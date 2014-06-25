using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{



	[JsType(Name = "System.Reflection.MemberInfo", Filename = "~/res/System.Reflection.js")]
	internal abstract class JsImplMemberInfo
	{
		internal string _Name;
		public virtual string Name
		{
			get { return _Name; }
		}

		internal JsImplType _DeclaringType;
		public JsImplType DeclaringType
		{
			get
			{
				return _DeclaringType;
			}
		}


		protected virtual void VerifyCustomAttributes()
		{
			DeclaringType.VerifyCustomAttributesOnTypeAndMembers();
		}

		/// <summary>
		/// Returns the base member for custom attribute inheritance
		/// </summary>
		/// <returns></returns>
		protected virtual JsImplMemberInfo GetBaseMember()
		{
			return null;//TODO: implement for MethodInfo, EventInfo as needed.
		}

		private void AddCustomAttributes(List<object> list, JsImplType attributeType, bool inherit)
		{
			VerifyCustomAttributes();
			if (_CustomAttributes != null)
			{
				for (var i = 0; i < _CustomAttributes.length; i++)
				{
					var att = _CustomAttributes[i];
					if (attributeType.IsInstanceOfType(att))
						list.Add(att);
				}
			}
			if (inherit)
			{
				var bm = GetBaseMember();
				if (bm != null)
					bm.AddCustomAttributes(list, attributeType, inherit);
			}
		}

		public object[] GetCustomAttributes(JsImplType attributeType, bool inherit)
		{
			var list = new List<object>();
			AddCustomAttributes(list, attributeType, inherit);
			return list.ToArray();
		}

		public object[] GetCustomAttributes(bool inherit)
		{
			if (inherit)
				throw new NotImplementedException("GetCustomAttributes with inherit=true is not implemented");
			VerifyCustomAttributes();
			return _CustomAttributes.As<object[]>();
		}

		internal JsExtendedArray _CustomAttributes;

	}


	[JsType(Name = "System.Reflection.MethodBase", Filename = "~/res/System.Reflection.js")]
	internal abstract class JsImplMethodBase : JsImplMemberInfo
	{
		public abstract object Invoke(object obj, object[] parameters);
	}


	[JsType(Name = "System.Reflection.MethodInfo", Filename = "~/res/System.Reflection.js")]
	internal class JsImplMethodInfo : JsImplMethodBase
	{
		internal bool _IsStatic;

        public bool IsStatic { get { return _IsStatic; } }
		public override object Invoke(object obj, object[] parameters)
		{
			JsFunction func;
			if (_IsStatic)
				func = JsFunction;
			else
			{
				if (obj == null)
					throw new Exception("Cannot invoke non static method without a target object");
				func = obj.As<JsObject>()[JsName].As<JsFunction>();//to support runtime overrides (as in .net)
			}
			object res;
			if (parameters == null)
				res = func.apply(obj);
			else
				res = func.apply(obj, parameters);
			return res;
		}
		internal JsFunction JsFunction=null;
		internal string JsName=null;

	}
}
