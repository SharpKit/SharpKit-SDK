using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ParametricGeometry : Geometry
    {
        public ParametricGeometry(JsFunc<JsNumber, JsNumber, JsNumber> func, JsNumber slices, JsNumber stacks) { }
        public ParametricGeometry(JsFunc<JsNumber, JsNumber, JsNumber> func, JsNumber slices, JsNumber stacks, JsBoolean useTris) { }
    }
}