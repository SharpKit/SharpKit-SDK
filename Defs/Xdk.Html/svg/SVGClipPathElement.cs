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

namespace SharpKit.DotNet.Html.svg
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGClipPathElement")]
    public partial class SvgClipPathElement : SvgElement, IGlobalEventTarget<SvgClipPathElement, SvgClipPathElement>, IGlobalUIEventTarget<SvgClipPathElement, SvgClipPathElement>, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgTransformable
    {

        #region IGlobalEventTarget
        #region Focus events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onfocus", NativeField = true)]
        public new EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> onFocus { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> OnFocus
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
        public new EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> onFocusIn { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> OnFocusIn
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
        public new EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> onFocusOut { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> OnFocusOut
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
        public new EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> onBlur { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> OnBlur
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FocusEventType type, EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FocusEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FocusEventType type, EventListener<FocusEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onload", NativeField = true)]
        public new EventListener<GlobalEvent<SvgClipPathElement, SvgClipPathElement>> onLoad { get; set; }
#endif
        public new event EventListener<GlobalEvent<SvgClipPathElement, SvgClipPathElement>> OnLoad
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
        public new EventListener<GlobalEvent<SvgClipPathElement, SvgClipPathElement>> onScroll { get; set; }
#endif
        public new event EventListener<GlobalEvent<SvgClipPathElement, SvgClipPathElement>> OnScroll
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalEventType type, EventListener<GlobalEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalEventType type, EventListener<GlobalEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Error event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public new EventListener<ErrorEvent<SvgClipPathElement, SvgClipPathElement>> onError { get; set; }
#endif
        public new event EventListener<ErrorEvent<SvgClipPathElement, SvgClipPathElement>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion
        #endregion

        #region inherited IGlobalEventTarget to hide
        #region Focus events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(FocusEventType type, EventListener<FocusEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(FocusEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(FocusEventType type, EventListener<FocusEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Global events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(GlobalEventType type, EventListener<GlobalEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(GlobalEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(GlobalEventType type, EventListener<GlobalEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Error event
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<SvgElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(ErrorEvent<SvgElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<SvgElement>> listener, bool useCapture = false) { }
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onLoadStart { get; set; }
#endif
        /// <summary>
        /// The user agent begins looking for media data, as part of the resource selection algorithm.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnLoadStart
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onProgress { get; set; }
#endif
        /// <summary>
        /// The user agent is fetching media data.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnProgress
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onSuspend { get; set; }
#endif
        /// <summary>
        /// The user agent is intentionally not currently fetching media data, but does not have the entire media resource downloaded.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnSuspend
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onAbort { get; set; }
#endif
        /// <summary>
        /// The user agent stops fetching the media data before it is completely downloaded, but not due to an error.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnAbort
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onEmptied { get; set; }
#endif
        /// <summary>
        /// A media element whose networkState was previously not in the NETWORK_EMPTY state has just switched to that state (either because of a fatal error during load that's about to be reported, or because the load() method was invoked while the resource selection algorithm was already running).
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnEmptied
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onStalled { get; set; }
#endif
        /// <summary>
        /// The user agent is trying to fetch media data, but data is unexpectedly not forthcoming.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnStalled
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onPlay { get; set; }
#endif
        /// <summary>
        /// Playback has begun. Fired after the play() method has returned, or when the autoplay attribute has caused playback to begin.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnPlay
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onPause { get; set; }
#endif
        /// <summary>
        /// Playback has been paused. Fired after the pause() method has returned.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnPause
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onLoadedMetadata { get; set; }
#endif
        /// <summary>
        /// The user agent has just determined the duration and dimensions of the media resource.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnLoadedMetadata
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onLoadedData { get; set; }
#endif
        /// <summary>
        /// The user agent can render the media data at the current playback position for the first time.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnLoadedData
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onWaiting { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the next frame is not available, but the user agent expects that frame to become available in due course.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnWaiting
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onPlaying { get; set; }
#endif
        /// <summary>
        /// Playback has started.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnPlaying
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onCanPlay { get; set; }
#endif
        /// <summary>
        /// The user agent can resume playback of the media data, but estimates that if playback were to be started now, the media resource could not be rendered at the current playback rate up to its end without having to stop for further buffering of content.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnCanPlay
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onCanPlayThrough { get; set; }
#endif
        /// <summary>
        /// The user agent estimates that if playback were to be started now, the media resource could be rendered at the current playback rate all the way to its end without having to stop for further buffering.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnCanPlayThrough
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onSeeking { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to true and the seek operation is taking long enough that the user agent has time to fire the event.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnSeeking
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onSeeked { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to false.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnSeeked
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onTimeUpdate { get; set; }
#endif
        /// <summary>
        /// The current playback position changed as part of normal playback or in an especially interesting way, for example discontinuously.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnTimeUpdate
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onEnded { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the end of the media resource was reached.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnEnded
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onRateChange { get; set; }
#endif
        /// <summary>
        /// Either the defaultPlaybackRate or the playbackRate attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnRateChange
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onDurationChange { get; set; }
#endif
        /// <summary>
        /// The duration attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnDurationChange
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
        public new EventListener<MediaEvent<SvgClipPathElement>> onVolumeChange { get; set; }
#endif
        /// <summary>
        /// Either the volume attribute or the muted attribute has changed. Fired after the relevant attribute's setter has returned.
        /// </summary>
        public new event EventListener<MediaEvent<SvgClipPathElement>> OnVolumeChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MediaEventType type, EventListener<MediaEvent<SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MediaEvent<SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MediaEventType type, EventListener<MediaEvent<SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Input events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oninput", NativeField = true)]
        public new EventListener<InputEvent<SvgClipPathElement, SvgClipPathElement>> onInput { get; set; }
#endif
        public new event EventListener<InputEvent<SvgClipPathElement, SvgClipPathElement>> OnInput
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(InputEventType type, EventListener<InputEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(InputEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(InputEventType type, EventListener<InputEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Form events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsubmit", NativeField = true)]
        public new EventListener<FormEvent<SvgClipPathElement>> onSubmit { get; set; }
#endif
        public new event EventListener<FormEvent<SvgClipPathElement>> OnSubmit
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
        public new EventListener<FormEvent<SvgClipPathElement>> onReset { get; set; }
#endif
        public new event EventListener<FormEvent<SvgClipPathElement>> OnReset
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FormEventType type, EventListener<FormEvent<SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FormEvent<SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FormEventType type, EventListener<FormEvent<SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region UI Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onselect", NativeField = true)]
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onSelect { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnSelect
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onCancel { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnCancel
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onSelectionChange { get; set; }
#endif
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnSelectionChange
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnChange
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onContextMenu { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnContextMenu
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onCueChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnCueChange
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onInvalid { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnInvalid
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onSort { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnSort
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onShow { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnShow
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
        public new EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> onClose { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> OnClose
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalUIEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Clipboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncopy", NativeField = true)]
        public new EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> onCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> OnCopy
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
        public new EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> onCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> OnCut
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
        public new EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> onPaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> OnPaste
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
        public new EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> onBeforeCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> OnBeforeCopy
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
        public new EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> onBeforeCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> OnBeforeCut
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
        public new EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> onBeforePaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> OnBeforePaste
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ClipboardEventType type, EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ClipboardEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ClipboardEventType type, EventListener<ClipboardEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Keyboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onkeydown", NativeField = true)]
        public new EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> onKeyDown { get; set; }
#endif
        public new event EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> OnKeyDown
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
        public new EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> onKeyPress { get; set; }
#endif
        public new event EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> OnKeyPress
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
        public new EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> onKeyUp { get; set; }
#endif
        public new event EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> OnKeyUp
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(KeyboardEventType type, EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(KeyboardEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(KeyboardEventType type, EventListener<KeyboardEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Touch events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchmove", NativeField = true)]
        public new EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> onTouchMove { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> OnTouchMove
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
        public new EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> onTouchStart { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> OnTouchStart
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
        public new EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> onTouchEnd { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> OnTouchEnd
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
        public new EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> onTouchCancel { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> OnTouchCancel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(TouchEventType type, EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(TouchEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(TouchEventType type, EventListener<TouchEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion

        #region Mouse events

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onclick", NativeField = true)]
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onClick { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnClick
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDblClick { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDblClick
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseDown { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseDown
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseUp { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseUp
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseOver { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseOver
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseMove { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseMove
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseOut { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseOut
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseEnter
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onMouseLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseLeave
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDrag { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDrag
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDragStart { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDragStart
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDragEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDragEnter
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDragOver { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDragOver
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDragLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDragLeave
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDragEnd { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDragEnd
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onDrop { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnDrop
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
        public new EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> onSelectStart { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> OnSelectStart
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
        public new EventListener<WheelEvent<SvgClipPathElement, SvgClipPathElement>> onMouseWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<SvgClipPathElement, SvgClipPathElement>> OnMouseWheel
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
        public new EventListener<WheelEvent<SvgClipPathElement, SvgClipPathElement>> onWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<SvgClipPathElement, SvgClipPathElement>> OnWheel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MouseEventType type, EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MouseEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MouseEventType type, EventListener<MouseEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(WheelEventType type, EventListener<WheelEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(WheelEvent<SvgClipPathElement, SvgClipPathElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(WheelEventType type, EventListener<WheelEvent<SvgClipPathElement, SvgClipPathElement>> listener, bool useCapture = false) { }
        #endregion


        #endregion

        #region inherited IGlobalUIEventTarget to hide
        #region Media events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(MediaEventType type, EventListener<MediaEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(MediaEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(MediaEventType type, EventListener<MediaEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Input events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(InputEventType type, EventListener<InputEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(InputEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(InputEventType type, EventListener<InputEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Form events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(FormEventType type, EventListener<FormEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(FormEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(FormEventType type, EventListener<FormEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region UI Global events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(GlobalUIEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Clipboard events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(ClipboardEventType type, EventListener<ClipboardEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(ClipboardEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(ClipboardEventType type, EventListener<ClipboardEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Keyboard events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(KeyboardEventType type, EventListener<KeyboardEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(KeyboardEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(KeyboardEventType type, EventListener<KeyboardEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Touch events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(TouchEventType type, EventListener<TouchEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(TouchEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(TouchEventType type, EventListener<TouchEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion

        #region Mouse events
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(MouseEventType type, EventListener<MouseEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(MouseEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(MouseEventType type, EventListener<MouseEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(WheelEventType type, EventListener<WheelEvent<SvgElement>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(WheelEvent<SvgElement> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(WheelEventType type, EventListener<WheelEvent<SvgElement>> listener, bool useCapture = false) { }
        #endregion


        #endregion

        [JsProperty(Global = true, NativeField = true, Name = "'clippath'")]
        public static JsString TAG_NAME { get; private set; }
        [JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('clippath')")]
        public SvgClipPathElement() { }
        public SvgAnimatedEnumeration<SvgUnitTypesEnum> clipPathUnits { get; set; }
        public SvgStringList requiredFeatures { get; set; }
        public SvgStringList requiredExtensions { get; set; }
        public SvgStringList systemLanguage { get; set; }
        [JsMethod(Name = "hasExtension")]
        public bool HasExtension(JsString extension) { return default(bool); }
        public JsString xmllang { get; set; }
        public JsString xmlspace { get; set; }
        public SvgAnimatedBoolean externalResourcesRequired { get; set; }
        [JsMethod(Name = "getPresentationAttribute")]
        public CssValue GetPresentationAttribute(JsString name) { return default(CssValue); }
        public SvgAnimatedTransformList transform { get; set; }
        public SvgElement nearestViewportElement { get; set; }
        public SvgElement farthestViewportElement { get; set; }
        [JsMethod(Name = "getBBox")]
        public SvgRect GetBBox() { return default(SvgRect); }
        [JsMethod(Name = "getCTM")]
        public SvgMatrix GetCTM() { return default(SvgMatrix); }
        [JsMethod(Name = "getScreenCTM")]
        public SvgMatrix GetScreenCTM() { return default(SvgMatrix); }
        [JsMethod(Name = "getTransformToElement")]
        public SvgMatrix GetTransformToElement(SvgElement element) { return default(SvgMatrix); }

        [JsMethod(Global = true, Name = "document.getElementById")]
        public static new SvgClipPathElement GetById(JsString elementId) { return default(SvgClipPathElement); }
        [JsMethod(Global = true, Name = "document.getElementsByTagName", InsertArg0 = "'clippath'")]
        public static JsArray<SvgClipPathElement> GetByTagName() { return default(JsArray<SvgClipPathElement>); }
        [JsMethod(Global = true, Name = "document.getElementsByTagNameNS", InsertArg0 = "'clippath'")]
        public static JsArray<SvgClipPathElement> GetByTagNameNS(JsString namespaceURI) { return default(JsArray<SvgClipPathElement>); }
    }
}