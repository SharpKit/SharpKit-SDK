using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.ComponentModel.CancelEventHandler", Filename = "~/Internal/Core.js")]
	internal delegate void JsImplCancelEventHandler(object sender, JsImplCancelEventArgs e);

    [JsType(Name = "System.ComponentModel.CancelEventArgs", Filename = "~/Internal/Core.js")]
	internal class JsImplCancelEventArgs : JsImplEventArgs
	{

		// Methods
		public JsImplCancelEventArgs()
		{
			_Cancel = false;
		}

		public JsImplCancelEventArgs(bool cancel)
		{
			this._Cancel = cancel;
		}

		private bool _Cancel;
		public bool Cancel
		{
			get
			{
				return this._Cancel;
			}
			set
			{
				this._Cancel = value;
			}
		}
	}


}
