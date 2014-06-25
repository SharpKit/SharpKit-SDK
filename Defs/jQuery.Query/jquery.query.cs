using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.jQuery
{
    /// <summary>
    /// jQuery.Query plugin
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, Name="$")]
	public static class QueryPlugin
	{
        public static jQueryQueryString query { get; private set; }

	}

    [JsType(JsMode.Prototype, Export = false)]
    public class jQueryQueryString
    {
        public object get(JsString key) { return null; }
        public jQueryQueryString set(JsString key, object value) { return null; }
        public jQueryQueryString remove(JsString key) { return null; }
        public jQueryQueryString empty() { return null; }
        public jQueryQueryString copy() { return null; }
        public jQueryQueryString load(JsString url) { return null; }
        public JsString toString() { return null; }
    }
}
