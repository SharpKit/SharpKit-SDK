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
    /// A FileUploadOptions object can be passed to the <see cref="FileTransfer.Upload"/> method to specify additional parameters to the upload script.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#FileUploadOptions
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class FileUploadOptions
    {
        /// <summary>
        /// The name of the form element. Defaults to "file".
        /// </summary>
        public JsString fileKey { get; set; }
        /// <summary>
        /// The file name to use when saving the file on the server. Defaults to "image.jpg".
        /// </summary>
        public JsString fileName { get; set; }
        /// <summary>
        /// The mime type of the data to upload. Defaults to "image/jpeg".
        /// </summary>
        public JsString mimeType { get; set; }
        /// <summary>
        /// A set of optional key/value pairs to pass in the HTTP request.
        /// </summary>
        [JsProperty(Name = "params", NativeField = true)]
        public JsObject parameters { get; set; }
        /// <summary>
        /// A map of header name/header values. Use an array to specify more than one value.
        /// </summary>
        public JsObject headers { get; set; }
        /// <summary>
        /// Whether to upload the data in chunked streaming mode. Defaults to "true".
        /// </summary>
        public bool chunkedMode { get; set; }
        /// <summary>
        /// "PUT" or "POST"
        /// </summary>
        public FileUploadMethod httpMethod { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fileKey">The name of the form element. Defaults to "file".</param>
        /// <param name="fileName">The file name to use when saving the file on the server. Defaults to "image.jpg".</param>
        /// <param name="mimeType">The mime type of the data to upload. Defaults to "image/jpeg".</param>
        /// <param name="parameters">A set of optional key/value pairs to pass in the HTTP request.</param>
        /// <param name="headers">A map of header name/header values. Use an array to specify more than one value.</param>
        /// <param name="httpMethod">"PUT" or "POST"</param>
        public FileUploadOptions(JsString fileKey = null, JsString fileName = null, JsString mimeType = null, JsObject parameters = null, JsObject headers = null, FileUploadMethod httpMethod = FileUploadMethod.Post) { }
    }

}