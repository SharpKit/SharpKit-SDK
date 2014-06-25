using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class TetrahedronGeometry : Geometry
    {
        public TetrahedronGeometry() { }
        public TetrahedronGeometry(JsNumber radius) { }
        public TetrahedronGeometry(JsNumber radius, JsNumber detail) { }
    }
}