using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.fs
{
    /// <summary>
    /// <p><code>ReadStream</code> is a <a href="stream.html#stream_readable_stream">Readable Stream</a>.
    /// </p>
    /// </summary>
    public partial class ReadStream
    {
        #region events
        /// <summary>
        /// fd Integer file descriptor used by the WriteStream.
        /// Emitted when the WriteStream's file is opened.
        /// </summary>
        public JsAction<int> open { get; set; }
        #endregion
        
    }
}
