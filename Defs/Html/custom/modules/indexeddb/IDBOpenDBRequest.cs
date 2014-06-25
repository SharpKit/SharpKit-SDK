using System;

namespace SharpKit.Html.indexeddb.custom
{
    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBOpenDBRequest")]
    public partial class IDBOpenDBRequest : IDBRequest<IDBDatabase>
    {
        public  EventListener onblocked { get; set; }

        public  EventListener onupgradeneeded { get; set; }
    }

}