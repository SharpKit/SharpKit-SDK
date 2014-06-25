using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SharpKit.JavaScript
{
	[JsType(Export = false, Name = "Array", NativeConstructors = true)]
	public class JsExtendedArray : JsArray, IEnumerable
	{
		public JsExtendedArray()
		{
		}

		/// <summary>
		/// An array to be copied to the array being constructed. 
		/// </summary>
		/// <param name="array"></param>
		public JsExtendedArray(JsArray array)
		{
		}

		/// <summary>
		/// The size of the array. As arrays are zero-based, created elements will have indexes from zero to size -1. 
		/// </summary>
		/// <param name="size"></param>
		public JsExtendedArray(int size)
		{
		}

		/// <summary>
		/// A typed array that contains all the parameters passed to the constructor. These parameters are used as the first elements of the array. 
		/// </summary>
		/// <param name="items"></param>
		public JsExtendedArray(params object[] items)
		{
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public new System.Collections.IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}


		public JsExtendedArray Clone()
		{
			throw new NotImplementedException();
		}

		public void Remove(object item)
		{
			throw new NotImplementedException();
		}

		[JsMethod(NativeOverloads = true)]
		public int indexOf(object value, int startIndex)
		{
			throw new NotImplementedException();
		}

        //[JsMethod(NativeOverloads = true)]
        //public int indexOf(object value)
        //{
        //    throw new NotImplementedException();
        //}
		[JsMethod(NativeOverloads = true)]
		public void insert(int index, object value)
		{
			throw new NotImplementedException();
		}
		[JsMethod(NativeOverloads = true)]
		public bool contains(object obj)
		{
			throw new NotImplementedException();
		}
        [JsMethod(NativeOverloads = true)]
        public JsExtendedArray reverse(object obj)
        {
            throw new NotImplementedException();
        }
		[JsMethod(NativeOverloads = true)]
		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}


		[JsMethod(NativeOverloads = true)]
		public JsExtendedArray concat()
		{
			throw new NotImplementedException();
		}
	}
}
