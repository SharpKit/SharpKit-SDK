/* CONFIRMATION BOX LIBRARY */

//the variable to hold the confirmation box DIV
var divConfirmationBox;
var confirmationBox_OKCall;
var confirmationBox_CancelCall;

function confirmationBox_show(strPrompt,strTitle,strOKPrompt, strCancelPrompt,OKFunction,CancelFunction) 
{
    //Defaults
    if (strPrompt==null){strPrompt="Would you like to confirm or cancel this action?";}
    if (strTitle==null){strTitle="Confirmation";}
    if (strOKPrompt==null){strOKPrompt="Confirm";}
    if (strCancelPrompt==null){strCancelPrompt="Cancel";}
    
    //create the hidden DIV to hold the confirmation box on load
    if (divConfirmationBox==null)
    {
        var divConfirmationBox=document.createElement("div");
        divConfirmationBox.setAttribute("id","divConfirmatonPopup");
        divConfirmationBox.setAttribute("style","display:none;background-color:#333;text-align:center;position:absolute;width:1px;height:1px;top:312px;left:84px;border-radius:30px;opacity:.8;border: solid 3px #aaa;font-size:24pt;overflow:hidden;");

        document.getElementsByTagName("body").item(0).appendChild(divConfirmationBox);
    }
    
    //set the confirmation box actions
    confirmationBox_OKCall=OKFunction;
    confirmationBox_CancelCall=CancelFunction;
    
    var tmpPopupHTML = "<table width='600' height='400'><tr><td colspan='2' valign='top'><span style='font-size:32pt;font-weight:bold;'>"+strTitle+"</span></td></tr><tr><td colspan='2' valign='middle'>"+strPrompt+"</td></tr>";
    tmpPopupHTML += "<tr><td valign='bottom' align='middle' width='50%' ontouchstart='eval(confirmationBox_OKCall);confirmationBox_hide();'    ><div style='border-radius:30px;opacity:.95;border: solid 3px #aaa;background-color:#000;width:250px;font-size:28pt;font-weight:bold;padding-top:30px;padding-bottom:30px;margin-bottom:15px;'>"+strOKPrompt+"</div></td>";
    tmpPopupHTML +=     "<td valign='bottom' align='middle' width='50%' ontouchstart='eval(confirmationBox_CancelCall);confirmationBox_hide();'><div style='border-radius:30px;opacity:.95;border: solid 3px #aaa;background-color:#000;width:250px;font-size:28pt;font-weight:bold;padding-top:30px;padding-bottom:30px;margin-bottom:15px;'>"+strCancelPrompt+"</div></td></tr></table>";


    document.getElementById("divConfirmatonPopup").innerHTML=tmpPopupHTML;
    document.getElementById("divConfirmatonPopup").style.width="600px";
    document.getElementById("divConfirmatonPopup").style.height="400px";
    document.getElementById("divConfirmatonPopup").style.display="block";   
}

function confirmationBox_hide() 
{
    confirmationBox_OKCall=null;
    confirmationBox_CancelCall=null;
    document.getElementById("divConfirmatonPopup").style.display="none";
}
