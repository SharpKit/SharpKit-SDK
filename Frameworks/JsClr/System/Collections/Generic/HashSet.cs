using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using SharpKit.JavaScript;
using System.Collections.Generic;
using SharpKit.JavaScript.Utils;
namespace SharpKit.JavaScript.Private
{
    /// <summary>Represents a set of values.</summary>
    /// <typeparam name="T">The type of elements in the hast set.</typeparam>
    [JsType(JsMode.Clr, Name = "System.Collections.Generic.HashSet$1", Filename = "~/res/System.Collections.js")]
    public class JsImplHashSet<T> : JsImplISet<T>, JsImplICollection<T>, JsImplIEnumerable<T>, JsImplIEnumerable
    {
        public JsImplHashSet()
        {
        }
        public JsImplHashSet(IEqualityComparer<T> comparer)
        {
            Comparer = comparer;
        }
        JsObject<T> Hashtable = new JsObject<T>();
        #region JsImplISet<T> Members

        IEqualityComparer<T> Comparer;
        protected virtual string GetHashKey(T key)
        {
            if (Comparer != null)
                return Comparer.GetHashCode(key).As<string>();
            return Js.GetHashKey(key);
        }
        public bool Add(T item)
        {
            var key = GetHashKey(item);
            if (Hashtable[key]!=null)
                return false;
            Hashtable[key] = item;
            _Count++;
            return true;
        }

        public void UnionWith(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(JsImplIEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region JsImplICollection<T> Members

        int _Count;
        public int Count
        {
            get { return _Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Clear()
        {
            Hashtable = new JsObject<T>();
            _Count = 0;
        }

        public bool Contains(T item)
        {
            var key = GetHashKey(item);
            if (Hashtable[key].ExactEquals(item))
                return true;
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            var key = GetHashKey(item);
            if (Hashtable[key].ExactEquals(item))
            {
                JsContext.delete(Hashtable[key]);
                _Count--;
                return true;
            }
            return false;
        }


        void JsImplICollection<T>.Add(T item)
        {
            Add(item);
        }

        #endregion

        #region JsImplIEnumerable<T> Members

        public JsImplIEnumerator<T> GetEnumerator()
        {
            var array = new JsArray<T>();
            foreach (var hashKey in Hashtable)
            {
                array.push(Hashtable[hashKey]);
            }
            return new JsArrayEnumerator<T>(array);

        }

        #endregion
    }
}
