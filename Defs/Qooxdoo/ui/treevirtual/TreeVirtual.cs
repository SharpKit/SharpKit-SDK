// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.treevirtual
{
    /// <summary>
	/// <para>A &#8220;virtual&#8221; tree</para>
	/// <para>A number of convenience methods are available in the following mixins:
	/// <list type="bullet">
	/// <item><see cref="qx.ui.treevirtual.MNode"/></item>
	/// <item><see cref="qx.ui.treevirtual.MFamily"/></item>
	/// </list></para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.treevirtual.TreeVirtual", OmitOptionalParameters = true, Export = false)]
    public partial class TreeVirtual : qx.ui.table.Table
    {
		#region Events

		/// <summary>
		/// <para>Fired when the selected rows change.</para>
		/// <para>Event data: An array of node objects (the selected rows&#8217; nodes)
		/// from the data model.  Each node object is described in
		/// <see cref="qx.ui.treevirtual.SimpleTreeDataModel"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		/// <summary>
		/// <para>Fired when a tree branch is closed.</para>
		/// <para>Event data: the node object from the data model (of the node
		/// being closed) as described in
		/// <see cref="qx.ui.treevirtual.SimpleTreeDataModel"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnTreeClose;

		/// <summary>
		/// <para>Fired when an empty tree branch is opened.</para>
		/// <para>Event data: the node object from the data model (of the node
		/// being opened) as described in
		/// <see cref="qx.ui.treevirtual.SimpleTreeDataModel"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnTreeOpenWhileEmpty;

		/// <summary>
		/// <para>Fired when a tree branch which already has content is opened.</para>
		/// <para>Event data: the node object from the data model (of the node
		/// being opened) as described in
		/// <see cref="qx.ui.treevirtual.SimpleTreeDataModel"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnTreeOpenWithContent;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Whether a click on the open/close button should also cause selection of
		/// the row.</para>
		/// </summary>
		[JsProperty(Name = "openCloseClickSelectsRow", NativeField = true)]
		public bool OpenCloseClickSelectsRow { get; set; }

		#endregion Properties

		#region Methods

		public TreeVirtual() { throw new NotImplementedException(); }

		/// <param name="headings">An array containing a list of strings, one for each column, representing the headings for each column.  As a special case, if only one column is to exist, the string representing its heading need not be enclosed in an array.</param>
		/// <param name="custom">A map provided (typically) by subclasses, to override the various supplemental classes allocated within this constructor.  For normal usage, this parameter may be omitted.  Each property must be an object instance or a function which returns an object instance, as indicated by the defaults listed here:   initiallyHiddenColumns  {Array?} A list of column numbers that should be initially invisible. Any column not mentioned will be initially visible, and if no array is provided, all columns will be initially visible.  dataModel new qx.ui.treevirtual.SimpleTreeDataModel() treeDataCellRenderer  Instance of qx.ui.treevirtual.SimpleTreeDataCellRenderer. Custom data cell renderer for the tree column.  treeColumn  The column number in which the tree is to reside, i.e., which column uses the SimpleTreeDataCellRenderer or a subclass of it.  defaultDataCellRenderer  Instance of qx.ui.treevirtual.DefaultDataCellRenderer. Custom data cell renderer for all columns other than the tree column.  dataRowRenderer new qx.ui.treevirtual.SimpleTreeDataRowRenderer() selectionManager    function(obj) { return new qx.ui.treevirtual.SelectionManager(obj); }    tableColumnModel    function(obj) { return new qx.ui.table.columnmodel.Resize(obj); }    </param>
		public TreeVirtual(object headings, object custom = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set whether the open/close button should be displayed on a branch,
		/// even if the branch has no children.</para>
		/// </summary>
		/// <returns>true if tree lines are in use; false otherwise.</returns>
		[JsMethod(Name = "getAlwaysShowOpenCloseSymbol")]
		public bool GetAlwaysShowOpenCloseSymbol() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the data model for this tree.</para>
		/// </summary>
		/// <returns>The data model.</returns>
		[JsMethod(Name = "getDataModel")]
		public qx.ui.table.ITableModel GetDataModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get whether drawing of first-level tree lines should be disabled even
		/// if drawing of tree lines is enabled.
		/// (See also <see cref="GetUseTreeLines"/>)</para>
		/// </summary>
		/// <returns>true if tree lines are in use; false otherwise.</returns>
		[JsMethod(Name = "getExcludeFirstLevelTreeLines")]
		public bool GetExcludeFirstLevelTreeLines() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Obtain the entire hierarchy of labels from the root down to the
		/// specified node.</para>
		/// </summary>
		/// <param name="nodeReference">The node for which the hierarchy is desired.  The node can be represented either by the node object, or the node id (as would have been returned by addBranch(), addLeaf(), etc.)</param>
		/// <returns>The returned array contains one string for each label in the hierarchy of the node specified by the parameter.  Element 0 of the array contains the label of the root node, element 1 contains the label of the node immediately below root in the specified node&#8217;s hierarchy, etc., down to the last element in the array contain the label of the node referenced by the parameter.</returns>
		[JsMethod(Name = "getHierarchy")]
		public JsArray GetHierarchy(object nodeReference) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property openCloseClickSelectsRow.</para>
		/// </summary>
		[JsMethod(Name = "getOpenCloseClickSelectsRow")]
		public bool GetOpenCloseClickSelectsRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the nodes that are currently selected.</para>
		/// </summary>
		/// <returns>An array containing the nodes that are currently selected.</returns>
		[JsMethod(Name = "getSelectedNodes")]
		public JsArray GetSelectedNodes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the selection mode currently in use.</para>
		/// </summary>
		/// <returns>One of the values documented in #setSelectionMode</returns>
		[JsMethod(Name = "getSelectionMode")]
		public double GetSelectionMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get whether lines linking tree children shall be drawn on the tree.</para>
		/// </summary>
		/// <returns>true if tree lines are in use; false otherwise.</returns>
		[JsMethod(Name = "getUseTreeLines")]
		public bool GetUseTreeLines() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property openCloseClickSelectsRow
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property openCloseClickSelectsRow.</param>
		[JsMethod(Name = "initOpenCloseClickSelectsRow")]
		public void InitOpenCloseClickSelectsRow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property openCloseClickSelectsRow equals true.</para>
		/// </summary>
		[JsMethod(Name = "isOpenCloseClickSelectsRow")]
		public void IsOpenCloseClickSelectsRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property openCloseClickSelectsRow.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOpenCloseClickSelectsRow")]
		public void ResetOpenCloseClickSelectsRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set whether the open/close button should be displayed on a branch,
		/// even if the branch has no children.</para>
		/// </summary>
		/// <param name="b">true if the open/close button should be shown; false otherwise.</param>
		[JsMethod(Name = "setAlwaysShowOpenCloseSymbol")]
		public void SetAlwaysShowOpenCloseSymbol(bool b) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set whether drawing of first-level tree-node lines are disabled even
		/// if drawing of tree lines is enabled.</para>
		/// </summary>
		/// <param name="b">true if first-level tree lines should be disabled; false for normal operation.</param>
		[JsMethod(Name = "setExcludeFirstLevelTreeLines")]
		public void SetExcludeFirstLevelTreeLines(bool b) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property openCloseClickSelectsRow.</para>
		/// </summary>
		/// <param name="value">New value for property openCloseClickSelectsRow.</param>
		[JsMethod(Name = "setOpenCloseClickSelectsRow")]
		public void SetOpenCloseClickSelectsRow(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the overflow mode.</para>
		/// </summary>
		/// <param name="s">Overflow mode.  The only allowable mode is &#8220;hidden&#8221;.</param>
		[JsMethod(Name = "setOverflow")]
		public void SetOverflow(string s) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the selection mode.</para>
		/// </summary>
		/// <param name="mode">The selection mode to be used.  It may be any of:   qx.ui.treevirtual.TreeVirtual.SelectionMode.NONE: Nothing can ever be selected.  qx.ui.treevirtual.TreeVirtual.SelectionMode.SINGLE Allow only one selected item.  qx.ui.treevirtual.TreeVirtual.SelectionMode.SINGLE_INTERVAL Allow one contiguous interval of selected items.  qx.ui.treevirtual.TreeVirtual.SelectionMode.MULTIPLE_INTERVAL Allow any selected items, whether contiguous or not. </param>
		[JsMethod(Name = "setSelectionMode")]
		public void SetSelectionMode(double mode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set whether lines linking tree children shall be drawn on the tree.
		/// Note that not all themes support tree lines.  As of the time of this
		/// writing, the Classic theme supports tree lines (and uses +/- icons
		/// which lend themselves to tree lines), while the Modern theme, which
		/// uses right-facing and downward-facing arrows instead of +/-, does not.</para>
		/// </summary>
		/// <param name="b">true if tree lines should be shown; false otherwise.</param>
		[JsMethod(Name = "setUseTreeLines")]
		public void SetUseTreeLines(bool b) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property openCloseClickSelectsRow.</para>
		/// </summary>
		[JsMethod(Name = "toggleOpenCloseClickSelectsRow")]
		public void ToggleOpenCloseClickSelectsRow() { throw new NotImplementedException(); }

		#endregion Methods
    }
}