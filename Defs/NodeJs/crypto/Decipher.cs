using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Class for decrypting data.
    /// </p>
    /// <p>Returned by <code>crypto.createDecipher</code> and <code>crypto.createDecipheriv</code>.
    /// </p>
    /// </summary>
    public partial class Decipher
    {
        /// <summary>
        /// Returns any remaining plaintext which is deciphered, with output_encoding being one of: 'binary', 'ascii' or 'utf8'. Defaults to 'binary'.
        ///
        /// Note: decipher object can not be used after final() method been called.
        /// </summary>
        /// <returns></returns>
        public JsString final() { return null; }
        /// <summary>
        /// Returns any remaining plaintext which is deciphered, with output_encoding being one of: 'binary', 'ascii' or 'utf8'. Defaults to 'binary'.
        ///
        /// Note: decipher object can not be used after final() method been called.
        /// </summary>
        /// <param name="output_encoding"></param>
        /// <returns></returns>
        public object final(JsString output_encoding) { return null; }
        /// <summary>
        /// <p>You can disable auto padding if the data has been encrypted without standard block padding to prevent
        /// <code>decipher.final</code> from checking and removing it. Can only work if the input data&#39;s length is a multiple of the
        /// ciphers block size. You must call this before streaming data to <code>decipher.update</code>.
        /// </p>
        /// </summary>
        public object setAutoPadding(object auto_padding) { return null; }
        /// <summary>
        /// You can disable auto padding if the data has been encrypted without standard block padding to prevent decipher.final from checking and removing it. 
        /// Can only work if the input data's length is a multiple of the ciphers block size. You must call this before streaming data to decipher.update.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public object update(JsString data) { return null; }
        /// <summary>
        /// You can disable auto padding if the data has been encrypted without standard block padding to prevent decipher.final from checking and removing it. 
        /// Can only work if the input data's length is a multiple of the ciphers block size. You must call this before streaming data to decipher.update.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="output_encoding"></param>
        /// <returns></returns>
        public object update(JsString data, JsString output_encoding) { return null; }
        /// <summary>
        /// You can disable auto padding if the data has been encrypted without standard block padding to prevent decipher.final from checking and removing it. 
        /// Can only work if the input data's length is a multiple of the ciphers block size. You must call this before streaming data to decipher.update.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="input_encoding"></param>
        /// <param name="output_encoding"></param>
        /// <returns></returns>
        public object update(JsString data, JsString input_encoding, JsString output_encoding) { return null; }
    }
}
