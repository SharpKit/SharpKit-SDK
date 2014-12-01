using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Object3D
    {
        public JsNumber id { get; set; }
        public JsString name { get; set; }
        public Object3D parent { get; set; }
        public Object3D [] children { get; set; }
        public Vector3 up { get; set; }
        public Vector3 position { get; set; }
        public Vector3 rotation { get; set; }
        public JsString eulerOrder { get; set; }
        public Vector3 scale { get; set; }
        public JsBoolean doubleSided { get; set; }
        public JsBoolean flipSided { get; set; }
        public JsNumber renderDepth { get; set; }
        public JsBoolean rotationAutoUpdate { get; set; }
        public Matrix4 matrix { get; set; }
        public Matrix4 matrixWorld { get; set; }
        public Matrix4 matrixRotationWorld { get; set; }
        public JsBoolean matrixAutoUpdate { get; set; }
        public JsBoolean matrixWorldNeedsUpdate { get; set; }
        public Quaternion quaternion { get; set; }
        public JsBoolean useQuaternion { get; set; }
        public JsNumber boundRadius { get; set; }
        public JsNumber boundRadiusScale { get; set; }
        public JsBoolean visible { get; set; }
        public JsBoolean castShadow { get; set; }
        public JsBoolean receiveShadow { get; set; }
        public JsBoolean frustumCulled { get; set; }
        public Vector3 _vector { get; set; }

        public Object3D() { }
        public void applyMatrix(Matrix4 m) { }
        public void translate(JsNumber distance, Vector3 axis) { }
        public void translateX(JsNumber distance) { }
        public void translateY(JsNumber distance) { }
        public void translateZ(JsNumber distance) { }
        public void lookAt(Vector3 vector) { }
        public void add(Object3D obj) { }
        public void remove(Object3D obj) { }
        public Object3D getChildByName(JsString name, JsBoolean doRecurse) { return this;  }
        public void updateMatrix() { }
        public void updateMatrixWorld(JsBoolean force) { }



    }
}