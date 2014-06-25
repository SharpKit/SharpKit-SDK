/*******************************************************************************************************
  This file was created/modified by Hervé PHILIPPE alchiweb[at]gmail.com
********************************************************************************************************

  Copyright (C) 2013 Hervé PHILIPPE, Web: http://xmadevlab.net

  Project based on the files auto generated with the tool "WebIDLParser"
  Copyright (C) 2013 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.ComponentModel;

namespace SharpKit.DotNet.Html
{

    using SharpKit.JavaScript;
    using SharpKit.DotNet.JavaScript;
    using SharpKit.DotNet.Html.fileapi;
    using SharpKit.DotNet.Html.html.shadow;
    using SharpKit.DotNet.Html.html.track;
    using SharpKit.DotNet.Html.inspector;
    using SharpKit.DotNet.Html.loader.appcache;
    using SharpKit.DotNet.Html.battery;
    using SharpKit.DotNet.Html.gamepad;
    using SharpKit.DotNet.Html.geolocation;
    using SharpKit.DotNet.Html.indexeddb;
    using SharpKit.DotNet.Html.intents;
    using SharpKit.DotNet.Html.mediasource;
    using SharpKit.DotNet.Html.mediastream;
    using SharpKit.DotNet.Html.networkinfo;
    using SharpKit.DotNet.Html.notifications;
    using SharpKit.DotNet.Html.proximity;
    using SharpKit.DotNet.Html.quota;
    using SharpKit.DotNet.Html.speech;
    using SharpKit.DotNet.Html.webaudio;
    using SharpKit.DotNet.Html.webdatabase;
    using SharpKit.DotNet.Html.plugins;
    using SharpKit.DotNet.Html.storage;
    using SharpKit.DotNet.Html.svg;
    using SharpKit.DotNet.Html.workers;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Window")]
    public partial class Window : UIEventTarget<Window>, ILocalFileSystem,
        IWindowEventTarget<Window>
    {
        #region From PagePopup
        public PagePopupController pagePopupController { get; set; }
        #endregion

        #region From WebSockets module
        public CloseEvent CloseEvent { get; set; }
        public WebSocket WebSocket { get; set; }
        #endregion

        #region From WebDatabase module
        /// <summary>
        /// The method creates a new SQL Lite Database and returns a Database object that allows manipulation of the data.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_storage_storage.md.html#OpenDatabase
        /// </remarks>
        /// <param name="name">The name of the database.</param>
        /// <param name="version">The version of the database.</param>
        /// <param name="displayName">The display name of the database.</param>
        /// <param name="estimatedSize">The size of the database in bytes.</param>
        /// <returns></returns>
        [JsMethod(Name = "openDatabase")]
        public Database OpenDatabase(JsString name, JsString version, JsString displayName, long estimatedSize) { return default(Database); }
        /// <summary>
        /// The method creates a new SQL Lite Database and returns a Database object that allows manipulation of the data.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_storage_storage.md.html#OpenDatabase
        /// </remarks>
        /// <param name="name">The name of the database.</param>
        /// <param name="version">The version of the database.</param>
        /// <param name="displayName">The display name of the database.</param>
        /// <param name="estimatedSize">The size of the database in bytes.</param>
        /// <param name="creationCallback"></param>
        /// <returns></returns>
        [JsMethod(Name = "openDatabase")]
        public Database OpenDatabase(JsString name, JsString version, JsString displayName, long estimatedSize, DatabaseCallback creationCallback) { return default(Database); }
        public SQLException SQLException { get; set; }
        #endregion

        #region From WebAudio module
        public AudioProcessingEvent AudioProcessingEvent { get; set; }
        public OfflineAudioCompletionEvent OfflineAudioCompletionEvent { get; set; }
        #endregion

        #region From MediaStream module
        public RTCSessionDescription RTCSessionDescription { get; set; }
        public RTCIceCandidate RTCIceCandidate { get; set; }
        public MediaStreamEvent MediaStreamEvent { get; set; }
        #endregion

        #region From IndexedDatabase module
        public IDBFactory indexedDB { get; set; }
        public IDBCursor IDBCursor { get; set; }
        public IDBCursorWithValue IDBCursorWithValue { get; set; }
        public IDBDatabase IDBDatabase { get; set; }
        public IDBFactory IDBFactory { get; set; }
        public IDBIndex IDBIndex { get; set; }
        public IDBKeyRange IDBKeyRange { get; set; }
        public IDBObjectStore IDBObjectStore { get; set; }
        public IDBOpenDBRequest IDBOpenDBRequest { get; set; }
        public IDBRequest IDBRequest { get; set; }
        public IDBTransaction IDBTransaction { get; set; }
        public IDBVersionChangeEvent IDBVersionChangeEvent { get; set; }
        #endregion

        public Screen screen { get; set; }
        public History history { get; set; }
        public BarInfo locationbar { get; set; }
        public BarInfo menubar { get; set; }
        public BarInfo personalbar { get; set; }
        public BarInfo scrollbars { get; set; }
        public BarInfo statusbar { get; set; }
        public BarInfo toolbar { get; set; }
        public Navigator navigator { get; set; }
        public Navigator clientInformation { get; set; }
        public Crypto crypto { get; set; }
        public Location location { get; set; }
        public Event @event { get; set; }
        public Element frameElement { get; set; }
        public bool offscreenBuffering { get; set; }
        public int outerHeight { get; set; }
        public int outerWidth { get; set; }
        public int innerHeight { get; set; }
        public int innerWidth { get; set; }
        public int screenX { get; set; }
        public int screenY { get; set; }
        public int screenLeft { get; set; }
        public int screenTop { get; set; }
        public int scrollX { get; set; }
        public int scrollY { get; set; }
        public int pageXOffset { get; set; }
        public int pageYOffset { get; set; }
        public bool closed { get; set; }
        public int length { get; set; }
        public JsString name { get; set; }
        public JsString status { get; set; }
        public JsString defaultStatus { get; set; }
        public JsString defaultstatus { get; set; }
        public Window self { get; set; }
        public Window window { get; set; }
        public Window frames { get; set; }
        public Window opener { get; set; }
        public Window parent { get; set; }
        public Window top { get; set; }
        public Document document { get; set; }
        public StyleMedia styleMedia { get; set; }
        public double devicePixelRatio { get; set; }
        public DOMApplicationCache applicationCache { get; set; }
        /// <summary>
        /// Provides access to the W3C's Web Storage interface
        /// <para>An app can use it to save persistent data using key-value pairs. The <see cref="Window.sessionStorage"/> interface works the same way as the <see cref="Window.localStorage"/> in every respect, except that all data is cleared each time the app closes. Each database provides a separate namespace.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_storage_storage.md.html#localStorage
        /// </remarks>
        public Storage sessionStorage { get; set; }
        /// <summary>
        /// Provides access to the W3C's Web Storage interface
        /// <para>An app can use it to save persistent data using key-value pairs. The <see cref="Window.sessionStorage"/> interface works the same way as the <see cref="Window.localStorage"/> in every respect, except that all data is cleared each time the app closes. Each database provides a separate namespace.</para>
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_storage_storage.md.html#localStorage
        /// </remarks>
        public Storage localStorage { get; set; }
        public Console console { get; set; }

        #region IBodyFrameSet
        #region Window events

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onafterprint", NativeField = true)]
        public EventListener<WindowEvent<Window>> onAfterPrint { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnAfterPrint
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"afterprint\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"afterprint\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onbeforeprint", NativeField = true)]
        public EventListener<WindowEvent<Window>> onBeforePrint { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnBeforePrint
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforeprint\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforeprint\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onbeforeunload", NativeField = true)]
        public EventListener<WindowEvent<Window>> onBeforeUnload { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnBeforeUnload
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforeunload\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforeunload\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onoffline", NativeField = true)]
        public EventListener<WindowEvent<Window>> onOffline { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnOffline
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"offline\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"offline\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ononline", NativeField = true)]
        public EventListener<WindowEvent<Window>> onOnline { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnOnline
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"online\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"online\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onresize", NativeField = true)]
        public EventListener<WindowEvent<Window>> onResize { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnResize
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"resize\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"resize\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onunload", NativeField = true)]
        public EventListener<WindowEvent<Window>> onUnLoad { get; set; }
#endif
        public event EventListener<WindowEvent<Window>> OnUnLoad
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"unload\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"unload\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(WindowEventType type, EventListener<WindowEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(WindowEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(WindowEventType type, EventListener<WindowEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region Device motion event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondevicemotion", NativeField = true)]
        public EventListener<DeviceMotionEvent<Window>> onDeviceMotion { get; set; }
#endif
        public event EventListener<DeviceMotionEvent<Window>> OnDeviceMotion
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"devicemotion\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"devicemotion\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(DeviceMotionEventType type, EventListener<DeviceMotionEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(DeviceMotionEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(DeviceMotionEventType type, EventListener<DeviceMotionEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region Device orientation change events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondeviceorientation", NativeField = true)]
        public EventListener<DeviceOrientationEvent<Window>> onDeviceOrientation { get; set; }
#endif
        public event EventListener<DeviceOrientationEvent<Window>> OnDeviceOrientation
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"deviceorientation\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"deviceorientation\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onorientationchange", NativeField = true)]
        public EventListener<DeviceOrientationEvent<Window>> onOrientationChange { get; set; }
#endif
        public event EventListener<DeviceOrientationEvent<Window>> OnOrientationChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"orientationchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"orientationchange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(DeviceOrientationEventType type, EventListener<DeviceOrientationEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(DeviceOrientationEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(DeviceOrientationEventType type, EventListener<DeviceOrientationEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region Storage event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onstorage", NativeField = true)]
        public EventListener<StorageEvent<Window>> onStorage { get; set; }
#endif
        public event EventListener<StorageEvent<Window>> OnStorage
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"storage\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"storage\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(StorageEventType type, EventListener<StorageEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(StorageEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(StorageEventType type, EventListener<StorageEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region HashChange event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onhashchange", NativeField = true)]
        public EventListener<HashChangeEvent<Window>> onHashChange { get; set; }
#endif
        public event EventListener<HashChangeEvent<Window>> OnHashChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"hashchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"hashchange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(HashChangeEventType type, EventListener<HashChangeEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(HashChangeEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(HashChangeEventType type, EventListener<HashChangeEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region PopState event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onpopstate", NativeField = true)]
        public EventListener<PopStateEvent<Window>> onPopState { get; set; }
#endif
        public event EventListener<PopStateEvent<Window>> OnPopState
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"popstate\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"popstate\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(PopStateEventType type, EventListener<PopStateEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(PopStateEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(PopStateEventType type, EventListener<PopStateEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region PageTransition events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onpagehide", NativeField = true)]
        public EventListener<PageTransitionEvent<Window>> onPageHide { get; set; }
#endif
        public event EventListener<PageTransitionEvent<Window>> OnPageHide
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"pagehide\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"pagehide\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onpageshow", NativeField = true)]
        public EventListener<PageTransitionEvent<Window>> onPageShow { get; set; }
#endif
        public event EventListener<PageTransitionEvent<Window>> OnPageShow
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"pageshow\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"pageshow\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(PageTransitionEventType type, EventListener<PageTransitionEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(PageTransitionEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(PageTransitionEventType type, EventListener<PageTransitionEvent<Window>> listener, bool useCapture = false) { }
        #endregion

        #region Message event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmessage", NativeField = true)]
        public EventListener<MessageEvent<Window>> onMessage { get; set; }
#endif
        public event EventListener<MessageEvent<Window>> OnMessage
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"message\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"message\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MessageEventType type, EventListener<MessageEvent<Window>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MessageEvent<Window> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MessageEventType type, EventListener<MessageEvent<Window>> listener, bool useCapture = false) { }
        #endregion
        #endregion




        public StyleSheet StyleSheet { get; set; }
        public CssStyleSheet CSSStyleSheet { get; set; }
        public CssValue CSSValue { get; set; }
        public CssPrimitiveValue CSSPrimitiveValue { get; set; }
        public CssValueList CSSValueList { get; set; }
        public CssRule CSSRule { get; set; }
        public CssCharsetRule CSSCharsetRule { get; set; }
        public CssFontFaceRule CSSFontFaceRule { get; set; }
        public CssImportRule CSSImportRule { get; set; }
        public CssMediaRule CSSMediaRule { get; set; }
        public CssPageRule CSSPageRule { get; set; }
        public CssStyleRule CSSStyleRule { get; set; }
        public CssStyleDeclaration CSSStyleDeclaration { get; set; }
        public MediaList MediaList { get; set; }
        public Counter Counter { get; set; }
        public CssRuleList CSSRuleList { get; set; }
        public Rect Rect { get; set; }
        public RGBColor RGBColor { get; set; }
        public StyleSheetList StyleSheetList { get; set; }
        public DOMException DOMException { get; set; }
        public DOMStringList DOMStringList { get; set; }
        public DOMImplementation DOMImplementation { get; set; }
        public DOMSettableTokenList DOMSettableTokenList { get; set; }
        public DOMTokenList DOMTokenList { get; set; }
        public DocumentFragment DocumentFragment { get; set; }
        public Document Document { get; set; }
        public Node Node { get; set; }
        public NodeList NodeList { get; set; }
        public PropertyNodeList PropertyNodeList { get; set; }
        public NamedNodeMap NamedNodeMap { get; set; }
        public CharacterData CharacterData { get; set; }
        public Attr Attr { get; set; }
        public Element Element { get; set; }
        public Text Text { get; set; }
        public Comment Comment { get; set; }
        public CDATASection CDATASection { get; set; }
        public DocumentType DocumentType { get; set; }
        public Notation Notation { get; set; }
        public Entity Entity { get; set; }
        public EntityReference EntityReference { get; set; }
        public ProcessingInstruction ProcessingInstruction { get; set; }
        public HtmlContentElement HTMLContentElement { get; set; }
        public HtmlShadowElement HTMLShadowElement { get; set; }
        public Selection Selection { get; set; }
        [JsProperty(Name = "Window")]
        public Window Window_ { get; set; }
        public HtmlDocument HTMLDocument { get; set; }
        public HtmlElement HTMLElement { get; set; }
        public HtmlAnchorElement HTMLAnchorElement { get; set; }
        public HtmlAppletElement HTMLAppletElement { get; set; }
        public HtmlAreaElement HTMLAreaElement { get; set; }
        public HtmlBRElement HTMLBRElement { get; set; }
        public HtmlBaseElement HTMLBaseElement { get; set; }
        public HtmlBaseFontElement HTMLBaseFontElement { get; set; }
        public HtmlBodyElement HTMLBodyElement { get; set; }
        public HtmlButtonElement HTMLButtonElement { get; set; }
        public HtmlCanvasElement HTMLCanvasElement { get; set; }
        public HtmlDListElement HTMLDListElement { get; set; }
        public HtmlDataListElement HTMLDataListElement { get; set; }
        public HtmlDialogElement HTMLDialogElement { get; set; }
        public HtmlDirectoryElement HTMLDirectoryElement { get; set; }
        public HtmlDivElement HTMLDivElement { get; set; }
        public HtmlEmbedElement HTMLEmbedElement { get; set; }
        public HtmlFieldSetElement HTMLFieldSetElement { get; set; }
        public HtmlFontElement HTMLFontElement { get; set; }
        public HtmlFormElement HTMLFormElement { get; set; }
        public HtmlFrameElement HTMLFrameElement { get; set; }
        public HtmlFrameSetElement HTMLFrameSetElement { get; set; }
        public HtmlHRElement HTMLHRElement { get; set; }
        public HtmlHeadElement HTMLHeadElement { get; set; }
        public HtmlHeadingElement HTMLHeadingElement { get; set; }
        public HtmlHtmlElement HTMLHtmlElement { get; set; }
        public HtmlIFrameElement HTMLIFrameElement { get; set; }
        public HtmlImageElement HTMLImageElement { get; set; }
        public HtmlInputElement HTMLInputElement { get; set; }
        public HtmlKeygenElement HTMLKeygenElement { get; set; }
        public HtmlLIElement HTMLLIElement { get; set; }
        public HtmlLabelElement HTMLLabelElement { get; set; }
        public HtmlLegendElement HTMLLegendElement { get; set; }
        public HtmlLinkElement HTMLLinkElement { get; set; }
        public HtmlMapElement HTMLMapElement { get; set; }
        public HtmlMarqueeElement HTMLMarqueeElement { get; set; }
        public HtmlMenuElement HTMLMenuElement { get; set; }
        public HtmlMetaElement HTMLMetaElement { get; set; }
        public HtmlModElement HTMLModElement { get; set; }
        public HtmlOListElement HTMLOListElement { get; set; }
        public HtmlObjectElement HTMLObjectElement { get; set; }
        public HtmlOptGroupElement HTMLOptGroupElement { get; set; }
        public HtmlOptionElement HTMLOptionElement { get; set; }
        public HtmlOutputElement HTMLOutputElement { get; set; }
        public HtmlParagraphElement HTMLParagraphElement { get; set; }
        public HtmlParamElement HTMLParamElement { get; set; }
        public HtmlPreElement HTMLPreElement { get; set; }
        public HtmlQuoteElement HTMLQuoteElement { get; set; }
        public HtmlScriptElement HTMLScriptElement { get; set; }
        public HtmlSelectElement HTMLSelectElement { get; set; }
        public HtmlSpanElement HTMLSpanElement { get; set; }
        public HtmlStyleElement HTMLStyleElement { get; set; }
        public HtmlTableCaptionElement HTMLTableCaptionElement { get; set; }
        public HtmlTableCellElement HTMLTableCellElement { get; set; }
        public HtmlTableColElement HTMLTableColElement { get; set; }
        public HtmlTableElement HTMLTableElement { get; set; }
        public HtmlTableRowElement HTMLTableRowElement { get; set; }
        public HtmlTableSectionElement HTMLTableSectionElement { get; set; }
        public HtmlTemplateElement HTMLTemplateElement { get; set; }
        public HtmlTextAreaElement HTMLTextAreaElement { get; set; }
        public HtmlTitleElement HTMLTitleElement { get; set; }
        public HtmlUListElement HTMLUListElement { get; set; }
        public HtmlCollection HTMLCollection { get; set; }
        public HtmlAllCollection HTMLAllCollection { get; set; }
        public HtmlFormControlsCollection HTMLFormControlsCollection { get; set; }
        public HtmlOptionsCollection HTMLOptionsCollection { get; set; }
        public HtmlPropertiesCollection HTMLPropertiesCollection { get; set; }
        public HtmlUnknownElement HTMLUnknownElement { get; set; }
        public HtmlImageElement Image { get; set; }
        public HtmlOptionElement Option { get; set; }
        public MediaKeyError MediaKeyError { get; set; }
        public MediaKeyEvent MediaKeyEvent { get; set; }
        public HtmlTrackElement HTMLTrackElement { get; set; }
        public TextTrack TextTrack { get; set; }
        public TextTrackCue TextTrackCue { get; set; }
        public TextTrackCueList TextTrackCueList { get; set; }
        public TextTrackList TextTrackList { get; set; }
        public TrackEvent TrackEvent { get; set; }
        public HtmlAudioElement Audio { get; set; }
        public HtmlAudioElement HTMLAudioElement { get; set; }
        public HtmlMediaElement HTMLMediaElement { get; set; }
        public HtmlVideoElement HTMLVideoElement { get; set; }
        public MediaError MediaError { get; set; }
        public TimeRanges TimeRanges { get; set; }
        public HtmlSourceElement HTMLSourceElement { get; set; }
        public MediaController MediaController { get; set; }
        public HtmlIntentElement HTMLIntentElement { get; set; }
        public CanvasPattern CanvasPattern { get; set; }
        public CanvasGradient CanvasGradient { get; set; }
        public CanvasRenderingContext2D CanvasRenderingContext2D { get; set; }
        public ImageData ImageData { get; set; }
        public TextMetrics TextMetrics { get; set; }
        public WebGLActiveInfo WebGLActiveInfo { get; set; }
        public WebGLBuffer WebGLBuffer { get; set; }
        public WebGLFramebuffer WebGLFramebuffer { get; set; }
        public WebGLProgram WebGLProgram { get; set; }
        public WebGLRenderbuffer WebGLRenderbuffer { get; set; }
        public WebGLRenderingContext WebGLRenderingContext { get; set; }
        public WebGLShader WebGLShader { get; set; }
        public WebGLShaderPrecisionFormat WebGLShaderPrecisionFormat { get; set; }
        public WebGLTexture WebGLTexture { get; set; }
        public WebGLUniformLocation WebGLUniformLocation { get; set; }
        public DOMStringMap DOMStringMap { get; set; }
        public ArrayBuffer ArrayBuffer { get; set; }
        public ArrayBufferView ArrayBufferView { get; set; }
        public Int8Array Int8Array { get; set; }
        public Uint8Array Uint8Array { get; set; }
        public Uint8ClampedArray Uint8ClampedArray { get; set; }
        public Int16Array Int16Array { get; set; }
        public Uint16Array Uint16Array { get; set; }
        public Int32Array Int32Array { get; set; }
        public Uint32Array Uint32Array { get; set; }
        public Float32Array Float32Array { get; set; }
        public Float64Array Float64Array { get; set; }
        public DataView DataView { get; set; }
        public Event Event { get; set; }
        public BeforeLoadEvent BeforeLoadEvent { get; set; }
        public CompositionEvent CompositionEvent { get; set; }
        public CustomEvent CustomEvent { get; set; }
        public ErrorEvent ErrorEvent { get; set; }
        public HashChangeEvent HashChangeEvent { get; set; }
        public KeyboardEvent KeyboardEvent { get; set; }
        public MessageEvent MessageEvent { get; set; }
        public MouseEvent MouseEvent { get; set; }
        public MutationEvent MutationEvent { get; set; }
        public OverflowEvent OverflowEvent { get; set; }
        public PopStateEvent PopStateEvent { get; set; }
        public PageTransitionEvent PageTransitionEvent { get; set; }
        public ProgressEvent ProgressEvent { get; set; }
        public TextEvent TextEvent { get; set; }
        public UIEvent UIEvent { get; set; }
        public WheelEvent WheelEvent { get; set; }
        public XMLHttpRequestProgressEvent XMLHttpRequestProgressEvent { get; set; }
        public DeviceMotionEvent DeviceMotionEvent { get; set; }
        public DeviceOrientationEvent DeviceOrientationEvent { get; set; }
        public Touch Touch { get; set; }
        public TouchEvent TouchEvent { get; set; }
        public TouchList TouchList { get; set; }
        public StorageEvent StorageEvent { get; set; }
        public SpeechInputEvent SpeechInputEvent { get; set; }
        public WebGLContextEvent WebGLContextEvent { get; set; }
        public DeviceProximityEvent DeviceProximityEvent { get; set; }
        //Obsolete        public EventException EventException { get; set; }
        public Clipboard Clipboard { get; set; }
        public Worker Worker { get; set; }
        public SharedWorker SharedWorker { get; set; }
        public File File { get; set; }
        public FileList FileList { get; set; }
        public Blob Blob { get; set; }
        public NodeFilter NodeFilter { get; set; }
        public Range Range { get; set; }
        //Obsolete        public RangeException RangeException { get; set; }
        public EventSource EventSource { get; set; }
        public Document XMLDocument { get; set; }
        public DOMParser DOMParser { get; set; }
        public XMLSerializer XMLSerializer { get; set; }
        public XMLHttpRequest XMLHttpRequest { get; set; }
        public XMLHttpRequestUpload XMLHttpRequestUpload { get; set; }
        public XMLHttpRequestException XMLHttpRequestException { get; set; }
        public XSLTProcessor XSLTProcessor { get; set; }
        public Plugin Plugin { get; set; }
        public PluginArray PluginArray { get; set; }
        public MimeType MimeType { get; set; }
        public MimeTypeArray MimeTypeArray { get; set; }
        public ClientRect ClientRect { get; set; }
        public ClientRectList ClientRectList { get; set; }
        public Storage Storage { get; set; }
        public XPathEvaluator XPathEvaluator { get; set; }
        public XPathResult XPathResult { get; set; }
        //Obsolete        public XPathException XPathException { get; set; }
        public SvgZoomEvent SVGZoomEvent { get; set; }
        public FormData FormData { get; set; }
        public FileError FileError { get; set; }
        public FileException FileException { get; set; }
        public FileReader FileReader { get; set; }
        public URL URL { get; set; }

        [JsMethod(Name = "getSelection")]
        public Selection GetSelection() { return default(Selection); }
        [JsMethod(Name = "close")]
        public void Close() { }
        [JsMethod(Name = "print")]
        public void Print() { }
        [JsMethod(Name = "stop")]
        public void Stop() { }
        [JsMethod(Name = "open")]
        public Window Open() { return default(Window); }
        [JsMethod(Name = "open")]
        public Window Open(JsString url, JsString name) { return default(Window); }
        [JsMethod(Name = "open")]
        public Window Open(JsString url, JsString name, JsString options) { return default(Window); }
        [JsMethod(Name = "showModalDialog")]
        public object ShowModalDialog(JsString url) { return default(object); }
        [JsMethod(Name = "showModalDialog")]
        public object ShowModalDialog(JsString url, object dialogArgs) { return default(object); }
        [JsMethod(Name = "showModalDialog")]
        public object ShowModalDialog(JsString url, object dialogArgs, JsString featureArgs) { return default(object); }
        [JsMethod(Name = "alert")]
        public void Alert(JsString message) { }
        [JsMethod(Name = "confirm")]
        public bool Confirm(JsString message) { return default(bool); }
        [JsMethod(Name = "prompt")]
        public JsString Prompt(JsString message, JsString defaultValue) { return default(JsString); }
        [JsMethod(Name = "find")]
        public bool Find(JsString str, bool caseSensitive, bool backwards, bool wrap, bool wholeWord, bool searchInFrames, bool showDialog) { return default(bool); }
        [JsMethod(Name = "scrollBy")]
        public void ScrollBy(int x, int y) { }
        [JsMethod(Name = "scrollTo")]
        public void ScrollTo(int x, int y) { }
        [JsMethod(Name = "scroll")]
        public void Scroll(int x, int y) { }
        [JsMethod(Name = "moveBy")]
        public void MoveBy(double x, double y) { }
        [JsMethod(Name = "moveTo")]
        public void MoveTo(double x, double y) { }
        [JsMethod(Name = "resizeBy")]
        public void ResizeBy(double x, double y) { }
        [JsMethod(Name = "resizeTo")]
        public void ResizeTo(double width, double height) { }
        [JsMethod(Name = "matchMedia")]
        public MediaQueryList MatchMedia(JsString query) { return default(MediaQueryList); }
        [JsMethod(Name = "getComputedStyle")]
        public CssStyleDeclaration GetComputedStyle(Element element, JsString pseudoElement) { return default(CssStyleDeclaration); }
        [JsMethod(Name = "getMatchedCSSRules")]
        public CssRuleList GetMatchedCSSRules(Element element, JsString pseudoElement) { return default(CssRuleList); }
        [JsMethod(Name = "postMessage")]
        public void PostMessage(object message, JsString targetOrigin) { }
        [JsMethod(Name = "postMessage")]
        public void PostMessage(object message, JsString targetOrigin, Array messagePorts) { }
        [JsMethod(Name = "setTimeout")]
        public int SetTimeout(JsAction handler, int timeout) { return default(int); }
        [JsMethod(Name = "setTimeout")]
        public int SetTimeout(object handler, int timeout) { return default(int); }
        [JsMethod(Name = "clearTimeout")]
        public void ClearTimeout(int handle) { }
        [JsMethod(Name = "setInterval")]
        public int SetInterval(JsAction handler, int timeout) { return default(int); }
        [JsMethod(Name = "setInterval")]
        public int SetInterval(object handler, int timeout) { return default(int); }
        [JsMethod(Name = "clearInterval")]
        public void ClearInterval(int handle) { }
        [JsMethod(Name = "atob")]
        public JsString AToB(JsString str) { return default(JsString); }
        [JsMethod(Name = "btoa")]
        public JsString BToA(JsString str) { return default(JsString); }

        [JsMethod(Name = "captureEvents")]
        public void CaptureEvents() { }
        [JsMethod(Name = "releaseEvents")]
        public void ReleaseEvents() { }

        #region From StorageInfo
        public StorageInfo StorageInfo { get; private set; }

        //[JsField(Name = "webkitStorageInfo")]
        //[Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        //public StorageInfo WebkitStorageInfo;
        #endregion

        #region From LocalFileSystem
        //[JsMethod(Name = "requestFileSystem", Code = "(requestFileSystem||webkitRequestFileSystem)(type, size, successCallback, errorCallback);")]
        [JsMethod(Name = "requestFileSystem")]
        public void RequestFileSystem(LocalFileSystemType type, ulong size, FileSystemCallback successCallback, FileErrorCallback errorCallback = null) { }

        [JsMethod(Name = "resolveLocalFileSystemURL")]
        public void ResolveLocalFileSystemUrl(JsString url, EntryCallback successCallback, FileErrorCallback errorCallback = null) { }
        //[JsMethod(Name = "webkitRequestFileSystem")]
        //[Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        //public void WebkitRequestFileSystem(ushort type, ulong size, FileSystemCallback successCallback, ErrorCallback errorCallback = null) { }

        //[JsMethod(Name = "WebkitResolveLocalFileSystemURL")]
        //[Obsolete("Methods with the 'webkit' prefix may be deprecated without warning.")]
        //public void WebkitResolveLocalFileSystemUrl(JsString url, EntryCallback successCallback, ErrorCallback errorCallback = null) { }
        #endregion

    }

}