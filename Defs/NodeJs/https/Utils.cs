using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.NodeJs.http;

namespace SharpKit.NodeJs.https
{
    [JsType(JsMode.Prototype, Export = false, Name = "https")]
    public partial class Utils
    {
        /// <summary>
        /// Returns a new HTTPS web server object. The options is similar to tls.createServer(). The requestListener is a function which is automatically added to the 'request' event.
        /// <example>
        /// Example:
        ///<code>
        /// // curl -k https://localhost:8000/
        /// var https = require('https');
        /// var fs = require('fs');

        /// var options = {
        ///  key: fs.readFileSync('test/fixtures/keys/agent2-key.pem'),
        ///  cert: fs.readFileSync('test/fixtures/keys/agent2-cert.pem')
        /// };

        /// https.createServer(options, function (req, res) {
        ///   res.writeHead(200);
        ///   res.end("hello world\n");
        /// }).listen(8000);
        /// </code>
        /// </example>
        /// <example>
        /// Or
        ///<code>
        /// var https = require('https');
        /// var fs = require('fs');
        ///
        /// var options = {
        ///  pfx: fs.readFileSync('server.pfx')
        /// };
        ///
        /// https.createServer(options, function (req, res) {
        ///   res.writeHead(200);
        ///   res.end("hello world\n");
        /// }).listen(8000);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="options"> The options is similar to tls.createServer(). </param>
        /// <returns>Returns a new HTTPS web server object.</returns>
        public object createServer(object options) { return null; }
        /// <summary>
        /// Returns a new HTTPS web server object. The options is similar to tls.createServer(). The requestListener is a function which is automatically added to the 'request' event.
        /// <example>
        /// Example:
        ///<code>
        /// // curl -k https://localhost:8000/
        /// var https = require('https');
        /// var fs = require('fs');

        /// var options = {
        ///  key: fs.readFileSync('test/fixtures/keys/agent2-key.pem'),
        ///  cert: fs.readFileSync('test/fixtures/keys/agent2-cert.pem')
        /// };

        /// https.createServer(options, function (req, res) {
        ///   res.writeHead(200);
        ///   res.end("hello world\n");
        /// }).listen(8000);
        /// </code>
        /// </example>
        /// <example>
        /// Or
        ///<code>
        /// var https = require('https');
        /// var fs = require('fs');
        ///
        /// var options = {
        ///  pfx: fs.readFileSync('server.pfx')
        /// };
        ///
        /// https.createServer(options, function (req, res) {
        ///   res.writeHead(200);
        ///   res.end("hello world\n");
        /// }).listen(8000);
        /// </code>
        /// </example>
        /// </summary>
        /// </summary>
        /// <param name="options"> The options is similar to tls.createServer(). </param>
        /// <param name="requestListener">The requestListener is a function which is automatically added to the 'request' event.</param>
        /// <returns>Returns a new HTTPS web server object.</returns>
        public object createServer(object options, JsAction requestListener) { return null; }
        //TODO: ServerOptions:  The options is similar to tls.createServer().

