using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

    [JsType(Name = "System.Diagnostics.Trace", Filename = "~/res/System.Diagnostics.js")]
	internal static class JsImplTrace
	{
		static List<string> Warnings;
		static bool Enabled=false; //TODO:
		public static void TraceWarning(string msg)
		{
			if (!Enabled)
				return;
			if (Warnings == null)
				Warnings = new List<string>();
			Warnings.Add(msg);
		}

		public static void TraceWarning(string format, params object[] args)
		{
			if (!Enabled)
				return;
			TraceWarning(String.Format(format, args));
		}

	}
}
