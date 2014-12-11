using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class LineBasicMaterial : Material
    {
        public LineBasicMaterial() { }
        public LineBasicMaterial(LineBasicMaterialOptions parameters) { }

        public LineBasicMaterial clone() { return null; }

        public Color color;
        public JsNumber linewidth;
    }

    [JsType(JsMode.Json)]
    public class LineBasicMaterialOptions
    {
        public Color color;
        public JsNumber linewidth;
    }

}