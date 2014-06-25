
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGSVGElement.idl

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

namespace SharpKit.Html.svg
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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGSVGElement")]
public partial class SvgSvgElement : SvgElement, SvgTests, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgLocatable, SvgFitToViewBox, SvgZoomAndPan
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('svg')")]
	public   SvgSvgElement() {}
	public  SvgAnimatedLength x {get; set; }
	public  SvgAnimatedLength y {get; set; }
	public  SvgAnimatedLength width {get; set; }
	public  SvgAnimatedLength height {get; set; }
	public  JsString contentScriptType {get; set; }
	public  JsString contentStyleType {get; set; }
	public  SvgRect viewport {get; set; }
	public  double pixelUnitToMillimeterX {get; set; }
	public  double pixelUnitToMillimeterY {get; set; }
	public  double screenPixelToMillimeterX {get; set; }
	public  double screenPixelToMillimeterY {get; set; }
	public  bool useCurrentView {get; set; }
	public  SvgViewSpec currentView {get; set; }
	public  double currentScale {get; set; }
	public  SvgPoint currentTranslate {get; set; }
	public  int suspendRedraw(int maxWaitMilliseconds) { return default(int); }
	public  void unsuspendRedraw(int suspendHandleId) {}
	public  void unsuspendRedrawAll() {}
	public  void forceRedraw() {}
	public  void pauseAnimations() {}
	public  void unpauseAnimations() {}
	public  bool animationsPaused() { return default(bool); }
	public  double getCurrentTime() { return default(double); }
	public  void setCurrentTime(double seconds) {}
	public  NodeList getIntersectionList(SvgRect rect, SvgElement referenceElement) { return default(NodeList); }
	public  NodeList getEnclosureList(SvgRect rect, SvgElement referenceElement) { return default(NodeList); }
	public  bool checkIntersection(SvgElement element, SvgRect rect) { return default(bool); }
	public  bool checkEnclosure(SvgElement element, SvgRect rect) { return default(bool); }
	public  void deselectAll() {}
	public  SvgNumber createSVGNumber() { return default(SvgNumber); }
	public  SvgLength createSVGLength() { return default(SvgLength); }
	public  SvgAngle createSVGAngle() { return default(SvgAngle); }
	public  SvgPoint createSVGPoint() { return default(SvgPoint); }
	public  SvgMatrix createSVGMatrix() { return default(SvgMatrix); }
	public  SvgRect createSVGRect() { return default(SvgRect); }
	public  SvgTransform createSVGTransform() { return default(SvgTransform); }
	public  SvgTransform createSVGTransformFromMatrix(SvgMatrix matrix) { return default(SvgTransform); }
	public  Element getElementById(string elementId) { return default(Element); }
	public  SvgStringList requiredFeatures {get; set; }
	public  SvgStringList requiredExtensions {get; set; }
	public  SvgStringList systemLanguage {get; set; }
	public  bool hasExtension(string extension) { return default(bool); }
	public  JsString xmllang {get; set; }
	public  JsString xmlspace {get; set; }
	public  SvgAnimatedBoolean externalResourcesRequired {get; set; }
	public  SvgAnimatedString className {get; set; }
	public  CssStyleDeclaration style {get; set; }
	public  CssValue getPresentationAttribute(string name) { return default(CssValue); }
	public  SvgElement nearestViewportElement {get; set; }
	public  SvgElement farthestViewportElement {get; set; }
	public  SvgRect getBBox() { return default(SvgRect); }
	public  SvgMatrix getCTM() { return default(SvgMatrix); }
	public  SvgMatrix getScreenCTM() { return default(SvgMatrix); }
	public  SvgMatrix getTransformToElement(SvgElement element) { return default(SvgMatrix); }
	public  SvgAnimatedRect viewBox {get; set; }
	public  SvgAnimatedPreserveAspectRatio preserveAspectRatio {get; set; }
	public  int SVG_ZOOMANDPAN_UNKNOWN {get; private set; }
	public  int SVG_ZOOMANDPAN_DISABLE {get; private set; }
	public  int SVG_ZOOMANDPAN_MAGNIFY {get; private set; }
	public  int zoomAndPan {get; set; }
}

}