

using System.Collections.Generic;
using SharpKit.JavaScript;
using SharpKit.Test;

namespace SharpKit.JsClr.Test
{
    [JsType(JsMode.Clr, Filename = "~/res/QunitTests.js")]
    public class TestClass
    {
        
    }

    [JsType(JsMode.Global, Filename = "~/res/QunitTests.js", GlobalObject = true)]
    public class ArrayTest
    {
        [JsMethod(GlobalCode = true)]
        public static void Contains()
        {
            Qunit.RunTest("Contains", () =>
                                          {
                                              var testClass = new TestClass();
                                              IList<TestClass> array = new [] {testClass};
                                              Qunit.IsTrue(array.Contains(testClass));
            });
        }

        [JsMethod(GlobalCode = true)]
        public static void Remove()
        {
            Qunit.RunTest("Remove", () =>
            {
                var testClass = new TestClass();
                IList<TestClass> array = new[] { testClass };
                array.Remove(testClass);
                Qunit.AreEqual(0,array.Count);
            });
        }

    }
}