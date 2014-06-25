using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.http
{
    [JsType(JsMode.Prototype, Name="IncomingMessage", Export=false)]
    public class IncomingMessage
    {
        public JsAction close { get; set; }
        public JsString httpVersion { get; set; }
        public JsObject<JsString> headers { get; set; }
        public JsObject<JsString> trailers { get; set; }
        public void setTimeout(int msecs, JsAction callback) { }
        public JsString method { get; set; }
        public JsString url { get; set; }
        public JsString statusCode { get; set; }
        public JsString socket { get; set; }
    }
}
