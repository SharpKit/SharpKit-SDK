//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.column
{
    #region Action
    /// <inheritdocs />
    /// <summary>
    /// <p>A Grid header type which renders an icon, or a series of icons in a grid cell, and offers a scoped click
    /// handler for each icon.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.Store">Ext.data.Store</see>', {
    /// storeId:'employeeStore',
    /// fields:['firstname', 'lastname', 'seniority', 'dep', 'hired'],
    /// data:[
    /// {firstname:"Michael", lastname:"Scott"},
    /// {firstname:"Dwight", lastname:"Schrute"},
    /// {firstname:"Jim", lastname:"Halpert"},
    /// {firstname:"Kevin", lastname:"Malone"},
    /// {firstname:"Angela", lastname:"Martin"}
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.grid.Panel">Ext.grid.Panel</see>', {
    /// title: 'Action Column Demo',
    /// store: <see cref="Ext.data.StoreManager.lookup">Ext.data.StoreManager.lookup</see>('employeeStore'),
    /// columns: [
    /// {text: 'First Name',  dataIndex:'firstname'},
    /// {text: 'Last Name',  dataIndex:'lastname'},
    /// {
    /// xtype:'actioncolumn',
    /// width:50,
    /// items: [{
    /// icon: 'extjs/examples/shared/icons/fam/cog_edit.png',  // Use a URL in the icon config
    /// tooltip: 'Edit',
    /// handler: function(grid, rowIndex, colIndex) {
    /// var rec = grid.getStore().getAt(rowIndex);
    /// alert("Edit " + rec.get('firstname'));
    /// }
    /// },{
    /// icon: 'extjs/examples/restful/images/delete.png',
    /// tooltip: 'Delete',
    /// handler: function(grid, rowIndex, colIndex) {
    /// var rec = grid.getStore().getAt(rowIndex);
    /// alert("Terminate " + rec.get('firstname'));
    /// }
    /// }]
    /// }
    /// ],
    /// width: 250,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <p>The action column can be at any index in the columns array, and a grid can have any number of
    /// action columns.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Action : Ext.grid.column.Column
    {
        /// <summary>
        /// The alt text to use for the image element.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString altText;
        /// <summary>
        /// A function which returns the CSS class to apply to the icon image.
        /// </summary>
        public System.Delegate getClass;
        /// <summary>
        /// A function called when the icon is clicked. The table row clicked upon.
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// The URL of an image to display as the clickable element in the column.
        /// Defaults to <c><see cref="Ext.BLANK_IMAGE_URL">Ext.BLANK_IMAGE_URL</see></c>.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// A CSS class to apply to the icon image. To determine the class dynamically, configure the Column with
        /// a getClass function.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// Prevent grid selection upon mousedown.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool stopSelection;
        /// <summary>
        /// Disables this ActionColumn's action at the specified index.
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="silent">
        /// <p>Defaults to: <c>false</c></p></param>
        public void disableAction(object index, object silent=null){}
        /// <summary>
        /// Enables this ActionColumn's action at the specified index.
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <param name="silent">
        /// <p>Defaults to: <c>false</c></p></param>
        public void enableAction(object index, object silent=null){}
        /// <summary>
        /// Process and refire events routed from the GridView's processEvent method.
        /// Also fires any configured click handlers. By default, cancels the mousedown event to prevent selection.
        /// Returns the event handler's status to allow canceling of GridView's bubbling process.
        /// </summary>
        /// <param name="type">
        /// </param>
        /// <param name="view">
        /// </param>
        /// <param name="cell">
        /// </param>
        /// <param name="recordIndex">
        /// </param>
        /// <param name="cellIndex">
        /// </param>
        /// <param name="e">
        /// </param>
        /// <param name="record">
        /// </param>
        /// <param name="row">
        /// </param>
        private void processEvent(object type, object view, object cell, object recordIndex, object cellIndex, object e, object record, object row){}
        public Action(Ext.grid.column.ActionConfig config){}
        public Action(){}
        public Action(params object[] args){}
    }
    #endregion
    #region ActionConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ActionConfig : Ext.grid.column.ColumnConfig
    {
        /// <summary>
        /// The alt text to use for the image element.
        /// Defaults to: <c>&quot;&quot;</c>
        /// </summary>
        public JsString altText;
        /// <summary>
        /// A function which returns the CSS class to apply to the icon image.
        /// </summary>
        public System.Delegate getClass;
        /// <summary>
        /// A function called when the icon is clicked. The table row clicked upon.
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// The URL of an image to display as the clickable element in the column.
        /// Defaults to <c><see cref="Ext.BLANK_IMAGE_URL">Ext.BLANK_IMAGE_URL</see></c>.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// A CSS class to apply to the icon image. To determine the class dynamically, configure the Column with
        /// a getClass function.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// Prevent grid selection upon mousedown.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool stopSelection;
        public ActionConfig(params object[] args){}
    }
    #endregion
    #region ActionEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ActionEvents : Ext.grid.column.ColumnEvents
    {
        public ActionEvents(params object[] args){}
    }
    #endregion
}
