using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.fs
{
    public class WriteStream
    {
        /// <summary>
        /// fd Integer file descriptor used by the WriteStream.
        /// Emitted when the WriteStream's file is opened.
        /// </summary>
        public JsAction<int> open { get; set; }
        //TODO: open is event
        public JsNumber bytesWritten { get; set; }
        //TODO: file.bytesWritten 
    }
}
