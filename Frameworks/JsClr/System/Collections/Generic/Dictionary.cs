using System;
using System.Collections.Generic;
using SharpKit.JavaScript.Utils;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Collections.Generic.Dictionary$2", Filename = "~/res/System.Collections.js")]
    class JsImplDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        JsObject _table;
        JsObject _keys;
        int _version;
        public JsImplDictionary()
        {
            this._table = new JsObject();
            this._keys = new JsObject();
            this._version = 0;
        }

        public JsImplDictionary(IEqualityComparer<TKey> comparer)
        {
            this._table = new JsObject();
            this._keys = new JsObject();
            this._version = 0;
            Comparer = comparer;
        }

        IEqualityComparer<TKey> Comparer;
        protected virtual string GetHashKey(TKey key)
        {
            if (Comparer != null)
                return Comparer.GetHashCode(key).As<string>();
            return Js.GetHashKey(key);
        }
        public void Add(TKey key, TValue value)
        {
            // If TKey is default(ValueType), it's a valid key.
            if (key == null)
                throw new ArgumentNullException("key");
            if (this.ContainsKey(key))
                throw new ArgumentException("The specified key already exists.", "key", null);

            var hashKey = GetHashKey(key);
            this._table[hashKey] = value;
            this._keys[hashKey] = key;
            this._version++;
        }

        public bool Remove(TKey key)
        {
            // If TKey is default(ValueType), it's a valid key.
            if (key == null)
                throw new ArgumentNullException("key");
            var result = this.ContainsKey(key);
            var hashKey = GetHashKey(key);
            JsContext.delete(this._table[hashKey]);
            JsContext.delete(this._keys[hashKey]);
            this._version++;
            return result;
        }

        public TValue this[TKey key]
        {
            get
            {
                if (!this.ContainsKey(key))
                    throw new KeyNotFoundException("The specified key does not exist.");
                var hashKey = GetHashKey(key);
                return this._table[hashKey].As<TValue>();
            }
            set
            {
                //if (!this.ContainsKey(key))
                //    throw new KeyNotFoundException("The specified key does not exist.");
                var hashKey = GetHashKey(key);
                this._table[hashKey] = value;
                this._keys[hashKey] = key;
                this._version++;
            }
        }
        public bool ContainsKey(TKey key)
        {
            var hashKey = GetHashKey(key);
            return JsContext.@typeof(this._table[hashKey]) != "undefined";
        }
        public ICollection<TKey> Keys
        {
            get
            {
                var keys = new JsArray();
                foreach (var p in this._keys)
                {
                    keys.push(this._keys[p]);
                }
                return keys.As<ICollection<TKey>>();
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                var values = new JsArray();
                foreach (var p in this._table)
                {
                    values.push(this._table[p]);
                }
                return values.As<ICollection<TValue>>();
            }
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            var array = new JsArray(); //TODO:
            foreach (var hashKey in this._table)
            {
                array.push(new KeyValuePair<TKey, TValue>(this._keys[hashKey].As<TKey>(), this._table[hashKey].As<TValue>()));
            }
            return array.As<JsExtendedArray>().GetEnumerator().As<IEnumerator<KeyValuePair<TKey, TValue>>>();
        }
        public void Clear()
        {
            foreach (var hashKey in this._table)
            {
                this._keys = new JsObject();
                this._table = new JsObject();
                this._version++;
                return;
            }
        }

        #region IDictionary<TKey,TValue> Members
        public bool TryGetValue(TKey key, out TValue value)
        {
            var hashKey = GetHashKey(key);
            var v = this._table[hashKey];
            value = v.As<TValue>();
            return JsContext.@typeof(v) != "undefined";
        }


        #endregion

        #region ICollection<KeyValuePair<TKey,TValue>> Members

        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

    }

    [JsType(Name = "System.Collections.Generic.KeyNotFoundException", Filename = "~/Internal/Core.js")]
    internal class JsImplKeyNotFoundException : JsImplException
    {
        public JsImplKeyNotFoundException()
            : base("JsImplKeyNotFoundException")
        {
        }
        public JsImplKeyNotFoundException(string s)
            : base("JsImplKeyNotFoundException: " + s)
        {
        }
        public JsImplKeyNotFoundException(string s, Exception innerException)
            : base("JsImplKeyNotFoundException: " + s, innerException)
        {
        }
    }


}
//using System;
//using System.Collections.Generic;
//
//using System.Text;
//

//namespace SharpKit.JavaScript.Private
//{
//  //[JsType(Name="System.Collections.Generics.Dictionary$2")]
//  public class Dictionary<K, T>
//  {
//  }


//  public class DuplexHashtable
//  {
//    JsObject _table;
//    JsObject _table2;

//    DuplexHashtable()
//    {
//      this._table = new JsObject();
//      this._table2 = new JsObject();
//    }

//    //void AddRange(object[] keyValuePairs)
//    //{
//    //  var arr = keyValuePairs.AsJsArray();
//    //  for (var i = 0; i < arr.length; i++)
//    //  {
//    //    this.Add(arr[i][0], arr[i][1]);
//    //  }
//    //}
//    void Add(object key, object value)
//    {
//      var hashKey = Js.GetHashKey(key);
//      this._table[hashKey] = value;
//      var valueHashKey = Js.GetHashKey(value);
//      this._table2[valueHashKey] = key;
//    }
//    void Remove(object key)
//    {
//      var hashKey = Js.GetHashKey(key);
//      var value = this._table[hashKey];
//      Js.DeleteMember(this._table, hashKey);
//      var valueHashKey = Js.GetHashKey(value);
//      Js.DeleteMember(this._table2, valueHashKey);
//    }
//    public object this[object key]
//    {
//      get
//      {
//        var hashKey = Js.GetHashKey(key);
//        return this._table[hashKey];
//      }
//      set
//      {
//        var hashKey = Js.GetHashKey(key);
//        this._table[hashKey] = value;
//        var valueHashKey = Js.GetHashKey(value);
//        this._table2[valueHashKey] = key;
//      }
//    }
//    object GetKey(object value)
//    {
//      var valueHashKey = Js.GetHashKey(value);
//      return this._table2[valueHashKey];
//    }
//    bool ContainsKey(object key)
//    {
//      var hashKey = Js.GetHashKey(key);
//      return this._table[hashKey] != null;
//    }
//    bool ContainsValue(object value)
//    {
//      throw new Exception("Not implemented");
//    }

//  }

//}
