using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.BasicNavigation
{
    [JsType(Name = "Querystring", OmitDefaultConstructor = true, Mode = JsMode.Prototype, Filename = "../js/demo-basicnavigation.js", OrderInFile = 2, PreCode = "//---------QueryString----------//")]
    public class QueryString : HtmlContext
    {
        [JsField(Name = "params")]
        public JsObject<JsString> parameters;
        /// <summary>
        /// get(JsString key, JsString default_) return JsString
        /// </summary>
        public JsNativeFunc<JsString, JsString, JsString> get;
        [JsMethod(Global = true, Name = "Querystring")]
        public void Querystring(JsString qs = null)
        { // optionally pass a querystring to parse
            this.parameters = new JsObject<JsString>();
            JsCode("this.get = Querystring_get");

            if (qs == null)
                qs = location.search.Substring(1, location.search.length);

            if (qs.length == 0) return;

            // Turn <plus> back to <space>
            // See: http://www.w3.org/TR/REC-html40/interact/forms.html#h-17.13.4.1
            qs = qs.Replace(new JsRegExp("\\+", "g"), " ");
            JsArray<JsString> args = qs.Split('&'); // parse out name/value pairs separated via &
            // split out each name=value pair
            for (int i = 0; i < args.length; i++)
            {
                JsString value;
                JsArray<JsString> pair = args[i].Split('=');
                JsString name = Unescape(pair[0]);

                if (pair.length == 2)
                    value = Unescape(pair[1]);
                else
                    value = name;
                this.parameters[name] = value;
            }
        }
        [JsMethod(Global = true)]
        JsString Querystring_get(JsString key, JsString default_)
        {
            // This silly looking line changes UNDEFINED to NULL
            if (default_ == null) default_ = null;

            JsString value = this.parameters[key];
            if (value == null) value = default_;

            return value;
        }

    }
}