using System;
using System.Collections.Generic;
using System.Linq;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class WebGLRenderer
    {
        public WebGLRenderer() { }
        public WebGLRenderer(WebGLRendererOptions parameters) { }

        //todo add all public params
        public HtmlElement domElement { get; set; }

        //todo add all methods
        public void render(Scene scene, Camera camera) { }
        public void render(Scene scene, Camera camera, WebGLRenderTarget renderTarget, JsBoolean forceClear) { }

        public WebGLRenderingContext getContext() { return null; }

        public JsBoolean supportsVertexTextures() { return null; }

        public JsNumber getMaxAnisotropy() { return null; }

        public void setSize(JsNumber width, JsNumber height) { }

        public void setViewport(JsNumber x, JsNumber y, JsNumber width, JsNumber height) { }

        public void setScissor(JsNumber x, JsNumber y, JsNumber width, JsNumber height) { }

        public void enableScissorTest(JsBoolean enable) { }

        public void setClearColorHex(JsNumber hex, JsNumber alpha) { }

        public void setClearColor(Color color, JsNumber alpha) { }

        public Color getClearColor() { return null; }

        public JsNumber getClearAlpha() { return null; }

        public void clear(JsBoolean color, JsBoolean depth, JsBoolean stencil) { }
    }
}