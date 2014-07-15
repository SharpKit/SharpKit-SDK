using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    public abstract class Logger
    {
        /// <summary>
        /// Adds the given appender
        /// </summary>
        /// <param name="appender"></param>
        public void addAppender(Appender appender) { }
        /// <summary>
        /// Removes the given appender
        /// </summary>
        /// <param name="appender"></param>
        public void removeAppender(Appender appender) { }
        /// <summary>
        /// Clears all appenders for the current logger
        /// </summary>
        public void removeAllAppenders() { }
        /// <summary>
        /// Sets the level. Log messages of a lower level than level will not be logged. Default value is DEBUG
        /// </summary>
        /// <param name="level"></param>
        public void setLevel(Level level) { }
        /// <summary>
        /// Returns the level explicitly set for this logger or null if none has been set
        /// </summary>
        /// <returns></returns>
        public Level getLevel() { return default(Level); }
        /// <summary>
        /// Returns the level at which the logger is operating. This is either the level explicitly set on the logger or, if no level has been set, the effective level of the logger's parent
        /// </summary>
        /// <returns></returns>
        public Level getEffectiveLevel() { return default(Level); }
        /// <summary>
        /// Sets whether appender additivity is enabled (the default) or disabled. If set to false, this particular logger will not inherit any appenders form its ancestors. Any descendant of this logger, however, will inherit from its ancestors as normal, unless its own additivity is explicitly set to false. Default value is true.
        /// </summary>
        /// <param name="additivity"></param>
        public void setAdditivity(JsBoolean additivity) { }
        /// <summary>
        /// Returns whether additivity is enabled for this logger
        /// </summary>
        /// <returns></returns>
        public JsBoolean getAdditivity() { return false; }
        /// <summary>
        /// Generic logging method used by wrapper methods such as debug, error etc
        /// </summary>
        /// <param name="level"></param>
        /// <param name="param"></param>
        public void log(Level level, object param) { }
        /// <summary>
        /// Logs one or more messages and optionally an error at level TRACE
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="messages"></param>
        public void trace(object message1, params object[] messages) { }
        /// <summary>
        /// Logs one or more messages and optionally an error at level DEBUG
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="messages"></param>
        public void debug(object message1, params object[] messages) { }
        /// <summary>
        /// Logs one or more messages and optionally an error at level INFO
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="messages"></param>
        public void info(object message1, params object[] messages) { }
        /// <summary>
        /// Logs one or more messages and optionally an error at level WARN
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="messages"></param>
        public void warn(object message1, params object[] messages) { }
        /// <summary>
        /// Logs one or more messages and optionally an error at level ERROR
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="messages"></param>
        public void error(object message1, params object[] messages) { }
        /// <summary>
        /// Logs one or more messages and optionally an error at level FATAL
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="messages"></param>
        public void fatal(object message1, params object[] messages) { }
        /// <summary>
        /// Returns whether the logger is enabled for the specified level
        /// </summary>
        /// <param name="level"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public JsBoolean isEnabledFor(Level level, JsError exception) { return false; }
        /// <summary>
        /// Returns whether the logger is enabled for TRACE messages
        /// </summary>
        /// <returns></returns>
        public JsBoolean isTraceEnabled() { return false; }
        /// <summary>
        /// Returns whether the logger is enabled for DEBUG messages
        /// </summary>
        /// <returns></returns>
        public JsBoolean isDebugEnabled() { return false; }
        /// <summary>
        /// Returns whether the logger is enabled for INFO messages
        /// </summary>
        /// <returns></returns>
        public JsBoolean isInfoEnabled() { return false; }
        /// <summary>
        /// Returns whether the logger is enabled for WARN messages
        /// </summary>
        /// <returns></returns>
        public JsBoolean isWarnEnabled() { return false; }
        /// <summary>
        /// Returns whether the logger is enabled for ERROR messages
        /// </summary>
        /// <returns></returns>
        public JsBoolean isErrorEnabled() { return false; }
        /// <summary>
        /// Returns whether the logger is enabled for FATAL messages
        /// </summary>
        /// <returns></returns>
        public JsBoolean isFatalEnabled() { return false; }
        /// <summary>
        /// Starts a new group of log messages. In appenders that support grouping (currently PopUpAppender and InPageAppender), a group appears as an expandable section in the console, labelled with the name specified. Specifying initiallyExpanded determines whether the group starts off expanded (the default is true). Groups may be nested. 
        /// </summary>
        /// <param name="name"></param>
        [JsMethod(NativeOverloads = true)]
        public virtual void group(JsString name) { }
        /// <summary>
        /// Starts a new group of log messages. In appenders that support grouping (currently PopUpAppender and InPageAppender), a group appears as an expandable section in the console, labelled with the name specified. Specifying initiallyExpanded determines whether the group starts off expanded (the default is true). Groups may be nested. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="initiallyExpanded"></param>
        [JsMethod(NativeOverloads = true)]
        public virtual void group(JsString name, JsBoolean initiallyExpanded) { }
        /// <summary>
        /// Ends the current group. If there is no group then this function has no effect
        /// </summary>
        public void groupEnd() { }
        /// <summary>
        /// Starts a timer with name name. When the timer is ended with a call to timeEnd using the same name, the amount of time that has elapsed in milliseconds since the timer was started is logged at level level. If not level is supplied, the level defaults to INFO
        /// </summary>
        /// <param name="name"></param>
        [JsMethod(NativeOverloads = true)]
        public void time(JsString name) { }
        /// <summary>
        /// Starts a timer with name name. When the timer is ended with a call to timeEnd using the same name, the amount of time that has elapsed in milliseconds since the timer was started is logged at level level. If not level is supplied, the level defaults to INFO
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        [JsMethod(NativeOverloads = true)]
        public void time(JsString name, Level level) { }
        /// <summary>
        /// Ends the timer with name name and logs the time elapsed
        /// </summary>
        /// <param name="name"></param>
        public void timeEnd(JsString name) { }
        /// <summary>
        /// Asserts the given expression is true or evaluates to true. If so, nothing is logged. If not, an error is logged at the ERROR level
        /// </summary>
        /// <param name="expr"></param>
        public void assert(Object expr) { }
    }
}
