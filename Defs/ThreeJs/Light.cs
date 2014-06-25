using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Light : Object3D
    {
        public Light() { }
        public Light(JsNumber hex) { }
    }
}