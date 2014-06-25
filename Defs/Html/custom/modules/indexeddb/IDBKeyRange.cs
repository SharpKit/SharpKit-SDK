using System;

namespace SharpKit.Html.indexeddb
{

    using SharpKit.JavaScript;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBKeyRange")]
    public partial class IDBKeyRange<Key>
    {
        public  Key lower { get; set; }

        public  Key upper { get; set; }

        public  bool lowerOpen { get; set; }

        public  bool upperOpen { get; set; }

        public static IDBKeyRange<Key> only(Key value)
        {
            return default(IDBKeyRange<Key>);
        }

        public static IDBKeyRange<Key> lowerBound(Key bound)
        {
            return default(IDBKeyRange<Key>);
        }

        public static IDBKeyRange<Key> lowerBound(Key bound, bool open)
        {
            return default(IDBKeyRange<Key>);
        }

        public static IDBKeyRange<Key> upperBound(Key bound)
        {
            return default(IDBKeyRange<Key>);
        }

        public static IDBKeyRange<Key> upperBound(Key bound, bool open)
        {
            return default(IDBKeyRange<Key>);
        }

        /// <summary>
        /// The closed range(including lower and upper values)
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        public static IDBKeyRange<Key> bound(Key lower, Key upper)
        {
            return default(IDBKeyRange<Key>);
        }

        public static IDBKeyRange<Key> bound(Key lower, Key upper, bool lowerOpen)
        {
            return default(IDBKeyRange<Key>);
        }

        public static IDBKeyRange<Key> bound(Key lower, Key upper, bool lowerOpen, bool upperOpen)
        {
            return default(IDBKeyRange<Key>);
        }
    }

}