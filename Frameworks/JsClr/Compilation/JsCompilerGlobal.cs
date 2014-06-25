using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript.Private;

namespace SharpKit.JavaScript.Compilation
{

    [JsType(JsMode.Global, Filename = "JsCompiler.js", OrderInFile = -1)]
    public class JsCompilerGlobal : BrowserContext
    {
        internal static JsDelegateFunction RemoveDelegate(JsDelegateFunction delOriginal, JsDelegateFunction delToRemove)
        {
            if (delToRemove == null || delOriginal == null)
                return delOriginal;

            if (delOriginal.isMulticastDelegate)
            {
                if (delToRemove.isMulticastDelegate)
                    throw new NotImplementedException("Multicast to multicast delegate removal is not implemented yet");
                var del = CreateMulticastDelegateFunction();
                for (var i = 0; i < delOriginal.delegates.length; i++)
                {
                    var del2 = delOriginal.delegates[i];
                    if (del2 != delToRemove)
                    {
                        if (del.delegates == null)
                            del.delegates = new JsArray<JsDelegateFunction>();
                        del.delegates.push(del2);
                    }
                }
                if (del.delegates == null)
                    return null;
                //del.delegates = delOriginal.delegates.splice(0, 0);//clone
                if (del.delegates.length == 1)
                    return del.delegates[0];
                return del;
            }
            else
            {
                if (delToRemove.isMulticastDelegate)
                    throw new NotImplementedException("single to multicast delegate removal is not supported");
                if (delOriginal == delToRemove)
                    return null;
                return delOriginal;
            }
        }

        internal static JsDelegateFunction CombineDelegates(JsDelegateFunction del1, JsDelegateFunction del2)
        {
            if (del1 == null)
                return del2;
            if (del2 == null)
                return del1;
            var del = CreateMulticastDelegateFunction();
            del.delegates = new JsArray<JsDelegateFunction>();
            if (del1.isMulticastDelegate)
            {
                for (var i = 0; i < del1.delegates.length; i++)
                    del.delegates.push(del1.delegates[i]);
            }
            else
            {
                del.delegates.push(del1);
            }
            if (del2.isMulticastDelegate)
            {
                for (var i = 0; i < del2.delegates.length; i++)
                    del.delegates.push(del2.delegates[i]);
            }
            else
            {
                del.delegates.push(del2);
            }
            return del;
        }
        static JsDelegateFunction CreateMulticastDelegateFunction()
        {

            JsDelegateFunction del2 = null;

            var del = new JsNativeFunc<object>(delegate()
            {
                var x = undefined;
                for (var i = 0; i < del2.delegates.length; i++)
                {
                    var del3 = del2.delegates[i];
                    x = del3.apply(null, arguments.As<object[]>());
                }
                return x;
            }).As<JsDelegateFunction>();
            del.isMulticastDelegate = true;

            del2 = del;

            return del;
        }
        internal static JsDelegateFunction CreateClrDelegate(JsType type, JsArray<JsType> genericArgs, object target, JsFunction func)
        {
            return JsTypeHelper.GetDelegate(target, func).As<JsDelegateFunction>(); //TODO: support delegate.getType()
        }


        [JsProperty(Export = false, NativeField = true)]//avoid initialization to null
        public static JsArray<JsType> JsTypes { get; set; }

        private static JsImplType Typeof(object jsTypeOrName)
        {
            if (jsTypeOrName == null)
                throw new JsError("Unknown type.").As<Exception>();
            if (JsTypeOf(jsTypeOrName) == JavaScript.JsTypes.function)
            {
                jsTypeOrName = JsTypeHelper.GetType(jsTypeOrName);
            }
            if (JsTypeOf(jsTypeOrName) == JavaScript.JsTypes.@string)
                return JsImplType.GetType(jsTypeOrName.As<string>(), true);
            return JsImplType._TypeOf(jsTypeOrName.As<JsType>());
        }

        private static JsType JsTypeof(string typeName)
        {
            return JsTypeHelper.GetType(typeName, false);
        }
        private static object New(string typeName, JsArray args)
        {
            //TODO:
            var type = JsTypeHelper.GetType(typeName, true);
            if (args == null || args.length == 0)
            {
                var obj = JsCompiler.NewByFunc(type.ctor);
                return obj;
            }
            else
            {
                var obj = JsCompiler.NewByFuncArgs(type.ctor, args);
                return obj;
            }
        }
        private static object NewWithInitializer(JsType type, JsObject json)
        {
            var obj = JsCompiler.NewByFunc(type.ctor);
            if (@typeof(json) == "array")
            {
                throw new Exception("not implemented");
            }
            else
            {
                foreach (var p in json)
                {
                    var setter = obj.As<JsObject>()["set_" + p];
                    if (@typeof(setter) == "function")
                        setter.As<JsFunction>().call(obj, json[p]);
                    else
                        obj.As<JsObject>()[p] = json[p];
                }
            }
            return obj;
        }

        private static object As(object obj, string typeOrName)
        {
            if (obj == null)
                return obj;
            var type = JsTypeHelper.GetType(typeOrName, true);
            if (Is(obj, type))
                return obj;
            return null;
        }

