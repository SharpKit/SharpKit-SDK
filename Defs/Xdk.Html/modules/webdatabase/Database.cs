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

namespace SharpKit.DotNet.Html.webdatabase
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
    /// Provides access to an SQL database.
    /// <para>The <see cref="Window.OpenDatabase(JsString,JsString,JsString,long,DatabaseCallback)"/> method returns a Database object.</para>
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_storage_storage.md.html#Database
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Database")]
    public partial class Database
    {
        public JsString version { get; set; }

        /// <summary>
        /// Allows scripts to automatically verify the version number and change it when updating a schema.
        /// </summary>
        /// <param name="oldVersion"></param>
        /// <param name="newVersion"></param>
        [JsMethod(Name = "changeVersion")]
        public void ChangeVersion(JsString oldVersion, JsString newVersion) { }
        /// <summary>
        /// Allows scripts to automatically verify the version number and change it when updating a schema.
        /// </summary>
        /// <param name="oldVersion"></param>
        /// <param name="newVersion"></param>
        /// <param name="callback"></param>
        [JsMethod(Name = "changeVersion")]
        public void ChangeVersion(JsString oldVersion, JsString newVersion, SQLTransactionCallback callback) { }
        /// <summary>
        /// Allows scripts to automatically verify the version number and change it when updating a schema.
        /// </summary>
        /// <param name="oldVersion"></param>
        /// <param name="newVersion"></param>
        /// <param name="callback"></param>
        /// <param name="errorCallback"></param>
        [JsMethod(Name = "changeVersion")]
        public void ChangeVersion(JsString oldVersion, JsString newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback) { }
        /// <summary>
        /// Allows scripts to automatically verify the version number and change it when updating a schema.
        /// </summary>
        /// <param name="oldVersion"></param>
        /// <param name="newVersion"></param>
        /// <param name="callback"></param>
        /// <param name="errorCallback"></param>
        /// <param name="successCallback"></param>
        [JsMethod(Name = "changeVersion")]
        public void ChangeVersion(JsString oldVersion, JsString newVersion, SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, VoidCallback successCallback) { }

        /// <summary>
        /// Runs a database transaction.
        /// </summary>
        /// <param name="callback"></param>
        [JsMethod(Name = "transaction")]
        public void Transaction(SQLTransactionCallback callback) { }
        /// <summary>
        /// Runs a database transaction.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="errorCallback"></param>
        [JsMethod(Name = "transaction")]
        public void Transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback) { }
        /// <summary>
        /// Runs a database transaction.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="errorCallback"></param>
        /// <param name="successCallback"></param>
        [JsMethod(Name = "transaction")]
        public void Transaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, VoidCallback successCallback) { }

        [JsMethod(Name = "readTransaction")]
        public void ReadTransaction(SQLTransactionCallback callback) { }
        [JsMethod(Name = "readTransaction")]
        public void ReadTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback) { }
        [JsMethod(Name = "readTransaction")]
        public void ReadTransaction(SQLTransactionCallback callback, SQLTransactionErrorCallback errorCallback, VoidCallback successCallback) { }
    }

}