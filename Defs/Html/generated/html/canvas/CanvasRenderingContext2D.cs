
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/html/canvas/CanvasRenderingContext2D.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "CanvasRenderingContext2D")]
public partial class CanvasRenderingContext2D : CanvasRenderingContext
{
	public  void save() {}
	public  void restore() {}
	public  void scale(double sx, double sy) {}
	public  void rotate(double angle) {}
	public  void translate(double tx, double ty) {}
	public  void transform(double m11, double m12, double m21, double m22, double dx, double dy) {}
	public  void setTransform(double m11, double m12, double m21, double m22, double dx, double dy) {}
	public  double globalAlpha {get; set; }
	public  JsString globalCompositeOperation {get; set; }
	public  CanvasGradient createLinearGradient(double x0, double y0, double x1, double y1) { return default(CanvasGradient); }
	public  CanvasGradient createRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1) { return default(CanvasGradient); }
	public  double lineWidth {get; set; }
	public  JsString lineCap {get; set; }
	public  JsString lineJoin {get; set; }
	public  double miterLimit {get; set; }
	public  double shadowOffsetX {get; set; }
	public  double shadowOffsetY {get; set; }
	public  double shadowBlur {get; set; }
	public  JsString shadowColor {get; set; }
	public  void setLineDash(double dash) {}
	public  double getLineDash() { return default(double); }
	public  double lineDashOffset {get; set; }
	public  void clearRect(double x, double y, double width, double height) {}
	public  void fillRect(double x, double y, double width, double height) {}
	public  void beginPath() {}
	public  void closePath() {}
	public  void moveTo(double x, double y) {}
	public  void lineTo(double x, double y) {}
	public  void quadraticCurveTo(double cpx, double cpy, double x, double y) {}
	public  void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) {}
	public  void arcTo(double x1, double y1, double x2, double y2, double radius) {}
	public  void rect(double x, double y, double width, double height) {}
	public  void arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise) {}
	public  void fill() {}
	public  void stroke() {}
	public  void clip() {}
	public  bool isPointInPath(double x, double y) { return default(bool); }
	public  JsString font {get; set; }
	public  JsString textAlign {get; set; }
	public  JsString textBaseline {get; set; }
	public  TextMetrics measureText(string text) { return default(TextMetrics); }
	public  void setAlpha(double alpha) {}
	public  void setCompositeOperation(string compositeOperation) {}
	public  void setLineWidth(double width) {}
	public  void setLineCap(string cap) {}
	public  void setLineJoin(string join) {}
	public  void setMiterLimit(double limit) {}
	public  void clearShadow() {}
	public  void fillText(string text, double x, double y) {}
	public  void fillText(string text, double x, double y, double maxWidth) {}
	public  void strokeText(string text, double x, double y) {}
	public  void strokeText(string text, double x, double y, double maxWidth) {}
	public  void setStrokeColor(string color) {}
	public  void setStrokeColor(string color, double alpha) {}
	public  void setStrokeColor(double grayLevel) {}
	public  void setStrokeColor(double grayLevel, double alpha) {}
	public  void setStrokeColor(double r, double g, double b, double a) {}
	public  void setStrokeColor(double c, double m, double y, double k, double a) {}
	public  void setFillColor(string color) {}
	public  void setFillColor(string color, double alpha) {}
	public  void setFillColor(double grayLevel) {}
	public  void setFillColor(double grayLevel, double alpha) {}
	public  void setFillColor(double r, double g, double b, double a) {}
	public  void setFillColor(double c, double m, double y, double k, double a) {}
	public  void strokeRect(double x, double y, double width, double height) {}
	public  void strokeRect(double x, double y, double width, double height, double lineWidth) {}
	public  void drawImage(HtmlImageElement image, double x, double y) {}
	public  void drawImage(HtmlImageElement image, double x, double y, double width, double height) {}
	public  void drawImage(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) {}
	public  void drawImage(HtmlCanvasElement canvas, double x, double y) {}
	public  void drawImage(HtmlCanvasElement canvas, double x, double y, double width, double height) {}
	public  void drawImage(HtmlCanvasElement canvas, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) {}
	public  void drawImageFromRect(HtmlImageElement image) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) {}
	public  void drawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh, string compositeOperation) {}
	public  void setShadow(double width, double height, double blur) {}
	public  void setShadow(double width, double height, double blur, string color) {}
	public  void setShadow(double width, double height, double blur, string color, double alpha) {}
	public  void setShadow(double width, double height, double blur, double grayLevel) {}
	public  void setShadow(double width, double height, double blur, double grayLevel, double alpha) {}
	public  void setShadow(double width, double height, double blur, double r, double g, double b, double a) {}
	public  void setShadow(double width, double height, double blur, double c, double m, double y, double k, double a) {}
	public  void putImageData(ImageData imagedata, double dx, double dy) {}
	public  void putImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight) {}
	public  CanvasPattern createPattern(HtmlCanvasElement canvas, string repetitionType) { return default(CanvasPattern); }
	public  CanvasPattern createPattern(HtmlImageElement image, string repetitionType) { return default(CanvasPattern); }
	public  ImageData createImageData(ImageData imagedata) { return default(ImageData); }
	public  ImageData createImageData(double sw, double sh) { return default(ImageData); }
	public  object strokeStyle {get; set; }
	public  object fillStyle {get; set; }
	public  ImageData getImageData(double sx, double sy, double sw, double sh) { return default(ImageData); }
}

}