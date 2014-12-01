using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class OctahedronGeometry  : Geometry
    {
        public OctahedronGeometry() { }
        public OctahedronGeometry(JsNumber radius) { }
        public OctahedronGeometry(JsNumber radius, JsNumber detail) { }
    }
}