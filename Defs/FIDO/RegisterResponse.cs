using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    /// <summary>
    /// Error or RegisterResponse or SignResponse
    /// - all in one class
    /// </summary>
    [JsType(JsMode.Json, PropertiesAsFields = true, NativeCasts = true)]
    public class RegisterResponse
    {
        [JsProperty(Name = "errorCode", NativeField = true)]
        public ErrorCode ErrorCode { get; set; }

        [JsProperty(Name = "errorMessage", NativeField = true)]
        public JsString ErrorMessage { get; set; }

        [JsProperty(Name = "registrationData", NativeField = true)]
        public JsString RegistrationData { get; set; }

        /// <summary>
        /// The client data created by the FIDO client, websafe-base64 encoded
        /// </summary>
        [JsProperty(Name = "clientData", NativeField = true)]
        public JsString ClientData { get; set; }
    }
}

