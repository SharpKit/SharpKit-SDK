using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.net
{
    /// <summary>
    /// 
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "net")]
    public partial class Utils
    {
        /// <summary>
        /// Creates a new TCP server. The connectionListener argument is automatically set as a listener for the 'connection' event.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// Here is an example of an echo server which listens for connections on port 8124:
        /// <code>
        ///var net = require('net');
        ///var server = net.createServer(function(c) { //'connection' listener
        ///  console.log('server connected');
        ///  c.on('end', function() {
        ///    console.log('server disconnected');
        ///  });
        ///  c.write('hello\r\n');
        ///  c.pipe(c);
        ///});
        ///server.listen(8124, function() { //'listening' listener
        ///  console.log('server bound');
        ///});
        ///</code> </example>
        ///<example>
        ///Test this by using telnet:
        ///<code> telnet localhost 8124 </code>
        ///To listen on the socket /tmp/echo.sock the third line from the last would just be changed to
        ///<code>
        ///server.listen('/tmp/echo.sock', function() { //'listening' listener
        ///Use nc to connect to a UNIX domain socket server:
        ///nc -U /tmp/echo.sock
        /// </code>
        /// </example>
        public object createServer() { return null; }
        /// <summary>
        /// Creates a new TCP server. The connectionListener argument is automatically set as a listener for the 'connection' event.
        /// </summary>
        /// <param name="options">options is an object with the following defaults:
        ///<example>
        ///<code>
        /// { allowHalfOpen: false
        /// }
        /// If allowHalfOpen is true, then the socket won't automatically send a FIN packet when the other end of the socket sends a FIN packet. The socket becomes non-readable, but still writable. You should call the end() method explicitly. See 'end' event for more information.</param>
        /// </code>
        /// </example>
        /// <param name="connectionListener"></param>
        /// <returns></returns>
        /// <example>
        /// Here is an example of an echo server which listens for connections on port 8124:
        /// <code>
        ///var net = require('net');
        ///var server = net.createServer(function(c) { //'connection' listener
        ///  console.log('server connected');
        ///  c.on('end', function() {
        ///    console.log('server disconnected');
        ///  });
        ///  c.write('hello\r\n');
        ///  c.pipe(c);
        ///});
        ///server.listen(8124, function() { //'listening' listener
        ///  console.log('server bound');
        ///});
        ///</code> </example>
        ///<example>
        ///Test this by using telnet:
        ///<code> telnet localhost 8124 </code>
        ///To listen on the socket /tmp/echo.sock the third line from the last would just be changed to
        ///<code>
        ///server.listen('/tmp/echo.sock', function() { //'listening' listener
        ///Use nc to connect to a UNIX domain socket server:
        ///nc -U /tmp/echo.sock
        /// </code>
        /// </example>
        public object createServer(CreateServerOptions options, JsAction connectionListener) { return null; }
        /// <summary>
        /// Creates a new TCP server. The connectionListener argument is automatically set as a listener for the 'connection' event.
        /// </summary>
        /// <param name="options">options is an object with the following defaults:
        ///<example>
        ///<code>
        /// { allowHalfOpen: false
        /// }
        /// If allowHalfOpen is true, then the socket won't automatically send a FIN packet when the other end of the socket sends a FIN packet. The socket becomes non-readable, but still writable. You should call the end() method explicitly. See 'end' event for more information.</param>
        /// </code>
        /// </example>
        /// <returns></returns>
        /// <example>
        /// Here is an example of an echo server which listens for connections on port 8124:
        /// <code>
        ///var net = require('net');
        ///var server = net.createServer(function(c) { //'connection' listener
        ///  console.log('server connected');
        ///  c.on('end', function() {
        ///    console.log('server disconnected');
        ///  });
        ///  c.write('hello\r\n');
        ///  c.pipe(c);
        ///});
        ///server.listen(8124, function() { //'listening' listener
        ///  console.log('server bound');
        ///});
        ///</code> </example>
        ///<example>
        ///Test this by using telnet:
        ///<code> telnet localhost 8124 </code>
        ///To listen on the socket /tmp/echo.sock the third line from the last would just be changed to
        ///<code>
        ///server.listen('/tmp/echo.sock', function() { //'listening' listener
        ///Use nc to connect to a UNIX domain socket server:
        ///nc -U /tmp/echo.sock
        /// </code>
        /// </example>
        public object createServer(CreateServerOptions options) { return null; }
        /// <summary>
        /// Creates a new TCP server. The connectionListener argument is automatically set as a listener for the 'connection' event.
        /// </summary>
        /// <param name="connectionListener"></param>
        /// <returns></returns>
        /// <example>
        /// Here is an example of an echo server which listens for connections on port 8124:
        /// <code>
        ///var net = require('net');
        ///var server = net.createServer(function(c) { //'connection' listener
        ///  console.log('server connected');
        ///  c.on('end', function() {
        ///    console.log('server disconnected');
        ///  });
        ///  c.write('hello\r\n');
        ///  c.pipe(c);
        ///});
        ///server.listen(8124, function() { //'listening' listener
        ///  console.log('server bound');
        ///});
        ///</code> </example>
        ///<example>
        ///Test this by using telnet:
        ///<code> telnet localhost 8124 </code>
        ///To listen on the socket /tmp/echo.sock the third line from the last would just be changed to
        ///<code>
        ///server.listen('/tmp/echo.sock', function() { //'listening' listener
        ///Use nc to connect to a UNIX domain socket server:
        ///nc -U /tmp/echo.sock
        /// </code>
        /// </example>
        public object createServer(JsAction connectionListener) { return null; }
        /// <summary>
        /// Creates a TCP connection to port on host. If host is omitted, 'localhost' will be assumed. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public object connect(JsNumber port) { return null; }
        /// <summary>
        /// Creates a TCP connection to port on host. If host is omitted, 'localhost' will be assumed. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="host"></param>
        /// <param name="connectListener"></param>
        /// <returns></returns>
        public object connect(JsNumber port, JsString host, JsAction connectListener) { return null; }
        /// <summary>
        /// Creates unix socket connection to path. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object connect(JsString path) { return null; }
        /// <summary>
        /// Creates unix socket connection to path. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="connectListener"></param>
        /// <returns></returns>
        public object connect(JsString path, JsAction connectListener) { return null; }
        /// <summary>
        /// Constructs a new socket object and opens the socket to the given location. When the socket is established, the 'connect' event will be emitted.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public object connect(ConnectOptions options) { return null; }
        /// <summary>
        /// Constructs a new socket object and opens the socket to the given location. When the socket is established, the 'connect' event will be emitted.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="connectListener"></param>
        /// <returns></returns>
        public object connect(ConnectOptions options, JsAction connectListener) { return null; }
        /// <summary>
        /// Constructs a new socket object and opens the socket to the given location. When the socket is established, the 'connect' event will be emitted.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public object createConnection(ConnectOptions options) { return null; }
        public object createConnection(object options) { return null; }
        /// <summary>
        /// Constructs a new socket object and opens the socket to the given location. When the socket is established, the 'connect' event will be emitted.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="connectionListener"></param>
        /// <returns></returns>
        public object createConnection(ConnectOptions options, JsAction connectionListener) { return null; }
        /// <summary>
        /// Creates a TCP connection to port on host. If host is omitted, 'localhost' will be assumed. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public object createConnection(JsNumber port) { return null; }
        /// <summary>
        /// Creates a TCP connection to port on host. If host is omitted, 'localhost' will be assumed. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="host"></param>
        /// <param name="connectListener"></param>
        /// <returns></returns>
        public object createConnection(JsNumber port, JsString host, JsAction connectListener) { return null; }
        /// <summary>
        /// Creates unix socket connection to path. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public object createConnection(JsString path) { return null; }
        /// <summary>
        /// Creates unix socket connection to path. The connectListener parameter will be added as an listener for the 'connect' event.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="connectListener"></param>
        /// <returns></returns>
        public object createConnection(JsString path, JsAction connectListener) { return null; }
    }
    #region CreateServerOptions
    [JsType(JsMode.Json)]
    public partial class CreateServerOptions
    {
        public bool allowHalfOpen { get; set; }
    }
    #endregion
    #region ConnectOptions
    [JsType(JsMode.Json)]
    public partial class ConnectOptions : CreateServerOptions
    {
        /// <summary>
        ///  Port the client should connect to (Required).
        /// </summary>
        public object port { get; set; }
        /// <summary>
        ///  Host the client should connect to. Defaults to 'localhost'.
        /// </summary>
        public JsString host { get; set; }
        /// <summary>
        ///  Local interface to bind to for network connections.
        /// </summary>
        public object localAdress { get; set; }
        /// <summary>
        ///  Path the client should connect to (Required).
        /// </summary>
        public JsString path { get; set; }
    }
    #endregion
}

