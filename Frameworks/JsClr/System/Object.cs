using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{


	//causes recursion - object inherits from object

	//[RunAtClient]
	//[JsType(Name = "System.Object")]
	//public class JsImplObject
	//{

	//  [JsMethod(Code = "return\"{\"+this.constructor._type.name+\"}\"")]
	//  public override string ToString()
	//  {
	//    throw new NotSupportedException();
	//  }

	//  //override
	//  string toString()
	//  {
	//    return this.ToString();
	//  }

	//  /// <summary>
	//  /// constructs an object (should be called as the first line of every constructor) calls the base constructors as well.
	//  /// </summary>
	//  [JsMethod(Code = "arguments.callee.caller._type.baseType.ctor.apply(this, arguments);")]
	//  void construct()
	//  {
	//    throw new NotSupportedException();
	//  }

	//  [JsMethod(Code = "return System.Type._TypeOf(this.constructor._type);")]
	//  public new JsImplType GetType()
	//  {
	//    throw new NotSupportedException();
	//  }
	//  [JsMethod(Code = "return this.constructor._type;")]
	//  JsType getType()
	//  {
	//    throw new NotSupportedException();
	//  }
	//  [JsMethod(Code = "return this.constructor._type.name;")]
	//  JsType getTypeName()
	//  {
	//    throw new NotSupportedException();
	//  }

	//  ////
	//  //// calls the caller's function's base method
	//  ////
	//  //base : function()
	//  //{
	//  //  return arguments.callee.caller._type.baseType.ctor.prototype[arguments.callee.caller._name].apply(this, arguments);
	//  //},

	//  /////
	//  ///// calls a base method
	//  /////
	//  //callBase : function(methodName)
	//  //{
	//  //  return arguments.callee.caller._type.baseType.ctor.prototype[methodName].apply(this, Arguments.from(arguments, 1));
	//  //}

	//}

}
