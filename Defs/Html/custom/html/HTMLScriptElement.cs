using System;

namespace SharpKit.Html
{
    partial class HtmlScriptElement 
    {
        [Obsolete("DOMScriptElement.readyState remains for IE compatibility.")]
        public string readyState { get; set; }

        [Obsolete("DOMScriptElement.onreadystatechange remains the IE equivalent of DOMScriptElement.onload.")]
        public EventListener onreadystatechange { get; set; }
    }
}