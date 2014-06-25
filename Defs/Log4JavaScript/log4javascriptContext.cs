using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;


namespace log4javascript
{
    [JsType(Name = "log4javascript")]
    public class log4javascriptContext : SharpKit.Html.HtmlContext
    {
        /// <summary>
        /// The version number of your copy of log4javascript
        /// </summary>
        public static string version;
        /// <summary>
        /// The edition of your copy of log4javascript
        /// </summary>
        public static string edition;
        /// <summary>
        /// log4javascript's internal logging object
        /// </summary>
        public static LogLog logLog;
        /// <summary>
        /// Returns a logger with the specified name, creating it if a logger with that name does not already exist. If no name is specified, a logger is returned with name [anonymous], and subsequent calls to getLogger() (with no logger name specified) will return this same logger object.
        /// Note that the names [anonymous], [default], [null] and root are reserved for the anonymous logger, default logger, null logger and root logger respectively.
        /// </summary>
        /// <returns></returns>
        [JsMethod(NativeOverloads = true)]
        public static Logger getLogger() { return null; }
        /// <summary>
        /// Returns a logger with the specified name, creating it if a logger with that name does not already exist. If no name is specified, a logger is returned with name [anonymous], and subsequent calls to getLogger() (with no logger name specified) will return this same logger object.
        /// Note that the names [anonymous], [default], [null] and root are reserved for the anonymous logger, default logger, null logger and root logger respectively.
        /// </summary>
        /// <returns></returns>
        [JsMethod(NativeOverloads = true)]
        public static Logger getLogger(JsString loggerName) { return null; }
        public static Logger getDefaultLogger() { return null; }
        public static Logger getNullLogger() { return null; }
        public static Logger getRootLogger() { return null; }
        public static void resetConfiguration() { }
        public static void setEnabled(JsBoolean enabled) { }
        public static JsBoolean isEnabled() { return false; }
        public static void addEventListener(JsString eventType, JsAction<object, object, object> listener) { }
        public static void removeEventListener(JsString eventType, JsAction<object, object, object> listener) { }
        public static void dispatchEvent(JsString eventType, Object eventArgs) { }
        public static void setEventTypes(Array eventTypes) { }
        public static void setShowStackTraces(JsBoolean show) { }
        public static Object evalInScope(JsString expr) { return null; }
    }
}