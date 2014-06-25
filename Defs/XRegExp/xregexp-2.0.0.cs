using SharpKit.JavaScript;

namespace SharpKit.XRegExp
{
    public class XRegExp
    {
        /// <summary>
        /// Creates an extended regular expression object for matching text with a pattern. Differs from a native regular expression in that additional syntax and flags are supported.
        /// The returned object is in fact a native RegExp and works with all native methods.
        /// </summary>
        /// <param name="pattern">Regex pattern string, or an existing regex object to copy.</param>
        /// <param name="flags">Any combination of flags.
        /// Native flags:
        /// g - global
        /// i - ignore case
        /// m - multiline anchors
        /// y - sticky (Firefox 3+)
        /// Additional XRegExp flags:
        /// n - explicit capture
        /// s - dot matches all (aka singleline)
        /// x - free-spacing and line comments (aka extended)
        /// Flags cannot be provided when constructing one RegExp from another.</param>
        /// <returns>Extended regular expression object.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // With named capture and flag x
        /// XRegExp('(?&lt;year>  [0-9]{4} ) [-\\s]?  # year  \n\
        ///          (?&lt;month> [0-9]{2} ) [-\\s]?  # month \n\
        ///          (?&lt;day>   [0-9]{2} )          # day   ', 'x');
        /// 
        /// // Providing a regex object copies it. Native regexes are recompiled using native (not
        /// // XRegExp) syntax. Copies maintain special properties for named capture, are augmented
        /// // with `XRegExp.prototype` methods, and have fresh `lastIndex` properties (set to zero).
        /// XRegExp(/regex/);
        ///</code>
        ///</example>
        ///<remarks>
        ///Regexes, strings, and backslashes
        ///JavaScript string literals (as opposed to, e.g., user input or text extracted from the DOM) use a backslash as an escape character. The string literal '\\' therefore contains a single backslash, and its length property's value is 1. However, a backslash is also an escape character in regular expression syntax, where the pattern \\ matches a single backslash. When providing string literals to the RegExp or XRegExp constructor functions, four backslashes are therefore needed to match a single backslash—e.g., XRegExp('\\\\'). Only two of those backslashes are actually passed into the constructor function. The other two are used to escape the backslashes in the string before the function ever sees the string.
        ///The same issue is at play with the \\s sequences in the example code just shown. XRegExp is provided with the two characters \s, which it in turn recognizes as the metasequence used to match a whitespace character. \n (used at the end of the first two lines) is another metasequence in JavaScript string literals and inserts actual line feed characters into the string, which terminate the free-spacing mode line comments that start with #. The backslashes at the very end of the first two lines allow the string to continue to the next line, which avoids the need to concatenate multiple strings when extending a string beyond one line of code.
        /// </remarks>
        public XRegExp(JsString pattern, JsString flags) { }
        /// <summary>
        /// Creates an extended regular expression object for matching text with a pattern. Differs from a native regular expression in that additional syntax and flags are supported.
        /// The returned object is in fact a native RegExp and works with all native methods.
        /// </summary>
        /// <param name="pattern">Regex pattern string, or an existing regex object to copy.</param>
        /// <param name="flags">Any combination of flags.
        /// Native flags:
        /// g - global
        /// i - ignore case
        /// m - multiline anchors
        /// y - sticky (Firefox 3+)
        /// Additional XRegExp flags:
        /// n - explicit capture
        /// s - dot matches all (aka singleline)
        /// x - free-spacing and line comments (aka extended)
        /// Flags cannot be provided when constructing one RegExp from another.</param>
        /// <returns>Extended regular expression object.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // With named capture and flag x
        /// XRegExp('(?&lt;year>  [0-9]{4} ) [-\\s]?  # year  \n\
        ///          (?&lt;month> [0-9]{2} ) [-\\s]?  # month \n\
        ///          (?&lt;day>   [0-9]{2} )          # day   ', 'x');
        /// 
        /// // Providing a regex object copies it. Native regexes are recompiled using native (not
        /// // XRegExp) syntax. Copies maintain special properties for named capture, are augmented
        /// // with `XRegExp.prototype` methods, and have fresh `lastIndex` properties (set to zero).
        /// XRegExp(/regex/);
        ///</code>
        ///</example>
        ///<remarks>
        ///Regexes, strings, and backslashes
        ///JavaScript string literals (as opposed to, e.g., user input or text extracted from the DOM) use a backslash as an escape character. The string literal '\\' therefore contains a single backslash, and its length property's value is 1. However, a backslash is also an escape character in regular expression syntax, where the pattern \\ matches a single backslash. When providing string literals to the RegExp or XRegExp constructor functions, four backslashes are therefore needed to match a single backslash—e.g., XRegExp('\\\\'). Only two of those backslashes are actually passed into the constructor function. The other two are used to escape the backslashes in the string before the function ever sees the string.
        ///The same issue is at play with the \\s sequences in the example code just shown. XRegExp is provided with the two characters \s, which it in turn recognizes as the metasequence used to match a whitespace character. \n (used at the end of the first two lines) is another metasequence in JavaScript string literals and inserts actual line feed characters into the string, which terminate the free-spacing mode line comments that start with #. The backslashes at the very end of the first two lines allow the string to continue to the next line, which avoids the need to concatenate multiple strings when extending a string beyond one line of code.
        /// </remarks>
        public XRegExp(JsRegExp pattern, JsString flags) { }
        /// <summary>
        /// Creates an extended regular expression object for matching text with a pattern. Differs from a native regular expression in that additional syntax and flags are supported.
        /// The returned object is in fact a native RegExp and works with all native methods.
        /// </summary>
        /// <param name="pattern">Regex pattern string, or an existing regex object to copy.</param>
        /// <returns>Extended regular expression object.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // With named capture and flag x
        /// XRegExp('(?&lt;year>  [0-9]{4} ) [-\\s]?  # year  \n\
        ///          (?&lt;month> [0-9]{2} ) [-\\s]?  # month \n\
        ///          (?&lt;day>   [0-9]{2} )          # day   ', 'x');
        /// 
        /// // Providing a regex object copies it. Native regexes are recompiled using native (not
        /// // XRegExp) syntax. Copies maintain special properties for named capture, are augmented
        /// // with `XRegExp.prototype` methods, and have fresh `lastIndex` properties (set to zero).
        /// XRegExp(/regex/);
        ///</code>
        ///</example>
        ///<remarks>
        ///Regexes, strings, and backslashes
        ///JavaScript string literals (as opposed to, e.g., user input or text extracted from the DOM) use a backslash as an escape character. The string literal '\\' therefore contains a single backslash, and its length property's value is 1. However, a backslash is also an escape character in regular expression syntax, where the pattern \\ matches a single backslash. When providing string literals to the RegExp or XRegExp constructor functions, four backslashes are therefore needed to match a single backslash—e.g., XRegExp('\\\\'). Only two of those backslashes are actually passed into the constructor function. The other two are used to escape the backslashes in the string before the function ever sees the string.
        ///The same issue is at play with the \\s sequences in the example code just shown. XRegExp is provided with the two characters \s, which it in turn recognizes as the metasequence used to match a whitespace character. \n (used at the end of the first two lines) is another metasequence in JavaScript string literals and inserts actual line feed characters into the string, which terminate the free-spacing mode line comments that start with #. The backslashes at the very end of the first two lines allow the string to continue to the next line, which avoids the need to concatenate multiple strings when extending a string beyond one line of code.
        /// </remarks>
        public XRegExp(JsString pattern) { }
        /// <summary>
        /// Creates an extended regular expression object for matching text with a pattern. Differs from a native regular expression in that additional syntax and flags are supported.
        /// The returned object is in fact a native RegExp and works with all native methods.
        /// </summary>
        /// <param name="pattern">Regex pattern string, or an existing regex object to copy.</param>
        /// <returns>Extended regular expression object.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // With named capture and flag x
        /// XRegExp('(?&lt;year>  [0-9]{4} ) [-\\s]?  # year  \n\
        ///          (?&lt;month> [0-9]{2} ) [-\\s]?  # month \n\
        ///          (?&lt;day>   [0-9]{2} )          # day   ', 'x');
        /// 
        /// // Providing a regex object copies it. Native regexes are recompiled using native (not
        /// // XRegExp) syntax. Copies maintain special properties for named capture, are augmented
        /// // with `XRegExp.prototype` methods, and have fresh `lastIndex` properties (set to zero).
        /// XRegExp(/regex/);
        ///</code>
        ///</example>
        ///<remarks>
        ///Regexes, strings, and backslashes
        ///JavaScript string literals (as opposed to, e.g., user input or text extracted from the DOM) use a backslash as an escape character. The string literal '\\' therefore contains a single backslash, and its length property's value is 1. However, a backslash is also an escape character in regular expression syntax, where the pattern \\ matches a single backslash. When providing string literals to the RegExp or XRegExp constructor functions, four backslashes are therefore needed to match a single backslash—e.g., XRegExp('\\\\'). Only two of those backslashes are actually passed into the constructor function. The other two are used to escape the backslashes in the string before the function ever sees the string.
        ///The same issue is at play with the \\s sequences in the example code just shown. XRegExp is provided with the two characters \s, which it in turn recognizes as the metasequence used to match a whitespace character. \n (used at the end of the first two lines) is another metasequence in JavaScript string literals and inserts actual line feed characters into the string, which terminate the free-spacing mode line comments that start with #. The backslashes at the very end of the first two lines allow the string to continue to the next line, which avoids the need to concatenate multiple strings when extending a string beyond one line of code.
        /// </remarks>
        public XRegExp(JsRegExp pattern) { }

