// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.layer
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>Abstract base class for layers of a virtual pane.</para>
	/// <para>This class queues calls to <see cref="FullUpdate"/>, <see cref="UpdateLayerWindow"/>
	/// and <see cref="UpdateLayerData"/> and only performs the absolute necessary
	/// actions. Concrete implementation of this class must at least implement
	/// the <see cref="#_fullUpdate"/> method. Additionally the two methods
	/// <see cref="#_updateLayerWindow"/> and <see cref="#_updateLayerData"/> may be implemented
	/// to increase the performance.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.layer.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.ui.core.Widget, qx.ui.virtualx.core.ILayer
    {
		#region Properties

		/// <summary>
		/// <para>Whether the widget is anonymous.</para>
		/// <para>Anonymous widgets are ignored in the event hierarchy. This is useful
		/// for combined widgets where the internal structure do not have a custom
		/// appearance with a different styling from the element around. This is
		/// especially true for widgets like checkboxes or buttons where the text
		/// or icon are handled synchronously for state changes to the outer widget.</para>
		/// </summary>
		[JsProperty(Name = "anonymous", NativeField = true)]
		public bool Anonymous { get; set; }

		#endregion Properties

		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Do a complete update of the layer. All cached data should be discarded.
		/// This method is called e.g. after changes to the grid geometry
		/// (row/column sizes, row/column count, ...).</para>
		/// <para>Note: This method can only be called after the widgets initial appear
		/// event has been fired because it may work with the widget&#8217;s DOM elements.</para>
		/// </summary>
		/// <param name="firstRow">Index of the first row to display.</param>
		/// <param name="firstColumn">Index of the first column to display.</param>
		/// <param name="rowSizes">Array of heights for each row to display.</param>
		/// <param name="columnSizes">Array of widths for each column to display.</param>
		[JsMethod(Name = "fullUpdate")]
		public void FullUpdate(double firstRow, double firstColumn, double rowSizes, double columnSizes) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the sizes of the rendered column</para>
		/// </summary>
		/// <returns>List of column widths</returns>
		[JsMethod(Name = "getColumnSizes")]
		public double GetColumnSizes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the first rendered column</para>
		/// </summary>
		/// <returns>The first rendered column</returns>
		[JsMethod(Name = "getFirstColumn")]
		public double GetFirstColumn() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the first rendered row</para>
		/// </summary>
		/// <returns>The first rendered row</returns>
		[JsMethod(Name = "getFirstRow")]
		public double GetFirstRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the sizes of the rendered rows</para>
		/// </summary>
		/// <returns>List of row heights</returns>
		[JsMethod(Name = "getRowSizes")]
		public double GetRowSizes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called during the flush of the
		/// <see cref="qx.ui.core.queue.Widget widget queue"/>.</para>
		/// </summary>
		/// <param name="jobs">A map of jobs.</param>
		[JsMethod(Name = "syncWidget")]
		public void SyncWidget(object jobs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the layer to reflect changes in the data the layer displays.</para>
		/// </summary>
		[JsMethod(Name = "updateLayerData")]
		public void UpdateLayerData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the layer to display a different window of the virtual grid.
		/// This method is called if the pane is scrolled, resized or cells
		/// are prefetched. The implementation can assume that no other grid
		/// data has been changed since the last &#8220;fullUpdate&#8221; of &#8220;updateLayerWindow&#8221;
		/// call.</para>
		/// <para>Note: This method can only be called after the widgets initial appear
		/// event has been fired because it may work with the widget&#8217;s DOM elements.</para>
		/// </summary>
		/// <param name="firstRow">Index of the first row to display.</param>
		/// <param name="firstColumn">Index of the first column to display.</param>
		/// <param name="rowSizes">Array of heights for each row to display.</param>
		/// <param name="columnSizes">Array of widths for each column to display.</param>
		[JsMethod(Name = "updateLayerWindow")]
		public void UpdateLayerWindow(double firstRow, double firstColumn, double rowSizes, double columnSizes) { throw new NotImplementedException(); }

		#endregion Methods
    }
}