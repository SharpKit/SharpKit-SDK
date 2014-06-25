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

    /// <summary>
    /// For compatibility.
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public partial class EventTarget : IEventTarget
    {
        /// <summary>
        /// Adds a listener for an event from the EventTarget object.
        /// </summary>
        /// <param name="type">the event to listen for.</param>
        /// <param name="listener">the function that executes when the event fires.</param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(Event evt) { return default(bool); }
        /// <summary>
        /// Removes a listener for an event from the EventTarget object.
        /// </summary>
        /// <param name="type">the event to listen for.</param>
        /// <param name="listener">the function that executes when the event fires.</param>
        /// <param name="useCapture"></param>
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(JsString type, EventListener listener, bool useCapture = false) { }
    }
    /*
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public partial class EventTarget<TEnumEventType> : IEventTarget<TEnumEventType>
    {
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(TEnumEventType type, EventListener<Event> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(Event evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(TEnumEventType type, EventListener<Event> listener, bool useCapture = false) { }
    }


    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "EventTarget")]
    public partial class EventTarget<TEnumEventType, TEvent> : EventTarget, IEventTarget<TEnumEventType, TEvent>
    {
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(TEnumEventType type, EventListener<TEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(TEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(TEnumEventType type, EventListener<TEvent> listener, bool useCapture = false) { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(Event evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(JsString type, EventListener listener, bool useCapture = false) { }

    }
*/



}