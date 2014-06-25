//---------Global----------//
var strChangeText = "This just in: Live Update can be used to change an application even after it has been installed from a device\'s application store!";
var applicationVersion = 1;
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
//initial event handler to detect when appMobi is ready to roll
document.addEventListener("intel.xdk.device.ready", DeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
//this event handler captures the event thrown when an update becomes available while an application is running
document.addEventListener("intel.xdk.device.update.available", UpdateAvailable, false);
function Init()
{
    document.getElementById("divTextBalloon").innerHTML = strChangeText;
};
function DeviceReady(evt)
{
    //use AppMobi.display.viewport to size the application to the appropriate width regardless of the device used
    intel.xdk.display.useViewport(768, 1024);
    //once the sizing is done, make the HTML body visible
    document.getElementById("bodyTag").style.visibility = "visible";
    //use AppMobi.device.setRotateOrientation to rotate the application to a certain orientation
    intel.xdk.device.setRotateOrientation("portrait");
    //use AppMobi.device.setAutoRotate to lock the rotation
    intel.xdk.device.setAutoRotate(false);
    //use AppMobi.device.managePower to keep the device from shutting off unexpectedly
    intel.xdk.device.managePower(true, false);
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
    /* OVER THE AIR UPDATE CODE*/
    if (intel.xdk.cache.getCookie("applicationVersion") == null)
    {
        //this is the initial installation
        intel.xdk.cache.setCookie("applicationVersion", applicationVersion, -1);
    }
    else
    {
        //the current application version is different from the previous one
        var previousVersion = ConvertStringToNumber(intel.xdk.cache.getCookie("applicationVersion"));
        if (previousVersion < applicationVersion)
        {
            //the previous version is lower than the application version installed with this code 
            intel.xdk.notification.alert("Application Updated Successfully");
            //save the cookie for the next time the application starts
            intel.xdk.cache.setCookie("applicationVersion", applicationVersion, -1);
        }
    }
    //appMobi.updateAvailable indicates whether or not an over the air update is available or not.
    if (intel.xdk.updateAvailable == true)
    {
        //there is an application update available at startup
        DoUpdateAvailable(intel.xdk.updateMessage);
    }
};
function UpdateAvailable(evt)
{
    if (evt.type == "intel.xdk.device.update.available")
    {
        //there is an update available *while* the application is running - just warn the user
        WarnUpdateAvailable(evt.updateMessage);
    }
};
function UpdateApplication(evt)
{
    // installs an update if one is available
    intel.xdk.device.installUpdate();
};
function UpdateApplicationLater()
{
    //add any code to indicate that the update has been postponed
};
function WarnUpdateAvailable(strUpdateMessage)
{
    if (strUpdateMessage == null)
    {
        strUpdateMessage = "Live Update Available";
    }
    strUpdateMessage += " - Touch Here To Update Application";
    document.getElementById("divFooter").innerHTML = strUpdateMessage;
    document.getElementById("divFooter").className = "marquee";
    document.getElementById("divFooter").addEventListener("click", UpdateApplication, false);
};
function DoUpdateAvailable(strUpdateMessage)
{
    if (strUpdateMessage == null)
    {
        strUpdateMessage = "Would you like to update this application?";
    }
    //there is an update available - ask the user whether they would like to install or not
    confirmationBox_show(strUpdateMessage, "Application Update Available", "Yes, update now", "I\'ll update later", "UpdateApplication()", "UpdateApplicationLater()");
    //Alternately, the developer could choose to force the update at this point 
    //by calling "AppMobi.device.installUpdate();".
};
function ConvertStringToNumber(str)
{
    try
    {
        return str / 1;
    }
    catch (e)
    {
        return 0;
    }
};
//---------Analytics----------//
function addAnalyticsDataPoint(eventID, queryString)
{
    try
    {
        if (queryString == null)
        {
            queryString = "";
        }
        intel.xdk.analytics.logPageEvent("/application/" + eventID + ".event", queryString, "", "GET", 0, "index.html");
    }
    catch (e)
    {
    }
};
//---------PushMobi----------//
/*
var clearList =  [];
var didcheckuser = false;
// Register for messages as soon as appMobi is loaded
document.addEventListener("intel.xdk.device.ready", RegisterForMessages, false);
document.addEventListener("intel.xdk.notification.push.rich.close", RichViewerClosed, false);
function RegisterForMessages(evt)
{
    //Get the unique identifier of this device
    var myUserID = intel.xdk.device.uuid;
    //Register the appMobi.notification.push.enable event
    document.addEventListener("intel.xdk.notification.push.enable", NotificationsRegistered, false);
    //If this device is already registered, just check for new notifications
    if (intel.xdk.cache.getCookie("username") === undefined)
    {
        try
        {
            //unremark this code to register this application for push messages
            var chosenUsername = prompt("Choose a username for push messaging", intel.xdk.device.uuid);
            var chosenPassword = prompt("Choose a password for push messaging", "password");
            var chosenEmail = prompt("Enter an email address for account confirmation", "");
            intel.xdk.cache.setCookie("username", chosenUsername, -1);
            intel.xdk.cache.setCookie("password", chosenPassword, -1);
            intel.xdk.cache.setCookie("email", chosenEmail, -1);
            intel.xdk.notification.addPushUser(chosenUsername, chosenPassword, chosenEmail);
        }
        catch (e)
        {
            alert("error adding push user: " + e.message);
        }
    }
    else
    {
        intel.xdk.notification.checkPushUser(intel.xdk.cache.getCookie("username"), intel.xdk.cache.getCookie("password"));
    }
};
function NotificationsRegistered(evt)
{
    if (evt.success === false)
    {
        if (didcheckuser == false)
        {
            intel.xdk.notification.checkPushUser(intel.xdk.device.uuid, "password");
            didcheckuser = true;
        }
        else
        {
            alert("There was an error adding push notifications " + evt.message);
        }
        return;
    }
    document.addEventListener("intel.xdk.notification.push.receive", UpdateNotifications, false);
    document.addEventListener("intel.xdk.notification.push.refresh", UpdateNotifications, false);
    UpdateNotifications(null);
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
            if (msgObj.richhtml === undefined && msgObj.richurl === undefined)
            {
                intel.xdk.notification.alert(msgObj.msg, "pushMobi Message", "OK");
                //remove the message from the server
                intel.xdk.notification.deletePushNotifications(msgObj.id);
            }
            else
            {
                intel.xdk.notification.showRichPushViewer(msgObj.id, 10, 10, 10, 10, 80, 80);
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
};
*/
