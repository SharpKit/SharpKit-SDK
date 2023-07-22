using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    [JsType(JsMode.Json, PropertiesAsFields = true, NativeCasts = true)]
    public class RegisterRequest
    {
        /// <summary>
        /// The version of the protocol that the to-be-registered token must speak. E.g. "U2F_V2".
        /// </summary>
        [JsProperty(Name = "version", NativeField = true)]
        public JsString Version { get; set; }

        /// <summary>
        /// The websafe-base64-encoded challenge.
        /// </summary>
        [JsProperty(Name = "challenge", NativeField = true)]
        public JsString Challenge { get; set; }

        /// <summary>
        /// The application id that the RP asserts. The new key pair that the U2F token generates will be associated with this application id.
        /// (For application id details see [U2FAppFacet] in bibliography).
        /// </summary>
        [JsProperty(Name = "appId", NativeField = true)]
        public JsString AppID { get; set; }

    }
}

