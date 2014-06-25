using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    [JsType(JsMode.Prototype, Export = false, Name = "console")]
    public partial class Console
    {
        [JsProperty(Name="")]
        public static Console Current { get; private set; }
        /// <summary>
        /// Prints to stdout with newline. This function can take multiple arguments in a printf()-like way. Example:
        /// <example>
        /// <code>
        /// console.log('count: %d', count);
        /// </code>
        /// </example>
        /// If formatting elements are not found in the first string then util.
        /// inspect is used on each argument. See util.format() for more information.
        /// </summary>
        /// <param name="obj"></param>
        public void log(params object[] obj) { }
        /// <summary>
        /// Prints to stdout with newline. This function can take multiple arguments in a printf()-like way. Example:
        /// <example>
        /// <code>
        /// console.log('count: %d', count);
        /// </code>
        /// </example>
        /// If formatting elements are not found in the first string then util.
        /// inspect is used on each argument. See util.format() for more information.
        /// </summary>
        /// <param name="data"></param>       
        public void log(JsString data) { }
        /// <summary>
        /// Prints to stdout with newline. This function can take multiple arguments in a printf()-like way. Example:
        /// <example>
        /// <code>
        /// console.log('count: %d', count);
        /// </code>
        /// </example>
        /// If formatting elements are not found in the first string then util.
        /// inspect is used on each argument. See util.format() for more information.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="obj"></param>
        public void log(JsString data, params object[] obj) { }
        /// <summary>
        /// Same as console.log.
        /// </summary>
        /// <param name="data"></param>
        public void info(JsString data) { }
        /// <summary>
        /// Same as console.log.
        /// </summary>
        /// <param name="obj"></param>
        public void info(params object[] obj) { }
        /// <summary>
        /// Same as console.log.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="obj"></param>
        public void info(JsString data, params object[] obj) { }
        /// <summary>
        /// Same as console.log but prints to stderr.
        /// </summary>
        /// <param name="data"></param>
        public void error(JsString data) { }
        /// <summary>
        /// Same as console.log but prints to stderr.
        /// </summary>
        /// <param name="obj"></param>
        public void error(params object[] obj) { }
        /// <summary>
        /// Same as console.log but prints to stderr.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="obj"></param>
        public void error(JsString data, params object[] obj) { }
        /// <summary>
        /// Same as console.error.
        /// </summary>
        /// <param name="data"></param>
        public void warn(JsString data) { }
        /// <summary>
        /// Same as console.error.
        /// </summary>
        /// <param name="obj"></param>
        public void warn(params object[] obj) { }
        /// <summary>
        /// Same as console.error.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="obj"></param>
        public void warn(JsString data, params object[] obj) { }
        /// <summary>
        /// Mark a time.
        /// </summary>
        /// <param name="label"></param>
        public void time(JsString label) { }
        /// <summary>
        /// Finish timer, record output.
        /// </summary>
        /// <param name="label"></param>

        /// <example>
        ///  Example:
        /// <code>
        /// console.time('100-elements');
        ///for (var i = 0; i < 100; i++) {
        ///  ;
        ///}
        ///console.timeEnd('100-elements');
        /// </code>
        /// </example>
        public void timeEnd(JsString label) { }
        /// <summary>
        /// Print a stack trace to stderr of the current position.
        /// </summary>
        /// <param name="label"></param>
        public void trace(JsString label) { }
        /// <summary>
        /// Same as assert.ok() where if the expression evaluates as false throw an AssertionError with message.
        /// </summary>
        /// <param name="expression"></param>
        public void assert(bool expression) { }
        /// <summary>
        /// Same as assert.ok() where if the expression evaluates as false throw an AssertionError with message.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="message"></param>
        public void assert(bool expression, JsString message) { }
    }
}
