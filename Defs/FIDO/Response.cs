using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    /// <summary>
    /// Low-level API
    /// </summary>
    [JsType(JsMode.Json, PropertiesAsFields = true, NativeCasts = true)]
    public class Response
    {
        /// <summary>
        /// The type of request, either "u2f_register_request" or "u2f_sign_request".
        /// </summary>
        [JsProperty(Name = "type", NativeField = true)]
        public JsString Type { get; set; }

        /// <summary>
        /// Error or RegisterResponse or SignResponse
        /// </summary>
        [JsProperty(Name = "responseData", NativeField = true)]
        public ResponseData ResponseData { get; set; }

        /// <summary>
        /// An integer identifying this request from concurrent requests.
        /// </summary>
        [JsProperty(Name = "requestId", NativeField = true)]
        public int RequestId { get; set; }
    }
}

