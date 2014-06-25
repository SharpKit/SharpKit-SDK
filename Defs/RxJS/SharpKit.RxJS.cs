using SharpKit.JavaScript;
using SharpKit.Html4;
using System;
namespace SharpKit.Rx
{
    #region AsyncSubject Class
    /// <summary>
    /// Represents the result of an asynchronous operation.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.AsyncSubject")]
    public class AsyncSubject : Observable, IObservable, ISubject, IObserver
    {
        /// <summary>
        /// Creates a subject that can only receive one value and that value is cached for all future observations.
        /// </summary>
        public AsyncSubject(Scheduler scheduler) { }
        /// <summary>
        /// Creates a subject that can only receive one value and that value is cached for all future observations.
        /// </summary>
        public AsyncSubject() { }
        /// <summary>
        /// Notifies all subscribed observers of the end of the sequence.
        /// </summary>
        public virtual void OnCompleted() { }
        /// <summary>
        /// Notifies all subscribed observers with the exception.
        /// </summary>
        public virtual void OnError(object exception) { }
        /// <summary>
        /// Notifies all subscribed observers with the value.
        /// </summary>
        public virtual void OnNext(object value) { }
    }
    #endregion
    #region BehaviorSubject Class
    /// <summary>
    /// Represents an object that is both an observable sequence as well as an observer.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.BehaviorSubject")]
    public class BehaviorSubject : ReplaySubject, IObservable, ISubject, IObserver
    {
        /// <summary>
        /// Creates a behavior subject.
        /// </summary>
        public BehaviorSubject(object value, Scheduler scheduler) : base(default(int), default(int)) { }
        /// <summary>
        /// Creates a behavior subject.
        /// </summary>
        public BehaviorSubject(object value) : base(default(int), default(int)) { }
    }
    #endregion
    #region BooleanDisposable Class
    /// <summary>
    /// Represents an IDisposable that can be checked for status.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.BooleanDisposable")]
    public class BooleanDisposable : IDisposable
    {
        /// <summary>
        /// Constructs a new undisposed BooleanDisposable.
        /// </summary>
        public BooleanDisposable() { }
        /// <summary>
        /// Sets the status to Disposed.
        /// </summary>
        public virtual void Dispose() { }
        /// <summary>
        /// Gets a value indicating whether the object is disposed.
        /// </summary>
        public bool GetIsDisposed() { return default(bool); }
    }
    #endregion
    #region CompositeDisposable Class
    /// <summary>
    /// Represents a group of Disposables that are disposed together.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.CompositeDisposable")]
    public class CompositeDisposable : IDisposable
    {
        /// <summary>
        /// Constructs a CompositeDisposable from a group of disposables.
        /// </summary>
        public CompositeDisposable() { }
        /// <summary>
        /// Constructs a CompositeDisposable from a group of disposables.
        /// </summary>
        public CompositeDisposable(IDisposable d1) { }
        /// <summary>
        /// Constructs a CompositeDisposable from a group of disposables.
        /// </summary>
        public CompositeDisposable(IDisposable d1, IDisposable d2) { }
        /// <summary>
        /// Constructs a CompositeDisposable from a group of disposables.
        /// </summary>
        public CompositeDisposable(IDisposable d1, IDisposable d2, IDisposable d3) { }
        /// <summary>
        /// Constructs a CompositeDisposable from a group of disposables.
        /// </summary>
        public CompositeDisposable(IDisposable d1, IDisposable d2, IDisposable d3, IDisposable d4) { }
        /// <summary>
        /// Adds a disposable to the CompositeDisposable or disposes the disposable if the CompositeDisposable is disposed.
        /// </summary>
        public void Add(IDisposable item) { }
        /// <summary>
        /// Removes and disposes all disposables from the CompositeDisposable, but does not dispose the CompositeDisposable.
        /// </summary>
        public void Clear() { }
        /// <summary>
        /// Disposes all disposables in the group and removes them from the group.
        /// </summary>
        public virtual void Dispose() { }
        /// <summary>
        /// Gets the number of disposables contained in the CompositeDisposable.
        /// </summary>
        public int GetCount() { return default(int); }
        /// <summary>
        /// Removes and disposes the first occurrence of a disposable from the CompositeDisposable.
        /// </summary>
        public bool Remove(IDisposable item) { return default(bool); }
    }
    #endregion
    #region ConnectableObservable Class
    /// <summary>
    /// Represents an observable that can be connected and disconnected from its source.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.ConnectableObservable")]
    public class ConnectableObservable : Observable, IObservable
    {
        /// <summary>
        /// Creates an observable that can be connected and disconnected from its source.
        /// </summary>
        public ConnectableObservable(Observable source, ISubject subject) { }
        /// <summary>
        /// Creates an observable that can be connected and disconnected from its source.
        /// </summary>
        public ConnectableObservable(Observable source) { }
        /// <summary>
        /// Connects the observable to its source.
        /// </summary>
        public IDisposable Connect() { return default(IDisposable); }
        /// <summary>
        /// Returns an observable sequence that stays connected to the source as long as there is at least one subscription to the observable sequence.
        /// </summary>
        public Observable RefCount() { return default(Observable); }
    }
    #endregion
    #region Disposable Class
    /// <summary>
    /// Provides a set of static methods for creating Disposables.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Disposable")]
    public class Disposable
    {
        /// <summary>
        /// Creates the disposable that invokes dispose when disposed.
        /// </summary>
        public static IDisposable Create(Action action) { return default(IDisposable); }
        /// <summary>
        /// Represents the disposable that does nothing when disposed.
        /// </summary>
        public IDisposable Empty { get; set; }
    }
    #endregion
    #region GroupedObservable Class
    /// <summary>
    /// Represents an observable sequence of values that have a common key.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.GroupedObservable")]
    public class GroupedObservable : Observable, IObservable
    {
        private GroupedObservable() { }
        /// <summary>
        /// Gets the common key.
        /// </summary>
        public object Key { get; set; }
    }
    #endregion
    #region IObservable Interface
    /// <summary>
    /// Represents a push-style collection.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.IObservable")]
    public interface IObservable
    {
        /// <summary>
        /// Subscribes an observer to the observable sequence.
        /// </summary>
        IDisposable Subscribe(IObserver observer);
    }
    #endregion
    #region IObserver Interface
    /// <summary>
    /// Supports push-style iteration over an observable sequence.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.IObserver")]
    public interface IObserver
    {
        /// <summary>
        /// Notifies the observer of the end of the sequence.
        /// </summary>
        void OnCompleted();
        /// <summary>
        /// Notifies the observer that an exception has occurred.
        /// </summary>
        void OnError(object exception);
        /// <summary>
        /// Notifies the observer of a new value in the sequence.
        /// </summary>
        void OnNext(object value);
    }
    #endregion
    #region ISubject Interface
    /// <summary>
    /// Represents an object that is both an observable sequence as well as an observer.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.ISubject")]
    public interface ISubject : IObservable, IObserver
    {
    }
    #endregion
    #region List Class
    /// <summary>
    /// Represents mutable List semantics in JavaScript
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.List")]
    public class List
    {
        /// <summary>
        /// Creates a new List.
        /// </summary>
        public List() { }
        public List(Func<object, bool, bool> comparer) { }
        /// <summary>
        /// Adds item to the list.
        /// </summary>
        public void Add(object item) { }
        /// <summary>
        /// Clears the list.
        /// </summary>
        public void Clear() { }
        /// <summary>
        /// Returns the amount of items in the list.
        /// </summary>
        public int GetCount() { return default(int); }
        /// <summary>
        /// returns item at position index.
        /// </summary>
        public object GetItem(int index) { return default(object); }
        /// <summary>
        /// Searches item in the list and returns it index if found, returns -1 otherwise.
        /// </summary>
        public int IndexOf(object item) { return default(int); }
        /// <summary>
        /// Tries to remove item from list, returns boolean indicating success.
        /// </summary>
        public bool Remove(object item) { return default(bool); }
        /// <summary>
        /// Removes item at index.
        /// </summary>
        public void RemoveAt(int index) { }
        /// <summary>
        /// Replaces value at postition index with item.
        /// </summary>
        public void SetItem(int index, object item) { }
        public Object[] ToArray() { return default(Object[]); }
    }
    #endregion
    #region MutableDisposable Class
    /// <summary>
    /// Represents a disposable whose underlying disposable can be swapped for another disposable.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.MutableDisposable")]
    public class MutableDisposable : IDisposable
    {
        /// <summary>
        /// Constructs a new MutableDisposable with no current underlying disposable.
        /// </summary>
        public MutableDisposable() { }
        /// <summary>
        /// Disposes the underlying disposable as well as all future replacements.
        /// </summary>
        public virtual void Dispose() { }
        /// <summary>
        /// Gets a value indicating whether the MutableDisposable has an underlying disposable.
        /// </summary>
        public IDisposable Get() { return default(IDisposable); }
        /// <summary>
        /// Swaps and disposes the current disposable with the new disposable.
        /// </summary>
        public void Replace(IDisposable disposable) { }
    }
    #endregion
    #region Notification Class
    /// <summary>
    /// Represents a notification to an observer.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Notification")]
    public class Notification : Observable, IObservable
    {
        /// <summary>
        /// Constructs a notification.
        /// </summary>
        public Notification(string kind, object value) { }
        /// <summary>
        /// Constructs a notification.
        /// </summary>
        public Notification(string kind) { }
        /// <summary>
        /// Invokes the observer's method corresponding to the notification.
        /// </summary>
        public IDisposable Accept(Observer observer) { return default(IDisposable); }
        /// <summary>
        /// Gets the kind of notification that is represented.
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// Returns the current value.
        /// </summary>
        public string Value { get; set; }
    }
    #endregion
    #region Observable Class
    /// <summary>
    /// Represents a push-style collection.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Observable")]
    public class Observable : IObservable
    {
        public Observable() { }
        public Observable Aggregate(object seed, Func<object, object, object> accumulator) { return default(Observable); }
        public Observable Aggregate1(Func<object, object, object> accumulator) { return default(Observable); }
        public Observable All(Func<object, bool> predicate) { return default(Observable); }
        /// <summary>
        /// Returns the observable sequence that reacts first.
        /// </summary>
        public static Observable Amb(Observable o1) { return default(Observable); }
        /// <summary>
        /// Returns the observable sequence that reacts first.
        /// </summary>
        public static Observable Amb(Observable o1, Observable o2) { return default(Observable); }
        /// <summary>
        /// Returns the observable sequence that reacts first.
        /// </summary>
        public static Observable Amb(Observable o1, Observable o2, Observable o3) { return default(Observable); }
        /// <summary>
        /// Returns the observable sequence that reacts first.
        /// </summary>
        public static Observable Amb(Observable o1, Observable o2, Observable o3, Observable o4) { return default(Observable); }
        /// <summary>
        /// Matches when both observable sequences have an available value.
        /// </summary>
        public Pattern And(Observable other) { return default(Pattern); }
        /// <summary>
        /// Determines whether an observable sequence contains any elements.
        /// </summary>
        public Observable Any() { return default(Observable); }
        public Observable Any(Func<object, bool> predicate) { return default(Observable); }
        /// <summary>
        /// Hides the identity of an observable sequence.
        /// </summary>
        public Observable AsObservable() { return default(Observable); }
        /// <summary>
        /// Computes the average of a sequence of numeric values.
        /// </summary>
        public Observable Average() { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithCount(int count) { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithCount(int count, int skip) { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithTime(int timeSpan) { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithTime(int timeSpan, int timeShift) { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithTime(int timeSpan, int timeShift, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithTimeOrCount(int timeSpan, int count) { return default(Observable); }
        /// <summary>
        /// Projects each value of an observable sequence into a buffer.
        /// </summary>
        public Observable BufferWithTimeOrCount(int timeSpan, int count, Scheduler scheduler) { return default(Observable); }
        public static Observable Case(Func<Observable> selector, JsObject sources) { return default(Observable); }
        public static Observable Case(Func<Observable> selector, JsObject sources, Observable defaultSource) { return default(Observable); }
        public static Observable Case(Func<Observable> selector, JsObject sources, Observable defaultSource, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated by an exception with the next observable sequence.
        /// </summary>
        public static Observable Catch(Observable[] items) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated by an exception with the next observable sequence.
        /// </summary>
        public static Observable Catch(Observable[] items, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated by an exception with the next observable sequence.
        /// </summary>
        public Observable Catch(Observable o1) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated by an exception with the next observable sequence.
        /// </summary>
        public Observable Catch(Observable o1, Observable o2) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated by an exception with the next observable sequence.
        /// </summary>
        public Observable Catch(Observable o1, Observable o2, Observable o3) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated by an exception with the next observable sequence.
        /// </summary>
        public Observable Catch(Observable o1, Observable o2, Observable o3, Observable o4) { return default(Observable); }
        public Observable CombineLatest(Observable right, Func<object, object, object> selector) { return default(Observable); }
        /// <summary>
        /// Concatenates all the observable sequences.
        /// </summary>
        public static Observable Concat(Observable[] items) { return default(Observable); }
        /// <summary>
        /// Concatenates all the observable sequences.
        /// </summary>
        public static Observable Concat(Observable[] items, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Concatenates all the observable sequences.
        /// </summary>
        public Observable Concat(Observable o1) { return default(Observable); }
        /// <summary>
        /// Concatenates all the observable sequences.
        /// </summary>
        public Observable Concat(Observable o1, Observable o2) { return default(Observable); }
        /// <summary>
        /// Concatenates all the observable sequences.
        /// </summary>
        public Observable Concat(Observable o1, Observable o2, Observable o3) { return default(Observable); }
        /// <summary>
        /// Concatenates all the observable sequences.
        /// </summary>
        public Observable Concat(Observable o1, Observable o2, Observable o3, Observable o4) { return default(Observable); }
        /// <summary>
        /// Determines whether an observable sequence contains a specified element by using the default comparer.
        /// </summary>
        public Observable Contains(object value) { return default(Observable); }
        public Observable Contains(object value, Func<object, bool, bool> comparer) { return default(Observable); }
        /// <summary>
        /// Returns an number representing the total number of elements in an observable sequence.
        /// </summary>
        public Observable Count() { return default(Observable); }
        public static Observable Create(Func<Observer, Action> subcribe) { return default(Observable); }
        public static Observable CreateWithDisposable(Func<Observer, IDisposable> subcribe) { return default(Observable); }
        public static Observable Defer(Func<Observable> observableFactory) { return default(Observable); }
        /// <summary>
        /// Time shifts the observable sequence by dueTime.
        /// The relative time intervals between the values are preserved.
        /// </summary>
        public Observable Delay(int dueTime) { return default(Observable); }
        /// <summary>
        /// Time shifts the observable sequence by dueTime.
        /// The relative time intervals between the values are preserved.
        /// </summary>
        public Observable Delay(int dueTime, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Dematerializes the explicit notification values of an observable sequence as implicit notifications.
        /// </summary>
        public Observable Dematerialize() { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains only distinct contiguous values.
        /// </summary>
        public Observable DistinctUntilChanged() { return default(Observable); }
        public Observable DistinctUntilChanged(Func<object, object> keySelector) { return default(Observable); }
        public Observable DistinctUntilChanged(Func<object, object> keySelector, Func<object, bool, bool> comparer) { return default(Observable); }
        public Observable Do(Action<object> onNext) { return default(Observable); }
        public Observable Do(Action<object> onNext, Action<object> onError) { return default(Observable); }
        public Observable Do(Action<object> onNext, Action<object> onError, Action onCompleted) { return default(Observable); }
        /// <summary>
        /// Invokes the observer for its side-effects on each value in the observable sequence.
        /// </summary>
        public Observable Do(Observer observer) { return default(Observable); }
        public static Observable DoWhile(Observable source, Func<bool> condition) { return default(Observable); }
        /// <summary>
        /// Returns an empty observable sequence.
        /// </summary>
        public static Observable Empty() { return default(Observable); }
        /// <summary>
        /// Returns an empty observable sequence.
        /// </summary>
        public static Observable Empty(Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns an observable that contains only the final OnNext value.
        /// </summary>
        public Observable Final() { return default(Observable); }
        /// <summary>
        /// Invokes finallyAction after source observable sequence terminates normally or by an exception.
        /// </summary>
        public Observable Finally(Action finallyAction) { return default(Observable); }
        public static Observable For(Array source, Func<object, Observable> resultSelector) { return default(Observable); }
        /// <summary>
        /// Runs all observable sequences in parallel and combines their last values.
        /// </summary>
        public static Observable ForkJoin(Observable o1, Observable o2) { return default(Observable); }
        /// <summary>
        /// Runs all observable sequences in parallel and combines their last values.
        /// </summary>
        public static Observable ForkJoin(Observable o1, Observable o2, Observable o3) { return default(Observable); }
        /// <summary>
        /// Runs all observable sequences in parallel and combines their last values.
        /// </summary>
        public static Observable ForkJoin(Observable o1, Observable o2, Observable o3, Observable o4) { return default(Observable); }
        /// <summary>
        /// Runs all observable sequences in parallel and combines their last values.
        /// </summary>
        public static Observable ForkJoin(Observable o1, Observable o2, Observable o3, Observable o4, Observable o5) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains all values from the array in order.
        /// </summary>
        public static Observable FromArray(Object[] items) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains all values from the array in order.
        /// </summary>
        public static Observable FromArray(Object[] items, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying DOM event.
        /// </summary>
        public static Observable FromDOMEvent(HtmlElement element, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying DOM event.
        /// </summary>
        public static Observable FromDOMEvent(HtmlDocument document, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying DOM event.
        /// </summary>
        public static Observable FromDOMEvent(HtmlWindow window, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying Html event.
        /// </summary>
        public static Observable FromHtmlEvent(HtmlElement element, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying Html event.
        /// </summary>
        public static Observable FromHtmlEvent(HtmlDocument document, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying Html event.
        /// </summary>
        public static Observable FromHtmlEvent(HtmlWindow window, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying Internet Explorer event.
        /// </summary>
        public static Observable FromIEEvent(HtmlElement element, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying Internet Explorer event.
        /// </summary>
        public static Observable FromIEEvent(HtmlDocument document, string eventName) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains the values of the underlying Internet Explorer event.
        /// </summary>
        public static Observable FromIEEvent(HtmlWindow window, string eventName) { return default(Observable); }
        public static Observable Generate(Func<object> initialState, Func<object, bool> condition, Func<object, object> iterate, Func<object, object> resultSelector) { return default(Observable); }
        public static Observable Generate(Func<object> initialState, Func<object, bool> condition, Func<object, object> iterate, Func<object, object> resultSelector, Scheduler scheduler) { return default(Observable); }
        public static Observable GenerateWithTime(Func<object> initialState, Func<object, bool> condition, Func<object, object> iterate, Func<object, object> resultSelector, Func<object, int> timeSelector) { return default(Observable); }
        public static Observable GenerateWithTime(Func<object> initialState, Func<object, bool> condition, Func<object, object> iterate, Func<object, object> resultSelector, Func<object, int> timeSelector, Scheduler scheduler) { return default(Observable); }
        public GroupedObservable GroupBy(Func<object, object> keySelector) { return default(GroupedObservable); }
        public GroupedObservable GroupBy(Func<object, object> keySelector, Func<object, object> elementSelector) { return default(GroupedObservable); }
        public GroupedObservable GroupBy(Func<object, object> keySelector, Func<object, object> elementSelector, Func<object, string> keySerializer) { return default(GroupedObservable); }
        public static Observable If(Func<bool> condition, Observable thenSource, Observable elseSource) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that produces a value after each period.
        /// </summary>
        public static Observable Interval(int period) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that produces a value after each period.
        /// </summary>
        public static Observable Interval(int period, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Determines whether an observable sequence is empty.
        /// </summary>
        public Observable IsEmpty() { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2, Plan p3) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2, Plan p3, Plan p4) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2, Plan p3, Plan p4, Plan p5) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2, Plan p3, Plan p4, Plan p5, Plan p6) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2, Plan p3, Plan p4, Plan p5, Plan p6, Plan p7) { return default(Observable); }
        /// <summary>
        /// Joins together the results from several plans.
        /// </summary>
        public static Observable Join(Plan p1, Plan p2, Plan p3, Plan p4, Plan p5, Plan p6, Plan p7, Plan p8) { return default(Observable); }
        public static Observable Let(object source, Func<object, Observable> resultSelector) { return default(Observable); }
        public Observable Let(Func<Observable, Observable> func) { return default(Observable); }
        public Observable Let(Func<Observable, Observable> func, Func<ISubject> subjectFactory) { return default(Observable); }
        /// <summary>
        /// Materializes the implicit notifications of an observable sequence as explicit notification values.
        /// </summary>
        public Observable Materialize() { return default(Observable); }
        /// <summary>
        /// Returns the maximum value in an observable sequence.
        /// </summary>
        public Observable Max() { return default(Observable); }
        public Observable MaxBy(Func<object, object> keySelector) { return default(Observable); }
        public Observable MaxBy(Func<object, object> keySelector, Func<object, object, int> comparer) { return default(Observable); }
        /// <summary>
        /// Merges all the observable sequences into a single observable sequence.
        /// </summary>
        public static Observable Merge(Observable[] items) { return default(Observable); }
        /// <summary>
        /// Merges all the observable sequences into a single observable sequence.
        /// </summary>
        public static Observable Merge(Observable[] items, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Merges all the observable sequences into a single observable sequence.
        /// </summary>
        public Observable Merge(Observable o1) { return default(Observable); }
        /// <summary>
        /// Merges all the observable sequences into a single observable sequence.
        /// </summary>
        public Observable Merge(Observable o1, Observable o2) { return default(Observable); }
        /// <summary>
        /// Merges all the observable sequences into a single observable sequence.
        /// </summary>
        public Observable Merge(Observable o1, Observable o2, Observable o3) { return default(Observable); }
        /// <summary>
        /// Merges all the observable sequences into a single observable sequence.
        /// </summary>
        public Observable Merge(Observable o1, Observable o2, Observable o3, Observable o4) { return default(Observable); }
        /// <summary>
        /// Merges an observable sequence of observable sequences into an observable sequence.
        /// </summary>
        public Observable MergeObservable() { return default(Observable); }
        /// <summary>
        /// Returns the minimum value in an observable sequence.
        /// </summary>
        public Observable Min() { return default(Observable); }
        public Observable MinBy(Func<object, object> keySelector) { return default(Observable); }
        public Observable MinBy(Func<object, object> keySelector, Func<object, object, int> comparer) { return default(Observable); }
        /// <summary>
        /// Returns a non-terminating observable sequence.
        /// </summary>
        public static Observable Never() { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
        /// </summary>
        public static Observable OnErrorResumeNext(Observable[] items) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
        /// </summary>
        public static Observable OnErrorResumeNext(Observable[] items, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
        /// </summary>
        public Observable OnErrorResumeNext(Observable o1) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
        /// </summary>
        public Observable OnErrorResumeNext(Observable o1, Observable o2) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
        /// </summary>
        public Observable OnErrorResumeNext(Observable o1, Observable o2, Observable o3) { return default(Observable); }
        /// <summary>
        /// Continues an observable sequence that is terminated normally or by an exception with the next observable sequence.
        /// </summary>
        public Observable OnErrorResumeNext(Observable o1, Observable o2, Observable o3, Observable o4) { return default(Observable); }
        /// <summary>
        /// Returns a connectable observable sequence that shares a single subscription to the underlying source containing only the last notification.
        /// </summary>
        public ConnectableObservable Prune() { return default(ConnectableObservable); }
        public Observable Prune(Func<Observable, Observable> selector) { return default(Observable); }
        public Observable Prune(Func<Observable, Observable> selector, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns a connectable observable sequence that shares a single subscription to the underlying source.
        /// </summary>
        public ConnectableObservable Publish() { return default(ConnectableObservable); }
        public Observable Publish(Func<Observable, Observable> selector) { return default(Observable); }
        /// <summary>
        /// Generates an observable sequence of integral numbers within a specified range.
        /// </summary>
        public static Observable Range(int start, int count) { return default(Observable); }
        /// <summary>
        /// Generates an observable sequence of integral numbers within a specified range.
        /// </summary>
        public static Observable Range(int start, int count, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Removes the timestamp from each value of an observable sequence.
        /// </summary>
        public Observable RemoveInterval() { return default(Observable); }
        /// <summary>
        /// Removes the timestamp from each value of an observable sequence.
        /// </summary>
        public Observable RemoveTimestamp() { return default(Observable); }
        /// <summary>
        /// Generates an observable sequence that contains one repeated value.
        /// </summary>
        public static Observable Repeat(object value) { return default(Observable); }
        /// <summary>
        /// Generates an observable sequence that contains one repeated value.
        /// </summary>
        public static Observable Repeat(object value, int count) { return default(Observable); }
        /// <summary>
        /// Generates an observable sequence that contains one repeated value.
        /// </summary>
        public static Observable Repeat(object value, int count, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Repeats the observable sequence indefinitely.
        /// </summary>
        public Observable Repeat() { return default(Observable); }
        /// <summary>
        /// Repeats the observable sequence repeatCount times.
        /// </summary>
        public Observable Repeat(int count) { return default(Observable); }
        /// <summary>
        /// Repeats the observable sequence repeatCount times.
        /// </summary>
        public Observable Repeat(int count, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns a connectable observable sequence that shares a single subscription to the underlying source replaying all notifications.
        /// </summary>
        public ConnectableObservable Replay() { return default(ConnectableObservable); }
        public Observable Replay(Func<Observable, Observable> selector) { return default(Observable); }
        public Observable Replay(Func<Observable, Observable> selector, int bufferSize) { return default(Observable); }
        public Observable Replay(Func<Observable, Observable> selector, int bufferSize, int window) { return default(Observable); }
        public Observable Replay(Func<Observable, Observable> selector, int bufferSize, int window, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Repeats the source observable sequence until it successfully terminates.
        /// </summary>
        public Observable Retry() { return default(Observable); }
        /// <summary>
        /// Repeats the source observable sequence the retryCount times or until it successfully terminates.
        /// </summary>
        public Observable Retry(int count) { return default(Observable); }
        /// <summary>
        /// Repeats the source observable sequence the retryCount times or until it successfully terminates.
        /// </summary>
        public Observable Retry(int count, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains a single value.
        /// </summary>
        public static Observable Return(object value) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that contains a single value.
        /// </summary>
        public static Observable Return(object value, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Samples the observable sequence at each interval.
        /// </summary>
        public Observable Sample(int interval) { return default(Observable); }
        /// <summary>
        /// Samples the observable sequence at each interval.
        /// </summary>
        public Observable Sample(int interval, Scheduler scheduler) { return default(Observable); }
        public Observable Scan(object seed, Func<object, object, object> accumulator) { return default(Observable); }
        public Observable Scan0(object seed, Func<object, object, object> accumulator) { return default(Observable); }
        public Observable Scan1(Func<object, object, object> accumulator) { return default(Observable); }
        public Observable Select(Func<object, object> selector) { return default(Observable); }
        public Observable Select(Func<object, int, object> selector) { return default(Observable); }
        public Observable SelectMany(Func<object, Observable> selector) { return default(Observable); }
        /// <summary>
        /// Bypasses a specified number of values in an observable sequence and then returns the remaining values.
        /// </summary>
        public Observable Skip(int count) { return default(Observable); }
        /// <summary>
        /// Bypasses a specified number of values at the end of an observable sequence.
        /// </summary>
        public static Observable SkipLast(int count) { return default(Observable); }
        /// <summary>
        /// Returns the values from the source observable sequence only after the other observable sequence produces a value.
        /// </summary>
        public Observable SkipUntil(Observable other) { return default(Observable); }
        public Observable SkipWhile(Func<object, bool> predicate) { return default(Observable); }
        public static Observable Start(Func<object, object> original, object instance, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object, Object[], object> original, object instance, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Invokes the action asynchronously, using scheduler to schedule the work.
        /// </summary>
        public static Observable Start(Action original, object instance, Object[] arguments, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object> original, object instance, Object[] arguments, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Action<object> original, object instance, Object[] arguments, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object, object> original, object instance, Object[] arguments, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object, Object[], object> original, object instance, Object[] arguments, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Invokes the action asynchronously.
        /// </summary>
        public static Observable Start(Action original) { return default(Observable); }
        public static Observable Start(Func<object> original) { return default(Observable); }
        public static Observable Start(Action<object> original) { return default(Observable); }
        public static Observable Start(Func<object, object> original) { return default(Observable); }
        public static Observable Start(Func<object, Object[], object> original) { return default(Observable); }
        /// <summary>
        /// Invokes the action asynchronously.
        /// </summary>
        public static Observable Start(Action original, object instance) { return default(Observable); }
        public static Observable Start(Func<object> original, object instance) { return default(Observable); }
        public static Observable Start(Action<object> original, object instance) { return default(Observable); }
        public static Observable Start(Func<object, object> original, object instance) { return default(Observable); }
        public static Observable Start(Func<object, Object[], object> original, object instance) { return default(Observable); }
        /// <summary>
        /// Invokes the action asynchronously.
        /// </summary>
        public static Observable Start(Action original, object instance, Object[] arguments) { return default(Observable); }
        public static Observable Start(Func<object> original, object instance, Object[] arguments) { return default(Observable); }
        public static Observable Start(Action<object> original, object instance, Object[] arguments) { return default(Observable); }
        public static Observable Start(Func<object, object> original, object instance, Object[] arguments) { return default(Observable); }
        public static Observable Start(Func<object, Object[], object> original, object instance, Object[] arguments) { return default(Observable); }
        /// <summary>
        /// Invokes the action asynchronously, using scheduler to schedule the work.
        /// </summary>
        public static Observable Start(Action original, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object> original, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Action<object> original, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object, object> original, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object, Object[], object> original, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Invokes the action asynchronously, using scheduler to schedule the work.
        /// </summary>
        public static Observable Start(Action original, object instance, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Func<object> original, object instance, Scheduler scheduler) { return default(Observable); }
        public static Observable Start(Action<object> original, object instance, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Prepends a value to an observable sequence.
        /// </summary>
        public Observable StartWith(object value, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Prepends a sequence values to an observable sequence.
        /// </summary>
        public Observable StartWith(Object[] values) { return default(Observable); }
        /// <summary>
        /// Prepends a sequence values to an observable sequence.
        /// </summary>
        public Observable StartWith(Object[] values, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Prepends a value to an observable sequence.
        /// </summary>
        public Observable StartWith(object value) { return default(Observable); }
        /// <summary>
        /// Subscribes to the observable sequence for its side-effects.
        /// </summary>
        public IDisposable Subscribe() { return default(IDisposable); }
        /// <summary>
        /// Subscribes an observer to the observable sequence.
        /// </summary>
        public virtual IDisposable Subscribe(IObserver observer) { return default(IDisposable); }
        public IDisposable Subscribe(Action<object> onNext) { return default(IDisposable); }
        public IDisposable Subscribe(Action<object> onNext, Action<object> onError) { return default(IDisposable); }
        public IDisposable Subscribe(Action<object> onNext, Action<object> onError, Action onCompleted) { return default(IDisposable); }
        /// <summary>
        /// Computes the sum of a sequence of numeric values.
        /// </summary>
        public Observable Sum() { return default(Observable); }
        /// <summary>
        /// Transforms an observable sequence of observable sequences into an observable sequence producing values only from the most recent observable sequence.
        /// </summary>
        public Observable Switch() { return default(Observable); }
        /// <summary>
        /// Returns a specified number of contiguous values from the start of an observable sequence.
        /// </summary>
        public Observable Take(int count) { return default(Observable); }
        /// <summary>
        /// Returns a specified number of contiguous values from the start of an observable sequence.
        /// </summary>
        public Observable Take(int count, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns a specified number of contiguous values from the end of an observable sequence.
        /// </summary>
        public static Observable TakeLast(int count) { return default(Observable); }
        /// <summary>
        /// Returns the values from the source observable sequence until the other observable sequence produces a value.
        /// </summary>
        public Observable TakeUntil(Observable other) { return default(Observable); }
        public Observable TakeWhile(Func<object, bool> predicate) { return default(Observable); }
        /// <summary>
        /// Matches when the observable sequence has an available value and projects the value.
        /// </summary>
        public Plan Then(JsFunction selector) { return default(Plan); }
        /// <summary>
        /// Ignores values from an observable sequence which are followed by another value before dueTime.
        /// </summary>
        public Observable Throttle(int dueTime) { return default(Observable); }
        /// <summary>
        /// Ignores values from an observable sequence which are followed by another value before dueTime.
        /// </summary>
        public Observable Throttle(int dueTime, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that terminates with an exception.
        /// </summary>
        public static Observable Throw(object exception) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that terminates with an exception.
        /// </summary>
        public static Observable Throw(object exception, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Records the time interval for each value of an observable sequence.
        /// </summary>
        public Observable TimeInterval() { return default(Observable); }
        /// <summary>
        /// Records the time interval for each value of an observable sequence according to the scheduler's notion of time.
        /// </summary>
        public Observable TimeInterval(Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns observable sequence that ends with a TimeoutException if dueTime elapses.
        /// </summary>
        public Observable Timeout(int dueTime) { return default(Observable); }
        /// <summary>
        /// Returns observable sequence that ends with a TimeoutException if dueTime elapses.
        /// </summary>
        public Observable Timeout(int dueTime, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns the source observable sequence until completed or if dueTime elapses replaces the observable sequence with other.
        /// </summary>
        public Observable Timeout(int dueTime, Observable other) { return default(Observable); }
        /// <summary>
        /// Returns the source observable sequence until completed or if dueTime elapses replaces the observable sequence with other.
        /// </summary>
        public Observable Timeout(int dueTime, Observable other, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that produces a value at dueTime.
        /// </summary>
        public static Observable Timer(int dueTime) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that produces a value after dueTime has elapsed and then after each period.
        /// </summary>
        public static Observable Timer(int dueTime, int period) { return default(Observable); }
        /// <summary>
        /// Returns an observable sequence that produces a value after dueTime has elapsed and then after each period.
        /// </summary>
        public static Observable Timer(int dueTime, int period, Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Records the timestamp for each value of an observable sequence.
        /// </summary>
        public Observable Timestamp() { return default(Observable); }
        /// <summary>
        /// Records the timestamp for each value of an observable sequence according to the scheduler's notion of time.
        /// </summary>
        public Observable Timestamp(Scheduler scheduler) { return default(Observable); }
        /// <summary>
        /// Converts the action into an asynchronous function.
        /// </summary>
        public static Func<Observable> ToAsync(Action original) { return default(Func<Observable>); }
        public static Func<Observable> ToAsync(Func<object> original) { return default(Func<Observable>); }
        public static Func<object, Observable> ToAsync(Action<object> original) { return default(Func<object, Observable>); }
        public static Func<object, Observable> ToAsync(Func<object, object> original) { return default(Func<object, Observable>); }
        public static Func<object, Object[], Observable> ToAsync(Func<object, Object[], object> original) { return default(Func<object, Object[], Observable>); }
        /// <summary>
        /// Converts the action into an asynchronous function, using scheduler to schedule the work.
        /// </summary>
        public static Func<Observable> ToAsync(Action original, Scheduler scheduler) { return default(Func<Observable>); }
        public static Func<Observable> ToAsync(Func<object> original, Scheduler scheduler) { return default(Func<Observable>); }
        public static Func<object, Observable> ToAsync(Action<object> original, Scheduler scheduler) { return default(Func<object, Observable>); }
        public static Func<object, Observable> ToAsync(Func<object, object> original, Scheduler scheduler) { return default(Func<object, Observable>); }
        public static Func<object, Object[], Observable> ToAsync(Func<object, Object[], object> original, Scheduler scheduler) { return default(Func<object, Object[], Observable>); }
        public static Observable Using(Func<IDisposable> resourceSelector, Func<IDisposable, Observable> resourceUsage) { return default(Observable); }
        public Observable Where(Func<object, bool> selector) { return default(Observable); }
        public Observable Where(Func<object, int, bool> selector) { return default(Observable); }
        public static Observable While(Func<bool> condition, Observable source) { return default(Observable); }
        /// <summary>
        /// Starts an asynchronous XmlHttpRequest.
        /// </summary>
        public static Observable XmlHttpRequest(XmlHttpRequestDetails details) { return default(Observable); }
        /// <summary>
        /// Starts an asynchronous XmlHttpRequest.
        /// </summary>
        public static Observable XmlHttpRequest(string url) { return default(Observable); }
        public Observable Zip(Observable right, Func<object, object, object> selector) { return default(Observable); }
    }
    #endregion
    #region Observer Class
    /// <summary>
    /// Supports push-style iteration over an observable sequence.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Observer")]
    public class Observer : IObserver
    {
        public Observer(Action<object> onNext) { }
        public Observer(Action<object> onNext, Action<object> onError) { }
        public Observer(Action<object> onNext, Action<object> onError, Action onCompleted) { }
        /// <summary>
        /// Hides the identity of an observer.
        /// </summary>
        public Observer AsObserver() { return default(Observer); }
        public static Observer Create(Action<object> onNext) { return default(Observer); }
        public static Observer Create(Action<object> onNext, Action<object> onError) { return default(Observer); }
        public static Observer Create(Action<object> onNext, Action<object> onError, Action onCompleted) { return default(Observer); }
        /// <summary>
        /// Notifies the observer of the end of the sequence.
        /// </summary>
        public virtual void OnCompleted() { }
        /// <summary>
        /// Notifies the observer that an exception has occurred.
        /// </summary>
        public virtual void OnError(object value) { }
        /// <summary>
        /// Notifies the observer of a new value in the sequence.
        /// </summary>
        public virtual void OnNext(object value) { }
    }
    #endregion
    #region Pattern Class
    /// <summary>
    /// Represents a join pattern.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Pattern")]
    public class Pattern
    {
        private Pattern() { }
        /// <summary>
        /// Matches when all observable sequences have an available value.
        /// </summary>
        public Pattern And(Observable other) { return default(Pattern); }
        /// <summary>
        /// Matches when all observable sequences have an available value and projects the values.
        /// </summary>
        public Plan Then(JsFunction selector) { return default(Plan); }
    }
    #endregion
    #region Plan Class
    /// <summary>
    /// Represents an execution plan for join patterns.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Plan")]
    public class Plan
    {
        private Plan() { }
    }
    #endregion
    #region RefCountDisposable Class
    /// <summary>
    /// Represents a disposable that only disposes its underlying disposable when all dependent disposables have been disposed.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.RefCountDisposable")]
    public class RefCountDisposable : IDisposable
    {
        /// <summary>
        /// Creates a disposable that only disposes its underlying disposable when all dependent disposables have been disposed.
        /// </summary>
        public RefCountDisposable() { }
        /// <summary>
        /// Disposes the underlying disposable only when all dependent disposables have been disposed.
        /// </summary>
        public virtual void Dispose() { }
        public IDisposable GetDisposable() { return default(IDisposable); }
    }
    #endregion
    #region ReplaySubject Class
    /// <summary>
    /// Represents an object that is both an observable sequence as well as an observer.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.ReplaySubject")]
    public class ReplaySubject : Observable, IObservable, ISubject, IObserver
    {
        /// <summary>
        /// Creates a replayable subject.
        /// </summary>
        public ReplaySubject(int bufferSize, int window, Scheduler scheduler) { }
        /// <summary>
        /// Creates a replayable subject.
        /// </summary>
        public ReplaySubject(int bufferSize, int window) { }
        /// <summary>
        /// Notifies the observer of the end of the sequence.
        /// </summary>
        public virtual void OnCompleted() { }
        /// <summary>
        /// Notifies the observer that an exception has occurred.
        /// </summary>
        public virtual void OnError(object exception) { }
        /// <summary>
        /// Notifies the observer of a new value in the sequence.
        /// </summary>
        public virtual void OnNext(object value) { }
    }
    #endregion
    #region Scheduler Class
    /// <summary>
    /// Represents an object that schedules units of work.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Scheduler")]
    public class Scheduler
    {
        public Scheduler(Action schedule, Action<int> scheduleWithTime) { }
        /// <summary>
        /// Gets the scheduler that schedules work as soon as possible on the current thread.
        /// </summary>
        public Scheduler CurrentThread { get; set; }
        /// <summary>
        /// Gets the scheduler that schedules work immediately on the current thread.
        /// </summary>
        public Scheduler Immediate { get; set; }
        /// <summary>
        /// Gets the scheduler's notion of current time.
        /// </summary>
        public double Now() { return default(double); }
        /// <summary>
        /// Schedules action to be executed.
        /// </summary>
        public static IDisposable Schedule(Action action) { return default(IDisposable); }
        public static IDisposable ScheduleRecursive(Action<Action> action) { return default(IDisposable); }
        public static IDisposable ScheduleRecursiveWithTime(Action<Action<int>> action, int dueTime) { return default(IDisposable); }
        /// <summary>
        /// Schedules action to be executed after dueTime.
        /// </summary>
        public static IDisposable ScheduleWithTime(Action action, int dueTime) { return default(IDisposable); }
        /// <summary>
        /// Gets the scheduler that schedules work using window.setTimeout.
        /// </summary>
        public Scheduler Timeout { get; set; }
    }
    #endregion
    #region Subject Class
    /// <summary>
    /// Represents an object that is both an observable sequence as well as an observer.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.Subject")]
    public class Subject : Observable, IObservable, ISubject, IObserver
    {
        /// <summary>
        /// Creates a subject.
        /// </summary>
        public Subject(Scheduler scheduler) { }
        /// <summary>
        /// Creates a subject.
        /// </summary>
        public Subject() { }
        /// <summary>
        /// Notifies all subscribed observers of the end of the sequence.
        /// </summary>
        public virtual void OnCompleted() { }
        /// <summary>
        /// Notifies all subscribed observers with the exception.
        /// </summary>
        public virtual void OnError(object exception) { }
        /// <summary>
        /// Notifies all subscribed observers with the value.
        /// </summary>
        public virtual void OnNext(object value) { }
    }
    #endregion
    #region XmlHttpRequestDetails Class
    /// <summary>
    /// Represents required and optional arguments passed into Observable.XmlHttpRequest.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "Rx.XmlHttpRequestDetails")]
    public class XmlHttpRequestDetails
    {
        /// <summary>
        /// Creates a new XmlHttpRequestDetails object.
        /// </summary>
        public XmlHttpRequestDetails() { }
        /// <summary>
        /// Adds custom HTTP headers to the request.
        /// </summary>
        public JsObject Headers { get; set; }
        /// <summary>
        /// Required. String that specifies the HTTP method used to open the connection: such as GET, POST, or HEAD. This parameter is not case-sensitive.
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// Optional. String that specifies the password for authentication. This parameter is ignored if the user parameter is null ("") or missing.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Required. String that specifies either the absolute or a relative URL of the XML data or server-side XML Web services.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Optional. String that specifies the name of the user for authentication. If this parameter is null ("") or missing and the site requires authentication, the component displays a logon window
        /// </summary>
        public string User { get; set; }
    }
    #endregion
}
