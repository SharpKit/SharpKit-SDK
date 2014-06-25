using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SharpKit.JavaScript.Private
{

    [JsType(JsMode.Clr, Name = "System.Array", Filename = "~/Internal/Core.js")]
    public class JsImplArray
    {

        public static void Sort(Array array)
        {
            Sort(array.As<object[]>());
        }

        public static void Sort<T>(T[] array)
        {
            Sort(array, (Comparison<T>)null);
        }

        public static void Sort<T>(T[] array, Comparison<T> cmpFunc)
        {
            var needConvert = !(array.instanceof<JsArray>());
            JsArray sortArray;
            if (needConvert)
            {
                sortArray = new JsArray(array.Length);
                for (var i = 0; i < array.Length; i++)
                    sortArray[i] = array[i];
            }
            else sortArray = array.As<JsArray>();

            if (cmpFunc == null)
            {
                cmpFunc = Comparer<T>.Default.Compare;
            }

            if (cmpFunc == null)
            {
                sortArray.sort();
            }
            else
                sortArray.sort(cmpFunc.As<JsFunction>());

            if (!needConvert) return;
            for (var i = 0; i < array.Length; i++)
                array[i] = sortArray[i].As<T>();
        }

        public static void Sort<T>(T[] array, IComparer<T> cmp)
        {
            Sort(array, new JsComparerHelper<T>(cmp).Compare);
        }

        //[JsMethod(Name = "")] //HACK! TODO: FIX!
        public static void Sort(JsArray array, IComparer cmp)
        {
            Sort(array.As<object[]>(), cmp.As<IComparer<object>>());
        }

    }

    [JsType(JsMode.Clr, Filename = "~/Internal/Core.js")]
    public class JsComparerHelper<T> : IComparer<T>
    {
        IComparer<T> cmp;
        public JsComparerHelper(IComparer<T> cmp)
        {
            this.cmp = cmp;
        }

        public int Compare(T x, T y)
        {
            return cmp.Compare(x, y);
        }
    }

}
