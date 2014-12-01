using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Vector2
    {
        public Vector2() { }
        public Vector2(JsNumber x) { }
        public Vector2(JsNumber x, JsNumber y) { }

        public JsNumber x { get; set; }
        public JsNumber y { get; set; }

        public Vector2 set(JsNumber x, JsNumber y) { return null; }
        public Vector2 copy(Vector2 v) { return null; }
        public Vector2 clone() { return null; }
        public Vector2 add(Vector2 v1, Vector2 v2) { return null; }
        public Vector2 addSelf(Vector2 v) { return null; }
        public Vector2 sub(Vector2 v1, Vector2 v2) { return null; }
        public Vector2 subSelf(Vector2 v) { return null; }
        public Vector2 multiplyScalar(JsNumber s) { return null; }
        public Vector2 divideScalar(JsNumber s) { return null; }
        public Vector2 negate() { return null; }
        public JsNumber dot(Vector2 v) { return 0; }
        public JsNumber lengthSq() { return 0; }
        public JsNumber length() { return 0; }
        public Vector2 normalize() { return null; }
        public Vector2 setLength(JsNumber l) { return null; }
        public Vector2 lerpSelf(Vector2 v, JsNumber a) { return null; }
        public JsBoolean equals(Vector2 v) { return true; }
        public JsBoolean isZero() { return true; }
    }
}