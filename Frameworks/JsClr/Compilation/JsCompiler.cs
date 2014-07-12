using System;

using SharpKit.JavaScript.Private;

namespace SharpKit.JavaScript.Compilation
{
        


    [JsType(JsMode.Prototype, Name = "JsCompiler", Filename = "JsCompiler.js")]
    public class JsCompiler : JsCompilerGlobal
    {

        internal static void Compile_Direct()
        {
            Compile_Phase1();
            Compile_Phase2();
            Compile_Phase3();
        }
        private static void Compile_Phase1()
        {
            foreach (var action in BeforeCompilationFunctions)
                action();
            BeforeCompilationFunctions = new JsArray<JsAction>();
            foreach (var jsType in JsTypes)
            {
                var fullName = jsType.fullname;
                var type = Types[fullName].As<JsType>();
                if (type == null)
                {
                    Types[fullName] = jsType;
                }
                else
                {
                    jsType.isPartial = true;
                    jsType.realType = type;
                }
                if (jsType.derivedTypes == null)
                    jsType.derivedTypes = new JsArray<JsType>();
                if (jsType.interfaces == null)
                    jsType.interfaces = new JsArray<JsType>();
                if (jsType.definition == null)
                    jsType.definition = new JsObject();

                var index = fullName.As<JsString>().lastIndexOf(".");
                if (index == -1)
                {
                    jsType.name = fullName;
                }
                else
                {
                    jsType.name = fullName.As<JsString>().substring(index + 1);
                    jsType.ns = fullName.As<JsString>().substring(0, index);
                }

                if (jsType.Kind == JsTypeKind.Enum)
                {
                    if (jsType.baseTypeName == null)
                        jsType.baseTypeName = "System.Object";
                    if (jsType.definition["toString"] == JsCode("Object.prototype.toString"))
                        jsType.definition["toString"] = new JsFunction("return this._Name;");
                }
                else if (jsType.Kind == JsTypeKind.Struct)
                {
                    if (jsType.baseTypeName == null)
                        jsType.baseTypeName = "System.ValueType";
                }

            }
        }

        private static void Compile_Phase2()
        {
            for (var i = 0; i < JsTypes.length; i++)
            {
                var jsType = JsTypes[i];
                Compile_Phase2_TmpType(jsType);
            }
            foreach (var ce in JsTypes)
            {
                if (ce.cctor != null)
                    ce.cctor.As<JsAction>()();
            }
            LinkInterfaceMethods();
            JsTypes = new JsArray<JsType>();
        }

        private static void Compile_Phase2_TmpType(JsType tmpType)
        {
            var p = tmpType.fullname;
            var type = CompileType(tmpType);
            if (type != null)
                CopyMemberIfNotDefined(type, type.fullname, window);
            if (type.ns != null)
            {
                var ns = ResolveNamespace(type.ns);
                if (type != null)
                    ns[type.name] = type;
            }
        }

        private static void LinkInterfaceMethods()
        {
            for (var it = 0; it < JsTypes.length; it++)
            {
                var jsType = JsTypes[it];
                for (var ii = 0; ii < jsType.interfaces.length; ii++)
                {
                    var intType = jsType.interfaces[ii];

                    foreach (var shortName in intType.definition.As<JsObject>())
                    {
                        var longName = intType.name + "$$" + shortName;
                        var longMem = jsType.commonPrototype[longName];
                        if (longMem == JsContext.undefined)
                        {
                            var shortMem = jsType.commonPrototype[shortName];
                            if (shortMem != JsContext.undefined)
                            {
                                jsType.commonPrototype[longName] = jsType.commonPrototype[shortName];
                            }
                        }
                    }
                }

            }
        }

        private static void Compile_Phase3()
        {
            var funcs = AfterCompilationFunctions;
            AfterCompilationFunctions = new JsArray<JsAction>();
            foreach (var action in funcs)
                action();
            IsCompiled = true;
        }

        #region JsCode

        [JsMethod(NativeOverloads = true, Code = @"if(target[name]===undefined) target[name] = source;")]
        internal static void CopyMemberIfNotDefined(object source, string name, object target)
        {
        }

