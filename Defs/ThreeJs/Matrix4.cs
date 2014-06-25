using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Matrix4
    {
        public Matrix4(JsNumber n11, JsNumber n12, JsNumber n13, JsNumber n14, JsNumber n21, JsNumber n22, JsNumber n23, JsNumber n24, JsNumber n31, JsNumber n32, JsNumber n33, JsNumber n34, JsNumber n41, JsNumber n42, JsNumber n43, JsNumber n44 ){}

        public Matrix4()
        {
            
        }

        public JsNumber n11 { get; set; }
        public JsNumber n12 { get; set; }
        public JsNumber n13 { get; set; }
        public JsNumber n14 { get; set; }
        public JsNumber n21 { get; set; }
        public JsNumber n22 { get; set; }
        public JsNumber n23 { get; set; }
        public JsNumber n24 { get; set; }
        public JsNumber n31 { get; set; }
        public JsNumber n32 { get; set; }
        public JsNumber n33 { get; set; }
        public JsNumber n34 { get; set; }
        public JsNumber n41 { get; set; }
        public JsNumber n42 { get; set; }
        public JsNumber n43 { get; set; }
        public JsNumber n44 { get; set; }

        public Matrix4 set(JsNumber n11, JsNumber n12, JsNumber n13, JsNumber n14, JsNumber n21, JsNumber n22, JsNumber n23, JsNumber n24, JsNumber n31, JsNumber n32, JsNumber n33, JsNumber n34, JsNumber n41, JsNumber n42, JsNumber n43, JsNumber n44) { return null;  }
        public Matrix4 identity(JsNumber n11, JsNumber n12, JsNumber n13, JsNumber n14, JsNumber n21, JsNumber n22, JsNumber n23, JsNumber n24, JsNumber n31, JsNumber n32, JsNumber n33, JsNumber n34, JsNumber n41, JsNumber n42, JsNumber n43, JsNumber n44) { return null; }
        public Matrix4 copy(Matrix4 m) { return null; }
        public Matrix4 lookat(Vector4 eye, Vector4 center, Vector4 up) { return this; }
        public Matrix4 multiply(Matrix4 a, Matrix4 b) { return null; }
        public Matrix4 multiplySelf(Matrix4 m) { return null; }
        public Matrix4 multiplyToArray(Matrix4 a, Matrix4 b, JsNumber[] r) { return null; }

        public Matrix4 makeRotationFromEuler(Vector3 vector3)
        {
            return null;
        }
    }
}