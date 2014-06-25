using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.KineticJs
{
    public class Node
    {
        /// <summary>
        /// Node constructor.  Nodes are entities that can be transformed, layered,and have events bound to them. They are the building blocks of a KineticJSapplication
        /// </summary>
        /// <param name="config"></param>
        public Node(NodeConfig config) { }

        /// <summary>
        /// Node constructor.  Nodes are entities that can be transformed, layered,and have events bound to them. They are the building blocks of a KineticJSapplication
        /// </summary>
        public Node() { }

        /// <summary>
        /// clone node
        /// </summary>
        /// <param name="config">used to override cloned attrs</param>
        /// <returns></returns>
        public Node clone(object config) { return null; }

        /// <summary>
        /// get absolute alpha
        /// </summary>
        /// <returns></returns>
        public JsNumber getAbsoluteAlpha() { return null; }

        /// <summary>
        /// get absolute position relative to stage
        /// </summary>
        /// <returns></returns>
        public XYProperty getAbsolutePosition() { return null; }

        /// <summary>
        /// get transform of the node while taking intoaccount the transforms of its parents
        /// </summary>
        /// <returns></returns>
        public object getAbsoluteTransform() { return null; }

        /// <summary>
        /// get absolute z-index by taking into accountall parent and sibling indices
        /// </summary>
        /// <returns></returns>
        public object getAbsoluteZIndex() { return null; }

        /// <summary>
        /// get alpha. Alpha values range from 0 to 1.A node with an alpha of 0 is fully transparent, and a nodewith an alpha of 1 is fully opaque
        /// </summary>
        /// <returns></returns>
        public JsNumber getAlpha() { return null; }

        /// <summary>
        /// get attrs
        /// </summary>
        /// <returns></returns>
        public object getAttrs() { return null; }

        /// <summary>
        /// get detection type
        /// </summary>
        /// <returns></returns>
        public DetectionType getDetectionType() { return null; }

        /// <summary>
        /// get drag bounds
        /// </summary>
        /// <returns></returns>
        public Bounds getDragBounds() { return null; }

        /// <summary>
        /// get drag constraint
        /// </summary>
        /// <returns></returns>
        public JsString getDragConstraint() { return null; }

        /// <summary>
        /// get draggable
        /// </summary>
        /// <returns></returns>
        public JsString getDraggable() { return null; }

        /// <summary>
        /// get id
        /// </summary>
        /// <returns></returns>
        public JsString getId() { return null; }

        /// <summary>
        /// get layer that contains the node
        /// </summary>
        /// <returns></returns>
        public Layer getLayer() { return null; }

        /// <summary>
        /// get node level in node tree
        /// </summary>
        /// <returns></returns>
        public object getLevel() { return null; }

        /// <summary>
        /// determine if listening to events or not
        /// </summary>
        /// <returns></returns>
        public bool getListening() { return false; }

        /// <summary>
        /// get name
        /// </summary>
        /// <returns></returns>
        public JsString getName() { return null; }

        /// <summary>
        /// get offset
        /// </summary>
        /// <returns></returns>
        public JsNumber getOffset() { return null; }

        /// <summary>
        /// get parent container
        /// </summary>
        /// <returns></returns>
        public object getParent() { return null; }

        /// <summary>
        /// get node position relative to container
        /// </summary>
        /// <returns></returns>
        public point getPosition() { return null; }

        /// <summary>
        /// get rotation in radians
        /// </summary>
        /// <returns></returns>
        public JsNumber getRotation() { return null; }

        /// <summary>
        /// get rotation in degrees
        /// </summary>
        /// <returns></returns>
        public JsNumber getRotationDeg() { return null; }

        /// <summary>
        /// get scale
        /// </summary>
        /// <returns></returns>
        public JsNumber getScale() { return null; }

        /// <summary>
        /// get stage that contains the node
        /// </summary>
        /// <returns></returns>
        public Stage getStage() { return null; }

        /// <summary>
        /// get transform of the node while not takinginto account the transforms of its parents
        /// </summary>
        /// <returns></returns>
        public object getTransform() { return null; }

        /// <summary>
        /// get node x position
        /// </summary>
        /// <returns></returns>
        public JsNumber getX() { return null; }

        /// <summary>
        /// get node y position
        /// </summary>
        /// <returns></returns>
        public JsNumber getY() { return null; }

        /// <summary>
        /// get zIndex
        /// </summary>
        /// <returns></returns>
        public JsNumber getZIndex() { return null; }

        /// <summary>
        /// hide node
        /// </summary>
        public void hide() { }

        /// <summary>
        /// determine if node is currently in drag and drop mode
        /// </summary>
        public void isDragging() {}

        /// <summary>
        /// determine if shape is visible or not.
        /// Shape is visible onlyif it's visible and all of its ancestors are visible. If one ancestoris invisible, this means that the shape is also invisible
        /// </summary>
        public void isVisible() { }

        /// <summary>
        /// move node by an amount
        /// </summary>
        public void move() { }

        /// <summary>
        /// move node down
        /// </summary>
        public void moveDown() {}

        /// <summary>
        /// move node to another container
        /// </summary>
        /// <param name="newContainer"></param>
        /// <returns></returns>
        public object moveTo(Container newContainer) { return null; }

        /// <summary>
        /// move node to bottom
        /// </summary>
        public void moveToBottom() {}

        /// <summary>
        /// move node to top
        /// </summary>
        /// <returns></returns>
        public void moveToTop() {  }

        /// <summary>
        /// move node up
        /// </summary>
        /// <returns></returns>
        public void moveUp() { }

        /// <summary>
        /// remove event bindings from the node. Pass in a string ofevent types delimmited by a space to remove multiple eventbindings at once such as 'mousedown mouseup mousemove'.include a namespace to remove an event binding by namesuch as 'click.foobar'.
        /// </summary>
        /// <param name="typesStr"></param>
        public void off(JsString typesStr) { }

        /// <summary>
        /// bind events to the node. KineticJS supports mouseover, mousemove,mouseout, mousedown, mouseup, click, dblclick, touchstart, touchmove,touchend, tap, dbltap, dragstart, dragmove, and dragend. Pass in a stringof event types delimmited by a space to bind multiple events at oncesuch as 'mousedown mouseup mousemove'.
        /// include a namespace to bind anevent by name such as 'click.foobar'.
        /// </summary>
        /// <param name="typesStr"></param>
        /// <param name="handler"></param>
        public void on(JsString typesStr, JsFunction handler) { }

        /// <summary>
        /// rotate node by an amount in radians
        /// </summary>
        /// <param name="theta"></param>
        public void rotate(JsNumber theta) { }

        /// <summary>
        /// rotate node by an amount in degrees
        /// </summary>
        /// <param name="theta"></param>
        public void rotateDeg(JsNumber deg) { }

        /// <summary>
        /// set absolute position relative to stage
        /// </summary>
        /// <param name="pos">object containing an x and y property</param>
        public void setAbsolutePosition(XYProperty pos) { }

        /// <summary>
        /// set alpha
        /// </summary>
        /// <param name="alpha">Alpha values range from 0 to 1. A node with an alpha of 0 is fully transparent, and a nodewith an alpha of 1 is fully opaque</param>
        public void setAlpha(JsNumber alpha) {}

        /// <summary>
        /// set attrs
        /// </summary>
        /// <param name="config"></param>
        public void setAttrs(object config) {}

        /// <summary>
        /// set default attrs
        /// </summary>
        /// <param name="confic"></param>
        public void setDefaultAttrs(object confic) { }

        /// <summary>
        /// set detection type
        /// </summary>
        /// <param name="type">can be "path" or "pixel"</param>
        public void setDetectionType(DetectionType type) {}

        /// <summary>
        /// set drag bounds
        /// </summary>
        /// <param name="bounds"></param>
        public void setDragBounds(Bounds bounds) { }

        /// <summary>
        /// set drag constraint
        /// </summary>
        /// <param name="constraint"></param>
        public void setDragConstraint(JsString constraint) { }

        /// <summary>
        /// set draggable
        /// </summary>
        /// <param name="constraint"></param>
        public void setDraggable(JsString draggable) {}

        /// <summary>
        /// listen or don't listen to events
        /// </summary>
        /// <param name="listening"></param>
        public void setListening(bool listening) { }

        /// <summary>
        /// set offset
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void setOffset(JsNumber x, JsNumber y) {}

        /// <summary>
        /// set node position
        /// </summary>
        /// <param name="point"></param>
        public void setPosition(point point) { }

        /// <summary>
        /// set node rotation in radians
        /// </summary>
        /// <param name="theta"></param>
        public void setRotation(JsNumber theta) {}

        /// <summary>
        /// set node rotation in degrees
        /// </summary>
        /// <param name="theta"></param>
        public void setRotationDeg(JsNumber deg) { }

        /// <summary>
        /// set node scale.
        /// </summary>
        /// <param name="scale"></param>
        public void setScale(JsNumber scale) { }
        //TODO: {Number|Array|Object|List} was writen in type

        /// <summary>
        /// set node x position
        /// </summary>
        /// <param name="x"></param>
        public void setX(JsNumber x) { }

        /// <summary>
        /// set node y position
        /// </summary>
        /// <param name="x"></param>
        public void setY(JsNumber y) { }

        /// <summary>
        /// set zIndex
        /// </summary>
        /// <param name="zIndex"></param>
        public void setZIndex(JsNumber zIndex) { }
        //TODO: zIndex was writhen "int"

        /// <summary>
        /// show node
        /// </summary>
        public void show() { }

        /// <summary>
        /// simulate event
        /// </summary>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public object simulate(JsString eventType) { return null; }

        /// <summary>
        /// transition node to another state.
        /// Any property that can accept a real number can be transitioned, including x, y, rotation, alpha, strokeWidth, radius, scale.x, scale.y, offset.x, offset.y, etc.
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public Transition transitionTo(NodeConfig config) { return null; }

    }

    public class XYProperty
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
    }

    public class DetectionType
    {
        public JsString path { get; set; }
        public JsString pixel { get; set; }
    }

    public class Bounds
    {
        /// <summary>
        /// Optional left bounds position
        /// </summary>
        public JsNumber left  { get; set; }
        /// <summary>
        /// Optional top bounds position
        /// </summary>
        public JsNumber top { get; set; }
        /// <summary>
        /// Optional right  bounds position
        /// </summary>
        public JsNumber right { get; set; }
        /// <summary>
        /// Optional bottom  bounds position
        /// </summary>
        public JsNumber bottom { get; set; }
    }

    public class NodeConfig
    {
        /// <summary>
        /// Optional. duration that the transition runs in seconds
        /// </summary>
        public JsNumber duration  { get; set; }

        /// <summary>
        /// Optional. easing function. can be linear, ease-in, ease-out, ease-in-out, back-ease-in, back-ease-out, back-ease-in-out,
        /// elastic-ease-in, elastic-ease-out, elastic-ease-in-out, bounce-ease-out, bounce-ease-in, bounce-ease-in-out, strong-ease-in, strong-ease-out, or strong-ease-in-out linear is the default
        /// </summary>
        public JsString easing  { get; set; }

        /// <summary>
        /// Optional. callback function to be executed when transition completes
        /// </summary>
        public ConfigCB callback  { get; set; } 
    }

    /// <summary>
    /// callback function to be executed when transition completes
    /// </summary>
    /// <param name="callback"></param>
    public delegate void ConfigCB(JsAction callback);
    //TODO: danel chack

    public class Container: Node
    {
        /// <summary>
        /// Container constructor.  Containers are used to contain nodes or other containers
        /// </summary>
        /// <param name="config"></param>
        public Container(object config) { }

        /// <summary>
        /// Container constructor.  Containers are used to contain nodes or other containers
        /// </summary>
        public Container() { }

        /// <summary>
        /// add node to container
        /// </summary>
        /// <param name="child"></param>
        public void add(Node child) { }

        /// <summary>
        /// return an array of nodes that match the selector. Use '#' for id selectionsand '.' for name selectionsex:var node = stage.get('#foo'); // selects node with id foovar nodes = layer.get('.bar'); // selects nodes with name bar inside layer
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public JsArray get(JsString selector) { return null; }

        /// <summary>
        /// get children
        /// </summary>
        /// <returns></returns>
        public object getChildren() { return null; }

        /// <summary>
        /// get shapes that intersect a point
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public object getIntersections(object point) { return null; }

        /// <summary>
        /// determine if node is an ancestorof descendant
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool isAncestorOf(Node node) { return false; }

        /// <summary>
        /// remove child from container
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        public object remove(Node child) { return null; }

        /// <summary>
        /// remove all childrenremove all children
        /// </summary>
        public void removeChildren() { }
    }

    public class Shape: Node
    {
        /// <summary>
        /// Shape constructor. Shapes are used to objectify drawing bits of a KineticJSapplication
        /// </summary>
        /// <param name="config"></param>
        public Shape(ShapeConfig config) { }

        /// <summary>
        /// Shape constructor. Shapes are used to objectify drawing bits of a KineticJSapplication
        /// </summary>
        public Shape() { }

        /// <summary>
        /// helper method to set the line join of a shapebased on the lineJoin property
        /// </summary>
        public void applyLineJoin() { }

        /// <summary>
        /// helper method to draw an image and applya shadow if neede
        /// </summary>
        public void drawImage() { }

        /// <summary>
        /// helper method to fill the shape with a color, linear gradient,radial gradient, or pattern, and also apply shadows if needed
        /// </summary>
        public void fill() { }

        /// <summary>
        /// helper method to fill text and appy shadows if needed
        /// </summary>
        /// <param name="text"></param>
        public void fillText(JsString text) { }

        /// <summary>
        /// get shape temp layer canvas
        /// </summary>
        /// <returns></returns>
        public object getCanvas() { return null; }

        /// <summary>
        /// get layer context where the shape is being drawn. Whenthe shape is being rendered, .getContext() returns the context of theuser created layer that contains the shape.
        /// When the event detectionengine is determining whether or not an event has occured on that shape,.getContext() returns the context of the invisible path layer.
        /// </summary>
        /// <returns></returns>
        public object getContext() { return null; }

        /// <summary>
        /// get draw function
        /// </summary>
        /// <returns></returns>
        public JsFunction getDrawFunc() { return null; }

        /// <summary>
        /// get fill
        /// </summary>
        /// <returns></returns>
        public object getFill() { return null; }

        /// <summary>
        /// get line join
        /// </summary>
        /// <returns></returns>
        public object getLineJoin() { return null; }
        //tryed to write LineJoinOptions as a return type, didnt work

        /// <summary>
        /// get shadow object
        /// </summary>
        /// <returns></returns>
        public object getShadow() { return null; }

        /// <summary>
        /// get stroke color
        /// </summary>
        /// <returns></returns>
        public object getStrokeColor() { return null; }

        /// <summary>
        /// get stroke width
        /// </summary>
        /// <returns></returns>
        public JsNumber getStrokeWidth() { return null; }

        /// <summary>
        /// set draw function
        /// </summary>
        /// <param name="drawFunc">drawing function</param>
        public void setDrawFunc(JsFunction drawFunc) { }

        /// <summary>
        /// set fill which can be a color, linear gradient object, radial gradient object, or pattern object
        /// </summary>
        /// <param name="fill"></param>
        public void setFill(object fill) { }

        /// <summary>
        /// set fill which can be a color, linear gradient object, radial gradient object, or pattern object
        /// </summary>
        /// <param name="fill"></param>
        public void setFill(JsString fill) { }

        /// <summary>
        /// set line join
        /// </summary>
        /// <param name="lineJoin">Can be miter, round, or bevel. The default is miter</param>
        public void setLineJoin(LineJoinOptions lineJoin) { }

        /// <summary>
        /// set shadow object
        /// </summary>
        /// <param name="config"></param>
        public void setShadow(object config) { }

        /// <summary>
        /// set stroke color
        /// </summary>
        /// <param name="stroke"></param>
        public void setStroke(JsString stroke) { }

        /// <summary>
        /// set stroke width
        /// </summary>
        /// <param name="strokeWidth"></param>
        public void setStrokeWidth(JsNumber strokeWidth) { }

        /// <summary>
        /// helper method to stroke the shape and applyshadows if needed
        /// </summary>
        public void stroke() { }

        /// <summary>
        /// helper method to stroke text and apply shadowsif needed
        /// </summary>
        /// <param name="text"></param>
        public void strokeText(JsString text) { }

    }
        
    /// <summary>
    /// Shape constructor. Shapes are used to objectify drawing bits of a KineticJSapplication
    /// </summary>
    public class ShapeConfig
    {

        /// <summary>
        /// Optional. can be a string color, a linear gradient object, a radial gradient object, or a pattern object.
        /// </summary>
        public object fill { get; set; }

        /// <summary>
        /// Optional.stroke color
        /// </summary>
        public JsString stroke  { get; set; }

        /// <summary>
        /// Optional.stroke width
        /// </summary>
        public JsNumber strokeWidth  { get; set; }

        /// <summary>
        /// Optional.line join can be "miter", "round", or "bevel". The default is "miter"
        /// </summary>
        public LineJoinOptions lineJoin { get; set; }

        /// <summary>
        /// Optional.shadow object
        /// </summary>
        public object shadow { get; set; }

        /// <summary>
        /// Optional. shape detection type. Can be "path" or "pixel". The default is "path" because it performs better
        /// </summary>
        public DetectionType detectionType  { get; set; }
    }

    public enum LineJoinOptions
    {
        miter,
        round,
        bevel,
    }

    public class Ellipse: Shape
    {
        /// <summary>
        /// Ellipse constructor
        /// </summary>
        /// <param name="config"></param>
        public Ellipse(object config) { }
        /// <summary>
        /// Ellipse constructor
        /// </summary>
        public Ellipse() { }

        /// <summary>
        /// get radius
        /// </summary>
        /// <returns></returns>
        public XYProperty getRadius() { return null; }

        /// <summary>
        /// radius can be a number, in which the ellipse becomes a circle, it can be an object with an x and y component, or it can be an array in which the first element is the x component and the second element is the y component.
        /// The x component defines the horizontal radius and the y component defines the vertical radius
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(XYProperty radius) { }

        /// <summary>
        /// radius can be a number, in which the ellipse becomes a circle, it can be an object with an x and y component, or it can be an array in which the first element is the x component and the second element is the y component.
        /// The x component defines the horizontal radius and the y component defines the vertical radius
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(JsArray radius) { }

        /// <summary>
        /// radius can be a number, in which the ellipse becomes a circle, it can be an object with an x and y component, or it can be an array in which the first element is the x component and the second element is the y component.
        /// The x component defines the horizontal radius and the y component defines the vertical radius
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(object radius) { }
    }

    public class Group : Container
    {
        /// <summary>
        /// Group constructor. Groups are used to contain shapes or other groups.
        /// </summary>
        /// <param name="config"></param>
        public Group(object config) { }

        /// <summary>
        /// Group constructor. Groups are used to contain shapes or other groups.
        /// </summary>
        public Group() { }
    }

    public class Image : Shape
    {
        /// <summary>
        /// Image constructor
        /// </summary>
        /// <param name="config"></param>
        public Image(object config) { }

        /// <summary>
        /// Image constructor
        /// </summary>
        public Image() { }

        /// <summary>
        /// get crop
        /// </summary>
        /// <returns></returns>
        public object getCrop() { return null; }

        /// <summary>
        /// get height
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// get image
        /// </summary>
        /// <returns></returns>
        public object getImage() { return null; }

        /// <summary>
        /// return image size
        /// </summary>
        /// <returns></returns>
        public Size getSize() { return null; }

        /// <summary>
        /// get width
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// set crop
        /// </summary>
        /// <param name="config"></param>
        public void setCrop(object config) { }

        /// <summary>
        /// set height
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(JsNumber height) { }

        /// <summary>
        /// set image
        /// </summary>
        /// <param name="image"></param>
        public void setImage(object image) { }

        /// <summary>
        /// set width and height
        /// </summary>
        /// <param name="size"></param>
        public void setSize(Size size) { }

        /// <summary>
        /// set width
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(JsNumber width) { }
    }

    public class Size
    {
        public JsNumber width  { get; set; }
        public JsNumber height { get; set; }
    }
    //it is named just "size" cuse it is used in Image and in Rect

    public class Layer : Container
    {
        /// <summary>
        /// Layer constructor. Layers are tied to their own canvas element and are usedto contain groups or shapes
        /// </summary>
        /// <param name="config"></param>
        public Layer(object config) { }

        /// <summary>
        /// Layer constructor. Layers are tied to their own canvas element and are usedto contain groups or shapes
        /// </summary>
        public Layer() { }

        /// <summary>
        /// set after draw function handler
        /// </summary>
        public void afterDraw() { }

        /// <summary>
        /// set before draw function handler
        /// </summary>
        public void beforeDraw() { }

        /// <summary>
        /// clears the canvas context tied to the layer. Clearing a layer does not remove its children.
        /// The nodes within the layer will be redrawn whenever the .draw() method is used again.
        /// </summary>
        public void clear() { }

        /// <summary>
        /// draw children nodes. this includes any groups or shapes
        /// </summary>
        public void draw() { }

        /// <summary>
        /// get layer canvas
        /// </summary>
        /// <returns></returns>
        public object getCanvas() { return null; }

        /// <summary>
        /// get flag which determines if the layer is cleared or not before drawing
        /// </summary>
        /// <returns></returns>
        public object getClearBeforeDraw() { return null; }

        /// <summary>
        /// get layer context
        /// </summary>
        /// <returns></returns>
        public object getContext() { return null; }

        /// <summary>
        /// get throttle
        /// </summary>
        /// <returns></returns>
        public JsNumber getThrottle() { return null; }

        /// <summary>
        /// set flag which determines if the layer is cleared or not before drawing
        /// </summary>
        /// <param name="clearBeforeDraw"></param>
        public void setClearBeforeDraw(bool clearBeforeDraw) { }

        /// <summary>
        /// set throttle
        /// </summary>
        /// <param name="throttle"></param>
        public void setThrottle(JsNumber throttle) { }

    }

    public class Line : Shape
    {
        /// <summary>
        /// Line constructor.  Lines are defined by an array of points
        /// </summary>
        /// <param name="config"></param>
        public Line(object config) { }

        /// <summary>
        /// Line constructor.  Lines are defined by an array of points
        /// </summary>
        public Line() { }

        /// <summary>
        /// get dash array
        /// </summary>
        /// <returns></returns>
        public JsArray<JsNumber> getDashArray() { return null; }

        /// <summary>
        /// get line cap
        /// </summary>
        /// <returns></returns>
        public LineCap getLineCap() { return 0; }
        //don't know what happend here. shows an error 

        /// <summary>
        /// get points array
        /// </summary>
        /// <returns></returns>
        public point getPoints() { return null; }

        /// <summary>
        /// set dash array.
        /// </summary>
        /// <param name="dashArray"></param>
        public void setDashArray(JsArray<JsNumber> dashArray) { }

        /// <summary>
        /// set line cap. Can be butt, round, or square
        /// </summary>
        /// <param name="lineCap"></param>
        public void setLineCap(LineCap lineCap) { }

        /// <summary>
        /// set points array
        /// </summary>
        /// <param name="can">be an array of point objects or an array of Numbers. e.g. [{x:1,y:2},{x:3,y:4}] or [1,2,3,4]</param>
        public void setPoints(JsArray<point> can) { }

        /// <summary>
        /// set points array
        /// </summary>
        /// <param name="can">be an array of point objects or an array of Numbers. e.g. [{x:1,y:2},{x:3,y:4}] or [1,2,3,4]</param>
        public void setPoints(JsArray<JsNumber> can) { }
    }

    public enum LineCap
    {
        butt,
        round,
        square,
    }

    public class point
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
    }


    public class Path : Shape
    {
        /// <summary>
        /// Path constructor. 
        /// Author: Jason Follas.
        /// </summary>
        /// <param name="config"></param>
        public Path(object config) { }

        /// <summary>
        /// Path constructor. 
        /// Author: Jason Follas.
        /// </summary>
        public Path() { }

        /// <summary>
        /// get SVG path data string
        /// </summary>
        /// <returns></returns>
        public JsString getData() { return null; }

        /// <summary>
        /// set SVG path data string. This method also automatically parses the data string into a data array.
        /// Currently supported SVG data: M, m, L, l, H, h, V, v, Q, q, T, t, C, c, S, s, A, a, Z, z
        /// </summary>
        /// <param name="SVG">path command string</param>
        public void setData(JsString SVG) { }
    }

    /// <summary>
    /// Polygon constructor.  Polygons are defined by an array of points
    /// </summary>
    public class Polygon : Shape
    {
        /// <summary>
        /// Polygon constructor.  Polygons are defined by an array of points
        /// </summary>
        /// <param name="config"></param>
        public Polygon(object config) { }

        /// <summary>
        /// Polygon constructor.  Polygons are defined by an array of points
        /// </summary>
        public Polygon() { }

        /// <summary>
        /// get points array
        /// </summary>
        /// <returns></returns>
        public point getPoints() { return null; }

        /// <summary>
        /// set points array
        /// </summary>
        /// <param name="can">be an array of point objects or an array of Numbers. e.g. [{x:1,y:2},{x:3,y:4}] or [1,2,3,4]</param>
        public void setPoints(JsArray<point> can) { }

    }

    public class Rect : Shape
    {
        /// <summary>
        /// Rect constructor
        /// </summary>
        /// <param name="config"></param>
        public Rect(object config) { }

        /// <summary>
        /// Rect constructor
        /// </summary>
        public Rect() { }

        /// <summary>
        /// get corner radius
        /// </summary>
        /// <returns></returns>
        public JsNumber getCornerRadius() { return null; }

        /// <summary>
        /// get height
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// return image size
        /// </summary>
        /// <returns></returns>
        public Size getSize() { return null; }

        /// <summary>
        /// get width
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// set corner radius
        /// </summary>
        /// <param name="radius"></param>
        public void setCornerRadius(JsNumber radius) { }

        /// <summary>
        /// set height
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(JsNumber height) { }

        /// <summary>
        /// set width and height
        /// </summary>
        /// <param name="size"></param>
        public void setSize(Size size) { }

        /// <summary>
        /// set width
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(JsNumber width) { }


    }

    /// <summary>
    /// RegularPolygon constructor.  Examples include triangles, squares, pentagons, hexagons, etc.
    /// </summary>
    public class RegularPolygon : Shape
    {
        /// <summary>
        /// RegularPolygon constructor.  Examples include triangles, squares, pentagons, hexagons, etc.
        /// </summary>
        /// <param name="config"></param>
        public RegularPolygon(object config) { }

        /// <summary>
        /// RegularPolygon constructor.  Examples include triangles, squares, pentagons, hexagons, etc.
        /// </summary>
        public RegularPolygon() { }

        /// <summary>
        /// get radius
        /// </summary>
        /// <returns></returns>
        public JsNumber getRadius() { return null; }

        /// <summary>
        /// get sides
        /// </summary>
        /// <returns></returns>
        public JsNumber getSides() { return null; }

        /// <summary>
        /// set radius
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(JsNumber radius) { }

        /// <summary>
        /// set number of sides
        /// </summary>
        /// <param name="sides"></param>
        public void setSides(JsNumber sides) { }
    }

    public class Sprite : Shape
    {
        /// <summary>
        /// Sprite constructor
        /// </summary>
        /// <param name="config"></param>
        public Sprite(object config) { }

        /// <summary>
        /// Sprite constructor
        /// </summary>
        public Sprite() { }

        /// <summary>
        /// set after frame event handler
        /// </summary>
        /// <param name="index">frame index</param>
        /// <param name="func">function to be executed after frame has been drawn</param>
        public void afterFrame(JsArray index, JsFunction func) { }
        //TODO: not sure if array, was writen Integer

        /// <summary>
        /// get animation key
        /// </summary>
        /// <returns></returns>
        public JsString getAnimation() { return null; }

        /// <summary>
        /// get animations object
        /// </summary>
        /// <returns></returns>
        public object getAnimations() { return null; }

        /// <summary>
        /// get animation frame index
        /// </summary>
        /// <returns></returns>
        public JsArray getIndex() { return null; }
        //TODO: not sure if array, was writen Integer

        /// <summary>
        /// set animation key
        /// </summary>
        /// <param name="anim">animation key</param>
        public void setAnimation(JsString anim) { }

        /// <summary>
        /// set animations obect
        /// </summary>
        /// <param name="animations"></param>
        public void setAnimations(object animations) { }

        /// <summary>
        /// set animation frame index
        /// </summary>
        /// <param name="index">frame index</param>
        public void setIndex(JsArray index) { }
        //TODO: not sure if array, was writen Integer

        /// <summary>
        /// start sprite animation
        /// </summary>
        public void start() { }

        /// <summary>
        /// stop  sprite animation
        /// </summary>
        public void stop() { }


    }

    public class Stage : Shape
    {
        /// <summary>
        /// Stage constructor. A stage is used to contain multiple layers and handleanimations
        /// </summary>
        /// <param name="cont">Container id or DOM element</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Stage (JsString cont, JsNumber width, JsNumber height){}

        /// <summary>
        /// Stage constructor. A stage is used to contain multiple layers and handleanimations
        /// </summary>
        /// <param name="cont">Container id or DOM element</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Stage (HtmlElement cont, JsNumber width, JsNumber height){}

        /// <summary>
        /// Stage constructor. A stage is used to contain multiple layers and handleanimations
        /// </summary>
        public Stage (){}

        /// <summary>
        /// clear all layers
        /// </summary>
        public void clear() {}

        /// <summary>
        /// clear all layers
        /// </summary>
        public void draw() {}

        /// <summary>
        /// get container DOM element
        /// </summary>
        /// <returns></returns>
        public HtmlElement getContainer () { return null; }
        //TODO: return type?

        /// <summary>
        /// get stage DOM node, which is a div elementwith the class name "kineticjs-content"
        /// </summary>
        /// <returns></returns>
        public Node getDOM () {return null;}
        //TODO: return type?

        /// <summary>
        /// get height
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// get mouse position for desktop apps
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public object getMousePosition(DOMEvent evt) { return null; }

        /// <summary>
        /// return stage size
        /// </summary>
        /// <returns></returns>
        public Size getSize() { return null; }

        /// <summary>
        /// get stage
        /// </summary>
        /// <returns></returns>
        public object getStage() { return null; }

        /// <summary>
        /// get throttle
        /// </summary>
        /// <returns></returns>
        public JsNumber getThrottle() { return null; }

        /// <summary>
        /// get touch position for mobile apps
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public object getTouchPosition(DOMEvent evt) { return null; }

        /// <summary>
        /// get user position (mouse position or touch position)
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public object getUserPosition(DOMEvent evt) { return null; }

        /// <summary>
        /// get width
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// load stage with JSON string. De-serializtion does not generate custom shape drawing functions, images, or event handlers (this would make the	serialized object huge).
        /// If your app uses custom shapes, images, and event handlers (it probably does),
        /// then you need to select the appropriate shapes after loading the stage and set these properties via on(), setDrawFunc(), and setImage()
        /// </summary>
        /// <param name="JSON"></param>
        public void load(JsString JSON) { }

        /// <summary>
        /// sets onFrameFunc for animation
        /// </summary>
        /// <param name="func"></param>
        public void onFrame(JsFunction func) { }

        /// <summary>
        /// reset stage to default state
        /// </summary>
        public void reset() { }

        /// <summary>
        /// set height
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(JsNumber height) { }

        /// <summary>
        /// set stage size
        /// </summary>
        /// <param name="size"></param>
        public void setSize(Size size) { }
        //TODO: orginly no parameters

        /// <summary>
        /// set throttle. Increasing the throttle will increase the number of mousemove and touchmove event detections,
        /// and decreasing the throttle will decrease the number of mousemove and touchmove events which improves performance
        /// </summary>
        /// <param name="throttle"></param>
        public void setThrottle(JsNumber throttle) { }

        /// <summary>
        /// set width
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(JsNumber width) { }

        /// <summary>
        /// start animation
        /// </summary>
        public void start() { }

        /// <summary>
        /// stop  animation
        /// </summary>
        public void stop() { }

        /// <summary>
        /// Creates a composite data URL and passes it to a callback.
        /// If MIME type is notspecified, then "image/png" will result. For "image/jpeg", specify a qualitylevel as quality (range 0.0 - 1.0)
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="mimeType"></param>
        /// <param name="quality"></param>
        public void toDataURL(ToDataURLCB callback, JsString mimeType, JsNumber quality) { }

        /// <summary>
        /// Creates a composite data URL and passes it to a callback.
        /// If MIME type is notspecified, then "image/png" will result. For "image/jpeg", specify a qualitylevel as quality (range 0.0 - 1.0)
        /// </summary>
        /// <param name="callback"></param>
        public void toDataURL(ToDataURLCB callback) { }

        /// <summary>
        /// serialize stage and children as a JSON object
        /// </summary>
        public void toJSON() { }

    }

    public delegate void ToDataURLCB(JsAction callback);
    //TODO: danel chack

    public class Star : Shape
    {
        /// <summary>
        /// Star constructor
        /// </summary>
        /// <param name="config"></param>
        public Star(object config) { }

        /// <summary>
        /// Star constructor
        /// </summary>
        public Star() { }

        /// <summary>
        /// get inner radius
        /// </summary>
        /// <returns></returns>
        public JsNumber getInnerRadius() { return null; }

        /// <summary>
        /// get number of points
        /// </summary>
        /// <returns></returns>
        public JsNumber getNumPoints() { return null; }

        /// <summary>
        /// get outer radius
        /// </summary>
        /// <returns></returns>
        public JsNumber getOuterRadius() { return null; }

        /// <summary>
        /// set inner radius
        /// </summary>
        /// <param name="radius"></param>
        public void setInnerRadius(JsNumber radius) { }

        /// <summary>
        /// set number of points
        /// </summary>
        /// <param name="points"></param>
        public void setNumPoints(JsNumber points) { }

        /// <summary>
        /// set outer radius
        /// </summary>
        /// <param name="radius"></param>
        public void setOuterRadius(JsNumber radius) { }
    }

    public class Transition
    {
        /// <summary>
        /// Transition constructor. The transitionTo() Node method returns a reference to the transition object which you can use to stop, resume, or restart the transition
        /// </summary>
        /// <param name="node"></param>
        /// <param name="config"></param>
        public Transition(Node node, object config) { }

        /// <summary>
        /// Transition constructor. The transitionTo() Node method returns a reference to the transition object which you can use to stop, resume, or restart the transition
        /// </summary>
        public Transition() { }
        /// <summary>
        /// resume transition
        /// </summary>
        public void resume() { }
        /// <summary>
        /// start transition
        /// </summary>
        public void start() { }
        /// <summary>
        /// stop transition
        /// </summary>
        public void stop() { }
    }

    public class Text : Shape
    {
        /// <summary>
        /// get horizontal align
        /// </summary>
        /// <returns></returns>
        public AlignOptions getAlign() { return 0; }
        //TODO: { return 0; }?

        /// <summary>
        /// get box height
        /// </summary>
        /// <returns></returns>
        public JsNumber getBoxHeight() { return null; }

        /// <summary>
        /// get box width
        /// </summary>
        /// <returns></returns>
        public JsNumber getBoxWidth() { return null; }

        /// <summary>
        /// get font family
        /// </summary>
        /// <returns></returns>
        public JsString getFontFamily() { return null; }

        /// <summary>
        /// get font size
        /// </summary>
        /// <returns></returns>
        public JsNumber getFontSize() { return null; }

        /// <summary>
        /// get font style
        /// </summary>
        /// <returns></returns>
        public FontStyle getFontStyle() { return 0; }
        //TODO: { return 0; }?

        /// <summary>
        /// get height of text box
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// get line height
        /// </summary>
        /// <returns></returns>
        public JsNumber getLineHeight() { return null; }

        /// <summary>
        /// get padding
        /// </summary>
        /// <returns></returns>
        public JsNumber getPadding() { return null; }

        /// <summary>
        /// get shadow of text or textbox
        /// </summary>
        /// <returns></returns>
        public object getShadow() { return null; }

        /// <summary>
        /// get text
        /// </summary>
        /// <returns></returns>
        public JsString getText() { return null; }

        /// <summary>
        /// get text fill color
        /// </summary>
        /// <returns></returns>
        public JsString getTextFill() { return null; }

        /// <summary>
        /// get text height in pixels
        /// </summary>
        /// <returns></returns>
        public JsNumber getTextHeight() { return null; }

        /// <summary>
        /// get text stroke color
        /// </summary>
        /// <returns></returns>
        public JsString getTextStroke() { return null; }

        /// <summary>
        /// get text stroke width
        /// </summary>
        /// <returns></returns>
        public JsString getTextStrokeWidth() { return null; }

        /// <summary>
        /// get text width in pixels
        /// </summary>
        /// <returns></returns>
        public JsNumber getTextWidth() { return null; }

        /// <summary>
        /// get width of text box
        /// </summary>
        /// <returns></returns>
        public JsString getWidth() { return null; }

        /// <summary>
        /// align can be 'left', 'center', or 'right'
        /// </summary>
        /// <param name="align"></param>
        public void setAlign(AlignOptions align) { }

        /// <summary>
        /// set font family
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setFontFamily(JsString fontFamily) { }

        /// <summary>
        /// set font size
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setFontSize(JsNumber fontSize) { }

        /// <summary>
        /// set text stroke color
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setFontStroke(JsString textStroke) { }

        /// <summary>
        /// set font style. Can be "normal", "italic", or "bold". "normal" is the default.
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setFontStyle(FontStyle fontStyle) { }

        /// <summary>
        /// set height of text box
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setHeight(JsNumber height) { }

        /// <summary>
        /// set line height
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setLineHeight(JsNumber lineHeight) { }

        /// <summary>
        /// set padding
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setPadding(JsNumber padding) { }

        /// <summary>
        /// set shadow of text or textbox
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setShadow(object config) { }

        /// <summary>
        /// set text
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setText(JsString text) { }

        /// <summary>
        /// set text fill color
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setTextFill(JsString textFill) { }

        /// <summary>
        /// set text stroke width
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setTextStrokeWidth(JsNumber textStrokeWidth) { }

        /// <summary>
        /// set width of text box
        /// </summary>
        /// <param name="fontFamily"></param>
        public void setWidth(JsNumber width) { }
    }

    public enum AlignOptions
    {
        left,
        center,
        right,
    }

    public enum FontStyle
    {
        normal,
        italic,
    }
}
