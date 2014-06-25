using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.JsClr.System.Linq
{
    [JsType(JsMode.Clr, Name = "System.Linq._Error", Filename = "~/res/System.Linq.js")]
    internal static class Error
    {
        internal static Exception ArgumentArrayHasTooManyElements(object p0)
        {
            return new ArgumentException("ArgumentArrayHasTooManyElements(p0");
        }
        internal static Exception ArgumentNotIEnumerableGeneric(object p0)
        {
            return new ArgumentException("ArgumentNotIEnumerableGeneric(p0");
        }
        internal static Exception ArgumentNotSequence(object p0)
        {
            return new ArgumentException("ArgumentNotSequence(p0");
        }
        internal static Exception ArgumentNotValid(object p0)
        {
            return new ArgumentException("ArgumentNotValid(p0");
        }
        internal static Exception IncompatibleElementTypes()
        {
            return new ArgumentException("IncompatibleElementTypes");
        }
        internal static Exception ArgumentNotLambda(object p0)
        {
            return new ArgumentException("ArgumentNotLambda(p0");
        }
        internal static Exception MoreThanOneElement()
        {
            return new InvalidOperationException("MoreThanOneElement");
        }
        internal static Exception MoreThanOneMatch()
        {
            return new InvalidOperationException("MoreThanOneMatch");
        }
        internal static Exception NoArgumentMatchingMethodsInQueryable(object p0)
        {
            return new InvalidOperationException("NoArgumentMatchingMethodsInQueryable(p0");
        }
        internal static Exception NoElements()
        {
            return new InvalidOperationException("NoElements");
        }
        internal static Exception NoMatch()
        {
            return new InvalidOperationException("NoMatch");
        }
        internal static Exception NoMethodOnType(object p0, object p1)
        {
            return new InvalidOperationException("NoMethodOnType(p0, p1");
        }
        internal static Exception NoMethodOnTypeMatchingArguments(object p0, object p1)
        {
            return new InvalidOperationException("NoMethodOnTypeMatchingArguments(p0, p1");
        }
        internal static Exception NoNameMatchingMethodsInQueryable(object p0)
        {
            return new InvalidOperationException("NoNameMatchingMethodsInQueryable(p0");
        }
        internal static Exception ArgumentNull(string paramName)
        {
            return new ArgumentNullException(paramName);
        }
        internal static Exception ArgumentOutOfRange(string paramName)
        {
            return new ArgumentOutOfRangeException(paramName);
        }
        internal static Exception NotImplemented()
        {
            return new NotImplementedException();
        }
        internal static Exception NotSupported()
        {
            return new NotSupportedException();
        }
    }
}
