using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Fonts
{
    [JsType(GlobalObject = true, Filename = "../js/demo-fonts.js", OrderInFile = 1, PreCode = "//---------Global----------//")]
    public class Global : HtmlContext
    {
        #region Global variables
        public static JsObject<JsString> arrFonts = new JsObject<JsString>();
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


        public static void Init()
        {
        }

        /// <summary>
        /// This event handler is fired once the AppMobi libraries are ready
        /// AppMobi is ready to roll
        /// </summary>
        /// <param name="evt"></param>
        public static void DeviceReady(XdkDeviceEvent evt)
        {
            try
            {
                //use AppMobi viewport
                Xdk.display.UseViewport(320, 480);

                //lock orientation
                Xdk.device.SetRotateOrientation(XdkDeviceOrientation.Portrait);
                Xdk.device.SetAutoRotate(false);

                //manage power
                Xdk.device.ManagePower(true, false);
            }
            catch (JsError e) { Alert(e.message); }

            JsString platform_suffix = Xdk.device.platform == XdkDevicePlatformType.Android ? "ANDROID" : "";

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

            foreach (JsString i in arrFonts)
            {
                HtmlElement.GetById("ddFonts").innerHTML += "<option value='" + i + "'>" + arrFonts[i] + "</option>";
            }
            //show splash screen
            Xdk.device.HideSplashScreen();
        }

        public static void ChangeFont()
        {
            HtmlElement.GetById("txtSample").style.fontFamily = HtmlSelectElement.GetById("ddFonts").value;
            HtmlTextAreaElement.GetById("userinput").value = HtmlSelectElement.GetById("ddFonts").options[HtmlSelectElement.GetById("ddFonts").selectedIndex].text;
            ChangeText();
        }

        public static void ChangeText()
        {
            HtmlElement.GetById("txtSample").innerHTML = HtmlTextAreaElement.GetById("userinput").value;
        }
    }
}