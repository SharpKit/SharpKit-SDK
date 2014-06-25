using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.BasicNavigation
{
    [JsType(GlobalObject = true, Filename = "../js/demo-basicnavigation.js", OrderInFile = 1, PreCode = "//---------This is a general javascript library for miscellaneous useful functions----------//\n//global variables")]
    public class General : HtmlContext
    {
        #region Global varibales
        public static int iDebugLevel = 1;
        #endregion

        /// <summary>
        /// Global code
        /// </summary>
        static General()
        {
        }

        /// <summary>
        /// This method is used to debug the application
        /// Change the iDebugLevel to turn it on/off
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorLevel"></param>
        public static JsAction<JsString, JsNumber> DbAlert = delegate(JsString message, JsNumber errorLevel)
        {
            try
            {
                if (errorLevel == null)
                {
                    Alert(message);
                }
                else
                {
                    if (errorLevel <= iDebugLevel)
                    {
                        Alert(message);
                    }
                }
            }
            catch (JsError e) { }
        };

        public static JsFunc<JsString, bool> IsNumeric = delegate(JsString val)
        {
            if (IsNaN(ParseFloat(val)))
            {
                return false;
            }
            return true;
        };
    }
}