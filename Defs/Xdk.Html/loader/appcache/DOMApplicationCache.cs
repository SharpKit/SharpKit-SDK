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

namespace SharpKit.DotNet.Html.loader.appcache
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "DOMApplicationCache")]
    public partial class DOMApplicationCache : EventTarget, IEventTarget<ApplicationCacheEventType, ApplicationCacheEvent>,
        IEventTarget<ProgressEventType, ProgressEvent<DOMApplicationCache, DOMApplicationCache>>,
        IEventTarget<ErrorEventType, ErrorEvent<DOMApplicationCache, DOMApplicationCache>>
    {
        public ApplicationCacheStatus status { get; set; }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onchecking", NativeField = true)]
        public EventListener<ApplicationCacheEvent> onChecking { get; set; }
#endif
        public event EventListener<ApplicationCacheEvent> OnChecking
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"checking\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"checking\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onnoupdate", NativeField = true)]
        public EventListener<ApplicationCacheEvent> onNoUpdate { get; set; }
#endif
        public event EventListener<ApplicationCacheEvent> OnNoUpdate
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"noupdate\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"noupdate\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "ondownloading", NativeField = true)]
        public EventListener<ApplicationCacheEvent> onDownloading { get; set; }
#endif
        public event EventListener<ApplicationCacheEvent> OnDownloading
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"downloading\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"downloading\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onupdateready", NativeField = true)]
        public EventListener<ApplicationCacheEvent> onUpdateReady { get; set; }
#endif
        public event EventListener<ApplicationCacheEvent> OnUpdateReady
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"updateready\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"updateready\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "oncached", NativeField = true)]
        public EventListener<ApplicationCacheEvent> onCached { get; set; }
#endif
        public event EventListener<ApplicationCacheEvent> OnCached
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"cached\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"cached\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onobsolete", NativeField = true)]
        public EventListener<ApplicationCacheEvent> onObsolete { get; set; }
#endif
        public event EventListener<ApplicationCacheEvent> OnObsolete
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"obsolete\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"obsolete\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ApplicationCacheEventType type, EventListener<ApplicationCacheEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ApplicationCacheEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ApplicationCacheEventType type, EventListener<ApplicationCacheEvent> listener, bool useCapture = false) { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onprogress", NativeField = true)]
        public EventListener<ProgressEvent<DOMApplicationCache, DOMApplicationCache>> onProgress { get; set; }
#endif
        public event EventListener<ProgressEvent<DOMApplicationCache, DOMApplicationCache>> OnProgress
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ProgressEventType type, EventListener<ProgressEvent<DOMApplicationCache, DOMApplicationCache>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ProgressEvent<DOMApplicationCache, DOMApplicationCache> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ProgressEventType type, EventListener<ProgressEvent<DOMApplicationCache, DOMApplicationCache>> listener, bool useCapture = false) { }

#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<ErrorEvent<DOMApplicationCache, DOMApplicationCache>> onError { get; set; }
#endif
        public event EventListener<ErrorEvent<DOMApplicationCache, DOMApplicationCache>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<DOMApplicationCache, DOMApplicationCache>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<DOMApplicationCache, DOMApplicationCache> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<DOMApplicationCache, DOMApplicationCache>> listener, bool useCapture = false) { }


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

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ProgressEventType type, EventListener<ProgressEvent> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ProgressEvent evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ProgressEventType type, EventListener<ProgressEvent> listener, bool useCapture = false) { }

        [JsMethod(Name = "update")]
        public void Update() { }
        [JsMethod(Name = "swapCache")]
        public void SwapCache() { }
        [JsMethod(Name = "abort")]
        public void Abort() { }
    }

}