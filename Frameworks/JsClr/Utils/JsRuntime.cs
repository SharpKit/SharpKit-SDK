using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.JavaScript.Compilation;

namespace SharpKit.Web
{
    /// <summary>
    /// The client side JavaScript .net runtime, loading and running js .net runtime modules and assembies
    /// </summary>
    [JsType(JsMode.Prototype, Filename = "~/Internal/Core.js", Name = "JsRuntime")]
    public class JsRuntime
    {
        /// <summary>
        /// Starts the js runtime, binding all currently included js modules / assemblies (.js files),
        /// this function can be called from javascript using this code:
        /// <code>JsRuntime.Start();</code>
        /// </summary>
        public static void Start()
        {
            JsCompiler.Compile();
        }
    }
}