        /// <summary>
        /// Extends or changes XRegExp syntax and allows custom flags. This is used internally and can be used to create XRegExp addons.
        /// XRegExp.install('extensibility') must be run before calling this function, or an error is thrown.
        /// If more than one token can match the same string, the last added wins.
        /// </summary>
        /// <param name="regex">Regex object that matches the new token.</param>
        /// <param name="handler">Function that returns a new pattern string (using native regex syntax) to replace the matched token within all future XRegExp regexes.
        /// Has access to persistent properties of the regex being built, through this. Invoked with two arguments:
        /// The match array, with named backreference properties.
        /// The regex scope where the match was found.</param>
        /// <param name="options">
        /// Options object with optional properties:
        /// scope {String} Scopes where the token applies: 'default', 'class', or 'all'.
        /// trigger {Function} Function that returns true when the token should be applied; e.g., if a flag is set. If false is returned, the matched string can be matched by other tokens.
        /// Has access to persistent properties of the regex being built, through this (including function this.hasFlag).
        /// customFlags {String} Nonnative flags used by the token's handler or trigger functions.
        /// Prevents XRegExp from throwing an 'unknown flag' error when the specified flags are used.</param>
        ///<example>
        ///usage
        ///<code>
        /// // Basic usage: Add \a for the ALERT control code
        /// XRegExp.addToken(
        ///   /\\a/,
        ///   function () {return '\\x07';},
        ///   {scope: 'all'}
        /// );
        /// XRegExp('\\a[\\a-\\n]+').test('\x07\n\x07'); // -> true
        ///</code>
        ///</example>
        public static void addToken(JsRegExp regex, JsAction handler, XRegExpAddTokenOptions options) { }
        /// <summary>
        /// Extends or changes XRegExp syntax and allows custom flags. This is used internally and can be used to create XRegExp addons.
        /// XRegExp.install('extensibility') must be run before calling this function, or an error is thrown.
        /// If more than one token can match the same string, the last added wins.
        /// </summary>
        /// <param name="regex">Regex object that matches the new token.</param>
        /// <param name="handler">Function that returns a new pattern string (using native regex syntax) to replace the matched token within all future XRegExp regexes.
        /// Has access to persistent properties of the regex being built, through this. Invoked with two arguments:
        /// The match array, with named backreference properties.
        /// The regex scope where the match was found.</param>
        ///<example>
        ///usage
        ///<code>
        /// // Basic usage: Add \a for the ALERT control code
        /// XRegExp.addToken(
        ///   /\\a/,
        ///   function () {return '\\x07';},
        ///   {scope: 'all'}
        /// );
        /// XRegExp('\\a[\\a-\\n]+').test('\x07\n\x07'); // -> true
        ///</code>
        ///</example>
        public static void addToken(JsRegExp regex, JsAction handler) { }

