using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class MeshNormalMaterial : Material
    {
        public MeshNormalMaterial() { }
        public MeshNormalMaterial(MeshNormalMaterialOptions parameters) { }

        public MeshNormalMaterial clone() { return null; }
    }

    [JsType(JsMode.Json)]
    public class MeshNormalMaterialOptions
    {
        public bool wireframe;
        public Shading shading;
        public bool morphTargets;
        public JsNumber wireframeLinewidth;
    }

}