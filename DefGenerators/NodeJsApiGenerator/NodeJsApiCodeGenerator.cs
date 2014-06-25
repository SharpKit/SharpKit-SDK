using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.CodeDom.Compiler;
using SharpKit.ExtJs4.Generator;

namespace NodeJsApiGenerator
{
    class YuiCodeGenerator
    {
       
        public YuiCodeGenerator()
        {
            Context = new AssemblyContext();
            Assembly = new Assembly
            {
                Usings = new List<string> 
                    { 
                        "System",
                        "System.Collections.Generic",
                    }
            };
            Context.Assemblies.Add(Assembly);
            var asm = new Assembly
            {
                Classes = new List<Class>
                {
                    new Class{Name="void"},
                    new Class{Name="object"},
                    new Class{Name="bool"},
                    new Class{Name="string"},
                    new Class{Name="int"},
                    new Class{Name="Function", IsDelegate=true},
                }
            };
            Context.Assemblies.Add(asm);
            ObjectClass = Context.GetClass("object");
        }

        public object DataJson { get; set; }

        public void Generate()
        {
            var modules = DataJson.GetValues("modules");
            foreach (var module in modules)
            {
                var classes = module.GetValues("classes").NotNull();
                foreach (var ce2 in classes)
                {
                    var ce = GenerateClass(ce2);
                    var members = ce2.GetValues("methods").NotNull();
                    foreach (var me in members)
                    {
                        GenerateMember(ce, me);
                    }
                }
            }
            foreach (var ce in Assembly.Classes)
            {
                var baseClassName = ce.Tag.Get<string>("extends");
                if (baseClassName != null)
                {
                    ce.BaseClass = FindClass(baseClassName);
                    if (ce.BaseClass == null)
                    {
                        Console.WriteLine("Warning: base class: {0} was not found", baseClassName);
                       
                    }
                }
            }


        }

        private Class GenerateClass(object node)
        {
            var names = node.GetNames();
            var ce = new Class
            {
                FullName = node.Get<string>("name"),
                Tag = node,
            };
            ImportDocumentation(ce, node);
            Assembly.Classes.Add(ce);
            return ce;
        }

        void ImportDocumentation(Element el, object node)
        {
            var desc = node.Get<string>("desc");
            el.Summary = desc;
        }

        private void GenerateMember(Class ce, object node)
        {
            var signatures = node.GetValues("signatures");
            if (signatures.IsNullOrEmpty())
            {
                GenerateMember(ce, node, null);
            }
            else
            {
                foreach (var signature in signatures)
                {
                    GenerateMember(ce, node, signature);

                }
            }
        }
        private void GenerateMember(Class ce, object node, object signature)
        {
            var names = node.GetNames();
            var itemType = node.Get<string>("type");
            var name = node.Get<string>("name");
            var access = node.Get<string>("access");
            if (name.IsNullOrEmpty())
            {
                Console.WriteLine("Warning: empty name " + name);
                return;
            }
            var className = node.Get<string>("class");
            var type = "object";// node.Get<string>("type");
            //var ce = FindClass(className);
            if (ce == null)
            {
                Console.WriteLine("Warning: Can't find class: " + className);
                return;
            }
            Element me2 = null;
            if (itemType == "attribute" || itemType == "property")
            {
                var isReadOnly = node.Get<string>("readonly") != null;
                if (type.IsNullOrEmpty())
                {
                    type = "object";
                    Console.WriteLine("Warning: type is null: " + className + "." + name + " assuming object");
                    //return;
                }
                var pe = new Property
                {
                    Name = name,
                    Type = FindClass(type),
                };
                pe.IsReadOnly = isReadOnly;
                if (Char.IsDigit(pe.Name[0]))
                {
                    Console.WriteLine("Warning: Invalid name " + pe.Name);
                    return;
                }
                if (pe.Type == null)
                {
                    Console.WriteLine("Warning: type is null");
                    return;
                }

                ce.Members.Add(pe);
                if (itemType == "attribute")
                {
                    var ctor = ce.GetEmptyConstructor();
                    if (ctor == null)
                    {
                        ctor = new Method
                        {
                            IsConstructor = true,
                            Name=".ctor",
                        };
                        ce.Members.Add(ctor);
                    }
                    var att = ctor.Attributes.Where(t => t.Name == "JsMethod").FirstOrDefault();
                    if (att == null)
                    {
                        att = new SharpKit.ExtJs4.Generator.Attribute
                        {
                            Name = "JsMethod",
                            NamedParamters = new Dictionary<string, string> { { "JsonInitializers", "true" } },
                        };
                        ctor.Attributes.Add(att);
                    }
                }
                me2 = pe;
            }
            else if (itemType == "method")
            {
                var prms = signature.GetValues("params");
                var returnType = "object";// node.GetValues("return");
                var me = new Method
                {
                    Name = name,
                    //Type = FindClass(node.Get<string>("desc"))
                    //Type = FindClass(type),
                };
                if (me.Name == ce.Name)
                {
                    me.IsConstructor = true;
                    returnType = null;
                }
                if (prms != null)
                    me.Parameters = prms.Select(GenerateParameter).ToList();
                if (me.Parameters.Contains(null))
                {
                    Console.WriteLine("Warning: prms contains nulls:" + className + "." + name);
                    return;
                }
               
                if (returnType != null)
                {
                    //var returnType = returns.LastOrDefault() as string;
                    //returnType = returnType.Split('|').FirstOrDefault().Trim();
                    me.Type = FindClass(returnType);
                    if (me.Type == null)
                    {
                        Console.WriteLine("Cannot resolve method return type: " + className + "." + name);
                        me.Type = ObjectClass;
                    }
                }

                ce.Members.Add(me);
                me2 = me;
            }
            if (me2 != null)
            {
                if (access.IsNullOrEmpty())
                {
                }
                else if (access == "protected")
                    me2.IsProtected = true;
                else if (access == "private")
                    me2.IsPrivate = true;
                else if (access == "public")
                {
                }
                else
                {
                }
                ImportDocumentation(me2, node);

            }
        }

