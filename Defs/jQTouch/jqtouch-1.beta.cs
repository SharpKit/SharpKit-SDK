using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.jQuery.jQTouch
{
    [JsType(JsMode.Prototype, Name = "$.jQTouch", Export=false)]
    public class jQTouch
    {
        public jQTouch(jQTouchSettings settings)
        {
        }
    }

    public static class JQTouch
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery jQTouch(this jQuery query)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery jQTouch(this jQuery query, JsObject options)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery jQTouch(this jQuery query, string methodName, params string[] optionName)
        {
            throw new NotImplementedException();
        }

        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery goBack(this jQuery query, object to)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery goTo(this jQuery query, object toPage, object animation)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery getOrientation(this jQuery query)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery addAnimation(this jQuery query, object animation)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeDelegates = true)]
        public static jQuery submitForm(this jQuery query, object e, Action callback)
        {
            throw new NotImplementedException();
        }

        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeDelegates = true)]
        public static void unselect(this jQueryFn jqfn, object obj)
        {
            throw new NotImplementedException();
        }

        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeDelegates = true)]
        public static void makeActive(this jQueryFn jqfn)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeDelegates = true)]
        public static void swipe(this jQuery jqfn, Action<object, object> fn)
        {
            throw new NotImplementedException();
        }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, NativeDelegates = true)]
        public static void tap(this jQueryFn jqfn, JsFunction fn)
        {
            throw new NotImplementedException();
        }


        //publicObj = {
        //          getOrientation: getOrientation,
        //          goBack: goBack,
        //          goTo: goTo,
        //          addAnimation: addAnimation,
        //          submitForm: submitForm
        //      }
        //    function liveTap(e){
        //      function addPageToHistory(page, animation) {
        //      function animatePages(fromPage, toPage, animation, backwards) {
        //      function dumbLoopStart() {
        //      function insertPages(nodes, animation) {
        //      function showPageByHref(href, options) {
        //      function submitForm(e, callback){
        //      function submitParentForm(e){
        //      function updateOrientation() {
        //      function handleTouch(e) {


        //        // Public jQuery Fns
        //              $.fn.unselect = function(obj) {
        //      $.fn.makeActive = function(){
        //      $.fn.swipe = function(fn) {
        //      $.fn.tap = function(fn){

    }


	[JsType(Mode = JsMode.Json)]
	public class jQTouchSettings
	{
		/*Property	Default	Expects	Notes*/

		/// <summary>
		/// If set to true, allow iPhone to add gloss to your web clip icon.
		/// </summary>
		public bool addGlossToIcon = true;
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger the “back” behavior of jQTouch when tapped. When the back behavior is invoked, the current panel moves off screen with a reverse animation and is removed from history.
		/// </summary>
		public string backSelector = ".back, .cancel, .goback";
		/// <summary>
		/// If set to true, automatically caches GET requests, so subsequent clicks reference the already loaded data.
		/// </summary>
		public bool cacheGetRequests = true;
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger a cube animation from the current panel to the target panel.
		/// </summary>
		public string cubeSelector = ".cube";
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger a dissolve animation from the current panel to the target panel.
		/// </summary>
		public string dissolveSelector = ".dissolve";
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger a fade animation from the current panel to the target panel.
		/// </summary>
		public string fadeSelector = ".fade";
		/// <summary>
		/// If set to true, prevents users from being able to zoom in or out of the page.
		/// </summary>
		public bool fixedViewport = true;
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger a flip animation from the current panel to the target panel.
		/// </summary>
		public string flipSelector = ".flip";
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	 
		/// </summary>
		public string formSelector = "form";
		/// <summary>
		/// When set to true, your app will open in full screen mode when launched from the users home screen. Has no effect on the display if the app is running in Mobile Safari.
		/// </summary>
		public bool fullScreen = true;
		/// <summary>
		/// Class name that will be applied to the body when the app is launched in full screen mode. Allows you to write custom CSS that only executes in full screen mode.
		/// </summary>
		public string fullScreenClass = "fullscreen";
		/// <summary>
		/// null or a relative or absolute path to a 57x57 px png image file.	The web clip icon for your app. This is the image that will be displayed when a user saves your app to their home screen.
		/// </summary>
		public string icon = null;
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger a pop animation from the current panel to the target panel.
		/// </summary>
		public string popSelector = ".pop";
		/// <summary>
		/// An array of image paths to load them before page loads.	Ex: ["images/link_over.png", "images/link_select.png"]
		/// </summary>
		public string[] preloadImages = null;
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will trigger a slide left animation from the current panel to the target panel.
		/// </summary>
		public string slideInSelector = "ul li a";
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will cause the target panel to slide up into view in front of the current panel.
		/// </summary>
		public string slideupSelector = ".slideup";
		/// <summary>
		/// null or a relative or absolute path to an image file.	Pass a relative or absolute path to a 320px x 460px startup screen for full screen apps. Use a 320px x 480px image if you set statusBar to black-translucent.
		/// </summary>
		public string startupScreen = null;
		/// <summary>
		/// default, black-translucent, black	Defines the appearance of the 20 pixel status bar at the top of the window in an app launched in full screen mode.
		/// </summary>
		public string statusBar = "default";
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Selector which, when clicked, will submit its parent form (and close keyboard if open).
		/// </summary>
		public string submitSelector = ".submit";
		/// <summary>
		/// Any valid CSS selector. Separate multiple values with a comma.	Defines elements that will cause the target panel to swap into view in front of the current panel.
		/// </summary>
		public string swapSelector = ".swap";
		/// <summary>
		/// Set to false to disable all animations.
		/// </summary>
		public bool useAnimations = true;
	}

    public class jQueryFn//TODO:
    {
    }
}