        /// <summary>
        /// Addon: Builds regexes using named subpatterns, for readability and pattern reuse.
        /// Backreferences in the outer pattern and provided subpatterns are automatically renumbered to work correctly. Returns a regex with interpolated subpatterns.
        /// </summary>
        /// <param name="pattern">XRegExp pattern using {{name}} for embedded subpatterns. Allows ({{name}}) as shorthand for (?&lt;name>{{name}}).
        /// Patterns cannot be embedded within character classes.</param>
        /// <param name="subs">Lookup object for named subpatterns.
        /// Values can be strings or regexes. A leading ^ and trailing unescaped $ are stripped from subpatterns, if both are present.</param>
        /// <param name="flags">Any combination of XRegExp flags.</param>
        /// <returns>Regex with interpolated subpatterns.</returns>
        public static JsRegExp build(JsString pattern, object subs, JsString flags) { return null; }
        /// <summary>
        /// Addon: Builds regexes using named subpatterns, for readability and pattern reuse.
        /// Backreferences in the outer pattern and provided subpatterns are automatically renumbered to work correctly. Returns a regex with interpolated subpatterns.
        /// </summary>
        /// <param name="pattern">XRegExp pattern using {{name}} for embedded subpatterns. Allows ({{name}}) as shorthand for (?&lt;name>{{name}}).
        /// Patterns cannot be embedded within character classes.</param>
        /// <param name="subs">Lookup object for named subpatterns.
        /// Values can be strings or regexes. A leading ^ and trailing unescaped $ are stripped from subpatterns, if both are present.</param>
        /// <returns>Regex with interpolated subpatterns.</returns>
        public static JsRegExp build(JsString pattern, object subs) { return null; }

        /// <summary>
        /// Caches and returns the result of calling XRegExp(pattern, flags). On any subsequent call with the same pattern and flag combination, the cached copy is returned.
        /// </summary>
        /// <param name="pattern">Regex pattern string.</param>
        /// <param name="flags">Any combination of XRegExp flags.</param>
        /// <returns>Cached XRegExp object.</returns>
        ///<example>
        ///usage
        ///<code>
        ///while (match = XRegExp.cache('.', 'gs').exec(str)) {
        ///   // The regex is compiled once only
        /// }
        /// 
        /// var regex1 = XRegExp.cache('.', 's'),
        /// var regex2 = XRegExp.cache('.', 's');
        /// // regex1 and regex2 are references to the same regex object
        ///</code>
        ///</example>
        public static XRegExp cache(JsString pattern, JsString flags) { return null; }
        /// <summary>
        /// Caches and returns the result of calling XRegExp(pattern, flags). On any subsequent call with the same pattern and flag combination, the cached copy is returned.
        /// </summary>
        /// <param name="pattern">Regex pattern string.</param>
        /// <returns>Cached XRegExp object.</returns>
        ///<example>
        ///usage
        ///<code>
        ///while (match = XRegExp.cache('.', 'gs').exec(str)) {
        ///   // The regex is compiled once only
        /// }
        /// 
        /// var regex1 = XRegExp.cache('.', 's'),
        /// var regex2 = XRegExp.cache('.', 's');
        /// // regex1 and regex2 are references to the same regex object
        ///</code>
        ///</example>
        public static XRegExp cache(JsString pattern) { return null; }

        /// <summary>
        /// Escapes any regular expression metacharacters, for use when matching literal strings. The result can safely be used at any point within a regex that uses any flags.
        /// The escaped characters are [, ], {, }, (, ), -, *, +, ?, ., \, ^, $, |, ,, #, and whitespace (see free-spacing for the list of whitespace characters).
        /// </summary>
        /// <param name="str">String to escape.</param>
        /// <returns>String with regex metacharacters escaped.</returns>
        ///<example>
        ///usage
        ///<code>
        ///XRegExp.escape('Escaped? &lt;.>');
        /// // -> 'Escaped\?\ &lt;\.>'
        ///</code>
        ///</example>
        public static JsString escape(JsString str) { return null; }

        /// <summary>
        /// Executes a regex search in a specified string. Returns a match array or null. If the provided regex uses named capture, named backreference properties are included on the match array.
        /// Optional pos and sticky arguments specify the search start position, and whether the match must start at the specified position only. The lastIndex property of the provided regex is not used, but is updated for compatibility.
        /// Also fixes browser bugs compared to the native RegExp.prototype.exec and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <param name="pos">Zero-based index at which to start the search.</param>
        /// <param name="sticky">Whether the match must start at the specified position only. The string 'sticky' is accepted as an alternative to true</param>
        /// <returns>Match array with named backreference properties, or null.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use, with named backreference
        /// var match = XRegExp.exec('U+2620', XRegExp('U\\+(?[0-9A-F]{4})'));
        /// match.hex; // -> '2620'
        /// 
        /// // With pos and sticky, in a loop
        /// var pos = 2, result = [], match;
        /// while (match = XRegExp.exec('&lt;1>&lt;2>&lt;3>&lt;4>5&lt;6>', /&lt;(\d)>/, pos, 'sticky')) {
        ///   result.push(match[1]);
        ///   pos = match.index + match[0].length;
        /// }
        /// // result -> ['2', '3', '4']
        ///</code>
        ///</example>
        public static JsArray exec(JsString str, JsRegExp regex, JsNumber pos, bool sticky) { return null; }
        /// <summary>
        /// Executes a regex search in a specified string. Returns a match array or null. If the provided regex uses named capture, named backreference properties are included on the match array.
        /// Optional pos and sticky arguments specify the search start position, and whether the match must start at the specified position only. The lastIndex property of the provided regex is not used, but is updated for compatibility.
        /// Also fixes browser bugs compared to the native RegExp.prototype.exec and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <param name="pos">Zero-based index at which to start the search.</param>
        /// <param name="sticky">Whether the match must start at the specified position only. The string 'sticky' is accepted as an alternative to true</param>
        /// <returns>Match array with named backreference properties, or null.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use, with named backreference
        /// var match = XRegExp.exec('U+2620', XRegExp('U\\+(?[0-9A-F]{4})'));
        /// match.hex; // -> '2620'
        /// 
        /// // With pos and sticky, in a loop
        /// var pos = 2, result = [], match;
        /// while (match = XRegExp.exec('&lt;1>&lt;2>&lt;3>&lt;4>5&lt;6>', /&lt;(\d)>/, pos, 'sticky')) {
        ///   result.push(match[1]);
        ///   pos = match.index + match[0].length;
        /// }
        /// // result -> ['2', '3', '4']
        ///</code>
        ///</example>
        public static JsArray exec(JsString str, JsRegExp regex, JsNumber pos, JsString sticky) { return null; }
        /// <summary>
        /// Executes a regex search in a specified string. Returns a match array or null. If the provided regex uses named capture, named backreference properties are included on the match array.
        /// Optional pos and sticky arguments specify the search start position, and whether the match must start at the specified position only. The lastIndex property of the provided regex is not used, but is updated for compatibility.
        /// Also fixes browser bugs compared to the native RegExp.prototype.exec and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <returns>Match array with named backreference properties, or null.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use, with named backreference
        /// var match = XRegExp.exec('U+2620', XRegExp('U\\+(?[0-9A-F]{4})'));
        /// match.hex; // -> '2620'
        /// 
        /// // With pos and sticky, in a loop
        /// var pos = 2, result = [], match;
        /// while (match = XRegExp.exec('&lt;1>&lt;2>&lt;3>&lt;4>5&lt;6>', /&lt;(\d)>/, pos, 'sticky')) {
        ///   result.push(match[1]);
        ///   pos = match.index + match[0].length;
        /// }
        /// // result -> ['2', '3', '4']
        ///</code>
        ///</example>
        public static JsArray exec(JsString str, JsRegExp regex) { return null; }

