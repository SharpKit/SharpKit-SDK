using SharpKit.JavaScript;
using SharpKit.Html;
using System;

namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class jQueryUI
    {
        [JsMethod(Name = "bind", ExtensionImplementedInInstance = true)]
        public static void bindUI(this jQuery jquery, JsString eventName, jQueryUIEvent handler) { }
    }
    #region Accordion
    ///<summary>
    ///Make the selected elements Accordion widgets. Semantic requirements:
    ///The markup of your accordion container needs pairs of headers and content panels. By default, the header elements are anchors, assuming the following structure:
    ///<div id="accordion">
    ///    <a href="#">First header</a>
    ///    <div>First content</div>
    ///    <a href="#">Second header</a>
    ///    <div>Second content</div>
    ///</div>If you use a different element for the header, specify the header-option with an appropriate selector, eg. header: 'h3'. The content element must be always next to its header.
    ///If you have links inside the accordion content and use a-elements as headers, add a class to them and use that as the header, eg. header: 'a.header'.
    ///Use activate(Number) to change the active content programmatically.
    ///[edit]NOTE: If you want multiple sections open at once, don't use an accordion
    ///An accordion doesn't allow more than one content panel to be open at the same time, and it takes a lot of effort to do that. If you are looking for a widget that allows more than one content panel to be open, don't use this. Usually it can be written with a few lines of jQuery instead, something like this:
    ///jQuery(document).ready(function(){
    ///	$('.accordion .head').click(function() {
    ///		$(this).next().toggle();
    ///		return false;
    ///	}).next().hide();
    ///});Or animated:
    ///jQuery(document).ready(function(){
    ///	$('.accordion .head').click(function() {
    ///		$(this).next().toggle('slow');
    ///		return false;
    ///	}).next().hide();
    ///});
    ///</summary>
    public static partial class AccordionExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery accordion(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery accordion(this jQuery query, AccordionOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery accordion(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UIAccordion
    {
        /// <summary>
        /// ui.newHeader // jQuery object, activated header
        /// </summary>
        public jQuery newHeader { get; set; }

        /// <summary>
        /// ui.oldHeader // jQuery object, previous header
        /// </summary>
        public jQuery oldHeader { get; set; }

        /// <summary>
        /// ui.newContent // jQuery object, activated content
        /// </summary>
        public jQuery newContent { get; set; }

        /// <summary>
        /// ui.oldContent // jQuery object, previous content
        /// </summary>
        public jQuery oldContent { get; set; }
    }
    #endregion
    #region AccordionOptions
    ///<summary>
    ///Options JSON object for Accordion
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class AccordionOptions
    {

        ///<summary>
        ///Selector for the active element. Set to false to display none at start. Needs collapsible: true.
        ///Default: first child
        ///Types: Selector, Element, jQuery, Boolean, Number
        ///</summary>
        public object active { get; set; }
        ///<summary>
        ///Choose your favorite animation, or disable them (set to false). In addition to the default, 'bounceslide' and all defined easing methods are supported ('bounceslide' requires UI Effects Core).
        ///Default: 'slide'
        ///Types: Boolean, String
        ///</summary>
        public object animated { get; set; }
        ///<summary>
        ///Whether all the sections can be closed at once. Allows collapsing the active section by the triggering event (click is the default).
        ///Default: false
        ///</summary>
        public bool collapsible { get; set; }
        /// <summary>
        /// Disables (true) or enables (false) the droppable. Can be set when initialising (first creating) the droppable.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///The event on which to trigger the accordion.
        ///Default: 'click'
        ///</summary>
        public string @event { get; set; }
        ///<summary>
        ///Selector for the header element.
        ///Default: '> li > :first-child,> :not(li):even'
        ///Types: Selector, jQuery
        ///</summary>
        public object header { get; set; }
        /// <summary>
        /// Default: "auto"
        /// Controls the height of the accordion and each panel. Possible values:
        /// "auto": All panels will be set to the height of the tallest panel.
        /// "fill": Expand to the available height based on the accordion's parent height.
        /// "content": Each panel will be only as tall as its content.
        /// </summary>
        public HeightStyleType heightStyle { get; set; }
        ///<summary>
        ///Icons to use for headers. Icons may be specified for 'header' and 'headerSelected', and we recommend using the icons native to the jQuery UI CSS Framework manipulated by jQuery UI ThemeRoller
        ///Default: { 'header': 'ui-icon-triangle-1-e', 'headerSelected': 'ui-icon-triangle-1-s' }
        ///</summary>
        public IconOptions icons { get; set; }
        ///<summary>
        ///If set, looks for the anchor that matches location.href and activates it. Great for href-based state-saving. Use navigationFilter to implement your own matcher.
        ///Default: false
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public bool navigation { get; set; }
        ///<summary>
        ///If set, the highest content part is used as height reference for all other parts. Provides more consistent animations.
        ///Default: true
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public bool autoHeight { get; set; }
        ///<summary>
        ///If set, clears height and overflow styles after finishing animations. This enables accordions to work with dynamic content. Won't work together with autoHeight.
        ///Default: false
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public bool clearStyle { get; set; }
        ///<summary>
        ///If set, the accordion completely fills the height of the parent element. Overrides autoheight.
        ///Default: false
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public bool fillSpace { get; set; }

        ///<summary>
        ///Triggered after a panel has been activated (after animation completes).
        ///If the accordion was previously collapsed, ui.oldHeader and ui.oldPanel will be empty jQuery objects.
        ///If the accordion is collapsing, ui.newHeader and ui.newPanel will be empty jQuery objects.
        ///</summary>
        public jQueryUIEvent<UIAccordion> activate { get; set; }

        ///<summary>
        ///Triggered directly after a panel is activated. Can be canceled to prevent the panel from activating.
        ///If the accordion is currently collapsed, ui.oldHeader and ui.oldPanel will be empty jQuery objects.
        ///If the accordion is collapsing, ui.newHeader and ui.newPanel will be empty jQuery objects.
        ///</summary>
        public jQueryUIEvent<UIAccordion> beforeActivate { get; set; }

        ///<summary>
        ///This event is triggered when accordion is created.
        ///</summary>
        public jQueryUIEvent<UIAccordion> create { get; set; }

        ///<summary>
        ///This event is triggered every time the accordion changes.
        ///If the accordion is animated, the event will be triggered upon completion of the animation; otherwise, it is triggered immediately.
        ///$('.ui-accordion').bind('accordionchange', function(event, ui) {
        ///   ui.newHeader // jQuery object, activated header
        ///   ui.oldHeader // jQuery object, previous header
        ///   ui.newContent // jQuery object, activated content
        ///   ui.oldContent // jQuery object, previous content
        /// });
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UIAccordion> change { get; set; }

        ///<summary>
        ///This event is triggered every time the accordion starts to change.
        /// $('.ui-accordion').bind('accordionchangestart', function(event, ui) {
        ///   ui.newHeader // jQuery object, activated header
        ///   ui.oldHeader // jQuery object, previous header
        ///   ui.newContent // jQuery object, activated content
        ///   ui.oldContent // jQuery object, previous content
        /// });
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UIAccordion> changestart { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum HeightStyleType
    {
        /// <summary>
        /// All panels will be set to the height of the tallest panel.
        /// </summary>
        auto,
        /// <summary>
        /// Expand to the available height based on the accordion's parent height.
        /// </summary>
        fill,
        /// <summary>
        /// Each panel will be only as tall as its content.
        /// </summary>
        content,
    }


    [JsType(JsMode.Json)]
    public class IconOptions
    {
        public JsString secondary { get; set; }
        public JsString primary { get; set; }
        public JsString header { get; set; }
        public JsString headerSelected { get; set; }
    }
    #endregion
    #region Autocomplete
    ///<summary>
    ///Make the selected elements Autocomplete widgets. Semantic requirements:
    ///The markup of your autocomplete container needs pairs of headers and content panels. By default, the header elements are anchors, assuming the following structure:
    ///<div id="autocomplete">
    ///    <a href="#">First header</a>
    ///    <div>First content</div>
    ///    <a href="#">Second header</a>
    ///    <div>Second content</div>
    ///</div>If you use a different element for the header, specify the header-option with an appropriate selector, eg. header: 'h3'. The content element must be always next to its header.
    ///If you have links inside the autocomplete content and use a-elements as headers, add a class to them and use that as the header, eg. header: 'a.header'.
    ///Use activate(Number) to change the active content programmatically.
    ///[edit]NOTE: If you want multiple sections open at once, don't use an autocomplete
    ///An autocomplete doesn't allow more than one content panel to be open at the same time, and it takes a lot of effort to do that. If you are looking for a widget that allows more than one content panel to be open, don't use this. Usually it can be written with a few lines of jQuery instead, something like this:
    ///jQuery(document).ready(function(){
    ///	$('.autocomplete .head').click(function() {
    ///		$(this).next().toggle();
    ///		return false;
    ///	}).next().hide();
    ///});Or animated:
    ///jQuery(document).ready(function(){
    ///	$('.autocomplete .head').click(function() {
    ///		$(this).next().toggle('slow');
    ///		return false;
    ///	}).next().hide();
    ///});
    ///</summary>
    public static partial class AutocompleteExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery autocomplete(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery autocomplete(this jQuery query, AutocompleteOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery autocomplete(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery autocomplete(this jQuery query, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region AutocompleteOptions
    ///<summary>
    ///Options JSON object for Autocomplete
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class AutocompleteOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the droppable. Can be set when initialising (first creating) the droppable.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        /// <summary>
        /// Which element the menu should be appended to.
        /// </summary>
        public JsString appendTo { get; set; }
        /// <summary>
        /// If set to true the first item will be automatically focused.
        /// Default:false
        /// </summary>
        public bool autoFocus { get; set; }
        /// <summary>
        /// The delay in milliseconds the Autocomplete waits after a keystroke to activate itself.
        /// A zero-delay makes sense for local data (more responsive), but can produce a lot of load for remote data, while being less responsive.
        /// Default:300
        /// </summary>
        public JsNumber delay { get; set; }
        /// <summary>
        /// The minimum number of characters a user has to type before the Autocomplete activates. Zero is useful for local data with just a few items.
        /// Should be increased when there are a lot of items, where a single character would match a few thousand items.
        /// Default:1
        /// </summary>
        public JsNumber minLength { get; set; }
        /// <summary>
        /// Identifies the position of the Autocomplete widget in relation to the associated input element. The "of" option defaults to the input element, but you can specify another element to position against.
        /// You can refer to the jQuery UI Position utility for more details about the various options.
        /// Default:{ my: "left top", at: "left bottom", collision: "none" }
        /// </summary>
        public object position { get; set; }
        /// <summary>
        /// Defines the data to use, must be specified. See Overview section for more details, and look at the various demos.
        /// Default:none, must be specified
        /// </summary>
        public object source { get; set; }

        /// <summary>
        /// Defines the data to use, must be specified. See Overview section for more details, and look at the various demos.
        /// Default:none, must be specified
        /// </summary>
        [JsProperty(Name = "source")]
        public JsArray<AutocompleteItem> sourceItems { get; set; }


        /// <summary>
        /// This event is triggered when autocomplete is created.
        /// </summary>
        public jQueryUIEvent create { get; set; }

        /// <summary>
        /// Before a request (source-option) is started, after minLength and delay are met. Can be canceled (return false), then no request will be started and no items suggested.
        ///</summary>
        public jQueryUIEvent searchEvent { get; set; }
        //TODO: event name without the"event"

        /// <summary>
        /// Triggered when the suggestion menu is opened.
        /// </summary>
        public jQueryUIEvent open { get; set; }

        /// <summary>
        /// Before focus is moved to an item (not selecting), ui.item refers to the focused item. The default action of focus is to replace the text field's value with the value of the focused item, though only if the focus event was triggered by a keyboard interaction.
        /// Canceling this event prevents the value from being updated, but does not prevent the menu item from being focused.
        /// </summary>
        public jQueryUIEvent focus { get; set; }

        /// <summary>
        /// Triggered when an item is selected from the menu; ui.item refers to the selected item. The default action of select is to replace the text field's value with the value of the selected item.
        ///Canceling this event prevents the value from being updated, but does not prevent the menu from closing.
        /// </summary>
        public jQueryUIEvent select { get; set; }

        /// <summary>
        /// When the list is hidden - doesn't have to occur together with a change.
        /// </summary>
        public jQueryUIEvent closeEvent { get; set; }
        //TODO: event name without the"event"

        /// <summary>
        /// Triggered when the field is blurred, if the value has changed; ui.item refers to the selected item.
        /// </summary>
        public jQueryUIEvent change { get; set; }


    }
    [JsType(JsMode.Json)]
    public class AutocompleteItem
    {
        public JsString value { get; set; }
        public JsString label { get; set; }
        public JsString desc { get; set; }
        public JsString icon { get; set; }
    }
    #endregion
    #region AddClass
    ///<summary>
    ///[edit]addClass( class, [duration] )
    ///Adds the specified class to each of the set of matched elements with an optional transition between the states.
    ///</summary>
    public static partial class AddClassExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery addClass(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery addClass(this jQuery query, AddClassOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery addClass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }

        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery addClass(this jQuery query, string className, JsNumber duration, JsAction callback) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery addClass(this jQuery query, string className, JsNumber duration) { return default(jQuery); }
    }
    #endregion
    #region AddClassOptions
    ///<summary>
    ///Options JSON object for AddClass
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class AddClassOptions
    {
        ///<summary>
        ///One CSS class to add to the elements.
        ///Default: null
        ///</summary>
        public string @class { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object duration { get; set; }
    }
    #endregion
    #region Button
    public static partial class ButtonExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery button(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery button(this jQuery query, ButtonOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery button(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery buttonset(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery buttonset(this jQuery query, ButtonOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery buttonset(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region ButtonOptions
    ///<summary>
    ///Options JSON object for Button
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class ButtonOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        /// <summary>
        /// Whether to show any text - when set to false (display no text), icons (see icons option) must be enabled, otherwise it'll be ignored.
        /// Default:true
        /// </summary>
        public bool text { get; set; }
        /// <summary>
        /// Icons to display, with or without text (see text option). The primary icon is displayed by default on the left of the label text, the secondary by default is on the right. Value for the primary and secondary properties must be a classname (String), eg. "ui-icon-gear".
        /// For using only one icon: icons: {primary:'ui-icon-locked'}. For using two icons: icons: {primary:'ui-icon-gear',secondary:'ui-icon-triangle-1-s'}
        /// Default:{ primary: null, secondary: null }
        /// </summary>
        public IconOptions icons { get; set; }
        /// <summary>
        /// Text to show on the button. When not specified (null), the element's html content is used, or its value attribute when it's an
        /// input element of type submit or reset; or the html content of the associated label element if its an input of type radio or checkbox
        /// Default:HTML content of the button, or value attribute
        /// </summary>
        public JsString label { get; set; }

        ///<summary>
        ///This event is triggered when button is created.
        ///</summary>
        public jQueryUIEvent<UIDraggable> create { get; set; }
        //TODO: no UIButton
    }
    #endregion
    #region Datepicker
    ///<summary>
    ///The jQuery UI Datepicker is a highly configurable plugin that adds datepicker functionality to your pages. You can customize the date format and language, restrict the selectable date ranges and add in buttons and other navigation options easily.
    ///By default, the datepicker calendar opens in a small overlay onFocus and closes automatically onBlur or when a date if selected. For an inline calendar, simply attach the datepicker to a div or span. 
    ///You can use keyboard shortcuts to drive the datepicker: 
    ///page up/down - previous/next month
    ///ctrl+page up/down - previous/next year
    ///ctrl+home - current month or open when closed
    ///ctrl+left/right - previous/next day
    ///ctrl+up/down - previous/next week
    ///enter - accept the selected date
    ///ctrl+end - close and erase the date
    ///escape - close the datepicker without selection
    ///[edit]Utility functions
    ///$.datepicker.setDefaults( settings ) - Set settings for all datepicker instances.
    ///$.datepicker.formatDate( format, date, settings ) - Format a date into a string value with a specified format.
    ///$.datepicker.iso8601Week( date ) - Determine the week of the year for a given date: 1 to 53.
    ///$.datepicker.parseDate( format, value, settings ) - Extract a date from a string value with a specified format.
    ///</summary>
    public static partial class DatepickerExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery datepicker(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery datepicker(this jQuery query, DatepickerOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery datepicker(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region DatepickerOptions
    ///<summary>
    ///Options JSON object for Datepicker
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class DatepickerOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }

        ///<summary>
        ///The jQuery selector for another field that is to be updated with the selected date from the datepicker. Use the altFormat setting below to change the format of the date within this field. Leave as blank for no alternate field.
        ///Default: ''
        ///</summary>
        public string altField { get; set; }
        ///<summary>
        ///The dateFormat to be used for the altField option. This allows one date format to be shown to the user for selection purposes, while a different format is actually sent behind the scenes. For a full list of the possible formats see the formatDate function
        ///Default: ''
        ///</summary>
        public string altFormat { get; set; }
        ///<summary>
        ///The text to display after each date field, e.g. to show the required format.
        ///Default: ''
        ///</summary>
        public string appendText { get; set; }
        ///<summary>
        ///The URL for the popup button image. If set, button text becomes the alt value and is not directly displayed.
        ///Default: ''
        ///</summary>
        public string buttonImage { get; set; }
        ///<summary>
        ///Set to true to place an image after the field to use as the trigger without it appearing on a button.
        ///Default: false
        ///</summary>
        public bool buttonImageOnly { get; set; }
        ///<summary>
        ///The text to display on the trigger button. Use in conjunction with showOn equal to 'button' or 'both'.
        ///Default: '...'
        ///</summary>
        public string buttonText { get; set; }
        ///<summary>
        ///Allows you to change the month by selecting from a drop-down list. You can enable this feature by setting the attribute to true.
        ///Default: false
        ///</summary>
        public bool changeMonth { get; set; }
        ///<summary>
        ///Allows you to change the year by selecting from a drop-down list. You can enable this feature by setting the attribute to true.
        ///Default: false
        ///</summary>
        public bool changeYear { get; set; }
        ///<summary>
        ///The text to display for the close link. This attribute is one of the regionalisation attributes. Use the showButtonPanel to display this button.
        ///Default: 'Done'
        ///</summary>
        public string closeText { get; set; }
        ///<summary>
        ///True if the input field is constrained to the current date format.
        ///Default: true
        ///</summary>
        public bool constrainInput { get; set; }
        ///<summary>
        ///The text to display for the current day link. This attribute is one of the regionalisation attributes. Use the showButtonPanel to display this button.
        ///Default: 'Today'
        ///</summary>
        public string currentText { get; set; }
        ///<summary>
        ///The format for parsed and displayed dates. This attribute is one of the regionalisation attributes. For a full list of the possible formats see the formatDate function.
        ///Default: 'mm/dd/yy'
        ///</summary>
        public string dateFormat { get; set; }
        ///<summary>
        ///The list of long day names, starting from Sunday, for use as requested via the dateFormat setting. They also appear as popup hints when hovering over the corresponding column headings. This attribute is one of the regionalisation attributes.
        ///Default: ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday']
        ///</summary>
        public JsArray dayNames { get; set; }
        ///<summary>
        ///The list of minimised day names, starting from Sunday, for use as column headers within the datepicker. This attribute is one of the regionalisation attributes.
        ///Default: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa']
        ///</summary>
        public JsArray dayNamesMin { get; set; }
        ///<summary>
        ///The list of abbreviated day names, starting from Sunday, for use as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
        ///Default: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
        ///</summary>
        public JsArray dayNamesShort { get; set; }
        ///<summary>
        ///Set the date to highlight on first opening if the field is blank. Specify either an actual date via a Date object, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
        ///Default: null
        ///Types: Date, Number, String
        ///</summary>
        public object defaultDate { get; set; }
        ///<summary>
        ///Control the speed at which the datepicker appears, it may be a time in milliseconds, a string representing one of the three predefined speeds ("slow", "normal", "fast"), or '' for immediately.
        ///Default: 'normal'
        ///Types: String, Number
        ///</summary>
        public object duration { get; set; }
        ///<summary>
        ///Set the first day of the week: Sunday is 0, Monday is 1, ... This attribute is one of the regionalisation attributes.
        ///Default: 0
        ///</summary>
        public int firstDay { get; set; }
        ///<summary>
        ///If true, the current day link moves to the currently selected date instead of today.
        ///Default: false
        ///</summary>
        public bool gotoCurrent { get; set; }
        ///<summary>
        ///Normally the previous and next links are disabled when not applicable (see minDate/maxDate). You can hide them altogether by setting this attribute to true.
        ///Default: false
        ///</summary>
        public bool hideIfNoPrevNext { get; set; }
        ///<summary>
        ///True if the current language is drawn from right to left. This attribute is one of the regionalisation attributes.
        ///Default: false
        ///</summary>
        public bool isRTL { get; set; }
        ///<summary>
        ///Set a maximum selectable date via a Date object, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +1w'), or null for no limit.
        ///Default: null
        ///Types: Date, Number, String
        ///</summary>
        public object maxDate { get; set; }
        ///<summary>
        ///Set a minimum selectable date via a Date object, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '-1y -1m'), or null for no limit.
        ///Default: null
        ///Types: Date, Number, String
        ///</summary>
        public object minDate { get; set; }
        ///<summary>
        ///The list of full month names, as used in the month header on each datepicker and as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
        ///Default: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']
        ///</summary>
        public JsArray monthNames { get; set; }
        ///<summary>
        ///The list of abbreviated month names, for use as requested via the dateFormat setting. This attribute is one of the regionalisation attributes.
        ///Default: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
        ///</summary>
        public JsArray monthNamesShort { get; set; }
        ///<summary>
        ///When true the formatDate function is applied to the prevText, nextText, and currentText values before display, allowing them to display the target month names for example.
        ///Default: false
        ///</summary>
        public bool navigationAsDateFormat { get; set; }
        ///<summary>
        ///The text to display for the next month link. This attribute is one of the regionalisation attributes. With the standard ThemeRoller styling, this value is replaced by an icon.
        ///Default: 'Next'
        ///</summary>
        public string nextText { get; set; }
        ///<summary>
        ///Set how many months to show at once. The value can be a straight integer, or can be a two-element array to define the number of rows and columns to display.
        ///Default: 1
        ///Types: Number, Array
        ///</summary>
        public object numberOfMonths { get; set; }
        ///<summary>
        ///The text to display for the previous month link. This attribute is one of the regionalisation attributes. With the standard ThemeRoller styling, this value is replaced by an icon.
        ///Default: 'Prev'
        ///</summary>
        public string prevText { get; set; }
        ///<summary>
        ///Set the cutoff year for determining the century for a date (used in conjunction with dateFormat 'y'). If a numeric value (0-99) is provided then this value is used directly. If a string value is provided then it is converted to a number and added to the current year. Once the cutoff year is calculated, any dates entered with a year value less than or equal to it are considered to be in the current century, while those greater than it are deemed to be in the previous century.
        ///Default: '+10'
        ///Types: String, Number
        ///</summary>
        public object shortYearCutoff { get; set; }
        ///<summary>
        ///Set the name of the animation used to show/hide the datepicker. Use 'show' (the default), 'slideDown', 'fadeIn', or any of the show/hide jQuery UI effects.
        ///Default: 'show'
        ///</summary>
        public string showAnim { get; set; }
        ///<summary>
        ///Whether to show the button panel.
        ///Default: false
        ///</summary>
        public bool showButtonPanel { get; set; }
        ///<summary>
        ///Specify where in a multi-month display the current month shows, starting from 0 at the top/left.
        ///Default: 0
        ///</summary>
        public int showCurrentAtPos { get; set; }
        ///<summary>
        ///Whether to show the month after the year in the header.
        ///Default: false
        ///</summary>
        public bool showMonthAfterYear { get; set; }
        ///<summary>
        ///Have the datepicker appear automatically when the field receives focus ('focus'), appear only when a button is clicked ('button'), or appear when either event takes place ('both').
        ///Default: 'focus'
        ///</summary>
        public string showOn { get; set; }
        ///<summary>
        ///If using one of the jQuery UI effects for showAnim, you can provide additional settings for that animation via this option.
        ///Default: {}
        ///</summary>
        public JsObject showOptions { get; set; }
        ///<summary>
        ///Display dates in other months (non-selectable) at the start or end of the current month.
        ///Default: false
        ///</summary>
        public bool showOtherMonths { get; set; }
        /// <summary>
        /// When true a column is added to show the week of the year. The calculateWeek option determines how the week of the year is calculated. You may also want to change the firstDay option.
        ///Default: false
        /// </summary>
        public bool showWeek { get; set; }
        ///<summary>
        ///Set how many months to move when clicking the Previous/Next links.
        ///Default: 1
        ///</summary>
        public int stepMonths { get; set; }
        ///<summary>
        ///Control the range of years displayed in the year drop-down: either relative to current year (-nn:+nn) or absolute (nnnn:nnnn).
        ///Default: '-10:+10'
        ///</summary>
        public string yearRange { get; set; }

        ///<summary>
        ///Can be a function that takes an input field and current datepicker instance and returns an options object to update the datepicker with. It is called just before the datepicker is displayed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent beforeShow { get; set; }
        ///<summary>
        ///The function takes a date as a parameter and must return an array with [0] equal to true/false indicating whether or not this date is selectable, [1] equal to a CSS class name(s) or '' for the default presentation and [2] an optional popup tooltip for this date. It is called for each day in the datepicker before is it displayed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent beforeShowDay { get; set; }
        ///<summary>
        ///Allows you to define your own event when the datepicker moves to a new month and/or year. The function receives the selected year, month (1-12), and the datepicker instance as parameters. this refers to the associated input field.
        ///Default: null
        ///Types: function(year, month, inst)
        ///</summary>
        public jQueryUIEvent onChangeMonthYear { get; set; }
        ///<summary>
        ///Allows you to define your own event when the datepicker is closed, whether or not a date is selected. The function receives the selected date as text and the datepicker instance as parameters. this refers to the associated input field.
        ///Default: null
        ///Types: function(dateText, inst)
        ///</summary>
        public jQueryUIEvent onClose { get; set; }
        ///<summary>
        ///Allows you to define your own event when the datepicker is selected. The function receives the selected date as text and the datepicker instance as parameters. this refers to the associated input field.
        ///Default: null
        ///Types: function(dateText, inst)
        ///</summary>
        public JsAction<JsString, object> onSelect { get; set; }
    }
    #endregion
    #region Dialog
    ///<summary>
    ///A dialog is a floating window that contains a title bar and a content area. The dialog window can be moved, resized and closed with the 'x' icon by default. 
    ///If the content length exceeds the maximum height, a scrollbar will automatically appear. 
    ///A bottom button bar and semi-transparent modal overlay layer are common options that can be added. 
    ///A call to $(foo).dialog() initializes a dialog. If you want a click to open a dialog, use $(foo).dialog('open'), but if the dialog hasn't been destroyed, the $(foo).dialog() init call is only required once, not on each click. 
    ///</summary>
    public static partial class DialogExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery dialog(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery dialog(this jQuery query, DialogOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery dialog(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class DialogButton
    {
        public JsString text { get; set; }
        public JsAction click { get; set; }
    }
    #endregion
    #region DialogOptions
    ///<summary>
    ///Options JSON object for Dialog
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class DialogOptions
    {
        /// <summary>
        /// Which element the dialog (and overlay, if modal) should be appended to.
        /// Default:"body"
        /// </summary>
        public object appendTo { get; set; }
        /// <summary>
        /// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///When autoOpen is true the dialog will open automatically when dialog is called. If false it will stay hidden until .dialog("open") is called on it.
        ///Default: true
        ///</summary>
        public bool autoOpen { get; set; }
        ///<summary>
        ///When true, the bgiframe plugin will be used, to fix the issue in IE6 where select boxes show on top of other elements, regardless of zIndex. Requires including the bgiframe plugin. Future versions may not require a separate plugin.
        ///Default: false
        ///</summary>
        public bool bgiframe { get; set; }
        ///<summary>
        ///Specifies which buttons should be displayed on the dialog. The property key is the text of the button. The value is the callback function for when the button is clicked. The context of the callback is the dialog element; if you need access to the button, it is available as the target of the event object. 
        ///Default: { }
        ///</summary>
        public JsArray<DialogButton> buttons { get; set; }
        ///<summary>
        ///Specifies which buttons should be displayed on the dialog. The property key is the text of the button. The value is the callback function for when the button is clicked. The context of the callback is the dialog element; if you need access to the button, it is available as the target of the event object. 
        ///Default: { }
        ///</summary>
        [JsProperty(Name = "buttons")]
        public JsObject<JsAction> buttonsClicks { get; set; }
        ///<summary>
        ///Specifies whether the dialog should close when it has focus and the user presses the esacpe (ESC) key.
        ///Default: true
        ///</summary>
        public bool closeOnEscape { get; set; }
        ///<summary>
        ///The specified class name(s) will be added to the dialog, for additional theming.
        ///Default: ''
        ///</summary>
        public string dialogClass { get; set; }
        ///<summary>
        ///If set to true, the dialog will be draggable will be draggable by the titlebar.
        ///Default: true
        ///</summary>
        public bool draggable { get; set; }
        ///<summary>
        ///The height of the dialog, in pixels.
        ///Default: 'auto'
        ///</summary>
        public int height { get; set; }
        ///<summary>
        ///The effect to be used when the dialog is closed.
        ///Default: null
        ///</summary>
        public string hide { get; set; }
        ///<summary>
        ///The maximum height to which the dialog can be resized, in pixels.
        ///Default: false
        ///</summary>
        public int maxHeight { get; set; }
        ///<summary>
        ///The maximum width to which the dialog can be resized, in pixels.
        ///Default: false
        ///</summary>
        public int maxWidth { get; set; }
        ///<summary>
        ///The minimum height to which the dialog can be resized, in pixels.
        ///Default: 150
        ///</summary>
        public int minHeight { get; set; }
        ///<summary>
        ///The minimum width to which the dialog can be resized, in pixels.
        ///Default: 150
        ///</summary>
        public int minWidth { get; set; }
        ///<summary>
        ///If set to true, the dialog will have modal behavior; other items on the page will be disabled (i.e. cannot be interacted with). Modal dialogs create an overlay below the dialog but above other page elements.
        ///Default: false
        ///</summary>
        public bool modal { get; set; }
        ///<summary>
        ///Specifies where the dialog should be displayed. Possible values: 'center', 'left', 'right', 'top', 'bottom', or an array containing a coordinate pair (in pixel offset from top left of viewport) or the possible string values (e.g. ['right','top'] for top right corner).
        ///Default: 'center'
        ///Types: String, Array
        ///</summary>
        public object position { get; set; }
        ///<summary>
        ///If set to true, the dialog will be resizeable.
        ///Default: true
        ///</summary>
        public bool resizable { get; set; }
        ///<summary>
        ///The effect to be used when the dialog is opened.
        ///Default: null
        ///</summary>
        public string show { get; set; }
        ///<summary>
        ///Specifies whether the dialog will stack on top of other dialogs. This will cause the dialog to move to the front of other dialogs when it gains focus.
        ///Default: true
        ///</summary>
        public bool stack { get; set; }
        ///<summary>
        ///Specifies the title of the dialog. The title can also be specified by the title attribute on the dialog source element.
        ///Default: ''
        ///</summary>
        public string title { get; set; }
        ///<summary>
        ///The width of the dialog, in pixels.
        ///Default: 300
        ///</summary>
        public int width { get; set; }
        ///<summary>
        ///The starting z-index for the dialog.
        ///Default: 1000
        ///</summary>
        public int zIndex { get; set; }
        ///<summary>
        ///This event is triggered when dialog is created.
        ///</summary>
        public jQueryUIEvent create { get; set; }

        ///<summary>
        ///This event is triggered when a dialog attempts to close. If the beforeclose event handler (callback function) returns false, the close will be prevented.
        ///Default: null
        ///</summary>
        public jQueryUIEvent beforeclose { get; set; }

        ///<summary>
        ///This event is triggered when dialog is opened.
        ///Default: null
        ///</summary>
        public jQueryUIEvent open { get; set; }

        ///<summary>
        ///This event is triggered when the dialog gains focus.
        ///Default: null
        ///</summary>
        public jQueryUIEvent focus { get; set; }

        ///<summary>
        ///This event is triggered at the beginning of the dialog being dragged.
        ///Default: null
        ///</summary>
        public jQueryUIEvent dragStart { get; set; }

        ///<summary>
        ///This event is triggered when the dialog is dragged.
        ///Default: null
        ///</summary>
        public jQueryUIEvent drag { get; set; }

        ///<summary>
        ///This event is triggered after the dialog has been dragged.
        ///Default: null
        ///</summary>
        public jQueryUIEvent dragStop { get; set; }

        ///<summary>
        ///This event is triggered at the beginning of the dialog being resized.
        ///Default: null
        ///</summary>
        public jQueryUIEvent resizeStart { get; set; }

        ///<summary>
        ///This event is triggered when the dialog is resized.
        ///Default: null
        ///</summary>
        public jQueryUIEvent resize { get; set; }

        ///<summary>
        ///This event is triggered after the dialog has been resized.
        ///Default: null
        ///</summary>
        public jQueryUIEvent resizeStop { get; set; }

        ///<summary>
        ///This event is triggered when the dialog is closed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent close { get; set; }
    }
    #endregion
    #region Draggable
    ///<summary>
    ///The jQuery UI Draggable plugin makes selected elements draggable by mouse.
    ///Draggable elements gets a class of ui-draggable. During drag the element also gets a class of ui-draggable-dragging. If you want not just drag, but drag-and-drop, see the jQuery UI Droppable plugin, which provides a drop target for draggables.
    ///All callbacks (start, stop, drag) receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
    ///ui.helper - the jQuery object representing the helper that's being dragged
    ///ui.position - current position of the helper as { top, left } object, relative to the offset element
    ///ui.offset - current absolute position of the helper as { top, left } object, relative to page
    ///</summary>
    public static partial class DraggableExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery draggable(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery draggable(this jQuery query, DraggableOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery draggable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UIDraggable
    {
        /// <summary>
        /// ui.helper - the jQuery object representing the helper that's being dragged
        /// </summary>
        public jQuery helper { get; set; }

        /// <summary>
        /// ui.position - current position of the helper as { top, left } object, relative to the offset element
        /// </summary>
        public TopLeft position { get; set; }

        /// <summary>
        /// ui.offset - current absolute position of the helper as { top, left } object, relative to page
        /// </summary>
        public TopLeft offset { get; set; }
    }

    #endregion
    #region DraggableOptions
    ///<summary>
    ///Options JSON object for Draggable
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class DraggableOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the draggable. Can be set when initialising (first creating) the draggable.
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///If set to false, will prevent the ui-draggable class from being added. This may be desired as a performance optimization when calling .draggable() init on many hundreds of elements.
        ///Default: true
        ///</summary>
        public bool addClasses { get; set; }
        ///<summary>
        ///The element passed to or selected by the appendTo option will be used as the draggable helper's container during dragging. By default, the helper is appended to the same container as the draggable.
        ///Default: 'parent'
        ///Types: Element, Selector
        ///</summary>
        public object appendTo { get; set; }
        ///<summary>
        ///Constrains dragging to either the horizontal (x) or vertical (y) axis. Possible values: 'x', 'y'.
        ///Default: false
        ///</summary>
        public string axis { get; set; }
        ///<summary>
        ///Prevents dragging from starting on specified elements.
        ///Default: ':input,option'
        ///</summary>
        public string cancel { get; set; }
        ///<summary>
        ///Allows the draggable to be dropped onto the specified sortables. If this option is used (helper must be set to 'clone' in order to work flawlessly), a draggable can be dropped onto a sortable list and then becomes part of it. 
        ///Note: Specifying this option as an array of selectors has been removed.
        ///Default: false
        ///</summary>
        public string connectToSortable { get; set; }
        ///<summary>
        ///Constrains dragging to within the bounds of the specified element or region. Possible string values: 'parent', 'document', 'window', [x1, y1, x2, y2].
        ///Default: false
        ///Types: Selector, Element, String, Array
        ///</summary>
        public object containment { get; set; }
        ///<summary>
        ///The css cursor during the drag operation.
        ///Default: 'auto'
        ///</summary>
        public string cursor { get; set; }
        ///<summary>
        ///Moves the dragging helper so the cursor always appears to drag from the same position. Coordinates can be given as a hash using a combination of one or two keys: { top, left, right, bottom }.
        ///Default: false
        ///</summary>
        public object cursorAt { get; set; }
        ///<summary>
        ///Time in milliseconds after mousedown until dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
        ///Default: 0
        ///</summary>
        public int delay { get; set; }
        ///<summary>
        ///Distance in pixels after mousedown the mouse must move before dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
        ///Default: 1
        ///</summary>
        public int distance { get; set; }
        ///<summary>
        ///Snaps the dragging helper to a grid, every x and y pixels. Array values: [x, y]
        ///Default: false
        ///</summary>
        public JsArray grid { get; set; }
        ///<summary>
        ///If specified, restricts drag start click to the specified element(s).
        ///Default: false
        ///Types: Element, Selector
        ///</summary>
        public object handle { get; set; }
        ///<summary>
        ///Allows for a helper element to be used for dragging display. Possible values: 'original', 'clone', Function. If a function is specified, it must return a DOMElement.
        ///Default: 'original'
        ///Types: String, Function
        ///</summary>
        public object helper { get; set; }
        ///<summary>
        ///Prevent iframes from capturing the mousemove events during a drag. Useful in combination with cursorAt, or in any case, if the mouse cursor is not over the helper. If set to true, transparent overlays will be placed over all iframes on the page. If a selector is supplied, the matched iframes will have an overlay placed over them.
        ///Default: false
        ///Types: Boolean, Selector
        ///</summary>
        public object iframeFix { get; set; }
        ///<summary>
        ///Opacity for the helper while being dragged.
        ///Default: false
        ///</summary>
        public float opacity { get; set; }
        ///<summary>
        ///If set to true, all droppable positions are calculated on every mousemove. Caution: This solves issues on highly dynamic pages, but dramatically decreases performance.
        ///Default: false
        ///</summary>
        public bool refreshPositions { get; set; }
        ///<summary>
        ///If set to true, the element will return to its start position when dragging stops. Possible string values: 'valid', 'invalid'. If set to invalid, revert will only occur if the draggable has not been dropped on a droppable. For valid, it's the other way around.
        ///Default: false
        ///Types: Boolean, String
        ///</summary>
        public object revert { get; set; }
        ///<summary>
        ///The duration of the revert animation, in milliseconds. Ignored if revert is false.
        ///Default: 500
        ///</summary>
        public int revertDuration { get; set; }
        ///<summary>
        ///Used to group sets of draggable and droppable items, in addition to droppable's accept option. A draggable with the same scope value as a droppable will be accepted by the droppable.
        ///Default: 'default'
        ///</summary>
        public string scope { get; set; }
        ///<summary>
        ///If set to true, container auto-scrolls while dragging.
        ///Default: true
        ///</summary>
        public bool scroll { get; set; }
        ///<summary>
        ///Distance in pixels from the edge of the viewport after which the viewport should scroll. Distance is relative to pointer, not the draggable.
        ///Default: 20
        ///</summary>
        public int scrollSensitivity { get; set; }
        ///<summary>
        ///The speed at which the window should scroll once the mouse pointer gets within the scrollSensitivity distance.
        ///Default: 20
        ///</summary>
        public int scrollSpeed { get; set; }
        ///<summary>
        ///If set to a selector or to true (equivalent to '.ui-draggable'), the draggable will snap to the edges of the selected elements when near an edge of the element.
        ///Default: false
        ///Types: Boolean, Selector
        ///</summary>
        public object snap { get; set; }
        ///<summary>
        ///Determines which edges of snap elements the draggable will snap to. Ignored if snap is false. Possible values: 'inner', 'outer', 'both'
        ///Default: 'both'
        ///</summary>
        public string snapMode { get; set; }
        ///<summary>
        ///The distance in pixels from the snap element edges at which snapping should occur. Ignored if snap is false.
        ///Default: 20
        ///</summary>
        public int snapTolerance { get; set; }
        ///<summary>
        ///Controls the z-Index of the defined group (key 'group' in the hash, accepts jQuery selector) automatically, always brings to front the dragged item. Very useful in things like window managers. Optionally, a 'min' key can be set, so the zIndex cannot go below that value.
        ///Default: false
        ///</summary>
        public object stack { get; set; }
        ///<summary>
        ///z-index for the helper while being dragged.
        ///Default: false
        ///</summary>
        public int zIndex { get; set; }
        [JsProperty(Name = "drag")]
        public JsAction dragAction { get; set; }
        ///<summary>
        ///This event is triggered when draggable is created.
        ///</summary>
        public jQueryUIEvent<UIDraggable> create { get; set; }

        ///<summary>
        ///This event is triggered when dragging starts.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UIDraggable> start { get; set; }

        ///<summary>
        ///This event is triggered when the mouse is moved during the dragging.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UIDraggable> drag { get; set; }

        ///<summary>
        ///This event is triggered when dragging stops.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UIDraggable> stop { get; set; }

    }
    #endregion
    #region Droppable
    ///<summary>
    ///The jQuery UI Droppable plugin makes selected elements droppable (meaning they accept being dropped on by draggables). You can specify which (individually) or which kind of draggables each will accept.
    ///All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
    ///ui.draggable - current draggable element, a jQuery object.
    ///ui.helper - current draggable helper, a jQuery object
    ///ui.position - current position of the draggable helper { top: , left: }
    ///ui.offset - current absolute position of the draggable helper { top: , left: }
    ///</summary>
    public static partial class DroppableExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery droppable(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery droppable(this jQuery query, DroppableOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery droppable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UIDroppable
    {
        /// <summary>
        /// ui.draggable - current draggable element, a jQuery object
        /// </summary>
        public jQuery draggable { get; set; }

        /// <summary>
        /// ui.helper - the jQuery object containing the helper element
        /// </summary>
        public jQuery helper { get; set; }

        /// <summary>
        /// ui.position - current position of the helper as { top, left } object, relative to the offset element
        /// </summary>
        public TopLeft position { get; set; }

        /// <summary>
        /// ui.offset - current absolute position of the helper as { top, left } object, relative to page
        /// </summary>
        public TopLeft offset { get; set; }
    }
    #endregion
    #region DroppableOptions
    ///<summary>
    ///Options JSON object for Droppable
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class DroppableOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the droppable. Can be set when initialising (first creating) the droppable.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///All draggables that match the selector will be accepted. If a function is specified, the function will be called for each draggable on the page (passed as the first argument to the function), to provide a custom filter. The function should return true if the draggable should be accepted.
        ///Default: '*'
        ///Types: Selector, Function
        ///</summary>
        public object accept { get; set; }
        ///<summary>
        ///If specified, the class will be added to the droppable while an acceptable draggable is being dragged.
        ///Default: false
        ///</summary>
        public string activeClass { get; set; }
        ///<summary>
        ///If set to false, will prevent the ui-droppable class from being added. This may be desired as a performance optimization when calling .droppable() init on many hundreds of elements.
        ///Default: true
        ///</summary>
        public bool addClasses { get; set; }
        ///<summary>
        ///If true, will prevent event propagation on nested droppables.
        ///Default: false
        ///</summary>
        public bool greedy { get; set; }
        ///<summary>
        ///If specified, the class will be added to the droppable while an acceptable draggable is being hovered.
        ///Default: false
        ///</summary>
        public string hoverClass { get; set; }
        ///<summary>
        ///Used to group sets of draggable and droppable items, in addition to droppable's accept option. A draggable with the same scope value as a droppable will be accepted.
        ///Default: 'default'
        ///</summary>
        public string scope { get; set; }
        ///<summary>
        ///Specifies which mode to use for testing whether a draggable is 'over' a droppable. Possible values: 'fit', 'intersect', 'pointer', 'touch'. 
        ///fit: draggable overlaps the droppable entirely
        ///intersect: draggable overlaps the droppable at least 50%
        ///pointer: mouse pointer overlaps the droppable
        ///touch: draggable overlaps the droppable any amount
        ///Default: 'intersect'
        ///</summary>
        public string tolerance { get; set; }

        ///<summary>
        ///This event is triggered when droppable is created.
        ///</summary>
        public jQueryUIEvent<UIDroppable> create { get; set; }

        ///<summary>
        ///This event is triggered any time an accepted draggable starts dragging.
        ///This can be useful if you want to make the droppable 'light up' when it can be dropped on.
        ///</summary>
        public jQueryUIEvent<UIDroppable> activate { get; set; }

        ///<summary>
        ///This event is triggered any time an accepted draggable stops dragging.
        ///</summary>
        public jQueryUIEvent<UIDroppable> deactivate { get; set; }

        ///<summary>
        ///This event is triggered as an accepted draggable is dragged 'over' (within the tolerance of) this droppable.
        ///</summary>
        public jQueryUIEvent<UIDroppable> over { get; set; }

        ///<summary>
        ///This event is triggered when an accepted draggable is dragged out (within the tolerance of) this droppable.
        ///</summary>
        public jQueryUIEvent<UIDroppable> @out { get; set; }

        ///<summary>
        ///This event is triggered when an accepted draggable is dropped 'over' (within the tolerance of) this droppable.
        ///In the callback, $(this) represents the droppable the draggable is dropped on. ui.draggable represents the draggable.
        ///</summary>
        public jQueryUIEvent<UIDroppable> drop { get; set; }
    }
    #endregion
    #region Effect
    ///<summary>
    ///[edit]effect( effect, [options], [speed], [callback] )
    ///Uses a specific effect on an element (without the show/hide logic).
    ///</summary>
    public static partial class EffectExtension
    {
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <param name="callback">A function that is called after the effect is completed.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect, object options, object speed, jQueryUIEvent callback) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect, object options, object speed) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect, object options) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <param name="callback">A function that is called after the effect is completed.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect, object options, object speed, jQueryUIEvent callback) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect, object options, object speed) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect, object options) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect) { return default(jQuery); }

        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <param name="callback">A function that is called after the effect is completed.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect, AnimationPropertiesEx options, object speed, jQueryUIEvent callback) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect, AnimationPropertiesEx options, object speed) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, string effect, AnimationPropertiesEx options) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <param name="callback">A function that is called after the effect is completed.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect, AnimationPropertiesEx options, object speed, jQueryUIEvent callback) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <param name="speed">A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect, AnimationPropertiesEx options, object speed) { return default(jQuery); }
        /// <summary>
        /// Uses a specific effect on an element (without the show/hide logic).
        /// </summary>
        /// <param name="query"></param>
        /// <param name="effect">The effect to be used. Possible values: 'blind', 'bounce', 'clip', 'drop', 'explode', 'fold', 'highlight', 'puff', 'pulsate', 'scale', 'shake', 'size', 'slide', 'transfer'.</param>
        /// <param name="options">A object/hash including specific options for the effect.</param>
        /// <returns>jQuery</returns>
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery effect(this jQuery query, EffectType effect, AnimationPropertiesEx options) { return default(jQuery); }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum EffectType
    {
        blind,
        bounce,
        clip,
        drop,
        explode,
        fade,
        fold,
        highlight,
        puff,
        pulsate,
        scale,
        shake,
        size,
        slide,
        transfer,
    }
    #endregion
    #region Hide
    ///<summary>
    ///[edit]hide( effect, [options], [speed], [callback] )
    ///The enhanced hide method optionally accepts jQuery UI advanced effects.
    ///Uses a specific effect on an element to hide the element if the first argument is an effect string.
    ///</summary>
    public static partial class HideExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery hide(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery hide(this jQuery query, HideOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery hide(this jQuery query, EffectType effect, object options, object speed, jQueryUIEvent callback) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery hide(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region HideOptions
    ///<summary>
    ///Options JSON object for Hide
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class HideOptions
    {
        ///<summary>
        ///The effect to be used. Possible values: 'blind', 'clip', 'drop', 'explode', 'fold', 'puff', 'slide', 'scale', 'size', 'pulsate'.
        ///Default: null
        ///</summary>
        public string effect { get; set; }
        ///<summary>
        ///A object/hash including specific options for the effect.
        ///Default: null
        ///</summary>
        public object options { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object speed { get; set; }
        ///<summary>
        ///A function that is called after the effect is completed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent callback { get; set; }
    }
    #endregion
    #region Progressbar
    ///<summary>
    ///The progress bar is designed to simply display the current % complete for a process. The bar is coded to be flexibly sized through CSS and will scale to fit inside it's parent container by default. 
    ///This is a determinate progress bar, meaning that it should only be used in situations where the system can accurately update the current status complete. A determinate progress bar should never fill from left to right, then loop back to empty for a single process -- if the actual percent complete status cannot be calculated, an indeterminate progress bar (coming soon) or spinner animation is a better way to provide user feedback. 
    ///</summary>
    public static partial class ProgressbarExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery progressbar(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery progressbar(this jQuery query, ProgressbarOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery progressbar(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region ProgressbarOptions
    ///<summary>
    ///Options JSON object for Progressbar
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class ProgressbarOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///The value of the progressbar.
        ///Default: 0
        ///</summary>
        public int value { get; set; }
        /// <summary>
        /// The maximum progress bar value
        /// Default: 100
        /// </summary>
        public int max { get; set; }
        ///<summary>
        ///This event is triggered when progressbar is created.
        ///</summary>
        public jQueryUIEvent create { get; set; }

        ///<summary>
        ///This event is triggered when the value of the progressbar changes.
        ///Default: null
        ///</summary>
        public jQueryUIEvent change { get; set; }

        ///<summary>
        ///This event is triggered when the value of the progressbar reaches the maximum value of 100.
        ///</summary>
        public jQueryUIEvent complete { get; set; }
    }
    #endregion
    #region RemoveClass
    ///<summary>
    ///[edit]removeClass( [class], [duration] )
    ///Removes all or specified class from each of the set of matched elements with an optional transition between the states.
    ///</summary>
    public static partial class RemoveClassExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery removeClass(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery removeClass(this jQuery query, RemoveClassOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery removeClass(this jQuery query, string methodName, object number, jQueryUIEvent callback) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery removeClass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }

    }
    #endregion
    #region RemoveClassOptions
    ///<summary>
    ///Options JSON object for RemoveClass
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class RemoveClassOptions
    {
        ///<summary>
        ///CSS classes to remove from the elements.
        ///Default: null
        ///</summary>
        public string @class { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object duration { get; set; }
    }
    #endregion
    #region Resizable
    ///<summary>
    ///The jQuery UI Resizable plugin makes selected elements resizable (meaning they have draggable resize handles). You can specify one or more handles as well as min and max width and height.
    ///All callbacks (start,stop,resize) receive two arguments: The original browser event and a prepared ui object. The ui object has the following fields:
    ///ui.helper - a jQuery object containing the helper element
    ///ui.originalPosition - {top, left} before resizing started
    ///ui.originalSize - {width, height} before resizing started
    ///ui.position - {top, left} current position
    ///ui.size - {width, height} current size
    ///</summary>
    public static partial class ResizableExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery resizable(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery resizable(this jQuery query, ResizableOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery resizable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UIResizable
    {
        /// <summary>
        /// ui.helper - the jQuery object containing the helper element
        /// </summary>
        public jQuery helper { get; set; }

        /// <summary>
        /// ui.originalPosition - {top, left} before resizing started
        /// </summary>
        public TopLeft originalPosition { get; set; }

        /// <summary>
        /// ui.originalSize - {width, height} before resizing started
        /// </summary>
        public Size originalSize { get; set; }

        /// <summary>
        /// ui.position - current position of the helper as { top, left } object, relative to the offset element
        /// </summary>
        public TopLeft position { get; set; }

        /// <summary>
        /// ui.size - {width, height} current size
        /// </summary>
        public Size size { get; set; }
    }

    [JsType(JsMode.Json)]
    public class Size
    {
        public JsNumber width { get; set; }
        public JsNumber height { get; set; }
    }
    #endregion
    #region ResizableOptions
    ///<summary>
    ///Options JSON object for Resizable
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class ResizableOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the resizable. Can be set when initialising (first creating) the resizable.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///Resize these elements synchronous when resizing.
        ///Default: false
        ///Types: Selector, jQuery, Element
        ///</summary>
        public object alsoResize { get; set; }
        ///<summary>
        ///Animates to the final size after resizing.
        ///Default: false
        ///</summary>
        public bool animate { get; set; }
        ///<summary>
        ///Duration time for animating, in milliseconds. Other possible values: 'slow', 'normal', 'fast'.
        ///Default: 'slow'
        ///Types: Integer, String
        ///</summary>
        public object animateDuration { get; set; }
        ///<summary>
        ///Easing effect for animating.
        ///Default: 'swing'
        ///</summary>
        public string animateEasing { get; set; }
        ///<summary>
        ///If set to true, resizing is constrained by the original aspect ratio. Otherwise a custom aspect ratio can be specified, such as 9 / 16, or 0.5.
        ///Default: false
        ///Types: Boolean, Float
        ///</summary>
        public object aspectRatio { get; set; }
        ///<summary>
        ///If set to true, automatically hides the handles except when the mouse hovers over the element.
        ///Default: false
        ///</summary>
        public bool autoHide { get; set; }
        ///<summary>
        ///Prevents resizing if you start on elements matching the selector.
        ///Default: ':input,option'
        ///</summary>
        public string cancel { get; set; }
        ///<summary>
        ///Constrains resizing to within the bounds of the specified element. Possible values: 'parent', 'document', a DOMElement, or a Selector.
        ///Default: false
        ///Types: String, Element, Selector
        ///</summary>
        public object containment { get; set; }
        ///<summary>
        ///Tolerance, in milliseconds, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond duration. This can help prevent unintended resizing when clicking on an element.
        ///Default: 0
        ///</summary>
        public int delay { get; set; }
        ///<summary>
        ///Tolerance, in pixels, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond distance. This can help prevent unintended resizing when clicking on an element.
        ///Default: 1
        ///</summary>
        public int distance { get; set; }
        ///<summary>
        ///If set to true, a semi-transparent helper element is shown for resizing.
        ///Default: false
        ///</summary>
        public bool ghost { get; set; }
        ///<summary>
        ///Snaps the resizing element to a grid, every x and y pixels. Array values: [x, y]
        ///Default: false
        ///</summary>
        public JsArray grid { get; set; }
        ///<summary>
        ///If specified as a string, should be a comma-split list of any of the following: 'n, e, s, w, ne, se, sw, nw, all'. The necessary handles will be auto-generated by the plugin. 
        ///If specified as an object, the following keys are supported: { n, e, s, w, ne, se, sw, nw }. The value of any specified should be a jQuery selector matching the child element of the resizable to use as that handle. If the handle is not a child of the resizable, you can pass in the DOMElement or a valid jQuery object directly.
        ///Default: 'e, s, se'
        ///Types: String, Object
        ///</summary>
        public object handles { get; set; }
        ///<summary>
        ///This is the css class that will be added to a proxy element to outline the resize during the drag of the resize handle. Once the resize is complete, the original element is sized.
        ///Default: false
        ///</summary>
        public string helper { get; set; }
        ///<summary>
        ///This is the maximum height the resizable should be allowed to resize to.
        ///Default: null
        ///</summary>
        public int maxHeight { get; set; }
        ///<summary>
        ///This is the maximum width the resizable should be allowed to resize to.
        ///Default: null
        ///</summary>
        public int maxWidth { get; set; }
        ///<summary>
        ///This is the minimum height the resizable should be allowed to resize to.
        ///Default: 10
        ///</summary>
        public int minHeight { get; set; }
        ///<summary>
        ///This is the minimum width the resizable should be allowed to resize to.
        ///Default: 10
        ///</summary>
        public int minWidth { get; set; }

        ///<summary>
        ///This event is triggered when resizable is created.
        ///</summary>
        public jQueryUIEvent<UIResizable> create { get; set; }

        ///<summary>
        ///This event is triggered at the start of a resize operation.
        ///</summary>
        public jQueryUIEvent<UIResizable> start { get; set; }

        ///<summary>
        ///This event is triggered during the resize, on the drag of the resize handler.
        ///</summary>
        public jQueryUIEvent<UIResizable> resize { get; set; }

        ///<summary>
        ///This event is triggered at the end of a resize operation.
        ///</summary>
        public jQueryUIEvent<UIResizable> stop { get; set; }

    }
    #endregion
    #region Selectable
    ///<summary>
    ///The jQuery UI Selectable plugin allows for elements to be selected by dragging a box (sometimes called a lasso) with the mouse over the elements. Also, elements can be selected by click or drag while holding the Ctrl/Meta key, allowing for multiple (non-contiguous) selections.
    ///</summary>
    public static partial class SelectableExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery selectable(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery selectable(this jQuery query, SelectableOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery selectable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region SelectableOptions
    ///<summary>
    ///Options JSON object for Selectable
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class SelectableOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the droppable. Can be set when initialising (first creating) the droppable.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///This determines whether to refresh (recalculate) the position and size of each selectee at the beginning of each select operation. If you have many many items, you may want to set this to false and call the refresh method manually.
        ///Default: true
        ///</summary>
        public bool autoRefresh { get; set; }
        ///<summary>
        ///Prevents selecting if you start on elements matching the selector.
        ///Default: ':input,option'
        ///</summary>
        public string cancel { get; set; }
        ///<summary>
        ///Time in milliseconds to define when the selecting should start. It helps preventing unwanted selections when clicking on an element.
        ///Default: 0
        ///</summary>
        public int delay { get; set; }
        ///<summary>
        ///Tolerance, in pixels, for when selecting should start. If specified, selecting will not start until after mouse is dragged beyond distance.
        ///Default: 0
        ///</summary>
        public int distance { get; set; }
        ///<summary>
        ///The matching child elements will be made selectees (able to be selected).
        ///Default: '*'
        ///</summary>
        public string filter { get; set; }
        ///<summary>
        ///Possible values: 'touch', 'fit'. 
        ///fit: draggable overlaps the droppable entirely
        ///touch: draggable overlaps the droppable any amount
        ///Default: 'touch'
        ///</summary>
        public string tolerance { get; set; }

        ///<summary>
        ///This event is triggered when selectable is created.
        ///</summary>
        public jQueryUIEvent<UIDraggable> create { get; set; }

        ///<summary>
        ///This event is triggered at the end of the select operation, on each element added to the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> selected { get; set; }

        ///<summary>
        ///This event is triggered during the select operation, on each element added to the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> selecting { get; set; }

        ///<summary>
        ///This event is triggered at the beginning of the select operation.
        ///</summary>
        public jQueryUIEvent<UIDraggable> start { get; set; }

        ///<summary>
        ///This event is triggered at the end of the select operation.
        ///</summary>
        public jQueryUIEvent<UIDraggable> stop { get; set; }

        ///<summary>
        ///This event is triggered at the end of the select operation, on each element removed from the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> unselected { get; set; }

        ///<summary>
        ///This event is triggered during the select operation, on each element removed from the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> unselecting { get; set; }

    }
    #endregion
    #region Show
    ///<summary>
    ///[edit]show( effect, [options], [speed], [callback] )
    ///The enhanced show method optionally accepts jQuery UI advanced effects.
    ///Uses a specific effect on an element to show the element if the first argument is a effect string.
    ///</summary>
    public static partial class ShowExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery show(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery show(this jQuery query, ShowOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery show(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery show(this jQuery query, EffectType effect, object options, object speed, jQueryUIEvent callback) { return default(jQuery); }
    }
    #endregion
    #region ShowOptions
    ///<summary>
    ///Options JSON object for Show
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class ShowOptions
    {
        ///<summary>
        ///The effect to be used. Possible values: 'blind', 'clip', 'drop', 'explode', 'fold', 'puff', 'slide', 'scale', 'size', 'pulsate'.
        ///Default: null
        ///</summary>
        public string effect { get; set; }
        ///<summary>
        ///A object/hash including specific options for the effect.
        ///Default: null
        ///</summary>
        public object options { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object speed { get; set; }
        ///<summary>
        ///A function that is called after the effect is completed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent callback { get; set; }
    }
    #endregion
    #region Slider
    ///<summary>
    ///The jQuery UI Slider plugin makes selected elements into sliders. There are various options such as multiple handles, and ranges. The handle can be moved with the mouse or the arrow keys.
    ///All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'): 
    ///ui.handle: DOMElement - the current focused handle 
    ///ui.value: Integer - the current handle's value 
    ///</summary>
    public static partial class SliderExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery slider(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery slider(this jQuery query, SliderOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery slider(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UISlider
    {
        /// <summary>
        /// ui.handle: DOMElement - the current focused handle
        /// </summary>
        public HtmlElement handle { get; set; }

        /// <summary>
        /// ui.value: Integer - the current handle's value
        /// </summary>
        public JsNumber value { get; set; }

        public JsArray values { get; set; }


    }
    #endregion
    #region SliderOptions
    ///<summary>
    ///Options JSON object for Slider
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class SliderOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///Whether to slide handle smoothly when user click outside handle on the bar.
        ///Default: false
        ///</summary>
        public bool animate { get; set; }
        ///<summary>
        ///The maximum value of the slider.
        ///Default: 100
        ///</summary>
        public JsNumber max { get; set; }
        ///<summary>
        ///The minimum value of the slider.
        ///Default: 0
        ///</summary>
        public JsNumber min { get; set; }
        ///<summary>
        ///Normally you don't need to set this option because the plugin detects the slider orientation automatically. If the orientation is not correctly detected you can set this option to 'horizontal' or 'vertical'.
        ///Default: 'auto'
        ///</summary>
        public string orientation { get; set; }
        ///<summary>
        ///If set to true, the slider will detect if you have two handles and create a stylable range element between these two. Two other possible values are 'min' and 'max'. A min range goes from the slider min to one handle. A max range goes from one handle to the slider max.
        ///Default: false
        ///Types: Boolean, String
        ///</summary>
        public object range { get; set; }
        ///<summary>
        ///Determines the size or amount of each interval or step the slider takes between min and max. The full specified value range of the slider (max - min) needs to be evenly divisible by the step.
        ///Default: 1
        ///</summary>
        public JsNumber step { get; set; }
        ///<summary>
        ///Determines the value of the slider, if there's only one handle. If there is more than one handle, determines the value of the first handle.
        ///Default: 0
        ///</summary>
        public int value { get; set; }
        ///<summary>
        ///This option can be used to specify multiple handles. If range is set to true, the length of 'values' should be 2.
        ///Default: null
        ///</summary>
        public JsArray values { get; set; }

        ///<summary>
        ///This event is triggered when slider is created.
        ///</summary>
        public jQueryUIEvent<UISlider> create { get; set; }

        ///<summary>
        ///This event is triggered when the user starts sliding.
        ///</summary>
        public jQueryUIEvent<UISlider> start { get; set; }

        ///<summary>
        ///This event is triggered on every mouse move during slide. Use ui.value (single-handled sliders) to obtain the value of the current handle,
        ///$(..).slider('value', index) to get another handles' value.
        ///Return false in order to prevent a slide, based on ui.value.
        ///</summary>
        public jQueryUIEvent<UISlider> slide { get; set; }

        ///<summary>
        ///This event is triggered on slide stop, or if the value is changed programmatically (by the value method). Takes arguments event and ui.
        ///Use event.originalEvent to detect whether the value changed by mouse, keyboard, or programmatically.
        ///Use ui.value (single-handled sliders) to obtain the value of the current handle, $(this).slider('values', index) to get another handle's value.
        ///</summary>
        public jQueryUIEvent<UISlider> change { get; set; }

        ///<summary>
        ///This event is triggered when the user stops sliding.
        ///</summary>
        public jQueryUIEvent<UISlider> stop { get; set; }
    }
    #endregion
    #region Sortable
    ///<summary>
    ///The jQuery UI Sortable plugin makes selected elements sortable by dragging with the mouse.
    ///All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
    ///ui.helper - the current helper element (most often a clone of the item)
    ///ui.position - current position of the helper
    ///ui.offset - current absolute position of the helper
    ///ui.item - the current dragged element
    ///ui.placeholder - the placeholder (if you defined one)
    ///ui.sender - the sortable where the item comes from (only exists if you move from one connected list to another)
    ///</summary>
    public static partial class SortableExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery sortable(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery sortable(this jQuery query, SortableOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery sortable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UISortable
    {
        /// <summary>
        /// ui.helper - the jQuery object containing the helper element
        /// </summary>
        public jQuery helper { get; set; }

        /// <summary>
        /// ui.item - the current dragged element
        /// </summary>
        public jQuery item { get; set; }

        /// <summary>
        /// ui.placeholder - the placeholder
        /// </summary>
        public jQuery placeholder { get; set; }

        /// <summary>
        /// ui.sender - the sortable where the item comes from (only exists if you move from one connected list to another)
        /// </summary>
        public jQuery sender { get; set; }

        /// <summary>
        /// ui.position - current position of the helper as { top, left } object, relative to the offset element
        /// </summary>
        public TopLeft position { get; set; }

        /// <summary>
        /// ui.offset - current absolute position of the helper as { top, left } object, relative to page
        /// </summary>
        public TopLeft offset { get; set; }
    }

    #endregion
    #region SortableOptions
    ///<summary>
    ///Options JSON object for Sortable
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class SortableOptions
    {
        /// <summary>
        /// Disables (true) or enables (false) the droppable. Can be set when initialising (first creating) the droppable.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///Defines where the helper that moves with the mouse is being appended to during the drag (for example, to resolve overlap/zIndex issues).
        ///Default: 'parent'
        ///</summary>
        public string appendTo { get; set; }
        ///<summary>
        ///If defined, the items can be dragged only horizontally or vertically. Possible values:'x', 'y'.
        ///Default: false
        ///</summary>
        public string axis { get; set; }
        ///<summary>
        ///Prevents sorting if you start on elements matching the selector.
        ///Default: ':input,button'
        ///</summary>
        public string cancel { get; set; }
        ///<summary>
        ///Takes a jQuery selector with items that also have sortables applied. If used, the sortable is now connected to the other one-way, so you can drag from this sortable to the other.
        ///Default: false
        ///</summary>
        public string connectWith { get; set; }
        ///<summary>
        ///Constrains dragging to within the bounds of the specified element - can be a DOM element, 'parent', 'document', 'window', or a jQuery selector.
        ///Default: false
        ///Types: Element, String, Selector
        ///</summary>
        public object containment { get; set; }
        ///<summary>
        ///Defines the cursor that is being shown while sorting.
        ///Default: 'auto'
        ///</summary>
        public string cursor { get; set; }
        ///<summary>
        ///Moves the sorting element or helper so the cursor always appears to drag from the same position. Coordinates can be given as a hash using a combination of one or two keys: { top, left, right, bottom }.
        ///Default: false
        ///</summary>
        public object cursorAt { get; set; }
        ///<summary>
        ///Time in milliseconds to define when the sorting should start. It helps preventing unwanted drags when clicking on an element.
        ///Default: 0
        ///</summary>
        public int delay { get; set; }
        ///<summary>
        ///Tolerance, in pixels, for when sorting should start. If specified, sorting will not start until after mouse is dragged beyond distance. Can be used to allow for clicks on elements within a handle.
        ///Default: 1
        ///</summary>
        public int distance { get; set; }
        ///<summary>
        ///If empty allows for an item to be dropped from a linked selectable.
        ///Default: true
        ///</summary>
        public bool dropOnEmpty { get; set; }
        ///<summary>
        ///If true, forces the helper to have a size.
        ///Default: false
        ///</summary>
        public bool forceHelperSize { get; set; }
        ///<summary>
        ///If true, forces the placeholder to have a size.
        ///Default: false
        ///</summary>
        public bool forcePlaceholderSize { get; set; }
        ///<summary>
        ///Snaps the sorting element or helper to a grid, every x and y pixels. Array values: [x, y]
        ///Default: false
        ///</summary>
        public JsArray grid { get; set; }
        ///<summary>
        ///Restricts sort start click to the specified element.
        ///Default: false
        ///Types: Selector, Element
        ///</summary>
        public object handle { get; set; }
        ///<summary>
        ///Allows for a helper element to be used for dragging display. The supplied function receives the event and the element being sorted, and should return a DOMElement to be used as a custom proxy helper. Possible values: 'original', 'clone'
        ///Default: 'original'
        ///Types: String, Function
        ///</summary>
        public object helper { get; set; }
        ///<summary>
        ///Specifies which items inside the element should be sortable.
        ///Default: '> *'
        ///</summary>
        public string items { get; set; }
        ///<summary>
        ///Defines the opacity of the helper while sorting. From 0.01 to 1
        ///Default: false
        ///</summary>
        public float opacity { get; set; }
        ///<summary>
        ///Class that gets applied to the otherwise white space.
        ///Default: false
        ///</summary>
        public string placeholder { get; set; }
        ///<summary>
        ///If set to true, the item will be reverted to its new DOM position with a smooth animation.
        ///Default: false
        ///</summary>
        public bool revert { get; set; }
        ///<summary>
        ///If set to true, the page scrolls when coming to an edge.
        ///Default: true
        ///</summary>
        public bool scroll { get; set; }
        ///<summary>
        ///Defines how near the mouse must be to an edge to start scrolling.
        ///Default: 20
        ///</summary>
        public int scrollSensitivity { get; set; }
        ///<summary>
        ///The speed at which the window should scroll once the mouse pointer gets within the scrollSensitivity distance.
        ///Default: 20
        ///</summary>
        public int scrollSpeed { get; set; }
        ///<summary>
        ///This is the way the reordering behaves during drag. Possible values: 'intersect', 'pointer'. In some setups, 'pointer' is more natural. 
        ///intersect: draggable overlaps the droppable at least 50%
        ///pointer: mouse pointer overlaps the droppable
        ///Default: 'intersect'
        ///</summary>
        public string tolerance { get; set; }
        ///<summary>
        ///Z-index for element/helper while being sorted.
        ///Default: 1000
        ///</summary>
        public int zIndex { get; set; }

        ///<summary>
        ///This event is triggered when sortable is created.
        ///</summary>
        public jQueryUIEvent<UISortable> create { get; set; }

        ///<summary>
        ///This event is triggered when sorting starts.
        ///</summary>
        public jQueryUIEvent<UISortable> start { get; set; }

        ///<summary>
        ///This event is triggered during sorting.
        ///</summary>
        public jQueryUIEvent<UISortable> sort { get; set; }

        ///<summary>
        ///This event is triggered during sorting, but only when the DOM position has changed.
        ///</summary>
        public jQueryUIEvent<UISortable> change { get; set; }

        ///<summary>
        ///This event is triggered when sorting stops, but when the placeholder/helper is still available.
        ///</summary>
        public jQueryUIEvent<UISortable> beforeStop { get; set; }

        ///<summary>
        ///This event is triggered when sorting has stopped.
        ///</summary>
        public jQueryUIEvent<UISortable> stop { get; set; }

        ///<summary>
        ///This event is triggered when the user stopped sorting and the DOM position has changed.
        ///</summary>
        public jQueryUIEvent<UISortable> update { get; set; }

        ///<summary>
        ///This event is triggered when a connected sortable list has received an item from another list.
        ///</summary>
        public jQueryUIEvent<UISortable> receive { get; set; }

        ///<summary>
        ///This event is triggered when a sortable item has been dragged out from the list and into another.
        ///</summary>
        public jQueryUIEvent<UISortable> remove { get; set; }

        ///<summary>
        ///This event is triggered when a sortable item is moved into a connected list.
        ///</summary>
        public jQueryUIEvent<UISortable> over { get; set; }

        ///<summary>
        ///This event is triggered when a sortable item is moved away from a connected list
        ///</summary>
        public jQueryUIEvent<UISortable> @out { get; set; }

        ///<summary>
        ///This event is triggered when using connected lists, every connected list on drag start receives it.
        ///</summary>
        public jQueryUIEvent<UISortable> activate { get; set; }

        ///<summary>
        ///This event is triggered when sorting was stopped, is propagated to all possible connected lists.
        ///</summary>
        public jQueryUIEvent<UISortable> deactivate { get; set; }
    }
    #endregion
    #region SwitchClass
    ///<summary>
    ///[edit]switchClass( remove, add, [duration] )
    ///Switches from the class defined in the first argument to the class defined as second argument, using an optional transition.
    ///</summary>
    public static partial class SwitchClassExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery switchClass(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery switchClass(this jQuery query, SwitchClassOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery switchClass(this jQuery query, string methodName, JsNumber duration) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery switchClass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }

    }
    #endregion
    #region SwitchClassOptions
    ///<summary>
    ///Options JSON object for SwitchClass
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class SwitchClassOptions
    {
        ///<summary>
        ///The CSS class that will be removed.
        ///Default: null
        ///</summary>
        public string remove { get; set; }
        ///<summary>
        ///The CSS class that will be added.
        ///Default: null
        ///</summary>
        public string add { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object duration { get; set; }
    }
    #endregion
    #region Tabs
    ///<summary>
    ///Tabs are generally used to break content into multiple sections that can be swapped to save space, much like an accordion.
    ///By default a tab widget will swap between tabbed sections onClick, but the events can be changed to onHover through an option. Tab content can be loaded via Ajax by setting an href on a tab.
    ///Contents
    ///1 Events
    ///2 Ajax mode 
    ///2.1 Back button and bookmarking
    ///3 How to... 
    ///3.1 ...retrieve the index of the currently selected tab
    ///3.2 ...open links in the current tab instead of leaving the page
    ///3.3 ...select a tab from a text link instead of clicking a tab itself
    ///3.4 ...prevent switching to the tab on click depending on form validation
    ///3.5 ...immediately select a just added tab
    ///3.6 ...follow a tab's URL instead of loading its content via ajax
    ///3.7 ...prevent a FOUC (Flash of Unstyled Content) before tabs are initialized
    ///4 Why does... 
    ///4.1 ...my slider, Google Map, sIFR etc. not work when placed in a hidden (inactive) tab?
    ///[edit]Events
    ///A series of events fire when interacting with a tabs interface: 
    ///tabsselect, tabsload, tabsshow (in that order) 
    ///tabsadd, tabsremove 
    ///tabsenable, tabsdisable 
    ///Event binding example: 
    ///$('#example').bind('tabsselect', function(event, ui) {
    ///    // Objects available in the function context:
    ///    ui.tab     // anchor element of the selected (clicked) tab
    ///    ui.panel   // element, that contains the selected/clicked tab contents
    ///    ui.index   // zero-based index of the selected (clicked) tab
    ///});Note that if a handler for the tabsselect event returns false, the clicked tab will not become selected (useful for example if switching to the next tab requires a form validation). 
    ///[edit]Ajax mode 
    ///Tabs supports loading tab content via Ajax in an unobtrusive manner. 
    ///The HTML you need is slightly different from the one that is used for static tabs: A list of links pointing to existing resources (from where the content gets loaded) and no additional containers at all (unobtrusive!). The containers' markup is going to be created on the fly: 
    ///<div id="example">
    ///     <ul>
    ///         <li><a href="ahah_1.html"><span>Content 1</span></a></li>
    ///         <li><a href="ahah_2.html"><span>Content 2</span></a></li>
    ///         <li><a href="ahah_3.html"><span>Content 3</span></a></li>
    ///     </ul>
    ///</div>
    ///Obviously this degrades gracefully - the links, e.g. the content, will still be accessible with JavaScript disabled. 
    ///Note that if you wish to reuse an existing container, you could do so by matching a title attribute and the container's id: 
    ///<li><a href="hello/world.html" title="Todo Overview"> ... </a></li>
    ///and a container like: 
    ///<div id="Todo_Overview"> ... </div>
    ///(Note how white space is replaced with an underscore) 
    ///This is useful if you want a human readable hash in the URL instead of a cryptic generated one. 
    ///[edit]Back button and bookmarking
    ///Tabs 2 already supported this functionality, although the history plugin needs a rewrite first (it doesn't support Safari 3 and is in general a little inflexible) before it can be build back into the tabs. It is planned and Klaus is working on it whenever he finds the time. Actual bugs in the UI Tabs plugin itself always have higher priority though. 
    ///[edit]How to...
    ///[edit]...retrieve the index of the currently selected tab
    ///var $tabs = $('#example').tabs();
    ///var selected = $tabs.tabs('option', 'selected'); // => 0[edit]...open links in the current tab instead of leaving the page
    ///"Hijax" links after tab content has been loaded: 
    ///$('#example').tabs({
    ///    load: function(event, ui) {
    ///        $('a', ui.panel).click(function() {
    ///            $(ui.panel).load(this.href);
    ///            return false;
    ///        });
    ///    }
    ///});[edit]...select a tab from a text link instead of clicking a tab itself
    ///var $tabs = $('#example').tabs(); // first tab selected
    ///$('#my-text-link').click(function() { // bind click event to link
    ///    $tabs.tabs('select', 2); // switch to third tab
    ///    return false;
    ///});[edit]...prevent switching to the tab on click depending on form validation
    ///Returning false in the tabs select handler prevents the clicked tab from becoming selected. 
    ///$('#example').tabs({
    ///    select: function(event, ui) {
    ///        var isValid = ... // form validation returning true or false
    ///        return isValid;
    ///    }
    ///});[edit]...immediately select a just added tab
    ///var $tabs = $('#example').tabs({
    ///    add: function(event, ui) {
    ///        $tabs.tabs('select', '#' + ui.panel.id);
    ///    }
    ///});[edit]...follow a tab's URL instead of loading its content via ajax
    ///Note that opening a tab in a new window is unexpected, e.g. inconsistent behaviour exposing a usablity problem (http://www.useit.com/alertbox/tabs.html). 
    ///$('#example').tabs({
    ///    select: function(event, ui) {
    ///        var url = $.data(ui.tab, 'load.tabs');
    ///        if( url ) {
    ///            location.href = url;
    ///            return false;
    ///        }
    ///        return true;
    ///    }
    ///});
    ///[edit]...prevent a FOUC (Flash of Unstyled Content) before tabs are initialized
    ///Add the necessary classes to hide an inactive tab panel to the HTML right away - note that this will not degrade gracefully with JavaScript being disabled: 
    ///<div id="example" class="ui-tabs">
    ///  ...
    ///  <div id="a-tab-panel" class="ui-tabs-hide"> </div>
    ///  ...
    ///</div>[edit]Why does...
    ///[edit]...my slider, Google Map, sIFR etc. not work when placed in a hidden (inactive) tab?
    ///Any component that requires some dimensional computation for its initialization won't work in a hidden tab, because the tab panel itself is hidden via display: none so that any elements inside won't report their actual width and height (0 in most browsers). 
    ///There's an easy workaround. Use the off-left technique for hiding inactive tab panels. E.g. in your style sheet replace the rule for the class selector ".ui-tabs .ui-tabs-hide" with 
    ///.ui-tabs .ui-tabs-hide {
    ///    position: absolute;
    ///    left: -10000px;
    ///}For Google maps you can also resize the map once the tab is displayed like this: 
    ///$('#example').bind('tabsshow', function(event, ui) {
    ///    if (ui.panel.id == "map-tab") {
    ///        resizeMap();
    ///    }
    ///});resizeMap() will call Google Maps' checkResize() on the particular map. 
    ///</summary>
    public static partial class TabsExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery tabs(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery tabs(this jQuery query, TabsOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery tabs(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class UITabs
    {
        /// <summary>
        ///  ui.newTab - anchor element of the selected (clicked) tab. Selected tab and previous selected
        /// </summary>
        public HtmlElement newTab { get; set; }
        public HtmlElement oldTab { get; set; }

        /// <summary>
        /// ui.newPanel - element, that contains the selected/clicked tab contents and previous oldPanel
        /// </summary>
        public HtmlElement newPanel { get; set; }
        public HtmlElement oldPanel { get; set; }

        /// <summary>
        /// ui.index - zero-based index of the selected (clicked) tab
        /// </summary>
        public JsNumber index { get; set; }
    }
    #endregion
    #region TabsOptions
    ///<summary>
    ///Options JSON object for Tabs
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class TabsOptions
    {
        /// <summary>
        /// Default: 0
        /// Which panel is currently open.
        /// Multiple types supported:
        /// Boolean: Setting active to false will collapse all panels. This requires the collapsible option to be true.
        /// Integer: The zero-based index of the panel that is active (open). A negative value selects panels going backward from the last panel.
        /// </summary>
        public bool active { get; set; }
        /// <summary>
        /// Default: 0
        /// Which panel is currently open.
        /// Multiple types supported:
        /// Boolean: Setting active to false will collapse all panels. This requires the collapsible option to be true.
        /// Integer: The zero-based index of the panel that is active (open). A negative value selects panels going backward from the last panel.
        /// </summary>
        [JsProperty(Name = "active")]
        public JsNumber activeNumber { get; set; }
        ///<summary>
        ///Set to true to allow an already selected tab to become unselected again upon reselection.
        ///Default: false
        ///</summary>
        public bool collapsible { get; set; }
        /// <summary>
        /// Disables (true) or enables (false) the button. Can be set when initialising (first creating) the button.
        /// Default:false
        /// </summary>
        public bool disabled { get; set; }
        ///<summary>
        ///An array containing the position of the tabs (zero-based index) that should be disabled on initialization.
        ///Default: []
        ///</summary>
        [JsProperty(Name = "disabled")]
        public JsArray<int> disabledIntArray { get; set; }
        ///<summary>
        ///The type of event to be used for selecting a tab.
        ///Default: 'click'
        ///</summary>
        public string @event { get; set; }
        /// <summary>
        /// Default: "auto"
        /// Controls the height of the tabs widget and each panel. Possible values:
        /// "auto": All panels will be set to the height of the tallest panel.
        /// "fill": Expand to the available height based on the tabs' parent height.
        /// "content": Each panel will be only as tall as its content.
        /// </summary>
        public HeightStyleType heightStyle { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        public bool hide { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        [JsProperty(Name = "hide")]
        public JsNumber hideNumber { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        [JsProperty(Name = "hide")]
        public JsString hideString { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        [JsProperty(Name = "hide")]
        public object hideObject { get; set; }

        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        public bool show { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        [JsProperty(Name = "show")]
        public JsNumber showNumber { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        [JsProperty(Name = "show")]
        public JsString showString { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        [JsProperty(Name = "show")]
        public object showObject { get; set; }

        ///<summary>
        ///Additional Ajax options to consider when loading tab content (see $.ajax).
        ///Default: null
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public JsObject ajaxOptions { get; set; }
        ///<summary>
        ///Whether or not to cache remote tabs content, e.g. load only once or with every click. Cached content is being lazy loaded, e.g once and only once for the first click. Note that to prevent the actual Ajax requests from being cached by the browser you need to provide an extra cache: false flag to ajaxOptions.
        ///Default: false
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public bool cache { get; set; }
        ///<summary>
        ///Store the latest selected tab in a cookie. The cookie is then used to determine the initially selected tab if the selected option is not defined. Requires cookie plugin. The object needs to have key/value pairs of the form the cookie plugin expects as options. Available options (example): { expires: 7, path: '/', domain: 'jquery.com', secure: true }. Since jQuery UI 1.7 it is also possible to define the cookie name being used via name property.
        ///Default: null
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public object cookie { get; set; }
        ///<summary>
        ///deprecated in jQuery UI 1.7, use collapsible.
        ///Default: false
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public bool deselectable { get; set; }
        ///<summary>
        ///Enable animations for hiding and showing tab panels. The duration option can be a string representing one of the three predefined speeds ("slow", "normal", "fast") or the duration in milliseconds to run an animation (default is "normal").
        ///Default: null
        ///Types: Options, Array&lt;Options&gt;
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public object fx { get; set; }
        ///<summary>
        ///If the remote tab, its anchor element that is, has no title attribute to generate an id from, an id/fragment identifier is created from this prefix and a unique id returned by $.data(el), for example "ui-tabs-54".
        ///Default: 'ui-tabs-'
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public string idPrefix { get; set; }
        ///<summary>
        ///HTML template from which a new tab panel is created in case of adding a tab with the add method or when creating a panel for a remote tab on the fly.
        ///Default: '<div></div>'
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public string panelTemplate { get; set; }
        ///<summary>
        ///Zero-based index of the tab to be selected on initialization. To set all tabs to unselected pass -1 as value.
        ///Default: 0
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public int selected { get; set; }
        ///<summary>
        ///The HTML content of this string is shown in a tab title while remote content is loading. Pass in empty string to deactivate that behavior.
        ///Default: '<em>Loading&#8230;</em>'
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public string spinner { get; set; }
        ///<summary>
        ///HTML template from which a new tab is created and added. The placeholders #{href} and #{label} are replaced with the url and tab label that are passed as arguments to the add method.
        ///Default: '<li><a href="#{href}"><span>#{label}</span></a></li>'
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public string tabTemplate { get; set; }

        ///<summary>
        ///Triggered after a tab has been activated (after animation completes).
        ///If the tabs were previously collapsed, ui.oldTab and ui.oldPanel will be empty jQuery objects.
        ///If the tabs are collapsing, ui.newTab and ui.newPanel will be empty jQuery objects.
        ///</summary>
        public jQueryUIEvent<UITabs> activate { get; set; }

        ///<summary>
        ///Triggered directly after a tab is activated. Can be canceled to prevent the tab from activating.
        ///If the tabs are currently collapsed, ui.oldTab and ui.oldPanel will be empty jQuery objects.
        ///If the tabs are collapsing, ui.newTab and ui.newPanel will be empty jQuery objects.
        ///</summary>
        public jQueryUIEvent<UITabs> beforeActivate { get; set; }

        /// <summary>
        /// Triggered when a remote tab is about to be loaded, after the beforeActivate event.
        /// Can be canceled to prevent the tab panel from loading content; though the panel will still be activated.
        /// This event is triggered just before the Ajax request is made, so modifications can be made to ui.jqXHR and ui.ajaxSettings.
        /// </summary>
        public jQueryUIEvent<UITabs> beforeLoad { get; set; }

        ///<summary>
        ///This event is triggered when tabs is created.
        ///</summary>
        public jQueryUIEvent<UITabs> create { get; set; }

        /// <summary>
        /// Triggered after a remote tab has been loaded.
        /// </summary>
        public jQueryUIEvent<UITabs> load { get; set; }

        ///<summary>
        ///This event is triggered when clicking a tab.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> selectEvent { get; set; }
        ///<summary>
        ///This event is triggered after the content of a remote tab has been loaded.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> loadEvent { get; set; }
        ///<summary>
        ///This event is triggered when a tab is shown.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> showEvent { get; set; }
        ///<summary>
        ///This event is triggered when a tab is added.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> addEvent { get; set; }
        ///<summary>
        ///This event is triggered when a tab is removed.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> removeEvent { get; set; }
        ///<summary>
        ///This event is triggered when a tab is enabled.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> enableEvent { get; set; }
        ///<summary>
        ///This event is triggered when a tab is disabled.
        ///</summary>
        //[Obsoloete("Removed from documentation at jQuery UI v1.9.0")]
        public jQueryUIEvent<UITabs> disableEvent { get; set; }
    }
    #endregion
    #region Toggle
    ///<summary>
    ///[edit]toggle( effect, [options], [speed], [callback] )
    ///The enhanced toggle method optionally accepts jQuery UI advanced effects.
    ///Uses a specific effect on an element to toggle the element if the first argument is an effect string.
    ///</summary>
    public static partial class ToggleExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggle(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggle(this jQuery query, ToggleOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggle(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region ToggleOptions
    ///<summary>
    ///Options JSON object for Toggle
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class ToggleOptions
    {
        ///<summary>
        ///The effect to be used. Possible values: 'blind', 'clip', 'drop', 'explode', 'fold', 'puff', 'slide', 'scale', 'size', 'pulsate'.
        ///Default: null
        ///</summary>
        public EffectType effect { get; set; }
        ///<summary>
        ///A object/hash including specific options for the effect.
        ///Default: null
        ///</summary>
        public object options { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object speed { get; set; }
        ///<summary>
        ///A function that is called after the effect is completed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent callback { get; set; }
    }
    #endregion
    #region ToggleClass
    ///<summary>
    ///[edit]toggleClass( class, [duration] )
    ///Adds the specified class if it is not present, and removes the specified class if it is present, using an optional transition.
    ///</summary>
    public static partial class ToggleClassExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggleClass(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggleClass(this jQuery query, ToggleClassOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggleClass(this jQuery query, JsString @class, JsNumber duration) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggleClass(this jQuery query, JsString @class, JsString duration) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery toggleClass(this jQuery query, JsString @class) { return default(jQuery); }
        //[JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        //public static jQuery toggleClass(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion
    #region ToggleClassOptions
    ///<summary>
    ///Options JSON object for ToggleClass
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class ToggleClassOptions
    {
        ///<summary>
        ///A CSS class to toggle on the elements.
        ///Default: null
        ///</summary>
        public string @class { get; set; }
        ///<summary>
        ///A string representing one of the three predefined speeds ("slow", "normal", or "fast") or the number of milliseconds to run the animation (e.g. 1000).
        ///Default: null
        ///Types: String, Number
        ///</summary>
        public object duration { get; set; }
    }
    #endregion
    #region Position

    ///<summary>
    ///[edit]hide( effect, [options], [speed], [callback] )
    ///The enhanced hide method optionally accepts jQuery UI advanced effects.
    ///Uses a specific effect on an element to hide the element if the first argument is an effect string.
    ///</summary>
    public static partial class PositionExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery position(this jQuery query, PositionOptions options) { return default(jQuery); }
    }

    ///<summary>
    ///Options JSON object for Position
    ///</summary>
    [JsType(JsMode.Json)]
    public partial class PositionOptions
    {
        ///<summary>
        ///Defines which position on the element being positioned to align with the target element: "horizontal vertical" alignment. A single value such as "right" will default to "right center", "top" will default to "center top" (following CSS convention). 
        /// Acceptable values: "top", "center", "bottom", "left", "right". 
        /// Example: "left top" or "center center
        ///</summary>
        public string my { get; set; }
        ///<summary>
        ///Defines which position on the target element to align the positioned element against: "horizontal vertical" alignment. A single value such as "right" will default to "right center", "top" will default to "center top" (following CSS convention). 
        ///Acceptable values: "top", "center", "bottom", "left", "right". 
        /// Example: "left top" or "center center"
        ///</summary>
        public string at { get; set; }
        ///<summary>
        ///Element to position against. If you provide a selector, the first matching element will be used. If you provide a jQuery object, the first element will be used. If you provide an event object, the pageX and pageY properties will be used. 
        /// Example: "#top-menu
        ///Types: Selector, Element, jQuery, Event
        ///</summary>
        public object of { get; set; }
        ///<summary>
        ///Add these left-top values to the calculated position, eg. "50 50" (left top) A single value such as "50" will apply to both.
        ///</summary>
        [Obsolete(@"Deprecated offset option; merged into my and at<br>(#6981) The offset option has been deprecated and offsets have been merged into the my and at options. The form for a position is now the named position, optionally followed by a plus or minus and then an offset. In addition, offsets now support percentages (see above). You should replace all uses of the offset option with offsets placed inside the my and/or at options.")]
        public string offset { get; set; }
        /// <summary>
        /// When the positioned element overflows the window in some direction, move it to an alternative position. Similar to my and at, this accepts a single value or a pair for horizontal/vertical, eg. "flip", "fit", "fit flip", "fit none".
        /// Acceptable values: "flip", "fit", "none".
        /// flip: to the opposite side and the collision detection is run again to see if it will fit. If it won't fit in either position, the center option should be used as a fall back. 
        /// fit: so the element keeps in the desired direction, but is re-positioned so it fits. 
        /// none: not do collision detection.
        /// </summary>
        public string collision { get; set; }
        /// <summary>
        /// When specified the actual property setting is delegated to this callback. Receives a single parameter which is a hash of top and left values for the position that should be set.
        /// </summary>
        public JsAction<object> @using { get; set; }
        [JsProperty(Name = "using")]
        public JsAction<JsObject, JsObject> usingExtend { get; set; }
        /// <summary>
        /// (Default: window)
        /// Element to position within, affecting collision detection. 
        /// If you provide a selector or jQuery object, 
        /// the first matching element will be used.
        /// </summary>
        public jQuery within { get; set; }
        /// <summary>
        /// (Default: window)
        /// Element to position within, affecting collision detection. 
        /// If you provide a selector or jQuery object, 
        /// the first matching element will be used.
        /// </summary>
        [JsProperty(Name = "within")]
        public HtmlElement withinElememt { get; set; }
        //TODO: within Selector type
    }
    #endregion
    [JsDelegate(NativeDelegates = true)]
    [JsType(JsMode.Json, OmitCasts = true, Export = false)]
    public delegate void jQueryUIEvent(Event e, object ui);

    [JsDelegate(NativeDelegates = true)]
    [JsType(JsMode.Json, OmitCasts = true, Export = false)]
    public delegate void jQueryUIEvent<T>(Event e, T ui);


    #region Plugins as classes
    /// <summary>
    /// The jQuery UI Draggable plugin makes selected elements draggable by mouse.
    /// </summary>
    internal class Draggable
    {
        public Draggable(jQuery jQuery, DraggableOptions options)
        {
        }

        /// <summary>
        /// Remove the draggable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the draggable.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the draggable.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any draggable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }
        //TODO: value is array (?)

        /// <summary>
        /// set any draggable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any draggable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-draggable element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        ///<summary>
        ///This event is triggered when draggable is created.
        ///</summary>
        public jQueryUIEvent<UIDraggable> create { get; set; }

        ///<summary>
        ///This event is triggered when dragging starts.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UIDraggable> start { get; set; }

        ///<summary>
        ///This event is triggered when the mouse is moved during the dragging.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UIDraggable> drag { get; set; }

        ///<summary>
        ///This event is triggered when dragging stops.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UIDraggable> stop { get; set; }
    }

    /// <summary>
    /// The jQuery UI Droppable plugin makes selected elements droppable (meaning they accept being dropped on by draggables). You can specify which (individually) or which kind of draggables each will accept.
    /// 
    /// All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
    /// 
    /// ui.draggable - current draggable element, a jQuery object.
    /// ui.helper - current draggable helper, a jQuery object
    /// ui.position - current position of the draggable helper { top: , left: }
    /// ui.offset - current absolute position of the draggable helper { top: , left: }
    /// </summary>
    internal class Droppable
    {
        public Droppable(jQuery jQuery, DroppableOptions options)
        {
        }


        /// <summary>
        /// Remove the droppable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the droppable.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the droppable.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any droppable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }
        //TODO: value is array (?)

        /// <summary>
        /// set any droppable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any droppable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-droppable element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        ///<summary>
        ///This event is triggered when droppable is created.
        ///</summary>
        public jQueryUIEvent<UIDroppable> create { get; set; }

        ///<summary>
        ///This event is triggered any time an accepted draggable starts dragging.
        ///This can be useful if you want to make the droppable 'light up' when it can be dropped on.
        ///</summary>
        public jQueryUIEvent<UIDroppable> activate { get; set; }

        ///<summary>
        ///This event is triggered any time an accepted draggable stops dragging.
        ///</summary>
        public jQueryUIEvent<UIDroppable> deactivate { get; set; }

        ///<summary>
        ///This event is triggered as an accepted draggable is dragged 'over' (within the tolerance of) this droppable.
        ///</summary>
        public jQueryUIEvent<UIDroppable> over { get; set; }

        ///<summary>
        ///This event is triggered when an accepted draggable is dragged out (within the tolerance of) this droppable.
        ///</summary>
        public jQueryUIEvent<UIDroppable> @out { get; set; }

        ///<summary>
        ///This event is triggered when an accepted draggable is dropped 'over' (within the tolerance of) this droppable.
        ///In the callback, $(this) represents the droppable the draggable is dropped on. ui.draggable represents the draggable.
        ///</summary>
        public jQueryUIEvent<UIDroppable> drop { get; set; }
    }

    /// <summary>
    /// The jQuery UI Selectable plugin allows for elements to be selected by dragging a box (sometimes called a lasso) with the mouse over the elements. Also, elements can be selected by click or drag while holding the Ctrl/Meta key, allowing for multiple (non-contiguous) selections.
    /// </summary>
    internal class Resizable
    {
        public Resizable(jQuery jQuery, ResizableOptions options)
        {
        }

        /// <summary>
        /// Remove the resizable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the resizable.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the resizable.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any resizable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }
        //TODO: value is array (?)

        /// <summary>
        /// set any resizable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any resizable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-resizable element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        ///<summary>
        ///This event is triggered when resizable is created.
        ///</summary>
        public jQueryUIEvent<UIResizable> create { get; set; }

        ///<summary>
        ///This event is triggered at the start of a resize operation.
        ///</summary>
        public jQueryUIEvent<UIResizable> start { get; set; }

        ///<summary>
        ///This event is triggered during the resize, on the drag of the resize handler.
        ///</summary>
        public jQueryUIEvent<UIResizable> resize { get; set; }

        ///<summary>
        ///This event is triggered at the end of a resize operation.
        ///</summary>
        public jQueryUIEvent<UIResizable> stop { get; set; }
    }

    /// <summary>
    /// The jQuery UI Selectable plugin allows for elements to be selected by dragging a box (sometimes called a lasso) with the mouse over the elements. Also, elements can be selected by click or drag while holding the Ctrl/Meta key, allowing for multiple (non-contiguous) selections.
    /// </summary>
    internal class Selectable
    {
        public Selectable(jQuery jQuery, SelectableOptions options)
        {
        }

        /// <summary>
        /// Remove the selectable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the selectable.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the selectable.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any selectable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }
        //TODO: value is array (?)

        /// <summary>
        /// set any selectable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any selectable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-selectable element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Refresh the position and size of each selectee element.
        /// This method can be used to manually recalculate the position and size of each selectee element. Very useful if autoRefresh is set to false.
        /// </summary>
        public void refresh() { }

        ///<summary>
        ///This event is triggered when selectable is created.
        ///</summary>
        public jQueryUIEvent<UIDraggable> create { get; set; }

        ///<summary>
        ///This event is triggered at the end of the select operation, on each element added to the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> selected { get; set; }

        ///<summary>
        ///This event is triggered during the select operation, on each element added to the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> selecting { get; set; }

        ///<summary>
        ///This event is triggered at the beginning of the select operation.
        ///</summary>
        public jQueryUIEvent<UIDraggable> start { get; set; }

        ///<summary>
        ///This event is triggered at the end of the select operation.
        ///</summary>
        public jQueryUIEvent<UIDraggable> stop { get; set; }

        ///<summary>
        ///This event is triggered at the end of the select operation, on each element removed from the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> unselected { get; set; }

        ///<summary>
        ///This event is triggered during the select operation, on each element removed from the selection.
        ///</summary>
        public jQueryUIEvent<UIDraggable> unselecting { get; set; }

    }

    /// <summary>
    /// The jQuery UI Sortable plugin makes selected elements sortable by dragging with the mouse.
    /// 
    /// All callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
    /// 
    /// ui.helper - the current helper element (most often a clone of the item)
    /// ui.position - current position of the helper
    /// ui.offset - current absolute position of the helper
    /// ui.item - the current dragged element
    /// ui.placeholder - the placeholder (if you defined one)
    /// ui.sender - the sortable where the item comes from (only exists if you move from one connected list to another)
    /// </summary>
    internal class Sortable
    {
        public Sortable(jQuery jQuery, SortableOptions options)
        {
        }

        /// <summary>
        /// Remove the sortable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the sortable.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the sortable.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any sortable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }
        //TODO: value is array (?)

        /// <summary>
        /// set any sortable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any sortable option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-sortable element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Serializes the sortable's item id's into a form/ajax submittable string.
        /// Calling this method produces a hash that can be appended to any url to easily submit a new item order back to the server.
        ///It works by default by looking at the id of each item in the format 'setname_number', and it spits out a hash like "setname[]=number&setname[]=number".
        ///You can also give in a option hash as second argument to custom define how the function works.
        ///The possible options are: 'key' (replaces part1[] with whatever you want), 'attribute' (test another attribute than 'id') and 'expression' (use your own regexp).
        ///If serialize returns an empty string, make sure the id attributes include an underscore.
        ///They must be in the form: "set_number" For example, a 3 element list with id attributes foo_1, foo_5, foo_2 will serialize to foo[]=1&foo[]=5&foo[]=2.
        ///You can use an underscore, equal sign or hyphen to separate the set and number. For example foo=1 or foo-1 or foo_1 all serialize to foo[]=1.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public object serialize(SortableSerializeOptionsType options) { return null; }
        //TODO: return type?

        /// <summary>
        /// Serializes the sortable's item id's into an array of string.
        /// </summary>
        public void toArray() { }

        /// <summary>
        /// Refresh the sortable items. Custom trigger the reloading of all sortable items, causing new items to be recognized.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Refresh the cached positions of the sortables' items. Calling this method refreshes the cached item positions of all sortables.
        /// This is usually done automatically by the script and slows down performance. Use wisely.
        /// </summary>
        public void refreshPositions() { }

        /// <summary>
        /// Cancels a change in the current sortable and reverts it back to how it was before the current sort started. Useful in the stop and receive callback functions.
        /// If the sortable item is not being moved from one connected sortable to another:
        /// $(this).sortable('cancel');
        /// will cancel the change.
        /// If the sortable item is being moved from one connected sortable to another:
        /// $(ui.sender).sortable('cancel');
        /// will cancel the change. Useful in the 'receive' callback.
        /// </summary>
        public void cancel() { }

        ///<summary>
        ///This event is triggered when sortable is created.
        ///</summary>
        public jQueryUIEvent<UISortable> create { get; set; }

        ///<summary>
        ///This event is triggered when sorting starts.
        ///</summary>
        public jQueryUIEvent<UISortable> start { get; set; }

        ///<summary>
        ///This event is triggered during sorting.
        ///</summary>
        public jQueryUIEvent<UISortable> sort { get; set; }

        ///<summary>
        ///This event is triggered during sorting, but only when the DOM position has changed.
        ///</summary>
        public jQueryUIEvent<UISortable> change { get; set; }

        ///<summary>
        ///This event is triggered when sorting stops, but when the placeholder/helper is still available.
        ///</summary>
        public jQueryUIEvent<UISortable> beforeStop { get; set; }

        ///<summary>
        ///This event is triggered when sorting has stopped.
        ///</summary>
        public jQueryUIEvent<UISortable> stop { get; set; }

        ///<summary>
        ///This event is triggered when the user stopped sorting and the DOM position has changed.
        ///</summary>
        public jQueryUIEvent<UISortable> update { get; set; }

        ///<summary>
        ///This event is triggered when a connected sortable list has received an item from another list.
        ///</summary>
        public jQueryUIEvent<UISortable> receive { get; set; }

        ///<summary>
        ///This event is triggered when a sortable item has been dragged out from the list and into another.
        ///</summary>
        public jQueryUIEvent<UISortable> remove { get; set; }

        ///<summary>
        ///This event is triggered when a sortable item is moved into a connected list.
        ///</summary>
        public jQueryUIEvent<UISortable> over { get; set; }

        ///<summary>
        ///This event is triggered when a sortable item is moved away from a connected list
        ///</summary>
        public jQueryUIEvent<UISortable> @out { get; set; }

        ///<summary>
        ///This event is triggered when using connected lists, every connected list on drag start receives it.
        ///</summary>
        public jQueryUIEvent<UISortable> activate { get; set; }

        ///<summary>
        ///This event is triggered when sorting was stopped, is propagated to all possible connected lists.
        ///</summary>
        public jQueryUIEvent<UIDraggable> deactivate { get; set; }

    }

    public enum SortableSerializeOptionsType
    {
        /// <summary>
        /// replaces part1[] with whatever you want
        /// </summary>
        key,
        /// <summary>
        /// test another attribute than 'id'
        /// </summary>
        attribute,
        /// <summary>
        /// use your own regexp
        /// </summary>
        expression,
    }

    /// <summary>
    /// Make the selected elements Accordion widgets. Semantic requirements:
    /// 
    /// The markup of your accordion container needs pairs of headers and content panels:
    /// 
    /// <div id="accordion">
    ///     <h3><a href="#">First header</a></h3>
    ///     <div>First content</div>
    ///     <h3><a href="#">Second header</a></h3>
    ///     <div>Second content</div>
    /// </div>
    /// If you use a different element for the header, specify the header-option with an appropriate selector, eg. header: 'a.header'. The content element must be always next to its header.
    /// 
    /// If you have links inside the accordion content and use a-elements as headers, add a class to them and use that as the header, eg. header: 'a.header'.
    /// 
    /// Use activate(Number) to change the active content programmatically.
    /// 
    /// NOTE: If you want multiple sections open at once, don't use an accordion
    /// </summary>
    internal class Accordion
    {
        public Accordion(jQuery jQuery, AccordionOptions options)
        {
        }

        /// <summary>
        /// Remove the accordion functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the accordion.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the accordion.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any accordion option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any accordion option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any accordion option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-accordion element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Activate a content part of the Accordion programmatically.
        /// The index can be a zero-indexed number to match the position of the header to close or a Selector matching an element.
        /// </summary>
        /// <param name="index"></param>
        public void activate(JsNumber index) { }

        /// <summary>
        /// Recompute heights of the accordion contents when using the fillSpace option and the container height changed.
        /// For example, when the container is a resizable, this method should be called by its resize-event.
        /// </summary>
        public void resize() { }

        ///<summary>
        ///This event is triggered when accordion is created.
        ///</summary>
        public jQueryUIEvent<UIAccordion> create { get; set; }

        ///<summary>
        ///This event is triggered every time the accordion changes.
        ///If the accordion is animated, the event will be triggered upon completion of the animation; otherwise, it is triggered immediately.
        ///$('.ui-accordion').bind('accordionchange', function(event, ui) {
        ///   ui.newHeader // jQuery object, activated header
        ///   ui.oldHeader // jQuery object, previous header
        ///   ui.newContent // jQuery object, activated content
        ///   ui.oldContent // jQuery object, previous content
        /// });
        ///</summary>
        public jQueryUIEvent<UIAccordion> change { get; set; }

        ///<summary>
        ///This event is triggered every time the accordion starts to change.
        /// $('.ui-accordion').bind('accordionchangestart', function(event, ui) {
        ///   ui.newHeader // jQuery object, activated header
        ///   ui.oldHeader // jQuery object, previous header
        ///   ui.newContent // jQuery object, activated content
        ///   ui.oldContent // jQuery object, previous content
        /// });
        ///</summary>
        public jQueryUIEvent<UIAccordion> changestart { get; set; }

    }

    /// <summary>
    /// Autocomplete, when added to an input field, enables users to quickly find and select from a pre-populated list of values as they type, leveraging searching and filtering.
    /// 
    /// By giving an Autocomplete field focus or entering something into it, the plugin starts searching for entries that match and displays a list of values to choose from. By entering more characters, the user can filter down the list to better matches.
    /// 
    /// This can be used to enter previous selected values, for example you could use Autocomplete for entering tags, to complete an address, you could enter a city name and get the zip code, or maybe enter email addresses from an address book.
    /// 
    /// You can pull data in from a local and/or a remote source: Local is good for small data sets (like an address book with 50 entries), remote is necessary for big data sets, like a database with hundreds or millions of entries to select from.
    /// 
    /// Autocomplete can be customized to work with various data sources, by just specifying the source option. A data source can be:
    /// 
    /// an Array with local data
    /// a String, specifying a URL
    /// a Callback
    /// </summary>
    internal class Autocomplete
    {
        public Autocomplete(jQuery jQuery, AutocompleteOptions options)
        {
        }

        /// <summary>
        /// Remove the autocomplete functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the autocomplete.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the autocomplete.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any autocomplete option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any autocomplete option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any autocomplete option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-autocomplete element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Triggers a search event, which, when data is available, then will display the suggestions; can be used by a selectbox-like button to open the suggestions when clicked.
        /// If no value argument is specified, the current input's value is used. Can be called with an empty string and minLength: 0 to display all items.
        /// </summary>
        /// <param name="value"></param>
        public void search(object value) { }
        /// <summary>
        /// Triggers a search event, which, when data is available, then will display the suggestions; can be used by a selectbox-like button to open the suggestions when clicked.
        /// If no value argument is specified, the current input's value is used. Can be called with an empty string and minLength: 0 to display all items.
        /// </summary>
        public void search() { }

        /// <summary>
        /// Close the Autocomplete menu. Useful in combination with the search method, to close the open menu.
        /// </summary>
        public void close() { }

        /// <summary>
        /// This event is triggered when autocomplete is created.
        /// </summary>
        public jQueryUIEvent create { get; set; }

        /// <summary>
        /// Before a request (source-option) is started, after minLength and delay are met. Can be canceled (return false), then no request will be started and no items suggested.
        ///</summary>
        public jQueryUIEvent searchEvent { get; set; }
        //TODO: event name without the"event"

        /// <summary>
        /// Triggered when the suggestion menu is opened.
        /// </summary>
        public jQueryUIEvent open { get; set; }

        /// <summary>
        /// Before focus is moved to an item (not selecting), ui.item refers to the focused item. The default action of focus is to replace the text field's value with the value of the focused item, though only if the focus event was triggered by a keyboard interaction.
        /// Canceling this event prevents the value from being updated, but does not prevent the menu item from being focused.
        /// </summary>
        public jQueryUIEvent focus { get; set; }

        /// <summary>
        /// Triggered when an item is selected from the menu; ui.item refers to the selected item. The default action of select is to replace the text field's value with the value of the selected item.
        ///Canceling this event prevents the value from being updated, but does not prevent the menu from closing.
        /// </summary>
        public jQueryUIEvent select { get; set; }

        /// <summary>
        /// When the list is hidden - doesn't have to occur together with a change.
        /// </summary>
        public jQueryUIEvent closeEvent { get; set; }
        //TODO: event name without the"event"

        /// <summary>
        /// Triggered when the field is blurred, if the value has changed; ui.item refers to the selected item.
        /// </summary>
        public jQueryUIEvent change { get; set; }
    }

    /// <summary>
    /// Button enhances standard form elements like button, input of type submit or reset or anchors to themable buttons with appropiate mouseover and active styles.
    /// 
    /// In addition to basic push buttons, radio buttons and checkboxes (inputs of type radio and checkbox) can be converted to buttons: Their associated label is styled to appear as the button, while the underlying input is updated on click.
    /// 
    /// In order to group radio buttons, Button also provides an additional widget-method, called Buttonset. Its used by selecting a container element (which contains the radio buttons) and calling buttonset(). Buttonset will also provide visual grouping, and therefore should be used whenever you have a group of buttons. It works by selecting all descendents and applying button() to them. You can enable and disable a buttonset, which will enable and disable all contained buttons. Destroying a buttonset also calls the button's destroy method.
    /// 
    /// When using an input of type button, submit or reset, support is limited to plain text labels with no icons.
    /// </summary>
    internal class Button
    {
        public Button(jQuery jQuery, ButtonOptions options)
        {
        }

        /// <summary>
        /// Remove the button functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the button.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the button.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any button option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }
        //TODO: value is array (?)

        /// <summary>
        /// set any button option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any button option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-button element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Refresh the position and size of each selectee element.
        /// This method can be used to manually recalculate the position and size of each selectee element. Very useful if autoRefresh is set to false.
        /// </summary>
        public void refresh() { }

        ///<summary>
        ///This event is triggered when button is created.
        ///</summary>
        public jQueryUIEvent<UIDraggable> create { get; set; }
        //TODO: no UIButton
    }

    /// <summary>
    /// The jQuery UI Datepicker is a highly configurable plugin that adds datepicker functionality to your pages. You can customize the date format and language, restrict the selectable date ranges and add in buttons and other navigation options easily.
    /// 
    /// By default, the datepicker calendar opens in a small overlay onFocus and closes automatically onBlur or when a date is selected. For an inline calendar, simply attach the datepicker to a div or span.
    /// 
    /// You can use keyboard shortcuts to drive the datepicker:
    /// 
    /// page up/down - previous/next month
    /// ctrl+page up/down - previous/next year
    /// ctrl+home - current month or open when closed
    /// ctrl+left/right - previous/next day
    /// ctrl+up/down - previous/next week
    /// enter - accept the selected date
    /// ctrl+end - close and erase the date
    /// escape - close the datepicker without selection
    /// </summary>
    internal class Datepicker
    {
        public Datepicker(jQuery jQuery, DatepickerOptions options)
        {
        }

        /// <summary>
        /// Remove the datepicker functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the datepicker.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the datepicker.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any datepicker option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any datepicker option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any datepicker option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-datepicker element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Open a datepicker in a "dialog" box.
        /// </summary>
        /// <param name="date">the initial date for the date picker as either a Date or a string in the current date format.</param>
        /// <param name="onSelect">A callback function when a date is selected. The function receives the date text and date picker instance as parameters.</param>
        /// <param name="settings">The new settings for the date picker.</param>
        /// <param name="pos">The position of the top/left of the dialog as [x, y] or a MouseEvent that contains the coordinates. If not specified the dialog is centered on the screen.</param>
        public void dialog(JsString date, object onSelect, object settings, object pos) { }
        /// <summary>
        /// Open a datepicker in a "dialog" box.
        /// </summary>
        /// <param name="date">the initial date for the date picker as either a Date or a string in the current date format.</param>
        /// <param name="onSelect">A callback function when a date is selected. The function receives the date text and date picker instance as parameters.</param>
        /// <param name="settings">The new settings for the date picker.</param>
        /// <param name="pos">The position of the top/left of the dialog as [x, y] or a MouseEvent that contains the coordinates. If not specified the dialog is centered on the screen.</param>
        public void dialog(JsDate date, object onSelect, object settings, object pos) { }
        /// <summary>
        /// Open a datepicker in a "dialog" box.
        /// </summary>
        /// <param name="date">the initial date for the date picker as either a Date or a string in the current date format.</param>
        public void dialog(JsString date) { }
        /// <summary>
        /// Open a datepicker in a "dialog" box.
        /// </summary>
        /// <param name="date">the initial date for the date picker as either a Date or a string in the current date format.</param>
        public void dialog(JsDate date) { }

        /// <summary>
        /// Determine whether a date picker has been disabled.
        /// </summary>
        public void isDisabled() { }

        /// <summary>
        /// Close a previously opened date picker.
        /// </summary>
        public void hide() { }

        /// <summary>
        /// Call up a previously attached date picker. If the datepicker is attached to an input, the input must be visible for the datepicker to be shown.
        /// </summary>
        public void show() { }

        /// <summary>
        /// Redraw a date picker, after having made some external modifications.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Returns the current date for the datepicker or null if no date has been selected.
        /// </summary>
        /// <returns></returns>
        public object getDate() { return null; }

        /// <summary>
        /// Sets the current date for the datepicker. The new date may be a Date object or a string in the current date format (e.g. '01/26/2009'),
        /// a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d')
        /// or null to clear the selected date.
        /// </summary>
        /// <param name="date"></param>
        public void setDate(JsString date) { }
        /// <summary>
        /// Sets the current date for the datepicker. The new date may be a Date object or a string in the current date format (e.g. '01/26/2009'),
        /// a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d')
        /// or null to clear the selected date.
        /// </summary>
        /// <param name="date"></param>
        public void setDate(JsDate date) { }

        ///<summary>
        ///Can be a function that takes an input field and current datepicker instance and returns an options object to update the datepicker with. It is called just before the datepicker is displayed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent beforeShow { get; set; }
        ///<summary>
        ///The function takes a date as a parameter and must return an array with [0] equal to true/false indicating whether or not this date is selectable, [1] equal to a CSS class name(s) or '' for the default presentation and [2] an optional popup tooltip for this date. It is called for each day in the datepicker before is it displayed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent beforeShowDay { get; set; }
        ///<summary>
        ///Allows you to define your own event when the datepicker moves to a new month and/or year. The function receives the selected year, month (1-12), and the datepicker instance as parameters. this refers to the associated input field.
        ///Default: null
        ///Types: function(year, month, inst)
        ///</summary>
        public jQueryUIEvent onChangeMonthYear { get; set; }
        ///<summary>
        ///Allows you to define your own event when the datepicker is closed, whether or not a date is selected. The function receives the selected date as text and the datepicker instance as parameters. this refers to the associated input field.
        ///Default: null
        ///Types: function(dateText, inst)
        ///</summary>
        public jQueryUIEvent onClose { get; set; }
        ///<summary>
        ///Allows you to define your own event when the datepicker is selected. The function receives the selected date as text and the datepicker instance as parameters. this refers to the associated input field.
        ///Default: null
        ///Types: function(dateText, inst)
        ///</summary>
        public jQueryUIEvent onSelect { get; set; }
    }

    /// <summary>
    /// A dialog is a floating window that contains a title bar and a content area. The dialog window can be moved, resized and closed with the 'x' icon by default.
    /// 
    /// If the content length exceeds the maximum height, a scrollbar will automatically appear.
    /// 
    /// A bottom button bar and semi-transparent modal overlay layer are common options that can be added.
    /// </summary>
    internal class Dialog
    {
        public Dialog(jQuery jQuery, DialogOptions options)
        {
        }

        /// <summary>
        /// Remove the dialog functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the dialog.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the dialog.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any dialog option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any dialog option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any dialog option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-dialog element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Close the dialog.
        /// </summary>
        public void close() { }

        /// <summary>
        /// Returns true if the dialog is currently open.
        /// </summary>
        /// <returns></returns>
        public bool isOpen() { return false; }

        /// <summary>
        /// Move the dialog to the top of the dialogs stack.
        /// </summary>
        public void moveToTop() { }

        /// <summary>
        /// Open the dialog.
        /// </summary>
        public void open() { }

        ///<summary>
        ///This event is triggered when dialog is created.
        ///</summary>
        public jQueryUIEvent create { get; set; }

        ///<summary>
        ///This event is triggered when a dialog attempts to close. If the beforeclose event handler (callback function) returns false, the close will be prevented.
        ///Default: null
        ///</summary>
        public jQueryUIEvent beforeclose { get; set; }

        ///<summary>
        ///This event is triggered when dialog is opened.
        ///Default: null
        ///</summary>
        public jQueryUIEvent openEvent { get; set; }
        //TODO: event name without the"event"

        ///<summary>
        ///This event is triggered when the dialog gains focus.
        ///Default: null
        ///</summary>
        public jQueryUIEvent focus { get; set; }

        ///<summary>
        ///This event is triggered at the beginning of the dialog being dragged.
        ///Default: null
        ///</summary>
        public jQueryUIEvent dragStart { get; set; }

        ///<summary>
        ///This event is triggered when the dialog is dragged.
        ///Default: null
        ///</summary>
        public jQueryUIEvent drag { get; set; }

        ///<summary>
        ///This event is triggered after the dialog has been dragged.
        ///Default: null
        ///</summary>
        public jQueryUIEvent dragStop { get; set; }

        ///<summary>
        ///This event is triggered at the beginning of the dialog being resized.
        ///Default: null
        ///</summary>
        public jQueryUIEvent resizeStart { get; set; }

        ///<summary>
        ///This event is triggered when the dialog is resized.
        ///Default: null
        ///</summary>
        public jQueryUIEvent resize { get; set; }

        ///<summary>
        ///This event is triggered after the dialog has been resized.
        ///Default: null
        ///</summary>
        public jQueryUIEvent resizeStop { get; set; }

        ///<summary>
        ///This event is triggered when the dialog is closed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent closeEvent { get; set; }
        //TODO: event name without the"event"
    }


    /// <summary>
    /// The progress bar is designed to simply display the current % complete for a process. The bar is coded to be flexibly sized through CSS and will scale to fit inside it's parent container by default.
    /// 
    /// This is a determinate progress bar, meaning that it should only be used in situations where the system can accurately update the current status complete. A determinate progress bar should never fill from left to right, then loop back to empty for a single process -- if the actual percent complete status cannot be calculated, an indeterminate progress bar (coming soon) or spinner animation is a better way to provide user feedback.
    /// </summary>
    internal class Progressbar
    {
        public Progressbar(jQuery jQuery, ProgressbarOptions options)
        {
        }

        /// <summary>
        /// Remove the progressbar functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the progressbar.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the progressbar.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any progressbar option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any progressbar option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any progressbar option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-progressbar element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// sets the current value of the progressbar.
        /// </summary>
        /// <param name="value"></param>
        public void value(object value) { }

        /// <summary>
        /// gets the current value of the progressbar.
        /// </summary>
        /// <returns></returns>
        public object value() { return null; }

        ///<summary>
        ///This event is triggered when progressbar is created.
        ///</summary>
        public jQueryUIEvent create { get; set; }

        ///<summary>
        ///This event is triggered when the value of the progressbar changes.
        ///Default: null
        ///</summary>
        public jQueryUIEvent change { get; set; }

        ///<summary>
        ///This event is triggered when the value of the progressbar reaches the maximum value of 100.
        ///</summary>
        public jQueryUIEvent complete { get; set; }

    }

    /// <summary>
    /// The jQuery UI Slider plugin makes selected elements into sliders. There are various options such as multiple handles, and ranges. The handle can be moved with the mouse or the arrow keys.
    /// 
    /// The start, slide, and stop callbacks receive two arguments: The original browser event and a prepared ui object, view below for a documentation of this object (if you name your second argument 'ui'):
    /// 
    /// The slider widget will create handle elements with the class 'ui-slider-handle' on initialization. You can specify custom handle elements by creating and appending the elements and adding the 'ui-slider-handle' class before init. It will only create the number of handles needed to match the length of value/values. For example, if you specify 'values: [1, 5, 18]' and create one custom handle, the plugin will create the other two.
    /// </summary>
    internal class Slider
    {
        public Slider(jQuery jQuery, SliderOptions options)
        {
        }

        /// <summary>
        /// Remove the slider functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the slider.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the slider.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any slider option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any slider option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any slider option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-slider element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// sets the current value of the slider.
        /// </summary>
        /// <param name="value"></param>
        public void value(object value) { }

        /// <summary>
        /// gets the current value of the slider.
        /// </summary>
        /// <returns></returns>
        public object value() { return null; }

        /// <summary>
        /// sets the values of the slider. For multiple handle or range sliders.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void values(JsNumber index, object value) { }
        /// <summary>
        /// sets the values of the slider. For multiple handle or range sliders.
        /// </summary>
        /// <param name="index"></param>
        public void values(JsNumber index) { }

        /// <summary>
        /// gets the values of the slider. For multiple handle or range sliders.
        /// </summary>
        /// <returns></returns>
        public object values() { return null; }

        ///<summary>
        ///This event is triggered when slider is created.
        ///</summary>
        public jQueryUIEvent<UISlider> create { get; set; }

        ///<summary>
        ///This event is triggered when the user starts sliding.
        ///</summary>
        public jQueryUIEvent<UISlider> start { get; set; }

        ///<summary>
        ///This event is triggered on every mouse move during slide. Use ui.value (single-handled sliders) to obtain the value of the current handle,
        ///$(..).slider('value', index) to get another handles' value.
        ///Return false in order to prevent a slide, based on ui.value.
        ///</summary>
        public jQueryUIEvent<UISlider> slide { get; set; }

        ///<summary>
        ///This event is triggered on slide stop, or if the value is changed programmatically (by the value method). Takes arguments event and ui.
        ///Use event.originalEvent to detect whether the value changed by mouse, keyboard, or programmatically.
        ///Use ui.value (single-handled sliders) to obtain the value of the current handle, $(this).slider('values', index) to get another handle's value.
        ///</summary>
        public jQueryUIEvent<UISlider> change { get; set; }

        ///<summary>
        ///This event is triggered when the user stops sliding.
        ///</summary>
        public jQueryUIEvent<UISlider> stop { get; set; }


    }

    /// <summary>
    /// Tabs are generally used to break content into multiple sections that can be swapped to save space, much like an accordion.
    /// 
    /// By default a tab widget will swap between tabbed sections onClick, but the events can be changed to onHover through an option. Tab content can be loaded via Ajax by setting an href on a tab.
    /// 
    /// NOTE: Tabs created dynamically using .tabs( "add", ... ) are given an id of ui-tabs-NUM, where NUM is an auto-incrementing id. If you use this naming convention for your own elements, you may encounter problems.
    /// </summary>
    internal class Tabs
    {
        public Tabs(jQuery jQuery, TabsOptions options)
        {
        }

        /// <summary>
        /// Remove the tabs functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        /// <returns></returns>
        public object destroy() { return null; }

        /// <summary>
        /// Disable the tabs.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enable the tabs.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// set any tabs option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        /// <param name="value"></param>
        public void option(JsString optionName, object value) { }

        /// <summary>
        /// set any tabs option. If no value is specified, will act as a getter.
        /// </summary>
        /// <param name="optionName"></param>
        public void option(JsString optionName) { }

        /// <summary>
        /// Get any tabs option. If no value is specified, will act as a getter.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }

        /// <summary>
        /// Returns the .ui-tabs element.
        /// </summary>
        /// <returns></returns>
        public object widget() { return null; }

        /// <summary>
        /// Add a new tab. The second argument is either a URL consisting of a fragment identifier only to create an in-page tab or a full url (relative or absolute,
        /// no cross-domain support) to turn the new tab into an Ajax (remote) tab.
        /// The third is the zero-based position where to insert the new tab. Optional, by default a new tab is appended at the end.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="label"></param>
        /// <param name="index"></param>
        public void add(JsString url, object label, JsNumber index) { }
        /// <summary>
        /// Add a new tab. The second argument is either a URL consisting of a fragment identifier only to create an in-page tab or a full url (relative or absolute,
        /// no cross-domain support) to turn the new tab into an Ajax (remote) tab.
        /// The third is the zero-based position where to insert the new tab. Optional, by default a new tab is appended at the end.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="label"></param>
        public void add(JsString url, object label) { }

        /// <summary>
        /// Remove a tab. The second argument is the zero-based index of the tab to be removed. Instead of an index, the href of the tab may be passed.
        /// </summary>
        /// <param name="index"></param>
        public void remove(JsNumber index) { }

        /// <summary>
        /// Enable a disabled tab. To enable more than one tab at once reset the disabled property like:
        /// $('#example').tabs("option","disabled",[]);
        /// . The second argument is the zero-based index of the tab to be enabled. Instead of an index, the href of the tab may be passed.
        /// </summary>
        /// <param name="index"></param>
        public void enable(JsNumber index) { }

        /// <summary>
        /// Disable a tab. The selected tab cannot be disabled. To disable more than one tab at once use:
        /// $('#example').tabs("option","disabled", [1, 2, 3]);
        /// The second argument is the zero-based index of the tab to be disabled. Instead of an index, the href of the tab may be passed.
        /// </summary>
        /// <param name="index"></param>
        public void disable(JsNumber index) { }

        /// <summary>
        /// Select a tab, as if it were clicked. The second argument is the zero-based index of the tab to be selected
        /// or the id selector of the panel the tab is associated with (the tab's href fragment identifier, e.g. hash, points to the panel's id).
        /// </summary>
        /// <param name="index"></param>
        public void select(JsNumber index) { }

        /// <summary>
        /// Reload the content of an Ajax tab programmatically. This method always loads the tab content from the remote location,
        /// even if cache is set to true. The second argument is the zero-based index of the tab to be reloaded.
        /// </summary>
        /// <param name="index"></param>
        public void load(JsNumber index) { }

        /// <summary>
        /// Change the url from which an Ajax (remote) tab will be loaded. The specified URL will be used for subsequent loads.
        /// Note that you can not only change the URL for an existing remote tab with this method, but also turn an in-page tab into a remote tab.
        /// The second argument is the zero-based index of the tab of which its URL is to be updated. The third is a URL the content of the tab is loaded from.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="url"></param>
        public void url(JsNumber index, JsString url) { }

        /// <summary>
        /// Retrieve the number of tabs of the first matched tab pane.
        /// </summary>
        /// <returns></returns>
        public JsNumber length() { return null; }

        /// <summary>
        /// Terminate all running tab ajax requests and animations.
        /// </summary>
        public void abort() { }

        /// <summary>
        /// Set up an automatic rotation through tabs of a tab pane. The second argument is an amount of time in milliseconds until the next tab in the cycle gets activated.
        /// The third controls whether or not to continue the rotation after a tab has been selected by a user. Default: false.
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="continuing"></param>
        public void rotate(JsNumber ms, bool continuing) { }
        /// <summary>
        /// Set up an automatic rotation through tabs of a tab pane. The second argument is an amount of time in milliseconds until the next tab in the cycle gets activated.
        /// The third controls whether or not to continue the rotation after a tab has been selected by a user. Default: false.
        /// </summary>
        /// <param name="ms"></param>
        public void rotate(JsNumber ms) { }


        ///<summary>
        ///This event is triggered when tabs is created.
        ///</summary>
        public jQueryUIEvent<UITabs> create { get; set; }

        ///<summary>
        ///This event is triggered when clicking a tab.
        ///</summary>
        public jQueryUIEvent<UITabs> selectEvent { get; set; }
        //TODO: event name without the"event"

        ///<summary>
        ///This event is triggered after the content of a remote tab has been loaded.
        ///</summary>
        public jQueryUIEvent<UITabs> loadEvent { get; set; }
        //TODO: event name without the"event"

        ///<summary>
        ///This event is triggered when a tab is shown.
        ///</summary>
        public jQueryUIEvent<UITabs> show { get; set; }

        ///<summary>
        ///This event is triggered when a tab is added.
        ///</summary>
        public jQueryUIEvent<UITabs> addEvent { get; set; }
        //TODO: event name without the"event"

        ///<summary>
        ///This event is triggered when a tab is removed.
        ///</summary>
        public jQueryUIEvent<UITabs> removeEvent { get; set; }
        //TODO: event name without the"event"

        ///<summary>
        ///This event is triggered when a tab is enabled.
        ///</summary>
        public jQueryUIEvent<UITabs> enableEvent { get; set; }
        //TODO: event name without the"event"

        ///<summary>
        ///This event is triggered when a tab is disabled.
        ///</summary>
        public jQueryUIEvent<UITabs> disableEvent { get; set; }
        //TODO: event name without the"event"

    }
    #endregion

    [JsType(JsMode.Json)]
    public class AnimationPropertiesEx : Map
    {
        //public JsString backgroundColor { get; set; }
        public JsString borderTopColor { get; set; }
        public JsString borderBottomColor { get; set; }
        public JsString borderLeftColor { get; set; }
        public JsString borderRightColor { get; set; }
        //public JsString color { get; set; }
        public JsString outlineColor { get; set; }

        [JsProperty(Name = "width")]
        public JsNumber widthNumber { get; set; }

    }
    #region Menu
    public static partial class MenuExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery menu(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery menu(this jQuery query, MenuOptions options) { return default(jQuery); }

    }

    /// <summary>
    /// Themeable menu with mouse and keyboard interactions for navigation.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Menu", Export = false)]
    public partial class Menu
    {
        /// <summary>
        /// Removes focus from a menu, resets any active element styles and triggers the menu's blur event.
        /// </summary>
        /// <param name="event">What triggered the menu to blur.</param>
        public void blur(Event @event) { }
        /// <summary>
        /// Removes focus from a menu, resets any active element styles and triggers the menu's blur event.
        /// </summary>
        public void blur() { }

        /// <summary>
        /// Closes the currently active sub-menu.
        /// </summary>
        /// <param name="event">What triggered the menu to collapse.</param>
        public void collapse(Event @event) { }
        /// <summary>
        /// Closes the currently active sub-menu.
        /// </summary>
        public void collapse() { }

        /// <summary>
        /// Closes all open sub-menus.
        /// </summary>
        /// <param name="event">What triggered the menu to collapse.</param>
        /// <param name="all">Indicates whether all sub-menus should be closed or only sub-menus below and including the menu that is or contains the target of the triggering event.</param>
        public void collapseAll(Event @event, bool all) { }
        /// <summary>
        /// Closes all open sub-menus.
        /// </summary>
        /// <param name="event">What triggered the menu to collapse.</param>
        public void collapseAll(Event @event) { }
        /// <summary>
        /// Closes all open sub-menus.
        /// </summary>
        public void collapseAll() { }

        /// <summary>
        /// Removes the menu functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Disables the menu.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enables the menu.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// Opens the sub-menu below the currently active item, if one exists.
        /// </summary>
        /// <param name="event">What triggered the menu to expand.</param>
        public void expand(Event @event) { }
        /// <summary>
        /// Opens the sub-menu below the currently active item, if one exists.
        /// </summary>
        public void expand() { }

        /// <summary>
        /// Activates a particular menu item, begins opening any sub-menu if present and triggers the menu's focus event.
        /// </summary>
        /// <param name="event">What triggered the menu item to gain focus.</param>
        /// <param name="item">The menu item to focus/activate.</param>
        public void focus(Event @event, jQuery item) { }
        /// <summary>
        /// Activates a particular menu item, begins opening any sub-menu if present and triggers the menu's focus event.
        /// </summary>
        /// <param name="event">What triggered the menu item to gain focus.</param>
        public void focus(Event @event) { }
        /// <summary>
        /// Activates a particular menu item, begins opening any sub-menu if present and triggers the menu's focus event.
        /// </summary>
        public void focus() { }

        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the first item in the menu.
        /// </summary>
        /// <returns></returns>
        public bool isFirstItem() { return false; }

        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the last item in the menu.
        /// </summary>
        /// <returns></returns>
        public bool isLastItem() { return false; }

        /// <summary>
        /// Moves active state to next menu item.
        /// </summary>
        /// <param name="event">What triggered the focus to move.</param>
        public void next(Event @event) { }

        /// <summary>
        /// Moves active state to first menu item below the bottom of a scrollable menu or the last item if not scrollable.
        /// </summary>
        /// <param name="event">What triggered the focus to move.</param>
        public void nextPage(Event @event) { }

        /// <summary>
        /// Gets the value currently associated with the specified optionName.
        /// </summary>
        /// <param name="optionName">The name of the option to get.</param>
        /// <returns></returns>
        public object option(JsString optionName) { return null; }
        /// <summary>
        /// Gets an object containing key/value pairs representing the current menu options hash.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }
        /// <summary>
        /// Sets the value of the menu option associated with the specified optionName.
        /// </summary>
        /// <param name="optionName">The name of the option to set.</param>
        /// <param name="value">A value to set for the option.</param>
        public void option(JsString optionName, object value) { }
        /// <summary>
        /// Sets one or more options for the menu.
        /// </summary>
        /// <param name="options">A map of option-value pairs to set.</param>
        public void option(MenuOptions options) { }

        /// <summary>
        /// Moves active state to previous menu item.
        /// </summary>
        /// <param name="event">What triggered the focus to move.</param>
        public void previous(Event @event) { }

        /// <summary>
        /// Moves active state to first menu item above the top of a scrollable menu or the first item if not scrollable.
        /// </summary>
        /// <param name="event">What triggered the focus to move.</param>
        public void previousPage(Event @event) { }

        /// <summary>
        /// Initializes sub-menus and menu items that have not already been initialized.
        /// New menu items, including sub-menus can be added to the menu or all of the contents of the menu can be replaced and then initialized with the refresh() method.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Selects the currently active menu item, collapses all sub-menus and triggers the menu's select event.
        /// </summary>
        /// <param name="event">What triggered the selection.</param>
        public void select(Event @event) { }

        /// <summary>
        /// Returns a jQuery object containing the menu.
        /// </summary>
        /// <returns></returns>
        public jQuery widget() { return null; }

        /// <summary>
        /// Triggered when the menu loses focus.
        /// </summary>
        [JsProperty(Name = "blur")]
        public JsAction<Event, MenuUI> blurEvent { get; set; }

        /// <summary>
        /// Triggered when the menu is created.
        /// </summary>
        public JsAction<Event, MenuUI> create { get; set; }

        /// <summary>
        /// Triggered when a menu gains focus or when any menu item is activated.
        /// </summary>
        [JsProperty(Name = "focus")]
        public JsAction<Event, MenuUI> focusEvent { get; set; }

        /// <summary>
        /// Triggered when a menu item is selected.
        /// </summary>
        [JsProperty(Name = "select")]
        public JsAction<Event, MenuUI> selectEvent { get; set; }

    }


    [JsType(JsMode.Json)]
    public partial class MenuUI
    {
        /// <summary>
        /// The currently active menu item.
        /// </summary>
        public jQuery item { get; set; }
    }

    #endregion
    #region MenuOptions
    [JsType(JsMode.Json)]
    public partial class MenuOptions
    {
        /// <summary>
        /// (Default: false).
        /// Disables the menu if set to true.
        /// </summary>
        public bool disabled { get; set; }
        /// <summary>
        /// (Default: { submenu: "ui-icon-carat-1-e" })
        /// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.
        /// <remarks>
        /// submenu (string, default: "ui-icon-carat-1-e")
        /// </remarks>
        /// </summary>
        public object icons { get; set; }
        /// <summary>
        /// (Default: "ul")
        /// Selector for the elements that serve as the menu container, including sub-menus.
        /// </summary>
        public JsString menues { get; set; }
        /// <summary>
        /// (Default: { my: "top left", at: "top right" })
        /// Identifies the position of submenus in relation to the associated parent menu item. 
        /// The of option defaults to the parent menu item, but you can specify another element to position against.
        /// You can refer to the jQuery UI Position utility for more details about the various options
        /// </summary>
        public object position { get; set; }
        /// <summary>
        /// (Default: "menu").
        /// Customize the ARIA roles used for the menu and menu items. 
        /// The default uses "menuitem" for items. Setting the role option to 
        /// "listbox" will use "option" for items. 
        /// If set to null, no roles will be set, 
        /// which is useful if the menu is being controlled by another element that is maintaining focus.
        /// </summary>
        public JsString role { get; set; }
        public jQueryUIEvent select { get; set; }
    }
    #endregion
    #region Spinner
    public static partial class SpinnerExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery spinner(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery spinner(this jQuery query, SpinnerOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery spinner(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    /// <summary>
    /// Enhance a text input for entering numeric values, with up/down buttons and arrow key handling.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Spinner", Export = false)]
    public partial class Spinner
    {
        /// <summary>
        /// Removes the spinner functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Disables the spinner.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enables the spinner.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// Gets the value currently associated with the specified optionName.
        /// </summary>
        /// <param name="optionName">The name of the option to get.</param>
        /// <returns></returns>
        public object option(JsString optionName) { return null; }
        /// <summary>
        /// Gets an object containing key/value pairs representing the current spinner options hash.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }
        /// <summary>
        /// Sets the value of the spinner option associated with the specified optionName.
        /// </summary>
        /// <param name="optionName">The name of the option to set.</param>
        /// <param name="value">A value to set for the option.</param>
        public void option(JsString optionName, object value) { }
        /// <summary>
        /// Sets one or more options for the spinner.
        /// </summary>
        /// <param name="options">A map of option-value pairs to set.</param>
        public void option(SpinnerOptions options) { }

        /// <summary>
        /// Decrements the value by the specified number of pages, as defined by the page option. Without the parameter, a single page is decremented.
        /// </summary>
        /// <param name="pages">Number of pages to decrement, defaults to 1.</param>
        public void pageDown(JsNumber pages) { }

        /// <summary>
        /// Increments the value by the specified number of pages, as defined by the page option. Without the parameter, a single page is incremented.
        /// </summary>
        /// <param name="pages">Number of pages to increment, defaults to 1.</param>
        public void pageUp(JsNumber pages) { }

        /// <summary>
        /// Decrements the value by the specified number of steps. Without the parameter, a single step is decremented.
        /// If the resulting value is above the max, below the min, or reuslts in a step mismatch, the value will be adjusted to the closest valid value.
        /// </summary>
        /// <param name="steps">Number of steps to decrement, defaults to 1.</param>
        public void stepDown(JsNumber steps) { }

        /// <summary>
        /// Increments the value by the specified number of steps. Without the parameter, a single step is incremented.
        /// If the resulting value is above the max, below the min, or reuslts in a step mismatch, the value will be adjusted to the closest valid value.
        /// </summary>
        /// <param name="steps">Number of steps to decrement, defaults to 1.</param>
        public void stepUp(JsNumber steps) { }

        /// <summary>
        /// Gets the current value as a number. The value is parsed based on the numberFormat and culture options.
        /// </summary>
        /// <returns></returns>
        public JsNumber value() { return null; }
        /// <summary>
        /// Gets the current value as a number. The value is parsed based on the numberFormat and culture options.
        /// </summary>
        /// <param name="value">Type: Number or String
        /// The value to set. If passed as a string, the value is parsed based on the numberFormat and culture options.</param>
        /// <returns></returns>
        public JsNumber value(JsNumber value) { return null; }
        /// <summary>
        /// Gets the current value as a number. The value is parsed based on the numberFormat and culture options.
        /// </summary>
        /// <param name="value">Type: Number or String
        /// The value to set. If passed as a string, the value is parsed based on the numberFormat and culture options.</param>
        /// <returns></returns>
        public JsNumber value(JsString value) { return null; }

        /// <summary>
        /// Returns a jQuery object containing the generated wrapper.
        /// </summary>
        /// <returns></returns>
        public jQuery widget() { return null; }

        /// <summary>
        /// Triggered when the value of the spinner has changed and the input is no longer focused.
        /// </summary>
        public JsAction<Event, SpinnerUI> change { get; set; }

        /// <summary>
        /// Triggered when the spinner is created.
        /// </summary>
        public JsAction<Event, SpinnerUI> create { get; set; }

        /// <summary>
        /// Triggered during increment/decrement (to determine direction of spin compare current value with ui.value).
        /// Can be canceled, preventing the value from being updated.
        /// </summary>
        public JsAction<Event, SpinnerUI> spin { get; set; }

        /// <summary>
        /// Triggered before a spin. Can be canceled, preventing the spin from occurring.
        /// </summary>
        public JsAction<Event, SpinnerUI> start { get; set; }

        /// <summary>
        /// Triggered after a spin.
        /// </summary>
        public JsAction<Event, SpinnerUI> stop { get; set; }

    }
    #endregion
    #region SpinnerOptions
    [JsType(JsMode.Json)]
    public partial class SpinnerOptions
    {
        /// <summary>
        /// Default: null
        /// Sets the culture to use for parsing and formatting the value.
        /// If null, the currently set culture in Globalize is used, see Globalize docs for available cultures.
        /// Only relevant if the numberFormat option is set. Requires Globalize to be included.
        /// </summary>
        public JsString culture { get; set; }

        /// <summary>
        /// Default: false
        /// Disables the spinner if set to true.
        /// </summary>
        public bool disabled { get; set; }

        /// <summary>
        /// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
        /// </summary>
        public SpinnerIconsOptions icons { get; set; }

        /// <summary>
        /// Default: true
        /// Controls the number of steps taken when holding down a spin button.
        /// Multiple types supported:
        /// Boolean: When set to true, the stepping delta will increase when spun incessantly. When set to false, all steps are equal (as defined by the step option).
        /// Function: Receives one parameter: the number of spins that have occurred. Must return the number of steps that should occur for the current spin.
        /// </summary>
        public bool incremental { get; set; }
        /// <summary>
        /// Default: true
        /// Controls the number of steps taken when holding down a spin button.
        /// Multiple types supported:
        /// Boolean: When set to true, the stepping delta will increase when spun incessantly. When set to false, all steps are equal (as defined by the step option).
        /// Function: Receives one parameter: the number of spins that have occurred. Must return the number of steps that should occur for the current spin.
        /// </summary>
        [JsProperty(Name = "incremental")]
        public JsFunc<JsNumber, JsNumber> incrementalFunction { get; set; }

        /// <summary>
        /// Default: null
        /// The maximum allowed value. The element's max attribute is used if it exists and the option is not explicitly set. If null, there is no maximum enforced.
        /// Multiple types supported:
        /// Number: The maximum value.
        /// String: If Globalize is included, the max option can be passed as a string which will be parsed based on the numberFormat and culture options;
        /// otherwise it will fall back to the native parseFloat() method.
        /// </summary>
        public JsNumber max { get; set; }
        /// <summary>
        /// Default: null
        /// The maximum allowed value. The element's max attribute is used if it exists and the option is not explicitly set. If null, there is no maximum enforced.
        /// Multiple types supported:
        /// Number: The maximum value.
        /// String: If Globalize is included, the max option can be passed as a string which will be parsed based on the numberFormat and culture options;
        /// otherwise it will fall back to the native parseFloat() method.
        /// </summary>
        [JsProperty(Name = "max")]
        public JsString maxString { get; set; }

        /// <summary>
        /// Default: null
        /// The minimum allowed value. The element's min attribute is used if it exists and the option is not explicitly set. If null, there is no minimum enforced.
        /// Multiple types supported:
        /// Number: The minimum value.
        /// String: If Globalize is included, the min option can be passed as a string which will be parsed based on the numberFormat and culture options;
        /// otherwise it will fall back to the native parseFloat() method.
        /// </summary>
        public JsNumber min { get; set; }
        /// <summary>
        /// Default: null
        /// The minimum allowed value. The element's min attribute is used if it exists and the option is not explicitly set. If null, there is no minimum enforced.
        /// Multiple types supported:
        /// Number: The minimum value.
        /// String: If Globalize is included, the min option can be passed as a string which will be parsed based on the numberFormat and culture options;
        /// otherwise it will fall back to the native parseFloat() method.
        /// </summary>
        [JsProperty(Name = "min")]
        public JsString minString { get; set; }

        /// <summary>
        /// Default: null
        /// Format of numbers passed to Globalize, if available. Most common are "n" for a decimal number and "C" for a currency value. Also see the culture option.
        /// </summary>
        public JsString numberFormat { get; set; }

        /// <summary>
        /// Default: null
        /// The number of steps to take when paging via the pageUp/pageDown methods.
        /// </summary>
        public JsNumber page { get; set; }

        /// <summary>
        /// Default: null
        /// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods.
        /// The element's step attribute is used if it exists and the option is not explicitly set.
        /// Multiple types supported:
        /// Number: The size of the step.
        /// String: If Globalize is included, the step option can be passed as a string which will be parsed based on the numberFormat and culture options,
        /// otherwise it will fall back to the native parseFloat.
        /// </summary>
        public JsNumber step { get; set; }
        /// <summary>
        /// Default: null
        /// The size of the step to take when spinning via buttons or via the stepUp()/stepDown() methods.
        /// The element's step attribute is used if it exists and the option is not explicitly set.
        /// Multiple types supported:
        /// Number: The size of the step.
        /// String: If Globalize is included, the step option can be passed as a string which will be parsed based on the numberFormat and culture options,
        /// otherwise it will fall back to the native parseFloat.
        /// </summary>
        [JsProperty(Name = "step")]
        public JsString stepString { get; set; }

        /// <summary>
        /// Triggered when the value of the spinner has changed and the input is no longer focused.
        /// </summary>
        public JsAction<Event, SpinnerUI> change { get; set; }

        /// <summary>
        /// Triggered when the spinner is created.
        /// </summary>
        public JsAction<Event, SpinnerUI> create { get; set; }

        /// <summary>
        /// Triggered during increment/decrement (to determine direction of spin compare current value with ui.value).
        /// Can be canceled, preventing the value from being updated.
        /// </summary>
        public JsAction<Event, SpinnerUI> spin { get; set; }

        /// <summary>
        /// Triggered before a spin. Can be canceled, preventing the spin from occurring.
        /// </summary>
        public JsAction<Event, SpinnerUI> start { get; set; }

        /// <summary>
        /// Triggered after a spin.
        /// </summary>
        public JsAction<Event, SpinnerUI> stop { get; set; }
    }
    #endregion
    #region SpinnerIconsOptions

    /// <summary>
    /// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.
    /// </summary>
    [JsType(JsMode.Json)]
    public partial class SpinnerIconsOptions
    {
        /// <summary>
        /// (string, default: "ui-icon-triangle-1-n")
        /// </summary>
        public JsString up { get; set; }

        /// <summary>
        /// (string, default: "ui-icon-triangle-1-s")
        /// </summary>
        public JsString down { get; set; }

    }

    [JsType(JsMode.Json)]
    public partial class SpinnerUI
    {
        /// <summary>
        /// The new value to be set, unless the event is cancelled.
        /// </summary>
        public JsNumber value { get; set; }
    }

    #endregion
    #region Tooltip
    public static partial class TooltipExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery tooltip(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery tooltip(this jQuery query, TooltipOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery tooltip(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    /// <summary>
    /// Customizable, themeable tooltips, replacing native tooltips.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Tooltip", Export = false)]
    public partial class Tooltip
    {
        /// <summary>
        /// Closes a tooltip. If the widget's element is the target, the event argument is optional.
        /// Otherwise you have to pass an event object with the currentTarget property pointing at the target.
        /// </summary>
        /// <param name="event">What triggered the tooltip to close.</param>
        public void close(Event @event) { }

        /// <summary>
        /// Removes the tooltip functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Disables the tooltip.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// Enables the tooltip.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// Programmatically open a tooltip. If the widget's element is the target, the event argument is optional.
        /// Otherwise you have to pass an event object with the currentTarget property pointing at the target.
        /// </summary>
        /// <param name="event">What triggered the tooltip to open.</param>
        public void open(Event @event) { }

        /// <summary>
        /// Gets the value currently associated with the specified optionName.
        /// </summary>
        /// <param name="optionName">The name of the option to get.</param>
        /// <returns></returns>
        public object option(JsString optionName) { return null; }
        /// <summary>
        /// Gets an object containing key/value pairs representing the current tooltip options hash.
        /// </summary>
        /// <returns></returns>
        public object option() { return null; }
        /// <summary>
        /// Sets the value of the spinner option associated with the specified optionName.
        /// </summary>
        /// <param name="optionName">The name of the option to set.</param>
        /// <param name="value">A value to set for the option.</param>
        public void option(JsString optionName, object value) { }
        /// <summary>
        /// Sets one or more options for the tooltip.
        /// </summary>
        /// <param name="options">A map of option-value pairs to set.</param>
        public void option(TooltipOptions options) { }

        /// <summary>
        /// Returns a jQuery object containing the original element.
        /// </summary>
        /// <returns></returns>
        public jQuery widget() { return null; }

        /// <summary>
        /// Triggered when a tooltip is closed, triggered on focusout or mouseleave.
        /// </summary>
        [JsProperty(Name = "close")]
        public JsAction<Event, TooltipUI> closeEvent { get; set; }

        /// <summary>
        /// Triggered when the tooltip is created.
        /// </summary>
        public JsAction<Event, TooltipUI> create { get; set; }

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on focusin or mouseover.
        /// </summary>
        [JsProperty(Name = "open")]
        public JsAction<Event, TooltipUI> openEvent { get; set; }
    }
    #endregion
    #region TooltipOptions

    [JsType(JsMode.Json)]
    public partial class TooltipOptions
    {
        /// <summary>
        /// Default: function returning the title attribute
        /// The content of the tooltip.
        /// When changing this option, you likely need to also change the items option.
        /// Multiple types supported:
        /// Function: A callback which can either return the content directly, or call the first argument, passing in the content, e.g., for Ajax content.
        /// String: A string of HTML to use for the tooltip content.
        /// </summary>
        public JsString content { get; set; }
        /// <summary>
        /// Default: function returning the title attribute
        /// The content of the tooltip.
        /// When changing this option, you likely need to also change the items option.
        /// Multiple types supported:
        /// Function: A callback which can either return the content directly, or call the first argument, passing in the content, e.g., for Ajax content.
        /// String: A string of HTML to use for the tooltip content.
        /// </summary>
        [JsProperty(Name = "content")]
        public JsAction contentFunction { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: false
        /// Disables the tooltip if set to true.
        /// </summary>
        public bool disabled { get; set; }

        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        public bool hide { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        [JsProperty(Name = "hide")]
        public JsNumber hideNumber { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        [JsProperty(Name = "hide")]
        public JsString hideString { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the hiding of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be hidden immediately.
        /// When set to true, the tooltip will fade out with the default duration and the default easing.
        /// Number: The tooltip will fade out with the specified duration and the default easing.
        /// String: The tooltip will be hidden using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        [JsProperty(Name = "hide")]
        public object hideObject { get; set; }

        /// <summary>
        /// Default: [title]
        /// A selector indicating which items should show tooltips.
        /// Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.
        /// When changing this option, you likely need to also change the content option.
        /// </summary>
        public JsString items { get; set; }

        /// <summary>
        /// Default: { my: "left+15 center", at: "right center", collision: "flipfit" }
        /// Configuration for the Position utility. The of property defaults to the target element, but can also be overriden.
        /// </summary>
        public object position { get; set; }

        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        public bool show { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        [JsProperty(Name = "show")]
        public JsNumber showNumber { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        [JsProperty(Name = "show")]
        public JsString showString { get; set; }
        /// <summary>
        /// Default: null
        /// If and how to animate the showing of the tooltip.
        /// Multiple types supported:
        /// Boolean: When set to false, no animation will be used and the tooltip will be shown immediately.
        /// When set to true, the tooltip will fade in with the default duration and the default easing.
        /// Number: The tooltip will fade in with the specified duration and the default easing.
        /// String: The tooltip will be shown using the specified effect.
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold".
        /// In either case the effect will be used with the default duration and the default easing.
        /// Object: If the value is an object, then effect, duration, and easing properties may be provided.
        /// If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect.
        /// When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect.
        /// If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        [JsProperty(Name = "show")]
        public object showObject { get; set; }

        /// <summary>
        /// Default: null
        /// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.
        /// This may get replaced by the classes option.
        /// </summary>
        public JsString tooltipClass { get; set; }

        /// <summary>
        /// Default: false
        /// Whether the tooltip should track (follow) the mouse.
        /// </summary>
        public bool track { get; set; }

        /// <summary>
        /// Triggered when a tooltip is closed, triggered on focusout or mouseleave.
        /// </summary>
        public JsAction<Event, TooltipUI> close { get; set; }

        /// <summary>
        /// Triggered when the tooltip is created.
        /// </summary>
        public JsAction<Event, TooltipUI> create { get; set; }

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on focusin or mouseover.
        /// </summary>
        public JsAction<Event, TooltipUI> open { get; set; }

    }
    #endregion
    #region TooltipUI

    [JsType(JsMode.Json)]
    public partial class TooltipUI
    {
        /// <summary>
        /// The generated tooltip element.
        /// </summary>
        public jQuery tooltip { get; set; }
    }

    #endregion
    #region Widget
    public static partial class WidgetExtention
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "jQuery.Widget")]
        public static jQuery Widget(this jQuery query, JsString name, WidgetOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "jQuery.Widget")]
        public static jQuery Widget(this jQuery query, JsString name, JsAction @base, WidgetOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true, Name = "jQuery.Widget")]
        public static jQuery Widget(this jQuery query, JsString name, params object[] args) { return default(jQuery); }
    }
    #endregion Widget

    


    #region WidgetOptions
    [JsType(JsMode.Json)]
    public partial class WidgetOptions
    {
        /// <summary>
        /// Disables the jQuery.Widget if set to true.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the disabled option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ disabled: true });
        /// </code>
        /// Get or set the disabled option, after initialization:
        /// <code>
        /// // getter
        /// var disabled = $( ".selector" ).jQuery.Widget( "option", "disabled" ); 
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "disabled", true );
        /// </code>
        /// </example>
        public bool disabled { get; set; }
        /// <summary>
        /// When set to false, no animation will be used and the element will be hidden immediately. When set to true, the element will fade out with the default duration and the default easing.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the hide option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ hide: { effect: "explode", duration: 1000 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the hide option, after initialization:
        /// <code>
        /// // getter
        /// var hide = $( ".selector" ).jQuery.Widget( "option", "hide" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "hide", { effect: "explode", duration: 1000 } );
        /// </code>
        /// </example>
        [JsProperty(Name = "hide")]
        public bool hideBoolean { get; set; }
        /// <summary>
        /// The element will fade out with the specified duration and the default easing.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the hide option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ hide: { effect: "explode", duration: 1000 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the hide option, after initialization:
        /// <code>
        /// // getter
        /// var hide = $( ".selector" ).jQuery.Widget( "option", "hide" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "hide", { effect: "explode", duration: 1000 } );
        /// </code>
        /// </example>
        [JsProperty(Name = "hide")]
        public JsNumber hideNumber { get; set; }
        /// <summary>
        /// The element will be hidden using the specified effect. 
        /// The value can either be the name of a built-in jQuery animateion method, such as "slideUp", or the name of a jQuery UI effect, such as "fold". 
        /// In either case the effect will be used with the default duration and the default easing.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the hide option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ hide: { effect: "explode", duration: 1000 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the hide option, after initialization:
        /// <code>
        /// // getter
        /// var hide = $( ".selector" ).jQuery.Widget( "option", "hide" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "hide", { effect: "explode", duration: 1000 } );
        /// </code>
        /// </example>
        [JsProperty(Name = "hide")]
        public JsString hideString { get; set; }
        /// <summary>
        ///  If the value is an object, then effect, duration, and easing properties may be provided. If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect. When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect. If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeOut" will be used.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the hide option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ hide: { effect: "explode", duration: 1000 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the hide option, after initialization:
        /// <code>
        /// // getter
        /// var hide = $( ".selector" ).jQuery.Widget( "option", "hide" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "hide", { effect: "explode", duration: 1000 } );
        /// </code>
        /// </example>
        public object hide { get; set; }
        /// <summary>
        /// When set to false, no animation will be used and the element will be shown immediately. When set to true, the element will fade in with the default duration and the default easing.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the show option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ show: { effect: "explode", duration: 1000 } });
        /// </code>
        /// <example>
        /// Initialize the jQuery.Widget with the show option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ show: { effect: "blind", duration: 800 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the show option, after initialization:
        /// <code>
        /// // getter
        /// var show = $( ".selector" ).jQuery.Widget( "option", "show" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "show", { effect: "blind", duration: 800 } );
        /// </code>
        /// </example>
        [JsProperty(Name = "show")]
        public bool showBoolean { get; set; }
        /// <summary>
        /// The element will fade in with the specified duration and the default easing.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the show option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ show: { effect: "blind", duration: 800 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the show option, after initialization:
        /// <code>
        /// // getter
        /// var show = $( ".selector" ).jQuery.Widget( "option", "show" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "show", { effect: "blind", duration: 800 } );
        /// </code>
        /// </example>
        [JsProperty(Name = "show")]
        public JsNumber showNumber { get; set; }
        /// <summary>
        /// The element will be shown using the specified effect. The value can either be the name of a built-in jQuery animateion method, such as "slideDown", or the name of a jQuery UI effect, such as "fold". In either case the effect will be used with the default duration and the default easing.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the show option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ show: { effect: "explode", duration: 1000 } });
        /// </code>
        /// <example>
        /// Initialize the jQuery.Widget with the show option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ show: { effect: "blind", duration: 800 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the show option, after initialization:
        /// <code>
        /// // getter
        /// var show = $( ".selector" ).jQuery.Widget( "option", "show" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "show", { effect: "blind", duration: 800 } );
        /// </code>
        /// </example>
        [JsProperty(Name = "show")]
        public JsString showString { get; set; }
        /// <summary>
        ///  If the value is an object, then effect, duration, and easing properties may be provided. If the effect property contains the name of a jQuery method, then that method will be used; otherwise it is assumed to be the name of a jQuery UI effect. When using a jQuery UI effect that supports additional settings, you may include those settings in the object and they will be passed to the effect. If duration or easing is omitted, then the default values will be used. If effect is omitted, then "fadeIn" will be used.
        /// </summary>
        /// <example>
        /// Initialize the jQuery.Widget with the show option specified:
        /// <code>
        /// $( ".selector" ).jQuery.Widget({ show: { effect: "blind", duration: 800 } });
        /// </code>
        /// </example>
        /// <example>
        /// Get or set the show option, after initialization:
        /// <code>
        /// // getter
        /// var show = $( ".selector" ).jQuery.Widget( "option", "show" );
        ///  
        /// // setter
        /// $( ".selector" ).jQuery.Widget( "option", "show", { effect: "blind", duration: 800 } );
        /// </code>
        /// </example>
        public object show { get; set; }


    }
    #endregion



}