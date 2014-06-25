using SharpKit.JavaScript;

namespace SharpKit.Test
{
    [JsType(JsMode.Global, Filename = "~/res/QunitTests.js",GlobalObject = true)]
    internal class StringTest
    {
        [JsMethod(GlobalCode = true)]
        public static void PeekTest()
        {
            Qunit.RunTest("Format3Arg", () =>
                                            {
                                                Qunit.AreEqual("foo bar hello", string.Format("{0} {1} {2}","foo","bar","hello"));
                                            });
        }
    }
}