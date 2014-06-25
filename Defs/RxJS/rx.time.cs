using SharpKit.JavaScript;

namespace SharpKit.Rx
{
	// ReSharper disable InconsistentNaming

	#region Classes

	#region Observable

	public static partial class Observable
	{
		/// <summary>
		/// Returns an observable sequence that produces a value after each period.
		/// </summary>
		/// <param name="period">Period for producing the values in the resulting sequence (specified as an integer denoting milliseconds).</param>
		/// <param name="scheduler">Scheduler to run the timer on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence that produces a value after each period.</returns>
		public static IObservable<long> interval(long period, IScheduler scheduler = null) { return null; }
		
		#region timer

		/// <summary>
		/// Returns an observable sequence that produces a value after dueTime has elapsed and then after each period.
		/// </summary>
		/// <param name="dueTime">Absolute (specified as a Date object) at which to produce the first value.</param>
		/// <param name="period">Period to produce subsequent values (specified as an integer denoting milliseconds). If not specified, the resulting timer is not recurring.</param>
		/// <param name="scheduler">Scheduler to run the timer on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence that produces a value after due time has elapsed and then each period.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<long> timer(JsDate dueTime, long period = -1, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that produces a value after dueTime has elapsed and then after each period.
		/// </summary>
		/// <param name="dueTime">Absolute (specified as a Date object) at which to produce the first value.</param>
		/// <param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>An observable sequence that produces a value after due time has elapsed and then each period.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<long> timer(JsDate dueTime, IScheduler scheduler) { return null; }
		/// <summary>
		/// Returns an observable sequence that produces a value after dueTime has elapsed and then after each period.
		/// </summary>
		/// <param name="dueTime">Relative time (specified as an integer denoting milliseconds) at which to produce the first value.</param>
		/// <param name="period">Period to produce subsequent values (specified as an integer denoting milliseconds). If not specified, the resulting timer is not recurring.</param>
		/// <param name="scheduler">Scheduler to run the timer on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence that produces a value after due time has elapsed and then each period.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<long> timer(long dueTime, long period = -1, IScheduler scheduler = null) { return null; }
		/// <summary>
		/// Returns an observable sequence that produces a value after dueTime has elapsed and then after each period.
		/// </summary>
		/// <param name="dueTime">Relative time (specified as an integer denoting milliseconds) at which to produce the first value.</param>
		/// <param name="scheduler">Scheduler to run the timer on.</param>
		/// <returns>An observable sequence that produces a value after due time has elapsed and then each period.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<long> timer(long dueTime, IScheduler scheduler) { return null; }

		#endregion

		#region delay

		/// <summary>
		/// Time shifts the observable sequence by dueTime. The relative time intervals between the values are preserved.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="dueTime">Absolute (specified as a Date object) time by which to shift the observable sequence.</param>
		/// <param name="scheduler">Scheduler to run the delay timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>Time-shifted sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> delay<TSource>(this IObservable<TSource> source, JsDate dueTime, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Time shifts the observable sequence by dueTime. The relative time intervals between the values are preserved.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="dueTime">Relative time (specified as an integer denoting milliseconds) by which to shift the observable sequence.</param>
		/// <param name="scheduler">Scheduler to run the delay timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>Time-shifted sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> delay<TSource>(this IObservable<TSource> source, long dueTime, IScheduler scheduler = null) { return null; }

		#endregion

		/// <summary>
		/// Ignores values from an observable sequence which are followed by another value before dueTime.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="dueTime">Duration of the throttle period for each value (specified as an integer denoting milliseconds).</param>
		/// <param name="scheduler">Scheduler to run the throttle timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>The throttled sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> throttle<TSource>(this IObservable<TSource> source, long dueTime, IScheduler scheduler = null) { return null; }

