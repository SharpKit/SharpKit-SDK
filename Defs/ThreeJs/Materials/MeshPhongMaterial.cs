using System;
using System.Collections.Generic;
using System.Linq;


using SharpKit.Html;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class MeshPhongMaterial : Material
    {
        public MeshPhongMaterial(MeshPhongMaterialOptions parameters) { }

        public Color color { get; set; }
    
    }

    [JsType(JsMode.Json, Export = false)]
    public class MeshPhongMaterialOptions
    {
        public JsNumber color { get; set; }
        public JsNumber shininess { get; set; }
    }

}