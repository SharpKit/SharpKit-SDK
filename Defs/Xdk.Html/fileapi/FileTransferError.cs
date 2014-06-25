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

namespace SharpKit.DotNet.Html.fileapi
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
    /// A FileTransferError object is set when an error occurs in any of the <see cref="FileTransfer"/> API methods.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#FileTransferError
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class FileTransferError
    {
        /// <summary>
        /// Error code resulting from a failed media capture operation.
        /// </summary>
        public FileTransferErrorCode code { get; set; }
        /// <summary>
        /// URI to the source.
        /// </summary>
        public JsString source { get; set; }
        /// <summary>
        /// URI to the target.
        /// </summary>
        public JsString target { get; set; }
        /// <summary>
        /// HTTP status code. This attribute is only available when a response code is received from the HTTP connection.
        /// </summary>
        [JsProperty(Name = "http_status", NativeField = true)]
        public long httpStatus { get; set; }
        public HtmlBodyElement body { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code">Error code resulting from a failed media capture operation.</param>
        /// <param name="source">URI to the source.</param>
        /// <param name="target">URI to the target.</param>
        /// <param name="status">HTTP status code. This attribute is only available when a response code is received from the HTTP connection.</param>
        /// <param name="body"></param>
        public FileTransferError(FileTransferErrorCode code, JsString source, JsString target, long status, HtmlBodyElement body = null) { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="source">URI to the source.</param>
        /// <param name="target">URI to the target.</param>
        public FileTransferError(FileTransferErrorCode code, JsString source = null, JsString target = null) { }
        /// <summary>
        /// Default constructor
        /// </summary>
        public FileTransferError() { }
    }

}