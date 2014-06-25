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

namespace SharpKit.DotNet.Html.workers
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Worker")]
    public partial class Worker : AbstractWorker,
                               IEventTarget<MessageEventType, MessageEvent<Worker, Worker>>,
                               IEventTarget<ErrorEventType, ErrorEvent<Worker, Worker>>
    {
        public Worker(JsString scriptUrl) { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmessage", NativeField = true)]
        public EventListener<MessageEvent<Worker, Worker>> onMessage { get; set; }
#endif
        public event EventListener<MessageEvent<Worker, Worker>> OnMessage
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"message\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"message\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MessageEventType type, EventListener<MessageEvent<Worker, Worker>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MessageEvent<Worker, Worker> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MessageEventType type, EventListener<MessageEvent<Worker, Worker>> listener, bool useCapture = false) { }


#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public new EventListener<ErrorEvent<Worker, Worker>> onError { get; set; }
#endif
        public new event EventListener<ErrorEvent<Worker, Worker>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<Worker, Worker>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<Worker, Worker> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<Worker, Worker>> listener, bool useCapture = false) { }

        #region Properties and methods inherited to hide for Intellisense
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<AbstractWorker, AbstractWorker>> listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(ErrorEvent<AbstractWorker, AbstractWorker> evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<AbstractWorker, AbstractWorker>> listener, bool useCapture = false) { }
        #endregion


        [JsMethod(Name = "postMessage")]
        public void PostMessage(object message) { }
        [JsMethod(Name = "postMessage")]
        public void PostMessage(object message, Array messagePorts) { }
        [JsMethod(Name = "terminate")]
        public void Terminate() { }
    }

}