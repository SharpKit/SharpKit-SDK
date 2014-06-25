using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.http
{
    /// <summary>
    /// <p>This is an [EventEmitter][] with the following events:
    /// </p>
    /// </summary>
     [JsType(JsMode.Prototype, Export = false, Name = "server")]
    public partial class Server
    {
        /// <summary>
        /// <p>Stops the server from accepting new connections.  See [net.Server.close()][].
        /// </p>
        /// </summary>
        public object close() { return null; }
        /// <summary>
        /// <p>Stops the server from accepting new connections.  See [net.Server.close()][].
        /// </p>
        /// </summary>
        public object close(object callback) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified port and hostname.  If the
        /// hostname is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>).
        /// </p>
        /// <p>To listen to a unix socket, supply a filename instead of port and hostname.
        /// </p>
        /// <p>Backlog is the maximum length of the queue of pending connections.
        /// The actual length will be determined by your OS through sysctl settings such as
        /// <code>tcp_max_syn_backlog</code> and <code>somaxconn</code> on linux. The default value of this
        /// parameter is 511 (not 512).
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be added as
        /// a listener for the [&#39;listening&#39;][] event.  See also [net.Server.listen(port)][].
        /// </p>
        /// </summary>
        public object listen(object port) { return null; }
        /// <summary>
        /// <p>Start a UNIX socket server listening for connections on the given <code>path</code>.
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be added as
        /// a listener for the [&#39;listening&#39;][] event.  See also [net.Server.listen(path)][].
        /// </p>
        /// </summary>
        public object listen(object path, object callback) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified port and hostname.  If the
        /// hostname is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>).
        /// </p>
        /// <p>To listen to a unix socket, supply a filename instead of port and hostname.
        /// </p>
        /// <p>Backlog is the maximum length of the queue of pending connections.
        /// The actual length will be determined by your OS through sysctl settings such as
        /// <code>tcp_max_syn_backlog</code> and <code>somaxconn</code> on linux. The default value of this
        /// parameter is 511 (not 512).
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be added as
        /// a listener for the [&#39;listening&#39;][] event.  See also [net.Server.listen(port)][].
        /// </p>
        /// </summary>
        public object listen(object port, object backlog, object callback) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified port and hostname.  If the
        /// hostname is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>).
        /// </p>
        /// <p>To listen to a unix socket, supply a filename instead of port and hostname.
        /// </p>
        /// <p>Backlog is the maximum length of the queue of pending connections.
        /// The actual length will be determined by your OS through sysctl settings such as
        /// <code>tcp_max_syn_backlog</code> and <code>somaxconn</code> on linux. The default value of this
        /// parameter is 511 (not 512).
        /// </p>
        /// <p>This function is asynchronous. The last parameter <code>callback</code> will be added as
        /// a listener for the [&#39;listening&#39;][] event.  See also [net.Server.listen(port)][].
        /// </p>
        /// </summary>
        public object listen(object port, object hostname, object backlog, object callback) { return null; }
        #region events
        /// <summary>
        /// function (request, response) { }
        /// Emitted each time there is a request. Note that there may be multiple requests per connection (in the case of keep-alive connections). request is an instance of http.ServerRequest and response is an instance of http.ServerResponse
        /// </summary>
        public JsAction<ServerRequest, ServerResponse> request { get; set; }
        /// <summary>
        /// function (socket) { }
        /// When a new TCP stream is established. socket is an object of type net.Socket. Usually users will not want to access this event. The socket can also be accessed at request.connection.
        /// </summary>
        public JsAction<Socket> connection { get; set; }
        /// <summary>
        /// Emitted when the server closes.
        /// </summary>
        [JsProperty(Name = "close")]
        public JsAction closeEvent { get; set; }
        /// <summary>
        /// function (request, response) { }
        ///Emitted each time a request with an http Expect: 100-continue is received. If this event isn't listened for, the server will automatically respond with a 100 Continue as appropriate.
        ///Handling this event involves calling response.writeContinue if the client should continue to send the request body, or generating an appropriate HTTP response (e.g., 400 Bad Request) if the client should not continue to send the request body.
        ///Note that when this event is emitted and handled, the request event will not be emitted.
        /// </summary>
        public JsAction<ServerRequest, ServerResponse> checkContinue { get; set; }
        /// <summary>
        /// function (request, socket, head) { }
        ///Emitted each time a client requests a http CONNECT method. If this event isn't listened for, then clients requesting a CONNECT method will have their connections closed.
        ///request is the arguments for the http request, as it is in the request event.
        ///socket is the network socket between the server and client.
        ///head is an instance of Buffer, the first packet of the tunneling stream, this may be empty.
        ///After this event is emitted, the request's socket will not have a data event listener, meaning you will need to bind to it in order to handle data sent to the server on that socket.
        /// </summary>
        public JsAction<ServerRequest, Socket, Buffer> connect { get; set; }
        /// <summary>
        /// function (request, socket, head) { }
        ///Emitted each time a client requests a http upgrade. If this event isn't listened for, then clients requesting an upgrade will have their connections closed.
        ///request is the arguments for the http request, as it is in the request event.
        ///socket is the network socket between the server and client.
        ///head is an instance of Buffer, the first packet of the upgraded stream, this may be empty.
        ///After this event is emitted, the request's socket will not have a data event listener, meaning you will need to bind to it in order to handle data sent to the server on that socket.
        /// </summary>
        public JsAction<ServerRequest, Socket, Buffer> upgrade { get; set; }
        /// <summary>
        /// function (exception) { }
        /// If a client connection emits an 'error' event - it will forwarded here.
        /// </summary>
        public JsAction<JsError> clientError { get; set; }
        #endregion
    }
    [JsType(JsMode.Json)]
    public partial class ServerOptions
    {
        /// <summary>
        /// Limits maximum incoming headers count, equal to 1000 by default. If set to 0 - no limit will be applied.
        /// </summary>
        public JsNumber maxHeaderCount { get; set; }
    }
}
