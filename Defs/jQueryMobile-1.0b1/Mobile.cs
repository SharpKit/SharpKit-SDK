
using System.Collections.Generic;
using SharpKit.JavaScript;
using SharpKit.Html;
namespace SharpKit.jQueryMobile
{
    //TODO: $(document).bind("mobileinit"


    [JsType(JsMode.Prototype)]
    public partial class Mobile
    {

        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">jQuery collection object. ($("#about"))</param>
        /// <param name="options"></param>
        /// <example>
        /// transition to the "about us" page with a slideup transition
        /// <code>
        /// $.mobile.changePage( "about/us.html", { transition: "slideup"} );	
        /// </code>
        /// transition to the "search results" page, using data from a form with an ID of "search"
        /// <code>
        ///$.mobile.changePage( "searchresults.php", {type: "post", data: $("form#search").serialize()});
        ///</code>
        ///transition to the "confirm" page with a "pop" transition without tracking it in history
        ///<code>		
        ///$.mobile.changePage( "../alerts/confirm.html", {transition: "pop",reverse: false,changeHash: false});	
        ///</code>
        /// </example>
        public void changePage(object to, ChangePageOptions options)
        {
        }
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">
        /// Absolute or relative URL. ("about/us.html")
        /// </param>
        /// <param name="options">
        /// </param>
        public void changePage(JsString to, ChangePageOptions options)
        {
        }
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">
        /// Absolute or relative URL. ("about/us.html")
        /// </param>
        public void changePage(JsString to)
        {
        }
        /// <summary>
        /// Programmatically change from one page to another. 
        /// This method is used internally for the page loading and transitioning that occurs as a result of clicking a link or submitting a form, when those features are enabled.
        /// </summary>
        /// <param name="to">Absolute or relative URL. ("about/us.html")</param>
        public void changePage(object to)
        {
        }

        //TODO: can't find arguments in doc
        public void removeData()
        {
        }

        /// <summary>
        /// Load an external page, enhance its content, and insert it into the DOM. This method is called internally by the changePage() function when its first argument is a URL. This function does not affect the current active page so it can be used to load pages in the background. The function returns a deferred promise object that gets resolved after the page has been enhanced and inserted into the document.
        /// </summary>
        /// <param name="url">
        ///  (string or object, required) A relative or absolute URL.
        ///  </param>
        /// <param name="options">
        /// (object, optional)
        /// </param>
        ///  /// <example>
        /// load the "about us" page into the DOM.
        /// <code>
        /// $.mobile.loadPage( "about/us.html" );
        /// </code>
        /// load a "search results" page, using data from a form with an ID of "search""
        /// <code>
        /// $.mobile.loadPage( "searchresults.php", {type: "post", data: $("form#search").serialize()});
        /// </code>
        /// </example>
        public void loadPage(object url, LoadPageOptions options)
        {
        }

        public FixedToolbarsOptions fixedToolbars { get; set; }

        /// <summary>
        /// Show the page loading message, which is configurable via $.mobile.loadingMessage.
        /// </summary>
        /// <example>
        /// cue the page loader
        /// <code>
        /// $.mobile.showPageLoadingMsg();
        /// </code>
        /// </example>
        public void showPageLoadingMsg()
        {
        }
        /// <summary>
        /// Show the page loading message, which is configurable via $.mobile.loadingMessage.
        /// </summary>
        /// <param name="theme">(string, default: "a") The theme swatch for the message.</param>
        /// <param name="msgText"> (string, default: "loading") The text of the message.</param>
        /// <param name="textonly">(boolean, default: false) If true, the "spinner" image will be hidden when the message is shown.</param>
        public void showPageLoadingMsg(JsString theme, JsString msgText, bool textonly)
        {
        }

        /// <summary>
        /// Hide the page loading message, which is configurable via $.mobile.loadingMessage.
        /// </summary>
        /// <example>
        /// cue the page loader
        /// <code>
        /// $.mobile.hidePageLoadingMsg();
        /// </code>
        /// </example>
        public void hidePageLoadingMsg()
        {
        }

        public PathOptions path { get; set; }

        /// <summary>
        /// Utilities for working with generated base element. TODO: document as public API is finalized
        /// </summary>
        /// <param name="prms"></param>
        /// <returns></returns>
        public object @base(params object[] prms) { return null; }
        //TODO: $.mobile.base (methods, properties) (?)

