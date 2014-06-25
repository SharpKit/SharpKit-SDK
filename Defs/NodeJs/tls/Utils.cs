using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;


namespace SharpKit.NodeJs.tls
{
    [JsType(JsMode.Prototype, Export = false, Name = "tls")]
    public partial class Utils
    {
        /// <summary>
        /// Creates a new tls.Server. The connectionListener argument is automatically set as a listener for the secureConnection event.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public object createServer(CreateServerOptions options) { return null; }
        /// <summary>
        ///  Creates a new tls.Server. The connectionListener argument is automatically set as a listener for the secureConnection event.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="secureConnectionListener"></param>
        /// <returns></returns>
        public object createServer(CreateServerOptions options, JsAction secureConnectionListener) { return null; }
        /// <summary>
        /// Creates a new client connection to the given port and host (old API) or options.port and options.host. (If host is omitted, it defaults to localhost.) 
        /// </summary>
        /// <param name="option">options should be an object which specifies:
        /// <list type="bullet">
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  port: Port the client should connect to.</item>
        /// <item>  socket: Establish secure connection on a given socket rather than creating a new socket. If this option is specified, host and port are ignored.</item>
        /// <item>  pfx: A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format.</item>
        /// <item>  key: A string or Buffer containing the private key of the client in PEM format.</item>
        /// <item>  passphrase: A string of passphrase for the private key or pfx.</item>
        /// <item>  cert: A string or Buffer containing the certificate key of the client in PEM format.</item>
        /// <item>  ca: An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.</item>
        /// <item>  rejectUnauthorized: If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Default: false.</item>
        /// <item>  NPNProtocols: An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)</item>
        /// <item>  servername: Servername for SNI (Server Name Indication) TLS extension.
        /// </list></param>
        /// <returns>tls.connect() returns a CleartextStream object.</returns>
        /// <example>
        /// Here is an example of a client of echo server as described previously:
        /// <code>
        /// var tls = require('tls');
        /// var fs = require('fs');
        /// var options = {
        ///   //  These are necessary only if using the client certificate authentication
        ///   key: fs.readFileSync('client-key.pem'),
        ///   cert: fs.readFileSync('client-cert.pem'),
        ///
        ///   //  This is necessary only if the server uses the self-signed certificate
        ///   ca: [ fs.readFileSync('server-cert.pem') ]
        /// };
        ///
        /// var cleartextStream = tls.connect(8000, options, function() {
        ///   console.log('client connected',
        ///               cleartextStream.authorized ? 'authorized' : 'unauthorized');
        ///   process.stdin.pipe(cleartextStream);
        ///   process.stdin.resume();
        /// });
        /// cleartextStream.setEncoding('utf8');
        /// cleartextStream.on('data', function(data) {
        ///   console.log(data);
        /// });
        /// cleartextStream.on('end', function() {
        ///   server.close();
        /// });
        ///</code></example>
        ///<example>
        /// Or
        ///<code>
        /// var tls = require('tls');
        /// var fs = require('fs');
        ///
        /// var options = {
        ///   pfx: fs.readFileSync('client.pfx')
        /// };
        ///
        /// var cleartextStream = tls.connect(8000, options, function() {
        ///   console.log('client connected',
        ///               cleartextStream.authorized ? 'authorized' : 'unauthorized');
        ///   process.stdin.pipe(cleartextStream);
        ///   process.stdin.resume();
        /// });
        /// cleartextStream.setEncoding('utf8');
        /// cleartextStream.on('data', function(data) {
        ///   console.log(data);
        /// });
        /// cleartextStream.on('end', function() {
        ///   server.close();
        /// });
        /// </code>
        /// </example>
        public CleartextStream connect(ConnectOptions option) { return null; }
        /// <summary>
        /// Creates a new client connection to the given port and host (old API) or options.port and options.host. (If host is omitted, it defaults to localhost.) 
        /// </summary>
        /// <param name="option">options should be an object which specifies:
        /// <list type="bullet">
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  port: Port the client should connect to.</item>
        /// <item>  socket: Establish secure connection on a given socket rather than creating a new socket. If this option is specified, host and port are ignored.</item>
        /// <item>  pfx: A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format.</item>
        /// <item>  key: A string or Buffer containing the private key of the client in PEM format.</item>
        /// <item>  passphrase: A string of passphrase for the private key or pfx.</item>
        /// <item>  cert: A string or Buffer containing the certificate key of the client in PEM format.</item>
        /// <item>  ca: An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.</item>
        /// <item>  rejectUnauthorized: If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Default: false.</item>
        /// <item>  NPNProtocols: An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)</item>
        /// <item>  servername: Servername for SNI (Server Name Indication) TLS extension.
        /// </list></param>
        /// <param name="callback">The callback parameter will be added as a listener for the 'secureConnect' event.</param>
        /// <returns>tls.connect() returns a CleartextStream object.</returns>
        /// <example>
        /// Here is an example of a client of echo server as described previously:
        /// <code>
        /// var tls = require('tls');
        /// var fs = require('fs');
        /// var options = {
        ///   //  These are necessary only if using the client certificate authentication
        ///   key: fs.readFileSync('client-key.pem'),
        ///   cert: fs.readFileSync('client-cert.pem'),
        ///
        ///   //  This is necessary only if the server uses the self-signed certificate
        ///   ca: [ fs.readFileSync('server-cert.pem') ]
        /// };
        ///
        /// var cleartextStream = tls.connect(8000, options, function() {
        ///   console.log('client connected',
        ///               cleartextStream.authorized ? 'authorized' : 'unauthorized');
        ///   process.stdin.pipe(cleartextStream);
        ///   process.stdin.resume();
        /// });
        /// cleartextStream.setEncoding('utf8');
        /// cleartextStream.on('data', function(data) {
        ///   console.log(data);
        /// });
        /// cleartextStream.on('end', function() {
        ///   server.close();
        /// });
        ///</code></example>
        ///<example>
        /// Or
        ///<code>
        /// var tls = require('tls');
        /// var fs = require('fs');
        ///
        /// var options = {
        ///   pfx: fs.readFileSync('client.pfx')
        /// };
        ///
        /// var cleartextStream = tls.connect(8000, options, function() {
        ///   console.log('client connected',
        ///               cleartextStream.authorized ? 'authorized' : 'unauthorized');
        ///   process.stdin.pipe(cleartextStream);
        ///   process.stdin.resume();
        /// });
        /// cleartextStream.setEncoding('utf8');
        /// cleartextStream.on('data', function(data) {
        ///   console.log(data);
        /// });
        /// cleartextStream.on('end', function() {
        ///   server.close();
        /// });
        /// </code>
        /// </example>
        public CleartextStream connect(ConnectOptions options, JsAction callback) { return null; }
        /// <summary>
        /// Creates a new client connection to the given port and host (old API) or options.port and options.host. (If host is omitted, it defaults to localhost.) 
        /// </summary>
        /// <param name="port"> Port the client should connect to</param>
        /// <returns>tls.connect() returns a CleartextStream object.</returns>
        public CleartextStream connect(JsNumber port) { return null; }
        /// <summary>
        /// Creates a new client connection to the given port and host (old API) or options.port and options.host. (If host is omitted, it defaults to localhost.) 
        /// </summary>
        /// <param name="port"> Port the client should connect to</param>
        /// <param name="host">Host the client should connect to</param>
        /// <returns>tls.connect() returns a CleartextStream object.</returns>
        public CleartextStream connect(JsNumber port, JsNumber host) { return null; }
        /// <summary>
        /// Creates a new client connection to the given port and host (old API) or options.port and options.host. (If host is omitted, it defaults to localhost.)
        /// </summary>
        /// <param name="port"> Port the client should connect to</param>
        ///<param name="option">options should be an object which specifies:
        /// <list type="bullet">
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  port: Port the client should connect to.</item>
        /// <item>  socket: Establish secure connection on a given socket rather than creating a new socket. If this option is specified, host and port are ignored.</item>
        /// <item>  pfx: A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format.</item>
        /// <item>  key: A string or Buffer containing the private key of the client in PEM format.</item>
        /// <item>  passphrase: A string of passphrase for the private key or pfx.</item>
        /// <item>  cert: A string or Buffer containing the certificate key of the client in PEM format.</item>
        /// <item>  ca: An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.</item>
        /// <item>  rejectUnauthorized: If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Default: false.</item>
        /// <item>  NPNProtocols: An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)</item>
        /// <item>  servername: Servername for SNI (Server Name Indication) TLS extension.
        /// </list></param>
        /// <param name="callback">The callback parameter will be added as a listener for the 'secureConnect' event.</param>
        /// <returns>tls.connect() returns a CleartextStream object.</returns>
        public CleartextStream connect(JsNumber port, ConnectOptions options, JsAction callback) { return null; }
        /// <summary>
        /// Creates a new client connection to the given port and host (old API) or options.port and options.host. (If host is omitted, it defaults to localhost.)
        /// </summary>
        /// <param name="port"> Port the client should connect to</param>
        /// <param name="host">Host the client should connect to</param>
        ///<param name="option">options should be an object which specifies:
        /// <list type="bullet">
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  host: Host the client should connect to.</item>
        /// <item>  port: Port the client should connect to.</item>
        /// <item>  socket: Establish secure connection on a given socket rather than creating a new socket. If this option is specified, host and port are ignored.</item>
        /// <item>  pfx: A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format.</item>
        /// <item>  key: A string or Buffer containing the private key of the client in PEM format.</item>
        /// <item>  passphrase: A string of passphrase for the private key or pfx.</item>
        /// <item>  cert: A string or Buffer containing the certificate key of the client in PEM format.</item>
        /// <item>  ca: An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.</item>
        /// <item>  rejectUnauthorized: If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Default: false.</item>
        /// <item>  NPNProtocols: An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)</item>
        /// <item>  servername: Servername for SNI (Server Name Indication) TLS extension.
        /// </list></param>
        /// <param name="callback">The callback parameter will be added as a listener for the 'secureConnect' event.</param>
        /// <returns>tls.connect() returns a CleartextStream object.</returns>
        public CleartextStream connect(JsNumber port, JsNumber host, ConnectOptions options, JsAction callback) { return null; }
        /// <summary>
        /// Creates a new secure pair object with two streams, one of which reads/writes encrypted data, and one reads/writes cleartext data. Generally the encrypted one is piped to/from an incoming encrypted data stream, and the cleartext one is used as a replacement for the initial encrypted stream.
        /// </summary>
        public CleartextStream createServerSecurePair() { return null; }
        /// <summary>
        /// Creates a new secure pair object with two streams, one of which reads/writes encrypted data, and one reads/writes cleartext data. Generally the encrypted one is piped to/from an incoming encrypted data stream, and the cleartext one is used as a replacement for the initial encrypted stream.
        /// </summary>
        /// <param name="credentials">A credentials object from crypto.createCredentials( ... )</param>
        /// <param name="isServer"> A boolean indicating whether this tls connection should be opened as a server or a client.</param>
        /// <param name="requestCert"> A boolean indicating whether a server should request a certificate from a connecting client. Only applies to server connections.</param>
        /// <param name="rejectUnauthorized"> A boolean indicating whether a server should automatically reject clients with invalid certificates. Only applies to servers with requestCert enabled.</param>
        /// <returns>tls.createSecurePair() returns a SecurePair object with [cleartext][] and encrypted stream properties.</returns>
        public SecurePair createServerSecurePair(object credentials, bool isServer, bool requestCert, bool rejectUnauthorized) { return null; }
        /// <summary>
        /// Creates a new secure pair object with two streams, one of which reads/writes encrypted data, and one reads/writes cleartext data. Generally the encrypted one is piped to/from an incoming encrypted data stream, and the cleartext one is used as a replacement for the initial encrypted stream.
        /// </summary>
        /// <param name="credentials">A credentials object from crypto.createCredentials( ... )</param>
        /// <param name="isServer"> A boolean indicating whether this tls connection should be opened as a server or a client.</param>
        /// <returns>tls.createSecurePair() returns a SecurePair object with [cleartext][] and encrypted stream properties.</returns>
        public SecurePair createServerSecurePair(object credentials, bool isServer) { return null; }
        /// <summary>
        /// Creates a new secure pair object with two streams, one of which reads/writes encrypted data, and one reads/writes cleartext data. Generally the encrypted one is piped to/from an incoming encrypted data stream, and the cleartext one is used as a replacement for the initial encrypted stream.
        /// </summary>
        /// <param name="credentials">A credentials object from crypto.createCredentials( ... )</param>
        /// <param name="isServer"> A boolean indicating whether this tls connection should be opened as a server or a client.</param>
        /// <param name="requestCert"> A boolean indicating whether a server should request a certificate from a connecting client. Only applies to server connections.</param>
        /// <returns>tls.createSecurePair() returns a SecurePair object with [cleartext][] and encrypted stream properties.</returns>
        public SecurePair createServerSecurePair(object credentials, bool isServer, bool requestCert) { return null; }
        /// <summary>
        /// Creates a new secure pair object with two streams, one of which reads/writes encrypted data, and one reads/writes cleartext data. Generally the encrypted one is piped to/from an incoming encrypted data stream, and the cleartext one is used as a replacement for the initial encrypted stream.
        /// </summary>
        /// <param name="credentials">A credentials object from crypto.createCredentials( ... )</param>
        /// <returns>tls.createSecurePair() returns a SecurePair object with [cleartext][] and encrypted stream properties.</returns>
        public SecurePair createServerSecurePair(object credentials) { return null; }
    }
    #region ConnectOptions
    [JsType(JsMode.Json)]
    public partial class ConnectOptions
    {
        /// <summary>
        /// Host the client should connect to.
        /// </summary>
        public JsString host { get; set; }
        /// <summary>
        ///  Port the client should connect to
        /// </summary>
        public JsString port { get; set; }
        public object socket { get; set; }
        [JsProperty(Name = "pfx")]
        public JsString pfxString { get; set; }
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        /// </summary>
        [JsProperty(Name = "pfx")]
        public Buffer pfxBuffer { get; set; }
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        ///  Please use the correct type.
        /// </summary>
        public object pfx { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "key")]
        public JsString keyString { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "key")]
        public Buffer keyBuffer { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// Please use the correct type.
        /// </summary>
        public object key { get; set; }
        /// <summary>
        ///  A string of passphrase for the private key or pfx.
        /// </summary>
        public JsString passphrase { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "cert")]
        public JsString certString { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "cert")]
        public Buffer certBuffer { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        ///  Please use the correct type.
        /// </summary>
        public object cert { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// </summary>
        [JsProperty(Name = "ca")]
        public JsArray<JsString> caArrayString { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// </summary>
        public Buffer caBuffer { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// Please use the correct Array type.
        /// </summary>
        public JsArray ca { get; set; }
        /// <summary>
        ///  If true, the server certificate is verified against the list of supplied CAs. An 'error' event is emitted if verification fails. Default: false.
        /// </summary>
        public bool rejectUnauthorized { get; set; }
        /// <summary>
        /// An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)
        /// </summary>
        [JsProperty(Name = "NPNProtocols")]
        public JsArray<JsString> NPNProtocolsStringArray { get; set; }
        /// <summary>
        /// An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)
        /// </summary>
        [JsProperty(Name = "NPNProtocols")]
        public Buffer NPNProtocolsBuffer { get; set; }
        /// <summary>
        /// An array of string or Buffer containing supported NPN protocols. Buffer should have following format: 0x05hello0x05world, where first byte is next protocol name's length. (Passing array should usually be much simpler: ['hello', 'world'].)
        /// Please use the correct type.
        /// </summary>
        public object NPNProtocols { get; set; }
        /// <summary>
        /// Servername for SNI (Server Name Indication) TLS extension.
        /// </summary>
        public JsString serverName { get; set; }
    }
#endregion
    #region CreateServerOptions
    [JsType(JsMode.Json)]
    public partial class CreateServerOptions
    {
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        /// </summary>
        [JsProperty(Name = "pfx")]
        public JsString pfxString { get; set; }
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        /// </summary>
        [JsProperty(Name = "pfx")]
        public Buffer pfxBuffer { get; set; }
        /// <summary>
        ///  A string or Buffer containing the private key, certificate and CA certs of the server in PFX or PKCS12 format. (Mutually exclusive with the key, cert and ca options.)
        ///  Please use the correct type.
        /// </summary>
        public object pfx { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "key")]
        public JsString keyString { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "key")]
        public Buffer keyBuffer { get; set; }
        /// <summary>
        /// A string or Buffer containing the private key of the server in PEM format. (Required)
        /// Please use the correct type.
        /// </summary>
        public object key { get; set; }
        /// <summary>
        ///  A string of passphrase for the private key or pfx.
        /// </summary>
        public JsString passphrase { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "cert")]
        public JsString certString { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        /// </summary>
        [JsProperty(Name = "cert")]
        public Buffer certBuffer { get; set; }
        /// <summary>
        ///  A string or Buffer containing the certificate key of the server in PEM format. (Required)
        ///  Please use the correct type.
        /// </summary>
        public object cert { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// </summary>
        [JsProperty(Name = "ca")]
        public JsArray<JsString> caArrayString { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// </summary>
        public Buffer caBuffer { get; set; }
        /// <summary>
        ///  An array of strings or Buffers of trusted certificates. If this is omitted several well known "root" CAs will be used, like VeriSign. These are used to authorize connections.
        /// Please use the correct Array type.
        /// </summary>
        public JsArray ca { get; set; }
        /// <summary>
        ///  Either a string or list of strings of PEM encoded CRLs (Certificate Revocation List)
        /// </summary>
        [JsProperty(Name = "crl")]
        public List<JsString> crlList { get; set; }
        /// <summary>
        ///  Either a string or list of strings of PEM encoded CRLs (Certificate Revocation List)
        /// </summary>
        public JsString crl { get; set; }
        /// <summary>
        /// A string describing the ciphers to use or exclude.
        /// </summary>
        public JsString ciphers { get; set; }

        //TODO: ask about honorCipherOrder 

    }
    #endregion
}
