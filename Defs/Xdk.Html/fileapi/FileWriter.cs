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
    /// Object that allows you to create and write data to a file.
    /// </summary>
    /// <remarks>
    /// More infos at: http://help.xmadevlab.net/cordova/en/3.0.0/cordova_file_file.md.html#FileWriter
    /// </remarks>
    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "FileWriter")]
    public partial class FileWriter : EventTarget, IEventTarget<FileWriterProgressEventType, FileWriterProgressEvent<FileWriter>>
    {
        /// <summary>
        /// One of the reader's three possible states.
        /// </summary>
        public FileWriterState readyState { get; set; }
        /// <summary>
        /// The name of the file to be written.
        /// </summary>
        public JsString fileName { get; set; }
        /// <summary>
        /// The length of the file to be written.
        /// </summary>
        public long length { get; set; }
        /// <summary>
        /// The current position of the file pointer.
        /// </summary>
        public long position { get; set; }
        /// <summary>
        /// An object containing errors.
        /// </summary>
        public FileError error { get; set; }

#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the write has been aborted. For instance, by invoking the <see cref="Abort"/> method.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onabort", NativeField = true)]
        public EventListener<FileWriterProgressEvent<FileWriter>> onAbort { get; set; }
#endif
        /// <summary>
        /// Called when the write has been aborted. For instance, by invoking the <see cref="Abort"/> method.
        /// </summary>
        public event EventListener<FileWriterProgressEvent<FileWriter>> OnAbort
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"abort\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"abort\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the write has failed.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<FileWriterProgressEvent<FileWriter>> onError { get; set; }
#endif
        /// <summary>
        /// Called when the write has failed.
        /// </summary>
        public event EventListener<FileWriterProgressEvent<FileWriter>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the request has completed successfully.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onwrite", NativeField = true)]
        public EventListener<FileWriterProgressEvent<FileWriter>> onWrite { get; set; }
#endif
        /// <summary>
        /// Called when the request has completed successfully.
        /// </summary>
        public event EventListener<FileWriterProgressEvent<FileWriter>> OnWrite
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"write\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"write\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the write starts.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onwritestart", NativeField = true)]
        public EventListener<FileWriterProgressEvent<FileWriter>> onWriteStart { get; set; }
#endif
        /// <summary>
        /// Called when the write starts.
        /// </summary>
        public event EventListener<FileWriterProgressEvent<FileWriter>> OnWriteStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"writestart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"writestart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onwriteend", NativeField = true)]
        public EventListener<FileWriterProgressEvent<FileWriter>> onWriteEnd { get; set; }
#endif
        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
        public event EventListener<FileWriterProgressEvent<FileWriter>> OnWriteEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"writeend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"writeend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called while writing the file, reporting progress in terms of "FileWriterProgressEvent.loaded"/"FileWriterProgressEvent.total".
        /// <para>WARNING: this property is not supported by Cordova.</para>
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onprogress", NativeField = true)]
        public EventListener<FileWriterProgressEvent<FileWriter>> onProgress { get; set; }
#endif
        /// <summary>
        /// Called while writing the file, reporting progress in terms of "FileWriterProgressEvent.loaded"/"FileWriterProgressEvent.total".
        /// <para>WARNING: this property is not supported by Cordova.</para>
        /// </summary>
        public event EventListener<FileWriterProgressEvent<FileWriter>> OnProgress
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            remove { }
        }
        /*
        /// <summary>
        /// Called when the write has been aborted. For instance, by invoking the <see cref="Abort"/> method.
        /// </summary>
        [JsProperty(Name = "onabort", NativeField = true)]
        public EventListener<FileWriterProgressEvent> onAbort { get; set; }
        /// <summary>
        /// Called when the write has failed.
        /// </summary>
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<FileWriterProgressEvent> onError { get; set; }
        /// <summary>
        /// Called when the request has completed successfully.
        /// </summary>
        [JsProperty(Name = "onwrite", NativeField = true)]
        public EventListener<FileWriterProgressEvent> onWrite { get; set; }
        /// <summary>
        /// Called when the write starts.
        /// </summary>
        [JsProperty(Name = "onwritestart", NativeField = true)]
        public EventListener<FileWriterProgressEvent> onWriteStart { get; set; }
        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
        [JsProperty(Name = "onwriteend", NativeField = true)]
        public EventListener<FileWriterProgressEvent> onWriteEnd { get; set; }
        /// <summary>
        /// Called while writing the file, reporting progress in terms of "FileWriterProgressEvent.loaded"/"FileWriterProgressEvent.total".
        /// <para>WARNING: this property is not supported by Cordova.</para>
        /// </summary>
        [JsProperty(Name = "onprogress", NativeField = true)]
        public EventListener<FileWriterProgressEvent> onProgress { get; set; }
        */
        /// <summary>
        /// Default constructor.
        /// </summary>
        public FileWriter() { }
        /// <summary>
        /// Aborts writing file.
        /// </summary>
        [JsMethod(Name = "abort")]
        public void Abort() { }
        /// <summary>
        /// Moves the file pointer to the specified byte.
        /// </summary>
        /// <param name="offset">offset is the location to move the file pointer to.</param>
        [JsMethod(Name = "seek")]
        public void Seek(long offset) { }
        /// <summary>
        /// Shortens the file to the specified length.
        /// </summary>
        /// <param name="size">size to chop the file at.</param>
        [JsMethod(Name = "truncate")]
        public void Truncate(long size) { }
        /// <summary>
        /// Writes data to the file.
        /// </summary>
        /// <param name="data">data text or blob to be written.</param>
        [JsMethod(Name = "write")]
        public void Write(File data) { }
        /// <summary>
        /// Writes data to the file.
        /// </summary>
        /// <param name="data">data text or blob to be written.</param>
        [JsMethod(Name = "write")]
        public void Write(Blob data) { }
        /// <summary>
        /// Writes data to the file.
        /// </summary>
        /// <param name="data">data text or blob to be written.</param>
        [JsMethod(Name = "write")]
        public void Write(ArrayBuffer data) { }
        /// <summary>
        /// Writes data to the file.
        /// </summary>
        /// <param name="data">data text or blob to be written.</param>
        [JsMethod(Name = "write")]
        public void Write(JsString data) { }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FileWriterProgressEventType type, EventListener<FileWriterProgressEvent<FileWriter>> listener, bool useCapture = false) { }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FileWriterProgressEventType type, EventListener<FileWriterProgressEvent<FileWriter>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FileWriterProgressEvent<FileWriter> evt) { return default(bool); }

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