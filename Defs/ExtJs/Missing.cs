using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace Ext
{

    public partial class ExtContext
    {
        [JsMethod(IgnoreGenericArguments=false)]
        public static T create<T>(object config) { return default(T); }
        //public static Ext.window.MessageBox MessageBox { get; set; }
    }
}
