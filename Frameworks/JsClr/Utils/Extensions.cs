using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using System.Globalization;
using System.Configuration;
using System.Reflection;
using System.IO;
using System.Diagnostics;



[JsType(Name = "SharpKit.Html4.HtmlDomEventHandler", Filename="~/Internal/Core.js")]
internal delegate void JsImplHtmlDomEventHandler(object e);

namespace SharpKit
{

    [JsType(JsMode.Prototype, Name = "Array", OmitDefaultConstructor = true, NativeOverloads = false)]
    class JsArrayExtensions<T> : JsArray<T>
    {
        public T this[int index]
        {
            get { return this.As<JsArray<T>>()[index]; }
            set { this.As<JsArray<T>>()[index] = value; }
        }
    }


	[JsType(Filename="~/res/System.Ext.js")]
	internal static class PropertyInfoExtensions
	{
		[JsMethod(Code = "return pi._IsStatic;")]
		public static bool IsStatic(this PropertyInfo pi)
		{
			return pi.GetAccessors()[0].IsStatic;
		}
		[JsMethod(Code = "throw new Error('Not Implemented');")]
		public static bool IsPublic(this PropertyInfo pi)
		{
			return (pi.GetAccessors()[0].Attributes & MethodAttributes.Public) == MethodAttributes.Public;
		}

	}

	public static class ArrayExtensions
	{
		[JsMethod(Code = "return array==null || array.length==0;")]
		public static bool IsNullOrEmpty(this Array array)
		{
			return array == null || array.Length == 0;
		}

		[JsMethod(Code = "return array!=null && array.length>0;")]
		public static bool IsNotNullOrEmpty(this Array array)
		{
			return array != null && array.Length > 0;
		}
	}

	[JsType(Filename="~/res/System.Ext.js")]
	public static class Extensions2
	{
        [JsMethod(Export = false, ExtensionImplementedInInstance=true, NativeOverloads=true)]
        public static bool startsWith(this JsString s, JsString s2)
        {
            return false;
        }
        [JsMethod(Export = false, ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static bool endsWith(this JsString s, JsString s2)
        {
            return false;
        }

		[JsMethod(Code = "if(s==null || s.length==0) return defaultValue; return s;")]
		public static string GetValueOrDefaultIfNullOrEmpty(this string s, string defaultValue)
		{
			if (s == null || s.Length == 0)
				return defaultValue;
			return s;
		}

		[JsMethod(Export = false)]
		public static bool IsNullOrEmpty(this string s)
		{
			return s == null || s.Length == 0;
		}

		[JsMethod(Export = false)]
		public static bool IsNotNullOrEmpty(this string s)
		{
			return s != null && s.Length > 0;
		}

		public static bool IsNullOrEmpty(this JsString s)
		{
			return s == null || s.length == 0;
		}

		public static bool IsNotNullOrEmpty(this JsString s)
		{
			return s != null && s.length > 0;
		}

		public static string HtmlEscape(this string s)
		{
			return s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\n", "<br/>");
		}

		[JsMethod(Code = "return s.ReplaceFirst(search, replace);")]
		public static string ReplaceFirst(this string s, string search, string replace)
		{
			return ReplaceFirst(s, search, replace, StringComparison.CurrentCulture);
		}
		public static string ReplaceFirst(this string s, string search, string replace, StringComparison comparisonType)
		{
			int index = s.IndexOf(search, comparisonType);
			if (index != -1)
			{
				string finalStr = String.Concat(s.Substring(0, index), replace, s.Substring(search.Length + index));
				return finalStr;
			}
			return s;
		}

		public static string FixCamelCasing(this string s)
		{
			StringBuilder sb = new StringBuilder();
			bool first = true;
			foreach (char c in s)
			{
				if (Char.IsUpper(c) && !first)
				{
					sb.Append(' ');
				}
				sb.Append(c);
				first = false;
			}
			return sb.ToString();
		}

		[JsMethod(Code = "return s.substr(s, s.length-count);")]
		public static string RemoveLast(this string s, int count)
		{
			return s.Substring(0, s.Length - count);
		}

		public static string TrimEnd(this string s, string trimText)
		{
			if (s.EndsWith(trimText))
				return RemoveLast(s, trimText.Length);
			return s;
		}



		public static bool EqualsIgnoreCase(this string s1, string s2)
		{
			return String.Compare(s1, s2, true) == 0;
		}
	}

}

