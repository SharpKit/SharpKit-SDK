using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    [JsType(JsMode.Json)]
    public class Header
    {
        public string name;
        public string value;
    }
}
