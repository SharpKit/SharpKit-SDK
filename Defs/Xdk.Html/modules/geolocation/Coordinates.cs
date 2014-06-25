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
    /// A set of properties that describe the geographic coordinates of a position.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_geolocation_geolocation.md.html#Coordinates
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Coordinates")]
    public partial class Coordinates
    {
        /// <summary>
        /// Latitude in decimal degrees.
        /// </summary>
        public double latitude { get; set; }
        /// <summary>
        /// Longitude in decimal degrees.
        /// </summary>
        public double longitude { get; set; }
        /// <summary>
        /// Height of the position in meters above the ellipsoid.
        /// </summary>
        public double altitude { get; set; }
        /// <summary>
        /// Accuracy level of the latitude and longitude coordinates in meters.
        /// </summary>
        public double accuracy { get; set; }
        /// <summary>
        /// Direction of travel, specified in degrees counting clockwise relative to the true north.
        /// </summary>
        public double heading { get; set; }
        /// <summary>
        /// Current ground speed of the device, specified in meters per second.
        /// </summary>
        public double speed { get; set; }
        /// <summary>
        /// Accuracy level of the altitude coordinate in meters.
        /// </summary>
        public double altitudeAccuracy { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Coordinates() { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        public Coordinates(double latitude) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        /// <param name="longitude">Longitude in decimal degrees.</param>
        public Coordinates(double latitude, double longitude) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        /// <param name="longitude">Longitude in decimal degrees.</param>
        /// <param name="altitude">Height of the position in meters above the ellipsoid.</param>
        public Coordinates(double latitude, double longitude, double altitude) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        /// <param name="longitude">Longitude in decimal degrees.</param>
        /// <param name="altitude">Height of the position in meters above the ellipsoid.</param>
        /// <param name="accuracy">Accuracy level of the latitude and longitude coordinates in meters.</param>
        public Coordinates(double latitude, double longitude, double altitude, double accuracy) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        /// <param name="longitude">Longitude in decimal degrees.</param>
        /// <param name="altitude">Height of the position in meters above the ellipsoid.</param>
        /// <param name="accuracy">Accuracy level of the latitude and longitude coordinates in meters.</param>
        /// <param name="heading">Direction of travel, specified in degrees counting clockwise relative to the true north.</param>
        public Coordinates(double latitude, double longitude, double altitude, double accuracy, double heading) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        /// <param name="longitude">Longitude in decimal degrees.</param>
        /// <param name="altitude">Height of the position in meters above the ellipsoid.</param>
        /// <param name="accuracy">Accuracy level of the latitude and longitude coordinates in meters.</param>
        /// <param name="heading">Direction of travel, specified in degrees counting clockwise relative to the true north.</param>
        /// <param name="speed">Current ground speed of the device, specified in meters per second.</param>
        public Coordinates(double latitude, double longitude, double altitude, double accuracy, double heading, double speed) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="latitude">Latitude in decimal degrees.</param>
        /// <param name="longitude">Longitude in decimal degrees.</param>
        /// <param name="altitude">Height of the position in meters above the ellipsoid.</param>
        /// <param name="accuracy">Accuracy level of the latitude and longitude coordinates in meters.</param>
        /// <param name="heading">Direction of travel, specified in degrees counting clockwise relative to the true north.</param>
        /// <param name="speed">Current ground speed of the device, specified in meters per second.</param>
        /// <param name="altitudeAccuracy">Accuracy level of the altitude coordinate in meters.</param>
        public Coordinates(double latitude, double longitude, double altitude, double accuracy, double heading, double speed, double altitudeAccuracy) { }
    }

}