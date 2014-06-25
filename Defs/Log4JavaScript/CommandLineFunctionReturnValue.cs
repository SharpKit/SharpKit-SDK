using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace log4javascript
{
    /// <summary>
    /// This is an object with two properties that allow the function to control how the result is displayed
    /// </summary>
    [JsType(JsMode.Json)]
    public class CommandLineFunctionReturnValue
    {
        /// <summary>
        /// A boolean value that determines whether the returned value from this function is appended to the console. The default value is true
        /// </summary>
        public bool appendResult;
        /// <summary>
        /// A boolean value that specifies whether the output of this function should be displayed as an error. The default value is false
        /// </summary>
        public bool isError;
    }
}
