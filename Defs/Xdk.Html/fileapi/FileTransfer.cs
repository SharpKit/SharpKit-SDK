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
    /// The FileTransfer object allows you to upload or download files to and from a server.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#FileTransfer
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true)]
    public partial class FileTransfer : EventTarget, IEventTarget<ProgressEventType, ProgressEvent<FileTransfer, FileTransfer>>
    {
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called with a <see cref="ProgressEvent"/> whenever a new chunk of data is transferred.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onprogress", NativeField = true)]
        public EventListener<ProgressEvent<FileTransfer, FileTransfer>> onProgress { get; set; }
#endif
        /// <summary>
        /// Called with a <see cref="ProgressEvent"/> whenever a new chunk of data is transferred.
        /// </summary>
        public event EventListener<ProgressEvent<FileTransfer, FileTransfer>> OnProgress
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            remove { }
        }
        /*
        /// <summary>
        /// Called with a <see cref="ProgressEvent"/> whenever a new chunk of data is transferred.
        /// </summary>
        [JsProperty(Name = "onprogress", NativeField = true)]
        public EventListener<ProgressEvent> onProgress { get; set; }
        */
        /// <summary>
        /// Default constructor.
        /// </summary>
        public FileTransfer() { }
        /// <summary>
        /// Sends a file to a server.
        /// </summary>
        /// <param name="filePath">Full path of the file on the device.</param>
        /// <param name="server">URL of the server to receive the file, as encoded by encodeURI().</param>
        /// <param name="successCallback">A callback success.</param>
        /// <param name="errorCallback">A callback that executes if an error occurs. Invoked with a FileTransferError object.</param>
        /// <param name="options">Optional parameters such as file name and mimetype.</param>
        /// <param name="trustAllHosts">Optional parameter, defaults to false. If set to true, it accepts all security certificates.</param>
        [JsMethod(Name = "upload")]
        public void Upload(JsString filePath, JsString server, FileUploadResultCallback successCallback, FileTransferErrorCallback errorCallback = null, FileUploadOptions options = null, bool trustAllHosts = false) { }
        /// <summary>
        /// Downloads a file from server.
        /// </summary>
        /// <param name="source">URL of the server to download the file, as encoded by encodeURI()</param>
        /// <param name="target">Full path of the file on the device.</param>
        /// <param name="successCallback">A callback success.</param>
        /// <param name="errorCallback">A callback that executes if an error occurs. Invoked with a FileTransferError object.</param>
        /// <param name="trustAllHosts">Optional parameter, defaults to false. If set to true then it will accept all security certificates.</param>
        /// <param name="options">Optional parameters, currently only supports headers (such as Authorization (Basic Authentication), etc).</param>
        [JsMethod(Name = "download")]
        public void Download(JsString source, JsString target, EntryCallback successCallback, FileTransferErrorCallback errorCallback = null, bool trustAllHosts = false, FileDownloadOptions options = null) { }
        /// <summary>
        /// Aborts an in-progress transfer.
        /// </summary>
        [JsMethod(Name = "abort")]
        public void Abort() { }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(ProgressEventType type, EventListener<ProgressEvent<FileTransfer, FileTransfer>> listener, bool useCapture = false) { }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(ProgressEventType type, EventListener<ProgressEvent<FileTransfer, FileTransfer>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(ProgressEvent<FileTransfer, FileTransfer> evt) { return default(bool); }

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
    }

}