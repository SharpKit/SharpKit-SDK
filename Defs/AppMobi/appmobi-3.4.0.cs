/*
 * -----------------------------------------------------------------------
 * AppMobi wrapper for SharpKit / v0.9 (beta)
 * Copyright by Hervé PHILIPPE / alchiweb.fr / revodev@gmail.com
 * -----------------------------------------------------------------------
 * SharpKit version: v5.01.1000
 * AppMobi version: 3.4.0 (first Intel's version)
 *  for further info, see Intel's HTML5 Development Environment (Intel's XDK) at:
 *  http://html5dev-software.intel.com/
 * -----------------------------------------------------------------------
 * Remarks:
 * - events are 'static' because:
 *      . 'add' and 'remove' methods aren't generated globaly if the event isn't static
 *      . the generated code is relativ to 'document', not to the object
 * - all JS variables are C# properties 
 * - names of methods were renamed in C#, in order to begin the name with a capital letter
 * - names of properties aren't renamed, in order to know that the are JS variables
 * - for renaming properties, use 'NativeField' attribute, like this: [JsProperty(Name = "contactid", NativeField = true)]
 * - the Intel Documentation (http://www.html5dev-software.intel.com/documentation/jsAPI) was useful for:
 *      . the summary of properties/events/methods/parameters method
 *      . finding the strong typing of the variables
 *      . finding the events
 * - the appmobi.js file was useful for:
 *      . finding all the classes and methods
 * - there were things that wasn't consistent:
 *      . in Device class, lastStation or lastPlaying JS variable?
 *      . in Cache class, JS method clearAllCookies must have 'name' parameter?
 *      . number of parameters in methods: if so, I have surcharged the method
 *      . I don't know the properties names for CacheEvent class
 * - I have write 'TODO' comments,  mainly for verifying strong typing (like id, that is sometimes JsString, and sometimes JsNumber/int)
 * - for Facebook: FBParameters* classes must be completed with the good properties (see https://fbdevwiki.com/wiki/FB.ui... or with others infos?)
*/

using System;                           // Reference: System
using SharpKit.JavaScript;              // Reference: SharpKit.JavaScript
using SharpKit.Html;                    // Reference: SharpKit.Html
using System.Collections.Generic;

[assembly: JsNamespace(Namespace = "SharpKit.AppMobi", JsNamespace = "AppMobi")]
[assembly: JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true)]
namespace SharpKit.AppMobi
{
    #region Global
    /// <summary>
    /// AppMobi Context
    /// </summary>
    [JsType(GlobalObject = true)]
    public class AppMobiContext
    {
        [JsProperty(Name = "AppMobiInit", NativeField = true)]
        public static object appMobiInit { get; set; }
        [JsProperty(Name = "AppMobi", NativeField = true)]
        public static AppMobiGlobal appMobi { get; set; }
        [JsProperty(Name = "webview", NativeField = true)]
        public static WebView webView { get; set; }
        public static Context context { get; set; }
        public static Helper helper { get; set; }