        /// <summary>
        /// Scroll to a particular Y position without triggering scroll event listeners.
        /// </summary>
        /// <param name="yPos">
        /// (number, defaults to 0). Pass any number to scroll to that Y location.
        /// </param>
        /// <example>
        /// scroll to Y 100px
        /// <code>
        /// $.mobile.silentScroll(100);
        /// </code>
        /// </example>
        public void silentScroll(JsNumber yPos)
        {
        }
        /// <summary>
        /// Add width breakpoints to the min/max width classes that are added to the HTML element.
        /// </summary>
        /// <param name="values">
        /// (number or array). Pass any number or array of numbers to add to the resolution classes. Read more about this feature here: Orientation &amp;resolution targeting.
        /// </param>
        /// <example>
        /// add a 400px breakpoint
        /// <code>
        /// $.mobile.addResolutionBreakpoints(400);
        /// </code>
        /// add 2 more breakpoints
        /// <code>
        /// $.mobile.addResolutionBreakpoints([600,800]);
        /// </code>
        /// </example>
        public void addResolutionBreakpoints(JsNumber values)
        {
        }
        /// <summary>
        /// Add width breakpoints to the min/max width classes that are added to the HTML element.
        /// </summary>
        /// <param name="values">
        /// (number or array). Pass any number or array of numbers to add to the resolution classes. Read more about this feature here: Orientation &amp;resolution targeting.
        /// </param>
        /// <example>
        /// add a 400px breakpoint
        /// <code>
        /// $.mobile.addResolutionBreakpoints(400);
        /// </code>
        /// add 2 more breakpoints
        /// <code>
        /// $.mobile.addResolutionBreakpoints([600,800]);
        /// </code>
        /// </example>
        public void addResolutionBreakpoints(JsArray values)
        {
        }

        /// <summary>
        /// Reference to the page currently in view.
        /// </summary>
        public JsString activePage { get; set; } // TODO: ask dan-el.
    }

    [JsType(JsMode.Prototype, Name = "$.fn")]
    public class jQueryFn
    {
        /// <summary>
        /// Returns value at named data store for the element, as set by jQuery.data(element, name, value), or the full data store for the element.
        /// When working with jQuery Mobile, jqmData and jqmRemoveData should be used in place of jQuery core's data and removeData methods (note that this includes $.fn.data, $.fn.removeData, and the $.data, $.removeData, and $.hasData utilities), as they automatically incorporate getting and setting of namespaced data attributes (even if no namespace is currently in use).
        /// </summary>
        /// <example>
        /// When finding elements by their jQuery Mobile data attribute, please use the custom selector :jqmData(), as it automatically incorporates namespaced data attributes into the lookup when they are in use
        /// <code>
        /// instead of calling $("div[data-role='page']"), you should use $("div:jqmData(role='page')"), which internally maps to $("div[data-"+ $.mobile.ns +"role='page']") without forcing you to concatenate a namespace into your selectors manually.
        /// </code>
        /// </example>
        public static JsObject jqmData(HtmlElement element) { return null; }
        /// <summary>
        /// Returns value at named data store for the element, as set by jQuery.data(element, name, value), or the full data store for the element.
        /// When working with jQuery Mobile, jqmData and jqmRemoveData should be used in place of jQuery core's data and removeData methods (note that this includes $.fn.data, $.fn.removeData, and the $.data, $.removeData, and $.hasData utilities), as they automatically incorporate getting and setting of namespaced data attributes (even if no namespace is currently in use).
        /// </summary>
        public static JsObject jqmdata(HtmlElement element, JsString key) { return null; }
        /// <summary>
        /// Store arbitrary data associated with the specified element.
        /// When working with jQuery Mobile, jqmData and jqmRemoveData should be used in place of jQuery core's data and removeData methods (note that this includes $.fn.data, $.fn.removeData, and the $.data, $.removeData, and $.hasData utilities), as they automatically incorporate getting and setting of namespaced data attributes (even if no namespace is currently in use).
        /// </summary>
        public static jQuery jqmdata(HtmlElement element, JsString key, JsObject value) { return null; }
        /// <summary>
        /// When working with jQuery Mobile, jqmData and jqmRemoveData should be used in place of jQuery core's data and removeData methods (note that this includes $.fn.data, $.fn.removeData, and the $.data, $.removeData, and $.hasData utilities), as they automatically incorporate getting and setting of namespaced data attributes (even if no namespace is currently in use).
        /// </summary>
        public static jQuery jqmRemoveData(HtmlElement element) { return null; }
        /// <summary>
        /// Remove a previously-stored piece of data.
        /// When working with jQuery Mobile, jqmData and jqmRemoveData should be used in place of jQuery core's data and removeData methods (note that this includes $.fn.data, $.fn.removeData, and the $.data, $.removeData, and $.hasData utilities), as they automatically incorporate getting and setting of namespaced data attributes (even if no namespace is currently in use).
        /// </summary>
        public static jQuery jqmremoveData(HtmlElement element, JsString name) { return null; }

        /// <summary>
        /// For users that wish to respect data-enhance=false parent elements during manual enhancement or custom plugin authoring jQuery Mobile provides the $.fn.jqmEnhanceable filter method.
        /// · Settings:
        /// If, and only if, $.mobile.ignoreContentEnabled is set to true, this method will traverse the parent nodes for each DOM element in the jQuery object and where it finds a data-enhance=false parent the child will be removed from the set.
        /// · Warning:
        /// The operation of traversing all parent elements can be expensive for even small jQuery object sets.
        /// </summary>
        /// <returns></returns>
        public static jQuery jqmEnhanceable() { return null; }
        //TODO: can't understand the Arguments.

