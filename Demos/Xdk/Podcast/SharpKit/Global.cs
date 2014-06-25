using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Podcast
{
    [JsType(GlobalObject = true, Filename = "../js/demo-podcast.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables
        //Frank DeFord's NPR Sports podcast
        public static JsString podcastRSSURL = "http://www.npr.org/rss/podcast.php?id=4499275";

        //Chinese History - English
        //public static JsString podcastRSSURL = "http://feeds.feedburner.com/chinahistorypodcast?format=xml";

        //World Football
        //public static JsString podcastRSSURL = "http://downloads.bbc.co.uk/podcasts/worldservice/wswf/rss.xml";

        //BBC - Chinese Podcast of the Day
        //public static JsString podcastRSSURL = "http://downloads.bbc.co.uk/podcasts/worldservice/podcastoftheday/rss.xml";

        public static int feedTimeout;

        public static int iPortraitWidth = 768;
        public static int iLandscapeWidth = 1024;

        public static Document previousXMLData;
        public static XMLHttpRequest xmlhttp = null;
        public static bool boolDebounce = false;
        #endregion

        #region Functions delegate
        //*** Prevent Default Scroll ******
        /// <summary>
        /// Prevent Default Scroll
        /// </summary>
        /// <param name="evt"></param>
        public static EventListener<TouchEvent> PreventDefaultScroll = delegate(TouchEvent evt)
        {
            evt.PreventDefault();
            window.Scroll(0, 0);
            @return(false);
        };
        #endregion

        /// <summary>
        /// Global code
        /// </summary>
        static Global()
        {
            //initial event handler to detect when appMobi is ready to roll
            Xdk.OnDeviceReady += DeviceReady;
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        }

        public static void DataFailed(JsString xmlData)
        {
            console.Log("DataFailed");
            Xdk.notification.Alert(xmlData, "Podcast Failure", "OK");
        }

        public static void DataLoaded(JsString strRequestResponse)
        {
            var parser = new DOMParser();
            Document xmlData = parser.ParseFromString(strRequestResponse, "text/xml");
            JsCode("xmlData.alltext = strRequestResponse");
            if (xmlData != null) { previousXMLData = xmlData; } else { xmlData = previousXMLData; }

            if (xmlData != null)
            {
                JsString outHTML = "";
                HtmlElement.GetById("podcastTitle").innerHTML = xmlData.GetElementsByTagName("title")[0].childNodes[0].nodeValue;

                outHTML += "<table class=\"episodes\">";

                NodeList nodeList;
                nodeList = xmlData.GetElementsByTagName("channel");

                if (nodeList.length > 0)
                {
                    for (int i = 0; i < nodeList.length; i++)
                    {
                        if ((nodeList[i] as Element).GetElementsByTagName("item").length >= 1)
                        {
                            for (int ii = 0; ii < (nodeList[i] as Element).GetElementsByTagName("item").length; ii++)
                            {
                                Node selNode = ((nodeList[i] as Element).GetElementsByTagName("item"))[ii];
                                JsString strTitle = "";
                                JsString strPodcastLink = "";
                                JsString strPodcastMP3 = "";
                                //JsString strNodeIcon = "";

                                for (int x = 0; x < selNode.childNodes.length; x++)
                                {
                                    if (selNode.childNodes[x].nodeName == "title")
                                    {
                                        strTitle = selNode.childNodes[x].childNodes[0].nodeValue;
                                    }

                                    if (selNode.childNodes[x].nodeName == "enclosure")
                                    {
                                        strPodcastMP3 = (selNode.childNodes[x] as Element).GetAttribute("url");
                                    }

                                    if (selNode.childNodes[x].nodeName == "link")
                                    {
                                        strPodcastLink = selNode.childNodes[x].childNodes[0].nodeValue;
                                    }
                                }
                                outHTML += "<table width=\"100%\" onclick=\"playPodcast('" + strPodcastMP3 + "');\">";

                                outHTML += "<tr>";

                                outHTML += "<td class=\"ListItem\" align=\"left\" valign=\"middle\">";
                                outHTML += strTitle;
                                outHTML += "</td>";
                                outHTML += "</tr></table>";
                            }
                        }
                    }
                    outHTML += "</table>";
                    HtmlElement.GetById("podcastEpisodes").innerHTML = outHTML;
                }
            }
        }

        public static void PlayPodcast(JsString podcastURL)
        {
            try
            {
                if (boolDebounce == false)
                {
                    boolDebounce = true;

                    //load the podcast
                    Xdk.player.PlayPodcast(podcastURL);
                    SetTimeout("boolDebounce = false", 5000);
                }
            }
            catch (JsError e) { Alert("error in playpodcast: " + e.message); }
        }


        //*** Device Ready Code *******************
        //This event handler is fired once the AppMobi libraries are ready
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            //use AppMobi viewport
            Xdk.display.UseViewport(iPortraitWidth, iLandscapeWidth);

            //lock orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            //manage power
            Xdk.device.ManagePower(true, false);

            try
            {
                //for playing podcasts
                Xdk.OnPlayerAudioStop += OnPodcastComplete;
                Xdk.OnPlayerAudioError += OnPodcastError;
            }
            catch (JsError e) { }

            //hide splash screen
            Xdk.device.HideSplashScreen();

            if (Xdk.device.appmobiVersion != "3.2.4")
            {
                Xdk.device.GetRemoteData(podcastRSSURL, GetPost.GET, "", "DataLoaded", "DataFailed");
            }
            else
            {
                //********* Use XMLHTTP on an error ***************
                try
                {
                    XMLHttpRequest xmlhttp = new XMLHttpRequest(); // instantiate it
                    xmlhttp.OnReadyStateChange += delegate(XMLHttpRequestEvent evt_delegate)
                    {
                        if (xmlhttp.readyState == XMLHttpRequestState.DONE)
                        {

                            if (xmlhttp.status == 200 || xmlhttp.responseText != "")
                            {
                                //XML file read, now parse it
                                DataLoaded(xmlhttp.responseText);
                            }
                        }
                    };
                    try
                    {
                        xmlhttp.Open(GetPost.GET, podcastRSSURL); // open server interface
                    }
                    catch (JsError err)
                    {
                        Alert("XMLHttpRequest.open() failed.\n" + err.message + " \n URL : " + podcastRSSURL); //Permission Denied
                        return;
                    }
                    xmlhttp.Send(@null as JsString);
                }
                catch (JsError err)
                {
                    Alert("Error initializing XMLHttpRequest.\n" + err); // show error
                }

                //***************************************
            }
        }



        //*** Audio Code ******************

        public static void OnPodcastComplete(XdkPlayerEvent evt)
        { }

        public static void OnPodcastError(XdkPlayerEvent evt)
        { }




    }
}