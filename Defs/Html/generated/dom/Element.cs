
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Element.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Element")]
public partial class Element : Node
{
	public  JsString tagName {get; set; }
	public  JsString getAttribute(string name) { return default(JsString); }
	public  void setAttribute(string name, string value) {}
	public  void removeAttribute(string name) {}
	public  Attr getAttributeNode(string name) { return default(Attr); }
	public  Attr setAttributeNode(Attr newAttr) { return default(Attr); }
	public  Attr removeAttributeNode(Attr oldAttr) { return default(Attr); }
	public  NodeList getElementsByTagName(string name) { return default(NodeList); }
	public  JsString getAttributeNS(string namespaceURI, string localName) { return default(JsString); }
	public  void setAttributeNS(string namespaceURI, string qualifiedName, string value) {}
	public  void removeAttributeNS(string namespaceURI, string localName) {}
	public  NodeList getElementsByTagNameNS(string namespaceURI, string localName) { return default(NodeList); }
	public  Attr getAttributeNodeNS(string namespaceURI, string localName) { return default(Attr); }
	public  Attr setAttributeNodeNS(Attr newAttr) { return default(Attr); }
	public  bool hasAttribute(string name) { return default(bool); }
	public  bool hasAttributeNS(string namespaceURI, string localName) { return default(bool); }
	public  CssStyleDeclaration style {get; set; }
	public  int offsetLeft {get; set; }
	public  int offsetTop {get; set; }
	public  int offsetWidth {get; set; }
	public  int offsetHeight {get; set; }
	public  Element offsetParent {get; set; }
	public  int clientLeft {get; set; }
	public  int clientTop {get; set; }
	public  int clientWidth {get; set; }
	public  int clientHeight {get; set; }
	public  int scrollLeft {get; set; }
	public  int scrollTop {get; set; }
	public  int scrollWidth {get; set; }
	public  int scrollHeight {get; set; }
	public  void focus() {}
	public  void blur() {}
	public  void scrollIntoView() {}
	public  void scrollIntoView(bool alignWithTop) {}
	public  void scrollIntoViewIfNeeded() {}
	public  void scrollIntoViewIfNeeded(bool centerIfNeeded) {}
	public  void scrollByLines(int lines) {}
	public  void scrollByPages(int pages) {}
	public  NodeList getElementsByClassName(string name) { return default(NodeList); }
	public  JsString className {get; set; }
	public  DOMTokenList classList {get; set; }
	public  DOMStringMap dataset {get; set; }
	public  Element querySelector(string selectors) { return default(Element); }
	public  NodeList querySelectorAll(string selectors) { return default(NodeList); }
	public  Element firstElementChild {get; set; }
	public  Element lastElementChild {get; set; }
	public  Element previousElementSibling {get; set; }
	public  Element nextElementSibling {get; set; }
	public  int childElementCount {get; set; }
	public  void remove() {}
	public  ClientRectList getClientRects() { return default(ClientRectList); }
	public  ClientRect getBoundingClientRect() { return default(ClientRect); }
	public  EventListener onabort {get; set; }
	public  EventListener onblur {get; set; }
	public  EventListener onchange {get; set; }
	public  EventListener onclick {get; set; }
	public  EventListener oncontextmenu {get; set; }
	public  EventListener ondblclick {get; set; }
	public  EventListener ondrag {get; set; }
	public  EventListener ondragend {get; set; }
	public  EventListener ondragenter {get; set; }
	public  EventListener ondragleave {get; set; }
	public  EventListener ondragover {get; set; }
	public  EventListener ondragstart {get; set; }
	public  EventListener ondrop {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onfocus {get; set; }
	public  EventListener oninput {get; set; }
	public  EventListener oninvalid {get; set; }
	public  EventListener onkeydown {get; set; }
	public  EventListener onkeypress {get; set; }
	public  EventListener onkeyup {get; set; }
	public  EventListener onload {get; set; }
	public  EventListener onmousedown {get; set; }
	public  EventListener onmousemove {get; set; }
	public  EventListener onmouseout {get; set; }
	public  EventListener onmouseover {get; set; }
	public  EventListener onmouseup {get; set; }
	public  EventListener onmousewheel {get; set; }
	public  EventListener onscroll {get; set; }
	public  EventListener onselect {get; set; }
	public  EventListener onsubmit {get; set; }
	public  EventListener onbeforecut {get; set; }
	public  EventListener oncut {get; set; }
	public  EventListener onbeforecopy {get; set; }
	public  EventListener oncopy {get; set; }
	public  EventListener onbeforepaste {get; set; }
	public  EventListener onpaste {get; set; }
	public  EventListener onreset {get; set; }
	public  EventListener onsearch {get; set; }
	public  EventListener onselectstart {get; set; }
	public  EventListener ontouchstart {get; set; }
	public  EventListener ontouchmove {get; set; }
	public  EventListener ontouchend {get; set; }
	public  EventListener ontouchcancel {get; set; }
}

}