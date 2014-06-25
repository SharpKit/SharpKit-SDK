using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.KendoUI.Web;
using SharpKit.Html;
using SharpKit.jQuery;
using SharpKit.KendoUI;


namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class KendoUIWebExtensions
    {

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete<T>(this jQuery query, AutoCompleteConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query, CalendarConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox<T>(this jQuery query, ComboBoxConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDatePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDatePicker(this jQuery query, DatePickerConfiguration configuration) { return null; }

        //TODO: Ask Danel. Add by Lee
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDraggable(this jQuery query) { return null; }
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDraggable(this jQuery query, DraggableConfiguration configuration) { return null; }
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropTarget(this jQuery query) { return null; }
        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropTarget(this jQuery query, DropTargetConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDateTimePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDateTimePicker(this jQuery query, DateTimePickerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropDownList(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropDownList<T>(this jQuery query, DropDownListConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoEditor(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoEditor(this jQuery query, EditorConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoGrid(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoGrid<T>(this jQuery query, GridConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoListView(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoListView<T>(this jQuery query, ListViewConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoMenu(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoMenu(this jQuery query, MenuConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoNumericTextBox(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoNumericTextBox(this jQuery query, NumericTextBoxConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPager(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPager<T>(this jQuery query, PagerConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPanelBar(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPanelBar(this jQuery query, PanelBarConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoRangeSlider(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoRangeSlider(this jQuery query, RangeSliderConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoSlider(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoSlider(this jQuery query, SliderConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoSplitter(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoSplitter(this jQuery query, SplitterConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoTabStrip(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoTabStrip(this jQuery query, TabStripConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoTimePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoTimePicker(this jQuery query, TimePickerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoTreeView(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoTreeView<T>(this jQuery query, TreeViewConfiguration<T> configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoUpload(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoUpload(this jQuery query, UploadConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoWindow(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoValidator(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoValidator(this jQuery query, ValidatorConfiguration configuration) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoWindow(this jQuery query, WindowConfiguration configuration) { return null; }
    }

}

namespace SharpKit.KendoUI.Web
{
    #region Ui

    [JsType(JsMode.Prototype, Name = "kendo.ui", Export = false)]
    public class Ui
    {
        /// <summary>
        /// Helper method for writing new widgets.
        /// Exposes a jQuery plug-in that will handle the widget creation and attach its client-side object in the appropriate data-* attribute.
        /// </summary>
        /// <param name="widget">The widget function.</param>
        /// <param name="register">The object where the reference to the widget is recorded.</param>
        /// <param name="prefix">The plugin function prefix, e.g. "Mobile" will register "kendoMobileFoo".</param>
        public static void plugin(Widget widget, object register, JsString prefix) { }

        /// <summary>
        /// Shows an overlay with a loading message, indicating that an action is in progress.
        /// </summary>
        /// <param name="container">The container that will hold the overlay</param>
        /// <param name="toggle">Whether the overlay should be shown or hidden</param>
        public static void progress(jQuery.jQuery container, bool toggle) { }
    }

    [JsType(JsMode.Prototype, Name = "kendo.ui.Widget", Export = false)]
    public class Widget
    {
        //TODO: undocumented class. used as a type
    }

    #endregion

    #region AutoComplete

    [JsType(JsMode.Prototype, Name = "kendo.ui.AutoComplete", Export = false)]
    public class AutoComplete
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var autocomplete = $("#autocomplete").data("kendoAutoComplete");
        /// // get the dataItem corresponding to the passed index.
        ///var dataItem = autocomplete.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enable/Disable the autocomplete widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // re-render the items in drop-down list.
        ///autocomplete.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // Searches for item which has "Inception" in the name.
        ///autocomplete.search("Inception");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li) { }

        /// <summary>
        /// Forces a suggestion onto the text of the AutoComplete.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the AutoComplete
        /// //
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        /// // force a suggestion to the item with the name "Inception"
        ///autoComplete.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Gets/Sets the value of the autocomplete.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The value of the autocomplete.</returns>
        public JsString value(JsString value) { return null; }
        /// <summary>
        /// Gets/Sets the value of the autocomplete.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The value of the autocomplete.</returns>
        public JsObject value() { return null; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        ///$("#autoComplete").data("kendoAutoComplete").bind("change", function(e) {
        ///    // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    open: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> open
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        ///var onSelect = function(e) {
        ///    // access the selected item via e.item (jQuery object)
        ///};
        ///
        /// // attach select event handler during initialization
        ///var autocomplete = $("#autocomplete").kendoAutoComplete({
        ///    select: onSelect
        ///});
        ///
        /// // detach select event handler via unbind()
        ///autocomplete.data("kendoAutoComplete").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class AutoCompleteConfiguration<T>
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn of the animation.
        /// </summary>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource<T> dataSource { get; set; }
        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { ID: 1, Name: "Item 1" }, { ID: 2, Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({
        ///    dataSource: items,
        ///    dataTextField: "Name"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        ///(default: 200) Specifies the delay in ms after which the AutoComplete will start filtering the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the delay to 500 milliseconds
        ///$("#autoComplete").kendoAutoComplete({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the AutoComplete should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // disable the autocomplete when it is created (enabled by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "startswith") Defines the type of filtration. This value is handled by the remote data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // send a filter value of 'contains' to the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains'
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Sets the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the height of the drop-down list that appears when the autocomplete is activated to 500px
        ///$("#autoComplete").kendoAutoComplete({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autocomplete").kendoAutoComplete({
        ///    highlightFirst: false //no of the suggested items will be highlighted
        ///});
        ///</code>
        ///</example>
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public bool ignoreCase { get; set; }

        /// <summary>
        /// (default: 1) Specifies the minimum number of characters that should be typed before the AutoComplete queries the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // wait until the user types 3 characters before querying the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "")A string that appears in the textbox when it has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //autocomplete initialization
        ///&lt;script>
        ///    $("#autocomplete").kendoAutoComplete({
        ///        dataSource: dataSource,
        ///        placeholder: "Enter value..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: "")Sets the separator for completion. Empty by default, allowing for only one completion.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set completion separator to ,
        ///$("#autoComplete").kendoAutoComplete({
        ///    separator: ", "
        ///});
        ///</code>
        ///</example> 
        public JsString separator { get; set; }

        /// <summary>
        /// (default: false)Controls whether the AutoComplete should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // turn on auto-typing (off by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    suggest: true
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        /// //autocomplete initialization
        /// &lt;script>
        ///     $("#autocomplete").kendoAutoComplete({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         template: kendo.template($("#template").html())
        ///     });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        public JsAction change { get; set; }
        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        public JsAction<Event> select { get; set; }
        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        public JsAction close { get; set; }
        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        public JsAction open { get; set; }

    }

    #endregion

    #region Calendar

    [JsType(JsMode.Prototype, Name = "kendo.ui.Calendar", Export = false)]
    public class Calendar
    {
        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Navigates to view
        /// </summary>
        /// <param name="value">Desired date</param>
        /// <param name="view">Desired view</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to the desired date
        ///calendar.navigate(value, view);
        ///</code>
        ///</example>
        public void navigate(JsDate value, JsString view) { }

        /// <summary>
        /// Navigates to the lower view
        /// </summary>
        /// <param name="value">Desired date</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate down
        ///calendar.navigateDown(value);
        ///</code>
        ///</example>
        public void navigateDown(JsDate value) { }

        /// <summary>
        /// Navigates to the future
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to future
        ///calendar.navigateToFuture();
        ///</code>
        ///</example>
        public void navigateToFuture() { }

        /// <summary>
        /// Navigates to the past
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to past
        ///calendar.navigateToPast();
        ///</code>
        ///</example>
        public void navigateToPast() { }

        /// <summary>
        /// Navigates to the upper view
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate up
        ///calendar.navigateUp();
        ///</code>
        ///</example>
        public void navigateUp() { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsDate value) { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the value of the calendar.
        ///var value = calendar.value();
        /// // set the value of the calendar.
        ///calendar.value(new Date());
        ///</code>
        ///</example>
        public JsDate value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the Kendo UI calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // bind to the change event
        ///calendar.bind("change", function(e) {
        ///     // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"chang\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
        /// <summary>
        /// Fires when navigate
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    navigate: function(e) {
        ///         // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> navigateEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"navigate\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"navigate\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class CalendarConfiguration
    {

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //can manipulate month template depending on this array.
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    depth: "year"
        ///});
        ///</code>
        ///</example>
        public JsString depth { get; set; }

        /// <summary>
        /// Can be boolean or string. Specifies the content of the footer. If false, the footer will not be rendered.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // change the footer text from the default current date
        ///$("#calendar").kendoCalendar({
        ///    footer = "My Custom Footer"
        ///});
        ///</code>
        ///</example>
        public object footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    start: "year"
        ///});
        ///</code>
        ///</example>\
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected date to Jan 1st. 2012
        ///$("#calendar").kendoCalendar({
        ///    value: new Date(2012, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }
        /// <summary>
        /// Fires when the selected date is changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#calendar").kendoCalendar({
        ///     change: function(e) {
        ///         // handle event
        ///     });
        /// });
        /// </code>
        /// </example>
        public JsAction change { get; set; }
        /// <summary>
        /// Fires when navigate.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#calendar").kendoCalendar({
        ///     navigate: function(e) {
        ///         // handle event
        ///     });
        /// });
        /// </code>
        /// </example>
        public JsAction navigate { get; set; }
    }

    [JsType(JsMode.Json)]
    public class MonthConfiguration
    {
        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are in range.
        /// </summary>
        public JsString content { get; set; }

        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are not in the min/max range.
        /// </summary>
        public JsString empty { get; set; }
    }

    #endregion

    #region ComboBox

    [JsType(JsMode.Prototype, Name = "kendo.ui.ComboBox", Export = false)]
    public class ComboBox
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index. If the index is not specified, the selected index will be used.
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the dataItem corresponding to the selectedIndex.
        /// var dataItem = combobox.dataItem();
        /// // get the dataItem corresponding to the passed index.
        /// var dataItem = combobox.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enables/disables the combobox widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Enables/disables the combobox widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable() { }

        /// <summary>
        /// Opens the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI ComboBox
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // re-render the items of the drop-down list.
        ///combobox.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // Searches for item which has "In" in the name.
        /// combobox.search("In");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li) { }
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(JsNumber li) { }
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(JsString li) { }

        /// <summary>
        /// Forces a suggestion onto the text of the ComboBox.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the ComboBox
        /// //
        /// // get a referenence to the Kendo UI ComboBox
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // force a suggestion to the item with the name "Inception"
        /// combobox.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Sets the text of the ComboBox.
        /// </summary>
        /// <param name="text">The text to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public void text(JsString text) { }

        /// <summary>
        /// Gets the text of the ComboBox.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public JsString text() { return null; }

        /// <summary>
        /// Toggles the drop-down list between opened and closed state.
        /// </summary>
        /// <param name="toggle">Defines the whether to open/close the drop-down list.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // toggles the open state of the drop-down list.
        /// combobox.toggle();
        ///</code>
        ///</example>
        public void toggle(bool toggle) { }

        /// <summary>
        /// Sets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }


        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }

    }

    [JsType(JsMode.Json)]
    public class ComboBoxConfiguration<T>
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// Controls whether to bind the widget to the DataSource on initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    autoBind: false
        ///});
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist1").kendoDropDownList();
        ///$("#dropdownlist2").kendoDropDownList({
        ///    cascadeFrom: "dropdownlist1"
        ///});
        ///</code>
        ///</example>
        public JsString cascadeFrom { get; set; }

        /// <summary>
        /// A local JavaScript object or instance of DataSource or the data that the ComboBox will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        public DataSource<T> dataSource { get; set; }

        /// <summary>
        /// A local JavaScript object or instance of DataSource or the data that the ComboBox will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the value content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataValueField { get; set; }

        /// <summary>
        /// (default: 200) Specifies the delay in ms after which the ComboBox will start filtering dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the ComboBox should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "none") Defines the type of filtration. If "none" the ComboBox will not filter the items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    filter: "startswith"
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Define the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    highLightFirst: true
        ///});
        ///</code>
        ///</example>   
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }

        /// <summary>
        /// (default: -1) Defines the initial selected item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataSource: items,
        ///    index: 1 // 0 based from the start of the collection of objects. this selects "Item 2".
        ///});
        ///</code>
        ///</example>
        public JsNumber index { get; set; }

        /// <summary>
        /// (default: 1) Specifies the minimum characters that should be typed before the ComboBox activates
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "") A string that appears in the textbox when the combobox has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        placeholder: "Select..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: false) Controls whether the ComboBox should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    suggest: false
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        ///
        /// //combobox initialization
        /// &lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         dataValueField: "Id",
        ///         template: kendo.template($("#template").html())
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// (default: "") Define the text of the widget, when the autoBind is set to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     autoBind: false,
        ///     text: "Chai"
        ///});
        ///</code>
        ///</example>
        public JsString text { get; set; }

        /// <summary>
        /// (default: "") Define the value of the widget
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     dataSource: ["Item1", "Item2"],
        ///     value: "Item1"
        ///});
        ///</code>
        ///</example>
        public JsString value { get; set; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to instance of the Kendo UI ComboBox
        /// var combobox = $("#comboBox").data("kendoComboBox");
        /// // bind to the change event
        /// combobox.bind("change", function(e) {
        ///    // handle event
        ///});
        /// </code>
        /// </example>
        public JsAction change { get; set; }
        // <summary>
        /// Fires when the value has been selected.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#comboBox").kendoComboBox({
        ///    select: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to instance of the Kendo UI ComboBox
        /// var combobox = $("#comboBox").data("kendoComboBox");
        /// // bind to the change event
        /// combobox.bind("select", function(e) {
        ///    // handle event
        ///});
        /// </code>
        /// </example>
        public JsAction<Event> select { get; set; }
        // <summary>
        /// Fires when the value has been closed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to instance of the Kendo UI ComboBox
        /// var combobox = $("#comboBox").data("kendoComboBox");
        /// // bind to the change event
        /// combobox.bind("close", function(e) {
        ///    // handle event
        ///});
        /// </code>
        /// </example>
        public JsAction close { get; set; }
        // <summary>
        /// Fires when the value has been opened.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to instance of the Kendo UI ComboBox
        /// var combobox = $("#comboBox").data("kendoComboBox");
        /// // bind to the change event
        /// combobox.bind("open", function(e) {
        ///    // handle event
        ///});
        /// </code>
        /// </example>
        public JsAction open { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AnimationConfiguration
    {
        /// <summary>
        /// Animation to be used for closing of the popup
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           close: {
        ///               effects: "fadeOut",
        ///               duration: 300,
        ///               hide: true
        ///               show: false
        ///           }
        ///        }
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public object close { get; set; }

        /// <summary>
        /// Animation to be used for opening of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         animation: {
        ///            open: {
        ///                effects: "fadeIn",
        ///                duration: 300,
        ///                show: true
        ///            }
        ///         }
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public object open { get; set; }

    }

    #endregion

    #region DatePicker

    [JsType(JsMode.Prototype, Name = "kendo.ui.DatePicker", Export = false)]
    public class DatePicker
    {
        /// <summary>
        /// Closes the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Enable/Disable the datePicker widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }
        /// <summary>
        /// Enable/Disable the datePicker widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable() { }

        /// <summary>
        /// Sets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Sets the value of the datePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the datePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the calendar is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the calendar is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class DatePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }
        /// <summary>
        /// Fires when the selected date is changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#datePicker").kendoDatePicker({
        ///     change: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction change { get; set; }
        /// <summary>
        /// Fires when the selected date is opened.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#datePicker").kendoDatePicker({
        ///     open: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction open { get; set; }
        /// <summary>
        /// Fires when the selected date is closed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#datePicker").kendoDatePicker({
        ///     close: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction close { get; set; }

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade",
        ///    depth: "year" // the datePicker will only go to the year level
        ///});
        ///</code>
        ///</example>
        public StartDepthOptions depth { get; set; }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // DatePicker initialization
        /// &lt;script>
        ///     $("#datePicker").kendoDatePicker({
        ///         footer: "Today - #=kendo.toString(data, 'd') #"
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    format: "yyyy/MM/dd",
        ///    parseFormats: ["MMMM yyyy"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade" // the datePicker will start with a decade display
        ///});
        ///</code>
        ///</example> 
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected value to January 1st, 2011
        ///$("#datePicker").kendoDatePicker({
        /// value: new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }


    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum StartDepthOptions
    {
        /// <summary>
        /// shows the days of the month
        /// </summary>
        month,
        /// <summary>
        /// shows the months of the year
        /// </summary>
        year,
        /// <summary>
        /// shows the years of the decade
        /// </summary>
        decade,
        /// <summary>
        /// shows the decades from the centery
        /// </summary>
        century,
    }

    #endregion

    #region DateTimePicker

    [JsType(JsMode.Prototype, Name = "kendo.ui.DateTimePicker", Export = false)]
    public class DateTimePicker
    {

        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close("date");
        ///</code>
        ///</example>
        public void close(ViewOptions view) { }
        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close("date");
        ///</code>
        ///</example>
        public void close(JsString view) { }

        /// <summary>
        /// Enables or disables a DateTimePicker.
        /// </summary>
        /// <param name="enable">Enables (true or undefined) or disables (false) a DateTimePicker.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Enables or disables a DateTimePicker.
        /// </summary>
        /// <param name="enable">Enables (true or undefined) or disables (false) a DateTimePicker.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable() { }

        /// <summary>
        /// Sets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("dateTimePicker").data("kendoDateTimePicker").open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date"</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").open("date");
        ///</code>
        ///</example>
        public void open(ViewOptions view) { }
        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date"</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").open("date");
        ///</code>
        ///</example>
        public void open(JsString view) { }

        /// <summary>
        /// Toggles the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").toggle("date");
        ///</code>
        ///</example>
        public void toggle() { }

        /// <summary>
        /// Toggles the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").toggle("date");
        ///</code>
        ///</example>
        public void toggle(ViewOptions view) { }

        /// <summary>
        /// Sets the value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the DateTimePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }

        /// <summary>
        /// Triggered when the underlying value of a DateTimePicker is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the calendar or the time drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class DateTimePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which are shown in the time drop-down list. If not set, the DateTimePicker will auto-generate the available times.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //the drop-down list will consist only two entries - "10:00 AM" and "10:30 AM"
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade",
        ///    depth: "year" // the datePicker will only go to the year level
        ///});
        ///</code>
        ///</example>
        public StartDepthOptions depth { get; set; }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // DatePicker initialization
        /// &lt;script>
        ///     $("#datePicker").kendoDatePicker({
        ///         footer: "Today - #=kendo.toString(data, 'd') #"
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: 30) Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    interval: 15
        ///});
        ///</code>
        ///</example>
        public JsNumber interval { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    format: "yyyy/MM/dd",
        ///    parseFormats: ["MMMM yyyy"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade" // the datePicker will start with a decade display
        ///});
        ///</code>
        ///</example> 
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: h:mm tt) Specifies the format, which is used to format the values in the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    timeFormat: "HH:mm" //24 hours format
        ///});
        ///</code>
        ///</example>
        public JsString timeFormat { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected value to January 1st, 2011
        ///$("#datePicker").kendoDatePicker({
        /// value: new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }

        /// <summary>
        /// Fires when the selected date is changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#dateTimePicker").kendoDateTimePicker({
        ///     change: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction change { get; set; }
        /// <summary>
        /// Fires when the selected date is opened.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#dateTimePicker").kendoDateTimePicker({
        ///     open: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction<Event> open { get; set; }
        /// <summary>
        /// Fires when the selected date is closed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#dateTimePicker").kendoDateTimePicker({
        ///     close: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction<Event> close { get; set; }

    }

    [JsType(JsMode.Json)]
    public class OpenEventData
    {
        public ViewOptions view { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ViewOptions
    {
        date,
        time,
    }

    #endregion

    #region DropDownList

    [JsType(JsMode.Prototype, Name = "kendo.ui.DropDownList", Export = false)]
    public class DropDownList
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index. If the index is not specified, the selected index will be used.
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the dataItem corresponding to the selectedIndex.
        /// var dataItem = combobox.dataItem();
        /// // get the dataItem corresponding to the passed index.
        /// var dataItem = combobox.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enables/disables the dropdownlist widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }
        /// <summary>
        /// Enables/disables the dropdownlist widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable() { }

        /// <summary>
        /// Opens the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI ComboBox
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // re-render the items of the drop-down list.
        ///combobox.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Selects item, which starts with the provided parameter.
        /// </summary>
        /// <param name="word">The search value.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // Searches for item which has "In" in the name.
        /// combobox.search("In");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(jQuery.jQuery li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsNumber li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"\
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsString li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"\
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsNumber index) { return null; }

        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Sets the text of the dropdownlist.
        /// </summary>
        /// <param name="text">The text to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public void text(JsString text) { }
        /// <summary>
        /// Gets the text of the dropdownlist.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public JsString text() { return null; }

        /// <summary>
        /// Toggles the drop-down list between opened and closed state.
        /// </summary>
        /// <param name="toggle">Defines the whether to open/close the drop-down list.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // toggles the open state of the drop-down list.
        /// combobox.toggle();
        ///</code>
        ///</example>
        public void toggle(bool toggle) { }

        /// <summary>
        /// Sets the value of the dropdownlist. The value will not be set if there is no item with such value. If value is undefined, text of the data item is used.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }
        /// <summary>
        /// Gets the value of the dropdownlist. The value will not be set if there is no item with such value. If value is undefined, text of the data item is used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }


        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }

    }

    [JsType(JsMode.Json)]
    public class DropDownListConfiguration<T>
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: true) Controls whether to bind the widget on initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    autoBind: false
        ///});
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist1").kendoDropDownList();
        ///$("#dropdownlist2").kendoDropDownList({
        ///    cascadeFrom: "dropdownlist1"
        ///});
        ///</code>
        ///</example>
        public JsString cascadeFrom { get; set; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#dropdownlist").kendoDropDownList({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        /// </code>
        /// </example>
        public JsAction change { get; set; }

        /// <summary>
        /// Instance of DataSource or the data that the DropDownList will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        public DataSource<T> dataSource { get; set; }

        /// <summary>
        /// Instance of DataSource or the data that the DropDownList will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the value content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataValueField { get; set; }

        /// <summary>
        /// (default: 500) Specifies the delay in ms before the search text typed by the end user is cleared.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the DropDownList  should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: 200) Define the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public bool ignoreCase { get; set; }

        /// <summary>
        /// (default: 0) Defines the initial selected item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataSource: items,
        ///    index: 1 // 0 based from the start of the collection of objects. this selects "Item 2".
        ///});
        ///</code>
        ///</example>
        public JsNumber index { get; set; }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it directly.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist").kendoDropDownList({
        ///    optionLabel: "Select An Option"
        ///});
        ///</code>
        ///</example>
        public object optionLabel { get; set; }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it directly.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist").kendoDropDownList({
        ///    optionLabel: "Select An Option"
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "optionLabel")]
        public JsString optionLabelString { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        ///
        /// //combobox initialization
        /// &lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         dataValueField: "Id",
        ///         template: kendo.template($("#template").html())
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// (default: "") Define the text of the widget, when the autoBind is set to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     autoBind: false,
        ///     text: "Chai"
        ///});
        ///</code>
        ///</example>
        public JsString text { get; set; }

        /// <summary>
        /// (default: "") Define the value of the widget
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     dataSource: ["Item1", "Item2"],
        ///     value: "Item1"
        ///});
        ///</code>
        ///</example>
        public JsString value { get; set; }
        /// <summary>
        /// Fires when the selected date is selected.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#datePicker").kendoDropDownList({
        ///     select: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction<Event> select { get; set; }
        /// <summary>
        /// Fires when the selected date is opened.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#datePicker").kendoDropDownList({
        ///     open: function() {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction open { get; set; }
        /// <summary>
        /// Fires when the selected date is closed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#datePicker").kendoDropDownList({
        ///     close: function() {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// </example>
        public JsAction close { get; set; }

    }

    #endregion

    #region Editor

    [JsType(JsMode.Prototype, Name = "kendo.ui.Editor", Export = false)]
    public class Editor
    {
        /// <summary>
        /// Creates a W3C-compatible Range object.
        /// </summary>
        /// <param name="document">The document that the range is associated with. If ommited, the document of the editor editing area will be used.</param>
        /// <returns>Range. The created Range object.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///var range = editor.createRange();
        ///</code>
        ///</example>
        public Range createRange(HtmlDocument document) { return null; }

        /// <summary>
        /// Gets the HTML encoded value of the editor.
        /// </summary>
        /// <returns></returns>
        public JsString encodedValue() { return null; }

        /// <summary>
        /// Executes an editor command on the currently selected text.
        /// </summary>
        /// <param name="name">The name of the command to be executed.</param>
        /// <param name="params">The parameters for the executed command.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.exec("bold");
        ///editor.exec("undo");
        ///editor.exec("foreColor", { value: "#ff0000" });
        ///</code>
        ///</example>
        public void exec(JsString name, object @params) { }
        /// <summary>
        /// Executes an editor command on the currently selected text.
        /// </summary>
        /// <param name="name">The name of the command to be executed.</param>
        /// <param name="params">The parameters for the executed command.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.exec("bold");
        ///editor.exec("undo");
        ///editor.exec("foreColor", { value: "#ff0000" });
        ///</code>
        ///</example>
        public void exec(JsString name) { }

        /// <summary>
        /// Focuses the editable area.
        /// </summary>
        public void focus() { }

        /// <summary>
        /// Gets a Range object form the editable area.
        /// </summary>
        /// <returns>Range A W3C-compatible Range object that represents the currently selected text in the editor area.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///var range = editor.getRange();
        ///</code>
        ///</example>
        public Range getRange() { return null; }

        /// <summary>
        /// Gets a W3C-compatible Selection object form the editable area.
        /// </summary>
        /// <returns></returns>
        public Selection getSelection() { return null; }

        /// <summary>
        /// Pastes HTML into the editable area.
        /// </summary>
        /// <param name="html">The HTML to be pasted.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.paste("<p>new content</p>");
        ///</code>
        ///</example>
        public void paste(JsString html) { }

        /// <summary>
        /// Serializes the currently selected text to a XHTML string.
        /// </summary>
        /// <returns>String The selectied text as valid XHTML.</returns>
        public JsString selectedHtml() { return null; }

        /// <summary>
        /// Focuses the editable area and selects the range described by the range parameter.
        /// </summary>
        /// <param name="range">The Range object that describes the new selection.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor"),
        ///    range = editor.createRange();
        ///range.selectNodeContents(editor.body);
        ///editor.selectRange(range);
        ///</code>
        ///</example>
        public void selectRange(Range range) { }

        public event JsAction<EmptyEventData> select
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }
        /// <summary>
        /// Gets or sets the Editor value.
        /// </summary>
        /// <param name="value">
        /// The value to set.
        /// String The value of the Editor as HTML string.
        /// </param>
        /// <returns> String The value of the Editor as HTML string.</returns>
        /// <example>
        /// <code>
        /// var editor = $("#editor").data("kendoEditor");
        /// // set value
        /// editor.value("<p>new content</p>");
        /// // get value
        /// var htmlValue = editor.value();
        /// </code>
        /// </example>
        public JsString value(JsString value) { return null; }
        /// <summary>
        /// Gets or sets the Editor value.
        /// </summary>
        /// <returns> String The value of the Editor as HTML string.</returns>
        /// <example>
        /// <code>
        /// var editor = $("#editor").data("kendoEditor");
        /// // set value
        /// editor.value("<p>new content</p>");
        /// // get value
        /// var htmlValue = editor.value();
        /// </code>
        /// </example>
        public JsString value() { return null; }


    }

    [JsType(JsMode.Json)]
    public class EditorConfiguration
    {
        /// <summary>
        /// (default: true) Indicates whether the Editor should submit encoded HTML tags.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///    encoded: false
        ///});
        ///</code>
        ///</example>
        public bool encoded { get; set; }

        /// <summary>
        /// Allows custom stylesheets to be included within the editing area.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///     stylesheets: [
        ///         "common-styles.css",
        ///         "green-theme.css",
        ///     ]
        /// });
        ///</code>
        ///</example>
        public JsArray stylesheets { get; set; }

        /// <summary>
        /// A collection of tools that should render a button, combobox, etc, to interact with the Editor.
        /// Custom tools are defined as a collection of required properties, while the insertHtml tool requires a collection of text-value pairs
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///    tools: [
        ///        "bold",
        ///        "italic",
        ///        "underline",
        ///        "strikethrough",
        ///        "fontName",
        ///        "fontSize",
        ///        "foreColor",
        ///        "backColor",
        ///        "justifyLeft",
        ///        "justifyCenter",
        ///        "justifyRight",
        ///        "justifyFull",
        ///        "insertUnorderedList",
        ///        "insertOrderedList",
        ///        "indent",
        ///        "outdent",
        ///        "formatBlock",
        ///        "createLink",
        ///        "unlink",
        ///        "insertImage",
        ///        "insertHtml",
        ///        "viewHtml",
        ///        {
        ///            name: "customTool",
        ///            tooltip: "Custom Tool",
        ///            exec: function(e) {
        ///                var editor = $(this).data("kendoEditor");
        ///                // ...
        ///            }
        ///        }
        ///    ],
        ///    insertHtml: [
        ///        { text: "label 1", value: "<p>snippet 1</p>" },
        ///        { text: "label 2", value: "<p>snippet 2</p>" }
        ///    ]
        ///});
        ///</code>
        ///</example>
        public JsArray tools { get; set; }
    }

    #endregion

    #region Grid

    [JsType(JsMode.Prototype, Name = "kendo.ui.Grid", Export = false)]
    public class Grid
    {
        /// <summary>
        /// Adds a new empty table row in edit mode. The addRow method triggers edit event.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.addRow();
        ///</code>
        ///</example>
        public void addRow() { }

        /// <summary>
        /// Cancels any pending changes during. Deleted rows are restored. Inserted rows are removed. Updated rows are restored to their original values.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.cancelChanges();
        ///</code>
        ///</example>
        public void cancelChanges() { }

        /// <summary>
        /// Switch the current edited row into display mode and revert changes made to the data
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.cancelRow();
        ///</code>
        ///</example>
        public void cancelRow() { }

        /// <summary>
        /// Returns the index of the cell in the grid item skipping group and hierarchy cells.
        /// </summary>
        /// <param name="cell">Target cell.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // get the index of the row
        /// // TODO: add specific function call here
        ///</code>
        ///</example>
        public JsNumber cellIndex(JsString cell) { return null; }
        /// <summary>
        /// Returns the index of the cell in the grid item skipping group and hierarchy cells.
        /// </summary>
        /// <param name="cell">Target cell.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // get the index of the row
        /// // TODO: add specific function call here
        ///</code>
        ///</example>
        public JsNumber cellIndex(HtmlElement cell) { return null; }

        /// <summary>
        /// Clears currently selected items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // clear the selection of items in the grid
        ///grid.clearSelection();
        ///</code>
        ///</example>
        public void clearSelection() { }

        /// <summary>
        /// Closes current edited cell.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // close the cell being edited
        ///grid.closeCell();
        ///</code>
        ///</example>
        public void closeCell() { }

        /// <summary>
        /// Collapses specified group.
        /// </summary>
        /// <param name="group">Target group item to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first group item
        /// grid.collapseGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void collapseGroup(JsString group) { }
        /// <summary>
        /// Collapses specified group.
        /// </summary>
        /// <param name="group">Target group item to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first group item
        /// grid.collapseGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void collapseGroup(HtmlElement group) { }

        /// <summary>
        /// Collapses specified master row.
        /// </summary>
        /// <param name="row ">Target master row to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first master row
        /// grid.collapseRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void collapseRow(JsString row) { }
        /// <summary>
        /// Collapses specified master row.
        /// </summary>
        /// <param name="row ">Target master row to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first master row
        /// grid.collapseRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void collapseRow(HtmlElement row) { }

        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(JsString tr) { return null; }
        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(HtmlElement tr) { return null; }

        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(jQuery.jQuery tr) { return null; }

        /// <summary>
        /// Puts the specified table cell in edit mode. It requires a jQuery object representing the cell. The editCell method triggers edit event.
        /// </summary>
        /// <param name="cell">Cell to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // edit first table cell
        ///grid.editCell(grid.tbody.find(">tr>td:first"));
        ///</code>
        ///</example>
        public void editCell(JsString cell) { }

        /// <summary>
        /// Switches the specified row from the grid into edit mode. The editRow method triggers edit event.
        /// </summary>
        /// <param name="row ">Row to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // edit first table row
        /// grid.editRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void editRow(JsString row) { }
        /// <summary>
        /// Switches the specified row from the grid into edit mode. The editRow method triggers edit event.
        /// </summary>
        /// <param name="row ">Row to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // edit first table row
        /// grid.editRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void editRow(HtmlElement row) { }

        /// <summary>
        /// Expands specified group.
        /// </summary>
        /// <param name="group">Target group item to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first group item
        /// grid.expandGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void expandGroup(JsString group) { }
        /// <summary>
        /// Expands specified group.
        /// </summary>
        /// <param name="group">Target group item to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first group item
        /// grid.expandGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void expandGroup(HtmlElement group) { }

        /// <summary>
        /// Expands specified master row.
        /// </summary>
        /// <param name="row ">Target master row to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first master row
        /// grid.expandRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void expandRow(JsString row) { }
        /// <summary>
        /// Expands specified master row.
        /// </summary>
        /// <param name="row ">Target master row to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first master row
        /// grid.expandRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void expandRow(HtmlElement row) { }

        /// <summary>
        /// Redraws the grid using the current data of the DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // refreshes the grid
        /// grid.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Removes the specified row from the grid. The removeRow method triggers remove event. (Note: In inline or popup edit modes the changes will be automatically synced)
        /// </summary>
        /// <param name="row ">Row to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // remove first table row
        /// grid.removeRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void removeRow(JsString row) { }
        /// <summary>
        /// Removes the specified row from the grid. The removeRow method triggers remove event. (Note: In inline or popup edit modes the changes will be automatically synced)
        /// </summary>
        /// <param name="row ">Row to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // remove first table row
        /// grid.removeRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void removeRow(HtmlElement row) { }

        /// <summary>
        /// Calls DataSource sync to submit any pending changes if state is valid. The saveChanges method triggers saveChanges event.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.saveChanges();
        ///</code>
        ///</example>
        public void saveChanges() { }

        /// <summary>
        /// Switch the current edited row into dislay mode and save changes made to the data (Note: the changes will be automatically synced)
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.saveRow();
        ///</code>
        ///</example>
        public void saveRow() { }

        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void select(JsString items) { }
        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void select(HtmlElement items) { }

        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public JsArray select() { return null; }


        /// <summary>
        /// Fires when the grid selection has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the grid has received data from the data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     dataBound: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> dataBound
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"dataBound\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"dataBound\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the grid detail row is collapsed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///  $("#grid").kendoGrid({
        ///     detailCollapse: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailCollapseEventData> detailCollapse
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"detailCollapse\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"detailCollapse\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the grid detail row is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     detailExpand: function(e) {
        ///         // handle event
        ///     }
        /// });
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailCollapseEventData> detailExpand
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"detailExpand\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"detailExpand\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the grid detail is initialized.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     detailInit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailInitEventData> detailInit
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"detailInit\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"detailInit\"")]
            remove { }
        }
        /// <summary>
        /// Fires when the grid enters edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     edit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridEditEventData> edit
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"edit\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"edit\"")]
            remove { }
        }
        /// <summary>
        /// Fires before the grid item is removed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     remove: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridRemoveEventData> remove
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"remove\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"remove\"")]
            remove { }
        }
        /// <summary>
        /// Fires before the grid item is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     save: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridSaveEventData> save
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"save\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"save\"")]
            remove { }
        }
        /// <summary>
        /// Fires before the grid calls DataSource sync.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     saveChanges: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> saveChangesEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"saveChange\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"saveChange\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the user resizes a column.
        /// <code>
        /// // get a reference to the grid
        /// var grid = $("#grid").data("kendoGrid");
        /// bind to the columnResize event
        /// grid.bind("columnResize", function(e) {
        ///    // handle event
        /// });
        /// </code>
        /// </summary>
        public event JsAction<ColumnResizeEventData> columnResize
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"columnResize\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"columnResize\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the user selects a column to show.
        /// Undocumented event.
        /// </summary>
        public event JsAction<EmptyEventData> columnShow
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"columnShow\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"columnShow\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the user selects a column to hide.
        /// Undocumented event.
        /// </summary>
        public event JsAction<EmptyEventData> columnHide
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"columnHide\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"columnHide\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the user reorders the columns of the grid.
        /// Undocumented event.
        /// </summary>
        public event JsAction<ColumnReorderEventData> columnReorder
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"columnReorder\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"columnReorder\"")]
            remove { }
        }
    }

    [JsType(PropertiesAsFields = true)]
    public class ColumnResizeEventData
    {
        public JsObject column { get; set; }
        public JsNumber newWidth { get; set; }
        public JsNumber oldWidth { get; set; }
    }

    [JsType(PropertiesAsFields = true)]
    public class ColumnReorderEventData
    {
        public JsObject column { get; set; }
        public JsNumber newIndex { get; set; }
        public JsNumber oldIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridConfiguration<T>
    {

        /// <summary>
        /// Indicates whether the grid will call read on the DataSource initially.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// A collection of column objects or collection of strings that represents the name of the fields.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var sharedDataSource = new kendo.data.DataSource({
        ///     data: [{title: "Star Wars: A New Hope", year: 1977}, {title: "Star Wars: The Empire Strikes Back", year: 1980}],
        ///     pageSize: 1
        ///});
        ///$("#grid").kendoGrid({
        ///    dataSource: sharedDataSource,
        ///    columns: [ { title: "Action", command: "destroy" }, // creates a column with delete buttons
        ///               { title: "Title", field: "title", width: 200, template: "<div id='title'>${ title }</div>" },
        ///               { title: "Year", field: "year", filterable: false, sortable: true, format: "{0:dd/MMMM/yyyy}" } ];
        ///});
        ///</code>
        ///</example>
        public JsArray<GridColumnConfiguration> columns { get; set; }

        /// <summary>
        /// Undocument property. Add by Lee
        /// (Default: false). 
        /// </summary>
        public bool columnMenu { get; set; }

        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource<T> dataSource { get; set; }
        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// Template to be used for rendering the detail rows in the grid. See the Detail Template example.
        /// </summary>
        public JsAction detailTemplate { get; set; }
        /// <summary>
        /// Fires when the grid selection has changed.
        /// </summary>
        /// <example
        /// <code>
        ///  $("#grid").kendoGrid({
        /// change: function(e) {
        ///     handle event
        ///     }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to the grid
        /// var grid = $("#grid").data("kendoGrid");
        /// // bind to the change event
        /// grid.bind("change", function(e) {
        ///     handle event
        /// });
        /// </code>
        /// </example>
        public JsAction<object> change { get; set; }

        /// <summary>
        /// Fires when the grid has received data from the data source.
        /// </summary>
        /// <example>
        /// <code>
        ///  $("#grid").kendoGrid({
        ///     dataBound: function(e) {
        ///     // handle event
        ///     }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to the grid
        /// var grid = $("#grid").data("kendoGrid");
        /// // bind to the dataBound event
        /// grid.bind("dataBound", function(e) {
        ///     // handle event
        /// });
        /// </code>
        /// </example>
        public JsAction<object> dataBound { get; set; }

        /// <summary>
        /// Fires the first time a grid detail group is expanded.
        /// </summary>
        /// <example>
        /// <code>
        ///  $("#grid").kendoGrid({
        ///     detailInit: function(e) {
        ///     // handle event
        ///     }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to the grid
        /// var grid = $("#grid").data("kendoGrid");
        /// // bind to the detailInit event
        /// grid.bind("detailInit", function(e) {
        ///     // handle event
        /// });
        /// </code>
        /// </example>
        public JsAction<object> detailInit { get; set; }

        /// <summary>
        /// Indicates whether editing is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ]
        ///     toolbar: [
        ///         "create",
        ///         { name: "save", text: "Save This Record" },
        ///         { name: "cancel", template: "&lt;img src="icons/cancel.png' rel='cancel' />" }
        ///     ],
        ///     editable: {
        ///         update: true, // puts the row in edit mode when it is clicked
        ///         destroy: false, // does not remove the row when it is deleted, but marks it for deletion
        ///         confirmation: "Are you sure you want to remove this item?"
        ///     }
        /// });
        ///</code>
        ///</example>   
        public GridEditableConfiguration editable { get; set; }

        /// <summary>
        /// Undocument property. Add by Lee.
        /// </summary>
        [JsProperty(Name = "editable")]
        public bool editableBoolean { get; set; }

        /// <summary>
        /// Undocument property. Add by Lee.
        /// </summary>
        [JsProperty(Name = "editable")]
        public JsString editableString { get; set; }


        /// <summary>
        /// Undocument property added by Lee
        /// </summary>
        public bool filterable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether grouping is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     groupable: true
        /// });
        ///</code>
        ///</example>
        public bool groupable { get; set; }

        /// <summary>
        /// Undocument property added by Lee
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: false) Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     navigatable: true
        /// });
        ///</code>
        ///</example>
        public bool navigatable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "pageable")]
        public bool pageableBoolean { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "pageable")]
        public object pageableObject { get; set; }



        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        public GridPageableConfiguration pageable { get; set; }

        /// <summary>
        /// Undocument property. Added by Lee
        /// (Default: false). Specifies whether given column is reorderable.
        /// </summary>
        public bool reorderable { get; set; }

        /// <summary>
        /// Undocument property, add by Lee
        /// default: false
        /// Specifies whether given column is resizeable.
        /// </summary>
        public bool resizable { get; set; }

        /// <summary>
        /// Template to be used for rendering the rows in the grid.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        /// &lt;script id="rowTemplate" type="text/x-kendo-tmpl">
        ///     &lt;tr>
        ///         &lt;td>
        ///             &lt;img src="${ BoxArt.SmallUrl }" alt="${ Name }" />
        ///         &lt;/td>
        ///         &lt;td>
        ///             ${ Name }
        ///         &lt;/td>
        ///         &lt;td>
        ///             ${ AverageRating }
        ///         &lt;/td>
        ///     &lt;/tr>
        /// &lt;/script>
        ///
        /// //grid intialization
        /// &lt;script>PO details informaiton
        ///     $("#grid").kendoGrid({
        ///         dataSource: dataSource,
        ///         rowTemplate: kendo.template($("#rowTemplate").html()),
        ///         height: 200
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsFunc<JsString, JsString> rowTemplate { get; set; }

        /// <summary>
        /// (default: true) Enable/disable grid scrolling. Possible values:
        /// true
        ///Enables grid vertical scrolling
        ///false
        ///Disables grid vertical scrolling
        ///{ virtual: false }
        ///Enables grid vertical scrolling without data virtualization. Same as first option.
        ///{ virtual: true }
        ///Enables grid vertical scrolling with data virtualization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     scrollable: {
        ///         virtual: true //false
        ///     }
        /// });
        ///</code>
        ///</example>
        public bool scrollable { get; set; }
        /// <summary>
        /// (default: true) Enable/disable grid scrolling. Possible values:
        /// true
        ///Enables grid vertical scrolling
        ///false
        ///Disables grid vertical scrolling
        ///{ virtual: false }
        ///Enables grid vertical scrolling without data virtualization. Same as first option.
        ///{ virtual: true }
        ///Enables grid vertical scrolling with data virtualization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     scrollable: {
        ///         virtual: true //false
        ///     }
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "scrollable")]
        public object scrollableObject { get; set; }

        /// <summary>
        /// Indicates whether selection is enabled/disabled. 
        /// "row": Single row selection.
        /// "cell": Single cell selection.
        /// "multiple, row": Multiple row selection.
        /// "multiple, cell": Multiple cell selection.
        /// </summary>
        public JsString selectable { get; set; }

        /// <summary>
        /// Defines whether grid columns are sortable.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     sortable: true
        /// });
        /// //
        /// // or
        /// //
        /// $("#grid").kendoGrid({
        ///     sortable: {
        ///         mode: "multiple", // enables multi-column sorting
        ///         allowUnsort: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "sortable")]
        public GridSortableConfiguration sortableConfiguration { get; set; }

        /// <summary>
        /// Undocument property
        /// Default: false
        /// Specifies whether given column is sortable.
        /// </summary>
        [JsProperty(Name = "sortable")]
        public bool sortableBoolean { get; set; }

        /// <summary>
        /// Can be boolean or configuration, please use the typed property instead
        /// </summary>
        public object sortable { get; set; }


        /// <summary>
        /// This is a list of commands for which the corresponding buttons will be rendered. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        public GridSortableToolbarConfiguration toolbar { get; set; }

        /// <summary>
        /// This is a list of commands for which the corresponding buttons will be rendered. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "toolbar")]
        public GridSortableToolbarCommandsOptions toolbarBuildInCommands { get; set; }
        //TODO: check if neeeded 



    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum GridSelectableOptions
    {
        /// <summary>
        /// Single row selection.
        /// </summary>
        row,
        /// <summary>
        /// Single cell selection.
        /// </summary>
        cell,
        /// <summary>
        /// Multiple row selection.
        /// </summary>
        multipleRow,
        /// <summary>
        /// Multiple cell selection.
        /// </summary>
        multipleCell

    }

    /// <summary>
    /// Provides a way to specify custom editor for this column.
    /// </summary>
    /// <param name="container">The container in which the editor must be added.</param>
    /// <param name="options">Additional options.</param>
    public delegate void GridColumnsEditorCallback(jQuery.jQuery container, GridColumnsEditorOptionsConfiguration options);

    [JsType(JsMode.Json)]
    public class GridColumnConfiguration
    {
        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        public GridColumnsCommandOptions command { get; set; }

        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "command")]
        public JsString commandString { get; set; }
        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "command")]
        public JsArray<JsString> commandStringArray { get; set; }
        /// <summary>
        /// Provides a way to specify custom editor for this column.
        /// </summary>
        public GridColumnsEditorCallback editor { get; set; }

        /// <summary>
        /// (default: true) Specified whether the column content is escaped. Disable encoding if the data contains HTML markup.
        /// </summary>
        public bool encoded { get; set; }

        /// <summary>
        /// The field from the datasource that will be displayed in the column.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// (default: true) Specifies whether given column is filterable.
        /// </summary>
        public bool filterable { get; set; }

        /// <summary>
        /// The format that will be applied on the column cells.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             format: "{0:dd/MMMM/yyyy}"
        ///        }
        ///     ]
        ///  });
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: true) Specifies whether given column is sortable.
        /// </summary>
        public bool sortable { get; set; }

        /// <summary>
        /// The template for column's cells.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ]
        ///  });
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// The text that will be displayed in the column header.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// The width of the column.
        /// </summary>
        [JsProperty(Name = "width")]
        public JsString widthString { get; set; }
        /// <summary>
        /// Undocument property type. Add by Lee
        /// The width of the column.
        /// </summary>
        [JsProperty(Name = "width")]
        public JsNumber widthNumber { get; set; }
        /// <summary>
        /// The width of the column.
        /// Please use the correct type. 
        /// </summary>
        public object width { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum GridColumnsCommandOptions
    {
        create,
        cancel,
        save,
        destroy,

    }

    [JsType(JsMode.Json)]
    public class GridColumnsEditorOptionsConfiguration
    {
        /// <summary>
        /// The field for the editor.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// The model for the editor.
        /// </summary>
        public object model { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridEditableConfiguration
    {
        /// <summary>
        /// Defines the text that will be used in confirmation box when delete an item.
        /// </summary>
        public bool confirmation { get; set; }
        /// <summary>
        /// Defines the text that will be used in confirmation box when delete an item.
        /// </summary>
        [JsProperty(Name = "confirmation")]
        public JsString confirmationString { get; set; }

        /// <summary>
        /// Indicates whether item should be deleted when click on delete button.
        /// </summary>
        public bool destroy { get; set; }

        /// <summary>
        /// Indicates which of the available edit modes(incell(default)/inline/popup) will be used
        /// </summary>
        public JsString mode { get; set; }

        /// <summary>
        /// Template which will be use during popup editing
        /// </summary>
        public JsString template { get; set; }

        /// <summary>
        /// Indicates whether item should be switched to edit mode on click.
        /// </summary>
        public bool update { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridPageableConfiguration
    {
        /// <summary>
        /// Defines the number of records which will be displyed.
        /// </summary>
        public JsNumber pageSize { get; set; }

        /// <summary>
        /// (default: true) Defines if buttons for navigating to the first, last, previous and next pages will be shown.
        /// </summary>
        public bool previousNext { get; set; }

        /// <summary>
        /// (default: true) Defines if numeric portion of the pager will be shown.
        /// </summary>
        public bool numeric { get; set; }

        /// <summary>
        /// (default: 10) Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        public JsNumber buttonCount { get; set; }

        /// <summary>
        /// (default: false) Defines if an input element which allows the user to navigate to given page will be displayed.
        /// </summary>
        public bool input { get; set; }

        /// <summary>
        /// (default: false)Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        public bool pageSizes { get; set; }
        /// <summary>
        /// (default: [5,10,20])Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        [JsProperty(Name = "pageSizes")]
        public JsArray pageSizesArray { get; set; }

        /// <summary>
        /// (default: false) Defines if a refresh button will be displayed.
        /// </summary>
        public bool refresh { get; set; }

        /// <summary>
        /// (default: true) Defines if a label showing current paging information will be displayed.
        /// </summary>
        public bool info { get; set; }

        /// <summary>
        /// Defines texts shown within the pager.
        /// </summary>
        public GridPageableMessagesConfiguration messages { get; set; }

    }

    [JsType(JsMode.Json)]
    public class GridPageableMessagesConfiguration
    {
        /// <summary>
        /// (default: "{0} - {1} of {2} items"), Defines the info text.
        /// </summary>
        public JsString display { get; set; }

        /// <summary>
        /// (default: "No items to display"), Defines the info text shown when there are no records to be displayed.
        /// </summary>
        public JsString empty { get; set; }

        /// <summary>
        /// (default: "Page"), Defines the first part of the text of the input option.
        /// </summary>
        public JsString page { get; set; }

        /// <summary>
        /// (default: "of {0}"), Defines the last part of the text of the input option.
        /// </summary>
        public JsString of { get; set; }

        /// <summary>
        /// (default: "items per page"), Defines the text displayed after the select element of the pageSizes mode.
        /// </summary>
        public JsString itemsPerPage { get; set; }

        /// <summary>
        /// (default: "Go to the first page"), Defines the text of the first page button tooltip.
        /// </summary>
        public JsString first { get; set; }

        /// <summary>
        /// (default: "Go to the previous page"), Defines the text of the previous page button tooltip.
        /// </summary>
        public JsString previous { get; set; }

        /// <summary>
        /// (default: "Go to the next page"), Defines the text of the next page button tooltip.
        /// </summary>
        public JsString next { get; set; }

        /// <summary>
        /// (default: "Go to the last page"), Defines the text of the last page button tooltip.
        /// </summary>
        public JsString last { get; set; }

        /// <summary>
        /// (default: "Refresh"), Defines the text of the refresh button tooltip.
        /// </summary>
        public JsString refresh { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridSortableConfiguration
    {
        /// <summary>
        /// (default: false) Defines whether column can have unsorted state.
        /// </summary>
        public bool allowUnsort { get; set; }

        public GridSortableModeOptions mode { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum GridSortableModeOptions
    {
        /// <summary>
        /// Defines that only once column can be sorted at a time.
        /// </summary>
        single,
        /// <summary>
        /// Defines that multiple columns can be sorted at a time.
        /// </summary>
        multiple,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum GridSortableToolbarCommandsOptions
    {
        create,
        cancel,
        save,
        destroy,
    }

    [JsType(JsMode.Json)]
    public class GridSortableToolbarConfiguration
    {
        /// <summary>
        /// The name of the command. One of the predefined or a custom.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The template for the command button.
        /// </summary>
        public JsString template { get; set; }

        /// <summary>
        /// The text of the command that will be set on the button.
        /// </summary>
        public JsString text { get; set; }

    }

    [JsType(JsMode.Json)]
    public class GridDetailCollapseEventData
    {
        /// <summary>
        /// The jQuery element representing master row.
        /// </summary>
        public object masterRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail row.
        /// </summary>
        public object detailRow { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridDetailInitEventData
    {
        /// <summary>
        /// The jQuery element representing master row.
        /// </summary>
        public object masterRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail row.
        /// </summary>
        public object detailRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail cell.
        /// </summary>
        public object detailCell { get; set; }

        /// <summary>
        /// The data for the master row.
        /// </summary>
        public object data { get; set; }

    }

    [JsType(JsMode.Json)]
    public class GridEditEventData
    {
        /// <summary>
        /// The jQuery element to be edited.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// The model to be edited.
        /// </summary>
        public object model { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridRemoveEventData
    {
        /// <summary>
        /// The row element to be deleted.
        /// </summary>
        public object row { get; set; }

        /// <summary>
        /// The model which to be deleted.
        /// </summary>
        public object model { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GridSaveEventData
    {
        /// <summary>
        /// The values entered by the user.
        /// </summary>
        public object values { get; set; }

        /// <summary>
        /// The jQuery element which is in edit mode.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// The edited model.
        /// </summary>
        public object model { get; set; }
    }

    #endregion

    #region ListView

    [JsType(JsMode.Prototype, Name = "kendo.ui.ListView", Export = false)]
    public class ListView<T>
    {

        /// <summary>
        /// Inserts empty item as first item on the current view and prepare it for editing.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        ///var listView = $("#listView").data("kendoListView");
        /// // add item
        ///listView.add();
        ///</code>
        ///</example>
        public void add() { }

        /// <summary>
        /// Cancels changes in currently edited item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // cancel changes in currently edited item
        /// listView.cancel();
        ///</code>
        ///</example>
        public void cancel() { }

        /// <summary>
        /// Clears ListView selected items and triggers change event.
        /// </summary>
        public void clearSelection() { }

        /// <summary>
        /// Edit specified ListView item. Triggers edit event.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.edit(listView.element.children().first());
        ///</code>
        ///</example>
        public void edit(jQuery.jQuery item) { }
        /// <summary>
        /// Edit specified ListView item. Triggers edit event.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.edit(listView.element.children().first());
        ///</code>
        ///</example>
        public void edit(Model<T> item) { }
        //TODO: danel not sure. d.check

        /// <summary>
        /// Reloads the data and repaints the list view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var listView = $("#listView").data("kendoListView");
        /// // refreshes the list view
        /// listView.refresh();
        ///</code>
        ///</example>   
        public void refresh() { }

        /// <summary>
        /// Removes specified ListView item. Triggers remove event and if not prevented calls DataSource sync method.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.remove(listView.element.children().first());
        ///</code>
        ///</example>
        public void remove(jQuery.jQuery item) { }
        /// <summary>
        /// Removes specified ListView item. Triggers remove event and if not prevented calls DataSource sync method.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.remove(listView.element.children().first());
        ///</code>
        ///</example>
        public void remove(Model<T> item) { }
        //TODO: danel not sure. d.check

        /// <summary>
        /// Saves edited ListView item. If validation succeeds will call DataSource sync method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.edit(listView.element.children().first());
        /// // save edited item
        /// listView.save();
        ///</code>
        ///</example>   
        public void save() { }

        /// <summary>
        /// Selects the specified ListView item. If called without arguments - returns the selected items.
        /// </summary>
        /// <param name="items">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // selects first list view item
        /// listView.select(listView.element.children().first());
        ///</code>
        ///</example>
        public void select(JsString items) { }
        //TODO: "If called without arguments - returns the selected items." (?)
        /// <summary>
        /// Selects the specified ListView item. If called without arguments - returns the selected items.
        /// </summary>
        /// <param name="items">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // selects first list view item
        /// listView.select(listView.element.children().first());
        ///</code>
        ///</example>
        public void select(JsArray items) { }
        //TODO: "If called without arguments - returns the selected items." (?)

        /// <summary>
        /// Selects the specified ListView item. If called without arguments - returns the selected items.
        /// </summary>
        /// <param name="items">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // selects first list view item
        /// listView.select(listView.element.children().first());
        ///</code>
        ///</example>
        public JsArray select() { return null; }

        /// <summary>
        /// Fires when the list view selection has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the list view has received data from the data source. and is about to render it.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     dataBound: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> dataBound
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"dateBound\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"DataBound\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the grid enters edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     edit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<ListViewEditEventData> editEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"edit\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"edit\"")]
            remove { }
        }
        //TODO: event name is edit

        /// <summary>
        /// Fires when the list view  item is removed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     remove: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<ListViewRemoveEventData> removeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"remove\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"remove\"")]
            remove { }
        }
        //TODO: event name is remove
    }

    [JsType(JsMode.Json)]
    public class ListViewConfiguration<T>
    {

        /// <summary>
        /// (default: true) Indicates whether the list view will call read on the DataSource initially.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource<T> dataSource { get; set; }
        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// Specifies ListView item template in edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#listView").kendoListView({
        ///     dataSource: {
        ///         data: createRandomData(50)
        ///     },
        ///     template: kendo.template($("#template").html()),
        ///     editTemplate: kendo.template($("#editTemplate").html())
        /// });
        ///</code>
        ///</example>
        public JsFunc<JsString, JsString> editTemplate { get; set; }

        /// <summary>
        /// (default: false) Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     navigatable: true
        /// });
        ///</code>
        ///</example>
        public bool navigatable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether selection is enabled/disabled.  Possible values:
        /// true
        /// Single item selection.
        /// "single"
        /// Single item selection.
        /// "multiple"
        /// Multiple item selection.
        /// </summary>
        [JsProperty(Name = "selectable")]
        public bool selectableBool { get; set; }

        /// <summary>
        /// (default: false) Indicates whether selection is enabled/disabled.  Possible values:
        /// true
        ///     Single item selection.
        /// "single"
        ///     Single item selection.
        /// "multiple"
        ///     Multiple item selection.
        /// </summary>
        [JsProperty(Name = "selectable")]
        public JsString selectableString { get; set; }

        /// <summary>
        /// (default: false) Indicates whether selection is enabled/disabled.
        /// Please use the right type: bool or string.  
        /// </summary>
        public object selectable { get; set; }

        /// <summary>
        /// Specifies ListView item template.
        /// </summary>
        /// <example>
        /// <code>
        /// <script type="text/x-kendo-tmpl" id="template">
        /// <div>
        /// <dl>
        /// <dt>Name</dt> <dd>${Name}</dd>
        /// <dt>Birth Date</dt> <dd>${BirdthDate}</dd>
        /// </dl>
        /// </div>
        /// </script>
        /// </code>
        /// </example>
        /// <example>
        /// <code>
        /// $("#listView").kendoListView({
        ///     dataSource: {
        ///         data: createRandomData(50)
        ///     },
        ///     template: kendo.template($("#template").html())
        /// });
        /// </code>
        /// </example>
        public JsFunc<JsString, JsString> template { get; set; }
        /// <summary>
        /// Fires when the list view selection has changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#listView").kendoListView({
        ///     change: function(e) {
        ///         // handle event
        ///     }
        ///  });    
        /// </code>
        /// To set after initialization
        /// <code>
        ///  // get a reference to the list view
        ///  var listView = $("#listView").data("kendoListView");
        ///  // bind to the change event
        ///  listView.bind("change", function(e) {
        ///      // handle event
        ///  }
        /// </code>
        /// </example>
        public JsAction change { get; set; }
        /// <summary>
        /// Fires when the list view has received data from the data source. and is about to render it.
        /// </summary>
        /// <example>
        /// <code>
        /// function onDataBound(e) {
        ///     // handle event
        /// }
        /// </code>
        /// </example>
        public JsAction dataBound { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ListViewEditEventData
    {
        /// <summary>
        /// The jQuery element to be edited.
        /// </summary>
        public object item { get; set; }

        /// <summary>
        /// The model to be edited.
        /// </summary>
        public object model { get; set; }
    }

    [JsType(JsMode.Json)]
    public class ListViewRemoveEventData
    {
        /// <summary>
        /// The item element to be deleted.
        /// </summary>
        public object item { get; set; }

        /// <summary>
        /// The model which to be deleted.
        /// </summary>
        public object model { get; set; }
    }

    #endregion

    #region Menu

    [JsType(JsMode.Prototype, Name = "kendo.ui.Menu", Export = false)]
    public class Menu
    {
        /// <summary>
        /// Appends an item to a Menu in the specified referenceItem's sub menu.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu append(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Appends an item to a Menu in the specified referenceItem's sub menu.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu append(JsArray item, object referenceItem) { return null; }

        /// <summary>
        /// Closes a sub-menu of a specified item(s) in a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <param name="item">The closed item</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // close the sub menu of "Item1"
        /// menu.close("#Item1");
        ///</code>
        ///</example>
        public Menu close(JsString element, HtmlElement item) { return null; }
        /// <summary>
        /// Closes a sub-menu of a specified item(s) in a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <param name="item">The closed item</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // close the sub menu of "Item1"
        /// menu.close("#Item1");
        ///</code>
        ///</example>
        public Menu close(jQuery.jQuery item) { return null; }

        /// <summary>
        /// Enables or disables an item of a Menu. This can optionally be accomplished on initialization by setting the disabled="disabled" on the desired menu item html element.
        /// </summary>
        /// <param name="element">Target element</param>
        /// <param name="enable">Desired state</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // disable the li menu item with the id "secondItem"
        /// menu.enable("#secondItem", false);
        ///</code>
        ///</example>
        public Menu enable(JsString element, bool enable) { return null; }

        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertAfter(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertAfter(object item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertAfter(JsArray<object> item, object referenceItem) { return null; }
        //TODO: chack all 3 of them

        /// <summary>
        /// Inserts an item into a Menu before the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertBefore(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts an item into a Menu before the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertBefore(JsString item, JsArray referenceItem) { return null; }

        /// <summary>
        /// Opens a sub-menu of a specified item(s) in a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <param name="item">The opened item</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // open the sub menu of "Item1"
        /// menu.open("#Item1");
        ///</code>
        ///</example>
        public Menu open(JsString element, HtmlElement item) { return null; }

        /// <summary>
        /// Removes a specified item(s) from a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // remove the item with the id "Item1"
        /// menu.remove("#Item1");
        ///</code>
        ///</example>
        public Menu remove(JsString element) { return null; }


        /// <summary>
        /// Fires after a sub menu gets closed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires before a sub menu gets opened.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }

        /// <summary>
        /// Fires when a menu item gets selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class MenuConfiguration
    {
        /// <summary>
        /// A collection of Animation objects, used to change default animations. A value of false will disable all animations in the widget.
        /// Available animations for the Menu are listed below. Each animation has a reverse options which is used for the close effect by default,
        /// but can be over-ridden by setting the close animation. Each animation also has a direction which can be set off the animation (i.e. slideIn:Down).
        /// slideIn:
        /// Menu content slides in from the top
        /// fadeIn:
        /// Menu content fades in
        /// expand:
        /// Menu content expands from the top down. Similar to slideIn.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     animation: { open: { effects: "fadeIn" } }
        /// });
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: true) Specifies that sub menus should close after item selection (provided they won't navigate).
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///    closeOnClick: false
        ///});
        ///</code>
        ///</example>
        public bool closeOnClick { get; set; }
        /// <summary>
        /// Undocument property. Add by Lee.
        /// </summary>
        public JsArray dataSource { get; set; }

        /// <summary>
        /// (default: "default") Specifies Menu opening direction. Can be "top", "bottom", "left", "right".
        /// You can also specify different direction for root and sub menu items, separating them with space.
        /// The example below will initialize the root menu to open upwards and its sub menus to the left.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     direction: "top left"
        /// });
        ///</code>
        ///</example>
        public JsString direction { get; set; }

        /// <summary>
        /// (default: 100) Specifies the delay in ms before the menu is opened/closed - used to avoid accidental closure on leaving.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     hoverDelay: 200
        /// });
        ///</code>
        ///</example>
        public JsNumber hoverDelay { get; set; }

        /// <summary>
        /// (default: false) Specifies that the root sub menus will be opened on item click.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     openOnClick: true
        /// });
        ///</code>
        ///</example>
        public bool openOnClick { get; set; }

        /// <summary>
        /// (default: "horizontal") Root menu orientation. Could be horizontal or vertical.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     orientation: "vertical"
        /// });
        ///</code>
        ///</example>
        public JsString orientation { get; set; }

        /// <summary>
        /// Specifies how Menu should adjust to screen boundaries. By default the strategy is "fit" for a sub menu with a horizontal parent,
        /// meaning it will move to fit in screen boundaries in all directions, and "fit flip" for a sub menu with vertical parent,
        /// meaning it will fit vertically and flip over its parent horizontally.]
        /// You can also switch off the screen boundary detection completely if you set the popupCollision to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     popupCollision: false
        /// });
        ///</code>
        ///</example>
        public JsString popupCollision { get; set; }

        /// <summary>
        /// Fires when a menu item gets selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public JsAction<OneItemEventData> select { get; set; }

    }

    #endregion

    #region NumericTextBox

    [JsType(JsMode.Prototype, Name = "kendo.ui.NumericTextBox", Export = false)]
    public class NumericTextBox
    {

        /// <summary>
        /// Enable/Disable the numerictextbox widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }
        /// <summary>
        /// Enable/Disable the numerictextbox widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable() { }

        /// <summary>
        /// Sets the max value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The max value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }
        /// <summary>
        /// Sets the max value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The max value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsNumber max() { return null; }

        /// <summary>
        /// Sets the min value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The min value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }
        /// <summary>
        /// Sets the min value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The min value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsNumber min() { return null; }

        /// <summary>
        /// Sets the step value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The step value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the NumericTextBox widget
        /// var numerictextbox = $("#numerictextbox").data("kendoNumericTextBox");
        /// 
        /// // get the step value of the numerictextbox.
        /// var step = numerictextbox.step();
        /// 
        /// // set the step value of the numerictextbox.
        /// numerictextbox.step(0.1);
        ///</code>
        ///</example>
        public void step(JsNumber value) { }
        /// <summary>
        /// Sets the step value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The step value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the NumericTextBox widget
        /// var numerictextbox = $("#numerictextbox").data("kendoNumericTextBox");
        /// 
        /// // get the step value of the numerictextbox.
        /// var step = numerictextbox.step();
        /// 
        /// // set the step value of the numerictextbox.
        /// numerictextbox.step(0.1);
        ///</code>
        ///</example>
        public void step(JsString value) { }
        /// <summary>
        /// Gets the step value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The step value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the NumericTextBox widget
        /// var numerictextbox = $("#numerictextbox").data("kendoNumericTextBox");
        /// 
        /// // get the step value of the numerictextbox.
        /// var step = numerictextbox.step();
        /// 
        /// // set the step value of the numerictextbox.
        /// numerictextbox.step(0.1);
        ///</code>
        ///</example>
        public JsNumber step() { return null; }

        /// <summary>
        /// Sets the value of the numerictextbox.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a referene to the numeric textbox
        /// var numerictextbox = $("#textbox").data("kendoNumericTextBox");
        /// 
        /// // get the value of the numerictextbox.
        /// var value = numerictextbox.value();
        /// 
        /// // set the value of the numerictextbox.
        /// numerictextbox.value("10.20");
        ///</code>
        ///</example>
        public void value(JsNumber value) { }
        /// <summary>
        /// Sets the value of the numerictextbox.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a referene to the numeric textbox
        /// var numerictextbox = $("#textbox").data("kendoNumericTextBox");
        /// 
        /// // get the value of the numerictextbox.
        /// var value = numerictextbox.value();
        /// 
        /// // set the value of the numerictextbox.
        /// numerictextbox.value("10.20");
        ///</code>
        ///</example>
        public void value(JsString value) { }
        /// <summary>
        /// Gets the value of the numerictextbox.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a referene to the numeric textbox
        /// var numerictextbox = $("#textbox").data("kendoNumericTextBox");
        /// 
        /// // get the value of the numerictextbox.
        /// var value = numerictextbox.value();
        /// 
        /// // set the value of the numerictextbox.
        /// numerictextbox.value("10.20");
        ///</code>
        ///</example>
        public JsNumber value() { return null; }



        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the value is changed from the spin buttons
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#numeric").kendoNumericTextBox({
        ///     spin: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> spin
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"spin\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"spin\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class NumericTextBoxConfiguration
    {
        /// <summary>
        /// (default: en-US) Specifies the culture info used by the NumericTextBox widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// (default: null) Specifies the number precision. If not set precision defined by current culture is used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 1,
        ///     step: 0.1,
        ///     decimals: 1
        /// });
        ///</code>
        ///</example>
        public JsNumber decimals { get; set; }

        /// <summary>
        /// (default: Decrease value) Specifies the text of the tooltip on the down arrow.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50,
        ///     upArrowText: "More",
        ///     downArrowText: "Less"
        /// });
        ///</code>
        ///</example>
        public JsString downArrowText { get; set; }

        /// <summary>
        /// (default: n) Specifies the format of the number. Any valid number format is allowed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#numeric").kendoNumericTextBox({
        ///    format: "p0", // format as percentage with % sign
        ///    min: 0,
        ///    max: 1,
        ///    step: 0.01
        /// });
        ///</code>
        ///</example>   
        public JsString format { get; set; }

        /// <summary>
        /// (default: null) Specifies the largest value the user can enter.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" min="-100" max="100" step="10"/>
        /// &lt;br />
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50
        /// });
        ///</code>
        ///</example>
        public JsNumber max { get; set; }

        /// <summary>
        /// (default: null) Specifies the smallest value the user can enter.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" min="-100" max="100" step="10"/>
        /// &lt;br />
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50
        /// });
        ///</code>
        ///</example>
        public JsNumber min { get; set; }

        /// <summary>
        /// (default: "") Specifies the text displayed when the input is empty.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50,
        ///     placeholder: "Select A Value"
        /// });
        ///</code>
        ///</example>   
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: 1) Specifies the increment/decrement step.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" />
        /// &lt;br />
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 1,
        ///     step: 0.1
        /// });
        ///</code>
        ///</example>
        public JsNumber step { get; set; }

        /// <summary>
        /// (default: Increase value) Specifies the text of the tooltip on the up arrow.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50,
        ///     upArrowText: "More",
        ///     downArrowText: "Less"
        /// });
        ///</code>
        ///</example>
        public JsString upArrowText { get; set; }

        /// <summary>
        /// (default: null) Specifies the value of the NumericTextBox widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" min="-100" max="100" step="10"/>
        /// 
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50
        /// });
        ///</code>
        ///</example>
        public JsNumber value { get; set; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#comboBox").kendoNumericTextBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to instance of the Kendo UI ComboBox
        /// var numeric = $("#numeric").data("kendoNumericTextBox");
        /// // bind to the change event
        /// numeric.bind("change", function(e) {
        ///    // handle event
        ///});
        /// </code>
        /// </example>
        public JsAction<ChangeEventData> change { get; set; }

        /// <summary>
        /// Fires when the value is changed from the spin buttons.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#numeric").kendoNumericTextBox({
        /// spin: function(e) {
        ///     // handle event
        ///     }
        /// });
        /// </code>
        /// To set after initialization
        /// <code>
        /// // get a reference to the numeric textbox widget
        /// var numeric = $("#numeric").data("kendoNumericTextBox");
        /// // bind to the spin event
        /// numeric.bind("spin", function(e) {
        ///     // handle event
        /// });
        /// </code>
        /// </example>
        public JsAction spin { get; set; }

        /// <summary>
        /// Specifies whether the up/down spin buttons should be rendered.  Default is true.
        /// </summary>
        /// <example>
        /// <code>
        /// $("#numeric").kendoNumericTextBox({
        /// spinners: false
        /// });
        /// </code>
        /// </example>
        public JsBoolean spinners { get; set; }
    }

    #endregion

    #region Pager

    [JsType(JsMode.Prototype, Name = "kendo.ui.Pager", Export = false)]
    public class Pager
    {
        /// <summary>
        /// Returns the number of pages.
        /// </summary>
        /// <returns></returns>
        public JsNumber totalPages() { return null; }

        /// <summary>
        /// Returns the page size - maximum number of items allowed on one page.
        /// </summary>
        /// <returns></returns>
        public JsNumber pageSize() { return null; }

        /// <summary>
        /// Set the specified page as a current page. If called without arguments - returns the current page.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var currentPage = pager.page();
        ///</code>
        ///</example>   
        public JsNumber page() { return null; }
        /// <summary>
        /// Set the specified page as a current page. If called without arguments - returns the current page.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///pager.page(2);
        ///</code>
        ///</example>   
        public void page(JsNumber page) { }

        /// <summary>
        /// Updates all values of pager elements so that these values fit the values of DataSource.
        /// This method is automaticaly called after DataSource change event is fired.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Unbinds all callbacks created within pager initialization. This method doesn't remove pager element from DOM.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Fires when the current page has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class PagerConfiguration<T>
    {
        /// <summary>
        /// (default: true) Indicates whether the pager refresh method will be called within its initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// (default: 10) Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        public JsNumber buttonCount { get; set; }

        /// <summary>
        /// Instance of kendo DataSource. See the kendo.data.DataSource. This option is mandatory because the Pager is tightly connected with DataSource.
        /// The pager is UI widget for managing paging over the DataSource. The Pager gets values like page size or total count of items from DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///     dataSource: new kendo.data.DataSource({
        ///         data: [
        ///             {title: "Star Wars: A New Hope", year: 1977},
        ///             {title: "Star Wars: The Empire Strikes Back", year: 1980}
        ///         ],
        ///         pageSize: 25
        ///     });
        ///     pageSizes: [10, 25, 50]
        /// });
        ///</code>
        ///</example>
        public DataSource<T> dataSource { get; set; }

        /// <summary>
        /// The template for selectbox with predefined page sizes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///     dataSource: sharedDataSource,
        ///     selectTemplate: '&lt;li>&lt;span class="k-state-selected">#=text#&lt;/span>&lt;/li>'
        /// });
        ///</code>
        ///</example>
        public JsString selectTemplate { get; set; }

        /// <summary>
        /// The template for page number links.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///     dataSource: sharedDataSource,
        ///     linkTemplate: '&lt;li>&lt;a href="\\#" class="k-link" data-#=ns#page="#=idx#">#=text#&lt;/a>&lt;/li>'
        /// });
        ///</code>
        ///</example>
        public JsString linkTemplate { get; set; }

        /// <summary>
        /// (default: true) Defines if a label showing current paging information will be displayed.
        /// </summary>
        public bool info { get; set; }

        /// <summary>
        /// (default: false) Defines if an input element which allows the user to navigate to given page will be displayed.
        /// </summary>
        public bool input { get; set; }

        /// <summary>
        /// (default: true) Defines if numeric portion of the pager will be shown.
        /// </summary>
        public bool numeric { get; set; }

        /// <summary>
        /// (default: false)Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        public bool pageSizes { get; set; }
        /// <summary>
        /// (default: [5,10,20])Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        [JsProperty(Name = "pageSizes")]
        public JsArray pageSizesArray { get; set; }

        /// <summary>
        /// (default: true) Defines if buttons for navigating to the first, last, previous and next pages will be shown.
        /// </summary>
        public bool previousNext { get; set; }

        /// <summary>
        /// (default: false) Defines if a refresh button will be displayed.
        /// </summary>
        public bool refresh { get; set; }

        /// <summary>
        /// Defines texts shown within the pager.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///    dataSource: sharedDataSource,
        ///    messages: {
        ///        display: "{0} - {1} of {2} items",
        ///        empty: "No items to display",
        ///        page: "Page",
        ///        of: "of {0}",
        ///        itemsPerPage: "items per page",
        ///        first: "Go to the first page",
        ///        previous: "Go to the previous page",
        ///        next: "Go to the next page",
        ///        last: "Go to the last page",
        ///        refresh: "Refresh"
        ///    }
        ///});
        ///</code>
        ///</example>
        public GridPageableMessagesConfiguration messages { get; set; }
    }

    #endregion

    #region PanelBar

    [JsType(JsMode.Prototype, Name = "kendo.ui.PanelBar", Export = false)]
    public class PanelBar
    {
        /// <summary>
        /// Appends an item to the PanelBar.
        /// </summary>
        /// <param name="item">Target item, specified as the JSON representation of an object. You can pass item text, content or contentUrl here.
        /// Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns> Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar append(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Appends an item to the PanelBar.
        /// </summary>
        /// <param name="item">Target item, specified as the JSON representation of an object. You can pass item text, content or contentUrl here.
        /// Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns> Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar append(JsArray item, object referenceItem) { return null; }

        /// <summary>
        /// Collapses the specified item(s) of a PanelBar. Temporarily enables (true) or disables (false) any visual animation(s) when collapsing items.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be collapsed, expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="useAnimation">_optional, default: _</param>
        /// <param name="item">The collapsing item of the PanelBar.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        public PanelBar collapse(JsString element, bool useAnimation, HtmlElement item) { return null; }

        /// <summary>
        /// Collapses the specified item(s) of a PanelBar. Temporarily enables (true) or disables (false) any visual animation(s) when collapsing items.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be collapsed, expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        public PanelBar collapse(jQuery.jQuery element) { return null; }
        /// <summary>
        /// Undocument method. Add by Lee.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>d</returns>
        public PanelBar data(JsString str) { return null; }
        /// <summary>
        /// Undocunment method. Add by Lee
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public PanelBar replaceWith(jQuery.jQuery element) { return null; }


        /// <summary>
        ///Enables (true) or disables (false) the specified item(s) of the PanelBar.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be enabled (true) or disabled (false),
        /// expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="enable">The desired state - enabled (true) or disabled (false) - of the target element(s).</param>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // enable the item of the PanelBar with ID, "item1"
        /// panelBar.enable($("#item1"), true);
        /// // disable the currently selected item of the PanelBar
        /// var item = panelBar.select();
        /// panelBar.enable(item, false);
        /// // disable all list items that start with ID, "item"
        /// panelBar.enable($('[id^="item"]'), false);
        ///</code>
        ///</example>
        public void enable(JsString element, bool enable) { }

        /// <summary>
        /// Expands the specified item(s) of a PanelBar. Temporariliy enables (true) or disables (false) any visual animation(s) when expanding items.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be expanded, expressed as a selector.</param>
        /// <param name="useAnimation">_optional, default: _</param>
        /// <param name="item">The expanding item of the PanelBar.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // expand the element with ID, "item1"
        /// panelBar.expand($("#item1"));
        /// // expand the element with ID, "item2" without visual animations
        /// panelBar.expand($("#item2"), false);
        /// // expand all list items that start with ID, "item"
        /// panelBar.expand($('[id^="item"]'));
        ///</code>
        ///</example>
        public PanelBar expand(JsString element, bool useAnimation, HtmlElement item) { return null; }

        /// <summary>
        /// Inserts a PanelBar item after the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to insert the new item after</param>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public void insertAfter(JsString item, object referenceItem) { }
        /// <summary>
        /// Inserts a PanelBar item after the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to insert the new item after</param>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public void insertAfter(JsArray<JsString> item, object referenceItem) { }

        /// <summary>
        /// Inserts a PanelBar item before the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar insertBefore(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts a PanelBar item before the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar insertBefore(JsArray<JsString> item, object referenceItem) { return null; }

        /// <summary>
        /// Reloads the content of a PanelBar from an AJAX request.
        /// </summary>
        /// <param name="element">Target element</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the panel bar
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // reload the panel basr
        /// panelBar.reload();
        ///</code>
        ///</example>
        public void reload(JsString element) { }

        /// <summary>
        /// Removes the specified PanelBar item(s).
        /// </summary>
        /// <param name="element">Target item selector.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // remove the item with the id "Item1"
        /// menu.remove("#Item1");
        ///</code>
        ///</example>
        public void remove(JsString element) { }

        /// <summary>
        /// Selects the specified item of the PanelBar. If this method is invoked without arguments, it returns the currently selected item.
        /// </summary>
        /// <param name="element">The PanelBar item to be selected, expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="item">The selected item of the PanelBar.</param>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // select the item with ID, "item1"
        /// panelBar.select("#item1");
        ///</code>
        ///</example>
        public void select(JsString element, HtmlElement item) { }


        /// <summary>
        /// Triggered when an item of a PanelBar is activated.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for activate
        /// var onActivate = function(e) {
        ///     // access the activated item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach activate event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     activate: onActivate
        /// });
        /// 
        /// // detach activate event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("activate", onActivate);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> activate
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"activate\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"activate\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is collapsed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for collapse
        /// var onCollapse = function(e) {
        ///     // access the collapsed item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach collapse event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     collapse: onCollapse
        /// });
        /// 
        /// // detach collapse event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("collapse", onCollapse);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> collapseEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"collapse\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"collapse\"")]
            remove { }
        }

        /// <summary>
        /// Fires when content is fetched from an AJAX request.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    contentLoad: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<PanelBarContentLoadEventData> contentLoad
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"contentLoad\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"contentLoad\"")]
            remove { }
        }

        /// <summary>
        /// Fires when AJAX request results in an error.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    error: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<PanelBarErrorEventData> error
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"error\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"error\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for expand
        /// var onExpand = function(e) {
        ///     // access the expanded item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach expand event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     expand: onExpand
        /// });
        /// 
        /// // detach expand event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("expand", onExpand);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> expandEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"expand\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"expand\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class PanelBarConfiguration
    {
        /// <summary>
        /// A collection of visual animations used when PanelBar items are opened or closed through user interactions. Setting this option to false will disable all animations.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        // fade-out closing items over 1000 milliseconds
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        },
        ///       // fade-in and expand opening items over 500 milliseconds
        ///       open: {
        ///           duration: 500,
        ///           effects: "expandVertical fadeIn"
        ///       }
        ///   }
        ///});
        ///</code>
        ///</example>
        public PanelBarAnimationConfiguration animation { get; set; }

        /// <summary>
        /// Specifies how the PanelBar items are displayed when opened and closed. The following values are available:
        /// "single"
        /// Display one item at a time when an item is opened; opening an item will close the previously opened item.
        /// "multiple"
        /// Display multiple values at one time; opening an item has no visual impact on any other items in the PanelBar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    expandMode: "single"
        ///});
        ///</code>
        ///</example>
        public JsString expandMode { get; set; }
        /// <summary>
        /// Undocument property. Add by Lee. 
        /// </summary>
        public JsArray<JsString> contentUrls { get; set; }
        /// <summary>
        /// Triggered when an item of a PanelBar is selected.
        /// </summary>
        public JsAction<PanelBarContentLoadEventData> select { get; set; }
        /// <summary>
        /// Triggered when an item of a PanelBar is expanded.
        /// </summary>
        public JsAction<PanelBarContentLoadEventData> expand { get; set; }
        /// <summary>
        /// Triggered when an item of a PanelBar is collapsed.
        /// </summary>
        public JsAction<PanelBarContentLoadEventData> collapse { get; set; }
        /// <summary>
        /// Triggered when an item of a PanelBar is activated.
        /// </summary>
        public JsAction<PanelBarContentLoadEventData> activate { get; set; }
        /// <summary>
        /// Fires when content is fetched from an AJAX request.
        /// </summary>
        public JsAction<PanelBarContentLoadEventData> contentLoad { get; set; }
        /// <summary>
        /// ires when AJAX request results in an error.
        /// </summary>
        public JsAction<PanelBarErrorEventData> error { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PanelBarAnimationConfiguration
    {
        /// <summary>
        /// The visual animation(s) that will be used when PanelBar items are closed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           close: {
        ///               effects: "fadeOut",
        ///               duration: 300,
        ///               hide: true
        ///               show: false
        ///           }
        ///        }
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public PanelBarAnimationCloseConfiguration close { get; set; }

        /// <summary>
        /// Animation to be used for opening of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         animation: {
        ///            open: {
        ///                effects: "fadeIn",
        ///                duration: 300,
        ///                show: true
        ///            }
        ///         }
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public PanelBarAnimationOpenConfiguration open { get; set; }

        public PanelBarAnimationExpandConfiguration expand { get; set; }



    }
    [JsType(JsMode.Json)]
    public class PanelBarAnimationExpandConfiguration
    {
        public JsString effects { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PanelBarAnimationCloseConfiguration
    {
        /// <summary>
        /// (default: 200) The number of milliseconds used for the visual animation when a PanelBar item is closed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        close: {
        ///
        ///                   duration: 1000
        ///
        ///               }
        ///  }
        ///});
        ///</code>
        ///</example>
        public JsNumber duration { get; set; }

        /// <summary>
        /// A whitespace-delimited string of animation effects that are utilized when a PanelBar item is closed. Options include "fadeOut".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsString effects { get; set; }

    }

    [JsType(JsMode.Json)]
    public class PanelBarAnimationOpenConfiguration
    {
        /// <summary>
        /// (default: 200) The number of milliseconds used for the visual animation when an item is opened.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        open: {
        ///
        ///                   duration: 1000
        ///
        ///               }
        ///  }
        ///});
        ///</code>
        ///</example>
        public JsNumber duration { get; set; }

        /// <summary>
        /// (default: "expandVertical") A whitespace-delimited string of animation effects that are used when an item is expanded. Options include "expandVertical" and "fadeIn".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsString effects { get; set; }

        /// <summary>
        /// (default: true)
        /// </summary>
        public bool show { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PanelBarExpandModeOptions
    {
        /// <summary>
        /// Display one item at a time when an item is opened; opening an item will close the previously opened item.
        /// </summary>
        single,
        /// <summary>
        /// Display multiple values at one time; opening an item has no visual impact on any other items in the PanelBar.
        /// </summary>
        multiple,
    }

    [JsType(JsMode.Json)]
    public class PanelBarContentLoadEventData
    {
        /// <summary>
        /// The selected item
        /// </summary>
        public HtmlElement item { get; set; }

        /// <summary>
        /// The loaded content element
        /// </summary>
        public HtmlElement contentElement { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PanelBarErrorEventData
    {
        /// <summary>
        /// The jqXHR object used to load the content
        /// </summary>
        public jqXHR xhr { get; set; }

        /// <summary>
        /// The returned status.
        /// </summary>
        public JsString status { get; set; }


    }

    #endregion

    #region RangeSlider

    [JsType(JsMode.Prototype, Name = "kendo.ui.RangeSlider", Export = false)]
    public class RangeSlider
    {

        /// <summary>
        /// Prepares the RangeSlider for safe removal from the DOM.
        /// Detaches event handlers and removes data entries in order to avoid memory leaks.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // deatach events
        /// $("#rangeSlider").data("kendoRangeSlider").destroy();
        /// 
        /// // remove slider html from DOM
        /// $("#rangeSlider").closest(".k-slider").remove();
        ///</code>
        ///</example>
        public void destroy() { }

        /// <summary>
        /// Enable/Disable the RangeSlider widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the RangeSlider.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the range slider widget
        /// var rangeSlider = $("#rangeSlider").data("kendoRangeSlider");
        /// 
        /// // disables the range slider
        /// rangeSlider.enable(false);
        /// 
        /// // enables the range slider
        /// rangeSlider.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// The value method gets or sets the start and end values of the RangeSlider.
        /// It accepts an array as parameter, and returns an object array with the start and end selection values.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public JsArray value() { return null; }
        /// <summary>
        /// The value method gets or sets the start and end values of the RangeSlider.
        /// It accepts an array as parameter, and returns an object array with the start and end selection values.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public void value(JsArray value) { }

        /// <summary>
        /// Fires when the rangeSlider value changes as a result of selecting a new value with one of the drag handles or the keyboard.
        /// </summary>
        public event JsAction<RangeSliderEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        public event JsAction<RangeSliderEventData> slide
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"slide\"")]
            add { }
            [JsMethod(Name = "bind", InsertArg0 = "\"slide\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class RangeSliderConfiguration
    {
        /// <summary>
        /// (default: 5) The delta with which the value will change when the user presses the Page Up or Page Down key (the drag handle must be focused).
        /// Note: The allied largeStep will also set large tick for every large step.
        /// </summary>
        public JsNumber largeStep { get; set; }

        /// <summary>
        /// (default: 10) The maximum value of the RangeSlider.
        /// </summary>
        public JsNumber max { get; set; }

        /// <summary>
        /// (default: 0) The minimum value of the RangeSlider.
        /// </summary>
        public JsNumber min { get; set; }

        /// <summary>
        /// (default: "horizontal") F The orientation of a RangeSlider; "horizontal" or "vertical".
        /// </summary>
        public OrientationOptions orientation { get; set; }

        /// <summary>
        /// The selection end value of the RangeSlider.
        /// </summary>
        public JsNumber selectionEnd { get; set; }

        /// <summary>
        /// The selection start value of the RangeSlider.
        /// </summary>
        public JsNumber selectionStart { get; set; }

        /// <summary>
        /// (default: 1) The small step value of the RangeSlider. The underlying value will be changed when the end user (1) clicks on the increase
        /// or decrease buttons of the RangeSlider, (2) presses the arrow keys (the drag handle must be focused), or (3) drags the drag handle.
        /// </summary>
        public JsNumber smallStep { get; set; }

        /// <summary>
        /// (default: "both")
        /// Denotes the location of the tick marks in the RangeSlider. The available options are:
        /// "topLeft"
        /// Tick marks are located on the top of the horizontal widget or on the left of the vertical widget.
        /// "bottomRight"
        /// Tick marks are located on the bottom of the horizontal widget or on the right side of the vertical widget.
        /// "both"
        /// Tick marks are located on both sides of the widget.
        /// "none"
        /// Tick marks are not visible.
        /// </summary>
        public RangeSliderTickPlacementOptions tickPlacement { get; set; }

        /// <summary>
        /// Configuration of the RangeSlider tooltip.
        /// </summary>
        public RangeSliderTooltipConfiguration tooltip { get; set; }
        public JsAction<RangeSliderEventData> change { get; set; }
        public JsAction<RangeSliderEventData> slide { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum RangeSliderTickPlacementOptions
    {
        /// <summary>
        /// Tick marks are located on the top of the horizontal widget or on the left of the vertical widget.
        /// </summary>
        topLeft,
        /// <summary>
        /// Tick marks are located on the bottom of the horizontal widget or on the right side of the vertical widget.
        /// </summary>
        bottomRight,
        /// <summary>
        /// Tick marks are located on both sides of the widget.
        /// </summary>
        both,
        /// <summary>
        /// Tick marks are not visible.
        /// </summary>
        none,
    }

    [JsType(JsMode.Json)]
    public class RangeSliderTooltipConfiguration
    {
        /// <summary>
        /// (default: true) Disables (false) or enables (true) the tooltip of the RangeSlider.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// (default: "{0}") Format string for the text of the tooltip. Note: The applied format will also influence the appearance of the RangeSlider tick labels.
        /// </summary>
        public JsString format { get; set; }
    }

    [JsType(JsMode.Json)]
    public class RangeSliderEventData
    {
        /// <summary>
        /// Represents the updated array of values of the first and second drag handle.
        /// </summary>
        public JsNumber value { get; set; }
    }

    #endregion

    #region Slider

    [JsType(JsMode.Prototype, Name = "kendo.ui.Slider", Export = false)]
    public class Slider
    {

        /// <summary>
        /// Prepares the Slider for safe removal from the DOM.
        /// Detaches event handlers and removes data entries in order to avoid memory leaks.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // deatach events
        /// $("#rangeSlider").data("kendoRangeSlider").destroy();
        /// 
        /// // remove slider html from DOM
        /// $("#rangeSlider").closest(".k-slider").remove();
        ///</code>
        ///</example>
        public void destroy() { }

        /// <summary>
        /// Enable/Disable the Slider widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the Slider.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the slider widget
        /// var Slider = $("#Slider").data("kendoSlider");
        /// 
        /// // disables the range slider
        /// Slider.enable(false);
        /// 
        /// // enables the range slider
        /// Slider.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Gets the value of a Slider. It accepts a string or number as parameters and returns a number representing the underlying value.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public JsNumber value() { return null; }
        /// <summary>
        /// Sets the value of a Slider. It accepts a string or number as parameters and returns a number representing the underlying value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public void value(JsNumber value) { }
        /// <summary>
        /// Sets the value of a Slider. It accepts a string or number as parameters and returns a number representing the underlying value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Fires when the slider value changes as a result of selecting a new value with the drag handle, buttons or keyboard.
        /// </summary>
        public event JsAction<RangeSliderEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        public event JsAction<RangeSliderEventData> slide
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"slide\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"slide\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class SliderConfiguration
    {
        /// <summary>
        /// (default: "Decrease") The title of the decrease button of the Slider.
        /// </summary>
        public JsString decreaseButtonTitle { get; set; }

        /// <summary>
        /// (default: "Increase") The title of the increase button of the Slider.
        /// </summary>
        public JsString increaseButtonTitle { get; set; }

        /// <summary>
        /// (default: 5) The delta with which the value will change when the user presses the Page Up or Page Down key (the drag handle must be focused).
        /// Note: The allied largeStep will also set large tick for every large step.
        /// </summary>
        public JsNumber largeStep { get; set; }

        /// <summary>
        /// (default: 10) The maximum value of the Slider.
        /// </summary>
        public JsNumber max { get; set; }

        /// <summary>
        /// (default: 0) The minimum value of the Slider.
        /// </summary>
        public JsNumber min { get; set; }

        /// <summary>
        /// (default: "horizontal") F The orientation of a Slider; "horizontal" or "vertical".
        /// </summary>
        public OrientationOptions orientation { get; set; }

        /// <summary>
        /// (default: true) Can be used to show (true) or hide (false) the increase and decrease buttons of a Slider.
        /// </summary>
        public bool showButtons { get; set; }

        /// <summary>
        /// (default: 1) The small step value of the Slider. The underlying value will be changed when the end user (1) clicks on the increase
        /// or decrease buttons of the Slider, (2) presses the arrow keys (the drag handle must be focused), or (3) drags the drag handle.
        /// </summary>
        public JsNumber smallStep { get; set; }

        /// <summary>
        /// (default: "both")
        /// Denotes the location of the tick marks in the Slider. The available options are:
        /// "topLeft"
        /// Tick marks are located on the top of the horizontal widget or on the left of the vertical widget.
        /// "bottomRight"
        /// Tick marks are located on the bottom of the horizontal widget or on the right side of the vertical widget.
        /// "both"
        /// Tick marks are located on both sides of the widget.
        /// "none"
        /// Tick marks are not visible.
        /// </summary>
        public RangeSliderTickPlacementOptions tickPlacement { get; set; }

        /// <summary>
        /// Configuration of the Slider tooltip.
        /// </summary>
        public RangeSliderTooltipConfiguration tooltip { get; set; }

        /// <summary>
        /// The underlying value of the Slider.
        /// </summary>
        public JsNumber value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsAction<SliderConfiguration> change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsAction<SliderConfiguration> slide { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum OrientationOptions
    {
        /// <summary>
        /// Define horizontal orientation
        /// </summary>
        horizontal,
        /// <summary>
        /// Define vertical orientation of the splitter.
        /// </summary>
        vertical,
    }

    #endregion

    #region Splitter

    [JsType(JsMode.Prototype, Name = "kendo.ui.Splitter", Export = false)]
    public class Splitter
    {
        /// <summary>
        /// Loads the content of a pane from a local or remote URL.
        /// </summary>
        /// <param name="pane">The targetted pane whose content is to be loaded via a URL.</param>
        /// <param name="url">A local or remote URL from which the content of the pane is to be loaded.</param>
        /// <param name="data">Any data that is necessary to be sent to the server.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // load content into the pane with ID, pane1
        /// splitter.ajaxRequest("#pane1", "/customer/profile", { id: 42 });
        ///</code>
        ///</example>
        public void ajaxRequest(JsString pane, JsString url, object data) { }
        /// <summary>
        /// Loads the content of a pane from a local or remote URL.
        /// </summary>
        /// <param name="pane">The targetted pane whose content is to be loaded via a URL.</param>
        /// <param name="url">A local or remote URL from which the content of the pane is to be loaded.</param>
        /// <param name="data">Any data that is necessary to be sent to the server.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // load content into the pane with ID, pane1
        /// splitter.ajaxRequest("#pane1", "/customer/profile", { id: 42 });
        ///</code>
        ///</example>
        public void ajaxRequest(HtmlElement pane, JsString url, object data) { }
        /// <summary>
        /// Loads the content of a pane from a local or remote URL.
        /// </summary>
        /// <param name="pane">The targetted pane whose content is to be loaded via a URL.</param>
        /// <param name="url">A local or remote URL from which the content of the pane is to be loaded.</param>
        /// <param name="data">Any data that is necessary to be sent to the server.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // load content into the pane with ID, pane1
        /// splitter.ajaxRequest("#pane1", "/customer/profile", { id: 42 });
        ///</code>
        ///</example>
        public void ajaxRequest(JsString pane, JsString url, JsString data) { }
        /// <summary>
        /// Loads the content of a pane from a local or remote URL.
        /// </summary>
        /// <param name="pane">The targetted pane whose content is to be loaded via a URL.</param>
        /// <param name="url">A local or remote URL from which the content of the pane is to be loaded.</param>
        /// <param name="data">Any data that is necessary to be sent to the server.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // load content into the pane with ID, pane1
        /// splitter.ajaxRequest("#pane1", "/customer/profile", { id: 42 });
        ///</code>
        ///</example>
        public void ajaxRequest(HtmlElement pane, JsString url, JsString data) { }

        /// <summary>
        /// Collapses a specified pane. Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger a collapse event.
        /// </summary>
        /// <param name="pane">The pane to be collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // collapse the pane with ID, pane1
        /// splitter.collapse("#pane1");
        ///</code>
        ///</example>
        public void collapse(JsString pane) { }
        /// <summary>
        /// Collapses a specified pane. Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger a collapse event.
        /// </summary>
        /// <param name="pane">The pane to be collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // collapse the pane with ID, pane1
        /// splitter.collapse("#pane1");
        ///</code>
        ///</example>
        public void collapse(HtmlElement pane) { }

        /// <summary>
        /// Expands a specified pane. Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger an expand event.
        /// </summary>
        /// <param name="pane">The pane to be expanded.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // expand the pane with ID, pane1
        /// splitter.expand("#pane1");
        ///</code>
        ///</example>
        public void expand(JsString pane) { }
        /// <summary>
        /// Expands a specified pane. Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger an expand event.
        /// </summary>
        /// <param name="pane">The pane to be expanded.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // expand the pane with ID, pane1
        /// splitter.expand("#pane1");
        ///</code>
        ///</example>
        public void expand(HtmlElement pane) { }

        /// <summary>
        /// Sets the maximum size of a pane. Setting this value will not cause the Splitter to redraw, nor will it trigger any events.
        /// </summary>
        /// <param name="pane">The pane being targetted for a new minimum size configuration value.</param>
        /// <param name="value">The maximum size value of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // set the maximum size of the pane with ID, pane1
        /// splitter.max("#pane1", "300px");
        ///</code>
        ///</example>
        public void max(JsString pane, JsString value) { }
        /// <summary>
        /// Sets the maximum size of a pane. Setting this value will not cause the Splitter to redraw, nor will it trigger any events.
        /// </summary>
        /// <param name="pane">The pane being targetted for a new minimum size configuration value.</param>
        /// <param name="value">The maximum size value of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").</param>
        /// <example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // set the maximum size of the pane with ID, pane1
        /// splitter.max("#pane1", "300px");
        ///</code>
        ///</example>
        public void max(HtmlElement pane, JsString value) { }

        /// <summary>
        /// Sets the minimum size of a pane. Setting this value will not cause the Splitter to redraw, nor will it trigger any events.
        /// </summary>
        /// <param name="pane">The pane being targetted for a new minimum size configuration value.</param>
        /// <param name="value">The minimum size value of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // set the minimum size of the pane with ID, pane1
        /// splitter.min("#pane1", "100px");
        ///</code>
        ///</example>
        public void min(JsString pane, JsString value) { }
        /// <summary>
        /// Sets the minimum size of a pane. Setting this value will not cause the Splitter to redraw, nor will it trigger any events.
        /// </summary>
        /// <param name="pane">The pane being targetted for a new minimum size configuration value.</param>
        /// <param name="value">The minimum size value of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // set the minimum size of the pane with ID, pane1
        /// splitter.min("#pane1", "100px");
        ///</code>
        ///</example>
        public void min(HtmlElement pane, JsString value) { }

        /// <summary>
        /// Set the size of the pane. Setting this value will cause the Splitter to redraw and it will trigger layoutChange and resize events.
        /// </summary>
        /// <param name="pane">The pane to be resized.</param>
        /// <param name="value">The new size of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// Note: This value must not exceed panes.max or be less then panes.min.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // set the size of the pane with ID, pane1
        /// splitter.size("#pane1", "200px");
        ///</code>
        ///</example>
        public void size(JsString pane, JsString value) { }
        /// <summary>
        /// Set the size of the pane. Setting this value will cause the Splitter to redraw and it will trigger layoutChange and resize events.
        /// </summary>
        /// <param name="pane">The pane to be resized.</param>
        /// <param name="value">The new size of the pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%").
        /// Note: This value must not exceed panes.max or be less then panes.min.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // set the size of the pane with ID, pane1
        /// splitter.size("#pane1", "200px");
        ///</code>
        ///</example>
        public void size(HtmlElement pane, JsString value) { }

        /// <summary>
        /// Toggles the state of a specified pane (i.e. collapsed or expanded). Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger collapse or expand events.
        /// </summary>
        /// <param name="pane">The pane to be resized.</param>
        /// <param name="expand ">(Optional) Represents the desired state of the specified pane; to be expanded (true) or collapsed (false).
        /// If undefined, toggle() will collapse the pane if it is expanded or will expand the pane if it is collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // toggle the state of the pane with ID, pane1
        /// splitter.toggle("#pane1");
        /// // toggle the state of the pane with ID, pane1 to be expanded
        /// splitter.toggle("#pane1", true);
        /// // toggle the state of the pane with ID, pane1 to be collapsed
        /// splitter.toggle("#pane1", false);
        ///</code>
        ///</example>
        public void toggle(JsString pane, bool expand) { }
        /// <summary>
        /// Toggles the state of a specified pane (i.e. collapsed or expanded). Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger collapse or expand events.
        /// </summary>
        /// <param name="pane">The pane to be resized.</param>
        /// <param name="expand ">(Optional) Represents the desired state of the specified pane; to be expanded (true) or collapsed (false).
        /// If undefined, toggle() will collapse the pane if it is expanded or will expand the pane if it is collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // toggle the state of the pane with ID, pane1
        /// splitter.toggle("#pane1");
        /// // toggle the state of the pane with ID, pane1 to be expanded
        /// splitter.toggle("#pane1", true);
        /// // toggle the state of the pane with ID, pane1 to be collapsed
        /// splitter.toggle("#pane1", false);
        ///</code>
        ///</example>
        public void toggle(HtmlElement pane, bool expand) { }
        /// <summary>
        /// Toggles the state of a specified pane (i.e. collapsed or expanded). Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger collapse or expand events.
        /// </summary>
        /// <param name="pane">The pane to be resized.</param>
        /// <param name="expand ">(Optional) Represents the desired state of the specified pane; to be expanded (true) or collapsed (false).
        /// If undefined, toggle() will collapse the pane if it is expanded or will expand the pane if it is collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // toggle the state of the pane with ID, pane1
        /// splitter.toggle("#pane1");
        /// // toggle the state of the pane with ID, pane1 to be expanded
        /// splitter.toggle("#pane1", true);
        /// // toggle the state of the pane with ID, pane1 to be collapsed
        /// splitter.toggle("#pane1", false);
        ///</code>
        ///</example>
        public void toggle(JsString pane) { }
        /// <summary>
        /// Toggles the state of a specified pane (i.e. collapsed or expanded). Invoking this method will force the Splitter to redraw and it will trigger layoutChange and resize events.
        /// Note: Invoking the method will not trigger collapse or expand events.
        /// </summary>
        /// <param name="pane">The pane to be resized.</param>
        /// <param name="expand ">(Optional) Represents the desired state of the specified pane; to be expanded (true) or collapsed (false).
        /// If undefined, toggle() will collapse the pane if it is expanded or will expand the pane if it is collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the splitter
        /// var splitter = $("#splitter").data("kendoSplitter");
        /// // toggle the state of the pane with ID, pane1
        /// splitter.toggle("#pane1");
        /// // toggle the state of the pane with ID, pane1 to be expanded
        /// splitter.toggle("#pane1", true);
        /// // toggle the state of the pane with ID, pane1 to be collapsed
        /// splitter.toggle("#pane1", false);
        ///</code>
        ///</example>
        public void toggle(HtmlElement pane) { }

        /// <summary>
        /// Triggered when a pane of a Splitter is collapsed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for collapse
        /// var onCollapse = function(e) {
        ///     // access the collapsed item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach collapse event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     collapse: onCollapse
        /// });
        /// 
        /// // detach collapse event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("collapse", onCollapse);
        ///</code>
        ///</example>
        public event JsAction<SplitterEventData> collapseEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"collapse\"")]
            add { }
            [JsMethod(Name = "bind", InsertArg0 = "\"collapse\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when the content for a pane has finished loading.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for contentLoad
        /// var onContentLoad = function(e) {
        ///     // access the loaded pane via e.pane (HTMLElement)
        /// };
        /// 
        /// // attach contentLoad event handler during initialization
        /// var splitter = $("#splitter").kendoSplitter({
        ///     contentLoad: onContentLoad
        /// });
        /// 
        /// // detach contentLoad event handler via unbind()
        /// splitter.data("kendoSplitter").unbind("contentLoad", onContentLoad);
        ///</code>
        ///</example>
        public event JsAction<SplitterEventData> contentLoad
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"contentLoad\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"contentLoad\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a pane of a Splitter is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for expand
        /// var onExpand = function(e) {
        ///     // access the expanded item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach expand event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     expand: onExpand
        /// });
        /// 
        /// // detach expand event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("expand", onExpand);
        ///</code>
        ///</example>
        public event JsAction<SplitterEventData> expandEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"expand\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"expand\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the splitter layout has changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for resize
        /// var onLayoutChange = function(e) {
        ///     // ...
        /// };
        /// 
        /// $("#splitter").kendoSplitter({
        ///     layoutChange: onLayoutChange
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> layoutChange
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"layoutChange\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"layoutChange\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a pane is resized.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for resize
        /// var onResize = function(e) {
        ///     // ...
        /// };
        /// 
        /// // attach resize event handler during initialization
        /// var splitter = $("#splitter").kendoSplitter({
        ///     resize: onResize
        /// });
        /// 
        /// // detach resize event handler via unbind()
        /// splitter.data("kendoSplitter").unbind("resize", onResize);
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> resize
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"resize\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"resize\"")]
            remove { }
        }

        /// <summary>
        /// 
        /// </summary>
        public JsObject element { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SplitterConfiguration
    {
        /// <summary>
        /// (default: horizontal) Specifies the orientation of the Splitter.
        /// </summary>
        public OrientationOptions orientation { get; set; }

        /// <summary>
        /// An array of pane definitions.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#splitter").kendoSplitter({
        ///    panes: [
        ///        { size: "200px", min: "100px", max: "300px" },
        ///        { size: "20%", resizable: false },
        ///        { collapsed: true, collapsible: true }
        ///    ]
        ///});
        ///</code>
        ///</example>
        public JsArray<SplitterPaneConfiguration> panes { get; set; }
        /// <summary>
        /// Triggered when a pane of a Splitter is expanded.
        /// </summary>
        public JsAction<SplitterEventData> expand { get; set; }
        /// <summary>
        /// Triggered when a pane of a Splitter is collapsed.
        /// </summary>
        public JsAction<SplitterEventData> collapse { get; set; }
        /// <summary>
        /// Triggered when the content for a pane has finished loading.
        /// </summary>
        public JsAction<SplitterEventData> contentLoad { get; set; }
        /// <summary>
        /// Triggered when a pane is resized.
        /// </summary>
        public JsAction<SplitterEventData> resize { get; set; }

    }

    [JsType(JsMode.Json)]
    public class SplitterPaneConfiguration
    {
        /// <summary>
        /// (default: false) Specifies whether a pane is initially collapsed (true) or expanded (true).
        /// </summary>
        public bool collapsed { get; set; }

        /// <summary>
        /// (default: false) Specifies whether a pane is collapsible (true) or not collapsible (false).
        /// </summary>
        public bool collapsible { get; set; }

        /// <summary>
        /// (default: true) Specifies the URL from which to load the content of a pane.
        /// </summary>
        public bool contentUrl { get; set; }

        /// <summary>
        /// (default: true) Specifies the URL from which to load the content of a pane.
        /// </summary>
        [JsProperty(Name = "contentUrl")]
        public JsString contentUrlString { get; set; }

        /// <summary>
        /// Specifies the maximum size of a pane defined as pixels
        /// (i.e. "200px") or as a percentage (i.e. "50%"). The size of a resized pane cannot exceed the defined maximum size.
        /// </summary>
        public JsString max { get; set; }

        /// <summary>
        /// Specifies the minimum size of a pane defined as pixels
        /// (i.e. "200px") or as a percentage (i.e. "50%"). The size of a resized pane cannot be less than the defined minimum size.
        /// </summary>
        public JsString min { get; set; }

        /// <summary>
        /// (default: true) Specifies whether a pane is resizable (true) or not resizable (false).
        /// </summary>
        public bool resizable { get; set; }

        /// <summary>
        /// (default: true) Specifies whether a pane is scrollable (true) or not scrollable (false).
        /// </summary>
        public bool scrollable { get; set; }

        /// <summary>
        /// Specifies the size of a pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%"). Note: This value must not exceed panes.max or be less then panes.min
        /// </summary>
        public JsString size { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SplitterEventData
    {

        public HtmlElement pane { get; set; }
    }

    #endregion

    #region TabStrip

    [JsType(JsMode.Prototype, Name = "kendo.ui.TabStrip", Export = false)]
    public class TabStrip
    {
        /// <summary>
        /// Activates a tab specified as a selector. Note: Invoking this method will not trigger any events.
        /// </summary>
        /// <param name="item">The target tab, specified as a selector, to be activated.</param>
        /// <returns> Returns true if successful; otherwise, false.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var tabToActivate = $("#tab1");
        /// $("#tabStrip").data("kendoTabStrip").activateTab(tabToActivate);
        ///</code>
        ///</example>
        public bool activateTab(JsString item) { return false; }

        /// <summary>
        /// Appends a tab to the collection of tabs in a TabStrip.
        /// </summary>
        /// <param name="tab">Target tab, specified as a JSON object. You can pass tab text, content or contentUrl here.
        /// Can handle an HTML string or array of such strings or JSON.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        public TabStrip append(JsString tab) { return null; }

        /// <summary>
        /// Obtains the DOM element representing a tab by its index in the TabStrip.
        /// </summary>
        /// <param name="itemIndex">The index of the tab in the TabStrip.</param>
        /// <returns>The DOM element representing a tab by its index in the TabStrip.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var tabContent = $("#tabStrip").data("kendoTabStrip").contentElement(0);
        ///</code>
        ///</example>
        public HtmlElement contentElement(JsNumber itemIndex) { return null; }

        /// <summary>
        /// Deactivates a tab specified as a selector. Note: Invoking this method will not trigger any events.
        /// </summary>
        /// <param name="item">The target tab, specified as a selector, to be deactivated.</param>
        ///<example>
        ///usage
        ///<code>
        ///var tabToDeactivate = $("#tab1");
        /// $("#tabStrip").data("kendoTabStrip").deactivateTab(tabToActivate);
        ///</code>
        ///</example>
        public void deactivateTab(JsString item) { }

        /// <summary>
        /// Disables a tab(s) of a TabStrip.
        /// </summary>
        /// <param name="element">The target tab(s), specified as a selector, to be disabled.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        public TabStrip disable(JsString element) { return null; }

        /// <summary>
        /// Disables (false) or enables (true) a tab(s) of a TabStrip.
        /// </summary>
        /// <param name="element">The target tab(s), specified as a selector, to be enabled (true) or disabled (false).</param>
        /// <param name="enable">Desired state of the tab(s) specified by the selector; enabled (true) or disabled (false).</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        public TabStrip enable(JsString element, bool enable) { return null; }

        /// <summary>
        /// Inserts a newly-created tab after a specified tab.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public TabStrip insertAfter(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts a newly-created tab after a specified tab.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public TabStrip insertAfter(JsArray<JsString> item, object referenceItem) { return null; }

        /// <summary>
        /// Inserts a newly-created tab before a specified tab.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>TabStrip Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public TabStrip insertBefore(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts a newly-created tab before a specified tab.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>TabStrip Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public TabStrip insertBefore(JsArray<JsString> item, object referenceItem) { return null; }

        /// <summary>
        /// Reloads TabStrip tab(s) via AJAX.
        /// </summary>
        /// <param name="element">The target tab(s), specified as a selector, to be reloaded via AJAX.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        public TabStrip reload(JsString element) { return null; }

        /// <summary>
        /// Removes a specified tab from a TabStrip.
        /// </summary>
        /// <param name="element">The target tab(s), specified as a selector, to be removed.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///tabStrip.remove("#tab1");
        ///</code>
        ///</example>
        public TabStrip remove(JsString element) { return null; }

        /// <summary>
        /// Selects the specified tab(s) within a TabStrip. If called without arguments, it returns the currently selected tab.
        /// </summary>
        /// <param name="element">or index The target tab(s), specified as a selector or index in the tab group.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///tabStrip.select("#tab1");
        ///</code>
        ///</example>
        public TabStrip select(JsString element) { return null; }
        /// <summary>
        /// Selects the specified tab(s) within a TabStrip. If called without arguments, it returns the currently selected tab.
        /// </summary>
        /// <param name="element">or index The target tab(s), specified as a selector or index in the tab group.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///tabStrip.select("#tab1");
        ///</code>
        ///</example>
        public TabStrip select(JsNumber element) { return null; }
        /// <summary>
        /// Selects the specified tab(s) within a TabStrip. If called without arguments, it returns the currently selected tab.
        /// </summary>
        /// <param name="element">or index The target tab(s), specified as a selector or index in the tab group.</param>
        /// <returns>Returns the TabStrip object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///tabStrip.select("#tab1");
        ///</code>
        ///</example>
        public TabStrip select() { return null; }


        /// <summary>
        /// Triggered just after a tab is being made visible, but before the end of the animation
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for activate
        /// var onActivate = function(e) {
        ///     // access the activated item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach activate event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     activate: onActivate
        /// });
        /// 
        /// // detach activate event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("activate", onActivate);
        ///</code>
        ///</example>
        public event JsAction<TabStripSelectEventData> activate
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"activate\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"activate\"")]
            remove { }
        }

        /// <summary>
        /// Fires when content is fetched from an AJAX request.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    contentLoad: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<TabStripSelectEventData> contentLoad
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"contentLoad\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"contentLoad\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when an AJAX request results in an error.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    error: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<PanelBarErrorEventData> error
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"error\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"error\"")]
            remove { }
        }

        /// <summary>
        /// Triggered before a tab is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<TabStripSelectEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class TabStripConfiguration
    {
        /// <summary>
        /// A collection of visual animations used when TabStrip tab are selected through user interactions. Setting this option to false will disable all animations.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        // fade-out closing items over 1000 milliseconds
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        },
        ///       // fade-in and expand opening items over 500 milliseconds
        ///       open: {
        ///           duration: 500,
        ///           effects: "expandVertical fadeIn"
        ///       }
        ///   }
        ///});
        ///</code>
        ///</example>
        public PanelBarAnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: false) Specifies whether the TabStrip should be able to collapse completely when clicking an expanded tab.
        /// </summary>
        public bool collapsible { get; set; }
        /// <summary>
        /// Undocument property. Add by Lee.
        /// </summary>
        public JsArray<JsString> contentUrls { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the tab content element.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#tabstrip").kendoTabStrip({
        ///     dataTextField: "Name",
        ///     dataContentField: "Content",
        ///     dataSource: data
        /// });
        ///</code>
        ///</example>
        public JsString dataContentField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the URL for the ajax loaded tab content.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#tabstrip").kendoTabStrip({
        ///     dataTextField: "Name",
        ///     dataContentUrlField: "ContentUrl",
        ///     dataSource: data
        /// });
        ///</code>
        ///</example>
        public JsString dataContentUrlField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the image URL of the tab.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#tabstrip").kendoTabStrip({
        ///     dataTextField: "Name",
        ///     dataImageUrlField: "ImageUrl",
        ///     dataSource: data
        /// });
        ///</code>
        ///</example>
        public JsString dataImageUrlField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the CSS class of the tab.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#tabstrip").kendoTabStrip({
        ///     dataTextField: "Name",
        ///     dataSpriteCssClass: "CssClass ",
        ///     dataSource: data
        /// });
        ///</code>
        ///</example>
        public JsString dataSpriteCssClass { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text name of the tab.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#tabstrip").kendoTabStrip({
        ///    dataTextField: "Name",
        ///    dataSource: data
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the link URL for the tab.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#tabstrip").kendoTabStrip({
        ///    dataTextField: "Name",
        ///    dataUrlField: "Url",
        ///    dataSource: data
        ///});
        ///</code>
        ///</example>
        public JsString dataUrlField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public JsAction<TabStripSelectEventData> select { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsAction<TabStripSelectEventData> activate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsAction<TabStripSelectEventData> contentLoad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public JsAction<TabStripErroEventData> error { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TabStripSelectEventData
    {
        /// <summary>
        /// The selected item chosen by a user.
        /// </summary>
        public HtmlElement item { get; set; }

        /// <summary>
        /// The content element of the tab going to be selected.
        /// </summary>
        public HtmlElement contentElement { get; set; }
    }
    [JsType(JsMode.Json)]
    public class TabStripErroEventData
    {
        /// <summary>
        /// The jqXHR object used to load the content
        /// </summary>
        public jqXHR xhr { get; set; }

        /// <summary>
        /// The returned status.
        /// </summary>
        public JsString status { get; set; }
    }


    #endregion

    #region TimePicker

    [JsType(JsMode.Prototype, Name = "kendo.ui.TimePicker", Export = false)]
    public class TimePicker
    {
        /// <summary>
        /// Closes the drop-down list of a TimePicker
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("timepicker").data("kendoTimePicker").close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Enables or disables a TimePicker.
        /// </summary>
        /// <param name="enable">Enables (true or undefined) or disables (false) a DateTimePicker.</param>
        ///<example>
        ///usage
        ///<code>
        ///$("timepicker").data("kendoTimePicker").enable();
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Enables or disables a TimePicker.
        /// </summary>
        /// <param name="enable">Enables (true or undefined) or disables (false) a DateTimePicker.</param>
        ///<example>
        ///usage
        ///<code>
        ///$("timepicker").data("kendoTimePicker").enable();
        ///</code>
        ///</example>
        public void enable() { }

        /// <summary>
        /// Sets the max value of the TimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the TimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the TimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the TimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the TimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the TimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the drop-down list of a TimePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("timepicker").data("kendoTimePicker").open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Sets the value of the TimePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }
        /// <summary>
        /// Sets the value of the TimePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsDate value) { }
        /// <summary>
        /// Gets the value of the TimePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsDate value() { return null; }

        /// <summary>
        /// Triggered when the underlying value of a TimePicker is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"change\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"change\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the time drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Fires when the time drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class TimePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn of the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#timepicker").kendoTimePicker({
        ///     animation: {
        ///         close: {
        ///             effects: "fadeOut",
        ///             duration: 300,
        ///             hide: true
        ///             show: false
        ///         }
        ///     }
        /// });
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// Triggered when the underlying value of a TimePicker is changed.
        /// </summary>
        /// <example>
        /// Attach change event handler during initialization; detach via unbind()
        /// <code>
        /// // event change for expand
        /// var onChange = function(e) {
        ///     // ...
        /// };
        /// // attach change event handler during initialization
        /// var timePicker = $("#timePicker").kendoTimePicker({
        ///    change: onChange
        ///});
        /// // detach change event handler via unbind()
        /// timePicker.data("kendoTimePicker").unbind("change", onChange);
        /// </code>
        /// </example>
        public JsAction change { get; set; }


        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which are shown in the time drop-down list. If not set, the DateTimePicker will auto-generate the available times.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //the drop-down list will consist only two entries - "10:00 AM" and "10:30 AM"
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// (default: h:mm tt) Specifies the format, which is used to format the value of the TimePicker displayed in the input. The format also will be used to parse the input.
        /// </summary>
        public JsString format { get; set; }

        /// <summary>
        /// (default: 30) Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    interval: 15
        ///});
        ///</code>
        ///</example>
        public JsNumber interval { get; set; }

        /// <summary>
        /// (default: 00:00) Specifies the end value in the popup list.
        /// </summary>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: 00:00) Specifies the start value in the popup list.
        /// </summary>
        public JsDate min { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with the value method or by direct input.
        /// If not set the value of the options.format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#timePicker").kendoTimePicker({
        ///    format: "h:mm tt",
        ///    parseFormats: ["HH:mm"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected time.
        /// </summary>
        public JsDate value { get; set; }
    }

    #endregion

    #region TreeView

    [JsType(JsMode.Prototype, Name = "kendo.ui.TreeView", Export = false)]
    public class TreeView<T>
    {
        /// <summary>
        /// Appends a node to a group of a TreeView. This method may also be used to reorder the nodes of a TreeView.
        /// </summary>
        /// <param name="nodeData">A JSON-formatted string or selector that specifies the node to be appended.</param>
        /// <param name="parentNode">The node that will contain the newly appended node. If not specified, the new node will be appended to the root group of the TreeView.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///treeView.append({ text: "HTML5" }, $("#firstItem"));
        ///</code>
        ///</example>
        public void append(JsString nodeData, Node parentNode) { }
        //TODO: parentNode type is Node
        /// <summary>
        /// Appends a node to a group of a TreeView. This method may also be used to reorder the nodes of a TreeView.
        /// </summary>
        /// <param name="nodeData">A JSON-formatted string or selector that specifies the node to be appended.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///treeView.append({ text: "HTML5" }, $("#firstItem"));
        ///</code>
        ///</example>
        public void append(JsString nodeData) { }

        /// <summary>
        /// Collapses nodes.
        /// </summary>
        /// <param name="nodes">The nodes that are to be collapsed.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeview = $("#treeview").data("kendoTreeView");
        ///
        /// // collapse the node with id="firstItem"
        ///treeview.collapse(document.getElementById("firstItem"));
        ///
        /// // collapse all nodes
        ///treeview.collapse(".k-item");
        ///</code>
        ///</example>
        public void collapse(JsString nodes) { }
        //TODO: one more parameter (?) e.node (Node) The collapsed node

        /// <summary>
        /// Returns the model dataItem that corresponds to a TreeView node
        /// </summary>
        /// <param name="node">The element or selector that specifies a node.</param>
        /// <returns></returns>
        public Model<T> dataItem(jQuery.jQuery node) { return null; }
        //TODO: return type?
        /// <summary>
        /// Returns the model dataItem that corresponds to a TreeView node
        /// </summary>
        /// <param name="node">The element or selector that specifies a node.</param>
        /// <returns></returns>
        public Model<T> dataItem(HtmlElement node) { return null; }
        //TODO: return type?
        /// <summary>
        /// Returns the model dataItem that corresponds to a TreeView node
        /// </summary>
        /// <param name="node">The element or selector that specifies a node.</param>
        /// <returns></returns>
        public Model<T> dataItem(JsString node) { return null; }
        //TODO: return type?

        /// <summary>
        /// Removes a node from a TreeView, but keeps its jQuery.data() objects.
        /// </summary>
        /// <param name="node">The node that is to be detached.</param>
        /// <returns>The node that has been detached.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///var firstItem = $("#firstItem");
        ///firstItem.data("id", 1);
        ///treeview.detach(firstItem);
        ///firstItem.data("id") == 1;
        ///</code>
        ///</example>
        public jQuery.jQuery detach(JsString node) { return null; }

        /// <summary>
        /// Enables or disables nodes.
        /// </summary>
        /// <param name="nodes">The nodes that are to be enabled/disabled.</param>
        /// <param name="enable">(optional, default: true) Whether the nodes should be enabled or disabled.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeview = $("#treeview").data("kendoTreeView");
        /// 
        /// // disable the node with id="firstItem"
        /// treeview.enable(document.getElementById("firstItem"), false);
        /// 
        /// // enable all nodes
        /// treeview.enable(".k-item");
        ///</code>
        ///</example>
        public void enable(JsString nodes, bool enable = true) { }

        /// <summary>
        /// Enables or disables nodes.
        /// </summary>
        /// <param name="nodes">The nodes that are to be enabled/disabled.</param>
        /// <param name="enable">(optional, default: true) Whether the nodes should be enabled or disabled.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeview = $("#treeview").data("kendoTreeView");
        /// 
        /// // disable the node with id="firstItem"
        /// treeview.enable(document.getElementById("firstItem"), false);
        /// 
        /// // enable all nodes
        /// treeview.enable(".k-item");
        ///</code>
        ///</example>
        public void enable(jQuery.jQuery nodes, bool enable = true) { }

        /// <summary>
        /// Enables or disables nodes.
        /// </summary>
        /// <param name="nodes">The nodes that are to be enabled/disabled.</param>
        /// <param name="enable">(optional, default: true) Whether the nodes should be enabled or disabled.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeview = $("#treeview").data("kendoTreeView");
        /// 
        /// // disable the node with id="firstItem"
        /// treeview.enable(document.getElementById("firstItem"), false);
        /// 
        /// // enable all nodes
        /// treeview.enable(".k-item");
        ///</code>
        ///</example>
        public void enable(Node nodes, bool enable = true) { }

        /// <summary>
        /// Expands nodes.
        /// </summary>
        /// <param name="nodeSelector">The nodes that are to be expanded..</param>
        ///<example>
        ///usage
        ///<code>
        /// var treeview = $("#treeview").data("kendoTreeView");
        /// 
        /// // expands the node with id="firstItem"
        /// treeview.expand(document.getElementById("firstItem"));
        /// 
        /// // expands all nodes
        /// treeview.expand(".k-item");
        ///</code>
        ///</example>
        public void expand(JsString nodeSelector) { }

        /// <summary>
        /// Expands nodes.
        /// </summary>
        /// <param name="nodeSelector">The nodes that are to be expanded..</param>
        ///<example>
        ///usage
        ///<code>
        /// var treeview = $("#treeview").data("kendoTreeView");
        /// 
        /// // expands the node with id="firstItem"
        /// treeview.expand(document.getElementById("firstItem"));
        /// 
        /// // expands all nodes
        /// treeview.expand(".k-item");
        ///</code>
        ///</example>
        public void expand(jQuery.jQuery nodeSelector) { }

        /// <summary>
        /// Expands nodes.
        /// </summary>
        /// <param name="node">The node that is to be expanded..</param>
        ///<example>
        ///usage
        ///<code>
        /// var treeview = $("#treeview").data("kendoTreeView");
        /// 
        /// // expands the node with id="firstItem"
        /// treeview.expand(document.getElementById("firstItem"));
        /// 
        /// // expands all nodes
        /// treeview.expand(".k-item");
        ///</code>
        ///</example>
        public void expand(Node node) { }
        //TODO: one more parameter (?) e.node (Node) The collapsed node

        /// <summary>
        /// Searches a TreeView for a node that has specific text.
        /// </summary>
        /// <param name="text">The text that is being searched for.</param>
        /// <returns>All nodes that have the text.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///var foundNode = treeView.findByText("CSS3 is da bomb!");
        ///</code>
        ///</example>
        public jQuery.jQuery findByText(JsString text) { return null; }

        /// <summary>
        /// Searches a TreeView for a node with the given unique identifier. Applicable when the widget is bound to a HierarchicalDataSource.
        /// </summary>
        /// <param name="text">The text that is being searched for.</param>
        /// <returns>All nodes that have the text.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///var node = treeView.findByUid("95c1925d-a779-47fc-8420-b4274f01c037");
        ///</code>
        ///</example>
        public jQuery.jQuery findByUid(JsString text) { return null; }

        /// <summary>
        /// Inserts a node after a specified node in a TreeView. This method may also be used to reorder the nodes of a TreeView.
        /// </summary>
        /// <param name="nodeData">A JSON-formatted string or selector that specifies the node to be inserted.</param>
        /// <param name="referenceNode">The node that will be preceed the newly-appended node.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///treeView.insertAfter({ text: "JavaScript" }, $("#firstItem"));
        ///</code>
        ///</example>
        public void insertAfter(JsString nodeData, Node referenceNode) { }

        /// <summary>
        /// Inserts a node before another node. This method may also be used to reorder the nodes of a TreeView.
        /// </summary>
        /// <param name="nodeData">A JSON-formatted string or selector that specifies the node to be inserted.</param>
        /// <param name="referenceNode">The node that will be preceed the newly-appended node.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///treeView.insertBefore({ text: "CSS3" }, $("#firstItem"));
        ///</code>
        ///</example>
        public void insertBefore(JsString nodeData, Node referenceNode) { }

        /// <summary>
        /// Removes a node from a TreeView.
        /// </summary>
        /// <param name="node">The node that is to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///treeView.remove($("#firstItem"));
        ///</code>
        ///</example>
        public void remove(JsString node) { }

        /// <summary>
        /// Gets the selected node of a TreeView.
        /// </summary>
        /// <returns>The selected node of a TreeView.</returns>
        public Node select() { return null; }
        /// <summary>
        /// Sets the selected node of a TreeView.
        /// </summary>
        /// <param name="selector">If provided, the node of a TreeView that should be selected.</param>
        public void select(JsString selector) { }

        /// <summary>
        /// Sets the selected node of a TreeView.
        /// </summary>
        /// <param name="selector">If provided, the node of a TreeView that should be selected.</param>
        public void select(jQuery.jQuery selector) { }

        /// <summary>
        /// Sets the selected node of a TreeView.
        /// </summary>
        /// <param name="domNode">If provided, the node of a TreeView that should be selected.</param>
        public void select(Node domNode) { }

        /// <summary>
        /// Gets the text of a node in a TreeView.
        /// </summary>
        /// <param name="node">The node of which the text is being retrieved.</param>
        /// <returns>The text of a node.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///var nodeText = treeView.text($("#firstItem"));
        ///</code>
        ///</example>
        public JsString text(JsString node) { return null; }

        /// <summary>
        /// Toggles the node of a TreeView between its expanded and collapsed states.
        /// </summary>
        /// <param name="node">The node that should be toggled.</param>
        ///<example>
        ///usage
        ///<code>
        ///var treeView = $("#treeView").data("kendoTreeView");
        ///treeView.toggle($("#firstItem"));
        ///</code>
        ///</example>
        public void toggle(JsString node) { }


        /// <summary>
        /// Triggered before a subgroup gets collapsed.
        /// </summary>
        public event JsAction<TreeViewEventData> collapseEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"collapse\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"collapse\"")]
            remove { }
        }

        /// <summary>
        /// Triggered while a node is being dragged.
        /// Pre-defined status classes are:
        /// k-insert-top - Indicates that the item will be inserted on top.
        /// k-insert-middle - Indicates that the item will be inserted in the middle.
        /// k-insert-bottom - Indicates that the item will be inserted at the bottom.
        /// k-add - Indicates that the item will be added/appended.
        /// k-denied - Indicates an invalid operation
        /// Using this class will automatically make the drop operation invalid, so there will be no need to call setValid(false) in the drop event.
        /// </summary>
        public event JsAction<TreeViewDragEventData> drag
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"drag\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"drag\"")]
            remove { }
        }
        //TODO:check summary (?)

        /// <summary>
        /// Triggered after a node has been dropped.
        /// </summary>
        public event JsAction<TreeViewDragendEventData> dragend
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"dragend\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"dragend\"")]
            remove { }
        }

        /// <summary>
        /// Triggered before the dragging of a node starts.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///treeview.data("kendoTreeView").bind("dragstart", function(e) {
        ///    if ($(e.sourceNode).parentsUntil(".k-treeview", ".k-item").length == 0) {
        ///        e.preventDefault();
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<TreeViewDragstartEventData> dragstart
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"dragstart\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"dragstart\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a node is being dropped.
        /// </summary>
        public event JsAction<TreeViewDropEventData> drop
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"drop\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"drop\"")]
            remove { }
        }

        /// <summary>
        /// Triggered before a subgroup gets expanded.
        /// </summary>
        public event JsAction<TreeViewEventData> expandEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"expand\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"expand\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a node gets selected.
        /// </summary>
        public event JsAction<TreeViewEventData> selectEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class TreeViewConfiguration<T>
    {
        /// <summary>
        /// A collection of visual animations used when items are expanded or collapsed through user interaction. Setting this option to false will disable all animations.
        /// </summary>
        public TreeViewAnimationConfiguration animation { get; set; }

        public JsString checkboxTemplate { get; set; }
        [JsProperty(Name = "checkboxTemplate")]
        public JsFunc<JsString, JsString> checkboxTemplateFunc { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the image URL of the treeview nodes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#tabstrip").kendoTabStrip({
        ///     dataTextField: "Name",
        ///     dataImageUrlField: "ImageUrl",
        ///     dataSource: data
        /// });
        ///</code>
        ///</example>
        public JsString dataImageUrlField { get; set; }

        /// <summary>
        /// The data that the TreeView will be bound to, as an array (that will be turned into a DataSource internally)
        /// </summary>
        [JsProperty(Name="dataSource")]
        public JsArray dataSourceArray { get; set; }

        /// <summary>
        /// The Datasource that the TreeView will be bound to
        /// </summary>
        public DataSource<T> dataSource { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the sprite CSS class of the treeview nodes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [
        ///    { id: 1, text: "Tea", sprite: "icon-tea" },
        ///    { id: 2, text: "Coffee", sprite: "icon-coffee" }
        ///];
        ///
        ///$("#treeview").kendoTreeView({
        ///    dataSource: items,
        ///    dataSpriteCssClassField: "sprite"
        ///});
        ///</code>
        ///</example>
        public JsString dataSpriteCssClassField { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the text content of the treeview nodes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#tabstrip").kendoTabStrip({
        ///    dataTextField: "Name",
        ///    dataSource: data
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the link URL of the treeview nodes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#tabstrip").kendoTabStrip({
        ///    dataTextField: "Name",
        ///    dataUrlField: "Url",
        ///    dataSource: data
        ///});
        ///</code>
        ///</example>
        public JsString dataUrlField { get; set; }

        /// <summary>
        /// (default: false) Disables (false) or enables (true) drag-and-drop on the nodes of a TreeView.
        /// </summary>
        public bool dragAndDrop { get; set; }

        /// <summary>
        /// (default: true) Indicates whether the child datasources should be fetched lazily, when parent groups get expanded.
        /// Setting this to false causes all child dataSources to be loaded at initialization time.
        /// Note: when initializing a TreeView from array (rather than from a HierarchicalDataSource instance), the default value of this option is false.
        /// </summary>
        public bool loadOnDemand { get; set; }

        /// <summary>
        /// Template for rendering of the nodes of the treeview.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#treeview").kendoTreeView({
        ///    template: "#= item.text # <a href='\\#'>Delete</a>"
        ///});
        ///</code>
        ///</example>
        public JsString template { get; set; }
        /// <summary>
        /// Template for rendering of the nodes of the treeview.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#treeview").kendoTreeView({
        ///    template: "#= item.text # <a href='\\#'>Delete</a>"
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "template")]
        public JsFunc<JsString, JsString> templateFunction { get; set; }
        public JsAction<TreeViewEventData> collapse { get; set; }
        public JsAction<TreeViewEventData> select { get; set; }
        public JsAction<TreeViewEventData> expand { get; set; }
        public JsAction<TreeViewDragstartEventData> dragstart { get; set; }
        public JsAction<TreeViewDragEventData> drag { get; set; }
        public JsAction<TreeViewDropEventData> drop { get; set; }
        public JsAction<TreeViewDragendEventData> dragend { get; set; }
        public JsAction<TreeViewDataBoundEventData> dataBound { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeViewAnimationConfiguration
    {
        /// <summary>
        /// The animation that will be used when collapsing items.
        /// </summary>
        public TreeViewAnimationCollapseConfiguration collapse { get; set; }

        /// <summary>
        /// The animation that will be used when expanding items.
        /// </summary>
        public TreeViewAnimationExpandConfiguration expand { get; set; }

    }

    [JsType(JsMode.Json)]
    public class TreeViewAnimationCollapseConfiguration
    {
        /// <summary>
        /// (default: 200) The number of milliseconds used for the animation when a node is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#treeView").kendoTreeView({
        ///    animation: {
        ///        collapse: {
        ///            duration: 1000
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsNumber duration { get; set; }

        /// <summary>
        /// A whitespace-delimited string of animation effects that are utilized when a TreeView node is collapsed. Options include "fadeOut".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#treeView").kendoTreeView({
        ///    animation: {
        ///        collapse: {
        ///            duration: 5000,
        ///            effects: "fadeOut"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsString effects { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeViewAnimationExpandConfiguration
    {
        /// <summary>
        /// (default: 200) The number of milliseconds used for the animation when a node is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#treeView").kendoTreeView({
        ///    animation: {
        ///        collapse: {
        ///            duration: 1000
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsNumber duration { get; set; }

        /// <summary>
        /// (default: "expandVertical") A whitespace-delimited string of animation effects that are utilized when a TreeView node is expanded. Options include "expandVertical" and "fadeIn".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#treeView").kendoTreeView({
        ///    animation: {
        ///        collapse: {
        ///            duration: 5000,
        ///            effects: "fadeOut"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsString effects { get; set; }

        /// <summary>
        /// (default: true)
        /// </summary>
        public bool show { get; set; }
    }

    [JsType(JsMode.Json)]
    public abstract class AbstractTreeViewEventData
    {
        public void preventDefault() { }
    }

    [JsType(JsMode.Json)]
    public class TreeViewEventData : AbstractTreeViewEventData
    {
        public Node node { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeViewDragEventData : AbstractTreeViewEventData
    {
        /// <summary>
        /// The node that is being dragged.
        /// </summary>
        public Node sourceNode { get; set; }

        /// <summary>
        /// The element that the node is placed over.
        /// </summary>
        public HtmlElement dropTarget { get; set; }

        /// <summary>
        /// The x coordinate of the mouse.
        /// </summary>
        public JsNumber pageX { get; set; }

        /// <summary>
        /// The y coordinate of the mouse.
        /// </summary>
        public JsNumber pageY { get; set; }

        /// <summary>
        /// The status that the drag clue shows. <see cref="setStatusClass" />
        /// </summary>
        public JsString statusClass { get; private set; }

        /// <summary>
        /// Allows a custom drag clue status to be set.
        /// Pre-defined status classes are:
        /// <list type="list">
        /// <item>k-insert-top - Indicates that the item will be inserted on top.</item>
        /// <item>k-insert-middle - Indicates that the item will be inserted in the middle.</item>
        /// <item>k-insert-bottom - Indicates that the item will be inserted at the bottom.</item>
        /// <item>k-add - Indicates that the item will be added/appended.</item>
        /// <item>k-denied - Indicates an invalid operation. Using this class will automatically make the drop operation invalid, so there will be no need to call setValid(false) in the drop event.</item>
        /// </list>
        /// </summary>
        /// <param name="cssClass">The css class or classes (separated by spaces) to set on the item</param>
        public void setStatusClass(JsString cssClass) { }
    }


    [JsType(JsMode.Json)]
    public class TreeViewDragendEventData : AbstractTreeViewEventData
    {
        /// <summary>
        /// The node that is being dropped.
        /// </summary>
        public Node sourceNode { get; set; }

        /// <summary>
        /// The node that the sourceNode is being dropped upon.
        /// </summary>
        public Node destinationNode { get; set; }

        /// <summary>
        /// Shows where the source has been dropped. One of the values over, before, or after.
        /// </summary>
        public JsString dropPosition { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeViewDataBoundEventData : AbstractTreeViewEventData
    {
        /// <summary>
        /// The node whose children have been changed. If the changes have occurred on the root level, this parameter is undefined.
        /// </summary>
        public jQuery.jQuery node { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeViewDragstartEventData : AbstractTreeViewEventData
    {
        /// <summary>
        /// The node that will be dragged.
        /// </summary>
        public Node sourceNode { get; set; }
    }

    [JsType(JsMode.Json)]
    public class TreeViewDropEventData : AbstractTreeViewEventData
    {
        /// <summary>
        /// The node that is being dropped.
        /// </summary>
        public Node sourceNode { get; set; }

        /// <summary>
        /// The node that the sourceNode is being dropped upon.
        /// </summary>
        public Node destinationNode { get; set; }

        /// <summary>
        /// Whether this drop operation is permitted.
        /// </summary>
        public bool valid { get; set; }

        /// <summary>
        /// Allows the drop to be prevented.
        /// </summary>
        public void setValid(bool isValid) { }

        /// <summary>
        /// The element that the node is placed over.
        /// </summary>
        public HtmlElement dropTarget { get; set; }

        /// <summary>
        /// Shows where the source will be dropped. One of the values over, before, or after.
        /// </summary>
        public JsString dropPosition { get; set; }

        
    }

    #endregion

    #region Upload

    [JsType(JsMode.Prototype, Name = "kendo.ui.Upload", Export = false)]
    public class Upload
    {

        /// <summary>
        /// Disables the upload.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var upload = $("#upload").data("kendoUpload");
        /// 
        /// // disables the upload
        /// upload.enable();
        ///</code>
        ///</example>
        public void disable() { }

        /// <summary>
        /// Prepares the Upload for safe removal from the DOM. Detaches event handlers and removes data entries in order to avoid memory leaks.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // Destroy widget and detach events
        /// $("#upload").data("kendoUpload").destroy();
        /// 
        /// // Remove widget element from DOM
        /// $("#upload").closest(".k-upload").remove();
        ///</code>
        ///</example>
        public void destroy() { }

        /// <summary>
        /// Enables the upload.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// var upload = $("#upload").data("kendoUpload");
        /// 
        /// // enables the upload
        /// upload.enable();
        ///</code>
        ///</example>
        public void enable() { }
        //TODO: wird parameter

        /// <summary>
        /// Toggles the upload enabled state.
        /// </summary>
        /// <param name="enable">(Optional) The new enabled state.</param>
        ///<example>
        ///usage
        ///<code>
        ///var upload = $("#upload").data("kendoUpload");
        /// 
        /// // toggles the upload enabled state
        /// upload.toggle();
        ///</code>
        ///</example>
        public void toggle(bool enable) { }
        /// <summary>
        /// Toggles the upload enabled state.
        /// </summary>
        /// <param name="enable">(Optional) The new enabled state.</param>
        ///<example>
        ///usage
        ///<code>
        ///var upload = $("#upload").data("kendoUpload");
        /// 
        /// // toggles the upload enabled state
        /// upload.toggle();
        ///</code>
        ///</example>
        public void toggle() { }

        /// <summary>
        /// Fires when the upload has been cancelled while in progress.
        /// Note: The cancel event fires only when the upload is in async mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///     // ...
        ///     cancel: onCancel
        /// });
        /// 
        /// function onCancel(e) {
        ///     // Array with information about the uploaded files
        ///     var files = e.files;
        /// 
        ///     // Process the Cancel event
        /// }
        ///</code>
        ///</example>
        public event JsAction<UploadCancelSelectEventData> cancel
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"cancel\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"cancel\"")]
            remove { }
        }

        /// <summary>
        /// Fires when all active uploads have completed either successfully or with errors.
        /// Note: The complete event fires only when the upload is in async mode.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///     // ...
        ///     complete: onComplete
        /// });
        /// 
        /// function onComplete(e) {
        ///     // The upload is now idle
        /// }
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> complete
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"complete\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"complete\"")]
            remove { }
        }

        /// <summary>
        /// Fires when an upload / remove operation has failed.
        /// Note: The error event fires only when the upload is in async mode.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///     // ...
        ///     error: onError
        /// });
        /// 
        /// function onError(e) {
        ///     // Array with information about the uploaded files
        ///     var files = e.files;
        /// 
        ///     if (e.operation == "upload") {
        ///         alert("Failed to uploaded " + files.length + " files");
        ///     }
        /// }
        ///</code>
        ///</example>
        public event JsAction<UploadErrorEventData> error
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"error\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"error\"")]
            remove { }
        }

        /// <summary>
        /// Fires when upload progress data is available.
        /// Note: The progress event fires only when the upload is in async mode.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///     // ...
        ///     progress: onProgress
        /// });
        /// 
        /// function onProgress(e) {
        ///     // Array with information about the uploaded files
        ///     var files = e.files;
        /// 
        ///     console.log(e.percentComplete);
        /// }
        ///</code>
        ///</example>
        public event JsAction<UploadProgressEventData> progress
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"progress\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"progress\"")]
            remove { }
        }

        /// <summary>
        /// Fires when an uploaded file is about to be removed. Cancelling the event will prevent the remove.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///    // ...
        ///    remove: onRemove
        ///});
        ///
        ///function onRemove(e) {
        ///    // Array with information about the removed files
        ///    var files = e.files;
        ///
        ///    // Process the Remove event
        ///    // Optionally cancel the remove operation by calling
        ///    // e.preventDefault()
        ///}
        ///</code>
        ///</example>
        public event JsAction<UploadUploadRemoveEventData> remove
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"remove\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"remove\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a file(s) is selected. Note: Cancelling this event will prevent the selection from occurring.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///var onSelect = function(e) {
        ///     $.each(e.files, function(index, value) {
        ///         console.log("Name: " + value.name);
        ///         console.log("Size: " + value.size + " bytes");
        ///         console.log("Extension: " + value.extension);
        ///     });
        /// };
        /// 
        /// // initialize and configure an Upload widget with a select event handler
        /// $("#photos").kendoUpload({
        ///     // ...
        ///     select: onSelect
        /// });
        ///</code>
        ///</example>
        public event JsAction<UploadCancelSelectEventData> select
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"select\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"select\"")]
            remove { }
        }

        /// <summary>
        /// Fires when an upload / remove operation has been completed successfully.
        /// Note: The success event fires only when the upload is in async mode.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///     // ...
        ///     success: onSuccess
        /// });
        /// 
        /// function onSuccess(e) {
        ///     // Array with information about the uploaded files
        ///     var files = e.files;
        /// 
        ///     if (e.operation == "upload") {
        ///         alert("Successfully uploaded " + files.length + " files");
        ///     }
        /// }
        ///</code>
        ///</example>
        public event JsAction<UploadSuccessEventData> success
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"success\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"success\"")]
            remove { }
        }

        /// <summary>
        /// Fires when one or more files are about to be uploaded. Cancelling the event will prevent the upload.
        /// Note: The upload event fires only when the upload is in async mode.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#photos").kendoUpload({
        ///     // ...
        ///     upload: onUpload
        /// });
        /// 
        /// function onUpload(e) {
        ///     // Array with information about the uploaded files
        ///     var files = e.files;
        /// 
        ///     // Check the extension of each file and abort the upload if it is not .jpg
        ///     $.each(files, function() {
        ///         if (this.extension != ".jpg") {
        ///             alert("Only .jpg files can be uploaded")
        ///             e.preventDefault();
        ///         }
        ///     });
        /// }
        ///</code>
        ///</example>
        public event JsAction<UploadUploadRemoveEventData> upload
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"upload\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"upload\"")]
            remove { }
        }
    }

    [JsType(JsMode.Json)]
    public class UploadConfiguration
    {
        /// <summary>
        /// Configures the ability to upload a file(s) in an asynchronous manner. Please refer to the async mode help topic for more details.
        /// </summary>
        public UploadAsyncConfiguration @async { get; set; }

        /// <summary>
        /// Sets the strings rendered by the Upload.
        /// </summary>
        public UploadLocalizationConfiguration localization { get; set; }

        /// <summary>
        /// (default: true) Enables (true) or disables (false) an Upload. A disabled Upload may be re-enabled via enable().
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// (default: true) Enables (true) or disables (false) the ability to select multiple files. If false, users will be able to select only one file at a time.
        /// Note: This option does not limit the total number of uploaded files in an asynchronous configuration.
        /// </summary>
        public bool multiple { get; set; }

        /// <summary>
        /// (default: true)Enables (true) or disables (false) the ability to display a file listing for uploading a file(s).
        /// Disabling a file listing may be useful you wish to customize the UI; use the client-side events to build your own UI..
        /// </summary>
        public bool showFileList { get; set; }


    }

    [JsType(JsMode.Json)]
    public class UploadAsyncConfiguration
    {
        /// <summary>
        /// (default: true) The selected files will be uploaded immediately by default. You can change this behavior by setting autoUpload to false.
        /// </summary>
        public bool autoUpload { get; set; }

        /// <summary>
        /// (default: false) The selected files will be uploaded in separate requests, if this is supported by the browser. You can change this behavior by setting batch to true.
        /// </summary>
        public bool batch { get; set; }

        /// <summary>
        /// (default: "fileNames") The name of the form field submitted to the Remove URL.
        /// </summary>
        public JsString removeField { get; set; }

        /// <summary>
        /// The URL of the handler responsible for removing uploaded files (if any).
        /// The handler must accept POST requests containing one or more "fileNames" fields specifying the files to be deleted.
        /// </summary>
        public JsString removeUrl { get; set; }

        /// <summary>
        /// (default: "DELETE") The HTTP verb to be used by the remove action.
        /// </summary>
        public JsString removeVerb { get; set; }

        /// <summary>
        /// The name of the form field submitted to the save URL. The default value is the input name.
        /// </summary>
        public JsString saveField { get; set; }

        /// <summary>
        ///The URL of the handler that will receive the submitted files.
        ///The handler must accept POST requests containing one or more fields with the same name as the original input name.
        /// </summary>
        public JsString saveUrl { get; set; }
    }

    [JsType(JsMode.Json)]
    public class UploadLocalizationConfiguration
    {
        /// <summary>
        /// Sets the text of the cancel button text.
        /// </summary>
        public JsString cancel { get; set; }

        /// <summary>
        /// (default: "drop files here to upload") Sets the drop zone hint.
        /// </summary>
        public JsString dropFilesHere { get; set; }

        /// <summary>
        /// Sets the text of the remove button text.
        /// </summary>
        public JsString remove { get; set; }

        /// <summary>
        /// Sets the text of the retry button text.
        /// </summary>
        public JsString retry { get; set; }

        /// <summary>
        /// Sets the "Select..." button text.
        /// </summary>
        public JsString select { get; set; }

        /// <summary>
        /// Sets the status message for failed uploads.
        /// </summary>
        public JsString statusFailed { get; set; }

        /// <summary>
        /// Sets the status message for uploaded files.
        /// </summary>
        public JsString statusUploaded { get; set; }

        /// <summary>
        /// Sets the status message for files that are being uploaded.
        /// </summary>
        public JsString statusUploading { get; set; }

        /// <summary>
        /// Sets the text of the "Upload files" button.
        /// </summary>
        public JsString uploadSelectedFiles { get; set; }
    }

    [JsType(JsMode.Json)]
    public class UploadCancelSelectEventData
    {
        /// <summary>
        /// List of the files that were uploaded or removed .
        /// Each file has:
        /// name
        /// extension - the file extension inlcuding the leading dot - ".jpg", ".png", etc.
        /// size - the file size in bytes (null if not available)
        /// </summary>
        [JsProperty(Name = "files")]
        public JsArray filesArray { get; set; }
        /// <summary>
        /// List of the files that were uploaded or removed .
        /// Each file has:
        /// name
        /// extension - the file extension inlcuding the leading dot - ".jpg", ".png", etc.
        /// size - the file size in bytes (null if not available)
        /// </summary>
        public UploadFileConfig files { get; set; }
    }

    [JsType(JsMode.Json)]
    public class UploadFileConfig
    {
        public JsString name { get; set; }

        /// <summary>
        ///  the file extension inlcuding the leading dot - ".jpg", ".png", etc.
        /// </summary>
        public JsString extension { get; set; }

        /// <summary>
        /// the file size in bytes (null if not available)
        /// </summary>
        public JsNumber size { get; set; }
    }

    [JsType(JsMode.Json)]
    public class UploadErrorEventData
    {
        /// <summary>
        /// List of the files that were uploaded or removed
        /// </summary>
        public UploadFileConfig files { get; set; }

        public UploadOperationOptions operation { get; set; }

        /// <summary>
        /// This is either the original XHR used for the operation or a stub containing:
        /// responseText
        /// status
        /// statusText Verify that this is an actual XHR before accessing any other fields.
        /// </summary>
        public object XMLHttpRequest { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum UploadOperationOptions
    {
        upload,
        remove,
    }

    [JsType(JsMode.Json)]
    public class UploadProgressEventData
    {
        /// <summary>
        /// List of the files that are being uploaded. Each file has:
        /// </summary>
        public UploadFileConfig files { get; set; }

        /// <summary>
        /// Upload progress (0 - 100)
        /// </summary>
        public JsNumber percentComplete { get; set; }
    }

    [JsType(JsMode.Json)]
    public class UploadUploadRemoveEventData
    {
        /// <summary>
        /// List of the files that were uploaded or removed .
        /// </summary>
        public UploadFileConfig files { get; set; }

        /// <summary>
        /// Optional object that will be sent to the save handler in the form of key/value pairs.
        /// </summary>
        public object data { get; set; }
    }

    [JsType(JsMode.Json)]
    public class UploadSuccessEventData
    {
        /// <summary>
        /// List of the files that were uploaded or removed .
        /// </summary>
        public UploadFileConfig files { get; set; }

        /// <summary>
        /// "upload" or "remove".
        /// </summary>
        public UploadOperationOptions operation { get; set; }

        /// <summary>
        /// the response object returned by the server.
        /// </summary>
        public JsString response { get; set; }

        /// <summary>
        /// This is either the original XHR used for the operation or a stub containing:
        /// responseText
        /// status
        /// statusText Verify that this is an actual XHR before accessing any other fields.
        /// </summary>
        public object XMLHttpRequest { get; set; }
    }

    #endregion

    #region Window

    [JsType(JsMode.Prototype, Name = "kendo.ui.Window", Export = false)]
    public class Window
    {
        /// <summary>
        /// Undocumented
        /// </summary>
        public jQuery.jQuery wrapper { get; set; }
        /// <summary>
        /// Centers a Window within the viewport.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow");
        ///kendoWindow.center();
        ///</code>
        ///</example>
        public Window center() { return null; }

        /// <summary>
        /// Closes a Window.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow").close();
        ///</code>
        ///</example>
        public Window close() { return null; }

        /// <summary>
        /// set the content of a Window.
        /// </summary>
        /// <param name="content">_optional, default: _</param>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow").content("Kendo UI for all the things!");
        ///</code>
        ///</example>
        public Window content(JsString content) { return null; }

        /// <summary>
        /// Gets the content of a Window.
        /// </summary>
        /// <returns>If content is provided, this method will return the (Kendo UI) Window object to support chaining.
        /// Otherwise, it will return the current content of the (Kendo UI) Window.</returns>
        public JsString content() { return null; }

        /// <summary>
        /// Destroys the window and its modal overlay, if necessary. Removes the Window HTML elements from the DOM.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Maximizes a Window to the entire viewing area of the user agent. Triggers the resize event.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///$("#window").data("kendoWindow").maximize();
        ///</code>
        ///</example>
        public Window maximize() { return null; }

        /// <summary>
        /// Maximizes a Window to its title bar.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///$("#window").data("kendoWindow").minimize();
        ///</code>
        ///</example>
        public Window minimize() { return null; }

        /// <summary>
        /// Opens a Window.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow").open();
        ///</code>
        ///</example>
        public Window open() { return null; }

        /// <summary>
        /// Refreshes the content of a Window from a remote URL.
        /// </summary>
        /// <param name="options">Options for requesting data from the server. If omitted, the window uses the content property that was supplied when the window was created.
        /// Any options specified here are passed to jQuery.ajax().</param>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var windowObject = $("#window").data("kendoWindow");
        /// windowObject.refresh("/feedbackForm");
        /// 
        /// windowObject.refresh({
        ///     url: "/feedbackForm",
        ///     data: { userId: 42 }
        /// });
        /// 
        /// windowObject.refresh({
        ///     url: "/userInfo",
        ///     data: { userId: 42 },
        ///     template: "Hello, #= firstName # #= lastName #"
        /// });
        ///</code>
        ///</example>
        public Window refresh(WindowRefreshOptions options) { return null; }
        /// <summary>
        /// Refreshes the content of a Window from a remote URL.
        /// </summary>
        /// <param name="options">Options for requesting data from the server. If omitted, the window uses the content property that was supplied when the window was created.
        /// Any options specified here are passed to jQuery.ajax().</param>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var windowObject = $("#window").data("kendoWindow");
        /// windowObject.refresh("/feedbackForm");
        /// 
        /// windowObject.refresh({
        ///     url: "/feedbackForm",
        ///     data: { userId: 42 }
        /// });
        /// 
        /// windowObject.refresh({
        ///     url: "/userInfo",
        ///     data: { userId: 42 },
        ///     template: "Hello, #= firstName # #= lastName #"
        /// });
        ///</code>
        ///</example>
        public Window refresh() { return null; }
        /// <summary>
        /// Refreshes the content of a Window from a remote URL.
        /// </summary>
        /// <param name="options">Options for requesting data from the server. If omitted, the window uses the content property that was supplied when the window was created.
        /// Any options specified here are passed to jQuery.ajax().</param>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var windowObject = $("#window").data("kendoWindow");
        /// windowObject.refresh("/feedbackForm");
        /// 
        /// windowObject.refresh({
        ///     url: "/feedbackForm",
        ///     data: { userId: 42 }
        /// });
        /// 
        /// windowObject.refresh({
        ///     url: "/userInfo",
        ///     data: { userId: 42 },
        ///     template: "Hello, #= firstName # #= lastName #"
        /// });
        ///</code>
        ///</example>
        public Window refresh(object options) { return null; }
        /// <summary>
        /// Refreshes the content of a Window from a remote URL.
        /// </summary>
        /// <param name="options">Options for requesting data from the server. If omitted, the window uses the content property that was supplied when the window was created.
        /// Any options specified here are passed to jQuery.ajax().</param>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var windowObject = $("#window").data("kendoWindow");
        /// windowObject.refresh("/feedbackForm");
        /// 
        /// windowObject.refresh({
        ///     url: "/feedbackForm",
        ///     data: { userId: 42 }
        /// });
        /// 
        /// windowObject.refresh({
        ///     url: "/userInfo",
        ///     data: { userId: 42 },
        ///     template: "Hello, #= firstName # #= lastName #"
        /// });
        ///</code>
        ///</example>
        public Window refresh(JsString options) { return null; }

        /// <summary>
        /// Restores a maximized or minimized Window to its previous state. Triggers the resize event.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow").restore();
        ///</code>
        ///</example>
        public Window restore() { return null; }

        /// <summary>
        /// set the title of a Window.
        /// </summary>
        /// <param name="text">_optional, default: _</param>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow").title("Do a barrel roll!");
        ///</code>
        ///</example>
        public void title(JsString text) { }
        /// <summary>
        /// Get the title of a Window.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// var kendoWindow = $("#window").data("kendoWindow");
        /// var windowTitle = kendoWindow.title();
        ///</code>
        ///</example>
        public JsString title() { return null; }
        //TODO: return type?

        /// <summary>
        /// Brings forward a Window to the top of the z-index.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///Brings forward a Window to the top of the z-index.
        ///</code>
        ///</example>
        public Window toFront() { return null; }

        /// <summary>
        /// Toggles a Window between a maximized and restored state. Triggers the resize event.
        /// </summary>
        /// <returns>Returns the (Kendo UI) Window object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var kendoWindow = $("#window").data("kendoWindow").toggleMaximization();
        ///</code>
        ///</example>
        public Window toggleMaximization() { return null; }


        /// <summary>
        /// Triggered when a Window has finished its opening animation.
        /// </summary>
        public event JsAction<EmptyEventData> activate
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"activate\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"activate\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Window is closed (by a user or through the close() method).
        /// </summary>
        public event JsAction<EmptyEventData> closeEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"close\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"close\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Window has finished its closing animation.
        /// </summary>
        public event JsAction<EmptyEventData> deactivate
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"deactivate\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"deactivate\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Window has been moved by a user.
        /// </summary>
        public event JsAction<EmptyEventData> dragend
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"dragend\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"dragend\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when the user starts to move the window.
        /// </summary>
        public event JsAction<EmptyEventData> dragstart
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"dragstart\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"dragstart\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when an AJAX request for content fails.
        /// </summary>
        public event JsAction<EmptyEventData> error
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"error\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"error\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Window is opened (i.e. the open() method is called).
        /// </summary>
        public event JsAction<EmptyEventData> openEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"open\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"open\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when the content of a Window have been refreshed via AJAX.
        /// </summary>
        public event JsAction<EmptyEventData> refreshEvent
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"refresh\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"refresh\"")]
            remove { }
        }

        /// <summary>
        /// Triggered when a Window has been resized by a user.
        /// </summary>
        public event JsAction<EmptyEventData> resize
        {
            [JsMethod(Name = "bind", InsertArg0 = "\"resize\"")]
            add { }
            [JsMethod(Name = "unbind", InsertArg0 = "\"resize\"")]
            remove { }
        }

        //TODO: all events have no eventData (?)
    }

    [JsType(JsMode.Json)]
    public class WindowRefreshOptions
    {
        /// <summary>
        /// The server URL that will be requested.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// A JSON object containing the data that will be passed to the server.
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// The HTTP request method ("GET", "POST").
        /// </summary>
        public JsString type { get; set; }

        /// <summary>
        /// A template to be used for displaying the requested data.
        /// </summary>
        public JsString template { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WindowConfiguration
    {
        /// <summary>
        /// (default: ["Close"]) The buttons for interacting with the window. Predefined array values are "Close", "Refresh", "Minimize", and "Maximize".
        /// </summary>
        public JsArray actions { get; set; }

        /// <summary>
        /// A collection of {Animation} objects, used to change default animations. A value of false will disable all animations in the widget.
        /// </summary>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: document.body) The element that the Window will be appended to.
        /// </summary>
        public object appendTo { get; set; }

        /// <summary>
        /// Specifies a URL or request options that the window should load its content from. For remote URLs, a container iframe element is automatically created.
        /// </summary>
        public WindowContentConfiguration content { get; set; }
        /// <summary>
        /// Specifies a URL or request options that the window should load its content from. For remote URLs, a container iframe element is automatically created.
        /// </summary>
        [JsProperty(Name = "content")]
        public object contentObject { get; set; }
        /// <summary>
        /// Specifies a URL or request options that the window should load its content from. For remote URLs, a container iframe element is automatically created.
        /// </summary>
        [JsProperty(Name = "content")]
        public JsString contentString { get; set; }

        /// <summary>
        /// (default: true) Enables (true) or disables (false) the ability for users to move/drag a Window.
        /// </summary>
        public bool draggable { get; set; }

        /// <summary>
        /// Undocument Property. Add by Lee.
        /// </summary>
        public JsString height { get; set; }

        /// <summary>
        /// Explicitly states whether content iframe should be created.
        /// </summary>
        public bool iframe { get; set; }

        /// <summary>
        /// (default: Infinity) The maximum height (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public JsNumber maxHeight { get; set; }

        /// <summary>
        /// (default: Infinity) The maximum width (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public JsNumber maxWidth { get; set; }

        /// <summary>
        /// (default: 50) The minimum height (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public JsNumber minHeight { get; set; }

        /// <summary>
        /// (default: 50) The minimum width (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public JsNumber minWidth { get; set; }

        /// <summary>
        /// (default: false) Specifies whether the window should show a modal overlay over the page.
        /// </summary>
        public bool modal { get; set; }

        /// <summary>
        /// (default: true) Enables (true) or disables (false) the ability for users to resize a Window.
        /// </summary>
        public bool resizable { get; set; }

        /// <summary>
        /// The text in the window title bar.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// (default: true) Specifies whether the window will be initially visible.
        /// </summary>
        public bool visible { get; set; }
        /// <summary>
        /// Undocument property. Add by Lee.
        /// </summary>
        public JsString width { get; set; }

        ///  /// <summary>
        /// Triggered when a Window is closed (by a user or through the close() method).
        /// </summary>
        public JsAction close { get; set; }
        /// <summary>
        /// Triggered when a Window is opened (i.e. the open() method is called).
        /// </summary>
        public JsAction<Event> open { get; set; }
        /// <summary>
        /// riggered when a Window has finished its opening animation.
        /// </summary>
        public JsAction<Event> activate { get; set; }
        /// <summary>
        /// Triggered when a Window has finished its closing animation.
        /// </summary>
        public JsAction<Event> deactivate { get; set; }
        /// <summary>
        /// Triggered when the content of a Window has finished loading via AJAX, when the window iframe has finished loading, or when the refresh button has been clicked on a window with static content.
        /// </summary>
        public JsAction<Event> refresh { get; set; }
        /// <summary>
        /// Triggered when a Window has been resized by a user.
        /// </summary>
        public JsAction<Event> resize { get; set; }
        /// <summary>
        /// Triggered when a Window has been moved by a user.
        /// </summary>
        public JsAction<Event> dragend { get; set; }
        /// <summary>
        /// Triggered when the user starts to move the window.
        /// </summary>
        public JsAction<Event> dragstart { get; set; }
    }

    [JsType(JsMode.Json)]
    public class WindowContentConfiguration
    {
        /// <summary>
        /// Template for the content of a Window.
        /// </summary>
        public JsString template { get; set; }
    }

    #endregion

    #region Helpers

    public class EmptyEventData
    {
    }

    [JsType(PropertiesAsFields = true)]
    public class SelectEventData
    {
        /// <summary>
        /// The selected item chosen by a user.
        /// </summary>
        public jQuery.jQuery item { get; set; }
    }

    [JsType(PropertiesAsFields = true)]
    public class OneItemEventData
    {
        /// <summary>
        /// The selected  item
        /// </summary>
        public HtmlElement item { get; set; }
    }

    [JsType(PropertiesAsFields = true)]
    public class ChangeEventData
    {
        public ChangeEventSender sender { get; set; }
    }

    [JsType(PropertiesAsFields = true)]
    public class ChangeEventSender
    {
        public jQuery.jQuery element { get; set; }
    }

    #endregion

}

