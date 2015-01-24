using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    /// <summary>
    /// Low-level API
    /// </summary>
    [JsType(JsMode.Json, PropertiesAsFields = true, NativeCasts = true)]
    public class Request
    {
        /// <summary>
        /// The type of request, either "u2f_register_request" or "u2f_sign_request".
        /// </summary>
        [JsProperty(Name = "type", NativeField = true)]
        public JsString Type { get; set; }

        /// <summary>
        /// A list of SignRequest dictionaries, one for each token already registered with this RP.
        /// </summary>
        [JsProperty(Name = "signRequests", NativeField = true)]
        public SignRequest[] SignRequest { get; set; }

        /// <summary>
        /// A list of RegisterRequest dictionaries, one for each protocol version that the RP is willing to register.
        /// </summary>
        [JsProperty(Name = "registerRequests", NativeField = true)]
        public RegisterRequest[] RegisterRequest { get; set; }

        /// <summary>
        /// A timeout for the FIDO Client's processing, in seconds
        /// </summary>
        [JsProperty(Name = "timeoutSeconds", NativeField = true)]
        public int TimeoutSeconds { get; set; }

        /// <summary>
        /// An integer identifying this request from concurrent requests.
        /// </summary>
        [JsProperty(Name = "requestId", NativeField = true)]
        public int RequestId { get; set; }
    }
}

