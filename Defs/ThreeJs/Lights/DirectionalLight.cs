using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class DirectionalLight : Light
    {
        public DirectionalLight(Color color) { }
        public DirectionalLight(Color color, JsNumber intensity) { }
    }

}