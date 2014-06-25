using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>Returned by tls.createSecurePair.
    /// </p>
    /// </summary>
    public partial class SecurePair
    {
        /// <summary>
        /// The event is emitted from the SecurePair once the pair has successfully established a secure connection.
        /// 
        /// Similarly to the checking for the server 'secureConnection' event, pair.cleartext.authorized should be checked to confirm whether the certificate used properly authorized.
        /// </summary>
        public JsAction secure { get; set; }
        //TODO: event
    }
}