        /// <summary>
        /// For users that wish to respect data-ajax=false parent elements during custom form and link binding jQuery Mobile provides the $.fn.jqmHijackable filter method.
        /// · Settings:
        /// If, and only if, $.mobile.ignoreContentEnabled is set to true, this method will traverse the parent nodes for each DOM element in the jQuery object and where it finds a data-ajax=false parent the child form or link will be removed from the set.
        /// · Warning:
        /// The operation of traversing all parent elements can be expensive for even small jQuery object sets.        /// </summary>
        /// <returns></returns>
        public static jQuery jqmHijackable() { return null; }
        //TODO: can't understand the Arguments.

        //TODO: $.fn.jqmEnhanceable(), $.fn.jqmHijackable()
        // TODO:public static jQuery jqmHasData()
    }

    [JsType(JsMode.Json)]
    public partial class FixedToolbarsOptions
    {
        /// <summary>
        /// Utility method for displaying the fixed header and/or footer of the current active page within the viewport.
        /// Note that fixed headers/footers are never really hidden.
        /// Toggling the show/hide state of a toolbar is really toggling whether or not they are inline within the page content,
        /// or displayed within the viewport as if they were fixed.
        /// </summary>
        /// <param name="immediately">immediately (boolean, optional) If true, any fixed header or footer for the current active page is displayed immediately within the viewport.
        /// If false or unspecified, the fixed header/footer will fade-in after a 100 millisecond delay.
        /// Note that other events such as a document resize or scroll event can result in an additional delay before the start of the header/footer display animation.</param>
        public void show(bool immediately) { }
        /// <summary>
        /// Utility method for displaying the fixed header and/or footer of the current active page within the viewport.
        /// Note that fixed headers/footers are never really hidden.
        /// Toggling the show/hide state of a toolbar is really toggling whether or not they are inline within the page content,
        /// or displayed within the viewport as if they were fixed.
        /// </summary>
        public void show() { }

        /// <summary>
        /// Utility method for hiding the fixed header and/or footer of the current active page.
        /// </summary>
        /// <param name="immediately">immediately (boolean, optional) If true, any fixed header or footer for the current active page is immediately placed inline (back in flow)
        /// with the page content, which means it will scroll along with the content and will only be visible when viewing the top or bottom of the page within the viewport.
        /// If false or unspecified, the fixed header/footer will fade-out after a 100 millisecond delay.
        /// Note that other events such as a document resize or scroll event can result in the header/footer being immediately hidden.</param>
        public void hide(bool immediately) { }
        /// <summary>
        /// Utility method for hiding the fixed header and/or footer of the current active page.
        /// </summary>
        public void hide() { }

    }

