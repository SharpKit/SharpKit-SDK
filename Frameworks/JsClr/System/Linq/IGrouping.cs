using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using SharpKit.JavaScript;

namespace SharpKit.JsClr.System.Linq
{

    [JsType(JsMode.Clr, Name = "System.Linq.IGrouping$2", Filename = "~/res/System.Linq.js")]
    public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable
    {
        TKey Key { get; }
    }
}
