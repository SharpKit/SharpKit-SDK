
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/dom/Document.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Document")]
public partial class Document : Node
{
	public  DocumentType doctype {get; set; }
	public  DOMImplementation implementation {get; set; }
	public  Element documentElement {get; set; }
	public  Element createElement(string tagName) { return default(Element); }
	public  DocumentFragment createDocumentFragment() { return default(DocumentFragment); }
	public  Text createTextNode(string data) { return default(Text); }
	public  Comment createComment(string data) { return default(Comment); }
	public  CDATASection createCDATASection(string data) { return default(CDATASection); }
	public  ProcessingInstruction createProcessingInstruction(string target, string data) { return default(ProcessingInstruction); }
	public  Attr createAttribute(string name) { return default(Attr); }
	public  EntityReference createEntityReference(string name) { return default(EntityReference); }
	public  NodeList getElementsByTagName(string tagname) { return default(NodeList); }
	public  Node importNode(Node importedNode) { return default(Node); }
	public  Node importNode(Node importedNode, bool deep) { return default(Node); }
	public  Element createElementNS(string namespaceURI, string qualifiedName) { return default(Element); }
	public  Attr createAttributeNS(string namespaceURI, string qualifiedName) { return default(Attr); }
	public  NodeList getElementsByTagNameNS(string namespaceURI, string localName) { return default(NodeList); }
	public  Element getElementById(string elementId) { return default(Element); }
	public  JsString inputEncoding {get; set; }
	public  JsString xmlEncoding {get; set; }
	public  JsString xmlVersion {get; set; }
	public  bool xmlStandalone {get; set; }
	public  Node adoptNode(Node source) { return default(Node); }
	public  JsString documentURI {get; set; }
	public  DOMEvent createEvent(string eventType) { return default(DOMEvent); }
	public  Range createRange() { return default(Range); }
	public  NodeIterator createNodeIterator(Node root, int whatToShow, NodeFilter filter, bool expandEntityReferences) { return default(NodeIterator); }
	public  TreeWalker createTreeWalker(Node root, int whatToShow, NodeFilter filter, bool expandEntityReferences) { return default(TreeWalker); }
	public  Window defaultView {get; set; }
	public  StyleSheetList styleSheets {get; set; }
	public  CssStyleDeclaration getOverrideStyle(Element element, string pseudoElement) { return default(CssStyleDeclaration); }
	public  XPathExpression createExpression(string expression, XPathNSResolver resolver) { return default(XPathExpression); }
	public  XPathNSResolver createNSResolver(Node nodeResolver) { return default(XPathNSResolver); }
	public  XPathResult evaluate(string expression, Node contextNode, XPathNSResolver resolver, int type, XPathResult inResult) { return default(XPathResult); }
	public  bool execCommand(string command, bool userInterface, string value) { return default(bool); }
	public  bool queryCommandEnabled(string command) { return default(bool); }
	public  bool queryCommandIndeterm(string command) { return default(bool); }
	public  bool queryCommandState(string command) { return default(bool); }
	public  bool queryCommandSupported(string command) { return default(bool); }
	public  JsString queryCommandValue(string command) { return default(JsString); }
	public  JsString title {get; set; }
	public  JsString referrer {get; set; }
	public  JsString domain {get; set; }
	public  JsString URL {get; set; }
	public  JsString cookie {get; set; }
	public  HtmlElement body {get; set; }
	public  HtmlHeadElement head {get; set; }
	public  HtmlCollection images {get; set; }
	public  HtmlCollection applets {get; set; }
	public  HtmlCollection links {get; set; }
	public  HtmlCollection forms {get; set; }
	public  HtmlCollection anchors {get; set; }
	public  JsString lastModified {get; set; }
	public  NodeList getElementsByName(string elementName) { return default(NodeList); }
	public  Location location {get; set; }
	public  JsString charset {get; set; }
	public  JsString defaultCharset {get; set; }
	public  JsString readyState {get; set; }
	public  Element elementFromPoint(int x, int y) { return default(Element); }
	public  Range caretRangeFromPoint(int x, int y) { return default(Range); }
	public  Selection getSelection() { return default(Selection); }
	public  JsString characterSet {get; set; }
	public  JsString preferredStylesheetSet {get; set; }
	public  JsString selectedStylesheetSet {get; set; }
	public  CanvasRenderingContext getCSSCanvasContext(string contextId, string name, int width, int height) { return default(CanvasRenderingContext); }
	public  NodeList getElementsByClassName(string tagname) { return default(NodeList); }
	public  JsString compatMode {get; set; }
	public  Element querySelector(string selectors) { return default(Element); }
	public  NodeList querySelectorAll(string selectors) { return default(NodeList); }
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
	public  EventListener onreadystatechange {get; set; }
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
	public  EventListener onselectionchange {get; set; }
	public  EventListener ontouchstart {get; set; }
	public  EventListener ontouchmove {get; set; }
	public  EventListener ontouchend {get; set; }
	public  EventListener ontouchcancel {get; set; }
	public  SecurityPolicy securityPolicy {get; set; }
}

}