        Parameter GenerateParameter(object node)
        {
            var names = node.GetNames();
            var prm = new Parameter
            {
                Name = node.Get<string>("name"),
                Type = FindClass(node.Get<string>("type")),
                IsOptional = node.Get("optional") != null,
            };
            //if (prm.Type == null || prm.Name.IsNullOrEmpty())
              //  return null;

            prm.Type = ObjectClass;
                        return prm;
        }

        Class FindClass(string name, bool throwIfNotFound = false)
        {
            if (name.IsNullOrEmpty())
                return null;
            var ce = Context.GetClass(name);
            if (ce == null)
            {
                foreach (var asm in Context.Assemblies)
                {
                    ce = asm.Classes.Where(t => t.Name == name).FirstOrDefault();
                    if (ce != null)
                        return ce;
                }

            }
            if (throwIfNotFound)
                throw new Exception("Class " + name + " was not found");
            return ce;
        }

        void ReplaceType(Class a, Class b)
        {
            foreach (var ce in Assembly.AllClasses)
            {
                ce.Members.Where(t => t.Type == a).ForEach(t => t.Type = b);
                foreach (var me in ce.Methods())
                {
                    me.Parameters.Where(t => t.Type == a).ForEach(t => t.Type = b);
                }
            }
        }
        public void Finalize2()
        {
            foreach (var ce in Assembly.Classes)
            {
                ce.Members.RemoveAll(t => t.IsPrivate);
            }


            FixOptionalParameters();

            Assembly.Classes.ForEach(t => t.Members.ForEach(m => m.DeclaringClass = t));

            //Assembly.GetClass("YUI").Attributes.Add(new SharpKit.ExtJs4.Generator.Attribute
            //{
            //    Name="JsType", 
            //    Parameters = new List<string>{"JsMode.Prototype"},
            //    NamedParamters=new Dictionary<string,string>{{"Name", "\"YUI\""}},
            //});
            //var ceYuiObj = Assembly.GetClass("Object");
            //ceYuiObj.Name = "YuiObject";
            //ReplaceType(ceYuiObj, ObjectClass);
            FindClass("Function").Name = "JsAction";
            var dicNs = new Dictionary<string, string>();
            foreach (var ce in Assembly.Classes)
            {
                if (ce.Namespace.IsNullOrEmpty())
                    ce.Namespace = "SharpKit.NodeJs";
                else
                    ce.Namespace = "SharpKit.NodeJs." + ce.Namespace;
                var ns = ce.Namespace;

                //ce.Namespace = ce.Namespace.Split('.').Select(t => t + "_").StringConcat(".");
                //dicNs[ce.Namespace] = ns;
                ce.Name = Identifier(ce.Name);
                foreach (var me in ce.Methods())
                {
                    me.Parameters.Where(t => t.Type == null).ForEach(t => t.Type = ObjectClass);
                    me.Parameters.Where(t => t.Name.IsNullOrEmpty()).ForEach(t => t.Name = "Undocumented");
                }

               
                var doubles = ce.Members.RemoveDoublesByKey(t => t.UniqueName);
                foreach (var d in doubles)
                {
                    Console.WriteLine("Warning: removed double: {0}", d);
                    
       
                  
                }
                foreach (var group in ce.Members.GroupBy(t => t.Name))
                {
                   
                    var toRemove = group.GroupBy(t => t.GetType()).Skip(1).Ungroup();
                    foreach (var me in toRemove)
                    {
                        Console.WriteLine(" Warning: removed double: {0}", me.UniqueName);
                        ce.Members.Remove(me);
                         
                    }
                }
                foreach (var me in ce.Members)
                {
                    me.Name = Identifier(me.Name);
                }
                foreach (var me in ce.Methods())
                {
                    me.Parameters.ForEach(t => t.Name = Identifier(t.Name));
                    foreach (var group in me.Parameters.GroupBy(t => t.Name))
                    {
                        foreach (var prm in group.Skip(1))
                            prm.Name += "_";
                    }
                }
            }
            Assembly.Usings.Add("SharpKit.JavaScript");
            foreach (var ns in dicNs)
            {
                Assembly.Attributes.Add(new SharpKit.ExtJs4.Generator.Attribute
                {
                    Name = "assembly: JsNamespace",
                    NamedParamters = new Dictionary<string, string> { { "Namespace", StringLiteral(ns.Key) }, { "JsNamespace", StringLiteral(ns.Value ?? "") } }
                });
            }
            Assembly.Classes = Assembly.Classes.OrderBy(t => t.Name).ToList();
            foreach (var ce in Assembly.AllClasses)
            {
                ce.Members = ce.Members.OrderBy(t => t.GetType().Name).ThenBy(t => t.UniqueName).ToList();
            }
            //Assembly.GetClass("YUI").Name = "YUIClass";

        }
        static string StringLiteral(string s)
        {
            return String.Format("\"{0}\"", s);
        }
        public void Save(string outDir)
        {
            //var writer = new StringWriter();
            new CodeModelExporter { Assembly = Assembly, OutputDir = outDir, RootNamespace="SharpKit.NodeJs" }.Export();
            //File.WriteAllText(outFilename, writer.GetStringBuilder().ToString());

        }
        Class ObjectClass;
        AssemblyContext Context;

