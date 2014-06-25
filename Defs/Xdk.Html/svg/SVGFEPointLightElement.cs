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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGFEPointLightElement")]
    public partial class SvgFEPointLightElement : SvgElement, IGlobalEventTarget<SvgFEPointLightElement, SvgFEPointLightElement>, IGlobalUIEventTarget<SvgFEPointLightElement, SvgFEPointLightElement>
    {

        #region IGlobalEventTarget
        #region Focus events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onfocus", NativeField = true)]
        public new EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onFocus { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnFocus
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
        public new EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onFocusIn { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnFocusIn
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
        public new EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onFocusOut { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnFocusOut
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
        public new EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onBlur { get; set; }
#endif
        public new event EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnBlur
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"blur\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FocusEventType type, EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FocusEventType type, EventListener<FocusEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onload", NativeField = true)]
        public new EventListener<GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onLoad { get; set; }
#endif
        public new event EventListener<GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnLoad
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
        public new EventListener<GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onScroll { get; set; }
#endif
        public new event EventListener<GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnScroll
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"scroll\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalEventType type, EventListener<GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalEventType type, EventListener<GlobalEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Error event
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public new EventListener<ErrorEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onError { get; set; }
#endif
        public new event EventListener<ErrorEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onLoadStart { get; set; }
#endif
        /// <summary>
        /// The user agent begins looking for media data, as part of the resource selection algorithm.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnLoadStart
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onProgress { get; set; }
#endif
        /// <summary>
        /// The user agent is fetching media data.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnProgress
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onSuspend { get; set; }
#endif
        /// <summary>
        /// The user agent is intentionally not currently fetching media data, but does not have the entire media resource downloaded.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnSuspend
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onAbort { get; set; }
#endif
        /// <summary>
        /// The user agent stops fetching the media data before it is completely downloaded, but not due to an error.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnAbort
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onEmptied { get; set; }
#endif
        /// <summary>
        /// A media element whose networkState was previously not in the NETWORK_EMPTY state has just switched to that state (either because of a fatal error during load that's about to be reported, or because the load() method was invoked while the resource selection algorithm was already running).
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnEmptied
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onStalled { get; set; }
#endif
        /// <summary>
        /// The user agent is trying to fetch media data, but data is unexpectedly not forthcoming.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnStalled
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onPlay { get; set; }
#endif
        /// <summary>
        /// Playback has begun. Fired after the play() method has returned, or when the autoplay attribute has caused playback to begin.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnPlay
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onPause { get; set; }
#endif
        /// <summary>
        /// Playback has been paused. Fired after the pause() method has returned.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnPause
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onLoadedMetadata { get; set; }
#endif
        /// <summary>
        /// The user agent has just determined the duration and dimensions of the media resource.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnLoadedMetadata
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onLoadedData { get; set; }
#endif
        /// <summary>
        /// The user agent can render the media data at the current playback position for the first time.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnLoadedData
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onWaiting { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the next frame is not available, but the user agent expects that frame to become available in due course.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnWaiting
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onPlaying { get; set; }
#endif
        /// <summary>
        /// Playback has started.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnPlaying
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onCanPlay { get; set; }
#endif
        /// <summary>
        /// The user agent can resume playback of the media data, but estimates that if playback were to be started now, the media resource could not be rendered at the current playback rate up to its end without having to stop for further buffering of content.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnCanPlay
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onCanPlayThrough { get; set; }
#endif
        /// <summary>
        /// The user agent estimates that if playback were to be started now, the media resource could be rendered at the current playback rate all the way to its end without having to stop for further buffering.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnCanPlayThrough
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onSeeking { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to true and the seek operation is taking long enough that the user agent has time to fire the event.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnSeeking
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onSeeked { get; set; }
#endif
        /// <summary>
        /// The seeking IDL attribute changed to false.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnSeeked
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onTimeUpdate { get; set; }
#endif
        /// <summary>
        /// The current playback position changed as part of normal playback or in an especially interesting way, for example discontinuously.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnTimeUpdate
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onEnded { get; set; }
#endif
        /// <summary>
        /// Playback has stopped because the end of the media resource was reached.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnEnded
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onRateChange { get; set; }
#endif
        /// <summary>
        /// Either the defaultPlaybackRate or the playbackRate attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnRateChange
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onDurationChange { get; set; }
#endif
        /// <summary>
        /// The duration attribute has just been updated.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnDurationChange
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
        public new EventListener<MediaEvent<SvgFEPointLightElement>> onVolumeChange { get; set; }
#endif
        /// <summary>
        /// Either the volume attribute or the muted attribute has changed. Fired after the relevant attribute's setter has returned.
        /// </summary>
        public new event EventListener<MediaEvent<SvgFEPointLightElement>> OnVolumeChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"volumechange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MediaEventType type, EventListener<MediaEvent<SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MediaEvent<SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MediaEventType type, EventListener<MediaEvent<SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Input events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oninput", NativeField = true)]
        public new EventListener<InputEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onInput { get; set; }
#endif
        public new event EventListener<InputEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnInput
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"input\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(InputEventType type, EventListener<InputEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(InputEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(InputEventType type, EventListener<InputEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Form events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onsubmit", NativeField = true)]
        public new EventListener<FormEvent<SvgFEPointLightElement>> onSubmit { get; set; }
