using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SharpKit.KnockoutJs")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SharpKit.KnockoutJs")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("57a33c2f-a6fb-440f-85b6-b6bc124d1313")]

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
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("4.30.2000")]

/// <summary>
/// SharpKit interface for KnockoutJs library.
/// Knockout is a JavaScript library that helps you to create rich, responsive display and editor user interfaces with a clean underlying data model. Any time you have sections of UI that update dynamically (e.g., changing depending on the user’s actions or when an external data source changes), KO can help you implement it more simply and maintainably.
/// </summary>
/// <example>
/// Hello world
/// <code>
/// [JsType(JsMode.Global)]
/// class MyPage : Knockout
/// {
///     static MyPage()
///     {
///         // Here's my data model
///         var viewModel = new MyViewModel
///         {
///             firstName = observable("Planet"),
///             lastName = observable("Earth")
///         };
///         // Knockout tracks dependencies automatically. It knows that fullName depends on firstName and lastName, because these get called when evaluating fullName.
///         viewModel.fullName = dependentObservable(() => viewModel.firstName.Value + " " + viewModel.lastName.Value);
/// 
///         applyBindings(viewModel); // This makes Knockout get to work
///     }
/// }
/// [JsType(JsMode.Json)]
/// class MyViewModel
/// {
///     public Observable&lt;string&gt; firstName { get; set; }
///     public Observable&lt;string&gt; lastName { get; set; }
///     public DependentObservable&lt;string&gt; fullName { get; set; }
/// }
/// </code></example>
class AssemblyDoc
{
}

namespace SharpKit.KnockoutJs
{
    /// <summary>
    /// Knockout is a JavaScript library that helps you to create rich, responsive display and editor user interfaces with a clean underlying data model. Any time you have sections of UI that update dynamically (e.g., changing depending on the user’s actions or when an external data source changes), KO can help you implement it more simply and maintainably.
    /// </summary>
    /// <example>
    /// Hello world
    /// <code>
    /// [JsType(JsMode.Global)]
    /// class MyPage : Knockout
    /// {
    ///     static MyPage()
    ///     {
    ///         // Here's my data model
    ///         var viewModel = new MyViewModel
    ///         {
    ///             firstName = observable("Planet"),
    ///             lastName = observable("Earth")
    ///         };
    ///         // Knockout tracks dependencies automatically. It knows that fullName depends on firstName and lastName, because these get called when evaluating fullName.
    ///         viewModel.fullName = dependentObservable(() => viewModel.firstName.Value + " " + viewModel.lastName.Value);
    /// 
    ///         applyBindings(viewModel); // This makes Knockout get to work
    ///     }
    /// }
    /// [JsType(JsMode.Json)]
    /// class MyViewModel
    /// {
    ///     public Observable&lt;string&gt; firstName { get; set; }
    ///     public Observable&lt;string&gt; lastName { get; set; }
    ///     public DependentObservable&lt;string&gt; fullName { get; set; }
    /// }
    /// </code></example>
    class NamespaceDoc
    {
    }
}
