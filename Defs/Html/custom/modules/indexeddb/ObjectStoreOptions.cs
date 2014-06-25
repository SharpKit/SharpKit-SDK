using System;
using SharpKit.JavaScript;

namespace SharpKit.Html.indexeddb
{
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBObjectStoreOptions")]
    public class ObjectStoreOptions
    {
        [JsProperty(Name = "keyPath")]
        public string keyPath { get; set; }
    }
}

