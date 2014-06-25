using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.http
{
    /// <summary>
    /// This object is created when making a request with http.request(). It is passed to the 'response' event of the request object.
    /// </summary>
     [JsType(JsMode.Prototype, Export = false, Name = "clientResponse")]
    public partial class ClientResponse
    {
        #region Events
        /// <summary>
        /// function () { }
        /// Indicates that the underlaying connection was terminated before response.end() was called or able to flush.
        /// Just like 'end', this event occurs only once per response, and no more 'data' events will fire afterwards. See [http.ServerResponse][]'s 'close' event for more information.
        /// Note: 'close' can fire after 'end', but not vice versa.
        /// </summary>
        public JsAction close { get; set; }
        /// <summary>
        /// function (chunk) { }
        /// Emitted when a piece of the message body is received.
        /// Note that the data will be lost if there is no listener when a ClientResponse emits a 'data' event. 
        /// </summary>
        public JsAction<JsString> data { get; set; }
        /// <summary>
        /// function () { }
        /// Emitted exactly once for each response. After that, no more 'data' events will be emitted on the response.
        /// </summary>
        public JsAction end { get; set; }
        #endregion
        /// <summary>
        /// Set the encoding for the response body. See stream.setEncoding() for more information.
        /// </summary>
        /// <returns></returns>
        public object setEncoding() { return null; }
        /// <summary>
        /// Set the encoding for the response body. See stream.setEncoding() for more information.
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public object setEncoding(object encoding) { return null; }
        /// <summary>
        /// Pauses response from emitting events. Useful to throttle back a download.
        /// </summary>
        /// <returns></returns>
        public object pause() { return null; }
        /// <summary>
        /// Resumes a paused response.
        /// </summary>
        /// <returns></returns>
        public object resume() { return null; }
    }
    [JsType(JsMode.Json)]
    public partial class ClientRegion
    {
        /// <summary>
        /// The 3-digit HTTP response status code. E.G. 404.
        /// </summary>
        public JsNumber statusCode { get; set; }
        /// <summary>
        /// The HTTP version of the connected-to server. Probably either '1.1' or '1.0'. Also response.httpVersionMajor is the first integer and response.httpVersionMinor is the second.
        /// </summary>
        public JsNumber httpVersion { get; set; }
        /// <summary>
        /// The response headers object.
        /// </summary>
        public object headers { get; set; }
        /// <summary>
        /// The response trailers object. Only populated after the 'end' event.
        /// </summary>
        public object trailers { get; set; }

    }

}
