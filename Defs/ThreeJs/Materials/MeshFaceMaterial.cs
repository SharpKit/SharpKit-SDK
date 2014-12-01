using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class MeshFaceMaterial : Material
    {
        public MeshFaceMaterial() { }

        public MeshFaceMaterial clone() { return null; }
    }
}