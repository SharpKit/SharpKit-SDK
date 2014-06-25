using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBObjectStore")]
    public partial class IDBObjectStore<Key,Value>
    {
        public  JsString name { get; set; }

        public  IDBAny keyPath { get; set; }

        public  DOMStringList indexNames { get; set; }

        public  IDBTransaction transaction { get; set; }

        public  bool autoIncrement { get; set; }

        public  IDBRequest put(Value value)
        {
            return default(IDBRequest);
        }

        public  IDBRequest put(Value value, Key key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest add(object value)
        {
            return default(IDBRequest);
        }

        public  IDBRequest add(object value, Key key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest delete(IDBKeyRange<Key> keyRange)
        {
            return default(IDBRequest);
        }

        public  IDBRequest delete(Key key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest clear()
        {
            return default(IDBRequest);
        }

        public  IDBRequest get(IDBKeyRange<Key> key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest<Value> get(Key key)
        {
            return default(IDBRequest<Value>);
        }

        public  IDBRequest<IDBCursorWithValue<Key,Value>> openCursor()
        {
            return default(IDBRequest<IDBCursorWithValue<Key,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<Key,Value>> openCursor(IDBKeyRange<Key> range)
        {
            return default(IDBRequest<IDBCursorWithValue<Key,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<Key,Value>> openCursor(IDBKeyRange<Key> range, string direction)
        {
            return default(IDBRequest<IDBCursorWithValue<Key,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<Key,Value>> openCursor(Key key)
        {
            return default(IDBRequest<IDBCursorWithValue<Key,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<Key,Value>> openCursor(Key key, string direction)
        {
            return default(IDBRequest<IDBCursorWithValue<Key,Value>>);
        }

        public  IDBIndex createIndex(string name, JsString keyPath)
        {
            return default(IDBIndex);
        }

        public  IDBIndex createIndex(string name, JsString keyPath, object options)
        {
            return default(IDBIndex);
        }

        public  IDBIndex createIndex(string name, string keyPath)
        {
            return default(IDBIndex);
        }

        public  IDBIndex createIndex(string name, string keyPath, object options)
        {
            return default(IDBIndex);
        }

        public  IDBIndex<Index,Value> createIndex<Index>(string name, JsString keyPath)
        {
            return default(IDBIndex<Index,Value>);
        }

        public  IDBIndex<Index,Value> createIndex<Index>(string name, JsString keyPath, object options)
        {
            return default(IDBIndex<Index,Value>);
        }

        public  IDBIndex<Index,Value> createIndex<Index>(string name, string keyPath)
        {
            return default(IDBIndex<Index,Value>);
        }

        public  IDBIndex<Index,Value> createIndex<Index>(string name, string keyPath, object options)
        {
            return default(IDBIndex<Index,Value>);
        }

        public  IDBIndex<Index,Value> index<Index>(string name)
        {
            return default(IDBIndex<Index,Value>);
        }

        public  void deleteIndex(string name)
        {
        }

        public  IDBRequest count()
        {
            return default(IDBRequest);
        }

        public  IDBRequest count(IDBKeyRange<Key> range)
        {
            return default(IDBRequest);
        }

        public  IDBRequest count(Key key)
        {
            return default(IDBRequest);
        }
    }

}