using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.BasicNavigation
{
    [JsType(GlobalObject = true, Filename = "../js/demo-basicnavigation.js", OrderInFile = 3, PreCode = "//---------Global----------//\n//global variables")]
    public class Global : HtmlContext
    {
        #region Global variables
        public static bool boolLightOn = false;
        public static int iPortraitWidth = 768;
        public static int iLandscapeWidth = 1024;
        #endregion

        #region Functions delegate
        //*** Prevent Default Scroll ******
        /// <summary>
        /// Prevent Default Scroll
        /// </summary>
        /// <param name="evt"></param>
        public static EventListener<TouchEvent> PreventDefaultScroll = delegate(TouchEvent evt)
        {
            evt.PreventDefault();
            window.Scroll(0, 0);
            @return(false);
        };
        #endregion

        /// <summary>
        /// Global code
        /// </summary>
        static Global()
        {
            //initial event handler to detect when appMobi is ready to roll
            Xdk.OnDeviceReady += DeviceReady;
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        }

        /// <summary>
        /// This function runs once the page is loaded
        /// </summary>
        public static void Init()
        {
        }

        /// <summary>
        /// Flashlight Switch
        /// </summary>
        /// <returns></returns>
        public static void LightSwitch()
        {
            if (boolLightOn == true)
            {
                Element.GetById("off").style.visibility = "visible";
                Element.GetById("on").style.visibility = "hidden";
                document.body.style.backgroundColor = "black";
            }
            else
            {
                Element.GetById("on").style.visibility = "visible";
                Element.GetById("off").style.visibility = "hidden";
                document.body.style.backgroundColor = "white";
            }
            boolLightOn = !boolLightOn;
        }

        /// <summary>
        /// This event handler is fired once the AppMobi libraries are ready
        /// AppMobi is ready to roll
        /// </summary>
        /// <param name="evt"></param>
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            //use AppMobi viewport
            Xdk.display.UseViewport(iPortraitWidth, iLandscapeWidth);

            //lock orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            //manage power
            Xdk.device.ManagePower(true, false);

            //hide splash screen
            Xdk.device.HideSplashScreen();
        }


    }
}