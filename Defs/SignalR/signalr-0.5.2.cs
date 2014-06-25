using SharpKit.JavaScript;
using SharpKit.jQuery;

namespace SharpKit.SignalR
{
    [JsType(JsMode.Prototype, Export = false, Name = "$")]
    public class SignalRContext
    {
        public static Connection connection(JsString s) { return null; }
        public static Hub hubConnection(JsString s) { return null; }
    }
    [JsType(JsMode.Prototype, Export = false, Name = "$.connection")]
    public class Connection
    {
        /// <summary>
        /// Creates a new connection.
        /// </summary>
        public Connection() { }
        /// <summary>
        /// Creates a new connection.
        /// </summary>
        /// <param name="url"></param>
        public Connection(JsString url) { }
        //TODO: must check

        /// <summary>
        /// A function to execute each time data is received.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>Returns a connection.</returns>
        ///<example>
        ///usage
        ///<code>
        ///connection.received(function(data) {
        ///     console.log(data);
        /// });
        ///</code>
        ///</example>
        public Connection received(JsAction<object> handler) { return null; }

        /// <summary>
        ///  A function to execute each time an error occurs.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>Returns a connection.</returns>
        ///<example>
        ///usage
        ///<code>
        ///connection.error(function(error) {
        ///     console.warn(error);
        /// });
        ///</code>
        ///</example>
        public Connection error(JsAction<object> handler) { return null; }
        //TODO: check

        /// <summary>
        ///  A function to execute each time the connection state changes.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>Returns a connection.</returns>
        ///<example>
        ///usage
        ///<code>
        ///connection.stateChanged(function (change) {
        ///     if (change.newState === $.signalR.connectionState.reconnecting) {
        ///         console.log('Re-connecting');
        ///     }
        ///     else if (change.newState === $.signalR.connectionState.connected) {
        ///         console.log('The server is online');
        ///     } 
        /// });
        ///</code>
        ///</example>
        public Connection stateChanged(JsAction<object> handler) { return null; }
        //TODO: check

        /// <summary>
        ///  A function to execute each time the connection has successfully reconnected.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns>Returns a connection.</returns>
        ///<example>
        ///usage
        ///<code>
        ///connection.reconnected(function() {
        ///     console.log('Reconnected');
        /// });
        ///</code>
        ///</example>
        public Connection reconnected(JsAction handler) { return null; }

        /// <summary>
        ///  A function to execute before the transport establishes a connection to the server.
        /// </summary>
        /// <param name="handler"></param>
        public void sending(JsAction handler) { }

        /// <summary>
        /// Starts the connection using the default settings.
        /// NOTE: A connection cannot send or receive messages until the start method has been called and the connection successfully established.
        /// </summary>
        /// <returns>Returns a deferred.</returns>
        ///<example>
        ///usage
        ///<code>
        ///connection.start();
        ///</code>
        ///</example>
        public Deferred<object, JsError> start() { return null; }
        //TODO: return type?

        /// <summary>
        /// Starts the connection using the default settings and executes the passed callback once the connection has been established.
        /// NOTE: This callback attaches an event handler that will be raised every time the connection is started.
        /// This means that subsequent calls to start raise the callback. To avoid this, see below.
        /// </summary>
        /// <param name="callback">- A callback function to invoke when the connection has been successfully established.**</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // This callback will only run once
        /// connection.start().done(function() {
        ///     console.log("connection started!");
        /// });
        ///</code>
        ///</example>
        public Deferred<object, JsError> start(JsAction callback) { return null; }
        //TODO: return type?


        /// <summary>
        /// Starts the connection using the passed settings.
        /// </summary>
        /// <param name="settings"></param>
        public Deferred<object, JsError> start(ConnectionStartSettings settings) { return null; }
        //TODO: return type?

        /// <summary>
        /// Starts the connection using the passed settings, and executes the passed callback once the connection has been established.
        /// </summary>
        /// <param name="settings">A set of key value pairs that configure the connection. All settings are optional.</param>
        /// <param name="callback"> A callback function to invoke when the connection has been successfully established.</param>
        ///<example>
        ///usage
        ///<code>
        ///connection.start({ transport: 'longPolling' }, function() {
        ///     console.log('connection started!');
        /// });
        ///</code>
        ///</example>
        public void start(ConnectionStartSettings settings, JsAction callback) { }
        //TODO: return type?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"> data to send over the connection.</param>
        ///<example>
        ///usage
        ///<code>
        ///connection.send("Hello World");
        ///</code>
        ///</example>
        public void send(object data) { }

        /// <summary>
        /// Gets or sets the client id for the current connection.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Gets or sets the message id for the current connection.
        /// </summary>
        public JsString messageId { get; set; }

        public Hub createHubProxy(JsString s) { return null; }
        public void on(JsString eventName, JsAction handler) { }

    }

    [JsType(JsMode.Json)]
    public class ConnectionStartSettings
    {
        /// <summary>
        /// Details of the transport to use. Can be a known transport name (that maps to a member on signalR.transports), a transport object, or an array of each. If an array, each transport will be tried until one succeeds or all fail.
        /// Defaults to "auto", which will try all transports on signalR.transports until one succeeds or all fail.
        /// </summary>
        public object transport { get; set; }

        /// <summary>
        ///  A callback function to invoke when the connection has been successfully established. Defaults to undefined (no callback).
        /// </summary>
        public JsAction callback { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false, Name = "$.hubConnection")]
    public class Hub : Connection
    {
        [JsMethod(OmitNewOperator = true)]
        public Hub() { }
        [JsMethod(OmitNewOperator = true)]
        public Hub(Connection connection) { }
        [JsMethod(OmitNewOperator = true)]
        public Hub(JsString cs) { }

        /// <summary>
        /// The client id for the hub connection.
        /// </summary>
        public new JsString id { get; set; }

        /// <summary>
        /// Set to true to enable logging. Default is false
        /// </summary>
        public bool logging { get; set; }

        public JsString qs { get; set; }
        //TODO: $.connection.{hubname}
    }
}
