//---------Global----------//
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
//initial event handler to detect when appMobi is ready to roll
document.addEventListener("intel.xdk.device.ready", OnDeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
document.addEventListener("intel.xdk.device.orientation.change", OnOrientation, false);
window.addEventListener("resize", OnResize, false);
function UpdateOrientation(orientation)
{
    var bg = document.getElementById("bg");
    var note = document.getElementById("note");
    var orient = document.getElementById("orient");
    if (orientation == 0 || orientation == 180)
    {
        bg.src = "app_bg_port.jpg";
        note.src = "note_port.png";
        note.style.top = "134px";
    }
    else
    {
        bg.src = "app_bg_ls.jpg";
        note.src = "note_ls.png";
        note.style.top = "102px";
    }
    orient.innerHTML = orientation;
    document.getElementById("body").style.visibility = "visible";
};
function OnResize(evt)
{
    SetHeightAndWidth();
};
function SetHeightAndWidth()
{
    var width = document.getElementById("width");
    var height = document.getElementById("height");
    var data = document.getElementById("data");
    var note = document.getElementById("note");
    var bg = document.getElementById("bg");
    width.innerHTML = window.innerWidth;
    height.innerHTML = window.innerHeight;
    data.style.top = ((window.innerWidth) / 3) + "px";
    note.style.left = ((window.innerWidth) / 4) + "px";
    //app_bg_ls.jpg is 1446x748, app_bg_ls.jpg is 768x1306
    //check if src ends with 'app_bg_ls.jpg'
    if (new RegExp("app_bg_ls.jpg$").test(bg.src))
    {
        bg.style.left = (((1446 - window.innerWidth) / 2) * -1) + "px";
    }
    else
    {
        bg.style.left = (((768 - window.innerWidth) / 2) * -1) + "px";
    }
};
function OnOrientation(evt)
{
    document.getElementById("body").style.visibility = "hidden";
    UpdateOrientation(evt.orientation);
    document.getElementById("orient").innerHTML = evt.orientation;
};
function OnDeviceReady(evt)
{
    UpdateOrientation(intel.xdk.device.initialOrientation);
    document.removeEventListener("intel.xdk.device.ready", OnDeviceReady, false);
    if (intel.xdk.device.platform == "Android")
    {
        intel.xdk.display.useViewport(768, 1446);
    }
    else
    {
        intel.xdk.display.useViewport(768, 1024);
    }
    SetHeightAndWidth();
    document.getElementById("body").style.visibility = "visible";
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
};
