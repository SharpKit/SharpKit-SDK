using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Line : Object3D
    {
        public Geometry geometry { get; set; }
        public Material material { get; set; }
    }
}