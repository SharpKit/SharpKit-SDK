using SharpKit.Html;
using SharpKit.JavaScript;

namespace SharpKit.KnockoutJs
{
    /// <summary>
    /// Represent a token to unsubscribe from observable subscription
    /// </summary>
    [JsType(JsMode.Prototype, Export = false)]
    public interface IDisposable
    {
        /// <summary>
        /// Unsubscribe from observable subscription.
        /// </summary>
        void dispose();
    }
    /// <summary>
    /// Represents a custom binding handler in Knockout.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public abstract class BindingHandler
    {
        /// <summary>
        /// Performs one time initialization for a binding.
        /// </summary>
        /// <param name="element">The element involved in this binding.</param>
        /// <param name="valueAccessor">A function which returns the model property that is involved in this binding.</param>
        /// <param name="allBindingsAccessor">A function which returns all the model properties bound to this element.</param>
        /// <param name="viewModel">The view model instance involved in this binding.</param>
        public virtual void init(HtmlElement element, JsFunc<object> valueAccessor, JsFunc<JsObject> allBindingsAccessor, object viewModel)
        {
        }
        /// <summary>
        /// Invoked whenever an observable associated with this binding changes.
        /// </summary>
        /// <param name="element">The element involved in this binding.</param>
        /// <param name="valueAccessor">A function which returns the model property that is involved in this binding.</param>
        /// <param name="allBindingsAccessor">A function which returns all the model properties bound to this element.</param>
        /// <param name="viewModel">The view model instance involved in this binding.</param>
        public virtual void update(HtmlElement element, JsFunc<object> valueAccessor, JsFunc<JsObject> allBindingsAccessor, object viewModel)
        {
        }
    }
    /// <summary>
    /// Represents an object containing a value dependent on other observable values.
    /// </summary>
    /// <typeparam name="T">The type of the contained value.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DependentObservable<T>: Observable<T>
    {
        /// <summary>
        /// Protected constructor.
        /// </summary>
        protected DependentObservable()
        {
        }

        /// <summary>
        /// Gets count of dependencies
        /// </summary>
        public int DependeciesCount
        {
            [JsMethod(Name = "getDependenciesCount")]
            get { return default(int); }
        }
    }

    /// <summary>
    /// Provides advanced options for defining a dependent observable.
    /// </summary>
    /// <typeparam name="T">The type of the observable value.</typeparam>
    [JsType(JsMode.Json, Export=false)]
    public partial class DependentObservableOptions<T>
    {
        /// <summary>
        /// Gets or sets whether the evaluation should be deferred, i.e. not
        /// performed when the observable is first created.
        /// </summary>
        public bool deferEvaluation
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the function to compute the value.
        /// </summary>
        public JsFunc<T> read
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the function to accept the new value.
        /// </summary>
        public JsAction<T> write
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the model instance which acts as 'this' in the get value function.
        /// </summary>
        public object owner
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Provides Knockout functionality.
    /// </summary>
    [JsType(JsMode.Prototype, Name="ko")]
    public static class Knockout
    {
        /// <summary>
        /// Converts a model into the equivalent JSON representation.
        /// </summary>
        /// <param name="model">The model object to convert.</param>
        /// <returns>The JSON JsString representing the model data.</returns>
        public static JsString toJSON(object model)
        {
            return null;
        }
        /// <summary>
        /// Converts a model into the equivalent vanilla script object.
        /// </summary>
        /// <param name="model">The model object to convert.</param>
        /// <returns>The vanilla script object representing the model data.</returns>
        public static object toJS(object model)
        {
            return null;
        }

        /// <summary>
        /// Provides access to the currently registered binding handlers.
        /// </summary>
        public static JsObject<JsString, BindingHandler> bindingHandlers{get;private set;}
        /// <summary>
        /// Gets the mapping plugin which allows converting models to plain
        /// objects and JSON and vice-versa.
        /// </summary>
        public static KnockoutMapping mapping{get;private set;}

