using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.net
{
    /// <summary>
    /// <p>This class is used to create a TCP or UNIX server.
    /// A server is a <code>net.Socket</code> that can listen for new incoming connections.
    /// </p>
    /// </summary>
    public partial class Server
    {
        /// <summary>
        /// <p>Returns the bound address, the address family name and port of the server
        /// as reported by the operating system.
        /// Useful to find which port was assigned when giving getting an OS-assigned address.
        /// Returns an object with three properties, e.g.
        /// <code>{ port: 12346, family: &#39;IPv4&#39;, address: &#39;127.0.0.1&#39; }</code>
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var server = net.createServer(function (socket) {
        /// socket.end(&quot;goodbye\n&quot;);
        /// });
        /// // grab a random port.
        /// server.listen(function() {
        /// address = server.address();
        /// console.log(&quot;opened server on %j&quot;, address);
        /// });</code></pre>
        /// <p>Don&#39;t call <code>server.address()</code> until the <code>&#39;listening&#39;</code> event has been emitted.
        /// </p>
        /// </summary>
        public object address() { return null; }
        /// <summary>
        /// <p>Stops the server from accepting new connections and keeps existing
        /// connections. This function is asynchronous, the server is finally
        /// closed when all connections are ended and the server emits a <code>&#39;close&#39;</code>
        /// event. Optionally, you can pass a callback to listen for the <code>&#39;close&#39;</code>
        /// event.
        /// </p>
        /// </summary>
        public object close() { return null; }
        /// <summary>
        /// <p>Stops the server from accepting new connections and keeps existing
        /// connections. This function is asynchronous, the server is finally
        /// closed when all connections are ended and the server emits a <code>&#39;close&#39;</code>
        /// event. Optionally, you can pass a callback to listen for the <code>&#39;close&#39;</code>
        /// event.
        /// </p>
        /// </summary>
        public object close(JsAction callback) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified <code>port</code> and <code>host</code>.  If the
        /// <code>host</code> is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>). A port value of zero will assign a random port.
        /// </p>
        /// <p>Backlog is the maximum length of the queue of pending connections.
        /// The actual length will be determined by your OS through sysctl settings such as
        /// <code>tcp_max_syn_backlog</code> and <code>somaxconn</code> on linux. The default value of this
        /// parameter is 511 (not 512).
        /// </p>
        /// <p>This function is asynchronous.  When the server has been bound,
        /// [&#39;listening&#39;][] event will be emitted.  The last parameter <code>callback</code>
        /// will be added as an listener for the [&#39;listening&#39;][] event.
        /// </p>
        /// <p>One issue some users run into is getting <code>EADDRINUSE</code> errors. This means that
        /// another server is already running on the requested port. One way of handling this
        /// would be to wait a second and then try again. This can be done with
        /// </p>
        /// <pre><code>server.on(&#39;error&#39;, function (e) {
        /// if (e.code == &#39;EADDRINUSE&#39;) {
        /// console.log(&#39;Address in use, retrying...&#39;);
        /// setTimeout(function () {
        /// server.close();
        /// server.listen(PORT, HOST);
        /// }, 1000);
        /// }
        /// });</code></pre>
        /// <p>(Note: All sockets in Node set <code>SO_REUSEADDR</code> already)
        /// </p>
        /// </summary>
        public object listen(object port) { return null; }

        /// <summary>
        /// <p>Begin accepting connections on the specified <code>port</code> and <code>host</code>.  If the
        /// <code>host</code> is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>). A port value of zero will assign a random port.
        /// </p>
        /// <p>Backlog is the maximum length of the queue of pending connections.
        /// The actual length will be determined by your OS through sysctl settings such as
        /// <code>tcp_max_syn_backlog</code> and <code>somaxconn</code> on linux. The default value of this
        /// parameter is 511 (not 512).
        /// </p>
        /// <p>This function is asynchronous.  When the server has been bound,
        /// [&#39;listening&#39;][] event will be emitted.  The last parameter <code>callback</code>
        /// will be added as an listener for the [&#39;listening&#39;][] event.
        /// </p>
        /// <p>One issue some users run into is getting <code>EADDRINUSE</code> errors. This means that
        /// another server is already running on the requested port. One way of handling this
        /// would be to wait a second and then try again. This can be done with
        /// </p>
        /// <pre><code>server.on(&#39;error&#39;, function (e) {
        /// if (e.code == &#39;EADDRINUSE&#39;) {
        /// console.log(&#39;Address in use, retrying...&#39;);
        /// setTimeout(function () {
        /// server.close();
        /// server.listen(PORT, HOST);
        /// }, 1000);
        /// }
        /// });</code></pre>
        /// <p>(Note: All sockets in Node set <code>SO_REUSEADDR</code> already)
        /// </p>
        /// </summary>
        public object listen(object port, object backlog, JsAction callback) { return null; }
        /// <summary>
        /// <p>Begin accepting connections on the specified <code>port</code> and <code>host</code>.  If the
        /// <code>host</code> is omitted, the server will accept connections directed to any
        /// IPv4 address (<code>INADDR_ANY</code>). A port value of zero will assign a random port.
        /// </p>
        /// <p>Backlog is the maximum length of the queue of pending connections.
        /// The actual length will be determined by your OS through sysctl settings such as
        /// <code>tcp_max_syn_backlog</code> and <code>somaxconn</code> on linux. The default value of this
        /// parameter is 511 (not 512).
        /// </p>
        /// <p>This function is asynchronous.  When the server has been bound,
        /// [&#39;listening&#39;][] event will be emitted.  The last parameter <code>callback</code>
        /// will be added as an listener for the [&#39;listening&#39;][] event.
        /// </p>
        /// <p>One issue some users run into is getting <code>EADDRINUSE</code> errors. This means that
        /// another server is already running on the requested port. One way of handling this
        /// would be to wait a second and then try again. This can be done with
        /// </p>
        /// <pre><code>server.on(&#39;error&#39;, function (e) {
        /// if (e.code == &#39;EADDRINUSE&#39;) {
        /// console.log(&#39;Address in use, retrying...&#39;);
        /// setTimeout(function () {
        /// server.close();
        /// server.listen(PORT, HOST);
        /// }, 1000);
        /// }
        /// });</code></pre>
        /// <p>(Note: All sockets in Node set <code>SO_REUSEADDR</code> already)
        /// </p>
        /// </summary>
        public object listen(object port, object host, object backlog, JsAction callback) { return null; }
        /// <summary>
        /// <p>Start a UNIX socket server listening for connections on the given <code>path</code>.
        /// </p>
        /// <p>This function is asynchronous.  When the server has been bound,
        /// [&#39;listening&#39;][] event will be emitted.  The last parameter <code>callback</code>
        /// will be added as an listener for the [&#39;listening&#39;][] event.
        /// </p>
        /// </summary>
        public object listen(object path, JsAction callback) { return null; }
       
        //TODO: server.maxConnections, server.connections

        #region Events
        /// <summary>
        /// Emitted when the server has been bound after calling server.listen.
        /// </summary>
        public JsAction listening { get; set; }
        /// <summary>
        /// Emitted when a new connection is made. socket is an instance of net.Socket.
        /// </summary>
        public JsAction<Socket> connection { get; set; }
        /// <summary>
        /// Emitted when the server closes. Note that if connections exist, this event is not emitted until all connections are ended.
        /// </summary>
        [JsProperty(Name = "close")]
        public JsAction closeEvent { get; set; }
        /// <summary>
        /// Emitted when an error occurs. The 'close' event will be called directly following this event. See example in discussion of server.listen.
        /// </summary>
        public JsAction<Object> error { get; set; }

        #endregion
    }
}
