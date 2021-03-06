//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dd
{
    #region DragZone
    /// <inheritdocs />
    /// <summary>
    /// <p>This class provides a container DD instance that allows dragging of multiple child source nodes.</p>
    /// <p>This class does not move the drag target nodes, but a proxy element which may contain any DOM structure you wish. The
    /// DOM element to show in the proxy is provided by either a provided implementation of <see cref="Ext.dd.DragZone.getDragData">getDragData</see>, or by
    /// registered draggables registered with <see cref="Ext.dd.Registry">Ext.dd.Registry</see></p>
    /// <p>If you wish to provide draggability for an arbitrary number of DOM nodes, each of which represent some application
    /// object (For example nodes in a <see cref="Ext.view.View">DataView</see>) then use of this class is the most efficient way to
    /// "activate" those nodes.</p>
    /// <p>By default, this class requires that draggable child nodes are registered with <see cref="Ext.dd.Registry">Ext.dd.Registry</see>. However a
    /// simpler way to allow a DragZone to manage any number of draggable elements is to configure the DragZone with an
    /// implementation of the <see cref="Ext.dd.DragZone.getDragData">getDragData</see> method which interrogates the passed mouse event to see if it has taken
    /// place within an element, or class of elements. This is easily done by using the event's <see cref="Ext.EventObject.getTarget">getTarget</see> method to identify a node based on a <see cref="Ext.dom.Query">Ext.DomQuery</see> selector. For example,
    /// to make the nodes of a DataView draggable, use the following technique. Knowledge of the use of the DataView is
    /// required:</p>
    /// <pre><code>myDataView.on('render', function(v) {
    /// myDataView.dragZone = new <see cref="Ext.dd.DragZone">Ext.dd.DragZone</see>(v.getEl(), {
    /// //      On receipt of a mousedown event, see if it is within a DataView node.
    /// //      Return a drag data object if so.
    /// getDragData: function(e) {
    /// //          Use the DataView's own itemSelector (a mandatory property) to
    /// //          test if the mousedown is within one of the DataView's nodes.
    /// var sourceEl = e.getTarget(v.itemSelector, 10);
    /// //          If the mousedown is within a DataView node, clone the node to produce
    /// //          a ddel element for use by the drag proxy. Also add application data
    /// //          to the returned data object.
    /// if (sourceEl) {
    /// d = sourceEl.cloneNode(true);
    /// d.id = <see cref="Ext.ExtContext.id">Ext.id</see>();
    /// return {
    /// ddel: d,
    /// sourceEl: sourceEl,
    /// repairXY: <see cref="Ext.ExtContext.fly">Ext.fly</see>(sourceEl).getXY(),
    /// sourceStore: v.store,
    /// draggedRecord: v.<see cref="Ext.view.View.getRecord">getRecord</see>(sourceEl)
    /// }
    /// }
    /// },
    /// //      Provide coordinates for the proxy to slide back to on failed drag.
    /// //      This is the original XY coordinates of the draggable element captured
    /// //      in the getDragData method.
    /// getRepairXY: function() {
    /// return this.dragData.repairXY;
    /// }
    /// });
    /// });
    /// </code></pre>
    /// <p>See the <see cref="Ext.dd.DropZone">DropZone</see> documentation for details about building a DropZone which cooperates with
    /// this DragZone.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DragZone : DragSource
    {
        /// <summary>
        /// True to register this container with the Scrollmanager for auto scrolling during drag operations.
        /// </summary>
        public bool containerScroll;
        /// <summary>
        /// This property contains the data representing the dragged object. This data is set up by the implementation of the
        /// getDragData method. It must contain a ddel property, but can contain any other data according to the
        /// application's needs.
        /// </summary>
        public JsObject dragData{get;set;}
        /// <summary>
        /// Called after a repair of an invalid drop. By default, highlights this.dragData.ddel
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        public virtual void afterRepair(){}
        /// <summary>
        /// Called before a repair of an invalid drop to get the XY to animate to. By default returns the XY of
        /// this.dragData.ddel
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="e"><p>The mouse up event</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see>[]</span><div><p>The xy location (e.g. <c>[100, 200]</c>)</p>
        /// </div>
        /// </returns>
        public virtual JsNumber[] getRepairXY(object e){return null;}
        /// <summary>
        /// Called once drag threshold has been reached to initialize the proxy element. By default, it clones the
        /// this.dragData.ddel
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="x"><p>The x position of the click on the dragged object</p>
        /// </param>
        /// <param name="y"><p>The y position of the click on the dragged object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>true to continue the drag, false to cancel</p>
        /// </div>
        /// </returns>
        public virtual bool onInitDrag(JsNumber x, JsNumber y){return false;}
        public DragZone(Ext.dd.DragZoneConfig config){}
        public DragZone(){}
        public DragZone(params object[] args){}
    }
    #endregion
    #region DragZoneConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DragZoneConfig : DragSourceConfig
    {
        /// <summary>
        /// True to register this container with the Scrollmanager for auto scrolling during drag operations.
        /// </summary>
        public bool containerScroll;
        public DragZoneConfig(params object[] args){}
    }
    #endregion
    #region DragZoneEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DragZoneEvents : DragSourceEvents
    {
        public DragZoneEvents(params object[] args){}
    }
    #endregion
}