        /// <summary>
        /// Executes a provided function once per regex match.
        /// Provides a simpler and cleaner way to iterate over regex matches compared to the traditional approaches of subverting String.prototype.replace or repeatedly calling RegExp.prototype.exec within a while loop. Searches always start at the beginning of the string and continue until the end, regardless of the state of the regex's global property and initial lastIndex.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <param name="callback">Function to execute for each match. Invoked with four arguments:
        /// The match array, with named backreference properties.
        /// The zero-based match index.
        /// The string being traversed.
        /// The regex object being used to traverse the string.</param>
        /// <param name="context">Object to use as this when executing callback.</param>
        /// <returns>Provided context object.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Extracts every other digit from a string
        /// XRegExp.forEach('1a2345', /\d/, function (match, i) {
        ///   if (i % 2) this.push(+match[0]);
        /// }, []);
        /// // -> [2, 4]
        ///</code>
        ///</example>
        public static object forEach(JsString str, JsRegExp regex, JsAction callback, object context) { return null; }
        //TODO: callback gets 2 parameter.
        /// <summary>
        /// Executes a provided function once per regex match.
        /// Provides a simpler and cleaner way to iterate over regex matches compared to the traditional approaches of subverting String.prototype.replace or repeatedly calling RegExp.prototype.exec within a while loop. Searches always start at the beginning of the string and continue until the end, regardless of the state of the regex's global property and initial lastIndex.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <param name="callback">Function to execute for each match. Invoked with four arguments:
        /// The match array, with named backreference properties.
        /// The zero-based match index.
        /// The string being traversed.
        /// The regex object being used to traverse the string.</param>
        /// <returns>Provided context object.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Extracts every other digit from a string
        /// XRegExp.forEach('1a2345', /\d/, function (match, i) {
        ///   if (i % 2) this.push(+match[0]);
        /// }, []);
        /// // -> [2, 4]
        ///</code>
        ///</example>
        public static object forEach(JsString str, JsRegExp regex, JsAction callback) { return null; }
        //TODO: callback gets 2 parameter.

        /// <summary>
        /// Copies a regex object and adds flag g. The copy maintains special properties for named capture,
        /// is augmented with XRegExp.prototype methods, and has a fresh lastIndex property (set to zero). Native regexes are not recompiled using XRegExp syntax.
        /// </summary>
        /// <param name="regex">Regex to globalize.</param>
        /// <returns>Copy of the provided regex with flag g added.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var globalCopy = XRegExp.globalize(/regex/);
        /// globalCopy.global; // -> true
        /// 
        /// function parse(str, regex) {
        ///   var match;
        ///   regex = XRegExp.globalize(regex);
        ///   while (match = regex.exec(str)) {
        ///     // ...
        ///   }
        /// }
        ///</code>
        ///</example>
        public static JsRegExp globalize(JsRegExp regex) { return null; }

        /// <summary>
        /// Installs optional features according to the specified options. Can be undone using XRegExp.uninstall.
        /// </summary>
        /// <param name="options">Options object or string.</param>
        ///<example>
        ///usage
        ///<code>
        /// // With an options object
        /// XRegExp.install({
        ///   // Overrides native regex methods with fixed/extended versions that support named
        ///   // backreferences and fix numerous cross-browser bugs
        ///   natives: true,
        /// 
        ///   // Enables extensibility of XRegExp syntax and flags
        ///   extensibility: true
        /// });
        /// 
        /// // With an options string
        /// XRegExp.install('natives extensibility');
        ///</code>
        ///</example>
        public static void install(JsString options) { }
        //TODO: optins can be a Options object or string, but there is no optins class for this method.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feature">Name of the feature to check. One of: natives, extensibility</param>
        /// <returns>Whether the feature is installed.</returns>
        ///<example>
        ///usage
        ///<code>
        ///XRegExp.isInstalled('natives');
        ///</code>
        ///</example>
        public static bool isInstalled(JsString feature) { return false; }

        /// <summary>
        /// Returns true if an object is a regex; false if it isn't. This works correctly for regexes created in another frame, when instanceof and constructor checks would fail.
        /// </summary>
        /// <param name="value">Object to check.</param>
        /// <returns>Whether the object is a RegExp object.</returns>
        ///<example>
        ///usage
        ///<code>
        ///XRegExp.isRegExp('string'); // -> false
        /// XRegExp.isRegExp(/regex/i); // -> true
        /// XRegExp.isRegExp(RegExp('^', 'm')); // -> true
        /// XRegExp.isRegExp(XRegExp('(?s).')); // -> true
        ///</code>
        ///</example>
        public static bool isRegExp(object value) { return false; }