        private static object Cast(object obj, string typeOrName)
        {
            if (obj == null)
                return obj;
            var type = JsTypeHelper.GetType(typeOrName, true);
            if (Is(obj, type))
                return obj;
            var converted = TryImplicitConvert(obj, type);
            if (converted != null)
                return converted;
            var objTypeName = JsContext.@typeof(obj);
            if (JsContext.@typeof(obj.As<JsCompilerObject>().getTypeName) == "function")
            {
                objTypeName = obj.As<JsCompilerObject2>().getTypeName();
            }
            var msg = new JsArray("InvalidCastException: Cannot cast ", objTypeName, " to ", type.fullname, "Exception generated by JsRuntime").join("");
            throw new JsError(msg).As<Exception>();
        }


        static bool _TestTypeInterfacesIs(JsType testType, JsType iface, JsObject testedInterfaces)
        {
            if (testedInterfaces[iface.name].As<bool>())
                return false;
            for (var i = 0; i < testType.interfaces.length; i++)
            {
                var testIface = testType.interfaces[i].As<JsType>();
                if (testIface == iface)
                    return true;
                testedInterfaces[testIface.name] = true;
                if (_TestTypeInterfacesIs(testIface, iface, testedInterfaces))
                    return true;
            }
            return false;
        }

        //checkes if the [objType] is of a certain [type]
        static bool TypeIs(JsType objType, JsType type)
        {
            if (objType == type)
                return true;
            if (type.Kind == JsTypeKind.Interface)
            {
                var testedInterfaces = new JsObject();
                while (objType != null)
                {
                    if (objType == type)
                        return true;
                    if (_TestTypeInterfacesIs(objType, type, testedInterfaces))
                        return true;
                    objType = objType.baseType;
                }
                return false;
            }
            if (type.Kind == JsTypeKind.Delegate && objType.fullname == "System.Delegate")
            {
                //for now, casting between any delegate type is permitted
                return true;
            }
            if (objType.fullname == "System.Int32")
            {
                if (type.fullname == "System.Decimal")
                    return true;
                if (type.fullname == "System.Double")
                    return true;
                if (type.fullname == "System.Single")
                    return true;
            }
            var t = objType.baseType;
            while (t != null)
            {
                if (t == type)
                    return true;
                t = t.baseType;
            }
            return false;
        }

        static bool Is(object obj, object typeOrName)
        {
            //Profiler.Data.push([1, new Date().getTime(), false, 1]);
            if (obj == null)
            {
                //Profiler.Data.push([1, new Date().getTime(), true, 1]);
                return false;
            }
            var type = JsTypeHelper.GetType(typeOrName.As<string>(), true);
            //var type = typeCtor._type;
            if (type == null)
            {
                if (type == null && JsTypeOf(typeOrName) == JavaScript.JsTypes.function)
                {
                    var ctor = typeOrName.As<JsFunction>();
                    var i = 0;
                    while (ctor != null && i < 20) //avoid circular base types (infinite loop)
                    {
                        if (obj.instanceof(ctor))
                            return true;
                        ctor = ctor.As<JsObject>()["$baseCtor"].As<JsFunction>();
                        i++;
                    }
                    return false;
                }
                throw new JsError("type expected").As<Exception>();
            }
            var objType = GetObjectType(obj);
            if (objType == null) return false;
            var isIt = TypeIs(objType, type);
            //Profiler.Data.push([1, new Date().getTime(), true, 1]);
            return isIt;
        }

        public static object Default(object T)
        {
            //TODO:
            return null;
        }

        [JsMethod(NativeOverloads = true, Code = @"	var objType;	
	if(
			obj.constructor==null ||  //IE
			obj instanceof Node || //FireFox
			obj.constructor==HTMLImageElement || obj.constructor==HTMLInputElement ||								//IE & Firefox
			obj.constructor.name=='HTMLImageElement' || obj.constructor.name=='HTMLInputElement' 		//IE & Safari
		 )
	{
		var objTypeName = SharpKit.Html4.HtmlDom.GetTypeNameFromHtmlNode(obj);
		if(objTypeName==null)
			throw new Error();
		objType = JsTypeHelper.GetType(objTypeName, true);
	}
	else
	{
		objType = obj.constructor._type;
	}
	return objType === undefined ? null : objType;
")]
        static JsType GetObjectType(object obj)
        {
            throw new NotImplementedException();
        }

        [JsMethod(NativeOverloads = true, Code = @"	if (obj instanceof Error)
	{
		if (obj._Exception != null)
		{
			if(Is(obj._Exception, type))
				return obj._Exception;
			else
				return null;
		}
		else if (type.get_FullName() == 'System.Exception')
		{
			obj._Exception = new Exception(obj.message);
			return obj._Exception;
		}
	}
	return null;")]
        private static object TryImplicitConvert(object obj, JsType type)
        {
            throw new NotImplementedException();
        }

        public static void Compile()
        {
            JsCompiler.Compile_Direct();
        }

        protected static JsArray<JsAction> AfterCompilationFunctions = new JsArray<JsAction>();
        public static void AfterCompilation(JsAction func)
        {
            if (IsCompiled)
                func();
            else
                AfterCompilationFunctions.push(func);
        }
        public static void AfterNextCompilation(JsAction func)
        {
            AfterCompilationFunctions.push(func);
        }

        protected static JsArray<JsAction> BeforeCompilationFunctions = new JsArray<JsAction>();
        public static void BeforeCompilation(JsAction func)
        {
            BeforeCompilationFunctions.push(func);
        }
        public static bool IsCompiled = false;

    }
}
