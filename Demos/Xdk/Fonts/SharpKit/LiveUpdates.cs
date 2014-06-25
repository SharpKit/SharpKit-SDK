using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Fonts
{
    /// <summary>
    /// If you decide to allow your application to handle Live Updates itself, 
    /// this snippet will give you a starting point. Drop this javascript code 
    /// into your application's <body> HTML tag to detect if an update has been 
    /// successfully downloaded.
    /// </summary>
    [JsType(GlobalObject = true, Filename = "../js/demo-fonts.js", OrderInFile = 3, PreCode = "//---------Live Updates----------//")]
    public class LiveUpdates : HtmlContext
    {
        static LiveUpdates()
        {
            /* Live Updates */

            /* If you decide to allow your application to handle Live Updates itself, 
            this snippet will give you a starting point. Drop this javascript code 
            into your application's <body> HTML tag to detect if an update has been 
            successfully downloaded. */
            Xdk.OnDeviceUpdateAvailable += UpdateAvailable;
            Xdk.OnDeviceReady += DeviceReadyTestForUpdate;
        }

        /// <summary>
        /// This event handler captures the event thrown when an update becomes available while an application is running
        /// </summary>
        /// <param name="evt"></param>
        public static void UpdateAvailable(XdkDeviceEvent evt)
        {
            /* test to see if the event is appMobi.device.update.available */
            if (evt.type == XdkDeviceEventType.DeviceUpdateAvailable)
            {
                /* there is an update available *while* the application is running - decide what to do */
                if (Confirm(evt.updateMessage) == true)
                {
                    UpdateApplication();
                }
                else
                {
                    UpdateApplicationLater();
                }
            }
        }

        public static void DeviceReadyTestForUpdate(XdkDeviceEvent evt)
        {
            /* appMobi.updateAvailable indicates whether or not an over the air update is available or not. */
            if (Xdk.updateAvailable == true)
            {
                //there is an application update available at startup
                if (Confirm(Xdk.updateMessage) == true)
                {
                    UpdateApplication();
                }
                else
                {
                    UpdateApplicationLater();
                }
            }
        }

        public static void UpdateApplication()
        {
            /* installs an update if one is available */
            Xdk.device.InstallUpdate();
        }

        public static void UpdateApplicationLater()
        {
            /* add any code to indicate that the update has been postponed */
            Alert("The update has been postponed");
        }
    }
}