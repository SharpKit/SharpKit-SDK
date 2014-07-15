using SharpKit.JavaScript;

namespace SharpKit.JavaScript
{
    [JsType(JsMode.Prototype, Export = false, Name = "console")]
    public class FirebugConsole
    {
        public static void log(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Writes a message to the console, including a hyperlink to the line where it was called. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void debug(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Writes a message to the console with the visual "info" icon and color coding and a hyperlink to the line where it was called. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void info(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Writes a message to the console with the visual "warning" icon and color coding and a hyperlink to the line where it was called. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void warn(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Writes a message to the console with the visual "error" icon and color coding and a hyperlink to the line where it was called. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void error(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Tests that an expression is true. If not, it will write a message to the console and throw an exception. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void assert(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Clears the console. 
        /// </summary>
        public static void clear()
        {

        }

        /// <summary>
        /// Prints an interactive listing of all properties of the object. This looks identical to the view that you would see in the DOM tab. 
        /// </summary>
        /// <param name="obj"></param>
        public static void dir(object obj)
        {

        }

        /// <summary>
        /// Prints the XML source tree of an HTML or XML element. This looks identical to the view that you would see in the HTML tab. You can click on any node to inspect it in the HTML tab. 
        /// </summary>
        /// <param name="obj"></param>
        public static void dirxml(object obj)
        {

        }

        /// <summary>
        /// Prints an interactive stack trace of JavaScript execution at the point where it is called. The stack trace details the functions on the stack, as well as the values that were passed as arguments to each function. You can click each function to take you to its source in the Script tab, and click each argument value to inspect it in the DOM or HTML tabs. 
        /// </summary>
        public static void trace()
        {

        }

        /// <summary>
        /// Writes a message to the console and opens a nested block to indent all future messages sent to the console. Call console.groupEnd() to close the block. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void group(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Like console.group(), but the block is initially collapsed.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        public static void groupCollapsed(object obj, params object[] args)
        {

        }

        /// <summary>
        /// Closes the most recently opened block created by a call to console.group() or console.groupCollapsed()
        /// </summary>
        public static void groupEnd()
        {

        }

        /// <summary>
        /// Creates a new timer under the given name. Call console.timeEnd(name) with the same name to stop the timer and print the time elapsed.
        /// </summary>
        /// <param name="name"></param>
        public static void time(JsString name)
        {

        }

        /// <summary>
        /// Stops a timer created by a call to console.time(name) and writes the time elapsed.
        /// </summary>
        /// <param name="name"></param>
        public static void timeEnd(JsString name)
        {

        }

        /// <summary>
        /// Turns on the JavaScript profiler. The optional argument title would contain the text to be printed in the header of the profile report.
        /// </summary>
        /// <param name="title"></param>
        public static void profile(JsString title)
        {

        }

        /// <summary>
        /// Turns off the JavaScript profiler and prints its report.
        /// </summary>
        /// <param name="title"></param>
        public static void profileEnd(JsString title)
        {

        }

        /// <summary>
        /// Writes the number of times that the line of code where count was called was executed. The optional argument title will print a message in addition to the number of the count.
        /// </summary>
        /// <param name="title"></param>
        public static void count(JsString title)
        {

        }

        /// <summary>
        /// Prints an error message together with an interactive stack trace of JavaScript execution at the point where the exception occurred.
        /// </summary>
        /// <param name="errorObject"></param>
        /// <param name="args"></param>
        public static void exception(object errorObject, params object[] args)
        {

        }

        /// <summary>
        /// Prints an error message together with an interactive stack trace of JavaScript execution at the point where the exception occurred.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="columns"></param>
        public static void table(object data, params object[] columns)
        {

        }


    }
}