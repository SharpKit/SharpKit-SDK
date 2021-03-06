// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.log.appender
{
    /// <summary>
	/// <para>Contains some common methods available to all log appenders.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.log.appender.Util", OmitOptionalParameters = true, Export = false)]
    public partial class Util 
    {
		#region Methods

		public Util() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Escapes the HTML in the given value</para>
		/// </summary>
		/// <param name="value">value to escape</param>
		/// <returns>escaped value</returns>
		[JsMethod(Name = "escapeHTML")]
		public static string EscapeHTML(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Formats a numeric time offset to 6 characters.</para>
		/// </summary>
		/// <param name="offset">Current offset value</param>
		/// <param name="length">Refine the length</param>
		/// <returns>Padded string</returns>
		[JsMethod(Name = "formatOffset")]
		public static string FormatOffset(double offset, double length = 6) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts a single log entry to HTML</para>
		/// </summary>
		/// <param name="entry">The entry to process</param>
		[JsMethod(Name = "toHtml")]
		public static void ToHtml(object entry) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts a single log entry to plain text</para>
		/// </summary>
		/// <param name="entry">The entry to process</param>
		/// <returns>the formatted log entry</returns>
		[JsMethod(Name = "toText")]
		public static string ToText(object entry) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts a single log entry to an array of plain text</para>
		/// </summary>
		/// <param name="entry">The entry to process</param>
		/// <returns>Argument list ready message array.</returns>
		[JsMethod(Name = "toTextArray")]
		public static JsArray ToTextArray(object entry) { throw new NotImplementedException(); }

		#endregion Methods
    }
}