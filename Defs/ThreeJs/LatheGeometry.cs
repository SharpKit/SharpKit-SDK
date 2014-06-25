using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class LatheGeometry  : Geometry
    {
        public LatheGeometry(Vector3[] points) { }
        public LatheGeometry(Vector3[] points, JsNumber steps) { }
        public LatheGeometry(Vector3[] points, JsNumber steps, JsNumber angle) { }
    }
}