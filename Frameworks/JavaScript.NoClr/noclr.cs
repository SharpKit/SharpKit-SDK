using SharpKit.JavaScript;
using System.Collections.Generic;
using System.Collections;
using System;
[assembly: JsType(JsMode.Prototype, TargetTypeName = "System.Collections.Generic.List`1", Name = "Array", NativeArrayEnumerator = true, NativeEnumerator = false)]
[assembly: JsProperty(TargetTypeName = "System.Collections.Generic.List`1", TargetProperty="Item", NativeIndexer=true)]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "Add", Name = "push")]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "RemoveAt", Name = "splice", InsertArg1 = "1")]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "Insert", Name = "splice", InsertArg1="0")]

[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "AddRange", Name = "ListHelper.AddRange", InstanceImplementedAsExtension=true)]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "IndexOf", Name = "ListHelper.IndexOf", InstanceImplementedAsExtension = true)]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "Remove", Name = "ListHelper.Remove", InstanceImplementedAsExtension = true)]
//[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "IndexOf", Name = "slice", InvokePrefix="(", InvokeSuffix=",1)[0]", OmitParanthesis=true)]
//[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.List`1", TargetMethod = "Remove", Name = "splice", InvokePrefix="indexOf(", InvokeSuffix = "), 1")]



[assembly: JsType(JsMode.Json, TargetTypeName = "System.Collections.Generic.Dictionary`2", Name = "Object", NativeEnumerator = true)]
[assembly: JsProperty(TargetTypeName = "System.Collections.Generic.Dictionary`2", TargetProperty = "Item", NativeIndexer = true)]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.Dictionary`2", TargetMethod = "Remove", Name = "delete", OmitParanthesis = true, InstanceImplementedAsExtension = true, InsertArg0 = "[", InsertArg1 = "]", OmitCommas = true)]
[assembly: JsMethod(TargetTypeName = "System.Collections.Generic.Dictionary`2", TargetMethod = "Add", Name = "", OmitParanthesis = true, InstanceImplementedAsExtension = true, InsertArg0 = "[", InsertArg1 = "] =", OmitCommas = true)]
[assembly: JsProperty(TargetTypeName = "System.Collections.Generic.Dictionary`2", TargetProperty = "Keys", Name = "", NativeField = true)]

[assembly: JsType(JsMode.Json, TargetTypeName = "System.Collections.Generic.Dictionary`2+KeyCollection", NativeEnumerator = true)]

[assembly: JsType(JsMode.Prototype, TargetType = typeof(DateTime), Name = "Date")]
[assembly: JsMethod(TargetType = typeof(DateTime), TargetMethod="get_Now", Name = "new Date", Global=true)]
[assembly: JsProperty(TargetTypeName = "System.Collections.Generic.List`1", TargetProperty = "Count", NativeField = true, Name = "length")]


//[assembly: JsType(JsMode.Json, TargetTypeName = "System.Collections.Generic.KeyValuePair`2", NativeEnumerator = true)]
//[assembly: JsProperty(TargetTypeName = "System.Collections.Generic.KeyValuePair`2", TargetProperty = "Key", Name="", NativeField=true)]


namespace SharpKit.JavaScript.NoClr
{
    [JsType(JsMode.Prototype, Name = "ListHelper")]
    static class ListHelper
    {
        public static void AddRange<T>(JsArray<T> list, IJsArrayEnumerable<T> items)
        {
            JsContext.NativeActionOf<T>(list.push).As<JsFunction>().apply(list, items.As<object[]>());
        }
        public static JsNumber IndexOf<T>(JsArray<T> list, T item) where T:class
        {
            var length = list.length;
            for(var i=0;i<length;i++)
            {
                if (list[i] == item)
                    return i;
            }
            return -1;
        }
        public static bool Remove<T>(JsArray<T> list, T item) where T : class
        {
            var index = IndexOf(list, item);
            if (index >= 0)
            {
                list.splice(index, 1);
                return true;
            }
            return false;
        }
    }
}