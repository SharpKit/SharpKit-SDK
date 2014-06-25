using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Json, Export = false)]
    public class WebGLRenderTargetOptions
    {
        //todo add all other properties
        public JsBoolean generateMipmaps { get; set; }
    }
}