using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>A class for running scripts.  Returned by vm.createScript.
    /// </p>
    /// </summary>
    public partial class Script
    {
        /// <summary>
        /// <p>Similar to <code>vm.runInNewContext</code> a method of a precompiled <code>Script</code> object.
        /// <code>script.runInNewContext</code> runs the code of <code>script</code> with <code>sandbox</code> as the global object and returns the result.
        /// Running code does not have access to local scope. <code>sandbox</code> is optional.
        /// </p>
        /// <p>Example: compile code that increments a global variable and sets one, then execute this code multiple times.
        /// These globals are contained in the sandbox.
        /// </p>
        /// <pre><code>var util = require(&#39;util&#39;),
        /// vm = require(&#39;vm&#39;),
        /// sandbox = {
        /// animal: &#39;cat&#39;,
        /// count: 2
        /// };
        /// var script = vm.createScript(&#39;count += 1; name = &quot;kitty&quot;&#39;, &#39;myfile.vm&#39;);
        /// for (var i = 0; i &lt; 10 ; i += 1) {
        /// script.runInNewContext(sandbox);
        /// }
        /// console.log(util.inspect(sandbox));
        /// // { animal: &#39;cat&#39;, count: 12, name: &#39;kitty&#39; }</code></pre>
        /// <p>Note that running untrusted code is a tricky business requiring great care.  To prevent accidental
        /// global variable leakage, <code>script.runInNewContext</code> is quite useful, but safely running untrusted code
        /// requires a separate process.
        /// </p>
        /// </summary>
        public object runInNewContext(){return null;}
        /// <summary>
        /// <p>Similar to <code>vm.runInNewContext</code> a method of a precompiled <code>Script</code> object.
        /// <code>script.runInNewContext</code> runs the code of <code>script</code> with <code>sandbox</code> as the global object and returns the result.
        /// Running code does not have access to local scope. <code>sandbox</code> is optional.
        /// </p>
        /// <p>Example: compile code that increments a global variable and sets one, then execute this code multiple times.
        /// These globals are contained in the sandbox.
        /// </p>
        /// <pre><code>var util = require(&#39;util&#39;),
        /// vm = require(&#39;vm&#39;),
        /// sandbox = {
        /// animal: &#39;cat&#39;,
        /// count: 2
        /// };
        /// var script = vm.createScript(&#39;count += 1; name = &quot;kitty&quot;&#39;, &#39;myfile.vm&#39;);
        /// for (var i = 0; i &lt; 10 ; i += 1) {
        /// script.runInNewContext(sandbox);
        /// }
        /// console.log(util.inspect(sandbox));
        /// // { animal: &#39;cat&#39;, count: 12, name: &#39;kitty&#39; }</code></pre>
        /// <p>Note that running untrusted code is a tricky business requiring great care.  To prevent accidental
        /// global variable leakage, <code>script.runInNewContext</code> is quite useful, but safely running untrusted code
        /// requires a separate process.
        /// </p>
        /// </summary>
        public object runInNewContext(object sandbox){return null;}
        /// <summary>
        /// <p>Similar to <code>vm.runInThisContext</code> but a method of a precompiled <code>Script</code> object.
        /// <code>script.runInThisContext</code> runs the code of <code>script</code> and returns the result.
        /// Running code does not have access to local scope, but does have access to the <code>global</code> object
        /// (v8: in actual context).
        /// </p>
        /// <p>Example of using <code>script.runInThisContext</code> to compile code once and run it multiple times:
        /// </p>
        /// <pre><code>var vm = require(&#39;vm&#39;);
        /// globalVar = 0;
        /// var script = vm.createScript(&#39;globalVar += 1&#39;, &#39;myfile.vm&#39;);
        /// for (var i = 0; i &lt; 1000 ; i += 1) {
        /// script.runInThisContext();
        /// }
        /// console.log(globalVar);
        /// // 1000</code></pre>
        /// </summary>
        public object runInThisContext(){return null;}
    }
}
