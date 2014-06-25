using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBTransaction")]
    public partial class IDBTransaction
    {
        public const string READ_ONLY = "readonly";
        public const string READ_WRITE = "readwrite";
        public const string VERSION_CHANGE = "versionchange";

        public  IDBObjectStore<Key,Value> objectStore<Key,Value>(string name)
        {
            return default(IDBObjectStore<Key,Value>);
        }
    }
}