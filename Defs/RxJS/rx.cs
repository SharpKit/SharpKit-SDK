using SharpKit.JavaScript;

namespace SharpKit.Rx
{
	// ReSharper disable InconsistentNaming

	#region Interfaces

	#region IDisposable

	/// <summary>
	/// Defines a method to release allocated resources.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false)]
	public interface IDisposable
	{
		/// <summary>
		/// Disposes the disposable resource.
		/// </summary>
		void dispose();
	}

	#endregion

	#region IObserver

	/// <summary>
	/// Provides observer functionality, used as the callback mechanism for observable sequences.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true)]
	public interface IObserver<in T>
	{
		/// <summary>
		/// Notifies the observer by supplying a new sequence element.
		/// </summary>
		/// <param name="value">New sequence element.</param>
		void onNext(T value);

		/// <summary>
		/// Notifies the observer about an error that occurred in the sequence.
		/// </summary>
		/// <param name="exception">The error object.</param>
		void onError(JsError exception);

		/// <summary>
		/// Notifies the observer of the termination of the sequence.
		/// </summary>
		void onCompleted();
	}

	#endregion

	#region IObservable

	/// <summary>
	/// Represents a push-style collection.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true)]
	public interface IObservable<out T>
	{
		/// <summary>
		/// Subscribes to the observable sequence by specifying an observer.
		/// </summary>
		/// <param name="observer">Observer object to receive notifications on.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		IDisposable subscribe(IObserver<T> observer);
	}

	#endregion

	#region IScheduler

	/// <summary>
	/// Represents an object that schedules units of work.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public interface IScheduler
	{
		/*long now
		{
			[JsMethod(Name = "now")]
			get;
		}*/

		/// <summary>
		/// Schedules the specified action recursively, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(0, function (i, self) { alert('Hello ' + i + '!'); self(i + 1); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		IDisposable scheduleRecursiveWithState<TState>(TState state, JsAction<TState, JsAction<TState>> action);

		/// <summary>
		/// Schedules the specified action recursively using relative due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule(0, 1000 /* 1s */, function (i, self) { alert('Hello ' + i + '!'); self(i + 1, 1000 /* 1s */); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		IDisposable scheduleRecursiveWithRelativeAndState<TState>(TState state, long dueTime, JsAction<TState, JsAction<TState, long>> action);

		/// <summary>
		/// Schedules the specified action recursively using absolute due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule("Bart", new DateTime(2011, 2, 11), function (name, self) { alert('Hello ' + name + '!'); self(name, new Date(new Date().getFullYear() + 1, 2, 11)); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		IDisposable scheduleRecursiveWithAbsoluteAndState<TState>(TState state, JsDate dueTime, JsAction<TState, JsAction<TState, JsDate>> action);
	}

	#endregion

	#region IScheduledItem

	/// <summary>
	/// Represents a work item that has been scheduled.
	/// </summary>
	/// <typeparam name="TAbsolute">The absolute time argument type.</typeparam>
	[JsType(JsMode.Prototype, Export = true, IgnoreGenericTypeArguments = true)]
	public interface IScheduledItem<TAbsolute>
	{
		/// <summary>
		/// Get the absolute time at which the item executes.
		/// </summary>
		[JsProperty(NativeField = true)]
		TAbsolute dueTime { get; }

		/// <summary>
		/// Invokes the work item.
		/// </summary>
		void invoke();
	}

	#endregion

	#region IConnectableObservable

	/// <summary>
	/// Represents an observable that can be connected and disconnected.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true)]
	public interface IConnectableObservable<out T> : IObservable<T>
	{
		/// <summary>
		/// Connects the observable to its source.
		/// </summary>
		/// <returns>Disposable used to disconnect the observable sequence from its source.</returns>
		IDisposable connect();
	}

	#endregion

	#region IGroupedObservable

	/// <summary>
	/// Represents an observable sequence of values that have a common key.
	/// </summary>
	/// <typeparam name="TKey">The type of key.</typeparam>
	/// <typeparam name="TElement">The type of element.</typeparam>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true)]
	public interface IGroupedObservable<out TKey, out TElement> : IObservable<TElement>
	{
		/// <summary>
		/// Gets the common key.
		/// </summary>
		[JsProperty(NativeField = true)]
		TKey key
		{
			get;
		}
	}

	#endregion

	#region ISubject

	/// <summary>
	/// Represents an object that is both an observable sequence as well as an observer.
	/// </summary>
	/// <typeparam name="TSource">The type of source.</typeparam>
	/// <typeparam name="TResult">The type of result.</typeparam>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true)]
	public interface ISubject<in TSource, out TResult> : IObserver<TSource>, IObservable<TResult>
	{
	}

	/// <summary>
	/// Represents an object that is both an observable sequence as well as an observer.
	/// </summary>
	/// <typeparam name="T">The type of the subject.</typeparam>
	[JsType(JsMode.Prototype, Export = false, IgnoreGenericTypeArguments = true)]
	public interface ISubject<T> : ISubject<T, T>
	{
	}

	#endregion

	#endregion

	#region Classes

	#region Disposable

	/// <summary>
	/// Disposable object that runs the given function upon disposal.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "Rx.Disposable", Export = false)]
	public class Disposable : IDisposable
	{
		/// <summary>
		/// Creates a disposable object that invokes the specified function when disposed.
		/// </summary>
		/// <param name="action">Function to run during a call to dispose.</param>
		public Disposable(JsAction action) { }

		/// <summary>
		/// Disposes the disposable resource.
		/// </summary>
		public void dispose() { }
	}

	#endregion

	#region Unit

	/// <summary>
	/// Represents void.
	/// </summary>
	[JsType(JsMode.Json, Export = false)]
	public class Unit
	{
	}

	#endregion

	#region Observable

