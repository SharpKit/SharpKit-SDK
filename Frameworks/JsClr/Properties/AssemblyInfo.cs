using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpKit.JavaScript;

[assembly: JsType(TargetType = typeof(int), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(byte), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(char), OmitCasts = true)]     // Dan-el, 'char' was missing from your list you sent me, required for Guid
[assembly: JsType(TargetType = typeof(short), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(double), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(float), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(uint), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(ushort), OmitCasts = true)]
[assembly: JsType(TargetType = typeof(decimal), OmitCasts = true)]

[assembly: JsMergedFile(Filename = "res/System.js", Sources = new string[]
{
    //"Internal/sk.js",
	"Compilation/JsCompiler.js",
    "Internal/Core.js",
    "Internal/CoreEx.js",
})]

[assembly: JsMergedFile(Filename = "res/jsclr.js", Sources = new string[]
{
    "res/System.js",
    "res/System.IO.js",
    "res/System.Linq.js",
    "res/System.Collections.js",
    "res/System.Reflection.js",
    "res/System.Diagnostics.js",
    "res/System.ComponentModel.js",
    "res/System.Text.js",
    "res/System.Ext.js"
})]

[assembly: JsMergedFile(Filename = "res/jsclr.min.js", Sources = new string[] { "res/jsclr.js" }, Minify = true)]

[assembly: JsExport(UseStrict = true/*, CodeInjectionFilename = "Internal/sk.js", GenerateSourceMaps=true, ExportTsHeaders =true */)]
//[assembly: JsExport(UseStrict = true)]

[assembly: JsType(JsMode.Prototype, Export = false, TargetType = typeof(BindingFlags))]
