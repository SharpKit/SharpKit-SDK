using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBRequest")]
    public partial class IDBRequest<Result>
    {
        public  Result result { get; set; }

        public  DOMError error { get; set; }

        public  IDBAny source { get; set; }

        public  IDBTransaction transaction { get; set; }

        public  JsString readyState { get; set; }

        public  EventListener onsuccess { get; set; }

        public  EventListener<ErrorEvent> onerror { get; set; }

        public  void addEventListener(string type, EventListener listener)
        {
        }

        public  void addEventListener(string type, EventListener listener, bool useCapture)
        {
        }

        public  void removeEventListener(string type, EventListener listener)
        {
        }

        public  void removeEventListener(string type, EventListener listener, bool useCapture)
        {
        }

        public  bool dispatchEvent(DOMEvent evt)
        {
            return default(bool);
        }
    }

}