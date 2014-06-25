using System;
using System.Collections.Generic;

using System.Text;
using System.Collections;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Collections.Generic.Queue$1", Filename = "~/res/System.Collections.js")]
	public class JsImplQueue<T> : IEnumerable<T>, ICollection
	{
		JsExtendedArray _list;
        public JsImplQueue()
		{
			this._list = new JsExtendedArray();
		}
        public JsImplQueue(int capacity)
        {
            this._list = new JsExtendedArray(capacity);
        }
        public JsImplQueue(IEnumerable<T> collection)
        {
            var enumerator = collection.GetEnumerator();
            this._list = new JsExtendedArray();
            int i = 0;
            while (enumerator.MoveNext())
                this._list[i++] = enumerator.Current;
        }
		public void Clear()
		{
			this._list.Clear();
		}
		public int Count
		{
			get
			{
				return this._list.length;
			}
		}
		public IEnumerator<T> GetEnumerator()
		{
			return this._list.GetEnumerator().As<IEnumerator<T>>();
		}
		public T[] ToArray()
		{
			return this._list.Clone().As<T[]>();
		}
		public void Enqueue(T item)
		{
			this._list.push(item);
		}
		public object Dequeue()
		{
			if (this._list.length == 0)
				throw new JsError("Cannot dequeue - queue is empty").As<Exception>();
		    var item = this._list[0];
            this._list.RemoveAt(0);
            return item;
		}

        public object Peek()
        {
            if (this._list.length == 0)
                throw new JsError("Cannot peek in queue - queue is empty").As<Exception>();
            return this._list[0];
        }
		
		public bool Contains(T item)
		{
			return this._list.contains(item);
		}


		#region IEnumerable Members

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region ICollection Members

		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

		bool ICollection.IsSynchronized
		{
			get { throw new NotImplementedException(); }
		}

		object ICollection.SyncRoot
		{
			get { throw new NotImplementedException(); }
		}

		#endregion
	}
}
