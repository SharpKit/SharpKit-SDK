using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Class for generating signatures.
    /// </p>
    /// <p>Returned by <code>crypto.createSign</code>.
    /// </p>
    /// </summary>
    public partial class Signer
    {
        /// <summary>
        /// Calculates the signature on all the updated data passed through the signer. 
        /// Note: signer object can not be used after sign() method been called.
        /// </summary>
        /// <param name="private_key">private_key is a string containing the PEM encoded private key for signing.</param>
        /// <returns>Returns the signature in output_format which can be 'binary', 'hex' or 'base64'. Defaults to 'binary'.</returns>
  
        public object sign(object private_key){return null;}
        /// <summary>
        /// Calculates the signature on all the updated data passed through the signer. 
        /// Note: signer object can not be used after sign() method been called.
        /// </summary>
        /// <param name="private_key">private_key is a string containing the PEM encoded private key for signing.</param>
        /// <param name="output_format">can be 'binary', 'hex' or 'base64'. Defaults to 'binary'.</param>
        /// <returns>Returns the signature in output_format which can be 'binary', 'hex' or 'base64'. Defaults to 'binary'.</returns>
        public object sign(object private_key, object output_format){return null;}
        /// <summary>
        /// Updates the signer object with data.
        /// This can be called many times with new data as it is streamed.
        /// </summary>
        public object update(JsString data){return null;}
    }
}
