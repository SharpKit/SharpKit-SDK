//---------Global----------//
var podcastRSSURL = "http://www.npr.org/rss/podcast.php?id=4499275";
var feedTimeout = 0;
var iPortraitWidth = 768;
var iLandscapeWidth = 1024;
var previousXMLData = null;
var xmlhttp = null;
var boolDebounce = false;
var PreventDefaultScroll = function (evt)
{
    evt.preventDefault();
    window.scroll(0, 0);
    return false;
};
//initial event handler to detect when appMobi is ready to roll
document.addEventListener("intel.xdk.device.ready", DeviceReady, false);
intel.xdk.multitouch.add(window.document, "touchmove", PreventDefaultScroll, false);
function DataFailed(xmlData)
{
    console.log("DataFailed");
    intel.xdk.notification.alert(xmlData, "Podcast Failure", "OK");
};
function DataLoaded(strRequestResponse)
{
    var parser = new DOMParser();
    var xmlData = parser.parseFromString(strRequestResponse, "text/xml");
     "xmlData.alltext = strRequestResponse";
    if (xmlData != null)
    {
        previousXMLData = xmlData;
    }
    else
    {
        xmlData = previousXMLData;
    }
    if (xmlData != null)
    {
        var outHTML = "";
        document.getElementById("podcastTitle").innerHTML = xmlData.getElementsByTagName("title")[0].childNodes[0].nodeValue;
        outHTML += "<table class=\"episodes\">";
        var nodeList;
        nodeList = xmlData.getElementsByTagName("channel");
        if (nodeList.length > 0)
        {
            for (var i = 0; i < nodeList.length; i++)
            {
                if ((nodeList[i]).getElementsByTagName("item").length >= 1)
                {
                    for (var ii = 0; ii < (nodeList[i]).getElementsByTagName("item").length; ii++)
                    {
                        var selNode = ((nodeList[i]).getElementsByTagName("item"))[ii];
                        var strTitle = "";
                        var strPodcastLink = "";
                        var strPodcastMP3 = "";
                        //JsString strNodeIcon = "";
                        for (var x = 0; x < selNode.childNodes.length; x++)
                        {
                            if (selNode.childNodes[x].nodeName == "title")
                            {
                                strTitle = selNode.childNodes[x].childNodes[0].nodeValue;
                            }
                            if (selNode.childNodes[x].nodeName == "enclosure")
                            {
                                strPodcastMP3 = (selNode.childNodes[x]).getAttribute("url");
                            }
                            if (selNode.childNodes[x].nodeName == "link")
                            {
                                strPodcastLink = selNode.childNodes[x].childNodes[0].nodeValue;
                            }
                        }
                        outHTML += "<table width=\"100%\" onclick=\"playPodcast(\'" + strPodcastMP3 + "\');\">";
                        outHTML += "<tr>";
                        outHTML += "<td class=\"ListItem\" align=\"left\" valign=\"middle\">";
                        outHTML += strTitle;
                        outHTML += "</td>";
                        outHTML += "</tr></table>";
                    }
                }
            }
            outHTML += "</table>";
            document.getElementById("podcastEpisodes").innerHTML = outHTML;
        }
    }
};
function PlayPodcast(podcastURL)
{
    try
    {
        if (boolDebounce == false)
        {
            boolDebounce = true;
            //load the podcast
            intel.xdk.player.playPodcast(podcastURL);
            setTimeout("boolDebounce = false", 5000);
        }
    }
    catch (e)
    {
        alert("error in playpodcast: " + e.message);
    }
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
    try
    {
        //for playing podcasts
        document.addEventListener("intel.xdk.player.audio.stop", OnPodcastComplete, false);
        document.addEventListener("intel.xdk.player.audio.error", OnPodcastError, false);
    }
    catch (e)
    {
    }
    //hide splash screen
    intel.xdk.device.hideSplashScreen();
    if (intel.xdk.device.appmobiversion != "3.2.4")
    {
        intel.xdk.device.getRemoteData(podcastRSSURL, "GET", "", "DataLoaded", "DataFailed");
    }
    else
    {
        //********* Use XMLHTTP on an error ***************
        try
        {
            var xmlhttp = new XMLHttpRequest();
            // instantiate it
            xmlhttp.addEventListener("readystatechange", function (evt_delegate)
            {
                if (xmlhttp.readyState == 4)
                {
                    if (xmlhttp.status == 200 || xmlhttp.responseText != "")
                    {
                        //XML file read, now parse it
                        DataLoaded(xmlhttp.responseText);
                    }
                }
            }, false);
            try
            {
                xmlhttp.open("GET", podcastRSSURL);
                // open server interface
            }
            catch (err)
            {
                alert("XMLHttpRequest.open() failed.\n" + err.message + " \n URL : " + podcastRSSURL);
                //Permission Denied
                return;
            }
            xmlhttp.send(null instanceof String ? null : null);
        }
        catch (err)
        {
            alert("Error initializing XMLHttpRequest.\n" + err);
            // show error
        }
        //***************************************
    }
};
function OnPodcastComplete(evt)
{
};
function OnPodcastError(evt)
{
};
