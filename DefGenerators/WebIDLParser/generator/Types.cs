
/*******************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace WebIDLParser
{
    public class TFileType
    {
        //// Tags in this hash table will have their names translated.
        //private readonly Dictionary<string, string> tagNameOverrides = 
        //    new Dictionary<string, string>
        //        {
        //            { "image",              "img" },
        //            { "anchor",             "a" },
        //            { "tablecaption",       "caption" },
        //            { "tablecell",          "td" },
        //            { "tablecol",           "col" },
        //            { "tablerow",           "tr" },
        //            // TODO: It can be thead or tfoot, too!
        //            { "tablesection",       "tbody" },
        //            { "dlist",              "dl" },
        //            { "olist",              "ol" },
        //            { "ulist",              "ul" },
        //            { "directory",          "d" },
        //            { "paragraph",          "p" },
        //            // TODO: Could be del or ins, but not mod. mod is an interface.
        //            { "mod",                "tbody" },
        //        };

        public string name = "";
        public string aliasName = "";
        public TMemberList members = new TMemberList();
        public TNamespace ns;
        public TTypeList baseType = new TTypeList();
        public TJsAttributeList jsAttributes = new TJsAttributeList();

        public bool CheckExport()
        {
            return !name.StartsWith("WebKit");
        }

        public void rename(string newName)
        {
            //AliasName = newName;
            //if (Name == "Event") {
            //  return;
            //}
            foreach (var t in Generator.allTypes)
            {
                if (t.name == name)
                {
                    t.name = newName;
                    if (t.genericType != null && t.genericType.name == name)
                        t.genericType.name = newName;
                }
            }
            this.name = newName;
        }

        public void write(StringBuilder sb)
        {
            if (isDelegate())
            {
                var del = members[0] as TMethod;
                var resultTypeName = del.resultType.ToString();
                var delegateName = Generator.getName(name);
                if (TransformationConfig.changeDelegateResultType.ContainsKey(delegateName))
                {
                    resultTypeName = TransformationConfig.changeDelegateResultType[delegateName];
                }
                sb.Append("public delegate " + resultTypeName + " " + delegateName);
                del.parameters.write(sb);
                sb.Append(";" + Environment.NewLine);
                return;
            }

            var isSupplemental = this.isSupplemental();

            jsAttributes.Add("Export", "false");
            jsAttributes.Add("PropertiesAsFields", "true");
            jsAttributes.Add("NativeCasts", "true");

            if (aliasName == "") aliasName = name; //Give all types an Name-attribute (without namespace)
            if (aliasName != "") jsAttributes.Add("Name", "\"" + aliasName + "\"");

            if (!isSupplemental) sb.Append("[JsType(JsMode.Prototype, " + jsAttributes.ToString() + ")]" + Environment.NewLine);
            string typeType = "class";
            if (isInterface) typeType = "interface";
            sb.Append("public partial " + typeType + " " + (isSupplemental ? getSupplementalName() : name));
            if (baseType.Count != 0)
            {
                sb.Append(" : ");
                for (var tIdx = 0; tIdx < baseType.Count; tIdx++)
                {
                    if (tIdx != 0) sb.Append(", ");
                    sb.Append(baseType[tIdx].ToString());
                }
            }
            sb.Append(Environment.NewLine + "{" + Environment.NewLine);
            foreach (TMember mem in members)
            {
                mem.write(sb);
            }

            if (!isInterface)
                writeInterfaceTypes(sb);

            sb.Append("}" + Environment.NewLine + Environment.NewLine);
        }

        public bool isSupplemental()
        {
            return getSupplementalName() != "";
        }

        public string getSupplementalName()
        {
            foreach (var attr in attributes)
                if (attr is TNameAttribute && (attr as TNameAttribute).name == "Supplemental") return (attr as TNameAttribute).value;
            return "";
        }

        public bool isDelegate()
        {
            foreach (var attr in attributes)
            {
                if (attr is TNameAttribute)
                {
                    var nameAttr = attr as TNameAttribute;
                    if (nameAttr.name == "Callback")
                    {
                        return true;
                    }
                }
            }
            foreach (var mem in members)
            {
                if (mem.name == "handleEvent") return true;
            }
            return false;
        }

        public void writeInterfaceTypes(StringBuilder sb)
        {
            for (var i = 0; i < baseType.Count; i++)
            {
                var t = Generator.findType(baseType[i].name);
                if (t != null && t.isInterface)
                {
                    foreach (var mem in t.members)
                    {
                        mem.write(sb, true);
                    }
                    //foreach (var intBaseType in t.baseType) {
                    //  var intType = Program.findType(intBaseType.name);
                    //  if (intType != null) intType.writeInterfaceTypes(sb);
                    //}
                    t.writeInterfaceTypes(sb);
                }
            }
        }

        public void write(string File)
        {
            StringBuilder sb = new StringBuilder();
            write(sb);
            LarneFunctions.StringSaveToFile(File, sb.ToString());
        }

        public void checkAlias()
        {
            //switch (Name) {
            //  case "HTMLImageElement":
            //    AliasName = "Image";
            //    break;
            //}
            //if (name.StartsWith("HTML")) {
            //  aliasName = name;
            //  name = name.Replace("HTML", "Html");
            //}
        }

        public TAttributeList attributes = new TAttributeList();

        public bool isInterface = false;

        public void convertToInterface()
        {
            if (isInterface) return;
            isInterface = true;
            for (var i = 0; i < members.Count; i++)
            {
                var mem = members[i];
                if (mem is TField)
                {
                    var prop = new TProperty(this);
                    prop.name = mem.name;
                    //prop.modifier = "";
                    prop.resultType = mem.resultType;
                    prop.canWrite = false;
                    members[i] = prop;
                }
                else
                {
                    //mem.modifier = "";
                }
            }
        }

        public void checkConvertToInterface()
        {
            for (var i = 1; i < baseType.Count; i++)
            {
                var t = Generator.findType(baseType[i].name);
                if (t != null) t.convertToInterface();
            }
        }

        public void generateConstructors()
        {
            var memList = new TMemberList();
            foreach (var attr in attributes)
            {
                if (attr is TConstructorAttribute)
                {
                    var ctorAttr = attr as TConstructorAttribute;
                    memList.Insert(0, ctorAttr.constructor);
                }
            }
            if (memList.Count == 0)
            {
                //if (name.StartsWith("Html") && name.EndsWith("Element"))
                //    tryCreateElementMethod(memList, name.Substring(0, name.Length - ("Element".Length)).Substring("Html".Length).ToLower(), name);
                //if (name.StartsWith("Svg") && name.EndsWith("Element"))
                //    tryCreateElementMethod(memList, name.Substring(0, name.Length - ("Element".Length)).Substring("Svg".Length).ToLower(), name);
                foreach (var entry in TransformationConfig.generateElementConstructor)
                {
                    if (name.StartsWith(entry.Item1) && name.EndsWith(entry.Item2))
                        tryCreateElementMethod(memList, name.Substring(0, name.Length - (entry.Item2.Length)).Substring(entry.Item1.Length).ToLower(), name);
                }
            }
            if (memList.Count != 0)
            {
                members.InsertRange(0, memList);
                //createSubConstructors();
            }
        }

        private void tryCreateElementMethod(TMemberList memList, string tagName, string typeName)
        {
            var mem = createElementMethod(tagName, typeName);
            if (mem != null) memList.Add(mem);
        }

        private TMethod createElementMethod(string tagName, string typeName)
        {
            tagName = getCreateElementMethodTagName(tagName, typeName);
            if (string.IsNullOrEmpty(tagName)) return null;
            var method = new TMethod(this) { name = "ctor", aliasName = "document.createElement('" + tagName + "')" };
            method.jsAttributes.Add("OmitParanthesis", "true");
            method.jsAttributes.Add("OmitNewOperator", "true");
            return method;
        }

        private string getCreateElementMethodTagName(string tagName, string typeName)
        {
            //switch (tagName)
            //{
            //    case "image": return "img";
            //    case "anchor": return "a";
            //    case "tablecaption": return "caption";
            //    case "tablecell": return "td";
            //    case "tablecol": return "col";
            //    case "tablerow": return "tr";
            //    case "tablesection": return "tbody"; //Notice: It can be thead or tfoot, too!
            //    default: return tagName;
            //}

            if (TransformationConfig.generateElementConstructorCorrectName.ContainsKey(typeName))
                return TransformationConfig.generateElementConstructorCorrectName[typeName];
            else
                return tagName;
        }

        public void checkGenerateEnumerator()
        {
            foreach (var attr in attributes)
            {
                if (attr is TNameAttribute)
                {
                    var nameAttr = attr as TNameAttribute;
                    if (nameAttr.name == "IndexedGetter")
                    {

                        var typeName = "";
                        foreach (var mem in members)
                        {
                            if (mem.name == "this")
                            {
                                typeName = mem.resultType.ToString();
                                break;
                            }
                        }
                        if (typeName == "") return;

                        jsAttributes.Add("NativeEnumerator", "false");
                        jsAttributes.Add("NativeArrayEnumerator", "true");

                        baseType.Add(new TType() { name = "IJsArrayEnumerable", genericType = new TType() { name = typeName }, canCorrect = false });
                        var str = @"
	{TYPE} IJsArrayEnumerable<{TYPE}>.this[JsNumber index] {
		get { throw new NotImplementedException(); }
	}

	JsNumber IJsArrayEnumerable<{TYPE}>.length {
		get { throw new NotImplementedException(); }
	}

	System.Collections.Generic.IEnumerator<{TYPE}> System.Collections.Generic.IEnumerable<{TYPE}>.GetEnumerator() {
		throw new NotImplementedException();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
		throw new NotImplementedException();
	}
";
                        str = str.Replace("{TYPE}", typeName);
                        members.Add(new TFragmentMember(this) { text = str });
                    }
                }
            }
        }

        public void createSubConstructors()
        {
            var subTypes = Generator.findByBaseType(name);
            foreach (var subType in subTypes)
            {
                var subCTorMemList = new TMemberList();
                foreach (var baseMember in members)
                {
                    if (baseMember.name == "ctor")
                    {
                        var baseCTor = (baseMember as TMethod);
                        if (baseCTor.parameters.Count > 0)
                        {
                            var subCTor = new TMethod(subType);
                            subCTor.name = baseCTor.name;
                            subCTor.resultType = baseCTor.resultType;
                            subCTor.baseMethod = baseCTor;
                            subCTorMemList.Add(subCTor);
                        }
                    }
                }
                if (subCTorMemList.Count > 0)
                {
                    subType.members.InsertRange(0, subCTorMemList);
                }
            }
        }

        public void checkProp()
        {
            TMemberList memList = new TMemberList();
            memList.AddRange(members);
            foreach (TMember mem in memList)
            {
                if (mem is TMethod)
                {
                    TMethod func = (TMethod)mem;
                    if ((func.name.StartsWith("get") && func.parameters.Count == 0) || (func.name == "item" || func.name == "namedItem"))
                    {
                        if (func.name == "item" || func.name == "namedItem")
                        {
                            TProperty prop = new TProperty(this);
                            prop.name = "this";
                            prop.Parameters.AddRange(func.parameters);
                            prop.resultType = func.resultType;
                            prop.canRead = true;
                            int idx = members.IndexOf(func);
                            members[idx] = prop;
                        }
                        else
                        {
                            //string n1 = func.Name.Substring(3);
                            //var propName = char.ToLower(n1[0]).ToString() + n1.Substring(1);
                            //TProperty prop = new TProperty();
                            //prop.Name = propName;
                            //prop.resultType = func.resultType;
                            //prop.canRead = true;
                            //int idx = Members.IndexOf(func);
                            //Members[idx] = prop;
                            //TMethod setMem = (TMethod)Members.Find("set" + n1);
                            //if (setMem != null) {
                            //  prop.canWrite = true;
                            //  Members.Remove(setMem);
                            //}
                        }
                    }
                }
            }
        }

    }

    //public class TClassComment : TMember
    //{
    //  public string text;

    //  public override void write(StringBuilder sb) {
    //    sb.Append(Environment.NewLine + "\t" + text + Environment.NewLine);
    //  }

    //}

    public abstract class TMember
    {
        public TMember(TFileType parentType)
        {
            this.parentType = parentType;
            resultType = new TType() { name = "void" };
        }

        public bool isPrivate = false;
        public TJsAttributeList jsAttributes = new TJsAttributeList();

        public TFileType parentType;
        public string name = "";
        public string aliasName = "";
        public TType resultType;
        public TAttributeList attributes = new TAttributeList();

        public abstract void write(StringBuilder sb, bool impl = false);
    }

    public class TFragmentMember : TMember
    {
        public TFragmentMember(TFileType parentType) : base(parentType) { }

        public string text = "";

        public override void write(StringBuilder sb, bool impl = false)
        {
            sb.Append(text);
        }
    }

    public class TMethod : TMember
    {
        public TMethod(TFileType parentType) : base(parentType) {
            //if (parentType == null) throw new ArgumentException("parentType");
        }

        public TParameterList parameters = new TParameterList();
        public TMethod baseMethod;

        public override void write(StringBuilder sb, bool impl = false)
        {
            var modifier = "public ";
            if (isPrivate) modifier = "private ";
            if (parentType.isInterface && !impl) modifier = "";
            var rType = resultType.ToString();

            var sName = Generator.getName(name);
            if (isConstructor)
            {
                rType = "";
                sName = Generator.getName(parentType.name);
            }
            if (aliasName != "") jsAttributes.Add("Name", "\"" + aliasName + "\"");
            if (jsAttributes.Count > 0)
            {
                sb.Append("\t[JsMethod(" + jsAttributes + ")]" + Environment.NewLine);
            }
            sb.Append("\t" + modifier + " " + rType + " " + sName);
            parameters.write(sb);
            if (parentType.isInterface && !impl)
            {
                sb.Append(";" + Environment.NewLine);
            }
            else
            {
                if (isConstructor && baseMethod != null)
                {
                    sb.Append(" : base(");
                    for (var i = 0; i < baseMethod.parameters.Count; i++)
                    {
                        if (i != 0) sb.Append(", ");
                        sb.Append("default(" + baseMethod.parameters[i].type + ")");
                    }
                    sb.Append(")");
                }
                sb.Append(" {");
                if (resultType != null)
                {
                    if (resultType.name != "void")
                    {
                        sb.Append(" return default(" + resultType + "); ");
                    }
                }
                sb.Append("}" + Environment.NewLine);
            }
        }

        public bool isConstructor
        {
            get
            {
                return name == "ctor";
            }
        }

        public bool appendParamArray
        {
            get
            {
                foreach (var attr in attributes)
                    if (attr is TNameAttribute && (attr as TNameAttribute).name == "CallWith" && (attr as TNameAttribute).value == "ScriptArguments")
                        return true;
                return false;
            }
        }

    }

    public class TProperty : TMember
    {
        public TProperty(TFileType parentType) : base(parentType) { }

        public bool canRead = true;
        public bool canWrite = true;

        public TParameterList Parameters = new TParameterList();

        public override void write(StringBuilder sb, bool impl = false)
        {
            if (name == parentType.name)
            {
                sb.Append("\t" + "[JsProperty(Name=\"" + name + "\")]" + Environment.NewLine);
                name += "_";
            }
            if (name == "this")
            {
                sb.Append("\t" + "[JsProperty(NativeIndexer = true)]" + Environment.NewLine);
            }
            var modifier = "public ";
            if (parentType.isInterface && !impl) modifier = "";
            sb.Append("\t" + modifier + " " + resultType + " " + Generator.getName(name));
            if (name == "this")
            {
                Parameters.write(sb, true);
            }
            sb.Append(" {");
            if (canRead)
            {
                if (name == "this")
                {
                    sb.Append("get { return default(" + resultType + "); } ");
                }
                else
                {
                    sb.Append("get;");
                }
            }
            if (canWrite)
            {
                if (name == "this")
                {
                    sb.Append("set {}");
                }
                else
                {
                    sb.Append(" set; ");
                }
            }
            else
            {
                if (name != "this")
                {
                    if (parentType.isInterface && !impl) { }
                    else
                    {
                        sb.Append(" private set; ");
                    }
                }
            }
            sb.Append("}" + Environment.NewLine);
        }
    }

    public class TField : TMember
    {
        public TField(TFileType parentType) : base(parentType) { }
        public string value;

        public override void write(StringBuilder sb, bool impl = false)
        {
            var modifier = "public ";
            if (parentType.isInterface && !impl) modifier = "";
            sb.Append("\t" + modifier + " static " + resultType + " " + name);
            if (value != null)
            {
                sb.Append(" = " + value);
            }
            sb.Append(";" + Environment.NewLine);
        }
    }

    public class TParameter
    {
        public string name;
        public TType type;
        public bool paramArray = false;
        public TAttributeList attributes = new TAttributeList();

        public bool isOptional()
        {
            foreach (var attr in attributes)
            {
                if (attr is TNameAttribute && (attr as TNameAttribute).name == "Optional" && (attr as TNameAttribute).value == "") return true;
            }
            return false;
        }

        public void write(StringBuilder sb)
        {
            if (this.paramArray)
            {
                sb.Append("params ");
            }
            sb.Append(type + " " + Generator.getName(name));
            //if (isOptional()) {
            //  sb.Append(" = default(" + type.ToString() + ")");
            //}
        }
    }

    public class TParameterList : List<TParameter>
    {

        public bool parametersEquals(TParameterList paramList)
        {
            if (Count != paramList.Count) return false;
            for (var i = 0; i < Count; i++)
            {
                if (this[i].type.name != paramList[i].type.name) return false;
            }
            return true;
        }

        public void write(StringBuilder sb, bool indexer = false)
        {
            if (indexer)
            {
                sb.Append("[");
            }
            else
            {
                sb.Append("(");
            }

            bool f = true;
            foreach (TParameter param in this)
            {
                if (f)
                {
                    f = false;
                }
                else
                {
                    sb.Append(", ");
                }
                param.write(sb);
            }
            if (indexer)
            {
                sb.Append("]");
            }
            else
            {
                sb.Append(")");
            }
        }
    }

    public class TMemberList : List<TMember>
    {
        public void addWithCheck(TMember mem)
        {
            if (mem is TMethod)
                foreach (var m in this)
                {
                    if (m.name == mem.name)
                    {
                        if (m is TMethod)
                        {
                            var met = m as TMethod;
                            if ((mem as TMethod).parameters.parametersEquals(met.parameters)) return;
                        }
                    }
                }
            Add(mem);
        }

        public TMember find(string name)
        {
            foreach (TMember mem in this)
            {
                if (mem.name == name)
                {
                    return mem;
                }
            }
            return null;
        }
    }

    public class TFileTypeList : List<TFileType>
    {
    }

    public class TType
    {
        public TType()
        {
            Generator.allTypes.Add(this);
        }

        public string name;
        public bool isArray = false;
        public bool isNullable = false;
        public TType genericType;
        public bool isResult = true;

        public bool canCorrect = true;
        public void correctType()
        {
            trySetNewTypes();
            if (TParsedFile.isUnknownType(this))
            {
                name = "object";
            }
        }

        private void trySetNewTypes()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("TimeoutHandler", "JsAction");

            if (dict.ContainsKey(name)) name = dict[name];
        }

        public override string ToString()
        {
            if (canCorrect) correctType();
            if (name == "sequence") return genericType.ToString();
            string str = name;
            if (isResult) str = getResultTypeName();
            if (genericType != null) str += "<" + genericType + ">";
            if (isArray) str += "[]";
            //if (isNullable && !isArray) str += "?";
            return str;
        }

        public string getResultTypeName()
        {
            switch (name)
            {
                case "string":
                    return "JsString";
                //case "object":
                //  return "JsObject";
                default:
                    return name;
            }
        }
    }

    public class TTypeList : List<TType> { }

    public class TNamespace
    {
        public string name;
        public TFileTypeList types = new TFileTypeList();
        public List<string> importList = new List<string>();

        private TParsedFile file;
        public TNamespace(TParsedFile file)
        {
            this.file = file;
        }

        public void write(StringBuilder sb)
        {
            sb.Append("namespace " + name + Environment.NewLine);
            sb.Append("{" + Environment.NewLine + Environment.NewLine);
            sb.Append("using SharpKit.JavaScript;" + Environment.NewLine);
            foreach (var usingName in Generator.namespaceNames)
                sb.Append("using " + usingName + ";" + Environment.NewLine);
            foreach (string imp in importList)
            {
                string n = imp.Substring(imp.LastIndexOf(".") + 1);
                sb.Append("using " + n + " = " + imp + ";" + Environment.NewLine);
            }
            sb.Append(Environment.NewLine);
            foreach (TFileType t in types)
            {
                t.write(sb);
            }
            sb.Append("}");
        }
    }

    public class TNamespaceList : List<TNamespace>
    {

        private TParsedFile file;
        public TNamespaceList(TParsedFile file)
        {
            this.file = file;
        }

        public void write(StringBuilder sb)
        {
            var path = file.inFile.Replace(Program.idlInDirectory, "").Replace("\\", "/");
            sb.Append(@"
/*******************************************************************************************************

  This file was auto generated with the tool 'WebIDLParser'

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/{FILE}

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as 'partial'. Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) {YEAR} Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the 'Software'), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/
".Replace("{DATE}", DateTime.Now.ToString("r")).Replace("{FILE}", path).Replace("'", "\"").Replace("{YEAR}", DateTime.Now.Year.ToString()));
            sb.Append(Environment.NewLine);
            sb.Append("using System;" + Environment.NewLine);
            sb.Append(Environment.NewLine);
            foreach (TNamespace ns in this)
            {
                ns.write(sb);
            }
        }
    }

    public class TAttribute { }

    public class TNameAttribute : TAttribute
    {
        public string name = "";
        public string value = "";
    }

    public class TConstructorAttribute : TAttribute
    {
        public TConstructorAttribute(TMethod constructor)
        {
            this.constructor = constructor;
        }

        public TMethod constructor;
        public string name = "";
    }

    public class TAttributeList : List<TAttribute> { }

    public class TJsAttribute
    {
        public string name;
        public string value;
    }
    public class TJsAttributeList : List<TJsAttribute>
    {
        public void Add(string name, string value)
        {
            var attr = find(name);
            if (attr == null)
                Add(new TJsAttribute() { name = name, value = value });
            else
                attr.value = value;
        }

        public TJsAttribute find(string name)
        {
            foreach (var attr in this)
                if (attr.name == name) return attr;
            return null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < Count; i++)
            {
                if (i != 0) sb.Append(", ");
                sb.Append(this[i].name + " = " + this[i].value);
            }
            return sb.ToString();
        }
    }

}