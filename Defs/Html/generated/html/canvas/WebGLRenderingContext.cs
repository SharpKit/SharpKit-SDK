
/*******************************************************************************************************

  This file was auto generated with the tool "WebIDLParser"

  Content was generated from IDL file:
  http://trac.webkit.org/browser/trunk/Source/WebCore/html/canvas/WebGLRenderingContext.idl

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

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "WebGLRenderingContext")]
public partial class WebGLRenderingContext : CanvasRenderingContext
{
	public  static int DEPTH_BUFFER_BIT = 0x00000100;
	public  static int STENCIL_BUFFER_BIT = 0x00000400;
	public  static int COLOR_BUFFER_BIT = 0x00004000;
	public  static int POINTS = 0x0000;
	public  static int LINES = 0x0001;
	public  static int LINE_LOOP = 0x0002;
	public  static int LINE_STRIP = 0x0003;
	public  static int TRIANGLES = 0x0004;
	public  static int TRIANGLE_STRIP = 0x0005;
	public  static int TRIANGLE_FAN = 0x0006;
	public  static int ZERO = 0;
	public  static int ONE = 1;
	public  static int SRC_COLOR = 0x0300;
	public  static int ONE_MINUS_SRC_COLOR = 0x0301;
	public  static int SRC_ALPHA = 0x0302;
	public  static int ONE_MINUS_SRC_ALPHA = 0x0303;
	public  static int DST_ALPHA = 0x0304;
	public  static int ONE_MINUS_DST_ALPHA = 0x0305;
	public  static int DST_COLOR = 0x0306;
	public  static int ONE_MINUS_DST_COLOR = 0x0307;
	public  static int SRC_ALPHA_SATURATE = 0x0308;
	public  static int FUNC_ADD = 0x8006;
	public  static int BLEND_EQUATION = 0x8009;
	public  static int BLEND_EQUATION_RGB = 0x8009;
	public  static int BLEND_EQUATION_ALPHA = 0x883D;
	public  static int FUNC_SUBTRACT = 0x800A;
	public  static int FUNC_REVERSE_SUBTRACT = 0x800B;
	public  static int BLEND_DST_RGB = 0x80C8;
	public  static int BLEND_SRC_RGB = 0x80C9;
	public  static int BLEND_DST_ALPHA = 0x80CA;
	public  static int BLEND_SRC_ALPHA = 0x80CB;
	public  static int CONSTANT_COLOR = 0x8001;
	public  static int ONE_MINUS_CONSTANT_COLOR = 0x8002;
	public  static int CONSTANT_ALPHA = 0x8003;
	public  static int ONE_MINUS_CONSTANT_ALPHA = 0x8004;
	public  static int BLEND_COLOR = 0x8005;
	public  static int ARRAY_BUFFER = 0x8892;
	public  static int ELEMENT_ARRAY_BUFFER = 0x8893;
	public  static int ARRAY_BUFFER_BINDING = 0x8894;
	public  static int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
	public  static int STREAM_DRAW = 0x88E0;
	public  static int STATIC_DRAW = 0x88E4;
	public  static int DYNAMIC_DRAW = 0x88E8;
	public  static int BUFFER_SIZE = 0x8764;
	public  static int BUFFER_USAGE = 0x8765;
	public  static int CURRENT_VERTEX_ATTRIB = 0x8626;
	public  static int FRONT = 0x0404;
	public  static int BACK = 0x0405;
	public  static int FRONT_AND_BACK = 0x0408;
	public  static int TEXTURE_2D = 0x0DE1;
	public  static int CULL_FACE = 0x0B44;
	public  static int BLEND = 0x0BE2;
	public  static int DITHER = 0x0BD0;
	public  static int STENCIL_TEST = 0x0B90;
	public  static int DEPTH_TEST = 0x0B71;
	public  static int SCISSOR_TEST = 0x0C11;
	public  static int POLYGON_OFFSET_FILL = 0x8037;
	public  static int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
	public  static int SAMPLE_COVERAGE = 0x80A0;
	public  static int NO_ERROR = 0;
	public  static int INVALID_ENUM = 0x0500;
	public  static int INVALID_VALUE = 0x0501;
	public  static int INVALID_OPERATION = 0x0502;
	public  static int OUT_OF_MEMORY = 0x0505;
	public  static int CW = 0x0900;
	public  static int CCW = 0x0901;
	public  static int LINE_WIDTH = 0x0B21;
	public  static int ALIASED_POINT_SIZE_RANGE = 0x846D;
	public  static int ALIASED_LINE_WIDTH_RANGE = 0x846E;
	public  static int CULL_FACE_MODE = 0x0B45;
	public  static int FRONT_FACE = 0x0B46;
	public  static int DEPTH_RANGE = 0x0B70;
	public  static int DEPTH_WRITEMASK = 0x0B72;
	public  static int DEPTH_CLEAR_VALUE = 0x0B73;
	public  static int DEPTH_FUNC = 0x0B74;
	public  static int STENCIL_CLEAR_VALUE = 0x0B91;
	public  static int STENCIL_FUNC = 0x0B92;
	public  static int STENCIL_FAIL = 0x0B94;
	public  static int STENCIL_PASS_DEPTH_FAIL = 0x0B95;
	public  static int STENCIL_PASS_DEPTH_PASS = 0x0B96;
	public  static int STENCIL_REF = 0x0B97;
	public  static int STENCIL_VALUE_MASK = 0x0B93;
	public  static int STENCIL_WRITEMASK = 0x0B98;
	public  static int STENCIL_BACK_FUNC = 0x8800;
	public  static int STENCIL_BACK_FAIL = 0x8801;
	public  static int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
	public  static int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
	public  static int STENCIL_BACK_REF = 0x8CA3;
	public  static int STENCIL_BACK_VALUE_MASK = 0x8CA4;
	public  static int STENCIL_BACK_WRITEMASK = 0x8CA5;
	public  static int VIEWPORT = 0x0BA2;
	public  static int SCISSOR_BOX = 0x0C10;
	public  static int COLOR_CLEAR_VALUE = 0x0C22;
	public  static int COLOR_WRITEMASK = 0x0C23;
	public  static int UNPACK_ALIGNMENT = 0x0CF5;
	public  static int PACK_ALIGNMENT = 0x0D05;
	public  static int MAX_TEXTURE_SIZE = 0x0D33;
	public  static int MAX_VIEWPORT_DIMS = 0x0D3A;
	public  static int SUBPIXEL_BITS = 0x0D50;
	public  static int RED_BITS = 0x0D52;
	public  static int GREEN_BITS = 0x0D53;
	public  static int BLUE_BITS = 0x0D54;
	public  static int ALPHA_BITS = 0x0D55;
	public  static int DEPTH_BITS = 0x0D56;
	public  static int STENCIL_BITS = 0x0D57;
	public  static int POLYGON_OFFSET_UNITS = 0x2A00;
	public  static int POLYGON_OFFSET_FACTOR = 0x8038;
	public  static int TEXTURE_BINDING_2D = 0x8069;
	public  static int SAMPLE_BUFFERS = 0x80A8;
	public  static int SAMPLES = 0x80A9;
	public  static int SAMPLE_COVERAGE_VALUE = 0x80AA;
	public  static int SAMPLE_COVERAGE_INVERT = 0x80AB;
	public  static int COMPRESSED_TEXTURE_FORMATS = 0x86A3;
	public  static int DONT_CARE = 0x1100;
	public  static int FASTEST = 0x1101;
	public  static int NICEST = 0x1102;
	public  static int GENERATE_MIPMAP_HINT = 0x8192;
	public  static int BYTE = 0x1400;
	public  static int UNSIGNED_BYTE = 0x1401;
	public  static int SHORT = 0x1402;
	public  static int UNSIGNED_SHORT = 0x1403;
	public  static int INT = 0x1404;
	public  static int UNSIGNED_INT = 0x1405;
	public  static int FLOAT = 0x1406;
	public  static int DEPTH_COMPONENT = 0x1902;
	public  static int ALPHA = 0x1906;
	public  static int RGB = 0x1907;
	public  static int RGBA = 0x1908;
	public  static int LUMINANCE = 0x1909;
	public  static int LUMINANCE_ALPHA = 0x190A;
	public  static int UNSIGNED_SHORT_4_4_4_4 = 0x8033;
	public  static int UNSIGNED_SHORT_5_5_5_1 = 0x8034;
	public  static int UNSIGNED_SHORT_5_6_5 = 0x8363;
	public  static int FRAGMENT_SHADER = 0x8B30;
	public  static int VERTEX_SHADER = 0x8B31;
	public  static int MAX_VERTEX_ATTRIBS = 0x8869;
	public  static int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
	public  static int MAX_VARYING_VECTORS = 0x8DFC;
	public  static int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
	public  static int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
	public  static int MAX_TEXTURE_IMAGE_UNITS = 0x8872;
	public  static int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
	public  static int SHADER_TYPE = 0x8B4F;
	public  static int DELETE_STATUS = 0x8B80;
	public  static int LINK_STATUS = 0x8B82;
	public  static int VALIDATE_STATUS = 0x8B83;
	public  static int ATTACHED_SHADERS = 0x8B85;
	public  static int ACTIVE_UNIFORMS = 0x8B86;
	public  static int ACTIVE_ATTRIBUTES = 0x8B89;
	public  static int SHADING_LANGUAGE_VERSION = 0x8B8C;
	public  static int CURRENT_PROGRAM = 0x8B8D;
	public  static int NEVER = 0x0200;
	public  static int LESS = 0x0201;
	public  static int EQUAL = 0x0202;
	public  static int LEQUAL = 0x0203;
	public  static int GREATER = 0x0204;
	public  static int NOTEQUAL = 0x0205;
	public  static int GEQUAL = 0x0206;
	public  static int ALWAYS = 0x0207;
	public  static int KEEP = 0x1E00;
	public  static int REPLACE = 0x1E01;
	public  static int INCR = 0x1E02;
	public  static int DECR = 0x1E03;
	public  static int INVERT = 0x150A;
	public  static int INCR_WRAP = 0x8507;
	public  static int DECR_WRAP = 0x8508;
	public  static int VENDOR = 0x1F00;
	public  static int RENDERER = 0x1F01;
	public  static int VERSION = 0x1F02;
	public  static int NEAREST = 0x2600;
	public  static int LINEAR = 0x2601;
	public  static int NEAREST_MIPMAP_NEAREST = 0x2700;
	public  static int LINEAR_MIPMAP_NEAREST = 0x2701;
	public  static int NEAREST_MIPMAP_LINEAR = 0x2702;
	public  static int LINEAR_MIPMAP_LINEAR = 0x2703;
	public  static int TEXTURE_MAG_FILTER = 0x2800;
	public  static int TEXTURE_MIN_FILTER = 0x2801;
	public  static int TEXTURE_WRAP_S = 0x2802;
	public  static int TEXTURE_WRAP_T = 0x2803;
	public  static int TEXTURE = 0x1702;
	public  static int TEXTURE_CUBE_MAP = 0x8513;
	public  static int TEXTURE_BINDING_CUBE_MAP = 0x8514;
	public  static int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
	public  static int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
	public  static int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
	public  static int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
	public  static int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
	public  static int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
	public  static int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
	public  static int TEXTURE0 = 0x84C0;
	public  static int TEXTURE1 = 0x84C1;
	public  static int TEXTURE2 = 0x84C2;
	public  static int TEXTURE3 = 0x84C3;
	public  static int TEXTURE4 = 0x84C4;
	public  static int TEXTURE5 = 0x84C5;
	public  static int TEXTURE6 = 0x84C6;
	public  static int TEXTURE7 = 0x84C7;
	public  static int TEXTURE8 = 0x84C8;
	public  static int TEXTURE9 = 0x84C9;
	public  static int TEXTURE10 = 0x84CA;
	public  static int TEXTURE11 = 0x84CB;
	public  static int TEXTURE12 = 0x84CC;
	public  static int TEXTURE13 = 0x84CD;
	public  static int TEXTURE14 = 0x84CE;
	public  static int TEXTURE15 = 0x84CF;
	public  static int TEXTURE16 = 0x84D0;
	public  static int TEXTURE17 = 0x84D1;
	public  static int TEXTURE18 = 0x84D2;
	public  static int TEXTURE19 = 0x84D3;
	public  static int TEXTURE20 = 0x84D4;
	public  static int TEXTURE21 = 0x84D5;
	public  static int TEXTURE22 = 0x84D6;
	public  static int TEXTURE23 = 0x84D7;
	public  static int TEXTURE24 = 0x84D8;
	public  static int TEXTURE25 = 0x84D9;
	public  static int TEXTURE26 = 0x84DA;
	public  static int TEXTURE27 = 0x84DB;
	public  static int TEXTURE28 = 0x84DC;
	public  static int TEXTURE29 = 0x84DD;
	public  static int TEXTURE30 = 0x84DE;
	public  static int TEXTURE31 = 0x84DF;
	public  static int ACTIVE_TEXTURE = 0x84E0;
	public  static int REPEAT = 0x2901;
	public  static int CLAMP_TO_EDGE = 0x812F;
	public  static int MIRRORED_REPEAT = 0x8370;
	public  static int FLOAT_VEC2 = 0x8B50;
	public  static int FLOAT_VEC3 = 0x8B51;
	public  static int FLOAT_VEC4 = 0x8B52;
	public  static int INT_VEC2 = 0x8B53;
	public  static int INT_VEC3 = 0x8B54;
	public  static int INT_VEC4 = 0x8B55;
	public  static int BOOL = 0x8B56;
	public  static int BOOL_VEC2 = 0x8B57;
	public  static int BOOL_VEC3 = 0x8B58;
	public  static int BOOL_VEC4 = 0x8B59;
	public  static int FLOAT_MAT2 = 0x8B5A;
	public  static int FLOAT_MAT3 = 0x8B5B;
	public  static int FLOAT_MAT4 = 0x8B5C;
	public  static int SAMPLER_2D = 0x8B5E;
	public  static int SAMPLER_CUBE = 0x8B60;
	public  static int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
	public  static int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
	public  static int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
	public  static int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
	public  static int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
	public  static int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
	public  static int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
	public  static int COMPILE_STATUS = 0x8B81;
	public  static int LOW_FLOAT = 0x8DF0;
	public  static int MEDIUM_FLOAT = 0x8DF1;
	public  static int HIGH_FLOAT = 0x8DF2;
	public  static int LOW_INT = 0x8DF3;
	public  static int MEDIUM_INT = 0x8DF4;
	public  static int HIGH_INT = 0x8DF5;
	public  static int FRAMEBUFFER = 0x8D40;
	public  static int RENDERBUFFER = 0x8D41;
	public  static int RGBA4 = 0x8056;
	public  static int RGB5_A1 = 0x8057;
	public  static int RGB565 = 0x8D62;
	public  static int DEPTH_COMPONENT16 = 0x81A5;
	public  static int STENCIL_INDEX = 0x1901;
	public  static int STENCIL_INDEX8 = 0x8D48;
	public  static int DEPTH_STENCIL = 0x84F9;
	public  static int RENDERBUFFER_WIDTH = 0x8D42;
	public  static int RENDERBUFFER_HEIGHT = 0x8D43;
	public  static int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
	public  static int RENDERBUFFER_RED_SIZE = 0x8D50;
	public  static int RENDERBUFFER_GREEN_SIZE = 0x8D51;
	public  static int RENDERBUFFER_BLUE_SIZE = 0x8D52;
	public  static int RENDERBUFFER_ALPHA_SIZE = 0x8D53;
	public  static int RENDERBUFFER_DEPTH_SIZE = 0x8D54;
	public  static int RENDERBUFFER_STENCIL_SIZE = 0x8D55;
	public  static int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
	public  static int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
	public  static int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
	public  static int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
	public  static int COLOR_ATTACHMENT0 = 0x8CE0;
	public  static int DEPTH_ATTACHMENT = 0x8D00;
	public  static int STENCIL_ATTACHMENT = 0x8D20;
	public  static int DEPTH_STENCIL_ATTACHMENT = 0x821A;
	public  static int NONE = 0;
	public  static int FRAMEBUFFER_COMPLETE = 0x8CD5;
	public  static int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
	public  static int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
	public  static int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
	public  static int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
	public  static int FRAMEBUFFER_BINDING = 0x8CA6;
	public  static int RENDERBUFFER_BINDING = 0x8CA7;
	public  static int MAX_RENDERBUFFER_SIZE = 0x84E8;
	public  static int INVALID_FRAMEBUFFER_OPERATION = 0x0506;
	public  static int UNPACK_FLIP_Y_WEBGL = 0x9240;
	public  static int UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;
	public  static int CONTEXT_LOST_WEBGL = 0x9242;
	public  static int UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;
	public  static int BROWSER_DEFAULT_WEBGL = 0x9244;
	public  int drawingBufferWidth {get; set; }
	public  int drawingBufferHeight {get; set; }
	public  void activeTexture(int texture) {}
	public  void attachShader(WebGLProgram program, WebGLShader shader) {}
	public  void bindAttribLocation(WebGLProgram program, int index, string name) {}
	public  void bindBuffer(int target, WebGLBuffer buffer) {}
	public  void bindFramebuffer(int target, WebGLFramebuffer framebuffer) {}
	public  void bindRenderbuffer(int target, WebGLRenderbuffer renderbuffer) {}
	public  void bindTexture(int target, WebGLTexture texture) {}
	public  void blendColor(double red, double green, double blue, double alpha) {}
	public  void blendEquation(int mode) {}
	public  void blendEquationSeparate(int modeRGB, int modeAlpha) {}
	public  void blendFunc(int sfactor, int dfactor) {}
	public  void blendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha) {}
	public  void bufferData(int target, ArrayBuffer data, int usage) {}
	public  void bufferData(int target, ArrayBufferView data, int usage) {}
	public  void bufferData(int target, int size, int usage) {}
	public  void bufferSubData(int target, int offset, ArrayBuffer data) {}
	public  void bufferSubData(int target, int offset, ArrayBufferView data) {}
	public  int checkFramebufferStatus(int target) { return default(int); }
	public  void clear(int mask) {}
	public  void clearColor(double red, double green, double blue, double alpha) {}
	public  void clearDepth(double depth) {}
	public  void clearStencil(int s) {}
	public  void colorMask(bool red, bool green, bool blue, bool alpha) {}
	public  void compileShader(WebGLShader shader) {}
	public  void compressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, ArrayBufferView data) {}
	public  void compressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, ArrayBufferView data) {}
	public  void copyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border) {}
	public  void copyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {}
	public  WebGLBuffer createBuffer() { return default(WebGLBuffer); }
	public  WebGLFramebuffer createFramebuffer() { return default(WebGLFramebuffer); }
	public  WebGLProgram createProgram() { return default(WebGLProgram); }
	public  WebGLRenderbuffer createRenderbuffer() { return default(WebGLRenderbuffer); }
	public  WebGLShader createShader(int type) { return default(WebGLShader); }
	public  WebGLTexture createTexture() { return default(WebGLTexture); }
	public  void cullFace(int mode) {}
	public  void deleteBuffer(WebGLBuffer buffer) {}
	public  void deleteFramebuffer(WebGLFramebuffer framebuffer) {}
	public  void deleteProgram(WebGLProgram program) {}
	public  void deleteRenderbuffer(WebGLRenderbuffer renderbuffer) {}
	public  void deleteShader(WebGLShader shader) {}
	public  void deleteTexture(WebGLTexture texture) {}
	public  void depthFunc(int func) {}
	public  void depthMask(bool flag) {}
	public  void depthRange(double zNear, double zFar) {}
	public  void detachShader(WebGLProgram program, WebGLShader shader) {}
	public  void disable(int cap) {}
	public  void disableVertexAttribArray(int index) {}
	public  void drawArrays(int mode, int first, int count) {}
	public  void drawElements(int mode, int count, int type, int offset) {}
	public  void enable(int cap) {}
	public  void enableVertexAttribArray(int index) {}
	public  void finish() {}
	public  void flush() {}
	public  void framebufferRenderbuffer(int target, int attachment, int renderbuffertarget, WebGLRenderbuffer renderbuffer) {}
	public  void framebufferTexture2D(int target, int attachment, int textarget, WebGLTexture texture, int level) {}
	public  void frontFace(int mode) {}
	public  void generateMipmap(int target) {}
	public  WebGLActiveInfo getActiveAttrib(WebGLProgram program, int index) { return default(WebGLActiveInfo); }
	public  WebGLActiveInfo getActiveUniform(WebGLProgram program, int index) { return default(WebGLActiveInfo); }
	public  void getAttachedShaders(WebGLProgram program) {}
	public  int getAttribLocation(WebGLProgram program, string name) { return default(int); }
	public  void getBufferParameter() {}
	public  WebGLContextAttributes getContextAttributes() { return default(WebGLContextAttributes); }
	public  int getError() { return default(int); }
	public  object getExtension(string name) { return default(object); }
	public  void getFramebufferAttachmentParameter() {}
	public  void getParameter() {}
	public  void getProgramParameter() {}
	public  JsString getProgramInfoLog(WebGLProgram program) { return default(JsString); }
	public  void getRenderbufferParameter() {}
	public  void getShaderParameter() {}
	public  JsString getShaderInfoLog(WebGLShader shader) { return default(JsString); }
	public  WebGLShaderPrecisionFormat getShaderPrecisionFormat(int shadertype, int precisiontype) { return default(WebGLShaderPrecisionFormat); }
	public  JsString getShaderSource(WebGLShader shader) { return default(JsString); }
	public  JsString getSupportedExtensions() { return default(JsString); }
	public  void getTexParameter() {}
	public  void getUniform() {}
	public  WebGLUniformLocation getUniformLocation(WebGLProgram program, string name) { return default(WebGLUniformLocation); }
	public  void getVertexAttrib() {}
	public  int getVertexAttribOffset(int index, int pname) { return default(int); }
	public  void hint(int target, int mode) {}
	public  bool isBuffer(WebGLBuffer buffer) { return default(bool); }
	public  bool isContextLost() { return default(bool); }
	public  bool isEnabled(int cap) { return default(bool); }
	public  bool isFramebuffer(WebGLFramebuffer framebuffer) { return default(bool); }
	public  bool isProgram(WebGLProgram program) { return default(bool); }
	public  bool isRenderbuffer(WebGLRenderbuffer renderbuffer) { return default(bool); }
	public  bool isShader(WebGLShader shader) { return default(bool); }
	public  bool isTexture(WebGLTexture texture) { return default(bool); }
	public  void lineWidth(double width) {}
	public  void linkProgram(WebGLProgram program) {}
	public  void pixelStorei(int pname, int param) {}
	public  void polygonOffset(double factor, double units) {}
	public  void readPixels(int x, int y, int width, int height, int format, int type, ArrayBufferView pixels) {}
	public  void releaseShaderCompiler() {}
	public  void renderbufferStorage(int target, int internalformat, int width, int height) {}
	public  void sampleCoverage(double value, bool invert) {}
	public  void scissor(int x, int y, int width, int height) {}
	public  void shaderSource(WebGLShader shader, string @string) {}
	public  void stencilFunc(int func, int @ref, int mask) {}
	public  void stencilFuncSeparate(int face, int func, int @ref, int mask) {}
	public  void stencilMask(int mask) {}
	public  void stencilMaskSeparate(int face, int mask) {}
	public  void stencilOp(int fail, int zfail, int zpass) {}
	public  void stencilOpSeparate(int face, int fail, int zfail, int zpass) {}
	public  void texParameterf(int target, int pname, double param) {}
	public  void texParameteri(int target, int pname, int param) {}
	public  void texImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, ArrayBufferView pixels) {}
	public  void texImage2D(int target, int level, int internalformat, int format, int type, ImageData pixels) {}
	public  void texImage2D(int target, int level, int internalformat, int format, int type, HtmlImageElement image) {}
	public  void texImage2D(int target, int level, int internalformat, int format, int type, HtmlCanvasElement canvas) {}
	public  void texSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, ArrayBufferView pixels) {}
	public  void texSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, ImageData pixels) {}
	public  void texSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, HtmlImageElement image) {}
	public  void texSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, HtmlCanvasElement canvas) {}
	public  void uniform1f(WebGLUniformLocation location, double x) {}
	public  void uniform1fv(WebGLUniformLocation location, Float32Array v) {}
	public  void uniform1i(WebGLUniformLocation location, int x) {}
	public  void uniform1iv(WebGLUniformLocation location, Int32Array v) {}
	public  void uniform2f(WebGLUniformLocation location, double x, double y) {}
	public  void uniform2fv(WebGLUniformLocation location, Float32Array v) {}
	public  void uniform2i(WebGLUniformLocation location, int x, int y) {}
	public  void uniform2iv(WebGLUniformLocation location, Int32Array v) {}
	public  void uniform3f(WebGLUniformLocation location, double x, double y, double z) {}
	public  void uniform3fv(WebGLUniformLocation location, Float32Array v) {}
	public  void uniform3i(WebGLUniformLocation location, int x, int y, int z) {}
	public  void uniform3iv(WebGLUniformLocation location, Int32Array v) {}
	public  void uniform4f(WebGLUniformLocation location, double x, double y, double z, double w) {}
	public  void uniform4fv(WebGLUniformLocation location, Float32Array v) {}
	public  void uniform4i(WebGLUniformLocation location, int x, int y, int z, int w) {}
	public  void uniform4iv(WebGLUniformLocation location, Int32Array v) {}
	public  void uniformMatrix2fv(WebGLUniformLocation location, bool transpose, Float32Array array) {}
	public  void uniformMatrix3fv(WebGLUniformLocation location, bool transpose, Float32Array array) {}
	public  void uniformMatrix4fv(WebGLUniformLocation location, bool transpose, Float32Array array) {}
	public  void useProgram(WebGLProgram program) {}
	public  void validateProgram(WebGLProgram program) {}
	public  void vertexAttrib1f(int indx, double x) {}
	public  void vertexAttrib1fv(int indx, Float32Array values) {}
	public  void vertexAttrib2f(int indx, double x, double y) {}
	public  void vertexAttrib2fv(int indx, Float32Array values) {}
	public  void vertexAttrib3f(int indx, double x, double y, double z) {}
	public  void vertexAttrib3fv(int indx, Float32Array values) {}
	public  void vertexAttrib4f(int indx, double x, double y, double z, double w) {}
	public  void vertexAttrib4fv(int indx, Float32Array values) {}
	public  void vertexAttribPointer(int indx, int size, int type, bool normalized, int stride, int offset) {}
	public  void viewport(int x, int y, int width, int height) {}
}

}