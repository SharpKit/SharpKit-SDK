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

namespace SharpKit.DotNet.Html.geolocation
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
    /// The geolocation object provides access to location data based on the device's GPS sensor or inferred from network signals.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_geolocation_geolocation.md.html#Geolocation
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Geolocation")]
    public partial class Geolocation
    {
        /// <summary>
        /// Returns the device's current position as a <see cref="Position"/> object.
        /// </summary>
        /// <param name="successCallback">The callback that is passed the current position.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public void GetCurrentPosition(PositionCallback successCallback) { }
        /// <summary>
        /// Returns the device's current position as a <see cref="Position"/> object.
        /// </summary>
        /// <param name="successCallback">The callback that is passed the current position.</param>
        /// <param name="errorCallback">The callback that executes if an error occurs.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public void GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback) { }
        /// <summary>
        /// Returns the device's current position as a <see cref="Position"/> object.
        /// </summary>
        /// <param name="successCallback">The callback that is passed the current position.</param>
        /// <param name="errorCallback">The callback that executes if an error occurs.</param>
        /// <param name="options">The geolocation options.</param>
        [JsMethod(Name = "getCurrentPosition")]
        public void GetCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options) { }
        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="successCallback">The callback that is passed the current position.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with <see cref="ClearWatch"/> to stop watching for changes in position.</returns>
        [JsMethod(Name = "watchPosition")]
        public long WatchPosition(PositionCallback successCallback) { return default(long); }
        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="successCallback">The callback that is passed the current position.</param>
        /// <param name="errorCallback">The callback that executes if an error occurs.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with <see cref="ClearWatch"/> to stop watching for changes in position.</returns>
        [JsMethod(Name = "watchPosition")]
        public long WatchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback) { return default(long); }
        /// <summary>
        /// Watches for changes to the device's current position.
        /// </summary>
        /// <param name="successCallback">The callback that is passed the current position.</param>
        /// <param name="errorCallback">The callback that executes if an error occurs.</param>
        /// <param name="options">The geolocation options.</param>
        /// <returns>returns a watch id that references the watch position interval. The watch id should be used with <see cref="ClearWatch"/> to stop watching for changes in position.</returns>
        [JsMethod(Name = "watchPosition")]
        public long WatchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback, PositionOptions options) { return default(long); }
        /// <summary>
        /// Stop watching for changes to the device's location referenced by the watchId parameter.
        /// </summary>
        /// <param name="watchId">The id of the <see cref="WatchPosition(PositionCallback,PositionErrorCallback,PositionOptions)"/> interval to clear.</param>
        [JsMethod(Name = "clearWatch")]
        public void ClearWatch(long watchId) { }
    }

}