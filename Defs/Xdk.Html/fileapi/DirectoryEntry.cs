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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "DirectoryEntry")]
    public partial class DirectoryEntry : Entry
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public DirectoryEntry() { }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of the directory.</param>
        /// <param name="fullPath">The full absolute path from the root to the directory.</param>
        public DirectoryEntry(JsString name, JsString fullPath) { }
        /// <summary>
        /// Creates a new <see cref="DirectoryReader"/> to read entries in a directory.
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "createReader")]
        public DirectoryReader CreateReader() { return default(DirectoryReader); }
        /// <summary>
        /// Creates or looks up an existing directory. An error results if the app attempts to create a directory whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the directory to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        [JsMethod(Name = "getDirectory")]
        public void GetDirectory(JsString path) { }
        /// <summary>
        /// Creates or looks up an existing directory. An error results if the app attempts to create a directory whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the directory to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the directory is to be created if it doesn't exist</param>
        [JsMethod(Name = "getDirectory")]
        public void GetDirectory(JsString path, Flags options) { }
        /// <summary>
        /// Creates or looks up an existing directory. An error results if the app attempts to create a directory whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the directory to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the directory is to be created if it doesn't exist</param>
        /// <param name="successCallback">A callback that executes with a <see cref="DirectoryEntry"/> object.</param>
        [JsMethod(Name = "getDirectory")]
        public void GetDirectory(JsString path, Flags options, DirectoryEntryCallback successCallback) { }
        /// <summary>
        /// Creates or looks up an existing directory. An error results if the app attempts to create a directory whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the directory to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the directory is to be created if it doesn't exist</param>
        /// <param name="successCallback">A callback that executes with a <see cref="DirectoryEntry"/> object.</param>
        /// <param name="errorCallback">A callback that executes if an error occurs when creating or looking up the directory. Invoked with a <see cref="FileError"/> object.</param>
        [JsMethod(Name = "getDirectory")]
        public void GetDirectory(JsString path, Flags options, DirectoryEntryCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// Creates or looks up a file. An error results if the app attempts to create a file whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the file to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        [JsMethod(Name = "getFile")]
        public void GetFile(JsString path) { }
        /// <summary>
        /// Creates or looks up a file. An error results if the app attempts to create a file whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the file to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the file is created if it doesn't exist.</param>
        [JsMethod(Name = "getFile")]
        public void GetFile(JsString path, Flags options) { }
        /// <summary>
        /// Creates or looks up a file. An error results if the app attempts to create a file whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the file to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the file is created if it doesn't exist.</param>
        /// <param name="successCallback">A callback that executes with a <see cref="FileEntry"/> object.</param>
        [JsMethod(Name = "getFile")]
        public void GetFile(JsString path, Flags options, FileEntryCallback successCallback) { }
        /// <summary>
        /// Creates or looks up a file. An error results if the app attempts to create a file whose immediate parent does not yet exist.
        /// </summary>
        /// <param name="path">The path to the file to be looked up or created. Either an absolute path, or a relative path from this DirectoryEntry.</param>
        /// <param name="options">Options to specify whether the file is created if it doesn't exist.</param>
        /// <param name="successCallback">A callback that executes with a <see cref="FileEntry"/> object.</param>
        /// <param name="errorCallback">A callback that executes if an error occurs when creating or looking up the file. Invoked with a <see cref="FileError"/> object.</param>
        [JsMethod(Name = "getFile")]
        public void GetFile(JsString path, Flags options, FileEntryCallback successCallback, FileErrorCallback errorCallback) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="successCallback"></param>
        [JsMethod(Name = "removeRecursively")]
        public void RemoveRecursively(VoidCallback successCallback) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="successCallback"></param>
        /// <param name="errorCallback"></param>
        [JsMethod(Name = "removeRecursively")]
        public void RemoveRecursively(VoidCallback successCallback, FileErrorCallback errorCallback = null) { }
    }

}