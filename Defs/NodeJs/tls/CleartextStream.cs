using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.tls
{
    /// <summary>
    /// <p>This is a stream on top of the <em>Encrypted</em> stream that makes it possible to
    /// read/write an encrypted data as a cleartext data.
    /// </p>
    /// <p>This instance implements a duplex [Stream][] interfaces.  It has all the
    /// common stream methods and events.
    /// </p>
    /// <p>A ClearTextStream is the <code>clear</code> member of a SecurePair object.
    /// </p>
    /// </summary>
    public partial class CleartextStream
    {
        /// <summary>
        /// <p>Returns the bound address, the address family name and port of the
        /// underlying socket as reported by the operating system. Returns an
        /// object with three properties, e.g.
        /// <code>{ port: 12346, family: &#39;IPv4&#39;, address: &#39;127.0.0.1&#39; }</code>
        /// </p>
        /// </summary>
        public object address() { return null; }
        /// <summary>
        /// <p>Returns an object representing the cipher name and the SSL/TLS
        /// protocol version of the current connection.
        /// </p>
        /// <p>Example:
        /// { name: &#39;AES256-SHA&#39;, version: &#39;TLSv1/SSLv3&#39; }
        /// </p>
        /// <p>See SSL_CIPHER_get_name() and SSL_CIPHER_get_version() in
        /// <a href="http://www.openssl.org/docs/ssl/ssl.html#DEALING_WITH_CIPHERS">http://www.openssl.org/docs/ssl/ssl.html#DEALING_WITH_CIPHERS</a> for more
        /// information.
        /// </p>
        /// </summary>
        public object getCipher() { return null; }
        /// <summary>
        /// <p>Returns an object representing the peer&#39;s certificate. The returned object has
        /// some properties corresponding to the field of the certificate.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>{ subject:
        /// { C: &#39;UK&#39;,
        /// ST: &#39;Acknack Ltd&#39;,
        /// L: &#39;Rhys Jones&#39;,
        /// O: &#39;node.js&#39;,
        /// OU: &#39;Test TLS Certificate&#39;,
        /// CN: &#39;localhost&#39; },
        /// issuer:
        /// { C: &#39;UK&#39;,
        /// ST: &#39;Acknack Ltd&#39;,
        /// L: &#39;Rhys Jones&#39;,
        /// O: &#39;node.js&#39;,
        /// OU: &#39;Test TLS Certificate&#39;,
        /// CN: &#39;localhost&#39; },
        /// valid_from: &#39;Nov 11 09:52:22 2009 GMT&#39;,
        /// valid_to: &#39;Nov  6 09:52:22 2029 GMT&#39;,
        /// fingerprint: &#39;2A:7A:C2:DD:E5:F9:CC:53:72:35:99:7A:02:5A:71:38:52:EC:8A:DF&#39; }</code></pre>
        /// <p>If the peer does not provide a certificate, it returns <code>null</code> or an empty
        /// object.
        /// </p>
        /// </summary>
        public object getPeerCertificate() { return null; }
        /// <summary>
        /// This event is emitted after a new connection has been successfully handshaked. The listener will be called no matter if the server's certificate was authorized or not. 
        /// It is up to the user to test cleartextStream.authorized to see if the server certificate was signed by one of the specified CAs. 
        /// If cleartextStream.authorized === false then the error can be found in cleartextStream.authorizationError. 
        /// Also if NPN was used - you can check cleartextStream.npnProtocol for negotiated protocol.
        /// </summary>
        public JsAction secureConnect { get; set; }
        //TODO: event
    }
    #region CleartextStreamOptions
    [JsType(JsMode.Json)]
    public partial class CleartextStreamOptions
    {
        /// <summary>
        /// A boolean that is true if the peer certificate was signed by one of the specified CAs, otherwise false.
        /// </summary>
        public bool authorized { get; set; }
        /// <summary>
        /// The reason why the peer's certificate has not been verified. This property becomes available only when cleartextStream.authorized === false.
        /// </summary>
        public object authorizedError { get; set; }
        /// <summary>
        /// The string representation of the remote IP address. For example, '74.125.127.100' or '2001:4860:a005::68'.
        /// </summary>
        public JsString remoteAddress { get; set; }
        /// <summary>
        /// The numeric representation of the remote port. For example, 443.
        /// </summary>
        public JsNumber remotePort { get; set; }
    }
    #endregion
}