    [JsType(JsMode.Json)]
    public partial class PathOptions
    {
        /// <summary>
        /// Utility method for parsing a URL and its relative variants into an object that makes accessing the components of the URL easy. When parsing relative variants, the resulting object will contain empty string values for missing components (like protocol, host, etc). Also, when parsing URLs that have no authority, such as tel: urls, the pathname property of the object will contain the data after the protocol/scheme colon.
        /// </summary>
        /// <param name="url">
        /// (string, required) A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns an object that contains the various components of the URL as strings. The properties on the object mimic the browser's location object
        /// </returns>
        /// <example>
        /// Parsing the Url below results an object that is returned with the
        /// following properties:
        /// <code>
        /// obj.href:         http://jblas:password@mycompany.com:8080/mail/inbox?msg&amp;1234&amp;type&amp;unread#msg-content
        ///  obj.hrefNoHash:   http://jblas:password@mycompany.com:8080/mail/inbox?msg&amp;1234&amp;type&amp;unread
        ///  obj.hrefNoSearch: http://jblas:password@mycompany.com:8080/mail/inbox
        ///  obj.domain:       http://jblas:password@mycompany.com:8080
        ///  obj.protocol:     http:
        ///  obj.authority:    jblas:password@mycompany.com:8080
        ///  obj.username:     jblas
        ///  obj.password:     password
        ///  obj.host:         mycompany.com:8080
        ///  obj.hostname:     mycompany.com
        ///  obj.port:         8080
        ///  obj.pathname:     /mail/inbox
        ///  obj.directory:    /mail/
        ///  obj.filename:     inbox
        ///  obj.search:       ?msg=1234&amp;type=unread
        ///  obj.hash:         #msg-content
        ///  var obj = $.mobile.path.parseUrl("http://jblas:password@mycompany.com:8080/mail/inbox?msg=1234");
        /// </code>
        /// </example>
        public ReturnValueParseUrl parseUrl(JsString url) { return null; } //TODO: ask dan-el.
        /// <summary>
        /// Utility method for converting a relative file or directory path into an absolute path.
        /// </summary>
        /// <param name="relPath">
        /// (string, required) A relative file or directory path.
        /// </param>
        /// <param name="absPath">
        /// (string, required) An absolute file or relative path to resolve against.
        /// </param>
        /// <returns>
        /// This function returns a string that is an absolute version of the relative path passed in.
        /// </returns>
        /// <example>
        /// Returns: /a/b/c/file.html
        /// <code>
        /// var absPath = $.mobile.path.makePathAbsolute("file.html", "/a/b/c/bar.html");
        /// </code>
        /// Returns: /a/foo/file.html
        /// <code>
        /// var absPath = $.mobile.path.makePathAbsolute("../../foo/file.html", "/a/b/c/bar.html");
        /// </code>
        /// </example>
        public JsString makePathAbsolute(JsString relPath, JsString absPath) { return null; }
        /// <summary>
        /// Utility method for converting a relative URL to an absolute URL.
        /// </summary>
        /// <param name="relUrl">
        /// (string, required) A relative URL.
        /// </param>
        /// <param name="absUrl">
        /// (string, required) An absolute URL to resolve against.
        /// </param>
        /// <returns>
        /// This function returns a string that is an absolute version of the relative URL passed in.
        /// </returns>
        /// <example>
        /// Returns: http://foo.com/a/b/c/file.html
        /// <code>
        /// var absUrl = $.mobile.path.makeUrlAbsolute("file.html", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: http://foo.com/a/foo/file.html
        /// <code>
        /// var absUrl = $.mobile.path.makeUrlAbsolute("../../foo/file.html", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: http://foo.com/bar/file.html
        /// <code>
        /// var absUrl = $.mobile.path.makeUrlAbsolute("//foo.com/bar/file.html", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: http://foo.com/a/b/c/test.html?a=amp;amp;1&amp;b=amp;2
        /// <code>
        /// var absUrl = $.mobile.path.makeUrlAbsolute("?a&amp;1&amp;b&amp;2", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: http://foo.com/a/b/c/test.html#bar
        /// <code>
        /// var absUrl = $.mobile.path.makeUrlAbsolute("#bar", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// </example>
        public JsString makeUrlAbsolute(JsString relUrl, JsString absUrl) { return null; }
        /// <summary>
        /// Utility method for comparing the domain of 2 URLs.
        /// </summary>
        /// <example>
        /// Returns: true
        /// <code>
        /// var same = $.mobile.path.isSameDomain("http://foo.com/a/file.html", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var same = $.mobile.path.isSameDomain("file://foo.com/a/file.html", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var same = $.mobile.path.isSameDomain("https://foo.com/a/file.html", "http://foo.com/a/b/c/test.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var same = $.mobile.path.isSameDomain("http://foo.com/a/file.html", "http://bar.com/a/b/c/test.html");
        /// </code>
        /// </example>
        /// <param name="url1">
        /// (string, required) A relative URL.
        /// </param>
        /// <param name="url2">
        /// (string, required) An absolute URL to resolve against.
        /// </param>
        /// <returns>
        /// This function returns a boolean true if the domains match, false if they don't.
        /// </returns>
        public bool isSameDomain(JsString url1, JsString url2) { return false; }
        /// <summary>
        /// Utility method for determining if a URL is a relative variant.
        /// </summary>
        /// <param name="url">
        /// (string, required) A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns a boolean true if the URL is relative, false if it is absolute.
        /// </returns>
        /// <example>
        /// Returns: false
        /// <code>
        /// var isRel = $.mobile.path.isRelativeUrl("http://foo.com/a/file.html");
        /// </code>
        /// Returns: true
        /// <code>
        /// var isRel = $.mobile.path.isRelativeUrl("//foo.com/a/file.html");
        /// </code>
        /// Returns: true
        /// <code>
        /// var isRel = $.mobile.path.isRelativeUrl("/a/file.html");
        /// </code>
        /// Returns: true
        /// <code>
        /// var isRel = $.mobile.path.isRelativeUrl("file.html");
        /// </code>
        /// Returns: true
        /// <code>
        /// var isRel = $.mobile.path.isRelativeUrl("?a&amp;1&amp;b&amp;2");
        /// </code>
        /// Returns: true
        /// <code>
        /// var isRel = $.mobile.path.isRelativeUrl("#foo");
        /// </code>
        /// </example>
        public bool isRelativeUrl(JsString url) { return false; }
        /// <summary>
        /// Utility method for determining if a URL is absolute.
        /// </summary>
        /// <param name="url">
        /// (string, required) A relative or absolute URL.
        /// </param>
        /// <returns>
        /// This function returns a boolean true if the URL is absolute, false if it is absolute.
        /// </returns>
        /// <example>
        /// Returns: true
        /// <code>
        /// var isAbs = $.mobile.path.isAbsoluteUrl("http://foo.com/a/file.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var isAbs = $.mobile.path.isAbsoluteUrl("//foo.com/a/file.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var isAbs = $.mobile.path.isAbsoluteUrl("/a/file.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var isAbs = $.mobile.path.isAbsoluteUrl("file.html");
        /// </code>
        /// Returns: false
        /// <code>
        /// var isAbs = $.mobile.path.isAbsoluteUrl("?a&amp;1&amp;b&amp;2");
        /// </code>
        /// Returns: false
        /// <code>
        /// var isAbs = $.mobile.path.isAbsoluteUrl("#foo");
        /// </code>
        /// </example>
        public bool isAbsoluteUrl(JsString url) { return false; }