		#region windowWithTime

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows which are produced based on timing information.
		/// <para>res = xs.windowWithTime(1000, 500 /*, scheduler */); // segments of 1 second with time shift 0.5 seconds</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="timeSpan">Length of each window (specified as an integer denoting milliseconds).</param>
		/// <param name="timeShift">Interval between creation of consecutive windows (specified as an integer denoting milliseconds), or an optional scheduler parameter. If not specified, the time shift corresponds to the timeSpan parameter, resulting in non-overlapping adjacent windows.</param>
		/// <param name="scheduler">Scheduler to run windowing timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IObservable<TSource>> windowWithTime<TSource>(this IObservable<TSource> source, long timeSpan, long timeShift = -1, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows which are produced based on timing information.
		/// <para>res = xs.windowWithTime(1000, scheduler); // non-overlapping segments of 1 second</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="timeSpan">Length of each window (specified as an integer denoting milliseconds).</param>
		/// <param name="scheduler">[Optional] Scheduler to run windowing timers on.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IObservable<TSource>> windowWithTime<TSource>(this IObservable<TSource> source, long timeSpan, IScheduler scheduler) { return null; }

		#endregion

		/// <summary>
		/// Projects each element of an observable sequence into a window that is completed when either it's full or a given amount of time has elapsed.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="timeSpan">Maximum time length (specified as an integer denoting milliseconds) of a window.</param>
		/// <param name="count">Maximum element count of a window.</param>
		/// <param name="scheduler">Scheduler to run windowing timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IObservable<TSource>> windowWithTimeOrCount<TSource>(this IObservable<TSource> source, long timeSpan, int count, IScheduler scheduler = null) { return null; }

		#region bufferWithTime

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers which are produced based on timing information.
		/// <para>res = xs.bufferWithTime(1000, 500 /*, scheduler */); // segments of 1 second with time shift 0.5 seconds</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="timeSpan">Length of each buffer (specified as an integer denoting milliseconds).</param>
		/// <param name="timeShift">Interval between creation of consecutive buffers (specified as an integer denoting milliseconds). If not specified, the time shift corresponds to the timeSpan parameter, resulting in non-overlapping adjacent buffers.</param>
		/// <param name="scheduler">Scheduler to run buffer timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence of buffers.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> bufferWithTime<TSource>(this IObservable<TSource> source, long timeSpan, long timeShift, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers which are produced based on timing information.
		/// <para>res = xs.bufferWithTime(1000, scheduler); // non-overlapping segments of 1 second</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="timeSpan">Length of each buffer (specified as an integer denoting milliseconds).</param>
		/// <param name="scheduler">Scheduler to run buffer timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence of buffers.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> bufferWithTime<TSource>(this IObservable<TSource> source, long timeSpan, IScheduler scheduler) { return null; }

		#endregion

		/// <summary>
		/// Projects each element of an observable sequence into a buffer that is completed when either it's full or a given amount of time has elapsed.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="timeSpan">Maximum time length of a buffer.</param>
		/// <param name="count">Maximum element count of a buffer.</param>
		/// <param name="scheduler">Scheduler to run bufferin timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence of buffers.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> bufferWithTimeOrCount<TSource>(this IObservable<TSource> source, long timeSpan, int count, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Records the time interval between consecutive values in an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="scheduler">Scheduler used to compute time intervals. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence with time interval information on values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TimeInterval<TSource>> timeInterval<TSource>(this IObservable<TSource> source, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Records the timestamp for each value in an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="scheduler">Scheduler used to compute timestamps. If not specified, the timeout scheduler is used.</param>
		/// <returns>An observable sequence with timestamp information on values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<Timestamped<TSource>> timestamp<TSource>(this IObservable<TSource> source, IScheduler scheduler = null) { return null; }
		
		#region sample

		/// <summary>
		/// Samples the observable sequence at each interval.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="interval">Interval at which to sample (specified as an integer denoting milliseconds).</param>
		/// <param name="scheduler">Scheduler to run the sampling timer on. If not specified, the timeout scheduler is used.</param>
		/// <returns>Sampled observable sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> sample<TSource>(this IObservable<TSource> source, long interval, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Samples the observable sequence at each interval.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TSample">The type of sample.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="sampler">The sampling tick sequence.</param>
		/// <returns>Sampled observable sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> sample<TSource, TSample>(this IObservable<TSource> source, IObservable<TSample> sampler) { return null; }

		#endregion

		#region timeout

		/// <summary>
		/// Returns the source observable sequence or the other observable sequence if dueTime elapses.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="dueTime">Relative time (specified as an integer denoting milliseconds) when a timeout occurs.</param>
		/// <param name="other">Sequence to return in case of a timeout. If not specified, a timeout error throwing sequence will be used.</param>
		/// <param name="scheduler">Scheduler to run the timeout timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>The source sequence switching to the other sequence in case of a timeout.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> timeout<TSource>(this IObservable<TSource> source, long dueTime, IObservable<TSource> other = null, IScheduler scheduler = null) { return null; }
		
