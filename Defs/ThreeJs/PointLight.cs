using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PointLight : Light
    {
        public PointLight(JsNumber hex) { }
        public PointLight(JsNumber hex, JsNumber intensity) { }
        public PointLight(JsNumber hex, JsNumber intensity, JsNumber distance) { }
    }

}