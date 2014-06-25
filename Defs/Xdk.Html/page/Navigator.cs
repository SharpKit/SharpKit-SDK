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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Navigator")]
    public partial class Navigator
    {
        #region From Vibration module
        [JsMethod(Name = "vibrate")]
        public void Vibrate(int pattern) { }
        //public  void vibrate(int time) {}
        #endregion

        #region From Geolocation module
        /// <summary>
        /// The geolocation object provides access to location data based on the device's GPS sensor or inferred from network signals.
        /// </summary>
        /// <remarks>
        /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_geolocation_geolocation.md.html#Geolocation
        /// </remarks>
        public Geolocation geolocation { get; set; }
        #endregion

        #region From NavigatorContentUtils module
        [JsMethod(Name = "registerProtocolHandler")]
        public void RegisterProtocolHandler(JsString scheme, JsString url, JsString title) { }
        [JsMethod(Name = "isProtocolHandlerRegistered")]
        public JsString IsProtocolHandlerRegistered(JsString scheme, JsString url) { return default(JsString); }
        [JsMethod(Name = "unregisterProtocolHandler")]
        public void UnregisterProtocolHandler(JsString scheme, JsString url) { }
        #endregion

        public JsString appCodeName { get; set; }
        public JsString appName { get; set; }
        public JsString appVersion { get; set; }
        public JsString language { get; set; }
        public JsString userAgent { get; set; }
        public JsString platform { get; set; }
        public PluginArray plugins { get; set; }
        public MimeTypeArray mimeTypes { get; set; }
        public JsString product { get; set; }
        public JsString productSub { get; set; }
        public JsString vendor { get; set; }
        public JsString vendorSub { get; set; }
        public bool cookieEnabled { get; set; }
        public bool onLine { get; set; }


        [JsMethod(Name = "javaEnabled")]
        public bool JavaEnabled() { return default(bool); }
        [JsMethod(Name = "getStorageUpdates")]
        public void GetStorageUpdates() { }
    }

}