using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Private
{

    [JsType(JsMode.Clr, Name = "System.Collections.Generic.Comparer$1", Filename = "~/Internal/Core.js")]
    public abstract class JsImplComparer<T> : IComparer<T>
    {
        public abstract int Compare(T x, T y);

        private static JsImplComparer<T> _Default;
        public static JsImplComparer<T> Default
        {
            get
            {
                if (_Default == null)
                    _Default = new DefaultComparer().As<JsImplComparer<T>>();
                return _Default;
            }
        }

    }

}
