using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.http
{
    /// <summary>
    /// <p>This object is created internally and returned from <code>http.request()</code>.  It
    /// represents an <em>in-progress</em> request whose header has already been queued.  The
    /// header is still mutable using the <code>setHeader(name, value)</code>, <code>getHeader(name)</code>,
    /// <code>removeHeader(name)</code> API.  The actual header will be sent along with the first
    /// data chunk or when closing the connection.
    /// </p>
    /// <p>To get the response, add a listener for <code>&#39;response&#39;</code> to the request object.
    /// <code>&#39;response&#39;</code> will be emitted from the request object when the response
    /// headers have been received.  The <code>&#39;response&#39;</code> event is executed with one
    /// argument which is an instance of <code>http.ClientResponse</code>.
    /// </p>
    /// <p>During the <code>&#39;response&#39;</code> event, one can add listeners to the
    /// response object; particularly to listen for the <code>&#39;data&#39;</code> event. Note that
    /// the <code>&#39;response&#39;</code> event is called before any part of the response body is received,
    /// so there is no need to worry about racing to catch the first part of the
    /// body. As long as a listener for <code>&#39;data&#39;</code> is added during the <code>&#39;response&#39;</code>
    /// event, the entire body will be caught.
    /// </p>
    /// <pre><code>// Good
    /// request.on(&#39;response&#39;, function (response) {
    /// response.on(&#39;data&#39;, function (chunk) {
    /// console.log(&#39;BODY: &#39; + chunk);
    /// });
    /// });
    /// // Bad - misses all or part of the body
    /// request.on(&#39;response&#39;, function (response) {
    /// setTimeout(function () {
    /// response.on(&#39;data&#39;, function (chunk) {
    /// console.log(&#39;BODY: &#39; + chunk);
    /// });
    /// }, 10);
    /// });</code></pre>
    /// <p>Note: Node does not check whether Content-Length and the length of the body
    /// which has been transmitted are equal or not.
    /// </p>
    /// <p>The request implements the [Writable Stream][] interface. This is an
    /// [EventEmitter][] with the following events:
    /// </p>
    /// </summary>
    public partial class ClientRequest
    {
        /// <summary>
        /// <p>Aborts a request.  (New since v0.3.8.)
        /// </p>
        /// </summary>
        public object abort() { return null; }
        /// <summary>
        /// <p>Finishes sending the request. If any parts of the body are
        /// unsent, it will flush them to the stream. If the request is
        /// chunked, this will send the terminating <code>&#39;0\r\n\r\n&#39;</code>.
        /// </p>
        /// <p>If <code>data</code> is specified, it is equivalent to calling
        /// <code>request.write(data, encoding)</code> followed by <code>request.end()</code>.
        /// </p>
        /// </summary>
        public object end() { return null; }
        /// <summary>
        /// <p>Finishes sending the request. If any parts of the body are
        /// unsent, it will flush them to the stream. If the request is
        /// chunked, this will send the terminating <code>&#39;0\r\n\r\n&#39;</code>.
        /// </p>
        /// <p>If <code>data</code> is specified, it is equivalent to calling
        /// <code>request.write(data, encoding)</code> followed by <code>request.end()</code>.
        /// </p>
        /// </summary>
        public object end(object encoding) { return null; }
        /// <summary>
        /// <p>Finishes sending the request. If any parts of the body are
        /// unsent, it will flush them to the stream. If the request is
        /// chunked, this will send the terminating <code>&#39;0\r\n\r\n&#39;</code>.
        /// </p>
        /// <p>If <code>data</code> is specified, it is equivalent to calling
        /// <code>request.write(data, encoding)</code> followed by <code>request.end()</code>.
        /// </p>
        /// </summary>
        public object end(object data, object encoding) { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setNoDelay()][] will be called.
        /// </p>
        /// </summary>
        public object setNoDelay() { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setNoDelay()][] will be called.
        /// </p>
        /// </summary>
        public object setNoDelay(object noDelay) { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setKeepAlive()][] will be called.
        /// </p>
        /// </summary>
        public object setSocketKeepAlive() { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setKeepAlive()][] will be called.
        /// </p>
        /// </summary>
        public object setSocketKeepAlive(object initialDelay) { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setKeepAlive()][] will be called.
        /// </p>
        /// </summary>
        public object setSocketKeepAlive(object enable, object initialDelay) { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setTimeout()][] will be called.
        /// </p>
        /// </summary>
        public object setTimeout(object timeout) { return null; }
        /// <summary>
        /// <p>Once a socket is assigned to this request and is connected
        /// [socket.setTimeout()][] will be called.
        /// </p>
        /// </summary>
        public object setTimeout(object timeout, object callback) { return null; }
        /// <summary>
        /// Sends a chunk of the body. By calling this method many times, the user can stream a request body to a server--in that case it is suggested to use the ['Transfer-Encoding', 'chunked'] header line when creating the request.
        /// </summary>
        /// <param name="chunk">The chunk argument should be a Buffer or a string.</param>
        /// <returns></returns>
        public object write(Buffer chunk) { return null; }
        /// <summary>
        /// Sends a chunk of the body. By calling this method many times, the user can stream a request body to a server--in that case it is suggested to use the ['Transfer-Encoding', 'chunked'] header line when creating the request.
        /// </summary>
        /// <param name="chunk">The chunk argument should be a Buffer or a string.</param>
        /// <param name="encoding">The encoding argument is optional and only applies when chunk is a string. Defaults to 'utf8'.</param>
        /// <returns></returns>
        public object write(JsString chunk, JsString encoding) { return null; }
        /// <summary>
        /// Sends a chunk of the body. By calling this method many times, the user can stream a request body to a server--in that case it is suggested to use the ['Transfer-Encoding', 'chunked'] header line when creating the request.
        /// </summary>
        /// <param name="chunk">The chunk argument should be a Buffer or a string.</param>
        /// <returns></returns>
        public object write(JsString chunk) { return null; }

        #region methods
        /// <summary>
        /// function (response) { }
        /// Emitted when a response is received to this request. This event is emitted only once. The response argument will be an instance of http.ClientResponse.
        /// </summary>
        public JsAction<ClientResponse> response { get; set; }
        /// <summary>
        /// function (socket) { }
        /// Emitted after a socket is assigned to this request.
        /// </summary>
        public JsAction<Socket> socket { get; set; }
        /// <summary>
        /// function (response, socket, head) { }
        ///
        ///Emitted each time a server responds to a request with a CONNECT method. If this event isn't being listened for, clients receiving a CONNECT method will have their connections closed.
        /// </summary>
        /// <example>
        ///A client server pair that show you how to listen for the connect event.
        ///<code>
        ///var http = require('http');
        ///var net = require('net');
        ///var url = require('url');
        ///
        ///  // Create an HTTP tunneling proxy
        ///var proxy = http.createServer(function (req, res) {
        ///  res.writeHead(200, {'Content-Type': 'text/plain'});
        ///  res.end('okay');
        ///});
        ///proxy.on('connect', function(req, cltSocket, head) {
        ///  /// connect to an origin server
        ///  var srvUrl = url.parse('http:///' + req.url);
        ///  var srvSocket = net.connect(srvUrl.port, srvUrl.hostname, function() {
        ///    cltSocket.write('HTTP/1.1 200 Connection Established\r\n' +
        ///                    'Proxy-agent: Node-Proxy\r\n' +
        ///                    '\r\n');
        ///    srvSocket.write(head);
        ///    srvSocket.pipe(cltSocket);
        ///    cltSocket.pipe(srvSocket);
        ///  });
        ///});
        ///
        /// // now that proxy is running
        ///proxy.listen(1337, '127.0.0.1', function() {
        ///
        ///  // make a request to a tunneling proxy
        ///  var options = {
        ///    port: 1337,
        ///    hostname: '127.0.0.1',
        ///    method: 'CONNECT',
        ///    path: 'www.google.com:80'
        ///  };
        ///
        ///  var req = http.request(options);
        ///  req.end();

        ///  req.on('connect', function(res, socket, head) {
        ///    console.log('got connected!');

        ///    // make a request over an HTTP tunnel
        ///    socket.write('GET / HTTP/1.1\r\n' +
        ///                 'Host: www.google.com:80\r\n' +
        ///                 'Connection: close\r\n' +
        ///                 '\r\n');
        ///    socket.on('data', function(chunk) {
        ///      console.log(chunk.toString());
        ///    });
        ///    socket.on('end', function() {
        ///      proxy.close();
        ///    });
        ///  });
        ///});
        /// </code>
        /// </example>
        public JsAction<JsNumber, JsString, JsAction> connect { get; set; }
        /// <summary>
        /// function (response, socket, head) { }
        /// </summary>
        /// <example>
        ///Emitted each time a server responds to a request with an upgrade. If this event isn't being listened for, clients receiving an upgrade header will have their connections closed.
        ///<code>
        ///A client server pair that show you how to listen for the upgrade event.
        ///
        ///var http = require('http');
        ///
        /// // Create an HTTP server
        ///var srv = http.createServer(function (req, res) {
        ///  res.writeHead(200, {'Content-Type': 'text/plain'});
        ///  res.end('okay');
        ///});
        ///srv.on('upgrade', function(req, socket, head) {
        ///  socket.write('HTTP/1.1 101 Web Socket Protocol Handshake\r\n' +
        ///               'Upgrade: WebSocket\r\n' +
        ///               'Connection: Upgrade\r\n' +
        ///               '\r\n');
        ///
        ///  socket.pipe(socket); /// echo back
        ///});
        ///
        /// // now that server is running
        ///srv.listen(1337, '127.0.0.1', function() {
        ///
        ///  // make a request
        ///  var options = {
        ///    port: 1337,
        ///    hostname: '127.0.0.1',
        ///    headers: {
        ///      'Connection': 'Upgrade',
        ///      'Upgrade': 'websocket'
        ///    }
        ///  };
        ///
        ///  var req = http.request(options);
        ///  req.end();
        ///
        ///  req.on('upgrade', function(res, socket, upgradeHead) {
        ///    console.log('got upgraded!');
        ///    socket.end();
        ///    process.exit(0);
        ///  });
        ///  });
        ///</code>
        ///</example>
        public JsAction<JsNumber, JsString, JsAction> upgrade { get; set; }
        /// <summary>
        /// function () { }
        /// Emitted when the server sends a '100 Continue' HTTP response, usually because the request contained 'Expect: 100-continue'. This is an instruction that the client should send the request body.
        /// </summary>
        [JsProperty(Name = "continue")]
        public JsAction @continue { get; set; }
        //TODO: event name is continue
        #endregion
    }
    #region ResponseOptions
    [JsType(JsMode.Json)]
    public partial class ResponseOptions
    {
        /// <summary>
        ///  A domain name or IP address of the server to issue the request to.
        /// </summary>
        public JsString host { get; set; }
        /// <summary>
        /// Port of remote server.
        /// </summary>
        public JsNumber port { get; set; }
        /// <summary>
        /// Unix Domain Socket (use one of host:port or socketPath)
        /// </summary>
        public object socketPath { get; set; }

    }
    #endregion
}
