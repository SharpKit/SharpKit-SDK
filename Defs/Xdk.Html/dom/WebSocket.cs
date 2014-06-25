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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "WebSocket")]
    public partial class WebSocket : EventTarget,
                                       IEventTarget<WebSocketEventType, WebSocketEvent>,
                                       IEventTarget<MessageEventType, MessageEvent<WebSocket, WebSocket>>,
                               IEventTarget<ErrorEventType, ErrorEvent<WebSocket, WebSocket>>,
                               IEventTarget<CloseEventType, CloseEvent<WebSocket, WebSocket>>
    {
        public WebSocket(JsString url, JsString protocol) { }
        public WebSocket(JsString url, JsArray<JsString> protocols) { }
        public WebSocket(JsString url) { }
        public JsString URL { get; set; }
        public JsString url { get; set; }
        public WebSocketState readyState { get; set; }
        public int bufferedAmount { get; set; }
        public JsString protocol { get; set; }
        public JsString extensions { get; set; }
        public JsString binaryType { get; set; }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onopen", NativeField = true)]
        public EventListener<WebSocketEvent> onOpen { get; set; }
#endif
        public event EventListener<WebSocketEvent> OnOpen
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"open\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"open\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(WebSocketEventType type, EventListener<WebSocketEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(WebSocketEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(WebSocketEventType type, EventListener<WebSocketEvent> listener, bool useCapture = false) { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onmessage", NativeField = true)]
        public EventListener<MessageEvent<WebSocket, WebSocket>> onMessage { get; set; }
#endif
        public event EventListener<MessageEvent<WebSocket, WebSocket>> OnMessage
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"message\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"message\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(MessageEventType type, EventListener<MessageEvent<WebSocket, WebSocket>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(MessageEvent<WebSocket, WebSocket> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(MessageEventType type, EventListener<MessageEvent<WebSocket, WebSocket>> listener, bool useCapture = false) { }



#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<ErrorEvent<WebSocket, WebSocket>> onError { get; set; }
#endif
        public event EventListener<ErrorEvent<WebSocket, WebSocket>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<WebSocket, WebSocket>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<WebSocket, WebSocket> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<WebSocket, WebSocket>> listener, bool useCapture = false) { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onclose", NativeField = true)]
        public EventListener<CloseEvent<WebSocket, WebSocket>> onClose { get; set; }
#endif
        public event EventListener<CloseEvent<WebSocket, WebSocket>> OnClose
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"close\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(CloseEventType type, EventListener<CloseEvent<WebSocket, WebSocket>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(CloseEvent<WebSocket, WebSocket> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(CloseEventType type, EventListener<CloseEvent<WebSocket, WebSocket>> listener, bool useCapture = false) { }


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

        [JsMethod(Name = "send")]
        public bool Send(ArrayBuffer data) { return default(bool); }
        [JsMethod(Name = "send")]
        public bool Send(ArrayBufferView data) { return default(bool); }
        [JsMethod(Name = "send")]
        public bool Send(Blob data) { return default(bool); }
        [JsMethod(Name = "send")]
        public bool Send(JsString data) { return default(bool); }
        [JsMethod(Name = "close")]
        public void Close() { }
        [JsMethod(Name = "close")]
        public void Close(int code) { }
        [JsMethod(Name = "close")]
        public void Close(int code, JsString reason) { }
    }

}