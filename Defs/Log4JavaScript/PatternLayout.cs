using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// Provides a flexible way of formatting a log message by means of a conversion pattern string
    /// </summary>
    public class PatternLayout : Layout
    {
        /// <summary>
        /// Built-in conversion pattern, equivalent to %r %p %c - %m%n
        /// </summary>
        public static JsString TTCC_CONVERSION_PATTERN;
        /// <summary>
        /// Built-in conversion pattern, equivalent to %m%n
        /// </summary>
        public static JsString DEFAULT_CONVERSION_PATTERN;
        /// <summary>
        /// Built-in date format (and also the default), equivalent to yyyy-MM-dd HH:mm:ss,SSS
        /// </summary>
        public static JsString ISO8601_DATEFORMAT;
        /// <summary>
        /// Built-in date format, equivalent to dd MMM YYYY HH:mm:ss,SSS
        /// </summary>
        public static JsString DATETIME_DATEFORMAT;
        /// <summary>
        /// Built-in date format, equivalent to HH:mm:ss,SSS
        /// </summary>
        public static JsString ABSOLUTETIME_DATEFORMAT;

        /// <summary>
        /// Create a new PatternLayout
        /// </summary>
        /// <param name="pattern">The conversion pattern string to use</param>
        public PatternLayout(JsString pattern) { }
        public override JsString format(LoggingEvent loggingEvent) { return default(JsString); }
    }
}
