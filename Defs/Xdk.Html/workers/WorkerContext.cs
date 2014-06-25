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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "WorkerContext")]
    public partial class WorkerContext : EventTarget,
                        IEventTarget<ErrorEventType, ErrorEvent<WorkerContext, WorkerContext>>
    {
        #region From WebSockets module
        public WebSocket WebSocket { get; set; }
        #endregion

        #region From WebDatabase module
        [JsMethod(Name = "openDatabase")]
        public Database OpenDatabase(JsString name, JsString version, JsString displayName, int estimatedSize) { return default(Database); }
        [JsMethod(Name = "openDatabase")]
        public Database OpenDatabase(JsString name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback) { return default(Database); }
        [JsMethod(Name = "openDatabaseSync")]
        public DatabaseSync OpenDatabaseSync(JsString name, JsString version, JsString displayName, int estimatedSize) { return default(DatabaseSync); }
        [JsMethod(Name = "openDatabaseSync")]
        public DatabaseSync OpenDatabaseSync(JsString name, JsString version, JsString displayName, int estimatedSize, DatabaseCallback creationCallback) { return default(DatabaseSync); }
        #endregion

        #region From FileSystem module
        public FileError FileError { get; set; }
        //Obsolete        public FileException FileException { get; set; }
        #endregion

        #region From IndexedDatabase module
        public IDBFactory indexedDB { get; set; }
        public IDBCursor IDBCursor { get; set; }
        public IDBCursorWithValue IDBCursorWithValue { get; set; }
        public IDBDatabase IDBDatabase { get; set; }
        public IDBFactory IDBFactory { get; set; }
        public IDBIndex IDBIndex { get; set; }
        public IDBKeyRange IDBKeyRange { get; set; }
        public IDBObjectStore IDBObjectStore { get; set; }
        public IDBOpenDBRequest IDBOpenDBRequest { get; set; }
        public IDBRequest IDBRequest { get; set; }
        public IDBTransaction IDBTransaction { get; set; }
        public IDBVersionChangeEvent IDBVersionChangeEvent { get; set; }
        #endregion

        public WorkerContext self { get; set; }
        public WorkerLocation location { get; set; }

        public WorkerNavigator navigator { get; set; }
        public MessageEvent MessageEvent { get; set; }
        public WorkerLocation WorkerLocation { get; set; }
        public EventSource EventSource { get; set; }
        public XMLHttpRequest XMLHttpRequest { get; set; }
        public URL URL { get; set; }
        public ArrayBuffer ArrayBuffer { get; set; }
        public Int8Array Int8Array { get; set; }
        public Uint8Array Uint8Array { get; set; }
        public Uint8Array Uint8ClampedArray { get; set; }
        public Int16Array Int16Array { get; set; }
        public Uint16Array Uint16Array { get; set; }
        public Int32Array Int32Array { get; set; }
        public Uint32Array Uint32Array { get; set; }
        public Float32Array Float32Array { get; set; }
        public Float64Array Float64Array { get; set; }
        public DataView DataView { get; set; }


#if COMP_WITH_EVENTS_PROP
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<ErrorEvent<WorkerContext, WorkerContext>> onError { get; set; }
#endif
        public event EventListener<ErrorEvent<WorkerContext, WorkerContext>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ErrorEventType type, EventListener<ErrorEvent<WorkerContext, WorkerContext>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ErrorEvent<WorkerContext, WorkerContext> evt) { return default(bool); }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ErrorEventType type, EventListener<ErrorEvent<WorkerContext, WorkerContext>> listener, bool useCapture = false) { }

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

        [JsMethod(Name = "close")]
        public void Close() { }
        [JsMethod(Name = "importScripts")]
        public void ImportScripts() { }
        [JsMethod(Name = "setTimeout")]
        public int SetTimeout(JsAction handler, int timeout) { return default(int); }
        [JsMethod(Name = "setTimeout")]
        public int SetTimeout(object handler, int timeout) { return default(int); }
        [JsMethod(Name = "clearTimeout")]
        public void ClearTimeout(int handle) { }
        [JsMethod(Name = "setInterval")]
        public int SetInterval(JsAction handler, int timeout) { return default(int); }
        [JsMethod(Name = "setInterval")]
        public int SetInterval(object handler, int timeout) { return default(int); }
        [JsMethod(Name = "clearInterval")]
        public void ClearInterval(int handle) { }
    }

}