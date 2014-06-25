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

namespace SharpKit.DotNet.Html.battery
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "BatteryManager")]
    public partial class BatteryManager : EventTarget, IEventTarget<BatteryEventType, BatteryEvent>
    {
        public bool charging { get; set; }
        public double chargingTime { get; set; }
        public double dischargingTime { get; set; }
        public double level { get; set; }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onchargingchange", NativeField = true)]
        public EventListener<BatteryEvent> onChargingChange { get; set; }
#endif
        public event EventListener<BatteryEvent> OnChargingChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"chargingchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"chargingchange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onchargingtimechange", NativeField = true)]
        public EventListener<BatteryEvent> onChargingTimeChange { get; set; }
#endif
        public event EventListener<BatteryEvent> OnChargingTimeChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"chargingtimechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"chargingtimechange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondischargingtimechange", NativeField = true)]
        public EventListener<BatteryEvent> onDischargingTimeChange { get; set; }
#endif
        public event EventListener<BatteryEvent> OnDischargingTimeChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"dischargingtimechange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"dischargingtimechange\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onlevelchange", NativeField = true)]
        public EventListener<BatteryEvent> onLevelChange { get; set; }
#endif
        public event EventListener<BatteryEvent> OnLevelChange
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"levelchange\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"levelchange\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(BatteryEventType type, EventListener<BatteryEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(BatteryEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(BatteryEventType type, EventListener<BatteryEvent> listener, bool useCapture = false) { }

        #region Properties and methods inherited to hide for Intellisense
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(Event evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        #endregion

    }

}