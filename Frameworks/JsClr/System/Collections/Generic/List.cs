using System;
using System.Collections.Generic;
using System.Collections;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Collections.Generic.List$1", Filename = "~/res/System.Collections.js")]
	//[Remotable]
	internal partial class JsImplList<T> : IList<T>, IList
	{
		public JsImplList()
		{
			this._list = new JsExtendedArray();
		}

		public JsImplList(IEnumerable<T> collection)
		{
			this._list = new JsExtendedArray();
			AddRange(collection);
		}

        public JsImplList(int capacity)
        {
            //Hint: in this js implementation, the capacity will not used. This overload is only for compatibility.
            this._list = new JsExtendedArray();
        }

		public void RemoveRange(int index, int count)
		{
			_list.splice(index, count);
		}

	    readonly JsExtendedArray _list;
		public void Clear()
		{
			this._list.Clear();
		}
		public T this[int index]
		{
			get
			{
				if (index >= this._list.length || index < 0)
					throw new ArgumentOutOfRangeException("index");
				return this._list[index].As<T>();
			}
			set
			{
				if (index >= this._list.length || index<0)
					throw new ArgumentOutOfRangeException("index");
				this._list[index] = value;
			}
		}
		public int Count
		{
			get
			{
				return this._list.length;
			}
		}

		//[Remotable(false)]
		//[JsMethod(Code="return this._list.GetEnumerator();")]
		public IEnumerator<T> GetEnumerator()
		{
			return new IListEnumerator<T>(this);// this._list.GetEnumerator().As<IEnumerator<T>>();
		}

		public T[] ToArray()
		{
		    int len = this.Count;
		    var array = new JsArray<T>(len);
            for (int i = 0; i < len; i++)
                array[i] = this[i];
		    return array;
		}

		public void AddRange(IEnumerable<T> items)
		{
			foreach(T item in items)
			{
				this.Add(item);
			}
		}

		public void Add(T item)
		{
			this._list.push(item);
		}

		public bool Remove(T item)
		{
			var index = _list.indexOf(item);
			if (index == -1)
				return false;
			this._list.RemoveAt(index);
			return true;
		}

		public bool Contains(T item)
		{
			return this._list.contains(item);
		}

		public void SetItems(IEnumerable<T> items)
		{
			this.Clear();
			if (items != null)
				this.AddRange(items);
		}

		public int IndexOf(T item)
		{
			return _list.indexOf(item);
		}

		public void Insert(int index, T item)
		{
			_list.insert(index, item);
		}

		public void RemoveAt(int index)
		{
			_list.RemoveAt(index);
		}

		public bool TryRemove(T item)
		{
			throw new NotImplementedException("TryRemove");
		}

		#region ICollection<T> Members

		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new NotImplementedException("JsImplList$T");
		}


		public bool IsReadOnly
		{
			get { throw new NotImplementedException("JsImplList$T"); }
		}


		#endregion

		//TODO:
		//bool ICollection<T>.Remove(T item)
		//{
		//  return TryRemove(item);
		//}

        public void Reverse()
        {
            _list.reverse();
        }

        public void Sort()
        {
            //_list.sort();
            Array.Sort(_list.As<T[]>());
        }
        
        public void Sort(Comparison<T> comparison)
        {
            _list.sort(comparison.As<JsFunction>());
        }

        /// <summary>Performs the specified action on each element of the <see cref="T:System.Collections.Generic.List`1" />.</summary>
        /// <param name="action">The <see cref="T:System.Action`1" /> delegate to perform on each element of the <see cref="T:System.Collections.Generic.List`1" />.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="action" /> is null.</exception>
        public void ForEach(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");
            for (int i = 0; i < _list.length; i++)
            {
                action(_list[i].As<T>());
            }
        }

		#region IList Members

		int IList.Add(object value)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		bool IList.Contains(object value)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		int IList.IndexOf(object value)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		void IList.Insert(int index, object value)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		bool IList.IsFixedSize
		{
			get { throw new NotImplementedException("JsImplList$T"); }
		}

		bool IList.IsReadOnly
		{
			get { throw new NotImplementedException("JsImplList$T"); }
		}

		void IList.Remove(object value)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		void IList.RemoveAt(int index)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		object IList.this[int index]
		{
			get
			{
				throw new NotImplementedException("JsImplList$T");
			}
			set
			{
				throw new NotImplementedException("JsImplList$T");
			}
		}

		#endregion

		#region ICollection Members

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException("JsImplList$T");
		}

		bool ICollection.IsSynchronized
		{
			get { throw new NotImplementedException("JsImplList$T"); }
		}

		object ICollection.SyncRoot
		{
			get { throw new NotImplementedException("JsImplList$T"); }
		}

		#endregion

		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException("JsImplList$T");
		}

		#endregion
	}

	// Summary:
	//     Represents the method that compares two objects of the same type.
	//
	// Parameters:
	//   x:
	//     The first object to compare.
	//
	//   y:
	//     The second object to compare.
	//
	// Type parameters:
	//   T:
	//     The type of the objects to compare.
	//
	// Returns:
	//     Value Condition Less than 0 x is less than y.  0 x equals y.  Greater than
	//     0 x is greater than y.
	[JsType(Name="System.Comparison$1", Filename="~/Internal/Core.js")]
	internal delegate int JsImplComparison<T>(T x, T y);



}
