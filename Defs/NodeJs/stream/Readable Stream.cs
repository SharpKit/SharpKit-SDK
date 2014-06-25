using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>A <code>Readable Stream</code> has the following methods, members, and events.
    /// </p>
    /// </summary>
    public partial class Readable_Stream
    {
        /// <summary>
        /// <p>Closes the underlying file descriptor. Stream is no longer <code>writable</code>
        /// nor <code>readable</code>.  The stream will not emit any more &#39;data&#39;, or &#39;end&#39;
        /// events. Any queued write data will not be sent.  The stream should emit
        /// &#39;close&#39; event once its resources have been disposed of.
        /// </p>
        /// </summary>
        public object destroy() { return null; }
        /// <summary>
        /// <p>Issues an advisory signal to the underlying communication layer,
        /// requesting that no further data be sent until <code>resume()</code> is called.
        /// </p>
        /// <p>Note that, due to the advisory nature, certain streams will not be
        /// paused immediately, and so <code>&#39;data&#39;</code> events may be emitted for some
        /// indeterminate period of time even after <code>pause()</code> is called. You may
        /// wish to buffer such <code>&#39;data&#39;</code> events.
        /// </p>
        /// </summary>
        public object pause() { return null; }
        /// <summary>
        /// <p>This is a <code>Stream.prototype</code> method available on all <code>Stream</code>s.
        /// </p>
        /// <p>Connects this read stream to <code>destination</code> WriteStream. Incoming data on
        /// this stream gets written to <code>destination</code>. The destination and source
        /// streams are kept in sync by pausing and resuming as necessary.
        /// </p>
        /// <p>This function returns the <code>destination</code> stream.
        /// </p>
        /// <p>Emulating the Unix <code>cat</code> command:
        /// </p>
        /// <pre><code>process.stdin.resume(); process.stdin.pipe(process.stdout);</code></pre>
        /// <p>By default <code>end()</code> is called on the destination when the source stream
        /// emits <code>end</code>, so that <code>destination</code> is no longer writable. Pass <code>{ end:
        /// false }</code> as <code>options</code> to keep the destination stream open.
        /// </p>
        /// <p>This keeps <code>process.stdout</code> open so that &quot;Goodbye&quot; can be written at the
        /// end.
        /// </p>
        /// <pre><code>process.stdin.resume();
        /// process.stdin.pipe(process.stdout, { end: false });
        /// process.stdin.on(&quot;end&quot;, function() {
        /// process.stdout.write(&quot;Goodbye\n&quot;); });</code></pre>
        /// </summary>
        public object pipe(JsString destination) { return null; }
        /// <summary>
        /// <p>This is a <code>Stream.prototype</code> method available on all <code>Stream</code>s.
        /// </p>
        /// <p>Connects this read stream to <code>destination</code> WriteStream. Incoming data on
        /// this stream gets written to <code>destination</code>. The destination and source
        /// streams are kept in sync by pausing and resuming as necessary.
        /// </p>
        /// <p>This function returns the <code>destination</code> stream.
        /// </p>
        /// <p>Emulating the Unix <code>cat</code> command:
        /// </p>
        /// <pre><code>process.stdin.resume(); process.stdin.pipe(process.stdout);</code></pre>
        /// <p>By default <code>end()</code> is called on the destination when the source stream
        /// emits <code>end</code>, so that <code>destination</code> is no longer writable. Pass <code>{ end:
        /// false }</code> as <code>options</code> to keep the destination stream open.
        /// </p>
        /// <p>This keeps <code>process.stdout</code> open so that &quot;Goodbye&quot; can be written at the
        /// end.
        /// </p>
        /// <pre><code>process.stdin.resume();
        /// process.stdin.pipe(process.stdout, { end: false });
        /// process.stdin.on(&quot;end&quot;, function() {
        /// process.stdout.write(&quot;Goodbye\n&quot;); });</code></pre>
        /// </summary>
        public object pipe(object destination, PipeOptions options) { return null; }
        /// <summary>
        /// <p>Resumes the incoming <code>&#39;data&#39;</code> events after a <code>pause()</code>.
        /// </p>
        /// </summary>
        public object resume() { return null; }
        /// <summary>
        /// <p>Makes the <code>&#39;data&#39;</code> event emit a string instead of a <code>Buffer</code>. <code>encoding</code>
        /// can be <code>&#39;utf8&#39;</code>, <code>&#39;utf16le&#39;</code> (<code>&#39;ucs2&#39;</code>), <code>&#39;ascii&#39;</code>, or <code>&#39;hex&#39;</code>. Defaults
        /// to <code>&#39;utf8&#39;</code>.
        /// </p>
        /// </summary>
        public object setEncoding() { return null; }
        /// <summary>
        /// <p>Makes the <code>&#39;data&#39;</code> event emit a string instead of a <code>Buffer</code>. <code>encoding</code>
        /// can be <code>&#39;utf8&#39;</code>, <code>&#39;utf16le&#39;</code> (<code>&#39;ucs2&#39;</code>), <code>&#39;ascii&#39;</code>, or <code>&#39;hex&#39;</code>. Defaults
        /// to <code>&#39;utf8&#39;</code>.
        /// </p>
        /// </summary>
        public object setEncoding(object encoding) { return null; }

        #region events
        /// <summary>
        /// The 'data' event emits either a Buffer (by default) or a string if setEncoding() was used.
        /// </summary>
        /// <remarks>
        /// Note that the data will be lost if there is no listener when a Readable Stream emits a 'data' event.
        ///</remarks>
        [JsProperty(Name = "data")]
        public JsAction<Buffer> dataString { get; set; }
        /// <summary>
        /// The 'data' event emits either a Buffer (by default) or a string if setEncoding() was used.
        /// </summary>
        /// <remarks>
        /// Note that the data will be lost if there is no listener when a Readable Stream emits a 'data' event.
        ///</remarks>
        [JsProperty(Name = "data")]
        public JsAction<JsString> dataBuffer { get; set; }
        /// <summary>
        /// The 'data' event emits either a Buffer (by default) or a string if setEncoding() was used.
        /// </summary>
        /// <remarks>
        /// Note that the data will be lost if there is no listener when a Readable Stream emits a 'data' event.
        ///</remarks>
        public JsAction<object> data { get; set; }
        /// <summary>
        /// Emitted when the stream has received an EOF (FIN in TCP terminology). Indicates that no more 'data' events will happen. 
        /// If the stream is also writable, it may be possible to continue writing.
        /// </summary>
        public JsAction end { get; set; }
        /// <summary>
        /// Emitted when the underlying resource (for example, the backing file descriptor) has been closed. Not all streams will emit this.
        /// </summary>
        public JsAction close { get; set; }
        #endregion
    }
    //TODO:
    #region ReadableStreamOptions
    [JsType(JsMode.Json)]
    public partial class ReadableStreamOption
    {
        /// <summary>
        /// A boolean that is true by default, but turns false after an 'error' occurred, the stream came to an 'end', or destroy() was called.
        /// </summary>
        public bool readable { get; set; }
    }
    #endregion

    #region PipeOPtions
    [JsType(JsMode.Json)]
    public partial class PipeOptions
    {
        /// <summary>
        /// A boolean that is true by default, but turns false after an 'error' occurred, the stream came to an 'end', or destroy() was called.
        /// </summary>
        public bool end { get; set; }
    }
    #endregion
}
