using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpKit.JavaScript.Private
{
    /// <summary>
    /// Implements System.Collections.Generic.Stack &lt;T&gt;
    /// </summary>
    /// <remarks>
    /// A stack is a last-in first-out (LIFO) collection. 
    /// </remarks>
    /// <see href="http://en.wikipedia.org/wiki/Stack_(abstract_data_type)"/>
    /// <typeparam name="T">The type of objects in the collection.</typeparam>
	[JsType(Name = "System.Collections.Generic.Stack$1", Filename = "~/res/System.Collections.js")]
	public class JsImplStack<T> : IEnumerable<T>, ICollection
    {
        #region Fields
        private readonly JsExtendedArray _list;
        #endregion

        #region Initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="JsImplStack{T}" /> class.
        /// </summary>
        public JsImplStack()
		{
			this._list = new JsExtendedArray();
		}
        
        public JsImplStack(int capacity)
        {
            this._list = new JsExtendedArray(capacity);
        }

        public JsImplStack(IEnumerable<T> collection)
        {
            var enumerator = collection.GetEnumerator();
            this._list = new JsExtendedArray();
            int i = 0;
            while (enumerator.MoveNext())
                this._list[i++] = enumerator.Current;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        /// <returns>The number of elements contained in the <see cref="T:System.Collections.ICollection" />.</returns>
        public int Count
        {
            get
            {
                return this._list.length;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Clears all elements from the stack.
        /// </summary>
        public void Clear()
        {
            this._list.Clear();
        }

        /// <summary>
        /// Returns the collection as an array, leaving all elements on the stack.
        /// </summary>
        /// <returns>An array.</returns>
        public T[] ToArray()
        {
            return this._list.Clone().As<T[]>();
        }

        /// <summary>
        /// Pushes the specified item onto the stack.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Push(T item)
        {
            this._list.push(item);
        }

        /// <summary>
        /// Pops and returns an item from the top of the stack.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="JsError"></exception>
        public object Pop()
        {
            if (this._list.length == 0)
                throw new JsError("Cannot pop from stack - stack is empty").As<Exception>();
            return this._list.pop();
        }

        /// <summary>
        /// Returns the element at the top of the stack, without removing it.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="JsError"></exception>
        public object Peek()
        {
            if (this._list.length == 0)
                throw new JsError("Cannot peek in stack - stack is empty").As<Exception>();
            return this._list[this._list.length - 1];
        }

        /// <summary>
        /// Determines whether this stack contains the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        ///   <c>true</c> if this stack contains the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(T item)
        {
            return this._list.contains(item);
        }
        #endregion

		#region IEnumerable Members
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"></see> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this._list.GetEnumerator().As<IEnumerator<T>>();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
		    return this.GetEnumerator();
		}
		#endregion

		#region ICollection Members
        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        /// <exception cref="System.NotImplementedException"></exception>
		void ICollection.CopyTo(Array array, int index)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).
        /// </summary>
        /// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, false.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
		bool ICollection.IsSynchronized
		{
			get { throw new NotImplementedException(); }
		}

        /// <summary>
        /// Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
        /// </summary>
        /// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
		object ICollection.SyncRoot
		{
			get { throw new NotImplementedException(); }
		}
		#endregion
	}
}
