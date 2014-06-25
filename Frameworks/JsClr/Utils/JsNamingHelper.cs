using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using SharpKit.JavaScript;
using System.Reflection;

namespace SharpKit.JavaScript
{

	[JsType(Filename="~/res/System.Ext.js")]
	static class JsNamingHelper
	{
		public static string JsFunctionNameToClrMethodName(string jsFuncName)
		{
			var methodName = jsFuncName;
			var di = jsFuncName.IndexOf('$');
			if (di > 0)
				methodName = jsFuncName.Substring(0, di);
			return methodName;
		}

		public static string ClrTypeToJsTypeRef(Type type)
		{
			var att = type.GetCustomAttributes(typeof(JsTypeAttribute), false).OfType<JsTypeAttribute>().FirstOrDefault();
			if (att != null && att.Name.IsNotNullOrEmpty())
			{
				return att.Name.Replace('`', '$');
			}
			return type.Namespace+"."+type.Name.Replace('`', '$');
		}
		public static string ClrConstructorToJsFunctionName(ConstructorInfo mi)
		{
			var sb = new StringBuilder();
			var typeRef = ClrTypeToJsTypeRef(mi.DeclaringType);
			sb.Append(typeRef);
			sb.Append(".ctor");
			ConvertParametersToJsFunctionName(mi.GetParameters(), sb);
			return sb.ToString();
		}

		private static void ConvertParametersToJsFunctionName(ParameterInfo[] prms, StringBuilder sb)
		{
			foreach (var prm in prms)
			{
				sb.Append("$$");
				sb.Append(prm.ParameterType.Name);
			}
		}
		public static string ClrMethodBaseToJsFunctionName(MethodBase mi)
		{
			if (mi.MemberType == MemberTypes.Constructor)
			{
				return ClrMethodToJsFunctionName((MethodInfo)mi);
			}
			else if (mi.MemberType == MemberTypes.Method)
			{
				return ClrConstructorToJsFunctionName((ConstructorInfo)mi);
			}
			else
				throw new NotImplementedException();
		}

		public static string ClrMethodToJsFunctionName(MethodInfo mi)
		{
			if (IsPropertySetter(mi)) //IsPropertySetter
			{
				return mi.Name;
			}
			var name = mi.Name;
			var type = mi.DeclaringType;
			if (type.IsGenericType)
			{
				type = type.GetGenericTypeDefinition();
				mi = type.GetMethod(name);
			}
			var sb = new StringBuilder();
			if (mi.IsStatic)
			{
				sb.Append(ClrTypeToJsTypeRef(type));
				var att = type.GetCustomAttributes(typeof(JsTypeAttribute), false).OfType<JsTypeAttribute>().FirstOrDefault();
				if (att == null || att.Mode == JsMode.Clr)
				{
					sb.Append(".staticDefinition.");
				}
				else
				{
					sb.Append(".");
				}
			}
			sb.Append(name);
			ConvertParametersToJsFunctionName(mi.GetParameters(), sb);
			return sb.ToString();
		}

		private static bool IsPropertySetter(MethodInfo mi)
		{
			var name = mi.Name;
			return name.StartsWith("set_") && mi.GetParameters().Length == 1;
		}
	}
}
