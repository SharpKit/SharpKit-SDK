using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using System.Collections;

namespace SharpKit.JavaScript.Private
{

	[JsType(Name="System.Collections.IListEnumerator$1", Filename = "~/res/System.Collections.js")]
	class IListEnumerator<T> : IEnumerator<T>
	{
		public IListEnumerator(IList<T> list)
		{
			List = list;
			Index = -1;
			ListCount = list.Count;
		}
		IList<T> List;
		int Index;
		int ListCount;
		#region IEnumerator<T> Members

		public T Current
		{
			get
			{
				return List[Index];
			}
		}

		#endregion

		#region IDisposable Members

		public void Dispose()
		{
			List = null;
		}

		#endregion

		#region IEnumerator Members

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public bool MoveNext()
		{
			Index++;
			return Index < ListCount;
		}

		public void Reset()
		{
			Index = -1;
		}

		#endregion
	}



}
