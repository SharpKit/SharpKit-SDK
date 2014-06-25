using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Compilation
{
    [JsTypeAttribute(JsMode.Prototype, Name = "JsTypeHelper", Filename = "JsCompiler.js")]
    static class JsTypeHelper
    {

        public static JsType GetTypeIgnoreNamespace(string name, bool throwIfNotFound)
        {
            JsType type;
            var cache = GetTypeIgnoreNamespaceCache;//arguments.callee.cache;
            if (cache != null)
            {
                type = cache[name].As<JsType>();
                if (JsContext.@typeof(type) != "undefined")
                {
                    if (throwIfNotFound && type == null)
                        throw new JsError("type " + name + " was not found with (with IgnoreNamespace).").As<Exception>();
                    return type;
                }
            }
            if (name.As<JsString>().search(".") > -1)
            {
                var tokens = name.As<JsString>().split(".").As<JsArray>();
                name = tokens[tokens.length - 1].As<string>();
            }
            type = JsCompiler.Types[name].As<JsType>();
            var nameAfterNs = "." + name;
            if (type == null)
            {
                foreach (var p in JsCompiler.Types)
                {
                    if (p == name || p.As<JsString>().endsWith(nameAfterNs))
                    {
                        type = JsCompiler.Types[p].As<JsType>();
                        break;
                    }
                }
            }
            if (throwIfNotFound && type == null)
                throw new JsError("type " + name + " was not found with (with IgnoreNamespace).").As<Exception>();
            if (cache != null)
                cache[name] = type ?? null;
            return type;
        }
        static JsObject GetTypeIgnoreNamespaceCache = null;
        public static bool _HasTypeArguments(string typeName)
        {
            return typeName.As<JsString>().indexOf("[") > -1;
        }
        /// <summary>
        /// returns null if no args exist in name.
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="throwIfNotFound"></param>
        /// <returns></returns>
        public static JsArray _GetTypeWithArguments(string typeName, bool throwIfNotFound)
        {
            var name = typeName;
            var gti = name.As<JsString>().indexOf("`");
            if (gti != -1 && name.As<JsString>().indexOf("[") > -1)
            {
                var args = _ParseTypeNameArgs(name);
                if (args == null)
                    return null;
                var type = JsTypeHelper.GetType(args[0].As<string>(), throwIfNotFound);
                if (type == null)
                    return null;
                var res = new object[0].As<JsArray>();
                res.push(type);
                var typeArgs = new object[0].As<JsArray>();
                for (var i = 0; i < args[1].As<JsArray>().length; i++)
                {
                    var typeArg = JsTypeHelper.GetType(args[1].As<JsArray>()[i].As<JsArray>()[0].As<string>(), throwIfNotFound);
                    if (typeArg == null)
                        return null;
                    typeArgs.push(typeArg);
                }
                res.push(typeArgs);
                return res;
            }
            return null;
        }
        [JsMethod(Code = @"	var code = name.replace(/, [a-zA-Z0-9, =.]+\]/g, ']'); //remove all the ', mscorlib, Version=1.0.0.0, publicKeyToken=xxxxxxxxx
	code = code.replace(/`([0-9])/g, '$$$1,'); //remove the `2 and replace to $2, (the comma is for array to compile)
	code = '[' + code + ']';
try
{
	var args = eval(code);
return args;
}
catch(e)
{
  //ERROR
  return null;
}
	")]
        private static JsArray _ParseTypeNameArgs(string name)
        {
            throw new NotImplementedException();

        }
        [JsMethod(Export = false, NativeOverloads = true)]
        public static JsType GetType(object typeOrNameOrCtor)
        {
            throw new NotImplementedException();
        }
        public static JsType GetType(object typeOrNameOrCtor, bool throwIfNotFound)
        {
            if (JsContext.@typeof(typeOrNameOrCtor) != "string")
            {
                if (JsContext.@typeof(typeOrNameOrCtor) == "function")
                    return typeOrNameOrCtor.As<JsCompilerFunction>()._type;
                return typeOrNameOrCtor.As<JsType>();
            }
            var name = typeOrNameOrCtor.As<JsString>();
            var gti = name.As<JsString>().indexOf("`");
            if (gti != -1)
            {
                name = name.As<JsString>().substr(0, gti + 2).As<JsString>().replace("`", "$");
            }
            var type = JsCompiler.Types[name].As<JsType>();
            if (type == null)
            {
                if (throwIfNotFound)
                    throw new JsError("JsType " + name + " was not found").As<Exception>();
                return null;
            }
            return type;
        }
        public static JsType FindType(string name, bool throwIfNotFound)
        {
            var type = GetType(name, false);
            if (type == null)
                type = GetTypeIgnoreNamespace(name, throwIfNotFound);
            return type;
        }
        public static string GetAssemblyQualifiedName(this JsType type)
        {
            if (type._AssemblyQualifiedName == null)
            {
                var name = type.fullname;
                if (type.assemblyName != null)
                    name += ", " + type.assemblyName;
                type._AssemblyQualifiedName = name;
            }
            return type._AssemblyQualifiedName;
        }
        public static string GetName(this JsType type)
        {
            return type.name;
        }
        public static JsString getMemberTypeName(JsObject instance, JsString memberName)
        {
            var signature = instance[memberName + "$$"].As<JsString>();
            if (signature == null)
                return null;
            var tokens = signature.split(" ");
            var memberTypeName = tokens[tokens.length - 1];
            return memberTypeName;
        }
        public static JsFunction GetDelegate(object obj, JsFunction func)
        {
            var target = obj.As<JsCompilerObject>();
            if (target == null)
                return func;
            if (JsContext.@typeof(func) == "string")
                func = target.As<JsObject>()[func.As<JsString>()].As<JsFunction>();
            var cache = target.__delegateCache;
            if (cache == null)
            {
                cache = new JsObject<JsDelegateFunction>();
                target.__delegateCache = cache;
            }
            var key = JsCompiler.GetHashKey(func);
            var del = cache[key];
            if (del == null)
            {
                del = new JsNativeFunc<object>(delegate()
                {
                    var del2 = JsContext.arguments.callee.As<JsDelegateFunction>();
                    return del2.func.apply(del.target, JsContext.arguments.As<object[]>());
                }).As<JsDelegateFunction>();
                del.func = func;
                del.target = target;
                del.isDelegate = true;
                cache[key] = del;
            }
            return del;
        }

    }
}
