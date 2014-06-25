using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class IcosahedronGeometry  : Geometry
    {
        public IcosahedronGeometry() { }
        public IcosahedronGeometry(JsNumber radius) { }
        public IcosahedronGeometry(JsNumber radius, JsNumber detail) { }
    }
}