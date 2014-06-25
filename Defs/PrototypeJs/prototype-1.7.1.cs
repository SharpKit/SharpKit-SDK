using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.PrototypeJs
{
    #region Prototype

    //TODO: Prototype namespace

    /// <summary>
    /// A collection of Boolean values indicating the browser which is currently in use.
    /// Available properties are IE, Opera, WebKit, MobileSafari and Gecko.
    /// </summary>
    ///<example>
    ///usage
    ///<code>
    ///Prototype.Browser.WebKit;
    /// //-> true, when executed in any WebKit-based browser.
    ///</code>
    ///</example>
    [JsType(JsMode.Prototype, Name = "Prototype.Browser", Export = false)]
    public class Browser
    {
        public bool IE { get; set; }
        public bool Opera { get; set; }
        public bool WebKit { get; set; }
        public bool MobileSafari { get; set; }
        public bool Gecko { get; set; }
    }

    /// <summary>
    /// A collection of Boolean values indicating the presence of specific browser features.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Prototype.BrowserFeatures", Export = false)]
    public class BrowserFeatures
    {
        /// <summary>
        /// Used internally to detect if the browser supports extending html element prototypes.
        /// </summary>
        public bool ElementExtensions { get; set; }
        /// <summary>
        /// Used internally to detect if the browser supports the NodeSelector API.
        /// </summary>
        public bool SelectorsAPI { get; set; }
        /// <summary>
        /// Used internally to detect if the browser supports DOM Level 3 XPath.
        /// </summary>
        public bool XPath { get; set; }
    }

    /// <summary>
    /// A namespace that acts as a wrapper around the choosen selector engine (Sizzle by default).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Prototype.Selector", Export = false)]
    public class Selector
    {
        /// <summary>
        /// Alias of: Element.extend
        /// Extends the given element instance with all of the Prototype goodness and syntactic sugar, as well as any extensions added via Element.addMethods.
        /// (If the element instance was already extended, this is a no-op.)
        /// You only need to use Element.extend on element instances you've acquired directly from the DOM;
        /// all Prototype methods that return element instances (such as $, Element.down, etc.) will pre-extend the element before returning it.
        /// Check out "How Prototype extends the DOM" for more about element extensions.
        /// Specifically, Element.extend extends the given instance with the methods contained in Element.Methods and Element.Methods.Simulated.
        /// If element is an input, textarea, or select element, it will also be extended with the methods from Form.Element.Methods.
        /// If it is a form element, it will also be extended with the methods from Form.Methods.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public HtmlElement extendElement(HtmlElement element) { return null; }

        /// <summary>
        /// If necessary, extends the elements contained in elements and returns elements untouched.
        /// This is provided as a convenience method for selector engine wrapper implementors.
        /// </summary>
        /// <param name="elements">elements (Enumerable) – a collection of DOM elements.</param>
        /// <returns></returns>
        public Enumerable<HtmlElement> extendElements(Enumerable<HtmlElement> elements) { return null; }
        //TODO: check

        /// <summary>
        /// Filters the given collection of elements with expression and returns the first matching element (or the indexth matching element if index is specified).
        /// </summary>
        /// <param name="elements">(Enumerable) – a collection of DOM elements.</param>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="index">Numeric index of the match to return, defaults to 0.</param>
        /// <returns></returns>
        public HtmlElement find(Enumerable<HtmlElement> elements, JsString expression, JsNumber index) { return null; }
        /// <summary>
        /// Filters the given collection of elements with expression and returns the first matching element (or the indexth matching element if index is specified).
        /// </summary>
        /// <param name="elements">(Enumerable) – a collection of DOM elements.</param>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <returns></returns>
        public HtmlElement find(Enumerable<HtmlElement> elements, JsString expression) { return null; }

        /// <summary>
        /// Tests whether element matches the CSS selector.
        /// </summary>
        /// <param name="element">(Element) – a DOM element.</param>
        /// <param name="expression"> (String) – A CSS selector.</param>
        /// <returns></returns>
        public bool match(HtmlElement element, JsString expression) { return false; }

        /// <summary>
        /// Searches root for elements that match the provided CSS selector and returns an array of extended Element objects.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="root">(Element | document) – A "scope" to search within. All results will be descendants of this node.</param>
        /// <returns></returns>
        public JsArray<HtmlElement> select(JsString expression, HtmlElement root) { return null; }
        /// <summary>
        /// Searches root for elements that match the provided CSS selector and returns an array of extended Element objects.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="root">(Element | document) – A "scope" to search within. All results will be descendants of this node.</param>
        /// <returns></returns>
        public JsArray<HtmlElement> select(JsString expression, HtmlDocument root) { return null; }
    }



    public class Prototype
    {
        /// <summary>
        /// The Prototype.emptyFunction does nothing... and returns nothing!
        /// It is used thoughout the framework to provide a fallback function in order to cut down on conditionals.
        /// Typically you'll find it as a default value for optional callback functions.
        /// </summary>
        /// <param name="argument"></param>
        public void emptyFunction(object argument) { }
        /// <summary>
        /// The Prototype.emptyFunction does nothing... and returns nothing!
        /// It is used thoughout the framework to provide a fallback function in order to cut down on conditionals.
        /// Typically you'll find it as a default value for optional callback functions.
        /// </summary>
        public void emptyFunction() { }

        /// <summary>
        /// Prototype.K is Prototype's very own identity function, i.e. it returns its argument untouched.
        /// This is used throughout the framework, most notably in the Enumerable module as a default value for iterators.
        /// </summary>
        /// <param name="argument">(Object) – Optional argument...</param>
        /// <returns></returns>
        public object K(object argument) { return null; }
        /// <summary>
        /// Prototype.K is Prototype's very own identity function, i.e. it returns its argument untouched.
        /// This is used throughout the framework, most notably in the Enumerable module as a default value for iterators.
        /// </summary>
        /// <returns></returns>
        public object K() { return null; }

        /// <summary>
        /// The version of the Prototype library you are using (e.g. "&lt;%= PROTOTYPE_VERSION %>").
        /// </summary>
        public JsString Version { get; set; }
    }

    #endregion
    //TODO: fix all elements!!!

    #region DOM section

    [JsType(JsMode.Global)]
    public class PrototypeContext
    {
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="el">(String | Element) – A DOM node or a string that references a node's ID.</param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static Element D(HtmlElement el) { return null; }
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="el">(String | Element) – A DOM node or a string that references a node's ID.</param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static Element D(JsString el) { return null; }
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static JsArray<Element> D(params HtmlElement[] elements) { return null; }
        /// <summary>
        /// If provided with a string, returns the element in the document with matching ID; otherwise returns the passed element.
        /// Takes in an arbitrary number of arguments. Returns one Element if given one argument; otherwise returns an Array of Elements.
        /// All elements returned by the function are "extended" with Element instance methods.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        [JsMethod(Name = "$")]
        public static JsArray<Element> D(params JsString[] elements) { return null; }

        /// <summary>
        /// Takes an arbitrary number of CSS selectors (strings) and returns a document-order array of extended DOM elements that match any of them.
        /// Sometimes the usual tools from your DOM arsenal -- document.getElementById encapsulated by $,
        /// getElementsByTagName and even Prototype's very own getElementsByClassName extensions -- just aren't enough to quickly find elements or collections of elements.
        /// If you know the DOM tree structure, you can simply resort to CSS selectors to get the job done.
        /// </summary>
        /// <param name="cssRule"></param>
        /// <returns></returns>
        [JsMethod(Name = "$$")]
        public static JsArray<Element> DD(params JsString[] cssRule) { return null; }

        /// <summary>
        /// Returns the value of a form control. This is a convenience alias of Form.Element.getValue. Refer to it for full details.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [JsMethod(Name = "$F")]
        public static JsString DF(HtmlElement element) { return null; }
        /// <summary>
        /// Returns the value of a form control. This is a convenience alias of Form.Element.getValue. Refer to it for full details.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        [JsMethod(Name = "$F")]
        public static JsArray<JsString> DF(params HtmlElement[] element) { return null; }

    }

    #region document

    /// <summary>
    /// Prototype extends the built-in document object with several convenience methods related to events.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "document", Export = false)]
    public class document : HtmlElement
    {
        /// <summary>
        /// Fires a custom event of name eventName with document as the target.
        /// document.fire is the document-wide version of Element.fire.
        /// Custom events must include a colon (:) in their names.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="memo">Metadata for the event. Will be accessible through the event's memo property.</param>
        /// <param name="bubble">Whether the event will bubble.</param>
        /// <returns></returns>
        public Event fire(JsString eventName, object memo, bool bubble) { return null; }
        /// <summary>
        /// Fires a custom event of name eventName with document as the target.
        /// document.fire is the document-wide version of Element.fire.
        /// Custom events must include a colon (:) in their names.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="memo">Metadata for the event. Will be accessible through the event's memo property.</param>
        /// <returns></returns>
        public Event fire(JsString eventName, object memo) { return null; }
        /// <summary>
        /// Fires a custom event of name eventName with document as the target.
        /// document.fire is the document-wide version of Element.fire.
        /// Custom events must include a colon (:) in their names.
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public Event fire(JsString eventName) { return null; }

        /// <summary>
        /// Listens for the given event over the entire document. Can also be used for listening to "dom:loaded" event.
        /// document.observe is the document-wide version of Element#observe. Using document.observe is equivalent to Event.observe(document, eventName, handler).
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public Element observe(JsString eventName, JsAction handler) { return null; }

        /// <summary>
        /// Unregisters an event handler from the document.
        /// document.stopObserving is the document-wide version of Element.stopObserving.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public Element stopObserving(JsString eventName, JsAction handler) { return null; }

        /// <summary>
        /// Whether the full DOM tree is ready for manipulation.
        /// </summary>
        public bool loaded { get; set; }
    }

    /// <summary>
    /// The document.viewport namespace contains methods that return information about the viewport — the rectangle that represents the portion of a web page within view.
    /// In other words, it's the browser window minus all chrome.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "document.viewport", Export = false)]
    public class viewport
    {
        /// <summary>
        /// Returns an object containing viewport dimensions in the form { width: Number, height: Number }.
        /// The viewport is the subset of the browser window that a page occupies — the "usable" space in a browser window.
        /// </summary>
        /// <returns></returns>
        public DimensionsOptions getDimensions() { return null; }

        /// <summary>
        /// Returns the height of the viewport.
        /// Equivalent to document.viewport.getDimensions().height.
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// Returns the viewport's horizontal and vertical scroll offsets.
        /// Returns an array in the form of [leftValue, topValue]. Also accessible as properties: { left: leftValue, top: topValue }.
        /// </summary>
        /// <returns></returns>
        [JsMethod(Name = "getScrollOffsets")]
        public JsArray getScrollOffsetsArray() { return null; }
        /// <summary>
        /// Returns the viewport's horizontal and vertical scroll offsets.
        /// Returns an array in the form of [leftValue, topValue]. Also accessible as properties: { left: leftValue, top: topValue }.
        /// </summary>
        /// <returns></returns>
        public ScrollOffsetsOptions getScrollOffsets() { return null; }

        /// <summary>
        /// Returns the width of the viewport.
        /// Equivalent to calling document.viewport.getDimensions().width.
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

    }
    [JsType(JsMode.Json)]
    public class DimensionsOptions
    {
        public JsNumber width { get; set; }

        public JsNumber height { get; set; }
    }
    [JsType(JsMode.Json)]
    public class ScrollOffsetsOptions
    {
        public JsNumber left { get; set; }

        public JsNumber top { get; set; }
    }

    #endregion

    #region Element

    /// <summary>
    /// The Element object provides a variety of powerful DOM methods for interacting with DOM elements — creating them, updating them, traversing them, etc.
    /// You can access these either as methods of Element itself, passing in the element to work with as the first argument, or as methods on extended element instances
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Element", Export = false)]
    public class Element
    {
        /// <summary>
        /// Creates an HTML element with tagName as the tag name, optionally with the given attributes.
        /// This can be markedly more concise than working directly with the DOM methods,
        /// and takes advantage of Prototype's workarounds for various browser issues with certain attributes:
        /// </summary>
        /// <param name="tagName"> (String) – The name of the HTML element to create.</param>
        /// <param name="attributes">(Object) – An optional group of attribute/value pairs to set on the element.</param>
        ///<example>
        ///usage
        ///<code>
        /// // The old way:
        /// var a = document.createElement('a');
        /// a.setAttribute('class', 'foo');
        /// a.setAttribute('href', '/foo.html');
        /// a.appendChild(document.createTextNode("Next page"));
        ///  // The new way:
        /// var a = new Element('a', {'class': 'foo', href: '/foo.html'}).update("Next page");
        ///</code>
        ///</example>
        public Element(JsString tagName, object attributes) { }
        /// <summary>
        /// Creates an HTML element with tagName as the tag name, optionally with the given attributes.
        /// This can be markedly more concise than working directly with the DOM methods,
        /// and takes advantage of Prototype's workarounds for various browser issues with certain attributes:
        /// </summary>
        /// <param name="tagName"> (String) – The name of the HTML element to create.</param>
        ///<example>
        ///usage
        ///<code>
        /// // The old way:
        /// var a = document.createElement('a');
        /// a.setAttribute('class', 'foo');
        /// a.setAttribute('href', '/foo.html');
        /// a.appendChild(document.createTextNode("Next page"));
        ///  // The new way:
        /// var a = new Element('a', {'class': 'foo', href: '/foo.html'}).update("Next page");
        ///</code>
        ///</example>
        public Element(JsString tagName) { }

        //TODO: Element.Methods http://api.prototypejs.org/dom/Element/Methods/

        //TODO: Class methods (static methods)

        /// <summary>
        /// Turns element into an absolutely-positioned element without changing its position in the page layout.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element absolutize() { return null; }

        /// <summary>
        /// Adds the given CSS class to element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="className"> (String) – The class name to add.</param>
        /// <returns></returns>
        public Element addClassName(JsString className) { return null; }

        /// <summary>
        /// Finds all siblings of the current element that match the given selector(s). If you provide multiple selectors, siblings matching any of the selectors are included.
        /// If a sibling matches multiple selectors, it is only included once. The order of the returned array is not defined.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="selector">(String) – A CSS selector.</param>
        /// <returns></returns>
        public Element adjacent(params JsString[] selector) { return null; }

        /// <summary>
        /// Collects all of element's ancestor elements and returns them as an array of extended elements.
        /// The returned array's first element is element's direct ancestor (its parentNode), the second one is its grandparent, and so on until the &lt;html> element is reached.
        /// &lt;html> will always be the last member of the array. Calling ancestors on the &lt;html> element will return an empty array.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> ancestors() { return null; }

        /// <summary>
        /// Collects all of the element's children and returns them as an array of Element.extended elements, in document order.
        /// The first entry in the array is the topmost child of element, the next is the child after that, etc.
        /// Like all of Prototype's DOM traversal methods, Element.childElements ignores text nodes and returns element nodes only.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> childElements() { return null; }

        /// <summary>
        /// Returns a new instance of Element.ClassNames, an Enumerable object used to read and write CSS class names of element.
        /// Deprecated, please see Element.addClassName, Element.removeClassName, and Element.hasClassName.
        /// If you want an array of classnames, you can use $w(element.className).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<JsString> classNames() { return null; }

        /// <summary>
        /// Removes all of element's child text nodes that contain only whitespace. Returns element.
        /// This can be very useful when using standard properties like nextSibling, previousSibling, firstChild or lastChild to walk the DOM.
        /// Usually you'd only do that if you are interested in all of the DOM nodes, not just Elements (since if you just need to traverse the Elements in the DOM tree,
        /// you can use Element.up, Element.down, Element.next, and Element.previous instead).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element cleanWhitespace() { return null; }

        /// <summary>
        /// Returns a duplicate of element.
        /// A wrapper around DOM Level 2 Node#cloneNode, Element.clone cleans up any expando properties defined by Prototype.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="deep"> (Boolean) – Whether to clone element's descendants as well.</param>
        /// <returns></returns>
        public Element clone(bool deep) { return null; }

        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <param name="options">(Object) – The position fields to clone.</param>
        /// <returns></returns>
        public Element clonePosition(HtmlElement source, PositionOptions options) { return null; }
        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <returns></returns>
        public Element clonePosition(HtmlElement source) { return null; }
        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <param name="options">(Object) – The position fields to clone.</param>
        /// <returns></returns>
        public Element clonePosition(JsString source, PositionOptions options) { return null; }
        /// <summary>
        /// Clones the position and/or dimensions of source onto the element as defined by options, with an optional offset for the left and top properties.
        /// Note that the element will be positioned exactly like source whether or not it is part of the same CSS containing block.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="source"> (Element | String) – The source element (or its ID).</param>
        /// <returns></returns>
        public Element clonePosition(JsString source) { return null; }

        /// <summary>
        /// Returns the offsets of element from the top left corner of the document.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Offset cumulativeOffset() { return null; }

        /// <summary>
        /// Calculates the cumulative scroll offset of an element in nested scrolling containers.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Offset cumulativeScrollOffset() { return null; }

        /// <summary>
        /// Checks if element is a descendant of ancestor.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="ancestor"> (Element | String) – The element to check against (or its ID).</param>
        /// <returns></returns>
        public bool descendantOf(Element ancestor) { return false; }
        /// <summary>
        /// Checks if element is a descendant of ancestor.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="ancestor"> (Element | String) – The element to check against (or its ID).</param>
        /// <returns></returns>
        public bool descendantOf(JsString ancestor) { return false; }

        /// <summary>
        /// Collects all of the element's descendants (its children, their children, etc.) and returns them as an array of extended elements.
        /// As with all of Prototype's DOM traversal methods, only Elements are returned, other nodes (text nodes, etc.) are skipped.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> descendants() { return null; }

        /// <summary>
        /// Returns element's first descendant (or the Nth descendant, if index is specified) that matches expression.
        /// If no expression is provided, all descendants are considered.
        /// If no descendant matches these criteria, undefined is returned.
        /// The Element.down method is part of Prototype's ultimate DOM traversal toolkit
        /// (check out Element.up, Element.next and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS rule-based selection of any of the element's descendants.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining:
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element down(JsString expression, JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first descendant (or the Nth descendant, if index is specified) that matches expression.
        /// If no expression is provided, all descendants are considered.
        /// If no descendant matches these criteria, undefined is returned.
        /// The Element.down method is part of Prototype's ultimate DOM traversal toolkit
        /// (check out Element.up, Element.next and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS rule-based selection of any of the element's descendants.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining:
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <returns></returns>
        public Element down(JsString expression) { return null; }
        /// <summary>
        /// Returns element's first descendant (or the Nth descendant, if index is specified) that matches expression.
        /// If no expression is provided, all descendants are considered.
        /// If no descendant matches these criteria, undefined is returned.
        /// The Element.down method is part of Prototype's ultimate DOM traversal toolkit
        /// (check out Element.up, Element.next and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS rule-based selection of any of the element's descendants.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining:
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element down(JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first descendant (or the Nth descendant, if index is specified) that matches expression.
        /// If no expression is provided, all descendants are considered.
        /// If no descendant matches these criteria, undefined is returned.
        /// The Element.down method is part of Prototype's ultimate DOM traversal toolkit
        /// (check out Element.up, Element.next and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS rule-based selection of any of the element's descendants.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining:
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element down() { return null; }

        /// <summary>
        /// See Event.fire.
        /// Fires a custom event with the current element as its target.
        /// Element.fire creates a custom event with the given name, then triggers it on the given element. The custom event has all the same properties and methods of native events. Like a native event, it will bubble up through the DOM unless its propagation is explicitly stopped.
        /// The optional second argument will be assigned to the memo property of the event object so that it can be read by event handlers.
        /// Custom events are dispatched synchronously: Element.fire waits until the event finishes its life cycle, then returns the event itself.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="memo"></param>
        /// <param name="bubble"></param>
        /// <returns></returns>
        public Event fire(JsString eventName, object memo, bool bubble) { return null; }
        /// <summary>
        /// See Event.fire.
        /// Fires a custom event with the current element as its target.
        /// Element.fire creates a custom event with the given name, then triggers it on the given element. The custom event has all the same properties and methods of native events. Like a native event, it will bubble up through the DOM unless its propagation is explicitly stopped.
        /// The optional second argument will be assigned to the memo property of the event object so that it can be read by event handlers.
        /// Custom events are dispatched synchronously: Element.fire waits until the event finishes its life cycle, then returns the event itself.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public Event fire(JsString eventName, object memo) { return null; }
        /// <summary>
        /// See Event.fire.
        /// Fires a custom event with the current element as its target.
        /// Element.fire creates a custom event with the given name, then triggers it on the given element. The custom event has all the same properties and methods of native events. Like a native event, it will bubble up through the DOM unless its propagation is explicitly stopped.
        /// The optional second argument will be assigned to the memo property of the event object so that it can be read by event handlers.
        /// Custom events are dispatched synchronously: Element.fire waits until the event finishes its life cycle, then returns the event itself.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public Event fire(JsString eventName) { return null; }

        /// <summary>
        /// Returns the first child that is an element.
        /// This is opposed to the firstChild DOM property, which will return any node, including text nodes and comment nodes.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element firstDescendant() { return null; }

        /// <summary>
        /// Finds the computed width and height of element and returns them as key/value pairs of an object.
        /// For backwards-compatibility, these dimensions represent the dimensions of the element's "border box" (including CSS padding and border).
        /// This is equivalent to the built-in offsetWidth and offsetHeight browser properties.
        /// Note that all values are returned as numbers only although they are expressed in pixels.
        /// Caveats:
        /// If the element is hidden via display: none in CSS, this method will attempt to measure the element by temporarily removing that CSS and applying visibility:
        /// hidden and position: absolute. This gives the element dimensions without making it visible or affecting the positioning of surrounding elements —
        /// but may not give accurate results in some cases. Element.measure is designed to give more accurate results.
        /// In order to avoid calling the method twice, you should consider caching the returned values in a variable, as shown in the example below.
        /// For more complex use cases, use Element.measure, which is able to measure many different aspects of an element's dimensions and offsets.
        /// </summary>
        /// <returns></returns>
        public object getDimensions() { return null; }

        /// <summary>
        /// Alias of: Element#select
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public JsArray<Element> getElementsBySelector(JsString selector) { return null; }

        /// <summary>
        /// Returns the height of element.
        /// This method returns correct values on elements whose display is set to none either in an inline style rule or in an CSS stylesheet.
        /// For performance reasons, if you need to query both width and height of element, you should consider using Element.getDimensions instead.
        /// Note that the value returned is a number only although it is expressed in pixels.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// Returns an instance of Element.Layout for measuring an element's dimensions.
        /// Note that this method returns a new Element.Layout object each time it's called.
        /// If you want to take advantage of measurement caching,
        /// retain a reference to one Element.Layout object, rather than calling Element.getLayout whenever you need a measurement.
        /// You should call Element.getLayout again only when the values in an existing Element.Layout object have become outdated.
        /// Remember that instances of Element.Layout compute values the first time they're asked for and remember those values for later retrieval.
        /// If you want to compute all an element's measurements at once, pass
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="preCompute"></param>
        /// <returns></returns>
        public Layout getLayout(Element element, bool preCompute) { return null; }
        /// <summary>
        /// Returns an instance of Element.Layout for measuring an element's dimensions.
        /// Note that this method returns a new Element.Layout object each time it's called.
        /// If you want to take advantage of measurement caching,
        /// retain a reference to one Element.Layout object, rather than calling Element.getLayout whenever you need a measurement.
        /// You should call Element.getLayout again only when the values in an existing Element.Layout object have become outdated.
        /// Remember that instances of Element.Layout compute values the first time they're asked for and remember those values for later retrieval.
        /// If you want to compute all an element's measurements at once, pass
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Layout getLayout(Element element) { return null; }
        /// <summary>
        /// Returns an instance of Element.Layout for measuring an element's dimensions.
        /// Note that this method returns a new Element.Layout object each time it's called.
        /// If you want to take advantage of measurement caching,
        /// retain a reference to one Element.Layout object, rather than calling Element.getLayout whenever you need a measurement.
        /// You should call Element.getLayout again only when the values in an existing Element.Layout object have become outdated.
        /// Remember that instances of Element.Layout compute values the first time they're asked for and remember those values for later retrieval.
        /// If you want to compute all an element's measurements at once, pass
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="preCompute"></param>
        /// <returns></returns>
        public Layout getLayout(bool preCompute) { return null; }
        /// <summary>
        /// Returns an instance of Element.Layout for measuring an element's dimensions.
        /// Note that this method returns a new Element.Layout object each time it's called.
        /// If you want to take advantage of measurement caching,
        /// retain a reference to one Element.Layout object, rather than calling Element.getLayout whenever you need a measurement.
        /// You should call Element.getLayout again only when the values in an existing Element.Layout object have become outdated.
        /// Remember that instances of Element.Layout compute values the first time they're asked for and remember those values for later retrieval.
        /// If you want to compute all an element's measurements at once, pass
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Layout getLayout() { return null; }

        /// <summary>
        /// Returns element's closest positioned ancestor. If none is found, the body element is returned.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element getOffsetParent() { return null; }

        /// <summary>
        /// Returns the opacity of the element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsString getOpacity() { return null; }

        /// <summary>
        /// Returns the Hash object that stores custom metadata for this element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Hash getStorage() { return null; }

        /// <summary>
        /// Returns the given CSS property value of element. The property can be specified in either its CSS form (font-size) or its camelized form (fontSize).
        /// This method looks up the CSS property of an element whether it was applied inline or in a stylesheet.
        /// It works around browser inconsistencies regarding float, opacity, which returns a value between 0 (fully transparent) and 1 (fully opaque),
        /// position properties (left, top, right and bottom) and when getting the dimensions (width or height) of hidden elements.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="style"> (String) – The property name to be retrieved.</param>
        /// <returns></returns>
        public JsString getStyle(JsString style) { return null; }

        /// <summary>
        /// Returns the width of element.
        /// This method returns correct values on elements whose display is set to none either in an inline style rule or in an CSS stylesheet.
        /// For performance reasons, if you need to query both width and height of element, you should consider using Element.getDimensions instead.
        /// Note that the value returned is a number only although it is expressed in pixels.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// Simulates the standard compliant DOM method hasAttribute for browsers missing it (Internet Explorer 6 and 7).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public bool hasAttribute(JsString attribute) { return false; }

        /// <summary>
        /// Checks for the presence of CSS class className on element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public bool hasClassName(JsString className) { return false; }

        /// <summary>
        /// Sets display: none on element. Returns element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element hide() { return null; }

        /// <summary>
        /// Returns element's ID. If element does not have an ID, one is generated, assigned to element, and returned.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsString identify() { return null; }

        /// <summary>
        /// This method is deprecated, please see Element.childElements.
        /// Alias of: Element#childElements
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> immediateDescendants() { return null; }

        /// <summary>
        /// Inserts content above, below, at the top, and/or at the bottom of the given element, depending on the option(s) given.
        /// insert accepts content in any of these forms: - String: A string of HTML to be parsed and rendered -
        /// Element: An Element instance to insert - ...any object with a toElement method: The method is called and the resulting element used -
        /// ...any object with a toHTML method: The method is called and the resulting HTML string is parsed and rendered
        /// The content argument can be the content to insert, in which case the implied insertion point is bottom, or an object that specifies one or more insertion points
        /// (e.g., { bottom: "foo", top: "bar" }).
        /// Accepted insertion points are: - before (as element's previous sibling) - after (as element's next sibling) - top (as element's first child) -
        /// bottom (as element's last child)
        /// Note that if the inserted HTML contains any &lt;script> tag, these will be automatically evaluated after the insertion
        /// (insert internally calls String.evalScripts when inserting HTML).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="content">(String | Element | Object) – The content to insert.</param>
        /// <returns></returns>
        public Element insert(JsString content) { return null; }
        /// <summary>
        /// Inserts content above, below, at the top, and/or at the bottom of the given element, depending on the option(s) given.
        /// insert accepts content in any of these forms: - String: A string of HTML to be parsed and rendered -
        /// Element: An Element instance to insert - ...any object with a toElement method: The method is called and the resulting element used -
        /// ...any object with a toHTML method: The method is called and the resulting HTML string is parsed and rendered
        /// The content argument can be the content to insert, in which case the implied insertion point is bottom, or an object that specifies one or more insertion points
        /// (e.g., { bottom: "foo", top: "bar" }).
        /// Accepted insertion points are: - before (as element's previous sibling) - after (as element's next sibling) - top (as element's first child) -
        /// bottom (as element's last child)
        /// Note that if the inserted HTML contains any &lt;script> tag, these will be automatically evaluated after the insertion
        /// (insert internally calls String.evalScripts when inserting HTML).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="content">(String | Element | Object) – The content to insert.</param>
        /// <returns></returns>
        public Element insert(HtmlElement content) { return null; }
        /// <summary>
        /// Inserts content above, below, at the top, and/or at the bottom of the given element, depending on the option(s) given.
        /// insert accepts content in any of these forms: - String: A string of HTML to be parsed and rendered -
        /// Element: An Element instance to insert - ...any object with a toElement method: The method is called and the resulting element used -
        /// ...any object with a toHTML method: The method is called and the resulting HTML string is parsed and rendered
        /// The content argument can be the content to insert, in which case the implied insertion point is bottom, or an object that specifies one or more insertion points
        /// (e.g., { bottom: "foo", top: "bar" }).
        /// Accepted insertion points are: - before (as element's previous sibling) - after (as element's next sibling) - top (as element's first child) -
        /// bottom (as element's last child)
        /// Note that if the inserted HTML contains any &lt;script> tag, these will be automatically evaluated after the insertion
        /// (insert internally calls String.evalScripts when inserting HTML).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="content">(String | Element | Object) – The content to insert.</param>
        /// <returns></returns>
        public Element insert(object content) { return null; }

        /// <summary>
        /// Returns the debug-oriented string representation of element.
        /// For more information on inspect methods, see Object.inspect.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsString inspect() { return null; }

        /// <summary>
        /// Simulates the poorly-supported CSS clip property by setting element's overflow value to hidden.
        /// To undo clipping, use Element.undoClipping.
        /// The visible area is determined by element's width and height.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element makeClipping() { return null; }

        /// <summary>
        /// Allows for the easy creation of a CSS containing block by setting element's CSS position to relative if its initial position is either static or undefined.
        /// To revert back to element's original CSS position, use Element.undoPositioned.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element makePositioned() { return null; }

        /// <summary>
        /// Checks if element matches the given CSS selector.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="selector">(String) – A CSS selector.</param>
        /// <returns></returns>
        public bool match(JsString selector) { return false; }

        /// <summary>
        /// Gives the pixel value of element's dimension specified by property.
        /// Useful for one-off measurements of elements. If you find yourself calling this method frequently over short spans of code,
        /// you might want to call Element.getLayout and operate on the Element.Layout object itself (thereby taking advantage of measurement caching).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public JsNumber measure(JsString property) { return null; }

        /// <summary>
        /// Returns element's first following sibling (or the Nth, if index is specified) that matches expression.
        /// If no expression is provided, all following siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.next method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up,
        /// Element.down and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS expression-based selection of any of element's following siblings.
        /// (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element next(JsString expression, JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first following sibling (or the Nth, if index is specified) that matches expression.
        /// If no expression is provided, all following siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.next method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up,
        /// Element.down and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS expression-based selection of any of element's following siblings.
        /// (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <returns></returns>
        public Element next(JsString expression) { return null; }
        /// <summary>
        /// Returns element's first following sibling (or the Nth, if index is specified) that matches expression.
        /// If no expression is provided, all following siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.next method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up,
        /// Element.down and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS expression-based selection of any of element's following siblings.
        /// (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element next(JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first following sibling (or the Nth, if index is specified) that matches expression.
        /// If no expression is provided, all following siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.next method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up,
        /// Element.down and Element.previous for some more Prototypish niceness).
        /// It allows precise index-based and/or CSS expression-based selection of any of element's following siblings.
        /// (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element next() { return null; }

        /// <summary>
        /// Collects all of element's next siblings and returns them as an Array of elements.
        /// Two elements are siblings if they have the same parent. So for example, the head and body elements are siblings
        /// (their parent is the html element). Next-siblings are simply the ones which follow element in the document.
        /// The returned Array reflects the siblings order in the document (e.g. an index of 0 refers to the sibling right below element).
        /// Note that all of Prototype's DOM traversal methods ignore text nodes and return element nodes only.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> nextSiblings() { return null; }

        /// <summary>
        /// See Event.observe.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public Element observe(JsString eventName, JsAction handler) { return null; }

        /// <summary>
        /// See Event.on.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="selector"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public Handler on(JsString eventName, JsString selector, JsAction callback) { return null; }
        /// <summary>
        /// See Event.on.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public Handler on(JsString eventName, JsString selector) { return null; }
        /// <summary>
        /// See Event.on.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public Handler on(JsString eventName) { return null; }

        /// <summary>
        /// Returns element's offset relative to its closest positioned ancestor (the element that would be returned by Element.getOffsetParent).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Offset positionedOffset() { return null; }

        /// <summary>
        /// Returns element's first previous sibling (or the Nth, if index is specified) that matches expression. If no expression is provided, all previous siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.previous method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up, Element.down and Element.next for some more Prototypish niceness). It allows precise index-based and/or CSS expression-based selection of any of element's previous siblings. (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element previous(JsString expression, JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first previous sibling (or the Nth, if index is specified) that matches expression. If no expression is provided, all previous siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.previous method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up, Element.down and Element.next for some more Prototypish niceness). It allows precise index-based and/or CSS expression-based selection of any of element's previous siblings. (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        /// <returns></returns>
        public Element previous(JsString expression) { return null; }
        /// <summary>
        /// Returns element's first previous sibling (or the Nth, if index is specified) that matches expression. If no expression is provided, all previous siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.previous method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up, Element.down and Element.next for some more Prototypish niceness). It allows precise index-based and/or CSS expression-based selection of any of element's previous siblings. (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element previous(JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first previous sibling (or the Nth, if index is specified) that matches expression. If no expression is provided, all previous siblings are considered. If none matches these criteria, undefined is returned.
        /// More information:
        /// The Element.previous method is part of Prototype's ultimate DOM traversal toolkit (check out Element.up, Element.down and Element.next for some more Prototypish niceness). It allows precise index-based and/or CSS expression-based selection of any of element's previous siblings. (Note that two elements are considered siblings if they have the same parent, so for example, the head and body elements are siblings—their parent is the html element.)
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extend) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element previous() { return null; }

        /// <summary>
        /// Collects all of element's previous siblings and returns them as an Array of elements.
        /// Two elements are siblings if they have the same parent. So for example, the &lt;head> and &lt;body> elements are siblings (their parent is the &lt;html> element).
        /// Previous-siblings are simply the ones which precede element in the document.
        /// The returned Array reflects the siblings inversed order in the document (e.g. an index of 0 refers to the lowest sibling i.e., the one closest to element).
        /// Note that all of Prototype's DOM traversal methods ignore text nodes and return element nodes only.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> previousSiblings() { return null; }

        /// <summary>
        /// Removes all event listeners and storage keys from an element.
        /// To be used just before removing an element from the page.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsString purge() { return null; }

        /// <summary>
        /// Returns the value of element's attribute or null if attribute has not been specified.
        /// This method serves two purposes. First it acts as a simple wrapper around getAttribute which isn't a "real" function in Safari and Internet Explorer
        /// (it doesn't have .apply or .call for instance). Secondly, it cleans up the horrible mess Internet Explorer makes when handling attributes.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public JsString readAttribute(JsString attributeName) { return null; }

        /// <summary>
        /// Recursively collects elements whose relationship to element is specified by property. property has to be a property (a method won't do!)
        /// of element that points to a single DOM node (e.g., nextSibling or parentNode).
        /// More information:
        /// This method is used internally by Element.ancestors, Element.descendants, Element.nextSiblings,
        /// Element.previousSiblings and Element.siblings which offer really convenient way to grab elements,
        /// so directly accessing Element.recursivelyCollect should seldom be needed. However, if you are after something out of the ordinary, it is the way to go.
        /// Note that all of Prototype's DOM traversal methods ignore text nodes and return element nodes only.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public JsArray<Element> recursivelyCollect(JsString property) { return null; }

        /// <summary>
        /// Turns element into a relatively-positioned element without changing its position in the page layout.
        /// Used to undo a call to Element.absolutize.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element relativize() { return null; }

        /// <summary>
        /// Completely removes element from the document and returns it.
        /// If you would rather just hide the element and keep it around for further use, try Element.hide instead.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element remove() { return null; }

        /// <summary>
        /// Removes CSS class className from element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public Element removeClassName(JsString className) { return null; }

        /// <summary>
        /// Replaces element itself with newContent and returns element.
        /// Keep in mind that this method returns the element that has just been removed — not the element that took its place.
        /// newContent can be either plain text, an HTML snippet or any JavaScript object which has a toString() method.
        /// If newContent contains any &lt;script> tags, these will be evaluated after element has been replaced (Element.replace internally calls String#evalScripts).
        /// Note that if no argument is provided, Element.replace will simply clear element of its content.
        /// However, using Element.remove to do so is both faster and more standard compliant.
        /// Warning:
        /// Using Element.replace as an instance method (e.g., $('foo').replace('&lt;p>Bar&lt;/p>')) causes errors in Opera 9 when used on input elements.
        /// The replace property is reserved on input elements as part of Web Forms 2. As a workaround, use the generic version instead (Element.replace('foo', '&lt;p>Bar&lt;/p>')).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="newContent"></param>
        /// <returns></returns>
        public Element replace(object newContent) { return null; }

        public T retrieve<T>(JsString key, T defaultValue) { return default(T); }
        public object retrieve(JsString key) { return null; }
        public T retrieve<T>(JsString key) { return default(T); }
        //TODO: Element#retrieve http://api.prototypejs.org/dom/Element/prototype/retrieve/

        /// <summary>
        /// Scrolls the window so that element appears at the top of the viewport.
        /// This has a similar effect than what would be achieved using HTML anchors (except the browser's history is not modified).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element scrollTo() { return null; }

        /// <summary>
        /// Takes an arbitrary number of CSS selectors and returns an array of descendants of element that match any of them.
        /// This method is very similar to $$ but can be used within the context of one element, rather than the whole document.
        /// The supported CSS syntax is identical, so please refer to the $$ docs for details.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Element select(JsString expression) { return null; }
        /// <summary>
        /// Takes an arbitrary number of CSS selectors and returns an array of descendants of element that match any of them.
        /// This method is very similar to $$ but can be used within the context of one element, rather than the whole document.
        /// The supported CSS syntax is identical, so please refer to the $$ docs for details.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public JsArray<Element> select(params JsString[] expression) { return null; }
        //TODO: check

        /// <summary>
        /// Sets the visual opacity of an element while working around inconsistencies in various browsers. The opacity argument should be a floating point number, where the value of 0 is fully transparent and 1 is fully opaque.
        /// Element.setStyle method uses Element.setOpacity internally when needed.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="opacity"></param>
        /// <returns></returns>
        public JsArray<Element> setOpacity(JsNumber opacity) { return null; }

        /// <summary>
        /// Modifies element's CSS style properties. Styles are passed as a hash of property-value pairs in which the properties are specified in their camelized form.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="styles"></param>
        /// <returns></returns>
        public Element setStyle(object styles) { return null; }
        //TODO: i think i shuld create a class for styles... http://api.prototypejs.org/dom/Element/prototype/setStyle/

        /// <summary>
        /// Removes display: none on element. Returns element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element show() { return null; }

        /// <summary>
        /// Collects all of element's siblings and returns them as an Array of elements.
        /// Two elements are siblings if they have the same parent. So for example, the head and body elements are siblings (their parent is the html element).
        /// The returned Array reflects the siblings' order in the document (e.g. an index of 0 refers to element's topmost sibling).
        /// Note that all of Prototype's DOM traversal methods ignore text nodes and return element nodes only.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> siblings() { return null; }

        /// <summary>
        /// See Event.stopObserving.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="handler"></param>
        /// <returns></returns>
        public Element stopObserving(JsString eventName, JsAction handler) { return null; }

        /// <summary>
        /// Stores a key/value pair of custom metadata on the element.
        /// The metadata can later be retrieved with Element.retrieve.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Element store(object key, object value) { return null; }
        //TODO: ?

        /// <summary>
        /// Toggles the visibility of element. Returns element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element toggle() { return null; }

        /// <summary>
        /// Toggles the presence of CSS class className on element.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public Element toggleClassName(JsString className) { return null; }

        /// <summary>
        /// Sets element's CSS overflow property back to the value it had before Element.makeClipping was applied.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element undoClipping() { return null; }

        /// <summary>
        /// Sets element back to the state it was in before Element.makePositioned was applied to it.
        /// element's absolutely positioned children will now have their positions set relatively to element's nearest ancestor with a CSS position of 'absolute', 'relative' or 'fixed'.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element undoPositioned() { return null; }

        /// <summary>
        /// Returns element's first ancestor (or the Nth ancestor, if index is specified) that matches expression.
        /// If no expression is provided, all ancestors are considered. If no ancestor matches these criteria, undefined is returned.
        /// More information:
        /// The Element.up method is part of Prototype's ultimate DOM traversal toolkit (check out Element.down,
        /// Element.next and Element.previous for some more Prototypish niceness). It allows precise index-based and/or CSS rule-based selection of any of element's ancestors.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extended) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element up(JsString expression, JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first ancestor (or the Nth ancestor, if index is specified) that matches expression.
        /// If no expression is provided, all ancestors are considered. If no ancestor matches these criteria, undefined is returned.
        /// More information:
        /// The Element.up method is part of Prototype's ultimate DOM traversal toolkit (check out Element.down,
        /// Element.next and Element.previous for some more Prototypish niceness). It allows precise index-based and/or CSS rule-based selection of any of element's ancestors.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extended) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public Element up(JsString expression) { return null; }
        /// <summary>
        /// Returns element's first ancestor (or the Nth ancestor, if index is specified) that matches expression.
        /// If no expression is provided, all ancestors are considered. If no ancestor matches these criteria, undefined is returned.
        /// More information:
        /// The Element.up method is part of Prototype's ultimate DOM traversal toolkit (check out Element.down,
        /// Element.next and Element.previous for some more Prototypish niceness). It allows precise index-based and/or CSS rule-based selection of any of element's ancestors.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extended) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Element up(JsNumber index) { return null; }
        /// <summary>
        /// Returns element's first ancestor (or the Nth ancestor, if index is specified) that matches expression.
        /// If no expression is provided, all ancestors are considered. If no ancestor matches these criteria, undefined is returned.
        /// More information:
        /// The Element.up method is part of Prototype's ultimate DOM traversal toolkit (check out Element.down,
        /// Element.next and Element.previous for some more Prototypish niceness). It allows precise index-based and/or CSS rule-based selection of any of element's ancestors.
        /// As it totally ignores text nodes (it only returns elements), you don't have to worry about whitespace nodes.
        /// And as an added bonus, all elements returned are already extended (see Element.extended) allowing chaining.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element up() { return null; }

        /// <summary>
        /// Replaces the content of element with the newContent argument and returns element.
        /// newContent may be in any of these forms:
        /// - String: A string of HTML to be parsed and rendered 
        /// - Element: An Element instance to insert 
        /// -...any object with a toElement method: The method is called and the resulting element used 
        /// - ...any object with a toHTML method: The method is called and the resulting HTML string is parsed and rendered
        /// If newContent is omitted, the element's content is blanked out (i.e., replaced with an empty string).
        /// If newContent is a string and contains one or more inline <script> tags, the scripts are scheduled to be evaluated after a very brief pause (using Function#defer) to allow the browser to finish updating the DOM. Note that the scripts are evaluated in the scope of String#evalScripts, not in the global scope, which has important ramifications for your vars and functions. See String#evalScripts for details.
        /// Note that this method allows seamless content update of table related elements in Internet Explorer 6 and beyond.
        /// Any nodes replaced with Element.update will first have event listeners unregistered and storage keys removed. This frees up memory and prevents leaks in certain versions of Internet Explorer. (See Element.purge).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="newContent"></param>
        /// <returns></returns>
        public Element update(object newContent) { return null; }

        /// <summary>
        /// Returns the X/Y coordinates of element relative to the viewport.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Offset viewportOffset() { return null; }

        /// <summary>
        /// Tells whether element is visible (i.e., whether its inline display CSS property is set to none.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public bool visible() { return false; }

        /// <summary>
        /// Wraps an element inside another, then returns the wrapper.
        /// If the given element exists on the page, Element.wrap will wrap it in place — its position will remain the same.
        /// The wrapper argument can be either an existing Element or a string representing the tag name of an element to be created.
        /// The optional attributes argument can contain a list of attribute/value pairs that will be set on the wrapper using Element.writeAttribute.
        /// </summary>
        /// <param name="wrapper"> (Element | String) – An element to wrap element inside, or else a string representing the tag name of an element to be created.</param>
        /// <param name="attributes"> (Object) – A set of attributes to apply to the wrapper element. Refer to the Element constructor for usage.</param>
        /// <returns></returns>
        public Element wrap(HtmlElement wrapper, object attributes) { return null; }
        /// <summary>
        /// Wraps an element inside another, then returns the wrapper.
        /// If the given element exists on the page, Element.wrap will wrap it in place — its position will remain the same.
        /// The wrapper argument can be either an existing Element or a string representing the tag name of an element to be created.
        /// The optional attributes argument can contain a list of attribute/value pairs that will be set on the wrapper using Element.writeAttribute.
        /// </summary>
        /// <param name="wrapper"> (Element | String) – An element to wrap element inside, or else a string representing the tag name of an element to be created.</param>
        /// <param name="attributes"> (Object) – A set of attributes to apply to the wrapper element. Refer to the Element constructor for usage.</param>
        /// <returns></returns>
        public Element wrap(JsString wrapper, object attributes) { return null; }

        /// <summary>
        /// Adds, specifies or removes attributes passed as either a hash or a name/value pair.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="attribute"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Element writeAttribute(object attribute, bool value) { return null; }
        /// <summary>
        /// Adds, specifies or removes attributes passed as either a hash or a name/value pair.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public Element writeAttribute(object attributes) { return null; }
        //TODO: ?
    }

    [JsType(JsMode.Json)]
    public class PositionOptions
    {
        /// <summary>
        /// Default:true. Clones source's left CSS property onto element.
        /// </summary>
        public bool setLeft { get; set; }
        /// <summary>
        /// Default:true. Clones source's top CSS property onto element.
        /// </summary>
        public bool setTop { get; set; }
        /// <summary>
        /// Default: true.Clones source's width onto element.
        /// </summary>
        public bool setWidth { get; set; }
        /// <summary>
        /// Default:true. Clones source's width onto element.
        /// </summary>
        public bool setHeight { get; set; }
        /// <summary>
        /// Default: 0. Number by which to offset element's left CSS property.
        /// </summary>
        public bool offsetLeft { get; set; }
        /// <summary>
        /// Default: 0. Number by which to offset element's top CSS property.
        /// </summary>
        public bool offsetTop { get; set; }
    }

    /// <summary>
    /// A set of key/value pairs representing measurements of various dimensions of an element.
    /// The Element.Layout class is a specialized way to measure elements. It helps mitigate:
    /// The convoluted steps often needed to get common measurements for elements.
    /// The tendency of browsers to report measurements in non-pixel units.
    /// The quirks that lead some browsers to report inaccurate measurements.
    /// The difficulty of measuring elements that are hidden.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Element.Layout", Export = false)]
    public class Layout : Hash
    {
        /// <summary>
        /// Declare a new layout hash.
        /// The preCompute argument determines whether measurements will be lazy-loaded or not.
        /// If you plan to use many different measurements, it's often more performant to pre-compute, as it minimizes the amount of overhead needed to measure.
        /// If you need only one or two measurements, it's probably not worth it.
        /// </summary>
        /// <param name="element">(Element) – The element to be measured.</param>
        /// <param name="preCompute">(Boolean) – Whether to compute all values at once. Default is false.</param>
        public Layout(Element element, bool preCompute) { }
        /// <summary>
        /// Declare a new layout hash.
        /// The preCompute argument determines whether measurements will be lazy-loaded or not.
        /// If you plan to use many different measurements, it's often more performant to pre-compute, as it minimizes the amount of overhead needed to measure.
        /// If you need only one or two measurements, it's probably not worth it.
        /// </summary>
        /// <param name="element">(Element) – The element to be measured.</param>
        public Layout(Element element) { }

        /// <summary>
        /// Retrieve the measurement specified by property. Will throw an error if the property is invalid.
        /// </summary>
        /// <param name="property">(String) – One of the properties defined in Element.Layout.PROPERTIES.</param>
        /// <returns></returns>
        public static JsNumber get(JsString property) { return null; }

        /// <summary>
        /// Converts the layout hash to a plain object of CSS property/value pairs, optionally  including only the given keys.
        /// Keys can be passed into this method as individual arguments or separated by spaces within a string.
        /// </summary>
        /// <param name="keys"> (String) – A space-separated list of keys to include.</param>
        /// <returns></returns>
        public static object toCSS(params JsString[] keys) { return null; }
        //TODO: must check

        /// <summary>
        /// Converts the layout hash to an ordinary hash of key/value pairs, optionally including only the given keys.
        /// Keys can be passed into this method as individual arguments or separated by spaces within a string.
        /// </summary>
        /// <param name="keys"> (String) – A space-separated list of keys to include.</param>
        /// <returns></returns>
        public static Hash toHash(params JsString[] keys) { return null; }
        //TODO: must check

        /// <summary>
        ///Converts the layout hash to a plain object of key/value pairs, optionally including only the given keys.
        ///Keys can be passed into this method as individual arguments or separated by spaces within a string.
        /// </summary>
        /// <param name="keys"> (String) – A space-separated list of keys to include.</param>
        /// <returns></returns>
        public static object toObject(params JsString[] keys) { return null; }
        //TODO: must check

        public JsNumber height
        {
            [JsMethod(Name = "get", InsertArg0 = "'height'")]
            get;
            private set;
        }
        public JsNumber width
        {
            [JsMethod(Name = "get", InsertArg0 = "'width'")]
            get;
            private set;
        }
        public JsNumber top
        {
            [JsMethod(Name = "get", InsertArg0 = "'top'")]
            get;
            private set;
        }
        public JsNumber left
        {
            [JsMethod(Name = "get", InsertArg0 = "'left'")]
            get;
            private set;
        }
        public JsNumber right
        {
            [JsMethod(Name = "get", InsertArg0 = "'right'")]
            get;
            private set;
        }
        public JsNumber bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'bottom'")]
            get;
            private set;
        }
        public JsNumber border_left
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-left'")]
            get;
            private set;
        }
        public JsNumber border_right
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-right'")]
            get;
            private set;
        }
        public JsNumber border_top
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-top'")]
            get;
            private set;
        }
        public JsNumber border_bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-bottom'")]
            get;
            private set;
        }
        public JsNumber padding_left
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-left'")]
            get;
            private set;
        }
        public JsNumber padding_right
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-right'")]
            get;
            private set;
        }
        public JsNumber padding_top
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-top'")]
            get;
            private set;
        }
        public JsNumber padding_bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-bottom'")]
            get;
            private set;
        }
        public JsNumber margin_top
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-top'")]
            get;
            private set;
        }
        public JsNumber margin_bottom
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-bottom'")]
            get;
            private set;
        }
        public JsNumber margin_left
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-left'")]
            get;
            private set;
        }
        public JsNumber margin_right
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-right'")]
            get;
            private set;
        }

        //COMPOSITE_PROPERTIES:
        /// <summary>
        /// (width of the content area, from the beginning of the left padding to the end of the right padding)
        /// </summary>
        public JsNumber padding_box_width
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-box-width'")]
            get;
            private set;
        }
        /// <summary>
        /// (height of the content area, from the beginning of the top padding to the end of the bottom padding)
        /// </summary>
        public JsNumber padding_box_height
        {
            [JsMethod(Name = "get", InsertArg0 = "'padding-box-height'")]
            get;
            private set;
        }
        /// <summary>
        /// (width of the content area, from the outer edge of the left border to the outer edge of the right border)
        /// </summary>
        public JsNumber border_box_width
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-box-width'")]
            get;
            private set;
        }
        /// <summary>
        /// (height of the content area, from the outer edge of the top border to the outer edge of the bottom border)
        /// </summary>
        public JsNumber border_box_height
        {
            [JsMethod(Name = "get", InsertArg0 = "'border-box-height'")]
            get;
            private set;
        }
        /// <summary>
        /// (width of the content area, from the beginning of the left margin to the end of the right margin)
        /// </summary>
        public JsNumber margin_box_width
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-box-width'")]
            get;
            private set;
        }
        /// <summary>
        /// (height of the content area, from the beginning of the top margin to the end of the bottom margin)
        /// </summary>
        public JsNumber margin_box_height
        {
            [JsMethod(Name = "get", InsertArg0 = "'margin-box-height'")]
            get;
            private set;
        }

    }

    /// <summary>
    /// A representation of the top- and left-offsets of an element relative to another.
    /// All methods that compute offsets return an instance of Element.Offset.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Element.Offset", Export = false)]
    public class Offset
    {
        /// <summary>
        /// Instantiates an Element.Offset. You shouldn't need to call this directly.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public Offset(JsNumber left, JsNumber top) { }

        /// <summary>
        /// Returns a debug-friendly representation of the offset.
        /// </summary>
        /// <returns></returns>
        public static JsString inspect() { return null; }

        /// <summary>
        /// Returns a new Element.Offset with its origin at the given offset. Useful for determining an element's distance from another arbitrary element.
        /// </summary>
        /// <param name="offset"> (Element.Offset) – Another offset to compare to.</param>
        /// <returns></returns>
        public static Offset relativeTo(Offset offset) { return null; }

        /// <summary>
        /// Returns an array representation fo the offset in [x, y] format.
        /// </summary>
        /// <returns></returns>
        public static JsArray toArray() { return null; }

        public JsString toString { get; set; }
    }

    #endregion

    #region Event

    /// <summary>
    /// The namespace for Prototype's event system.
    /// Events: a fine mess:
    /// Event management is one of the really sore spots of cross-browser scripting.
    /// True, the prevalent issue is: everybody does it the W3C way, and MSIE does it another way altogether. But there are quite a few subtler, sneakier issues here and there waiting to bite your ankle — such as the keypress/keydown issue with KHTML-based browsers (Konqueror and Safari). Also, MSIE has a tendency to leak memory when it comes to discarding event handlers.
    /// Prototype to the rescue:
    /// Of course, Prototype smooths it over so well you'll forget these troubles even exist. Enter the Event namespace. It is replete with methods that help to normalize the information reported by events across browsers.
    /// Event also provides a standardized list of key codes you can use with keyboard-related events, including KEY_BACKSPACE, KEY_TAB, KEY_RETURN, KEY_ESC, KEY_LEFT, KEY_UP, KEY_RIGHT, KEY_DOWN, KEY_DELETE, KEY_HOME, KEY_END, KEY_PAGEUP, KEY_PAGEDOWN and KEY_INSERT.
    /// The functions you're most likely to use a lot are Event.observe, Event.element and Event.stop. If your web app uses custom events, you'll also get a lot of mileage out of Event.fire.
    /// Instance methods on event objects:
    /// As of Prototype 1.6, all methods on the Event object are now also available as instance methods on the event object itself:
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Event", Export = false)]
    public class Event
    {
        //TODO: Class methods

        /// <summary>
        /// Returns the DOM element on which the event occurred. This method is deprecated, use Event.findElement instead.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element element() { return null; }

        /// <summary>
        /// Extends event with all of the methods contained in Event.Methods.
        /// Note that all events inside handlers that were registered using Event.observe or Element.observe will be extended automatically.
        /// You need only call Event.extend manually if you register a handler a different way (e.g., the onclick attribute). We really can't encourage that sort of thing, though.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element extend() { return null; }

        /// <summary>
        /// Returns the first DOM element that matches a given CSS selector — starting with the element on which the event occurred,
        /// then moving up its ancestor chain. If expression is not given, the element which fired the event is returned.
        /// If no matching element is found, the document itself (HTMLDocument node) is returned.
        /// </summary>
        /// <param name="expression">(String) – An optional CSS selector</param>
        /// <returns></returns>
        public Element findElement(JsString expression) { return null; }
        /// <summary>
        /// Returns the first DOM element that matches a given CSS selector — starting with the element on which the event occurred,
        /// then moving up its ancestor chain. If expression is not given, the element which fired the event is returned.
        /// If no matching element is found, the document itself (HTMLDocument node) is returned.
        /// </summary>
        /// <returns></returns>
        public Element findElement() { return null; }

        /// <summary>
        /// Determines whether a button-related mouse event involved the left mouse button.
        /// Keep in mind that the "left" mouse button is actually the "primary" mouse button.
        /// When a mouse is in left-handed mode, the browser will report clicks of the right button as "left-clicks."
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public bool isLeftClick() { return false; }

        /// <summary>
        /// Determines whether a button-related mouse event involved the middle mouse button.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public bool isMiddleClick() { return false; }

        /// <summary>
        /// Determines whether a button-related mouse event involved the right mouse button.
        /// Keep in mind that the "left" mouse button is actually the "secondary" mouse button. When a mouse is in left-handed mode, the browser will report clicks of the left button as "left-clicks."\
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public bool isRightClick() { return false; }

        /// <summary>
        /// Returns the absolute position of the pointer for a mouse event.
        /// Returns an object in the form { x: Number, y: Number}.
        /// Note that this position is absolute on the page, not on the viewport.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public PointerConfig pointer() { return null; }

        /// <summary>
        /// Returns the absolute horizontal position of the pointer for a mouse event.
        /// Note that this position is absolute on the <body>, not on the viewport: scrolling right increases the returned value for events on the same viewport location.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsNumber pointerX() { return null; }

        /// <summary>
        /// Returns the absolute vertical position of the pointer for a mouse event.
        /// Note that this position is absolute on the <body>, not on the viewport: scrolling down increases the returned value for events on the same viewport location.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsNumber pointerY() { return null; }

        /// <summary>
        /// Stops the event's propagation and prevents its eventual default action from being triggered.
        /// Stopping an event also sets a stopped property on that event for future inspection.
        /// There are two aspects to how your browser handles an event once it fires up:
        /// The browser usually triggers event handlers on the actual element the event occurred on,
        /// then on its parent element, and so on and so forth, until the document's root element is reached. This is called event bubbling,
        /// and is the most common form of event propagation. You may very well want to stop this propagation when you just handled an event,
        /// and don't want it to keep bubbling up (or see no need for it).
        /// Once your code had a chance to process the event, the browser handles it as well, if that event has a default behavior.
        /// For instance, clicking on links navigates to them; submitting forms sends them over to the server side;
        /// hitting the Return key in a single-line form field submits it; etc. You may very well want to prevent this default behavior if you do your own handling.
        /// Because stopping one of those aspects means, in 99.9% of the cases, preventing the other one as well, Prototype bundles both in this stop function.
        /// Calling it on an event object, stops propagation and prevents the default behavior.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        public void stop() { }
    }

    [JsType(JsMode.Json)]
    public class PointerConfig
    {
        public JsNumber y { get; set; }

        public JsNumber x { get; set; }
    }

    /// <summary>
    /// Creates an observer on an element that listens for a particular event on that element's descendants, optionally filtering by a CSS selector.
    /// This class simplifies the common "event delegation" pattern, in which one avoids adding an observer to a number of individual elements and instead listens on a common ancestor element.
    /// For more information on usage, see Event.on.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Event.Handler", Export = false)]
    public class Handler
    {
        /// <summary>
        /// Instantiates an Event.Handler. Will not begin observing until Event.Handler#start is called.
        /// </summary>
        /// <param name="element">(Element) – The element to listen on.</param>
        /// <param name="eventName">(String) – An event to listen for. Can be a standard browser event or a custom event.</param>
        /// <param name="selector">(String) – A CSS selector. If specified, will call callback only when it can find an element
        /// that matches selector somewhere in the ancestor chain between the event's target element and the given element.</param>
        /// <param name="callback"> (Function) – The event handler function. Should expect two arguments: the event object and the element that received the event.
        /// (If selector was given, this element will be the one that satisfies the criteria described just above; if not, it will be the one specified in the element argument).</param>
        public Handler(Element element, JsString eventName, JsString selector, JsAction callback) { }
        /// <summary>
        /// Instantiates an Event.Handler. Will not begin observing until Event.Handler#start is called.
        /// </summary>
        /// <param name="element">(Element) – The element to listen on.</param>
        /// <param name="eventName">(String) – An event to listen for. Can be a standard browser event or a custom event.</param>
        /// <param name="selector">(String) – A CSS selector. If specified, will call callback only when it can find an element
        /// that matches selector somewhere in the ancestor chain between the event's target element and the given element.</param>
        public Handler(Element element, JsString eventName, JsString selector) { }
        /// <summary>
        /// Instantiates an Event.Handler. Will not begin observing until Event.Handler#start is called.
        /// </summary>
        /// <param name="element">(Element) – The element to listen on.</param>
        /// <param name="eventName">(String) – An event to listen for. Can be a standard browser event or a custom event.</param>
        public Handler(Element element, JsString eventName) { }

        /// <summary>
        /// Starts listening for events. Returns itself.
        /// </summary>
        public Handler start { get; set; }
        //TODO: seems wird that it is a propertye...

        /// <summary>
        /// Stops listening for events. Returns itself.
        /// </summary>
        public Handler stop { get; set; }
        //TODO: seems wird that it is a propertye...

    }

    #endregion

    /// <summary>
    /// A class that queries the document for elements that match a given CSS selector.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Selector", Export = false)]
    public class DOMSelector
    {
        /// <summary>
        /// Creates a Selector with the given CSS selector.
        /// </summary>
        /// <param name="expression">(String) – A CSS selector.</param>
        public DOMSelector(JsString expression) { }

        //TODO: class methodes

        /// <summary>
        /// Searches the document for elements that match the instance's CSS selector.
        /// </summary>
        /// <param name="root">(Element | document) – A "scope" to search within. All results will be descendants of this node.</param>
        /// <returns></returns>
        public JsArray<Element> findElements(HtmlElement root) { return null; }
        /// <summary>
        /// Searches the document for elements that match the instance's CSS selector.
        /// </summary>
        /// <param name="root">(Element | document) – A "scope" to search within. All results will be descendants of this node.</param>
        /// <returns></returns>
        public JsArray<Element> findElements(HtmlDocument root) { return null; }

        /// <summary>
        /// Tests whether a element matches the instance's CSS selector.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool match(HtmlElement element) { return false; }
    }
    //TODO: class name is Selector
    #endregion

    #region Language


    /// <summary>
    /// Extensions to the built-in String class.
    /// Prototype enhances the String object with a series of useful methods for ranging from the trivial to the complex.
    /// Tired of stripping trailing whitespace? Try String#strip. Want to replace replace? Have a look at String#sub and String#gsub.
    /// Need to parse a query string? We have what you need.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "JsStringExtensions", Export = false)]
    public static class JsStringExtensions
    {

        //TODO: Class methods

        /// <summary>
        /// Check if the string is "blank" — either empty (length of 0) or containing only whitespace.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static bool blank(this JsString s) { return false; }

        /// <summary>
        /// Converts a string separated by dashes into a camelCase equivalent. For instance, 'foo-bar' would be converted to 'fooBar'.
        /// Prototype uses this internally for translating CSS properties into their DOM style property equivalents.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString camelize(this JsString s) { return null; }

        /// <summary>
        /// Capitalizes the first letter of a string and downcases all the others.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString capitalize(this JsString s) { return null; }

        /// <summary>
        /// Replaces every instance of the underscore character "_" by a dash "-".
        /// Note: Used in conjunction with String#underscore, String#dasherize converts a DOM style into its CSS equivalent.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString dasherize(this JsString s) { return null; }

        /// <summary>
        /// Checks if the string is empty.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static bool empty(this JsString s) { return false; }

        /// <summary>
        /// Checks if the string ends with substring.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString endsWith(this JsString s) { return null; }

        /// <summary>
        /// Converts HTML special characters to their entity equivalents.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString escapeHTML(this JsString s) { return null; }

        /// <summary>
        /// Evaluates the JSON in the string and returns the resulting object.
        /// If the optional sanitize parameter is set to true, the string is checked for possible malicious attempts; if one is detected, eval is not called.
        /// Warning:
        /// If the JSON string is not well formated or if a malicious attempt is detected a SyntaxError is thrown.
        /// Note:
        /// Always set the sanitize parameter to true for data coming from externals sources to prevent XSS attacks.
        /// As String#evalJSON internally calls String#unfilterJSON, optional security comment delimiters (defined in Prototype.JSONFilter) are automatically removed.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="sanitize"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object evalJSON(this JsString s, bool sanitize) { return null; }
        /// <summary>
        /// Evaluates the JSON in the string and returns the resulting object.
        /// If the optional sanitize parameter is set to true, the string is checked for possible malicious attempts; if one is detected, eval is not called.
        /// Warning:
        /// If the JSON string is not well formated or if a malicious attempt is detected a SyntaxError is thrown.
        /// Note:
        /// Always set the sanitize parameter to true for data coming from externals sources to prevent XSS attacks.
        /// As String#evalJSON internally calls String#unfilterJSON, optional security comment delimiters (defined in Prototype.JSONFilter) are automatically removed.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object evalJSON(this JsString s) { return null; }

        /// <summary>
        /// Evaluates the content of any inline &lt;script> block present in the string.
        /// Returns an array containing the value returned by each script. &lt;script> blocks referencing external files will be treated as though they were empty
        /// (the result for that position in the array will be undefined);
        /// external files are not loaded and processed by String#evalScripts.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray evalScripts(this JsString s) { return null; }

        /// <summary>
        /// Extracts the content of any &lt;script> blocks present in the string and returns them as an array of strings.
        /// This method is used internally by String#evalScripts. It does not evaluate the scripts (use String#evalScripts to do that),
        /// but can be usefull if you need to evaluate the scripts at a later date.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray extractScripts(this JsString s) { return null; }

        /// <summary>
        /// Returns the string with every occurence of a given pattern replaced by either a regular string, the returned value of a function or a Template string.
        /// The pattern can be a string or a regular expression.
        /// If its second argument is a string String#gsub works just like the native JavaScript method replace() set to global match.
        /// If you pass it a function, it will be invoked for every occurrence of the pattern with the match of the current pattern as its unique argument.
        /// Note that this argument is the returned value of the match() method called on the current pattern.
        /// It is in the form of an array where the first element is the entire match and every subsequent one corresponds to a parenthesis group in the regex.
        /// Lastly, you can pass String#gsub a Template string in which you can also access the returned value of the match() method using the ruby inspired notation:
        /// #{0} for the first element of the array, #{1} for the second one, and so on. So our last example could be easily re-written as:
        /// If you need an equivalent to String#gsub but without global match set on, try String#sub.
        /// Note: Do not use the "g" flag on the regex as this will create an infinite loop.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString gsub(this JsString s, JsString pattern, JsFunc<JsString> replacement) { return null; }
        /// <summary>
        /// Returns the string with every occurence of a given pattern replaced by either a regular string, the returned value of a function or a Template string.
        /// The pattern can be a string or a regular expression.
        /// If its second argument is a string String#gsub works just like the native JavaScript method replace() set to global match.
        /// If you pass it a function, it will be invoked for every occurrence of the pattern with the match of the current pattern as its unique argument.
        /// Note that this argument is the returned value of the match() method called on the current pattern.
        /// It is in the form of an array where the first element is the entire match and every subsequent one corresponds to a parenthesis group in the regex.
        /// Lastly, you can pass String#gsub a Template string in which you can also access the returned value of the match() method using the ruby inspired notation:
        /// #{0} for the first element of the array, #{1} for the second one, and so on. So our last example could be easily re-written as:
        /// If you need an equivalent to String#gsub but without global match set on, try String#sub.
        /// Note: Do not use the "g" flag on the regex as this will create an infinite loop.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString gsub(this JsString s, JsString pattern, JsString replacement) { return null; }
        /// <summary>
        /// Returns the string with every occurence of a given pattern replaced by either a regular string, the returned value of a function or a Template string.
        /// The pattern can be a string or a regular expression.
        /// If its second argument is a string String#gsub works just like the native JavaScript method replace() set to global match.
        /// If you pass it a function, it will be invoked for every occurrence of the pattern with the match of the current pattern as its unique argument.
        /// Note that this argument is the returned value of the match() method called on the current pattern.
        /// It is in the form of an array where the first element is the entire match and every subsequent one corresponds to a parenthesis group in the regex.
        /// Lastly, you can pass String#gsub a Template string in which you can also access the returned value of the match() method using the ruby inspired notation:
        /// #{0} for the first element of the array, #{1} for the second one, and so on. So our last example could be easily re-written as:
        /// If you need an equivalent to String#gsub but without global match set on, try String#sub.
        /// Note: Do not use the "g" flag on the regex as this will create an infinite loop.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString gsub(this JsString s, JsString pattern, Template replacement) { return null; }

        /// <summary>
        /// Checks if the string contains substring.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static bool include(this JsString s, JsString substring) { return false; }

        /// <summary>
        /// Returns a debug-oriented version of the string (i.e. wrapped in single or double quotes, with backslashes and quotes escaped).
        /// For more information on inspect methods, see Object.inspect.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="useDoubleQuotes"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString inspect(this JsString s, bool useDoubleQuotes) { return null; }
        /// <summary>
        /// Returns a debug-oriented version of the string (i.e. wrapped in single or double quotes, with backslashes and quotes escaped).
        /// For more information on inspect methods, see Object.inspect.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString inspect(this JsString s) { return null; }

        /// <summary>
        /// Treats the string as a Template and fills it with object's properties.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="object"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString interpolate(this JsString s, object @object, JsString pattern) { return null; }
        /// <summary>
        /// Treats the string as a Template and fills it with object's properties.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="object"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString interpolate(this JsString s, object @object) { return null; }

        /// <summary>
        /// Check if the string is valid JSON by the use of regular expressions. This security method is called internally.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static bool isJSON(this JsString s) { return false; }

        /// <summary>
        /// Aliased as: String#toQueryParams:
        /// Parses a URI-like query string and returns an object composed of parameter/value pairs.
        /// This method is realy targeted at parsing query strings (hence the default value of"&" for the separator argument).
        /// For this reason, it does not consider anything that is either before a question mark (which signals the beginning of a query string)
        /// or beyond the hash symbol ("#"), and runs decodeURIComponent() on each parameter/value pair.
        /// String#toQueryParams also aggregates the values of identical keys into an array of values.
        /// Note that parameters which do not have a specified value will be set to undefined.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object parseQuery(this JsString s, JsString separator) { return null; }

        /// <summary>
        /// Allows iterating over every occurrence of the given pattern (which can be a string or a regular expression). Returns the original string.
        /// Internally just calls String#gsub passing it pattern and iterator as arguments.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString scan(this JsString s, JsString pattern, JsAction<JsRegExpResult> iterator) { return null; }
        /// <summary>
        /// Allows iterating over every occurrence of the given pattern (which can be a string or a regular expression). Returns the original string.
        /// Internally just calls String#gsub passing it pattern and iterator as arguments.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="iterator"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString scan(this JsString s, JsRegExp pattern, JsAction<JsRegExpResult> iterator) { return null; }

        /// <summary>
        /// Checks if the string starts with substring.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="substring"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static bool startsWith(this JsString s, JsString substring) { return false; }

        /// <summary>
        /// Strips all leading and trailing whitespace from a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString strip(this JsString s) { return null; }

        /// <summary>
        /// Strips a string of things that look like an HTML script blocks.
        /// Note that the processing String#stripScripts does is good enough for most purposes, but you cannot rely on it for security purposes.
        /// If you're processing end-user-supplied content, String#stripScripts is probably not sufficiently robust to prevent hack attacks.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///&quot;&lt;p&gt;This is a test.&lt;script&gt;alert(&quot;Look, a test!&quot;);&lt;/script&gt;End of test&lt;/p&gt;&quot;.stripScripts();
        /// // =&gt; &quot;&lt;p&gt;This is a test.End of test&lt;/p&gt;&quot;
        ///</code>
        ///</example>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString stripScripts(this JsString s) { return null; }

        /// <summary>
        /// Strips a string of any HTML tags.
        /// Note that String#stripTags will only strip HTML 4.01 tags — like div, span, and abbr. It will not strip namespace-prefixed tags such as h:table or xsl:template.
        /// Watch out for &lt;script> tags in your string, as String#stripTags will not remove their content. Use String#stripScripts to do so.
        /// Caveat User:
        /// Note that the processing String#stripTags does is good enough for most purposes, but you cannot rely on it for security purposes.
        /// If you're processing end-user-supplied content, String#stripTags is not sufficiently robust to ensure that the content is completely
        /// devoid of HTML tags in the case of a user intentionally trying to circumvent tag restrictions.
        /// But then, you'll be running them through String#escapeHTML anyway, won't you?
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///&#39;a &lt;a href=&quot;#&quot;&gt;link&lt;/a&gt;&#39;.stripTags();
        ///  // -&gt; &#39;a link&#39;
        ///  &#39;a &lt;a href=&quot;#&quot;&gt;link&lt;/a&gt;&lt;script&gt;alert(&quot;hello world!&quot;);&lt;/script&gt;&#39;.stripTags();
        /// // -&gt; &#39;a linkalert(&quot;hello world!&quot;);&#39;
        ///  &#39;a &lt;a href=&quot;#&quot;&gt;link&lt;/a&gt;&lt;script&gt;alert(&quot;hello world!&quot;);&lt;/script&gt;&#39;.stripScripts().stripTags();
        /// // -&gt; &#39;a link&#39;
        ///</code>
        ///</example>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString stripTags(this JsString s) { return null; }

        /// <summary>
        /// Returns a string with the first count occurrences of pattern replaced by either a regular string, the returned value of a function or a Template string.
        /// pattern can be a string or a regular expression.
        /// Unlike String#gsub, String#sub takes a third optional parameter which specifies the number of occurrences of the pattern which will be replaced.
        /// If not specified, it will default to 1.
        /// Apart from that, String#sub works just like String#gsub. Please refer to it for a complete explanation.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString sub(this JsString s, JsString pattern, object replacement, JsNumber count) { return null; }
        /// <summary>
        /// Returns a string with the first count occurrences of pattern replaced by either a regular string, the returned value of a function or a Template string.
        /// pattern can be a string or a regular expression.
        /// Unlike String#gsub, String#sub takes a third optional parameter which specifies the number of occurrences of the pattern which will be replaced.
        /// If not specified, it will default to 1.
        /// Apart from that, String#sub works just like String#gsub. Please refer to it for a complete explanation.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString sub(this JsString s, JsRegExp pattern, object replacement, JsNumber count) { return null; }

        /// <summary>
        /// Used internally by ObjectRange.
        /// Converts the last character of the string to the following character in the Unicode alphabet.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString succ(this JsString s) { return null; }

        /// <summary>
        /// Concatenates the string count times.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString times(this JsString s, JsNumber count) { return null; }

        /// <summary>
        /// Splits the string character-by-character and returns an array with the result.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray toArray(this JsString s) { return null; }

        /// <summary>
        /// Parses a URI-like query string and returns an object composed of parameter/value pairs.
        /// This method is realy targeted at parsing query strings (hence the default value of"&" for the separator argument).
        /// For this reason, it does not consider anything that is either before a question mark (which signals the beginning of a query string) or beyond the hash symbol ("#"),
        /// and runs decodeURIComponent() on each parameter/value pair.
        /// String#toQueryParams also aggregates the values of identical keys into an array of values.
        /// Note that parameters which do not have a specified value will be set to undefined.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object toQueryParams(this JsString s, JsString separator) { return null; }
        /// <summary>
        /// Parses a URI-like query string and returns an object composed of parameter/value pairs.
        /// This method is realy targeted at parsing query strings (hence the default value of"&" for the separator argument).
        /// For this reason, it does not consider anything that is either before a question mark (which signals the beginning of a query string) or beyond the hash symbol ("#"),
        /// and runs decodeURIComponent() on each parameter/value pair.
        /// String#toQueryParams also aggregates the values of identical keys into an array of values.
        /// Note that parameters which do not have a specified value will be set to undefined.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object toQueryParams(this JsString s) { return null; }

        /// <summary>
        /// Truncates a string to given length and appends suffix to it (indicating that it is only an excerpt).
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString truncate(this JsString s, JsNumber length, JsString suffix) { return null; }
        /// <summary>
        /// Truncates a string to given length and appends suffix to it (indicating that it is only an excerpt).
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString truncate(this JsString s, JsNumber length) { return null; }
        /// <summary>
        /// Truncates a string to given length and appends suffix to it (indicating that it is only an excerpt).
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString truncate(this JsString s) { return null; }

        /// <summary>
        /// Converts a camelized string into a series of words separated by an underscore (_).
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString underscore(this JsString s) { return null; }

        /// <summary>
        /// Strips tags and converts the entity forms of special HTML characters to their normal form.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString unescapeHTML(this JsString s) { return null; }

        /// <summary>
        /// Strips comment delimiters around Ajax JSON or JavaScript responses. This security method is called internally.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString unfilterJSON(this JsString s, object filter) { return null; }
    }

    /// <summary>
    /// Prototype extends all native JavaScript arrays with quite a few powerful methods.
    /// This is done in two ways:
    /// It mixes in the Enumerable module, which brings in a ton of methods.
    /// It adds quite a few extra methods, which are documented in this section.
    /// With Prototype, arrays become much, much more than the trivial objects we used to manipulate,
    /// limiting ourselves to using their length property and their [] indexing operator.
    /// They become very powerful objects that greatly simplify the code for 99% of the common use cases involving them.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "JsArrayExtensions", Export = false)]
    public static class JsArrayExtensions
    {

        //TODO: Class methods

        /// <summary>
        /// Clears the array (makes it empty) and returns the array reference.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray clear(this JsArray a) { return null; }

        /// <summary>
        /// Returns a duplicate of the array, leaving the original array intact.
        /// Aliased as: Array#toArray
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray clone(this JsArray a) { return null; }

        /// <summary>
        /// Returns a copy of the array without any null or undefined values.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray compact(this JsArray a) { return null; }

        /// <summary>
        /// Returns the array's first item (e.g., array[0]).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object first(this JsArray a) { return null; }

        /// <summary>
        /// Returns a flattened (one-dimensional) copy of the array, leaving the original array unchanged.
        /// Nested arrays are recursively injected inline. This can prove very useful when handling the results of a recursive collection algorithm, for instance.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray flatten(this JsArray a) { return null; }

        /// <summary>
        /// Returns the index of the first occurrence of item within the array, or -1 if item doesn't exist in the array. Array#indexOf compares items using strict equality (===).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="item">(?) – A value that may or may not be in the array.</param>
        /// <param name="offset">(Number) – The number of initial items to skip before beginning the search.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber indexOf(this JsArray a, object item, JsNumber offset) { return null; }
        /// <summary>
        /// Returns the index of the first occurrence of item within the array, or -1 if item doesn't exist in the array. Array#indexOf compares items using strict equality (===).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="item">(?) – A value that may or may not be in the array.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber indexOf(this JsArray a, object item) { return null; }

        /// <summary>
        /// Returns the debug-oriented string representation of an array.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString inspect(this JsArray a) { return null; }

        /// <summary>
        /// Returns an array containing every item that is shared between the two given arrays.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="array">(Array) – A collection of values.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray intersect(this JsArray a, JsArray array) { return null; }
        //TODO: check

        /// <summary>
        /// Returns the array's last item (e.g., array[array.length - 1]).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static object last(this JsArray a) { return null; }

        /// <summary>
        /// Returns the position of the last occurrence of item within the array — or -1 if item doesn't exist in the array.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="item">(?) – A value that may or may not be in the array.</param>
        /// <param name="offset"> (Number) – The number of items at the end to skip before beginning the search.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber lastIndexOf(this JsArray a, object item, JsNumber offset) { return null; }
        /// <summary>
        /// Returns the position of the last occurrence of item within the array — or -1 if item doesn't exist in the array.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="item">(?) – A value that may or may not be in the array.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber lastIndexOf(this JsArray a, object item) { return null; }

        /// <summary>
        /// Reverses the array's contents, optionally cloning it first.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="inline"> (Boolean) – Whether to modify the array in place. Defaults to true. Clones the original array when false.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray reverse(this JsArray a, bool inline) { return null; }
        /// <summary>
        /// Reverses the array's contents, optionally cloning it first.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray reverse(this JsArray a) { return null; }

        /// <summary>
        /// Returns the size of the array (e.g., array.length).
        /// This is just a local optimization of the mixed-in Enumerable#size which avoids array cloning and uses the array's native length property.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber size(this JsArray a) { return null; }

        /// <summary>
        /// Alias of: Array#clone
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray toArray(this JsArray a) { return null; }

        /// <summary>
        /// Produces a duplicate-free version of an array. If no duplicates are found, the original array is returned.
        /// On large arrays when sorted is false, this method has a potentially large performance cost.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="sorted"> (Boolean) – Whether the array has already been sorted. If true, a less-costly algorithm will be used.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray uniq(this JsArray a, bool sorted) { return null; }
        /// <summary>
        /// Produces a duplicate-free version of an array. If no duplicates are found, the original array is returned.
        /// On large arrays when sorted is false, this method has a potentially large performance cost.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray uniq(this JsArray a) { return null; }

        /// <summary>
        /// Produces a new version of the array that does not contain any of the specified values, leaving the original array unchanged.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="value"> (?) – A value to exclude.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray<T> without<T>(this JsArray<T> a, params T[] value) { return null; }
        /// <summary>
        /// Produces a new version of the array that does not contain any of the specified values, leaving the original array unchanged.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="value"> (?) – A value to exclude.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsArray<T> without<T>(this JsArray<T> a, T value) { return null; }


        //TODO: Includes: Enumerable

    }

    /// <summary>
    /// Extensions to the built-in Date object.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "JsDateExtensions", Export = false)]
    public static class JsDateExtensions
    {
        /// <summary>
        /// Produces a string representation of the date in ISO 8601 format. The time zone is always UTC, as denoted by the suffix "Z".
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString toISOString(this JsDate d) { return null; }

        /// <summary>
        /// Internally calls Date#toISOString.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString toJSON(this JsDate d) { return null; }

    }

    /// <summary>
    /// Enumerable provides a large set of useful methods for enumerations — objects that act as collections of values. It is a cornerstone of Prototype.
    /// Enumerable is a mixin: a set of methods intended not for standaone use, but for incorporation into other objects.
    /// Prototype mixes Enumerable into several classes. The most visible cases are Array and Hash,
    /// but you'll find it in less obvious spots as well, such as in ObjectRange and various DOM- or Ajax-related objects.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsType(JsMode.Prototype, Export = false)]
    public class Enumerable<T>
    {
        /// <summary>
        /// Determines whether all the elements are "truthy" (boolean-equivalent to true), either directly or through computation by the provided iterator.
        /// Stops on the first falsy element found (e.g., the first element that is boolean-equivalent to false, such as undefined, 0, or indeed false);
        /// </summary>
        /// <param name="iterator">iterator (Function) – An optional function to use to evaluate each element in the enumeration;
        /// the function should return the value to test. If this is not provided, the element itself is tested.
        /// context (Object) – An optional object to use as this within calls to the iterator.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///[].all();
        /// // -> true (empty arrays have no elements that could be falsy)
        ///  $R(1, 5).all();
        /// // -> true (all values in [1..5] are truthy)
        ///  [0, 1, 2].all();
        /// // -> false (with only one loop cycle: 0 is falsy)
        ///  [9, 10, 15].all(function(n) { return n >= 10; });
        /// // -> false (the iterator returns false on 9)
        ///</code>
        ///</example>
        public bool all<R>(JsFunc<T, R> iterator) { return false; }
        //TODO: must check.
        /// <summary>
        /// Determines whether all the elements are "truthy" (boolean-equivalent to true), either directly or through computation by the provided iterator.
        /// Stops on the first falsy element found (e.g., the first element that is boolean-equivalent to false, such as undefined, 0, or indeed false);
        /// </summary>
        /// <param name="iterator">iterator (Function) – An optional function to use to evaluate each element in the enumeration;
        /// the function should return the value to test. If this is not provided, the element itself is tested.
        /// context (Object) – An optional object to use as this within calls to the iterator.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///[].all();
        /// // -> true (empty arrays have no elements that could be falsy)
        ///  $R(1, 5).all();
        /// // -> true (all values in [1..5] are truthy)
        ///  [0, 1, 2].all();
        /// // -> false (with only one loop cycle: 0 is falsy)
        ///  [9, 10, 15].all(function(n) { return n >= 10; });
        /// // -> false (the iterator returns false on 9)
        ///</code>
        ///</example>
        public bool all(JsFunc<T> iterator) { return false; }
        //TODO: must check.
        /// <summary>
        /// Determines whether all the elements are "truthy" (boolean-equivalent to true), either directly or through computation by the provided iterator.
        /// Stops on the first falsy element found (e.g., the first element that is boolean-equivalent to false, such as undefined, 0, or indeed false);
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///[].all();
        /// // -> true (empty arrays have no elements that could be falsy)
        ///  $R(1, 5).all();
        /// // -> true (all values in [1..5] are truthy)
        ///  [0, 1, 2].all();
        /// // -> false (with only one loop cycle: 0 is falsy)
        ///  [9, 10, 15].all(function(n) { return n >= 10; });
        /// // -> false (the iterator returns false on 9)
        ///</code>
        ///</example>
        public bool all() { return false; }
        //TODO: must check.

        //TODO: finish the class with Danel: http://api.prototypejs.org/language/Enumerable/
    }

    //TODO: FunctionExtensions 

    /// <summary>
    /// A set of key/value pairs.
    /// Hash can be thought of as an associative array, binding unique keys to values (which are not necessarily unique),
    /// though it can not guarantee consistent order its elements when iterating. Because of the nature of JavaScript, every object is in fact a hash;
    /// but Hash adds a number of methods that let you enumerate keys and values, iterate over key/value pairs, merge two hashes together, and much more.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Hash", Export = false)]
    public class Hash
    {

        //TODO: Includes: Enumerable

        /// <summary>
        /// Creates a new Hash. If object is given, the new hash will be populated with all the object's properties. See $H.
        /// </summary>
        /// <param name="object"></param>
        public Hash(object @object) { }
        /// <summary>
        /// Creates a new Hash. If object is given, the new hash will be populated with all the object's properties. See $H.
        /// </summary>
        public Hash() { }

        /// <summary>
        /// Returns a clone of this Hash.
        /// </summary>
        /// <returns></returns>
        public Hash clone() { return null; }

        //TODO: each http://api.prototypejs.org/language/Hash/prototype/each/

        /// <summary>
        /// Returns the stored value for the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object get(JsString key) { return null; }

        /// <summary>
        /// Returns the first key in the hash whose value matches value. Returns false if there is no such key.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public JsString index(object value) { return null; }

        /// <summary>
        /// Returns the debug-oriented string representation of the Hash.
        /// </summary>
        /// <returns></returns>
        public JsString inspect() { return null; }

        /// <summary>
        /// Provides an Array containing the keys for items stored in the hash.
        /// The order of the keys is not guaranteed.
        /// </summary>
        /// <returns></returns>
        public JsArray<JsString> keys() { return null; }

        /// <summary>
        /// Returns a new Hash instance with object's key/value pairs merged in; this hash remains unchanged.
        /// To modify the original hash in place, use Hash#update.
        /// </summary>
        /// <param name="object">(Object | Hash) – The object to merge with this hash to produce the resulting hash.</param>
        /// <returns></returns>
        public Hash merge(object @object) { return null; }
        /// <summary>
        /// Returns a new Hash instance with object's key/value pairs merged in; this hash remains unchanged.
        /// To modify the original hash in place, use Hash#update.
        /// </summary>
        /// <param name="object">(Object | Hash) – The object to merge with this hash to produce the resulting hash.</param>
        /// <returns></returns>
        public Hash merge(Hash @object) { return null; }

        /// <summary>
        /// Stores value in the hash using the key key and returns value.
        /// </summary>
        /// <param name="key">(String) – The key to use for this value.</param>
        /// <param name="value"> (?) – The value to use for this key.</param>
        /// <returns></returns>
        public object set(JsString key, object value) { return null; }

        /// <summary>
        /// Alias of: Hash#toObject
        /// </summary>
        /// <returns></returns>
        public object toJSON() { return null; }

        /// <summary>
        /// Returns a cloned, vanilla object whose properties (and property values) match the keys (and values) from the hash.
        /// </summary>
        /// <returns></returns>
        public object toObject() { return null; }

        /// <summary>
        /// Returns a URL-encoded string containing the hash's contents as query parameters according to the following rules:
        /// An undefined value results a parameter with no value portion at all (simply the key name, no equal sign).
        /// A null value results a parameter with a blank value (the key followed by an equal sign and nothing else).
        /// A boolean value results a parameter with the value "true" or "false".
        /// An Array value results in a parameter for each array element, in array order, each using the same key.
        /// All keys and values are URI-encoded using JavaScript's native encodeURIComponent function.
        /// The order of pairs in the string is not guaranteed, other than the order of array values described above.
        /// </summary>
        /// <returns></returns>
        public JsString toQueryString() { return null; }

        /// <summary>
        /// Alias of: Hash#toObject
        /// </summary>
        /// <returns></returns>
        public object toTemplateReplacements() { return null; }

        /// <summary>
        /// Deletes the stored pair for the given key from the hash and returns its value.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object unset(JsString key) { return null; }

        /// <summary>
        /// Updates a hash in place with the key/value pairs of object, returns the hash.
        /// Hash#update modifies the hash. To get a new hash instead, use Hash#merge.
        /// </summary>
        /// <param name="object"> (Object | Hash) – The object to merge with this hash to produce the resulting hash.</param>
        /// <returns></returns>
        public Hash update(object @object) { return null; }

        /// <summary>
        /// Collects the values of the hash and returns them in an array.
        /// The order of the values is not guaranteed.
        /// </summary>
        /// <returns></returns>
        public JsArray values() { return null; }
    }

    /// <summary>
    /// Extensions to the built-in Number object.
    /// Prototype extends native JavaScript numbers in order to provide:
    /// ObjectRange compatibility, through Number#succ.
    /// Numerical loops with Number#times.
    /// Simple utility methods such as Number#toColorPart and Number#toPaddedString.
    /// Instance-method aliases of many functions in the Math namespace.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "JsNumberExtensions", Export = false)]
    public static class JsNumberExtensions
    {
        /// <summary>
        /// Returns the absolute value of the number. Convenience method that simply calls Math.abs on this instance and returns the result.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber abs(this JsNumber n) { return null; }

        /// <summary>
        /// Returns the smallest integer greater than or equal to the number. Convenience method that simply calls Math.ceil on this instance and returns the result.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber ceil(this JsNumber n) { return null; }

        /// <summary>
        /// Returns the largest integer less than or equal to the number. Convenience method that simply calls Math.floor on this instance and returns the result.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber floor(this JsNumber n) { return null; }

        /// <summary>
        /// Rounds the number to the nearest integer. Convenience method that simply calls Math.round on this instance and returns the result.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber round(this JsNumber n) { return null; }

        /// <summary>
        /// Returns the successor of the current Number, as defined by current + 1. Used to make numbers compatible with ObjectRange.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber succ(this JsNumber n) { return null; }

        /// <summary>
        /// Calls iterator the specified number of times, passing in a number as the first parameter.
        /// The number will be 0 on first call, 1 on second call, etc. times returns the number instance it was called on.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="iterator"> (Function) – An iterator function to call.</param>
        /// <param name="context">(Object) – An optional context (this value) to use when calling iterator.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber times(this JsNumber n, JsAction iterator, object context) { return null; }
        /// <summary>
        /// Calls iterator the specified number of times, passing in a number as the first parameter.
        /// The number will be 0 on first call, 1 on second call, etc. times returns the number instance it was called on.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="iterator"> (Function) – An iterator function to call.</param>
        /// <param name="context">(Object) – An optional context (this value) to use when calling iterator.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsNumber times(this JsNumber n, JsAction iterator) { return null; }

        /// <summary>
        /// Produces a 2-digit hexadecimal representation of the number (which is therefore assumed to be in the [0..255] range, inclusive). Useful for composing CSS color strings.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString toColorPart(this JsNumber n) { return null; }

        /// <summary>
        /// Returns a string representation of the number padded with leading 0s so that the string's length is at least equal to length.
        /// Takes an optional radix argument which specifies the base to use for conversion.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="length">(Number) – The minimum length for the resulting string.</param>
        /// <param name="radix"> (Number) – An optional radix for the string representation, defaults to 10 (decimal).</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString toPaddedString(this JsNumber n, JsNumber length, JsNumber radix) { return null; }
        /// <summary>
        /// Returns a string representation of the number padded with leading 0s so that the string's length is at least equal to length.
        /// Takes an optional radix argument which specifies the base to use for conversion.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="length">(Number) – The minimum length for the resulting string.</param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static JsString toPaddedString(this JsNumber n, JsNumber length) { return null; }

    }

    /// <summary>
    /// Extensions to the built-in Object object.
    /// Because it is dangerous and invasive to augment Object.prototype (i.e., add instance methods to objects),
    /// all these methods are static methods that take an Object as their first parameter.
    /// Object is used by Prototype as a namespace; that is, it just keeps a few new methods together,
    /// which are intended for namespaced access (i.e. starting with "Object.").
    /// For the regular developer (who simply uses Prototype without tweaking it),
    /// the most commonly used methods are probably Object.inspect and, to a lesser degree, Object.clone.
    /// Advanced users, who wish to create their own objects like Prototype does, or explore objects as if they were hashes,
    /// will turn to Object.extend, Object.keys, and Object.values.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "ObjectExtensions", Export = false)]
    public static class ObjectExtensions
    {
        //TODO: Class methods
    }

    /// <summary>
    /// A succession of values.
    /// An ObjectRange can model a range of any value that implements a succ method (which links that value to its "successor").
    /// Prototype provides such a method for Number and String, but you are (of course) welcome to implement useful semantics in your own objects,
    /// in order to enable ranges based on them.
    /// ObjectRange mixes in Enumerable, which makes ranges very versatile. It takes care, however, to override the default code for include, to achieve better efficiency.
    /// While ObjectRange does provide a constructor, the preferred way to obtain a range is to use the $R utility function, which is strictly equivalent (only way more concise to use).
    /// See $R for more information.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "ObjectRange", Export = false)]
    public class ObjectRange
    {
        /// <summary>
        /// Creates a new ObjectRange.
        /// The exclusive argument specifies whether end itself is a part of the range.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="exclusive"></param>
        public ObjectRange(object start, object end, bool exclusive) { }
        //TODO: start, end type?
        /// <summary>
        /// Creates a new ObjectRange.
        /// The exclusive argument specifies whether end itself is a part of the range.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public ObjectRange(object start, object end) { }
        //TODO: start, end type?

        /// <summary>
        /// Determines whether the value is included in the range.
        /// This assumes the values in the range have a valid strict weak ordering (have valid semantics for the &lt; operator).
        /// While ObjectRange mixes in Enumerable, this method overrides the default version of Enumerable#include, and is much more efficient (it uses a maximum of two comparisons).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool include(object value) { return false; }

        /// <summary>
        /// The upper bounding value of the range.
        /// </summary>
        public object end { get; set; }
        //TODO: ?

        /// <summary>
        /// The lower bounding value of the range.
        /// </summary>
        public object start { get; set; }
        //TODO: ?
    }

    /// <summary>
    /// Oversees the calling of a particular function periodically.
    /// PeriodicalExecuter shields you from multiple parallel executions of a callback function, should it take longer than the given interval to execute.
    /// This is especially useful if you use one to interact with the user at given intervals (e.g. use a prompt or confirm call):
    /// this will avoid multiple message boxes all waiting to be actioned.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "PeriodicalExecuter", Export = false)]
    public class PeriodicalExecuter
    {
        /// <summary>
        /// Creates a PeriodicalExecuter.
        /// </summary>
        /// <param name="callback">(Function) – the function to be executed at each interval.</param>
        /// <param name="frequency"> (Number) – the amount of time, in seconds, to wait in between callbacks.</param>
        public PeriodicalExecuter(JsAction callback, JsNumber frequency) { }

        /// <summary>
        /// Stops the periodical executer (there will be no further triggers).
        /// Once a PeriodicalExecuter is created, it constitues an infinite loop, triggering at the given interval until the page unloads.
        /// This method lets you stop it any time you want.
        /// </summary>
        public void stop() { }
    }


    /// <summary>
    /// Extensions to the built-in RegExp object.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "JsRegExpExtensions", Export = false)]
    public static class JsRegExpExtensions
    {

        //TODO: Class methods

        /// <summary>
        /// Alias of the native RegExp#test method. Returns true if str matches the regular expression, false otherwise.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static bool match(this JsRegExp r, JsString str) { return false; }
    }
    //TODO: $A, $H, $R, $w.

    /// <summary>
    /// A class for sophisticated string interpolation.
    /// Any time you have a group of similar objects and you need to produce formatted output for these objects,
    /// maybe inside a loop, you typically resort to concatenating string literals with the object's fields:
    /// "The TV show " + title + " was created by " + author + "."
    /// There's nothing wrong with this approach, except that it is hard to visualize the output immediately just by glancing at the concatenation expression.
    /// The Template class provides a much nicer and clearer way of achieving this formatting.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Template", Export = false)]
    public class Template
    {
        /// <summary>
        /// Creates a Template object.
        /// The optional pattern argument expects a RegExp that defines a custom syntax for the replaceable symbols in template.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="pattern"></param>
        public Template(JsString template, JsString pattern) { }

        /// <summary>
        /// Applies the template to object's data, producing a formatted string with symbols replaced by object's corresponding properties.
        /// </summary>
        /// <param name="object"></param>
        /// <returns></returns>
        public JsString evaluate(object @object) { return null; }
    }

    //TODO: Try- http://api.prototypejs.org/language/Try/

    #endregion

}

