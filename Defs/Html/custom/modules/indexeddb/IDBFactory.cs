
using System;

namespace SharpKit.Html.indexeddb.custom
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBFactory")]
    public partial class IDBFactory
    {
        public  IDBOpenDBRequest open(string name)
        {
            return default(IDBOpenDBRequest);
        }

        public  IDBOpenDBRequest open(string name, int version)
        {
            return default(IDBOpenDBRequest);
        }

        public  IDBVersionChangeRequest deleteDatabase(string name)
        {
            return default(IDBVersionChangeRequest);
        }

        public  short cmp(IDBKey first, IDBKey second)
        {
            return default(short);
        }
    }

}