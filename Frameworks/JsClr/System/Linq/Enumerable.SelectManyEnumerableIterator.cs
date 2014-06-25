using System;
using System.Collections.Generic;
using System.Linq;
namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {
        /*private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
        {
            return (TSource x) => selector2(selector1(x));
        }*/

        [JsType(Name = "System.Linq.Enumerable.SelectManyEnumerableIterator", Filename = "~/res/System.Linq.js")]
        private class SelectManyEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
        {
            private IEnumerable<TSource> source;
            private Func<TSource, IEnumerable<TResult>> selector;
            private IEnumerator<TSource> enumerator;
            private IEnumerator<TResult> innerEnumerator;
            public SelectManyEnumerableIterator(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
            {
                this.source = source;
                this.selector = selector;
            }
            public override Enumerable.Iterator<TResult> Clone()
            {
                return new Enumerable.SelectManyEnumerableIterator<TSource, TResult>(this.source, this.selector);
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

                while (true)
                {
                    if (this.innerEnumerator == null)
                    {
                        if (this.enumerator.MoveNext())
                        {
                            this.innerEnumerator = selector(this.enumerator.Current).GetEnumerator();
                        }
                        else
                        {
                            this.Dispose();
                            return false;
                        }
                    }
                    else
                    {
                        if (this.innerEnumerator.MoveNext())
                        {
                            this.current = this.innerEnumerator.Current;
                            return true;
                        }
                        this.innerEnumerator = null;
                    }
                    
                }
            }
            public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
            {
                return new Enumerable.WhereSelectEnumerableIterator<TResult, TResult2>(this, null, selector);
            }
            public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
            {
                return new Enumerable.WhereEnumerableIterator<TResult>(this, predicate);
            }
        }

    }
}