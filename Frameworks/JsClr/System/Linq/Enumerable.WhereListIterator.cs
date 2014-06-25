using System;
using System.Collections.Generic;
using System.Linq;
namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {
        private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
        {
            return (TSource x) => predicate1(x) && predicate2(x);
        }

        [JsType(Name = "System.Linq.Enumerable.WhereListIterator", Filename = "~/res/System.Linq.js")]
        private class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
        {
            private List<TSource> source;
            private Func<TSource, bool> predicate;
            private IEnumerator<TSource> enumerator;
            public WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
            {
                this.source = source;
                this.predicate = predicate;
            }
            public override Enumerable.Iterator<TSource> Clone()
            {
                return new Enumerable.WhereListIterator<TSource>(this.source, this.predicate);
            }
            public override bool MoveNext()
            {
                switch (this.state)
                {
                    case 1:
                        this.enumerator = this.source.GetEnumerator();
                        this.state = 2;
                        break;
                    case 2:
                        break;
                    default:
                        return false;
                }
                while (this.enumerator.MoveNext())
                {
                    TSource current = this.enumerator.Current;
                    if (this.predicate(current))
                    {
                        this.current = current;
                        return true;
                    }
                }
                this.Dispose();
                return false;
            }
            public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
            {
                return new Enumerable.WhereSelectListIterator<TSource, TResult>(this.source, this.predicate, selector);
            }
            public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
            {
                return new Enumerable.WhereListIterator<TSource>(this.source, Enumerable.CombinePredicates<TSource>(this.predicate, predicate));
            }
        }
    }
}