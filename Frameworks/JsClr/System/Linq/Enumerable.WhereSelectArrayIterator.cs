using System;
using System.Collections.Generic;
using System.Linq;
namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {

        [JsType(Name = "System.Linq.Enumerable.WhereSelectArrayIterator", Filename = "~/res/System.Linq.js")]
        private class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
        {
            private TSource[] source;
            private Func<TSource, bool> predicate;
            private Func<TSource, TResult> selector;
            private int index;
            public WhereSelectArrayIterator(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
            {
                this.source = source;
                this.predicate = predicate;
                this.selector = selector;
            }
            public override Enumerable.Iterator<TResult> Clone()
            {
                return new Enumerable.WhereSelectArrayIterator<TSource, TResult>(this.source, this.predicate, this.selector);
            }
            public override bool MoveNext()
            {
                if (this.state == 1)
                {
                    while (this.index < this.source.Length)
                    {
                        TSource arg = this.source[this.index];
                        this.index++;
                        if (this.predicate == null || this.predicate(arg))
                        {
                            this.current = this.selector(arg);
                            return true;
                        }
                    }
                    this.Dispose();
                }
                return false;
            }
            public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
            {
                return new Enumerable.WhereSelectArrayIterator<TSource, TResult2>(this.source, this.predicate, Enumerable.CombineSelectors<TSource, TResult, TResult2>(this.selector, selector));
            }
            public override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
            {
                return new Enumerable.WhereEnumerableIterator<TResult>(this, predicate);
            }
        }
    }
}