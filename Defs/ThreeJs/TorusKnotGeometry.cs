using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class TorusKnotGeometry : Geometry
    {
        public TorusKnotGeometry() { }
        public TorusKnotGeometry(JsNumber radius) { }
        public TorusKnotGeometry(JsNumber radius, JsNumber tube) { }
        public TorusKnotGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments) { }
        public TorusKnotGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments, JsNumber tubularSegments) { }
        public TorusKnotGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments, JsNumber tubularSegments, JsNumber p) { }
        public TorusKnotGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments, JsNumber tubularSegments, JsNumber p, JsNumber q) { }
        public TorusKnotGeometry(JsNumber radius, JsNumber tube, JsNumber radialSegments, JsNumber tubularSegments, JsNumber p, JsNumber q, JsNumber heightScale) { }
    }
}