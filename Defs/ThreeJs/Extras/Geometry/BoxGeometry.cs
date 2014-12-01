using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class BoxGeometry  : Geometry
    {
        public BoxGeometry(JsNumber width, JsNumber height, JsNumber depth) { }
        public BoxGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth) { }
        public BoxGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight) { }
        public BoxGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber segmentsDepth) { }
        public BoxGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber segmentsDepth, Material[] materials) { }
        public BoxGeometry(JsNumber width, JsNumber height, JsNumber depth, JsNumber segmentsWidth, JsNumber segmentsHeight, JsNumber segmentsDepth, Material[] materials, JsBoolean[] sides) { }
    }
}