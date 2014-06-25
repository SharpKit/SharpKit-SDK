using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    [JsType(JsMode.Global)]
    public class NodeJsContext : JsContext
    {
        public static dynamic require(string s) { return null; }
        public static T require<T>(string s) where T : IRequirable { return default(T); }
        [JsMethod(IgnoreGenericArguments = false)]
        public static T require<T>() where T : IRequirable { return default(T); }
        public static Console console { get; private set; }
        public static Module module { get; set; }
    }
    public interface IRequirable { }



}
