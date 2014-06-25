
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Range.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Range")]
public partial class Range
{
	public  Node startContainer {get; set; }
	public  int startOffset {get; set; }
	public  Node endContainer {get; set; }
	public  int endOffset {get; set; }
	public  bool collapsed {get; set; }
	public  Node commonAncestorContainer {get; set; }
	public  void setStart(Node refNode, int offset) {}
	public  void setEnd(Node refNode, int offset) {}
	public  void setStartBefore(Node refNode) {}
	public  void setStartAfter(Node refNode) {}
	public  void setEndBefore(Node refNode) {}
	public  void setEndAfter(Node refNode) {}
	public  void collapse(bool toStart) {}
	public  void selectNode(Node refNode) {}
	public  void selectNodeContents(Node refNode) {}
	public  static int START_TO_START = 0;
	public  static int START_TO_END = 1;
	public  static int END_TO_END = 2;
	public  static int END_TO_START = 3;
	public  short compareBoundaryPoints(object how, Range sourceRange) { return default(short); }
	public  void deleteContents() {}
	public  DocumentFragment extractContents() { return default(DocumentFragment); }
	public  DocumentFragment cloneContents() { return default(DocumentFragment); }
	public  void insertNode(Node newNode) {}
	public  void surroundContents(Node newParent) {}
	public  Range cloneRange() { return default(Range); }
	public  JsString toString() { return default(JsString); }
	public  void detach() {}
	public  ClientRectList getClientRects() { return default(ClientRectList); }
	public  ClientRect getBoundingClientRect() { return default(ClientRect); }
	public  DocumentFragment createContextualFragment(string html) { return default(DocumentFragment); }
	public  bool intersectsNode(Node refNode) { return default(bool); }
	public  short compareNode(Node refNode) { return default(short); }
	public  static int NODE_BEFORE = 0;
	public  static int NODE_AFTER = 1;
	public  static int NODE_BEFORE_AND_AFTER = 2;
	public  static int NODE_INSIDE = 3;
	public  short comparePoint(Node refNode, int offset) { return default(short); }
	public  bool isPointInRange(Node refNode, int offset) { return default(bool); }
	public  void expand(string unit) {}
}

}