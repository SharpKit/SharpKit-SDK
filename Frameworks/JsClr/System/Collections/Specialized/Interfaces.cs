using System.Collections.Specialized;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Collections.Specialized.NotifyCollectionChangedAction", Filename = "~/Internal/Core.js")]
	public enum JSImplNotifyCollectionChangedAction
	{
		Add,
		Remove,
		Replace,
		Move,
		Reset,
	}

	[JsType(Name = "System.Collections.Specialized.INotifyCollectionChanged", Filename = "~/Internal/Core.js")]
	public interface JsImplINotifyCollectionChanged
	{
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}

}
