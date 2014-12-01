using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Face4
    {
        public Face4(JsNumber a, JsNumber b, JsNumber c, JsNumber d, Vector3 normal, Color color, JsNumber materialIndex) { }

        public Face4 clone() { return null; }
    }
}