        /// <summary>
        /// Retrieves the matches from searching a string using a chain of regexes that successively search within previous matches. The provided chain array can contain regexes and objects with regex and backref properties.
        /// When a backreference is specified, the named or numbered backreference is passed forward to the next regex or returned.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chain">Regexes that each search for matches within preceding results.</param>
        /// <returns>Matches by the last regex in the chain, or an empty array.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic usage; matches numbers within &lt;b> tags
        /// XRegExp.matchChain('1 &lt;b>2&lt;/b> 3 &lt;b>4 a 56&lt;/b>', [
        ///   XRegExp('(?is)&lt;b>.*?&lt;/b>'),
        ///   /\d+/
        /// ]);
        /// // -> ['2', '4', '56']
        /// 
        /// // Passing forward and returning specific backreferences
        /// html = '&lt;a href="http://xregexp.com/api/">XRegExp&lt;/a>\
        ///         &lt;a href="http://www.google.com/">Google&lt;/a>';
        /// XRegExp.matchChain(html, [
        ///   {regex: /&lt;a href="([^"]+)">/i, backref: 1},
        ///   {regex: XRegExp('(?i)^https?://(?&lt;domain>[^/?#]+)'), backref: 'domain'}
        /// ]);
        /// // -> ['xregexp.com', 'www.google.com']
        ///</code>
        ///</example>
        public static JsArray matchChain(JsString str, JsArray chain) { return null; }

        /// <summary>
        /// Addon: Returns an array of match strings between outermost left and right delimiters,
        /// or an array of objects with detailed match parts and position data. An error is thrown if delimiters are unbalanced within the data.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="left">Left delimiter as an XRegExp pattern.</param>
        /// <param name="right">Right delimiter as an XRegExp pattern</param>
        /// <param name="flags">Flags for the left and right delimiters. Use any of: gimnsxy.</param>
        /// <param name="options">Lets you specify valueNames and escapeChar options.</param>
        /// <returns>Array of matches, or an empty array.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic usage
        /// var str = '(t((e))s)t()(ing)';
        /// XRegExp.matchRecursive(str, '\\(', '\\)', 'g');
        /// // -> ['t((e))s', '', 'ing']
        /// 
        /// // Extended information mode with valueNames
        /// str = 'Here is &lt;div> &lt;div>an&lt;/div>&lt;/div> example';
        /// XRegExp.matchRecursive(str, '&lt;div\\s*>', '&lt;/div>', 'gi', {
        ///   valueNames: ['between', 'left', 'match', 'right']
        /// });
        /// /* -> [
        /// {name: 'between', value: 'Here is ',       start: 0,  end: 8},
        /// {name: 'left',    value: '&lt;div>',          start: 8,  end: 13},
        /// {name: 'match',   value: ' &lt;div>an&lt;/div>', start: 13, end: 27},
        /// {name: 'right',   value: '&lt;/div>',         start: 27, end: 33},
        /// {name: 'between', value: ' example',       start: 33, end: 41}
        /// ] */
        /// 
        /// // Omitting unneeded parts with null valueNames, and using escapeChar
        /// str = '...{1}\\{{function(x,y){return y+x;}}';
        /// XRegExp.matchRecursive(str, '{', '}', 'g', {
        ///   valueNames: ['literal', null, 'value', null],
        ///   escapeChar: '\\'
        /// });
        /// /* -> [
        /// {name: 'literal', value: '...', start: 0, end: 3},
        /// {name: 'value',   value: '1',   start: 4, end: 5},
        /// {name: 'literal', value: '\\{', start: 6, end: 8},
        /// {name: 'value',   value: 'function(x,y){return y+x;}', start: 9, end: 35}
        /// ] */
        /// 
        /// // Sticky mode via flag y
        /// str = '&lt;1>&lt;&lt;&lt;2>>>&lt;3>4&lt;5>';
        /// XRegExp.matchRecursive(str, '&lt;', '>', 'gy');
        /// // -> ['1', '&lt;&lt;2>>', '3']
        ///</code>
        ///</example>
        public static JsArray matchRecursive(JsString str, JsString left, JsString right, JsString flags, object options) { return null; }
        /// <summary>
        /// Addon: Returns an array of match strings between outermost left and right delimiters,
        /// or an array of objects with detailed match parts and position data. An error is thrown if delimiters are unbalanced within the data.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="left">Left delimiter as an XRegExp pattern.</param>
        /// <param name="right">Right delimiter as an XRegExp pattern</param>
        /// <returns>Array of matches, or an empty array.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic usage
        /// var str = '(t((e))s)t()(ing)';
        /// XRegExp.matchRecursive(str, '\\(', '\\)', 'g');
        /// // -> ['t((e))s', '', 'ing']
        /// 
        /// // Extended information mode with valueNames
        /// str = 'Here is &lt;div> &lt;div>an&lt;/div>&lt;/div> example';
        /// XRegExp.matchRecursive(str, '&lt;div\\s*>', '&lt;/div>', 'gi', {
        ///   valueNames: ['between', 'left', 'match', 'right']
        /// });
        /// /* -> [
        /// {name: 'between', value: 'Here is ',       start: 0,  end: 8},
        /// {name: 'left',    value: '&lt;div>',          start: 8,  end: 13},
        /// {name: 'match',   value: ' &lt;div>an&lt;/div>', start: 13, end: 27},
        /// {name: 'right',   value: '&lt;/div>',         start: 27, end: 33},
        /// {name: 'between', value: ' example',       start: 33, end: 41}
        /// ] */
        /// 
        /// // Omitting unneeded parts with null valueNames, and using escapeChar
        /// str = '...{1}\\{{function(x,y){return y+x;}}';
        /// XRegExp.matchRecursive(str, '{', '}', 'g', {
        ///   valueNames: ['literal', null, 'value', null],
        ///   escapeChar: '\\'
        /// });
        /// /* -> [
        /// {name: 'literal', value: '...', start: 0, end: 3},
        /// {name: 'value',   value: '1',   start: 4, end: 5},
        /// {name: 'literal', value: '\\{', start: 6, end: 8},
        /// {name: 'value',   value: 'function(x,y){return y+x;}', start: 9, end: 35}
        /// ] */
        /// 
        /// // Sticky mode via flag y
        /// str = '&lt;1>&lt;&lt;2>>>&lt;3>4&lt;5>';
        /// XRegExp.matchRecursive(str, '&lt;', '>', 'gy');
        /// // -> ['1', '&lt;&lt;2>>', '3']
        ///</code>
        ///</example>
        public static JsArray matchRecursive(JsString str, JsString left, JsString right) { return null; }

