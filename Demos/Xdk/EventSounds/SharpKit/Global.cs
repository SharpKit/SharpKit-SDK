using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.EventSounds
{
    [JsType(GlobalObject = true, Filename = "../js/demo-eventsounds.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables

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

        public static void DoRandomSound()
        {
            console.Log("in DoRandomSound", 4);
            try
            {
                if (Rnd(10) == 0)
                {
                    Xdk.player.PlaySound("sounds/catmeow2.mp3");
                }
                else
                {
                    Xdk.player.PlaySound("sounds/cowbell.mp3");
                }
            }
            catch (JsError e)
            {
                console.Log("error in DoRandomSound: " + e.message);
            }

        }
        /// <summary>
        /// Audio Code
        /// </summary>
        public static void PlaySound()
        {
            Xdk.player.PlaySound("sounds/cowbell.mp3");
            //AppMobi.player.PlaySound("sounds/catmeow2.mp3");
        }

        /// <summary>
        /// random number generator
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Rnd(int i)
        {
            return JsMath.Floor(JsMath.Random() * i);
        }


    }
}