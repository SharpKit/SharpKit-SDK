using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    [JsType(JsMode.Prototype)]
    public class Module
    {
        public object exports { get; set; }
    }
}
