using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.cluster
{
    public partial class Utils
    {
        /// <summary>
        /// setupMaster is used to change the default 'fork' behavior. The new settings are effective immediately and permanently, they cannot be changed later on. 
        /// </summary>
        /// <returns></returns>
        public Worker setupMaster() { return null; }
        /// <summary>
        /// setupMaster is used to change the default 'fork' behavior. The new settings are effective immediately and permanently, they cannot be changed later on.
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// var cluster = require("cluster");
        /// cluster.setupMaster({
        ///   exec : "worker.js",
        ///   args : ["--use", "https"],
        ///   silent : true
        /// });
        /// cluster.fork();
        /// </code>
        /// </example>
        public Worker setupMaster(SettingOptions settings) { return null; }
        /// <summary>
        /// Spawn a new worker process. This can only be called from the master process. 
        /// </summary>
        /// <returns>return Worker object</returns>
        public Worker fork() { return null; }
        /// <summary>
        /// Spawn a new worker process. This can only be called from the master process. 
        /// </summary>
        /// <param name="env">env Object Key/value pairs to add to child process environment.</param>
        /// <returns>return Worker object</returns>
        public Worker fork(object env) { return null; }
        /// <summary>
        /// When calling this method, all workers will commit a graceful suicide. 
        /// When they are disconnected all internal handlers will be closed, allowing the master process to die graceful if no other event is waiting.
        /// </summary>
        /// <returns></returns>
        public object disconnect() { return null; }
        /// <summary>
        /// When calling this method, all workers will commit a graceful suicide. 
        /// When they are disconnected all internal handlers will be closed, allowing the master process to die graceful if no other event is waiting.
        /// </summary>
        /// <param name="callback">callback Function called when all workers are disconnected and handlers are closed</param>
        /// <returns></returns>
        public object disconnect(JsAction callback) { return null; }
        /// <summary>
        /// A reference to the current worker object. Not available in the master process. 
        /// <example>
        /// <code>
        /// var cluster = require('cluster');
        ///
        /// if (cluster.isMaster) {
        ///   console.log('I am master');
        ///   cluster.fork();
        ///   cluster.fork();
        /// } else if (cluster.isWorker) {
        ///   console.log('I am worker {return null;}' + cluster.worker.id);
        /// }
        /// </code>
        ///  Should you wish to reference a worker over a communication channel, using the worker's unique id is the easiest way to find the worker.
        /// <code>
        /// socket.on('data', function(id) {
        ///  var worker = cluster.workers[id];
        /// });
        /// </code>
        /// </summary>
        public JsFunc<object> worker { get; set; }

        #region properties
        /// <summary>
        /// <list type="bullet">
        /// Object
        /// <list type="bullet">
        /// <item>exec <description> String file path to worker file. (Default=__filename)</description></item>
        /// <item>args <description> Array string arguments passed to worker. (Default=process.argv.slice(2))</description></item>
        /// <item>silent <description> Boolean whether or not to send output to parent's stdio. (Default=false)</description></item>
        ///</list>
        ///</list>
        /// All settings set by the .setupMaster is stored in this settings object. This object is not supposed to be change or set manually, by you.
        /// </summary>
        public Object setting { get; set; }
        /// <summary>
        /// True if the process is a master. This is determined by the process.env.NODE_UNIQUE_ID. 
        /// If process.env.NODE_UNIQUE_ID is undefined, then isMaster is true.
        /// </summary>
        public bool isMaster { get; set; }
        /// <summary>
        /// This boolean flag is true if the process is a worker forked from a master. If the process.env.NODE_UNIQUE_ID is set to a value, then isWorker is true.
        /// </summary>
        public bool isWorker { get; set; }
        #endregion
        #region events
        /// <summary>
        /// When a new worker is forked the cluster module will emit a 'fork' event. This can be used to log worker activity, and create you own timeout. 
        /// </summary>
        /// <example>
        /// <code>
        /// var timeouts = [];
        /// function errorMsg() {
        ///   console.error("Something must be wrong with the connection ...");
        /// }
        ///
        /// cluster.on('fork', function(worker) {
        ///   timeouts[worker.id] = setTimeout(errorMsg, 2000);
        /// });
        /// cluster.on('listening', function(worker, address) {
        ///   clearTimeout(timeouts[worker.id]);
        /// });
        /// cluster.on('exit', function(worker, code, signal) {
        ///   clearTimeout(timeouts[worker.id]);
        ///   errorMsg();
        /// });
        /// </code>
        /// </example>
        [JsProperty(Name = "fork")]
        public JsAction forkEvent { get; set; }
        /// <summary>
        /// After forking a new worker, the worker should respond with a online message. When the master receives a online message it will emit such event. 
        /// The difference between 'fork' and 'online' is that fork is emitted when the master tries to fork a worker, and 'online' is emitted when the worker is being executed. 
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.on('online', function(worker) {
        ///  console.log("Yay, the worker responded after it was forked");
        /// });
        /// </code>
        /// </example>
        public JsAction<Worker> online { get; set; }
        /// <summary>
        /// When calling listen() from a worker, a 'listening' event is automatically assigned to the server instance. 
        /// When the server is listening a message is send to the master where the 'listening' event is emitted.
        /// The event handler is executed with two arguments, the worker contains the worker object and the 
        /// address object contains the following connection properties: address, port and addressType. This is very useful if the worker is listening on more than one address. 
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.on('listening', function(worker, address) {
        ///  console.log("A worker is now connected to " + address.address + ":" + address.port);
        /// });
        /// </code> 
        /// </example>
        public JsAction<Worker, Object> listening { get; set; }
        /// <summary>
        /// When a workers IPC channel has disconnected this event is emitted. This will happen when the worker dies, usually after calling .destroy(). 
        /// When calling .disconnect(), there may be a delay between the disconnect and exit events. 
        /// This event can be used to detect if the process is stuck in a cleanup or if there are long-living connections.
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.on('disconnect', function(worker) {
        ///     console.log('The worker {get;set;}' + worker.id + ' has disconnected');
        /// });
        /// </code>
        /// </example>
        [JsProperty(Name = "disconnect")]
        public JsAction<Worker> disconnectEvent { get; set; }
        /// <summary>
        /// code Number the exit code, if it exited normally.
        /// signal String the name of the signal (eg. 'SIGHUP') that caused the process to be killed.
        /// When any of the workers die the cluster module will emit the 'exit' event. This can be used to restart the worker by calling fork() again. 
        /// </summary>
        /// <example>
        /// <code>
        /// cluster.on('exit', function(worker, code, signal) {
        ///  var exitCode = worker.process.exitCode;
        ///  console.log('worker ' + worker.process.pid + ' died ('+exitCode+'). restarting...');
        ///  cluster.fork();
        /// });
        /// </code>
        /// </example>
        public JsAction<Worker> exit { get; set; }
        /// <summary>
        /// When the .setupMaster() function has been executed this event emits. If .setupMaster() was not executed before fork() this function will call 
        /// .setupMaster() with no arguments. 
        /// </summary>
        public JsAction<Worker> setup { get; set; }
        #endregion

    }
    [JsType(JsMode.Json)]
    public partial class SettingOptions
    {
        /// <summary>
        /// exec String file path to worker file. (Default=__filename)
        /// </summary>
        public JsString exec { get; set; }
        /// <summary>
        /// args Array string arguments passed to worker. (Default=process.argv.slice(2)) 
        /// </summary>
        public JsArray<JsString> args { get; set; }
        /// <summary>
        /// silent Boolean whether or not to send output to parent's stdio. (Default=false) 
        /// </summary>
        public bool silent { get; set; }
    }
}
