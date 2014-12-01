using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public static class ImageUtils
    {
        public static object loadTexture(string url, object mapping, Action<object> callback)
        {
            throw new NotImplementedException();
        }
    }
}