#endif
        public new event EventListener<FormEvent<SvgFEPointLightElement>> OnSubmit
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
        public new EventListener<FormEvent<SvgFEPointLightElement>> onReset { get; set; }
#endif
        public new event EventListener<FormEvent<SvgFEPointLightElement>> OnReset
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"reset\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FormEventType type, EventListener<FormEvent<SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FormEvent<SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FormEventType type, EventListener<FormEvent<SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region UI Global events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onselect", NativeField = true)]
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onSelect { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnSelect
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onCancel { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnCancel
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onSelectionChange { get; set; }
#endif
        /// <summary>
        /// Warning: only for IE
        /// </summary>       
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnSelectionChange
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnChange
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onContextMenu { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnContextMenu
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onCueChange { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnCueChange
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onInvalid { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnInvalid
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onSort { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnSort
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onShow { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnShow
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
        public new EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onClose { get; set; }
#endif
        public new event EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnClose
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(GlobalUIEventType type, EventListener<GlobalUIEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Clipboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncopy", NativeField = true)]
        public new EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnCopy
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
        public new EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnCut
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
        public new EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onPaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnPaste
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
        public new EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onBeforeCopy { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnBeforeCopy
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
        public new EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onBeforeCut { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnBeforeCut
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
        public new EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onBeforePaste { get; set; }
#endif
        public new event EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnBeforePaste
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"beforepaste\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ClipboardEventType type, EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ClipboardEventType type, EventListener<ClipboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Keyboard events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onkeydown", NativeField = true)]
        public new EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onKeyDown { get; set; }
#endif
        public new event EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnKeyDown
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
        public new EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onKeyPress { get; set; }
#endif
        public new event EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnKeyPress
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
        public new EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onKeyUp { get; set; }
#endif
        public new event EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnKeyUp
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"keyup\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(KeyboardEventType type, EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(KeyboardEventType type, EventListener<KeyboardEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Touch events
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ontouchmove", NativeField = true)]
        public new EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onTouchMove { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnTouchMove
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
        public new EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onTouchStart { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnTouchStart
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
        public new EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onTouchEnd { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnTouchEnd
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
        public new EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onTouchCancel { get; set; }
#endif
        public new event EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnTouchCancel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"touchcancel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(TouchEventType type, EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(TouchEventType type, EventListener<TouchEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        #endregion

        #region Mouse events

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onclick", NativeField = true)]
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onClick { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnClick
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDblClick { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDblClick
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseDown { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseDown
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseUp { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseUp
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseOver { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseOver
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseMove { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseMove
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseOut { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseOut
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseEnter
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseLeave
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDrag { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDrag
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDragStart { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDragStart
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDragEnter { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDragEnter
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDragOver { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDragOver
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDragLeave { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDragLeave
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDragEnd { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDragEnd
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onDrop { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnDrop
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
        public new EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onSelectStart { get; set; }
#endif
        public new event EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnSelectStart
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
        public new EventListener<WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onMouseWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnMouseWheel
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
        public new EventListener<WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement>> onWheel { get; set; }
#endif
        public new event EventListener<WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement>> OnWheel
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"wheel\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MouseEventType type, EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MouseEventType type, EventListener<MouseEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(WheelEventType type, EventListener<WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(WheelEventType type, EventListener<WheelEvent<SvgFEPointLightElement, SvgFEPointLightElement>> listener, bool useCapture = false) { }
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

        [JsProperty(Global = true, NativeField = true, Name = "'fepointlight'")]
        public static JsString TAG_NAME { get; private set; }
        [JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('fepointlight')")]
        public SvgFEPointLightElement() { }
        public SvgAnimatedNumber x { get; set; }
        public SvgAnimatedNumber y { get; set; }
        public SvgAnimatedNumber z { get; set; }

        [JsMethod(Global = true, Name = "document.getElementById")]
        public static new SvgFEPointLightElement GetById(JsString elementId) { return default(SvgFEPointLightElement); }
        [JsMethod(Global = true, Name = "document.getElementsByTagName", InsertArg0 = "'fepointlight'")]
        public static JsArray<SvgFEPointLightElement> GetByTagName() { return default(JsArray<SvgFEPointLightElement>); }
        [JsMethod(Global = true, Name = "document.getElementsByTagNameNS", InsertArg0 = "'fepointlight'")]
        public static JsArray<SvgFEPointLightElement> GetByTagNameNS(JsString namespaceURI) { return default(JsArray<SvgFEPointLightElement>); }
    }

}