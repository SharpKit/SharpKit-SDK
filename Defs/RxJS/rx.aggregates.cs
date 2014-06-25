using SharpKit.JavaScript;

namespace SharpKit.Rx
{
	// ReSharper disable InconsistentNaming

	#region Classes

	#region Observable

	public static partial class Observable
	{
		#region aggregate

		/// <summary>
		/// Applies an accumulator function over an observable sequence. The specified seed value is used as the initial accumulator value.
		/// </summary>  
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TAccumulate">The type of accumulator.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="seed">The initial accumulator value.</param>
		/// <param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>An observable sequence containing a single element with the final accumulator value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TAccumulate> aggregate<TSource, TAccumulate>(this IObservable<TSource> source,
			TAccumulate seed, JsFunc<TAccumulate, TSource, TAccumulate> accumulator) { return null; }

		/// <summary>
		/// Applies an accumulator function over an observable sequence.
		/// </summary>  
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to aggregate.</param>
		/// <param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>An observable sequence containing a single element with the final accumulator value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> aggregate<TSource>(this IObservable<TSource> source,
			JsFunc<TSource, TSource, TSource> accumulator) { return null; }

		#endregion

		/// <summary>
		/// Determines whether any element of an observable sequence satisfies a condition.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to test.</param>
		/// <param name="predicate">A function to test each element for a condition. If not specified, the operator tests for the sequence being non-empty.</param>
		/// <returns>An observable sequence containing a single Boolean value determining whether any elements in the source sequence pass the test in the specified predicate, or (when no predicate is specified) whether the sequence is non-empty.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<bool> any<TSource>(this IObservable<TSource> source, JsFunc<TSource, bool> predicate = null) { return null; }

		/// <summary>
		/// Determines whether all element of an observable sequence satisfies a condition.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to test.</param>
		/// <param name="predicate">A function to test each element for a condition. If not specified, the operator tests for the sequence being non-empty.</param>
		/// <returns>An observable sequence containing a single Boolean value determining whether all elements in the source sequence pass the test in the specified predicate, or (when no predicate is specified) whether the sequence is non-empty.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<bool> all<TSource>(this IObservable<TSource> source, JsFunc<TSource, bool> predicate = null) { return null; }

		/// <summary>
		/// Determines whether an observable sequence contains a specified element.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to test.</param>
		/// <param name="value">The value to locate in the sequence.</param>
		/// <param name="comparer">An equality comparer to compare elements. If not specified, this defaults to object comparison using ===.</param>
		/// <returns>An observable sequence containing a single Boolean value determining whether the source sequence contains an element that has the specified value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<bool> contains<TSource>(this IObservable<TSource> source, TSource value, JsFunc<TSource, TSource, int> comparer = null) { return null; }

		/// <summary>
		/// Returns an observable sequence containing an integer value that represents the total number of elements in an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to count.</param>
		/// <returns>An observable sequence containing a single element with the number of elements in the input sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<int> count<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Determines whether an observable sequence is empty.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to test.</param>
		/// <returns>An observable sequence containing a single element determining whether the source sequence is empty.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<bool> isEmpty<TSource>(this IObservable<TSource> source) { return null; }

		#region sum

		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence to sum.</param>
		/// <returns>An observable sequence containing a single element with the sum of the values in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<JsNumber> sum(this IObservable<JsNumber> source) { return null; }

		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence to sum.</param>
		/// <returns>An observable sequence containing a single element with the sum of the values in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<int> sum(this IObservable<int> source) { return null; }

		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence to sum.</param>
		/// <returns>An observable sequence containing a single element with the sum of the values in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<long> sum(this IObservable<long> source) { return null; }

		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence to sum.</param>
		/// <returns>An observable sequence containing a single element with the sum of the values in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<decimal> sum(this IObservable<decimal> source) { return null; }

		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence to sum.</param>
		/// <returns>An observable sequence containing a single element with the sum of the values in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<float> sum(this IObservable<float> source) { return null; }

		/// <summary>
		/// Computes the sum of a sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence to sum.</param>
		/// <returns>An observable sequence containing a single element with the sum of the values in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<double> sum(this IObservable<double> source) { return null; }

		#endregion

		/// <summary>
		/// Returns the elements in an observable sequence with the minimum key value.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">Source sequence.</param>
		/// <param name="keySelector">Key selector function.</param>
		/// <param name="comparer">Comparer used to compare key values. If not specified, this defaults to comparison of two objects by subtraction using -.</param>
		/// <returns>An observable sequence containing a list of zero or more elements that have a minimum key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> minBy<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TKey, TKey, int> comparer = null) { return null; }

		/// <summary>
		/// Returns the elements in an observable sequence with the maximum key value.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">Source sequence.</param>
		/// <param name="keySelector">Key selector function.</param>
		/// <param name="comparer">Comparer used to compare key values. If not specified, this defaults to comparison of two objects by subtraction using -.</param>
		/// <returns>An observable sequence containing a list of zero or more elements that have a maximum key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> maxBy<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TKey, TKey, int> comparer = null) { return null; }
		
		/// <summary>
		/// Returns the minimum element in an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence.</param>
		/// <param name="comparer">Comparer used to compare elements. If not specified, this defaults to comparison of two objects by subtraction using -.</param>
		/// <returns>An observable sequence containing a single element with the minimum element in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> min<TSource>(this IObservable<TSource> source, JsFunc<TSource, TSource, int> comparer = null) { return null; }
		
		/// <summary>
		/// Returns the maximum element in an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence.</param>
		/// <param name="comparer">Comparer used to compare elements. If not specified, this defaults to comparison of two objects by subtraction using -.</param>
		/// <returns>An observable sequence containing a single element with the maximum element in the sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> max<TSource>(this IObservable<TSource> source, JsFunc<TSource, TSource, int> comparer = null) { return null; }

		#region average

		/// <summary>
		/// Computes the average of an observable sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence.</param>
		/// <returns>An observable sequence containing a single element with the average of the sequence of values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<double> average(this IObservable<int> source) { return null; }

		/// <summary>
		/// Computes the average of an observable sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence.</param>
		/// <returns>An observable sequence containing a single element with the average of the sequence of values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<JsNumber> average(this IObservable<JsNumber> source) { return null; }

		/// <summary>
		/// Computes the average of an observable sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence.</param>
		/// <returns>An observable sequence containing a single element with the average of the sequence of values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<double> average(this IObservable<long> source) { return null; }

		/// <summary>
		/// Computes the average of an observable sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence.</param>
		/// <returns>An observable sequence containing a single element with the average of the sequence of values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<decimal> average(this IObservable<decimal> source) { return null; }

		/// <summary>
		/// Computes the average of an observable sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence.</param>
		/// <returns>An observable sequence containing a single element with the average of the sequence of values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<float> average(this IObservable<float> source) { return null; }

		/// <summary>
		/// Computes the average of an observable sequence of numeric values.
		/// </summary>
		/// <param name="source">Source sequence.</param>
		/// <returns>An observable sequence containing a single element with the average of the sequence of values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<double> average(this IObservable<double> source) { return null; }

		#endregion

		/// <summary>
		/// Determines whether two sequences are equal by comparing the elements pairwise.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="first">First observable sequence to compare.</param>
		/// <param name="second">Second observable sequence to compare.</param>
		/// <param name="comparer">Comparer used to compare elements of both sequences. If not specified, this defaults to object comparison using ===.</param>
		/// <returns>An observable sequence that contains a single element which indicates whether both sequences are equal.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<bool> qequenceEqual<TSource>(this IObservable<TSource> first,
			IObservable<TSource> second, JsFunc<TSource, TSource, int> comparer = null) { return null; }
	}

	#endregion

	#endregion

	// ReSharper restore InconsistentNaming
}