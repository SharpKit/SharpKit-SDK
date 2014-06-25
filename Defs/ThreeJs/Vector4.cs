using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Vector4
    {
        public Vector4() { }
        public Vector4(JsNumber x) { }
        public Vector4(JsNumber x, JsNumber y) { }
        public Vector4(JsNumber x, JsNumber y, JsNumber z) { }
        public Vector4(JsNumber x, JsNumber y, JsNumber z, JsNumber w) { }

        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber z { get; set; }
        public JsNumber w { get; set; }

        public Vector4 set(JsNumber x, JsNumber y, JsNumber z, JsNumber w) { return null; }
        public Vector4 copy(Vector4 v) { return null; }
        public Vector4 clone() { return null;}
        public Vector4 add(Vector4 v1, Vector4 v2) { return null; }
        public Vector4 addSelf(Vector4 v) { return null; }
        public Vector4 sub(Vector4 v1, Vector4 v2) { return null; }
        public Vector4 subSelf(Vector4 v) { return null; }
        public Vector4 multiplyScalar(JsNumber s) { return null; }
        public Vector4 divideScalar(JsNumber s) { return null; }
        public Vector4 negate() { return null; }
        public JsNumber dot(Vector4 v) { return 0; }
        public JsNumber lengthSq() { return 0; }
        public JsNumber length() { return 0; }
        public JsNumber lengthManhatten() { return 0; }
        public Vector4 normalize() { return null; }
        public Vector4 setLength(JsNumber l) { return null; }
        public Vector4 lerpSelf(Vector4 v, JsNumber a) { return null; }
        public Vector4 setAxisAngleFromQuaternion(Quaternion q) { return null; }
        public Vector4 setAxisAngleFromRotationMatrix(Matrix4 m) { return null; }
    }
}