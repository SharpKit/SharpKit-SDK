using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ShaderMaterial : Material
    {
        public ShaderMaterial(ShaderMaterialOptions parameters)
        {
           
        }
        public object uniforms { get; set; }
        public bool wireframe { get; set; }
    }
}