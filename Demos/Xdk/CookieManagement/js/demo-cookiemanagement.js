//---------Global----------//
//Define any global variables here
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
function Init()
{
};
function DeviceReady(evt)
{
    //user AppMobi viewport
    intel.xdk.display.useViewport(iPortraitWidth, iLandscapeWidth);
    //lock orientation
    intel.xdk.device.setRotateOrientation("portrait");
    intel.xdk.device.setAutoRotate(false);
    //manage power
    intel.xdk.device.managePower(true, false);
    //any app-specific initialization
    InitApp();
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
};
function InitApp()
{
    alert(window.devicePixelRatio);
    UpdateDropdown();
};
function UpdateDropdown()
{
    var select = document.getElementById("name");
    var selectedText = null;
    if (select.selectedIndex != -1)
    {
        selectedText = select.options[select.selectedIndex].text;
    }
    //remove all options
    for (var option in select.options)
    {
        select.remove(option);
    }
    //add all options
    var cookies = intel.xdk.cache.getCookieList();
    for (var i = 0; i < cookies.length; i++)
    {
        var option = new Option(cookies[i], intel.xdk.cache.getCookie(cookies[i]), true, true);
        select.add(option, null);
    }
    //set selected if it is still there
    if (selectedText != null)
    {
        for (var option in select.options)
        {
            if (option.text == selectedText)
            {
                option.selected = true;
                break;
            }
        }
    }
    ShowCookie();
};
function AddCookie()
{
    //add a cookie
    var name = prompt("Enter cookie name:");
    if (name.length == 0)
        return;
    var value = prompt("Enter cookie value:");
    var daysTillExpiry = prompt("Days until cookie expires (-1 for never):");
    try
    {
        intel.xdk.cache.setCookie(name, value, parseInt(daysTillExpiry));
    }
    catch (e)
    {
        alert("error in setCookie: " + e.message);
    }
    UpdateDropdown();
};
function DeleteCookie()
{
    //remove cookie, set background, play sound, then reset background
    var select = document.getElementById("name");
    if (select.selectedIndex != -1)
    {
        var name = select.options[select.selectedIndex].text;
        intel.xdk.cache.removeCookie(name);
        if (intel.xdk.player &&  intel.xdk.player.playSound)
        {
            intel.xdk.player.playSound("nomnomnom.mp3");
        }
        document.getElementById("cookiemonster").style.display = "block";
        setTimeout("document.getElementById(\'cookiemonster\').style.display=\'none\'", 2000);
        UpdateDropdown();
    }
    else
    {
        alert("nothing selected");
    }
};
function ShowCookie()
{
    //populate fields with cookie values
    var select = document.getElementById("name");
    if (select.selectedIndex != -1)
    {
        var selectedText = select.options[select.selectedIndex].text;
        document.getElementById("cookieValue").innerHTML = intel.xdk.cache.getCookie(selectedText);
    }
    else
    {
        document.getElementById("cookieValue").innerHTML = "";
    }
};
