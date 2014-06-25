using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace log4javascript
{
    /// <summary>
    /// Logs messages to a pop-up console window (note: you will need to disable pop-up blockers to use it).
    /// </summary>
    public class PopUpAppender : Appender
    {
        public override JsString toString() { return default(JsString); }
        public override void append(LoggingEvent loggingEvent) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PopUpAppender" /> class.
        /// </summary>
        [JsMethod(NativeOverloads = true)]
        public PopUpAppender() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PopUpAppender" /> class.
        /// </summary>
        /// <param name="lazyInit">Set this to true to open the pop-up only when the first log message reaches the appender. Otherwise, the pop-up window opens as soon as the appender is created. If not specified, defaults to false.</param>
        /// <param name="initiallyMinimized">Whether the console window should start off hidden / minimized. If not specified, defaults to false.</param>
        /// <param name="useDocumentWrite">Specifies how the console window is created.</param>
        /// <param name="width">The outer width in pixels of the pop-up window.</param>
        /// <param name="height">The outer height in pixels of the pop-up window.</param>
        [JsMethod(NativeOverloads = true)]
        public PopUpAppender(JsBoolean lazyInit, JsBoolean initiallyMinimized, JsBoolean useDocumentWrite, JsNumber width, JsNumber height) { }
        /// <summary>
        /// Returns whether the console window starts off hidden / minimized
        /// </summary>
        /// <returns></returns>
        public JsBoolean isInitiallyMinimized() { return default(JsBoolean); }
        /// <summary>
        /// [not available after initialization]
        /// Sets whether the console window should start off hidden / minimized. 
        /// </summary>
        /// <param name="initiallyMinimized"></param>
        public void setInitiallyMinimized(JsBoolean initiallyMinimized) { }
        /// <summary>
        /// Returns whether the pop-up window is focussed (i.e. brought it to the front) when a new log message is added. Default value is false
        /// </summary>
        /// <returns></returns>
        public JsBoolean isFocusPopUp() { return default(JsBoolean); }
        /// <summary>
        /// Sets whether to focus the pop-up window (i.e. bring it to the front) when a new log message is added
        /// </summary>
        /// <param name="focusPopUp"></param>
        public void setFocusPopUp(JsBoolean focusPopUp) { }
        /// <summary>
        /// Returns whether the same pop-up window is used if the main page is reloaded
        /// </summary>
        /// <returns></returns>
        public JsBoolean isUseOldPopUp() { return default(JsBoolean); }
        /// <summary>
        /// [not available after initialization] 
        /// Sets whether to use the same pop-up window if the main page is reloaded
        /// </summary>
        /// <param name="useOldPopUp"></param>
        public void setUseOldPopUp(Boolean useOldPopUp) { }
        /// <summary>
        /// Returns whether an alert is shown to the user when the pop-up window cannot be created as a result of a pop-up blocker
        /// </summary>
        /// <returns></returns>
        public JsBoolean isComplainAboutPopUpBlocking() { return default(JsBoolean); }
        /// <summary>
        /// [not available after initialization] 
        /// Sets whether to announce to show an alert to the user when the pop-up window cannot be created as a result of a pop-up blocker. 
        /// </summary>
        /// <param name="complainAboutPopUpBlocking"></param>
        public void setComplainAboutPopUpBlocking(Boolean complainAboutPopUpBlocking) { }
    }
}