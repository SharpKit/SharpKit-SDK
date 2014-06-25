using System;
using System.Collections.Generic;

using System.Text;

using System.Collections;

namespace SharpKit.JavaScript.Private
{
    partial class Enumerable
    {
        [JsType(Name = "System.Linq.Enumerable.OfTypeIterator", Filename = "~/res/System.Linq.js")]
        class OfTypeIterator<T> : IEnumerator<T>, IEnumerable<T>
        {
            public OfTypeIterator(IEnumerable source)
            {
                this.Source = source;
            }
            IEnumerable Source;
            IEnumerator SourceEnumerator;

            public void Reset()
            {
                if (SourceEnumerator != null)
                    this.SourceEnumerator.Reset();
            }
            public T Current
            {
                get
                {
                    return SourceEnumerator.Current.As<T>();
                }
            }
            public bool MoveNext()
            {
                if (SourceEnumerator == null)
                    SourceEnumerator = Source.GetEnumerator();
                while (true)
                {
                    if (!SourceEnumerator.MoveNext())
                        return false;
                    var item = SourceEnumerator.Current;
                    if (item is T)
                        return true;
                }
            }

            #region IDisposable Members

            public void Dispose()
            {
                Source = null;
                SourceEnumerator = null;
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            void System.Collections.IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            #endregion

            #region IEnumerable<T> Members

            public IEnumerator<T> GetEnumerator()
            {
                return this;
            }

            #endregion

            #region IEnumerable Members

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            #endregion
        }


        [JsType(Name = "System.Linq.Enumerable.SkipIterator", Filename = "~/res/System.Linq.js")]
        class SkipIterator<T> : IEnumerator<T>, IEnumerable<T>
        {
            public SkipIterator(IEnumerable source, int skipCount)
            {
                this.Source = source;
                SkipCount = skipCount;
            }
            int SkipCount;
            IEnumerable Source;
            IEnumerator SourceEnumerator;

            public void Reset()
            {
                if (SourceEnumerator != null)
                    this.SourceEnumerator.Reset();
            }
            public T Current
            {
                get
                {
                    return SourceEnumerator.Current.As<T>();
                }
            }
            int State;
            public bool MoveNext()
            {
                if (State == 0)
                {
                    SourceEnumerator = Source.GetEnumerator();
                    State = 1;
                }
                if (State == 1)
                {
                    for (var i = 0; i < SkipCount; i++)
                    {
                        if (!SourceEnumerator.MoveNext())
                            return false;
                    }
                    State = 2;
                }
                if (State == 2)
                {
                    return SourceEnumerator.MoveNext();
                }
                return false;
            }

            #region IDisposable Members

            public void Dispose()
            {
                Source = null;
                SourceEnumerator = null;
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            void System.Collections.IEnumerator.Reset()
            {
                State = 0;
            }

            #endregion

            #region IEnumerable<T> Members

            public IEnumerator<T> GetEnumerator()
            {
                if (State == 0)
                    return this;
                return new SkipIterator<T>(Source, SkipCount);
            }

            #endregion

            #region IEnumerable Members

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            #endregion

        }

        [JsType(Name = "System.Linq.Enumerable.TakeIterator", Filename = "~/res/System.Linq.js")]
        class TakeIterator<T> : IEnumerator<T>, IEnumerable<T>
        {
            public TakeIterator(IEnumerable source, int takeCount)
            {
                this.Source = source;
                TakeCount = takeCount;
            }
            int TakeCount;
            IEnumerable Source;
            IEnumerator SourceEnumerator;

            public void Reset()
            {
                if (SourceEnumerator != null)
                    this.SourceEnumerator.Reset();
            }
            public T Current
            {
                get
                {
                    return SourceEnumerator.Current.As<T>();
                }
            }
            int State;
            int TakeIndex;
            public bool MoveNext()
            {
                if (State == 0)
                {
                    SourceEnumerator = Source.GetEnumerator();
                    State = 1;
                }
                if (State == 1)
                {
                    if (SourceEnumerator.MoveNext())
                    {
                        TakeIndex++;
                        if (TakeIndex <= TakeCount)
                            return true;
                    }
                    State = 2;
                    return false;
                }
                return false;
            }

            #region IDisposable Members

            public void Dispose()
            {
                Source = null;
                SourceEnumerator = null;
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            void System.Collections.IEnumerator.Reset()
            {
                State = 0;
            }

            #endregion

            #region IEnumerable<T> Members

            public IEnumerator<T> GetEnumerator()
            {
                if (State == 0)
                    return this;
                return new TakeIterator<T>(Source, TakeCount);
            }

            #endregion

            #region IEnumerable Members

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            #endregion

        }

        [JsType(Name = "System.Linq.Enumerable.ConcatIterator", Filename = "~/res/System.Linq.js")]
        class ConcatIterator<T> : IEnumerator<T>, IEnumerable<T>
        {
            public ConcatIterator(IEnumerable first, IEnumerable second)
            {
                this.First = first;
                this.Second = second;
            }
            IEnumerable First;
            IEnumerable Second;
            IEnumerator FirstEnumerator;
            IEnumerator SecondEnumerator;
            int State;
            bool onFirst = true;

            public void Reset()
            {
                if (FirstEnumerator != null)
                    this.FirstEnumerator.Reset();
                if (SecondEnumerator != null)
                    this.SecondEnumerator.Reset();
                onFirst = true;
            }
            public T Current
            {
                get
                {
                    if (State == 1)
                    {
                        return FirstEnumerator.Current.As<T>();
                    }
                    if (State == 3)
                    {
                        return SecondEnumerator.Current.As<T>();
                    }
                    throw new InvalidOperationException();
                }
            }
            
            public bool MoveNext()
            {
                if (State == 0)
                {
                    FirstEnumerator = First.GetEnumerator();
                    State = 1;
                }
                if (State == 1)
                {
                    if (FirstEnumerator.MoveNext())
                    {
                        return true;
                    }
                    State = 2;
                }
                if (State == 2)
                {
                    SecondEnumerator = Second.GetEnumerator();
                    State = 3;
                }
                if (State == 3)
                {
                    if (SecondEnumerator.MoveNext())
                    {
                        return true;
                    }
                    State = 4;
                }
                return false;
            }

            #region IDisposable Members

            public void Dispose()
            {
                First = null;
                FirstEnumerator = null;
                Second = null;
                SecondEnumerator = null;
            }

            #endregion

            #region IEnumerator Members

            object System.Collections.IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            void System.Collections.IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            #endregion

            #region IEnumerable<T> Members

            public IEnumerator<T> GetEnumerator()
            {
                if (State == 0)
                    return this;
                return new ConcatIterator<T>(First, Second);
            }

            #endregion

            #region IEnumerable Members

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            #endregion

        }
    }

}
