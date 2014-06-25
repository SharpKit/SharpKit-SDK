using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpKit.JavaScript;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SharpKit.Html")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SharpKit.Html")]
[assembly: AssemblyCopyright("Copyright ©  2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("9bbb82c6-d750-48e7-af7b-737acdc213f9")]

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
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("4.30.2000")]

[assembly: JsNamespace(Namespace = "SharpKit.Html", JsNamespace = "")]
[assembly: JsType(JsMode.Prototype, Name = "", Export = false, PropertiesAsFields = true, NativeCasts = true)] // Removed OmitCasts=true and added NativeCasts=true, because 'instanceof' will not work otherwise.