        /// <summary>
        /// Makes a request to a secure web server.
        /// </summary>
        /// <param name="options">options can be an object or a string. If options is a string, it is automatically parsed with url.parse().
        /// All options from http.request() are valid.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// var https = require('https');
        ///
        ///var options = {
        ///  hostname: 'encrypted.google.com',
        ///  port: 443,
        ///  path: '/',
        ///  method: 'GET'
        ///};
        ///
        ///var req = https.request(options, function(res) {
        ///  console.log("statusCode: ", res.statusCode);
        ///  console.log("headers: ", res.headers);
        ///
        ///  res.on('data', function(d) {
        ///    process.stdout.write(d);
        ///  });
        ///});
        ///req.end();
        ///
        ///req.on('error', function(e) {
        ///  console.error(e);
        ///});
        /// </code>
        /// </example>
        /// The options argument has the following options:
        /// <list type = "bullet">
        ///host: A domain name or IP address of the server to issue the request to. Defaults to 'localhost'.
        ///hostname: To support url.parse() hostname is preferred over host
        ///port: Port of remote server. Defaults to 443.
        ///method: A string specifying the HTTP request method. Defaults to 'GET'.
        ///path: Request path. Defaults to '/'. Should include query string if any. E.G. '/index.html?page=12'
        ///headers: An object containing request headers.
        ///auth: Basic authentication i.e. 'user:password' to compute an Authorization header.
        ///agent: Controls Agent behavior. When an Agent is used request will default to Connection: keep-alive. Possible values:
        ///undefined (default): use globalAgent for this host and port.
        ///Agent object: explicitly use the passed in Agent.
        ///false: opts out of connection pooling with an Agent, defaults request to Connection: close.
        /// </list>        
        ///The following options from tls.connect() can also be specified. However, a globalAgent silently ignores these.
        ///<list type = "bullet">
        ///pfx: Certificate, Private key and CA certificates to use for SSL. Default null.
        ///key: Private key to use for SSL. Default null.
        ///passphrase: A string of passphrase for the private key or pfx. Default null.
        ///cert: Public x509 certificate to use. Default null.
        ///ca: An authority certificate or array of authority certificates to check the remote host against.
        ///ciphers: A string describing the ciphers to use or exclude. Consult http:///www.openssl.org/docs/apps/ciphers.html#CIPHER_LIST_FORMAT for details on the format.
        ///rejectUnauthorized: If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Verification happens at the connection level, before the HTTP request is sent. Default false.
        ///</list>
        ///In order to specify these options, use a custom Agent.
        /// <example>
        ///Example:
        /// <code>
        ///var options = {
        ///  hostname: 'encrypted.google.com',
        ///  port: 443,
        ///  path: '/',
        ///  method: 'GET',
        ///  key: fs.readFileSync('test/fixtures/keys/agent2-key.pem'),
        ///  cert: fs.readFileSync('test/fixtures/keys/agent2-cert.pem')
        ///};
        ///options.agent = new https.Agent(options);
        ///
        ///var req = https.request(options, function(res) {
        ///  ...
        ///}
        ///</code>
        ///</example>
        ///Or does not use an Agent.
        ///<example>
        ///Example:
        /// <code>
        ///var options = {
        ///  hostname: 'encrypted.google.com',
        ///  port: 443,
        ///  path: '/',
        ///  method: 'GET',
        ///  key: fs.readFileSync('test/fixtures/keys/agent2-key.pem'),
        ///  cert: fs.readFileSync('test/fixtures/keys/agent2-cert.pem'),
        ///  agent: false
        ///};
        ///
        ///var req = https.request(options, function(res) {
        ///  ...
        ///}
        ///</code>
        ///</example>
        public object request(RequestOptions options, JsAction callback) { return null; }
        /// <summary>
        /// Makes a request to a secure web server.
        /// </summary>
        /// <param name="options">options can be an object or a string. If options is a string, it is automatically parsed with url.parse().
        /// All options from http.request() are valid.</param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// var https = require('https');
        ///
        ///var options = {
        ///  hostname: 'encrypted.google.com',
        ///  port: 443,
        ///  path: '/',
        ///  method: 'GET'
        ///};
        ///
        ///var req = https.request(options, function(res) {
        ///  console.log("statusCode: ", res.statusCode);
        ///  console.log("headers: ", res.headers);
        ///
        ///  res.on('data', function(d) {
        ///    process.stdout.write(d);
        ///  });
        ///});
        ///req.end();
        ///
        ///req.on('error', function(e) {
        ///  console.error(e);
        ///});
        /// </code>
        /// </example>
        /// The options argument has the following options:
        /// <list type = "bullet">
        ///host: A domain name or IP address of the server to issue the request to. Defaults to 'localhost'.
        ///hostname: To support url.parse() hostname is preferred over host
        ///port: Port of remote server. Defaults to 443.
        ///method: A string specifying the HTTP request method. Defaults to 'GET'.
        ///path: Request path. Defaults to '/'. Should include query string if any. E.G. '/index.html?page=12'
        ///headers: An object containing request headers.
        ///auth: Basic authentication i.e. 'user:password' to compute an Authorization header.
        ///agent: Controls Agent behavior. When an Agent is used request will default to Connection: keep-alive. Possible values:
        ///undefined (default): use globalAgent for this host and port.
        ///Agent object: explicitly use the passed in Agent.
        ///false: opts out of connection pooling with an Agent, defaults request to Connection: close.
        /// </list>        
        ///The following options from tls.connect() can also be specified. However, a globalAgent silently ignores these.
        ///<list type = "bullet">
        ///pfx: Certificate, Private key and CA certificates to use for SSL. Default null.
        ///key: Private key to use for SSL. Default null.
        ///passphrase: A string of passphrase for the private key or pfx. Default null.
        ///cert: Public x509 certificate to use. Default null.
        ///ca: An authority certificate or array of authority certificates to check the remote host against.
        ///ciphers: A string describing the ciphers to use or exclude. Consult http:///www.openssl.org/docs/apps/ciphers.html#CIPHER_LIST_FORMAT for details on the format.
        ///rejectUnauthorized: If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Verification happens at the connection level, before the HTTP request is sent. Default false.
        ///</list>
        ///In order to specify these options, use a custom Agent.
        /// <example>
        ///Example:
        /// <code>
        ///var options = {
        ///  hostname: 'encrypted.google.com',
        ///  port: 443,
        ///  path: '/',
        ///  method: 'GET',
        ///  key: fs.readFileSync('test/fixtures/keys/agent2-key.pem'),
        ///  cert: fs.readFileSync('test/fixtures/keys/agent2-cert.pem')
        ///};
        ///options.agent = new https.Agent(options);
        ///
        ///var req = https.request(options, function(res) {
        ///  ...
        ///}
        ///</code>
        ///</example>
        ///Or does not use an Agent.
        ///<example>
        ///Example:
        /// <code>
        ///var options = {
        ///  hostname: 'encrypted.google.com',
        ///  port: 443,
        ///  path: '/',
        ///  method: 'GET',
        ///  key: fs.readFileSync('test/fixtures/keys/agent2-key.pem'),
        ///  cert: fs.readFileSync('test/fixtures/keys/agent2-cert.pem'),
        ///  agent: false
        ///};
        ///
        ///var req = https.request(options, function(res) {
        ///  ...
        ///}
        ///</code>
        ///</example>
        public object request(JsString options, JsAction callback) { return null; }
        //TODO: can also use tls.connect() options
        