namespace SharpKit.PrototypeJs.Ajax
{
    [JsType(JsMode.Prototype, Name = "Ajax", Export = false)]
    public class Ajax
    {
        /// <summary>
        /// Represents the number of active XHR requests triggered through Ajax.Request, Ajax.Updater, or Ajax.PeriodicalUpdater.
        /// </summary>
        public JsNumber activeRequestCount { get; set; }
    }
    //TODO: May invented the class

    /// <summary>
    /// Prototype's APIs around the XmlHttpRequest object.
    /// The Prototype framework enables you to deal with Ajax calls in a manner that is both easy and compatible with all modern browsers.
    /// Actual requests are made by creating instances of Ajax.Request.
    /// Request headers:
    /// The following headers are sent with all Ajax requests (and can be overridden with the requestHeaders option described below):
    /// X-Requested-With is set to XMLHttpRequest.
    /// X-Prototype-Version is set to Prototype's current version (e.g., <%= PROTOTYPE_VERSION %>).
    /// Accept is set to text/javascript, text/html, application/xml, text/xml, * / *
    /// Content-type is automatically determined based on the contentType and encoding options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AjaxOptions
    {
        /// <summary>
        /// (Boolean; default true): Determines whether XMLHttpRequest is used asynchronously or not.
        /// Synchronous usage is strongly discouraged — it halts all script execution for the duration of the request and blocks the browser UI.
        /// </summary>
        public bool asynchronous { get; set; }

        /// <summary>
        /// (String; default application/x-www-form-urlencoded): The Content-type header for your request.
        /// Change this header if you want to send data in another format (like XML).
        /// </summary>
        public JsString contentType { get; set; }

        /// <summary>
        /// (String; default UTF-8): The encoding for the contents of your request.
        /// It is best left as-is, but should weird encoding issues arise, you may have to tweak this.
        /// </summary>
        public JsString encoding { get; set; }

        /// <summary>
        /// (String; default post): The HTTP method to use for the request. The other common possibility is get.
        /// Abiding by Rails conventions,
        /// Prototype also reacts to other HTTP verbs(such as put and delete) by submitting via post and adding a extra _method parameter with the originally-requested method.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// (String): The parameters for the request, which will be encoded into the URL for a get method, or into the request body for the other methods.
        /// This can be provided either as a URL-encoded string, a Hash, or a plain Object.
        /// </summary>
        public JsString parameters { get; set; }

        /// <summary>
        /// Specific contents for the request body on a post method. If it is not provided, the contents of the parameters option will be used instead.
        /// </summary>
        public JsString postBody { get; set; }

        /// <summary>
        /// A set of key-value pairs, with properties representing header names.
        /// </summary>
        public object requestHeaders { get; set; }

        /// <summary>
        /// (Boolean | String; default true):
        /// Automatically evals the content of Ajax.Response#responseText and populates Ajax.Response#responseJSON with it if the Content-type returned by the server is set to application/json.
        /// If the request doesn't obey same-origin policy, the content is sanitized before evaluation.
        /// If you need to force evalutation, pass 'force'. To prevent it altogether, pass false.
        /// </summary>
        public bool evalJS { get; set; }
        /// <summary>
        /// (Boolean | String; default true):
        /// Automatically evals the content of Ajax.Response#responseText and populates Ajax.Response#responseJSON with it if the Content-type returned by the server is set to application/json.
        /// If the request doesn't obey same-origin policy, the content is sanitized before evaluation.
        /// If you need to force evalutation, pass 'force'. To prevent it altogether, pass false.
        /// </summary>
        [JsProperty(Name = "evalJS")]
        public JsString evalJSString { get; set; }

        /// <summary>
        /// (Boolean; default is false for same-origin requests, true otherwise): Sanitizes the contents of Ajax.Response#responseText before evaluating it.
        /// </summary>
        public bool sanitizeJSON { get; set; }

        /// <summary>
        /// Triggered when the Ajax.Request object is initialized.
        /// This is after the parameters and the URL have been processed, but before opening the connection via the XHR object.
        /// </summary>
        public JsAction<Response, object> onCreate { get; set; }

        /// <summary>
        /// (Not guaranteed): Invoked just after the XHR object is created.
        /// </summary>
        public JsAction<Response, object> onUninitialized { get; set; }

        /// <summary>
        ///  (Not guaranteed): Triggered when the underlying XHR object is being setup, and its connection opened.
        /// </summary>
        public JsAction<Response, object> onLoading { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered once the underlying XHR object is setup, the connection is open, and it is ready to send its actual request.
        /// </summary>
        public JsAction<Response, object> onLoaded { get; set; }

        /// <summary>
        ///  (Not guaranteed): Triggered whenever the requester receives a part of the response (but not the final part), should it be sent in several packets.
        /// </summary>
        public JsAction<Response, object> onInteractive { get; set; }

        /// <summary>
        /// Invoked when a request completes and its status code is undefined or belongs in the 2xy family.
        /// This is skipped if a code-specific callback is defined (e.g., on200), and happens before onComplete.
        /// </summary>
        public JsAction<Response, object> onSuccess { get; set; }

        /// <summary>
        ///  Invoked when a request completes and its status code exists but is not in the 2xy family.
        ///  This is skipped if a code-specific callback is defined (e.g. on403), and happens before onComplete.
        /// </summary>
        public JsAction<Response, object> onFailure { get; set; }

        /// <summary>
        /// (with XYZ representing any HTTP status code): Invoked just after the response is complete if the status code is the exact code used in the callback name.
        /// Prevents execution of onSuccess and onFailure. Happens before onComplete.
        /// </summary>
        public JsAction<Response, object> onXYZ { get; set; }

        /// <summary>
        /// Triggered whenever an XHR error arises.
        /// Has a custom signature: the first argument is the requester (i.e. an Ajax.Request instance), and the second is the exception object.
        /// </summary>
        public JsAction<Response, object> onException { get; set; }

        /// <summary>
        /// Triggered at the very end of a request's life-cycle, after the request completes, status-specific callbacks are called,
        /// and possible automatic behaviors are processed. Guaranteed to run regardless of what happened during the request.
        /// </summary>
        public JsAction<Response, object> onComplete { get; set; }

    }

    /// <summary>
    /// Periodically performs an Ajax request and updates a container's contents based on the response text.
    /// Ajax.PeriodicalUpdater behaves like Ajax.Updater, but performs the update at a prescribed interval, rather than only once.
    /// (Note that it is not a subclass of Ajax.Updater; it's a wrapper around it.)
    /// This class addresses the common need of periodical update, as required by all sorts of "polling" mechanisms (e.g., an online chatroom or an online mail client).
    /// The basic idea is to run a regular Ajax.Updater at regular intervals,
    /// keeping track of the response text so it can (optionally) react to receiving the exact same response consecutively.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.PeriodicalUpdater", Export = false)]
    public class PeriodicalUpdater
    {
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options"> Configuration for the request. See the Ajax for more information.</param>
        public PeriodicalUpdater(JsString container, JsString url, PeriodicalUpdaterOptions options) { }
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        public PeriodicalUpdater(JsString container, JsString url) { }
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options"> Configuration for the request. See the Ajax for more information.</param>
        public PeriodicalUpdater(Element container, JsString url, PeriodicalUpdaterOptions options) { }
        /// <summary>
        /// Creates a new Ajax.PeriodicalUpdater.
        /// Periodically performs an AJAX request and updates a container's contents based on the response text.
        /// Offers a mechanism for "decay," which lets it trigger at widening intervals while the response is unchanged.
        /// This object addresses the common need of periodical update, which is used by all sorts of "polling" mechanisms (e.g. in an online chatroom or an online mail client).
        /// The basic idea is to run a regular Ajax.Updater at regular intervals, monitoring changes in the response text if the decay option (see below) is active.
        /// </summary>
        /// <param name="container">(String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        public PeriodicalUpdater(Element container, JsString url) { }

        /// <summary>
        /// Starts the periodical updater (if it had previously been stopped with Ajax.PeriodicalUpdater#stop).
        /// </summary>
        public static void start() { }

        /// <summary>
        /// Stops the periodical updater.
        /// Also calls the onComplete callback, if one has been defined.
        /// </summary>
        public static void stop() { }
    }

    /// <summary>
    /// Ajax.PeriodicalUpdater features all the common options and callbacks described in the Ajax — plus those added by Ajax.Updater.
    /// It also provides two new options:
    /// </summary>
    [JsType(JsMode.Json)]
    public class PeriodicalUpdaterOptions : UpdaterOptions
    {
        /// <summary>
        ///  (Number; default is 2): How long, in seconds, to wait between the end of one request and the beginning of the next.
        /// </summary>
        public JsNumber frequency { get; set; }

        /// <summary>
        /// (Number; default is 1): The rate at which the frequency grows when the response received is exactly the same as the previous.
        /// The default of 1 means frequency will never grow; override the default if a stale response implies it's worthwhile to poll less often.
        /// If decay is set to 2, for instance, frequency will double (2 seconds, 4 seconds, 8 seconds...) each consecutive time the result is the same;
        /// when the result is different once again, frequency will revert to its original value.
        /// </summary>
        public JsNumber decay { get; set; }
    }

    /// <summary>
    /// Initiates and processes an Ajax request.
    /// Ajax.Request is a general-purpose class for making HTTP requests which handles the life-cycle of the request, handles the boilerplate,
    /// and lets you plug in callback functions for your custom needs.
    /// In the optional options hash, you usually provide an onComplete and/or onSuccess callback,
    /// unless you're in the edge case where you're getting a JavaScript-typed response, that will automatically be eval'd.
    /// For a full list of common options and callbacks, see "Ajax options" heading of the Ajax.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Request", Export = false)]
    public class Request
    {
        /// <summary>
        /// Creates a new Ajax.Request.
        /// </summary>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options"> (Object) – Configuration for the request. See the Ajax for more information.</param>
        public Request(JsString url, AjaxOptions options) { }
        /// <summary>
        /// Creates a new Ajax.Request.
        /// </summary>
        /// <param name="url">(String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        public Request(JsString url) { }

        /// <summary>
        /// Returns the value of the given response header, or null if that header was not found.
        /// </summary>
        /// <param name="name"> The name of an HTTP header that may have been part of the response.</param>
        /// <returns></returns>
        public static JsString getHeader(JsString name) { return null; }

        /// <summary>
        /// Tests whether the request was successful.
        /// </summary>
        /// <returns></returns>
        public static bool success() { return false; }

    }

    /// <summary>
    /// A wrapper class around XmlHttpRequest for dealing with HTTP responses of Ajax requests.
    /// An instance of Ajax.Response is passed as the first argument of all Ajax requests' callbacks. You will not need to create instances of Ajax.Response yourself.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Response", Export = false)]
    public class Response
    {
        /// <summary>
        /// Returns a String containing all headers separated by line breaks. Does not throw errors if no headers are present the way its native counterpart does.
        /// </summary>
        /// <returns></returns>
        public static JsString getAllHeaders() { return null; }

        /// <summary>
        /// Returns a String containing all headers separated by line breaks; throws an error if no headers exist.
        /// This is just a wrapper around the XmlHttpRequest method of the same name. Prefer it's shorter counterpart: Ajax.Response#getAllHeaders.
        /// </summary>
        /// <returns></returns>
        public static JsString getAllResponseHeaders() { return null; }

        /// <summary>
        /// See Ajax.Request#getHeader.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static JsString getHeader(JsString name) { return null; }

        /// <summary>
        /// Returns the value of the requested header if present; throws an error otherwise.
        /// This is just a wrapper around the XmlHttpRequest method of the same name. Prefer it's shorter counterpart: Ajax.Response#getHeader.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static JsString getResponseHeader(JsString name) { return null; }

        //TODO: the following propertyes should be here or in an optios class?

        /// <summary>
        /// Auto-evaluated content of the X-JSON header if present; null otherwise. This is useful to transfer small amounts of data.
        /// </summary>
        public object headerJSON { get; set; }
        /// <summary>
        /// Auto-evaluated content of the X-JSON header if present; null otherwise. This is useful to transfer small amounts of data.
        /// </summary>
        [JsProperty(Name = "headerJSON")]
        public JsArray headerJSONArray { get; set; }
        //TODO: can also be null type

        /// <summary>
        /// A Number corresponding to the request's current state.
        /// 0 : "Uninitialized"
        /// 1 : "Loading"
        /// 2 : "Loaded"
        /// 3 : "Interactive"
        /// 4 : "Complete"
        /// </summary>
        public StateType readyState { get; set; }

        /// <summary>
        /// The request object itself (an instance of Ajax.Request or Ajax.Updater).
        /// </summary>
        public Request request { get; set; }
        /// <summary>
        /// The request object itself (an instance of Ajax.Request or Ajax.Updater).
        /// </summary>
        [JsProperty(Name = "request")]
        public Updater requestUpdater { get; set; }

        /// <summary>
        /// The JSON body of the response if the Content-type of the request is set to application/json; null otherwise.
        /// </summary>
        public object responseJSON { get; set; }
        /// <summary>
        /// The JSON body of the response if the Content-type of the request is set to application/json; null otherwise.
        /// </summary>
        [JsProperty(Name = "responseJSON")]
        public JsArray responseJSONArray { get; set; }

        /// <summary>
        /// The XML body of the response if the Content-type of the request is set to application/xml; null otherwise.
        /// </summary>
        public document responseXML { get; set; }
        //TODO: type can be null

        /// <summary>
        /// The HTTP status code sent by the server.
        /// </summary>
        public JsNumber status { get; set; }

        /// <summary>
        /// The HTTP status text sent by the server.
        /// </summary>
        public JsString statusText { get; set; }

        /// <summary>
        /// The native XmlHttpRequest object itself.
        /// </summary>
        public XMLHttpRequest transport { get; set; }
    }

    [JsType(JsMode.Json)]
    public enum StateType
    {
        Uninitialized = 0,
        Loading= 1,
        Loaded=2,
        Interactive=3,
        Complete=4,
    }

    /// <summary>
    /// A class that performs an Ajax request and updates a container's contents with the contents of the response.
    /// Ajax.Updater is a subclass of Ajax.Request built for a common use-case.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Response", Export = false)]
    public class Updater : Request
    {
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(JsString container, JsString url, UpdaterOptions options) : base(url, options) { }
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(JsString container, JsString url) : base(url, null) { }
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(Element container, JsString url, UpdaterOptions options) : base(url, options) { }
        /// <summary>
        /// Creates a new Ajax.Updater.
        /// </summary>
        /// <param name="container"> (String | Element) – The DOM element whose contents to update as a result of the Ajax request.
        /// Can be a DOM node or a string that identifies a node's ID.</param>
        /// <param name="url"> (String) – The URL to fetch. When the same-origin policy is in effect (as it is in most cases),
        /// url must be a relative URL or an absolute URL that starts with a slash (i.e., it must not begin with http).</param>
        /// <param name="options">(Object) – Configuration for the request. See the Ajax for more information.</param>
        public Updater(Element container, JsString url) : base(url, null) { }
    }

    /// <summary>
    /// Ajax.Updater has some options of its own apart from the common options described in the Ajax:
    /// </summary>
    [JsType(JsMode.Json)]
    public class UpdaterOptions : AjaxOptions
    {
        /// <summary>
        /// (Boolean; defaults to false): Whether <script> elements in the response text should be evaluated.
        /// </summary>
        public bool evalScripts { get; set; }

        /// <summary>
        ///  (String): By default, Element.update is used, meaning the contents of the response will replace the entire contents of the container.
        ///  You may instead insert the response text without disrupting existing contents.
        ///  The insertion option takes one of four strings — top, bottom, before, or after — and inserts the contents of the response in the manner described by Element#insert.
        /// </summary>
        public JsString insertion { get; set; }
    }
}
namespace SharpKit.PrototypeJs.Ajax.Responders
{
    /// <summary>
    /// A repository of global listeners notified about every step of Prototype-based Ajax requests.
    /// Sometimes, you need to provide generic behaviors over all Ajax operations happening on the page (through Ajax.Request, Ajax.Updater or Ajax.PeriodicalUpdater).
    /// For instance, you might want to automatically show an indicator when an Ajax request is ongoing, and hide it when none are.
    /// You may well want to factor out exception handling as well, logging those somewhere on the page in a custom fashion. The possibilities are myriad.
    /// To achieve this, Prototype provides Ajax.Responders, which lets you register (and, if you wish, unregister later) responders, which are objects with specially-named methods.
    /// These names come from a set of general callbacks corresponding to different points in time (or outcomes) of an Ajax request's life cycle.
    /// For instance, Prototype automatically registers a responder that maintains a nifty variable: Ajax.activeRequestCount.
    /// This represents, at a given time, the number of currently active Ajax requests — by monitoring their onCreate and onComplete events. 
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.Responders", Export = false)]
    public class Responders
    {
        /// <summary>
        /// Add a group of responders to all Ajax requests.
        /// </summary>
        /// <param name="responder"> A list of functions with keys corresponding to the names of possible callbacks.</param>
        public void register(object responder) { }

