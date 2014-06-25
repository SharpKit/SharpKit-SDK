//---------Global----------//
var msgTimeout = 0;
var didcheckuser = false;
var chosenUsername = "testUser";
var chosenPassword = "password";
var chosenEmail = "recovery_email@email.com";
var clearList =  [];
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
var OnDeviceReady = function (evt)
{
    intel.xdk.display.useViewport(768, 1024);
    //lock the orientation of the application
    intel.xdk.device.setRotateOrientation("portrait");
    intel.xdk.device.setAutoRotate(false);
    intel.xdk.device.hideSplashScreen();
    if (intel.xdk.device.platform == "Android" && intel.xdk.device.osversion == "2.1")
    {
        intel.xdk.notification.alert("The appMobi push messaging commands require Android OS 2.2 or higher", "pushMobi Requirement", "OK");
    }
    else
    {
        //update the t-shirt message to be the last push message received
        if (intel.xdk.cache.getCookie("tshirtMessage") != undefined)
        {
            document.getElementById("spnShirtMessage").innerHTML = intel.xdk.cache.getCookie("tshirtMessage");
        }
        else
        {
            document.getElementById("spnShirtMessage").innerHTML = "Your push message here!";
        }
        //register the application to receive push messages
        RegisterForMessages();
    }
};
//This event handler captures the event indicating that appMobi is completely loaded
document.addEventListener("intel.xdk.device.ready", OnDeviceReady, false);
window.addEventListener("load", Init, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
//event that let's you know that the user's app is enabled to receive push
document.addEventListener("intel.xdk.notification.push.enable", NotificationsRegistered, false);
//register to be notified when a push message is received by the app
document.addEventListener("intel.xdk.notification.push.receive", UpdateNotifications, false);
//Two rich push msgs, can't be viewed at the same time
//register to be notified when a rich push message is closed (so that you can launch the next one)
document.addEventListener("intel.xdk.notification.push.rich.close", RichViewerClosed, false);
function Init(evt)
{
};
function RegisterForMessages()
{
    chosenUsername = intel.xdk.device.uuid;
    //set a default unique username for the purposes of push
    if (chosenUsername.indexOf("emulated") != -1)
    {
        intel.xdk.cache.removeCookie("pushmobi_username");
        chosenUsername = Rnd(99999);
    }
    //If this device is already registered, just check for new notifications
    if (intel.xdk.cache.getCookie("pushmobi_username") == undefined)
    {
        try
        {
            intel.xdk.notification.addPushUser(chosenUsername, chosenPassword, chosenEmail);
        }
        catch (e)
        {
            alert("error adding push user: " + e.message);
        }
    }
};
function NotificationsRegistered(evt)
{
    if (evt.success == false)
    {
        if (didcheckuser == false)
        {
            intel.xdk.notification.checkPushUser(chosenUsername, chosenPassword);
            didcheckuser = true;
        }
        else
        {
            alert("There was an error adding push notifications " + evt.message);
        }
        return;
    }
    else
    {
        //if the app successfully registered, it's good to save the user information
        //for pulling the right the messages that belong to this user. Then you
        //can prevent unnecessarily trying to re-register the app/user
        intel.xdk.cache.setCookie("pushmobi_username", chosenUsername, -1);
        intel.xdk.cache.setCookie("pushmobi_password", chosenPassword, -1);
        intel.xdk.cache.setCookie("pushmobi_email", chosenEmail, -1);
    }
    UpdateNotifications(evt);
};
function UpdateNotifications(evt)
{
    try
    {
        var myNotifications = intel.xdk.notification.getNotificationList();
        var len = myNotifications.length;
        for (var i = 0; i < len; i++)
        {
            //get the pushMobi message data
            var msgObj = intel.xdk.notification.getNotificationData(myNotifications[i]);
            //display the pushMobi message as a notification if there is no data
            if (msgObj.isRich == false)
            {
                //Is this a simple text push message?
                //update the style of the t-shirt text
                if (msgObj.data != "")
                {
                    document.getElementById("spnShirtMessage").style.cssText = msgObj.data;
                }
                console.log(document.getElementById("spnShirtMessage").style.cssText);
                //print the message on the t-shirt
                document.getElementById("spnShirtMessage").innerHTML = msgObj.msg;
                intel.xdk.cache.setCookie("tshirtMessage", msgObj.msg, -1);
                //message received
                intel.xdk.player.startAudio("images/small-bell-ring-01.mp3", false);
                document.getElementById("spnMessage").innerHTML = "Push Message Received";
                //Hide the status message after 6 seconds
                clearTimeout(msgTimeout);
                msgTimeout = setTimeout("HideMessage();", 6000);
                //remove the message from the server otherwise the app will 
                //think it has more messages waiting for it
                intel.xdk.notification.deletePushNotifications(msgObj.id);
            }
            else
            {
                //show rich push messages in the rich viewer
                intel.xdk.notification.showRichPushViewer(msgObj.id, 10, 10, 10, 10, 80, 80);
                break;
                // only one rich message at a time, will resume after RichViewerClosed
            }
        }
    }
    catch (e)
    {
        alert("error in UpdateNotifications: " + e.message);
    }
};
function RichViewerClosed(evt)
{
    //remove the message from the server
    intel.xdk.notification.deletePushNotifications(evt.id);
    // resume viewing push messages
    UpdateNotifications(evt);
};
function SendPushMessage(evt)
{
    //play a click
    intel.xdk.player.startAudio("images/click-5.mp3", false);
    //send the notification FROM the application TO the current user of the application
    intel.xdk.notification.sendPushNotification(chosenUsername, document.getElementById("txtMessage").value, "111");
    //clear the edit field and update the status message
    document.getElementById("txtMessage").value = "";
    document.getElementById("spnMessage").innerHTML = "Push Message Sent";
    //clear the status message after six seconds
    clearTimeout(msgTimeout);
    msgTimeout = setTimeout("HideMessage();", 6000);
};
function HideMessage()
{
    document.getElementById("spnMessage").innerHTML = "";
};
function Rnd(i)
{
    return Math.floor(Math.random() * i);
};
