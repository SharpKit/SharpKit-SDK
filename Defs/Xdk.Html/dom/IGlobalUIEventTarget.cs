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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public interface IGlobalUIEventTarget<TEventCurrentTarget, TEventTarget> : IEventTarget<MediaEventType, MediaEvent<TEventCurrentTarget>>,
        IGlobalUIEventTargetWithoutMedia<TEventCurrentTarget, TEventTarget>
    {
        #region Media events
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onLoadStart { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnLoadStart;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onProgress { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnProgress;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onSuspend { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnSuspend;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onAbort { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnAbort;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onEmptied { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnEmptied;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onStalled { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnStalled;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onPlay { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnPlay;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onPause { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnPause;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onLoadedMetadata { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnLoadedMetadata;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onLoadedData { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnLoadedData;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onWaiting { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnWaiting;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onPlaying { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnPlaying;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onCanPlay { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnCanPlay;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onCanPlayThrough { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnCanPlayThrough;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onSeeking { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnSeeking;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onSeeked { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnSeeked;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onTimeUpdate { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnTimeUpdate;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onEnded { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnEnded;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onRateChange { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnRateChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onDurationChange { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnDurationChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onVolumeChange { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnVolumeChange;
        #endregion
    }

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public interface IGlobalUIEventTarget<TEventCurrentTarget> : IEventTarget<MediaEventType, MediaEvent<TEventCurrentTarget>>,
        IGlobalUIEventTargetWithoutMedia<TEventCurrentTarget>
    {
        #region Media events
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onLoadStart { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnLoadStart;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onProgress { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnProgress;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onSuspend { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnSuspend;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onAbort { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnAbort;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onEmptied { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnEmptied;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onStalled { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnStalled;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onPlay { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnPlay;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onPause { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnPause;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onLoadedMetadata { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnLoadedMetadata;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onLoadedData { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnLoadedData;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onWaiting { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnWaiting;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onPlaying { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnPlaying;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onCanPlay { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnCanPlay;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onCanPlayThrough { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnCanPlayThrough;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onSeeking { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnSeeking;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onSeeked { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnSeeked;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onTimeUpdate { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnTimeUpdate;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onEnded { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnEnded;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onRateChange { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnRateChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onDurationChange { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnDurationChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<MediaEvent<TEventCurrentTarget>> onVolumeChange { get; set; }
#endif
        event EventListener<MediaEvent<TEventCurrentTarget>> OnVolumeChange;
        #endregion
    }

}