        /// <summary>
        /// Remove a previously-added group of responders.
        /// As always, unregistering something requires you to use the very same object you used at registration.
        /// If you plan to use unregister, be sure to assign your responder to a variable before passing it into Ajax.Responders#register — don't pass it an object literal.
        /// </summary>
        /// <param name="responder">  A list of functions with keys corresponding to the names of possible callbacks.</param>
        public void unregister(object responder) { }
    }
    //TODO: think it is a namespce not a class

    /// <summary>
    /// The callbacks for responders are similar to the callbacks described in the Ajax, but take a different signature.
    /// They're invoked with three parameters: the requester object (i.e., the corresponding "instance" of Ajax.Request),
    /// the XMLHttpRequest object, and the result of evaluating the X-JSON response header, if any (can be null).
    /// They also execute in the context of the responder, bound to the this reference.
    /// </summary>
    [JsType(JsMode.Json)]
    public class RespondersOptions
    {

        /// <summary>
        /// Triggered whenever a requester object from the Ajax namespace is created, after its parameters are adjusted and before its XHR connection is opened.
        /// This takes two arguments: the requester object and the underlying XHR object.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onCreate { get; set; }

        /// <summary>
        /// (Not guaranteed): Invoked just after the XHR object is created.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onUninitialized { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered when the underlying XHR object is being setup, and its connection opened.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onLoading { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered once the underlying XHR object is setup, the connection is open, and it is ready to send its actual request.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onLoaded { get; set; }

