// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.lang
{
    /// <summary>
	/// <para>Collection of helper methods operating on functions.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.lang.Function", OmitOptionalParameters = true, Export = false)]
    public partial class Function 
    {
		#region Methods

		public Function() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Tries to execute the function.</para>
		/// <para>Syntax</para>
		/// <code>var result = qx.lang.Function.attempt(myFunction, [self, [varargs...]]);</code>
		/// <para>Example</para>
		/// <code>
		/// var myObject = {
		/// 'cow': 'moo!'
		/// };
		/// var myFunction = function()
		/// {
		/// for(var i = 0; i < arguments.length; i++) {
		/// if(!this[arguments[i]]) throw('doh!');
		/// }
		/// };
		/// var result = qx.lang.Function.attempt(myFunction, myObject, 'pig', 'cow'); // false
		/// </code>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="self">The object that the &#8220;this&#8221; of the function will refer to.</param>
		/// <param name="varargs">The arguments to pass to the function.</param>
		/// <returns>false if an exception is thrown, else the function's return.</returns>
		[JsMethod(Name = "attempt")]
		public static object Attempt(Action<object> func, object self = null, JsArguments varargs = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a function whose &#8220;this&#8221; is altered.</para>
		/// <para>Native way</para>
		/// <para>This is also a feature of JavaScript 1.8.5 and will be supplied
		/// by modern browsers. Including <see cref="qx.lang.normalize.Function"/>
		/// will supply a cross browser normalization of the native
		/// implementation. We like to encourage you to use the native function!</para>
		/// <para>Syntax</para>
		/// <code>qx.lang.Function.bind(myFunction, [self, [varargs...]]);</code>
		/// <para>Example</para>
		/// <code>
		/// function myFunction()
		/// {
		/// this.setStyle('color', 'red');
		/// // note that 'this' here refers to myFunction, not an element
		/// // we'll need to bind this function to the element we want to alter
		/// };
		/// var myBoundFunction = qx.lang.Function.bind(myFunction, myElement);
		/// myBoundFunction(); // this will make the element myElement red.
		/// </code>
		/// <para>If you find yourself using this static method a lot, you may be
		/// interested in the bindTo() method in the mixin qx.core.MBindTo.</para>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="self">The object that the &#8220;this&#8221; of the function will refer to.</param>
		/// <param name="varargs">The arguments to pass to the function.</param>
		/// <returns>The bound function.</returns>
		[JsMethod(Name = "bind")]
		public static Action<object> Bind(Action<object> func, object self = null, JsArguments varargs = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Base function for creating functional closures which is used by most other methods here.</para>
		/// <para>Syntax</para>
		/// <code>var createdFunction = qx.lang.Function.create(myFunction, [options]);</code>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="options">Map of options  self: The object that the &#8220;this&#8221; of the function will refer to. Default is the same as the wrapper function is called. args: An array of arguments that will be passed as arguments to the function when called. Default is no custom arguments; the function will receive the standard arguments when called. delay: If set, the returned function will delay the actual execution by this amount of milliseconds and return a timer handle when called. Default is no delay. periodical: If set the returned function will periodically perform the actual execution with this specified interval and return a timer handle when called. Default is no periodical execution. attempt: If set to true, the returned function will try to execute and return either the results or false on error. Default is false. </param>
		/// <returns>Wrapped function</returns>
		[JsMethod(Name = "create")]
		public static Action<object> Create(Action<object> func, object options) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a function whose arguments are pre-configured.</para>
		/// <para>Syntax</para>
		/// <code>qx.lang.Function.curry(myFunction, [varargs...]);</code>
		/// <para>Example</para>
		/// <code>
		/// function myFunction(elem) {
		/// elem.setStyle('color', 'red');
		/// };
		/// var myBoundFunction = qx.lang.Function.curry(myFunction, myElement);
		/// myBoundFunction(); // this will make the element myElement red.
		/// </code>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="varargs">The arguments to pass to the function.</param>
		/// <returns>The pre-configured function.</returns>
		[JsMethod(Name = "curry")]
		public static object Curry(Action<object> func, JsArguments varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Delays the execution of a function by a specified duration.</para>
		/// <para>Syntax</para>
		/// <code>var timeoutID = qx.lang.Function.delay(myFunction, [delay, [self, [varargs...]]]);</code>
		/// <para>Example</para>
		/// <code>
		/// var myFunction = function(){ alert('moo! Element id is: ' + this.id); };
		/// //wait 50 milliseconds, then call myFunction and bind myElement to it
		/// qx.lang.Function.delay(myFunction, 50, myElement); // alerts: 'moo! Element id is: ... '
		/// // An anonymous function, example
		/// qx.lang.Function.delay(function(){ alert('one second later...'); }, 1000); //wait a second and alert
		/// </code>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="delay">The duration to wait (in milliseconds).</param>
		/// <param name="self">The object that the &#8220;this&#8221; of the function will refer to.</param>
		/// <param name="varargs">The arguments to pass to the function.</param>
		/// <returns>The JavaScript Timeout ID (useful for clearing delays).</returns>
		[JsMethod(Name = "delay")]
		public static double Delay(Action<object> func, double delay, object self = null, JsArguments varargs = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>empty function</para>
		/// </summary>
		[JsMethod(Name = "empty")]
		public static void Empty() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Extract the caller of a function from the arguments variable.
		/// This will not work in Opera 
		/// </summary>
		/// <param name="args">The local arguments variable</param>
		/// <returns>A reference to the calling function or &#8220;undefined&#8221; if caller is not supported.</returns>
		[JsMethod(Name = "getCaller")]
		public static Action<object> GetCaller(JsArguments args) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Try to get a sensible textual description of a function object.
		/// This may be the class/mixin and method name of a function
		/// or at least the signature of the function.</para>
		/// </summary>
		/// <param name="fcn">function the get the name for.</param>
		/// <returns>Name of the function.</returns>
		[JsMethod(Name = "getName")]
		public static string GetName(Action<object> fcn) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Evaluates JavaScript code globally</para>
		/// </summary>
		/// <param name="data">JavaScript commands</param>
		/// <returns>Result of the execution</returns>
		[JsMethod(Name = "globalEval")]
		public static object GlobalEval(string data) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a function which could be used as a listener for a native event callback.</para>
		/// <para>Syntax</para>
		/// <code>qx.lang.Function.listener(myFunction, [self, [varargs...]]);</code>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="self">The object that the &#8220;this&#8221; of the function will refer to.</param>
		/// <param name="varargs">The arguments to pass to the function.</param>
		/// <returns>The bound function.</returns>
		[JsMethod(Name = "listener")]
		public static object Listener(Action<object> func, object self = null, JsArguments varargs = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Executes a function in the specified intervals of time</para>
		/// <para>Syntax</para>
		/// <code>var intervalID = qx.lang.Function.periodical(myFunction, [period, [self, [varargs...]]]);</code>
		/// <para>Example</para>
		/// <code>
		/// var Site = { counter: 0 };
		/// var addCount = function(){ this.counter++; };
		/// qx.lang.Function.periodical(addCount, 1000, Site); // will add the number of seconds at the Site
		/// </code>
		/// </summary>
		/// <param name="func">Original function to wrap</param>
		/// <param name="interval">The duration of the intervals between executions.</param>
		/// <param name="self">The object that the &#8220;this&#8221; of the function will refer to.</param>
		/// <param name="varargs">The arguments to pass to the function.</param>
		/// <returns>The Interval ID (useful for clearing a periodical).</returns>
		[JsMethod(Name = "periodical")]
		public static double Periodical(Action<object> func, double interval, object self = null, JsArguments varargs = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Simply return false.</para>
		/// </summary>
		/// <returns>Always returns false.</returns>
		[JsMethod(Name = "returnFalse")]
		public static bool ReturnFalse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Simply return null.</para>
		/// </summary>
		/// <returns>Always returns null.</returns>
		[JsMethod(Name = "returnNull")]
		public static object ReturnNull() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return &#8220;this&#8221;.</para>
		/// </summary>
		/// <returns>Always returns &#8220;this&#8221;.</returns>
		[JsMethod(Name = "returnThis")]
		public static object ReturnThis() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Simply return true.</para>
		/// </summary>
		/// <returns>Always returns true.</returns>
		[JsMethod(Name = "returnTrue")]
		public static bool ReturnTrue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Simply return 0.</para>
		/// </summary>
		/// <returns>Always returns 0.</returns>
		[JsMethod(Name = "returnZero")]
		public static double ReturnZero() { throw new NotImplementedException(); }

		#endregion Methods
    }
}