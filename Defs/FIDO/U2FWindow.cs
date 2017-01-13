using System;
using SharpKit.JavaScript;

namespace SharpKit.FIDO
{
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "window")]
    public partial class U2FWindow
    {
        /// <summary>
        /// FIDO U2F
        /// http://fidoalliance.org/specs/fido-u2f-javascript-api-v1.0-rd-20141008.pdf
        /// </summary>
        public static U2F u2f { get; set; }
    }
}