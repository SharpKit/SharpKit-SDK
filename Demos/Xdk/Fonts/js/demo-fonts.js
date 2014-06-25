//---------Global----------//
var arrFonts = new Object();
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
    try
    {
        //use AppMobi viewport
        intel.xdk.display.useViewport(320, 480);
        //lock orientation
        intel.xdk.device.setRotateOrientation("portrait");
        intel.xdk.device.setAutoRotate(false);
        //manage power
        intel.xdk.device.managePower(true, false);
    }
    catch (e)
    {
        alert(e.message);
    }
    var platform_suffix = intel.xdk.device.platform == "Android" ? "ANDROID" : "";
    arrFonts["ActionManRegular" + platform_suffix] = "Action Man";
    arrFonts["KitchenpoliceRegular" + platform_suffix] = "Kitchenpolice";
    arrFonts["ComfortaaRegular" + platform_suffix] = "Comfortaa";
    arrFonts["ProclamateLightLight" + platform_suffix] = "Proclamate Light";
    arrFonts["Furore" + platform_suffix] = "Furore";
    arrFonts["Letritista" + platform_suffix] = "Letritista";
    arrFonts["AnagramRegular" + platform_suffix] = "Anagram";
    arrFonts["CaslonCalligraphicInitialsReg" + platform_suffix] = "Caslon Calligraphic Initials";
    arrFonts["DeStencilNFRegular" + platform_suffix] = "DeStencil NF";
    arrFonts["KingthingsWroteRegular" + platform_suffix] = "Kingthings Wrote";
    arrFonts["KulminoituvaRegular" + platform_suffix] = "Kulminoituva";
    arrFonts["NervousRexRegular" + platform_suffix] = "Nervous Rex";
    arrFonts["NotethisRegular" + platform_suffix] = "Notethis";
    arrFonts["ProFontWindowsRegular" + platform_suffix] = "Pro Font Windows";
    arrFonts["RieslingRegular" + platform_suffix] = "Riseling";
    arrFonts["UpperEastSideRegular" + platform_suffix] = "Upper East Side";
    arrFonts["VeggieburgerRegular" + platform_suffix] = "Veggieburger";
    for (var i in arrFonts)
    {
        document.getElementById("ddFonts").innerHTML += "<option value=\'" + i + "\'>" + arrFonts[i] + "</option>";
    }
    //show splash screen
    intel.xdk.device.hideSplashScreen();
};
function ChangeFont()
{
    document.getElementById("txtSample").style.fontFamily = document.getElementById("ddFonts").value;
    document.getElementById("userinput").value = document.getElementById("ddFonts").options[document.getElementById("ddFonts").selectedIndex].text;
    ChangeText();
};
function ChangeText()
{
    document.getElementById("txtSample").innerHTML = document.getElementById("userinput").value;
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
