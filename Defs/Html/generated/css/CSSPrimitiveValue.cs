
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/css/CSSPrimitiveValue.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "CSSPrimitiveValue")]
public partial class CssPrimitiveValue : CssValue
{
	public  const int CSS_UNKNOWN = 0;
	public  const int CSS_NUMBER = 1;
	public  const int CSS_PERCENTAGE = 2;
	public  const int CSS_EMS = 3;
	public  const int CSS_EXS = 4;
	public  const int CSS_PX = 5;
	public  const int CSS_CM = 6;
	public  const int CSS_MM = 7;
	public  const int CSS_IN = 8;
	public  const int CSS_PT = 9;
	public  const int CSS_PC = 10;
	public  const int CSS_DEG = 11;
	public  const int CSS_RAD = 12;
	public  const int CSS_GRAD = 13;
	public  const int CSS_MS = 14;
	public  const int CSS_S = 15;
	public  const int CSS_HZ = 16;
	public  const int CSS_KHZ = 17;
	public  const int CSS_DIMENSION = 18;
	public  const int CSS_STRING = 19;
	public  const int CSS_URI = 20;
	public  const int CSS_IDENT = 21;
	public  const int CSS_ATTR = 22;
	public  const int CSS_COUNTER = 23;
	public  const int CSS_RECT = 24;
	public  const int CSS_RGBCOLOR = 25;
	public  const int CSS_VW = 26;
	public  const int CSS_VH = 27;
	public  const int CSS_VMIN = 28;
	public  int primitiveType {get; set; }
	public  void setFloatValue(int unitType, double floatValue) {}
	public  double getFloatValue(int unitType) { return default(double); }
	public  void setStringValue(int stringType, string stringValue) {}
	public  JsString getStringValue() { return default(JsString); }
	public  Counter getCounterValue() { return default(Counter); }
	public  Rect getRectValue() { return default(Rect); }
	public  RGBColor getRGBColorValue() { return default(RGBColor); }
}

}