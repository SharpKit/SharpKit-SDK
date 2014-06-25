using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBIndex")]
    public partial class IDBIndex<IndexKey,Value>
    {
        public  JsString name { get; set; }

        public  IDBObjectStore objectStore { get; set; }

        public  IDBAny keyPath { get; set; }

        public  bool unique { get; set; }

        public  bool multiEntry { get; set; }

        public  IDBRequest<IDBCursorWithValue<IndexKey,Value>> openCursor()
        {
            return default(IDBRequest<IDBCursorWithValue<IndexKey,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<IndexKey,Value>> openCursor(IDBKeyRange<IndexKey> range)
        {
            return default(IDBRequest<IDBCursorWithValue<IndexKey,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<IndexKey,Value>> openCursor(IDBKeyRange<IndexKey> range, string direction)
        {
            return default(IDBRequest<IDBCursorWithValue<IndexKey,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<IndexKey,Value>> openCursor(IndexKey key)
        {
            return default(IDBRequest<IDBCursorWithValue<IndexKey,Value>>);
        }

        public  IDBRequest<IDBCursorWithValue<IndexKey,Value>> openCursor(IndexKey key, string direction)
        {
            return default(IDBRequest<IDBCursorWithValue<IndexKey,Value>>);
        }

        public  IDBRequest openKeyCursor()
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(IDBKeyRange<IndexKey> range)
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(IDBKeyRange<IndexKey> range, string direction)
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(IndexKey key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest openKeyCursor(IndexKey key, string direction)
        {
            return default(IDBRequest);
        }

        public  IDBRequest get(IDBKeyRange<IndexKey> key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest<Value> get(IndexKey key)
        {
            return default(IDBRequest<Value>);
        }

        public  IDBRequest getKey(IDBKeyRange<IndexKey> key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest getKey(IndexKey key)
        {
            return default(IDBRequest);
        }

        public  IDBRequest count()
        {
            return default(IDBRequest);
        }

        public  IDBRequest count(IDBKeyRange<IndexKey> range)
        {
            return default(IDBRequest);
        }

        public  IDBRequest count(IndexKey key)
        {
            return default(IDBRequest);
        }
    }

}