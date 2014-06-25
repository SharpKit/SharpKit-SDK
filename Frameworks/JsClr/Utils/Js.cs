using System;

using SharpKit.JavaScript.Private;
using SharpKit.JavaScript.Compilation;

namespace SharpKit.JavaScript.Utils
{
	/// <summary>
	/// TODO: Inline all method implementations!!!
	/// </summary>
	[JsType(Filename="~/res/System.Ext.js")]
	public static class Js
	{
		[JsMethod(Code = "return escape(s);")]
		public static string escape(string s)
		{
			throw new NotImplementedException("TODO: Implement");
		}

        //[JsMethod(Code="return del._ToJsFunction();")]
        //public static JsFunction ToJsFunction(this MulticastDelegate del)
        //{
        //    throw new NotImplementedException("TODO: Implement");
        //}

		public static object undefined;
		[JsMethod(Code = "return obj==value;")]
		public static bool JsEquals(this object obj, object value)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(Code = "return obj===undefined;")]
		public static bool JsExactEqualsToUndefined(this object obj)
		{
			throw new NotImplementedException("TODO: Implement");
		}
	
		[JsMethod(Code = "return obj===value;")]
		public static bool JsExactEquals(this object obj, object value)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(Code = "return typeof(obj);")]
		public static string Typeof(object obj)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		public static object ApplyFunction(object func, object thisArg, object[] prms)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		public static object CallFunction(object func, object thisArg, params object[] prms)
		{
			throw new NotImplementedException("TODO: Implement");
		}

		[JsMethod(Code = "return obj[funcName].apply(obj, Arguments.from(arguments, 2));")]
		public static object CallFunction2(object obj, string funcName, params object[] prms)
		{
			throw new NotImplementedException("TODO: Implement");
		}
        ////[JsMethod(Code = "return new System.MulticastDelegate.ctor$$Object$$Function(obj, func);")]
        //public static object CreateDelegate(object obj, JsFunction func)
        //{
        //    return new JsImplMulticastDelegate(obj.As<JsObject>(), func);
        //}

        ////[JsMethod(Code = "if(obj==null || funcName==null || obj[funcName]==null) throw new Error('CreateInstanceDelegate error'); return new System.MulticastDelegate.ctor(obj, obj[funcName]);")]
        //public static object CreateInstanceDelegate(object obj, string funcName)
        //{
        //    var jsObj = obj.As<JsObject>();
        //    if(jsObj==null || funcName==null || jsObj[funcName]==null) 
        //        throw new Exception("CreateInstanceDelegate error");
        //    return new JsImplMulticastDelegate(jsObj, jsObj[funcName].As<JsFunction>());
        //}

        //public static object CreateInstanceDelegate(object obj, string funcName, bool findOverloadedMethod)
        //{
        //    var jsObj = obj.As<JsObject>();
        //    if (jsObj == null || funcName == null)
        //        throw new Exception("CreateInstanceDelegate error");
        //    if (jsObj[funcName] == null && findOverloadedMethod)
        //    {
        //        var overloadedFuncName = FindOverloadedMethodName(obj, funcName);
        //        if (overloadedFuncName == null)
        //            throw new Exception("CreateInstanceDelegate error");
        //        else
        //            funcName = overloadedFuncName;
        //    }
        //    if(jsObj[funcName] == null)
        //        throw new Exception("CreateInstanceDelegate error");
        //    return new JsImplMulticastDelegate(jsObj, jsObj[funcName].As<JsFunction>());
        //}

		[JsMethod(Code=@"funcName+='$$';for(var o in obj)
if (typeof(obj[o])=='function' && o.indexOf(funcName)==0) 
	return o; 
return null;")]
		static string FindOverloadedMethodName(object obj, string funcName)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code="eval(code)")]
		public static object Eval(string code)
		{
			throw new NotImplementedException();
		}

		public static void Compile()
		{
			throw new NotImplementedException();
		}

		public static string GetHashKey(object key)
		{
            return JsCompiler.GetHashKey(key);
        }

		[JsMethod(Code = "delete obj[name];")]
		public static void DeleteMember(object obj, string name)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code = "return parseFloat(s);")]
		public static JsNumber parseFloat(string s)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code = "return parseInt(s);")]
		public static JsNumber parseInt(string s)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code="if(prms==null || prms.length==0) return new jsCtor(); return new jsCtor(prms[0], prms[1], prms[2], prms[3], prms[4], prms[5], prms[6], prms[7], prms[8]);")]//TODO: switch by prm number
		internal static object ApplyNew(JsFunction jsCtor, JsArray prms)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code = "return obj instanceof Array;")]
		public static bool IsArray(object obj)
		{
			throw new NotImplementedException();
		}

		[JsMethod(Code = "return isNaN(obj);")]
		public static bool isNaN(object obj)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
		/// </summary>
		/// <param name="encodedURIString"></param>
		/// <returns>The required encodedURIString argument is a value representing an encoded URI component.A URIComponent is part of a complete URI. If the encodedURIString is not valid, a URIError occurs. 
		/// </returns>
		[JsMethod(Code = "return decodeURIComponent(encodedURIString)")]
		public static string decodeURIComponent(string encodedURIString)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Encodes a text string as a valid component of a Uniform Resource Identifier (URI). 
		/// </summary>
		/// <param name="encodedURIString"></param>
		/// <returns></returns>
		[JsMethod(Code = "return encodeURIComponent(encodedURIString)")]
		public static string encodeURIComponent(string encodedURIString)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Encodes a text string as a valid Uniform Resource Identifier (URI) 
		/// </summary>
		/// <param name="URIString"></param>
		/// <returns></returns>
		[JsMethod(Code = "return encodeURI(URIString)")]
		public static string encodeURI(string URIString)
		{
			throw new NotImplementedException(" ");
		}

		/// <summary>
		/// Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
		/// </summary>
		/// <param name="URIString"></param>
		/// <returns></returns>
		[JsMethod(Code = "return decodeURI(URIString)")]
		public static string decodeURI(string URIString)
		{
			throw new NotImplementedException(" ");
		}



		[JsMethod(Code = "return unescape(s)", NativeOverloads = true)]
		public static string unescape(string s)
		{
			throw new NotImplementedException();
		}
	}
}