        /// <summary>
        /// Utility method for determining the directory portion of an URL. If the URL has no trailing slash, the last component of the URL is considered to be a file.
        /// </summary>
        /// <param name="url">(string, required) A relative or absolute URL.</param>
        /// <returns>This function returns the directory portion of a given URL.</returns>
        public object get(JsString url) { return null; }
        //TODO: return value?
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TouchEvents
    {
        /// <summary>
        /// Triggers after a quick, complete touch event.
        /// </summary>
        tap,
        /// <summary>
        ///Triggers after a held complete touch event (close to one second).
        /// </summary>
        taphold,
        /// <summary>
        /// Triggers when a horizontal drag of 30px or more (and less than 20px vertically) occurs within 1 second duration but these can be configured:
        /// <list type="bullet">
        /// <item>scrollSupressionThreshold (default: 10px) – More than this horizontal displacement, and we will suppress scrolling</item>
        /// <item>durationThreshold (default: 1000ms) – More time than this, and it isn’t a swipe</item>
        /// <item>horizontalDistanceThreshold (default: 30px) – Swipe horizontal displacement must be more than this.</item>
        /// <item>verticalDistanceThreshold (default: 75px) – Swipe vertical displacement must be less than this.</item>
        /// </list>
        /// </summary>
        swipe,
        /// <summary>
        /// Triggers when a swipe event occurred moving in the left direction.
        /// </summary>
        swipeleft,
        /// <summary>
        /// Triggers when a swipe event occurred moving in the right direction.
        /// </summary>
        swiperight,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum OrientationChangeEvent
    {
        /// <summary>
        /// Triggers when a device orientation changes (by turning it vertically or horizontally). When bound to this event, your callback function can leverage a second argument, which contains an orientation property equal to either "portrait" or "landscape". These values are also added as classes to the HTML element, allowing you to leverage them in your CSS selectors. Note that we currently bind to the resize event when orientationChange is not natively supported.
        /// </summary>
        orientationchange,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ScrollEvents
    {
        /// <summary>
        /// Triggers when a scroll begins. Note that iOS devices freeze DOM manipulation during scroll, queuing them to apply when the scroll finishes. We're currently investigating ways to allow DOM manipulations to apply before a scroll starts.
        /// </summary>
        scrollstart,
        /// <summary>
        /// Triggers when a scroll finishes.
        /// </summary>
        scrollstop,
    }

    /// <summary>
    /// Whenever a page is shown or hidden in jQuery Mobile, two events are triggered on that page. The events triggered depend on whether that page is being shown or hidden, so when a page transition occurs, there are actually 4 events triggered: 2 for each page.
    /// Note that all four of these events expose a reference to either the next page (nextPage) or previous page (prevPage), depending on whether the page is being shown or hidden, and whether that next or previous page exists (the first ever page shown does not have a previous page to reference, but an empty jQuery object is provided just the same). You can access this reference via the second argument of a bound callback function.
    /// </summary>
    /// <example>
    /// <code>
    /// $('div').live('pageshow',function(event, ui){alert('This page was just hidden: '+ ui.prevPage);});
    /// $('div').live('pagehide',function(event, ui){alert('This page was just shown: '+ ui.nextPage);});
    /// </code>
    /// </example>
    /// <remarks>
    /// Also, for these handlers to be invoked during the initial page load, you must bind them before jQuery Mobile executes. This can be done in the mobileinit handler, as described on the global config page.
    /// </remarks>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PageShowHideEvents
    {
        /// <summary>
        /// Triggered on the page being shown, before its transition begins.
        /// </summary>
        pagebeforeshow,
        /// <summary>
        /// Triggered on the page being hidden, before its transition begins.
        /// </summary>
        pagebeforehide,
        /// <summary>
        /// Triggered on the page being shown, after its transition completes.
        /// </summary>
        pageshow,
        /// <summary>
        /// Triggered on the page being hidden, after its transition completes.
        /// </summary>
        pagehide
    }

    /// <summary>
    /// Internally, jQuery Mobile auto-initializes plugins based on the markup conventions found in a given "page". For example, an input element with a type of range will automatically generate a custom slider control.
    ///This auto-initialization is controlled by the "page" plugin, which dispatches events before and after it executes, allowing you to manipulate a page either pre-or-post initialization, or even provide your own intialization behavior and prevent the auto-initializations from occuring. Note that these events will only fire once per "page", as opposed to the show/hide events, which fire every time a page is shown and hidden.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PageInitializationEvents
    {
        /// <summary>
        /// Triggered on the page being initialized, before initialization occurs.
        /// </summary>
        /// <example>
        /// <code>
        /// $('#aboutPage').live('pagebeforecreate',function(event){alert('This page was just inserted into the dom!');});
        /// <remarks>
        /// Note that by binding to pagebeforecreate and returning false, you can prevent the page plugin from making its manipulations.
        /// </remarks>
        /// </code>
        /// <code>
        /// $('#aboutPage').live('pagebeforecreate',function(event){//run your own enhancement scripting here...return false;});
        /// </code>
        /// </example>
        pagebeforecreate,
        /// <summary>
        /// Triggered on the page being initialized, after initialization occurs. We recommend binding to this event instead of DOM ready() because this will work regardless of whether the page is loaded directly or if the content is pulled into another page as part of the Ajax navigation system.
        /// </summary>
        /// <example>
        /// <code>
        /// $('#aboutPage').live('pagecreate',function(event){alert('This page was just enhanced by jQuery Mobile!');});
        /// </code>
        /// </example>
        pagecreate,
    }

    /// <summary>
    /// We provide a set of "virtual" click events that normalize mouse and touch events. This allows the developer to register listeners for the basic mouse events, such as mousedown, mousemove, mouseup, and click, and the plugin will take care of registering the correct listeners behind the scenes to invoke the listener at the fastest possible time for that device. This still retains the order of event firing in the traditional mouse environment, should multiple handlers be registered on the same element for different events.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum VirtualMouseEvents
    {
        /// <summary>
        /// Normalized event for handling touch or mouse mouseover events
        /// </summary>
        vmouseover,
        /// <summary>
        /// Normalized event for handling touch or mouse mousedown events 
        /// </summary>
        vmousedown,
        /// <summary>
        /// Normalized event for handling touch or mouse mousemove events
        /// </summary>
        vmousemove,
        /// <summary>
        /// Normalized event for handling touch or mouse mouseup events 
        /// </summary>
        vmouseup,
        /// <summary>
        /// Normalized event for handling touch or mouse click events
        /// </summary>
        vclick,
        /// <summary>
        /// Normalized event for handling touch or mouse mousecancel events
        /// </summary>
        vmousecancel,
        //TODO: AnimationEvents- jQuery Mobile exposes the animationComplete plugin, which you can utilize after adding or removing a class that applies a CSS transition. 
    }

    [JsType(JsMode.Prototype)]
    public class jQuery
    {
        public void live(JsString name, JsAction<Event, UI> handler)
        {
        }
        //TODOpublic void live(LiveEvent name, JsAction<Event, UI> handler)
        //{
        //}
    }

    public class Event
    {
    }

    public class UI
    {
    }

    [JsType(JsMode.Json)]
    public partial class ChangePageOptions
    {
        /// <summary>
        /// default:	$.mobile.defaultPageTransition)	The transition to use when showing the page.
        /// </summary>
        public JsString transition { get; set; }
        /// <summary>
        /// default:	(boolean, default:	false) Decides what direction the transition will run when showing the page.
        /// </summary>
        public bool reverse { get; set; }
        /// <summary>
        /// (boolean,	default:	true) Decides if the hash in the location bar should be updated.
        /// </summary>
        public bool changeHash { get; set; }
        /// <summary>
        /// (JsString,	default:	undefined) The data-role value to be used when displaying the page. By default this is undefined which means rely on the value of the @data-role attribute defined on the element.
        /// </summary>
        public JsString role { get; set; }
        /// <summary>
        /// (jQuery collection,	default:	$.mobile.pageContainer) Specifies the element that should contain the page.
        /// </summary>
        public jQuery pageContainer { get; set; }
        /// <summary>
        /// (JsString, default: "get") Specifies the method ("get" or "post") to use when making a page request.
        /// <list type=" bullet">
        /// Used only when the 'to' argument of changePage() is a URL.
        /// </list>
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// (object or	JsString,	default: undefined) The data to send with an Ajax page request.
        /// <list type="bullet">
        /// Used only when the 'to' argument of changePage() is a URL. 
        /// </list>
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// (object or	JsString,	default: undefined) The data to send with an Ajax page request.
        /// <list type="bullet">
        /// Used only when the 'to' argument of changePage() is a URL. 
        /// </list>
        /// </summary>
        [JsProperty(Name = "data")]
        public JsString dataString { get; set; }
        /// <summary>
        /// (boolean, default: false) Forces a reload of a page, even if it is already in the DOM of the page container.
        /// <list type="bullet">
        ///Used only when the 'to' argument of changePage() is a URL. 
        /// </list>
        /// </summary>
        public bool reloadPage { get; set; }

        /// <summary>
        /// default: false.
        /// By default, changePage() ignores requests to change to the current active page.
        /// Setting this option to true, allows the request to execute.
        /// Developers should note that some of the page transitions assume that the fromPage and toPage of a changePage request are different,
        /// so they may not animate as expected. Developers are responsible for either providing a proper transition, or turning it off for this specific case.
        /// </summary>
        public bool allowSamePageTransition { get; set; }

        /// <summary>
        /// default: undefined
        /// The URL to use when updating the browser location upon changePage completion.
        /// If not specified, the value of the data-url attribute of the page element is used.
        /// </summary>
        public JsString dataUrl { get; set; }

        /// <summary>
        /// default: true
        /// Decides whether or not to show the loading message when loading external pages.
        /// </summary>
        public bool showLoadMsg { get; set; }
    }

    /// <summary>
    /// Load an external page, enhance its content, and insert it into the DOM. This method is called internally by the changePage() function when its first argument is a URL. This function does not affect the current active page so it can be used to load pages in the background. The function returns a deferred promise object that gets resolved after the page has been enhanced and inserted into the document.
    /// </summary>
    [JsType(JsMode.Json)]
    public partial class LoadPageOptions
    {
        /// <summary>
        /// (string,	default:	undefined) The data-role value to be used when displaying the page. By default this is undefined which means rely on the value of the @data-role attribute defined on the element.
        /// </summary>
        public JsString role { get; set; }
        /// <summary>
        /// (jQuery collection,	default:	$.mobile.pageContainer) Specifies the element that should contain the page after it is loaded.
        /// </summary>
        public jQuery pageContainer { get; set; }
        /// <summary>
        ///  (string, default: "get") Specifies the method ("get" or "post") to use when making a page request.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// (object or	string,	default: undefined) The data to send with an Ajax page request.
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// (object or	string,	default: undefined) The data to send with an Ajax page request.
        /// </summary>
        [JsProperty(Name = "data")]
        public JsString dataString { get; set; }
        /// <summary>
        /// (boolean, default: false) Forces a reload of a page, even if it is already in the DOM of the page container.
        /// </summary>
        public bool reloadPage { get; set; }
        /// <summary>
        /// (number (in ms), default: 50) Forced delay before the loading message is shown. This is meant to allow time for a page that has already been visited to be fetched from cache without a loading message.
        /// </summary>
        public JsNumber loadMsgDelay { get; set; }
    }

    /// <summary>
    /// The following defaults are configurable via the $.mobile object:
    /// </summary>
    [JsType(JsMode.Prototype)]
    public class MobileOptions
    {
        /// <summary>
        /// default: ""
        /// The namespace used in data- attributes, for example, data-role. Can be set to anything, including a blank string which is the default. When using, it's clearest if you include a trailing dash, such as "mynamespace-" which maps to data-mynamespace-foo="...".
        /// NOTE: if you're using data- namespacing, you'll need to manually update/override one selector in the theme CSS. The following data selectors should incorporate the namespace you're using:
        /// </summary>
        /// <example>
        /// This example shows how to....
        /// <code>
        /// .ui-mobile [data-mynamespace-role=page], .ui-mobile [data-mynamespace-role=dialog], .ui-page { ...
        /// </code>
        /// </example>
        public JsString ns { get; set; }
        /// <summary>
        ///default: true
        ///When the DOM is ready, the framework should automatically call $.mobile.initializePage. If false, page will not initialize, and will be visually hidden until until $.mobile.initializePage is manually called.
        /// </summary>
        public bool autoInitializePage { get; set; }
        /// <summary>
        /// default: "ui-page"
        ///The url parameter used for referencing widget-generated sub-pages (such as those generated by nested listviews). Translates to to example.html&amp;ui-page&amp;subpageIdentifier. The hash segment before &amp;ui-page&amp; is used by the framework for making an Ajax request to the URL where the sub-page exists.
        /// </summary>
        public JsString subPageUrlKey { get; set; }
        /// <summary>
        /// default: "ui-page-active"
        /// The class assigned to page currently in view, and during transitions
        /// activeBtnClass string, default: "ui-page-active"
        /// The class used for "active" button state, from CSS framework.
        /// </summary>
        public JsString activePageClass { get; set; }
        /// <summary>
        /// default: "ui-page-active"
        /// The class used for "active" button state, from CSS framework.
        /// </summary>
        public JsString activeBtnClass { get; set; }
        /// <summary>
        /// default: true
        /// jQuery Mobile will automatically handle link clicks and form submissions through Ajax, when possible. If false, url hash listening will be disabled as well, and urls will load as regular http requests.
        /// </summary>
        public bool ajaxEnabled { get; set; }
        /// <summary>
        /// default: true
        /// jQuery Mobile will automatically listen and handle changes to the location.hash. Disabling this will prevent jQuery Mobile from handling hash changes, which allows you to handle them yourself, or simply to use simple deep-links within a document that scroll to a particular ID.
        /// </summary>
        public bool hashListeningEnabled { get; set; }
        /// <summary>
        /// default: 'slide'
        /// Set the default transition for page changes that use Ajax. Set to 'none' for no transitions by default.
        /// </summary>
        public JsString defaultPageTransition { get; set; }
        /// <summary>
        ///  default: 'pop'
        ///  Set the default transition for dialog changes that use Ajax. Set to 'none' for no transitions by default.
        /// </summary>
        public JsString defaultDialogTransition { get; set; }
        /// <summary>
        /// string, default: 150
        /// Minimum scroll distance that will be remembered when returning to a page.
        /// </summary>
        public JsString minScrollBack { get; set; }
        /// <summary>
        /// default: "loading"
        /// Set the text that appears when a page is loading. If set to false, the message will not appear at all.
        /// </summary>
        public JsString loadingMessage { get; set; }
        /// <summary>
        /// default: "Error Loading Page"
        /// Set the text that appears when a page fails to load through Ajax.
        /// </summary>
        public JsString pageLoadErrorMessage { get; set; }
        /// <summary>
        ///  default: a function returning the value of $.support.mediaquery
        ///  Any support conditions that must be met in order to proceed.
        /// </summary>
        public JsFunc<bool> gradeA { get; set; }

        /// <summary>
        /// default: false
        /// When jQuery Mobile attempts to load an external page, the request runs through $.mobile.loadPage().
        /// This will only allow cross-domain requests if $.mobile.allowCrossDomainPages is set to true.
        /// Because the jQuery Mobile framework tracks what page is being viewed within the browser's location hash,
        /// it is possible for a cross-site scripting (XSS) attack to occur if the XSS code in question can manipulate the hash and set it to a cross-domain URL of its choice.
        /// This is the main reason that the default setting for $.mobile.allowCrossDomainPages is set to false.
        /// In PhoneGap apps that must "phone home" by loading assets off a remote server, both the $.support.cors AND $.mobile.allowCrossDomainPages must be set to true.
        /// </summary>
        public bool allowCrossDomainPages { get; set; }

        public ButtonMarkupOptions buttonMarkup { get; set; }

        /// <summary>
        /// default: false
        /// Warning: Setting this property to true will cause performance degradation on enhancement.
        /// Once set, all automatic enhancements made by the framework to each enhanceable element of the user's markup will first check for a data-enhance=false parent node.
        /// If one is found the markup will be ignored.
        /// This setting and the accompanying data attribute provide a mechanism through which users can prevent enhancement over large sections of markup.
        /// </summary>
        public bool ignoreContentEnabled { get; set; }

        /// <summary>
        ///  default: true
        ///  jQuery Mobile will automatically bind the clicks on anchor tags in your document.
        ///  Setting this options to false will prevent all anchor click handling including the addition of active button state and alternate link bluring.
        ///  This should only be used when attempting to delegate the click management to another library or custom code.
        /// </summary>
        public bool linkBindingEnabled { get; set; }

        /// <summary>
        /// default: false
        /// Whether the text should be visible when a loading message is shown. The text is always visible for loading errors.
        /// </summary>
        public bool loadingMessageTextVisible { get; set; }

        /// <summary>
        /// default: "a"
        /// The theme that the loading message box uses when text is visible.
        /// </summary>
        public JsString loadingMessageTheme { get; set; }

        /// <summary>
        ///  default: "e"
        ///  Set the theme that the error message box uses.
        /// </summary>
        public JsString pageLoadErrorMessageTheme { get; set; }

        /// <summary>
        ///  default: true
        ///  Enhancement to use history.replaceState in supported browsers, to convert the hash-based Ajax URL into the full document path.
        ///  Note that we recommend disabling this feature if Ajax is disabled or if extensive use of external links are used.
        /// </summary>
        public bool pushStateEnabled { get; set; }

        /// <summary>
        /// Deprecated in 1.1.0
        /// Enable smoother page transitions and true fixed toolbars in devices that support both the overflow: and overflow-scrolling: touch; CSS properties.
        /// </summary>
        public bool touchOverflowEnabled { get; set; }

    }

    [JsType(JsMode.Prototype)]
    public class ButtonMarkupOptions
    {
        /// <summary>
        /// default: 200
        /// Set the delay for touch devices to add the hover and down classes on touch interactions for buttons throughout the framework.
        /// Reducing the delay here results in a more responsive feeling ui, but will often result in the downstate being applied during page scrolling.
        /// </summary>
        public JsNumber hoverDelay { get; set; }
    }

    /// <summary>
    /// This function returns an object that contains the various components of the URL as strings. The properties on the object mimic the browser's location object:
    /// </summary>
    [JsType(JsMode.Json)]
    public partial class ReturnValueParseUrl
    {
        /// <summary>
        /// The fragment conponent of the URL, including the leading '#' character.
        /// </summary>
        public JsString hash { get; set; }
        /// <summary>
        /// The host and port number of the URL.
        /// </summary>
        public JsString host { get; set; }
        /// <summary>
        /// The name of the host within the URL.
        /// </summary>
        public JsString hostname { get; set; }
        /// <summary>
        /// The original URL that was parsed.
        /// </summary>
        public JsString href { get; set; }
        /// <summary>
        /// The path of the file or directory referenced by the URL.
        /// </summary>
        public JsString pathname { get; set; }
        /// <summary>
        /// The port specified within the URL. Most URLs rely on the default port for the protocol used, so this may be an empty string most of the time.
        /// </summary>
        public JsString port { get; set; }
        /// <summary>
        /// The protocol for the URL including the trailing ':' character.
        /// </summary>
        public JsString protocol { get; set; }
        /// <summary>
        /// The query component of the URL including the leading '?' character.
        /// But it also contains additional properties that provide access to additional components as well as some common forms of the URL developers access:
        /// </summary>
        public JsString search { get; set; }
        /// <summary>
        /// The username, password, and host components of the URL
        /// </summary>
        public JsString authority { get; set; }
        /// <summary>
        /// The directory component of the pathname, minus any filename.
        /// </summary>
        public JsString directory { get; set; }
        /// <summary>
        /// The protocol and authority components of the URL.
        /// </summary>
        public JsString domain { get; set; }
        /// <summary>
        /// The filename within the pathname component, minus the directory.
        /// </summary>
        public JsString filename { get; set; }
        /// <summary>
        /// The original URL minus the fragment (hash) components.
        /// </summary>
        public JsString hrefNoHash { get; set; }
        /// <summary>
        /// The original URL minus the query (search) and fragment (hash) components.
        /// </summary>
        public JsString hrefNoSearch { get; set; }
        /// <summary>
        /// The password contained within the authority component.
        /// </summary>
        public JsString password { get; set; }
        /// <summary>
        /// The username contained within the authority component.
        /// </summary>
        public JsString username { get; set; }








    }
}
