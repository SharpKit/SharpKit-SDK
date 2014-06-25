using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.http
{
    /// <summary>
    /// <p>This object is created internally by a HTTP server -- not by
    /// the user -- and passed as the first argument to a <code>&#39;request&#39;</code> listener.
    /// </p>
    /// <p>The request implements the [Readable Stream][] interface. This is an
    /// [EventEmitter][] with the following events:
    /// </p>
    /// </summary>
    public partial class ServerRequest : IncomingMessage
    {
        /// <summary>
        /// <p>Pauses request from emitting events.  Useful to throttle back an upload.
        /// </p>
        /// </summary>
        public object pause() { return null; }
        /// <summary>
        /// <p>Resumes a paused request.
        /// </p>
        /// </summary>
        public object resume() { return null; }
        /// <summary>
        /// <p>Set the encoding for the request body. See [stream.setEncoding()][] for more
        /// information.
        /// </p>
        /// </summary>
        public object setEncoding() { return null; }
        /// <summary>
        /// <p>Set the encoding for the request body. See [stream.setEncoding()][] for more
        /// information.
        /// </p>
        /// </summary>
        public object setEncoding(object encoding) { return null; }

        #region events
        /// <summary>
        /// Emitted when a piece of the message body is received. The chunk is a string if an encoding has been set with request.setEncoding(), otherwise it's a Buffer.
        /// Note that the data will be lost if there is no listener when a ServerRequest emits a 'data' event.
        /// </summary>
        public event JsAction<JsString> data
        {
            [JsMethod(Name = "on", InsertArg0 = "\"data\"")]
            add { }
            remove { }
        }
        /// <summary>
        /// Emitted exactly once for each request. After that, no more 'data' events will be emitted on the request.
        /// </summary>
        public event JsAction end
        {
            [JsMethod(Name = "on", InsertArg0 = "\"end\"")]
            add { }
            remove { }
        }
        /// <summary>
        /// Indicates that the underlaying connection was terminated before response.end() was called or able to flush.
        /// Just like 'end', this event occurs only once per request, and no more 'data' events will fire afterwards.
        /// Note: 'close' can fire after 'end', but not vice versa.
        /// </summary>
        public event JsAction close        
        {
            [JsMethod(Name = "on", InsertArg0 = "\"close\"")]
            add { }
            remove { }
        }
        /// <summary>

        #endregion
    }
    [JsType(JsMode.Json)]
    public partial class ServerRequestOptions
    {
        /// <summary>
        /// The request method as a string. Read only. Example: 'GET', 'DELETE'.
        /// </summary>
        public JsString method { get; set; }
        /// <summary>
        /// Request URL string. This contains only the URL that is present in the actual HTTP request. If the request is:
        /// <example>
        /// <code>
        ///GET /status?name=ryan HTTP/1.1\r\n
        ///Accept: text/plain\r\n
        ///\r\n 
        ///Then request.url will be:
        ///'/status?name=ryan'
        ///If you would like to parse the URL into its parts, you can use require('url').parse(request.url). Example:

        ///node> require('url').parse('/status?name=ryan')
        ///{ href: '/status?name=ryan',
        ///  search: '?name=ryan',
        ///  query: 'name=ryan',
        ///  pathname: '/status' }
        ///If you would like to extract the params from the query string, you can use the require('querystring').parse function, or pass true as the second argument to require('url').parse. Example:

        ///node> require('url').parse('/status?name=ryan', true)
        ///{ href: '/status?name=ryan',
        ///  search: '?name=ryan',
        ///  query: { name: 'ryan' },
        ///  pathname: '/status' }
        ///  </code>
        ///  </example>
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        /// Read only map of header names and values. Header names are lower-cased. Example:
        /// </summary>
        /// <example>
        /// <code>
        /// // Prints something like:
        /// //
        /// // { 'user-agent': 'curl/7.22.0',
        /// //   host: '127.0.0.1:8000',
        /// //   accept: '*/*' }
        /// console.log(request.headers);
        /// </code>
        /// </example>
        public object headers { get; set; } //TODO: ask Dan-el
        /// <summary>
        /// Read only; HTTP trailers (if present). Only populated after the 'end' event.
        /// </summary>
        public object trailers { get; set; }
        /// <summary>
        /// The HTTP protocol version as a string. Read only. Examples: '1.1', '1.0'. Also request.httpVersionMajor is the first integer and request.httpVersionMinor is the second.
        /// </summary>
        public JsString httpVersion { get; set; }

    }
}
