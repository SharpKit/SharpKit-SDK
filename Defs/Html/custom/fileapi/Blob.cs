using SharpKit.JavaScript;

namespace SharpKit.Html.fileapi
{
    partial class Blob
    {
        public Blob() { }
        public Blob(ArrayBuffer[] arrayBuffer) { }
        public Blob(ArrayBufferView[] arrayBufferView) { }
        public Blob(string[] value) { }
        public Blob(ArrayBuffer[] arrayBuffer, object propertyBag) { }
        public Blob(ArrayBufferView[] arrayBufferView, object propertyBag = null) { }
        public Blob(string[] value, object propertyBag) { }

        [JsMethod(Name = "slice")]
        public Blob Slice(long start=0, long end=0, string contentType="") { return null; }

        [JsMethod(Name = "close")]
        public void Close() {}
    }
}