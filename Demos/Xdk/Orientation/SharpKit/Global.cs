using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Orientation
{
    [JsType(GlobalObject = true, Filename = "../js/demo-orientation.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
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
            Xdk.OnDeviceReady += OnDeviceReady;
            Xdk.multitouch.Add(window.document, TouchEventType.TouchMove, PreventDefaultScroll);
            Xdk.OnDeviceOrientationChange += OnOrientation;
            window.AddEventListener("resize", OnResize, false);
        }

        public static void UpdateOrientation(int orientation)
        {
            HtmlImageElement bg = HtmlImageElement.GetById("bg");
            HtmlImageElement note = HtmlImageElement.GetById("note");
            HtmlElement orient = HtmlElement.GetById("orient");

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
            orient.innerHTML = orientation.As<JsString>();
            HtmlElement.GetById("body").style.visibility = "visible";
        }

        public static void OnResize(Event evt)
        {
            SetHeightAndWidth();
        }

        public static void SetHeightAndWidth()
        {
            HtmlElement width = HtmlElement.GetById("width");
            HtmlElement height = HtmlElement.GetById("height");
            HtmlElement data = HtmlElement.GetById("data");
            HtmlElement note = HtmlElement.GetById("note");
            HtmlImageElement bg = HtmlImageElement.GetById("bg");
            width.innerHTML = window.innerWidth.As<JsString>();
            height.innerHTML = window.innerHeight.As<JsString>();
            data.style.top = ((window.innerWidth) / 3) + "px";
            note.style.left = ((window.innerWidth) / 4) + "px";

            //app_bg_ls.jpg is 1446x748, app_bg_ls.jpg is 768x1306
            //check if src ends with 'app_bg_ls.jpg'
            if (new JsRegExp("app_bg_ls.jpg$").Test(bg.src))
            {
                bg.style.left = (((1446 - window.innerWidth) / 2) * -1) + "px";
            }
            else
            {
                bg.style.left = (((768 - window.innerWidth) / 2) * -1) + "px";
            }
        }

        public static void OnOrientation(XdkDeviceEvent evt)
        {
            HtmlElement.GetById("body").style.visibility = "hidden";
            UpdateOrientation(evt.orientation);
            HtmlElement.GetById("orient").innerHTML = evt.orientation.As<JsString>();
        }

        /// <summary>
        /// This event handler is fired once the AppMobi libraries are ready
        /// AppMobi is ready to roll
        /// </summary>
        /// <param name="evt"></param>
        public static void OnDeviceReady(XdkDeviceEvent evt)
        {
            UpdateOrientation(Xdk.device.initialOrientation);
            Xdk.OnDeviceReady -= OnDeviceReady;
            if (Xdk.device.platform == XdkDevicePlatformType.Android)
            {
                Xdk.display.UseViewport(768, 1446);
            }
            else
            {
                Xdk.display.UseViewport(768, 1024);
            }
            SetHeightAndWidth();
            HtmlElement.GetById("body").style.visibility = "visible";

            //hide splash screen
            Xdk.device.HideSplashScreen();
        }
    }
}