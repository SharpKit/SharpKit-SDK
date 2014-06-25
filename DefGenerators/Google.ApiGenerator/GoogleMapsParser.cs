using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using SharpKit.Html;

namespace SharpKit.Google.ApiGenerator
{
    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js")]
    public class GoogleMapsParser
    {
        CodeWriter Writer;
        Assembly Assembly;
        public void OnLoad()
        {
            Assembly = new Assembly();
            Writer = new CodeWriter();
            var body = new jQuery.jQuery(HtmlContext.document.body);
            foreach (var ch in body.children("h2"))
            {
                var ce = ParseClass(ch);
                Assembly.Classes.Add(ce);
            }
            FixAssembly();
            Writer.WriteLine(@"using System;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Google.Maps
{");

            GenerateCode();
            var code = Writer.ToString();
            var pre = new jQuery.jQuery("#Output");
            pre.val(code).remove();
            body[0].insertBefore(pre[0], body[0].firstChild);
            Writer.WriteLine("}");

        }

        private void FixAssembly()
        {
            foreach (var ce in Assembly.Classes)
            {
                foreach (var me in ce.Members)
                {
                    FixType(me.Type);
                    if (me is Method)
                    {
                        var me2 = (Method)me;
                        foreach (var prm in me2.Parameters)
                        {
                            FixType(prm.Type);
                        }
                    }
                }
            }
        }
        static void FixType(Class ce)
        {
            if (ce.Name.Contains("|"))
                ce.Name = "object";
            ce.Name = ce.Name
                .replace("*", "object")
                .replace("number", "JsNumber")
                .replace("boolean", "bool")
                .replace("number", "JsNumber")
                .replace("Array.", "JsArray")
                .replace("Object.", "JsObject")
                .replace("MVCArray.", "MVCArray")
                .replace("MVCJsArray.", "MVCArray");

            if (ce.Name == "None")
                ce.Name = "void";
            //if (ce.Name.Contains("*"))
            //    ce.Name = ce.Name.replace("*", "object");
            //if (ce.Name.Contains("|"))
            //    ce.Name = "object";
            //if (ce.Name == "number")
            //    ce.Name = "JsNumber";
            //if (ce.Name == "*")
            //    ce.Name = "object";
            //if (ce.Name == "boolean")
            //    ce.Name = "bool";

            //if (ce.Name.Contains("Array."))
            //    ce.Name = ce.Name
            //if (ce.Name == "number")
            //    ce.Name = "JsNumber";
            //if (ce.Name.StartsWith("Object."))
            //    ce.Name = ce.Name.replace("Object\\.", "JsObject<") + ">";
        }


        private string GetDefaultValueCode(Class ce)
        {
            if (ce == null || ce.Name == "void")
                return "";
            if (ce.Name == "bool")
                return "false";
            return "null";
        }
        private void GenerateCode()
        {
            foreach (var ce in Assembly.Classes)
            {
                WriteAttributes(ce);
                Writer.WriteLine("class " + ce.Name);
                Writer.BeginBlock();
                foreach (var me in ce.Members)
                {
                    if (me is Method)
                    {
                        var me2 = me.As<Method>();
                        WriteDescription(me);
                        Writer.Write("public " + me.Type.Name + " " + me.Name + "(");
                        Writer.Write(me2.Parameters.JsSelect(t => t.Type.Name + " " + t.Name + (t.IsOptional ? ("=" + GetDefaultValueCode(t.Type)) : "")).join(", "));
                        Writer.Write(")");
                        if (me2.IsConstructor || me2.Type == null || me2.Type.Name == "void")
                            Writer.WriteLine("{}");
                        else
                            Writer.WriteLine("{return " + GetDefaultValueCode(me2.Type) + ";}");
                    }
                    else if (me is Property)
                    {
                        var pe = me.As<Property>();
                        WriteDescription(pe);
                        Writer.WriteLine("public " + (pe.IsStatic ? "static " : "") + me.Type.Name + " " + me.Name + "{get; set;}");
                    }
                }
                Writer.EndBlock();
            }
        }

        private void WriteAttributes(Class ce)
        {
            foreach (var att in ce.Attributes)
                Writer.WriteLine(att.Code);

        }
        private void WriteDescription(Member me)
        {
            if (me.Description == null || me.Description.length == 0)
                return;
            Writer.WriteLine("/// <summary>");
            foreach (var line in me.Description.split('\n'))
            {
                Writer.WriteLine("///" + line);
            }
            Writer.WriteLine("/// </summary>");
        }

        private static Class ParseClass(HtmlElement ch)
        {
            var fullName = ch.ToJQuery().text();
            var isClass = fullName.Contains("class");
            var isJson = fullName.Contains("object specification");
            fullName = fullName.RemoveLast("class").RemoveLast("object specification").RemoveWhitespace();
            var tokens = fullName.split('.');
            var name = tokens[tokens.length - 1];
            tokens.splice(tokens.length - 1, 1);
            var ce = new Class { Name = name, Members = new JsArray<Member>(), Namespace = tokens.join(".") };
            if (isJson)
                ce.Attributes.Add(new Attribute { Code = "[JsType(JsMode.Json)]" });
            else
                ce.Attributes.Add(new Attribute { Code = "[JsType(JsMode.Prototype, Name=\"" + ce.Namespace + "." + ce.Name + "\")]" });
            var tables = ch.ToJQuery().nextUntil("h2").filter("table");
            foreach (var tbl in tables.As<JsArray<HtmlTableElement>>())
            {
                if (tbl.summary.Contains("Constructor"))
                {
                    foreach (var me in ParseMethods(tbl, true))
                        ce.Members.Add(me);
                }
                else if (tbl.summary.Contains("Method"))
                {
                    foreach (var me in ParseMethods(tbl, false))
                        ce.Members.Add(me);
                }
                else if (tbl.summary.Contains("Prop"))
                {
                    foreach (var me in ParseProperties(tbl))
                        ce.Members.Add(me);
                }
                else if (tbl.summary.Contains("Constant"))
                {
                    foreach (var me in ParseConstants(tbl))
                        ce.Members.Add(me);
                }
                else if (tbl.summary.Contains("Event"))
                {
                    foreach (var me in ParseEvents(tbl))
                        ce.Members.Add(me);
                }

            }

            return ce;
        }


        private static JsArray<Property> ParseConstants(HtmlTableElement tbl)
        {
            var list = new JsArray<Property>();
            var trs = tbl.ToJQuery().find("tbody > tr");
            foreach (var tr in trs)
            {
                var cells = tr.ToJQuery().children("td");
                var name = cells[0].ToJQuery().text().RemoveWhitespace();
                var type = "object";
                var desc = cells[1].ToJQuery().text();

                var me = new Property
                {
                    Name = name,
                    Type = new Class { Name = type },
                    Description = desc,
                    IsStatic = true,
                };

                list.push(me);
            }
            return list;
        }

        private static JsArray<Property> ParseProperties(HtmlTableElement tbl)
        {
            var list = new JsArray<Property>();
            var trs = tbl.ToJQuery().find("> tbody > tr");
            foreach (var tr in trs)
            {
                var cells = tr.ToJQuery().children("td");
                var sig = cells[0].ToJQuery().text().RemoveWhitespace();
                var type = cells[1].ToJQuery().text().RemoveWhitespace();
                var desc = cells[2].ToJQuery().text();

                var name = sig;

                var me = new Property
                {
                    Name = name,
                    Type = new Class { Name = type },
                    Description = desc,
                };

                list.push(me);
            }
            return list;
        }
        private static JsArray<Property> ParseEvents(HtmlTableElement tbl)
        {
            var list = new JsArray<Property>();
            var trs = tbl.ToJQuery().find("> tbody > tr");
            foreach (var tr in trs)
            {
                var cells = tr.ToJQuery().children("td");
                var sig = cells[0].ToJQuery().text().RemoveWhitespace();
                var type = cells[1].ToJQuery().text().RemoveWhitespace();
                var desc = cells[2].ToJQuery().text();
                if (type.Contains("None"))
                    type = "JsAction";
                else
                    type = "JsAction<" + type + ">";
                var name = sig;

                var me = new Property
                {
                    Name = name,
                    Type = new Class { Name = type },
                    Description = desc,
                };

                list.push(me);
            }
            return list;
        }

        private static JsArray<Method> ParseMethods(HtmlTableElement tbl, bool isCtor)
        {
            var list = new JsArray<Method>();
            var trs = tbl.ToJQuery().find("> tbody > tr");
            foreach (var tr in trs)
            {
                var cells = tr.ToJQuery().children("td");
                var sig = cells[0].ToJQuery().text().RemoveWhitespace();
                JsString type;
                JsString desc;
                if (isCtor)
                {
                    type = "";
                    desc = cells[1].ToJQuery().text();
                }
                else
                {
                    type = cells[1].ToJQuery().text().RemoveWhitespace();
                    desc = cells[2].ToJQuery().text();
                }

                var name = sig.substr(0, sig.indexOf("("));

                var me = new Method
                {
                    Name = name,
                    Type = new Class { Name = type },
                    Description = desc,
                    IsConstructor = isCtor,
                };


                var prms = sig.substr(sig.indexOf("(") + 1);
                prms = prms.substr(0, prms.indexOf(")"));
                if (prms.length > 0)
                {
                    if (!prms.Contains("function"))
                    {

                        var prms2 = prms.split(",");
                        foreach (var prm in prms2)
                        {
                            var tokens = prm.split(':');
                            var prmTypeName = (tokens[1] ?? "").trim();
                            var prmName = tokens[0].trim();
                            var prm3 = new Parameter { Type = new Class { Name = prmTypeName ?? "object" } };
                            if (prmName.EndsWith("?"))
                            {
                                prmName = prmName.substr(0, prmName.length - 1);
                                prm3.IsOptional = true;
                            }
                            prm3.Name = prmName;
                            me.Parameters.Add(prm3);
                        }
                    }
                }


                list.push(me);
            }
            return list;
        }
    }
    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js")]
    public class CodeWriter
    {
        public CodeWriter()
        {
            Writer = new JsArray<object>();
        }
        public JsArray<object> Writer { get; set; }
        public void BeginBlock()
        {
            WriteLine("{");
        }
        public void EndBlock()
        {
            WriteLine("}");
        }
        public void WriteLine(string obj)
        {
            if (obj == null)
                return;
            Write(obj + "\n");
        }
        public override string ToString()
        {
            return Writer.join("");
        }

        public void Write(string s)
        {
            Writer.push(s);
        }
    }

    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    static class Extensions
    {
        public static bool Contains(this JsString s, JsString find)
        {
            return s.indexOf(find) >= 0;
        }
        public static bool StartsWith(this JsString s, JsString find)
        {
            return s.indexOf(find) == 0;
        }
        public static bool EndsWith(this JsString s, JsString find)
        {
            return s.lastIndexOf(find) == s.length - find.length;
        }

        public static JsArray<R> JsSelect<T, R>(this JsArray<T> list, JsFunc<T, R> selector)
        {
            var list2 = new JsArray<R>();
            foreach (var item in list)
                list2.push(selector(item));
            return list2;
        }
        public static JsString RemoveWhitespace(this JsString s)
        {
            return s.replace(new JsRegExp("\\s", "g"), "");
        }
        public static JsString RemoveLast(this JsString s, JsString find)
        {
            var index = s.lastIndexOf(find);
            if (index >= 0)
                return s.substring(0, index) + s.substring(index + find.length);
            return s;
        }
        [JsMethod(Name = "$", Global = true, Export = false)]
        public static jQuery.jQuery ToJQuery(this HtmlElement el)
        {
            return new jQuery.jQuery(el);
        }
    }
    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Assembly
    {
        public Assembly()
        {
            Classes = new JsArray<Class>();
        }
        public JsArray<Class> Classes { get; set; }
    }

    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Member
    {
        public Member()
        {
            Attributes = new JsArray<Attribute>();
        }
        public Class Type { get; set; }
        public JsString Name { get; set; }
        public JsString Description { get; set; }
        public JsArray<Attribute> Attributes { get; set; }
    }
    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Attribute
    {
        public string Code { get; set; }
    }

    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Method : Member
    {
        public Method()
        {
            Parameters = new JsArray<Parameter>();
        }
        public bool IsConstructor { get; set; }
        public JsArray<Parameter> Parameters { get; set; }

    }
    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Property : Member
    {

        public bool IsStatic { get; set; }
    }

    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Parameter : Member
    {

        public bool IsOptional { get; set; }
    }

    [JsType(JsMode.Prototype, Filename = "GoogleMapsParser.js", NativeCasts = true)]
    class Class : Member
    {
        public JsArray<Member> Members { get; set; }

        public JsString Namespace { get; set; }
    }

}