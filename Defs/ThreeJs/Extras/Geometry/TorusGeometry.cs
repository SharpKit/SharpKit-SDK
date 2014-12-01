using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class TorusGeometry : Geometry
    {
        public TorusGeometry() { }
        public TorusGeometry(JsNumber radius) { }
        public TorusGeometry(JsNumber radius, JsNumber tube) { }
        public TorusGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments) { }
        public TorusGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments, JsNumber tubularSegments) { }
        public TorusGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments, JsNumber tubularSegments, JsNumber arc) { }
    }
}