using System;
using System.ComponentModel;
using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html.storage;
using SharpKit.DotNet.Html.webdatabase;

namespace SharpKit.DotNet.Html
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
        public static object frames { get; set; }
        public static object length { get; set; }
        public static Window top { get; private set; }
        public static object opener { get; set; }
        public static Window parent { get; private set; }
        public static Element frameElement { get; private set; }
        public static Navigator navigator { get; private set; }
        //public static ApplicationCache applicationCache { get; private set; }
 
        public static HtmlDocument document { get; private set; }
        public static StyleMedia styleMedia { get; private set; }
        public static Screen screen { get; private set; }
        public static int innerWidth { get; private set; }
        public static int innerHeight { get; private set; }
        public static int pageXOffset { get; private set; }
        public static int pageYOffset { get; private set; }
        public static void ScrollBy(int x, int y) { }
        public static int screenX { get; private set; }
        public static int screenY { get; private set; }
        public static int outerWidth { get; private set; }
        public static int outerHeight { get; private set; }
        // WindowSessionStorage
        public static Storage sessionStorage { get; private set; }
        // WindowLocalStorage
        public static Storage localStorage { get; private set; }

        [JsMethod(Name = "close")]
        public static void Close() { }
        [JsMethod(Name = "stop")]
        public static void Stop() { }
        [JsMethod(Name = "focus")]
        public static void Focus() { }
        [JsMethod(Name = "blur")]
        public static void Blur() { }
        [JsMethod(Name = "open")]
        public static Window Open() { return null; }
        [JsMethod(Name = "open")]
        public static Window Open(JsString url) { return null; }
        [JsMethod(Name = "open")]
        public static Window Open(JsString url, JsString target) { return null; }
        [JsMethod(Name = "open")]
        public static Window Open(JsString url, JsString target, JsString features) { return null; }
        [JsMethod(Name = "open")]
        public static Window Open(JsString url, JsString target, JsString features, JsString replace) { return null; }
        [JsMethod(Name = "getElement")]
        public static Window GetElement(int index) { return null; }
        [JsMethod(Name = "getElement")]
        public static object GetElement(JsString name) { return null; }
        [JsMethod(Name = "setElement")]
        public static void SetElement(JsString name, object value) { }
        [JsMethod(Name = "alert")]
        public static void Alert(JsString message) { }
        [JsMethod(Name = "alert")]
        public static void Alert(object obj) { }
        [JsMethod(Name = "confirm")]
        public static bool Confirm(JsString message) { return false; }
        [JsMethod(Name = "confirm")]
        public static bool Confirm(object obj) { return false; }
        [JsMethod(Name = "prompt")]
        public static JsString Prompt(JsString message) { return null; }
        [JsMethod(Name = "prompt")]
        public static JsString Prompt(object obj) { return null; }
        [JsMethod(Name = "prompt")]
        public static JsString Prompt(JsString message, JsString _default) { return null; }
        [JsMethod(Name = "prompt")]
        public static JsString Prompt(object obj, object _default) { return null; }
        [JsMethod(Name = "print")]
        public static void Print() { }
        [JsMethod(Name = "showModalDialog")]
        public static object ShowModalDialog(JsString url) { return null; }
        [JsMethod(Name = "showModalDialog")]
        public static object ShowModalDialog(JsString url, object argument) { return null; }
        [JsMethod(Name = "postMessage")]
        public static void PostMessage(object message, JsString targetOrigin) { }
        [JsMethod(Name = "postMessage")]
        public static void PostMessage(object message, JsString targetOrigin, MessagePort[] ports) { }
        // Window-1
        [JsMethod(Name = "getComputedStyle")]
        public static CssStyleDeclaration GetComputedStyle(Element elt) { return null; }
        [JsMethod(Name = "getComputedStyle")]
        public static CssStyleDeclaration GetComputedStyle(Element elt, JsString pseudoElt) { return null; }
        // Window-2
        [JsMethod(Name = "scroll")]
        public static void Scroll(int x, int y) { }
        [JsMethod(Name = "scrollTo")]
        public static void ScrollTo(int x, int y) { }
        [JsMethod(Name = "scrollBy")]
        // WindowTimers
        [JsMethod(Name = "setTimeout")]
        public static int SetTimeout(JsAction handler) { return 0; }
        [JsMethod(Name = "setTimeout")]
        public static int SetTimeout(JsAction handler, object timeout, params object[] args) { return 0; }
        [JsMethod(Name = "setTimeout")]
        public static int SetTimeout(JsString handler) { return 0; }
        [JsMethod(Name = "setTimeout")]
        public static int SetTimeout(JsString handler, object timeout, params object[] args) { return 0; }
        [JsMethod(Name = "clearTimeout")]
        public static void ClearTimeout(int handle) { }
        [JsMethod(Name = "setInterval")]
        public static int SetInterval(JsAction handler) { return 0; }
        [JsMethod(Name = "setInterval")]
        public static int SetInterval(JsAction handler, object timeout, params object[] args) { return 0; }
        [JsMethod(Name = "clearInterval")]
        public static void ClearInterval(int handle) { }
        [Obsolete("requestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        [JsMethod(Name = "requestAnimationFrame")]
        public static void RequestAnimationFrame(JsAction handler) { }
        [Obsolete("webkitRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        [JsMethod(Name = "webkitRequestAnimationFrame")]
        public static void WebkitRequestAnimationFrame(JsAction handler) { }
        [Obsolete("mozRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        [JsMethod(Name = "mozRequestAnimationFrame")]
        public static void MozRequestAnimationFrame(JsAction handler) { }
        [Obsolete("oRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        [JsMethod(Name = "oRequestAnimationFrame")]
        public static void ORequestAnimationFrame(JsAction handler) { }
        [Obsolete("msRequestAnimationFrame is not a WHATWG-sanctioned function and may be deprecated without notice.", false)]
        [JsMethod(Name = "msRequestAnimationFrame")]
        public static void MsRequestAnimationFrame(JsAction handler) { }

        // WindowDatabase
        [JsMethod(Name = "openDatabase")]
        public static Database OpenDatabase(JsString name, JsString version, JsString displayName, int estimatedSize) { return null; }
        [JsMethod(Name = "openDatabase")]
        public static Database OpenDatabase(JsString name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback) { return null; }
        #endregion

        ///<summary>
        ///Encodes String objects so they can be read on all computers.
        ///</summary>
        ///<param name="s">String object or literal to be encoded.</param>
        ///<returns>A JsString value (in Unicode format) that contains the contents of charstring. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with %xx encoding, where xx is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."</returns>
        [JsMethod(Name = "escape")]
        public static JsString Escape(JsString s) { return null; }
        ///<summary>
        ///Returns the unencoded version of an encoded component of a Uniform Resource Identifier (URI). 
        ///</summary>
        ///<param name="encodedURIString">A value representing an encoded URI component.</param>
        ///<returns>The required encodedURIString argument is a value representing an encoded 
        ///URI component.A URIComponent is part of a complete URI. If the encodedURIString is 
        ///not valid, a URIError occurs.</returns>
        [JsMethod(Name = "decodeURIComponent")]
        public static JsString DecodeURIComponent(JsString encodedURIString) { return null; }
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
        [JsMethod(Name = "encodeURIComponent")]
        public static JsString EncodeURIComponent(JsString encodedURIString) { return null; }
        ///<summary>
        ///Encodes a text JsString as a valid Uniform Resource Identifier (URI) 
        ///</summary>
        ///<param name="URIString">A value representing an encoded URI.</param>
        ///<returns>n encoded URI. If you pass the result to decodeURI, the original JsString is returned. The encodeURI method does not encode the following characters: ":", "/", ";", and "?". Use encodeURIComponent to encode these characters.</returns>
        [JsMethod(Name = "encodeURI")]
        public static JsString EncodeURI(JsString URIString) { return null; }
        ///<summary>
        ///Returns the unencoded version of an encoded Uniform Resource Identifier (URI). 
        ///</summary>
        ///<param name="URIString"></param>
        ///<returns></returns>
        [JsMethod(Name = "decodeURI")]
        public static JsString DecodeURI(JsString URIString) { return null; }
        ///<summary>
        ///Decodes String objects encoded with the escape method.
        ///</summary>
        ///<param name="charString">String object or literal to be decoded.</param>
        ///<returns>A JsString value that contains the contents of charstring. All characters encoded with the %xx hexadecimal form are replaced by their ASCII character set equivalents.</returns>
        [JsMethod(Name = "unescape")]
        public static JsString Unescape(JsString charString) { return null; }


    }


}
