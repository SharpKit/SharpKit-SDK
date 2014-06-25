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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "HTMLCanvasElement")]
    public partial class HtmlCanvasElement : HtmlElement, IGlobalEventTarget<HtmlCanvasElement, HtmlCanvasElement>, IGlobalUIEventTarget<HtmlCanvasElement, HtmlCanvasElement>
    {

        #region IGlobalEventTarget
        #region Focus events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onfocus", NativeField = true)]
        public new EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> onFocus { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> OnFocus
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"focus\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"focus\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onfocusin", NativeField = true)]
        public new EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> onFocusIn { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> OnFocusIn
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"focusin\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"focusin\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onfocusin", NativeField = true)]
        public new EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> onFocusOut { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> OnFocusOut
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"focusin\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"focusin\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onblur", NativeField = true)]
        public new EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> onBlur { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> OnBlur
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FocusEventType type, EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FocusEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FocusEventType type, EventListener<FocusEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onload", NativeField = true)]
        public new EventListener<GlobalEvent<HtmlCanvasElement, HtmlCanvasElement>> onLoad { get; set; }
#endif
        public new event EventListener<GlobalEvent<HtmlCanvasElement, HtmlCanvasElement>> OnLoad
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"load\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"load\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onscroll", NativeField = true)]
        public new EventListener<GlobalEvent<HtmlCanvasElement, HtmlCanvasElement>> onScroll { get; set; }
#endif
        public new event EventListener<GlobalEvent<HtmlCanvasElement, HtmlCanvasElement>> OnScroll
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalEventType type, EventListener<GlobalEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalEventType type, EventListener<GlobalEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Error event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public new EventListener<ErrorEvent<HtmlCanvasElement, HtmlCanvasElement>> onError { get; set; }
#endif
        public new event EventListener<ErrorEvent<HtmlCanvasElement, HtmlCanvasElement>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion
        #endregion

        #region inherited IGlobalEventTarget to hide
        #region Focus events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(FocusEventType type, EventListener<FocusEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(FocusEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(FocusEventType type, EventListener<FocusEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Global events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(GlobalEventType type, EventListener<GlobalEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(GlobalEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(GlobalEventType type, EventListener<GlobalEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Error event
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<HtmlElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(ErrorEvent<HtmlElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion
        #endregion

        #region IGlobalUIEventTarget
        #region Media events
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent begins looking for media data, as part of the resource selection algorithm.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadstart", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onLoadStart { get; set; }
#endif
        /// <summary>
        /// The user agent begins looking for media data, as part of the resource selection algorithm.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnLoadStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent is fetching media data.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onprogress", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onProgress { get; set; }
#endif
        /// <summary>
        /// The user agent is fetching media data.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnProgress
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent is intentionally not currently fetching media data, but does not have the entire media resource downloaded.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsuspend", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onSuspend { get; set; }
#endif
        /// <summary>
        /// The user agent is intentionally not currently fetching media data, but does not have the entire media resource downloaded.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnSuspend
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"suspend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"suspend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent stops fetching the media data before it is completely downloaded, but not due to an error.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onabort", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onAbort { get; set; }
#endif
        /// <summary>
        /// The user agent stops fetching the media data before it is completely downloaded, but not due to an error.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnAbort
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"abort\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"abort\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// A media element whose networkState was previously not in the NETWORK_EMPTY state has just switched to that state (either because of a fatal error during load that's about to be reported, or because the load() method was invoked while the resource selection algorithm was already running).
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onemptied", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onEmptied { get; set; }
#endif
        /// <summary>
        /// A media element whose networkState was previously not in the NETWORK_EMPTY state has just switched to that state (either because of a fatal error during load that's about to be reported, or because the load() method was invoked while the resource selection algorithm was already running).
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnEmptied
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"emptied\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"emptied\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent is trying to fetch media data, but data is unexpectedly not forthcoming.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onstalled", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onStalled { get; set; }
#endif
        /// <summary>
        /// The user agent is trying to fetch media data, but data is unexpectedly not forthcoming.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnStalled
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"stalled\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"stalled\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Playback has begun. Fired after the play() method has returned, or when the autoplay attribute has caused playback to begin.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onplay", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onPlay { get; set; }
#endif
        /// <summary>
        /// Playback has begun. Fired after the play() method has returned, or when the autoplay attribute has caused playback to begin.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnPlay
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"play\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"play\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Playback has been paused. Fired after the pause() method has returned.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onpause", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onPause { get; set; }
#endif
        /// <summary>
        /// Playback has been paused. Fired after the pause() method has returned.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnPause
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"pause\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"pause\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent has just determined the duration and dimensions of the media resource.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadedmetadata", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onLoadedMetadata { get; set; }
#endif
        /// <summary>
        /// The user agent has just determined the duration and dimensions of the media resource.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnLoadedMetadata
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadedmetadata\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadedmetadata\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent can render the media data at the current playback position for the first time.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadeddata", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onLoadedData { get; set; }
#endif
        /// <summary>
        /// The user agent can render the media data at the current playback position for the first time.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnLoadedData
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadeddata\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadeddata\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Playback has stopped because the next frame is not available, but the user agent expects that frame to become available in due course.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onwaiting", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onWaiting { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the next frame is not available, but the user agent expects that frame to become available in due course.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnWaiting
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"waiting\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"waiting\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Playback has started.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onplaying", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onPlaying { get; set; }
#endif
        /// <summary>
        /// Playback has started.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnPlaying
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"playing\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"playing\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent can resume playback of the media data, but estimates that if playback were to be started now, the media resource could not be rendered at the current playback rate up to its end without having to stop for further buffering of content.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncanplay", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onCanPlay { get; set; }
#endif
        /// <summary>
        /// The user agent can resume playback of the media data, but estimates that if playback were to be started now, the media resource could not be rendered at the current playback rate up to its end without having to stop for further buffering of content.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnCanPlay
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"canplay\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"canplay\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The user agent estimates that if playback were to be started now, the media resource could be rendered at the current playback rate all the way to its end without having to stop for further buffering.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncanplaythrough", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onCanPlayThrough { get; set; }
#endif
        /// <summary>
        /// The user agent estimates that if playback were to be started now, the media resource could be rendered at the current playback rate all the way to its end without having to stop for further buffering.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnCanPlayThrough
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"canplaythrough\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"canplaythrough\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The seeking IDL attribute changed to true and the seek operation is taking long enough that the user agent has time to fire the event.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onseeking", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onSeeking { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to true and the seek operation is taking long enough that the user agent has time to fire the event.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnSeeking
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"seeking\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"seeking\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The seeking IDL attribute changed to false.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onseeked", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onSeeked { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to false.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnSeeked
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"seeked\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"seeked\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The current playback position changed as part of normal playback or in an especially interesting way, for example discontinuously.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontimeupdate", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onTimeUpdate { get; set; }
#endif
        /// <summary>
        /// The current playback position changed as part of normal playback or in an especially interesting way, for example discontinuously.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnTimeUpdate
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"timeupdate\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"timeupdate\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Playback has stopped because the end of the media resource was reached.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onEnded", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onEnded { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the end of the media resource was reached.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnEnded
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"Ended\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"Ended\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Either the defaultPlaybackRate or the playbackRate attribute has just been updated.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onratechange", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onRateChange { get; set; }
#endif
        /// <summary>
        /// Either the defaultPlaybackRate or the playbackRate attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnRateChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"ratechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"ratechange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// The duration attribute has just been updated.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondurationchange", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onDurationChange { get; set; }
#endif
        /// <summary>
        /// The duration attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnDurationChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"durationchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"durationchange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Either the volume attribute or the muted attribute has changed. Fired after the relevant attribute's setter has returned.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onvolumechange", NativeField = true)]
        public new EventListener<MediaEvent<HtmlCanvasElement>> onVolumeChange { get; set; }
#endif
        /// <summary>
        /// Either the volume attribute or the muted attribute has changed. Fired after the relevant attribute's setter has returned.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlCanvasElement>> OnVolumeChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MediaEventType type, EventListener<MediaEvent<HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MediaEvent<HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MediaEventType type, EventListener<MediaEvent<HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Input events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oninput", NativeField = true)]
        public new EventListener<InputEvent<HtmlCanvasElement, HtmlCanvasElement>> onInput { get; set; }
#endif
        public new event EventListener<InputEvent<HtmlCanvasElement, HtmlCanvasElement>> OnInput
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(InputEventType type, EventListener<InputEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(InputEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(InputEventType type, EventListener<InputEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Form events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsubmit", NativeField = true)]
        public new EventListener<FormEvent<HtmlCanvasElement>> onSubmit { get; set; }
#endif
        public new event EventListener<FormEvent<HtmlCanvasElement>> OnSubmit
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"submit\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"submit\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onreset", NativeField = true)]
        public new EventListener<FormEvent<HtmlCanvasElement>> onReset { get; set; }
#endif
        public new event EventListener<FormEvent<HtmlCanvasElement>> OnReset
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FormEventType type, EventListener<FormEvent<HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FormEvent<HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FormEventType type, EventListener<FormEvent<HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region UI Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onselect", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onSelect { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnSelect
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"select\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"select\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncancel", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onCancel { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnCancel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"cancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"cancel\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onselectionchange", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onSelectionChange { get; set; }
#endif
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnSelectionChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"selectionchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"selectionchange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onchange", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"change\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"change\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncontextmenu", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onContextMenu { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnContextMenu
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"contextmenu\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"contextmenu\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncuechange", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onCueChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnCueChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"cuechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"cuechange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oninvalid", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onInvalid { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnInvalid
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"invalid\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"invalid\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsort", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onSort { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnSort
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"sort\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"sort\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onshow", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onShow { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnShow
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"show\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"show\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onclose", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> onClose { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> OnClose
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Clipboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncopy", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnCopy
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"copy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"copy\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncut", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnCut
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"cut\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"cut\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onpaste", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onPaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnPaste
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"paste\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"paste\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onbeforecopy", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onBeforeCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnBeforeCopy
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforecopy\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforecopy\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onbeforecut", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onBeforeCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnBeforeCut
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforecut\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforecut\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onbeforepaste", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onBeforePaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnBeforePaste
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ClipboardEventType type, EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ClipboardEventType type, EventListener<ClipboardEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Keyboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onkeydown", NativeField = true)]
        public new EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onKeyDown { get; set; }
#endif
        public new event EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnKeyDown
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"keydown\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"keydown\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onkeypress", NativeField = true)]
        public new EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onKeyPress { get; set; }
#endif
        public new event EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnKeyPress
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"keypress\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"keypress\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onkeyup", NativeField = true)]
        public new EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> onKeyUp { get; set; }
#endif
        public new event EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> OnKeyUp
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(KeyboardEventType type, EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(KeyboardEventType type, EventListener<KeyboardEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Touch events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchmove", NativeField = true)]
        public new EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> onTouchMove { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> OnTouchMove
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchmove\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchmove\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchstart", NativeField = true)]
        public new EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> onTouchStart { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> OnTouchStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchend", NativeField = true)]
        public new EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> onTouchEnd { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> OnTouchEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchcancel", NativeField = true)]
        public new EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> onTouchCancel { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> OnTouchCancel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(TouchEventType type, EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(TouchEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(TouchEventType type, EventListener<TouchEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion

        #region Mouse events

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onclick", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onClick { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnClick
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"click\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"click\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondblclick", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDblClick { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDblClick
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dblclick\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dblclick\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmousedown", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseDown { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseDown
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mousedown\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mousedown\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmouseup", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseUp { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseUp
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mouseup\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mouseup\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmouseover", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseOver { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseOver
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mouseover\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mouseover\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmousemove", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseMove { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseMove
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mousemove\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mousemove\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmouseout", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseOut { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseOut
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mouseout\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mouseout\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmouseenter", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseEnter
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mouseenter\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mouseenter\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmouseleave", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseLeave
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mouseleave\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mouseleave\"", InsertArg1 = "false")]
            remove { }
        }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondrag", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDrag { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDrag
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"drag\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"drag\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondragstart", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDragStart { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDragStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dragstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dragstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondragenter", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDragEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDragEnter
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dragenter\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dragenter\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondragover", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDragOver { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDragOver
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dragover\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dragover\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondragleave", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDragLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDragLeave
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dragleave\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dragleave\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondragend", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDragEnd { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDragEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dragend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dragend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondrop", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onDrop { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnDrop
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"drop\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"drop\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onselectstart", NativeField = true)]
        public new EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> onSelectStart { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> OnSelectStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"selectstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"selectstart\"", InsertArg1 = "false")]
            remove { }
        }


#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmousewheel", NativeField = true)]
        public new EventListener<WheelEvent<HtmlCanvasElement, HtmlCanvasElement>> onMouseWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<HtmlCanvasElement, HtmlCanvasElement>> OnMouseWheel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"mousewheel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"mousewheel\"", InsertArg1 = "false")]
            remove { }
        }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onwheel", NativeField = true)]
        public new EventListener<WheelEvent<HtmlCanvasElement, HtmlCanvasElement>> onWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<HtmlCanvasElement, HtmlCanvasElement>> OnWheel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MouseEventType type, EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MouseEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MouseEventType type, EventListener<MouseEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(WheelEventType type, EventListener<WheelEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(WheelEvent<HtmlCanvasElement, HtmlCanvasElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(WheelEventType type, EventListener<WheelEvent<HtmlCanvasElement, HtmlCanvasElement>> listener, bool useCapture = false) { }
        #endregion


        #endregion

        #region inherited IGlobalUIEventTarget to hide
        #region Media events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(MediaEventType type, EventListener<MediaEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(MediaEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(MediaEventType type, EventListener<MediaEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Input events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(InputEventType type, EventListener<InputEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(InputEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(InputEventType type, EventListener<InputEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Form events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(FormEventType type, EventListener<FormEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(FormEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(FormEventType type, EventListener<FormEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region UI Global events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(GlobalUIEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Clipboard events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(ClipboardEventType type, EventListener<ClipboardEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(ClipboardEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(ClipboardEventType type, EventListener<ClipboardEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Keyboard events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(KeyboardEventType type, EventListener<KeyboardEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(KeyboardEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(KeyboardEventType type, EventListener<KeyboardEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Touch events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(TouchEventType type, EventListener<TouchEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(TouchEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(TouchEventType type, EventListener<TouchEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion

        #region Mouse events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(MouseEventType type, EventListener<MouseEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(MouseEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(MouseEventType type, EventListener<MouseEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(WheelEventType type, EventListener<WheelEvent<HtmlElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(WheelEvent<HtmlElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(WheelEventType type, EventListener<WheelEvent<HtmlElement>> listener, bool useCapture = false) { }
        #endregion


        #endregion

        /// <summary>
        /// The width of the canvas element.
        /// </summary>
        public long width { get; set; }
        /// <summary>
        /// The height of the canvas element.
        /// </summary>
        public long height { get; set; }
        [JsProperty(Global = true, NativeField = true, Name = "'canvas'")]
        public static JsString TAG_NAME { get; private set; }
        [JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('canvas')")]
        public HtmlCanvasElement() { }
        [JsMethod(Name = "toDataURL")]
        public JsString ToDataURL(JsString type) { return default(JsString); }
        /// <summary>
        /// Returns an object that exposes an API for 2D drawing on the canvas.
        /// </summary>
        /// <returns>CanvasRenderingContext2D object</returns>
        [JsMethod(Name = "getContext", InsertArg0 = "\"2d\"")]
        public CanvasRenderingContext2D GetContext2D() { return default(CanvasRenderingContext2D); }
        /// <summary>
        /// Returns an object that exposes an API for WebGL drawing on the canvas.
        /// </summary>
        /// <returns>WebGLRenderingContext object</returns>
        [JsMethod(Name = "getContext", InsertArg0 = "\"webgl\"")]
        public WebGLRenderingContext GetContextWebGL() { return default(WebGLRenderingContext); }
        /*
                [JsMethod(Name = "getContext")]
                public CanvasRenderingContext GetContext(CanvasRenderingContextApi contextId) { return default(CanvasRenderingContext); }
         */

        [JsMethod(Global = true, Name = "document.getElementById")]
        public static new HtmlCanvasElement GetById(JsString elementId) { return default(HtmlCanvasElement); }
        [JsMethod(Global = true, Name = "document.getElementsByTagName", InsertArg0 = "'canvas'")]
        public static JsArray<HtmlCanvasElement> GetByTagName() { return default(JsArray<HtmlCanvasElement>); }
        [JsMethod(Global = true, Name = "document.getElementsByTagNameNS", InsertArg0 = "'canvas'")]
        public static JsArray<HtmlCanvasElement> GetByTagNameNS(JsString namespaceURI) { return default(JsArray<HtmlCanvasElement>); }
    }

}