using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class WireframeHelper : Line
    {

        public WireframeHelper(BufferGeometry obj, Color color)
        {
            throw new NotImplementedException();
        }

        public WireframeHelper(Mesh obj, Color color)
        {
            throw new NotImplementedException();
        }

    }
}
