using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using SharpKit.JavaScript;

namespace SharpKit.JsClr.System.Linq
{
    [JsType(JsMode.Clr, Name = "System.Linq._OrderedEnumerable$1", Filename = "~/res/System.Linq.js")]
    internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
    {
        internal IEnumerable<TElement> source;
        TElement[] sorted;
        public IEnumerator<TElement> GetEnumerator()
        {
            if (sorted == null)
                sorted = SortSource();
            return sorted.AsJsArray().GetEnumerator();
        }

        internal virtual TElement[] SortSource()
        {
            var list = source.ToArray().AsJsArray();
            list.sort(Compare);
            return list.AsArray();
        }
        internal abstract JsNumber Compare(TElement x, TElement y);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
        {
            return new OrderedEnumerable<TElement, TKey>(this.source, keySelector, comparer, descending)
            {
                parent = this
            };
        }
    }
    [JsType(JsMode.Clr, Name = "System.Linq._OrderedEnumerable$2", Filename = "~/res/System.Linq.js")]
    internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
    {
        internal OrderedEnumerable<TElement> parent;
        internal Func<TElement, TKey> keySelector;
        internal IComparer<TKey> comparer;
        internal bool descending;
        internal OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (keySelector == null)
            {
                throw Error.ArgumentNull("keySelector");
            }
            this.source = source;
            this.keySelector = keySelector;
            this.comparer = ((comparer != null) ? comparer : Comparer<TKey>.Default);
            this.descending = descending;
        }

        internal override JsNumber Compare(TElement x, TElement y)
        {
            if (parent != null)
            {
                var z = parent.Compare(x, y);
                if (z != 0)
                    return z;
            }
            var xx = keySelector(x);
            var yy = keySelector(y);
            var zz = comparer.Compare(xx, yy);
            if (descending)
                zz *= -1;
            return zz;
        }
    }
}
