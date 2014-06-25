using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>A Worker object contains all public information and method about a worker.
    /// In the master it can be obtained using <code>cluster.workers</code>. In a worker
    /// it can be obtained using <code>cluster.worker</code>.
    /// </p>
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "worker")]
    public partial class Worker
    {
        /// <summary>
        /// This function will kill the worker, and inform the master to not spawn a new worker. The boolean suicide lets you distinguish between voluntary and accidental exit.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// </code>
        /// cluster.on('exit', function(worker, code, signal) {
        ///  if (worker.suicide === true) {
        ///     console.log('Oh, it was just suicide\' – no need to worry').
        ///   }
        /// });
        /// //  destroy worker
        /// worker.destroy();
        /// </example>
        public object destroy() { return null; }
        /// <summary>
        /// When calling this function the worker will no longer accept new connections, but they will be handled by any other listening worker. 
        /// Existing connection will be allowed to exit as usual. When no more connections exist, the IPC channel to the worker will close allowing it to die graceful. 
        /// When the IPC channel is closed the disconnect event will emit, this is then followed by the exit event, there is emitted when the worker finally die.
        ///
        /// Because there might be long living connections, it is useful to implement a timeout. 
        /// This example ask the worker to disconnect and after 2 seconds it will destroy the server. 
        /// An alternative would be to execute worker.destroy() after 2 seconds, but that would normally not allow the worker to do any cleanup if needed.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// if (cluster.isMaster) {
        ///   var worker = cluster.fork();
        ///   var timeout;
        ///
        ///   worker.on('listening', function(address) {
        ///     worker.disconnect();
        ///     timeout = setTimeout(function() {
        ///       worker.send('force kill');
        ///     }, 2000);
        ///   });
        ///
        ///   worker.on('disconnect', function() {
        ///     clearTimeout(timeout);
        ///   });
        ///
        /// } else if (cluster.isWorker) {
        ///   var net = require('net');
        ///   var server = net.createServer(function(socket) {
        ///     //  connection never end
        ///   });
        ///
        ///   server.listen(8000);
        ///
        ///   server.on('close', function() {
        ///     //  cleanup
        ///   });
        ///
        ///   process.on('message', function(msg) {
        ///     if (msg === 'force kill') {
        ///       server.destroy();
        ///     }
        ///   });
        /// }
        /// </code>
        /// </example>
        public object disconnect() { return null; }
        /// <summary>
        /// This function is equal to the send methods provided by child_process.fork(). In the master you should use this function to send a message to a specific worker. 
        /// However in a worker you can also use process.send(message), since this is the same function.
        /// </summary>
        /// <param name="message">  Object</param>
        /// <returns></returns>
        /// <example>
        /// This example will echo back all messages from the master:
        ///<code>
        /// if (cluster.isMaster) {
        ///   var worker = cluster.fork();
        ///   worker.send('hi there');
        ///
        /// } else if (cluster.isWorker) {
        ///   process.on('message', function(msg) {
        ///     process.send(msg);
        ///   });
        /// }
        /// </code>
        /// </example>
        public object send(object message) { return null; }
        /// <summary>
        /// This function is equal to the send methods provided by child_process.fork(). In the master you should use this function to send a message to a specific worker. 
        /// However in a worker you can also use process.send(message), since this is the same function.
        /// </summary>
        /// <param name="message">  Object</param>
        /// <param name="sendHandle">Handle object</param>
        /// <returns></returns>
        /// <example>
        /// This example will echo back all messages from the master:
        ///<code>
        /// if (cluster.isMaster) {
        ///   var worker = cluster.fork();
        ///   worker.send('hi there');
        ///
        /// } else if (cluster.isWorker) {
        ///   process.on('message', function(msg) {
        ///     process.send(msg);
        ///   });
        /// }
        /// </code>
        /// </example>
        public object send(object message, object sendHandle) { return null; }
        #region properties
        /// <summary>
        /// Each new worker is given its own unique id, this id is stored in the id.
        ///
        /// While a worker is alive, this is the key that indexes it in cluster.workers
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// All workers are created using child_process.fork(), the returned object from this function is stored in process.
        ///
        /// See: Child Process module
        /// </summary>
        public ChildProcess process { get; set; }
        /// <summary>
        /// This property is a boolean. It is set when a worker dies after calling .destroy() or immediately after calling the .disconnect() method. Until then it is undefined.
        /// </summary>
        public bool suicide { get; set; }
        #endregion
        #region events
        //TODO
        /// <summary>
        /// This event is the same as the one provided by child_process.fork(). In the master you should use this event, however in a worker you can also use process.on('message')
        /// </summary>
        /// <example>
        /// As an example, here is a cluster that keeps count of the number of requests in the master process using the message system:
        /// <code>
        /// var cluster = require('cluster');
        /// var http = require('http');
        ///
        /// if (cluster.isMaster) {
        ///
        ///   //  Keep track of http requests
        ///   var numReqs = 0;
        ///   setInterval(function() {
        ///     console.log("numReqs =", numReqs);
        ///   }, 1000);
        ///
        ///   //  Count requestes
        ///   function messageHandler(msg) {
        ///     if (msg.cmd && msg.cmd == 'notifyRequest') {
        ///       numReqs += 1;
        ///     }
        ///   }
        ///
        ///   //  Start workers and listen for messages containing notifyRequest
        ///   var numCPUs = require('os').cpus().length;
        ///   for (var i = 0; i &lt; numCPUs; i++) {
        ///     cluster.fork();
        ///   }
        ///
        ///   Object.keys(cluster.workers).forEach(function(id) {
        ///     cluster.workers[id].on('message', messageHandler);
        ///   });
        ///
        /// } else {
        ///
        ///   //  Worker processes have a http server.
        ///   http.Server(function(req, res) {
        ///     res.writeHead(200);
        ///     res.end("hello world\n");
        ///
        ///     //  notify master about the request
        ///     process.send({ cmd: 'notifyRequest' });
        ///   }).listen(8000);
        /// }
        /// </code>
        /// </example>
        public JsAction<Object> message { get; set; }
        /// <summary>
        /// Same as the cluster.on('online') event, but emits only when the state change on the specified worker.
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.fork().on('online', function() {
        ///  // Worker is online
        /// };
        /// </code>
        /// </example>
        public JsAction online { get; set; }
        /// <summary>
        /// Same as the cluster.on('listening') event, but emits only when the state change on the specified worker. 
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.fork().on('listening', function(address) {
        ///  // Worker is listening
        /// };
        /// </code>
        /// </example>
        public JsAction<Object> listening { get; set; }
        /// <summary>
        /// Same as the cluster.on('disconnect') event, but emits only when the state change on the specified worker. 
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.fork().on('disconnect', function() {
        ///  // Worker has disconnected
        /// }; 
        /// </code>
        /// </example> 
        [JsProperty(Name = "disconnect")]
        public JsAction disconnectEvent { get; set; }
        /// <summary>
        /// <list type="bullet">
        /// <item> code Number the exit code, if it exited normally.</item>
        /// <item>signal String the name of the signal (eg. 'SIGHUP') that caused the process to be killed.</item>
        /// </list>
        /// Emitted by the individual worker instance, when the underlying child process is terminated. See child_process public JsAction'exit'. 
        /// </summary>
        /// <example>
        /// <code>
        /// var worker = cluster.fork();
        /// worker.on('exit', function(code, signal) {
        ///  if( signal ) {
        ///     console.log("worker was killed by signal: "+signal);
        ///   } else if( code !== 0 ) {
        ///     console.log("worker exited with error code: "+code);
        ///   } else {
        ///     console.log("worker success!");
        ///   }
        /// };
        /// </code>
        /// </example>
        public JsAction<JsNumber, JsString> exit { get; set; }
        #endregion
    }
}