        string Identifier(string s)
        {
            if (Char.IsDigit(s[0]))
                s = "_" + s;
            return s.Replace("~", "_").Replace(".", "_").Replace(",", "_").Replace("*", "_").Replace("/", "_").Replace("{", "_").Replace("}", "_").Replace("+", "_");
        }
        Assembly Assembly;

        void FixOptionalParameters()
        {
            foreach (var ce in Assembly.AllClasses)
            {
                foreach (var me in ce.Methods().ToArray())
                {
                    var optionalParameters = me.Parameters.Where(t => t.IsOptional).ToList();
                    if (optionalParameters.Count > 0)
                    {
                        optionalParameters.ForEach(t => t.IsOptional = false);
                        AddOptionalOverloads(ce, me, optionalParameters);
                    }
                }
            }
        }
        private static void AddOptionalOverloads(Class ce, Method me, List<Parameter> optionalParameters)
        {
            foreach (var prm in optionalParameters.ToArray())
            {
                var me2 = me.Clone();
                me2.Parameters.Remove(me2.Parameters.Where(t => t.Name == prm.Name).First());
                ce.Members.Add(me2);
                var op2 = optionalParameters.ToArray().ToList();
                op2.Remove(prm);
                AddOptionalOverloads(ce, me2, op2);
            }
        }

    }

}