	/// <summary>
	/// Provides a set of static methods for query operations over observable sequences.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.Observable", OmitOptionalParameters = true, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public static partial class Observable
	{
		#region subscribe

		/// <summary>
		/// Subscribes to the observable sequence by specifying a set of callback functions.
		/// </summary>
		/// <param name="observable">Observable instance</param>
		/// <param name="onNext">Observer object to receive notifications on, or an onNext handler function.</param>
		/// <param name="onError">An onError handler function. This parameter shouldn't be supplied when the first parameter is an Observer. If not specified, the default behavior is to keep the error unhandled.</param>
		/// <param name="onCompleted">An onCompleted handler function.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IDisposable subscribe<T>(this IObservable<T> observable, JsAction<T> onNext, JsAction<JsError> onError = null, JsAction onCompleted = null) { return null; }

		/// <summary>
		/// Subscribes to the observable sequence by specifying a set of callback functions.
		/// </summary>
		/// <param name="observable">Observable instance</param>
		/// <param name="onNext">Observer object to receive notifications on, or an onNext handler function.</param>
		/// <param name="onCompleted">An onCompleted handler function.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg1 = "undefined")]
		public static IDisposable subscribe<T>(this IObservable<T> observable, JsAction<T> onNext, JsAction onCompleted) { return null; }

		#endregion

		/// <summary>
		/// Returns an observable sequence that stays connected to the source as long as there is at least one subscription to the observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <returns>An observable sequence that stays connected to the source as long as there is at least one subscription to the observable sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IObservable<TSource> refCount<TSource>(this IConnectableObservable<TSource> source) { return null; }

		#region start

		/// <summary>
		/// Invokes a function on the given instance and with the given arguments on the specified scheduler, producing the result through an observable sequence.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return type="Observable">Observable sequence that will produce the result of calling the function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true, InsertArg1 = "undefined", InsertArg2 = "undefined")]
		public static IObservable<Unit> start(JsAction action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Invokes a function on the given instance and with the given arguments on the specified scheduler, producing the result through an observable sequence.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="instance">Object instance to invoke the function on.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return type="Observable">Observable sequence that will produce the result of calling the function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true, InsertArg2 = "undefined")]
		public static IObservable<Unit> start(JsAction action, object instance, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Invokes a function on the given instance and with the given arguments on the specified scheduler, producing the result through an observable sequence.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="instance">Object instance to invoke the function on.</param>
		/// <param name="arguments">Arguments to pass to the function.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return type="Observable">Observable sequence that will produce the result of calling the function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<Unit> start(JsAction action, object instance, JsArray arguments, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Invokes a function on the given instance and with the given arguments on the specified scheduler, producing the result through an observable sequence.
		/// </summary>
		/// <param name="func">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return type="Observable">Observable sequence that will produce the result of calling the function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true, InsertArg1 = "undefined", InsertArg2 = "undefined")]
		public static IObservable<TResult> start<TResult>(JsFunc<TResult> func, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Invokes a function on the given instance and with the given arguments on the specified scheduler, producing the result through an observable sequence.
		/// </summary>
		/// <param name="func">Function to run asynchronously.</param>
		/// <param name="instance">Object instance to invoke the function on.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return type="Observable">Observable sequence that will produce the result of calling the function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true, InsertArg2 = "undefined")]
		public static IObservable<TResult> start<TResult>(JsFunc<TResult> func, object instance, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Invokes a function on the given instance and with the given arguments on the specified scheduler, producing the result through an observable sequence.
		/// </summary>
		/// <param name="func">Function to run asynchronously.</param>
		/// <param name="instance">Object instance to invoke the function on.</param>
		/// <param name="arguments">Arguments to pass to the function.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return type="Observable">Observable sequence that will produce the result of calling the function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> start<TResult>(JsFunc<TResult> func, object instance, JsArray arguments, IScheduler scheduler = null) { return null; }

		#endregion

		#region toAsync

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<IObservable<Unit>> toAsync(JsAction action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, IObservable<Unit>> toAsync<T1>(JsAction<T1> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, T2, IObservable<Unit>> toAsync<T1, T2>(JsAction<T1, T2> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, T2, T3, IObservable<Unit>> toAsync<T1, T2, T3>(JsAction<T1, T2, T3> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, T2, T3, T4, IObservable<Unit>> toAsync<T1, T2, T3, T4>(JsAction<T1, T2, T3, T4> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<IObservable<TResult>> toAsync<TResult>(JsFunc<TResult> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, IObservable<TResult>> toAsync<T1, TResult>(JsFunc<T1, TResult> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, T2, IObservable<TResult>> toAsync<T1, T2, TResult>(JsFunc<T1, T2, TResult> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, T2, T3, IObservable<TResult>> toAsync<T1, T2, T3, TResult>(JsFunc<T1, T2, T3, TResult> action, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts a function to an asynchronous function that returns an observable sequence with the function's result.
		/// </summary>
		/// <param name="action">Function to run asynchronously.</param>
		/// <param name="scheduler">Scheduler to run the function on. If not specified, the timeout scheduler is used.</param>
		/// <return>Function returning an observable sequence that will produce the result of calling the original function, or an error object if an error occurred.</return>
		[JsMethod(NativeOverloads = true)]
		public static JsFunc<T1, T2, T3, T4, IObservable<TResult>> toAsync<T1, T2, T3, T4, TResult>(JsFunc<T1, T2, T3, T4, TResult> action, IScheduler scheduler = null) { return null; }

		#endregion

		#region multicast

		/// <summary>
		/// Returns an observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function or specified subject.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be pushed into the specified subject.</param>
		/// <param name="subject">The subject to push source elements into or the factory function to create an intermediate subject through which the source sequence’s elements will be multicast to the selector function.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function or specified subject.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IConnectableObservable<TResult> multicast<TSource, TResult>(this IObservable<TSource> source, ISubject<TSource, TResult> subject) { return null; }

		/// <summary>
		/// Returns an observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function or specified subject.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TIntermediate">The type of intermediate.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence which will be multicast in the specified selector function.</param>
		/// <param name="subjectSelector">The factory function to create an intermediate subject through which the source sequence’s elements will be multicast to the selector function.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence subject to the policies enforced by the created subject.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> multicast<TSource, TIntermediate, TResult>(this IObservable<TSource> source, JsFunc<ISubject<TSource, TIntermediate>> subjectSelector, JsFunc<IObservable<TIntermediate>, IObservable<TResult>> selector) { return null; }

		#endregion

		#region publish

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence.
		/// &#10;
		/// &#10; xs_ = xs.publish(); res = xs_.zip(xs_, function (x, y) { return x + y; }); }); xs_.connect();
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <returns>A connectable observable sequence that shares a single subscription to the underlying sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IConnectableObservable<TSource> publish<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence.
		/// &#10;
		/// &#10; res = xs.publish(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); });
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> publish<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector) { return null; }

		#endregion

		#region publishValue

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence and starts with initialValue.
		/// &#10;
		/// &#10;res = xs.publishValue(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); }, 42);
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <param name="initialValue">The initial value received by observers upon subscription.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> publishValue<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector, TSource initialValue) { return null; }

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence and starts with initialValue.
		/// &#10;
		/// &#10;xs_ = xs.publishValue(42); res = xs_.zip(xs_, function (x, y) { return x + y; }); }); xs_.connect();
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <param name="initialValue">The initial value received by observers upon subscription.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined")]
		public static IConnectableObservable<TSource> publishValue<TSource>(this IObservable<TSource> source, TSource initialValue) { return null; }

		#endregion

		#region publishLast

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		/// &#10;
		/// &#10; xs_ = xs.publish(); res = xs_.zip(xs_, function (x, y) { return x + y; }); }); xs_.connect();
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <returns>A connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IConnectableObservable<TSource> publishLast<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		/// &#10;
		/// &#10; res = xs.publish(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); });
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasted through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> publishLast<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector) { return null; }

		#endregion

		#region replay

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		/// &#10;
		/// &#10; xs_ = xs.replay(); res = xs_.zip(xs_, function (x, y) { return x + y; }); }); xs_.connect();
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <returns>A connectable observable sequence that shares a single subscription to the underlying sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IConnectableObservable<TSource> replay<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="bufferSize">Maximum element count of the replay buffer.</param>
		/// <param name="window">Maximum time length of the replay buffer. If not specified, the window length is infinite.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		/// <returns>A connectable observable sequence that shares a single subscription to the underlying sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined")]
		public static IConnectableObservable<TSource> replay<TSource>(this IObservable<TSource> source, int bufferSize, long window = -1, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="window">Maximum time length of the replay buffer.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		/// <returns>A connectable observable sequence that shares a single subscription to the underlying sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined", InsertArg1 = "undefined")]
		public static IConnectableObservable<TSource> replay<TSource>(this IObservable<TSource> source, long window, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns a connectable observable sequence that shares a single subscription to the underlying sequence replaying all notifications.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>A connectable observable sequence that shares a single subscription to the underlying sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined", InsertArg1 = "undefined", InsertArg2 = "undefined")]
		public static IConnectableObservable<TSource> replay<TSource>(this IObservable<TSource> source, IScheduler scheduler) { return null; }

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		/// &#10;
		/// &#10; res = xs.replay(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); });
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <param name="bufferSize">Maximum element count of the replay buffer. If not specified, the buffer size is infinite.</param>
		/// <param name="window">Maximum time length of the replay buffer. If not specified, the window length is infinite.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> replay<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector, int bufferSize = -1, long window = -1, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		/// &#10;
		/// &#10; res = xs.replay(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); });
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <param name="bufferSize">Maximum element count of the replay buffer.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg2 = "undefined")]
		public static IObservable<TResult> replay<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector, int bufferSize, IScheduler scheduler) { return null; }

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		/// &#10;
		/// &#10; res = xs.replay(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); });
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <param name="window">Maximum time length of the replay buffer.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg1 = "undefined")]
		public static IObservable<TResult> replay<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector, long window, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that is the result of invoking the selector on a connectable observable sequence that shares a single subscription to the underlying sequence containing only the last notification.
		/// &#10;
		/// &#10; res = xs.replay(function (xs_) { return xs_.zip(xs_, function (x, y) { return x + y; }); });
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence whose elements will be multicasting through a single shared subscription.</param>
		/// <param name="selector">The selector function which can use the multicasted source sequence as many times as needed, without causing multiple subscriptions to the source sequence.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		/// <returns>An observable sequence that contains the elements of a sequence produced by multicasting the source sequence within a selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg1 = "undefined", InsertArg2 = "undefined")]
		public static IObservable<TResult> replay<TSource, TResult>(this IObservable<TSource> source, JsFunc<IObservable<TSource>, IObservable<TResult>> selector, IScheduler scheduler) { return null; }

		#endregion

		/// <summary>
		/// Returns a non-terminating observable sequence.
		/// </summary>
		/// <returns>A non-terminating observable sequence.</returns>
		public static IObservable<TResult> never<TResult>() { return null; }

		/// <summary>
		/// Returns an empty observable sequence with the specified scheduler.
		/// </summary>
		/// <param name="scheduler">The scheduler to send the termination call. If not specified, the immediate scheduler is used.</param>
		/// <returns>The observable sequence with no elements.</returns>
		public static IObservable<TResult> empty<TResult>(IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that contains a single value with a specified value and optional scheduler.
		/// </summary>
		/// <param name="value">The single element in the resulting observable sequence.</param>
		/// <param name="scheduler">The scheduler to send the single element on. If not specified, the immediate scheduler is used.</param>
		/// <returns>Observable sequence containing the single specified element.</returns>
		public static IObservable<TResult> returnValue<TResult>(TResult value, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that terminates with an exception.
		/// </summary>
		/// <param name="exception">Exception object used for the sequence's termination.</param>
		/// <param name="scheduler">The scheduler to send the exceptional termination call on. If not specified, the immediate scheduler is used.</param>
		/// <returns>The observable sequence that terminates exceptionally with the specified exception object.</returns>
		public static IObservable<TResult> throwException<TResult>(JsError exception, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Generates an observable sequence by iterating a state from an initial state until the condition fails.
		/// </summary>
		/// <param name="initialState">The initial state.</param>
		/// <param name="condition">The condition to terminate generation.</param>
		/// <param name="iterate">The iteration step function.</param>
		/// <param name="resultSelector">The selector function for results produced in the sequence.</param>
		/// <param name="scheduler">The scheduler on which to run the generator loop. If not specified, the current thread scheduler is used.</param>
		/// <returns>The generated sequence.</returns>
		public static IObservable<TResult> generate<TState, TResult>(TState initialState, JsFunc<TState, bool> condition,
			JsFunc<TState, TState> iterate, JsFunc<TState, TResult> resultSelector, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that invokes the observable factory whenever a new observer subscribes, allowing defered creation of the sequence. This is useful to allow an observer to easily obtain an updated or refreshed version of the sequence.
		/// </summary>
		/// <param name="observableFactory">The observable factory function to invoke for each observer that subscribes to the resulting sequence.</param>
		/// <returns>The observable sequence whose observers trigger an invocation of the given observable factory function.</returns>
		public static IObservable<TValue> defer<TValue>(JsFunc<IObservable<TValue>> observableFactory) { return null; }

		/// <summary>
		/// Constructs an observable sequence that depends on a resource object, whose lifetime is tied to the resulting observable sequence's lifetime.
		/// </summary>
		/// <param name="resourceFactory">Factory function to obtain a resource object.</param>
		/// <param name="observableFactory">Factory function to obtain an observable sequence that depends on the obtained resource.</param>
		/// <returns>Observable sequence whose lifetime controls the lifetime of the dependent resource object.</returns>
		public static IObservable<TSource> @using<TSource, TResource>(JsFunc<TResource> resourceFactory, JsFunc<TResource, IObservable<TSource>> observableFactory)
			where TResource : IDisposable { return null; }

		#region fromArray

		/// <summary>
		/// Converts an array to an observable sequence.
		/// </summary>
		/// <param name="source">Array to convert to an observable sequence.</param>
		/// <param name="scheduler">The scheduler on which to run the loop iterating over the array. If not specified, the current thread scheduler is used.</param>
		/// <returns>The observable sequence whose elements are pulled from the given array.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<T> fromArray<T>(JsArray<T> source, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts an array to an observable sequence.
		/// </summary>
		/// <param name="source">Array to convert to an observable sequence.</param>
		/// <param name="scheduler">The scheduler on which to run the loop iterating over the array. If not specified, the current thread scheduler is used.</param>
		/// <returns>The observable sequence whose elements are pulled from the given array.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<object> fromArray(JsArray source, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts an array to an observable sequence.
		/// </summary>
		/// <param name="source">Array to convert to an observable sequence.</param>
		/// <param name="scheduler">The scheduler on which to run the loop iterating over the array. If not specified, the current thread scheduler is used.</param>
		/// <returns>The observable sequence whose elements are pulled from the given array.</returns>
		[JsMethod(ExtensionImplementedInInstance = false, Name = "fromArray", NativeOverloads = true)]
		public static IObservable<T> toObservable<T>(this JsArray<T> source, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts an array to an observable sequence.
		/// </summary>
		/// <param name="source">Array to convert to an observable sequence.</param>
		/// <param name="scheduler">The scheduler on which to run the loop iterating over the array. If not specified, the current thread scheduler is used.</param>
		/// <returns>The observable sequence whose elements are pulled from the given array.</returns>
		[JsMethod(ExtensionImplementedInInstance = false, Name = "fromArray", NativeOverloads = true)]
		public static IObservable<T> toObservable<T>(this T[] source, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Converts an array to an observable sequence.
		/// </summary>
		/// <param name="source">Array to convert to an observable sequence.</param>
		/// <param name="scheduler">The scheduler on which to run the loop iterating over the array. If not specified, the current thread scheduler is used.</param>
		/// <returns>The observable sequence whose elements are pulled from the given array.</returns>
		[JsMethod(ExtensionImplementedInInstance = false, Name = "fromArray", NativeOverloads = true)]
		public static IObservable<object> toObservable(this JsArray source, IScheduler scheduler = null) { return null; }

		#endregion

		/// <summary>
		/// Creates an observable sequence from a specified subscribe method implementation.
		/// </summary>
		/// <param name="subscribe">The implementation of the resulting observable sequence's subscribe method, returning a Disposable object used to unsubscribe.</param>
		/// <returns>The observable sequence with the specified implementation for the subscribe method.</returns>
		public static IObservable<TSource> createWithDisposable<TSource>(JsFunc<IObserver<TSource>, IDisposable> subscribe) { return null; }

		/// <summary>
		/// Creates an observable sequence from a specified subscribe method implementation.
		/// </summary>
		/// <param name="subscribe">The implementation of the resulting observable sequence's subscribe method, returning a function used to unsubscribe.</param>
		/// <returns>The observable sequence with the specified implementation for the subscribe method.</returns>
		public static IObservable<TSource> create<TSource>(JsFunc<IObserver<TSource>, JsAction> subscribe) { return null; }

		/// <summary>
		/// Generates an observable sequence of integral numbers within a specified range.
		/// </summary>
		/// <param name="start">The value of the first integer in the sequence.</param>
		/// <param name="count">The number of sequential integers to generate.</param>
		/// <param name="scheduler">The scheduler to run the generator loop on. If not specified, the current thread scheduler is used.</param>
		/// <returns>An observable sequence that contains a range of sequential integral numbers.</returns>
		public static IObservable<int> range(int start, int count, IScheduler scheduler = null) { return null; }
		
		#region repeat

		/// <summary>
		/// Repeats the observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to repeat.</param>
		/// <param name="repeatCount">The number of times to repeat the sequence. If not specified, the sequence is repeated indefinitely.</param>
		/// <returns>The observable sequence producing the elements of the given sequence repeatedly.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> repeat<TSource>(this IObservable<TSource> source, int repeatCount = -1) { return null; }

		/// <summary>
		/// Generates an observable sequence that repeats the given element the specified number of times.
		/// </summary>
		/// <param name="value">The element to repeat.</param>
		/// <param name="repeatCount">The number of times to repeat the element. If not specified, the sequence is repeated indefinitely.</param>
		/// <param name="scheduler">The scheduler to run the producer loop on. If not specified, the current thread scheduler is used.</param>
		/// <returns>An observable sequence that repeats the given element the specified number of times.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObservable<TResult> repeat<TResult>(TResult value, int repeatCount = -1, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Generates an observable sequence that repeats the given element infinitely.
		/// </summary>
		/// <param name="value">The element to repeat.</param>
		/// <param name="scheduler">The scheduler to run the producer loop on.</param>
		/// <returns>An observable sequence that repeats the given element infinitely.</returns>
		[JsMethod(NativeOverloads = true, InsertArg1 = "undefined")]
		public static IObservable<TResult> repeat<TResult>(TResult value, IScheduler scheduler) { return null; }

		#endregion
		
		/// <summary>
		/// Repeats the source observable sequence until it successfully terminates.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to retry.</param>
		/// <param name="retryCount">Number of times to repeat the sequence. If not specified, the sequence is repeated indefinitely as long as errors occur.</param>
		/// <returns>The observable sequence producing the elements of the given sequence repeatedly as long as errors occur.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IObservable<TSource> retry<TSource>(this IObservable<TSource> source, int retryCount = -1) { return null; }

		#region select

		/// <summary>
		/// Projects each element of an observable sequence into a new form by incorporating specified source and selector.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="selector">A transform function to apply to each source element.</param>
		/// <returns>An observable sequence into a new form.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> select<TSource, TResult>(this IObservable<TSource> source, JsFunc<TSource, TResult> selector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into a new form by incorporating specified source and selector.
		/// </summary>
		/// <remarks>
		/// Alias of <see cref="select&lt;TSource, TResult&gt;(IObservable&lt;TSource&gt;, JsFunc&lt;TSource, TResult&gt;)"/> for use with query expressions.
		/// </remarks>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="selector">A transform function to apply to each source element.</param>
		/// <returns>An observable sequence into a new form.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "select")]
		public static IObservable<TResult> Select<TSource, TResult>(this IObservable<TSource> source, JsFunc<TSource, TResult> selector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into a new form by incorporating the element’s index with the specified source and selector.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
		/// <returns>An observable sequence into a new form.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> select<TSource, TResult>(this IObservable<TSource> source, JsFunc<TSource, int, TResult> selector) { return null; }

		#endregion

		#region where

		/// <summary>
		/// Filters the elements of an observable sequence based on a predicate.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="predicate">A function to test each source element for a condition.</param>
		/// <returns>An observable sequence that contains elements from the input sequence that satisfy the condition.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> where<TSource>(this IObservable<TSource> source, JsFunc<TSource, bool> predicate) { return null; }

		/// <summary>
		/// Filters the elements of an observable sequence based on a predicate.
		/// </summary>
		/// <remarks>
		/// Alias of <see cref="where&lt;TSource&gt;(IObservable&lt;TSource&gt;, JsFunc&lt;TSource, bool&gt;)"/> for use with query expressions.
		/// </remarks>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="predicate">A function to test each source element for a condition.</param>
		/// <returns>An observable sequence that contains elements from the input sequence that satisfy the condition.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "where")]
		public static IObservable<TSource> Where<TSource>(this IObservable<TSource> source, JsFunc<TSource, bool> predicate) { return null; }

		/// <summary>
		/// Filters the elements of an observable sequence based on a predicate.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="predicate">A function to test each source element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <returns>An observable sequence that contains elements from the input sequence that satisfy the condition.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> where<TSource>(this IObservable<TSource> source, JsFunc<TSource, int, bool> predicate) { return null; }

		#endregion

		#region groupByUntil

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer and selects the resulting elements by using a specified function. A duration selector function is used to control the lifetime of groups.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <typeparam name="TElement">The type of element.</typeparam>
		/// <typeparam name="TDuration">The type of duration.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <param name="elementSelector">A function to map each source element to an element in an observable group.</param>
		/// <param name="durationSelector">A function to signal the expiration of a group.</param>
		/// <param name="keySerializer">A function to serialize the key to a string for comparison purposes. If not specified, this defaults to the .toString() method implementation.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value. If not specified, this defaults to the .toString() method implementation.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IGroupedObservable<TKey, TElement>> groupByUntil<TSource, TKey, TElement, TDuration>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TSource, TElement> elementSelector,
			JsFunc<IGroupedObservable<TKey, TElement>, IObservable<TDuration>> durationSelector,
			JsFunc<TKey, object> keySerializer = null) { return null; }

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer. A duration selector function is used to control the lifetime of groups.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <typeparam name="TDuration">The type of duration.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <param name="durationSelector">A function to signal the expiration of a group.</param>
		/// <param name="keySerializer">A function to serialize the key to a string for comparison purposes. If not specified, this defaults to the .toString() method implementation.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value. If not specified, this defaults to the .toString() method implementation.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg1 = "undefined")]
		public static IObservable<IGroupedObservable<TKey, TSource>> groupByUntil<TSource, TKey, TDuration>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector,
			JsFunc<IGroupedObservable<TKey, TSource>, IObservable<TDuration>> durationSelector,
			JsFunc<TKey, object> keySerializer = null) { return null; }

		#endregion

		#region groupBy

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer and selects the resulting elements by using a specified function
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <typeparam name="TElement">The type of element.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <param name="elementSelector">A function to map each source element to an element in an observable group.</param>
		/// <param name="keySerializer">A function to serialize the key to a string for comparison purposes. If not specified, this defaults to the .toString() method implementation.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IGroupedObservable<TKey, TElement>> groupBy<TSource, TKey, TElement>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TSource, TElement> elementSelector,
			JsFunc<TKey, object> keySerializer = null) { return null; }

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <param name="keySerializer">A function to serialize the key to a string for comparison purposes.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg1 = "undefined")]
		public static IObservable<IGroupedObservable<TKey, TSource>> groupBy<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TKey, object> keySerializer) { return null; }

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IGroupedObservable<TKey, TSource>> groupBy<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector) { return null; }

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function and comparer and selects the resulting elements by using a specified function
		/// </summary>
		/// <remarks>
		/// Alias of <see cref="groupBy&lt;TSource, TKey, TElement&gt;(IObservable&lt;TSource&gt;, JsFunc&lt;TSource, TKey&gt;, JsFunc&lt;TSource, TElement&gt;, JsFunc&lt;TKey, object&gt;)"/> for using in query expressions.
		/// </remarks>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <typeparam name="TElement">The type of element.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <param name="elementSelector">A function to map each source element to an element in an observable group.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "groupBy")]
		public static IObservable<IGroupedObservable<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TSource, TElement> elementSelector) { return null; }

		/// <summary>
		/// Groups the elements of an observable sequence according to a specified key selector function.
		/// </summary>
		/// <remarks>
		/// Alias of <see cref="groupBy&lt;TSource, TKey&gt;(IObservable&lt;TSource&gt;, JsFunc&lt;TSource, TKey&gt;)"/> for using in query expressions.
		/// </remarks>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to extract the key for each element.</param>
		/// <returns>A sequence of observable groups, each of which corresponds to a unique key value, containing all elements that share that same key value.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "groupBy")]
		public static IObservable<IGroupedObservable<TKey, TSource>> GroupBy<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector) { return null; }

		#endregion

		/// <summary>
		/// Returns a specified number of contiguous values from the start of an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The sequence to take elements from.</param>
		/// <param name="count">The number of elements to return.</param>
		/// <param name="scheduler">Scheduler used to produce an onCompleted message in case the count parameter is set to 0.</param>
		/// <returns>An observable sequence that contains the specified number of elements from the start of the input sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IObservable<TSource> take<TSource>(this IObservable<TSource> source, int count, IScheduler scheduler = null) { return null; }

		/// <summary>
		/// Bypasses a specified number of values in an observable sequence and then returns the remaining values.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The sequence to skip elements from.</param>
		/// <param name="count">The number of elements to skip before returning the remaining elements.</param>
		/// <returns>An observable sequence that contains the elements that occur after the specified index in the input sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IObservable<TSource> skip<TSource>(this IObservable<TSource> source, int count) { return null; }
		
		#region takeWhile

		/// <summary>
		/// Returns values from an observable sequence as long as a specified condition is true, and then skips the remaining values.
		/// </summary>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <returns>An observable sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> takeWhile<TSource>(this IObservable<TSource> source, JsFunc<TSource, int, bool> predicate) { return null; }

		/// <summary>
		/// Returns values from an observable sequence as long as a specified condition is true, and then skips the remaining values.
		/// </summary>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <returns>An observable sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> takeWhile<TSource>(this IObservable<TSource> source, JsFunc<TSource, bool> predicate) { return null; }

		#endregion

		#region skipWhile

		/// <summary>
		/// Bypasses values in an observable sequence as long as a specified condition is true and then returns the remaining values.
		/// </summary>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <returns>An observable sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> skipWhile<TSource>(this IObservable<TSource> source, JsFunc<TSource, int, bool> predicate) { return null; }

		/// <summary>
		/// Bypasses values in an observable sequence as long as a specified condition is true and then returns the remaining values.
		/// </summary>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <returns>An observable sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> skipWhile<TSource>(this IObservable<TSource> source, JsFunc<TSource, bool> predicate) { return null; }

		#endregion

		#region selectMany

		/// <summary>
		/// Projects each element of an observable sequence to an observable sequence and flattens the resulting observable sequences into one observable sequence.
		/// <para>
		/// xs.selectMany(/* collection selector */ function (x) { return ys(x); }, /* result selector */ function (x, y) { return x + y; })
		/// </para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TCollection">The type of collection.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">An observable sequence of elements to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <param name="resultSelector">[Optional] A transform function to apply to each element of the intermediate sequence.</param>
		/// <returns>An observable sequence whose elements are the result of invoking the one-to-many transform function collectionSelector on each element of the input sequence and then mapping each of those sequence elements and their corresponding source element to a result element.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> selectMany<TSource, TCollection, TResult>(this IObservable<TSource> source,
			JsFunc<TSource, IObservable<TCollection>> selector,
			JsFunc<TSource, TCollection, TResult> resultSelector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence to an observable sequence and flattens the resulting observable sequences into one observable sequence.
		/// <para>
		/// xs.selectMany(/* collection selector */ function (x) { return ys(x); }, /* result selector */ function (x, y) { return x + y; })
		/// </para>
		/// </summary>
		/// <remarks>
		/// Alias of <see cref="selectMany&lt;TSource, TCollection, TResult&gt;(IObservable&lt;TSource&gt;, JsFunc&lt;TSource, IObservable&lt;TCollection&gt;&gt;, JsFunc&lt;TSource, TCollection, TResult&gt;)"/> for using in query expressions.
		/// </remarks>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TCollection">The type of collection.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">An observable sequence of elements to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <param name="resultSelector">[Optional] A transform function to apply to each element of the intermediate sequence.</param>
		/// <returns>An observable sequence whose elements are the result of invoking the one-to-many transform function collectionSelector on each element of the input sequence and then mapping each of those sequence elements and their corresponding source element to a result element.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "selectMany")]
		public static IObservable<TResult> SelectMany<TSource, TCollection, TResult>(this IObservable<TSource> source,
			JsFunc<TSource, IObservable<TCollection>> selector,
			JsFunc<TSource, TCollection, TResult> resultSelector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence to an observable sequence and flattens the resulting observable sequences into one observable sequence.
		/// <para>xs.SelectMany(/* collection selector */ function (x) { return ys(x); })</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="source">An observable sequence of elements to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <returns>An observable sequence whose elements are the result of invoking the one-to-many transform function collectionSelector on each element of the input sequence and then mapping each of those sequence elements and their corresponding source element to a result element.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> selectMany<TSource, TResult>(this IObservable<TSource> source,
			JsFunc<TSource, IObservable<TResult>> selector) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence to an observable sequence and flattens the resulting observable sequences into one observable sequence.
		/// <para>xs.SelectMany(/* inner sequence */ zs)</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TOther">The other type.</typeparam>
		/// <param name="source">An observable sequence of elements to project.</param>
		/// <param name="other">An observable sequence to project each element from the source sequence onto.</param>
		/// <returns>An observable sequence whose elements are the result of invoking the one-to-many transform function collectionSelector on each element of the input sequence and then mapping each of those sequence elements and their corresponding source element to a result element.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TOther> selectMany<TSource, TOther>(this IObservable<TSource> source, IObservable<TOther> other) { return null; }

		#endregion

		/// <summary>
		/// Creates an array from an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source observable sequence to get an array of elements for.</param>
		/// <returns>An observable sequence containing a single element with an array containing all the elements of the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> toArray<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Materializes the implicit notifications of an observable sequence as explicit notification values.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">An observable sequence to get notification values for.</param>
		/// <returns>An observable sequence containing the materialized notification values from the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<Notification<TSource>> materialize<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Dematerializes the explicit notification values of an observable sequence as implicit notifications.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">An observable sequence containing explicit notification values which have to be turned into implicit notifications.</param>
		/// <returns>An observable sequence exhibiting the behavior corresponding to the source sequence's notification values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> Dematerialize<TSource>(this IObservable<Notification<TSource>> source) { return null; }

		/// <summary>
		/// Hides the identity of an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">An observable sequence whose identity to hide.</param>
		/// <returns>An observable sequence that hides the identity of the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> asObservable<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into zero or more windows which are produced based on element count information.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to produce windows over.</param>
		/// <param name="count">Length of each window.</param>
		/// <param name="skip">Number of elements to skip between creation of consecutive windows. If not specified, the skip count corresponds to the count parameter value, resulting in non-overlapping adjacent windows.</param>
		/// <returns>An observable sequence of windows.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<IObservable<TSource>> windowWithCount<TSource>(this IObservable<TSource> source, int count, int skip = -1) { return null; }

		/// <summary>
		/// Projects each element of an observable sequence into zero or more buffers which are produced based on element count information.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to produce buffers over.</param>
		/// <param name="count">Length of each buffer.</param>
		/// <param name="skip">Number of elements to skip between creation of consecutive buffers. If not specified, the skip count corresponds to the count parameter value, resulting in non-overlapping adjacent buffers.</param>
		/// <returns>An observable sequence of buffers.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource[]> buffer<TSource>(this IObservable<TSource> source, int count, int skip = -1) { return null; }

		/// <summary>
		/// Prepends a sequence of values to an observable sequence.
		/// <para>E.g. res = xs.startWith(1, 2, 3);</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to prepend values to.</param>
		/// <param name="values">Values to prepend to the specified sequence.</param>
		/// <returns>The source sequence prepended with the specified values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> startWith<TSource>(this IObservable<TSource> source, params TSource[] values) { return null; }

		#region scan

		/// <summary>
		/// Applies an accumulator function over an observable sequence and returns each intermediate result with the specified source, optional seed and accumulator.
		/// <para>scanned = xs.scan(0, accumulator);</para>
		/// </summary>    
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TAccumulate">The type of accumulator.</typeparam>
		/// <param name="source">An observable sequence to accumulate over.</param>
		/// <param name="seed">The initial accumulator value.</param>
		/// <param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>An observable sequence containing the accumulated values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TAccumulate> scan<TSource, TAccumulate>(this IObservable<TSource> source, TAccumulate seed,
			JsFunc<TAccumulate, TSource, TAccumulate> accumulator) { return null; }

		/// <summary>
		/// Applies an accumulator function over an observable sequence and returns each intermediate result with the specified source, optional seed and accumulator.
		/// <para>scanned = xs.scan(accumulator);</para>
		/// </summary>    
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">An observable sequence to accumulate over.</param>
		/// <param name="accumulator">An accumulator function to be invoked on each element.</param>
		/// <returns>An observable sequence containing the accumulated values.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> scan<TSource>(this IObservable<TSource> source, JsFunc<TSource, TSource, TSource> accumulator) { return null; }
		
		#endregion

		#region distinctUntilChanged

		/// <summary>
		/// Returns an observable sequence that contains only distinct contiguous elements according to the keySelector and the comparer.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">An observable sequence to retain distinct contiguous elements for, based on a computed key value.</param>
		/// <param name="keySelector">A function to compute the comparison key for each element.</param>
		/// <param name="comparer">The equality comparer for computed key values. If not specified, this defaults to object comparison using ===.</param>
		/// <returns>An observable sequence only containing the distinct contiguous elements, based on a computed key value, from the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> distinctUntilChanged<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TKey, TKey, int> comparer = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that contains only distinct contiguous elements.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">An observable sequence to retain distinct contiguous elements for.</param>
		/// <param name="comparer">The equality comparer for computed key values. If not specified, this defaults to object comparison using ===.</param>
		/// <returns>An observable sequence only containing the distinct contiguous elements from the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> distinctUntilChanged<TSource>(this IObservable<TSource> source,
			JsFunc<TSource, TSource, int> comparer = null) { return null; }

		#endregion

		/// <summary>
		/// Invokes a specified action after source observable sequence terminates normally or by an exception.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="finallyAction">Action to invoke after the source observable sequence terminates.</param>
		/// <returns>Source sequence with the action-invoking termination behavior applied.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> finallyAction<TSource>(this IObservable<TSource> source, JsAction finallyAction) { return null; }

		#region doAction

		/// <summary>
		/// Invokes an action for each element in the observable sequence and invokes an action upon exceptional termination of the observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="observer">The observer whose methods to invoke as part of the source sequence's observation.</param>
		/// <returns>The source sequence with the side-effecting behavior applied.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> doAction<TSource>(this IObservable<TSource> source, IObserver<TSource> observer) { return null; }

		/// <summary>
		/// Invokes an action for each element in the observable sequence, and invokes an action upon graceful or exceptional termination of the observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="onNext">The observer whose methods to invoke as part of the source sequence's observation or the action to invoke for each element in the observable sequence.</param>
		/// <param name="onError">The action to invoke upon exceptional termination of the observable sequence.</param>
		/// <param name="onCompleted">The action to invoke upon graceful termination of the observable sequence.</param>
		/// <returns>The source sequence with the side-effecting behavior applied.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> doAction<TSource>(this IObservable<TSource> source,
			JsAction<TSource> onNext, JsAction<JsError> onError = null, JsAction onCompleted = null) { return null; }

		/// <summary>
		/// Invokes an action for each element in the observable sequence, and invokes an action upon graceful or exceptional termination of the observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="onNext">The observer whose methods to invoke as part of the source sequence's observation or the action to invoke for each element in the observable sequence.</param>
		/// <param name="onCompleted">The action to invoke upon graceful termination of the observable sequence.</param>
		/// <returns>The source sequence with the side-effecting behavior applied.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg1 = "undefined")]
		public static IObservable<TSource> doAction<TSource>(this IObservable<TSource> source,
			JsAction<TSource> onNext, JsAction onCompleted) { return null; }

		#endregion

		/// <summary>
		/// Bypasses a specified number of elements at the end of an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="count">Bypasses a specified number of elements at the end of an observable sequence.</param>
		/// <returns>An observable sequence containing the source sequence elements except for the bypassed ones at the end.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> skipLast<TSource>(this IObservable<TSource> source, int count) { return null; }

		/// <summary>
		/// Returns a specified number of contiguous elements from the end of an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="count">Number of elements to take from the end of the source sequence.</param>
		/// <returns>An observable sequence containing the specified number of elements from the of the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> takeLast<TSource>(this IObservable<TSource> source, int count) { return null; }

		/// <summary>
		/// Ignores all values in an observable sequence leaving only the termination messages.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <returns>An empty observable sequence that signals termination, successful or exceptional of the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> ignoreElements<TSource>(this IObservable<TSource> source) { return null; }

		/// <summary>
		/// Returns the element at a specified index in a sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <returns>An observable sequence that produces the element at the specified position in the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> elementAt<TSource>(this IObservable<TSource> source, int index) { return null; }

		/// <summary>Returns the element at a specified index in a sequence or a default value if the index is out of range.</summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="index">The zero-based index of the element to retrieve.</param>
		/// <param name="defaultValue">The default value if the index is out of range. If not specified, the default value used is null.</param>
		/// <returns>An observable sequence that produces the element at the specified position in the source sequence or a default value if the index is outside the bounds of the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> elementAtOrDefault<TSource>(this IObservable<TSource> source, int index, TSource defaultValue = default(TSource)) { return null; }

		/// <summary>
		/// Returns the elements of the specified sequence or the type parameter's default value in a singleton sequence if the sequence is empty.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="defaultValue">The value to return if the sequence is empty. If not specified, the default value used is null.</param>
		/// <returns>An observable sequence that contains the specified default value if the source is empty; otherwise, the elements of the source itself.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> defaultIfEmpty<TSource>(this IObservable<TSource> source, TSource defaultValue = default(TSource)) { return null; }
		
		#region distinct

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements according to the keySelector.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TKey">The type of key.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySelector">A function to compute the comparison key for each element. If not specified, this defaults to the identity function.</param>
		/// <param name="keySerializer">A function to compute the key used for comparison. If not specified, this defaults to the .toString() method implementation.</param>
		/// <returns>An observable sequence only containing the distinct elements, based on a computed key value, from the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> distinct<TSource, TKey>(this IObservable<TSource> source,
			JsFunc<TSource, TKey> keySelector, JsFunc<TKey, object> keySerializer = null) { return null; }

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements according to the comparer.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="keySerializer">A function to compute the key used for comparison.</param>
		/// <returns>An observable sequence only containing the distinct elements from the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, InsertArg0 = "undefined")]
		public static IObservable<TSource> distinct<TSource>(this IObservable<TSource> source, JsFunc<TSource, object> keySerializer) { return null; }

