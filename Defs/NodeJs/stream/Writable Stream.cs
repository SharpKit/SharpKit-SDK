using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>A <code>Writable Stream</code> has the following methods, members, and events.
    /// </p>
    /// </summary>
    public partial class Writable_Stream
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
        /// <p>After the write queue is drained, close the file descriptor.
        /// <code>destroySoon()</code> can still destroy straight away, as long as there is no
        /// data left in the queue for writes.
        /// </p>
        /// </summary>
        public object destroySoon() { return null; }
        /// <summary>
        /// <p>Terminates the stream with EOF or FIN.  This call will allow queued
        /// write data to be sent before closing the stream.
        /// </p>
        /// </summary>
        public object end() { return null; }
        /// <summary>
        /// <p>Same as above but with a <code>buffer</code>.
        /// </p>
        /// </summary>
        public object end(Buffer buffer) { return null; }
        /// <summary>
        /// <p>Sends <code>string</code> with the given <code>encoding</code> and terminates the stream with
        /// EOF or FIN. This is useful to reduce the number of packets sent.
        /// </p>
        /// </summary>
        public object end(JsString str, JsString encoding) { return null; }
        /// <summary>
        /// <p>Same as the above except with a raw buffer.
        /// </p>
        /// </summary>
        public bool write(Buffer buffer) { return false; }
        /// <summary>
        /// Writes string with the given encoding to the stream.  The 'drain' event will indicate when the kernel buffer is empty again. The encoding defaults to 'utf8'
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns>
        /// Returns true if the string has been flushed to the kernel buffer. 
        /// Returns false to indicate that the kernel buffer is full, and the data will be sent out in the future.</returns>
        public bool write(JsString buffer) { return false; }
        /// <summary>
        ///  Writes string with the given encoding to the stream.  The 'drain' event will indicate when the kernel buffer is empty again.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="encoding">The encoding defaults to 'utf8'</param>
        /// <returns>Returns true if the string has been flushed to the kernel buffer. 
        /// Returns false to indicate that the kernel buffer is full, and the data will be sent out in the future.
        /// </returns>
        public bool write(JsString str, JsString encoding) { return false; }

        #region events
        /// <summary>
        /// Emitted when the stream's write queue empties and it's safe to write without buffering again. Listen for it when stream.write() returns false.
        /// 
        /// The 'drain' event can happen at any time, regardless of whether or not stream.write() has previously returned false. 
        /// To avoid receiving unwanted 'drain' events, listen using stream.once().
        /// </summary>
        public JsAction drain { get; set; }
        /// <summary>
        /// Emitted on error with the exception exception.
        /// </summary>
        public JsAction<Exception> error { get; set; }
        /// <summary>
        /// Emitted when the underlying file descriptor has been closed.
        /// </summary>
        public JsAction close { get; set; }
        /// <summary>
        /// Emitted when the stream is passed to a readable stream's pipe method.
        /// </summary>
        public JsAction<object> pipe { get; set; }


        #endregion
    }
    #region writableOptions
    public partial class writableOptions
    {
        /// <summary>
        /// A boolean that is true by default, but turns false after an 'error' occurred or end() / destroy() was called.
        /// </summary>
        public bool writable { get; set; }
    }
    #endregion
}