        /// <summary>
        /// Returns a new string with one or all matches of a pattern replaced. The pattern can be a string or regex, and the replacement can be a string or a function to be called for each match.
        /// To perform a global search and replace, use the optional scope argument or include flag g if using a regex. Replacement strings can use ${n} for named and numbered backreferences.
        /// Replacement functions can use named backreferences via arguments[0].name.
        /// Also fixes browser bugs compared to the native String.prototype.replace and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="search">Search pattern to be replaced.</param>
        /// <param name="replacement">Replacement string or a function invoked to create it.
        /// Replacement strings can include special replacement syntax:
        /// $$ - Inserts a literal $ character.
        /// $&amp;, $0 - Inserts the matched substring.
        /// $` - Inserts the string that precedes the matched substring (left context).
        /// $' - Inserts the string that follows the matched substring (right context).
        /// $n, $nn - Where n/nn are digits referencing an existent capturing group, inserts backreference n/nn.
        /// ${n} - Where n is a name or any number of digits that reference an existent capturing group, inserts backreference n.
        /// Replacement functions are invoked with three or more arguments:
        /// The matched substring (corresponds to $&amp; above). Named backreferences are accessible as properties of this first argument.
        /// 0..n arguments, one for each backreference (corresponding to $1, $2, etc. above).
        /// The zero-based index of the match within the total search string.
        /// The total string being searched.</param>
        /// <param name="scope">Use 'one' to replace the first match only, or 'all'. If not explicitly specified and using a regex with flag g, scope is 'all'.</param>
        /// <returns>New string with one or all matches replaced.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Regex search, using named backreferences in replacement string
        /// var name = XRegExp('(?&lt;first>\\w+) (?&lt;last>\\w+)');
        /// XRegExp.replace('John Smith', name, '${last}, ${first}');
        /// // -> 'Smith, John'
        /// 
        /// // Regex search, using named backreferences in replacement function
        /// XRegExp.replace('John Smith', name, function (match) {
        ///   return match.last + ', ' + match.first;
        /// });
        /// // -> 'Smith, John'
        /// 
        /// // String search, with replace-all
        /// XRegExp.replace('RegExp builds RegExps', 'RegExp', 'XRegExp', 'all');
        /// // -> 'XRegExp builds XRegExps'
        ///</code>
        ///</example>
        public static JsString replace(JsString str, JsRegExp search, JsString replacement, JsString scope) { return null; }
        /// <summary>
        /// Returns a new string with one or all matches of a pattern replaced. The pattern can be a string or regex, and the replacement can be a string or a function to be called for each match.
        /// To perform a global search and replace, use the optional scope argument or include flag g if using a regex. Replacement strings can use ${n} for named and numbered backreferences.
        /// Replacement functions can use named backreferences via arguments[0].name.
        /// Also fixes browser bugs compared to the native String.prototype.replace and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="search">Search pattern to be replaced.</param>
        /// <param name="replacement">Replacement string or a function invoked to create it.
        /// Replacement strings can include special replacement syntax:
        /// $$ - Inserts a literal $ character.
        /// $&amp;, $0 - Inserts the matched substring.
        /// $` - Inserts the string that precedes the matched substring (left context).
        /// $' - Inserts the string that follows the matched substring (right context).
        /// $n, $nn - Where n/nn are digits referencing an existent capturing group, inserts backreference n/nn.
        /// ${n} - Where n is a name or any number of digits that reference an existent capturing group, inserts backreference n.
        /// Replacement functions are invoked with three or more arguments:
        /// The matched substring (corresponds to $&amp; above). Named backreferences are accessible as properties of this first argument.
        /// 0..n arguments, one for each backreference (corresponding to $1, $2, etc. above).
        /// The zero-based index of the match within the total search string.
        /// The total string being searched.</param>
        /// <returns>New string with one or all matches replaced.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Regex search, using named backreferences in replacement string
        /// var name = XRegExp('(?&lt;first>\\w+) (?&lt;last>\\w+)');
        /// XRegExp.replace('John Smith', name, '${last}, ${first}');
        /// // -> 'Smith, John'
        /// 
        /// // Regex search, using named backreferences in replacement function
        /// XRegExp.replace('John Smith', name, function (match) {
        ///   return match.last + ', ' + match.first;
        /// });
        /// // -> 'Smith, John'
        /// 
        /// // String search, with replace-all
        /// XRegExp.replace('RegExp builds RegExps', 'RegExp', 'XRegExp', 'all');
        /// // -> 'XRegExp builds XRegExps'
        ///</code>
        ///</example>
        public static JsString replace(JsString str, JsRegExp search, JsString replacement) { return null; }
        /// <summary>
        /// Returns a new string with one or all matches of a pattern replaced. The pattern can be a string or regex, and the replacement can be a string or a function to be called for each match.
        /// To perform a global search and replace, use the optional scope argument or include flag g if using a regex. Replacement strings can use ${n} for named and numbered backreferences.
        /// Replacement functions can use named backreferences via arguments[0].name.
        /// Also fixes browser bugs compared to the native String.prototype.replace and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="search">Search pattern to be replaced.</param>
        /// <param name="replacement">Replacement string or a function invoked to create it.
        /// Replacement strings can include special replacement syntax:
        /// $$ - Inserts a literal $ character.
        /// $&amp;, $0 - Inserts the matched substring.
        /// $` - Inserts the string that precedes the matched substring (left context).
        /// $' - Inserts the string that follows the matched substring (right context).
        /// $n, $nn - Where n/nn are digits referencing an existent capturing group, inserts backreference n/nn.
        /// ${n} - Where n is a name or any number of digits that reference an existent capturing group, inserts backreference n.
        /// Replacement functions are invoked with three or more arguments:
        /// The matched substring (corresponds to $&amp; above). Named backreferences are accessible as properties of this first argument.
        /// 0..n arguments, one for each backreference (corresponding to $1, $2, etc. above).
        /// The zero-based index of the match within the total search string.
        /// The total string being searched.</param>
        /// <param name="scope">Use 'one' to replace the first match only, or 'all'. If not explicitly specified and using a regex with flag g, scope is 'all'.</param>
        /// <returns>New string with one or all matches replaced.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Regex search, using named backreferences in replacement string
        /// var name = XRegExp('(?&lt;first>\\w+) (?&lt;last>\\w+)');
        /// XRegExp.replace('John Smith', name, '${last}, ${first}');
        /// // -> 'Smith, John'
        /// 
        /// // Regex search, using named backreferences in replacement function
        /// XRegExp.replace('John Smith', name, function (match) {
        ///   return match.last + ', ' + match.first;
        /// });
        /// // -> 'Smith, John'
        /// 
        /// // String search, with replace-all
        /// XRegExp.replace('RegExp builds RegExps', 'RegExp', 'XRegExp', 'all');
        /// // -> 'XRegExp builds XRegExps'
        ///</code>
        ///</example>
        public static JsString replace(JsString str, JsString search, JsAction replacement, JsString scope) { return null; }
        /// <summary>
        /// Returns a new string with one or all matches of a pattern replaced. The pattern can be a string or regex, and the replacement can be a string or a function to be called for each match.
        /// To perform a global search and replace, use the optional scope argument or include flag g if using a regex. Replacement strings can use ${n} for named and numbered backreferences.
        /// Replacement functions can use named backreferences via arguments[0].name.
        /// Also fixes browser bugs compared to the native String.prototype.replace and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="search">Search pattern to be replaced.</param>
        /// <param name="replacement">Replacement string or a function invoked to create it.
        /// Replacement strings can include special replacement syntax:
        /// $$ - Inserts a literal $ character.
        /// $&amp;, $0 - Inserts the matched substring.
        /// $` - Inserts the string that precedes the matched substring (left context).
        /// $' - Inserts the string that follows the matched substring (right context).
        /// $n, $nn - Where n/nn are digits referencing an existent capturing group, inserts backreference n/nn.
        /// ${n} - Where n is a name or any number of digits that reference an existent capturing group, inserts backreference n.
        /// Replacement functions are invoked with three or more arguments:
        /// The matched substring (corresponds to $&amp; above). Named backreferences are accessible as properties of this first argument.
        /// 0..n arguments, one for each backreference (corresponding to $1, $2, etc. above).
        /// The zero-based index of the match within the total search string.
        /// The total string being searched.</param>
        /// <returns>New string with one or all matches replaced.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Regex search, using named backreferences in replacement string
        /// var name = XRegExp('(?&lt;first>\\w+) (?&lt;last>\\w+)');
        /// XRegExp.replace('John Smith', name, '${last}, ${first}');
        /// // -> 'Smith, John'
        /// 
        /// // Regex search, using named backreferences in replacement function
        /// XRegExp.replace('John Smith', name, function (match) {
        ///   return match.last + ', ' + match.first;
        /// });
        /// // -> 'Smith, John'
        /// 
        /// // String search, with replace-all
        /// XRegExp.replace('RegExp builds RegExps', 'RegExp', 'XRegExp', 'all');
        /// // -> 'XRegExp builds XRegExps'
        ///</code>
        ///</example>
        public static JsString replace(JsString str, JsString search, JsAction replacement) { return null; }