		/// <summary>
		/// Returns an observable sequence that contains only distinct elements with a specified source.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <returns>An observable sequence only containing the distinct elements from the source sequence.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> distinct<TSource>(this IObservable<TSource> source) { return null; }
		
		#endregion

		/// <summary>
		/// Merges an observable sequence of observable sequences into an observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">The observable sequence of inner observable sequences.</param>
		/// <returns>The observable sequence that merges the elements of the inner sequences.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> mergeObservable<TSource>(this IObservable<IObservable<TSource>> sources) { return null; }
		
		#region merge

		/// <summary>
		/// Merges an observable sequence of observable sequences into an observable sequence, limiting the number of concurrent subscriptions to inner sequences.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">The observable sequence of inner observable sequences.</param>
		/// <param name="maxConcurrent">Maximum number of inner observable sequences being subscribed to concurrently.</param>
		/// <returns>The observable sequence that merges the elements of the inner sequences.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> merge<TSource>(this IObservable<IObservable<TSource>> sources, int maxConcurrent) { return null; }

		/// <summary>
		/// Merges two observable sequences into a single observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="other">Second observable sequence.</param>    
		/// <returns>The observable sequence that merges the elements of the inner sequences.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> merge<TSource>(this IObservable<TSource> source, IObservable<TSource> other) { return null; }

