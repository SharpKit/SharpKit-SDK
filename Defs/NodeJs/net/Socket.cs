using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.net
{
    /// <summary>
    /// <p>This object is an abstraction of a TCP or UNIX socket.  <code>net.Socket</code>
    /// instances implement a duplex Stream interface.  They can be created by the
    /// user and used as a client (with <code>connect()</code>) or they can be created by Node
    /// and passed to the user through the <code>&#39;connection&#39;</code> event of a server.
    /// </p>
    /// </summary>
    public partial class Socket
    {
        public Socket() { }
        /// <summary>
        /// <p>Construct a new socket object.
        /// </p>
        /// <p><code>options</code> is an object with the following defaults:
        /// </p>
        /// <pre><code>{ fd: null
        /// type: null
        /// allowHalfOpen: false
        /// }</code></pre>
        /// <p><code>fd</code> allows you to specify the existing file descriptor of socket. <code>type</code>
        /// specified underlying protocol. It can be <code>&#39;tcp4&#39;</code>, <code>&#39;tcp6&#39;</code>, or <code>&#39;unix&#39;</code>.
        /// About <code>allowHalfOpen</code>, refer to <code>createServer()</code> and <code>&#39;end&#39;</code> event.
        /// </p>
        /// </summary>
        public Socket(SocketOptions options) { }
        /// <summary>
        /// <p>Returns the bound address, the address family name and port of the
        /// socket as reported by the operating system. Returns an object with
        /// three properties, e.g.
        /// <code>{ port: 12346, family: &#39;IPv4&#39;, address: &#39;127.0.0.1&#39; }</code>
        /// </p>
        /// </summary>
        public object address() { return null; }
        /// <summary>
        /// <p>Opens the connection for a given socket. If <code>port</code> and <code>host</code> are given,
        /// then the socket will be opened as a TCP socket, if <code>host</code> is omitted,
        /// <code>localhost</code> will be assumed. If a <code>path</code> is given, the socket will be
        /// opened as a unix socket to that path.
        /// </p>
        /// <p>Normally this method is not needed, as <code>net.createConnection</code> opens the
        /// socket. Use this only if you are implementing a custom Socket or if a
        /// Socket is closed and you want to reuse it to connect to another server.
        /// </p>
        /// <p>This function is asynchronous. When the [&#39;connect&#39;][] event is emitted the
        /// socket is established. If there is a problem connecting, the <code>&#39;connect&#39;</code> event
        /// will not be emitted, the <code>&#39;error&#39;</code> event will be emitted with the exception.
        /// </p>
        /// <p>The <code>connectListener</code> parameter will be added as an listener for the
        /// [&#39;connect&#39;][] event.
        /// </p>
        /// </summary>
        public object connect(object path) { return null; }
        /// <summary>
        /// <p>Opens the connection for a given socket. If <code>port</code> and <code>host</code> are given,
        /// then the socket will be opened as a TCP socket, if <code>host</code> is omitted,
        /// <code>localhost</code> will be assumed. If a <code>path</code> is given, the socket will be
        /// opened as a unix socket to that path.
        /// </p>
        /// <p>Normally this method is not needed, as <code>net.createConnection</code> opens the
        /// socket. Use this only if you are implementing a custom Socket or if a
        /// Socket is closed and you want to reuse it to connect to another server.
        /// </p>
        /// <p>This function is asynchronous. When the [&#39;connect&#39;][] event is emitted the
        /// socket is established. If there is a problem connecting, the <code>&#39;connect&#39;</code> event
        /// will not be emitted, the <code>&#39;error&#39;</code> event will be emitted with the exception.
        /// </p>
        /// <p>The <code>connectListener</code> parameter will be added as an listener for the
        /// [&#39;connect&#39;][] event.
        /// </p>
        /// </summary>
        public object connect(object path, object connectListener) { return null; }
        /// <summary>
        /// <p>Opens the connection for a given socket. If <code>port</code> and <code>host</code> are given,
        /// then the socket will be opened as a TCP socket, if <code>host</code> is omitted,
        /// <code>localhost</code> will be assumed. If a <code>path</code> is given, the socket will be
        /// opened as a unix socket to that path.
        /// </p>
        /// <p>Normally this method is not needed, as <code>net.createConnection</code> opens the
        /// socket. Use this only if you are implementing a custom Socket or if a
        /// Socket is closed and you want to reuse it to connect to another server.
        /// </p>
        /// <p>This function is asynchronous. When the [&#39;connect&#39;][] event is emitted the
        /// socket is established. If there is a problem connecting, the <code>&#39;connect&#39;</code> event
        /// will not be emitted, the <code>&#39;error&#39;</code> event will be emitted with the exception.
        /// </p>
        /// <p>The <code>connectListener</code> parameter will be added as an listener for the
        /// [&#39;connect&#39;][] event.
        /// </p>
        /// </summary>
        public object connect(object port, object host, object connectListener) { return null; }
        /// <summary>
        /// <p>Ensures that no more I/O activity happens on this socket. Only necessary in
        /// case of errors (parse error or so).
        /// </p>
        /// </summary>
        public object destroy() { return null; }
        /// <summary>
        /// <p>Half-closes the socket. i.e., it sends a FIN packet. It is possible the
        /// server will still send some data.
        /// </p>
        /// <p>If <code>data</code> is specified, it is equivalent to calling
        /// <code>socket.write(data, encoding)</code> followed by <code>socket.end()</code>.
        /// </p>
        /// </summary>
        public object end() { return null; }
        /// <summary>
        /// <p>Half-closes the socket. i.e., it sends a FIN packet. It is possible the
        /// server will still send some data.
        /// </p>
        /// <p>If <code>data</code> is specified, it is equivalent to calling
        /// <code>socket.write(data, encoding)</code> followed by <code>socket.end()</code>.
        /// </p>
        /// </summary>
        public object end(object encoding) { return null; }
        /// <summary>
        /// <p>Half-closes the socket. i.e., it sends a FIN packet. It is possible the
        /// server will still send some data.
        /// </p>
        /// <p>If <code>data</code> is specified, it is equivalent to calling
        /// <code>socket.write(data, encoding)</code> followed by <code>socket.end()</code>.
        /// </p>
        /// </summary>
        public object end(object data, object encoding) { return null; }
        /// <summary>
        /// <p>Pauses the reading of data. That is, <code>&#39;data&#39;</code> events will not be emitted.
        /// Useful to throttle back an upload.
        /// </p>
        /// </summary>
        public object pause() { return null; }
        /// <summary>
        /// <p>Resumes reading after a call to <code>pause()</code>.
        /// </p>
        /// </summary>
        public object resume() { return null; }
        /// <summary>
        /// <p>Set the encoding for the socket as a Readable Stream. See
        /// [stream.setEncoding()][] for more information.
        /// </p>
        /// </summary>
        public object setEncoding() { return null; }
        /// <summary>
        /// <p>Set the encoding for the socket as a Readable Stream. See
        /// [stream.setEncoding()][] for more information.
        /// </p>
        /// </summary>
        public object setEncoding(object encoding) { return null; }
        /// <summary>
        /// <p>Enable/disable keep-alive functionality, and optionally set the initial
        /// delay before the first keepalive probe is sent on an idle socket.
        /// <code>enable</code> defaults to <code>false</code>.
        /// </p>
        /// <p>Set <code>initialDelay</code> (in milliseconds) to set the delay between the last
        /// data packet received and the first keepalive probe. Setting 0 for
        /// initialDelay will leave the value unchanged from the default
        /// (or previous) setting. Defaults to <code>0</code>.
        /// </p>
        /// </summary>
        public object setKeepAlive() { return null; }
        /// <summary>
        /// <p>Enable/disable keep-alive functionality, and optionally set the initial
        /// delay before the first keepalive probe is sent on an idle socket.
        /// <code>enable</code> defaults to <code>false</code>.
        /// </p>
        /// <p>Set <code>initialDelay</code> (in milliseconds) to set the delay between the last
        /// data packet received and the first keepalive probe. Setting 0 for
        /// initialDelay will leave the value unchanged from the default
        /// (or previous) setting. Defaults to <code>0</code>.
        /// </p>
        /// </summary>
        public object setKeepAlive(object initialDelay) { return null; }
        /// <summary>
        /// <p>Enable/disable keep-alive functionality, and optionally set the initial
        /// delay before the first keepalive probe is sent on an idle socket.
        /// <code>enable</code> defaults to <code>false</code>.
        /// </p>
        /// <p>Set <code>initialDelay</code> (in milliseconds) to set the delay between the last
        /// data packet received and the first keepalive probe. Setting 0 for
        /// initialDelay will leave the value unchanged from the default
        /// (or previous) setting. Defaults to <code>0</code>.
        /// </p>
        /// </summary>
        public object setKeepAlive(bool enable, object initialDelay) { return null; }
        /// <summary>
        /// <p>Disables the Nagle algorithm. By default TCP connections use the Nagle
        /// algorithm, they buffer data before sending it off. Setting <code>true</code> for
        /// <code>noDelay</code> will immediately fire off data each time <code>socket.write()</code> is called.
        /// <code>noDelay</code> defaults to <code>true</code>.
        /// </p>
        /// </summary>
        public object setNoDelay() { return null; }
        /// <summary>
        /// <p>Disables the Nagle algorithm. By default TCP connections use the Nagle
        /// algorithm, they buffer data before sending it off. Setting <code>true</code> for
        /// <code>noDelay</code> will immediately fire off data each time <code>socket.write()</code> is called.
        /// <code>noDelay</code> defaults to <code>true</code>.
        /// </p>
        /// </summary>
        public object setNoDelay(bool noDelay) { return null; }
        /// <summary>
        /// <p>Sets the socket to timeout after <code>timeout</code> milliseconds of inactivity on
        /// the socket. By default <code>net.Socket</code> do not have a timeout.
        /// </p>
        /// <p>When an idle timeout is triggered the socket will receive a <code>&#39;timeout&#39;</code>
        /// event but the connection will not be severed. The user must manually <code>end()</code>
        /// or <code>destroy()</code> the socket.
        /// </p>
        /// <p>If <code>timeout</code> is 0, then the existing idle timeout is disabled.
        /// </p>
        /// <p>The optional <code>callback</code> parameter will be added as a one time listener for the
        /// <code>&#39;timeout&#39;</code> event.
        /// </p>
        /// </summary>
        public object setTimeout(object timeout) { return null; }
        /// <summary>
        /// <p>Sets the socket to timeout after <code>timeout</code> milliseconds of inactivity on
        /// the socket. By default <code>net.Socket</code> do not have a timeout.
        /// </p>
        /// <p>When an idle timeout is triggered the socket will receive a <code>&#39;timeout&#39;</code>
        /// event but the connection will not be severed. The user must manually <code>end()</code>
        /// or <code>destroy()</code> the socket.
        /// </p>
        /// <p>If <code>timeout</code> is 0, then the existing idle timeout is disabled.
        /// </p>
        /// <p>The optional <code>callback</code> parameter will be added as a one time listener for the
        /// <code>&#39;timeout&#39;</code> event.
        /// </p>
        /// </summary>
        public object setTimeout(object timeout, JsAction callback) { return null; }

        /// <summary>
        /// <p>Sends data on the socket. The second parameter specifies the encoding in the
        /// case of a string--it defaults to UTF8 encoding.
        /// </p>
        /// <p>Returns <code>true</code> if the entire data was flushed successfully to the kernel
        /// buffer. Returns <code>false</code> if all or part of the data was queued in user memory.
        /// <code>&#39;drain&#39;</code> will be emitted when the buffer is again free.
        /// </p>
        /// <p>The optional <code>callback</code> parameter will be executed when the data is finally
        /// written out - this may not be immediately.
        /// </p>
        /// </summary>
        public bool write(object data) { return false; }
        /// <summary>
        /// <p>Sends data on the socket. The second parameter specifies the encoding in the
        /// case of a string--it defaults to UTF8 encoding.
        /// </p>
        /// <p>Returns <code>true</code> if the entire data was flushed successfully to the kernel
        /// buffer. Returns <code>false</code> if all or part of the data was queued in user memory.
        /// <code>&#39;drain&#39;</code> will be emitted when the buffer is again free.
        /// </p>
        /// <p>The optional <code>callback</code> parameter will be executed when the data is finally
        /// written out - this may not be immediately.
        /// </p>
        /// </summary>
        public bool write(object data, object callback) { return false; }
        /// <summary>
        /// <p>Sends data on the socket. The second parameter specifies the encoding in the
        /// case of a string--it defaults to UTF8 encoding.
        /// </p>
        /// <p>Returns <code>true</code> if the entire data was flushed successfully to the kernel
        /// buffer. Returns <code>false</code> if all or part of the data was queued in user memory.
        /// <code>&#39;drain&#39;</code> will be emitted when the buffer is again free.
        /// </p>
        /// <p>The optional <code>callback</code> parameter will be executed when the data is finally
        /// written out - this may not be immediately.
        /// </p>
        /// </summary>
        public bool write(object data, object encoding, JsAction callback) { return false; }
        #region Events
        /// <summary>
        /// Emitted when a socket connection is successfully established. See connect().
        /// </summary>
        [JsProperty(Name= "conect")]
        public JsAction connectEvent { get; set; }
        /// <summary>
        /// Emitted when data is received. The argument data will be a Buffer or String. Encoding of data is set by socket.setEncoding(). (See the Readable Stream section for more information.)
        ///
        /// Note that the data will be lost if there is no listener when a Socket emits a 'data' event.
        /// </summary>
        public JsAction<Buffer> data { get; set; }
        /// <summary>
        /// Emitted when the other end of the socket sends a FIN packet.
        /// By default (allowHalfOpen == false) the socket will destroy its file descriptor once it has written out its pending write queue. However, by setting allowHalfOpen == true the socket will not automatically end() its side allowing the user to write arbitrary amounts of data, with the caveat that the user is required to end() their side now.
        /// </summary>
        [JsProperty(Name = "end")]
        public JsAction endEvent { get; set; }
        /// <summary>
        /// Emitted if the socket times out from inactivity. This is only to notify that the socket has been idle. The user must manually close the connection.
        /// See also: socket.setTimeout()
        /// </summary>
        public JsAction timeout { get; set; }
        /// <summary>
        /// Emitted when the write buffer becomes empty. Can be used to throttle uploads.
        ///
        /// See also: the return values of socket.write()
        /// </summary>
        public JsAction drain { get; set; }
        /// <summary>
        /// Emitted when an error occurs. The 'close' event will be called directly following this event.
        /// </summary>
        public JsAction<object> error { get; set; }
        /// <summary>
        /// Emitted once the socket is fully closed. The argument had_error is a boolean which says if the socket was closed due to a transmission error.
        /// </summary>
        public JsAction<bool> close { get; set; }
        #endregion

    }
    [JsType(JsMode.Json)]
    public partial class SocketOptions
    {
        public JsNumber fd { get; set; }
        public object type { get; set; }
        public bool allowHalfOpen { get; set; }
    }
}
