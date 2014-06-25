using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class UV
    {
        public UV() { }
        public UV(JsNumber u) { }
        public UV(JsNumber u, JsNumber v) { }

        public UV set(JsNumber u, JsNumber v) { return null; }
        public UV copy(UV uv) { return null; }
        public UV lerpSelf(UV uv, JsNumber alpha) { return null; }
        public UV clone() { return null; }
    }
}
