using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
using SharpKit.Html;


[assembly: JsNamespace(Namespace = "SharpKit.Fabric", JsNamespace = "")]
namespace SharpKit.Fabric
{
    #region array
    /// <summary>
    /// </summary>
    public partial class array
    {
        /// <summary>
        /// Invokes method on all items in a given array
        /// </summary>
        public static object[] invoke(object[] array, string method) { return null; }
        /// <summary>
        /// Finds maximum value in array (not necessarily "first" one)
        /// </summary>
        public static object max(object[] array, string byProperty) { return null; }
        /// <summary>
        /// Finds minimum value in array (not necessarily "first" one)
        /// </summary>
        public static object min(object[] array, string byProperty) { return null; }
    }
    #endregion

    [JsType(JsMode.Prototype, Name = "fabric")]
    public partial class fabric
    {
        /// <summary>
        /// Only available when running fabric on node.js
        /// </summary>
        public static Object createCanvasForNode(JsNumber width, JsNumber height) { return null; }
        /// <summary>
        /// Returns CSS rules for a given SVG document
        /// </summary>
        public static Object getCSSRules(object doc) { return null; }
        /// <summary>
        /// Parses an SVG document, returning all of the gradient declarations found in it
        /// </summary>
        public static Object getGradientDefs(object doc) { return null; }


        /// <summary>
        /// Takes string corresponding to an SVG document, and parses it into a set of fabric objects
        /// </summary>
        public static void loadSVGFromString(string data, JsAction<Object[], SVGOption> callback) { }

        /// <summary>
        /// Takes string corresponding to an SVG document, and parses it into a set of fabric objects
        /// </summary>
        public static void loadSVGFromString(string data, JsAction<Object[], SVGOption> callback, JsAction reviver) { }

        /// <summary>
        /// Takes url corresponding to an SVG document, and parses it into a set of fabric objects. Note that SVG is fetched via XMLHttpRequest, so it needs to conform to SOP (Same Origin Policy)
        /// </summary>
        public static void loadSVGFromURL(string url, JsAction<Object[], SVGOption> callback) { }

        /// <summary>
        /// Takes url corresponding to an SVG document, and parses it into a set of fabric objects. Note that SVG is fetched via XMLHttpRequest, so it needs to conform to SOP (Same Origin Policy)
        /// </summary>
        public static void loadSVGFromURL(string url, JsAction<Object[], SVGOption> callback, object reviver) { }
        /// <summary>
        /// Wrapper around `console.log` (when available)
        /// </summary>
        public static void log(object values) { }
        /// <summary>
        /// Returns an object of attributes' name/value, given element and an array of attribute names;
        /// Parses parent "g" nodes recursively upwards.
        /// </summary>
        public static Object parseAttributes(object element, object[] attributes) { return null; }
        /// <summary>
        /// Transforms an array of svg elements to corresponding fabric.* instances
        /// </summary>
        public static void parseElements(object[] elements, JsAction callback, Object options, object reviver) { }
        /// <summary>
        /// Parses "points" attribute, returning an array of values
        /// </summary>
        public static object[] parsePointsAttribute(string points) { return null; }
        /// <summary>
        /// Parses "style" attribute, retuning an object with values
        /// </summary>
        public static Object parseStyleAttribute(object element) { return null; }
        /// <summary>
        /// Parses an SVG document, converts it to an array of corresponding fabric.* instances and passes them to a callback
        /// </summary>
        public static void parseSVGDocument(object doc, JsAction callback, object reviver) { }
        /// <summary>
        /// Parses "transform" attribute, returning an array of values
        /// </summary>
        public static object[] parseTransformAttribute(string attributeValue) { return null; }
        /// <summary>
        /// Wrapper around `console.warn` (when available)
        /// </summary>
        public static void warn(object Values) { }
        /// <summary>
        /// True when in environment that's probably Node.js
        /// </summary>
        public static bool isLikelyNode { get; set; }
        /// <summary>
        /// True when in environment that supports touch events
        /// </summary>
        public static bool isTouchSupported { get; set; }
        /// <summary>
        /// Attributes parsed from all SVG elements
        /// </summary>
        public static array SHARED_ATTRIBUTES { get; set; }
        //} ****** end fabric ****


        #region BaseBrush
        /// <summary>
        /// </summary>
        public partial class BaseBrush
        {
            /// <summary>
            /// Sets shadow of an object
            /// </summary>
            public Object setShadow(object options) { return null; }
            /// <summary>
            /// Color of a brush
            /// </summary>
            public string color { get; set; }
            /// <summary>
            /// Shadow object representing shadow of this shape.
            /// <b>Backwards incompatibility note:</b> This property replaces "shadowColor" (String), "shadowOffsetX" (Number),
            /// "shadowOffsetY" (Number) and "shadowBlur" (Number) since v1.2.12
            /// </summary>
            public Shadow shadow { get; set; }
            /// <summary>
            /// Line endings style of a brush (one of "butt", "round", "square")
            /// </summary>
            public string strokeLineCap { get; set; }
            /// <summary>
            /// Corner style of a brush (one of "bevil", "round", "miter")
            /// </summary>
            public string strokeLineJoin { get; set; }
            /// <summary>
            /// Width of a brush
            /// </summary>
            public JsNumber width { get; set; }
        }
        #endregion
        #region Canvas
        /// <summary>
        /// </summary>
        public partial class Canvas : StaticCanvas
        {
            public Canvas()
            {

            }

            public Canvas(string id)
            {

            }

            public Canvas add(Object item) { return null; }

            public object remove(Object @object) { return null; }

            /// <summary>
            /// </summary>
            public void _setCursorFromEvent() { }
            /// <summary>
            /// Sets the cursor depending on where the canvas is being hovered.
            /// Note: very buggy in Opera
            /// </summary>
            public void _setCursorFromEvent(object e, Object target) { }
            /// <summary>
            /// Checks if point is contained within an area of given object
            /// </summary>
            public bool containsPoint(object e, Object target) { return false; }
            /// <summary>
            /// Deactivates all objects on canvas, removing any active group or object
            /// </summary>
            public fabric.Canvas deactivateAll() { return null; }
            /// <summary>
            /// Deactivates all objects and dispatches appropriate events
            /// </summary>
            public fabric.Canvas deactivateAllWithDispatch() { return null; }
            /// <summary>
            /// Discards currently active group
            /// </summary>
            public fabric.Canvas discardActiveGroup() { return null; }
            /// <summary>
            /// Discards currently active object
            /// </summary>
            public fabric.Canvas discardActiveFabricObject() { return null; }
            /// <summary>
            /// Draws objects' controls (borders/controls)
            /// </summary>
            public void drawControls(object ctx) { }
            /// <summary>
            /// Method that determines what object we are clicking on
            /// </summary>
            public void findTarget(object e, bool skipGroup) { }
            /// <summary>
            /// Returns pointer coordinates relative to canvas.
            /// </summary>
            public MouseEvent getPointer(MouseEvent e) { return null; }
            /// <summary>
            /// Returns context of canvas where object selection is drawn
            /// </summary>
            public object getSelectionContext() { return null; }
            /// <summary>
            /// Returns &lt;canvas> element on which object selection is drawn
            /// </summary>
            public object getSelectionElement() { return null; }
            /// <summary>
            /// Returns true if object is transparent at a certain location
            /// </summary>
            public bool isTargetTransparent(Object target, JsNumber x, JsNumber y) { return false; }
            /// <summary>
            /// Removes all event listeners
            /// </summary>
            public void removeListeners() { }
            /// <summary>
            /// Sets active group to a speicified one
            /// </summary>
            public fabric.Canvas setActiveGroup(Group group) { return null; }
            /// <summary>
            /// Sets given object as the only active object on canvas
            /// </summary>
            public fabric.Canvas setActiveFabricObject(Object @object, object e) { return null; }
            /// <summary>
            /// When true, objects use center point as the origin of rotate transformation.
            /// <b>Backwards incompatibility note:</b> This property replaces "centerTransform" (Boolean).
            /// </summary>
            public bool centeredRotation { get; set; }
            /// <summary>
            /// When true, objects use center point as the origin of scale transformation.
            /// <b>Backwards incompatibility note:</b> This property replaces "centerTransform" (Boolean).
            /// </summary>
            public bool centeredScaling { get; set; }
            /// <summary>
            /// Default element class that's given to wrapper (div) element of canvas
            /// </summary>
            public string containerClass { get; set; }
            /// <summary>
            /// Default cursor value used for the entire canvas
            /// </summary>
            public string defaultCursor { get; set; }
            /// <summary>
            /// Cursor value used during free drawing
            /// </summary>
            public string freeDrawingCursor { get; set; }
            /// <summary>
            /// Default cursor value used when hovering over an object on canvas
            /// </summary>
            public string hoverCursor { get; set; }
            /// <summary>
            /// Indicates that canvas is interactive. This property should not be changed.
            /// </summary>
            public bool interactive { get; set; }
            /// <summary>
            /// Default cursor value used when moving an object on canvas
            /// </summary>
            public string moveCursor { get; set; }
            /// <summary>
            /// When true, object detection happens on per-pixel basis rather than on per-bounding-box
            /// </summary>
            public bool perPixelTargetFind { get; set; }
            /// <summary>
            /// Cursor value used for rotation point
            /// </summary>
            public string rotationCursor { get; set; }
            /// <summary>
            /// Indicates whether group selection should be enabled
            /// </summary>
            public bool selection { get; set; }
            /// <summary>
            /// Color of the border of selection (usually slightly darker than color of selection itself)
            /// </summary>
            public string selectionBorderColor { get; set; }
            /// <summary>
            /// Color of selection
            /// </summary>
            public string selectionColor { get; set; }
            /// <summary>
            /// Default dash array pattern
            /// If not empty the selection border is dashed
            /// </summary>
            public object[] selectionDashArray { get; set; }
            /// <summary>
            /// Width of a line used in object/group selection
            /// </summary>
            public JsNumber selectionLineWidth { get; set; }
            /// <summary>
            /// When true, target detection is skipped when hovering over canvas. This can be used to improve performance.
            /// </summary>
            public bool skipTargetFind { get; set; }
            /// <summary>
            /// Number of pixels around target pixel to tolerate (consider active) during object detection
            /// </summary>
            public JsNumber targetFindTolerance { get; set; }
            /// <summary>
            /// When true, objects can be transformed by one side (unproportionally)
            /// </summary>
            public bool uniScaleTransform { get; set; }

            public Object[] getObjects()
            {
                return null;
            }
        }
        #endregion
        #region Canvas
        /// <summary>
        /// fabric.Element
        /// </summary>
        public partial class Canvas
        {
        }
        #endregion
        #region Circle
        /// <summary>
        /// </summary>
        public partial class Circle : Object
        {
            public Circle()
            {

            }

