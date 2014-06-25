//---------Global----------//
var timer = 0;
var portrait_width = 768;
var landscape_width = 1024;
var metatag = null;
var masthead = null;
var tabletop = null;
var label = null;
var container = null;
var current_left = 0;
var current_top = 0;
var absx = 0;
var absy = 0;
var dx = 0;
var dy = 0;
var x_ispos = 1;
var y_ispos = 1;
var o_width = portrait_width;
var o_height = landscape_width;
var labelleft = 0;
var canangle = 0;
var labeldirection = 1;
var lastangle = 0;
var nextrot = 0;
var vectangle = 0;
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
var Fail = function ()
{
};
var WatchAccel = function ()
{
    var opt = new intel.xdk.AccelerationOptions();
    opt.frequency = 5;
    //opt.frequency = 1000;
    timer = intel.xdk.accelerometer.watchAcceleration(Suc, opt);
};
//normally, global variables are discouraged. Here we use them for two reasons,
//1) the accelerometer readings are coming potentially 100s of times per second
// - allocating 15 variables 100s of times per second will be an unnecessary resource drain on slower device like gen1 iTouches
//2) webkit transforms just make an animation happen - THEY DON'T change the actual CSS position of 
//of an element that was animated. To keep track of the position a global variable is helpful (current_left, current_top)
//although we could accomplish this differently with a little more work.
//
//NOTE - we said right above that webkit animations don't reposition the an element as reported by CSS. 
//SO, why don't we then correct CSS's position? Because the can doesn't visually have time to repaint at it's pre-animation position
//given that we are doing an new webkit animation every 100th of a second based on
//accelerometer readings - so no need to 
//invoke the extra overhead of telling the DOM that the element is being repositioned constantly by resetting the CSS
//pixelLeft and pixelTop of the cokecan.
document.addEventListener("intel.xdk.device.ready", DeviceReady, false);
// or, if DeviceReady as Event parameter (and not DeviceEvent):
// document.AddEventListener(AppMobiEventType.DeviceReady, DeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
function RoundNumber(num)
{
    var dec = 2;
    var result = 100 * Math.round(num * Math.pow(10, dec)) / Math.pow(10, dec);
    return result;
};
function DoCanPhysics(a)
{
    x_ispos = 1;
    y_ispos = 1;
    //take the abs tilt values so we don't
    //get stupid results while doing interim
    //calculations
    absx = Math.abs(a.x);
    absy = Math.abs(a.y);
    if (absx < 0.1)
    {
        absx = 0;
    }
    if (absy < 0.1)
    {
        absy = 0;
    }
    //skip the calculations if there is no movement;
    if (absx == absy && absx == 0)
    {
        return;
    }
    //var opp;
    //var adj;
    //what is the angle of the vector of motion of the can?
    //first calc without regard to sign of the accelerometer vectors
    lastangle = vectangle;
    vectangle = Math.round(Math.atan2(a.y, a.x) * 180 / Math.PI);
    //        //ignore small variations in rotation so that the can doesn't shake incessantly
    //        if (lastangle > vectangle) {
    //            if (Math.abs(lastangle - vectangle) < 10) {
    //                vectangle = lastangle;
    //            }
    //        }
    //        else {
    //            if (Math.abs(vectangle - lastangle) < 10) {
    //                vectangle = lastangle;
    //            }
    //        }
    //now, adjust the arctan calculation for direction of the accel vectors
    //by adding the correct angle based on the quatrant
    // that the motion occurs in.
    //quadrant 1
    if (x_ispos > 0 && y_ispos > 0)
    {
        vectangle = 90 - vectangle;
    }
    else if (x_ispos > 0 && y_ispos < 0)
    {
        vectangle = 90 + vectangle;
    }
    else if (x_ispos < 0 && y_ispos < 0)
    {
        vectangle = 270 - vectangle;
    }
    else if (x_ispos < 0 && y_ispos > 0)
    {
        vectangle = 270 + vectangle;
    }
    //make the motion vect angle positive.
    if (vectangle < 0)
    {
        vectangle = (vectangle + 360) % 360;
    }
    //allow some accelerated movement based on how tilted the device is
    dx = Math.floor(Math.log(RoundNumber(absx) * 5));
    dx = Math.max(dx, 0);
    dy = Math.floor(Math.log(RoundNumber(absy) * 5));
    dy = Math.max(dy, 0);
    x_ispos = 1;
    y_ispos = 1;
    if (a.x < 0)
    {
        x_ispos = -1;
    }
    if (a.y < 0)
    {
        y_ispos = -1;
    }
    //now put back the sign
    dx = dx * x_ispos;
    dy = dy * y_ispos;
    //calculate can movements
    current_left += dx;
    current_top -= dy;
    canangle = (canangle + 360) % 360;
    var a1, a2, a3, a4, af;
    //a1 and a2 then can is within 90
    //a3 and a4 can is upside down relative to 
    //the motion vector
    labeldirection = 1;
    a1 = vectangle + 90 - canangle;
    //HtmlElement.GetById("accel_z").innerHTML = "case 1: " ;
    af = a1;
    a2 = vectangle - 90 - canangle;
    if (Math.abs(a2) < Math.abs(af))
    {
        af = a2;
        // HtmlElement.GetById("accel_z").innerHTML = "case 2: ";
    }
    a3 = vectangle + 90 - canangle + 180;
    if (Math.abs(a3) < Math.abs(af))
    {
        af = a3;
        //HtmlElement.GetById("accel_z").innerHTML = "case 3: ";
        labeldirection = -1;
    }
    a4 = vectangle - 90 - canangle + 180;
    if (Math.abs(a4) < Math.abs(af))
    {
        af = a4;
        // HtmlElement.GetById("accel_z").innerHTML = "case 4: a4 = " + a4 + "a3 = " + a3 + "a2 = " + a2 + "a1 = " + a1;
        labeldirection = -1;
    }
    if (af > 180)
    {
        af = -1 * (360 - af);
    }
    //HtmlElement.GetById("accel_y").innerHTML = "vectangle= " + vectangle + "; canangle=" + canangle + " rotpos=" + af; //  + "; rotneg=" + rotneg + "; nextrot=" + nextrot;
    // HtmlElement.GetById("accel_x").innerHTML = "a.x = " + a.x + ", a.y = " + a.y;
    //which way should the label spin?
    //it should spin right when moving at 90deg to the
    //motion vector, spin left when moving at 270deg
    if (canangle > vectangle)
    {
        labeldirection = -1;
    }
    if (Math.abs(canangle - vectangle) > 180)
    {
        labeldirection = labeldirection * -1;
    }
    //if the movement is right or down then the label and can is upright, label move left
    labelleft += labeldirection * Math.ceil(Math.sqrt(dx * dx + dy * dy));
    if (af > 3)
    {
        canangle++;
    }
    else if (af < -3)
    {
        canangle--;
    }
};
function Suc(a)
{
    //readings are from -1 to 1 (with 0 being equilibrium in a plane). Assumes holding in portrait mode
    //with screen pointed straight at your chest.
    //e.g. in the X plane -1 = tilted all the way left, 1 = tilted all the way right.
    //e.g. in the Y plane -1 = tilted all the way left, 1 = tilted all the way right.
    //  HtmlElement.GetById("accel_x").innerHTML = "a.x = " + a.x + ", a.y = " + a.y;
    DoCanPhysics(a);
    //make sure the can isn't off the screen
    current_left = Math.max(current_left, 0);
    current_top = Math.max(current_top, -100);
    current_left = Math.min(current_left, o_width - 100);
    current_top = Math.min(current_top, o_height - 200);
    //visible width of label on can is 164
    //total widht of label is 1074
    if (labelleft <= -910)
    {
        labelleft = -373;
    }
    if (labelleft >= 0)
    {
        labelleft = -537;
    }
    //labelleft = labelleft % 537;
    //basically, we're going to slide and rotate the can around on the screen based on the physics
    //computed in the previous funciton. The animation calls are really fairly simple ...
    //need to check that container and label have been initialized in case deviceready happens before load
     "if (container != null) container.style.webkitTransform = \"translate(\" + current_left + \"px, \" + current_top + \"px) rotate(\" + canangle + \"deg) scale(.85, .85)\"";
     "if (label != null) label.style.webkitTransform = \"translate(\" + labelleft + \"px, 0px)\"";
    //TODO	        if (container != null) container.style.webkitTransform = "translate(" + current_left + "px, " + current_top + "px) rotate(" + canangle + "deg) scale(.85, .85)";
    //TODO	        if (label != null) label.style.webkitTransform = "translate(" + labelleft + "px, 0px)";
};
function DeviceReady(evt)
{
    //use AppMobi viewport
    var landscapewidth = 1360;
    intel.xdk.display.useViewport(portrait_width, landscapewidth);
    //lock orientation
    intel.xdk.device.setRotateOrientation("portrait");
    intel.xdk.device.setAutoRotate(false);
    //manage power
    intel.xdk.device.managePower(true, false);
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
    WatchAccel();
};
function BodyLoad()
{
    metatag = document.getElementById("meta_view");
    label = document.getElementById("img_cokelabel");
    container = document.getElementById("div_cokecan");
    masthead = document.getElementById("img_masthead");
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
