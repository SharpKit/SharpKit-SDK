using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.zlib
{
    [JsType(JsMode.Prototype, Export = false, Name = "zlib")]
    public partial class Utils
    {
        /// <summary>
        /// Returns a new Gzip object with an options.
        /// </summary>
        /// <returns></returns>
        public Gzip createGzip() { return null; }
        /// <summary>
        /// Returns a new Gzip object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Gzip createGzip(ZlibOptions options) { return null; }
        /// <summary>
        /// Returns a new Gunzip object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Gunzip createGunzip() { return null; }
        /// <summary>
        /// Returns a new Gunzip object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Gunzip createGunzip(ZlibOptions options) { return null; }
        /// <summary>
        /// Returns a new Deflate object with an options.
        /// </summary>
        /// <returns></returns>
        public Deflate createDeflate() { return null; }
        /// <summary>
        /// Returns a new Deflate object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Deflate createDeflate(ZlibOptions options) { return null; }
        /// <summary>
        /// Returns a new Inflate object with an options.
        /// </summary>
        /// <returns></returns>
        public Inflate createInflate() { return null; }
        /// <summary>
        /// Returns a new Inflate object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Inflate createInflate(ZlibOptions options) { return null; }
        /// <summary>
        /// Returns a new DeflateRaw object with an options.
        /// </summary>
        /// <returns></returns>
        public DeflateRaw createDeflateRaw() { return null; }
        /// <summary>
        /// Returns a new DeflateRaw object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public DeflateRaw createDeflateRaw(ZlibOptions options) { return null; }
        /// <summary>
        /// Returns a new InflateRaw object with an options.
        /// </summary>
        /// <returns></returns>
        public InflateRaw createInflateRaw() { return null; }
        /// <summary>
        /// Returns a new InflateRaw object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public InflateRaw createInflateRaw(ZlibOptions options) { return null; }
        /// <summary>
        /// Returns a new Unzip object with an options.
        /// </summary>
        /// <returns></returns>
        public Unzip createUnzip() { return null; }
        /// <summary>
        /// Returns a new Unzip object with an options.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public Unzip createUnzip(ZlibOptions options) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Compress a string with Deflate.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object deflate(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Compress a string with Deflate.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object deflate(Buffer buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Compress a string with DeflateRaw.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object deflateRaw(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Compress a string with DeflateRaw.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object deflateRaw(Buffer buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Compress a string with Gzip.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object gzip(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Compress a string with Gzip.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object gzip(Buffer buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with Gunzip.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object gunzip(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with Gunzip.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object gunzip(Buffer buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with Inflate.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object Inflate(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with Inflate.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object Inflate(Buffer buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with InflateRaw.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object InflateRaw(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with InflateRaw.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object InflateRaw(Buffer buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with Unzip.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object Unzip(JsString buf, JsAction<JsError, JsString> result) { return null; }
        /// <summary>
        /// This take a string or buffer as the first argument, and call the supplied callback with callback(error, result). The compression/decompression engine is created using the default settings in all convenience methods. To supply different options, use the zlib classes directly.
        /// Decompress a raw Buffer with Unzip.
        /// </summary>
        /// <param name="buf"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public object Unzip(Buffer buf, JsAction<JsError, JsString> result) { return null; }
    }
    #region ZlibOptions
    /// <summary>
    /// Each class takes an options object. All options are optional. (The convenience methods use the default settings for all options.)
    ///
    /// Note that some options are only relevant when compressing, and are ignored by the decompression classes.
    /// </summary>
    [JsType(JsMode.Json)]
    public partial class ZlibOptions
    {
        /// <summary>
        /// chunkSize (default: 16*1024)
        /// </summary>
        public JsNumber chunkSize { get; set; }
        /// <summary>
        /// windowBits
        /// </summary>
        public JsNumber windowBits { get; set; }
        /// <summary>
        /// level (compression only)
        /// </summary>
        public JsNumber level { get; set; }
        /// <summary>
        /// memLevel (compression only)
        /// </summary>
        public JsNumber memLevel { get; set; }
        /// <summary>
        /// strategy (compression only)
        /// </summary>
        public JsNumber strategy { get; set; }
        /// <summary>
        /// dictionary (deflate/inflate only, empty dictionary by default)
        /// </summary>
        public object dictionary { get; set; }

    }
    #endregion

}
