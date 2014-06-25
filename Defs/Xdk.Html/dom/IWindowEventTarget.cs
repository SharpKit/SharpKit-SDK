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
    public interface IWindowEventTarget<TEventCurrentTarget, TEventTarget> :
        IEventTarget<WindowEventType, WindowEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<HashChangeEventType, HashChangeEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<MessageEventType, MessageEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<PopStateEventType, PopStateEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<PageTransitionEventType, PageTransitionEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<StorageEventType, StorageEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<DeviceMotionEventType, DeviceMotionEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<DeviceOrientationEventType, DeviceOrientationEvent<TEventCurrentTarget, TEventTarget>>
    {
        #region Window events
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onAfterPrint { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnAfterPrint;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onBeforePrint { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnBeforePrint;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onBeforeUnload { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnBeforeUnload;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onOffline { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnOffline;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onOnline { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnOnline;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onResize { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnResize;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> onUnLoad { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget, TEventTarget>> OnUnLoad;
        #endregion

        #region Device motion event
#if COMP_WITH_EVENTS_PROP
        EventListener<DeviceMotionEvent<TEventCurrentTarget, TEventTarget>> onDeviceMotion { get; set; }
#endif
        event EventListener<DeviceMotionEvent<TEventCurrentTarget, TEventTarget>> OnDeviceMotion;
        #endregion

        #region Device orientation change events
#if COMP_WITH_EVENTS_PROP
        EventListener<DeviceOrientationEvent<TEventCurrentTarget, TEventTarget>> onOrientationChange { get; set; }
#endif
        event EventListener<DeviceOrientationEvent<TEventCurrentTarget, TEventTarget>> OnOrientationChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<DeviceOrientationEvent<TEventCurrentTarget, TEventTarget>> onDeviceOrientation { get; set; }
#endif
        event EventListener<DeviceOrientationEvent<TEventCurrentTarget, TEventTarget>> OnDeviceOrientation;
        #endregion

        #region Storage event
#if COMP_WITH_EVENTS_PROP
        EventListener<StorageEvent<TEventCurrentTarget, TEventTarget>> onStorage { get; set; }
#endif
        event EventListener<StorageEvent<TEventCurrentTarget, TEventTarget>> OnStorage;
        #endregion

        #region HashChange event
#if COMP_WITH_EVENTS_PROP
        EventListener<HashChangeEvent<TEventCurrentTarget, TEventTarget>> onHashChange { get; set; }
#endif
        event EventListener<HashChangeEvent<TEventCurrentTarget, TEventTarget>> OnHashChange;
        #endregion

        #region PopState event
#if COMP_WITH_EVENTS_PROP
        EventListener<PopStateEvent<TEventCurrentTarget, TEventTarget>> onPopState { get; set; }
#endif
        event EventListener<PopStateEvent<TEventCurrentTarget, TEventTarget>> OnPopState;
        #endregion

        #region PageTransition events
#if COMP_WITH_EVENTS_PROP
        EventListener<PageTransitionEvent<TEventCurrentTarget, TEventTarget>> onPageHide { get; set; }
#endif
        event EventListener<PageTransitionEvent<TEventCurrentTarget, TEventTarget>> OnPageHide;
#if COMP_WITH_EVENTS_PROP
        EventListener<PageTransitionEvent<TEventCurrentTarget, TEventTarget>> onPageShow { get; set; }
#endif
        event EventListener<PageTransitionEvent<TEventCurrentTarget, TEventTarget>> OnPageShow;
        #endregion

        #region Message event
#if COMP_WITH_EVENTS_PROP
        EventListener<MessageEvent<TEventCurrentTarget, TEventTarget>> onMessage { get; set; }
#endif
        event EventListener<MessageEvent<TEventCurrentTarget, TEventTarget>> OnMessage;
        #endregion
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public interface IWindowEventTarget<TEventCurrentTarget> :
        IEventTarget<WindowEventType, WindowEvent<TEventCurrentTarget>>, IEventTarget<HashChangeEventType, HashChangeEvent<TEventCurrentTarget>>,
        IEventTarget<MessageEventType, MessageEvent<TEventCurrentTarget>>, IEventTarget<PopStateEventType, PopStateEvent<TEventCurrentTarget>>,
        IEventTarget<PageTransitionEventType, PageTransitionEvent<TEventCurrentTarget>>, IEventTarget<StorageEventType, StorageEvent<TEventCurrentTarget>>,
        IEventTarget<DeviceMotionEventType, DeviceMotionEvent<TEventCurrentTarget>>,
        IEventTarget<DeviceOrientationEventType, DeviceOrientationEvent<TEventCurrentTarget>>
    {
        #region Window events
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onAfterPrint { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnAfterPrint;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onBeforePrint { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnBeforePrint;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onBeforeUnload { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnBeforeUnload;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onOffline { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnOffline;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onOnline { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnOnline;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onResize { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnResize;
#if COMP_WITH_EVENTS_PROP
        EventListener<WindowEvent<TEventCurrentTarget>> onUnLoad { get; set; }
#endif
        event EventListener<WindowEvent<TEventCurrentTarget>> OnUnLoad;
        #endregion


        #region Device motion event
#if COMP_WITH_EVENTS_PROP
        EventListener<DeviceMotionEvent<TEventCurrentTarget>> onDeviceMotion { get; set; }
#endif
        event EventListener<DeviceMotionEvent<TEventCurrentTarget>> OnDeviceMotion;
        #endregion

        #region Device orientation change events
#if COMP_WITH_EVENTS_PROP
        EventListener<DeviceOrientationEvent<TEventCurrentTarget>> onOrientationChange { get; set; }
#endif
        event EventListener<DeviceOrientationEvent<TEventCurrentTarget>> OnOrientationChange;
#if COMP_WITH_EVENTS_PROP
        EventListener<DeviceOrientationEvent<TEventCurrentTarget>> onDeviceOrientation { get; set; }
#endif
        event EventListener<DeviceOrientationEvent<TEventCurrentTarget>> OnDeviceOrientation;
        #endregion

        #region Storage event
#if COMP_WITH_EVENTS_PROP
        EventListener<StorageEvent<TEventCurrentTarget>> onStorage { get; set; }
#endif
        event EventListener<StorageEvent<TEventCurrentTarget>> OnStorage;
        #endregion

        #region HashChange event
#if COMP_WITH_EVENTS_PROP
        EventListener<HashChangeEvent<TEventCurrentTarget>> onHashChange { get; set; }
#endif
        event EventListener<HashChangeEvent<TEventCurrentTarget>> OnHashChange;
        #endregion

        #region PopState event
#if COMP_WITH_EVENTS_PROP
        EventListener<PopStateEvent<TEventCurrentTarget>> onPopState { get; set; }
#endif
        event EventListener<PopStateEvent<TEventCurrentTarget>> OnPopState;
        #endregion

        #region PageTransition events
#if COMP_WITH_EVENTS_PROP
        EventListener<PageTransitionEvent<TEventCurrentTarget>> onPageHide { get; set; }
#endif
        event EventListener<PageTransitionEvent<TEventCurrentTarget>> OnPageHide;
#if COMP_WITH_EVENTS_PROP
        EventListener<PageTransitionEvent<TEventCurrentTarget>> onPageShow { get; set; }
#endif
        event EventListener<PageTransitionEvent<TEventCurrentTarget>> OnPageShow;
        #endregion

        #region Message event
#if COMP_WITH_EVENTS_PROP
        EventListener<MessageEvent<TEventCurrentTarget>> onMessage { get; set; }
#endif
        event EventListener<MessageEvent<TEventCurrentTarget>> OnMessage;
        #endregion
    }

}