        /// <summary>
        /// Like http.get() but for HTTPS.
        /// </summary>
        /// <param name="options">options can be an object or a string. If options is a string, it is automatically parsed with url.parse(). </param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// var https = require('https');
        ///
        /// https.get('https://encrypted.google.com/', function(res) {
        ///   console.log("statusCode: ", res.statusCode);
        ///   console.log("headers: ", res.headers);
        /// 
        ///   res.on('data', function(d) {
        ///     process.stdout.write(d);
        ///   });
        /// 
        /// }).on('error', function(e) {
        ///   console.error(e);
        /// });
        /// </code>
        /// </example>
        public object get(JsString options, JsAction callback) { return null; }
        /// <summary>
        /// Like http.get() but for HTTPS.
        /// </summary>
        /// <param name="options">options can be an object or a string. If options is a string, it is automatically parsed with url.parse(). </param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// var https = require('https');
        ///
        /// https.get('https://encrypted.google.com/', function(res) {
        ///   console.log("statusCode: ", res.statusCode);
        ///   console.log("headers: ", res.headers);
        /// 
        ///   res.on('data', function(d) {
        ///     process.stdout.write(d);
        ///   });
        /// 
        /// }).on('error', function(e) {
        ///   console.error(e);
        /// });
        /// </code>
        /// </example>
        public object get(object options, JsAction callback) { return null; }
        
        //TODO: https.globalAgent: Global instance of https.Agent for all HTTPS client requests.
    }
}
