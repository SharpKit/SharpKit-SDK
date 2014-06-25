using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.CodeMirror
{
    /// <summary>
    /// CodeMirror is a code-editor component that can be embedded in Web pages. The code library provides only the editor component, no accompanying buttons, auto-completion, or other IDE functionality.
    /// It does provide a rich API on top of which such functionality can be straightforwardly implemented. See the add-ons included in the distribution, and the CodeMirror UI project,for reusable implementations of extra features.
    /// CodeMirror works with language-specific modes. Modes are JavaScript programs that help color (and optionally indent) text written in a given language. The distribution comes with a number of modes (see the mode/ directory), and it isn't hard to write new ones for other languages.
    /// </summary>
    public class CodeMirror
    {
        public CodeMirror() { }
        public CodeMirror(CodeMirrorConfiguration config) { }

        /// <summary>
        /// Finally, the CodeMirror object itself has a method fromTextArea. This takes a textarea DOM node as first argument and an optional configuration object as second.
        /// It will replace the textarea with a CodeMirror instance, and wire up the form of that textarea (if any) to make sure the editor contents are put into the textarea when the form is submitted.
        /// </summary>
        /// <param name="domNode"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static CodeMirror fromTextArea(HtmlElement domNode, CodeMirrorConfiguration config) { return null; }

        /// <summary>
        /// Get the current editor content. You can pass it an optional argument to specify the string to be used to separate lines (defaults to "\n").
        /// </summary>
        /// <returns></returns>
        public JsString getValue() { return null; }

        /// <summary>
        /// Set the editor content.
        /// </summary>
        /// <param name="value"></param>
        public void setValue(JsString value) { }

        /// <summary>
        /// Get the currently selected code.
        /// </summary>
        /// <returns></returns>
        public JsString getSelection() { return null; }

        /// <summary>
        /// Replace the selection with the given string.
        /// </summary>
        /// <param name="selection"></param>
        public void replaceSelection(JsString selection) { }

        /// <summary>
        /// Programatically set the size of the editor (overriding the applicable CSS rules). width and height height can be either numbers (interpreted as pixels) or CSS units ("100%", for example).
        /// You can pass null for either of them to indicate that that dimension should not be changed.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void setSize(JsNumber width, JsNumber height) { }
        /// <summary>
        /// Programatically set the size of the editor (overriding the applicable CSS rules). width and height height can be either numbers (interpreted as pixels) or CSS units ("100%", for example).
        /// You can pass null for either of them to indicate that that dimension should not be changed.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void setSize(JsString width, JsString height) { }

        /// <summary>
        /// Give the editor focus.
        /// </summary>
        public void focus() { }

        /// <summary>
        /// Scroll the editor to a given (pixel) position. Both arguments may be left as null or undefined to have no effect.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void scrollTo(JsNumber x, JsNumber y) { }

        /// <summary>
        /// Get an {x, y, width, height} object that represents the current scroll position and scrollable area size of the editor.
        /// </summary>
        /// <returns></returns>
        public ScrollInfo getScrollInfo() { return null; }

        /// <summary>
        /// Change the configuration of the editor. option should the name of an option, and value should be a valid value for that option.
        /// </summary>
        /// <param name="option"></param>
        /// <param name="value"></param>
        public void setOption(CodeMirrorConfiguration option, object value) { }

        /// <summary>
        /// Retrieves the current value of the given option for this editor instance.
        /// </summary>
        /// <returns></returns>
        public object getOption() { return null; }

        /// <summary>
        /// Returns an {x, y, yBot} object containing the coordinates of the cursor. If mode is "local", they will be relative to the top-left corner of the editable document. If it is "page" or not given, they are relative to the top-left corner of the page.
        /// yBot is the coordinate of the bottom of the cursor. start is a boolean indicating whether you want the start or the end of the selection.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public CursorCoords cursorCoords(bool start, object mode) { return null; }

        /// <summary>
        /// Like cursorCoords, but returns the position of an arbitrary characters. pos should be a {line, ch} object.
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public object charCoords(PosConfig pos, object mode) { return null; }

        /// <summary>
        /// Given an {x, y} object (in page coordinates), returns the {line, ch} position that corresponds to it.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public PosConfig coordsChar(XYObject pos) { return null; }

        /// <summary>
        /// Undo one edit (if any undo events are stored).
        /// </summary>
        public void undo() { }

        /// <summary>
        /// Redo one undone edit.
        /// </summary>
        public void redo() { }

        /// <summary>
        /// Returns an object with {undo, redo} properties, both of which hold integers, indicating the amount of stored undo and redo operations.
        /// </summary>
        /// <returns></returns>
        public HistorySize historySize() { return null; }

        /// <summary>
        /// Clears the editor's undo history.
        /// </summary>
        public void clearHistory() { }

        /// <summary>
        /// Get a (JSON-serializeable) representation of the undo history.
        /// </summary>
        /// <returns></returns>
        public object getHistory() { return null; }

        /// <summary>
        /// Replace the editor's undo history with the one provided, which must be a value as returned by getHistory.
        /// Note that this will have entirely undefined results if the editor content isn't also the same as it was when getHistory was called.
        /// </summary>
        /// <param name="obj"></param>
        public void setHistory(object obj) { }

        /// <summary>
        /// Reset the given line's indentation to the indentation prescribed by the mode. If the second argument is given,
        /// indentation will be increased (if dir is true) or decreased (if false) by an indent unit instead.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="dir"></param>
        public void indentLine(object line, bool dir) { }
        /// <summary>
        /// Reset the given line's indentation to the indentation prescribed by the mode. If the second argument is given,
        /// indentation will be increased (if dir is true) or decreased (if false) by an indent unit instead.
        /// </summary>
        /// <param name="line"></param>
        public void indentLine(object line) { }

        /// <summary>
        /// Retrieves information about the token the current mode found before the given position (a {line, ch} object)
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public TokenAt getTokenAt(PosConfig pos) { return null; }

        /// <summary>
        /// Can be used to mark a range of text with a specific CSS class name. from and to should be {line, ch} objects.
        /// The method will return an object with two methods, clear(), which removes the mark, and find(), which returns a {from, to} (both document positions),
        /// indicating the current position of the marked range.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public MarkTextResult markText(PosConfig from, PosConfig to, JsString className) { return null; }

        /// <summary>
        /// Inserts a bookmark, a handle that follows the text around it as it is being edited, at the given position. A bookmark has two methods find() and clear().
        /// The first returns the current position of the bookmark, if it is still in the document, and the second explicitly removes the bookmark.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public MarkTextResult setBookmark(PosConfig pos) { return null; }

        /// <summary>
        /// Returns an array of all the bookmarks and marked ranges present at the given position.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public JsArray<Range> findMarksAt(PosConfig pos) { return null; }

        /// <summary>
        /// Add a gutter marker for the given line. Gutter markers are shown in the line-number area (instead of the number for this line).
        /// Both text and className are optional. Setting text to a Unicode character like ● tends to give a nice effect.
        /// To put a picture in the gutter, set text to a space and className to something that sets a background image. If you specify text, the given text (which may contain HTML) will, by default, replace the line number for that line.
        /// If this is not what you want, you can include the string %N% in the text, which will be replaced by the line number.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="text"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public LineHandle setMarker(JsNumber line, JsString text, JsString className) { return null; }
        /// <summary>
        /// Add a gutter marker for the given line. Gutter markers are shown in the line-number area (instead of the number for this line).
        /// Both text and className are optional. Setting text to a Unicode character like ● tends to give a nice effect.
        /// To put a picture in the gutter, set text to a space and className to something that sets a background image. If you specify text, the given text (which may contain HTML) will, by default, replace the line number for that line.
        /// If this is not what you want, you can include the string %N% in the text, which will be replaced by the line number.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public LineHandle setMarker(JsNumber line, JsString text) { return null; }
        /// <summary>
        /// Add a gutter marker for the given line. Gutter markers are shown in the line-number area (instead of the number for this line).
        /// Both text and className are optional. Setting text to a Unicode character like ● tends to give a nice effect.
        /// To put a picture in the gutter, set text to a space and className to something that sets a background image. If you specify text, the given text (which may contain HTML) will, by default, replace the line number for that line.
        /// If this is not what you want, you can include the string %N% in the text, which will be replaced by the line number.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineHandle setMarker(JsNumber line) { return null; }

        /// <summary>
        /// Clears a marker created with setMarker.
        /// line can be either a number or a handle returned by setMarker (since a number may now refer to a different line if something was added or deleted).
        /// </summary>
        /// <param name="line"></param>
        public void clearMarker(JsNumber line) { }
        /// <summary>
        /// Clears a marker created with setMarker.
        /// line can be either a number or a handle returned by setMarker (since a number may now refer to a different line if something was added or deleted).
        /// </summary>
        /// <param name="line"></param>
        public void clearMarker(LineHandle line) { }

        /// <summary>
        /// Set a CSS class name for the given line. line can be a number or a line handle (as returned by setMarker or this function).
        /// className will be used to style the text for the line, and backgroundClassName to style its background (which lies behind the selection).
        /// Pass null to clear the classes for a line.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="className"></param>
        /// <param name="backgroundClassName"></param>
        /// <returns></returns>
        public LineHandle setLineClass(JsNumber line, JsString className, JsString backgroundClassName) { return null; }
        /// <summary>
        /// Set a CSS class name for the given line. line can be a number or a line handle (as returned by setMarker or this function).
        /// className will be used to style the text for the line, and backgroundClassName to style its background (which lies behind the selection).
        /// Pass null to clear the classes for a line.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="className"></param>
        /// <param name="backgroundClassName"></param>
        /// <returns></returns>
        public LineHandle setLineClass(LineHandle line, JsString className, JsString backgroundClassName) { return null; }

        /// <summary>
        /// Hide the given line (either by number or by handle). Hidden lines don't show up in the editor, and their numbers are skipped when line numbers are enabled.
        /// Deleting a region around them does delete them, and coping a region around will include them in the copied text.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineHandle hideLine(JsNumber line) { return null; }
        /// <summary>
        /// Hide the given line (either by number or by handle). Hidden lines don't show up in the editor, and their numbers are skipped when line numbers are enabled.
        /// Deleting a region around them does delete them, and coping a region around will include them in the copied text.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineHandle hideLine(LineHandle line) { return null; }

        /// <summary>
        /// The inverse of hideLine—re-shows a previously hidden line, by number or by handle.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineHandle showLine(JsNumber line) { return null; }
        /// <summary>
        /// The inverse of hideLine—re-shows a previously hidden line, by number or by handle.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineHandle showLine(LineHandle line) { return null; }

        /// <summary>
        /// Register a function that should be called when the line is deleted from the document.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="func"></param>
        public void onDeleteLine(JsNumber line, JsAction func) { }
        /// <summary>
        /// Register a function that should be called when the line is deleted from the document.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="func"></param>
        public void onDeleteLine(LineHandle line, JsAction func) { }

        /// <summary>
        /// Returns the line number, text content, and marker status of the given line, which can be either a number or a handle returned by setMarker.
        /// The returned object has the structure {line, handle, text, markerText, markerClass, lineClass, bgClass}.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineInfo lineInfo(LineHandle line) { return null; }
        /// <summary>
        /// Returns the line number, text content, and marker status of the given line, which can be either a number or a handle returned by setMarker.
        /// The returned object has the structure {line, handle, text, markerText, markerClass, lineClass, bgClass}.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineInfo lineInfo(JsNumber line) { return null; }

        /// <summary>
        /// Fetches the line handle for the given line number.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public LineHandle getLineHandle(JsNumber line) { return null; }

        /// <summary>
        /// Returns a {from, to} object indicating the start (inclusive) and end (exclusive) of the currently displayed part of the document.
        /// In big documents, when most content is scrolled out of view,CodeMirror will only render the visible part, and a margin around it. See also the onViewportChange option.
        /// </summary>
        /// <returns></returns>
        public Range getViewport() { return null; }

        /// <summary>
        /// Puts node, which should be an absolutely positioned DOM node, into the editor, positioned right below the given {line, ch} position.
        /// When scrollIntoView is true, the editor will ensure that the entire node is visible (if possible).
        /// To remove the widget again, simply use DOM methods (move it somewhere else, or call removeChild on its parent).
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="node"></param>
        /// <param name="scrollIntoView"></param>
        public void addWidget(PosConfig pos, HtmlElement node, bool scrollIntoView) { }

        /// <summary>
        /// Force matching-bracket-highlighting to happen.
        /// </summary>
        public void matchBrackets() { }

        /// <summary>
        /// Get the number of lines in the editor.
        /// </summary>
        /// <returns></returns>
        public JsNumber lineCount() { return null; }

        /// <summary>
        /// start is a boolean indicating whether the start or the end of the selection must be retrieved. If it is not given, the current cursor pos,
        /// i.e. the side of the selection that would move if you pressed an arrow key, is chosen. A {line, ch} object will be returned.
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public PosConfig getCursor(bool start) { return null; }
        /// <summary>
        /// start is a boolean indicating whether the start or the end of the selection must be retrieved. If it is not given, the current cursor pos,
        /// i.e. the side of the selection that would move if you pressed an arrow key, is chosen. A {line, ch} object will be returned.
        /// </summary>
        /// <returns></returns>
        public PosConfig getCursor() { return null; }

        /// <summary>
        /// Return true if any text is selected.
        /// </summary>
        /// <returns></returns>
        public bool somethingSelected() { return false; }

        /// <summary>
        /// Set the cursor position. You can either pass a single {line, ch} object, or the line and the character as two separate parameters.
        /// </summary>
        /// <param name="pos"></param>
        public void setCursor(PosConfig pos) { }
        /// <summary>
        /// Set the cursor position. You can either pass a single {line, ch} object, or the line and the character as two separate parameters.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="character"></param>
        public void setCursor(JsNumber line, JsNumber character) { }

        /// <summary>
        /// Set the selection range. start and end should be {line, ch} objects.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void setSelection(PosConfig start, PosConfig end) { }

        /// <summary>
        /// Get the content of line n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public JsString getLine(JsNumber n) { return null; }

        /// <summary>
        /// Set the content of line n.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="text"></param>
        public void setLine(JsNumber n, JsString text) { }

        /// <summary>
        /// Remove the given line from the document.
        /// </summary>
        /// <param name="n"></param>
        public void removeLine(JsNumber n) { }

        /// <summary>
        /// Get the text between the given points in the editor, which should be {line, ch} objects
        /// An optional third argument can be given to indicate the line separator string to use (defaults to "\n").
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public JsString getRange(PosConfig from,PosConfig to) { return null; }
        /// <summary>
        /// Get the text between the given points in the editor, which should be {line, ch} objects
        /// An optional third argument can be given to indicate the line separator string to use (defaults to "\n").
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public JsString getRange(PosConfig from, PosConfig to, JsString separator) { return null; }

        /// <summary>
        /// Replace the part of the document between from and to with the given string.
        /// from and to must be {line, ch} objects. to can be left off to simply insert the string at position from.
        /// </summary>
        /// <param name="string"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void replaceRange(JsString @string, PosConfig from, PosConfig to) { }
        /// <summary>
        /// Replace the part of the document between from and to with the given string.
        /// from and to must be {line, ch} objects. to can be left off to simply insert the string at position from.
        /// </summary>
        /// <param name="string"></param>
        /// <param name="from"></param>
        public void replaceRange(JsString @string, PosConfig from) { }

        /// <summary>
        /// Calculates and returns a {line, ch} object for a zero-based index who's value is relative to the start of the editor's text.
        /// If the index is out of range of the text then the returned object is clipped to start or end of the text respectively.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public PosConfig posFromIndex(JsNumber index) { return null; }

        /// <summary>
        /// The reverse of posFromIndex.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public JsNumber indexFromPos(PosConfig pos) { return null; }


        #region low-level methods

        /// <summary>
        /// CodeMirror internally buffers changes and only updates its DOM structure after it has finished performing some operation.
        /// If you need to perform a lot of operations on a CodeMirror instance, you can call this method with a function argument.
        /// It will call the function, buffering up all changes, and only doing the expensive update after the function returns.
        /// This can be a lot faster. The return value from this method will be the return value of your function.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public object operation(JsAction func) { return null; }

        /// <summary>
        /// Will call the given function (and return its result), combining all changes made while that function executes into a single undo event.
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public object compoundChange(JsAction func) { return null; }

        /// <summary>
        /// If your code does something to change the size of the editor element (window resizes are already listened for),
        /// or unhides it, you should probably follow up by calling this method to ensure CodeMirror is still looking as intended.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Returns the hidden textarea used to read input.
        /// </summary>
        /// <returns></returns>
        public HtmlTextAreaElement getInputField() { return null; }

        /// <summary>
        /// Returns the DOM node that represents the editor, and controls its width. Remove this from your tree to delete an editor instance. Set it's width style when resizing.
        /// </summary>
        /// <returns></returns>
        public HtmlElement getWrapperElement() { return null; }

        /// <summary>
        /// Returns the DOM node that is responsible for the vertical sizing and horizontal scrolling of the editor.
        /// You can change the height style of this element to resize an editor. (You might have to call the refresh method afterwards.)
        /// </summary>
        /// <returns></returns>
        public HtmlElement getScrollerElement() { return null; }

        /// <summary>
        /// Fetches the DOM node that represents the editor gutter.
        /// </summary>
        /// <returns></returns>
        public HtmlElement getGutterElement() { return null; }

        /// <summary>
        /// Returns the mode's parser state, if any, at the end of the given line number. If no line number is given, the state at the end of the document is returned.
        /// This can be useful for storing parsing errors in the state, or getting other kinds of contextual information for a line.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public object getStateAfter(JsNumber line) { return null; }
        //TODO: return type? 
        /// <summary>
        /// Returns the mode's parser state, if any, at the end of the given line number. If no line number is given, the state at the end of the document is returned.
        /// This can be useful for storing parsing errors in the state, or getting other kinds of contextual information for a line.
        /// </summary>
        /// <returns></returns>
        public object getStateAfter() { return null; }
        //TODO: return type? 
        #endregion


        /// <summary>
        /// Copy the content of the editor into the textarea.
        /// </summary>
        public void save() { }

        /// <summary>
        /// Remove the editor, and restore the original textarea (with the editor's current content).
        /// </summary>
        /// <returns></returns>
        public HtmlTextAreaElement toTextArea() { return null; }

        /// <summary>
        /// Returns the textarea that the instance was based on.
        /// </summary>
        /// <returns></returns>
        public HtmlTextAreaElement getTextArea() { return null; }

        /// <summary>
        /// If you want to define extra methods in terms of the CodeMirror API, it is possible to use CodeMirror.defineExtension(name, value).
        /// This will cause the given value (usually a method) to be added to all CodeMirror instances created from then on.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void defineExtension(JsString name, JsString value) { }


    }

    /// <summary>
    /// Both the CodeMirror function and its fromTextArea method take as second (optional) argument an object containing configuration options.
    /// Any option not supplied like this will be taken from CodeMirror.defaults, an object containing the default options.
    /// You can update this object to change the defaults on your page.
    /// Options are not checked in any way, so setting bogus option values is bound to lead to odd errors.
    /// </summary>
    public class CodeMirrorConfiguration
    {
        /// <summary>
        /// The starting value of the editor.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// The mode to use. When not given, this will default to the first mode that was loaded. It may be a string, which either simply names the mode or is a MIME type associated with the mode.
        /// Alternatively, it may be an object containing configuration options for the mode, with a name property that names the mode (for example {name: "javascript", json: true}).
        /// The demo pages for each mode contain information about what configuration parameters the mode supports.
        /// You can ask CodeMirror which modes and MIME types are loaded with the CodeMirror.listModes and CodeMirror.listMIMEs functions.
        /// </summary>
        public JsString mode { get; set; }
        /// <summary>
        /// The mode to use. When not given, this will default to the first mode that was loaded. It may be a string, which either simply names the mode or is a MIME type associated with the mode.
        /// Alternatively, it may be an object containing configuration options for the mode, with a name property that names the mode (for example {name: "javascript", json: true}).
        /// The demo pages for each mode contain information about what configuration parameters the mode supports.
        /// You can ask CodeMirror which modes and MIME types are loaded with the CodeMirror.listModes and CodeMirror.listMIMEs functions.
        /// </summary>
        [JsProperty(Name="mode")]
        public object modeObject { get; set; }

        /// <summary>
        /// The theme to style the editor with. You must make sure the CSS file defining the corresponding .cm-s-[name] styles is loaded (see the theme directory in the distribution).
        /// The default is "default", for which colors are included in codemirror.css.
        /// It is possible to use multiple theming classes at once—for example "foo bar" will assign both the cm-s-foo and the cm-s-bar classes to the editor.
        /// </summary>
        public JsString theme { get; set; }

        /// <summary>
        /// How many spaces a block (whatever that means in the edited language) should be indented. The default is 2.
        /// </summary>
        public JsNumber indentUnit { get; set; }

        /// <summary>
        /// Whether to use the context-sensitive indentation that the mode provides (or just indent the same as the line before). Defaults to true.
        /// </summary>
        public bool smartIndent { get; set; }

        /// <summary>
        /// The width of a tab character. Defaults to 4.
        /// </summary>
        public JsNumber tabSize { get; set; }

        /// <summary>
        /// Whether, when indenting, the first N*tabSize spaces should be replaced by N tabs. Default is false.
        /// </summary>
        public bool indentWithTabs { get; set; }

        /// <summary>
        /// Configures whether the editor should re-indent the current line when a character is typed that might change its proper indentation
        /// (only works if the mode supports indentation). Default is true.
        /// </summary>
        public bool electricChars { get; set; }

        /// <summary>
        /// When turned on (default is off), this will automatically clear lines consisting only of whitespace when the cursor leaves them.
        /// This is mostly useful to prevent auto indentation from introducing trailing whitespace in a file.
        /// </summary>
        public bool autoClearEmptyLines { get; set; }

        /// <summary>
        /// Configures the keymap to use. The default is "default", which is the only keymap defined in codemirror.js itself. Extra keymaps are found in the keymap directory.
        /// See the section on keymaps for more information.
        /// </summary>
        public JsString keyMap { get; set; }

        /// <summary>
        /// Can be used to specify extra keybindings for the editor, alongside the ones defined by keyMap. Should be either null, or a valid keymap value.
        /// </summary>
        public object extraKeys { get; set; }

        /// <summary>
        /// Whether CodeMirror should scroll or wrap for long lines. Defaults to false (scroll).
        /// </summary>
        public bool lineWrapping { get; set; }

        /// <summary>
        /// Whether to show line numbers to the left of the editor.
        /// </summary>
        public bool lineNumbers { get; set; }

        /// <summary>
        /// At which number to start counting lines. Default is 1.
        /// </summary>
        public JsNumber firstLineNumber { get; set; }

        /// <summary>
        /// A function used to format line numbers. The function is passed the current line number. Default prints the line number verbatim.
        /// </summary>
        public JsAction<JsNumber> lineNumberFormatter { get; set; }

        /// <summary>
        /// Can be used to force a 'gutter' (empty space on the left of the editor) to be shown even when no line numbers are active. This is useful for setting markers.
        /// </summary>
        public bool gutter { get; set; }

        /// <summary>
        /// When enabled (off by default), this will make the gutter stay visible when the document is scrolled horizontally.
        /// </summary>
        public bool fixedGutter { get; set; }

        /// <summary>
        /// This disables editing of the editor content by the user. If the special value "nocursor" is given (instead of simply true), focusing of the editor is also disallowed.
        /// </summary>
        public bool readOnly { get; set; }

        /// <summary>
        /// When given, this function will be called every time the content of the editor is changed. It will be given the editor instance as first argument,
        /// and an {from, to, text, next} object containing information about the changes that occurred as second argument. from and to are the positions
        /// (in the pre-change coordinate system) where the change started and ended (for example, it might be {ch:0, line:18} if the position is at the beginning of line #19).
        /// text is an array of strings representing the text that replaced the changed range (split by line). If multiple changes happened during a single operation,
        /// the object will have a next property pointing to another change object (which may point to another, etc).
        /// </summary>
        public JsAction onChange { get; set; }

        /// <summary>
        /// Will be called when the cursor or selection moves, or any change is made to the editor content.
        /// </summary>
        public JsAction onCursorActivity { get; set; }

        /// <summary>
        /// When given, will be called whenever the view port of the editor changes (due to scrolling, editing, or any other factor).
        /// It will be passed three arguments, the editor instance, the start of the viewport, and its end.
        /// </summary>
        public JsAction onViewportChange { get; set; }

        /// <summary>
        /// When given, will be called whenever the editor gutter (the line-number area) is clicked.
        /// Will be given the editor instance as first argument, the (zero-based) number of the line that was clicked as second argument, and the raw mousedown event object as third argument.
        /// </summary>
        public JsAction onGutterClick { get; set; }

        /// <summary>
        ///  functions will be called whenever the editor is focused or unfocused.
        /// </summary>
        public JsAction onFocus { get; set; }

        /// <summary>
        /// functions will be called whenever the editor is focused or unfocused.
        /// </summary>
        public JsAction onBlur { get; set; }

        /// <summary>
        /// When given, will be called whenever the editor is scrolled.
        /// </summary>
        public JsAction onScroll { get; set; }

        /// <summary>
        /// Whenever the editor's content has been fully highlighted, this function (if given) will be called. It'll be given a single argument, the editor instance.
        /// </summary>
        public JsAction onHighlightComplete { get; set; }

        /// <summary>
        /// Will be called whenever CodeMirror updates its DOM display.
        /// </summary>
        public JsAction onUpdate { get; set; }

        /// <summary>
        /// Determines whether brackets are matched whenever the cursor is moved next to a bracket.
        /// </summary>
        public bool matchBrackets { get; set; }

        /// <summary>
        /// Half-period in milliseconds used for cursor blinking. The default blink rate is 530ms.
        /// </summary>
        public JsNumber cursorBlinkRate { get; set; }

        /// <summary>
        /// Highlighting is done by a pseudo background-thread that will work for workTime milliseconds, and then use timeout to sleep for workDelay milliseconds.
        /// The defaults are 200 and 300, you can change these options to make the highlighting more or less aggressive.
        /// </summary>
        public JsNumber workTime { get; set; }

        /// <summary>
        /// Highlighting is done by a pseudo background-thread that will work for workTime milliseconds, and then use timeout to sleep for workDelay milliseconds.
        /// The defaults are 200 and 300, you can change these options to make the highlighting more or less aggressive.
        /// </summary>
        public JsNumber workDelay { get; set; }

        /// <summary>
        /// Indicates how quickly CodeMirror should poll its input textarea for changes. Most input is captured by events, but some things,
        /// like IME input on some browsers, doesn't generate events that allow CodeMirror to properly detect it. Thus, it polls. Default is 100 milliseconds.
        /// </summary>
        public JsNumber pollInterval { get; set; }

        /// <summary>
        /// The maximum number of undo levels that the editor stores. Defaults to 40.
        /// </summary>
        public JsNumber undoDepth { get; set; }

        /// <summary>
        /// The tab index to assign to the editor. If not given, no tab index will be assigned.
        /// </summary>
        public JsNumber tabindex { get; set; }

        /// <summary>
        /// Can be used to make CodeMirror focus itself on initialization. Defaults to off. When fromTextArea is used, and no explicit value is given for this option,
        /// it will be set to true when either the source textarea is focused, or it has an autofocus attribute and no other element is focused.
        /// </summary>
        public bool autofocus { get; set; }

        /// <summary>
        /// Controls whether drag-and-drop is enabled. On by default.
        /// </summary>
        public bool dragDrop { get; set; }

        /// <summary>
        /// When given, this will be called when the editor is handling a dragenter, dragover, or drop event. It will be passed the editor instance and the event object as arguments.
        /// The callback can choose to handle the event itself, in which case it should return true to indicate that CodeMirror should not do anything further.
        /// </summary>
        public JsAction onDragEvent { get; set; }

        /// <summary>
        /// This provides a rather low-level hook into CodeMirror's key handling. If provided, this function will be called on every keydown, keyup, and keypress event that CodeMirror captures. It will be passed two arguments, the editor instance and the key event.
        /// This key event is pretty much the raw key event, except that a stop() method is always added to it. You could feed it to, for example, jQuery.Event to further normalize it.
        /// This function can inspect the key event, and handle it if it wants to. It may return true to tell CodeMirror to ignore the event. Be wary that, on some browsers, stopping a keydown does not stop the keypress from firing, whereas on others it does.
        /// If you respond to an event, you should probably inspect its type property and only do something when it is keydown (or keypress for actions that need character data).
        /// </summary>
        public JsAction onKeyEvent { get; set; }
    }

    public class ScrollInfo
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber width { get; set; }
        public JsNumber height { get; set; }
    }

    public class CursorCoords
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber yBot { get; set; }

    }

    public class PosConfig
    {
        public JsNumber line { get; set; }
        public JsNumber ch { get; set; }

    }

    public class XYObject
    {
        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
    }

    public class HistorySize
    {
        public JsNumber undo { get; set; }
        public JsNumber redo { get; set; }

    }

    public class TokenAt
    {
        /// <summary>
        /// The character (on the given line) at which the token starts.
        /// </summary>
        public JsNumber start { get; set; }
        /// <summary>
        /// The character at which the token ends.
        /// </summary>
        public JsNumber end { get; set; }
        /// <summary>
        /// The token's string.
        /// </summary>
        public JsString @string { get; set; }
        /// <summary>
        /// The class the mode assigned to the token. (Can be null when no class was assigned.)
        /// </summary>
        public JsNumber className { get; set; }
        /// <summary>
        /// The mode's state at the end of this token.
        /// </summary>
        public object state { get; set; }
    }

    public class MarkTextResult
    {
        public void clear() { }
        public Range find() { return null; }
    }

    public class Range
    {
        public PosConfig from { get; set; }
        public PosConfig to { get; set; }
    }

    public class LineHandle
    {
        //TODO:
    }

    public class LineInfo
    {
        public JsNumber line { get; set; }
        public LineHandle handle { get; set; }
        public JsString text { get; set; }
        public JsString markerText { get; set; }
        public JsString markerClass { get; set; }
        public JsString lineClass { get; set; }
        public JsString bgClass { get; set; }
    }

    //TODO: addons

    public class CodeMirrorStream
    {
        /// <summary>
        /// Returns true only if the stream is at the end of the line.
        /// </summary>
        /// <returns></returns>
        public bool eol() { return false; }

        /// <summary>
        /// Returns true only if the stream is at the start of the line.
        /// </summary>
        /// <returns></returns>
        public bool sol() { return false; }

        /// <summary>
        /// Returns the next character in the stream without advancing it. Will return an empty string at the end of the line.
        /// </summary>
        /// <returns></returns>
        public JsString peek() { return null; }

        /// <summary>
        /// Returns the next character in the stream and advances it. Also returns undefined when no more characters are available.
        /// </summary>
        /// <returns></returns>
        public JsString next() { return null; }

        /// <summary>
        /// match can be a character, a regular expression, or a function that takes a character and returns a boolean.
        /// If the next character in the stream 'matches' the given argument, it is consumed and returned. Otherwise, undefined is returned.
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public JsString eat(object match) { return null; }

        /// <summary>
        /// Repeatedly calls eat with the given argument, until it fails. Returns true if any characters were eaten.
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public bool eatWhile(object match) { return false; }

        /// <summary>
        /// Shortcut for eatWhile when matching white-space.
        /// </summary>
        /// <returns></returns>
        public bool eatSpace() { return false; }

        /// <summary>
        /// Moves the position to the end of the line.
        /// </summary>
        public void skipToEnd() { }

        /// <summary>
        /// Skips to the next occurrence of the given character,if found on the current line (doesn't advance the stream if the character does not occur on the line).
        /// Returns true if the character was found.
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public bool skipTo(JsString ch) { return false; }

        /// <summary>
        /// Act like a multi-character eat—if consume is true or not given—or a look-ahead that doesn't update the stream position—if it is false.
        /// pattern can be either a string or a regular expression starting with ^. When it is a string, caseFold can be set to true to make the match case-insensitive.
        /// When successfully matching a regular expression,the returned value will be the array returned by match, in case you need to extract matched groups.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="consume"></param>
        /// <param name="caseFold"></param>
        /// <returns></returns>
        public object match(object pattern, object consume, object caseFold) { return null; }

        /// <summary>
        /// Backs up the stream n characters. Backing it up further than the start of the current token will cause things to break, so be careful.
        /// </summary>
        /// <param name="n"></param>
        public void backUp(JsString n) { }

        /// <summary>
        /// Returns the column (taking into account tabs) at which the current token starts. Can be used to find out whether a token starts a new line.
        /// </summary>
        /// <returns></returns>
        public JsNumber column() { return null; }

        /// <summary>
        /// Tells you how far the current line has been indented, in spaces. Corrects for tab characters.
        /// </summary>
        /// <returns></returns>
        public JsNumber indentation() { return null; }

        /// <summary>
        /// Get the string between the start of the current token and the current stream position.
        /// </summary>
        /// <returns></returns>
        public JsString current() { return null; }

    }
}
