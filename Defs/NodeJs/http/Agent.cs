using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.http
{
    /// <summary>
    /// <p>In node 0.5.3+ there is a new implementation of the HTTP Agent which is used
    /// for pooling sockets used in HTTP client requests.
    /// </p>
    /// <p>Previously, a single agent instance helped pool for a single host+port. The
    /// current implementation now holds sockets for any number of hosts.
    /// </p>
    /// <p>The current HTTP Agent also defaults client requests to using
    /// Connection:keep-alive. If no pending HTTP requests are waiting on a socket
    /// to become free the socket is closed. This means that node&#39;s pool has the
    /// benefit of keep-alive when under load but still does not require developers
    /// to manually close the HTTP clients using keep-alive.
    /// </p>
    /// <p>Sockets are removed from the agent&#39;s pool when the socket emits either a
    /// &quot;close&quot; event or a special &quot;agentRemove&quot; event. This means that if you intend
    /// to keep one HTTP request open for a long time and don&#39;t want it to stay in the
    /// pool you can do something along the lines of:
    /// </p>
    /// <pre><code>http.get(options, function(res) {
    /// // Do stuff
    /// }).on(&quot;socket&quot;, function (socket) {
    /// socket.emit(&quot;agentRemove&quot;);
    /// });</code></pre>
    /// <p>Alternatively, you could just opt out of pooling entirely using <code>agent:false</code>:
    /// </p>
    /// <pre><code>http.get({host:&#39;localhost&#39;, port:80, path:&#39;/&#39;, agent:false}, function (res) {
    /// // Do stuff
    /// })</code></pre>
    /// </summary>
    public partial class Agent
    {

    }
    #region AgentOptions
    [JsType(JsMode.Json)]
    public partial class AgentOptions
    {
        /// <summary>
        /// By default set to 5. Determines how many concurrent sockets the agent can have open per host.
        /// </summary>
        public JsNumber maxSockets { get; set; }
        /// <summary>
        /// An object which contains arrays of sockets currently in use by the Agent. Do not modify.
        /// </summary>
        public JsArray<Socket> sockets { get; set; }
        /// <summary>
        /// An object which contains queues of requests that have not yet been assigned to sockets. Do not modify.
        /// </summary>
        public Queue<object> requests { get; set; }
        /// <summary>
        /// Global instance of Agent which is used as the default for all http client requests.
        /// </summary>
        public Agent globalAgent { get; set; }
        //TODO: http.globalAgent?
    }
    #endregion
}
