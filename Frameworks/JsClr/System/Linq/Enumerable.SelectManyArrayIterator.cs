using System;
using System.Collections.Generic;
using System.Linq;
namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {

        [JsType(Name = "System.Linq.Enumerable.SelectManyArrayIterator", Filename = "~/res/System.Linq.js")]
        private class SelectManyArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
        {
            private TSource[] source;
            private Func<TSource, IEnumerable<TResult>> selector;
            private int index;
            private IEnumerator<TResult> innerEnumerator;

            public SelectManyArrayIterator(TSource[] source, Func<TSource, IEnumerable<TResult>> selector)
            {
                this.source = source;
                this.selector = selector;
            }
            public override Enumerable.Iterator<TResult> Clone()
            {
                return new Enumerable.SelectManyArrayIterator<TSource, TResult>(this.source, this.selector);
            }
            public override bool MoveNext()
            {
                if (this.state == 1)
                {
                    while (this.index < this.source.Length || innerEnumerator != null)
                    {
                        if (innerEnumerator == null)
                        {
                            TSource arg = this.source[this.index];
                            this.index++;

                            var innerEnumerable = this.selector(arg);

                            innerEnumerator = innerEnumerable.GetEnumerator();    
                        }


                        var hadNext = innerEnumerator.MoveNext();

                        if (!hadNext)
                        {
                            innerEnumerator = null;
                            continue;
                        }

                        this.current = innerEnumerator.Current;
                        return true;

                    }
                    this.Dispose();
                }
                return false;
            }
            public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
            {
                //return new Enumerable.WhereSelectArrayIterator<TSource, TResult2>(this.source, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this.selector, selector));
                return new Enumerable.WhereSelectEnumerableIterator<TResult, TResult2>(this, null, selector);
            }
            public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
            {
                return new Enumerable.WhereEnumerableIterator<TResult>(this, predicate);
            }
        }
    }
}