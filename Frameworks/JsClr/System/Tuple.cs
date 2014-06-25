using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Tuple", Filename = "~/Internal/Core.js")]
    public static class Tuple
    {
        /// <summary>Creates a new 1-tuple, or singleton.</summary>
        /// <returns>A tuple whose value is (<paramref name="item1" />).</returns>
        /// <param name="item1">The value of the only component of the tuple.</param>
        /// <typeparam name="T1">The type of the only component of the tuple.</typeparam>
        public static Tuple<T1> Create<T1>(T1 item1)
        {
            return new Tuple<T1>(item1);
        }
        /// <summary>Creates a new 2-tuple, or pair.</summary>
        /// <returns>A 2-tuple whose value is (<paramref name="item1" />, <paramref name="item2" />).</returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
        {
            return new Tuple<T1, T2>(item1, item2);
        }
        /// <summary>Creates a new 3-tuple, or triple.</summary>
        /// <returns>A 3-tuple whose value is (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />).</returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }
        /// <summary>Creates a new 4-tuple, or quadruple.</summary>
        /// <returns>A 4-tuple whose value is (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />).</returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <param name="item4">The value of the fourth component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        /// <typeparam name="T4">The type of the fourth component of the tuple.  </typeparam>
        public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }
        /// <summary>Creates a new 5-tuple, or quintuple.</summary>
        /// <returns>A 5-tuple whose value is (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />).</returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <param name="item4">The value of the fourth component of the tuple.</param>
        /// <param name="item5">The value of the fifth component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        /// <typeparam name="T4">The type of the fourth component of the tuple.</typeparam>
        /// <typeparam name="T5">The type of the fifth component of the tuple.</typeparam>
        public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }
        /// <summary>Creates a new 6-tuple, or sextuple.</summary>
        /// <returns>A 6-tuple whose value is (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />, <paramref name="item6" />).</returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <param name="item4">The value of the fourth component of the tuple.</param>
        /// <param name="item5">The value of the fifth component of the tuple.</param>
        /// <param name="item6">The value of the sixth component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        /// <typeparam name="T4">The type of the fourth component of the tuple.</typeparam>
        /// <typeparam name="T5">The type of the fifth component of the tuple.</typeparam>
        /// <typeparam name="T6">The type of the sixth component of the tuple.</typeparam>
        public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }
        /// <summary>Creates a new 7-tuple, or septuple.</summary>
        /// <returns>A 7-tuple whose value is (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />, <paramref name="item6" />, <paramref name="item7" />).</returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <param name="item4">The value of the fourth component of the tuple.</param>
        /// <param name="item5">The value of the fifth component of the tuple.</param>
        /// <param name="item6">The value of the sixth component of the tuple.</param>
        /// <param name="item7">The value of the seventh component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        /// <typeparam name="T4">The type of the fourth component of the tuple.</typeparam>
        /// <typeparam name="T5">The type of the fifth component of the tuple.</typeparam>
        /// <typeparam name="T6">The type of the sixth component of the tuple.</typeparam>
        /// <typeparam name="T7">The type of the seventh component of the tuple.</typeparam>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }
#if NET4
        /// <summary>Creates a new 8-tuple, or octuple.</summary>
        /// <returns>An 8-tuple (octuple) whose value is (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />, <paramref name="item6" />, <paramref name="item7" />, <paramref name="item8" />). </returns>
        /// <param name="item1">The value of the first component of the tuple.</param>
        /// <param name="item2">The value of the second component of the tuple.</param>
        /// <param name="item3">The value of the third component of the tuple.</param>
        /// <param name="item4">The value of the fourth component of the tuple.</param>
        /// <param name="item5">The value of the fifth component of the tuple.</param>
        /// <param name="item6">The value of the sixth component of the tuple.</param>
        /// <param name="item7">The value of the seventh component of the tuple.</param>
        /// <param name="item8">The value of the eighth component of the tuple.</param>
        /// <typeparam name="T1">The type of the first component of the tuple.</typeparam>
        /// <typeparam name="T2">The type of the second component of the tuple.</typeparam>
        /// <typeparam name="T3">The type of the third component of the tuple.</typeparam>
        /// <typeparam name="T4">The type of the fourth component of the tuple.</typeparam>
        /// <typeparam name="T5">The type of the fifth component of the tuple.</typeparam>
        /// <typeparam name="T6">The type of the sixth component of the tuple.</typeparam>
        /// <typeparam name="T7">The type of the seventh component of the tuple.</typeparam>
        /// <typeparam name="T8">The type of the eighth component of the tuple.</typeparam>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new Tuple<T8>(item8));
        }
