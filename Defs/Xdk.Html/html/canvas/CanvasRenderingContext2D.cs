/*******************************************************************************************************
  This file was created/modified by Hervé PHILIPPE alchiweb[at]gmail.com
********************************************************************************************************

  Copyright (C) 2013 Hervé PHILIPPE, Web: http://xmadevlab.net

  Project based on the files auto generated with the tool "WebIDLParser"
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
using System.ComponentModel;

namespace SharpKit.DotNet.Html
{

    using SharpKit.JavaScript;
    using SharpKit.DotNet.JavaScript;
    using SharpKit.DotNet.Html.fileapi;
    using SharpKit.DotNet.Html.html.shadow;
    using SharpKit.DotNet.Html.html.track;
    using SharpKit.DotNet.Html.inspector;
    using SharpKit.DotNet.Html.loader.appcache;
    using SharpKit.DotNet.Html.battery;
    using SharpKit.DotNet.Html.gamepad;
    using SharpKit.DotNet.Html.geolocation;
    using SharpKit.DotNet.Html.indexeddb;
    using SharpKit.DotNet.Html.intents;
    using SharpKit.DotNet.Html.mediasource;
    using SharpKit.DotNet.Html.mediastream;
    using SharpKit.DotNet.Html.networkinfo;
    using SharpKit.DotNet.Html.notifications;
    using SharpKit.DotNet.Html.proximity;
    using SharpKit.DotNet.Html.quota;
    using SharpKit.DotNet.Html.speech;
    using SharpKit.DotNet.Html.webaudio;
    using SharpKit.DotNet.Html.webdatabase;
    using SharpKit.DotNet.Html.plugins;
    using SharpKit.DotNet.Html.storage;
    using SharpKit.DotNet.Html.svg;
    using SharpKit.DotNet.Html.workers;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "CanvasRenderingContext2D")]
    public partial class CanvasRenderingContext2D : CanvasRenderingContext
    {
        /// <summary>
        /// The globalAlpha attribute gives an alpha value that is applied to shapes and images before they are composited onto the canvas. The value must be in the range from 0.0 (fully transparent) to 1.0 (no additional transparency). If an attempt is made to set the attribute to a value outside this range, including Infinity and Not-a-Number (NaN) values, the attribute must retain its previous value. When the context is created, the globalAlpha attribute must initially have the value 1.0.
        /// </summary>
        public double globalAlpha { get; set; }
        /// <summary>
        /// The globalCompositeOperation affects how canvas drawing routines interact with the data that's being drawn upon.
        /// <para>The globalCompositeOperation attribute sets how shapes and images are drawn onto the existing bitmap, once they have had globalAlpha and the current transformation matrix applied. It must be set to a value from the following list. In the descriptions below, the source image, A, is the shape or image being rendered, and the destination image, B, is the current state of the bitmap.HTML5 canvas provides compositing attribute globalCompositeOperation which affect all the drawing operations.</para>
        /// </summary>
        public JsString globalCompositeOperation { get; set; }
        public double lineWidth { get; set; }
        public JsString lineCap { get; set; }
        public JsString lineJoin { get; set; }
        public double miterLimit { get; set; }
        public double shadowOffsetX { get; set; }
        public double shadowOffsetY { get; set; }
        public double shadowBlur { get; set; }
        public JsString shadowColor { get; set; }
        public JsString font { get; set; }
        public JsString textAlign { get; set; }
        public JsString textBaseline { get; set; }
        /// <summary>
        /// This property represents the color or style to use for stroking shapes.
        /// <para>Set this to change the stroke style. The style can be either a JsString containing a CSS color, or a CanvasGradient or CanvasPattern object. Invalid values are ignored.</para>
        /// </summary>
        public object strokeStyle { get; set; }
        /// <summary>
        /// This property represents the color or style to use for filling shapes.
        /// <para>Set this to change the stroke style. The style can be either a JsString containing a CSS color, or a CanvasGradient or CanvasPattern object. Invalid values are ignored.</para>
        /// </summary>
        public object fillStyle { get; set; }
        /// <summary>
        /// Pushes the current state onto the stack.
        /// <para>Each context maintains a stack of drawing states. Drawing states consist of the current transformation matrix, the current clipping region, and the current values of a variety of the canvas attributes including <see cref="strokeStyle"/>, <see cref="fillStyle"/>, <see cref="globalAlpha"/>, lineWidth, font, textAlign, and textBaseline.</para>
        /// </summary>
        [JsMethod(Name = "save")]
        public void Save() { }
        /// <summary>
        /// Restores the top state on the stack, restoring the canvas context to that state.
        /// <para>This method will pop the top entry in the drawing state stack, and reset the drawing state it describes. If there is no saved state, the method does nothing.</para>
        /// </summary>
        [JsMethod(Name = "restore")]
        public void Restore() { }
        /// <summary>
        /// Changes the size of an object.
        /// <para>Changes the transformation matrix to apply a scaling transformation with the given characteristics.</para>
        /// </summary>
        /// <param name="sx">The scale factor of the object's width</param>
        /// <param name="sy">The scale factor of the object's height</param>
        [JsMethod(Name = "scale")]
        public void Scale(double sx, double sy) { }
        /// <summary>
        /// Rotates an object.
        /// <para>Changes the transformation matrix to apply a rotation transformation with the given characteristics to the entire canvas. The angle is in radians.</para>
        /// </summary>
        /// <param name="angle">The angle to rotate an object in radians with positive numbers heading clockwise and negative numbers headed counter clockwise</param>
        [JsMethod(Name = "rotate")]
        public void Rotate(double angle) { }

        /// <summary>
        /// Moves everything drawn on the canvas by a certain.
        /// <para>Changes the transformation matrix to apply a translation transformation with the given characteristics.</para>
        /// </summary>
        /// <param name="tx">The amount to move what is drawn in the x-axis</param>
        /// <param name="ty">The amount to move what is drawn in the y-axis</param>
        [JsMethod(Name = "translate")]
        public void Translate(double tx, double ty) { }
        /// <summary>
        /// This method replaces the current transformation matrix with the result of multiplying the current transformation matrix.
        /// </summary>
        /// <remarks>
        /// The <see cref="Transform">Transform(a, b, c, d, e, f)</see> method must replace the current transformation matrix with the result of multiplying the current transformation matrix with the matrix described by:
        /// <para>a c e</para>
        /// <para>b d f</para>
        /// <para>0 0 1</para>
        /// <para>The arguments a, b, c, d, e, and f are sometimes called m11, m12, m21, m22, dx, and dy or m11, m21, m12, m22, dx, and dy. Care should be taken in particular with the order of the second and third arguments (b and c) as their order varies from API to API and APIs sometimes use the notation m12/m21 and sometimes m21/m12 for those positions.</para>
        /// </remarks>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [JsMethod(Name = "transform")]
        public void Transform(double m11, double m12, double m21, double m22, double dx, double dy) { }

        /// <summary>
        /// This method resets the current transform to the identity matrix and then invokes the transform method with the same arguments.
        /// </summary>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m21"></param>
        /// <param name="m22"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [JsMethod(Name = "setTransform")]
        public void SetTransform(double m11, double m12, double m21, double m22, double dx, double dy) { }
        [JsMethod(Name = "createLinearGradient")]
        public CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1) { return default(CanvasGradient); }
        [JsMethod(Name = "createRadialGradient")]
        public CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1) { return default(CanvasGradient); }
        [JsMethod(Name = "setLineDash")]
        public void SetLineDash(double dash) { }
        [JsMethod(Name = "getLineDash")]
        public double GetLineDash() { return default(double); }
        public double lineDashOffset { get; set; }
        /// <summary>
        /// Clears all pixels on the canvas in the given rectangle to transparent black.
        /// <para>If either height or width are zero, this method has no effect. Use the FillRect with fillStyle property to set the background color.</para>
        /// </summary>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "clearRect")]
        public void ClearRect(double x, double y, double width, double height) { }
        /// <summary>
        /// Paints the given rectangle onto the canvas using the current fill style.
        /// <para>This method paints the specified rectangular area using the fillStyle. If either height or width are zero, this method has no effect.</para>
        /// </summary>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "fillRect")]
        public void FillRect(double x, double y, double width, double height) { }
        /// <summary>
        /// Starts a new path.
        /// <para>This method will reset the current default path. It is used to start drawing a new path.</para>
        /// </summary>
        [JsMethod(Name = "beginPath")]
        public void BeginPath() { }
        /// <summary>
        /// Starts a new path at the exact same point as where the previous path ended.
        /// <para>Marks the current subpath as closed, and starts a new subpath with a point the same as the start and end of the newly closed subpath.</para>
        /// </summary>
        [JsMethod(Name = "closePath")]
        public void ClosePath() { }
        /// <summary>
        /// Creates a new subpath with the given point.
        /// <para>Use this command to draw a line from an entirely new point on the canvas. Any LineTo command following a MoveTo command will use the point identified in the MoveTo as the starting point.</para>
        /// </summary>
        /// <param name="x">The x-coordinate of the point to start the path.</param>
        /// <param name="y">The y-coordinate of the point to start the path.</param>
        [JsMethod(Name = "moveTo")]
        public void MoveTo(double x, double y) { }
        /// <summary>
        /// Adds the given point to the current subpath, connected to the previous one by a straight line.
        /// <para>Use this command to draw a line from the previous point on the canvas (defined by either MoveTo or LineTo) to the specified point.</para>
        /// </summary>
        /// <param name="x">The x-coordinate of the point to add to the path.</param>
        /// <param name="y">The y-coordinate of the point to add to the path.</param>
        [JsMethod(Name = "lineTo")]
        public void LineTo(double x, double y) { }

        /// <summary>
        /// This command draws a curve using a single control point.
        /// <para>Adds the given point to the current subpath, connected to the previous one by a quadratic Bézier curve with the given control point. The QuadraticCurveTo method creates a line from the path's current point to the specified point, via a controlpoint.</para>
        /// </summary>
        /// <param name="cpx">Control point x coordinate</param>
        /// <param name="cpy">Control point y coordinate</param>
        /// <param name="x">end point x coordinate</param>
        /// <param name="y">end point y coordinate</param>
        [JsMethod(Name = "quadraticCurveTo")]
        public void QuadraticCurveTo(double cpx, double cpy, double x, double y) { }

        /// <summary>
        /// This command draws a curve with two control points.
        /// <para>Adds the given point to the current subpath, connected to the previous one by a cubic Bézier curve with the given control points. Draw a path from one point to another and stretch the path from two controll points.</para>
        /// </summary>
        /// <param name="cp1x">Control point 1 x coordinate</param>
        /// <param name="cp1y">Control point 1 y coordinate</param>
        /// <param name="cp2x">Control point 2 x coordinate</param>
        /// <param name="cp2y">Control point 2 y coordinate</param>
        /// <param name="x">end point x coordinate</param>
        /// <param name="y">end point y coordinate</param>
        [JsMethod(Name = "bezierCurveTo")]
        public void BezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y) { }
        /// <summary>
        /// Draws a turn in an otherwise straight line of a particular radius.
        /// <para>This command adds an arc with the given control points and radius to the current subpath, connected to the previous point by a straight line.</para>
        /// </summary>
        /// <param name="x1">The x-coordinate of the first point of the arc</param>
        /// <param name="y1">The y-coordinate of the first point of the arc</param>
        /// <param name="x2">The x-coordinate of the second point of the arc</param>
        /// <param name="y2">The y-coordinate of the second point of the arc</param>
        /// <param name="radius">The radius of the circular arc</param>
        [JsMethod(Name = "arcTo")]
        public void ArcTo(double x1, double y1, double x2, double y2, double radius) { }
        /// <summary>
        /// Draws a path in a rectangle.
        /// <para>Adds a new closed subpath to the path, representing the given rectangle.</para>
        /// </summary>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "rect")]
        public void Rect(double x, double y, double width, double height) { }

        /// <summary>
        /// Draws an arc path around a single point.
        /// <para>This command can be used to draw part of or an entire circle based on a point and its radius. The direction may also be specified (defaulting to clockwise), is added to the path, connected to the previous point by a straight line.</para>
        /// </summary>
        /// <param name="x">The x-coordinate of the starting point of the arc</param>
        /// <param name="y">The y-coordinate of the starting point of the arc</param>
        /// <param name="radius">the radius from the chosen point to draw the arc</param>
        /// <param name="startAngle">the angle to start the arc at</param>
        /// <param name="endAngle">The angle to end the arc at</param>
        /// <param name="anticlockwise">An optional parameter to have the arc draw counter-clockwise rather than clockwise (the default)</param>
        [JsMethod(Name = "arc")]
        public void Arc(double x, double y, double radius, double startAngle, double endAngle, bool anticlockwise) { }
        /// <summary>
        /// Fills the subpaths of the current default path or the given path with the current fill style.
        /// <para>Fills all the subpaths of the intended path, using fillStyle.</para>
        /// </summary>
        [JsMethod(Name = "fill")]
        public void Fill() { }
        /// <summary>
        /// Fills the subpaths of the current default path or the given path with the current fill style.
        /// <para>Fills all the subpaths of the intended path, using fillStyle.</para>
        /// </summary>
        /// <param name="path"></param>
        [JsMethod(Name = "fill")]
        public void Fill(object path) { }
        /// <summary>
        /// Strokes the subpaths of the current default path or the given path with the current stroke style.
        /// <para>This method draws the path,and then fills the combined stroke area using the strokeStyle attribute.</para>
        /// </summary>
        [JsMethod(Name = "stroke")]
        public void Stroke() { }
        /// <summary>
        /// Strokes the subpaths of the current default path or the given path with the current stroke style.
        /// <para>This method draws the path,and then fills the combined stroke area using the strokeStyle attribute.</para>
        /// </summary>
        /// <param name="path"></param>
        [JsMethod(Name = "stroke")]
        public void Stroke(object path) { }
        [JsMethod(Name = "clip")]
        public void Clip() { }

        /// <summary>
        /// Returns true if the given point is in the current default path.
        /// <para>This method returns true if the point given by the x and y coordinates passed to the method, when treated as coordinates in the canvas coordinate space unaffected by the current transformation, is inside the intended path as determined by the non-zero winding number rule; and must return false otherwise. Points on the path itself must be considered to be inside the path. If either of the arguments is infinite or NaN, then the method must return false.</para>
        /// </summary>
        /// <param name="x">The x-coordinate of the point to test</param>
        /// <param name="y">The y-coordinate of the point to test</param>
        /// <returns></returns>
        [JsMethod(Name = "isPointInPath")]
        public bool IsPointInPath(double x, double y) { return default(bool); }

        /// <summary>
        /// This method is used to gather metrics about a particular block of text.
        /// </summary>
        /// <param name="text">Text to be measured</param>
        /// <returns></returns>
        [JsMethod(Name = "measureText")]
        public TextMetrics MeasureText(JsString text) { return default(TextMetrics); }

        [JsMethod(Name = "setAlpha")]
        public void SetAlpha(double alpha) { }
        [JsMethod(Name = "setCompositeOperation")]
        public void SetCompositeOperation(JsString compositeOperation) { }
        [JsMethod(Name = "setLineWidth")]
        public void SetLineWidth(double width) { }
        [JsMethod(Name = "setLineCap")]
        public void SetLineCap(JsString cap) { }
        [JsMethod(Name = "setLineJoin")]
        public void SetLineJoin(JsString join) { }
        [JsMethod(Name = "setMiterLimit")]
        public void SetMiterLimit(double limit) { }
        [JsMethod(Name = "clearShadow")]
        public void ClearShadow() { }
        [JsMethod(Name = "fillText")]
        public void FillText(JsString text, double x, double y) { }
        [JsMethod(Name = "fillText")]
        public void FillText(JsString text, double x, double y, double maxWidth) { }

        /// <summary>
        /// Draws text with the canvas with the current strokeStyle.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [JsMethod(Name = "strokeText")]
        public void StrokeText(JsString text, double x, double y) { }
        /// <summary>
        /// Draws text with the canvas with the current strokeStyle.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="maxWidth"></param>
        [JsMethod(Name = "strokeText")]
        public void StrokeText(JsString text, double x, double y, double maxWidth) { }

        [JsMethod(Name = "setStrokeColor")]
        public void SetStrokeColor(JsString color) { }
        [JsMethod(Name = "setStrokeColor")]
        public void SetStrokeColor(JsString color, double alpha) { }
        [JsMethod(Name = "setStrokeColor")]
        public void SetStrokeColor(double grayLevel) { }
        [JsMethod(Name = "setStrokeColor")]
        public void SetStrokeColor(double grayLevel, double alpha) { }
        [JsMethod(Name = "setStrokeColor")]
        public void SetStrokeColor(double r, double g, double b, double a) { }
        [JsMethod(Name = "setStrokeColor")]
        public void SetStrokeColor(double c, double m, double y, double k, double a) { }
        [JsMethod(Name = "setFillColor")]
        public void SetFillColor(JsString color) { }
        [JsMethod(Name = "setFillColor")]
        public void SetFillColor(JsString color, double alpha) { }
        [JsMethod(Name = "setFillColor")]
        public void SetFillColor(double grayLevel) { }
        [JsMethod(Name = "setFillColor")]
        public void SetFillColor(double grayLevel, double alpha) { }
        [JsMethod(Name = "setFillColor")]
        public void SetFillColor(double r, double g, double b, double a) { }
        [JsMethod(Name = "setFillColor")]
        public void SetFillColor(double c, double m, double y, double k, double a) { }

        /// <summary>
        /// Paints the box that outlines the given rectangle onto the canvas using the current stroke style.
        /// <para>This method traces the outline of the rectangle using available line styles, and then fills it with the strokeStyle.</para>
        /// </summary>
        /// <param name="x">The x-coordinate to position the rectangle.</param>
        /// <param name="y">The y-coordinate to position the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        [JsMethod(Name = "strokeRect")]
        public void StrokeRect(double x, double y, double width, double height) { }

        [JsMethod(Name = "strokeRect")]
        public void StrokeRect(double x, double y, double width, double height, double lineWidth) { }

        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="image">Image to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlImageElement image, double dx, double dy) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="image">Image to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        /// <param name="dw">The width to size the image to on the canvas</param>
        /// <param name="dh">The height to size the image to on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlImageElement image, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="image">Image to draw</param>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites.</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        /// <param name="dw">The width to size the image to on the canvas</param>
        /// <param name="dh">The height to size the image to on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="video">Video to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlVideoElement video, double dx, double dy) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="video">Video to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        /// <param name="dw">The width to size the image to on the canvas</param>
        /// <param name="dh">The height to size the image to on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlVideoElement video, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="video">Video to draw</param>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites.</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        /// <param name="dw">The width to size the image to on the canvas</param>
        /// <param name="dh">The height to size the image to on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlVideoElement video, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="canvas">Canvas to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlCanvasElement canvas, double dx, double dy) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="canvas">Canvas to draw</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        /// <param name="dw">The width to size the image to on the canvas</param>
        /// <param name="dh">The height to size the image to on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlCanvasElement canvas, double dx, double dy, double dw, double dh) { }
        /// <summary>
        /// Draws a given image onto the canvas.
        /// </summary>
        /// <param name="canvas">Canvas to draw</param>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites.</param>
        /// <param name="dx">The x-coordinate to position the image at on the canvas</param>
        /// <param name="dy">The y-coordinate to position the image at on the canvas</param>
        /// <param name="dw">The width to size the image to on the canvas</param>
        /// <param name="dh">The height to size the image to on the canvas</param>
        [JsMethod(Name = "drawImage")]
        public void DrawImage(HtmlCanvasElement canvas, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }

        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh) { }
        [JsMethod(Name = "drawImageFromRect")]
        public void DrawImageFromRect(HtmlImageElement image, double sx, double sy, double sw, double sh, double dx, double dy, double dw, double dh, JsString compositeOperation) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur, JsString color) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur, JsString color, double alpha) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur, double grayLevel) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur, double grayLevel, double alpha) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur, double r, double g, double b, double a) { }
        [JsMethod(Name = "setShadow")]
        public void SetShadow(double width, double height, double blur, double c, double m, double y, double k, double a) { }
        /// <summary>
        /// Paints the data from the given ImageData object onto the canvas.
        /// </summary>
        /// <param name="imagedata"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [JsMethod(Name = "putImageData")]
        public void PutImageData(ImageData imagedata, double dx, double dy) { }
        /// <summary>
        /// Paints the data from the given ImageData object onto the canvas.
        /// </summary>
        /// <param name="imagedata"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dirtyX"></param>
        /// <param name="dirtyY"></param>
        /// <param name="dirtyWidth"></param>
        /// <param name="dirtyHeight"></param>
        [JsMethod(Name = "putImageData")]
        public void PutImageData(ImageData imagedata, double dx, double dy, double dirtyX, double dirtyY, double dirtyWidth, double dirtyHeight) { }

        [JsMethod(Name = "createPattern")]
        public CanvasPattern CreatePattern(HtmlCanvasElement canvas, JsString repetitionType) { return default(CanvasPattern); }
        [JsMethod(Name = "createPattern")]
        public CanvasPattern CreatePattern(HtmlImageElement image, JsString repetitionType) { return default(CanvasPattern); }
        [JsMethod(Name = "createImageData")]
        public ImageData CreateImageData(ImageData imagedata) { return default(ImageData); }
        [JsMethod(Name = "createImageData")]
        public ImageData CreateImageData(double sw, double sh) { return default(ImageData); }
        /// <summary>
        /// Returns an ImageData object containing the image data for the given rectangle of the canvas.
        /// </summary>
        /// <param name="sx">This parameter moves the clipping region on the source image to a certain x-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sy">This parameter moves the clipping region on the source image to a certain y-coordinate. This is helpful in the animation of sprites.</param>
        /// <param name="sw">This parameter clips the source image to a certain width. This is helpful in the animation of sprites.</param>
        /// <param name="sh">This parameter clips the source image to a certain height. This is helpful in the animation of sprites. </param>
        /// <returns>object containing the image data</returns>
        [JsMethod(Name = "getImageData")]
        public ImageData GetImageData(double sx, double sy, double sw, double sh) { return default(ImageData); }
    }

}