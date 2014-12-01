using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class AmbientLight : Light
    {
        public AmbientLight(Color color) { }
        public AmbientLight(Color color, JsNumber intensity) { }
        public AmbientLight(Color color, JsNumber intensity, JsNumber distance) { }
    }

}