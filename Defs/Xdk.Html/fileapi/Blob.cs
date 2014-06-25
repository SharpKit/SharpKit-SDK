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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Blob")]
    public partial class Blob
    {
        /// <summary>
        /// The mime type of the entry.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// The size of the entry, in bytes.
        /// </summary>
        public int size { get; set; }

        public Blob() { }
        public Blob(ArrayBuffer[] arrayBuffer) { }
        public Blob(ArrayBufferView[] arrayBufferView) { }
        public Blob(JsString[] value) { }
        public Blob(ArrayBuffer[] arrayBuffer, object propertyBag) { }
        public Blob(ArrayBufferView[] arrayBufferView, object propertyBag = null) { }
        public Blob(JsString[] value, object propertyBag) { }


        /// <summary>
        /// Return a new Blob object, for which <see cref="FileReader"/> returns only the specified portion of the file. Negative values for start or end are measured from the end of the file. Indexes are positioned relative to the current slice.
        /// </summary>
        /// <returns>new File object.</returns>
        [JsMethod(Name = "slice")]
        public Blob Slice() { return default(Blob); }
        /// <summary>
        /// Return a new Blob object, for which <see cref="FileReader"/> returns only the specified portion of the file. Negative values for start or end are measured from the end of the file. Indexes are positioned relative to the current slice.
        /// </summary>
        /// <param name="start">The index of the first byte to read, inclusive.</param>
        /// <returns>new Blob object.</returns>
        [JsMethod(Name = "slice")]
        public Blob Slice(long start) { return default(Blob); }
        /// <summary>
        /// Return a new Blob object, for which <see cref="FileReader"/> returns only the specified portion of the file. Negative values for start or end are measured from the end of the file. Indexes are positioned relative to the current slice.
        /// </summary>
        /// <param name="start">The index of the first byte to read, inclusive.</param>
        /// <param name="end">The index of the byte after the last one to read.</param>
        /// <returns>new Blob object.</returns>
        [JsMethod(Name = "slice")]
        public Blob Slice(long start, long end) { return default(Blob); }
        /// <summary>
        /// Return a new Blob object, for which <see cref="FileReader"/> returns only the specified portion of the file. Negative values for start or end are measured from the end of the file. Indexes are positioned relative to the current slice.
        /// </summary>
        /// <param name="start">The index of the first byte to read, inclusive.</param>
        /// <param name="end">The index of the byte after the last one to read.</param>
        /// <param name="contentType"></param>
        /// <returns>new Blob object.</returns>
        [JsMethod(Name = "slice")]
        public Blob Slice(long start, long end, JsString contentType) { return default(Blob); }

        [JsMethod(Name = "close")]
        public void Close() { }
    }

}