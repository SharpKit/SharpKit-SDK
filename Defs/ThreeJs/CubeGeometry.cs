using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class CubeGeometry  : Geometry
    {
        public CubeGeometry(JsNumber width, JsNumber height, JsNumber depth) { }
        public CubeGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth) { }
        public CubeGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight) { }
        public CubeGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber segmentsDepth) { }
        public CubeGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber segmentsDepth, Material[] materials) { }
        public CubeGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber segmentsDepth, Material[] materials, JsBoolean[] sides) { }
    }
}