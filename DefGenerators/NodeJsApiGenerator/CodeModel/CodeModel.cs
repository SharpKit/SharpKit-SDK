using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace SharpKit.ExtJs4.Generator
{
    class Class : Element
    {
        public Class()
        {
            Members = new List<Element>();
            GenericArguments = new List<Class>();
            Interfaces = new List<Class>();
        }
        public string Namespace { get; set; }
        public List<Class> GenericArguments { get; set; }
        public Class BaseClass { get; set; }
        public List<Class> Interfaces { get; set; }
        public List<Element> Members { get; set; }
        public string FullName
        {
            get
            {
                if (DeclaringClass != null)
                {
                    return DeclaringClass.FullName + "+" + Name;
                }
                if (Namespace.IsNotNullOrEmpty())
                    return Namespace + "." + Name;
                return Name;
            }
            set
            {
                var tokens = value.Split('.');
                Name = tokens.Skip(tokens.Length - 1).First();
                Namespace = tokens.Take(tokens.Length - 1).StringConcat(".");
            }
        }
        public override string ToString()
        {
            return FullName;
        }
        public bool IsInterface { get; set; }

        public bool IsDelegate { get; set; }
    }
    class Method : Element
    {
        public Method()
        {
            Parameters = new List<Parameter>();
        }
        public List<Parameter> Parameters { get; set; }

        public override string UniqueName
        {
            get
            {
                var name = base.UniqueName;
                var prms = Parameters.Select(t => t.Type.UniqueName).StringConcat(",");
                return name + "(" + prms + ")";
            }
        }
        public bool IsConstructor { get; set; }
    }
    class Parameter : Element
    {
        public bool IsOptional { get; set; }
    }
    class Field : Element
    {
        public string Initializer { get; set; }
    }
    class Property : Element
    {
        public bool IsReadOnly { get; set; }
    }
    class Event : Element
    {
    }
    class Element
    {
        public object Tag { get; set; }
        public Element()
        {
            Attributes = new List<Attribute>();
        }
        public bool IsStatic { get; set; }
        public Class DeclaringClass { get; set; }

        public Class Type { get; set; }
        public string Name { get; set; }
        //Lee
        public string returnValue { get; set; }
        public override string ToString()
        {
            return Name;
        }

        public List<Attribute> Attributes { get; set; }
        public string Summary { get; set; }
        public string Remarks { get; set; }


        public virtual string UniqueName
        {
            get
            {
                var name = Name;
                if (DeclaringClass != null)
                    name = DeclaringClass.UniqueName + "." + name;
                return name;
            }
        }
        public bool IsVirtual { get; set; }

        public bool IsOverride { get; set; }

        public bool IsNew { get; set; }

        public bool IsProtected { get; set; }

        public bool IsPrivate { get; set; }


    }
    class Assembly
    {
        public Assembly()
        {
            Classes = new List<Class>();
            Usings = new List<string>();
            Attributes = new List<Attribute>();
        }
        public List<Attribute> Attributes { get; set; }

        public List<Class> Classes { get; set; }
        public IEnumerable<Class> AllClasses
        {
            get
            {
                foreach (var ce in Classes)
                {
                    yield return ce;
                    foreach (var ce2 in ce.Members.OfType<Class>())
                        yield return ce2;
                }
            }
        }
        public Class GetClass(string fullName)
        {
            return AllClasses.Where(t => t.FullName == fullName).FirstOrDefault();
        }
        public List<string> Usings { get; set; }
    }

    class AssemblyContext
    {
        public AssemblyContext()
        {
            Assemblies = new List<Assembly>();
            ClassMappings = new Dictionary<string, string>();
        }
        public List<Assembly> Assemblies { get; set; }
        public Dictionary<string, string> ClassMappings { get; set; }
        public Class GetClass(string name)
        {
            name = ClassMappings.TryGetValue(name) ?? name;
            foreach (var asm in Assemblies)
            {
                var type = asm.GetClass(name);
                if (type != null)
                    return type;
            }
            return null;
        }
        public Class MakeGenericClass(Class ce, List<Class> genericArgs)
        {
            return new Class { Name = ce.Name, Namespace = ce.Namespace, GenericArguments = genericArgs };
        }
    }

    class Attribute
    {
        public Attribute()
        {
            Parameters = new List<string>();
            NamedParamters = new Dictionary<string, string>();
        }
        public Attribute Clone()
        {
            return new Attribute { Name = Name, Parameters = new List<string>(Parameters), NamedParamters = new Dictionary<string, string>(NamedParamters) };
        }
        public string Name { get; set; }
        public List<string> Parameters { get; set; }
        public Dictionary<string, string> NamedParamters { get; set; }
    }


    static class CodeModelExtensions
    {
        public static T Clone<T>(this T obj) where T : Element
        {
            var obj2 = new Cloner
            {
                ShouldDeepCloneObject = obj3 => !(obj3 is Class),
            }.Clone(obj);
            return (T)obj2;
        }


        public static bool HasEmptyConstructor(this Class ce)
        {
            return ce.GetEmptyConstructor()!=null;
        }
        public static Method GetEmptyConstructor(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t => t.IsConstructor && t.Parameters.Count == 0 && !t.IsStatic).FirstOrDefault();
        }
        public static bool HasAnyConstructor(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t => t.IsConstructor).FirstOrDefault() != null;
        }
        public static IEnumerable<Method> Methods(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t => !t.IsConstructor);
        }
        public static IEnumerable<Property> Properties(this Class ce)
        {
            return ce.Members.OfType<Property>();
        }
        public static IEnumerable<Method> Constructors(this Class ce)
        {
            return ce.Members.OfType<Method>().Where(t => t.IsConstructor);
        }
    }

    class Cloner
    {
        public Cloner()
        {
            ShouldCloneProperty = (obj, pe) => true;
            ShouldDeepCloneObject = obj => true;
        }
        public Func<object, PropertyInfo, bool> ShouldCloneProperty { get; set; }
        public Func<object, bool> ShouldDeepCloneObject { get; set; }
        public object Clone(object obj)
        {
            if (obj == null)
                return null;
            var type = obj.GetType();
            if (type.GetTypeCode() != TypeCode.Object)
                return obj;
            if (!ShouldDeepCloneObject(obj))
                return obj;
            var obj2 = Activator.CreateInstance(type);
            if (obj is IList)
            {
                var list = (IList)obj;
                var list2 = (IList)obj2;
                foreach (var item in list)
                {
                    list2.Add(Clone(item));
                }
            }
            else
            {
                foreach (var pe in type.GetProperties())
                {
                    if (pe.GetSetMethod() == null || !pe.GetSetMethod().IsPublic)
                        continue;
                    if (!ShouldCloneProperty(obj, pe))
                        continue;
                    var value = pe.GetValue(obj, null);
                    var value2 = Clone(value);
                    pe.SetValue(obj2, value2, null);
                }
            }
            return obj2;
        }

    }
}
