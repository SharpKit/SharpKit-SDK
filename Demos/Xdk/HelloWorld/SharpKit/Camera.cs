using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.HelloWorld
{
    public class CameraOptions
    {
        public HtmlElement inject;
    }
    [JsType(OmitDefaultConstructor = true, OmitInheritance = true, ForceDelegatesAsNativeFunctions = true, Name = "objCamera", Filename = "../js/camera.js", OrderInFile = 1, PreCode = "//---------Camera----------//\n")]
    public class Camera : HtmlContext
    {

        public void CapturePhoto(TouchEvent evt)
        {
            Xdk.camera.TakePicture(50, false, XdkPictureType.Jpg);
        }

        public void OnCamera(XdkCameraEvent evt)
        {
            switch (evt.type)
            {
                case XdkCameraEventType.CameraPictureAdd:
                    if (evt.success == true)
                    {
                        // create image 
                        HtmlImageElement largeImage = HtmlImageElement.GetById("largeImage");

                        //show the filename in the console
                        console.Log(evt.filename);

                        //save the image
                        largeImage.src = Xdk.camera.GetPictureUrl(evt.filename);
                        largeImage.style.width = "480px";
                        largeImage.style.display = "block";
                    }
                    else
                    {
                        if (evt.message != undefined)
                        {
                            Alert(evt.message);
                        }
                        else
                        {
                            Alert("error taking picture");
                        }
                    }
                    break;
                case XdkCameraEventType.CameraPictureBusy:
                    console.Log("busy");
                    break;
                case XdkCameraEventType.CameraPictureCancel:
                    console.Log("canceled");
                    break;
            }
        }

        public void ImportPicture()
        {
            Xdk.camera.ImportPicture();
        }

        public void ShowPictureList()
        {
            JsArray<JsString> arrPictureList = Xdk.camera.GetPictureList();
            if (arrPictureList.length > 1)
            {
                Xdk.camera.DeletePicture(arrPictureList[0]);
                arrPictureList = Xdk.camera.GetPictureList();
            }
            Element.GetById("largeImage").style.display = "none";
            for (var x = 0; x < arrPictureList.length; x++)
            {
                // create image 
                HtmlImageElement newImage = new HtmlImageElement();
                newImage.src = Xdk.camera.GetPictureUrl(arrPictureList[x]);
                newImage.style.width = "100px";
                newImage.style.height = "100px";
                newImage.id = HtmlImageElement.GetById("img_" + arrPictureList[x]).id;
                document.body.AppendChild(newImage);
            }
        }

        public void Init(CameraOptions objOptions)
        {

            Xdk.OnCameraPictureAdd += OnCamera;
            Xdk.OnCameraPictureBusy += OnCamera;
            Xdk.OnCameraPictureCancel += OnCamera;

            console.Log("camera object wrapper initialized");

            if (objOptions.inject != null)
            {
                //inject a div to display an image and a camera button
                HtmlDivElement cameraDiv = new HtmlDivElement();
                cameraDiv.id = "cameradiv";
                document.body.AppendChild(cameraDiv);

                HtmlImageElement imgLarge = new HtmlImageElement();
                imgLarge.id = "largeImage";
                imgLarge.style.display = "none";
                Element.GetById("cameradiv").AppendChild(imgLarge);

                HtmlButtonElement btnCapture = new HtmlButtonElement();
                btnCapture.id = "btnPicture";
                btnCapture.innerText = "Take Picture";
                Xdk.multitouch.Add(btnCapture, TouchEventType.TouchStart, CapturePhoto);
                Element.GetById("cameradiv").AppendChild(btnCapture);
            }
        }
    }
}