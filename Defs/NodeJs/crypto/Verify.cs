using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Class for verifying signatures.
    /// </p>
    /// <p>Returned by <code>crypto.createVerify</code>.
    /// </p>
    /// </summary>
    public partial class Verify
    {
        /// <summary>
        /// Updates the verifier object with data.
        /// This can be called many times with new data as it is streamed.
        /// </summary>
        public object update(object data) { return null; }
        /// <summary>
        /// Verifies the signed data by using the object and signature. 
        /// object is a string containing a PEM encoded object, which can be one of RSA public key, DSA public key, or X.509 certificate. 
        /// signature is the previously calculated signature for the data, in the signature_format which can be 'binary', 'hex' or 'base64'. Defaults to 'binary'.
        /// Note: verifier object can not be used after verify() method been called.
        /// </summary>
        /// <param name="object">object is a string containing a PEM encoded object, which can be one of RSA public key, DSA public key, or X.509 certificate.</param>
        /// <param name="signature"> signature is the previously calculated signature for the data</param>
        /// <returns>Returns true or false depending on the validity of the signature for the data and public key.</returns>
        public object verify(object @object, object signature) { return null; }
        /// <summary>
        /// Verifies the signed data by using the object and signature. 
        /// object is a string containing a PEM encoded object, which can be one of RSA public key, DSA public key, or X.509 certificate. 
        /// signature is the previously calculated signature for the data, in the signature_format which can be 'binary', 'hex' or 'base64'. Defaults to 'binary'.
        /// Note: verifier object can not be used after verify() method been called.
        /// </summary>
        /// <param name="object">object is a string containing a PEM encoded object, which can be one of RSA public key, DSA public key, or X.509 certificate.</param>
        /// <param name="signature"> signature is the previously calculated signature for the data</param>
        /// <param name="signature_format">can be 'binary', 'hex' or 'base64'. Defaults to 'binary'.</param>
        /// <returns>Returns true or false depending on the validity of the signature for the data and public key.</returns>
        public object verify(object @object, object signature, object signature_format) { return null; }
    }
}
