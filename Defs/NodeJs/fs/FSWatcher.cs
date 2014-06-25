using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs.fs
{
    /// <summary>
    /// <p>Objects returned from <code>fs.watch()</code> are of this type.
    /// </p>
    /// </summary>
    public partial class FSWatcher
    {
        /// <summary>
        /// <p>Stop watching for changes on the given <code>fs.FSWatcher</code>.
        /// </p>
        /// </summary>
        public object close() { return null; }
        #region events
        /// <summary>
        /// event String The type of fs change
        /// filename String The filename that changed (if relevant/available)
        /// Emitted when something changes in a watched directory or file. See more details in fs.watch.
        /// </summary>
        public JsAction<JsString, JsString> change { get; set; }
        /// <summary>
        /// error Error object
        /// Emitted when an error occurs.
        /// </summary>
        public JsAction<JsError> error { get; set; }

        #endregion
    }
}
