using System;
using System.Collections.Generic;
using System.Linq;
namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {
        private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
        {
            return (TSource x) => selector2(selector1(x));
        }

        [JsType(Name = "System.Linq.Enumerable.WhereSelectEnumerableIterator", Filename = "~/res/System.Linq.js")]
        private class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
        {
            private IEnumerable<TSource> source;
            private Func<TSource, bool> predicate;
            private Func<TSource, TResult> selector;
            private IEnumerator<TSource> enumerator;
            public WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
            {
                this.source = source;
                this.predicate = predicate;
                this.selector = selector;
            }
            public override Enumerable.Iterator<TResult> Clone()
            {
                return new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(this.source, this.predicate, this.selector);
            }
            public override void Dispose()
            {
                if (this.enumerator != null)
                {
                    this.enumerator.Dispose();
                }
                this.enumerator = null;
                base.Dispose();
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
                    if (this.predicate == null || this.predicate(current))
                    {
                        this.current = this.selector(current);
                        return true;
                    }
                }
                this.Dispose();
                return false;
            }
            public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
            {
                return new Enumerable.WhereSelectEnumerableIterator<TSource, TResult2>(this.source, this.predicate, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this.selector, selector));
            }
            public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
            {
                return new Enumerable.WhereEnumerableIterator<TResult>(this, predicate);
            }
        }

    }
}