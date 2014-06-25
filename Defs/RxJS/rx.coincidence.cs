using SharpKit.JavaScript;

namespace SharpKit.Rx
{
	// ReSharper disable InconsistentNaming

	#region Classes

	#region Observable

	public static partial class Observable
	{
		/// <summary>
		/// Correlates the elements of two sequences based on overlapping durations.
		/// </summary>
		/// <param name="left">The left observable sequence to join elements for.</param>
		/// <param name="right">The right observable sequence to join elements for.</param>
		/// <param name="leftDurationSelector">A function to select the duration (expressed as an observable sequence) of each element of the left observable sequence, used to determine overlap.</param>
		/// <param name="rightDurationSelector">A function to select the duration (expressed as an observable sequence) of each element of the right observable sequence, used to determine overlap.</param>
		/// <param name="resultSelector">A function invoked to compute a result element for any two overlapping elements of the left and right observable sequences. The parameters passed to the function correspond with the elements from the left and right source sequences for which overlap occurs.</param>
		/// <returns>An observable sequence that contains result elements computed from source elements that have an overlapping duration.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> join<TLeft, TRight, TLeftDuration, TRightDuration, TResult>(this IObservable<TLeft> left,
			IObservable<TRight> right, JsFunc<TLeft, IObservable<TLeftDuration>> leftDurationSelector,
			JsFunc<TRight, IObservable<TRightDuration>> rightDurationSelector, JsFunc<TLeft, TRight, TResult> resultSelector) { return null; }

		/// <summary>
		/// Correlates the elements of two sequences based on overlapping durations, and groups the results.
		/// </summary>
		/// <param name="left">The left observable sequence to join elements for.</param>
		/// <param name="right">The right observable sequence to join elements for.</param>
		/// <param name="leftDurationSelector">A function to select the duration (expressed as an observable sequence) of each element of the left observable sequence, used to determine overlap.</param>
		/// <param name="rightDurationSelector">A function to select the duration (expressed as an observable sequence) of each element of the right observable sequence, used to determine overlap.</param>
		/// <param name="resultSelector">A function invoked to compute a result element for any element of the left sequence with overlapping elements from the right observable sequence. The first parameter passed to the function is an element of the left sequence. The second parameter passed to the function is an observable sequence with elements from the right sequence that overlap with the left sequence's element.</param>
		/// <returns>An observable sequence that contains result elements computed from source elements that have an overlapping duration.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> groupJoin<TLeft, TRight, TLeftDuration, TRightDuration, TResult>(this IObservable<TLeft> left,
			IObservable<TRight> right, JsFunc<TLeft, IObservable<TLeftDuration>> leftDurationSelector,
			JsFunc<TRight, IObservable<TRightDuration>> rightDurationSelector,
			JsFunc<TLeft, IObservable<TRight>, TResult> resultSelector) { return null; }

		#region buffer

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers.
		/// </summary>
		/// <param name="source">Source sequence to produce buffers over.</param>
		/// <param name="bufferClosingSelector">A function invoked to define the closing of each produced window.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> buffer<TSource, TBufferClosing>(this IObservable<TSource> source,
			JsFunc<IObservable<TBufferClosing>> bufferClosingSelector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers.
		/// </summary>
		/// <param name="source">Source sequence to produce buffers over.</param>
		/// <param name="bufferOpenings">Observable sequence whose elements denote the creation of new windows.</param>
		/// <param name="bufferClosingSelector">A function invoked to define the closing of each produced window.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> buffer<TSource, TBufferOpening, TBufferClosing>(this IObservable<TSource> source,
			IObservable<TBufferOpening> bufferOpenings, JsFunc<TBufferOpening, IObservable<TBufferClosing>> bufferClosingSelector) { return null; }


		#endregion

		#region window

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows.
		/// </summary>
		/// <param name="source">Source sequence to produce windows over.</param>
		/// <param name="windowClosingSelector">A function invoked to define the closing of each produced window.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IObservable<TSource>> window<TSource, TBufferClosing>(this IObservable<TSource> source,
			JsFunc<IObservable<TBufferClosing>> windowClosingSelector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows.
		/// </summary>
		/// <param name="source">Source sequence to produce windows over.</param>
		/// <param name="windowOpenings">Observable sequence whose elements denote the creation of new windows.</param>
		/// <param name="windowClosingSelector">A function invoked to define the closing of each produced window.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IObservable<TSource>> window<TSource, TBufferOpening, TBufferClosing>(this IObservable<TSource> source,
			IObservable<TBufferOpening> windowOpenings, JsFunc<TBufferOpening, IObservable<TBufferClosing>> windowClosingSelector) { return null; }

		#endregion
	}

	#endregion

	#endregion

	// ReSharper restore InconsistentNaming
}
