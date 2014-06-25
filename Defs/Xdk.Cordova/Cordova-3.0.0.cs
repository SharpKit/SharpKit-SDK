/*
 * -----------------------------------------------------------------------
 * Cordova wrapper for SharpKit / v1.0 (september 2013)
 * Copyright 2013 by Hervé PHILIPPE / http://alchiweb.fr / alchiweb@gmail.com
 * MIT Licence
 * -----------------------------------------------------------------------
 * SharpKit version: v5.2.0
 * Cordova version: 3.0.0
 *  for further info, see Apache Cordova at:
 * http://cordova.apache.org/
 * -----------------------------------------------------------------------
 * Remarks:
 * - events are 'static' because:
 *      . 'add' and 'remove' methods aren't generated globaly if the event isn't static
 *      . the generated code is relativ to 'document', not to the object
 * - all JS variables are C# properties 
 * - names of methods were renamed in C#, in order to begin the name with a capital letter
 * - names of properties aren't generaly renamed, in order to know that the are JS variables
 * - for renaming properties, add 'NativeField' attribute, like this: [JsProperty(Name = "contactid", NativeField = true)]
 * - I used JsNumber type if I don't know the type of the number (floating number or integer number).
 * - I used JsString type and I don't used string type.
 * - I don't used JsBoolean type.
*/

using System;                           // Reference: System
using SharpKit.JavaScript;              // Reference: SharpKit.DotNet.JavaScript
using SharpKit.DotNet.JavaScript;        // Reference: SharpKit.DotNet.JavaScript
using SharpKit.DotNet.Html;              // Reference: SharpKit.DotNet.Html
using System.Collections.Generic;

using SharpKit.DotNet.Html.battery;
using SharpKit.DotNet.Html.fileapi;
using SharpKit.DotNet.Html.gamepad;
using SharpKit.DotNet.Html.geolocation;
using SharpKit.DotNet.Html.html;
using SharpKit.DotNet.Html.html.shadow;
using SharpKit.DotNet.Html.html.track;
using SharpKit.DotNet.Html.indexeddb;
using SharpKit.DotNet.Html.inspector;
using SharpKit.DotNet.Html.intents;
using SharpKit.DotNet.Html.loader;
using SharpKit.DotNet.Html.loader.appcache;
using SharpKit.DotNet.Html.mediasource;
using SharpKit.DotNet.Html.mediastream;
using SharpKit.DotNet.Html.networkinfo;
using SharpKit.DotNet.Html.notifications;
using SharpKit.DotNet.Html.plugins;
using SharpKit.DotNet.Html.proximity;
using SharpKit.DotNet.Html.quota;
using SharpKit.DotNet.Html.speech;
using SharpKit.DotNet.Html.storage;
using SharpKit.DotNet.Html.svg;
using SharpKit.DotNet.Html.webaudio;
using SharpKit.DotNet.Html.webdatabase;
using SharpKit.DotNet.Html.workers;

[assembly: JsNamespace(Namespace = "SharpKit.DotNet.Cordova", JsNamespace = "")]
namespace SharpKit.DotNet.Cordova
{
    #region Global
    /// <summary>
    /// Global variables
    /// </summary>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true, OmitInheritance = true)]
    public partial class Cordova
    {
        /// <summary>
        /// Captures device motion in the x, y, and z direction.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#Accelerometer
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.accelerometer", NativeField = true)]
        public static Accelerometer accelerometer { get; set; }
        /// <summary>
        /// The camera object provides access to the device's default camera application.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#Camera
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.camera", NativeField = true)]
        public static Camera camera { get; set; }
        /// <summary>
        /// Obtains the direction that the device is pointing.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#Compass
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.compass", NativeField = true)]
        public static Compass compass { get; set; }
        /// <summary>
        /// The connection object, exposed via Cordova.connection, provides information about the device's cellular and wifi connection.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_connection_connection.md.html#Connection
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.connection", NativeField = true)]
        public static Connection connection { get; set; }
        /// <summary>
        /// The contacts object provides access to the device contacts database.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contacts
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.contacts", NativeField = true)]
        public static Contacts contacts { get; set; }
        /// <summary>
        /// The device object describes the device's hardware and software.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.md.html#Device
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.device", NativeField = true)]
        public static Device device { get; set; }
        /// <summary>
        /// Obtains information and performs operations specific to the user's locale and timezone.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.globalization", NativeField = true)]
        public static Globalization globalization { get; set; }
        /// <summary>
        /// Visual, audible, and tactile device notifications.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification
        /// </remarks>
        [JsProperty(Global = true, Name = "navigator.notification", NativeField = true)]
        public static DeviceNotification notification { get; set; }


