using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    //TODO:Name =  util.
    class Utilities
    {
        /// <summary>
        /// Returns a formatted string using the first argument as a printf-like format.
        /// </summary>
        /// <param name="format">The format argument is a string that contains zero or more placeholders. Each placeholder is replaced with the converted value from its corresponding argument. Supported placeholders are:
        /// <list type="bullet">
        /// %s - String.
        /// %d - Number (both integer and float).
        /// %j - JSON.
        /// % - single percent sign ('%'). This does not consume an argument.</param>
        /// </list>
        /// <param name="strings"></param>
        /// <returns>Returns a formatted string using the first argument as a printf-like format.</returns>
        /// If the placeholder does not have a corresponding argument, the placeholder is not replaced.
        ///<example>
        ///<code>
        /// util.format('%s:%s', 'foo'); //  'foo:%s'
        ///</code>
        /// If there are more arguments than placeholders, the extra arguments are converted to strings with util.inspect() and these strings are concatenated, delimited by a space.
        /// <code>
        /// util.format('%s:%s', 'foo', 'bar', 'baz'); ///  'foo:bar baz'
        /// </code>
        /// If the first argument is not a format string then util.format() returns a string that is the concatenation of all its arguments separated by spaces. Each argument is converted to a string with util.inspect().
        /// <code>
        /// util.format(1, 2, 3); //  '1 2 3'
        /// </code>
        /// </example>
        public JsString format(JsString format, params JsString[] strings) { return null; }
        /// <summary>
        /// Returns a formatted string using the first argument as a printf-like format.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        ///<example>
        ///<code>
        /// util.format('%s:%s', 'foo'); //  'foo:%s'
        ///</code>
        /// If there are more arguments than placeholders, the extra arguments are converted to strings with util.inspect() and these strings are concatenated, delimited by a space.
        /// <code>
        /// util.format('%s:%s', 'foo', 'bar', 'baz'); ///  'foo:bar baz'
        /// </code>
        /// If the first argument is not a format string then util.format() returns a string that is the concatenation of all its arguments separated by spaces. Each argument is converted to a string with util.inspect().
        /// <code>
        /// util.format(1, 2, 3); //  '1 2 3'
        /// </code>
        /// </example>
        public JsString format(params object[] strings) { return null; }
        /// <summary>
        /// A synchronous output function. Will block the process and output string immediately to stderr.
        /// <example>
        /// <code>
        /// require('util').debug('message on stderr');
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public JsString debug(JsString str) { return null; }
        /// <summary>
        /// Same as util.debug() except this will output all arguments immediately to stderr.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public JsString error(params JsString[] strings) { return null; }
        /// <summary>
        /// A synchronous output function. Will block the process and output all arguments to stdout with newlines after each argument.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public JsString puts(params JsString[] strings) { return null; }
        /// <summary>
        /// A synchronous output function. Will block the process, cast each argument to a string then output to stdout. Does not place newlines after each argument.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public JsString print(params JsString[] strings) { return null; }
        /// <summary>
        /// Output with timestamp on stdout.
        /// <example>
        /// <code>require('util').log('Timestamped message.');</code>
        /// </example>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public JsString log(JsString str) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public JsString inspect(object obj) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="showHidden">If showHidden is true, then the object's non-enumerable properties will be shown too. Defaults to false.</param>
        /// <returns></returns>
        public JsString inspect(object obj, bool showHidden) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="depth">If depth is provided, it tells inspect how many times to recurse while formatting the object. This is useful for inspecting large complicated objects.
        /// The default is to only recurse twice. To make it recurse indefinitely, pass in null for depth.</param>
        /// <returns></returns>
        public JsString inspect(object obj, object depth) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="showHidden">If showHidden is true, then the object's non-enumerable properties will be shown too. Defaults to false.</param>
        /// <param name="colors">If colors is true, the output will be styled with ANSI color codes. Defaults to false.</param>
        /// <returns></returns>
        public JsString inspect(object obj, bool showHidden, bool colors) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="depth">
        /// If depth is provided, it tells inspect how many times to recurse while formatting the object. This is useful for inspecting large complicated objects.
        /// The default is to only recurse twice. To make it recurse indefinitely, pass in null for depth.
        /// </param>
        /// <param name="colors">If colors is true, the output will be styled with ANSI color codes. Defaults to false.</param>
        /// <returns></returns>
        public JsString inspect(object obj, object depth, bool colors) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="showHidden">If showHidden is true, then the object's non-enumerable properties will be shown too. Defaults to false.</param>
        /// <param name="depth">
        /// If depth is provided, it tells inspect how many times to recurse while formatting the object. This is useful for inspecting large complicated objects.
        /// The default is to only recurse twice. To make it recurse indefinitely, pass in null for depth.
        /// </param>
        /// <returns></returns>
        public JsString inspect(object obj, bool showHidden, object depth) { return null; }
        /// <summary>
        /// Return a string representation of object, which is useful for debugging.
        /// <example>
        /// Example of inspecting all properties of the util object:
        /// <code>
        /// var util = require('util');
        ///
        /// console.log(util.inspect(util, true, null));
        /// Objects also may define their own inspect(depth) function which util.inspect() will invoke and use the result of when inspecting the object:
        ///
        /// var util = require('util');
        ///
        /// var obj = { name: 'nate' };
        /// obj.inspect = function(depth) {
        ///   return '{' + this.name + '}';
        /// };
        ///
        /// util.inspect(obj);
        /// // "{nate}"
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="showHidden">If showHidden is true, then the object's non-enumerable properties will be shown too. Defaults to false.</param>
        /// <param name="depth">If depth is provided, it tells inspect how many times to recurse while formatting the object. This is useful for inspecting large complicated objects.</param>
        /// <param name="colors">If colors is true, the output will be styled with ANSI color codes. Defaults to false.</param>
        /// <returns></returns>
        public JsString inspect(object obj, bool showHidden, object depth, bool colors) { return null; }
        /// <summary>
        /// <example>
        /// <code>
        /// var util = require('util');
        /// util.isArray([])
        ///  // true
        /// util.isArray(new Array)
        ///   // true
        /// util.isArray({})
        ///   // false
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Returns true if the given "object" is an Array. false otherwise.</returns>
        public bool isArray(object obj) { return false; }
        /// <summary>
        /// var util = require('util');
        /// util.isRegExp(/some regexp/)
        ///   // true
        /// util.isRegExp(new RegExp('another regexp'))
        ///   // true
        /// util.isRegExp({})
        ///   // false
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Returns true if the given "object" is a RegExp. false otherwise.</returns>
        public bool isRegExp(object obj) { return false; }
        /// <summary>
        /// <example>
        /// <code>
        /// var util = require('util');
        ///
        /// util.isDate(new Date())
        ///   // true
        /// util.isDate(Date())
        ///   // false (without 'new' returns a String)
        /// util.isDate({})
        ///   // false
        ///   </code>
        ///   </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Returns true if the given "object" is a Date. false otherwise.</returns>
        public bool isDate(object obj) { return false; }
        /// <summary>
        /// <example>
        /// <code>
        /// var util = require('util');
        /// 
        /// util.isError(new Error())
        ///   // true
        /// util.isError(new TypeError())
        ///   // true
        /// util.isError({ name: 'Error', message: 'an error occurred' })
        ///   // false
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Returns true if the given "object" is an Error. false otherwise.</returns>
        public bool isError(object obj) { return false; }
        /// <summary>
        /// Stability: 0 - Deprecated: Use readableStream.pipe(writableStream)
        /// Read the data from readableStream and send it to the writableStream. When writableStream.write(data) returns false readableStream will be paused until the drain event occurs on the writableStream. callback gets an error as its only argument and is called when writableStream is closed or when an error occurs.
        /// </summary>
        /// <param name="readableStream"></param>
        /// <param name="writableStream"></param>
        /// <returns></returns>
        public object pump(Readable_Stream readableStream, Writable_Stream writableStream) { return null; }
        /// <summary>
        /// Stability: 0 - Deprecated: Use readableStream.pipe(writableStream)
        /// Read the data from readableStream and send it to the writableStream. When writableStream.write(data) returns false readableStream will be paused until the drain event occurs on the writableStream. callback gets an error as its only argument and is called when writableStream is closed or when an error occurs.
        /// </summary>
        /// <param name="readableStream"></param>
        /// <param name="writableStream"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object pump(Readable_Stream readableStream, Writable_Stream writableStream, JsAction callback) { return null; }
        /// <summary>
        /// Inherit the prototype methods from one constructor into another. The prototype of constructor will be set to a new object created from superConstructor.
        ///
        /// As an additional convenience, superConstructor will be accessible through the constructor.super_ property.
        /// </summary>
        /// <param name="constructor"></param>
        /// <param name="superConstructor"></param>
        /// <example>
        /// <code>
        /// var util = require("util");
        /// var events = require("events");
        /// 
        /// function MyStream() {
        ///     events.EventEmitter.call(this);
        /// }
        /// 
        /// util.inherits(MyStream, events.EventEmitter);
        ///
        /// MyStream.prototype.write = function(data) {
        ///     this.emit("data", data);
        /// }
        /// 
        /// var stream = new MyStream();
        ///
        /// console.log(stream instanceof events.EventEmitter); // true
        /// console.log(MyStream.super_ === events.EventEmitter); // true
        ///
        /// stream.on("data", function(data) {
        ///    console.log('Received data: "' + data + '"');
        /// })
        /// stream.write("It works!"); // Received data: "It works!"
        /// </code>></example>
        public void inherits(JsAction constructor,JsAction superConstructor) { }
    }
}
