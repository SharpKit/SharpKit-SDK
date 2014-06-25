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
    public interface IGlobalEventTarget<TEventCurrentTarget, TEventTarget> : IEventTarget<ErrorEventType, ErrorEvent<TEventCurrentTarget, TEventTarget>>,
        IEventTarget<FocusEventType, FocusEvent<TEventCurrentTarget, TEventTarget>>, IEventTarget<GlobalEventType, GlobalEvent<TEventCurrentTarget, TEventTarget>>
    {
        #region Focus events
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> onFocus { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> OnFocus;
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> onFocusIn { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> OnFocusIn;
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> onFocusOut { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> OnFocusOut;
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> onBlur { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget, TEventTarget>> OnBlur;
        void Focus();
        void Blur();
        #endregion

        #region Global events
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalEvent<TEventCurrentTarget, TEventTarget>> onLoad { get; set; }
#endif
        event EventListener<GlobalEvent<TEventCurrentTarget, TEventTarget>> OnLoad;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalEvent<TEventCurrentTarget, TEventTarget>> onScroll { get; set; }
#endif
        event EventListener<GlobalEvent<TEventCurrentTarget, TEventTarget>> OnScroll;
        #endregion

        #region Error event
#if COMP_WITH_EVENTS_PROP
        EventListener<ErrorEvent<TEventCurrentTarget, TEventTarget>> onError { get; set; }
#endif
        event EventListener<ErrorEvent<TEventCurrentTarget, TEventTarget>> OnError;
        #endregion
    }

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public interface IGlobalEventTarget<TEventCurrentTarget> : IEventTarget<ErrorEventType, ErrorEvent<TEventCurrentTarget>>,
        IEventTarget<FocusEventType, FocusEvent<TEventCurrentTarget>>, IEventTarget<GlobalEventType, GlobalEvent<TEventCurrentTarget>>
    {
        #region Focus events
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget>> onFocus { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget>> OnFocus;
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget>> onFocusIn { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget>> OnFocusIn;
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget>> onFocusOut { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget>> OnFocusOut;
#if COMP_WITH_EVENTS_PROP
        EventListener<FocusEvent<TEventCurrentTarget>> onBlur { get; set; }
#endif
        event EventListener<FocusEvent<TEventCurrentTarget>> OnBlur;
        void Focus();
        void Blur();
        #endregion

        #region Global events
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalEvent<TEventCurrentTarget>> onLoad { get; set; }
#endif
        event EventListener<GlobalEvent<TEventCurrentTarget>> OnLoad;
#if COMP_WITH_EVENTS_PROP
        EventListener<GlobalEvent<TEventCurrentTarget>> onScroll { get; set; }
#endif
        event EventListener<GlobalEvent<TEventCurrentTarget>> OnScroll;
        #endregion

        #region Error event
#if COMP_WITH_EVENTS_PROP
        EventListener<ErrorEvent<TEventCurrentTarget>> onError { get; set; }
#endif
        event EventListener<ErrorEvent<TEventCurrentTarget>> OnError;
        #endregion
    }

}