        #region Events
        /// <summary>
        /// The event fires when Cordova is fully loaded.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#DeviceReady
        /// </remarks>
        public static event EventListener<CordovaEvent> OnDeviceReady
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"deviceready\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"deviceready\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when an application is put into the background.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#Pause
        /// </remarks>
        public static event EventListener<CordovaEvent> OnPause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"pause\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"pause\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when an application is retrieved from the background.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#Resume
        /// </remarks>
        public static event EventListener<CordovaEvent> OnResume
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"resume\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"resume\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event fires when an application goes online, and the device becomes connected to the Internet.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#Online
        /// </remarks>
        public static event EventListener<CordovaEvent> OnOnline
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"online\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"online\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when an application goes offline, and the device is not connected to the Internet.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#Offline
        /// </remarks>
        public static event EventListener<CordovaEvent> OnOffline
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"offline\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"offline\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the user presses the back button.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#BackButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnBackButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"backbutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"backbutton\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the battery has reached the critical level threshold.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#BatteryCritical
        /// </remarks>
        public static event EventListener<CordovaBatteryEvent> OnBatteryCritical
        {
            [JsMethod(Global = true, Name = "window.addEventListener", InsertArg0 = "\"batterycritical\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "window.removeEventListener", InsertArg0 = "\"batterycritical\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the battery has reached the low level threshold.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#BatteryLow
        /// </remarks>
        public static event EventListener<CordovaBatteryEvent> OnBatteryLow
        {
            [JsMethod(Global = true, Name = "window.addEventListener", InsertArg0 = "\"batterylow\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "window.removeEventListener", InsertArg0 = "\"batterylow\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when there is a change in the battery status.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#BatteryStatus
        /// </remarks>
        public static event EventListener<CordovaBatteryEvent> OnBatteryStatus
        {
            [JsMethod(Global = true, Name = "window.addEventListener", InsertArg0 = "\"batterystatus\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "window.removeEventListener", InsertArg0 = "\"batterystatus\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the user presses the menu button.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#MenuButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnMenuButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"menubutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"menubutton\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the user presses the search button on Android.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#SearchButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnSearchButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"searchbutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"searchbutton\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the user presses the start call button.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#StartCallButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnStartCallButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"startcallbutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"startcallbutton\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event fires when the user presses the end call button.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#EndCallButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnEndCallButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"endcallbutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"endcallbutton\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the user presses the volume down button.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#VolumeDownButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnVolumeDownButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"volumedownbutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"volumedownbutton\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// The event fires when the user presses the volume up button.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#VolumeUpButton
        /// </remarks>
        public static event EventListener<CordovaEvent> OnVolumeUpButton
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"volumeupbutton\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"volumeupbutton\"", InsertArg1 = "false")]
            remove { }
        }
        #endregion

        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(CordovaEventType type, EventListener<CordovaEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(CordovaEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(CordovaEventType type, EventListener<CordovaEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "window.addEventListener")]
        public static void AddEventListener(CordovaBatteryEventType type, EventListener<CordovaBatteryEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "window.dispatchEvent")]
        public static bool DispatchEvent(CordovaBatteryEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "window.removeEventListener")]
        public static void RemoveEventListener(CordovaBatteryEventType type, EventListener<CordovaBatteryEvent> listener, bool useCapture = false) { }



    }
    #endregion

    #region Accelerometer
    /// <summary>
    /// Callback function that provides the <see cref="Acceleration"/> information.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#AccelerometerSuccessCallback
    /// </remarks>
    /// <param name="acceleration"></param>
    public delegate void AccelerometerSuccessCallback(Acceleration acceleration);
    /// <summary>
    /// Callback function for acceleration functions.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#AccelerometerErrorCallback
    /// </remarks>
    public delegate void AccelerometerErrorCallback();
    /// <summary>
    /// Contains <see cref="Accelerometer"/> data captured at a specific point in time.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#Acceleration
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Acceleration
    {
        /// <summary>
        /// Amount of acceleration on the x-axis. (in m/s^2)
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// Amount of acceleration on the y-axis. (in m/s^2)
        /// </summary>
        public double y { get; set; }
        /// <summary>
        /// Amount of acceleration on the z-axis. (in m/s^2)
        /// </summary>
        public double z { get; set; }
        /// <summary>
        /// Creation timestamp in milliseconds. (DOMTimeStamp)
        /// </summary>
        public long timestamp { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">Amount of acceleration on the x-axis.</param>
        /// <param name="y">Amount of acceleration on the y-axis.</param>
        /// <param name="z">Amount of acceleration on the z-axis.</param>
        /// <param name="timestamp">Creation timestamp in milliseconds.</param>
        public Acceleration(double x, double y, double z, long timestamp) { }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Acceleration() { }
    }
    /// <summary>
    /// Used to customize the retrieval of accelerometer values.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#AccelerometerOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class AccelerometerOptions
    {
        /// <summary>
        /// How often to retrieve the <see cref="Acceleration"/> in milliseconds. (Number) (Default: 10000)
        /// </summary>
        public long frequency { get; set; }
    }
    /// <summary>
    /// Captures device motion in the x, y, and z direction.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#Accelerometer
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class Accelerometer
    {
        /// <summary>
        /// Get the current acceleration along the x, y, and z axes.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#accelerometer.GetCurrentAcceleration
        /// </remarks>
        /// <param name="accelerometerSuccess">Callback function that provides the <see cref="Acceleration"/> information.</param>
        /// <param name="accelerometerError"></param>
        [JsMethod(Name = "getCurrentAcceleration")]
        public void GetCurrentAcceleration(AccelerometerSuccessCallback accelerometerSuccess, AccelerometerErrorCallback accelerometerError) { }
        /// <summary>
        /// At a regular interval, get the acceleration along the x, y, and z axis.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#accelerometer.WatchAcceleration
        /// </remarks>
        /// <param name="accelerometerSuccess">Callback function that provides the <see cref="Acceleration"/> information.</param>
        /// <param name="accelerometerError"></param>
        /// <param name="accelerometerOptions">An optional parameter to customize the retrieval of accelerometer values.</param>
        /// <returns>The returned watch ID references the accelerometer's watch interval, and can be used with <see cref="ClearWatch"/> to stop watching the accelerometer.</returns>
        [JsMethod(Name = "watchAcceleration")]
        public JsString WatchAcceleration(AccelerometerSuccessCallback accelerometerSuccess, AccelerometerErrorCallback accelerometerError, AccelerometerOptions accelerometerOptions = null) { return default(JsString); }
        /// <summary>
        /// Stop watching the <see cref="Acceleration"/> referenced by the watchId parameter.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_accelerometer_accelerometer.md.html#accelerometer.ClearAcceleration
        /// </remarks>
        /// <param name="watchId">The ID returned by <see cref="WatchAcceleration"/>.</param>
        [JsMethod(Name = "clearWatch")]
        public void ClearWatch(JsString watchId) { }
    }
    #endregion

    #region Camera
    /// <summary>
    /// Callback function that provides the image data.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraSuccessCallback
    /// </remarks>
    /// <param name="imageData">Base64 encoding of the image data, or the image file URI, depending on <see cref="CameraOptions"/> in effect.</param>
    public delegate void CameraSuccessCallback(JsString imageData);
    /// <summary>
    /// Callback function that provides an error message.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraErrorCallback
    /// </remarks>
    /// <param name="message">The message is provided by the device's native code.</param>
    public delegate void CameraErrorCallback(JsString message);

    /// <summary>
    /// Set the source of the picture.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CameraPictureSourceType
    {
        PHOTOLIBRARY = 0,
        CAMERA = 1,
        SAVEDPHOTOALBUM = 2
    }
    /// <summary>
    /// Choose the format of the return value.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CameraDestinationType
    {
        /// <summary>
        /// Return image as base64-encoded JsString.
        /// </summary>
        DATA_URL = 0,
        /// <summary>
        /// Return image file URI.
        /// </summary>
        FILE_URI = 1,
        /// <summary>
        /// Return image native URI (e.g., assets-library: on iOS or content: on Android).
        /// </summary>
        NATIVE_URI = 2
    };
    /// <summary>
    /// Choose the returned image file's encoding.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CameraEncodingType
    {
        /// <summary>
        /// Return JPEG encoded image.
        /// </summary>
        JPEG = 0,
        /// <summary>
        /// Return PNG encoded image.
        /// </summary>
        PNG = 1
    };
    /// <summary>
    /// Set the type of media to select from. Only works when sourceType is CameraPictureSourceType.PHOTOLIBRARY or CameraPictureSourceType.SAVEDPHOTOALBUM.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CameraMediaType
    {
        /// <summary>
        /// Allow selection of still pictures only. DEFAULT. Will return format specified via <see cref="CameraDestinationType"/>.
        /// </summary>
        PICTURE = 0,
        /// <summary>
        /// Allow selection of video only, WILL ALWAYS RETURN FILE_URI.
        /// </summary>
        VIDEO = 1,
        /// <summary>
        /// Allow selection from all media types.
        /// </summary>
        ALLMEDIA = 2
    }

    /// <summary>
    /// Choose the camera to use (front- or back-facing).
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CameraDirection
    {
        /// <summary>
        /// Use the back-facing camera
        /// </summary>
        BACK = 0,
        /// <summary>
        /// Use the front-facing camera
        /// </summary>
        FRONT = 1
    }
    /// <summary>
    /// Direction the arrow on the popover should point.
    /// <para>Matches iOS UIPopoverArrowDirection constants.</para>
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraPopoverOptions
    /// </remarks>
    [Flags]
    [JsType(JsMode.Json, Export = false)]
    public enum CameraPopoverArrowDirection
    {
        ARROW_UP = 1,
        ARROW_DOWN = 2,
        ARROW_LEFT = 4,
        ARROW_RIGHT = 8,
        ARROW_ANY = 15
    };
    /// <summary>
    /// iOS-only options that specify popover location in iPad.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraPopoverOptions
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CameraPopoverOptions
    {
        /// <summary>
        /// X pixel coordinate of screen element onto which to anchor the popover.
        /// <para>Default value: 0</para>
        /// </summary>
        public long x { get; set; }
        /// <summary>
        /// Y pixel coordinate of screen element onto which to anchor the popover.
        /// <para>Default value: 32</para>
        /// </summary>
        public long y { get; set; }
        /// <summary>
        /// Width, in pixels, of the screen element onto which to anchor the popover.
        /// <para>Default value: 320</para>
        /// </summary>
        public long width { get; set; }
        /// <summary>
        /// Height, in pixels, of the screen element onto which to anchor the popover.
        /// <para>Default value: 480</para>
        /// </summary>
        public long height { get; set; }
        /// <summary>
        /// Direction the arrow on the popover should point.
        /// <para>Default value: CameraPopoverArrowDirection.ARROW_ANY</para>
        /// </summary>
        public CameraPopoverArrowDirection arrowDir;

        /// <summary>
        /// Constructor of CameraPopoverOptions.
        /// </summary>
        /// <param name="x">x pixel coordinate of screen element onto which to anchor the popover.</param>
        /// <param name="y">y pixel coordinate of screen element onto which to anchor the popover.</param>
        /// <param name="width">width, in pixels, of the screen element onto which to anchor the popover.</param>
        /// <param name="height">height, in pixels, of the screen element onto which to anchor the popover.</param>
        /// <param name="arrowDir">direction the arrow on the popover should point.</param>
        public CameraPopoverOptions(long x = 0, long y = 32, long width = 320, long height = 480, CameraPopoverArrowDirection arrowDir = CameraPopoverArrowDirection.ARROW_ANY) { }
    }

    /// <summary>
    /// A handle to the popover dialog created by <see cref="Camera.GetPicture"/>.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraPopoverHandle
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CameraPopoverHandle
    {
        /// <summary>
        /// Set the position of the popover.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraPopoverHandle
        /// </remarks>
        /// <param name="popoverOptions"></param>
        [JsMethod(Name = "setPosition")]
        public void SetPosition(CameraPopoverOptions popoverOptions) { }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CameraPopoverHandle() { }
    }
    /// <summary>
    /// Optional parameters to customize the camera settings.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#CameraOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class CameraOptions
    {
        /// <summary>
        /// Quality of the saved image, expressed as a range of 0-100, where 100 is typically full resolution with no loss from file compression. (Note that information about the camera's resolution is unavailable.)
        /// <para>Default value: 75</para>
        /// </summary>
        public long quality { get; set; }
        /// <summary>
        /// Choose the format of the return value.
        /// <para>Default value: CameraDestinationType.DATA_URL</para>
        /// </summary>
        public CameraDestinationType destinationType { get; set; }
        /// <summary>
        /// Set the source of the picture.
        /// <para>Default value: CameraPictureSourceType.CAMERA</para>
        /// </summary>
        public CameraPictureSourceType sourceType { get; set; }
        /// <summary>
        /// Allow simple editing of image before selection.
        /// <para>Default value: true</para>
        /// </summary>
        public bool allowEdit { get; set; }
        /// <summary>
        /// Choose the returned image file's encoding.
        /// <para>Default value: CameraEncodingType.JPEG</para>
        /// </summary>
        public CameraEncodingType encodingType { get; set; }
        /// <summary>
        /// Width in pixels to scale image. Must be used with targetHeight. Aspect ratio remains constant.
        /// <para>Default value: 100</para>
        /// </summary>
        public long targetWidth { get; set; }
        /// <summary>
        /// Height in pixels to scale image. Must be used with targetWidth. Aspect ratio remains constant.
        /// <para>Default value: 100</para>
        /// </summary>
        public long targetHeight { get; set; }
        /// <summary>
        /// Save the image to the photo album on the device after capture.
        /// <para>Default value: false</para>
        /// </summary>
        public bool saveToPhotoAlbum { get; set; }
        /// <summary>
        /// iOS-only options that specify popover location in iPad.
        /// </summary>
        public CameraPopoverOptions popoverOptions { get; set; }
        /// <summary>
        /// Set the type of media to select from. Only works when sourceType is CameraPictureSourceType.PHOTOLIBRARY or CameraPictureSourceType.SAVEDPHOTOALBUM.
        /// </summary>
        public CameraMediaType mediaType { get; set; }
        /// <summary>
        /// Rotate the image to correct for the orientation of the device during capture.
        /// </summary>
        public bool correctOrientation { get; set; }
        /// <summary>
        /// Choose the camera to use (front- or back-facing).
        /// </summary>
        public CameraDirection cameraDirection { get; set; }
    }
    /// <summary>
    /// The camera object provides access to the device's default camera application.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#Camera
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Camera
    {
        /// <summary>
        /// Takes a photo using the camera, or retrieves a photo from the device's image gallery. The image is passed to the success callback as a base64-encoded String, or as the URI for the image file. The method itself returns a <see cref="CameraPopoverHandle"/> object that can be used to reposition the file selection popover.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.md.html#camera.GetPicture
        /// </remarks>
        /// <param name="cameraSuccess">Callback function that provides the image data.</param>
        /// <param name="cameraError">Callback function that provides an error message.</param>
        /// <param name="cameraOptions">Optional parameters to customize the camera settings.</param>
        /// <returns>A handle to the popover dialog.</returns>
        [JsMethod(Name = "getPicture")]
        public CameraPopoverHandle GetPicture(CameraSuccessCallback cameraSuccess, CameraErrorCallback cameraError, CameraOptions cameraOptions = null) { return default(CameraPopoverHandle); }
        /// <summary>
        /// Removes intermediate photos taken by the camera from temporary storage.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_camera_camera.cleanup.md.html#camera.Cleanup
        /// </remarks>
        /// <param name="cameraSuccess">Callback function that provides the image data.</param>
        /// <param name="cameraError">Callback function that provides an error message.</param>
        [JsMethod(Name = "cleanup")]
        public void Cleanup(CameraSuccessCallback cameraSuccess, CameraErrorCallback cameraError) { }
    }
    #endregion

    #region MediaFile
    /// <summary>
    /// Invoked upon a successful <see cref="MediaFile.GetFormatData"/> operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#MediaFile.GetFormatData
    /// </remarks>
    /// <param name="mediaFileData"></param>
    public delegate void MediaFileDataSuccessCallback(MediaFileData mediaFileData);
    /// <summary>
    /// Invoked if an error occurs during a <see cref="MediaFile.GetFormatData"/> operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#MediaFile.GetFormatData
    /// </remarks>
    public delegate void MediaFileDataErrorCallback();

    /// <summary>
    /// Encapsulates format information about a media file
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#MediaFileData
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class MediaFileData
    {
        /// <summary>
        /// The actual format of the audio and video content.
        /// </summary>
        public JsString codecs { get; set; }
        /// <summary>
        /// The average bitrate of the content. The value is zero for images.
        /// </summary>
        public double bitrate { get; set; }
        /// <summary>
        /// The height of the image or video in pixels. The value is zero for audio clips.
        /// </summary>
        public double height { get; set; }
        /// <summary>
        /// The width of the image or video in pixels. The value is zero for audio clips.
        /// </summary>
        public double width { get; set; }
        /// <summary>
        /// The length of the video or sound clip in seconds. The value is zero for images.
        /// </summary>
        public double duration { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="codecs">The actual format of the audio and video content.</param>
        /// <param name="bitrate">The average bitrate of the content. The value is zero for images.</param>
        /// <param name="height">The height of the image or video in pixels. The value is zero for audio clips.</param>
        /// <param name="width">The width of the image or video in pixels. The value is zero for audio clips.</param>
        /// <param name="duration">The length of the video or sound clip in seconds. The value is zero for images.</param>
        public MediaFileData(JsString codecs = null, double bitrate = 0, double height = 0, double width = 0, double duration = 0) { }
    }
    /// <summary>
    /// Encapsulates properties of a media capture file.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#MediaFile
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class MediaFile
    {
        /// <summary>
        /// The name of the file, without path information.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The full path of the file, including the name.
        /// </summary>
        public JsString fullPath { get; set; }
        /// <summary>
        /// The file's mime type.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The date and time when the file was last modified.
        /// </summary>
        public JsDate lastModifiedDate { get; set; }
        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        public long size { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MediaFile() { }
        /// <summary>
        /// Retrieves format information about the media capture file.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#MediaFile.GetFormatData
        /// </remarks>
        /// <param name="mediaFileDataSuccess"></param>
        /// <param name="mediaFileDataError"></param>
        [JsMethod(Name = "getFormatData")]
        public void GetFormatData(MediaFileDataSuccessCallback mediaFileDataSuccess, MediaFileDataErrorCallback mediaFileDataError = null) { }
    }

    #endregion

    #region Capture
    /// <summary>
    /// Invoked upon a successful media capture operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureSuccessCallback
    /// </remarks>
    /// <param name="mediaFiles">Each <see cref="MediaFile"/> object describes a captured media file.</param>
    public delegate void CaptureSuccessCallback(JsArray<MediaFile> mediaFiles);
    /// <summary>
    /// Invoked if an error occurs during a media capture operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureErrorCallback
    /// </remarks>
    /// <param name="error">Encapsulates the error code resulting from a failed media capture operation.</param>
    public delegate void CaptureErrorCallback(CaptureError error);

    /// <summary>
    /// Error code type after a failed media capture operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureError
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CaptureErrorCode
    {
        /// <summary>
        /// The camera or microphone failed to capture image or sound.
        /// </summary>
        CAPTURE_INTERNAL_ERR = 0,
        /// <summary>
        /// The camera or audio capture application is currently serving another capture request.
        /// </summary>
        CAPTURE_APPLICATION_BUSY = 1,
        /// <summary>
        /// Invalid use of the API (e.g., the value of limit is less than one).
        /// </summary>
        CAPTURE_INVALID_ARGUMENT = 2,
        /// <summary>
        /// The user exits the camera or audio capture application before capturing anything.
        /// </summary>
        CAPTURE_NO_MEDIA_FILES = 3,
        /// <summary>
        /// The requested capture operation is not supported.
        /// </summary>
        CAPTURE_NOT_SUPPORTED = 20
    };
    /// <summary>
    /// Encapsulates the error code resulting from a failed media capture operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureError
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CaptureError
    {
        /// <summary>
        /// Error code resulting from a failed media capture operation.
        /// </summary>
        public CaptureErrorCode code { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code">Error code</param>
        public CaptureError(CaptureErrorCode code) { }
        /// <summary>
        /// Default constructor
        /// </summary>
        public CaptureError() { }
    }

    /// <summary>
    /// Encapsulates a set of media capture parameters that a device supports.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#ConfigurationData
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ConfigurationData
    {
        /// <summary>
        /// The ASCII-encoded lowercase JsString representing the media type.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The width of the image or video in pixels. The value is zero for sound clips.
        /// </summary>
        public long width { get; set; }
        /// <summary>
        /// The height of the image or video in pixels. The value is zero for sound clips.
        /// </summary>
        public long height { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ConfigurationData() { }
    }

    /// <summary>
    /// Encapsulates audio capture configuration options.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureAudioOptions
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CaptureAudioOptions
    {
        /// <summary>
        /// The maximum number of audio clips the device user can record in a single capture operation. The value must be greater than or equal to 1.
        /// <para>Default: 1</para>
        /// </summary>
        public long limit { get; set; }
        /// <summary>
        /// The maximum duration of an audio sound clip, in seconds.
        /// <para>Default: 0</para>
        /// </summary>
        public double duration { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CaptureAudioOptions() { }
    }

    /// <summary>
    /// Encapsulates video capture configuration options.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureVideoOptions
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CaptureVideoOptions
    {
        /// <summary>
        /// TThe maximum number of video clips the device's user can capture in a single capture operation. The value must be greater than or equal to 1.
        /// <para>Default: 1</para>
        /// </summary>
        public long limit { get; set; }
        /// <summary>
        /// The maximum duration of a video clip, in seconds.
        /// <para>Default: 0</para>
        /// </summary>
        public double duration { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CaptureVideoOptions() { }
    }

    /// <summary>
    /// Encapsulates image capture configuration options.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#CaptureImageOptions
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CaptureImageOptions
    {
        /// <summary>
        /// The maximum number of images the user can capture in a single capture operation. The value must be greater than or equal to 1.
        /// <para>Default: 1</para>
        /// </summary>
        public long limit { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CaptureImageOptions() { }
    }

    /// <summary>
    /// Provides access to the device's audio, image, and video capture capabilities.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#Capture
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Capture
    {
        /// <summary>
        /// The audio recording formats supported by the device.
        /// </summary>
        public JsArray<ConfigurationData> supportedAudioModes { get; set; }
        /// <summary>
        /// The recording image sizes and formats supported by the device.
        /// </summary>
        public JsArray<ConfigurationData> supportedImageModes { get; set; }
        /// <summary>
        /// The recording video resolutions and formats supported by the device.
        /// </summary>
        public JsArray<ConfigurationData> supportedVideoModes { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Capture() { }
        /// <summary>
        /// Start the audio recorder application and return information about captured audio clip files.
        /// </summary>
        /// <remarks>
        /// http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#capture.CaptureAudio
        /// </remarks>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        [JsMethod(Name = "captureAudio")]
        public void CaptureAudio(CaptureSuccessCallback captureSuccess, CaptureErrorCallback captureError, CaptureAudioOptions options = null) { }

        /// <summary>
        /// Start the video recorder application and return information about captured video clip files.
        /// </summary>
        /// <remarks>
        /// http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#capture.CaptureVideo
        /// </remarks>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        [JsMethod(Name = "captureVideo")]
        public void CaptureVideo(CaptureSuccessCallback captureSuccess, CaptureErrorCallback captureError, CaptureVideoOptions options = null) { }

        /// <summary>
        /// Start the camera application and return information about captured image files.
        /// </summary>
        /// <remarks>
        /// http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#capture.CaptureImage
        /// </remarks>
        /// <param name="captureSuccess"></param>
        /// <param name="captureError"></param>
        /// <param name="options"></param>
        [JsMethod(Name = "captureImage")]
        public void CaptureImage(CaptureSuccessCallback captureSuccess, CaptureErrorCallback captureError, CaptureImageOptions options = null) { }
    }
    #endregion

    #region Compass
    /// <summary>
    /// Success callback function that provides the compass heading information via a <see cref="CompassHeading"/> object.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#CompassSuccessCallback
    /// </remarks>
    /// <param name="heading">The heading information.</param>
    public delegate void CompassSuccessCallback(CompassHeading heading);
    /// <summary>
    /// Error callback function for compass functions.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#CompassErrorCallback
    /// </remarks>
    /// <param name="error">Encapsulates the error code resulting from a failed compass operation.</param>
    public delegate void CompassErrorCallback(CompassError error);

    /// <summary>
    /// Error code for a failed compass operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#CompassError
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum CompassErrorCode
    {
        COMPASS_INTERNAL_ERR = 0,
        COMPASS_NOT_SUPPORTED = 20
    };
    /// <summary>
    /// Encapsulates the error code resulting from a failed compass operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#CompassError
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CompassError
    {
        /// <summary>
        /// Error code resulting from a failed compass operation.
        /// </summary>
        public CompassErrorCode code { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        public CompassError(CompassErrorCode code) { }
        /// <summary>
        /// Default constructor
        /// </summary>
        public CompassError() { }
    }
    /// <summary>
    /// A CompassHeading object is returned to the <see cref="CompassSuccessCallback"/> callback function.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#CompassHeading
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class CompassHeading
    {
        /// <summary>
        /// The heading in degrees from 0-359.99 at a single moment in time.
        /// </summary>
        public double magneticHeading { get; set; }
        /// <summary>
        /// The heading relative to the geographic North Pole in degrees 0-359.99 at a single moment in time. A negative value indicates that the true heading cannot be determined.
        /// </summary>
        public double trueHeading { get; set; }
        /// <summary>
        /// The deviation in degrees between the reported heading and the true heading.
        /// </summary>
        public double headingAccuracy { get; set; }
        /// <summary>
        /// The time at which this heading was determined.
        /// </summary>
        public long timestamp { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="magneticHeading">The heading in degrees from 0-359.99 at a single moment in time.</param>
        /// <param name="trueHeading">The heading relative to the geographic North Pole in degrees 0-359.99 at a single moment in time. A negative value indicates that the true heading cannot be determined.</param>
        /// <param name="headingAccuracy">The deviation in degrees between the reported heading and the true heading.</param>
        /// <param name="timestamp">The time at which this heading was determined.</param>
        public CompassHeading(double magneticHeading, double trueHeading, double headingAccuracy, long timestamp) { }
        /// <summary>
        /// Default constructor
        /// </summary>
        public CompassHeading() { }
    }
    /// <summary>
    /// An optional parameter to customize the retrieval of the compass.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#CompassOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class CompassOptions
    {
        /// <summary>
        /// How often to retrieve the compass heading in milliseconds.
        /// </summary>
        public long frequency { get; set; }
        /// <summary>
        /// The change in degrees required to initiate a <see cref="Compass.WatchHeading"/> success callback.
        /// </summary>
        public double filter { get; set; }
    }
    /// <summary>
    /// Obtains the direction that the device is pointing.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#Compass
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class Compass
    {
        /// <summary>
        /// Get the current compass heading.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#compass.GetCurrentHeading
        /// </remarks>
        /// <param name="compassSuccess">Callback function that provides the compass heading information via a <see cref="CompassHeading"/> object.</param>
        /// <param name="compassError">Callback function for compass functions.</param>
        /// <param name="options">An optional parameter to customize the retrieval of the compass.</param>
        [JsMethod(Name = "getCurrentHeading")]
        public void GetCurrentHeading(CompassSuccessCallback compassSuccess, CompassErrorCallback compassError, CompassOptions options = null) { }
        /// <summary>
        /// At a regular interval, get the compass heading in degrees.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#compass.WatchHeading
        /// </remarks>
        /// <param name="compassSuccess">Callback function that provides the compass heading information via a <see cref="CompassHeading"/> object.</param>
        /// <param name="compassError">Callback function for compass functions.</param>
        /// <param name="options">An optional parameter to customize the retrieval of the compass.</param>
        /// <returns>The returned watch ID references the compass watch interval. The watch ID can be used with <see cref="ClearWatch"/> to stop watching the compass.</returns>
        [JsMethod(Name = "watchHeading")]
        public JsString WatchHeading(CompassSuccessCallback compassSuccess, CompassErrorCallback compassError, CompassOptions options = null) { return default(JsString); }
        /// <summary>
        /// Stop watching the compass referenced by the watch ID parameter.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_compass_compass.md.html#compass.ClearWatch
        /// </remarks>
        /// <param name="watchId">The ID returned by <see cref="WatchHeading"/>.</param>
        [JsMethod(Name = "clearWatch")]
        public void ClearWatch(JsString watchId) { }
    }
    #endregion

    #region Connection
    /// <summary>
    /// Checks the currently active network connection.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_connection_connection.md.html#ConnectionType
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum ConnectionType
    {
        [JsField(Name = "unknown")]
        UNKNOWN = 0,
        [JsField(Name = "ethernet")]
        ETHERNET,
        [JsField(Name = "wifi")]
        WIFI,
        [JsField(Name = "2g")]
        CELL_2G,
        [JsField(Name = "3g")]
        CELL_3G,
        [JsField(Name = "4g")]
        CELL_4G,
        [JsField(Name = "cellular")]
        CELL,
        [JsField(Name = "none")]
        NONE
    }
    /// <summary>
    /// The connection object, exposed via Cordova.connection, provides information about the device's cellular and wifi connection.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_connection_connection.md.html#Connection
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class Connection
    {
        /// <summary>
        /// Checks the currently active network connection.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_connection_connection.md.html#ConnectionType
        /// </remarks>
        public ConnectionType type { get; set; }
    }
    #endregion

    #region Contacts
    /// <summary>
    /// Success callback function that provides the Contact array resulting from a <see cref="Contacts.Find"/> operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#ContactFindSuccessCallback
    /// </remarks>
    /// <param name="contacts">The contact array resulting from a find operation.</param>
    public delegate void ContactFindSuccessCallback(JsArray<Contact> contacts);
    /// <summary>
    /// Success callback function resulting from a <see cref="Contact.Remove"/> operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contact
    /// </remarks>
    public delegate void ContactRemoveSuccessCallback();
    /// <summary>
    /// Success callback function resulting from a <see cref="Contact.Save"/> operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contact
    /// </remarks>
    /// <param name="contact">The saved contact.</param>
    public delegate void ContactSaveSuccessCallback(Contact contact);
    /// <summary>
    /// Error callback function for contact functions.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#ContactErrorCallback
    /// </remarks>
    /// <param name="error">Encapsulates the error code resulting from a failed contact operation.</param>
    public delegate void ContactErrorCallback(ContactError error);

    /// <summary>
    /// Error code for a failed contact operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contacts
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum ContactErrorCode
    {
        UNKNOWN_ERROR = 0,
        INVALID_ARGUMENT_ERROR = 1,
        IMEOUT_ERROR = 2,
        PENDING_OPERATION_ERROR = 3,
        IO_ERROR = 4,
        NOT_SUPPORTED_ERROR = 5,
        PERMISSION_DENIED_ERROR = 20
    };
    /// <summary>
    /// Encapsulates the error code resulting from a failed contact operation.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contacts
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ContactError
    {
        /// <summary>
        /// Error code resulting from a failed contact operation.
        /// </summary>
        public ContactErrorCode code { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code">Error code</param>
        public ContactError(ContactErrorCode code) { }
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactError() { }
    }
    /// <summary>
    /// A CompassHeading object is returned to the <see cref="CompassSuccessCallback"/> callback function.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contacts
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class ContactsHeading
    {
        /// <summary>
        /// The heading in degrees from 0-359.99 at a single moment in time.
        /// </summary>
        public double magneticHeading { get; set; }
        /// <summary>
        /// The heading relative to the geographic North Pole in degrees 0-359.99 at a single moment in time. A negative value indicates that the true heading cannot be determined.
        /// </summary>
        public double trueHeading { get; set; }
        /// <summary>
        /// The deviation in degrees between the reported heading and the true heading.
        /// </summary>
        public double headingAccuracy { get; set; }
        /// <summary>
        /// The time at which this heading was determined.
        /// </summary>
        public long timestamp { get; set; }
    }
    /// <summary>
    /// Optional parameter of the <see cref="Contacts.Find"/> method, used to filter the contacts returned from the contacts database.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contacts
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ContactFindOptions
    {
        /// <summary>
        /// The search JsString used to filter contacts.
        /// <para>Default: ""</para>
        /// </summary>
        public JsString filter { get; set; }
        /// <summary>
        /// The change in degrees required to initiate a <see cref="Compass.WatchHeading"/> success callback.
        /// <para>Default: false</para>
        /// </summary>
        public bool multiple { get; set; }
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactFindOptions() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filter">The search JsString used to filter contacts.</param>
        /// <param name="multiple">Determines if the find operation returns multiple contacts.</param>
        public ContactFindOptions(JsString filter, bool multiple = false) { }
    }
    /// <summary>
    /// Contains properties that describe a contact, such as a user's personal or business contact.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contact
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Contact
    {
        /// <summary>
        /// private?
        /// </summary>
        public JsString rawId { get; set; }
        /// <summary>
        /// A globally unique identifier.
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// The name of this contact, suitable for display to end-users.
        /// </summary>
        public JsString displayName { get; set; }
        /// <summary>
        /// An object containing all components of a persons name.
        /// </summary>
        public ContactName name { get; set; }
        /// <summary>
        /// A casual name by which to address the contact.
        /// </summary>
        public JsString nickname { get; set; }
        /// <summary>
        /// An array of all the contact's phone numbers.
        /// </summary>
        public JsArray<ContactField> phoneNumbers { get; set; }
        /// <summary>
        /// An array of all the contact's email addresses.
        /// </summary>
        public JsArray<ContactField> emails { get; set; }
        /// <summary>
        /// An array of all the contact's addresses.
        /// </summary>
        public JsArray<ContactAddress> addresses { get; set; }
        /// <summary>
        /// An array of all the contact's IM addresses.
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
        /// An array of the contact's photos.
        /// </summary>
        public JsArray<ContactField> photos { get; set; }
        /// <summary>
        /// An array of all the user-defined categories associated with the contact.
        /// </summary>
        public JsArray<ContactField> categories { get; set; }
        /// <summary>
        /// An array of web pages associated with the contact.
        /// </summary>
        public JsArray<ContactField> urls { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">A globally unique identifier.</param>
        /// <param name="displayName">The name of this contact, suitable for display to end-users.</param>
        /// <param name="name">An object containing all components of a persons name.</param>
        /// <param name="nickname">A casual name by which to address the contact.</param>
        /// <param name="phoneNumbers">An array of all the contact's phone numbers.</param>
        /// <param name="emails">An array of all the contact's email addresses.</param>
        /// <param name="addresses">An array of all the contact's addresses.</param>
        /// <param name="ims">An array of all the contact's IM addresses.</param>
        /// <param name="organizations">An array of all the contact's organizations.</param>
        /// <param name="birthday">The birthday of the contact.</param>
        /// <param name="note">A note about the contact.</param>
        /// <param name="photos">An array of the contact's photos.</param>
        /// <param name="categories">An array of all the user-defined categories associated with the contact.</param>
        /// <param name="urls">An array of web pages associated with the contact.</param>
        public Contact(JsString id = null, JsString displayName = null, ContactName name = null, JsString nickname = null, JsArray<ContactField> phoneNumbers = null, JsArray<ContactField> emails = null, JsArray<ContactAddress> addresses = null,
            JsArray<ContactField> ims = null, JsArray<ContactOrganization> organizations = null, JsDate birthday = null, JsString note = null, JsArray<ContactField> photos = null, JsArray<ContactField> categories = null, JsArray<ContactField> urls = null) { }
        /// <summary>
        /// Returns a new Contact object that is a deep copy of the calling object, with the id property set to null.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contact
        /// </remarks>
        /// <returns>new Contact object, with the id property set to null.</returns>
        [JsMethod(Name = "clone")]
        public Contact Clone() { return default(Contact); }
        /// <summary>
        /// Removes the contact from the device contacts database, otherwise executes an error callback with a <see cref="ContactError"/> object.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contact
        /// </remarks>
        /// <param name="contactSuccess">Success callback function.</param>
        /// <param name="contactError">Error callback function for contact functions.</param>
        [JsMethod(Name = "remove")]
        public void Remove(ContactRemoveSuccessCallback contactSuccess, ContactErrorCallback contactError) { }
        /// <summary>
        /// Saves a new contact to the device contacts database, or updates an existing contact if a contact with the same id already exists.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contact
        /// </remarks>
        /// <param name="contactSuccess"></param>
        /// <param name="contactError"></param>
        [JsMethod(Name = "save")]
        public void Save(ContactFindSuccessCallback contactSuccess, ContactErrorCallback contactError) { }
    }

    /// <summary>
    /// Supports generic fields in a <see cref="Contact"/> object. Some properties stored as ContactField objects include email addresses, phone numbers, and URLs.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#ContactField
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ContactField
    {
        /// <summary>
        /// private?
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// A JsString that indicates what type of field this is, home for example.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The value of the field, such as a phone number or email address.
        /// </summary>
        public JsString value { get; set; }
        /// <summary>
        /// Set to true if this ContactField contains the user's preferred value.
        /// </summary>
        public bool pref { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type">A JsString that indicates what type of field this is, home for example.</param>
        /// <param name="value">The value of the field, such as a phone number or email address.</param>
        /// <param name="pref">Set to true if this ContactField contains the user's preferred value.</param>
        public ContactField(JsString type = null, JsString value = null, bool pref = false) { }
    }
    /// <summary>
    /// Contains address properties for a <see cref="Contact"/> object.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#ContactAddress
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ContactAddress
    {
        /// <summary>
        /// private?
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// Set to true if this ContactAddress contains the user's preferred value.
        /// </summary>
        public bool pref { get; set; }
        /// <summary>
        /// A JsString that indicates what type of field this is, home for example.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The full address formatted for display.
        /// </summary>
        public JsString formatted { get; set; }
        /// <summary>
        /// The full street address.
        /// </summary>
        public JsString streetAddress { get; set; }
        /// <summary>
        /// The city or locality.
        /// </summary>
        public JsString locality { get; set; }
        /// <summary>
        /// The state or region.
        /// </summary>
        public JsString region { get; set; }
        /// <summary>
        /// The zip code or postal code.
        /// </summary>
        public JsString postalCode { get; set; }
        /// <summary>
        /// The country name.
        /// </summary>
        public JsString country { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pref">Set to true if this ContactAddress contains the user's preferred value.</param>
        /// <param name="type">A JsString that indicates what type of field this is, home for example.</param>
        /// <param name="formatted">The full address formatted for display.</param>
        /// <param name="streetAddress">The full street address.</param>
        /// <param name="locality">The city or locality.</param>
        /// <param name="region">The state or region.</param>
        /// <param name="postalCode">The zip code or postal code.</param>
        /// <param name="country">The country name.</param>
        public ContactAddress(bool pref = false, JsString type = null, JsString formatted = null, JsString streetAddress = null, JsString locality = null, JsString region = null, JsString postalCode = null, JsString country = null) { }
    }
    /// <summary>
    /// Contains different kinds of information about a <see cref="Contact"/> object's name.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#ContactName
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ContactName
    {
        /// <summary>
        /// The complete name of the contact.
        /// </summary>
        public JsString formatted { get; set; }
        /// <summary>
        /// The contact's family name.
        /// </summary>
        public JsString familyName { get; set; }
        /// <summary>
        /// The contact's given name.
        /// </summary>
        public JsString givenName { get; set; }
        /// <summary>
        /// The contact's middle name.
        /// </summary>
        public JsString middleName { get; set; }
        /// <summary>
        /// The contact's prefix (example Mr. or Dr.).
        /// </summary>
        public JsString honorificPrefix { get; set; }
        /// <summary>
        /// The contact's suffix (example Esq.).
        /// </summary>
        public JsString honorificSuffix { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formatted">The complete name of the contact.</param>
        /// <param name="familyName">The contact's family name.</param>
        /// <param name="givenName">The contact's given name.</param>
        /// <param name="middle">The contact's middle name.</param>
        /// <param name="prefix">The contact's prefix (example Mr. or Dr.).</param>
        /// <param name="suffix">The contact's suffix (example Esq.).</param>
        public ContactName(JsString formatted = null, JsString familyName = null, JsString givenName = null, JsString middle = null, JsString prefix = null, JsString suffix = null) { }
    }

    /// <summary>
    /// Contains a <see cref="Contact"/> object's organization properties.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#ContactOrganization
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class ContactOrganization
    {
        /// <summary>
        /// private?
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// Set to true if this ContactOrganisation contains the user's preferred value.
        /// </summary>
        public bool pref { get; set; }
        /// <summary>
        /// A JsString that indicates what type of field this is, home for example.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The name of the organization.
        /// </summary>
        public JsString name { get; set; }
        /// <summary>
        /// The department the contract works for.
        /// </summary>
        public JsString department { get; set; }
        /// <summary>
        /// The contact's title at the organization.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pref">Set to true if this ContactOrganisation contains the user's preferred value.</param>
        /// <param name="type">A JsString that indicates what type of field this is, home for example.</param>
        /// <param name="name">The name of the organization.</param>
        /// <param name="dept">The department the contract works for.</param>
        /// <param name="title">The contact's title at the organization.</param>
        public ContactOrganization(bool pref = false, JsString type = null, JsString name = null, JsString dept = null, JsString title = null) { }
    }

    /// <summary>
    /// The contacts object provides access to the device contacts database.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#Contacts
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class Contacts
    {
        /// <summary>
        /// Returns a new <see cref="Contact"/> object.
        /// </summary>
        /// <param name="objWithProperties">Object with properties to match with the properties of the new <see cref="Contact"/> object.</param>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#contacts.Create
        /// </remarks>
        [JsMethod(Name = "create")]
        public void Create(JsObject objWithProperties) { }
        /// <summary>
        /// Returns a new <see cref="Contact"/> object.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#contacts.Create
        /// </remarks>
        /// <param name="contact"><see cref="Contact"/> object with properties to match with the properties of the new <see cref="Contact"/> object.</param>
        [JsMethod(Name = "create")]
        public void Create(Contact contact) { }
        /// <summary>
        /// Queries the device contacts database and returns one or more <see cref="Contact"/> objects, each containing the fields specified.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_contacts_contacts.md.html#contacts.Find
        /// </remarks>
        /// <param name="contactFields">Required parameter used to specify which fields should be included in the <see cref="Contact"/> objects resulting from a find operation.</param>
        /// <param name="contactSuccess">Success callback function invoked with the contacts returned from the database.</param>
        /// <param name="contactError">Error callback function, invoked when an error occurs.</param>
        /// <param name="contactFindOptions"></param>
        [JsMethod(Name = "find")]
        public void Find(JsArray<JsString> contactFields, ContactFindSuccessCallback contactSuccess, ContactErrorCallback contactError = null, ContactFindOptions contactFindOptions = null) { }
    }
    #endregion

    #region Device
    /// <summary>
    /// The device object describes the device's hardware and software.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.md.html#Device
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Device
    {
        /// <summary>
        /// Not in the doc API but in the JS file.
        /// </summary>
        public bool available { get; set; }
        /// <summary>
        /// Get the version of Cordova running on the device.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.md.html#device.cordova
        /// </remarks>
        public JsString cordova { get; set; }
        /// <summary>
        /// Get the device's operating system name.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.md.html#device.platform
        /// </remarks>
        public JsString platform { get; set; }
        /// <summary>
        /// Get the device's Universally Unique Identifier (UUID).
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.md.html#device.uuid
        /// </remarks>
        public JsString uuid { get; set; }
        /// <summary>
        /// Get the operating system version.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.md.html#device.version
        /// </remarks>
        public JsString version { get; set; }
        /// <summary>
        /// Get the device's model name.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_device_device.model.md.html#device.model
        /// </remarks>
        public JsString model { get; set; }

        /// <summary>
        /// Provides access to the device's audio, image, and video capture capabilities.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_capture_capture.md.html#Capture
        /// </remarks>
        public Capture capture { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Device() { }
    }
    #endregion

    #region Enum for Cordova events
    /// <summary>
    /// Cordova event types (without battery).
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#Events
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum CordovaEventType
    {
        [JsField(Name = "deviceready")]
        DeviceReady,
        [JsField(Name = "pause")]
        Pause,
        [JsField(Name = "resume")]
        Resume,
        [JsField(Name = "online")]
        Online,
        [JsField(Name = "offline")]
        Offline,
        [JsField(Name = "backbutton")]
        BackButton,
        [JsField(Name = "menubutton")]
        MenuButton,
        [JsField(Name = "searchbutton")]
        SearchButton,
        [JsField(Name = "startcallbutton")]
        StartCallButton,
        [JsField(Name = "endcallbutton")]
        EndCallButton,
        [JsField(Name = "volumedownbutton")]
        VolumeDownButton,
        [JsField(Name = "volumeupbutton")]
        VolumeUpButton
    }
    /// <summary>
    /// Cordova battery event types.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#Events
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum CordovaBatteryEventType
    {
        [JsField(Name = "batterycritical")]
        BatteryCriticalReached,
        [JsField(Name = "batterylow")]
        BatteryLowReached,
        [JsField(Name = "batterystatus")]
        BatteryStatusChanged
    }

    #endregion

    #region CordovaEvent
    /*
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class CordovaEvent<TEventTarget> : CordovaEvent
    {
        public new TEventTarget srcElement { get; set; }
        public new TEventTarget target { get; set; }
        public new TEventTarget currentTarget { get; set; }
    }
    */
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class CordovaEvent : Event<CordovaEventType, HtmlDocument>
    {
        public new HtmlDocument currentTarget { get; set; }
    }

    /// <summary>
    /// Event object for battery events.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_events_events.md.html#BatteryCritical
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class CordovaBatteryEvent : Event<CordovaBatteryEventType, Window>
    {
        public new Window currentTarget { get; set; }

        /// <summary>
        /// The percentage of battery charge (0-100).
        /// </summary>
        public JsNumber level { get; set; }
        /// <summary>
        /// A boolean that indicates whether the device is plugged in.
        /// </summary>
        public bool isPlugged { get; set; }
    }
    #endregion

    #region Globalization
    public delegate void GlobalizationStringCallback(GlobalizationString success);
    public delegate void GlobalizationDateCallback(GlobalizationDate success);
    public delegate void GlobalizationDatePatternCallback(GlobalizationDatePattern success);
    public delegate void GlobalizationArrayStringCallback(GlobalizationArrayString success);
    public delegate void GlobalizationDstCallback(GlobalizationDst success);
    public delegate void GlobalizationDayOfWeekCallback(GlobalizationDayOfWeek success);
    public delegate void GlobalizationNumberCallback(GlobalizationNumber success);
    public delegate void GlobalizationNumberPatternCallback(GlobalizationNumberPattern success);
    public delegate void GlobalizationCurrencyPatternCallback(GlobalizationCurrencyPattern success);
    public delegate void GlobalizationErrorCallback(GlobalizationError error);
    /// <summary>
    /// The error code of a <see cref="GlobalizationError"/> object.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#GlobalizationError
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum GlobalizationErrorCode
    {
        UNKNOWN_ERROR = 0,
        FORMATTING_ERROR = 1,
        PARSING_ERROR = 2,
        PATTERN_ERROR = 3
    }

    /// <summary>
    /// A GlobalizationError object is passed to the <see cref="GlobalizationErrorCallback"/> when an error occurs.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#GlobalizationError
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "GlobalizationError")]
    public partial class GlobalizationError
    {
        /// <summary>
        /// One of the predefined error codes.
        /// </summary>
        public GlobalizationErrorCode code { get; set; }
        /// <summary>
        /// A text message that includes the error's explanation and/or details
        /// </summary>
        public JsString message { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GlobalizationError() { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">One of the predefined error codes.</param>
        public GlobalizationError(GlobalizationErrorCode code) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">One of the predefined error codes.</param>
        /// <param name="message">A text message that includes the error's explanation and/or details.</param>
        public GlobalizationError(PositionErrorCode code, JsString message) { }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationString
    {
        /// <summary>
        /// A JsString value.
        /// </summary>
        public JsString value { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationNumber
    {
        /// <summary>
        /// The value of the JsString conversion.
        /// </summary>
        public JsNumber value { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationArrayString
    {
        /// <summary>
        /// This array features names starting from either the first month in the year or the first day of the week, depending on the option selected.
        /// </summary>
        public JsArray<JsString> value { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationDate
    {
        /// <summary>
        /// The four digit year.
        /// </summary>
        public uint year { get; set; }
        /// <summary>
        /// The month from (0-11).
        /// </summary>
        public uint month { get; set; }
        /// <summary>
        /// The day from (1-31).
        /// </summary>
        public uint day { get; set; }
        /// <summary>
        /// The hour from (0-23).
        /// </summary>
        public uint hour { get; set; }
        /// <summary>
        /// The minute from (0-59).
        /// </summary>
        public uint minute { get; set; }
        /// <summary>
        /// The second from (0-59).
        /// </summary>
        public uint second { get; set; }
        /// <summary>
        /// The milliseconds (from 0-999), not available on all platforms.
        /// </summary>
        public uint millisecond { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationDatePattern
    {
        /// <summary>
        /// The date and time pattern to format and parse dates.
        /// <para>The patterns follow Unicode Technical Standard #35: http://unicode.org/reports/tr35/tr35-4.html .</para>
        /// </summary>
        public JsString pattern { get; set; }
        /// <summary>
        /// The abbreviated name of the time zone on the client.
        /// </summary>
        public JsString timezone { get; set; }
        /// <summary>
        /// The current difference in seconds between the client's time zone and coordinated universal time.
        /// </summary>
        [JsProperty(Name = "utc_offset", NativeField = true)]
        public JsNumber utcOffset { get; set; }
        /// <summary>
        /// The current daylight saving time offset in seconds between the client's non-daylight saving's time zone and the client's daylight saving's time zone.
        /// </summary>
        [JsProperty(Name = "dst_offset", NativeField = true)]
        public JsNumber dstOffset { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationDst
    {
        /// <summary>
        /// Indicates whether or not daylight savings time is in effect.
        /// </summary>
        public bool dst { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationDayOfWeek
    {
        /// <summary>
        /// The days of the week are numbered starting from 1, where 1 is assumed to be Sunday.
        /// </summary>
        public GlobalizationDayOfWeekType value { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationNumberPattern
    {
        /// <summary>
        /// The number pattern to format and parse numbers.
        /// <para>The patterns follow Unicode Technical Standard #35: http://unicode.org/reports/tr35/tr35-4.html .</para>
        /// </summary>
        public JsString pattern { get; set; }
        /// <summary>
        /// The symbol to use when formatting and parsing, such as a percent or currency symbol: <see cref="GlobalizationNumberType"/>.
        /// </summary>
        public JsString symbol { get; set; }
        /// <summary>
        /// The number of fractional digits to use when parsing and formatting numbers.
        /// </summary>
        public uint fraction { get; set; }
        /// <summary>
        /// The rounding increment to use when parsing and formatting.
        /// </summary>
        public JsNumber rounding { get; set; }
        /// <summary>
        /// The symbol to use for positive numbers when parsing and formatting.
        /// </summary>
        public JsString positive { get; set; }
        /// <summary>
        /// The symbol to use for negative numbers when parsing and formatting.
        /// </summary>
        public JsString negative { get; set; }
        /// <summary>
        /// The decimal symbol to use for parsing and formatting.
        /// </summary>
        [JsProperty(Name = "decimal", NativeField = true)]
        public JsString decimalSymbol { get; set; }
        /// <summary>
        /// The grouping symbol to use for parsing and formatting.
        /// </summary>
        [JsProperty(Name = "grouping", NativeField = true)]
        public JsString groupingSymbol { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationCurrencyPattern
    {
        /// <summary>
        /// The currency pattern to format and parse currency values.
        /// <para>The patterns follow Unicode Technical Standard #35: http://unicode.org/reports/tr35/tr35-4.html .</para>
        /// </summary>
        public JsString pattern { get; set; }
        /// <summary>
        /// The ISO 4217 currency code for the pattern (three capital letters like "USD").
        /// </summary>
        public JsString code { get; set; }
        /// <summary>
        /// The number of fractional digits to use when parsing and formatting currency.
        /// </summary>
        public uint fraction { get; set; }
        /// <summary>
        /// The rounding increment to use when parsing and formatting.
        /// </summary>
        public JsNumber rounding { get; set; }
        /// <summary>
        /// The decimal symbol to use for parsing and formatting.
        /// </summary>
        [JsProperty(Name = "decimal", NativeField = true)]
        public JsString decimalSymbol { get; set; }
        /// <summary>
        /// The grouping symbol to use for parsing and formatting.
        /// </summary>
        [JsProperty(Name = "grouping", NativeField = true)]
        public JsString groupingSymbol { get; set; }
    }


    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum GlobalizationFormatLength
    {
        [JsField(Name = "short")]
        Short,
        [JsField(Name = "medium")]
        Medium,
        [JsField(Name = "long")]
        Long,
        [JsField(Name = "full")]
        Full
    }

    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum GlobalizationSelector
    {
        [JsField(Name = "date")]
        Date,
        [JsField(Name = "time")]
        Time,
        [JsField(Name = "date and time")]
        DateAndTime
    }

    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum GlobalizationDateNameType
    {
        [JsField(Name = "narrow")]
        Narrow,
        [JsField(Name = "wide")]
        Wide
    }

    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum GlobalizationNumberType
    {
        [JsField(Name = "decimal")]
        Decimal,
        [JsField(Name = "percent")]
        Percent,
        [JsField(Name = "currency")]
        Currency
    }


    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum GlobalizationDateNameItem
    {
        [JsField(Name = "months")]
        Months,
        [JsField(Name = "days")]
        Days
    }

    [JsType(JsMode.Json, Export = false)]
    public enum GlobalizationDayOfWeekType
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }


    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationDateOptions
    {
        /// <summary>
        /// Can be "short", "medium", "long" or "full".
        /// </summary>
        public GlobalizationFormatLength formatLength { get; set; }
        /// <summary>
        /// Can be "date", "time" or "date and time"
        /// </summary>
        public GlobalizationSelector selector { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationDateNameOptions
    {
        /// <summary>
        /// Can be "narrow" or "wide"
        /// </summary>
        public GlobalizationDateNameType type { get; set; }
        /// <summary>
        /// Can be "months" or "days"
        /// </summary>
        public GlobalizationDateNameItem item { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class GlobalizationNumberOptions
    {
        /// <summary>
        /// Can be "decimal", "percent", or "currency".
        /// </summary>
        public GlobalizationNumberType type { get; set; }
    }

    /// <summary>
    /// Obtains information and performs operations specific to the user's locale and timezone.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Globalization
    {
        /// <summary>
        /// Get the JsString identifier for the client's current language.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetPreferredLanguage
        /// </remarks>
        /// <param name="successCallback">Has a <see cref="GlobalizationString"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is UNKNOWN_ERROR.</param>
        [JsMethod(Name = "getPreferredLanguage")]
        public void GetPreferredLanguage(GlobalizationStringCallback successCallback, GlobalizationErrorCallback errorCallback) { }
        /// <summary>
        /// Get the JsString identifier for the client's current locale setting.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetLocaleName
        /// </remarks>
        /// <param name="successCallback">Has a <see cref="GlobalizationString"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is UNKNOWN_ERROR.</param>
        [JsMethod(Name = "getLocaleName")]
        public void GetLocaleName(GlobalizationStringCallback successCallback, GlobalizationErrorCallback errorCallback) { }
        /// <summary>
        /// Returns a date formatted as a JsString according to the client's locale and timezone.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.DateToString
        /// </remarks>
        /// <param name="date"></param>
        /// <param name="successCallback">Has a <see cref="GlobalizationString"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is FORMATTING_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "dateToString")]
        public void DateToString(JsDate date, GlobalizationStringCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationDateOptions options) { }
        /// <summary>
        /// Parses a date formatted as a JsString, according to the client's user preferences and calendar using the time zone of the client, and returns the corresponding date object.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.StringToDate
        /// </remarks>
        /// <param name="dateString"></param>
        /// <param name="successCallback">Has a <see cref="GlobalizationDate"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is PARSING_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "stringToDate")]
        public void StringToDate(JsString dateString, GlobalizationDateCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationDateOptions options) { }
        /// <summary>
        /// Returns a pattern JsString to format and parse dates according to the client's user preferences.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetDatePattern
        /// </remarks>
        /// <param name="successCallback">Has a <see cref="GlobalizationDatePattern"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is PATTERN_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "getDatePattern")]
        public void GetDatePattern(GlobalizationDatePatternCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationDateOptions options) { }
        /// <summary>
        /// Returns an array of the names of the months or days of the week, depending on the client's user preferences and calendar.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetDateNames
        /// </remarks>
        /// <param name="successCallback">Has a <see cref="GlobalizationArrayString"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is UNKNOWN_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "getDateNames")]
        public void GetDateNames(GlobalizationArrayStringCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationDateNameOptions options) { }
        /// <summary>
        /// Indicates whether daylight savings time is in effect for a given date using the client's time zone and calendar.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.IsDayLightSavingsTime
        /// </remarks>
        /// <param name="date"></param>
        /// <param name="successCallback">Has a <see cref="GlobalizationDst"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is UNKNOWN_ERROR.</param>
        [JsMethod(Name = "isDayLightSavingsTime")]
        public void IsDayLightSavingsTime(JsDate date, GlobalizationDstCallback successCallback, GlobalizationErrorCallback errorCallback) { }
        /// <summary>
        /// Returns the first day of the week according to the client's user preferences and calendar.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetFirstDayOfWeek
        /// </remarks>
        /// <param name="successCallback">Has a <see cref="GlobalizationDayOfWeek"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is UNKNOWN_ERROR.</param>
        [JsMethod(Name = "getFirstDayOfWeek")]
        public void GetFirstDayOfWeek(GlobalizationDayOfWeekCallback successCallback, GlobalizationErrorCallback errorCallback) { }
        /// <summary>
        /// Returns the first day of the week according to the client's user preferences and calendar.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.NumberToString
        /// </remarks>
        /// <param name="number"></param>
        /// <param name="successCallback">Has a <see cref="GlobalizationString"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is FORMATTING_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "numberToString")]
        public void NumberToString(JsNumber number, GlobalizationStringCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationNumberOptions options) { }
        /// <summary>
        /// Parses a number formatted as a JsString according to the client's user preferences and returns the corresponding number.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.StringToNumber
        /// </remarks>
        /// <param name="str"></param>
        /// <param name="successCallback">Has a <see cref="GlobalizationNumber"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is PARSING_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "stringToNumber")]
        public void StringToNumber(JsString str, GlobalizationNumberCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationNumberOptions options) { }
        /// <summary>
        /// Returns a pattern JsString to format and parse numbers according to the client's user preferences.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetNumberPattern
        /// </remarks>
        /// <param name="successCallback">Has a <see cref="GlobalizationNumberPattern"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is PATTERN_ERROR.</param>
        /// <param name="options"></param>
        [JsMethod(Name = "getNumberPattern")]
        public void GetNumberPattern(GlobalizationNumberPatternCallback successCallback, GlobalizationErrorCallback errorCallback, GlobalizationNumberOptions options) { }
        /// <summary>
        /// Returns a pattern JsString to format and parse currency values according to the client's user preferences and ISO 4217 currency code.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_globalization_globalization.md.html#Globalization.GetCurrencyPattern
        /// </remarks>
        /// <param name="isoCode">The three letters of the ISO code for the currency (ie: "USD").</param>
        /// <param name="successCallback">Has a <see cref="GlobalizationCurrencyPattern"/> object parameter.</param>
        /// <param name="errorCallback">Note that the <see cref="GlobalizationError"/>'s expected code is FORMATTING_ERROR.</param>
        [JsMethod(Name = "getCurrencyPattern")]
        public void GetCurrencyPattern(JsString isoCode, GlobalizationCurrencyPatternCallback successCallback, GlobalizationErrorCallback errorCallback) { }
    }
    #endregion

    #region InAppBrowser
    /// <summary>
    /// Callback function that executes after the JavaScript/CSS code is injected.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#ExecuteScript
    /// </remarks>
    public delegate void InjectCallback();

    /// <summary>
    /// Event types for InAppBrowser.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum InAppBrowserEventType
    {
        [JsField(Name = "loadstart")]
        LoadStart,
        [JsField(Name = "loadstop")]
        LoadStop,
        [JsField(Name = "loaderror")]
        LoadError,
        [JsField(Name = "exit")]
        Exit
    }
    /// <summary>
    /// The object that is passed to the callback function from an <see cref="InAppBrowser.AddEventListener"/> call on an <see cref="InAppBrowser"/> object.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#InAppBrowserEvent
    /// </remarks>

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class InAppBrowserEvent<TEventTarget> : InAppBrowserEvent
    {
        public new TEventTarget srcElement { get; set; }
        public new TEventTarget target { get; set; }
        public new TEventTarget currentTarget { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class InAppBrowserEvent : Event<InAppBrowserEventType, InAppBrowser>
    {
        public new InAppBrowser currentTarget { get; set; }

        /// <summary>
        /// The URL that was loaded.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        /// The error code, only in the case of <see cref="InAppBrowser.OnLoadError"/>.
        /// </summary>
        public JsNumber code { get; set; }
        /// <summary>
        /// The error message, only in the case of <see cref="InAppBrowser.OnLoadError"/>.
        /// </summary>
        public JsString message { get; set; }
    }

    /// <summary>
    /// Details of the script to run (or CSS to execute), specifying either a file or code key.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#ExecuteScript
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class InjectDetails
    {
        /// <summary>
        /// URL of the script to inject.
        /// </summary>
        public JsString file { get; set; }
        /// <summary>
        /// Text of the script to inject.
        /// </summary>
        public JsString code { get; set; }
    }
    /// <summary>
    /// The InAppBrowser is a web browser that displays in the app when calling "HtmlContext.window.open".
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#InAppBrowser
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class InAppBrowser : Window, IEventTarget<InAppBrowserEventType, InAppBrowserEvent>
    {
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The event fires when the InAppBrowser starts to load a URL.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadstart", NativeField = true)]
        public new EventListener<InAppBrowserEvent> onLoadStart { get; set; }
#endif
        /// <summary>
        /// The event fires when the InAppBrowser starts to load a URL.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
        public new event EventListener<InAppBrowserEvent> OnLoadStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The event fires when the InAppBrowser finishes loading a URL.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadstop", NativeField = true)]
        public EventListener<InAppBrowserEvent> onLoadStop { get; set; }
#endif
        /// <summary>
        /// The event fires when the InAppBrowser finishes loading a URL.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
        public event EventListener<InAppBrowserEvent> OnLoadStop
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadstop\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadstop\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The event fires when the InAppBrowser encounters an error when loading a URL.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloaderror", NativeField = true)]
        public EventListener<InAppBrowserEvent> onLoadError { get; set; }
#endif
        /// <summary>
        /// The event fires when the InAppBrowser encounters an error when loading a URL.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
        public event EventListener<InAppBrowserEvent> OnLoadError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loaderror\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loaderror\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The event fires when the InAppBrowser window is closed.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onexit", NativeField = true)]
        public EventListener<InAppBrowserEvent> onExit { get; set; }
#endif
        /// <summary>
        /// The event fires when the InAppBrowser window is closed.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
        public event EventListener<InAppBrowserEvent> OnExit
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"exit\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"exit\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Adds a listener for an event from the InAppBrowser.
        /// <para>Good practice: use instead the events of the InAppBrowser object.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#AddEventListener
        /// </remarks>
        /// <param name="type">the event to listen for.</param>
        /// <param name="listener">the function that executes when the event fires.</param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(InAppBrowserEventType type, EventListener<InAppBrowserEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// Removes a listener for an event from the InAppBrowser.
        /// <para>Good practice: use instead the events of the InAppBrowser object.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#RemoveEventListener
        /// </remarks>
        /// <param name="type">the event to listen for.</param>
        /// <param name="listener">the function that executes when the event fires.</param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(InAppBrowserEventType type, EventListener<InAppBrowserEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(InAppBrowserEvent evt) { return default(bool); }

        /// <summary>
        /// Closes the InAppBrowser window.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#Close
        /// </remarks>
        [JsMethod(Name = "close")]
        public new void Close() { }
        /// <summary>
        /// Displays an InAppBrowser window that was opened hidden. Calling this has no effect if the InAppBrowser was already visible.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#Show
        /// </remarks>
        [JsMethod(Name = "show")]
        public void Show() { }
        /// <summary>
        /// Injects JavaScript code into the InAppBrowser window.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#ExecuteScript
        /// </remarks>
        /// <param name="injectDetails">Details of the script to run, specifying either a file or code key.</param>
        /// <param name="injectCallback">Callback function that executes after the JavaScript code is injected.</param>
        [JsMethod(Name = "executeScript")]
        public void ExecuteScript(InjectDetails injectDetails, InjectCallback injectCallback) { }
        /// <summary>
        /// Injects CSS into the InAppBrowser window.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_inappbrowser_inappbrowser.md.html#InsertCss
        /// </remarks>
        /// <param name="injectDetails">Details of the CSS to execute, specifying either a file or code key.</param>
        /// <param name="injectCallback">Callback function that executes after the CSS code is injected.</param>
        [JsMethod(Name = "insertCSS")]
        public void InsertCss(InjectDetails injectDetails, InjectCallback injectCallback) { }

        #region Properties and methods inherited to hide for Intellisense
        #endregion
    }
    #endregion

    #region Media
    /// <summary>
    /// The callback that executes to indicate status changes.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media
    /// </remarks>
    /// <param name="status"></param>
    public delegate void MediaStatusCallback(MediaStatus status);
    /// <summary>
    /// The callback that is passed the current position in seconds.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.GetCurrentPosition
    /// </remarks>
    /// <param name="position"></param>
    public delegate void MediaPositionCallback(JsNumber position);


    /// <summary>
    /// Status for media.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media
    /// </remarks>
    [JsType(JsMode.Json, Export = false)]
    public enum MediaStatus
    {
        MEDIA_NONE = 0,
        MEDIA_STARTING = 1,
        MEDIA_RUNNING = 2,
        MEDIA_PAUSED = 3,
        MEDIA_STOPPED = 4
    }
    /// <summary>
    /// The Media object provides the ability to record and play back audio files on a device.
    /// <para>NOTE: The current implementation does not adhere to a W3C specification for media capture, and is provided for convenience only. A future implementation will adhere to the latest W3C specification and may deprecate the current APIs.</para>
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Media
    {
        /// <summary>
        /// The position within the audio playback, in seconds.
        /// <para>Not automatically updated during play; call <see cref="GetCurrentPosition(MediaPositionCallback,MediaErrorCallback)"/> to update.</para>
        /// </summary>
        JsNumber position { get; set; }
        /// <summary>
        /// The duration of the media, in seconds.
        /// </summary>
        JsNumber duration { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Media() { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="src">A URI containing the audio content.</param>
        public Media(JsString src) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="src">A URI containing the audio content.</param>
        /// <param name="mediaSuccessCallback">The callback that executes after a Media object has completed the current play, record, or stop action.</param>
        public Media(JsString src, VoidCallback mediaSuccessCallback) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="src">A URI containing the audio content.</param>
        /// <param name="mediaSuccessCallback">The callback that executes after a Media object has completed the current play, record, or stop action.</param>
        /// <param name="mediaErrorCallback">The callback that executes if an error occurs.</param>
        public Media(JsString src, VoidCallback mediaSuccessCallback, MediaErrorCallback mediaErrorCallback) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="src">A URI containing the audio content.</param>
        /// <param name="mediaSuccessCallback">The callback that executes after a Media object has completed the current play, record, or stop action.</param>
        /// <param name="mediaErrorCallback">The callback that executes if an error occurs.</param>
        /// <param name="mediaStatusCallback">The callback that executes to indicate status changes.</param>
        public Media(JsString src, VoidCallback mediaSuccessCallback, MediaErrorCallback mediaErrorCallback, MediaStatusCallback mediaStatusCallback) { }

        /// <summary>
        /// Returns the current position within an audio file.
        /// <para>An asynchronous function that returns the current position of the underlying audio file of a Media object. Also updates the Media object's <see cref="position"/> parameter.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.GetCurrentPosition
        /// </remarks>
        /// <param name="mediaSuccessCallback">The callback that is passed the current position in seconds.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public void GetCurrentPosition(MediaPositionCallback mediaSuccessCallback) { }
        /// <summary>
        /// Returns the current position within an audio file.
        /// <para>An asynchronous function that returns the current position of the underlying audio file of a Media object. Also updates the Media object's <see cref="position"/> parameter.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.GetCurrentPosition
        /// </remarks>
        /// <param name="mediaSuccessCallback">The callback that is passed the current position in seconds.</param>
        /// <param name="mediaErrorCallback">The callback to execute if an error occurs.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public void GetCurrentPosition(MediaPositionCallback mediaSuccessCallback, MediaErrorCallback mediaErrorCallback) { }
        /// <summary>
        /// Returns the duration of an audio file.
        /// <para>This method executes synchronously, returning the duration of the audio file in seconds, if known. If the duration is unknown, it returns a value of -1.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.GetDuration
        /// </remarks>
        /// <returns>the duration of the audio file in seconds or -1 if unknown.</returns>
        [JsMethod(Name = "getDuration")]
        public JsNumber GetDuration() { return default(JsNumber); }
        /// <summary>
        /// Pauses playing an audio file.
        /// <para>This method executes synchronously, and pauses playing an audio file.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.Pause
        /// </remarks>
        [JsMethod(Name = "pause")]
        public void Pause() { }
        /// <summary>
        /// Starts or resumes playing an audio file.
        /// <para>This method executes synchronously, and starts or resumes playing an audio file.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.Play
        /// </remarks>
        [JsMethod(Name = "play")]
        public void Play() { }
        /// <summary>
        /// Releases the underlying operating system's audio resources.
        /// <para>This method executes synchronously, releasing the underlying operating system's audio resources. This is particularly important for Android, since there are a finite amount of OpenCore instances for media playback. Applications should call the <see cref="Release"/> function for any Media resource that is no longer needed.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.Release
        /// </remarks>
        [JsMethod(Name = "release")]
        public void Release() { }
        /// <summary>
        /// Sets the current position within an audio file.
        /// <para>This method executes asynchronously, updating the current playback position within an audio file referenced by a Media object. Also updates the Media object's <see cref="position"/> parameter.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.SeekTo
        /// </remarks>
        /// <param name="milliseconds">The position to set the playback position within the audio, in milliseconds.</param>
        [JsMethod(Name = "seekTo")]
        public void SeekTo(long milliseconds) { }
        /// <summary>
        /// Set the volume for an audio file.
        /// <para>This method is an asynchronous function that sets the volume during audio playback.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.SetVolume
        /// </remarks>
        /// <param name="volume">The volume to set for playback. The value must be within the range of 0.0 to 1.0.</param>
        [JsMethod(Name = "setVolume")]
        public void SetVolume(double volume) { }
        /// <summary>
        /// Set the volume for an audio file.
        /// <para>This method is an asynchronous function that sets the volume during audio playback.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.SetVolume
        /// </remarks>
        /// <param name="volume">The volume to set for playback. The value must be within the range of 0.0 to 1.0.</param>
        [JsMethod(Name = "setVolume")]
        public void SetVolume(JsString volume) { }
        /// <summary>
        /// Starts recording an audio file.
        /// <para>This method executes synchronously, starts a recording for an audio file.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.StartRecord
        /// </remarks>
        [JsMethod(Name = "startRecord")]
        public void StartRecord() { }
        /// <summary>
        /// Stops playing an audio file.
        /// <para>This method executes synchronously to stop playing an audio file.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.Stop
        /// </remarks>
        [JsMethod(Name = "stop")]
        public void Stop() { }
        /// <summary>
        /// Stops recording an audio file.
        /// <para>This method executes synchronously, stopping the recording of an audio file.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_media_media.md.html#Media.StopRecord
        /// </remarks>
        [JsMethod(Name = "stopRecord")]
        public void StopRecord() { }

    }
    #endregion

    #region Notification
    /// <summary>
    /// Callback to invoke when alert dialog is dismissed.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Alert
    /// </remarks>
    public delegate void AlertCallback();
    /// <summary>
    /// Executed when the user presses one of the buttons in the confirmation dialog box.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Confirm
    /// </remarks>
    /// <param name="buttonIndex">The index of the pressed button. Note that the index uses one-based indexing, so the value is 1, 2, 3, etc.</param>
    public delegate void ConfirmCallback(uint buttonIndex);
    /// <summary>
    /// Executed when the user presses one of the buttons in the prompt dialog box.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Prompt
    /// </remarks>
    /// <param name="buttonIndex">The index of the pressed button. Note that the index uses one-based indexing, so the value is 1, 2, 3, etc.</param>
    /// <param name="input1">The text entered in the prompt dialog box.</param>
    public delegate void PromptCallback(uint buttonIndex, JsString input1);

    /// <summary>
    /// Visual, audible, and tactile device notifications.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Notification")]
    public partial class DeviceNotification
    {
        /// <summary>
        /// Shows a custom alert or dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Alert
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="alertCallback">Callback to invoke when alert dialog is dismissed.</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message, AlertCallback alertCallback) { }
        /// <summary>
        /// Shows a custom alert or dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Alert
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="alertCallback">Callback to invoke when alert dialog is dismissed.</param>
        /// <param name="title">Dialog title. Default: "Alert".</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message, AlertCallback alertCallback, JsString title) { }
        /// <summary>
        /// Shows a custom alert or dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Alert
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="alertCallback">Callback to invoke when alert dialog is dismissed.</param>
        /// <param name="title">Dialog title. Default: "Alert".</param>
        /// <param name="buttonName">Button name. Default: "OK".</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message, AlertCallback alertCallback, JsString title, JsString buttonName) { }
        /// <summary>
        /// Displays a customizable confirmation dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Confirm
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="confirmCallback">Callback to invoke with index of button pressed (1, 2, or 3) or when the dialog is dismissed without a button press (0).</param>
        [JsMethod(Name = "confirm")]
        public void Confirm(JsString message, ConfirmCallback confirmCallback) { }
        /// <summary>
        /// Displays a customizable confirmation dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Confirm
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="confirmCallback">Callback to invoke with index of button pressed (1, 2, or 3) or when the dialog is dismissed without a button press (0).</param>
        /// <param name="title">Dialog title. Default: "Confirm".</param>
        [JsMethod(Name = "confirm")]
        public void Confirm(JsString message, ConfirmCallback confirmCallback, JsString title) { }
        /// <summary>
        /// Displays a customizable confirmation dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Confirm
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="confirmCallback">Callback to invoke with index of button pressed (1, 2, or 3) or when the dialog is dismissed without a button press (0).</param>
        /// <param name="title">Dialog title. Default: "Confirm".</param>
        /// <param name="buttonLabels">Comma-separated JsString specifying button labels. Default: "OK,Cancel".</param>
        [JsMethod(Name = "confirm")]
        public void Confirm(JsString message, ConfirmCallback confirmCallback, JsString title, JsString buttonLabels) { }
        /// <summary>
        /// Shows a customizable prompt dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Prompt
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="promptCallback">Callback to invoke when a button is pressed.</param>
        [JsMethod(Name = "prompt")]
        public void Prompt(JsString message, PromptCallback promptCallback) { }
        /// <summary>
        /// Shows a customizable prompt dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Prompt
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="promptCallback">Callback to invoke when a button is pressed.</param>
        /// <param name="title">Dialog title. Default: "Prompt".</param>
        [JsMethod(Name = "prompt")]
        public void Prompt(JsString message, PromptCallback promptCallback, JsString title) { }
        /// <summary>
        /// Shows a customizable prompt dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Prompt
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="promptCallback">Callback to invoke when a button is pressed.</param>
        /// <param name="title">Dialog title. Default: "Prompt".</param>
        /// <param name="buttonLabels">Array of strings specifying button labels. Default: ["OK","Cancel"].</param>
        [JsMethod(Name = "prompt")]
        public void Prompt(JsString message, PromptCallback promptCallback, JsString title, JsArray<JsString> buttonLabels) { }
        /// <summary>
        /// Shows a customizable prompt dialog box.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Prompt
        /// </remarks>
        /// <param name="message">Dialog message.</param>
        /// <param name="promptCallback">Callback to invoke when a button is pressed.</param>
        /// <param name="title">Dialog title. Default: "Prompt".</param>
        /// <param name="buttonLabels">Array of strings specifying button labels. Default: ["OK","Cancel"].</param>
        /// <param name="defaultText">Default textbox input value. Default: "".</param>
        [JsMethod(Name = "prompt")]
        public void Prompt(JsString message, PromptCallback promptCallback, JsString title, JsArray<JsString> buttonLabels, JsString defaultText) { }
        /// <summary>
        /// The device plays a beep sound.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Beep
        /// </remarks>
        /// <param name="times">The number of times to repeat the beep.</param>
        [JsMethod(Name = "beep")]
        public void Beep(ulong times) { }
        /// <summary>
        /// Vibrates the device for the specified amount of time.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_notification_notification.md.html#Notification.Vibrate
        /// </remarks>
        /// <param name="milliseconds">Milliseconds to vibrate the device, where 1000 milliseconds equals 1 second.</param>
        [JsMethod(Name = "vibrate")]
        public void Vibrate(ulong milliseconds) { }
    }
    #endregion

    #region Splashscreen
    /// <summary>
    /// Displays and hides the application's splash screen.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_splashscreen_splashscreen.md.html#Splashscreen
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class Splashscreen
    {
        /// <summary>
        /// Displays the splash screen.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_splashscreen_splashscreen.md.html#splashscreen.Show
        /// </remarks>
        [JsMethod(Name = "show")]
        public void Show() { }
        /// <summary>
        /// Dismiss the splash screen.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_splashscreen_splashscreen.md.html#splashscreen.Hide
        /// </remarks>
        [JsMethod(Name = "hide")]
        public void Hide() { }
    }
    #endregion

}
