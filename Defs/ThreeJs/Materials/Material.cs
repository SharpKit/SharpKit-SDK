using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;
using SharpKit.Three;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Material
    {
        public Material() { }
        public Material(MaterialOptions parameters) { }

        //enums
        //todo missing enums

        //properties
        public JsNumber opacity { get; set; }
        public JsBoolean transparent { get; set; }

        public BlendingMode blending { get; set; }
        public JsBoolean depthTest { get; set; }
        public JsBoolean depthWrite { get; set; }

        public JsBoolean polygonOffset { get; set; }
        public JsNumber polygonOffsetFactor { get; set; }
        public JsNumber polygonOffsetUnits { get; set; }
        public JsNumber alphaTest { get; set; }
        public JsNumber overdraw { get; set; }

        public JsBoolean needsUpdate;
        public Side side { get; set; }
        //methods
        //todo missing methods

    }
}