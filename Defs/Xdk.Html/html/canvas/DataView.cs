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

namespace SharpKit.DotNet.Html
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

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "DataView")]
    public partial class DataView : ArrayBufferView
    {
        public DataView(ArrayBuffer buffer) { }
        public DataView(ArrayBuffer buffer, int byteOffset) { }
        public DataView(ArrayBuffer buffer, int byteOffset, int byteLength) { }

        //[JsMethod(Name = "getInt8")]
        //public  object GetInt8() { return default(object); }
        //[JsMethod(Name = "getUint8")]
        //public object GetUint8() { return default(object); }
        //[JsMethod(Name = "setInt8")]
        //public void SetInt8() { }
        //[JsMethod(Name = "setUint8")]
        //public void SetUint8() { }

        [JsMethod(Name = "getInt8")]
        public sbyte GetInt8(int byteOffset) { return default(sbyte); }
        [JsMethod(Name = "getUint8")]
        public byte GetUint8(int byteOffset) { return default(byte); }
        [JsMethod(Name = "getInt16")]
        public short GetInt16(int byteOffset) { return default(short); }
        [JsMethod(Name = "getInt16")]
        public short GetInt16(int byteOffset, bool littleEndian) { return default(short); }
        [JsMethod(Name = "getUint16")]
        public int GetUint16(int byteOffset) { return default(int); }
        [JsMethod(Name = "getUint16")]
        public int GetUint16(int byteOffset, bool littleEndian) { return default(int); }
        [JsMethod(Name = "getInt32")]
        public int GetInt32(int byteOffset) { return default(int); }
        [JsMethod(Name = "getInt32")]
        public int GetInt32(int byteOffset, bool littleEndian) { return default(int); }
        [JsMethod(Name = "getUint32")]
        public int GetUint32(int byteOffset) { return default(int); }
        [JsMethod(Name = "getUint32")]
        public int GetUint32(int byteOffset, bool littleEndian) { return default(int); }
        [JsMethod(Name = "getFloat32")]
        public double GetFloat32(int byteOffset) { return default(double); }
        [JsMethod(Name = "getFloat32")]
        public double GetFloat32(int byteOffset, bool littleEndian) { return default(double); }
        [JsMethod(Name = "getFloat64")]
        public double GetFloat64(int byteOffset) { return default(double); }
        [JsMethod(Name = "getFloat64")]
        public double GetFloat64(int byteOffset, bool littleEndian) { return default(double); }
        [JsMethod(Name = "setInt8")]
        public void SetInt8(int byteOffset, sbyte value) { }
        [JsMethod(Name = "setUint8")]
        public void SetUint8(int byteOffset, byte value) { }
        [JsMethod(Name = "setInt16")]
        public void SetInt16(int byteOffset, short value) { }
        [JsMethod(Name = "setInt16")]
        public void SetInt16(int byteOffset, short value, bool littleEndian) { }
        [JsMethod(Name = "setUint16")]
        public void SetUint16(int byteOffset, int value) { }
        [JsMethod(Name = "setUint16")]
        public void SetUint16(int byteOffset, int value, bool littleEndian) { }
        [JsMethod(Name = "setInt32")]
        public void SetInt32(int byteOffset, int value) { }
        [JsMethod(Name = "setInt32")]
        public void SetInt32(int byteOffset, int value, bool littleEndian) { }
        [JsMethod(Name = "setUint32")]
        public void SetUint32(int byteOffset, int value) { }
        [JsMethod(Name = "setUint32")]
        public void SetUint32(int byteOffset, int value, bool littleEndian) { }
        [JsMethod(Name = "setFloat32")]
        public void SetFloat32(int byteOffset, double value) { }
        [JsMethod(Name = "setFloat32")]
        public void SetFloat32(int byteOffset, double value, bool littleEndian) { }
        [JsMethod(Name = "setFloat64")]
        public void SetFloat64(int byteOffset, double value) { }
        [JsMethod(Name = "setFloat64")]
        public void SetFloat64(int byteOffset, double value, bool littleEndian) { }
    }

}