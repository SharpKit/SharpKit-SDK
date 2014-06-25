using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class PlaneGeometry : Geometry
    {
        public PlaneGeometry(JsNumber width, JsNumber height) { }
        public PlaneGeometry(JsNumber width, JsNumber height, JsNumber widthSegments) { }
        public PlaneGeometry(JsNumber width, JsNumber height, JsNumber widthSegments, JsNumber heightSegments) { }
    }
}