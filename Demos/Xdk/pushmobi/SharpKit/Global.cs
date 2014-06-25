using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.PushMobi
{
    [JsType(GlobalObject = true, Filename = "../js/demo-pushmobi.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables
        //timeout for the status message at the bottom of the application
        public static int msgTimeout;

        public static bool didcheckuser = false;
        public static JsString chosenUsername = "testUser";
        public static JsString chosenPassword = "password";
        public static JsString chosenEmail = "recovery_email@email.com";
        public static JsArray clearList = new JsArray();
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

        /// <summary>
        /// This code will run as soon as appMobi is completely loaded
        /// </summary>
        /// <param name="evt"></param>
        public static EventListener<XdkDeviceEvent> OnDeviceReady = delegate(XdkDeviceEvent evt)
        {
            Xdk.display.UseViewport(768, 1024);

            //lock the orientation of the application
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            Xdk.device.HideSplashScreen();

            if (Xdk.device.platform == XdkDevicePlatformType.Android && Xdk.device.osVersion == "2.1")
            {
                Xdk.notification.Alert("The appMobi push messaging commands require Android OS 2.2 or higher", "pushMobi Requirement", "OK");
            }
            else
            {

                //update the t-shirt message to be the last push message received
                if (Xdk.cache.GetCookie("tshirtMessage") != undefined)
                {
                    HtmlElement.GetById("spnShirtMessage").innerHTML = Xdk.cache.GetCookie("tshirtMessage");
                }
                else
                {
                    HtmlElement.GetById("spnShirtMessage").innerHTML = "Your push message here!";
                }

                //register the application to receive push messages
                RegisterForMessages();
            }
        };

        #endregion

        /// <summary>
        /// Global code
        /// </summary>
        static Global()
        {
            //This event handler captures the event indicating that appMobi is completely loaded
            Xdk.OnDeviceReady += OnDeviceReady;
            window.AddEventListener("load", Init, false);
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, PreventDefaultScroll);

            //event that let's you know that the user's app is enabled to receive push
            Xdk.OnNotificationPushEnable += NotificationsRegistered;
            //register to be notified when a push message is received by the app
            Xdk.OnNotificationPushReceive += UpdateNotifications;
            //Two rich push msgs, can't be viewed at the same time
            //register to be notified when a rich push message is closed (so that you can launch the next one)
            Xdk.OnNotificationPushRichClose += RichViewerClosed;
        }

        /// <summary>
        /// This function runs once the page is loaded, but appMobi is not yet active
        /// </summary>
        public static void Init(Event evt) { }


        //register this app/user with the push messaging system.
        //This should only happen once per install
        public static void RegisterForMessages()
        {
            chosenUsername = Xdk.device.uuid; //set a default unique username for the purposes of push

            if (chosenUsername.IndexOf("emulated") != -1)
            {
                Xdk.cache.RemoveCookie("pushmobi_username");
                chosenUsername = Rnd(99999).As<JsString>();
            }

            //If this device is already registered, just check for new notifications
            if (Xdk.cache.GetCookie("pushmobi_username") == undefined)
            {
                try
                {
                    Xdk.notification.AddPushUser(chosenUsername, chosenPassword, chosenEmail);
                }
                catch (JsError e) { Alert("error adding push user: " + e.message); }
            }
        }

        /* This callback lets you know whether the app has successfully registered to 
        recieve push notifications. This should only happen once per install (note, though, that if you
        ask the system whether the user/app is registered for push via checkPushUser, or if you attempt
        to reregister the app/user with the system, this even will fire again */
        public static void NotificationsRegistered(XdkNotificationPushEvent evt)
        {
            if (evt.success == false)
            {
                if (didcheckuser == false)
                {
                    Xdk.notification.CheckPushUser(chosenUsername, chosenPassword);
                    didcheckuser = true;
                }
                else
                {
                    Alert("There was an error adding push notifications " + evt.message);
                }
                return;
            }
            else
            {
                //if the app successfully registered, it's good to save the user information
                //for pulling the right the messages that belong to this user. Then you
                //can prevent unnecessarily trying to re-register the app/user
                Xdk.cache.SetCookie("pushmobi_username", chosenUsername, -1);
                Xdk.cache.SetCookie("pushmobi_password", chosenPassword, -1);
                Xdk.cache.SetCookie("pushmobi_email", chosenEmail, -1);
            }

            UpdateNotifications(evt);
        }

        /* Callback for handling notifications */
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
                    if (msgObj.isRich == false)
                    { //Is this a simple text push message?

                        //update the style of the t-shirt text
                        if (msgObj.data != "")
                        {
                            HtmlElement.GetById("spnShirtMessage").style.cssText = msgObj.data;
                        }
                        console.Log(HtmlElement.GetById("spnShirtMessage").style.cssText);

                        //print the message on the t-shirt
                        HtmlElement.GetById("spnShirtMessage").innerHTML = msgObj.msg;
                        Xdk.cache.SetCookie("tshirtMessage", msgObj.msg, -1);

                        //message received
                        Xdk.player.StartAudio("images/small-bell-ring-01.mp3");
                        HtmlElement.GetById("spnMessage").innerHTML = "Push Message Received";

                        //Hide the status message after 6 seconds
                        ClearTimeout(msgTimeout);
                        msgTimeout = SetTimeout("HideMessage();", 6000);

                        //remove the message from the server otherwise the app will 
                        //think it has more messages waiting for it
                        Xdk.notification.DeletePushNotifications(msgObj.id);
                    }
                    else
                    { //show rich push messages in the rich viewer
                        Xdk.notification.ShowRichPushViewer(msgObj.id, 10, 10, 10, 10, 80, 80);
                        break; // only one rich message at a time, will resume after RichViewerClosed
                    }
                }
            }
            catch (JsError e) { Alert("error in UpdateNotifications: " + e.message); }
        }

        public static void RichViewerClosed(XdkNotificationPushEvent evt)
        {
            //remove the message from the server
            Xdk.notification.DeletePushNotifications(evt.id);

            // resume viewing push messages
            UpdateNotifications(evt);
        }

        public static void SendPushMessage(Event evt)
        {
            //play a click
            Xdk.player.StartAudio("images/click-5.mp3");

            //send the notification FROM the application TO the current user of the application
            Xdk.notification.SendPushNotification(chosenUsername, HtmlInputElement.GetById("txtMessage").value, "111");

            //clear the edit field and update the status message
            HtmlInputElement.GetById("txtMessage").value = "";
            HtmlElement.GetById("spnMessage").innerHTML = "Push Message Sent";

            //clear the status message after six seconds
            ClearTimeout(msgTimeout);
            msgTimeout = SetTimeout("HideMessage();", 6000);
        }

        //clear the status message
        public static void HideMessage()
        {
            HtmlElement.GetById("spnMessage").innerHTML = "";
        }

        //random number generator
        public static int Rnd(int i)
        {
            return JsMath.Floor(JsMath.Random() * i);
        }

    }
}