using System;

namespace SharpKit.JavaScript.Private
{
	/// <summary>
	/// Represents a 64-bit signed integer.
	/// </summary>
	[JsType(Name = "System.Int64", Filename = "~/Internal/Core.js")]
	public class JsImplInt64
	{
		#region Fields
		private readonly JsNumber _value;
		#endregion

		#region Initialization
		/// <summary>
		/// Initializes a new instance of the <see cref="JsImplInt64" /> class.
		/// </summary>
		public JsImplInt64()
			: this(0)
		{
		}

		/// <summary>
		/// Prevents a default instance of the <see cref="JsImplInt64" /> class from being created.
		/// </summary>
		/// <param name="value">The value.</param>
		private JsImplInt64(object value)
		{
			_value = Convert(value);
		}
		#endregion

		#region Conversion
		/// <summary>
		/// Converts the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <exception cref="System.ArgumentNullException"></exception>
		/// <exception cref="System.FormatException"></exception>
		private JsNumber Convert(object value)
		{
			if (value == null)
				throw new ArgumentNullException();

			var regex = new JsRegExp(@"^-?([0-9]+)[^0-9]");
			var match = regex.exec(value.ToString());
			if (match == null)
				throw new FormatException();
			return new JsNumber(match[1].As<double>());
		}


		/// <summary>
		/// Converts the value to JsImplInt64.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>JsImplInt64</returns>
		public static implicit operator JsImplInt64(uint value)
		{
			return new JsImplInt64(value);
		}

		/// <summary>
		/// Converts the value to JsImplInt64.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>JsImplInt64</returns>
		public static explicit operator JsImplInt64(int value)
		{
			return new JsImplInt64(value);
		}

		/// <summary>
		/// Jses the number.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		public static implicit operator JsNumber(JsImplInt64 value)
		{
			return value._value;
		}
		#endregion
	}
}

