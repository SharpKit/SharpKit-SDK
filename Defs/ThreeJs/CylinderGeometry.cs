using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class CylinderGeometry  : Geometry
    {
        public CylinderGeometry() { }
        public CylinderGeometry(JsNumber radiusTop) { }
        public CylinderGeometry(JsNumber radiusTop, JsNumber radiusBottom) { }
        public CylinderGeometry(JsNumber radiusTop, JsNumber radiusBottom, JsNumber height) { }
        public CylinderGeometry(JsNumber radiusTop, JsNumber radiusBottom, JsNumber height, JsNumber radiusSegments) { }
        public CylinderGeometry(JsNumber radiusTop, JsNumber radiusBottom, JsNumber height, JsNumber radiusSegments, JsNumber heightSegments) { }
        public CylinderGeometry(JsNumber radiusTop, JsNumber radiusBottom, JsNumber height, JsNumber radiusSegments, JsNumber heightSegments, JsBoolean openEnded) { }
    }
}