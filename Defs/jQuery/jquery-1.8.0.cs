using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
using SharpKit.Html;
namespace SharpKit.jQuery
{
    #region jQuery
    [JsType(JsMode.Prototype, Export = false, Name = "$", NativeArrayEnumerator = true, NativeEnumerator = false)]
    public partial class jQuery : IJsArrayEnumerable<HtmlElement>
    {
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(object obj) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(HtmlElement element) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsArray elementArray) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(jQuery jQuery_object) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery() { }
        /// <summary>
        /// Creates DOM elements on the fly from the provided string of raw HTML.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsString html, HtmlDocument ownerDocument) { }
        /// <summary>
        /// Creates DOM elements on the fly from the provided string of raw HTML.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsString html, object props) { }
        /// <summary>
        /// Binds a function to be executed when the DOM has finished loading.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsAction callback) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsString selector, HtmlElement context) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsString selector, jQuery context) { }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public jQuery(JsString selector) { }

        /// <summary>
        /// Creates a jQuery element by tagName
        /// </summary>
        [JsMethod(Name = "$", Global = true, ArgumentsPrefix = "document.createElement(", ArgumentsSuffix = ")")]
        public static jQuery createElement(string tagName) { return null; }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        public jQuery add<T>() where T : HtmlElement { return null; }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        public jQuery add(JsString selector) { return null; }
        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        public jQuery add(JsArray<HtmlElement> elements) { return null; }
        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        public jQuery add(params HtmlElement[] elements) { return null; }
        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        public jQuery add(string html) { return null; }
        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        /// <param name="jqueryObject">An existing jQuery object to add to the set of matched elements.</param>
        /// <returns></returns>
        public jQuery add(jQuery jqueryObject) { return null; }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        public jQuery add(JsString selector, HtmlElement context) { return null; }
        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        public jQuery addClass(JsString className) { return null; }
        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        public jQuery addClass(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        /// </summary>
        public jQuery after(JsAction<Event> function) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        /// </summary>
        public jQuery after(JsString content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        /// </summary>
        public jQuery after(HtmlElement content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        /// </summary>
        public jQuery after(jQuery content) { return null; }
        /// <summary>
        /// Register a handler to be called when Ajax requests complete. This is an Ajax Event.
        /// </summary>
        public jQuery ajaxComplete(JsAction<object, string, jqXHR> handler) { return null; }
        /// <summary>
        /// Register a handler to be called when Ajax requests complete with an error. This is an Ajax Event.
        /// </summary>
        public jQuery ajaxError(JsAction<Event, jqXHR, object, JsError> handler) { return null; }
        /// <summary>
        /// Attach a function to be executed before an Ajax request is sent. This is an Ajax Event.
        /// </summary>
        public jQuery ajaxSend(JsAction<object, string, jqXHR> handler) { return null; }
        /// <summary>
        /// Register a handler to be called when the first Ajax request begins. This is an Ajax Event.
        /// </summary>
        public jQuery ajaxStart(JsAction handler__) { return null; }
        /// <summary>
        /// Register a handler to be called when all Ajax requests have completed. This is an Ajax Event.
        /// </summary>
        public jQuery ajaxStop(JsAction handler__) { return null; }
        /// <summary>
        /// Attach a function to be executed whenever an Ajax request completes successfully. This is an Ajax Event.
        /// </summary>
        public jQuery ajaxSuccess(JsAction<object, string, jqXHR> handler) { return null; }
        /// <summary>
        /// Handle custom Ajax options or modify existing options before each request is sent and before they are processed by $.ajax().
        /// </summary>
        /// <param name="handler">
        /// handler(options, originalOptions, jqXHR)A handler to set default values for future Ajax requests.
        /// </param>
        public static void ajaxPrefilter(JsAction<object, object, object> handler)
        {
        }
        /// <summary>
        /// Handle custom Ajax options or modify existing options before each request is sent and before they are processed by $.ajax().
        /// </summary>
        /// <param name="dataTypes">
        /// dataTypesAn optional string containing one or more space-separated dataTypes
        /// </param>
        /// <param name="handler">
        /// handler(options, originalOptions, jqXHR)A handler to set default values for future Ajax requests.
        /// </param>
        public static void ajaxPrefilter(JsString dataTypes, JsAction<object, object, object> handler)
        {
        }

        /// <summary>
        /// Add the previous set of elements on the stack to the current set.
        /// </summary>
        public jQuery andSelf() { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, AnimateOptions options) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsString easing) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsNumber duration) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(Map properties, JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, AnimateOptions options) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsString easing) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsNumber duration) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Perform a custom animation of a set of CSS properties.
        /// </summary>
        public jQuery animate(object properties, JsNumber duration, JsString easing, JsAction callback) { return null; }

        /// <summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        /// </summary>
        public jQuery append(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        /// </summary>
        public jQuery append(JsString content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        /// </summary>
        public jQuery append(JsNumber content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        /// </summary>
        public jQuery append(HtmlElement content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        /// </summary>
        public jQuery append(jQuery content) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the end of the target.
        /// </summary>
        public jQuery appendTo(JsString target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the end of the target.
        /// </summary>
        public jQuery appendTo(HtmlElement target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the end of the target.
        /// </summary>
        public jQuery appendTo(jQuery target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the end of the target.
        /// </summary>
        public jQuery appendTo(object target) { return null; }
        /// <summary>
        /// Get the value of an attribute for the first element in the set of matched elements.
        /// </summary>
        public JsString attr(JsString attributeName) { return null; }
        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        public jQuery attr(object map) { return null; }
        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        public jQuery attr(JsString attributeName, JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        public jQuery attr(JsString attributeName, JsString value) { return null; }
        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        public jQuery attr(JsString attributeName, JsNumber value) { return null; }
        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        public jQuery attr(JsString attributeName, bool value) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        /// </summary>
        public jQuery before(JsAction function) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        /// </summary>
        public jQuery before(JsString content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        /// </summary>
        public jQuery before(HtmlElement content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        /// </summary>
        public jQuery before(jQuery content) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        public jQuery bind(EventsMap events) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        public jQuery bind(JsString eventType, JsAction handler) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        public jQuery bind(JsString eventType, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        public jQuery bind(JsString eventType, bool @false) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        public jQuery bind(JsString eventType, object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        public jQuery bind(JsString eventType, object eventData, bool @false) { return null; }
        /// <summary>
        /// Bind an event handler to the "blur" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery blur() { return null; }
        /// <summary>
        /// Bind an event handler to the "blur" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery blur(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "blur" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery blur(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery change() { return null; }
        /// <summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery change(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery change(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery change(JsAction handler) { return null; }
        /// <summary>
        /// Get the children of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery children() { return null; }
        /// <summary>
        /// Get the children of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery children(JsString selector) { return null; }
        /// <summary>
        /// Remove from the queue all items that have not yet been run.
        /// </summary>
        public jQuery clearQueue() { return null; }
        /// <summary>
        /// Remove from the queue all items that have not yet been run.
        /// </summary>
        public jQuery clearQueue(JsString queueName) { return null; }
        /// <summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery click() { return null; }
        /// <summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery click(JsAction handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery click(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery click(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        public jQuery clone() { return null; }
        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        public jQuery clone(bool withDataAndEvents) { return null; }
        /// <summary>
        ///  Create a deep copy of the set of matched elements.
        /// </summary>
        /// <param name="withDataAndEvents">A Boolean indicating whether event handlers and data should be copied along with the elements.
        /// The default value is false. *In jQuery 1.5.0 the default value was incorrectly true; it was changed back to false in 1.5.1 and up.</param>
        /// <param name="deepWithDataAndEvents">A Boolean indicating whether event handlers and data for all children of the cloned element should be copied.
        /// By default its value matches the first argument's value (which defaults to false).</param>
        /// <returns></returns>
        public jQuery clone(bool withDataAndEvents, bool deepWithDataAndEvents) { return null; }
        /// <summary>
        /// Get the first ancestor element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        /// </summary>
        public jQuery closest(JsString selector) { return null; }
        /// <summary>
        /// Gets an array of all the elements and selectors matched against the current element up through the DOM tree.
        /// </summary>
        public JsArray closest(JsArray selectors) { return null; }
        /// <summary>
        /// Get the first ancestor element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        /// </summary>
        public jQuery closest(JsString selector, HtmlElement context) { return null; }
        /// <summary>
        /// Gets an array of all the elements and selectors matched against the current element up through the DOM tree.
        /// </summary>
        public JsArray closest(JsArray selectors, HtmlElement context) { return null; }
        /// <summary>
        /// Get the first ancestor element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        /// </summary>
        /// <param name="jqueryObject">
        /// A jQuery object to match elements against.
        /// </param>
        /// <returns>
        /// </returns>
        public jQuery closest(jQuery jqueryObject) { return null; }
        /// <summary>
        /// Get the first ancestor element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        /// </summary>
        /// <param name="element">
        /// An element to match elements against.
        /// </param>
        /// <returns>
        /// </returns>
        public jQuery closest(object element) { return null; } // ask dan-el about the element type.
        /// <summary>
        /// Get the children of each element in the set of matched elements, including text and comment nodes.
        /// </summary>
        public jQuery contents() { return null; }
        /// <summary>
        /// Get the value of a style property for the first element in the set of matched elements.
        /// </summary>
        public JsString css(JsString propertyName) { return null; }
        /// <summary>
        /// Set one or more CSS properties for the  set of matched elements.
        /// </summary>
        public jQuery css(object map) { return null; }
        /// <summary>
        /// Set one or more CSS properties for the  set of matched elements.
        /// </summary>
        public jQuery css(JsString propertyName, JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Set one or more CSS properties for the  set of matched elements.
        /// </summary>
        public jQuery css(JsString propertyName, JsString value) { return null; }
        /// <summary>
        /// Set one or more CSS properties for the  set of matched elements.
        /// </summary>
        public jQuery css(JsString propertyName, JsNumber value) { return null; }
        /// <summary>
        /// Returns value at named data store for the first element in the jQuery collection, as set by data(name, value).
        /// </summary>
        public object data() { return null; }
        /// <summary>
        /// Store arbitrary data associated with the matched elements.
        /// </summary>
        public jQuery data(object obj) { return null; }
        /// <summary>
        /// Returns value at named data store for the first element in the jQuery collection, as set by data(name, value).
        /// </summary>
        public object data(JsString key) { return null; }
        /// <summary>
        /// Store arbitrary data associated with the matched elements.
        /// </summary>
        public jQuery data(JsString key, object value) { return null; }
        /// <summary>
        /// Bind an event handler to the "dblclick" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery dblclick() { return null; }
        /// <summary>
        /// Bind an event handler to the "dblclick" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery dblclick(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "dblclick" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery dblclick(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Set a timer to delay execution of subsequent items in the queue.
        /// </summary>
        public jQuery delay(JsNumber duration) { return null; }
        /// <summary>
        /// Set a timer to delay execution of subsequent items in the queue.
        /// </summary>
        public jQuery delay(JsNumber duration, JsString queueName) { return null; }
        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        public jQuery @delegate(JsString selector, JsString eventType, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        public jQuery @delegate(JsString selector, JsString eventType, object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        public jQuery @delegate(JsString selector, JsString events) { return null; }
        /// <summary>
        /// Provides a way to execute callback functions based on one or more objects, usually Deferred objects that represent asynchronous events.
        /// <list type="bullet">
        /// If a single Deferred is passed to jQuery.when, its Promise object (a subset of the Deferred methods) is returned by the method. Additional methods of the Promise object can be called to attach callbacks, such as deferred.then. When the Deferred is resolved or rejected, usually by the code that created the Deferred originally, the appropriate callbacks will be called.
        /// <example>
        /// the jqXHR object returned by jQuery.ajax is a Deferred and can be used this way:
        /// <code>
        /// $.when( $.ajax("test.aspx") ).then(function(ajaxArgs){ 
        ///      alert(ajaxArgs[1]); /* ajaxArgs is [ "success", statusText, jqXHR ] */
        /// });        
        /// </code>
        /// </example>
        /// </list>
        /// <list type="bullet">
        /// If a single argument is passed to jQuery.when and it is not a Deferred, it will be treated as a resolved Deferred and any doneCallbacks attached will be executed immediately. The doneCallbacks are passed the original argument. In this case any failCallbacks you might set are never called since the Deferred is never rejected.
        /// <example>
        /// <code>
        /// $.when( { testing: 123 } ).done(
        ///   function(x){ alert(x.testing); } /* alerts "123" */
        /// );
        /// </code>
        /// </example>
        /// In the case where multiple Deferred objects are passed to jQuery.when, the method returns the Promise from a new "master" Deferred object that tracks the aggregate state of all the Deferreds it has been passed. The method will resolve its master Deferred as soon as all the Deferreds resolve, or reject the master Deferred as soon as one of the Deferreds is rejected. If the master Deferred is resolved, it is passed the resolved values of all the Deferreds that were passed to jQuery.when. For example, when the Deferreds are jQuery.ajax() requests, the arguments will be the jqXHR objects for the requests, in the order they were given in the argument list.
        /// In the multiple-Deferreds case where one of the Deferreds is rejected, jQuery.when immediately fires the failCallbacks for its master Deferred. Note that some of the Deferreds may still be unresolved at that point. If you need to perform additional processing for this case, such as canceling any unfinished ajax requests, you can keep references to the underlying jqXHR objects in a closure and inspect/cancel them in the failCallback.
        /// </list>
        /// </summary>
        /// <param name="defferds">
        /// deferreds One or more Deferred objects, or plain JavaScript objects.
        /// </param>
        /// <returns>
        /// Returns: Promise
        /// </returns>
        /// <example>
        ///  Execute a function after two ajax requests are successful. (See the jQuery.ajax() documentation for a complete description of success and error cases for an ajax request).
        /// <code>
        /// $.when($.ajax("/page1.php"), $.ajax("/page2.php")).done(function(a1,  a2){
        ///    /* a1 and a2 are arguments resolved for the 
        ///        page1 and page2 ajax requests, respectively */
        ///   var jqXHR = a1[2]; /* arguments are [ "success", statusText, jqXHR ] */
        ///   if ( /Whip It/.test(jqXHR.responseText) ) {
        ///      alert("First page has 'Whip It' somewhere.");
        ///   }
        /// });
        /// </code>
        ///  Execute the function myFunc when both ajax requests are successful, or myFailure if either one has an error.
        ///  <code>
        /// $.when($.ajax("/page1.php"), $.ajax("/page2.php"))
        ///  .then(myFunc, myFailure);
        ///  </code>
        /// </example>
        public static Promise when(params Deferred[] defferds) { return null; }
        /// <summary>
        /// Execute the next function on the queue for the matched elements.
        /// </summary>
        public jQuery dequeue() { return null; }
        /// <summary>
        /// Execute the next function on the queue for the matched elements.
        /// </summary>
        public jQuery dequeue(JsString queueName) { return null; }
        /// <summary>
        /// Remove the set of matched elements from the DOM.
        /// </summary>
        public jQuery detach() { return null; }
        /// <summary>
        /// Remove the set of matched elements from the DOM.
        /// </summary>
        public jQuery detach(JsString selector) { return null; }
        /// <summary>
        /// Remove all event handlers previously attached using .live() from the elements.
        /// </summary>
        public jQuery die() { return null; }
        /// <summary>
        /// Remove an event handler previously attached using .live() from the elements.
        /// </summary>
        public jQuery die(JsString eventType) { return null; }
        /// <summary>
        /// Remove an event handler previously attached using .live() from the elements.
        /// </summary>
        public jQuery die(JsString eventType, JsString handler) { return null; }
        /// <summary>
        /// Iterate over a jQuery object, executing a function for each matched element.
        /// </summary>
        public jQuery each(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Invokes the jQuery $.each() function.  @return(true) from the callback to continue, false to break.
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="array">The array to iterate over the elements of</param>
        /// <param name="callback"></param>
        public static void each<T>(JsArray<T> array, JsAction<JsNumber, T> callback) { }
        /// <summary>
        /// Invoices the jQuery $.each() function.  @return(true) true from the callback to continue, false to break.
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="obj">The object to iterate over the properties of</param>
        /// <param name="callback"></param>
        public static void each<T>(JsObject<T> obj, JsAction<JsNumber, T> callback) { }
        /// <summary>
        /// Remove all child nodes of the set of matched elements from the DOM.
        /// </summary>
        public jQuery empty() { return null; }
        /// <summary>
        /// End the most recent filtering operation in the current chain and return the set of matched elements to its previous state.
        /// </summary>
        public jQuery end() { return null; }
        /// <summary>
        ///  Reduce the set of matched elements to the one at the specified index.
        /// </summary>
        /// <param name="index">An integer indicating the position of the element, by adding "-" counting backwards from the last element in the set.</param>
        /// <returns></returns>
        public jQuery eq(JsNumber index) { return null; }
        /// <summary>
        /// Bind an event handler to the "error" JavaScript event.
        /// </summary>
        public jQuery error(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "error" JavaScript event.
        /// </summary>
        public jQuery error(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn() { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsNumber duration) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        public jQuery fadeIn(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut() { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsFunc<jQuery> callback) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsNumber duration) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        public jQuery fadeOut(JsNumber duration, JsString easing, JsAction callback) { return null; }


        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber opacity) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsString duration, JsNumber opacity) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber opacity, JsAction callback) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber opacity, JsString easing) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber duration, JsNumber opacity) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsString duration, JsNumber opacity, JsAction callback) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsString duration, JsNumber opacity, JsString easing) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber opacity, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber duration, JsNumber opacity, JsAction callback) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber duration, JsNumber opacity, JsString easing) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsString duration, JsNumber opacity, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        public jQuery fadeTo(JsNumber duration, JsNumber opacity, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>

        public jQuery fadeToggle() { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsNumber duration) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        public jQuery fadeToggle(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test.
        /// </summary>
        public jQuery filter(JsString selector) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test.
        /// </summary>
        public jQuery filter(JsFunc<int, bool> function) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test.
        /// </summary>
        public jQuery filter(HtmlElement element) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test.
        /// </summary>
        public jQuery filter(jQuery jQuery_object) { return null; }
        /// <summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector.
        /// </summary>
        public jQuery find(JsString selector) { return null; }
        /// <summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        /// </summary>
        /// <param name="jqueryObject">
        /// A jQuery object to match elements against.
        /// </param>
        /// <returns>
        /// </returns>
        public jQuery find(jQuery jqueryObject) { return null; }
        /// <summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        /// </summary>
        /// <param name="element">
        /// An element to match elements against.
        /// </param>
        /// <returns>
        /// </returns>
        public jQuery find(object element) { return null; } // ask doni about the eeent type.
        /// <summary>
        /// Reduce the set of matched elements to the first in the set.
        /// </summary>
        public jQuery first() { return null; }
        /// <summary>
        /// Bind an event handler to the "focus" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery focus() { return null; }
        /// <summary>
        /// Bind an event handler to the "focus" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery focus(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "focus" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery focus(object eventData, JsAction<Event> handler) { return null; }

        // TODO: focus selector- http://api.jquery.com/focus-selector/

        /// <summary>
        /// Bind an event handler to the "focusin" JavaScript event.
        /// </summary>
        public jQuery focusin(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "focusin" JavaScript event.
        /// </summary>
        public jQuery focusin(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "focusout" JavaScript event.
        /// </summary>
        public jQuery focusout(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "focusout" JavaScript event.
        /// </summary>
        public jQuery focusout(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Retrieve the DOM elements matched by the jQuery object.
        /// </summary>
        public JsArray<HtmlElement> get() { return null; }
        /// <summary>
        /// Retrieve the DOM elements matched by the jQuery object.
        /// </summary>
        public HtmlElement get(JsNumber index) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery has(JsString selector) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.
        /// </summary>
        /// <param name="contained">Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.</param>
        /// <returns></returns>
        public jQuery has(HtmlElement contained) { return null; }
        /// <summary>
        /// Determine whether any of the matched elements are assigned the given class.
        /// </summary>
        public bool hasClass(JsString className) { return false; }
        /// <summary>
        /// Determine whether an element has any jQuery data associated with it.
        /// </summary>
        /// <param name="element">
        /// element A DOM element to be checked for data.
        /// </param>
        /// <returns>
        /// The jQuery.hasData() method provides a way to determine if an element currently has any values that were set using jQuery.data(). If no data is associated with an element (there is no data object at all or the data object is empty), the method returns false; otherwise it returns true.
        /// The primary advantage of jQuery.hasData(element) is that it does not create and associate a data object with the element if none currently exists. In contrast, jQuery.data(element) always returns a data object to the caller, creating one if no data object previously existed.
        /// </returns>
        /// <example>
        /// Set data on an element and see the results of hasData.
        /// <code>
        ///&lt;!DOCTYPE html>
        ///&lt;html>
        ///&lt;head>
        ///  &lt;script src="http:///code.jquery.com/jquery-latest.js">&lt;/script>
        ///&lt;/head>
        ///&lt;body>
        ///  &lt;p>Results: &lt;/p>
        ///&lt;script>
        ///$(function(){
        ///  var $p = jQuery("p"), p = $p[0];
        ///  $p.append(jQuery.hasData(p)+" "); /* false */
        ///  jQuery.data(p, "testing", 123);
        ///  $p.append(jQuery.hasData(p)+" "); /* true*/
        ///  jQuery.removeData(p, "testing");
        ///  $p.append(jQuery.hasData(p)+" "); /* false */
        ///});
        ///&lt;/script>
        ///
        ///&lt;/body>
        ///&lt;/html>
        ///Demo:
        ///Results: false true false
        /// </code>
        /// </example>
        public bool hasData(HtmlElement element) { return false; }

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements.
        /// </summary>
        public JsNumber height() { return null; }
        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        public jQuery height(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        public jQuery height(JsString value) { return null; }
        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        public jQuery height(JsNumber value) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide() { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsNumber duration) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements.
        /// </summary>
        public jQuery hide(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Bind a single handler to the matched elements, to be executed when the mouse pointer enters or leaves the elements.
        /// </summary>
        public jQuery hover(JsAction<Event> handlerInOut) { return null; }
        /// <summary>
        /// Bind two handlers to the matched elements, to be executed when the mouse pointer enters and leaves the elements.
        /// </summary>
        public jQuery hover(JsAction<Event> handlerIn, JsAction<Event> handlerOut) { return null; }
        /// <summary>
        /// Get the HTML contents of the first element in the set of matched elements.
        /// </summary>
        public JsString html() { return null; }
        /// <summary>
        /// Set the HTML contents of each element in the set of matched elements.
        /// </summary>
        public jQuery html(JsString htmlString) { return null; }
        /// <summary>
        /// Set the HTML contents of each element in the set of matched elements.
        /// </summary>
        public jQuery html(JsAction<JsNumber, HtmlElement> function) { return null; }

        /// <summary>
        /// Get the value of a property for the first element in the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns></returns>
        public JsString prop(JsString propertyName) { return null; }
        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="map">A map of property-value pairs to set.</param>
        /// <returns></returns>
        public jQuery prop(object map) { return null; }
        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="function">A function returning the value to set. Receives the index position of the element in the set and the old property value as arguments.
        /// Within the function, the keyword this refers to the current element.</param>
        /// <returns></returns>
        public jQuery prop(JsString propertyName, JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Set one or more properties for the set of matched elements
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns></returns>
        public jQuery prop(JsString propertyName, JsString value) { return null; }
        /// <summary>
        /// Set one or more properties for the set of matched elements
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns></returns>
        public jQuery prop(JsString propertyName, JsNumber value) { return null; }
        /// <summary>
        /// Set one or more properties for the set of matched elements
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns></returns>
        public jQuery prop(JsString propertyName, bool value) { return null; }
        /// <summary>
        /// Holds or releases the execution of jQuery's ready event.
        /// <list type="bullet">
        /// The $.holdReady() method allows the caller to delay jQuery's ready event. This advanced feature would typically be used by dynamic script loaders that want to load additional JavaScript such as jQuery plugins before allowing the ready event to occur, even though the DOM may be ready. This method must be called early in the document, such as in the &lt;head&gt; immediately after the jQuery script tag. Calling this method after the ready event has already fired will have no effect.
        /// To delay the ready event, first call $.holdReady(true). When the ready event should be released to execute, call $.holdReady(false). Note that multiple holds can be put on the ready event, one for each $.holdReady(true) call. The ready event will not actually fire until all holds have been released with a corresponding $.holdReady(false) and the normal document ready conditions are met. (See ready for more information.)
        /// </list>
        /// <example>
        /// Delay the ready event until a custom plugin has loaded.
        /// <code>
        /// $.holdReady(true);
        /// $.getScript("myplugin.js", function() {
        ///      $.holdReady(false);
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="hold">
        /// Indicates whether the ready hold is being requested or released
        /// </param>
        public static void holdReady(JsAction hold)
        {
        }
        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        public JsNumber index() { return null; }
        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        public JsNumber index(JsString selector) { return null; }
        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        public JsNumber index(HtmlElement element) { return null; }
        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        public JsNumber index(jQuery element) { return null; }
        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding but not border.
        /// </summary>
        public JsNumber innerHeight() { return null; }
        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding but not border.
        /// </summary>
        public JsNumber innerWidth() { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements after the target.
        /// </summary>
        public jQuery insertAfter(JsString target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements after the target.
        /// </summary>
        public jQuery insertAfter(HtmlElement target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements after the target.
        /// </summary>
        public jQuery insertAfter(jQuery target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements before the target.
        /// </summary>
        public jQuery insertBefore(JsString target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements before the target.
        /// </summary>
        public jQuery insertBefore(HtmlElement target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements before the target.
        /// </summary>
        public jQuery insertBefore(jQuery target) { return null; }
        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public bool @is(JsString selector) { return false; }
        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="function">A function used as a test for the set of elements.
        /// It accepts one argument, index, which is the element's index in the jQuery collection.Within the function, this refers to the current DOM element.</param>
        /// <returns></returns>
        public jQuery @is(JsFunc<int, bool> function) { return null; }
        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="element">An element to match the current set of elements against.</param>
        /// <returns></returns>
        public jQuery @is(HtmlElement element) { return null; }
        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="jQueryObject">jQuery objectAn existing jQuery object to match the current set of elements against.</param>
        /// <returns></returns>
        public jQuery @is(jQuery jQueryObject) { return null; }
        /// <summary>
        /// Bind an event handler to the "keydown" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keydown() { return null; }
        /// <summary>
        /// Bind an event handler to the "keydown" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keydown(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "keydown" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keydown(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "keypress" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keypress() { return null; }
        /// <summary>
        /// Bind an event handler to the "keypress" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keypress(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "keypress" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keypress(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "keyup" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keyup() { return null; }
        /// <summary>
        /// Bind an event handler to the "keyup" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keyup(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "keyup" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery keyup(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to the final one in the set.
        /// </summary>
        public jQuery last() { return null; }
        /// <summary>
        /// Attach a handler to the event for all elements which match the current selector, now and in the future.
        /// </summary>
        public jQuery live(JsString eventType, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to the event for all elements which match the current selector, now and in the future.
        /// </summary>
        public jQuery live(JsString eventType, object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "load" JavaScript event.
        /// </summary>
        public jQuery load(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Load data from the server and place the returned HTML into the matched element.
        /// </summary>
        public jQuery load(JsString url) { return null; }
        /// <summary>
        /// Bind an event handler to the "load" JavaScript event.
        /// </summary>
        public jQuery load(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Load data from the server and place the returned HTML into the matched element.
        /// </summary>
        public jQuery load(JsString url, object data) { return null; }
        /// <summary>
        /// Load data from the server and place the returned HTML into the matched element.
        /// </summary>
        public jQuery load(JsString url, JsAction<object, string, jqXHR> complete) { return null; }
        /// <summary>
        /// Load data from the server and place the returned HTML into the matched element.
        /// </summary>
        public jQuery load(JsString url, JsString data) { return null; }
        /// <summary>
        /// Load data from the server and place the returned HTML into the matched element.
        /// </summary>
        public jQuery load(JsString url, object data, JsAction<object, string, jqXHR> complete) { return null; }
        /// <summary>
        /// Load data from the server and place the returned HTML into the matched element.
        /// </summary>
        public jQuery load(JsString url, JsString data, JsAction<object, string, jqXHR> complete) { return null; }
        /// <summary>
        /// Pass each element in the current matched set through a function, producing a new jQuery object containing the return values.
        /// </summary>
        public jQuery map(JsFunc<HtmlElement, HtmlElement, object> callback) { return null; }
        /// <summary>
        /// Bind an event handler to the "mousedown" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mousedown() { return null; }
        /// <summary>
        /// Bind an event handler to the "mousedown" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mousedown(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mousedown" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mousedown(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to be fired when the mouse enters an element, or trigger that handler on an element.
        /// </summary>
        public jQuery mouseenter() { return null; }
        /// <summary>
        /// Bind an event handler to be fired when the mouse enters an element, or trigger that handler on an element.
        /// </summary>
        public jQuery mouseenter(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to be fired when the mouse enters an element, or trigger that handler on an element.
        /// </summary>
        public jQuery mouseenter(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to be fired when the mouse leaves an element, or trigger that handler on an element.
        /// </summary>
        public jQuery mouseleave() { return null; }
        /// <summary>
        /// Bind an event handler to be fired when the mouse leaves an element, or trigger that handler on an element.
        /// </summary>
        public jQuery mouseleave(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to be fired when the mouse leaves an element, or trigger that handler on an element.
        /// </summary>
        public jQuery mouseleave(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mousemove" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mousemove() { return null; }
        /// <summary>
        /// Bind an event handler to the "mousemove" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mousemove(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mousemove" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mousemove(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseout" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseout() { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseout" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseout(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseout" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseout(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseover" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseover() { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseover" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseover(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseover" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseover(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseup" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseup() { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseup" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseup(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "mouseup" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery mouseup(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Get the immediately following sibling of each element in the set of matched elements. If a selector is provided, it retrieves the next sibling only if it matches that selector.
        /// </summary>
        public jQuery next() { return null; }
        /// <summary>
        ///  Get the immediately following sibling of each element in the set of matched elements.
        ///  If a selector is provided, it retrieves the next sibling only if it matches that selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery next(JsString selector) { return null; }
        /// <summary>
        /// Get all following siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery nextAll() { return null; }
        /// <summary>
        /// Get all following siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery nextAll(JsString selector) { return null; }
        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector.
        /// </summary>
        public jQuery nextUntil() { return null; }
        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery nextUntil(JsString selector, JsString filter) { return null; }
        /// <summary>
        ///  Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery nextUntil(HtmlElement element, JsString filter) { return null; }
        /// <summary>
        ///  Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery nextUntil(jQuery element, JsString filter) { return null; }
        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public jQuery nextUntil(JsString selector) { return null; }
        /// <summary>
        ///  Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public jQuery nextUntil(HtmlElement element) { return null; }
        /// <summary>
        ///  Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public jQuery nextUntil(jQuery element) { return null; }
        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        public jQuery not(JsString selector) { return null; }
        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        public jQuery not(JsArray<HtmlElement> elements) { return null; }
        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        public jQuery not(JsAction<Event> function) { return null; }
        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="jQueryObject">An existing jQuery object to match the current set of elements against.</param>
        /// <returns></returns>
        public jQuery not(jQuery jQueryObject) { return null; }
        /// <summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the document.
        /// </summary>
        public TopLeft offset() { return null; }
        /// <summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        /// </summary>
        public jQuery offset(object coordinates) { return null; }
        /// <summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        /// </summary>
        public jQuery offset(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Get the closest ancestor element that is positioned.
        /// </summary>
        public jQuery offsetParent() { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        /// </summary>
        public jQuery one(JsString events, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        /// </summary>
        public jQuery one(JsString events, object data, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin"</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event.
        /// If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false</param>
        /// <returns></returns>
        public jQuery one(JsString events, JsString selector, object data, JsAction<Event> handler) { return null; }
        //TODO: data type?
        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        /// </summary>
        /// <param name="eventsMap">A map in which the string keys represent one or more space-separated event types and optional namespaces,
        /// and the values represent a handler function to be called for the event(s).</param>
        /// <returns></returns>
        public jQuery one(EventsMap eventsMap) { return null; }
        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        /// </summary>
        /// <param name="eventsMap"></param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event.
        /// If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <returns></returns>
        public jQuery one(EventsMap eventsMap, JsString selector, object data) { return null; }
        //TODO: data type?
        //TODO: danel must check all "one"

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding, border, and optionally margin.
        /// </summary>
        public JsNumber outerHeight() { return null; }
        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding, border, and optionally margin.
        /// </summary>
        public JsNumber outerHeight(bool includeMargin) { return null; }
        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding and border.
        /// </summary>
        public JsNumber outerWidth() { return null; }
        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding and border.
        /// </summary>
        public JsNumber outerWidth(bool includeMargin) { return null; }
        /// <summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery parent() { return null; }
        /// <summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery parent(JsString selector) { return null; }
        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery parents() { return null; }
        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery parents(JsString selector) { return null; }
        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector.
        /// </summary>
        public jQuery parentsUntil() { return null; }
        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector.
        /// </summary>
        public jQuery parentsUntil(JsString selector) { return null; }
        /// <summary>
        ///  Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery parentsUntil(HtmlElement element, JsString filter) { return null; }
        /// <summary>
        ///  Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery parentsUntil(jQuery element, JsString filter) { return null; }
        /// <summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the offset parent.
        /// </summary>
        public TopLeft position() { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        /// </summary>
        public jQuery prepend(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        /// </summary>
        public jQuery prepend(JsString content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        /// </summary>
        public jQuery prepend(HtmlElement content) { return null; }
        /// <summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        /// </summary>
        public jQuery prepend(jQuery content) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the beginning of the target.
        /// </summary>
        public jQuery prependTo(JsString target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the beginning of the target.
        /// </summary>
        public jQuery prependTo(HtmlElement target) { return null; }
        /// <summary>
        /// Insert every element in the set of matched elements to the beginning of the target.
        /// </summary>
        public jQuery prependTo(jQuery target) { return null; }
        /// <summary>
        /// Get the immediately preceding sibling of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery prev() { return null; }
        /// <summary>
        /// Get the immediately preceding sibling of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery prev(JsString selector) { return null; }
        /// <summary>
        /// Get all preceding siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery prevAll() { return null; }
        /// <summary>
        /// Get all preceding siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery prevAll(JsString selector) { return null; }
        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector.
        /// </summary>
        public jQuery prevUntil() { return null; }
        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector.
        /// </summary>
        public jQuery prevUntil(JsString selector) { return null; }
        /// <summary>
        ///   Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery prevUntil(HtmlElement element, JsString filter) { return null; }
        /// <summary>
        ///   Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public jQuery prevUntil(jQuery element, JsString filter) { return null; }
        /// <summary>
        /// Add a collection of DOM elements onto the jQuery stack.
        /// </summary>
        public jQuery pushStack(JsArray elements) { return null; }
        /// <summary>
        /// Add a collection of DOM elements onto the jQuery stack.
        /// </summary>
        public jQuery pushStack(JsArray elements, JsString name, JsArray arguments) { return null; }
        /// <summary>
        /// Show the queue of functions to be executed on the matched elements.
        /// </summary>
        public JsArray queue() { return null; }
        /// <summary>
        /// Show the queue of functions to be executed on the matched elements.
        /// </summary>
        public JsArray queue(JsString queueName) { return null; }
        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched elements.
        /// </summary>
        public jQuery queue(JsArray newQueue) { return null; }
        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched elements.
        /// </summary>
        public jQuery queue(JsAction<Event> callback) { return null; }
        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched elements.
        /// </summary>
        public jQuery queue(JsString queueName, JsArray newQueue) { return null; }
        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched elements.
        /// </summary>
        public jQuery queue(JsString queueName, JsAction<Event> callback) { return null; }
        /// <summary>
        /// Specify a function to execute when the DOM is fully loaded.
        /// </summary>
        public jQuery ready(JsAction handler) { return null; }
        /// <summary>
        /// Remove the set of matched elements from the DOM.
        /// </summary>
        public jQuery remove() { return null; }
        /// <summary>
        /// Remove the set of matched elements from the DOM.
        /// </summary>
        public jQuery remove(JsString selector) { return null; }
        /// <summary>
        /// Remove an attribute from each element in the set of matched elements.
        /// </summary>
        public jQuery removeAttr(JsString attributeName) { return null; }
        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        /// </summary>
        public jQuery removeClass() { return null; }
        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        /// </summary>
        public jQuery removeClass(JsString className) { return null; }
        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        /// </summary>
        public jQuery removeClass(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Remove a property for the set of matched elements.
        /// </summary>
        public jQuery removeProp(JsString propertyName) { return null; }
        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        public static jQuery removeData() { return null; }
        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        public jQuery removeData(JsString name) { return null; }
        /// <summary>
        /// Replace each target element with the set of matched elements.
        /// </summary>
        public jQuery replaceAll(JsString target) { return null; }
        /// <summary>
        /// Replace each element in the set of matched elements with the provided new content.
        /// </summary>
        public jQuery replaceWith(JsAction function) { return null; }
        /// <summary>
        /// Replace each element in the set of matched elements with the provided new content.
        /// </summary>
        public jQuery replaceWith(JsString newContent) { return null; }
        /// <summary>
        /// Replace each element in the set of matched elements with the provided new content.
        /// </summary>
        public jQuery replaceWith(HtmlElement newContent) { return null; }
        /// <summary>
        /// Replace each element in the set of matched elements with the provided new content.
        /// </summary>
        public jQuery replaceWith(jQuery newContent) { return null; }
        /// <summary>
        /// Bind an event handler to the "resize" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery resize() { return null; }
        /// <summary>
        /// Bind an event handler to the "resize" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery resize(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "resize" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery resize(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "scroll" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery scroll() { return null; }
        /// <summary>
        /// Bind an event handler to the "scroll" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery scroll(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "scroll" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery scroll(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Get the current horizontal position of the scroll bar for the first element in the set of matched elements.
        /// </summary>
        public JsNumber scrollLeft() { return null; }
        /// <summary>
        /// Set the current horizontal position of the scroll bar for each of the set of matched elements.
        /// </summary>
        public jQuery scrollLeft(JsNumber value) { return null; }
        /// <summary>
        /// Get the current vertical position of the scroll bar for the first element in the set of matched elements.
        /// </summary>
        public JsNumber scrollTop() { return null; }
        /// <summary>
        /// Set the current vertical position of the scroll bar for each of the set of matched elements.
        /// </summary>
        public jQuery scrollTop(JsNumber value) { return null; }
        /// <summary>
        /// Bind an event handler to the "select" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery select() { return null; }
        /// <summary>
        /// Bind an event handler to the "select" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery select(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "select" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery select(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Encode a set of form elements as a string for submission.
        /// </summary>
        public JsString serialize() { return null; }
        /// <summary>
        /// Encode a set of form elements as an array of names and values.
        /// </summary>
        public JsArray serializeArray() { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show() { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsNumber duration) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements.
        /// </summary>
        public jQuery show(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Get the siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery siblings() { return null; }
        /// <summary>
        /// Get the siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        public jQuery siblings(JsString selector) { return null; }
        /// <summary>
        /// Return the number of DOM elements matched by the jQuery object.
        /// </summary>
        public JsNumber size() { return null; }
        /// <summary>
        /// Reduce the set of matched elements to a subset specified by a range of indices.
        /// </summary>
        public jQuery slice(JsNumber start) { return null; }
        /// <summary>
        /// Reduce the set of matched elements to a subset specified by a range of indices.
        /// </summary>
        public jQuery slice(JsNumber start, JsNumber end) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown() { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsNumber duration) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideDown(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle() { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsNumber duration) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideToggle(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp() { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsNumber duration) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Hide the matched elements with a sliding motion.
        /// </summary>
        public jQuery slideUp(JsNumber duration, JsString easing, JsAction callback) { return null; }

        /// <summary>
        /// Stop the currently-running animation on the matched elements.
        /// </summary>
        public jQuery stop() { return null; }

        /// <summary>
        /// Stop the currently-running animation on the matched elements.
        /// </summary>
        public jQuery stop(bool clearQueue) { return null; }

        /// <summary>
        /// Stop the currently-running animation on the matched elements.
        /// </summary>
        public jQuery stop(bool clearQueue, bool jumpToEnd) { return null; }

        /// <summary>
        /// Stop the currently-running animation, remove all queued animations, and complete all animations for the matched elements.
        /// </summary>
        public jQuery finish() { return null; }

        /// <summary>
        /// Stop the currently-running animation, remove all queued animations, and complete all animations for the matched elements.
        /// </summary>
        public jQuery finish(JsString queue) { return null; }

        /// <summary>
        /// Bind an event handler to the "submit" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery submit() { return null; }
        /// <summary>
        /// Bind an event handler to the "submit" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery submit(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "submit" JavaScript event, or trigger that event on an element.
        /// </summary>
        public jQuery submit(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Get the combined text contents of each element in the set of matched elements, including their descendants.
        /// </summary>
        public JsString text() { return null; }
        /// <summary>
        /// Set the content of each element in the set of matched elements to the specified text.
        /// </summary>
        public jQuery text(JsString textString) { return null; }
        /// <summary>
        /// Set the content of each element in the set of matched elements to the specified text.
        /// </summary>
        public jQuery text(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Retrieve all the DOM elements contained in the jQuery set, as an array.
        /// </summary>
        public JsArray<HtmlElement> toArray() { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle() { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(bool showOrHide) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsNumber duration) { return null; }
        /// <summary>
        /// Bind two or more handlers to the matched elements, to be executed on alternate clicks.
        /// </summary>
        public jQuery toggle(JsAction<Event> handler, JsAction<Event> handler_) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsString duration, JsString easing) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsNumber duration, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsNumber duration, JsString easing) { return null; }
        /// <summary>
        /// Bind two or more handlers to the matched elements, to be executed on alternate clicks.
        /// </summary>
        public jQuery toggle(JsAction<Event> handler, JsAction<Event> handler_, JsAction<Event> handler__) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsString duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Display or hide the matched elements.
        /// </summary>
        public jQuery toggle(JsNumber duration, JsString easing, JsAction callback) { return null; }
        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        public jQuery toggleClass(JsString className) { return null; }
        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        public jQuery toggleClass(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        public jQuery toggleClass(JsString className, bool @switch) { return null; }
        /// <summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        /// </summary>
        public jQuery toggleClass(JsAction<JsNumber, HtmlElement> function, bool @switch) { return null; }
        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        public jQuery trigger(JsString eventType) { return null; }
        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        public jQuery trigger(Event @event) { return null; }
        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        public jQuery trigger(JsString eventType, JsArray extraParameters) { return null; }
        /// <summary>
        /// Execute all handlers attached to an element for an event.
        /// </summary>
        public object triggerHandler(JsString eventType, JsArray extraParameters) { return null; }
        /// <summary>
        /// Execute all handlers attached to an element for an event.
        /// </summary>
        public object triggerHandler(JsString eventType) { return null; }
        public object triggerHandler(Event ev) { return null; }
        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        public jQuery unbind() { return null; }
        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        public jQuery unbind(object @event) { return null; }
        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        public jQuery unbind(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        public jQuery unbind(JsString eventType) { return null; }
        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        public jQuery unbind(JsString eventType, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        public jQuery unbind(JsString eventType, bool @false) { return null; }
        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, now or in the future, based upon a specific set of root elements.
        /// </summary>
        public jQuery undelegate() { return null; }
        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, now or in the future, based upon a specific set of root elements.
        /// </summary>
        public jQuery undelegate(JsString selector, JsString eventType) { return null; }
        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, now or in the future, based upon a specific set of root elements.
        /// </summary>
        public jQuery undelegate(JsString selector, JsString eventType, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elemen
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="events">A map of one or more event types and previously bound functions to unbind from them.</param>
        /// <returns></returns>
        public jQuery undelegate(JsString selector, EventsMap events) { return null; }
        /// <summary>
        ///  Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="namespace">A string containing a namespace to unbind all events from.</param>
        /// <returns></returns>
        public jQuery undelegate(JsString @namespace) { return null; }
        /// <summary>
        /// Bind an event handler to the "unload" JavaScript event.
        /// </summary>
        public jQuery unload(JsAction<Event> handler) { return null; }
        /// <summary>
        /// Bind an event handler to the "unload" JavaScript event.
        /// </summary>
        public jQuery unload(object eventData, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Remove the parents of the set of matched elements from the DOM, leaving the matched elements in their place.
        /// </summary>
        public jQuery unwrap() { return null; }
        /// <summary>
        /// Get the current value of the first element in the set of matched elements.
        /// </summary>
        public object val() { return null; }
        /// <summary>
        /// Get the current value of the first element in the set of matched elements.
        /// </summary>
        [JsMethod(Name = "val")]
        public JsString valString() { return null; }
        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        public jQuery val(JsString value) { return null; }
        /// <summary>
        /// Set the value of each element in the set of matched elements.
        /// </summary>
        public jQuery val(JsAction<JsNumber, HtmlElement> function) { return null; }


        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements.
        /// </summary>
        public JsNumber width() { return null; }
        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        public jQuery width(JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        public jQuery width(JsString value) { return null; }
        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        public jQuery width(JsNumber value) { return null; }
        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        public jQuery wrap(JsAction wrappingFunction) { return null; }
        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        public jQuery wrap(JsString wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        public jQuery wrap(HtmlElement wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        public jQuery wrap(jQuery wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        /// </summary>
        public jQuery wrapAll(JsString wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        /// </summary>
        public jQuery wrapAll(HtmlElement wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        /// </summary>
        public jQuery wrapAll(jQuery wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        /// </summary>
        public jQuery wrapInner(JsString wrappingElement) { return null; }
        /// <summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        /// </summary>
        public jQuery wrapInner(JsAction wrappingFunction) { return null; }
        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        ///<seealso cref="T:SharpKit.jQuery.jqXHR"/>        
        /// </summary>
        public static jqXHR ajax(AjaxSettings settings) { return null; }
        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        ///<seealso cref="T:SharpKit.jQuery.jqXHR"/>        
        /// </summary>
        public static jqXHR ajax(JsString url, AjaxSettings settings) { return null; }
        /// <summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        ///<seealso cref="T:SharpKit.jQuery.jqXHR"/>        
        /// </summary>
        public static jqXHR ajax(JsString url) { return null; }
        /// <summary>
        /// Set default values for future Ajax requests.
        ///<seealso cref="T:SharpKit.jQuery.jqXHR"/>        
        /// </summary>
        public static void ajaxSetup(AjaxSettings options) { }
        /// <summary>
        /// Check to see if a DOM node is within another DOM node.
        /// </summary>
        public static bool contains(HtmlElement container, HtmlElement contained) { return false; }
        /// <summary>
        /// Returns value at named data store for the element, as set by jQuery.data(element, name, value), or the full data store for the element.
        /// </summary>
        public static JsObject data(HtmlElement element) { return null; }
        /// <summary>
        /// Returns value at named data store for the element, as set by jQuery.data(element, name, value), or the full data store for the element.
        /// </summary>
        public static object data(HtmlElement element, JsString key) { return null; }
        /// <summary>
        /// Store arbitrary data associated with the specified element.
        /// </summary>
        public static jQuery data(HtmlElement element, JsString key, object value) { return null; }
        /// <summary>
        /// Execute the next function on the queue for the matched element.
        /// </summary>
        public static void dequeue(HtmlElement element) { }
        /// <summary>
        /// Execute the next function on the queue for the matched element.
        /// </summary>
        public static void dequeue(HtmlElement element, JsString queueName) { }

        /// <summary>
        /// A generic iterator function, which can be used to seamlessly iterate over both objects and arrays. Arrays and array-like objects with a length property (such as a function's arguments object) are iterated by numeric index, from 0 to length-1. Other objects are iterated via their named properties.
        /// </summary>
        public static object each(object collection, JsAction<JsNumber, object> callback) { return null; }
        /// <summary>
        /// Takes a string and throws an exception containing it.
        /// </summary>
        public static void error(JsString message) { }

        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static JsObject extend(JsObject target) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static JsObject extend(JsObject target, JsObject object1) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static JsObject extend(JsObject target, JsObject object1, JsObject objectN) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static JsObject extend(bool deep, JsObject target, JsObject object1) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static JsObject extend(bool deep, JsObject target, JsObject object1, JsObject objectN) { return null; }

        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static object extend(object target) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static object extend(object target, object object1) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static object extend(object target, object object1, object objectN) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static object extend(bool deep, object target, object object1) { return null; }
        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        public static object extend(bool deep, object target, object object1, object objectN) { return null; }

        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, object data) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, JsAction<object, string, jqXHR> callback) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, JsString data) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, object data, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, object data, JsAction<object, string, jqXHR> callback) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, JsAction<object, string, jqXHR> callback, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, JsString data, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, JsString data, JsAction<object, string, jqXHR> callback) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, object data, JsAction<object, string, jqXHR> callback, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP GET request.
        /// </summary>
        public static jqXHR get(JsString url, JsString data, JsAction<object, string, jqXHR> callback, JsString dataType) { return null; }
        /// <summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        /// </summary>
        public static jqXHR getJSON(JsString url) { return null; }
        /// <summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        /// </summary>
        public static jqXHR getJSON(JsString url, JsAction<object, string, jqXHR> callback) { return null; }
        /// <summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        /// </summary>
        public static jqXHR getJSON(JsString url, object data) { return null; }
        /// <summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        /// </summary>
        public static jqXHR getJSON(JsString url, object data, JsAction<object, string, jqXHR> callback) { return null; }
        /// <summary>
        /// Load a JavaScript file from the server using a GET HTTP request, then execute it.
        /// </summary>
        public static jqXHR getScript(JsString url) { return null; }
        /// <summary>
        /// Load a JavaScript file from the server using a GET HTTP request, then execute it.
        /// </summary>
        public static jqXHR getScript(JsString url, JsAction<JsNumber, HtmlElement> success) { return null; }
        /// <summary>
        /// Execute some JavaScript code globally.
        /// </summary>
        public static void globalEval(JsString code) { }
        /// <summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        /// </summary>
        public static JsArray grep(JsArray array, JsAction<JsNumber, HtmlElement> function) { return null; }
        /// <summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        /// </summary>
        public static JsArray grep(JsArray array, JsAction<JsNumber, HtmlElement> function, bool invert) { return null; }
        /// <summary>
        /// Search for a specified value within an array and return its index (or -1 if not found).
        /// </summary>
        public static JsNumber inArray(object value, JsArray array) { return null; }
        /// <summary>
        /// Determine whether the argument is an array.
        /// </summary>
        public static bool isArray(object obj) { return false; }
        /// <summary>
        /// Check to see if an object is empty (contains no properties).
        /// </summary>
        public static bool isEmptyObject(object @object) { return false; }
        /// <summary>
        /// Determine if the argument passed is a Javascript function object.
        /// </summary>
        public static bool isFunction(object obj) { return false; }
        /// <summary>
        /// Determines whether its argument is a number.
        /// </summary>
        /// <param name="value">The value to be tested.</param>
        /// <returns></returns>
        public static bool isNumeric(object value) { return false; }
        /// <summary>
        /// Check to see if an object is a plain object (created using "{}" or "new object").
        /// </summary>
        public static bool isPlainObject(object @object) { return false; }
        /// <summary>
        /// Determine whether the argument is a window.
        /// </summary>
        public static bool isWindow(object obj) { return false; }
        /// <summary>
        /// Check to see if a DOM node is within an XML document (or is an XML document).
        /// </summary>
        public static bool isXMLDoc(HtmlElement node) { return false; }
        /// <summary>
        /// Convert an array-like object into a true JavaScript array.
        /// </summary>
        public static JsArray makeArray(object obj) { return null; }
        /// <summary>
        /// Translate all items in an array or array-like object to another array of items.
        /// </summary>
        public static JsArray map(JsArray array, JsFunc<object, JsNumber, object> callback) { return null; }
        /// <summary>
        /// Translate all items in an array or array-like object to another array of items.
        /// </summary>
        public static JsArray map(JsArray array, JsFunc<object, object> callback) { return null; }

        /// <summary>
        /// Translate all items in an array or array-like object to another array of items.
        /// </summary>
        public static JsArray<R> map<T, R>(JsArray<T> array, JsFunc<T, JsNumber, R> callback) { return null; }

        /// <summary>
        /// Translate all items in an array or array-like object to another array of items.
        /// </summary>
        public static JsArray<R> map<T, R>(JsArray<T> array, JsFunc<T, R> callback) { return null; }

        //TODO: not full. http://api.jquery.com/jQuery.map/
        /// <summary>
        /// Merge the contents of two arrays together into the first array.
        /// </summary>
        public static JsArray merge(JsArray first, JsArray second) { return null; }
        /// <summary>
        /// Relinquish jQuery's control of the $ variable.
        /// </summary>
        public static object noConflict() { return null; }
        /// <summary>
        /// Relinquish jQuery's control of the $ variable.
        /// </summary>
        /// <param name="removeAll">A Boolean indicating whether to remove all jQuery variables from the global scope (including jQuery itself).</param>
        /// <returns></returns>
        public static object noConflict(bool removeAll) { return null; }
        /// <summary>
        /// An empty function.
        /// </summary>
        public static JsAction noop() { return null; }
        /// <summary>
        /// Return a number representing the current time.
        /// </summary>
        /// <returns></returns>
        public static JsNumber now() { return null; }
        /// <summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request.
        /// </summary>
        public static JsString param(JsArray obj) { return null; }
        /// <summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request.
        /// </summary>
        public static JsString param(object obj) { return null; }
        /// <summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request.
        /// </summary>
        public static JsString param(JsArray obj, bool traditional) { return null; }
        /// <summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request.
        /// </summary>
        public static JsString param(object obj, bool traditional) { return null; }
        /// <summary>
        /// Takes a well-formed JSON string and returns the resulting JavaScript object.
        /// </summary>
        public static JsObject parseJSON(JsString json) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, object data) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, JsAction<object, string, jqXHR> success) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, JsString data) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, object data, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, object data, JsAction<object, string, jqXHR> success) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, JsAction<object, string, jqXHR> success, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, JsString data, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, JsString data, JsAction<object, string, jqXHR> success) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, object data, JsAction<object, string, jqXHR> success, JsString dataType) { return null; }
        /// <summary>
        /// Load data from the server using a HTTP POST request.
        /// </summary>
        public static jqXHR post(JsString url, JsString data, JsAction<object, string, jqXHR> success, JsString dataType) { return null; }
        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        public static JsAction proxy(JsAction function, object context) { return null; }
        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        public static JsAction proxy(object context, JsString name) { return null; }
        /// <summary>
        /// Show the queue of functions to be executed on the matched element.
        /// </summary>
        public static JsArray queue(HtmlElement element) { return null; }
        /// <summary>
        /// Show the queue of functions to be executed on the matched element.
        /// </summary>
        public static JsArray queue(HtmlElement element, JsString queueName) { return null; }
        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        /// </summary>
        public static jQuery queue(HtmlElement element, JsString queueName, JsArray newQueue) { return null; }
        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        /// </summary>
        public static jQuery queue(HtmlElement element, JsString queueName, JsAction callback__) { return null; }
        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        public static jQuery removeData(HtmlElement element) { return null; }
        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        public static jQuery removeData(HtmlElement element, JsString name) { return null; }
        /// <summary>
        /// Remove the whitespace from the beginning and end of a string.
        /// </summary>
        public static JsString trim(JsString str) { return null; }
        /// <summary>
        /// Determine the internal JavaScript [[Class]] of an object.
        /// </summary>
        public static JsString type(object obj) { return null; }
        /// <summary>
        /// Sorts an array of DOM elements, in place, with the duplicates removed. Note that this only works on arrays of DOM elements, not strings or numbers.
        /// </summary>
        public static JsArray unique(JsArray array) { return null; }
        /// <summary>
        /// We recommend against using this property, 
        /// please try to use feature detection instead (see jQuery.support). 
        /// Contains flags for the useragent, read from navigator.userAgent. 
        /// While jQuery.browser will not be removed from future versions of jQuery, 
        /// every effort to use jQuery.support and proper feature detection should be made.
        /// </summary>
        public static jQueryBrowser browser { get; set; }
        /// <summary>
        /// The number of elements in the jQuery object.
        /// </summary>
        public JsNumber length { get; set; }

        /// <summary>
        /// Get the selected elements by index
        /// </summary>
        [JsProperty(NativeIndexer = true)]
        public HtmlElement this[JsNumber index] { get { return null; } }
        /// <summary>
        /// A selector representing selector originally passed to jQuery().
        /// </summary>
        public JsString selector { get; set; }
        /// <summary>
        /// The DOM node context originally passed to jQuery(); if none was passed then context will likely be the document.
        /// </summary>
        public HtmlElement context { get; set; }
        /// <summary>
        /// Deprecated in jQuery 1.3 (see jQuery.support)
        /// . States if the current page, in the user's browser, is being rendered using the W3C CSS Box Model.
        /// </summary>
        public static bool boxModel { get; set; }
        /// <summary>
        /// A collection of properties that represent the presence of different browser features or bugs.
        /// </summary>
        public static JsObject support { get; set; }
#if NET4
        /// <summary>
        /// Gets the internal fn object.
        /// </summary>
        public static dynamic fn { get; private set; }

        /// <summary>
        /// Provides a means to access the jQuery.ui object.
        /// </summary>
        /// <value>The ui object.</value>
        public static dynamic ui { get; private set; }
        public static dynamic @event { get; private set; }
#endif
        public static jQueryFx fx { get; set; }
        /// <summary>
        /// There are two specific use cases for which jQuery.sub() was created. The first was for providing a painless way of overriding jQuery methods without completely destroying the original methods and another was for helping to do encapsulation and basic namespacing for jQuery plugins.
        /// Note that jQuery.sub() doesn't attempt to do any sort of isolation - that's not its intention. All the methods on the sub'd version of jQuery will still point to the original jQuery (events bound and triggered will still be through the main jQuery, data will be bound to elements through the main jQuery, Ajax queries and events will run through the main jQuery, etc.).
        /// Note that if you're looking to use this for plugin development you should first strongly consider using something like the jQuery UI widget factory which manages both state and plugin sub-methods. Some examples of using the jQuery UI widget factory to build a plugin.
        /// The particular use cases of this method can be best described through some examples.
        /// <example>
        /// Adding a method to a jQuery sub so that it isn't exposed externally:
        /// <code>
        /// (function(){
        ///   var sub$ = jQuery.sub();
        ///   sub$.fn.myCustomMethod = function(){
        /// return 'just for me';
        /// };
        /// sub$(document).ready(function() {
        /// sub$('body').myCustomMethod() // 'just for me'
        /// });
        /// })();
        /// typeof jQuery('body').myCustomMethod // undefined
        /// </code>
        /// </example>
        /// Override some jQuery methods to provide new functionality.
        /// <code>
        /// (function() {
        ///  var myjQuery = jQuery.sub();
        ///
        /// myjQuery.fn.remove = function() {
        /// // New functionality: Trigger a remove event
        /// this.trigger("remove");
        ///
        /// // Be sure to call the original jQuery remove method
        /// return jQuery.fn.remove.apply( this, arguments );
        ///};
        ///
        /// myjQuery(function($) {
        /// $(".menu").click(function() {
        /// $(this).find(".submenu").remove();
        /// });
        ///
        /// // A new remove event is now triggered from this copy of jQuery
        /// $(document).bind("remove", function(e) {
        /// $(e.target).parent().hide();
        /// });
        /// });
        /// })();
        ///
        /// // Regular jQuery doesn't trigger a remove event when removing an element
        /// // This functionality is only contained within the modified 'myjQuery'.
        /// </code>
        /// Create a plugin that returns plugin-specific methods.
        /// <code>
        /// (function() {
        ///  // Create a new copy of jQuery using sub()
        ///  var plugin = jQuery.sub();
        ///
        ///  // Extend that copy with the new plugin methods
        ///  plugin.fn.extend({
        ///    open: function() {
        ///      return this.show();
        ///    },
        ///    close: function() {
        ///      return this.hide();
        ///    }
        ///  });
        ///
        ///  // Add our plugin to the original jQuery
        ///  jQuery.fn.myplugin = function() {
        ///    this.addClass("plugin");
        ///
        ///    // Make sure our plugin returns our special plugin version of jQuery
        ///    return plugin( this );
        ///  };
        ///})();
        ///
        ///$(document).ready(function() {
        ///  // Call the plugin, open method now exists
        ///  $('#main').myplugin().open();
        ///
        ///  // Note: Calling just $("#main").open() won't work as open doesn't exist!
        ///});        
        /// </code>
        /// </summary>
        [Obsolete("This method is deprecated as of jQuery 1.7 and will be moved to a plugin in jQuery 1.8.")]
        public static jQuery sub() { return null; }
        /// <summary>
        /// The jQuery.Event constructor is exposed and can be used when calling trigger. The new operator is optional.
        /// Check trigger‘s documentation to see how to combine it with your own event object.
        /// </summary>
        /// <returns></returns>
        public static Event Event(JsString name) { return null; }
        /// <summary>
        /// The jQuery.Event constructor is exposed and can be used when calling trigger. The new operator is optional.
        /// Check trigger‘s documentation to see how to combine it with your own event object.
        /// </summary>
        /// <returns></returns>
        public static Event Event(JsString name, Event props) { return null; }
        /// <summary>
        /// The jQuery.Deferred() constructor creates a new Deferred object. The new operator is optional.
        /// jQuery.Deferred can be passed an optional function, which is called just before the constructor returns and is passed the constructed deferred object as both the this object and as the first argument to the function. The called function can attach callbacks using deferred.then() for example.
        /// A Deferred object starts in the pending state. Any callbacks added to the object with deferred.then(), deferred.done(), or deferred.fail() are queued to be executed later. Calling deferred.resolve() or deferred.resolveWith() transitions the Deferred into the resolved state and immediately executes any doneCallbacks that are set. Calling deferred.reject() or deferred.rejectWith() transitions the Deferred into the rejected state and immediately executes any failCallbacks that are set. Once the object has entered the resolved or rejected state, it stays in that state. Callbacks can still be added to the resolved or rejected Deferred — they will execute immediately.
        /// The Deferred object is chainable, similar to the way a jQuery object is chainable, but it has its own methods. After creating a Deferred object, you can use any of the methods below by either chaining directly from the object creation or saving the object in a variable and invoking one or more methods on that variable.
        /// </summary>
        /// <returns></returns>
        public static Deferred Deferred() { return null; }
        /// <summary>
        /// The jQuery.Deferred() constructor creates a new Deferred object. The new operator is optional.
        /// jQuery.Deferred can be passed an optional function, which is called just before the constructor returns and is passed the constructed deferred object as both the this object and as the first argument to the function. The called function can attach callbacks using deferred.then() for example.
        /// A Deferred object starts in the pending state. Any callbacks added to the object with deferred.then(), deferred.done(), or deferred.fail() are queued to be executed later. Calling deferred.resolve() or deferred.resolveWith() transitions the Deferred into the resolved state and immediately executes any doneCallbacks that are set. Calling deferred.reject() or deferred.rejectWith() transitions the Deferred into the rejected state and immediately executes any failCallbacks that are set. Once the object has entered the resolved or rejected state, it stays in that state. Callbacks can still be added to the resolved or rejected Deferred — they will execute immediately.
        /// The Deferred object is chainable, similar to the way a jQuery object is chainable, but it has its own methods. After creating a Deferred object, you can use any of the methods below by either chaining directly from the object creation or saving the object in a variable and invoking one or more methods on that variable.
        /// </summary>
        /// <returns></returns>
        public static Deferred Deferred(JsAction<Deferred> callback) { return null; }
        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin"</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns></returns>
        public jQuery on(JsString events, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events1"></param>
        /// <param name="events2"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public jQuery on(JsString events1, JsString events2, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin"</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event.
        /// If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false</param>
        /// <returns></returns>
        public jQuery on(JsString events, JsString selector, object data, JsAction<Event> handler) { return null; }
        //TODO: data type?
        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="eventsMap">A map in which the string keys represent one or more space-separated event types and optional namespaces,
        /// and the values represent a handler function to be called for the event(s).</param>
        /// <returns></returns>
        public jQuery on(EventsMap eventsMap) { return null; }
        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="eventsMap"></param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event.
        /// If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <returns></returns>
        public jQuery on(EventsMap eventsMap, JsString selector, object data) { return null; }
        //TODO: data type?

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <returns></returns>
        public jQuery off(JsString events) { return null; }
        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <param name="handler">A handler function previously attached for the event(s), or the special value false.</param>
        /// <returns></returns>
        public jQuery off(JsString events, JsString selector, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="handler">A handler function previously attached for the event(s), or the special value false.</param>
        /// <returns></returns>
        public jQuery off(JsString events, JsAction<Event> handler) { return null; }
        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="eventsMap">A map where the string keys represent one or more space-separated event types and optional namespaces,
        /// and the values represent handler functions previously attached for the event(s).</param>
        /// <returns></returns>
        public jQuery off(EventsMap eventsMap) { return null; }
        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="eventsMap">A map where the string keys represent one or more space-separated event types and optional namespaces,
        /// and the values represent handler functions previously attached for the event(s).</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <returns></returns>
        public jQuery off(EventsMap eventsMap, JsString selector) { return null; }
        //TODO: danel must check all "off" and "on"!

        /// <summary>
        /// Parses a string into an XML document.
        /// </summary>
        /// <param name="data">a well-formed XML string to be parsed</param>
        /// <returns></returns>
        public static HtmlDocument parseXML(JsString data) { return null; }

        public jQuery disableSelection() { return null; }

        #region IEnumerable<HtmlElement> Members

        public IEnumerator<HtmlElement> GetEnumerator()
        {
            for (int i = 0; i < length; i++)
                yield return this[i];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < length; i++)
                yield return this[i];
        }

        #endregion

        /// <summary>
        /// Set to false, to disable the jQuery-UI 1.8 API backward compatibility
        /// </summary>
        public static bool uiBackCompat;
    }

    [JsType(JsMode.Json)]
    public class AnimateOptions
    {
        /// <summary>
        /// A string or number determining how long the animation will run.
        /// </summary>
        [JsProperty(Name = "duration")]
        public JsString durationString { get; set; }
        /// <summary>
        /// A string or number determining how long the animation will run.
        /// </summary>
        public JsNumber duration { get; set; }

        /// <summary>
        /// A string indicating which easing function to use for the transition.
        /// </summary>
        public JsString easing { get; set; }

        /// <summary>
        /// A function to call once the animation is complete.
        /// </summary>
        public JsAction complete { get; set; }

        /// <summary>
        /// A function to be called after each step of the animation.
        /// </summary>
        public JsAction step { get; set; }

        /// <summary>
        /// A Boolean indicating whether to place the animation in the effects queue. If false, the animation will begin immediately.
        /// As of jQuery 1.7, the queue option can also accept a string, in which case the animation is added to the queue represented by that string.
        /// </summary>
        public bool queue { get; set; }

        /// <summary>
        ///  A map of one or more of the CSS properties defined by the properties argument and their corresponding easing functions (added 1.4).
        /// </summary>
        public object specialEasing { get; set; }
    }

    /// <summary>
    /// Tip: you can animate every CSS numeric property.
    /// </summary>
    [JsType(JsMode.Json)]
    public class Map : CssStyleDeclaration
    {
    }

    #endregion
    #region jQueryContext
    [JsType(JsMode.Global, Export = false)]
    public partial class jQueryContext : HtmlContext
    {
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(object obj) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(HtmlElement element) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsArray elementArray) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(jQuery jQuery_object) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J() { return null; }
        /// <summary>
        /// Creates DOM elements on the fly from the provided string of raw HTML.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsString html, HtmlDocument ownerDocument) { return null; }
        /// <summary>
        /// Creates DOM elements on the fly from the provided string of raw HTML.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsString html, object props) { return null; }
        /// <summary>
        /// Binds a function to be executed when the DOM has finished loading.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsAction callback) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsString selector, HtmlElement context) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsString selector, jQuery context) { return null; }
        /// <summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        /// </summary>
        [JsMethod(Name = "$")]
        public static jQuery J(JsString selector) { return null; }
    }

    #endregion
    #region jQueryBrowser
    [JsType(JsMode.Json)]
    public partial class jQueryBrowser
    {
        public bool webkit { get; set; }
        public bool safari { get; set; }
        public bool msie { get; set; }
        public bool opera { get; set; }
        public bool mozilla { get; set; }
        public bool chrome { get; set; }
        public JsString version { get; set; }
    }

    #endregion
    #region jQueryFx

    [JsType(JsMode.Json, Export = false)]
    public partial class jQueryFx
    {
        /// <summary>
        /// The rate (in milliseconds) at which animations fire.
        /// </summary>
        public JsNumber interval { get; set; }
        /// <summary>
        /// Globally disable all animations.
        /// </summary>
        public bool off { get; set; }
    }

    #endregion
    #region jqXHR
    /// <summary>
    ///The jQuery XMLHttpRequest (jqXHR) object returned by $.ajax() as of jQuery 1.5 is a superset of the browser's native XMLHttpRequest object. For example, it contains responseText and responseXML properties, as well as a getResponseHeader() method. When the transport mechanism is something other than XMLHttpRequest (for example, a script tag for a JSONP request) the jqXHR object simulates native XHR functionality where possible.    
    ///The jqXHR objects returned by $.ajax() as of jQuery 1.5 implement the Promise interface, giving them all the properties, methods, and behavior of a Promise (see Deferred object for more information). For convenience and consistency with the callback names used by $.ajax(), jqXHR also provides .error(), .success(), and .complete() methods. These methods take a function argument that is called when the $.ajax() request terminates, and the function receives the same arguments as the correspondingly-named $.ajax() callback. This allows you to assign multiple callbacks on a single request, and even to assign callbacks after the request may have completed. (If the request is already complete, the callback is fired immediately.)
    ///<seealso cref="M:SharpKit.jQuery.jQuery.ajax"/>
    ///<seealso cref="M:SharpKit.jQuery.AjaxSettings"/>
    /// </summary>
    [JsType(JsMode.Json)]
    public class jqXHR : Promise
    {
        /// <summary>
        /// Retrieves the response body as a string.
        /// </summary>
        public JsString responseText { get; private set; }
        /// <summary>
        /// Retrieves the current state of the request operation.
        /// </summary>
        public JsNumber readyState { get; private set; }
        /// <summary>
        /// Retrieves the HTTP status code of the request.
        /// </summary>
        public JsNumber status { get; private set; }
        /// <summary>
        /// Retrieves the friendly HTTP status of the request.
        /// </summary>
        public JsString statusText { get; private set; }
        /// <summary>
        /// Adds custom HTTP headers to the request which departs from the standard by replacing the old value with the new one rather than concatenating the new value to the old one
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void setRequestHeader(string name, string value) { }
        /// <summary>
        /// Cancels the current HTTP request.
        /// </summary>
        public void abort() { }
        /// <summary>
        /// Retrieves all response headers in a single string
        /// </summary>
        /// <returns></returns>
        public JsString getAllResponseHeaders() { return null; }
        /// <summary>
        /// Retrieves a response header value by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public JsString getResponseHeader(string name) { return null; }

        /// <summary>
        /// As of jQuery 1.5.1, the jqXHR object also contains the overrideMimeType() method (it was available in jQuery 1.4.x, as well, but was temporarily removed in jQuery 1.5). The .overrideMimeType() method may be used in the beforeSend() callback function, for example, to modify the response content-type header:
        /// </summary>
        /// <example>
        ///<code>
        ///jQuery.ajax(new AjaxSettings
        ///{
        ///  url= "http://fiddle.jshell.net/favicon.png",
        ///  beforeSend = xhr => xhr.overrideMimeType("text/plain; charset=x-user-defined"),
        ///}).done(data => console.log("Sample of data:", data.slice(0, 100)));
        /// </code>
        ///</example>
        public void overrideMimeType(JsString mimeType) { }
    }
    #endregion
    #region AjaxSettings

    [JsType(JsMode.Json)]
    public partial class AjaxSettings
    {
        /// <summary>
        /// Default: depends on DataType
        ///The content type sent in the request header that tells the server what kind of response it will accept in return. If the accepts setting needs modification, it is recommended to do so once in the $.ajaxSetup() method.
        /// </summary>
        public object accepts { get; set; }
        /// <summary>
        /// Default: true
        /// By default, all requests are sent asynchronously (i.e. this is set to true by default). If you need synchronous requests, set this option to false. Cross-domain requests and dataType: "jsonp" requests do not support synchronous operation. Note that synchronous requests may temporarily lock the browser, disabling any actions while the request is active.
        /// </summary>
        public bool @async { get; set; }
        /// <summary>
        /// Data to be sent to the server. It is converted to a query string, if not already a string. It's appended to the url for GET-requests. See processData option to prevent this automatic processing. object must be Key/Value pairs. If value is an Array, jQuery serializes multiple values with same key based on the value of the traditional setting (described below).
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// A pre-request callback function that can be used to modify the jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object before it is sent. Use this to set custom headers, etc. The jqXHR and settings maps are passed as arguments. This is an Ajax Event. Returning false in the beforeSend function will cancel the request. As of jQuery 1.5, the beforeSend option will be called regardless of the type of request.
        /// </summary>
        public JsAction<jqXHR, AjaxSettings> beforeSend { get; set; }
        /// <summary>
        /// Default: true, false for dataType 'script' and 'jsonp'
        /// If set to false, it will force requested pages not to be cached by the browser. Setting cache to false also appends a query string parameter, "_=[TIMESTAMP]", to the URL.
        /// </summary>
        public bool cache { get; set; }
        /// <summary>
        /// A function to be called when the request finishes (after success and error callbacks are executed). The function gets passed two arguments: The jqXHR (in jQuery 1.4.x, XMLHTTPRequest) object and a string categorizing the status of the request ("success", "notmodified", "error", "timeout", "abort", or "parsererror"). As of jQuery 1.5, the complete setting can accept an array of functions. Each function will be called in turn. This is an Ajax Event
        /// </summary>
        public JsAction<jqXHR, AjaxStatus> complete { get; set; }
        /// <summary>
        /// A map of string/regular-expression pairs that determine how jQuery will parse the response, given its content type.
        /// </summary>
        public object contents { get; set; }
        /// <summary>
        /// Default: 'application/x-www-form-urlencoded'
        /// When sending data to the server, use this content-type. Default is "application/x-www-form-urlencoded", which is fine for most cases. If you explicitly pass in a content-type to $.ajax() then it'll always be sent to the server (even if no data is sent). Data will always be transmitted to the server using UTF-8 charset; you must decode this appropriately on the server side.
        /// </summary>
        public JsString contentType { get; set; }
        /// <summary>
        /// This object will be made the context of all Ajax-related callbacks. By default, the context is an object that represents the ajax settings used in the call ($.ajaxSettings merged with the settings passed to $.ajax). For example specifying a DOM element as the context will make that the context for the complete callback of a request, like so:
        /// <code>
        /// $.ajax({url: "test.html",context: document.body,success: function(){$(this).addClass("done");}});
        /// </code>
        /// </summary>
        public object context { get; set; }
        /// <summary>
        /// Default: {"* text": window.String, "text html": true, "text json": jQuery.parseJSON, "text xml": jQuery.parseXML}
        /// A map of dataType-to-dataType converters. Each converter's value is a function that returns the transformed value of the response.
        /// </summary>
        public object converters { get; set; }
        /// <summary>
        /// Default: false for same-domain requests, true for cross-domain requests
        ///If you wish to force a crossDomain request (such as JSONP) on the same domain, set the value of crossDomain to true. This allows, for example, server-side redirection to another domain
        /// </summary>
        public bool crossDomain { get; set; }
        /// <summary>
        /// A function to be used to handle the raw response data of XMLHttpRequest.This is a pre-filtering function to sanitize the response. You should return the sanitized data. The function accepts two arguments: The raw data returned from the server and the 'dataType' parameter.
        /// </summary>
        public JsFunc<object, JsString, JsString> dataFilter { get; set; }
        /// <summary>
        /// Default: Intelligent Guess (xml, json, script, or html)
        /// The type of data that you're expecting back from the server. If none is specified, jQuery will try to infer it based on the MIME type of the response (an XML MIME type will yield XML, in 1.4 JSON will yield a JavaScript object, in 1.4 script will execute the script, and anything else will be returned as a string). The available types (and the result passed as the first argument to your success callback) are:
        /// "xml": Returns a XML document that can be processed via jQuery.
        /// "html": Returns HTML as plain text; included script tags are evaluated when inserted in the DOM.
        /// "script": Evaluates the response as JavaScript and returns it as plain text. Disables caching by appending a query string parameter, "_=[TIMESTAMP]", to the URL unless the cache option is set to true. Note: This will turn POSTs into GETs for remote-domain requests.
        /// "json": Evaluates the response as JSON and returns a JavaScript object. In jQuery 1.4 the JSON data is parsed in a strict manner; any malformed JSON is rejected and a parse error is thrown. (See json.org for more information on proper JSON formatting.)
        /// "jsonp": Loads in a JSON block using JSONP. Adds an extra "?callback=?" to the end of your URL to specify the callback. Disables caching by appending a query string parameter, "_=[TIMESTAMP]", to the URL unless the cache option is set to true.
        /// "text": A plain text string.
        /// multiple, space-separated values: As of jQuery 1.5, jQuery can convert a dataType from what it received in the Content-Type header to what you require. For example, if you want a text response to be treated as XML, use "text xml" for the dataType. You can also make a JSONP request, have it received as text, and interpreted by jQuery as XML: "jsonp text xml." Similarly, a shorthand string such as "jsonp xml" will first attempt to convert from jsonp to xml, and, failing that, convert from jsonp to text, and then from text to xml.
        /// </summary>
        public JsString dataType { get; set; }
        /// <summary>
        /// A function to be called if the request fails. The function receives three arguments: The jqXHR (in jQuery 1.4.x, XMLHttpRequest) object, a string describing the type of error that occurred and an optional exception object, if one occurred. Possible values for the second argument (besides null) are "timeout", "error", "abort", and "parsererror". When an HTTP error occurs, errorThrown receives the textual portion of the HTTP status, such as "Not Found" or "Internal Server Error." As of jQuery 1.5, the error setting can accept an array of functions. Each function will be called in turn. Note: This handler is not called for cross-domain script and JSONP requests. This is an Ajax Event.
        /// </summary>
        public JsAction<jqXHR, JsString, JsError> error { get; set; }
        /// <summary>
        /// Default: true
        /// Whether to trigger global Ajax event handlers for this request. The default is true. Set to false to prevent the global handlers like ajaxStart or ajaxStop from being triggered. This can be used to control various Ajax Events
        /// </summary>
        public bool global { get; set; }
        /// <summary>
        /// Default: {}
        ///A map of additional header key/value pairs to send along with the request. This setting is set before the beforeSend function is called; therefore, any values in the headers setting can be overwritten from within the beforeSend function.
        /// </summary>
        public object headers { get; set; }
        /// <summary>
        /// Default: false
        /// Allow the request to be successful only if the response has changed since the last request. This is done by checking the Last-Modified header. Default value is false, ignoring the header. In jQuery 1.4 this technique also checks the 'etag' specified by the server to catch unmodified data
        /// </summary>
        public bool ifModified { get; set; }
        /// <summary>
        /// Default: depends on current location protocol
        ///Allow the current environment to be recognized as "local," (e.g. the filesystem), even if jQuery does not recognize it as such by default. The following protocols are currently recognized as local: file, *-extension, and widget. If the isLocal setting needs modification, it is recommended to do so once in the $.ajaxSetup() method.
        /// </summary>
        public bool isLocal { get; set; }
        /// <summary>
        /// Override the callback function name in a jsonp request. This value will be used instead of 'callback' in the 'callback=?' part of the query string in the url. So {jsonp:'onJSONPLoad'} would result in 'onJSONPLoad=?' passed to the server. As of jQuery 1.5, setting the jsonp option to false prevents jQuery from adding the "?callback" string to the URL or attempting to use "=?" for transformation. In this case, you should also explicitly set the jsonpCallback setting. For example, { jsonp: false, jsonpCallback: "callbackName" }
        /// </summary>
        public JsString jsonp { get; set; }
        /// <summary>
        /// Specify the callback function name for a JSONP request. This value will be used instead of the random name automatically generated by jQuery. It is preferable to let jQuery generate a unique name as it'll make it easier to manage the requests and provide callbacks and error handling. You may want to specify the callback when you want to enable better browser caching of GET requests. As of jQuery 1.5, you can also use a function for this setting, in which case the value of jsonpCallback is set to the return value of that function.
        /// </summary>
        public JsAction jsonpCallback { get; set; }
        /// <summary>
        /// A mime type to override the XHR mime type.
        /// </summary>
        public JsString mimeType { get; set; }
        /// <summary>
        /// A password to be used in response to an HTTP access authentication request.
        /// </summary>
        public JsString password { get; set; }
        /// <summary>
        /// Default: true
        /// By default, data passed in to the data option as an object (technically, anything other than a string) will be processed and transformed into a query string, fitting to the default content-type "application/x-www-form-urlencoded". If you want to send a DOMDocument, or other non-processed data, set this option to false
        /// </summary>
        public bool processData { get; set; }
        /// <summary>
        /// Only for requests with "jsonp" or "script" dataType and "GET" type. Forces the request to be interpreted as a certain charset. Only needed for charset differences between the remote and local content.
        /// </summary>
        public JsString scriptCharset { get; set; }
        /// <summary>
        /// Default: {}
        ///A map of numeric HTTP codes and functions to be called when the response has the corresponding code. 
        /// </summary>
        /// <example>
        /// the following will alert when the response status is a 404:
        /// <code>
        /// $.ajax({statusCode: {404: function() {alert('page not found');}}});
        /// </code>
        /// <list type="note">
        /// If the request is successful, the status code functions take the same parameters as the success callback; if it results in an error, they take the same parameters as the error callback.
        /// </list>
        /// </example>
        public object statusCode { get; set; }
        /// <summary>
        /// A function to be called if the request succeeds. The function gets passed three arguments: The data returned from the server, formatted according to the dataType parameter; a string describing the status; and the jqXHR (in jQuery 1.4.x, XMLHttpRequest) object. As of jQuery 1.5, the success setting can accept an array of functions. Each function will be called in turn. This is an Ajax Event.
        /// </summary>
        public JsAction<object, JsString, jqXHR> success { get; set; }
        /// <summary>
        /// Set a local timeout (in milliseconds) for the request. This will override the global timeout, if one is set with $.ajaxSetup(). For example, you could use this property to give a single request a longer timeout than all other requests that you've set to time out in one second. See $.ajaxSetup() for global timeouts. In jQuery 1.4.x and below, please note that the XMLHttpRequest object will be in an invalid state should the request time out. Where this is the case, accessing any object members may result in an exception being thrown. In jQuery 1.5.2 and above,$.ajax() does not handle JSONP requests as expected should the request fail due to a timeout in Firefox 3.0+. This is a browser-based issue due to FF currently not providing a way to abort cross-domain requests once the script tag has been appended. This issue does not currently affect other browsers.
        /// </summary>
        public JsNumber timeout { get; set; }
        /// <summary>
        /// Set this to true if you wish to use the traditional style of param serialization.
        /// </summary>
        public bool traditional { get; set; }
        /// <summary>
        /// Default: 'GET'
        /// The type of request to make ("POST" or "GET"), default is "GET". Note: Other HTTP request methods, such as PUT and DELETE, can also be used here, but they are not supported by all browsers.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// Default: The current page
        /// A string containing the URL to which the request is sent.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        /// A username to be used in response to an HTTP access authentication request.
        /// </summary>
        public JsString username { get; set; }
        /// <summary>
        /// Default: ActiveXObject when available (IE), the XMLHttpRequest otherwise
        /// Callback for creating the XMLHttpRequest object. Defaults to the ActiveXObject when available (IE), the XMLHttpRequest otherwise. Override to provide your own implementation for XMLHttpRequest or enhancements to the factory.
        /// </summary>
        public JsAction xhr { get; set; }
        /// <summary>
        /// A map of fieldName-fieldValue pairs to set on the native XHR object. For example, you can use it to set withCredentials to true for cross-domain requests if needed.
        /// </summary>
        /// <example>
        /// <code>
        /// $.ajax({url: a_cross_domain_url,xhrFields: {withCredentials: true}});
        /// </code>
        /// <list type=">bullet">
        /// In jQuery 1.5, the withCredentials property was not propagated to the native XHR and thus CORS requests requiring it would ignore this flag. For this reason, we recommend using jQuery 1.5.1+ should you require the use of it.
        /// </list>
        /// </example>
        public object xhrFields { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum AjaxStatus
    {
        success,
        notmodified,
        error,
        timeout,
        abort,
        parsererror,
    }
    #endregion
    #region Event
    [JsType(JsMode.Prototype, Export = false, Name = "jQuery.Event")]
    public partial class Event
    {
        public Event(JsString type, object props) { }
        public Event(JsString type) { }
        /// <summary>
        /// Returns whether event.stopImmediatePropagation() was ever called on this event object.
        /// </summary>
        public bool isImmediatePropagationStopped() { return false; }
        /// <summary>
        /// Keeps the rest of the handlers from being executed and prevents the event from bubbling up the DOM tree.
        /// </summary>
        public void stopImmediatePropagation() { }
        /// <summary>
        /// Returns whether event.stopPropagation() was ever called on this event object.
        /// </summary>
        public bool isPropagationStopped() { return false; }
        /// <summary>
        /// Prevents the event from bubbling up the DOM tree, preventing any parent handlers from being notified of the event.
        /// </summary>
        public void stopPropagation() { }
        /// <summary>
        /// Returns whether event.preventDefault() was ever called on this event object.
        /// </summary>
        public bool isDefaultPrevented() { return false; }
        /// <summary>
        /// If this method is called, the default action of the event will not be triggered.
        /// </summary>
        public void preventDefault() { }
        /// <summary>
        /// The namespace specified when the event was triggered.
        /// </summary>
        public JsString @namespace { get; set; }
        /// <summary>
        /// The difference in milliseconds between the time an event is triggered and January 1, 1970.
        /// </summary>
        public JsNumber timeStamp { get; set; }
        /// <summary>
        /// The last value returned by an event handler that was triggered by this event, unless the value was undefined.
        /// </summary>
        public object result { get; set; }
        /// <summary>
        /// For key or button events, this attribute indicates the specific button or key that was pressed.
        /// </summary>
        public JsNumber which { get; set; }
        /// <summary>
        /// The mouse position relative to the top edge of the document.
        /// </summary>
        public JsNumber pageY { get; set; }
        /// <summary>
        /// The mouse position relative to the left edge of the document.
        /// </summary>
        public JsNumber pageX { get; set; }
        /// <summary>
        /// The current DOM element within the event bubbling phase.
        /// </summary>
        public HtmlElement currentTarget { get; set; }
        /// <summary>
        /// The other DOM element involved in the event, if any.
        /// </summary>
        public HtmlElement relatedTarget { get; set; }
        /// <summary>
        /// The optional data passed to jQuery.fn.bind when the current executing handler was bound.
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// The element where the currently-called jQuery event handler was attached.
        /// </summary>
        public object delegateTarget { get; set; }
        /// <summary>
        /// The DOM element that initiated the event.
        /// </summary>
        public HtmlElement target { get; set; }
        /// <summary>
        /// Describes the nature of the event.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// Certain native events may have special properties that can be accessed as properties of the event.originalEvent object. To make special properties available in all event objects, we can add them to the jQuery.event.props array.
        /// </summary>
        public DOMEvent originalEvent { get; set; }

        public JsBoolean altKey { get; set; }
        public object attrChange { get; set; }
        public JsString attrName { get; set; }

        public JsBoolean bubbles { get; set; }
        public object button { get; set; }
        public JsBoolean cancelable { get; set; }
        public JsNumber charCode { get; set; }
        public JsNumber clientX { get; set; }
        public JsNumber clientY { get; set; }
        public JsBoolean ctrlKey { get; set; }

        public object detail { get; set; }
        public JsString eventPhase { get; set; }
        public HtmlElement fromElement { get; set; }
        public object handler { get; set; }
        public JsNumber keyCode { get; set; }
        public JsNumber layerX { get; set; }
        public JsNumber layerY { get; set; }
        public object metaKey { get; set; }
        public object newValue { get; set; }
        public JsNumber offsetX { get; set; }
        public JsNumber offsetY { get; set; }
        public object originalTarget { get; set; }
        public object prevValue { get; set; }
        public object relatedNode { get; set; }

        public JsNumber screenX { get; set; }
        public JsNumber screenY { get; set; }
        public JsBoolean shiftKey { get; set; }
        public HtmlElement srcElement { get; set; }

        public HtmlElement toElement { get; set; }
        public object view { get; set; }
        public JsNumber wheelDelta { get; set; }

    }
    #endregion
    #region EventsMap


    [JsType(JsMode.Json)]
    public class EventsMap
    {
        //Keyboard Events
        public JsAction<Event> focusin { get; set; }
        public JsAction<Event> focusout { get; set; }
        public JsAction<Event> keydown { get; set; }
        public JsAction<Event> keypress { get; set; }
        public JsAction<Event> keyup { get; set; }
        //Mouse Events
        public JsAction<Event> click { get; set; }
        public JsAction<Event> dblclick { get; set; }
        public JsAction<Event> hover { get; set; }
        public JsAction<Event> mousedown { get; set; }
        public JsAction<Event> mouseenter { get; set; }
        public JsAction<Event> mouseleave { get; set; }
        public JsAction<Event> mousemove { get; set; }
        public JsAction<Event> mouseout { get; set; }
        public JsAction<Event> mouseover { get; set; }
        public JsAction<Event> mouseup { get; set; }
        public JsAction<Event> toggle { get; set; }
        //browser events
        public JsAction<Event> error { get; set; }
        public JsAction<Event> resize { get; set; }
        public JsAction<Event> scroll { get; set; }
    }
    #endregion
    #region Deferred

    /// <summary>
    /// jQuery.Deferred(), introduced in version 1.5, is a chainable utility object that can register multiple callbacks into callback queues, invoke callback queues, and relay the success or failure state of any synchronous or asynchronous function.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "jQuery.Deferred", Export = false)]
    public partial class Deferred : Deferred<object, object>
    {
        /// <summary>
        /// The jQuery.Deferred() constructor creates a new Deferred object. The new operator is optional.
        /// jQuery.Deferred can be passed an optional function, which is called just before the constructor returns and is passed the constructed deferred object as both the this object and as the first argument to the function. The called function can attach callbacks using deferred.then() for example.
        /// A Deferred object starts in the pending state. Any callbacks added to the object with deferred.then(), deferred.done(), or deferred.fail() are queued to be executed later. Calling deferred.resolve() or deferred.resolveWith() transitions the Deferred into the resolved state and immediately executes any doneCallbacks that are set. Calling deferred.reject() or deferred.rejectWith() transitions the Deferred into the rejected state and immediately executes any failCallbacks that are set. Once the object has entered the resolved or rejected state, it stays in that state. Callbacks can still be added to the resolved or rejected Deferred — they will execute immediately.
        /// The Deferred object is chainable, similar to the way a jQuery object is chainable, but it has its own methods. After creating a Deferred object, you can use any of the methods below by either chaining directly from the object creation or saving the object in a variable and invoking one or more methods on that variable.
        /// </summary>
        public Deferred()
        {
        }
        /// <summary>
        /// Reject a Deferred object and call any failCallbacks with the given args.
        /// <list type="bullet">
        /// Normally, only the creator of a Deferred should call this method; you can prevent other code from changing the Deferred's state by returning a restricted Promise object through deferred.promise().
        /// </list>
        /// <list type="bullet">
        /// When the Deferred is rejected, any failCallbacks added by deferred.then or deferred.fail are called. Callbacks are executed in the order they were added. Each callback is passed the args from the deferred.reject() call. Any failCallbacks added after the Deferred enters the rejected state are executed immediately when they are added, using the arguments that were passed to the .reject() call. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="args">
        /// args Optional arguments that are passed to the failCallbacks.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred reject(params object[] args) { return null; }
        /// <summary>
        ///  Reject a Deferred object and call any failCallbacks with the given context and args.
        ///  <list type="bullet">
        ///  Normally, only the creator of a Deferred should call this method; you can prevent other code from changing the Deferred's state by returning a restricted Promise object through deferred.promise().
        ///  </list>
        ///  <list type="bullet">
        ///  When the Deferred is rejected, any failCallbacks added by deferred.then or deferred.fail are called. Callbacks are executed in the order they were added. Each callback is passed the args from the deferred.reject() call. Any failCallbacks added after the Deferred enters the rejected state are executed immediately when they are added, using the arguments that were passed to the .reject() call. For more information, see the documentation for Deferred object.
        ///  </list>
        /// </summary>
        /// <param name="context">
        /// context Context passed to the failCallbacks as the this object.
        /// </param>
        /// <param name="args">
        /// args An optional array of arguments that are passed to the failCallbacks.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred rejectWith(object context, params object[] args) { return null; }
        /// <summary>
        /// Resolve a Deferred object and call any doneCallbacks with the given args.
        /// <list type="bullet">
        /// When the Deferred is resolved, any doneCallbacks added by deferred.then or deferred.done are called. Callbacks are executed in the order they were added. Each callback is passed the args from the .resolve(). Any doneCallbacks added after the Deferred enters the resolved state are executed immediately when they are added, using the arguments that were passed to the .resolve() call. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="args">
        /// args Optional arguments that are passed to the doneCallbacks.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred resolve(params object[] args) { return null; }
        /// <summary>
        /// Resolve a Deferred object and call any doneCallbacks with the given context and args.
        /// <list type="bullet">
        /// Normally, only the creator of a Deferred should call this method; you can prevent other code from changing the Deferred's state by returning a restricted Promise object through deferred.promise().
        /// </list>
        /// <list type="bullet">
        /// When the Deferred is resolved, any doneCallbacks added by deferred.then or deferred.done are called. Callbacks are executed in the order they were added. Each callback is passed the args from the .resolve(). Any doneCallbacks added after the Deferred enters the resolved state are executed immediately when they are added, using the arguments that were passed to the .resolve() call. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="context">
        /// context Context passed to the doneCallbacks as the this object.
        /// </param>
        /// <param name="args">
        /// args An optional array of arguments that are passed to the doneCallbacks.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred resolveWith(object context, params object[] args) { return null; }


    }

    /// <summary>
    /// jQuery.Deferred(), introduced in version 1.5, is a chainable utility object that can register multiple callbacks into callback queues, invoke callback queues, and relay the success or failure state of any synchronous or asynchronous function.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "jQuery.Deferred", Export = false)]
    public partial class Deferred<T, E> : Promise<T, E>
    {
        /// <summary>
        /// The jQuery.Deferred() constructor creates a new Deferred object. The new operator is optional.
        /// jQuery.Deferred can be passed an optional function, which is called just before the constructor returns and is passed the constructed deferred object as both the this object and as the first argument to the function. The called function can attach callbacks using deferred.then() for example.
        /// A Deferred object starts in the pending state. Any callbacks added to the object with deferred.then(), deferred.done(), or deferred.fail() are queued to be executed later. Calling deferred.resolve() or deferred.resolveWith() transitions the Deferred into the resolved state and immediately executes any doneCallbacks that are set. Calling deferred.reject() or deferred.rejectWith() transitions the Deferred into the rejected state and immediately executes any failCallbacks that are set. Once the object has entered the resolved or rejected state, it stays in that state. Callbacks can still be added to the resolved or rejected Deferred — they will execute immediately.
        /// The Deferred object is chainable, similar to the way a jQuery object is chainable, but it has its own methods. After creating a Deferred object, you can use any of the methods below by either chaining directly from the object creation or saving the object in a variable and invoking one or more methods on that variable.
        /// </summary>
        public Deferred()
        {
        }
        /// <summary>
        /// Return a Deferred's Promise object.
        /// </summary>
        /// <returns>
        /// Returns: Promise
        /// </returns>
        /// <note>
        /// The deferred.promise() method allows an asynchronous function to prevent other code from interfering with the progress or status of its internal request. The Promise exposes only the Deferred methods needed to attach additional handlers or determine the state (then, done, fail, isResolved, and isRejected), but not ones that change the state (resolve, reject, resolveWith, and rejectWith). As of jQuery 1.6, the Promise also exposes the always and pipe Deferred methods.
        /// If target is provided, deferred.promise() will attach the methods onto it and then return this object rather than create a new one. This can be useful to attach the Promise behavior to an object that already exists.
        /// If you are creating a Deferred, keep a reference to the Deferred so that it can be resolved or rejected at some point. Return only the Promise object via deferred.promise() so other code can register callbacks or inspect the current state.
        /// </note>
        /// <example>
        /// Create a Deferred and set two timer-based functions to either resolve or reject the Deferred after a random interval. Whichever one fires first "wins" and will call one of the callbacks. The second timeout has no effect since the Deferred is already complete (in a resolved or rejected state) from the first timeout action.
        /// <code>
        /// //Create a Deferred and return its Promise
        /// function asyncEvent(){var dfd = new jQuery.Deferred();setTimeout(function(){dfd.resolve("hurray");}, Math.floor(Math.random()*1500));setTimeout(function(){dfd.reject("sorry");}, Math.floor(Math.random()*1500));return dfd.promise();}
        /// // Attach a done and fail handler for the asyncEvent
        /// $.when( asyncEvent() ).then(function(status){alert( status+', things are going well' );},function(status){alert( status+', you fail this time' );});
        /// </code>
        /// Use the target argument to promote an existing object to a Promise:
        /// <code>
        /// //Existing object
        /// var obj = {hello: function( name ) {alert( "Hello " + name );}},
        /// //Create a Deferred
        /// defer = $.Deferred();
        /// //Set object as a promise
        /// defer.promise( obj );
        /// // Resolve the deferred
        /// defer.resolve( "John" );
        /// // Use the object as a Promise
        /// obj.done(function( name ) {obj.hello( name ); // will alert "Hello John"}).hello( "Karl" ); // will alert "Hello Karl"
        /// </code>
        /// </example>
        public Promise<T, E> promise() { return null; }
        /// <summary>
        /// Return a Deferred's Promise object.
        /// </summary>
        /// <param name="target">
        /// targetObject onto which the promise methods have to be attached
        /// </param>
        /// <returns>
        /// Returns: Promise
        /// </returns>
        /// <note>
        /// The deferred.promise() method allows an asynchronous function to prevent other code from interfering with the progress or status of its internal request. The Promise exposes only the Deferred methods needed to attach additional handlers or determine the state (then, done, fail, isResolved, and isRejected), but not ones that change the state (resolve, reject, resolveWith, and rejectWith). As of jQuery 1.6, the Promise also exposes the always and pipe Deferred methods.
        /// If target is provided, deferred.promise() will attach the methods onto it and then return this object rather than create a new one. This can be useful to attach the Promise behavior to an object that already exists.
        /// If you are creating a Deferred, keep a reference to the Deferred so that it can be resolved or rejected at some point. Return only the Promise object via deferred.promise() so other code can register callbacks or inspect the current state.
        /// </note>
        /// <example>
        /// Create a Deferred and set two timer-based functions to either resolve or reject the Deferred after a random interval. Whichever one fires first "wins" and will call one of the callbacks. The second timeout has no effect since the Deferred is already complete (in a resolved or rejected state) from the first timeout action.
        /// <code>
        /// //Create a Deferred and return its Promise
        /// function asyncEvent(){var dfd = new jQuery.Deferred();setTimeout(function(){dfd.resolve("hurray");}, Math.floor(Math.random()*1500));setTimeout(function(){dfd.reject("sorry");}, Math.floor(Math.random()*1500));return dfd.promise();}
        /// // Attach a done and fail handler for the asyncEvent
        /// $.when( asyncEvent() ).then(function(status){alert( status+', things are going well' );},function(status){alert( status+', you fail this time' );});
        /// </code>
        /// Use the target argument to promote an existing object to a Promise:
        /// <code>
        /// //Existing object
        /// var obj = {hello: function( name ) {alert( "Hello " + name );}},
        /// //Create a Deferred
        /// defer = $.Deferred();
        /// //Set object as a promise
        /// defer.promise( obj );
        /// // Resolve the deferred
        /// defer.resolve( "John" );
        /// // Use the object as a Promise
        /// obj.done(function( name ) {obj.hello( name ); // will alert "Hello John"}).hello( "Karl" ); // will alert "Hello Karl"
        /// </code>
        /// </example>
        public Promise<T, E> promise(object target) { return null; }
        /// <summary>
        /// Reject a Deferred object and call any failCallbacks with the given args.
        /// <list type="bullet">
        /// Normally, only the creator of a Deferred should call this method; you can prevent other code from changing the Deferred's state by returning a restricted Promise object through deferred.promise().
        /// </list>
        /// <list type="bullet">
        /// When the Deferred is rejected, any failCallbacks added by deferred.then or deferred.fail are called. Callbacks are executed in the order they were added. Each callback is passed the args from the deferred.reject() call. Any failCallbacks added after the Deferred enters the rejected state are executed immediately when they are added, using the arguments that were passed to the .reject() call. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="error"></param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred<T, E> reject(E error) { return null; }
        /// <summary>
        ///  Reject a Deferred object and call any failCallbacks with the given context and args.
        ///  <list type="bullet">
        ///  Normally, only the creator of a Deferred should call this method; you can prevent other code from changing the Deferred's state by returning a restricted Promise object through deferred.promise().
        ///  </list>
        ///  <list type="bullet">
        ///  When the Deferred is rejected, any failCallbacks added by deferred.then or deferred.fail are called. Callbacks are executed in the order they were added. Each callback is passed the args from the deferred.reject() call. Any failCallbacks added after the Deferred enters the rejected state are executed immediately when they are added, using the arguments that were passed to the .reject() call. For more information, see the documentation for Deferred object.
        ///  </list>
        /// </summary>
        /// <param name="context">
        /// context Context passed to the failCallbacks as the this object.
        /// </param>
        /// <param name="error">
        /// args An optional array of arguments that are passed to the failCallbacks.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred<T, E> rejectWith(object context, E error) { return null; }
        /// <summary>
        /// Resolve a Deferred object and call any doneCallbacks with the given args.
        /// <list type="bullet">
        /// When the Deferred is resolved, any doneCallbacks added by deferred.then or deferred.done are called. Callbacks are executed in the order they were added. Each callback is passed the args from the .resolve(). Any doneCallbacks added after the Deferred enters the resolved state are executed immediately when they are added, using the arguments that were passed to the .resolve() call. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="result">
        /// args Optional arguments that are passed to the doneCallbacks.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred<T, E> resolve(T result) { return null; }
        /// <summary>
        /// Resolve a Deferred object and call any doneCallbacks with the given context and args.
        /// <list type="bullet">
        /// Normally, only the creator of a Deferred should call this method; you can prevent other code from changing the Deferred's state by returning a restricted Promise object through deferred.promise().
        /// </list>
        /// <list type="bullet">
        /// When the Deferred is resolved, any doneCallbacks added by deferred.then or deferred.done are called. Callbacks are executed in the order they were added. Each callback is passed the args from the .resolve(). Any doneCallbacks added after the Deferred enters the resolved state are executed immediately when they are added, using the arguments that were passed to the .resolve() call. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="context">
        /// context Context passed to the doneCallbacks as the this object.
        /// </param>
        /// <param name="result"></param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        public Deferred<T, E> resolveWith(object context, T result) { return null; }


    }

    #endregion
    #region Promise

    /// <summary>
    /// This object provides a subset of the methods of the Deferred object (then, done, fail, always, pipe. isResolved, and isRejected) to prevent users from changing the state of the Deferred
    /// </summary>
    [JsType(JsMode.Prototype, Export = false)]
    public partial class Promise : Promise<object, object>
    {
    }


    /// <summary>
    /// This object provides a subset of the methods of the Deferred object (then, done, fail, always, pipe. isResolved, and isRejected) to prevent users from changing the state of the Deferred
    /// </summary>
    [JsType(JsMode.Prototype, Export = false)]
    public partial class Promise<T, E>
    {

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="callback">
        /// doneCallbacks A function, or array of functions, that are called when the Deferred is resolved.
        ///doneCallbacks Optional additional functions, or arrays of functions, that are called when the Deferred is resolved.
        /// </param>
        /// <returns>
        /// returns the deferred object
        /// </returns>
        /// <example>
        /// Since the jQuery.get method returns a jqXHR object, which is derived from a Deferred object, we can attach a success callback using the .done() method.
        ///<code>
        ///$.get("test.php").done(function() { alert("$.get succeeded"); });
        ///</code>
        ///Resolve a Deferred object when the user clicks a button, triggering a number of callback functions:
        /// </example>
        public Deferred<T, E> done(JsAction callback) { return null; }
        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="callback">
        /// doneCallbacks A function, or array of functions, that are called when the Deferred is resolved.
        ///doneCallbacks Optional additional functions, or arrays of functions, that are called when the Deferred is resolved.
        /// </param>
        /// <returns>
        /// returns the deferred object
        /// </returns>
        /// <example>
        /// Since the jQuery.get method returns a jqXHR object, which is derived from a Deferred object, we can attach a success callback using the .done() method.
        ///<code>
        ///$.get("test.php").done(function() { alert("$.get succeeded"); });
        ///</code>
        ///Resolve a Deferred object when the user clicks a button, triggering a number of callback functions:
        /// </example>
        public Deferred<T, E> done(JsAction<T> callback) { return null; }
        /// <summary>
        /// Add handlers to be called when the Deferred object is rejected.
        /// </summary>
        /// <param name="callback">
        /// failCallbacks A function, or array of functions, that are called when the Deferred is rejected.
        /// failCallbacks Optional additional functions, or arrays of functions, that are called when the Deferred is rejected.
        /// </param>
        /// <returns>
        /// returns the deferred object.
        /// </returns>
        /// <example>
        /// Since the jQuery.get method returns a jqXHR object, which is derived from a Deferred, you can attach a success and failure callback using the deferred.done() and deferred.fail() methods.
        /// <code>
        /// $.get("test.php").done(function(){ alert("$.get succeeded"); }).fail(function(){ alert("$.get failed!"); });
        /// </code>
        /// </example>
        public Deferred<T, E> fail(JsAction callback) { return null; }
        public Deferred<T, E> fail(JsAction<E> callback) { return null; }
        /// <summary>
        /// Add handlers to be called when the Deferred object is either resolved or rejected.
        /// </summary>
        /// <param name="callback">
        /// The argument can be either a single function or an array of functions. When the Deferred is resolved or rejected, the alwaysCallbacks are called
        /// </param>
        /// <returns>
        /// returns the Deferred object.
        /// </returns>
        /// <example>
        /// Since the jQuery.get() method returns a jqXHR object, which is derived from a Deferred object, we can attach a callback for both success and error using the deferred.always() method.
        ///<code>
        /// $.get("test.php").always( function() { 
        ///   alert("$.get completed with success or error callback arguments");
        ///     } );
        ///</code>
        /// </example>
        public Deferred<T, E> always(JsAction callback) { return null; }
        /// <summary>
        /// Determine whether a Deferred object has been rejected.
        /// </summary>
        /// <returns>
        /// Returns true if the Deferred object is in the rejected state, meaning that either deferred.reject() or deferred.rejectWith() has been called for the object and the failCallbacks have been called (or are in the process of being called).
        /// </returns>
        /// <note>
        /// Note that a Deferred object can be in one of three states: unresolved, resolved, or rejected; use deferred.isResolved() to determine whether the Deferred object is in the resolved state. These methods are primarily useful for debugging, for example to determine whether a Deferred has already been resolved even though you are inside code that intended to reject it.
        /// </note>
        public bool isRejected() { return false; }
        /// <summary>
        /// Determine whether a Deferred object has been resolved.
        /// </summary>
        /// <returns>
        /// Returns true if the Deferred object is in the resolved state, meaning that either deferred.resolve() or deferred.resolveWith() has been called for the object and the doneCallbacks have been called (or are in the process of being called).
        /// </returns>
        ///<note>
        ///Note that a Deferred object can be in one of three states: unresolved, resolved, or rejected; use deferred.isRejected() to determine whether the Deferred object is in the rejected state. These methods are primarily useful for debugging, for example to determine whether a Deferred has already been resolved even though you are inside code that intended to reject it.
        ///</note>
        public bool isResolved() { return false; }
        /// <summary>
        /// Utility method to filter and/or chain Deferreds.
        /// </summary>
        /// <returns>
        /// The deferred.pipe() method returns a new promise that filters the status and values of a deferred through a function. The doneFilter and failFilter functions filter the original deferred's resolved / rejected status and values. These filter functions can return a new value to be passed along to the piped promise's done() or fail() callbacks, or they can return another observable object (Deferred, Promise, etc) which will pass its resolved / rejected status and values to the piped promise's callbacks. If the filter function used is null, or not specified, the piped promise will be resolved or rejected with the same values as the original.
        /// </returns>
        /// <example>
        /// Filter resolve value:
        /// <code>
        /// var defer = $.Deferred(),
        ///     filtered = defer.pipe(function( value ) {
        ///       return value * 2;
        ///     });
        ///
        /// defer.resolve( 5 );
        /// filtered.done(function( value ) {
        ///   alert( "Value is ( 2*5 = ) 10: " + value );
        /// });        
        /// </code>
        /// Filter reject value:
        /// <code>
        /// var defer = $.Deferred(),
        ///    filtered = defer.pipe( null, function( value ) {
        ///      return value * 3;
        ///     });
        ///
        /// defer.reject( 6 );
        /// filtered.fail(function( value ) {
        ///   alert( "Value is ( 3*6 = ) 18: " + value );
        /// });        
        /// </code>
        /// Chain tasks:
        /// <code>
        /// var request = $.ajax( url, { dataType: "json" } ),
        ///     chained = request.pipe(function( data ) {
        ///       return $.ajax( url2, { data: { user: data.userId } } );
        ///     });
        ///
        /// chained.done(function( data ) {
        ///   // data retrieved from url2 as provided by the first request
        /// });        
        /// </code>
        /// </example>
        public Promise<T, E> pipe() { return null; }
        /// <summary>
        /// Utility method to filter and/or chain Deferreds.
        /// </summary>
        /// <param name="doneFilter">
        /// doneFilter An optional function that is called when the Deferred is resolved.
        /// </param>
        /// <returns>
        /// The deferred.pipe() method returns a new promise that filters the status and values of a deferred through a function. The doneFilter and failFilter functions filter the original deferred's resolved / rejected status and values. These filter functions can return a new value to be passed along to the piped promise's done() or fail() callbacks, or they can return another observable object (Deferred, Promise, etc) which will pass its resolved / rejected status and values to the piped promise's callbacks. If the filter function used is null, or not specified, the piped promise will be resolved or rejected with the same values as the original.
        /// </returns>
        /// <example>
        /// Filter resolve value:
        /// <code>
        /// var defer = $.Deferred(),
        ///     filtered = defer.pipe(function( value ) {
        ///       return value * 2;
        ///     });
        ///
        /// defer.resolve( 5 );
        /// filtered.done(function( value ) {
        ///   alert( "Value is ( 2*5 = ) 10: " + value );
        /// });        
        /// </code>
        /// Filter reject value:
        /// <code>
        /// var defer = $.Deferred(),
        ///    filtered = defer.pipe( null, function( value ) {
        ///      return value * 3;
        ///     });
        ///
        /// defer.reject( 6 );
        /// filtered.fail(function( value ) {
        ///   alert( "Value is ( 3*6 = ) 18: " + value );
        /// });        
        /// </code>
        /// Chain tasks:
        /// <code>
        /// var request = $.ajax( url, { dataType: "json" } ),
        ///     chained = request.pipe(function( data ) {
        ///       return $.ajax( url2, { data: { user: data.userId } } );
        ///     });
        ///
        /// chained.done(function( data ) {
        ///   // data retrieved from url2 as provided by the first request
        /// });        
        /// </code>
        /// </example>
        public Promise<T, E> pipe(JsAction doneFilter) { return null; }
        /// <summary>
        /// Utility method to filter and/or chain Deferreds.
        /// </summary>
        /// <param name="doneFilter">
        /// doneFilter An optional function that is called when the Deferred is resolved.
        /// </param>
        /// <param name="failFilter">
        /// failFilter An optional function that is called when the Deferred is rejected.
        /// </param>
        /// <returns>
        /// The deferred.pipe() method returns a new promise that filters the status and values of a deferred through a function. The doneFilter and failFilter functions filter the original deferred's resolved / rejected status and values. These filter functions can return a new value to be passed along to the piped promise's done() or fail() callbacks, or they can return another observable object (Deferred, Promise, etc) which will pass its resolved / rejected status and values to the piped promise's callbacks. If the filter function used is null, or not specified, the piped promise will be resolved or rejected with the same values as the original.
        /// </returns>
        /// <example>
        /// Filter resolve value:
        /// <code>
        /// var defer = $.Deferred(),
        ///     filtered = defer.pipe(function( value ) {
        ///       return value * 2;
        ///     });
        ///
        /// defer.resolve( 5 );
        /// filtered.done(function( value ) {
        ///   alert( "Value is ( 2*5 = ) 10: " + value );
        /// });        
        /// </code>
        /// Filter reject value:
        /// <code>
        /// var defer = $.Deferred(),
        ///    filtered = defer.pipe( null, function( value ) {
        ///      return value * 3;
        ///     });
        ///
        /// defer.reject( 6 );
        /// filtered.fail(function( value ) {
        ///   alert( "Value is ( 3*6 = ) 18: " + value );
        /// });        
        /// </code>
        /// Chain tasks:
        /// <code>
        /// var request = $.ajax( url, { dataType: "json" } ),
        ///     chained = request.pipe(function( data ) {
        ///       return $.ajax( url2, { data: { user: data.userId } } );
        ///     });
        ///
        /// chained.done(function( data ) {
        ///   // data retrieved from url2 as provided by the first request
        /// });        
        /// </code>
        /// </example>
        public Promise<T, E> pipe(JsAction doneFilter, JsAction failFilter) { return null; }
        /// <summary>
        /// Utility method to filter and/or chain Deferreds.
        /// </summary>
        /// <param name="doneFilter">
        /// doneFilter An optional function that is called when the Deferred is resolved.
        /// </param>
        /// <returns>
        /// The deferred.pipe() method returns a new promise that filters the status and values of a deferred through a function. The doneFilter and failFilter functions filter the original deferred's resolved / rejected status and values. These filter functions can return a new value to be passed along to the piped promise's done() or fail() callbacks, or they can return another observable object (Deferred, Promise, etc) which will pass its resolved / rejected status and values to the piped promise's callbacks. If the filter function used is null, or not specified, the piped promise will be resolved or rejected with the same values as the original.
        /// </returns>
        /// <example>
        /// Filter resolve value:
        /// <code>
        /// var defer = $.Deferred(),
        ///     filtered = defer.pipe(function( value ) {
        ///       return value * 2;
        ///     });
        ///
        /// defer.resolve( 5 );
        /// filtered.done(function( value ) {
        ///   alert( "Value is ( 2*5 = ) 10: " + value );
        /// });        
        /// </code>
        /// Filter reject value:
        /// <code>
        /// var defer = $.Deferred(),
        ///    filtered = defer.pipe( null, function( value ) {
        ///      return value * 3;
        ///     });
        ///
        /// defer.reject( 6 );
        /// filtered.fail(function( value ) {
        ///   alert( "Value is ( 3*6 = ) 18: " + value );
        /// });        
        /// </code>
        /// Chain tasks:
        /// <code>
        /// var request = $.ajax( url, { dataType: "json" } ),
        ///     chained = request.pipe(function( data ) {
        ///       return $.ajax( url2, { data: { user: data.userId } } );
        ///     });
        ///
        /// chained.done(function( data ) {
        ///   // data retrieved from url2 as provided by the first request
        /// });        
        /// </code>
        /// </example>
        public Promise<T, E> pipe(JsFunc<object> doneFilter) { return null; }
        /// <summary>
        /// Utility method to filter and/or chain Deferreds.
        /// </summary>
        /// <param name="doneFilter">
        /// doneFilter An optional function that is called when the Deferred is resolved.
        /// </param>
        /// <param name="failFilter">
        /// failFilter An optional function that is called when the Deferred is rejected.
        /// </param>
        /// <returns>
        /// The deferred.pipe() method returns a new promise that filters the status and values of a deferred through a function. The doneFilter and failFilter functions filter the original deferred's resolved / rejected status and values. These filter functions can return a new value to be passed along to the piped promise's done() or fail() callbacks, or they can return another observable object (Deferred, Promise, etc) which will pass its resolved / rejected status and values to the piped promise's callbacks. If the filter function used is null, or not specified, the piped promise will be resolved or rejected with the same values as the original.
        /// </returns>
        /// <example>
        /// Filter resolve value:
        /// <code>
        /// var defer = $.Deferred(),
        ///     filtered = defer.pipe(function( value ) {
        ///       return value * 2;
        ///     });
        ///
        /// defer.resolve( 5 );
        /// filtered.done(function( value ) {
        ///   alert( "Value is ( 2*5 = ) 10: " + value );
        /// });        
        /// </code>
        /// Filter reject value:
        /// <code>
        /// var defer = $.Deferred(),
        ///    filtered = defer.pipe( null, function( value ) {
        ///      return value * 3;
        ///     });
        ///
        /// defer.reject( 6 );
        /// filtered.fail(function( value ) {
        ///   alert( "Value is ( 3*6 = ) 18: " + value );
        /// });        
        /// </code>
        /// Chain tasks:
        /// <code>
        /// var request = $.ajax( url, { dataType: "json" } ),
        ///     chained = request.pipe(function( data ) {
        ///       return $.ajax( url2, { data: { user: data.userId } } );
        ///     });
        ///
        /// chained.done(function( data ) {
        ///   // data retrieved from url2 as provided by the first request
        /// });        
        /// </code>
        /// </example>
        public Promise<T, E> pipe(JsFunc<object> doneFilter, JsFunc<object> failFilter) { return null; }
        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved or rejected.
        /// <list type="bullet">
        /// Both arguments can be either a single function or an array of functions. Either argument can also be null if no callback of that type is desired. Alternatively, use .done() or .fail() to set only doneCallbacks or failCallbacks. When the Deferred is resolved, the doneCallbacks are called. If the Deferred is instead rejected, the failCallbacks are called. Callbacks are executed in the order they were added. Since deferred.then returns the deferred object, other methods of the deferred object can be chained to this one, including additional .then() methods. For more information, see the documentation for Deferred object.
        /// </list>
        /// </summary>
        /// <param name="doneCallbacks">
        /// doneCallbacks A function, or array of functions, called when the Deferred is resolved.
        /// </param>
        /// <param name="failCallbacks">
        /// failCallbacks A function, or array of functions, called when the Deferred is rejected.
        /// </param>
        /// <returns>
        /// Returns: Deferred
        /// </returns>
        /// <example>
        /// Since the jQuery.get method returns a jqXHR object, which is derived from a Deferred object, we can attach handlers using the .then method.
        /// <code>
        /// $.get("test.php").then(function(){ alert("$.get succeeded"); },function(){ alert("$.get failed!"); });
        /// </code>
        /// </example>
        public Deferred<T, E> then(JsAction doneCallbacks, JsAction failCallbacks) { return null; }
    }

    #endregion
    #region TopLeft
    [JsType(JsMode.Json)]
    public partial class TopLeft
    {
        public JsNumber top { get; set; }
        public JsNumber left { get; set; }
    }


    /// <summary>
    /// (Object) An object containing these properties(same as the remove method):
    /// </summary>
    public partial class HandleObj
    {
        /// <summary>
        /// (String) The name of the event.
        /// </summary>
        /// <returns></returns>
        public JsString type { get; set; }
        /// <summary>
        /// // - (Anything) Whatever data object (optional) was passed in when binding the event.
        /// </summary>
        /// <returns></returns>
        public object data { get; set; }
        /// <summary>
        /// // - (String) A sorted, dot-delimited list of namespaces specified when binding the event.
        /// </summary>
        /// <returns></returns>
        public JsString @namespace { get; set; }
        /// <summary>
        /// (Function) The event handler being bound to the event. This function will be called whenever the event is triggered.
        /// </summary>
        /// <returns></returns>
        public JsString handler { get; set; }
        /// <summary>
        /// (Number) A unique ID for this event handler. This is used internally for managing handlers.
        /// </summary>
        /// <returns></returns>
        public JsString guid { get; set; }// - 
        /// <summary>
        /// (String) The selector used by the delegate or live jQuery methods. Only available when binding event handlers using these two methods.
        /// </summary>
        /// <returns></returns>
        public JsString selector { get; set; }// - 
    }
    /// <summary>
    /// A special event can be defined using the following five methods. Each method is optional, and only needs to be specified if necessary. The namespace for the special event is jQuery.event.special.myevent where myevent is the name of your event. Also note that while you can have any number of other methods and properties attached to this namespace, all but these five will be ignored:
    /// </summary>
    public partial class SpecialEvent : jQuery
    {
        /// <summary>
        /// Do something when the first event handler is bound to a particular element.
        /// More explicitly: do something when an event handler is bound to a particular element, but only if there are not currently any event handlers bound. This may occur in two scenarios: 1) either the very first time that event is bound to that element, or 2) the next time that event is bound to that element, after all previous handlers for that event have been unbound from that element.
        /// </summary>
        /// <param name="data">(Anything) Whatever eventData (optional) was passed in when binding the event.</param>
        /// <param name="namespaces">(Array) An array of namespaces specified when binding the event.</param>
        /// <param name="eventHandle">(Function) The actual function that will be bound to the browser’s native event (this is used internally for the beforeunload event, you’ll never use it).</param>
        public virtual void setup(object data, JsArray<JsString> namespaces, JsFunction eventHandle) { }
        /// <summary>
        /// Do something when the last event handler is unbound from a particular element.
        /// </summary>
        /// <param name="namespaces"></param>
        public virtual void teardown(JsArray<JsString> namespaces) { }
        /// <summary>
        /// Do something each time an event handler is bound to a particular element.
        /// 'this' is the element to which the event handler is being bound.
        /// </summary>
        /// <param name="handleObj"></param>
        public virtual void add(HandleObj handleObj) { }
        /// <summary>
        /// Do something each time an event handler is unbound from a particular element.
        /// </summary>
        /// <param name="handleObj"></param>
        public virtual void remove(HandleObj handleObj) { }
        /// <summary>
        /// The default action for the event. This callback will be triggered unless event.preventDefault() is called.
        /// </summary>
        /// <param name="e"></param>
        public virtual void _default(Event e) { }
    }

    #endregion
    #region NamespaceDoc

    /// <summary>
    /// SharpKit.jQuery namespace contains all jQuery core framework APIs
    /// </summary>
    class NamespaceDoc
    {
    }
    #endregion


}



