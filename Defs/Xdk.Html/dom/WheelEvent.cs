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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "WheelEvent")]
    public partial class WheelEvent : MouseEvent
    {
        public new WheelEventType type { get; set; }
        public int wheelDelta { get; set; }
        public int wheelDeltaX { get; set; }
        public int wheelDeltaY { get; set; }

        [JsMethod(Name = "initUIEvent")]
        public void InitUIEvent(WheelEventType type, bool canBubble, bool cancelable, Window view, int detail) { }
        [JsMethod(Name = "initEvent")]
        public void InitEvent(WheelEventType eventTypeArg, bool canBubbleArg, bool cancelableArg) { }
        [JsMethod(Name = "initMouseEvent")]
        public void InitMouseEvent(WheelEventType type, bool canBubble, bool cancelable, Window view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int button, EventTarget relatedTarget) { }

        [JsMethod(Name = "initWebKitWheelEvent")]
        public void InitWebKitWheelEvent(int wheelDeltaX, int wheelDeltaY, Window view, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey) { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "initUIEvent")]
        public new void InitUIEvent(MouseEventType type, bool canBubble, bool cancelable, Window view, int detail) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "initEvent")]
        public new void InitEvent(MouseEventType eventTypeArg, bool canBubbleArg, bool cancelableArg) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "initMouseEvent")]
        public new void InitMouseEvent(MouseEventType type, bool canBubble, bool cancelable, Window view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int button, EventTarget relatedTarget) { }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "WheelEvent")]
    public partial class WheelEvent<TEventCurrentTarget> : WheelEvent
    {
        public new TEventCurrentTarget currentTarget { get; set; }
    }
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "WheelEvent")]
    public partial class WheelEvent<TEventCurrentTarget, TEventTarget> : WheelEvent<TEventCurrentTarget>
    {
        public new TEventTarget srcElement { get; set; }
        public new TEventTarget target { get; set; }
    }
}