        /// <summary>
        /// (Not guaranteed): Triggered whenever the requester receives a part of the response (but not the final part), should it be sent in several packets.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onInteractive { get; set; }

        /// <summary>
        /// Triggered whenever an XHR error arises.
        /// Has a custom signature: the first argument is the requester (i.e. an Ajax.Request instance), and the second is the exception object.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onException { get; set; }

        /// <summary>
        /// Triggered at the very end of a request's life-cycle, after the request completes, status-specific callbacks are called, and possible automatic behaviors are processed.
        /// Guaranteed to run regardless of what happened during the request.
        /// </summary>
        public JsAction<Request, XMLHttpRequest, object> onComplete { get; set; }

    }
}
//TODO: make sure namespce is OK

namespace SharpKit.PrototypeJs.Abstract
{
    [JsType(JsMode.Prototype, Name = "Abstract.EventObserver", Export = false)]
    public class EventObserver
    {
    }

    /// <summary>
    /// An abstract DOM element observer class, subclasses of which can be used to periodically check a value and trigger a callback when the value has changed.
    /// A TimedObserver object will try to check a value using the getValue() instance method which must be defined by the subclass.
    /// There are two out-of-the-box subclasses: Form.Observer, which serializes a form and triggers when the result has changed;
    /// and Form.Element.Observer, which triggers when the value of a given form field changes.
    /// Using TimedObserver implementations is straightforward; simply instantiate them with appropriate arguments.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Abstract.TimedObserver", Export = false)]
    public class TimedObserver
    {
        /// <summary>
        /// Initializes an Abstract.TimedObserver; used by subclasses.
        /// </summary>
        /// <param name="element">(String | Element) – The DOM element to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency">(Number) – The frequency, in seconds — e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback"> (Function) – The callback to trigger when the value changes.</param>
        public TimedObserver(JsString element, JsNumber frequency, JsAction callback) { }
        /// <summary>
        /// Initializes an Abstract.TimedObserver; used by subclasses.
        /// </summary>
        /// <param name="element">(String | Element) – The DOM element to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency">(Number) – The frequency, in seconds — e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback"> (Function) – The callback to trigger when the value changes.</param>
        public TimedObserver(HtmlElement element, JsNumber frequency, JsAction callback) { }

    }
}

namespace SharpKit.PrototypeJs.Form
{
    [JsType(JsMode.Prototype, Name = "Form.EventObserver", Export = false)]
    public class EventObserver : Abstract.EventObserver
    {
    }

