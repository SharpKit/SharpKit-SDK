using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//using System.Web.Script.Serialization;
using System.CodeDom.Compiler;
using SharpKit.TinyMCE.Generator;
using System;
using System.Xml;
using System.Web;

namespace TinyMCEApiGenerator
{

    public class TinyMCECodeGenerator
    {
        public const string TinyMCENamespace = "TinyMCE";
        public const string TinyMCENamespaceNS = "TinyMCE_Support";


        public TinyMCECodeGenerator()
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
                    new Class{Name="Array"},
                    new Class{Name="int"},
                    new Class{Name="Function", IsDelegate=true},
                }
            };
            Context.Assemblies.Add(asm);
            ObjectClass = Context.GetClass("object");
        }

        public XmlDocument DataXml { get; set; }




        public void Generate()
        {
            XmlNode rootNode = DataXml.SelectSingleNode("//model");

            if (rootNode == null)
                throw new NotSupportedException("Schema does not match.");

            NavigateNamespaces(rootNode);
        }



        private void NavigateNamespaces(XmlNode node)
        {
            var namespaces = node.SelectNodes("namespace");

            foreach (XmlNode nsNode in namespaces)
            {
                DoLog("Navigating namespace fullname[{0}] name[{1}]", nsNode.Attributes["fullname"].Value, nsNode.Attributes["name"].Value);

                /// 
                /// NAMESPACES COULD BE NESTED. 
                /// 
                NavigateNamespaces(nsNode);

                NavigateClasses(nsNode);
            }

            NavigateClasses(node);
        }




        private void NavigateClasses(XmlNode namespaceNode)
        {
            var classes = namespaceNode.SelectNodes("class");

            foreach (XmlNode classNode in classes)
            {
                var cs = GenerateClass2(namespaceNode, classNode);

                DoLog("Generating class fullname[{0}] name[{1}]", classNode.Attributes["fullname"].Value, classNode.Attributes["name"].Value);

                NavigateMembers(cs, classNode);
            }
        }




        private void NavigateMembers(Class cs, XmlNode classNode)
        {
            XmlNodeList members = classNode.SelectNodes("members");

            if (members.Count > 1)
                throw new NotSupportedException("Found more than one 'members' collection on the class node.");

            foreach (XmlNode memberNode in members[0].ChildNodes)
            {
                GenerateMember2(cs, memberNode);
            }
        }



        private Class GenerateClass2(XmlNode namespaceNode, XmlNode classNode)
        {
            bool isNamespace = string.Equals(namespaceNode.Name, "namespace", StringComparison.OrdinalIgnoreCase);

            string nsName = (isNamespace) ? namespaceNode.Attributes["fullname"].Value : "";

            if (string.Equals(nsName, TinyMCENamespace, StringComparison.OrdinalIgnoreCase))
                nsName = TinyMCENamespaceNS;
            else if (nsName.StartsWith(TinyMCENamespace + ".", StringComparison.OrdinalIgnoreCase))
                nsName = TinyMCENamespaceNS + nsName.Substring(TinyMCENamespace.Length);
            else if (string.IsNullOrEmpty(nsName)) nsName = TinyMCENamespace;


            var ce = new Class
            {
                FullName = classNode.Attributes["name"].Value,
                Namespace = nsName,
                Tag = classNode,
            };

            CheckIsStatic(classNode, ce);

            ImportDocumentation2(ce, classNode, "summary");
            Assembly.Classes.Add(ce);
            return ce;
        }




        void ImportDocumentation2(Element el, XmlNode node, string docName)
        {
            var summary = node.Attributes[docName].Value;
            el.Summary = summary;
        }


        void ImportDocumentation3(Element el, XmlNode node)
        {
            XmlNode documentationNode = node.SelectSingleNode("description");
            if (documentationNode != null)
                el.Summary = documentationNode.InnerText.Trim();
        }



        private void GenerateMember2(Class ce, XmlNode memberNode)
        {
            var itemType = memberNode.Name;// node.Get<string>("type");

            var name = memberNode.Attributes["name"].Value;
            var accessNode = memberNode.Attributes["access"];
            var access = (accessNode != null) ? accessNode.Value : null;

            DoLog(">> Processing Item [{0}] - Name[{1}]", itemType, name);

            if (itemType == "attribute" || itemType == "property")
            {
                if (memberNode.Attributes["inherited-from"] != null)
                {
                    /// 
                    /// THIS PROPERTY IS INHERITED.
                    /// WE ARE IGNORING IT FOR THE TIME BEING.
                    /// 
                    /// 
                }
                else
                {
                    var pe = new Property
                    {
                        Name = memberNode.Attributes["name"].Value,
                        TypeName = memberNode.Attributes["type"].Value,
                        IsReadOnly = false  // TINYMCE DOES NOT HAVE READ ONLY PROPERTIES.
                    };

                    ImportDocumentation2(pe, memberNode, "summary");

                    ce.Members.Add(pe);

                    CheckIsStatic(memberNode, ce);

                }
            }
            else if (itemType == "method")
            {
                var returnType = "object";// node.GetValues("return");

                XmlNode returnTypeNode = memberNode.SelectSingleNode("return");

                if (returnTypeNode != null)
                {
                    /// 
                    /// THERE CAN BE MORE THAN ONE RETURN TYPE ~_~
                    /// GO FIGURE 1
                    /// 

                    XmlNodeList allReturnTypes = returnTypeNode.SelectNodes("type");
                    if (allReturnTypes.Count > 0)
                    {
                        /// 
                        /// USING ONLY THE FIRST RETURN VALUE !
                        /// IGNORING THE REST.
                        /// 
                        returnType = allReturnTypes[0].Attributes["fullname"].Value;
                    }
                    else
                    {
                        returnType = returnTypeNode.Attributes["type"].Value;
                    }
                }


                var me = new Method
                {
                    Name = name,
                    //Type = FindClass(type),
                };

                if (me.Name == ce.Name)
                {
                    me.IsConstructor = true;
                    returnType = null;
                }

                foreach (XmlNode paramNode in memberNode.SelectNodes("param"))
                {
                    Parameter param = GenerateParameter2(paramNode);

                    if (param != null)
                    {
                        me.Parameters.Add(param);

                        ImportDocumentation3(param, paramNode);
                    }
                }


                if (returnType != null)
                {
                    //me.Type = FindClass(returnType);
                    me.TypeName = returnType;
                }

                ImportDocumentation3(me, memberNode);

                CheckIsStatic(memberNode, me);

                ce.Members.Add(me);
            }
            else if (itemType == "event")
            {
                var evnt = new Event
                {
                    Name = name,
                    TypeName = "object",
                    //DeclaringClass = ce
                    //Parameters = FindClassOrObject("JsAction")
                };

                //foreach (XmlNode paramNode in memberNode.SelectNodes("param"))
                //{
                //    Parameter param = GenerateParameter2(paramNode);

                //    if (param != null)
                //        evnt.Parameters.Add(param);
                //}

                ImportDocumentation3(ce, memberNode);

                //ce.Members.Add(evnt);
            }


            /// 
            /// THERE ARE NO ACCESS MODIFIERS ON TINY-MCE,
            /// THEREFORE, ALL THE MEMBERS ARE "PUBLIC"
            /// 

        }




        Parameter GenerateParameter2(XmlNode node)
        {
            var prm = new Parameter
            {
                Name = node.Attributes["name"].Value,
                IsOptional = false,  // THERE ARE NO "OPTIONAL" FLAGS IN THE MODEL.XML
            };


            XmlNodeList signatures = node.SelectNodes("type");

            if (signatures.Count > 0)
            {
                /// OOPSY DAISY... THIS PARAMETER HAS MORE THAN ONE TYPE ACCEPTED !
                /// USING ONLY THE FIRST TYPE, IGNORING THE REST.
                /// 
                prm.TypeName = signatures[0].Attributes["fullname"].Value;
                return null;
            }
            else
            {
                prm.TypeName = node.Attributes["type"].Value;
            }

            XmlNode summary = node.SelectSingleNode("description");

            if (summary != null)
                prm.Summary = summary.InnerText;

            return prm;
        }


        private void FindClassOrObject(Element e)
        {
            try
            {
                e.Type = FindClass2(e.TypeName);
            }
            catch (Exception x)
            {
                DoLog("Assigning object-type to member [{0}] - TypeName [{1}]", e.ToString(), e.TypeName);
                e.Type = ObjectClass;
            }

        }


        Class FindClass2(string name)
        {
            if (string.Equals(name, "Boolean", StringComparison.OrdinalIgnoreCase)) name = "bool";

            if (name.IsNullOrEmpty())
                return null;
            var ce = Context.GetClass(name);
            if (ce == null)
            {
                foreach (var asm in Context.Assemblies)
                {
                    ce = asm.Classes.Where(t => string.Equals(t.FullName, name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                    if (ce != null)
                        return ce;
                }

            }

            /// DOING A NON-FULLNNAME SEARCH. THIS IS NOT AS GOOD BECAUSE IT CAN RETURN MORE THAN ONE CLASS...
            if (ce == null)
            {
                foreach (var asm in Context.Assemblies)
                {
                    var classes = asm.Classes.Where(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase));

                    if (classes.Count() > 1)
                    {
                        DoLog("Found more than one class when doing a non fullname search for [{0}]", name);
                    }

                    ce = classes.FirstOrDefault();

                    if (ce != null) return ce;
                }
            }


            if (ce == null)// && throwIfNotFound)
                throw new Exception("Class " + name + " was not found");

            return ce;
        }


        private void CheckIsStatic(XmlNode node, Element e)
        {
            XmlAttribute staticAttrib = node.Attributes["static"];

            if (staticAttrib != null && string.Equals(staticAttrib.Value, "true", StringComparison.OrdinalIgnoreCase))
                e.IsStatic = true;
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


            Assembly.Classes.ForEach(clss =>
            {

                List<Method> removeList = new List<Method>();

                clss.Members.ForEach(m =>
                    {
                        m.DeclaringClass = clss;

                        /// MAKING THE METHODS OF A STATIC CLASS, STATIC AS WELL.
                        /// 
                        if (m.DeclaringClass.IsStatic)
                        {
                            m.IsStatic = true;
                            Method meth = m as Method;
                            if (meth != null && meth.IsConstructor)
                            {
                                /// WE NEED TO REMOVE CONSTRUCTORS FROM STATIC CLASSES.
                                /// 
                                removeList.Add(meth);
                            }
                        }


                    });

                removeList.ForEach(m => clss.Members.Remove(m));

                string jsNamespace = null;

                List<string> ns = clss.Namespace.Split(new char[] { '.' }).ToList();

                string csNamespace = clss.Namespace;

                if (string.Equals(ns[0], TinyMCENamespace))
                {
                    ns.RemoveAt(0);
                }
                else if (string.Equals(ns[0], TinyMCENamespaceNS))
                {
                    ns[0] = TinyMCENamespace;
                    csNamespace = string.Join(".", ns.ToArray());

                    ns[0] = TinyMCENamespace.ToLower();
                }

                jsNamespace = string.Join(".", ns.ToArray());

                if (!string.IsNullOrEmpty(jsNamespace)) jsNamespace += ".";

                jsNamespace += clss.Name;

                clss.Namespace = csNamespace;
                clss.Attributes.Add(new SharpKit.TinyMCE.Generator.Attribute
                {
                    Name = "JsType",
                    Parameters = new List<string>() { "JsMode.Prototype" },
                    NamedParamters = new Dictionary<string, string> { { "Name", "\"" + jsNamespace + "\"" }, { "Export", "false" } }
                });

            });

            

            //Assembly.GetClass("YUI").Attributes.Add(new SharpKit.ExtJs4.Generator.Attribute
            //{
            //    Name="JsType", 
            //    Parameters = new List<string>{"JsMode.Prototype"},
            //    NamedParamters=new Dictionary<string,string>{{"Name", "\"YUI\""}},
            //});
            //var ceYuiObj = Assembly.GetClass("Object");
            //ceYuiObj.Name = "YuiObject";
            //ReplaceType(ceYuiObj, ObjectClass);
            
            FindClass2("Function").Name = "JsAction";

            var dicNs = new Dictionary<string, string>();

            foreach (var ce in Assembly.Classes)
            {
                foreach (var m in ce.Members)
                {
                    FindClassOrObject(m);

                    Method met = m as Method;
                    if (met != null)
                    {
                        foreach (var p in met.Parameters)
                        {
                            FindClassOrObject(p);
                        }
                    }

                    /// WE ARE INTERESTED IN THE TYPES OF PROPERTIES AND PARAMETERS.
                    /// CLASSES AND EVENTS ARE A TYPE IN ITSELF.
                    /// 
                    //if (m.GetType() == typeof(Property) || m.GetType() == typeof(Parameter) || m.GetType() == typeof(Method))
                    //    m.Type = FindClass2(m.TypeName);
                }
            }


            foreach (var ce in Assembly.Classes)
            {
                if (ce.Namespace.IsNullOrEmpty())
                {
                    throw new NotSupportedException("A namespace is required");
                    //ce.Namespace = "SharpKit." + TinyMCENamespace;
                }
                else
                    ce.Namespace = "SharpKit." + ce.Namespace;

                var ns = ce.Namespace;

                //ce.Namespace = ce.Namespace.Split('.').Select(t => t + "_").StringConcat(".");
                //dicNs[ce.Namespace] = ns;
                ce.Name = Identifier(ce.Name);
                //foreach (var me in ce.Methods())
                //{
                //    me.Parameters.Where(t => t.Type == null).ForEach(t => t.Type = ObjectClass);
                //    me.Parameters.Where(t => t.Name.IsNullOrEmpty()).ForEach(t => t.Name = "Undocumented");
                //}

                foreach (var me in ce.Members)
                {
                    DoLog("-- {0}", me.UniqueName);
                }


                var doubles = ce.Members.RemoveDoublesByKey(t => t.UniqueName);
                foreach (var d in doubles)
                    Console.WriteLine("Warning: removed double: {0}", d);
                foreach (var group in ce.Members.GroupBy(t => t.Name))
                {
                    var toRemove = group.GroupBy(t => t.GetType()).Skip(1).Ungroup();
                    foreach (var me in toRemove)
                    {
                        Console.WriteLine("Warning: removed double: {0}", me.UniqueName);
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
                Assembly.Attributes.Add(new SharpKit.TinyMCE.Generator.Attribute
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
        public void Save(string outDir, bool singleFile)
        {
            //var writer = new StringWriter();
            new CodeModelExporter { Assembly = Assembly, OutputDir = outDir, RootNamespace = "SharpKit", SingleFile = singleFile }.Export();
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


        public LogDelegate Logger { get; set; }

        public delegate void LogDelegate(string msg);

        private void DoLog(string msg, params object[] prms)
        {
            if (Logger != null) Logger(string.Format(msg + "", prms));
        }
    }

}