        /// <summary>
        /// Splits a string into an array of strings using a regex or string separator. Matches of the separator are not included in the result array.
        /// However, if separator is a regex that contains capturing groups, backreferences are spliced into the result each time separator is matched.
        /// Fixes browser bugs compared to the native String.prototype.split and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to split.</param>
        /// <param name="separator">Regex or string to use for separating the string.</param>
        /// <param name="limit">Maximum number of items to include in the result array.</param>
        /// <returns>Array of substrings.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use
        /// XRegExp.split('a b c', ' ');
        /// // -> ['a', 'b', 'c']
        /// 
        /// // With limit
        /// XRegExp.split('a b c', ' ', 2);
        /// // -> ['a', 'b']
        /// 
        /// // Backreferences in result array
        /// XRegExp.split('..word1..', /([a-z]+)(\d+)/i);
        /// // -> ['..', 'word', '1', '..']
        ///</code>
        ///</example>
        public static JsArray split(JsString str, JsRegExp separator, JsNumber limit) { return null; }

        /// <summary>
        /// Executes a regex search in a specified string. Returns true or false. Optional pos and sticky arguments specify the search start position, and whether the match must start at the specified position only. The lastIndex property of the provided regex is not used, but is updated for compatibility.
        /// Also fixes browser bugs compared to the native RegExp.prototype.test and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <param name="pos">Zero-based index at which to start the search.</param>
        /// <param name="sticky">Whether the match must start at the specified position only. The string 'sticky' is accepted as an alternative to true.</param>
        /// <returns>Whether the regex matched the provided value.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use
        /// XRegExp.test('abc', /c/); // -> true
        /// 
        /// // With pos and sticky
        /// XRegExp.test('abc', /c/, 0, 'sticky'); // -> false
        ///</code>
        ///</example>
        public static bool test(JsString str, JsRegExp regex, JsNumber pos, bool sticky) { return false; }
        /// <summary>
        /// Executes a regex search in a specified string. Returns true or false. Optional pos and sticky arguments specify the search start position, and whether the match must start at the specified position only. The lastIndex property of the provided regex is not used, but is updated for compatibility.
        /// Also fixes browser bugs compared to the native RegExp.prototype.test and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <param name="pos">Zero-based index at which to start the search.</param>
        /// <param name="sticky">Whether the match must start at the specified position only. The string 'sticky' is accepted as an alternative to true.</param>
        /// <returns>Whether the regex matched the provided value.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use
        /// XRegExp.test('abc', /c/); // -> true
        /// 
        /// // With pos and sticky
        /// XRegExp.test('abc', /c/, 0, 'sticky'); // -> false
        ///</code>
        ///</example>
        public static bool test(JsString str, JsRegExp regex, JsNumber pos, JsString sticky) { return false; }
        /// <summary>
        /// Executes a regex search in a specified string. Returns true or false. Optional pos and sticky arguments specify the search start position, and whether the match must start at the specified position only. The lastIndex property of the provided regex is not used, but is updated for compatibility.
        /// Also fixes browser bugs compared to the native RegExp.prototype.test and can be used reliably cross-browser.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="regex">Regex to search with.</param>
        /// <returns>Whether the regex matched the provided value.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // Basic use
        /// XRegExp.test('abc', /c/); // -> true
        /// 
        /// // With pos and sticky
        /// XRegExp.test('abc', /c/, 0, 'sticky'); // -> false
        ///</code>
        ///</example>
        public static bool test(JsString str, JsRegExp regex) { return false; }

