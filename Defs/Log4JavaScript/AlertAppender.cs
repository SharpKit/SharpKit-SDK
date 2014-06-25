using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// Displays a log message as a JavaScript alert
    /// </summary>
    public class AlertAppender : Appender
    {
        public override void append(LoggingEvent loggingEvent) { }
        public override JsString toString() { return default(JsString); }
    }
}