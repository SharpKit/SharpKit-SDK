using System;
using SharpKit.JavaScript;
using SharpKit.Html.storage;
using SharpKit.Html.webdatabase;

namespace SharpKit.Html
{
	[JsType(JsMode.Global, Export = false)]
	public class HtmlContext : JsContext
	{
		#region Window
		public static Console console { get; private set; }
		public static Window window { get; private set; }
		public static Window self { get; private set; }
		public static JsString name { get; set; }
		public static Location location { get; set; }
		public static History history { get; private set; }
		//public static UndoManager undoManager { get; private set; }
		public static Selection selection { get; private set; }
		public static object locationbar { get; set; }
		public static object menubar { get; set; }
		public static object personalbar { get; set; }
		public static object scrollbars { get; set; }
		public static object statusbar { get; set; }
		public static object toolbar { get; set; }
		public static void close() { }
		public static void stop() { }
		public static void focus() { }
		public static void blur() { }
		public static object frames { get; set; }
		public static object length { get; set; }
		public static Window top { get; private set; }
		public static object opener { get; set; }
		public static Window parent { get; private set; }
		public static Element frameElement { get; private set; }
		public static Window open() { return null; }
		public static Window open(string url) { return null; }
		public static Window open(string url, JsString target) { return null; }
		public static Window open(string url, JsString target, JsString features) { return null; }
		public static Window open(string url, JsString target, JsString features, JsString replace) { return null; }
		public static Window getElement(int index) { return null; }
		public static object getElement(string name) { return null; }
		public static void setElement(string name, object value) { }
		public static Navigator navigator { get; private set; }
		//public static ApplicationCache applicationCache { get; private set; }
		public static void alert(string message) { }
		public static void alert(object obj) { }
		public static bool confirm(string message) { return false; }
		public static JsString prompt(string message) { return null; }
		public static JsString prompt(string message, JsString _default) { return null; }
		public static void print() { }
		public static object showModalDialog(string url) { return null; }
		public static object showModalDialog(string url, object argument) { return null; }
		public static void postMessage(object message, JsString targetOrigin) { }
		public static void postMessage(object message, JsString targetOrigin, MessagePort[] ports) { }
		public static JsAction onabort { get; set; }
		public static JsAction onafterprint { get; set; }
		public static JsAction onbeforeprint { get; set; }
		public static JsAction onbeforeunload { get; set; }
		public static JsAction onblur { get; set; }
		public static JsAction oncanplay { get; set; }
		public static JsAction oncanplaythrough { get; set; }
		public static JsAction onchange { get; set; }
		public static JsAction onclick { get; set; }
		public static JsAction oncontextmenu { get; set; }
		public static JsAction ondblclick { get; set; }
		public static JsAction ondrag { get; set; }
		public static JsAction ondragend { get; set; }
		public static JsAction ondragenter { get; set; }
		public static JsAction ondragleave { get; set; }
		public static JsAction ondragover { get; set; }
		public static JsAction ondragstart { get; set; }
		public static JsAction ondrop { get; set; }
		public static JsAction ondurationchange { get; set; }
		public static JsAction onemptied { get; set; }
		public static JsAction onended { get; set; }
		public static JsAction onerror { get; set; }
		public static JsAction onfocus { get; set; }
		public static JsAction onformchange { get; set; }
		public static JsAction onforminput { get; set; }
		public static JsAction onhashchange { get; set; }
		public static JsAction oninput { get; set; }
		public static JsAction oninvalid { get; set; }
		public static JsAction onkeydown { get; set; }
		public static JsAction onkeypress { get; set; }
		public static JsAction onkeyup { get; set; }
		public static JsAction onload { get; set; }
		public static JsAction onloadeddata { get; set; }
		public static JsAction onloadedmetadata { get; set; }
		public static JsAction onloadstart { get; set; }
		public static JsAction onmessage { get; set; }
		public static JsAction onmousedown { get; set; }
		public static JsAction onmousemove { get; set; }
		public static JsAction onmouseout { get; set; }
		public static JsAction onmouseover { get; set; }
		public static JsAction onmouseup { get; set; }
		public static JsAction onmousewheel { get; set; }
		public static JsAction onoffline { get; set; }
		public static JsAction ononline { get; set; }
		public static JsAction onpause { get; set; }
		public static JsAction onplay { get; set; }
		public static JsAction onplaying { get; set; }
		public static JsAction onpagehide { get; set; }
		public static JsAction onpageshow { get; set; }
		public static JsAction onpopstate { get; set; }
		public static JsAction onprogress { get; set; }
		public static JsAction onratechange { get; set; }
		public static JsAction onreadystatechange { get; set; }
		public static JsAction onredo { get; set; }
		public static JsAction onresize { get; set; }
		public static JsAction onscroll { get; set; }
		public static JsAction onseeked { get; set; }
		public static JsAction onseeking { get; set; }
		public static JsAction onselect { get; set; }
		public static JsAction onshow { get; set; }
		public static JsAction onstalled { get; set; }
		public static JsAction onstorage { get; set; }
		public static JsAction onsubmit { get; set; }
		public static JsAction onsuspend { get; set; }
		public static JsAction ontimeupdate { get; set; }
		public static JsAction onundo { get; set; }
		public static JsAction onunload { get; set; }
		public static JsAction onvolumechange { get; set; }
		public static JsAction onwaiting { get; set; }
		// Window-1
		public static CssStyleDeclaration getComputedStyle(Element elt) { return null; }
		public static CssStyleDeclaration getComputedStyle(Element elt, JsString pseudoElt) { return null; }
		// Window-2
		public static HtmlDocument document { get; private set; }
		public static StyleMedia styleMedia { get; private set; }
		public static Screen screen { get; private set; }
		public static int innerWidth { get; private set; }
		public static int innerHeight { get; private set; }
		public static int pageXOffset { get; private set; }
		public static int pageYOffset { get; private set; }
		public static void scroll(int x, int y) { }
		public static void scrollTo(int x, int y) { }
		public static void scrollBy(int x, int y) { }
		public static int screenX { get; private set; }
		public static int screenY { get; private set; }
		public static int outerWidth { get; private set; }
		public static int outerHeight { get; private set; }
		// WindowTimers
		public static int setTimeout(JsAction handler) { return 0; }
		public static int setTimeout(JsAction handler, object timeout, params object[] args) { return 0; }
		public static void clearTimeout(int handle) { }
		public static int setInterval(JsAction handler) { return 0; }
		public static int setInterval(JsAction handler, object timeout, params object[] args) { return 0; }
		public static void clearInterval(int handle) { }
        [Obsolete("requestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        public static void requestAnimationFrame(JsAction handler) { }
        [Obsolete("webkitRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        public static void webkitRequestAnimationFrame(JsAction handler) { }
        [Obsolete("mozRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        public static void mozRequestAnimationFrame(JsAction handler) { }
        [Obsolete("oRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        public static void oRequestAnimationFrame(JsAction handler) { }
        [Obsolete("msRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        public static void msRequestAnimationFrame(JsAction handler) { }

        // WindowDatabase
		public static Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize) { return null; }
		public static Database openDatabase(string name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback) { return null; }
		// WindowSessionStorage
		public static Storage sessionStorage { get; private set; }
		// WindowLocalStorage
		public static Storage localStorage { get; private set; }
		#endregion

		///<summary>
		///Encodes String objects so they can be read on all computers.
		///</summary>
		///<param name="s">String object or literal to be encoded.</param>
		///<returns>A JsString value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
		public static JsString escape(JsString s) { return null; }
		///<summary>
		///Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
		///</summary>
		///<param name="encodedURIString">A value representing an encoded URI component.</param>
		///<returns>The required encodedURIString argument is a value representing an encoded 
		///URI component.A URIComponent is part of a complete URI. If the encodedURIString is 
		///not valid, a URIError occurs.</returns>
		public static JsString decodeURIComponent(JsString encodedURIString) { return null; }
		///<summary>
		///Encodes a text JsString as a valid component of a Uniform Resource Identifier (URI).
		///</summary>
		///<param name="encodedURIString">A value representing an encoded URI component.</param>
		///<returns>A an encoded URI. If you pass the result to decodeURIComponent, 
		///the original JsString is returned. Because the encodeURIComponent method encodes all 
		///characters, be careful if the JsString represents a path such 
		///as /folder1/folder2/default.html. The slash characters will be encoded and will 
		///not be valid if sent as a request to a web server. Use the encodeURI method if the 
		///JsString contains more than a single URI component.</returns>
		public static JsString encodeURIComponent(JsString encodedURIString) { return null; }
		///<summary>
		///Encodes a text JsString as a valid Uniform Resource Identifier (URI) 
		///</summary>
		///<param name="URIString">A value representing an encoded URI.</param>
		///<returns>n encoded URI. If you pass the result to decodeURI, the original JsString is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
		public static JsString encodeURI(JsString URIString) { return null; }
		///<summary>
		///Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
		///</summary>
		///<param name="URIString"></param>
		///<returns></returns>
		public static JsString decodeURI(JsString URIString) { return null; }
		///<summary>
		///Decodes String objects encoded with the escape method.
		///</summary>
		///<param name="charString">String object or literal to be decoded.</param>
		///<returns>A JsString value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
		public static JsString unescape(JsString charString) { return null; }


	}


}
