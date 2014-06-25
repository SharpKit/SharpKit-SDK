using SharpKit.JavaScript;

namespace SharpKit.jQuery
{
    public partial class jQuery
    {
        [JsMethod(Name = "modal")]
        public jQuery simplemodal()
        {
            return null;
        }

        [JsMethod(Name = "modal")]
        public jQuery simplemodal(string html)
        {
            return null;
        }

        [JsMethod(Name = "modal")]
        internal jQuery simplemodal(SimpleModalOptions options)
        {
            return null;
        }

        public static ModalImplementation modal;
    }

    [JsType(JsMode.Prototype, Export = false)]
    public class ModalImplementation
    {
        public void close()
        {

        }
    }

    [JsType(JsMode.Json)]
    public class SimpleModalOptions
    {
        /// <summary>
        /// The jQuery selector to append the elements to. For ASP.NET, use 'form'.
        /// </summary>
        public JsString appendTo{ get; set; }
        /// <summary>
        /// Focus in the first visible, enabled element?
        /// </summary>
        public JsBoolean focus { get; set; }
        /// <summary>
        /// The opacity value for the overlay div, from 0 - 100
        /// </summary>
        public JsNumber opacity { get; set; }
        /// <summary>
        /// The DOM element id for the overlay div
        /// </summary>
        public JsString overlayId { get; set; }
        /// <summary>
        /// The CSS styling for the overlay div
        /// </summary>
        public JsArray<JsObject> overlayCss { get; set; }
        /// <summary>
        /// The DOM element id for the container div
        /// </summary>
        public JsString containerId { get; set; }
        /// <summary>
        /// The CSS styling for the container div
        /// </summary>
        public JsArray<JsObject> containerCss { get; set; }
        /// <summary>
        /// The DOM element id for the data div
        /// </summary>
        public JsString dataId { get; set; }
        /// <summary>
        /// The CSS styling for the data div
        /// </summary>
        public JsArray<JsObject> dataCss { get; set; }
        /// <summary>
        /// The minimum height for the container
        /// </summary>
        public JsNumber minHeight { get; set; }
        /// <summary>
        /// The minimum width for the container
        /// </summary>
        public JsNumber minWidth { get; set; }
        /// <summary>
        /// The maximum height for the container. If not specified, the window height is used.
        /// </summary>
        public JsNumber maxHeight { get; set; }
        /// <summary>
        /// The maximum width for the container. If not specified, the window width is used.
        /// </summary>
        public JsNumber maxWidth { get; set; }
        /// <summary>
        /// Resize the container if it exceeds the browser window dimensions?
        /// </summary>
        public JsBoolean autoResize { get; set; }
        /// <summary>
        /// Automatically position the container upon creation and on window resize?
        /// </summary>
        public JsBoolean autoPosition { get; set; }
        /// <summary>
        /// Starting z-index value
        /// </summary>
        public JsNumber zIndex { get; set; }
        /// <summary>
        /// If true, closeHTML, escClose and overClose will be used if set. If false, none of them will be used.
        /// </summary>
        public JsBoolean close { get; set; }
        /// <summary>
        /// The HTML for the default close link. SimpleModal will automatically add the closeClass to this element.
        /// </summary>
        public JsString closeHTML { get; set; }
        /// <summary>
        /// The CSS class used to bind to the close event
        /// </summary>
        public JsString closeClass { get; set; }
        /// <summary>
        /// Allow Esc keypress to close the dialog?
        /// </summary>
        public JsBoolean escClose { get; set; }
        /// <summary>
        /// Allow click on overlay to close the dialog?
        /// </summary>
        public JsBoolean overlayClose { get; set; }
        /// <summary>
        /// Position of container [top, left]. Can be number of pixels or percentage
        /// </summary>
        public JsArray position { get; set; }
        /// <summary>
        /// Persist the data across modal calls? Only used for existing DOM elements. If true, the data will be maintained across modal calls, if false, the data will be reverted to its original state.
        /// </summary>
        public JsBoolean persist { get; set; }
        /// <summary>
        /// User will be unable to interact with the page below the modal or tab away from the dialog. If false, the overlay, iframe, and certain events will be disabled allowing the user to interact with the page below the dialog.
        /// </summary>
        public JsBoolean modal { get; set; }
        /// <summary>
        /// The callback function used in place of SimpleModal's open
        /// </summary>
        public JsAction onOpen { get; set; }
        /// <summary>
        /// The callback function used after the modal dialog has opened
        /// </summary>
        public JsAction onShow { get; set; }
        /// <summary>
        /// The callback function used in place of SimpleModal's close
        /// </summary>
        public JsAction onClose { get; set; }


    }
}