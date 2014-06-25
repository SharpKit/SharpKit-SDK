using System;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Enum", Filename = "~/Internal/Core.js")]
	internal class JsImplEnum
	{
        /// <summary>
        /// Retrieves the name of the constant in the specified enumeration that has the specified value.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="value">The value.</param>
        /// <returns>A string array of the names of the constants in enumType.</returns>
        /// <exception cref="ArgumentNullException"><para>enumType</para> is null.</exception>
        public static string GetName(Type enumType, object value)
        {
            if (enumType == null || value == null) throw new ArgumentNullException("enumType");

            var jsType = enumType.As<JsImplType>()._JsType;
            foreach (var p in jsType.staticDefinition)
                if (p == value)
                    return p.As<string>();
            throw new ArgumentException("value");
        }

        /// <summary>
        /// Retrieves an array of the names of the constants in a specified enumeration.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <returns>A string array of the names of the constants in enumType.</returns>
        /// <exception cref="ArgumentNullException"><para>enumType</para> is null.</exception>
        public static string[] GetNames(Type enumType)
		{
            if (enumType == null) throw new ArgumentNullException("enumType");

            var jsType = enumType.As<JsImplType>()._JsType;
			var array = new JsExtendedArray();
			foreach (var p in jsType.staticDefinition)
				array.push(p);
			return array.As<string[]>();
		}

        /// <summary>
        /// Retrieves an array of the values of the constants in a specified enumeration.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <returns>An array that contains the values of the constants in enumType.</returns>
        /// <exception cref="ArgumentNullException"><para>enumType</para> is null.</exception>
        public static object[] GetValues(Type enumType)
		{
            if (enumType == null) throw new ArgumentNullException("enumType");

            var jsType = enumType.As<JsImplType>()._JsType;
			var array = new JsExtendedArray();
			foreach (var p in jsType.staticDefinition)
				array.push(jsType.staticDefinition[p]);
			return array.As<object[]>();
		}

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="value">A string containing the name or value to convert.</param>
        /// <returns>An object of type enumType whose value is represented by value.</returns>
        /// <exception cref="ArgumentNullException"><para>enumType</para> or <para>value</para> is null.</exception>
        /// <exception cref="ArgumentException"><para>enumType</para> or <para>value</para> is null.</exception>
        public static object Parse(Type enumType, String value)
        {
            return Parse(enumType, value, false);
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="value">A string containing the name or value to convert.</param>
        /// <param name="ignoreCase"><value>true</value> to ignore case; <value>false</value> to regard case. </param>
        /// <returns>An object of type enumType whose value is represented by value.</returns>
        /// <exception cref="ArgumentNullException"><para>enumType</para> or <para>value</para> is null.</exception>
        /// <exception cref="ArgumentException"><para>enumType</para> or <para>value</para> is null.</exception>
        public static object Parse(Type enumType, String value, bool ignoreCase)
        {
            if (enumType == null) throw new ArgumentNullException("enumType");
            if (value == null) throw new ArgumentNullException("value");
            if (value.Trim() == string.Empty) throw new ArgumentException("value is either an empty string or only contains white space.");

            var jsType = enumType.As<JsImplType>()._JsType;
            foreach (var p in jsType.staticDefinition)
                if (ignoreCase ? p.toUpperCase() == value.ToUpper() : p == value)
                    return jsType.staticDefinition[p];
            throw new ArgumentException("value is a name, but not one of the named constants defined for the enumeration.");
        }
	}
}
