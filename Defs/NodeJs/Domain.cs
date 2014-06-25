using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
using SharpKit.NodeJs.events;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>The Domain class encapsulates the functionality of routing errors and
    /// uncaught exceptions to the active Domain object.
    /// </p>
    /// <p>Domain is a child class of [EventEmitter][].  To handle the errors that it
    /// catches, listen to its <code>error</code> event.
    /// </p>
    /// </summary>
    public partial class Domain
    {
        /// <summary>
        /// Explicitly adds an emitter to the domain. If any event handlers called by the emitter throw an error, or if the emitter emits an error event, it will be routed to the domain's error event, just like with implicit binding.
        /// This also works with timers that are returned from setInterval and setTimeout. If their callback function throws, it will be caught by the domain 'error' handler.
        /// If the Timer or EventEmitter was already bound to a domain, it is removed from that one, and bound to this one instead.
        /// </summary>
        /// <param name="emitter"></param>
        /// <returns></returns>
        public object add(EventEmitter emitter) { return null; }
        /// <summary>
        /// Explicitly adds an emitter to the domain. If any event handlers called by the emitter throw an error, or if the emitter emits an error event, it will be routed to the domain's error event, just like with implicit binding.
        /// This also works with timers that are returned from setInterval and setTimeout. If their callback function throws, it will be caught by the domain 'error' handler.
        /// If the Timer or EventEmitter was already bound to a domain, it is removed from that one, and bound to this one instead. 
        /// </summary>
        /// <param name="emitter"></param>
        /// <returns></returns>
        public object add(object emitter) { return null; }
        /// <summary>
        /// The returned function will be a wrapper around the supplied callback function. 
        /// When the returned function is called, any errors that are thrown will be routed to the domain's error event.
        /// </summary>
        /// <param name="callback"></param>
        /// <returns>return: Function The bound function</returns>
        /// <example>
        /// <code>
        /// var d = domain.create();
        /// function readSomeFile(filename, cb) {
        ///   fs.readFile(filename, 'utf8', d.bind(function(er, data) {
        ///     // if this throws, it will also be passed to the domain
        ///     return cb(er, data ? JSON.parse(data) : null);
        ///   }));
        /// }
        ///
        /// d.on('error', function(er) {
        ///   // an error occurred somewhere.
        ///   // if we throw it now, it will crash the program
        ///   // with the normal line number and stack message.
        /// });
        /// </code>
        /// </example>
        public JsFunction bind(JsAction callback) { return null; }
        /// <summary>
        /// The dispose method destroys a domain, and makes a best effort attempt to clean up any and all IO that is associated with the domain. 
        /// Streams are aborted, ended, closed, and/or destroyed. Timers are cleared. Explicitly bound callbacks are no longer called. 
        /// Any error events that are raised as a result of this are ignored.
        /// The intention of calling dispose is generally to prevent cascading errors when a critical part of the Domain context is found to be in an error state.
        /// Once the domain is disposed the dispose event will emit.
        /// Note that IO might still be performed. However, to the highest degree possible, once a domain is disposed, further errors from the emitters in that set will be ignored. 
        /// So, even if some remaining actions are still in flight, Node.js will not communicate further about them.
        /// </summary>
        /// <returns></returns>
        public object dispose() { return null; }
        /// <summary>
        /// This method is almost identical to domain.bind(callback). 
        /// However, in addition to catching thrown errors, it will also intercept Error objects sent as the first argument to the function.
        /// In this way, the common if (er) return callback(er); pattern can be replaced with a single error handler in a single place.
        /// </summary>
        /// <param name="callback">Function The callback function</param>
        /// <returns>Function The intercepted function</returns>
        /// <example>
        /// <code>
        /// var d = domain.create();
        /// 
        /// function readSomeFile(filename, cb) {
        ///   fs.readFile(filename, 'utf8', d.intercept(function(data) {
        ///     // note, the first argument is never passed to the
        ///     // callback since it is assumed to be the 'Error' argument
        ///     // and thus intercepted by the domain.
        /// 
        ///     // if this throws, it will also be passed to the domain
        ///     // so the error-handling logic can be moved to the 'error'
        ///     // event on the domain instead of being repeated throughout
        ///     // the program.
        ///     return cb(null, JSON.parse(data));
        ///   }));
        /// }
        /// d.on('error', function(er) {
        ///   // an error occurred somewhere.
        ///   // if we throw it now, it will crash the program
        ///   // with the normal line number and stack message.
        /// });
        /// </code>
        /// </example>
        public object intercept(JsAction<JsString> callback) { return null; }
        /// <summary>
        /// The opposite of domain.add(emitter). Removes domain handling from the specified emitter.
        /// </summary>
        /// <param name="emitter">emitter EventEmitter | Timer emitter or timer to be removed from the domain</param>
        /// <returns></returns>
        public object remove(object emitter) { return null; }
        /// <summary>
        /// Run the supplied function in the context of the domain, implicitly binding all event emitters, timers, and lowlevel requests that are created in that context.
        /// 
        /// This is the most basic way to use a domain.
        /// </summary>
        /// <param name="fn">Function</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var d = domain.create();
        /// d.on('error', function(er) {
        ///   console.error('Caught error!', er);
        /// });
        /// d.run(function() {
        ///   process.nextTick(function() {
        ///     setTimeout(function() { // simulating some various async stuff
        ///       fs.open('non-existent file', 'r', function(er, fd) {
        ///         if (er) throw er;
        ///         // proceed...
        ///       });
        ///     }, 100);
        ///   });
        /// });
        /// </code>
        /// <remarks>
        /// In this example, the d.on('error') handler will be triggered, rather than crashing the program.
        /// </remarks>
        /// </example>
        public object run(JsAction fn) { return null; }
        /// <summary>
        /// An array of timers and event emitters that have been explicitly added to the domain.
        /// </summary>
        public JsFunc<JsArray> members { get; set; }
    }
}
