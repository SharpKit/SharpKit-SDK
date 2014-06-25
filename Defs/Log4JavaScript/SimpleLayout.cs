using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// Provides basic formatting. SimpleLayout consists of the level of the log statement, followed by " - " and then the log message itself.
    /// </summary>
    public class SimpleLayout : Layout
    {
        public override JsString format(LoggingEvent loggingEvent) { return default(JsString); }
    }
}
