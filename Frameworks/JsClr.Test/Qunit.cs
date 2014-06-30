using System;
using SharpKit.JavaScript;

namespace SharpKit.Test
{
    [JsType(JsMode.Global, Filename = "~/res/QunitTests.js", GlobalObject = true)]
    public static class Qunit
    {
        [JsMethod(Export = false)]
        public static void test(string testName,Action action)
        {
            
        }

        [JsMethod(Export = true)]
        public static void RunTest(string testName, Action action)
        {
            Compile();
            test(testName, action);
        }

        [JsMethod(Export = false,Name = "QUnit.equal")]
        public static void AreEqual(object i, object i1)
        {
            throw new NotImplementedException();
        }

        [JsMethod(Export = false,Code = "alert('hoi');")]
        private static void Compile()
        {
            throw new NotImplementedException();
        }

        [JsMethod(Export = false, Name = "QUnit.ok")]
        public static void IsTrue(bool condition)
        {
            
        }
    }
}