		/// <summary>
		/// Merges all the observable sequences into a single observable sequence.
		/// </summary>
		/// <param name="sources">Observable sequences to merge.</param>
		/// <returns>The observable sequence that merges the elements of the observable sequences.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> merge<TSource>(params IObservable<TSource>[] sources) { return null; }

		/// <summary>
		/// Merges all the observable sequences into a single observable sequence.
		/// </summary>
		/// <param name="scheduler">Scheduler to run the enumeration of the sequence of sources on.</param>
		/// <param name="sources">Observable sequences to merge.</param>
		/// <returns>The observable sequence that merges the elements of the observable sequences.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> merge<TSource>(IScheduler scheduler, params IObservable<TSource>[] sources) { return null; }

		#endregion

		/// <summary>
		/// Transforms an observable sequence of observable sequences into an observable sequence producing values only from the most recent observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">The observable sequence of inner observable sequences.</param>
		/// <returns>The observable sequence that at any point in time produces the elements of the most recent inner observable sequence that has been received.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> switchLatest<TSource>(this IObservable<IObservable<TSource>> sources) { return null; }

		#region concat

		/// <summary>
		/// Concatenates all the observable sequences.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">Observable sequences to concatenate.</param>
		/// <returns>An observable sequence that contains the elements of each given sequence, in sequential order.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> concat<TSource>(params IObservable<TSource>[] sources) { return null; }

