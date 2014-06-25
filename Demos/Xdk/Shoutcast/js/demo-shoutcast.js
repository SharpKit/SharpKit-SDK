//---------Global----------//
var defaultColors = true;
var defaultPosition = true;
var boolPlaying = false;
var boolPaused = false;
var jazzUrl = "http://64.5.130.43:80/";
document.addEventListener("intel.xdk.device.ready", DeviceReadyListener, false);
document.addEventListener("intel.xdk.device.suspend", BackgroundListener, false);
document.addEventListener("intel.xdk.device.resume", BackgroundListener, false);
document.addEventListener("intel.xdk.player.hide", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.show", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.track.change", TrackChangeListener, false);
document.addEventListener("intel.xdk.player.shoutcast.start", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.shoutcast.play", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.shoutcast.pause", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.shoutcast.stop", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.shoutcast.busy", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.shoutcast.error", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.podcast.start", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.podcast.play", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.podcast.pause", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.podcast.stop", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.podcast.busy", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.podcast.error", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.station.start", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.station.play", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.station.pause", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.station.stop", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.station.busy", PlayerEventListener, false);
document.addEventListener("intel.xdk.player.station.error", PlayerEventListener, false);
function BuildMessage(evt)
{
    var msg = "";
    //System.Enum.GetName(typeof(XdkEventType), evt.type) + "bof";
    msg += "<br>";
    return msg;
};
function PrependToLog(log, message)
{
    var child = document.createElement('div');
    child.innerHTML = message;
    if (log.firstChild == null)
    {
        log.appendChild(child);
    }
    else
    {
        log.insertBefore(child, log.firstChild);
    }
};
function PlayerEventListener(evt)
{
    try
    {
        var log = document.getElementById("log");
        PrependToLog(log, BuildMessage(evt));
        var src_img_play = "";
        switch (evt.type)
        {
            case "intel.xdk.player.station.start":
            case "intel.xdk.player.shoutcast.start":
                src_img_play = "images/Pause.png";
                boolPlaying = true;
                break;
            case "intel.xdk.player.station.stop":
            case "intel.xdk.player.shoutcast.stop":
                src_img_play = "images/Play.png";
                boolPlaying = false;
                break;
            case "intel.xdk.player.station.pause":
            case "intel.xdk.player.shoutcast.pause":
                src_img_play = "images/Play.png";
                boolPaused = true;
                break;
        }
        document.getElementById("play").src = src_img_play;
    }
    catch (e)
    {
        alert("something bad happened in playerEventListener: " + e.message);
    }
};
function BackgroundListener(evt)
{
    try
    {
        var log = document.getElementById("log");
        PrependToLog(log, BuildMessage(evt));
        if (evt.type == "intel.xdk.device.resume")
        {
            PrependToLog(log, "lastPlaying: " + intel.xdk.device.lastPlaying);
        }
    }
    catch (e)
    {
        alert("something bad happened in playerEventListener: " + e.message);
    }
};
function TrackChangeListener(evt)
{
    try
    {
        var info = document.getElementById("trackInfo");
        info.innerHTML = "Artist: " + intel.xdk.playingTrack.artist + "<br>" + "Title: " + intel.xdk.playingTrack.title + "<br>" + "Album: " + intel.xdk.playingTrack.album + "<br>" + "<img src=\'" + intel.xdk.playingTrack.imageurl + "\'>";
    }
    catch (e)
    {
        alert("something bad happened in trackChangeListener: " + e.message);
    }
};
function SetColors()
{
    var btn = document.getElementById("btn16");
    if (defaultColors)
    {
        //red
        intel.xdk.player.setColors("FFC0C0", "C00000", "FF4040", "FF8080");
        btn.innerHTML = "Set progress blue";
    }
    else
    {
        //blue
        intel.xdk.player.setColors("C0C0FF", "0000C0", "4040FF", "8080FF");
        btn.innerHTML = "Set progress red";
    }
    defaultColors = !defaultColors;
};
function SetPosition()
{
    if (defaultPosition)
    {
        intel.xdk.player.setPosition(100, 100, 100, 100);
    }
    else
    {
        intel.xdk.player.setPosition(0, 0, 0, 0);
    }
    defaultPosition = !defaultPosition;
};
function AdjustVolume(delta)
{
    var volume = document.getElementById("volume");
    var volumeValue = parseInt(volume.innerHTML.substring(volume.innerHTML.lastIndexOf(":") + 1));
    volumeValue += delta;
    if (volumeValue >= 0 && volumeValue <= 100)
    {
        intel.xdk.player.volume(volumeValue);
        volume.innerHTML = "&nbsp;&nbsp;&nbsp;Volume: " + volumeValue;
    }
};
function SetVolume(volumeValue)
{
    var volume = document.getElementById("volume");
    intel.xdk.player.volume(volumeValue);
    volume.innerHTML = "&nbsp;&nbsp;&nbsp;Volume: " + volumeValue;
};
function DeviceReadyListener(evt)
{
    //use AppMobi viewport
    intel.xdk.display.useViewport(320, 480);
    //lock orientation
    intel.xdk.device.setRotateOrientation("portrait");
    intel.xdk.device.setAutoRotate(false);
    //manage power
    intel.xdk.device.managePower(true, false);
    SetVolume(100);
    if (intel.xdk.device.platform == "Android")
    {
        //fix the font on Android devices
        document.getElementById("log").style.fontFamily = "EurostileANDROID";
        document.getElementById("trackInfo").style.fontFamily = "EurostileANDROID";
        document.getElementById("volume").style.fontFamily = "EurostileANDROID";
    }
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
};
function CheckSel(obj)
{
    var ind = obj.selectedIndex;
};
function PlayButton()
{
    if (boolPlaying)
    {
        if (boolPaused == false)
        {
            intel.xdk.player.pause();
            document.getElementById("play").src = "images/Play.png";
        }
        else
        {
            intel.xdk.player.play();
            document.getElementById("play").src = "images/Pause.png";
        }
    }
    else
    {
        //start playing
        Music();
    }
};
function MusicShowPlayer()
{
    intel.xdk.player.startShoutcast(jazzUrl, true);
    intel.xdk.player.show();
};
function Music()
{
    intel.xdk.player.startShoutcast(jazzUrl, false);
};
function Disappear()
{
    document.getElementById("apDiv12").style.display = "none";
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
