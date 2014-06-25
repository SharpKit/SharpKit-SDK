 
/*******************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de

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

using SharpKit.JavaScript;
using SharpKit.Html.fileapi;

namespace SharpKit.Html
{
    [JsDelegate(NativeDelegates = true)]
    [JsType(JsMode.Json, OmitCasts = true, Export = false)]
    public delegate void EventListener<T>(T evt);

    public partial class ArrayBuffer
    {
        public ArrayBuffer() { }
        public ArrayBuffer(int byteLength) { }
    }

    public partial class DataView
    {
        public DataView(ArrayBuffer buffer) { }
        public DataView(ArrayBuffer buffer, int byteOffset) { }
        public DataView(ArrayBuffer buffer, int byteOffset, int byteLength) { }

        public sbyte getInt8(int byteOffset) { return default(sbyte); }
        public byte getUint8(int byteOffset) { return default(byte); }

        public void setInt8(int byteOffset, sbyte value) { }
        public void setUint8(int byteOffset, byte value) { }
    }

    public partial class Int8Array
    {
        public Int8Array() { }
        public Int8Array(int length) { }
        public Int8Array(sbyte[] array) { }
        public Int8Array(ArrayBuffer buffer) { }
        public Int8Array(ArrayBuffer buffer, int byteOffset) { }
        public Int8Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public sbyte this[int key] { get { return default(sbyte); } set { } }
    }

    public partial class Uint8ClampedArray
    {
         public Uint8ClampedArray() { }
       public Uint8ClampedArray(int length) : base(length) { }
        public Uint8ClampedArray(ArrayBuffer buffer) : base(buffer) { }
        public Uint8ClampedArray(ArrayBuffer buffer, int byteOffset) : base(buffer, byteOffset) { }
        public Uint8ClampedArray(ArrayBuffer buffer, int byteOffset, int length) : base(buffer, byteOffset, length) { }
    }

    public partial class Uint8Array
    {
          public Uint8Array() { }
      public Uint8Array(int length) { }
        public Uint8Array(byte[] array) { }
        public Uint8Array(ArrayBuffer buffer) { }
        public Uint8Array(ArrayBuffer buffer, int byteOffset) { }
        public Uint8Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public byte this[int key] { get { return default(byte); } set { } }
    }

    public partial class Int16Array
    {
          public Int16Array() { }
      public Int16Array(int length) { }
        public Int16Array(short[] array) { }
        public Int16Array(ArrayBuffer buffer) { }
        public Int16Array(ArrayBuffer buffer, int byteOffset) { }
        public Int16Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public short this[int key] { get { return default(short); } set { } }
    }

    public partial class Uint16Array
    {
           public Uint16Array() { }
     public Uint16Array(int length) { }
        public Uint16Array(ushort[] array) { }
        public Uint16Array(ArrayBuffer buffer) { }
        public Uint16Array(ArrayBuffer buffer, int byteOffset) { }
        public Uint16Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public ushort this[int key] { get { return default(ushort); } set { } }
    }

    public partial class Int32Array
    {
        public Int32Array() { }
public Int32Array(int length) { }
        public Int32Array(int[] array) { }
        public Int32Array(ArrayBuffer buffer) { }
        public Int32Array(ArrayBuffer buffer, int byteOffset) { }
        public Int32Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public int this[int key] { get { return default(int); } set { } }
    }

    public partial class Uint32Array
    {
         public Uint32Array() { }
       public Uint32Array(int length) { }
        public Uint32Array(uint[] array) { }
        public Uint32Array(ArrayBuffer buffer) { }
        public Uint32Array(ArrayBuffer buffer, int byteOffset) { }
        public Uint32Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public uint this[int key] { get { return default(uint); } set { } }
    }

    public partial class Float32Array
    {
         public Float32Array() { }
        public Float32Array(int length) { }
        public Float32Array(float[] array) { }
        public Float32Array(ArrayBuffer buffer) { }
        public Float32Array(ArrayBuffer buffer, int byteOffset) { }
        public Float32Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public float this[int key] { get { return default(float); } set { } }
    }

    public partial class Float64Array
    {
        public Float64Array() { }
        public Float64Array(int length) { }
        public Float64Array(double[] array) { }
        public Float64Array(ArrayBuffer buffer) { }
        public Float64Array(ArrayBuffer buffer, int byteOffset) { }
        public Float64Array(ArrayBuffer buffer, int byteOffset, int length) { }
        [JsProperty(NativeIndexer = true)]
        public double this[int key] { get { return default(double); } set { } }
    }

    //public partial class WebSocket
    //{
    //    public WebSocket(string url) { }
    //    public WebSocket(string url, JsString protocol) { }
    //    public void send(Blob data) { }
    //    public void send(ArrayBuffer data) { }
    //    public void send(ArrayBufferView data) { }
    //}

    public partial class CssStyleDeclaration
    {
        public JsString azimuth { get; set; }
        public JsString background { get; set; }
        public JsString backgroundAttachment { get; set; }
        public JsString backgroundColor { get; set; }
        public JsString backgroundImage { get; set; }
        public JsString backgroundPosition { get; set; }
        public JsString backgroundRepeat { get; set; }
        public JsString backgroundSize { get; set; }
        public JsString border { get; set; }
        public JsString borderCollapse { get; set; }
        public JsString borderColor { get; set; }
        public JsString borderSpacing { get; set; }
        public JsString borderStyle { get; set; }
        public JsString borderTop { get; set; }
        public JsString borderRight { get; set; }
        public JsString borderBottom { get; set; }
        public JsString borderLeft { get; set; }
        public JsString borderTopColor { get; set; }
        public JsString borderRightColor { get; set; }
        public JsString borderBottomColor { get; set; }
        public JsString borderLeftColor { get; set; }
        public JsString borderTopStyle { get; set; }
        public JsString borderRightStyle { get; set; }
        public JsString borderBottomStyle { get; set; }
        public JsString borderLeftStyle { get; set; }
        public JsString borderTopWidth { get; set; }
        public JsString borderRightWidth { get; set; }
        public JsString borderBottomWidth { get; set; }
        public JsString borderLeftWidth { get; set; }
        public JsString borderWidth { get; set; }
        public JsString bottom { get; set; }
        public JsString captionSide { get; set; }
        public JsString clear { get; set; }
        public JsString clip { get; set; }
        public JsString color { get; set; }
        public JsString content { get; set; }
        public JsString counterIncrement { get; set; }
        public JsString counterReset { get; set; }
        public JsString cue { get; set; }
        public JsString cueAfter { get; set; }
        public JsString cueBefore { get; set; }
        public JsString cursor { get; set; }
        public JsString direction { get; set; }
        public JsString display { get; set; }
        public JsString elevation { get; set; }
        public JsString emptyCells { get; set; }
        public JsString cssFloat { get; set; }
        public JsString font { get; set; }
        public JsString fontFamily { get; set; }
        public JsString fontSize { get; set; }
        public JsString fontSizeAdjust { get; set; }
        public JsString fontStretch { get; set; }
        public JsString fontStyle { get; set; }
        public JsString fontVariant { get; set; }
        public JsString fontWeight { get; set; }
        public JsString height { get; set; }
        public JsString left { get; set; }
        public JsString letterSpacing { get; set; }
        public JsString lineHeight { get; set; }
        public JsString listStyle { get; set; }
        public JsString listStyleImage { get; set; }
        public JsString listStylePosition { get; set; }
        public JsString listStyleType { get; set; }
        public JsString margin { get; set; }
        public JsString marginTop { get; set; }
        public JsString marginRight { get; set; }
        public JsString marginBottom { get; set; }
        public JsString marginLeft { get; set; }
        public JsString markerOffset { get; set; }
        public JsString marks { get; set; }
        public JsString maxHeight { get; set; }
        public JsString maxWidth { get; set; }
        public JsString minHeight { get; set; }
        public JsString minWidth { get; set; }
        public JsString opacity { get; set; }
        public JsString orphans { get; set; }
        public JsString outline { get; set; }
        public JsString outlineColor { get; set; }
        public JsString outlineStyle { get; set; }
        public JsString outlineWidth { get; set; }
        public JsString overflow { get; set; }
        public JsString padding { get; set; }
        public JsString paddingTop { get; set; }
        public JsString paddingRight { get; set; }
        public JsString paddingBottom { get; set; }
        public JsString paddingLeft { get; set; }
        public JsString page { get; set; }
        public JsString pageBreakAfter { get; set; }
        public JsString pageBreakBefore { get; set; }
        public JsString pageBreakInside { get; set; }
        public JsString pause { get; set; }
        public JsString pauseAfter { get; set; }
        public JsString pauseBefore { get; set; }
        public JsString pitch { get; set; }
        public JsString pitchRange { get; set; }
        public JsString playDuring { get; set; }
        public JsString position { get; set; }
        public JsString quotes { get; set; }
        public JsString richness { get; set; }
        public JsString right { get; set; }
        public JsString size { get; set; }
        public JsString speak { get; set; }
        public JsString speakHeader { get; set; }
        public JsString speakNumeral { get; set; }
        public JsString speakPunctuation { get; set; }
        public JsString speechRate { get; set; }
        public JsString stress { get; set; }
        public JsString tableLayout { get; set; }
        public JsString textAlign { get; set; }
        public JsString textDecoration { get; set; }
        public JsString textIndent { get; set; }
        public JsString textShadow { get; set; }
        public JsString textTransform { get; set; }
        public JsString top { get; set; }
        public JsString unicodeBidi { get; set; }
        public JsString verticalAlign { get; set; }
        public JsString visibility { get; set; }
        public JsString voiceFamily { get; set; }
        public JsString volume { get; set; }
        public JsString whiteSpace { get; set; }
        public JsString widows { get; set; }
        public JsString width { get; set; }
        public JsString wordSpacing { get; set; }
        public JsString zIndex { get; set; }
    }

    [JsType(JsMode.Prototype, Name = "JSON", Export = false)]
    public class JSON
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty string: "".
        /// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
        /// <returns></returns>
        public static string stringify(object obj, JsFunc<object, object, object> replacer) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty string: "".
        /// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
        /// <returns></returns>
        public static string stringify(object obj, JsFunc<object, object, object> replacer, int space) { return null; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replacer">If replacer is a function, JSON.stringify calls the function, passing in the key and value of each member. The return value is serialized instead of the original value. If the function returns undefined, the member will be excluded from the serialization. The key for the root object is an empty string: "".
        /// If replacer is an array, only members with key values in the array will be serialized. The order of serialization is the same as the order of the keys in the array. The replacer array is ignored when the value argument is also an array.</param>
        /// <returns></returns>
        public static string stringify(object obj, JsFunc<object, object, object> replacer, string space) { return null; }

        public static string stringify(object obj) { return null; }

        public static object parse(JsString json) { return null; }

        public static T parse<T>(JsString json) { return default(T); }
    }

    public partial class WebGLRenderingContext
    {
        public object getUniform(WebGLProgram program, WebGLUniformLocation location) { return null; }
        public object getProgramParameter(WebGLProgram program, int pname) { return null; }
        public object getShaderParameter(WebGLShader shader, int pname) { return null; }
        public object getParameter(int pname) { return null; }
    }

    partial class HtmlSelectElement
    {
        public void remove(long index) { }
        public void remove(HtmlOptionElement option) { }
    }
    //TODO: Name="XMLHttpRequest", Name="Node"
    //
}