    /// <summary>
    /// An Abstract.TimedObserver subclass that watches for changes to a form.
    /// The callback is triggered when the form changes — e.g., when any of its fields' values changes,
    /// when fields are added/removed, etc.; anything that affects the serialized form of the form (see Form#serialize).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Form.Observer", Export = false)]
    public class Observer : Abstract.TimedObserver
    {
        /// <summary>
        /// Creates a Form.Observer.
        /// </summary>
        /// <param name="element">(String | Element) – The element of the form to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency"> (Number) – The frequency, in seconds -- e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback">(Function) – The callback to trigger when the form changes.</param>
        public Observer(JsString element, JsNumber frequency, JsAction callback) : base(element, frequency, callback) { }
        /// <summary>
        /// Creates a Form.Observer.
        /// </summary>
        /// <param name="element">(String | Element) – The element of the form to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency"> (Number) – The frequency, in seconds -- e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback">(Function) – The callback to trigger when the form changes.</param>
        public Observer(HtmlElement element, JsNumber frequency, JsAction callback) : base(element, frequency, callback) { }

    }

    [JsType(JsMode.Prototype, Name = "Form", Export = false)]
    public class Form
    {
        /// <summary>
        /// Disables the form as a whole. Form controls will be visible but uneditable.
        /// Disabling the form is done by iterating over form elements and calling Form.Element.disable on them.
        /// Note :Keep in mind that disabled elements are skipped by serialization methods! You cannot serialize a disabled form.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element disable() { return null; }

