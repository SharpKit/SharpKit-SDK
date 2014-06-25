using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.CodeDom.Compiler;

namespace SharpKit.ExtJs4.Generator
{
    class ExtDocModelGenerator
    {
        static void Generate(string[] args)
        {
            var dir = @"D:\Projects\JsParser\SharpKit.ExtJs4.Generator\output\";

            foreach (var filename in Directory.GetFiles(dir, "*.js"))
            {

                var code = File.ReadAllText(filename);
                var code2 = code.SubstringBetween(code.IndexOf("(") + 1, code.LastIndexOf(");"));
                var obj = new JavaScriptSerializer().Deserialize(code2, null) as Dictionary<string, object>;
                //var obj2 = new JavaScriptSerializer().Deserialize(code2, null) as Dictionary<string, object>;

                Assembly = new Assembly
                {
                    Usings = new List<string> 
                { 
                    "System",
                    "System.Collections.Generic",

                }
                };
                Context = new AssemblyContext
                {
                    //    ClassMappings = new Dictionary<string, string>
                    //{
                    //    {"Object", "object"},
                    //    {"Element", "Ext.Element"},
                    //    {"HTMLElement", "HtmlElement"},
                    //    {"Function", "JsAction"},
                    //    {"Array", "JsArray"},
                    //    {"String", "JsString"},
                    //    {"string", "JsString"},
                    //    {"Boolean", "bool"},
                    //    {"Number", "JsNumber"},
                    //    {"int", "JsNumber"},
                    //    {"Date", "JsDate"},
                    //    {"RegExp", "JsRegExp"},
                    //}
                };
                Context.Assemblies.Add(Assembly);
                var asm = new Assembly
                {
                    Classes = new List<Class>
                {
                    new Class{Name="void"},
                    new Class{Name="object"},
                    //new Class{Name="JsObject"},
                    //new Class{Name="HtmlElement"},
                    //new Class{Name="JsArray"},
                    //new Class{Name="JsAction"},
                    new Class{Name="bool"},
                    new Class{Name="string"},
                    new Class{Name="int"},
                }
                };
                Context.Assemblies.Add(asm);
                ObjectClass = Context.GetClass("object");


                var ce = GenerateClass(obj);
                var i = 0;
                Assembly.Classes.Where(t => t.Name.IsNullOrEmpty()).ForEach(t => t.Name = "Class" + i++);

                Assembly.Classes.ForEach(x =>
                {
                    var doubles = Assembly.Classes.Where(y => x != y && x.Members.TrueForAllTwice(y.Members, (mx, my) => mx.Name == my.Name)).ToList();
                    if (doubles.Count > 0)
                    {
                    }
                });

                var writer = new StringWriter();
                new CodeModelExporter { Assembly = Assembly, Writer = new IndentedTextWriter(writer) }.Export();
                //var block = new JsParser().Parse(code);
                File.WriteAllText("output.cs", writer.GetStringBuilder().ToString());
                return;
            }

        }
        static Class ObjectClass;
        static AssemblyContext Context;

        static Assembly Assembly;
        private static Class GenerateClass(object value)
        {
            if (value is Dictionary<string, object>)
            {
                var ce2 = GenerateClass(value as Dictionary<string, object>);
                return ce2;
            }
            else if (value is object[])
            {
                var list = value as object[];
                if (list.Length > 0)
                {
                    var ce2 = GenerateClass(list[0]);
                    return new Class { Name = "List`1", GenericArguments = new List<Class> { ce2 } };
                }
                else
                {
                    return new Class { Name = "List`1", GenericArguments = new List<Class> { ObjectClass } };
                }
            }
            else if (value is bool)
            {
                return Context.GetClass("bool");
            }
            else if (value == null)
            {
                return ObjectClass;
            }
            else if (value is string)
            {
                return Context.GetClass("string");
            }
            else if (value is int)
            {
                return Context.GetClass("int");
            }
            else
            {
            }
            return null;
        }
        private static Class GenerateClass(Dictionary<string, object> obj)
        {
            var ce = new Class();
            Assembly.Classes.Add(ce);
            foreach (var pair in obj)
            {
                var name = pair.Key;
                var value = pair.Value;
                var pe = new Property { Name = pair.Key };
                pe.Type = GenerateClass(value);
                ce.Members.Add(pe);
                if (pe.Type == null)
                {
                }
            }
            ce.Members = ce.Members.OrderBy(t => t.Name).ToList();
            return ce;
        }
    }

}
