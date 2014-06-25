using System;
using System.Collections.Generic;

using System.Text;

using System.Collections;
using System.Security.Permissions;
using System.Runtime.Serialization;

namespace SharpKit.JavaScript.Private
{
	
	//[Serializable, ComVisible(true), ComDefaultInterface(typeof(_Exception)), ClassInterface(ClassInterfaceType.None)]

	//[Remotable]
	[JsType(Name = "System.Exception", Filename = "~/Internal/Core.js")]
	internal class JsImplException //: ISerializable, _Exception
	{
		//protected JsImplException(SerializationInfo info, StreamingContext context)
		//{
		//}

		public JsImplException(string message, Exception innerException)
		{
			_Message = message;
			_InnerException = innerException;
		}
		public JsImplException(string message)
		{
			_Message = message;
		}
		public JsImplException()
		{
		}
		Exception _InnerException;
		//[Remotable("Greedy")]
		public Exception InnerException
		{
			get
			{
				return this._InnerException;
			}
		}

		string _Message;
		public virtual string Message
		{
			get
			{
				return this._Message;
			}
		}

		public override string ToString()
		{
			var ie = InnerException;
			if (ie == null)
				return Message;
			return Message + ", " + InnerException;
		}

		//[Remotable(false)]
		internal void SetErrorCode(int hr)
		{
		}

		//[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		//public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		//{
		//  //string stackTrace = this._stackTraceString;
		//  //if (info == null)
		//  //{
		//  //  throw new ArgumentNullException("info");
		//  //}
		//  //if (this._className == null)
		//  //{
		//  //  this._className = this.GetClassName();
		//  //}
		//  //if (this._stackTrace != null)
		//  //{
		//  //  if (stackTrace == null)
		//  //  {
		//  //    stackTrace = Environment.GetStackTrace(this, true);
		//  //  }
		//  //  if (this._exceptionMethod == null)
		//  //  {
		//  //    RuntimeMethodHandle typicalMethodDefinition = InternalGetMethod(this._stackTrace).GetTypicalMethodDefinition();
		//  //    this._exceptionMethod = RuntimeType.GetMethodBase(typicalMethodDefinition);
		//  //  }
		//  //}
		//  //if (this._source == null)
		//  //{
		//  //  this._source = this.Source;
		//  //}
		//  //info.AddValue("ClassName", this._className, typeof(string));
		//  //info.AddValue("Message", this._message, typeof(string));
		//  //info.AddValue("Data", this._data, typeof(IDictionary));
		//  //info.AddValue("InnerException", this._innerException, typeof(Exception));
		//  //info.AddValue("HelpURL", this._helpURL, typeof(string));
		//  //info.AddValue("StackTraceString", stackTrace, typeof(string));
		//  //info.AddValue("RemoteStackTraceString", this._remoteStackTraceString, typeof(string));
		//  //info.AddValue("RemoteStackIndex", this._remoteStackIndex, typeof(int));
		//  //info.AddValue("ExceptionMethod", this.GetExceptionMethodString(), typeof(string));
		//  //info.AddValue("HResult", this.HResult);
		//  //info.AddValue("Source", this._source, typeof(string));
		//}

 

 

	}

	//[Remotable]
	[JsType(Name = "System.NotImplementedException", Filename = "~/Internal/Core.js")]
	internal class JsImplNotImplementedException : JsImplException
	{
		public JsImplNotImplementedException() : base("NotImplementedException")
		{
		}
		public JsImplNotImplementedException(string s)
			: base("NotImplementedException: "+s)
		{
		}
	}


}
