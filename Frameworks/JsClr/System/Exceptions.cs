using System;
using System.Collections.Generic;

using System.Text;

using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Globalization;

namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.SystemException", Filename = "~/Internal/Core.js")]
	internal class JsImplSystemException : JsImplException
	{
		// Methods
		public JsImplSystemException()
			: base(JsImplEnvironment.GetResourceString("Arg_SystemException"))
		{
			SetErrorCode(-2146233087);
		}

		public JsImplSystemException(string message)
			: base(message)
		{
			SetErrorCode(-2146233087);
		}

		//protected JsImplSystemException(SerializationInfo info, StreamingContext context)
		//  : base(info, context)
		//{
		//}

		public JsImplSystemException(string message, Exception innerException)
			: base(message, innerException)
		{
			SetErrorCode(-2146233087);
		}
	}


	[JsType(Name = "System.ArgumentException", Filename = "~/Internal/Core.js")]
	internal class JsImplArgumentException : JsImplSystemException
	{
		// Fields
		private string m_paramName;

		// Methods
		public JsImplArgumentException()
			: base(JsImplEnvironment.GetResourceString("Arg_ArgumentException"))
		{
			SetErrorCode(-2147024809);
		}

		public JsImplArgumentException(string message)
			: base(message)
		{
			SetErrorCode(-2147024809);
		}

		//protected JsImplArgumentException(SerializationInfo info, StreamingContext context)
		//  : base(info, context)
		//{
		//  this.m_paramName = info.GetString("ParamName");
		//}

		public JsImplArgumentException(string message, Exception innerException)
			: base(message, innerException)
		{
			//SetErrorCode(-2147024809);
		}

		public JsImplArgumentException(string message, string paramName)
			: base(message)
		{
			this.m_paramName = paramName;
			SetErrorCode(-2147024809);
		}

		public JsImplArgumentException(string message, string paramName, Exception innerException)
			: base(message, innerException)
		{
			this.m_paramName = paramName;
			SetErrorCode(-2147024809);
		}

		//[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		//public override void GetObjectData(SerializationInfo info, StreamingContext context)
		//{
		//  if (info == null)
		//  {
		//    throw new ArgumentNullException("info");
		//  }
		//  base.GetObjectData(info, context);
		//  info.AddValue("ParamName", this.m_paramName, typeof(string));
		//}

		////TODO: base properties to not work in js
		//public override string Message
		//{
		//  get
		//  {
		//    string message = base.Message;
		//    if ((this.m_paramName != null) && (this.m_paramName.Length != 0))
		//    {
		//      return (message + Environment.NewLine + string.Format(CultureInfo.CurrentCulture, JsImplEnvironment.GetResourceString("Arg_ParamName_Name"), new object[] { this.m_paramName }));
		//    }
		//    return message;
		//  }
		//}

		public virtual string ParamName
		{
			get
			{
				return this.m_paramName;
			}
		}
	}


	[JsType(Name = "System.NullReferenceException", Filename = "~/Internal/Core.js")]
	internal class JsImplNullReferenceException : JsImplSystemException
	{
		public JsImplNullReferenceException()
			: base("Object reference not set to an instance of object")
		{
		}
		public JsImplNullReferenceException(string message)
			: base(message)
		{
		}
	}


	/// <summary>The exception that is thrown when an invoked method is not supported, or when there is an attempt to read, seek, or write to a stream that does not support the invoked functionality.</summary>
	/// <filterpriority>2</filterpriority>
	//[Serializable, ComVisible(true)]

	[JsType(Name = "System.NotSupportedException", Filename = "~/Internal/Core.js")]
	internal class JsImplNotSupportedException : JsImplSystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error. This message takes into account the current system culture.</summary>
		public JsImplNotSupportedException()
			: base("Arg_NotSupportedException")
		{
			//SetErrorCode(-2146233067);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		public JsImplNotSupportedException(string message)
			: base(message)
		{
			//SetErrorCode(-2146233067);
		}

		///// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class with serialized data.</summary>
		///// <param name="info">The object that holds the serialized object data. </param>
		///// <param name="context">The contextual information about the source or destination. </param>
		//protected JsImplNotSupportedException(SerializationInfo info, StreamingContext context)
		//  : base(info, context)
		//{
		//}

		/// <summary>Initializes a new instance of the <see cref="T:System.NotSupportedException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception. </param>
		public JsImplNotSupportedException(string message, Exception innerException)
			: base(message, innerException)
		{
			//SetErrorCode(-2146233067);
		}
	}



	[JsType(Name = "System.ArgumentOutOfRangeException", Filename = "~/Internal/Core.js")]
	internal class JsImplArgumentOutOfRangeException : JsImplArgumentException//, ISerializable
	{
		// Fields
		private static string _rangeMessage;
		private object m_actualValue;

		// Methods
		public JsImplArgumentOutOfRangeException()
			: base("Arg_ArgumentOutOfRangeException")
		{
			SetErrorCode(-2146233086);
		}

		public JsImplArgumentOutOfRangeException(string paramName)
			: base("Arg_ArgumentOutOfRangeException", paramName)
		{
			SetErrorCode(-2146233086);
		}

		//protected JsImplArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
		//  : base(info, context)
		//{
		//  this.m_actualValue = info.GetValue("ActualValue", typeof(object));
		//}

		public JsImplArgumentOutOfRangeException(string message, Exception innerException)
			: base(message, innerException)
		{
			SetErrorCode(-2146233086);
		}

		public JsImplArgumentOutOfRangeException(string paramName, string message)
			: base(message, paramName)
		{
			SetErrorCode(-2146233086);
		}

		public JsImplArgumentOutOfRangeException(string paramName, object actualValue, string message)
			: base(message, paramName)
		{
			this.m_actualValue = actualValue;
			SetErrorCode(-2146233086);
		}

		//[SecurityPermission(SecurityAction.LinkDemand, Flags=SecurityPermissionFlag.SerializationFormatter)]
		//public override void GetObjectData(SerializationInfo info, StreamingContext context)
		//{
		//    if (info == null)
		//    {
		//        throw new ArgumentNullException("info");
		//    }
		//    base.GetObjectData(info, context);
		//    info.AddValue("ActualValue", this.m_actualValue, typeof(object));
		//}

		// Properties
		public virtual object ActualValue
		{
			get
			{
				return this.m_actualValue;
			}
		}

		////TODO: base properties to not work in js
		//public override string Message
		//{
		//  get
		//  {
		//    string message = base.Message;
		//    if (this.m_actualValue == null)
		//    {
		//      return message;
		//    }
		//    string str2 = string.Format("ArgumentOutOfRange_ActualValue {0}", this.m_actualValue.ToString());
		//    if (message == null)
		//    {
		//      return str2;
		//    }
		//    return (message + Environment.NewLine + str2);
		//  }
		//}

		private string RangeMessage
		{
			get
			{
				if (_rangeMessage == null)
				{
					_rangeMessage = "Arg_ArgumentOutOfRangeException";// Environment.GetResourceString(
				}
				return _rangeMessage;
			}
		}
	}





}
