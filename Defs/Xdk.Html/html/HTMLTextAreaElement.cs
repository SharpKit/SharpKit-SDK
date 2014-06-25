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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "HTMLTextAreaElement")]
    public partial class HtmlTextAreaElement : HtmlElement, IGlobalEventTarget<HtmlTextAreaElement, HtmlTextAreaElement>, IGlobalUIEventTarget<HtmlTextAreaElement, HtmlTextAreaElement>
    {

        #region IGlobalEventTarget
        #region Focus events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onfocus", NativeField = true)]
        public new EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onFocus { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnFocus
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
        public new EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onFocusIn { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnFocusIn
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
        public new EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onFocusOut { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnFocusOut
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
        public new EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onBlur { get; set; }
#endif
        public new event EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnBlur
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FocusEventType type, EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FocusEventType type, EventListener<FocusEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onload", NativeField = true)]
        public new EventListener<GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onLoad { get; set; }
#endif
        public new event EventListener<GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnLoad
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
        public new EventListener<GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onScroll { get; set; }
#endif
        public new event EventListener<GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnScroll
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalEventType type, EventListener<GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalEventType type, EventListener<GlobalEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Error event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public new EventListener<ErrorEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onError { get; set; }
#endif
        public new event EventListener<ErrorEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onLoadStart { get; set; }
#endif
        /// <summary>
        /// The user agent begins looking for media data, as part of the resource selection algorithm.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnLoadStart
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onProgress { get; set; }
#endif
        /// <summary>
        /// The user agent is fetching media data.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnProgress
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onSuspend { get; set; }
#endif
        /// <summary>
        /// The user agent is intentionally not currently fetching media data, but does not have the entire media resource downloaded.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnSuspend
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onAbort { get; set; }
#endif
        /// <summary>
        /// The user agent stops fetching the media data before it is completely downloaded, but not due to an error.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnAbort
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onEmptied { get; set; }
#endif
        /// <summary>
        /// A media element whose networkState was previously not in the NETWORK_EMPTY state has just switched to that state (either because of a fatal error during load that's about to be reported, or because the load() method was invoked while the resource selection algorithm was already running).
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnEmptied
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onStalled { get; set; }
#endif
        /// <summary>
        /// The user agent is trying to fetch media data, but data is unexpectedly not forthcoming.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnStalled
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onPlay { get; set; }
#endif
        /// <summary>
        /// Playback has begun. Fired after the play() method has returned, or when the autoplay attribute has caused playback to begin.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnPlay
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onPause { get; set; }
#endif
        /// <summary>
        /// Playback has been paused. Fired after the pause() method has returned.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnPause
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onLoadedMetadata { get; set; }
#endif
        /// <summary>
        /// The user agent has just determined the duration and dimensions of the media resource.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnLoadedMetadata
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onLoadedData { get; set; }
#endif
        /// <summary>
        /// The user agent can render the media data at the current playback position for the first time.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnLoadedData
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onWaiting { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the next frame is not available, but the user agent expects that frame to become available in due course.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnWaiting
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onPlaying { get; set; }
#endif
        /// <summary>
        /// Playback has started.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnPlaying
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onCanPlay { get; set; }
#endif
        /// <summary>
        /// The user agent can resume playback of the media data, but estimates that if playback were to be started now, the media resource could not be rendered at the current playback rate up to its end without having to stop for further buffering of content.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnCanPlay
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onCanPlayThrough { get; set; }
#endif
        /// <summary>
        /// The user agent estimates that if playback were to be started now, the media resource could be rendered at the current playback rate all the way to its end without having to stop for further buffering.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnCanPlayThrough
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onSeeking { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to true and the seek operation is taking long enough that the user agent has time to fire the event.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnSeeking
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onSeeked { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to false.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnSeeked
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onTimeUpdate { get; set; }
#endif
        /// <summary>
        /// The current playback position changed as part of normal playback or in an especially interesting way, for example discontinuously.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnTimeUpdate
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onEnded { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the end of the media resource was reached.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnEnded
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onRateChange { get; set; }
#endif
        /// <summary>
        /// Either the defaultPlaybackRate or the playbackRate attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnRateChange
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onDurationChange { get; set; }
#endif
        /// <summary>
        /// The duration attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnDurationChange
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
        public new EventListener<MediaEvent<HtmlTextAreaElement>> onVolumeChange { get; set; }
#endif
        /// <summary>
        /// Either the volume attribute or the muted attribute has changed. Fired after the relevant attribute's setter has returned.
        /// </summary>
        public new event EventListener<MediaEvent<HtmlTextAreaElement>> OnVolumeChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MediaEventType type, EventListener<MediaEvent<HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MediaEvent<HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MediaEventType type, EventListener<MediaEvent<HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Input events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oninput", NativeField = true)]
        public new EventListener<InputEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onInput { get; set; }
#endif
        public new event EventListener<InputEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnInput
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(InputEventType type, EventListener<InputEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(InputEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(InputEventType type, EventListener<InputEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Form events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsubmit", NativeField = true)]
        public new EventListener<FormEvent<HtmlTextAreaElement>> onSubmit { get; set; }
#endif
        public new event EventListener<FormEvent<HtmlTextAreaElement>> OnSubmit
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
        public new EventListener<FormEvent<HtmlTextAreaElement>> onReset { get; set; }
#endif
        public new event EventListener<FormEvent<HtmlTextAreaElement>> OnReset
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FormEventType type, EventListener<FormEvent<HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FormEvent<HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FormEventType type, EventListener<FormEvent<HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region UI Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onselect", NativeField = true)]
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onSelect { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnSelect
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onCancel { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnCancel
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onSelectionChange { get; set; }
#endif
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnSelectionChange
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnChange
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onContextMenu { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnContextMenu
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onCueChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnCueChange
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onInvalid { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnInvalid
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onSort { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnSort
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onShow { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnShow
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
        public new EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onClose { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnClose
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Clipboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncopy", NativeField = true)]
        public new EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnCopy
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
        public new EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnCut
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
        public new EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onPaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnPaste
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
        public new EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onBeforeCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnBeforeCopy
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
        public new EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onBeforeCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnBeforeCut
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
        public new EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onBeforePaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnBeforePaste
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ClipboardEventType type, EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ClipboardEventType type, EventListener<ClipboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Keyboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onkeydown", NativeField = true)]
        public new EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onKeyDown { get; set; }
#endif
        public new event EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnKeyDown
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
        public new EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onKeyPress { get; set; }
#endif
        public new event EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnKeyPress
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
        public new EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onKeyUp { get; set; }
#endif
        public new event EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnKeyUp
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(KeyboardEventType type, EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(KeyboardEventType type, EventListener<KeyboardEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Touch events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchmove", NativeField = true)]
        public new EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onTouchMove { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnTouchMove
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
        public new EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onTouchStart { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnTouchStart
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
        public new EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onTouchEnd { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnTouchEnd
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
        public new EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onTouchCancel { get; set; }
#endif
        public new event EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnTouchCancel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(TouchEventType type, EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(TouchEventType type, EventListener<TouchEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        #endregion

        #region Mouse events

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onclick", NativeField = true)]
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onClick { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnClick
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDblClick { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDblClick
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseDown { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseDown
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseUp { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseUp
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseOver { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseOver
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseMove { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseMove
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseOut { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseOut
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseEnter
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseLeave
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDrag { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDrag
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDragStart { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDragStart
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDragEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDragEnter
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDragOver { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDragOver
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDragLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDragLeave
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDragEnd { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDragEnd
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onDrop { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnDrop
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
        public new EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onSelectStart { get; set; }
#endif
        public new event EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnSelectStart
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
        public new EventListener<WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onMouseWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnMouseWheel
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
        public new EventListener<WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement>> onWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement>> OnWheel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MouseEventType type, EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MouseEventType type, EventListener<MouseEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(WheelEventType type, EventListener<WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(WheelEventType type, EventListener<WheelEvent<HtmlTextAreaElement, HtmlTextAreaElement>> listener, bool useCapture = false) { }
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

        [JsProperty(Global = true, NativeField = true, Name = "'textarea'")]
        public static JsString TAG_NAME { get; private set; }
        [JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('textarea')")]
        public HtmlTextAreaElement() { }
        public bool autofocus { get; set; }
        public int cols { get; set; }
        public JsString dirName { get; set; }
        public bool disabled { get; set; }
        public HtmlFormElement form { get; set; }
        public int maxLength { get; set; }
        public JsString name { get; set; }
        public JsString placeholder { get; set; }
        public bool @readOnly { get; set; }
        public bool required { get; set; }
        public int rows { get; set; }
        public JsString wrap { get; set; }
        public JsString type { get; set; }
        public JsString defaultValue { get; set; }
        public JsString value { get; set; }
        public int textLength { get; set; }
        public bool willValidate { get; set; }
        public ValidityState validity { get; set; }
        public JsString validationMessage { get; set; }


        [JsMethod(Name = "checkValidity")]
        public bool CheckValidity() { return default(bool); }
        [JsMethod(Name = "setCustomValidity")]
        public void SetCustomValidity(JsString error) { }
        public NodeList labels { get; set; }
        public int selectionStart { get; set; }
        public int selectionEnd { get; set; }
        public JsString selectionDirection { get; set; }
        [JsMethod(Name = "setRangeText")]
        public void SetRangeText(JsString replacement) { }
        [JsMethod(Name = "setRangeText")]
        public void SetRangeText(JsString replacement, int start, int end, JsString selectionMode) { }
        [JsMethod(Name = "setSelectionRange")]
        public void SetSelectionRange(int start, int end) { }
        [JsMethod(Name = "setSelectionRange")]
        public void SetSelectionRange(int start, int end, JsString direction) { }

        [JsMethod(Global = true, Name = "document.getElementById")]
        public static new HtmlTextAreaElement GetById(JsString elementId) { return default(HtmlTextAreaElement); }
        [JsMethod(Global = true, Name = "document.getElementsByTagName", InsertArg0 = "'textarea'")]
        public static JsArray<HtmlTextAreaElement> GetByTagName() { return default(JsArray<HtmlTextAreaElement>); }
        [JsMethod(Global = true, Name = "document.getElementsByTagNameNS", InsertArg0 = "'textarea'")]
        public static JsArray<HtmlTextAreaElement> GetByTagNameNS(JsString namespaceURI) { return default(JsArray<HtmlTextAreaElement>); }
    }

}