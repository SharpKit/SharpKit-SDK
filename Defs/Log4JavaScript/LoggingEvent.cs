using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    public class LoggingEvent
    {
        public LoggingEvent(Logger logger, JsDate timeStamp, Level level, JsArray messages, JsError exception) { }
        public Logger logger;
        public JsDate timeStamp;
        public JsNumber timeStampInMilliseconds;
        public JsNumber timeStampInSeconds;
        public JsNumber milliseconds;
        public Level level;
        public JsArray messages;
        public JsError exception;
        public object getThrowableStrRep() { return null; }
        public object getCombinedMessages() { return null; }
        public JsString toString() { return null; }
    }
}
