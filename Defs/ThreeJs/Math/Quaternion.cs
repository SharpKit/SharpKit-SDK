using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Quaternion
    {
        public Quaternion(JsNumber x, JsNumber y, JsNumber z, JsNumber w) { }

        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber z { get; set; }
        public JsNumber w { get; set; }

        public Quaternion set(JsNumber x, JsNumber y, JsNumber z, JsNumber w) { return null; }
        public Quaternion copy(Vector4 v) { return null; }
        public Quaternion clone() { return null; }
        public Quaternion setFromEuler(Vector3 vec3) { return null; }
        public Quaternion setFromAxisAngle(Vector3 axis, JsNumber angle) { return null; }
        public Quaternion setFromRotationMatrix(Matrix4 m) { return null; }
        public Quaternion calculateW() { return this; }
        public Quaternion inverse() { return this; }
        public JsNumber length() { return 0; }
        public Quaternion normalize() { return this; }
        public Quaternion multiplySelf(Quaternion quat2) { return null; }
        public Quaternion multiply(Quaternion q1, Quaternion q2) { return null; }
        public Vector3 multiplyVector3(Vector3 vector, Vector3 dest) { return null; }
        public Quaternion slerp(Quaternion qa, Quaternion qb, Quaternion qm, JsNumber t) { return null; }
    }
}