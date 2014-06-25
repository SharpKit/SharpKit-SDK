//---------Global----------//
var iPortraitWidth = 768;
var iLandscapeWidth = 1024;
var boolSelected = false;
var dragItemHeight = 110;
var dragItemWidth = 90;
var imgOffset = dragItemWidth;
var movingItems = new Object();
var isMoving = false;
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
//initial event handler to detect when appMobi is ready to roll
document.addEventListener("intel.xdk.device.ready", DeviceReady, false);
// or, if DeviceReady as Event parameter (and not DeviceEvent):
// document.addEventListener(AppMobiEventType.DeviceReady, DeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
intel.xdk.multitouch.add(window.document, "touchmove", TouchMove, false);
intel.xdk.multitouch.add(window.document, "touchend", TouchEnd, false);
intel.xdk.multitouch.add(window.document, "touchstart", TouchStart, false);
function DeviceReady(evt)
{
    try
    {
        //user AppMobi viewport
        intel.xdk.display.useViewport(iPortraitWidth, iLandscapeWidth);
    }
    catch (e)
    {
    }
    try
    {
        //lock orientation
        intel.xdk.device.setRotateOrientation("portrait");
        intel.xdk.device.setAutoRotate(false);
    }
    catch (e)
    {
    }
    try
    {
        //manage power
        intel.xdk.device.managePower(true, false);
    }
    catch (e)
    {
    }
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
};
function Init()
{
    AddMovingItem("dragItem");
    AddMovingItem("dragItem2");
};
function TouchStart(evt)
{
    // With JQuery: $(document).bind("touchstart", function(e) {...}
    evt.preventDefault();
    var target_id = evt.target.id;
    if (isMoving == false && movingItems[target_id] == 1)
    {
        isMoving = true;
        //var orig = e.originalEvent;
        var orig = evt;
        var x = orig.touches[0].pageX - imgOffset;
        var y = orig.touches[0].pageY - imgOffset;
        //Set the item to moving, and update the position and zIndex
        movingItems[target_id] = 2;
        document.getElementById(target_id).style.top = y + "px";
        document.getElementById(target_id).style.left = x + "px";
        // With JQuery: $("#dragItem").css({top: y, left: x});
        document.getElementById(target_id).style.zIndex = "2000";
    }
};
function TouchMove(evt)
{
    // With JQuery: $(document).bind("touchmove", function(e) {...}
    evt.preventDefault();
    var target_id = evt.target.id;
    //Check that the target element is registered and flagged as moving
    if (movingItems[target_id] && movingItems[target_id] == 2)
    {
        //var orig = e.originalEvent;
        var orig = evt;
        if (orig.touches.length > 1)
            return;
        var x = orig.touches[0].pageX - imgOffset;
        var y = orig.touches[0].pageY - imgOffset;
        document.getElementById(target_id).style.top = y + "px";
        document.getElementById(target_id).style.left = x + "px";
        // With JQuery: $("#dragItem").css({top: y, left: x});
    }
};
function TouchEnd(evt)
{
    var target_id = evt.target.id;
    if (movingItems[target_id])
    {
        isMoving = false;
        //Deactivate the current moving object and set the zIndex to 1;
        movingItems[target_id] = 1;
        document.getElementById(target_id).style.zIndex = "2";
        for (var j in movingItems)
        {
            if (j != target_id)
            {
                document.getElementById(j).style.zIndex = "1";
            }
        }
    }
};
function AddMovingItem(ind)
{
    movingItems[ind] = 1;
};
//---------Analytics----------//
function AddAnalyticsDataPoint(eventID, queryString)
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
//---------Live Updates----------//
/* Live Updates */
/* If you decide to allow your application to handle Live Updates itself, 
this snippet will give you a starting point. Drop this javascript code 
into your application's <body> HTML tag to detect if an update has been 
successfully downloaded. */
document.addEventListener("intel.xdk.device.update.available", UpdateAvailable, false);
document.addEventListener("intel.xdk.device.ready", DeviceReadyTestForUpdate, false);
function UpdateAvailable(evt)
{
    /* test to see if the event is appMobi.device.update.available */
    if (evt.type == "intel.xdk.device.update.available")
    {
        /* there is an update available *while* the application is running - decide what to do */
        if (confirm(evt.updateMessage) == true)
        {
            UpdateApplication();
        }
        else
        {
            UpdateApplicationLater();
        }
    }
};
function DeviceReadyTestForUpdate(evt)
{
    /* appMobi.updateAvailable indicates whether or not an over the air update is available or not. */
    if (intel.xdk.updateAvailable == true)
    {
        //there is an application update available at startup
        if (confirm(intel.xdk.updateMessage) == true)
        {
            UpdateApplication();
        }
        else
        {
            UpdateApplicationLater();
        }
    }
};
function UpdateApplication()
{
    /* installs an update if one is available */
    intel.xdk.device.installUpdate();
};
function UpdateApplicationLater()
{
    /* add any code to indicate that the update has been postponed */
    alert("The update has been postponed");
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
