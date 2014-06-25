using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx;
using qx.ui.root;

namespace qx.application
{
    ///<summary>
    ///For a GUI application that looks & feels like native desktop application
    ///(often called “RIA” – Rich Internet Application).
    ///Such a stand-alone application typically creates and updates all content
    ///dynamically. Often it is called a “single-page application”, since the
    ///document itself is never reloaded or changed. Communication with the server
    ///is done with AJAX.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "qx.application.Standalone")]
    public partial class Standalone : qx.application.AbstractGui
    {
        [JsMethod(Name = "getRoot")]
        public Application GetRootApp() { throw new NotImplementedException(); }
    }
}