using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class MeshBasicMaterial : Material
    {
        public MeshBasicMaterial( MeshBasicMaterialOptions parameters) { }

        public MeshBasicMaterial clone() { return null; }
    }

    [JsType(JsMode.Json)]
    public class MeshBasicMaterialOptions
    {
        public Color color;
    }

}