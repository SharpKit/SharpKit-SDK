using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.ICloneable", Filename = "~/Internal/Core.js")]
    public interface JsImplICloneable
    {
        object Clone();
    }
}
