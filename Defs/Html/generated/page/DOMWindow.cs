
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/page/DOMWindow.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "Window")]
public partial class Window
{
	public  Screen screen {get; set; }
	public  History history {get; set; }
	public  BarInfo locationbar {get; set; }
	public  BarInfo menubar {get; set; }
	public  BarInfo personalbar {get; set; }
	public  BarInfo scrollbars {get; set; }
	public  BarInfo statusbar {get; set; }
	public  BarInfo toolbar {get; set; }
	public  Navigator navigator {get; set; }
	public  Navigator clientInformation {get; set; }
	public  Crypto crypto {get; set; }
	public  Location location {get; set; }
	public  DOMEvent @event {get; set; }
	public  Selection getSelection() { return default(Selection); }
	public  Element frameElement {get; set; }
	public  void focus() {}
	public  void blur() {}
	public  void close() {}
	public  void print() {}
	public  void stop() {}
	public  Window open(string url, string name) { return default(Window); }
	public  Window open(string url, string name, string options) { return default(Window); }
	public  object showModalDialog(string url) { return default(object); }
	public  object showModalDialog(string url, object dialogArgs) { return default(object); }
	public  object showModalDialog(string url, object dialogArgs, string featureArgs) { return default(object); }
	public  void alert(string message) {}
	public  bool confirm(string message) { return default(bool); }
	public  JsString prompt(string message, string defaultValue) { return default(JsString); }
	public  bool find(string @string, bool caseSensitive, bool backwards, bool wrap, bool wholeWord, bool searchInFrames, bool showDialog) { return default(bool); }
	public  bool offscreenBuffering {get; set; }
	public  int outerHeight {get; set; }
	public  int outerWidth {get; set; }
	public  int innerHeight {get; set; }
	public  int innerWidth {get; set; }
	public  int screenX {get; set; }
	public  int screenY {get; set; }
	public  int screenLeft {get; set; }
	public  int screenTop {get; set; }
	public  int scrollX {get; set; }
	public  int scrollY {get; set; }
	public  int pageXOffset {get; set; }
	public  int pageYOffset {get; set; }
	public  void scrollBy(int x, int y) {}
	public  void scrollTo(int x, int y) {}
	public  void scroll(int x, int y) {}
	public  void moveBy(double x, double y) {}
	public  void moveTo(double x, double y) {}
	public  void resizeBy(double x, double y) {}
	public  void resizeTo(double width, double height) {}
	public  bool closed {get; set; }
	public  int length {get; set; }
	public  JsString name {get; set; }
	public  JsString status {get; set; }
	public  JsString defaultStatus {get; set; }
	public  JsString defaultstatus {get; set; }
	public  Window self {get; set; }
	public  Window window {get; set; }
	public  Window frames {get; set; }
	public  Window opener {get; set; }
	public  Window parent {get; set; }
	public  Window top {get; set; }
	public  Document document {get; set; }
	public  MediaQueryList matchMedia(string query) { return default(MediaQueryList); }
	public  StyleMedia styleMedia {get; set; }
	public  CssStyleDeclaration getComputedStyle(Element element, string pseudoElement) { return default(CssStyleDeclaration); }
	public  CssRuleList getMatchedCSSRules(Element element, string pseudoElement) { return default(CssRuleList); }
	public  double devicePixelRatio {get; set; }
	public  DOMApplicationCache applicationCache {get; set; }
	public  Storage sessionStorage {get; set; }
	public  Storage localStorage {get; set; }
	public  Console console {get; set; }
	public  void postMessage(object message, string targetOrigin) {}
	public  void postMessage(object message, string targetOrigin, Array messagePorts) {}
	public  int setTimeout(object handler, int timeout) { return default(int); }
	public  void clearTimeout(int handle) {}
	public  int setInterval(object handler, int timeout) { return default(int); }
	public  void clearInterval(int handle) {}
	public  JsString atob(string @string) { return default(JsString); }
	public  JsString btoa(string @string) { return default(JsString); }
	public  EventListener onabort {get; set; }
	public  EventListener onbeforeunload {get; set; }
	public  EventListener onblur {get; set; }
	public  EventListener oncanplay {get; set; }
	public  EventListener oncanplaythrough {get; set; }
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
	public  EventListener ondurationchange {get; set; }
	public  EventListener onemptied {get; set; }
	public  EventListener onended {get; set; }
	public  EventListener<ErrorEvent> onerror {get; set; }
	public  EventListener onfocus {get; set; }
	public  EventListener<HashChangeEvent> onhashchange {get; set; }
	public  EventListener oninput {get; set; }
	public  EventListener oninvalid {get; set; }
	public  EventListener onkeydown {get; set; }
	public  EventListener onkeypress {get; set; }
	public  EventListener onkeyup {get; set; }
	public  EventListener onload {get; set; }
	public  EventListener onloadeddata {get; set; }
	public  EventListener onloadedmetadata {get; set; }
	public  EventListener onloadstart {get; set; }
	public  EventListener<MessageEvent> onmessage {get; set; }
	public  EventListener onmousedown {get; set; }
	public  EventListener onmousemove {get; set; }
	public  EventListener onmouseout {get; set; }
	public  EventListener onmouseover {get; set; }
	public  EventListener onmouseup {get; set; }
	public  EventListener onmousewheel {get; set; }
	public  EventListener onoffline {get; set; }
	public  EventListener ononline {get; set; }
	public  EventListener onpagehide {get; set; }
	public  EventListener onpageshow {get; set; }
	public  EventListener onpause {get; set; }
	public  EventListener onplay {get; set; }
	public  EventListener onplaying {get; set; }
	public  EventListener<PopStateEvent> onpopstate {get; set; }
	public  EventListener<ProgressEvent> onprogress {get; set; }
	public  EventListener onratechange {get; set; }
	public  EventListener onresize {get; set; }
	public  EventListener onscroll {get; set; }
	public  EventListener onseeked {get; set; }
	public  EventListener onseeking {get; set; }
	public  EventListener onselect {get; set; }
	public  EventListener onstalled {get; set; }
	public  EventListener<StorageEvent> onstorage {get; set; }
	public  EventListener onsubmit {get; set; }
	public  EventListener onsuspend {get; set; }
	public  EventListener ontimeupdate {get; set; }
	public  EventListener onunload {get; set; }
	public  EventListener onvolumechange {get; set; }
	public  EventListener onwaiting {get; set; }
	public  EventListener onreset {get; set; }
	public  EventListener onsearch {get; set; }
	public  EventListener ontouchstart {get; set; }
	public  EventListener ontouchmove {get; set; }
	public  EventListener ontouchend {get; set; }
	public  EventListener ontouchcancel {get; set; }
	public  EventListener<DeviceMotionEvent> ondevicemotion {get; set; }
	public  EventListener<DeviceOrientationEvent> ondeviceorientation {get; set; }
	public  void addEventListener(string type, EventListener listener) {}
	public  void addEventListener(string type, EventListener listener, bool useCapture) {}
	public  void removeEventListener(string type, EventListener listener) {}
	public  void removeEventListener(string type, EventListener listener, bool useCapture) {}
	public  bool dispatchEvent(DOMEvent evt) { return default(bool); }
	public  void captureEvents() {}
	public  void releaseEvents() {}
	public  StyleSheet StyleSheet {get; set; }
	public  CssStyleSheet CSSStyleSheet {get; set; }
	public  CssValue CSSValue {get; set; }
	public  CssPrimitiveValue CSSPrimitiveValue {get; set; }
	public  CssValueList CSSValueList {get; set; }
	public  CssRule CSSRule {get; set; }
	public  CssCharsetRule CSSCharsetRule {get; set; }
	public  CssFontFaceRule CSSFontFaceRule {get; set; }
	public  CssImportRule CSSImportRule {get; set; }
	public  CssMediaRule CSSMediaRule {get; set; }
	public  CssPageRule CSSPageRule {get; set; }
	public  CssStyleRule CSSStyleRule {get; set; }
	public  CssStyleDeclaration CSSStyleDeclaration {get; set; }
	public  MediaList MediaList {get; set; }
	public  Counter Counter {get; set; }
	public  CssRuleList CSSRuleList {get; set; }
	public  Rect Rect {get; set; }
	public  RGBColor RGBColor {get; set; }
	public  StyleSheetList StyleSheetList {get; set; }
	public  object DOMException {get; set; }
	public  DOMStringList DOMStringList {get; set; }
	public  DOMImplementation DOMImplementation {get; set; }
	public  DOMSettableTokenList DOMSettableTokenList {get; set; }
	public  DOMTokenList DOMTokenList {get; set; }
	public  DocumentFragment DocumentFragment {get; set; }
	public  Document Document {get; set; }
	public  Node Node {get; set; }
	public  NodeList NodeList {get; set; }
	public  PropertyNodeList PropertyNodeList {get; set; }
	public  NamedNodeMap NamedNodeMap {get; set; }
	public  CharacterData CharacterData {get; set; }
	public  Attr Attr {get; set; }
	public  Element Element {get; set; }
	public  Text Text {get; set; }
	public  Comment Comment {get; set; }
	public  CDATASection CDATASection {get; set; }
	public  DocumentType DocumentType {get; set; }
	public  Notation Notation {get; set; }
	public  Entity Entity {get; set; }
	public  EntityReference EntityReference {get; set; }
	public  ProcessingInstruction ProcessingInstruction {get; set; }
	public  HtmlContentElement HTMLContentElement {get; set; }
	public  HtmlShadowElement HTMLShadowElement {get; set; }
	public  Selection Selection {get; set; }
	[JsProperty(Name="Window")]
	public  Window Window_ {get; set; }
	public  HtmlDocument HTMLDocument {get; set; }
	public  HtmlElement HTMLElement {get; set; }
	public  HtmlAnchorElement HTMLAnchorElement {get; set; }
	public  HtmlAppletElement HTMLAppletElement {get; set; }
	public  HtmlAreaElement HTMLAreaElement {get; set; }
	public  HtmlBRElement HTMLBRElement {get; set; }
	public  HtmlBaseElement HTMLBaseElement {get; set; }
	public  HtmlBaseFontElement HTMLBaseFontElement {get; set; }
	public  HtmlBodyElement HTMLBodyElement {get; set; }
	public  HtmlButtonElement HTMLButtonElement {get; set; }
	public  HtmlCanvasElement HTMLCanvasElement {get; set; }
	public  HtmlDListElement HTMLDListElement {get; set; }
	public  HtmlDataListElement HTMLDataListElement {get; set; }
	public  HtmlDialogElement HTMLDialogElement {get; set; }
	public  HtmlDirectoryElement HTMLDirectoryElement {get; set; }
	public  HtmlDivElement HTMLDivElement {get; set; }
	public  HtmlEmbedElement HTMLEmbedElement {get; set; }
	public  HtmlFieldSetElement HTMLFieldSetElement {get; set; }
	public  HtmlFontElement HTMLFontElement {get; set; }
	public  HtmlFormElement HTMLFormElement {get; set; }
	public  HtmlFrameElement HTMLFrameElement {get; set; }
	public  HtmlFrameSetElement HTMLFrameSetElement {get; set; }
	public  HtmlHRElement HTMLHRElement {get; set; }
	public  HtmlHeadElement HTMLHeadElement {get; set; }
	public  HtmlHeadingElement HTMLHeadingElement {get; set; }
	public  HtmlHtmlElement HTMLHtmlElement {get; set; }
	public  HtmlIFrameElement HTMLIFrameElement {get; set; }
	public  HtmlImageElement HTMLImageElement {get; set; }
	public  HtmlInputElement HTMLInputElement {get; set; }
	public  HtmlKeygenElement HTMLKeygenElement {get; set; }
	public  HtmlLIElement HTMLLIElement {get; set; }
	public  HtmlLabelElement HTMLLabelElement {get; set; }
	public  HtmlLegendElement HTMLLegendElement {get; set; }
	public  HtmlLinkElement HTMLLinkElement {get; set; }
	public  HtmlMapElement HTMLMapElement {get; set; }
	public  HtmlMarqueeElement HTMLMarqueeElement {get; set; }
	public  HtmlMenuElement HTMLMenuElement {get; set; }
	public  HtmlMetaElement HTMLMetaElement {get; set; }
	public  HtmlModElement HTMLModElement {get; set; }
	public  HtmlOListElement HTMLOListElement {get; set; }
	public  HtmlObjectElement HTMLObjectElement {get; set; }
	public  HtmlOptGroupElement HTMLOptGroupElement {get; set; }
	public  HtmlOptionElement HTMLOptionElement {get; set; }
	public  HtmlOutputElement HTMLOutputElement {get; set; }
	public  HtmlParagraphElement HTMLParagraphElement {get; set; }
	public  HtmlParamElement HTMLParamElement {get; set; }
	public  HtmlPreElement HTMLPreElement {get; set; }
	public  HtmlQuoteElement HTMLQuoteElement {get; set; }
	public  HtmlScriptElement HTMLScriptElement {get; set; }
	public  HtmlSelectElement HTMLSelectElement {get; set; }
	public  HtmlSpanElement HTMLSpanElement {get; set; }
	public  HtmlStyleElement HTMLStyleElement {get; set; }
	public  HtmlTableCaptionElement HTMLTableCaptionElement {get; set; }
	public  HtmlTableCellElement HTMLTableCellElement {get; set; }
	public  HtmlTableColElement HTMLTableColElement {get; set; }
	public  HtmlTableElement HTMLTableElement {get; set; }
	public  HtmlTableRowElement HTMLTableRowElement {get; set; }
	public  HtmlTableSectionElement HTMLTableSectionElement {get; set; }
	public  HtmlTemplateElement HTMLTemplateElement {get; set; }
	public  HtmlTextAreaElement HTMLTextAreaElement {get; set; }
	public  HtmlTitleElement HTMLTitleElement {get; set; }
	public  HtmlUListElement HTMLUListElement {get; set; }
	public  HtmlCollection HTMLCollection {get; set; }
	public  HtmlAllCollection HTMLAllCollection {get; set; }
	public  HtmlFormControlsCollection HTMLFormControlsCollection {get; set; }
	public  HtmlOptionsCollection HTMLOptionsCollection {get; set; }
	public  HtmlPropertiesCollection HTMLPropertiesCollection {get; set; }
	public  HtmlUnknownElement HTMLUnknownElement {get; set; }
	public  HtmlImageElement Image {get; set; }
	public  HtmlOptionElement Option {get; set; }
	public  MediaKeyError MediaKeyError {get; set; }
	public  MediaKeyEvent MediaKeyEvent {get; set; }
	public  HtmlTrackElement HTMLTrackElement {get; set; }
	public  TextTrack TextTrack {get; set; }
	public  TextTrackCue TextTrackCue {get; set; }
	public  TextTrackCueList TextTrackCueList {get; set; }
	public  TextTrackList TextTrackList {get; set; }
	public  TrackEvent TrackEvent {get; set; }
	public  HtmlAudioElement Audio {get; set; }
	public  HtmlAudioElement HTMLAudioElement {get; set; }
	public  HtmlMediaElement HTMLMediaElement {get; set; }
	public  HtmlVideoElement HTMLVideoElement {get; set; }
	public  MediaError MediaError {get; set; }
	public  TimeRanges TimeRanges {get; set; }
	public  HtmlSourceElement HTMLSourceElement {get; set; }
	public  MediaController MediaController {get; set; }
	public  HtmlIntentElement HTMLIntentElement {get; set; }
	public  CanvasPattern CanvasPattern {get; set; }
	public  CanvasGradient CanvasGradient {get; set; }
	public  CanvasRenderingContext2D CanvasRenderingContext2D {get; set; }
	public  ImageData ImageData {get; set; }
	public  TextMetrics TextMetrics {get; set; }
	public  WebGLActiveInfo WebGLActiveInfo {get; set; }
	public  WebGLBuffer WebGLBuffer {get; set; }
	public  WebGLFramebuffer WebGLFramebuffer {get; set; }
	public  WebGLProgram WebGLProgram {get; set; }
	public  WebGLRenderbuffer WebGLRenderbuffer {get; set; }
	public  WebGLRenderingContext WebGLRenderingContext {get; set; }
	public  WebGLShader WebGLShader {get; set; }
	public  WebGLShaderPrecisionFormat WebGLShaderPrecisionFormat {get; set; }
	public  WebGLTexture WebGLTexture {get; set; }
	public  WebGLUniformLocation WebGLUniformLocation {get; set; }
	public  DOMStringMap DOMStringMap {get; set; }
	public  ArrayBuffer ArrayBuffer {get; set; }
	public  ArrayBufferView ArrayBufferView {get; set; }
	public  Int8Array Int8Array {get; set; }
	public  Uint8Array Uint8Array {get; set; }
	public  Uint8ClampedArray Uint8ClampedArray {get; set; }
	public  Int16Array Int16Array {get; set; }
	public  Uint16Array Uint16Array {get; set; }
	public  Int32Array Int32Array {get; set; }
	public  Uint32Array Uint32Array {get; set; }
	public  Float32Array Float32Array {get; set; }
	public  Float64Array Float64Array {get; set; }
	public  DataView DataView {get; set; }
	public  DOMEvent Event {get; set; }
	public  BeforeLoadEvent BeforeLoadEvent {get; set; }
	public  CompositionEvent CompositionEvent {get; set; }
	public  CustomEvent CustomEvent {get; set; }
	public  ErrorEvent ErrorEvent {get; set; }
	public  HashChangeEvent HashChangeEvent {get; set; }
	public  KeyboardEvent KeyboardEvent {get; set; }
	public  MessageEvent MessageEvent {get; set; }
	public  MouseEvent MouseEvent {get; set; }
	public  MutationEvent MutationEvent {get; set; }
	public  OverflowEvent OverflowEvent {get; set; }
	public  PopStateEvent PopStateEvent {get; set; }
	public  PageTransitionEvent PageTransitionEvent {get; set; }
	public  ProgressEvent ProgressEvent {get; set; }
	public  TextEvent TextEvent {get; set; }
	public  UIEvent UIEvent {get; set; }
	public  WheelEvent WheelEvent {get; set; }
	public  XMLHttpRequestProgressEvent XMLHttpRequestProgressEvent {get; set; }
	public  DeviceMotionEvent DeviceMotionEvent {get; set; }
	public  DeviceOrientationEvent DeviceOrientationEvent {get; set; }
	public  Touch Touch {get; set; }
	public  TouchEvent TouchEvent {get; set; }
	public  TouchList TouchList {get; set; }
	public  StorageEvent StorageEvent {get; set; }
	public  SpeechInputEvent SpeechInputEvent {get; set; }
	public  WebGLContextEvent WebGLContextEvent {get; set; }
	public  DeviceProximityEvent DeviceProximityEvent {get; set; }
	public  object EventException {get; set; }
	public  Clipboard Clipboard {get; set; }
	public  Worker Worker {get; set; }
	public  SharedWorker SharedWorker {get; set; }
	public  File File {get; set; }
	public  FileList FileList {get; set; }
	public  Blob Blob {get; set; }
	public  NodeFilter NodeFilter {get; set; }
	public  Range Range {get; set; }
	public  object RangeException {get; set; }
	public  EventSource EventSource {get; set; }
	public  Document XMLDocument {get; set; }
	public  DOMParser DOMParser {get; set; }
	public  XMLSerializer XMLSerializer {get; set; }
	public  XMLHttpRequest XMLHttpRequest {get; set; }
	public  XMLHttpRequestUpload XMLHttpRequestUpload {get; set; }
	public  object XMLHttpRequestException {get; set; }
	public  XSLTProcessor XSLTProcessor {get; set; }
	public  Plugin Plugin {get; set; }
	public  PluginArray PluginArray {get; set; }
	public  MimeType MimeType {get; set; }
	public  MimeTypeArray MimeTypeArray {get; set; }
	public  ClientRect ClientRect {get; set; }
	public  ClientRectList ClientRectList {get; set; }
	public  Storage Storage {get; set; }
	public  XPathEvaluator XPathEvaluator {get; set; }
	public  XPathResult XPathResult {get; set; }
	public  object XPathException {get; set; }
	public  SvgZoomEvent SVGZoomEvent {get; set; }
	public  FormData FormData {get; set; }
	public  FileError FileError {get; set; }
	public  FileReader FileReader {get; set; }
	public  URL URL {get; set; }
}

}