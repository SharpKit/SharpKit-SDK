using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBCursor")]
    public partial class IDBCursor<Key>
    {
        public  JsString direction { get; set; }

        public  Key key { get; set; }

        public  Key primaryKey { get; set; }

        public  IDBAny source { get; set; }

        public  IDBRequest update(object value)
        {
            return default(IDBRequest);
        }

        public  void advance(int count)
        {
        }

        public  void @continue()
        {
        }

        public  void @continue(Key key)
        {
        }

        public  IDBRequest delete()
        {
            return default(IDBRequest);
        }
    }

}