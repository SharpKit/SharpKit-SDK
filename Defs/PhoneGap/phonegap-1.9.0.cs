using System;
using SharpKit.JavaScript;

[assembly: JsNamespace(Namespace = "SharpKit.PhoneGap", JsNamespace = "")]
[assembly: JsType(JsMode.Prototype, Export = false)]

namespace SharpKit.PhoneGap
{
    /// <summary>
    /// Captures device motion in the x, y, and z direction.
    /// </summary>
    public class Accelerometer
    {
        /// <summary>
        /// Get the current acceleration along the x, y, and z axis.
        /// </summary>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param>
        /// <returns></returns>
        public object getCurrentAcceleration(JsAction<Acceleration> onSuccess, JsAction onError) { return null; }

        /// <summary>
        /// At a regular interval, get the acceleration along the x, y, and z axis.
        /// </summary>
        /// <param name="accelerometerSuccess">onSuccess callback function that provides the Acceleration information.</param>
        /// <param name="accelerometerError">onError callback function for acceleration functions.</param>
        /// <param name="accelerometerOptions">An optional parameter to customize the retrieval of the accelerometer.</param>
        /// <returns></returns>
        public object watchAcceleration(AccelerometerSuccess accelerometerSuccess, AccelerometerError accelerometerError, AccelerometerOptions accelerometerOptions) { return null; }

        /// <summary>
        /// At a regular interval, get the acceleration along the x, y, and z axis.
        /// </summary>
        /// <param name="accelerometerSuccess">onSuccess callback function that provides the Acceleration information.</param>
        /// <param name="accelerometerError">onError callback function for acceleration functions.</param>
        /// <returns></returns>
        public object watchAcceleration(AccelerometerSuccess accelerometerSuccess, AccelerometerError accelerometerError) { return null; }

        /// <summary>
        /// Stop watching the Acceleration referenced by the watch ID parameter.
        /// </summary>
        /// <param name="watchID"> The ID returned by accelerometer.watchAcceleration.</param>
        public void clearWatch(object watchID) { }

    }

    /// <summary>
    /// An optional parameter to customize the retrieval of the accelerometer.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AccelerometerOptions
    {
        public JsNumber frequency { get; set; }
    }
    /// <summary>
    /// onSuccess callback function that provides the Acceleration information.
    /// </summary>
    /// <param name="acceleration">The acceleration at a single moment in time</param>
    public delegate void AccelerometerSuccess(Acceleration acceleration);

    /// <summary>
    /// onError callback function for acceleration functions.
    /// </summary>
    public delegate void AccelerometerError();

