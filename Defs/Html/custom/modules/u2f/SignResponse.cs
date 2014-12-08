﻿using System;
using SharpKit.JavaScript;

namespace SharpKit.Html.U2F
{
    /// <summary>
    /// Error or RegisterResponse or SignResponse
    /// - all in one class
    /// </summary>
    [JsType(JsMode.Json, PropertiesAsFields = true, NativeCasts = true)]
    public class SignResponse
    {
        [JsProperty(Name = "errorCode", NativeField = true)]
        public ErrorCode ErrorCode { get; set; }

        [JsProperty(Name = "errorMessage", NativeField = true)]
        public JsString ErrorMessage { get; set; }

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

        /// <summary>
        /// The client data created by the FIDO client, websafe-base64 encoded
        /// </summary>
        [JsProperty(Name = "clientData", NativeField = true)]
        public JsString ClientData { get; set; }

    }
}

