using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;
[assembly: JsNamespace(Namespace = "SharpKit.Google.Chrome", JsNamespace = "chrome")]
namespace SharpKit.Google.Chrome
{

    #region alarms

    /// <summary>
    /// Warning: This API is still under development. It is only available for Chrome users on the dev early release channel. Learn more.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false)]
    public class alarms
    {
        /// <summary>
        /// Clears the alarm with the given name.
        /// </summary>
        /// <param name="name">The name of the alarm to clear. Defaults to the empty string.</param>
        public static void clear(JsString name) { }
        /// <summary>
        /// Clears the alarm with the given name.
        /// </summary>
        public static void clear() { }

        /// <summary>
        /// Clears all alarms.
        /// </summary>
        public static void clearAll() { }

        /// <summary>
        /// Creates an alarm. Near the time(s) specified by 'alarmInfo', the onAlarm event is fired. If there is another alarm with the same name (or no name if none is specified),
        /// it will be cancelled and replaced by this alarm. Note that granularity is not guaranteed: times are more of a hint to the browser. For performance reasons, alarms may be delayed an arbitrary amount of time before firing. string. be specified by either |when| or |delayInMinutes| (but not both). If minutes after the initial event.
        /// If neither |when| or |delayInMinutes| is set for a repeating alarm, |periodInMinutes| is used as the default for |delayInMinutes|.
        /// </summary>
        /// <param name="name">Optional name to identify this alarm. Defaults to the empty</param>
        /// <param name="alarmInfo">Describes when the alarm should fire. The initial time must</param>
        public static void create(JsString name, AlarmCreateInfo alarmInfo) { }
        /// <summary>
        /// Creates an alarm. Near the time(s) specified by 'alarmInfo', the onAlarm event is fired. If there is another alarm with the same name (or no name if none is specified),
        /// it will be cancelled and replaced by this alarm. Note that granularity is not guaranteed: times are more of a hint to the browser. For performance reasons, alarms may be delayed an arbitrary amount of time before firing. string. be specified by either |when| or |delayInMinutes| (but not both). If minutes after the initial event.
        /// If neither |when| or |delayInMinutes| is set for a repeating alarm, |periodInMinutes| is used as the default for |delayInMinutes|.
        /// </summary>
        /// <param name="alarmInfo">Describes when the alarm should fire. The initial time must</param>
        public static void create(AlarmCreateInfo alarmInfo) { }

        /// <summary>
        /// Retrieves details about the specified alarm.
        /// </summary>
        /// <param name="name">The name of the alarm to get. Defaults to the empty string.</param>
        /// <param name="AlarmCallback"></param>
        public static void get(JsString name, JsAction<Alarm> AlarmCallback) { }
        /// <summary>
        /// Retrieves details about the specified alarm.
        /// </summary>
        /// <param name="AlarmCallback"></param>
        public static void get(JsAction<Alarm> AlarmCallback) { }

        /// <summary>
        /// Gets an array of all the alarms.
        /// </summary>
        /// <param name="AlarmListCallback"></param>
        public static void getAll(JsAction<JsArray<Alarm>> AlarmListCallback) { }