    /// <summary>
    /// Contains Accelerometer data captured at a specific point in time.
    /// </summary>
    public class Acceleration
    {
        /// <summary>
        /// Amount of acceleration on the x-axis. (in m/s^2) (Number) 
        /// </summary>
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber z { get; set; }
        public JsNumber timestamp { get; set; }
    }
    /// <summary>
    /// The camera object provides access to the device's default camera application.
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Takes a photo using the camera or retrieves a photo from the device's album.
        /// The image is returned as a base64 encoded String or as the URI of an image file.
        /// </summary>
        /// <param name="cameraSuccess">onSuccess callback function that provides the image data.</param>
        /// <param name="cameraError">onError callback function that provides an error message.</param>
        /// <param name="cameraOptions">Optional parameters to customize the camera settings.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// navigator.camera.getPicture(onSuccess, onFail, { quality: 50,
        ///     destinationType: Camera.DestinationType.DATA_URL
        /// }); 
        /// function onSuccess(imageData) {
        ///     var image = document.getElementById('myImage');
        ///     image.src = "data:image/jpeg;base64," + imageData;
        /// }
        /// function onFail(message) {
        ///     alert('Failed because: ' + message);
        /// }
        /// </code>
        /// </example>
        public JsString getPicture(CameraSuccess cameraSuccess, JsAction cameraError, CameraOptions cameraOptions) { return null; }
        /// <summary>
        /// Takes a photo using the camera or retrieves a photo from the device's album.
        /// The image is returned as a base64 encoded String or as the URI of an image file.
        /// </summary>
        /// <param name="cameraSuccess">onSuccess callback function that provides the image data.</param>
        /// <param name="cameraError">onError callback function that provides an error message.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// navigator.camera.getPicture(onSuccess, onFail, { quality: 50,
        /// destinationType: Camera.DestinationType.DATA_URL
        /// }); 
        /// function onSuccess(imageData) {
        /// var image = document.getElementById('myImage');
        /// image.src = "data:image/jpeg;base64," + imageData;
        /// }
        /// function onFail(message) {
        /// alert('Failed because: ' + message);
        /// }
        /// </code>
        /// </example>
        public object getPicture(JsAction cameraSuccess, JsAction cameraError) { return null; }
        /// <summary>
        /// Cleans up the image files that were taken by the camera, that were stored in a temporary storage location
        /// </summary>
        /// <param name="cameraSuccess">onSuccess callback function that provides the image data.</param>
        /// <param name="cameraError">onError callback function that provides an error message.</param>
        /// <example>
        /// usage
        /// <code>
        /// navigator.camera.cleanup(onSuccess, onFail); 
        /// function onSuccess() {
        /// console.log("Camera cleanup success.")
        /// }
        /// function onFail(message) {
        /// alert('Failed because: ' + message);
        /// }
        /// </code>
        /// </example>
        public void cleanup(JsAction cameraSuccess, JsAction cameraError) { }
    }

    public delegate void CameraSuccess(object imageData);
    /// <summary>
    /// Optional parameters to customize the camera settings.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// { quality : 75, 
    /// destinationType : Camera.DestinationType.DATA_URL, 
    /// sourceType : Camera.PictureSourceType.CAMERA, 
    /// allowEdit : true,
    /// encodingType: Camera.EncodingType.JPEG,
    /// targetWidth: 100,
    /// targetHeight: 100,
    /// popoverOptions: CameraPopoverOptions,
    /// saveToPhotoAlbum: false };
    /// </code>
    /// </example>
    [JsType(JsMode.Json)]
    public class CameraOptions
    {
        /// <summary>
        /// Quality of saved image. Range is [0, 100]
        /// </summary>
        public JsNumber quality { get; set; }
        /// <summary>
        ///  Choose the format of the return value. Defined in navigator.camera.DestinationType
        /// </summary>
        public CameraDestinationType destinationType { get; set; }
        /// <summary>
        /// Set the source of the picture. Defined in nagivator.camera.PictureSourceType (Number)
        /// </summary>
        public CameraPictureSourceType sourceType { get; set; }
        /// <summary>
        /// Allow simple editing of image before selection
        /// </summary>
        public bool allowEdit { get; set; }
        /// <summary>
        /// Choose the encoding of the returned image file. Defined in navigator.camera.EncodingType
        /// </summary>
        public CameraEncodingType encodingType { get; set; }
        /// <summary>
        /// Width in pixels to scale image. Must be used with targetHeight. Aspect ratio is maintained.
        /// </summary>
        public JsNumber targetWidth { get; set; }
        /// <summary>
        /// Height in pixels to scale image. Must be used with targetWidth. Aspect ratio is maintained.
        /// </summary>
        public JsNumber targetHeight { get; set; }
        /// <summary>
        /// Set the type of media to select from. Only works when PictureSourceType is PHOTOLIBRARY or SAVEDPHOTOALBUM. Defined in nagivator.camera.MediaType
        /// </summary>
        public CameraMediaType mediaType { get; set; }
        /// <summary>
        /// Rotate the image to correct for the orientation of the device during capture
        /// </summary>
        public bool correctOrientation { get; set; }
        /// <summary>
        /// Save the image to the photo album on the device after capture
        /// </summary>
        public bool saveToPhotoAlbum { get; set; }
        /// <summary>
        /// iOS only options to specify popover location in iPad. Defined in CameraPopoverOptions
        /// </summary>
        public CameraPopoverOptions popoverOptions { get; set; }
    }

    /// <summary>
    /// Choose the format of the return value. Defined in navigator.camera.DestinationType (Number)
    /// </summary>
    [JsType(JsMode.Json)]
    public enum CameraDestinationType
    {
        /// <summary>
        ///  Return image as base64 encoded string
        /// </summary>
        DATA_URL = 0,
        /// <summary>
        /// Return image file URI
        /// </summary>
        FILE_URI = 1,
    }

    [JsType(JsMode.Json)]
    public enum CameraPictureSourceType
    {
        PHOTOLIBRARY = 0,
        CAMERA = 1,
        SAVEDPHOTOALBUM = 2
    }

    [JsType(JsMode.Json)]
    public enum CameraEncodingType
    {
        /// <summary>
        /// Return JPEG encoded image
        /// </summary>
        JPEG = 0,
        /// <summary>
        /// Return PNG encoded image
        /// </summary>
        PNG = 1,
    }

    [JsType(JsMode.Json)]
    public enum CameraMediaType
    {
        /// <summary>
        /// allow selection of still pictures only. DEFAULT. Will return format specified via DestinationType
        /// </summary>
        PICTURE = 0,
        /// <summary>
        /// allow selection of video only, WILL ALWAYS RETURN FILE_URI
        /// </summary>
        VIDEO = 1,
        /// <summary>
        /// allow selection from all media types
        /// </summary>
        ALLMEDIA = 2,
    }


    /// <summary>
    /// Parameters only used by iOS to specify the anchor element location and arrow direction
    /// of popover used on iPad when selecting images from the library or album.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// { x : 0, 
    /// y :  32,
    /// width : 320,
    /// height : 480,
    /// arrowDir : Camera.PopoverArrowDirection.ARROW_ANY
    /// };
    /// </code>
    /// </example>
    [JsType(JsMode.Json)]
    public class CameraPopoverOptions
    {
        /// <summary>
        ///  x pixel coordinate of element on the screen to anchor popover onto.
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y pixel coordinate of element on the screen to anchor popover onto.
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// width, in pixels, of the element on the screen to anchor popover onto
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        ///  height, in pixels, of the element on the screen to anchor popover onto
        /// </summary>
        public CameraPopoverArrowDirection height { get; set; }
        /// <summary>
        /// Direction the arrow on the popover should point. Defined in Camera.PopoverArrowDirection
        /// </summary>
        public JsNumber arrowDir { get; set; }
    }

    [JsType(JsMode.Json)]
    public enum CameraPopoverArrowDirection
    {
        /// <summary>
        /// matches iOS UIPopoverArrowDirection constants
        /// </summary>
        ARROW_UP = 1,
        ARROW_DOWN = 2,
        ARROW_LEFT = 4,
        ARROW_RIGHT = 8,
        ARROW_ANY = 15
    }

    /// <summary>
    /// Provides access to the audio, image, and video capture capabilities of the device.
    /// </summary>
    public class Capture
    {
        /// <summary>
        /// Start the audio recorder application and return information about captured audio clip file(s).
        /// </summary>
        /// <param name="captureSuccess">This method starts an asynchronous operation to capture audio recordings using the device's default audio recording application.
        /// The operation allows the device user to capture multiple recordings in a single session.</param>
        /// <param name="captureError">The capture operation ends when either the user exits the audio recording application,
        /// or the maximum number of recordings, specified by the limit parameter in CaptureAudioOptions, has been reached.
        /// If no value is provided for the limit parameter, a default value of one (1) is used, and the capture operation will terminate after the user records a single audio clip.</param>
        /// <param name="options">When the capture operation is finished, it will invoke the CaptureCB callback with an array of MediaFile objects describing each captured audio clip file.
        /// If the operation is terminated by the user before an audio clip is captured,
        /// the CaptureErrorCB callback will be invoked with a CaptureError object with the CaptureError.CAPTURE_NO_MEDIA_FILES error code.</param>
        /// <returns></returns>
        public void captureAudio(CaptureCB captureSuccess, CaptureErrorCB captureError, CaptureAudioOptions options) { }

        /// <summary>
        /// Start the audio recorder application and return information about captured audio clip file(s).
        /// </summary>
        /// <param name="captureSuccess">This method starts an asynchronous operation to capture audio recordings using the device's default audio recording application.
        /// The operation allows the device user to capture multiple recordings in a single session.</param>
        /// <param name="captureError">The capture operation ends when either the user exits the audio recording application,
        /// or the maximum number of recordings, specified by the limit parameter in CaptureAudioOptions, has been reached.
        /// If no value is provided for the limit parameter, a default value of one (1) is used, and the capture operation will terminate after the user records a single audio clip.</param>
        /// <returns></returns>
        public void captureAudio(CaptureCB captureSuccess, CaptureErrorCB captureError) { }

        /// <summary>
        /// Start the camera application and return information about captured image file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start image capture
        /// navigator.device.capture.captureImage(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureImage(CaptureCB captureSuccess, CaptureErrorCB captureError, CaptureImageOptions options) { }


        /// <summary>
        /// Start the camera application and return information about captured image file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start image capture
        /// navigator.device.capture.captureImage(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureImage(CaptureCB captureSuccess, CaptureErrorCB captureError) { }

        /// <summary>
        /// Start the video recorder application and return information about captured video clip file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start video capture
        /// navigator.device.capture.captureVideo(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureVideo(CaptureCB captureSuccess, CaptureErrorCB captureError, CaptureVideoOptions options) { }

        /// <summary>
        /// Start the video recorder application and return information about captured video clip file(s).
        /// </summary>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // capture callback
        /// var captureSuccess = function(mediaFiles) {
        /// var i, path, len;
        /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1) {
        /// path = mediaFiles[i].fullPath;
        /// // do something interesting with the file
        /// }
        /// };
        /// // capture error callback
        /// var captureError = function(error) {
        /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
        /// };
        /// // start video capture
        /// navigator.device.capture.captureVideo(captureSuccess, captureError, {limit:2});
        /// </code>
        /// </example>
        public void captureVideo(CaptureCB captureSuccess, CaptureErrorCB captureError) { }

    }

    /// <summary>
    /// Encapsulates audio capture configuration options
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // limit capture operation to 3 media files, no longer than 10 seconds each
    /// var options = { limit: 3, duration: 10 };
    /// navigator.device.capture.captureAudio(captureSuccess, captureError, options);
    /// </code>
    /// </example>
    [JsType(JsMode.Json)]
    public class CaptureAudioOptions
    {
        /// <summary>
        ///  The maximum number of audio clips the device user can record in a single capture operation.
        ///  The value must be greater than or equal to 1 (defaults to 1).
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        /// The maximum duration of an audio sound clip, in seconds.
        /// </summary>
        public JsNumber duration { get; set; }
        /// <summary>
        /// The selected audio mode. The value must match one of the elements in capture.supportedAudioModes.
        /// </summary>
        public JsNumber mode { get; set; }
    }

    public delegate void MediaFileDataSuccessCB(MediaFileData mediaFileData);
    public delegate void MediaFileDataErrorCB();

    /// <summary>
    /// Encapsulates image capture configuration options.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // limit capture operation to 3 images
    /// var options = { limit: 3 };
    /// navigator.device.capture.captureImage(captureSuccess, captureError, options);
    /// </code></example>
    [JsType(JsMode.Json)]
    public class CaptureImageOptions
    {
        /// <summary>
        ///  The maximum number of images the device user can capture in a single capture operation.
        ///  The value must be greater than or equal to 1 (defaults to 1).
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        ///  The selected image mode. The value must match one of the elements in capture.supportedImageModes.
        /// </summary>
        public JsNumber mode { get; set; }
    }

    /// <summary>
    /// Encapsulates video capture configuration options.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // limit capture operation to 3 video clips
    /// var options = { limit: 3 };
    /// navigator.device.capture.captureVideo(captureSuccess, captureError, options);
    /// </code></example>
    [JsType(JsMode.Json)]
    public class CaptureVideoOptions
    {
        /// <summary>
        ///  The maximum number of video clips the device user can capture in a single capture operation.
        ///  The value must be greater than or equal to 1 (defaults to 1).
        /// </summary>
        public JsNumber limit { get; set; }
        /// <summary>
        ///  The maximum duration of a video clip, in seconds.
        /// </summary>
        public JsNumber duration { get; set; }
        /// <summary>
        /// The selected video capture mode. The value must match one of the elements in capture.supportedVideoModes.
        /// </summary>
        public JsNumber mode { get; set; }
    }

    public class CaptureError
    {
        /// <summary>
        ///  One of the pre-defined error codes listed below
        /// </summary>
        public JsNumber code { get; set; }

        /// <summary>
        /// Camera or microphone failed to capture image or sound.
        /// </summary>
        public static CaptureError CAPTURE_INTERNAL_ERR { get; private set; }


        /// <summary>
        /// Camera application or audio capture application is currently serving other capture request.
        /// </summary>
        public static CaptureError CAPTURE_APPLICATION_BUSY { get; private set; }

        /// <summary>
        /// Invalid use of the API (e.g. limit parameter has value less than one).
        /// </summary>
        public static CaptureError CAPTURE_INVALID_ARGUMENT { get; private set; }

        /// <summary>
        /// User exited camera application or audio capture application before capturing anything.
        /// </summary>
        public static CaptureError CAPTURE_NO_MEDIA_FILES { get; private set; }

        /// <summary>
        /// he requested capture operation is not supported.
        /// </summary>
        public static CaptureError CAPTURE_NOT_SUPPORTED { get; private set; }

    }


    /// <summary>
    /// Invoked upon a successful media capture operation.
    /// </summary>
    /// <param name="mediaFiles"></param>
    /// <example>
    /// <code>
    /// // capture callback
    /// function captureSuccess(mediaFiles) {
    /// var i, path, len;
    /// for (i = 0, len = mediaFiles.length; i &lt; len; i += 1){
    /// path = mediaFiles[i].fullPath;
    /// do something interesting with the file
    /// }
    /// };
    /// </code></example>
    public delegate void CaptureCB(JsArray<MediaFile> mediaFiles);

    /// <summary>
    /// Invoked if an error occurs during a media capture operation.
    /// </summary>
    /// <param name="error"></param>
    /// <example>
    /// <code>
    /// // capture error callback
    /// var captureError = function(error) {
    /// navigator.notification.alert('Error code: ' + error.code, null, 'Capture Error');
    /// };
    /// </code>
    /// </example>
    public delegate void CaptureErrorCB(JsArray<CaptureError> error);

    /// <summary>
    /// Encapsulates a set of media capture parameters that a device supports.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // retrieve supported image modes
    /// var imageModes = navigator.device.capture.supportedImageModes;
    /// // Select mode that has the highest horizontal resolution
    /// var width = 0;
    /// var selectedmode;
    /// for each (var mode in imageModes) {
    /// if (mode.width > width) {
    /// width = mode.width;
    /// selectedmode = mode;
    /// }
    /// }
    /// </code>
    /// </example>
    public class ConfigurationData
    {
        /// <summary>
        /// The ASCII-encoded string in lower case representing the media type.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The height of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber height { get; set; }
        /// <summary>
        ///  The width of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber width { get; set; }
    }

    /// <summary>
    /// Encapsulates properties of a media capture file
    /// </summary>
    public class MediaFile
    {
        /// <summary>
        /// The name of the file, without path information
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The full path of the file, including the name.
        /// </summary>
        public JsString fullPath { get; set; }
        /// <summary>
        /// The mime type
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The date and time that the file was last modified
        /// </summary>
        public JsDate lastModifiedDate { get; set; }
        /// <summary>
        ///  The size of the file, in bytes.
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// Retrieves the format information of the media file.
        /// </summary>
        /// <param name="successCallback"></param>
        /// <param name="errorCallback"></param>
        public void getFormatData(MediaFileDataSuccessCB successCallback, MediaFileDataErrorCB errorCallback) { }
        /// <summary>
        /// Retrieves the format information of the media file.
        /// </summary>
        /// <param name="successCallback"></param>
        public void getFormatData(MediaFileDataSuccessCB successCallback) { }

    }

    /// <summary>
    /// Encapsulates format information about a media file.
    /// </summary>
    public class MediaFileData
    {
        /// <summary>
        /// The actual format of the audio and video content
        /// </summary>
        public JsString codecs { get; set; }
        /// <summary>
        ///  The average bitrate of the content. In case of an image, this attribute has value 0. (Number)
        /// </summary>
        public JsNumber bitrate { get; set; }
        /// <summary>
        ///  The height of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber height { get; set; }
        /// <summary>
        ///   The width of the image or video in pixels. In the case of a sound clip, this attribute has value 0.
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        ///  The length of the video or sound clip in seconds. In the case of an image, this attribute has value 0
        /// </summary>
        public JsNumber duration { get; set; }
    }

    /// <summary>
    /// Obtains the direction that the device is pointing.
    /// </summary>
    public class Compass
    {


        /// <summary>
        /// The compass is a sensor that detects the direction or heading that the device is pointed. It measures the heading in degrees from 0 to 359.99.
        /// The compass heading information is returned via a CompassHeading object using the compassSuccess callback function.
        /// </summary>
        /// <param name="compassSuccess">onSuccess callback function that provides the compass heading information via a compassHeading object.</param>
        /// <param name="compassError">onError callback function for compass functions.</param>
        /// <param name="compassOptions">An optional parameter to customize the retrieval of the compass.</param>
        /// <example>
        /// uage
        /// <code>
        /// function onSuccess(heading) {
        /// //    alert('Heading: ' + heading.magneticHeading);
        /// //};
        /// //function onError(error) {
        /// //    alert('CompassError: ' + error.code);
        /// //};
        /// //navigator.compass.getCurrentHeading(onSuccess, onError);
        /// </code>
        /// </example>
        public void getCurrentHeading(compassSuccess compassSuccess, CompassError compassError, CompassOptions compassOptions) { }
        /// <summary>
        /// At a regular interval, get the compass heading in degrees.
        /// </summary>
        /// <param name="compassSuccess">onSuccess callback function that provides the compass heading information via a compassHeading object.</param>
        /// <param name="compassError">onError callback function for compass functions.</param>
        /// <param name="compassOptions">An optional parameter to customize the retrieval of the compass.</param>
        /// <example>
        /// uage
        /// <code>
        /// function onSuccess(heading) {
        ///    var element = document.getElementById('heading');
        ///    element.innerHTML = 'Heading: ' + heading.magneticHeading;
        ///};
        ///function onError(compassError) {
        ///        alert('Compass error: ' + compassError.code);
        ///};
        ///var options = { frequency: 3000 };  // Update every 3 seconds
        ///var watchID = navigator.compass.watchHeading(onSuccess, onError, options);
        /// </code>
        /// </example>
        public JsString watchHeading(compassSuccess compassSuccess, CompassError compassError, CompassOptions compassOptions) { return null; }
        /// <summary>
        /// Stop watching the compass referenced by the watch ID parameter.
        /// </summary>
        /// <param name="watchID"> The ID returned by compass.watchHeading.</param>
        /// <example>
        /// usage
        /// <code>
        /// var watchID = navigator.compass.watchHeading(onSuccess, onError, options);
        /// // ... later on ...
        /// navigator.compass.clearWatch(watchID);
        /// </code>
        /// </example>
        public void clearWatch(JsString watchID) { }
    }

    /// <summary>
    /// A CompassHeading object is returned to the compassSuccess callback function when an error occurs
    /// </summary>
    public class compassHeading
    {
        /// <summary>
        ///  The heading in degrees from 0 - 359.99 at a single moment in time.
        /// </summary>
        public JsNumber magneticHeading { get; set; }
        /// <summary>
        /// The heading relative to the geographic North Pole in degrees 0 - 359.99 at a single moment in time.
        /// A negative value indicates that the true heading could not be determined.
        /// </summary>
        public JsNumber trueHeading { get; set; }
        /// <summary>
        ///  The deviation in degrees between the reported heading and the true heading.
        /// </summary>
        public JsNumber headingAccuracy { get; set; }
        /// <summary>
        /// The time at which this heading was determined. (milliseconds)
        /// </summary>
        public JsNumber timestamp { get; set; }
    }
    public delegate void compassSuccess(JsArray<compassHeading> heading);
    public delegate void compassError(JsArray<CompassError> error);

    /// <summary>
    /// A CompassError object is returned to the compassError callback function when an error occurs.
    /// </summary>
    public class CompassError
    {
        /// <summary>
        /// One of the predefined error codes listed below.
        /// </summary>
        public JsCode code { get; set; }
        public static CompassError COMPASS_INTERNAL_ERR { get; private set; }
        public static CompassError COMPASS_NOT_SUPPORTED { get; private set; }
    }

    /// <summary>
    /// An optional parameter to customize the retrieval of the compass.
    /// </summary>
    [JsType(JsMode.Json)]
    public class CompassOptions
    {
        /// <summary>
        ///  How often to retrieve the compass heading in milliseconds.(Default: 100)
        /// </summary>
        public JsNumber frequency { get; set; }
        /// <summary>
        ///  The change in degrees required to initiate a watchHeading success callback
        /// </summary>
        public JsNumber filter { get; set; }

    }

    /// <summary>
    /// The connection object gives access to the device's cellular and wifi connection information.
    /// </summary>
    public class Connection
    {
        public Connection type { get; set; }
        public static Connection UNKNOWN { get; private set; }
        public static Connection ETHERNET { get; private set; }
        public static Connection WIFI { get; private set; }
        public static Connection CELL_2G { get; private set; }
        public static Connection CELL_3G { get; private set; }
        public static Connection CELL_4G { get; private set; }
        public static Connection NONE { get; private set; }

    }

    /// <summary>
    /// Contains properties that describe a contact, such as a user's personal or business contact
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// A globally unique identifier
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// The name of this Contact, suitable for display to end-users.
        /// </summary>
        public JsString displayName { get; set; }
        /// <summary>
        ///  An object containing all components of a persons name.
        /// </summary>
        public ContactName name { get; set; }
        /// <summary>
        ///  A casual name to address the contact by
        /// </summary>
        public JsString nickname { get; set; }
        /// <summary>
        ///  An array of all the contact's phone numbers.
        /// </summary>
        public JsArray<ContactField> phoneNumbers { get; set; }
        /// <summary>
        /// An array of all the contact's email addresses
        /// </summary>
        public JsArray<ContactField> emails { get; set; }
        /// <summary>
        /// An array of all the contact's addresses
        /// </summary>
        public JsArray<ContactAddress> addresses { get; set; }
        /// <summary>
        ///  An array of all the contact's IM addresses
        /// </summary>
        public JsArray<ContactField> ims { get; set; }
        /// <summary>
        /// An array of all the contact's organizations.
        /// </summary>
        public JsArray<ContactOrganization> organizations { get; set; }
        /// <summary>
        /// The birthday of the contact.
        /// </summary>
        public JsDate birthday { get; set; }
        /// <summary>
        /// A note about the contact.
        /// </summary>
        public JsString note { get; set; }
        /// <summary>
        ///  An array of the contact's photos.
        /// </summary>
        public JsArray<ContactField> photos { get; set; }
        /// <summary>
        /// An array of all the contacts user defined categories.
        /// </summary>
        public JsArray<ContactField> categories { get; set; }
        /// <summary>
        /// An array of web pages associated to the contact.
        /// </summary>
        public JsArray<ContactField> urls { get; set; }
        /// <summary>
        /// Returns a new Contact object that is a deep copy of the calling object, with the id property set to null.
        /// </summary>
        /// <returns></returns>
        public Contact clone() { return null; }
        /// <summary>
        /// Removes the contact from the device contacts database. An error callback is called with a ContactError object if the removal is unsuccessful.
        /// </summary>
        public void remove() { }
        /// <summary>
        /// Saves a new contact to the device contacts database, or updates an existing contact if a contact with the same id already exists.
        /// </summary>
        public void save() { }



    }

    /// <summary>
    /// Contains name properties of a Contact object
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// function onSuccess(contacts) {
    ///    for (var i=0; i &lt;contacts.length; i++) {
    ///        alert("Formatted: " + contacts[i].name.formatted + "\n" + 
    ///                "Family Name: "  + contacts[i].name.familyName + "\n" + 
    ///                "Given Name: "  + contacts[i].name.givenName + "\n" + 
    ///                "Middle Name: "  + contacts[i].name.middleName + "\n" + 
    ///                "Suffix: "  + contacts[i].name.honorificSuffix + "\n" + 
    ///                "Prefix: "  + contacts[i].name.honorificSuffix);
    ///    }
    ///};
    ///function onError(contactError) {
    ///    alert('onError!');
    ///};
    ///var options = new ContactFindOptions();
    ///options.filter="";
    ///filter = ["displayName","name"];
    ///navigator.contacts.find(filter, onSuccess, onError, options);
    /// </code>
    /// </example>
    public class ContactName
    {
        /// <summary>
        /// The complete name of the contact.
        /// </summary>
        public JsString formatted { get; set; }
        /// <summary>
        ///  The contacts family name.
        /// </summary>
        public JsString familyName { get; set; }
        /// <summary>
        ///  The contacts given name
        /// </summary>
        public JsString givenName { get; set; }
        /// <summary>
        /// The contacts middle name.
        /// </summary>
        public JsString middleName { get; set; }
        /// <summary>
        /// The contacts prefix (example Mr. or Dr.)
        /// </summary>
        public JsString honorificPrefix { get; set; }
        /// <summary>
        ///  The contacts suffix (example Esq.).
        /// </summary>
        public JsString honorificSuffix { get; set; }

    }

    /// <summary>
    /// Supports generic fields in a Contact object. Some properties that are stored as ContactField objects include email addresses, phone numbers, and urls.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // create a new contact
    ///var contact = navigator.contacts.create();
    /// // store contact phone numbers in ContactField[]
    ///var phoneNumbers = [];
    ///phoneNumbers[0] = new ContactField('work', '212-555-1234', false);
    ///phoneNumbers[1] = new ContactField('mobile', '917-555-5432', true); // preferred number
    ///phoneNumbers[2] = new ContactField('home', '203-555-7890', false);
    ///contact.phoneNumbers = phoneNumbers;
    /// // save the contact
    ///contact.save();
    /// </code>
    /// </example>
    public class ContactField
    {
        /// <summary>
        /// A string that tells you what type of field this is (example: 'home'). 
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The value of the field (such as a phone number or email address).
        /// </summary>
        public JsString value { get; set; }
        /// <summary>
        /// Set to true if this ContactField contains the user's preferred value.
        /// </summary>
        public bool pref { get; set; }
    }

    /// <summary>
    /// Contains address properties for a Contact object.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // display the address information for all contacts
    ///function onSuccess(contacts) {
    ///    for (var i=0; i &lt;contacts.length; i++) {
    ///        for (var j=0; j &lt;contacts[i].addresses.length; j++) {
    ///            alert("Pref: " + contacts[i].addresses[j].pref + "\n" +
    ///                    "Type: " + contacts[i].addresses[j].type + "\n" +
    ///                    "Formatted: " + contacts[i].addresses[j].formatted + "\n" + 
    ///                    "Street Address: "  + contacts[i].addresses[j].streetAddress + "\n" + 
    ///                    "Locality: "  + contacts[i].addresses[j].locality + "\n" + 
    ///                    "Region: "  + contacts[i].addresses[j].region + "\n" + 
    ///                    "Postal Code: "  + contacts[i].addresses[j].postalCode + "\n" + 
    ///                    "Country: "  + contacts[i].addresses[j].country);
    ///        }
    ///    }
    ///};
    ///function onError(contactError) {
    ///    alert('onError!');
    ///};
    /// // find all contacts
    ///var options = new ContactFindOptions();
    ///options.filter=""; 
    ///var filter = ["displayName","addresses"];
    ///navigator.contacts.find(filter, onSuccess, onError, options);
    /// </code>
    /// </example>
    public class ContactAddress
    {
        /// <summary>
        /// Set to true if this ContactAddress contains the user's preferred value.
        /// </summary>
        public bool pref { get; set; }
        /// <summary>
        ///  A string that tells you what type of field this is (example: 'home')
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The full address formatted for display
        /// </summary>
        public JsString formatted { get; set; }
        /// <summary>
        /// The full street address.
        /// </summary>
        public JsString streetAddress { get; set; }
        /// <summary>
        /// The city or locality
        /// </summary>
        public JsString locality { get; set; }
        /// <summary>
        /// The state or region.
        /// </summary>
        public JsString region { get; set; }
        /// <summary>
        ///  The zip code or postal code.
        /// </summary>
        public JsString postalCode { get; set; }
        /// <summary>
        /// The country name.
        /// </summary>
        public JsString country { get; set; }

    }

    /// <summary>
    /// Contains organization properties of a Contact object.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// function onSuccess(contacts) {
    ///    for (var i=0; i &lt;contacts.length; i++) {
    ///        for (var j=0; j&lt;contacts[i].organizations.length; j++) {
    ///            alert("Pref: " + contacts[i].organizations[j].pref + "\n" +
    ///                    "Type: " + contacts[i].organizations[j].type + "\n" +
    ///                    "Name: " + contacts[i].organizations[j].name + "\n" + 
    ///                    "Department: "  + contacts[i].organizations[j].department + "\n" + 
    ///                    "Title: "  + contacts[i].organizations[j].title);
    ///        }
    ///    }
    ///};
    ///function onError(contactError) {
    ///    alert('onError!');
    ///};
    ///var options = new ContactFindOptions();
    ///options.filter="";
    ///filter = ["displayName","organizations"];
    ///navigator.contacts.find(filter, onSuccess, onError, options);
    /// </code>
    /// </example>
    public class ContactOrganization
    {
        /// <summary>
        /// Set to true if this ContactOrganization contains the user's preferred value.
        /// </summary>
        public bool pref { get; set; }
        /// <summary>
        ///  A string that tells you what type of field this is (example: 'home').
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The name of the organization
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The department the contract works for.
        /// </summary>
        public JsString department { get; set; }
        /// <summary>
        /// The contacts title at the organization. 
        /// </summary>
        public JsString title { get; set; }
    }

    /// <summary>
    /// Contains properties that can be used to filter the results of a contacts.find operation.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// // success callback
    ///function onSuccess(contacts) {
    ///    for (var i=0; i &lt;contacts.length; i++) {
    ///        alert(contacts[i].displayName);
    ///    }
    ///};
    /// // error callback
    ///function onError(contactError) {
    ///    alert('onError!');
    ///};
    /// // specify contact search criteria
    ///var options = new ContactFindOptions();
    ///options.filter="";          // empty search string returns all contacts
    ///options.multiple=true;      // return multiple results
    ///filter = ["displayName"];   // return contact.displayName field
    /// // find contacts
    ///navigator.contacts.find(filter, onSuccess, onError, options);
    /// </code>
    /// </example>
    [JsType(JsMode.Json)]
    public class ContactFindOptions
    {
        /// <summary>
        /// The search string used to find contacts.(Default: "")
        /// </summary>
        public JsString filter { get; set; }
        /// <summary>
        ///  Determines if the find operation should return multiple contacts. (Default: false)
        /// </summary>
        public bool multiple { get; set; }

    }

    /// <summary>
    /// A ContactError object is returned to the contactError callback when an error occurs.
    /// </summary>
    public class ContactError
    {
        /// <summary>
        /// One of the predefined error codes listed below.
        /// </summary>
        public JsCode code { get; set; }

        public static ContactError UNKNOWN_ERROR { get; private set; }

        public static ContactError INVALID_ARGUMENT_ERROR { get; private set; }

        public static ContactError TIMEOUT_ERROR { get; private set; }

        public static ContactError PENDING_OPERATION_ERROR { get; private set; }

        public static ContactError IO_ERROR { get; private set; }

        public static ContactError NOT_SUPPORTED_ERROR { get; private set; }

        public static ContactError PERMISSION_DENIED_ERROR { get; private set; }


    }
    /// <summary>
    /// The contact array resulting from a find operation. (Contact)
    /// </summary>
    /// <param name="contacts"></param>
    public delegate void ContactSuccess(JsArray<Contact> contacts);
    /// <summary>
    /// Error callback function for contact functions.
    /// </summary>
    /// <param name="error"></param>
    public delegate void ContactErrorCB(JsArray<CompassError> error);

    /// <summary>
    /// The contacts object provides access to the device contacts database.
    /// </summary>
    public class Contacts
    {
        /// <summary>
        /// contacts.create is a synchronous function that returns a new Contact object.
        /// This method does not persist the Contact object to the device contacts database. To persist the Contact object to the device, invoke the Contact.save method.
        /// </summary>
        /// <param name="properties"></param>
        /// <returns>Contains properties that describe a contact, such as a user's personal or business contact</returns>
        /// <example>
        /// usage
        /// <code>
        /// var myContact = navigator.contacts.create({"displayName": "Test User"});
        /// </code>
        /// </example>
        public Contact create(object properties) { return null; }

        /// <summary>
        /// Queries the device contacts database and returns one or more Contact objects, each containing the fields specified.
        /// </summary>
        /// <param name="contactFields">Contact fields to be used as search qualifier. Only these fields will have values in the resulting Contact objects. [Required]</param>
        /// <param name="contactSuccess">Success callback function that is invoked with the contacts returned from the contacts database. [Required]</param>
        /// <param name="contactError">Error callback function. Invoked when error occurs. [Optional]</param>
        /// <param name="contactFindOptions">Search options to filter contacts. [Optional]</param>
        /// <returns>Contains properties that describe a contact, such as a user's personal or business contact.</returns>
        public Contact find(JsArray<JsString> contactFields, ContactSuccess contactSuccess, ContactError contactError, ContactFindOptions contactFindOptions) { return null; }
    }

    /// <summary>
    /// The device object describes the device's hardware and software.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Get the device's model name.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Android:    Nexus One       returns "Passion" (Nexus One code name)
        /// //             Motorola Droid  returns "voles"
        /// // BlackBerry: Torch 9800      returns "9800"
        /// // iPhone:     All devices     returns a name set by iTunes e.g. "Joe's iPhone"
        /// //
        ///var name = device.name;
        /// </code>
        /// </example>
        public JsString name { get; set; }

        /// <summary>
        /// Get the version of Cordova running on the device.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// var name = device.cordova;
        /// </code>
        /// </example>
        public JsString cordova { get; set; }

        /// <summary>
        /// Get the device's operating system name.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Depending on the device, a few examples are:
        /// //   - "Android"
        /// //   - "BlackBerry"
        /// //   - "iPhone"
        /// //   - "webOS"
        /// //   - "WinCE"
        ///var devicePlatform = device.platform;
        /// </code>
        /// </example>
        public JsString platform { get; set; }

        /// <summary>
        /// Get the device's Universally Unique Identifier (UUID=Universally unique identifier).
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Android: Returns a random 64-bit integer (as a string, again!)
        /// //          The integer is generated on the device's first boot
        /// //
        /// // BlackBerry: Returns the PIN number of the device
        /// //             This is a nine-digit unique integer (as a string, though!)
        /// //
        /// // iPhone: (Paraphrased from the UIDevice Class documentation)
        /// //         Returns a string of hash values created from multiple hardware identifies.
        /// //         It is guaranteed to be unique for every device and cannot be tied
        /// //         to the user account.
        /// // Windows Phone 7 : Returns a hash of device+current user, 
        /// // if the user is not defined, a guid is generated and will persist until the app is uninstalled
        /// // 
        /// // webOS: returns the device NDUID
        ///var deviceID = device.uuid;
        /// </code>
        /// </example>
        public JsString uuid { get; set; }

        /// <summary>
        /// Get the operating system version
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Android:    Froyo OS would return "2.2"
        /// //             Eclair OS would return "2.1", "2.0.1", or "2.0"
        /// //             Version can also return update level "2.1-update1" 
        /// //
        /// // BlackBerry: Torch 9800 using OS 6.0 would return "6.0.0.600"
        /// //
        /// // iPhone:     iOS 3.2 returns "3.2"
        /// //
        /// // Windows Phone 7: returns current OS version number, ex. on Mango returns 7.10.7720
        /// // webOS: webOS 2.2.4 return 2.2.4
        ///var deviceVersion = device.version;
        /// </code>
        /// </example>
        public JsString version { get; set; }



    }

    /// <summary>
    /// This object represents a directory on a file system. It is defined in the W3C Directories and Systems specification.
    /// </summary>
    public class DirectoryEntry : Entry
    {
        /// <summary>
        /// Always false.
        /// </summary>
        public bool isFile { get; set; }
        /// <summary>
        /// Always true.
        /// </summary>
        public bool isDirectory { get; set; }
        /// <summary>
        /// The name of the DirectoryEntry, excluding the path leading to it.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The full absolute path from the root to the DirectoryEntry. 
        /// </summary>
        public JsString fullPath { get; set; }
        /// <summary>
        ///  The file system on which the DirectoryEntry resides.
        /// </summary>
        public FileSystem filesystem { get; set; }

        /// <summary>
        /// Look up metadata about a directory.
        /// </summary>
        /// <param name="successCallback"> A callback that is called with a Metadata object.</param>
        /// <param name="errorCallback"> A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(metadata) {
        ///    console.log("Last Modified: " + metadata.modificationTime);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        /// // Request the metadata object for this entry
        ///entry.getMetadata(success, fail);
        /// </code></example>
        public void getMetadata(JsAction<Metadata> successCallback, JsAction errorCallback) { }

        /// <summary>
        /// Set metadata on a directory. Only works on iOS currently - this will set the extended attributes of a directory.
        /// </summary>
        /// <param name="successCallback">A callback that is called when the metadata was successfully set.</param>
        /// <param name="errorCallback"> A callback that is called when the metadata was not successfully set</param>
        /// <param name="metadataObject">An object that contains the metadata keys and values</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success() {
        ///    console.log("The metadata was successfully set.");
        ///}
        ///function fail() {
        ///    alert("There was an error in setting the metadata");
        ///}
        /// // Set the metadata
        ///entry.setMetadata(success, fail, { "com.apple.MobileBackup": 1});
        /// </code>
        /// </example>
        public void setMetadata(JsAction successCallback, JsAction errorCallback, Metadata metadataObject) { }

        /// <summary>
        /// Move a directory to a different location on the file system. It is an error to attempt to:
        ///move a directory inside itself or to any child at any depth;
        ///move a directory into its parent if a name different from its current one is not provided;
        ///move a directory to a path occupied by a file;
        ///move a directory to a path occupied by a directory which is not empty.
        ///In addition, an attempt to move a directory on top of an existing empty directory must attempt to delete and replace that directory.
        /// </summary>
        /// <param name="parent">The parent directory to which to move the directory.</param>
        /// <param name="newName"> The new name of the directory. Defaults to the current name if unspecified</param>
        /// <param name="successCallback">A callback that is called with the DirectoryEntry object of the new directory</param>
        /// <param name="errorCallback">A callback that is called if an error occurs when attempting to move the directory. Invoked with a FileError object.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(entry) {
        ///    console.log("New Path: " + entry.fullPath);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        ///function moveDir(entry) {
        ///    var parent = document.getElementById('parent').value,
        ///        parentName = parent.substring(parent.lastIndexOf('/')+1),
        ///        newName = document.getElementById('newName').value,
        ///        parentEntry = new DirectoryEntry(parentName, parent);
        ///    // move the directory to a new directory and rename it
        ///    entry.moveTo(parentEntry, newName, success, fail);
        ///}
        /// </code>
        /// </example>
        public void moveTo(DirectoryEntry parent, JsString newName, JsAction<FileEntry> successCallback, JsAction errorCallback) { }

        /// <summary>
        /// Copy a directory to a different location on the file system. It is an error to attempt to:
        /// copy a directory inside itself at any depth;
        /// copy a directory into its parent if a name different from its current one is not provided.
        /// Directory copies are always recursive - that is, they copy all contents of the directory.
        /// </summary>
        /// <param name="parent">The parent directory to which to copy the directory.</param>
        /// <param name="newName">The new name of the directory. Defaults to the current name if unspecified.</param>
        /// <param name="successCallback">A callback that is called with the DirectoryEntry object of the new directory.</param>
        /// <param name="errorCallback"> A callback that is called if an error occurs when attempting to copy the underlying directory. Invoked with a FileError object</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function win(entry) {
        ///    console.log("New Path: " + entry.fullPath);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        ///function copyDir(entry) {
        ///    var parent = document.getElementById('parent').value,
        ///        parentName = parent.substring(parent.lastIndexOf('/')+1),
        ///        newName = document.getElementById('newName').value,
        ///        parentEntry = new DirectoryEntry(parentName, parent);
        ///    // copy the directory to a new directory and rename it
        ///    entry.copyTo(parentEntry, newName, success, fail);
        ///}
        /// </code>
        /// </example>
        public void copyTo(DirectoryEntry parent, JsString newName, JsAction<FileEntry> successCallback, JsAction errorCallback) { }

        /// <summary>
        /// Returns a URL that can be used to locate the file.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // Request the URL for this entry
        ///var fileURL = entry.toURL();
        ///console.log(fileURL);
        /// </code>
        /// </example>
        public JsString toURL() { return null; }

        /// <summary>
        /// Deletes a directory. It is an error to attempt to:
        /// delete a directory that is not empty;
        /// delete the root directory of a filesystem.
        /// </summary>
        /// <param name="successCallback"> A callback that is called after the directory has been deleted. Invoked with no parameters</param>
        /// <param name="errorCallback">A callback that is called if an error occurs when attempting to delete the directory. Invoked with a FileError object</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(entry) {
        ///     console.log("Removal succeeded");
        /// }
        /// function fail(error) {
        ///     alert('Error removing directory: ' + error.code);
        /// }
        /// remove this directory
        /// entry.remove(success, fail);
        /// </code>
        /// </example>
        public void remove(JsAction successCallback, FileErrorCallback errorCallback) { }

        /// <summary>
        /// Look up the parent DirectoryEntry containing the directory.
        /// </summary>
        /// <param name="successCallback">A callback that is called with the directory's parent DirectoryEntry.</param>
        /// <param name="errorCallback"> A callback that is called if an error occurs when attempting to retrieve the parent DirectoryEntry. Invoked with a FileError object</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(parent) {
        ///    console.log("Parent Name: " + parent.name);
        ///}
        ///function fail(error) {
        ///    alert('Failed to get parent directory: ' + error.code);
        ///}
        /// // Get the parent DirectoryEntry
        ///entry.getParent(success, fail);
        /// </code>
        /// </example>
        public void getParent(JsAction<DirectoryEntry> successCallback, FileErrorCallback errorCallback) { }

        /// <summary>
        /// Creates a new DirectoryReader to read entries in a directory.
        /// </summary>
        /// <returns></returns>
        public DirectoryReader createReader() { return null; }
        /// <summary>
        /// Creates or looks up an existing directory. It is an error to attempt to create a directory whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the directory to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the directory is created if it doesn't exist.</param>
        /// <param name="successCallback">A callback that is invoked with a DirectoryEntry object. </param>
        /// <param name="errorCallback"> A callback that is called if an error occurs creating or looking up the directory. Invoked with a FileError object.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(parent) {
        ///    console.log("Parent Name: " + parent.name);
        ///}
        ///function fail(error) {
        ///    alert("Unable to create new directory: " + error.code);
        ///}
        /// // Retrieve an existing directory, or create it if it does not already exist
        ///entry.getDirectory("newDir", {create: true, exclusive: false}, success, fail);
        /// </code>
        /// </example>
        public void getDirectory(JsString path, Flags options, JsAction<DirectoryEntry> successCallback, JsAction errorCallback) { }
        /// <summary>
        /// Creates or looks up a file. It is an error to attempt to create a file whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the file to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the file is created if it doesn't exist.</param>
        /// <param name="successCallback"> A callback that is invoked with a FileEntry object.</param>
        /// <param name="errorCallback">- A callback that is called if an error occurs creating or looking up the file. Invoked with a FileError object.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(parent) {
        ///    console.log("Parent Name: " + parent.name);
        ///}
        ///function fail(error) {
        ///    alert("Failed to retrieve file: " + error.code);
        ///}
        /// // Retrieve an existing file, or create it if it does not exist
        ///entry.getFile("newFile.txt", {create: true, exclusive: false}, success, fail);
        /// </code>
        /// </example>
        public void getFile(JsString path, Flags options, JsAction<FileEntry> successCallback, JsAction errorCallback) { }
        /// <summary>
        /// Deletes a directory and all of its contents. In the event of an error (e.g. trying to delete a directory that contains a file that cannot be removed), some of the contents of the directory may be deleted.
        /// It is an error to attempt to delete the root directory of a filesystem.
        /// </summary>
        /// <param name="successCallback"> A callback that is called after the DirectoryEntry has been deleted. Invoked with no parameters.</param>
        /// <param name="errorCallback">A callback that is called if an error occurs when attempting to delete the DirectoryEntry. Invoked with a FileError object</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(parent) {
        ///    console.log("Remove Recursively Succeeded");
        ///}
        ///function fail(error) {
        ///    alert("Failed to remove directory or it's contents: " + error.code);
        ///}
        /// // remove the directory and all it's contents
        ///entry.removeRecursively(success, fail);
        /// </code>
        /// </example>
        public void removeRecursively(JsAction successCallback, JsAction errorCallback) { }
    }

    /// <summary>
    /// This object is used to supply arguments to the DirectoryEntry getFile and getDirectory methods, which look up or create files and directories, respectively.
    /// </summary>
    [JsType(JsMode.Json)]
    public class Flags
    {
        /// <summary>
        /// Used to indicate that the file or directory should be created, if it does not exist
        /// </summary>
        public bool create { get; set; }
        /// <summary>
        ///  By itself, exclusive has no effect. Used with create, it causes the file or directory creation to fail if the target path already exists.
        /// </summary>
        public bool exclusive { get; set; }
    }


    /// <summary>
    /// This object represents a file system.
    /// </summary>
    public class FileSystem
    {
        /// <summary>
        /// The name of the file system
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The root directory of the file system.
        /// </summary>
        public DirectoryEntry root { get; set; }
    }

    /// <summary>
    /// An object that lists files and directories in a directory. Defined in the Directories and Systems specification.
    /// </summary>
    public class DirectoryReader
    {
        /// <summary>
        /// Read the entries in this directory.
        /// </summary>
        /// <param name="successCallback">- A callback that is passed an array of FileEntry and DirectoryEntry objects</param>
        /// <param name="errorCallback">A callback that is called if an error occurs retrieving the directory listing. Invoked with a FileError object.</param>
        /// <example>
        /// usage
        /// <code>
        /// function success(entries) {
        ///    var i;
        ///    for (i=0; i &lt;entries.length; i++) {
        ///        console.log(entries[i].name);
        ///    }
        ///}
        ///function fail(error) {
        ///    alert("Failed to list directory contents: " + error.code);
        ///}
        /// // Get a directory reader
        ///var directoryReader = dirEntry.createReader();
        /// // Get a list of all the entries in the directory
        ///directoryReader.readEntries(success,fail);
        /// </code>
        /// </example>
        public void readEntries(ReadEntriesSuccessCallback successCallback, ReadEntriesErrorCallback errorCallback) { }

    }

    public class Entry
    {
    }
    /// <summary>
    /// A callback that is passed an array of FileEntry and DirectoryEntry objects. (Function)
    /// </summary>
    /// <param name="entries"></param>

    public delegate void ReadEntriesSuccessCallback(JsArray<Entry> entries);

    /// <summary>
    /// A callback that is called if an error occurs retrieving the directory listing. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void ReadEntriesErrorCallback(FileError error);

    /// <summary>
    /// A 'FileError' object is set when an error occurs in any of the File API methods.
    /// </summary>
    public class FileError
    {
        /// <summary>
        ///  One of the pre-defined error codes listed below
        /// </summary>
        public JsNumber code { get; set; }

        public static FileError NOT_FOUND_ERR { get; private set; }

        public static FileError SECURITY_ERR { get; private set; }

        public static FileError ABORT_ERR { get; private set; }

        public static FileError NOT_READABLE_ERR { get; private set; }

        public static FileError ENCODING_ERR { get; private set; }

        public static FileError NO_MODIFICATION_ALLOWED_ERR { get; private set; }

        public static FileError INVALID_STATE_ERR { get; private set; }

        public static FileError SYNTAX_ERR { get; private set; }

        public static FileError INVALID_MODIFICATION_ERR { get; private set; }

        public static FileError QUOTA_EXCEEDED_ERR { get; private set; }

        public static FileError TYPE_MISMATCH_ERR { get; private set; }

        public static FileError PATH_EXISTS_ERR { get; private set; }






    }

    /// <summary>
    /// The File object contains attributes of a single file. You can get an instance of a File object by calling the file method of a FileEntry object.
    /// </summary>
    public class File
    {
        /// <summary>
        ///  The name of the file. 
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        ///  The full path of the file including the file name
        /// </summary>
        public JsString fullPath { get; set; }
        /// <summary>
        ///  The mime type of the file. 
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The last time the file was modified.
        /// </summary>
        public JsDate lastModifiedDate { get; set; }
        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        public long size { get; set; }
    }

    /// <summary>
    /// This object represents a file on a file system. It is defined in the W3C Directories and Systems specification.
    /// </summary>
    public class FileEntry
    {
        /// <summary>
        /// Always true.
        /// </summary>
        public bool isFile { get; set; }

        /// <summary>
        /// Always false.
        /// </summary>
        public bool isDirectory { get; set; }

        /// <summary>
        /// The name of the FileEntry, excluding the path leading to it.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        ///  The full absolute path from the root to the FileEntry.
        /// </summary>
        public JsString fullPath { get; set; }

        /// <summary>
        ///  The file system on which the FileEntry resides.
        /// </summary>
        public FileSystem filesystem { get; set; }

        /// <summary>
        /// Look up metadata about a file.
        /// </summary>
        /// <param name="successCallback"> A callback that is called with a Metadata object.</param>
        /// <param name="errorCallback"> A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.</param>
        /// <example>
        /// <code>
        /// function success(metadata) {
        ///    console.log("Last Modified: " + metadata.modificationTime);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        /// // Request the metadata object for this entry
        ///entry.getMetadata(success, fail);
        /// </code>
        /// </example>
        public void getMetadata(GetMetadataSuccessCallback successCallback, GetMetadataErrorCallback errorCallback) { }

        /// <summary>
        /// Set metadata on a file. Only works on iOS currently - this will set the extended attributes of a file.
        /// </summary>
        /// <param name="successCallback">A callback that is called when the metadata was successfully set.</param>
        /// <param name="errorCallback">A callback that is called when the metadata was not successfully set.</param>
        /// <param name="metadataObject">An object that contains the metadata keys and values. </param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success() {
        ///    console.log("The metadata was successfully set.");
        ///}
        ///function fail() {
        ///    alert("There was an error in setting the metadata");
        ///}
        /// // Set the metadata
        ///entry.setMetadata(success, fail, { "com.apple.MobileBackup": 1});
        /// </code>
        /// </example>
        public void setMetadata(SetMetadataSuccessCallback successCallback, SetMetadataErrorCallback errorCallback, object metadataObject) { }

        /// <summary>
        /// Move a file to a different location on the file system. It is an error to attempt to:
        ///move a file into its parent if a name different from its current one isn't provided;
        ///move a file to a path occupied by a directory;
        ///In addition, an attempt to move a file on top of an existing file must attempt to delete and replace that file.
        /// </summary>
        /// <param name="parent"> The parent directory to which to move the file.</param>
        /// <param name="newName"> The new name of the file. Defaults to the current name if unspecified.</param>
        /// <param name="successCallback">A callback that is called with the FileEntry object of the new file.</param>
        /// <param name="errorCallback">A callback that is called if an error occurs when attempting to move the file. Invoked with a FileError object.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function success(entry) {
        ///    console.log("New Path: " + entry.fullPath);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        ///function moveFile(entry) {
        ///    var parent = document.getElementById('parent').value,
        ///        parentName = parent.substring(parent.lastIndexOf('/')+1),
        ///        parentEntry = new DirectoryEntry(parentName, parent);
        ///    // move the file to a new directory and rename it
        ///    entry.moveTo(parentEntry, "newFile.txt", success, fail);
        ///}
        /// </code>
        /// </example>
        public void moveTo(DirectoryEntry parent, JsString newName, MoveToSuccessCallback successCallback, MoveToErrorCallback errorCallback) { }

        /// <summary>
        ///Copy a file to a new location on the file system. It is an error to attempt to:
        ///copy a file into its parent if a name different from its current one is not provided.
        /// </summary>
        /// <param name="parent"> The parent directory to which to copy the file.</param>
        /// <param name="newName"> The new name of the file. Defaults to the current name if unspecified.</param>
        /// <param name="successCallback">A callback that is called with the FileEntry object of the new file.</param>
        /// <param name="errorCallback">A callback that is called if an error occurs when attempting to copy the file. Invoked with a FileError object.</param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        ///function win(entry) {
        ///    console.log("New Path: " + entry.fullPath);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        ///function copyFile(entry) {
        ///    var parent = document.getElementById('parent').value,
        ///        parentName = parent.substring(parent.lastIndexOf('/')+1),
        ///        parentEntry = new DirectoryEntry(parentName, parent);
        ///    // copy the file to a new directory and rename it
        ///    entry.copyTo(parentEntry, "file.copy", success, fail);
        ///}
        /// </code>
        /// </example>
        public void copyTo(DirectoryEntry parent, JsString newName, MoveToSuccessCallback successCallback, MoveToErrorCallback errorCallback) { }

        /// <summary>
        /// Returns a URL that can be used to locate the file.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// // Request the URL for this entry
        ///var fileURL = entry.toURL();
        ///console.log(fileURL);
        /// </code>
        /// </example>
        public JsString toURL() { return null; }

        /// <summary>
        /// Deletes a file.
        /// </summary>
        /// <param name="successCallback">A callback that is called after the file has been deleted. Invoked with no parameters. </param>
        /// <param name="errorCallback"> A callback that is called if an error occurs when attempting to delete the file. Invoked with a FileError object</param>
        /// <example>
        /// usage
        /// <code>
        /// function success(entry) {
        ///    console.log("Removal succeeded");
        ///}
        ///function fail(error) {
        ///    alert('Error removing file: ' + error.code);
        ///}
        /// // remove the file
        ///entry.remove(success, fail);
        /// </code>
        /// </example>
        public void remove(RemoveSuccessCallback successCallback, RemoveErrorCallback errorCallback) { }

        /// <summary>
        /// Look up the parent DirectoryEntry containing the file.
        /// </summary>
        /// <param name="successCallback">A callback that is called with the file's parent DirectoryEntry. </param>
        /// <param name="errorCallback">A callback that is called if an error occurs when attempting to retrieve the parent DirectoryEntry. Invoked with a FileError object</param>
        /// <example>
        /// usage
        /// <code>
        /// function success(parent) {
        ///    console.log("Parent Name: " + parent.name);
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        /// // Get the parent DirectoryEntry
        ///entry.getParent(success, fail);
        /// </code>
        /// </example>
        public void getParent(GetParentSuccessCallback successCallback, GetParentErrorCallback errorCallback) { }

        /// <summary>
        /// Create a FileWriter object associated with the file that the FileEntry represents.
        /// </summary>
        /// <param name="successCallback">A callback that is called with a FileWriter object.</param>
        /// <param name="errorCallback">A callback that is called if an error occurs while attempting to create the FileWriter. Invoked with a FileError object.</param>
        /// <example>
        /// usage
        /// <code>
        /// function success(writer) {
        ///    writer.write("Some text to the file");
        ///}
        ///function fail(error) {
        ///    alert(error.code);
        ///}
        /// // create a FileWriter to write to the file
        ///entry.createWriter(success, fail);
        /// </code>
        /// </example>
        public void createWriter(CreateWriterSuccessCallback successCallback, CreateWriterErrorCallback errorCallback) { }

        /// <summary>
        /// Return a File object that represents the current state of the file that this FileEntry represents.
        /// </summary>
        /// <param name="successCallback">A callback that is called with a File object.</param>
        /// <param name="errorCallback"> A callback that is called if an error occurs when creating the File object (e.g. the underlying file no longer exists).
        /// Invoked with a FileError object.</param>
        /// <returns></returns>
        public File file(FileSuccessCallback successCallback, FileErrorCallback errorCallback) { return null; }


    }

    /// <summary>
    /// This interface supplies information about the state of a file or directory.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// function win(metadata) {
    ///    console.log("Last Modified: " + metadata.modificationTime);
    ///}
    /// // Request the metadata object for this entry
    ///entry.getMetadata(win, null);
    /// </code>
    /// </example>
    public class Metadata
    {
        /// <summary>
        ///  This is the time at which the file or directory was last modified.
        /// </summary>
        public JsDate modificationTime { get; set; }
    }

    /// <summary>
    ///  A callback that is called with a Metadata object. 
    /// </summary>
    /// <param name="metadata"></param>
    public delegate void GetMetadataSuccessCallback(Metadata metadata);
    /// <summary>
    /// A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void GetMetadataErrorCallback(FileError error);

    /// <summary>
    /// A callback that is called when the metadata was successfully set. 
    /// </summary>
    public delegate void SetMetadataSuccessCallback();
    /// <summary>
    ///  A callback that is called when the metadata was not successfully set.
    /// </summary>
    public delegate void SetMetadataErrorCallback();

    /// <summary>
    /// A callback that is called with the FileEntry object of the new file.
    /// </summary>
    /// <param name="entry"></param>
    public delegate void MoveToSuccessCallback(FileEntry entry);
    /// <summary>
    /// A callback that is called if an error occurs when attempting to move the file. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void MoveToErrorCallback(FileError error);

    /// <summary>
    /// A callback that is called with the FileEntry object of the new file.
    /// </summary>
    /// <param name="entry"></param>
    public delegate void CopyToSuccessCallback(FileEntry entry);
    /// <summary>
    /// A callback that is called if an error occurs when attempting to copy the file. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void CopyToErrorCallback(FileError error);

    /// <summary>
    ///  A callback that is called after the file has been deleted.  (?)Invoked with no parameters(?)
    /// </summary>
    /// <param name="entry"></param>
    public delegate void RemoveSuccessCallback(Entry entry);
    /// <summary>
    ///A callback that is called if an error occurs when attempting to delete the file. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void RemoveErrorCallback(FileError error);

    /// <summary>
    ///  A callback that is called with the file's parent DirectoryEntry
    /// </summary>
    /// <param name="parent"></param>
    public delegate void GetParentSuccessCallback(DirectoryEntry parent);
    /// <summary>
    ///A callback that is called if an error occurs when attempting to retrieve the parent DirectoryEntry. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void GetParentErrorCallback(FileError error);

    /// <summary>
    /// FileWriter is an object that allows one to write a file.
    /// </summary>
    public class FileWriter
    {
        /// <summary>
        /// One of the three states the reader can be in INIT, WRITING or DONE.
        /// </summary>
        public FileWriterReadyState readyState { get; set; }

        /// <summary>
        ///  The name of the file to be written.
        /// </summary>
        public JsString fileName { get; set; }

        /// <summary>
        ///  The length of the file to be written.
        /// </summary>
        public long length { get; set; }

        /// <summary>
        /// The current position of the file pointer.
        /// </summary>
        public long position { get; set; }

        /// <summary>
        /// An object containing errors
        /// </summary>
        public FileError error { get; set; }

        /// <summary>
        /// Called when the write starts.
        /// </summary>
        public JsFunction onwritestart { get; set; }

        /// <summary>
        /// Called while writing the file, reports progress (progess.loaded/progress.total).-NOT SUPPORTED
        /// </summary>
        public JsFunction onprogress { get; set; }

        /// <summary>
        /// Called when the request has completed successfully. 
        /// </summary>
        public JsFunction onwrite { get; set; }

        /// <summary>
        ///  Called when the write has been aborted. For instance, by invoking the abort() method. 
        /// </summary>
        public JsFunction onabort { get; set; }

        /// <summary>
        /// Called when the write has failed.
        /// </summary>
        public JsFunction onerror { get; set; }

        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
        public JsFunction onwriteend { get; set; }

        /// <summary>
        /// Aborts writing file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// function win(writer) {
        ///    writer.onwrite = function(evt) {
        ///        console.log("write success");
        ///    };
        ///    writer.write("some sample text");
        ///    writer.abort();
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.createWriter(win, fail);
        /// </code>
        /// </example>
        public void abort() { }

        /// <summary>
        ///  Moves the file pointer to the byte specified.
        /// </summary>
        /// <param name="location"></param>
        /// <example>
        /// usage
        /// <code>
        /// function win(writer) {
        ///    // fast forwards file pointer to end of file
        ///    writer.seek(writer.length); 
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.createWriter(win, fail);
        /// </code>
        /// </example>
        public void seek(JsNumber location) { }

        /// <summary>
        /// : Shortens the file to the length specified.
        /// </summary>
        /// <param name="length"></param>
        /// <example>
        /// usage
        /// <code>
        /// function win(writer) {
        ///    writer.truncate(10);    
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.createWriter(win, fail);
        /// </code>
        /// </example>
        public void truncate(JsNumber length) { }

        /// <summary>
        /// Writes data to the file with a UTF-8 encoding.
        /// </summary>
        /// <param name="s"></param>
        /// <example>
        /// usage
        /// <code>
        /// function win(writer) {
        ///    writer.onwrite = function(evt) {
        ///        console.log("write success");
        ///    };
        ///    writer.write("some sample text");
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.createWriter(win, fail);
        /// </code>
        /// </example>
        public void write(JsString s) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <example>
        /// usage
        /// <code>
        /// function win(writer) {
        ///    writer.onwrite = function(evt) {
        ///        console.log("write success");
        ///    };
        ///    writer.seek(writer.length);
        ///    writer.write("appended text");
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.createWriter(win, fail);
        /// </code>
        /// </example>
        public void append(JsString s) { }

    }

    /// <summary>
    /// One of the three states the reader can be in INIT, WRITING or DONE.
    /// </summary>
    public enum FileWriterReadyState
    {
        INIT,
        WRITING,
        DONE,
    }

    /// <summary>
    ///  A callback that is called with the file's parent DirectoryEntry
    /// </summary>
    /// <param name="writer"></param>
    public delegate void CreateWriterSuccessCallback(FileWriter writer);
    /// <summary>
    ///A callback that is called if an error occurs when attempting to retrieve the parent DirectoryEntry. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void CreateWriterErrorCallback(FileError error);

    /// <summary>
    /// A callback that is called with a File object
    /// </summary>
    /// <param name="file"></param>
    public delegate void FileSuccessCallback(File file);
    /// <summary>
    ///A callback that is called if an error occurs when creating the File object (e.g. the underlying file no longer exists). Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void FileErrorCallback(FileError error);

    /// <summary>
    ///  One of the three states the reader can be in EMPTY, LOADING or DONE.
    /// </summary>
    public enum FileReaderReadyState
    {
        EMPTY,
        LOADING,
        DONE,
    }

    /// <summary>
    /// FileReader is an object that allows one to read a file.
    /// </summary>
    public class FileReader
    {
        public FileReaderReadyState readyState { get; set; }

        /// <summary>
        /// The contents of the file that has been read.
        /// </summary>
        public JsString result { get; set; }

        /// <summary>
        /// An object containing errors. 
        /// </summary>
        public FileError error { get; set; }

        /// <summary>
        /// Called when the read starts.
        /// </summary>
        public JsFunction onloadstart { get; set; }

        /// <summary>
        ///  Called while reading the file, reports progress (progess.loaded/progress.total).-NOT SUPPORTED
        /// </summary>
        public JsFunction onprogress { get; set; }

        /// <summary>
        ///  Called when the read has successfully completed.
        /// </summary>
        public JsFunction onload { get; set; }

        /// <summary>
        /// Called when the read has been aborted. For instance, by invoking the abort() method.
        /// </summary>
        public JsFunction onabort { get; set; }

        /// <summary>
        /// Called when the read has failed.
        /// </summary>
        public JsFunction onerror { get; set; }

        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
        public JsFunction onloadend { get; set; }

        /// <summary>
        /// Aborts reading file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// function win(file) {
        ///    var reader = new FileReader();
        ///    reader.onloadend = function(evt) {
        ///        console.log("read success");
        ///        console.log(evt.target.result);
        ///    };
        ///    reader.readAsText(file);
        ///    reader.abort();
        ///};
        ///function fail(error) {
        ///    console.log(error.code);
        ///}
        ///entry.file(win, fail);
        /// </code>
        /// </example>
        public void abort() { }

        /// <summary>
        /// Read file and return data as a base64 encoded data url.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function win(file) {
        ///    var reader = new FileReader();
        ///    reader.onloadend = function(evt) {
        ///        console.log("read success");
        ///        console.log(evt.target.result);
        ///    };
        ///    reader.readAsDataURL(file);
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.file(win, fail);
        /// </code>
        /// </example>
        public JsString readAsText(File file) { return null; }

        /// <summary>
        /// Reads text file
        /// </summary>
        /// <param name="file">the file object to read</param>
        /// <param name="encoding">the encoding to use to encode the file's content. Default is UTF8.</param>
        /// <example>
        /// usage
        /// <code>
        /// function win(file) {
        ///    var reader = new FileReader();
        ///    reader.onloadend = function(evt) {
        ///        console.log("read success");
        ///        console.log(evt.target.result);
        ///    };
        ///    reader.readAsText(file);
        ///};
        ///var fail = function(evt) {
        ///    console.log(error.code);
        ///};
        ///entry.file(win, fail);
        /// </code>
        /// </example>
        public void readAsText(File file, JsString encoding) { }

    }

    /// <summary>
    /// FileTransfer is an object that allows you to upload files to a server or download files from a server.
    /// The FileTransfer object provides a way to upload files to a remote server using an HTTP multi-part POST request.
    /// Both HTTP and HTTPS protocols are supported. Optional parameters can be specified by passing a FileUploadOptions object to the upload method.
    /// On successful upload, the success callback will be called with a FileUploadResult object.
    /// If an error occurs, the error callback will be invoked with a FileTransferError object.
    /// It is also possible to download a file from remote and save it on the device (only iOS and Android).
    /// </summary>
    public class FileTransfer
    {
        /// <summary>
        ///  sends a file to a server.
        /// </summary>
        /// <param name="filePath">Full path of the file on the device</param>
        /// <param name="server">URL of the server to receive the file</param>
        /// <param name="successCallback"> A callback that is called with a Metadata object.</param>
        /// <param name="errorCallback">- A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.</param>
        /// <param name="options">Optional parameters such as file name and mimetype</param>
        /// <example>
        /// usage
        /// <code>
        /// // !! Assumes variable fileURI contains a valid URI to a  text file on the device
        ///var win = function(r) {
        ///    console.log("Code = " + r.responseCode);
        ///    console.log("Response = " + r.response);
        ///    console.log("Sent = " + r.bytesSent);
        ///}
        ///var fail = function(error) {
        ///    alert("An error has occurred: Code = " + error.code);
        ///    console.log("upload error source " + error.source);
        ///    console.log("upload error target " + error.target);
        ///}
        ///var options = new FileUploadOptions();
        ///options.fileKey="file";
        ///options.fileName=fileURI.substr(fileURI.lastIndexOf('/')+1);
        ///options.mimeType="text/plain";
        ///var params = new Object();
        ///params.value1 = "test";
        ///params.value2 = "param";
        ///options.params = params;
        ///var ft = new FileTransfer();
        ///ft.upload(fileURI, "http://some.server.com/upload.php", win, fail, options);
        /// </code>
        /// </example>
        public void upload(JsString filePath, JsString server, UploadSuccessCallback successCallback, UploadErrorCallback errorCallback, FileUploadOptions options) { }

        /// <summary>
        /// downloads a file from server.
        /// </summary>
        /// <param name="source">URL of the server to receive the file</param>
        /// <param name="target"> Full path of the file on the device</param>
        /// <param name="successCallback"> A callback that is called with a FileEntry object. </param>
        /// <param name="errorCallback"> A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.</param>
        public void download(JsString source, JsString target, DownloadSuccessCallback successCallback, DownloadErrorCallback errorCallback) { }
    }

    /// <summary>
    ///  A callback that is called with a Metadata object. 
    /// </summary>
    /// <param name="successCallback "></param>
    public delegate void UploadSuccessCallback(FileUploadResult successCallback);
    /// <summary>
    /// A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void UploadErrorCallback(FileTransferError error);

    /// <summary>
    ///   A callback that is called with a FileEntry object 
    /// </summary>
    /// <param name="successCallback "></param>
    public delegate void DownloadSuccessCallback(FileEntry successCallback);
    /// <summary>
    ///  A callback that is called if an error occurs retrieving the Metadata. Invoked with a FileError object.
    /// </summary>
    /// <param name="error"></param>
    public delegate void DownloadErrorCallback(FileError error);

    /// <summary>
    /// A FileUploadOptions object can be passed to the FileTransfer objects upload method in order to specify additional parameters to the upload script.
    /// </summary>
    public class FileUploadOptions
    {
        /// <summary>
        /// The name of the form element. If not set defaults to "file". 
        /// </summary>
        public JsString fileKey { get; set; }

        /// <summary>
        /// The file name you want the file to be saved as on the server. If not set defaults to "image.jpg".
        /// </summary>
        public JsString fileName { get; set; }

        /// <summary>
        /// The mime type of the data you are uploading. If not set defaults to "image/jpeg".
        /// </summary>
        public JsString mimeType { get; set; }

        /// <summary>
        ///  A set of optional key/value pairs to be passed along in the HTTP request.
        /// </summary>
        public object @params { get; set; }

        /// <summary>
        /// Should the data be uploaded in chunked streaming mode. If not set defaults to "true". 
        /// </summary>
        public bool chunkedMode { get; set; }

    }

    /// <summary>
    /// A FileUploadResult object is returned via the success callback of the FileTransfer upload method.
    /// </summary>
    public class FileUploadResult
    {
        /// <summary>
        ///  The number of bytes sent to the server as part of the upload.
        /// </summary>
        public long bytesSent { get; set; }

        /// <summary>
        /// The HTTP response code returned by the server.
        /// </summary>
        public long responseCode { get; set; }

        /// <summary>
        /// The HTTP response returned by the server. 
        /// </summary>
        public JsString response { get; set; }
    }

    /// <summary>
    /// A FileTransferError object is returned via the error callback when an error occurs.
    /// </summary>
    public class FileTransferError
    {
        /// <summary>
        /// One of the predefined error codes listed below.
        /// </summary>
        public JsNumber code { get; set; }

        /// <summary>
        ///  URI to the source 
        /// </summary>
        public JsString source { get; set; }

        /// <summary>
        ///  URI to the target  
        /// </summary>
        public JsString target { get; set; }

        /// <summary>
        ///  HTTP status code. This attribute is only available when a response code is received from the HTTP connection. 
        /// </summary>
        public JsNumber http_status { get; set; }

        public static FileTransferError FILE_NOT_FOUND_ERR { get; private set; }

        public static FileTransferError INVALID_URL_ERR { get; private set; }

        public static FileTransferError CONNECTION_ERR { get; private set; }



    }

    /// <summary>
    /// This object provides a way to obtain root file systems.
    /// </summary>
    public class LocalFileSystem
    {
        /// <summary>
        /// Requests a filesystem.
        /// </summary>
        /// <param name="fileSystem"></param>
        /// <example>
        /// usage
        /// <code>
        /// function onSuccess(fileSystem) {
        ///    console.log(fileSystem.name);
        ///}
        /// // request the persistent file system
        ///window.requestFileSystem(LocalFileSystem.PERSISTENT, 0, onSuccess, onError);
        /// </code>
        /// </example>
        public static void requestFileSystem(LocalFileSystem fs, JsNumber x, JsAction<FileSystem> successCallback, JsAction errorCallback) { }

        /// <summary>
        ///  Retrieve a DirectoryEntry or FileEntry using local URI.
        /// </summary>
        /// <param name="entry"></param>
        /// <example>
        /// usage
        /// <code>
        /// function onSuccess(fileEntry) {
        ///    console.log(fileEntry.name);
        ///}
        ///window.resolveLocalFileSystemURI("file:///example.txt", onSuccess, onError);
        /// </code>
        /// </example>
        public void resolveLocalFileSystemURI(JsString url, JsAction<Entry> successCallback, JsAction errorCallback) { }

        /// <summary>
        /// Used for storage that should not be removed by the user agent without application or user permission.
        /// </summary>
        public static LocalFileSystem PERSISTENT { get; private set; }

        /// <summary>
        ///  Used for storage with no guarantee of persistence.
        /// </summary>
        public static LocalFileSystem TEMPORARY { get; private set; }
    }

    /// <summary>
    /// The geolocation object provides access to the device's GPS sensor.
    /// </summary>
    public class Geolocation
    {
        /// <summary>
        /// geolocation.getCurrentPositon is an asynchronous function. It returns the device's current position to the
        /// geolocationSuccess callback with a Position object as the parameter.
        /// If there is an error, the geolocationError callback is invoked with a PositionError object.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <param name="geolocationError">The callback that is called if there was an error.</param>
        /// <param name="geolocationOptions"> The geolocation options.</param>
        /// <returns>Contains Position coordinates and timestamp, created by the geolocation API.</returns>
        public Position getCurrentPosition(GeolocationSuccess geolocationSuccess, GeolocationError geolocationError, GeolocationOptions geolocationOptions) { return null; }

        /// <summary>
        /// geolocation.getCurrentPositon is an asynchronous function. It returns the device's current position to the
        /// geolocationSuccess callback with a Position object as the parameter.
        /// If there is an error, the geolocationError callback is invoked with a PositionError object.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <param name="geolocationError">The callback that is called if there was an error.</param>
        /// <returns>Contains Position coordinates and timestamp, created by the geolocation API.</returns>
        public Position getCurrentPosition(GeolocationSuccess geolocationSuccess, GeolocationError geolocationError) { return null; }

        /// <summary>
        /// geolocation.getCurrentPositon is an asynchronous function. It returns the device's current position to the
        /// geolocationSuccess callback with a Position object as the parameter.
        /// If there is an error, the geolocationError callback is invoked with a PositionError object.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <param name="geolocationOptions"> The geolocation options.</param>
        /// <returns>Contains Position coordinates and timestamp, created by the geolocation API.</returns>
        public Position getCurrentPosition(GeolocationSuccess geolocationSuccess, GeolocationOptions geolocationOptions) { return null; }

        /// <summary>
        /// geolocation.getCurrentPositon is an asynchronous function. It returns the device's current position to the
        /// geolocationSuccess callback with a Position object as the parameter.
        /// If there is an error, the geolocationError callback is invoked with a PositionError object.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <returns>Contains Position coordinates and timestamp, created by the geolocation API.</returns>
        public Position getCurrentPosition(GeolocationSuccess geolocationSuccess) { return null; }


        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <param name="geolocationError">The callback that is called if there was an error.</param>
        /// <param name="geolocationOptions"> The geolocation options.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with geolocation.clearWatch to stop watching for changes in position.</returns>
        public JsString watchPosition(GeolocationSuccess geolocationSuccess, GeolocationError geolocationError, GeolocationOptions geolocationOptions) { return null; }

        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <param name="geolocationError">The callback that is called if there was an error.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with geolocation.clearWatch to stop watching for changes in position.</returns>
        public JsString watchPosition(GeolocationSuccess geolocationSuccess, GeolocationError geolocationError) { return null; }

        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <param name="geolocationOptions"> The geolocation options.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with geolocation.clearWatch to stop watching for changes in position.</returns>
        public JsString watchPosition(GeolocationSuccess geolocationSuccess, GeolocationOptions geolocationOptions) { return null; }

        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="geolocationSuccess">The callback that is called with the current position.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with geolocation.clearWatch to stop watching for changes in position.</returns>
        public JsString watchPosition(GeolocationSuccess geolocationSuccess) { return null; }

        /// <summary>
        /// Stop watching for changes to the device's location referenced by the watchID parameter.
        /// </summary>
        /// <param name="watchID">The id of the watchPosition interval to clear. </param>
        /// <example>
        /// usage
        /// <code>
        /// // Options: watch for changes in position, and use the most
        /// // accurate position acquisition method available.
        /// //
        ///var watchID = navigator.geolocation.watchPosition(onSuccess, onError, { enableHighAccuracy: true });
        /// // ...later on...
        ///navigator.geolocation.clearWatch(watchID);
        /// </code>
        /// </example>
        public void clearWatch(JsString watchID) { }

    }

    public class Position
    {
        /// <summary>
        /// A set of geographic coordinates.
        /// </summary>
        public Coordinates coords { get; private set; }

        /// <summary>
        ///  Creation timestamp for coords. 
        /// </summary>
        public JsDate timestamp { get; private set; }

    }

    /// <summary>
    /// A set of properties that describe the geographic coordinates of a position.
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        ///  Latitude in decimal degrees. 
        /// </summary>
        public JsNumber latitude { get; private set; }

        /// <summary>
        ///  Longitude in decimal degrees.
        /// </summary>
        public JsNumber longitude { get; private set; }

        /// <summary>
        ///  Height of the position in meters above the ellipsoid.
        /// </summary>
        public JsNumber altitude { get; private set; }

        /// <summary>
        /// Accuracy level of the latitude and longitude coordinates in meters.
        /// </summary>
        public JsNumber accuracy { get; private set; }

        /// <summary>
        ///  Accuracy level of the altitude coordinate in meters.
        /// </summary>
        public JsNumber altitudeAccuracy { get; private set; }

        /// <summary>
        /// Direction of travel, specified in degrees counting clockwise relative to the true north.
        /// </summary>
        public JsNumber heading { get; private set; }

        /// <summary>
        /// Current ground speed of the device, specified in meters per second.
        /// </summary>
        public JsNumber speed { get; private set; }
    }

    /// <summary>
    /// A PositionError object is returned to the geolocationError callback when an error occurs.
    /// </summary>
    public class PositionError
    {
        /// <summary>
        /// One of the predefined error codes listed below.
        /// </summary>
        public JsNumber code { get; private set; }

        /// <summary>
        /// Error message describing the details of the error encountered.
        /// </summary>
        public JsString message { get; private set; }

        /// <summary>
        /// Returned when the user does not allow your application to retrieve position information. This is dependent on the platform.
        /// </summary>
        public static PositionError PERMISSION_DENIED { get; private set; }

        /// <summary>
        /// Returned when the device was unable to retrieve a position. In general this means the device has no network connectivity and/or cannot get a satellite fix.
        /// </summary>
        public static PositionError POSITION_UNAVAILABLE { get; private set; }

        /// <summary>
        /// Returned when the device was unable to retrieve a position within the time specified in the geolocationOptions' timeout property.
        /// When using in conjunction with geolocation.
        /// watchPosition, this error could be called into the geolocationError callback every timeout milliseconds.
        /// </summary>
        public static PositionError TIMEOUT { get; private set; }

    }

    /// <summary>
    /// The user's callback function that is called when a geolocation position becomes available
    /// (when using with geolocation.getCurrentPosition), or when the position changes (when using with geolocation.watchPosition).
    /// </summary>
    /// <param name="position">The geolocation position returned by the device.</param>
    public delegate void GeolocationSuccess(Position position);

    /// <summary>
    /// The user's callback function that is called when there is an error for geolocation functions.
    /// </summary>
    /// <param name="error">The error returned by the device.</param>
    public delegate void GeolocationError(PositionError error);

    /// <summary>
    /// Optional parameters to customize the retrieval of the geolocation Position.
    /// </summary>
    /// <example>
    /// usge
    /// <code>
    /// { maximumAge: 3000, timeout: 5000, enableHighAccuracy: true };
    /// </code>
    /// </example>
    public class GeolocationOptions
    {
        /// <summary>
        /// Provides a hint that the application would like to receive the best possible results. By default, the device will attempt to retrieve a Position using network-based methods.
        /// Setting this property to true tells the framework to use more accurate methods, such as satellite positioning.
        /// </summary>
        public bool enableHighAccuracy { get; set; }

        /// <summary>
        /// The maximum length of time (milliseconds) that is allowed to pass from the call to geolocation.getCurrentPosition or geolocation.watchPosition
        /// until the corresponding geolocationSuccess callback is invoked. If the geolocationSuccess callback is not invoked within this time,
        /// the geolocationError callback will be invoked with a PositionError.TIMEOUT error code. NOTE: when used in conjunction with geolocation.watchPosition,
        /// the geolocationError callback could be called on an interval every timeout milliseconds!
        /// </summary>
        public JsNumber timeout { get; set; }

        /// <summary>
        ///  Accept a cached position whose age is no greater than the specified time in milliseconds.
        /// </summary>
        public JsNumber maximumAge { get; set; }
    }

    /// <summary>
    /// The Media object provides the ability to record and play back audio files on a device.
    /// </summary>
    public class Media
    {
        /// <summary>
        /// The Media object provides the ability to record and play back audio files on a device.
        /// </summary>
        /// <param name="src">A URI containing the audio content.</param>
        public Media(JsString src)
        {
        }

        /// <summary>
        /// The Media object provides the ability to record and play back audio files on a device.
        /// </summary>
        /// <param name="src">A URI containing the audio content</param>
        /// <param name="mediaSuccess"> (Optional) The callback that is invoked after a Media object has completed the current play/record or stop action.</param>
        public Media(JsString src, JsAction mediaSuccess)
        {
        }

        /// <summary>
        /// The Media object provides the ability to record and play back audio files on a device.
        /// </summary>
        /// <param name="src">A URI containing the audio content</param>
        /// <param name="mediaSuccess"> (Optional) The callback that is invoked after a Media object has completed the current play/record or stop action.</param>
        /// <param name="mediaError"> (Optional) The callback that is invoked if there was an error.</param>
        public Media(JsString src, JsAction mediaSuccess, MediaError mediaError)
        {
        }

        /// <summary>
        /// The Media object provides the ability to record and play back audio files on a device.
        /// </summary>
        /// <param name="src">A URI containing the audio content</param>
        /// <param name="mediaSuccess"> (Optional) The callback that is invoked after a Media object has completed the current play/record or stop action.</param>
        /// <param name="mediaError"> (Optional) The callback that is invoked if there was an error.</param>
        /// <param name="mediaStatus">(Optional) The callback that is invoked to indicate status changes</param>
        public Media(JsString src, JsAction mediaSuccess, MediaError mediaError, JsAction mediaStatus)
        {
        }

        /// <summary>
        /// Returns the current position within an audio file.
        /// </summary>
        /// <param name="mediaSuccess">The callback that is called with the current position in seconds.</param>
        /// <param name="mediaError">The callback that is called if there was an error.</param>
        /// <example>
        /// usage
        /// <code>
        /// // Audio player
        /// //
        ///var my_media = new Media(src, onSuccess, onError);
        /// // Update media position every second
        ///var mediaTimer = setInterval(function() {
        ///    // get media position
        ///    my_media.getCurrentPosition(
        ///        // success callback
        ///        function(position) {
        ///            if (position > -1) {
        ///                console.log((position) + " sec");
        ///            }
        ///        },
        ///        // error callback
        ///        function(e) {
        ///            console.log("Error getting pos=" + e);
        ///        }
        ///    );
        ///}, 1000);
        /// </code>
        /// </example>
        public void getCurrentPosition(JsFunction mediaSuccess, MediaError mediaError) { }

        /// <summary>
        /// Returns the current position within an audio file.
        /// </summary>
        /// <param name="mediaSuccess">The callback that is called with the current position in seconds.</param>
        /// <example>
        /// usage
        /// <code>
        /// // Audio player
        /// //
        ///var my_media = new Media(src, onSuccess, onError);
        /// // Update media position every second
        ///var mediaTimer = setInterval(function() {
        ///    // get media position
        ///    my_media.getCurrentPosition(
        ///        // success callback
        ///        function(position) {
        ///            if (position > -1) {
        ///                console.log((position) + " sec");
        ///            }
        ///        },
        ///        // error callback
        ///        function(e) {
        ///            console.log("Error getting pos=" + e);
        ///        }
        ///    );
        ///}, 1000);
        /// </code>
        /// </example>
        public void getCurrentPosition(JsFunction mediaSuccess) { }

        /// <summary>
        /// Returns the duration of an audio file.
        /// </summary>
        /// <returns></returns>
        public JsNumber getDuration() { return null; }

        /// <summary>
        /// Starts or resumes playing an audio file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Play audio
        /// //
        ///function playAudio(url) {
        ///    // Play the audio file at url
        ///    var my_media = new Media(url,
        ///        // success callback
        ///        function() {
        ///            console.log("playAudio():Audio Success");
        ///        },
        ///        // error callback
        ///        function(err) {
        ///            console.log("playAudio():Audio Error: "+err);
        ///    });
        ///    // Play audio
        ///    my_media.play();
        ///}
        /// </code>
        /// </example>
        public void play() { }

        /// <summary>
        /// Pauses playing an audio file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Play audio
        /// //
        ///function playAudio(url) {
        ///    // Play the audio file at url
        ///    var my_media = new Media(url,
        ///        // success callback
        ///        function() {
        ///            console.log("playAudio():Audio Success");
        ///        },
        ///        // error callback
        ///        function(err) {
        ///            console.log("playAudio():Audio Error: "+err);
        ///    });
        ///    // Play audio
        ///    my_media.play();
        ///    // Pause after 10 seconds
        ///    setTimeout(function() {
        ///        media.pause();
        ///    }, 10000);        
        ///}
        /// </code>
        /// </example>
        public void pause() { }

        /// <summary>
        /// Releases the underlying operating systems audio resources.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Audio player
        /// //
        ///var my_media = new Media(src, onSuccess, onError);
        ///my_media.play();
        ///my_media.stop();
        ///my_media.release();
        /// </code>
        /// </example>
        public void release() { }

        /// <summary>
        /// Sets the current position within an audio file.
        /// </summary>
        /// <param name="milliseconds">The position to set the playback position within the audio in milliseconds. .</param>
        /// <example>
        /// usage
        /// <code>
        ///     // Audio player
        /// //
        ///var my_media = new Media(src, onSuccess, onError);
        ///my_media.play();
        /// // SeekTo to 10 seconds after 5 seconds
        ///setTimeout(function() {
        ///    my_media.seekTo(10000);
        ///}, 5000);
        /// </code>
        /// </example>
        public void seekTo(JsNumber milliseconds) { }

        /// <summary>
        /// Starts recording an audio file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Record audio
        ///        // 
        ///        function recordAudio() {
        ///    var src = "myrecording.mp3";
        ///    var mediaRec = new Media(src,
        ///        // success callback
        ///        function() {
        ///            console.log("recordAudio():Audio Success");
        ///        },
        ///        // error callback
        ///        function(err) {
        ///            console.log("recordAudio():Audio Error: "+ err.code);
        ///        });
        ///    // Record audio
        ///    mediaRec.startRecord();
        ///}
        /// </code>
        /// </example>
        public void startRecord() { }

        /// <summary>
        /// Stops recording an audio file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Record audio
        ///        // 
        ///        function recordAudio() {
        ///    var src = "myrecording.mp3";
        ///    var mediaRec = new Media(src,
        ///        // success callback
        ///        function() {
        ///            console.log("recordAudio():Audio Success");
        ///        },
        ///        // error callback
        ///        function(err) {
        ///            console.log("recordAudio():Audio Error: "+ err.code);
        ///        });
        ///    // Record audio
        ///    mediaRec.startRecord();
        ///    // Stop recording after 10 seconds
        ///    setTimeout(function() {
        ///        mediaRec.stopRecord();
        ///    }, 10000);
        ///}
        /// </code>
        /// </example>
        public void stopRecord() { }

        /// <summary>
        /// Stops playing an audio file.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // Play audio
        /// //
        ///function playAudio(url) {
        ///    // Play the audio file at url
        ///    var my_media = new Media(url,
        ///        // success callback
        ///        function() {
        ///            console.log("playAudio():Audio Success");
        ///        },
        ///        // error callback
        ///        function(err) {
        ///            console.log("playAudio():Audio Error: "+err);
        ///    });
        ///    // Play audio
        ///    my_media.play();
        ///    // Pause after 10 seconds
        ///    setTimeout(function() {
        ///        my_media.stop();
        ///    }, 10000);        
        ///}
        /// </code>
        /// </example>
        public void stop() { }

        /// <summary>
        /// The position within the audio playback in seconds. Not automatically updated during play, call getCurrentPosition to update.
        /// </summary>
        public Position position { get; private set; }
        /// <summary>
        ///  The duration of the media in seconds.
        /// </summary>
        public JsNumber duration { get; private set; }

    }

    public class MediaError
    {
        /// <summary>
        /// One of the predefined error codes listed below.
        /// </summary>
        public JsNumber code { get; set; }

        /// <summary>
        ///  Error message describing the details of the error.
        /// </summary>
        public JsString message { get; set; }

        public static MediaError MEDIA_ERR_ABORTED { get; private set; }

        public static MediaError MEDIA_ERR_NETWORK { get; private set; }

        public static MediaError MEDIA_ERR_DECODE { get; private set; }

        public static MediaError MEDIA_ERR_NONE_SUPPORTED { get; private set; }

    }

    public class Notification
    {
        /// <summary>
        /// Most Cordova implementations use a native dialog box for this feature.
        /// However, some platforms simply use the browser's alert function, which is typically less customizable.
        /// </summary>
        /// <param name="message">Dialog message</param>
        /// <param name="alertCallback">Callback to invoke when alert dialog is dismissed. </param>
        /// <param name="title">Dialog title (Optional, Default: "Alert")</param>
        /// <param name="buttonName">Button name (Optional, Default: "OK")</param>
        /// <example>
        /// usage
        /// <code>
        /// // Android / BlackBerry WebWorks (OS 5.0 and higher) / iPhone
        /// //
        ///function alertDismissed() {
        ///    // do something
        ///}
        ///navigator.notification.alert(
        ///    'You are the winner!',  // message
        ///    alertDismissed,         // callback
        ///    'Game Over',            // title
        ///    'Done'                  // buttonName
        ///);
        /// </code>
        /// </example>
        public void alert(JsString message, JsAction alertCallback, JsString title, JsString buttonName) { }

        /// <summary>
        /// Most Cordova implementations use a native dialog box for this feature.
        /// However, some platforms simply use the browser's alert function, which is typically less customizable.
        /// </summary>
        /// <param name="message">Dialog message</param>
        /// <param name="alertCallback">Callback to invoke when alert dialog is dismissed. </param>
        /// <param name="title">Dialog title (Optional, Default: "Alert")</param>
        /// <example>
        /// usage
        /// <code>
        /// // Android / BlackBerry WebWorks (OS 5.0 and higher) / iPhone
        /// //
        ///function alertDismissed() {
        ///    // do something
        ///}
        ///navigator.notification.alert(
        ///    'You are the winner!',  // message
        ///    alertDismissed,         // callback
        ///    'Game Over',            // title
        ///    'Done'                  // buttonName
        ///);
        /// </code>
        /// </example>
        public void alert(JsString message, JsAction alertCallback, JsString title) { }

        /// <summary>
        /// Shows a customizable confirmation dialog box.
        /// </summary>
        /// <param name="message">Dialog message</param>
        /// <param name="confirmCallback">Callback to invoke with index of button pressed (1, 2 or 3).</param>
        /// <param name="title">Dialog title (Optional, Default: "Confirm")</param>
        /// <param name="buttonLabels"> Comma separated string with button labels (Optional, Default: "OK,Cancel")</param>
        /// <example>
        /// usage
        /// <code>
        /// // process the confirmation dialog result
        ///function onConfirm(buttonIndex) {
        ///    alert('You selected button ' + buttonIndex);
        ///}
        /// // Show a custom confirmation dialog
        /// //
        ///function showConfirm() {
        ///    navigator.notification.confirm(
        ///        'You are the winner!',  // message
        ///        onConfirm,              // callback to invoke with index of button pressed
        ///        'Game Over',            // title
        ///        'Restart,Exit'          // buttonLabels
        ///    );
        ///}
        /// </code>
        /// </example>
        public void confirm(JsString message, ConfirmCallback confirmCallback, JsString title, JsString buttonLabels) { }

        /// <summary>
        /// Shows a customizable confirmation dialog box.
        /// </summary>
        /// <param name="message">Dialog message</param>
        /// <param name="confirmCallback">Callback to invoke with index of button pressed (1, 2 or 3).</param>
        /// <example>
        /// usage
        /// <code>
        /// // process the confirmation dialog result
        ///function onConfirm(buttonIndex) {
        ///    alert('You selected button ' + buttonIndex);
        ///}
        /// // Show a custom confirmation dialog
        /// //
        ///function showConfirm() {
        ///    navigator.notification.confirm(
        ///        'You are the winner!',  // message
        ///        onConfirm,              // callback to invoke with index of button pressed
        ///        'Game Over',            // title
        ///        'Restart,Exit'          // buttonLabels
        ///    );
        ///}
        /// </code>
        /// </example>
        public void confirm(JsString message, ConfirmCallback confirmCallback) { }

        /// <summary>
        /// Shows a customizable confirmation dialog box.
        /// </summary>
        /// <param name="message">Dialog message</param>
        /// <param name="confirmCallback">Callback to invoke with index of button pressed (1, 2 or 3).</param>
        /// <param name="titleOrButtonLabels">Dialog title (Optional, Default: "Confirm")
        /// or
        /// Comma separated string with button labels (Optional, Default: "OK,Cancel")</param>
        /// <example>
        /// usage
        /// <code>
        /// // process the confirmation dialog result
        ///function onConfirm(buttonIndex) {
        ///    alert('You selected button ' + buttonIndex);
        ///}
        /// // Show a custom confirmation dialog
        /// //
        ///function showConfirm() {
        ///    navigator.notification.confirm(
        ///        'You are the winner!',  // message
        ///        onConfirm,              // callback to invoke with index of button pressed
        ///        'Game Over',            // title
        ///        'Restart,Exit'          // buttonLabels
        ///    );
        ///}
        /// </code>
        /// </example>
        public void confirm(JsString message, ConfirmCallback confirmCallback, JsString titleOrButtonLabels) { }

        /// <summary>
        /// The device will play a beep sound.
        /// </summary>
        /// <param name="times">The number of times to repeat the beep </param>
        /// <example>
        /// usage
        /// <code>
        /// // Beep twice!
        ///navigator.notification.beep(2);
        /// </code>
        /// </example>
        public void beep(JsNumber times) { }

        /// <summary>
        /// Vibrates the device for the specified amount of time.
        /// </summary>
        /// <param name="times"> Milliseconds to vibrate the device. 1000 milliseconds equals 1 second</param>
        /// <example>
        /// usage
        /// <code>
        /// // Vibrate for 2.5 seconds
        /// //
        ///navigator.notification.vibrate(2500);
        /// </code>
        /// </example>
        public void vibrate(JsNumber times) { }
    }

    /// <summary>
    ///  Callback to invoke with index of button pressed (1, 2 or 3)
    /// </summary>
    /// <param name="index">(1, 2 or 3)</param>
    public delegate void ConfirmCallback(JsNumber index);

    /// <summary>
    /// Contains methods that allow the user to manipulate the Database
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Runs a database transaction.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// function populateDB(tx) {
        ///     tx.executeSql('DROP TABLE IF EXISTS DEMO');
        ///     tx.executeSql('CREATE TABLE IF NOT EXISTS DEMO (id unique, data)');
        ///     tx.executeSql('INSERT INTO DEMO (id, data) VALUES (1, "First row")');
        ///     tx.executeSql('INSERT INTO DEMO (id, data) VALUES (2, "Second row")');
        ///}
        ///function errorCB(err) {
        ///    alert("Error processing SQL: "+err.code);
        ///}
        ///function successCB() {
        ///    alert("success!");
        ///}
        ///var db = window.openDatabase("Database", "1.0", "Cordova Demo", 200000);
        ///db.transaction(populateDB, errorCB, successCB);
        /// </code>
        /// </example>
        public void transaction(JsAction<SQLTransaction> action, JsAction<SQLError> errorCallback, JsAction successCallback) { }

        /// <summary>
        /// method allows scripts to atomically verify the version number and change it at the same time as doing a schema update.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// var db = window.openDatabase("Database", "1.0", "Cordova Demo", 200000);
        ///db.changeVersion("1.0", "1.1");
        /// </code>
        /// </example>
        public void changeVersion(JsString fromVersion, JsString toVersion) { }
    }

    /// <summary>
    /// Contains methods that allow the user to execute SQL statements against the Database.
    /// </summary>
    public class SQLTransaction
    {
        /// <summary>
        /// executes a SQL statement
        /// </summary>
        /// <returns></returns>
        public SQLResultSet executeSql(JsString sql) { return null; }
    }

    /// <summary>
    /// When the executeSql method of a SQLTransaction is called it will invoke it's callback with a SQLResultSet.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// function queryDB(tx) {
    ///    tx.executeSql('SELECT * FROM DEMO', [], querySuccess, errorCB);
    ///}
    ///function querySuccess(tx, results) {
    ///console.log("Returned rows = " + results.rows.length);
    /// // this will be true since it was a select statement and so rowsAffected was 0
    ///if (!resultSet.rowsAffected) {
    ///  console.log('No rows affected!');
    ///  return false;
    ///}
    /// // for an insert statement, this property will return the ID of the last inserted row
    ///console.log("Last inserted row ID = " + results.insertId);
    ///}
    ///function errorCB(err) {
    ///    alert("Error processing SQL: "+err.code);
    ///}
    ///var db = window.openDatabase("Database", "1.0", "Cordova Demo", 200000);
    ///db.transaction(queryDB, errorCB);
    /// </code>
    /// </example>
    public class SQLResultSet
    {
        /// <summary>
        /// the row ID of the row that the SQLResultSet object's SQL statement inserted into the database
        /// </summary>
        public JsNumber insertId { get; set; }

        /// <summary>
        /// the number of rows that were changed by the SQL statement. If the statement did not affect any rows then it is set to 0.
        /// </summary>
        public JsNumber rowsAffected { get; set; }

        /// <summary>
        ///  a SQLResultSetRowList representing the rows returned. If no rows are returned the object will be empty.
        /// </summary>
        public SQLResultSetList rows { get; set; }
    }

    /// <summary>
    /// One of the properties of the SQLResultSet containing the rows returned from a SQL query.
    /// </summary>
    /// <example>
    /// usage
    /// <code>
    /// function queryDB(tx) {
    ///    tx.executeSql('SELECT * FROM DEMO', [], querySuccess, errorCB);
    ///}
    ///function querySuccess(tx, results) {
    ///    var len = results.rows.length;
    ///    console.log("DEMO table: " + len + " rows found.");
    ///    for (var i=0; i<len; i++){
    ///        console.log("Row = " + i + " ID = " + results.rows.item(i).id + " Data =  " + results.rows.item(i).data);
    ///    }
    ///}
    ///function errorCB(err) {
    ///    alert("Error processing SQL: "+err.code);
    ///}
    ///var db = window.openDatabase("Database", "1.0", "Cordova Demo", 200000);
    ///db.transaction(queryDB, errorCB);
    /// </code>
    /// </example>
    public class SQLResultSetList
    {
        /// <summary>
        /// the number of rows returned by the SQL query
        /// </summary>
        public JsNumber length { get; set; }

        /// <summary>
        /// returns the row at the specified index represented by a JavaScript object.
        /// </summary>
        public object item { get; set; }
    }

    /// <summary>
    /// A SQLError object is thrown when an error occurs.
    /// </summary>
    public class SQLError
    {
        /// <summary>
        /// One of the predefined error codes listed below
        /// </summary>
        public JsNumber code { get; set; }

        /// <summary>
        ///  A description of the error.
        /// </summary>
        public object message { get; set; }

        public static SQLError UNKNOWN_ERR { get; private set; }
        public static SQLError DATABASE_ERR { get; private set; }
        public static SQLError VERSION_ERR { get; private set; }
        public static SQLError TOO_LARGE_ERR { get; private set; }
        public static SQLError QUOTA_ERR { get; private set; }
        public static SQLError SYNTAX_ERR { get; private set; }
        public static SQLError CONSTRAINT_ERR { get; private set; }
        public static SQLError TIMEOUT_ERR { get; private set; }


    }

    /// <summary>
    /// Provides access to a W3C Storage interface (http://dev.w3.org/html5/webstorage/#the-localstorage-attribute)
    /// </summary>
    public class LocalStorage
    {
        [JsProperty(Global = true, Name = "window.localStorage")]
        public static LocalStorage Current { get; private set; }

        /// <summary>
        /// Returns the name of the key at the position specified.
        /// </summary>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// var keyName = window.localStorage.key(0);
        /// </code>
        /// </example>
        public JsString key(JsNumber position) { return null; }

        /// <summary>
        /// Returns the item identified by it's key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// var value = window.localStorage.getItem("key");
        /// // value is now equal to "value"
        /// </code>
        /// </example>
        public JsString getItem(JsString key) { return null; }

        /// <summary>
        /// Saves and item at the key provided.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <example>
        /// usage
        /// <code>
        /// window.localStorage.setItem("key", "value");
        /// </code>
        /// </example>
        public void setItem(JsString key, JsString value) { }

        /// <summary>
        /// Removes the item identified by it's key.
        /// </summary>
        /// <param name="key"></param>
        /// <example>
        /// usage
        /// <code>
        /// window.localStorage.removeItem("key");
        /// </code>
        /// </example>
        public void removeItem(JsString key) { }

        /// <summary>
        ///  Removes all of the key value pairs.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// window.localStorage.clear();
        /// </code>
        /// </example>
        public void clear() { }



    }

    /// <summary>
    /// Provides access to the devices storage options.
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// This method will create a new SQL Lite Database and return a Database object. Use the Database Object to manipulate the data.
        /// </summary>
        /// <param name="database_name">The name of the database.</param>
        /// <param name="database_version">The version of the database.</param>
        /// <param name="database_displayname">The display name of the database.</param>
        /// <param name="database_size">The size of the database in bytes.</param>
        /// <returns></returns>
        public Database openDatabase(JsString database_name, JsString database_version, JsString database_displayname, JsNumber database_size) { return null; }
    }

    /// <summary>
    /// All PhoneGap events, in order to use, invisibly cast a document object to this (Events) type:
    /// <example>
    /// <code>
    /// var doc = HtmlContext.document.As&lt;Events&gt;();
    /// doc.deviceready += () => HtmlContext.alert("Deviceready");
    /// </code></example>
    /// </summary>
    public class Events
    {
        [JsMethod(Name="document")]
        public Events()
        {
        }
        /// <summary>
        /// This is an event that fires when Cordova is fully loaded.
        /// </summary>
        public event JsAction deviceready
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"deviceready\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"deviceready\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application is put into the background.
        /// </summary>
        public event JsAction pause
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"pause\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"pause\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application is retrieved from the background.
        /// </summary>
        public event JsAction resume
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"resume\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"resume\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application is online (connected to the Internet).
        /// </summary>
        public event JsAction online
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"online\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"online\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application is offline (not connected to the Internet).
        /// </summary>
        public event JsAction offline
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"offline\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"offline\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the back button.
        /// </summary>
        public event JsAction backbutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"backbutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"backbutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application detects the battery has reached the critical level threshold.
        /// </summary>
        public event JsAction<BatteryStatus> batterycritical
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"batterycritical\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"batterycritical\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application detects the battery has reached the low level threshold.
        /// </summary>
        public event JsAction<BatteryStatus> batterylow
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"batterylow\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"batterylow\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when a Cordova application detects the battery has reached the low level threshold.
        /// </summary>
        public event JsAction<BatteryStatus> batterystatus
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"batterystatus\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"batterystatus\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the menu button.
        /// </summary>
        public event JsAction menubutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"menubutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"menubutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the menu button.
        /// </summary>
        public event JsAction searchbutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"searchbutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"searchbutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the start call button.
        /// </summary>
        public event JsAction startcallbutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"startcallbutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"startcallbutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the end call button.
        /// </summary>
        public event JsAction endcallbutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"endcallbutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"endcallbutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the volume down button.
        /// </summary>
        public event JsAction volumedownbutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"volumedownbutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"volumedownbutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }

        /// <summary>
        /// This is an event that fires when the user presses the volume UP button.
        /// </summary>
        public event JsAction volumeupbutton
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"volumeupbutton\"", InsertArg2 = "false")]
            add
            {
            }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"volumeupbutton\"", InsertArg2 = "false")]
            remove
            {
            }
        }
    }

    /// <summary>
    /// The battery status handler will be called with an object that contains two properties:
    /// </summary>
    public class BatteryStatus
    {
        /// <summary>
        /// The percentage of battery (0-100).
        /// </summary>
        public JsNumber level { get; set; }
        /// <summary>
        ///  A boolean that represents whether or not the device is plugged in or not.
        /// </summary>
        public bool isPlugged { get; set; }
    }

}
