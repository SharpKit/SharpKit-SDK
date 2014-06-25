using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.Three
{
    [JsType(JsMode.Json, Export = false)]
    public class TypeValue
    {
        public string type { get; set; }
        public object value { get; set; }
    }
}
