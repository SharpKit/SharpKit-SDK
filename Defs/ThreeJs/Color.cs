using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Color
    {
        public Color(JsNumber hex) { }

        public JsNumber r { get; set; }
        public JsNumber g { get; set; }
        public JsNumber b { get; set; }

        public Color copy(Color color) { return this; }
        public Color copyGammaToLinea(Color color) { return this; }
        public Color copyLinearToGamma(Color color) { return this; }
        public Color convertGammaToLinear() { return this; }
        public Color convertLinearToGamma() { return this; }
        public Color setRGB(JsNumber r, JsNumber g, JsNumber b) { return this; }
        public Color setHSV(JsNumber r, JsNumber g, JsNumber b) { return this; }
        public Color setHEX(JsNumber hex) { return this; }
        public JsNumber getHEX() { return 0; }
        public JsString getContextStyle() { return ""; }
        public Color clone() { return this; }
    }
}