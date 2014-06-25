using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ConvexGeometry  : Geometry
    {
        public ConvexGeometry (Vector3[] vertices) { }
    }
}