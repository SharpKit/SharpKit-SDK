using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SharpKit.ExtJs4.Generator
{
    static class Extensions
    {
        public static bool IsInRange(this int x, int from, int to)
        {
            return x >= from && x <= to;
        }
        public static R If<R>(this bool condition, R ifTrue)
        {
            if (condition)
                return ifTrue;
            return default(R);
        }
        public static R If<R>(this bool condition, R ifTrue, R ifNotTrue)
        {
            if (condition)
                return ifTrue;
            else
                return ifNotTrue;
        }
        [DebuggerStepThrough]
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
                action(item);
        }
        [DebuggerStepThrough]
        public static void ForEach<T>(this IEnumerable<T> items, Action<T, int> action)
        {
            var i = 0;
            foreach (var item in items)
            {
                action(item, i);
                i++;
            }
        }
        public static void ForEachJoin<T>(this IEnumerable<T> items, Action<T> action, Action actionBetweenItems)
        {
            var first = true;
            foreach (var item in items)
            {
                if (first)
                    first = false;
                else
                    actionBetweenItems();
                action(item);
            }
        }


        public static void ForEachTwice<T1, T2>(this IEnumerable<T1> items, IEnumerable<T2> items2, Action<T1, T2> action)
        {
            var i1 = items.GetEnumerator();
            var i2 = items2.GetEnumerator();
            var hasItems1 = true;
            var hasItems2 = true;
            while (hasItems1 || hasItems2)
            {
                if (hasItems1)
                    hasItems1 = i1.MoveNext();
                if (hasItems2)
                    hasItems2 = i2.MoveNext();
                action(i1.Current, i2.Current);
            }
        }

        public static bool TrueForAllTwice<T1, T2>(this IEnumerable<T1> items, IEnumerable<T2> items2, Func<T1, T2, bool> func)
        {
            var i1 = items.GetEnumerator();
            var i2 = items2.GetEnumerator();
            var hasItems1 = true;
            var hasItems2 = true;
            while (hasItems1 && hasItems2)
            {
                hasItems1 = i1.MoveNext();
                hasItems2 = i2.MoveNext();
                if (!hasItems1 || !hasItems2)
                    break;
                if (!func(i1.Current, i2.Current))
                    return false;
            }
            return hasItems1 == hasItems2;
        }

        //public static T Clone<T>(this T obj) where T : Element
        //{
        //    return obj.Clone2() as T;
        //}

    }
}
