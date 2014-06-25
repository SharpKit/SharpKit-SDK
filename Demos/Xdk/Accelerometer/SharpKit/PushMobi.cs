using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Accelerometer
{
    /// <summary>
    /// This snippet of code is a starting point for handling pushMobi Push Messages in 
    /// an appMobi application. Drop this javascript code into your application's <head>
    /// HTML tag to allow a user to log in and test basic push text messaging.
    /// </summary>
    [JsType(GlobalObject = true, Filename = "../js/demo-accelerometer.js", OrderInFile = 4, PreCode = "//---------PushMobi----------//\n/*", PostCode = "*/")]
    public class PushMobi : HtmlContext
    {
        public static JsArray clearList = new JsArray();
        public static bool didcheckuser = false;

        /// <summary>
        /// Global code
        /// </summary>
        static PushMobi()
        {
            // Register for messages as soon as appMobi is loaded
            Xdk.OnDeviceReady += RegisterForMessages;
            Xdk.OnNotificationPushRichClose += RichViewerClosed;
        }

        /// <summary>
        /// This function will add this device to the push messaging system the first time it runs on a device 
        /// </summary>
        /// <param name="evt"></param>
        public static void RegisterForMessages(XdkDeviceEvent evt)
        {
            //Get the unique identifier of this device
            JsString myUserID = Xdk.device.uuid;

            //Register the appMobi.notification.push.enable event
            Xdk.OnNotificationPushEnable += NotificationsRegistered;

            //If this device is already registered, just check for new notifications
            if (Xdk.cache.GetCookie("username").ExactEquals(undefined))
            {
                try
                {
                    //unremark this code to register this application for push messages
                    JsString chosenUsername = Prompt("Choose a username for push messaging", Xdk.device.uuid);
                    JsString chosenPassword = Prompt("Choose a password for push messaging", "password");
                    JsString chosenEmail = Prompt("Enter an email address for account confirmation", "");

                    Xdk.cache.SetCookie("username", chosenUsername);
                    Xdk.cache.SetCookie("password", chosenPassword);
                    Xdk.cache.SetCookie("email", chosenEmail);
                    Xdk.notification.AddPushUser(chosenUsername, chosenPassword, chosenEmail);
                }
                catch (JsError e) { Alert("error adding push user: " + e.message); }
            }
            else
            {
                Xdk.notification.CheckPushUser(Xdk.cache.GetCookie("username"), Xdk.cache.GetCookie("password"));
            }
        }

        public static void NotificationsRegistered(XdkNotificationPushEvent evt)
        {
            if (evt.success.ExactEquals(false))
            {
                if (didcheckuser == false)
                {
                    Xdk.notification.CheckPushUser(Xdk.device.uuid, "password");
                    didcheckuser = true;
                }
                else
                {
                    Alert("There was an error adding push notifications " + evt.message);
                }
                return;
            }
            Xdk.OnNotificationPushReceive += UpdateNotifications;
            Xdk.OnNotificationPushRefresh += UpdateNotifications;

            UpdateNotifications(null);
        }

        /// <summary>
        /// Callback for handling notifications
        /// </summary>
        /// <param name="evt"></param>
        public static void UpdateNotifications(XdkNotificationPushEvent evt)
        {
            try
            {
                JsArray<JsString> myNotifications = Xdk.notification.GetNotificationList();
                int len = myNotifications.length;

                for (int i = 0; i < len; i++)
                {
                    //get the pushMobi message data
                    XdkNotificationData msgObj = Xdk.notification.GetNotificationData(myNotifications[i]);

                    //display the pushMobi message as a notification if there is no data
                    if (msgObj.richHtml.ExactEquals(undefined) && msgObj.richUrl.ExactEquals(undefined))
                    {
                        Xdk.notification.Alert(msgObj.msg, "pushMobi Message", "OK");
                        //remove the message from the server
                        Xdk.notification.DeletePushNotifications(msgObj.id);
                    }
                    else
                    {
                        Xdk.notification.ShowRichPushViewer(msgObj.id, 10, 10, 10, 10, 80, 80);
                    }
                }
            }
            catch (JsError e) { Alert("error in UpdateNotifications: " + e.message); }
        }

        public static void RichViewerClosed(XdkNotificationPushEvent evt)
        {
            //remove the message from the server
            Xdk.notification.DeletePushNotifications(evt.id);
        }
    }
}