//---------This is a general javascript library for miscellaneous useful functions----------//
//global variables
var iDebugLevel = 1;
var DbAlert = function (message, errorLevel)
{
    try
    {
        if (errorLevel == null)
        {
            alert(message);
        }
        else
        {
            if (errorLevel <= iDebugLevel)
            {
                alert(message);
            }
        }
    }
    catch (e)
    {
    }
};
var IsNumeric = function (val)
{
    if (isNaN(parseFloat(val)))
    {
        return false;
    }
    return true;
};
//---------QueryString----------//
function Querystring(qs)
{
    // optionally pass a querystring to parse
    this.params = new Object();
     "this.get = Querystring_get";
    if (qs == null)
        qs = location.search.substring(1, location.search.length);
    if (qs.length == 0)
        return;
    // Turn <plus> back to <space>
    // See: http://www.w3.org/TR/REC-html40/interact/forms.html#h-17.13.4.1
    qs = qs.replace(new RegExp("\\+", "g"), " ");
    var args = qs.split("&");
    // parse out name/value pairs separated via &
    // split out each name=value pair
    for (var i = 0; i < args.length; i++)
    {
        var value;
        var pair = args[i].split("=");
        var name = unescape(pair[0]);
        if (pair.length == 2)
            value = unescape(pair[1]);
        else
            value = name;
        this.params[name] = value;
    }
};
function Querystring_get(key, default_)
{
    // This silly looking line changes UNDEFINED to NULL
    if (default_ == null)
        default_ = null;
    var value = this.params[key];
    if (value == null)
        value = default_;
    return value;
};
//---------Global----------//
//global variables
var boolLightOn = false;
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
function LightSwitch()
{
    if (boolLightOn == true)
    {
        document.getElementById("off").style.visibility = "visible";
        document.getElementById("on").style.visibility = "hidden";
        document.body.style.backgroundColor = "black";
    }
    else
    {
        document.getElementById("on").style.visibility = "visible";
        document.getElementById("off").style.visibility = "hidden";
        document.body.style.backgroundColor = "white";
    }
    boolLightOn = !boolLightOn;
};
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