        /// <summary>
        /// Fired when an alarm has elapsed. Useful for transient background pages.
        /// </summary>
        public static Event<JsAction<Alarm>> onAlarm { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.alarms.Alarm", Export = false)]
    public class Alarm
    {
        /// <summary>
        /// Name of this alarm.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional )
        /// If not null, the alarm is a repeating alarm and will fire again in 'periodInMinutes' minutes.
        /// </summary>
        public JsNumber periodInMinutes { get; set; }

        /// <summary>
        /// Time at which this alarm was scheduled to fire, in milliseconds past the epoch (e.g. Date.now() + n).
        /// For performance reasons, the alarm may have been delayed an arbitrary amount beyond this.
        /// </summary>
        public JsNumber scheduledTime { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.alarms.AlarmCreateInfo", Export = false)]
    public class AlarmCreateInfo
    {
        /// <summary>
        /// ( optional )
        /// Length of time in minutes after which the onAlarm event should fire. TODO: need minimum=0
        /// </summary>
        public JsNumber delayInMinutes { get; set; }

        /// <summary>
        /// ( optional )
        /// If set, the onAlarm event should fire every |periodInMinutes| minutes after the initial event specified by |when| or |delayInMinutes|.
        /// If not set, the alarm will only fire once. TODO: need minimum=0
        /// </summary>
        public JsNumber periodInMinutes { get; set; }

        /// <summary>
        /// ( optional )
        /// Time at which the alarm should fire, in milliseconds past the epoch (e.g. Date.now() + n).
        /// </summary>
        public JsNumber when { get; set; }
    }
    //The "TODO" in this class are googles' not mays'

    #endregion

    #region bookmarks

    /// <summary>
    /// Use the chrome.bookmarks module to create, organize, and otherwise manipulate bookmarks. Also see Override Pages, which you can use to create a custom Bookmark Manager page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.bookmarks", Export = false)]
    public class bookmarks
    {
        /// <summary>
        /// Creates a bookmark or folder under the specified parentId. If url is NULL or missing, it will be a folder.
        /// </summary>
        /// <param name="bookmark"></param>
        /// <param name="callback"></param>
        public static void create(Bookmark bookmark, JsAction callback) { }

        /// <summary>
        /// Retrieves the specified BookmarkTreeNode(s).
        /// </summary>
        /// <param name="idOrIdList">A single string-valued id, or an array of string-valued ids</param>
        /// <param name="callback"></param>
        public static void get(JsString idOrIdList, JsAction callback) { }
        /// <summary>
        /// Retrieves the specified BookmarkTreeNode(s).
        /// </summary>
        /// <param name="idOrIdList">A single string-valued id, or an array of string-valued ids</param>
        /// <param name="callback"></param>
        public static void get(JsArray<JsString> idOrIdList, JsAction callback) { }

        /// <summary>
        /// Retrieves the children of the specified BookmarkTreeNode id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void getChildren(JsString id, JsAction callback) { }

        /// <summary>
        /// Retrieves the recently added bookmarks.
        /// </summary>
        /// <param name="numberOfItems">The maximum number of items to return.</param>
        /// <param name="callback"></param>
        public static void getRecent(JsNumber numberOfItems, JsAction callback) { }

        /// <summary>
        /// Retrieves part of the Bookmarks hierarchy, starting at the specified node.
        /// </summary>
        /// <param name="id">The ID of the root of the subtree to retrieve.</param>
        /// <param name="callback"></param>
        public static void getSubTree(JsString id, JsAction callback) { }

        /// <summary>
        /// Retrieves the entire Bookmarks hierarchy.
        /// </summary>
        /// <param name="callback"></param>
        public static void getTree(JsAction callback) { }

        /// <summary>
        /// Moves the specified BookmarkTreeNode to the provided location.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destination"></param>
        /// <param name="callback"></param>
        public static void move(JsString id, BookmarkMoveDestination destination, JsAction callback) { }
        /// <summary>
        /// Moves the specified BookmarkTreeNode to the provided location.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="destination"></param>
        public static void move(JsString id, BookmarkMoveDestination destination) { }

        /// <summary>
        /// Removes a bookmark or an empty bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void remove(JsString id, JsAction callback) { }
        /// <summary>
        /// Removes a bookmark or an empty bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        public static void remove(JsString id) { }

        /// <summary>
        /// Recursively removes a bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callback"></param>
        public static void removeTree(JsString id, JsAction callback) { }
        /// <summary>
        /// Recursively removes a bookmark folder.
        /// </summary>
        /// <param name="id"></param>
        public static void removeTree(JsString id) { }

        /// <summary>
        /// Searches for BookmarkTreeNodes matching the given query.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="callback"></param>
        public static void search(JsString query, JsAction callback) { }

        /// <summary>
        /// Updates the properties of a bookmark or folder. Specify only the properties that you want to change;
        /// unspecified properties will be left unchanged. Note: Currently, only 'title' and 'url' are supported.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="changes"></param>
        /// <param name="callback"></param>
        public static void update(JsString id, BookmarkUpdateChanges changes, JsAction callback) { }

        /// <summary>
        /// Fired when a bookmark or folder changes. Note: Currently, only title and url changes trigger this.
        /// </summary>
        public static Event<JsAction<string, BookmarkChangeInfoDestination>> onChanged { get; set; }

        /// <summary>
        /// Fired when the children of a folder have changed their order due to the order being sorted in the UI. This is not called as a result of a move().
        /// </summary>
        public static Event<JsAction<string, BookmarkReorderInfoDestination>> onChildrenReordered { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is created.
        /// </summary>
        public static Event<JsAction<string, BookmarkTreeNode>> onCreated { get; set; }

        /// <summary>
        /// Fired when a bookmark import session is begun.
        /// Expensive observers should ignore handleCreated updates until onImportEnded is fired. Observers should still handle other notifications immediately.
        /// </summary>
        public static Event<JsAction> onImportBegan { get; set; }

        /// <summary>
        /// Fired when a bookmark import session is ended.
        /// </summary>
        public static Event<JsAction> onImportEnded { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is moved to a different parent folder.
        /// </summary>
        public static Event<JsAction<string, BookmarkMoveInfo>> onMoved { get; set; }

        /// <summary>
        /// Fired when a bookmark or folder is removed. When a folder is removed recursively, a single notification is fired for the folder, and none for its contents.
        /// </summary>
        public static Event<JsAction<string, BookmarkRemoveInfo>> onRemoved { get; set; }

    }

    [JsType(JsMode.Json)]
    public class Bookmark
    {
        /// <summary>
        /// ( optional )
        /// Defaults to the Other Bookmarks folder.
        /// </summary>
        public JsString parentId { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString url { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkMoveDestination
    {
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString parentId { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsNumber index { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkUpdateChanges
    {
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString title { get; set; }
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString url { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkChangeInfoDestination
    {
        public JsString title { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString url { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkReorderInfoDestination
    {
        public JsArray<JsString> childIds { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkMoveInfo
    {
        public JsString parentId { get; set; }

        public JsNumber index { get; set; }

        public JsString oldParentId { get; set; }

        public JsNumber oldIndex { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BookmarkRemoveInfo
    {
        public JsString parentId { get; set; }

        public JsNumber index { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.bookmarks.BookmarkTreeNode", Export = false)]
    public class BookmarkTreeNode
    {
        /// <summary>
        /// The unique identifier for the node. IDs are unique within the current profile, and they remain valid even after the browser is restarted.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional ) The id of the parent folder. Omitted for the root node.
        /// </summary>
        public JsString parentId { get; set; }

        /// <summary>
        ///  ( optional ) The 0-based position of this node within its parent folder.
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// ( optional )The URL navigated to when a user clicks the bookmark. Omitted for folders.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The text displayed for the node.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional ) When this node was created, in milliseconds since the epoch (new Date(dateAdded)).
        /// </summary>
        public JsNumber dateAdded { get; set; }

        /// <summary>
        /// ( optional ) When the contents of this folder last changed, in milliseconds since the epoch.
        /// </summary>
        public JsNumber dateGroupModified { get; set; }

        /// <summary>
        /// ( optional array of bookmarks.BookmarkTreeNode ) An ordered list of children of this node.
        /// </summary>
        public JsArray<BookmarkTreeNode> children { get; set; }
    }

    #endregion

    #region browserAction
    /// <summary>
    /// Use browser actions to put icons in the main Google Chrome toolbar, to the right of the address bar.
    /// In addition to its icon, a browser action can also have a tooltip, a badge, and a popup.
    /// For the best visual impact, follow these guidelines:
    /// Do use browser actions for features that make sense on most pages.
    /// Don't use browser actions for features that make sense for only a few pages. Use page actions instead.
    /// Do use big, colorful icons that make the most of the 19x19-pixel space. Browser action icons should seem a little bigger and heavier than page action icons.
    /// Don't attempt to mimic Google Chrome's monochrome "wrench" icon. That doesn't work well with themes, and anyway, extensions should stand out a little.
    /// Do use alpha transparency to add soft edges to your icon. Because many people use themes, your icon should look nice on a variety of background colors.
    /// Don't constantly animate your icon. That's just annoying.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.browserAction", Export = false)]
    public class browserAction
    {
        /// <summary>
        /// Gets the background color of the browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getBadgeBackgroundColor(BrowserActionBadgeBackgroundColorDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the badge text of the browser action. If no tab is specified, the non-tab-specific badge text is returned.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getBadgeText(BrowserActionBadgeTextDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the html document set as the popup for this browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getPopup(BrowserActionPopupDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the title of the browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getTitle(BrowserActionTitleDetails details, JsAction callback) { }

        /// <summary>
        /// Sets the background color for the badge.
        /// </summary>
        /// <param name="details"></param>
        public static void setBadgeBackgroundColor(BrowserActionBadgeBackgroundColorDetails details) { }

        /// <summary>
        /// Sets the badge text for the browser action. The badge is displayed on top of the icon.
        /// </summary>
        /// <param name="details"></param>
        public static void setBadgeText(BrowserActionBadgeTextDetails details) { }

        /// <summary>
        /// Sets the icon for the browser action. The icon can be specified either as the path to an image file or as the pixel data from a canvas element.
        /// Either the path or the imageData property must be specified.
        /// </summary>
        /// <param name="details"></param>
        public static void setIcon(BrowserActionSetIconDetails details) { }

        /// <summary>
        /// Sets the html document to be opened as a popup when the user clicks on the browser action's icon.
        /// </summary>
        /// <param name="details"></param>
        public static void setPopup(BrowserActionPopupDetails details) { }

        /// <summary>
        /// Sets the title of the browser action. This shows up in the tooltip.
        /// </summary>
        /// <param name="details"></param>
        public static void setTitle(BrowserActionTitleDetails details) { }

        /// <summary>
        /// Fired when a browser action icon is clicked. This event will not fire if the browser action has a popup.
        /// </summary>
        public static Event<JsAction<Tab>> onClicked { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BrowserActionBadgeBackgroundColorDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// An array of four integers in the range [0,255] that make up the RGBA color of the badge.
        /// For example, opaque red is [255, 0, 0, 255]. Can also be a string with a CSS value, with opaque red being #FF0000 or #F00.
        /// </summary>
        [JsProperty(Name = "color")]
        public JsString colorString { get; set; }

        /// <summary>
        /// This property is available for setter operations only.
        /// An array of four integers in the range [0,255] that make up the RGBA color of the badge.
        /// For example, opaque red is [255, 0, 0, 255]. Can also be a string with a CSS value, with opaque red being #FF0000 or #F00.
        /// </summary>
        public ColorArray color { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the badge background color from.
        /// If no tab is specified, the non-tab-specific badge background color is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionBadgeTextDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// Any number of characters can be passed, but only about four can fit in the space.
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the badge text from. If no tab is specified, the non-tab-specific badge text is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }

    }

    [JsType(JsMode.Json)]
    public class BrowserActionPopupDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
        /// </summary>
        public JsString popup { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the popup from. If no tab is specified, the non-tab-specific popup is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionTitleDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The string the browser action should display when moused over.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// When using the getter operations: Specify the tab to get the title from. If no tab is specified, the non-tab-specific title is returned.
        /// When using the setter operations: Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionSetIconDetails
    {
        /// <summary>
        /// ( optional )
        /// Pixel data for an image. Must be an ImageData object (for example, from a canvas element).
        /// </summary>
        public ImageData imageData { get; set; }

        /// <summary>
        /// ( optional )
        /// Relative path to an image in the extension to show in the browser action.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// ( optional )
        /// Limits the change to when a particular tab is selected. Automatically resets when the tab is closed.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.browserAction.ColorArray", Export = false)]
    public class ColorArray : JsArray<JsNumber>
    {
    }

    #endregion

    #region browsingData

    /// <summary>
    /// Use the chrome.browsingData module to remove browsing data from a user's local profile.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.browsingData", Export = false)]
    public class browsingData
    {
        /// <summary>
        /// Clears various types of browsing data stored in a user's profile.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="dataToRemove"></param>
        /// <param name="callback"></param>
        public static void remove(RemovalOptions options, BrowsingDataDataToRemove dataToRemove, JsAction callback) { }
        /// <summary>
        /// Clears various types of browsing data stored in a user's profile.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="dataToRemove"></param>
        public static void remove(RemovalOptions options, BrowsingDataDataToRemove dataToRemove) { }

        /// <summary>
        /// Clears websites' appcache data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional )Called when websites' appcache data has been cleared.</param>
        public static void removeAppcache(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' appcache data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeAppcache(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's cache.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional )Called when the browser's cache has been cleared.</param>
        public static void removeCache(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's cache.
        /// </summary>
        /// <param name="options"></param>
        public static void removeCache(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's cookies modified within a particular timeframe.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's cookies have been cleared.</param>
        public static void removeCookies(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's cookies modified within a particular timeframe.
        /// </summary>
        /// <param name="options"></param>
        public static void removeCookies(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's list of downloaded files (not the downloaded files themselves).
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's list of downloaded files has been cleared.</param>
        public static void removeDownloads(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's list of downloaded files (not the downloaded files themselves).
        /// </summary>
        /// <param name="options"></param>
        public static void removeDownloads(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' file system data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback"> ( optional ) Called when websites' file systems have been cleared.</param>
        public static void removeFileSystems(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' file system data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeFileSystems(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's stored form data (autofill).
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's form data has been cleared.</param>
        public static void removeFormData(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's stored form data (autofill).
        /// </summary>
        /// <param name="options"></param>
        public static void removeFormData(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's history.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's history has cleared.</param>
        public static void removeHistory(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's history.
        /// </summary>
        /// <param name="options"></param>
        public static void removeHistory(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' IndexedDB data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when websites' IndexedDB data has been cleared.</param>
        public static void removeIndexedDB(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' IndexedDB data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeIndexedDB(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' local storage data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when websites' local storage has been cleared.</param>
        public static void removeLocalStorage(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' local storage data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeLocalStorage(RemovalOptions options) { }

        /// <summary>
        /// Clears the browser's stored passwords.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when the browser's passwords have been cleared.</param>
        public static void removePasswords(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears the browser's stored passwords.
        /// </summary>
        /// <param name="options"></param>
        public static void removePasswords(RemovalOptions options) { }

        /// <summary>
        /// Clears plugins' data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) Called when plugins' data has been cleared.</param>
        public static void removePluginData(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears plugins' data.
        /// </summary>
        /// <param name="options"></param>
        public static void removePluginData(RemovalOptions options) { }

        /// <summary>
        /// Clears websites' WebSQL data.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="callback"> ( optional ) Called when websites' WebSQL databases have been cleared.</param>
        public static void removeWebSQL(RemovalOptions options, JsAction callback) { }
        /// <summary>
        /// Clears websites' WebSQL data.
        /// </summary>
        /// <param name="options"></param>
        public static void removeWebSQL(RemovalOptions options) { }
    }

    [JsType(JsMode.Json)]
    public class BrowsingDataDataToRemove
    {
        /// <summary>
        /// ( optional )
        /// Should websites' appcaches be cleared?
        /// </summary>
        public bool appcache { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's cache be cleared? Note: this clears the entire cache: it is not limited to the range you specify.
        /// </summary>
        public bool cache { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's cookies be cleared?
        /// </summary>
        public bool cookies { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's download list be cleared?
        /// </summary>
        public bool downloads { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' file systems be cleared?
        /// </summary>
        public bool fileSystems { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's stored form data be cleared?
        /// </summary>
        public bool formData { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the browser's history be cleared?
        /// </summary>
        public bool history { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' IndexedDB data be cleared?
        /// </summary>
        public bool indexedDB { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' local storage data be cleared?
        /// </summary>
        public bool localStorage { get; set; }

        /// <summary>
        /// ( optional )
        /// Should server-bound certificates be removed?
        /// </summary>
        public bool serverBoundCertificates { get; set; }

        /// <summary>
        /// ( optional )
        /// Should plugins' data be cleared?
        /// </summary>
        public bool pluginData { get; set; }

        /// <summary>
        /// ( optional )
        /// Should the stored passwords be cleared?
        /// </summary>
        public bool passwords { get; set; }

        /// <summary>
        /// ( optional )
        /// Should websites' WebSQL data be cleared?
        /// </summary>
        public bool webSQL { get; set; }

    }

    /// <summary>
    /// Options that determine exactly what data will be removed.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.browsingData.RemovalOptions", Export = false)]
    public class RemovalOptions
    {
        /// <summary>
        /// Remove data accumulated on or after this date, represented in milliseconds since the epoch(accessible via the getTime method of the JavaScript Date object).
        /// If absent, defaults to 0 (which would remove all browsing data).
        /// </summary>
        public JsNumber since { get; set; }

        /// <summary>
        /// An object whose properties specify which origin types ought to be cleared. If this object isn't specified, it defaults to clearing only "unprotected" origins.
        /// Please ensure that you really want to remove application data before adding 'protectedWeb' or 'extensions'.
        /// </summary>
        public RemovalOptionsOriginTypes originTypes { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RemovalOptionsOriginTypes
    {
        /// <summary>
        /// ( optional )Normal websites.
        /// </summary>
        public bool unprotectedWeb { get; set; }

        /// <summary>
        /// ( optional )Websites that have been installed as hosted applications (be careful!).
        /// </summary>
        public bool protectedWeb { get; set; }

        /// <summary>
        /// ( optional ) Extensions and packaged applications a user has installed (be _really_ careful!).
        /// </summary>
        public bool extension { get; set; }
    }

    #endregion

    #region contentSettings

    /// <summary>
    /// The content settings module allows you to change settings that control whether websites can use features such as cookies, JavaScript, and plug-ins.
    /// More generally speaking, content settings allow you to customize Chrome's behavior on a per-site basis instead of globally.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.contentSettings", Export = false)]
    public class contentSettings
    {
        /// <summary>
        /// Whether to allow cookies and other local data to be set by websites. One of
        /// allow: Accept cookies,
        /// block: Block cookies,
        /// session_only: Accept cookies only for the current session. 
        /// Default is allow.
        /// The primary URL is the URL representing the cookie origin. The secondary URL is the URL of the top-level frame.
        /// </summary>
        public ContentSetting cookies { get; set; }

        /// <summary>
        /// Whether to show images. One of
        /// allow: Show images,
        /// block: Don't show images. 
        /// Default is allow.
        /// The primary URL is the main-frame URL. The secondary URL is the URL of the image.
        /// </summary>
        public ContentSetting images { get; set; }

        /// <summary>
        /// Whether to run JavaScript. One of
        /// allow: Run JavaScript,
        /// block: Don't run JavaScript. 
        /// Default is allow.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting javascript { get; set; }

        /// <summary>
        /// Whether to run plug-ins. One of
        /// allow: Run plug-ins automatically,
        /// block: Don't run plug-ins automatically. 
        /// Default is allow.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting plugins { get; set; }

        /// <summary>
        /// Whether to allow sites to show pop-ups. One of
        /// allow: Allow sites to show pop-ups,
        /// block: Don't allow sites to show pop-ups. 
        /// Default is block.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting popups { get; set; }

        /// <summary>
        /// Whether to allow sites to show desktop notifications. One of
        /// allow: Allow sites to show desktop notifications,
        /// block: Don't allow sites to show desktop notifications,
        /// ask: Ask when a site wants to show desktop notifications. 
        /// Default is ask.
        /// The primary URL is the main-frame URL. The secondary URL is not used.
        /// </summary>
        public ContentSetting notifications { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.contentSettings.ContentSetting", Export = false)]
    public class ContentSetting
    {
        /// <summary>
        /// Clear all content setting rules set by this extension.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void clear(ContentSettingClearDetails details, JsAction callback) { }
        /// <summary>
        /// Clear all content setting rules set by this extension.
        /// </summary>
        /// <param name="details"></param>
        public static void clear(ContentSettingClearDetails details) { }

        /// <summary>
        /// Gets the current content setting for a given pair of URLs.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void get(ContentSettingGetDetails details, JsAction callback) { }

        public static void getResourceIdentifiers(JsAction callback) { }

        /// <summary>
        /// Applies a new content setting rule.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void set(ContentSettingSetDetails details, JsAction callback) { }
        /// <summary>
        /// Applies a new content setting rule.
        /// </summary>
        /// <param name="details"></param>
        public static void set(ContentSettingSetDetails details) { }
    }
    //TODO: the methods in this class are static right?

    /// <summary>
    /// The only content type using resource identifiers is plugins. For more information, see Resource Identifiers.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.contentSettings.ResourceIdentifier", Export = false)]
    public class ResourceIdentifier
    {

        /// <summary>
        /// The resource identifier for the given content type.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional )A human readable description of the resource.
        /// </summary>
        public JsString description { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ContentSettingClearDetails
    {
        /// <summary>
        /// ( optional enumerated string ["regular", "incognito_session_only"] ). Where to set the setting (default: regular). 
        /// </summary>
        public ContentSettingScopeType scope { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ContentSettingScopeType
    {
        /// <summary>
        /// setting for regular profile (which is inherited by the incognito profile if not overridden elsewhere),
        /// </summary>
        regular,
        /// <summary>
        /// setting for incognito profile that can only be set during an incognito session and is deleted when the incognito session ends (overrides regular settings).
        /// </summary>
        incognito_session_only,
    }
    //TODO: make sure i was right with this eunm

    [JsType(JsMode.Json)]
    public class ContentSettingGetDetails
    {
        /// <summary>
        /// The primary URL for which the content setting should be retrieved. Note that the meaning of a primary URL depends on the content type.
        /// </summary>
        public JsString primaryUrl { get; set; }

        /// <summary>
        /// ( optional ) The secondary URL for which the content setting should be retrieved. Defaults to the primary URL.
        /// Note that the meaning of a secondary URL depends on the content type, and not all content types use secondary URLs.
        /// </summary>
        public JsString secondaryUrl { get; set; }

        /// <summary>
        ///  ( optional ) A more specific identifier of the type of content for which the settings should be retrieved.
        /// </summary>
        public ResourceIdentifier resourceIdentifier { get; set; }

        /// <summary>
        /// ( optional ) Whether to check the content settings for an incognito session. (default false)
        /// </summary>
        public bool incognito { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ContentSettingSetDetails
    {
        /// <summary>
        /// The pattern for the primary URL. For details on the format of a pattern, see Content Setting Patterns.
        /// </summary>
        public JsString primaryPattern { get; set; }

        /// <summary>
        /// ( optional ) The pattern for the secondary URL. Defaults to matching all URLs. For details on the format of a pattern, see Content Setting Patterns.
        /// </summary>
        public JsString secondaryPattern { get; set; }

        /// <summary>
        ///  ( optional ) The resource identifier for the content type.
        /// </summary>
        public ResourceIdentifier resourceIdentifier { get; set; }

        /// <summary>
        /// The setting applied by this rule. See the description of the individual ContentSetting objects for the possible values.
        /// </summary>
        public ContentSetting setting { get; set; }

        /// <summary>
        /// ( optional enumerated string ["regular", "incognito_session_only"] ).Where to clear the setting (default: regular). 
        /// </summary>
        public ContentSettingScopeType scope { get; set; }
    }

    #endregion

    #region contextMenus

    [JsType(JsMode.Prototype, Name = "chrome.contextMenus", Export = false)]
    public class contextMenus
    {
        /// <summary>
        /// Creates a new context menu item. Note that if an error occurs during creation,
        /// you may not find out until the creation callback fires (the details will be in chrome.extension.lastError).
        /// </summary>
        /// <param name="createProperties"></param>
        /// <param name="callback">( optional )Called when the item has been created in the browser.
        /// If there were any problems creating the item, details will be available in chrome.extension.lastError.</param>
        /// <returns></returns>
        public static object create(CreateProperties createProperties, JsAction callback) { return null; }
        /// <summary>
        /// Creates a new context menu item. Note that if an error occurs during creation,
        /// you may not find out until the creation callback fires (the details will be in chrome.extension.lastError).
        /// </summary>
        /// <param name="createProperties"></param>
        /// <returns></returns>
        public static object create(CreateProperties createProperties) { return null; }

        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        /// <param name="callback">( optional function ) Called when the context menu has been removed.</param>
        public static void remove(JsNumber menuItemId, JsAction callback) { }
        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        /// <param name="callback">( optional function ) Called when the context menu has been removed.</param>
        public static void remove(JsString menuItemId, JsAction callback) { }
        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        public static void remove(JsNumber menuItemId) { }
        /// <summary>
        /// Removes a context menu item.
        /// </summary>
        /// <param name="menuItemId">The ID of the context menu item to remove.</param>
        public static void remove(JsString menuItemId) { }

        /// <summary>
        /// Removes all context menu items added by this extension.
        /// </summary>
        /// <param name="callback">( optional )Called when removal is complete.</param>
        public static void removeAll(JsAction callback) { }
        /// <summary>
        /// Removes all context menu items added by this extension.
        /// </summary>
        public static void removeAll() { }

        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        /// <param name="callback"> ( optional ) Called when the context menu has been updated.</param>
        public static void update(JsNumber id, UpdateProperties updateProperties, JsAction callback) { }
        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        /// <param name="callback"> ( optional ) Called when the context menu has been updated.</param>
        public static void update(JsString id, UpdateProperties updateProperties, JsAction callback) { }
        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        public static void update(JsNumber id, UpdateProperties updateProperties) { }
        /// <summary>
        /// Updates a previously created context menu item.
        /// </summary>
        /// <param name="id">The ID of the item to update</param>
        /// <param name="updateProperties">The properties to update. Accepts the same values as the create function.</param>
        public static void update(JsString id, UpdateProperties updateProperties) { }

        /// <summary>
        /// Fired when a context menu item is clicked.
        /// </summary>
        public static Event<JsAction<OnClickData, Tab>> onClicked { get; set; }
    }

    [JsType(JsMode.Json)]
    public class CreateProperties
    {
        /// <summary>
        ///  ( optional enumerated string ["normal", "checkbox", "radio", "separator"] )
        ///  The type of menu item. Defaults to 'normal' if not specified.
        /// </summary>
        public CreatePropertiesType type { get; set; }

        /// <summary>
        /// ( optional )
        /// The unique ID to assign to this item. Mandatory for event pages. Cannot be the same as another ID for this extension.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional )
        /// The text to be displayed in the item; this is required unless type is 'separator'. When the context is 'selection', you can use %s within the string to show the selected text.
        /// For example, if this parameter's value is "Translate '%s' to Pig Latin" and the user selects the word "cool",the context menu item for the selection is "Translate 'cool' to Pig Latin".
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional )
        /// The initial state of a checkbox or radio item: true for selected and false for unselected. Only one radio item can be selected at a time in a given group of radio items.
        /// </summary>
        public bool @checked { get; set; }

        /// <summary>
        /// ( optional array of string ["all", "page", "frame", "selection", "link", "editable", "image", "video", "audio"] )
        /// List of contexts this menu item will appear in. Defaults to ['page'] if not specified.
        /// </summary>
        public JsArray<CreatePropertiesContexts> contexts { get; set; }

        /// <summary>
        /// ( optional )
        /// A function that will be called back when the menu item is clicked.
        /// Event pages cannot use this; instead, they should register a listener for chrome.contextMenus.onClicked.
        /// </summary>
        public JsAction<Tab, OnClickData> onclick { get; set; }

        /// <summary>
        /// ( optional )
        /// The ID of a parent menu item; this makes the item a child of a previously added item.
        /// </summary>
        [JsProperty(Name = "parentId")]
        public JsString parentIdString { get; set; }
        /// <summary>
        /// ( optional )
        /// The ID of a parent menu item; this makes the item a child of a previously added item.
        /// </summary>
        public JsNumber parentId { get; set; }

        /// <summary>
        /// ( optional )
        /// Lets you restrict the item to apply only to documents whose URL matches one of the given patterns.
        /// (This applies to frames as well.) For details on the format of a pattern, see Match Patterns.
        /// </summary>
        public JsArray<JsString> documentUrlPatterns { get; set; }

        /// <summary>
        /// ( optional )
        /// Similar to documentUrlPatterns, but lets you filter based on the src attribute of img/audio/video tags and the href of anchor tags.
        /// </summary>
        public JsArray<JsString> targetUrlPatterns { get; set; }

        /// <summary>
        /// ( optional )
        /// Whether this context menu item is enabled or disabled. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CreatePropertiesType
    {
        normal,
        checkbox,
        radio,
        separator,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CreatePropertiesContexts
    {
        all,
        page,
        frame,
        selection,
        link,
        editable,
        image,
        video,
        audio,
    }

    /// <summary>
    /// Information sent when a context menu item is clicked.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.contextMenus.OnClickData", Export = false)]
    public class OnClickData
    {
        /// <summary>
        /// The ID of the menu item that was clicked.
        /// </summary>
        [JsProperty(Name = "menuItemId")]
        public JsString menuItemIdString { get; set; }
        /// <summary>
        /// The ID of the menu item that was clicked.
        /// </summary>
        [JsProperty(Name = "menuItemId")]
        public JsNumber menuItemId { get; set; }

        /// <summary>
        /// ( optional ) The parent ID, if any, for the item clicked.
        /// </summary>
        [JsProperty(Name = "parentMenuItemId")]
        public JsString parentMenuItemIdString { get; set; }
        /// <summary>
        /// ( optional ) The parent ID, if any, for the item clicked.
        /// </summary>
        public JsNumber parentMenuItemId { get; set; }

        /// <summary>
        /// ( optional ) One of 'image', 'video', or 'audio' if the context menu was activated on one of these types of elements.
        /// </summary>
        public MediaType mediaType { get; set; }

        /// <summary>
        /// ( optional ) If the element is a link, the URL it points to.
        /// </summary>
        public JsString linkUrl { get; set; }

        /// <summary>
        /// ( optional ) Will be present for elements with a 'src' URL.
        /// </summary>
        public JsString srcUrl { get; set; }

        /// <summary>
        /// The URL of the page where the menu item was clicked.
        /// </summary>
        public JsString pageUrl { get; set; }

        /// <summary>
        /// ( optional ) The URL of the frame of the element where the context menu was clicked, if it was in a frame.
        /// </summary>
        public JsString frameUrl { get; set; }

        /// <summary>
        /// ( optional ) The text for the context selection, if any.
        /// </summary>
        public JsString selectionText { get; set; }

        /// <summary>
        /// ( optional ) A flag indicating whether the element is editable (text input, textarea, etc.).
        /// </summary>
        public bool editable { get; set; }

        /// <summary>
        /// ( optional ) A flag indicating the state of a checkbox or radio item before it was clicked.
        /// </summary>
        public bool wasChecked { get; set; }

        /// <summary>
        /// ( optional ) A flag indicating the state of a checkbox or radio item after it is clicked.
        /// </summary>
        public bool @checked { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum MediaType
    {
        image,
        video,
        audio,
    }

    [JsType(JsMode.Json)]
    public class UpdateProperties : CreateProperties
    {
    }

    #endregion

    #region cookies

    [JsType(JsMode.Prototype, Name = "chrome.cookies", Export = false)]
    public class cookies
    {
        /// <summary>
        /// Retrieves information about a single cookie. If more than one cookie of the same name exists for the given URL, the one with the longest path will be returned.
        /// For cookies with the same path length, the cookie with the earliest creation time will be returned.
        /// </summary>
        /// <param name="details">Details to identify the cookie being retrieved.</param>
        /// <param name="callback"></param>
        public static void get(CookiesGetDetails details, JsAction<Cookie> callback) { }

        /// <summary>
        /// Retrieves all cookies from a single cookie store that match the given information. The cookies returned will be sorted, with those with the longest path first.
        /// If multiple cookies have the same path length, those with the earliest creation time will be first.
        /// </summary>
        /// <param name="details">Information to filter the cookies being retrieved.</param>
        /// <param name="callback"></param>
        public static void getAll(CookiesGetAllDetails details, JsAction<JsArray<Cookie>> callback) { }

        /// <summary>
        /// Lists all existing cookie stores.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAllCookieStores(JsAction<JsArray<CookieStore>> callback) { }

        /// <summary>
        /// Deletes a cookie by name.
        /// </summary>
        /// <param name="details">Information to identify the cookie to remove.</param>
        /// <param name="callback">( optional ) This parameter was added in version 11.0.674.0. You must omit this parameter in earlier versions, and you may omit it in any version.
        /// If you require this parameter, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.</param>
        public static void remove(CookiesRemoveDetails details, JsAction callback) { }
        /// <summary>
        /// Deletes a cookie by name.
        /// </summary>
        /// <param name="details">Information to identify the cookie to remove.</param>
        public static void remove(CookiesRemoveDetails details) { }

        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        /// <param name="details">Details about the cookie being set.</param>
        /// <param name="callback"> ( optional ) This parameter was added in version 11.0.674.0. You must omit this parameter in earlier versions, and you may omit it in any version.
        /// If you require this parameter, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.</param>
        public static void set(CookiesSetAllDetails details, JsAction callback) { }
        /// <summary>
        /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
        /// </summary>
        /// <param name="details">Details about the cookie being set.</param>
        public static void set(CookiesSetAllDetails details) { }
    }

    [JsType(JsMode.Json)]
    public class CookiesGetDetails
    {

        /// <summary>
        /// The URL with which the cookie to retrieve is associated. This argument may be a full URL, in which case any data following the URL path (e.g. the query string) is simply ignored.
        /// If host permissions for this URL are not specified in the manifest file, the API call will fail.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The name of the cookie to retrieve.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store in which to look for the cookie. By default, the current execution context's cookie store will be used.
        /// </summary>
        public JsString storeId { get; set; }


    }

    [JsType(JsMode.Json)]
    public class CookiesGetAllDetails
    {

        /// <summary>
        /// ( optional ) Restricts the retrieved cookies to those that would match the given URL.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) Filters the cookies by name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) Restricts the retrieved cookies to those whose domains match or are subdomains of this one.
        /// </summary>
        public JsString domain { get; set; }

        /// <summary>
        /// ( optional ) Restricts the retrieved cookies to those whose path exactly matches this string.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// ( optional ) Filters the cookies by their Secure property.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// ( optional ) Filters out session vs. persistent cookies.
        /// </summary>
        public bool session { get; set; }

        /// <summary>
        /// ( optional ) The cookie store to retrieve cookies from. If omitted, the current execution context's cookie store will be used.
        /// </summary>
        public JsString storeId { get; set; }


    }

    [JsType(JsMode.Json)]
    public class CookiesRemoveDetails
    {

        /// <summary>
        /// The URL associated with the cookie. If host permissions for this URL are not specified in the manifest file, the API call will fail.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The name of the cookie to remove.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store to look in for the cookie. If unspecified, the cookie is looked for by default in the current execution context's cookie store.
        /// </summary>
        public JsString storeId { get; set; }


    }

    [JsType(JsMode.Json)]
    public class CookiesSetAllDetails
    {

        /// <summary>
        /// ( optional ) The request-URI to associate with the setting of the cookie. This value can affect the default domain and path values of the created cookie.
        /// If host permissions for this URL are not specified in the manifest file, the API call will fail.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The name of the cookie. Empty by default if omitted.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) The value of the cookie. Empty by default if omitted.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// ( optional ) The domain of the cookie. If omitted, the cookie becomes a host-only cookie.
        /// </summary>
        public JsString domain { get; set; }

        /// <summary>
        /// ( optional ) The path of the cookie. Defaults to the path portion of the url parameter.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// ( optional ) Whether the cookie should be marked as Secure. Defaults to false.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// ( optional ) Whether the cookie should be marked as HttpOnly. Defaults to false.
        /// </summary>
        public bool httpOnly { get; set; }

        /// <summary>
        /// ( optional ) The expiration date of the cookie as the number of seconds since the UNIX epoch. If omitted, the cookie becomes a session cookie.
        /// </summary>
        public JsNumber expirationDate { get; set; }

        /// <summary>
        /// ( optional ) The ID of the cookie store in which to set the cookie. By default, the cookie is set in the current execution context's cookie store.
        /// </summary>
        public JsString storeId { get; set; }
    }

    /// <summary>
    /// Represents information about an HTTP cookie.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.cookies.Cookie", Export = false)]
    public class Cookie
    {

        /// <summary>
        /// The name of the cookie.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The value of the cookie.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// The domain of the cookie (e.g. "www.google.com", "example.com").
        /// </summary>
        public JsString domain { get; set; }

        /// <summary>
        /// True if the cookie is a host-only cookie (i.e. a request's host must exactly match the domain of the cookie).
        /// </summary>
        public bool hostOnly { get; set; }

        /// <summary>
        /// The path of the cookie.
        /// </summary>
        public JsString path { get; set; }

        /// <summary>
        /// True if the cookie is marked as Secure (i.e. its scope is limited to secure channels, typically HTTPS).
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// True if the cookie is marked as HttpOnly (i.e. the cookie is inaccessible to client-side scripts).
        /// </summary>
        public bool httpOnly { get; set; }

        /// <summary>
        /// True if the cookie is a session cookie, as opposed to a persistent cookie with an expiration date.
        /// </summary>
        public bool session { get; set; }

        /// <summary>
        /// The expiration date of the cookie as the number of seconds since the UNIX epoch. Not provided for session cookies.
        /// </summary>
        public JsNumber expirationDate { get; set; }

        /// <summary>
        /// The ID of the cookie store containing this cookie, as provided in getAllCookieStores().
        /// </summary>
        public JsString storeId { get; set; }
    }

    /// <summary>
    /// Represents a cookie store in the browser. An incognito mode window, for instance, uses a separate cookie store from a non-incognito window.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.cookies.CookieStore", Export = false)]
    public class CookieStore
    {
        /// <summary>
        /// The unique identifier for the cookie store.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Identifiers of all the browser tabs that share this cookie store.
        /// </summary>
        public JsArray<JsNumber> tabIds { get; set; }
    }

    #endregion

    #region debugger

    [JsType(JsMode.Prototype, Name = "chrome.debugger", Export = false)]
    public class debugger
    {
        /// <summary>
        /// Attaches debugger to the given target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to attach.</param>
        /// <param name="requiredVersion">Required debugging protocol version ("0.1"). One can only attach to the debuggee with matching major version and greater or equal minor version.
        /// List of the protocol versions can be obtained here: https://developers.google.com/chrome-developer-tools/docs/remote-debugging </param>
        /// <param name="callback">( optional )Called once the attach operation succeeds or fails. Callback receives no arguments. If the attach fails, chrome.extension.lastError will be set to the error message.</param>
        public static void attach(Debuggee target, JsString requiredVersion, JsAction callback) { }
        /// <summary>
        /// Attaches debugger to the given target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to attach.</param>
        /// <param name="requiredVersion">Required debugging protocol version ("0.1"). One can only attach to the debuggee with matching major version and greater or equal minor version.
        /// List of the protocol versions can be obtained here: https://developers.google.com/chrome-developer-tools/docs/remote-debugging </param>
        public static void attach(Debuggee target, JsString requiredVersion) { }

        /// <summary>
        /// Detaches debugger from the given target.
        /// </summary>
        /// <param name="target">Debugging target from which you want to detach.</param>
        /// <param name="callback">( optional ) Called once the detach operation succeeds or fails. Callback receives no arguments.
        /// If the detach fails, chrome.extension.lastError will be set to the error message.</param>
        public static void detach(Debuggee target, JsAction callback) { }
        /// <summary>
        /// Detaches debugger from the given target.
        /// </summary>
        /// <param name="target">Debugging target from which you want to detach.</param>
        public static void detach(Debuggee target) { }

        /// <summary>
        /// Sends given command to the debugging target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to send the command.</param>
        /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
        /// <param name="params">JSON object with request parameters. This object must conform to the remote debugging params scheme for given method.</param>
        /// <param name="callback">Response body. If an error occurs while posting the message, the callback will be called with no arguments and chrome.extension.lastError will be set to the error message.</param>
        public static void sendCommand(Debuggee target, JsString method, object @params, JsAction callback) { }
        /// <summary>
        /// Sends given command to the debugging target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to send the command.</param>
        /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
        /// <param name="params">JSON object with request parameters. This object must conform to the remote debugging params scheme for given method.</param>
        public static void sendCommand(Debuggee target, JsString method, object @params) { }
        /// <summary>
        /// Sends given command to the debugging target.
        /// </summary>
        /// <param name="target">Debugging target to which you want to send the command.</param>
        /// <param name="method">Method name. Should be one of the methods defined by the remote debugging protocol.</param>
        public static void sendCommand(Debuggee target, JsString method) { }

        /// <summary>
        /// Fired when browser terminates debugging session for the tab. This happens when either the tab is being closed or Chrome DevTools is being invoked for the attached tab.
        /// </summary>
        public static Event<JsAction<Debuggee>> onDetach { get; set; }

        /// <summary>
        /// Fired whenever debugging target issues instrumentation event.
        /// Listener parameters:
        /// source ( debugger.Debuggee )
        /// The debuggee that generated this event.
        /// method ( string )
        /// Method name. Should be one of the notifications defined by the remote debugging protocol.
        /// params ( optional object )
        /// JSON object with the response. Structure of the response varies depending on the method and is defined by the remote debugging protocol.
        /// </summary>
        public static Event<JsAction<Debuggee, JsString, object>> onEvent { get; set; }
    }

    /// <summary>
    /// Debuggee identifier.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.debugger.Debuggee", Export = false)]
    public class Debuggee
    {
        /// <summary>
        /// The id of the tab which you intend to debug.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    #endregion

    #region declarativeWebRequest

    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest", Export = false)]
    public class declarativeWebRequest
    {
        //TODO: this class is empty (?)
    }

    /// <summary>
    /// Redirects a request by applying a regular expression on the URL. The regular expressions use the RE2 syntax.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectByRegEx", Export = false)]
    public class RedirectByRegEx
    {
        /// <summary>
        /// A match pattern that may contain capture groups. Capture groups are referenced in the Perl syntax
        /// ($1, $2, ...) instead of the RE2 syntax (\1, \2, ...) in order to be closer to JavaScript Regular Expressions.
        /// </summary>
        public JsString from { get; set; }

        /// <summary>
        /// Destination pattern.
        /// </summary>
        public JsString to { get; set; }
    }

    /// <summary>
    /// Matches network events by various criteria.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RequestMatcher", Export = false)]
    public class RequestMatcher
    {
        /// <summary>
        /// ( optional events.UrlFilter ) Matches if the condition of the UrlFilter are fulfilled for the URL of the request.
        /// </summary>
        public UrlFilter url { get; set; }

        /// <summary>
        /// ( optional array of string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] ) Matches if the request type of a request is contained in the list. Requests that cannot match any of the types will be filtered out.
        /// </summary>
        public JsArray<ResourceType> resourceType { get; set; }

        /// <summary>
        /// ( enumerated string ["declarativeWebRequest.RequestMatcher"] )
        /// </summary>
        public JsString instanceType { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ResourceType
    {
        main_frame,
        sub_frame,
        stylesheet,
        script,
        image,
        @object,
        xmlhttprequest,
        other,
    }

    /// <summary>
    /// Declarative event action that redirects a network request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectRequest", Export = false)]
    public class RedirectRequest
    {
        /// <summary>
        /// ( enumerated string ["declarativeWebRequest.RedirectRequest"] )
        /// </summary>
        public JsString instanceType { get; set; }

        /// <summary>
        /// Destination to where the request is redirected.
        /// </summary>
        public JsString redirectUrl { get; set; }
    }

    /// <summary>
    /// Declarative event action that redirects a network request to a transparent image.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectToTransparentImage", Export = false)]
    public class RedirectToTransparentImage
    {
    }

    /// <summary>
    /// Declarative event action that redirects a network request to an empty document.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RedirectToEmptyDocument", Export = false)]
    public class RedirectToEmptyDocument
    {
    }

    /// <summary>
    /// Declarative event action that cancels a network request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.CancelRequest", Export = false)]
    public class CancelRequest
    {
        /// <summary>
        /// ( enumerated string ["declarativeWebRequest.CancelRequest"] )
        /// </summary>
        public JsString instanceType { get; set; }
    }

    /// <summary>
    /// Sets the request header of the specified name to the specified value. If a header with the specified name did not exist before, a new one is created.
    /// Header name comparison is always case-insensitive. Each request header name occurs only once in each request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.SetRequestHeader", Export = false)]
    public class SetRequestHeader
    {
        /// <summary>
        /// HTTP request header name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// HTTP request header value.
        /// </summary>
        public JsString value { get; set; }
    }

    /// <summary>
    /// Removes the request header of the specified name. Do not use SetRequestHeader and RemoveRequestHeader with the same header name on the same request.
    /// Each request header name occurs only once in each request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RemoveRequestHeader", Export = false)]
    public class RemoveRequestHeader
    {
        /// <summary>
        /// HTTP request header name (case-insensitive).
        /// </summary>
        public JsString name { get; set; }
    }

    /// <summary>
    /// Adds the response header to the response of this web request.
    /// As multiple response headers may share the same name, you need to first remove and then add a new response header in order to replace one.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.AddResponseHeader", Export = false)]
    public class AddResponseHeader
    {
        /// <summary>
        /// HTTP request header name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// HTTP request header value.
        /// </summary>
        public JsString value { get; set; }
    }

    /// <summary>
    /// Removes all response headers of the specified names and values.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.RemoveResponseHeader", Export = false)]
    public class RemoveResponseHeader
    {
        /// <summary>
        /// HTTP request header name.(case-insensitive).
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        ///( optional ) HTTP request header value.(case-insensitive).
        /// </summary>
        public JsString value { get; set; }


    }

    /// <summary>
    /// Masks all rules that match the specified criteria.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.declarativeWebRequest.IgnoreRules", Export = false)]
    public class IgnoreRules
    {
        /// <summary>
        /// If set, rules with a lower priority than the specified value are ignored.
        /// This boundary is not persited, it affects only rules and their actions of the same network request stage. TODO(battre): Explain network request stages.
        /// </summary>
        public JsNumber lowerPriorityThan { get; set; }
    }

    #endregion

    #region events

    [JsType(JsMode.Prototype, Name = "chrome.events.Event", Export = false)]
    public class Event<T>
    {
        public void addListener(T action) { }
        public void removeListener(T action) { }
        public bool hasListener(T action) { return false; }


        /// <summary>
        /// Registers rules to handle events.
        /// </summary>
        /// <param name="rules">Rules to be registered. These do not replace previously registered rules.</param>
        /// <param name="callback">( optional ) Called with registered rules.</param>
        public void addRules(JsArray<Rule> rules, JsAction<AddRulesDetails> callback) { }
        /// <summary>
        /// Registers rules to handle events.
        /// </summary>
        /// <param name="rules">Rules to be registered. These do not replace previously registered rules.</param>
        public void addRules(JsArray<Rule> rules) { }

        /// <summary>
        /// Returns currently registered rules.
        /// </summary>
        /// <param name="ruleIdentifiers">( optional ) If an array is passed, only rules with identifiers contained in this array are returned.</param>
        /// <param name="callback">Called with registered rules.</param>
        public void getRules(JsArray<JsString> ruleIdentifiers, JsAction<AddRulesDetails> callback) { }
        /// <summary>
        /// Returns currently registered rules.
        /// </summary>
        /// <param name="callback">Called with registered rules.</param>
        public void getRules(JsAction<AddRulesDetails> callback) { }

        public void hasListener() { }
        public void hasListeners() { }
        public void removeListener() { }

        /// <summary>
        /// Unregisters currently registered rules.
        /// </summary>
        /// <param name="ruleIdentifiers"> ( optional ) If an array is passed, only rules with identifiers contained in this array are unregistered.</param>
        /// <param name="callback">( optional ) Called when rules were unregistered.</param>
        public void removeRules(JsArray<JsString> ruleIdentifiers, JsAction callback) { }
        /// <summary>
        /// Unregisters currently registered rules.
        /// </summary>
        /// <param name="ruleIdentifiers"> ( optional ) If an array is passed, only rules with identifiers contained in this array are unregistered.</param>
        public void removeRules(JsArray<JsString> ruleIdentifiers) { }
        /// <summary>
        /// Unregisters currently registered rules.
        /// </summary>
        public void removeRules() { }

    }

    [JsType(JsMode.Prototype, Name = "chrome.events.Event", Export = false)]
    public class WebRequestEvent<T> : Event<T>
    {
        public BlockingResponse addListener(T action, RequestFilter filter) { return null; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.events.Event", Export = false)]
    public class WebRequestEvent<T, S> : WebRequestEvent<T>
    {
        public BlockingResponse addListener(T action, RequestFilter filter, JsArray<JsString> extraInfoSpec) { return null; }
        public BlockingResponse addListener(T action, RequestFilter filter, JsArray<S> extraInfoSpec) { return null; }
        public BlockingResponse addListener(T action, RequestFilter filter, S[] extraInfoSpec) { return null; }
    }

    /// <summary>
    /// Description of a declarative rule for handling events.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.events.Rule", Export = false)]
    public class Rule
    {
        /// <summary>
        /// Optional identifier that allows referencing this rule.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// List of conditions that can trigger the actions.
        /// </summary>
        public JsArray<object> conditions { get; set; }

        /// <summary>
        /// List of actions that are triggered if one of the condtions is fulfilled.
        /// </summary>
        public JsArray<object> actions { get; set; }

        /// <summary>
        /// Optional priority of this rule. Defaults to 100.
        /// </summary>
        public JsNumber priority { get; set; }

    }

    /// <summary>
    /// Filters URLs for various criteria
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.events.UrlFilter", Export = false)]
    public class UrlFilter
    {
        /// <summary>
        /// ( optional ) Matches if the host name of the URL contains a specified string.
        /// </summary>
        public JsString hostContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the host name of the URL is equal to a specified string.
        /// </summary>
        public JsString hostEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the host name of the URL starts with a specified string.
        /// </summary>
        public JsString hostPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the host name of the URL ends with a specified string.
        /// </summary>
        public JsString hostSuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL contains a specified string.
        /// </summary>
        public JsString pathContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL is equal to a specified string.
        /// </summary>
        public JsString pathEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL starts with a specified string.
        /// </summary>
        public JsString pathPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the path segment of the URL ends with a specified string.
        /// </summary>
        public JsString pathSuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL contains a specified string.
        /// </summary>
        public JsString queryContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL is equal to a specified string.
        /// </summary>
        public JsString queryEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL starts with a specified string.
        /// </summary>
        public JsString queryPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the query segment of the URL ends with a specified string.
        /// </summary>
        public JsString querySuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL contains a specified string.
        /// </summary>
        public JsString urlContains { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL is equal to a specified string.
        /// </summary>
        public JsString urlEquals { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL starts with a specified string.
        /// </summary>
        public JsString urlPrefix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the URL ends with a specified string.
        /// </summary>
        public JsString urlSuffix { get; set; }

        /// <summary>
        /// ( optional ) Matches if the scheme of the URL is equal to any of the schemes specified in the array.
        /// </summary>
        public JsArray<JsString> schemes { get; set; }

        /// <summary>
        /// ( optional ) Matches if the port of the URL is contained in any of the specified port lists.
        /// For example [80, 443, [1000, 1200]] matches all requests on port 80, 443 and in the range 1000-1200.
        /// </summary>
        public JsArray<object> ports { get; set; }
    }

    public class AddRulesDetails : JsArray<Rule>
    {
    }
    //TODO: danel don't know what to do here

    #endregion

    #region extension

    [JsType(JsMode.Prototype, Name = "chrome.extension", Export = false)]
    public class extension
    {
        /// <summary>
        /// ( optional ) Set for the lifetime of a callback if an ansychronous extension api has resulted in an error.
        /// If no error has occured lastError will be undefined.
        /// </summary>
        public ExtensionLastError lastError { get; set; }

        /// <summary>
        /// ( optional ) True for content scripts running inside incognito tabs, and for extension pages running inside an incognito process.
        /// The latter only applies to extensions with 'split' incognito_behavior.
        /// </summary>
        public bool inIncognitoContext { get; set; }

        /// <summary>
        /// Attempts to connect to other listeners within the extension (such as the extension's background page).
        /// This is primarily useful for content scripts connecting to their extension processes.
        /// Extensions may connect to content scripts embedded in tabs via chrome.tabs.connect().
        /// </summary>
        /// <param name="extensionId"> ( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <param name="connectInfo">( optional )</param>
        /// <returns>Port through which messages can be sent and received with the extension. The port's onDisconnect event is fired if extension does not exist.</returns>
        public static Port connect(JsString extensionId, ExtensionConnectInfo connectInfo) { return null; }
        /// <summary>
        /// Attempts to connect to other listeners within the extension (such as the extension's background page).
        /// This is primarily useful for content scripts connecting to their extension processes.
        /// Extensions may connect to content scripts embedded in tabs via chrome.tabs.connect().
        /// </summary>
        /// <param name="extensionId"> ( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <returns>Port through which messages can be sent and received with the extension. The port's onDisconnect event is fired if extension does not exist.</returns>
        public static Port connect(JsString extensionId) { return null; }
        /// <summary>
        /// Attempts to connect to other listeners within the extension (such as the extension's background page).
        /// This is primarily useful for content scripts connecting to their extension processes.
        /// Extensions may connect to content scripts embedded in tabs via chrome.tabs.connect().
        /// </summary>
        /// <returns>Port through which messages can be sent and received with the extension. The port's onDisconnect event is fired if extension does not exist.</returns>
        public static Port connect() { return null; }

        /// <summary>
        /// Returns the JavaScript 'window' object for the background page running inside the current extension. Returns null if the extension has no background page.
        /// </summary>
        /// <returns></returns>
        public static Window getBackgroundPage() { return null; }

        /// <summary>
        /// Converts a relative path within an extension install directory to a fully-qualified URL.
        /// </summary>
        /// <param name="path">A path to a resource within an extension expressed relative to its install directory.</param>
        /// <returns>The fully-qualified URL to the resource.</returns>
        public static JsString getURL(JsString path) { return null; }

        /// <summary>
        /// Returns an array of the JavaScript 'window' objects for each of the pages running inside the current extension.
        /// </summary>
        /// <param name="fetchProperties"></param>
        /// <returns>Array of global objects</returns>
        public static JsArray<Window> getViews(ExtensionFetchProperties fetchProperties) { return null; }
        /// <summary>
        /// Returns an array of the JavaScript 'window' objects for each of the pages running inside the current extension.
        /// </summary>
        /// <returns>Array of global objects</returns>
        public static JsArray<Window> getViews() { return null; }

        /// <summary>
        /// Retrieves the state of the extension's access to the 'file://' scheme (as determined by the user-controlled 'Allow access to File URLs' checkbox.
        /// *This function was added in version 12.0.706.0.
        /// If you require this function, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.*
        /// </summary>
        /// <param name="callback"></param>
        public static void isAllowedFileSchemeAccess(JsAction callback) { }

        /// <summary>
        /// Retrieves the state of the extension's access to Incognito-mode (as determined by the user-controlled 'Allowed in Incognito' checkbox.
        /// *This function was added in version 12.0.706.0.
        /// If you require this function, the manifest key minimum_chrome_version can ensure that your extension won't be run in an earlier browser version.*
        /// </summary>
        /// <param name="callback"></param>
        public static void isAllowedIncognitoAccess(JsAction callback) { }

        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="extensionId">( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <param name="message"></param>
        /// <param name="responseCallback">( optional ) The JSON response object sent by the handler of the message. If an error occurs while connecting to the extension,
        /// the callback will be called with no arguments and chrome.extension.lastError will be set to the error message.</param>
        public static void sendMessage(JsString extensionId, object message, JsAction<object> responseCallback) { }
        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="extensionId">( optional ) The extension ID of the extension you want to connect to. If omitted, default is your own extension.</param>
        /// <param name="message"></param>
        public static void sendMessage(JsString extensionId, object message) { }
        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="responseCallback">( optional ) The JSON response object sent by the handler of the message. If an error occurs while connecting to the extension,
        /// the callback will be called with no arguments and chrome.extension.lastError will be set to the error message.</param>
        public static void sendMessage(object message, JsAction<object> responseCallback) { }
        /// <summary>
        /// Sends a single message to other listeners within the extension. Similar to chrome.extension.connect, but only sends a single message with an optional response.
        /// The chrome.extension.onMessage event is fired in each page of the extension.
        /// </summary>
        /// <param name="message"></param>
        public static void sendMessage(object message) { }

        /// <summary>
        /// Sets the value of the ap CGI parameter used in the extension's update URL.
        /// This value is ignored for extensions that are hosted in the Chrome Extension Gallery.
        /// </summary>
        /// <param name="data"></param>
        public static void setUpdateUrlData(JsString data) { }

        /// <summary>
        /// Fired when a connection is made from either an extension process or a content script.
        /// </summary>
        public static Event<JsAction<Port>> onConnect { get; set; }

        /// <summary>
        /// Fired when a connection is made from another extension.
        /// </summary>
        public static Event<JsAction<Port>> onConnectExternal { get; set; }

        /// <summary>
        /// Fired when a message is sent from either an extension process or a content script.
        /// </summary>
        public static Event<JsFunc<ExtensionOnMessageDetails, bool>> onMessage { get; set; }

        /// <summary>
        /// Fired when a message is sent from another extension.
        /// </summary>
        public static Event<JsFunc<ExtensionOnMessageDetails, bool>> onMessageExternal { get; set; }

    }

    [JsType(JsMode.Json)]
    public class ExtensionLastError
    {
        /// <summary>
        /// Description of the error that has taken place.
        /// </summary>
        public JsString message { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ExtensionConnectInfo
    {
        /// <summary>
        /// ( optional ) Will be passed into onConnect for extension processes that are listening for the connection event.
        /// </summary>
        public JsString name { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ExtensionFetchProperties
    {
        /// <summary>
        /// type ( optional enumerated string ["tab", "infobar", "notification", "popup"] )
        /// The type of view to get. If omitted, returns all views (including background pages and tabs). Valid values: 'tab', 'infobar', 'notification', 'popup'.
        /// </summary>
        public FetchPropertiesType type { get; set; }

        /// <summary>
        /// The window to restrict the search to. If omitted, returns all views.
        /// </summary>
        public JsNumber windowId { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum FetchPropertiesType
    {
        tab,
        infobar,
        notification,
        popup,
    }

    [JsType(JsMode.Json)]
    public class ExtensionOnMessageDetails
    {
        /// <summary>
        /// The message sent by the calling script.
        /// </summary>
        public object message { get; set; }

        public MessageSender sender { get; set; }

        /// <summary>
        /// Function to call (at most once) when you have a response. The argument should be any JSON-ifiable object.
        /// If you have more than one onMessage listener in the same document, then only one may send a response.
        /// This function becomes invalid when the event listener returns, unless you return true from the event listener to indicate you wish to send a response asynchronously
        /// (this will keep the message channel open to the other end until sendResponse is called).
        /// </summary>
        public JsAction sendResponse { get; set; }

    }

    /// <summary>
    /// An object containing information about the script context that sent a message or request.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.extension.MessageSender", Export = false)]
    public class MessageSender
    {
        /// <summary>
        /// ( optional tabs.Tab ) This property will only be present when the connection was opened from a tab or content script.
        /// </summary>
        public Tab tab { get; set; }

        /// <summary>
        /// The extension ID of the extension that opened the connection.
        /// </summary>
        public JsString id { get; set; }
    }

    /// <summary>
    /// An object which allows two way communication with other pages.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.extension.Port", Export = false)]
    public class Port
    {

        public JsString name { get; set; }

        public object onDisconnect { get; set; }
        //TODO: type is ( events.Event ) (needs to create this class)

        public object onMessage { get; set; }
        //TODO: type is ( events.Event ) (needs to create this class)

        public JsAction postMessage { get; set; }

        public MessageSender sender { get; set; }
    }
    #endregion

    #region fileBrowserHandler


    /// <summary>
    /// Use the chrome.fileBrowserHandler module to extend the Chrome OS file browser.
    /// For example, you can use this API to enable users to upload files to your website.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.fileBrowserHandler", Export = false)]
    public class fileBrowserHandler
    {

        /// <summary>
        /// Prompts user to select file path under which a new file will be created.
        /// When the user selects file, the file gets created or, if it already existed, truncated. The function has to be called with a user gesture.
        /// </summary>
        /// <param name="selectionParams">Parameters that will be used to create a new file.</param>
        /// <param name="callback">Function called upon completion.</param>
        public static void selectFile(SelectionParams selectionParams, JsAction callback) { }

        /// <summary>
        /// Fired when file system action is executed from ChromeOS file browser.
        /// </summary>
        public static Event<JsAction<JsString, FileHandlerExecuteEventDetails>> onExecute { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SelectionParams
    {
        /// <summary>
        /// Suggested name for the new file.
        /// </summary>
        public JsString suggestedName { get; set; }
    }

    /// <summary>
    /// Event details payload for fileBrowserHandler.onExecute event.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.fileBrowserHandler.FileHandlerExecuteEventDetails", Export = false)]
    public class FileHandlerExecuteEventDetails
    {
        /// <summary>
        /// Array of Entry instances representing files that are targets of this action (selected in ChromeOS file browser).
        /// </summary>
        public JsArray<object> entries { get; set; }

        /// <summary>
        /// ( optional ) The ID of the tab that raised this event. Tab IDs are unique within a browser session.
        /// </summary>
        public JsNumber tab_id { get; set; }
    }

    #endregion

    #region history

    /// <summary>
    /// Use the chrome.history module to interact with the browser's record of visited pages.
    /// You can add, remove, and query for URLs in the browser's history. To override the history page with your own version, see Override Pages.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.history", Export = false)]
    public class history
    {
        /// <summary>
        /// Adds a URL to the history at the current time with a transition type of "link".
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void addUrl(HistoryAddUrlDetails details, JsAction callback) { }
        /// <summary>
        /// Adds a URL to the history at the current time with a transition type of "link".
        /// </summary>
        /// <param name="details"></param>
        public static void addUrl(HistoryAddUrlDetails details) { }

        /// <summary>
        /// Deletes all items from the history.
        /// </summary>
        /// <param name="callback"></param>
        public static void deleteAll(JsAction callback) { }

        /// <summary>
        /// Removes all items within the specified date range from the history. Pages will not be removed from the history unless all visits fall within the range.
        /// </summary>
        /// <param name="range"></param>
        /// <param name="callback"></param>
        public static void deleteRange(HistoryDeleteRange range, JsAction callback) { }

        /// <summary>
        /// Removes all occurrences of the given URL from the history.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void deleteUrl(HistoryDeleteUrlDetails details, JsAction callback) { }
        /// <summary>
        /// Removes all occurrences of the given URL from the history.
        /// </summary>
        /// <param name="details"></param>
        public static void deleteUrl(HistoryDeleteUrlDetails details) { }

        /// <summary>
        /// Retrieves information about visits to a URL.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getVisits(HistoryGetVisitsDetails details, JsAction callback) { }

        /// <summary>
        /// Searches the history for the last visit time of each page matching the query.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="callback"></param>
        public static void search(HistorySearchQuery query, JsAction callback) { }

        /// <summary>
        /// Fired when one or more URLs are removed from the history service. When all visits have been removed the URL is purged from history.
        /// </summary>
        public static Event<JsAction<HistoryOnVisitRemoved>> onVisitRemoved { get; set; }

        /// <summary>
        /// Fired when a URL is visited, providing the HistoryItem data for that URL. This event fires before the page has loaded.
        /// </summary>
        public static Event<JsAction<HistoryItem>> onVisited { get; set; }

    }

    [JsType(JsMode.Json)]
    public class HistoryAddUrlDetails
    {
        /// <summary>
        /// The URL to add.
        /// </summary>
        public JsString url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistoryDeleteRange
    {
        /// <summary>
        /// Items added to history after this date, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber startTime { get; set; }
        /// <summary>
        /// Items added to history before this date, represented in milliseconds since the epoch
        /// </summary>
        public JsNumber endTime { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistoryDeleteUrlDetails
    {
        /// <summary>
        /// The URL to remove.
        /// </summary>
        public JsString url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistoryGetVisitsDetails
    {
        /// <summary>
        /// The URL for which to retrieve visit information. It must be in the format as returned from a call to history.search.
        /// </summary>
        public JsString url { get; set; }
    }

    [JsType(JsMode.Json)]
    public class HistorySearchQuery
    {
        /// <summary>
        /// A free-text query to the history service. Leave empty to retrieve all pages.
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        /// ( optional ) Limit results to those visited after this date, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber startTime { get; set; }

        /// <summary>
        /// ( optional )Limit results to those visited before this date, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber endTime { get; set; }

        /// <summary>
        /// ( optional )The maximum number of results to retrieve. Defaults to 100.
        /// </summary>
        public JsNumber maxResults { get; set; }

    }

    [JsType(JsMode.Json)]
    public class HistoryOnVisitRemoved
    {
        /// <summary>
        /// True if all history was removed. If true, then urls will be empty.
        /// </summary>
        public bool allHistory { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsArray<JsString> urls { get; set; }
    }

    /// <summary>
    /// An object encapsulating one result of a history query.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.history.HistoryItem", Export = false)]
    public class HistoryItem
    {
        /// <summary>
        /// The unique identifier for the item.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional ) The URL navigated to by a user.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The title of the page when it was last loaded.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional ) When this page was last loaded, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber lastVisitTime { get; set; }

        /// <summary>
        /// ( optional ) The number of times the user has navigated to this page.
        /// </summary>
        public JsNumber visitCount { get; set; }

        /// <summary>
        /// ( optional ) The number of times the user has navigated to this page by typing in the address.
        /// </summary>
        public JsNumber typedCount { get; set; }
    }

    /// <summary>
    /// An object encapsulating one visit to a URL.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.history.VisitItem", Export = false)]
    public class VisitItem
    {
        /// <summary>
        /// The unique identifier for the item.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The unique identifier for this visit.
        /// </summary>
        public JsString visitId { get; set; }

        /// <summary>
        /// ( optional ) When this visit occurred, represented in milliseconds since the epoch.
        /// </summary>
        public JsNumber visitTime { get; set; }

        /// <summary>
        /// The visit ID of the referrer.
        /// </summary>
        public JsString referringVisitId { get; set; }

        /// <summary>
        /// ( enumerated string ["link", "typed", "auto_bookmark", "auto_subframe", "manual_subframe", "generated", "start_page", "form_submit", "reload", "keyword", "keyword_generated"] )
        /// The transition type for this visit from its referrer.
        /// </summary>
        public TransitionType transition { get; set; }
    }

    /// <summary>
    /// The history API uses a transition type to describe how the browser navigated to a particular URL on a particular visit.
    /// For example, if a user visits a page by clicking a link on another page, the transition type is "link".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TransitionType
    {
        /// <summary>
        /// The user got to this page by clicking a link on another page.
        /// </summary>
        link,
        /// <summary>
        /// The user got this page by typing the URL in the address bar. Also used for other explicit navigation actions.
        /// See also generated, which is used for cases where the user selected a choice that didn't look at all like a URL.
        /// </summary>
        typed,
        /// <summary>
        /// The user got to this page through a suggestion in the UI — for example, through a menu item.
        /// </summary>
        auto_bookmark,
        /// <summary>
        /// Subframe navigation. This is any content that is automatically loaded in a non-top-level frame.
        /// For example, if a page consists of several frames containing ads, those ad URLs have this transition type.
        /// The user may not even realize the content in these pages is a separate frame, and so may not care about the URL (see also manual_subframe).
        /// </summary>
        auto_subframe,
        /// <summary>
        /// For subframe navigations that are explicitly requested by the user and generate new navigation entries in the back/forward list.
        /// An explicitly requested frame is probably more important than an automatically loaded frame because the user probably cares about 
        /// he fact that the requested frame was loaded.
        /// </summary>
        manual_subframe,
        /// <summary>
        /// The user got to this page by typing in the address bar and selecting an entry that did not look like a URL.
        /// For example, a match might have the URL of a Google search result page, but it might appear to the user as "Search Google for ...".
        /// These are not quite the same as typed navigations because the user didn't type or see the destination URL. See also keyword.
        /// </summary>
        generated,
        /// <summary>
        /// The page was specified in the command line or is the start page.
        /// </summary>
        start_page,
        /// <summary>
        /// The user filled out values in a form and submitted it.
        /// Note that in some situations — such as when a form uses script to submit contents — submitting a form does not result in this transition type.
        /// </summary>
        form_submit,
        /// <summary>
        /// The user reloaded the page, either by clicking the reload button or by pressing Enter in the address bar.
        /// Session restore and Reopen closed tab use this transition type, too.
        /// </summary>
        reload,
        /// <summary>
        /// The URL was generated from a replaceable keyword other than the default search provider. See also keyword_generated.
        /// </summary>
        keyword,
        /// <summary>
        /// Corresponds to a visit generated for a keyword. See also keyword.
        /// </summary>
        keyword_generated,
    }

    #endregion

    #region i18n

    /// <summary>
    /// An internationalized extension can be easily localized — adapted to languages and regions that it didn't originally support.
    /// To internationalize your extension, you need to put all of its user-visible strings into a file named messages.json.
    /// Each time you localize your extension you add a messages file under a directory named _locales/localeCode, where localeCode is a code such as en for English.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.i18n", Export = false)]
    public class i18n
    {
        /// <summary>
        /// Gets the accept-languages of the browser. This is different from the locale used by the browser; to get the locale, use window.navigator.language.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAcceptLanguages(JsAction callback) { }

        /// <summary>
        /// Gets the localized string for the specified message.
        /// If the message is missing, this method returns an empty string (''). If the format of the getMessage() call is wrong — for example, essageName is not a string or the substitutions array has more than 9 elements — this method returns undefined.
        /// </summary>
        /// <param name="messageName">The name of the message, as specified in the messages.json file.</param>
        /// <param name="substitutions">( optional ) Up to 9 substitution strings, if the message requires any.</param>
        /// <returns>Message localized for current locale</returns>
        public static JsString getMessage(JsString messageName, object substitutions) { return null; }
        /// <summary>
        /// Gets the localized string for the specified message.
        /// If the message is missing, this method returns an empty string (''). If the format of the getMessage() call is wrong — for example, essageName is not a string or the substitutions array has more than 9 elements — this method returns undefined.
        /// </summary>
        /// <param name="messageName">The name of the message, as specified in the messages.json file.</param>
        /// <returns>Message localized for current locale</returns>
        public static JsString getMessage(JsString messageName) { return null; }
    }
    #endregion

    #region idle

    /// <summary>
    /// You must declare the "idle" permission in your extension's manifest to use the idle API.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.idle", Export = false)]
    public class idle
    {
        /// <summary>
        /// Returns the current state of the browser.
        /// </summary>
        /// <param name="thresholdSeconds">Threshold, in seconds, used to determine when a machine is in the idle state.</param>
        /// <param name="callback"></param>
        public static void queryState(JsNumber thresholdSeconds, JsAction callback) { }

        /// <summary>
        /// Fired when the browser changes to an active state. Currently only reports the transition from idle to active.
        /// </summary>
        public static Event<JsAction<IdleStateType>> onStateChanged { get; set; }
        //TODO: check

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum IdleStateType
    {
        active,
    }
    //TODO: can eunm have only one option?

    #endregion

    #region input.ime

    [JsType(JsMode.Prototype, Name = "chrome.input.ime", Export = false)]
    public class InputIme
    {
        /// <summary>
        /// Clear the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.extension.lastError is set.</param>
        public static void clearComposition(InputImeClearCompositionParameter parameters, JsAction callback) { }
        /// <summary>
        /// Clear the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        public static void clearComposition(InputImeClearCompositionParameter parameters) { }

        /// <summary>
        /// Commits the provided text to the current input.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.extension.lastError is set.</param>
        public static void commitText(InputImeCommitTextParameter parameters, JsAction callback) { }
        /// <summary>
        /// Commits the provided text to the current input.
        /// </summary>
        /// <param name="parameters"></param>
        public static void commitText(InputImeCommitTextParameter parameters) { }

        /// <summary>
        /// Sets the properties of the candidate window. This fails if the extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes.</param>
        public static void setCandidateWindowProperties(InputImeCandidateWindowParameter parameters, JsAction callback) { }
        /// <summary>
        /// Sets the properties of the candidate window. This fails if the extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        public static void setCandidateWindowProperties(InputImeCandidateWindowParameter parameters) { }

        /// <summary>
        /// Sets the current candidate list. This fails if this extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes.</param>
        public static void setCandidates(InputImeCandidatesParameter parameters, JsAction callback) { }
        /// <summary>
        /// Sets the current candidate list. This fails if this extension doesn’t own the active IME
        /// </summary>
        /// <param name="parameters"></param>
        public static void setCandidates(InputImeCandidatesParameter parameters) { }

        /// <summary>
        /// Set the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes with a boolean indicating if the text was accepted or not. On failure, chrome.extension.lastError is set.</param>
        public static void setComposition(InputImeCompositionParameter parameters, JsAction callback) { }
        /// <summary>
        /// Set the current composition. If this extension does not own the active IME, this fails.
        /// </summary>
        /// <param name="parameters"></param>
        public static void setComposition(InputImeCompositionParameter parameters) { }

        /// <summary>
        /// Set the position of the cursor in the candidate window. This is a no-op if this extension does not own the active IME.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes</param>
        public static void setCursorPosition(InputImeCursorPositionParameter parameters, JsAction callback) { }
        /// <summary>
        /// Set the position of the cursor in the candidate window. This is a no-op if this extension does not own the active IME.
        /// </summary>
        /// <param name="parameters"></param>
        public static void setCursorPosition(InputImeCursorPositionParameter parameters) { }

        /// <summary>
        /// Adds the provided menu items to the language menu when this IME is active.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) </param>
        public static void setMenuItems(InputImeMenuItemsParameter parameters, JsAction callback) { }
        /// <summary>
        /// Adds the provided menu items to the language menu when this IME is active.
        /// </summary>
        /// <param name="parameters"></param>
        public static void setMenuItems(InputImeMenuItemsParameter parameters) { }

        /// <summary>
        /// Updates the state of the MenuItems specified
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="callback">( optional ) Called when the operation completes</param>
        public static void updateMenuItems(InputImeMenuItemsParameter parameters, JsAction callback) { }
        /// <summary>
        /// Updates the state of the MenuItems specified
        /// </summary>
        /// <param name="parameters"></param>
        public static void updateMenuItems(InputImeMenuItemsParameter parameters) { }

        /// <summary>
        /// This event is sent when an IME is activated. It signals that the IME will be receiving onKeyPress events.
        /// </summary>
        public static Event<JsAction<JsString>> onActivate { get; set; }

        /// <summary>
        /// This event is sent when focus leaves a text box. It is sent to all extensions that are listening to this event, and enabled by the user.
        /// </summary>
        public static Event<JsAction<JsNumber>> onBlur { get; set; }

        /// <summary>
        /// This event is sent if this extension owns the active IME.
        /// </summary>
        public static Event<JsAction<JsString, JsNumber, CandidateClickedButtonType>> onCandidateClicked { get; set; }

        /// <summary>
        /// This event is sent when an IME is deactivated. It signals that the IME will no longer be receiving onKeyPress events.
        /// </summary>
        public static Event<JsAction<JsString>> onDeactivated { get; set; }

        /// <summary>
        /// This event is sent when focus enters a text box. It is sent to all extensions that are listening to this event, and enabled by the user.
        /// </summary>
        public static Event<JsAction<InputContext>> onFocus { get; set; }

        /// <summary>
        /// This event is sent when the properties of the current InputContext change, such as the the type.
        /// It is sent to all extensions that are listening to this event, and enabled by the user.
        /// </summary>
        public static Event<JsAction<InputContext>> onInputContextUpdate { get; set; }

        /// <summary>
        /// This event is sent if this extension owns the active IME.
        /// </summary>
        public static Event<JsAction<JsString, KeyboardEvent>> onKeyEvent { get; set; }
        //TODO: returns boolean (???)

        /// <summary>
        /// Called when the user selects a menu item
        /// </summary>
        public static Event<JsAction<JsString, JsString>> onMenuItemActivated { get; set; }

    }
    //TODO: class name (???)

    [JsType(JsMode.Json)]
    public class InputImeClearCompositionParameter
    {
        /// <summary>
        /// ID of the context where the composition will be cleared
        /// </summary>
        public JsNumber contextID { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCommitTextParameter
    {
        /// <summary>
        /// ID of the context where the text will be committed
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// The text to commit
        /// </summary>
        public JsString text { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCandidateWindowParameter
    {
        /// <summary>
        /// ID of the engine to set properties on.
        /// </summary>
        public JsString engineID { get; set; }

        public InputImeCandidateWindowParameterProperties properties { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCandidateWindowParameterProperties
    {
        /// <summary>
        /// ( optional )True to show the Candidate window, false to hide it.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// ( optional ) True to show the cursor, false to hide it.
        /// </summary>
        public bool cursorVisible { get; set; }

        /// <summary>
        /// ( optional )True if the candidate window should be rendered vertical, false to make it horizontal.
        /// </summary>
        public bool vertical { get; set; }

        /// <summary>
        /// ( optional ) The number of candidates to display per page.
        /// </summary>
        public JsNumber pageSize { get; set; }

        /// <summary>
        /// ( optional )Text that is shown at the bottom of the candidate window.
        /// </summary>
        public JsString auxiliaryText { get; set; }

        /// <summary>
        /// ( optional )True to display the auxiliary text, false to hide it.
        /// </summary>
        public bool auxiliaryTextVisible { get; set; }

    }

    [JsType(JsMode.Json)]
    public class InputImeCandidatesParameter
    {
        /// <summary>
        /// ID of the context that owns the candidate window.
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// List of candidates to show in the candidate window
        /// </summary>
        public JsArray<InputImeCandidatesParameterCandidates> candidates { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCandidatesParameterCandidates
    {
        /// <summary>
        /// The candidate
        /// </summary>
        public JsString candidate { get; set; }

        /// <summary>
        /// The candidate's id
        /// </summary>
        public JsNumber id { get; set; }

        /// <summary>
        /// ( optional ) The id to add these candidates under
        /// </summary>
        public JsNumber parentId { get; set; }

        /// <summary>
        /// ( optional ) Short string displayed to next to the candidate, often the shortcut key or index
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// ( optional ) Additional text describing the candidate
        /// </summary>
        public JsString annotation { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCompositionParameter
    {
        /// <summary>
        /// ID of the context where the composition text will be set
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// Text to set
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        ///  ( optional ) Position in the text that the selection starts at.
        /// </summary>
        public JsNumber selectionStart { get; set; }

        /// <summary>
        /// ( optional ) Position in the text that the selection ends at.
        /// </summary>
        public JsNumber selectionEnd { get; set; }

        /// <summary>
        /// Position in the text of the cursor.
        /// </summary>
        public JsNumber cursor { get; set; }

        /// <summary>
        /// List of segments and their associated types.
        /// </summary>
        public JsArray<InputImeCompositionParameterSegment> segments { get; set; }

    }

    /// <summary>
    /// List of segments and their associated types.
    /// </summary>
    [JsType(JsMode.Json)]
    public class InputImeCompositionParameterSegment
    {
        /// <summary>
        /// Index of the character to start this segment at
        /// </summary>
        public JsNumber start { get; set; }

        /// <summary>
        /// Index of the character to end this segment after.
        /// </summary>
        public JsNumber end { get; set; }

        /// <summary>
        /// ( enumerated string ["underline", "doubleUnderline"] ) How to render this segment
        /// </summary>
        public SegmentsStyle style { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeCursorPositionParameter
    {
        /// <summary>
        /// ID of the context that owns the candidate window.
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// ID of the candidate to select.
        /// </summary>
        public JsNumber candidateID { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeMenuItemsParameter
    {
        /// <summary>
        /// ID of the engine to use
        /// </summary>
        public JsString engineID { get; set; }

        /// <summary>
        /// ID of the candidate to select.
        /// </summary>
        public JsArray<object> items { get; set; }
    }

    [JsType(JsMode.Json)]
    public class InputImeMenuItemsParameterItem
    {

        /// <summary>
        /// String that will be passed to callbacks referencing this MenuItem.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// ( optional ) Text displayed in the menu for this item.
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// ( optional enumerated string ["none", "check", "radio", "separator"] ) Enum representing if this item is: none, check, radio, or a separator.
        /// Radio buttons between separators are considered grouped.
        /// </summary>
        public MenuItemsStyle style { get; set; }

        /// <summary>
        /// ( optional ) Indicates this item is visible.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// ( optional ) Indicates this item should be drawn with a check.
        /// </summary>
        public bool @checked { get; set; }

        /// <summary>
        /// ( optional ) Indicates this item is enabled.
        /// </summary>
        public bool enabled { get; set; }
    }

    /// <summary>
    /// See http://www.w3.org/TR/DOM-Level-3-Events/#events-KeyboardEvent
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.input.ime", Export = false)]
    public class KeyboardEvent
    {
        /// <summary>
        /// One of keyup or keydown.
        /// </summary>
        public KeyboardEventType type { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        public JsString requestId { get; set; }

        /// <summary>
        /// Value of the key being pressed
        /// </summary>
        public JsString key { get; set; }

        /// <summary>
        /// ( optional )Whether or not the ALT key is pressed.
        /// </summary>
        public bool altKey { get; set; }

        /// <summary>
        /// ( optional )Whether or not the CTRL key is pressed.
        /// </summary>
        public bool ctrlKey { get; set; }

        /// <summary>
        /// ( optional )Whether or not the SHIFT key is pressed.
        /// </summary>
        public bool shiftKey { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum KeyboardEventType
    {
        keyup,
        keydown,
    }

    /// <summary>
    /// Describes an input Context
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.input.ime", Export = false)]
    public class InputContext
    {
        /// <summary>
        /// This is used to specify targets of text field operations. This ID becomes invalid as soon as onBlur is called.
        /// </summary>
        public JsNumber contextID { get; set; }

        /// <summary>
        /// Type of value this text field edits, (Text, Number, Password, etc)
        /// </summary>
        public InputContextType type { get; set; }
    }

    /// <summary>
    /// Type of value this text field edits, (Text, Number, Password, etc)
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum InputContextType
    {
        text,
        number,
        password,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum SegmentsStyle
    {
        underline,
        doubleUnderline,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum MenuItemsStyle
    {
        none,
        check,
        radio,
        separator,
    }


    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CandidateClickedButtonType
    {
        left,
        middle,
        right,
    }

    #endregion

    #region management

    /// <summary>
    /// You must declare the "management" permission in the extension manifest to use the management API. 
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.management", Export = false)]
    public class management
    {
        /// <summary>
        /// Returns information about the installed extension or app that has the given ID.
        /// </summary>
        /// <param name="id">The ID from an item of $ref:ExtensionInfo.</param>
        /// <param name="callback">( optional )</param>
        public static void get(JsString id, JsAction callback) { }
        /// <summary>
        /// Returns information about the installed extension or app that has the given ID.
        /// </summary>
        /// <param name="id">The ID from an item of $ref:ExtensionInfo.</param>
        public static void get(JsString id) { }

        /// <summary>
        /// Returns a list of information about installed extensions and apps.
        /// </summary>
        /// <param name="callback">( optional ) </param>
        public static void getAll(JsAction callback) { }
        /// <summary>
        /// Returns a list of information about installed extensions and apps.
        /// </summary>
        public static void getAll() { }

        /// <summary>
        /// Returns a list of permission warnings for the given extension id.
        /// </summary>
        /// <param name="id">The ID of an already installed extension.</param>
        /// <param name="callback">( optional ) </param>
        public static void getPermissionWarningsById(JsString id, JsAction callback) { }
        /// <summary>
        /// Returns a list of permission warnings for the given extension id.
        /// </summary>
        /// <param name="id">The ID of an already installed extension.</param>
        public static void getPermissionWarningsById(JsString id) { }

        /// <summary>
        /// Returns a list of permission warnings for the given extension manifest string.
        /// Note: This function can be used without requesting the 'management' permission in the manifest.
        /// </summary>
        /// <param name="manifestStr">Extension manifest JSON string.</param>
        /// <param name="callback">( optional ) </param>
        public static void getPermissionWarningsByManifest(JsString manifestStr, JsAction callback) { }
        /// <summary>
        /// Returns a list of permission warnings for the given extension manifest string.
        /// Note: This function can be used without requesting the 'management' permission in the manifest.
        /// </summary>
        /// <param name="manifestStr">Extension manifest JSON string.</param>
        public static void getPermissionWarningsByManifest(JsString manifestStr) { }

        /// <summary>
        /// Launches an application.
        /// </summary>
        /// <param name="id">The extension id of the application.</param>
        /// <param name="callback">( optional ) </param>
        public static void launchApp(JsString id, JsAction callback) { }
        /// <summary>
        /// Launches an application.
        /// </summary>
        /// <param name="id">The extension id of the application.</param>
        public static void launchApp(JsString id) { }

        /// <summary>
        /// Enables or disables an app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="enabled">Whether this item should be enabled or disabled.</param>
        /// <param name="callback">( optional ) </param>
        public static void setEnabled(JsString id, bool enabled, JsAction callback) { }
        /// <summary>
        /// Enables or disables an app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="enabled">Whether this item should be enabled or disabled.</param>
        public static void setEnabled(JsString id, bool enabled) { }

        /// <summary>
        /// Uninstalls a currently installed app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="options"></param>
        /// <param name="callback">( optional ) </param>
        public static void uninstall(JsString id, ManagementUninstallOptions options, JsAction callback) { }
        /// <summary>
        /// Uninstalls a currently installed app or extension.
        /// </summary>
        /// <param name="id">This should be the id from an item of $ref:ExtensionInfo.</param>
        /// <param name="options"></param>
        public static void uninstall(JsString id, ManagementUninstallOptions options) { }

        /// <summary>
        /// Fired when an app or extension has been disabled
        /// </summary>
        public static Event<JsAction<ExtensionInfo>> onDisabled { get; set; }

        /// <summary>
        /// Fired when an app or extension has been enabled.
        /// </summary>
        public static Event<JsAction<ExtensionInfo>> onEnabled { get; set; }

        /// <summary>
        /// Fired when an app or extension has been installed.
        /// </summary>
        public static Event<JsAction<ExtensionInfo>> onInstalled { get; set; }

        /// <summary>
        /// Fired when an app or extension has been uninstalled.
        /// </summary>
        public static Event<JsAction<JsString>> onUninstalled { get; set; }

    }

    /// <summary>
    /// Information about an icon belonging to an extension or app.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.management.IconInfo", Export = false)]
    public class IconInfo
    {
        /// <summary>
        /// A number representing the width and height of the icon. Likely values include (but are not limited to) 128, 48, 24, and 16.
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// The URL for this icon image. To display a grayscale version of the icon (to indicate that an extension is disabled, for example), append ?grayscale=true to the URL.
        /// </summary>
        public JsString url { get; set; }
    }

    /// <summary>
    /// Information about an installed extension or app.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.management.ExtensionInfo", Export = false)]
    public class ExtensionInfo
    {
        /// <summary>
        /// The extension's unique identifier.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The name of this extension or app.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The description of this extension or app.
        /// </summary>
        public JsString description { get; set; }

        /// <summary>
        /// The version of this extension or app.
        /// </summary>
        public JsString version { get; set; }

        /// <summary>
        /// Whether this extension can be disabled or uninstalled by the user.
        /// </summary>
        public bool mayDisable { get; set; }

        /// <summary>
        /// Whether it is currently enabled or disabled.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// ( optional enumerated string ["unknown", "permissions_increase"] ) A reason the item is disabled.
        /// </summary>
        public object disabledReason { get; set; }

        /// <summary>
        /// True if this is an app.
        /// </summary>
        public bool isApp { get; set; }

        /// <summary>
        /// ( optional ) The launch url (only present for apps).
        /// </summary>
        public JsString appLaunchUrl { get; set; }

        /// <summary>
        /// ( optional ) The URL of the homepage of this extension or app.
        /// </summary>
        public JsString homepageUrl { get; set; }

        /// <summary>
        ///  ( optional string ) The update URL of this extension or app.
        /// </summary>
        public JsString updateUrl { get; set; }

        /// <summary>
        /// Whether the extension or app declares that it supports offline.
        /// </summary>
        public bool offlineEnabled { get; set; }

        /// <summary>
        /// The url for the item's options page, if it has one.
        /// </summary>
        public JsString optionsUrl { get; set; }

        /// <summary>
        /// ( optional )  A list of icon information. Note that this just reflects what was declared in the manifest, and the actual image at that url may be larger or smaller than
        /// what was declared, so you might consider using explicit width and height attributes on img tags referencing these images. See the manifest documentation on icons for more details.
        /// </summary>
        public JsArray<IconInfo> icons { get; set; }

        /// <summary>
        /// Returns a list of API based permissions.
        /// </summary>
        public JsArray<JsString> permissions { get; set; }

        /// <summary>
        /// Returns a list of host based permissions.
        /// </summary>
        public JsArray<JsString> hostPermissions { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ManagementUninstallOptions
    {
        /// <summary>
        /// Whether or not a confirm-uninstall dialog should prompt the user. Defaults to false.
        /// </summary>
        public bool showConfirmDialog { get; set; }
    }

    #endregion

    #region omnibox

    /// <summary>
    /// The omnibox API allows you to register a keyword with Google Chrome's address bar, which is also known as the omnibox.
    /// Note: Chrome automatically creates a grayscale version of your 16x16-pixel icon. You should provide a full-color version so that it can also be used in other situations that require color.
    /// For example, the context menus API also uses a 16x16-pixel icon, but it is displayed in color.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.omnibox", Export = false)]
    public class omnibox
    {
        /// <summary>
        /// Sets the description and styling for the default suggestion. The default suggestion is the text that is displayed in the first suggestion row underneath the URL bar.
        /// </summary>
        /// <param name="suggestion">A partial SuggestResult object, without the 'content' parameter. See SuggestResult for a description of the parameters.</param>
        public static void setDefaultSuggestion(OmniboxDefaultSuggestion suggestion) { }

        /// <summary>
        /// User has ended the keyword input session without accepting the input.
        /// </summary>
        public static Event<JsAction> onInputCancelled { get; set; }

        /// <summary>
        /// User has changed what is typed into the omnibox.
        /// </summary>
        public static Event<JsAction<JsString, JsAction<JsArray<SuggestResult>>>> onInputChanged { get; set; }

        /// <summary>
        /// User has accepted what is typed into the omnibox.
        /// </summary>
        public static Event<JsAction<JsString>> onInputEntered { get; set; }

        /// <summary>
        /// User has started a keyword input session by typing the extension's keyword.
        /// This is guaranteed to be sent exactly once per input session, and before any onInputChanged events.
        /// </summary>
        public static Event<JsAction> onInputStarted { get; set; }

    }

    /// <summary>
    /// A partial SuggestResult object, without the 'content' parameter. See SuggestResult for a description of the parameters.
    /// </summary>
    [JsType(JsMode.Json)]
    public class OmniboxDefaultSuggestion
    {
        /// <summary>
        /// The text to display in the default suggestion. The placeholder string '%s' can be included and will be replaced with the user's input.
        /// </summary>
        public JsString description { get; set; }
    }

    /// <summary>
    /// A suggest result.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.omnibox.SuggestResult", Export = false)]
    public class SuggestResult
    {
        /// <summary>
        /// The text that is put into the URL bar, and that is sent to the extension when the user chooses this entry.
        /// </summary>
        public JsString content { get; set; }

        /// <summary>
        /// The text that is displayed in the URL dropdown. Can contain XML-style markup for styling. The supported tags are 'url' (for a literal URL),
        /// 'match' (for highlighting text that matched what the user's query), and 'dim' (for dim helper text). The styles can be nested, eg. dimmed match
        /// </summary>
        public JsString description { get; set; }
    }

    #endregion

    #region pageAction

    /// <summary>
    /// Use page actions to put icons inside the address bar. Page actions represent actions that can be taken on the current page, but that aren't applicable to all pages. Some examples:
    /// Subscribe to this page's RSS feed
    /// Make a slideshow out of this page's photos
    /// The RSS icon in the following screenshot represents a page action that lets you subscribe to the RSS feed for the current page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.pageAction", Export = false)]
    public class pageAction
    {
        /// <summary>
        /// Gets the html document set as the popup for this browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getPopup(PageActionPopupDetails details, JsAction callback) { }

        /// <summary>
        /// Gets the title of the browser action.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getTitle(PageActionTitleDetails details, JsAction callback) { }

        /// <summary>
        /// Hides the page action.
        /// </summary>
        /// <param name="tabId">The id of the tab for which you want to modify the page action.</param>
        public static void hide(JsNumber tabId) { }

        /// <summary>
        /// Sets the icon for the page action. The icon can be specified either as the path to an image file
        /// or as the pixel data from a canvas element. Either the path or the imageData property must be specified.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback">( optional )</param>
        public static void setIcon(PageActionIconDetails details, JsAction callback) { }
        /// <summary>
        /// Sets the icon for the page action. The icon can be specified either as the path to an image file
        /// or as the pixel data from a canvas element. Either the path or the imageData property must be specified.
        /// </summary>
        /// <param name="details"></param>
        public static void setIcon(PageActionIconDetails details) { }

        /// <summary>
        /// Sets the html document to be opened as a popup when the user clicks on the page action's icon.
        /// </summary>
        /// <param name="details"></param>
        public static void setPopup(PageActionPopupDetails details) { }

        /// <summary>
        /// Sets the title of the page action. This is displayed in a tooltip over the page action.
        /// </summary>
        /// <param name="details"></param>
        public static void setTitle(PageActionTitleDetails details) { }

        /// <summary>
        /// Shows the page action. The page action is shown whenever the tab is selected.
        /// </summary>
        /// <param name="tabId">The id of the tab for which you want to modify the page action.</param>
        public static void show(JsNumber tabId) { }

        /// <summary>
        /// Fired when a page action icon is clicked. This event will not fire if the page action has a popup.
        /// </summary>
        public static Event<JsAction<Tab>> onClicked { get; set; }

    }

    [JsType(JsMode.Json)]
    public class PageActionPopupDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The html file to show in a popup. If set to the empty string (''), no popup is shown.
        /// </summary>
        public JsString popup { get; set; }

        /// <summary>
        /// for get operation: Specify the tab to get the popup from.
        /// for set operation:The id of the tab for which you want to modify the page action.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PageActionTitleDetails
    {
        /// <summary>
        /// This property is available for setter operations only.
        /// The tooltip string.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// for get operation: Specify the tab to get the title from.
        /// for set operation:The id of the tab for which you want to modify the page action.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PageActionIconDetails
    {
        /// <summary>
        /// The id of the tab for which you want to modify the page action.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( optional ) Pixel data for an image. Must be an ImageData object (for example, from a canvas element).
        /// </summary>
        public ImageData imageData { get; set; }

        /// <summary>
        /// ( optional ) Relative path to an image in the extension to show in the browser action.
        /// </summary>
        public JsNumber path { get; set; }

        /// <summary>
        /// ( optional ) Deprecated. The zero-based index into the icons vector specified in the manifest.
        /// </summary>
        public JsNumber iconIndex { get; set; }

    }

    #endregion

    #region pageCapture

    /// <summary>
    /// The pageCapture API allows you to save a tab as MHTML.
    /// MHTML is a standard format supported by most browsers. It encapsulates in a single file a page and all its resources (CSS files, images..).
    /// Note that for security reasons a MHTML file can only be loaded from the file system and that it can only be loaded in the main frame.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.pageCapture ", Export = false)]
    public class pageCapture
    {
        /// <summary>
        /// Saves the content of the tab with given id as MHTML.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback">Called when the MHTML has been generated.</param>
        public static void saveAsMHTML(PageCaptureDetails details, JsAction callback) { }
    }

    [JsType(JsMode.Json)]
    public class PageCaptureDetails
    {
        /// <summary>
        /// The id of the tab to save as MHTML.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    #endregion

    #region permissions

    /// <summary>
    /// Use the chrome.permissions module to implement optional permissions.
    /// You can request optional permissions during your extension's regular application flow rather than at install time,
    /// so users understand why the permissions are needed and use only those that are necessary.
    /// For general information about permissions and details about each permission, see the permissions section of the manifest documentation.
    /// 
    /// You can specify any of the following as optional permissions:
    /// host permissions
    /// appNotifications
    /// background
    /// bookmarks
    /// clipboardRead
    /// clipboardWrite
    /// contentSettings
    /// contextMenusk
    /// cookies
    /// debugger
    /// histokry
    /// idle
    /// management
    /// notifications
    /// pageCapture
    /// tabs
    /// topSites
    /// webNavigation
    /// webRequest
    /// webRequestBlocking
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.permissions ", Export = false)]
    public class permissions
    {
        /// <summary>
        /// Checks if the extension has the specified permissions.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="callback"></param>
        public static void contains(Permissions permissions, JsAction callback) { }

        /// <summary>
        /// Gets the extension's current set of permissions.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAll(JsAction callback) { }

        /// <summary>
        /// Removes access to the specified permissions. If there are any problems removing the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="callback"></param>
        public static void remove(Permissions permissions, JsAction callback) { }
        /// <summary>
        /// Removes access to the specified permissions. If there are any problems removing the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        public static void remove(Permissions permissions) { }

        /// <summary>
        /// Requests access to the specified permissions. These permissions must be defined in the optional_permissions field of the manifest.
        /// If there are any problems requesting the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        /// <param name="callback"></param>
        public static void request(Permissions permissions, JsAction callback) { }
        /// <summary>
        /// Requests access to the specified permissions. These permissions must be defined in the optional_permissions field of the manifest.
        /// If there are any problems requesting the permissions, chrome.extension.lastError will be set.
        /// </summary>
        /// <param name="permissions"></param>
        public static void request(Permissions permissions) { }

        /// <summary>
        /// Fired when the extension acquires new permissions.
        /// </summary>
        public static Event<JsAction<Permissions>> onAdded { get; set; }

        /// <summary>
        /// Fired when access to permissions has been removed from the extension.
        /// </summary>
        public static Event<JsAction<Permissions>> onRemoved { get; set; }

    }

    [JsType(JsMode.Prototype, Name = "chrome.permissions.Permissions ", Export = false)]
    public class Permissions
    {

        /// <summary>
        /// ( optional ) List of named permissions (does not include hosts or origins).
        /// </summary>
        public JsArray<JsString> permissions { get; set; }
    }

    #endregion

    #region privacy

    /// <summary>
    /// Use the chrome.privacy module to control usage of the features in Chrome that can affect a user's privacy.
    /// This module relies on the ChromeSetting prototype of the type API for getting and setting Chrome's configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.privacy ", Export = false)]
    public class privacy
    {
        /// <summary>
        /// Settings that influence Chrome's handling of network connections in general.
        /// </summary>
        public PrivacyNetworkSetting network { get; set; }

        /// <summary>
        /// Settings that enable or disable features that require third-party network services provided by Google and your default search provider.
        /// </summary>
        public PrivacyServicesSetting services { get; set; }

        /// <summary>
        /// Settings that determine what information Chrome makes available to websites.
        /// </summary>
        public PrivacyWebsitesSetting websites { get; set; }
    }

    /// <summary>
    /// Settings that influence Chrome's handling of network connections in general.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrivacyNetworkSetting
    {
        /// <summary>
        /// If enabled, Chrome attempts to speed up your web browsing experience by pre-resolving DNS entries, prerendering sites (&lt;link rel='prefetch' ...>),
        /// and preemptively opening TCP and SSL connections to servers. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting networkPredictionEnabled { get; set; }
    }

    /// <summary>
    /// Settings that enable or disable features that require third-party network services provided by Google and your default search provider.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrivacyServicesSetting
    {
        /// <summary>
        /// If enabled, Chrome uses a web service to help resolve navigation errors. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting alternateErrorPagesEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome offers to automatically fill in forms. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting autofillEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome automatically performs and displays search requests for text you type into the Omnibox as you type it.
        /// This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting NameinstantEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome does its best to protect you from phishing and malware. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting safeBrowsingEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome sends the text you type into the Omnibox to your default search engine, which provides predictions of websites and searches that are likely completions of what you've typed so far.
        /// This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting searchSuggestEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome uses a web service to help correct spelling errors. This preference's value is a boolean, defaulting to false.
        /// </summary>
        public ChromeSetting spellingServiceEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome offers to translate pages that aren't in a language you read. This preference's value is a boolean, defaulting to true.
        /// </summary>
        public ChromeSetting translationServiceEnabled { get; set; }
    }

    /// <summary>
    /// Settings that determine what information Chrome makes available to websites.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrivacyWebsitesSetting
    {
        /// <summary>
        /// If disabled, Chrome blocks third-party sites from setting cookies. The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting thirdPartyCookiesAllowed { get; set; }

        /// <summary>
        /// If enabled, Chrome sends auditing pings when requested by a website (&lt;a ping>). The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting hyperlinkAuditingEnabled { get; set; }

        /// <summary>
        /// If enabled, Chrome sends referer headers with your requests. Yes, the name of this preference doesn't match the misspelled header.
        /// No, we're not going to change it. The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting referrersEnabled { get; set; }

        /// <summary>
        /// Available on ChromeOS only: If enabled, Chrome provides a unique ID to plugins in order to run protected content.
        /// The value of this preference is of type boolean, and the default value is true.
        /// </summary>
        public ChromeSetting protectedContentEnabled { get; set; }
    }

    #endregion

    #region proxy

    /// <summary>
    /// Use the chrome.proxy module to manage Chrome's proxy settings.
    /// This module relies on the ChromeSetting prototype of the type API for getting and setting the proxy configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy ", Export = false)]
    public class proxy
    {
        /// <summary>
        /// Proxy settings to be used. The value of this setting is a ProxyConfig object
        /// </summary>
        public ChromeSetting settings { get; set; }

        /// <summary>
        /// Notifies about proxy errors.
        /// </summary>
        public static Event<JsAction<ProxyErrorDetails>> onProxyError { get; set; }

    }

    [JsType(JsMode.Json)]
    public class ProxyErrorDetails
    {
        /// <summary>
        /// If true, the error was fatal and the network transaction was aborted. Otherwise, a direct connection is used instead.
        /// </summary>
        public bool fatal { get; set; }

        /// <summary>
        /// The error description.
        /// </summary>
        public JsString error { get; set; }

        /// <summary>
        /// Additional details about the error such as a JavaScript runtime error..
        /// </summary>
        public JsString details { get; set; }
    }

    /// <summary>
    /// An object encapsulating a single proxy server's specification.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.ProxyServer ", Export = false)]
    public class ProxyServer
    {
        /// <summary>
        ///  ( optional enumerated string ["http", "https", "socks4", "socks5"] )
        ///  The scheme (protocol) of the proxy server itself. Defaults to 'http'.
        /// </summary>
        public ProxyServerSchemeType scheme { get; set; }

        /// <summary>
        /// The URI of the proxy server. This must be an ASCII hostname (in Punycode format). IDNA is not supported, yet.
        /// </summary>
        public JsString host { get; set; }

        /// <summary>
        /// ( optional ) The port of the proxy server. Defaults to a port that depends on the scheme.
        /// </summary>
        public JsNumber port { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ProxyServerSchemeType
    {
        http,
        https,
        socks4,
        socks5,
    }

    /// <summary>
    /// An object encapsulating the set of proxy rules for all protocols.
    /// Use either 'singleProxy' or (a subset of) 'proxyForHttp', 'proxyForHttps', 'proxyForFtp' and 'fallbackProxy'.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.ProxyRules ", Export = false)]
    public class ProxyRules
    {
        /// <summary>
        ///  ( optional )The proxy server to be used for all per-URL requests (that is http, https, and ftp).
        /// </summary>
        public ProxyServer singleProxy { get; set; }

        /// <summary>
        ///  ( optional ) The proxy server to be used for HTTP requests.
        /// </summary>
        public ProxyServer proxyForHttp { get; set; }

        /// <summary>
        ///  ( optional ) The proxy server to be used for HTTPS requests.
        /// </summary>
        public ProxyServer proxyForHttps { get; set; }

        /// <summary>
        ///  ( optional )The proxy server to be used for FTP requests.
        /// </summary>
        public ProxyServer proxyForFtp { get; set; }

        /// <summary>
        ///  ( optional )The proxy server to be used for everthing else or if any of the specific proxyFor... is not specified.
        /// </summary>
        public ProxyServer fallbackProxy { get; set; }

        /// <summary>
        ///  ( optional ) List of servers to connect to without a proxy server.
        /// </summary>
        public JsArray<JsString> bypassList { get; set; }
    }

    /// <summary>
    /// An object holding proxy auto-config information. Exactly one of the fields should be non-empty.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.PacScript ", Export = false)]
    public class PacScript
    {
        /// <summary>
        /// ( optional ) URL of the PAC file to be used.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) A PAC script.
        /// </summary>
        public JsString data { get; set; }

        /// <summary>
        /// ( optional ) If true, an invalid PAC script will prevent the network stack from falling back to direct connections. Defaults to false.
        /// </summary>
        public bool mandatory { get; set; }
    }

    /// <summary>
    /// An object encapsulating a complete proxy configuration.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.proxy.ProxyConfig ", Export = false)]
    public class ProxyConfig
    {
        /// <summary>
        /// ( optional ) The proxy rules describing this configuration. Use this for 'fixed_servers' mode.
        /// </summary>
        public ProxyRules rules { get; set; }

        /// <summary>
        /// ( optional ) The proxy auto-config (PAC) script for this configuration. Use this for 'pac_script' mode.
        /// </summary>
        public PacScript pacScript { get; set; }

        /// <summary>
        /// ( enumerated string ["direct", "auto_detect", "pac_script", "fixed_servers", "system"] )
        /// </summary>
        public ProxyConfigModeType mode { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ProxyConfigModeType
    {
        /// <summary>
        /// Never use a proxy
        /// </summary>
        direct,
        /// <summary>
        /// Auto detect proxy settings
        /// </summary>
        auto_detect,
        /// <summary>
        /// Use specified PAC script
        /// </summary>
        pac_script,
        /// <summary>
        /// Manually specify proxy servers
        /// </summary>
        fixed_servers,
        /// <summary>
        /// Use system proxy settings
        /// </summary>
        system,
    }

    #endregion

    #region runtime

    /// <summary>
    /// Warning: This API is still under development. It is only available for Chrome users on the dev early release channel. Learn more.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.runtime ", Export = false)]
    public class runtime
    {
        /// <summary>
        /// Retrieves the JavaScript 'window' object for the background page running inside the current extension.
        /// If the background page is transient, the system will ensure it is loaded before calling the callback. If there is no background page, an error is set.
        /// </summary>
        /// <param name="callback"></param>
        public static void getBackgroundPage(JsAction callback) { }

        /// <summary>
        /// Sent to the transient background page just before it is unloaded. This gives the extension opportunity to do some clean up.
        /// Note that since the page is unloading, any asynchronous operations started while handling this event are not guaranteed to complete.
        /// </summary>
        public static Event<JsAction> onBackgroundPageUnloadingSoon { get; set; }

        /// <summary>
        /// Fired when the extension is first installed.
        /// </summary>
        public static Event<JsAction> onInstalled { get; set; }

    }

    #endregion

    #region storage

    /// <summary>
    /// Use the chrome.storage module to store, retrieve, and track changes to user data. This API has been optimized to meet the specific storage needs of extensions. It provides the same storage capabilities as the localStorage API with the following key differences:
    /// User data can be automatically synced with Chrome sync (using storage.sync).
    /// Your extension's content scripts can directly access user data without the need for a background page.
    /// A user's extension settings can be persisted even when using split incognito behavior.
    /// User data can be stored as objects (the localStorage API stores data in strings).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.storage ", Export = false)]
    public class storage
    {
        /// <summary>
        /// Items under the "sync" namespace are synced using Chrome Sync.
        /// </summary>
        public static SyncStorageChange sync { get; set; }

        /// <summary>
        /// Items under the "local" namespace are local to each machine.
        /// </summary>
        public static LocalStorageChange local { get; set; }

        /// <summary>
        /// Fired when one or more items change.
        /// Listener parameters:
        /// changes ( object )
        /// Object mapping each key that changed to its corresponding StorageChange for that item.
        /// namespace ( string )
        /// The namespace ("sync" or "local") of the storage area the changes are for.
        /// </summary>
        public static Event<JsAction<object, JsString>> onChanged { get; set; }

    }

    /// <summary>
    /// Items under the "sync" namespace are synced using Chrome Sync.
    /// </summary>
    [JsType(JsMode.Json)]
    public class SyncStorageChange : StorageArea
    {
        /// <summary>
        /// The maximum total amount (in bytes) of data that can be stored in sync storage.
        /// Updates that would cause this limit to be exceeded fail immediately and set chrome.extension.lastError.
        /// </summary>
        public const int QUOTA_BYTES = 102400;

        /// <summary>
        /// The maximum size (in bytes) of each individual item in sync storage. Updates containing items larger than this limit will fail.
        /// </summary>
        public const int QUOTA_BYTES_PER_ITEM = 2048;

        /// <summary>
        /// The maximum number of items that can be stored in sync storage. Updates that would cause this limit to be exceeded will fail
        /// </summary>
        public const int MAX_ITEMS = 512;

        /// <summary>
        /// The maximum number of set, remove, or clear operations that can be performed each hour. Updates that would cause this limit to be exceeded fail.
        /// </summary>
        public const int MAX_WRITE_OPERATIONS_PER_HOUR = 1000;

        /// <summary>
        /// The maximum number of set, remove, or clear operations that can be performed each minute, sustained over 10 minutes.
        /// Updates that would cause this limit to be exceeded fail.
        /// </summary>
        public const int MAX_SUSTAINED_WRITE_OPERATIONS_PER_MINUTE = 10;
    }

    /// <summary>
    /// Items under the "local" namespace are local to each machine.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LocalStorageChange : StorageArea
    {
        /// <summary>
        /// The maximum amount (in bytes) of data that can be stored in local storage.
        /// This value will be ignored if the extension has the unlimitedStorage permission. Updates that would cause this limit to be exceeded fail.
        /// </summary>
        public const int QUOTA_BYTES = 5242880;
    }

    [JsType(JsMode.Prototype, Name = "chrome.storage.StorageChange ", Export = false)]
    public class StorageChange
    {
        /// <summary>
        /// The old value of the item, if there was an old value.
        /// </summary>
        public object oldValue { get; set; }

        /// <summary>
        /// The new value of the item, if there is a new value.
        /// </summary>
        public object newValue { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.storage.StorageArea ", Export = false)]
    public class StorageArea
    {
        /// <summary>
        /// Removes all items from storage.
        /// </summary>
        /// <param name="callback"> ( optional ) Callback on success, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void clear(JsAction callback) { }
        /// <summary>
        /// Removes all items from storage.
        /// </summary>
        public void clear() { }

        /// <summary>
        /// Gets one or more items from storage.
        /// </summary>
        /// <param name="keys">( optional string or array of string or object ) 
        /// A single key to get, list of keys to get, or a dictionary specifying default values (see description of the object).
        /// An empty list or object will return an empty result object. Pass in null to get the entire contents of storage.</param>
        /// <param name="callback">Callback with storage items, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void get(JsString keys, JsAction callback) { }
        /// <summary>
        /// Gets one or more items from storage.
        /// </summary>
        /// <param name="keys">( optional string or array of string or object ) 
        /// A single key to get, list of keys to get, or a dictionary specifying default values (see description of the object).
        /// An empty list or object will return an empty result object. Pass in null to get the entire contents of storage.</param>
        /// <param name="callback">Callback with storage items, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void get(JsArray<JsString> keys, JsAction callback) { }
        /// <summary>
        /// Gets one or more items from storage.
        /// </summary>
        /// <param name="keys">( optional string or array of string or object ) 
        /// A single key to get, list of keys to get, or a dictionary specifying default values (see description of the object).
        /// An empty list or object will return an empty result object. Pass in null to get the entire contents of storage.</param>
        /// <param name="callback">Callback with storage items, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void get(object keys, JsAction callback) { }
        /// <summary>
        /// Gets one or more items from storage.
        /// </summary>
        /// <param name="callback">Callback with storage items, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void get(JsAction callback) { }

        /// <summary>
        /// Gets the amount of space (in bytes) being used by one or more items.
        /// </summary>
        /// <param name="keys">( optional string or array of string )
        /// A single key or list of keys to get the total usage for. An empty list will return 0. Pass in null to get the total usage of all of storage.</param>
        /// <param name="callback">Callback with the amount of space being used by storage, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void getBytesInUse(JsString keys, JsAction callback) { }
        /// <summary>
        /// Gets the amount of space (in bytes) being used by one or more items.
        /// </summary>
        /// <param name="keys">( optional string or array of string )
        /// A single key or list of keys to get the total usage for. An empty list will return 0. Pass in null to get the total usage of all of storage.</param>
        /// <param name="callback">Callback with the amount of space being used by storage, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void getBytesInUse(JsArray<JsString> keys, JsAction callback) { }
        /// <summary>
        /// Gets the amount of space (in bytes) being used by one or more items.
        /// </summary>
        /// <param name="callback">Callback with the amount of space being used by storage, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void getBytesInUse(JsAction callback) { }

        /// <summary>
        /// Removes one or more items from storage.
        /// </summary>
        /// <param name="keys">A single key or a list of keys for items to remove.</param>
        /// <param name="callback"> ( optional ) Callback on success, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void remove(JsString keys, JsAction callback) { }
        /// <summary>
        /// Removes one or more items from storage.
        /// </summary>
        /// <param name="keys">A single key or a list of keys for items to remove.</param>
        /// <param name="callback"> ( optional ) Callback on success, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void remove(JsArray<JsString> keys, JsAction callback) { }
        /// <summary>
        /// Removes one or more items from storage.
        /// </summary>
        /// <param name="keys">A single key or a list of keys for items to remove.</param>
        public void remove(JsString keys) { }

        /// <summary>
        /// Sets multiple items.
        /// </summary>
        /// <param name="items">Object specifying items to augment storage with. Values that cannot be serialized (functions, etc) will be ignored.</param>
        /// <param name="callback"> ( optional ) Callback on success, or on failure (in which case chrome.extension.lastError will be set).</param>
        public void set(object items, JsAction callback) { }
        /// <summary>
        /// Sets multiple items.
        /// </summary>
        /// <param name="items">Object specifying items to augment storage with. Values that cannot be serialized (functions, etc) will be ignored.</param>
        public void set(object items) { }
    }

    #endregion

    #region tabs

    [JsType(JsMode.Prototype, Name = "chrome.tabs", Export = false)]
    public class tabs
    {
        /// <summary>
        /// Captures the visible area of the currently active tab in the specified window. You must have host permission for the URL displayed by the tab.
        /// </summary>
        /// <param name="windowId">( optional ) The target window. Defaults to the current window.</param>
        /// <param name="options">( optional ) Set parameters of image capture, such as the format of the resulting image.</param>
        /// <param name="callback"></param>
        public static void captureVisibleTab(JsNumber windowId, TabsCaptureVisibleTabOptions options, JsAction callback) { }
        /// <summary>
        /// Captures the visible area of the currently active tab in the specified window. You must have host permission for the URL displayed by the tab.
        /// </summary>
        /// <param name="windowId">( optional ) The target window. Defaults to the current window.</param>
        /// <param name="callback"></param>
        public static void captureVisibleTab(JsNumber windowId, JsAction callback) { }
        /// <summary>
        /// Captures the visible area of the currently active tab in the specified window. You must have host permission for the URL displayed by the tab.
        /// </summary>
        /// <param name="callback"></param>
        public static void captureVisibleTab(JsAction callback) { }

        /// <summary>
        /// Connects to the content script(s) in the specified tab.
        /// The chrome.extension.onConnect event is fired in each content script running in the specified tab for the current extension.
        /// For more details, see Content Script Messaging.
        /// </summary>
        /// <param name="tabId"></param>
        /// <param name="connectInfo"></param>
        /// <returns>A port that can be used to communicate with the content scripts running in the specified tab.
        /// The port's onDisconnect event is fired if the tab closes or does not exist.</returns>
        public static Port connect(JsNumber tabId, TabsConnectInfo connectInfo) { return null; }
        /// <summary>
        /// Connects to the content script(s) in the specified tab.
        /// The chrome.extension.onConnect event is fired in each content script running in the specified tab for the current extension.
        /// For more details, see Content Script Messaging.
        /// </summary>
        /// <param name="tabId"></param>
        /// <returns>A port that can be used to communicate with the content scripts running in the specified tab.
        /// The port's onDisconnect event is fired if the tab closes or does not exist.</returns>
        public static Port connect(JsNumber tabId) { return null; }

        /// <summary>
        /// Creates a new tab. Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="createProperties"></param>
        /// <param name="callback"></param>
        public static void create(TabsCreateProperties createProperties, JsAction callback) { }
        /// <summary>
        /// Creates a new tab. Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="createProperties"></param>
        public static void create(TabsCreateProperties createProperties) { }

        /// <summary>
        /// Detects the primary language of the content in a tab.
        /// </summary>
        /// <param name="tabId"> ( optional ) Defaults to the active tab of the current window.</param>
        /// <param name="callback"></param>
        public static void detectLanguage(JsNumber tabId, JsAction callback) { }
        /// <summary>
        /// Detects the primary language of the content in a tab.
        /// </summary>
        /// <param name="callback"></param>
        public static void detectLanguage(JsAction callback) { }

        /// <summary>
        /// Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab in which to run the script; defaults to the active tab of the current window.</param>
        /// <param name="details">Details of the script to run. Either the code or the file property must be set, but both may not be set at the same time.</param>
        /// <param name="callback">( optional ) Called after all the JavaScript has been executed.</param>
        public static void executeScript(JsNumber tabId, TabsExecuteScriptDetails details, JsAction callback) { }
        /// <summary>
        /// Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab in which to run the script; defaults to the active tab of the current window.</param>
        /// <param name="details">Details of the script to run. Either the code or the file property must be set, but both may not be set at the same time.</param>
        public static void executeScript(JsNumber tabId, TabsExecuteScriptDetails details) { }
        /// <summary>
        /// Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="details">Details of the script to run. Either the code or the file property must be set, but both may not be set at the same time.</param>
        /// <param name="callback">( optional ) Called after all the JavaScript has been executed.</param>
        public static void executeScript(TabsExecuteScriptDetails details, JsAction callback) { }
        /// <summary>
        /// Injects JavaScript code into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="details">Details of the script to run. Either the code or the file property must be set, but both may not be set at the same time.</param>
        public static void executeScript(TabsExecuteScriptDetails details) { }

        /// <summary>
        /// Retrieves details about the specified tab.
        /// </summary>
        /// <param name="tabId"></param>
        /// <param name="callback"></param>
        public static void get(JsNumber tabId, JsAction callback) { }

        /// <summary>
        /// Gets the tab that this script call is being made from. May be undefined if called from a non-tab context (for example: a background page or popup view).
        /// </summary>
        /// <param name="callback"></param>
        public static void getCurrent(JsAction callback) { }

        /// <summary>
        /// Highlights the given tabs.
        /// </summary>
        /// <param name="highlightInfo"></param>
        /// <param name="callback"></param>
        public static void highlight(TabsHighlightInfo highlightInfo, JsAction callback) { }

        /// <summary>
        /// Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab in which to insert the CSS; defaults to the active tab of the current window.</param>
        /// <param name="details">Details of the CSS text to insert. Either the code or the file property must be set, but both may not be set at the same time.</param>
        /// <param name="callback">( optional ) Called when all the CSS has been inserted.</param>
        public static void insertCSS(JsNumber tabId, TabsInsertCSSDetails details, JsAction callback) { }
        /// <summary>
        /// Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="details">Details of the CSS text to insert. Either the code or the file property must be set, but both may not be set at the same time.</param>
        /// <param name="callback">( optional ) Called when all the CSS has been inserted.</param>
        public static void insertCSS(TabsInsertCSSDetails details, JsAction callback) { }
        /// <summary>
        /// Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab in which to insert the CSS; defaults to the active tab of the current window.</param>
        /// <param name="details">Details of the CSS text to insert. Either the code or the file property must be set, but both may not be set at the same time.</param>
        public static void insertCSS(JsNumber tabId, TabsInsertCSSDetails details) { }
        /// <summary>
        /// Injects CSS into a page. For details, see the programmatic injection section of the content scripts doc.
        /// </summary>
        /// <param name="details">Details of the CSS text to insert. Either the code or the file property must be set, but both may not be set at the same time.</param>
        public static void insertCSS(TabsInsertCSSDetails details) { }

        /// <summary>
        /// Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to move.</param>
        /// <param name="moveProperties"></param>
        /// <param name="callback">( optional )</param>
        public static void move(JsNumber tabIds, TabsMoveProperties moveProperties, JsAction callback) { }
        /// <summary>
        /// Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to move.</param>
        /// <param name="moveProperties"></param>
        public static void move(JsNumber tabIds, TabsMoveProperties moveProperties) { }
        /// <summary>
        /// Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to move.</param>
        /// <param name="moveProperties"></param>
        /// <param name="callback">( optional )</param>
        public static void move(JsArray<JsNumber> tabIds, TabsMoveProperties moveProperties, JsAction callback) { }
        /// <summary>
        /// Moves one or more tabs to a new position within its window, or to a new window. Note that tabs can only be moved to and from normal (window.type === "normal") windows.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to move.</param>
        /// <param name="moveProperties"></param>
        public static void move(JsArray<JsNumber> tabIds, TabsMoveProperties moveProperties) { }

        /// <summary>
        /// Gets all tabs that have the specified properties, or all tabs if no properties are specified.
        /// </summary>
        /// <param name="queryInfo"></param>
        /// <param name="callback"></param>
        public static void query(TabsQueryInfo queryInfo, JsAction callback) { }

        /// <summary>
        /// Reload a tab.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab to reload; defaults to the selected tab of the current window.</param>
        /// <param name="reloadProperties">( optional ) </param>
        /// <param name="callback">( optional ) </param>
        public static void name(JsNumber tabId, TabsReloadProperties reloadProperties, JsAction callback) { }
        /// <summary>
        /// Reload a tab.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab to reload; defaults to the selected tab of the current window.</param>
        /// <param name="reloadProperties">( optional ) </param>
        public static void name(JsNumber tabId, TabsReloadProperties reloadProperties) { }
        /// <summary>
        /// Reload a tab.
        /// </summary>
        /// <param name="tabId">( optional ) The ID of the tab to reload; defaults to the selected tab of the current window.</param>
        public static void name(JsNumber tabId) { }
        /// <summary>
        /// Reload a tab.
        /// </summary>
        public static void name() { }

        /// <summary>
        /// Closes one or more tabs. Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to close.</param>
        /// <param name="callback">( optional )</param>
        public static void remove(JsNumber tabIds, JsAction callback) { }
        /// <summary>
        /// Closes one or more tabs. Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to close.</param>
        public static void remove(JsNumber tabIds) { }
        /// <summary>
        /// Closes one or more tabs. Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to close.</param>
        /// <param name="callback">( optional )</param>
        public static void remove(JsArray<JsNumber> tabIds, JsAction callback) { }
        /// <summary>
        /// Closes one or more tabs. Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="tabIds">The tab or list of tabs to close.</param>
        public static void remove(JsArray<JsNumber> tabIds) { }

        /// <summary>
        /// Sends a single message to the content script(s) in the specified tab, with an optional callback to run when a response is sent back.
        /// The chrome.extension.onMessage event is fired in each content script running in the specified tab for the current extension.
        /// </summary>
        /// <param name="tabId"></param>
        /// <param name="message"></param>
        /// <param name="responseCallback">( optional )</param>
        public static void sendMessage(JsNumber tabId, object message, JsAction<object> responseCallback) { }
        /// <summary>
        /// Sends a single message to the content script(s) in the specified tab, with an optional callback to run when a response is sent back.
        /// The chrome.extension.onMessage event is fired in each content script running in the specified tab for the current extension.
        /// </summary>
        /// <param name="tabId"></param>
        /// <param name="message"></param>
        public static void sendMessage(JsNumber tabId, object message) { }

        /// <summary>
        /// Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.
        /// Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="tabId">( optional ) Defaults to the selected tab of the current window.</param>
        /// <param name="updateProperties"></param>
        /// <param name="callback"> ( optional )</param>
        public static void update(JsNumber tabId, TabsUpdateProperties updateProperties, JsAction callback) { }
        /// <summary>
        /// Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.
        /// Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="tabId">( optional ) Defaults to the selected tab of the current window.</param>
        /// <param name="updateProperties"></param>
        public static void update(JsNumber tabId, TabsUpdateProperties updateProperties) { }
        /// <summary>
        /// Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.
        /// Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="updateProperties"></param>
        public static void update(TabsUpdateProperties updateProperties) { }
        /// <summary>
        /// Modifies the properties of a tab. Properties that are not specified in updateProperties are not modified.
        /// Note: This function can be used without requesting the 'tabs' permission in the manifest.
        /// </summary>
        /// <param name="updateProperties"></param>
        /// <param name="callback"> ( optional )</param>
        public static void update(TabsUpdateProperties updateProperties, JsAction callback) { }

        /// <summary>
        /// Fires when the active tab in a window changes.
        /// Note that the tab's URL may not be set at the time this event fired, but you can listen to onUpdated events to be notified when a URL is set.
        /// </summary>
        public static Event<JsAction<TabsActiveInfo>> onActivated { get; set; }

        /// <summary>
        /// Fired when a tab is attached to a window, for example because it was moved between windows.
        /// </summary>
        public static Event<JsAction<JsNumber, TabsAttachInfo>> onAttached { get; set; }

        /// <summary>
        /// Fired when a tab is created.
        /// Note that the tab's URL may not be set at the time this event fired, but you can listen to onUpdated events to be notified when a URL is set.
        /// </summary>
        public static Event<JsAction<Tab>> onCreated { get; set; }

        /// <summary>
        /// Fired when a tab is detached from a window, for example because it is being moved between windows.
        /// </summary>
        public static Event<JsAction<JsNumber, TabsDetachInfo>> onDetached { get; set; }

        /// <summary>
        /// Fired when the highlighted or selected tabs in a window changes.
        /// </summary>
        public static Event<JsAction<TabsOnHighlightInfo>> onHighlighted { get; set; }

        /// <summary>
        /// Fired when a tab is moved within a window. Only one move event is fired, representing the tab the user directly moved.
        /// Move events are not fired for the other tabs that must move in response.
        /// This event is not fired when a tab is moved between windows. For that, see onDetached.
        /// </summary>
        public static Event<JsAction<JsNumber, TabsMoveInfo>> onMoved { get; set; }

        /// <summary>
        /// Fired when a tab is closed. Note: A listener can be registered for this event without requesting the 'tabs' permission in the manifest.
        /// </summary>
        public static Event<JsAction<JsNumber, TabsRemoveInfo>> onRemoved { get; set; }

        /// <summary>
        /// Fired when a tab is updated.
        /// </summary>
        public static Event<JsAction<JsNumber, TabsChangeInfo, Tab>> onUpdated { get; set; }

    }

    /// <summary>
    /// Set parameters of image capture, such as the format of the resulting image.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TabsCaptureVisibleTabOptions
    {
        /// <summary>
        /// ( optional enumerated string ["jpeg", "png"] ) The format of the resulting image. Default is jpeg.
        /// </summary>
        public FormatType format { get; set; }

        /// <summary>
        /// When format is 'jpeg', controls the quality of the resulting image. This value is ignored for PNG images.
        /// As quality is decreased, the resulting image will have more visual artifacts, and the number of bytes needed to store it will decrease.
        /// </summary>
        public JsNumber quality { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum FormatType
    {
        jpeg,
        png,
    }

    [JsType(JsMode.Json)]
    public class TabsConnectInfo
    {
        /// <summary>
        ///  ( optional ) Will be passed into onConnect for content scripts that are listening for the connection event.
        /// </summary>
        public JsString name { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsCreateProperties
    {
        /// <summary>
        /// ( optional ) The window to create the new tab in. Defaults to the current window.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// ( optional ) The position the tab should take in the window. The provided value will be clamped to between zero and the number of tabs in the window.
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// ( optional ) The URL to navigate the tab to initially. Fully-qualified URLs must include a scheme (i.e. 'http://www.google.com', not 'www.google.com').
        /// Relative URLs will be relative to the current page within the extension. Defaults to the New Tab Page.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) Whether the tab should become the active tab in the window. Defaults to true
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        /// ( optional ) Whether the tab should be pinned. Defaults to false
        /// </summary>
        public bool pinned { get; set; }

        /// <summary>
        /// ( optional ) The ID of the tab that opened this tab. If specified, the opener tab must be in the same window as the newly created tab.
        /// </summary>
        public bool openerTabId { get; set; }
    }

    /// <summary>
    /// Details of the script to run. Either the code or the file property must be set, but both may not be set at the same time.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TabsExecuteScriptDetails
    {
        /// <summary>
        /// ( optional ) JavaScript code to execute.
        /// </summary>
        public JsString code { get; set; }

        /// <summary>
        /// ( optional ) The window to create the new tab in. Defaults to the current window.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// ( optional ) JavaScript file to execute.
        /// </summary>
        public JsString file { get; set; }

        /// <summary>
        /// ( optional ) If allFrames is true, this function injects script into all frames of current page.
        /// By default, it's false and script is injected only into the top main frame.
        /// </summary>
        public bool allFrames { get; set; }

        /// <summary>
        /// ( optional enumerated string ["document_start", "document_end", "document_idle"] )
        /// The soonest that the script will be injected into the tab. Defaults to "document_idle".
        /// </summary>
        public RunAtTypes runAt { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum RunAtTypes
    {
        document_start,
        document_end,
        document_idle,
    }

    [JsType(JsMode.Json)]
    public class TabsHighlightInfo
    {
        /// <summary>
        /// ( optional ) The window that contains the tabs.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// One or more tab indices to highlight.
        /// </summary>
        public JsArray<JsNumber> tabs { get; set; }

        /// <summary>
        /// One or more tab indices to highlight.
        /// </summary>
        [JsProperty(Name = "tabs")]
        public JsNumber tabsNumber { get; set; }

    }

    /// <summary>
    /// Details of the CSS text to insert. Either the code or the file property must be set, but both may not be set at the same time.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TabsInsertCSSDetails
    {
        /// <summary>
        /// ( optional ) CSS code to be injected.
        /// </summary>
        public JsString code { get; set; }

        /// <summary>
        /// ( optional ) CSS file to be injected.
        /// </summary>
        public JsString file { get; set; }

        /// <summary>
        /// ( optional ) If allFrames is true, this function injects CSS text into all frames of current page.
        /// By default, it's false and CSS is injected only into the top main frame.
        /// </summary>
        public bool allFrames { get; set; }

        /// <summary>
        /// ( optional enumerated string ["document_start", "document_end", "document_idle"] )
        /// The soonest that the CSS will be injected into the tab. Defaults to "document_idle".
        /// </summary>
        public RunAtTypes runAt { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsMoveProperties
    {
        /// <summary>
        /// ( optional ) Defaults to the window the tab is currently in.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// The position to move the window to. -1 will place the tab at the end of the window.
        /// </summary>
        public JsNumber index { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsQueryInfo
    {
        /// <summary>
        /// ( optional ) Whether the tabs are active in their windows.
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        /// ( optional ) Whether the tabs are pinned.
        /// </summary>
        public bool pinned { get; set; }

        /// <summary>
        /// ( optional ) Whether the tabs are highlighted.
        /// </summary>
        public bool highlighted { get; set; }

        /// <summary>
        /// ( optional ) Whether the tabs are in the current window.
        /// </summary>
        public bool currentWindow { get; set; }

        /// <summary>
        /// ( optional ) Whether the tabs are in the last focused window.
        /// </summary>
        public bool lastFocusedWindow { get; set; }

        /// <summary>
        /// ( optional enumerated string ["loading", "complete"] ) Whether the tabs have completed loading.
        /// </summary>
        public StatusType status { get; set; }

        /// <summary>
        /// ( optional ) Match page titles against a pattern.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional ) Match tabs against a URL pattern.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The ID of the parent window, or chrome.windows.WINDOW_ID_CURRENT for the current window.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// ( optional ) The type of window the tabs are in.
        /// </summary>
        public WindowType windowType { get; set; }

        /// <summary>
        /// ( optional ) The position of the tabs within their windows.
        /// </summary>
        public JsNumber index { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum StatusType
    {
        loading,
        complete,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum WindowType
    {
        normal,
        popup,
        panel,
        app,
    }

    [JsType(JsMode.Json)]
    public class TabsReloadProperties
    {
        /// <summary>
        /// Whether using any local cache. Default is false.
        /// </summary>
        public bool bypassCache { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsUpdateProperties
    {
        /// <summary>
        /// ( optional ) A URL to navigate the tab to.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) Whether the tab should be active.
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        /// ( optional ) Adds or removes the tab from the current selection.
        /// </summary>
        public bool highlighted { get; set; }

        /// <summary>
        /// ( optional ) Whether the tab should be pinned.
        /// </summary>
        public bool pinned { get; set; }

        /// <summary>
        /// ( optional ) The ID of the tab that opened this tab. If specified, the opener tab must be in the same window as this tab.
        /// </summary>
        public JsNumber openerTabId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsActiveInfo
    {

        /// <summary>
        /// The ID of the tab that has become active.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// The ID of the window the active tab changed inside of.
        /// </summary>
        public JsNumber windowId { get; set; }

    }

    [JsType(JsMode.Json)]
    public class TabsAttachInfo
    {
        public JsNumber newWindowId { get; set; }

        public JsNumber newPosition { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsDetachInfo
    {
        public JsNumber oldWindowId { get; set; }

        public JsNumber oldPosition { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsOnHighlightInfo
    {
        /// <summary>
        /// The window whose tabs changed.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// All highlighted tabs in the window.
        /// </summary>
        public JsArray<JsNumber> tabIds { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsMoveInfo
    {
        public JsNumber windowId { get; set; }

        public JsNumber fromIndex { get; set; }

        public JsNumber toIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabsRemoveInfo
    {
        /// <summary>
        /// True when the tab is being closed because its window is being closed.
        /// </summary>
        public bool isWindowClosing { get; set; }

    }

    /// <summary>
    /// Lists the changes to the state of the tab that was updated.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TabsChangeInfo
    {
        /// <summary>
        ///  ( optional ) The status of the tab. Can be either loading or complete.
        /// </summary>
        public StatusType status { get; set; }

        /// <summary>
        /// The tab's URL if it has changed.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The tab's new pinned state.
        /// </summary>
        public bool pinned { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.tabs.Tab", Export = false)]
    public class Tab
    {
        /// <summary>
        /// The ID of the tab. Tab IDs are unique within a browser session.
        /// </summary>
        public JsNumber id { get; set; }

        /// <summary>
        /// The zero-based index of the tab within its window.
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// The ID of the window the tab is contained within.
        /// </summary>
        public JsNumber windowId { get; set; }

        /// <summary>
        /// ( optional ) The ID of the tab that opened this tab, if any. This will only be present if the opener tab still exists.
        /// </summary>
        public JsNumber openerTabId { get; set; }

        /// <summary>
        /// Whether the tab is highlighted.
        /// </summary>
        public bool highlighted { get; set; }

        /// <summary>
        /// Whether the tab is active in its window.
        /// </summary>
        public bool active { get; set; }

        /// <summary>
        /// Whether the tab is pinned.
        /// </summary>
        public bool pinned { get; set; }

        /// <summary>
        /// The URL the tab is displaying.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// ( optional ) The title of the tab. This may not be available if the tab is loading.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// ( optional ) The URL of the tab's favicon. This may not be available if the tab is loading.
        /// </summary>
        public JsString favIconUrl { get; set; }

        /// <summary>
        /// ( optional ) Either loading or complete.
        /// </summary>
        public JsString status { get; set; }

        /// <summary>
        /// ( optional ) Whether the tab is in an incognito window.
        /// </summary>
        public bool incognito { get; set; }
    }

    #endregion

    #region topSites

    /// <summary>
    /// The top sites module allows access to the top sites that are displayed on the new tab page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.topSites", Export = false)]
    public class topSites
    {
        /// <summary>
        /// Gets a list of top sites.
        /// </summary>
        /// <param name="callback"></param>
        public static void get(JsAction<MostVisitedURL> callback) { }
        //TODO: check
    }

    /// <summary>
    /// An object encapsulating a most visited URL, such as the URLs on the new tab page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.topSites.MostVisitedURL", Export = false)]
    public class MostVisitedURL
    {
        /// <summary>
        /// The most visited URL.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The title of the page
        /// </summary>
        public JsString title { get; set; }
    }

    #endregion

    #region tts

    /// <summary>
    /// Use the chrome.tts module to play synthesized text-to-speech (TTS) from your extension or packaged app.
    /// See also the related ttsEngine module, which allows an extension to implement a speech engine.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.tts", Export = false)]
    public class tts
    {
        /// <summary>
        /// Gets an array of all available voices.
        /// </summary>
        /// <param name="callback"></param>
        public static void getVoices(JsAction<JsArray<TtsVoice>> callback) { }


        ///// <summary>
        ///// Gets an array of all available voices.
        ///// </summary>
        ///// <returns></returns>
        //public static JsArray<TtsVoice> getVoices() { return null; }
        ////TODO: check!

        /// <summary>
        /// Checks whether the engine is currently speaking.
        /// On Mac OS X, the result is true whenever the system speech engine is speaking, even if the speech wasn't initiated by Chrome.
        /// </summary>
        /// <param name="callback"></param>
        public static void isSpeaking(JsAction<bool> callback) { }
        ///// <summary>
        ///// Checks whether the engine is currently speaking.
        ///// On Mac OS X, the result is true whenever the system speech engine is speaking, even if the speech wasn't initiated by Chrome.
        ///// </summary>
        ///// <returns></returns>
        //public static bool isSpeaking() { return false; }
        ////TODO: check!

        /// <summary>
        /// Speaks text using a text-to-speech engine.
        /// </summary>
        /// <param name="utterance">The text to speak, either plain text or a complete, well-formed SSML document.
        /// Speech engines that do not support SSML will strip away the tags and speak the text. The maximum length of the text is 32,768 characters.</param>
        /// <param name="options">( optional )The speech options.</param>
        /// <param name="callback">( optional )Called right away, before speech finishes. Check chrome.extension.lastError to make sure there were no errors.
        /// Use options.onEvent to get more detailed feedback.</param>
        public static void speak(JsString utterance, TtsSpeakOptions options, JsAction callback) { }
        /// <summary>
        /// Speaks text using a text-to-speech engine.
        /// </summary>
        /// <param name="utterance">The text to speak, either plain text or a complete, well-formed SSML document.
        /// Speech engines that do not support SSML will strip away the tags and speak the text. The maximum length of the text is 32,768 characters.</param>
        /// <param name="options">( optional )The speech options.</param>
        public static void speak(JsString utterance, TtsSpeakOptions options) { }
        /// <summary>
        /// Speaks text using a text-to-speech engine.
        /// </summary>
        /// <param name="utterance">The text to speak, either plain text or a complete, well-formed SSML document.
        /// Speech engines that do not support SSML will strip away the tags and speak the text. The maximum length of the text is 32,768 characters.</param>
        public static void speak(JsString utterance) { }
    }

    /// <summary>
    /// The speech options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TtsSpeakOptions
    {
        /// <summary>
        /// ( optional ) If true, enqueues this utterance if TTS is already in progress.
        /// If false (the default), interrupts any current speech and flushes the speech queue before speaking this new utterance.
        /// </summary>
        public bool enqueue { get; set; }

        /// <summary>
        /// ( optional ) The name of the voice to use for synthesis. If empty, uses any available voice.
        /// </summary>
        public JsString voiceName { get; set; }

        /// <summary>
        /// ( optional )The extension ID of the speech engine to use, if known.
        /// </summary>
        public JsString extensionId { get; set; }

        /// <summary>
        /// ( optional ) The language to be used for synthesis, in the form language-region. Examples: 'en', 'en-US', 'en-GB', 'zh-CN'.
        /// </summary>
        public JsString lang { get; set; }

        /// <summary>
        /// ( optional enumerated string ["male", "female"] )
        /// Gender of voice for synthesized speech.
        /// </summary>
        public GenderType gender { get; set; }

        /// <summary>
        /// ( optional ) Speaking rate relative to the default rate for this voice. 1.0 is the default rate, normally around 180 to 220 words per minute.
        /// 2.0 is twice as fast, and 0.5 is half as fast. Values below 0.1 or above 10.0 are strictly disallowed,
        /// but many voices will constrain the minimum and maximum rates further—for example a particular voice may not actually speak faster than 3 times normal
        /// even if you specify a value larger than 3.0.
        /// </summary>
        public JsNumber rate { get; set; }

        /// <summary>
        /// ( optional ) Speaking pitch between 0 and 2 inclusive, with 0 being lowest and 2 being highest. 1.0 corresponds to a voice's default pitch.
        /// </summary>
        public JsNumber pitch { get; set; }

        /// <summary>
        /// ( optional ) Speaking volume between 0 and 1 inclusive, with 0 being lowest and 1 being highest, with a default of 1.0.
        /// </summary>
        public JsNumber volume { get; set; }

        /// <summary>
        /// ( optional ) The TTS event types the voice must support.
        /// </summary>
        public JsArray<EventType> requiredEventTypes { get; set; }

        /// <summary>
        /// ( optional )The TTS event types that you are interested in listening to. If missing, all event types may be sent.
        /// </summary>
        public JsArray<EventType> desiredEventTypes { get; set; }

        /// <summary>
        /// ( optional )This function is called with events that occur in the process of speaking the utterance.
        /// </summary>
        public JsAction<TtsEvent> onEvent { get; set; }
    }

    /// <summary>
    /// An event from the TTS engine to communicate the status of an utterance.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.tts.TtsEvent", Export = false)]
    public class TtsEvent
    {
        /// <summary>
        /// ( enumerated string ["start", "end", "word", "sentence", "marker", "interrupted", "cancelled", "error"] )
        /// </summary>
        public EventType type { get; set; }

        /// <summary>
        /// ( optional ) The index of the current character in the utterance.
        /// </summary>
        public JsNumber charIndex { get; set; }

        /// <summary>
        /// ( optional ) The error description, if the event type is 'error'.
        /// </summary>
        public JsString errorMessage { get; set; }
    }

    /// <summary>
    /// Each event includes an event type, the character index of the current speech relative to the utterance, and for error events, an optional error message.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum EventType
    {
        /// <summary>
        /// The engine has started speaking the utterance.
        /// </summary>
        start,
        /// <summary>
        ///  A word boundary was reached. Use event.charIndex to determine the current speech position.
        /// </summary>
        word,
        /// <summary>
        ///  A sentence boundary was reached. Use event.charIndex to determine the current speech position.
        /// </summary>
        sentence,
        /// <summary>
        /// An SSML marker was reached. Use event.charIndex to determine the current speech position
        /// </summary>
        marker,
        /// <summary>
        /// The engine has finished speaking the utterance.
        /// </summary>
        end,
        /// <summary>
        /// This utterance was interrupted by another call to speak() or stop() and did not finish.
        /// </summary>
        interrupted,
        /// <summary>
        ///  This utterance was queued, but then cancelled by another call to speak() or stop() and never began to speak at all.
        /// </summary>
        cancelled,
        /// <summary>
        ///  An engine-specific error occurred and this utterance cannot be spoken. Check event.errorMessage for details.
        /// </summary>
        error

    }

    /// <summary>
    /// A description of a voice available for speech synthesis.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.tts.TtsVoice", Export = false)]
    public class TtsVoice
    {
        /// <summary>
        /// ( optional )The name of the voice.
        /// </summary>
        public JsString voiceName { get; set; }

        /// <summary>
        /// ( optional ) The language that this voice supports, in the form language-region. Examples: 'en', 'en-US', 'en-GB', 'zh-CN'.
        /// </summary>
        public JsString lang { get; set; }

        /// <summary>
        /// ( optional )This voice's gender.
        /// </summary>
        public GenderType gender { get; set; }

        /// <summary>
        /// ( optional )The ID of the extension providing this voice.
        /// </summary>
        public JsString extensionId { get; set; }

        /// <summary>
        /// ( optional )All of the callback event types that this voice is capable of sending.
        /// </summary>
        public JsArray<EventType> eventTypes { get; set; }
        //TODO: check
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum GenderType
    {
        male,
        female,
    }

    #endregion

    #region types

    /// <summary>
    /// The chrome.types module contains type declarations for Chrome.
    /// Currently this comprises only a prototype for giving other modules access to manage Chrome browser settings.
    /// This prototype is used, for example, for chrome.proxy.settings.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.types", Export = false)]
    public class types
    {
        //THIS CLAASS IS EMPTY. nothing to put inside.
    }

    /// <summary>
    /// An interface which allows access to a Chrome browser setting.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.types.ChromeSetting", Export = false)]
    public class ChromeSetting
    {
        /// <summary>
        /// Clears the setting. This way default settings can become effective again.
        /// </summary>
        /// <param name="details">What setting to clear.</param>
        /// <param name="callback">( optional )Called after the setting has been cleared.</param>
        public void clear(ChromeSettingClearDetails details, JsAction callback) { }
        /// <summary>
        /// Clears the setting. This way default settings can become effective again.
        /// </summary>
        /// <param name="details">What setting to clear.</param>
        public void clear(ChromeSettingClearDetails details) { }

        /// <summary>
        /// Gets the value of a setting.
        /// </summary>
        /// <param name="details">What setting to consider.</param>
        /// <param name="callback"></param>
        public void get(ChromeSettingGetDetails details, JsAction callback) { }

        /// <summary>
        /// Sets the value of a setting.
        /// </summary>
        /// <param name="details">What setting to change.</param>
        /// <param name="callback"> ( optional )Called after the setting has been set.</param>
        public void set(ChromeSettingSetDetails details, JsAction callback) { }
        /// <summary>
        /// Sets the value of a setting.
        /// </summary>
        /// <param name="details">What setting to change.</param>
        public void set(ChromeSettingSetDetails details) { }

        /// <summary>
        /// Fired when the value of the setting changes.
        /// </summary>
        public Event<JsAction<ChromeSettingChangeDetails>> onChange { get; set; }
    }

    /// <summary>
    /// What setting to clear.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ChromeSettingClearDetails
    {
        /// <summary>
        /// ( optional enumerated string ["regular", "incognito_persistent", "incognito_session_only"] )
        /// Where to clear the setting (default: regular). 
        /// </summary>
        public ChromeSettingScopeType scope { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ChromeSettingScopeType
    {
        /// <summary>
        /// setting for the regular profile (which is inherited by the incognito profile if not overridden elsewhere),
        /// </summary>
        regular,
        /// <summary>
        /// setting for the regular profile only (not inherited by the incognito profile),
        /// </summary>
        regular_only,
        /// <summary>
        /// setting for the incognito profile that survives browser restarts (overrides regular preferences),
        /// </summary>
        incognito_persistent,
        /// <summary>
        /// setting for the incognito profile that can only be set during an incognito session and is deleted when the incognito session ends
        /// (overrides regular and incognito_persistent preferences).
        /// </summary>
        incognito_session_only,
    }

    /// <summary>
    /// What setting to consider.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ChromeSettingGetDetails
    {
        /// <summary>
        ///  ( optional ) Whether to return the setting that applies to the incognito session (default false).
        /// </summary>
        public bool incognito { get; set; }
    }

    /// <summary>
    /// What setting to change.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ChromeSettingSetDetails
    {
        /// <summary>
        /// The value of the setting. 
        /// Note that every setting has a specific value type, which is described together with the setting. An extension should not set a value of a different type.
        /// </summary>
        public object value { get; set; }

        /// <summary>
        /// ( optional enumerated string ["regular", "regular_only", "incognito_persistent", "incognito_session_only"] )
        /// Where to set the setting (default: regular).
        /// </summary>
        public ChromeSettingScopeType scope { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ChromeSettingChangeDetails
    {

        /// <summary>
        /// The value of the setting.
        /// </summary>
        public object value { get; set; }

        /// <summary>
        /// ( enumerated string ["not_controllable", "controlled_by_other_extensions", "controllable_by_this_extension", "controlled_by_this_extension"] )
        /// </summary>
        public ChromeSettingLevelOfControl levelOfControl { get; set; }

        /// <summary>
        /// ( optional )
        /// Whether the value that has changed is specific to the incognito session.
        /// This property will only be present if the user has enabled the extension in incognito mode.
        /// </summary>
        public bool incognitoSpecific { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ChromeSettingLevelOfControl
    {
        /// <summary>
        /// cannot be controlled by any extension
        /// </summary>
        not_controllable,
        /// <summary>
        /// controlled by extensions with higher precedence
        /// </summary>
        controlled_by_other_extensions,
        /// <summary>
        /// can be controlled by this extension
        /// </summary>
        controllable_by_this_extension,
        /// <summary>
        ///  controlled by this extension
        /// </summary>
        controlled_by_this_extension,
    }

    #endregion

    #region webNavigation

    /// <summary>
    /// Use the chrome.webNavigation module to receive notifications about the status of navigations requests in-flight.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.webNavigation", Export = false)]
    public class webNavigation
    {
        /// <summary>
        /// Retrieves information about all frames of a given tab.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getAllFrames(WebNavigationAllFramesDetails details, JsAction callback) { }

        /// <summary>
        /// Retrieves information about the given frame. A frame refers to an &lt;iframe> or a &lt;frame> of a web page and is identified by a tab ID and a frame ID.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="callback"></param>
        public static void getFrame(WebNavigationFrameDetails details, JsAction callback) { }

        /// <summary>
        /// Fired when a navigation is about to occur.
        /// </summary>
        public Event<JsAction<WebNavigationBeforeNavigateDetails>> onBeforeNavigate { get; set; }

        /// <summary>
        /// Fired when a navigation is committed. The document (and the resources it refers to, such as images and subframes) might still be downloading,
        /// but at least part of the document has been received from the server and the browser has decided to switch to the new document.
        /// </summary>
        public Event<JsAction<WebNavigationCommittedDetails>> onCommitted { get; set; }

        /// <summary>
        /// Fired when a document, including the resources it refers to, is completely loaded and initialized.
        /// </summary>
        public Event<JsAction<WebNavigationCompletedDetails>> onCompleted { get; set; }

        /// <summary>
        /// Fired when a new window, or a new tab in an existing window, is created to host a navigation.
        /// </summary>
        public Event<JsAction<WebNavigationCreatedNavigationTargetDetails>> onCreatedNavigationTarget { get; set; }

        /// <summary>
        /// Fired when the page's DOM is fully constructed, but the referenced resources may not finish loading.
        /// </summary>
        public Event<JsAction<WebNavigationDOMContentLoadedDetails>> onDOMContentLoaded { get; set; }

        /// <summary>
        /// Fired when an error occurs and the navigation is aborted. This can happen if either a network error occurred, or the user aborted the navigation.
        /// </summary>
        public Event<JsAction<WebNavigationErrorOccurredDetails>> onErrorOccurred { get; set; }

        /// <summary>
        /// Fired when the reference fragment of a frame was updated. All future events for that frame will use the updated URL.
        /// </summary>
        public Event<JsAction<WebNavigationReferenceFragmentUpdatedDetails>> onReferenceFragmentUpdated { get; set; }
    }

    /// <summary>
    /// Information about the tab to retrieve all frames from.
    /// </summary>
    [JsType(JsMode.Json)]
    public class WebNavigationAllFramesDetails
    {
        /// <summary>
        /// The ID of the tab.
        /// </summary>
        public JsNumber tabId { get; set; }
    }

    /// <summary>
    /// Information about the frame to retrieve information about.
    /// </summary>
    [JsType(JsMode.Json)]
    public class WebNavigationFrameDetails
    {
        /// <summary>
        /// The ID of the tab in which the frame is.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// The ID of the frame in the given tab.
        /// </summary>
        public JsNumber frameId { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebNavigationBeforeNavigateDetails
    {
        /// <summary>
        /// The ID of the tab in which the navigation is about to occur.
        /// </summary>
        public JsNumber tabId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// The time when the browser was about to start the navigation, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebNavigationCommittedDetails
    {
        /// <summary>
        /// The ID of the tab in which the navigation is about to occur.
        /// </summary>
        public JsNumber tabId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ( enumerated string ["link", "typed", "auto_bookmark", "auto_subframe", "manual_subframe", "generated", "start_page", "form_submit", "reload", "keyword", "keyword_generated"] )
        /// Cause of the navigation. The same transition types as defined in the history API are used.
        /// </summary>
        public TransitionType transitionType { get; set; }

        /// <summary>
        /// ( array of string ["client_redirect", "server_redirect", "forward_back", "from_address_bar"] )
        /// A list of transition qualifiers.
        /// </summary>
        public JsArray<TransitionQualifiers> transitionQualifiers { get; set; }

        /// <summary>
        /// The time when the navigation was committed, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebNavigationCompletedDetails
    {
        /// <summary>
        /// The ID of the tab in which the navigation occurs.
        /// </summary>
        public JsNumber tabId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// The time when the document finished loading, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebNavigationCreatedNavigationTargetDetails
    {
        /// <summary>
        /// The ID of the tab in which the navigation is triggered.
        /// </summary>
        public JsNumber sourceTabId { get; set; }

        /// <summary>
        /// The ID of the frame with sourceTabId in which the navigation is triggered. 0 indicates the main frame.
        /// </summary>
        public JsNumber sourceFrameId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// The ID of the tab in which the url is opened
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// The time when the browser was about to create a new view, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

    }

    [JsType(JsMode.Json)]
    public class WebNavigationDOMContentLoadedDetails
    {

        /// <summary>
        /// The ID of the tab in which the navigation occurs.
        /// </summary>
        public JsNumber tabId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// The time when the page's DOM was fully constructed, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebNavigationErrorOccurredDetails
    {
        /// <summary>
        /// The ID of the tab in which the navigation occurs.
        /// </summary>
        public JsNumber tabId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// The error description.
        /// </summary>
        public JsString error { get; set; }

        /// <summary>
        /// The time when the error occurred, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebNavigationReferenceFragmentUpdatedDetails
    {

        /// <summary>
        /// The ID of the tab in which the navigation occurs.
        /// </summary>
        public JsNumber tabId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// 0 indicates the navigation happens in the tab content window; a positive value indicates navigation in a subframe. Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ( enumerated string ["link", "typed", "auto_bookmark", "auto_subframe", "manual_subframe", "generated", "start_page", "form_submit", "reload", "keyword", "keyword_generated"] )
        /// Cause of the navigation. The same transition types as defined in the history API are used.
        /// </summary>
        public TransitionType transitionType { get; set; }

        /// <summary>
        /// ( array of string ["client_redirect", "server_redirect", "forward_back", "from_address_bar"] )
        /// A list of transition qualifiers.
        /// </summary>
        public JsArray<TransitionQualifiers> transitionQualifiers { get; set; }

        /// <summary>
        /// The time when the navigation was committed, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TransitionQualifiers
    {
        /// <summary>
        /// One or more redirects caused by JavaScript or meta refresh tags on the page happened during the navigation.
        /// </summary>
        client_redirect,
        /// <summary>
        /// One or more redirects caused by HTTP headers sent from the server happened during the navigation.
        /// </summary>
        server_redirect,
        /// <summary>
        /// The user used the Forward or Back button to initiate the navigation.
        /// </summary>
        forward_back,
        /// <summary>
        /// The user initiated the navigation from the address bar (aka Omnibox).
        /// </summary>
        from_address_bar,

    }

    #endregion

    #region webRequest

    [JsType(JsMode.Prototype, Name = "chrome.webRequest", Export = false)]
    public class webRequest
    {
        /// <summary>
        /// Needs to be called when the behavior of the webRequest handlers has changed to prevent incorrect handling due to caching.
        /// This function call is expensive. Don't call it often.
        /// </summary>
        /// <param name="callback"></param>
        public static void handlerBehaviorChanged(JsAction callback) { }

        /// <summary>
        /// Fired when an authentication failure is received. The listener has three options: it can provide authentication credentials,
        /// it can cancel the request and display the error page, or it can take no action on the challenge.
        /// If bad user credentials are provided, this may be called multiple times for the same request.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestAuthRequiredDetails>, AuthRequiredExtraInfoSpec> onAuthRequired { get; set; }

        /// <summary>
        /// Fired when a server-initiated redirect is about to occur.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestBeforeRedirectDetails>, BeforeRedirectExtraInfoSpec> onBeforeRedirect { get; set; }

        /// <summary>
        /// Fired when a request is about to occur.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestBeforeRequestDetails>, BeforeRequestExtraInfoSpec> onBeforeRequest { get; set; }

        /// <summary>
        /// Fired before sending an HTTP request, once the request headers are available.
        /// This may occur after a TCP connection is made to the server, but before any HTTP data is sent.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestBeforeSendHeadersDetails>, BeforeSendHeadersExtraInfoSpec> onBeforeSendHeaders { get; set; }

        /// <summary>
        /// Fired when a request is completed.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestCompletedDetails>, CompletedExtraInfoSpec> onCompleted { get; set; }

        /// <summary>
        /// Fired when an error occurs.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestErrorOccurredDetails>> onErrorOccurred { get; set; }

        /// <summary>
        /// Fired when HTTP response headers of a request have been received.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestHeadersReceivedDetails>, HeadersReceivedExtraInfoSpec> onHeadersReceived { get; set; }

        /// <summary>
        /// Fired when the first byte of the response body is received. For HTTP requests, this means that the status line and response headers are available.
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestResponseStartedDetails>, ResponseStartedExtraInfoSpec> onResponseStarted { get; set; }

        /// <summary>
        /// Fired just before a request is going to be sent to the server (modifications of previous onBeforeSendHeaders callbacks are visible by the time onSendHeaders is fired).
        /// </summary>
        public static WebRequestEvent<JsAction<WebRequestonSendHeadersDetails>, SendHeadersExtraInfoSpec> onSendHeaders { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum AuthRequiredExtraInfoSpec
    {
        responseHeaders,
        blocking,
        asyncBlocking,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum BeforeRedirectExtraInfoSpec
    {
        responseHeaders,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum BeforeRequestExtraInfoSpec
    {
        blocking,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum BeforeSendHeadersExtraInfoSpec
    {
        requestHeaders,
        blocking,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum CompletedExtraInfoSpec
    {
        responseHeaders,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum HeadersReceivedExtraInfoSpec
    {
        responseHeaders,
        blocking,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ResponseStartedExtraInfoSpec
    {
        responseHeaders,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum SendHeadersExtraInfoSpec
    {
        requestHeaders,
    }

    /// <summary>
    /// An object describing filters to apply to webRequest events.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.webRequest.RequestFilter", Export = false)]
    public class RequestFilter
    {
        /// <summary>
        /// A list of URLs or URL patterns. Requests that cannot match any of the URLs will be filtered out.
        /// </summary>
        public JsArray<JsString> urls { get; set; }

        /// <summary>
        /// ( optional array of string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// A list of request types. Requests that cannot match any of the types will be filtered out.
        /// </summary>
        public RequestType types { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsNumber windowId { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum RequestType
    {
        main_frame,
        sub_frame,
        stylesheet,
        script,
        image,
        @object,
        xmlhttprequest,
        other,
    }

    /// <summary>
    /// An array of HTTP headers. Each header is represented as a dictionary containing the keys name and either value or binaryValue.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.webRequest.HttpHeaders", Export = false)]
    public class HttpHeaders
    {
        /// <summary>
        /// Name of the HTTP header.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// ( optional ) Value of the HTTP header if it can be represented by UTF-8.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// ( optional ) Value of the HTTP header if it cannot be represented by UTF-8, stored as individual byte values (0..255).
        /// </summary>
        public JsArray<JsNumber> binaryValue { get; set; }
    }

    /// <summary>
    /// Returns value for event handlers that have the 'blocking' extraInfoSpec applied. Allows the event handler to modify network requests.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.webRequest.BlockingResponse", Export = false)]
    public class BlockingResponse
    {

        /// <summary>
        /// ( optional ) If true, the request is cancelled. Used in onBeforeRequest, this prevents the request from being sent.
        /// </summary>
        public bool cancel { get; set; }

        /// <summary>
        /// ( optional ) Only used as a response to the onBeforeRequest event. If set, the original request is prevented from being sent and is instead redirected to the given URL.
        /// </summary>
        public JsString redirectUrl { get; set; }

        /// <summary>
        /// ( optional ) Only used as a response to the onBeforeSendHeaders event. If set, the request is made with these request headers instead.
        /// </summary>
        public HttpHeaders requestHeaders { get; set; }

        /// <summary>
        /// ( optional ) Only used as a response to the onHeadersReceived event. If set, the server is assumed to have responded with these response headers instead.
        /// Only return responseHeaders if you really want to modify the headers in order to limit the number of conflicts
        /// (only one extension may modify responseHeaders for each request).
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }

        /// <summary>
        /// ( optional ) Only used as a response to the onAuthRequired event. If set, the request is made using the supplied credentials.
        /// </summary>
        public BlockingResponseAuthCredentials authCredentials { get; set; }
    }

    /// <summary>
    /// Only used as a response to the onAuthRequired event. If set, the request is made using the supplied credentials.
    /// </summary>
    [JsType(JsMode.Json)]
    public class BlockingResponseAuthCredentials
    {

        public JsString username { get; set; }

        public JsString password { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestAuthRequiredDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// The authentication scheme, e.g. Basic or Digest.
        /// </summary>
        public JsString scheme { get; set; }

        /// <summary>
        ///  ( optional ) The authentication realm provided by the server, if there is one.
        /// </summary>
        public JsString realm { get; set; }

        /// <summary>
        /// The server requesting authentication.
        /// </summary>
        public WebRequestAuthRequiredChallengerDetails challenger { get; set; }

        /// <summary>
        /// True for Proxy-Authenticate, false for WWW-Authenticate.
        /// </summary>
        public bool isProxy { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this response.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }

        /// <summary>
        /// ( optional )HTTP status line of the response.
        /// </summary>
        public JsString statusLine { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestAuthRequiredChallengerDetails
    {
        public JsString host { get; set; }
        public JsNumber port { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestBeforeRedirectDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// The server IP address that the request was actually sent to. Note that it may be a literal IPv6 address.
        /// </summary>
        public JsString ip { get; set; }

        /// <summary>
        ///  ( optional ) Indicates if this response was fetched from disk cache.
        /// </summary>
        public bool fromCache { get; set; }

        /// <summary>
        /// Standard HTTP status code returned by the server.
        /// </summary>
        public JsNumber statusCode { get; set; }

        /// <summary>
        /// The new URL.
        /// </summary>
        public JsString redirectUrl { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this redirect.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }

        /// <summary>
        /// ( optional )HTTP status line of the response.
        /// </summary>
        public JsString statusLine { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestBeforeRequestDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestBeforeSendHeadersDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this redirect.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestCompletedDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// The server IP address that the request was actually sent to. Note that it may be a literal IPv6 address.
        /// </summary>
        public JsString ip { get; set; }

        /// <summary>
        ///  ( optional ) Indicates if this response was fetched from disk cache.
        /// </summary>
        public bool fromCache { get; set; }

        /// <summary>
        /// Standard HTTP status code returned by the server.
        /// </summary>
        public JsNumber statusCode { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this redirect.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }

        /// <summary>
        /// ( optional )HTTP status line of the response.
        /// </summary>
        public JsString statusLine { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestErrorOccurredDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        ///  ( optional ) The server IP address that the request was actually sent to. Note that it may be a literal IPv6 address.
        /// </summary>
        public JsString ip { get; set; }

        /// <summary>
        /// Indicates if this response was fetched from disk cache.
        /// </summary>
        public bool fromCache { get; set; }

        /// <summary>
        /// The error description. This string is not guaranteed to remain backwards compatible between releases. You must not parse and act based upon its content.
        /// </summary>
        public JsString error { get; set; }

    }

    [JsType(JsMode.Json)]
    public class WebRequestHeadersReceivedDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// ( optional )HTTP status line of the response.
        /// </summary>
        public JsString statusLine { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this redirect.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestResponseStartedDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// ( optional ) The server IP address that the request was actually sent to. Note that it may be a literal IPv6 address.
        /// </summary>
        public JsString ip { get; set; }

        /// <summary>
        ///Indicates if this response was fetched from disk cache.
        /// </summary>
        public bool fromCache { get; set; }

        /// <summary>
        /// Standard HTTP status code returned by the server.
        /// </summary>
        public JsNumber statusCode { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this redirect.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }

        /// <summary>
        /// ( optional )HTTP status line of the response.
        /// </summary>
        public JsString statusLine { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WebRequestonSendHeadersDetails
    {
        /// <summary>
        /// The ID of the request. Request IDs are unique within a browser session. As a result, they could be used to relate different events of the same request.
        /// </summary>
        public JsString requestId { get; set; }

        public JsString url { get; set; }

        /// <summary>
        /// Standard HTTP method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// The value 0 indicates that the request happens in the main frame; a positive value indicates the ID of a subframe in which the request happens.
        /// If the document of a (sub-)frame is loaded (type is main_frame or sub_frame), frameId indicates the ID of this frame, not the ID of the outer frame.
        /// Frame IDs are unique within a tab.
        /// </summary>
        public JsNumber frameId { get; set; }

        /// <summary>
        /// ID of frame that wraps the frame which sent the request. Set to -1 if no parent frame exists.
        /// </summary>
        public JsNumber parentFrameId { get; set; }

        /// <summary>
        /// The ID of the tab in which the request takes place. Set to -1 if the request isn't related to a tab.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( enumerated string ["main_frame", "sub_frame", "stylesheet", "script", "image", "object", "xmlhttprequest", "other"] )
        /// How the requested resource will be used.
        /// </summary>
        public RequestType type { get; set; }

        /// <summary>
        /// The time when this signal is triggered, in milliseconds since the epoch.
        /// </summary>
        public JsNumber timeStamp { get; set; }

        /// <summary>
        /// ( optional )The HTTP response headers that were received along with this redirect.
        /// </summary>
        public HttpHeaders responseHeaders { get; set; }
    }

    #endregion

    #region webstore

    [JsType(JsMode.Prototype, Name = "chrome.webstore", Export = false)]
    public class webstore
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">( optional ) If you have more than one &lt;link> tag on your page with the chrome-webstore-item relation,
        /// you can choose which item you'd like to install by passing in its URL here. If it is omitted, then the first (or only) link will be used.
        /// An exception will be thrown if the passed in URL does not exist on the page.</param>
        /// <param name="successCallback">( optional ) This function is invoked when inline installation successfully completes
        /// (after the dialog is shown and the user agrees to add the item to Chrome).
        /// You may wish to use this to hide the user interface element that prompted the user to install the app or extension.</param>
        /// <param name="failureCallback"> ( optional ) This function is invoked when inline installation does not successfully complete.
        /// Possible reasons for this include the user canceling the dialog, the linked item not being found in the store,
        /// or the install being initiated from a non-verified site.</param>
        public static void install(JsString url, JsAction successCallback, JsAction<JsString> failureCallback) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">( optional ) If you have more than one &lt;link> tag on your page with the chrome-webstore-item relation,
        /// you can choose which item you'd like to install by passing in its URL here. If it is omitted, then the first (or only) link will be used.
        /// An exception will be thrown if the passed in URL does not exist on the page.</param>
        /// <param name="successCallback">( optional ) This function is invoked when inline installation successfully completes
        /// (after the dialog is shown and the user agrees to add the item to Chrome).
        /// You may wish to use this to hide the user interface element that prompted the user to install the app or extension.</param>
        public static void install(JsString url, JsAction successCallback) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">( optional ) If you have more than one &lt;link> tag on your page with the chrome-webstore-item relation,
        /// you can choose which item you'd like to install by passing in its URL here. If it is omitted, then the first (or only) link will be used.
        /// An exception will be thrown if the passed in URL does not exist on the page.</param>
        /// <param name="failureCallback"> ( optional ) This function is invoked when inline installation does not successfully complete.
        /// Possible reasons for this include the user canceling the dialog, the linked item not being found in the store,
        /// or the install being initiated from a non-verified site.</param>
        public static void install(JsString url, JsAction<JsString> failureCallback) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">( optional ) If you have more than one &lt;link> tag on your page with the chrome-webstore-item relation,
        /// you can choose which item you'd like to install by passing in its URL here. If it is omitted, then the first (or only) link will be used.
        /// An exception will be thrown if the passed in URL does not exist on the page.</param>
        public static void install(JsString url) { }
    }

    #endregion

    #region windows

    /// <summary>
    /// Use the chrome.windows module to interact with browser windows. You can use this module to create, modify, and rearrange windows in the browser.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "chrome.windows", Export = false)]
    public class windows
    {
        /// <summary>
        /// The windowId value that represents the absence of a chrome browser window.
        /// </summary>
        public const int WINDOW_ID_NONE = -1;

        /// <summary>
        /// The windowId value that represents the current window.
        /// </summary>
        public const int WINDOW_ID_CURRENT = -2;

        /// <summary>
        /// Creates (opens) a new browser with any optional sizing, position or default URL provided.
        /// </summary>
        /// <param name="createData">( optional )</param>
        /// <param name="callback">( optional )</param>
        public static void create(WindowsCreateData createData, JsAction callback) { }
        /// <summary>
        /// Creates (opens) a new browser with any optional sizing, position or default URL provided.
        /// </summary>
        /// <param name="createData">( optional )</param>
        public static void create(WindowsCreateData createData) { }
        /// <summary>
        /// Creates (opens) a new browser with any optional sizing, position or default URL provided.
        /// </summary>
        public static void create() { }

        /// <summary>
        /// Gets details about a window.
        /// </summary>
        /// <param name="windowId"></param>
        /// <param name="getInfo"> ( optional )</param>
        /// <param name="callback"></param>
        public static void get(JsNumber windowId, WindowsGetInfo getInfo, JsAction callback) { }
        /// <summary>
        /// Gets details about a window.
        /// </summary>
        /// <param name="windowId"></param>
        /// <param name="callback"></param>
        public static void get(JsNumber windowId, JsAction callback) { }

        /// <summary>
        /// Gets all windows.
        /// </summary>
        /// <param name="getInfo"></param>
        /// <param name="callback"></param>
        public static void getAll(WindowsGetInfo getInfo, JsAction callback) { }
        /// <summary>
        /// Gets all windows.
        /// </summary>
        /// <param name="callback"></param>
        public static void getAll(JsAction callback) { }

        /// <summary>
        /// Gets the current window.
        /// </summary>
        /// <param name="getInfo"></param>
        /// <param name="callback"></param>
        public static void getCurrent(WindowsGetInfo getInfo, JsAction callback) { }
        /// <summary>
        /// Gets the current window.
        /// </summary>
        /// <param name="callback"></param>
        public static void getCurrent(JsAction callback) { }

        /// <summary>
        /// Gets the window that was most recently focused — typically the window 'on top'.
        /// </summary>
        /// <param name="getInfo"></param>
        /// <param name="callback"></param>
        public static void getLastFocused(WindowsGetInfo getInfo, JsAction callback) { }
        /// <summary>
        /// Gets the window that was most recently focused — typically the window 'on top'.
        /// </summary>
        /// <param name="getInfo"></param>
        /// <param name="callback"></param>
        public static void getLastFocused(JsAction callback) { }

        /// <summary>
        /// Removes (closes) a window, and all the tabs inside it.
        /// </summary>
        /// <param name="windowId"></param>
        /// <param name="callback"></param>
        public static void remove(JsNumber windowId, JsAction callback) { }
        /// <summary>
        /// Removes (closes) a window, and all the tabs inside it.
        /// </summary>
        /// <param name="windowId"></param>
        public static void remove(JsNumber windowId) { }

        /// <summary>
        /// Updates the properties of a window. Specify only the properties that you want to change; unspecified properties will be left unchanged.
        /// </summary>
        /// <param name="windowId"></param>
        /// <param name="updateInfo"></param>
        /// <param name="callback"></param>
        public static void update(JsNumber windowId, WindowsUpdateInfo updateInfo, JsAction callback) { }
        /// <summary>
        /// Updates the properties of a window. Specify only the properties that you want to change; unspecified properties will be left unchanged.
        /// </summary>
        /// <param name="windowId"></param>
        /// <param name="updateInfo"></param>
        public static void update(JsNumber windowId, WindowsUpdateInfo updateInfo) { }

        /// <summary>
        /// Fired when a window is created.
        /// </summary>
        public Event<JsAction<Window>> onCreated { get; set; }

        /// <summary>
        /// Fired when the currently focused window changes. Will be chrome.windows.WINDOW_ID_NONE if all chrome windows have lost focus.
        /// Note: On some Linux window managers, WINDOW_ID_NONE will always be sent immediately preceding a switch from one chrome window to another.
        /// </summary>
        public Event<JsAction<JsNumber>> onFocusChanged { get; set; }

        /// <summary>
        /// Fired when a window is removed (closed).
        /// </summary>
        public Event<JsAction<JsNumber>> onRemoved { get; set; }

    }

    [JsType(JsMode.Json)]
    public class WindowsCreateData
    {
        /// <summary>
        /// ( optional )A URL or list of URLs to open as tabs in the window. Fully-qualified URLs must include a scheme (i.e. 'http://www.google.com', not 'www.google.com').
        /// Relative URLs will be relative to the current page within the extension. Defaults to the New Tab Page.
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        /// ( optional )A URL or list of URLs to open as tabs in the window. Fully-qualified URLs must include a scheme (i.e. 'http://www.google.com', not 'www.google.com').
        /// Relative URLs will be relative to the current page within the extension. Defaults to the New Tab Page.
        /// </summary>
        [JsProperty(Name = "url")]
        public JsArray<JsString> urlArray { get; set; }

        /// <summary>
        /// ( optional ) The id of the tab for which you want to adopt to the new window.
        /// </summary>
        public JsNumber tabId { get; set; }

        /// <summary>
        /// ( optional )The number of pixels to position the new window from the left edge of the screen.
        /// If not specified, the new window is offset naturally from the last focused window. This value is ignored for panels.
        /// </summary>
        public JsNumber left { get; set; }

        /// <summary>
        /// ( optional )The number of pixels to position the new window from the top edge of the screen.
        /// If not specified, the new window is offset naturally from the last focused window. This value is ignored for panels.
        /// </summary>
        public JsNumber top { get; set; }

        /// <summary>
        ///( optional ) The width in pixels of the new window. If not specified defaults to a natural width.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// ( optional )The height in pixels of the new window. If not specified defaults to a natural height.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        ///  ( optional ) If true, opens an active window. If false, opens an inactive window.
        /// </summary>
        public bool focused { get; set; }

        /// <summary>
        /// ( optional )Whether the new window should be an incognito window.
        /// </summary>
        public bool incognito { get; set; }

        /// <summary>
        /// ( optional enumerated string ["normal", "popup", "panel"] )
        /// Specifies what type of browser window to create. The 'panel' type creates a popup unless the '--enable-panels' flag is set.
        /// </summary>
        public WindowType type { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WindowsUpdateInfo
    {
        /// <summary>
        /// ( optional )The offset from the left edge of the screen to move the window to in pixels. This value is ignored for panels.
        /// </summary>
        public JsNumber left { get; set; }

        /// <summary>
        /// ( optional )The offset from the top edge of the screen to move the window to in pixels. This value is ignored for panels.
        /// </summary>
        public JsNumber top { get; set; }

        /// <summary>
        ///( optional ) The width to resize the window to in pixels. This value is ignored for panels.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// ( optional )The height to resize the window to in pixels. This value is ignored for panels.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        ///  ( optional ) If true, brings the window to the front. If false, brings the next window in the z-order to the front.
        /// </summary>
        public bool focused { get; set; }

        /// <summary>
        /// ( optional )If true, causes the window to be displayed in a manner that draws the user's attention to the window, without changing the focused window.
        /// The effect lasts until the user changes focus to the window. This option has no effect if the window already has focus.
        /// Set to false to cancel a previous draw attention request.
        /// </summary>
        public bool drawAttention { get; set; }

        /// <summary>
        /// ( optional enumerated string ["normal", "minimized", "maximized", "fullscreen"] )
        /// The new state of the window. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined with 'left', 'top', 'width' or 'height'.
        /// </summary>
        public WindowState state { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WindowsGetInfo
    {
        /// <summary>
        /// If true, the window object will have a tabs property that contains a list of the $ref:tabs.Tab objects
        /// </summary>
        public bool populate { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "chrome.windows.Window", Export = false)]
    public class Window
    {
        /// <summary>
        /// The ID of the window. Window IDs are unique within a browser session.
        /// </summary>
        public JsNumber id { get; set; }

        /// <summary>
        /// Whether the window is currently the focused window.
        /// </summary>
        public bool focused { get; set; }

        /// <summary>
        /// The offset of the window from the top edge of the screen in pixels.
        /// </summary>
        public JsNumber top { get; set; }

        /// <summary>
        /// The offset of the window from the left edge of the screen in pixels.
        /// </summary>
        public JsNumber left { get; set; }

        /// <summary>
        /// The width of the window in pixels.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The height of the window in pixels.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        ///  ( optional ) Array of $ref:tabs.Tab objects representing the current tabs in the window.
        /// </summary>
        public JsArray<Tab> tabs { get; set; }

        /// <summary>
        /// Whether the window is incognito.
        /// </summary>
        public bool incognito { get; set; }

        /// <summary>
        /// ( enumerated string ["normal", "popup", "panel", "app"] )
        /// The type of browser window this is.
        /// </summary>
        public WindowType type { get; set; }

        /// <summary>
        /// ( enumerated string ["normal", "minimized", "maximized", "fullscreen"] )
        /// The state of this browser window.
        /// </summary>
        public WindowState state { get; set; }

        /// <summary>
        /// Whether the window is set to be always on top.
        /// </summary>
        public bool alwaysOnTop { get; set; }
    }

    /// <summary>
    /// The state of this browser window.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum WindowState
    {
        normal,
        minimized,
        maximized,
        fullscreen,
    }
    #endregion

    #region Manifest


    /// <summary>
    /// Every extension, installable web app, and theme has a JSON-formatted manifest file, named manifest.json, that provides important information.
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///{
    ///   // Required
    ///   "name": "My Extension",
    ///   "version": "versionString",
    ///   "manifest_version": 2,
    ///   // Recommended
    ///   "description": "A plain text description",
    ///   "icons": { ... },
    ///   "default_locale": "en",
    ///   // Pick one (or none)
    ///   "browser_action": {...},
    ///   "page_action": {...},
    ///   "theme": {...},
    ///   "app": {...},
    ///   // Add any of these that you need
    ///   "background": {...},
    ///   "chrome_url_overrides": {...},
    ///   "content_scripts": [...],
    ///   "content_security_policy": "policyString",
    ///   "file_browser_handlers": [...],
    ///   "homepage_url": "http://path/to/homepage",
    ///   "incognito": "spanning" or "split",
    ///   "intents": {...}
    ///   "key": "publicKey",
    ///   "minimum_chrome_version": "versionString",
    ///   "nacl_modules": [...],
    ///   "offline_enabled": true,
    ///   "omnibox": { "keyword": "aString" },
    ///   "options_page": "aFile.html",
    ///   "permissions": [...],
    ///   "plugins": [...],
    ///   "requirements": {...},
    ///   "update_url": "http://path/to/updateInfo.xml",
    ///   "web_accessible_resources": [...],
    ///   "sandbox": [...]
    /// }
    ///</code>
    ///</example>
    [JsType(JsMode.Prototype, Name = "chrome.Manifest", Export = false)]
    public class Manifest
    {
        // Required:

        /// <summary>
        /// A short, plain text string (no more than 45 characters) that identifies the extension. The name is used in the install dialog, extension management UI, and the store.
        /// You can specify locale-specific strings for this field; see Internationalization for details.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// One to four dot-separated integers identifying the version of this extension.
        /// A couple of rules apply to the integers: they must be between 0 and 65535, inclusive, and non-zero integers can't start with 0.
        /// For example, 99999 and 032 are both invalid.
        /// Here are some examples of valid versions:
        /// "version": "1"
        /// "version": "1.0"
        /// "version": "2.10.2"
        /// "version": "3.1.2.4567"
        /// The autoupdate system compares versions to determine whether an installed extension needs to be updated.
        /// If the published extension has a newer version string than the installed extension, then the extension is automatically updated.
        /// The comparison starts with the leftmost integers. If those integers are equal, the integers to the right are compared, and so on.
        /// For example, 1.2.0 is a newer version than 1.1.9.9999.
        /// A missing integer is equal to zero. For example, 1.1.9.9999 is newer than 1.1.
        /// For more information, see Autoupdating.
        /// </summary>
        public JsString version { get; set; }

        /// <summary>
        /// One integer specifying the version of the manifest file format your package requires.
        /// As of Chrome 18, developers should specify 2 (without quotes) to use the format as described by this document:
        /// "manifest_version": 2
        /// Consider manifest version 1 deprecated as of Chrome 18.
        /// Version 2 is not yet required, but we will, at some point in the not-too-distant future, stop supporting packages using deprecated manifest versions.
        /// Extensions, applications, and themes that aren't ready to make the jump to the new manifest version in Chrome 18 can either explicitly specify version 1,or leave the key off entirely.
        /// The changes between version 1 and version 2 of the manifest file format are described in detail in the manifest_version documentation.
        /// Setting manifest_version 2 in Chrome 17 or lower is not recommended.
        /// If your extension needs to work in older versions of Chrome, stick with version 1 for the moment. We'll give you ample warning before version 1 stops working.
        /// </summary>
        public JsNumber manifest_version { get; set; }

        // Recommended:

        /// <summary>
        /// A plain text string (no HTML or other formatting; no more than 132 characters) that describes the extension.
        /// The description should be suitable for both the browser's extension management UI and the Chrome Web Store.
        /// You can specify locale-specific strings for this field; see Internationalization for details.
        /// </summary>
        public JsString description { get; set; }

        /// <summary>
        /// One or more icons that represent the extension, app, or theme. You should always provide a 128x128 icon; it's used during installation and by the Chrome Web Store.
        /// Extensions should also provide a 48x48 icon, which is used in the extensions management page (chrome://extensions).
        /// You can also specify a 16x16 icon to be used as the favicon for an extension's pages. The 16x16 icon is also displayed in the experimental extension infobar feature.
        /// Icons should generally be in PNG format, because PNG has the best support for transparency.
        /// They can, however, be in any format supported by WebKit, including BMP, GIF, ICO, and JPEG. Here's an example of specifying the icons:
        /// "icons": { "16": "icon16.png",
        ///            "48": "icon48.png",
        ///           "128": "icon128.png" },
        /// Important: Use only the documented icon sizes. 
        /// 
        /// You might notice that Chrome sometimes resizes these icons down to smaller sizes. For example, the install dialog might shrink the 128-pixel icon down to 69 pixels. 
        /// 
        /// However, the details of Chrome's UI may change between versions, and these changes assume that developers are using the documented sizes.
        /// If you use other sizes, your icon may look bad in future versions of the browser.
        /// If you upload your extension, app, or theme using the Chrome Developer Dashboard, you'll need to upload additional images, including at least one screenshot of your extension.
        /// For more information, see the Chrome Web Store developer documentation.
        /// </summary>
        public object icons { get; set; }

        /// <summary>
        /// Specifies the subdirectory of _locales that contains the default strings for this extension.
        /// This field is required in extensions that have a _locales directory; it must be absent in extensions that have no _locales directory.
        /// For details, see Internationalization.
        /// </summary>
        public JsString default_locale { get; set; }

        // Pick one (or none):

        /// <summary>
        /// Register your browser action in the extension manifest like this:
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "My extension",
        ///   ...
        ///   "browser_action": {
        ///     "default_icon": "images/icon19.png", // optional
        ///     "default_title": "Google Mail",      // optional; shown in tooltip
        ///     "default_popup": "popup.html"        // optional
        ///   },
        ///   ...
        /// }
        ///</code>
        ///</example>
        public BrowserActionManifest browser_action { get; set; }

        /// <summary>
        /// Register your page action in the extension manifest like this:
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "My extension",
        ///   ...
        ///   "page_action": {
        ///     "default_icon": "icons/foo.png", // optional
        ///     "default_title": "Do action",    // optional; shown in tooltip
        ///     "default_popup": "popup.html"    // optional
        ///   },
        ///   ...
        /// }
        ///</code>
        ///</example>
        public PageActionManifest page_action { get; set; }

        /// <summary>
        /// A theme is a special kind of extension that changes the way the browser looks.
        /// Themes are packaged like regular extensions, but they don't contain JavaScript or HTML code.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "version": "2.6",
        ///   "name": "camo theme",
        ///   "theme": {
        ///     "images" : {
        ///       "theme_frame" : "images/theme_frame_camo.png",
        ///       "theme_frame_overlay" : "images/theme_frame_stripe.png",
        ///       "theme_toolbar" : "images/theme_toolbar_camo.png",
        ///       "theme_ntp_background" : "images/theme_ntp_background_norepeat.png",
        ///       "theme_ntp_attribution" : "images/attribution.png"
        ///     },
        ///     "colors" : {
        ///       "frame" : [71, 105, 91],
        ///       "toolbar" : [207, 221, 192],
        ///       "ntp_text" : [20, 40, 0],
        ///       "ntp_link" : [36, 70, 0],
        ///       "ntp_section" : [207, 221, 192],
        ///       "button_background" : [255, 255, 255]
        ///     },
        ///     "tints" : {
        ///       "buttons" : [0.33, 0.5, 0.47]
        ///     },
        ///     "properties" : {
        ///       "ntp_background_alignment" : "bottom"
        ///     }
        ///   }
        /// }
        ///</code>
        ///</example>
        public ThemeManifest theme { get; set; }

        /// <summary>
        /// Used by installable web apps, including packaged apps, to specify the URLs that the app uses.
        /// Most important is the launch page for the app—the page that the browser goes to when the user clicks the app's icon in the New Tab page.
        /// For details, see the documentation for hosted apps and packaged apps.
        /// </summary>
        public AppManifest app { get; set; }

        // Add any of these that you need:

        /// <summary>
        /// 
        /// </summary>
        public object background { get; set; }

        /// <summary>
        /// Register an override page in the extension manifest like this:
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "My extension",
        ///   ...
        ///   "chrome_url_overrides" : {
        ///     "pageToOverride": "myPage.html"
        ///   },
        ///   ...
        /// }
        ///</code>
        ///</example>
        public OverrideManifest chrome_url_overrides { get; set; }

        /// <summary>
        /// If your content script's code should always be injected, register it in the extension manifest using the content_scripts field, as in the following example.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "My extension",
        ///   ...
        ///   "content_scripts": [
        ///     {
        ///       "matches": ["http://www.google.com/*"],
        ///       "css": ["mystyles.css"],
        ///       "js": ["jquery.js", "myscript.js"]
        ///     }
        ///   ],
        ///   ...
        /// }
        ///</code>
        ///</example>
        public ContentManifest content_scripts { get; set; }

        /// <summary>
        /// In order to mitigate a large class of potental cross-site scripting issues,
        /// Chrome's extension system has incorporated the general concept of Content Security Policy (CSP) .
        /// This introduces some fairly strict policies that will make extensions more secure by default,
        /// and provides you with the ability to create and enforce rules governing the types of content that can be loaded and executed by your extensions and applications.
        /// In general, CSP works as a black/whitelisting mechanism for resources loaded or executed by your extensions.
        /// Defining a reasonable policy for your extension enables you to carefully consider the resources that your extension requires,
        /// and to ask the browser to ensure that those are the only resources your extension has access to.
        /// These policies provide security over and above the host permissions your extension requests; they're an additional layer of protection, not a replacement.
        /// </summary>
        public JsString content_security_policy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object file_browser_handlers { get; set; }

        /// <summary>
        /// The URL of the homepage for this extension. The extensions management page (chrome://extensions) will contain a link to this URL.
        /// This field is particularly useful if you host the extension on your own site.
        /// If you distribute your extension using the Chrome Web Store, the homepage URL defaults to the extension's own page.
        /// </summary>
        public JsString homepage_url { get; set; }

        /// <summary>
        /// Either "spanning" or "split", to specify how this extension will behave if allowed to run in incognito mode.
        /// The default for extensions is "spanning", which means that the extension will run in a single shared process.
        /// Any events or messages from an incognito tab will be sent to the shared process, with an incognito flag indicating where it came from.
        /// Because incognito tabs cannot use this shared process,
        /// an extension using the "spanning" incognito mode will not be able to load pages from its extension package into the main frame of an incognito tab.
        /// The default for installable web apps is "split", which means that all app pages in an incognito window will run in their own incognito process.
        /// If the app or extension contains a background page, that will also run in the incognito process. This incognito process runs along side the regular process,
        /// but has a separate memory-only cookie store. Each process sees events and messages only from its own context
        /// (for example, the incognito process will see only incognito tab updates). The processes are unable to communicate with each other.
        /// As a rule of thumb, if your extension or app needs to load a tab in an incognito browser, use split incognito behavior.
        /// If your extension or app needs to be logged into a remote server or persist settings locally, use spanning incognito behavior.
        /// </summary>
        public IncognitoType incognito { get; set; }

        /// <summary>
        /// A dictionary that specifies all intent handlers provided by this extension or app. Each key in the dictionary specifies
        /// an action verb that is handled by this extension.
        /// The following example specifies two handlers for the action verb "http://webintents.org/share".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "test",
        ///   "version": "1",
        ///   "intents": {
        ///     "http://webintents.org/share": [
        ///       {
        ///         "type": ["text/uri-list"],
        ///         "href": "/services/sharelink.html",
        ///         "title" : "Sample Link Sharing Intent",
        ///         "disposition" : "inline"
        ///       },
        ///       {
        ///         "type": ["image/*"],
        ///         "href": "/services/shareimage.html",
        ///         "title" : "Sample Image Sharing Intent",
        ///         "disposition" : "window"
        ///       }
        ///     ]
        ///   }
        /// }
        ///</code>
        ///</example>
        public object intents { get; set; }

        /// <summary>
        /// The version of Chrome that your extension, app, or theme requires, if any. The format for this string is the same as for the version field.
        /// </summary>
        public JsString minimum_chrome_version { get; set; }

        /// <summary>
        /// One or more mappings from MIME types to the Native Client module that handles each type.
        /// For example, the bold code in the following snippet registers a Native Client module as the content handler for the OpenOffice spreadsheet MIME type.
        /// The value of "path" is the location of a Native Client manifest (a .nmf file) within the extension directory.
        /// For more information on Native Client and .nmf files, see the Native Client Technical Overview.
        /// Each MIME type can be associated with only one .nmf file, but a single .nmf file might handle multiple MIME types.
        /// The following example shows an extension with two .nmf files that handle three MIME types.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "Native Client OpenOffice Spreadsheet Viewer",
        ///   "version": "0.1",
        ///   "description": "Open OpenOffice spreadsheets, right in your browser.",
        ///   "nacl_modules": [{
        ///     "path": "OpenOfficeViewer.nmf",
        ///     "mime_type": "application/vnd.oasis.opendocument.spreadsheet"
        ///   }]
        /// }
        ///</code>
        ///</example>
        public NaclModulesManifest nacl_modules { get; set; }

        /// <summary>
        /// Whether the app or extension is expected to work offline.
        /// When Chrome detects that it is offline, apps with this field set to true will be highlighted on the New Tab page.
        /// </summary>
        public bool offline_enabled { get; set; }

        /// <summary>
        /// You must include an omnibox keyword field in the manifest to use the omnibox API.
        /// You should also specify a 16x16-pixel icon, which will be displayed in the address bar when suggesting that users enter keyword mode.
        /// </summary>
        public OmniboxManifest omnibox { get; set; }

        /// <summary>
        /// To allow users to customize the behavior of your extension, you may wish to provide an options page.
        /// If you do, a link to it will be provided from the extensions management page at chrome://extensions.
        /// Clicking the Options link opens a new tab pointing at your options page.
        /// </summary>
        public JsString options_page { get; set; }

        /// <summary>
        /// An array of permissions that the extension or app might use. Each permission can be either one of a list of known strings
        /// (such as "geolocation") or a match pattern that gives access to one or more hosts.
        /// Permissions can help to limit damage if your extension or app is attacked.
        /// Some permissions are also displayed to users before installation, as detailed in Permission Warnings.
        /// If an extension API requires you to declare a permission in the manifest, then its documentation tells you how to do so.
        /// For example, the Tabs page shows you how to declare the "tabs" permission.
        /// Note: As of Chrome 16, some permissions can be optional. For details, see Optional Permissions.
        /// </summary>
        public JsArray<PermissionType> permissions { get; set; }

        /// <summary>
        /// Leveraging HTML and JavaScript makes developing new extensions really easy, but what if you have existing legacy or proprietary code that you want to reuse in your extension?
        /// You can bundle an NPAPI plugin with your extension, allowing you to call into native binary code from JavaScript.
        /// </summary>
        public object plugins { get; set; }

        /// <summary>
        /// Technologies required by the app or extension. Hosting sites such as the Chrome Web
        /// Store may use this list to dissuade users from installing apps or extensions that will not work on their computer.
        /// The only supported requirement is "3D", which denotes GPU hardware acceleration.
        /// For that requirement, you can list the 3D-related features your app requires, as demonstrated in the following example:
        /// </summary>
        public object requirements { get; set; }

        /// <summary>
        /// If you're hosting your own extension, you need to add the "update_url" field to your manifest.json file, like this:
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   "name": "My extension",
        ///   ...
        ///   "update_url": "http://myhost.com/mytestextension/updates.xml",
        ///   ...
        /// }
        ///</code>
        ///</example>
        public JsString update_url { get; set; }

        /// <summary>
        /// An array of strings specifying the paths (relative to the package root) of packaged resources that are expected to be usable in the context of a web page.
        /// For example, an extension that injects a content script with the intention of building up some custom interface for example.com would whitelist any
        /// resources that interface requires (images, icons, stylesheets, scripts, etc.)
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///{
        ///   ...
        ///   "web_accessible_resources": [
        ///     "images/my-awesome-image1.png",
        ///     "images/my-amazing-icon1.png",
        ///     "style/double-rainbow.css",
        ///     "script/double-rainbow.js"
        ///   ],
        ///   ...
        /// }
        ///</code>
        ///</example>
        public JsArray<JsString> web_accessible_resources { get; set; }

        /// <summary>
        /// Defines an collection of app or extension pages that are to be served in a sandboxed unique origin, and optionally a Content Security Policy to use with them.
        /// Being in a sandbox has two implications:
        /// A sandboxed page will not have access to extension or app APIs, or direct access to non-sandboxed pages (it may communicate with them via postMessage()).
        /// A sandboxed page is not subject to the Content Security Policy (CSP) used by the rest of the app or extension (it has its own separate CSP value).
        /// This means that, for example, it can use inline script and eval.
        /// If not specified, the default content_security_policy value is sandbox allow-scripts allow-forms.
        /// You can specify your CSP value to restrict the sandbox even further, but it must have the sandbox directive and may not have the allow-same-origin token
        /// (see the HTML5 specification for possible sandbox tokens).
        /// Note that you only need to list pages that you expected to be loaded in windows or frames. Resources used by sandboxed pages
        /// (e.g. stylesheets or JavaScript source files) do not need to appear in the sandboxed_page list, they will use the sandbox of the page that embeds them.
        /// Sandboxed page may only be specified when using manifest_version 2 or above.
        /// </summary>
        public JsArray<JsString> sandbox { get; set; }


    }
    //TODO: gussed most of it. danel  m u s t  check

    /// <summary>
    /// One or more mappings from MIME types to the Native Client module that handles each type.
    /// For example, the bold code in the following snippet registers a Native Client module as the content handler for the OpenOffice spreadsheet MIME type.
    /// The value of "path" is the location of a Native Client manifest (a .nmf file) within the extension directory.
    /// For more information on Native Client and .nmf files, see the Native Client Technical Overview.
    /// Each MIME type can be associated with only one .nmf file, but a single .nmf file might handle multiple MIME types.
    /// The following example shows an extension with two .nmf files that handle three MIME types.
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///{
    ///   "name": "Native Client OpenOffice Spreadsheet Viewer",
    ///   "version": "0.1",
    ///   "description": "Open OpenOffice spreadsheets, right in your browser.",
    ///   "nacl_modules": [{
    ///     "path": "OpenOfficeViewer.nmf",
    ///     "mime_type": "application/vnd.oasis.opendocument.spreadsheet"
    ///   }]
    /// }
    ///</code>
    ///</example>
    [JsType(JsMode.Json)]
    public class NaclModulesManifest
    {

        public JsString path { get; set; }

        public JsString mime_type { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PageActionManifest
    {
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString default_icon { get; set; }

        /// <summary>
        /// ( optional )  shown in tooltip
        /// </summary>
        public JsString default_title { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString default_popup { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BrowserActionManifest
    {
        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString default_icon { get; set; }

        /// <summary>
        /// ( optional )  shown in tooltip
        /// </summary>
        public JsString default_title { get; set; }

        /// <summary>
        /// ( optional )
        /// </summary>
        public JsString default_popup { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///{
    ///   "version": "2.6",
    ///   "name": "camo theme",
    ///   "theme": {
    ///     "images" : {
    ///       "theme_frame" : "images/theme_frame_camo.png",
    ///       "theme_frame_overlay" : "images/theme_frame_stripe.png",
    ///       "theme_toolbar" : "images/theme_toolbar_camo.png",
    ///       "theme_ntp_background" : "images/theme_ntp_background_norepeat.png",
    ///       "theme_ntp_attribution" : "images/attribution.png"
    ///     },
    ///     "colors" : {
    ///       "frame" : [71, 105, 91],
    ///       "toolbar" : [207, 221, 192],
    ///       "ntp_text" : [20, 40, 0],
    ///       "ntp_link" : [36, 70, 0],
    ///       "ntp_section" : [207, 221, 192],
    ///       "button_background" : [255, 255, 255]
    ///     },
    ///     "tints" : {
    ///       "buttons" : [0.33, 0.5, 0.47]
    ///     },
    ///     "properties" : {
    ///       "ntp_background_alignment" : "bottom"
    ///     }
    ///   }
    /// }
    ///</code>
    ///</example>
    [JsType(JsMode.Json)]
    public class ThemeManifest
    {
        /// <summary>
        /// Image resources use paths relative to the root of the extension. You can override any of the images that are specified by kThemeableImages in theme_service.cc.
        /// Just remove the "IDR_" and convert the remaining characters to lowercase. For example, IDR_THEME_NTP_BACKGROUND
        /// (which kThemeableImages uses to specify the background of the new tab pane) corresponds to "theme_ntp_background".
        /// </summary>
        public ThemeImage images { get; set; }

        /// <summary>
        /// Colors are in RGB format. To find the strings you can use within the "colors" field, look for kColor* strings in theme_service.cc.
        /// </summary>
        public ThemeColor colors { get; set; }

        /// <summary>
        /// You can specify tints to be applied to parts of the UI such as buttons, the frame, and the background tab.
        /// Google Chrome supports tints, not images, because images don't work across platforms and are brittle in the case of adding new buttons.
        /// To find the strings you can use within the "tints" field, look for kTint* strings in theme_service.cc.
        /// Tints are in Hue-Saturation-Lightness (HSL) format, using floating-point numbers in the range 0 - 1.0:
        /// Hue is an absolute value, with 0 and 1 being red.
        /// Saturation is relative to the currently provided image. 0.5 is no change, 0 is totally desaturated, and 1 is full saturation.
        /// Lightness is also relative, with 0.5 being no change, 0 as all pixels black, and 1 as all pixels white.
        /// You can alternatively use -1.0 for any of the HSL values to specify no change.
        /// </summary>
        public ThemeTint tints { get; set; }

        /// <summary>
        /// This field lets you specify properties such as background alignment, background repeat, and an alternate logo.
        /// To see the properties and the values they can have, see theme_service.cc.
        /// </summary>
        public ThemePropertie properties { get; set; }
    }

    /// <summary>
    /// Image resources use paths relative to the root of the extension. You can override any of the images that are specified by kThemeableImages in theme_service.cc.
    /// Just remove the "IDR_" and convert the remaining characters to lowercase. For example, IDR_THEME_NTP_BACKGROUND
    /// (which kThemeableImages uses to specify the background of the new tab pane) corresponds to "theme_ntp_background".
    /// </summary>
    [JsType(JsMode.Json)]
    public class ThemeImage
    {
        public JsString theme_frame { get; set; }

        public JsString theme_frame_overlay { get; set; }

        public JsString theme_toolbar { get; set; }

        public JsString theme_ntp_background { get; set; }

        public JsString theme_ntp_attribution { get; set; }
    }

    /// <summary>
    /// Colors are in RGB format. To find the strings you can use within the "colors" field, look for kColor* strings in theme_service.cc.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ThemeColor
    {
        public JsArray<JsNumber> frame { get; set; }

        public JsArray<JsNumber> toolbar { get; set; }

        public JsArray<JsNumber> ntp_text { get; set; }

        public JsArray<JsNumber> ntp_link { get; set; }

        public JsArray<JsNumber> ntp_section { get; set; }

        public JsArray<JsNumber> button_background { get; set; }
    }

    /// <summary>
    /// You can specify tints to be applied to parts of the UI such as buttons, the frame, and the background tab.
    /// Google Chrome supports tints, not images, because images don't work across platforms and are brittle in the case of adding new buttons.
    /// To find the strings you can use within the "tints" field, look for kTint* strings in theme_service.cc.
    /// Tints are in Hue-Saturation-Lightness (HSL) format, using floating-point numbers in the range 0 - 1.0:
    /// Hue is an absolute value, with 0 and 1 being red.
    /// Saturation is relative to the currently provided image. 0.5 is no change, 0 is totally desaturated, and 1 is full saturation.
    /// Lightness is also relative, with 0.5 being no change, 0 as all pixels black, and 1 as all pixels white.
    /// You can alternatively use -1.0 for any of the HSL values to specify no change.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ThemeTint
    {
        public JsArray<JsNumber> buttons { get; set; }
    }

    /// <summary>
    /// This field lets you specify properties such as background alignment, background repeat, and an alternate logo.
    /// To see the properties and the values they can have, see theme_service.cc.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ThemePropertie
    {
        public JsString ntp_background_alignment { get; set; }
    }

    /// <summary>
    /// Used by installable web apps, including packaged apps, to specify the URLs that the app uses.
    /// Most important is the launch page for the app—the page that the browser goes to when the user clicks the app's icon in the New Tab page.
    /// For details, see the documentation for hosted apps and packaged apps.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AppManifest
    {
        /// <summary>
        /// The URLs for the pages in the hosted app, not necessarily including the launch page.
        /// Once the app is installed, these pages and the launch page have the permissions requested in the manifest.
        /// Note: You don't need to specify the URLs for included files or for assets such as images.
        /// 
        /// Each URL must begin with http, https, or * (which matches both http and https). You can use wildcards for subdomains—for example, "*://*.example.com/".
        /// 
        /// Important: Do not put port numbers in the value of "urls".
        /// Port numbers aren't necessary there (all ports are valid), and values with port numbers are silently ignored, leaving the corresponding pages without the requested permissions.
        /// 
        /// You need to specify only the start of the app's URLs.
        /// For example, "https://www.google.com/accounts/" matches every URL that starts with that string, such as https://www.google.com/accounts/ and https://www.google.com/accounts/b/0/ManageAccount.
        /// 
        /// Important: If you provide multiple apps, avoid overlapping URLs.
        /// If a user tries to install an app whose "web_url" or "urls" values overlap with those of an already installed app, the second installation will fail due to URL conflict errors.
        /// For example, an app that specifies a "urls" value of "http://mail.example.com/" would conflict with an app that specifies "http://mail.example.com/mail/".
        /// 
        /// If the user downloads the app's .crx file from a server that's not the Chrome Web Store, only one domain is allowed, and it must be the same as the domain that serves the .crx file.
        /// For more information on hosting options, see the extensions documentation for Hosting.
        /// </summary>
        public JsString urls { get; set; }

        /// <summary>
        /// Required. Specifies what happens when the user launches the app.
        /// </summary>
        public AppLaunch launch { get; set; }
    }

    /// <summary>
    /// Specifies what happens when the user launches the app.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AppLaunch
    {
        /// <summary>
        /// Required. Specifies the launch page as an absolute URL.
        /// </summary>
        public JsString web_url { get; set; }

        /// <summary>
        /// The value "panel" makes the app appear in an app panel. By default, or when you specify "tab", the app appears in a tab.
        /// </summary>
        public ContainerType container { get; set; }

        /// <summary>
        /// If the container is set to "panel", this integer specifies the height of the panel in pixels.
        /// For example, you might specify "height":400. Note that you don't use quotation marks in the value.
        /// This field specifies the height of the area to display contents in; window decorations add a few more pixels to the total height.
        /// If the container isn't a panel, this field is ignored.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// Similar to "height", but specifies the width of the panel.
        /// </summary>
        public JsNumber width { get; set; }
    }

    [JsType(JsMode.Json)]
    public class OmniboxManifest
    {
        public JsString pageToOverride { get; set; }
    }

    /// <summary>
    /// Register an override page in the extension manifest like this:
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///{
    ///   "name": "My extension",
    ///   ...
    ///   "chrome_url_overrides" : {
    ///     "pageToOverride": "myPage.html"
    ///   },
    ///   ...
    /// }
    ///</code>
    ///</example>
    [JsType(JsMode.Json)]
    public class OverrideManifest
    {
        public JsString keyword { get; set; }

    }

    /// <summary>
    /// If your content script's code should always be injected, register it in the extension manifest using the content_scripts field, as in the following example.
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///{
    ///   "name": "My extension",
    ///   ...
    ///   "content_scripts": [
    ///     {
    ///       "matches": ["http://www.google.com/*"],
    ///       "css": ["mystyles.css"],
    ///       "js": ["jquery.js", "myscript.js"]
    ///     }
    ///   ],
    ///   ...
    /// }
    ///</code>
    ///</example>
    [JsType(JsMode.Json)]
    public class ContentManifest
    {

        /// <summary>
        /// Required. Specifies which pages this content script will be injected into.
        /// See Match Patterns for more details on the syntax of these strings and Match patterns and globs for information on how to exclude URLs.
        /// </summary>
        public JsArray<JsString> matches { get; set; }

        /// <summary>
        /// Optional. Excludes pages that this content script would otherwise be injected into.
        /// See Match Patterns for more details on the syntax of these strings and Match patterns and globs for information on how to exclude URLs.
        /// </summary>
        public JsArray<JsString> exclude_matches { get; set; }

        /// <summary>
        /// Optional. The list of CSS files to be injected into matching pages.
        /// These are injected in the order they appear in this array, before any DOM is constructed or displayed for the page.
        /// </summary>
        public JsArray<JsString> css { get; set; }

        /// <summary>
        /// Optional. The list of JavaScript files to be injected into matching pages. These are injected in the order they appear in this array.
        /// </summary>
        public JsArray<JsString> js { get; set; }

        /// <summary>
        /// Optional. Controls when the files in js are injected. Can be "document_start", "document_end", or "document_idle". Defaults to "document_idle". 
        /// 
        /// In the case of "document_start", the files are injected after any files from css, but before any other DOM is constructed or any other script is run. 
        /// 
        /// In the case of "document_end", the files are injected immediately after the DOM is complete, but before subresources like images and frames have loaded. 
        /// 
        /// In the case of "document_idle", the browser chooses a time to inject scripts between "document_end" and immediately after the window.onload event fires.
        /// The exact moment of injection depends on how complex the document is and how long it is taking to load, and is optimized for page load speed. 
        /// 
        /// Note: With "document_idle", content scripts may not necessarily receive the window.onload event, because they may run after it has already fired.
        /// In most cases, listening for the onload event is unnecessary for content scripts running at "document_idle" because they are guaranteed to run after the DOM is complete.
        /// If your script definitely needs to run after window.onload, you can check if onload has already fired by using the document.readyState property.
        /// </summary>
        public JsArray<RunAtTypes> run_at { get; set; }

        /// <summary>
        /// Optional. Controls whether the content script runs in all frames of the matching page, or only the top frame. 
        /// Defaults to false, meaning that only the top frame is matched.
        /// </summary>
        public bool all_frames { get; set; }

        /// <summary>
        /// Optional. Applied after matches to include only those URLs that also match this glob.
        /// Intended to emulate the @include Greasemonkey keyword. See Match patterns and globs below for more details.
        /// </summary>
        public JsArray<JsString> include_globs { get; set; }

        /// <summary>
        /// Optional. Applied after matches to exclude URLs that match this glob.
        /// Intended to emulate the @exclude Greasemonkey keyword. See Match patterns and globs below for more details.
        /// </summary>
        public JsArray<JsString> pageToOverride { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ContainerType
    {
        panel,
        tab,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum IncognitoType
    {
        spanning,
        split,
    }

    /// <summary>
    /// The following table lists the permissions an extension or packaged app can use.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PermissionType
    {
        /// <summary>
        /// Specifies a host permission. Required if the extension wants to interact with the code running on pages.
        /// Many extension capabilities, such as cross-origin XMLHttpRequests,
        /// programmatically injected content scripts, and the cookies API require host permissions. For details on the syntax, see Match Patterns.
        /// </summary>
        match_pattern,
        /// <summary>
        /// Makes Chrome start up early and and shut down late, so that apps and extensions can have a longer life.
        /// When any installed hosted app, packaged app, or extension has "background" permission,
        /// Chrome runs (invisibly) as soon as the user logs into their computer—before the user launches Chrome.
        /// The "background" permission also makes Chrome continue running (even after its last window is closed) until the user explicitly quits Chrome.
        /// Note: Disabled apps and extensions are treated as if they aren't installed.
        /// You typically use the "background" permission with a background page or (for hosted apps) a background window.
        /// </summary>
        background,
        /// <summary>
        /// Required if the extension uses the chrome.bookmarks module.
        /// </summary>
        bookmarks,
        /// <summary>
        /// Required if the extension uses the "chrome://favicon/url" mechanism to display the favicon of a page.
        /// For example, to display the favicon of http://www.google.com/, you declare the "chrome://favicon/" permission and use HTML code like this:
        ///&lt;img src="chrome://favicon/http://www.google.com/">
        /// </summary>
        favicon,
        /// <summary>
        /// Required if the extension uses document.execCommand('paste').
        /// </summary>
        clipboardRead,
        /// <summary>
        /// Indicates the app or extension uses document.execCommand('copy') or document.execCommand('cut').
        /// This permission is required for hosted apps; it's recommended for extensions and packaged apps.
        /// </summary>
        clipboardWrite,
        /// <summary>
        /// Required if the extension uses the chrome.contentSettings module.
        /// </summary>
        contentSettings,
        /// <summary>
        /// Required if the extension uses the chrome.contextMenus module.
        /// </summary>
        contextMenus,
        /// <summary>
        /// Required if the extension uses the chrome.cookies module.
        /// </summary>
        cookies,
        /// <summary>
        /// Required if the extension uses any chrome.experimental.* APIs.
        /// </summary>
        experimental,
        /// <summary>
        /// Required if the extension uses the fileBrowserhandler module.
        /// </summary>
        fileBrowserHandler,
        /// <summary>
        /// Allows the extension to use the proposed HTML5 geolocation API without prompting the user for permission.
        /// </summary>
        geolocation,
        /// <summary>
        /// Required if the extension uses the chrome.history module.
        /// </summary>
        history,
        /// <summary>
        /// Required if the extension uses the chrome.idle module.
        /// </summary>
        idle,
        /// <summary>
        /// Required if the extension uses the chrome.management module.
        /// </summary>
        management,
        /// <summary>
        /// Allows the extension to use the proposed HTML5 notification API without calling permission methods
        /// (such as checkPermission()). For more information see Desktop Notifications.
        /// </summary>
        notifications,
        /// <summary>
        /// Required if the extension uses the chrome.privacy module.
        /// </summary>
        privacy,
        /// <summary>
        /// Required if the extension uses the chrome.proxy module.
        /// </summary>
        proxy,
        /// <summary>
        /// Required if the extension uses the chrome.tabs or chrome.windows module.
        /// </summary>
        tabs,
        /// <summary>
        /// Required if the extension uses the chrome.tts module.
        /// </summary>
        tts,
        /// <summary>
        /// Required if the extension uses the chrome.ttsEngine module.
        /// </summary>
        ttsEngine,
        /// <summary>
        /// Provides an unlimited quota for storing HTML5 client-side data, such as databases and local storage files.
        /// Without this permission, the extension is limited to 5 MB of local storage.
        /// Note: This permission applies only to Web SQL Database and application cache (see issue 58985).
        /// Also, it doesn't currently work with wildcard subdomains such as http://*.example.com.
        /// </summary>
        unlimitedStorage,
        /// <summary>
        /// Required if the extension uses the chrome.webNavigation module.
        /// </summary>
        webNavigation,
        /// <summary>
        /// Required if the extension uses the chrome.webRequest module.
        /// </summary>
        webRequest,
        /// <summary>
        /// Required if the extension uses the chrome.webRequest module in a blocking fashion.
        /// </summary>
        webRequestBlocking,
    }

    #endregion

}