            public Circle (Object opt)
            {

            }

            
            /// <summary>
            /// Returns {@link fabric.Circle} instance from an SVG element
            /// </summary>
            public Circle fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns {@link fabric.Circle} instance from an object representation
            /// </summary>
            public Object fromFabricObject(Object @object) { return null; }
            /// <summary>
            /// Returns horizontal radius of an object (according to how an object is scaled)
            /// </summary>
            public JsNumber getRadiusX() { return null; }
            /// <summary>
            /// Returns vertical radius of an object (according to how an object is scaled)
            /// </summary>
            public JsNumber getRadiusY() { return null; }
            /// <summary>
            /// Sets radius of an object (and updates width accordingly)
            /// </summary>
            public JsNumber setRadius() { return null; }
            /// <summary>
            /// Returns svg representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by {@link fabric.Circle.fromElement})
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
        }
        #endregion
        #region CircleBrush
        /// <summary>
        /// </summary>
        public partial class CircleBrush
        {
            /// <summary>
            /// </summary>
            public Point addPoint(Object pointer) { return null; }
            /// <summary>
            /// Invoked inside on mouse down and mouse move
            /// </summary>
            public void drawDot(Object pointer) { }
            /// <summary>
            /// Constructor
            /// </summary>
            public CircleBrush initialize(fabric.Canvas canvas) { return null; }
            /// <summary>
            /// Invoked on mouse down
            /// </summary>
            public void onMouseDown() { }
            /// <summary>
            /// Invoked on mouse move
            /// </summary>
            public void onMouseMove(Object pointer) { }
            /// <summary>
            /// Invoked on mouse up
            /// </summary>
            public void onMouseUp() { }
            /// <summary>
            /// Width of a brush
            /// </summary>
            public JsNumber width { get; set; }
        }
        #endregion
        #region Collection
        /// <summary>
        /// </summary>
        public partial class Collection
        {
            /// <summary>
            /// Adds objects to collection, then renders canvas (if `renderOnAddRemove` is not `false`)
            /// FabricObjects should be instances of (or inherit from) fabric.FabricObject
            /// </summary>
            public static object add(object ___) { return null; }
            /// <summary>
            /// Returns number representation of a collection complexity
            /// </summary>
            public static JsNumber complexity() { return null; }
            /// <summary>
            /// Returns true if collection contains an object
            /// </summary>
            public static bool contains(Object @object) { return false; }
            /// <summary>
            /// Executes given function for each object in this group
            /// </summary>
            public static object forEachFabricObject(JsAction callback, Object context) { return null; }
            /// <summary>
            /// Returns an array of children objects of this instance
            /// Type parameter introduced in 1.3.10
            /// </summary>
            public static object[] getFabricObjects(string type) { return null; }
            /// <summary>
            /// Inserts an object into collection at specified index, then renders canvas (if `renderOnAddRemove` is not `false`)
            /// An object should be an instance of (or inherit from) fabric.FabricObject
            /// </summary>
            public static object insertAt(Object @object, JsNumber index, bool nonSplicing) { return null; }
            /// <summary>
            /// Returns true if collection contains no objects
            /// </summary>
            public static bool isEmpty() { return false; }
            /// <summary>
            /// Returns object at specified index
            /// </summary>
            public static object item(JsNumber index) { return null; }
            /// <summary>
            /// Removes an object from a collection, then renders canvas (if `renderOnAddRemove` is not `false`)
            /// </summary>
            public static object remove(Object @object) { return null; }
            /// <summary>
            /// Returns a size of a collection (i.e: length of an array containing its objects)
            /// </summary>
            public static JsNumber size() { return null; }
        }
        #endregion
        #region Color
        /// <summary>
        /// </summary>
        public partial class Color
        {
            /// <summary>
            /// Returns new color object, when given a color in HEX format
            /// </summary>
            public Color fromHex(string color) { return null; }
            /// <summary>
            /// Returns new color object, when given a color in HSL format
            /// </summary>
            public Color fromHsl(string color) { return null; }
            /// <summary>
            /// Returns new color object, when given a color in HSLA format
            /// </summary>
            public Color fromHsla(string color) { return null; }
            /// <summary>
            /// Returns new color object, when given a color in RGB format
            /// </summary>
            public Color fromRgb(string color) { return null; }
            /// <summary>
            /// Returns new color object, when given a color in RGBA format
            /// </summary>
            public Color fromRgba(string color) { return null; }
            /// <summary>
            /// Returns new color object, when given color in array representation (ex: [200, 100, 100, 0.5])
            /// </summary>
            public Color fromSource(object[] source) { return null; }
            /// <summary>
            /// Gets value of alpha channel for this color
            /// </summary>
            public JsNumber getAlpha() { return null; }
            /// <summary>
            /// Returns source of this color (where source is an array representation; ex: [200, 200, 100, 1])
            /// </summary>
            public object[] getSource() { return null; }
            /// <summary>
            /// Overlays color with another color
            /// </summary>
            public Color overlayWith(object otherColor) { return null; }
            /// <summary>
            /// Sets value of alpha channel for this color
            /// </summary>
            public Color setAlpha(JsNumber alpha) { return null; }
            /// <summary>
            /// Sets source of this color (where source is an array representation; ex: [200, 200, 100, 1])
            /// </summary>
            public void setSource(object[] source) { }
            /// <summary>
            /// Returns array represenatation (ex: [100, 100, 200, 1]) of a color that's in HEX format
            /// </summary>
            public object[] sourceFromHex(string color) { return null; }
            /// <summary>
            /// Returns array represenatation (ex: [100, 100, 200, 1]) of a color that's in HSL or HSLA format.
            /// Adapted from <a href="https://rawgithub.com/mjijackson/mjijackson.github.com/master/2008/02/rgb-to-hsl-and-rgb-to-hsv-color-model-conversion-algorithms-in-javascript.html">https://github.com/mjijackson</a>
            /// </summary>
            public object[] sourceFromHsl(string color) { return null; }
            /// <summary>
            /// Returns array represenatation (ex: [100, 100, 200, 1]) of a color that's in RGB or RGBA format
            /// </summary>
            public object[] sourceFromRgb(string color) { return null; }
            /// <summary>
            /// Transforms color to its black and white representation
            /// </summary>
            public Color toBlackWhite(JsNumber threshold) { return null; }
            /// <summary>
            /// Transforms color to its grayscale representation
            /// </summary>
            public Color toGrayscale() { return null; }
            /// <summary>
            /// Returns color represenation in HEX format
            /// </summary>
            public string toHex() { return null; }
            /// <summary>
            /// Returns color represenation in HSL format
            /// </summary>
            public string toHsl() { return null; }
            /// <summary>
            /// Returns color represenation in HSLA format
            /// </summary>
            public string toHsla() { return null; }
            /// <summary>
            /// Returns color represenation in RGB format
            /// </summary>
            public string toRgb() { return null; }
            /// <summary>
            /// Returns color represenation in RGBA format
            /// </summary>
            public string toRgba() { return null; }
            /// <summary>
            /// Map of the 17 basic color names with HEX code
            /// </summary>
            public object colorNameMap { get; set; }
            /// <summary>
            /// Regex matching color in HEX format (ex: #FF5555, 010155, aff)
            /// </summary>
            public object reHex { get; set; }
            /// <summary>
            /// Regex matching color in HSL or HSLA formats (ex: hsl(200, 80%, 10%), hsla(300, 50%, 80%, 0.5), hsla( 300 , 50% , 80% , 0.5 ))
            /// </summary>
            public object reHSLa { get; set; }
            /// <summary>
            /// Regex matching color in RGB or RGBA formats (ex: rgb(0, 0, 0), rgba(255, 100, 10, 0.5), rgba( 255 , 100 , 10 , 0.5 ), rgb(1,1,1), rgba(100%, 60%, 10%, 0.5))
            /// </summary>
            public object reRGBa { get; set; }
        }
        #endregion
        #region ease
        /// <summary>
        /// Easing functions
        /// See <a href="http://gizma.com/easing/">Easing Equations by Robert Penner</a>
        /// </summary>
        public partial class ease
        {
            /// <summary>
            /// Backwards easing in
            /// </summary>
            public static void easeInBack() { }
            /// <summary>
            /// Bouncing easing in
            /// </summary>
            public static void easeInBounce() { }
            /// <summary>
            /// Circular easing in
            /// </summary>
            public static void easeInCirc() { }
            /// <summary>
            /// Cubic easing in
            /// </summary>
            public static void easeInCubic() { }
            /// <summary>
            /// Elastic easing in
            /// </summary>
            public static void easeInElastic() { }
            /// <summary>
            /// Exponential easing in
            /// </summary>
            public static void easeInExpo() { }
            /// <summary>
            /// Backwards easing in and out
            /// </summary>
            public static void easeInOutBack() { }
            /// <summary>
            /// Bouncing easing in and out
            /// </summary>
            public static void easeInOutBounce() { }
            /// <summary>
            /// Circular easing in and out
            /// </summary>
            public static void easeInOutCirc() { }
            /// <summary>
            /// Cubic easing in and out
            /// </summary>
            public static void easeInOutCubic() { }
            /// <summary>
            /// Elastic easing in and out
            /// </summary>
            public static void easeInOutElastic() { }
            /// <summary>
            /// Exponential easing in and out
            /// </summary>
            public static void easeInOutExpo() { }
            /// <summary>
            /// Quadratic easing in and out
            /// </summary>
            public static void easeInOutQuad() { }
            /// <summary>
            /// Quartic easing in and out
            /// </summary>
            public static void easeInOutQuart() { }
            /// <summary>
            /// Quintic easing in and out
            /// </summary>
            public static void easeInOutQuint() { }
            /// <summary>
            /// Sinusoidal easing in and out
            /// </summary>
            public static void easeInOutSine() { }
            /// <summary>
            /// Quadratic easing in
            /// </summary>
            public static void easeInQuad() { }
            /// <summary>
            /// Quartic easing in
            /// </summary>
            public static void easeInQuart() { }
            /// <summary>
            /// Quintic easing in
            /// </summary>
            public static void easeInQuint() { }
            /// <summary>
            /// Sinusoidal easing in
            /// </summary>
            public static void easeInSine() { }
            /// <summary>
            /// Backwards easing out
            /// </summary>
            public static void easeOutBack() { }
            /// <summary>
            /// Bouncing easing out
            /// </summary>
            public static void easeOutBounce() { }
            /// <summary>
            /// Circular easing out
            /// </summary>
            public static void easeOutCirc() { }
            /// <summary>
            /// Cubic easing out
            /// </summary>
            public static void easeOutCubic() { }
            /// <summary>
            /// Elastic easing out
            /// </summary>
            public static void easeOutElastic() { }
            /// <summary>
            /// Exponential easing out
            /// </summary>
            public static void easeOutExpo() { }
            /// <summary>
            /// Quadratic easing out
            /// </summary>
            public static void easeOutQuad() { }
            /// <summary>
            /// Quartic easing out
            /// </summary>
            public static void easeOutQuart() { }
            /// <summary>
            /// Quintic easing out
            /// </summary>
            public static void easeOutQuint() { }
            /// <summary>
            /// Sinusoidal easing out
            /// </summary>
            public static void easeOutSine() { }
        }
        #endregion
        #region Ellipse
        /// <summary>
        /// </summary>
        public partial class Ellipse : Object
        {
            /// <summary>
            /// Returns {@link fabric.Ellipse} instance from an SVG element
            /// </summary>
            public Ellipse fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns {@link fabric.Ellipse} instance from an object representation
            /// </summary>
            public Ellipse fromFabricObject(Object @object) { return null; }
            /// <summary>
            /// Returns svg representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by {@link fabric.Ellipse.fromElement})
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
            /// <summary>
            /// Horizontal radius
            /// </summary>
            public JsNumber rx { get; set; }
            /// <summary>
            /// Vertical radius
            /// </summary>
            public JsNumber ry { get; set; }
        }
        #endregion

        #region Gradient
        /// <summary>
        /// </summary>
        public partial class Gradient
        {
            /// <summary>
            /// Adds another colorStop
            /// </summary>
            public Gradient addColorStop(Object colorStop) { return null; }
            /// <summary>
            /// Returns {@link fabric.Gradient} instance from its object representation
            /// </summary>
            public void forFabricObject(Object obj, Object options) { }
            /// <summary>
            /// Returns {@link fabric.Gradient} instance from an SVG element
            /// </summary>
            public Gradient fromElement(object el, Object instance) { return null; }
            /// <summary>
            /// Constructor
            /// </summary>
            public Gradient initialize(Object options) { return null; }
            /// <summary>
            /// Returns an instance of CanvasGradient
            /// </summary>
            public object toLive(object ctx) { return null; }
            /// <summary>
            /// Returns object representation of a gradient
            /// </summary>
            public Object toFabricObject() { return null; }
            /// <summary>
            /// Returns SVG representation of an gradient
            /// </summary>
            public string toSVG(Object @object, bool normalize) { return null; }
        }
        #endregion
        #region Group
        /// <summary>
        /// </summary>
        public partial class Group : Object
        {
            /// <summary>
            /// Adds an object to a group; Then recalculates group's dimension, position.
            /// </summary>
            public Group addWithUpdate(Object @object) { return null; }
            /// <summary>
            /// Destroys a group (restoring state of its objects)
            /// </summary>
            public Group destroy() { return null; }
            /// <summary>
            /// Returns {@link fabric.Group} instance from an object representation
            /// </summary>
            public Group fromFabricObject(Object @object, Object options) { return null; }
            /// <summary>
            /// Checks whether this group was moved (since `saveCoords` was called last)
            /// </summary>
            public bool hasMoved() { return false; }
            /// <summary>
            /// Removes an object from a group; Then recalculates group's dimension, position.
            /// </summary>
            public Group removeWithUpdate(Object @object) { return null; }
            /// <summary>
            /// Saves coordinates of this instance (to be used together with `hasMoved`)
            /// </summary>
            public Group saveCoords() { return null; }
            /// <summary>
            /// Sets coordinates of all group objects
            /// </summary>
            public Group setFabricObjectsCoords() { return null; }
            /// <summary>
            /// Returns svg representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// Indicates that instances of this type are async
            /// </summary>
            public bool async { get; set; }
            /// <summary>
            /// Properties that are delegated to group objects when reading/writing
            /// </summary>
            public object delegatedProperties { get; set; }
        }
        #endregion
        #region Image
        /// <summary>
        /// </summary>
        public partial class Image : Object
        {
            public Image()
            {
            }

