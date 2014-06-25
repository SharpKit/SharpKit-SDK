using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// There are a few methods common to all layouts
    /// </summary>
    public abstract class Layout
    {
        /// <summary>
        /// Formats the log message. You should override this method in your own layouts
        /// </summary>
        /// <param name="loggingEvent"></param>
        /// <returns></returns>
        public abstract JsString format(LoggingEvent loggingEvent);
        /// <summary>
        /// Returns whether the layout ignores an error object in a logging event passed to its format method
        /// </summary>
        /// <returns></returns>
        public virtual bool ignoresThrowable() { return default(bool); }
        /// <summary>
        /// Returns the content type of the output of the layout
        /// </summary>
        /// <returns></returns>
        public virtual string getContentType() { return default(string); }
        /// <summary>
        /// Returns whether the layout's output is suitable for batching. JsonLayout and XmlLayout are the only built-in layouts that return true for this method
        /// </summary>
        /// <returns></returns>
        public virtual bool allowBatching() { return default(bool); }
    }
}
