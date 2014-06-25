using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {
        [JsType(Name = "System.Linq.Enumerable.Iterator", Filename = "~/res/System.Linq.js")]
        private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
        {
            //private int threadId;
            internal int state;
            internal TSource current;
            public TSource Current
            {
                get
                {
                    return this.current;
                }
            }
            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }
            public Iterator()
            {
                //this.threadId = Thread.CurrentThread.ManagedThreadId;
            }
            public abstract Enumerable.Iterator<TSource> Clone();
            public virtual void Dispose()
            {
                this.current = default(TSource);
                this.state = -1;
            }
            public IEnumerator<TSource> GetEnumerator()
            {
                if (/*this.threadId == Thread.CurrentThread.ManagedThreadId && */this.state == 0)
                {
                    this.state = 1;
                    return this;
                }
                Enumerable.Iterator<TSource> iterator = this.Clone();
                iterator.state = 1;
                return iterator;
            }
            public abstract bool MoveNext();
            public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
            public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}