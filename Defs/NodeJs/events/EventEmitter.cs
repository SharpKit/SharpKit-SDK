using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.events
{
    /// <summary>
    /// <p>To access the EventEmitter class, <code>require(&#39;events&#39;).EventEmitter</code>.
    /// </p>
    /// <p>When an <code>EventEmitter</code> instance experiences an error, the typical action is
    /// to emit an <code>&#39;error&#39;</code> event.  Error events are treated as a special case in node.
    /// If there is no listener for it, then the default action is to print a stack
    /// trace and exit the program.
    /// </p>
    /// <p>All EventEmitters emit the event <code>&#39;newListener&#39;</code> when new listeners are
    /// added.
    /// </p>
    /// </summary>
    public partial class EventEmitter
    {
        /// <summary>
        /// Adds a listener to the end of the listeners array for the specified event.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="listener"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// server.on('connection', function (stream) {
        /// console.log('someone connected!');
        /// });
        /// </code>
        /// </example>
        public object addListener(JsString @event, JsAction<JsString> listener) { return null; }
        /// <summary>
        /// Execute each of the listeners in order with the supplied arguments.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        public object emit(JsString @event) { return null; }
        /// <summary>
        /// Execute each of the listeners in order with the supplied arguments.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="arg1"></param>
        /// <returns></returns>
        public object emit(object @event, object arg1) { return null; }
        /// <summary>
        /// Execute each of the listeners in order with the supplied arguments.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public object emit(object @event, params object[] args) { return null; }
        /// <summary>
        /// Execute each of the listeners in order with the supplied arguments.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public object emit(object @event, object arg1, object arg2) { return null; }
        /// <summary>
        /// Execute each of the listeners in order with the supplied arguments.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public object emit(object @event, object arg1, object arg2, params object[] args) { return null; }
        /// <summary>
        /// Returns an array of listeners for the specified event.
        /// <example>
        /// <code>
        /// server.on('connection', function (stream) {
        ///  console.log('someone connected!');
        /// });
        /// console.log(util.inspect(server.listeners('connection'))); // [ [Function] ]
        /// </code>
        /// </example>
        /// This array may be a mutable reference to the same underlying list of listeners that is used by the event subsystem. 
        /// However, certain actions (specifically, removeAllListeners) will invalidate this reference.
        /// If you would like to get a copy of the listeners at a specific point in time that is guaranteed not to change, make a copy, for example by doing emitter.
        /// listeners(event).slice(0).
        /// In a future release of node, this behavior may change to always return a copy, for consistency. 
        /// In your programs, please do not rely on being able to modify the EventEmitter listeners using array methods. Always use the 'on' method to add new listeners.
        /// </summary>
        /// <param name="event"></param>
        /// <returns>Returns an array of listeners for the specified event.</returns>
        public JsArray listeners(JsString @event) { return null; }
        /// <summary>
        /// Adds a listener to the end of the listeners array for the specified event.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="listener"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// server.on('connection', function (stream) {
        ///  console.log('someone connected!');
        /// });
        /// </code>
        /// </example>
        public object on(JsString @event, JsAction<JsString> listener) { return null; }
        /// <summary>
        /// Adds a listener to the end of the listeners array for the specified event.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="listener"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// server.on('connection', function (stream) {
        ///  console.log('someone connected!');
        /// });
        /// </code>
        /// </example>
        public object on(JsString @event, JsAction listener) { return null; }
        /// <summary>
        /// Adds a one time listener for the event. This listener is invoked only the next time the event is fired, after which it is removed.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="listener"></param>
        /// <returns></returns>
        public object once(JsString @event, JsAction<JsString> listener) { return null; }
        /// <summary>
        /// Removes all listeners, or those of the specified event.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Note that this will invalidate any arrays that have previously been returned by emitter.listeners(event).
        /// </remarks>
        public object removeAllListeners() { return null; }
        /// <summary>
        /// Removes all listeners, or those of the specified event.
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        /// /// <remarks>
        /// Note that this will invalidate any arrays that have previously been returned by emitter.listeners(event).
        /// </remarks>
        public object removeAllListeners(object @event) { return null; }
        /// <summary>
        /// Remove a listener from the listener array for the specified event. Caution: changes array indices in the listener array behind the listener.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="listener"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var callback = function(stream) {
        /// console.log('someone connected!');
        /// };
        /// server.on('connection', callback);
        /// // ...
        /// server.removeListener('connection', callback);
        /// </code>
        /// </example>
        public object removeListener(JsString @event, JsAction<JsString> listener) { return null; }
        /// <summary>
        /// <p>By default EventEmitters will print a warning if more than 10 listeners are
        /// added for a particular event. This is a useful default which helps finding memory leaks.
        /// Obviously not all Emitters should be limited to 10. This function allows
        /// that to be increased. Set to zero for unlimited.
        /// </p>
        /// </summary>
        public object setMaxListeners(object n) { return null; }
        /// <summary>
        /// This event is emitted any time someone adds a new listener.
        /// </summary>
        public JsAction<JsString, JsAction> newListener { get; set; }
        //TODO: this is an event.
    }
}
