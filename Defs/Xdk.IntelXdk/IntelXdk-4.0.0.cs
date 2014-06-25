/*
 * -----------------------------------------------------------------------
 * Intel XDK wrapper for SharpKit / v1.0 (10 September 2013)
 * Copyright 2013 by Hervé PHILIPPE / http://alchiweb.fr / alchiweb@gmail.com
 * MIT Licence
 * -----------------------------------------------------------------------
 * SharpKit version: v5.2.0
 * IntelXdk version: 4.0.0 (september 2013)
 *  for further info, see Intel's HTML5 Development Environment (Intel's XDK) at:
 *  http://html5dev-software.intel.com/
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
 * - I have write 'TODO' comments,  mainly for verifying strong typing (like id, that is sometimes JsString, and sometimes JsNumber/long)
 * - for Facebook: FBParameters* classes must be completed with the good properties (see https://fbdevwiki.com/wiki/FB.ui... or with others infos?)
*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using SharpKit.JavaScript;              // Reference: SharpKit.DotNet.JavaScript
using SharpKit.DotNet.JavaScript;        // Reference: SharpKit.DotNet.JavaScript
using SharpKit.DotNet.Html;              // Reference: SharpKit.DotNet.Html
using SharpKit.DotNet.Html.geolocation;

[assembly: JsNamespace(Namespace = "SharpKit.DotNet.IntelXdk", JsNamespace = "intel.xdk")]
namespace SharpKit.DotNet.IntelXdk
{

    #region Xdk
    /// <summary>
    /// Global variables
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, OmitInheritance = true, Name = "intel.xdk")]
    public partial class Xdk
    {
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a native iOS or Android device.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isNative == true)
        ///     {
        ///         // Application is running on native device
        ///         HtmlContext.console.Log("Running on a native device");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isnative", NativeField = true)]
        public static bool isNative { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if currently running in the xdk.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isXdk == true)
        ///     {
        ///         // Application is running in XDK mode
        ///         HtmlContext.console.Log("Running in Emulator Mode");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isxdk", NativeField = true)]
        public static bool isXdk { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if currently running on Windows device.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isWindows == true)
        ///     {
        ///         // Application is running on Windows device
        ///         HtmlContext.console.Log("Running on Windows device");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "iswindows", NativeField = true)]
        public static bool isWindows { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running in Intel XDK app.lab (via Test Anywhere or Test on Local WiFi).
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isTest == true)
        ///     {
        ///         // Application is running in app.lab
        ///         HtmlContext.console.Log("Running in app.lab test");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "istest", NativeField = true)]
        public static bool isTest { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running in the Chrome browser.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isGoogle == true)
        ///     {
        ///         // Application is running in Chrome browser
        ///         HtmlContext.console.Log("Running in Chrome");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "ischrome", NativeField = true)]
        public static bool isChrome { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running as a Facebook application.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isFacebook == true)
        ///     {
        ///         // Application is running as a Facebook app
        ///         HtmlContext.console.Log("Running as a Facebook app");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isfacebook", NativeField = true)]
        public static bool isFacebook { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a Barnes and Noble Nook device.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isNook == true)
        ///     {
        ///         // Application is running on Nook device
        ///         HtmlContext.console.Log("Running on a Nook device");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isnook", NativeField = true)]
        public static bool isNook { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a native phone device.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isNative == true)
        ///     {
        ///         // Application is running on native device
        ///         HtmlContext.console.Log("Running on a native device");
        ///         if (Xdk.isPhone == true)
        ///         {
        ///             HtmlContext.console.Log("Native device is a phone");
        ///         }
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isphone", NativeField = true)]
        public static bool isPhone { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a native tablet device.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isNative == true)
        ///     {
        ///         // Application is running on native device
        ///         HtmlContext.console.Log("Running on a native device");
        ///         if (Xdk.isTablet == true)
        ///         {
        ///             HtmlContext.console.Log("Native device is a tablet");
        ///         }
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "istablet", NativeField = true)]
        public static bool isTablet { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running in a web browser such as Safari.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isWeb == true)
        ///     {
        ///         // Application is running in a web browser such as Safari
        ///         HtmlContext.console.Log("Running in a web browser");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isweb", NativeField = true)]
        public static bool isWeb { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running as an Amazon application.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isAmazon == true)
        ///     {
        ///         // Application is running as an Amazon app
        ///         HtmlContext.console.Log("Running as an Amazon app");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isamazon", NativeField = true)]
        public static bool isAmazon { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is running as a Google Play Store application.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isGoogle == true)
        ///     {
        ///         // Application is running as a Google Play Store app
        ///         HtmlContext.console.Log("Running as a Google Play Store app");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isgoogle", NativeField = true)]
        public static bool isGoogle { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running as an Intel AppUp application.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isIntel == true)
        ///     {
        ///         // Application is running as an Intel AppUp application
        ///         HtmlContext.console.Log("Running an Intel AppUp app");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "isintel", NativeField = true)]
        public static bool isIntel { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is running as a Mozilla store app.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.isMozilla == true)
        ///     {
        ///         // Application is running as a Mozilla Store app
        ///         HtmlContext.console.Log("Running as a Mozilla app");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "ismozilla", NativeField = true)]
        public static bool isMozilla { get; set; }
        /// <summary>
        /// This property indicates whether the oAuth service is ready or not when the application starts up.
        /// </summary>
        /// <remarks>
        /// This property should be checked in <see cref="Xdk.OnDeviceReady"/> event handler to see if the OAuth system is available. 
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     if (Xdk.oAuthAvailable == true)
        ///     {
        ///         HtmlContext.Alert("oAuth is available in this application");
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        [JsProperty(Name = "oauthAvailable", NativeField = true)]
        public static bool oAuthAvailable { get; set; }
        /// <summary>
        /// A boolean indicating whether an update is available to the application or not.
        /// </summary>
        /// <remarks>
        /// This property will indicate whether a Live Update is available for an application by returning a true or a false. It is only set following the <see cref="Xdk.OnDeviceReady"/> event. A true result indicates that an update is available and has not yet been installed.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Confirm"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     //Xdk.updateAvailable indicates whether or not an over the air update is available or not.
        ///     if (Xdk.updateAvailable == true)
        ///     {
        ///         //there is an application update available at startup
        ///         if (HtmlContext.Confirm(Xdk.updateMessage) == true)
        ///         {
        ///             Xdk.device.InstallUpdate();
        ///         }
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        public static bool updateAvailable { get; set; }
        /// <summary>
        /// The message associated with a Live Update
        /// </summary>
        /// <remarks>
        /// When a Live Update is triggered in an application, this property will return the text message associated with the update.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Confirm"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     //Xdk.updateAvailable indicates whether or not an over the air update is available or not.
        ///     if (Xdk.updateAvailable == true)
        ///     {
        ///         //there is an application update available at startup
        ///         if (HtmlContext.Confirm(Xdk.updateMessage) == true)
        ///         {
        ///             Xdk.device.InstallUpdate();
        ///         }
        ///     }
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        public static JsString updateMessage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.available);
        /// </code>
        /// </example>
        public static bool available { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.paymentsAvailable);
        /// </code>
        /// </example>
        public static bool paymentsAvailable { get; set; }
        /// <summary>
        /// This property holds the unique identifier for an Intel XDK application.
        /// </summary>
        /// <remarks>
        /// This property holds the unique identifier for an Intel XDK application, which is described as a GUID.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document"
        /// public static void WriteScript()
        /// {
        ///     HtmlScriptElement scr = new HtmlScriptElement();
        ///     scr.type = "text/javascript";
        ///     scr.src = "http://debug.appmobi.com/target/target-script-min.js#" + Xdk.app;
        ///     HtmlHeadElement.GetByTagName()[0].appendChild(scr);
        /// }
        /// </code>
        /// </example>
        public static JsString app { get; set; }
        public static JsString release { get; set; }
        public static JsString package { get; set; }
        /// <summary>
        /// This property holds the full path to Intel XDK's internal web server.
        /// </summary>
        /// <remarks>
        /// Use this property to reference files distributed with the bundle of the application itself. For example, images or sounds that are included alongside the index.html file that drives the application. The path returned by this property will reference the root directory where the index.html file is located.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document"
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     HtmlBodyElement.GetByTagName()[0].style.backgroundImage = "url('" + Xdk.webRoot + "bodyImage.png')";
        /// }
        /// // generate a call to addEventListener
        /// Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// </code>
        /// </example>
        public static JsString webRoot { get; set; }
        /// <summary>
        /// The current version of the HTML5 Tools JavaScript API library.
        /// </summary>
        /// <remarks>
        /// This property holds the current version of the HTML5 Tools JavaScript library used in the application. It can be compared to the application version stored in <see cref="XdkDevice.appmobiVersion">Xdk.device.appmobiVersion</see>.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.jsVersion);
        /// </code>
        /// </example>
        public static JsString jsVersion { get; set; }
        public static JsNumber revision { get; set; }

        public static bool hasLocalStorage { get; set; }
        public static XdkQueueData queue { get; set; }
        public static JsArray<JsAction> _constructors { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasAnalytics"/>
        /// </summary>
        public static bool _hasAnalytics { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasCaching"/>
        /// </summary>
        public static bool _hasCaching { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasStreaming"/>
        /// </summary>
        public static bool _hasStreaming { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasAdvertising"/>
        /// </summary>
        public static bool _hasAdvertising { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasPush"/>
        /// </summary>
        public static bool _hasPush { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasInAppPay"/>
        /// </summary>
        public static bool _hasInAppPay { get; set; }
        /// <summary>
        /// <see cref="XdkDevice.hasOAuth"/>
        /// </summary>
        public static bool _hasOAuth { get; set; }

        public static JsObject<XdkCookieData> cookies { get; set; }
        [JsProperty(Name = "mediacache", NativeField = true)]
        public static JsObject<JsString> mediaCache { get; set; }
        public static JsArray<XdkNotificationData> notifications { get; set; }
        public static JsArray<XdkContactData> people { get; set; }
        [JsProperty(Name = "picturelist", NativeField = true)]
        public static JsArray<JsString> pictureList { get; set; }
        [JsProperty(Name = "recordinglist", NativeField = true)]
        public static JsArray<JsString> recordingList { get; set; }
        /// <summary>
        /// Access information about the media currently playing.
        /// </summary>
        /// <remarks>
        /// The playingtrack object provides a series of properties that contain information about media currently played by the application. Please note that this object currently only works with stations hosted by appMobi and played with the StartStation (deprecated) or <see cref="XdkPlayer.StartShoutcast"/> commands. Not all properties may have values for all streams. An event is fired when the currently playing track changes.
        /// </remarks>
        [JsProperty(Name = "playingTrack", NativeField = true)]
        public static XdkPlayingTrack playingtrack { get; set; }

        public static XdkNative native { get; set; }
        /// <summary>
        /// Define object for receiving acceleration values.
        /// </summary>
        public static XdkAcceleration _accel { get; set; }
        /// <summary>
        /// Use the accelerometer object to listen to the device's motion sensor.
        /// </summary>
        /// <remarks>
        /// The accelerometer is the device on a smartphone that detects movement. The accelerometer object is used to track the accelerometer on the device. Success and failure callback functions need to be defined in your Javascript. Successful data is returned as an object with the attributes ".x", ".y", and ".z". Values of accelerometer samples for each axis range from -1 to 1.
        /// </remarks>
        public static XdkAccelerometer accelerometer { get; set; }
        public static XdkAdvertising advertising { get; set; }
        public static Audio audio { get; set; }
        /// <summary>
        /// Play audio and video.
        /// </summary>
        /// <remarks>
        /// The player object is used to play media natively in applications. It is a useful alternative to the HTML5 "video" and "audio" tags. It also allows applications to play streaming and shoutcast stations with a skinnable native UI.
        /// </remarks>
        public static XdkPlayer player { get; set; }
        public static XdkStats stats { get; set; }
        /// <summary>
        /// Track how your application is used and accessed by setting custom events.
        /// </summary>
        /// <remarks>
        /// The analytics object provides access to statMobi Analytics.
        /// </remarks>
        public static XdkAnalytics analytics { get; set; }
        /// <summary>
        /// Transfers files over the Internet.
        /// </summary>
        /// <remarks>
        /// The file object gives applications the ability to upload files to a remote server.
        /// </remarks>
        public static XdkFile file { get; set; }
        /// <summary>
        /// Use the device's camera and access your device's camera library.
        /// </summary>
        /// <remarks>
        /// The camera object consists of several methods to control the capturing and maintenance of picture files. The camera object contains a list of photos known as the "picture list". The picture list is where new images are placed once they are created. There are several methods in the camera object that allow the application to control the files in this list. The application may add to the picture list by capturing a photo from the device's native camera using <see cref="XdkCamera.TakePicture">Xdk.camera.TakePicture</see>, a picture may be added to the list by referencing a file on the device using <see cref="XdkCamera.ImportPicture">Xdk.camera.ImportPicture</see>, all the photos on the list may be listed in an array using <see cref="XdkCamera.GetPictureList">Xdk.camera.GetPictureList</see>, photos may be removed from the list singly using <see cref="XdkCamera.DeletePicture">Xdk.camera.DeletePicture</see>, or the picture list may be wiped clear using <see cref="XdkCamera.ClearPictures">Xdk.camera.ClearPictures</see>. Finally, files in the picture list may be referenced for use in an application using the <see cref="XdkCamera.GetPictureUrl">Xdk.camera.GetPictureUrl</see> method.
        /// </remarks>
        public static XdkCamera camera { get; set; }
        /// <summary>
        /// This object is intended to provide local storage for data to speed up applications.
        /// </summary>
        /// <remarks>
        /// This object is intended to provide local storage for data to speed up applications. It can be used as in conjunction with, or as an alternative to the HTML5 local database. Its methods provide features similar to browser cookies and file caching.
        /// <para>For cookies, the intention is that you would use <see cref="XdkCache.SetCookie">Xdk.cache.SetCookie</see> to save JsString data in name-value pairs. Cookies persist between application sessions. Data values may be retrieved using the <see cref="XdkCache.GetCookie">Xdk.cache.GetCookie</see> command or from the <see cref="XdkCache.GetCookieList">Xdk.cache.GetCookieList</see> command as soon as the <see cref="Xdk.OnDeviceReady"/> event is fired.</para>
        /// <para>The media cache commands are meant to provide quicker access to files such as videos and images. Adding files to the media cache will expedite access to them when the application runs. These are files that are cached across sessions and are not in your application bundle. See the Xdk.Cache* events for more information about events fired from the cache section of Intel XDK.</para>
        /// </remarks>
        public static XdkCache cache { get; set; }
        /// <summary>
        /// The Canvas object represents the Accelerated Canvas App Game Interface instance itself.
        /// </summary>
        /// <remarks>
        /// The Canvas object is a read-only object representing the Accelerated Canvas App Game Interface tag. It is typically reached through the Xdk object this way:
        /// <code lang="C#">Xdk.canvas</code>
        /// In order to use the Accelerated Canvas App Game Interface, your app must be split into 2 components which will run in the 2 execution contexts which each have their own view. The HTML5 Tools component runs in the top view and should provide the portion of the user interface that the user interacts with. The Accelerated Canvas App Game Interface component runs in its own view that is beneath the first view - it does not directly receive touch events and so should not include user interaction elements. User interactions that are intended to provide input to the Accelerated Canvas App Game Interface component. It can do so via one of the bridge functions provided by the Accelerated Canvas App Game Interface (for example, a "jump" button in a game that causes a character to jump).
        /// <para>Other explication:</para>
        /// <para>The Accelerated Canvas App Game Interface plugin is designed for use with Intel XDK applications. In order to use Accelerated Canvas App Game Interface, your Intel XDK application must be split into two components which will run in two execution contexts. Each context will have its own view. The Intel XDK component runs in the top view and should provide the user interface that the user interacts with. The Accelerated Canvas App Game Interface component runs in its own view that is beneath the Intel XDK view and renders the graphics used for the application. It does not directly receive touch events and so should not include user interaction elements.</para>
        /// </remarks>
        public static XdkCanvasElement canvas { get; set; }
        /// <summary>
        /// This object provides access to the appMobi in-app purchasing system.
        /// </summary>
        public static XdkPurchasing purchasing { get; set; }
        /// <summary>
        /// This object provides access to the debugging console.
        /// </summary>
        public static XdkDebug debug { get; set; }
        /// <summary>
        /// Access the default contacts database on a device from an application.
        /// </summary>
        /// <remarks>
        /// The contacts object gives programmers access to the default contacts database on the native device. The application must be built with the appropriate permissions in order for this capability to work. Use <see cref="XdkContactData"/> class to create a contact.
        /// </remarks>
        public static XdkContacts contacts { get; set; }
        /// <summary>
        /// Access information about and configure settings of the device itself using this object.
        /// </summary>
        /// <remarks>
        /// The device object provides access to information about the device itself through a series of properties and functions.
        /// </remarks>
        public static XdkDevice device { get; set; }
        /// <summary>
        /// Make your application aware of where it is currently located
        /// </summary>
        public static XdkGeolocation geolocation { get; set; }
        /// <summary>
        /// Alert the application's user about the application's state using a variety of methods.
        /// </summary>
        /// <remarks>
        /// The notification object allows the developer to alert the user using device-specific capabilities.
        /// </remarks>
        public static XdkNotification notification { get; set; }
        /// <summary>
        /// Authorize or revoke authorization for a service such as Twitter or LinkedIn
        /// </summary>
        /// <remarks>
        /// The oAuth object is used to Authorize or remove authorization for a service such as Twitter or LinkedIn within the application.
        /// </remarks>
        [JsProperty(Name = "oauth", NativeField = true)]
        public static XdkOAuth oAuth { get; set; }
        /// <summary>
        /// Integrate your application with Facebook.
        /// </summary>
        /// <remarks>
        /// This object gives applications the capability to log users into Facebook in order to access their Facebook Graph as well as to post to the news feed and share request dialogs.
        /// <para>For more information on on how to use the Facebook JavaScript API commands in a native application, get the Facebook Integration document: http://www.html5dev-software.intel.com/amdocs/lib/Article-FacebookIntegration.pdf .</para>
        /// </remarks>
        public static XdkFacebook facebook { get; set; }
        /// <summary>
        /// Take control of the device's video display properties.
        /// </summary>
        /// <remarks>
        /// The display object gives the application control over aspects of the device's video display properties.
        /// </remarks>
        public static XdkDisplay display { get; set; }
        /// <summary>
        /// Allows applications to listen for touch events: add/remove touch events and multiple simultaneous touch events on an Android device
        /// </summary>
        /// <remarks>
        /// This object is mainly created to solve the problems with handling multiple simultaneous touches on an Android device. The Android operating system does not handle simultaneous touch events on the browser.
        /// </remarks>
        public static XdkMultitouch multitouch { get; set; }
        /// <summary>
        /// Used only for XDK: it isn't very useful. So the class for this object isn't done.   // TODO?
        /// </summary>
        private static object xdkBridge { get; set; }

        #region Events
        /// <summary>
        /// Fired when the new contact has been added to the list.
        /// </summary>
        /// <remarks>
        /// This event is fired in response to an <see cref="XdkContacts.AddContact">AddContact</see> method once a contact has been successfully added or the operation was cancelled.
        /// <para>The event is returned with three properties: success, contactId, cancelled.</para>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkContacts.AddContact"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkContactsEvent> OnContactsAdd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.contacts.add\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.contacts.add\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired when an operation on a contact list is requested, but another operation is blocking access to the device's contact list.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkContacts.AddContact"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkContacts.RemoveContact"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkContacts.EditContact"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkContacts.ChooseContact"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkContactsEvent> OnContactsBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.contacts.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.contacts.busy\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired once the contact has been selected.
        /// </summary>
        /// <remarks>
        /// This event is fired in response to a <see cref="XdkContacts.ChooseContact">ChooseContact</see> method once a contact has been selected from a list or the operation was cancelled.
        /// <para>The event is returned with three properties: success, contactId, cancelled.</para>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkContacts.ChooseContact"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkContactsEvent> OnContactsChoose
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.contacts.choose\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.contacts.choose\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired when the content of the contact has been updated.
        /// </summary>
        /// <remarks>
        /// This event is fired in response to a <see cref="XdkContacts.EditContact">EditContact</see> method once a contact has been successfully updated or the operation was cancelled.
        /// <para>The event is returned with three properties: success, contactId, cancelled.</para>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkContacts.EditContact"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkContactsEvent> OnContactsEdit
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.contacts.edit\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.contacts.edit\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired when the device's local contact list has been fully retrieved/refreshed from the device contact database.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkContacts.GetContacts"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkContactsEvent> OnContactsGet
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.contacts.get\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.contacts.get\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired when contact information has been removed from the list.
        /// </summary>
        /// <remarks>
        /// This event is fired in response to a <see cref="XdkContacts.RemoveContact">RemoveContact</see> method once a contact has been successfully removed or the operation was cancelled. 
        /// <para>The event is returned with four properites: success, contactId, cancelled, error.</para> 
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkContacts.RemoveContact"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkContactsEvent> OnContactsRemove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.contacts.remove\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.contacts.remove\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// This event will fire if the <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> command is called but the device is already playing
        /// </summary>
        /// <remarks>
        /// This event will fire if the <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> command is called but the device is already playing a podcast or station or shoutcast station.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartAudio"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.StopAudio"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerAudioBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.audio.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.audio.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event fires when execution of <see cref="XdkPlayer.SetAudioCurrentTime">Xdk.player.SetAudioCurrentTime</see> is complete
        /// </summary>
        /// <remarks>
        /// This event signifies that the <see cref="XdkPlayer.WatchAudioCurrentTime"/> callback and the <see cref="XdkPlayer.audioInfo">player.audioInfo</see> variable are again valid.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.SetAudioCurrentTime"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerAudioCurrenttimeSet
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.audio.currenttime.set\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.audio.currenttime.set\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event fires when there is an unknown error calling the <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> command
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartAudio"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.StopAudio"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerAudioError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.audio.error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.audio.error\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when an audio file is started (after calling <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> command)/
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartAudio"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerAudioStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.audio.start\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.audio.start\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire once an audio file played using <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> is complete
        /// </summary>
        /// <remarks>
        /// This event will fire once an audio file played using <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> is complete or if <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> is called.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartAudio"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.StopAudio"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerAudioStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.audio.stop\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.audio.stop\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire when the Intel XDK player screen is hidden
        /// </summary>
        /// <remarks>
        /// This event will fire when the Intel XDK player screen is hidden regardless of whether it was dismissed using the <see cref="XdkPlayer.Hide">Xdk.player.Hide</see> command or from the back button on the player itself.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.Hide"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerHide
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.hide\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.hide\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire when the Intel XDK player screen is shown
        /// </summary>
        /// <remarks>
        ///  It can be triggered when Intel XDK itself shows the player such as after a command such as <see cref="XdkPlayer.StartStation">Xdk.player.StartStation</see> is successfully executed or if a command such as <see cref="XdkPlayer.Show">Xdk.player.Show</see> is run.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.Show"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShow
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.show\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.show\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire if the <see cref="XdkPlayer.PlayPodcast">Xdk.player.PlayPodcast</see> command is called but the device is already playing
        /// </summary>
        /// <remarks>
        /// This event will fire if the <see cref="XdkPlayer.PlayPodcast">Xdk.player.PlayPodcast</see> command is called but the device is already playing a podcast or station or shoutcast station or an audio file.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.PlayPodcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerPodcastBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.podcast.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.podcast.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.PlayPodcast">Xdk.player.PlayPodcast</see> command experiences an unknown error
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.PlayPodcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerPodcastError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.podcast.error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.podcast.error\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a video is started
        /// </summary>
        /// <remarks>
        /// This event is fired when a video is started using the <see cref="XdkPlayer.PlayPodcast">Xdk.player.PlayPodcast</see> command.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.PlayPodcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerPodcastStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.podcast.start\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.podcast.start\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a video is played
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.PlayPodcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerPodcastPlay
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.podcast.play\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.podcast.play\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a video is paused
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.PlayPodcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerPodcastPause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.podcast.pause\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.podcast.pause\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire once a video or audio podcast is complete
        /// </summary>
        /// <remarks>
        /// This event will fire once a video or audio podcast started with <see cref="XdkPlayer.PlayPodcast">Xdk.player.PlayPodcast</see> is complete.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.PlayPodcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerPodcastStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.podcast.stop\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.podcast.stop\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire if the <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see> command is called while the device is already playing
        /// </summary>
        /// <remarks>
        /// This event will fire if the <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see> command is called but the device is already playing a podcast or an audio file.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShoutcastBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see> command experiences an unknown error
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShoutcastError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.error\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.Play">Xdk.player.Play</see> command is called or when a shoutcast station starts to play from the player screen
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.Play"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShoutcastPlay
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.play\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.play\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.Pause">Xdk.player.Pause</see> command is called or when a shoutcast station is paused from the player screen.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShoutcastPause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.pause\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.pause\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// This event is fired when a shoutcast station is started
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShoutcastStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.start\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.start\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a shoutcast station stops because the user hit the stop button
        /// </summary>
        /// <remarks>
        /// This event is fired when a shoutcast station stops because the user hit the stop button from the player screen or <see cref="XdkPlayer.Stop">Xdk.player.Stop</see> was called.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerShoutcastStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.stop\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.shoutcast.stop\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event fires if a file referenced by the <see cref="XdkPlayer.PlaySound">Xdk.player.PlaySound</see> command is invalid or missing.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.LoadSound"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.PlaySound"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerSoundError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.sound.error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.sound.error\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire if the <see cref="XdkPlayer.StartStation">Xdk.player.StartStation</see> command (and/or Shoutcast?) is called but the device is already playing
        /// </summary>
        /// <remarks>
        /// This event will fire if the <see cref="XdkPlayer.StartStation">Xdk.player.StartStation</see> command is called but the device is already playing a podcast or an audio file.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerStationBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.station.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.station.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.StartStation">Xdk.player.StartStation</see> command  (and/or Shoutcast?) experiences an unknown error
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerStationError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.station.error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.station.error\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.Pause">Xdk.player.Pause</see> command is called or when a station is paused
        /// </summary>
        /// <remarks>
        /// This event is fired when the <see cref="XdkPlayer.Pause">Xdk.player.Pause</see> command is called or when a station is paused from the player screen.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerStationPause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.station.pause\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.station.pause\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the <see cref="XdkPlayer.Play">Xdk.player.Play</see> command is called or when a station starts to play
        /// </summary>
        /// <remarks>
        /// This event is fired when the <see cref="XdkPlayer.Play">Xdk.player.Play</see> command is called or when a station starts to play from the player screen.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.Play"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerStationPlay
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.station.play\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.station.play\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a station is started.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerStationStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.station.start\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.station.start\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a station stops.
        /// </summary>
        /// <remarks>
        /// This event is fired when a station stops because the user hit the stop button from the player screen or <see cref="XdkPlayer.Stop">Xdk.player.Stop</see> was called.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerStationStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.station.stop\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.station.stop\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire each time a playing station changes to a new track and updates its metadata.
        /// </summary>
        /// <remarks>
        /// This will happen for stations started using <see cref="XdkPlayer.StartStation">Xdk.player.StartStation</see> or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkPlayer.StartShoutcast"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkPlayer.StartStation"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkPlayerEvent> OnPlayerTrackChange
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.player.track.change\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.player.track.change\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired when a photo is taken from the back camera
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.TakePicture"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraTakePicture
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.takePicture\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.takePicture\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when a photo is taken from the back camera
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.TakeFrontPicture"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraTakeFrontPicture
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.takeFrontPicture\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.takeFrontPicture\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when a photo is added to the application's picture list
        /// </summary>
        /// <remarks>
        /// It will return event object with "filename" and "success" properties.
        /// <para>Once an image has been added to the picture list, it can be referenced in an application using <see cref="XdkCamera.GetPictureUrl">camera.GetPictureUrl</see> and passing its filename. The entire list of available images filenames can be accessed using <see cref="XdkCamera.GetPictureList">camera.GetPictureList</see>.</para>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.ImportPicture"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCamera.TakePicture"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCamera.TakeFrontPicture"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraPictureAdd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.picture.add\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.picture.add\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when accessing the native camera functionality is blocked by another process
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.ImportPicture"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCamera.TakePicture"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCamera.TakeFrontPicture"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraPictureBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.picture.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.picture.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when the user chooses to cancel rather than taking or importing a picture
        /// </summary>
        /// <remarks>
        /// Fired when the user chooses to cancel rather than taking or importing a picture. The event is returned with the "success" property.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.ImportPicture"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCamera.TakePicture"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCamera.TakeFrontPicture"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraPictureCancel
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.picture.cancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.picture.cancel\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when the application's pictures list has been cleared
        /// </summary>
        /// <remarks>
        /// It will return an event object with a property indicating whether it was successful or not.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.ClearPictures"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraPictureClear
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.picture.clear\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.picture.clear\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when a photo is removed from application's pictures list
        /// </summary>
        /// <remarks>
        /// It will return an event object with propeties indicating whether it was successful or not, as well as the filename of the photo referenced in the picture list.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCamera.DeletePicture"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCameraEvent> OnCameraPictureRemove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.camera.picture.remove\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.camera.picture.remove\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fires when data is cached
        /// </summary>
        /// <remarks>
        /// It will return an event object that contains the URL of the remote file cached.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCache.AddToMediaCacheExt"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkCache.AddToMediaCache"/> (deprecated)</description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCacheEvent> OnCacheMediaAdd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.cache.media.add\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.cache.media.add\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired once all files are removed from the local file cache.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCache.ClearMediaCache"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCacheEvent> OnCacheMediaClear
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.cache.media.clear\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.cache.media.clear\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when data is removed from the cache.
        /// </summary>
        /// <remarks>
        /// It will return an event object that contains the URL of the original URL of the removed file.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCache.RemoveFromMediaCache"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCacheEvent> OnCacheMediaRemove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.cache.media.remove\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.cache.media.remove\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired repeatedly to track caching progress
        /// </summary>
        /// <remarks>
        /// It will return an event object that contains several parameters. The first parameter is the URL of the remote file cached. The second is the unique ID assigned when the command was called. The third is the current number of bytes downloaded and cached so far, and the final parameter is the total number of bytes in the file.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkCache.AddToMediaCacheExt"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkCacheEvent> OnCacheMediaUpdate
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.cache.media.update\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.cache.media.update\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// This event is fired once the barcode reader command has finished doing its job
        /// </summary>
        /// <remarks>
        /// This event is called once the QR code reader successfully reads a code or once it is cancelled. The event returned with this event contains the following properties: "type", "success", "codeData".
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkDevice.ScanBarcode"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// public static void InitScanBarCode()
        /// {
        ///     Xdk.OnDeviceBarcodeScan += Xdk_DeviceBarcodeScan;
        ///     Xdk.device.ScanBarcode();
        /// }
        /// static void Xdk_DeviceBarcodeScan(DeviceBarcodeEvent evt)
        /// {
        ///     Xdk.notification.Beep(1);
        ///     if (evt.success == true)
        ///     {
        ///         //successful scan
        ///         HtmlContext.console.Log(evt.codeData);
        ///         if (evt.codeData == "http://www.sampleurl.com/fake.html")
        ///         {
        ///             //in the XDK
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert(evt.codeData);
        ///         }
        ///     }
        ///     else
        ///     {
        ///         //failed scan
        ///         HtmlContext.console.Log("failed scan");
        ///     }
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceBarcodeEvent> OnDeviceBarcodeScan
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.barcode.scan\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.barcode.scan\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired in response to the <see cref="XdkDevice.UpdateConnection">Xdk.device.UpdateConnection</see> command to indicate that the device's Internet connection has changed
        /// </summary>
        /// <remarks>
        /// The connection property on the event object is set.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkDevice.UpdateConnection"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void DeviceConnection()
        /// {
        ///     Xdk.OnDeviceConnectionUpdate += Xdk_DeviceConnectionUpdate;
        ///     Xdk.device.UpdateConnection();
        /// }
        /// static void Xdk_DeviceConnectionUpdate(DeviceEvent evt)
        /// {
        ///     HtmlContext.Alert(Xdk.device.connection);
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceConnectionUpdate
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.connection.update\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.connection.update\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the screen is unlocked
        /// </summary>
        /// <remarks>
        /// This event is triggered when the device is restarted following the screen being locked. The screen is locked when turns off due to power saving timeout or the user presses the power button.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitEvent()
        /// {
        ///     Xdk.OnDeviceContinue += Xdk_DeviceContinue;
        /// }
        /// static void Xdk_DeviceContinue(DeviceEvent evt)
        /// {
        ///     Xdk.player.Play();
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceContinue
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.continue\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.continue\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the Android hardware back button is pressed following a call to <see cref="XdkDevice.AddVirtualPage">Xdk.device.AddVirtualPage</see>.
        /// </summary>
        /// <remarks>
        /// If the <see cref="XdkDevice.AddVirtualPage">Xdk.device.AddVirtualPage</see> command has been called, and a virtual page is available to be trapped, pressing the hardware back button will fire this event rather than the default functionality of the back button. The hardware back button refers to the physical button on the device, and so it is obviously not available on all platforms (for example, the iPhone does not have a back button).
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkDevice.AddVirtualPage"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// //pass a true to start capturing the back button
        /// //pass a false to stop capturing the back button
        /// //on a capture, the HWBackButtonPressed function is called
        /// static bool hwBackButton_boolCaptureState { get; set; }
        /// public static void HWBackButtonCapture(bool boolForceState)
        /// {
        ///     try
        ///     {
        ///         //force by default
        ///         if (boolForceState == null)
        ///         {
        ///             boolForceState = true;
        ///         }
        ///         if (boolForceState == true &amp;&amp; hwBackButton_boolCaptureState == false)
        ///         {
        ///             //capture the back button
        ///             try
        ///             {
        ///                 Xdk.device.AddVirtualPage();
        ///                 hwBackButton_boolCaptureState = true;
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("error adding virtual page:" + e.message);
        ///             }
        ///         }
        ///         else if (boolForceState == false)
        ///         {
        ///             //stop capturing the back button
        ///             try
        ///             {
        ///                 Xdk.device.RemoveVirtualPage();
        ///                 hwBackButton_boolCaptureState = false;
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("error removing virtual page:" + e.message);
        ///             }
        ///         }
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in captureHWBackButton: " + e.message);
        ///     }
        /// }
        /// public static void HWBackButtonPressed(DeviceEvent evt)
        /// {
        ///     try
        ///     {
        ///         Xdk.device.AddVirtualPage();
        ///         //        HWBackButtonExecute();
        ///         HtmlContext.console.Log("Hardware Back Button Pressed");
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in HWBackButtonPressed: " + e.message);
        ///     }
        /// }
        /// public static void HWBackButtonInit()
        /// {
        ///     Xdk.OnDeviceHardwareBack += HWBackButtonPressed;
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceHardwareBack
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.hardware.back\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.hardware.back\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire whenever the current orientation of the device changes
        /// </summary>
        /// <remarks>
        ///  The value is sent with the event and updated in <see cref="XdkDevice.orientation">Xdk.device.orientation</see>. The orientation parameter on the event object will contain one of the following values:
        /// <list type="table">
        /// <listheader>1
        /// <term>Orientation</term>
        /// <description>Value</description>
        /// </listheader>
        /// <item>
        /// <term>Portrait</term>
        /// <description>0</description>
        /// </item>
        /// <item>
        /// <term>Upside Down Portrait</term>
        /// <description>180</description>
        /// </item>
        /// <item>
        /// <term>Landscape Right</term>
        /// <description>90</description>
        /// </item>
        /// <item>
        /// <term>Landscape Left</term>
        /// <description>-90</description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkDeviceEvent> OnDeviceOrientationChange
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.orientation.change\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.orientation.change\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the screen locks
        /// </summary>
        /// <remarks>
        /// This event is triggered when the screen turns off due to power saving timeout or the user presses the power button.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitEvent()
        /// {
        ///     Xdk.OnDevicePause += Xdk_DevicePause;
        /// }
        /// static void Xdk_DevicePause(DeviceEvent evt)
        /// {
        ///     Xdk.player.Pause();
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDevicePause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.pause\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.pause\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire once all Intel XDK JavaScript bridge library loaded
        /// </summary>
        /// <remarks>
        /// This event will fire once all Intel XDK library information is loaded. Be sure to allow this event to fire before attempting any Intel XDK commands. In order to load the Intel XDK JavaScript library, be sure to include the following JavaScript library in your HTML file.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitEvent()
        /// {
        ///     Xdk.OnDeviceReady += Xdk_DeviceReady;
        /// }
        /// static void Xdk_DeviceReady(DeviceEvent evt)
        /// {
        ///     //lock the application in portrait orientation
        ///     Xdk.device.SetRotateOrientation(DeviceOrientation.Portrait);
        ///     Xdk.device.SetAutoRotate(false);
        ///     //hide splash screen
        ///     Xdk.device.HideSplashScreen();
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceReady
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.ready\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.ready\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once navigation to a web page from the main browser window is blocked by the <see cref="XdkDevice.BlockRemotePages">Xdk.device.BlockRemotePages</see> command
        /// </summary>
        /// <remarks>
        /// This event is fired upon completion of the <see cref="XdkDevice.BlockRemotePages">Xdk.device.BlockRemotePages</see> method and includes a "success" property that is set to true or false and an “blocked” property which contains the URL which was blocked. The application can ignore this URL or use the device.showRemoteSite method to view.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkDevice.BlockRemotePages"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void InitBlockRemotePages()
        /// {
        ///     //Set up a list of domains for which you allow remote pages
        ///     var whitelist = "www.cnn.com|www.appmobi.com:44|www.aol.com";
        ///     //Set up a list of domains for which you allow remote pages
        ///     Xdk.device.BlockRemotePages(true, whitelist);
        ///     Xdk.OnDeviceRemoteBlock += Xdk_DeviceRemoteBlock;
        /// }
        /// static void Xdk_DeviceRemoteBlock(DeviceRemoteEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert(evt.blocked + "ignored");
        ///     }
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceRemoteEvent> OnDeviceRemoteBlock
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.remote.block\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.remote.block\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event will fire once a new webview opened by the <see cref="XdkDevice.ShowRemoteSite">Xdk.device.ShowRemoteSite</see> command is closed
        /// </summary>
        /// <remarks>
        /// The <see cref="XdkDevice.ShowRemoteSite">Xdk.device.ShowRemoteSite</see> command is used to create a brand new web view in an application. This event will fire this event once a user closes the new webview.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkDevice.CloseRemoteSite"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkDevice.ShowRemoteSite"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkDevice.ShowRemoteSiteExt"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void ShowRemoteSite()
        /// {
        ///     Xdk.OnDeviceRemoteClose += Xdk_DeviceRemoteClose;
        ///     Xdk.device.ShowRemoteSite("http://www.twitter.com/", 280, 0, 50, 50);
        /// }
        /// static void Xdk_DeviceRemoteClose(DeviceRemoteEvent evt)
        /// {
        ///     HtmlContext.Alert("Twitter Window Closed");
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceRemoteEvent> OnDeviceRemoteClose
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.remote.close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.remote.close\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a response is received from the remote server in response to the <see cref="XdkDevice.GetRemoteDataExt">Xdk.device.GetRemoteDataExt</see> command
        /// </summary>
        /// <remarks>
        /// It contains a response element which contains the server response, and an extras element which contains the name/value pairs for each item in the headers object.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkDevice.GetRemoteDataExt"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void GetRemote(JsString name, JsString value)
        /// {
        ///     //Example Event Handlers
        ///     Xdk.OnDeviceRemoteData += Xdk_DeviceRemoteData;
        ///     //GET method example
        ///     var parameters = new DeviceRemoteDataParameters();
        ///     parameters.url = "http://twitter.com/statuses/public_timeline.xml";
        ///     parameters.id = "12345";
        ///     Xdk.device.GetRemoteDataExt(parameters);
        ///     //POST method example
        ///     var status = "status=" + "It is good to be alive";
        ///     parameters = new DeviceRemoteDataParameters();
        ///     parameters.url = "http://twitter.com/statuses/public_timeline.xml";
        ///     parameters.id = "12345";
        ///     parameters.method = GetPost.Post;
        ///     parameters.body = status;
        ///     //To add headers call AddHeader
        ///     parameters.AddHeader(name, value);
        ///     Xdk.device.GetRemoteDataExt(parameters);
        /// }
        /// static void Xdk_DeviceRemoteData(DeviceRemoteEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error obtaining remote data");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success: " + evt.response);
        ///     }
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceRemoteEvent> OnDeviceRemoteData
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.remote.data\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.remote.data\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event indicates that the user has switched back to using the application
        /// </summary>
        /// <remarks>
        /// If an application was minimized, but it never left memory, this event will fire in lieu of the <see cref="Xdk.OnDeviceReady"/> command.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitEvent()
        /// {
        ///     Xdk.OnDeviceResume += Xdk_DeviceResume;
        /// }
        /// static void Xdk_DeviceResume(DeviceEvent evt)
        /// {
        ///     // restart application sound
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceResume
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.resume\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.resume\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event indicates that the user has task-switched away from the application
        /// </summary>
        /// <remarks>
        /// When an application is minimized, this event will be fired as soon as possible to alert the application that it is losing the user’s focus. When the application reloads, be aware that you might see an <see cref="Xdk.OnDeviceResume"/> rather than the typical <see cref="Xdk.OnDeviceReady"/> event.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitEvent()
        /// {
        ///     Xdk.OnDeviceSuspend += Xdk_DeviceSuspend;
        /// }
        /// static void Xdk_DeviceSuspend(DeviceEvent evt)
        /// {
        ///     // pause application sound
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceSuspend
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.suspend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.suspend\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the Live Update service of hostMobi has successfully downloaded an update for an application
        /// </summary>
        /// <remarks>
        /// This event fires when a Live Update has been successfully loaded in the background of an application and awaits update by the application using <see cref="XdkDevice.InstallUpdate">Xdk.device.InstallUpdate()</see>. The event object will return two parameters. The first is updateMessage that holds the text of the message passed along with the Live Update. The second is type.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Confirm"
        /// public static void InitEvent()
        /// {
        ///     Xdk.OnDeviceUpdateAvailable += OnUpdateAvailable;
        /// }
        /// static void OnUpdateAvailable(DeviceEvent evt)
        /// {
        ///     /* test to see if the event is Xdk.DeviceUpdateAvailable */
        ///     if (evt.type == XdkDeviceEventType.DeviceUpdateAvailable)
        ///     {
        ///         /* there is an update available *while* the application is running - decide what to do */
        ///         if (HtmlContext.Confirm(evt.updateMessage) == true)
        ///         {
        ///             Xdk.device.InstallUpdate();
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        public static event EventListener<XdkDeviceEvent> OnDeviceUpdateAvailable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.device.update.available\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.device.update.available\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// This event is fired upon completion, after a call to <see cref="XdkNotification.Confirm">Xdk.notification.Confirm</see>.
        /// </summary>
        /// <remarks>
        /// This event includes a "success", "answer", and "id" properties. If success, "answer" will be set to "true" for confirmation, and "id" contains the value of the confirmEventId parameter provided in the function call.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.Confirm"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationEvent> OnNotificationConfirm
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.confirm\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.confirm\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// This event is fired if the GCM service notifies Intel XDK that there is no Google account on the phone.
        /// </summary>
        /// <remarks>
        /// According to Google, the application should ask the user to open the account manager and add a Google account. Refer to ACCOUNT_MISSING description: http://developer.android.com/guide/google/gcm/gcm.html#handling_reg .
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.AddPushUser"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkNotification.CheckPushUser"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushAccountmissing
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.accountmissing\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.accountmissing\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a push notification is removed from the messaging system
        /// </summary>
        /// <remarks>
        /// It includes an event object having a "success" property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.DeletePushNotifications"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushDelete
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.delete\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.delete\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the user is signed out of the pushMobi messaging system
        /// </summary>
        /// <remarks>
        /// This event is fired once the user is signed out of push. It includes an event object having a "success" property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.DeletePushUser"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushDisable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.disable\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.disable\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a user's credentials have been confirmed by the application and push notifications are enabled.
        /// </summary>
        /// <remarks>
        /// This event is fired following a call to <see cref="XdkNotification.CheckPushUser">Xdk.notification.AddPushUser</see> method (or <see cref="XdkNotification.CheckPushUser">Xdk.notification.CheckPushUser</see>). This event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.AddPushUser"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkNotification.CheckPushUser"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushEnable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.enable\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.enable\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Deprecated This event is fired once a push notification is marked as read and removed from the messaging system
        /// </summary>
        /// <remarks>
        /// This event is fired once a push notification is marked as read and removed from the messaging system. It includes an event object having a “success” property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.ReadPushNotifications"/> (deprecated)</description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushRead
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.read\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.read\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the application has gotten a push notification.
        /// </summary>
        /// <remarks>
        /// This event is fired once the application has gotten a push notification. It includes an event object having a “success” property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushReceive
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.receive\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.receive\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the notification system refreshes the data on an application
        /// </summary>
        /// <remarks>
        /// It includes an event object having a “success” property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.RefreshPushNotifications"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushRefresh
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.refresh\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.refresh\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired if <see cref="XdkNotification.ShowRichPushViewer">Xdk.notification.ShowRichPushViewer</see> is called while a rich push message is already visible
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.ShowRichPushViewer"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushRichBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.rich.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.rich.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a rich push message is closed
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.ShowRichPushViewer"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkNotification.CloseRichPushViewer"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushRichClose
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.rich.close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.rich.close\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a push notification is sent from an application
        /// </summary>
        /// <remarks>
        /// It includes an event object having a “success” property that will hold either a true or a false. The event object may additionally include a “message” property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.SendPushNotification"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushSend
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.send\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.send\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a request is made by a user to have their notifications password emailed to them.
        /// </summary>
        /// <remarks>
        /// It includes an event object having a "success" property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.SendPushUserPass"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushSendpassword
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.sendpassword\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.sendpassword\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired after a call to <see cref="XdkNotification.EditPushUser(JsString,JsString)">Xdk.notification.EditPushUser</see>.
        /// </summary>
        /// <remarks>
        /// The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.EditPushUser(JsString,JsString)"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushUserEdit
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.user.edit\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.user.edit\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired once further demographic information is associated with a user
        /// </summary>
        /// <remarks>
        ///  It includes an event object having a "success" property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.SetPushUserAttributes"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushUserEditattributes
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.user.editattributes\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.user.editattributes\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired following a request by an application to find other users of the application
        /// </summary>
        /// <remarks>
        /// It includes an event object having a "success" property that will hold either a true or a false. The event object may additionally include a "message" property describing any errors.
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkNotification.FindPushUser"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkNotificationPushEvent> OnNotificationPushUserFind
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.notification.push.user.find\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.notification.push.user.find\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// This event is fired when the accessing of oauth data is blocked by a <see cref="XdkOAuth.GetProtectedData">Xdk.oAuth.GetProtectedData</see> call that hasn't yet finished.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkOAuth.GetProtectedData"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkOAuth.UnauthorizeService"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkOAuthEvent> OnOAuthBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.oauth.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.oauth.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired at completion of the <see cref="XdkOAuth.GetProtectedData">Xdk.oAuth.GetProtectedData</see> call. Success returns data for the response, failure indicates an error condition.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkOAuth.GetProtectedData"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkOAuthEvent> OnOAuthProtectedData
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.oauth.protected.data\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.oauth.protected.data\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event indicates when oauth initialization is complete. Success means your service keys were obtained.
        /// </summary>
        /// <remarks>
        /// The Xdk.oAuthAvailable property should be checked at <see cref="Xdk.OnDeviceReady"/> to see if the OAuth system is available.
        /// Since each application has a key used to decrypt the secret OAuth keys in memory, OAuth may not always be ready at <see cref="Xdk.OnDeviceReady"/>.
        /// If this is the case, the Xdk.OAuthSetup event will be fired when it does become available.
        /// <para>If an attempt to access OAuth is made prior to it being available, the <see cref="Xdk.OnOAuthUnavailable"/> event is fired.</para>
        /// </remarks>
        public static event EventListener<XdkOAuthEvent> OnOAuthSetup
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.oauth.setup\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.oauth.setup\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired at completion of a <see cref="XdkOAuth.UnauthorizeService">Xdk.oAuth.UnauthorizeService</see> call. Success indicates that the specified service was unauthorized, failure indicates that the specified service was not a configured OAuth service.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkOAuth.UnauthorizeService"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkOAuthEvent> OnOAuthUnauthorize
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.oauth.unauthorize\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.oauth.unauthorize\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when attempting to access oauth data before initialization is complete.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkOAuth.GetProtectedData"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkOAuth.UnauthorizeService"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkOAuthEvent> OnOAuthUnavailable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.oauth.unavailable\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.oauth.unavailable\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired if a second Facebook request is made while a previous request is still pending.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFacebook.Login"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.Logout"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.RequestWithGraphAPI"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.ShowAppRequestDialog"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.ShowNewsFeedDialog"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFacebookEvent> OnFacebookBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired in response to a news feed or app request dialog.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFacebook.ShowAppRequestDialog"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.ShowNewsFeedDialog"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFacebookEvent> OnFacebookDialogComplete
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.dialog.complete\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.dialog.complete\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// This event is fired if Facebook tries to log the user on during a dialog request, but the login fails.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFacebook.ShowAppRequestDialog"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.ShowNewsFeedDialog"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFacebookEvent> OnFacebookDialogFail
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.dialog.fail\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.dialog.fail\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired after logging a user into Facebook
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFacebook.Login"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFacebookEvent> OnFacebookLogin
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.login\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.login\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired after logging a user out of Facebook
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFacebook.Logout"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="XdkFacebook.RequestWithGraphAPI"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFacebookEvent> OnFacebookLogout
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.logout\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.logout\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired in response to a Facebook API request.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFacebook.RequestWithGraphAPI"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFacebookEvent> OnFacebookRequestResponse
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.request.response\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.request.response\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired if the Facebook session is invalidated.
        /// </summary>
        public static event EventListener<XdkFacebookEvent> OnFacebookSessionInvalidate
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.facebook.session.invalidate\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.facebook.session.invalidate\"", InsertArg1 = "false")]
            remove { }
        }

        /// <summary>
        /// Fired once the file.uploadToServer method is complete.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFile.UploadToServer"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFileEvent> OnFileUpload
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.file.upload\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.file.upload\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired when accessing the file upload is blocked by another process.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFile.UploadToServer"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFileEvent> OnFileUploadBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.file.upload.busy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.file.upload.busy\"", InsertArg1 = "false")]
            remove { }
        }
        /// <summary>
        /// Fired if the file upload has been interrupted/cancelled.
        /// </summary>
        /// <remarks>
        /// <para>Method(s) that fire this event:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="XdkFile.CancelUpload"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static event EventListener<XdkFileEvent> OnFileUploadCancel
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "\"intel.xdk.file.upload.cancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "\"intel.xdk.file.upload.cancel\"", InsertArg1 = "false")]
            remove { }
        }
        #endregion

        /// <summary>
        /// Add an initialization function to a queue that ensures it will run and initialize application constructors only once Intel XDK has been initialized.
        /// </summary>
        /// <param name="func"></param>
        [JsMethod(Name = "addConstructor")]
        public static void AddConstructor(JsAction func) { }
        /// <summary>
        /// Execute a Intel XDK command in a queued fashion, to ensure commands do not execute with any race conditions, and only run when Intel XDK is ready to recieve them.
        /// </summary>
        /// <param name="command">Command to be run in Intel XDK, e.g. "ClassName.method"</param>
        [JsMethod(Name = "exec")]
        public static void Exec(JsString command) { }
        /// <summary>
        /// Execute a Intel XDK command in a queued fashion, to ensure commands do not execute with any race conditions, and only run when Intel XDK is ready to recieve them.
        /// </summary>
        /// <param name="command">Command to be run in Intel XDK, e.g. "ClassName.method"</param>
        /// <param name="args">Zero or more arguments to pass to the method</param>
        [JsMethod(Name = "exec")]
        public static void Exec(JsString command, params object[] args) { }
        /// <summary>
        /// Internal function used to dispatch the request to Intel XDK. This needs to be implemented per-platform to ensure that methods are called on the phone in a way appropriate for that device.
        /// </summary>
        [JsMethod(Name = "run_command")]
        public static void _RunCommand() { }
        [JsMethod(Name = "stubEvent")]
        public static void StubEvent(JsString eventSuffix) { }
        [JsMethod(Name = "stubEvent")]
        public static void StubEvent(JsString eventSuffix, params object[] extra) { }

        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkCacheEventType type, EventListener<XdkCacheEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkCacheEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkCacheEventType type, EventListener<XdkCacheEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkCameraEventType type, EventListener<XdkCameraEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkCameraEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkCameraEventType type, EventListener<XdkCameraEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkContactsEventType type, EventListener<XdkContactsEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkContactsEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkContactsEventType type, EventListener<XdkContactsEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkDeviceBarcodeEventType type, EventListener<XdkDeviceBarcodeEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkDeviceBarcodeEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkDeviceBarcodeEventType type, EventListener<XdkDeviceBarcodeEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkDeviceEventType type, EventListener<XdkDeviceEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkDeviceEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkDeviceEventType type, EventListener<XdkDeviceEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkDeviceRemoteEventType type, EventListener<XdkDeviceRemoteEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkDeviceRemoteEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkDeviceEventType type, EventListener<XdkDeviceRemoteEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkFacebookEventType type, EventListener<XdkFacebookEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkFacebookEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkFacebookEventType type, EventListener<XdkFacebookEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkFileEventType type, EventListener<XdkFileEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkFileEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkFileEventType type, EventListener<XdkFileEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkNotificationEventType type, EventListener<XdkNotificationEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkNotificationEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkNotificationEventType type, EventListener<XdkNotificationEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkNotificationPushEventType type, EventListener<XdkNotificationPushEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkNotificationPushEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkNotificationPushEventType type, EventListener<XdkNotificationPushEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkOAuthEventType type, EventListener<XdkOAuthEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkOAuthEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkOAuthEventType type, EventListener<XdkOAuthEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.addEventListener")]
        public static void AddEventListener(XdkPlayerEventType type, EventListener<XdkPlayerEvent> listener, bool useCapture = false) { }
        [JsMethod(Global = true, Name = "document.dispatchEvent")]
        public static bool DispatchEvent(XdkPlayerEvent evt) { return default(bool); }
        [JsMethod(Global = true, Name = "document.removeEventListener")]
        public static void RemoveEventListener(XdkPlayerEventType type, EventListener<XdkPlayerEvent> listener, bool useCapture = false) { }

    }
    #endregion

    #region Enum for platform type
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkDevicePlatformType
    {
        [JsField(Name = "Android")]
        Android,
        [JsField(Name = "iOS")]
        iOS,
        [JsField(Name = "Windows")]
        Windows
    }
    #endregion

    #region Enum for connection type
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkDeviceConnectionType
    {
        [JsField(Name = "wifi")]
        Wifi,
        [JsField(Name = "cell")]
        Cell,
        [JsField(Name = "none")]
        None,
        [JsField(Name = "unknown")]
        Unknown
    }
    #endregion

    #region Enum for Intel XDK events
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkContactsEventType
    {
        [JsField(Name = "intel.xdk.contacts.add")]
        ContactsAdd,
        [JsField(Name = "intel.xdk.contacts.busy")]
        ContactsBusy,
        [JsField(Name = "intel.xdk.contacts.choose")]
        ContactsChoose,
        [JsField(Name = "intel.xdk.contacts.edit")]
        ContactsEdit,
        [JsField(Name = "intel.xdk.contacts.get")]
        ContactsGet,
        [JsField(Name = "intel.xdk.contacts.remove")]
        ContactsRemove
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkPlayerEventType
    {
        [JsField(Name = "intel.xdk.player.audio.busy")]
        PlayerAudioBusy,
        [JsField(Name = "intel.xdk.player.audio.currenttime.set")]
        PlayerAudioCurrenttimeSet,
        [JsField(Name = "intel.xdk.player.audio.error")]
        PlayerAudioError,
        [JsField(Name = "intel.xdk.player.audio.start")]
        PlayerAudioStart,
        [JsField(Name = "intel.xdk.player.audio.stop")]
        PlayerAudioStop,
        [JsField(Name = "intel.xdk.player.hide")]
        PlayerHide,
        [JsField(Name = "intel.xdk.player.show")]
        PlayerShow,
        [JsField(Name = "intel.xdk.player.podcast.busy")]
        PlayerPodcastBusy,
        [JsField(Name = "intel.xdk.player.podcast.error")]
        PlayerPodcastError,
        [JsField(Name = "intel.xdk.player.podcast.play")]
        PlayerPodcastPlay,
        [JsField(Name = "intel.xdk.player.podcast.pause")]
        PlayerPodcastPause,
        [JsField(Name = "intel.xdk.player.podcast.start")]
        PlayerPodcastStart,
        [JsField(Name = "intel.xdk.player.podcast.stop")]
        PlayerPodcastStop,
        [JsField(Name = "intel.xdk.player.shoutcast.busy")]
        PlayerShoutcastBusy,
        [JsField(Name = "intel.xdk.player.shoutcast.error")]
        PlayerShoutcastError,
        [JsField(Name = "intel.xdk.player.shoutcast.play")]
        PlayerShoutcastPlay,
        [JsField(Name = "intel.xdk.player.shoutcast.pause")]
        PlayerShoutcastPause,
        [JsField(Name = "intel.xdk.player.shoutcast.start")]
        PlayerShoutcastStart,
        [JsField(Name = "intel.xdk.player.shoutcast.stop")]
        PlayerShoutcastStop,
        [JsField(Name = "intel.xdk.player.sound.error")]
        PlayerSoundError,
        [JsField(Name = "intel.xdk.player.station.busy")]
        PlayerStationBusy,
        [JsField(Name = "intel.xdk.player.station.error")]
        PlayerStationError,
        [JsField(Name = "intel.xdk.player.station.pause")]
        PlayerStationPause,
        [JsField(Name = "intel.xdk.player.station.play")]
        PlayerStationPlay,
        [JsField(Name = "intel.xdk.player.station.start")]
        PlayerStationStart,
        [JsField(Name = "intel.xdk.player.station.stop")]
        PlayerStationStop,
        [JsField(Name = "intel.xdk.player.track.change")]
        PlayerTrackChange
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkCameraEventType
    {
        [JsField(Name = "intel.xdk.camera.takePicture")]
        CameraTakePicture,
        [JsField(Name = "intel.xdk.camera.takeFrontPicture")]
        CameraTakeFrontPicture,
        [JsField(Name = "intel.xdk.camera.picture.add")]
        CameraPictureAdd,
        [JsField(Name = "intel.xdk.camera.picture.busy")]
        CameraPictureBusy,
        [JsField(Name = "intel.xdk.camera.picture.cancel")]
        CameraPictureCancel,
        [JsField(Name = "intel.xdk.camera.picture.clear")]
        CameraPictureClear,
        [JsField(Name = "intel.xdk.camera.picture.remove")]
        CameraPictureRemove
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkCacheEventType
    {
        [JsField(Name = "intel.xdk.cache.media.add")]
        CacheMediaAdd,
        [JsField(Name = "intel.xdk.cache.media.clear")]
        CacheMediaClear,
        [JsField(Name = "intel.xdk.cache.media.remove")]
        CacheMediaRemove,
        [JsField(Name = "intel.xdk.cache.media.update")]
        CacheMediaUpdate
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkDeviceRemoteEventType
    {
        [JsField(Name = "intel.xdk.device.remote.block")]
        DeviceRemoteBlock,
        [JsField(Name = "intel.xdk.device.remote.close")]
        DeviceRemoteClose,
        [JsField(Name = "intel.xdk.device.remote.data")]
        DeviceRemoteData
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkDeviceBarcodeEventType
    {
        [JsField(Name = "intel.xdk.device.barcode.scan")]
        DeviceBarcodeScan
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkDeviceEventType
    {
        [JsField(Name = "intel.xdk.device.connection.update")]
        DeviceConnectionUpdate,
        [JsField(Name = "intel.xdk.device.continue")]
        DeviceContinue,
        [JsField(Name = "intel.xdk.device.hardware.back")]
        DeviceHardwareBack,
        [JsField(Name = "intel.xdk.device.orientation.change")]
        DeviceOrientationChange,
        [JsField(Name = "intel.xdk.device.pause")]
        DevicePause,
        [JsField(Name = "intel.xdk.device.ready")]
        DeviceReady,
        [JsField(Name = "intel.xdk.device.resume")]
        DeviceResume,
        [JsField(Name = "intel.xdk.device.suspend")]
        DeviceSuspend,
        [JsField(Name = "intel.xdk.device.update.available")]
        DeviceUpdateAvailable
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkNotificationEventType
    {
        [JsField(Name = "intel.xdk.notification.confirm")]
        NotificationConfirm
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkNotificationPushEventType
    {
        [JsField(Name = "intel.xdk.notification.push.accountmissing")]
        NotificationPushAccountmissing,
        [JsField(Name = "intel.xdk.notification.push.delete")]
        NotificationPushDelete,
        [JsField(Name = "intel.xdk.notification.push.disable")]
        NotificationPushDisable,
        [JsField(Name = "intel.xdk.notification.push.enable")]
        NotificationPushEnable,
        [JsField(Name = "intel.xdk.notification.push.read")]
        NotificationPushRead,
        [JsField(Name = "intel.xdk.notification.push.receive")]
        NotificationPushReceive,
        [JsField(Name = "intel.xdk.notification.push.refresh")]
        NotificationPushRefresh,
        [JsField(Name = "intel.xdk.notification.push.rich.busy")]
        NotificationPushRichBusy,
        [JsField(Name = "intel.xdk.notification.push.rich.close")]
        NotificationPushRichClose,
        [JsField(Name = "intel.xdk.notification.push.send")]
        NotificationPushSend,
        [JsField(Name = "intel.xdk.notification.push.sendpassword")]
        NotificationPushSendpassword,
        [JsField(Name = "intel.xdk.notification.push.user.edit")]
        NotificationPushUserEdit,
        [JsField(Name = "intel.xdk.notification.push.user.editattributes")]
        NotificationPushUserEditattributes,
        [JsField(Name = "intel.xdk.notification.push.user.find")]
        NotificationPushUserFind
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkOAuthEventType
    {
        [JsField(Name = "intel.xdk.oauth.busy")]
        OAuthBusy,
        [JsField(Name = "intel.xdk.oauth.protected.data")]
        OAuthProtectedData,
        [JsField(Name = "intel.xdk.oauth.setup")]
        OAuthBusySetup,
        [JsField(Name = "intel.xdk.oauth.unauthorize")]
        OAuthBusyUnauthorize,
        [JsField(Name = "intel.xdk.oauth.unavailable")]
        OAuthBusyUnavailable
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkFacebookEventType
    {
        [JsField(Name = "intel.xdk.facebook.busy")]
        FacebookBusy,
        [JsField(Name = "intel.xdk.facebook.dialog.complete")]
        FacebookDialogComplete,
        [JsField(Name = "intel.xdk.facebook.dialog.fail")]
        FacebookDialogFail,
        [JsField(Name = "intel.xdk.facebook.login")]
        FacebookLogin,
        [JsField(Name = "intel.xdk.facebook.logout")]
        FacebookLogout,
        [JsField(Name = "intel.xdk.facebook.request.response")]
        FacebookRequestResponse,
        [JsField(Name = "intel.xdk.facebook.session.invalidate")]
        FacebookSessionInvalidate
    }
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkFileEventType
    {
        [JsField(Name = "intel.xdk.file.upload")]
        FileUpload,
        [JsField(Name = "intel.xdk.file.upload.busy")]
        FileUploadBusy,
        [JsField(Name = "intel.xdk.file.upload.cancel")]
        FileUploadCancel
    }

    #endregion

    #region Enum for call mode for Notifications
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkCallModeNotifications
    {
        [JsField(Name = "read")]
        Read = 1,
        [JsField(Name = "delete")]
        Delete = 2
    }
    #endregion

    #region XdkEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkEvent : Event
    {
        /// <summary>
        /// This parameter returns a true if the operation was successfully completed, or false if the operation was cancelled or there was an error.
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// This parameter returns a true if the operation was cancelled.
        /// </summary>
        public bool cancelled { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkEvent<TEnumEventType> : XdkEvent
    {
        public new HtmlDocument srcElement { get; set; }
        public new HtmlDocument target { get; set; }
        public new HtmlDocument currentTarget { get; set; }
        public new TEnumEventType type { get; set; }

        [JsMethod(Name = "initEvent")]
        public void InitEvent(TEnumEventType eventTypeArg, bool canBubbleArg, bool cancelableArg) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "initEvent")]
        public new void InitEvent(JsString eventTypeArg, bool canBubbleArg, bool cancelableArg) { }
    }
    #endregion

    #region ContactsEvent
    /// <summary>
    /// Contacts event
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkContactsEvent : XdkEvent<XdkContactsEventType>
    {
        /// <summary>
        /// This parameter returns the error message.
        /// </summary>
        public JsString error { get; set; }
        /// <summary>
        /// The contact id of the contact.
        /// </summary>
        [JsProperty(Name = "contactid", NativeField = true)]
        public JsString contactId { get; set; }
    }
    #endregion

    #region PlayerEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkPlayerEvent : XdkEvent<XdkPlayerEventType>
    {
        /// <summary>
        /// This parameter returns the error message.
        /// </summary>
        public JsString error { get; set; }
    }
    #endregion

    #region CameraPictureEvent
    /// <summary>
    /// Camera Picture event
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkCameraEvent : XdkEvent<XdkCameraEventType>
    {
        //	The filename of the image in the picture list (only for the 'add' operation).
        public JsString filename { get; set; }
        public JsString message { get; set; }
    }
    #endregion

    #region CacheEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkCacheEvent : XdkEvent<XdkCacheEventType>
    {
        /// <summary>
        /// the URL of the remote file cached.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        ///  the unique ID assigned when the command was called.
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// the current number of bytes downloaded and cached so far
        /// </summary>
        public long current { get; set; }
        /// <summary>
        /// the total number of bytes in the file
        /// </summary>
        public long total { get; set; }
    }
    #endregion

    #region DeviceEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkDeviceEvent : XdkEvent<XdkDeviceEventType>
    {
        /// <summary>
        /// 
        /// </summary>
        public JsString updateMessage { get; set; }
        public int orientation { get; set; }
        public XdkDeviceConnectionType connection { get; set; }

    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkDeviceRemoteEvent : XdkEvent<XdkDeviceRemoteEventType>
    {
        /// <summary>
        /// 
        /// </summary>
        public JsString message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsString response { get; set; }
        /// <summary>
        /// Contains the URL which was blocked. The application can ignore this URL or use the <see cref="XdkDevice.ShowRemoteSite">device.ShowRemoteSite</see> method to view.
        /// </summary>
        public JsString blocked { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkDeviceBarcodeEvent : XdkEvent<XdkDeviceBarcodeEventType>
    {
        /// <summary>
        /// On a successful read, the data embedded in the QR code will be returned here.
        /// </summary>
        [JsProperty(Name = "codedata", NativeField = true)]
        public JsString codeData { get; set; }
    }
    #endregion

    #region NotificationEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkNotificationEvent : XdkEvent<XdkNotificationEventType>
    {
        /// <summary>
        /// confirmEventID
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// True for confirmation
        /// </summary>
        public bool answer { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkNotificationPushEvent : XdkEvent<XdkNotificationPushEventType>
    {
        /// <summary>
        /// This parameter returns the error message.
        /// </summary>
        public JsString message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsString id { get; set; }
    }
    #endregion

    #region OAuthEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkOAuthEvent : XdkEvent<XdkOAuthEventType>
    {
        public JsObject data { get; set; }   // TODO verify type
        public JsString origin { get; set; }
        public JsString response { get; set; }
        public JsString error { get; set; }
        public JsString id { get; set; }
    }
    #endregion

    #region FacebookEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkFacebookEvent : XdkEvent<XdkFacebookEventType>
    {

        public XdkFacebookDataEvent data { get; set; }
    }
    #endregion

    #region FileEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public partial class XdkFileEvent : XdkEvent<XdkFileEventType>
    {
        [JsProperty(Name = "localURL", NativeField = true)]
        public JsString localUrl { get; set; }
        public JsString message { get; set; }
    }
    #endregion

    #region Queue
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkQueueData
    {
        public bool ready { get; set; }
        public JsArray commands { get; set; }   // TODO verify type
        public JsNumber timer { get; set; } // TODO verify type
    }
    #endregion

    #region Accelerometer
    public delegate void XdkAccelerationCallback(XdkAcceleration acceleration);

    /// <summary>
    /// This class contains acceleration information.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Acceleration")]
    public partial class XdkAcceleration
    {
        /// <summary>
        /// The force applied by the device in the x-axis (in m/s^2).
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// The force applied by the device in the y-axis (in m/s^2).
        /// </summary>
        public double y { get; set; }
        /// <summary>
        /// The force applied by the device in the z-axis (in m/s^2).
        /// </summary>
        public double z { get; set; }
        /// <summary>
        /// The time that the acceleration was obtained.
        /// </summary>
        public JsNumber timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The force applied by the device in the x-axis (in m/s^2).</param>
        /// <param name="y">The force applied by the device in the y-axis (in m/s^2).</param>
        /// <param name="z">The force applied by the device in the z-axis (in m/s^2).</param>
        /// <param name="doRotate">If true, rotate axes based on device rotation.</param>
        public XdkAcceleration(double x, double y, double z, bool doRotate) { }
    }


    /// <summary>
    /// This class specifies the options for requesting acceleration data.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.AccelerationOptions")]
    public partial class XdkAccelerationOptions
    {
        public long frequency { get; set; }
        public bool adjustForRotation { get; set; }
    }

    /// <summary>
    /// Use the accelerometer object to listen to the device's motion sensor.
    /// </summary>
    /// <remarks>
    /// The accelerometer is the device on a smartphone that detects movement. The accelerometer object is used to track the accelerometer on the device. Success and failure callback functions need to be defined in your Javascript. Successful data is returned as an object with the attributes ".x", ".y", and ".z". Values of accelerometer samples for each axis range from -1 to 1.
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Accelerometer")]
    public partial class XdkAccelerometer
    {
        /// <summary>
        /// This method will asynchronously acquire the device's acceleration when it is called.
        /// </summary>
        /// <remarks>
        /// This method will asynchronously acquire the acceleration on the device when it is called. The optional acceleration options parameter is looking for a javascript object with the ".adjustForRotation" property which changes the values of the .x and .y parameter based on the device orientation. The success function callback is triggered once data is available. Successful data is returned as an object with the attributes ".x", ".y", and ".z".
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void GetSingleAcceleration()
        /// {
        ///     Xdk.accelerometer.GetCurrentAcceleration(
        ///    new AccelerationCallback(delegate(Acceleration acc)
        ///    {
        ///        HtmlElement.GetById("accelerometerReadings").innerHTML =
        ///        "Acceleration X: " + acc.x + "&lt;br/&gt;" +
        ///        "Acceleration Y: " + acc.y + "&lt;br/&gt;" +
        ///        "Acceleration Z: " + acc.z + "&lt;br/&gt;" +
        ///        "Timestamp: " + acc.timestamp;
        ///    }), new AccelerationOptions() { adjustForRotation = false });
        /// }
        /// </code>
        /// </example>
        /// <param name="accelerometerSuccess">A function executed when the method successfully detects an accelerometer change.</param>
        /// <param name="accelerometerOptions">An object that contains the adjustForRotation property to set it to adjust for device orientation or not.</param>
        /// <returns>Successful data is returned as an object with the attributes ".x", ".y", and ".z".</returns>
        [JsMethod(Name = "getCurrentAcceleration")]
        public XdkAcceleration GetCurrentAcceleration(XdkAccelerationCallback accelerometerSuccess, XdkAccelerationOptions accelerometerOptions) { return default(XdkAcceleration); }

        /// <summary>
        /// This method will asynchronously acquire the device's acceleration repeatedly at a given interval.
        /// </summary>
        /// <remarks>
        /// This method will asynchronously acquire the acceleration repeatedly at a given interval. The acceleration options parameter is looking for a javascript object with two properties: ".frequency" which changes that millisecond interval for refresh and has a default of 500 and ".adjustForRotation" which changes the values of the .x and .y parameter based on the device orientation. The success function callback is triggered each time data is available. Successful data is returned as an object with the attributes ".x", ".y", and ".z". This method returns a watch timer object to be cleared with ClearWatch.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void WatchAcceleration()
        /// {
        ///     var options = new AccelerationOptions() { frequency = 3000, adjustForRotation = true };  // Update every 3 seconds
        ///     var watchID = Xdk.accelerometer.WatchAcceleration(OnSuccess, options);
        /// }
        /// static void OnSuccess(Acceleration acc)
        /// {
        ///     HtmlElement.GetById("accelerometerReadings").innerHTML =
        ///     "Acceleration X: " + acc.x + "&lt;br/&gt;" +
        ///     "Acceleration Y: " + acc.y + "&lt;br/&gt;" +
        ///     "Acceleration Z: " + acc.z + "&lt;br/&gt;" +
        ///     "Timestamp: " + acc.timestamp;
        /// }
        /// </code>
        /// </example>
        /// <param name="accelerometerSuccess">A function executed when the method successfully detects an accelerometer change.</param>
        /// <param name="accelerometerOptions">An object that contains properties which will modify how the accelerometer information is accessed.</param>
        /// <returns>A unique identifier returned from this method that can be used to stop watching for an accelerometer change.</returns>
        [JsMethod(Name = "watchAcceleration")]
        public long WatchAcceleration(XdkAccelerationCallback accelerometerSuccess, XdkAccelerationOptions accelerometerOptions) { return default(long); }

        /// <summary>
        /// This method stops the process started by watchAcceleration when it is passed the appropriate watch timer object.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var watchId = Xdk.accelerometer.WatchAcceleration(OnSuccess, options);
        /// // ... later on ...
        /// Xdk.accelerometer.ClearWatch(watchId);
        /// </code>
        /// </example>
        /// <param name="watchId">The ID returned by accelerometer.WatchAcceleration.</param>
        [JsMethod(Name = "clearWatch")]
        public void ClearWatch(long watchId) { }
    }
    #endregion

    #region Contact
    /// <summary>
    /// Contact informations
    /// </summary>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkContactData
    {
        public JsString id { get; set; }
        public JsString first { get; set; }
        public JsString last { get; set; }
        public JsString name { get; set; }
        public JsArray<JsString> phones { get; set; }
        public JsArray<JsString> emails { get; set; }
        public JsArray<XdkContactDataAddress> addresses { get; set; }
    }

    /// <summary>
    /// Address for contact informations
    /// </summary>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkContactDataAddress
    {
        public JsString street { get; set; }
        public JsString city { get; set; }
        public JsString state { get; set; }
        public JsString zip { get; set; }
        public JsString country { get; set; }
    }

    /// <summary>
    /// Access the default contacts database on a device from an application.
    /// </summary>
    /// <remarks>
    /// The contacts object gives programmers access to the default contacts database on the native device. The application must be built with the appropriate permissions in order for this capability to work. Use <see cref="XdkContactData"/> class to create a contact.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnContactsAdd"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnContactsRemove"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnContactsEdit"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnContactsChoose"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnContactsBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnContactsGet"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Contacts")]
    public partial class XdkContacts
    {
        /// <summary>
        /// This method accesses the add contact functionality on the device.
        /// </summary>
        /// <remarks>
        /// This method displays the native device's contacts application to allow the user to add a new contact. Once a contact is added, it will fire the <see cref="Xdk.OnContactsAdd"/> event.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnContactsAdd"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnContactsBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void AddContact()
        /// {
        ///     Xdk.OnContactsAdd += Xdk_ContactAdd;
        ///     Xdk.contacts.AddContact();
        /// }
        /// static void Xdk_ContactAdd(ContactsEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.Alert("Contact " + evt.contactId + " successfully added");
        ///     }
        ///     else if (evt.cancelled == true)
        ///     {
        ///         HtmlContext.Alert("Add Contact Cancelled");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "addContact")]
        public void AddContact() { }
        /// <summary>
        /// This method displays a list of contact names from which one can be chosen.
        /// </summary>
        /// <remarks>
        /// This method displays the native device's contacts application to allow the user to choose from the list. Once a contact is chosen, it will fire the <see cref="Xdk.OnContactsChoose"/> event.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnContactsChoose"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnContactsBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void ChooseContact()
        /// {
        ///     Xdk.OnContactsChoose += Xdk_ContactChoose;
        ///     Xdk.contacts.ChooseContact();
        /// }
        /// static void Xdk_ContactChoose(ContactsEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         Xdk.contacts.EditContact(evt.contactId);
        ///     }
        ///     else if (evt.cancelled == true)
        ///     {
        ///         HtmlContext.Alert("Choose Contact Cancelled");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "chooseContact")]
        public void ChooseContact() { }
        /// <summary>
        /// This method accesses the edit contact functionality on the device for the specified contact.
        /// </summary>
        /// <remarks>
        /// This method displays the native device's contacts application to allow the user to edit a contact. Once a user is done with their update, it will fire the <see cref="Xdk.OnContactsEdit"/> event.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnContactsEdit"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnContactsBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void EditContact(JsString contactId)
        /// {
        ///     Xdk.OnContactsEdit += Xdk_ContactEdit;
        ///     Xdk.contacts.EditContact(contactId);
        /// }
        /// static void Xdk_ContactEdit(ContactsEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.Alert("Contact " + evt.contactId + " successfully updated");
        ///     }
        ///     else if (evt.cancelled == true)
        ///     {
        ///         HtmlContext.Alert("Edit Contact Cancelled");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="contactId">The contact ID of the contact to modify</param>
        [JsMethod(Name = "editContact")]
        public void EditContact(JsString contactId) { }
        /// <summary>
        /// This command gets a specific contact object based on contact ID
        /// </summary>
        /// <remarks>
        /// This method returns a specific contact object based on contact ID from the local copy of the contact list obtained the last time the <see cref="GetContacts"/> method was called. Use <see cref="XdkContactData"/> class to create a contact.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitContactsReceived()
        /// {
        ///     Xdk.ContactsListRefresh += ContactsReceived;
        /// }
        /// public static void ContactsReceived(ContactsEvent evtContact)
        /// {
        ///     var table = HtmlTableElement.GetById("contacts");
        ///     table.innerHTML = "";
        ///     var myContacts = Xdk.contacts.GetContactList();
        ///     for (var i = 0; i &lt; myContacts.length; i++)
        ///     {
        ///         //add row to table
        ///         var contactInfo = Xdk.contacts.GetContactData(myContacts[i]);
        ///         var tr = new HtmlTableRowElement();
        ///         tr.id = "pnid" + contactInfo.id;
        ///         tr.AddEventListener("click",
        ///             new EventListener(delegate(Event evt) { HtmlInputElement.GetById("iden").value = evt.target.id; })
        ///             );
        ///         tr.style.backgroundColor = "#B8BFD8";
        ///         var td_id = new HtmlTableCellElement();
        ///         td_id.innerHTML = contactInfo.id;
        ///         tr.appendChild(td_id);
        ///         var td_msg = new HtmlTableCellElement();
        ///         td_msg.innerHTML = contactInfo.name;
        ///         tr.appendChild(td_msg);
        ///         table.appendChild(tr);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="contactId">The contact ID of the contact to modify</param>
        /// <returns>This method returns a single contact object</returns>
        [JsMethod(Name = "getContactData")]
        public XdkContactData GetContactData(JsString contactId) { return default(XdkContactData); }
        /// <summary>
        /// This command returns an array of contact IDs obtained via a call to Xdk.contacts.getContacts().
        /// </summary>
        /// <remarks>
        /// This method returns an array of contact IDs from the local copy of the contact list obtained the last time the <see cref="GetContacts"/> method was called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void InitContactsReceived()
        /// {
        ///     Xdk.ContactsListRefresh += ContactsReceived;
        /// }
        /// public static void ContactsReceived(ContactsEvent evtContact)
        /// {
        ///     var table = HtmlTableElement.GetById("contacts");
        ///     table.innerHTML = "";
        ///     var myContacts = Xdk.contacts.GetContactList();
        ///     for (var i = 0; i &lt; myContacts.length; i++)
        ///     {
        ///         //add row to table
        ///         var contactInfo = Xdk.contacts.GetContactData(myContacts[i]);
        ///         var tr = new HtmlTableRowElement();
        ///         tr.id = "pnid" + contactInfo.id;
        ///         tr.AddEventListener("click",
        ///             new EventListener(delegate(Event evt) { HtmlInputElement.GetById("iden").value = evt.target.id; })
        ///             );
        ///         tr.style.backgroundColor = "#B8BFD8";
        ///         var td_id = new HtmlTableCellElement();
        ///         td_id.innerHTML = contactInfo.id;
        ///         tr.appendChild(td_id);
        ///         var td_msg = new HtmlTableCellElement();
        ///         td_msg.innerHTML = contactInfo.name;
        ///         tr.appendChild(td_msg);
        ///         table.appendChild(tr);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <returns>An array of contact Ids for the contacts on the device.</returns>
        [JsMethod(Name = "getContactList")]
        public JsArray<JsString> GetContactList() { return default(JsArray<JsString>); }
        /// <summary>
        /// This method pulls the latest contacts from the device into local memory.
        /// </summary>
        /// <remarks>
        /// This method is called to pull a version of the device contact database locally. Use this method first to have a local copy of contact data to access using the <see cref="GetContactList"/> or <see cref="GetContactData"/> method so those methods won't be reading an uninitialized cache. It fires an event to signify when the local list has been synced up with the device database.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnContactsGet"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.ContactsListRefresh += ContactsReceived;
        /// Xdk.contacts.GetContacts();
        /// </code>
        /// </example>
        [JsMethod(Name = "getContacts")]
        public void GetContacts() { }
        /// <summary>
        /// This method removes a specific contact and the contact's information from the device.
        /// </summary>
        /// <remarks>
        /// This method displays the native device's contacts application to allow the user to remove a contact. Once a contact is removed, it will fire the <see cref="Xdk.OnContactsRemove"/> event.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnContactsRemove"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnContactsBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contactId">The contact ID of the contact to remove from the list</param>
        [JsMethod(Name = "removeContact")]
        public void RemoveContact(JsString contactId) { }
    }
    #endregion

    #region Advertising

    /// <summary>
    /// Advertising
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Advertising")]
    public partial class XdkAdvertising
    {
        [JsMethod(Name = "getAd")]
        public void GetAd(JsString adpath, JsString ident) { }
    }
    #endregion

    #region Audio
    /// <summary>
    /// AudioInfo
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.AudioInfo")]
    public partial class XdkAudioInfo
    {
        public XdkAudioInfo(JsNumber currentTime, JsNumber duration) { }
        /// <summary>
        /// This property contains the current offset (in seconds) from the beginning of the currently playing audio track.
        /// </summary>
        public JsNumber currentTime { get; set; }
        /// <summary>
        /// This property contains the length (in seconds) of the currently playing audio track.
        /// </summary>
        public JsNumber duration { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkHtmlAudioPlayer
    {
        public HtmlAudioElement player { get; set; }
        public bool playing { get; set; }
        /// <summary>
        /// Last Time : in Javascript, lasttime = 0; or lasttime = new Date();
        /// </summary>
        [JsProperty(Name = "lasttime", NativeField = true)]
        public JsNumber lastTime { get; set; }
    }
    /// <summary>
    /// Audio
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class Audio
    {
        [JsMethod(Name = "startPlaying")]
        public void StartPlaying(JsString recUrl) { }
        [JsMethod(Name = "stopPlaying")]
        public void StopPlaying() { }
        [JsMethod(Name = "pausePlaying")]
        public void PausePlaying() { }
        [JsMethod(Name = "continuePlaying")]
        public void ContinuePlaying() { }
        [JsMethod(Name = "startRecording")]
        public void StartRecording(JsString format, JsString samplingRate, object channels) { }    // TODO verify type
        [JsMethod(Name = "stopRecording")]
        public void StopRecording() { }
        [JsMethod(Name = "pauseRecording")]
        public void PauseRecording() { }
        [JsMethod(Name = "continueRecording")]
        public void ContinueRecording() { }
        [JsMethod(Name = "deleteRecording")]
        public void DeleteRecording(JsString recUrl) { }
        [JsMethod(Name = "clearRecordings")]
        public void ClearRecordings() { }
        [JsMethod(Name = "getRecordingList")]
        public JsArray<JsString> GetRecordingList() { return default(JsArray<JsString>); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>localUrl</returns>
        [JsMethod(Name = "getRecordingURL")]
        public JsString GetRecordingUrl(JsString filename) { return default(JsString); }
    }
    #endregion

    #region Player
    public delegate void XdkAudioInfoCallback(XdkAudioInfo audioInfo);

    /// <summary>
    /// Access information about the media currently playing.
    /// </summary>
    /// <remarks>
    /// The playingtrack object provides a series of properties that contain information about media currently played by the application. Please note that this object currently only works with stations hosted by appMobi and played with the StartStation (deprecated) or <see cref="XdkPlayer.StartShoutcast"/> commands. Not all properties may have values for all streams. An event is fired when the currently playing track changes.
    /// </remarks>
    /// <example>
    /// <code lang="C#">
    /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
    /// public static void PlayerTrackChange()
    /// {
    ///     Xdk.PlayerTrackChange += Xdk_PlayerTrackChange;
    /// }
    /// static void Xdk_PlayerTrackChange(PlayerEvent evt)
    /// {
    ///     //The track has just changed
    ///     HtmlContext.Alert("The new track's artist: " + Xdk.playingtrack.artist);
    ///     HtmlContext.Alert("The new track's title: " + Xdk.playingtrack.title);
    ///     HtmlContext.Alert("The new track's album name: " + Xdk.playingtrack.album);
    ///     HtmlContext.Alert("The new track's image: " + Xdk.playingtrack.imageUrl);
    /// }
    /// </code>
    /// </example>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkPlayingTrack
    {
        /// <summary>
        /// This property returns an album the currently playing track might be found on, if that information is available.
        /// </summary>
        public JsString album { get; set; }
        /// <summary>
        /// This property returns the artist of the currently playing track, if there is an artist available.
        /// </summary>
        public JsString artist { get; set; }
        /// <summary>
        /// This property returns a URL of the album cover image for the currently playing track. In general the image returned is 160x160 pixels. If no image is available, the imageurl property will be an empty.
        /// </summary>
        [JsProperty(Name = "imageurl", NativeField = true)]
        public JsString imageUrl { get; set; }
        /// <summary>
        /// This property returns the title of the currently playing track.
        /// </summary>
        public JsString title { get; set; }
    }

    /// <summary>
    /// Play audio and video.
    /// </summary>
    /// <remarks>
    /// The player object is used to play media natively in applications. It is a useful alternative to the HTML5 "video" and "audio" tags. It also allows applications to play streaming and shoutcast stations with a skinnable native UI.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnPlayerAudioBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerAudioCurrenttimeSet"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerAudioError"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerAudioStart"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerAudioStop"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerHide"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShow"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerPodcastBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerPodcastError"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerPodcastStart"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerPodcastPlay"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerPodcastPause"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerPodcastStop"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShoutcastBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShoutcastError"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShoutcastPlay"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShoutcastPause"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShoutcastStart"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerShoutcastStop"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerSoundError"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerStationBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerStationError"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerStationPause"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerStationPlay"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerStationStart"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerStationStop"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnPlayerTrackChange"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Player")]
    public partial class XdkPlayer
    {
        public XdkAudioInfo audioInfo { get; set; }
        public JsObject<JsArray<XdkHtmlAudioPlayer>> sounds { get; set; }

        /// <summary>
        /// This method will show the native Intel XDK player UI.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShow"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Show();
        /// </code>
        /// </example>
        [JsMethod(Name = "show")]
        public void Show() { }
        /// <summary>
        /// This method will hide the native Intel XDK player UI.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerHide"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Hide();
        /// </code>
        /// </example>
        [JsMethod(Name = "hide")]
        public void Hide() { }
        /// <summary>
        /// This method will load a specified podcast (either audio or video) from the web into a native player with UI.
        /// </summary>
        /// <remarks>
        /// This method will load a specified podcast from the web into a native player with UI. Although it can't play files directly from the local bundle, you can use the Intel XDK local webserver and reference the files using http://localhost:58888. Valid video formats depend on the device that Intel XDK is running on. See the table below for more information on what formats are available for particular platforms.
        /// <list type="table">
        /// <listheader>
        /// <term>Platform</term>
        /// <description>Type/Supported Formats</description>
        /// </listheader>
        /// <item>
        /// <term>iOS</term>
        /// <description>Video: H.264, MPEG-4 in .mp4, .m4v, .mov</description>
        /// </item>
        /// <item>
        /// <term>iOS</term>
        /// <description>Audio: AAC, MP3, M4a</description>
        /// </item>
        /// <item>
        /// <term>Android</term>
        /// <description>Video: WMV, MPEG4, H.263, H.264</description>
        /// </item>
        /// <item>
        /// <term>Android</term>
        /// <description>Audio: MP3, OGG</description>
        /// </item>
        /// <item>
        /// <term>Windows</term>
        /// <description>Video: WMV</description>
        /// </item>
        /// <item>
        /// <term>Windows</term>
        /// <description>Audio: MP3</description>
        /// </item>
        /// </list>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerPodcastBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerPodcastError"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerPodcastStart"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerPodcastStop"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerPodcastPlay"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerPodcastPause"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //load the video podcast
        /// Xdk.player.PlayPodcast("http://blip.tv/file/get/Unboomed-DanceAcrossAmerica550.mov");
        /// //load a video from the root of the local bundle
        /// Xdk.player.PlayPodcast("http://localhost:58888/lovely.mov");
        /// </code>
        /// </example>
        /// <param name="podcastUrl">The url of the audio or video podcast to play on the device.</param>
        [JsMethod(Name = "playPodcast")]
        public void PlayPodcast(JsString podcastUrl) { }
        /// <summary>
        /// DEPRECATED This method will load a station hosted by appMobi and identified by a unique NetStationID code.
        /// </summary>
        /// <remarks>
        /// Optionally, a boolean parameter specifying whether the station should attempt to resume from a previous play point may be set as well as a boolean value specifying whether to show the native player or not once the station is loaded are available. ResumeMode may not be available on all platforms.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationError"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationPause"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationPlay"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationStart"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationStop"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerTrackChange"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.StartStation("223020", true, true);  //KOIT San Francisco
        /// </code>
        /// </example>
        /// <param name="netStationId">The unique NetStationID code for this station on an appMobi media server.</param>
        /// <param name="resumeMode">A Boolean specifying whether the station should attempt to resume from a previous play point when restarted.</param>
        /// <param name="showPlayer">A Boolean value specifying whether to show the native player or not once the station is loaded are available.</param>
        [JsMethod(Name = "startStation")]
        private void StartStation(JsString netStationId, bool resumeMode, bool showPlayer) { }
        /// <summary>
        /// This method will play a sound with no UI or events and is not controllable.
        /// </summary>
        /// <remarks>
        /// This method will play a sound with no UI or events and is not controllable. This is intended as a simple way to play sound effects in your application. This requires the sound file to be included within the application file folder. Valid audio formats depend on the device that Intel XDK is running on.
        /// <para>IMPORTANT NOTE: If a polyphonic count was provided using <see cref="XdkPlayer.LoadSound">player.loadSound</see>, any requests made to play a sound that exceed the count are ignored. For sounds not preloaded using <see cref="XdkPlayer.LoadSound">player.loadSound</see>, if PlaySound is called while the sound is already playing, the request will be ignored.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerSoundError"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // play the sound
        /// Xdk.player.PlaySound("sounds/boing.wav");
        /// </code>
        /// </example>
        /// <param name="relativeFileUrl">The relative URL of the sound file to play relative to the root folder of the application.</param>
        [JsMethod(Name = "playSound")]
        public void PlaySound(JsString relativeFileUrl) { }
        /// <summary>
        /// Use this method to preload a sound file to prevent lag the first time it is played.
        /// </summary>
        /// <remarks>
        /// This method is used to preload a sound file in order to play the sound without delay the first time it is needed. This method requires the sound file to be included within the application file folder. Valid audio formats depend on the device that Intel XDK is running on. The <see cref="Xdk.OnPlayerSoundError"/> event is fired if the sound file is invalid or missing.
        /// <para>Developers should endeavor to execute this method when the application is not busy with other processes in order to free up resources on the device. For example, load sounds that are initially needed at startup once the <see cref="Xdk.OnDeviceReady"/> event fires. Then while switching between levels of a game, unload sounds no longer needed to free up resources, or load new sounds.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerSoundError"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void LoadSound()
        /// {
        ///     Xdk.PlayerSoundError += Xdk_PlayerSoundError;
        ///     Xdk.player.LoadSound("sounds/boing.wav", 5);
        ///     Xdk.player.LoadSound("sounds/jump.wav");
        /// }
        /// static void Xdk_PlayerSoundError(PlayerEvent evt)
        /// {
        ///     HtmlContext.Alert("Sound file could not be loaded");
        /// }
        /// </code>
        /// </example>
        /// <param name="relativeFileUrl">The relative URL of the sound file to play relative to the root folder of the application.</param>
        /// <param name="count">The polyphonic count of a sound - that is, how many times that sound can be played concurrently. This parameter is optional. Sounds loaded without a count may not be played on top of each other.</param>
        [JsMethod(Name = "loadSound")]
        public void LoadSound(JsString relativeFileUrl, long count = 0) { }
        /// <summary>
        /// Use this method to unload a sound file.
        /// </summary>
        /// <remarks>
        /// Developers should endeavor to execute this method when the application is not busy with other processes in order to free up resources on the device. For example, load sounds that are initially needed at startup once the <see cref="Xdk.OnDeviceReady"/> event fires. Then while switching between levels of a game, unload sounds no longer needed to free up resources, or load new sounds.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.UnloadSound("sounds/boing.wav");
        /// </code>
        /// </example>
        /// <param name="relativeFileUrl">The relative URL of the sound file to play relative to the root folder of the application.</param>
        [JsMethod(Name = "unloadSound")]
        public void UnloadSound(JsString relativeFileUrl) { }
        /// <summary>
        /// Use this method to unload all sound files that have been loaded via the <see cref="XdkPlayer.LoadSound">player.LoadSound</see> or <see cref="XdkPlayer.LoadSound">player.PlaySound</see> methods.
        /// </summary>
        /// <remarks>
        /// Developers should endeavor to execute this method when the application is not busy with other processes in order to free up resources on the device. For example, you may want to unload all current sounds at a game level change.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.UnloadAllSounds();
        /// </code>
        /// </example>
        [JsMethod(Name = "unloadAllSounds")]
        public void UnloadAllSounds() { }
        /// <summary>
        /// This method will load and start playing a specified audio file without a UI of any sort.
        /// </summary>
        /// <remarks>
        /// It is useful for adding a response to an application event or for playing a background audio file while the user performs other actions. This method requires the audio file to be included in the application zip file, or loaded into the _mediacache directory using the <see cref="XdkCache.AddToMediaCache">Xdk.cache.AddToMediaCache</see> command first.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioError"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioStart"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioStop"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // start playing an audio file without looping
        /// Xdk.player.StartAudio("sounds/cowbell.wav",false);
        /// </code>
        /// </example>
        /// <param name="relativeFileUrl">The url of the file to play. The file must be on the mobile device.</param>
        /// <param name="loop">Boolean to control whether the audio should loop or not. This parameter is optional with a default value of false.</param>
        [JsMethod(Name = "startAudio")]
        public void StartAudio(JsString relativeFileUrl, bool loop = false) { }
        /// <summary>
        /// This method will pause or play the audio started by a call to <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see>.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // toggle playback of the audio 
        /// Xdk.player.ToggleAudio();
        /// </code>
        /// </example>
        [JsMethod(Name = "toggleAudio")]
        public void ToggleAudio() { }
        /// <summary>
        /// This method will stop the audio started by a call to <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see>.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioError"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioStop"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // stop playback of the audio 
        /// Xdk.player.StopAudio();
        /// </code>
        /// </example>
        [JsMethod(Name = "stopAudio")]
        public void StopAudio() { }
        /// <summary>
        /// This method causes the player to seek to a time in the file specified in seconds.
        /// </summary>
        /// <remarks>
        /// If audio is already playing, this method causes the player to seek to the specified time. If audio is not currently playing, when <see cref="XdkPlayer.StartAudio">player.StartAudio</see> is called the player will start the audio at the specified time within the file. Once the time has been set, it remains set for all audio until cleared. To reset audio to start at the beginning of the file, the user should set the time to 0 to produce the desired behavior. 
        /// <para>NOTE: SetAudioCurrentTime is an asynchronous operation. When called, the <see cref="WatchAudioCurrentTime">WatchAudioCurrentTime</see> callback and the player.audioInfo variable are briefly invalid until the <see cref="Xdk.OnPlayerAudioCurrenttimeSet"/> event is fired.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerAudioCurrenttimeSet"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Set Audio to start at 30 seconds into the file 
        /// Xdk.player.SetAudioCurrentTime(30);
        /// Xdk.player.StartAudio("sounds/file1.mp3", false);
        /// </code>
        /// </example>
        /// <param name="time">A floating point value that specifies the time in seconds where the player should seek to.</param>
        [JsMethod(Name = "setAudioCurrentTime")]
        public void SetAudioCurrentTime(float time) { }
        /// <summary>
        /// Call the callback function when the currenttime value is readable. 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="successCallback"></param>
        /// <returns>time</returns>
        [JsMethod(Name = "getAudioCurrentTime")]
        public float GetAudioCurrentTime(XdkAudioInfoCallback successCallback) { return default(JsNumber); }
        /// <summary>
        /// This method is used to start a watch on the current audio track.
        /// </summary>
        /// <remarks>
        /// Once this method is called, it will update the <see cref="XdkAudioInfo">Xdk.player.audioInfo</see> variable with information about the current audio track at the specified time interval (in milliseconds) until the watch is cleared. This method returns an id that is required in order to clear the watch using the <see cref="XdkPlayer.ClearAudioCurrentTimeWatch">player.ClearAudioCurrentTimeWatch</see> method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void WatchAudioCurrentTime()
        /// {
        ///     // start a watch on the current audio track 
        ///     var watchID = Xdk.player.WatchAudioCurrentTime(OnSuccess, 3000);
        /// }
        /// public static void OnSuccess(AudioInfo audioInfo)
        /// {
        ///     HtmlContext.Alert("Audio Current Time: " + Xdk.player.audioInfo.currentTime + "\n" +
        ///         "Audio Duration: " + Xdk.player.audioInfo.duration + '\n');
        /// }
        /// </code>
        /// </example>
        /// <param name="successCallback">A function that will be called at the specified time interval.</param>
        /// <param name="frequency">The time interval in milliseconds for which to update the Xdk.player.audioInfo variable with information.</param>
        /// <returns>A unique identifier returned from this method that can be used to clear the watch for audio information.</returns>
        [JsMethod(Name = "watchAudioCurrentTime")]
        public long WatchAudioCurrentTime(XdkAudioInfoCallback successCallback, long frequency) { return (default(long)); }
        /// <summary>
        /// This method stops the process started by <see cref="XdkPlayer.WatchAudioCurrentTime">player.WatchAudioCurrentTime</see> when it is passed the appropriate watch ID.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var watchId = Xdk.player.WatchAudioCurrentTime(OnSuccess, 3000);
        /// // ...  some time later ...
        /// Xdk.player.ClearAudioCurrentTimeWatch(watchId);
        /// </code>
        /// </example>
        /// <param name="watchId">The ID returned by <see cref="XdkPlayer.WatchAudioCurrentTime">player.WatchAudioCurrentTime</see>.</param>
        [JsMethod(Name = "clearAudioCurrentTimeWatch")]
        public void ClearAudioCurrentTimeWatch(long watchId) { }
        /// <summary>
        /// This method will restart playback of a paused player.
        /// </summary>
        /// <remarks>
        /// This method will do nothing when called before the player is loaded. This method is used for stations started with Xdk.player.StartStation or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastPlay"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerStationPlay"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Play();
        /// </code>
        /// </example>
        [JsMethod(Name = "play")]
        public void Play() { }
        /// <summary>
        /// This method will pause the playback of a loaded player.
        /// </summary>
        /// <remarks>
        /// This method will do nothing when called before the player is loaded. This method is only used for stations started with Xdk.player.StartStation or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Pause();
        /// </code>
        /// </example>
        [JsMethod(Name = "pause")]
        public void Pause() { }
        /// <summary>
        /// This method will stop playback of a loaded player.
        /// </summary>
        /// <remarks>
        /// This method will do nothing when called before the player is loaded. This method is only used for stations started with Xdk.player.StartStation or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Stop();
        /// </code>
        /// </example>
        [JsMethod(Name = "stop")]
        public void Stop() { }
        /// <summary>
        /// This method controls the volume of streaming audio.
        /// </summary>
        /// <remarks>
        /// It does not change the volume of the device or of any other sounds or audio played. It only allows for adjustment of the currently playing stream. This method is only used for stations started with Xdk.player.StartStation or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Volume(90);  //crank up the volume to 90%
        /// </code>
        /// </example>
        /// <param name="percentage">A number from 0 to 100 indicating how to set the volume as a percentage of the maximum volume.</param>
        [JsMethod(Name = "volume")]
        public void Volume(JsNumber percentage) { }
        /// <summary>
        /// This method will rewind the play head.
        /// </summary>
        /// <remarks>
        /// This method will rewind the play head to the beginning of the track or 30 seconds from its current position, whichever is less. This method will do nothing when called before the player is loaded. This method is only used for stations started with Xdk.player.StartStation or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Rewind();  //go back 30 seconds
        /// </code>
        /// </example>
        [JsMethod(Name = "rewind")]
        public void Rewind() { }
        /// <summary>
        /// This method will advance the play head.
        /// </summary>
        /// <remarks>
        /// This method will advance the play head to the end of the track or 30 seconds from its current position, whichever is less. This method will do nothing when called before the player is loaded. This method is only used for stations started with Xdk.player.StartStation or <see cref="XdkPlayer.StartShoutcast">Xdk.player.StartShoutcast</see>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.Ffwd();  //search forward 30 seconds
        /// </code>
        /// </example>
        [JsMethod(Name = "ffwd")]
        public void Ffwd() { }
        /// <summary>
        /// This method allows developers to change the colors of the progress bar of the Intel XDK native player.
        /// </summary>
        /// <remarks>
        /// Each color can be six or seven characters which hold the hex value of a color. Once this command is called, these settings will persist for the length of the session.
        /// <list type="table">
        /// <listheader>
        /// <term>Color</term>
        /// <description>Defaults</description>
        /// </listheader>
        /// <item>
        /// <term>backColor</term>
        /// <description>black</description>
        /// </item>
        /// <item>
        /// <term>fillColor</term>
        /// <description>yellow</description>
        /// </item>
        /// <item>
        /// <term>doneColor</term>
        /// <description>green</description>
        /// </item>
        /// <item>
        /// <term>playColor</term>
        /// <description>red</description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.SetColors("#000000", "#999999", "#999999", "#ffffff");
        /// </code>
        /// </example>
        /// <param name="backColor">The background of the progress bar</param>
        /// <param name="fillColor">The downloading progress of the progress bar</param>
        /// <param name="doneColor">The color the progress bar will turn once all downloading is complete</param>
        /// <param name="playColor">The color the play head indicating where in the progress bar is currently playing</param>
        [JsMethod(Name = "setColors")]
        public void SetColors(JsString backColor, JsString fillColor, JsString doneColor, JsString playColor) { }
        /// <summary>
        /// On devices with a larger screen resolution such as the iPad, this command allows the developer to set the position of the native player on the screen.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.player.SetPosition(224, 188, 322, 228);
        /// </code>
        /// </example>
        /// <param name="portraitX">The position of the player from the left edge of the device in pixels while in portrait orientation.</param>
        /// <param name="portraitY">The position of the player from the top edge of the device in pixels while in portrait orientation.</param>
        /// <param name="landscapeX">The position of the player from the left edge of the device in pixels while in landscape orientation.</param>
        /// <param name="landscapeY">The position of the player from the top edge of the device in pixels while in landscape orientation.</param>
        [JsMethod(Name = "setPosition")]
        public void SetPosition(long portraitX, long portraitY, long landscapeX, long landscapeY) { }
        /// <summary>
        /// This method will load and play a station hosted by Shoutcast.
        /// </summary>
        /// <remarks>
        /// This method will load and play a station hosted by Shoutcast. The raw URL of the Shoutcast stream is the first parameter of the load command. Be sure to include the server and port number in your URL request. A boolean parameter specifying whether to show the native player or not once the station is loaded is available. Particular devices are only capable of handling particular types of streams.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastError"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastPlay"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastPause"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastStart"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerShoutcastStop"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnPlayerTrackChange"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // EYE97 - Commercial Free Non Stop Hits of the 70's, 80's, 90's and Today
        /// Xdk.player.StartShoutcast("http://209.9.238.10:8008/", true);
        /// </code>
        /// </example>
        /// <param name="stationUrl">The url of the shoutcast stream to load and play.</param>
        /// <param name="showPlayer">A boolean parameter specifying whether to show the native player or not once the station is loaded is available.</param>
        [JsMethod(Name = "startShoutcast")]
        public void StartShoutcast(JsString stationUrl, bool showPlayer) { }
    }
    #endregion

    #region Stats
    /// <summary>
    /// 
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Stats")]
    public partial class XdkStats
    {
    }
    #endregion

    #region Analytics
    /// <summary>
    /// Track how your application is used and accessed by setting custom events.
    /// </summary>
    /// <remarks>
    /// The analytics object provides access to statMobi Analytics.
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Analytics")]
    public partial class XdkAnalytics
    {
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <remarks>
        /// This function will log application events to statMobi Analytics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="page">The page parameter is a required JsString that identifies the logged statMobi Analytics event. Although any format could be used, Intel XDK suggests the following format for the JsString to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page) { }
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <remarks>
        /// This function will log application events to statMobi Analytics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="page">The page parameter is a required JsString that identifies the logged statMobi Analytics event. Although any format could be used, Intel XDK suggests the following format for the JsString to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        /// <param name="query">The query parameter is optional. It is used to hold a series of key/value pairs related to the tracked statMobi event. It defaults to the JsString "-".</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query) { }
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <remarks>
        /// This function will log application events to statMobi Analytics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="page">The page parameter is a required JsString that identifies the logged statMobi Analytics event. Although any format could be used, Intel XDK suggests the following format for the JsString to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        /// <param name="query">The query parameter is optional. It is used to hold a series of key/value pairs related to the tracked statMobi event. It defaults to the JsString "-".</param>
        /// <param name="status">The status parameter is optional. It defaults to the value 200.</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, JsString status) { }
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <remarks>
        /// This function will log application events to statMobi Analytics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="page">The page parameter is a required JsString that identifies the logged statMobi Analytics event. Although any format could be used, Intel XDK suggests the following format for the JsString to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        /// <param name="query">The query parameter is optional. It is used to hold a series of key/value pairs related to the tracked statMobi event. It defaults to the JsString "-".</param>
        /// <param name="status">The status parameter is optional. It defaults to the value 200.</param>
        /// <param name="method">The method parameter is optional. It defaults to the JsString "GET".</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, JsString status, GetPost method) { }
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <remarks>
        /// This function will log application events to statMobi Analytics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="page">The page parameter is a required JsString that identifies the logged statMobi Analytics event. Although any format could be used, Intel XDK suggests the following format for the JsString to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        /// <param name="query">The query parameter is optional. It is used to hold a series of key/value pairs related to the tracked statMobi event. It defaults to the JsString "-".</param>
        /// <param name="status">The status parameter is optional. It defaults to the value 200.</param>
        /// <param name="method">The method parameter is optional. It defaults to the JsString "GET".</param>
        /// <param name="bytes">The bytes parameter is optional. It defaults to the value 0.</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, JsString status, GetPost method, long bytes) { }
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <remarks>
        /// This function will log application events to statMobi Analytics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// static void AddAnalyticsDataPoint(JsString eventId, JsString queryString)
        /// {
        ///     try
        ///     {
        ///         if (queryString == null) { queryString = ""; }
        ///         Xdk.analytics.LogPageEvent("/application/" + eventId + ".event", queryString, "", GetPost.Get, 0, "index.html");
        ///     }
        ///     catch (JsError e) { }
        /// }
        /// </code>
        /// </example>
        /// <param name="page">The page parameter is a required JsString that identifies the logged statMobi Analytics event. Although any format could be used, Intel XDK suggests the following format for the JsString to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        /// <param name="query">The query parameter is optional. It is used to hold a series of key/value pairs related to the tracked statMobi event. It defaults to the JsString "-".</param>
        /// <param name="status">The status parameter is optional. It defaults to the value 200.</param>
        /// <param name="method">The method parameter is optional. It defaults to the JsString "GET".</param>
        /// <param name="bytes">The bytes parameter is optional. It defaults to the value 0.</param>
        /// <param name="referrer">The referrer parameter is optional. It is included in case your application is built in the form of a web application that spans several HTML documents and you would like to track each discreet HTML page. It defaults to an empty JsString.</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, JsString status, GetPost method, long bytes, JsString referrer) { }

    }
    #endregion

    #region File
    public delegate void XdkUploadProgressCallback(long bytesSent, long totalBytesToBeUploaded);

    /// <summary>
    /// Transfers files over the Internet.
    /// </summary>
    /// <remarks>
    /// The file object gives applications the ability to upload files to a remote server.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnFileUpload"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFileUploadCancel"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFileUploadBusy"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.File")]
    public partial class XdkFile
    {
        /// <summary>
        /// This method uploads files to a remote server over the Internet.
        /// </summary>
        /// <remarks>
        /// Use this command to upload a file to a server on the Internet.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFileUpload"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFileUploadBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void UploadPicture(JsString pictureFilename)
        /// {
        ///     //Get the image to upload
        ///     var pictureUrl = Xdk.camera.GetPictureUrl(pictureFilename);
        ///     long currentProgress = 0;
        ///     Xdk.file.UploadToServer(pictureUrl, "http://www.yourserver.com/uploadImage.php", "", "image/jpeg", "UpdateUploadProgress");
        ///     var UpdateUploadProgress = new UploadProgressCallback(delegate(long bytesSent, long totalBytes)
        ///    {
        ///        if (totalBytes > 0)
        ///            currentProgress = (bytesSent / totalBytes) * 100;
        ///        HtmlElement.GetById("progress").innerHTML = currentProgress + "%";
        ///    }
        ///         );
        ///     Xdk.FileUpload += UploadCompleted;
        ///     Xdk.FileUploadBusy += UploadBusy;
        ///     Xdk.FileUploadCancel += UploadCancelled;
        /// }
        /// static void UploadCompleted(FileEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.Alert("File " + evt.localUrl + " was uploaded");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("Error uploading file " + evt.message);
        ///     }
        /// }
        /// static void UploadBusy(FileEvent evt)
        /// {
        ///     HtmlContext.Alert("Sorry, a file is already being uploaded");
        /// }
        /// static void UploadCancelled(FileEvent evt)
        /// {
        ///     HtmlContext.Alert("File upload was cancelled " + evt.localUrl);
        /// }
        /// </code>
        /// </example>
        /// <param name="localURL">The URL of the file on the local device server. This URL will always start with http://localhost:58888/.</param>
        /// <param name="uploadURL">The remote server address that the file will be uploaded to</param>
        /// <param name="folderName">The name of the folder on the remote server to hold the transferred file</param>
        /// <param name="mimeType">The mime type of the file to be uploaded</param>
        /// <param name="strUploadProgressCallback">String with the name of the UploadProgressCallback function (the function type must be UploadProgressCallback). This function is called repetitively as the file uploads. The function include two parameters. The first will be the number of bytes sent so far and the second will be the total bytes to be uploaded.</param>
        [JsMethod(Name = "uploadToServer")]
        public void UploadToServer(JsString localURL, JsString uploadURL, JsString folderName, JsString mimeType, JsString strUploadProgressCallback) { }

        /// <summary>
        /// This method cancels a previous <see cref="XdkFile.UploadToServer">Xdk.file.UploadToServer</see> command.
        /// </summary>
        /// <remarks>
        /// This command may be used to cancel a <see cref="XdkFile.UploadToServer">Xdk.file.UploadToServer</see> command.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFileUploadCancel"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void UploadPicture(JsString pictureFilename)
        /// {
        ///     //Get the image to upload
        ///     var pictureUrl = Xdk.camera.GetPictureUrl(pictureFilename);
        ///     long currentProgress = 0;
        ///     Xdk.file.UploadToServer(pictureUrl, "http://www.yourserver.com/uploadImage.php", "", "image/jpeg", "UpdateUploadProgress");
        ///     var UpdateUploadProgress = new UploadProgressCallback(delegate(long bytesSent, long totalBytes)
        ///    {
        ///        if (totalBytes > 0)
        ///            currentProgress = (bytesSent / totalBytes) * 100;
        ///        HtmlElement.GetById("progress").innerHTML = currentProgress + "%";
        ///    }
        ///         );
        ///     var CancelUpload = new JsAction(delegate()
        ///    {
        ///        Xdk.file.CancelUpload();
        ///    }
        ///         );
        ///     Xdk.FileUpload += UploadCompleted;
        ///     Xdk.FileUploadBusy += UploadBusy;
        ///     Xdk.FileUploadCancel += UploadCancelled;
        /// }
        /// static void UploadCompleted(FileEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.Alert("File " + evt.localUrl + " was uploaded");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("Error uploading file " + evt.message);
        ///     }
        /// }
        /// static void UploadBusy(FileEvent evt)
        /// {
        ///     HtmlContext.Alert("Sorry, a file is already being uploaded");
        /// }
        /// static void UploadCancelled(FileEvent evt)
        /// {
        ///     HtmlContext.Alert("File upload was cancelled " + evt.localUrl);
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "cancelUpload")]
        public void CancelUpload() { }
    }
    #endregion

    #region Camera
    /// <summary>
    /// Picture types
    /// </summary>
    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkPictureType
    {
        [JsField(Name = "jpg")]
        Jpg = 1,
        [JsField(Name = "png")]
        Png = 2
    }

    /// <summary>
    /// Use the device's camera and access your device's camera library.
    /// </summary>
    /// <remarks>
    /// The camera object consists of several methods to control the capturing and maintenance of picture files. The camera object contains a list of photos known as the "picture list". The picture list is where new images are placed once they are created. There are several methods in the camera object that allow the application to control the files in this list. The application may add to the picture list by capturing a photo from the device's native camera using <see cref="XdkCamera.TakePicture">Xdk.camera.TakePicture</see>, a picture may be added to the list by referencing a file on the device using <see cref="XdkCamera.ImportPicture">Xdk.camera.ImportPicture</see>, all the photos on the list may be listed in an array using <see cref="XdkCamera.GetPictureList">Xdk.camera.GetPictureList</see>, photos may be removed from the list singly using <see cref="XdkCamera.DeletePicture">Xdk.camera.DeletePicture</see>, or the picture list may be wiped clear using <see cref="XdkCamera.ClearPictures">Xdk.camera.ClearPictures</see>. Finally, files in the picture list may be referenced for use in an application using the <see cref="XdkCamera.GetPictureUrl">Xdk.camera.GetPictureUrl</see> method.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnCameraPictureAdd"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCameraPictureBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCameraPictureCancel"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCameraPictureClear"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCameraPictureRemove"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCameraTakePicture"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCameraTakeFrontPicture"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Camera")]
    public partial class XdkCamera
    {
        /// <summary>
        /// Use this command to take a picture with your device's camera.
        /// </summary>
        /// <remarks>
        /// When this command is called, the native camera application for the device will open and allow the user to take a picture. Once the photo has been taken, the camera applicaiton will return control to the application. At that point, any events associated with this command will be fired.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureAdd"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureCancel"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraTakePicture"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document", "undefined" or "Alert"
        /// public static void InitCameraEventsListeners()
        /// {
        ///     Xdk.CameraTakePicture += OnSuccess;
        /// //    Xdk.CameraPictureAdd += OnSuccess;
        ///     Xdk.CameraPictureBusy += OnSuccess;
        ///     Xdk.CameraPictureCancel += OnSuccess;
        /// }
        /// public static void CapturePhoto()
        /// {
        ///     Xdk.camera.TakePicture(50, false, PictureType.Jpg);
        /// }
        /// static void OnSuccess(CameraPictureEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         // create image 
        ///         var image = new HtmlImageElement();
        ///         image.src = Xdk.camera.GetPictureUrl(evt.filename);
        ///         image.id = evt.filename;
        ///         HtmlContext.document.body.AppendChild(image);
        ///     }
        ///     else
        ///     {
        ///         if (evt.message != HtmlContext.undefined)
        ///         {
        ///             HtmlContext.Alert(evt.message);
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert("error capturing picture");
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="quality">The quality parameter reflects the percentage of image compression done to the image captured by the camera. This parameter must be a value between 1 and 100. The default value is 70.</param>
        /// <param name="saveToLib">This parameter controls whether the photo is saved directly to the device's image library or not. The default value is true.</param>
        /// <param name="picType">The parameter controls the file type the photo can be saved as. The valid JsString values are "jpg" and "png" respectively. The default value is "jpg".</param>
        /// <param name="isFront">Picture taken with the front camera or with the back camera</param>
        [JsMethod(Name = "takePicture")]
        public void TakePicture(uint quality = 70, bool saveToLib = true, XdkPictureType picType = XdkPictureType.Jpg, bool isFront = false) { }
        /// <summary>
        /// Use this command to take a picture with your device's camera.
        /// </summary>
        /// <remarks>
        /// When this command is called, the native camera application for the device will open and allow the user to take a picture. Once the photo has been taken, the camera applicaiton will return control to the application. At that point, any events associated with this command will be fired.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureAdd"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureCancel"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraTakeFrontPicture"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document", "undefined" or "Alert"
        /// public static void InitCameraEventsListeners()
        /// {
        ///     Xdk.CameraTakeFrontPicture += OnSuccess;
        /// //    Xdk.CameraPictureAdd += OnSuccess;
        ///     Xdk.CameraPictureBusy += OnSuccess;
        ///     Xdk.CameraPictureCancel += OnSuccess;
        /// }
        /// public static void CapturePhoto()
        /// {
        ///     Xdk.camera.TakeFrontPicture(50, false, PictureType.Jpg);
        /// }
        /// static void OnSuccess(CameraPictureEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         // create image 
        ///         var image = new HtmlImageElement();
        ///         image.src = Xdk.camera.GetPictureUrl(evt.filename);
        ///         image.id = evt.filename;
        ///         HtmlContext.document.body.AppendChild(image);
        ///     }
        ///     else
        ///     {
        ///         if (evt.message != HtmlContext.undefined)
        ///         {
        ///             HtmlContext.Alert(evt.message);
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert("error capturing picture");
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="quality">The quality parameter reflects the percentage of image compression done to the image captured by the camera. This parameter must be a value between 1 and 100. The default value is 70.</param>
        /// <param name="saveToLib">This parameter controls whether the photo is saved directly to the device's image library or not. The default value is true.</param>
        /// <param name="picType">The parameter controls the file type the photo can be saved as. The valid JsString values are "jpg" and "png" respectively. The default value is "jpg".</param>
        [JsMethod(Name = "takeFrontPicture")]
        public void TakeFrontPicture(uint quality = 70, bool saveToLib = true, XdkPictureType picType = XdkPictureType.Jpg) { }
        /// <summary>
        /// This method will move a photo from your application's native camera file service (e.g. the camera roll) to the picture list.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureAdd"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureCancel"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document", "undefined" or "Alert"
        /// public static void InitCameraEventsListeners()
        /// {
        ///     Xdk.CameraPictureAdd += OnSuccess;
        ///     Xdk.CameraPictureBusy += OnSuccess;
        ///     Xdk.CameraPictureCancel += OnSuccess;
        /// }
        /// public static void CapturePhoto()
        /// {
        ///     Xdk.camera.ImportPicture();
        /// }
        /// static void OnSuccess(CameraPictureEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         // create image 
        ///         var image = new HtmlImageElement();
        ///         image.src = Xdk.camera.GetPictureUrl(evt.filename);
        ///         image.id = evt.filename;
        ///         HtmlContext.document.body.AppendChild(image);
        ///     }
        ///     else
        ///     {
        ///         if (evt.message != HtmlContext.undefined)
        ///         {
        ///             HtmlContext.Alert(evt.message);
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert("error capturing picture");
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "importPicture")]
        public void ImportPicture() { }
        /// <summary>
        /// Use this command to remove a photo from your application's picture list.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureRemove"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document" or "Alert"
        /// public static void RemovePicture()
        /// {
        ///     Xdk.CameraPictureRemove += OnRemove;
        ///     var arrPictureList = Xdk.camera.GetPictureList();
        ///     if (arrPictureList.length > 1)
        ///     {
        ///         Xdk.camera.DeletePicture(arrPictureList[0]);
        ///     }
        /// }
        /// static void OnRemove(CameraPictureEvent evt)
        /// {
        ///     var arrPictureList = Xdk.camera.GetPictureList();
        ///     for (var x = 0; x &lt; arrPictureList.length; x++)
        ///     {
        ///         // create image 
        ///         var newImage = new HtmlImageElement();
        ///         newImage.src = Xdk.camera.GetPictureUrl(arrPictureList[x]);
        ///         newImage.style.width = "100px";
        ///         newImage.style.height = "100px";
        ///         newImage.id = "img_" + arrPictureList[x];
        ///         HtmlContext.document.body.AppendChild(newImage);
        ///     }
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.Alert(evt.filename + " has been removed from the application's picture list");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="pictureFilename">The filename of the image in the picture list. This filename can be obtained from camera.getPictureList</param>
        [JsMethod(Name = "deletePicture")]
        public void DeletePicture(JsString pictureFilename) { }
        /// <summary>
        /// This command will remove all photos from your application's picture list.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCameraPictureClear"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document" or "Alert"
        /// public static void ClearPictures()
        /// {
        ///     Xdk.CameraPicturesListClear += OnClear;
        ///     HtmlContext.Alert(Xdk.camera.GetPictureList().length + " items in the picture list");
        ///     Xdk.camera.ClearPictures();
        /// }
        /// static void OnClear(CameraPictureEvent evt)
        /// {
        ///     var arrPictureList = Xdk.camera.GetPictureList();
        ///     for (var x = 0; x &lt; arrPictureList.length; x++)
        ///     {
        ///         // create image 
        ///         var newImage = new HtmlImageElement();
        ///         newImage.src = Xdk.camera.GetPictureUrl(arrPictureList[x]);
        ///         newImage.style.width = "100px";
        ///         newImage.style.height = "100px";
        ///         newImage.id = "img_" + arrPictureList[x];
        ///         HtmlContext.document.body.AppendChild(newImage);
        ///     }
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.Alert("The picture list has been cleared");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "clearPictures")]
        public void ClearPictures() { }
        /// <summary>
        /// This command will return a list of all pictures stored in the application's picture list.
        /// </summary>
        /// <remarks>
        /// The pictures in the picture list will persist across sessions. Get an array listing the filenames of all the photos using this method. Use the <see cref="GetPictureUrl">GetPictureUrl</see> method to then reference the URL for the files in the picture list in your application.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document"
        /// var arrPictureList = Xdk.camera.GetPictureList();
        /// for (var x = 0; x &lt; arrPictureList.length; x++)
        /// {
        ///     // create image 
        ///     var newImage = new HtmlImageElement();
        ///     newImage.src = Xdk.camera.GetPictureUrl(arrPictureList[x]);
        ///     newImage.style.width = "100px";
        ///     newImage.style.height = "100px";
        ///     newImage.id = "img_" + arrPictureList[x];
        ///     HtmlContext.document.body.AppendChild(newImage);
        /// }
        /// </code>
        /// </example>
        /// <returns></returns>
        [JsMethod(Name = "getPictureList")]
        public JsArray<JsString> GetPictureList() { return default(JsArray<JsString>); }
        /// <summary>
        /// This command will return the URL of the picture on the local webserver
        /// </summary>
        /// <remarks>
        /// Pictures that are in the picture list may be referenced on the application's local webserver. To get the URL of those pictures, pass the filename of those pictures on the picture list to this method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document"
        /// var arrPictureList = Xdk.camera.GetPictureList();
        /// for (var x = 0; x &lt; arrPictureList.length; x++)
        /// {
        ///     // create image 
        ///     var newImage = new HtmlImageElement();
        ///     newImage.src = Xdk.camera.GetPictureUrl(arrPictureList[x]);
        ///     newImage.style.width = "100px";
        ///     newImage.style.height = "100px";
        ///     newImage.id = "img_" + arrPictureList[x];
        ///     HtmlContext.document.body.AppendChild(newImage);
        /// }
        /// </code>
        /// </example>
        /// <param name="pictureFilename">The name of the picture to get the URL for reference dfrom the array returned from getPictureList</param>
        /// <returns></returns>
        [JsMethod(Name = "getPictureURL")]
        public JsString GetPictureUrl(JsString pictureFilename) { return default(JsString); }
    }
    #endregion

    #region Cache (verify property names for events)

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkCookieData
    {
        public JsString value { get; set; }
        public long expires { get; set; }
    }

    /// <summary>
    /// This object is intended to provide local storage for data to speed up applications.
    /// </summary>
    /// <remarks>
    /// This object is intended to provide local storage for data to speed up applications. It can be used as in conjunction with, or as an alternative to the HTML5 local database. Its methods provide features similar to browser cookies and file caching.
    /// <para>For cookies, the intention is that you would use <see cref="XdkCache.SetCookie">Xdk.cache.SetCookie</see> to save JsString data in name-value pairs. Cookies persist between application sessions. Data values may be retrieved using the <see cref="XdkCache.GetCookie">Xdk.cache.GetCookie</see> command or from the <see cref="XdkCache.GetCookieList">Xdk.cache.GetCookieList</see> command as soon as the <see cref="Xdk.OnDeviceReady"/> event is fired.</para>
    /// <para>The media cache commands are meant to provide quicker access to files such as videos and images. Adding files to the media cache will expedite access to them when the application runs. These are files that are cached across sessions and are not in your application bundle. See the Xdk.Cache* events for more information about events fired from the cache section of Intel XDK.</para>
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnCacheMediaAdd"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCacheMediaUpdate"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCacheMediaClear"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnCacheMediaRemove"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Cache")]
    public partial class XdkCache
    {
        /// <summary>
        /// 
        /// </summary>
        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        /// <summary>
        /// This method will retrieve the value of a cookie previously saved using the <see cref="SetCookie"/> command.
        /// </summary>
        /// <remarks>
        /// This method will get the value of a cookie previously saved using the <see cref="SetCookie"/> command. If no such cookie exists, the value returned will be "undefined".
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var value = Xdk.cache.GetCookie("userid");
        /// </code>
        /// </example>
        /// <param name="cookieName">The unique name for the data to retrieve.</param>
        /// <returns>The value of the cookie.</returns>
        [JsMethod(Name = "getCookie")]
        public JsString GetCookie(JsString cookieName) { return (default(JsString)); }
        /// <summary>
        /// This method will return an array containing the names of all the previously saved cookies using the <see cref="SetCookie"/> command.
        /// </summary>
        /// <remarks>
        /// These names can then be used in calls to <see cref="GetCookie"/>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// var cookiesArray = Xdk.cache.GetCookieList();
        /// for (int i = 0; i &lt; cookiesArray.length; i++)
        /// {
        ///     HtmlContext.Alert(cookiesArray[i] + ":" + Xdk.cache.GetCookie(cookiesArray[i]));
        /// }
        /// </code>
        /// </example>
        /// <returns>An array of all the unique names of previously saved data</returns>
        [JsMethod(Name = "getCookieList")]
        public JsArray<JsString> GetCookieList() { return (default(JsArray<JsString>)); }
        /// <summary>
        /// Call this method to set a chunk of data that will persist from session to session.
        /// </summary>
        /// <remarks>
        /// The data is automatically purged once the expiration date lapses. The data can be retrieved using the <see cref="GetCookie"/> command. 
        /// <para>Please note that cookie names may not include periods.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Prompt" or "Alert"
        /// public static void SaveInfo()
        /// {
        ///     //add a cookie
        ///     var name = HtmlContext.Prompt("Enter information name:");
        ///     var value = HtmlContext.Prompt("Enter information value:");
        ///     var daysTillExpiry = HtmlContext.Prompt("Days until cookie expires (-1 for never):").As&lt;long&gt;();
        ///     try
        ///     {
        ///         if (name.indexOf(".") == -1)
        ///         {
        ///             Xdk.cache.SetCookie(name, value, daysTillExpiry);
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert("cookie names may not include a period");
        ///         }
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in saveInfo: " + e.message);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="cookieName">A unique name for the data to save. The name parameter may not contain periods or underscores.</param>
        /// <param name="cookieValue">The data to save. The data will be saved as a JsString. An undefined variable will be saved as an empty JsString.</param>
        /// <param name="days">The number of days until the data is automatically removed from the device. Pass a -1 to make sure the application never automatically expires data. Pass a 0 to make the cookie a "session cookie" that is removed once the application is closed.</param>
        [JsMethod(Name = "setCookie")]
        public void SetCookie(JsString cookieName, object cookieValue, long days = -1) { }
        /// <summary>
        /// This method will clear data previously saved using the <see cref="SetCookie"/> method.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.cache.RemoveCookie("userid");
        /// </code>
        /// </example>
        /// <param name="cookieName">The unique name of the data to remove.</param>
        [JsMethod(Name = "removeCookie")]
        public void RemoveCookie(JsString cookieName) { }
        /// <summary>
        /// This method will clear all data stored using the <see cref="SetCookie"/> method.
        /// </summary>
        /// <remarks>
        /// This method will clear all data stored using the <see cref="SetCookie"/> method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.cache.ClearAllCookies(); 
        /// </code>
        /// </example>
        [JsMethod(Name = "clearAllCookies")]
        public void ClearAllCookies() { }
        /// <summary>
        /// This method will clear all data stored using the <see cref="SetCookie"/> method.
        /// </summary>
        /// <remarks>
        /// This method will clear all data stored using the <see cref="SetCookie"/> method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="name"></param>
        [JsMethod(Name = "clearAllCookies")]
        public void ClearAllCookies(JsString name) { }
        /// <summary>
        /// This method will get an array containing all the names of all the previously cached files.
        /// </summary>
        /// <remarks>
        /// This method will get an array containing all the names of all the previously cached files using the AddToMediaCache command. These names can then be used in calls to <see cref="GetMediaCacheLocalUrl"/>.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// var cacheArray = Xdk.cache.GetMediaCacheList();
        /// for (int i = 0; i &lt; cacheArray.length; i++)
        /// {
        ///     HtmlContext.Alert(cacheArray[i] + "  " + Xdk.cache.GetMediaCacheLocalUrl(cacheArray[i]));
        /// }
        /// </code>
        /// </example>
        /// <returns>An array of URLs that have been cached on the device using the AddToMediaCache method.</returns>
        [JsMethod(Name = "getMediaCacheList")]
        public JsArray<JsString> GetMediaCacheList() { return (default(JsArray<JsString>)); }
        /// <summary>
        /// This method will return an url that you can use to access the cached media file.
        /// </summary>
        /// <remarks>
        /// If the requested URL is not cached, the value returned will be "undefined".
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var localUrl = Xdk.cache.GetMediaCacheLocalUrl("http://myweb.com/image/logo.gif");
        /// </code>
        /// </example>
        /// <param name="url">The remote URL of the file that was cached.</param>
        /// <returns>The local URL of the cached file on the device itself.</returns>
        [JsMethod(Name = "getMediaCacheLocalURL")]
        public JsString GetMediaCacheLocalUrl(JsString url) { return (default(JsString)); }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="url">The url of the file to cache.</param>
        /// <returns></returns>
        [JsMethod(Name = "getMediaCacheRelativePath")]
        public JsString GetMediaCacheRelativePath(JsString url) { return (default(JsString)); }
        /// <summary>
        /// This command will remove all files from the local cache on the device.
        /// </summary>
        /// <remarks>
        /// This command will remove all files from the local cache on the device. Once this command is run the <see cref="Xdk.OnCacheMediaClear"/> event is fired.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCacheMediaClear"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void ClearMediaCache()
        /// {
        ///     Xdk.CacheMediaClear += CacheCleared;
        ///     Xdk.cache.ClearMediaCache();
        /// }
        /// static void CacheCleared(CacheEvent evt)
        /// {
        ///     HtmlContext.Alert("cache cleared successfully");;
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "clearMediaCache")]
        public void ClearMediaCache() { }
        /*
        /// <summary>
        /// deprecated
       /// </summary> 
                /// <param name="url">The url of the file to cache.</param>
                /// <param name="id">A unique identifier for the cache request.</param>
                [JsMethod(Name = "addToMediaCacheImpl")]
                private void AddToMediaCacheImpl(JsString url, JsString id) { }
        */
        /// <summary>
        /// This command will get a file from the Internet and cache it locally on the device.
        /// </summary>
        /// <remarks>
        /// It can then be referenced in a special directory named _mediacache off the root of the bundle. Once this command is run, the <see cref="Xdk.OnCacheMediaAdd"/> event is fired. If there is already a file cached with that name it is overwritten.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCacheMediaAdd"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void AddToMediaCache(JsString urlToCache)
        /// {
        ///     Xdk.CacheMediaAdd += CacheUpdated;
        ///     Xdk.cache.AddToMediaCache(urlToCache);
        /// }
        /// static void CacheUpdated(CacheEvent evt)
        /// {
        ///     HtmlContext.Alert(evt.url + " cached successfully");
        /// }
        /// </code>
        /// </example>
        /// <param name="url">The url of the file to cache.</param>
        [JsMethod(Name = "addToMediaCache")]
        public void AddToMediaCache(JsString url) { }
        /// <summary>
        /// This command will get a file or files from the Internet and cache it locally on the device.
        /// </summary>
        /// <remarks>
        /// It can then be referenced in a special directory named _mediacache off the root of the bundle. As this method is executed, the <see cref="Xdk.OnCacheMediaUpdate"/> event is fired repeatedly to track the progress of the file caching. If there is already a file cached with that name it is overwritten. As the file is cached by this method, a unique id is returned in order to identify their origin. This command will replace the depreciated command AddToMediaCache.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCacheMediaUpdate"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnCacheMediaAdd"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void AddToMediaCacheExt(JsString urlToCache, JsString uniqueId)
        /// {
        ///     Xdk.CacheMediaUpdate += CacheUpdated;
        ///     Xdk.CacheMediaAdd += CacheComplete;
        ///     Xdk.cache.AddToMediaCacheExt(urlToCache, uniqueId);
        /// }
        /// static void CacheComplete(CacheEvent evt)
        /// {
        ///     var outString = "";
        ///     outString += "The procedure succeeded (" + evt.success + ") ";
        ///     outString += " the unique id is: " + evt.id;
        ///     outString += "the URL is: " + evt.url;
        ///     HtmlContext.Alert(outString);
        /// }
        /// static void CacheUpdated(CacheEvent evt)
        /// {
        ///     var outString = "";
        ///     outString += "current bytes downloaded: " + evt.current;
        ///     outString += " total bytes in download: " + evt.total;
        ///     var percentage = evt.current / evt.total;
        ///     outString += " percentage downloaded: " + percentage + "%";
        ///     outString += " the unique id is: " + evt.id;
        ///     outString += "the URL is: " + evt.url;
        ///     HtmlContext.Alert(outString);
        /// }
        /// </code>
        /// </example>
        /// <param name="url">The url of the file to cache.</param>
        /// <param name="id">A unique identifier for the cache request.</param>
        [JsMethod(Name = "addToMediaCacheExt")]
        public void AddToMediaCacheExt(JsString url, JsString id) { }
        /// <summary>
        /// This command will remove a file from the local cache on the device.
        /// </summary>
        /// <remarks>
        /// Once this command is run the <see cref="Xdk.OnCacheMediaRemove"/> event is fired.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnCacheMediaRemove"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void RemoveFromMediaCache(JsString urlToRemove)
        /// {
        ///     Xdk.CacheMediaRemove+=Xdk_CacheMediaRemove;
        ///     Xdk.cache.RemoveFromMediaCache(urlToRemove); 
        /// }
        /// static void Xdk_CacheMediaRemove(CacheEvent evt)
        /// {
        ///     HtmlContext.Alert(evt.url + " removed successfully");
        /// }
        /// </code>
        /// </example>
        /// <param name="url">The url of the file to remove from the local cache.</param>
        [JsMethod(Name = "removeFromMediaCache")]
        public void RemoveFromMediaCache(JsString url) { }
    }
    #endregion

    #region Canvas (or DirectCanvas or AGI)
    /// <summary>
    /// The Accelerated Canvas App Game Interface 2d context drawing commands are accessed through this object.
    /// </summary>
    /// <remarks>
    /// The context object is a read-only object representing the Accelerated Canvas App Game Interface context. It is typically reached through the Xdk object this way:
    /// <code lang="C#">var ctx = Xdk.canvas.GetContext2D();</code>
    /// Not all of the commands built into the standard HTML5 canvas tag specification are built into the Accelerated Canvas App Game Interface. Furthermore, there are several commands specific to the Accelerated Canvas App Game Interface such as the present method that serve specific purposes. For a list of available and new commands, refer to: http://www2.appmobi.com/documentation/resources/pregenPages/directCanvasMatrix.html.
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "CanvasRenderingContext2D")]
    public partial class XdkCanvasRenderingContext2D : CanvasRenderingContext2D
    {
        /// <summary>
        /// Test the existence of <see cref="DrawImageTile"/> method
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        [JsProperty(Name = "DrawImageTile", NativeField = true)]
        public bool existsDrawImageTile { get; set; }
        /// <summary>
        /// The alpha property of the Accelerated Canvas App Game Interface context.
        /// </summary>
        /// <remarks>
        /// The globalAlpha attribute gives an alpha value that is applied to shapes and images before they are composited onto the canvas. The value must be in the range from 0.0 (fully transparent) to 1.0 (no additional transparency). If an attempt is made to set the attribute to a value outside this range, including Infinity and Not-a-Number (NaN) values, the attribute must retain its previous value. When the context is created, the globalAlpha attribute must initially have the value 1.0.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        public new double globalAlpha { get; set; }
        /// <summary>
        /// The globalCompositeOperation affects how canvas drawing routines interact with the data that's being drawn upon.
        /// </summary>
        /// <remarks>
        /// The globalCompositeOperation attribute sets how shapes and images are drawn onto the existing bitmap, once they have had globalAlpha and the current transformation matrix applied. It must be set to a value from the following list. In the descriptions below, the source image, A, is the shape or image being rendered, and the destination image, B, is the current state of the bitmap.HTML5 canvas provides compositing attribute globalCompositeOperation which affect all the drawing operations.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <exexample>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.fillStyle = "#0066FF";
        /// ctx.FillRect(15, 15, 70, 70);
        /// ctx.globalCompositeOperation = "source-over";
        /// ctx.fillStyle = "#FF3366";
        /// ctx.BeginPath();
        /// ctx.Arc(75, 75, 35, 0, JsMath.PI * 2, true);
        /// ctx.Fill();
        /// </code>
        /// </exexample>
        public new JsString globalCompositeOperation { get; set; }
        /// <summary>
        /// This property represents the color or style to use for stroking shapes.
        /// </summary>
        /// <remarks>
        /// Set this to change the stroke style. The style can be either a JsString containing a CSS color, or a CanvasGradient or CanvasPattern object. Invalid values are ignored.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        public new object strokeStyle { get; set; }
        /// <summary>
        /// This property represents the color or style to use for filling shapes.
        /// </summary>
        /// <remarks>
        /// Set this to change the stroke style. The style can be either a JsString containing a CSS color, or a CanvasGradient or CanvasPattern object. Invalid values are ignored.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        public new object fillStyle { get; set; }

        /// <summary>
        /// A boolean setting to keep drawn or flashing elements from being lost.
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// In depth, the Accelerated Canvas App Game Interface uses OpenGL for drawing. Unlike HTML5 Canvas, OpenGL has a fundamental concept of frames. For performance reasons, OpenGL does not necessarily preserve the contents of frames between draw calls (exposed as present in the Accelerated Canvas App Game Interface). Most game engines clear the the drawing surface at the beginning of each frame and then redraw the entire contents of the frame every time, so the contents of the frame do not need to be preserved. However, for applications that do not incorporate a clear->draw->present structure, it may be required to preserve the contents of the frame, in which case HTML5CompatibilityMode may need to be set to true. Note that this may require additional memory to be allocated, which may reduce your application's performance.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// try {
        ///     ctx.html5CompatibilityMode = true;
        /// } catch(JsError e){}
        /// </code>
        /// </example>
        [JsProperty(Name = "HTML5CompatibilityMode", NativeField = true)]
        public bool html5CompatibilityMode { get; set; }

        /// <summary>
        /// The background color used when clearing the Accelerated Canvas App Game Interface.
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// This property is write only. Use it to set the background color that will be used for the ctx.Clear() or ctx.ClearRect() method is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        public object clearStyle { get; set; }

        /// <summary>
        /// The scale of the Accelerated Canvas App Game Interface context.
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// This is a multiplier that changes the relative size of the Accelerated Canvas App Game Interface context.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        public double globalScale { get; set; }

        /// <summary>
        /// The height of the Accelerated Canvas App Game Interface element.
        /// <para>Not for XDK/HTML5 apps. Use instead <see cref="XdkCanvasElement.height">Xdk.canvas.height</see>.</para>
        /// </summary>
        /// <remarks>
        /// This is a multiplier that changes the relative size of the Accelerated Canvas App Game Interface context.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var windowHeight = ctx.height;
        /// </code>
        /// </example>
        public long height { get; set; }

        /// <summary>
        /// The width of the Accelerated Canvas App Game Interface element.
        /// <para>Not for XDK/HTML5 apps. Use instead <see cref="XdkCanvasElement.width">Xdk.canvas.width</see>.</para>
        /// </summary>
        /// <remarks>
        /// This is a multiplier that changes the relative size of the Accelerated Canvas App Game Interface context.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var windowWidth = ctx.width;
        /// </code>
        /// </example>
        public long width { get; set; }

        /// <summary>
        /// Draws an arc path around a single point.
        /// </summary>
        /// <remarks>
        /// This command can be used to draw part of or an entire circle based on a point and its radius. The direction may also be specified (defaulting to clockwise), is added to the path, connected to the previous point by a straight line.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.strokeStyle = "#ffffff";
        /// ctx.lineWidth = 3;
        /// ctx.fillStyle = "#ff00ff";
        /// ctx.BeginPath();
        /// var x = 10;
        /// var y = 20;
        /// var radius = 12;
        /// ctx.Arc(x, y, radius, 0, JsMath.PI * 2, true);
        /// ctx.ClosePath();
        /// ctx.Fill();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate of the starting point of the arc</param>
        /// <param name="y">The y-coordinate of the starting point of the arc</param>
        /// <param name="radius">the radius from the chosen point to draw the arc</param>
        /// <param name="startAngle">the angle to start the arc at</param>
        /// <param name="endAngle">The angle to end the arc at</param>
        /// <param name="anticlockwise">An optional parameter to have the arc draw counter-clockwise rather than clockwise (the default)</param>
        [JsMethod(Name = "arc")]
        public new void Arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise) { }

        /// <summary>
        /// Draws a turn in an otherwise straight line of a particular radius.
        /// </summary>
        /// <remarks>
        /// This command adds an arc with the given control points and radius to the current subpath, connected to the previous point by a straight line.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;
        /// ctx.BeginPath();
        /// ctx.strokeStyle = "rgba(128,255,0,0.9)";
        /// ctx.MoveTo(220, 20);
        /// ctx.ArcTo(30, 200, 80, 320, 40);
        /// ctx.LineTo(80, 320);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x1">The x-coordinate of the first point of the arc</param>
        /// <param name="y1">The y-coordinate of the first point of the arc</param>
        /// <param name="x2">The x-coordinate of the second point of the arc</param>
        /// <param name="y2">The y-coordinate of the second point of the arc</param>
        /// <param name="radius">The radius of the circular arc</param>
        [JsMethod(Name = "arcTo")]
        public new void ArcTo(double x1, double y1, double x2, double y2, double radius) { }

        /// <summary>
        /// Starts a new path.
        /// </summary>
        /// <remarks>
        /// This method will reset the current default path. It is used to start drawing a new path.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;
        /// ctx.BeginPath();
        /// ctx.strokeStyle = "rgba(255,255,255,0.9)";
        /// ctx.MoveTo(240, 40); // give the (x,y) coordinates
        /// ctx.LineTo(90, 395);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "beginPath")]
        public new void BeginPath() { }

        /// <summary>
        /// This command draws a curve with two control points.
        /// </summary>
        /// <remarks>
        /// Adds the given point to the current subpath, connected to the previous one by a cubic Bézier curve with the given control points. Draw a path from one point to another and stretch the path from two controll points.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;
        /// ctx.BeginPath();
        /// ctx.strokeStyle = "rgba(0,255,128,0.9)";
        /// ctx.MoveTo(220, 20);
        /// ctx.BezierCurveTo(80, 220, 480, 50, 80, 320);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="cp1x">Control point 1 x coordinate</param>
        /// <param name="cp1y">Control point 1 y coordinate</param>
        /// <param name="cp2x">Control point 2 x coordinate</param>
        /// <param name="cp2y">Control point 2 y coordinate</param>
        /// <param name="x">end point x coordinate</param>
        /// <param name="y">end point y coordinate</param>
        [JsMethod(Name = "bezierCurveTo")]
        public new void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { }

        /// <summary>
        /// Clears all pixels on the canvas in the given rectangle to transparent black.
        /// </summary>
        /// <remarks>
        /// If either height or width are zero, this method has no effect. Use the FillRect with fillStyle property to set the background color.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.FillRect(10, 10, 100, 100);
        /// ctx.StrokeRect(150, 150, 100, 100);
        /// ctx.ClearRect(30, 30, 40, 40);
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "clearRect")]
        public new void ClearRect(double x, double y, double width, double height) { }

        /// <summary>
        /// Starts a new path at the exact same point as where the previous path ended.
        /// </summary>
        /// <remarks>
        /// Marks the current subpath as closed, and starts a new subpath with a point the same as the start and end of the newly closed subpath.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.MoveTo(40, 40);
        /// ctx.LineTo(120, 35);
        /// ctx.LineTo(320, 180);
        /// ctx.LineTo(120, 390);
        /// ctx.LineTo(30, 340);
        /// ctx.LineTo(250, 50);
        /// ctx.LineTo(170, 80);
        /// // complete custom shape
        /// ctx.ClosePath();
        /// ctx.lineWidth = 5;
        /// ctx.fillStyle = "#FFFFFF";
        /// ctx.Fill();
        /// ctx.strokeStyle = "#AAAAAA";
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "closePath")]
        public new void ClosePath() { }


        /// <summary>
        /// Use this command to automatically display Accelerated Canvas App Game Interface changes if you would prefer not to use the canvas.Present command.
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// Programmers who would prefer not to manage calling present as part of a game engine run loop, can call this method toautomatically call present the requested number of times per second. This method takes one parameter - the desired frames per second.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.SetFps(15);  //15 frames per second
        /// </code>
        /// </example>
        /// <param name="framesPerSecond">The frames per second</param>
        [JsMethod(Name = "setFps")]
        public void SetFps(uint framesPerSecond) { }
        /// <summary>
        /// Clears the Accelerated Canvas App Game Interface.
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// This method will completely clear the Accelerated Canvas App Game Interface. Use the canvas.clearStyle property to set the background color.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// if (Xdk.isXdk)
        /// {
        ///     ctx.Clear();
        /// }
        /// else
        /// {
        ///     ctx.ClearRect(0, 0, Xdk.canvas.width, Xdk.canvas.height);
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "clear")]
        public void Clear() { }
        /// <summary>
        /// This method will trigger the Accelerated Canvas App Game Interface context to render canvas operations to the screen.
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// Nothing will be displayed to the Accelerated Canvas App Game Interface until this method is called. It should be used as part of a game engine loop. Programmers who would prefer not to manage calling present as part of a game engine run loop may use the canvas.setFPS method instead.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.strokeStyle = "rgba(255,128,128,0.5)";
        /// ctx.Rect(30, 30, 50, 50);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "present")]
        public void Present() { }
        /// <summary>
        /// This command will delete the Accelerated Canvas App Game Interface
        /// <para>Not emulated by XDK.</para>
        /// </summary>
        /// <remarks>
        /// This command is used to delete the Accelerated Canvas App Game Interface entirely. The Accelerated Canvas App Game Interface is created on the canvas.Load() call from within index.html.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "setTimeout"
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.strokeStyle  = "rgba(255,128,128,0.5)";
        /// ctx.Rect(30,30,50,50);
        /// ctx.Stroke();
        /// ctx.Present();
        /// HtmlContext.setTimeout(delegate (){ ctx.Detach(); },5000);
        /// </code>
        /// </example>
        [JsMethod(Name = "detach")]
        public void Detach() { }

        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="image">Image to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlImageElement image, double dx, double dy) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="image">Image to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dw">The width to size the image to on the Accelerated Canvas App Game Interface</param>
        /// <param name="dh">The height to size the image to on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlImageElement image, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void DrawSprite(long positionx, long positiony, JsString imageUrl, long frame)
        /// {
        ///     var ctx = Xdk.canvas.GetContext2D();
        ///     //draws a particular frame of a 90x100 size sprite
        ///     var imgSprite = new HtmlImageElement();
        ///     imgSprite.AddEventListener("load", delegate(Event evt)
        ///     {
        ///         if (ctx.existsDrawImageTile)
        ///         {
        ///             ctx.DrawImageTile(imgSprite, positionx, positiony, frame, 100, 90, false, false, 1);
        ///         }
        ///         else
        ///         {
        ///             //in the XDK, there is no DrawImageTile command
        ///             var sx = frame * 100;
        ///             ctx.DrawImage(imgSprite, sx, 0, 100, 90, 100, 300, 100, 90);
        ///         }
        ///         ctx.Present();
        ///     }, false);
        ///     imgSprite.src = imageUrl;
        /// }
        /// </code>
        /// </example>
        /// <param name="image">Image to draw</param>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites.</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dw">The width to size the image to on the Accelerated Canvas App Game Interface</param>
        /// <param name="dh">The height to size the image to on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="video">Video to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlVideoElement video, double dx, double dy) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="video">Video to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dw">The width to size the image to on the Accelerated Canvas App Game Interface</param>
        /// <param name="dh">The height to size the image to on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlVideoElement video, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="video">Video to draw</param>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites.</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dw">The width to size the image to on the Accelerated Canvas App Game Interface</param>
        /// <param name="dh">The height to size the image to on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlVideoElement video, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="canvas">Canvas to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlCanvasElement canvas, double dx, double dy) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="canvas">Canvas to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dw">The width to size the image to on the Accelerated Canvas App Game Interface</param>
        /// <param name="dh">The height to size the image to on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlCanvasElement canvas, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the Accelerated Canvas App Game Interface.
        /// </summary>
        /// <remarks>
        /// Draws the given image onto the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// See <see cref="DrawImage(HtmlImageElement,double,double,double,double,double,double,double,double)"/> example.
        /// </example>
        /// <param name="canvas">Canvas to draw</param>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites.</param>
        /// <param name="dx">The x-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dy">The y-coordinate to position the image at on the Accelerated Canvas App Game Interface</param>
        /// <param name="dw">The width to size the image to on the Accelerated Canvas App Game Interface</param>
        /// <param name="dh">The height to size the image to on the Accelerated Canvas App Game Interface</param>
        [JsMethod(Name = "drawImage")]
        public new void DrawImage(HtmlCanvasElement canvas, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }

        /// <summary>
        /// This method is used by the Impact plugin to draw Animation Sheets, which are an approach to sprites.
        /// <para>Not emulated by XDK.</para>
        /// <para>Warning: only for use with the Impact plugin!!!!</para>
        /// </summary>
        /// <remarks>
        /// The image must be a sprite sheet (a composite image composed of a series of same-sized images). The tile number along with the tile width and tile height are used to calculate the offset and rectangle for the current image (which is a piece of the overall image). This command is not available in the XDK.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void DrawSprite(long positionx, long positiony, JsString imageUrl, long frame)
        /// {
        ///     var ctx = Xdk.canvas.GetContext2D();
        ///     //draws a particular frame of a 90x100 size sprite
        ///     var imgSprite = new HtmlImageElement();
        ///     imgSprite.AddEventListener("load", delegate(Event evt)
        ///     {
        ///         if (ctx.existsDrawImageTile)
        ///         {
        ///             ctx.DrawImageTile(imgSprite, positionx, positiony, frame, 100, 90, false, false, 1);
        ///         }
        ///         else
        ///         {
        ///             //in the XDK, there is no DrawImageTile command
        ///             var sx = frame * 100;
        ///             ctx.DrawImage(imgSprite, sx, 0, 100, 90, 100, 300, 100, 90);
        ///         }
        ///         ctx.Present();
        ///     }, false);
        ///     imgSprite.src = imageUrl;
        /// }
        /// </code>
        /// </example>
        /// <param name="image">The image file reference</param>
        /// <param name="dx">The x-coordinate to position the image</param>
        /// <param name="dy">The y-coordinate to position the image</param>
        /// <param name="t">The tile number</param>
        /// <param name="dw">The tile width</param>
        /// <param name="dh">The tile height</param>
        /// <param name="flipX">A boolean indicating that the sprite is to be flipped in the x direction</param>
        /// <param name="flipY">A boolean indicating that the sprite is to be flipped in the y direction</param>
        /// <param name="alpha">The alpha of the image expressed as a fraction from 0 to 1 (e.g. 0.5)</param>
        [JsMethod(Name = "drawImageTile")]
        public void DrawImageTile(HtmlImageElement image, double dx, double dy, long t, double dw, double dh, bool flipX, bool flipY, double alpha) { }

        /// <summary>
        /// Fills the subpaths of the current default path or the given path with the current fill style.
        /// </summary>
        /// <remarks>
        /// Fills all the subpaths of the intended path, using fillStyle.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.BeginPath();
        /// ctx.MoveTo(40, 40);
        /// ctx.LineTo(120, 35);
        /// ctx.LineTo(320, 180);
        /// ctx.LineTo(120, 390);
        /// ctx.LineTo(30, 340);
        /// ctx.LineTo(250, 50);
        /// ctx.LineTo(170, 80);
        /// // complete custom shape
        /// ctx.ClosePath();
        /// ctx.lineWidth = 5;
        /// ctx.fillStyle = "#FF4949";
        /// ctx.Fill();
        /// ctx.strokeStyle = "#FFA81E";
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "fill")]
        public new void Fill() { }
        /// <summary>
        /// Fills the subpaths of the current default path or the given path with the current fill style.
        /// </summary>
        /// <remarks>
        /// Fills all the subpaths of the intended path, using fillStyle.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.BeginPath();
        /// ctx.MoveTo(40, 40);
        /// ctx.LineTo(120, 35);
        /// ctx.LineTo(320, 180);
        /// ctx.LineTo(120, 390);
        /// ctx.LineTo(30, 340);
        /// ctx.LineTo(250, 50);
        /// ctx.LineTo(170, 80);
        /// // complete custom shape
        /// ctx.ClosePath();
        /// ctx.lineWidth = 5;
        /// ctx.fillStyle = "#FF4949";
        /// ctx.Fill();
        /// ctx.strokeStyle = "#FFA81E";
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="path"></param>
        [JsMethod(Name = "fill")]
        public new void Fill(object path) { }

        /// <summary>
        /// Paints the given rectangle onto the canvas using the current fill style.
        /// </summary>
        /// <remarks>
        /// This method paints the specified rectangular area using the fillStyle. If either height or width are zero, this method has no effect.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.FillRect(10,10,100,100);
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "fillRect")]
        public new void FillRect(double x, double y, double width, double height) { }

        /// <summary>
        /// Strokes the subpaths of the current default path or the given path with the current stroke style.
        /// </summary>
        /// <remarks>
        /// This method draws the path,and then fills the combined stroke area using the strokeStyle attribute.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.strokeStyle  = "rgba(255,0,128,0.9)";
        /// ctx.Rect(30,230,200,100);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "stroke")]
        public new void Stroke() { }
        /// <summary>
        /// Strokes the subpaths of the current default path or the given path with the current stroke style.
        /// </summary>
        /// <remarks>
        /// This method draws the path,and then fills the combined stroke area using the strokeStyle attribute.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.strokeStyle  = "rgba(255,0,128,0.9)";
        /// ctx.Rect(30,230,200,100);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="path"></param>
        [JsMethod(Name = "stroke")]
        public new void Stroke(object path) { }

        /// <summary>
        /// Paints the box that outlines the given rectangle onto the canvas using the current stroke style.
        /// </summary>
        /// <remarks>
        /// This method traces the outline of the rectangle using available line styles, and then fills it with the strokeStyle.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.FillRect(10,10,100,100)
        /// ctx.StrokeRect(150,150,100,100);
        /// ctx.ClearRect(30,30,40,40);
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "strokeRect")]
        public new void StrokeRect(double x, double y, double width, double height) { }

        /// <summary>
        /// Returns an ImageData object containing the image data for the given rectangle of the canvas.
        /// </summary>
        /// <remarks>
        /// Returns an object containing the image data for the given rectangle of the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public static void DrawSprite(long positionx, long positiony, JsString imageUrl, long frame)
        /// {
        ///     var ctx = Xdk.canvas.GetContext2D();
        ///     //draws a particular frame of a 90x100 size sprite
        ///     var imgSprite = new HtmlImageElement();
        ///     imgSprite.AddEventListener("load", delegate(Event evt)
        ///     {
        ///         if (ctx.existsDrawImageTile)
        ///         {
        ///             ctx.DrawImageTile(imgSprite, positionx, positiony, frame, 100, 90, false, false, 1);
        ///         }
        ///         else
        ///         {
        ///             //in the XDK, there is no DrawImageTile command
        ///             var sx = frame * 100;
        ///             ctx.DrawImage(imgSprite, sx, 0, 100, 90, 100, 300, 100, 90);
        ///         }
        ///         ctx.Present();
        ///     }, false);
        ///     imgSprite.src = imageUrl;
        /// }
        /// // The function call
        /// var ctx = Xdk.canvas.GetContext2D();
        /// DrawSprite(10, 10, "images/mysprite0.png", 0);
        /// var objImageData = ctx.GetImageData(0, 0, 300, 400);
        /// </code>
        /// </example>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites. </param>
        /// <returns>object containing the image data</returns>
        [JsMethod(Name = "getImageData")]
        public new ImageData GetImageData(double sx, double sy, double sw, double sh) { return default(ImageData); }

        /// <summary>
        /// Returns true if the given point is in the current default path.
        /// </summary>
        /// <remarks>
        /// This method returns true if the point given by the x and y coordinates passed to the method, when treated as coordinates in the canvas coordinate space unaffected by the current transformation, is inside the intended path as determined by the non-zero winding number rule; and must return false otherwise. Points on the path itself must be considered to be inside the path. If either of the arguments is infinite or NaN, then the method must return false.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;
        /// ctx.strokeStyle = "rgba(255,0,128,0.9)";
        /// ctx.Rect(30, 230, 200, 100);
        /// ctx.Stroke();
        /// ctx.Present();
        /// if (ctx.IsPointInPath(50, 300) == true)
        /// {
        ///     ctx.strokeStyle = "rgba(0,128,255,0.5)";
        ///     ctx.Rect(50, 260, 200, 100);
        ///     ctx.Stroke();
        ///     ctx.Present();
        /// }
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate of the point to test</param>
        /// <param name="y">The y-coordinate of the point to test</param>
        /// <returns></returns>
        [JsMethod(Name = "isPointInPath")]
        public new bool IsPointInPath(double x, double y) { return default(bool); }

        /// <summary>
        /// Creates a new subpath with the given point.
        /// </summary>
        /// <remarks>
        /// Use this command to draw a line from an entirely new point on the canvas. Any LineTo command following a MoveTo command will use the point identified in the MoveTo as the starting point.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;  
        /// ctx.BeginPath();  
        /// ctx.strokeStyle  = "rgba(255,255,255,0.9)";
        /// ctx.MoveTo(240, 40); // give the (x,y) coordinates
        /// ctx.LineTo(90, 395);
        /// ctx.Stroke(); 
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate of the point to start the path.</param>
        /// <param name="y">The y-coordinate of the point to start the path.</param>
        [JsMethod(Name = "moveTo")]
        public new void MoveTo(double x, double y) { }

        /// <summary>
        /// Use this command to load a sound that might play simultaneously multiple times.
        /// </summary>
        /// <remarks>
        /// To play a sound in a Accelerated Canvas App Game Interface application repeatedly in a manner that it may overlap itself, use this method to load the sound for playing later using the <see cref="PlaySound"/> method. Loading the sound in advance allows it to play quicker and more reliably. If the sound or music is meant to play continuously in the background, consider using the <see cref="StartBackgroundSound(JsString, bool)"/> or <see cref="StartBackgroundSound(JsString)"/> method. If the sound will only play singularly, consider using <see cref="LoadSound"/> to save resources. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //Load a sound for playing repeatedly later
        /// Xdk.context.LoadPolySound("sounds/beep-10.wav", 8);
        /// </code>
        /// </example>
        /// <param name="filename">The relative path to the sound file to load</param>
        /// <param name="polyCount">The maximum number of times the sound file will play simultaneously</param>
        [JsMethod(Name = "loadPolySound")]
        public void LoadPolySound(JsString filename, long polyCount) { }
        /// <summary>
        /// Use this command to load a sound for playing later.
        /// </summary>
        /// <remarks>
        /// Just to play a sound in a Accelerated Canvas App Game Interface application, use this method to load the sound for playing later using the <see cref="PlaySound"/> method. Loading the sound in advance allows it to play quicker and more reliably. If the sound or music is meant to play continuously in the background, consider using the <see cref="StartBackgroundSound(JsString, bool)"/> or <see cref="StartBackgroundSound(JsString)"/> method. If the sound will be used repeatedly overlap itself consider using the <see cref="LoadPolySound"/> method. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //Load a sound for playing later
        /// Xdk.context.LoadSound("sounds/can-open-1.wav");
        /// </code>
        /// </example>
        /// <param name="filename">The relative path to the sound file to load</param>
        [JsMethod(Name = "loadSound")]
        public void LoadSound(JsString filename) { }
        /// <summary>
        /// Use this method to start playing a sound.
        /// </summary>
        /// <remarks>
        /// To play a sound in a Accelerated Canvas App Game Interface application, use this method. This method may be used to play a sound loaded using either the <see cref="LoadSound"/> method or the <see cref="LoadPolySound"/> method. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //Play a sound
        /// Xdk.context.PlaySound("sounds/beep-10.wav");
        /// </code>
        /// </example>
        /// <param name="filename">The relative path to the sound file to play</param>
        [JsMethod(Name = "playSound")]
        public void PlaySound(JsString filename) { }
        /// <summary>
        /// Starts a sound that plays in the background.
        /// </summary>
        /// <remarks>
        /// A single background sound may be maintained by the Accelerated Canvas App Game Interface. Use this method to start a background sound or music. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //This command will start the background music
        /// Xdk.context.StartBackgroundSound("sounds/music_main.mp3");
        /// </code>
        /// </example>
        /// <param name="filename">The relative path and filename of the background sound to play</param>
        [JsMethod(Name = "startBackgroundSound")]
        public void StartBackgroundSound(JsString filename) { }
        /// <summary>
        /// Starts a sound that plays continuously in the background.
        /// </summary>
        /// <remarks>
        /// A single (optionally looping) background sound may be maintained by the Accelerated Canvas App Game Interface. Use this method to start a background sound or music. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //This command will start the background music and loop it indefinitely
        /// Xdk.context.StartBackgroundSound("sounds/music_main.mp3", true);
        /// </code>
        /// </example>
        /// <param name="filename">The relative path and filename of the background sound to play</param>
        /// <param name="shouldLoop">An optional boolean value indicating whether this background sound should repeat indefinitely or not</param>
        [JsMethod(Name = "startBackgroundSound")]
        public void StartBackgroundSound(JsString filename, bool shouldLoop) { }
        /// <summary>
        /// Use this command to stop the background sound.
        /// </summary>
        /// <remarks>
        /// A single (optionally looping) background sound may be maintained by the Accelerated Canvas App Game Interface. Use this method to stop the background sound or music in order to free up resources. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //This command will stop a background sound loaded with startBackgroundSound in order to free up resources
        /// Xdk.context.StopBackgroundSound();
        /// </code>
        /// </example>
        [JsMethod(Name = "stopBackgroundSound")]
        public void StopBackgroundSound() { }
        /// <summary>
        /// Use this command to toggle a background sound on or off.
        /// </summary>
        /// <remarks>
        /// A single (optionally looping) background sound may be maintained by the Accelerated Canvas App Game Interface. Use this method to toggle a background sound or music on or off. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use. 
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //This command will toggle a background sound loaded with startBackgroundSound on or off
        /// Xdk.context.ToggleBackgroundSound();
        /// </code>
        /// </example>
        [JsMethod(Name = "toggleBackgroundSound")]
        public void ToggleBackgroundSound() { }
        /// <summary>
        /// Use this command to free up resources by unloading all sounds in memory.
        /// </summary>
        /// <remarks>
        /// Sounds loaded into Accelerated Canvas App Game Interface use memory and processing resources. Free up these resources by unloading all sounds previously loaded using both the <see cref="LoadSound"/> or <see cref="LoadPolySound"/> methods. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use. 
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //Free up resources by unloading all sounds
        /// Xdk.context.UnloadAllSounds();
        /// </code>
        /// </example>
        [JsMethod(Name = "unloadAllSounds")]
        public void UnloadAllSounds() { }
        /// <summary>
        /// Use this command to free up resources used to load and play sounds.
        /// </summary>
        /// <remarks>
        /// Sounds loaded into Accelerated Canvas App Game Interface use memory and processing resources. Free up these resources by unloading sounds previously loaded using either the <see cref="LoadSound"/> or <see cref="LoadPolySound"/> methods. This command is included in addition to the <see cref="Audio"/> object in order to provide improved performance and increased ease of use.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //Free up resources by unloading a sound
        /// Xdk.context.UnloadSound("sounds/beep-10.wav");
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="filename">The relative path to the sound file to unload</param>
        [JsMethod(Name = "unloadSound")]
        public void UnloadSound(JsString filename) { }

        /// <summary>
        /// This method is used to gather metrics about a particular block of text.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available to the iOS implementation of AGI. 
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="text">Text to be measured</param>
        /// <returns></returns>
        [JsMethod(Name = "measureText")]
        public new TextMetrics MeasureText(JsString text) { return default(TextMetrics); }
        /// <summary>
        /// Adds the given point to the current subpath, connected to the previous one by a straight line.
        /// </summary>
        /// <remarks>
        /// Use this command to draw a line from the previous point on the canvas (defined by either MoveTo or LineTo) to the specified point.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;
        /// ctx.BeginPath();  
        /// ctx.strokeStyle  = "rgba(255,255,255,0.9)";
        /// ctx.MoveTo(240, 40); // give the (x,y) coordinates
        /// ctx.LineTo(90, 395);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate of the point to add to the path.</param>
        /// <param name="y">The y-coordinate of the point to add to the path.</param>
        [JsMethod(Name = "lineTo")]
        public new void LineTo(double x, double y) { }
        /// <summary>
        /// Paints the data from the given ImageData object onto the canvas.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available to the iOS implementation of AGI.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="imagedata"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [JsMethod(Name = "putImageData")]
        public new void PutImageData(ImageData imagedata, double dx, double dy) { }
        /// <summary>
        /// Paints the data from the given ImageData object onto the canvas.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available to the iOS implementation of AGI.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="imagedata"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dirtyX"></param>
        /// <param name="dirtyY"></param>
        /// <param name="dirtyWidth"></param>
        /// <param name="dirtyHeight"></param>
        [JsMethod(Name = "putImageData")]
        public new void PutImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight) { }
        /// <summary>
        /// This command draws a curve using a single control point.
        /// </summary>
        /// <remarks>
        /// Adds the given point to the current subpath, connected to the previous one by a quadratic Bézier curve with the given control point. The QuadraticCurveTo method creates a line from the path's current point to the specified point, via a controlpoint.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.lineWidth = 15;  
        /// ctx.BeginPath();  
        /// ctx.strokeStyle  = "rgba(255,255,255,0.9)";
        /// ctx.MoveTo(220,  20);
        /// ctx.QuadraticCurveTo(340, 180, 80, 320);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="cpx">Control point x coordinate</param>
        /// <param name="cpy">Control point y coordinate</param>
        /// <param name="x">end point x coordinate</param>
        /// <param name="y">end point y coordinate</param>
        [JsMethod(Name = "quadraticCurveTo")]
        public new void QuadraticCurveTo(double cpx, double cpy, double x, double y) { }
        /// <summary>
        /// Draws a path in a rectangle.
        /// </summary>
        /// <remarks>
        /// Adds a new closed subpath to the path, representing the given rectangle.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// ctx.strokeStyle  = "rgba(255,0,128,0.9)";
        /// ctx.Rect(30, 230, 200, 100);
        /// ctx.Stroke();
        /// ctx.Present();
        /// </code>
        /// </example>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "rect")]
        public new void Rect(double x, double y, double width, double height) { }
        /// <summary>
        /// Pushes the current state onto the stack.
        /// </summary>
        /// <remarks>
        /// Each context maintains a stack of drawing states. Drawing states consist of the current transformation matrix, the current clipping region, and the current values of a variety of the Accelerated Canvas App Game Interface attributes including <see cref="strokeStyle"/>, <see cref="fillStyle"/>, <see cref="globalAlpha"/>, lineWidth, font, textAlign, and textBaseline.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var sx = 0.75; // .75 horizontal shear
        /// var sy = 0; // no vertical shear
        /// // apply custom transform and then revert to saved state
        /// ctx.Save();
        /// ctx.Transform(1, sy, sx, 1, 0, 0);
        /// // Type of "arrImages" is: JsArray of HtmlImageElement
        /// ctx.DrawImage(arrImages[2], 30, 30, 150, 100);
        /// ctx.Restore();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "save")]
        public new void Save() { }
        /// <summary>
        /// Restores the top state on the stack, restoring the Accelerated Canvas App Game Interface context to that state.
        /// </summary>
        /// <remarks>
        /// This method will pop the top entry in the drawing state stack, and reset the drawing state it describes. If there is no saved state, the method does nothing.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var sx = 0.75; // .75 horizontal shear
        /// var sy = 0; // no vertical shear
        /// // apply custom transform and then revert to saved state
        /// ctx.Save();
        /// ctx.Transform(1, sy, sx, 1, 0, 0);
        /// // Type of "arrImages" is: JsArray of HtmlImageElement
        /// ctx.DrawImage(arrImages[2], 30, 30, 150, 100);
        /// ctx.Restore();
        /// ctx.Present();
        /// </code>
        /// </example>
        [JsMethod(Name = "restore")]
        public new void Restore() { }
        /// <summary>
        /// Changes the size of an object.
        /// </summary>
        /// <remarks>
        /// Changes the transformation matrix to apply a scaling transformation with the given characteristics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var imgStatic = new HtmlImageElement();
        /// imgStatic.AddEventListener("load", delegate(Event evt)
        /// {
        ///     ctx.Save();
        ///     ctx.Scale(0.5, 2);
        ///     ctx.DrawImage(image0.imgObj, 0, 0);
        ///     ctx.Restore();
        ///     ctx.Present();
        /// }, false);
        /// imgStatic.src = imageUrl;
        /// </code>
        /// </example>
        /// <param name="sx">The scale factor of the object's width</param>
        /// <param name="sy">The scale factor of the object's height</param>
        [JsMethod(Name = "scale")]
        public new void Scale(double sx, double sy) { }
        /// <summary>
        /// Rotates an object.
        /// </summary>
        /// <remarks>
        /// Changes the transformation matrix to apply a rotation transformation with the given characteristics to the entire Accelerated Canvas App Game Interface. The angle is in radians.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var imgStatic = new HtmlImageElement();
        /// imgStatic.AddEventListener("load", delegate(Event evt)
        /// {
        ///     ctx.Save();
        ///     var angle = 45;
        ///     var radAngle = angle * JsMath.PI / 180;
        ///     ctx.Rotate(radAngle);
        ///     ctx.DrawImage(image0.imgObj,0,0);
        ///     ctx.Restore();
        ///     ctx.Present();
        /// }, false);
        /// imgStatic.src = imageUrl;
        /// </code>
        /// </example>
        /// <param name="angle">The angle to rotate an object in radians with positive numbers heading clockwise and negative numbers headed counter clockwise</param>
        [JsMethod(Name = "rotate")]
        public new void Rotate(double angle) { }

        /// <summary>
        /// This method resets the current transform to the identity matrix and then invokes the transform method with the same arguments.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// This method is currently only available in the iOS implementation of AGI.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [JsMethod(Name = "setTransform")]
        public new void SetTransform(double m11, double m12, double m21, double m22, double dx, double dy) { }
        /// <summary>
        /// Moves everything drawn on the canvas by a certain.
        /// </summary>
        /// <remarks>
        /// Changes the transformation matrix to apply a translation transformation with the given characteristics.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// var imgStatic = new HtmlImageElement();
        /// imgStatic.AddEventListener("load", delegate(Event evt)
        /// {
        ///     ctx.Save();
        ///     ctx.Translate(50, 50);
        ///     ctx.DrawImage(image0.imgObj, 0, 0);
        ///     ctx.Restore();
        ///     ctx.Present();
        /// }, false);
        /// imgStatic.src = imageUrl;
        /// </code>
        /// </example>
        /// <param name="tx">The amount to move what is drawn in the x-axis</param>
        /// <param name="ty">The amount to move what is drawn in the y-axis</param>
        [JsMethod(Name = "translate")]
        public new void Translate(double tx, double ty) { }
        /// <summary>
        /// This method replaces the current transformation matrix with the result of multiplying the current transformation matrix.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// The <see cref="Transform">Transform(a, b, c, d, e, f)</see> method must replace the current transformation matrix with the result of multiplying the current transformation matrix with the matrix described by:
        /// <para>a c e</para>
        /// <para>b d f</para>
        /// <para>0 0 1</para>
        /// <para>The arguments a, b, c, d, e, and f are sometimes called m11, m12, m21, m22, dx, and dy or m11, m21, m12, m22, dx, and dy. Care should be taken in particular with the order of the second and third arguments (b and c) as their order varies from API to API and APIs sometimes use the notation m12/m21 and sometimes m21/m12 for those positions.</para>
        /// <para>This method is currently only available in the iOS implementation of AGI.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [JsMethod(Name = "transform")]
        public new void Transform(double m11, double m12, double m21, double m22, double dx, double dy) { }

        /// <summary>
        /// Draws text with the canvas with the current strokeStyle.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available to the iOS implementation of AGI.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [JsMethod(Name = "strokeText")]
        public new void StrokeText(JsString text, double x, double y) { }
        /// <summary>
        /// Draws text with the canvas with the current strokeStyle.
        /// <para>Not for the Android implementation of AGI.</para>
        /// </summary>
        /// <remarks>
        /// This method is only available to the iOS implementation of AGI.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="maxWidth"></param>
        [JsMethod(Name = "strokeText")]
        public new void StrokeText(JsString text, double x, double y, double maxWidth) { }

    }

    /// <summary>
    /// The Canvas object represents the Accelerated Canvas App Game Interface instance itself.
    /// </summary>
    /// <remarks>
    /// The Canvas object is a read-only object representing the Accelerated Canvas App Game Interface tag. It is typically reached through the Xdk object this way:
    /// <code lang="C#">Xdk.canvas</code>
    /// In order to use the Accelerated Canvas App Game Interface, your app must be split into 2 components which will run in the 2 execution contexts which each have their own view. The HTML5 Tools component runs in the top view and should provide the portion of the user interface that the user interacts with. The Accelerated Canvas App Game Interface component runs in its own view that is beneath the first view - it does not directly receive touch events and so should not include user interaction elements. User interactions that are intended to provide input to the Accelerated Canvas App Game Interface component. It can do so via one of the bridge functions provided by the Accelerated Canvas App Game Interface (for example, a "jump" button in a game that causes a character to jump).
    /// <para>Other explication:</para>
    /// <para>The Accelerated Canvas App Game Interface plugin is designed for use with Intel XDK applications. In order to use Accelerated Canvas App Game Interface, your Intel XDK application must be split into two components which will run in two execution contexts. Each context will have its own view. The Intel XDK component runs in the top view and should provide the user interface that the user interacts with. The Accelerated Canvas App Game Interface component runs in its own view that is beneath the Intel XDK view and renders the graphics used for the application. It does not directly receive touch events and so should not include user interaction elements.</para>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Canvas")]
    public partial class XdkCanvasElement : HtmlCanvasElement
    {
        /// <summary>
        /// The Accelerated Canvas App Game Interface 2d context drawing commands are accessed through this object.
        /// </summary>
        /// <remarks>
        /// The context object is a read-only object representing the Accelerated Canvas App Game Interface context. It is typically reached through the Xdk object this way:
        /// <code lang="C#">var ctx = Xdk.canvas.GetContext2D();</code>
        /// Not all of the commands built into the standard HTML5 canvas tag specification are built into the Accelerated Canvas App Game Interface. Furthermore, there are several commands specific to the Accelerated Canvas App Game Interface such as the <see cref="XdkCanvasRenderingContext2D.Present">Present</see> method that serve specific purposes. For a list of available and new commands, refer to: http://www2.appmobi.com/documentation/resources/pregenPages/directCanvasMatrix.html.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        public XdkCanvasRenderingContext2D context { get; set; }
        /// <summary>
        /// The current visibility of the Accelerated Canvas App Game Interface object
        /// </summary>
        /// <remarks>
        /// This property is a boolean that can be used to determine the current visibility of the canvas.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// Xdk.canvas.Load("index.js");
        /// Xdk.canvas.Hide();
        /// HtmlContext.Alert(Xdk.canvas.isHidden);
        /// </code>
        /// </example>
        public bool isHidden { get; set; }

        /// <summary>
        /// The height of the Accelerated Canvas App Game Interface element.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var windowHeight = Xdk.canvas.height;
        /// </code>
        /// </example>
        public new long height { get; set; }

        /// <summary>
        /// The width of the Accelerated Canvas App Game Interface element.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var windowWidth = Xdk.canvas.width;
        /// </code>
        /// </example>
        public new long width { get; set; }

        /// <summary>
        /// Returns an object that exposes an API for 2d drawing on the canvas.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext2D();
        /// </code>
        /// </example>
        /// <returns>XdkCanvasRenderingContext2D object</returns>
        [JsMethod(Name = "getContext", InsertArg0 = "\"2d\"")]
        public new XdkCanvasRenderingContext2D GetContext2D() { return default(XdkCanvasRenderingContext2D); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [JsMethod(Name = "getContext", InsertArg0 = "\"webgl\"")]
        public new WebGLRenderingContext GetContextWebGL() { return default(WebGLRenderingContext); }
        /*
        /// <summary>
        /// Use instead <see cref="GetContext2D"/>():
        /// GetContext("2d") is like <see cref="GetContext2D"/> exept that the return type is already casted for <see cref="GetContext2D"/>.
        /// </summary>
        /// <remarks>
        /// The first argument specifies the desired API. Currently, the only API available is "2d".
        /// <para>If "2d", return a CanvasRenderingContext object that must be cast with CanvasRenderingContext2D type.</para>
        /// <para>
        /// <seealso cref="GetContext2D"/>
        /// <seealso cref="OrigGetContext"/>
        /// </para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.GetContext("2d");
        /// </code>
        /// </example>
        /// <param name="contextId">specifies the desired API. Currently, the only API available is "2d".</param>
        /// <returns>object herited from CanvasRenderingContext class</returns>
        [JsMethod(Name = "getContext")]
        public new CanvasRenderingContext GetContext(CanvasRenderingContextApi contextId) { return default(CanvasRenderingContext); }

        /// <summary>
        /// GetCanvasContext for the base class "HtmlCanvasElement".
        /// </summary>
        /// <remarks>
        /// The first argument specifies the desired API.
        /// <para>If "2d", return a CanvasRenderingContext2D object.</para>
        /// <para>If "webgl": return a WebGLRenderingContext object.</para>
        /// <para>
        /// <seealso cref="GetContext"/>
        /// <seealso cref="GetContext2D"/>
        /// </para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.OrigGetContext("2d");
        /// </code>
        /// </example>
        /// <param name="contextId">specifies the desired API: "2d" or "webgl"</param>
        /// <returns>object herited from CanvasRenderingContext class</returns>
        [JsMethod(Name = "origGetContext")]
        public CanvasRenderingContext OrigGetContext(CanvasRenderingContextApi contextId) { return default(CanvasRenderingContext); }
         */
        /// <summary>
        /// Returns an object that exposes an API for 2D drawing on the canvas.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.OrigGetContext2D();
        /// </code>
        /// </example>
        /// <returns>CanvasRenderingContext2D object</returns>
        [JsMethod(Name = "origGetContext", InsertArg0 = "\"2d\"")]
        public CanvasRenderingContext2D OrigGetContext2D() { return default(CanvasRenderingContext2D); }
        /// <summary>
        /// Returns an object that exposes an API for WebGL drawing on the canvas.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var ctx = Xdk.canvas.OrigGetContext2D();
        /// </code>
        /// </example>
        /// <returns>WebGLRenderingContext object</returns>
        [JsMethod(Name = "origGetContext", InsertArg0 = "\"webgl\"")]
        public WebGLRenderingContext OrigGetContextWebGL() { return default(WebGLRenderingContext); }

        /// <summary>
        /// Creates a new Accelerated Canvas App Game Interface and loads the contents of a JavaScript library into it.
        /// </summary>
        /// <remarks>
        /// This command must be executed in order to access Accelerated Canvas App Game Interface from an application.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.canvas.Load("index.js");
        /// </code>
        /// </example>
        /// <param name="relativeUrl">The filename of the Javascript file to load with the direct canvas</param>
        [JsMethod(Name = "load")]
        public void Load(JsString relativeUrl) { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface view to be shown. By default, the Accelerated Canvas App Game Interface is shown, but this method can be used to reveal the Accelerated Canvas App Game Interface once it has been hidden.
        /// </summary>
        /// <remarks>
        /// By default, the Accelerated Canvas App Game Interface is shown, but this method can be used to reveal the Accelerated Canvas App Game Interface once it has been hidden.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// Xdk.canvas.Load("index.js");
        /// Xdk.canvas.Hide();
        /// HtmlContext.Alert(Xdk.canvas.isHidden);
        /// Xdk.canvas.Show();
        /// </code>
        /// </example>
        [JsMethod(Name = "show")]
        public void Show() { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface view to be hidden.
        /// </summary>
        /// <remarks>
        /// By default, the Accelerated Canvas App Game Interface is shown.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// Xdk.canvas.Load("index.js");
        /// Xdk.canvas.Hide();
        /// HtmlContext.Alert(Xdk.canvas.isHidden);
        /// </code>
        /// </example>
        [JsMethod(Name = "hide")]
        public void Hide() { }

        /// <summary>
        /// JavaScript that is passed to the execute method and will be forwarded to the Accelerated Canvas App Game Interface execution context for execution there.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// In the example below, the 'jump' function would be executed in the Accelerated Canvas App Game Interface context.
        /// <code lang="C#">Xdk.canvas.Execute("jump()");</code>
        /// </example>
        /// <param name="javascript">Any JavaScript calls that should be executed in the Accelerated Canvas App Game Interface context</param>
        [JsMethod(Name = "execute")]
        public void Execute(JsString javascript) { }
        /// <summary>
        /// JavaScript that is passed to the execute method and will be forwarded to the Accelerated Canvas App Game Interface execution context for execution there.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jsResultFunction">Warning: not a JsString, but a something that return an object!</param>
        [JsMethod(Name = "execute", ArgumentsPrefix = "\"", ArgumentsSuffix = ";\"")]
        public void Execute(object jsResultFunction) { }
        /// <summary>
        /// JavaScript that is passed to the execute method and will be forwarded to the Accelerated Canvas App Game Interface execution context for execution there.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jsAction">Warning: a method like void something(), without the parenthesis.</param>
        [JsMethod(Name = "execute", ArgumentsPrefix = "\"", ArgumentsSuffix = "();\"")]
        public void Execute(JsAction jsAction) { }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="javascript">Any JavaScript calls that should be executed in the Accelerated Canvas App Game Interface context</param>
        [JsMethod(Name = "eval")]
        public void Eval(JsString javascript) { }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jsResultFunction">Warning: not a JsString, but a something that return an object!</param>
        [JsMethod(Name = "eval", ArgumentsPrefix = "\"", ArgumentsSuffix = ";\"")]
        public void Eval(object jsResultFunction) { }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jsAction">Warning: a method like void something(), without the parenthesis.</param>
        [JsMethod(Name = "eval", ArgumentsPrefix = "\"", ArgumentsSuffix = "();\"")]
        public void Eval(JsAction jsAction) { }

        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface view to be completely reset.
        /// </summary>
        /// <remarks>
        /// Use this method, followed by the load method to reload the page or when loading a brand new page.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.canvas.Load("index.js");
        /// Xdk.canvas.Reset();
        /// Xdk.canvas.Load("index2.js");
        /// </code>
        /// </example>
        [JsMethod(Name = "reset")]
        public void Reset() { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface to draw itself to its view a particular number of times per second.
        /// </summary>
        /// <remarks>
        /// Normally, you should call context.present as part of your run loop in your Accelerated Canvas App Game Interface component. However, this is an alternative which causes the Accelerated Canvas App Game Interface to draw itself to it's view fps times per second. Note that the Impact plugin calls context.present internally as part of the run loop, so Impact apps should not call setFramesPerSecond or context.present.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.canvas.SetFramesPerSecond(12);
        /// </code>
        /// </example>
        /// <param name="framesPerSecond">A numeric value indicating how often the Accelerated Canvas App Game Interface should draw itself per second.</param>
        [JsMethod(Name = "setFramesPerSecond")]
        public void SetFramesPerSecond(uint framesPerSecond) { }
        /// <summary>
        /// Compatibility stub: <see cref="SetFramesPerSecond"/>
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="framesPerSecond">A numeric value indicating how often the Accelerated Canvas App Game Interface should draw itself per second.</param>
        [JsMethod(Name = "setFps")]
        public void SetFps(uint framesPerSecond) { }

        /// <summary>
        /// </summary>
        /// <remarks>
        /// This is a multiplier that changes the relative size of the Accelerated Canvas App Game Interface context.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evt"></param>
        [JsMethod(Name = "forwardTouchEvent")]
        public void ForwardTouchEvent(TouchEvent evt) { }
    }
    #endregion

    #region Purchasing
    /// <summary>
    /// This class provides access to the appMobi in-app purchasing system.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Purchasing")]
    public partial class XdkPurchasing
    {
        [JsMethod(Name = "purchaseProduct")]
        public void PurchaseProduct(JsString productId, long quantity, JsString user) { }   // TODO verify type
    }
    #endregion

    #region Debug
    /// <summary>
    /// This class provides access to the debugging console.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Debug")]
    public partial class XdkDebug
    {
        /// <summary>
        /// Utility function for rendering and indenting strings, or serializing objects to a JsString capable of being printed to the console.
        /// </summary>
        /// <param name="message">The JsString or object to convert to an indented JsString</param>
        /// <returns></returns>
        [JsMethod(Name = "processMessage")]
        public JsString _ProcessMessage(object message) { return (default(JsString)); }
        /// <summary>
        /// Print a normal log message to the console
        /// </summary>
        /// <param name="message">Message or object to print to the console</param>
        [JsMethod(Name = "log")]
        public void Log(object message) { }
        /// <summary>
        /// Print a warning message to the console
        /// </summary>
        /// <param name="message">Message or object to print to the console</param>
        [JsMethod(Name = "warn")]
        public void Warn(object message) { }
        /// <summary>
        /// Print an error message to the console
        /// </summary>
        /// <param name="message">Message or object to print to the console</param>
        [JsMethod(Name = "error")]
        public void Error(object message) { }
    }
    #endregion

    #region Device
    public delegate void XdkRemoteDataCallback(JsString data);
    public delegate void XdkRemoteDataWithIdCallback(long uniqueId, JsString data);

    [JsType(JsMode.Json, Export = false)]
    [JsEnum(ValuesAsNames = true)]
    public enum XdkDeviceOrientation
    {
        [JsField(Name = "")]
        Unlock = 0,
        [JsField(Name = "portrait")]
        Portrait = 1,
        [JsField(Name = "landscape")]
        Landscape = 2
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Device.RemoteDataParameters")]
    public partial class XdkDeviceRemoteDataParameters : DataParametersBase
    {
    }

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.DeviceDataBase")]
    public partial class XdkDeviceDataBase
    {
        /// <summary>
        /// See <see cref="XdkDevice.platform"/>.
        /// </summary>
        public XdkDevicePlatformType platform { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.osVersion"/>.
        /// </summary>
        [JsProperty(Name = "osversion", NativeField = true)]
        public JsString osVersion { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.model"/>.
        /// </summary>
        public JsString model { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.uuid"/>.
        /// </summary>
        public JsString uuid { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.initialOrientation"/>.
        /// </summary>
        public int initialOrientation { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.appmobiVersion"/>.
        /// </summary>
        [JsProperty(Name = "appmobiversion", NativeField = true)]
        public JsString appmobiVersion { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.orientation"/>.
        /// </summary>
        public int orientation { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.connection"/>.
        /// </summary>
        public XdkDeviceConnectionType connection { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.width"/>.
        /// </summary>
        [JsProperty(Name = "width", NativeField = true)]
        public long width { get; set; }
        /// <summary>
        /// See <see cref="XdkDevice.height"/>.
        /// </summary>
        [JsProperty(Name = "height", NativeField = true)]
        public long height { get; set; }
    }

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.DeviceData")]
    public partial class XdkDeviceData : XdkDeviceDataBase
    {
        /// <summary>
        /// 
        /// </summary>
        public long statusWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long statusHeight { get; set; }
        /// <summary>
        /// See <see cref="Xdk.isNook"/>.
        /// </summary>
        [JsProperty(Name = "isnook", NativeField = true)]
        public static bool isNook { get; set; }
        /// <summary>
        /// See <see cref="Xdk.isPhone"/>.
        /// </summary>
        [JsProperty(Name = "isphone", NativeField = true)]
        public static bool isPhone { get; set; }
        /// <summary>
        /// See <see cref="Xdk.isTablet"/>.
        /// </summary>
        [JsProperty(Name = "istablet", NativeField = true)]
        public static bool isTablet { get; set; }
    }

    /// <summary>
    /// Access information about and configure settings of the device itself using this class.
    /// </summary>
    /// <remarks>
    /// The device class provides access to information about the device itself through a series of properties and functions.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnDeviceBarcodeScan"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceConnectionUpdate"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceContinue"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceHardwareBack"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceOrientationChange"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDevicePause"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceReady"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceRemoteBlock"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceRemoteClose"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceRemoteData"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceResume"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceSuspend"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnDeviceUpdateAvailable"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Device")]
    public partial class XdkDevice : XdkDeviceDataBase
    {
        /// <summary>
        /// The platform property returns a text JsString identifying the platform that Intel XDK is running on.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.platform);
        /// </code>
        /// </example>
        public new XdkDevicePlatformType platform { get; set; }
        /// <summary>
        /// This property returns the device's current operating system version information.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.osVersion);
        /// </code>
        /// </example>
        [JsProperty(Name = "osversion", NativeField = true)]
        public new JsString osVersion { get; set; }
        /// <summary>
        /// This property returns the model of the device that the application is running on.
        /// </summary>
        /// <remarks>
        /// This property is defined by the manufacturer of the device. Consequently, this property varies by maker as well as by model. Some valid values include:
        /// <list type="bullet">
        /// <item>
        /// <description>iPad</description>
        /// </item>
        /// <item>
        /// <description>iPhone 3G</description>
        /// </item>
        /// <item>
        /// <description>iPhone 4</description>
        /// </item>
        /// <item>
        /// <description>HTC EVO 4G</description>
        /// </item>
        /// <item>
        /// <description>HTC Legend</description>
        /// </item>
        /// <item>
        /// <description>HTC Evolution 4G</description>
        /// </item>
        /// <item>
        /// <description>HTC Thunderbolt</description>
        /// </item>
        /// <item>
        /// <description>HTC Sensation</description>
        /// </item>
        /// <item>
        /// <description>Motorola Droid</description>
        /// </item>
        /// <item>
        /// <description>Galaxy Tab</description>
        /// </item>
        /// <item>
        /// <description>Galaxy S</description>
        /// </item>
        /// <item>
        /// <description>Wave</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.model);
        /// </code>
        /// </example>
        public new JsString model { get; set; }
        /// <summary>
        /// The uuid property returns a unique identification id for the device.
        /// </summary>
        /// <remarks>
        /// The uuid property returns a unique identification id for the device. 
        /// <para>NOTE: Apple no longer permits obtaining the uuid within applications. Therfore if using this property on an iOS device the following is applied:</para> 
        /// <list type="bullet">
        /// <item>
        /// <description>iOS 5: Apple APIs are used to generate a unique GUID</description>
        /// </item>
        /// <item>
        /// <description>iOS 6: The Advertiser ID is returned as discussed in this announcement of March 21, 2013: https://developer.apple.com/news/?id=3212013a </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.uuid);
        /// </code>
        /// </example>
        public new JsString uuid { get; set; }
        /// <summary>
        /// This property returns the initial orientation of the device.
        /// </summary>
        /// <remarks>
        /// It will return one of the following values:
        /// <list type="table">
        /// <listheader>
        /// <term>Orientation</term>
        /// <description>Value</description>
        /// </listheader>
        /// <item>
        /// <term>Portrait</term>
        /// <description>0</description>
        /// </item>
        /// <item>
        /// <term>Upside Down Portrait</term>
        /// <description>180</description>
        /// </item>
        /// <item>
        /// <term>Landscape Right</term>
        /// <description>90</description>
        /// </item>
        /// <item>
        /// <term>Landscape Left</term>
        /// <description>-90</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //detect the initial orientation of the device
        /// if (Xdk.device.initialOrientation == 90 || Xdk.device.initialOrientation == -90)
        /// {
        ///     //landscape
        /// }
        /// else
        /// {
        ///     //portrait
        /// }
        /// </code>
        /// </example>
        public new int initialOrientation { get; set; }
        /// <summary>
        /// This property returns the version of the Intel XDK container software that the application is using.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.appmobiVersion);
        /// </code>
        /// </example>
        [JsProperty(Name = "appmobiversion", NativeField = true)]
        public new JsString appmobiVersion { get; set; }
        /// <summary>
        /// This property returns the version of phonegap running below the Intel XDK layer.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.phonegapVersion);
        /// </code>
        /// </example>
        [JsProperty(Name = "phonegapversion", NativeField = true)]
        public JsString phonegapVersion { get; set; }
        /// <summary>
        /// This property returns the current orientation of the device
        /// </summary>
        /// <remarks>
        /// It will return one of the following values:
        /// <list type="table">
        /// <listheader>
        /// <term>Orientation</term>
        /// <description>Value</description>
        /// </listheader>
        /// <item>
        /// <term>Portrait</term>
        /// <description>0</description>
        /// </item>
        /// <item>
        /// <term>Upside Down Portrait</term>
        /// <description>180</description>
        /// </item>
        /// <item>
        /// <term>Landscape Right</term>
        /// <description>90</description>
        /// </item>
        /// <item>
        /// <term>Landscape Left</term>
        /// <description>-90</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //detect the initial orientation of the device
        /// if (Xdk.device.orientation == 90 || Xdk.device.orientation == -90)
        /// {
        ///     //landscape
        /// }
        /// else
        /// {
        ///     //portrait
        /// }
        /// </code>
        /// </example>
        public new int orientation { get; set; }
        /// <summary>
        /// This property senses the best type of internet connection available
        /// </summary>
        /// <remarks>
        /// This property senses the best network connection type available and returns the result (either "wifi", "cell", or "none"). If the connection is still being negotiated by the device and the best network connection type is still being determined, this property will return the value "unknown". This property is updated only when the <see cref="XdkDevice.UpdateConnection">device.UpdateConnection()</see> command is called and the <see cref="Xdk.OnDeviceConnectionUpdate"/> event is triggered.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void DeviceConnection()
        /// {
        ///     Xdk.OnDeviceConnectionUpdate += Xdk_DeviceConnectionUpdate;
        ///     Xdk.device.UpdateConnection();
        /// }
        /// static void Xdk_DeviceConnectionUpdate(DeviceEvent evt)
        /// {
        ///     HtmlContext.Alert(Xdk.device.connection);
        /// }
        /// </code>
        /// </example>
        public new XdkDeviceConnectionType connection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.width);
        /// </code>
        /// </example>
        [JsProperty(Name = "width", NativeField = true)]
        public new long width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.height);
        /// </code>
        /// </example>
        [JsProperty(Name = "height", NativeField = true)]
        public new long height { get; set; }




        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.available);
        /// </code>
        /// </example>
        public bool available { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.density);
        /// </code>
        /// </example>
        public double density { get; set; }     // TODO: vertify type
        /// <summary>
        /// This property will hold information about the audio stream currently playing
        /// </summary>
        /// <remarks>
        /// This property will hold the NetStationID or ShoutcastURL of the station that is playing. Otherwise, this property only holds a null. This allows the user to know if their station is already playing at startup. This can happened if the UI is destroyed and the audio continues in the background and then the application is later brought back to the foreground.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.lastStation);
        /// </code>
        /// </example>
        public JsString lastPlaying { get; set; }

        /// <summary>
        /// This property indicates whether analytics has been enabled for this application.
        /// </summary>
        /// <remarks>
        /// This property indicates whether analytics has been enabled for this application. Functions under Xdk.stats will not be available if this is false.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasAnalytics);
        /// </code>
        /// </example>
        public bool hasAnalytics { get; set; }
        /// <summary>
        /// This property says whether caching has been enabled for this application
        /// </summary>
        /// <remarks>
        /// Functions under Xdk.cache for mediacache will not be available if this is false.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasCaching);
        /// </code>
        /// </example>
        public bool hasCaching { get; set; }
        /// <summary>
        /// This property indicates whether streaming has been enabled for this application.
        /// </summary>
        /// <remarks>
        /// Functions under Xdk.player for station and shoutcast will not be available if this is false.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasStreaming);
        /// </code>
        /// </example>
        public bool hasStreaming { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasAdvertising);
        /// </code>
        /// </example>
        public bool hasAdvertising { get; set; }
        /// <summary>
        /// This property indicates whether pushMobi has been enabled for this application.
        /// </summary>
        /// <remarks>
        /// This property indicates whether pushMobi push messages have been enabled for this application. This application will not be able to use the pushMobi cloud service if this is false.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasPush);
        /// </code>
        /// </example>
        public bool hasPush { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasPayments);
        /// </code>
        /// </example>
        public bool hasPayments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasInAppPay);
        /// </code>
        /// </example>
        public bool hasInAppPay { get; set; }
        /// <summary>
        /// This property indicates whether Live Update has been enabled for this application.
        /// </summary>
        /// <remarks>
        /// This property indicates whether the Live Update service of hostMobi has been enabled for this application. This application will not be able to use the Live Updates cloud service if this is false.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasUpdates);
        /// </code>
        /// </example>
        public bool hasUpdates { get; set; }
        /// <summary>
        /// This property indicates whether the OAuth has been enabled for this application.
        /// </summary>
        /// <remarks>
        /// This property indicates whether the OAuth has been enabled for this application. This application will not be able to use the OAuth if this is false.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.hasOAuth);
        /// </code>
        /// </example>
        public bool hasOAuth { get; set; }

        /// <summary>
        /// Width for the landscape mode.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.landWith);
        /// </code>
        /// </example>
        [JsProperty(Name = "landwidth", NativeField = true)]
        public long landWidth { get; set; }
        /// <summary>
        /// Height for the landscape mode.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.landHeight);
        /// </code>
        /// </example>
        [JsProperty(Name = "landheight", NativeField = true)]
        public long landHeight { get; set; }
        /// <summary>
        /// Width for the portrait mode.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.portWidth);
        /// </code>
        /// </example>
        [JsProperty(Name = "portwidth", NativeField = true)]
        public long portWidth { get; set; }
        /// <summary>
        /// Height for the portrait mode.
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.portHeight);
        /// </code>
        /// </example>
        [JsProperty(Name = "portheight", NativeField = true)]
        public long portHeight { get; set; }
        /// <summary>
        /// This property returns any query JsString parameters passed along with a protocol handler call to start an application
        /// </summary>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// HtmlContext.Alert(Xdk.device.queryString);
        /// </code>
        /// </example>
        public JsString queryString { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public XdkDevice() { }
        /// <summary>
        /// Constructor with an object of DeviceData type
        /// </summary>
        public XdkDevice(XdkDeviceData deviceData) { }

        /// <summary>
        /// This method controls how the device behaves in certain power states.
        /// </summary>
        /// <remarks>
        /// If shouldStayOn is false, normal power management for the device applies. If shouldStayOn is true and onlywhenPluggedIn is true, then the device will not go to sleep if the device is plugged in. If shouldStayOn is true and onlyWhenPluggedIn is false, then the device will never go to sleep.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.device.ManagePower(true, false);
        /// </code>
        /// </example>
        /// <param name="shouldStayOn">This boolean value sets whether normal power management for the device applies or not.</param>
        /// <param name="onlyWhenPluggedIn">This boolean value is only used if shouldStayOn is set to true. If shouldStayOn is true and onlywhenPluggedIn is true, then the device will not go to sleep if the device is plugged in. If shouldStayOn is true and onlyWhenPluggedIn is false, then the device will never go to sleep.</param>
        [JsMethod(Name = "managePower")]
        public void ManagePower(bool shouldStayOn, bool onlyWhenPluggedIn) { }
        /// <summary>
        /// This function will control whether the device should automatically handle rotation or not based on a boolean value.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.device.SetAutoRotate(false);
        /// </code>
        /// </example>
        /// <param name="shouldAutoRotate">This boolean value controls whether the device is allowed to automatically handle rotation or not.</param>
        [JsMethod(Name = "setAutoRotate")]
        public void SetAutoRotate(bool shouldAutoRotate) { }
        /// <summary>
        /// This function will lock the orientation of the device to either "landscape", "portrait" or unlock orientation.
        /// </summary>
        /// <remarks>
        /// This function will lock the orientation of the device to either "landscape" or "portrait" orientation. The orientation will be locked based on which specific JsString is passed to the function. Passing "portrait" will lock the application into portrait orientation and passing "landscape" will lock the application into landscape orientation. If the current orientation is not the specified orientation, the device will lock in the specified orientation only once the device is oriented in that position.
        /// <para>To unlock the orientation, select DeviceOrientation.Unlock.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.device.SetRotateOrientation(DeviceOrientation.Landscape);
        /// </code>
        /// </example>
        /// <param name="orientation"></param>
        [JsMethod(Name = "setRotateOrientation")]
        public void SetRotateOrientation(XdkDeviceOrientation orientation) { }
        /// <summary>
        /// This function will query the device to determine its current connection to the internet.
        /// </summary>
        /// <remarks>
        /// When it is done it will fire an event <see cref="Xdk.OnDeviceConnectionUpdate"/> and the <see cref="XdkDevice.connection">connection property of Xdk.device</see> will be updated.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceConnectionUpdate"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void DeviceConnection()
        /// {
        ///     Xdk.OnDeviceConnectionUpdate += Xdk_DeviceConnectionUpdate;
        ///     Xdk.device.UpdateConnection();
        /// }
        /// static void Xdk_DeviceConnectionUpdate(DeviceEvent evt)
        /// {
        ///     HtmlContext.Alert(Xdk.device.connection);
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "updateConnection")]
        public void UpdateConnection() { }

        /// <summary>
        /// This function will set header data required for basic authentication over the Internet.
        /// </summary>
        /// <remarks>
        /// It requires the domain and realm of the server it will make the request to as well as the appropriate username and password credentials. This method is not available on all platforms.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void BasicAuthentication(JsString username, JsString password, JsString url)
        /// {
        ///     XMLHttpRequest xmlhttp;
        ///     try
        ///     {
        ///         xmlhttp = new XMLHttpRequest(); // instantiate XMLHttpRequest
        ///     }
        ///     catch (JsError err)
        ///     {
        ///         HtmlContext.Alert("Error initializing XMLHttpRequest.\n" + err);
        ///         return;
        ///     }
        ///     Xdk.device.SetBasicAuthentication("api.twitter.com", username, password);
        ///     JsAction&lt;JsString, bool, JsString&gt; RequestResponse = new JsAction&lt;JsString, bool, JsString&gt;(delegate(JsString urlRequest, bool b, JsString strData)
        ///     {
        ///         try
        ///         {
        ///             xmlhttp.open("GET", urlRequest);
        ///         }
        ///         catch (JsError err)
        ///         {
        ///             HtmlContext.Alert("XMLHttpRequest.open() failed.\n" + err.message + " \n URL : " + url);
        ///             return;
        ///         }
        ///         xmlhttp.send(strData);
        ///     });
        ///     XMLHttpRequest xmlhttp = new XMLHttpRequest();
        ///     xmlhttp.ReadyStateChanged += new EventListener(delegate(Event evt)
        ///     {
        ///         HtmlContext.Alert(xmlhttp.status + "   " + xmlhttp.readyState);
        ///         if (xmlhttp.readyState ==  XMLHttpRequestState.DONE)
        ///         {
        ///             if (xmlhttp.status == 200)
        ///             {
        ///                 try { RequestResponse(url, true, xmlhttp.responseText); }
        ///                 catch (JsError e) { }
        ///             }
        ///         }
        ///     });
        /// }
        /// </code>
        /// </example>
        /// <param name="domain">The domain and realm of the server to make the request to.</param>
        /// <param name="username">The appropriate username for the authentication request.</param>
        /// <param name="password">The appropriate password for the authentication request.</param>
        [JsMethod(Name = "setBasicAuthentication")]
        public void SetBasicAuthentication(JsString domain, JsString username, JsString password) { }
        /// <summary>
        /// This function will intercept a single press of the device's hardware "back" button and fire the <see cref="Xdk.OnDeviceHardwareBack"/> event instead.
        /// </summary>
        /// <remarks>
        /// Call this function several times to intercept multiple device hardware button presses. This is used in applications that want to simulate flow through their app and have the device's hardware back button be able to be used to navigate backwards through the flow. 
        /// <para>This method is not available on all platforms.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceHardwareBack"/></description>
        /// </item>
        /// </list>      
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// //pass a true to start capturing the back button
        /// //pass a false to stop capturing the back button
        /// //on a capture, the HWBackButtonPressed function is called
        /// static bool hwBackButton_boolCaptureState { get; set; }
        /// public static void HWBackButtonCapture(bool boolForceState)
        /// {
        ///     try
        ///     {
        ///         //force by default
        ///         if (boolForceState == null)
        ///         {
        ///             boolForceState = true;
        ///         }
        ///         if (boolForceState == true &amp;&amp; hwBackButton_boolCaptureState == false)
        ///         {
        ///             //capture the back button
        ///             try
        ///             {
        ///                 Xdk.device.AddVirtualPage();
        ///                 hwBackButton_boolCaptureState = true;
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("error adding virtual page:" + e.message);
        ///             }
        ///         }
        ///         else if (boolForceState == false)
        ///         {
        ///             //stop capturing the back button
        ///             try
        ///             {
        ///                 Xdk.device.RemoveVirtualPage();
        ///                 hwBackButton_boolCaptureState = false;
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("error removing virtual page:" + e.message);
        ///             }
        ///         }
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in captureHWBackButton: " + e.message);
        ///     }
        /// }
        /// public static void HWBackButtonPressed(DeviceEvent evt)
        /// {
        ///     try
        ///     {
        ///         Xdk.device.AddVirtualPage();
        ///         //        HWBackButtonExecute();
        ///         HtmlContext.console.Log("Hardware Back Button Pressed");
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in HWBackButtonPressed: " + e.message);
        ///     }
        /// }
        /// public static void HWBackButtonInit()
        /// {
        ///     Xdk.OnDeviceHardwareBack += HWBackButtonPressed;
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "addVirtualPage")]
        public void AddVirtualPage() { }
        /// <summary>
        /// This method will help control a device's hardware "back" button.
        /// </summary>
        /// <remarks>
        /// This method will remove the interception of a single press of the device's hardware "back" button. For example, the back button on the Android device platform. This method is not available on all platforms.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// //pass a true to start capturing the back button
        /// //pass a false to stop capturing the back button
        /// //on a capture, the HWBackButtonPressed function is called
        /// static bool hwBackButton_boolCaptureState { get; set; }
        /// public static void HWBackButtonCapture(bool boolForceState)
        /// {
        ///     try
        ///     {
        ///         //force by default
        ///         if (boolForceState == null)
        ///         {
        ///             boolForceState = true;
        ///         }
        ///         if (boolForceState == true &amp;&amp; hwBackButton_boolCaptureState == false)
        ///         {
        ///             //capture the back button
        ///             try
        ///             {
        ///                 Xdk.device.AddVirtualPage();
        ///                 hwBackButton_boolCaptureState = true;
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("error adding virtual page:" + e.message);
        ///             }
        ///         }
        ///         else if (boolForceState == false)
        ///         {
        ///             //stop capturing the back button
        ///             try
        ///             {
        ///                 Xdk.device.RemoveVirtualPage();
        ///                 hwBackButton_boolCaptureState = false;
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("error removing virtual page:" + e.message);
        ///             }
        ///         }
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in captureHWBackButton: " + e.message);
        ///     }
        /// }
        /// public static void HWBackButtonPressed(DeviceEvent evt)
        /// {
        ///     try
        ///     {
        ///         Xdk.device.AddVirtualPage();
        ///         //        HWBackButtonExecute();
        ///         HtmlContext.console.Log("Hardware Back Button Pressed");
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.Alert("error in HWBackButtonPressed: " + e.message);
        ///     }
        /// }
        /// public static void HWBackButtonInit()
        /// {
        ///     Xdk.OnDeviceHardwareBack += HWBackButtonPressed;
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "removeVirtualPage")]
        public void RemoveVirtualPage() { }
        /// <summary>
        /// This function will open a url in the device's native browser application.
        /// </summary>
        /// <remarks>
        /// For example, on an iOS device, the URL will open in a Safari window. 
        /// <para>It can also be used to launch device services (such as SMS, email, or twitter) using known protocol handlers.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //Open a URL example
        /// Xdk.device.LaunchExternal("http://www.google.com");
        /// // Email example
        /// Xdk.device.LaunchExternal("mailto:my@emailaddress.com?subject=email%20Me&amp;body=test%20test%20test");
        /// // Twitter example
        /// Xdk.device.LaunchExternal("twitter://post?message=Message%20Tex");
        /// </code>
        /// </example>
        /// <param name="url">The URL for the browser window to open.</param>
        [JsMethod(Name = "launchExternal")]
        public void LaunchExternal(JsString url) { }
        /// <summary>
        /// This function is used to show a remote web site in a different web view.
        /// </summary>
        /// <remarks>
        /// Touching the close image will shut down the web view and return the user to the normal Intel XDK application.
        /// <para>The url parameter is for the new view's target url. The image coordinates define the position, width, and height of the close image that the user may touch to close the web view. By default close image is set to 48x48 pixels and positioned in the upper left hand corner of the screen.</para>
        /// <para>The close image may be changed by including a different remote_close.png file in the _appMobi directory of the project.</para>
        /// <para>When the close button is touched, it fires an <see cref="Xdk.OnDeviceRemoteClose"/> event.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceRemoteClose"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.device.ShowRemoteSite("http://www.twitter.com/", 280, 0, 50, 50);
        /// </code>
        /// </example>
        /// <param name="url">The URL for the web view to open.</param>
        /// <param name="closeImageX">The position of the button to close the web view from the left edge in pixels.</param>
        /// <param name="closeImageY">The position of the button to close the web view from the top edge in pixels.</param>
        /// <param name="closeImageWidth">The width of the button to close the web view in pixels.</param>
        /// <param name="closeImageHeight">The height of the button to close the web view in pixels.</param>
        [JsMethod(Name = "showRemoteSite")]
        public void ShowRemoteSite(JsString url, long closeImageX, long closeImageY, long closeImageWidth, long closeImageHeight) { }
        /// <summary>
        /// This function is used to show a remote web site in a different web view.
        /// </summary>
        /// <remarks>
        /// Touching the close image will shut down the web view and return the user to the normal Intel XDK application.
        /// <para>The url parameter is for the new view's target url. The image coordinates define the position, width, and height of the close image that the user may touch to close the web view. By default close image is set to 48x48 pixels and positioned in the upper left hand corner of the screen.</para>
        /// <para>The close image may be changed by including a different remote_close.png file in the _appMobi directory of the project.</para>
        /// <para>When the close button is touched, it fires an <see cref="Xdk.OnDeviceRemoteClose"/> event.</para>
        /// <para>This method replaces the <see cref="XdkDevice.ShowRemoteSite">Xdk.device.showRemoteSite</see>.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceRemoteClose"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.device.ShowRemoteSiteExt("http://www.google.com/", 280, 0, 50, 50);
        /// </code>
        /// </example>
        /// <param name="url">The URL for the web view to open.</param>
        /// <param name="closeImagePortraitX">The position of the button to close the web view from the left edge in pixels when the device is in the portrait orientation.</param>
        /// <param name="closeImagePortraitY">The position of the button to close the web view from the top edge in pixels when the device is in the portrait orientation.</param>
        /// <param name="closeImageLandscapeX">The position of the button to close the web view from the left edge in pixels when the device is in the landscape orientation.</param>
        /// <param name="closeImageLandscapeY">The position of the button to close the web view from the top edge in pixels when the device is in the landscape orientation.</param>
        /// <param name="closeImageWidth">The width of the button to close the web view in pixels.</param>
        /// <param name="closeImageHeight">The height of the button to close the web view in pixels.</param>
        [JsMethod(Name = "showRemoteSiteExt")]
        public void ShowRemoteSiteExt(JsString url, long closeImagePortraitX, long closeImagePortraitY, long closeImageLandscapeX, long closeImageLandscapeY, long closeImageWidth, long closeImageHeight) { }
        /// <summary>
        /// Call this command to force a remote site opened with showRemoteSite or showRemoteSiteExt to close.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceRemoteClose"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// public static void OnDeviceReady(DeviceEvent evt)
        /// {
        ///     try
        ///     {
        ///         int iCookieValue = 1;
        ///         Xdk.device.MainViewExecute("Xdk.cache.setCookie('remoteSiteCookie','" + iCookieValue + "',-1);");
        ///         Xdk.device.CloseRemoteSite();
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.console.Log("oops " + e.message);
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "closeRemoteSite")]
        public void CloseRemoteSite() { }
        /// <summary>
        /// Call this command from within a new web view created by the <see cref="ShowRemoteSite"/> or <see cref="ShowRemoteSiteExt"/> command to execute JavaScript commands within the main web view.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// public static void OnDeviceReady(DeviceEvent evt)
        /// {
        ///     try
        ///     {
        ///         int iCookieValue = 1;
        ///         Xdk.device.MainViewExecute("Xdk.cache.setCookie('remoteSiteCookie','" + iCookieValue + "',-1);");
        ///         Xdk.device.CloseRemoteSite();
        ///     }
        ///     catch (JsError e)
        ///     {
        ///         HtmlContext.console.Log("oops " + e.message);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="command">Any JavaScript that should be passed to and executed in the main web view of the application.</param>
        [JsMethod(Name = "mainViewExecute")]
        public void MainViewExecute(JsString command) { }
        /// <summary>
        /// Use this method to block remote pages, and also set up a white list of allowable remote pages.
        /// </summary>
        /// <remarks>
        /// Use this method to block remote pages from this application, while turning on the ability to intercept a remote page redirect.
        /// <para>This method requires two parameters, a boolean value that indicates whether to block remote pages or not, and a pipe ("|") delimited list of domains or domain:port pairs that are not to be blocked if the boolean value is "true".</para>
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnDeviceRemoteBlock"/> event which includes a "success" property that is set to true or false and a "blocked" property which contains the URL which was blocked. The application can ignore this URL or use the <see cref="XdkDevice.ShowRemoteSite">device.ShowRemoteSite</see> method to view it instead.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceRemoteBlock"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void InitBlockRemotePages()
        /// {
        ///     //Set up a list of domains for which you allow remote pages
        ///     var whitelist = "www.cnn.com|www.appmobi.com:44|www.aol.com";
        ///     //Set up a list of domains for which you allow remote pages
        ///     Xdk.device.BlockRemotePages(true, whitelist);
        ///     Xdk.OnDeviceRemoteBlock += Xdk_DeviceRemoteBlock;
        /// }
        /// static void Xdk_DeviceRemoteBlock(DeviceRemoteEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert(evt.blocked + "ignored");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="shouldBlock">This boolean value controls whether the application should block remote pages or not.</param>
        /// <param name="whitelist">This parameter is a "|" delimited list of of domains and or domain:port combos that are NOT to be blocked if shouldblock=true.</param>
        [JsMethod(Name = "blockRemotePages")]
        public void BlockRemotePages(bool shouldBlock, JsString whitelist) { }
        /// <summary>
        /// This method will open a full-screen QR code reader in an application
        /// </summary>
        /// <remarks>
        /// This function will open a full-scren QR code reader in an application. Once it successfully reads a QR code, or the reader is cancelled, the <see cref="Xdk.OnDeviceBarcodeScan"/> event is called.
        /// <para>For details about QR code: http://en.wikipedia.org/wiki/QR_code .</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceBarcodeScan"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// public static void InitScanBarCode()
        /// {
        ///     Xdk.OnDeviceBarcodeScan += Xdk_DeviceBarcodeScan;
        ///     Xdk.device.ScanBarcode();
        /// }
        /// static void Xdk_DeviceBarcodeScan(DeviceBarcodeEvent evt)
        /// {
        ///     Xdk.notification.Beep(1);
        ///     if (evt.success == true)
        ///     {
        ///         //successful scan
        ///         HtmlContext.console.Log(evt.codeData);
        ///         if (evt.codeData == "http://www.sampleurl.com/fake.html")
        ///         {
        ///             //in the XDK
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert(evt.codeData);
        ///         }
        ///     }
        ///     else
        ///     {
        ///         //failed scan
        ///         HtmlContext.console.Log("failed scan");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "scanBarcode")]
        public void ScanBarcode() { }
        /// <summary>
        /// This method will open an email view to send an email without exiting the application
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bodyText = "I am having trouble with building my app";
        /// Xdk.device.SendEmail(bodyText, "html5tools@intel.com.com", "I Need Help", true, "", "" ); 
        /// </code>
        /// </example>
        /// <param name="bodyText">This mandatory parameter includes the body of the email to send</param>
        /// <param name="toString">Comma separated JsString of email addresses to send email to</param>
        /// <param name="subjectText">Content of the email subject line</param>
        /// <param name="isHTML">A boolean value indicating whether body is to be sent in HTML format or not</param>
        /// <param name="ccString">Comma separated JsString of email addresses to be CCed</param>
        /// <param name="bccString">Comma separated JsString of email addresses to be BCCed</param>
        [JsMethod(Name = "sendEmail")]
        public void SendEmail(JsString bodyText, JsString toString, JsString subjectText, bool isHTML, JsString ccString, JsString bccString) { }
        /// <summary>
        /// This method will send an SMS message
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var bodyText = "I am at XYZ if you want to join me";
        /// Xdk.device.SendSms(bodyText, "7175551234");
        /// </code>
        /// </example>
        /// <param name="bodyText">Content of the message body.</param>
        /// <param name="toNumber">String containing number to send message.</param>
        [JsMethod(Name = "sendSms")]
        public void SendSms(JsString bodyText, JsString toNumber) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <remarks>
        /// It is an alternative to the HTML XMLHttpRequest function.
        /// <para>The url parameter should hold the URL to request the XML data from. The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands. The successCallback should hold the name of a function with a single parameter holding the data returned from the success. The errorCallback should hold the name of a similar function with a single parameter holding the data returned from the error.</para>
        /// <para>Any line breaks returned from a <see cref="GetRemoteDataWithId"/> will be replaced with a JsString of "\n".</para>
        /// <para>Please note that the callback properties are both strings with the names of the <see cref="XdkRemoteDataWithIdCallback"/> functions, not the functions themselves.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void GetRemoteDataWithId()
        /// {
        ///     //GET method example
        ///     var uniqueId = 12345;
        ///     Xdk.device.GetRemoteDataWithId("http://twitter.com/statuses/public_timeline.xml", GetPost.Get, "", "SuccessHandler", "ErrorHandler", uniqueId);
        ///     //POST method example
        ///     Xdk.device.GetRemoteDataWithId("http://twitter.com/statuses/public_timeline.xml", GetPost.Post, "E-MAIL=html5tools@intel.com&amp;TEST=1&amp;MAX=0", "SuccessHandler", "ErrorHandler", uniqueId);
        /// }
        /// //Example Event Handlers
        /// public static void SuccessHandler(long uniqueId, object data)
        /// {
        ///     HtmlContext.Alert("success: " + data);
        /// }
        /// public static void ErrorHandler(long uniqueId, object data)
        /// {
        ///     HtmlContext.Alert("error: " + data);
        /// }
        /// </code>
        /// </example>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The name of the the success function of type <see cref="XdkRemoteDataWithIdCallback"/>.</param>
        /// <param name="errorCallback">The name of the the error function of type <see cref="XdkRemoteDataWithIdCallback"/>.</param>
        /// <param name="uniqueIdentifier">A unique identifier that will be returned with the success or error callback function.</param>
        [JsMethod(Name = "getRemoteDataWithID")]
        public void GetRemoteDataWithId(JsString url, GetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback, long uniqueIdentifier) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <remarks>
        /// It is an alternative to the HTML XMLHttpRequest function.
        /// <para>The url parameter should hold the URL to request the XML data from. The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands. The successCallback should hold the name of a function with a single parameter holding the data returned from the success. The errorCallback should hold the name of a similar function with a single parameter holding the data returned from the error.</para>
        /// <para>Any line breaks returned from a <see cref="GetRemoteData"/> will be replaced with a JsString of "\n".</para>
        /// <para>Please note that the callback properties are both strings with the names of the <see cref="XdkRemoteDataCallback"/> functions, not the functions themselves.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void GetRemoteData()
        /// {
        ///     //GET method example
        ///     var uniqueId = 12345;
        ///     Xdk.device.GetRemoteData("http://twitter.com/statuses/public_timeline.xml", GetPost.Get, "", "SuccessHandler", "ErrorHandler");
        ///     //POST method example
        ///     Xdk.device.GetRemoteData("http://twitter.com/statuses/public_timeline.xml", GetPost.Post, "E-MAIL=html5tools@intel.com&amp;TEST=1&amp;MAX=0", "SuccessHandler", "ErrorHandler");
        /// }
        /// //Example Event Handlers
        /// public static void SuccessHandler(long uniqueId, object data)
        /// {
        ///     HtmlContext.Alert("success: " + data);
        /// }
        /// public static void ErrorHandler(long uniqueId, object data)
        /// {
        ///     HtmlContext.Alert("error: " + data);
        /// }
        /// </code>
        /// </example>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The name of the the success function of type <see cref="XdkRemoteDataCallback"/>.</param>
        /// <param name="errorCallback">The name of the the error function of type <see cref="XdkRemoteDataCallback"/>.</param>
        [JsMethod(Name = "getRemoteData")]
        public void GetRemoteData(JsString url, GetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <remarks>
        /// This function is used for making background POST/GET requests of XML data. It is an alternative to the HTML XMLHttpRequest function.
        /// <para>The url parameter should hold the URL to request the XML data from. The requestMethod must be either "GET" or "POST". The id parameter should hold a unique ID that may be used to correlate the request to an event. The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</para>
        /// <para>Any line breaks returned from a <see cref="GetRemoteDataExt"/> call will be replaced with a JsString of "\n".</para>
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnDeviceRemoteData"/> event that includes a a response element which contains the server response, and an extras element which contains the name/value pairs for each item in the headers object.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnDeviceRemoteData"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void GetRemote(JsString name, JsString value)
        /// {
        ///     //Example Event Handlers
        ///     Xdk.OnDeviceRemoteData += Xdk_DeviceRemoteData;
        ///     //GET method example
        ///     var parameters = new DeviceRemoteDataParameters();
        ///     parameters.url = "http://twitter.com/statuses/public_timeline.xml";
        ///     parameters.id = "12345";
        ///     Xdk.device.GetRemoteDataExt(parameters);
        ///     //POST method example
        ///     var status = "status=" + "It is good to be alive";
        ///     parameters = new DeviceRemoteDataParameters();
        ///     parameters.url = "http://twitter.com/statuses/public_timeline.xml";
        ///     parameters.id = "12345";
        ///     parameters.method = GetPost.Post;
        ///     parameters.body = status;
        ///     //To add headers call AddHeader
        ///     parameters.AddHeader(name, value);
        ///     Xdk.device.GetRemoteDataExt(parameters);
        /// }
        /// static void Xdk_DeviceRemoteData(DeviceRemoteEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error obtaining remote data");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success: " + evt.response);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="paramsObj"></param>
        [JsMethod(Name = "getRemoteDataExt")]
        public void GetRemoteDataExt(XdkDeviceRemoteDataParameters paramsObj) { }
        /// <summary>
        /// This method will immediately install a waiting Live Update. Following the install, the application will restart itself with the new code. If no update is waiting, this command is ignored.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Confirm"
        /// public static void InstallUpdate(JsString name, JsString value)
        /// {
        ///     Xdk.OnDeviceReady += OnDeviceReadyTestForUpdate;
        /// }
        /// static void OnDeviceReadyTestForUpdate(DeviceEvent evt)
        /// {
        ///     /* Xdk.updateAvailable indicates whether or not an over the air update is available or not. */
        ///     if (Xdk.updateAvailable == true)
        ///     {
        ///         //there is an application update available at startup
        ///         if (HtmlContext.Confirm(Xdk.updateMessage) == true)
        ///         {
        ///             Xdk.device.InstallUpdate();
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "installUpdate")]
        public void InstallUpdate() { }
        /// <summary>
        /// This method will hide the application splash screen earlier than it automatically does
        /// </summary>
        /// <remarks>
        /// This command is intended for use as the last function called in response to the <see cref="Xdk.OnDeviceReady"/> event. Typically, Intel XDK applications will display their splash screen until either the index.html document is completely loaded, or a 15-second limit has been reached. Call this method to force the automated application splash screen to disappear early.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.OnDeviceReady += new EventListener&lt;DeviceEvent&gt;(delegate(DeviceEvent evt){ Xdk.device.HideSplashScreen(); });
        /// </code>
        /// </example>
        [JsMethod(Name = "hideSplashScreen")]
        public void HideSplashScreen() { }
        /// <summary>
        /// This method hides the device status bar
        /// </summary>
        /// <remarks>
        /// Triggering this method will hide the native device's status bar allowing the app to run in a full-screen window.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.OnDeviceReady += new EventListener&lt;DeviceEvent&gt;(delegate(DeviceEvent evt){ Xdk.device.HideStatusBar(); });
        /// </code>
        /// </example>
        [JsMethod(Name = "hideStatusBar")]
        public void HideStatusBar() { }

        /// <summary>
        /// For XDK emulated mode
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orientation"></param>
        [JsMethod(Name = "setOrientation")]
        public void SetOrientation(int orientation) { }
        /// <summary>
        /// For XDK emulated mode
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        /// <summary>
        /// For XDK emulated mode
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="delegateName"></param>
        [JsMethod(Name = "registerLibrary")]
        public void RegisterLibrary(JsString delegateName) { }
        /// <summary>
        /// For XDK emulated mode
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="classNamefunctionName"></param>
        [JsMethod(Name = "pluginExec")]
        public void PluginExec(JsString classNamefunctionName) { }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subdir"></param>
        /// <param name="url"></param>
        [JsMethod(Name = "cachePackage")]
        public void CachePackage(JsString subdir, JsString url) { }

        /// <summary>
        /// This method allows for remote loading of a JavaScript file for Microsoft Windows 8.
        /// </summary>
        /// <remarks>
        /// This method allows for remote loading of a JavaScript file for Microsoft Windows 8 because you can not include script tags loading remote files for this platform.
        /// <para>Additional information can be found here: http://www.jasonfollas.com/blog/post/2012/07/09/Metro-Introducing-the-Local-and-Web-Contexts.aspx .</para>
        /// <para>The data returned to the user for the onLoad and onError parameters will be an xmlHttpResponse object. For more information: http://www.w3.org/TR/XMLHttpRequest/#response </para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void AddScript()
        /// {
        ///     var url = "http://www.somesite.com/script.js";
        ///     Xdk.device.AddRemoteScript(url, OnLoadHandler, OnErrorHandler);
        /// }
        /// //Example Event Handlers
        /// static void OnLoadHandler(XMLHttpRequest data) { HtmlContext.Alert("script file load successful"); }
        /// static void OnErrorHandler(XMLHttpRequest data) { HtmlContext.Alert(data.status + ": " + data.statusText); }
        /// </code>
        /// </example>
        /// <param name="url">The URL of the JavaScript file to load.</param>
        /// <param name="onLoad">A function to handle the successful load of the JavaScript file.</param>
        /// <param name="onError">A function to handle the failed load response.</param>
        [JsMethod(Name = "addRemoteScript")]
        public void AddRemoteScript(JsString url, EventListener<XMLHttpRequest> onLoad, EventListener<XMLHttpRequest> onError) { }
        /// <summary>
        /// Run or install a native app on an Android device.
        /// </summary>
        /// <remarks>
        /// Call this method to run a previously installed native app, or install and run the app if not already installed on the device.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// if (Xdk.device.platform == DevicePlatformType.Android)
        /// {
        ///     Xdk.device.RunInstallNativeApp("Boom Town", "applab.boomtown://", "market://details?id=com.appMobi.applab.boomtown", "com.appMobi.applab.boomtown");
        /// }
        /// </code>
        /// </example>
        /// <param name="appName">The name of the application being loaded.</param>
        /// <param name="protocolHandler">The protocol handler required for the application to run/install</param>
        /// <param name="appLocationUrl">The URL specifying the location of the application to run or install. This URL will be specific to the store from where the app is retrieved.</param>
        /// <param name="bundleId">The full Android bundle ID for the desired store. Example: com.companyname.projectname</param>
        [JsMethod(Name = "runInstallNativeApp")]
        public void RunInstallNativeApp(JsString appName, JsString protocolHandler, JsString appLocationUrl, JsString bundleId) { }
        /// <summary>
        /// Run or install a native app on an iOS device.
        /// </summary>
        /// <remarks>
        /// Call this method to run a previously installed native app, or install and run the app if not already installed on the device.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// if (Xdk.device.platform == DevicePlatformType.iOS)
        /// {
        ///     Xdk.device.RunInstallNativeApp("Old Lady Puzzle", "oldemo.puzzle://", "itms-apps://itunes.apple.com/us/app/old-lady-puzzle/id525537202?mt=8");
        /// }
        /// </code>
        /// </example>
        /// <param name="appName">The name of the application being loaded.</param>
        /// <param name="protocolHandler">The protocol handler required for the application to run/install</param>
        /// <param name="appLocationUrl">The URL specifying the location of the application to run or install. This URL will be specific to the store from where the app is retrieved.</param>
        [JsMethod(Name = "runInstallNativeApp")]
        public void RunInstallNativeApp(JsString appName, JsString protocolHandler, JsString appLocationUrl) { }
        /// <summary>
        /// Run or install a native app on a Windows/Windows Phone device.
        /// </summary>
        /// <remarks>
        /// Call this method to run a previously installed native app, or install and run the app if not already installed on the device.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="appackageDir">Directory of the appackage file</param>
        /// <param name="packageUrl">Url of the package</param>
        [JsMethod(Name = "runInstallNativeApp")]
        public void RunInstallNativeApp(JsString appackageDir, JsString packageUrl) { }
        /// <summary>
        /// DEPRECATED This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The successCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the successful call.</param>
        /// <param name="errorCallback">The errorCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the error.</param>
        /// <param name="uniqueIdentifier">A unique identifier that will be returned with the success or error callback function.</param>
        /// <param name="hasId"></param>
        [JsMethod(Name = "getRemoteDataImpl")]
        private void GetRemoteDataImpl(JsString url, GetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback, JsNumber uniqueIdentifier, bool hasId) { }
    }
    #endregion

    #region Geolocation

    /// <summary>
    /// Make your application aware of where it is currently located
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Geolocation")]
    public partial class XdkGeolocation : Geolocation
    {
        /// <summary>
        /// Use this command to get the current location of the device.
        /// </summary>
        /// <remarks>
        /// Use this command to get the current location. This command asynchronously acquires the approximate latitude and longitude of the device. When data is available, the success function is called. If there is an error getting position data, the error function is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "undefined" or "Alert"
        /// public static void GetLocation()
        /// {
        ///     PositionCallback Suc = delegate(Geoposition p)
        ///     {
        ///         HtmlContext.Alert("geolocation success");
        ///         if (p.coords.latitude as object != HtmlContext.undefined)
        ///         {
        ///             var currentLatitude = p.coords.latitude;
        ///             var currentLongitude = p.coords.longitude;
        ///         }
        ///     };
        ///     PositionErrorCallback Fail = delegate(PositionError p)
        ///     {
        ///         HtmlContext.Alert("geolocation failed");
        ///         GetLocation();
        ///     };
        ///     Xdk.geolocation.GetCurrentPosition(Suc, Fail);
        /// }
        /// </code>
        /// </example>
        /// <param name="successCallback">When data is available, this success function is called.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public new void GetCurrentPosition(PositionCallback successCallback) { }
        /// <summary>
        /// Use this command to get the current location of the device.
        /// </summary>
        /// <remarks>
        /// Use this command to get the current location. This command asynchronously acquires the approximate latitude and longitude of the device. When data is available, the success function is called. If there is an error getting position data, the error function is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "undefined" or "Alert"
        /// public static void GetLocation()
        /// {
        ///     PositionCallback Suc = delegate(Geoposition p)
        ///     {
        ///         HtmlContext.Alert("geolocation success");
        ///         if (p.coords.latitude as object != HtmlContext.undefined)
        ///         {
        ///             var currentLatitude = p.coords.latitude;
        ///             var currentLongitude = p.coords.longitude;
        ///         }
        ///     };
        ///     PositionErrorCallback Fail = delegate(PositionError p)
        ///     {
        ///         HtmlContext.Alert("geolocation failed");
        ///         GetLocation();
        ///     };
        ///     Xdk.geolocation.GetCurrentPosition(Suc, Fail);
        /// }
        /// </code>
        /// </example>
        /// <param name="successCallback">When data is available, this success function is called.</param>
        /// <param name="errorCallback">If there is an error getting position data, the error function is called.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public new void GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback) { }
        /// <summary>
        /// Use this command to get the current location of the device.
        /// </summary>
        /// <remarks>
        /// Use this command to get the current location. This command asynchronously acquires the approximate latitude and longitude of the device. When data is available, the success function is called. If there is an error getting position data, the error function is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "undefined" or "Alert"
        /// public static void GetLocation()
        /// {
        ///     PositionCallback Suc = delegate(Geoposition p)
        ///     {
        ///         HtmlContext.Alert("geolocation success");
        ///         if (p.coords.latitude as object != HtmlContext.undefined)
        ///         {
        ///             var currentLatitude = p.coords.latitude;
        ///             var currentLongitude = p.coords.longitude;
        ///         }
        ///     };
        ///     PositionErrorCallback Fail = delegate(PositionError p)
        ///     {
        ///         HtmlContext.Alert("geolocation failed");
        ///         GetLocation();
        ///     };
        ///     Xdk.geolocation.GetCurrentPosition(Suc, Fail);
        /// }
        /// </code>
        /// </example>
        /// <param name="successCallback">When data is available, this success function is called.</param>
        /// <param name="errorCallback">If there is an error getting position data, the error function is called.</param>
        /// <param name="options">Some options may be specified for the method as an object.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public new void GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options) { }
        /// <summary>
        /// Use this command rather than the GetCurrentPosition command to track progress during a trip rather than just getting a single position.
        /// </summary>
        /// <remarks>
        /// Use this command rather than the <see cref="GetCurrentPosition(PositionCallback)">GetCurrentPosition</see> command to track progress during a trip rather than just getting a single position. This command asynchronously acquires the latitude and longitude of the device. When data is available, the success function is called. If there is an error getting position data, the error function is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// // This object holds the options for the command
        /// var options = new PositionOptions() { timeout = 10000, maximumAge = 11000, enableHighAccuracy = true };
        /// // This function is called on every iteration of the watch Position command that fails
        /// PositionErrorCallback Fail = delegate(PositionError p)
        /// {
        ///     HtmlContext.Alert("Geolocation failed. \nPlease enable GPS in Settings.");
        /// };
        /// // This function is called on every iteration of the WatchPosition command that is a success
        /// PositionCallback Suc = delegate(Geoposition p)
        /// {
        ///     HtmlContext.Alert("Moved To: Latitude:" + p.coords.latitude + "Longitude:" + p.coords.longitude);
        /// };
        /// // This command starts watching the geolocation
        /// int geolocationWatchTimer = Xdk.geolocation.WatchPosition(Suc, Fail, options);
        /// // Call the StopGeolocation function to stop the geolocation watch
        /// JsAction StopGeolocation = delegate()
        /// {
        ///     Xdk.geolocation.ClearWatch(geolocationWatchTimer);
        /// };
        /// </code>
        /// </example>
        /// <param name="successCallback">When data is available, this success function is called.</param>
        /// <returns>geolocationWatchTimer</returns>
        [JsMethod(Name = "watchPosition")]
        public new long WatchPosition(PositionCallback successCallback) { return default(long); }
        /// <summary>
        /// Use this command rather than the GetCurrentPosition command to track progress during a trip rather than just getting a single position.
        /// </summary>
        /// <remarks>
        /// Use this command rather than the <see cref="GetCurrentPosition(PositionCallback,PositionErrorCallback)">GetCurrentPosition</see> command to track progress during a trip rather than just getting a single position. This command asynchronously acquires the latitude and longitude of the device. When data is available, the success function is called. If there is an error getting position data, the error function is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// // This object holds the options for the command
        /// var options = new PositionOptions() { timeout = 10000, maximumAge = 11000, enableHighAccuracy = true };
        /// // This function is called on every iteration of the watch Position command that fails
        /// PositionErrorCallback Fail = delegate(PositionError p)
        /// {
        ///     HtmlContext.Alert("Geolocation failed. \nPlease enable GPS in Settings.");
        /// };
        /// // This function is called on every iteration of the WatchPosition command that is a success
        /// PositionCallback Suc = delegate(Geoposition p)
        /// {
        ///     HtmlContext.Alert("Moved To: Latitude:" + p.coords.latitude + "Longitude:" + p.coords.longitude);
        /// };
        /// // This command starts watching the geolocation
        /// int geolocationWatchTimer = Xdk.geolocation.WatchPosition(Suc, Fail, options);
        /// // Call the StopGeolocation function to stop the geolocation watch
        /// JsAction StopGeolocation = delegate()
        /// {
        ///     Xdk.geolocation.ClearWatch(geolocationWatchTimer);
        /// };
        /// </code>
        /// </example>
        /// <param name="successCallback">When data is available, this success function is called.</param>
        /// <param name="errorCallback">If there is an error getting position data, the error function is called.</param>
        /// <returns>geolocationWatchTimer</returns>
        [JsMethod(Name = "watchPosition")]
        public new long WatchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback) { return default(long); }
        /// <summary>
        /// Use this command rather than the GetCurrentPosition command to track progress during a trip rather than just getting a single position.
        /// </summary>
        /// <remarks>
        /// Use this command rather than the <see cref="GetCurrentPosition(PositionCallback,PositionErrorCallback,PositionOptions)">GetCurrentPosition</see> command to track progress during a trip rather than just getting a single position. This command asynchronously acquires the latitude and longitude of the device. When data is available, the success function is called. If there is an error getting position data, the error function is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// // This object holds the options for the command
        /// var options = new PositionOptions() { timeout = 10000, maximumAge = 11000, enableHighAccuracy = true };
        /// // This function is called on every iteration of the watch Position command that fails
        /// PositionErrorCallback Fail = delegate(PositionError p)
        /// {
        ///     HtmlContext.Alert("Geolocation failed. \nPlease enable GPS in Settings.");
        /// };
        /// // This function is called on every iteration of the WatchPosition command that is a success
        /// PositionCallback Suc = delegate(Geoposition p)
        /// {
        ///     HtmlContext.Alert("Moved To: Latitude:" + p.coords.latitude + "Longitude:" + p.coords.longitude);
        /// };
        /// // This command starts watching the geolocation
        /// int geolocationWatchTimer = Xdk.geolocation.WatchPosition(Suc, Fail, options);
        /// // Call the StopGeolocation function to stop the geolocation watch
        /// JsAction StopGeolocation = delegate()
        /// {
        ///     Xdk.geolocation.ClearWatch(geolocationWatchTimer);
        /// };
        /// </code>
        /// </example>
        /// <param name="successCallback">When data is available, this success function is called.</param>
        /// <param name="errorCallback">If there is an error getting position data, the error function is called.</param>
        /// <param name="options">Some options may be specified for the method as an object.</param>
        /// <returns>geolocationWatchTimer</returns>
        [JsMethod(Name = "watchPosition")]
        public new long WatchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options) { return default(long); }
        /// <summary>
        /// This method stops the process started by WatchPosition when it is passed the appropriate watch timer object.
        /// </summary>
        /// <remarks>
        /// See: <see cref="WatchPosition(PositionCallback,PositionErrorCallback,PositionOptions)">Xdk.geolocation.WatchPosition(PositionCallback,PositionErrorCallback,PositionOptions)</see>, <see cref="WatchPosition(PositionCallback,PositionErrorCallback)">Xdk.geolocation.WatchPosition(PositionCallback,PositionErrorCallback)</see>, <see cref="WatchPosition(PositionCallback)">Xdk.geolocation.WatchPosition(PositionCallback)</see> commands.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var geolocationWatchTimer = Xdk.geolocation.WatchPosition(Suc, Fail, options);
        /// Xdk.geolocation.ClearWatch(geolocationWatchTimer);
        /// </code>
        /// </example>
        /// <param name="watchId">The returned watch returned from the previous <see cref="WatchPosition(PositionCallback,PositionErrorCallback,PositionOptions)">Xdk.geolocation.WatchPosition(PositionCallback,PositionErrorCallback,PositionOptions)</see> or <see cref="WatchPosition(PositionCallback,PositionErrorCallback)">Xdk.geolocation.WatchPosition(PositionCallback,PositionErrorCallback)</see> or <see cref="WatchPosition(PositionCallback)">Xdk.geolocation.WatchPosition(PositionCallback)</see> command.</param>
        [JsMethod(Name = "clearWatch")]
        public new void ClearWatch(long watchId) { }
    }
    #endregion

    #region Notification
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkNotificationData
    {
        /// <summary>
        /// Notification's id key
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// Notification's message
        /// </summary>
        public JsString msg { get; set; }
        /// <summary>
        /// Any data sent along with the notification
        /// </summary>
        public JsString data { get; set; }
        [JsProperty(Name = "userkey", NativeField = true)]
        public JsString userKey { get; set; }
        [JsProperty(Name = "richurl", NativeField = true)]
        public JsString richUrl { get; set; }
        [JsProperty(Name = "richhtml", NativeField = true)]
        public JsString richHtml { get; set; }
        public bool isRich { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Notification.PushUserAttributes")]
    public partial class XdkNotificationPushUserAttributes
    {
        public JsString s1 { get; set; }
        public JsString s2 { get; set; }
        public JsString s3 { get; set; }
        public JsString s4 { get; set; }
        public JsString s5 { get; set; }
        public JsString s6 { get; set; }
        public JsNumber n1 { get; set; }
        public JsNumber n2 { get; set; }
        public JsNumber n3 { get; set; }
        public JsNumber n4 { get; set; }
    }
    /// <summary>
    /// Alert the application's user about the application's state using a variety of methods.
    /// </summary>
    /// <remarks>
    /// The notification object allows the developer to alert the user using device-specific capabilities.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnNotificationConfirm"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushAccountmissing"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushDelete"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushDisable"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushEnable"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushRead"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushReceive"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushRefresh"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushRichBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushRichClose"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushSend"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushSendpassword"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushUserEdit"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushUserEditattributes"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnNotificationPushUserFind"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Notification")]
    public partial class XdkNotification
    {
        /// <summary>
        /// This method will display a modal alert box.
        /// </summary>
        /// <remarks>
        /// The message, alert box title, and the text on the confirm button are all defined by the parameters passed to this method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.Alert("Hammertime!");
        /// </code>
        /// </example>
        /// <param name="message">The message to show in the alert box.</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message) { }
        /// <summary>
        /// This method will display a modal alert box.
        /// </summary>
        /// <remarks>
        /// The message, alert box title, and the text on the confirm button are all defined by the parameters passed to this method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.Alert("Hammertime!", "STOP");
        /// </code>
        /// </example>
        /// <param name="message">The message to show in the alert box.</param>
        /// <param name="title">The title to put across the top of the alert box.</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message, JsString title) { }
        /// <summary>
        /// This method will display a modal alert box.
        /// </summary>
        /// <remarks>
        /// The message, alert box title, and the text on the confirm button are all defined by the parameters passed to this method.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.Alert("Hammertime!", "STOP", "Can\'t Touch This");
        /// </code>
        /// </example>
        /// <param name="message">The message to show in the alert box.</param>
        /// <param name="title">The title to put across the top of the alert box.</param>
        /// <param name="buttonText">The text to put on the button that dismisses the alert box.</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message, JsString title, JsString buttonText) { }
        /// <summary>
        /// This method will display a modal alert box with confirmation options.
        /// </summary>
        /// <remarks>
        /// This method will display a modal alert box that allows the user to confirm or ignore the message. The message text, function to execute on confirmation event being thrown, title, and the text for the confirm and dismiss buttons are all defined by the parameters passed to this method.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationConfirm"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// public static void NotificationConfirm()
        /// {
        ///     //  Set up confirmation event listener
        ///     Xdk.NotificationConfirm += ReceiveConfirm;
        ///     //  Display the confimation alert message
        ///     Xdk.notification.Confirm("Launch native maps?", "launchMaps", "Show A Map", "Yes", "No");
        /// }
        /// static void ReceiveConfirm(NotificationEvent evt)
        /// {
        ///     if (evt.id == "launchMaps")
        ///     {
        ///         if (evt.success == true &amp;&amp; evt.answer == true)
        ///         {
        ///             var url = "http://google.com/maps?saddr=35+East+Orange+St+Lancaster,+Harrisburg,+PA+17602&amp;daddr=1600+Pennsylvania+Ave+Washington,+DC+20006";
        ///             // HtmlContext.Alert(url);
        ///             // HtmlContext.console.Log(url);
        ///             Xdk.device.LaunchExternal(url);
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="message">The confirmation message to show in the alert box.</param>
        /// <param name="confirmEventId">Event ID of the confirmation. Used to identify which confirm message to process when event a confirm event is thrown.</param>
        /// <param name="title">The title to put across the top of the alert box.</param>
        /// <param name="confirmButtonText">The text to put on the button that confirms the action shown in the alert box.</param>
        /// <param name="dismissButtonText">The text to put on the button that dismisses the action shown in the alert box.</param>
        [JsMethod(Name = "confirm")]
        public void Confirm(JsString message, JsString confirmEventId, JsString title, JsString confirmButtonText, JsString dismissButtonText) { }
        /// <summary>
        /// This method will make the device to vibrate.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.Vibrate();
        /// </code>
        /// </example>
        [JsMethod(Name = "vibrate")]
        public void Vibrate() { }
        /// <summary>
        /// This method will cause the device to beep.
        /// </summary>
        /// <remarks>
        /// Passing a numeric value will cause it to beep several times in succession. If no parameters are passed, the number of beeps defaults to 1.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.Beep(1);
        /// </code>
        /// </example>
        /// <param name="count">The number of times the device should beep in succession.</param>
        [JsMethod(Name = "beep")]
        public void Beep(long count = 1) { }
        /// <summary>
        /// This method will turn on the device's "working" or "busy" state graphics such as a spinner or an hourglass.
        /// </summary>
        /// <remarks>
        /// Turn this off using the <see cref="XdkNotification.HideBusyIndicator">Xdk.notification.HideBusyIndicator</see> command.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.ShowBusyIndicator();
        /// </code>
        /// </example>
        [JsMethod(Name = "showBusyIndicator")]
        public void ShowBusyIndicator() { }
        /// <summary>
        /// This method will turn off the "working" or "busy" state graphics started by the Xdk.notification.showBusyIndicator method.
        /// </summary>
        /// <remarks>
        /// Turn this on using the <see cref="XdkNotification.ShowBusyIndicator">Xdk.notification.ShowBusyIndicator</see> command.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.notification.HideBusyIndicator(); 
        /// </code>
        /// </example>
        [JsMethod(Name = "hideBusyIndicator")]
        public void HideBusyIndicator() { }
        /// <summary>
        /// Use this method to get a list of id keys to obtain access to the list of available notifications for this user.
        /// </summary>
        /// <remarks>
        ///  It returns a javascript array of keys. This array is valid until an <see cref="Xdk.OnNotificationPushReceive"/> or <see cref="Xdk.OnNotificationPushRefresh"/> event fires or if <see cref="DeletePushNotifications"/> is called.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "@typeof", "Alert" or "Unescape"
        /// public static void GetNotifications()
        /// {
        ///     var myNotifications = Xdk.notification.GetNotificationList();
        ///     var len = myNotifications.length;
        ///     if (len &gt; 0)
        ///     {
        ///         var clearList = new JsArray&lt;JsString&gt;();
        ///         var strMessages = "";
        ///         for (int i = 0; i &lt; len; i++)
        ///         {
        ///             var msgObj = Xdk.notification.GetNotificationData(myNotifications[i]);
        ///             try
        ///             {
        ///                 if (HtmlContext.@typeof(msgObj) == "object" &amp;&amp; msgObj.id == myNotifications[i])
        ///                 {
        ///                     strMessages += HtmlContext.Unescape(msgObj.msg) + "&lt;br&gt;\n";
        ///                     clearList.push(msgObj.id);
        ///                 }
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("Invalid message object");
        ///             }
        ///         }
        ///         HtmlContext.Alert(strMessages);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <returns></returns>
        [JsMethod(Name = "getNotificationList")]
        public JsArray<JsString> GetNotificationList() { return (default(JsArray<JsString>)); }
        /// <summary>
        /// se this method to get any data associated with a notification.
        /// </summary>
        /// <remarks>
        /// This method requires the id key of a particular notification. The id keys can be obtained through the <see cref="GetNotificationList"/> command. This method will return a null if there is no notification for the specified id key found. On a success, it will return an object with the properties "id", "msg", and "data". The "id" property will hold the notification's id key, the "msg" property will hold the notification's message, and the "data" key will hold any data sent along with the notification.
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "@typeof", "Alert" or "Unescape"
        /// public static void GetNotifications()
        /// {
        ///     var myNotifications = Xdk.notification.GetNotificationList();
        ///     var len = myNotifications.length;
        ///     if (len &gt; 0)
        ///     {
        ///         var clearList = new JsArray&lt;JsString&gt;();
        ///         var strMessages = "";
        ///         for (int i = 0; i &lt; len; i++)
        ///         {
        ///             var msgObj = Xdk.notification.GetNotificationData(myNotifications[i]);
        ///             try
        ///             {
        ///                 if (HtmlContext.@typeof(msgObj) == "object" &amp;&amp; msgObj.id == myNotifications[i])
        ///                 {
        ///                     strMessages += HtmlContext.Unescape(msgObj.msg) + "&lt;br&gt;\n";
        ///                     clearList.push(msgObj.id);
        ///                 }
        ///             }
        ///             catch (JsError e)
        ///             {
        ///                 HtmlContext.Alert("Invalid message object");
        ///             }
        ///         }
        ///         HtmlContext.Alert(strMessages);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="id">The id parameter of the message object you would like to get the information from.</param>
        /// <returns>NotificationData object with id, msg and data properties values</returns>
        [JsMethod(Name = "getNotificationData")]
        public XdkNotificationData GetNotificationData(JsString id) { return (default(XdkNotificationData)); }
        /// <summary>
        /// Use this method to confirm the credentials of a user or to log an existing user in on a different device.
        /// </summary>
        /// <remarks>
        /// Use this method to confirm the credentials of a user or to log an existing user in on a different device. This method requires two parameters. The first parameter requires a unique JsString (per Intel XDK application) for this user to be addressable in the push system. The user id may not contain spaces or periods. The second parameter required is the user's password for the push system. Passwords may not contain spaces or periods.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushEnable"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushAccountmissing"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushEnable"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void AddPushUser()
        /// {
        ///     Xdk.NotificationPushEnable += NotificationsRegistered;
        ///     Xdk.notification.AddPushUser("userID", "newpassword", "newEmail@test.com");
        /// }
        /// static void NotificationsRegistered(NotificationPushEvent evt)
        /// {
        ///     var didcheckuser = false;
        ///     if (evt.success.ExactEquals(false))
        ///     {
        ///         if (evt.message == "user already exists")
        ///         {
        ///             Xdk.notification.CheckPushUser("userID", "newpassword");
        ///             didcheckuser = true;
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert("There was an error adding push notifications " + evt.message);
        ///         }
        ///         return;
        ///     }
        ///     HtmlContext.Alert("Notifications Enabled");
        /// }
        /// </code>
        /// </example>
        /// <param name="userId">The unique identifier for a particular push user in the system. This parameter may not contain spaces or periods.</param>
        /// <param name="password">A password for a particular user in the push system. This parameter may not contain spaces or periods.</param>
        [JsMethod(Name = "checkPushUser")]
        public void CheckPushUser(JsString userId, JsString password) { }
        /// <summary>
        /// Use this method to register a new user id on a particular Intel XDK application.
        /// </summary>
        /// <remarks>
        /// Use this method to register a new user id on a particular Intel XDK application with the Intel XDK push service. This method requires three parameters. The first parameter requires a unique JsString (per Intel XDK application) for this user to be addressable in the push system. The user id may not contain spaces or periods. The second parameter required is the user's chosen password for the push system. The password may not contain spaces or periods. The third parameter is the email address that the <see cref="SendPushUserPass"/> function will use when a user asks to retrieve their password.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushEnable"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushAccountmissing"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushEnable"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void AddPushUser()
        /// {
        ///     Xdk.NotificationPushEnable += NotificationsRegistered;
        ///     Xdk.notification.AddPushUser("userID", "newpassword", "newEmail@test.com");
        /// }
        /// static void NotificationsRegistered(NotificationPushEvent evt)
        /// {
        ///     var didcheckuser = false;
        ///     if (evt.success.ExactEquals(false))
        ///     {
        ///         if (evt.message == "user already exists")
        ///         {
        ///             Xdk.notification.CheckPushUser("userID", "newpassword");
        ///             didcheckuser = true;
        ///         }
        ///         else
        ///         {
        ///             HtmlContext.Alert("There was an error adding push notifications " + evt.message);
        ///         }
        ///         return;
        ///     }
        ///     HtmlContext.Alert("Notifications Enabled");
        /// }
        /// </code>
        /// </example>
        /// <param name="userId">A unique JsString (per Intel XDK application) for this user to be addressable in the push system. The user id may not contain spaces or periods.</param>
        /// <param name="password">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        /// <param name="email">The email address that the Xdk.notification.sendPushUserPass command will use to notifiy users about their userID and password information.</param>
        [JsMethod(Name = "addPushUser")]
        public void AddPushUser(JsString userId, JsString password, JsString email) { }
        /// <summary>
        /// Use this method to change the email address and the password associated with the push notification service of an Intel XDK application.
        /// </summary>
        /// <remarks>
        /// Use this method to change the email address and the password associated with the push notification service of an Intel XDK application. This method requires two parameters. The first parameter is the email address that the <see cref="SendPushUserPass"/> function will use when a user asks to retrieve their password. The second parameter required is the user's chosen password for the push system. The password may not contain spaces or periods. To leave either parameter as it was, simply pass an empty JsString instead.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushUserEdit"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushUserEdit"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void EditPushUser()
        /// {
        ///     Xdk.NotificationPushUserEdit += Xdk_NotificationPushUserEdit;
        ///     Xdk.notification.EditPushUser("test@appmobi.com", "newpassword");
        /// }
        /// static void Xdk_NotificationPushUserEdit(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="newEmail">The new email address that the <see cref="SendPushUserPass"/> function will use when a user asks to retrieve their password.</param>
        /// <param name="newPassword">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        [JsMethod(Name = "editPushUser")]
        public void EditPushUser(JsString newEmail, JsString newPassword) { }
        /// <summary>
        /// Use this method to change the email address and the password associated with the push notification service of an Intel XDK application.
        /// </summary>
        /// <remarks>
        /// Use this method to change the email address and the password associated with the push notification service of an Intel XDK application. This method requires two parameters. The first parameter is the email address that the <see cref="SendPushUserPass"/> function will use when a user asks to retrieve their password. The second parameter required is the user's chosen password for the push system. The password may not contain spaces or periods. To leave either parameter as it was, simply pass an empty JsString instead.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushUserEdit"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushUserEdit"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="newEmail">The new email address that the <see cref="SendPushUserPass"/> function will use when a user asks to retrieve their password.</param>
        /// <param name="newPassword">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        /// <param name="newUser"></param>
        [JsMethod(Name = "editPushUser")]
        public void EditPushUser(JsString newEmail, JsString newPassword, JsString newUser) { }
        /// <summary>
        /// Use this method to sign out of push notifications and no longer receive push messages for the application.
        /// </summary>
        /// <remarks>
        /// This method basically signs out of push and the application will no longer receive push messages. The actual "username" remains and can be reactivated at a later time by calling the <see cref="XdkNotification.CheckPushUser">Xdk.notification.CheckPushUser</see> method which will sign the user back in.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushDisable"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushDisable"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void DeletePushUser()
        /// {
        ///     Xdk.NotificationPushDisable += Xdk_NotificationPushDisable;
        ///     Xdk.notification.DeletePushUser();
        /// }
        /// static void Xdk_NotificationPushDisable(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error disabling push messaging");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "deletePushUser")]
        public void DeletePushUser() { }
        /// <summary>
        /// Use this method to send an email message to a user including the password for push notifications for a particular Intel XDK application.
        /// </summary>
        /// <remarks>
        /// The push notification user must be logged on using the <see cref="AddPushUser"/> or <see cref="CheckPushUser"/> commands first.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushSendpassword"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushSendpassword"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void UpdateNotification()
        /// {
        ///     Xdk.NotificationPushSendpassword += Xdk_NotificationPushSendpassword;
        ///     Xdk.notification.SendPushUserPass();
        /// }
        /// static void Xdk_NotificationPushSendpassword(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "sendPushUserPass")]
        public void SendPushUserPass() { }
        /// <summary>
        /// Use this method to associate attributes to a user.
        /// </summary>
        /// <remarks>
        /// This data will be used on the Intel XDK Push Notifications Service Admin Control Panel to allow applications to target push notifications to particular users of an Intel XDK application. This method requires a single parameter, a Javascript object built as described below. The push notification user must be logged on using the <see cref="AddPushUser"/> or <see cref="CheckPushUser"/> commands first. Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushUserEditattributes"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushUserEditattributes"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void SetPushUserAttributes()
        /// {
        ///     Xdk.NotificationPushUserEditattributes += Xdk_NotificationPushUserEditattributes;
        ///     var attributes = new NotificationPushUserAttributes();
        ///     attributes.s1 = "male";         // gender
        ///     attributes.s2 = "Lancaster";     // city
        ///     attributes.s3 = "PA";            // state
        ///     attributes.n1 = 1982;            // birth year
        ///     attributes.n2 = 17602;           // zip code
        ///     Xdk.notification.SetPushUserAttributes(attributes);
        /// }
        /// static void Xdk_NotificationPushUserEditattributes(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="attributesObj"></param>
        [JsMethod(Name = "setPushUserAttributes")]
        public void SetPushUserAttributes(XdkNotificationPushUserAttributes attributesObj) { }
        /// <summary>
        /// Use this method to allow users to find other users of an Intel XDK application. It provides a kind of "friends" functionality.
        /// </summary>
        /// <remarks>
        /// This method requires two parameters. The first parameter is a unique user id to look for in the messaging database of the application. The second parameter is an email address to look for in the messaging database of the application. One or both parameters may be specified. Pass an empty JsString to one parameter to search only by the other. Passing both parameters will default to a search on the user id. If both parameters are sent as an empty JsString, a random user will be selected from the messaging database.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushUserFind"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error. On a success, this event will additionally include a "userid" property that contains a matching user id.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushUserFind"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void FindPushUser()
        /// {
        ///     Xdk.NotificationPushUserFind += Xdk_NotificationPushUserFind;
        ///     Xdk.notification.FindPushUser("testUserID", "TestUser@appmobi.com");
        /// }
        /// static void Xdk_NotificationPushUserFind(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="userId">A unique user id to look for in the messaging database of the application.</param>
        /// <param name="emailAddress">An email address to look for in the messaging database of the application.</param>
        [JsMethod(Name = "findPushUser")]
        public void FindPushUser(JsString userId, JsString emailAddress) { }
        /// <summary>
        /// Use this method to allow users to force a user's device to re-synchronize notifications between this device and the database on the server.
        /// </summary>
        /// <remarks>
        /// Use this method to allow users to force a user's device to re-synchronize notifications between this device and the database on the server.
        /// <para>Generally this function is not needed, but this method is featured to force fresh data to be returned.</para>
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushRefresh"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushRefresh"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void RefreshPushNotifications()
        /// {
        ///     Xdk.NotificationPushRefresh += Xdk_NotificationPushRefresh;
        ///     Xdk.notification.RefreshPushNotifications();
        /// }
        /// static void Xdk_NotificationPushRefresh(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "refreshPushNotifications")]
        public void RefreshPushNotifications() { }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// </code>
        /// </example>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="device"></param>
        /// <param name="newerthan"></param>
        [JsMethod(Name = "refreshUserPushNotifications")]
        public void RefreshUserPushNotifications(JsString user, JsString pass, JsString device, JsString newerthan) { } // TODO verify type
        /// <summary>
        /// DEPRECATED: use <see cref="XdkNotification.DeletePushNotifications">DeletePushNotifications</see> instead
        /// </summary>
        /// <remarks>
        /// Use this method to remove notifications from the server.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushRead"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notificationIds">A pipe ("|") delimited list of notification ids to mark as read and remove from the system. The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</param>
        [JsMethod(Name = "readPushNotifications")]
        private void ReadPushNotifications(JsString notificationIds) { }

        /// <summary>
        /// Use this method to remove notifications from the server. This method replaces the ReadPushNotifications method which is being deprecated.
        /// </summary>
        /// <remarks>
        /// This method requires a single parameter, a pipe ("|") delimited list of notification ids to mark as read and remove from the system.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushDelete"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Note that the emulated method contains another parameter: CallModeNotifications callMode </para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushDelete"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void DeletePushNotifications()
        /// {
        ///     Xdk.NotificationPushDelete += Xdk_NotificationPushDelete;
        ///     var clearList = new JsArray&lt;JsString&gt;();
        ///     //clearList must contain notification ids
        ///     if (clearList.length > 0)
        ///     {
        ///         Xdk.notification.DeletePushNotifications(clearList.join("|"));
        ///     }
        /// }
        /// static void Xdk_NotificationPushDelete(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="notificationIds">A pipe ("|") delimited list of notification ids to mark as read and remove from the system. The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</param>
        [JsMethod(Name = "deletePushNotifications")]
        public void DeletePushNotifications(JsString notificationIds) { }
        /// <summary>
        /// Use this method to send a push notification to another user of an application.
        /// </summary>
        /// <remarks>
        /// This method requires three parameters. The first parameter is the user id of the user to send the message to, the second parameter is the message text to send, and the third parameter is any extra application-specific data that should be attached to the notification. The third parameter can be anything and is simply passed along to the receiving application.
        /// <para>Following a call to this method, it will fire the <see cref="Xdk.OnNotificationPushSend"/> event that includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</para>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushSend"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void SendPushNotification(JsString myUserId, JsString msg)
        /// {
        ///     //myUserID is a variable that holds the id to send the message to
        ///     //msg is a variable that holds the message text
        ///     Xdk.NotificationPushSend += Xdk_NotificationPushSend;
        ///     Xdk.notification.SendPushNotification(myUserId, msg, "");
        /// }
        /// static void Xdk_NotificationPushSend(NotificationPushEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.message);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert("success");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="userId">The unique user identification of the user to send the message to.</param>
        /// <param name="message">The text of the message to send.</param>
        /// <param name="data">A JsString of text that is sent along to be interpreted by the receiving device, but not automatically displayed.</param>
        [JsMethod(Name = "sendPushNotification")]
        public void SendPushNotification(JsString userId, JsString message, JsString data) { }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// </code>
        /// </example>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="attributes"></param>
        /// <param name="skip"></param>
        [JsMethod(Name = "broadcastPushNotification")]
        public void BroadcastPushNotification(JsString message, JsString data, XdkNotificationPushUserAttributes attributes, bool skip) { }   // TODO verify type
        /// <summary>
        /// Use this method to display a rich push message
        /// </summary>
        /// <remarks>
        /// This method will open the media component of a rich push message in a full screen view and display the back button associated with the application.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushRichBusy"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushRichClose"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "undefined"
        /// public static void SendPushNotification(JsString myUserId, JsString msg)
        /// {
        ///     Xdk.NotificationPushReceive += UpdateNotifications;
        ///     Xdk.NotificationPushRefresh += UpdateNotifications;
        ///     // [...]
        /// }
        /// static void UpdateNotifications(NotificationPushEvent evt)
        /// {
        ///     var myNotifications = Xdk.notification.GetNotificationList();
        ///     var len = myNotifications.length;
        ///     for (int i = 0; i &lt; len; i++)
        ///     {
        ///         //get the pushMobi message data
        ///         var msgObj = Xdk.notification.GetNotificationData(myNotifications[i]);
        ///         //display the pushMobi message as a notification if there is no data
        ///         if (msgObj.richHtml.ExactEquals(HtmlContext.undefined) &amp;&amp; msgObj.richUrl.ExactEquals(HtmlContext.undefined))
        ///         {
        ///             Xdk.notification.Alert(msgObj.msg, "pushMobi Message", "OK");
        ///         }
        ///         else
        ///         {
        ///             Xdk.notification.ShowRichPushViewer(msgObj.id, 10, 10, 100, 100, 80, 80);
        ///         }
        ///         //remove the message from the server
        ///         Xdk.notification.DeletePushNotifications(msgObj.id);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="notificationId">The unique identifier of the message to display.</param>
        /// <param name="closeImagePortraitX">The horizontal position of the image used to close the rich push message in terms of pixels from the left edge of the application. This value is used when the application is in portrait orientation.</param>
        /// <param name="closeImagePortraitY">The vertical position of the image used to close the rich push message in terms of pixels from the top edge of the application. This value is used when the application is in portrait orientation.</param>
        /// <param name="closeImageLandscapeX">The horizontal position of the image used to close the rich push message in terms of pixels from the left edge of the application. This value is used when the application is in landscape orientation.</param>
        /// <param name="closeImageLandscapeY">The vertical position of the image used to close the rich push message in terms of pixels from the top edge of the application. This value is used when the application is in landscape orientation.</param>
        /// <param name="closeImageWidth">The width of the image used to close the rich push message and return to the application.</param>
        /// <param name="closeImageHeight">The height of the image used to close the rich push message and return to the application.</param>
        [JsMethod(Name = "showRichPushViewer")]
        public void ShowRichPushViewer(JsString notificationId, long closeImagePortraitX, long closeImagePortraitY, long closeImageLandscapeX, long closeImageLandscapeY, long closeImageWidth, long closeImageHeight) { }
        /// <summary>
        /// This information will force a rich push message to close.
        /// </summary>
        /// <remarks>
        /// It is called from the application in response to an event to dismiss a rich push message and continue with the application.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnNotificationPushRichClose"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "setTimeout"
        /// Xdk.notification.ShowRichPushViewer(msgObj.id, 100, 100, 350, 10);
        /// //force the rich message to close after 5 seconds
        /// HtmlContext.setTimeout("Xdk.notification.closeRichPushViewer();".As&lt;JsAction&gt;(), 5000);
        /// </code>
        /// </example>
        [JsMethod(Name = "closeRichPushViewer")]
        public void CloseRichPushViewer() { }
    }
    #endregion

    #region Display
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkViewport
    {
        /// <summary>
        /// This property returns the visible screen width (in pixels) on the device for landscape
        /// </summary>
        [JsProperty(Name = "landscapeWidth", NativeField = true)]
        public JsNumber landscapeWidth { get; set; }
        /// <summary>
        /// This property returns the visible screen width (in pixels) on the device for portrait
        /// </summary>
        [JsProperty(Name = "portraitWidth", NativeField = true)]
        public JsNumber portraitWidth { get; set; }
        /// <summary>
        /// This property returns the visible screen height (in pixels) on the device for landscape
        /// </summary>
        [JsProperty(Name = "landscapeHeight", NativeField = true)]
        public JsNumber landscapeHeight { get; set; }
        /// <summary>
        /// This property returns the visible screen height (in pixels) on the device for portrait
        /// </summary>
        [JsProperty(Name = "portraitHeight", NativeField = true)]
        public JsNumber portraitHeight { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkDisplayWindow
    {
        /// <summary>
        /// This property returns the visible screen width (in pixels) on the device for landscape
        /// </summary>
        [JsProperty(Name = "landwidth", NativeField = true)]
        public JsNumber landscapeWidth { get; set; }
        /// <summary>
        /// This property returns the visible screen width (in pixels) on the device for portrait
        /// </summary>
        [JsProperty(Name = "portwidth", NativeField = true)]
        public JsNumber portraitWidth { get; set; }
        /// <summary>
        /// This property returns the visible screen height (in pixels) on the device for landscape
        /// </summary>
        [JsProperty(Name = "landheight", NativeField = true)]
        public JsNumber landscapeHeight { get; set; }
        /// <summary>
        /// This property returns the visible screen height (in pixels) on the device for portrait
        /// </summary>
        [JsProperty(Name = "portheight", NativeField = true)]
        public JsNumber portraitHeight { get; set; }
    }
    /// <summary>
    /// Take control of the device's video display properties.
    /// </summary>
    /// <remarks>
    /// The display object gives the application control over aspects of the device's video display properties.
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Display")]
    public partial class XdkDisplay
    {
        public XdkDisplayWindow display { get; set; }
        public XdkViewport viewport { get; set; }
        [JsProperty(Name = "oldviewport", NativeField = true)]
        public XdkViewport oldViewport { get; set; }
        /* deprecated
                public Document doc { get; set; }
        */
        /// <summary>
        /// This method triggers Intel XDK's augmented reality mode.
        /// </summary>
        /// <remarks>
        /// This method triggers Intel XDK's augmented reality mode. In this mode of operation, the application's background will show the camera input. In order to take advantage of this setting, the application's tag must include the CSS style "background-color:transparent".
        /// <para>Please note that augmented reality mode is not available on all platforms and devices due to hardware requirements.</para>
        /// <para>Augmented reality mode will lock to a particular orientation at startup.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.display.StartAR();
        /// </code>
        /// </example>
        [JsMethod(Name = "startAR")]
        public void StartAR() { }
        /// <summary>
        /// This method turns off augmented reality mode.
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.display.StopAR();
        /// </code>
        /// </example>
        [JsMethod(Name = "stopAR")]
        public void StopAR() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        [JsMethod(Name = "updateViewportContent")]
        public void UpdateViewportContent(JsString content) { }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orientation"></param>
        [JsMethod(Name = "updateViewportOrientation")]
        public void UpdateViewportOrientation(int orientation) { }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evt"></param>
        [JsMethod(Name = "viewportOrientationListener")]
        public void ViewportOrientationListener(DeviceOrientationEvent evt) { }

        /// <summary>
        /// This method tells Intel XDK to size down an application for a smaller device.
        /// </summary>
        /// <remarks>
        /// This method tells Intel XDK to size down an application for a smaller device. Use this method in your application's <see cref="Xdk.OnDeviceReady"/> event to size a larger application down for use on a smaller device than it was originally designed for. 
        /// <para>This method expects two values, the first is the width the application is designed for in portrait orientation, and the second is the width the application is designed for in landscape orientation.</para>
        /// <para>Unfortunately, several newer Android devices have changed their version of the Android operating system to a point that this command does not work. At this point, the list of devices that are known to ignore this functionality include:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>HTC EVO 4G</description>
        /// </item>
        /// <item>
        /// <description>HTC Legend</description>
        /// </item>
        /// <item>
        /// <description>HTC Evolution 4G</description>
        /// </item>
        /// <item>
        /// <description>HTC Thunderbolt</description>
        /// </item>
        /// <item>
        /// <description>HTC Sensation</description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // use Intel XDK viewport to allow this iPad-designed application to size down to an iPhone
        /// // or an Android handset device with a resolution lower than 1024x768.
        /// var iPortraitWidth=768;
        /// var iLandscapeWidth=1024;
        /// Xdk.display.UseViewport(iPortraitWidth, iLandscapeWidth);
        /// </code>
        /// </example>
        /// <param name="portraitWidthInPx">The width to set the device to display at in pixels when the device is in portrait orientation.</param>
        /// <param name="landscapeWidthInPx">The width to set the device to display at in pixels when the device is in landscape orientation.</param>
        [JsMethod(Name = "useViewport")]
        public void UseViewport(long portraitWidthInPx, long landscapeWidthInPx) { }

        /// <summary>
        /// This method guarantees that the values you send in are always completely visible and the smaller dimension will be filled completely.
        /// </summary>
        /// <remarks>
        /// IMPORTANT NOTE: This method calls <see cref="UseViewport"/> internally, so you should NOT use LockViewportWindow and <see cref="UseViewport"/> together. 
        /// <para>This method guarantees that the values you send in are always completely visible and the smaller dimension will be filled completely. The placement will always be to the top, left (0,0) which means that there will be extra visible space on the right(landscape) and the bottom(portrait) on devices that have a higher aspect ratio.</para>
        /// <para>This will scale up or down accordingly, but is mainly intended to be used to scale down as a best practice.</para>
        /// <para>It is suggested that you design for iPad since it has the lowest aspect ratio and then scale down to any other device. The iPad settings would be:</para>
        /// <para>Xdk.display.LockViewportWindow(768, 1004, 1024, 748);</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// //use LockViewportWindow to guarantee that the screen is completely visible with the smaller dimension completely filled.  Size for iPad.
        /// var iPortraitWidth=768;
        /// var iPortraitHeight=1004;
        /// var iLandscapeWidth=1024;
        /// var iLandscapeHeight=748;
        /// Xdk.display.LockViewportWindow(iPortraitWidth, iPortraitHeight, iLandscapeWidth, iLandscapeHeight);
        /// </code>
        /// </example>
        /// <param name="portwidth">The width to set the Viewport window to display at in pixels when the device is in portrait orientation.</param>
        /// <param name="portheight">The height to set the Viewport window to display at in pixels when the device is in portrait orientation.</param>
        /// <param name="landwidth">The width to set the Viewport window to display at in pixels when the device is in landscape orientation.</param>
        /// <param name="landheight">The height to set the Viewport window to display at in pixels when the device is in landscape orientation.</param>
        [JsMethod(Name = "lockViewportWindow")]
        public void LockViewportWindow(JsNumber portwidth, JsNumber portheight, JsNumber landwidth, JsNumber landheight) { }

        /// <summary>
        /// Turns on Intel XDK managed viewport
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="portraitWidthInPx"></param>
        /// <param name="landscapeWidthInPx"></param>
        [JsMethod(Name = "switchViewport")]
        public void SwitchViewport(long portraitWidthInPx, long landscapeWidthInPx) { }
        [JsMethod(Name = "revertViewport")]
        public void RevertViewport() { }
    }
    #endregion

    #region DataParameters (for DeviceRemoteDataParameters and for OAuthProtectedDataParameters)
    /// <summary>
    /// 
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public abstract partial class DataParametersBase
    {
        /// <summary>
        /// The URL of the page to access
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        /// ID that correlates the request to the event
        /// </summary>
        public JsString id { get; set; }
        /// <summary>
        /// The method to use for the request. This parameter should be either "GET" or "POST". Default is "GET".
        /// </summary>
        public GetPost method { get; set; }
        /// <summary>
        /// post data for a "POST" method request in a name=value format separated by ampersands
        /// </summary>
        public JsString body { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsString headers { get; set; }

        /// <summary>
        /// Add header to the headers JsString (value is converted in JsString).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        [JsMethod(Name = "addHeader")]
        public void AddHeader(JsString name, object value) { }
    }
    #endregion

    #region OAuth

    [JsType(Mode = JsMode.Prototype, Export = false, PropertiesAsFields = true, Name = "intel.xdk.OAuth.ProtectedDataParameters")]
    public partial class XdkOAuthProtectedDataParameters : DataParametersBase
    {
        /// <summary>
        /// The name given to the OAuth service within App Dev Center.
        /// </summary>
        public JsString service { get; set; }
    }

    /// <summary>
    /// Authorize or revoke authorization for a service such as Twitter or LinkedIn
    /// </summary>
    /// <remarks>
    /// The oAuth object is used to Authorize or remove authorization for a service such as Twitter or LinkedIn within the application.
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnOAuthProtectedData"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnOAuthUnauthorize"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnOAuthUnavailable"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnOAuthBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnOAuthSetup"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.OAuth")]
    public partial class XdkOAuth
    {
        /// <summary>
        /// This method removes authorization for a service that had previously been authorized.
        /// </summary>
        /// <remarks>
        /// This function will remove authorization for a service that had been previously authorized within the application.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnOAuthUnauthorize"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnOAuthUnavailable"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnOAuthBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// Xdk.oauth.UnauthorizeService("twitter");
        /// </code>
        /// </example>
        /// <param name="service">The name of the service to unauthorize (i.e. "twitter")</param>
        [JsMethod(Name = "unauthorizeService")]
        public void UnauthorizeService(JsString service) { }
        /// <summary>
        /// This method is used to get oauth authorization for a service, or update oauth protected data for a service once authorization is received.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnOAuthProtectedData"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnOAuthUnavailable"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnOAuthBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert"
        /// public static void GetTwitterData()
        /// {
        ///     Xdk.OAuthProtectedData += GetProtectedDataEvent;
        ///     //GET method example
        ///     var parameters = new OAuthProtectedDataParameters();
        ///     parameters.service = "twitter";
        ///     parameters.url = "https://api.twitter.com/1/account/verify_credentials.xml";
        ///     parameters.id = "tweet_get";
        ///     Xdk.oAuth.GetProtectedData(parameters);
        ///     //POST method example
        ///     var status = "status=" + "It's good to be alive";
        ///     parameters = new OAuthProtectedDataParameters();
        ///     parameters.service = "twitter";
        ///     parameters.url = "https://api.twitter.com/1/statuses/update.xml";
        ///     parameters.id = "tweet_update";
        ///     parameters.method = GetPost.Post;
        ///     parameters.body = status;
        ///     Xdk.oAuth.GetProtectedData(parameters);
        /// }
        /// //Example Event Handlers
        /// static void GetProtectedDataEvent(OAuthEvent evt)
        /// {
        ///     if (evt.success == false)
        ///     {
        ///         HtmlContext.Alert("error: " + evt.error);
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.Alert(evt.id + " ~~~ " + evt.response);
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="parameters"></param>
        [JsMethod(Name = "getProtectedData")]
        public void GetProtectedData(XdkOAuthProtectedDataParameters parameters) { }
    }
    #endregion

    #region Facebook (parameters to be completed)

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookDataEvent
    {
        public JsString path { get; set; }
        public XdkFacebookParametersBase parameters { get; set; }
        public GetPost method { get; set; }
        public object data { get; set; }    // ie: JsArray<FacebookParametersFriends>
    }

    /// <summary>
    /// TODO: FBParameters classes to complete, see https://fbdevwiki.com/wiki/FB.ui
    /// </summary>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersBase
    {
        public GetPost method { get; set; }
        public JsString display { get; set; }

        //        public JsString message { get; set; }
        //        public JsString urls { get; set; }
        //        public JsNumber limit { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersAppRequest : XdkFacebookParametersBase
    {
        public JsString to { get; set; }
        public JsString data { get; set; }
        public JsString title { get; set; }
        public JsString message { get; set; }
        /*
        filters	 JSON	 Optional, default is "", which shows a selector that includes the ability for a user to browse all friends, but also filter to friends using the application and friends not using the application. Can also be all, app_users and app_non_users. This controls what set of friends the user sees if a friend selector is shown. If all, app_users and app_non_users is specified, the user will only be able to see users in that list and will not be able to filter to another list. Additionally, an application can suggest custom filters as dictionaries with a name key and a user_ids key, which respectively have values that are a JsString and a list of user ids. name is the name of the custom filter that will show in the selector. user_ids is the list of friends to include, in the order they are to appear.	 Optional	 Example #1
        [{name: ‘Neighbors', user_ids: [1, 2, 3]}, {name: ‘Other Set', user_ids: [4,5,6]}]
        Example #2 [‘app_users']
         */
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersSend : XdkFacebookParametersBase
    {
        public JsString name { get; set; }
        public JsString description { get; set; }
        public JsString redirect_uri { get; set; }
        public JsString link { get; set; }
        public JsString picture { get; set; }
        public JsString to { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersStreamShare : XdkFacebookParametersBase
    {
        public JsString u { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersPermissionsRequest : XdkFacebookParametersBase
    {
        public JsString perms { get; set; }
        public bool enable_profile_selector { get; set; }
        public JsArray<JsString> profile_selector_ids { get; set; }
    }
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersFriends : XdkFacebookParametersBase
    {
        public JsString id { get; set; }
        public JsString name { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkFacebookParametersFeed : XdkFacebookParametersBase
    {
        public JsString name { get; set; }
        public JsString description { get; set; }
        public JsString caption { get; set; }
        public JsString link { get; set; }
        public JsString picture { get; set; }
        public JsString message { get; set; }
        public JsString user_message_prompt { get; set; }
        /*
        actions	 JSON	 action link added below a posting; only one allowed	 Optional	actions: [{name: 'fbrell', link: 'http://fbrell.com/'}]
        properties	 JSON	 JSON encoded object that gets displayed as a list of key-values below the "description". Example: "1" : {"text":"link text", "href":"http://example.com/"} will show "1: link text" where "link text" is a hotlink to example.com	 Optional	properties: ["1" : {"text":"link text", "href":"http://example.com/"}]
         */
    }
    /// <summary>
    /// Integrate your application with Facebook.
    /// </summary>
    /// <remarks>
    /// This object gives applications the capability to log users into Facebook in order to access their Facebook Graph as well as to post to the news feed and share request dialogs.
    /// <para>For more information on on how to use the Facebook JavaScript API commands in a native application, get the Facebook Integration document: http://www.html5dev-software.intel.com/amdocs/lib/Article-FacebookIntegration.pdf .</para>
    /// <para>Events:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Xdk.OnFacebookLogin"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFacebookLogout"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFacebookRequestResponse"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFacebookDialogComplete"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFacebookDialogFail"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFacebookBusy"/></description>
    /// </item>
    /// <item>
    /// <description><see cref="Xdk.OnFacebookSessionInvalidate"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Facebook")]
    public partial class XdkFacebook
    {
        public bool isSessionValid { get; set; }

        /// <summary>
        /// This method logs the user into Facebook.
        /// </summary>
        /// <remarks>
        /// When it is run, a dialog generated by Facebook should appear allowing the user to enter their credentials. Depending on the result of that interaction with Facebook, the application will receive a <see cref="Xdk.OnFacebookLogin"/> event indicating whether the login was successful or not. This method will log the user in with a series of default permissions if no permissions parameter is specified.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFacebookLogin"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// public static void LoginFacebook()
        /// {
        ///     HtmlContext.Alert("about to log into facebook");
        ///     Xdk.FacebookLogin += Xdk_FacebookLogin;
        ///     Xdk.facebook.Login("publish_stream,publish_actions,offline_access");
        /// }
        /// static void Xdk_FacebookLogin(FacebookEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.console.Log("Facebook Log in Successful");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.console.Log("Unsuccessful Login");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="permissions"></param>
        [JsMethod(Name = "login")]
        public void Login(JsString permissions) { }
        /// <summary>
        /// This method logs the user out of Facebook.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFacebookLogout"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "Alert" or "console"
        /// public static void LogoutFacebook()
        /// {
        ///     HtmlContext.Alert("logging out of facebook");
        ///     Xdk.FacebookLogout += Xdk_FacebookLogout;
        ///     Xdk.facebook.Logout();
        /// }
        /// static void Xdk_FacebookLogout(FacebookEvent evt)
        /// {
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.console.Log("Logged out of Facebook");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.console.Log("Unsuccessful Logout");
        ///     }
        /// }
        /// </code>
        /// </example>
        [JsMethod(Name = "logout")]
        public void Logout() { }
        /* deprecated
                /// <summary>
                /// DEPRECATED: use <see cref="RequestWithGraphAPI"/> instead. 
                /// <para>This method makes calls to the older REST Facebook API.</para>
                /// </summary>
                /// <remarks>
                /// This method is used to make a request using the older Facebook REST API. This API is being deprecated by Facebook, and may not be available in the future.
                /// <para>Events:</para>
                /// <list type="bullet">
                /// <item>
                /// <description><see cref="Xdk.FacebookRequestResponse"/></description>
                /// </item>
                /// <item>
                /// <description><see cref="Xdk.FacebookBusy"/></description>
                /// </item>
                /// </list>
                /// <para>Available Platforms:</para>
                /// <list type="bullet">
                /// <item>
                /// <description>Apple iOS</description>
                /// </item>
                /// <item>
                /// <description>Google Android</description>
                /// </item>
                /// <item>
                /// <description>Microsoft Windows 8</description>
                /// </item>
                /// <item>
                /// <description>Microsoft Windows Phone 8</description>
                /// </item>
                /// <item>
                /// <description>XDK emulated mode</description>
                /// </item>
                /// </list>
                /// </remarks>
                /// <param name="command">The REST API command to have Facebook execute</param>
                /// <param name="method">The request method to call the Facebook REST API, typically GET or POST</param>
                /// <param name="parameters">Any parameters required for the request</param>
                [JsMethod(Name = "requestWithRestAPI")]
                private void RequestWithRestAPI(JsString command, GetPost method, FacebookParametersBase parameters) { }
         */
        /// <summary>
        /// This method makes calls to the new Graph Facebook API.
        /// </summary>
        /// <remarks>
        /// This method is used to make a request from the newer Facebook Graph API. For more information on this particular API, see Facebook's documentation: http://developers.facebook.com/docs/reference/api/.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFacebookRequestResponse"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "document" or "console"
        /// public static void RequestFacebook()
        /// {
        ///     var facebookUserID = "me";  //me = the user currently logged into Facebook
        ///     Xdk.FacebookRequestResponse += Xdk_FacebookRequestResponse;
        ///     Xdk.facebook.RequestWithGraphAPI(facebookUserID + "/friends", GetPost.Get, new FBParameters());
        /// }
        /// static void Xdk_FacebookRequestResponse(FacebookEvent evt)
        /// {
        ///     HtmlContext.console.Log("Facebook User Friends Data Returned");
        ///     if (evt.success == true)
        ///     {
        ///         var data = evt.data.data;
        ///         var outHTML = "";
        ///         for (var r = 0; r &lt; data.length; r++)
        ///         {
        ///             outHTML += "&lt;img src='http://graph.facebook.com/\" + data[r][\"id\"] + \"/picture' info='\" + data[r][\"name\"] + \"' /&gt;";
        ///         }
        ///         HtmlBodyElement.GetByTagName()[0].innerHTML = outHTML;
        ///         Xdk.FacebookRequestResponse -= Xdk_FacebookRequestResponse;
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="path">The Facebook Graph PATH to execute</param>
        /// <param name="method">The request method to call the Facebook Graph API, typically GET or POST</param>
        /// <param name="parameters">Any parameters required for the request</param>
        [JsMethod(Name = "requestWithGraphAPI")]
        public void RequestWithGraphAPI(JsString path, GetPost method, XdkFacebookParametersBase parameters) { }
        /// <summary>
        /// This command ensures that news feed requests are "frictionless" in that it enables users to send requests to specific friends without having to click on a pop-up confirmation dialog.
        /// </summary>
        /// <remarks>
        /// The Request Dialog sends a Request from one user (the sender) to one or more users (the recipients). The Request Dialog can be used to send a Request directly from one user to another or display a Multi Friend Selector Dialog, allowing the sending user to select multiple recipient users.
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFacebookDialogComplete"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookDialogFail"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// public static void ShowAppRequestDialogFacebook()
        /// {
        ///     Xdk.FacebookDialogComplete += Xdk_FacebookDialogComplete;
        ///     var objParameters = new FBParametersAppRequest() { to = "USER_ID_HERE", message = "My Awesome Message", title = "A title for this dialog would go here" };
        ///     Xdk.facebook.ShowAppRequestDialog(objParameters);
        /// }
        /// static void Xdk_FacebookDialogComplete(FacebookEvent evt)
        /// {
        ///     HtmlContext.console.Log("Permissions Request Returned");
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.console.Log("News feed updated successfully");
        ///     }
        ///     else
        ///     {
        ///         HtmlContext.console.Log("permissions request failed");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// </remarks>
        /// <param name="parameters">A JSON object holding the appropriate parameters for the request as specified in Facebook's documentation</param>
        [JsMethod(Name = "showAppRequestDialog")]
        public void ShowAppRequestDialog(XdkFacebookParametersAppRequest parameters) { }
        /// <summary>
        /// A JSON object holding the appropriate parameters for the request as specified in Facebook's documentation.
        /// </summary>
        /// <remarks>
        /// <para>Events:</para>
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="Xdk.OnFacebookDialogComplete"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookDialogFail"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="Xdk.OnFacebookBusy"/></description>
        /// </item>
        /// </list>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "console"
        /// public static void ShowNewsFeedDialogFacebook()
        /// {
        ///     //This allows the application to post to Facebook for the logged in user
        ///     Xdk.FacebookDialogComplete += Xdk_FacebookDialogComplete;
        ///     var objParameters = new FBParametersFeed()
        ///     {
        ///         picture = "http://fbrell.com/f8.jpg",
        ///         name = "Facebook Dialog",
        ///         caption = "This is my caption",
        ///         description = "Using Dialogs to interact with users.",
        ///         link = "http://www.appmobi.com/documentation"
        ///     };
        ///     Xdk.facebook.ShowNewsFeedDialog(objParameters);
        /// }
        /// static void Xdk_FacebookDialogComplete(FacebookEvent evt)
        /// {
        ///     HtmlContext.console.Log("News Feed Event Returned");
        ///     if (evt.success == true)
        ///     {
        ///         HtmlContext.console.Log("News feed updated successfully");
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="parameters">A JSON object holding the appropriate parameters for the request as specified in Facebook's documentation</param>
        [JsMethod(Name = "showNewsFeedDialog")]
        public void ShowNewsFeedDialog(XdkFacebookParametersFeed parameters) { }
        /// <summary>
        /// This command ensures that news feed requests are "frictionless" in that it enables users to send requests to specific friends without having to click on a pop-up confirmation dialog.
        /// </summary>
        /// <remarks>
        /// This command option is for iOS only since Android requests are automatically set to be "frictionless".
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        [JsMethod(Name = "enableFrictionlessRequests")]
        public void EnableFrictionlessRequests() { }
    }
    #endregion

    #region Multitouch
    /// <summary>
    /// Allows applications to listen for touch events: add/remove touch events and multiple simultaneous touch events on an Android device
    /// </summary>
    /// <remarks>
    /// This object is mainly created to solve the problems with handling multiple simultaneous touches on an Android device. The Android operating system does not handle simultaneous touch events on the browser.
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "intel.xdk.Multitouch")]
    public partial class XdkMultitouch
    {
        /// <summary>
        /// This method starts listening for Android multi touch events on HTML elements at the cost of some device resources. It must be called if your app requires multitouch.
        /// </summary>
        /// <remarks>
        /// The enable method tells the application to start listening for multiple touch events. Once this method is called, we take over the normal touch event interface.
        /// <para>This capability comes at a cost to device resources, so it should only be used if your app requires multitouch events. This command will be ignored on devices other than Android.</para>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // This app requires multitouch events,  so enable them.
        /// Xdk.multitouch.Enable();
        /// </code>
        /// </example>
        [JsMethod(Name = "enable")]
        public void Enable() { }
        /// <summary>
        /// Add listener to touch events (standard touch events)
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "window" or "@return"
        /// public static void PreventDefaultScroll(TouchEvent evt)
        /// {
        ///     evt.PreventDefault();
        ///     HtmlContext.window.Scroll(0, 0);
        ///     HtmlContext.@return(false);
        /// }
        /// Xdk.multitouch.Add(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// </code>
        /// </example>
        /// <param name="target"></param>
        /// <param name="touchEventType"></param>
        /// <param name="listener"></param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "add")]
        public void Add(HtmlElement target, TouchEventType touchEventType, EventListener<TouchEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// Add listener to touch events (standard touch events)
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "window", "@return"
        /// public static void PreventDefaultScroll(TouchEvent evt)
        /// {
        ///     evt.PreventDefault();
        ///     HtmlContext.window.Scroll(0, 0);
        ///     HtmlContext.@return(false);
        /// }
        /// Xdk.multitouch.Add(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// </code>
        /// </example>
        /// <param name="target"></param>
        /// <param name="touchEventType"></param>
        /// <param name="listener"></param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "add")]
        public void Add(Document target, TouchEventType touchEventType, EventListener<TouchEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// Add listener to touch events (standard touch events)
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "window" or "@return"
        /// public static void PreventDefaultScroll(TouchEvent evt)
        /// {
        ///     evt.PreventDefault();
        ///     HtmlContext.window.Scroll(0, 0);
        ///     HtmlContext.@return(false);
        /// }
        /// Xdk.multitouch.Add(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// </code>
        /// </example>
        /// <param name="target"></param>
        /// <param name="touchEventType"></param>
        /// <param name="listener"></param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "add")]
        public void Add(Window target, TouchEventType touchEventType, EventListener<TouchEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// Remove listener to touch events (standard touch events)
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "window" or "@return"
        /// public static void PreventDefaultScroll(TouchEvent evt)
        /// {
        ///     evt.PreventDefault();
        ///     HtmlContext.window.Scroll(0, 0);
        ///     HtmlContext.@return(false);
        /// }
        /// Xdk.multitouch.Add(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// // Make stuffs[...]
        /// // Just for the Remove example... not so useful...
        /// Xdk.multitouch.Remove(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// </code>
        /// </example>
        /// <param name="target"></param>
        /// <param name="touchEventType"></param>
        /// <param name="listener"></param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "remove")]
        public void Remove(HtmlElement target, TouchEventType touchEventType, EventListener<TouchEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// Remove listener to touch events (standard touch events)
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "window" or "@return"
        /// public static void PreventDefaultScroll(TouchEvent evt)
        /// {
        ///     evt.PreventDefault();
        ///     HtmlContext.window.Scroll(0, 0);
        ///     HtmlContext.@return(false);
        /// }
        /// Xdk.multitouch.Add(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// // Make stuffs[...]
        /// // Just for the Remove example... not so useful...
        /// Xdk.multitouch.Remove(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// </code>
        /// </example>
        /// <param name="target"></param>
        /// <param name="touchEventType"></param>
        /// <param name="listener"></param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "remove")]
        public void Remove(Document target, TouchEventType touchEventType, EventListener<TouchEvent> listener, bool useCapture = false) { }
        /// <summary>
        /// Remove listener to touch events (standard touch events)
        /// </summary>
        /// <remarks>
        /// <para>Available Platforms:</para>
        /// <list type="bullet">
        /// <item>
        /// <description>Apple iOS</description>
        /// </item>
        /// <item>
        /// <description>Google Android</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows 8</description>
        /// </item>
        /// <item>
        /// <description>Microsoft Windows Phone 8</description>
        /// </item>
        /// <item>
        /// <description>Html5 natively</description>
        /// </item>
        /// <item>
        /// <description>XDK emulated mode</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Tips: if your class inherit from the "HtmlContext" base class, you don't need to add "HtmlContext." before "window" or "@return"
        /// public static void PreventDefaultScroll(TouchEvent evt)
        /// {
        ///     evt.PreventDefault();
        ///     HtmlContext.window.Scroll(0, 0);
        ///     HtmlContext.@return(false);
        /// }
        /// Xdk.multitouch.Add(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// // Make stuffs[...]
        /// // Just for the Remove example... not so useful...
        /// Xdk.multitouch.Remove(HtmlContext.window.document, TouchEventType.TouchMove, PreventDefaultScroll);
        /// </code>
        /// </example>
        /// <param name="target"></param>
        /// <param name="touchEventType"></param>
        /// <param name="listener"></param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "remove")]
        public void Remove(Window target, TouchEventType touchEventType, EventListener<TouchEvent> listener, bool useCapture = false) { }
    }
    #endregion

    #region Native
    /// <summary>
    /// 
    /// </summary>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkNativeBase64
    {
        public static JsString _keyStr { get; set; }

        [JsMethod(Name = "encode")]
        public static JsString Encode(JsString str) { return (default(JsString)); }
        [JsMethod(Name = "decode")]
        public static JsString Decode(JsString str) { return (default(JsString)); }
        [JsMethod(Name = "_utf8_encode")]
        public static JsString _Utf8Encode(JsString str) { return (default(JsString)); }
        [JsMethod(Name = "_utf8_decode")]
        public static JsString _Utf8Decode(JsString str) { return (default(JsString)); }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkNativeFacebook
    {
        public bool busy { get; set; }
        public bool frictionless { get; set; }

        [JsMethod(Name = "appRequest")]
        public void AppRequest(XdkFacebookParametersBase parameters) { }
        [JsMethod(Name = "api")]
        public void Api(JsString path, JsString httpMethod, XdkFacebookParametersBase parameters) { }
        [JsMethod(Name = "busyError")]
        public void BusyError() { }
        [JsMethod(Name = "apiCall")]
        public void ApiCall(JsString func, JsArray<XdkFacebookParametersBase> args, JsString responseType) { }   // TODO verify type
        [JsMethod(Name = "initCommunicationFrame")]
        public void InitCommunicationFrame() { }
        [JsMethod(Name = "setCommunicationFrameUrl")]
        public void SetCommunicationFrameUrl(JsString url) { }
        [JsMethod(Name = "callbackComplete")]
        public void CallbackComplete() { }
        [JsMethod(Name = "login")]
        public void Login(JsString scope) { }
        [JsMethod(Name = "logout")]
        public void Logout() { }
        [JsMethod(Name = "ui")]
        public void Ui(XdkFacebookParametersBase parameters, JsString responseType) { }
        [JsMethod(Name = "handleResponse")]
        public void HandleResponse(JsString eventName, bool success, JsString responseData, object extra, bool remainbusy) { }    // TODO verify type
        [JsMethod(Name = "handleResponse")]
        public void HandleResponse(JsString eventName, bool success, JsString responseData, object extra) { }      // TODO verify type
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkNativeServers
    {
        /// <summary>
        /// For Intel XDK v4.0: "html5tools-software.intel.com/facebook"
        /// </summary>
        [JsProperty(Name = "FACEBOOKHOST", NativeField = true)]
        public JsString facebookHost { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "https://html5tools-software.intel.com/facebook"
        /// </summary>
        [JsProperty(Name = "FACEBOOK", NativeField = true)]
        public JsString facebook { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "https://cservices.appmobi.com"
        /// </summary>
        [JsProperty(Name = "CLOUDSERVICES", NativeField = true)]
        public JsString cloudServices { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "http://xdk-software.intel.com"
        /// </summary>
        [JsProperty(Name = "XDK", NativeField = true)]
        public JsString xdk { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "https://services.html5tools-software.intel.com"
        /// </summary>
        [JsProperty(Name = "SERVICES", NativeField = true)]
        public JsString services { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "https://www.html5dev-software.intel.com"
        /// </summary>
        [JsProperty(Name = "MARKETING", NativeField = true)]
        public JsString marketing { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "https://appcenter.html5tools-software.intel.com"
        /// </summary>
        [JsProperty(Name = "HUB", NativeField = true)]
        public JsString hub { get; set; }
        /// <summary>
        /// For Intel XDK v4.0: "https://webservices.appmobi.com"
        /// </summary>
        [JsProperty(Name = "WEBSERVICES", NativeField = true)]
        public JsString webservices { get; set; }
    }

    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class XdkNative
    {
        [JsProperty(Name = "Facebook", NativeField = true)]
        public XdkNativeFacebook facebook { get; set; }
        [JsProperty(Name = "Base64", NativeField = true)]
        public XdkNativeBase64 base64 { get; set; }

        [JsProperty(Name = "SERVERS", NativeField = true)]
        public XdkNativeServers servers { get; set; }

        public HtmlAudioElement audioPlr { get; set; }
        public JsNumber audioPlrCurrentTime { get; set; }
        public bool audioPlrLoop { get; set; }

        /// <summary>
        /// Emulate the <see cref="XdkPlayer.StartAudio">Xdk.player.StartAudio</see> command.
        /// </summary>
        /// <param name="relativeFileUrl">The url of the file to play. The file must be on the mobile device.</param>
        /// <param name="loop">Boolean to control whether the audio should loop or not. This parameter is optional with a default value of false.</param>
        [JsMethod(Name = "elmulateStartAudio")]
        public void EmulateStartAudio(JsString relativeFileUrl, bool loop = false) { }
        [JsMethod(Name = "elmulateStartAudioContinue")]
        public void EmulateStartAudioContinue(object data) { }
        /// <summary>
        /// Emulate the <see cref="XdkPlayer.StopAudio">Xdk.player.StopAudio</see> command.
        /// </summary>
        [JsMethod(Name = "emulateStopAudio")]
        public void EmulateStopAudio() { }
        /// <summary>
        /// Emulate the <see cref="XdkPlayer.ToggleAudio">Xdk.player.ToggleAudio</see> command.
        /// </summary>
        [JsMethod(Name = "emulateToggleAudio")]
        public void EmulateToggleAudio() { }
        /// <summary>
        /// Emulate the <see cref="XdkPlayer.SetAudioCurrentTime">Xdk.player.SetAudioCurrentTime</see> command.
        /// </summary>
        /// <param name="time">A floating point value that specifies the time in seconds where the player should seek to.</param>
        [JsMethod(Name = "emulateSetAudioCurrentTime")]
        public void EmulateSetAudioCurrentTime(float time) { }
        [JsMethod(Name = "startAudioAfterLoad")]
        public void startAudioAfterLoad() { }
        [JsMethod(Name = "populateAudioInfo")]
        public void PopulateAudioInfo() { }

        //==================================================================================================
        // PURCHASE FUNCTIONS
        //=================================================================================================
        /// <summary>
        /// Emulate the <see cref="XdkPurchasing.PurchaseProduct">Xdk.purchasing.PurchaseProduct</see> command.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="user"></param>
        [JsMethod(Name = "emulatePurchaseProduct")]
        public void EmulatePurchaseProduct(JsString productId, long quantity, JsString user) { }   // TODO verify type

        //==================================================================================================
        // FILE FUNCTIONS
        //==================================================================================================
        /// <summary>
        /// Emulate the <see cref="XdkFile.UploadToServer">Xdk.file.UploadToServer</see> command.
        /// </summary>
        /// <param name="localURL"></param>
        /// <param name="uploadURL"></param>
        /// <param name="folderName"></param>
        /// <param name="mimeType"></param>
        /// <param name="uploadProgressCallback"></param>
        [JsMethod(Name = "emulateFileUpload")]
        public void EmulateFileUpload(JsString localURL, JsString uploadURL, JsString folderName, JsString mimeType, XdkUploadProgressCallback uploadProgressCallback) { }
        /// <summary>
        /// Emulate the <see cref="XdkFile.CancelUpload">Xdk.file.CancelUpload</see> command.
        /// </summary>
        [JsMethod(Name = "emulateFileCancelUpload")]
        public void EmulateFileCancelUpload() { }
        [JsMethod(Name = "getFileUploadStatus")]
        public void GetFileUploadStatus() { }

        //==================================================================================================
        // PACKAGE CACHE FUNCTIONS
        //==================================================================================================
        /// <summary>
        /// Emulate the <see cref="XdkDevice.CachePackage">Xdk.device.CachePackage</see> command.
        /// </summary>
        /// <param name="packageDir"></param>
        /// <param name="packageUrl"></param>
        [JsMethod(Name = "emulateCachePackage")]
        public void EmulateCachePackage(JsString packageDir, JsString packageUrl) { }
        [JsMethod(Name = "getCachePackageStatus")]
        public void GetCachePackageStatus(JsString url) { }

        //==============================================================================================================
        //Device
        //==============================================================================================================
        /// <summary>
        /// Emulate the <see cref="XdkDevice.GetRemoteData">Xdk.device.GetRemoteData</see> command.
        /// </summary>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty JsString) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The successCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the successful call.</param>
        /// <param name="errorCallback">The errorCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the error.</param>
        [JsMethod(Name = "emulateGetRemoteData")]
        public void EmulateGetRemoteData(JsString url, GetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback) { }
        /// <summary>
        /// Emulate the <see cref="XdkDevice.GetRemoteDataExt">Xdk.device.GetRemoteDataExt</see> command.
        /// </summary>
        /// <param name="paramsObj"></param>
        [JsMethod(Name = "getRemoteDataExt")]
        public void GetRemoteDataExt(XdkDeviceRemoteDataParameters paramsObj) { }

        /// <summary>
        /// Emulate the <see cref="XdkDevice.RegisterLibrary">Xdk.device.RegisterLibrary</see> command.
        /// </summary>        
        /// <param name="delegateName"></param>
        [JsMethod(Name = "emulateRegisterLibrary")]
        public void EmulateRegisterLibrary(JsString delegateName) { }
        /// <summary>
        /// Emulate the <see cref="XdkDevice.PluginExec">Xdk.device.PluginExec</see> command.
        /// </summary>        
        [JsMethod(Name = "emulatePluginExec")]
        public void EmulatePluginExec() { }
        /// <summary>
        /// Emulate the <see cref="XdkDevice.ScanBarcode">Xdk.device.ScanBarcode</see> command.
        /// </summary>        
        [JsMethod(Name = "emulateScanBarcode")]
        public void EmulateScanBarcode() { }

        //==============================================================================================================
        // notification
        //==============================================================================================================
        /// <summary>
        /// USED ONLY BY THE XDK 
        /// </summary>
        [JsMethod(Name = "emulateAsyncPushReceive")]
        public void EmulateAsyncPushReceive() { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.CheckPushUser">Xdk.notification.CheckPushUser</see> command.
        /// </summary>
        /// <param name="userId">The unique identifier for a particular push user in the system. This parameter may not contain spaces or periods.</param>
        /// <param name="password">A password for a particular user in the push system. This parameter may not contain spaces or periods.</param>
        [JsMethod(Name = "emulateCheckPushUser")]
        public void EmulateCheckPushUser(JsString userId, JsString password) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.AddPushUser">Xdk.notification.AddPushUser</see> command.
        /// </summary>
        /// <param name="userId">A unique JsString (per Intel XDK application) for this user to be addressable in the push system. The user id may not contain spaces or periods.</param>
        /// <param name="password">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        /// <param name="email">The email address that the Xdk.notification.sendPushUserPass command will use to notifiy users about their userID and password information.</param>
        [JsMethod(Name = "emulateAddPushUser")]
        public void EmulateAddPushUser(JsString userId, JsString password, JsString email) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.EditPushUser(JsString,JsString)">Xdk.notification.EditPushUser</see> command.
        /// </summary>
        /// <param name="newEmail">The new email address that the sendPushUserPass function will use when a user asks to retrieve their password.</param>
        /// <param name="newPassword">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        [JsMethod(Name = "emulateEditPushUser")]
        public void EmulateEditPushUser(JsString newEmail, JsString newPassword) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.EditPushUser(JsString,JsString,JsString)">Xdk.notification.EditPushUser</see> command.
        /// </summary>
        /// <param name="newEmail">The new email address that the sendPushUserPass function will use when a user asks to retrieve their password.</param>
        /// <param name="newPassword">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        /// <param name="newUser"></param>
        [JsMethod(Name = "emulateEditPushUser")]
        public void EmulateEditPushUser(JsString newEmail, JsString newPassword, JsString newUser) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.DeletePushUser">Xdk.notification.DeletePushUser</see> command.
        /// </summary>
        [JsMethod(Name = "emulateDeletePushUser")]
        public void EmulateDeletePushUser() { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.SendPushUserPass">Xdk.notification.SendPushUserPass</see> command.
        /// </summary>
        [JsMethod(Name = "emulateSendPushUserPass")]
        public void EmulateSendPushUserPass() { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.SetPushUserAttributes">Xdk.notification.SetPushUserAttributes</see> command.
        /// </summary>
        /// <param name="attributesObj"></param>
        [JsMethod(Name = "emulateSetPushUserAttributes")]
        public void EmulateSetPushUserAttributes(XdkNotificationPushUserAttributes attributesObj) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.FindPushUser">Xdk.notification.FindPushUser</see> command.
        /// </summary>
        /// <param name="userId">A unique user id to look for in the messaging database of the application.</param>
        /// <param name="emailAddress">An email address to look for in the messaging database of the application.</param>
        [JsMethod(Name = "emulateFindPushUser")]
        public void EmulateFindPushUser(JsString userId, JsString emailAddress) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.RefreshPushNotifications">Xdk.notification.RefreshPushNotifications</see> command.
        /// </summary>
        /// <param name="silent"></param>
        [JsMethod(Name = "emulateRefreshPushNotifications")]
        public void EmulateRefreshPushNotifications(bool silent = true) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.RefreshUserPushNotifications">Xdk.notification.RefreshUserPushNotifications</see> command.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="device"></param>
        /// <param name="newerthan"></param>
        [JsMethod(Name = "emulateRefreshUserPushNotifications")]
        public void EmulateRefreshUserPushNotifications(JsString user, JsString pass, JsString device, JsString newerthan) { } // TODO verify type
        /// <summary>
        /// Emulate the <see cref="XdkNotification.DeletePushNotifications">Xdk.notification.DeletePushNotifications</see> command.
        /// </summary>
        /// <param name="notificationIds">A pipe ("|") delimited list of notification ids to mark as read and remove from the system. The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</param>
        [JsMethod(Name = "emulateDeletePushNotifications")]
        public void EmulateDeletePushNotifications(JsString notificationIds) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.DeletePushNotifications">Xdk.notification.DeletePushNotifications</see> command.
        /// </summary>
        /// <param name="notificationIds">A pipe ("|") delimited list of notification ids to mark as read and remove from the system. The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</param>
        /// <param name="callMode"></param>
        [JsMethod(Name = "emulateDeletePushNotifications")]
        public void EmulateDeletePushNotifications(JsString notificationIds, XdkCallModeNotifications callMode = XdkCallModeNotifications.Read) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.SendPushNotification">Xdk.notification.SendPushNotification</see> command.
        /// </summary>
        /// <param name="userId">The unique user identification of the user to send the message to.</param>
        /// <param name="message">The text of the message to send.</param>
        /// <param name="data">A JsString of text that is sent along to be interpreted by the receiving device, but not automatically displayed.</param>
        [JsMethod(Name = "emulateSendPushNotification")]
        public void EmulateSendPushNotification(JsString userId, JsString message, JsString data) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.SendPushNotification">Xdk.notification.SendPushNotification</see> command.
        /// </summary>
        /// <param name="userId">The unique user identification of the user to send the message to.</param>
        /// <param name="message">The text of the message to send.</param>
        /// <param name="data">A JsString of text that is sent along to be interpreted by the receiving device, but not automatically displayed.</param>
        /// <param name="richurl"></param>
        /// <param name="richhtml"></param>
        /// <param name="userkey"></param>
        /// <param name="push_to_all"></param>
        /// <param name="messageMode"></param>
        [JsMethod(Name = "emulateSendPushNotificationXDK")]
        public void EmulateSendPushNotificationXDK(JsString userId, JsString message, JsString data, JsString richurl, JsString richhtml, JsString userkey, bool push_to_all, JsString messageMode) { }
        /// <summary>
        /// Emulate the <see cref="XdkNotification.BroadcastPushNotification">Xdk.notification.BroadcastPushNotification</see> command.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="attributes"></param>
        /// <param name="skip"></param>
        [JsMethod(Name = "emulateBroadcastPushNotification")]
        public void EmulateBroadcastPushNotification(JsString message, JsString data, XdkNotificationPushUserAttributes attributes, bool skip) { }   // TODO verify type

        [JsMethod(Name = "injectLocalScriptTag")]
        public void InjectLocalScriptTag(JsString command) { }
    }
    #endregion

    #region XdkGlobal
    /// <summary>
    /// Intel XDK Context
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, GlobalObject = true)]
    public partial class XdkGlobal
    {
        [JsProperty(Name = "AppMobiInit", NativeField = true)]
        public static JsObject AppMobiInit { get; set; }

        [JsMethod(Name = "getAppMobiObject")]
        public static Xdk GetAppMobiObject() { return default(Xdk); }
        [JsMethod(Name = "getAppMobiDocument")]
        public static HtmlDocument GetAppMobiDocument() { return HtmlContext.document; }
    }
    #endregion
}
