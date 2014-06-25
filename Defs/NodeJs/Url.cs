using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    [JsType(JsMode.Json, Export = false, Name = "url")]
    public partial class UrlPlugin : IRequirable
    {
        public Url parse(JsString url, bool parseQueryString, bool slashesDenoteHost) { return null; }
        public Url parse(JsString url, bool parseQueryString) { return null; }
        public Url parse(JsString url) { return null; }


        public JsString format(Url url) { return null; }
        public JsString resolve(JsString from, JsString to) { return null; }
    }

    [JsType(JsMode.Json, Export = false, Name = "url")]
    public partial class Url
    {
        public static Url parse(JsString url, bool x) { return null; }
        public JsString href { get; set; }
        public JsString protocol { get; set; }
        public JsString host { get; set; }
        public JsString auth { get; set; }
        public JsString hostname { get; set; }
        public JsString port { get; set; }
        public JsString pathname { get; set; }
        public JsString search { get; set; }
        public JsString path { get; set; }
        public JsString query { get; set; }
        [JsProperty(Name="query", NativeField=true)]
        public JsObject<JsString> parsedQuery { get; set; }
        public JsString hash { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, Name = "connection")]
    public partial class Connection
    {
        public static Connection query(JsString squery, JsAction<JsError, object, object> callback) { return null; }
    }

    public partial class Request
    {
        public JsString url { get; set; }
    }
}