            public Image(object img)
            {
            }

            /// <summary>
            /// Applies filters assigned to this image (from "filters" array)
            /// </summary>
            public Image applyFilters(JsAction callback) { return null; }
            /// <summary>
            /// Returns {@link fabric.Image} instance from an SVG element
            /// </summary>
            public Image fromElement(object element, JsAction callback, Object options) { return null; }
            /// <summary>
            /// Creates an instance of fabric.Image from its object representation
            /// </summary>
            public void fromFabricObject(Object @object, JsAction callback) { }
            /// <summary>
            /// Creates an instance of fabric.Image from an URL string
            /// </summary>
            public void fromURL(string url, JsAction callback, Object imgOptions) { }
            /// <summary>
            /// Returns image element which this instance if based on
            /// </summary>
            public object getElement() { return null; }
            /// <summary>
            /// Returns original size of an image
            /// </summary>
            public Object getOriginalSize() { return null; }
            /// <summary>
            /// Returns source of an image
            /// </summary>
            public string getSrc() { return null; }
            /// <summary>
            /// Sets crossOrigin value (on an instance and corresponding image element)
            /// </summary>
            public Image setCrossOrigin() { return null; }
            /// <summary>
            /// Sets image element for this instance to a specified one.
            /// If filters defined they are applied to new image.
            /// You might need to call `canvas.renderAll` and `object.setCoords` after replacing, to render new image and update controls area.
            /// </summary>
            public Image setElement(object element, JsAction callback) { return null; }
            /// <summary>
            /// Returns SVG representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// Indicates that instances of this type are async
            /// </summary>
            public bool async { get; set; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by {@link fabric.Image.fromElement})
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
            /// <summary>
            /// crossOrigin value (one of "", "anonymous", "allow-credentials")
            /// </summary>
            public string crossOrigin { get; set; }
            /// <summary>
            /// Default CSS class name for canvas
            /// </summary>
            public string CSS_CANVAS { get; set; }
            /// <summary>
            /// Alias for getSrc
            /// </summary>
            public object getSvgSrc { get; set; }
            /// <summary>
            /// Indicates compression level used when generating PNG under Node (in applyFilters). Any of 0-9
            /// </summary>
            public JsNumber pngCompression { get; set; }

            public string src { get; set; }
            public string _src { get; set; }
        }
        #endregion
        #region Intersection
        /// <summary>
        /// fabric.Intersection
        /// </summary>
        public partial class Intersection
        {
            /// <summary>
            /// Appends a point to intersection
            /// </summary>
            public void appendPoint(Point point) { }
            /// <summary>
            /// Appends points to intersection
            /// </summary>
            public void appendPoints(object[] points) { }
        }
        #endregion
        #region IText
        /// <summary>
        /// </summary>
        public partial class IText : Text
        {
            /// <summary>
            /// Aborts cursor animation and clears all timeouts
            /// </summary>
            public void abortCursorAnimation() { }
            /// <summary>
            /// Copies selected text
            /// </summary>
            public void copy() { }
            /// <summary>
            /// Cuts text
            /// </summary>
            public void cut() { }
            /// <summary>
            /// Enters editing state
            /// </summary>
            public IText enterEditing() { return null; }
            /// <summary>
            /// Exits from editing state
            /// </summary>
            public IText exitEditing() { return null; }
            /// <summary>
            /// Find new selection index representing start of current line according to current selection index
            /// </summary>
            public void findLineBoundaryLeft(JsNumber current) { }
            /// <summary>
            /// Find new selection index representing end of current line according to current selection index
            /// </summary>
            public void findLineBoundaryRight(JsNumber current) { }
            /// <summary>
            /// Find new selection index representing start of current word according to current selection index
            /// </summary>
            public JsNumber findWordBoundaryLeft(JsNumber startFrom) { return null; }
            /// <summary>
            /// Find new selection index representing end of current word according to current selection index
            /// </summary>
            public JsNumber findWordBoundaryRight(JsNumber startFrom) { return null; }
            /// <summary>
            /// Forward delete
            /// </summary>
            public void forwardDelete() { }
            /// <summary>
            /// Returns 2d representation (lineIndex and charIndex) of cursor (or selection start)
            /// </summary>
            public void get2DCursorLocation(JsNumber selectionStart) { }
            /// <summary>
            /// Returns color (fill) of char at the current cursor
            /// </summary>
            public string getCurrentCharColor(JsNumber lineIndex, JsNumber charIndex) { return null; }
            /// <summary>
            /// Returns fontSize of char at the current cursor
            /// </summary>
            public JsNumber getCurrentCharFontSize(JsNumber lineIndex, JsNumber charIndex) { return null; }
            /// <summary>
            /// Gets start offset of a selection
            /// </summary>
            public JsNumber getDownCursorOffset() { return null; }
            /// <summary>
            /// Returns number of newlines in selected text
            /// </summary>
            public JsNumber getNumNewLinesInSelectedText() { return null; }
            /// <summary>
            /// Returns selected text
            /// </summary>
            public string getSelectedText() { return null; }
            /// <summary>
            /// Returns index of a character corresponding to where an object was clicked
            /// </summary>
            public JsNumber getSelectionStartFromPointer(object e) { return null; }
            /// <summary>
            /// Gets style of a current selection/cursor (at the start position)
            /// </summary>
            public Object getSelectionStyles(JsNumber startIndex, JsNumber endIndex) { return null; }
            /// <summary>
            /// Initializes all the interactive behavior of IText
            /// </summary>
            public void initBehavior() { }
            /// <summary>
            /// Initializes double and triple click event handlers
            /// </summary>
            public void initClicks() { }
            /// <summary>
            /// Initializes event handlers related to cursor or selection
            /// </summary>
            public void initCursorSelectionHandlers() { }
            /// <summary>
            /// Initializes delayed cursor
            /// </summary>
            public void initDelayedCursor() { }
            /// <summary>
            /// Initializes "dbclick" event handler
            /// </summary>
            public void initDoubleClickSimulation() { }
            /// <summary>
            /// Initializes hidden textarea (needed to bring up keyboard in iOS)
            /// </summary>
            public void initHiddenTextarea() { }
            /// <summary>
            /// Initializes key handlers
            /// </summary>
            public void initKeyHandlers() { }
            /// <summary>
            /// Initializes "mousedown" event handler
            /// </summary>
            public void initMousedownHandler() { }
            /// <summary>
            /// Initializes "mousemove" event handler
            /// </summary>
            public void initMousemoveHandler() { }
            /// <summary>
            /// Initializes "mouseup" event handler
            /// </summary>
            public void initMouseupHandler() { }
            /// <summary>
            /// Initializes "selected" event handler
            /// </summary>
            public void initSelectedHandler() { }
            /// <summary>
            /// Inserts a character where cursor is (replacing selection if one exists)
            /// </summary>
            public void insertChars(string _chars) { }
            /// <summary>
            /// Inserts style object for a given line/char index
            /// </summary>
            public void insertCharStyleFabricObject(JsNumber lineIndex, JsNumber charIndex, Object style) { }
            /// <summary>
            /// Inserts new line
            /// </summary>
            public void insertNewline() { }
            /// <summary>
            /// Inserts new style object
            /// </summary>
            public void insertNewlineStyleFabricObject(JsNumber lineIndex, JsNumber charIndex, bool isEndOfLine) { }
            /// <summary>
            /// Inserts style object(s)
            /// </summary>
            public void insertStyleFabricObjects(string _chars, bool isEndOfLine, object[] styles) { }
            /// <summary>
            /// Returns true if object has no styling
            /// </summary>
            public void isEmptyStyles() { }
            /// <summary>
            /// Moves cursor down
            /// </summary>
            public void moveCursorDown(object e) { }
            /// <summary>
            /// Moves cursor down without keeping selection
            /// </summary>
            public void moveCursorDownWithoutShift(JsNumber offset) { }
            /// <summary>
            /// Moves cursor down while keeping selection
            /// </summary>
            public void moveCursorDownWithShift(JsNumber offset) { }
            /// <summary>
            /// Moves cursor left
            /// </summary>
            public void moveCursorLeft(object e) { }
            /// <summary>
            /// Moves cursor left without keeping selection
            /// </summary>
            public void moveCursorLeftWithoutShift(object e) { }
            /// <summary>
            /// Moves cursor left while keeping selection
            /// </summary>
            public void moveCursorLeftWithShift(object e) { }
            /// <summary>
            /// Moves cursor right
            /// </summary>
            public void moveCursorRight(object e) { }
            /// <summary>
            /// Moves cursor right without keeping selection
            /// </summary>
            public void moveCursorRightWithoutShift(object e) { }
            /// <summary>
            /// Moves cursor right while keeping selection
            /// </summary>
            public void moveCursorRightWithShift(object e) { }
            /// <summary>
            /// Moves cursor up
            /// </summary>
            public void moveCursorUp(object e) { }
            /// <summary>
            /// Moves cursor up without shift
            /// </summary>
            public void moveCursorUpWithoutShift(JsNumber offset) { }
            /// <summary>
            /// Moves cursor up with shift
            /// </summary>
            public void moveCursorUpWithShift(JsNumber offset) { }
            /// <summary>
            /// Handles keyup event
            /// </summary>
            public void onKeyDown(object e) { }
            /// <summary>
            /// Handles keypress event
            /// </summary>
            public void onKeyPress(object e) { }
            /// <summary>
            /// Pastes text
            /// </summary>
            public void paste() { }
            /// <summary>
            /// Inserts a character where cursor is (replacing selection if one exists)
            /// </summary>
            public void removeChars() { }
            /// <summary>
            /// Removes style object
            /// </summary>
            public void removeStyleFabricObject(bool isBeginningOfLine, JsNumber index) { }
            /// <summary>
            /// Renders cursor
            /// </summary>
            public void renderCursor(Object boundaries) { }
            /// <summary>
            /// Renders cursor or selection (depending on what exists)
            /// </summary>
            public void renderCursorOrSelection() { }
            /// <summary>
            /// Renders text selection
            /// </summary>
            public void renderSelection(object[] chars, Object boundaries) { }
            /// <summary>
            /// Finds index corresponding to beginning or end of a word
            /// </summary>
            public void searchWordBoundary(JsNumber selectionStart, JsNumber direction) { }
            /// <summary>
            /// Selects entire text
            /// </summary>
            public void selectAll() { }
            /// <summary>
            /// Selects a line based on the index
            /// </summary>
            public void selectLine(JsNumber selectionStart) { }
            /// <summary>
            /// Selects a word based on the index
            /// </summary>
            public void selectWord(JsNumber selectionStart) { }
            /// <summary>
            /// Changes cursor location in a text depending on passed pointer (x/y) object
            /// </summary>
            public void setCursorByClick(Object pointer) { }
            /// <summary>
            /// Sets selection end (right boundary of a selection)
            /// </summary>
            public void setSelectionEnd(JsNumber index) { }
            /// <summary>
            /// Sets selection start (left boundary of a selection)
            /// </summary>
            public void setSelectionStart(JsNumber index) { }
            /// <summary>
            /// Sets style of a current selection
            /// </summary>
            public IText setSelectionStyles(Object styles) { return null; }
            /// <summary>
            /// Shifts line styles up or down
            /// </summary>
            public void shiftLineStyles(JsNumber lineIndex, JsNumber offset) { }
            /// <summary>
            /// Indicates whether internal text char widths can be cached
            /// </summary>
            public bool caching { get; set; }
            /// <summary>
            /// Color of default cursor (when not overwritten by character style)
            /// </summary>
            public string cursorColor { get; set; }
            /// <summary>
            /// Delay between cursor blink (in ms)
            /// </summary>
            public JsNumber cursorDelay { get; set; }
            /// <summary>
            /// Duration of cursor fadein (in ms)
            /// </summary>
            public JsNumber cursorDuration { get; set; }
            /// <summary>
            /// Width of cursor (in px)
            /// </summary>
            public JsNumber cursorWidth { get; set; }
            /// <summary>
            /// Indicates whether a text can be edited
            /// </summary>
            public bool editable { get; set; }
            /// <summary>
            /// Border color of text object while it's in editing mode
            /// </summary>
            public string editingBorderColor { get; set; }
            /// <summary>
            /// Indicates whether text is in editing mode
            /// </summary>
            public bool isEditing { get; set; }
            /// <summary>
            /// Color of text selection
            /// </summary>
            public string selectionColor { get; set; }
            /// <summary>
            /// Index where text selection ends
            /// </summary>
            public object selectionEnd { get; set; }
            /// <summary>
            /// Index where text selection starts (or where cursor is when there is no selection)
            /// </summary>
            public object selectionStart { get; set; }
            /// <summary>
            /// FabricObject containing character styles
            /// (where top-level properties corresponds to line number and 2nd-level properties -- to char number in a line)
            /// </summary>
            public Object styles { get; set; }
        }
        #endregion
        #region Line
        /// <summary>
        /// </summary>
        public partial class Line : Object
        {
            public Line() { }

