using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;
using System.Collections;

namespace SharpKit.JsClr.Utils
{
    [JsType(Filename = "~/res/System.Ext.js")]
    public class JsClrClientSerializer
    {
        public JsClrClientSerializer()
        {
            ObjInfos = new Dictionary<object, ObjInfo>();
            IgnoreFields = new JsObject<bool>();
            IgnoreFields["_type"] = true;
            IgnoreFields["_hashKey"] = true;
        }
        public JsString Serialize(object obj)
        {
            var obj2 = Serialize2(obj);
            return JSON.stringify(obj2);
        }

        Dictionary<object, ObjInfo> ObjInfos;

        object Serialize2(object obj)
        {
            if (obj.ExactEquals(JsContext.undefined))
                return JsContext.undefined;
            if (obj.ExactEquals(null))
                return null;
            var jsType = JsContext.JsTypeOf(obj);
            if (jsType == JsTypes.@object)
            {
                return SerializeRefOrContent(obj);
            }
            else if (jsType == JsTypes.function)
            {
                return JsContext.undefined;
            }
            else
            {
                return obj;
            }
        }

        int RefIndex;
        TypedObj SerializeRefOrContent(object obj)
        {
            if (!ObjInfos.ContainsKey(obj))
            {
                var info = new ObjInfo();
                ObjInfos.Add(obj, info);
                SerializeFirstRef(obj, info);
                return info.FirstRef;
            }
            else
            {
                var info = ObjInfos[obj];
                if (info.Ref == null)
                {
                    RefIndex++;
                    info.Ref = new ObjRef { Key = RefIndex.ToString(), Type="ObjRef" };
                    info.FirstRef.RefKey = info.Ref.Key;
                }
                return info.Ref;
            }
        }

        JsObject<bool> IgnoreFields;
        private ReferencedObj SerializeFirstRef(object obj, ObjInfo info)
        {
            var obj2 = new ReferencedObj();
            info.FirstRef = obj2;
            var type = obj.GetType();
            obj2.Type = type.FullName;
            var obj3 = obj.As<JsObject>();
            if (obj is IList)
            {
                var list = obj.As<IList>();
                obj2.ListItems = new JsArray();
                foreach (var item in list)
                {
                    var item2 = Serialize2(item);
                    obj2.ListItems.push(item2);
                }
            }
            else
            {
                foreach (var p in obj3)
                {
                    if (IgnoreFields[p])
                        continue;
                    if (!obj3.hasOwnProperty(p))
                        continue;
                    var value = obj3[p];
                    obj2[p] = Serialize2(value);
                }
            }
            return obj2;
        }


    }


    [JsType(JsMode.Json)]
    class TypedObj : JsObject
    {
        [JsProperty(Name="$t", NativeField=true)]
        public string Type { get; set; }
    }

    [JsType(JsMode.Json)]
    class ReferencedObj : TypedObj
    {
        [JsProperty(Name = "$k", NativeField = true)]
        public string RefKey { get; set; }
        [JsProperty(Name = "$l", NativeField = true)]
        public JsArray ListItems { get; set; }
    }

    [JsType(JsMode.Json)]
    class ObjInfo
    {
        public ReferencedObj FirstRef { get; set; }
        public ObjRef Ref { get; set; }
    }

    [JsType(JsMode.Json)]
    class ObjRef : TypedObj
    {
        [JsProperty(Name = "$r", NativeField = true)]
        public string Key { get; set; }
    }
}
