using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Scriptaculous
{
    #region Controls

    [JsType(JsMode.Prototype, Name = "Ajax.Autocompleter", Export = false)]
    public class Autocompleter
    {
        public static void test(JsString con) { }
    }

    /// <summary>
    /// Ajax.Autocompleter allows for server-powered autocompleting text fields.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AutocompleterOptions : AjaxOptions
    {
        /// <summary>
        /// Name of the parameter for the string typed by the user on the autocompletion field
        /// </summary>
        public JsString paramName { get; set; }

        /// <summary>
        /// Tokenized incremental autocompletion is enabled automatically when an autocompleter is instantiated with the ‘tokens’ option in the options parameter:
        /// See Also Autocompleter.Base
        /// </summary>
        public JsArray tokens { get; set; }

        /// <summary>
        /// Default : 0.4
        /// How frequently (in seconds) the input field should be polled for changes before firing an Ajax request.
        /// </summary>
        public JsNumber frequency { get; set; }

        /// <summary>
        /// Default : 1
        /// The minimum number of characters that must be entered in the input field before an Ajax request is made.
        /// </summary>
        public JsNumber minChars { get; set; }

        /// <summary>
        /// The class name of the element that contains the text to be placed into the input box. By default all text will be used.
        /// </summary>
        public JsString select { get; set; }

        /// <summary>
        /// The HTML id of an element to display (using Element.show) while the Ajax request is in progress.
        /// This element will be hidden with Element.hide when the request is completed.
        /// This is useful for displaying an animated spinner during processing. See Ajaxload for some image examples.
        /// </summary>
        public JsString indicator { get; set; }

        /// <summary>
        /// Hook for a custom function to replace the built-in function that adds the list item text to the input field.
        /// The custom function is called after the element has been updated (i.e. when the user has selected an entry).
        /// The function receives one parameter only: the selected item (the &lt;li> item selected)
        /// </summary>
        public JsString updateElement { get; set; }

        /// <summary>
        /// Hook for a custom function that’s called following the execution of the built-in function that adds the list item text to the input field,
        /// which happens after a user has selected an entry.
        /// (The difference between updateElement and afterUpdateElement is that updateElement replaces the built-in Autocompleter function; afterUpdateElement supplements that built-in function.)
        /// The function receives two parameters, the input field specified for autocompletion, and the selected item (the &lt;li> item selected)
        /// </summary>
        public JsString afterUpdateElement { get; set; }

        /// <summary>
        /// This function is called just before the Request is actually made, allowing you to modify the querystring that is sent to the server.
        /// The function receives the completer’s input field and the default querystring (‘value=XXX’) as parameters.
        /// You should return the querystring you want used, including the default part.
        /// </summary>
        public JsAction<JsString, object> callback { get; set; }
        //TODO: must check

        /// <summary>
        /// To send additional parameters to the server, add them here in the format: 'field=value&amp;another=value'.
        /// Errata/bug: The hash format {field: 'value',another: 'value'} was noted in this wiki to work, but it does not,
        /// as the Ruby on Rails project has separately documented and fixed in their codebase.
        /// </summary>
        public JsString parameters { get; set; }
        //TODO: must check
    }


    /// <summary>
    /// This constructor generates a Flickr-style AJAX-based “on-the-fly” fields with a select box instead of Ajax.InPlaceEditor text fields.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.InPlaceCollectionEditor", Export = false)]
    public class InPlaceCollectionEditor
    {
        /// <summary>
        /// The constructor takes three parameters. The first is the element that should support in-place editing.
        /// The second is the url to submit the changed value to. The server should respond with the updated value
        /// (the server might have post-processed it or validation might have prevented it from changing).
        /// The third is a hash of options. Within that hash of options should be a field called collection that is an array of values to place inside your select box.
        /// The server side component gets the new value as the parameter ‘value’ (POST method), and should send the new value as the body of the response.
        /// If the collection parameter (or the result of the loadCollectionURL) is a one-dimensional array,
        /// the option tag’s value attribute will be the same as the label. For explicit value attributes,
        /// use a two dimensional array for the collection where the second dimension is a key value pair such as [['key', 'value'], ['key', 'value']].
        /// </summary>
        /// <param name="element"> The first is the element that should support in-place editing.</param>
        /// <param name="url"> The second is the url to submit the changed value to.</param>
        /// <param name="config"> The third is a hash of options.
        /// Within that hash of options should be a field called collection that is an array of values to place inside your select box.</param>
        public InPlaceCollectionEditor(HtmlElement element, JsString url, InPlaceCollectionEditorOptions config) { }
    }

    [JsType(JsMode.Json)]
    public class InPlaceCollectionEditorOptions : InPlaceEditorOptions
    {
        /// <summary>
        /// Array of static elements to be displayed as options (in JSON format)
        /// </summary>
        public JsArray<HtmlElement> collection { get; set; }

        /// <summary>
        /// Loads values and tag texts for the &lt;option> tags
        /// </summary>
        public JsString loadCollectionURL { get; set; }

        /// <summary>
        /// Text to be displayed while the collection is loading
        /// </summary>
        public JsString loadingCollectionText { get; set; }

        /// <summary>
        /// Class applied to form while the collection is loading
        /// </summary>
        public JsString loadingClassName { get; set; }

        ///// <summary>
        /////  Within that hash of options should be a field called collection that is an array of values to place inside your select box.
        ///// </summary>
        //public JsArray<JsArray<JsString>> collection { get; set; }
        //TODO: there is allreay a propertye named collection. wich is the reight one?
    }


    /// <summary>
    /// The in-place “text edit” testing allows for Flickr-style AJAX-backed “on-the-fly” textfields.
    /// See the documentation on Ajax.InPlaceEditor and Ajax.InPlaceCollectionEditor
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Ajax.InPlaceEditor", Export = false)]
    public class InPlaceEditor
    {
        /// <summary>
        /// The constructor takes three parameters.
        /// The first is the element that should support in-place editing.
        /// The second is the url to submit the changed value to. The server should respond with the updated value
        /// (the server might have post-processed it or validation might have prevented it from changing).
        /// The third is a hash of options.
        /// The server side component gets the new value as the parameter ‘value’ (POST method), and should send the new value as the body of the response.
        /// </summary>
        /// <param name="element">The first is the element that should support in-place editing.</param>
        /// <param name="url">The second is the url to submit the changed value to. The server should respond with the updated value</param>
        /// <param name="options">The third is a hash of options.</param>
        public InPlaceEditor(HtmlElement element, JsString url, InPlaceEditorOptions options) { }
    }

    [JsType(JsMode.Json)]
    public class InPlaceEditorOptions
    {
        /// <summary>
        /// Default : “button”
        /// What type of ok button to use in edit mode, or none at all (button, link, false)
        /// </summary>
        public JsString okControl { get; set; }

        /// <summary>
        /// Default : “link”
        /// What type of cancel button to use in edit mode, or none at all (button, link, false)
        /// </summary>
        public JsString cancelControl { get; set; }

        /// <summary>
        /// Default : “ok”
        /// The text of the submit button that submits the changed value to the server
        /// </summary>
        public JsString okText { get; set; }

        /// <summary>
        /// Default : “cancel”
        /// The text of the link that cancels editing
        /// </summary>
        public JsString cancelText { get; set; }

        /// <summary>
        /// Default : “Saving…”
        /// The text shown while the text is sent to the server
        /// </summary>
        public JsString savingText { get; set; }

        /// <summary>
        /// Default : “Click to edit”
        /// The text shown during mouseover the editable text
        /// </summary>
        public JsString clickToEditText { get; set; }

        /// <summary>
        /// Default : id of the element to edit plus ‘InPlaceForm’
        /// The id given to the element
        /// </summary>
        public object formId { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : null
        /// ID of an element that acts as an external control used to enter edit mode.
        /// The external control will be hidden when entering edit mode and shown again when leaving edit mode.
        /// </summary>
        public JsString externalControl { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : false
        /// Whether or not to disable onclick editing so that only an external control can activate editable mode
        /// </summary>
        public bool externalControlOnly { get; set; }

        /// <summary>
        /// Default : 1
        /// The row height of the input field (anything greater than 1 uses a multiline textarea for input)
        /// </summary>
        public JsNumber rows { get; set; }

        /// <summary>
        /// Default : “function(transport, element) {new Effect.Highlight(element, {startcolor: this.options.highlightColor});}”
        /// Code run if update successful with server. Also if user cancels the form. See bug.
        /// </summary>
        public JsCode onComplete { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : “function(transport) {alert(“Error communicating with the server: ” + transport.responseText.stripTags());}”
        /// Code run if update failed with server
        /// </summary>
        public JsCode onFailure { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : none
        /// The number of columns the text area should span (works for both single line or multi line)
        /// </summary>
        public JsNumber cols { get; set; }

        /// <summary>
        /// Default : none
        /// Synonym for ‘cols’ when using single-line (rows=1) input
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// Default : Ajax.InPlaceEditor.defaultHighlightColor
        /// The highlight color. Must be six hex digits, not 3.
        /// </summary>
        public object highlightColor { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : ”#FFFFFF”
        /// The color which the highlight fades to. Must be six hex digits, not 3.
        /// </summary>
        public JsString highlightEndColor { get; set; }

        /// <summary>
        /// Default : “inplaceeditor-saving”
        /// CSS class added to the element while displaying “Saving…” (removed when server responds)
        /// </summary>
        public JsString savingClassName { get; set; }

        /// <summary>
        /// Default : “inplaceeditor-form”
        /// CSS class used for the in place edit form
        /// </summary>
        public JsString formClassName { get; set; }

        /// <summary>
        /// Default : ?
        /// </summary>
        public JsString hoverClassName { get; set; }

        /// <summary>
        /// Default : null
        /// Will cause the text to be loaded from the server (useful if your text is actually textile and formatted on the server)
        /// </summary>
        public JsString loadTextURL { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : “Loading…”
        /// If the loadText URL option is specified then this text is displayed while the text is being loaded from the server
        /// </summary>
        public JsString loadingText { get; set; }

        /// <summary>
        /// Default : function(form) {Form.serialize(form)}
        /// A function that will get executed just before the request is sent to the server, should return the parameters to be sent in the URL.
        /// Will get two parameters, the entire form and the value of the text control.
        /// </summary>
        public JsFunc<object, object, object> callback { get; set; }
        //TODO: type?

        /// <summary>
        /// Default : “false”
        /// This option if true will submit the in_place_edit form when the input tag loses focus.
        /// </summary>
        public bool submitOnBlur { get; set; }

        /// <summary>
        /// Default : Options specified to all AJAX calls (loading and saving text), these options are passed through to the prototype AJAX classes.
        /// </summary>
        public AjaxOptions ajaxOptions { get; set; }
    }


    /// <summary>
    /// All Ajax classes share a common set of options and callbacks.
    /// Callbacks are called at various points in the life-cycle of a request, and always feature the same list of arguments.
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
        /// The parameters for the request, which will be encoded into the URL for a get method, or into the request body for the other methods.
        /// This can be provided either as a URL-encoded string, a Hash, or a plain Object.
        /// </summary>
        public object parameters { get; set; }

        /// <summary>
        /// Specific contents for the request body on a post method. If it is not provided, the contents of the parameters option will be used instead.
        /// </summary>
        public JsString postBody { get; set; }

        /// <summary>
        /// A set of key-value pairs, with properties representing header names.
        /// </summary>
        public object requestHeaders { get; set; }
        //TODO: type?

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

        //TODO: callbacks
    }

    //TODO: Autocompleter.Base

    /// <summary>
    /// The local array autocompleter. Used when you’d prefer to inject an array of autocompletion options into the page, rather than sending out Ajax queries.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Autocompleter.Local", Export = false)]
    public class Local
    {
        /// <summary>
        /// The constructor takes four parameters.
        /// The first two are, as usual, the id of the monitored textbox, and id of the autocompletion menu.
        /// The third is an array of strings that you want to autocomplete from, and the fourth is the options block.
        /// </summary>
        /// <param name="id_of_text_field"></param>
        /// <param name="id_of_div_to_populate"></param>
        /// <param name="array_of_strings"></param>
        /// <param name="options"></param>
        public Local(JsString id_of_text_field, JsString id_of_div_to_populate, JsArray<JsString> array_of_strings, LocalOptions options) { }
    }

    [JsType(JsMode.Json)]
    public class LocalOptions : AjaxOptions
    {
        /// <summary>
        /// Default : 10
        /// How many autocompletion choices to offer
        /// </summary>
        public JsNumber choices { get; set; }

        /// <summary>
        /// Default :true
        /// If false, the autocompleter will match entered text only at the beginning of strings in the autocomplete array.
        /// Defaults to true, which will match text at the beginning of any word in the strings in the autocomplete array.
        /// If you want to search anywhere in the string, additionally set the option fullSearch to true
        /// </summary>
        public bool partialSearch { get; set; }

        /// <summary>
        /// Default :false
        /// Search anywhere in autocomplete array strings.
        /// </summary>
        public bool fullSearch { get; set; }

        /// <summary>
        /// Default :2
        /// How many characters to enter before triggering a partial match (unlike minChars, which defines how many characters are required to do any match at all).
        /// </summary>
        public JsNumber partialChars { get; set; }

        /// <summary>
        /// Default : true
        /// Whether to ignore case when autocompleting
        /// </summary>
        public bool ignoreCase { get; set; }

        /// <summary>
        /// It’s possible to pass in a custom function as the ‘selector’ option, if you prefer to write your own autocompletion logic.
        /// In that case, the other options above will not apply unless you support them.
        /// </summary>
        public JsAction selector { get; set; }
    }
    //TOSO: not sure it Inherite from AjaxOptions

    /// <summary>
    /// A slider control which can be used to select a single or multiple values from a given range, or even set of values.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Control.Slider", Export = false)]
    public class Slider
    {
        /// <summary>
        /// To make a slider element, you create a new instance of class Control.Slider.
        /// handles can either be a single id (or element) or, if you want more than one handle, an array of ids (or elements). track is either id or element.
        /// </summary>
        /// <param name="handles"></param>
        /// <param name="track"></param>
        /// <param name="options"></param>
        public Slider(object handles, object track, SliderOptions options) { }
        /// <summary>
        /// To make a slider element, you create a new instance of class Control.Slider.
        /// handles can either be a single id (or element) or, if you want more than one handle, an array of ids (or elements). track is either id or element.
        /// </summary>
        /// <param name="handles"></param>
        /// <param name="track"></param>
        public Slider(object handles, object track) { }


    }

    [JsType(JsMode.Json)]
    public class SliderOptions
    {
        /// <summary>
        /// Default: horizontal
        /// Sets the direction that the slider will move in. It should either be horizontal or vertical.
        /// </summary>
        public DirectionType axis { get; set; }

        /// <summary>
        /// Default: 1	
        /// Defines the relationship of value to pixels. Setting this to 1 will mean each movement of 1 pixel equates to 1 value.
        /// </summary>
        public JsNumber increment { get; set; }

        /// <summary>
        /// Default: (none)	
        /// Length of track in pixels adjusted by increment.
        /// The maximum value that the slider will move to. For horizontal this is to the right while vertical it is down.
        /// </summary>
        public JsNumber maximum { get; set; }

        /// <summary>
        /// Default: 0
        /// The minimum value that the slider can move to.
        /// For horizontal this is to the left while vertical it is up. Note: this also sets the beginning of the slider (zeroes it out).
        /// </summary>
        public JsNumber minimum { get; set; }

        /// <summary>
        /// Default: (none)	
        /// Use the $R(min,max)
        /// </summary>
        public object range { get; set; }
        //TODO: type?

        /// <summary>
        /// Default:0	
        /// This will move the starting point on the x-axis for the handle in relation to the track.
        /// It is often used to move the ‘point’ of the handle to where 0 should be. It can also be used to set a different starting point on the track.
        /// </summary>
        public JsNumber alignX { get; set; }

        /// <summary>
        /// Default:0	
        /// This will move the starting point on the y-axis for the handle in relation to the track.
        /// It is often used to move the ‘point’ of the handle to where 0 should be. It can also be used to set a different starting point on the track.
        /// </summary>
        public JsNumber alignY { get; set; }

        /// <summary>
        /// Default: 0	
        /// Will set the initial slider value. The handle will be set to this value, assuming it is within the minimum and maxium values.
        /// </summary>
        public JsNumber sliderValue { get; set; }

        /// <summary>
        /// Default:(none)	 
        /// This will lock the slider so that it will not move and thus is disabled.
        /// </summary>
        public object disabled { get; set; }
        //TODO: type?

        /// <summary>
        /// Default:(none)	 
        /// The id of the image that represents the handle. This is used to swap out the image src with disabled image src when the slider is enabled.
        /// </summary>
        public JsString handleImage { get; set; }

        /// <summary>
        /// Default: (none)	
        /// The id of the image that represents the disabled handle. This is used to change the image src when the slider is disabled.
        /// </summary>
        public JsString handleDisabled { get; set; }

        /// <summary>
        /// Default: (none)	
        /// Accepts an array of integers.
        /// If set these will be the only legal values for the slider to be at. Thus you can set specific slider values that the user can move the slider to.
        /// </summary>
        public JsArray<JsNumber> values { get; set; }

        /// <summary>
        /// Default: (none)	 
        /// An array of ids or elements which are positioned between handles. This is used only when slider has more than one handle.
        /// </summary>
        public JsArray<JsString> spans { get; set; }
        /// <summary>
        /// Default: (none)	 
        /// An array of ids or elements which are positioned between handles. This is used only when slider has more than one handle.
        /// </summary>
        [JsProperty(Name = "spans")]
        public JsArray<HtmlElement> spansElementArray { get; set; }

        /// <summary>
        /// Default: false	
        /// Used only for multiple handles, when restricted is true, handle(s) with greater indexes are not allowed to have values less than handles with smaller indexes.
        /// When restricted is false, handles can be moved independently from others.
        /// </summary>
        public bool restricted { get; set; }

        /// <summary>
        /// Will update the slider’s value and thus move the slider handle to the appropriate position.
        /// handleIndex is optional, when it is not passed then ‘active’ (last-dragged/used) handle is used.
        /// NOTE: when using setValue, the onChange callback function is called.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="handleIndex"></param>
        public static void setValue(object value, JsNumber handleIndex) { }
        //TODO: check
        /// <summary>
        /// Will update the slider’s value and thus move the slider handle to the appropriate position.
        /// handleIndex is optional, when it is not passed then ‘active’ (last-dragged/used) handle is used.
        /// NOTE: when using setValue, the onChange callback function is called.
        /// </summary>
        /// <param name="value"></param>
        public static void setValue(object value) { }
        //TODO: check

        /// <summary>
        /// Will set the slider to the disabled state (disabled = true).
        /// </summary>
        /// <param name="disabled"></param>
        public static void setDisabled(bool disabled) { }
        //TODO: check

        /// <summary>
        /// Will set the slider to the enabled state (disabled = false).
        /// </summary>
        /// <param name="disabled"></param>
        public static void setEnabled(bool disabled) { }
        //TODO: check

        //TODO: callbacks 

    }


    #endregion

    #region Behaviours

    /// <summary>
    /// To make an element draggable, create a new instance of class Draggable.
    /// For additional built-in functionality, make a Sortable instead.
    /// There is also a class named Draggables that exposes functions for observing drag actions.
    /// Draggables become much more useful when you use them with droppables, which are the areas that you can drag draggables to.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Behaviours.Draggable", Export = false)]
    public class Draggable
    {
        public Draggable(JsString id_of_element, DraggableOptions options) { }
        public Draggable(JsString id_of_element) { }

    }

    [JsType(JsMode.Json)]
    public class Draggables
    {
        /// <summary>
        /// Array of all Draggables on the page
        /// </summary>
        public JsArray<Draggables> drags { get; set; }

        /// <summary>
        /// function(draggable). Called when you create a new Draggable?.
        /// If this is the first Draggable on the page, starts observing mouse events necessary for dragging.
        /// </summary>
        public JsArray<object> observers { get; set; }
        //TODO: type?

        /// <summary>
        /// function(draggable). Called when you create a new Draggable?. If this is the first Draggable on the page, starts observing mouse events necessary for dragging.
        /// </summary>
        /// <returns></returns>
        public JsArray<Draggable> register() { return null; }
        //TODO: was eritten "function(draggable)" with no big latter (?)

        /// <summary>
        /// function(draggable). Called by Draggable.destroy()?.
        /// Stops observing window mouse events if Draggable.drag is empty.
        /// </summary>
        /// <returns></returns>
        public JsArray<Draggable> unregister() { return null; }
        //TODO: was eritten "function(draggable)" with no big latter (?)

        /// <summary>
        /// Marks a particular Draggable as the activeDraggable
        /// </summary>
        public void activate() { }

        /// <summary>
        /// Sets Draggables.activeDraggable to @null
        /// </summary>
        public void deactivate() { }

        /// <summary>
        /// Passes the window mousemove event to the @activeDraggable@’s updateDrag function.
        /// </summary>
        public void updateDrag() { }

        /// <summary>
        /// Caught by the window’s mouseup, stops dragging the activeDraggable, if any, via its endDrag function.
        /// </summary>
        public void endDrag() { }

        /// <summary>
        /// Passes the window keypress event to the @activeDraggable@’s keyPress function.
        /// </summary>
        public void keyPress() { }

        /// <summary>
        /// Adds an observer to Draggables.observers
        /// </summary>
        public void addObserver() { }

        /// <summary>
        /// Removes an observer from Draggables.observers. Takes the observer’s element property as a parameter
        /// </summary>
        public void removeObserver() { }

        /// <summary>
        /// Calls the observers’ onStart(), onEnd(), and onDrag() functions as necessary
        /// </summary>
        public void notify() { }

        //TODO: callbacks


    }

    [JsType(JsMode.Json)]
    public class DraggableOptions
    {
        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        [JsProperty(Name = "handle")]
        public JsString handleString { get; set; }
        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        public HtmlElement handle { get; set; }

        /// <summary>
        /// boolean or function reference, defaults to false.
        /// Revert can also be an arbitrary function reference, called when the drag ends.
        /// Specifying 'failure' will instruct the draggable not to revert if successfully dropped in a droppable.
        /// </summary>
        public bool revert { get; set; }
        /// <summary>
        /// boolean or function reference, defaults to false.
        /// Revert can also be an arbitrary function reference, called when the drag ends.
        /// Specifying 'failure' will instruct the draggable not to revert if successfully dropped in a droppable.
        /// </summary>
        [JsProperty(Name = "revert")]
        public JsAction revertFunction { get; set; }
        //TODO: check

        /// <summary>
        /// If set to false no snapping occurs.
        /// Otherwise takes one of the following forms – Δi: one delta value for both horizontal and vertical snap, [Δx, Δy]: delta values for horizontal and vertical snap,
        /// function(x, y, draggable_object) { return [x, y]; }: a function that receives the proposed new top left
        /// coordinate pair and returns the coordinate pair to actually be used.
        /// </summary>
        public bool snap { get; set; }

        /// <summary>
        /// integer value, defaults to 1000. The css z-index of the draggable item.
        /// </summary>
        public JsNumber zindex { get; set; }

        /// <summary>
        /// string, not set by default. If set to 'horizontal' or 'vertical' the drag will be constrained to take place only horizontally or vertically.
        /// </summary>
        public JsString constraint { get; set; }

        /// <summary>
        /// boolean, defaults to false. Clones the element and drags the clone, leaving the original in place until the clone is dropped.
        /// </summary>
        public bool ghosting { get; set; }

        /// <summary>
        /// Effect, defaults to Effect.Opacity. Defines the effect to use when the draggable starts being dragged.
        /// </summary>
        public Effect starteffect { get; set; }

        /// <summary>
        /// Effect, default to Effect.Move. Defines the effect to use when the draggable reverts back to its starting position.
        /// </summary>
        public Effect reverteffect { get; set; }

        /// <summary>
        /// Effect, defaults to Effect.Opacity. Defines the effect to use when the draggable stops being dragged.
        /// </summary>
        public Effect endeffect { get; set; }

        /// <summary>
        /// string or DOM reference, not set by default. Specifies the element which will scroll when you get to the boundary. By default this is turned off.
        /// </summary>
        [JsProperty(Name = "scroll")]
        public JsString scrollString { get; set; }
        /// <summary>
        /// string or DOM reference, not set by default. Specifies the element which will scroll when you get to the boundary. By default this is turned off.
        /// </summary>
        public HtmlElement scroll { get; set; }

        /// <summary>
        /// integer value, defaults to 20 pixels. Minimum distance from the element boundary to start scrolling.
        /// </summary>
        public JsNumber scrollSensitivity { get; set; }

        //TODO: callbacks

    }


    /// <summary>
    /// To make an element react when a Draggable is dropped onto it, you’ll add it to the Droppables of the page with the Droppables.add class method.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Behaviours.Droppables", Export = false)]
    public class Droppables
    {
        public static Droppables add(JsString id_of_element, DroppablesOptions options) { return null; }
        public static Droppables add(JsString id_of_element) { return null; }
    }

    [JsType(JsMode.Json)]
    public class DroppablesOptions
    {
        /// <summary>
        /// Set accept to a string or an array of strings describing CSS classes.
        /// The Droppable will only accept Draggables that have one or more of these CSS classes.
        /// </summary>
        public JsString accept { get; set; }
        /// <summary>
        /// Set accept to a string or an array of strings describing CSS classes.
        /// The Droppable will only accept Draggables that have one or more of these CSS classes.
        /// </summary>
        [JsProperty(Name = "accept")]
        public JsArray<JsString> acceptArray { get; set; }

        /// <summary>
        /// The droppable will only accept the Draggable if the Draggable is contained in the given elements (or element ids).
        /// Can be a single element or an array of elements. This option is used by Sortables to control Drag-and-Drop between Sortables.
        /// </summary>
        public HtmlElement containment { get; set; }
        /// <summary>
        /// The droppable will only accept the Draggable if the Draggable is contained in the given elements (or element ids).
        /// Can be a single element or an array of elements. This option is used by Sortables to control Drag-and-Drop between Sortables.
        /// </summary>
        [JsProperty(Name = "containment")]
        public JsArray<JsString> containmentArray { get; set; }

        /// <summary>
        /// if set, the Droppable will have this additional CSS class when an accepted Draggable is hovered over it.
        /// </summary>
        public object hoverclass { get; set; }
        //TODO: type?

        /// <summary>
        /// If set to ‘horizontal’ or ‘vertical’ the droppable will only react to a Draggable if its overlapping by more than 50% in the given direction. Used by Sortables.
        /// </summary>
        public object overlap { get; set; }
        //TODO: type?

        /// <summary>
        /// OBSOLETE starting at v1.6.1 (mid-2006) boolean, defaults to true, stops processing hovering (don’t look for other Droppables that are under the Draggable)
        /// </summary>
        public bool greedy { get; set; }

        //TODO: callback
    }


    [JsType(JsMode.Prototype, Name = "Behaviours.Sortable", Export = false)]
    public class Sortable
    {
        /// <summary>
        /// Use Sortable.create('id_of_container',[options]); to create new Sortables.
        /// See Sortable.create. Furthermore, there are special requirements to get sortables to work in FF3 which are also covered in Sortable.create.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static Sortable create(JsString id_of_container, SortableCreateOptions options) { return null; }
        /// <summary>
        /// Use Sortable.create('id_of_container',[options]); to create new Sortables.
        /// See Sortable.create. Furthermore, there are special requirements to get sortables to work in FF3 which are also covered in Sortable.create.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <returns></returns>
        public static Sortable create(JsString id_of_container) { return null; }

        public object sortables { get; set; }

        public void options(HtmlElement element) { }

        public void destroy(HtmlElement element) { }

        public void create(HtmlElement element, SortableCreateOptions options) { }

        /// <summary>
        /// Internal function, which may be overridden through the options parameter on creation
        /// </summary>
        /// <param name="element"></param>
        /// <param name="dropon"></param>
        /// <param name="overlap"></param>
        public void findElements(HtmlElement element, object dropon, object overlap) { }
        //TODO: ?

        public void onHover(HtmlElement element, object dropon, object overlap) { }
        //TODO: ?

        public void onEmptyHover(HtmlElement element, object dropon, object overlap) { }
        //TODO: ?

        public void unmark() { }

        public void mark() { }

        public void tree(HtmlElement element) { }

        //TODO: sequence (element)	
        //setSequence (element, new_sequence)	
        //serialize (element)

        /// <summary>
        /// The Sortable object also provides a function to serialize the Sortable in a format suitable for HTTP GET or POST requests.
        /// This can be used to submit the order of the Sortable via an Ajax call:
        /// Important: For this to work, the elements contained in your Sortable must have id attributes in the following form:
        /// id="string_identifier" 
        /// 
        /// //Example
        /// &lt;ol id="container_id">
        ///   &lt;li id="image_1">Item 1&lt;/li>
        ///   &lt;li id="image_2">Item 1&lt;/li>
        ///   &lt;li id="image_3">Item 1&lt;/li>
        /// &lt;/ol>
        /// Only the identifier part of the id attribute will be serialized. If you want to use an other form of id attributes, you need to implement your own serialization.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static JsString serialize(JsString id_of_container, SortableSerializeOptions options) { return null; }
        /// <summary>
        /// The Sortable object also provides a function to serialize the Sortable in a format suitable for HTTP GET or POST requests.
        /// This can be used to submit the order of the Sortable via an Ajax call:
        /// Important: For this to work, the elements contained in your Sortable must have id attributes in the following form:
        /// id="string_identifier" 
        /// 
        /// //Example
        /// &lt;ol id="container_id">
        ///   &lt;li id="image_1">Item 1&lt;/li>
        ///   &lt;li id="image_2">Item 1&lt;/li>
        ///   &lt;li id="image_3">Item 1&lt;/li>
        /// &lt;/ol>
        /// Only the identifier part of the id attribute will be serialized. If you want to use an other form of id attributes, you need to implement your own serialization.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <returns></returns>
        public static JsString serialize(JsString id_of_container) { return null; }

        /// <summary>
        /// The Sortable object also provides a function to get a sequence array of the id’s.
        /// </summary>
        /// <param name="id_of_container"></param>
        /// <returns></returns>
        public static JsArray<JsString> sequence(JsString id_of_container) { return null; }

    }

    [JsType(JsMode.Json)]
    public class SortableCreateOptions
    {
        /// <summary>
        /// Default: ‘li’
        /// The kind of tag (of the child elements of the container) that will be made sortable. For UL and OL containers, this is ‘LI’, you have to provide the tag kind for other sorts of child tags.
        /// </summary>
        public object tag { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: (none)
        /// Further restricts the selection of child elements to only encompass elements with the given CSS class
        /// (or, if you provide an array of strings, on any of the classes).
        /// </summary>
        public object only { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: ‘vertical’
        /// Either ‘vertical’ or ‘horizontal’. For floating sortables or horizontal lists, choose ‘horizontal’. Vertical lists should use ‘vertical’.
        /// </summary>
        public DirectionType overlap { get; set; }

        /// <summary>
        /// string, not set by default. If set to 'horizontal' or 'vertical' the drag will be constrained to take place only horizontally or vertically.
        /// </summary>
        public DirectionType constraint { get; set; }

        /// <summary>
        /// Default: (only within container)
        /// Enables dragging and dropping between Sortables. Takes an array of elements or element-ids (of the containers).
        /// Important note: To ensure that two way dragging between containers is possible, place all Sortable.create calls after the container elements
        /// </summary>
        public HtmlElement containment { get; set; }
        /// <summary>
        /// Default: (only within container)
        /// Enables dragging and dropping between Sortables. Takes an array of elements or element-ids (of the containers).
        /// Important note: To ensure that two way dragging between containers is possible, place all Sortable.create calls after the container elements
        /// </summary>
        [JsProperty(Name = "containment")]
        public JsArray<JsString> containmentArray { get; set; }

        /// <summary>
        /// Default:
        /// /^[^_\-](?:[A-Za-z0-9\-\_]*)[_](.*)$/
        /// The format that the id is computed from each item-id
        /// </summary>
        public object format { get; set; }
        //TODO: type?

        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        [JsProperty(Name = "handle")]
        public JsString handleString { get; set; }
        /// <summary>
        /// string or DOM reference, not set by default. As above, except now the value may be a string referencing a CSS class value.
        /// The first child/grandchild/etc. element found within the element that has this CSS class value will be used as the handle.
        /// </summary>
        public HtmlElement handle { get; set; }

        /// <summary>
        /// Default: (none)
        /// Gives the created Droppables a hoverclass (see there).
        /// </summary>
        public object hoverclass { get; set; }
        //TODO: type?

        /// <summary>
        /// If set to true, dragged elements of the Sortable will be cloned and appear as “ghost”, i.e. a representation of their original element,
        /// instead of directly dragging the original element. See below for more details.
        /// </summary>
        public bool ghosting { get; set; }

        /// <summary>
        /// f set to true, the Sortable container will be made into a Droppable,
        /// that can receive a Draggable (as according to the containment rules) as a child element when there are no more elements inside.
        /// </summary>
        public bool dropOnEmpty { get; set; }

        /// <summary>
        /// Default: none
        /// When the sortable is contained in an element with style overflow:scroll, this value can be set to the ID of that container (or the container’s DOM object).
        /// The scroll position of the container will now move along when the sortable is dragged out of the viewable area.
        /// The container must have overflow:scroll set to include scroll bars. Does not yet work for scrolling the entire document.
        /// To get this to work correctly, include this line in your code before creating the sortable: Position.includeScrollOffsets = true;
        /// Update: Scrolling the whole document does work (at least on Safari 3.2 (Mac), IE7 and Firefox). Use scroll: window
        /// </summary>
        public object scroll { get; set; }
        //TODO: type?

        /// <summary>
        /// Default: 20
        /// Will start scrolling when element is x pixels from the bottom, where x is the scrollSensitivity.
        /// </summary>
        public JsNumber scrollSensitivity { get; set; }

        /// <summary>
        /// Default: 15
        /// Will scroll the element in increments of scrollSpeed pixels.
        /// </summary>
        public JsNumber scrollSpeed { get; set; }

        /// <summary>
        /// Default: false
        /// If true, sets sortable functionality to elements listed in treeTag
        /// </summary>
        public bool tree { get; set; }

        /// <summary>
        /// Default: ul
        /// The element type tree nodes are contained in.
        /// </summary>
        public object treeTag { get; set; }
        //TODO: type?

        //TODO: Callbacks

    }

    [JsType(JsMode.Json)]
    public class SortableSerializeOptions
    {

        /// <summary>
        /// The kind of tag (of the child elements of the container) that will be serialized.
        /// </summary>
        public object tag { get; set; }

        /// <summary>
        /// The name of the key that will be used to create the key/value pairs for serializing in HTTP GET/POST format (that is, key[]=value&amp;key[]=value …)
        /// </summary>
        public JsString name { get; set; }
    }

    #endregion

    #region Miscellaneous

    /// <summary>
    /// Use Builder to easily create DOM elements dynamically.
    /// </summary>
    [JsType(JsMode.Json)]
    public class Builder
    {
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <returns></returns>
        public static Builder node(JsString elementName) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, JsArray children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, JsNumber children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, JsString children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes, JsArray children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes, JsNumber children) { return null; }
        /// <summary>
        /// Use Builder to easily create DOM elements dynamically.
        /// Special cases:
        /// class: When specifying the class attribute for the node, use className to circumvent a Firefox bug.
        /// for: To set a for attribute (in labels) use htmlFor, since ‘for’ is a reserved word in javascript.
        /// </summary>
        /// <param name="elementName">String, The tag name for the element</param>
        /// <param name="attributes">Object, Typical attributes are id, className, style, onclick, etc.</param>
        /// <param name="children">Array, List of other nodes to be appended as children
        /// If an element of the children Array is a String or Number, it will be automatically appended as a text node.
        /// Instead of an array, children can also be a JavaScript String or Number, to ease usage.</param>
        /// <returns></returns>
        public static Builder node(JsString elementName, object attributes, JsString children) { return null; }
    }

    /// <summary>
    /// Use Sound to play audio directly from the browser.
    /// </summary>
    [JsType(JsMode.Json)]
    public class Sound
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="replace">replace the current active track, defauts to false</param>
        public static void play(JsString url, bool replace) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public static void play(JsString url) { }

        /// <summary>
        /// Sound.enable does not resume the playback, just allows the next track to be played.
        /// </summary>
        public static void enable() { }

        /// <summary>
        /// Sound.disable does not disable the playback immediately, it just prevents the next tracks from being played.
        /// Watch the demo to see how to stop the sound immediately.
        /// </summary>
        public static void disable() { }
    }
    //TODO: check class

    //TODO: Unit Testing (don't work...)
    #endregion

    #region Core Effects

    /// <summary>
    /// The seven core effects Effect.Opacity, Effect.Scale, Effect.Morph, Effect.Move, Effect.Highlight, Effect.Parallel, Effect.Tween are the foundation of the script.aculo.us Visual Effects JavaScript library.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect", Export = false)]
    public class Effect
    {
        /// <summary>
        /// The basic syntax to start an effect
        /// </summary>
        /// <param name="el">element can be either a string containing the id of the element, or a Java Script DOM element object.</param>
        /// <param name="required_params">required-params depend on the effect being called and may not be needed. Most effects do not have required parameters.
        /// See the documentation for the core effects to learn if the effect has required parameters or if this parameter should be omitted.</param>
        public Effect(HtmlElement el, EffectOptions required_params)
        {
        }
        /// <summary>
        /// The basic syntax to start an effect
        /// </summary>
        /// <param name="id_of_element">element can be either a string containing the id of the element, or a Java Script DOM element object.</param>
        /// <param name="required_params">required-params depend on the effect being called and may not be needed. Most effects do not have required parameters.
        /// See the documentation for the core effects to learn if the effect has required parameters or if this parameter should be omitted.</param>
        public Effect(JsString id_of_element, EffectOptions required_params)
        {
        }


        /// <summary>
        /// The element the effect is applied to.
        /// </summary>
        public static HtmlElement element { get; set; }

        /// <summary>
        /// Holds the options you gave to the effect.
        /// </summary>
        public static EffectOptions options { get; set; }

        /// <summary>
        /// The number of the last frame rendered.
        /// </summary>
        public static JsNumber currentFrame { get; set; }

        /// <summary>
        /// The times (in ms) when the effect was started, and when it will be finished.
        /// </summary>
        public static JsNumber startOn { get; set; }

        /// <summary>
        /// The times (in ms) when the effect was started, and when it will be finished.
        /// </summary>
        public static JsNumber finishOn { get; set; }

        /// <summary>
        /// On an Effect.Parallel effect, there’s an effects[] array containing the individual effects the parallel effect is composed of.
        /// </summary>
        public static JsArray<Effect> effects { get; set; }

        /// <summary>
        /// Stop the effect as is.
        /// </summary>
        public static void cancel() { }

        /// <summary>
        /// Get basic debugging information about the instance.
        /// </summary>
        /// <returns></returns>
        public static object inspect() { return null; }

    }

    [JsType(JsMode.Json)]
    public class EffectOptions
    {
        /// <summary>
        /// duration of the effect in seconds, given as a float. Defaults to 1.0.
        /// </summary>
        public JsNumber duration { get; set; }

        /// <summary>
        /// Target this many frames per second. Default to 25. Can’t be higher than 100.
        /// </summary>
        public JsNumber fps { get; set; }

        /// <summary>
        /// Sets a function that modifies the current point of the animation, which is between 0 and 1.
        /// Following transitions are supplied:
        /// Effect.Transitions.sinoidal (default),
        /// Effect.Transitions.linear,
        /// Effect.Transitions.reverse,
        /// Effect.Transitions.wobble, 
        /// Effect.Transitions.flicker, 
        /// Effect.Transitions.pulse, 
        /// Effect.Transitions.spring, 
        /// Effect.Transitions.none,
        /// Effect.Transitions.full.
        /// </summary>
        public object transition { get; set; }

        /// <summary>
        /// Sets the starting point of the transition, a float between 0.0 and 1.0. Defaults to 0.0.
        /// </summary>
        public JsNumber from { get; set; }

        /// <summary>
        /// Sets the end point of the transition, a float between 0.0 and 1.0. Defaults to 1.0.
        /// </summary>
        public JsNumber to { get; set; }

        /// <summary>
        /// Sets whether the effect should render new frames automatically (which it does by default).
        /// If true, you can render frames manually by calling the render() instance method of an effect. This is used by Effect.Parallel().
        /// </summary>
        public bool sync { get; set; }

        /// <summary>
        /// Sets queuing options.
        /// When used with a string, can be ‘front’ or ‘end’ to queue the effect in the global effects queue at the beginning or end,
        /// or a queue parameter object that can have { position: ’front/end’, scope: ’scope’, limit: 1 }. For more info on this, see Effect Queues.
        /// </summary>
        public JsString queue { get; set; }
        /// <summary>
        /// Sets queuing options.
        /// When used with a string, can be ‘front’ or ‘end’ to queue the effect in the global effects queue at the beginning or end,
        /// or a queue parameter object that can have { position: ’front/end’, scope: ’scope’, limit: 1 }. For more info on this, see Effect Queues.
        /// </summary>
        public object queueObject { get; set; }

        /// <summary>
        /// Sets the number of seconds to wait before the effect actually starts. Defaults to 0.0.
        /// </summary>
        public JsNumber delay { get; set; }

        //TODO: callback
    }

    /// <summary>
    /// This effect flashes a color as the background of an element.
    /// It is mostly used to draw attention to a part of the page that has been updated via JavaScript or AJAX, when the update would not otherwise be obvious.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Highlight", Export = false)]
    public class Highlight : Effect
    {
        public Highlight(JsString id_of_element, HighlightOptions options)
            : base(id_of_element, options)
        {
        }
        public Highlight(HtmlElement el, HighlightOptions options)
            : base(el, options)
        {
        }
    }

    [JsType(JsMode.Json)]
    public class HighlightOptions : EffectOptions
    {
        /// <summary>
        /// Sets the color of first frame of the highlight. Defaults to ”#ffff99” (a light yellow).
        /// </summary>
        public JsString startcolor { get; set; }

        /// <summary>
        /// Sets the color of the last frame of the highlight. This is best set to the background color of the highlighted element. Defaults to ”#ffffff” (white).
        /// </summary>
        public JsString endcolor { get; set; }

        /// <summary>
        /// Sets the background-color of the element after the highlight has finished. Defaults to the current background-color of the highlighted element.
        /// If the restorecolor option is not given,
        /// Effect.Highlight tries to find out the current background color of the element,
        /// which will only work reliably across browsers if the color is given with a CSS rgb triplet, like rgb(0, 255, 0).
        /// Also be aware that applying an effect (without setting a restorecolor), to an element that already has an highlight effect in progress,
        /// will cause the restorecolor to be set to the elements background-color at the time of the new effect, and not the original background-color.
        /// For example, click the example below 4-5 times in quick succession, and the paragraph will stay yellow as opposed to the original white.
        /// </summary>
        public object restorecolor { get; set; }

        /// <summary>
        /// Unless this is set to true, any background image on the element will not be preserved.
        /// </summary>
        public bool keepBackgroundImage { get; set; }
    }


    /// <summary>
    ///This effect changes the CSS properties of an element.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Morph", Export = false)]
    public class Morph : Effect
    {
        public Morph(HtmlElement el, MorphOptions options)
            : base(el, options)
        {
        }

        public Morph(JsString id_of_element, MorphOptions options)
            : base(id_of_element, options)
        {
        }

    }

    [JsType(JsMode.Json)]
    public class MorphOptions : EffectOptions
    {
        /// <summary>
        /// the target style of your element, as a string written with the standard CSS syntax, a hash, or a CSS class name.
        /// </summary>
        public JsString style { get; set; }
    }


    /// <summary>
    /// This effect flashes a color as the background of an element.
    /// It is mostly used to draw attention to a part of the page that has been updated via JavaScript or AJAX, when the update would not otherwise be obvious.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Move", Export = false)]
    public class Move : Effect
    {
        public Move(HtmlElement @object, MoveOptions options)
            : base(@object, options)
        {
        }

        public Move(JsString @object, MoveOptions options)
            : base(@object, options)
        {
        }
    }

    [JsType(JsMode.Json)]
    public class MoveOptions : EffectOptions
    {
        /// <summary>
        /// integer value, either the new absolute target of the effect elements left value or the modifier of its current left value, depending on the mode option
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// integer value, either the new absolute target of the effect elements top value or the modifier of its current top value, depending on the mode option
        /// </summary>
        public JsNumber y { get; set; }

        /// <summary>
        /// string, defaults to 'relative', can also be 'absolute', specifies if the element is moved absolutely or relative to its own position.
        /// </summary>
        public JsString mode { get; set; }

    }


    /// <summary>
    /// This effect changes an element’s opacity (transparency).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Opacity", Export = false)]
    public class Opacity : Effect
    {
        public Opacity(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }

        public Opacity(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }
    }



    /// <summary>
    ///This effect changes an elements width and height dimensions and the base for em units.
    ///This allows for smooth, automatic relative scaling of elements contained within the scaled element.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Scale", Export = false)]
    public class Scale : Effect
    {
        public Scale(HtmlElement el, ScaleOptions options)
            : base(el, options)
        {
        }

        public Scale(JsString id_of_element, ScaleOptions options)
            : base(id_of_element, options)
        {
        }

    }

    [JsType(JsMode.Json)]
    public class ScaleOptions : EffectOptions
    {
        /// <summary>
        /// Sets whether the element should be scaled horizontally, defaults to true.
        /// </summary>
        public bool scaleX { get; set; }

        /// <summary>
        /// Sets whether the element should be scaled vertically, defaults to true.
        /// </summary>
        public bool scaleY { get; set; }

        /// <summary>
        /// Sets whether content scaling should be enabled, defaults to true.
        /// </summary>
        public bool scaleContent { get; set; }

        /// <summary>
        /// If true, scale the element in a way that the center of the element stays on the same position on the screen, defaults to false.
        /// </summary>
        public bool scaleFromCenter { get; set; }

        /// <summary>
        /// Either ‘box’ (default, scales the visible area of the element) or ‘contents’ (scales the complete element,
        /// that is parts normally only visible byscrolling are taken into account).
        /// You can also precisely control the size the element will become by assigning the originalHeight and originalWidth variables to scaleMode.
        /// Example: scaleMode: { originalHeight: 900, originalWidth: 900 }
        /// </summary>
        public JsString scaleMode { get; set; }

        /// <summary>
        /// Sets the starting percentage for scaling, defaults to 100.0.
        /// </summary>
        public JsNumber scaleFrom { get; set; }
    }


    /// <summary>
    ///This is a special effect which allows to combine more than one core effect into a parallel effect.
    ///It’s the only effect that doesn’t take an element as first parameter, but an array of subeffects.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Parallel", Export = false)]
    public class Parallel : Effect
    {
        public Parallel(JsArray<Effect> subEffects, EffectOptions options)
            : base("", options) { }
    }


    #endregion

    #region Combination Effects

    /// <summary>
    /// This effect flashes a color as the background of an element.
    /// It is mostly used to draw attention to a part of the page that has been updated via JavaScript or AJAX, when the update would not otherwise be obvious.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Templet", Export = false)]
    public class Templet : Effect
    {
        public Templet(JsString id_of_element, HighlightOptions options)
            : base(id_of_element, options)
        {
        }
        public Templet(HtmlElement el, HighlightOptions options)
            : base(el, options)
        {
        }
    }

    [JsType(JsMode.Json)]
    public class TempletOptions : EffectOptions
    {
        /// <summary>
        /// Sets the color of first frame of the highlight. Defaults to ”#ffff99” (a light yellow).
        /// </summary>
        public JsString startcolor { get; set; }

        /// <summary>
        /// Sets the color of the last frame of the highlight. This is best set to the background color of the highlighted element. Defaults to ”#ffffff” (white).
        /// </summary>
        public JsString endcolor { get; set; }

        /// <summary>
        /// Sets the background-color of the element after the highlight has finished. Defaults to the current background-color of the highlighted element.
        /// If the restorecolor option is not given,
        /// Effect.Highlight tries to find out the current background color of the element,
        /// which will only work reliably across browsers if the color is given with a CSS rgb triplet, like rgb(0, 255, 0).
        /// Also be aware that applying an effect (without setting a restorecolor), to an element that already has an highlight effect in progress,
        /// will cause the restorecolor to be set to the elements background-color at the time of the new effect, and not the original background-color.
        /// For example, click the example below 4-5 times in quick succession, and the paragraph will stay yellow as opposed to the original white.
        /// </summary>
        public object restorecolor { get; set; }

        /// <summary>
        /// Unless this is set to true, any background image on the element will not be preserved.
        /// </summary>
        public bool keepBackgroundImage { get; set; }
    }

    /// <summary>
    /// Make an element appear. 
    /// If the element was previously set to display:none inside the style attribute of the element, the effect will automatically show the element. 
    /// This means that display must be set within the style attribute of an object, and not in the CSS in the head of the document or a linked file.
    /// In other words, this Effect will not work if display:none is set within style tag or linked CSS file. Alternatively,
    /// display:none can be set using a document.getElementById script even if no style is set in the style attribute.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Appear", Export = false)]
    public class Appear : Effect
    {
        public Appear(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }
        public Appear(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// This effect simulates a window blind, where the contents of the affected elements stay in place.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.BlindDown", Export = false)]
    public class BlindDown : Effect
    {
        public BlindDown(JsString id_of_element, BlindOptions options)
            : base(id_of_element, options)
        {
        }
        public BlindDown(HtmlElement el, BlindOptions options)
            : base(el, options)
        {
        }

        public BlindDown(JsString id_of_element)
            : base(id_of_element, null)
        {
        }
        public BlindDown(HtmlElement el)
            : base(el, null)
        {
        }
    }

    [JsType(JsMode.Json)]
    public class BlindOptions : EffectOptions
    {
        /// <summary>
        /// defaults to false
        /// Sets whether the element should be scaled horizontally, defaults to true.
        /// </summary>
        public bool scaleX { get; set; }

        /// <summary>
        /// defaults to true
        /// Sets whether the element should be scaled vertically, defaults to true.
        /// </summary>
        public bool scaleY { get; set; }

        /// <summary>
        /// defaults to true
        /// Sets whether content scaling should be enabled, defaults to true.
        /// </summary>
        public bool scaleContent { get; set; }

        /// <summary>
        /// defaults to false
        /// If true, scale the element in a way that the center of the element stays on the same position on the screen, defaults to false.
        /// </summary>
        public bool scaleFromCenter { get; set; }

        /// <summary>
        /// Either ‘box’ (default, scales the visible area of the element) or ‘contents’ (scales the complete element,
        /// that is parts normally only visible byscrolling are taken into account).
        /// You can also precisely control the size the element will become by assigning the originalHeight and originalWidth variables to scaleMode.
        /// Example: scaleMode: { originalHeight: 900, originalWidth: 900 }
        /// </summary>
        public JsString scaleMode { get; set; }

        /// <summary>
        /// integer value, percentage (0%–100%), defaults to 100
        /// </summary>
        public JsNumber scaleFrom { get; set; }

        /// <summary>
        /// integer value, percentage (0%–100%), defaults to 0
        /// </summary>
        public JsNumber scaleTo { get; set; }
    }

    /// <summary>
    /// This effect simulates a window blind, where the contents of the affected elements stay in place.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.BlindUp", Export = false)]
    public class BlindUp : Effect
    {
        public BlindUp(JsString id_of_element, BlindOptions options)
            : base(id_of_element, options)
        {
        }
        public BlindUp(HtmlElement el, BlindOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Makes an element drop and fade out at the same time.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.DropOut", Export = false)]
    public class DropOut : Effect
    {
        public DropOut(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public DropOut(HtmlElement el)
            : base(el, null)
        {
        }

        public DropOut(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }
        public DropOut(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Makes an element fade away and takes it out of the document flow when the effect is complete by setting the CSS display property to none. Opposite of Effect.Appear.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Fade", Export = false)]
    public class Fade : Effect
    {
        public Fade(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }
        public Fade(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Reduce the element to its top then to left to make it disappear.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Fold", Export = false)]
    public class Fold : Effect
    {
        public Fold(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public Fold(HtmlElement el)
            : base(el, null)
        {
        }

        public Fold(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }

        public Fold(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// “Grows” an element into a specific direction (see demo for better understanding).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Grow", Export = false)]
    public class Grow : Effect
    {
        public Grow(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public Grow(HtmlElement el)
            : base(el, null)
        {
        }

        public Grow(JsString id_of_element, GrowOptions options)
            : base(id_of_element, options)
        {
        }

        public Grow(HtmlElement el, GrowOptions options)
            : base(el, options)
        {
        }
    }

    [JsType(JsMode.Json)]
    public class GrowOptions : EffectOptions
    {
        /// <summary>
        /// string, defaults to 'center', can also be: 'top-left', 'top-right', 'bottom-left', 'bottom-right', specifying the origin from which to “grow” the element
        /// </summary>
        public JsString direction { get; set; }
    }

    /// <summary>
    /// Gives the illusion of the element puffing away (like a in a cloud of smoke).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Puff", Export = false)]
    public class Puff : Effect
    {
        public Puff(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }
        public Puff(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Pulsates the element, loops over five times over fading out and in.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Pulsate", Export = false)]
    public class Pulsate : Effect
    {
        public Pulsate(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }
        public Pulsate(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Moves the element slightly to the left, then to the right, repeatedly.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Shake", Export = false)]
    public class Shake : Effect
    {
        public Shake(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public Shake(HtmlElement el)
            : base(el, null)
        {
        }

        public Shake(JsString id_of_element, ShakeOptions options)
            : base(id_of_element, options)
        {
        }

        public Shake(HtmlElement el, ShakeOptions options)
            : base(el, options)
        {
        }
    }

    [JsType(JsMode.Json)]
    public class ShakeOptions : EffectOptions
    {
        /// <summary>
        /// integer value, defaults to 20, the number of pixels to move horizontally
        /// </summary>
        public JsNumber distance { get; set; }
    }

    /// <summary>
    /// “Shrinks” an element into a specific direction (see demo for better understanding), hides it when the effect is complete.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Shrink", Export = false)]
    public class Shrink : Effect
    {
        public Shrink(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public Shrink(HtmlElement el)
            : base(el, null)
        {
        }

        public Shrink(JsString id_of_element, GrowOptions options)
            : base(id_of_element, options)
        {
        }

        public Shrink(HtmlElement el, GrowOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// This effect simulates a window blind, where the contents of the affected elements scroll up and down accordingly.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.SlideDown", Export = false)]
    public class SlideDown : Effect
    {
        public SlideDown(JsString id_of_element, BlindOptions options)
            : base(id_of_element, options)
        {
        }
        public SlideDown(HtmlElement el, BlindOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// This effect simulates a window blind, where the contents of the affected elements scroll up accordingly.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.SlideUp", Export = false)]
    public class SlideUp : Effect
    {
        public SlideUp(JsString id_of_element, BlindOptions options)
            : base(id_of_element, options)
        {
        }
        public SlideUp(HtmlElement el, BlindOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Reduce the element to its top-left corner.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.Squish", Export = false)]
    public class Squish : Effect
    {
        public Squish(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public Squish(HtmlElement el)
            : base(el, null)
        {
        }

        public Squish(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }

        public Squish(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    /// <summary>
    /// Gives the illusion of a TV-style switch off.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Effect.SwitchOff", Export = false)]
    public class SwitchOff : Effect
    {
        public SwitchOff(JsString id_of_element)
            : base(id_of_element, null)
        {
        }

        public SwitchOff(HtmlElement el)
            : base(el, null)
        {
        }

        public SwitchOff(JsString id_of_element, EffectOptions options)
            : base(id_of_element, options)
        {
        }

        public SwitchOff(HtmlElement el, EffectOptions options)
            : base(el, options)
        {
        }
    }

    #endregion

    public class Transitions
    {

        //TODO:
    }

    public enum DirectionType
    {
        horizontal,
        vertical,
    }

    //TODO: Effect.Methods


    //[JsType(JsMode.Prototype, Name = "Effect.tagifyText", Export = false)]
    //public class tagifyText
    //{
    //    /// <summary>
    //    /// Effect.tagifyText transforms any text string contained in a specific element into a chain of span elements, each containing one character of the string.
    //    /// </summary>
    //    /// <param name="element"></param>
    //    public static void tagifyText(HtmlElement element) { }

    //    //TODO: check!!!
    //}

    //[JsType(JsMode.Prototype, Name = "Effect.multiple", Export = false)]
    //public class multiple: Effect
    //{

    //    public static void multiple(JsArray<HtmlElement> elements, Effect effect, MultipleOptions options) { }
    //}

    //[JsType(JsMode.Json)]
    //public class MultipleOptions : EffectOptions
    //{
    //    /// <summary>
    //    /// float value, defaults to 0.1, a delay offset for each subsequent effect
    //    /// </summary>
    //    public JsNumber speed { get; set; }

    //    /// <summary>
    //    /// float value, defaults to 0.0, the effects start delay
    //    /// </summary>
    //    public JsNumber delay { get; set; }
    //}
    
    //TODO: Effect helpers: Effect.Transitions, Effect.Methods, Effect.tagifyText, Effect.multiple, Effect.toggle
}
