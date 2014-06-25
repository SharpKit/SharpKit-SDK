using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Environment", Filename = "~/Internal/Core.js")]
	class JsImplEnvironment
	{
		internal static string GetResourceString(string p)
		{
			return p;
		}

        public static int TickCount { get { return new JsDate().valueOf(); } }

    }

}