        /// <summary>
        /// Uninstalls optional features according to the specified options. All optional features start out uninstalled, so this is used to undo the actions of XRegExp.install.
        /// </summary>
        /// <param name="options">Options object or string.</param>
        ///<example>
        ///usage
        ///<code>
        /// // With an options object
        /// XRegExp.uninstall({
        ///   // Restores native regex methods
        ///   natives: true,
        /// 
        ///   // Disables additional syntax and flag extensions
        ///   extensibility: true
        /// });
        /// 
        /// // With an options string
        /// XRegExp.uninstall('natives extensibility');
        ///</code>
        ///</example>
        public static void uninstall(object options) { }
        /// <summary>
        /// Uninstalls optional features according to the specified options. All optional features start out uninstalled, so this is used to undo the actions of XRegExp.install.
        /// </summary>
        /// <param name="options">Options object or string.</param>
        ///<example>
        ///usage
        ///<code>
        /// // With an options object
        /// XRegExp.uninstall({
        ///   // Restores native regex methods
        ///   natives: true,
        /// 
        ///   // Disables additional syntax and flag extensions
        ///   extensibility: true
        /// });
        /// 
        /// // With an options string
        /// XRegExp.uninstall('natives extensibility');
        ///</code>
        ///</example>
        public static void uninstall(JsString options) { }

        /// <summary>
        /// Returns an XRegExp object that is the union of the given patterns. Patterns can be provided as regex objects or strings. Metacharacters are escaped in patterns provided as strings.
        /// Backreferences in provided regex objects are automatically renumbered to work correctly. Native flags used by provided regexes are ignored in favor of the flags argument.
        /// </summary>
        /// <param name="patterns">Regexes and strings to combine.</param>
        /// <param name="flags">Any combination of XRegExp flags.</param>
        /// <returns>Union of the provided regexes and strings.</returns>
        ///<example>
        ///usage
        ///<code>
        ///XRegExp.union(['a+b*c', /(dogs)\1/, /(cats)\1/], 'i');
        /// // -> /a\+b\*c|(dogs)\1|(cats)\2/i
        ///</code>
        ///</example>
        public static JsRegExp union(JsArray patterns, JsString flags) { return null; }
        /// <summary>
        /// Returns an XRegExp object that is the union of the given patterns. Patterns can be provided as regex objects or strings. Metacharacters are escaped in patterns provided as strings.
        /// Backreferences in provided regex objects are automatically renumbered to work correctly. Native flags used by provided regexes are ignored in favor of the flags argument.
        /// </summary>
        /// <param name="patterns">Regexes and strings to combine.</param>
        /// <returns>Union of the provided regexes and strings.</returns>
        ///<example>
        ///usage
        ///<code>
        ///XRegExp.union(['a+b*c', /(dogs)\1/, /(cats)\1/], 'i');
        /// // -> /a\+b\*c|(dogs)\1|(cats)\2/i
        ///</code>
        ///</example>
        public static JsRegExp union(JsArray patterns) { return null; }

        /// <summary>
        /// The XRegExp version number as a string containing three dot-separated parts. For instance, '2.0.0-beta-3'.
        /// </summary>
        /// <param name="ver"></param>
        public static void version(JsString ver) { }
        //TODO: in the documnetion threr where no paremeters but it seems wird, so i gussed them.

        /// <summary>
        /// Addon: Implicitly calls the regex's test method with the first value in the provided args array. context is ignored.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="args"></param>
        public void apply(object context, JsArray args) { }

        /// <summary>
        /// Addon: Implicitly calls the regex's test method with the provided string. context is ignored.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="str"></param>
        public void call(object context, JsString str) { }

        /// <summary>
        /// Addon: Implicitly calls XRegExp.forEach.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="callback"></param>
        /// <param name="context"></param>
        public void forEach(JsString str, JsAction callback, object context) { }

        /// <summary>
        /// Addon: Implicitly calls XRegExp.globalize.
        /// </summary>
        public void globalize() { }

        /// <summary>
        /// Addon: Implicitly calls XRegExp.exec.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pos"></param>
        /// <param name="sticky"></param>
        public void xexec(JsString str, JsNumber pos, bool sticky) { }
        /// <summary>
        /// Addon: Implicitly calls XRegExp.exec.
        /// </summary>
        /// <param name="str"></param>
        public void xexec(JsString str) { }

        /// <summary>
        /// Addon: Implicitly calls XRegExp.test.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pos"></param>
        /// <param name="sticky"></param>
        public void xtest(JsString str, JsNumber pos, bool sticky) { }
        /// <summary>
        /// Addon: Implicitly calls XRegExp.test.
        /// </summary>
        /// <param name="str"></param>
        public void xtest(JsString str) { }
    }

    public class XRegExpAddTokenOptions
    {
        /// <summary>
        ///  Scopes where the token applies: 'default', 'class', or 'all'.
        /// </summary>
        public JsString scope { get; set; }

        /// <summary>
        /// Function that returns true when the token should be applied; e.g., if a flag is set. If false is returned, the matched string can be matched by other tokens.
        /// Has access to persistent properties of the regex being built, through this (including function this.hasFlag).
        /// </summary>
        public JsAction trigger { get; set; }

        /// <summary>
        /// Nonnative flags used by the token's handler or trigger functions. Prevents XRegExp from throwing an 'unknown flag' error when the specified flags are used.
        /// </summary>
        public JsString customFlags { get; set; }
    }
}
