using System;
using System.Collections.Generic;
using System.Text;


namespace SharpKit.JavaScript.Private
{
    [JsType(JsMode.Prototype, Name = "Number", Filename = "~/Internal/Core.js", OmitDefaultConstructor = true, OmitInheritance = true, NativeOverloads = false, NativeCasts = false, NativeOperatorOverloads = false)]
    internal class JsNumberEx : JsNumber
    {
        [JsMethod(Export = false)]
        public JsNumberEx(double d)
            : base(d)
        {

        }

        [JsMethod(NativeOverloads = true, Name = "CompareTo$$Double")]
        public int Compare2To(double value)
        {
            if (this < value)
                return -1;
            if (this > value)
                return 1;
            if (this == value)
                return 0;
            if (!double.IsNaN(this))
                return 1;
            return !double.IsNaN(value) ? -1 : 0;
        }

        [JsMethod(NativeOverloads = true, Name = "CompareTo$$Int32")]
        public int CompareTo(int value)
        {
            if (this < value)
                return -1;
            return this > value ? 1 : 0;
        }

    }
}