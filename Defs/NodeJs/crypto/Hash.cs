using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>The class for creating hash digests of data.
    /// </p>
    /// <p>Returned by <code>crypto.createHash</code>.
    /// </p>
    /// </summary>
    public partial class Hash
    {
        /// <summary>
        /// Calculates the digest of all of the passed data to be hashed. 
        ///Note: hash object can not be used after digest() method been called.
        /// </summary>
        /// <returns></returns>
        public object digest() { return null; }
        /// <summary>
        /// Calculates the digest of all of the passed data to be hashed. 
        ///Note: hash object can not be used after digest() method been called.
        /// </summary>
        /// <param name="encoding">The encoding can be 'hex', 'binary' or 'base64'. Defaults to 'binary'.</param>
        /// <returns></returns>
        public object digest(JsString encoding) { return null; }
        /// <summary>
        /// Updates the hash content with the given data, the encoding of which is given in input_encoding and can be 'utf8', 'ascii' or 'binary'.  This can be called many times with new data as it is streamed.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public object update(JsString data) { return null; }
        /// <summary>
        /// Updates the hash content with the given data, the encoding of which is given in input_encoding and can be 'utf8', 'ascii' or 'binary'.  This can be called many times with new data as it is streamed.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="input_encoding">Defaults to 'binary'. input_encoding and can be 'utf8', 'ascii' or 'binary'</param>
        /// <returns></returns>
        public object update(JsString data, JsString input_encoding) { return null; }
    }
}