        /// <summary>
        /// Enables a fully- or partially-disabled form.
        /// Enabling the form is done by iterating over form elements and calling Form.Element.enable on them.
        /// Note :This will enable all form controls regardless of how they were disabled (by scripting or by HTML attributes).
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element enable() { return null; }

        /// <summary>
        /// Finds the first non-hidden, non-disabled control within the form.
        /// The returned object is either an INPUT, SELECT or TEXTAREA element. This method is used by the Form.focusFirstElement method.
        /// Note : The result of this method is the element that comes first in the document order, not the tabindex order.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element findFirstElement() { return null; }

        /// <summary>
        /// Gives keyboard focus to the first element of the form. Returns the form.
        /// Uses Form.findFirstElement to get the first element and calls Form.Element.activate on it.
        /// This is useful for enhancing usability on your site by bringing focus
        /// on page load to forms such as search forms or contact forms where a user is ready to start typing right away.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element focusFirstElement() { return null; }

        /// <summary>
        /// Returns a collection of all controls within a form.
        /// Note: OPTION elements are not included in the result; only their parent SELECT control is.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> getElements() { return null; }

        /// <summary>
        /// Returns a collection of all INPUT elements in a form.
        /// Use optional type and name arguments to restrict the search on these attributes.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="type">(String) – A value for the type attribute against which to filter.</param>
        /// <param name="name"> (String) – A value for the name attribute against which to filter.</param>
        /// <returns></returns>
        public JsArray<Element> getInputs(JsString type, JsString name) { return null; }
        /// <summary>
        /// Returns a collection of all INPUT elements in a form.
        /// Use optional type and name arguments to restrict the search on these attributes.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="type">(String) – A value for the type attribute against which to filter.</param>
        /// <returns></returns>
        public JsArray<Element> getInputs(JsString type) { return null; }
        /// <summary>
        /// Returns a collection of all INPUT elements in a form.
        /// Use optional type and name arguments to restrict the search on these attributes.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public JsArray<Element> getInputs() { return null; }