#endif
    }

    [JsType(Name = "System.Tuple$1", Filename = "~/Internal/Core.js")]
    public class Tuple<T1>
    {
        public Tuple(T1 item1)
        {
            this._item1 = item1;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

    }

    [JsType(Name = "System.Tuple$2", Filename = "~/Internal/Core.js")]
    public class Tuple<T1, T2>
    {
        public Tuple(T1 item1, T2 item2)
        {
            this._item1 = item1;
            this._item2 = item2;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

        private T2 _item2;
        public T2 Item2 { get { return _item2; } }

    }

    [JsType(Name = "System.Tuple$3", Filename = "~/Internal/Core.js")]
    public class Tuple<T1, T2, T3>
    {
        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            this._item1 = item1;
            this._item2 = item2;
            this._item3 = item3;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

        private T2 _item2;
        public T2 Item2 { get { return _item2; } }

        private T3 _item3;
        public T3 Item3 { get { return _item3; } }

    }

    [JsType(Name = "System.Tuple$4", Filename = "~/Internal/Core.js")]
    public class Tuple<T1, T2, T3, T4>
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            this._item1 = item1;
            this._item2 = item2;
            this._item3 = item3;
            this._item4 = item4;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

        private T2 _item2;
        public T2 Item2 { get { return _item2; } }

        private T3 _item3;
        public T3 Item3 { get { return _item3; } }

        private T4 _item4;
        public T4 Item4 { get { return _item4; } }

    }

    [JsType(Name = "System.Tuple$5", Filename = "~/Internal/Core.js")]
    public class Tuple<T1, T2, T3, T4, T5>
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            this._item1 = item1;
            this._item2 = item2;
            this._item3 = item3;
            this._item4 = item4;
            this._item5 = item5;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

        private T2 _item2;
        public T2 Item2 { get { return _item2; } }

        private T3 _item3;
        public T3 Item3 { get { return _item3; } }

        private T4 _item4;
        public T4 Item4 { get { return _item4; } }

        private T5 _item5;
        public T5 Item5 { get { return _item5; } }

    }

    [JsType(Name = "System.Tuple$6", Filename = "~/Internal/Core.js")]
    public class Tuple<T1, T2, T3, T4, T5, T6>
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            this._item1 = item1;
            this._item2 = item2;
            this._item3 = item3;
            this._item4 = item4;
            this._item5 = item5;
            this._item6 = item6;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

        private T2 _item2;
        public T2 Item2 { get { return _item2; } }

        private T3 _item3;
        public T3 Item3 { get { return _item3; } }

        private T4 _item4;
        public T4 Item4 { get { return _item4; } }

        private T5 _item5;
        public T5 Item5 { get { return _item5; } }

        private T6 _item6;
        public T6 Item6 { get { return _item6; } }

    }

    [JsType(Name = "System.Tuple$7", Filename = "~/Internal/Core.js")]
    public class Tuple<T1, T2, T3, T4, T5, T6, T7>
    {
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            this._item1 = item1;
            this._item2 = item2;
            this._item3 = item3;
            this._item4 = item4;
            this._item5 = item5;
            this._item6 = item6;
            this._item7 = item7;
        }

        private T1 _item1;
        public T1 Item1 { get { return _item1; } }

        private T2 _item2;
        public T2 Item2 { get { return _item2; } }

        private T3 _item3;
        public T3 Item3 { get { return _item3; } }

        private T4 _item4;
        public T4 Item4 { get { return _item4; } }

        private T5 _item5;
        public T5 Item5 { get { return _item5; } }

        private T6 _item6;
        public T6 Item6 { get { return _item6; } }

        private T7 _item7;
        public T7 Item7 { get { return _item7; } }

    }

}
