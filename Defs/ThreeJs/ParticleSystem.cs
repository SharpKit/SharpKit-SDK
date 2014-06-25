using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using THREE;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class ParticleSystem : Object3D
    {
        public ParticleSystem(Geometry geometry, Material material)
        {
        }
    }
}
