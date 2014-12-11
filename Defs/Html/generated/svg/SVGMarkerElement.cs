
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGMarkerElement.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGMarkerElement")]
public partial class SvgMarkerElement : SvgElement, SvgLangSpace, SvgExternalResourcesRequired, SvgStylable, SvgFitToViewBox
{
	[JsMethod(OmitParanthesis = true, OmitNewOperator = true, Name = "document.createElement('marker')")]
	public   SvgMarkerElement() {}
	public  const int SVG_MARKERUNITS_UNKNOWN = 0;
	public  const int SVG_MARKERUNITS_USERSPACEONUSE = 1;
	public  const int SVG_MARKERUNITS_STROKEWIDTH = 2;
	public  const int SVG_MARKER_ORIENT_UNKNOWN = 0;
	public  const int SVG_MARKER_ORIENT_AUTO = 1;
	public  const int SVG_MARKER_ORIENT_ANGLE = 2;
	public  SvgAnimatedLength refX {get; set; }
	public  SvgAnimatedLength refY {get; set; }
	public  SvgAnimatedEnumeration markerUnits {get; set; }
	public  SvgAnimatedLength markerWidth {get; set; }
	public  SvgAnimatedLength markerHeight {get; set; }
	public  SvgAnimatedEnumeration orientType {get; set; }
	public  SvgAnimatedAngle orientAngle {get; set; }
	public  void setOrientToAuto() {}
	public  void setOrientToAngle(SvgAngle angle) {}
	public  JsString xmllang {get; set; }
	public  JsString xmlspace {get; set; }
	public  SvgAnimatedBoolean externalResourcesRequired {get; set; }
	public  SvgAnimatedString className {get; set; }
	public  CssStyleDeclaration style {get; set; }
	public  CssValue getPresentationAttribute(string name) { return default(CssValue); }
	public  SvgAnimatedRect viewBox {get; set; }
	public  SvgAnimatedPreserveAspectRatio preserveAspectRatio {get; set; }
}

}