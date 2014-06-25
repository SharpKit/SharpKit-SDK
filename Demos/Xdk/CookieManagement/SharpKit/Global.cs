using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.CookieManagement
{
    [JsType(GlobalObject = true, Filename = "../js/demo-cookiemanagement.js", OrderInFile = 1, PreCode = "//---------Global----------//\n//Define any global variables here")]
    public class Global : HtmlContext
    {
        #region Global variables
        public static int iPortraitWidth = 768;
        public static int iLandscapeWidth = 1024;
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

        /// <summary>
        /// This function runs once the page is loaded
        /// </summary>
        public static void Init()
        {
        }

        /// <summary>
        /// This event handler is fired once the AppMobi libraries are ready
        /// </summary>
        /// <returns></returns>
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            //user AppMobi viewport
            Xdk.display.UseViewport(iPortraitWidth, iLandscapeWidth);

            //lock orientation
            Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
            Xdk.device.SetAutoRotate(false);

            //manage power
            Xdk.device.ManagePower(true, false);

            //any app-specific initialization
            InitApp();

            //hide splash screen
            Xdk.device.HideSplashScreen();
        }

        //app functions

        public static void InitApp()
        {
            Alert(window.devicePixelRatio);

            UpdateDropdown();
        }

        public static void UpdateDropdown()
        {
            HtmlSelectElement select = HtmlSelectElement.GetById("name");
            JsString selectedText = null;
            if (select.selectedIndex != -1)
            {
                selectedText = select.options[select.selectedIndex].text;
            }
            //remove all options
            foreach (HtmlOptionElement option in select.options)
            {
                select.Remove(option);
            }
            //add all options
            JsArray<JsString> cookies = Xdk.cache.GetCookieList();
            for (int i = 0; i < cookies.length; i++)
            {
                HtmlOptionElement option = new HtmlOptionElement(cookies[i], Xdk.cache.GetCookie(cookies[i]), true, true);
                select.Add(option, null);
            }
            //set selected if it is still there
            if (selectedText != null)
            {
                foreach (HtmlOptionElement option in select.options)
                {
                    if (option.text == selectedText)
                    {
                        option.selected = true;
                        break;
                    }
                }
            }
            ShowCookie();
        }

        public static void AddCookie()
        {
            //add a cookie
            JsString name = Prompt("Enter cookie name:");
            if (name.length == 0) return;
            JsString value = Prompt("Enter cookie value:");
            JsString daysTillExpiry = Prompt("Days until cookie expires (-1 for never):");
            try
            {
                Xdk.cache.SetCookie(name, value, ParseInt(daysTillExpiry));
            }
            catch (JsError e)
            {
                Alert("error in setCookie: " + e.message);
            }
            UpdateDropdown();
        }

        public static void DeleteCookie()
        {
            //remove cookie, set background, play sound, then reset background
            HtmlSelectElement select = HtmlSelectElement.GetById("name");
            if (select.selectedIndex != -1)
            {
                JsString name = select.options[select.selectedIndex].text;
                Xdk.cache.RemoveCookie(name);
                if (Xdk.player.As<bool>() && NativeActionOf<JsString>(Xdk.player.PlaySound).As<bool>())
                {
                    Xdk.player.PlaySound("nomnomnom.mp3");
                }
                HtmlElement.GetById("cookiemonster").style.display = "block";
                SetTimeout("document.getElementById('cookiemonster').style.display='none'", 2000);
                UpdateDropdown();
            }
            else
            {
                Alert("nothing selected");
            }
        }

        public static void ShowCookie()
        {
            //populate fields with cookie values
            HtmlSelectElement select = HtmlSelectElement.GetById("name");
            if (select.selectedIndex != -1)
            {
                JsString selectedText = select.options[select.selectedIndex].text;
                HtmlSpanElement.GetById("cookieValue").innerHTML = Xdk.cache.GetCookie(selectedText);
            }
            else
            {
                HtmlSpanElement.GetById("cookieValue").innerHTML = "";
            }
        }


    }
}