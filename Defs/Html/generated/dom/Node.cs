
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Node.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Node")]
public partial class Node
{
	public  static int ELEMENT_NODE = 1;
	public  static int ATTRIBUTE_NODE = 2;
	public  static int TEXT_NODE = 3;
	public  static int CDATA_SECTION_NODE = 4;
	public  static int ENTITY_REFERENCE_NODE = 5;
	public  static int ENTITY_NODE = 6;
	public  static int PROCESSING_INSTRUCTION_NODE = 7;
	public  static int COMMENT_NODE = 8;
	public  static int DOCUMENT_NODE = 9;
	public  static int DOCUMENT_TYPE_NODE = 10;
	public  static int DOCUMENT_FRAGMENT_NODE = 11;
	public  static int NOTATION_NODE = 12;
	public  JsString nodeName {get; set; }
	public  JsString nodeValue {get; set; }
	public  int nodeType {get; set; }
	public  Node parentNode {get; set; }
	public  NodeList childNodes {get; set; }
	public  Node firstChild {get; set; }
	public  Node lastChild {get; set; }
	public  Node previousSibling {get; set; }
	public  Node nextSibling {get; set; }
	public  NamedNodeMap attributes {get; set; }
	public  Document ownerDocument {get; set; }
	public  Node insertBefore(Node newChild, Node refChild) { return default(Node); }
	public  Node replaceChild(Node newChild, Node oldChild) { return default(Node); }
	public  Node removeChild(Node oldChild) { return default(Node); }
	public  Node appendChild(Node newChild) { return default(Node); }
	public  bool hasChildNodes() { return default(bool); }
	public  Node cloneNode(bool deep) { return default(Node); }
	public  void normalize() {}
	public  bool isSupported(string feature, string version) { return default(bool); }
	public  JsString namespaceURI {get; set; }
	public  JsString prefix {get; set; }
	public  JsString localName {get; set; }
	public  bool hasAttributes() { return default(bool); }
	public  JsString baseURI {get; set; }
	public  JsString textContent {get; set; }
	public  bool isSameNode(Node other) { return default(bool); }
	public  bool isEqualNode(Node other) { return default(bool); }
	public  JsString lookupPrefix(string namespaceURI) { return default(JsString); }
	public  bool isDefaultNamespace(string namespaceURI) { return default(bool); }
	public  JsString lookupNamespaceURI(string prefix) { return default(JsString); }
	public  static int DOCUMENT_POSITION_DISCONNECTED = 0x01;
	public  static int DOCUMENT_POSITION_PRECEDING = 0x02;
	public  static int DOCUMENT_POSITION_FOLLOWING = 0x04;
	public  static int DOCUMENT_POSITION_CONTAINS = 0x08;
	public  static int DOCUMENT_POSITION_CONTAINED_BY = 0x10;
	public  static int DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC = 0x20;
	public  int compareDocumentPosition(Node other) { return default(int); }
	public  bool contains(Node other) { return default(bool); }
	public  Element parentElement {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent @event) { return default(bool); }
}

}