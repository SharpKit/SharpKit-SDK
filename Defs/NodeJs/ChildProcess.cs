using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p><code>ChildProcess</code> is an [EventEmitter][].
    /// </p>
    /// <p>Child processes always have three streams associated with them. <code>child.stdin</code>,
    /// <code>child.stdout</code>, and <code>child.stderr</code>.  These may be shared with the stdio
    /// streams of the parent process, or they may be separate stream objects
    /// which can be piped to and from.
    /// </p>
    /// <p>The ChildProcess class is not intended to be used directly.  Use the
    /// <code>spawn()</code> or <code>fork()</code> methods to create a Child Process instance.
    /// </p>
    /// </summary>
    public partial class ChildProcess
    {
        #region static
        /// <summary>
        /// Runs a command in a shell and buffers the output.
        /// <example>
        /// <code>
        /// var exec = require('child_process').exec,
        ///    child;
        ///
        // child = exec('cat *.js bad_file | wc -l',
        ///     function (error, stdout, stderr) {
        ///     console.log('stdout: ' + stdout);
        ///     console.log('stderr: ' + stderr);
        ///     if (error !== null) {
        ///       console.log('exec error: ' + error);
        ///     }
        /// });
        /// </code>
        /// The callback gets the arguments (error, stdout, stderr). On success, error will be null. On error, error will be an instance of Error and err.code will be the exit code of the child process, and err.signal will be set to the signal that terminated the process.
        /// </example>
        /// <example>There is a second optional argument to specify several options. The default options are
        /// <code>
        /// { encoding: 'utf8',
        ///  timeout: 0,
        ///  maxBuffer: 200*1024,
        ///  killSignal: 'SIGTERM',
        ///  cwd: null,
        ///  env: null }
        /// </code>
        /// If timeout is greater than 0, then it will kill the child process if it runs longer than timeout milliseconds. The child process is killed with killSignal (default: 'SIGTERM'). maxBuffer specifies the largest amount of data allowed on stdout or stderr - if this value is exceeded then the child process is killed.
        /// </example>
        /// </summary>
        /// <param name="command">The command to run, with space-separated arguments</param>
        /// <param name="options">options Object
        /// <list type="bullets">
        /// <item> cwd String Current working directory of the child process</item>
        /// <item> stdio Array|String Child's stdio configuration. (See above)</item>
        /// <item> customFds Array Deprecated File descriptors for the child to use for stdio.</item>
        /// <item> env Object Environment key-value pairs</item>
        /// <item> encoding String (Default: 'utf8')</item>
        /// <item> timeout Number (Default: 0)</item>
        /// <item> maxBuffer Number (Default: 200*1024)</item>
        /// <item> killSignal String (Default: 'SIGTERM')</item></list></param>
        /// <param name="callback">Function called with the output when process terminates</param>
        /// <returns>ChildProcess object</returns>
        public static object exec(JsString command, JsAction<JsError, Buffer, Buffer> callback) { return null; }
        /// <summary>
        /// Runs a command in a shell and buffers the output.
        /// <example>
        /// <code>
        /// var exec = require('child_process').exec,
        ///    child;
        ///
        // child = exec('cat *.js bad_file | wc -l',
        ///     function (error, stdout, stderr) {
        ///     console.log('stdout: ' + stdout);
        ///     console.log('stderr: ' + stderr);
        ///     if (error !== null) {
        ///       console.log('exec error: ' + error);
        ///     }
        /// });
        /// </code>
        /// The callback gets the arguments (error, stdout, stderr). On success, error will be null. On error, error will be an instance of Error and err.code will be the exit code of the child process, and err.signal will be set to the signal that terminated the process.
        /// </example>
        /// <example>There is a second optional argument to specify several options. The default options are
        /// <code>
        /// { encoding: 'utf8',
        ///  timeout: 0,
        ///  maxBuffer: 200*1024,
        ///  killSignal: 'SIGTERM',
        ///  cwd: null,
        ///  env: null }
        /// </code>
        /// If timeout is greater than 0, then it will kill the child process if it runs longer than timeout milliseconds. The child process is killed with killSignal (default: 'SIGTERM'). maxBuffer specifies the largest amount of data allowed on stdout or stderr - if this value is exceeded then the child process is killed.
        /// </example>
        /// </summary>
        /// <param name="command">The command to run, with space-separated arguments</param>
        /// <param name="options">options Object
        /// <list type="bullets">
        /// <item> cwd String Current working directory of the child process</item>
        /// <item> stdio Array|String Child's stdio configuration. (See above)</item>
        /// <item> customFds Array Deprecated File descriptors for the child to use for stdio.</item>
        /// <item> env Object Environment key-value pairs</item>
        /// <item> encoding String (Default: 'utf8')</item>
        /// <item> timeout Number (Default: 0)</item>
        /// <item> maxBuffer Number (Default: 200*1024)</item>
        /// <item> killSignal String (Default: 'SIGTERM')</item></list></param>
        /// <param name="callback">Function called with the output when process terminates</param>
        /// <returns>ChildProcess object</returns>
        public static object exec(JsString command, ExecOptions options, JsAction<JsError, Buffer, Buffer> callback) { return null; }
        /// <summary>
        /// This is similar to child_process.exec() except it does not execute a subshell but rather the specified file directly. This makes it slightly leaner than child_process.exec. It has the same options.
        /// </summary>
        /// <param name="file">The filename of the program to run</param>
        /// <param name="args">Array List of string arguments</param>
        /// <param name="options">options Object
        /// <list type="bullets">
        /// <item> cwd String Current working directory of the child process</item>
        /// <item> stdio Array|String Child's stdio configuration. (See above)</item>
        /// <item> customFds Array Deprecated File descriptors for the child to use for stdio.</item>
        /// <item> env Object Environment key-value pairs</item>
        /// <item> encoding String (Default: 'utf8')</item>
        /// <item> timeout Number (Default: 0)</item>
        /// <item> maxBuffer Number (Default: 200*1024)</item>
        /// <item> killSignal String (Default: 'SIGTERM')</item></list></param>
        /// <param name="callback"> Function called with the output when process terminates</param>
        /// <returns>ChildProcess object</returns>
        public static object execFile(JsString file, JsArray<JsString> args, ExecOptions options, JsAction<JsError, Buffer, Buffer> callback) { return null; }
        /// <summary>
        /// This is a special case of the spawn() functionality for spawning Node processes. In addition to having all the methods in a normal ChildProcess instance, the returned object has a communication channel built-in. See child.send(message, [sendHandle]) for details.
        ///
        /// By default the spawned Node process will have the stdout, stderr associated with the parent's. To change this behavior set the silent property in the options object to true.
        ///
        /// The child process does not automatically exit once it's done, you need to call process.exit() explicitly. This limitation may be lifted in the future.
        ///
        /// These child Nodes are still whole new instances of V8. Assume at least 30ms startup and 10mb memory for each new Node. That is, you cannot create many thousands of them.
        /// </summary>
        /// <param name="modulePath"> The module to run in the child</param>
        /// <returns> ChildProcess object</returns>
        public static object fork(JsString modulePath) { return null; }
        /// <summary>
        /// This is a special case of the spawn() functionality for spawning Node processes. In addition to having all the methods in a normal ChildProcess instance, the returned object has a communication channel built-in. See child.send(message, [sendHandle]) for details.
        ///
        /// By default the spawned Node process will have the stdout, stderr associated with the parent's. To change this behavior set the silent property in the options object to true.
        ///
        /// The child process does not automatically exit once it's done, you need to call process.exit() explicitly. This limitation may be lifted in the future.
        ///
        /// These child Nodes are still whole new instances of V8. Assume at least 30ms startup and 10mb memory for each new Node. That is, you cannot create many thousands of them.
        /// </summary>
        /// <param name="modulePath"> The module to run in the child</param>
        /// <param name="args">Array List of string arguments</param>
        /// <returns>ChildProcess object</returns>
        public static object fork(JsString modulePath, JsArray<JsString> args) { return null; }
        /// <summary>
        /// This is a special case of the spawn() functionality for spawning Node processes. In addition to having all the methods in a normal ChildProcess instance, the returned object has a communication channel built-in. See child.send(message, [sendHandle]) for details.
        ///
        /// By default the spawned Node process will have the stdout, stderr associated with the parent's. To change this behavior set the silent property in the options object to true.
        ///
        /// The child process does not automatically exit once it's done, you need to call process.exit() explicitly. This limitation may be lifted in the future.
        ///
        /// These child Nodes are still whole new instances of V8. Assume at least 30ms startup and 10mb memory for each new Node. That is, you cannot create many thousands of them.
        /// </summary>
        /// <param name="modulePath"> The module to run in the child</param>
        /// <param name="options"></param>
        /// <returns>ChildProcess object</returns>
        public static object fork(JsString modulePath, ForkOptions options) { return null; }
        /// <summary>
        /// This is a special case of the spawn() functionality for spawning Node processes. In addition to having all the methods in a normal ChildProcess instance, the returned object has a communication channel built-in. See child.send(message, [sendHandle]) for details.
        ///
        /// By default the spawned Node process will have the stdout, stderr associated with the parent's. To change this behavior set the silent property in the options object to true.
        ///
        /// The child process does not automatically exit once it's done, you need to call process.exit() explicitly. This limitation may be lifted in the future.
        ///
        /// These child Nodes are still whole new instances of V8. Assume at least 30ms startup and 10mb memory for each new Node. That is, you cannot create many thousands of them.
        /// </summary>
        /// <param name="modulePath"> The module to run in the child</param>
        /// <param name="args">Array List of string arguments</param>
        /// <param name="options"></param>
        /// <returns>ChildProcess object</returns>
        public static object fork(JsString modulePath, JsArray<JsString> args, ForkOptions options) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"> String The command to run</param>
        /// <returns>ChildProcess object</returns>
        public static object spawn(JsString command) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"> String The command to run</param>
        /// <param name="args">Array List of string arguments</param>
        /// <returns>ChildProcess object</returns>
        public static object spawn(JsString command, JsArray<JsString> args) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"> String The command to run</param>
        /// <param name="options"></param>
        /// <returns>ChildProcess object</returns>
        public static object spawn(JsString command, SpawnOptions options) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"> String The command to run</param>
        /// <param name="args">Array List of string arguments</param>
        /// <param name="options"></param>
        /// <returns>ChildProcess object</returns>
        public static object spawn(JsString command, JsArray<JsString> args, SpawnOptions options) { return null; }

        #endregion
        #region events

        /// <summary>
        /// This event is emitted after the child process ends. If the process terminated normally, code is the final exit code of the process, otherwise null. If the process terminated due to receipt of a signal, signal is the string name of the signal, otherwise null.
        ///
        /// Note that the child process stdio streams might still be open.
        /// </summary>
        public JsAction<JsNumber, JsString> exit { get; set; }
        /// <summary>
        /// This event is emitted when the stdio streams of a child process have all terminated. This is distinct from 'exit', since multiple processes might share the same stdio streams.
        /// </summary>
        public JsAction close { get; set; }
        /// <summary>
        /// This event is emitted after using the .disconnect() method in the parent or in the child. After disconnecting it is no longer possible to send messages. An alternative way to check if you can send messages is to see if the child.connected property is true.
        /// </summary>
        [JsProperty(Name = "disconnect")]
        public JsAction disconnectEvent { get; set; }
        /// <summary>
        /// Messages send by .send(message, [sendHandle]) are obtained using the message event.
        /// message Object a parsed JSON object or primitive value
        /// sendHandle Handle object a Socket or Server object
        /// </summary>
        public JsAction<Object, object> message { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// <p>To close the IPC connection between parent and child use the
        /// <code>child.disconnect()</code> method. This allows the child to exit gracefully since
        /// there is no IPC channel keeping it alive. When calling this method the
        /// <code>disconnect</code> event will be emitted in both parent and child, and the
        /// <code>connected</code> flag will be set to <code>false</code>. Please note that you can also call
        /// <code>process.disconnect()</code> in the child process.
        /// </p>
        /// </summary>
        public object disconnect() { return null; }
        /// <summary>
        /// <p>Send a signal to the child process. If no argument is given, the process will
        /// be sent <code>&#39;SIGTERM&#39;</code>. See <code>signal(7)</code> for a list of available signals.
        /// </p>
        /// <pre><code>var spawn = require(&#39;child_process&#39;).spawn,
        /// grep  = spawn(&#39;grep&#39;, [&#39;ssh&#39;]);
        /// grep.on(&#39;exit&#39;, function (code, signal) {
        /// console.log(&#39;child process terminated due to receipt of signal &#39;+signal);
        /// });
        /// // send SIGHUP to process
        /// grep.kill(&#39;SIGHUP&#39;);</code></pre>
        /// <p>Note that while the function is called <code>kill</code>, the signal delivered to the child
        /// process may not actually kill it.  <code>kill</code> really just sends a signal to a process.
        /// </p>
        /// <p>See <code>kill(2)</code>
        /// </p>
        /// </summary>
        public object kill() { return null; }
        /// <summary>
        /// <p>Send a signal to the child process. If no argument is given, the process will
        /// be sent <code>&#39;SIGTERM&#39;</code>. See <code>signal(7)</code> for a list of available signals.
        /// </p>
        /// <pre><code>var spawn = require(&#39;child_process&#39;).spawn,
        /// grep  = spawn(&#39;grep&#39;, [&#39;ssh&#39;]);
        /// grep.on(&#39;exit&#39;, function (code, signal) {
        /// console.log(&#39;child process terminated due to receipt of signal &#39;+signal);
        /// });
        /// // send SIGHUP to process
        /// grep.kill(&#39;SIGHUP&#39;);</code></pre>
        /// <p>Note that while the function is called <code>kill</code>, the signal delivered to the child
        /// process may not actually kill it.  <code>kill</code> really just sends a signal to a process.
        /// </p>
        /// <p>See <code>kill(2)</code>
        /// </p>
        /// </summary>
        public object kill(object signal) { return null; }
        /// <summary>
        /// The PID of the child process.
        /// </summary>
        public JsAction<int> pid { get; set; }
        /// <summary>
        /// <p>When using <code>child_process.fork()</code> you can write to the child using
        /// <code>child.send(message, [sendHandle])</code> and messages are received by
        /// a <code>&#39;message&#39;</code> event on the child.
        /// </p>
        /// <p>For example:
        /// </p>
        /// <pre><code>var cp = require(&#39;child_process&#39;);
        /// var n = cp.fork(__dirname + &#39;/sub.js&#39;);
        /// n.on(&#39;message&#39;, function(m) {
        /// console.log(&#39;PARENT got message:&#39;, m);
        /// });
        /// n.send({ hello: &#39;world&#39; });</code></pre>
        /// <p>And then the child script, <code>&#39;sub.js&#39;</code> might look like this:
        /// </p>
        /// <pre><code>process.on(&#39;message&#39;, function(m) {
        /// console.log(&#39;CHILD got message:&#39;, m);
        /// });
        /// process.send({ foo: &#39;bar&#39; });</code></pre>
        /// <p>In the child the <code>process</code> object will have a <code>send()</code> method, and <code>process</code>
        /// will emit objects each time it receives a message on its channel.
        /// </p>
        /// <p>There is a special case when sending a <code>{cmd: &#39;NODE_foo&#39;}</code> message. All messages
        /// containing a <code>NODE_</code> prefix in its <code>cmd</code> property will not be emitted in
        /// the <code>message</code> event, since they are internal messages used by node core.
        /// Messages containing the prefix are emitted in the <code>internalMessage</code> event, you
        /// should by all means avoid using this feature, it is subject to change without notice.
        /// </p>
        /// <p>The <code>sendHandle</code> option to <code>child.send()</code> is for sending a TCP server or
        /// socket object to another process. The child will receive the object as its
        /// second argument to the <code>message</code> event.
        /// </p>
        /// <p><strong>send server object</strong>
        /// </p>
        /// <p>Here is an example of sending a server:
        /// </p>
        /// <pre><code>var child = require(&#39;child_process&#39;).fork(&#39;child.js&#39;);
        /// // Open up the server object and send the handle.
        /// var server = require(&#39;net&#39;).createServer();
        /// server.on(&#39;connection&#39;, function (socket) {
        /// socket.end(&#39;handled by parent&#39;);
        /// });
        /// server.listen(1337, function() {
        /// child.send(&#39;server&#39;, server);
        /// });</code></pre>
        /// <p>And the child would the receive the server object as:
        /// </p>
        /// <pre><code>process.on(&#39;message&#39;, function(m, server) {
        /// if (m === &#39;server&#39;) {
        /// server.on(&#39;connection&#39;, function (socket) {
        /// socket.end(&#39;handled by child&#39;);
        /// });
        /// }
        /// });</code></pre>
        /// <p>Note that the server is now shared between the parent and child, this means
        /// that some connections will be handled by the parent and some by the child.
        /// </p>
        /// <p><strong>send socket object</strong>
        /// </p>
        /// <p>Here is an example of sending a socket. It will spawn two children and handle
        /// connections with the remote address <code>74.125.127.100</code> as VIP by sending the
        /// socket to a &quot;special&quot; child process. Other sockets will go to a &quot;normal&quot; process.
        /// </p>
        /// <pre><code>var normal = require(&#39;child_process&#39;).fork(&#39;child.js&#39;, [&#39;normal&#39;]);
        /// var special = require(&#39;child_process&#39;).fork(&#39;child.js&#39;, [&#39;special&#39;]);
        /// // Open up the server and send sockets to child
        /// var server = require(&#39;net&#39;).createServer();
        /// server.on(&#39;connection&#39;, function (socket) {
        /// // if this is a VIP
        /// if (socket.remoteAddress === &#39;74.125.127.100&#39;) {
        /// special.send(&#39;socket&#39;, socket);
        /// return;
        /// }
        /// // just the usual dudes
        /// normal.send(&#39;socket&#39;, socket);
        /// });
        /// server.listen(1337);</code></pre>
        /// <p>The <code>child.js</code> could look like this:
        /// </p>
        /// <pre><code>process.on(&#39;message&#39;, function(m, socket) {
        /// if (m === &#39;socket&#39;) {
        /// socket.end(&#39;You were handled as a &#39; + process.argv[2] + &#39; person&#39;);
        /// }
        /// });</code></pre>
        /// <p>Note that once a single socket has been sent to a child the parent can no
        /// longer keep track of when the socket is destroyed. To indicate this condition
        /// the <code>.connections</code> property becomes <code>null</code>.
        /// It is also recommended not to use <code>.maxConnections</code> in this condition.
        /// </p>
        /// </summary>
        public object send(Object message) { return null; }
        /// <summary>
        /// <p>When using <code>child_process.fork()</code> you can write to the child using
        /// <code>child.send(message, [sendHandle])</code> and messages are received by
        /// a <code>&#39;message&#39;</code> event on the child.
        /// </p>
        /// <p>For example:
        /// </p>
        /// <pre><code>var cp = require(&#39;child_process&#39;);
        /// var n = cp.fork(__dirname + &#39;/sub.js&#39;);
        /// n.on(&#39;message&#39;, function(m) {
        /// console.log(&#39;PARENT got message:&#39;, m);
        /// });
        /// n.send({ hello: &#39;world&#39; });</code></pre>
        /// <p>And then the child script, <code>&#39;sub.js&#39;</code> might look like this:
        /// </p>
        /// <pre><code>process.on(&#39;message&#39;, function(m) {
        /// console.log(&#39;CHILD got message:&#39;, m);
        /// });
        /// process.send({ foo: &#39;bar&#39; });</code></pre>
        /// <p>In the child the <code>process</code> object will have a <code>send()</code> method, and <code>process</code>
        /// will emit objects each time it receives a message on its channel.
        /// </p>
        /// <p>There is a special case when sending a <code>{cmd: &#39;NODE_foo&#39;}</code> message. All messages
        /// containing a <code>NODE_</code> prefix in its <code>cmd</code> property will not be emitted in
        /// the <code>message</code> event, since they are internal messages used by node core.
        /// Messages containing the prefix are emitted in the <code>internalMessage</code> event, you
        /// should by all means avoid using this feature, it is subject to change without notice.
        /// </p>
        /// <p>The <code>sendHandle</code> option to <code>child.send()</code> is for sending a TCP server or
        /// socket object to another process. The child will receive the object as its
        /// second argument to the <code>message</code> event.
        /// </p>
        /// <p><strong>send server object</strong>
        /// </p>
        /// <p>Here is an example of sending a server:
        /// </p>
        /// <pre><code>var child = require(&#39;child_process&#39;).fork(&#39;child.js&#39;);
        /// // Open up the server object and send the handle.
        /// var server = require(&#39;net&#39;).createServer();
        /// server.on(&#39;connection&#39;, function (socket) {
        /// socket.end(&#39;handled by parent&#39;);
        /// });
        /// server.listen(1337, function() {
        /// child.send(&#39;server&#39;, server);
        /// });</code></pre>
        /// <p>And the child would the receive the server object as:
        /// </p>
        /// <pre><code>process.on(&#39;message&#39;, function(m, server) {
        /// if (m === &#39;server&#39;) {
        /// server.on(&#39;connection&#39;, function (socket) {
        /// socket.end(&#39;handled by child&#39;);
        /// });
        /// }
        /// });</code></pre>
        /// <p>Note that the server is now shared between the parent and child, this means
        /// that some connections will be handled by the parent and some by the child.
        /// </p>
        /// <p><strong>send socket object</strong>
        /// </p>
        /// <p>Here is an example of sending a socket. It will spawn two children and handle
        /// connections with the remote address <code>74.125.127.100</code> as VIP by sending the
        /// socket to a &quot;special&quot; child process. Other sockets will go to a &quot;normal&quot; process.
        /// </p>
        /// <pre><code>var normal = require(&#39;child_process&#39;).fork(&#39;child.js&#39;, [&#39;normal&#39;]);
        /// var special = require(&#39;child_process&#39;).fork(&#39;child.js&#39;, [&#39;special&#39;]);
        /// // Open up the server and send sockets to child
        /// var server = require(&#39;net&#39;).createServer();
        /// server.on(&#39;connection&#39;, function (socket) {
        /// // if this is a VIP
        /// if (socket.remoteAddress === &#39;74.125.127.100&#39;) {
        /// special.send(&#39;socket&#39;, socket);
        /// return;
        /// }
        /// // just the usual dudes
        /// normal.send(&#39;socket&#39;, socket);
        /// });
        /// server.listen(1337);</code></pre>
        /// <p>The <code>child.js</code> could look like this:
        /// </p>
        /// <pre><code>process.on(&#39;message&#39;, function(m, socket) {
        /// if (m === &#39;socket&#39;) {
        /// socket.end(&#39;You were handled as a &#39; + process.argv[2] + &#39; person&#39;);
        /// }
        /// });</code></pre>
        /// <p>Note that once a single socket has been sent to a child the parent can no
        /// longer keep track of when the socket is destroyed. To indicate this condition
        /// the <code>.connections</code> property becomes <code>null</code>.
        /// It is also recommended not to use <code>.maxConnections</code> in this condition.
        /// </p>
        /// </summary>
        public object send(Object message, object sendHandle) { return null; }
        #endregion
        /// <summary>
        /// Stream object
        /// A Writable Stream that represents the child process's stdin. Closing this stream via end() often causes the child process to terminate.
        ///
        /// If the child stdio streams are shared with the parent, then this will not be set.
        /// </summary>
        public JsAction<object> stdin { get; set; }
        /// <summary>
        /// Stream object
        /// A Readable Stream that represents the child process's stdout.
        /// 
        /// If the child stdio streams are shared with the parent, then this will not be set.
        /// </summary>
        public JsAction<object> stdout { get; set; }
        /// <summary>
        /// A Readable Stream that represents the child process's stderr.
        /// 
        /// If the child stdio streams are shared with the parent, then this will not be set.
        /// </summary>
        public JsAction<object> stderr { get; set; }

    }

    #region ExecOptions
    [JsType(JsMode.Json)]
    public partial class ExecOptions
    {
        /// <summary>
        ///  Current working directory of the child process
        /// </summary>
        public JsString cwd { get; set; }
        /// <summary>
        /// Array|String Child's stdio configuration. 
        /// </summary>
        [JsProperty(Name = "stdio")]
        public JsString stdioString { get; set; }
        /// <summary>
        /// Array|String Child's stdio configuration. 
        /// </summary>
        [JsProperty(Name = "stdio")]
        public JsArray stdioArray { get; set; }
        /// <summary>
        /// Array|String Child's stdio configuration. Please use the correct type.
        /// </summary>
        public object stdio { get; set; }
        /// <summary>
        /// Array Deprecated File descriptors for the child to use for stdio. 
        /// </summary>
        public JsArray customFds { get; set; }
        /// <summary>
        /// Object Environment key-value pairs
        /// </summary>
        public object env { get; set; }
        //TODO: env Object Environment key-value pairs
        /// <summary>
        /// (Default: 'utf8')
        /// </summary>
        public JsString encoding { get; set; }
        /// <summary>
        /// (Default: 0)
        /// </summary>
        public JsNumber timeOut { get; set; }
        /// <summary>
        /// (Default: 200*1024)
        /// </summary>
        public JsNumber maxBuffer { get; set; }
        /// <summary>
        /// (Default: 'SIGTERM')
        /// </summary>
        public JsString killSignal { get; set; }
    }
    #endregion
    #region ForkOptions
    [JsType(JsMode.Json)]
    public partial class ForkOptions
    {
        /// <summary>
        ///  Current working directory of the child process
        /// </summary>
        public JsString cwd { get; set; }
        /// <summary>
        /// Object Environment key-value pairs
        /// </summary>
        public object env { get; set; }
        //TODO: env Object Environment key-value pairs
        /// <summary>
        /// (Default: 'utf8')
        /// </summary>
        public JsString encoding { get; set; }
    }
    #endregion
    #region SpawnOptions
    [JsType(JsMode.Json)]
    public partial class SpawnOptions
    {
        /// <summary>
        ///  Current working directory of the child process
        /// </summary>
        public JsString cwd { get; set; }
        /// <summary>
        /// Array|String Child's stdio configuration. 
        /// </summary>
        [JsProperty(Name = "stdio")]
        public JsString stdioString { get; set; }
        /// <summary>
        /// Array|String Child's stdio configuration. 
        /// </summary>
        [JsProperty(Name = "stdio")]
        public JsArray stdioArray { get; set; }
        /// <summary>
        /// Array|String Child's stdio configuration. Please use the correct type.
        /// </summary>
        public object stdio { get; set; }
        /// <summary>
        /// Array Deprecated File descriptors for the child to use for stdio. 
        /// </summary>
        public JsArray customFds { get; set; }
        /// <summary>
        /// Object Environment key-value pairs
        /// </summary>
        public object env { get; set; }
        //TODO: env Object Environment key-value pairs
        /// <summary>
        /// The child will be a process group leader. 
        /// </summary>
        public bool detached { get; set; }
        /// <summary>
        ///  Sets the user identity of the process.
        /// </summary>
        public JsNumber uid { get; set; }
        /// <summary>
        /// Sets the group identity of the process. 
        /// </summary>
        public JsNumber gid { get; set; }
    }
    #endregion


}
