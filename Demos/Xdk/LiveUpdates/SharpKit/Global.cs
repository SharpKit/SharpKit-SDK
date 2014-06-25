using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.LiveUpdates
{
    [JsType(GlobalObject = true, Filename = "../js/demo-liveupdates.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables
        //This text illustrates that the update changes the application
        public static JsString strChangeText = "This just in: Live Update can be used to change an application even after it has been installed from a device's application store!";

        //This is a numeric application version to increment before for each update
        public static int applicationVersion = 1;
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
            //this event handler captures the event thrown when an update becomes available while an application is running
            Xdk.OnDeviceUpdateAvailable += UpdateAvailable;
        }

        //This funciton is run immediately when the page loads.  Please note that appMobi functions are not
        //  available until DeviceReady is triggered.
        public static void Init()
        {
            HtmlElement.GetById("divTextBalloon").innerHTML = strChangeText;
        }


        /// <summary>
        /// This event handler is fired once the AppMobi libraries are ready
        /// AppMobi is ready to roll
        /// </summary>
        /// <param name="evt"></param>
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            //use AppMobi.display.viewport to size the application to the appropriate width regardless of the device used
            Xdk.display.UseViewport(768, 1024);

            //once the sizing is done, make the HTML body visible
            HtmlElement.GetById("bodyTag").style.visibility = "visible";

            //use AppMobi.device.setRotateOrientation to rotate the application to a certain orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);

            //use AppMobi.device.setAutoRotate to lock the rotation
            Xdk.device.SetAutoRotate(false);

            //use AppMobi.device.managePower to keep the device from shutting off unexpectedly
            Xdk.device.ManagePower(true, false);

            //hide splash screen
            Xdk.device.HideSplashScreen();

            /* OVER THE AIR UPDATE CODE*/

            if (Xdk.cache.GetCookie("applicationVersion") == null)
            {
                //this is the initial installation
                Xdk.cache.SetCookie("applicationVersion", applicationVersion, -1);
            }
            else
            {
                //the current application version is different from the previous one
                int previousVersion = ConvertStringToNumber(Xdk.cache.GetCookie("applicationVersion"));

                if (previousVersion < applicationVersion)
                {
                    //the previous version is lower than the application version installed with this code 
                    Xdk.notification.Alert("Application Updated Successfully");

                    //save the cookie for the next time the application starts
                    Xdk.cache.SetCookie("applicationVersion", applicationVersion, -1);
                }
            }

            //appMobi.updateAvailable indicates whether or not an over the air update is available or not.
            if (Xdk.updateAvailable == true)
            {
                //there is an application update available at startup
                DoUpdateAvailable(Xdk.updateMessage);
            }


        }


        /* OVER THE AIR UPDATE CODE */
        static void UpdateAvailable(XdkDeviceEvent evt)
        {
            if (evt.type == XdkDeviceEventType.DeviceUpdateAvailable)
            {
                //there is an update available *while* the application is running - just warn the user
                WarnUpdateAvailable(evt.updateMessage);
            }
        }

        public static void UpdateApplication(Event evt)
        {
            // installs an update if one is available
            Xdk.device.InstallUpdate();
        }

        public static void UpdateApplicationLater()
        {
            //add any code to indicate that the update has been postponed
        }


        public static void WarnUpdateAvailable(JsString strUpdateMessage)
        {
            if (strUpdateMessage == null)
            {
                strUpdateMessage = "Live Update Available";
            }
            strUpdateMessage += " - Touch Here To Update Application";
            HtmlDivElement.GetById("divFooter").innerHTML = strUpdateMessage;
            HtmlDivElement.GetById("divFooter").className = "marquee";
            HtmlDivElement.GetById("divFooter").AddEventListener("click", UpdateApplication, false);
        }

        public static void DoUpdateAvailable(JsString strUpdateMessage)
        {
            if (strUpdateMessage == null)
            {
                strUpdateMessage = "Would you like to update this application?";
            }

            //there is an update available - ask the user whether they would like to install or not
            ConfirmationBox.Show(strUpdateMessage, "Application Update Available", "Yes, update now", "I'll update later", "UpdateApplication()", "UpdateApplicationLater()");

            //Alternately, the developer could choose to force the update at this point 
            //by calling "AppMobi.device.installUpdate();".
        }


        public static JsNumber ConvertStringToNumber(JsString str)
        {
            try
            {
                return str.As<JsNumber>() / 1;
            }
            catch (JsError e)
            {
                return 0;
            }
        }



    }
}