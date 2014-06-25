using SharpKit.JavaScript;
using System.Linq;
namespace SharpKit.Test
{
    [JsType(JsMode.Global, Filename = "~/res/QunitTests.js",GlobalObject = true)]
    internal class ObjectTest
    {

        [JsMethod(GlobalCode =  true)]
        public static void ContainsTest()
        {
            Qunit.RunTest("ContainsTest", () =>
                                          {
                                              Qunit.IsTrue(new[] {"one", "two"}.Contains("two"));
                                          });
        }
    }
}

