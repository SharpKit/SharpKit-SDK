using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PolyhedronGeometry : Geometry
    {
        public PolyhedronGeometry(Vector3[] vertices, Face3[] faces, JsNumber radius, JsNumber detail) { }
    }
}