        /// <summary>
        /// Provide access to 'this'.
        /// </summary>
        public static object @this
        {
            get
            {
                return null;
            }
        }
        /// <summary>
        /// Sets up bindings using the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void applyBindings(object model)
        {
        }
        /// <summary>
        /// Sets up bindings within the specified root element using the specified the model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="rootElement">The element to bind to.</param>
        public static void applyBindings(object model, HtmlElement rootElement)
        {
        }
        /// <summary>
        /// Set up bindings on a single node without binding any of its descendents.
        /// </summary>
        /// <param name="node">The node to bind to.</param>
        /// <param name="bindings">An optional dictionary of bindings, pass null to let Knockout gather them from the element.</param>
        /// <param name="viewModel">The view model instance.</param>
        public static void applyBindingsToNode(HtmlElement node, JsObject bindings, object viewModel)
        {
        }
        /// <summary>
        /// Set up bindings on a single node without binding any of its descendents.
        /// </summary>
        /// <param name="node">The node to bind to.</param>
        /// <param name="bindings">An optional dictionary of bindings, pass null to let Knockout gather them from the element.</param>
        /// <param name="viewModel">The view model instance.</param>
        /// <param name="bindingAttributeName">The name of the attribute which has the binding definitions.</param>
        public static void applyBindingsToNode(HtmlElement node, JsObject bindings, object viewModel, JsString bindingAttributeName)
        {
        }
        /// <summary>
        /// Creates an observable with a value computed from one or more other values.
        /// </summary>
        /// <typeparam name="T">The type of the observable value.</typeparam>
        /// <param name="func">A function to compute the value.</param>
        /// <returns>A new dependent observable instance.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static DependentObservable<T> dependentObservable<T>(JsFunc<T> func)
        {
            return null;
        }
        /// <summary>
        /// Creates an observable with a value computed from one or more other values.
        /// </summary>
        /// <typeparam name="T">The type of the observable value.</typeparam>
        /// <param name="options">Options for the dependent observable.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static DependentObservable<T> dependentObservable<T>(DependentObservableOptions<T> options)
        {
            return null;
        }
        /// <summary>
        /// Creates an observable with a value computed from one or more other values.
        /// </summary>
        /// <typeparam name="T">The type of the observable value.</typeparam>
        /// <param name="func">A function to compute the value.</param>
        /// <returns>A new dependent observable instance.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static DependentObservable<T> computed<T>(JsFunc<T> func)
        {
            return null;
        }
        /// <summary>
        /// Creates an observable with a value computed from one or more other values.
        /// </summary>
        /// <typeparam name="T">The type of the observable value.</typeparam>
        /// <param name="options">Options for the dependent observable.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static DependentObservable<T> computed<T>(DependentObservableOptions<T> options)
        {
            return null;
        }
        /// <summary>
        /// Returns true if the value is an observable, false otherwise.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool isObservable(object value)
        {
            return false;
        }
        /// <summary>
        /// Returns true if the value is an writable observable, false otherwise.
        /// </summary>
        /// <param name="value">The value to check.</param>
        public static bool isWriteableObservable(object value)
        {
            return false;
        }
        /// <summary>
        /// Returns true if the value is an writable observable, false otherwise.
        /// </summary>
        /// <param name="value">The value to check.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true)]
        public static bool isWriteableObservable<T>(this Observable<T> value)
        {
            return false;
        }
        /// <summary>
        /// Creates an observable value.
        /// </summary>
        /// <typeparam name="T">The type of the observable.</typeparam>
        /// <returns>A new observable value instance.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static Observable<T> observable<T>()
        {
            return null;
        }
        /// <summary>
        /// Creates an observable with an initial value.
        /// </summary>
        /// <typeparam name="T">The type of the observable.</typeparam>
        /// <param name="initialValue">The initial value.</param>
        /// <returns>A new observable value instance.</returns>
        [JsMethod(IgnoreGenericArguments=true, NativeOverloads=true, NativeDelegates=true)]
        public static Observable<T> observable<T>(T initialValue)
        {
            return null;
        }
        /// <summary>
        /// Creates an empty observable array.
        /// </summary>
        /// <returns>A new observable array.</returns>
        /// <typeparam name="T">The type of items in the array.</typeparam>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static ObservableArray<T> observableArray<T>()
        {
            return null;
        }
        /// <summary>
        /// Creates an observable array with some initial items.
        /// </summary>
        /// <param name="initialItems">A sequence of initial items.</param>
        /// <returns>A new observable array.</returns>
        /// <typeparam name="T">The type of items in the array.</typeparam>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static ObservableArray<T> observableArray<T>(JsArray<T> initialItems)
        {
            return null;
        }

