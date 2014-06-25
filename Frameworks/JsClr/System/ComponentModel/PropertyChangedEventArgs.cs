using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.ComponentModel.INotifyPropertyChanging", Filename = "~/Internal/Core.js")]
	internal interface JsImplINotifyPropertyChanging
	{
	}

	[JsType(Name = "System.ComponentModel.INotifyPropertyChanged", Filename = "~/Internal/Core.js")]
	internal interface JsImplINotifyPropertyChanged
	{
	}

	[JsType(Name = "System.ComponentModel.PropertyChangedEventHandler", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplPropertyChangedEventHandler(object sender, JsImplPropertyChangedEventArgs e);

	[JsType(Name = "System.ComponentModel.PropertyChangedEventArgs", Filename = "~/Internal/Core.js")]
	//[Remotable]
	internal class JsImplPropertyChangedEventArgs : JsImplEventArgs
	{
		// Fields
		private readonly string _PropertyName;

		// Methods
		public JsImplPropertyChangedEventArgs(string propertyName)
		{
			this._PropertyName = propertyName;
		}

		// Properties
		public virtual string PropertyName
		{
			get
			{
				return this._PropertyName;
			}
		}
	}

}
