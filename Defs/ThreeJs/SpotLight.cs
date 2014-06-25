using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class SpotLight : Light
    {
        SpotLight(JsNumber hex, JsNumber intensity, JsNumber distance, JsBoolean castShadow) { }
    }
}