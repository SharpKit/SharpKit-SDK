using System;
using System.Collections;
using System.Collections.Generic;
using SharpKit.JsClr.System.Linq;

namespace SharpKit.JavaScript.Private
{

    [JsType(Name = "System.Linq.Enumerable", Filename = "~/res/System.Linq.js")]
    internal static partial class Enumerable
    {
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0)
                {
                    return list[0];
                }
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        return enumerator.Current;
                    }
                }
            }
            throw Error.NoElements();
        }

        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            foreach (TSource local in source)
            {
                if (predicate(local))
                {
                    return local;
                }
            }
            throw Error.NoMatch();
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0)
                {
                    return list[0];
                }
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        return enumerator.Current;
                    }
                }
            }
            return default(TSource);
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            foreach (TSource local in source)
            {
                if (predicate(local))
                {
                    return local;
                }
            }
            return default(TSource);
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, 
        /// and throws an exception if more than one such element exists.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <c ref="System.Collections.Generic.IEnumerable{T}">IEnumerable&lt;T&gt;</c> to return the single element of.</param>
        /// <returns>The single element of the input sequence, or default(TSource) if the sequence contains no elements.</returns>
        public static TSource Single<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw Error.ArgumentNull("source");

            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count == 1)
                    return list[0];
                else
                    throw new InvalidOperationException();
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                        return enumerator.Current;
                }
            }
            throw Error.NoElements();
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, 
        /// and throws an exception if more than one such element exists.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <c ref="System.Collections.Generic.IEnumerable{T}">IEnumerable&lt;T&gt;</c> to return the single element of.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence, or default(TSource) if the sequence contains no elements.</returns>
        public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull("source");

            if (predicate == null)
                throw Error.ArgumentNull("predicate");

            foreach (TSource local in source)
                if (predicate(local))
                    return local;

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the only element of a sequence, or a default value if the sequence is empty; 
        /// this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An <c ref="System.Collections.Generic.IEnumerable{T}">IEnumerable&lt;T&gt;</c> to return the single element of.</param>
        /// <returns>The single element of the input sequence, or default(TSource) if the sequence contains no elements.</returns>
        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
                throw Error.ArgumentNull("source");

            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count == 1)
                    return list[0];
                else
                    throw new InvalidOperationException();
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                        return enumerator.Current;
                }
            }
            return default(TSource);
        }

        /// <summary>
        /// Returns the only element of a sequence, or a default value if the sequence is empty;
        /// this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <param name="source">An <c ref="System.Collections.Generic.IEnumerable{T}">IEnumerable&lt;T&gt;</c> to return the single element of.</param>
        /// <param name="predicate">A function to test an element for a condition.</param>
        /// <returns>The single element of the input sequence, or default(TSource) if the sequence contains no elements.</returns>
        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            // TODO: Check for more than 1 matching element.
            if (source == null)
                throw Error.ArgumentNull("source");

            if (predicate == null)
                throw Error.ArgumentNull("predicate");

            foreach (TSource local in source)
                if (predicate(local))
                    return local;
            return default(TSource);
        }

        public static TSource Last<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                int count = list.Count;
                if (count > 0)
                {
                    return list[count - 1];
                }
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        TSource current;
                        do
                        {
                            current = enumerator.Current;
                        }
                        while (enumerator.MoveNext());
                        return current;
                    }
                }
            }
            throw Error.NoElements();
        }

        public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            TSource local = default(TSource);
            bool flag = false;
            foreach (TSource local2 in source)
            {
                if (predicate(local2))
                {
                    local = local2;
                    flag = true;
                }
            }
            if (!flag)
            {
                throw Error.NoMatch();
            }
            return local;
        }

        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                int count = list.Count;
                if (count > 0)
                {
                    return list[count - 1];
                }
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        TSource current;
                        do
                        {
                            current = enumerator.Current;
                        }
                        while (enumerator.MoveNext());
                        return current;
                    }
                }
            }
            return default(TSource);
        }

        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            TSource local = default(TSource);
            foreach (TSource local2 in source)
            {
                if (predicate(local2))
                {
                    local = local2;
                }
            }
            return local;
        }

        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            if (source is Enumerable.Iterator<TSource>)
            {
                return ((Enumerable.Iterator<TSource>)source).Where(predicate);
            }
            if (source is TSource[])
            {
                return new Enumerable.WhereArrayIterator<TSource>((TSource[])source, predicate);
            }
            if (source is List<TSource>)
            {
                return new Enumerable.WhereListIterator<TSource>((List<TSource>)source, predicate);
            }
            return new Enumerable.WhereEnumerableIterator<TSource>(source, predicate);
        }

        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            throw new NotImplementedException();
            //return new WhereEnumerator<TSource>(source, predicate);
        }

        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
        {
            if (source == null)
                throw Error.ArgumentNull("source");
            ICollection<TSource> is2 = source as ICollection<TSource>;
            if (is2 != null)
                return is2.Contains(value);
            foreach (TSource local in source)
            {
                if (local.As<object>() == value.As<object>())
                    return true;
            }
            return false;
        }

        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            if (comparer == null)
            {
                return source.Contains(value);
                //comparer = EqualityComparer<TSource>.Default;
            }
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            foreach (TSource local in source)
            {
                if (comparer.Equals(local, value))
                {
                    return true;
                }
            }
            return false;
        }

        //// Methods
        //public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (func == null)
        //  {
        //    throw Error.ArgumentNull("func");
        //  }
        //  using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //  {
        //    if (!enumerator.MoveNext())
        //    {
        //      throw Error.NoElements();
        //    }
        //    TSource current = enumerator.Current;
        //    while (enumerator.MoveNext())
        //    {
        //      current = func(current, enumerator.Current);
        //    }
        //    return current;
        //  }
        //}

        //public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (func == null)
        //  {
        //    throw Error.ArgumentNull("func");
        //  }
        //  TAccumulate local = seed;
        //  foreach (TSource local2 in source)
        //  {
        //    local = func(local, local2);
        //  }
        //  return local;
        //}

        //public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (func == null)
        //  {
        //    throw Error.ArgumentNull("func");
        //  }
        //  if (resultSelector == null)
        //  {
        //    throw Error.ArgumentNull("resultSelector");
        //  }
        //  TAccumulate local = seed;
        //  foreach (TSource local2 in source)
        //  {
        //    local = func(local, local2);
        //  }
        //  return resultSelector(local);
        //}

        //public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (predicate == null)
        //  {
        //    throw Error.ArgumentNull("predicate");
        //  }
        //  foreach (TSource local in source)
        //  {
        //    if (!predicate(local))
        //    {
        //      return false;
        //    }
        //  }
        //  return true;
        //}

        public static bool Any<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            using (IEnumerator<TSource> enumerator = source.GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            foreach (TSource local in source)
            {
                if (predicate(local))
                {
                    return true;
                }
            }
            return false;
        }

        //public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
        //{
        //  return source;
        //}

        //public static decimal Average(this IEnumerable<decimal> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  decimal num = 0M;
        //  long num2 = 0L;
        //  foreach (decimal num3 in source)
        //  {
        //    num += num3;
        //    num2 += 1L;
        //  }
        //  if (num2 <= 0L)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return (num / num2);
        //}

        //public static decimal? Average(this IEnumerable<decimal?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  decimal num = 0M;
        //  long num2 = 0L;
        //  foreach (decimal? nullable in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      num += nullable.GetValueOrDefault();
        //      num2 += 1L;
        //    }
        //  }
        //  if (num2 > 0L)
        //  {
        //    return new decimal?(num / num2);
        //  }
        //  return null;
        //}

        //public static double? Average(this IEnumerable<double?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double num = 0.0;
        //  long num2 = 0L;
        //  foreach (double? nullable in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      num += nullable.GetValueOrDefault();
        //      num2 += 1L;
        //    }
        //  }
        //  if (num2 > 0L)
        //  {
        //    return new double?(num / ((double)num2));
        //  }
        //  return null;
        //}

        //public static double? Average(this IEnumerable<int?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  long num2 = 0L;
        //  foreach (int? nullable in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      num += (long)nullable.GetValueOrDefault();
        //      num2 += 1L;
        //    }
        //  }
        //  if (num2 > 0L)
        //  {
        //    return new double?(((double)num) / ((double)num2));
        //  }
        //  return null;
        //}

        //public static double? Average(this IEnumerable<long?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  long num2 = 0L;
        //  foreach (long? nullable in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      num += nullable.GetValueOrDefault();
        //      num2 += 1L;
        //    }
        //  }
        //  if (num2 > 0L)
        //  {
        //    return new double?(((double)num) / ((double)num2));
        //  }
        //  return null;
        //}

        //public static float? Average(this IEnumerable<float?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double num = 0.0;
        //  long num2 = 0L;
        //  foreach (float? nullable in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      num += (double)nullable.GetValueOrDefault();
        //      num2 += 1L;
        //    }
        //  }
        //  if (num2 > 0L)
        //  {
        //    return new float?((float)(num / ((double)num2)));
        //  }
        //  return null;
        //}

        //public static double Average(this IEnumerable<double> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double num = 0.0;
        //  long num2 = 0L;
        //  foreach (double num3 in source)
        //  {
        //    num += num3;
        //    num2 += 1L;
        //  }
        //  if (num2 <= 0L)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return (num / ((double)num2));
        //}

        //public static double Average(this IEnumerable<int> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  long num2 = 0L;
        //  foreach (int num3 in source)
        //  {
        //    num += num3;
        //    num2 += 1L;
        //  }
        //  if (num2 <= 0L)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return (((double)num) / ((double)num2));
        //}

        //public static double Average(this IEnumerable<long> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  long num2 = 0L;
        //  foreach (long num3 in source)
        //  {
        //    num += num3;
        //    num2 += 1L;
        //  }
        //  if (num2 <= 0L)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return (((double)num) / ((double)num2));
        //}

        //public static float Average(this IEnumerable<float> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double num = 0.0;
        //  long num2 = 0L;
        //  foreach (float num3 in source)
        //  {
        //    num += num3;
        //    num2 += 1L;
        //  }
        //  if (num2 <= 0L)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return (float)(num / ((double)num2));
        //}

        //public static decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        //{
        //  return source.Select<TSource, decimal>(selector).Average();
        //}

        //public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        //{
        //  return source.Select<TSource, double>(selector).Average();
        //}

        //public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        //{
        //  return source.Select<TSource, int>(selector).Average();
        //}

        //public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        //{
        //  return source.Select<TSource, long>(selector).Average();
        //}

        //public static decimal? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        //{
        //  return source.Select<TSource, decimal?>(selector).Average();
        //}

        //public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        //{
        //  return source.Select<TSource, double?>(selector).Average();
        //}

        //public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        //{
        //  return source.Select<TSource, int?>(selector).Average();
        //}

        //public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        //{
        //  return source.Select<TSource, long?>(selector).Average();
        //}

        //public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        //{
        //  return source.Select<TSource, float?>(selector).Average();
        //}

        //public static float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        //{
        //  return source.Select<TSource, float>(selector).Average();
        //}

        //public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  return CastIterator<TResult>(source);
        //}

        //private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
        //{
        //  _CastIterator_d__b0<TResult> _b = new _CastIterator_d__b0<TResult>(-2);
        //  _b.__3__source = source;
        //  return _b;
        //}

        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null)
            {
                throw Error.ArgumentNull("first");
            }
            if (second == null)
            {
                throw Error.ArgumentNull("second");
            }
            return new ConcatEnumerable<TSource>(first, second);
        }

        //private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
        //{
        //  _ConcatIterator_d__77<TSource> d__ = new _ConcatIterator_d__77<TSource>(-2);
        //  d__.__3__first = first;
        //  d__.__3__second = second;
        //  return d__;
        //}


        public static int Count<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            ICollection<TSource> is2 = source as ICollection<TSource>;
            if (is2 != null)
            {
                return is2.Count;
            }
            int num = 0;
            using (IEnumerator<TSource> enumerator = source.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    num++;
                }
            }
            return num;
        }


        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (predicate == null)
            {
                throw Error.ArgumentNull("predicate");
            }
            int num = 0;
            foreach (TSource local in source)
            {
                if (predicate(local))
                {
                    num++;
                }
            }
            return num;
        }

        //public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source)
        //{
        //  return source.DefaultIfEmpty<TSource>(default(TSource));
        //}

        //public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  return DefaultIfEmptyIterator<TSource>(source, defaultValue);
        //}

        //private static IEnumerable<TSource> DefaultIfEmptyIterator<TSource>(IEnumerable<TSource> source, TSource defaultValue)
        //{
        //  _DefaultIfEmptyIterator_d__a4<TSource> _a = new _DefaultIfEmptyIterator_d__a4<TSource>(-2);
        //  _a.__3__source = source;
        //  _a.__3__defaultValue = defaultValue;
        //  return _a;
        //}

        //public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  return DistinctIterator<TSource>(source, null);
        //}

        //public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  return DistinctIterator<TSource>(source, comparer);
        //}

        //private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        //{
        //  _DistinctIterator_d__80<TSource> d__ = new _DistinctIterator_d__80<TSource>(-2);
        //  d__.__3__source = source;
        //  d__.__3__comparer = comparer;
        //  return d__;
        //}

        //public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
        //{
        //  TSource current;
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  IList<TSource> list = source as IList<TSource>;
        //  if (list != null)
        //  {
        //    return list[index];
        //  }
        //  if (index < 0)
        //  {
        //    throw Error.ArgumentOutOfRange("index");
        //  }
        //  using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //  {
        //  Label_0036:
        //    if (!enumerator.MoveNext())
        //    {
        //      throw Error.ArgumentOutOfRange("index");
        //    }
        //    if (index == 0)
        //    {
        //      current = enumerator.Current;
        //    }
        //    else
        //    {
        //      index--;
        //      goto Label_0036;
        //    }
        //  }
        //  return current;
        //}

        //public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (index >= 0)
        //  {
        //    IList<TSource> list = source as IList<TSource>;
        //    if (list != null)
        //    {
        //      if (index < list.Count)
        //      {
        //        return list[index];
        //      }
        //    }
        //    else
        //    {
        //      using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //      {
        //        while (enumerator.MoveNext())
        //        {
        //          if (index == 0)
        //          {
        //            return enumerator.Current;
        //          }
        //          index--;
        //        }
        //      }
        //    }
        //  }
        //  return default(TSource);
        //}

        //public static IEnumerable<TResult> Empty<TResult>()
        //{
        //  return EmptyEnumerable<TResult>.Instance;
        //}

        //public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        //{
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  return ExceptIterator<TSource>(first, second, null);
        //}

        //public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  return ExceptIterator<TSource>(first, second, comparer);
        //}

        //private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  _Iterator_d__98<TSource> d__ = new _Iterator_d__98<TSource>(-2);
        //  d__.__3__first = first;
        //  d__.__3__second = second;
        //  d__.__3__comparer = comparer;
        //  return d__;
        //}

        //public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TSource>(source, keySelector, IdentityFunction<TSource>.Instance, null);
        //}

        //public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TSource>(source, keySelector, IdentityFunction<TSource>.Instance, comparer);
        //}

        //public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TElement>(source, keySelector, elementSelector, null);
        //}

        //public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TSource, TResult>(source, keySelector, IdentityFunction<TSource>.Instance, resultSelector, null);
        //}

        //public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TElement>(source, keySelector, elementSelector, comparer);
        //}

        //public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, null);
        //}

        //public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TSource, TResult>(source, keySelector, IdentityFunction<TSource>.Instance, resultSelector, comparer);
        //}

        //public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //{
        //  return new GroupedEnumerable<TSource, TKey, TElement, TResult>(source, keySelector, elementSelector, resultSelector, comparer);
        //}

        //public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        //{
        //  if (outer == null)
        //  {
        //    throw Error.ArgumentNull("outer");
        //  }
        //  if (inner == null)
        //  {
        //    throw Error.ArgumentNull("inner");
        //  }
        //  if (outerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("outerKeySelector");
        //  }
        //  if (innerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("innerKeySelector");
        //  }
        //  if (resultSelector == null)
        //  {
        //    throw Error.ArgumentNull("resultSelector");
        //  }
        //  return GroupJoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
        //}

        //public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //{
        //  if (outer == null)
        //  {
        //    throw Error.ArgumentNull("outer");
        //  }
        //  if (inner == null)
        //  {
        //    throw Error.ArgumentNull("inner");
        //  }
        //  if (outerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("outerKeySelector");
        //  }
        //  if (innerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("innerKeySelector");
        //  }
        //  if (resultSelector == null)
        //  {
        //    throw Error.ArgumentNull("resultSelector");
        //  }
        //  return GroupJoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        //}

        //private static IEnumerable<TResult> GroupJoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //{
        //  _Iterator_d__70<TOuter, TInner, TKey, TResult> d__ = new _Iterator_d__70<TOuter, TInner, TKey, TResult>(-2);
        //  d__.__3__outer = outer;
        //  d__.__3__inner = inner;
        //  d__.__3__outerKeySelector = outerKeySelector;
        //  d__.__3__innerKeySelector = innerKeySelector;
        //  d__.__3__resultSelector = resultSelector;
        //  d__.__3__comparer = comparer;
        //  return d__;
        //}

        //public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        //{
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  return IntersectIterator<TSource>(first, second, null);
        //}

        //public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  return IntersectIterator<TSource>(first, second, comparer);
        //}

        //private static IEnumerable<TSource> IntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  _Iterator_d__91<TSource> d__ = new _Iterator_d__91<TSource>(-2);
        //  d__.__3__first = first;
        //  d__.__3__second = second;
        //  d__.__3__comparer = comparer;
        //  return d__;
        //}

        //public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        //{
        //  if (outer == null)
        //  {
        //    throw Error.ArgumentNull("outer");
        //  }
        //  if (inner == null)
        //  {
        //    throw Error.ArgumentNull("inner");
        //  }
        //  if (outerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("outerKeySelector");
        //  }
        //  if (innerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("innerKeySelector");
        //  }
        //  if (resultSelector == null)
        //  {
        //    throw Error.ArgumentNull("resultSelector");
        //  }
        //  return JoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, null);
        //}

        //public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //{
        //  if (outer == null)
        //  {
        //    throw Error.ArgumentNull("outer");
        //  }
        //  if (inner == null)
        //  {
        //    throw Error.ArgumentNull("inner");
        //  }
        //  if (outerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("outerKeySelector");
        //  }
        //  if (innerKeySelector == null)
        //  {
        //    throw Error.ArgumentNull("innerKeySelector");
        //  }
        //  if (resultSelector == null)
        //  {
        //    throw Error.ArgumentNull("resultSelector");
        //  }
        //  return JoinIterator<TOuter, TInner, TKey, TResult>(outer, inner, outerKeySelector, innerKeySelector, resultSelector, comparer);
        //}

        //private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //{
        //  _Iterator_d__67<TOuter, TInner, TKey, TResult> d__ = new _Iterator_d__67<TOuter, TInner, TKey, TResult>(-2);
        //  d__.__3__outer = outer;
        //  d__.__3__inner = inner;
        //  d__.__3__outerKeySelector = outerKeySelector;
        //  d__.__3__innerKeySelector = innerKeySelector;
        //  d__.__3__resultSelector = resultSelector;
        //  d__.__3__comparer = comparer;
        //  return d__;
        //}

        //public static long LongCount<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //  {
        //    while (enumerator.MoveNext())
        //    {
        //      num += 1L;
        //    }
        //  }
        //  return num;
        //}

        //public static long LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (predicate == null)
        //  {
        //    throw Error.ArgumentNull("predicate");
        //  }
        //  long num = 0L;
        //  foreach (TSource local in source)
        //  {
        //    if (predicate(local))
        //    {
        //      num += 1L;
        //    }
        //  }
        //  return num;
        //}

        //public static decimal Max(this IEnumerable<decimal> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  decimal num = 0M;
        //  bool flag = false;
        //  foreach (decimal num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if (num2 > num)
        //      {
        //        num = num2;
        //      }
        //    }
        //    else
        //    {
        //      num = num2;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static double? Max(this IEnumerable<double?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double? nullable = null;
        //  foreach (double? nullable2 in source)
        //  {
        //    if (nullable2.HasValue)
        //    {
        //      if (nullable.HasValue)
        //      {
        //        double? nullable3 = nullable2;
        //        double? nullable4 = nullable;
        //        if (((nullable3.GetValueOrDefault() <= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue)) && !double.IsNaN(nullable.Value))
        //        {
        //          continue;
        //        }
        //      }
        //      nullable = nullable2;
        //    }
        //  }
        //  return nullable;
        //}

        //public static double Max(this IEnumerable<double> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double d = 0.0;
        //  bool flag = false;
        //  foreach (double num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if ((num2 > d) || double.IsNaN(d))
        //      {
        //        d = num2;
        //      }
        //      continue;
        //    }
        //    d = num2;
        //    flag = true;
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return d;
        //}

        //public static int? Max(this IEnumerable<int?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  int? nullable = null;
        //  foreach (int? nullable2 in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      int? nullable3 = nullable2;
        //      int? nullable4 = nullable;
        //      if ((nullable3.GetValueOrDefault() <= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue))
        //      {
        //        continue;
        //      }
        //    }
        //    nullable = nullable2;
        //  }
        //  return nullable;
        //}

        //public static long? Max(this IEnumerable<long?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long? nullable = null;
        //  foreach (long? nullable2 in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      long? nullable3 = nullable2;
        //      long? nullable4 = nullable;
        //      if ((nullable3.GetValueOrDefault() <= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue))
        //      {
        //        continue;
        //      }
        //    }
        //    nullable = nullable2;
        //  }
        //  return nullable;
        //}

        //public static int Max(this IEnumerable<int> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  int num = 0;
        //  bool flag = false;
        //  foreach (int num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if (num2 > num)
        //      {
        //        num = num2;
        //      }
        //    }
        //    else
        //    {
        //      num = num2;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static decimal? Max(this IEnumerable<decimal?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  decimal? nullable = null;
        //  foreach (decimal? nullable2 in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      decimal? nullable3 = nullable2;
        //      decimal? nullable4 = nullable;
        //      if ((nullable3.GetValueOrDefault() <= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue))
        //      {
        //        continue;
        //      }
        //    }
        //    nullable = nullable2;
        //  }
        //  return nullable;
        //}

        //public static TSource Max<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  Comparer<TSource> comparer = Comparer<TSource>.Default;
        //  TSource y = default(TSource);
        //  if (y == null)
        //  {
        //    foreach (TSource local2 in source)
        //    {
        //      if ((local2 != null) && ((y == null) || (comparer.Compare(local2, y) > 0)))
        //      {
        //        y = local2;
        //      }
        //    }
        //    return y;
        //  }
        //  bool flag = false;
        //  foreach (TSource local3 in source)
        //  {
        //    if (flag)
        //    {
        //      if (comparer.Compare(local3, y) > 0)
        //      {
        //        y = local3;
        //      }
        //    }
        //    else
        //    {
        //      y = local3;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return y;
        //}

        //public static long Max(this IEnumerable<long> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  bool flag = false;
        //  foreach (long num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if (num2 > num)
        //      {
        //        num = num2;
        //      }
        //    }
        //    else
        //    {
        //      num = num2;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static float? Max(this IEnumerable<float?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  float? nullable = null;
        //  foreach (float? nullable2 in source)
        //  {
        //    if (nullable2.HasValue)
        //    {
        //      if (nullable.HasValue)
        //      {
        //        float? nullable3 = nullable2;
        //        float? nullable4 = nullable;
        //        if (((nullable3.GetValueOrDefault() <= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue)) && !float.IsNaN(nullable.Value))
        //        {
        //          continue;
        //        }
        //      }
        //      nullable = nullable2;
        //    }
        //  }
        //  return nullable;
        //}

        //public static float Max(this IEnumerable<float> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  float num = 0f;
        //  bool flag = false;
        //  foreach (float num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if ((num2 > num) || double.IsNaN((double)num))
        //      {
        //        num = num2;
        //      }
        //      continue;
        //    }
        //    num = num2;
        //    flag = true;
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static decimal Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        //{
        //  return source.Select<TSource, decimal>(selector).Max();
        //}

        //public static double Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        //{
        //  return source.Select<TSource, double>(selector).Max();
        //}

        //public static decimal? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        //{
        //  return source.Select<TSource, decimal?>(selector).Max();
        //}

        //public static double? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        //{
        //  return source.Select<TSource, double?>(selector).Max();
        //}

        //public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        //{
        //  return source.Select<TSource, int>(selector).Max();
        //}

        //public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        //{
        //  return source.Select<TSource, TResult>(selector).Max<TResult>();
        //}

        //public static int? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        //{
        //  return source.Select<TSource, int?>(selector).Max();
        //}

        //public static long? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        //{
        //  return source.Select<TSource, long?>(selector).Max();
        //}

        //public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        //{
        //  return source.Select<TSource, long>(selector).Max();
        //}

        //public static float? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        //{
        //  return source.Select<TSource, float?>(selector).Max();
        //}

        //public static float Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        //{
        //  return source.Select<TSource, float>(selector).Max();
        //}

        //public static decimal Min(this IEnumerable<decimal> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  decimal num = 0M;
        //  bool flag = false;
        //  foreach (decimal num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if (num2 < num)
        //      {
        //        num = num2;
        //      }
        //    }
        //    else
        //    {
        //      num = num2;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static double Min(this IEnumerable<double> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double num = 0.0;
        //  bool flag = false;
        //  foreach (double num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if ((num2 < num) || double.IsNaN(num2))
        //      {
        //        num = num2;
        //      }
        //      continue;
        //    }
        //    num = num2;
        //    flag = true;
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static decimal? Min(this IEnumerable<decimal?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  decimal? nullable = null;
        //  foreach (decimal? nullable2 in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      decimal? nullable3 = nullable2;
        //      decimal? nullable4 = nullable;
        //      if ((nullable3.GetValueOrDefault() >= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue))
        //      {
        //        continue;
        //      }
        //    }
        //    nullable = nullable2;
        //  }
        //  return nullable;
        //}

        //public static double? Min(this IEnumerable<double?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  double? nullable = null;
        //  foreach (double? nullable2 in source)
        //  {
        //    if (nullable2.HasValue)
        //    {
        //      if (nullable.HasValue)
        //      {
        //        double? nullable3 = nullable2;
        //        double? nullable4 = nullable;
        //        if (((nullable3.GetValueOrDefault() >= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue)) && !double.IsNaN(nullable2.Value))
        //        {
        //          continue;
        //        }
        //      }
        //      nullable = nullable2;
        //    }
        //  }
        //  return nullable;
        //}

        //public static TSource Min<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  Comparer<TSource> comparer = Comparer<TSource>.Default;
        //  TSource y = default(TSource);
        //  if (y == null)
        //  {
        //    foreach (TSource local2 in source)
        //    {
        //      if ((local2 != null) && ((y == null) || (comparer.Compare(local2, y) < 0)))
        //      {
        //        y = local2;
        //      }
        //    }
        //    return y;
        //  }
        //  bool flag = false;
        //  foreach (TSource local3 in source)
        //  {
        //    if (flag)
        //    {
        //      if (comparer.Compare(local3, y) < 0)
        //      {
        //        y = local3;
        //      }
        //    }
        //    else
        //    {
        //      y = local3;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return y;
        //}

        //public static int? Min(this IEnumerable<int?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  int? nullable = null;
        //  foreach (int? nullable2 in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      int? nullable3 = nullable2;
        //      int? nullable4 = nullable;
        //      if ((nullable3.GetValueOrDefault() >= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue))
        //      {
        //        continue;
        //      }
        //    }
        //    nullable = nullable2;
        //  }
        //  return nullable;
        //}

        //public static long? Min(this IEnumerable<long?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long? nullable = null;
        //  foreach (long? nullable2 in source)
        //  {
        //    if (nullable.HasValue)
        //    {
        //      long? nullable3 = nullable2;
        //      long? nullable4 = nullable;
        //      if ((nullable3.GetValueOrDefault() >= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue))
        //      {
        //        continue;
        //      }
        //    }
        //    nullable = nullable2;
        //  }
        //  return nullable;
        //}

        //public static float? Min(this IEnumerable<float?> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  float? nullable = null;
        //  foreach (float? nullable2 in source)
        //  {
        //    if (nullable2.HasValue)
        //    {
        //      if (nullable.HasValue)
        //      {
        //        float? nullable3 = nullable2;
        //        float? nullable4 = nullable;
        //        if (((nullable3.GetValueOrDefault() >= nullable4.GetValueOrDefault()) || !(nullable3.HasValue & nullable4.HasValue)) && !float.IsNaN(nullable2.Value))
        //        {
        //          continue;
        //        }
        //      }
        //      nullable = nullable2;
        //    }
        //  }
        //  return nullable;
        //}

        //public static int Min(this IEnumerable<int> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  int num = 0;
        //  bool flag = false;
        //  foreach (int num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if (num2 < num)
        //      {
        //        num = num2;
        //      }
        //    }
        //    else
        //    {
        //      num = num2;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static long Min(this IEnumerable<long> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  long num = 0L;
        //  bool flag = false;
        //  foreach (long num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if (num2 < num)
        //      {
        //        num = num2;
        //      }
        //    }
        //    else
        //    {
        //      num = num2;
        //      flag = true;
        //    }
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static float Min(this IEnumerable<float> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  float num = 0f;
        //  bool flag = false;
        //  foreach (float num2 in source)
        //  {
        //    if (flag)
        //    {
        //      if ((num2 < num) || float.IsNaN(num2))
        //      {
        //        num = num2;
        //      }
        //      continue;
        //    }
        //    num = num2;
        //    flag = true;
        //  }
        //  if (!flag)
        //  {
        //    throw Error.NoElements();
        //  }
        //  return num;
        //}

        //public static decimal Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        //{
        //  return source.Select<TSource, decimal>(selector).Min();
        //}

        //public static double Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        //{
        //  return source.Select<TSource, double>(selector).Min();
        //}

        //public static long? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        //{
        //  return source.Select<TSource, long?>(selector).Min();
        //}

        //public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        //{
        //  return source.Select<TSource, int>(selector).Min();
        //}

        //public static double? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        //{
        //  return source.Select<TSource, double?>(selector).Min();
        //}

        //public static float? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        //{
        //  return source.Select<TSource, float?>(selector).Min();
        //}

        //public static long Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        //{
        //  return source.Select<TSource, long>(selector).Min();
        //}

        //public static decimal? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        //{
        //  return source.Select<TSource, decimal?>(selector).Min();
        //}

        //public static int? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        //{
        //  return source.Select<TSource, int?>(selector).Min();
        //}

        //public static float Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        //{
        //  return source.Select<TSource, float>(selector).Min();
        //}

        //public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        //{
        //  return source.Select<TSource, TResult>(selector).Min<TResult>();
        //}

        public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            return new OfTypeIterator<TResult>(source);
        }


        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return new OrderedEnumerable<TSource, TKey>(source, keySelector, null, false);
        }

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, false);
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return new OrderedEnumerable<TSource, TKey>(source, keySelector, null, true);
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, true);
        }

        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            return source.CreateOrderedEnumerable<TKey>(keySelector, null, false);
        }

        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            return source.CreateOrderedEnumerable<TKey>(keySelector, comparer, false);
        }

        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            return source.CreateOrderedEnumerable<TKey>(keySelector, null, true);
        }

        public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            return source.CreateOrderedEnumerable<TKey>(keySelector, comparer, true);
        }

        //public static IEnumerable<int> Range(int start, int count)
        //{
        //  long num = (start + count) - 1L;
        //  if ((count < 0) || (num > 0x7fffffffL))
        //  {
        //    throw Error.ArgumentOutOfRange("count");
        //  }
        //  return RangeIterator(start, count);
        //}

        //private static IEnumerable<int> RangeIterator(int start, int count)
        //{
        //  _Iterator_d__b9 _b = new _Iterator_d__b9(-2);
        //  _b.__3__start = start;
        //  _b.__3__count = count;
        //  return _b;
        //}

        //public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
        //{
        //  if (count < 0)
        //  {
        //    throw Error.ArgumentOutOfRange("count");
        //  }
        //  return RepeatIterator<TResult>(element, count);
        //}

        //private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count)
        //{
        //  _Iterator_d__bd<TResult> _bd = new _Iterator_d__bd<TResult>(-2);
        //  _bd.__3__element = element;
        //  _bd.__3__count = count;
        //  return _bd;
        //}

        //public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  return ReverseIterator<TSource>(source);
        //}

        //private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
        //{
        //  _Iterator_d__9f<TSource> d__f = new _Iterator_d__9f<TSource>(-2);
        //  d__f.__3__source = source;
        //  return d__f;
        //}

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }
            if (source is Enumerable.Iterator<TSource>)
            {
                return ((Enumerable.Iterator<TSource>)source).Select<TResult>(selector);
            }
            if (source is TSource[])
            {
                return new Enumerable.WhereSelectArrayIterator<TSource, TResult>((TSource[])source, null, selector);
            }
            if (source is List<TSource>)
            {
                return new Enumerable.WhereSelectListIterator<TSource, TResult>((List<TSource>)source, null, selector);
            }
            return new Enumerable.WhereSelectEnumerableIterator<TSource, TResult>(source, null, selector);
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        {
            throw new NotImplementedException();
        }

        //private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
        //{
        //  _Iterator_d__d<TSource, TResult> _d = new _Iterator_d__d<TSource, TResult>(-2);
        //  _d.__3__source = source;
        //  _d.__3__selector = selector;
        //  return _d;
        //}

        //private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
        //{
        //  _Iterator_d__13<TSource, TResult> d__ = new _Iterator_d__13<TSource, TResult>(-2);
        //  d__.__3__source = source;
        //  d__.__3__selector = selector;
        //  return d__;
        //}

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (selector == null)
            {
                throw Error.ArgumentNull("selector");
            }
            /*if (source is Enumerable.Iterator<TSource>)
            {
                return ((Enumerable.Iterator<TSource>)source).SelectMany(selector);
            }*/
            if (source is TSource[])
            {
                return new Enumerable.SelectManyArrayIterator<TSource, TResult>((TSource[])source, selector);
            }
            if (source is List<TSource>)
            {
                return new Enumerable.SelectManyListIterator<TSource, TResult>((List<TSource>)source, selector);
            }
            return new Enumerable.SelectManyEnumerableIterator<TSource, TResult>(source, selector);
        }

        public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        {
            throw new NotImplementedException();

            /*if (source == null)
            {
              throw Error.ArgumentNull("source");
            }
            if (selector == null)
            {
              throw Error.ArgumentNull("selector");
            }
            return SelectManyIterator<TSource, TResult>(source, selector);*/
        }

        public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            if (collectionSelector == null)
            {
                throw Error.ArgumentNull("collectionSelector");
            }
            if (resultSelector == null)
            {
                throw Error.ArgumentNull("resultSelector");
            }
            return source.SelectMany(t => collectionSelector(t).Select(x => Tuple.Create(t, x))).Select(pair => resultSelector(pair.Item1, pair.Item2));
        }

        //public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (collectionSelector == null)
        //  {
        //    throw Error.ArgumentNull("collectionSelector");
        //  }
        //  if (resultSelector == null)
        //  {
        //    throw Error.ArgumentNull("resultSelector");
        //  }
        //  return SelectManyIterator<TSource, TCollection, TResult>(source, collectionSelector, resultSelector);
        //}

        //private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        //{
        //  _Iterator_d__1a<TSource, TResult> d__a = new _Iterator_d__1a<TSource, TResult>(-2);
        //  d__a.__3__source = source;
        //  d__a.__3__selector = selector;
        //  return d__a;
        //}

        //private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
        //{
        //  _Iterator_d__23<TSource, TResult> d__ = new _Iterator_d__23<TSource, TResult>(-2);
        //  d__.__3__source = source;
        //  d__.__3__selector = selector;
        //  return d__;
        //}

        //private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        //{
        //  _Iterator_d__37<TSource, TCollection, TResult> d__ = new _Iterator_d__37<TSource, TCollection, TResult>(-2);
        //  d__.__3__source = source;
        //  d__.__3__collectionSelector = collectionSelector;
        //  d__.__3__resultSelector = resultSelector;
        //  return d__;
        //}

        //private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
        //{
        //  _Iterator_d__2d<TSource, TCollection, TResult> d__d = new _Iterator_d__2d<TSource, TCollection, TResult>(-2);
        //  d__d.__3__source = source;
        //  d__d.__3__collectionSelector = collectionSelector;
        //  d__d.__3__resultSelector = resultSelector;
        //  return d__d;
        //}

        //public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        //{
        //  return first.SequenceEqual<TSource>(second, null);
        //}

        //public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  if (comparer == null)
        //  {
        //    comparer = EqualityComparer<TSource>.Default;
        //  }
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  using (IEnumerator<TSource> enumerator = first.GetEnumerator())
        //  {
        //    using (IEnumerator<TSource> enumerator2 = second.GetEnumerator())
        //    {
        //      while (enumerator.MoveNext())
        //      {
        //        if (!enumerator2.MoveNext() || !comparer.Equals(enumerator.Current, enumerator2.Current))
        //        {
        //          return false;
        //        }
        //      }
        //      if (enumerator2.MoveNext())
        //      {
        //        return false;
        //      }
        //    }
        //  }
        //  return true;
        //}

        //public static TSource Single<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  IList<TSource> list = source as IList<TSource>;
        //  if (list != null)
        //  {
        //    switch (list.Count)
        //    {
        //      case 0:
        //        throw Error.NoElements();

        //      case 1:
        //        return list[0];
        //    }
        //  }
        //  else
        //  {
        //    using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //    {
        //      if (!enumerator.MoveNext())
        //      {
        //        throw Error.NoElements();
        //      }
        //      TSource current = enumerator.Current;
        //      if (!enumerator.MoveNext())
        //      {
        //        return current;
        //      }
        //    }
        //  }
        //  throw Error.MoreThanOneElement();
        //}

        //public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (predicate == null)
        //  {
        //    throw Error.ArgumentNull("predicate");
        //  }
        //  TSource local = default(TSource);
        //  long num = 0L;
        //  foreach (TSource local2 in source)
        //  {
        //    if (predicate(local2))
        //    {
        //      local = local2;
        //      num += 1L;
        //    }
        //  }
        //  long num2 = num;
        //  if ((num2 <= 1L) && (num2 >= 0L))
        //  {
        //    switch (((int)num2))
        //    {
        //      case 0:
        //        throw Error.NoMatch();

        //      case 1:
        //        return local;
        //    }
        //  }
        //  throw Error.MoreThanOneMatch();
        //}

        //public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  IList<TSource> list = source as IList<TSource>;
        //  if (list != null)
        //  {
        //    switch (list.Count)
        //    {
        //      case 0:
        //        return default(TSource);

        //      case 1:
        //        return list[0];
        //    }
        //  }
        //  else
        //  {
        //    using (IEnumerator<TSource> enumerator = source.GetEnumerator())
        //    {
        //      if (!enumerator.MoveNext())
        //      {
        //        return default(TSource);
        //      }
        //      TSource current = enumerator.Current;
        //      if (!enumerator.MoveNext())
        //      {
        //        return current;
        //      }
        //    }
        //  }
        //  throw Error.MoreThanOneElement();
        //}

        //public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (predicate == null)
        //  {
        //    throw Error.ArgumentNull("predicate");
        //  }
        //  TSource local = default(TSource);
        //  long num = 0L;
        //  foreach (TSource local2 in source)
        //  {
        //    if (predicate(local2))
        //    {
        //      local = local2;
        //      num += 1L;
        //    }
        //  }
        //  long num2 = num;
        //  if ((num2 <= 1L) && (num2 >= 0L))
        //  {
        //    switch (((int)num2))
        //    {
        //      case 0:
        //        return default(TSource);

        //      case 1:
        //        return local;
        //    }
        //  }
        //  throw Error.MoreThanOneMatch();
        //}

        /// <summary>Bypasses a specified number of elements in a sequence and then returns the remaining elements.</summary>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements that occur after the specified index in the input sequence.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> is null.</exception>
        public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            var x = new SkipIterator<TSource>(source, count);
            return x;
        }


        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            var x = new TakeIterator<TSource>(source, count);
            return x;
        }


        public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            var arr = new JsArray();
            foreach (var obj in source)
            {
                arr.push(obj);
            }
            return arr.As<TSource[]>();
        }

        //public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //  return source.ToDictionary<TSource, TKey, TSource>(keySelector, IdentityFunction<TSource>.Instance, null);
        //}

        //public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        //{
        //  return source.ToDictionary<TSource, TKey, TSource>(keySelector, IdentityFunction<TSource>.Instance, comparer);
        //}

        //public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        //{
        //  return source.ToDictionary<TSource, TKey, TElement>(keySelector, elementSelector, null);
        //}

        //public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        //{
        //  if (source == null)
        //  {
        //    throw Error.ArgumentNull("source");
        //  }
        //  if (keySelector == null)
        //  {
        //    throw Error.ArgumentNull("keySelector");
        //  }
        //  if (elementSelector == null)
        //  {
        //    throw Error.ArgumentNull("elementSelector");
        //  }
        //  Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(comparer);
        //  foreach (TSource local in source)
        //  {
        //    dictionary.Add(keySelector(local), elementSelector(local));
        //  }
        //  return dictionary;
        //}

        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw Error.ArgumentNull("source");
            }
            return new List<TSource>(source);
        }

        //public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //  return (ILookup<TKey, TSource>)Lookup<TKey, TSource>.Create<TSource>(source, keySelector, IdentityFunction<TSource>.Instance, null);
        //}

        //public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
        //{
        //  return (ILookup<TKey, TSource>)Lookup<TKey, TSource>.Create<TSource>(source, keySelector, IdentityFunction<TSource>.Instance, comparer);
        //}

        //public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
        //{
        //  return (ILookup<TKey, TElement>)Lookup<TKey, TElement>.Create<TSource>(source, keySelector, elementSelector, null);
        //}

        //public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        //{
        //  return (ILookup<TKey, TElement>)Lookup<TKey, TElement>.Create<TSource>(source, keySelector, elementSelector, comparer);
        //}

        //public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        //{
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  return UnionIterator<TSource>(first, second, null);
        //}

        //public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  if (first == null)
        //  {
        //    throw Error.ArgumentNull("first");
        //  }
        //  if (second == null)
        //  {
        //    throw Error.ArgumentNull("second");
        //  }
        //  return UnionIterator<TSource>(first, second, comparer);
        //}

        //private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        //{
        //  _Iterator_d__87<TSource> d__ = new _Iterator_d__87<TSource>(-2);
        //  d__.__3__first = first;
        //  d__.__3__second = second;
        //  d__.__3__comparer = comparer;
        //  return d__;
        //}




        //private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        //{
        //  _Iterator_d__0<TSource> d__ = new _Iterator_d__0<TSource>(-2);
        //  d__.__3__source = source;
        //  d__.__3__predicate = predicate;
        //  return d__;
        //}

        //private static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        //{
        //  _Iterator_d__6<TSource> d__ = new _Iterator_d__6<TSource>(-2);
        //  d__.__3__source = source;
        //  d__.__3__predicate = predicate;
        //  return d__;
        //}





    }

    [JsType(Name = "System.Linq.Error", Filename = "~/res/System.Linq.js")]
    static class Error
    {
        internal static Exception ArgumentNull(string p)
        {
            return new Exception("ArgumentNull " + p);
        }

        internal static Exception NoElements()
        {
            return new Exception("NoElements");
        }

        internal static Exception NoMatch()
        {
            return new Exception("NoMatch");
        }
    }


}
