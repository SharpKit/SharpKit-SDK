using SharpKit.JavaScript;

namespace SharpKit.jQuery
{
    #region NestedSortable

    public static partial class NestedSortableExtension
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery nestedSortable(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery nestedSortable(this jQuery query, NestedSortableOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery nestedSortable(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }
    #endregion

    #region NestedSortableOptions

    [JsType(JsMode.Json)]
    public partial class NestedSortableOptions
    {
        /// <summary>
        /// How far right or left (in pixels) the item has to travel in order to be nested or to be sent outside its current list. 
        /// Default: 20 
        /// </summary>
        public int tabSize { get; set; }
        /// <summary>
        /// The class name of the items that will not accept nested lists. 
        /// Default: ui-nestedSortable-no-nesting
        /// </summary>
        public string disableNesting { get; set; }
        /// <summary>
        /// The class given to the placeholder in case of error. 
        /// Default: ui-nestedSortable-error 
        /// </summary>
        public string errorClass { get; set; }
        /// <summary>
        /// The list type used (ordered or unordered). 
        /// Default: ol 
        /// </summary>
        public string listType { get; set; }
        /// <summary>
        /// The maximum depth of nested items the list can accept. If set to '0' the levels are unlimited. 
        /// Default: 0 
        /// </summary>
        public int maxLevels { get; set; }
        /// <summary>
        /// Wether to protect the root level (i.e. root items can be sorted but not nested, sub-items cannot become root items). 
        /// Default: false 
        /// </summary>
        public bool protectRoot { get; set; }
        /// <summary>
        /// The id given to the root element (set this to whatever suits your data structure). 
        /// Default: null 
        /// </summary>
        public string rootID { get; set; }
        /// <summary>
        /// Set this to true if you have a right-to-left page. 
        /// Default: false 
        /// </summary>
        public bool rtl { get; set; }
        /// <summary>
        /// You can specify a custom function to verify if a drop location is allowed. 
        /// Default: function(parent, item) { return true; } 
        /// </summary>
        public JsAction isAllowed { get; set; }
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
        ///This event is triggered when sorting starts.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> start { get; set; }
        ///<summary>
        ///This event is triggered during sorting.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> sort { get; set; }
        ///<summary>
        ///This event is triggered during sorting, but only when the DOM position has changed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> change { get; set; }
        ///<summary>
        ///This event is triggered when sorting stops, but when the placeholder/helper is still available.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> beforeStop { get; set; }
        ///<summary>
        ///This event is triggered when sorting has stopped.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> stop { get; set; }
        ///<summary>
        ///This event is triggered when the user stopped sorting and the DOM position has changed.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> update { get; set; }
        ///<summary>
        ///This event is triggered when a connected sortable list has received an item from another list.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> receive { get; set; }
        ///<summary>
        ///This event is triggered when a sortable item has been dragged out from the list and into another.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> remove { get; set; }
        ///<summary>
        ///This event is triggered when a sortable item is moved into a connected list.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> over { get; set; }
        ///<summary>
        ///This event is triggered when a sortable item is moved away from a connected list.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> @out { get; set; }
        ///<summary>
        ///This event is triggered when using connected lists, every connected list on drag start receives it.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> activate { get; set; }
        ///<summary>
        ///This event is triggered when sorting was stopped, is propagated to all possible connected lists.
        ///Default: null
        ///</summary>
        public jQueryUIEvent<UISortable> deactivate { get; set; }
    }
    #endregion
}