
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/xml/XMLHttpRequest.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

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

namespace SharpKit.Html
{

using SharpKit.JavaScript;
using SharpKit.Html.fileapi;
using SharpKit.Html.html.shadow;
using SharpKit.Html.html.track;
using SharpKit.Html.inspector;
using SharpKit.Html.loader.appcache;
using SharpKit.Html.battery;
using SharpKit.Html.filesystem;
using SharpKit.Html.gamepad;
using SharpKit.Html.geolocation;
using SharpKit.Html.indexeddb;
using SharpKit.Html.intents;
using SharpKit.Html.mediasource;
using SharpKit.Html.mediastream;
using SharpKit.Html.navigatorcontentutils;
using SharpKit.Html.networkinfo;
using SharpKit.Html.notifications;
using SharpKit.Html.proximity;
using SharpKit.Html.quota;
using SharpKit.Html.speech;
using SharpKit.Html.vibration;
using SharpKit.Html.webaudio;
using SharpKit.Html.webdatabase;
using SharpKit.Html.plugins;
using SharpKit.Html.storage;
using SharpKit.Html.svg;
using SharpKit.Html.workers;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "XMLHttpRequest")]
public partial class XMLHttpRequest
{
	public   XMLHttpRequest() {}
	public  EventListener onabort {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onload {get; set; }
	public  EventListener onloadend {get; set; }
	public  EventListener onloadstart {get; set; }
	public  EventListener<ProgressEvent> onprogress {get; set; }
	public  EventListener ontimeout {get; set; }
	public  EventListener onreadystatechange {get; set; }
	public  static int UNSENT = 0;
	public  static int OPENED = 1;
	public  static int HEADERS_RECEIVED = 2;
	public  static int LOADING = 3;
	public  static int DONE = 4;
	public  int timeout {get; set; }
	public  int readyState {get; set; }
	public  bool withCredentials {get; set; }
	public  void open(string method, string url) {}
	public  void open(string method, string url, bool @async) {}
	public  void open(string method, string url, bool @async, string user) {}
	public  void open(string method, string url, bool @async, string user, string password) {}
	public  void setRequestHeader(string header, string value) {}
	public  void send() {}
	public  void send(ArrayBuffer data) {}
	public  void send(ArrayBufferView data) {}
	public  void send(Blob data) {}
	public  void send(Document data) {}
	public  void send(string data) {}
	public  void send(FormData data) {}
	public  void abort() {}
	public  XMLHttpRequestUpload upload {get; set; }
	public  JsString getAllResponseHeaders() { return default(JsString); }
	public  JsString getResponseHeader(string header) { return default(JsString); }
	public  JsString responseText {get; set; }
	public  Document responseXML {get; set; }
	public  JsString responseType {get; set; }
	public  object response {get; set; }
	public  int status {get; set; }
	public  JsString statusText {get; set; }
	public  void overrideMimeType(string @override) {}
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
}

}