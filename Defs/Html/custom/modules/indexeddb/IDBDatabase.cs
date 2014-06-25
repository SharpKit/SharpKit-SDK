using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBDatabase")]
    public partial class IDBDatabase
    {
        public  IDBObjectStore<Key,Value> createObjectStore<Key,Value>(string name)
        {
            return default(IDBObjectStore<Key,Value>);
        }

        public  IDBObjectStore<Key,Value> createObjectStore<Key,Value>(string name, ObjectStoreOptions options)
        {
            return default(IDBObjectStore<Key,Value>);
        }

        public  IDBTransaction transaction(JsArray<string> storeNames, string mode)
        {
            return default(IDBTransaction);
        }
    }
}