        /// <summary>
        /// A convenience method for serializing and submitting the form via an Ajax.Request to the URL of the form's action attribute.
        /// The options parameter is passed to the Ajax.Request instance, allowing one to override the HTTP method and/or specify additional parameters and callbacks.
        /// If the form has a method attribute, its value is used for the Ajax.Request method option. If a method option is passed to request(),
        /// it takes precedence over the form's method attribute. If neither is specified, method defaults to "POST".
        /// Key-value pairs specified in the parameters option (either as a hash or a query string) will be merged with (and take precedence over) the serialized form parameters.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="options">(Object) – Options to pass along to the Ajax.Request constructor.</param>
        /// <returns></returns>
        public Ajax.Request request(object options) { return null; }
        /// <summary>
        /// A convenience method for serializing and submitting the form via an Ajax.Request to the URL of the form's action attribute.
        /// The options parameter is passed to the Ajax.Request instance, allowing one to override the HTTP method and/or specify additional parameters and callbacks.
        /// If the form has a method attribute, its value is used for the Ajax.Request method option. If a method option is passed to request(),
        /// it takes precedence over the form's method attribute. If neither is specified, method defaults to "POST".
        /// Key-value pairs specified in the parameters option (either as a hash or a query string) will be merged with (and take precedence over) the serialized form parameters.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Ajax.Request request() { return null; }

