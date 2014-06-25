using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace log4javascript
{
    public class InPageAppender : Appender
    {
        [JsMethod(NativeOverloads = true)]
        public InPageAppender(HtmlElement container) { }
        [JsMethod(NativeOverloads = true)]
        public InPageAppender(HtmlElement container, JsBoolean lazyInit, JsBoolean initiallyMinimized, JsBoolean useDocumentWrite, JsString width, JsString height) { }

        public void addCssProperty(JsString name, JsString value) { }
        public JsBoolean isVisible() { return false; }
        public JsBoolean isInitiallyMinimized() { return false; }
        public void setInitiallyMinimized(JsBoolean initiallyMinimized) { }
        public JsBoolean isNewestMessageAtTop() { return false; }
        public void setNewestMessageAtTop(JsBoolean newestMessageAtTop) { }
        public JsBoolean isScrollToLatestMessage() { return false; }
        public void setScrollToLatestMessage(JsBoolean scrollToLatestMessage) { }
        public JsString getWidth() { return null; }
        public void setWidth(JsString width) { }
        public JsString getHeight() { return null; }
        public void setHeight(JsString height) { }
        public JsNumber getMaxMessages() { return 0; }
        public void setMaxMessages(JsNumber maxMessages) { }
        public JsBoolean isShowCommandLine() { return false; }
        public void setShowCommandLine(JsBoolean showCommandLine) { }
        public JsNumber getCommandLineObjectExpansionDepth() { return 0; }
        public void setCommandLineObjectExpansionDepth(JsNumber expansionDepth) { }
        public Window getCommandWindow() { return null; }
        public void setCommandWindow(Window commandWindow) { }
        public JsNumber getCommandLayout() { return 0; }
        public void setCommandLayout(Layout commandLayout) { }
        public void clear() { }
        public void show() { }
        public void hide() { }
        public void close() { }
        public void focus() { }
        public void focusCommandLine() { }
        public void focusSearch() { }
        public void evalCommandAndAppend(JsString expr) { }
        public void addCommandLineFunction(JsString functionName, JsAction<Appender, JsArray, CommandLineFunctionReturnValue> commandLineFunction) { }
        public override void append(LoggingEvent loggingEvent) { }
        public override JsString toString() { return default(JsString); }
    }
}
