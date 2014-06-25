using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.LiveUpdates
{
    /// <summary>
    /// This snippet of code is a starting point for handling pushMobi Push Messages in 
    /// an appMobi application. Drop this javascript code into your application's <head>
    /// HTML tag to allow a user to log in and test basic push text messaging.
    /// </summary>
    [JsType(GlobalObject = true, Filename = "../js/confirmationBox.js", OrderInFile = 1, PreCode = "//---------ConfirmationBox----------//\n")]
    public class ConfirmationBox : HtmlContext
    {
        //the variable to hold the confirmation box DIV
        public static HtmlDivElement divConfirmationBox;
        public static JsString confirmationBox_OKCall;
        public static JsString confirmationBox_CancelCall;

        /// <summary>
        /// Global code
        /// </summary>
        static ConfirmationBox()
        {
        }

        [JsMethod(Name = "confirmationBox_show")]
        public static void Show(JsString strPrompt, JsString strTitle, JsString strOKPrompt, JsString strCancelPrompt, JsString OKFunction, JsString CancelFunction)
        {
            //Defaults
            if (strPrompt == null) { strPrompt = "Would you like to confirm or cancel this action?"; }
            if (strTitle == null) { strTitle = "Confirmation"; }
            if (strOKPrompt == null) { strOKPrompt = "Confirm"; }
            if (strCancelPrompt == null) { strCancelPrompt = "Cancel"; }

            //create the hidden DIV to hold the confirmation box on load
            if (divConfirmationBox == null)
            {
                divConfirmationBox = new HtmlDivElement();
                divConfirmationBox.id = "divConfirmatonPopup";
                divConfirmationBox.style.display = "none";
                divConfirmationBox.style.backgroundColor = "#333";
                divConfirmationBox.style.textAlign = "center";
                divConfirmationBox.style.position = "absolute";
                divConfirmationBox.style.width = "1px";
                divConfirmationBox.style.height = "1px";
                divConfirmationBox.style.top = "312px";
                divConfirmationBox.style.left = "84px";
                divConfirmationBox.style.opacity = ".8";
                divConfirmationBox.style.border = "solid 3px #aaa";
                divConfirmationBox.style.fontSize = "24px";
                divConfirmationBox.style.overflow = "hidden";
                //                divConfirmationBox.style.borderRadius = "30px";
                divConfirmationBox.SetAttribute("style", "border-radius:30px");
                HtmlBodyElement.GetByTagName()[0].AppendChild(divConfirmationBox);
            }

            //set the confirmation box actions
            confirmationBox_OKCall = OKFunction;
            confirmationBox_CancelCall = CancelFunction;

            JsString tmpPopupHTML = "<table width='600' height='400'><tr><td colspan='2' valign='top'><span style='font-size:32pt;font-weight:bold;'>" + strTitle + "</span></td></tr><tr><td colspan='2' valign='middle'>" + strPrompt + "</td></tr>";
            tmpPopupHTML += "<tr><td valign='bottom' align='middle' width='50%' ontouchstart='eval(confirmationBox_OKCall);confirmationBox_hide();'    ><div style='border-radius:30px;opacity:.95;border: solid 3px #aaa;background-color:#000;width:250px;font-size:28pt;font-weight:bold;padding-top:30px;padding-bottom:30px;margin-bottom:15px;'>" + strOKPrompt + "</div></td>";
            tmpPopupHTML += "<td valign='bottom' align='middle' width='50%' ontouchstart='eval(confirmationBox_CancelCall);confirmationBox_hide();'><div style='border-radius:30px;opacity:.95;border: solid 3px #aaa;background-color:#000;width:250px;font-size:28pt;font-weight:bold;padding-top:30px;padding-bottom:30px;margin-bottom:15px;'>" + strCancelPrompt + "</div></td></tr></table>";


            HtmlDivElement.GetById("divConfirmatonPopup").innerHTML = tmpPopupHTML;
            HtmlDivElement.GetById("divConfirmatonPopup").style.width = "600px";
            HtmlDivElement.GetById("divConfirmatonPopup").style.height = "400px";
            HtmlDivElement.GetById("divConfirmatonPopup").style.display = "block";
        }

        [JsMethod(Name = "confirmationBox_hide")]
        public static void Hide()
        {
            confirmationBox_OKCall = null;
            confirmationBox_CancelCall = null;
            HtmlDivElement.GetById("divConfirmatonPopup").style.display = "none";
        }
    }
}