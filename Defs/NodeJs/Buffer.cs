using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>The Buffer class is a global type for dealing with binary data directly.
    /// It can be constructed in a variety of ways.
    /// </p>
    /// </summary>
    public partial class Buffer
    {
        public Buffer() { }
        /// <summary>
        /// Allocates a new buffer of size octets.
        /// </summary>
        /// <param name="size">Number</param>
        public Buffer(JsNumber size) { }
        /// <summary>
        /// Allocates a new buffer using an array of octets.
        /// </summary>
        /// <param name="array">Array</param>
        public Buffer(JsArray array) { }
        /// <summary>
        /// Allocates a new buffer containing the given str. encoding defaults to 'utf8'.
        /// </summary>
        /// <param name="str"> String - string to encode.</param>
        public Buffer(JsString str) { }
        /// <summary>
        /// Allocates a new buffer containing the given str. encoding defaults to 'utf8'.
        /// </summary>
        /// <param name="str"> String - string to encode.</param>
        /// <param name="encoding">String - encoding to use</param>
        public Buffer(JsString str, JsString encoding) { }
        /// <summary>
        /// Tests if obj is a Buffer.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>Boolean</returns>
        public static bool isBuffer(object obj) { return false; }
        /// <summary>
        /// Gives the actual byte length of a string. encoding defaults to 'utf8'. This is not the same as String.prototype.length since that returns the number of characters in a string.
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>Number</returns>
        public static JsNumber byteLength(JsString str) { return null; }
        /// <summary>
        /// Gives the actual byte length of a string. encoding defaults to 'utf8'. This is not the same as String.prototype.length since that returns the number of characters in a string.
        /// </summary>
        /// <param name="str"> String</param>
        /// <param name="encoding"> String, Optional, Default: 'utf8'</param>
        /// <returns></returns>
        public static JsNumber byteLength(JsString str, JsString encoding) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list">Array List of Buffer objects to concat</param>
        /// <returns>Returns a buffer which is the result of concatenating all the buffers in the list together.
        /// If the list has no items, or if the totalLength is 0, then it returns a zero-length buffer.
        /// If the list has exactly one item, then the first item of the list is returned.
        /// If the list has more than one item, then a new Buffer is created.
        /// If totalLength is not provided, it is read from the buffers in the list. However, this adds an additional loop to the function, so it is faster to provide the length explicitly.
        /// </returns>
        public static object concat(JsArray list) { return null; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list">List of Buffer objects to concat</param>
        /// <param name="totalLength"> Number Total length of the buffers when concatenated</param>
        /// <returns>Array List of Buffer objects to concat</param>
        /// <returns>Returns a buffer which is the result of concatenating all the buffers in the list together.
        /// If the list has no items, or if the totalLength is 0, then it returns a zero-length buffer.
        /// If the list has exactly one item, then the first item of the list is returned.
        /// If the list has more than one item, then a new Buffer is created.
        /// If totalLength is not provided, it is read from the buffers in the list. However, this adds an additional loop to the function, so it is faster to provide the length explicitly.
        /// </returns>
        public static object concat(JsArray list, JsNumber totalLength) { return null; }
        /// <summary>
        /// <p>Does copy between buffers. The source and target regions can be overlapped.
        /// <code>targetStart</code> and <code>sourceStart</code> default to <code>0</code>.
        /// <code>sourceEnd</code> defaults to <code>buffer.length</code>.
        /// </p>
        /// <p>Example: build two Buffers, then copy <code>buf1</code> from byte 16 through byte 19
        /// into <code>buf2</code>, starting at the 8th byte in <code>buf2</code>.
        /// </p>
        /// <pre><code>buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// buf2[i] = 33; // ASCII !
        /// }
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// // !!!!!!!!qrst!!!!!!!!!!!!!</code></pre>
        /// </summary>
        public object copy(object targetBuffer) { return null; }
        /// <summary>
        /// <p>Does copy between buffers. The source and target regions can be overlapped.
        /// <code>targetStart</code> and <code>sourceStart</code> default to <code>0</code>.
        /// <code>sourceEnd</code> defaults to <code>buffer.length</code>.
        /// </p>
        /// <p>Example: build two Buffers, then copy <code>buf1</code> from byte 16 through byte 19
        /// into <code>buf2</code>, starting at the 8th byte in <code>buf2</code>.
        /// </p>
        /// <pre><code>buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// buf2[i] = 33; // ASCII !
        /// }
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// // !!!!!!!!qrst!!!!!!!!!!!!!</code></pre>
        /// </summary>
        public object copy(object targetBuffer, JsNumber sourceEnd) { return null; }
        /// <summary>
        /// <p>Does copy between buffers. The source and target regions can be overlapped.
        /// <code>targetStart</code> and <code>sourceStart</code> default to <code>0</code>.
        /// <code>sourceEnd</code> defaults to <code>buffer.length</code>.
        /// </p>
        /// <p>Example: build two Buffers, then copy <code>buf1</code> from byte 16 through byte 19
        /// into <code>buf2</code>, starting at the 8th byte in <code>buf2</code>.
        /// </p>
        /// <pre><code>buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// buf2[i] = 33; // ASCII !
        /// }
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// // !!!!!!!!qrst!!!!!!!!!!!!!</code></pre>
        /// </summary>
        public object copy(object targetBuffer, JsNumber sourceStart, JsNumber sourceEnd) { return null; }
        /// <summary>
        /// <p>Does copy between buffers. The source and target regions can be overlapped.
        /// <code>targetStart</code> and <code>sourceStart</code> default to <code>0</code>.
        /// <code>sourceEnd</code> defaults to <code>buffer.length</code>.
        /// </p>
        /// <p>Example: build two Buffers, then copy <code>buf1</code> from byte 16 through byte 19
        /// into <code>buf2</code>, starting at the 8th byte in <code>buf2</code>.
        /// </p>
        /// <pre><code>buf1 = new Buffer(26);
        /// buf2 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// buf2[i] = 33; // ASCII !
        /// }
        /// buf1.copy(buf2, 8, 16, 20);
        /// console.log(buf2.toString('ascii', 0, 25));
        /// // !!!!!!!!qrst!!!!!!!!!!!!!</code></pre>
        /// </summary>
        public object copy(object targetBuffer, JsNumber targetStart, JsNumber sourceStart, JsNumber sourceEnd) { return null; }
        /// <summary>
        /// <p>Fills the buffer with the specified value. If the <code>offset</code> (defaults to <code>0</code>)
        /// and <code>end</code> (defaults to <code>buffer.length</code>) are not given it will fill the entire
        /// buffer.
        /// </p>
        /// <pre><code>var b = new Buffer(50);
        /// b.fill(&quot;h&quot;);</code></pre>
        /// </summary>
        public object fill(object value) { return null; }
        /// <summary>
        /// <p>Fills the buffer with the specified value. If the <code>offset</code> (defaults to <code>0</code>)
        /// and <code>end</code> (defaults to <code>buffer.length</code>) are not given it will fill the entire
        /// buffer.
        /// </p>
        /// <pre><code>var b = new Buffer(50);
        /// b.fill(&quot;h&quot;);</code></pre>
        /// </summary>
        public object fill(object value, JsNumber end) { return null; }
        /// <summary>
        /// <p>Fills the buffer with the specified value. If the <code>offset</code> (defaults to <code>0</code>)
        /// and <code>end</code> (defaults to <code>buffer.length</code>) are not given it will fill the entire
        /// buffer.
        /// </p>
        /// <pre><code>var b = new Buffer(50);
        /// b.fill(&quot;h&quot;);</code></pre>
        /// </summary>
        public object fill(object value, JsNumber offset, JsNumber end) { return null; }
        public JsNumber length() { return null; }
        /// <summary>
        /// <p>Reads a 64 bit double from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf[0] = 0x55;
        /// buf[1] = 0x55;
        /// buf[2] = 0x55;
        /// buf[3] = 0x55;
        /// buf[4] = 0x55;
        /// buf[5] = 0x55;
        /// buf[6] = 0xd5;
        /// buf[7] = 0x3f;
        /// console.log(buf.readDoubleLE(0));
        /// // 0.3333333333333333</code></pre>
        /// </summary>
        public JsNumber readDoubleBE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a 64 bit double from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf[0] = 0x55;
        /// buf[1] = 0x55;
        /// buf[2] = 0x55;
        /// buf[3] = 0x55;
        /// buf[4] = 0x55;
        /// buf[5] = 0x55;
        /// buf[6] = 0xd5;
        /// buf[7] = 0x3f;
        /// console.log(buf.readDoubleLE(0));
        /// // 0.3333333333333333</code></pre>
        /// </summary>
        public JsNumber readDoubleBE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a 64 bit double from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf[0] = 0x55;
        /// buf[1] = 0x55;
        /// buf[2] = 0x55;
        /// buf[3] = 0x55;
        /// buf[4] = 0x55;
        /// buf[5] = 0x55;
        /// buf[6] = 0xd5;
        /// buf[7] = 0x3f;
        /// console.log(buf.readDoubleLE(0));
        /// // 0.3333333333333333</code></pre>
        /// </summary>
        public JsNumber readDoubleLE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a 64 bit double from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf[0] = 0x55;
        /// buf[1] = 0x55;
        /// buf[2] = 0x55;
        /// buf[3] = 0x55;
        /// buf[4] = 0x55;
        /// buf[5] = 0x55;
        /// buf[6] = 0xd5;
        /// buf[7] = 0x3f;
        /// console.log(buf.readDoubleLE(0));
        /// // 0.3333333333333333</code></pre>
        /// </summary>
        public JsNumber readDoubleLE(object offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a 32 bit float from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x00;
        /// buf[1] = 0x00;
        /// buf[2] = 0x80;
        /// buf[3] = 0x3f;
        /// console.log(buf.readFloatLE(0));
        /// // 0x01</code></pre>
        /// </summary>
        public JsNumber readFloatBE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a 32 bit float from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x00;
        /// buf[1] = 0x00;
        /// buf[2] = 0x80;
        /// buf[3] = 0x3f;
        /// console.log(buf.readFloatLE(0));
        /// // 0x01</code></pre>
        /// </summary>
        public JsNumber readFloatBE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a 32 bit float from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x00;
        /// buf[1] = 0x00;
        /// buf[2] = 0x80;
        /// buf[3] = 0x3f;
        /// console.log(buf.readFloatLE(0));
        /// // 0x01</code></pre>
        /// </summary>
        public object readFloatLE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a 32 bit float from the buffer at the specified offset with specified
        /// endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x00;
        /// buf[1] = 0x00;
        /// buf[2] = 0x80;
        /// buf[3] = 0x3f;
        /// console.log(buf.readFloatLE(0));
        /// // 0x01</code></pre>
        /// </summary>
        public JsNumber readFloatLE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a signed 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt16*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt16BE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a signed 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt16*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt16BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a signed 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt16*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt16LE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a signed 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt16*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt16LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a signed 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt32*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt32BE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a signed 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt32*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt32BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a signed 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt32*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt32LE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a signed 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt32*</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt32LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads a signed 8 bit integer from the buffer at the specified offset.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt8</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt8(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads a signed 8 bit integer from the buffer at the specified offset.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.readUInt8</code>, except buffer contents are treated as two&#39;s
        /// complement signed values.
        /// </p>
        /// </summary>
        public JsNumber readInt8(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt16BE(0));
        /// console.log(buf.readUInt16LE(0));
        /// console.log(buf.readUInt16BE(1));
        /// console.log(buf.readUInt16LE(1));
        /// console.log(buf.readUInt16BE(2));
        /// console.log(buf.readUInt16LE(2));
        /// // 0x0304
        /// // 0x0403
        /// // 0x0423
        /// // 0x2304
        /// // 0x2342
        /// // 0x4223</code></pre>
        /// </summary>
        public JsNumber readUInt16BE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt16BE(0));
        /// console.log(buf.readUInt16LE(0));
        /// console.log(buf.readUInt16BE(1));
        /// console.log(buf.readUInt16LE(1));
        /// console.log(buf.readUInt16BE(2));
        /// console.log(buf.readUInt16LE(2));
        /// // 0x0304
        /// // 0x0403
        /// // 0x0423
        /// // 0x2304
        /// // 0x2342
        /// // 0x4223</code></pre>
        /// </summary>
        public JsNumber readUInt16BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt16BE(0));
        /// console.log(buf.readUInt16LE(0));
        /// console.log(buf.readUInt16BE(1));
        /// console.log(buf.readUInt16LE(1));
        /// console.log(buf.readUInt16BE(2));
        /// console.log(buf.readUInt16LE(2));
        /// // 0x0304
        /// // 0x0403
        /// // 0x0423
        /// // 0x2304
        /// // 0x2342
        /// // 0x4223</code></pre>
        /// </summary>
        public JsNumber readUInt16LE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 16 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt16BE(0));
        /// console.log(buf.readUInt16LE(0));
        /// console.log(buf.readUInt16BE(1));
        /// console.log(buf.readUInt16LE(1));
        /// console.log(buf.readUInt16BE(2));
        /// console.log(buf.readUInt16LE(2));
        /// // 0x0304
        /// // 0x0403
        /// // 0x0423
        /// // 0x2304
        /// // 0x2342
        /// // 0x4223</code></pre>
        /// </summary>
        public JsNumber readUInt16LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt32BE(0));
        /// console.log(buf.readUInt32LE(0));
        /// // 0x03042342
        /// // 0x42230403</code></pre>
        /// </summary>
        public JsNumber readUInt32BE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt32BE(0));
        /// console.log(buf.readUInt32LE(0));
        /// // 0x03042342
        /// // 0x42230403</code></pre>
        /// </summary>
        public JsNumber readUInt32BE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt32BE(0));
        /// console.log(buf.readUInt32LE(0));
        /// // 0x03042342
        /// // 0x42230403</code></pre>
        /// </summary>
        public JsNumber readUInt32LE(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 32 bit integer from the buffer at the specified offset with
        /// specified endian format.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// console.log(buf.readUInt32BE(0));
        /// console.log(buf.readUInt32LE(0));
        /// // 0x03042342
        /// // 0x42230403</code></pre>
        /// </summary>
        public JsNumber readUInt32LE(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 8 bit integer from the buffer at the specified offset.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// for (ii = 0; ii &lt; buf.length; ii++) {
        /// console.log(buf.readUInt8(ii));
        /// }
        /// // 0x3
        /// // 0x4
        /// // 0x23
        /// // 0x42</code></pre>
        /// </summary>
        public JsNumber readUInt8(JsNumber offset) { return null; }
        /// <summary>
        /// <p>Reads an unsigned 8 bit integer from the buffer at the specified offset.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>offset</code>. This means that <code>offset</code>
        /// may be beyond the end of the buffer. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf[0] = 0x3;
        /// buf[1] = 0x4;
        /// buf[2] = 0x23;
        /// buf[3] = 0x42;
        /// for (ii = 0; ii &lt; buf.length; ii++) {
        /// console.log(buf.readUInt8(ii));
        /// }
        /// // 0x3
        /// // 0x4
        /// // 0x23
        /// // 0x42</code></pre>
        /// </summary>
        public JsNumber readUInt8(JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Returns a new buffer which references the same memory as the old, but offset
        /// and cropped by the <code>start</code> (defaults to <code>0</code>) and <code>end</code> (defaults to
        /// <code>buffer.length</code>) indexes.
        /// </p>
        /// <p><strong>Modifying the new buffer slice will modify memory in the original buffer!</strong>
        /// </p>
        /// <p>Example: build a Buffer with the ASCII alphabet, take a slice, then modify one
        /// byte from the original Buffer.
        /// </p>
        /// <pre><code>var buf1 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// }
        /// var buf2 = buf1.slice(0, 3);
        /// console.log(buf2.toString(&#39;ascii&#39;, 0, buf2.length));
        /// buf1[0] = 33;
        /// console.log(buf2.toString(&#39;ascii&#39;, 0, buf2.length));
        /// // abc
        /// // !bc</code></pre>
        /// </summary>
        public object slice() { return null; }
        /// <summary>
        /// <p>Returns a new buffer which references the same memory as the old, but offset
        /// and cropped by the <code>start</code> (defaults to <code>0</code>) and <code>end</code> (defaults to
        /// <code>buffer.length</code>) indexes.
        /// </p>
        /// <p><strong>Modifying the new buffer slice will modify memory in the original buffer!</strong>
        /// </p>
        /// <p>Example: build a Buffer with the ASCII alphabet, take a slice, then modify one
        /// byte from the original Buffer.
        /// </p>
        /// <pre><code>var buf1 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// }
        /// var buf2 = buf1.slice(0, 3);
        /// console.log(buf2.toString(&#39;ascii&#39;, 0, buf2.length));
        /// buf1[0] = 33;
        /// console.log(buf2.toString(&#39;ascii&#39;, 0, buf2.length));
        /// // abc
        /// // !bc</code></pre>
        /// </summary>
        public object slice(JsNumber end) { return null; }
        /// <summary>
        /// <p>Returns a new buffer which references the same memory as the old, but offset
        /// and cropped by the <code>start</code> (defaults to <code>0</code>) and <code>end</code> (defaults to
        /// <code>buffer.length</code>) indexes.
        /// </p>
        /// <p><strong>Modifying the new buffer slice will modify memory in the original buffer!</strong>
        /// </p>
        /// <p>Example: build a Buffer with the ASCII alphabet, take a slice, then modify one
        /// byte from the original Buffer.
        /// </p>
        /// <pre><code>var buf1 = new Buffer(26);
        /// for (var i = 0 ; i &lt; 26 ; i++) {
        /// buf1[i] = i + 97; // 97 is ASCII a
        /// }
        /// var buf2 = buf1.slice(0, 3);
        /// console.log(buf2.toString(&#39;ascii&#39;, 0, buf2.length));
        /// buf1[0] = 33;
        /// console.log(buf2.toString(&#39;ascii&#39;, 0, buf2.length));
        /// // abc
        /// // !bc</code></pre>
        /// </summary>
        public object slice(JsNumber start, JsNumber end) { return null; }
        /// <summary>
        /// <p>Decodes and returns a string from buffer data encoded with <code>encoding</code>
        /// (defaults to <code>&#39;utf8&#39;</code>) beginning at <code>start</code> (defaults to <code>0</code>) and ending at
        /// <code>end</code> (defaults to <code>buffer.length</code>).
        /// </p>
        /// <p>See <code>buffer.write()</code> example, above.
        /// </p>
        /// </summary>
        public JsString toString() { return null; }
        /// <summary>
        /// <p>Decodes and returns a string from buffer data encoded with <code>encoding</code>
        /// (defaults to <code>&#39;utf8&#39;</code>) beginning at <code>start</code> (defaults to <code>0</code>) and ending at
        /// <code>end</code> (defaults to <code>buffer.length</code>).
        /// </p>
        /// <p>See <code>buffer.write()</code> example, above.
        /// </p>
        /// </summary>
        public JsString toString(JsNumber end) { return null; }
        /// <summary>
        /// <p>Decodes and returns a string from buffer data encoded with <code>encoding</code>
        /// (defaults to <code>&#39;utf8&#39;</code>) beginning at <code>start</code> (defaults to <code>0</code>) and ending at
        /// <code>end</code> (defaults to <code>buffer.length</code>).
        /// </p>
        /// <p>See <code>buffer.write()</code> example, above.
        /// </p>
        /// </summary>
        public JsString toString(JsNumber start, JsNumber end) { return null; }
        /// <summary>
        /// <p>Decodes and returns a string from buffer data encoded with <code>encoding</code>
        /// (defaults to <code>&#39;utf8&#39;</code>) beginning at <code>start</code> (defaults to <code>0</code>) and ending at
        /// <code>end</code> (defaults to <code>buffer.length</code>).
        /// </p>
        /// <p>See <code>buffer.write()</code> example, above.
        /// </p>
        /// </summary>
        public JsString toString(JsString encoding, JsNumber start, JsNumber end) { return null; }
        /// <summary>
        /// <p>Writes <code>string</code> to the buffer at <code>offset</code> using the given encoding.
        /// <code>offset</code> defaults to <code>0</code>, <code>encoding</code> defaults to <code>&#39;utf8&#39;</code>. <code>length</code> is
        /// the number of bytes to write. Returns number of octets written. If <code>buffer</code> did
        /// not contain enough space to fit the entire string, it will write a partial
        /// amount of the string. <code>length</code> defaults to <code>buffer.length - offset</code>.
        /// The method will not write partial characters.
        /// </p>
        /// <pre><code>buf = new Buffer(256);
        /// len = buf.write(&#39;\u00bd + \u00bc = \u00be&#39;, 0);
        /// console.log(len + &quot; bytes: &quot; + buf.toString(&#39;utf8&#39;, 0, len));</code></pre>
        /// <p>The number of characters written (which may be different than the number of
        /// bytes written) is set in <code>Buffer._charsWritten</code> and will be overwritten the
        /// next time <code>buf.write()</code> is called.
        /// </p>
        /// </summary>
        public JsNumber write(JsString @string) { return null; }
        /// <summary>
        /// <p>Writes <code>string</code> to the buffer at <code>offset</code> using the given encoding.
        /// <code>offset</code> defaults to <code>0</code>, <code>encoding</code> defaults to <code>&#39;utf8&#39;</code>. <code>length</code> is
        /// the number of bytes to write. Returns number of octets written. If <code>buffer</code> did
        /// not contain enough space to fit the entire string, it will write a partial
        /// amount of the string. <code>length</code> defaults to <code>buffer.length - offset</code>.
        /// The method will not write partial characters.
        /// </p>
        /// <pre><code>buf = new Buffer(256);
        /// len = buf.write(&#39;\u00bd + \u00bc = \u00be&#39;, 0);
        /// console.log(len + &quot; bytes: &quot; + buf.toString(&#39;utf8&#39;, 0, len));</code></pre>
        /// <p>The number of characters written (which may be different than the number of
        /// bytes written) is set in <code>Buffer._charsWritten</code> and will be overwritten the
        /// next time <code>buf.write()</code> is called.
        /// </p>
        /// </summary>
        public JsNumber write(JsString @string, JsString encoding) { return null; }
        /// <summary>
        /// <p>Writes <code>string</code> to the buffer at <code>offset</code> using the given encoding.
        /// <code>offset</code> defaults to <code>0</code>, <code>encoding</code> defaults to <code>&#39;utf8&#39;</code>. <code>length</code> is
        /// the number of bytes to write. Returns number of octets written. If <code>buffer</code> did
        /// not contain enough space to fit the entire string, it will write a partial
        /// amount of the string. <code>length</code> defaults to <code>buffer.length - offset</code>.
        /// The method will not write partial characters.
        /// </p>
        /// <pre><code>buf = new Buffer(256);
        /// len = buf.write(&#39;\u00bd + \u00bc = \u00be&#39;, 0);
        /// console.log(len + &quot; bytes: &quot; + buf.toString(&#39;utf8&#39;, 0, len));</code></pre>
        /// <p>The number of characters written (which may be different than the number of
        /// bytes written) is set in <code>Buffer._charsWritten</code> and will be overwritten the
        /// next time <code>buf.write()</code> is called.
        /// </p>
        /// </summary>
        public JsNumber write(JsString @string, JsNumber length, JsString encoding) { return null; }
        /// <summary>
        /// <p>Writes <code>string</code> to the buffer at <code>offset</code> using the given encoding.
        /// <code>offset</code> defaults to <code>0</code>, <code>encoding</code> defaults to <code>&#39;utf8&#39;</code>. <code>length</code> is
        /// the number of bytes to write. Returns number of octets written. If <code>buffer</code> did
        /// not contain enough space to fit the entire string, it will write a partial
        /// amount of the string. <code>length</code> defaults to <code>buffer.length - offset</code>.
        /// The method will not write partial characters.
        /// </p>
        /// <pre><code>buf = new Buffer(256);
        /// len = buf.write(&#39;\u00bd + \u00bc = \u00be&#39;, 0);
        /// console.log(len + &quot; bytes: &quot; + buf.toString(&#39;utf8&#39;, 0, len));</code></pre>
        /// <p>The number of characters written (which may be different than the number of
        /// bytes written) is set in <code>Buffer._charsWritten</code> and will be overwritten the
        /// next time <code>buf.write()</code> is called.
        /// </p>
        /// </summary>
        public JsNumber write(JsString @string, JsNumber offset, JsNumber length, JsString encoding) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 64 bit double.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf.writeDoubleBE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// buf.writeDoubleLE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 43 eb d5 b7 dd f9 5f d7&gt;
        /// // &lt;Buffer d7 5f f9 dd b7 d5 eb 43&gt;</code></pre>
        /// </summary>
        public object writeDoubleBE(Double value, JsNumber offset) { return null; }
        //TODO: Ask Dan-el the type of value

        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 64 bit double.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf.writeDoubleBE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// buf.writeDoubleLE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 43 eb d5 b7 dd f9 5f d7&gt;
        /// // &lt;Buffer d7 5f f9 dd b7 d5 eb 43&gt;</code></pre>
        /// </summary>
        public object writeDoubleBE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 64 bit double.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf.writeDoubleBE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// buf.writeDoubleLE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 43 eb d5 b7 dd f9 5f d7&gt;
        /// // &lt;Buffer d7 5f f9 dd b7 d5 eb 43&gt;</code></pre>
        /// </summary>
        public object writeDoubleLE(Double value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 64 bit double.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(8);
        /// buf.writeDoubleBE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// buf.writeDoubleLE(0xdeadbeefcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 43 eb d5 b7 dd f9 5f d7&gt;
        /// // &lt;Buffer d7 5f f9 dd b7 d5 eb 43&gt;</code></pre>
        /// </summary>
        public object writeDoubleLE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 32 bit float.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeFloatBE(0xcafebabe, 0);
        /// console.log(buf);
        /// buf.writeFloatLE(0xcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 4f 4a fe bb&gt;
        /// // &lt;Buffer bb fe 4a 4f&gt;</code></pre>
        /// </summary>
        public object writeFloatBE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 32 bit float.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeFloatBE(0xcafebabe, 0);
        /// console.log(buf);
        /// buf.writeFloatLE(0xcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 4f 4a fe bb&gt;
        /// // &lt;Buffer bb fe 4a 4f&gt;</code></pre>
        /// </summary>
        public object writeFloatBE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 32 bit float.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeFloatBE(0xcafebabe, 0);
        /// console.log(buf);
        /// buf.writeFloatLE(0xcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 4f 4a fe bb&gt;
        /// // &lt;Buffer bb fe 4a 4f&gt;</code></pre>
        /// </summary>
        public object writeFloatLE(Double value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid 32 bit float.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeFloatBE(0xcafebabe, 0);
        /// console.log(buf);
        /// buf.writeFloatLE(0xcafebabe, 0);
        /// console.log(buf);
        /// // &lt;Buffer 4f 4a fe bb&gt;
        /// // &lt;Buffer bb fe 4a 4f&gt;</code></pre>
        /// </summary>
        public object writeFloatLE(Double value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt16*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt16BE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt16*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt16BE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt16*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt16LE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt16*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt16LE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt32*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt32BE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt32*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt32BE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt32*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt32LE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid signed 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt32*</code>, except value is written out as a two&#39;s
        /// complement signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt32LE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset. Note, <code>value</code> must be a
        /// valid signed 8 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt8</code>, except value is written out as a two&#39;s complement
        /// signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt8(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset. Note, <code>value</code> must be a
        /// valid signed 8 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Works as <code>buffer.writeUInt8</code>, except value is written out as a two&#39;s complement
        /// signed integer into <code>buffer</code>.
        /// </p>
        /// </summary>
        public object writeInt8(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt16BE(0xdead, 0);
        /// buf.writeUInt16BE(0xbeef, 2);
        /// console.log(buf);
        /// buf.writeUInt16LE(0xdead, 0);
        /// buf.writeUInt16LE(0xbeef, 2);
        /// console.log(buf);
        /// // &lt;Buffer de ad be ef&gt;
        /// // &lt;Buffer ad de ef be&gt;</code></pre>
        /// </summary>
        public object writeUInt16BE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt16BE(0xdead, 0);
        /// buf.writeUInt16BE(0xbeef, 2);
        /// console.log(buf);
        /// buf.writeUInt16LE(0xdead, 0);
        /// buf.writeUInt16LE(0xbeef, 2);
        /// console.log(buf);
        /// // &lt;Buffer de ad be ef&gt;
        /// // &lt;Buffer ad de ef be&gt;</code></pre>
        /// </summary>
        public object writeUInt16BE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt16BE(0xdead, 0);
        /// buf.writeUInt16BE(0xbeef, 2);
        /// console.log(buf);
        /// buf.writeUInt16LE(0xdead, 0);
        /// buf.writeUInt16LE(0xbeef, 2);
        /// console.log(buf);
        /// // &lt;Buffer de ad be ef&gt;
        /// // &lt;Buffer ad de ef be&gt;</code></pre>
        /// </summary>
        public object writeUInt16LE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 16 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt16BE(0xdead, 0);
        /// buf.writeUInt16BE(0xbeef, 2);
        /// console.log(buf);
        /// buf.writeUInt16LE(0xdead, 0);
        /// buf.writeUInt16LE(0xbeef, 2);
        /// console.log(buf);
        /// // &lt;Buffer de ad be ef&gt;
        /// // &lt;Buffer ad de ef be&gt;</code></pre>
        /// </summary>
        public object writeUInt16LE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt32BE(0xfeedface, 0);
        /// console.log(buf);
        /// buf.writeUInt32LE(0xfeedface, 0);
        /// console.log(buf);
        /// // &lt;Buffer fe ed fa ce&gt;
        /// // &lt;Buffer ce fa ed fe&gt;</code></pre>
        /// </summary>
        public object writeUInt32BE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt32BE(0xfeedface, 0);
        /// console.log(buf);
        /// buf.writeUInt32LE(0xfeedface, 0);
        /// console.log(buf);
        /// // &lt;Buffer fe ed fa ce&gt;
        /// // &lt;Buffer ce fa ed fe&gt;</code></pre>
        /// </summary>
        public object writeUInt32BE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt32BE(0xfeedface, 0);
        /// console.log(buf);
        /// buf.writeUInt32LE(0xfeedface, 0);
        /// console.log(buf);
        /// // &lt;Buffer fe ed fa ce&gt;
        /// // &lt;Buffer ce fa ed fe&gt;</code></pre>
        /// </summary>
        public object writeUInt32LE(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset with specified endian
        /// format. Note, <code>value</code> must be a valid unsigned 32 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt32BE(0xfeedface, 0);
        /// console.log(buf);
        /// buf.writeUInt32LE(0xfeedface, 0);
        /// console.log(buf);
        /// // &lt;Buffer fe ed fa ce&gt;
        /// // &lt;Buffer ce fa ed fe&gt;</code></pre>
        /// </summary>
        public object writeUInt32LE(JsNumber value, JsNumber offset, bool noAssert) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset. Note, <code>value</code> must be a
        /// valid unsigned 8 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt8(0x3, 0);
        /// buf.writeUInt8(0x4, 1);
        /// buf.writeUInt8(0x23, 2);
        /// buf.writeUInt8(0x42, 3);
        /// console.log(buf);
        /// // &lt;Buffer 03 04 23 42&gt;</code></pre>
        /// </summary>
        public object writeUInt8(JsNumber value, JsNumber offset) { return null; }
        /// <summary>
        /// <p>Writes <code>value</code> to the buffer at the specified offset. Note, <code>value</code> must be a
        /// valid unsigned 8 bit integer.
        /// </p>
        /// <p>Set <code>noAssert</code> to true to skip validation of <code>value</code> and <code>offset</code>. This means
        /// that <code>value</code> may be too large for the specific function and <code>offset</code> may be
        /// beyond the end of the buffer leading to the values being silently dropped. This
        /// should not be used unless you are certain of correctness. Defaults to <code>false</code>.
        /// </p>
        /// <p>Example:
        /// </p>
        /// <pre><code>var buf = new Buffer(4);
        /// buf.writeUInt8(0x3, 0);
        /// buf.writeUInt8(0x4, 1);
        /// buf.writeUInt8(0x23, 2);
        /// buf.writeUInt8(0x42, 3);
        /// console.log(buf);
        /// // &lt;Buffer 03 04 23 42&gt;</code></pre>
        /// </summary>
        public object writeUInt8(JsNumber value, JsNumber offset, bool noAssert) { return null; }
    }
}
