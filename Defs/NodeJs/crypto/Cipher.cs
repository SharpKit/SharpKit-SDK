using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Class for encrypting data.
    /// </p>
    /// <p>Returned by <code>crypto.createCipher</code> and <code>crypto.createCipheriv</code>.
    /// </p>
    /// </summary>
    public partial class Cipher
    {
        /// <summary>
        /// Returns any remaining enciphered contents, with output_encoding being one of: 'binary', 'base64' or 'hex'. Defaults to 'binary'.
        /// 
        /// Note: cipher object can not be used after final() method been called. 
        /// </summary>
        /// <returns></returns>
        public JsString final() { return null; }
        /// <summary>
        /// Returns any remaining enciphered contents, with output_encoding being one of: 'binary', 'base64' or 'hex'. Defaults to 'binary'.
        /// 
        /// Note: cipher object can not be used after final() method been called.
        /// </summary>
        /// <param name="output_encoding"></param>
        /// <returns></returns>
        public JsString final(JsString output_encoding) { return null; }
        /// <summary>
        /// You can disable automatic padding of the input data to block size.  Useful for non-standard padding, e.g. using 0x0 instead of PKCS padding. 
        /// You must call this before cipher.final.
        /// </summary>
        /// <param name="auto_padding">If auto_padding is false, the length of the entire input data must be a multiple of the cipher's block size or final will fail.</param>
        /// <returns></returns>
        public object setAutoPadding(bool auto_padding) { return null; }
        /// <summary>
        /// Updates the cipher with data, the encoding of which is given in input_encoding and can be 'utf8', 'ascii' or 'binary'. Defaults to 'binary'.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Returns the enciphered contents, and can be called many times with new data as it is streamed.</returns>
        public object update(JsString data) { return null; }
        /// <summary>
        /// Updates the cipher with data, the encoding of which is given in input_encoding and can be 'utf8', 'ascii' or 'binary'. Defaults to 'binary'.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="output_encoding">can be 'utf8', 'ascii' or 'binary'. Defaults to 'binary'.</param>
        /// <returns>Returns the enciphered contents, and can be called many times with new data as it is streamed.</returns>
        public object update(JsString data, JsString output_encoding) { return null; }
        /// <summary>
        /// Updates the cipher with data, the encoding of which is given in input_encoding and can be 'utf8', 'ascii' or 'binary'. Defaults to 'binary'.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="input_encoding">can be 'utf8', 'ascii' or 'binary'. Defaults to 'binary'.</param>
        /// <param name="output_encoding">The output_encoding specifies the output format of the enciphered data, and can be 'binary', 'base64' or 'hex'. Defaults to 'binary'.</param>
        /// <returns>Returns the enciphered contents, and can be called many times with new data as it is streamed.</returns>
        public object update(JsString data, JsString input_encoding, JsString output_encoding) { return null; }
    }
}
