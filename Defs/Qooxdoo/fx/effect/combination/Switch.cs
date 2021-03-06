// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.fx.effect.combination
{
    /// <summary>
	/// <para>Combination effect &#8220;Switch Off&#8221;</para>
	/// <para>Flickers the element one time and then folds it in.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.fx.effect.combination.Switch", OmitOptionalParameters = true, Export = false)]
    public partial class Switch : qx.fx.Base
    {
		#region Properties

		/// <summary>
		/// <para>Number of seconds the effect should run.</para>
		/// </summary>
		[JsProperty(Name = "duration", NativeField = true)]
		public object Duration { get; set; }

		/// <summary>
		/// <para>Initial opacity value</para>
		/// </summary>
		[JsProperty(Name = "from", NativeField = true)]
		public object From { get; set; }

		/// <summary>
		/// <para>Mode indicating if effect should switch
		/// element &#8220;on&#8221; or &#8220;off&#8221;</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "off"
		/// </remarks>
		[JsProperty(Name = "mode", NativeField = true)]
		public object Mode { get; set; }

		/// <summary>
		/// <para>Flag indicating if the CSS attribute &#8220;display&#8221;
		/// should be modified by effect</para>
		/// </summary>
		[JsProperty(Name = "modifyDisplay", NativeField = true)]
		public bool ModifyDisplay { get; set; }

		/// <summary>
		/// <para>Final opacity value</para>
		/// </summary>
		[JsProperty(Name = "to", NativeField = true)]
		public object To { get; set; }

		#endregion Properties

		#region Methods

		public Switch() { throw new NotImplementedException(); }

		/// <param name="element">The DOM element</param>
		public Switch(object element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This internal function is called after
		/// the effect actually has ended.</para>
		/// </summary>
		[JsMethod(Name = "afterFinish")]
		public void AfterFinish() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property mode.</para>
		/// </summary>
		[JsMethod(Name = "getMode")]
		public object GetMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "getModifyDisplay")]
		public bool GetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property mode
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property mode.</param>
		[JsMethod(Name = "initMode")]
		public void InitMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property modifyDisplay
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property modifyDisplay.</param>
		[JsMethod(Name = "initModifyDisplay")]
		public void InitModifyDisplay(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property modifyDisplay equals true.</para>
		/// </summary>
		[JsMethod(Name = "isModifyDisplay")]
		public void IsModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property mode.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMode")]
		public void ResetMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property modifyDisplay.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModifyDisplay")]
		public void ResetModifyDisplay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property mode.</para>
		/// </summary>
		/// <param name="value">New value for property mode.</param>
		[JsMethod(Name = "setMode")]
		public void SetMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property modifyDisplay.</para>
		/// </summary>
		/// <param name="value">New value for property modifyDisplay.</param>
		[JsMethod(Name = "setModifyDisplay")]
		public void SetModifyDisplay(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This internal function is called
		/// before the effect starts to configure
		/// the element or prepare other effects.</para>
		/// <para>Fires &#8220;setup&#8221; event.</para>
		/// </summary>
		[JsMethod(Name = "setup")]
		public void Setup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Starts the effect</para>
		/// </summary>
		/// <returns>true if the effect was successfully started</returns>
		[JsMethod(Name = "start")]
		public bool Start() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property modifyDisplay.</para>
		/// </summary>
		[JsMethod(Name = "toggleModifyDisplay")]
		public void ToggleModifyDisplay() { throw new NotImplementedException(); }

		#endregion Methods
    }
}