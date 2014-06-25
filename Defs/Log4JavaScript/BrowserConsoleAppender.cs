using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace log4javascript
{
    /// <summary>
    /// Writes log messages to the browser's built-in console, if present. This only works currently in Safari, Opera and Firefox with the excellent Firebug extension installed.
    /// </summary>
    public class BrowserConsoleAppender : Appender
    {
        public override JsString toString() { return default(JsString); }
        public override void append(LoggingEvent loggingEvent) { }
    }
}
