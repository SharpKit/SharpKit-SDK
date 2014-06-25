//---------ConfirmationBox----------//

var divConfirmationBox = null;
var confirmationBox_OKCall = null;
var confirmationBox_CancelCall = null;
function confirmationBox_show(strPrompt, strTitle, strOKPrompt, strCancelPrompt, OKFunction, CancelFunction)
{
    //Defaults
    if (strPrompt == null)
    {
        strPrompt = "Would you like to confirm or cancel this action?";
    }
    if (strTitle == null)
    {
        strTitle = "Confirmation";
    }
    if (strOKPrompt == null)
    {
        strOKPrompt = "Confirm";
    }
    if (strCancelPrompt == null)
    {
        strCancelPrompt = "Cancel";
    }
    //create the hidden DIV to hold the confirmation box on load
    if (divConfirmationBox == null)
    {
        divConfirmationBox = document.createElement('div');
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
        divConfirmationBox.setAttribute("style", "border-radius:30px");
        document.getElementsByTagName('body')[0].appendChild(divConfirmationBox);
    }
    //set the confirmation box actions
    confirmationBox_OKCall = OKFunction;
    confirmationBox_CancelCall = CancelFunction;
    var tmpPopupHTML = "<table width=\'600\' height=\'400\'><tr><td colspan=\'2\' valign=\'top\'><span style=\'font-size:32pt;font-weight:bold;\'>" + strTitle + "</span></td></tr><tr><td colspan=\'2\' valign=\'middle\'>" + strPrompt + "</td></tr>";
    tmpPopupHTML += "<tr><td valign=\'bottom\' align=\'middle\' width=\'50%\' ontouchstart=\'eval(confirmationBox_OKCall);confirmationBox_hide();\'    ><div style=\'border-radius:30px;opacity:.95;border: solid 3px #aaa;background-color:#000;width:250px;font-size:28pt;font-weight:bold;padding-top:30px;padding-bottom:30px;margin-bottom:15px;\'>" + strOKPrompt + "</div></td>";
    tmpPopupHTML += "<td valign=\'bottom\' align=\'middle\' width=\'50%\' ontouchstart=\'eval(confirmationBox_CancelCall);confirmationBox_hide();\'><div style=\'border-radius:30px;opacity:.95;border: solid 3px #aaa;background-color:#000;width:250px;font-size:28pt;font-weight:bold;padding-top:30px;padding-bottom:30px;margin-bottom:15px;\'>" + strCancelPrompt + "</div></td></tr></table>";
    document.getElementById("divConfirmatonPopup").innerHTML = tmpPopupHTML;
    document.getElementById("divConfirmatonPopup").style.width = "600px";
    document.getElementById("divConfirmatonPopup").style.height = "400px";
    document.getElementById("divConfirmatonPopup").style.display = "block";
};
function confirmationBox_hide()
{
    confirmationBox_OKCall = null;
    confirmationBox_CancelCall = null;
    document.getElementById("divConfirmatonPopup").style.display = "none";
};