            public Line(double[] points) { }

            public Line(double[] points, Object options) { }


            /// <summary>
            /// Returns fabric.Line instance from an SVG element
            /// </summary>
            public Line fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns fabric.Line instance from an object representation
            /// </summary>
            public Line fromObject(Object @object) { return null; }
            /// <summary>
            /// Returns SVG representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by {@link fabric.Line.fromElement})
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
        }
        #endregion

        #region FabricObject
        /// <summary>
        /// </summary>
        /// 

        [JsType(JsMode.Json, Name = "Object")]
        public partial class Object : Observable
        {
            public int id { get; set; }
            public int childId { get; set; }
            public int pointId { get; set; }

            /// <summary>
            /// </summary>
            public void adjustPosition(string to) { }
            /// <summary>
            /// Animates object's properties
            /// </summary>
            public Object animate(object property, object value) { return null; }
            /// <summary>
            /// Moves an object up in stack of drawn objects
            /// </summary>
            public Object bringForward(bool intersecting) { return null; }
            /// <summary>
            /// Moves an object to the top of the stack of drawn objects
            /// </summary>
            public Object bringToFront() { return null; }
            /// <summary>
            /// Centers object vertically and horizontally on canvas to which is was added last
            /// You might need to call `setCoords` on an object after centering, to update controls area.
            /// </summary>
            public Object center() { return null; }
            /// <summary>
            /// Centers object horizontally on canvas to which it was added last.
            /// You might need to call `setCoords` on an object after centering, to update controls area.
            /// </summary>
            public Object centerH() { return null; }
            /// <summary>
            /// Centers object vertically on canvas to which it was added last.
            /// You might need to call `setCoords` on an object after centering, to update controls area.
            /// </summary>
            public Object centerV() { return null; }
            /// <summary>
            /// Clones an instance
            /// </summary>
            public Object clone(JsAction<Object> callback, object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Creates an instance of fabric.Image out of an object
            /// </summary>
            public Object cloneAsImage(JsAction<Image> callback) { return null; }
            /// <summary>
            /// Returns complexity of an instance
            /// </summary>
            public JsNumber complexity() { return null; }
            /// <summary>
            /// Checks if point is inside the object
            /// </summary>
            public bool containsPoint(Point point) { return false; }
            /// <summary>
            /// Draws borders of an object's bounding box.
            /// Requires public properties: width, height
            /// Requires public options: padding, borderColor
            /// </summary>
            public Object drawBorders(object ctx) { return null; }
            /// <summary>
            /// Draws corners of an object's bounding box.
            /// Requires public properties: width, height, scaleX, scaleY
            /// Requires public options: cornerSize, padding
            /// </summary>
            public Object drawControls(object ctx) { return null; }
            /// <summary>
            /// Same as {@link fabric.FabricObject.prototype.straighten} but with animation
            /// </summary>
            public Object fxStraighten(JsAction callbacks, JsAction callbacks_onComplete, JsAction callbacks_onChange) { return null; }
            /// <summary>
            /// Basic getter
            /// </summary>
            public object get(string property) { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#angle|angle} (in degrees)
            /// </summary>
            public JsNumber getAngle() { return null; }
            /// <summary>
            /// Returns coordinates of object's bounding rectangle (left, top, width, height)
            /// </summary>
            public Object getBoundingRect() { return null; }
            /// <summary>
            /// Returns height of an object's bounding rectangle
            /// </summary>
            public JsNumber getBoundingRectHeight() { return null; }
            /// <summary>
            /// Returns width of an object's bounding rectangle
            /// </summary>
            public JsNumber getBoundingRectWidth() { return null; }
            /// <summary>
            /// Returns the real center coordinates of the object
            /// </summary>
            public Point getCenterPoint() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#clipTo|clipping function}
            /// </summary>
            public object getClipTo() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#fill|fill}
            /// </summary>
            public string getFill() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#flipX|flipX} value
            /// </summary>
            public bool getFlipX() { return false; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#flipY|flipY} value
            /// </summary>
            public bool getFlipY() { return false; }
            /// <summary>
            /// Returns height of an object
            /// </summary>
            public JsNumber getHeight() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#left|left position}
            /// </summary>
            public JsNumber getLeft() { return null; }
            /// <summary>
            /// Returns coordinates of a pointer relative to an object
            /// </summary>
            public Object getLocalPointer(object e, Object pointer) { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#opacity|opacity}
            /// </summary>
            public JsNumber getOpacity() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#originX|originX}
            /// </summary>
            public string getOriginX() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#originY|originY}
            /// </summary>
            public string getOriginY() { return null; }
            /// <summary>
            /// Returns the coordinates of the object as if it has a different origin
            /// </summary>
            public Point getPointByOrigin(string originX, string originY) { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#scaleX|scaleX} value
            /// </summary>
            public JsNumber getScaleX() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#scaleY|scaleY} value
            /// </summary>
            public JsNumber getScaleY() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#shadow|shadow}
            /// </summary>
            public Object getShadow() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#stroke|stroke}
            /// </summary>
            public string getStroke() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#strokeWidth|strokeWidth}
            /// </summary>
            public JsNumber getStrokeWidth() { return null; }
            /// <summary>
            /// Returns styles-string for svg-export
            /// </summary>
            public string getSvgStyles() { return null; }
            /// <summary>
            /// Returns transform-string for svg-export
            /// </summary>
            public string getSvgTransform() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#top|top position}
            /// </summary>
            public JsNumber getTop() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#transformMatrix|transformMatrix}
            /// </summary>
            public object[] getTransformMatrix() { return null; }
            /// <summary>
            /// Retrieves object's {@link fabric.FabricObject#visible|visible} state
            /// </summary>
            public bool getVisible() { return false; }
            /// <summary>
            /// Returns width of an object
            /// </summary>
            public JsNumber getWidth() { return null; }
            /// <summary>
            /// Returns true if object state (one of its state properties) was changed
            /// </summary>
            public bool hasStateChanged() { return false; }
            /// <summary>
            /// Constructor
            /// </summary>
            public void initialize(Object options) { }
            /// <summary>
            /// Checks if object intersects with another object
            /// </summary>
            public bool intersectsWithFabricObject(Object other) { return false; }
            /// <summary>
            /// Checks if object intersects with an area formed by 2 points
            /// </summary>
            public bool intersectsWithRect(Object pointTL, Object pointBR) { return false; }
            /// <summary>
            /// Checks if object is fully contained within area of another object
            /// </summary>
            public bool isContainedWithinFabricObject(Object other) { return false; }
            /// <summary>
            /// Checks if object is fully contained within area formed by 2 points
            /// </summary>
            public bool isContainedWithinRect(Object pointTL, Object pointBR) { return false; }
            /// <summary>
            /// Returns true if the specified control is visible, false otherwise.
            /// </summary>
            public bool isControlVisible(string controlName) { return false; }
            /// <summary>
            /// Returns true if specified type is identical to the type of an instance
            /// </summary>
            public bool isType(ObjectType type) { return false; }

            public bool isType(string type) { return false; }
            /// <summary>
            /// Moves an object to specified level in stack of drawn objects
            /// </summary>
            public Object moveTo(JsNumber index) { return null; }
            /// <summary>
            /// Removes object from canvas to which it was added last
            /// </summary>
            public Object remove() { return null; }
            /// <summary>
            /// Renders an object on a specified context
            /// </summary>
            public void render(object ctx, bool noTransform) { }
            /// <summary>
            /// Saves state of an object
            /// </summary>
            public Object saveState(Object options) { return null; }
            /// <summary>
            /// Scales an object (equally by x and y)
            /// </summary>
            public Object scale(JsNumber value) { return null; }
            /// <summary>
            /// Scales an object to a given height, with respect to bounding box (scaling by x/y equally)
            /// </summary>
            public Object scaleToHeight(JsNumber value) { return null; }
            /// <summary>
            /// Scales an object to a given width, with respect to bounding box (scaling by x/y equally)
            /// </summary>
            public Object scaleToWidth(JsNumber value) { return null; }
            /// <summary>
            /// Moves an object down in stack of drawn objects
            /// </summary>
            public Object sendBackwards(bool intersecting) { return null; }
            /// <summary>
            /// Moves an object to the bottom of the stack of drawn objects
            /// </summary>
            public Object sendToBack() { return null; }
            /// <summary>
            /// Sets property to a given value. When changing position/dimension -related properties (left, top, scale, angle, etc.) `set` does not update position of object's borders/controls. If you need to update those, call `setCoords()`.
            /// </summary>
            public Object set(string key, object value) { return null; }

            public Object set(object anom) { return null; }

            /// <summary>
            /// Sets object's {@link fabric.FabricObject#angle|angle}
            /// </summary>
            public Object setAngle(JsNumber value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#clipTo|clipping function}
            /// </summary>
            public Object setClipTo(object clipTo) { return null; }
            /// <summary>
            /// Sets "color" of an instance (alias of `set('fill', &hellip;)`)
            /// </summary>
            public Text setColor(string color) { return null; }
            /// <summary>
            /// Sets the visibility state of object controls.
            /// </summary>
            public Object setControlsVisibility(VisibilityOpt opts) { return null; }
            /// <summary>
            /// Sets the visibility of the specified control.
            /// </summary>
            public Object setControlVisible(string controlName, bool visible) { return null; }
            /// <summary>
            /// Sets corner position coordinates based on current angle, width and height
            /// </summary>
            public Object setCoords() { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#fill|fill}
            /// </summary>
            public Object setFill(string value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#flipX|flipX} value
            /// </summary>
            public Object setFlipX(bool value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#flipY|flipY} value
            /// </summary>
            public Object setFlipY(bool value) { return null; }
            /// <summary>
            /// Sets gradient (fill or stroke) of an object
            /// <b>Backwards incompatibility note:</b> This method was named "setGradientFill" until v1.1.0
            /// </summary>
            public Object setGradient(string property, Object options, string options_type, JsNumber options_x1, JsNumber options_y1, JsNumber options_x2, JsNumber options_y2, JsNumber options_r1, JsNumber options_r2, Object options_colorStops) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#left|left position}
            /// </summary>
            public Object setLeft(JsNumber value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#opacity|opacity}
            /// </summary>
            public Object setOpacity(JsNumber value) { return null; }
            /// <summary>
            /// Sets object's properties from options
            /// </summary>
            public void setOptions(Object options) { }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#originX|originX}
            /// </summary>
            public Object setOriginX(string value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#originY|originY}
            /// </summary>
            public Object setOriginY(string value) { return null; }
            /// <summary>
            /// Sets pattern fill of an object
            /// </summary>
            public Object setPatternFill(Object options, object options_source, string options_repeat, JsNumber options_offsetX, JsNumber options_offsetY) { return null; }
            /// <summary>
            /// Sets the position of the object taking into consideration the object's origin
            /// </summary>
            public void setPositionByOrigin(Point point, string originX, string originY) { }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#scaleX|scaleX} value
            /// </summary>
            public Object setScaleX(JsNumber value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#scaleY|scaleY} value
            /// </summary>
            public Object setScaleY(JsNumber value) { return null; }
            /// <summary>
            /// Sets {@link fabric.FabricObject#shadow|shadow} of an object
            /// </summary>
            public Object setShadow(object options, string options_color, JsNumber options_blur, JsNumber options_offsetX, JsNumber options_offsetY) { return null; }
            /// <summary>
            /// Sets sourcePath of an object
            /// </summary>
            public Object setSourcePath(string value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#stroke|stroke}
            /// </summary>
            public Object setStroke(string value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#strokeWidth|strokeWidth}
            /// </summary>
            public Object setStrokeWidth(JsNumber value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#top|top position}
            /// </summary>
            public Object setTop(JsNumber value) { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#transformMatrix|transformMatrix}
            /// </summary>
            public Object setTransformMatrix(object[] transformMatrix) { return null; }
            /// <summary>
            /// Setups state of an object
            /// </summary>
            public Object setupState() { return null; }
            /// <summary>
            /// Sets object's {@link fabric.FabricObject#visible|visible} state
            /// </summary>
            public Object setVisible(bool value) { return null; }
            /// <summary>
            /// Straightens an object (rotating it from current angle to one of 0, 90, 180, 270, etc. depending on which is closer)
            /// </summary>
            public Object straighten() { return null; }
            /// <summary>
            /// Returns (dataless) object representation of an instance
            /// </summary>
            public Object toDatalessFabricObject(object[] propertiesToInclude) { return null; }

            public string toDataURL() { return null; }

            /// <summary>
            /// Converts an object into a data-url-like string
            /// </summary>
            public string toDataURL(Object options, string options_format, JsNumber options_quality, JsNumber options_multiplier, JsNumber options_left, JsNumber options_top, JsNumber options_width, JsNumber options_height) { return null; }
            /// <summary>
            /// Toggles specified property from `true` to `false` or from `false` to `true`
            /// </summary>
            public Object toggle(string property) { return null; }
            /// <summary>
            /// Returns a JSON representation of an instance
            /// </summary>
            public Object toJSON(object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Returns the point in local coordinates
            /// </summary>
            public Point toLocalPoint(Point point, string originX, string originY) { return null; }
            /// <summary>
            /// Returns an object representation of an instance
            /// </summary>
            public Object toObject(object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Returns a string representation of an instance
            /// </summary>
            public string toString() { return null; }
            /// <summary>
            /// Transforms context when rendering an object
            /// </summary>
            public void transform(object ctx, bool fromLeft) { }
            /// <summary>
            /// Translates the coordinates from origin to center coordinates (based on the object's dimensions)
            /// </summary>
            public Point translateToCenterPoint(Point point, string originX, string originY) { return null; }
            /// <summary>
            /// Translates the coordinates from center to origin coordinates (based on the object's dimensions)
            /// </summary>
            public Point translateToOriginPoint(Point point, string originX, string originY) { return null; }
            /// <summary>
            /// Unique id used internally when creating SVG elements
            /// </summary>
            public JsNumber __uid { get; set; }
            /// <summary>
            /// Angle of rotation of an object (in degrees)
            /// </summary>
            public JsNumber angle { get; set; }
            /// <summary>
            /// Background color of an object. Only works with text objects at the moment.
            /// </summary>
            public string backgroundColor { get; set; }
            /// <summary>
            /// Color of controlling borders of an object (when it's active)
            /// </summary>
            public string borderColor { get; set; }
            /// <summary>
            /// Opacity of object's controlling borders when object is active and moving
            /// </summary>
            public JsNumber borderOpacityWhenMoving { get; set; }
            /// <summary>
            /// Scale factor of object's controlling borders
            /// </summary>
            public JsNumber borderScaleFactor { get; set; }
            /// <summary>
            /// When true, this object will use center point as the origin of transformation
            /// when being rotated via the controls.
            /// <b>Backwards incompatibility note:</b> This property replaces "centerTransform" (Boolean).
            /// </summary>
            public bool centeredRotation { get; set; }
            /// <summary>
            /// When true, this object will use center point as the origin of transformation
            /// when being scaled via the controls.
            /// <b>Backwards incompatibility note:</b> This property replaces "centerTransform" (Boolean).
            /// </summary>
            public bool centeredScaling { get; set; }
            /// <summary>
            /// Function that determines clipping of an object (context is passed as a first argument)
            /// </summary>
            public object clipTo { get; set; }
            /// <summary>
            /// Color of controlling corners of an object (when it's active)
            /// </summary>
            public string cornerColor { get; set; }
            /// <summary>
            /// Size of object's controlling corners (in pixels)
            /// </summary>
            public JsNumber cornerSize { get; set; }
            /// <summary>
            /// When set to `false`, an object can not be a target of events. All events propagate through it. Introduced in v1.3.4
            /// </summary>
            public bool evented { get; set; }
            /// <summary>
            /// Color of object's fill
            /// </summary>
            public string fill { get; set; }
            /// <summary>
            /// Fill rule used to fill an object
            /// </summary>
            public string fillRule { get; set; }
            /// <summary>
            /// When true, an object is rendered as flipped horizontally
            /// </summary>
            public bool flipX { get; set; }
            /// <summary>
            /// When true, an object is rendered as flipped vertically
            /// </summary>
            public bool flipY { get; set; }
            /// <summary>
            /// When set to `false`, object's controlling borders are not rendered
            /// </summary>
            public bool hasBorders { get; set; }
            /// <summary>
            /// When set to `false`, object's controls are not displayed and can not be used to manipulate object
            /// </summary>
            public bool hasControls { get; set; }
            /// <summary>
            /// When set to `false`, object's controlling rotating point will not be visible or selectable
            /// </summary>
            public bool hasRotatingPoint { get; set; }
            /// <summary>
            /// FabricObject height
            /// </summary>
            public JsNumber height { get; set; }
            /// <summary>
            /// Default cursor value used when hovering over this object on canvas
            /// </summary>
            public string hoverCursor { get; set; }
            /// <summary>
            /// When `false`, default object's values are not included in its serialization
            /// </summary>
            public bool includeDefaultValues { get; set; }
            /// <summary>
            /// Left position of an object. Note that by default it's relative to object center. You can change this by setting originX={left/center/right}
            /// </summary>
            public JsNumber left { get; set; }
            /// <summary>
            /// When `true`, object horizontal movement is locked
            /// </summary>
            public bool lockMovementX { get; set; }
            /// <summary>
            /// When `true`, object vertical movement is locked
            /// </summary>
            public bool lockMovementY { get; set; }
            /// <summary>
            /// When `true`, object rotation is locked
            /// </summary>
            public bool lockRotation { get; set; }
            /// <summary>
            /// When `true`, object horizontal scaling is locked
            /// </summary>
            public bool lockScalingX { get; set; }
            /// <summary>
            /// When `true`, object vertical scaling is locked
            /// </summary>
            public bool lockScalingY { get; set; }
            /// <summary>
            /// When `true`, object non-uniform scaling is locked
            /// </summary>
            public bool lockUniScaling { get; set; }
            /// <summary>
            /// Minimum allowed scale value of an object
            /// </summary>
            public JsNumber minScaleLimit { get; set; }
            /// <summary>
            /// FabricObject containing coordinates of object's controls
            /// </summary>
            public Object oCoords { get; set; }
            /// <summary>
            /// Opacity of an object
            /// </summary>
            public JsNumber opacity { get; set; }
            /// <summary>
            /// Horizontal origin of transformation of an object (one of "left", "right", "center")
            /// </summary>
            public string originX { get; set; }
            /// <summary>
            /// Vertical origin of transformation of an object (one of "top", "bottom", "center")
            /// </summary>
            public string originY { get; set; }
            /// <summary>
            /// Padding between object and its controlling borders (in pixels)
            /// </summary>
            public JsNumber padding { get; set; }
            /// <summary>
            /// When set to `true`, objects are "found" on canvas on per-pixel basis rather than according to bounding box
            /// </summary>
            public bool perPixelTargetFind { get; set; }
            /// <summary>
            /// Alias for {@link fabric.FabricObject.prototype.setAngle}
            /// </summary>
            public object rotate { get; set; }
            /// <summary>
            /// Offset for object's controlling rotating point (when enabled via `hasRotatingPoint`)
            /// </summary>
            public JsNumber rotatingPointOffset { get; set; }
            /// <summary>
            /// FabricObject scale factor (horizontal)
            /// </summary>
            public JsNumber scaleX { get; set; }
            /// <summary>
            /// FabricObject scale factor (vertical)
            /// </summary>
            public JsNumber scaleY { get; set; }
            /// <summary>
            /// When set to `false`, an object can not be selected for modification (using either point-click-based or group-based selection).
            /// But events still fire on it.
            /// </summary>
            public bool selectable { get; set; }
            /// <summary>
            /// Shadow object representing shadow of this shape
            /// </summary>
            public Shadow shadow { get; set; }
            /// <summary>
            /// List of properties to consider when checking if state
            /// of an object is changed (fabric.FabricObject#hasStateChanged)
            /// as well as for history (undo/redo) purposes
            /// </summary>
            public object[] stateProperties { get; set; }
            /// <summary>
            /// When defined, an object is rendered via stroke and this property specifies its color
            /// </summary>
            public string stroke { get; set; }
            /// <summary>
            /// Array specifying dash pattern of an object's stroke (stroke must be defined)
            /// </summary>
            public object[] strokeDashArray { get; set; }
            /// <summary>
            /// Line endings style of an object's stroke (one of "butt", "round", "square")
            /// </summary>
            public string strokeLineCap { get; set; }
            /// <summary>
            /// Corner style of an object's stroke (one of "bevil", "round", "miter")
            /// </summary>
            public string strokeLineJoin { get; set; }
            /// <summary>
            /// Maximum miter length (used for strokeLineJoin = "miter") of an object's stroke
            /// </summary>
            public JsNumber strokeMiterLimit { get; set; }
            /// <summary>
            /// Width of a stroke used to render this object
            /// </summary>
            public JsNumber strokeWidth { get; set; }
            /// <summary>
            /// Top position of an object. Note that by default it's relative to object center. You can change this by setting originY={top/center/bottom}
            /// </summary>
            public JsNumber top { get; set; }

            public double radius { get; set; }
            /// <summary>
            /// Transform matrix (similar to SVG's transform matrix)
            /// </summary>
            public object[] transformMatrix { get; set; }
            /// <summary>
            /// When true, object's controlling corners are rendered as transparent inside (i.e. stroke instead of fill)
            /// </summary>
            public bool transparentCorners { get; set; }
            /// <summary>
            /// Type of an object (rect, circle, path, etc.)
            /// </summary>
            public ObjectType type { get; set; }
            /// <summary>
            /// When set to `false`, an object is not rendered on canvas
            /// </summary>
            public bool visible { get; set; }
            /// <summary>
            /// FabricObject width
            /// </summary>
            public JsNumber width { get; set; }

        }
        #endregion

        #region Observable
        /// <summary>
        /// </summary>
        public partial class Observable
        {


            /// <summary>
            /// Stops event observing for a particular event handler. Calling this method
            /// without arguments removes all handlers for all events
            /// </summary>
            public Object off(string eventName, JsAction<EventOptions> handler) { return null; }
            /// <summary>
            /// Observes specified event
            /// </summary>
            public Object on(string eventName, JsAction<EventOptions> handler) { return null; }
            /// <summary>
            /// Fires event with an optional options object
            /// </summary>
            public Object trigger(string eventName, EventOptions options) { return null; }
        }
        #endregion

        #region Path
        /// <summary>
        /// </summary>
        public partial class Path : Object
        {
            /// <summary>
            /// Creates an instance of fabric.Path from an SVG <path> element
            /// </summary>
            public void fromElement(object element, JsAction callback, Object options) { }
            /// <summary>
            /// Creates an instance of fabric.Path from an object
            /// </summary>
            public void fromFabricObject(Object @object, JsAction callback) { }
            /// <summary>
            /// Returns svg representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// Indicates that instances of this type are async
            /// </summary>
            public bool async { get; set; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by `fabric.Path.fromElement`)
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
        }
        #endregion
        #region PathGroup
        /// <summary>
        /// </summary>
        public partial class PathGroup : Path
        {
            /// <summary>
            /// Returns all paths in this path group
            /// </summary>
            public object[] getFabricObjects() { return null; }
            /// <summary>
            /// Returns true if all paths in this group are of same color
            /// </summary>
            public bool isSameColor() { return false; }
        }
        #endregion
        #region Pattern
        /// <summary>
        /// </summary>
        public partial class Pattern
        {
            /// <summary>
            /// Constructor
            /// </summary>
            public Pattern initialize(Object options) { return null; }
            /// <summary>
            /// Returns an instance of CanvasPattern
            /// </summary>
            public object toLive(object ctx) { return null; }
            /// <summary>
            /// Returns object representation of a pattern
            /// </summary>
            public Object toFabricObject() { return null; }
            /// <summary>
            /// Returns SVG representation of a pattern
            /// </summary>
            public string toSVG(Object @object) { return null; }
            /// <summary>
            /// Pattern horizontal offset from object's left/top corner
            /// </summary>
            public JsNumber offsetX { get; set; }
            /// <summary>
            /// Pattern vertical offset from object's left/top corner
            /// </summary>
            public JsNumber offsetY { get; set; }
            /// <summary>
            /// Repeat property of a pattern (one of repeat, repeat-x, repeat-y or no-repeat)
            /// </summary>
            public string repeat { get; set; }
        }
        #endregion
        #region PatternBrush
        /// <summary>
        /// </summary>
        public partial class PatternBrush : BaseBrush
        {
            /// <summary>
            /// Creates path
            /// </summary>
            public void createPath() { }
            /// <summary>
            /// Creates "pattern" instance property
            /// </summary>
            public void getPattern() { }
        }
        #endregion
        #region PencilBrush
        /// <summary>
        /// </summary>
        public partial class PencilBrush : BaseBrush
        {
            /// <summary>
            /// On mouseup after drawing the path on contextTop canvas
            /// we use the points captured to create an new fabric path object
            /// and add it to the fabric canvas.
            /// </summary>
            public void _finalizeAndAddPath() { }
            /// <summary>
            /// </summary>
            public void _prepareForDrawing(Object pointer) { }
            /// <summary>
            /// Converts points to SVG path
            /// </summary>
            public string convertPointsToSVGPath(object[] points) { return null; }
            /// <summary>
            /// Creates fabric.Path object to add on canvas
            /// </summary>
            public Path createPath(string pathData) { return null; }
            /// <summary>
            /// Returns bounding box of a path based on given points
            /// </summary>
            public Object getPathBoundingBox(object[] points) { return null; }
            /// <summary>
            /// Constructor
            /// </summary>
            public PencilBrush initialize(fabric.Canvas canvas) { return null; }
            /// <summary>
            /// Inovoked on mouse down
            /// </summary>
            public void onMouseDown(Object pointer) { }
            /// <summary>
            /// Inovoked on mouse move
            /// </summary>
            public void onMouseMove(Object pointer) { }
            /// <summary>
            /// Invoked on mouse up
            /// </summary>
            public void onMouseUp() { }
        }
        #endregion
        #region Point
        /// <summary>
        /// fabric.Point
        /// </summary>
        public partial class Point
        {
            public double x { get; set; }
            public double y { get; set; }

            /// <summary>
            /// Adds another point to this one and returns another one
            /// </summary>
            public Point add(Point that) { return null; }
            /// <summary>
            /// Adds another point to this one
            /// </summary>
            public Point addEquals(Point that) { return null; }
            /// <summary>
            /// Returns distance from this point and another one
            /// </summary>
            public JsNumber distanceFrom(Point that) { return null; }
            /// <summary>
            /// Divides this point by a value and returns a new one
            /// </summary>
            public Point divide(JsNumber scalar) { return null; }
            /// <summary>
            /// Divides this point by a value
            /// </summary>
            public Point divideEquals(JsNumber scalar) { return null; }
            /// <summary>
            /// Returns true if this point is equal to another one
            /// </summary>
            public bool eq(Point that) { return false; }
            /// <summary>
            /// Returns true if this point is greater another one
            /// </summary>
            public bool gt(Point that) { return false; }
            /// <summary>
            /// Returns true if this point is greater than or equal to another one
            /// </summary>
            public bool gte(Point that) { return false; }
            /// <summary>
            /// Returns new point which is the result of linear interpolation with this one and another one
            /// </summary>
            public Point lerp(Point that, JsNumber t) { return null; }
            /// <summary>
            /// Returns true if this point is less than another one
            /// </summary>
            public bool lt(Point that) { return false; }
            /// <summary>
            /// Returns true if this point is less than or equal to another one
            /// </summary>
            public bool lte(Point that) { return false; }
            /// <summary>
            /// Returns a new point which is the max of this and another one
            /// </summary>
            public Point max(Point that) { return null; }
            /// <summary>
            /// Returns the point between this point and another one
            /// </summary>
            public Point midPointFrom(Point that) { return null; }
            /// <summary>
            /// Returns a new point which is the min of this and another one
            /// </summary>
            public Point min(Point that) { return null; }
            /// <summary>
            /// Miltiplies this point by a value and returns a new one
            /// </summary>
            public Point multiply(JsNumber scalar) { return null; }
            /// <summary>
            /// Miltiplies this point by a value
            /// </summary>
            public Point multiplyEquals(JsNumber scalar) { return null; }
            /// <summary>
            /// Adds value to this point and returns a new one
            /// </summary>
            public Point scalarAdd(JsNumber scalar) { return null; }
            /// <summary>
            /// Adds value to this point
            /// </summary>
            public void scalarAddEquals(JsNumber scalar, Point thisArg) { }
            /// <summary>
            /// Subtracts value from this point and returns a new one
            /// </summary>
            public Point scalarSubtract(JsNumber scalar) { return null; }
            /// <summary>
            /// Subtracts value from this point
            /// </summary>
            public Point scalarSubtractEquals(JsNumber scalar) { return null; }
            /// <summary>
            /// Sets x/y of this point from another point
            /// </summary>
            public void setFromPoint(Point that) { }
            /// <summary>
            /// Sets x/y of this point
            /// </summary>
            public JsNumber setXY(JsNumber x) { return null; }
            /// <summary>
            /// Subtracts another point from this point and returns a new one
            /// </summary>
            public Point subtract(Point that) { return null; }
            /// <summary>
            /// Subtracts another point from this point
            /// </summary>
            public Point subtractEquals(Point that) { return null; }
            /// <summary>
            /// Swaps x/y of this point and another point
            /// </summary>
            public void swap(Point that) { }
            /// <summary>
            /// Returns string representation of this point
            /// </summary>
            public string toString() { return null; }
        }
        #endregion
        #region Polygon
        /// <summary>
        /// </summary>
        public partial class Polygon : Object
        {
            public Polygon() { }

            public Polygon(Point[] points) { }

            public Polygon(Point[] points, Object options) { }


            /// <summary>
            /// Returns {@link fabric.Polygon} instance from an SVG element
            /// </summary>
            public Polygon fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns fabric.Polygon instance from an object representation
            /// </summary>
            public Polygon fromFabricObject(Object @object) { return null; }
            /// <summary>
            /// Returns svg representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by `fabric.Polygon.fromElement`)
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
        }
        #endregion
        #region Polyline
        /// <summary>
        /// </summary>
        public partial class Polyline : Object
        {
            /// <summary>
            /// Returns fabric.Polyline instance from an SVG element
            /// </summary>
            public Polyline fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns fabric.Polyline instance from an object representation
            /// </summary>
            public Polyline fromFabricObject(Object @object) { return null; }
            /// <summary>
            /// Returns SVG representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by {@link fabric.Polyline.fromElement})
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
        }
        #endregion
        #region Rect
        /// <summary>
        /// </summary>
        public partial class Rect : Object
        {
            /// <summary>
            /// Returns {@link fabric.Rect} instance from an SVG element
            /// </summary>
            public Rect fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns {@link fabric.Rect} instance from an object representation
            /// </summary>
            public Object fromFabricObject(Object @object) { return null; }
            /// <summary>
            /// Returns svg representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by `fabric.Rect.fromElement`)
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
            /// <summary>
            /// Horizontal border radius
            /// </summary>
            public JsNumber rx { get; set; }
            /// <summary>
            /// Vertical border radius
            /// </summary>
            public JsNumber ry { get; set; }
            /// <summary>
            /// </summary>
            public JsNumber x { get; set; }
            /// <summary>
            /// </summary>
            public JsNumber y { get; set; }
        }
        #endregion
        #region Shadow
        /// <summary>
        /// </summary>
        public partial class Shadow
        {
            /// <summary>
            /// Constructor
            /// </summary>
            public Shadow initialize(object options) { return null; }
            /// <summary>
            /// Returns object representation of a shadow
            /// </summary>
            public Object toFabricObject() { return null; }
            /// <summary>
            /// Returns a string representation of an instance
            /// </summary>
            public string toString() { return null; }
            /// <summary>
            /// Returns SVG representation of a shadow
            /// </summary>
            public string toSVG(Object @object) { return null; }
            /// <summary>
            /// Whether the shadow should affect stroke operations
            /// </summary>
            public bool affectStroke { get; set; }
            /// <summary>
            /// Shadow blur
            /// </summary>
            public JsNumber blur { get; set; }
            /// <summary>
            /// Shadow color
            /// </summary>
            public string color { get; set; }
            /// <summary>
            /// Indicates whether toFabricObject should include default values
            /// </summary>
            public bool includeDefaultValues { get; set; }
            /// <summary>
            /// Shadow horizontal offset
            /// </summary>
            public JsNumber offsetX { get; set; }
            /// <summary>
            /// Shadow vertical offset
            /// </summary>
            public JsNumber offsetY { get; set; }
            /// <summary>
            /// Regex matching shadow offsetX, offsetY and blur (ex: "2px 2px 10px rgba(0,0,0,0.2)", "rgb(0,255,0) 2px 2px")
            /// </summary>
            public object reOffsetsAndBlur { get; set; }
        }
        #endregion
        #region SprayBrush
        /// <summary>
        /// </summary>
        public partial class SprayBrush
        {
            /// <summary>
            /// </summary>
            public void addSprayChunk(Object pointer) { }
            /// <summary>
            /// Constructor
            /// </summary>
            public SprayBrush initialize(fabric.Canvas canvas) { return null; }
            /// <summary>
            /// Invoked on mouse down
            /// </summary>
            public void onMouseDown(Object pointer) { }
            /// <summary>
            /// Invoked on mouse move
            /// </summary>
            public void onMouseMove(Object pointer) { }
            /// <summary>
            /// Invoked on mouse up
            /// </summary>
            public void onMouseUp() { }
            /// <summary>
            /// Renders brush
            /// </summary>
            public void render() { }
            /// <summary>
            /// Density of a spray (number of dots per chunk)
            /// </summary>
            public JsNumber density { get; set; }
            /// <summary>
            /// Width of spray dots
            /// </summary>
            public JsNumber dotWidth { get; set; }
            /// <summary>
            /// Width variance of spray dots
            /// </summary>
            public JsNumber dotWidthVariance { get; set; }
            /// <summary>
            /// Whether overlapping dots (rectangles) should be removed (for performance reasons)
            /// </summary>
            public bool optimizeOverlapping { get; set; }
            /// <summary>
            /// Whether opacity of a dot should be random
            /// </summary>
            public bool randomOpacity { get; set; }
            /// <summary>
            /// Width of a spray
            /// </summary>
            public JsNumber width { get; set; }
        }
        #endregion
        #region StaticCanvas
        /// <summary>
        /// </summary>
        public partial class StaticCanvas : Observable
        {
            public Object _offset { get; set; }

            public double width { get; set; }

            public double height { get; set; }

            /// <summary>
            /// Moves an object up in stack of drawn objects
            /// </summary>
            public fabric.Canvas bringForward(Object @object, bool intersecting) { return null; }
            /// <summary>
            /// Moves an object to the top of the stack of drawn objects
            /// </summary>
            public fabric.Canvas bringToFront(Object @object) { return null; }
            /// <summary>
            /// Calculates canvas element offset relative to the document
            /// This method is also attached as "resize" event handler of window
            /// </summary>
            public fabric.Canvas calcOffset() { return null; }
            /// <summary>
            /// Centers object vertically and horizontally.
            /// You might need to call `setCoords` on an object after centering, to update controls area.
            /// </summary>
            public fabric.Canvas centerObject(Object @object) { return null; }
            /// <summary>
            /// Centers object horizontally.
            /// You might need to call `setCoords` on an object after centering, to update controls area.
            /// </summary>
            public fabric.Canvas centerObjectH(Object @object) { return null; }
            /// <summary>
            /// Centers object vertically.
            /// You might need to call `setCoords` on an object after centering, to update controls area.
            /// </summary>
            public fabric.Canvas centerObjectV(Object @object) { return null; }
            /// <summary>
            /// Clears all contexts (background, main, top) of an instance
            /// </summary>
            public fabric.Canvas clear() { return null; }
            /// <summary>
            /// Clears specified context of canvas element
            /// </summary>
            public fabric.Canvas clearContext(object ctx) { return null; }
            /// <summary>
            /// Clones canvas instance
            /// </summary>
            public void clone(JsAction callback, object[] properties) { }
            /// <summary>
            /// Clones canvas instance without cloning existing data.
            /// This essentially copies canvas dimensions, clipping properties, etc.
            /// but leaves data empty (so that you can populate it with your own)
            /// </summary>
            public void cloneWithoutData(JsAction callback) { }
            /// <summary>
            /// </summary>
            public void createPNGStream() { }
            /// <summary>
            /// Clears a canvas element and removes all event listeners
            /// </summary>
            public fabric.Canvas dispose() { return null; }
            /// <summary>
            /// Centers object horizontally with animation.
            /// </summary>
            public fabric.Canvas fxCenterObjectH(Object @object, JsAction callbacks, JsAction callbacks_onComplete, JsAction callbacks_onChange) { return null; }
            /// <summary>
            /// Centers object vertically with animation.
            /// </summary>
            public fabric.Canvas fxCenterObjectV(Object @object, JsAction callbacks, JsAction callbacks_onComplete, JsAction callbacks_onChange) { return null; }
            /// <summary>
            /// Same as `fabric.Canvas#remove` but animated
            /// </summary>
            public fabric.Canvas fxRemove(Object @object, JsAction callbacks, JsAction callbacks_onComplete, JsAction callbacks_onChange) { return null; }
            /// <summary>
            /// Same as {@link fabric.Canvas.prototype.straightenFabricObject}, but animated
            /// </summary>
            public fabric.Canvas fxStraightenObject(Object @object) { return null; }
            /// <summary>
            /// Returns currently selected group of object, if any
            /// </summary>
            public Group getActiveGroup() { return null; }
            /// <summary>
            /// Returns currently selected object, if any
            /// </summary>
            public Object getActiveObject() { return null; }
            /// <summary>
            /// Returns coordinates of a center of canvas.
            /// Returned value is an object with top and left properties
            /// </summary>
            public Object getCenter() { return null; }
            /// <summary>
            /// Returns context of canvas where objects are drawn
            /// </summary>
            public object getContext() { return null; }
            /// <summary>
            /// Returns &lt;canvas> element corresponding to this instance
            /// </summary>
            public object getElement() { return null; }
            /// <summary>
            /// Returns canvas height (in px)
            /// </summary>
            public JsNumber getHeight() { return null; }
            /// <summary>
            /// Returns canvas width (in px)
            /// </summary>
            public JsNumber getWidth() { return null; }
            /// <summary>
            /// Constructor
            /// </summary>
            public Object initialize(object el, Object options) { return null; }
            /// <summary>
            /// Populates canvas with data from the specified dataless JSON.
            /// JSON format must conform to the one of {@link fabric.Canvas#toDatalessJSON}
            /// </summary>
            public fabric.Canvas loadFromDatalessJSON(object json, JsAction callback, object reviver) { return null; }
            /// <summary>
            /// Populates canvas with data from the specified JSON.
            /// JSON format must conform to the one of {@link fabric.Canvas#toJSON}
            /// </summary>
            public fabric.Canvas loadFromJSON(object json, JsAction callback, object reviver) { return null; }
            /// <summary>
            /// Moves an object to specified level in stack of drawn objects
            /// </summary>
            public fabric.Canvas moveTo(Object @object, JsNumber index) { return null; }
            /// <summary>
            /// Callback; invoked right before object is about to be scaled/rotated
            /// </summary>
            public void onBeforeScaleRotate(Object target) { }
            /// <summary>
            /// Renders both the top canvas and the secondary container canvas.
            /// </summary>
            public fabric.Canvas renderAll(bool allOnTop) { return null; }


            public fabric.Canvas renderAll() { return null; }

            /// <summary>
            /// Method to render only the top canvas.
            /// Also used to render the group selection box.
            /// </summary>
            public fabric.Canvas renderTop() { return null; }
            /// <summary>
            /// Moves an object down in stack of drawn objects
            /// </summary>
            public fabric.Canvas sendBackwards(Object @object, bool intersecting) { return null; }
            /// <summary>
            /// Moves an object to the bottom of the stack of drawn objects
            /// </summary>
            public fabric.Canvas sendToBack(Object @object) { return null; }
            /// <summary>
            /// Sets {@link fabric.StaticCanvas#backgroundColor|background color} for this canvas
            /// </summary>
            public fabric.Canvas setBackgroundColor(object backgroundColor, JsAction callback) { return null; }
            /// <summary>
            /// Sets {@link fabric.StaticCanvas#backgroundImage|background image} for this canvas
            /// </summary>
            public fabric.Canvas setBackgroundImage(object image, JsAction callback) { return null; }

            public fabric.Canvas setBackgroundImage(object image, JsAction callback, object options) { return null; }
            /// <summary>
            /// Sets dimensions (width, height) of this canvas instance
            /// </summary>
            public fabric.Canvas setDimensions(Object dimensions, JsNumber dimensions_width, JsNumber dimensions_height) { return null; }
            /// <summary>
            /// Sets height of this canvas instance
            /// </summary>
            public fabric.Canvas setHeight(JsNumber height) { return null; }
            /// <summary>
            /// Sets {@link fabric.StaticCanvas#overlayColor|background color} for this canvas
            /// </summary>
            public fabric.Canvas setOverlayColor(object overlayColor, JsAction callback) { return null; }
            /// <summary>
            /// Sets {@link fabric.StaticCanvas#overlayImage|overlay image} for this canvas
            /// </summary>
            public fabric.Canvas setOverlayImage(object image, JsAction callback, Object options) { return null; }
            /// <summary>
            /// Sets width of this canvas instance
            /// </summary>
            public fabric.Canvas setWidth(JsNumber width) { return null; }
            /// <summary>
            /// Straightens object, then rerenders canvas
            /// </summary>
            public fabric.Canvas straightenObject(Object @object) { return null; }
            /// <summary>
            /// Provides a way to check support of some of the canvas methods
            /// (either those of HTMLCanvasElement itself, or rendering context)
            /// </summary>
            public object supports(string methodName) { return null; }
            /// <summary>
            /// Returs dataless JSON representation of canvas
            /// </summary>
            public string toDatalessJSON(object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Returns dataless object representation of canvas
            /// </summary>
            public Object toDatalessObject(object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Exports canvas element to a dataurl image. Note that when multiplier is used, cropping is scaled appropriately
            /// </summary>
            public string toDataURL(Object options, string options_format, JsNumber options_quality, JsNumber options_multiplier, JsNumber options_left, JsNumber options_top, JsNumber options_width, JsNumber options_height) { return null; }
            /// <summary>
            /// Exports canvas element to a dataurl image (allowing to change image size via multiplier).
            /// </summary>
            public string toDataURLWithMultiplier(string format, JsNumber multiplier, JsNumber quality) { return null; }
            /// <summary>
            /// Returns JSON representation of canvas
            /// </summary>
            public string toJSON(object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Returns object representation of canvas
            /// </summary>
            public Object toObject(object[] propertiesToInclude) { return null; }
            /// <summary>
            /// Returns a string representation of an instance
            /// </summary>
            public string toString() { return null; }
            /// <summary>
            /// Returns SVG representation of canvas
            /// </summary>
            public string toSVG(Object options, bool options_suppressPreamble, Object options_viewBox, JsNumber options_viewBox_x, JsNumber options_viewBox_y, JsNumber options_viewBox_width, JsNumber options_viewBox_height, string options_encoding, object reviver) { return null; }
            /// <summary>
            /// Indicates whether the browser can be scrolled when using a touchscreen and dragging on the canvas
            /// </summary>
            public bool allowTouchScrolling { get; set; }
            /// <summary>
            /// Background color of canvas instance.
            /// Should be set via {@link fabric.StaticCanvas#setBackgroundColor}.
            /// </summary>
            public string backgroundColor { get; set; }
            /// <summary>
            /// Background image of canvas instance.
            /// Should be set via {@link fabric.StaticCanvas#setBackgroundImage}.
            /// <b>Backwards incompatibility note:</b> The "backgroundImageOpacity"
            /// and "backgroundImageStretch" properties are deprecated since 1.3.9.
            /// Use {@link fabric.Image#opacity}, {@link fabric.Image#width} and {@link fabric.Image#height}.
            /// </summary>
            public Image backgroundImage { get; set; }
            /// <summary>
            /// Function that determines clipping of entire canvas area
            /// Being passed context as first argument. See clipping canvas area in {@link https://github.com/kangax/fabric.js/wiki/FAQ}
            /// </summary>
            public object clipTo { get; set; }
            /// <summary>
            /// Indicates whether object controls (borders/controls) are rendered above overlay image
            /// </summary>
            public bool controlsAboveOverlay { get; set; }
            /// <summary>
            /// </summary>
            public string EMPTY_JSON { get; set; }
            /// <summary>
            /// Animation duration (in ms) for fx* methods
            /// </summary>
            public JsNumber FX_DURATION { get; set; }
            /// <summary>
            /// Indicates whether toFabricObject/toDatalessFabricObject should include default values
            /// </summary>
            public bool includeDefaultValues { get; set; }
            /// <summary>
            /// Overlay color of canvas instance.
            /// Should be set via {@link fabric.StaticCanvas#setOverlayColor}
            /// </summary>
            public string overlayColor { get; set; }
            /// <summary>
            /// Overlay image of canvas instance.
            /// Should be set via {@link fabric.StaticCanvas#setOverlayImage}.
            /// <b>Backwards incompatibility note:</b> The "overlayImageLeft"
            /// and "overlayImageTop" properties are deprecated since 1.3.9.
            /// Use {@link fabric.Image#left} and {@link fabric.Image#top}.
            /// </summary>
            public Image overlayImage { get; set; }
            /// <summary>
            /// Indicates whether {@link fabric.Collection.add}, {@link fabric.Collection.insertAt} and {@link fabric.Collection.remove} should also re-render canvas.
            /// Disabling this option could give a great performance boost when adding/removing a lot of objects to/from canvas at once
            /// (followed by a manual rendering after addition/deletion)
            /// </summary>
            public bool renderOnAddRemove { get; set; }
            /// <summary>
            /// Indicates whether objects' state should be saved
            /// </summary>
            public bool stateful { get; set; }


            public void setActiveObject(Object obj) { }
        }
        #endregion
        #region string
        /// <summary>
        /// String utilities
        /// </summary>
        public partial class @string
        {
            /// <summary>
            /// Camelizes a string
            /// </summary>
            public static string camelize(string @string) { return null; }
            /// <summary>
            /// Capitalizes a string
            /// </summary>
            public static string capitalize(string @string, bool firstLetterOnly) { return null; }
            /// <summary>
            /// Escapes XML in a string
            /// </summary>
            public static string escapeXml(string @string) { return null; }
        }
        #endregion
        #region Text
        /// <summary>
        /// </summary>
        public partial class Text : Object
        {
            /// <summary>
            /// Returns fabric.Text instance from an SVG element (<b>not yet implemented</b>)
            /// </summary>
            public Text fromElement(object element, Object options) { return null; }
            /// <summary>
            /// Returns fabric.Text instance from an object representation
            /// </summary>
            public Text fromObject(Object @object) { return null; }
            /// <summary>
            /// Retrieves object's fontFamily
            /// </summary>
            public string getFontFamily() { return null; }
            /// <summary>
            /// Retrieves object's fontSize
            /// </summary>
            public string getFontSize() { return null; }
            /// <summary>
            /// Retrieves object's fontStyle
            /// </summary>
            public string getFontStyle() { return null; }
            /// <summary>
            /// Retrieves object's fontWeight
            /// </summary>
            public object getFontWeight() { return null; }
            /// <summary>
            /// Retrieves object's lineHeight
            /// </summary>
            public JsNumber getLineHeight() { return null; }
            /// <summary>
            /// Retrieves object's text
            /// </summary>
            public string getText() { return null; }
            /// <summary>
            /// Retrieves object's textAlign
            /// </summary>
            public string getTextAlign() { return null; }
            /// <summary>
            /// Retrieves object's textBackgroundColor
            /// </summary>
            public string getTextBackgroundColor() { return null; }
            /// <summary>
            /// Retrieves object's textDecoration
            /// </summary>
            public string getTextDecoration() { return null; }
            /// <summary>
            /// Sets object's fontFamily
            /// </summary>
            public Text setFontFamily(string fontFamily) { return null; }
            /// <summary>
            /// Sets object's fontSize
            /// </summary>
            public Text setFontSize(JsNumber fontSize) { return null; }
            /// <summary>
            /// Sets object's fontStyle
            /// </summary>
            public Text setFontStyle(string fontStyle) { return null; }
            /// <summary>
            /// Sets object's fontWeight
            /// </summary>
            public Text setFontWeight(object fontWeight) { return null; }
            /// <summary>
            /// Sets object's lineHeight
            /// </summary>
            public Text setLineHeight(JsNumber lineHeight) { return null; }
            /// <summary>
            /// Sets object's text
            /// </summary>
            public Text setText(string text) { return null; }
            /// <summary>
            /// Sets object's textAlign
            /// </summary>
            public Text setTextAlign(string textAlign) { return null; }
            /// <summary>
            /// Sets object's textBackgroundColor
            /// </summary>
            public Text setTextBackgroundColor(string textBackgroundColor) { return null; }
            /// <summary>
            /// Sets object's textDecoration
            /// </summary>
            public Text setTextDecoration(string textDecoration) { return null; }
            /// <summary>
            /// Returns SVG representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
            /// <summary>
            /// List of attribute names to account for when parsing SVG element (used by {@link fabric.Text.fromElement})
            /// </summary>
            public object ATTRIBUTE_NAMES { get; set; }
            /// <summary>
            /// Font family
            /// </summary>
            public string fontFamily { get; set; }
            /// <summary>
            /// Font size (in pixels)
            /// </summary>
            public JsNumber fontSize { get; set; }
            /// <summary>
            /// Font style . Possible values: "", "normal", "italic" or "oblique".
            /// </summary>
            public string fontStyle { get; set; }
            /// <summary>
            /// Font weight (e.g. bold, normal, 400, 600, 800)
            /// </summary>
            public JsNumber fontWeight { get; set; }
            /// <summary>
            /// Line height
            /// </summary>
            public JsNumber lineHeight { get; set; }
            /// <summary>
            /// URL of a font file, when using Cufon
            /// </summary>
            public string path { get; set; }
            /// <summary>
            /// Text alignment. Possible values: "left", "center", or "right".
            /// </summary>
            public string textAlign { get; set; }
            /// <summary>
            /// Background color of text lines
            /// </summary>
            public string textBackgroundColor { get; set; }
            /// <summary>
            /// Text decoration Possible values: "", "underline", "overline" or "line-through".
            /// </summary>
            public string textDecoration { get; set; }
            /// <summary>
            /// Indicates whether canvas native text methods should be used to render text (otherwise, Cufon is used)
            /// </summary>
            public bool useNative { get; set; }
        }
        #endregion
        #region Triangle
        /// <summary>
        /// </summary>
        public partial class Triangle : Object
        {
            public Triangle() { }

            public Triangle(Object options) { }


            /// <summary>
            /// Returns fabric.Triangle instance from an object representation
            /// </summary>
            public Object fromObject(Object @object) { return null; }
            /// <summary>
            /// Returns SVG representation of an instance
            /// </summary>
            public string toSVG(object reviver) { return null; }
        }
        #endregion
        #region util
        /// <summary>
        /// </summary>
        public partial class util
        {


            /// <summary>
            /// Adds class to an element
            /// </summary>
            public static void addClass(object element, string className) { }
            /// <summary>
            /// Adds an event listener to an element
            /// </summary>
            public static void addListener(object element, string eventName, object handler) { }
            /// <summary>
            /// Changes value from one to another within certain period of time, invoking callbacks as value is being changed.
            /// </summary>
            public static void animate(Object options, object options_onChange, object options_onComplete, JsNumber options_startValue, JsNumber options_endValue, JsNumber options_byValue, object options_easing, JsNumber options_duration) { }
            /// <summary>
            /// </summary>
            public static void clipContext(Object receiver, object ctx) { }
            /// <summary>
            /// Creates accessors (getXXX, setXXX) for a "class", based on "stateProperties" array
            /// </summary>
            public static void createAccessors(Object klass) { }
            /// <summary>
            /// Creates canvas element and initializes it via excanvas if necessary
            /// </summary>
            public static object createCanvasElement(object canvasEl) { return null; }
            /// <summary>
            /// Helper for creation of "classes".
            /// </summary>
            public static void createClass(object parent, object properties) { }
            /// <summary>
            /// Creates image element (works on client and node)
            /// </summary>
            public static object createImage() { return null; }
            /// <summary>
            /// Transforms degrees to radians.
            /// </summary>
            public static JsNumber degreesToRadians(JsNumber degrees) { return null; }
            /// <summary>
            /// Draws arc
            /// </summary>
            public static void drawArc(object ctx, JsNumber x, JsNumber y, object[] coords) { }
            /// <summary>
            /// Draws a dashed line between two points
            /// This method is used to draw dashed line around selection area.
            /// See <a href="http://stackoverflow.com/questions/4576724/dotted-stroke-in-canvas">dotted stroke in canvas</a>
            /// </summary>
            public static void drawDashedLine(object ctx, JsNumber x, JsNumber y, JsNumber x2, JsNumber y2, object[] da) { }
            /// <summary>
            /// Creates corresponding fabric instances from their object representations
            /// </summary>
            public static void enlivenObjects(object[] objects, JsAction callback, object reviver) { }
            /// <summary>
            /// Function which always returns `false`.
            /// </summary>
            public static bool falseFunction() { return false; }
            /// <summary>
            /// Takes id and returns an element with that id (if one exists in a document)
            /// </summary>
            public static object getById(object id) { return null; }
            /// <summary>
            /// Returns offset for a given element
            /// </summary>
            public static Object getElementOffset(object element) { return null; }
            /// <summary>
            /// Returns style attribute value of a given element
            /// </summary>
            public static string getElementStyle(object element, string attr) { return null; }
            /// <summary>
            /// Returns string representation of function body
            /// </summary>
            public static string getFunctionBody(object fn) { return null; }
            /// <summary>
            /// Returns klass "Class" object of given namespace
            /// </summary>
            public static Object getKlass(string type, string @namespace) { return null; }
            /// <summary>
            /// Cross-browser wrapper for getting event's coordinates
            /// </summary>
            public static void getPointer(object @event, object upperCanvasEl) { }
            /// <summary>
            /// Returns random number between 2 specified ones.
            /// </summary>
            public static JsNumber getRandomInt(JsNumber min, JsNumber max) { return null; }
            /// <summary>
            /// Inserts a script element with a given url into a document; invokes callback, when that script is finished loading
            /// </summary>
            public static void getScript(string url, JsAction callback) { }
            /// <summary>
            /// Groups SVG elements (usually those retrieved from SVG document)
            /// </summary>
            public static Object groupSVGElements(Object[] elements, object options) { return null; }
            /// <summary>
            /// Returns true if context has transparent pixel
            /// at specified location (taking tolerance into account)
            /// </summary>
            public static void isTransparent(object ctx, JsNumber x, JsNumber y, JsNumber tolerance) { }
            /// <summary>
            /// Loads image element from given url and passes it to a callback
            /// </summary>
            public static void loadImage(string url, JsAction callback, object context, Object crossOrigin) { }
            /// <summary>
            /// Creates specified element with specified attributes
            /// </summary>
            public static object makeElement(string tagName, Object attributes) { return null; }
            /// <summary>
            /// Makes element selectable
            /// </summary>
            public static object makeElementSelectable(object element) { return null; }
            /// <summary>
            /// Makes element unselectable
            /// </summary>
            public static object makeElementUnselectable(object element) { return null; }
            /// <summary>
            /// Multiply matrix A by matrix B to nest transformations
            /// </summary>
            public static object[] multiplyTransformMatrices(object[] matrixA, object[] matrixB) { return null; }
            /// <summary>
            /// Normalizes polygon/polyline points according to their dimensions
            /// </summary>
            public static void normalizePoints(object[] points, Object options) { }
            /// <summary>
            /// Populates an object with properties of another object
            /// </summary>
            public static object[] populateWithProperties(Object source, Object destination) { return null; }
            /// <summary>
            /// Transforms radians to degrees.
            /// </summary>
            public static JsNumber radiansToDegrees(JsNumber radians) { return null; }
            /// <summary>
            /// Removes value from an array.
            /// Presence of value (and its position in an array) is determined via `Array.prototype.indexOf`
            /// </summary>
            public static object[] removeFromArray(object[] array, object value) { return null; }
            /// <summary>
            /// Removes an event listener from an element
            /// </summary>
            public static void removeListener(object element, string eventName, object handler) { }
            /// <summary>
            /// Cross-browser abstraction for sending XMLHttpRequest
            /// </summary>
            public static object request(string url, Object options, string options_method, object options_onComplete) { return null; }
            /// <summary>
            /// requestAnimationFrame polyfill based on http://paulirish.com/2011/requestanimationframe-for-smart-animating/
            /// In order to get a precise start time, `requestAnimFrame` should be called as an entry into the method
            /// </summary>
            public static void requestAnimFrame(JsAction callback, object element) { }
            /// <summary>
            /// Returns object of given namespace
            /// </summary>
            public static Object resolveNamespace(string @namespace) { return null; }
            /// <summary>
            /// Rotates `point` around `origin` with `radians`
            /// </summary>
            public static Point rotatePoint(Point point, Point origin, JsNumber radians) { return null; }
            /// <summary>
            /// Cross-browser wrapper for setting element's style
            /// </summary>
            public static object setStyle(object element, Object styles) { return null; }
            /// <summary>
            /// Converts an array-like object (e.g. arguments or NodeList) to an array
            /// </summary>
            public static object[] toArray(Object arrayLike) { return null; }
            /// <summary>
            /// A wrapper around Number#toFixed, which contrary to native method returns number, not string.
            /// </summary>
            public static JsNumber toFixed(object number, JsNumber fractionDigits) { return null; }
            /// <summary>
            /// Wraps element with another element
            /// </summary>
            public static object wrapElement(object element, object wrapper, Object attributes) { return null; }

            [JsMethod(Name = "object.clone")]
            public static Object clone(Object obj) { return null; }
        }
        #endregion

        [JsEnum(ValuesAsNames = true)]
        public enum ObjectType
        {
            line,
            circle,
            triangle,
            ellipse,
            polyline,
            polygon,
            path,
            path_group,
            group,
            image,
            rect,
            text
            //i-text,
            //BaseFilter,
            //Brightness,
            //Convolute,
            //GradientTransparency,
            //Grayscale,
            //Invert,
            //Mask,
            //Noise,
            //Pixelate,
            //RemoveWhite,
            //Sepia,
            //Sepia2,
            //Tint,
        }

    }

    [JsType(JsMode.Json)]
    public class VisibilityOpt
    {
        public bool bl { get; set; }
        public bool br { get; set; }
        public bool mb { get; set; }
        public bool ml { get; set; }
        public bool mr { get; set; }
        public bool mt { get; set; }
        public bool tl { get; set; }
        public bool tr { get; set; }
        public bool mtr { get; set; }
    }


    [JsType(JsMode.Json)]
    public partial class SVGOption
    {
        public JsNumber width { get; set; }
        public JsNumber height { get; set; }
    }


    [JsType(JsMode.Json)]
    public partial class EventOptions
    {
        public MouseEvent e { get; set; }
        public fabric.Object target { get; set; }
    }

   
}
