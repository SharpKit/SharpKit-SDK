//---------Global----------//
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
//initial event handler to detect when appMobi is ready to roll
document.addEventListener("intel.xdk.device.ready", DeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
window.addEventListener("load", Load, false);
function Init()
{
};
function Load(evt)
{
    var oldTC = "This sample has detected that you are not using the most up to date appMobi test container.  This sample\'s functionality may be compromised as a result.  Touch OK to continue. ";
    if (typeof(AppMobiInit) != "object")
        alert(oldTC);
};
function DeviceReady(evt)
{
    //use AppMobi viewport
    intel.xdk.display.useViewport(768, 1024);
    //lock orientation
    intel.xdk.device.setRotateOrientation("portrait");
    intel.xdk.device.setAutoRotate(false);
    //manage power
    intel.xdk.device.managePower(true, false);
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
};
function BeepOnce()
{
    try
    {
        intel.xdk.notification.beep(1);
    }
    catch (e)
    {
    }
};
function VibrateDevice()
{
    try
    {
        intel.xdk.notification.vibrate();
    }
    catch (e)
    {
    }
};
function Bark()
{
    try
    {
        intel.xdk.player.playSound("sounds/bark02.mp3");
    }
    catch (e)
    {
    }
};
function PlayDead()
{
    document.getElementById("shroud").style.display = "block";
};
function WakeUp()
{
    document.getElementById("shroud").style.display = "none";
};