        [JsMethod(Name = "createGUID")]
        public static JsString CreateGUID() { return default(JsString); }
        [JsMethod(Name = "supports_local_storage")]
        public static JsBoolean SupportsLocalStorage() { return default(JsBoolean); }
        [JsMethod(Name = "getAppMobiObject")]
        public static AppMobiGlobal GetAppMobiObject() { return appMobi; }
        [JsMethod(Name = "getAppMobiDocument")]
        public static HtmlDocument GetAppMobiDocument() { return HtmlContext.document; }
        [JsMethod(Name = "dCsetup")]
        public static void DCSetup(AppMobiMessageEvent evt) { }
        [JsMethod(Name = "dCsetup")]
        public static void DCSetup() { }
        [JsMethod(Name = "fireDeviceReady")]
        public static void FireDeviceReady() { } 
        [JsMethod(Name = "cfInstallCheck")]
        public static void CfInstallCheck() { }
        [JsMethod(Name = "setAnalyticsIP")]
        public static void SetAnalyticsIp(JsString ip) { }
    }
    /// <summary>
    /// Global variables
    /// </summary>
    public class AppMobiGlobal
    {
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a native iOS or Android device
        /// </summary>
        [JsProperty(Name = "isnative", NativeField = true)]
        public JsBoolean isNative { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if currently running in the xdk
        /// </summary>
        [JsProperty(Name = "isxdk", NativeField = true)]
        public JsBoolean isXdk { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running in appMobi app.lab (via Test Anywhere or Test on Local WiFi)
        /// </summary>
        [JsProperty(Name = "istest", NativeField = true)]
        public JsBoolean isTest { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running in the Chrome browser
        /// </summary>
        [JsProperty(Name = "ischrome", NativeField = true)]
        public JsBoolean isChrome { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running as a Facebook application
        /// </summary>
        [JsProperty(Name = "isfacebook", NativeField = true)]
        public JsBoolean isFacebook { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a Barnes and Noble Nook device
        /// </summary>
        [JsProperty(Name = "isnook", NativeField = true)]
        public JsBoolean isNook { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a native phone device
        /// </summary>
        [JsProperty(Name = "isphone", NativeField = true)]
        public JsBoolean isPhone { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running on a native tablet device
        /// </summary>
        [JsProperty(Name = "istablet", NativeField = true)]
        public JsBoolean isTablet { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running in a web browser such as Safari
        /// </summary>
        [JsProperty(Name = "isweb", NativeField = true)]
        public JsBoolean isWeb { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running as an Amazon application
        /// </summary>
        [JsProperty(Name = "isamazon", NativeField = true)]
        public JsBoolean isAmazon { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is running as a Google Play Store application.
        /// </summary>
        [JsProperty(Name = "isgoogle", NativeField = true)]
        public JsBoolean isGoogle { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is currently running as an Intel AppUp application.
        /// </summary>
        [JsProperty(Name = "isintel", NativeField = true)]
        public JsBoolean isIntel { get; set; }
        /// <summary>
        /// This property is a boolean value indicating if the app is running as a Mozilla store app
        /// </summary>
        [JsProperty(Name = "ismozilla", NativeField = true)]
        public JsBoolean isMozilla { get; set; }
        /// <summary>
        /// This property indicates whether the oAuth service is ready or not when the application starts up
        /// </summary>
        [JsProperty(Name = "oauthAvailable", NativeField = true)]
        public JsBoolean oAuthAvailable { get; set; }
        /// <summary>
        /// A boolean indicating whether an update is available to the application or not
        /// </summary>
        public JsBoolean updateAvailable { get; set; }
        /// <summary>
        /// The message associated with a Live Update
        /// </summary>
        public JsString updateMessage { get; set; }
        public JsBoolean available { get; set; }
        public JsBoolean paymentsAvailable { get; set; }
        /// <summary>
        /// This property holds the unique identifier for an appMobi application
        /// </summary>
        public JsString app { get; set; }
        public JsString release { get; set; }
        public JsString package { get; set; }
        /// <summary>
        /// This property holds the full path to appMobi's internal web server
        /// </summary>
        public JsString webRoot { get; set; }
        /// <summary>
        /// The current version of the HTML5 Tools JavaScript API library
        /// </summary>
        public JsString jsVersion { get; set; }
        public JsNumber revision { get; set; }

        public JsBoolean hasLocalStorage { get; set; }
        public QueueData queue { get; set; }
        public JsArray _constructors { get; set; }   // TODO verify type

        public JsObject<CookieData> cookies { get; set; }
        [JsProperty(Name = "mediacache", NativeField = true)]
        public JsObject<JsString> mediaCache { get; set; }
        public JsObject<NotificationData> notifications { get; set; }   // TODO verify type : JsArray or JsObject ?
        public JsArray<ContactData> people { get; set; }
        [JsProperty(Name = "picturelist", NativeField = true)]
        public JsObject<JsString> pictureList { get; set; }
        [JsProperty(Name = "recordinglist", NativeField = true)]
        public JsObject<JsString> recordingList { get; set; }   // TODO verify type : JsArray or JsObject ?
        [JsProperty(Name = "playingTrack", NativeField = true)]
        public PlayingTrack playingtrack { get; set; }

        /// <summary>
        /// Used in DirectCanvas shim
        /// </summary>
        public JsArray<QueueData> injectQueue { get; set; }   // TODO verify type
        /// <summary>
        /// Used in DirectCanvas shim
        /// </summary>
        public JsBoolean readyToInject { get; set; }

        /// <summary>
        /// Define object for receiving acceleration values
        /// </summary>
        public Acceleration _accel { get; set; }
        public Accelerometer accelerometer { get; set; }
        public Advertising advertising { get; set; }
        public Audio audio { get; set; }
        public Player player { get; set; }
        public Stats stats { get; set; }
        public Analytics analytics { get; set; }
        public Calendar calendar { get; set; }
        public File file { get; set; }
        public Speech speech { get; set; }
        public Camera camera { get; set; }
        public Cache cache { get; set; }
        public Canvas canvas { get; set; }
        public Purchasing purchasing { get; set; }
        public Debug debug { get; set; }
        public Contacts contacts { get; set; }
        public Device device { get; set; }
        public Geolocation geolocation { get; set; }
        public Notification notification { get; set; }
        [JsProperty(Name = "oauth", NativeField = true)]
        public OAuth oAuth { get; set; }
        public Facebook facebook { get; set; }
        public Display display { get; set; }
        public Multitouch multitouch { get; set; }

        /// <summary>
        /// Add an initialization function to a queue that ensures it will run and initialize application constructors only once AppMobi has been initialized.
        /// </summary>
        /// <param name="func"></param>
        [JsMethod(Name = "addConstructor")]
        public void AddConstructor(JsAction func) { }
        /// <summary>
        /// Execute a AppMobi command in a queued fashion, to ensure commands do not execute with any race conditions, and only run when AppMobi is ready to recieve them.
        /// </summary>
        [JsMethod(Name = "exec")]
        public void Exec() { }
        /// <summary>
        /// Execute a AppMobi command in a queued fashion, to ensure commands do not execute with any race conditions, and only run when AppMobi is ready to recieve them.
        /// </summary>
        /// <param name="command">Command to be run in AppMobi, e.g. "ClassName.method"</param>
        /// <param name="args">Zero or more arguments to pass to the method</param>
        [JsMethod(Name = "exec")]
        public void Exec(JsString command, JsArray<JsString> args) { }
        /// <summary>
        /// Internal function used to dispatch the request to AppMobi. This needs to be implemented per-platform to ensure that methods are called on the phone in a way appropriate for that device.
        /// </summary>
        [JsMethod(Name = "run_command")]
        public void RunCommand() { }
        [JsMethod(Name = "redirectMouseToTouch")]
        public TouchEvent RedirectMouseToTouch(JsString type, MouseEvent originalEvent) { return (default(TouchEvent)); }
        [JsMethod(Name = "emulateTouchEvents")]
        public void EmulateTouchEvents() { }
        [JsMethod(Name = "stubEvent")]
        public void StubEvent(JsString eventSuffix, object extra) { }    // TODO verify type
        [JsMethod(Name = "doInject")]
        public void DoInject() { }
        [JsMethod(Name = "makeReadyToInject")]
        public void MakeReadyToInject() { }
        [JsMethod(Name = "inject")]
        public void Inject(JsString relativeUrl) { }
    }
    #endregion

    #region Enum for Get and Post
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum MethodGetPost
    {
        [JsField(Name="GET")]
        Get = 1,
        [JsField(Name = "POST")]
        Post = 2
    }
    #endregion

    #region AppMobiElement
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Element")]
    public class AppMobiElement : Element
    {
        public JsString id { get; set; }
    }
    #endregion

    #region AppMobiEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class AppMobiEvent : DOMEvent
    {
        /// <summary>
        /// This parameter returns a true if the operation was successfully completed, or false if the operation was cancelled or there was an error.
        /// </summary>
        public JsBoolean success { get; set; }
        /// <summary>
        /// This parameter returns a true if the operation was cancelled.
        /// </summary>
        public JsBoolean cancelled { get; set; }
    }
    /// <summary>
    /// For dCsetup Javascript global method parameter
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class AppMobiMessageEvent : DOMEvent
    {
        public JsString data { get; set; }
    }
    #endregion

    #region MouseEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class MouseEvent : AppMobiEvent
    {
        public JsNumber clientX { get; set; }
        public JsNumber clientY { get; set; }
        public JsNumber pageX { get; set; }
        public JsNumber pageY { get; set; }
    }
    #endregion

    #region TouchEvent and MultitouchEvent
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class TouchEvent : AppMobiEvent
    {
        public JsArray<MouseEvent> touches { get; set; }
        public JsArray<MouseEvent> changedTouches { get; set; }
        public JsArray<MouseEvent> targetTouches { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class MultitouchEvent : AppMobiEvent
    {
    }
    #endregion

    #region Queue
    [JsType(JsMode.Json)]
    public class QueueData
    {
        public JsBoolean ready { get; set; }
        public JsArray commands { get; set; }   // TODO verify type
        public JsNumber timer { get; set; } // TODO verify type
    }
    #endregion

    #region WebView
    [JsType(JsMode.Json)]
    public class WebView
    {
        [JsMethod(Name = "execute")]
        public void Execute(JsString strJavascript) { }
        [JsMethod(Name = "eval")]
        public void Eval(JsString strJavascript) { }
    }
    #endregion

    #region Context
    /// <summary>
    /// DirectCanvas compatibility
    /// </summary>
    [JsType(JsMode.Json)]
    public class Context
    {
        /// <summary>
        /// Like AppMobi.inject
        /// </summary>
        /// <param name="relativeUrl"></param>
        [JsMethod(Name = "include")]
        public void Include(JsString relativeUrl) { }
        [JsMethod(Name = "startBackgroundSound")]
        public void StartBackgroundSound(JsString relativeFileUrl, JsBoolean isLooping) { }
        [JsMethod(Name = "toggleBackgroundSound")]
        public void ToggleBackgroundSound() { }
        [JsMethod(Name = "stopBackgroundSound")]
        public void StopBackgroundSound() { }
        [JsMethod(Name = "playSound")]
        public void PlaySound(JsString relativeFileURL) { }
        [JsMethod(Name = "loadSound")]
        public void LoadSound(JsString relativeFileURL, JsNumber count) { }
        [JsMethod(Name = "loadPolySound")]
        public void LoadPolySound(JsString relativeFileURL, JsNumber count) { }
        [JsMethod(Name = "hideLoadingScreen")]
        public void HideLoadingScreen() { }

    }
    #endregion

    #region Helper
    [JsType(JsMode.Json)]
    public class BrowserInfo
    {
        public JsString browser { get; set; }
        public JsString version { get; set; }
    }
    [JsType(JsMode.Json)]
    public class Helper
    {
        /// <summary>
        /// return by priority "chrome", "facebook", "web", "intel", "mozilla" or "unknown"
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getOsType")]
        public JsString GetOsType() { return default(JsString); }
        /// <summary>
        /// Today time in format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getTime")]
        public JsString GetTime() { return default(JsString); }
        /// <summary>
        /// Transform number to display it in 2 digits
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        [JsMethod(Name = "checkTime")]
        public JsString CheckTime(JsNumber i) { return default(JsString); }
        [JsMethod(Name = "identifyBrowser")]
        public BrowserInfo IdentifyBrowser(JsString userAgent, JsNumber elements) { return default(BrowserInfo); }
        [JsMethod(Name = "loadURL")]
        public void LoadUrl(JsString url) { }
        [JsMethod(Name = "sendAppStart")]
        public void SendAppStart() { }
        [JsMethod(Name = "sendXPromoRunHome")]
        public void SendXPromoRunHome() { }
    }
    #endregion

    #region Accelerometer
    /// <summary>
    /// This class contains acceleration information.
    /// </summary>
    public class Acceleration
    {
        /// <summary>
        /// The force applied by the device in the x-axis (in m/s^2).
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// The force applied by the device in the y-axis (in m/s^2).
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// The force applied by the device in the z-axis (in m/s^2).
        /// </summary>
        public JsNumber z { get; set; }
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
        public Acceleration(JsNumber x, JsNumber y, JsNumber z, JsBoolean doRotate) { }
    }


    /// <summary>
    /// This class specifies the options for requesting acceleration data.
    /// </summary>
    public class AccelerationOptions
    {
        public JsNumber frequency { get; set; }
        public JsBoolean adjustForRotation { get; set; }
    }


    /// <summary>
    /// Use the accelerometer object to listen to the device's motion sensor.
    /// </summary>
    public class Accelerometer
    {
        /// <summary>
        /// This method will asynchronously acquire the device's acceleration when it is called.
        /// </summary>
        /// <param name="accelerometerSuccess">A function executed when the method successfully detects an accelerometer change.</param>
        /// <param name="accelerometerOptions">An object that contains the adjustForRotation property to set it to adjust for device orientation or not.</param>
        /// <returns>Successful data is returned as an object with the attributes ".x", ".y", and ".z".</returns>
        [JsMethod(Name = "getCurrentAcceleration")]
        public Acceleration GetCurrentAcceleration(JsAction<Acceleration> accelerometerSuccess, AccelerationOptions accelerometerOptions) { return default(Acceleration); }

        /// <summary>
        /// This method will asynchronously acquire the device's acceleration repeatedly at a given interval.
        /// </summary>
        /// <param name="accelerometerSuccess">A function executed when the method successfully detects an accelerometer change.</param>
        /// <param name="accelerometerOptions">An object that contains properties which will modify how the accelerometer information is accessed.</param>
        /// <returns>A unique identifier returned from this method that can be used to stop watching for an accelerometer change.</returns>
        [JsMethod(Name = "watchAcceleration")]
        public JsNumber WatchAcceleration(JsAction<Acceleration> accelerometerSuccess, AccelerationOptions accelerometerOptions) { return default(JsNumber); }

        /// <summary>
        /// This method stops the process started by watchAcceleration when it is passed the appropriate watch timer object.
        /// </summary>
        /// <param name="watchId">The ID returned by accelerometer.watchAcceleration.</param>
        [JsMethod(Name = "clearWatch")]
        public void ClearWatch(JsNumber watchId) { }
    }
    #endregion

    #region Contact
    /// <summary>
    /// Contact informations
    /// </summary>
    [JsType(JsMode.Json)]
    public class ContactData
    {
        public JsString id { get; set; }
        public JsString first { get; set; }
        public JsString last { get; set; }
        public JsString name { get; set; }
        public JsArray<JsString> phones { get; set; }
        public JsArray<JsString> emails { get; set; }
        public JsArray<ContacDataAddress> addresses { get; set; }
    }

    /// <summary>
    /// Address for contact informations
    /// </summary>
    [JsType(JsMode.Json)]
    public class ContacDataAddress
    {
        public JsString street { get; set; }
        public JsString city { get; set; }
        public JsString state { get; set; }
        public JsString zip { get; set; }
        public JsString country { get; set; }
    }

    /// <summary>
    /// Contacts event
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class ContactsEvent : AppMobiEvent
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
    /// <summary>
    /// Access the default contacts database on a device from an application.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public class Contacts
    {
        /// <summary>
        /// Fired when the new contact has been added to the list.
        /// </summary>
        public static event JsAction<ContactsEvent> ContactAdd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.contacts.add'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.contacts.add'")]
            remove { }
        }

        /// <summary>
        /// Fired when an operation on a contact list is requested, but another operation is blocking access to the device's contact list.
        /// </summary>
        public static event JsAction<ContactsEvent> ContactsListBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.contacts.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.contacts.busy'")]
            remove { }
        }

        /// <summary>
        /// Fired once the contact has been selected.
        /// </summary>
        public static event JsAction<ContactsEvent> ContactChoose
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.contacts.choose'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.contacts.choose'")]
            remove { }
        }

        /// <summary>
        /// Fired when the content of the contact has been updated.
        /// </summary>
        public static event JsAction<ContactsEvent> ContactEdit
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.contacts.edit'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.contacts.edit'")]
            remove { }
        }

        /// <summary>
        /// Fired when the device's local contact list has been fully retrieved/refreshed from the device contact database.
        /// </summary>
        public static event JsAction<ContactsEvent> ContactsListRefresh
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.contacts.get'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.contacts.get'")]
            remove { }
        }

        /// <summary>
        /// Fired when contact information has been removed from the list.
        /// </summary>
        public static event JsAction<ContactsEvent> ContactRemove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.contacts.remove'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.contacts.remove'")]
            remove { }
        }

        /// <summary>
        /// This method accesses the add contact functionality on the device.
        /// </summary>
        [JsMethod(Name = "addContact")]
        public void AddContact() { }
        /// <summary>
        /// This method displays a list of contact names from which one can be chosen.
        /// </summary>

        [JsMethod(Name = "chooseContact")]
        public void ChooseContact() { }
        /// <summary>
        /// This method accesses the edit contact functionality on the device for the specified contact.
        /// </summary>
        /// <param name="contactID">The contact ID of the contact to modify</param>
        [JsMethod(Name = "editContact")]
        public void EditContact(JsString contactID) { }
        /// <summary>
        /// This command gets a specific contact object based on contact ID
        /// </summary>
        /// <param name="contactID">The contact ID of the contact to modify</param>
        /// <returns>This method returns a single contact object</returns>
        [JsMethod(Name = "getContactData")]
        public ContactData GetContactData(JsString contactID) { return default(ContactData); }
        /// <summary>
        /// This command returns an array of contact IDs obtained via a call to AppMobi.contacts.getContacts().
        /// </summary>
        /// <returns>An array of contact IDs for the contacts on the device.</returns>
        [JsMethod(Name = "getContactList")]
        public JsArray<JsString> GetContactList() { return default(JsArray<JsString>); }
        /// <summary>
        /// This method pulls the latest contacts from the device into local memory.
        /// </summary>
        [JsMethod(Name = "getContacts")]
        public void GetContacts() { }
        /// <summary>
        /// This method removes a specific contact and the contact's information from the device.
        /// </summary>
        /// <param name="contactID">The contact ID of the contact to remove from the list</param>
        [JsMethod(Name = "removeContact")]
        public void RemoveContact(JsString contactID) { }
    }
    #endregion

    #region Advertising

    /// <summary>
    /// Advertising
    /// </summary>
    public class Advertising
    {
        [JsMethod(Name = "getAd")]
        public void GetAd(JsString name, JsString path, object callbackId) { }  // TODO verify type
        [JsMethod(Name = "runPromotion")]
        public void RunPromotion(JsString appName, JsString storeUrl, JsString promotion, JsString protocol, JsString package, JsString query) { }
        [JsMethod(Name = "runPromotion")]
        public void RunPromotion(JsString appName, JsString storeUrl, JsString promotion, JsString protocol, JsString package) { }
    }
    #endregion

    #region Audio
    /// <summary>
    /// AudioInfo
    /// </summary>
    public class AudioInfo
    {
        public AudioInfo(JsNumber currentTime, JsNumber duration) { }
        /// <summary>
        /// This property contains the current offset (in seconds) from the beginning of the currently playing audio track.
        /// </summary>
        public JsNumber currentTime { get; set; }
        /// <summary>
        /// This property contains the length (in seconds) of the currently playing audio track.
        /// </summary>
        public JsNumber duration { get; set; }
    }
    [JsType(JsMode.Json)]
    public class AudioPlayer
    {
        public Player player { get; set; }
        public JsBoolean playing { get; set; }
        /// <summary>
        /// Last Time : in Javascript, lasttime = 0; or lasttime = new Date();
        /// </summary>
        [JsProperty(Name = "lasttime", NativeField = true)]
        public JsNumber lastTime { get; set; }
    }
    /// <summary>
    /// Audio
    /// </summary>
    public class Audio
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
        public JsObject<JsString> GetRecordingList() { return default(JsObject<JsString>); }    // TODO verify type
        [JsMethod(Name = "getRecordingURL")]
        public JsString GetRecordingURL() { return default(JsString); }
    }
    #endregion

    #region Player
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class PlayerEvent : AppMobiEvent
    {
        /// <summary>
        /// This parameter returns the error message.
        /// </summary>
        public JsString error { get; set; }
    }
    /// <summary>
    /// Access information about the media currently playing.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PlayingTrack
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
    /// Play audio and video
    /// </summary>
    public class Player
    {
        /// <summary>
        /// This event will fire if the AppMobi.player.startAudio command is called but the device is already playing
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerAudioBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.audio.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.audio.busy'")]
            remove { }
        }
        /// <summary>
        /// This event fires when execution of setAudioCurrentTime is complete
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerAudioCurrenttimeSet
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.audio.currenttime.set'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.audio.currenttime.set'")]
            remove { }
        }
        /// <summary>
        /// This event fires when there is an unknown error calling the AppMobi.player.startAudio command
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerAudioError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.audio.error'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.audio.error'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when an audio file is started
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerAudioStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.audio.start'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.audio.start'")]
            remove { }
        }
        /// <summary>
        /// This event will fire once an audio file played using AppMobi.player.startAudio is complete
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerAudioStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.audio.stop'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.audio.stop'")]
            remove { }
        }
        /// <summary>
        /// This event will fire when the appMobi player screen is hidden
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerHide
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.hide'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.hide'")]
            remove { }
        }
        /// <summary>
        /// This event will fire when the appMobi player screen is shown
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShow
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.show'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.show'")]
            remove { }
        }
        /// <summary>
        /// This event will fire if the AppMobi.player.playPodcast command is called but the device is already playing
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerPodcastBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.podcast.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.podcast.busy'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the AppMobi.player.playPodcast command experiences an unknown error
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerPodcastError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.podcast.error'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.podcast.error'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a video is started
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerPodcastStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.podcast.start'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.podcast.start'")]
            remove { }
        }
        /// <summary>
        /// This event will fire once a video or audio podcast is complete
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerPodcastStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.podcast.stop'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.podcast.stop'")]
            remove { }
        }
        /// <summary>
        /// This event will fire if the AppMobi.player.startShoutcast command is called while the device is already playing
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShoutcastBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.shoutcast.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.shoutcast.busy'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the AppMobi.player.startShoutcast command experiences an unknown error
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShoutcastError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.shoutcast.error'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.shoutcast.error'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the AppMobi.player.play command is called or when a shoutcast station starts to play from the player screen
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShoutcastPlay
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.shoutcast.play'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.shoutcast.play'")]
            remove { }
        }
        /// <summary>
        /// 
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShoutcastPause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.shoutcast.pause'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.shoutcast.pause'")]
            remove { }
        }

        /// <summary>
        /// This event is fired when a shoutcast station is started
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShoutcastStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.shoutcast.start'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.shoutcast.start'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a shoutcast station stops because the user hit the stop button
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerShoutcastStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.shoutcast.stop'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.shoutcast.stop'")]
            remove { }
        }
        /// <summary>
        /// This event fires if a file referenced by the AppMobi.player.playSound command is invalid or missing
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerSoundError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.sound.error'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.sound.error'")]
            remove { }
        }
        /// <summary>
        /// This event will fire if the AppMobi.player.startStation command is called but the device is already playing
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerStationBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.station.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.station.busy'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the AppMobi.player.startStation command experiences an unknown error
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerStationError
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.station.error'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.station.error'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the AppMobi.player.pause command is called or when a station is paused
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerStationPause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.station.pause'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.station.pause'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the AppMobi.player.play command is called or when a station starts to play
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerStationPlayer
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.station.player'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.station.player'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a station is started
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerStationStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.station.start'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.station.start'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a station stops
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerStationStop
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.station.stop'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.station.stop'")]
            remove { }
        }
        /// <summary>
        /// This event will fire each time a playing station changes to a new track and updates its metadata
        /// </summary>
        public static event JsAction<PlayerEvent> PlayerTrackChange
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.player.track.change'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.player.track.change'")]
            remove { }
        }


        public JsNumber currentTime { get; set; }
        public AudioInfo audioInfo { get; set; }
        public AudioPlayer audio { get; set; }
        public JsObject<JsAction<AudioPlayer>> sounds { get; set; }

        /// <summary>
        /// This method will show the native appMobi player UI.
        /// </summary>
        [JsMethod(Name = "show")]
        public void Show() { }
        /// <summary>
        /// This method will hide the native appMobi player UI.
        /// </summary>
        [JsMethod(Name = "hide")]
        public void Hide() { }
        /// <summary>
        /// This method will load a specified podcast (either audio or video) from the web into a native player with UI.
        /// </summary>
        /// <param name="podcastUrl">The url of the audio or video podcast to play on the device.</param>
        [JsMethod(Name = "playPodcast")]
        public void PlayPodcast(JsString podcastUrl) { }
        /// <summary>
        /// This method will load a station hosted by appMobi and identified by a unique NetStationID code.
        /// </summary>
        /// <param name="netStationId">The unique NetStationID code for this station on an appMobi media server.</param>
        /// <param name="resumeMode">A Boolean specifying whether the station should attempt to resume from a previous play point when restarted.</param>
        /// <param name="showPlayer">A Boolean value specifying whether to show the native player or not once the station is loaded are available.</param>
        [JsMethod(Name = "startStation")]
        public void StartStation(JsString netStationId, JsBoolean resumeMode, JsBoolean showPlayer) { }
        /// <summary>
        /// This method will play a sound with no UI or events and is not controllable.
        /// </summary>
        /// <param name="relativeFileUrl">The relative URL of the sound file to play relative to the root folder of the application.</param>
        [JsMethod(Name = "playSound")]
        public void PlaySound(JsString relativeFileUrl) { }
        /// <summary>
        /// Use this method to preload a sound file to prevent lag the first time it is played.
        /// </summary>
        /// <param name="relativeFileUrl">The relative URL of the sound file to play relative to the root folder of the application.</param>
        /// <param name="count">The polyphonic count of a sound - that is, how many times that sound can be played concurrently. This parameter is optional. Sounds loaded without a count may not be played on top of each other.</param>
        [JsMethod(Name = "loadSound")]
        public void LoadSound(JsString relativeFileUrl, JsNumber count) { }
        /// <summary>
        /// Use this method to unload a sound file.
        /// </summary>
        /// <param name="relativeFileUrl">The relative URL of the sound file to play relative to the root folder of the application.</param>
        [JsMethod(Name = "unloadSound")]
        public void UnloadSound(JsString relativeFileUrl) { }
        /// <summary>
        /// Use this method to unload all sound files that have been loaded via the player.loadSound or player.playSound methods.
        /// </summary>
        [JsMethod(Name = "unloadAllSounds")]
        public void UnloadAllSounds() { }
        /// <summary>
        /// This method will load and start playing a specified audio file without a UI of any sort.
        /// </summary>
        /// <param name="relativeFileUrl">The url of the file to play. The file must be on the mobile device.</param>
        /// <param name="loop">Boolean to control whether the audio should loop or not. This parameter is optional with a default value of false.</param>
        [JsMethod(Name = "startAudio")]
        public void StartAudio(JsString relativeFileUrl, JsBoolean loop) { }
        [JsMethod(Name = "startAudio")]
        public void StartAudio(JsString relativeFileUrl) { }
        /// <summary>
        /// This method will pause or play the audio started by a call to AppMobi.player.startAudio.
        /// </summary>
        [JsMethod(Name = "toggleAudio")]
        public void ToggleAudio() { }
        /// <summary>
        /// This method will stop the audio started by a call to AppMobi.player.startAudio.
        /// </summary>
        [JsMethod(Name = "stopAudio")]
        public void StopAudio() { }
        /// <summary>
        /// This method causes the player to seek to a time in the file specified in seconds.
        /// </summary>
        /// <param name="time">A floating point value that specifies the time in seconds where the player should seek to.</param>
        [JsMethod(Name = "setAudioCurrentTime")]
        public void SetAudioCurrentTime(float time) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="successCallback"></param>
        /// <returns>time</returns>
        [JsMethod(Name = "getAudioCurrentTime")]
        public float GetAudioCurrentTime(JsAction<PlayerEvent> successCallback) { return default(JsNumber); }
        /// <summary>
        /// This method is used to start a watch on the current audio track.
        /// </summary>
        /// <param name="successCallback">A function that will be called at the specified time interval.</param>
        /// <param name="frequency">The time interval in milliseconds for which to update the AppMobi.player.audioInfo variable with information.</param>
        /// <returns>A unique identifier returned from this method that can be used to clear the watch for audio information.</returns>
        [JsMethod(Name = "watchAudioCurrentTime")]
        public JsString WatchAudioCurrentTime(JsAction<PlayerEvent> successCallback, JsNumber frequency) { return (default(JsString)); }    // TODO verify type
        /// <summary>
        /// This method stops the process started by player.watchAudioCurrentTime when it is passed the appropriate watch ID.
        /// </summary>
        /// <param name="watchId">The ID returned by player.watchAudioCurrentTime.</param>
        [JsMethod(Name = "clearAudioCurrentTimeWatch")]
        public void ClearAudioCurrentTimeWatch(JsString watchId) { }     // TODO verify type
        /// <summary>
        /// This method will restart playback of a paused player.
        /// </summary>
        [JsMethod(Name = "play")]
        public void Play() { }
        /// <summary>
        /// This method will pause the playback of a loaded player.
        /// </summary>
        [JsMethod(Name = "pause")]
        public void Pause() { }
        /// <summary>
        /// This method will stop playback of a loaded player.
        /// </summary>
        [JsMethod(Name = "stop")]
        public void Stop() { }
        /// <summary>
        /// This method controls the volume of streaming audio.
        /// </summary>
        /// <param name="percentage">A number from 0 to 100 indicating how to set the volume as a percentage of the maximum volume.</param>
        [JsMethod(Name = "volume")]
        public void Volume(JsNumber percentage) { }
        /// <summary>
        /// This method will rewind the play head.
        /// </summary>
        [JsMethod(Name = "rewind")]
        public void Rewind() { }
        /// <summary>
        /// This method will advance the play head.
        /// </summary>
        [JsMethod(Name = "ffwd")]
        public void Ffwd() { }
        /// <summary>
        /// This method allows developers to change the colors of the progress bar of the appMobi native player.
        /// </summary>
        /// <param name="backColor">The background of the progress bar</param>
        /// <param name="fillColor">The downloading progress of the progress bar</param>
        /// <param name="doneColor">The color the progress bar will turn once all downloading is complete</param>
        /// <param name="playColor">The color the play head indicating where in the progress bar is currently playing</param>
        [JsMethod(Name = "setColors")]
        public void SetColors(JsString backColor, JsString fillColor, JsString doneColor, JsString playColor) { }
        /// <summary>
        /// On devices with a larger screen resolution such as the iPad, this command allows the developer to set the position of the native player on the screen.
        /// </summary>
        /// <param name="portraitX">The position of the player from the left edge of the device in pixels while in portrait orientation.</param>
        /// <param name="portraitY">The position of the player from the top edge of the device in pixels while in portrait orientation.</param>
        /// <param name="landscapeX">The position of the player from the left edge of the device in pixels while in landscape orientation.</param>
        /// <param name="landscapeY">The position of the player from the top edge of the device in pixels while in landscape orientation.</param>
        [JsMethod(Name = "setPosition")]
        public void SetPosition(JsNumber portraitX, JsNumber portraitY, JsNumber landscapeX, JsNumber landscapeY) { }
        /// <summary>
        /// This method will load and play a station hosted by Shoutcast.
        /// </summary>
        /// <param name="stationUrl">The url of the shoutcast stream to load and play.</param>
        /// <param name="showPlayer">A boolean parameter specifying whether to show the native player or not once the station is loaded is available.</param>
        [JsMethod(Name = "startShoutcast")]
        public void StartShoutcast(JsString stationUrl, JsBoolean showPlayer) { }
    }
    #endregion

    #region Stats
    /// <summary>
    /// 
    /// </summary>
    public class Stats
    {
        [JsMethod(Name = "logPageEvent")]
        public void LogEvent(JsString message) { }
    }
    #endregion

    #region Analytics
    [JsType(JsMode.Json)]
    public class QueueEvent
    {
        public JsString date { get; set; }
        public JsString time { get; set; }
        public JsString ip { get; set; }
        public JsString uniqueId { get; set; }
        public int status { get; set; }
        public JsString uri { get; set; }
        public JsString query { get; set; }
        public MethodGetPost method { get; set; }
        public int bytes { get; set; }
        public JsString userAgent { get; set; }
        public JsString referer { get; set; }
    }
    /// <summary>
    /// Track how your application is used and accessed by setting custom events
    /// </summary>
    public class Analytics
    {
        public JsString queueLink { get; set; }
        public JsObject<QueueEvent> analyticsQueue { get; set; }
        public JsString uniqueId { get; set; }
        public JsBoolean hasConnection { get; set; }
        public JsString ipAddress { get; set; }

        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        [JsMethod(Name = "eventObj")]
        public QueueEvent EventObj() { return (new QueueEvent()); }
        [JsMethod(Name = "processQueue")]
        public void ProcessQueue() { }
        [JsMethod(Name = "setOffline")]
        public void SetOffline() { }
        [JsMethod(Name = "logEvent")]
        public void LogEvent(JsString eventID, JsString queryString) { }
        /// <summary>
        /// This function will log events for statMobi Analytics.
        /// </summary>
        /// <param name="page">The page parameter is a required string that identifies the logged statMobi Analytics event. Although any format could be used, appMobi suggests the following format for the string to facilitate its use later in standard analytics engines: "/application/[EVENT IDENTIFIER HERE].event"</param>
        /// <param name="query">The query parameter is optional. It is used to hold a series of key/value pairs related to the tracked statMobi event. It defaults to the string "-".</param>
        /// <param name="status">The status parameter is optional. It defaults to the value 200.</param>
        /// <param name="method">The method parameter is optional. It defaults to the string "GET".</param>
        /// <param name="bytes">The bytes parameter is optional. It defaults to the value 0.</param>
        /// <param name="referrer">The referrer parameter is optional. It is included in case your application is built in the form of a web application that spans several HTML documents and you would like to track each discreet HTML page. It defaults to an empty string.</param>
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, int status, MethodGetPost method, int bytes, JsString referrer) { }
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, int status, MethodGetPost method, int bytes) { }
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, int status, MethodGetPost method) { }
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query, int status) { }
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page, JsString query) { }
        [JsMethod(Name = "logPageEvent")]
        public void LogPageEvent(JsString page) { }
    }
    #endregion

    #region Calendar
    /// <summary>
    /// This class provides access to the appMobiCalendar.
    /// </summary>
    public class Calendar
    {
        [JsMethod(Name = "addEvent")]
        public void AddEvent(JsString title, object start, object end) { }  // TODO verify type
    }
    #endregion

    #region File
    /// <summary>
    /// Transfers files over the Internet.
    /// </summary>
    public class File
    {
        /// <summary>
        /// This method uploads files to a remote server over the Internet.
        /// </summary>
        /// <param name="localURL">The URL of the file on the local device server. This URL will always start with http://localhost:58888/.</param>
        /// <param name="uploadURL">The remote server address that the file will be uploaded to</param>
        /// <param name="folderName">The name of the folder on the remote server to hold the transferred file</param>
        /// <param name="mimeType">The mime type of the file to be uploaded</param>
        /// <param name="uploadProgressCallback">The function named here is called repetitively as the file uploads. The function should include two parameters. The first will be the number of bytes sent so far and the second will be the total bytes to be uploaded.</param>
        [JsMethod(Name = "uploadToServer")]
        public void UploadToServer(JsString localURL, JsString uploadURL, JsString folderName, JsString mimeType, JsAction<JsNumber, JsNumber> uploadProgressCallback) { }

        /// <summary>
        /// This method cancels a previous file.uploadToServer command.
        /// </summary>
        [JsMethod(Name = "cancelUpload")]
        public void CancelUpload() { }
    }
    #endregion

    #region Speech
    /// <summary>
    /// This class provides access to the appMobiSpeech.
    /// </summary>
    public class Speech
    {
        [JsMethod(Name = "recognize")]
        public void Recognize(object longPause, JsString language) { }    // TODO verify type
        [JsMethod(Name = "stopRecording")]
        public void StopRecording() { }
        [JsMethod(Name = "vocalize")]
        public void Vocalize(JsString text, JsString voiceName, JsString language) { }  // TODO verify type
        [JsMethod(Name = "cancel")]
        public void Cancel() { }
    }
    #endregion

    #region Camera
    /// <summary>
    /// Picture types
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PictureType
    {
        [JsField(Name = "jpg")]
        Jpg = 1,
        [JsField(Name = "png")]
        Png = 2
    }

    /// <summary>
    /// Camera Picture event
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class CameraPictureEvent : AppMobiEvent
    {
        //	The filename of the image in the picture list (only for the 'add' operation).
        public JsString filename { get; set; }
    }

    /// <summary>
    /// Use the device's camera and access your device's camera library.
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Fired when a photo is added to the application's picture list
        /// </summary>
        public static event JsAction<ContactsEvent> PictureAdd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.camera.picture.add'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.camera.picture.add'")]
            remove { }
        }
        /// <summary>
        /// Fired when accessing the native camera functionality is blocked by another process
        /// </summary>
        public static event JsAction<ContactsEvent> CameraBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.camera.picture.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.camera.picture.busy'")]
            remove { }
        }
        /// <summary>
        /// Fired when the user chooses to cancel rather than taking or importing a picture
        /// </summary>
        public static event JsAction<ContactsEvent> PictureCancel
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.camera.picture.cancel'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.camera.picture.cancel'")]
            remove { }
        }
        /// <summary>
        /// Fired when the application's picture list has been cleared
        /// </summary>
        public static event JsAction<ContactsEvent> PictureListClear
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.camera.picture.clear'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.camera.picture.clear'")]
            remove { }
        }
        /// <summary>
        /// Fired when a photo is removed from application's picture list
        /// </summary>
        public static event JsAction<ContactsEvent> PictureRemove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.camera.picture.remove'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.camera.picture.remove'")]
            remove { }
        }

        /// <summary>
        /// Use this command to take a picture with your device's camera.
        /// </summary>
        /// <param name="quality">The quality parameter reflects the percentage of image compression done to the image captured by the camera. This parameter must be a value between 1 and 100. The default value is 70.</param>
        /// <param name="saveToLib">This parameter controls whether the photo is saved directly to the device's image library or not. The default value is true.</param>
        /// <param name="picType">The parameter controls the file type the photo can be saved as. The valid string values are "jpg" and "png" respectively. The default value is "jpg".</param>
        [JsMethod(Name = "takePicture")]
        public void TakePicture(JsNumber quality, JsBoolean saveToLib, PictureType picType) { }
        /// <summary>
        /// This method will move a photo from your application's native camera file service (e.g. the camera roll) to the picture list.
        /// </summary>
        [JsMethod(Name = "importPicture")]
        public void ImportPicture() { }
        /// <summary>
        /// Use this command to remove a photo from your application's picture list.
        /// </summary>
        /// <param name="pictureFilename">The filename of the image in the picture list. This filename can be obtained from camera.getPictureList</param>
        [JsMethod(Name = "deletePicture")]
        public void DeletePicture(JsString pictureFilename) { }
        /// <summary>
        /// This command will remove all photos from your application's picture list.
        /// </summary>
        [JsMethod(Name = "clearPictures")]
        public void ClearPictures() { }
        /// <summary>
        /// This command will return a list of all pictures stored in the application's picture list.
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getPictureList")]
        public JsObject<JsString> GetPictureList() { return default(JsObject<JsString>); }
        /// <summary>
        /// This command will return the URL of the picture on the local webserver
        /// </summary>
        /// <param name="pictureFilename">The name of the picture to get the URL for reference dfrom the array returned from getPictureList</param>
        /// <returns></returns>
        [JsMethod(Name = "getPictureURL")]
        public JsString GetPictureUrl(JsString pictureFilename) { return default(JsString); }
    }
    #endregion

    #region Cache (verify property names for events)
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class CacheEvent : AppMobiEvent      // TODO : verify property names
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
        public int bytes { get; set; }
        /// <summary>
        /// the total number of bytes in the file
        /// </summary>
        public int totalbytes { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CookieData
    {
        public object value { get; set; }
        public JsNumber expires { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Cache
    {
        /// <summary>
        /// Fires when data is cached
        /// </summary>
        public static event JsAction<CacheEvent> CacheMediaAdd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.cache.media.add'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.cache.media.add'")]
            remove { }
        }
        /// <summary>
        /// Fired once all files are removed from the local file cache
        /// </summary>
        public static event JsAction<CacheEvent> CacheMediaClear
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.cache.media.clear'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.cache.media.clear'")]
            remove { }
        }
        /// <summary>
        /// Fired when data is removed from the cache
        /// </summary>
        public static event JsAction<CacheEvent> CacheMediaRemove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.cache.media.remove'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.cache.media.remove'")]
            remove { }
        }
        /// <summary>
        /// Fired repeatedly to track caching progress
        /// </summary>
        public static event JsAction<CacheEvent> CacheMediaUpdate
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.cache.media.update'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.cache.media.update'")]
            remove { }
        }

        /// <summary>
        /// 
        /// </summary>
        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        /// <summary>
        /// This method will retrieve the value of a cookie previously saved using the setCookie command.
        /// </summary>
        /// <param name="cookieName">The unique name for the data to retrieve.</param>
        /// <returns></returns>
        [JsMethod(Name = "getCookie")]
        public CookieData GetCookie(JsString cookieName) { return (default(CookieData)); }
        /// <summary>
        /// This method will return an array containing the names of all the previously saved cookies using the setCookie command.
        /// </summary>
        /// <returns>An array of all the unique names of previously saved data</returns>
        [JsMethod(Name = "getCookieList")]
        public JsArray<CookieData> GetCookieList() { return (default(JsArray<CookieData>)); }
        /// <summary>
        /// Call this method to set a chunk of data that will persist from session to session.
        /// </summary>
        /// <param name="cookieName">A unique name for the data to save. The name parameter may not contain periods or underscores.</param>
        /// <param name="cookieValue">The data to save. The data will be saved as a string. An undefined variable will be saved as an empty string.</param>
        /// <param name="days">The number of days until the data is automatically removed from the device. Pass a -1 to make sure the application never automatically expires data. Pass a 0 to make the cookie a "session cookie" that is removed once the application is closed.</param>
        [JsMethod(Name = "setCookie")]
        public void SetCookie(JsString cookieName, object cookieValue, JsNumber days) { }
        /// <summary>
        /// This method will clear data previously saved using the setCookie method.
        /// </summary>
        /// <param name="cookieName">The unique name of the data to remove.</param>
        [JsMethod(Name = "removeCookie")]
        public void RemoveCookie(JsString cookieName) { }
        /// <summary>
        /// This method will clear all data stored using the setCookie method.
        /// </summary>
        /// <param name="name"></param>
        [JsMethod(Name = "clearAllCookies")]
        public void ClearAllCookies(JsString name) { }
        /// <summary>
        /// This method will clear all data stored using the setCookie method.
        /// </summary>
        [JsMethod(Name = "clearAllCookies")]
        public void ClearAllCookies() { }
        /// <summary>
        /// This method will get an array containing all the names of all the previously cached files.
        /// </summary>
        /// <returns>An array of URLs that have been cached on the device using the addToMediaCache method.</returns>
        [JsMethod(Name = "getMediaCacheList")]
        public JsArray<JsString> GetMediaCacheList() { return (default(JsArray<JsString>)); }
        /// <summary>
        /// This method will return an url that you can use to access a cached media file.
        /// </summary>
        /// <param name="url">The remote URL of the file that was cached.</param>
        /// <returns></returns>
        [JsMethod(Name = "getMediaCacheLocalURL")]
        public JsString GetMediaCacheLocalUrl(JsString url) { return (default(JsString)); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">The url of the file to cache.</param>
        /// <returns></returns>
        [JsMethod(Name = "getMediaCacheRelativePath")]
        public JsString GetMediaCacheRelativePath(JsString url) { return (default(JsString)); }
        /// <summary>
        /// This command will remove all files from the local cache on the device.
        /// </summary>
        [JsMethod(Name = "clearMediaCache")]
        public void ClearMediaCache() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">The url of the file to cache.</param>
        /// <param name="id">A unique identifier for the cache request.</param>
        [JsMethod(Name = "addToMediaCacheImpl")]
        public void AddToMediaCacheImpl(JsString url, JsString id) { }  // TODO verify type (id)
        /// <summary>
        /// This command will get a file from the Internet and cache it locally on the device.
        /// </summary>
        /// <param name="url">The url of the file to cache.</param>
        [JsMethod(Name = "addToMediaCache")]
        public void AddToMediaCache(JsString url) { }
        /// <summary>
        /// This command will get a file or files from the Internet and cache it locally on the device.
        /// </summary>
        /// <param name="url">The url of the file to cache.</param>
        /// <param name="id">A unique identifier for the cache request.</param>
        [JsMethod(Name = "addToMediaCacheExt")]
        public void AddToMediaCacheExt(JsString url, JsString id) { }  // TODO verify type (id)
        /// <summary>
        /// This command will remove a file from the local cache on the device.
        /// </summary>
        /// <param name="url">The url of the file to remove from the local cache.</param>
        [JsMethod(Name = "removeFromMediaCache")]
        public void RemoveFromMediaCache(JsString url) { }
    }
    #endregion

    #region Canvas
    [JsType(JsMode.Json)]
    public class CanvasContext
    {
        [JsMethod(Name = "setFps")]
        public void SetFps(int framesPerSecond) { }
        [JsMethod(Name = "clear")]
        public void Clear() { }
        [JsMethod(Name = "present")]
        public void Present() { }
    }
    /// <summary>
    /// The canvas object provides the bridge functions to the Accelerated Canvas App Game Interface plugin.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Element")]
    public class Canvas : AppMobiElement
    {
        public CanvasContext context { get; set; }
        /// <summary>
        /// The current visibility of the Accelerated Canvas App Game Interface object
        /// </summary>
        public JsBoolean isHidden { get; set; }

        /// <summary>
        /// Get CanvasContext... but without parameter (ctx)
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getContext")]
        public CanvasContext GetContext() { return (default(CanvasContext)); }
        /// <summary>
        /// Get CanvasContext... but without parameter (ctx)
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "origGetContext")]
        public CanvasContext OrigGetContext() { return (default(CanvasContext)); }
        /// <summary>
        /// Creates a new Accelerated Canvas App Game Interface and loads the contents of a JavaScript library into it. (like AppMobi.inject)
        /// </summary>
        /// <param name="relativeUrl">The filename of the Javascript file to load with the direct canvas</param>
        [JsMethod(Name = "load")]
        public void Load(JsString relativeUrl) { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface view to be shown. By default, the Accelerated Canvas App Game Interface is shown, but this method can be used to reveal the Accelerated Canvas App Game Interface once it has been hidden.
        /// </summary>
        [JsMethod(Name = "show")]
        public void Show() { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface view to be hidden.
        /// </summary>
        [JsMethod(Name = "hide")]
        public void Hide() { }
        /// <summary>
        /// JavaScript that is passed to the execute method and will be forwarded to the Accelerated Canvas App Game Interface execution context for execution there.
        /// </summary>
        /// <param name="javascript">Any JavaScript calls that should be executed in the Accelerated Canvas App Game Interface context</param>
        [JsMethod(Name = "execute")]
        public void Execute(JsString javascript) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="javascript"></param>
        [JsMethod(Name = "eval")]
        public void Eval(JsString javascript) { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface view to be completely reset.
        /// </summary>
        [JsMethod(Name = "reset")]
        public void Reset() { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface to draw itself to its view a particular number of times per second.
        /// </summary>
        /// <param name="framesPerSecond">A numeric value indicating how often the Accelerated Canvas App Game Interface should draw itself per second.</param>
        [JsMethod(Name = "setFramesPerSecond")]
        public void SetFramesPerSecond(int framesPerSecond) { }
        /// <summary>
        /// This command causes the Accelerated Canvas App Game Interface to draw itself to its view a particular number of times per second. (compatibility stub)
        /// </summary>
        /// <param name="framesPerSecond">A numeric value indicating how often the Accelerated Canvas App Game Interface should draw itself per second.</param>
        [JsMethod(Name = "setFps")]
        public void SetFps(int framesPerSecond) { }
        [JsMethod(Name = "setTimeout")]
        public void SetTimeout(JsString handler, int timeout) { }
        /*
                [JsMethod(Name = "setTimeout")]
                public int SetTimeout(JsAction handler) { return (default(int)); }
                [JsMethod(Name = "setTimeout")]
                public int SetTimeout(JsAction handler, object timeout, params object[] args) { return (default(int)); }
        */

    }
    #endregion

    #region Purchasing
    /// <summary>
    /// 
    /// </summary>
    public class Purchasing
    {
        [JsMethod(Name = "purchaseProduct")]
        public void PurchaseProduct(JsString productId, JsNumber quantity, JsString user) { }   // TODO verify type
    }
    #endregion

    #region Debug
    /// <summary>
    /// 
    /// </summary>
    public class Debug
    {
        /// <summary>
        /// Utility function for rendering and indenting strings, or serializing objects to a string capable of being printed to the console.
        /// </summary>
        /// <param name="message">The string or object to convert to an indented string</param>
        /// <returns></returns>
        [JsMethod(Name = "processMessage")]
        public JsString ProcessMessage(object message) { return (default(JsString));}
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
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum DeviceOrientation
    {
        [JsField(Name = "portrait")]
        Portrait = 1,
        [JsField(Name = "landscape")]
        Landscape = 2
    }

    public class RemoteDataParameters
    {
        public JsString url { get; set; }
        public JsString id { get; set; }
        public MethodGetPost method { get; set; }
        public JsString body { get; set; }
        public JsString headers { get; set; }

        [JsMethod(Name = "addHeader")]
        public void AddHeader(JsString name, object value) { }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class DeviceEvent : AppMobiEvent
    {
    }

    /// <summary>
    /// Access information about and configure settings of the device itself using this object
    /// </summary>
    public class Device
    {
        /// <summary>
        /// This event is fired once the barcode reader command has finished doing its job
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceBarcodeScan
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.barcode.scan'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.barcode.scan'")]
            remove { }
        }
        /// <summary>
        /// This event is fired in response to the AppMobi.device.updateConnection command to indicate that the device's Internet connection has changed
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceConnectionUpdate
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.connection.update'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.connection.update'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the screen is unlocked
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceContinue
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.continue'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.continue'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the Android hardware back button is pressed following a call to AppMobi.device.addVirtualPage
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceHardwareBack
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.hardware.back'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.hardware.back'")]
            remove { }
        }
        /// <summary>
        /// This event will fire whenever the current orientation of the device changes
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceOrientationChange
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.orientation.change'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.orientation.change'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when the screen locks
        /// </summary>
        public static event JsAction<DeviceEvent> DevicePause
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.pause'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.pause'")]
            remove { }
        }
        /// <summary>
        /// This event will fire once all AppMobi JavaScript bridge library loaded
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceReady
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.ready'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.ready'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once navigation to a web page from the main browser window is blocked by the device.blockRemotePages command
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceRemoteBlock
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.remote.block'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.remote.block'")]
            remove { }
        }
        /// <summary>
        /// This event will fire once a new webview opened by the AppMobi.device.showRemoteSite command is closed
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceRemoteClose
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.remote.close'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.remote.close'")]
            remove { }
        }
        /// <summary>
        /// This event is fired when a response is received from the remote server in response to the getRemoteDataExt command
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceRemoteData
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.remote.data'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.remote.data'")]
            remove { }
        }
        /// <summary>
        /// This event indicates that the user has switched back to using the application
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceResume
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.resume'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.resume'")]
            remove { }
        }
        /// <summary>
        /// This event indicates that the user has task-switched away from the application
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceSuspend
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.suspend'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.suspend'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the Live Update service of hostMobi has successfully downloaded an update for an application
        /// </summary>
        public static event JsAction<DeviceEvent> DeviceUpdateAvailable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.device.update.available'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.device.update.available'")]
            remove { }
        }

        /// <summary>
        /// 
        /// </summary>
        public JsBoolean available { get; set; }
        /// <summary>
        /// The platform property returns a text string identifying the platform that appMobi is running on.
        /// </summary>
        public JsString platform { get; set; }
        /// <summary>
        /// This property returns the device’s current operating system version information.
        /// </summary>
        [JsProperty(Name = "osversion", NativeField = true)]
        public JsString osVersion { get; set; }
        /// <summary>
        /// This property returns the model of the device that the application is running on.
        /// </summary>
        public JsString model { get; set; }
        /// <summary>
        /// The uuid property returns a unique identification id for the device.
        /// </summary>
        public JsString uuid { get; set; }
        /// <summary>
        /// This property returns the initial orientation of the device
        /// </summary>
        public int initialOrientation { get; set; }
        /// <summary>
        /// This property returns the version of the appMobi container software that the application is using.
        /// </summary>
        [JsProperty(Name = "appmobiversion", NativeField = true)]
        public JsString appmobiVersion { get; set; }
        /// <summary>
        /// This property returns the version of phonegap running below the AppMobi layer
        /// </summary>
        [JsProperty(Name = "phonegapversion", NativeField = true)]
        public JsString phonegapVersion { get; set; }
        /// <summary>
        /// This property returns the current orientation of the device
        /// </summary>
        public int orientation { get; set; }
        /// <summary>
        /// This property senses the best type of internet connection available
        /// </summary>
        public JsString connection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsString density { get; set; }
        /// <summary>
        /// !Like lastStation! This property will hold information about the audio stream currently playing
        /// </summary>
        public JsString lastPlaying { get; set; }
        /// <summary>
        /// !Like lastPlaying! This property will hold information about the audio stream currently playing
        /// </summary>
        public JsString lastStation { get; set; }
        /// <summary>
        /// This feature is now available from the appMobi documentation. Click here to redirect to that documentation.
        /// </summary>
        public JsBoolean hasAnalytics { get; set; }
        /// <summary>
        /// This property says whether caching has been enabled for this application
        /// </summary>
        public JsBoolean hasCaching { get; set; }
        /// <summary>
        /// This property indicates whether streaming has been enabled for this application
        /// </summary>
        public JsBoolean hasStreaming { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsBoolean hasAdvertising { get; set; }
        /// <summary>
        /// This feature is now available from the appMobi documentation. Click here to redirect to that documentation.
        /// </summary>
        public JsBoolean hasPush { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsBoolean hasPayments { get; set; }
        /// <summary>
        /// This feature is now available from the appMobi documentation. Click here to redirect to that documentation.
        /// </summary>
        public JsBoolean hasUpdates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsProperty(Name = "landwidth", NativeField = true)]
        public int landWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsProperty(Name = "landheight", NativeField = true)]
        public int landHeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsProperty(Name = "portwidth", NativeField = true)]
        public int portWidth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsProperty(Name = "portheight", NativeField = true)]
        public int portHeight { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsProperty(Name = "width", NativeField = true)]
        public int width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsProperty(Name = "height", NativeField = true)]
        public int height { get; set; }
        /// <summary>
        /// This property returns any query string parameters passed along with a protocol handler call to start an application
        /// </summary>
        public JsString queryString { get; set; }

        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        /// <summary>
        /// This method controls how the device behaves in certain power states.
        /// </summary>
        /// <param name="shouldStayOn">This boolean value sets whether normal power management for the device applies or not.</param>
        /// <param name="onlyWhenPluggedIn">This boolean value is only used if shouldStayOn is set to true. If shouldStayOn is true and onlywhenPluggedIn is true, then the device will not go to sleep if the device is plugged in. If shouldStayOn is true and onlyWhenPluggedIn is false, then the device will never go to sleep.</param>
        [JsMethod(Name = "managePower")]
        public void ManagePower(JsBoolean shouldStayOn, JsBoolean onlyWhenPluggedIn) { }
        /// <summary>
        /// This function will control whether the device should automatically handle rotation or not based on a boolean value.
        /// </summary>
        /// <param name="shouldAutoRotate">This boolean value controls whether the device is allowed to automatically handle rotation or not.</param>
        [JsMethod(Name = "setAutoRotate")]
        public void SetAutoRotate(JsBoolean shouldAutoRotate) { }
        /// <summary>
        /// This function will lock the orientation of the device to either "landscape" or "portrait" orientation.
        /// </summary>
        /// <param name="orientation"></param>
        [JsMethod(Name = "setRotateOrientation")]
        public void SetRotateOrientation(DeviceOrientation orientation) { }
        /// <summary>
        /// This function will query the device to determine its current connection to the internet.
        /// </summary>
        [JsMethod(Name = "updateConnection")]
        public void UpdateConnection() { }
        /// <summary>
        /// This function will set header data required for basic authentication over the Internet.
        /// </summary>
        /// <param name="domain">The domain and realm of the server to make the request to.</param>
        /// <param name="username">The appropriate username for the authentication request.</param>
        /// <param name="password">The appropriate password for the authentication request.</param>
        [JsMethod(Name = "setBasicAuthentication")]
        public void SetBasicAuthentication(JsString domain, JsString username, JsString password) { }
        /// <summary>
        /// This function will intercept a single press of the device's hardware "back" button and fire the appMobi.device.hardware.back event instead.
        /// </summary>
        [JsMethod(Name = "addVirtualPage")]
        public void AddVirtualPage() { }
        /// <summary>
        /// This method allows for remote loading of a JavaScript file for Microsoft Windows 8
        /// </summary>
        /// <param name="url">The URL of the JavaScript file to load.</param>
        /// <param name="onLoad">A function to handle the successful load of the JavaScript file.</param>
        /// <param name="onError">A function to handle the failed load response.</param>
        [JsMethod(Name = "addRemoteScript")]
        public void AddRemoteScript(JsString url, JsAction<DeviceEvent> onLoad, JsAction<DeviceEvent> onError) { }
        /// <summary>
        /// This method will help control a device's hardware "back" button.
        /// </summary>
        [JsMethod(Name = "removeVirtualPage")]
        public void RemoveVirtualPage() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="callback"></param>
        [JsMethod(Name = "addMenuItem")]
        public void AddMenuItem(JsString text, JsAction<DeviceEvent> callback) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="delegateName"></param>
        [JsMethod(Name = "registerLibrary")]
        public void RegisterLibrary(JsString delegateName) { }
        /// <summary>
        /// This function will open a url in the device's native browser application.
        /// </summary>
        /// <param name="url">The URL for the browser window to open.</param>
        [JsMethod(Name = "launchExternal")]
        public void LaunchExternal(JsString url) { }
        /// <summary>
        /// This function is used to show a remote web site in a different web view.
        /// </summary>
        /// <param name="url">The URL for the web view to open.</param>
        /// <param name="closeImageX">The position of the button to close the web view from the left edge in pixels.</param>
        /// <param name="closeImageY">The position of the button to close the web view from the top edge in pixels.</param>
        /// <param name="closeImageWidth">The width of the button to close the web view in pixels.</param>
        /// <param name="closeImageHeight">The height of the button to close the web view in pixels.</param>
        [JsMethod(Name = "showRemoteSite")]
        public void ShowRemoteSite(JsString url, int closeImageX, int closeImageY, int closeImageWidth, int closeImageHeight) { }
        /// <summary>
        /// This function is used to show a remote web site in a different web view.
        /// </summary>
        /// <param name="url">The URL for the web view to open.</param>
        /// <param name="closeImagePortraitX">The position of the button to close the web view from the left edge in pixels when the device is in the portrait orientation.</param>
        /// <param name="closeImagePortraitY">The position of the button to close the web view from the top edge in pixels when the device is in the portrait orientation.</param>
        /// <param name="closeImageLandscapeX">The position of the button to close the web view from the left edge in pixels when the device is in the landscape orientation.</param>
        /// <param name="closeImageLandscapeY">The position of the button to close the web view from the top edge in pixels when the device is in the landscape orientation.</param>
        /// <param name="closeImageWidth">The width of the button to close the web view in pixels.</param>
        /// <param name="closeImageHeight">The height of the button to close the web view in pixels.</param>
        [JsMethod(Name = "showRemoteSiteExt")]
        public void ShowRemoteSiteExt(JsString url, int closeImagePortraitX, int closeImagePortraitY, int closeImageLandscapeX, int closeImageLandscapeY, int closeImageWidth, int closeImageHeight) { }
        /// <summary>
        /// Call this command to force a remote site opened with showRemoteSite or showRemoteSiteExt to close.
        /// </summary>
        [JsMethod(Name = "closeRemoteSite")]
        public void CloseRemoteSite() { }
        /// <summary>
        /// Call this command from within a new web view created by the showRemoteSite or showRemoteSiteExt command to execute JavaScript commands within the main web view.
        /// </summary>
        /// <param name="command">Any JavaScript that should be passed to and executed in the main web view of the application.</param>
        [JsMethod(Name = "mainViewExecute")]
        public void MainViewExecute(JsString command) { }
        /// <summary>
        /// Use this method to block remote pages, and also set up a white list of allowable remote pages.
        /// </summary>
        /// <param name="shouldBlock">This boolean value controls whether the application should block remote pages or not.</param>
        /// <param name="whitelist">This parameter is a "|" delimited list of of domains and or domain:port combos that are NOT to be blocked if shouldblock=true.</param>
        [JsMethod(Name = "blockRemotePages")]
        public void BlockRemotePages(JsBoolean shouldBlock,JsString whitelist) { }
        /// <summary>
        /// This method will open a full-screen QR code reader in an application
        /// </summary>
        [JsMethod(Name = "scanBarcode")]
        public void ScanBarcode() { }
        /// <summary>
        /// Run or install a native app on the device
        /// </summary>
        /// <param name="appName">The name of the application being loaded.</param>
        /// <param name="protocolHandler">The protocol handler required for the application to run/install</param>
        /// <param name="appLocationUrl">The URL specifying the location of the application to run or install. This URL will be specific to the store from where the app is retrieved.</param>
        /// <param name="bundleId">The full Android bundle ID for the desired store (this parameter can be left blank for iOS). Example: com.companyname.projectname</param>
        [JsMethod(Name = "runInstallNativeApp")]
        public void RunInstallNativeApp(JsString appName, JsString protocolHandler, JsString appLocationUrl, JsString bundleId) { }
        /// <summary>
        /// Run or install a native app on the device
        /// </summary>
        /// <param name="appName">The name of the application being loaded.</param>
        /// <param name="protocolHandler">The protocol handler required for the application to run/install</param>
        /// <param name="appLocationUrl">The URL specifying the location of the application to run or install. This URL will be specific to the store from where the app is retrieved.</param>
        [JsMethod(Name = "runInstallNativeApp")]
        public void RunInstallNativeApp(JsString appName, JsString protocolHandler, JsString appLocationUrl) { }
        /// <summary>
        /// This method will open an email view to send an email without exiting the application
        /// </summary>
        /// <param name="bodyText">This mandatory parameter includes the body of the email to send</param>
        /// <param name="toString">Comma separated string of email addresses to send email to</param>
        /// <param name="subjectText">Content of the email subject line</param>
        /// <param name="isHTML">A boolean value indicating whether body is to be sent in HTML format or not</param>
        /// <param name="ccString">Comma separated string of email addresses to be CCed</param>
        /// <param name="bccString">Comma separated string of email addresses to be BCCed</param>
        [JsMethod(Name = "sendEmail")]
        public void SendEmail(JsString bodyText, JsString toString, JsString subjectText, JsBoolean isHTML, JsString ccString, JsString bccString) { }
        /// <summary>
        /// This method will send an SMS message
        /// </summary>
        /// <param name="bodyText">Content of the message body.</param>
        /// <param name="toNumber">String containing number to send message.</param>
        [JsMethod(Name = "sendSMS")]
        public void SendSms(JsString bodyText, JsString toNumber) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orientation"></param>
        [JsMethod(Name = "setOrientation")]
        public void SetOrientation(int orientation) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty string) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The successCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the successful call.</param>
        /// <param name="errorCallback">The errorCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the error.</param>
        /// <param name="uniqueIdentifier">A unique identifier that will be returned with the success or error callback function.</param>
        /// <param name="hasId"></param>
        [JsMethod(Name = "getRemoteDataImpl")]
        public void GetRemoteDataImpl(JsString url, MethodGetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback, JsNumber uniqueIdentifier, JsBoolean hasId) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty string) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The successCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the successful call.</param>
        /// <param name="errorCallback">The errorCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the error.</param>
        /// <param name="uniqueIdentifier">A unique identifier that will be returned with the success or error callback function.</param>
        [JsMethod(Name = "getRemoteDataWithID")]
        public void GetRemoteDataWithId(JsString url, MethodGetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback, JsNumber uniqueIdentifier) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <param name="url">The URL of the page to access.</param>
        /// <param name="requestMethod">The method to use for the page access. This parameter should be either "get" or "post".</param>
        /// <param name="requestBody">The requestBody is unused for a request with the "GET" method (just pass an empty string) and should hold the post data for a "POST" method request in a name=value format separated by ampersands.</param>
        /// <param name="successCallback">The successCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the successful call.</param>
        /// <param name="errorCallback">The errorCallback should hold the name of a separately created function. That function should include two parameters. The first will hold the unique identifier passed in the original call. The second will hold the data returned from the error.</param>
        [JsMethod(Name = "getRemoteData")]
        public void GetRemoteData(JsString url, MethodGetPost requestMethod, JsString requestBody, JsString successCallback, JsString errorCallback) { }
        /// <summary>
        /// This function is used for making background POST/GET requests for remote data
        /// </summary>
        /// <param name="paramsObj"></param>
        [JsMethod(Name = "getRemoteDataExt")]
        public void GetRemoteDataExt(RemoteDataParameters paramsObj) { }
        /// <summary>
        /// This method will immediately install a waiting Live Update. Following the install, the application will restart itself with the new code. If no update is waiting, this command is ignored.
        /// </summary>
        [JsMethod(Name = "installUpdate")]
        public void InstallUpdate() { }
        /// <summary>
        /// This method will hide the application splash screen earlier than it automatically does
        /// </summary>
        [JsMethod(Name = "hideSplashScreen")]
        public void HideSplashScreen() { }
        /// <summary>
        /// This method hides the device status bar
        /// </summary>
        [JsMethod(Name = "hideStatusBar")]
        public void HideStatusBar() { }
        /// <summary>
        /// 
        /// </summary>
        [JsMethod(Name = "cachePackage")]
        public void cachePackage(JsString subdir, JsString url) { }
    }
    #endregion

    #region Geolocation
    /// <summary>
    /// This class contains geolocation coords information.
    /// </summary>
    [JsType(JsMode.Json)]
    public class GeolocationCoords
    {
        /// <summary>
        /// 
        /// </summary>
        public JsNumber latitude { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsNumber longitude { get; set; }
    }
    /// <summary>
    /// This class contains geolocation position information.
    /// </summary>
    [JsType(JsMode.Json)]
    public class GeolocationPosition
    {
        /// <summary>
        /// 
        /// </summary>
        public GeolocationCoords coords { get; set; }
    }
    /// <summary>
    /// This class contains geolocation options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class GeolocationOptions
    {
        public int timeout { get; set; }
        public JsBoolean enableHighAccuracy { get; set; }
        public int maximumAge { get; set; }
    }

    /// <summary>
    /// Make your application aware of where it is currently located
    /// </summary>
    public class Geolocation
    {
        /// <summary>
        /// Use this command to get the current location of the device.
        /// </summary>
        /// <param name="successFunction">When data is available, this success function is called.</param>
        /// <param name="errorFunction">If there is an error getting position data, the error function is called.</param>
        /// <returns></returns>
        [JsMethod(Name = "getCurrentPosition")]
        public GeolocationPosition GetCurrentPosition(JsAction<GeolocationPosition> successFunction, JsAction errorFunction) { return default(GeolocationPosition); }
        /// <summary>
        /// Use this command rather than the getCurrentLocation command to track progress during a trip rather than just getting a single position.
        /// </summary>
        /// <param name="successFunction">When data is available, this success function is called.</param>
        /// <param name="errorFunction">If there is an error getting position data, the error function is called.</param>
        /// <param name="options">Some options may be specified for the method as an array object.</param>
        /// <returns>geolocationWatchTimer</returns>
        [JsMethod(Name = "watchPosition")]
        public JsNumber WatchPosition(JsAction<GeolocationPosition> successFunction, JsAction errorFunction, GeolocationOptions options) { return default(JsNumber); }
        /// <summary>
        /// This method stops the process started by watchPosition when it is passed the appropriate watch timer object.
        /// </summary>
        /// <param name="watchTimer">The returned watch returned from the previous AppMobi.geolocation.watchPosition() command.</param>
        [JsMethod(Name = "clearWatch")]
        public void ClearWatch(JsNumber watchTimer) { }
    }
    #endregion

    #region Notification
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class NotificationEvent : AppMobiEvent
    {
        /// <summary>
        /// This parameter returns the error message.
        /// </summary>
        public JsString message { get; set; }
    }
    [JsType(JsMode.Json)]
    public class NotificationData
    {
        public JsString id { get; set; }    // TODO verify type (if not JsString, modify methods)
        public JsString msg { get; set; }
        public JsString data { get; set; }
        [JsProperty(Name = "userkey", NativeField = true)]
        public JsString userKey { get; set; }
        [JsProperty(Name = "richurl", NativeField = true)]
        public JsString richUrl { get; set; }
        [JsProperty(Name = "richhtml", NativeField = true)]
        public JsString richHtml { get; set; }
        public JsBoolean isRich { get; set; }
    }
    public class PushUserAttributes
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
    public class Notification
    {
        /// <summary>
        /// This event is fired if the GCM service notifies appMobi that there is no Google account on the phone.
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushAccountmissing
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.accountmissing'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.accountmissing'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a push notification is removed from the messaging system
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushDelete
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.delete'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.delete'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the user is signed out of the pushMobi messaging system
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushDisable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.disable'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.disable'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a user's credentials have been confirmed by the application
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushEnable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.enable'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.enable'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a push notification is marked as read and removed from the messaging system
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushRead
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.read'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.read'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the application has gotten a push notification
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushReceive
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.receive'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.receive'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once the notification system refreshes the data on an application
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushRefresh
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.refresh'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.refresh'")]
            remove { }
        }
        /// <summary>
        /// This event is fired if showRichPushViewer is called while a rich push message is already visible
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushRichBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.rich.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.rich.busy'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a rich push message is closed
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushRichClose
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.rich.close'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.rich.close'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a push notification is sent from an application
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushSend
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.send'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.send'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once a request is made by a user to have their notifications password emailed to them
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushSendpassword
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.sendpassword'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.sendpassword'")]
            remove { }
        }
        /// <summary>
        /// 
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushUserEdit
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.user.edit'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.user.edit'")]
            remove { }
        }
        /// <summary>
        /// This event is fired once further demographic information is associated with a user
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPushUserEditattributes
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.user.editattributes'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.user.editattributes'")]
            remove { }
        }
        /// <summary>
        /// This event is fired following a request by an application to find other users of the application
        /// </summary>
        public static event JsAction<NotificationEvent> NotificationPush
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.notification.push.user.find'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.notification.push.user.find'")]
            remove { }
        }

        /// <summary>
        /// This method will display a modal alert box.
        /// </summary>
        /// <param name="message">The message to show in the alert box.</param>
        /// <param name="title">The title to put across the top of the alert box.</param>
        /// <param name="buttonText">The text to put on the button that dismisses the alert box.</param>
        [JsMethod(Name = "alert")]
        public void Alert(JsString message, JsString title, JsString buttonText) { }
        /// <summary>
        /// This method will display a modal alert box with confirmation options.
        /// </summary>
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
        [JsMethod(Name = "vibrate")]
        public void Vibrate() { }
        /// <summary>
        /// This method will cause the device to beep.
        /// </summary>
        /// <param name="count">The number of times the device should beep in succession.</param>
        [JsMethod(Name = "beep")]
        public void Beep(int count) { }
        /// <summary>
        /// This method will turn on the device's "working" or "busy" state graphics such as a spinner or an hourglass.
        /// </summary>
        [JsMethod(Name = "showBusyIndicator")]
        public void ShowBusyIndicator() { }
        /// <summary>
        /// This method will turn off the "working" or "busy" state graphics started by the AppMobi.notification.showBusyIndicator method.
        /// </summary>
        [JsMethod(Name = "hideBusyIndicator")]
        public void HideBusyIndicator() { }
        /// <summary>
        /// Use this method to get a list of id keys to obtain access to the list of available notifications for this user.
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getNotificationList")]
        public JsArray<JsString> GetNotificationList() { return (default(JsArray<JsString>)); }
        /// <summary>
        /// se this method to get any data associated with a notification.
        /// </summary>
        /// <param name="id">The id parameter of the message object you would like to get the information from.</param>
        /// <returns></returns>
        [JsMethod(Name = "getNotificationData")]
        public NotificationData GetNotificationData(JsString id) { return (default(NotificationData)); }
        /// <summary>
        /// Use this method to confirm the credentials of a user or to log an existing user in on a different device.
        /// </summary>
        /// <param name="userId">The unique identifier for a particular push user in the system. This parameter may not contain spaces or periods.</param>
        /// <param name="password">A password for a particular user in the push system. This parameter may not contain spaces or periods.</param>
        [JsMethod(Name = "checkPushUser")]
        public void CheckPushUser(JsString userId, JsString password) { }
        /// <summary>
        /// Use this method to register a new user id on a particular appMobi application.
        /// </summary>
        /// <param name="userId">A unique string (per appMobi application) for this user to be addressable in the push system. The user id may not contain spaces or periods.</param>
        /// <param name="password">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        /// <param name="email">The email address that the AppMobi.notification.sendPushUserPass command will use to notifiy users about their userID and password information.</param>
        [JsMethod(Name = "addPushUser")]
        public void AddPushUser(JsString userId, JsString password, JsString email) { }
        /// <summary>
        /// Use this method to change the email address and the password associated with the push notification service of an appMobi application.
        /// </summary>
        /// <param name="newEmail">The new email address that the sendPushUserPass function will use when a user asks to retrieve their password.</param>
        /// <param name="newPassword">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        /// <param name="newUser"></param>
        [JsMethod(Name = "editPushUser")]
        public void EditPushUser(JsString newEmail, JsString newPassword, JsString newUser) { }
        /// <summary>
        /// Use this method to change the email address and the password associated with the push notification service of an appMobi application.
        /// </summary>
        /// <param name="newEmail">The new email address that the sendPushUserPass function will use when a user asks to retrieve their password.</param>
        /// <param name="newPassword">The user's chosen password for the push system. The password may not contain spaces or periods.</param>
        [JsMethod(Name = "editPushUser")]
        public void EditPushUser(JsString newEmail, JsString newPassword) { }
        /// <summary>
        /// Use this method to sign out of push notifications and no longer receive push messages for the application.
        /// </summary>
        [JsMethod(Name = "deletePushUser")]
        public void DeletePushUser() { }
        /// <summary>
        /// Use this method to send an email message to a user including the password for push notifications for a particular appMobi application.
        /// </summary>
        [JsMethod(Name = "sendPushUserPass")]
        public void SendPushUserPass() { }
        /// <summary>
        /// Use this method to associate attributes to a user.
        /// </summary>
        /// <param name="attributesObj"></param>
        [JsMethod(Name = "setPushUserAttributes")]
        public void SetPushUserAttributes(PushUserAttributes attributesObj) { }
        /// <summary>
        /// Use this method to allow users to find other users of an appMobi application. It provides a kind of "friends" functionality.
        /// </summary>
        /// <param name="userId">A unique user id to look for in the messaging database of the application.</param>
        /// <param name="emailAddress">An email address to look for in the messaging database of the application.</param>
        [JsMethod(Name = "findPushUser")]
        public void FindPushUser(JsString userId, JsString emailAddress) { }
        /// <summary>
        /// Use this method to allow users to force a user's device to re-synchronize notifications between this device and the database on the server.
        /// </summary>
        [JsMethod(Name = "refreshPushNotifications")]
        public void RefreshPushNotifications() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="device"></param>
        /// <param name="newerthan"></param>
        [JsMethod(Name = "refreshUserPushNotifications")]
        public void RefreshUserPushNotifications(JsString user, JsString pass, object device, object newerthan) { } // TODO verify type
        /// <summary>
        /// Use this method to remove notifications from the server.
        /// </summary>
        /// <param name="notificationIds">A pipe ("|") delimited list of notification ids to mark as read and remove from the system. The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</param>
        [JsMethod(Name = "readPushNotifications")]
        public void ReadPushNotifications(JsString notificationIds) { }
        /// <summary>
        /// Use this method to remove notifications from the server. This method replaces the notification.readPushNotifications method which is being deprecated.
        /// </summary>
        /// <param name="notificationIds">A pipe ("|") delimited list of notification ids to mark as read and remove from the system. The event object includes a "success" property that is set to true or false. On an error, this event will additionally include a "message" property describing the error.</param>
        [JsMethod(Name = "deletePushNotifications")]
        public void DeletePushNotifications(JsString notificationIds) { }
        /// <summary>
        /// Use this method to send a push notification to another user of an application.
        /// </summary>
        /// <param name="userId">The unique user identification of the user to send the message to.</param>
        /// <param name="message">The text of the message to send.</param>
        /// <param name="data">A string of text that is sent along to be interpreted by the receiving device, but not automatically displayed.</param>
        [JsMethod(Name = "sendPushNotification")]
        public void SendPushNotification(JsString userId, JsString message, JsString data) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="attributes"></param>
        /// <param name="skip"></param>
        [JsMethod(Name = "broadcastPushNotification")]
        public void BroadcastPushNotification(JsString message, JsString data, PushUserAttributes attributes, JsBoolean skip) { }   // TODO verify type
        /// <summary>
        /// Use this method to display a rich push message
        /// </summary>
        /// <param name="notificationId">The unique identifier of the message to display.</param>
        /// <param name="closeImagePortraitX">The horizontal position of the image used to close the rich push message in terms of pixels from the left edge of the application. This value is used when the application is in portrait orientation.</param>
        /// <param name="closeImagePortraitY">The vertical position of the image used to close the rich push message in terms of pixels from the top edge of the application. This value is used when the application is in portrait orientation.</param>
        /// <param name="closeImageLandscapeX">The horizontal position of the image used to close the rich push message in terms of pixels from the left edge of the application. This value is used when the application is in landscape orientation.</param>
        /// <param name="closeImageLandscapeY">The vertical position of the image used to close the rich push message in terms of pixels from the top edge of the application. This value is used when the application is in landscape orientation.</param>
        /// <param name="closeImageWidth">The width of the image used to close the rich push message and return to the application.</param>
        /// <param name="closeImageHeight">The height of the image used to close the rich push message and return to the application.</param>
        [JsMethod(Name = "showRichPushViewer")]
        public void ShowRichPushViewer(JsString notificationId, int closeImagePortraitX, int closeImagePortraitY, int closeImageLandscapeX, int closeImageLandscapeY, int closeImageWidth, int closeImageHeight) { }
        /// <summary>
        /// This information will force a rich push message to close.
        /// </summary>
        [JsMethod(Name = "closeRichPushViewer")]
        public void CloseRichPushViewer() { }
    }
    #endregion

    #region Display
    /// <summary>
    /// 
    /// </summary>
    [JsType(JsMode.Json)]
    public class DisplayWindow
    {
        /// <summary>
        /// This property returns the visible screen width (in pixels) on the device for landscape
        /// </summary>
        [JsProperty(Name = "landwidth", NativeField = true)]
        public JsNumber landWidth { get; set; }
        /// <summary>
        /// This property returns the visible screen width (in pixels) on the device for portrait
        /// </summary>
        [JsProperty(Name = "portwidth", NativeField = true)]
        public JsNumber portWidth { get; set; }
        /// <summary>
        /// This property returns the visible screen height (in pixels) on the device for landscape
        /// </summary>
        [JsProperty(Name = "landheight", NativeField = true)]
        public JsNumber landHeight { get; set; }
        /// <summary>
        /// This property returns the visible screen height (in pixels) on the device for portrait
        /// </summary>
        [JsProperty(Name = "portheight", NativeField = true)]
        public JsNumber portHeight { get; set; }
    }
    /// <summary>
    /// Take control of the device's video display properties
    /// </summary>
    public class Display
    {
        public Element viewport { get; set; }
        [JsProperty(Name = "oldviewport", NativeField = true)]
        public Element oldViewport { get; set; }
        public Document doc { get; set; }

        /// <summary>
        /// This method triggers appMobi's augmented reality mode.
        /// </summary>
        [JsMethod(Name = "startAR")]
        public void StartAR() { }
        /// <summary>
        /// This method turns off augmented reality mode.
        /// </summary>
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
        /// <param name="orientation"></param>
        [JsMethod(Name = "updateViewportOrientation")]
        public void UpdateViewportOrientation(JsNumber orientation) { }

        [JsMethod(Name = "viewportOrientationListener")]
        public void ViewportOrientationListener() { }
        /// <summary>
        /// This method tells appMobi to size down an application for a smaller device.
        /// </summary>
        /// <param name="widthPortraitInPx">The width to set the device to display at in pixels when the device is in portrait orientation.</param>
        /// <param name="widthLandscapeInPx">The width to set the device to display at in pixels when the device is in landscape orientation.</param>
        [JsMethod(Name = "useViewport")]
        public void UseViewport(int widthPortraitInPx, int widthLandscapeInPx) { }
        /// <summary>
        /// This method guarantees that the values you send in are always completely visible and the smaller dimension will be filled completely.
        /// </summary>
        /// <param name="widthPortrait">The width to set the Viewport window to display at in pixels when the device is in portrait orientation.</param>
        /// <param name="heightPortrait">The height to set the Viewport window to display at in pixels when the device is in portrait orientation.</param>
        /// <param name="widthLandscape">The width to set the Viewport window to display at in pixels when the device is in landscape orientation.</param>
        /// <param name="heightLandscape">The height to set the Viewport window to display at in pixels when the device is in landscape orientation.</param>
        [JsMethod(Name = "lockViewportWindow")]
        public void LockViewportWindow(JsNumber widthPortrait, JsNumber heightPortrait, JsNumber widthLandscape, JsNumber heightLandscape) { }
    }
    #endregion

    #region OAuth and OAuthInternal
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class OAuthEvent : AppMobiEvent
    {
        public JsObject data { get; set; }   // TODO verify type
        public JsString origin { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ProtectedDataParameters
    {
        /// <summary>
        /// The name given to the OAuth service within App Dev Center.
        /// </summary>
        public JsString service { get; set; }
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
        public MethodGetPost method { get; set; }
        /// <summary>
        /// post data for a "POST" method request in a name=value format separated by ampersands
        /// </summary>
        public JsString body { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsObject<JsString> headers { get; set; }

        [JsMethod(Name = "addHeader")]
        public void AddHeader(JsString name, object value) { }
    }

    /// <summary>
    /// Authorize or revoke authorization for a service such as Twitter or LinkedIn
    /// </summary>
    public class OAuth
    {
        /// <summary>
        /// This event is fired when the accessing of oauth data is blocked by a getProtectedData call that hasn’t yet finished.
        /// </summary>
        public static event JsAction<OAuthEvent> OAuthBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.oauth.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.oauth.busy'")]
            remove { }
        }
        /// <summary>
        /// This event is fired at completion of the oauth.getProtectedData call. Success returns data for the response, failure indicates an error condition.
        /// </summary>
        public static event JsAction<OAuthEvent> OAuthProtectedData
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.oauth.protected.data'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.oauth.protected.data'")]
            remove { }
        }
        /// <summary>
        /// This event indicates when oauth initialization is complete. Success means your service keys were obtained.
        /// </summary>
        public static event JsAction<OAuthEvent> OAuthSetup
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.oauth.setup'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.oauth.setup'")]
            remove { }
        }
        /// <summary>
        /// This event is fired at completion of a oauth.unauthorizedService call. Success indicates that the specified service was unauthorized, failure indicates that the specified service was not a configured OAuth service.
        /// </summary>
        public static event JsAction<OAuthEvent> OAuthUnauthorize
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.oauth.unauthorize'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.oauth.unauthorize'")]
            remove { }
        }
        /// <summary>
        /// Fired when attempting to access oauth data before initialization is complete.
        /// </summary>
        public static event JsAction<OAuthEvent> OAuthUnavailable
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.oauth.unavailable'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.oauth.unavailable'")]
            remove { }
        }

        /// <summary>
        /// internal
        /// </summary>
        [JsProperty(Name = "internal", NativeField = true)]
        public OAuthInternal oAuthInternal { get; set; }

        /// <summary>
        /// This method removes authorization for a service that had previously been authorized.
        /// </summary>
        /// <param name="service">The name of the service to unauthorize (i.e. "twitter")</param>
        [JsMethod(Name = "unauthorizeService")]
        public void UnauthorizeService(JsString service) { }
        /// <summary>
        /// This method is used to get oauth authorization for a service, or update oauth protected data for a service once authorization is received.
        /// </summary>
        /// <param name="parameters"></param>
        [JsMethod(Name = "getProtectedData")]
        public void GetProtectedData(ProtectedDataParameters parameters) { }
    }

    /// <summary>
    /// 
    /// </summary>
    public class OAuthInternal
    {
        public JsBoolean processing { get; set; }
        public JsString oAuthServerOrigin { get; set; }
        public JsString oAuthServer { get; set; }
        [JsProperty(Name = "oAuthCB", NativeField = true)]
        public JsString oAuthCb { get; set; }
        public JsNumber oAuthCBCounter { get; set; }
        public JsObject<JsAction> oAuthRegisterCB { get; set; }

        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        [JsMethod(Name = "onmessage")]
        public void OnMessage(OAuthEvent e) { }
        [JsMethod(Name = "encodeParams")]
        public JsString encodeParams(ProtectedDataParameters parameters) { return (default(JsString)); }
    }
    #endregion

    #region Facebook and FacebookInternal (parameters to be completed)
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
    public class FacebookEvent : AppMobiEvent
    {
        public JsString data { get; set; }   // TODO verify type
    }

    [JsType(JsMode.Json)]
    public class FBData
    {
        public JsString path { get; set; }
        public FBParameters parameters { get; set; }
        public MethodGetPost method { get; set; }
    }
    /// <summary>
    /// TODO: FBParameters classes to complete, see https://fbdevwiki.com/wiki/FB.ui
    /// </summary>
    [JsType(JsMode.Json)]
    public class FBParameters
    {
        public MethodGetPost method { get; set; }
        public JsString display { get; set; }

//        public JsString message { get; set; }
//        public JsString urls { get; set; }
//        public JsNumber limit { get; set; }
    }
   [JsType(JsMode.Json)]
    public class FBParametersApprequest : FBParameters
    {
        public JsString to { get; set; }
        public JsString data { get; set; }
        public JsString title { get; set; }
        public JsString message { get; set; }
/*
filters	 JSON	 Optional, default is "", which shows a selector that includes the ability for a user to browse all friends, but also filter to friends using the application and friends not using the application. Can also be all, app_users and app_non_users. This controls what set of friends the user sees if a friend selector is shown. If all, app_users and app_non_users is specified, the user will only be able to see users in that list and will not be able to filter to another list. Additionally, an application can suggest custom filters as dictionaries with a name key and a user_ids key, which respectively have values that are a string and a list of user ids. name is the name of the custom filter that will show in the selector. user_ids is the list of friends to include, in the order they are to appear.	 Optional	 Example #1
[{name: ‘Neighbors’, user_ids: [1, 2, 3]}, {name: ‘Other Set’, user_ids: [4,5,6]}]
Example #2 [‘app_users’]
 */
    }
    [JsType(JsMode.Json)]
    public class FBParametersSend : FBParameters
    {
        public JsString name { get; set; }
        public JsString description { get; set; }
        public JsString redirect_uri { get; set; }
        public JsString link { get; set; }
        public JsString picture { get; set; }
        public JsString to { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FBParametersStreamShare : FBParameters
    {
        public JsString u { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FBParametersPermissionsRequest : FBParameters
    {
        public JsString perms { get; set; }
        public JsBoolean enable_profile_selector { get; set; }
        public JsArray<JsString> profile_selector_ids { get; set; }
    }
    [JsType(JsMode.Json)]
    public class FBParametersFriends : FBParameters
    {
        public JsString id { get; set; }
    }

    [JsType(JsMode.Json)]
    public class FBParametersFeed : FBParameters
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
    /// 
    /// </summary>
    public class Facebook
    {
        /// <summary>
        /// Fired if a second Facebook request is made while a previous request is still pending.
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookBusy
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.busy'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.busy'")]
            remove { }
        }
        /// <summary>
        /// This event is fired in response to a news feed or app request dialog.
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookDialogCompleted
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.dialog.complete'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.dialog.complete'")]
            remove { }
        }
        /// <summary>
        /// This event is fired if Facebook tries to log the user on during a dialog request, but the login fails.
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookDialogFailed
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.dialog.fail'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.dialog.fail'")]
            remove { }
        }
        /// <summary>
        /// Fired after logging a user into Facebook
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookLogin
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.login'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.login'")]
            remove { }
        }
        /// <summary>
        /// Fired after logging a user out of Facebook
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookLogout
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.logout'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.logout'")]
            remove { }
        }
        /// <summary>
        /// Fired in response to a Facebook API request.
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookRequest
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.request.response'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.request.response'")]
            remove { }
        }
        /// <summary>
        /// Fired if the Facebook session is invalidated.
        /// </summary>
        public static event JsAction<FacebookEvent> FacebookSessionInvalidated
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'appMobi.facebook.session.invalidate'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'appMobi.facebook.session.invalidate'")]
            remove { }
        }

        [JsProperty(Name = "internal", NativeField = true)]
        public FacebookInternal oFacebookInternal { get; set; }
        public JsBoolean willHandleUserTouchingLink { get; set; }

        /// <summary>
        /// This method logs the user into Facebook.
        /// </summary>
        /// <param name="permissions"></param>
        [JsMethod(Name = "login")]
        public void Login(JsString permissions) { }
        /// <summary>
        /// This method logs the user out of Facebook.
        /// </summary>
        [JsMethod(Name = "logout")]
        public void Logout() { }
        /// <summary>
        /// This method makes calls to the older REST Facebook API.
        /// </summary>
        /// <param name="command">The REST API command to have Facebook execute</param>
        /// <param name="method">The request method to call the Facebook REST API, typically GET or POST</param>
        /// <param name="parameters">Any parameters required for the request</param>
        [JsMethod(Name = "requestWithRestAPI")]
        public void RequestWithRestAPI(JsString command, MethodGetPost method, FBParameters parameters) { }
        /// <summary>
        /// This method makes calls to the new Graph Facebook API.
        /// </summary>
        /// <param name="path">The Facebook Graph PATH to execute</param>
        /// <param name="method">The request method to call the Facebook Graph API, typically GET or POST</param>
        /// <param name="parameters">Any parameters required for the request</param>
        [JsMethod(Name = "requestWithGraphAPI")]
        public void RequestWithGraphAPI(JsString path, MethodGetPost method, FBParameters parameters) { }
        /// <summary>
        /// This command ensures that news feed requests are "frictionless" in that it enables users to send requests to specific friends without having to click on a pop-up confirmation dialog.
        /// </summary>
        /// <param name="parameters">A JSON object holding the appropriate parameters for the request as specified in Facebook's documentation</param>
        [JsMethod(Name = "showAppRequestDialog")]
        public void ShowAppRequestDialog(FBParameters parameters) { }
        /// <summary>
        /// A JSON object holding the appropriate parameters for the request as specified in Facebook's documentation.
        /// </summary>
        /// <param name="parameters">A JSON object holding the appropriate parameters for the request as specified in Facebook's documentation</param>
        [JsMethod(Name = "showNewsFeedDialog")]
        public void ShowNewsFeedDialog(FBParameters parameters) { }
        /// <summary>
        /// This command ensures that news feed requests are "frictionless" in that it enables users to send requests to specific friends without having to click on a pop-up confirmation dialog.
        /// </summary>
        [JsMethod(Name = "enableFrictionlessRequests")]
        public void EnableFrictionlessRequests() { }

    }

    /// <summary>
    /// 
    /// </summary>
    public class FacebookInternal
    {
        public JsString _keyStr { get; set; }
        public JsBoolean busy { get; set; }
        public JsBoolean frictionless { get; set; }

        [JsMethod(Name = "busyError")]
        public void BusyError() { }
        [JsMethod(Name = "initialize")]
        public void Initialize() { }
        [JsMethod(Name = "setCommunicationFrameUrl")]
        public void SetCommunicationFrameUrl(JsString url) { }
        [JsMethod(Name = "callbackComplete")]
        public void CallbackComplete() { }
        [JsMethod(Name = "login")]
        public void Login(JsString scope) { }
        [JsMethod(Name = "logout")]
        public void Logout() { }
        [JsMethod(Name = "appRequest")]
        public void AppRequest(FBParameters parameters) { }
        [JsMethod(Name = "api")]
        public void Api(JsString path, JsString httpMethod, FBParameters parameters) { }
        [JsMethod(Name = "ui")]
        public void Ui(FBParameters parameters, JsString responseType) { }
        [JsMethod(Name = "handleResponse")]
        public void HandleResponse(JsString eventName,JsBoolean success, JsString responseData, object extra, JsBoolean remainbusy) { }    // TODO verify type
        [JsMethod(Name = "handleResponse")]
        public void HandleResponse(JsString eventName,JsBoolean success, JsString responseData, object extra) { }      // TODO verify type
        [JsMethod(Name = "apiCall")]
        public void ApiCall(JsString func, JsArray<FBParameters> args, JsString responseType) { }   // TODO verify type
        [JsMethod(Name = "base64Encode")]
        public JsString Base64Encode() { return (default(JsString)); }
        [JsMethod(Name = "base64Decode")]
        public JsString Base64Decode() { return (default(JsString)); }
        [JsMethod(Name = "_utf8_encode")]
        public JsString Utf8Encode() { return (default(JsString)); }
        [JsMethod(Name = "_utf8_decode")]
        public JsString Utf8Decode() { return (default(JsString)); }
    }
    #endregion

    #region Multitouch
    /// <summary>
    /// Allows applications to listen for multiple simultaneous touch events on an Android device.
    /// </summary>
    public class Multitouch
    {
        /// <summary>
        /// This method starts listening for Android multi touch events on HTML elements at the cost of some device resources. It must be called if your app requires multitouch.
        /// </summary>
        public void enable() { }

        public static event JsAction<MultitouchEvent> TouchStart
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'touchstart'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'touchstart'")]
            remove { }
        }
        public static event JsAction<MultitouchEvent> TouchEnd
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'touchend'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'touchend'")]
            remove { }
        }
        public static event JsAction<MultitouchEvent> TouchMove
        {
            [JsMethod(Global = true, Name = "document.addEventListener", InsertArg0 = "'touchmove'")]
            add { }
            [JsMethod(Global = true, Name = "document.removeEventListener", InsertArg0 = "'touchmove'")]
            remove { }
        }
    }
    #endregion

}
