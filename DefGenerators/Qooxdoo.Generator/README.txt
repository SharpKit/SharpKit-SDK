1. Generate qooxdoo Api documentation (run 'generate.py api' in the framework dir)
2. Run QxSharpGen on that folder
3. If there are errors while trying to build the results, resolve the namespaces, remove from class declarations the interfaces that can't be satisfied, also remove the duplicate methods / properties.





Example code:

using SharpKit.JavaScript;
using SharpKit.Html;
using SharpKit.jQuery;
using qx.ui.form;
using qx.ui.root;
using System.Collections.Generic;

namespace QooxDooTest
{
    [JsType(JsMode.Global, Filename = "testapp/source/script/generated/main.js")]
    public class DefaultClient : HtmlContext
    {
        static void Main()
        {
            var button = new Button("test");
            var root = qx.core.Init.GetApplication().GetRootApp();
            root.Add(button, new LayoutProperties { Left = 100, Top = 50 });
            
            button.AddListener("execute", a =>
            {
                alert("ok!");
            });
        }
    }
}

Converts into:

function Main()
{
    var button = new qx.ui.form.Button("test");
    var root = qx.core.Init.getApplication().getRoot();
    root.add(button, {left: 100, top: 50});
    button.addListener("execute", function (a)
    {
        alert("ok!");
    });
};