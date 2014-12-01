using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Json, Export = false)]
    public class WebGLRendererOptions
    {
        public JsBoolean antialias { get; set; }
        public HtmlElement canvas { get; set; }
        public JsNumber clearColor { get; set; }
        public JsNumber clearAlpha { get; set; }
        public JsNumber maxLights { get; set; }
        public JsBoolean stencil { get; set; }
        public JsBoolean preserveDrawingBuffer { get; set; }

        public JsString precision { get; set; }
        public JsBoolean alpha { get; set; }
        public JsBoolean premultipliedAlpha { get; set; }
    }
}