		/// <summary>
		/// Returns the source observable sequence or the other observable sequence if dueTime elapses.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="dueTime">Absolute (specified as a Date object) time when a timeout occurs.</param>
		/// <param name="other">Sequence to return in case of a timeout. If not specified, a timeout error throwing sequence will be used.</param>
		/// <param name="scheduler">Scheduler to run the timeout timers on. If not specified, the timeout scheduler is used.</param>
		/// <returns>The source sequence switching to the other sequence in case of a timeout.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> timeout<TSource>(this IObservable<TSource> source, JsDate dueTime, IObservable<TSource> other = null, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns the source observable sequence or the other observable sequence if dueTime elapses.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="dueTime">Relative time (specified as an integer denoting milliseconds) when a timeout occurs.</param>
		/// <param name="scheduler">Scheduler to run the timeout timers on.</param>
		/// <returns>The source sequence switching to the other sequence in case of a timeout.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> timeout<TSource>(this IObservable<TSource> source, long dueTime, IScheduler scheduler) { return null; }

		/// <summary>
		/// Returns the source observable sequence or the other observable sequence if dueTime elapses.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="dueTime">Absolute (specified as a Date object) time when a timeout occurs.</param>
		/// <param name="scheduler">Scheduler to run the timeout timers on.</param>
		/// <returns>The source sequence switching to the other sequence in case of a timeout.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> timeout<TSource>(this IObservable<TSource> source, JsDate dueTime, IScheduler scheduler) { return null; }

		#endregion

		/// <summary>
		/// Generates an observable sequence by iterating a state from an initial state until the condition fails.
		/// </summary>
		/// <typeparam name="TState">The type of state.</typeparam>
		/// <typeparam name="TResult">he type of result.</typeparam>
		/// <param name="initialState">Initial state.</param>
		/// <param name="condition">Condition to terminate generation (upon returning false).</param>
		/// <param name="iterate">Iteration step function.</param>
		/// <param name="resultSelector">Selector function for results produced in the sequence.</param>
		/// <param name="timeSelector">Time selector function to control the speed of values being produced each iteration, returning Date values.</param>
		/// <param name="scheduler">Scheduler on which to run the generator loop. If not specified, the timeout scheduler is used.</param>
		/// <returns>The generated sequence.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> generateWithAbsoluteTime<TState, TResult>(TState initialState, JsFunc<TState, bool> condition,
			JsFunc<TState, TState> iterate, JsFunc<TState, TResult> resultSelector, JsFunc<TState, JsDate> timeSelector, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Generates an observable sequence by iterating a state from an initial state until the condition fails.
		/// </summary>
		/// <typeparam name="TState">The type of state.</typeparam>
		/// <typeparam name="TResult">he type of result.</typeparam>
		/// <param name="initialState">Initial state.</param>
		/// <param name="condition">Condition to terminate generation (upon returning false).</param>
		/// <param name="iterate">Iteration step function.</param>
		/// <param name="resultSelector">Selector function for results produced in the sequence.</param>
		/// <param name="timeSelector">Time selector function to control the speed of values being produced each iteration, returning integer values denoting milliseconds.</param>
		/// <param name="scheduler">Scheduler on which to run the generator loop. If not specified, the timeout scheduler is used.</param>
		/// <returns>The generated sequence.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> generateWithRelativeTime<TState, TResult>(TState initialState, JsFunc<TState, bool> condition,
			JsFunc<TState, TState> iterate, JsFunc<TState, TResult> resultSelector, JsFunc<TState, long> timeSelector, IScheduler scheduler = null) { return null; }

		#region delaySubscription

		/// <summary>
		/// Time shifts the observable sequence by delaying the subscription.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="dueTime">Absolute time to perform the subscription at.</param>
		/// <param name="scheduler">Scheduler to run the subscription delay timer on. If not specified, the timeout scheduler is used.</param>
		/// <returns>Time-shifted sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> delaySubscription<TSource>(this IObservable<TSource> source, JsDate dueTime, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Time shifts the observable sequence by delaying the subscription.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="dueTime">Relative time to perform the subscription at.</param>
		/// <param name="scheduler">Scheduler to run the subscription delay timer on. If not specified, the timeout scheduler is used.</param>
		/// <returns>Time-shifted sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> delaySubscription<TSource>(this IObservable<TSource> source, long dueTime, IScheduler scheduler = null) { return null; }

