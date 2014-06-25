//---------Global----------//
var iPortraitWidth = 768;
var iLandscapeWidth = 1024;
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
//initial event handler to detect when appMobi is ready to roll
document.addEventListener("intel.xdk.device.ready", DeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
function DeviceReady(evt)
{
    //use AppMobi viewport
    intel.xdk.display.useViewport(iPortraitWidth, iLandscapeWidth);
    //lock orientation
    intel.xdk.device.setRotateOrientation("portrait");
    intel.xdk.device.setAutoRotate(false);
    //manage power
    intel.xdk.device.managePower(true, false);
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
};
function DoRandomSound()
{
    console.log("in DoRandomSound", 4);
    try
    {
        if (Rnd(10) == 0)
        {
            intel.xdk.player.playSound("sounds/catmeow2.mp3");
        }
        else
        {
            intel.xdk.player.playSound("sounds/cowbell.mp3");
        }
    }
    catch (e)
    {
        console.log("error in DoRandomSound: " + e.message);
    }
};
function PlaySound()
{
    intel.xdk.player.playSound("sounds/cowbell.mp3");
    //AppMobi.player.PlaySound("sounds/catmeow2.mp3");
};
function Rnd(i)
{
    return Math.floor(Math.random() * i);
};
