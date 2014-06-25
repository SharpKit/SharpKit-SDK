using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Shoutcast
{
    [JsType(GlobalObject = true, Filename = "../js/demo-shoutcast.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables
        public static bool defaultColors = true;
        public static bool defaultPosition = true;
        public static bool boolPlaying = false;
        public static bool boolPaused = false;
        public static JsString jazzUrl = "http://64.5.130.43:80/";
        #endregion

        static Global()
        {
            Xdk.OnDeviceReady += DeviceReadyListener;
            Xdk.OnDeviceSuspend += BackgroundListener;
            Xdk.OnDeviceResume += BackgroundListener;

            Xdk.OnPlayerHide += PlayerEventListener;
            Xdk.OnPlayerShow += PlayerEventListener;
            Xdk.OnPlayerTrackChange += TrackChangeListener;

            Xdk.OnPlayerShoutcastStart += PlayerEventListener;
            Xdk.OnPlayerShoutcastPlay += PlayerEventListener;
            Xdk.OnPlayerShoutcastPause += PlayerEventListener;
            Xdk.OnPlayerShoutcastStop += PlayerEventListener;
            Xdk.OnPlayerShoutcastBusy += PlayerEventListener;
            Xdk.OnPlayerShoutcastError += PlayerEventListener;

            Xdk.OnPlayerPodcastStart += PlayerEventListener;
            Xdk.OnPlayerPodcastPlay += PlayerEventListener;
            Xdk.OnPlayerPodcastPause += PlayerEventListener;
            Xdk.OnPlayerPodcastStop += PlayerEventListener;
            Xdk.OnPlayerPodcastBusy += PlayerEventListener;
            Xdk.OnPlayerPodcastError += PlayerEventListener;

            Xdk.OnPlayerStationStart += PlayerEventListener;
            Xdk.OnPlayerStationPlay += PlayerEventListener;
            Xdk.OnPlayerStationPause += PlayerEventListener;
            Xdk.OnPlayerStationStop += PlayerEventListener;
            Xdk.OnPlayerStationBusy += PlayerEventListener;
            Xdk.OnPlayerStationError += PlayerEventListener;

        }
        public static JsString BuildMessage(XdkEvent evt)
        {
            JsString msg = "";//System.Enum.GetName(typeof(XdkEventType), evt.type) + "bof";
            msg += "<br>";
            return msg;
        }

        public static void PrependToLog(HtmlElement log, JsString message)
        {
            HtmlDivElement child = new HtmlDivElement();
            child.innerHTML = message;
            if (log.firstChild == null)
            {
                log.AppendChild(child);
            }
            else
            {
                log.InsertBefore(child, log.firstChild);
            }
        }

        public static void PlayerEventListener(XdkPlayerEvent evt)
        {
            try
            {
                HtmlElement log = HtmlElement.GetById("log");
                PrependToLog(log, BuildMessage(evt));
                JsString src_img_play = "";
                switch (evt.type)
                {
                    case XdkPlayerEventType.PlayerStationStart:
                    case XdkPlayerEventType.PlayerShoutcastStart:
                        src_img_play = "images/Pause.png";
                        boolPlaying = true;
                        break;
                    case XdkPlayerEventType.PlayerStationStop:
                    case XdkPlayerEventType.PlayerShoutcastStop:
                        src_img_play = "images/Play.png";
                        boolPlaying = false;
                        break;
                    case XdkPlayerEventType.PlayerStationPause:
                    case XdkPlayerEventType.PlayerShoutcastPause:
                        src_img_play = "images/Play.png";
                        boolPaused = true;
                        break;
                }
                HtmlImageElement.GetById("play").src = src_img_play;
            }
            catch (JsError e)
            {
                Alert("something bad happened in playerEventListener: " + e.message);
            }
        }

        public static void BackgroundListener(XdkDeviceEvent evt)
        {
            try
            {
                HtmlElement log = HtmlElement.GetById("log");
                PrependToLog(log, BuildMessage(evt));
                if (evt.type == XdkDeviceEventType.DeviceResume)
                {
                    PrependToLog(log, "lastPlaying: " + Xdk.device.lastPlaying);
                }
            }
            catch (JsError e)
            {
                Alert("something bad happened in playerEventListener: " + e.message);
            }
        }

        public static void TrackChangeListener(XdkPlayerEvent evt)
        {
            try
            {
                HtmlElement info = HtmlElement.GetById("trackInfo");
                info.innerHTML =
                    "Artist: " + Xdk.playingtrack.artist + "<br>" +
                    "Title: " + Xdk.playingtrack.title + "<br>" +
                    "Album: " + Xdk.playingtrack.album + "<br>" +
                    "<img src='" + Xdk.playingtrack.imageUrl + "'>";
            }
            catch (JsError e)
            {
                Alert("something bad happened in trackChangeListener: " + e.message);
            }
        }

        public static void SetColors()
        {
            HtmlElement btn = HtmlElement.GetById("btn16");
            if (defaultColors)
            {
                //red
                Xdk.player.SetColors("FFC0C0", "C00000", "FF4040", "FF8080");
                btn.innerHTML = "Set progress blue";
            }
            else
            {
                //blue
                Xdk.player.SetColors("C0C0FF", "0000C0", "4040FF", "8080FF");
                btn.innerHTML = "Set progress red";
            }
            defaultColors = !defaultColors;
        }

        public static void SetPosition()
        {
            if (defaultPosition)
            {
                Xdk.player.SetPosition(100, 100, 100, 100);
            }
            else
            {
                Xdk.player.SetPosition(0, 0, 0, 0);
            }
            defaultPosition = !defaultPosition;
        }

        public static void AdjustVolume(int delta)
        {
            HtmlElement volume = HtmlElement.GetById("volume");
            int volumeValue = ParseInt(volume.innerHTML.Substring(volume.innerHTML.LastIndexOf(":") + 1));
            volumeValue += delta;
            if (volumeValue >= 0 && volumeValue <= 100)
            {
                Xdk.player.Volume(volumeValue);
                volume.innerHTML = "&nbsp;&nbsp;&nbsp;Volume: " + volumeValue;
            }
        }

        public static void SetVolume(int volumeValue)
        {
            HtmlElement volume = HtmlElement.GetById("volume");
            Xdk.player.Volume(volumeValue);
            volume.innerHTML = "&nbsp;&nbsp;&nbsp;Volume: " + volumeValue;
        }

        public static void DeviceReadyListener(XdkDeviceEvent evt)
        {
            //use AppMobi viewport
            Xdk.display.UseViewport(320, 480);

            //lock orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            //manage power
            Xdk.device.ManagePower(true, false);
            SetVolume(100);

            if (Xdk.device.platform == XdkDevicePlatformType.Android)
            {
                //fix the font on Android devices
                HtmlElement.GetById("log").style.fontFamily = "EurostileANDROID";
                HtmlElement.GetById("trackInfo").style.fontFamily = "EurostileANDROID";
                HtmlElement.GetById("volume").style.fontFamily = "EurostileANDROID";
            }

            //hide splash screen
            Xdk.device.HideSplashScreen();
        }


        public static void CheckSel(HtmlSelectElement obj)
        {
            int ind = obj.selectedIndex;
        }

        public static void PlayButton()
        {
            if (boolPlaying)
            {
                if (boolPaused == false)
                {
                    Xdk.player.Pause();
                    HtmlImageElement.GetById("play").src = "images/Play.png";
                }
                else
                {
                    Xdk.player.Play();
                    HtmlImageElement.GetById("play").src = "images/Pause.png";
                }
            }
            else
            {
                //start playing
                Music();
            }
        }

        public static void MusicShowPlayer()
        {
            Xdk.player.StartShoutcast(jazzUrl, true);
            Xdk.player.Show();
        }


        public static void Music()
        {
            Xdk.player.StartShoutcast(jazzUrl, false);
        }

        public static void Disappear()
        {
            HtmlElement.GetById("apDiv12").style.display = "none";
        }
    }
}