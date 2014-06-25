//---------Camera----------//

if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var objCamera =
{
    fullname: "objCamera",
    baseTypeName: "System.Object",
    staticDefinition:
    {
        cctor: function ()
        {
        }
    },
    assemblyName: "XdkDemo.HelloWorld",
    Kind: "Class",
    definition:
    {
        CapturePhoto: function (evt)
        {
            intel.xdk.camera.takePicture(50, false, "jpg", false);
        },
        OnCamera: function (evt)
        {
            switch (evt.type)
            {
                case "intel.xdk.camera.picture.add":
                    if (evt.success == true)
                    {
                        // create image 
                        var largeImage = document.getElementById("largeImage");
                        //show the filename in the console
                        console.log(evt.filename);
                        //save the image
                        largeImage.src = intel.xdk.camera.getPictureURL(evt.filename);
                        largeImage.style.width = "480px";
                        largeImage.style.display = "block";
                    }
                    else
                    {
                        if (evt.message != undefined)
                        {
                            alert(evt.message);
                        }
                        else
                        {
                            alert("error taking picture");
                        }
                    }
                    break;
                case "intel.xdk.camera.picture.busy":
                    console.log("busy");
                    break;
                case "intel.xdk.camera.picture.cancel":
                    console.log("canceled");
                    break;
            }
        },
        ImportPicture: function ()
        {
            intel.xdk.camera.importPicture();
        },
        ShowPictureList: function ()
        {
            var arrPictureList = intel.xdk.camera.getPictureList();
            if (arrPictureList.length > 1)
            {
                intel.xdk.camera.deletePicture(arrPictureList[0]);
                arrPictureList = intel.xdk.camera.getPictureList();
            }
            document.getElementById("largeImage").style.display = "none";
            for (var x = 0; x < arrPictureList.length; x++)
            {
                // create image 
                var newImage = document.createElement('img');
                newImage.src = intel.xdk.camera.getPictureURL(arrPictureList[x]);
                newImage.style.width = "100px";
                newImage.style.height = "100px";
                newImage.id = document.getElementById("img_" + arrPictureList[x]).id;
                document.body.appendChild(newImage);
            }
        },
        Init: function (objOptions)
        {
            document.addEventListener("intel.xdk.camera.picture.add", this.OnCamera, false);
            document.addEventListener("intel.xdk.camera.picture.busy", this.OnCamera, false);
            document.addEventListener("intel.xdk.camera.picture.cancel", this.OnCamera, false);
            console.log("camera object wrapper initialized");
            if (objOptions.inject != null)
            {
                //inject a div to display an image and a camera button
                var cameraDiv = document.createElement('div');
                cameraDiv.id = "cameradiv";
                document.body.appendChild(cameraDiv);
                var imgLarge = document.createElement('img');
                imgLarge.id = "largeImage";
                imgLarge.style.display = "none";
                document.getElementById("cameradiv").appendChild(imgLarge);
                var btnCapture = document.createElement('button');
                btnCapture.id = "btnPicture";
                btnCapture.innerText = "Take Picture";
                intel.xdk.multitouch.add(btnCapture, "touchstart", this.CapturePhoto, false);
                document.getElementById("cameradiv").appendChild(btnCapture);
            }
        }
    }
};
JsTypes.push(objCamera);