        [JsMethod(NativeOverloads = true, Code = @"for(var p in source)
		target[p] = source[p];
	if(source.toString!=Object.prototype.toString && target.toString==Object.prototype.toString)
		target.toString = source.toString;")]
        internal static void _CopyObject(object source, object target)
        {

        }
        [JsMethod(NativeOverloads = true, Code = @"	for(var p in source)
	{
		if(typeof(target[p])!='undefined')
		{
			//TODO: Alon - unmark this. throw new Error(p+' is already defined on target object');
		}
		else
			target[p] = source[p];
	}
	if(source.toString!=Object.prototype.toString)
	{//TODO: commented out by dan-el
		//if(target.toString!=Object.prototype.toString)
			//throw new Error('toString is already defined on target object');
	}")]
        internal static void _SafeCopyObject(JsObject source, JsObject target)
        {
        }

        [JsMethod(NativeOverloads = true, Code = @"return this.staticDefintion[name];")]
        private static object _EnumTryParse(JsString name)
        {
            throw new NotImplementedException();
        }

        [JsMethod(Code = "return new ctor();")]
        internal static object NewByFunc(JsFunction ctor)
        {
            return null;
        }
        [JsMethod(Code = "return new ctor.apply(null, args);")]
        internal static object NewByFuncArgs(JsFunction ctor, JsArray args)
        {
            return null;
        }

        [JsMethod(NativeOverloads = true, Code = "return Object.prototype.toString;")]
        private static JsFunction GetNativeToStringFunction()
        {
            throw new NotImplementedException();
        }

#pragma warning disable 0169
        static Exception __LastException;
        [JsMethod(NativeOverloads = true, Code = @"__LastException = exception || __LastException;
			var error = new Error(exception.ToString());
			error['_Exception'] = exception;
			throw error;")]
        private static void Throw(Exception exception)
        {

        }
#pragma warning restore 0169
        [JsMethod(NativeOverloads = true, Code = @"return function(){};")]
        static JsFunction CreateEmptyCtor()
        {
            throw new NotImplementedException();
        }
        //[JsMethod(NativeOverloads = true, Code = @"return function(){this.construct();};")]
        [JsMethod(NativeOverloads = true, Code = @"return function(){this.construct(type);};")]
        static JsFunction CreateBaseCtor(JsType type)
        {
            throw new NotImplementedException();
        }


        [JsMethod(GlobalCode = true, Code = @"if(typeof(Node)=='undefined')
	var Node = function(){};
")]
        static void Global2()
        {
        }

        #endregion

        internal static JsObject<JsType> Types = new JsObject<JsType>();

        private static JsNamespace ResolveNamespace(JsString nsText)
        {
            var ns = window.As<JsNamespace>();
            var tokens = nsText.split('.');
            for (var i = 0; i < tokens.length; i++)
            {
                var token = tokens[i];
                if (@typeof(ns[token]) == "undefined")
                    ns[token] = new JsNamespace();
                ns[token].As<JsNamespace>().name = tokens.slice(0, i).join(".");
                ns = ns[token].As<JsNamespace>();
            }
            return ns;
        }

        private static void ResolveBaseType(JsType type, JsType currentType)
        {
            var baseType = JsTypeHelper.GetType(type.baseTypeName);
            if (baseType == null)
                baseType = JsTypeHelper.GetTypeIgnoreNamespace(type.baseTypeName, true);
            if (!baseType.isCompiled)
                CompileType(baseType);
            currentType.baseType = baseType;
            baseType.derivedTypes.push(currentType);
        }

        private static void ResolveInterfaces(JsType type, JsType currentType)
        {
            if (type.interfaceNames == null)
                return;
            for (var i = 0; i < type.interfaceNames.length; i++)
            {
                var iName = type.interfaceNames[i].As<string>();
                var iface = JsTypeHelper.GetType(iName);
                if (iface == null)
                    iface = JsTypeHelper.GetTypeIgnoreNamespace(iName, true);
                if (!iface.isCompiled)
                    CompileType(iface);
                currentType.interfaces.push(iface);
            }
        }

        private static JsType CompileType(JsType type)
        {
            var currentType = Types[type.fullname].As<JsType>() ?? type;
            if (currentType.ctors == null)
                currentType.ctors = new JsObject();
            if (!type.isCompiled)
            {
                var baseTypeResolved = false;
                if (currentType.baseType == null && currentType.baseTypeName != null)
                {
                    ResolveBaseType(type, currentType);
                    if (currentType.baseType != null)
                        baseTypeResolved = true;
                }
                ResolveInterfaces(type, currentType);
                foreach (var p in type.definition)
                {
                    if (p.As<JsString>().search("ctor") == 0) //isCtor
                    {
                        currentType.As<JsObject>()[p] = type.definition[p];
                        delete(type.definition[p]);
                        if (@typeof(currentType.commonPrototype) == "undefined")
                            currentType.commonPrototype = currentType.As<JsObject>()[p].As<JsFunction>().prototype.As<JsCompilerPrototype>();
                        else
                            currentType.As<JsObject>()[p].As<JsFunction>().prototype = currentType.commonPrototype;
                        currentType.ctors[p] = currentType.As<JsObject>()[p];
                    }
                    if (p == "cctor")
                        currentType.cctor = p.As<JsFunction>();
                }
                if (currentType.ctor == null)
                {
                    if (currentType.ns == null || currentType.ns == "")
                    {
                        var jsCtor = window.As<JsObject>()[currentType.name].As<JsFunction>();
                        if (JsTypeOf(jsCtor) == JavaScript.JsTypes.function || JsTypeOf(jsCtor) == JavaScript.JsTypes.@object)
                            currentType.ctor = jsCtor;
                    }
                    if (currentType.ctor == null && currentType.ctors != null)
                    {
                        //create default ctor anyway for generic argument passing, etc...
                        //var createCtor = true;
                        //foreach (var p in currentType.ctors)
                        //{
                        //    createCtor = false;
                        //    break;
                        //}
                        //if (createCtor)
                        //{
                        if (currentType.baseType != null)
                            currentType.ctor = CreateBaseCtor(currentType);
                        else
                            currentType.ctor = CreateEmptyCtor();
                        //}
                    }
                    if (currentType.ctor != null)
                    {
                        currentType.ctors["ctor"] = currentType.ctor;
                        if (@typeof(currentType.commonPrototype) == "undefined")
                            currentType.commonPrototype = currentType.ctor.prototype.As<JsCompilerPrototype>();
                        else
                            currentType.ctor.prototype = currentType.commonPrototype;
                    }
                }
                foreach (var p in currentType.ctors)
                {
                    var ctor = currentType.ctors[p].As<JsCompilerFunction>();
                    if (ctor._type == null)
                        ctor._type = currentType;
                }
                if (baseTypeResolved)
                {
                    _CopyObject(currentType.baseType.commonPrototype, currentType.commonPrototype);
                }
                foreach (var p in type.definition)
                {
                    var member = type.definition[p];
                    currentType.commonPrototype[p] = member;
                    if (JsContext.@typeof(member) == "function")
                    {
                        member.As<JsCompilerFunction>()._name = p;
                        member.As<JsCompilerFunction>()._type = currentType;
                    }
                }
                if (type.definition.As<JsCompilerPrototype>().toString != JsCompilerObject.prototype.toString)
                {
                    currentType.commonPrototype.toString = type.definition.As<JsCompilerPrototype>().toString;
                    //currentType.commonPrototype.toString.name = "toString"; //It's always readonly! (and forbidden in strict mode)
                    currentType.commonPrototype.toString._type = currentType;
                }
                foreach (var p in type.staticDefinition)
                {
                    var member = type.staticDefinition[p];
                    //TODO: if (@typeof(currentType.As<JsObject>()[p]) != "undefined")
                    //TODO:    throw new JsError("Reserved static member name " + p).As<Exception>();
                    currentType.As<JsObject>()[p] = member;
                    if (JsContext.@typeof(member) == "function")
                    {
                        member.As<JsCompilerFunction>()._name = p;
                        member.As<JsCompilerFunction>()._type = currentType;
                    }
                }
                type.isCompiled = true;
            }
            CompileEnum(currentType);
            if (currentType != type && type.customAttributes != null)
            {
                if (currentType.customAttributes != null)
                {
                    for (var i = 0; i < type.customAttributes.length; i++)
                    {
                        currentType.customAttributes.push(type.customAttributes[i]);
                    }
                }
                else
                {
                    currentType.customAttributes = type.customAttributes;
                }
            }

            return currentType;
        }
        private static void CompileEnum(JsType currentType)
        {
            if (currentType.Kind == JsTypeKind.Enum)
            {
                currentType.tryParse = _EnumTryParse;
                foreach (var p in currentType.staticDefinition)
                {
                    if (@typeof(currentType.staticDefinition[p]) == "string")
                    {
                        var x = NewByFunc(currentType.ctor);
                        x.As<JsObject>()["_Name"] = p;
                        currentType.staticDefinition[p] = x;
                        currentType.As<JsObject>()[p] = x;
                    }
                }
            }
        }




        static int _hashKeyIndex = 0;
        static string _hashKeyPrefix = JsString.fromCharCode(1);
        public static JsString GetHashKey(object obj)
        {
            if (obj == undefined)
                return "undefined";
            if (obj == null)
                return "null";
            if (obj.As<JsPrimitive>().valueOf.As<bool>())
                obj = obj.As<JsPrimitive>().valueOf();
            var type = @typeof(obj);
            if (type == "string")
                return obj.As<JsString>();
            if (type == "object" || type == "function")
            {
                if (obj.As<JsCompilerObject>()._hashKey == null)
                {
                    obj.As<JsCompilerObject>()._hashKey = _hashKeyPrefix + _hashKeyIndex;
                    _hashKeyIndex++;
                }
                return obj.As<JsCompilerObject>()._hashKey;
            }
            return obj.As<JsObject>().toString();
        }

    }
}

/// <summary>
/// SharpKit library for Clr mode, .NET runtime implementation written in pure JavaScript.
/// This library supports namespaces, classes, generics, interfaces, enums, delegates, LINQ, reflection and many other .NET features.
/// To use this library, you must include the jsclr.js script and call the Compile() method.
/// Clr scripts have no dependencies, and you can include your own clr scripts in any order you want.
/// </summary>
class AssemblyDoc
{
}