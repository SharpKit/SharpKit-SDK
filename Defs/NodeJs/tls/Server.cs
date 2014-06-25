using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.tls
{
    /// <summary>
    /// <p>This class is a subclass of <code>net.Server</code> and has the same methods on it.
    /// Instead of accepting just raw TCP connections, this accepts encrypted
    /// connections using TLS or SSL.
    /// </p>
    /// </summary>
    public partial class Server
    {
        /// <summary>
        /// <p>Add secure context that will be used if client request&#39;s SNI hostname is
        /// matching passed <code>hostname</code> (wildcards can be used). <code>credentials</code> can contain
        /// <code>key</code>, <code>cert</code> and <code>ca</code>.
        /// </p>
        /// </summary>
        public object addContext(object hostname, object credentials) { return null; }
        /// <summary>
        /// <p>Returns the bound address, the address family name and port of the
        /// server as reported by the operating system.  See [net.Server.address()][] for
        /// more information.
        /// </p>
        /// </summary>
        public object address() { return null; }
        /// <summary>
        /// <p>Stops the server from accepting new connections. This function is
        /// asynchronous, the server is finally closed when the server emits a <code>&#39;close&#39;</code>
        /// event.
        /// </p>
        /// </summary>
        public object close() { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified <code>port</code> and <code>host</code>.  If the
        /// <code>host</code> is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>).
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be called
        /// when the server has been bound.
        /// </p>
        /// <p>See <code>net.Server</code> for more information.
        /// </p>
        /// </summary>
        public object listen(object port) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified <code>port</code> and <code>host</code>.  If the
        /// <code>host</code> is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>).
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be called
        /// when the server has been bound.
        /// </p>
        /// <p>See <code>net.Server</code> for more information.
        /// </p>
        /// </summary>
        public object listen(object port, JsAction callback) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified <code>port</code> and <code>host</code>.  If the
        /// <code>host</code> is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>).
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be called
        /// when the server has been bound.
        /// </p>
        /// <p>See <code>net.Server</code> for more information.
        /// </p>
        /// </summary>
        public object listen(object port, object host, JsAction callback) { return null; }
        #region events
        /// <summary>
        /// function (cleartextStream) {}
        /// This event is emitted after a new connection has been successfully handshaked. The argument is a instance of CleartextStream. It has all the common stream methods and events.
        /// cleartextStream.authorized is a boolean value which indicates if the client has verified by one of the supplied certificate authorities for the server. If cleartextStream.authorized is false, then cleartextStream.authorizationError is set to describe how authorization failed. Implied but worth mentioning: depending on the settings of the TLS server, you unauthorized connections may be accepted. cleartextStream.npnProtocol is a string containing selected NPN protocol. cleartextStream.servername is a string containing servername requested with SNI.
        /// </summary>
        public JsAction<CleartextStream> secureConnection { get; set; }
        /// <summary>
        /// function (exception) { }
        /// When a client connection emits an 'error' event before secure connection is established - it will be forwarded here.
        /// </summary>
        public JsAction<Exception> clientError { get; set; }
        #endregion
    }
    public partial class ServerOpctions
    {
        /// <summary>
        /// Set this property to reject connections when the server's connection count gets high.
        /// </summary>
        public object maxConnection { get; set; }
        /// <summary>
        /// The number of concurrent connections on the server.
        /// </summary>
        public JsNumber connection { get; set; }
    }
}
