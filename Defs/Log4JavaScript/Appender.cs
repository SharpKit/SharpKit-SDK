using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// There are methods common to all appenders
    /// </summary>
    public class Appender
    {
        /// <summary>
        /// Checks the logging event's level is at least as severe as the appender's threshold and calls the appender's append method if so.
        /// This method should not in general be used directly or overridden
        /// </summary>
        /// <param name="loggingEvent"></param>
        public void doAppend(LoggingEvent loggingEvent) { }
        /// <summary>
        /// Appender-specific method to append a log message. Every appender object should implement this method
        /// </summary>
        /// <param name="loggingEvent"></param>
        public virtual void append(LoggingEvent loggingEvent) { }
        /// <summary>
        /// Sets the appender's layout
        /// </summary>
        /// <param name="layout"></param>
        public void setLayout(Layout layout) { }
        /// <summary>
        /// Returns the appender's layout
        /// </summary>
        /// <returns></returns>
        public Layout getLayout() { return null; }
        /// <summary>
        /// Sets the appender's threshold. Log messages of level less severe than this threshold will not be logged
        /// </summary>
        /// <param name="level"></param>
        public void setThreshold(Level level) { }
        /// <summary>
        /// Returns the appender's threshold
        /// </summary>
        /// <returns></returns>
        public Level getThreshold() { return default(Level); }
        /// <summary>
        /// Returns a string representation of the appender. Every appender object should implement this method
        /// </summary>
        /// <returns></returns>
        public virtual JsString toString() { return default(JsString); }

        public sealed override string ToString()
        {
            return base.ToString();
        }

        public sealed override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public sealed override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