        /// <summary>
        /// Resets a form to its default values.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <returns></returns>
        public Element reset() { return null; }

        /// <summary>
        /// Serializes form data to a string suitable for Ajax requests (default behavior) or, if the hash option evaluates to true,
        /// an object hash where keys are form control names and values are data.
        /// Depending of whether or not the hash option evaluates to true,
        /// the result is either an object of the form {name: "johnny", color: "blue"} or a String of the form "name=johnny&color=blue",
        /// suitable for parameters in an Ajax request. This method mimics the way browsers serialize forms natively so that form data can be sent without refreshing the page.
        /// See Form.serializeElements for more details on the options.
        /// This method can be called either as an instance method or as a generic method. If calling as a generic, pass the instance in as the first argument.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public JsString serialize(SerializeOptions options) { return null; }

    }

    /// <summary>
    /// The options allow you to control two things: What kind of return value you get (an object or a string),
    /// and whether and which submit fields are included in that object or string.
    /// If you do not supply an options object at all, the options { hash: false } are used.
    /// If you supply an options object, it may have the following options:
    /// </summary>
    [JsType(JsMode.Json)]
    public class SerializeOptions
    {
        /// <summary>
        ///  true to return a plain object with keys and values (not a Hash; see below), false to return a String in query string format.
        ///  If you supply an options object with no hash member, hash defaults to true.
        ///  Note that this is not the same as leaving off the options object entirely (see above)
        /// </summary>
        public bool hash { get; set; }

        /// <summary>
        ///  In essence: If you omit this option the first submit button in the form is included;
        ///  if you supply false, no submit buttons are included; if you supply the name of a submit button, the first button with that name is included.
        ///  Note that the false value must really be false, not falsey; falsey-but-not-false is like omitting the option.
        /// </summary>
        public bool submit { get; set; }
        /// <summary>
        ///  In essence: If you omit this option the first submit button in the form is included;
        ///  if you supply false, no submit buttons are included; if you supply the name of a submit button, the first button with that name is included.
        ///  Note that the false value must really be false, not falsey; falsey-but-not-false is like omitting the option.
        /// </summary>
        [JsProperty(Name = "submit")]
        public JsString submitString { get; set; }

    }


}

namespace SharpKit.PrototypeJs.Form.Element2
{
    [JsType(JsMode.Prototype, Name = "Form.Element.EventObserver", Export = false)]
    public class EventObserver : Abstract.EventObserver
    {
    }

    /// <summary>
    /// An Abstract.TimedObserver subclass that watches for changes to a form field's value.
    /// This triggers the callback when the form field's value (according to Form.Element.getValue) changes.
    /// (Note that when the value actually changes can vary from browser to browser, particularly with select boxes.)
    /// Form.Element observer implements the getValue() method using Form.Element.getValue on the given element.
    /// See Abstract.TimedObserver for general documentation on timed observers.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Form.Element.Observer", Export = false)]
    public class Observer : Abstract.TimedObserver
    {
        /// <summary>
        /// Creates a Form.Element.Observer.
        /// </summary>
        /// <param name="element">(String | Element) – The form element to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency"> (Number) – The frequency, in seconds — e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback">(Function) – The callback to trigger when the value changes.</param>
        public Observer(JsString element, JsNumber frequency, JsAction callback) : base(element, frequency, callback) { }
        /// <summary>
        /// Creates a Form.Element.Observer.
        /// </summary>
        /// <param name="element">(String | Element) – The form element to watch. Can be an element instance or an ID.</param>
        /// <param name="frequency"> (Number) – The frequency, in seconds — e.g., 0.33 to check for changes every third of a second.</param>
        /// <param name="callback">(Function) – The callback to trigger when the value changes.</param>
        public Observer(HtmlElement element, JsNumber frequency, JsAction callback) : base(element, frequency, callback) { }

    }
}
//TODO: namespace name







