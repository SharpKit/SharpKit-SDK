using SharpKit.JavaScript;

namespace SharpKit.Html.storage
{
    partial class Storage
    {
        [JsProperty(NativeIndexer = true)]
        public string this[string key]
        {
            get { return getItem(key); }
            set { setItem(key, value); }
        }
    }
}
