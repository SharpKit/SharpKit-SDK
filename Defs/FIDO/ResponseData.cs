using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    /// <summary>
    /// Error or RegisterResponse or SignResponse
    /// - all in one class
    /// Low-level API
    /// </summary>
    [JsType(JsMode.Json, PropertiesAsFields = true, NativeCasts = true)]
    public class ResponseData
    {
        #region Error

        [JsProperty(Name = "errorCode", NativeField = true)]
        public ErrorCode ErrorCode { get; set; }

        [JsProperty(Name = "errorMessage", NativeField = true)]
        public JsString ErrorMessage { get; set; }

        #endregion

        #region RegisterResponse

        [JsProperty(Name = "registrationData", NativeField = true)]
        public JsString RegistrationData { get; set; }

        //clientData

        #endregion

        #region SignResponse

        /// <summary>
        /// The keyHandle of the SignRequest that was processed.
        /// </summary>
        [JsProperty(Name = "keyHandle", NativeField = true)]
        public JsString KeyHandle { get; set; }

        /// <summary>
        /// The raw response from U2F device, websafe-base64 encoded.
        /// </summary>
        [JsProperty(Name = "signatureData", NativeField = true)]
        public JsString SignatureData { get; set; }

        //clientData

        #endregion

        //Shared in RegisterResponse and SingResposne
        /// <summary>
        /// The client data created by the FIDO client, websafe-base64 encoded
        /// </summary>
        [JsProperty(Name = "clientData", NativeField = true)]
        public JsString ClientData { get; set; }

    }
}