		/// <summary>
		/// Concatenates all the observable sequences.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="sources">Observable sequences to concatenate.</param>
		/// <returns>An observable sequence that contains the elements of each given sequence, in sequential order.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> concat<TSource>(this IObservable<TSource> source, params IObservable<TSource>[] sources) { return null; }

		#endregion

		/// <summary>
		/// Concatenates an observable sequence of observable sequences.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">An observable sequence that contains the elements of each observed inner sequence, in sequential order.</param>
		/// <returns>An observable sequence that contains the elements of each observed inner sequence, in sequential order.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> concatObservable<TSource>(this IObservable<IObservable<TSource>> sources) { return null; }

		#region catchException

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception with the next observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="first">First observable sequence whose exception (if any) is caught.</param>
		/// <param name="second">A second observable sequence used to produce results when an error occurred in the first sequence.</param>
		/// <returns>An observable sequence containing the first sequence's elements, followed by the elements of the second sequence in case an exception occurred.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> catchException<TSource>(this IObservable<TSource> first, IObservable<TSource> second) { return null; }

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception with the next observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <typeparam name="TException">The type of the exception.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="handler">Exception handler function that returns an observable sequence given the error that occurred in the first sequence.</param>
		/// <returns>An observable sequence containing the first sequence's elements, followed by the elements of the handler sequence in case an exception occurred.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> catchException<TSource, TException>(this IObservable<TSource> source, JsFunc<TException, IObservable<TSource>> handler)
			where TException : JsError { return null; }

		/// <summary>
		/// Continues an observable sequence that is terminated by an exception with the next observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">Observable sequences to catch exceptions for.</param>
		/// <returns>An observable sequence containing elements from consecutive source sequences until a source sequence terminates successfully.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> catchException<TSource>(params IObservable<TSource>[] sources) { return null; }

		#endregion

		#region onErrorResumeNext

		/// <summary>
		/// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="first">The first observable sequence whose exception (if any) is caught.</param>
		/// <param name="second">Second observable sequence used to produce results after the first sequence terminates.</param>
		/// <returns>An observable sequence that concatenates the first and second sequence, even if the first sequence terminates exceptionally.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> onErrorResumeNext<TSource>(this IObservable<TSource> first, IObservable<TSource> second) { return null; }

		/// <summary>
		/// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
		/// </summary>
		/// <param name="sources">Observable sequences to concatenate.</param>
		/// <returns>An observable sequence that concatenates the source sequences, even if a sequence terminates exceptionally.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> onErrorResumeNext<TSource>(params IObservable<TSource>[] sources) { return null; }

		#endregion

		#region zip

		/// <summary>
		/// Merges two observable sequences into one observable sequence by combining their elements in a pairwise fashion.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive pair of elements from the first and second source.</param>
		/// <returns>An observable sequence containing the result of pairwise combining the elements of the first and second source using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> zip<TFirst, TSecond, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, JsFunc<TFirst, TSecond, TResult> resultSelector) { return null; }

		/// <summary>
		/// Merges three observable sequences into one observable sequence by combining their elements in a pairwise fashion.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TThird">The third type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="third">The fird observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive set of elements from the sources.</param>
		/// <returns>An observable sequence containing the result of combining the elements of the sources using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> zip<TFirst, TSecond, TThird, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, IObservable<TThird> third, JsFunc<TFirst, TSecond, TThird, TResult> resultSelector) { return null; }

