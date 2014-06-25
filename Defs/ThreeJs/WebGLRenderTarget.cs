using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class WebGLRenderTarget
    {
        public WebGLRenderTarget(JsNumber width, JsNumber height, WebGLRenderTargetOptions options) { }

        //todo add all properties
        public JsBoolean generateMipmaps { get; set; }


        //todo add all methods
    }
}