using System.Collections;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Collections.IDictionary", Filename = "~/Internal/Core.js")]
	internal interface IDictionary : ICollection, IEnumerable
	{
		// Methods
		void Add(object key, object value);
		void Clear();
		bool Contains(object key);
		void Remove(object key);

		// Properties
		bool IsFixedSize { get; }
		bool IsReadOnly { get; }
		object this[object key] { get; set; }
		ICollection Keys { get; }
		ICollection Values { get; }
	}

	[JsType(Name = "System.Collections.IEnumerable", Filename = "~/Internal/Core.js")]
    public interface JsImplIEnumerable
	{
	}

	[JsType(Name = "System.Collections.IEnumerator", Filename = "~/Internal/Core.js")]
	public interface JsImplIEnumerator
	{
	}

	[JsType(Name = "System.Collections.ICollection", Filename = "~/Internal/Core.js")]
    public interface JsImplICollection : JsImplIEnumerable
	{
	}

	[JsType(Name = "System.Collections.IList", Filename = "~/Internal/Core.js")]
	internal interface JsImplIList : JsImplICollection
	{
	}

    [JsType(Name = "System.Collections.IComparer", Filename = "~/Internal/Core.js")]
    public interface JsImplIComparer
    {
        int Compare(object x, object y);
    }
}