		/// <summary>
		/// Merges four observable sequences into one observable sequence by combining their elements in a pairwise fashion.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TThird">The third type.</typeparam>
		/// <typeparam name="TFourth">The fourth type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="third">The fird observable source.</param>
		/// <param name="forth">The fourth observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive set of elements from the sources.</param>
		/// <returns>An observable sequence containing the result of combining the elements of the sources using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> zip<TFirst, TSecond, TThird, TFourth, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, IObservable<TThird> third, IObservable<TFourth> forth,
			JsFunc<TFirst, TSecond, TThird, TFourth, TResult> resultSelector) { return null; }

		/// <summary>
		/// Merges four observable sequences into one observable sequence by combining their elements in a pairwise fashion.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TThird">The third type.</typeparam>
		/// <typeparam name="TFourth">The fourth type.</typeparam>
		/// <typeparam name="TFifth">The fifth type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="third">The fird observable source.</param>
		/// <param name="forth">The fourth observable source.</param>
		/// <param name="fifth">The fifth observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive set of elements from the sources.</param>
		/// <returns>An observable sequence containing the result of combining the elements of the sources using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> zip<TFirst, TSecond, TThird, TFourth, TFifth, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, IObservable<TThird> third, IObservable<TFourth> forth, IObservable<TFifth> fifth,
			JsFunc<TFirst, TSecond, TThird, TFourth, TFifth, TResult> resultSelector) { return null; }

		#endregion

		#region combineLatest

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive pair of elements from the first and second source.</param>
		/// <returns>An observable sequence containing the result of pairwise combining the elements of the first and second source using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> combineLatest<TFirst, TSecond, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, JsFunc<TFirst, TSecond, TResult> resultSelector) { return null; }

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TThird">The third type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="third">The fird observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive set of elements from the sources.</param>
		/// <returns>An observable sequence containing the result of combining the elements of the sources using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> combineLatest<TFirst, TSecond, TThird, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, IObservable<TThird> third, JsFunc<TFirst, TSecond, TThird, TResult> resultSelector) { return null; }

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TThird">The third type.</typeparam>
		/// <typeparam name="TFourth">The fourth type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="third">The fird observable source.</param>
		/// <param name="forth">The fourth observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive set of elements from the sources.</param>
		/// <returns>An observable sequence containing the result of combining the elements of the sources using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> combineLatest<TFirst, TSecond, TThird, TFourth, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, IObservable<TThird> third, IObservable<TFourth> forth,
			JsFunc<TFirst, TSecond, TThird, TFourth, TResult> resultSelector) { return null; }

		/// <summary>
		/// Merges the specified observable sequences into one observable sequence by using the selector function whenever any of the observable sequences produces an element.
		/// </summary>
		/// <typeparam name="TFirst">The first type.</typeparam>
		/// <typeparam name="TSecond">The second type.</typeparam>
		/// <typeparam name="TThird">The third type.</typeparam>
		/// <typeparam name="TFourth">The fourth type.</typeparam>
		/// <typeparam name="TFifth">The fifth type.</typeparam>
		/// <typeparam name="TResult">The type of result.</typeparam>
		/// <param name="first">The first observable source.</param>
		/// <param name="second">The second observable source.</param>
		/// <param name="third">The fird observable source.</param>
		/// <param name="forth">The fourth observable source.</param>
		/// <param name="fifth">The fifth observable source.</param>
		/// <param name="resultSelector">The function to invoke for each consecutive set of elements from the sources.</param>
		/// <returns>An observable sequence containing the result of combining the elements of the sources using the specified result selector function.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TResult> combineLatest<TFirst, TSecond, TThird, TFourth, TFifth, TResult>(this IObservable<TFirst> first,
			IObservable<TSecond> second, IObservable<TThird> third, IObservable<TFourth> forth, IObservable<TFifth> fifth,
			JsFunc<TFirst, TSecond, TThird, TFourth, TFifth, TResult> resultSelector) { return null; }

		#endregion

		/// <summary>
		/// Returns the values from the source observable sequence until the other observable sequence produces a value.
		/// </summary>
		/// <typeparam name="TOther">The other type.</typeparam>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to propagate elements for.</param>
		/// <param name="other">Observable sequence that terminates propagation of elements of the source sequence.</param>
		/// <returns>An observable sequence containing the elements of the source sequence up to the point the other sequence interrupted further propagation.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> takeUntil<TSource, TOther>(this IObservable<TSource> source, IObservable<TOther> other) { return null; }


		/// <summary>
		/// Returns the values from the source observable sequence only after the other observable sequence produces a value.
		/// </summary>
		/// <typeparam name="TOther">The other type.</typeparam>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence to propagate elements for.</param>
		/// <param name="other">Observable sequence that terminates propagation of elements of the source sequence.</param>
		/// <returns>An observable sequence containing the elements of the source sequence starting from the point the other sequence triggered propagation.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> skipUntil<TSource, TOther>(this IObservable<TSource> source, IObservable<TOther> other) { return null; }

		#region amb

		/// <summary>
		/// Propagates the observable sequence that reacts first.
		/// <para>E.g. winner = Rx.Observable.amb(xs, ys, zs);</para>
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="sources">Observable sources competing to react first.</param>
		/// <returns>An observable sequence that surfaces any of the given sequences, whichever reacted first.</returns>
		[JsMethod(NativeOverloads = true, NativeParams = true)]
		public static IObservable<TSource> amb<TSource>(params IObservable<TSource>[] sources) { return null; }

		/// <summary>
		/// Propagates the observable sequence that reacts first.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="first">The first observable sequence.</param>
		/// <param name="second">Second observable sequence.</param>
		/// <returns>An observable sequence that surfaces either of the given sequences, whichever reacted first.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> amb<TSource>(this IObservable<TSource> first, IObservable<TSource> second) { return null; }

		#endregion

		/// <summary>
		/// Asynchronously notify observers on the specified scheduler.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="scheduler">Scheduler to notify observers on.</param>
		/// <returns>The source sequence whose observations happen on the specified scheduler.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> observerOn<TSource>(this IObservable<TSource> source, IScheduler scheduler) { return null; }

		/// <summary>
		/// Asynchronously subscribes and unsubscribes observers on the specified scheduler.
		/// </summary>
		/// <typeparam name="TSource">The type of source.</typeparam>
		/// <param name="source">The source sequence.</param>
		/// <param name="scheduler">Scheduler to perform subscription and unsubscription actions on.</param>
		/// <returns>The source sequence whose subscriptions and unsubscriptions happen on the specified scheduler.</returns>
		[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
		public static IObservable<TSource> subscribeOn<TSource>(this IObservable<TSource> source, IScheduler scheduler) { return null; }
	}

	#endregion

	#region Notification

	/// <summary>
	/// Provides a set of static methods for constructing notifications.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.Notification")]
	public static class Notification
	{
		/// <summary>
		/// Creates an object that represents an OnNext notification to an observer.
		/// </summary>
		/// <typeparam name="T">Type of value.</typeparam>
		/// <param name="value">The value contained in the notification.</param>
		/// <returns>The OnNext notification containing the value.</returns>
		public static Notification<T> createOnNext<T>(T value) { return null; }

		/// <summary>
		/// Creates an object that represents an OnError notification to an observer.
		/// </summary>
		/// <typeparam name="T">Type of value.</typeparam>
		/// <param name="error">The exception contained in the notification.</param>
		/// <returns>The OnError notification containing the exception.</returns>
		public static Notification<T> createOnError<T>(JsError error) { return null; }

		/// <summary>
		/// Creates an object that represents an OnCompleted notification to an observer.
		/// </summary>
		/// <typeparam name="T">Type of value.</typeparam>
		/// <returns>The OnCompleted notification.</returns>
		public static Notification<T> createOnCompleted<T>() { return null; }
	}

	/// <summary>
	/// Indicates the type of a notification.
	/// </summary>
	[JsEnum(ValuesAsNames = true)]
	public enum NotificationKind
	{
		/// <summary>
		/// Represents an OnNext notification.
		/// </summary>
		[JsField(Name = "N")]
		OnNext,

		/// <summary>
		/// Represents an OnError notification.
		/// </summary>
		[JsField(Name = "E")]
		OnError,

		/// <summary>
		/// Represents an OnCompleted notification.
		/// </summary>
		[JsField(Name = "C")]
		OnCompleted
	}

	/// <summary>
	/// Represents a notification to an observer.
	/// </summary>
#pragma warning disable 659	// Equals override approved
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.Notification", OmitOptionalParameters = true)]
	public abstract class Notification<T>
	{
		/// <summary>
		/// Invokes the observer's method corresponding to the notification.
		/// </summary>
		/// <param name="observer">The observer whose methods to invoke based on the notification kind.</param>
		public abstract void accept(IObserver<T> observer);

		/// <summary>
		/// Invokes the function corresponding to the notification.
		/// </summary>
		/// <param name="onNext">The function to invoke for an OnNext notification.</param>
		/// <param name="onError">The function to invoke for an OnError notification.</param>
		/// <param name="onCompleted">The function to invoke for an OnCompleted notification.</param>
		public abstract void accept(JsAction<T> onNext, JsAction<JsError> onError, JsAction onCompleted);

		/// <summary>
		/// Invokes the function corresponding to the notification and returns the produced result.
		/// </summary>
		/// <param name="onNext">The function to invoke for an OnNext notification.</param>
		/// <param name="onError">The function to invoke for an OnError notification.</param>
		/// <param name="onCompleted">The function to invoke for an OnCompleted notification.</param>
		/// <returns>The result of calling the function or observer for the corresponding notification kind.</returns>
		public abstract TResult accept<TResult>(JsFunc<T, TResult> onNext, JsFunc<JsError, TResult> onError, JsFunc<TResult> onCompleted);

		/// <summary>
		/// Indicates whether this instance and a specified object are equal.
		/// </summary>
		/// <returns>true if both objects are the same; false otherwise.</returns>
		public abstract bool equals(Notification<T> other);

		/// <summary>
		/// Indicates whether this instance and a specified object are equal.
		/// </summary>
		/// <returns>true if both objects are the same; false otherwise.</returns>
		[JsMethod(Name = "equals")]
		public override bool Equals(object obj) { return default(bool); }

		/// <summary>
		/// Returns an observable sequence that exposes the notification's behavior.
		/// </summary>
		/// <param name="scheduler">Scheduler to send the notification on. If not specified, the immediate scheduler is used.</param>
		/// <returns>Observable sequence exposing the notification's behavior.</returns>
		public abstract IObservable<T> toObservable(IScheduler scheduler = null);

		/// <summary>
		/// Gets the kind of notification that is represented.
		/// </summary>
		[JsProperty(NativeField = true)]
		public abstract NotificationKind kind { get; }

		/// <summary>
		/// Returns a value that indicates whether the notification has a value.
		/// </summary>
		[JsProperty(NativeField = true)]
		public abstract bool hasValue { get; }

		/// <summary>
		/// Returns the value of an OnNext notification.
		/// </summary>
		[JsProperty(NativeField = true)]
		public abstract T value { get; }

		/// <summary>
		/// Returns the exception of an OnError notification or returns null.
		/// </summary>
		[JsProperty(NativeField = true)]
		public abstract JsError exception { get; }
	}
