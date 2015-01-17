using System;
using SharpKit.JavaScript;

namespace SharpKit.Html
{
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Window")]
    public partial class Window
    {
        /// <summary>
        /// FIDO U2F
        /// http://fidoalliance.org/specs/fido-u2f-javascript-api-v1.0-rd-20141008.pdf
        /// </summary>
        public SharpKit.Html.U2F.U2F u2f { get; set; }
    }
}