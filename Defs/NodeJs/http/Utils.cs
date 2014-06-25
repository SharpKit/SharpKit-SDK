using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.http
{
    [JsType(JsMode.Json, Export = false, Name = "http")]
    public partial class HttpPlugin : IRequirable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns a new web server object.</returns>
        public Server createServer() { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestListener">The requestListener is a function which is automatically added to the 'request' event.</param>
        /// <returns>Returns a new web server object.</returns> 
        public Server createServer(JsAction<ServerRequest, ServerResponse> requestListener) { return null; }
        /// <summary>
        /// Node maintains several connections per server to make HTTP requests. This function allows one to transparently issue requests.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object request(JsString options, JsAction callback) { return null; }
        /// <summary>
        /// Node maintains several connections per server to make HTTP requests. This function allows one to transparently issue requests.
        /// </summary>
        /// <param name="options">options can be an object or a string. If options is a string, it is automatically parsed with url.parse().</param>
        /// <param name="callbacke"></param>
        /// <returns></returns>
        public ClientRequest request(RequestOptions options, JsAction callbacke) { return null; }
        /// <summary>
        /// Since most requests are GET requests without bodies, Node provides this convenience method. The only difference between this method and http.request() is that it sets the method to GET and calls req.end() automatically.
        /// <example>
        /// <code>
        /// http.get("http://www.google.com/index.html", function(res) {
        ///   console.log("Got response: " + res.statusCode);
        /// }).on('error', function(e) {
        ///  console.log("Got error: " + e.message);
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public object get(JsString options, JsAction callback) { return null; }
    }
    [JsType(JsMode.Json)]
    public partial class RequestOptions
    {
        /// <summary>
        /// host: A domain name or IP address of the server to issue the request to. Defaults to 'localhost'.
        /// </summary>
        public JsString host { get; set; }
        /// <summary>
        /// hostname: To support url.parse() hostname is preferred over host.
        /// </summary>
        public JsString hostname { get; set; }
        /// <summary>
        /// Port of remote server. Defaults to 80.
        /// </summary>
        public JsNumber port { get; set; }
        /// <summary>
        ///  Local interface to bind for network connections.
        /// </summary>
        public JsString localAdress { get; set; }
        /// <summary>
        ///  Unix Domain Socket (use one of host:port or socketPath)
        /// </summary>
        public object socketPath { get; set; }
        /// <summary>
        /// A string specifying the HTTP request method. Defaults to 'GET'.
        /// </summary>
        public JsString method { get; set; }
        /// <summary>
        ///  Request path. Defaults to '/'. Should include query string if any. E.G. '/index.html?page=12'
        /// </summary>
        public JsString path { get; set; }
        /// <summary>
        ///  An object containing request headers.
        /// </summary>
        public object headers { get; set; }
        /// <summary>
        /// Basic authentication i.e. 'user:password' to compute an Authorization header.
        /// </summary>
        public object auth { get; set; }
        /// <summary>
        ///  Controls Agent behavior. When an Agent is used request will default to Connection: keep-alive. Possible values:
        /// undefined (default): use global Agent for this host and port.
        /// Agent object: explicitly use the passed in Agent.
        /// false: opts out of connection pooling with an Agent, defaults request to Connection: close.
        /// </summary>
        public object agent { get; set; }
        
    }
}
