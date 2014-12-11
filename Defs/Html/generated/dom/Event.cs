
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Event.idl

  PLEASE DO *NOT* MODIFY THIS FILE! This file will be overridden next generation. If you need changes:
  - All classes marked as "partial". Use the custom.cs in the root folder, to extend the classes.
  - or regenerate the project with the newest IDL files.
  - or modifiy the WebIDLParser tool itself.

********************************************************************************************************

  Copyright (C) 2014 Sebastian Loncar, Web: http://loncar.de
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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Event")]
public partial class DOMEvent
{
	public  const int NONE = 0;
	public  const int CAPTURING_PHASE = 1;
	public  const int AT_TARGET = 2;
	public  const int BUBBLING_PHASE = 3;
	public  const int MOUSEDOWN = 1;
	public  const int MOUSEUP = 2;
	public  const int MOUSEOVER = 4;
	public  const int MOUSEOUT = 8;
	public  const int MOUSEMOVE = 16;
	public  const int MOUSEDRAG = 32;
	public  const int CLICK = 64;
	public  const int DBLCLICK = 128;
	public  const int KEYDOWN = 256;
	public  const int KEYUP = 512;
	public  const int KEYPRESS = 1024;
	public  const int DRAGDROP = 2048;
	public  const int FOCUS = 4096;
	public  const int BLUR = 8192;
	public  const int SELECT = 16384;
	public  const int CHANGE = 32768;
	public  JsString type {get; set; }
	public  EventTarget target {get; set; }
	public  EventTarget currentTarget {get; set; }
	public  int eventPhase {get; set; }
	public  bool bubbles {get; set; }
	public  bool cancelable {get; set; }
	public  object timeStamp {get; set; }
	public  void stopPropagation() {}
	public  void preventDefault() {}
	public  void initEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg) {}
	public  bool defaultPrevented {get; set; }
	public  void stopImmediatePropagation() {}
	public  EventTarget srcElement {get; set; }
	public  bool returnValue {get; set; }
	public  bool cancelBubble {get; set; }
	public  Clipboard clipboardData {get; set; }
}

}