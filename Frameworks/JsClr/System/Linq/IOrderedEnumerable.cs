using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using SharpKit.JavaScript;

namespace SharpKit.JsClr.System.Linq
{
    [JsType(JsMode.Clr, Name = "System.Linq.IOrderedEnumerable$1", Filename = "~/res/System.Linq.js")]
    public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable
    {
        IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
    }
}
