using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpKit.JavaScript;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SharpKit.JsClr")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SharpKit.JsClr")]
[assembly: AssemblyCopyright("Copyright ©  2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("65e20c5b-1212-44fd-a6a7-25ad6d56a0ba")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("4.1.0.0")]
[assembly: AssemblyFileVersion("4.30.2000")]

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
