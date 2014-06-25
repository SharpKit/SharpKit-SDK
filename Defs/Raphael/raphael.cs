using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Raphael
{
    #region Animation

    [JsType(JsMode.Prototype)]
    public class Animation
    {
        /// <summary>
        /// Creates a copy of existing animation object with given delay.
        /// </summary>
        /// <param name="delay">number of ms to pass between animation start and actual animation</param>
        /// <returns>new altered Animation object</returns>
        /// <example>
        /// <code>
        /// var anim = Raphael.animation({cx: 10, cy: 20}, 2e3);
        /// circle1.animate(anim); // run the given animation immediately
        /// circle2.animate(anim.delay(500)); // run the given animation after 500 ms
        /// </code>
        /// </example>
        public Animation delay(JsNumber delay) { return null; }
        /// <summary>
        /// Creates a copy of existing animation object with given repetition.
        /// </summary>
        /// <param name="repeat">number iterations of animation. For infinite animation pass Infinity</param>
        /// <returns>new altered Animation object</returns>
        public Animation repeat(JsNumber repeat) { return null; }
    }

    #endregion

    #region Element

    [JsType(JsMode.Prototype)]
    public class Element
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing"></param>
        /// <param name="callback"></param>
        /// <returns>original element</returns>
        public Element animate(object @params, JsNumber ms, string easing, JsAction callback)
        {
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing"></param>
        /// <param name="animation"></param>
        /// <returns>original element</returns>
        public Element animate(object @params, JsNumber ms, string easing, object animation)
        {
            return null;
        }
        /// <summary>
        /// Acts similar to Element.animate, but ensure that given animation runs in sync with another given element.
        /// </summary>
        /// <param name="element">element to sync with</param>
        /// <param name="anim">animation to sync with</param>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing">easing type. Accept on of Raphael.easing_formulas or CSS format: cubic‐bezier(XX, XX, XX, XX)</param>
        /// <param name="callback">callback function. Will be called at the end of animation.</param>
        /// <returns></returns>
        public Element animateWith(object element, object anim, object @params, JsNumber ms, string easing, JsAction callback)
        {
            return null;
        }
        /// <summary>
        /// Acts similar to Element.animate, but ensure that given animation runs in sync with another given element.
        /// </summary>
        /// <param name="element">element to sync with</param>
        /// <param name="anim">animation to sync with</param>
        /// <param name="animation">animation object, see Raphael.animation</param>
        /// <returns></returns>
        public Element animateWith(object element, object anim, object animation)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="attrName">attribute’s name</param>
        /// <param name="value">value</param>
        /// <returns></returns>
        public Element attr(string attrName, string value)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="params">object of name/value pairs</param>
        /// <returns></returns>
        public Element attr(object @params) { return null; }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="params">object of name/value pairs</param>
        /// <returns></returns>
        public Element attr(ElementAttributes @params) { return null; }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="attrName">attribute’s name</param>
        /// <returns></returns>
        public object attr(string attrName)
        {
            return null;
        }
        /// <summary>
        /// Sets the attributes of the element
        /// </summary>
        /// <param name="attrNames">in this case method returns array of current values for given attribute names</param>
        /// <returns></returns>
        public JsArray attr(JsArray attrNames)
        {
            return null;
        }

        /// <summary>
        /// Adds event handler for click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object click(JsAction handler)
        {
            return null;
        }
        public Element clone()
        {
            return null;
        }
        /// <summary>
        /// Adds or retrieves given value asociated with given key. See also Element.removeData
        /// </summary>
        /// <param name="key">any, key to store data</param>
        /// <param name="value">value to store</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// for (var i = 0, i &lt; 5, i++) {
        /// paper.circle(10 + 15 * i, 10, 10)
        /// .attr({fill: "#000"})
        /// .data("i", i)
        /// .click(function () {
        /// alert(this.data("i"));
        /// });
        /// </code>
        /// </example>
        public object data(string key, object value)
        {
            return null;
        }
        //TODO: there is anathor return for specipic case. how should i write it?
        /// <summary>
        /// Adds event handler for double click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object dblclick(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handlers for drag of the element.
        /// </summary>
        /// <param name="onmove">handler for moving</param>
        /// <param name="onstart">handler for drag start</param>
        /// <param name="onend">handler for drag end</param>
        /// <param name="mcontext">context for moving handler</param>
        /// <param name="scontext">context for drag start handler</param>
        /// <param name="econtext">context for drag end handler</param>
        /// <returns></returns>
        public object drag(JsAction onmove, JsAction onstart, JsAction onend, object mcontext, object scontext, object econtext)
        {
            return null;
        }
        //TODO: there are some X&Y stuff what should i do with them?
        /// <summary>
        /// Return bounding box for a given element
        /// </summary>
        /// <param name="isWithoutTransform">flag, true if you want to have bounding box before transformations. Default is false.</param>
        /// <returns></returns>
        public object getBBox(object isWithoutTransform)
        {
            return null;
        }
        // object=boolean

        //grey box
        /// <summary>
        /// Return coordinates of the point located at the given length on the given path. Only works for element of “path” type.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public GetPointAtLength getPointAtLength(JsNumber length)
        {
            return null;
        }
        //TODO: D.check
        /// <summary>
        /// Return subpath of a given element from given length to given length. Only works for element of “path” type.
        /// </summary>
        /// <param name="from">position of the start of the segment</param>
        /// <param name="to">position of the end of the segment</param>
        /// <returns></returns>
        public string getSubpath(JsNumber from, JsNumber to)
        {
            return null;
        }
        /// <summary>
        /// Returns length of the path in pixels. Only works for element of “path” type.
        /// </summary>
        /// <returns></returns>
        public JsNumber getTotalLength()
        {
            return null;
        }
        /// <summary>
        /// Return set of elements that create glow-like effect around given element. See Paper.set. Note: Glow is not connected to the element. If you change element attributes it won’t adjust itself.
        /// </summary>
        /// <param name="glow">parameters object with all properties optional:</param>
        /// <returns></returns>
        public object glow(object glow)
        {
            return null;
        }
        /// <summary>
        /// Makes element invisible. See Element.show.
        /// </summary>
        /// <returns></returns>
        public object hide()
        {
            return null;
        }
        /// <summary>
        /// Adds event handlers for hover for the element.
        /// </summary>
        /// <param name="f_in">handler for hover in</param>
        /// <param name="f_out">handler for hover out</param>
        /// <param name="icontext">context for hover in handler</param>
        /// <param name="ocontext">context for hover out handler</param>
        /// <returns></returns>
        public object hover(JsAction f_in, JsAction f_out, object icontext, object ocontext)
        {
            return null;
        }
        /// <summary>
        /// Unique id of the element. Especially usesful when you want to listen to events of the element,
        /// because all events are fired in format <module>.<action>.<id>. Also useful for Paper.getById method.
        /// </summary>
        public JsNumber id { get; set; }
        //TODO: D.check
        /// <summary>
        /// Inserts current object after the given one.
        /// </summary>
        /// <returns></returns>
        public object insertAfter()
        {
            return null;
        }
        /// <summary>
        /// Inserts current object before the given one.
        /// </summary>
        /// <returns></returns>
        public object insertBefore()
        {
            return null;
        }
        /// <summary>
        /// Determine if given point is inside this element’s shape
        /// </summary>
        /// <param name="x">x coordinate of the point</param>
        /// <param name="y">y coordinate of the point</param>
        /// <returns>true if point inside the shape</returns>
        public bool isPointInside(JsNumber x, JsNumber y) { return false; }
        /// <summary>
        /// Keeps Matrix object, which represents element transformatio
        /// </summary>
        public object matrix { get; set; }
        /// <summary>
        /// Adds event handler for mousedown for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object mousedown(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mousemove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object mousemove(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mouseout for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object mouseout(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mouseover for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object mouseover(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for mouseup for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object mouseup(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Shortcut for assigning event handler for drag.over.[id] event, where id is id of the element (see Element.id).
        /// </summary>
        /// <param name="F">handler for event, first argument would be the element you are dragging over</param>
        public void OnDragOver(JsAction F) { }
        /// <summary>
        /// Internal reference to “paper” where object drawn. Mainly for use in plugins and element extensions.
        /// </summary> 
        ///<example>
        ///usage
        ///<code>
        ///Raphael.el.cross = function () {
        ///this.attr({fill: "red"});
        ///this.paper.path("M10,10L50,50M50,10L10,50")
        /// .attr({stroke: "red"});
        /// </code>
        /// </example>
        public Paper paper { get; set; }
        /// <summary>
        /// Reference to the next element in the hierarchy.
        /// </summary>
        public Next next { get; set; }
        /// <summary>
        /// Gives you a reference to the DOM object, so you can assign event handlers or just mess around. Note: Don’t mess with it.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// // draw a circle at coordinate 10,10 with radius of 10
        /// var c = paper.circle(10, 10, 10);
        /// c.node.onclick = function () {
        /// c.attr("fill", "red");};
        /// </code>
        /// </example>
        public Node node { get; set; }

        /// <summary>
        /// Stops animation of the element with ability to resume it later on.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns></returns>
        public object pause(object anim)
        {
            return null;
        }
        /// <summary>
        /// Reference to the previous element in the hierarchy.
        /// </summary>
        public Prev prev { get; set; }
        /// <summary>
        /// Internal reference to Raphael object. In case it is not available.
        /// </summary>
        public Raphael rapheal { get; set; }

        /// <summary>
        /// Resumes animation if it was paused with Element.pause method.
        /// </summary>
        /// <param name="key">animation object</param>
        /// <returns></returns>
        public object removeData(string key)
        {
            return null;
        }
        /// <summary>
        /// Adds rotation by given angle around given point to the list of transformations of the element.
        /// </summary>
        /// <param name="deg">angle in degrees</param>
        /// <param name="cx">x coordinate of the centre of rotation</param>
        /// <param name="cy">y coordinate of the centre of rotation</param>
        /// <returns></returns>
        public object rotate(JsNumber deg, JsNumber cx, JsNumber cy)
        {
            return null;
        }
        /// <summary>
        /// Adds scale by given amount relative to given point to the list of transformations of the element.
        /// </summary>
        /// <param name="sx">horisontal scale amount</param>
        /// <param name="sy">vertical scale amount</param>
        /// <param name="cx">x coordinate of the centre of scale</param>
        /// <param name="cy">y coordinate of the centre of scale</param>
        /// <returns>Element</returns>
        public object scale(JsNumber sx, JsNumber sy, JsNumber cx, JsNumber cy)
        {
            return null;
        }
        //If cx & cy aren’t specified centre of the shape is used instead.
        /// <summary>
        /// Sets the status of animation of the element in milliseconds. Similar to Element.status method.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <param name="value">number of milliseconds from the beginning of the animation</param>
        /// <returns>number of milliseconds from the beginning of the animation</returns>
        public object setTime(object anim, JsNumber value)
        {
            return null;
        }
        /// <summary>
        /// Makes element visible. See Element.hide.
        /// </summary>
        /// <returns></returns>
        public object show()
        {
            return null;
        }
        /// <summary>
        /// Gets or sets the status of animation of the element.
        /// </summary>
        /// <returns>status if anim is not specified. Array of objects in format:</returns>
        public JsArray<AnimationStatus> status()
        {
            return null;
        }
        /// <summary>
        /// Gets or sets the status of animation of the element.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns>status if anim is not specified. Array of objects in format:</returns>
        public AnimationStatus status(Animation anim)
        {
            return null;
        }

        /// <summary>
        /// Gets or sets the status of animation of the element.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <param name="value">0 – 1. If specified, method works like a setter and sets the status of a given animation to the value. This will cause animation to jump to the given position.</param>
        /// <returns>status</returns>
        public JsNumber status(Animation anim, JsNumber value)
        {
            return null;
        }
        /// <summary>
        /// Stops animation of the element.
        /// </summary>
        /// <param name="anim">animation object</param>
        /// <returns>original element</returns>
        public Element stop(object anim)
        {
            return null;
        }
        /// <summary>
        /// Moves the element so it is the furthest from the viewer’s eyes, behind other elements.
        /// </summary>
        /// <returns></returns>
        public object toBack()
        {
            return null;
        }
        /// <summary>
        /// Moves the element so it is the closest to the viewer’s eyes, on top of other elements.
        /// </summary>
        /// <returns></returns>
        public object toFront()
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchcancel for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object touchcancel(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchend for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object touchend(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchmove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object touchmove(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds event handler for touchstart for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object touchstart(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Adds transformation to the element which is separate to other attributes, i.e.
        /// translation doesn’t change x or y of the rectange. The format of transformation string is similar to the path string syntax:
        /// "t100,100r30,100,100s2,2,100,100r45s1.5"
        /// Each letter is a command. There are four commands: t is for translate, r is for rotate, s is for scale and m is for matrix.
        /// There are also alternative “absolute” translation, rotation and scale: T, R and S.
        /// They will not take previous transformation into account. For example, ...T100,0 will always move element 100 px horisontally,
        /// while ...t100,0 could move it vertically if there is r90 before. Just compare results of r90t100,0 and r90T100,0.
        /// So, the example line above could be read like “translate by 100, 100; rotate 30° around 100, 100;
        /// scale twice around 100, 100; rotate 45° around centre; scale 1.5 times relative to centre”.
        /// As you can see rotate and scale commands have origin coordinates as optional parameters, the default is the centre point of the element.
        /// Matrix accepts six parameters.
        /// </summary>
        /// <param name="tstr"></param>
        /// <returns></returns>
        /// <example>
        /// usage
        /// <code>
        /// var el = paper.rect(10, 20, 300, 200);
        /// // translate 100, 100, rotate 45°, translate -100, 0
        /// el.transform("t100,100r45t-100,0");
        /// // if you want you can append or prepend transformations
        /// el.transform("...t50,50");
        /// el.transform("s2...");
        /// // or even wrap
        /// el.transform("t50,50...t-50-50");
        /// // to reset transformation call method with empty string
        /// el.transform("");
        /// // to get current value call it without parameters
        /// console.log(el.transform());
        /// </code>
        /// </example>
        public JsString transform(JsString tstr) { return null; }
        //TODO: D.check
        ///// <summary>
        ///// Adds transformation to the element which is separate to other attributes, i.e.
        ///// translation doesn’t change x or y of the rectange. The format of transformation string is similar to the path string syntax:
        ///// "t100,100r30,100,100s2,2,100,100r45s1.5"
        ///// Each letter is a command. There are four commands: t is for translate, r is for rotate, s is for scale and m is for matrix.
        ///// There are also alternative “absolute” translation, rotation and scale: T, R and S.
        ///// They will not take previous transformation into account. For example, ...T100,0 will always move element 100 px horisontally,
        ///// while ...t100,0 could move it vertically if there is r90 before. Just compare results of r90t100,0 and r90T100,0.
        ///// So, the example line above could be read like “translate by 100, 100; rotate 30° around 100, 100;
        ///// scale twice around 100, 100; rotate 45° around centre; scale 1.5 times relative to centre”.
        ///// As you can see rotate and scale commands have origin coordinates as optional parameters, the default is the centre point of the element.
        ///// Matrix accepts six parameters.
        ///// </summary>
        ///// <param name="tstr"></param>
        ///// <returns>ELEMENT OR STRING</returns>
        ///// <example>
        ///// usage
        ///// <code>
        ///// var el = paper.rect(10, 20, 300, 200);
        ///// // translate 100, 100, rotate 45°, translate -100, 0
        ///// el.transform("t100,100r45t-100,0");
        ///// // if you want you can append or prepend transformations
        ///// el.transform("...t50,50");
        ///// el.transform("s2...");
        ///// // or even wrap
        ///// el.transform("t50,50...t-50-50");
        ///// // to reset transformation call method with empty string
        ///// el.transform("");
        ///// // to get current value call it without parameters
        ///// console.log(el.transform());
        ///// </code>
        ///// </example>
        //public object transform(JsString tstr) { return null; } 

        /// <summary>
        /// Adds translation by given amount to the list of transformations of the element.
        /// </summary>
        /// <param name="dx">horisontal shift</param>
        /// <param name="dy">vertical shift</param>
        /// <returns></returns>
        public object translate(JsNumber dx, JsNumber dy)
        {
            return null;
        }
        /// <summary>
        /// Removes event handler for click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object unclick(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Removes event handler for double click for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object undblclick(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Removes event handlers for hover for the element.
        /// </summary>
        /// <param name="f_in">handler for hover in</param>
        /// <param name="f_out">handler for hover out</param>
        /// <returns></returns>
        public object unhover(JsAction f_in, JsAction f_out)
        {
            return null;
        }
        /// <summary>
        /// Removes all drag event handlers from given element.
        /// </summary>
        public void undrag() { }

        /// <summary>
        /// Removes event handler for mousedown for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object unmousedown(JsAction handler)
        {
            return null;
        }
        /// <summary>
        ///Removes event handler for mousemove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object unmousemove(JsAction handler)
        {
            return null;
        }
        /// <summary>
        /// Removes event handler for mouseout for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object unmouseout(JsAction handler)
        {
            return null;
        }

        /// <summary>
        /// Removes event handler for unmouseover for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object unmouseover(JsAction handler)
        {
            return null;
        }

        /// <summary>
        /// Removes event handler for unmouseup for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object unmouseup(JsAction handler)
        {
            return null;
        }

        /// <summary>
        /// Removes event handler for untouchcancel for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object untouchcancel(JsAction handler)
        {
            return null;
        }

        /// <summary>
        /// Removes event handler for untouchend for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object untouchend(JsAction handler)
        {
            return null;
        }

        /// <summary>
        /// Removes event handler for untouchmove for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object untouchmove(JsAction handler)
        {
            return null;
        }

        /// <summary>
        /// Removes event handler for untouchstart for the element.
        /// </summary>
        /// <param name="handler">handler for the event</param>
        /// <returns></returns>
        public object untouchstart(JsAction handler)
        {
            return null;
        }



    }
    #endregion

    #region AnimationStatus

    [JsType(JsMode.Json)]
    public class AnimationStatus
    {
        public Animation anim { get; set; }
        public JsNumber status { get; set; }
    }
    #endregion

    #region ElementAttributes

    [JsType(JsMode.Json)]
    public class ElementAttributes
    {
        /// <summary>
        /// arrowhead on the end of the path. The format for string is &lt;type&gt;[-&lt;width>[-&lt;length&gt;]]. Possible types: classic, block, open, oval, diamond, none, width: wide, narrow, midium, length: long, short, midium.
        /// </summary>
        [JsProperty(Name = "'arrow-end'")]
        public string arrow_end { get; set; }
        /// <summary>
        /// comma or space separated values: x, y, width and height
        /// </summary>
        [JsProperty(Name = "'clip-rect'")]
        public string clip_rect { get; set; }
        /// <summary>
        /// CSS type of the cursor
        /// </summary>
        public string cursor { get; set; }
        /// <summary>
        /// the x-axis coordinate of the center of the circle, or ellipse
        /// </summary>
        public JsNumber cx { get; set; }
        /// <summary>
        /// the y-axis coordinate of the center of the circle, or ellipse
        /// </summary>
        public JsNumber cy { get; set; }
        /// <summary>
        /// colour, gradient or image
        /// </summary>
        public string fill { get; set; }
        [JsProperty(Name = "'fill-opacity'")]
        public JsNumber fill_opacity { get; set; }
        public string font { get; set; }
        [JsProperty(Name = "'font-family'")]
        public string font_family { get; set; }
        /// <summary>
        /// font size in pixels
        /// </summary>
        [JsProperty(Name = "'font-size'")]
        public JsNumber font_size { get; set; }
        [JsProperty(Name = "'font-weight'")]
        public string font_weight { get; set; }
        public JsNumber height { get; set; }
        /// <summary>
        /// URL, if specified element behaves as hyperlink
        /// </summary>
        public string href { get; set; }
        public JsNumber opacity { get; set; }
        /// <summary>
        /// SVG path string format
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// radius of the circle, ellipse or rounded corner on the rect
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// horisontal radius of the ellipse
        /// </summary>
        public JsNumber rx { get; set; }
        /// <summary>
        /// vertical radius of the ellipse
        /// </summary>
        public JsNumber ry { get; set; }
        /// <summary>
        /// image URL, only works for Element.image element
        /// </summary>
        public string src { get; set; }
        /// <summary>
        /// stroke colour
        /// </summary>
        public string stroke { get; set; }
        /// <summary>
        /// [“”, “-”, “.”, “-.”, “-..”, “. ”, “- ”, “--”, “- .”, “--.”, “--..”]
        /// </summary>
        [JsProperty(Name = "'stroke-dasharray'")]
        public string stroke_dasharray { get; set; }
        /// <summary>
        /// [“butt”, “square”, “round”]
        /// </summary>
        [JsProperty(Name = "'stroke-linecap'")]
        public string stroke_linecap { get; set; }
        /// <summary>
        /// [“bevel”, “round”, “miter”]
        /// </summary>
        [JsProperty(Name = "'stroke-linejoin'")]
        public string stroke_linejoin { get; set; }
        [JsProperty(Name = "'stroke-miterlimit'")]
        public JsNumber stroke_miterlimit { get; set; }
        [JsProperty(Name = "'stroke-opacity'")]
        public JsNumber stroke_opacity { get; set; }
        /// <summary>
        /// stroke width in pixels, default is '1'
        /// </summary>
        [JsProperty(Name = "'stroke-width'")]
        public JsNumber stroke_width { get; set; }
        /// <summary>
        /// used with href
        /// </summary>
        public string target { get; set; }
        /// <summary>
        /// contents of the text element. Use \n for multiline text
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// [“start”, “middle”, “end”], default is “middle”
        /// </summary>
        [JsProperty(Name = "'text-anchor'")]
        public string text_anchor { get; set; }
        /// <summary>
        /// will create tooltip with a given text
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// see Element.transform
        /// </summary>
        public string transform { get; set; }
        public JsNumber width { get; set; }
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }

    }
    #endregion

    #region DragEventArgs

    [JsType(JsMode.Json)]
    public class DragStartEventArgs
    {
        /// <summary>
        /// x position of the mouse
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// DOM event object
        /// </summary>
        public DOMEvent @event { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragMoveEventArgs
    {
        /// <summary>
        /// shift by x from the start point
        /// </summary>
        public JsNumber dx { get; set; }
        /// <summary>
        /// shift by y from the start point
        /// </summary>
        public JsNumber dy { get; set; }
        /// <summary>
        /// x position of the mouse
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y position of the mouse
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// DOM event object
        /// </summary>
        public DOMEvent @event { get; set; }
    }

    [JsType(JsMode.Json)]
    public class DragEndEventArgs
    {
        /// <summary>
        /// DOM event object
        /// </summary>
        public DOMEvent @event { get; set; }
    }
    #endregion

    #region GetBBoxOptions

    [JsType(JsMode.Json)]
    public class GetBBoxOptions
    {
        /// <summary>
        /// top left corner x
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// top left corner y
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// width
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        /// height
        /// </summary>
        public JsNumber height { get; set; }
    }
    #endregion

    #region GetPointAtLengthOptions

    [JsType(JsMode.Json)]
    public class GetPointAtLengthOptions
    {
        /// <summary>
        /// x coordinate
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y coordinate
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// angle of derivative
        /// </summary>
        public JsNumber alpha { get; set; }
    }
    #endregion

    #region GlowOptions

    [JsType(JsMode.Json)]
    public class GlowOptions
    {
        /// <summary>
        /// size of the glow, default is 10
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        /// will it be filled, default is false
        /// </summary>
        public bool fill { get; set; }

        /// <summary>
        /// opacity, default is 0.5
        /// </summary>
        public JsNumber opacity { get; set; }
        /// <summary>
        /// horizontal offset, default is 0
        /// </summary>
        public JsNumber offsetx { get; set; }
        /// <summary>
        /// vertical offset, default is 0
        /// </summary>
        public JsNumber offsety { get; set; }
        /// <summary>
        /// glow colour, default is black
        /// </summary>
        public string color { get; set; }



    }
    #endregion

    #region Matrix

    [JsType(JsMode.Prototype)]
    public class Matrix
    {
        /// <summary>
        /// Utility method Returns matrix based on given parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <returns>Matrix</returns>
        [JsMethod(OmitNewOperator = true, Name = "Raphael.matrix", Global = true)]
        public Matrix(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber e, JsNumber f)
        {
        }

        /// <summary>
        /// Adds given matrix to existing one.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <param name="matrix"></param>
        public void add(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber e, JsNumber f, object matrix) { }
        /// <summary>
        /// Returns copy of the matrix
        /// </summary>
        /// <returns></returns>
        public Matrix clone()
        {
            return null;
        }
        /// <summary>
        /// Returns inverted version of the matrix
        /// </summary>
        /// <returns></returns>
        public Matrix invert()
        {
            return null;
        }
        /// <summary>
        /// Rotates the matrix
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Matrix rotate(JsNumber a, JsNumber x, JsNumber y) { return null; }
        /// <summary>
        /// Scales the matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        public Matrix scale(JsNumber x, JsNumber y, JsNumber cx, JsNumber cy) { return null; }

        public Matrix split()
        {
            return null;
        }
        /// <summary>
        /// Return transform string that represents given matrix
        /// </summary>
        /// <returns></returns>
        public JsString toTransformString()
        {
            return null;
        }

        /// <summary>
        /// translate the matrix
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void translate(JsNumber x, JsNumber y) { }
        /// <summary>
        /// Return x coordinate for given point after transformation described by the matrix. See also Matrix.y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x</returns>
        public JsNumber x(JsNumber x, JsNumber y)
        {
            return null;
        }
        /// <summary>
        /// Return x coordinate for given point after transformation described by the matrix. See also Matrix.y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>y</returns>
        public JsNumber y(JsNumber x, JsNumber y)
        {
            return null;
        }

    }
    #endregion

    #region SplitOptions

    [JsType(JsMode.Prototype)]
    public class SplitOptions
    {
        /// <summary>
        /// translation by x
        /// </summary>
        public JsNumber dx { get; set; }
        /// <summary>
        /// translation by y
        /// </summary>
        public JsNumber dy { get; set; }
        /// <summary>
        /// scale by x
        /// </summary>
        public JsNumber scalex { get; set; }
        /// <summary>
        /// scale by y
        /// </summary>
        public JsNumber scaley { get; set; }
        /// <summary>
        /// shear
        /// </summary>
        public JsNumber shear { get; set; }
        /// <summary>
        /// rotation in deg
        /// </summary>
        public JsNumber rotate { get; set; }
        /// <summary>
        /// could it be represented via simple transformations
        /// </summary>
        public bool isSimple { get; set; }

    }
    #endregion

    #region Paper

    [JsType(JsMode.Prototype)]
    public class Paper
    {
        /// <summary>
        /// Imports elements in JSON array in format {type: type, [attributes]}
        /// </summary>
        /// <param name="json"></param>
        /// <returns>resulting set of imported elements</returns>
        /// <example>
        /// usage
        /// <code>
        /// paper.add([
        /// {
        /// type: "circle",
        /// cx: 10,
        /// cy: 10,
        /// r: 5
        /// },
        /// {
        /// type: "rect",
        /// x: 10,
        /// y: 10,
        /// width: 10,
        /// height: 10,
        /// fill: "#fc0"
        /// }
        /// ]);
        /// </code>
        /// </example>
        public object add(Array json)
        {
            return null;
        }
        /// <summary>
        /// Points to the bottom element on the paper
        /// </summary>
        public void bottom() { }
        /// <summary>
        /// Shortcut for Paper.customAttributes
        /// </summary>
        public JsObject<JsFunc<object, JsNumber>> ca { get; set; }
        /// <summary>
        /// Draws a circle.
        /// </summary>
        /// <param name="x">x coordinate of the centre</param>
        /// <param name="y">y coordinate of the centre</param>
        /// <param name="r">radius</param>
        /// <returns>Raphaël element object with type “circle”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var c = paper.circle(50, 50, 40);
        /// </code>
        /// </example>
        public Element circle(JsNumber x, JsNumber y, JsNumber r)
        {
            return null;
        }
        /// <summary>
        /// Clears the paper, i.e. removes all the elements.
        /// </summary>
        public void clear() { }
        /// <summary>
        /// If you have a set of attributes that you would like to represent as a function of some number you can do it easily with custom attributes
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// paper.customAttributes.hue = function (num) {
        /// num = num % 1;
        /// return {fill: "hsb(" + num + ", 0.75, 1)"};
        /// };
        /// // Custom attribute “hue” will change fill
        /// // to be given hue with fixed saturation and brightness.
        /// // Now you can use it like this:
        ///var c = paper.circle(10, 10, 10).attr({hue: .45});
        /// // or even like this:
        ///c.animate({hue: 1}, 1e3);
        /// // You could also create custom attribute
        /// // with multiple parameters:
        ///paper.customAttributes.hsb = function (h, s, b) {
        ///return {fill: "hsb(" + [h, s, b].join(",") + ")"};
        ///};
        ///c.attr({hsb: "0.5 .8 1"});
        ///c.animate({hsb: [1, 0, 0.5]}, 1e3);
        /// </code>
        /// </example>
        public JsObject<JsFunc<object, JsNumber>> customAttributes { get; set; }
        /// <summary>
        /// Draws an ellipse.
        /// </summary>
        /// <param name="x">x coordinate of the centre</param>
        /// <param name="y">y coordinate of the centre</param>
        /// <param name="rx">horizontal radius</param>
        /// <param name="ry">vertical radius</param>
        /// <returns>Raphaël element object with type “ellipse”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var c = paper.ellipse(50, 50, 40, 20);
        /// </code>
        /// </example>
        public Element ellipse(JsNumber x, JsNumber y, JsNumber rx, JsNumber ry)
        {
            return null;
        }
        /// <summary>
        /// Executes given function for each element on the paper
        /// If callback function returns false it will stop loop running.
        /// </summary>
        /// <param name="callback">function to run</param>
        /// <param name="thisArg">context object for the callback</param>
        /// <returns>Paper object</returns>
        public object forEach(JsAction callback, object thisArg)
        {
            return null;
        }
        /// <summary>
        /// Returns you element by its internal ID.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Raphaël element object</returns>
        public Element getById(JsNumber id)
        {
            return null;
        }
        /// <summary>
        /// Returns you topmost element under given point.
        /// </summary>
        /// <param name="x">x coordinate from the top left corner of the window</param>
        /// <param name="y">y coordinate from the top left corner of the window</param>
        /// <returns>Raphaël element object</returns>
        /// <example>
        /// usage
        /// <code>
        /// paper.getElementByPoint(mouseX, mouseY).attr({stroke: "#f00"});
        /// </code>
        /// </example>
        public Element getElementByPoint(JsNumber x, JsNumber y)
        {
            return null;
        }
        /// <summary>
        /// Finds font object in the registered fonts by given parameters. You could specify only one word from the font name, like “Myriad” for “Myriad Pro”.
        /// </summary>
        /// <param name="family">font family name or any word from it</param>
        /// <param name="weight">font weight</param>
        /// <param name="style">font style</param>
        /// <param name="stretch">font stretch</param>
        /// <returns>the font object</returns>
        /// <example>
        /// usage
        /// <code>
        /// paper.print(100, 100, "Test string", paper.getFont("Times", 800), 30);
        /// </code>
        /// </example>
        public object getFont(string family, string weight, string style, string stretch)
        {
            return null;
        }
        /// <summary>
        /// Embeds an image into the surface.
        /// </summary>
        /// <param name="src">URI of the source image</param>
        /// <param name="x">x coordinate position</param>
        /// <param name="y">y coordinate position</param>
        /// <param name="width">width of the image</param>
        /// <param name="height">height of the image</param>
        /// <returns>Raphaël element object with type “image”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var c = paper.image("apple.png", 10, 10, 80, 80);
        /// </code>
        /// </example>
        public Element image(string src, JsNumber x, JsNumber y, JsNumber width, JsNumber height)
        {
            return null;
        }
        /// <summary>
        /// Creates a path element by given path data string.
        /// </summary>
        /// <param name="pathString">path string in SVG format.</param>
        /// <example>
        /// usage
        /// <code>
        /// "M10,20L30,40"
        /// </code>
        /// </example>
        /// 
        public Element path(string pathString)
        {
            return null;
        }

        //TODO: not done!!!! 

        /// <summary>
        /// Creates set of shapes to represent given font at given position with given size. Result of the method is set object (see Paper.set) which contains each letter as separate path object.
        /// </summary>
        /// <param name="x">x position of the text</param>
        /// <param name="y">y position of the text</param>
        /// <param name="text">text to print</param>
        /// <param name="font">font object, see Paper.getFont</param>
        /// <param name="size">size of the font, default is 16</param>
        /// <param name="origin">could be "baseline" or "middle", default is "middle"</param>
        /// <param name="letter_spacing">number in range -1..1, default is 0</param>
        /// <returns>resulting set of letters</returns>
        /// <example>
        /// usage
        /// <code>
        /// var txt = r.print(10, 50, "print", r.getFont("Museo"), 30).attr({fill: "#fff"});
        /// // following line will paint first letter in red
        /// txt[0].attr({fill: "#f00"});
        /// </code>
        /// </example>
        public object print(JsNumber x, JsNumber y, string text, object font, JsNumber size, string origin, JsNumber letter_spacing)
        {
            return null;
        }
        /// <summary>
        /// Points to the Raphael object/function
        /// </summary>
        public Raphael rapheal { get; set; }
        /// <summary>
        /// Draws a rectangle.
        /// </summary>
        /// <param name="x">x coordinate of the top left corner</param>
        /// <param name="y">y coordinate of the top left corner</param>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <param name="r">radius for rounded corners, default is 0</param>
        /// <returns>Raphaël element object with type “rect”</returns>
        /// <example>
        /// usage
        /// <code>
        /// // regular rectangle
        /// var c = paper.rect(10, 10, 50, 50);
        /// // rectangle with rounded corners
        /// var c = paper.rect(40, 40, 50, 50, 10);
        /// </code>
        /// </example>
        public Element rect(JsNumber x, JsNumber y, JsNumber width, JsNumber height, JsNumber r)
        {
            return null;
        }
        /// <summary>
        /// Draws a rectangle.
        /// </summary>
        /// <param name="x">x coordinate of the top left corner</param>
        /// <param name="y">y coordinate of the top left corner</param>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <returns>Raphaël element object with type “rect”</returns>
        /// <example>
        /// usage
        /// <code>
        /// // regular rectangle
        /// var c = paper.rect(10, 10, 50, 50);
        /// // rectangle with rounded corners
        /// var c = paper.rect(40, 40, 50, 50, 10);
        /// </code>
        /// </example>
        public Element rect(JsNumber x, JsNumber y, JsNumber width, JsNumber height)
        {
            return null;
        }
        /// <summary>
        /// Removes the paper from the DOM.
        /// </summary>
        public void remove() { }
        /// <summary>
        /// Fixes the issue of Firefox and IE9 regarding subpixel rendering. If paper is dependant on other elements after reflow it could shift half pixel which cause for lines to lost their crispness. This method fixes the issue.
        /// </summary>
        public void renderfix() { }
        /// <summary>
        /// There is an inconvenient rendering bug in Safari (WebKit): sometimes the rendering should be forced. This method should help with dealing with this bug.
        /// </summary>
        public void safari() { }
        /// <summary>
        /// Creates array-like object to keep and operate several elements at once. Warning: it doesn’t create any elements for itself in the page, it just groups existing elements. Sets act as pseudo elements — all methods available to an element can be used on a set.
        /// </summary>
        /// <returns>array-like object that represents set of elements</returns>
        /// <example>
        /// usage
        /// <code>
        /// var st = paper.set();
        /// st.push(
        /// paper.circle(10, 10, 5),
        /// paper.circle(30, 10, 5)
        /// );
        /// st.attr({fill: "red"}); // changes the fill of both circles
        /// </code>
        /// </example>
        public object set()
        {
            return null;
        }
        /// <summary>
        /// See Paper.setStart. This method finishes catching and returns resulting set.
        /// </summary>
        /// <returns>set</returns>
        public object setFinish()
        {
            return null;
        }
        /// <summary>
        /// If you need to change dimensions of the canvas call this method
        /// </summary>
        /// <param name="width">new width of the canvas</param>
        /// <param name="height">new height of the canvas</param>
        public void setSize(JsNumber width, JsNumber height) { }
        /// <summary>
        /// Creates Paper.set. All elements that will be created after calling this method and before calling Paper.setFinish will be added to the set.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// paper.setStart();
        /// paper.circle(10, 10, 5),
        /// paper.circle(30, 10, 5)
        /// var st = paper.setFinish();
        /// st.attr({fill: "red"}); // changes the fill of both circles
        /// </code>
        /// </example>
        public void setStart() { }
        /// <summary>
        /// Sets the view box of the paper. Practically it gives you ability to zoom and pan whole paper surface by specifying new boundaries.
        /// </summary>
        /// <param name="x">new x position, default is 0</param>
        /// <param name="y">new y position, default is 0</param>
        /// <param name="w">new width of the canvas</param>
        /// <param name="h">new height of the canvas</param>
        /// <param name="fit">true if you want graphics to fit into new boundary box</param>
        public void setViewBox(JsNumber x, JsNumber y, JsNumber w, JsNumber h, bool fit) { }
        /// <summary>
        /// Draws a text string. If you need line breaks, put “\n” in the string.
        /// </summary>
        /// <param name="x">x coordinate position</param>
        /// <param name="y">y coordinate position</param>
        /// <param name="text">The text string to draw</param>
        /// <returns>Raphaël element object with type “text”</returns>
        /// <example>
        /// usage
        /// <code>
        /// var t = paper.text(50, 50, "Raphaël\nkicks\nbutt!");
        /// </code>
        /// </example>
        public Element text(JsNumber x, JsNumber y, string text)
        {
            return null;
        }
        /// <summary>
        /// Points to the topmost element on the paper
        /// </summary>
        public Top top { get; set; }
    }
    #endregion

    #region Raphael

    [JsType(JsMode.Prototype, Name = "Raphael")]
    public class Raphael
    {
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="callback">callback function which is going to be executed in the context of newly created paper</param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(HtmlElement container, JsNumber width, JsNumber height, JsAction callback) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="callback">callback function which is going to be executed in the context of newly created paper</param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(JsString container, JsNumber width, JsNumber height, JsAction callback) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(HtmlElement container, JsNumber width, JsNumber height) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(JsString container, JsNumber width, JsNumber height) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="callback">callback function which is going to be executed in the context of newly created paper</param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(JsNumber x, JsNumber y, JsNumber width, JsNumber height, JsAction callback) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(JsNumber x, JsNumber y, JsNumber width, JsNumber height) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="all">(first 3 or 4 elements in the array are equal to [containerID, width, height] or [x, y, width, height]. The rest are element descriptions in format {type: type, [attributes]}). See Paper.add.</param>
        /// <param name="callback">callback function which is going to be executed in the context of newly created paper</param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(JsArray all, JsAction callback) { return null; }
        /// <summary>
        /// Creates a canvas object on which to draw. You must do this first, as all future calls to drawing methods from this instance will be bound to this canvas.
        /// </summary>
        /// <param name="onReadyCallback">function that is going to be called on DOM ready event. You can also subscribe to this event via Eve’s “DOMLoad” event. In this case method returns undefined.</param>
        [JsMethod(Global = true, Name = "Raphael")]
        public static Paper Create(JsAction onReadyCallback) { return null; }
        //TODO: raphael (...) ?!?!

        /// <summary>
        /// Returns angle between two or three points
        /// </summary>
        /// <param name="x1">x coord of first point</param>
        /// <param name="y1">y coord of first point</param>
        /// <param name="x2">x coord of second point</param>
        /// <param name="y2">y coord of second point</param>
        /// <param name="x3">x coord of third point</param>
        /// <param name="y3">y coord of third point</param>
        /// <returns>angle in degrees.</returns>
        public static JsNumber angle(JsNumber x1, JsNumber y1, JsNumber x2, JsNumber y2, JsNumber x3, JsNumber y3)
        {
            return null;
        }
        /// <summary>
        /// Creates an animation object that can be passed to the Element.animate or Element.animateWith methods. See also Animation.delay and Animation.repeat methods.
        /// </summary>
        /// <param name="params">final attributes for the element, see also Element.attr</param>
        /// <param name="ms">number of milliseconds for animation to run</param>
        /// <param name="easing">easing type. Accept one of Raphael.easing_formulas or CSS format: cubic‐bezier(XX, XX, XX, XX)</param>
        /// <param name="callback">callback function. Will be called at the end of animation.</param>
        /// <returns>Animation</returns>
        public static object animation(object @params, JsNumber ms, string easing, JsAction callback)
        {
            return null;
        }
        //TODO: dubble check @params

        /// <summary>
        /// Parses the color string and returns object with all values for the given color.
        /// </summary>
        /// <param name="clr">color string in one of the supported formats (see Raphael.getRGB)</param>
        /// <returns>Combined RGB &amp; HSB object in format:</returns>
        public static object color(string clr)
        {
            return null;
        }
        /// <summary>
        /// Returns RFC4122, version 4 ID
        /// </summary>
        public static void createUUID() { }
        /// <summary>
        /// Transform angle to degrees
        /// </summary>
        /// <param name="deg">angle in radians</param>
        /// <returns>angle in radians</returns>
        public static JsNumber deg(JsNumber deg)
        {
            return null;
        }

        //TODO: Raphael.easing_formulas
        /// <summary>
        /// You can add your own method to elements. This is usefull when you want to hack default functionality or want to wrap some common transformation or attributes in one method. In difference to canvas methods, you can redefine element method at any time. Expending element methods wouldn’t affect set.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// Raphael.el.red = function () {
        /// this.attr({fill: "#f00"});
        /// };
        /// // then use it
        /// paper.circle(100, 100, 20).red();
        /// </code>
        /// </example>
        public object el { get; set; }

        /// <summary>
        /// Utility method Find dot coordinates on the given cubic bezier curve at the given t.
        /// </summary>
        /// <param name="p1x">x of the first point of the curve</param>
        /// <param name="p1y">y of the first point of the curve</param>
        /// <param name="c1x">x of the first anchor of the curve</param>
        /// <param name="c1y">y of the first anchor of the curve</param>
        /// <param name="c2x">x of the second anchor of the curve</param>
        /// <param name="c2y">y of the second anchor of the curve</param>
        /// <param name="p2x">x of the second point of the curve</param>
        /// <param name="p2y">y of the second point of the curve</param>
        /// <param name="t">position on the curve (0..1)</param>
        /// <returns>point information in format:</returns>
        public static object findDotsAtSegment(JsNumber p1x, JsNumber p1y, JsNumber c1x, JsNumber c1y, JsNumber c2x, JsNumber c2y, JsNumber p2x, JsNumber p2y, JsNumber t)
        {
            return null;
        }
        //TODO: grey box information
        /// <summary>
        /// You can add your own method to the canvas. For example if you want to draw a pie chart, you can create your own pie chart function and ship it as a Raphaël plugin. To do this you need to extend the Raphael.fn object. You should modify the fn object before a Raphaël instance is created, otherwise it will take no effect. Please note that the ability for namespaced plugins was removed in Raphael 2.0. It is up to the plugin to ensure any namespacing ensures proper context.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// Raphael.fn.arrow = function (x1, y1, x2, y2, size) {
        /// return this.path( ... );
        /// };
        /// // or create namespace
        /// Raphael.fn.mystuff = {
        /// arrow: function () {…},
        /// star: function () {…},
        /// // etc…
        /// };
        /// var paper = Raphael(10, 10, 630, 480);
        /// // then use it
        /// paper.arrow(10, 10, 30, 30, 5).attr({fill: "#f00"});
        /// paper.mystuff.arrow();
        /// paper.mystuff.star();
        /// </code>
        /// </example>
        public object fn { get; set; }


        //TODO: Raphael.format(token, …) what should i do with "..."?

        /// <summary>
        /// A little bit more advanced format function than Raphael.format. Replaces construction of type “{[name]}” to the corresponding argument.
        /// </summary>
        /// <param name="token">string to format</param>
        /// <param name="json">object which properties will be used as a replacement</param>
        /// <returns>formated string</returns>
        /// <example>
        /// usage
        /// <code>
        /// // this will draw a rectangular shape equivalent to "M10,20h40v50h-40z"
        /// paper.path(Raphael.format("M{x},{y}h{dim.width}v{dim.height}h{dim['negative width']}z", {
        /// x: 10,
        /// y: 20,
        /// dim: {
        /// width: 40,
        /// height: 50,
        /// "negative width": -40
        /// }
        /// }));
        /// </code>
        /// </example>
        public static string fullfill(string token, object json)
        {
            return null;
        }

        /// <summary>
        /// On each call returns next colour in the spectrum. To reset it back to red call Raphael.getColor.reset
        /// </summary>
        /// <param name="value">brightness, default is 0.75</param>
        /// <returns>hex representation of the colour.</returns>
        public static string getColor(JsNumber value)
        {
            return null;
        }
        /// <summary>
        /// Resets spectrum position for Raphael.getColor back to red
        /// </summary>
        /// [JsProperty(Name = "'getColor.reset'")]
        public static void getColor_reset() { }
        //dubble chack with danel

        /// <summary>
        /// Return coordinates of the point located at the given length on the given path.
        /// </summary>
        /// <param name="path">SVG path string</param>
        /// <param name="length"></param>
        /// <returns>representation of the point:</returns>
        public static object getPointAtLength(string path, JsNumber length)
        {
            return null;
        }

        /// <summary>
        /// Parses colour string as RGB object
        /// </summary>
        /// <param name="colour">colour string in one of formats:
        /// Colour name (“red”, “green”, “cornflowerblue”, etc)
        /// #••• — shortened HTML colour: (“#000”, “#fc0”, etc)
        /// #•••••• — full length HTML colour: (“#000000”, “#bd2300”)
        /// rgb(•••, •••, •••) — red, green and blue channels’ values: (“rgb(200, 100, 0)”)
        /// rgb(•••%, •••%, •••%) — same as above, but in %: (“rgb(100%, 175%, 0%)”)
        /// hsb(•••, •••, •••) — hue, saturation and brightness values: (“hsb(0.5, 0.25, 1)”)
        /// hsb(•••%, •••%, •••%) — same as above, but in %
        /// hsl(•••, •••, •••) — same as hsb
        /// hsl(•••%, •••%, •••%) — same as hsb</param>
        /// <returns></returns>
        public GetRGB getRGB(JsString colour) { return null; }
        /// <summary>
        /// Return subpath of a given path from given length to given length.
        /// </summary>
        /// <param name="path">SVG path string</param>
        /// <param name="from">position of the start of the segment</param>
        /// <param name="to">position of the end of the segment</param>
        /// <returns>pathstring for the segment</returns>
        public static string getSubpath(string path, JsNumber from, JsNumber to)
        {
            return null;
        }
        /// <summary>
        /// Returns length of the given path in pixels.
        /// </summary>
        /// <param name="path">SVG path string.</param>
        /// <returns>length.</returns>
        public static JsNumber getTotalLength(string path)
        {
            return null;
        }
        /// <summary>
        /// Converts HSB values to hex representation of the colour.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="b">value or brightness</param>
        /// <returns>hex representation of the colour.</returns>
        public static string hsb(JsNumber h, JsNumber s, JsNumber b)
        {
            return null;
        }
        /// <summary>
        /// Converts HSB values to RGB object.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="v">value or brightness</param>
        /// <returns>RGB object in format:</returns>
        public static object hsb2rgb(JsNumber h, JsNumber s, JsNumber v)
        {
            return null;
        }
        /// <summary>
        /// Converts HSL values to hex representation of the colour.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="l">luminosity</param>
        /// <returns>hex representation of the colour.</returns>
        public static string hsl(JsNumber h, JsNumber s, JsNumber l)
        {
            return null;
        }
        /// <summary>
        /// Converts HSL values to RGB object.
        /// </summary>
        /// <param name="h">hue</param>
        /// <param name="s">saturation</param>
        /// <param name="l">luminosity</param>
        /// <returns>RGB object in format:</returns>
        public static object hsl2rgb(JsNumber h, JsNumber s, JsNumber l)
        {
            return null;
        }

        //Raphael.is(o, type) (is is not good+what should i do with the "..."

        /// <summary>
        /// Utility method Returns matrix based on given parameters.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <returns>Matrix</returns>
        public static Matrix matrix(JsNumber a, JsNumber b, JsNumber c, JsNumber d, JsNumber e, JsNumber f)
        {
            return null;
        }
        /// <summary>
        /// If you want to leave no trace of Raphaël (Well, Raphaël creates only one global variable Raphael, but anyway.) You can use ninja method. Beware, that in this case plugins could stop working, because they are depending on global variable existance.
        /// </summary>
        /// <returns>Raphael object</returns>
        /// <example>
        /// usage
        /// <code>
        /// (function (local_raphael) {
        /// var paper = local_raphael(10, 10, 320, 200);
        /// …
        /// })(Raphael.ninja());
        /// </code>
        /// </example>
        public static object ninja()
        {
            return null;
        }
        /// <summary>
        /// Utility method Parses given path string into an array of arrays of path segments.
        /// </summary>
        /// <param name="pathString">path string or array of segments (in the last case it will be returned straight away)</param>
        /// <returns>array of segments.</returns>
        public JsArray parsePathString(JsString pathString) { return null; }
        /// <summary>
        /// Utility method Parses given path string into an array of arrays of path segments.
        /// </summary>
        /// <param name="pathString">path string or array of segments (in the last case it will be returned straight away)</param>
        /// <returns>array of segments.</returns>
        public JsArray parsePathString(JsArray pathString) { return null; }
        /// <summary>
        /// Utility method Parses given path string into an array of transformations.
        /// </summary>
        /// <param name="TString">Utility method Parses given path string into an array of transformations.</param>
        /// <returns>Utility method Parses given path string into an array of transformations.</returns>
        public JsArray parseTransformString(JsString TString) { return null; }
        /// <summary>
        /// Utility method Parses given path string into an array of transformations.
        /// </summary>
        /// <param name="TString">Utility method Parses given path string into an array of transformations.</param>
        /// <returns>Utility method Parses given path string into an array of transformations.</returns>
        public JsArray parseTransformString(JsArray TString) { return null; }
        /// <summary>
        /// Utility method Converts path to a new path where all segments are cubic bezier curves.
        /// </summary>
        /// <param name="pathString">path string or array of segments</param>
        /// <returns>array of segments.</returns>
        public JsArray path2curve(JsString pathString) { return null; }
        /// <summary>
        /// Utility method Converts path to a new path where all segments are cubic bezier curves.
        /// </summary>
        /// <param name="pathString">path string or array of segments</param>
        /// <returns>array of segments.</returns>
        public JsArray path2curve(JsArray pathString) { return null; }
        /// <summary>
        /// Utility method Return bounding box of a given path
        /// </summary>
        /// <param name="path">path string </param>
        /// <returns>bounding box</returns>
        public BoundingBox pathBBox(JsString path) { return null; }
        /// <summary>
        /// Utility method Finds intersections of two paths
        /// </summary>
        /// <param name="path1">path string</param>
        /// <param name="path2">path string</param>
        /// <returns>dots of intersection</returns>
        public PathIntersection pathIntersection(JsString path1, JsString path2) { return null; }
        //TODO: D.check id ok
        /// <summary>
        /// Utility method Converts path to relative form
        /// </summary>
        /// <param name="pathString">path string or array of segmentS</param>
        /// <returns>array of segments.</returns>
        public JsArray pathToRelative(JsString pathString) { return null; }
        /// <summary>
        /// Utility method Converts path to relative form
        /// </summary>
        /// <param name="pathString">path string or array of segmentS</param>
        /// <returns>array of segments.</returns>
        public JsArray pathToRelative(JsArray pathString) { return null; }
        /// <summary>
        /// Transform angle to radians
        /// </summary>
        /// <param name="deg">angle in degrees</param>
        /// <returns>angle in radians.</returns>
        public JsNumber rad(JsNumber deg) { return null; }
        /// <summary>
        /// Adds given font to the registered set of fonts for Raphaël.
        /// Should be used as an internal call from within Cufón’s font file.
        /// Returns original parameter, so it could be used with chaining.
        /// </summary>
        /// <param name="font">the font to register</param>
        /// <returns>the font you passed in</returns>
        /// <example>
        /// usage
        /// <code>
        /// Cufon.registerFont(Raphael.registerFont({…}));
        /// </code>
        /// </example>
        public object registerFont(object font) { return null; }
        /// <summary>
        /// Converts RGB values to hex representation of the colour.
        /// </summary>
        /// <param name="r">red</param>
        /// <param name="g">green</param>
        /// <param name="b">blue</param>
        /// <returns>hex representation of the colour</returns>
        public JsString rgb(JsNumber r, JsNumber g, JsNumber b) { return null; }
        /// <summary>
        ///Converts RGB values to HSB object.
        /// </summary>
        /// <param name="r">red</param>
        /// <param name="g">green</param>
        /// <param name="b">blue</param>
        /// <returns>HSB object in format:</returns>
        public Rgb2Hsb rgb2hsb(JsNumber r, JsNumber g, JsNumber b) { return null; }
        /// <summary>
        ///Converts RGB values to HSL object.
        /// </summary>
        /// <param name="r">red</param>
        /// <param name="g">green</param>
        /// <param name="b">blue</param>
        /// <returns>HSL object in format:</returns>
        public Rgb2Hsl rgb2hsl(JsNumber r, JsNumber g, JsNumber b) { return null; }
        /// <summary>
        /// Used when you need to draw in <iframe>. Switched window to the iframe one.
        /// </summary>
        /// <param name="newwin">new window object</param>
        public void setWindow(Window newwin) { }
        /// <summary>
        /// Snaps given value to given grid.
        /// </summary>
        /// <param name="values">given array of values or step of the grid</param>
        /// <param name="value">value to adjust</param>
        /// <param name="tolerance">tolerance for snapping. Default is 10.</param>
        /// <returns>adjusted value</returns>
        public JsNumber snapTo(JsArray values, JsNumber value, JsNumber tolerance) { return null; }
        /// <summary>
        /// Snaps given value to given grid.
        /// </summary>
        /// <param name="values">given array of values or step of the grid</param>
        /// <param name="value">value to adjust</param>
        /// <param name="tolerance">tolerance for snapping. Default is 10.</param>
        /// <returns>adjusted value</returns>
        public JsNumber snapTo(JsNumber values, JsNumber value, JsNumber tolerance) { return null; }
        /// <summary>
        /// You can add your own method to elements and sets. It is wise to add a set method for each element method you added,
        /// so you will be able to call the same method on sets too. See also Raphael.el.
        /// </summary>
        /// <example>
        /// usage
        /// <code>
        /// Raphael.el.red = function () {
        /// this.attr({fill: "#f00"});
        /// };
        /// Raphael.st.red = function () {
        /// this.forEach(function (el) {
        /// el.red();
        /// });
        /// };
        /// then use it
        ///paper.set(paper.circle(100, 100, 20), paper.circle(110, 100, 20)).red();
        /// </code>
        /// </example>
        public object st { get; set; }
        /// <summary>
        /// true if browser supports SVG.
        /// </summary>
        public JsBoolean svg { get; set; }
        /// <summary>
        /// Utility method Returns matrix of transformations applied to a given path
        /// </summary>
        /// <param name="path">path string</param>
        /// <param name="transform">transformation string</param>
        /// <returns>Matrix</returns>
        public object toMatrix(JsString path, JsString transform) { return null; }
        /// <summary>
        /// Utility method Returns matrix of transformations applied to a given path
        /// </summary>
        /// <param name="path">path string</param>
        /// <param name="transform">transformation string</param>
        /// <returns>Matrix</returns>
        public object toMatrix(JsString path, JsArray transform) { return null; }
        /// <summary>
        /// Utility method Returns path transformed by a given transformation
        /// </summary>
        /// <param name="path">path string</param>
        /// <param name="transform">transformation string</param>
        /// <returns>path</returns>
        public object transformPath(JsString path, JsString transform) { return null; }
        /// <summary>
        /// Utility method Returns path transformed by a given transformation
        /// </summary>
        /// <param name="path">path string</param>
        /// <param name="transform">transformation string</param>
        /// <returns>path</returns>
        public object transformPath(JsString path, JsArray transform) { return null; }
        /// <summary>
        /// Can be “SVG”, “VML” or empty, depending on browser support.
        /// </summary>
        public JsString type { get; set; }
        /// <summary>
        /// Can be “SVG”, “VML” or empty, depending on browser support.
        /// </summary>
        public JsBoolean vml { get; set; }
    }
    #endregion

    #region Set

    [JsType(JsMode.Prototype)]
    public class Set
    {
        /// <summary>
        /// Removeds all elements from the set
        /// </summary>
        public static void clear () { }
        //TODO: duble check

        /// <summary>
        /// Removes given element from the set
        /// </summary>
        /// <param name="element">element to remove</param>
        /// <returns>true if object was found & removed from the set</returns>
        public JsBoolean exclude(object element) { return null; }
        /// <summary>
        /// Executes given function for each element in the set.
        /// If function returns false it will stop loop running.
        /// </summary>
        /// <param name="callback">function to run</param>
        /// <param name="thisArg">context object for the callback</param>
        /// <returns>Set object</returns>
        public object forEach(JsFunction callback, object thisArg) { return null; }
        /// <summary>
        /// Removes last element and returns it.
        /// </summary>
        /// <returns>element</returns>
        public object pop() { return null; }
        /// <summary>
        /// Adds each argument to the current set.
        /// </summary>
        /// <returns>original element</returns>
        public object push() { return null; }
        /// <summary>
        /// Removes given element from the set
        /// </summary>
        /// <param name="index">position of the deletion</param>
        /// <param name="count">number of element to remove</param>
        /// <param name="insertion">elements to insert</param>
        /// <returns>set elements that were deleted</returns>
        public object splice(JsNumber index, JsNumber count, object insertion) { return null; }
    }

    #endregion

    #region eve

    [JsType(JsMode.Prototype)]
    public class eve
    {
        /// <summary>
        /// Fires event with given name, given scope and other parameters.
        /// </summary>
        /// <param name="name">name of the event, dot (.) or slash (/) separated</param>
        /// <param name="scope">context for the event handlers</param>
        /// <param name="varargs">the rest of arguments will be sent to event handlers</param>
        /// <returns>array of returned values from the listeners</returns>
        [JsMethod(Name="")]
        public static object fire(JsString name, object scope, object varargs) { return null; }
        //TODO: #3 object= "..."

        /// <summary>
        /// Internal method which gives you array of all event handlers that will be triggered by the given name.
        /// </summary>
        /// <param name="name">name of the event, dot (.) or slash (/) separated</param>
        /// <returns>array of event handlers</returns>
        public JsArray listeners(JsString name) { return null; }

        /// <summary>
        /// Could be used inside event handler to figure out actual name of the eve
        /// </summary>
        /// <param name="subname">subname of the event</param>
        /// <returns>true, if current event’s name contains subname</returns>
        public bool nt(JsString subname) { return false; }

        ///// <summary>
        ///// Could be used inside event handler to figure out actual name of the eve
        ///// </summary>
        ///// <param name="subname">subname of the event</param>
        ///// <returns>name of the event, if subname is not specified</returns>
        //public JsString nt(JsString subname) { return null; }

        /// <summary>
        /// Removes given function from the list of event listeners assigned to given name.
        /// </summary>
        /// <param name="name">name of the event, dot (.) or slash (/) separated, with optional wildcard</param>
        /// <param name="f">event handler function</param>
        public void off(JsString name, JsFunction f) { }

        /// <summary>
        /// Binds given event handler with a given name. You can use wildcards “*” for the names:
        /// eve.on("*.under.*", f);
        /// eve("mouse.under.floor"); // triggers f
        /// Use eve to trigger the listener.
        /// </summary>
        /// <param name="name">name of the event, dot (.) or slash (/) separated, with optional wildcards</param>
        /// <param name="f">event handler function</param>
        /// <returns>returned function accepts a single numeric parameter that represents z-index of the handler.
        /// It is an optional feature and only used when you need to ensure that some subset of handlers will be invoked in a given order,
        /// despite of the order of assignmen</returns>
        /// <example>
        /// usage
        /// <code>
        /// eve.on("mouse", eat)(2);
        /// eve.on("mouse", scream);
        /// eve.on("mouse", catch)(1);
        /// This will ensure that catch function will be called before eat. If you want to put your handler before non-indexed handlers, specify a negative value.
        /// Note: I assume most of the time you don’t need to worry about z-index, but it’s nice to have this feature “just in case”.
        /// </code>
        /// </example>
        public JsFunction on(JsString name, JsFunction f) { return null; }

        /// <summary>
        /// Binds given event handler with a given name to only run once then unbind itself.
        /// eve.once("login", f);
        /// eve("login"); // triggers f
        /// eve("login"); // no listeners
        /// Use eve to trigger the listener.
        /// </summary>
        /// <param name="name">name of the event, dot (.) or slash (/) separated, with optional wildcards</param>
        /// <param name="f">event handler function</param>
        /// <returns>same return function as eve.on</returns>
        public JsFunction once(JsString name, JsFunction f) { return null; }

        /// <summary>
        /// Is used inside an event handler to stop the event, preventing any subsequent listeners from firing.
        /// </summary>
        public static void stop() { }
        //TODO: duble chack

        /// <summary>
        /// See eve.off
        /// </summary>
        public static void unbind() { }
        //TODO: duble chack

        /// <summary>
        /// Current version of the library.
        /// </summary>
        public JsString version { get; set; }


    }

    #endregion

    #region ColorOptions

    [JsType(JsMode.Prototype)]
    public class ColorOptions
    {
        /// <summary>
        /// red
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// green
        /// </summary>
        public JsNumber g { get; set; }
        /// <summary>
        /// blue
        /// </summary>
        public JsNumber b { get; set; }
        /// <summary>
        /// color in HTML/CSS format: #••••••,
        /// </summary>
        public string hex { get; set; }
        /// <summary>
        /// true if string can’t be parsed,
        /// </summary>
        public bool error { get; set; }
        /// <summary>
        /// hue
        /// </summary>
        public JsNumber h { get; set; }
        /// <summary>
        /// saturation
        /// </summary>
        public JsNumber s { get; set; }
        /// <summary>
        /// value (brightness),
        /// </summary>
        public JsNumber v { get; set; }
        /// <summary>
        /// lightness
        /// </summary>
        public JsNumber l { get; set; }
    }
    #endregion

    #region Hsb2RgbOptions


    [JsType(JsMode.Prototype)]
    public class Hsb2RgbOptions
    {
        /// <summary>
        /// red
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// green
        /// </summary>
        public JsNumber g { get; set; }
        /// <summary>
        /// blue
        /// </summary>
        public JsNumber b { get; set; }
        /// <summary>
        /// color in HTML/CSS format: #••••••
        /// </summary>
        public string hex { get; set; }
    }
    #endregion

    #region Hsl2RgbOptions

    [JsType(JsMode.Prototype)]
    public class Hsl2RgbOptions
    {
        /// <summary>
        /// red
        /// </summary>
        public JsNumber r { get; set; }
        /// <summary>
        /// green
        /// </summary>
        public JsNumber g { get; set; }
        /// <summary>
        /// blue
        /// </summary>
        public JsNumber b { get; set; }
        /// <summary>
        /// color in HTML/CSS format: #••••••
        /// </summary>
        public string hex { get; set; }
    }
    #endregion

    #region TODO
    public class Prev
    {
    }
    public class Next
    {
    }
    public class Node
    {
    }
    public class Top
    {
    }
    #endregion

    #region BoundingBox
    [JsType(JsMode.Prototype)]
    public class BoundingBox
    {
        /// <summary>
        /// x coordinate of the left top point of the box
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y coordinate of the left top point of the box
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// x coordinate of the right bottom point of the box
        /// </summary>
        public JsNumber x2 { get; set; }
        /// <summary>
        /// x coordinate of the right bottom point of the box
        /// </summary>
        public JsNumber y2 { get; set; }
        /// <summary>
        /// width of the box
        /// </summary>
        public JsNumber width { get; set; }
        /// <summary>
        /// height of the box
        /// </summary>
        public JsNumber height { get; set; }
    }
    #endregion

    #region PathIntersection
    [JsType(JsMode.Prototype)]
    public class PathIntersection
    {
        /// <summary>
        /// x coordinate of the left top point
        /// </summary>
        public JsNumber x { get; set; }
        /// <summary>
        /// y coordinate of the left top point
        /// </summary>
        public JsNumber y { get; set; }
        /// <summary>
        /// t value for segment of path1
        /// </summary>
        public JsNumber t1 { get; set; }
        /// <summary>
        /// t value for segment of path2
        /// </summary>
        public JsNumber t2 { get; set; }
        /// <summary>
        /// order number for segment of path1
        /// </summary>
        public JsNumber segment1 { get; set; }
        /// <summary>
        /// order number for segment of path2
        /// </summary>
        public JsNumber segment2 { get; set; }
        /// <summary>
        /// eight coordinates representing beziér curve for the segment of path1
        /// </summary>
        public JsArray bez1 { get; set; }
        /// <summary>
        /// eight coordinates representing beziér curve for the segment of path2
        /// </summary>
        public JsArray bez2 { get; set; }
    }
    #endregion

    #region Rgb2Hsb
    [JsType(JsMode.Prototype)]
    public class Rgb2Hsb
    {
        /// <summary>
        /// hue
        /// </summary>
        public JsNumber h { get; set; }
        /// <summary>
        /// saturation
        /// </summary>
        public JsNumber s { get; set; }
        /// <summary>
        /// brightness
        /// </summary>
        public JsNumber b { get; set; }

    }
    #endregion

    #region Rgb2Hsl
    [JsType(JsMode.Prototype)]
    public class Rgb2Hsl
        {
            /// <summary>
            /// hue
            /// </summary>
            public JsNumber h { get; set; }
            /// <summary>
            /// saturation
            /// </summary>
            public JsNumber s { get; set; }
            /// <summary>
            /// brightness
            /// </summary>
            public JsNumber b { get; set; }

        }
    #endregion

    #region GetPointAtLength
    [JsType(JsMode.Prototype)]
        public class GetPointAtLength
        {
            /// <summary>
            /// x coordinate
            /// </summary>
            public JsNumber x { get; set; }
            /// <summary>
            /// y coordinate
            /// </summary>
            public JsNumber y { get; set; }
            /// <summary>
            /// angle of derivative
            /// </summary>
            public JsNumber alpha { get; set; }

        }
    #endregion

    #region GetRGB
    [JsType(JsMode.Prototype)]
        public class GetRGB
        {
            /// <summary>
            /// red
            /// </summary>
            public JsNumber r { get; set; }
            /// <summary>
            /// green
            /// </summary>
            public JsNumber g { get; set; }
            /// <summary>
            /// blue
            /// </summary>
            public JsNumber b { get; set; }
            /// <summary>
            /// color in HTML/CSS format: #••••••,
            /// </summary>
            public JsString hex { get; set; }
            /// <summary>
            /// true if string can’t be parsed
            /// </summary>
            public bool error { get; set; }
        }
        #endregion
}