using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using Y_;
[assembly: JsType(JsMode.Prototype)]
[assembly:JsMethod(TargetType=typeof(YUI), TargetMethod=".ctor", OmitNewOperator=true)]

namespace Y_
{
    [JsType(JsMode.Global, Export=false)]
    public partial class YUIContext
    {
        /// <summary>
        /// A predefined global variable named 'Y', serves as a placeholder for Yui global object
        /// and helps streamlining work with YUI and SharpKit
        /// </summary>
        [JsProperty(Name="Y", NativeField=true)]
        public static YUI Current { get; set; }
    }
    partial class YUI : YUIContext
    {
    }
}