using SharpKit.JavaScript;

namespace SharpKit.Rx
{
	// ReSharper disable InconsistentNaming

	#region Classes

	#region Observable

	public static partial class Observable
	{
		#region ifThen

		/// <summary>
		/// Determines whether an observable collection contains values.
		/// </summary>
		/// <param name="condition">The condition which determines if the thenSource or elseSource will be run.</param>
		/// <param name="thenSource">The observable sequence that will be run if the condition function returns true.</param>
		/// <param name="elseSource">The observable sequence that will be run if the condition function returns false.</param>     
		/// <returns>An observable sequence which is either the thenSource or elseSource.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> ifThen<TResult>(
			JsFunc<bool> condition,
			IObservable<TResult> thenSource,
			IObservable<TResult> elseSource) { return null; }

		/// <summary>
		/// Determines whether an observable collection contains values.
		/// </summary>
		/// <param name="condition">The condition which determines if the thenSource or elseSource will be run.</param>
		/// <param name="thenSource">The observable sequence that will be run if the condition function returns true.</param>
		/// <param name="scheduler">The scheduler used to create empty sequence that will be run if the condition function returns false.</param>
		/// <returns>An observable sequence which is either the thenSource or an empty sequence.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> ifThen<TResult>(
			JsFunc<bool> condition,
			IObservable<TResult> thenSource,
			IScheduler scheduler = null) { return null; }

		#endregion

		/// <summary>
		/// Repeats source as long as condition holds emulating a while loop.
		/// </summary>
		/// <param name="condition">The condition which determines if the source will be repeated.</param>
		/// <param name="source">The observable sequence that will be run if the condition function returns true.</param>
		/// <returns>An observable sequence which is repeated as long as the condition holds.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TSource> whileDo<TSource>(JsFunc<bool> condition, IObservable<TSource> source) { return null; }

		/// <summary>
		/// Repeats source as long as condition holds emulating a do while loop.
		/// </summary>
		/// <param name="source">The observable sequence that will be run if the condition function returns true.</param>
		/// <param name="condition">The condition which determines if the source will be repeated.</param>
		/// <returns>An observable sequence which is repeated as long as the condition holds.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> doWhile<TSource>(this IObservable<TSource> source, JsFunc<bool> condition) { return null; }
		
		#region switchCase

		/// <summary>
		/// Uses selector to determine which source in sources to use.
		/// </summary>
		/// <param name="selector">The function which extracts the value for to test in a case statement.</param>
		/// <param name="sources">A object which has keys which correspond to the case statement labels.</param>
		/// <param name="defaultSource">The observable sequence that will be run if the sources are not matched.</param>
		/// <returns>An observable sequence which is determined by a case statement.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> switchCase<TValue, TResult>(JsFunc<TValue> selector, JsObject<TValue, IObservable<TResult>> sources, IObservable<TResult> defaultSource) { return null; }

		/// <summary>
		/// Uses selector to determine which source in sources to use. An empty sequence will be provided in no matching case.
		/// </summary>
		/// <param name="selector">The function which extracts the value for to test in a case statement.</param>
		/// <param name="sources">A object which has keys which correspond to the case statement labels.</param>
		/// <param name="scheduler">The scheduler will be used for create an empty sequence as default case.</param>
		/// <returns>An observable sequence which is determined by a case statement.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> switchCase<TValue, TResult>(JsFunc<TValue> selector, JsObject<TValue, IObservable<TResult>> sources, IScheduler scheduler = null) { return null; }

		#endregion

		/// <summary>
		/// Concatenates the observable sequences obtained by running the specified result selector for each element in source.
		/// </summary>
		/// <param name="sources">An array of values to turn into an observable sequence.</param>
		/// <param name="resultSelector">A function to apply to each item in the sources array to turn it into an observable sequence.</param>
		/// <returns>An observable sequence from the concatenated observable sequences.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> forIn<TSource, TResult>(TSource[] sources, JsFunc<TSource, IObservable<TResult>> resultSelector) { return null; }

		/// <summary>
		/// Expands an observable sequence by recursively invoking selector.
		/// </summary>
		/// <param name="source">The source observable sequence.</param>
		/// <param name="selector">Selector function to invoke for each produced element, resulting in another sequence to which the selector will be invoked recursively again.</param>
		/// <param name="scheduler">Scheduler on which to perform the expansion. If not provided, this defaults to the current thread scheduler.</param>
		/// <returns>An observable sequence containing all the elements produced by the recursive expansion.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> expand<TSource>(this IObservable<TSource> source, JsFunc<TSource, IObservable<TSource>> selector, IScheduler scheduler = null) { return null; }
		
		#region forkJoin

		/// <summary>
		/// Runs all observable sequences in parallel and collect their last elements.
		/// </summary>
		/// <param name="sources">The array with the source observable sequences.</param>
		/// <returns>An observable sequence with an array collecting the last elements of all the input sequences.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource[]> forkJoin<TSource>(params IObservable<TSource>[] sources) { return null; }

		/// <summary>
		/// Runs two observable sequences in parallel and combines their last elemenets.
		/// </summary>
		/// <param name="first">First observable sequence.</param>
		/// <param name="second">Second observable sequence.</param>
		/// <param name="resultSelector">Result selector function to invoke with the last elements of both sequences.</param>
		/// <returns>An observable sequence with the result of calling the selector function with the last elements of both input sequences.</returns>
		[JsMethod(NativeOverloads = true, ExtensionImplementedInInstance = true)]
		public static IObservable<TResult> forkJoin<TFirst, TSecond, TResult>(this IObservable<TFirst> first, IObservable<TSecond> second,
			JsFunc<TFirst, TSecond, TResult> resultSelector) { return null; }

		#endregion

		/// <summary>
		/// Bind the source to the parameter without sharing subscription side-effects.
		/// </summary>
		/// <param name="source">The source observable sequence.</param>
		/// <param name="function">The function to produce other sequence using source sequence as parameter.</param>
		/// <returns>Produced sequence by the function.</returns>
		[JsMethod(NativeOverloads = true, ExtensionImplementedInInstance = true)]
		public static IObservable<TResult> letBind<TSource, TResult>(this IObservable<TSource> source,
			JsFunc<IObservable<TSource>, IObservable<TResult>> function) { return null; }
	}

	#endregion

	#endregion

	// ReSharper restore InconsistentNaming
}
