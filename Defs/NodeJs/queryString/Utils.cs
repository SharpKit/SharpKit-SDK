using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs.queryString
{
    /// <summary>
    /// This module provides utilities for dealing with query strings. It provides the following methods:
    /// </summary>
    [JsType(JsMode.Prototype, Export = false, Name = "querystring")]
    public class Utils
    {
        /// <summary>
        /// Serialize an object to a query string. Optionally override the default separator ('&') and assignment ('=') characters. 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// querystring.stringify({ foo: 'bar', baz: ['qux', 'quux'], corge: '' })
        /// // returns
        /// 'foo=bar&baz=qux&baz=quux&corge='
        /// querystring.stringify({foo: 'bar', baz: 'qux'}, ';', ':')
        /// // returns
        /// 'foo:bar;baz:qux'
        /// </code>
        /// </example>
        public JsString stringify(object obj) { return null; }
        /// <summary>
        /// Serialize an object to a query string. Optionally override the default separator ('&') and assignment ('=') characters. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="sep"></param>
        /// <returns></returns>
        public JsString stringify(object obj, JsString sep) { return null; }
        /// <summary>
        /// Serialize an object to a query string. Optionally override the default separator ('&amp;') and assignment ('=') characters. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="sep"></param>
        /// <param name="eq"></param>
        /// <returns></returns>
        public JsString stringify(object obj, JsString sep, JsString eq) { return null; }
        /// <summary>
        /// Deserialize a query string to an object. Optionally override the default separator ('&') and assignment ('=') characters.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// querystring.parse('foo=bar&amp;baz=qux&baz=quux&corge')
        /// // returns
        /// { foo: 'bar', baz: ['qux', 'quux'], corge: '' }
        /// </code>
        /// </example>
        public JsString parse(JsString str) { return null; }
        /// <summary>
        /// Deserialize a query string to an object. Optionally override the default separator ('&') and assignment ('=') characters.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sep"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// querystring.parse('foo=bar&baz=qux&baz=quux&corge')
        /// // returns
        /// { foo: 'bar', baz: ['qux', 'quux'], corge: '' }
        /// </code>
        /// </example>
        public JsString parse(JsString str, JsString sep) { return null; }
        /// <summary>
        /// Deserialize a query string to an object. Optionally override the default separator ('&') and assignment ('=') characters.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="option">
        /// Options object may contain maxKeys property (equal to 1000 by default), it'll be used to limit processed keys. Set it to 0 to remove key count limitation.
        /// </param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// querystring.parse('foo=bar&baz=qux&baz=quux&corge')
        /// // returns
        /// { foo: 'bar', baz: ['qux', 'quux'], corge: '' }
        /// </code>
        /// </example>
        public JsString parse(JsString str, ParseOptions option) { return null; }
        /// <summary>
        /// Deserialize a query string to an object. Optionally override the default separator ('&') and assignment ('=') characters.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sep"></param>
        /// <param name="option">
        /// Options object may contain maxKeys property (equal to 1000 by default), it'll be used to limit processed keys. Set it to 0 to remove key count limitation.
        /// </param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// querystring.parse('foo=bar&baz=qux&baz=quux&corge')
        /// // returns
        /// { foo: 'bar', baz: ['qux', 'quux'], corge: '' }
        /// </code>
        /// </example>
        public JsString parse(JsString str, JsString sep, ParseOptions option) { return null; }
        /// <summary>
        /// Deserialize a query string to an object. Optionally override the default separator ('&') and assignment ('=') characters.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sep"></param>
        /// <param name="eq"></param>
        /// <param name="option">
        /// Options object may contain maxKeys property (equal to 1000 by default), it'll be used to limit processed keys. Set it to 0 to remove key count limitation.
        /// </param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// querystring.parse('foo=bar&baz=qux&baz=quux&corge')
        /// // returns
        /// { foo: 'bar', baz: ['qux', 'quux'], corge: '' }
        /// </code>
        /// </example>
        public JsString parse(JsString str, JsString sep, JsString eq, ParseOptions option) { return null; }
        /// <summary>
        /// The escape function used by querystring.stringify, provided so that it could be overridden if necessary.The escape function used by querystring.stringify, provided so that it could be overridden if necessary.
        /// </summary>
        public JsFunc<JsString, JsString> escape { get; set; }
        /// <summary>
        /// The unescape function used by querystring.parse, provided so that it could be overridden if necessary.
        /// </summary>
        public JsFunc<JsString, JsString> unescape { get; set; }
    }
    public partial class ParseOptions
    {
        /// <summary>
        /// (equal to 1000 by default), it'll be used to limit processed keys. Set it to 0 to remove key count limitation.
        /// </summary>
        public JsNumber maxKey { get; set; }
    }
}
