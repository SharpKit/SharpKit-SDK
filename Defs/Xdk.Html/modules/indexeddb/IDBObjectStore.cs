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

namespace SharpKit.DotNet.Html.indexeddb
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "IDBObjectStore")]
    public partial class IDBObjectStore
    {
        public JsString name { get; set; }
        public IDBAny keyPath { get; set; }
        public DOMStringList indexNames { get; set; }
        public IDBTransaction transaction { get; set; }
        public bool autoIncrement { get; set; }
        [JsMethod(Name = "put")]
        public IDBRequest Put(object value) { return default(IDBRequest); }
        [JsMethod(Name = "put")]
        public IDBRequest Put(object value, IDBKey key) { return default(IDBRequest); }
        [JsMethod(Name = "add")]
        public IDBRequest Add(object value) { return default(IDBRequest); }
        [JsMethod(Name = "add")]
        public IDBRequest Add(object value, IDBKey key) { return default(IDBRequest); }
        [JsMethod(Name = "delete")]
        public IDBRequest Delete(IDBKeyRange keyRange) { return default(IDBRequest); }
        [JsMethod(Name = "delete")]
        public IDBRequest Delete(IDBKey key) { return default(IDBRequest); }
        [JsMethod(Name = "clear")]
        public IDBRequest Clear() { return default(IDBRequest); }
        [JsMethod(Name = "get")]
        public IDBRequest Get(IDBKeyRange key) { return default(IDBRequest); }
        [JsMethod(Name = "get")]
        public IDBRequest Get(IDBKey key) { return default(IDBRequest); }
        [JsMethod(Name = "openCursor")]
        public IDBRequest OpenCursor() { return default(IDBRequest); }
        [JsMethod(Name = "openCursor")]
        public IDBRequest OpenCursor(IDBKeyRange range) { return default(IDBRequest); }
        [JsMethod(Name = "openCursor")]
        public IDBRequest OpenCursor(IDBKeyRange range, JsString direction) { return default(IDBRequest); }
        [JsMethod(Name = "openCursor")]
        public IDBRequest OpenCursor(IDBKey key) { return default(IDBRequest); }
        [JsMethod(Name = "openCursor")]
        public IDBRequest OpenCursor(IDBKey key, JsString direction) { return default(IDBRequest); }
        [JsMethod(Name = "createIndex")]
        public IDBIndex CreateIndex(JsString name, JsString keyPath) { return default(IDBIndex); }
        [JsMethod(Name = "createIndex")]
        public IDBIndex CreateIndex(JsString name, JsString keyPath, object options) { return default(IDBIndex); }
        [JsMethod(Name = "index")]
        public IDBIndex Index(JsString name) { return default(IDBIndex); }
        [JsMethod(Name = "deleteIndex")]
        public void DeleteIndex(JsString name) { }
        [JsMethod(Name = "count")]
        public IDBRequest Count() { return default(IDBRequest); }
        [JsMethod(Name = "count")]
        public IDBRequest Count(IDBKeyRange range) { return default(IDBRequest); }
        [JsMethod(Name = "count")]
        public IDBRequest Count(IDBKey key) { return default(IDBRequest); }
    }

}