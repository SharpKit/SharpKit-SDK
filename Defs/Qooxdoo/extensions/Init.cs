using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx;
using qx.application;

namespace qx.core
{
    ///<summary>
    ///This is the base class for all qooxdoo applications.
    ///</summary>
    [JsType(JsMode.Prototype, Export = false, Name = "qx.core.Init")]
    public partial class Init 
    {
        [JsMethod(Name = "getApplication")]
        public static Standalone GetApplication() { throw new NotImplementedException(); }
    }
}