#pragma warning restore 659

	#endregion

	#region Observer

	/// <summary>
	/// Provides a set of static methods for creating observers.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.Observer", OmitOptionalParameters = true, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public static class Observer
	{
		#region create

		/// <summary>
		/// Creates an observer from the specified OnNext, OnError, and OnCompleted actions.
		/// </summary>
		/// <param name="onNext">Observer's OnNext action implementation.</param>
		/// <param name="onError">Observer's OnError action implementation. If not specified, the error is rethrown.</param>
		/// <param name="onCompleted">Observer's OnCompleted action implementation. If not specified, the completion message is ignored.</param>
		/// <returns>The observer object implemented using the given actions.</returns>
		[JsMethod(NativeOverloads = true)]
		public static IObserver<T> create<T>(JsAction<T> onNext, JsAction<JsError> onError = null, JsAction onCompleted = null) { return null; }

		/// <summary>
		/// Creates an observer from the specified OnNext, OnError, and OnCompleted actions.
		/// </summary>
		/// <param name="onNext">Observer's OnNext action implementation.</param>
		/// <param name="onCompleted">Observer's OnCompleted action implementation.</param>
		/// <returns>The observer object implemented using the given actions.</returns>
		[JsMethod(NativeOverloads = true, InsertArg1 = "undefined")]
		public static IObserver<T> create<T>(JsAction<T> onNext, JsAction onCompleted) { return null; }

		#endregion

		/// <summary>
		/// Creates a notification callback from an observer.
		/// </summary>
		/// <param name="observer">Observer instance.</param>
		/// <returns>The action that forwards its input notification to the underlying observer.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static JsAction<Notification<T>> toNotifier<T>(this IObserver<T> observer) { return null; }

		/// <summary>
		/// Hides the identity of an observer.
		/// </summary>
		/// <param name="observer">Observer instance.</param>
		/// <returns>An observer that hides the identity of the specified observer.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IObserver<T> asObserver<T>(this IObserver<T> observer) { return null; }
	}

	#endregion

	#region Scheduler

	/// <summary>
	/// Provides a set of static methods for creating Schedulers.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "Rx.Scheduler", Export = false, IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public static class Scheduler
	{
		/// <summary>
		/// Gets the current time.
		/// </summary>
		/// <returns>Current time.</returns>
		public static long now
		{
			[JsMethod(Name = "now")]
			get { return default(long); }
		}

		/// <summary>
		/// Scheduler that runs actions synchronously on the current thread. When using time-based operations, script execution may block, which is often undesirable.
		/// In such scenarios, use Rx.Scheduler.Timeout instead.
		/// </summary>
		[JsProperty(NativeField = true)]
		public static ImmediateScheduler Immediate { get { return null; } }

		/// <summary>
		/// Scheduler that runs actions on the current thread using a trampoline. When using time-based operations, script execution may block, which is often undesirable.
		/// In such scenarios, use Rx.Schedule.Timeout instead.
		/// </summary>
		[JsProperty(NativeField = true)]
		public static CurrentThreadScheduler CurrentThread { get { return null; } }

		/// <summary>
		/// Scheduler that runs actions using the setTimeout JavaScript function.
		/// </summary>
		[JsProperty(NativeField = true)]
		public static TimeoutScheduler Timeout { get { return null; } }

		/// <summary>
		/// Normalizes the given relative time span, i.e. negative time is rounded up to 0.
		/// </summary>
		/// <returns>Normalized relative time span.</returns>
		public static long normalize(long timeSpan) { return default(long); }

		/// <summary>
		/// Schedules the specified action immediately.
		/// <para>E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(function () { alert('Hello!'); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="action">Action to be scheduled.</param>
		/// <returns>A disposable object that can be used to cancel the scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable schedule(this IScheduler scheduler, JsAction action) { return null; }

		/// <summary>
		/// Schedules the specified action immediately, supplying it the given state object.
		/// <para>E.g. var cancel = Rx.Scheduler.CurrentThread.schedule("Bart", function (name) { alert('Hello ' + name + '!'); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="state">State to pass to the action.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object.</param>
		/// <returns>A disposable object that can be used to cancel the scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable scheduleWithState<TState>(this IScheduler scheduler, TState state, JsAction<TState> action) { return null; }

		/// <summary>
		/// Schedules the specified action at the given relative due time.
		/// <para>E.g. var cancel = Rx.Scheduler.Timeout.schedule(1000 /* 1s */, function () { alert('Hello!'); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action.</param>
		/// <param name="action">Action to be scheduled.</param>
		/// <returns>A disposable object that can be used to cancel the scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable scheduleWithRelative(this IScheduler scheduler, long dueTime, JsAction action) { return null; }

		/// <summary>
		/// Schedules the specified action at the given absolute due time.
		/// <para>E.g. var cancel = Rx.Scheduler.Timeout.schedule(new Date(2012, 2, 11), function () { alert('Hello!'); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action.</param>
		/// <param name="action">Action to be scheduled.</param>
		/// <returns>A disposable object that can be used to cancel the scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable scheduleWithAbsolute(this IScheduler scheduler, JsDate dueTime, JsAction action) { return null; }

		/// <summary>
		/// Schedules the specified action recursively.
		/// <para>E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(function (self) { alert('Hello!'); self(); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable scheduleRecursive(this IScheduler scheduler, JsAction<JsAction> action) { return null; }

		/// <summary>
		/// Schedules the specified action recursively using relative due times.
		/// <para>E.g. var cancel = Rx.Scheduler.Timeout.schedule(1000 /* 1s */, function (self) { alert('Hello!'); self(1000 /* 1s */); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable scheduleRecursiveWithRelative(this IScheduler scheduler, long dueTime, JsAction<JsAction<long>> action) { return null; }

		/// <summary>
		/// Schedules the specified action recursively using absolute due times.
		/// <para>E.g. var cancel = Rx.Scheduler.Timeout.schedule(new DateTime(2011, 2, 11), function (self) { alert('Hello!'); self(new Date(new Date().getFullYear() + 1, 2, 11)); });</para>
		/// </summary>
		/// <param name="scheduler">Scheduler instance.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		[JsMethod(ExtensionImplementedInInstance = true)]
		public static IDisposable scheduleRecursiveWithAbsolute(this IScheduler scheduler, JsDate dueTime, JsAction<JsAction<JsDate>> action) { return null; }
	}

	#endregion

	#region ImmediateScheduler

	/// <summary>
	/// Scheduler that runs actions synchronously on the current thread. When using time-based operations, script execution may block, which is often undesirable.
	/// In such scenarios, use Rx.Schedule.Timeout instead.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "Rx.ImmediateScheduler", Export = true)]
	public class ImmediateScheduler : IScheduler
	{
		#region Implementation of IScheduler

		/// <summary>
		/// Schedules the specified action recursively, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(0, function (i, self) { alert('Hello ' + i + '!'); self(i + 1); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithState<TState>(TState state, JsAction<TState, JsAction<TState>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using relative due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule(0, 1000 /* 1s */, function (i, self) { alert('Hello ' + i + '!'); self(i + 1, 1000 /* 1s */); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithRelativeAndState<TState>(TState state, long dueTime, JsAction<TState, JsAction<TState, long>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using absolute due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule("Bart", new DateTime(2011, 2, 11), function (name, self) { alert('Hello ' + name + '!'); self(name, new Date(new Date().getFullYear() + 1, 2, 11)); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithAbsoluteAndState<TState>(TState state, JsDate dueTime, JsAction<TState, JsAction<TState, JsDate>> action)
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#region CurrentThreadScheduler

	/// <summary>
	/// Scheduler that runs actions on the current thread using a trampoline. When using time-based operations, script execution may block, which is often undesirable.
	/// In such scenarios, use Rx.Schedule.Timeout instead.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "Rx.CurrentThreadScheduler", Export = true)]
	public class CurrentThreadScheduler : IScheduler
	{
		#region Implementation of IScheduler

		/// <summary>
		/// Schedules the specified action recursively, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(0, function (i, self) { alert('Hello ' + i + '!'); self(i + 1); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithState<TState>(TState state, JsAction<TState, JsAction<TState>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using relative due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule(0, 1000 /* 1s */, function (i, self) { alert('Hello ' + i + '!'); self(i + 1, 1000 /* 1s */); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithRelativeAndState<TState>(TState state, long dueTime, JsAction<TState, JsAction<TState, long>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using absolute due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule("Bart", new DateTime(2011, 2, 11), function (name, self) { alert('Hello ' + name + '!'); self(name, new Date(new Date().getFullYear() + 1, 2, 11)); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithAbsoluteAndState<TState>(TState state, JsDate dueTime, JsAction<TState, JsAction<TState, JsDate>> action)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		/// <summary>
		/// Gets a value indicating whether the caller must call a schedule method.
		/// </summary>
		public bool scheduleRequired
		{
			[JsMethod(Name = "scheduleRequired")]
			get { return default(bool); }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="action"></param>
		[JsMethod(NativeOverloads = true)]
		public void ensureTrampoline(JsAction action) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="action"></param>
		/// <returns></returns>
		[JsMethod(NativeOverloads = true)]
		public object ensureTrampoline(JsFunc<object> action) { return null; }

		/// <summary>
		/// 
		/// </summary>
		[JsProperty(NativeField = true)]
		public object queue { get { return null; } }
	}

	#endregion

	#region TimeoutScheduler

	/// <summary>
	/// Scheduler that runs actions using the setTimeout JavaScript function.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.TimeoutScheduler")]
	public class TimeoutScheduler : IScheduler
	{
		#region Implementation of IScheduler

		/// <summary>
		/// Schedules the specified action recursively, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(0, function (i, self) { alert('Hello ' + i + '!'); self(i + 1); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithState<TState>(TState state, JsAction<TState, JsAction<TState>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using relative due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule(0, 1000 /* 1s */, function (i, self) { alert('Hello ' + i + '!'); self(i + 1, 1000 /* 1s */); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithRelativeAndState<TState>(TState state, long dueTime, JsAction<TState, JsAction<TState, long>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using absolute due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule("Bart", new DateTime(2011, 2, 11), function (name, self) { alert('Hello ' + name + '!'); self(name, new Date(new Date().getFullYear() + 1, 2, 11)); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithAbsoluteAndState<TState>(TState state, JsDate dueTime, JsAction<TState, JsAction<TState, JsDate>> action)
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#region VirtualTimeScheduler

	/// <summary>
	/// Represents the base class for virtual time schedulers using a priority queue for scheduled items.
	/// </summary>
	/// <typeparam name="TAbsolute">The absolute time argument type.</typeparam>
	/// <typeparam name="TRelative">The relative time argument type.</typeparam>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.VirtualTimeScheduler", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public class VirtualTimeScheduler<TAbsolute, TRelative> : IScheduler
	{
		#region Implementation of IScheduler

		/// <summary>
		/// Schedules the specified action recursively, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.CurrentThread.schedule(0, function (i, self) { alert('Hello ' + i + '!'); self(i + 1); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithState<TState>(TState state, JsAction<TState, JsAction<TState>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using relative due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule(0, 1000 /* 1s */, function (i, self) { alert('Hello ' + i + '!'); self(i + 1, 1000 /* 1s */); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Relative time (specified in milliseconds) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithRelativeAndState<TState>(TState state, long dueTime, JsAction<TState, JsAction<TState, long>> action)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Schedules the specified action recursively using absolute due times, supplying it the given initial state object.
		/// &#10;
		/// &#10;E.g. var cancel = Rx.Scheduler.Timeout.schedule("Bart", new DateTime(2011, 2, 11), function (name, self) { alert('Hello ' + name + '!'); self(name, new Date(new Date().getFullYear() + 1, 2, 11)); });
		/// </summary>
		/// <param name="state">Initial state to pass to the action.</param>
		/// <param name="dueTime">Absolute time (specified as a Date object) at which to schedule the given action the first time.</param>
		/// <param name="action">Action to be scheduled. The first parameter passed to the action corresponds to the given state object. The second parameter passed to the action is a function that can be invoked to make a recursive call.</param>
		/// <returns>A disposable object that can be used to cancel the recursive scheduled action.</returns>
		public IDisposable scheduleRecursiveWithAbsoluteAndState<TState>(TState state, JsDate dueTime, JsAction<TState, JsAction<TState, JsDate>> action)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		/// <summary>
		/// Creates a new virtual time scheduler.
		/// </summary>
		/// <param name="initialClock">Initial value for the clock.</param>
		/// <param name="comparer">Comparer to determine causality of events based on absolute time.</param>
		public VirtualTimeScheduler(TAbsolute initialClock, JsFunc<TAbsolute, TAbsolute, int> comparer) { }

		/// <summary>
		/// Schedules an action to be executed at dueTime.
		/// </summary>
		/// <param name="state">State passed to the action to be executed.</param>
		/// <param name="action">Action to be executed.</param>
		/// <param name="dueTime">Relative time after which to execute the action.</param>
		/// <returns>The disposable object used to cancel the scheduled action (best effort).</returns>
		[JsMethod(NativeOverloads = true)]
		public IDisposable scheduleRelative<TState>(TState state, TRelative dueTime, JsAction<TState> action) { return null; }

		/// <summary>
		/// Schedules an action to be executed at dueTime.
		/// </summary>
		/// <param name="state">State passed to the action to be executed.</param>
		/// <param name="action">Action to be executed.</param>
		/// <param name="dueTime">Absolute time at which to execute the action.</param>
		/// <returns>The disposable object used to cancel the scheduled action (best effort).</returns>
		[JsMethod(NativeOverloads = true)]
		public IDisposable scheduleAbsolute<TState>(TState state, TAbsolute dueTime, JsAction<TState> action) { return null; }

		/// <summary>
		/// Starts the virtual time scheduler.
		/// </summary>
		public void start() { }

		/// <summary>
		/// Stops the virtual time scheduler.
		/// </summary>
		public void stop() { }

		/// <summary>
		/// Advances the scheduler's clock to the specified time, running all work till that point.
		/// </summary>
		/// <param name="time">Absolute time to advance the scheduler's clock to.</param>
		public void advanceTo(TAbsolute time) { }

		/// <summary>
		/// Advances the scheduler's clock by the specified relative time, running all work scheduled for that timespan.
		/// </summary>
		/// <param name="time">Relative time to advance the scheduler's clock by.</param>
		public void advanceBy(TRelative time) { }

		/// <summary>
		/// Gets the next scheduled item to be executed.
		/// </summary>
		/// <returns>The next scheduled item.</returns>
		public IScheduledItem<TAbsolute> getNext() { return null; }
	}

	/// <summary>
	/// Represents virtual time schedulers using a priority queue for scheduled items.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.VirtualTimeScheduler", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public class VirtualTimeScheduler : VirtualTimeScheduler<JsDate, long>
	{
		/// <summary>
		/// Creates a new virtual time scheduler.
		/// </summary>
		/// <param name="initialClock">Initial value for the clock.</param>
		/// <param name="comparer">Comparer to determine causality of events based on absolute time.</param>
		public VirtualTimeScheduler(JsDate initialClock, JsFunc<JsDate, JsDate, int> comparer) : base(initialClock, comparer) { }
	}

	#endregion

	#region ConnectableObservable

	/// <summary>
	/// Implementation of the <see cref="T:IConnectableObservable[T]"/>
	/// </summary>
	/// <typeparam name="T">The type of element.</typeparam>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.ConnectableObservable", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public class ConnectableObservable<T> : IConnectableObservable<T>
	{
		#region Implementation of IObservable<out T>

		/// <summary>
		/// Subscribes to the observable sequence by specifying an observer.
		/// </summary>
		/// <param name="observer">Observer object to receive notifications on.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		public IDisposable subscribe(IObserver<T> observer)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IConnectableObservable<out T>

		/// <summary>
		/// Connects the observable to its source.
		/// </summary>
		/// <returns>Disposable used to disconnect the observable sequence from its source.</returns>
		public IDisposable connect()
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#region Subject

	/// <summary>
	/// Provides a set of static methods for creating observers.
	/// </summary>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.Subject", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public static class Subject
	{
		/// <summary>
		/// Creates a subject from the specified observer and observable.
		/// </summary>
		/// <param name="observer">The observer used to publish messages to the subject.</param>
		/// <param name="observable">The observable used to subscribe to messages sent from the subject.</param>
		/// <returns>Subject implemented using the given observer and observable.</returns>
		public static ISubject<TSource, TResult> create<TSource, TResult>(IObserver<TSource> observer, IObservable<TResult> observable) { return null; }
	}

	/// <summary>
	/// Represents an object that is both an observable sequence as well as an observer.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.Subject", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public sealed class Subject<T> : ISubject<T>, IDisposable
	{
		#region Implementation of IObserver<in T>

		/// <summary>
		/// Notifies the observer by supplying a new sequence element.
		/// </summary>
		/// <param name="value">New sequence element.</param>
		public void onNext(T value)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer about an error that occurred in the sequence.
		/// </summary>
		/// <param name="exception">The error object.</param>
		public void onError(JsError exception)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer of the termination of the sequence.
		/// </summary>
		public void onCompleted()
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IObservable<out T>

		/// <summary>
		/// Subscribes to the observable sequence by specifying an observer.
		/// </summary>
		/// <param name="observer">Observer object to receive notifications on.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		public IDisposable subscribe(IObserver<T> observer)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IDisposable

		/// <summary>
		/// Unsubscribe all observers and release resources.
		/// </summary>
		public void dispose()
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#region AsyncSubject

	/// <summary>
	/// Represents a subject that can only receive one value and that value is cached for all future observations.
	/// Represents the result of an asynchronous operation.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.AsyncSubject", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public sealed class AsyncSubject<T> : ISubject<T>, IDisposable
	{
		#region Implementation of IObserver<in T>

		/// <summary>
		/// Notifies the observer by supplying a new sequence element.
		/// </summary>
		/// <param name="value">New sequence element.</param>
		public void onNext(T value)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer about an error that occurred in the sequence.
		/// </summary>
		/// <param name="exception">The error object.</param>
		public void onError(JsError exception)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer of the termination of the sequence.
		/// </summary>
		public void onCompleted()
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IObservable<out T>

		/// <summary>
		/// Subscribes to the observable sequence by specifying an observer.
		/// </summary>
		/// <param name="observer">Observer object to receive notifications on.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		public IDisposable subscribe(IObserver<T> observer)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IDisposable

		/// <summary>
		/// Unsubscribe all observers and release resources.
		/// </summary>
		public void dispose()
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#region BehaviorSubject

	/// <summary>
	/// Represents a value that changes over time.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.BehaviorSubject", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true)]
	public sealed class BehaviorSubject<T> : ISubject<T>, IDisposable
	{
		/// <summary>
		/// Creates a subject that caches its last value and starts with the specified value.
		/// </summary>
		/// <param name="value">Initial value sent to observers when no other value has been received by the subject yet.</param>
		public BehaviorSubject(T value) { }

		#region Implementation of IObserver<in T>

		/// <summary>
		/// Notifies the observer by supplying a new sequence element.
		/// </summary>
		/// <param name="value">New sequence element.</param>
		public void onNext(T value)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer about an error that occurred in the sequence.
		/// </summary>
		/// <param name="exception">The error object.</param>
		public void onError(JsError exception)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer of the termination of the sequence.
		/// </summary>
		public void onCompleted()
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IObservable<out T>

		/// <summary>
		/// Subscribes to the observable sequence by specifying an observer.
		/// </summary>
		/// <param name="observer">Observer object to receive notifications on.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		public IDisposable subscribe(IObserver<T> observer)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IDisposable

		/// <summary>
		/// Unsubscribe all observers and release resources.
		/// </summary>
		public void dispose()
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#region ReplaySubject

	/// <summary>
	/// Represents an object that is both an observable sequence as well as an observer.
	/// </summary>
	/// <typeparam name="T">The type.</typeparam>
	[JsType(JsMode.Prototype, Export = false, Name = "Rx.ReplaySubject", IgnoreGenericTypeArguments = true, IgnoreGenericMethodArguments = true, OmitOptionalParameters = true)]
	public sealed class ReplaySubject<T> : ISubject<T>, IDisposable
	{
		/// <summary>
		/// Creates a new replay subject with the specified buffer size, window and scheduler.
		/// </summary>
		/// <param name="bufferSize">Maximum element count of the replay buffer. If not specified, the buffer size is infinite.</param>
		/// <param name="window">Maximum time length of the replay buffer. If not specified, the window length is infinite.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		[JsMethod(NativeOverloads = true)]
		public ReplaySubject(int bufferSize = -1, long window = -1, IScheduler scheduler = null) { }

		/// <summary>
		/// Creates a new replay subject with the specified buffer size and scheduler. Window length is infinite.
		/// </summary>
		/// <param name="bufferSize">Maximum element count of the replay buffer. If not specified, the buffer size is infinite.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		[JsMethod(NativeOverloads = true, InsertArg1 = "undefined")]
		public ReplaySubject(int bufferSize, IScheduler scheduler) { }

		/// <summary>
		/// Creates a new replay subject with the infinite buffer size, window and scheduler.
		/// </summary>
		/// <param name="window">Maximum time length of the replay buffer. If not specified, the window length is infinite.</param>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on. If not specified, the current thread scheduler is used.</param>
		[JsMethod(NativeOverloads = true, InsertArg0 = "undefined")]
		public ReplaySubject(long window, IScheduler scheduler = null) { }

		/// <summary>
		/// Creates a new replay subject with the specified scheduler. The buffer size and window is infinite.
		/// </summary>
		/// <param name="scheduler">Scheduler where connected observers will be invoked on.</param>
		[JsMethod(NativeOverloads = true, InsertArg0 = "undefined", InsertArg1 = "undefined")]
		public ReplaySubject(IScheduler scheduler) { }

		#region Implementation of IObserver<in T>

		/// <summary>
		/// Notifies the observer by supplying a new sequence element.
		/// </summary>
		/// <param name="value">New sequence element.</param>
		public void onNext(T value)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer about an error that occurred in the sequence.
		/// </summary>
		/// <param name="exception">The error object.</param>
		public void onError(JsError exception)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Notifies the observer of the termination of the sequence.
		/// </summary>
		public void onCompleted()
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IObservable<out T>

		/// <summary>
		/// Subscribes to the observable sequence by specifying an observer.
		/// </summary>
		/// <param name="observer">Observer object to receive notifications on.</param>
		/// <return>Disposable object used to unsubscribe from the observable sequence.</return>
		public IDisposable subscribe(IObserver<T> observer)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		#region Implementation of IDisposable

		/// <summary>
		/// Unsubscribe all observers and release resources.
		/// </summary>
		public void dispose()
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}

	#endregion

	#endregion

	// ReSharper restore InconsistentNaming
}
