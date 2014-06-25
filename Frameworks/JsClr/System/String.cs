using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{
	//[Flags, ComVisible(false)]

	[JsType(Name = "System.StringSplitOptions", Filename = "~/Internal/Core.js")]
	internal enum JsImplStringSplitOptions
	{
		None,
		RemoveEmptyEntries
	}

	//[JsType(Name="System.String")]
	//[RunAtClient]
	//public static class JsImplString
	//{
	//  public static string Join(string separator, string[] values)
	//  {
	//    return values.AsJsArray().join(separator);
	//  }
	//}
}
