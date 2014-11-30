
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/svg/SVGPathSeg.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "SVGPathSeg")]
public partial class SvgPathSeg
{
	public  static int PATHSEG_UNKNOWN = 0;
	public  static int PATHSEG_CLOSEPATH = 1;
	public  static int PATHSEG_MOVETO_ABS = 2;
	public  static int PATHSEG_MOVETO_REL = 3;
	public  static int PATHSEG_LINETO_ABS = 4;
	public  static int PATHSEG_LINETO_REL = 5;
	public  static int PATHSEG_CURVETO_CUBIC_ABS = 6;
	public  static int PATHSEG_CURVETO_CUBIC_REL = 7;
	public  static int PATHSEG_CURVETO_QUADRATIC_ABS = 8;
	public  static int PATHSEG_CURVETO_QUADRATIC_REL = 9;
	public  static int PATHSEG_ARC_ABS = 10;
	public  static int PATHSEG_ARC_REL = 11;
	public  static int PATHSEG_LINETO_HORIZONTAL_ABS = 12;
	public  static int PATHSEG_LINETO_HORIZONTAL_REL = 13;
	public  static int PATHSEG_LINETO_VERTICAL_ABS = 14;
	public  static int PATHSEG_LINETO_VERTICAL_REL = 15;
	public  static int PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16;
	public  static int PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17;
	public  static int PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18;
	public  static int PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19;
	public  int pathSegType {get; set; }
	public  JsString pathSegTypeAsLetter {get; set; }
}

}