using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    [JsType(JsMode.Json)]
    public enum ErrorCode
    {
        /// <summary>
        /// Success. Not used in errors but reserved
        /// </summary>
        OK = 0,
        /// <summary>
        /// An error otherwise not enumerated here
        /// </summary>
        OtherError = 1,
        /// <summary>
        /// The request cannot be processed
        /// </summary>
        BadRequest = 2,
        /// <summary>
        /// Client configuration is not supported
        /// </summary>
        ConfigurationUnsupported = 3,
        /// <summary>
        /// The presented device is not eligible for this request. For a registration request this may mean that the token is already registered, and
        /// for a sign request it may mean the token does not know the presented key handle.
        /// </summary>
        DeviceIneligible = 4,
        /// <summary>
        /// Timeout reached before request could be satisfied
        /// </summary>
        Timeout = 5,
    }
}

