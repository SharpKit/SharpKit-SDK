using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SharpKit.JavaScript.Private
{

    [JsType(JsMode.Clr, Name = "System.Collections.Comparer", Filename = "~/Internal/Core.js")]
    public abstract class JsImplComparer : IComparer
    {
        public abstract int Compare(object x, object y);

        private static JsImplComparer _Default;
        public static JsImplComparer Default
        {
            get
            {
                if (_Default == null) 
                    _Default = new DefaultComparer();
                return _Default;
            }
        }


    }

    [JsType(JsMode.Clr, Filename = "~/Internal/Core.js")]
    class DefaultComparer : JsImplComparer
    {
        public override int Compare(object x, object y)
        {
            dynamic xx = x;
            dynamic yy = y;
            if (xx.CompareTo)
                return xx.CompareTo(y);
            if (xx > yy)
                return 1;
            if (xx < yy)
                return -1;
            return 0;
        }
    }

}
