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
    /// Represents a file or directory on the local file system.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#FileEntry
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Entry")]
    public partial class Entry
    {
        /// <summary>
        /// true if Entry is a file (readonly).
        /// </summary>
        public bool isFile { get; private set; }
        /// <summary>
        /// true if Entry is a directory (readonly).
        /// </summary>
        public bool isDirectory { get; private set; }
        /// <summary>
        /// Name of the file or directory, excluding the path leading to it (readonly).
        /// </summary>
        public JsString name { get; private set; }
        /// <summary>
        /// The full absolute path from the root to the file or directory (readonly).
        /// </summary>
        public JsString fullPath { get; private set; }
        /// <summary>
        /// The file system on which the Entry resides.
        /// <para>WARNING: this property is not supported by Cordova.</para>
        /// </summary>
        public DOMFileSystem filesystem { get; private set; }

        /// <summary>
        /// Defaut constructor.
        /// </summary>
        public Entry() { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="isFile">true if Entry is a file (readonly).</param>
        /// <param name="isDirectory">true if Entry is a directory (readonly).</param>
        /// <param name="name">Name of the file or directory, excluding the path leading to it (readonly).</param>
        /// <param name="fullPath">The full absolute path from the root to the file or directory (readonly).</param>
        public Entry(bool isFile, bool isDirectory, JsString name, JsString fullPath) { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="isFile">true if Entry is a file (readonly).</param>
        /// <param name="isDirectory">true if Entry is a directory (readonly).</param>
        /// <param name="name">Name of the file or directory, excluding the path leading to it (readonly).</param>
        /// <param name="fullPath">The full absolute path from the root to the file or directory (readonly).</param>
        /// <param name="fileSystem">The file system on which the Entry resides.</param>
        public Entry(bool isFile, bool isDirectory, JsString name, JsString fullPath, DOMFileSystem fileSystem) { }


        /// <summary>
        /// Look up the metadata of the entry.
        /// </summary>
        /// <param name="successCallback">successCallback is called with a <see cref="Metadata"/> object</param>
        [JsMethod(Name = "getMetadata")]
        public void GetMetadata(MetadataCallback successCallback) { }
        /// <summary>
        /// Look up the metadata of the entry.
        /// </summary>
        /// <param name="successCallback">successCallback is called with a <see cref="Metadata"/> object</param>
        /// <param name="errorCallback">errorCallback is called with a <see cref="FileError"/> object</param>
        [JsMethod(Name = "getMetadata")]
        public void GetMetadata(MetadataCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Set the metadata of the entry.
        /// </summary>
        /// <param name="successCallback">successCallback is called with a <see cref="Metadata"/> object</param>
        /// <param name="errorCallback">errorCallback is called with a <see cref="FileError"/> object</param>
        /// <param name="metadataObject">Properties for <see cref="Metadata"/> object</param>
        [JsMethod(Name = "setMetadata")]
        public void SetMetadata(MetadataCallback successCallback, FileErrorCallback errorCallback, Metadata metadataObject) { }
        /// <summary>
        /// Look up the parent DirectoryEntry of this entry.
        /// </summary>
        /// <param name="successCallback">successCallback is called with a <see cref="DirectoryEntry"/> object</param>
        [JsMethod(Name = "getParent")]
        public void GetParent(DirectoryEntryCallback successCallback) { }
        /// <summary>
        /// Look up the parent DirectoryEntry of this entry.
        /// </summary>
        /// <param name="successCallback">successCallback is called with a <see cref="DirectoryEntry"/> object</param>
        /// <param name="errorCallback">errorCallback is called with a <see cref="FileError"/> object</param>
        [JsMethod(Name = "getParent")]
        public void GetParent(DirectoryEntryCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Move a file or directory to a new location.
        /// </summary>
        /// <param name="parent">The directory to which to move this entry.</param>
        /// <param name="newName">New name of the entry, defaults to the current name.</param>
        /// <param name="successCallback">successCallback is called with the new <see cref="Entry"/> object</param>
        [JsMethod(Name = "moveTo")]
        public void MoveTo(DirectoryEntry parent, JsString newName, EntryCallback successCallback) { }
        /// <summary>
        /// Move a file or directory to a new location.
        /// </summary>
        /// <param name="parent">The directory to which to move this entry.</param>
        /// <param name="newName">New name of the entry, defaults to the current name.</param>
        /// <param name="successCallback">successCallback is called with the new <see cref="Entry"/> object</param>
        /// <param name="errorCallback">errorCallback is called with a <see cref="FileError"/> object</param>
        [JsMethod(Name = "moveTo")]
        public void MoveTo(DirectoryEntry parent, JsString newName, EntryCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Copy a directory or a file to a different location.
        /// </summary>
        /// <param name="parent">The directory to which to move this entry.</param>
        /// <param name="newName">New name of the entry, defaults to the current name.</param>
        /// <param name="successCallback">successCallback is called with the new <see cref="Entry"/> object</param>
        [JsMethod(Name = "copyTo")]
        public void CopyTo(DirectoryEntry parent, JsString newName, EntryCallback successCallback) { }
        /// <summary>
        /// Copy a directory or a file to a different location.
        /// </summary>
        /// <param name="parent">The directory to which to move this entry.</param>
        /// <param name="newName">New name of the entry, defaults to the current name.</param>
        /// <param name="successCallback">successCallback is called with the new <see cref="Entry"/> object</param>
        /// <param name="errorCallback">errorCallback is called with a <see cref="FileError"/> object</param>
        [JsMethod(Name = "copyTo")]
        public void CopyTo(DirectoryEntry parent, JsString newName, EntryCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Remove a file or directory.
        /// </summary>
        /// <param name="successCallback">successCallback is called without parameter</param>
        [JsMethod(Name = "remove")]
        public void Remove(VoidCallback successCallback) { }
        /// <summary>
        /// Remove a file or directory.
        /// </summary>
        /// <param name="successCallback">successCallback is called without parameter</param>
        /// <param name="errorCallback">errorCallback is called with a <see cref="FileError"/> object</param>
        [JsMethod(Name = "remove")]
        public void Remove(VoidCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Return a URL that can be used to identify this entry.
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "toURL")]
        public JsString ToUrl() { return default(JsString); }
    }

}