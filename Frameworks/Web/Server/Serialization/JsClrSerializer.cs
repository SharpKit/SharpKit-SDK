using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections;
using System.Reflection;

namespace SharpKit.Web.Server.Serialization
{
    public class JsClrSerializer
    {
        public JsClrSerializer()
        {
            KnownTypes = new List<Type>();
            KnownAssemblies = new List<Assembly>();
        }
        JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();
        public TextWriter Writer { get; set; }
        Dictionary<object, string> Refs = new Dictionary<object, string>();
        int RefIndex;
        /// <summary>
        /// Acts like JSON.stringify replacer - return the property value, or replace it with a different value, or null if you want to skip serialization
        /// </summary>
        public Func<object, PropertyInfo, object> Replacer { get; set; }
        public string Serialize(object obj)
        {
            if (obj == null)
                return "null";

            var type = obj.GetType();
            var typeCode = Type.GetTypeCode(type);
            if (typeCode == TypeCode.Object)
            {
                string objRef;
                if (Refs.TryGetValue(obj, out objRef))
                    return objRef;
                RefIndex++;
                objRef = "obj" + RefIndex;
                var typeGenericArgs = String.Join(",", type.GetGenericArguments().Select(t => Serialize(GetJsTypeName(t))).ToArray());
                Writer.WriteLine("var {0} = new {1}.ctor({2});", objRef, GetJsTypeName(type), typeGenericArgs);
                if (obj is IList)
                {
                    var list = obj as IList;
                    foreach (var item in list)
                    {
                        var itemRef = Serialize(item);
                        Writer.WriteLine("{0}.Add({1});", objRef, itemRef);
                    }
                }
                else
                {
                    var props = type.GetProperties();
                    foreach (var pe in props)
                    {
                        object value;
                        if (Replacer != null)
                            value = Replacer(obj, pe);
                        else
                            value = pe.GetValue(obj, null);
                        if (value == null)
                            continue;
                        var valueRef = Serialize(value);
                        Writer.WriteLine("{0}.set_{1}({2});", objRef, pe.Name, valueRef);
                    }
                }
                return objRef;
            }
            else
            {
                return JavaScriptSerializer.Serialize(obj);
            }
        }

        string GetJsTypeName(Type type)
        {
            if (type.IsGenericType)
            {
                return type.FullName.Replace("`", "$").Substring(0, type.FullName.IndexOf("["));
            }
            else
            {
                return type.FullName;
            }
        }

        Dictionary<string, object> DeRefs;

        public object Deserialize(string json)
        {
            DeRefs = new Dictionary<string, object>();
            var obj = JavaScriptSerializer.DeserializeObject(json);
            return Deserialize(obj, null);
        }
        object Deserialize(object obj, Type type)
        {

            if (obj is Dictionary<string, object>)
            {
                var dic = (Dictionary<string, object>)obj;
                var typeName = (string)dic.TryGetValue("$t");
                var listItems = (object[])dic.TryGetValue("$l");
                var ownRef = (string)dic.TryGetValue("$k");
                if (typeName != null)
                {
                    if (typeName == "ObjRef")
                    {
                        var extRef = (string)dic.TryGetValue("$r");
                        return DeRef(extRef);
                    }
                    type = ResolveType(typeName, type);
                    var obj2 = Activator.CreateInstance(type);
                    if (ownRef != null)
                        DeRefs[ownRef] = obj2;
                    foreach (var pair in dic)
                    {
                        if (pair.Key.StartsWith("$"))
                            continue;
                        var fieldOrProperty = FindFieldOrProperty(type, pair.Key);
                        if (fieldOrProperty.MemberType == MemberTypes.Field)
                        {
                            var field = (FieldInfo)fieldOrProperty;
                            var value2 = Deserialize(pair.Value, field.FieldType);
                            field.SetValue(obj2, value2);
                        }
                        else
                        {
                            var pe = (PropertyInfo)fieldOrProperty;
                            var value2 = Deserialize(pair.Value, pe.PropertyType);
                            pe.SetValue(obj2, value2, null);
                        }
                    }
                    if (listItems != null)
                    {
                        var list2 = (IList)obj2;
                        foreach (var item in listItems)
                        {
                            var item2 = Deserialize(item, type.GetEnumerableItemType());
                            list2.Add(item2);
                        }
                    }
                    return obj2;
                }
                else
                {
                    return obj;
                }
            }
            else if (obj is IList)
            {
                throw new Exception();
            }
            else
            {
                return obj;
            }
        }

        private object DeRef(string extRef)
        {
            var obj2 = DeRefs.TryGetValue(extRef);
            if (obj2 == null)
            {
                throw new Exception("Cannot find object with reference: " + extRef);
            }
            return obj2;
        }

        private static MemberInfo FindFieldOrProperty(Type type, string name)
        {
            var field = type.GetField(name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            if (field == null)
            {
                if (name.StartsWith("_"))
                {
                    var name2 = name.Substring(1);
                    var pe = type.GetProperty(name2, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                    if(pe==null)
                        throw new Exception("Cannot find field " + name + ", or property "+name2+" on type " + type);
                    return pe;
                }
                throw new Exception("Cannot find field " + name + " on type " + type);
            }
            return field;
        }

        public List<Type> KnownTypes { get; set; }
        public List<Assembly> KnownAssemblies { get; set; }
        private Type ResolveType(string typeName, Type type)
        {
            if (type != null && type.IsClass)
                return type;
            if (KnownTypes != null)
            {
                var type2 = KnownTypes.FirstOrDefault(t => t.FullName == typeName);
                if (type2 != null)
                    return type2;
            }
            if (KnownAssemblies != null)
            {
                foreach (var asm in KnownAssemblies)
                {
                    var type2 = asm.GetType(typeName, false);
                    if (type2 != null)
                        return type2;
                }
            }
            var type3 = Type.GetType(typeName, true);
            return type3;
        }


    }

    static class Extensions
    {
        public static Type GetEnumerableItemType(this Type type)
        {
            var iface = type.GetInterface(typeof(IEnumerable<>).FullName);
            if (iface == null)
                return null;
            return iface.GetGenericArguments()[0];
        }
        public static T TryGetValue<K, T>(this Dictionary<K, T> dic, K key)
        {
            T value;
            dic.TryGetValue(key, out value);
            return value;
        }
    }
}
