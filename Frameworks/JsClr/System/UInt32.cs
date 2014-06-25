using System;

namespace SharpKit.JavaScript.Private
{
    /// <summary>
    /// Represents a 32-bit unsigned integer.
    /// </summary>
    [JsType(Name = "System.UInt32", Filename = "~/Internal/Core.js")]
    public class JsImplUInt32
    {
        #region Fields
        private readonly JsNumber _value;
        #endregion

        #region Initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="JsImplUInt32" /> class.
        /// </summary>
        public JsImplUInt32() : this(0)
        {
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="JsImplUInt32" /> class from being created.
        /// </summary>
        /// <param name="value">The value.</param>
        private JsImplUInt32(object value)
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
            if(value == null)
                throw new ArgumentNullException();

            var regex = new JsRegExp(@"^-?([0-9]+)[^0-9]");
            var match = regex.exec(value.ToString());
            if(match == null)
                throw new FormatException();
            return new JsNumber(match[1].As<double>());
        }


        /// <summary>
        /// Converts the value to JsImplUInt32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>JsImplUInt32</returns>
        public static implicit operator JsImplUInt32(uint value)
        {
            return new JsImplUInt32(value);
        }

        /// <summary>
        /// Converts the value to JsImplUInt32.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>JsImplUInt32</returns>
        public static explicit operator JsImplUInt32(int value)
        {
            return new JsImplUInt32(value);
        }

        /// <summary>
        /// Jses the number.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static implicit operator JsNumber(JsImplUInt32 value)
        {
            return value._value;
        }
        #endregion
    }
}
