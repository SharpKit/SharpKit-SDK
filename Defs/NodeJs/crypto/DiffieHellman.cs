using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>The class for creating Diffie-Hellman key exchanges.
    /// </p>
    /// <p>Returned by <code>crypto.createDiffieHellman</code>.
    /// </p>
    /// </summary>
    public partial class DiffieHellman
    {
        /// <summary>
        /// Computes the shared secret using other_public_key as the other party's public key and returns the computed shared secret. 
        /// Supplied key is interpreted using specified input_encoding, and secret is encoded using specified output_encoding.
        /// </summary>
        /// <param name="other_public_key"></param>
        /// <returns>returns the computed shared secret.</returns>
        public object computeSecret(object other_public_key) { return null; }
        /// <summary>
        /// Computes the shared secret using other_public_key as the other party's public key and returns the computed shared secret. 
        /// Supplied key is interpreted using specified input_encoding, and secret is encoded using specified output_encoding.
        /// </summary>
        /// <param name="other_public_key"></param>
        /// <param name="output_encoding">Encodings can be 'binary', 'hex', or 'base64'.</param>
        /// <returns>returns the computed shared secret.</returns>
        public object computeSecret(JsString other_public_key, JsString output_encoding) { return null; }
        /// <summary>
        /// Computes the shared secret using other_public_key as the other party's public key and returns the computed shared secret. 
        /// Supplied key is interpreted using specified input_encoding, and secret is encoded using specified output_encoding.
        /// </summary>
        /// <param name="other_public_key"></param>
        /// <param name="input_encoding">Encodings can be 'binary', 'hex', or 'base64'. 
        /// The input encoding defaults to 'binary'. If no output encoding is given, the input encoding is used as output encoding.</param>
        /// <param name="output_encoding">Encodings can be 'binary', 'hex', or 'base64'.</param>
        /// <returns>returns the computed shared secret.</returns>
        public object computeSecret(JsString other_public_key, JsString input_encoding, JsString output_encoding) { return null; }
        /// <summary>
        /// Generates private and public Diffie-Hellman key values, and returns the public key in the specified encoding. This key should be transferred to the other party. 
        /// </summary>
        /// <returns>returns the public key in the specified encoding.</returns>
        public object generateKeys() { return null; }
        /// <summary>
        /// Generates private and public Diffie-Hellman key values, and returns the public key in the specified encoding. This key should be transferred to the other party. 
        /// </summary>
        /// <param name="encoding">Encoding can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        /// <returns>returns the public key in the specified encoding.</returns>
        public object generateKeys(JsString encoding) { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman prime in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <returns>Returns the Diffie-Hellman prime in the specified encoding</returns>
        public object getGenerator() { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman prime in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <param name="encoding">can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        /// <returns>Returns the Diffie-Hellman prime in the specified encoding</returns>
        public object getGenerator(JsString encoding) { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman prime in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <returns>Returns the Diffie-Hellman prime in the specified encoding</returns>
        public object getPrime() { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman prime in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <param name="encoding">can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        /// <returns>Returns the Diffie-Hellman prime in the specified encoding</returns>
        public object getPrime(JsString encoding) { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman private key in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <returns>Returns the Diffie-Hellman private key in the specified encoding</returns>
        public object getPrivateKey() { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman private key in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <param name="encoding">'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        /// <returns>Returns the Diffie-Hellman private key in the specified encoding</returns>
        public object getPrivateKey(JsString encoding) { return null; }
        /// <summary>
        /// Returns the Diffie-Hellman prime in the specified encoding, which can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.
        /// </summary>
        /// <returns>Returns the Diffie-Hellman prime in the specified encoding</returns>
        public object getPublicKey() { return null; }
        /// <summary>
        /// Sets the Diffie-Hellman private key.
        /// </summary>
        /// <param name="encoding">Key encoding can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        public void getPublicKey(JsString encoding) { }
        /// <summary>
        /// Sets the Diffie-Hellman private key. 
        /// </summary>
        /// <param name="public_key"></param>
        public void setPrivateKey(JsString public_key) { }
       /// <summary>
        /// Sets the Diffie-Hellman private key. 
       /// </summary>
       /// <param name="public_key"></param>
        /// <param name="encoding">Key encoding can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        public void setPrivateKey(JsString public_key, JsString encoding) { }
       /// <summary>
        /// Sets the Diffie-Hellman public key
       /// </summary>
       /// <param name="public_key"></param>
        public void setPublicKey(JsString public_key) { }
        /// <summary>
        /// Sets the Diffie-Hellman public key. 
        /// </summary>
        /// <param name="public_key"></param>
        /// <param name="encoding">Key encoding can be 'binary', 'hex', or 'base64'. Defaults to 'binary'.</param>
        public void setPublicKey(JsString public_key, JsString encoding) { }
    }
}
