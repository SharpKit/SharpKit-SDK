using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// log levels
    /// </summary>
    [JsEnum(ValuesAsNames = false)]
    public enum Level
    {
        ALL,
        TRACE,
        DEBUG,
        INFO,
        WARN,
        ERROR,
        FATAL,
        OFF,
    }
}
