using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// The most basic layout. NullLayout's format() methods performs no formatting at all and simply returns the message logged
    /// </summary>
    public class NullLayout : Layout
    {
        public override JsString format(LoggingEvent loggingEvent) { return default(JsString); }
    }
}
