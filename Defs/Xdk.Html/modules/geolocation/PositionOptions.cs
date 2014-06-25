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
    /// Optional parameters to customize the retrieval of the geolocation <see cref="Position"/>.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_geolocation_geolocation.md.html#GeolocationOptions
    /// </remarks>
    [JsType(JsMode.Json, Export = false, PropertiesAsFields = true)]
    public partial class PositionOptions
    {
        /// <summary>
        /// This will force the command to report back a more accurate latitude and longitude position at the expense of more battery usage.
        /// <para>Provides a hint that the application needs the best possible results. By default, the device attempts to retrieve a <see cref="Position"/> using network-based methods. Setting this property to true tells the framework to use more accurate methods, such as satellite positioning.</para>
        /// </summary>
        public bool enableHighAccuracy { get; set; }
        /// <summary>
        /// The number of milliseconds between checks of position rather than the default value of 10000 (or ten seconds).
        /// <para>Other explanation: the maximum length of time (milliseconds) that is allowed to pass.</para>
        /// </summary>
        public long timeout { get; set; }
        /// <summary>
        /// Accept a cached position whose age is no greater than the specified time in milliseconds.
        /// <para>Other explanation: the number of milliseconds the command will wait before deciding that it cannot get a new position reading and instead run the error message.</para>
        /// </summary>
        public long maximumAge { get; set; }
        /*
                /// <summary>
                /// Not W3C: only for Intel XDK.
                /// </summary>
                public bool requestAddress { get; set; }
                /// <summary>
                /// Not W3C: only for Intel XDK.
                /// </summary>
                public bool requireCoords { get; set; }
        */
    }

}