using System.Collections.Generic;
using SharpKit.JavaScript;

namespace SharpKit.Test
{
    [JsType(JsMode.Global, Filename = "~/res/QunitTests.js",GlobalObject = true)]
    internal class StackTest
    {
        [JsMethod(GlobalCode = true)]
        public static void PeekTest()
        {
            Qunit.RunTest("PeekTest", () =>
                                          {
                                              var stack = new Stack<string>();
                                              stack.Push("hello");
                                              stack.Push("goodbye");
                                              Qunit.AreEqual("goodbye", stack.Peek());
                                          });
        }
    }
}