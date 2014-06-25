using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Class for creating cryptographic hmac content.
    /// </p>
    /// <p>Returned by <code>crypto.createHmac</code>.
    /// </p>
    /// </summary>
    public partial class Hmac
    {
        /// <summary>
        /// Calculates the digest of all of the passed data to the hmac.
        ///
        /// Note: hmac object can not be used after digest() method been called.
        /// </summary>
        /// <returns></returns>
        public object digest() { return null; }
        /// <summary>
        /// Calculates the digest of all of the passed data to the hmac.
        ///
        /// Note: hmac object can not be used after digest() method been called.
        /// </summary>
        /// <param name="encoding"> The encoding can be 'hex', 'binary' or 'base64'. Defaults to 'binary'.</param>
        /// <returns></returns>
        public object digest(JsString encoding) { return null; }
        /// <summary>
        /// Update the hmac content with the given data. This can be called many times with new data as it is streamed.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public object update(JsString data) { return null; }
    }
}
