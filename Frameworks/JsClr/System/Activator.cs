using System;
using System.Collections.Generic;

using System.Text;
using System.Reflection;
using SharpKit.JavaScript.Compilation;
using System.Globalization;


namespace SharpKit.JavaScript.Private
{


	[JsType(Name = "System.Activator", Filename = "~/Internal/Core.js")]
	internal static class JsImplActivator
	{

		[JsMethod(Code = "return new type._JsType.ctor();")]
		public static object CreateInstance(JsImplType type)
		{
            return JsCompiler.NewByFunc(type._JsType.ctor);
		}
        public static object CreateInstance(JsImplType type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        public static object CreateInstance(JsImplType type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            throw new NotImplementedException();
        }
        public static object CreateInstance(JsImplType type, params object[] args)
        {
            throw new NotImplementedException();
        }
        public static object CreateInstance(JsImplType type, object[] args, object[] activationAttributes)
        {
            throw new NotImplementedException();
        }
        public static object CreateInstance(JsImplType type, bool nonPublic)
        {
            throw new NotImplementedException();
        }
        public static T CreateInstance<T>()
        {
            return CreateInstance(typeof(T).As<JsImplType>()).As<T>();
        }

    }

}
