using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    /// <summary>
    /// FIDO U2F
    /// http://fidoalliance.org/specs/fido-u2f-javascript-api-v1.0-rd-20141008.pdf
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "U2F")]
    public class U2F
    {
        public const string Version2 = "U2F_V2";

        /// <summary>
        /// High-level API
        /// </summary>
        [JsMethod(Name = "register")]
        public void Register(RegisterRequest[] registerRequests, SignRequest[] signRequests, JsAction<RegisterResponse> callback, int timeoutSeconds = 0)
        {
        }

        /// <summary>
        /// High-level API
        /// </summary>
        [JsMethod(Name = "sign")]
        public void Sign(SignRequest[] signRequests, JsAction<SignResponse> callback)
        {
        }

        /// <summary>
        /// High-level API
        /// </summary>
        [JsMethod(Name = "sign")]
        public void Sign(SignRequest[] signRequests, JsAction<SignResponse> callback, int timeoutSeconds)
        {
        }
    }
}

