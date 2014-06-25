using System;
using System.Collections.Generic;

using System.Text;

using SharpKit.JavaScript.Compilation;

namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Delegate", Filename = "~/Internal/Core.js")]
	internal abstract class JsImplDelegate
	{
        public static JsImplDelegate Combine(params JsImplDelegate[] delegates)
        {
            throw new NotImplementedException();
        }

		public static JsImplDelegate Combine(JsImplDelegate delegate1, JsImplDelegate delegate2)
		{
            return JsCompiler.CombineDelegates(delegate1.As<JsDelegateFunction>(), delegate2.As<JsDelegateFunction>()).As<JsImplDelegate>();
        }
        public static JsImplDelegate Remove(JsImplDelegate delegate1, JsImplDelegate delegate2)
        {
            return JsCompiler.RemoveDelegate(delegate1.As<JsDelegateFunction>(), delegate2.As<JsDelegateFunction>()).As<JsImplDelegate>();
        }

		public object DynamicInvoke(params object[] args)
		{
            throw new NotImplementedException();
        }

	}



	[JsType(Name = "System.MulticastDelegate", Filename = "~/Internal/Core.js")]
	internal class JsImplMulticastDelegate : JsImplDelegate
	{
		public JsImplDelegate[] GetInvocationList()
		{
            throw new NotImplementedException();
		}


		public bool Equals(JsImplMulticastDelegate del)
		{
            throw new NotImplementedException();
            //if(del==null)
            //    return false;
            //if(this==del)
            //    return true;
            //if (obj == del.obj && func == del.func)
            //{
            //    if ((delegates == null || delegates.length == 0))
            //        return del.delegates == null || del.delegates.length == 0;
            //    if (del.delegates == null || del.delegates.length == 0)
            //        return false;
            //    if (delegates.length != del.delegates.length)
            //        return false;
            //    for (var i = 0; i < delegates.length; i++)
            //    {
            //        if (!delegates[i].Equals(del.delegates[i]))
            //            return false;
            //    }
            //    return true;
            //}
            //return false;
		}

        public object Invoke(params object[] varargs)
		{
			throw new NotImplementedException();
		}


	}

}