		#region delayWithSelector

		/// <summary>
		/// Time shifts the observable sequence based on a subscription delay and a delay selector function for each element.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TDelay">The type of delay.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="subscriptionDelay">Sequence indicating the delay for the subscription to the source.</param>
		/// <param name="delayDurationSelector">Selector function to retrieve a sequence indicating the delay for each given element.</param>
		/// <returns>Time-shifted sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> delayWithSelector<TSource, TDelay>(this IObservable<TSource> source,
			IObservable<TDelay> subscriptionDelay, JsFunc<TSource, IObservable<TDelay>> delayDurationSelector) { return null; }

		/// <summary>
		/// Time shifts the observable sequence based on a subscription delay and a delay selector function for each element.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TDelay">The type of delay.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="delayDurationSelector">Selector function to retrieve a sequence indicating the delay for each given element.</param>
		/// <returns>Time-shifted sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined")]
		public static IObservable<TSource> delayWithSelector<TSource, TDelay>(this IObservable<TSource> source,
			JsFunc<TSource, IObservable<TDelay>> delayDurationSelector) { return null; }

		#endregion

		/// <summary>
		/// Ignores values from an observable sequence which are followed by another value within a computed throttle duration.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TThrottle">The type of throttle.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="throttleDurationSelector">Selector function to retrieve a sequence indicating the throttle duration for each given element.</param>
		/// <returns>The throttled sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> throttleWithSelector<TSource, TThrottle>(this IObservable<TSource> source,
			JsFunc<TSource, IObservable<TThrottle>> throttleDurationSelector) { return null; }

		#region timeoutWithSelector

		/// <summary>
		/// Returns the source observable sequence, switching to the other observable sequence if a timeout is signaled.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TTimeout">The type of timeout.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="firstTimeout">Observable sequence that represents the timeout for the first element.</param>
		/// <param name="timeoutDurationSelector">Selector to retrieve an observable sequence that represents the timeout between the current element and the next element.</param>
		/// <param name="other">Sequence to return in case of a timeout. If not provided, this is set to Observable.throwException(). </param>
		/// <returns>The source sequence switching to the other sequence in case of a timeout.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> timeoutWithSelector<TSource, TTimeout>(this IObservable<TSource> source,
			IObservable<TTimeout> firstTimeout, JsFunc<TSource, IObservable<TTimeout>> timeoutDurationSelector, IObservable<TSource> other = null) { return null; }

		/// <summary>
		/// Returns the source observable sequence, switching to the other observable sequence if a timeout is signaled.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TTimeout">The type of timeout.</typeparam>
		/// <param name="source">Source sequence to sample.</param>
		/// <param name="timeoutDurationSelector">Selector to retrieve an observable sequence that represents the timeout between the current element and the next element.</param>
		/// <param name="other">Sequence to return in case of a timeout. If not provided, this is set to Observable.throwException(). </param>
		/// <returns>The source sequence switching to the other sequence in case of a timeout.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined")]
		public static IObservable<TSource> timeoutWithSelector<TSource, TTimeout>(this IObservable<TSource> source,
			JsFunc<TSource, IObservable<TTimeout>> timeoutDurationSelector, IObservable<TSource> other = null) { return null; }

		#endregion

		#endregion
	}

	#endregion

	#region TimeInterval

	[JsType(JsMode.Json, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public class TimeInterval<T>
	{
		[JsProperty(NativeField = true)]
		T value { get { return default(T); } }

		[JsProperty(NativeField = true)]
		long interval { get { return default(long); } }
	}

	#endregion

	#region Timestamped

	[JsType(JsMode.Json, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public class Timestamped<T>
	{
		[JsProperty(NativeField = true)]
		T value { get { return default(T); } }

		[JsProperty(NativeField = true)]
		JsDate timestamp { get { return default(JsDate); } }
	}

	#endregion

	#endregion

	// ReSharper restore InconsistentNaming
}