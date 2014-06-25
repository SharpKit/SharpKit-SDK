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

namespace SharpKit.DotNet.Html.storage
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
    /// Provides access to the W3C's Web Storage interface.
    /// <para>An app can use it to save persistent data using key-value pairs. The <see cref="Window.sessionStorage"/> interface works the same way as the <see cref="Window.localStorage"/> in every respect, except that all data is cleared each time the app closes. Each database provides a separate namespace.</para>
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_storage_storage.md.html#localStorage
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Storage")]
    public partial class Storage
    {
        [JsProperty(NativeIndexer = true)]
        public JsString this[JsString key]
        {
            get { return GetItem(key); }
            set { SetItem(key, value); }
        }

        public int length { get; set; }

        /// <summary>
        /// Returns the name of the key at the specified position.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [JsMethod(Name = "key")]
        public JsString Key(int index) { return default(JsString); }
        /// <summary>
        /// Returns the item identified by the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        [JsMethod(Name = "getItem")]
        public JsString GetItem(JsString key) { return default(JsString); }
        /// <summary>
        /// Assigns a keyed item's value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        [JsMethod(Name = "setItem")]
        public void SetItem(JsString key, JsString data) { }
        /// <summary>
        /// Removes the item identified by the specified key.
        /// </summary>
        /// <param name="key"></param>
        [JsMethod(Name = "removeItem")]
        public void RemoveItem(JsString key) { }
        /// <summary>
        /// Removes all of the key/value pairs.
        /// </summary>
        [JsMethod(Name = "clear")]
        public void Clear() { }
    }

}