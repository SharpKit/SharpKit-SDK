using System;
using System.Collections.Generic;
using System.Linq;
namespace SharpKit.JavaScript.Private
{

    partial class Enumerable
    {
        [JsType(Name = "System.Linq.Enumerable.WhereArrayIterator", Filename = "~/res/System.Linq.js")]
        private class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
        {
            private TSource[] source;
            private Func<TSource, bool> predicate;
            private int index;
            public WhereArrayIterator(TSource[] source, Func<TSource, bool> predicate)
            {
                this.source = source;
                this.predicate = predicate;
            }
            public override Enumerable.Iterator<TSource> Clone()
            {
                return new Enumerable.WhereArrayIterator<TSource>(this.source, this.predicate);
            }
            public override bool MoveNext()
            {
                if (this.state == 1)
                {
                    while (this.index < this.source.Length)
                    {
                        TSource tSource = this.source[this.index];
                        this.index++;
                        if (this.predicate(tSource))
                        {
                            this.current = tSource;
                            return true;
                        }
                    }
                    this.Dispose();
                }
                return false;
            }
            public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
            {
                return new Enumerable.WhereSelectArrayIterator<TSource, TResult>(this.source, this.predicate, selector);
            }
            public override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
            {
                return new Enumerable.WhereArrayIterator<TSource>(this.source, Enumerable.CombinePredicates<TSource>(this.predicate, predicate));
            }
        }
    }
}