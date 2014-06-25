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
    /// Represents a file on a file system, as defined in the W3C Directories and Systems specification.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#FileEntry
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "FileEntry")]
    public partial class FileEntry : Entry
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public FileEntry() { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of the file.</param>
        /// <param name="fullPath">The full absolute path from the root to the file.</param>
        public FileEntry(JsString name, JsString fullPath) { }
        /// <summary>
        /// Create a <see cref="FileWriter"/> object associated with the file represented by the FileEntry.
        /// </summary>
        /// <param name="successCallback">A callback that is passed a <see cref="FileWriter"/> object.</param>
        [JsMethod(Name = "createWriter")]
        public void CreateWriter(FileWriterCallback successCallback) { }
        /// <summary>
        /// Create a <see cref="FileWriter"/> object associated with the file represented by the FileEntry.
        /// </summary>
        /// <param name="successCallback">A callback that is passed a <see cref="FileWriter"/> object.</param>
        /// <param name="errorCallback">A callback that executes if an error occurs while attempting to create the FileWriter. Invoked with a <see cref="FileError"/> object.</param>
        [JsMethod(Name = "createWriter")]
        public void CreateWriter(FileWriterCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Return a <see cref="fileapi.File"/> object that represents the current state of the file that this FileEntry represents.
        /// </summary>
        /// <param name="successCallback">A callback that is passed a <see cref="fileapi.File"/> object.</param>
        [JsMethod(Name = "file")]
        public void File(FileCallback successCallback) { }
        /// <summary>
        /// Return a <see cref="fileapi.File"/> object that represents the current state of the file that this FileEntry represents.
        /// </summary>
        /// <param name="successCallback">A callback that is passed a <see cref="fileapi.File"/> object.</param>
        /// <param name="errorCallback">A callback that executes if an error occurs when creating the File object, such as when the file no longer exists. Invoked with a <see cref="FileError"/> object.</param>
        [JsMethod(Name = "file")]
        public void File(FileCallback successCallback, FileErrorCallback errorCallback) { }
    }

}