using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Face3
    {
        public Face3(JsNumber a, JsNumber b, JsNumber c) { }
        public Face3(JsNumber a, JsNumber b, JsNumber c, Vector3 normal, Color color, JsNumber materialIndex) { }

        public Face3 clone() { return null; }

        public JsNumber a;
        public JsNumber b;
        public JsNumber c;

        public Vector3 normal;
        public JsArray<Vector3> vertexNormals;
        public Color color;
        public JsArray<Vector3> colors;
        public JsNumber materialIndex;
        public Vector3 centroid;
    }
}