        /// <summary>
        /// Provide access to utilities methods of the KnockoutJS
        /// </summary>
        public static KnockoutUtils utils { get; private set; }
        
        /// <summary>
        /// Delegate for use as an observable extender
        /// </summary>
        /// <param name="target">Target observable to extend.</param>
        /// <param name="options">Options of the extender.</param>
        /// <returns>Extended observable.</returns>
        public delegate Observable<object> ExtenderHandler(Observable<object> target, object options);

        /// <summary>
        /// Provide access to extenders of observables.
        /// </summary>
        public static JsObject<JsString, ExtenderHandler> extenders { get; private set; }

        /// <summary>
        /// Extends the observable with the extenders.
        /// </summary>
        /// <typeparam name="TObservable">Type of the observable.</typeparam>
        /// <param name="observable">Observable instance to extend.</param>
        /// <param name="extenders">Object with the extenders.</param>
        /// <returns>Extended observable instance.</returns>
        [JsMethod(IgnoreGenericArguments = true, ExtensionImplementedInInstance = true)]
        public static TObservable extend<TObservable>(this TObservable observable, object extenders) where TObservable: IObservable
        {
            return default(TObservable);
        }
    }
    /// <summary>
    /// Provide access to utilities methods of the KnockoutJS
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "ko.utils")]
    public partial class KnockoutUtils
    {
        /// <summary>
        /// If the provided value is an observable, return its value, otherwise just pass it through.
        /// </summary>
        /// <param name="value">The value to unwrap.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static T unwrapObservable<T>(object value)
        {
            return default(T);
        }

        /// <summary>
        /// Iterates and invokes the <paramref name="action"/> over each item in <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Array for iteration.</param>
        /// <param name="action">Action to invoke on each item.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static void arrayForEach(JsArray array, JsAction<object> action) { }
        /// <summary>
        /// Iterates and invokes the <paramref name="action"/> over each item in <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Array for iteration.</param>
        /// <param name="action">Action to invoke on each item.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static void arrayForEach<T>(JsArray<T> array, JsAction<T> action) { }
        
        /// <summary>
        /// Finds index of the <paramref name="item"/> in the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Array to find in.</param>
        /// <param name="item">Item to find.</param>
        /// <returns>Zero-based index of the item in array; -1 if item was not finded.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static int arrayIndexOf(JsArray array, object item) { return default(int); }
        /// <summary>
        /// Finds index of the <paramref name="item"/> in the <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Array to find in.</param>
        /// <param name="item">Item to find.</param>
        /// <returns>Zero-based index of the item in array; -1 if item was not finded.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static int arrayIndexOf<T>(JsArray<T> array, T item) { return default(int); }

        /// <summary>
        /// Finds first element in the <paramref name="array"/> that matches the <paramref name="predicate"/>.
        /// </summary>
        /// <param name="array">Array to find in.</param>
        /// <param name="predicate">Predicate to match; called in context of <paramref name="predicateOwner"/></param>
        /// <param name="predicateOwner">Context for invoke the <paramref name="predicate"/>.</param>
        /// <returns>First matched element or null overwise.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true, OmitOptionalParameters = true)]
        public static object arrayFirst(JsArray array, JsFunc<object, bool> predicate, object predicateOwner = null) { return null; }
        /// <summary>
        /// Finds first element in the <paramref name="array"/> that matches the <paramref name="predicate"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Array to find in.</param>
        /// <param name="predicate">Predicate to match; called in context of <paramref name="predicateOwner"/></param>
        /// <param name="predicateOwner">Context for invoke the <paramref name="predicate"/>.</param>
        /// <returns>First matched element or null overwise.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static T arrayFirst<T>(JsArray<T> array, JsFunc<T, bool> predicate, object predicateOwner = null) { return default(T); }

        /// <summary>
        /// Removes the <paramref name="itemToRemove"/> from the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Array to remove item from.</param>
        /// <param name="itemToRemove">Item to remove.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static void arrayRemoveItem(JsArray array, object itemToRemove) { }
        /// <summary>
        /// Removes the <paramref name="itemToRemove"/> from the <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Array to remove item from.</param>
        /// <param name="itemToRemove">Item to remove.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static void arrayRemoveItem<T>(JsArray<T> array, T itemToRemove) { }

        /// <summary>
        /// Create a new array with distinct values of the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Array to filter duplicates.</param>
        /// <returns>New array with distinct values.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray arrayGetDistinctValues(JsArray array) { return null; }
        /// <summary>
        /// Create a new array with distinct values of the <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Array to filter duplicates.</param>
        /// <returns>New array with distinct values.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray<T> arrayGetDistinctValues<T>(JsArray<T> array) { return null; }

        /// <summary>
        /// Maps each value of the <paramref name="array"/> to new value of new array using <paramref name="mapping"/> function.
        /// </summary>
        /// <param name="array">Source array to map from.</param>
        /// <param name="mapping">Mapping function; it takes the source item value and returns new mapped value.</param>
        /// <returns>New array with mapped values</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray arrayMap(JsArray array, JsFunc<object, object> mapping) { return null; }
        /// <summary>
        /// Maps each value of the <paramref name="array"/> to new value of new array using <paramref name="mapping"/> function.
        /// </summary>
        /// <typeparam name="T">Type of the source array item.</typeparam>
        /// <typeparam name="R">Type of the result array item.</typeparam>
        /// <param name="array">Source array to map from.</param>
        /// <param name="mapping">Mapping function; it takes the source item value and returns new mapped value.</param>
        /// <returns>New array with mapped values</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray<R> arrayMap<T, R>(JsArray<T> array, JsFunc<T, R> mapping) { return null; }

        /// <summary>
        /// Filters values from the <paramref name="array"/> using <paramref name="predicate"/>.
        /// </summary>
        /// <param name="array">Source array to filter.</param>
        /// <param name="predicate">Predicate function.</param>
        /// <returns>New array with matched values.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray arrayFilter(JsArray array, JsFunc<object, bool> predicate) { return null; }
        /// <summary>
        /// Filters values from the <paramref name="array"/> using <paramref name="predicate"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Source array to filter.</param>
        /// <param name="predicate">Predicate function.</param>
        /// <returns>New array with matched values.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray<T> arrayFilter<T>(JsArray<T> array, JsFunc<T, bool> predicate) { return null; }

        /// <summary>
        /// Pushes values from the <paramref name="valuesToPush"/> to the <paramref name="array"/>.
        /// </summary>
        /// <param name="array">Array to push in.</param>
        /// <param name="valuesToPush">Array of elements to push.</param>
        /// <returns>The source array with pushed values.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray arrayPushAll(JsArray array, JsArray valuesToPush) { return null; }
        /// <summary>
        /// Pushes values from the <paramref name="valuesToPush"/> to the <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">Type of the array element.</typeparam>
        /// <param name="array">Array to push in.</param>
        /// <param name="valuesToPush">Array of elements to push.</param>
        /// <returns>The source array with pushed values.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static JsArray<T> arrayPushAll<T>(JsArray<T> array, JsArray<T> valuesToPush) { return null; }

        /// <summary>
        /// Extends the <paramref name="target"/> object with properties from <paramref name="source"/> object.
        /// </summary>
        /// <typeparam name="TObject">Type of the target object.</typeparam>
        /// <param name="target">Object to extend.</param>
        /// <param name="source">Object to extend with.</param>
        /// <returns>Extended target object.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static TObject extend<TObject>(TObject target, object source) { return default(TObject); }

        /// <summary>
        /// Parses the <paramref name="jsonString"/> string as JSON-encoded format.
        /// </summary>
        /// <param name="jsonString">Source string to parse.</param>
        /// <returns>Parsed object.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static object parseJson(JsString jsonString) { return null; }
        /// <summary>
        /// Parses the <paramref name="jsonString"/> string as JSON-encoded format.
        /// </summary>
        /// <typeparam name="T">Type of result object.</typeparam>
        /// <param name="jsonString">Source string to parse.</param>
        /// <returns>Parsed object.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public static T parseJson<T>(JsString jsonString) { return default(T); }

        /// <summary>
        /// Convert the <paramref name="data"/> object to JSON-encoded string.
        /// </summary>
        /// <param name="data">Object to encode.</param>
        /// <returns>JSON-encoded string.</returns>
        public static JsString stringifyJson(object data) { return null; }
    }
    /// <summary>
    /// Provides functionality for mapping between knockout models and JSON or
    /// vanilla script objects.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public sealed class KnockoutMapping
    {
        private KnockoutMapping()
        {
        }
        /// <summary>
        /// Creates a model instance from the specified JSON JsString.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="jsonData">The JSON data.</param>
        /// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJSON<TModel>(JsString jsonData)
        {
            return default(TModel);
        }
        /// <summary>
        /// Creates a model instance from the specified JSON JsString and a
        /// custom mapping.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="jsonData">The JSON data.</param>
        /// <param name="mapping">The mapping rules to apply.</param>
        /// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJSON<TModel>(JsString jsonData, object mapping)
        {
            return default(TModel);
        }
        /// <summary>
        /// Creates a model instance from the specified script object.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="data">The vanilla script object.</param>
        /// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJS<TModel>(object data)
        {
            return default(TModel);
        }
        /// <summary>
        /// Creates a model instance from the specified script object and a
        /// custom mapping.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="data">The vanilla script object.</param>
        /// <param name="mapping">The mapping rules to apply.</param>
        /// <returns>A new instance of the model.</returns>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public TModel fromJS<TModel>(object data, object mapping)
        {
            return default(TModel);
        }
        /// <summary>
        /// Updates the specified model with the specified JSON JsString.
        /// </summary>
        /// <typeparam name="TModel">The tyoe of the model.</typeparam>
        /// <param name="model">The model to update.</param>
        /// <param name="jsonData">The JSON JsString representing the new values.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public void updateFromJSON<TModel>(TModel model, JsString jsonData)
        {
        }
        /// <summary>
        /// Updates the specified model with the specified script object.
        /// </summary>
        /// <typeparam name="TModel">The tyoe of the model.</typeparam>
        /// <param name="model">The model to update.</param>
        /// <param name="data">The script object representing the new values.</param>
        [JsMethod(IgnoreGenericArguments = true, NativeOverloads = true, NativeDelegates = true)]
        public void updateFromJS<TModel>(TModel model, object data)
        {
        }
    }

    /// <summary>
    /// Marker interface for observables.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false)]
    public interface IObservable
    {
    }

    /// <summary>
    /// Represents an object containing an observable value.
    /// </summary>
    /// <typeparam name="T">The type of the contained value.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Observable<T> : IObservable
    {
        /// <summary>
        /// Protected constructor.
        /// </summary>
        protected Observable()
        {
        }
        /// <summary>
        /// Gets or sets the current value within the observable object.
        /// </summary>
        public T Value 
        {
            [JsMethod(Name="")]
            get { return default(T); }
            [JsMethod(Name = "")]
            set { }
        }
        ///// <summary>
        ///// Gets the current value within the observable object.
        ///// </summary>
        ///// <returns>The current value.</returns>
        //[JsMethod(Name="")]
        //public T GetValue()
        //{
        //  return default(T);
        //}
        ///// <summary>
        ///// Sets the value within the observable object.
        ///// </summary>
        ///// <param name="value">The new value.</param>
        //[JsMethod(Name="")]
        //public void SetValue(T value)
        //{
        //}
        /// <summary>
        /// Subscribes to change notifications raised when the value changes.
        /// </summary>
        /// <param name="changeCallback">The callback to invoke.</param>
        /// <returns>A subscription cookie that can be disposed to unsubscribe.</returns>
        public IDisposable subscribe(JsAction<T> changeCallback)
        {
            return null;
        }
        /// <summary>
        /// Gets subscriptions count of the observable.
        /// </summary>
        public int SubscriptionsCount
        {
            [JsMethod(Name = "getSubscriptionsCount")]
            get { return default(int); }
        }
    }
    /// <summary>
    /// Represents an array of items that can be observed for changes to the set of
    /// contained items.
    /// </summary>
    /// <typeparam name="T">The type of the contained values.</typeparam>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ObservableArray<T> : Observable<JsArray<T>>
    {
        /// <summary>
        /// Protected constructor.
        /// </summary>
        protected ObservableArray()
        {
        }
        /// <summary>
        /// Marks all values that match the given parameter as deleted.
        /// </summary>
        /// <param name="value">The value to mark as deleted.</param>
        public void destroy(T value)
        {
        }
        /// <summary>
        /// Marks all values that satisfy the predicate as deleted.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        public void destroy(JsFunc<T, bool> predicate)
        {
        }
        /// <summary>
        /// Marks all values that satisfy the given parameters as deleted.
        /// </summary>
        /// <param name="values">An array of items to destroy.</param>
        public void destroyAll(params T[] values)
        {
        }

        ///// <summary>
        ///// Gets the underlying items within the observable array.
        ///// </summary>
        ///// <returns>The collection of items.</returns>
        //[JsMethod(Name="")]
        //public JsArray<T> GetItems()
        //{
        //  return null;
        //}
        /// <summary>
        /// Returns the index of the first array item that equals the value.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>The index of the matching item; -1 if there is no match.</returns>
        public JsNumber indexOf(T value)
        {
            return 0;
        }
        /// <summary>
        /// Removes the last value from the array and returns it.
        /// </summary>
        /// <returns>The last value.</returns>
        public T pop()
        {
            return default(T);
        }
        /// <summary>
        /// Adds the value and notifies observers.
        /// </summary>
        /// <param name="value">The value to add.</param>
        public void push(T value)
        {
        }
        /// <summary>
        /// Removes all values that match the given parameter and returns them.
        /// </summary>
        /// <param name="value">The value to remove.</param>
        /// <returns>The removed values.</returns>
        public T[] remove(T value)
        {
            return null;
        }
        /// <summary>
        /// Removes all values that satisfy the predicate and returns them.
        /// </summary>
        /// <param name="predicate">The removal predicate.</param>
        /// <returns>The removed values.</returns>
        public T[] remove(JsFunc<T, bool> predicate)
        {
            return null;
        }
        /// <summary>
        /// Removes all values that satisfy the given parameters and returns them.
        /// </summary>
        /// <param name="values">An array of items to remove.</param>
        /// <returns>The removed values.</returns>
        public T[] removeAll(params T[] values)
        {
            return null;
        }
        /// <summary>
        /// Reverses the order of the array.
        /// </summary>
        public void reverse()
        {
        }
        /// <summary>
        /// Removes the first value from the array and returns it
        /// </summary>
        /// <returns>The removed value.</returns>
        public T shift()
        {
            return default(T);
        }
        /// <summary>
        /// Returns elements from start index to the end of the array.
        /// </summary>
        /// <param name="start">Starting point of the sequence, if negative then it starts from the end.</param>
        /// <returns>The matched items.</returns>
        public T[] slice(int start)
        {
            return null;
        }
        /// <summary>
        /// Returns elements from start index to end index.
        /// </summary>
        /// <param name="start">Starting point of the sequence, if negative then it starts from the end.</param>
        /// <param name="end">End point of the sequence.</param>
        /// <returns>The matched items.</returns>
        public T[] slice(int start, int end)
        {
            return null;
        }
        /// <summary>
        /// Performs a default alphanumeric sort on the elements of the array.
        /// </summary>
        public void sort()
        {
        }
        /// <summary>
        /// Performs a sort using the comparator function.
        /// </summary>
        /// <param name="comparator">The comparing function.</param>
        public void sort(JsFunc<T, T, int> comparator)
        {
        }
        /// <summary>
        /// Inserts the value at the beginning of the array.
        /// </summary>
        /// <param name="value">The value to insert.</param>
        public void unshift(T value)
        {
        }
    }
}
