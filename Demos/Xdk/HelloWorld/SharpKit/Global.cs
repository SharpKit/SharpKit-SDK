using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.HelloWorld
{
    [JsType(GlobalObject = true, Filename = "../js/demo-helloworld.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
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

            window.AddEventListener("load", Load, false);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Init()
        {
        }

        public static void Load(Event evt)
        {
            JsString oldTC = "This sample has detected that you are not using the most up to date appMobi test container.  This sample's functionality may be compromised as a result.  Touch OK to continue. ";

            if (@typeof(XdkGlobal.AppMobiInit) != "object")
                Alert(oldTC);
        }


        /// <summary>
        /// This event handler is fired once the AppMobi libraries are ready
        /// AppMobi is ready to roll
        /// </summary>
        /// <param name="evt"></param>
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            //use AppMobi viewport
            Xdk.display.UseViewport(768, 1024);

            //lock orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            //manage power
            Xdk.device.ManagePower(true, false);

            //hide splash screen
            Xdk.device.HideSplashScreen();
        }



        /// <summary>
        /// These commands are just samples that can be deleted from a hello world app
        /// </summary>
        public static void BeepOnce()
        {
            try
            {
                Xdk.notification.Beep(1);
            }
            catch (JsError e) { }
        }

        public static void VibrateDevice()
        {
            try
            {
                Xdk.notification.Vibrate();
            }
            catch (JsError e) { }
        }

        public static void Bark()
        {
            try
            {
                Xdk.player.PlaySound("sounds/bark02.mp3");
            }
            catch (JsError e) { }
        }

        public static void PlayDead()
        {
            Element.GetById("shroud").style.display = "block";
        }

        public static void WakeUp()
        {
            Element.GetById("shroud").style.display = "none";
        }
    }
}