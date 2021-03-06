// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.module
{
    /// <summary>
	/// <para>Support for native and custom events.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.module.Event", OmitOptionalParameters = true, Export = false)]
    public partial class Event 
    {
		#region Methods

		public Event() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fire an event of the given type.</para>
		/// </summary>
		/// <param name="type">Event type</param>
		/// <param name="data">Optional data that will be passed to the listener callback function.</param>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "emit")]
		public static qxWeb Emit(string type, object data) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if one or more listeners for the given event type are attached to
		/// the first element in the collection</para>
		/// </summary>
		/// <param name="type">Event type, e.g. mousedown</param>
		/// <returns>true if one or more listeners are attached</returns>
		[JsMethod(Name = "hasListener")]
		public static bool HasListener(string type) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unregisters event listeners for the given type from each element in the
		/// collection.</para>
		/// </summary>
		/// <param name="type">Type of the event</param>
		/// <param name="listener">Listener callback</param>
		/// <param name="context">Listener callback context</param>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "off")]
		public static qxWeb Off(string type, Action<qx.eventx.type.Data> listener, object context) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Registers a listener for the given event type on each item in the
		/// collection. This can be either native or custom events.</para>
		/// </summary>
		/// <param name="type">Type of the event to listen for</param>
		/// <param name="listener">Listener callback</param>
		/// <param name="context">Context the callback function will be executed in. Default: The element on which the listener was registered</param>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "on")]
		public static qxWeb On(string type, Action<qx.eventx.type.Data> listener, object context) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Attaches a listener for the given event that will be executed only once.</para>
		/// </summary>
		/// <param name="type">Type of the event to listen for</param>
		/// <param name="listener">Listener callback</param>
		/// <param name="context">Context the callback function will be executed in. Default: The element on which the listener was registered</param>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "once")]
		public static qxWeb Once(string type, Action<qx.eventx.type.Data> listener, object context) { throw new NotImplementedException(); }

		#endregion Methods
    }
}