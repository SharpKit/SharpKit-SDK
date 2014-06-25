using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.vm
{
    [JsType(JsMode.Prototype, Export = false, Name = "vm")]
    class Utils
    {
        /// <summary>
        /// vm.runInThisContext() compiles code, runs it and returns the result. Running code does not have access to local scope. 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// var localVar = 123,
        ///     usingscript, evaled,
        ///     vm = require('vm');
        ///
        /// usingscript = vm.runInThisContext('localVar = 1;',
        ///   'myfile.vm');
        /// console.log('localVar: ' + localVar + ', usingscript: ' +
        ///   usingscript);
        /// evaled = eval('localVar = 1;');
        /// console.log('localVar: ' + localVar + ', evaled: ' +
        ///   evaled);
        ///
        /// // localVar: 123, usingscript: 1
        /// // localVar: 1, evaled: 1
        /// </code>
        /// </example>
        /// <remarks>
        /// vm.runInThisContext does not have access to the local scope, so localVar is unchanged. eval does have access to the local scope, so localVar is changed.
        /// 
        /// In case of syntax error in code, vm.runInThisContext emits the syntax error to stderr and throws an exception.
        /// </remarks>
        public object runThisContext(JsString code) { return null; }
        /// <summary>
        /// vm.runInThisContext() compiles code, runs it and returns the result. Running code does not have access to local scope. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="fileName">filename is optional, it's used only in stack traces.</param>
        /// <returns></returns>
        public object runThisContext(JsString code, JsString fileName) { return null; }
        /// <summary>
        /// vm.runInNewContext compiles code, then runs it in sandbox and returns the result. Running code does not have access to local scope.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <example>
        /// Example: compile and execute code that increments a global variable and sets a new one. These globals are contained in the sandbox.
        /// <code>
        /// var util = require('util'),
        ///     vm = require('vm'),
        ///     sandbox = {
        ///       animal: 'cat',
        ///       count: 2
        ///     };
        /// vm.runInNewContext('count += 1; name = "kitty"', sandbox, 'myfile.vm');
        /// console.log(util.inspect(sandbox));
        ///
        /// //  { animal: 'cat', count: 3, name: 'kitty' }
        /// Note that running untrusted code is a tricky business requiring great care. To prevent accidental global variable leakage, vm.runInNewContext is quite useful, but safely running untrusted code requires a separate process.
        ///
        /// In case of syntax error in code, vm.runInNewContext emits the syntax error to stderr and throws an exception.
        /// </code>
        /// </example>
        public object runInNewContext(JsString code) { return null; }
        /// <summary>
        /// vm.runInNewContext compiles code, then runs it in sandbox and returns the result. Running code does not have access to local scope.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="sandbox">The object sandbox will be used as the global object for code.</param>
        /// <returns></returns>
        /// <example>
        /// Example: compile and execute code that increments a global variable and sets a new one. These globals are contained in the sandbox.
        /// <code>
        /// var util = require('util'),
        ///     vm = require('vm'),
        ///     sandbox = {
        ///       animal: 'cat',
        ///       count: 2
        ///     };
        /// vm.runInNewContext('count += 1; name = "kitty"', sandbox, 'myfile.vm');
        /// console.log(util.inspect(sandbox));
        ///
        /// //  { animal: 'cat', count: 3, name: 'kitty' }
        /// Note that running untrusted code is a tricky business requiring great care. To prevent accidental global variable leakage, vm.runInNewContext is quite useful, but safely running untrusted code requires a separate process.
        ///
        /// In case of syntax error in code, vm.runInNewContext emits the syntax error to stderr and throws an exception.
        /// </code>
        /// </example>
        public object runInNewContext(JsString code, object sandbox) { return null; }
        /// <summary>
        /// vm.runInNewContext compiles code, then runs it in sandbox and returns the result. Running code does not have access to local scope.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="filename">filename is optional, filename is only used in stack traces.</param>
        /// <returns></returns>
        /// <example>
        /// Example: compile and execute code that increments a global variable and sets a new one. These globals are contained in the sandbox.
        /// <code>
        /// var util = require('util'),
        ///     vm = require('vm'),
        ///     sandbox = {
        ///       animal: 'cat',
        ///       count: 2
        ///     };
        /// vm.runInNewContext('count += 1; name = "kitty"', sandbox, 'myfile.vm');
        /// console.log(util.inspect(sandbox));
        ///
        /// //  { animal: 'cat', count: 3, name: 'kitty' }
        /// Note that running untrusted code is a tricky business requiring great care. To prevent accidental global variable leakage, vm.runInNewContext is quite useful, but safely running untrusted code requires a separate process.
        ///
        /// In case of syntax error in code, vm.runInNewContext emits the syntax error to stderr and throws an exception.
        /// </code>
        /// </example>
        public object runInNewContext(JsString code, JsString filename) { return null; }
        /// <summary>
        /// vm.runInNewContext compiles code, then runs it in sandbox and returns the result. Running code does not have access to local scope.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="sandbox">The object sandbox will be used as the global object for code.</param>
        /// <param name="filename">filename is optional, filename is only used in stack traces.</param>
        /// <returns></returns>
        /// <example>
        /// Example: compile and execute code that increments a global variable and sets a new one. These globals are contained in the sandbox.
        /// <code>
        /// var util = require('util'),
        ///     vm = require('vm'),
        ///     sandbox = {
        ///       animal: 'cat',
        ///       count: 2
        ///     };
        /// vm.runInNewContext('count += 1; name = "kitty"', sandbox, 'myfile.vm');
        /// console.log(util.inspect(sandbox));
        ///
        /// //  { animal: 'cat', count: 3, name: 'kitty' }
        /// Note that running untrusted code is a tricky business requiring great care. To prevent accidental global variable leakage, vm.runInNewContext is quite useful, but safely running untrusted code requires a separate process.
        ///
        /// In case of syntax error in code, vm.runInNewContext emits the syntax error to stderr and throws an exception.
        /// </code>
        /// </example>
        public object runInNewContext(JsString code, object sandbox, JsString filename) { return null; }
        /// <summary>
        /// vm.runInContext compiles code, then runs it in context and returns the result. A (V8) context comprises a global object, 
        /// together with a set of built-in objects and functions. 
        /// Running code does not have access to local scope and the global object held within context will be used as the global object for code. 
        /// 
        ///<example>
        /// Example: compile and execute code in a existing context.
        /// <code>
        /// var util = require('util'),
        ///     vm = require('vm'),
        ///     initSandbox = {
        ///       animal: 'cat',
        ///       count: 2
        ///     },
        ///     context = vm.createContext(initSandbox);
        ///
        /// vm.runInContext('count += 1; name = "CATT"', context, 'myfile.vm');
        /// console.log(util.inspect(context));
        ///
        /// // { animal: 'cat', count: 3, name: 'CATT' }
        ///</code>
        ///</example>
        ///<remarks>
        /// Note that createContext will perform a shallow clone of the supplied sandbox object in order to initialize the global object of the freshly constructed context.
        ///
        /// Note that running untrusted code is a tricky business requiring great care. To prevent accidental global variable leakage, vm.runInContext is quite useful, but safely running untrusted code requires a separate process.
        ///
        /// In case of syntax error in code, vm.runInContext emits the syntax error to stderr and throws an exception.
        /// </remarks>
        /// </summary>
        /// <param name="code"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public object runInContext(JsString code, JsContext context) { return null; }
        /// <summary>
        /// vm.runInContext compiles code, then runs it in context and returns the result. A (V8) context comprises a global object, 
        /// together with a set of built-in objects and functions. 
        /// Running code does not have access to local scope and the global object held within context will be used as the global object for code. 
        /// 
        ///<example>
        /// Example: compile and execute code in a existing context.
        /// <code>
        /// var util = require('util'),
        ///     vm = require('vm'),
        ///     initSandbox = {
        ///       animal: 'cat',
        ///       count: 2
        ///     },
        ///     context = vm.createContext(initSandbox);
        ///
        /// vm.runInContext('count += 1; name = "CATT"', context, 'myfile.vm');
        /// console.log(util.inspect(context));
        ///
        /// // { animal: 'cat', count: 3, name: 'CATT' }
        ///</code>
        ///</example>
        ///<remarks>
        /// Note that createContext will perform a shallow clone of the supplied sandbox object in order to initialize the global object of the freshly constructed context.
        ///
        /// Note that running untrusted code is a tricky business requiring great care. To prevent accidental global variable leakage, vm.runInContext is quite useful, but safely running untrusted code requires a separate process.
        ///
        /// In case of syntax error in code, vm.runInContext emits the syntax error to stderr and throws an exception.
        /// </remarks>
        /// </summary>
        /// <param name="code"></param>
        /// <param name="context"></param>
        /// <param name="filename">filename is optional, it's used only in stack traces.</param>
        /// <returns></returns>
        public object runInContext(JsString code, JsContext context, JsString filename) { return null; }
        /// <summary>
        /// vm.createContext creates a new context which is suitable for use as the 2nd argument of a subsequent call to vm.runInContext. 
        /// A (V8) context comprises a global object together with a set of build-in objects and functions. 
        /// The optional argument initSandbox will be shallow-copied to seed the initial contents of the global object used by the context. 
        /// </summary>
        /// <returns></returns>
        public JsContext createContext() { return null; }
        /// <summary>
        /// vm.createContext creates a new context which is suitable for use as the 2nd argument of a subsequent call to vm.runInContext. 
        /// A (V8) context comprises a global object together with a set of build-in objects and functions. 
        /// <param name="initSandbox">/// The optional argument initSandbox will be shallow-copied to seed the initial contents of the global object used by the context. </param>
        /// <returns></returns>
        public JsContext createContext(object initSandbox) { return null; }
        /// <summary>
        /// createScript compiles code but does not run it. Instead, it returns a vm.Script object representing this compiled code. 
        /// This script can be run later many times using methods below. The returned script is not bound to any global object. 
        /// It is bound before each run, just for that run.
        /// In case of syntax error in code, createScript prints the syntax error to stderr and throws an exception. 
        /// </summary>
        /// <param name="code"></param>
        /// <returns>returns a vm.Script object representing this compiled code. </returns>
        public Script createScript(JsString code) { return null; }
        /// <summary>
        /// createScript compiles code but does not run it. Instead, it returns a vm.Script object representing this compiled code. 
        /// This script can be run later many times using methods below. The returned script is not bound to any global object. 
        /// It is bound before each run, just for that run.
        /// In case of syntax error in code, createScript prints the syntax error to stderr and throws an exception. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="filename">filename is optional, it's only used in stack traces.</param>
        /// <returns>returns a vm.Script object representing this compiled code. </returns>
        public Script createScript(JsString code, JsString filename) { return null; }
    }
}
