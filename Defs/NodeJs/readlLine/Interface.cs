using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.NodeJs
{
    /// <summary>
    /// <p>The class that represents a readline interface with an input and output
    /// stream.
    /// </p>
    /// </summary>
    public partial class Interface
    {
        /// <summary>
        /// Closes the Interface instance, relinquishing control on the input and output streams. The "close" event will also be emitted.
        /// </summary>
        public object close() { return null; }
        /// <summary>
        /// Pauses the readline input stream, allowing it to be resumed later if needed.
        /// </summary>
        public object pause() { return null; }
        /// <summary>
        /// <p>Readies readline for input from the user, putting the current <code>setPrompt</code>
        /// options on a new line, giving the user a new spot to write. Set <code>preserveCursor</code>
        /// to <code>true</code> to prevent the cursor placement being reset to <code>0</code>.
        /// </p>
        /// <p>This will also resume the <code>input</code> stream used with <code>createInterface</code> if it has
        /// been paused.
        /// </p>
        /// </summary>
        public object prompt() { return null; }
        /// <summary>
        /// Readies readline for input from the user, putting the current setPrompt options on a new line, giving the user a new spot to write. 
        /// Set preserveCursor to true to prevent the cursor placement being reset to 0.
        ///
        /// This will also resume the input stream used with createInterface if it has been paused.
        /// </summary>
        public object prompt(bool preserveCursor) { return null; }
        /// <summary>
        /// Prepends the prompt with query and invokes callback with the user's response. 
        /// Displays the query to the user, and then invokes callback with the user's response after it has been typed.
        /// This will also resume the input stream used with createInterface if it has been paused.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        /// <example>
        /// Example usage:
        /// <code>
        /// interface.question('What is your favorite food?', function(answer) {
        ///     console.log('Oh, so your favorite food is ' + answer);
        /// });
        /// </code>
        /// </example>
        public object question(JsString query, JsAction callback) { return null; }
        /// <summary>
        /// <p>Resumes the readline <code>input</code> stream.
        /// </p>
        /// </summary>
        public object resume() { return null; }
        /// <summary>
        /// <p>Sets the prompt, for example when you run <code>node</code> on the command line, you see
        /// <code>&gt; </code>, which is node&#39;s prompt.
        /// </p>
        /// </summary>
        public object setPrompt(JsString prompt, JsNumber length) { return null; }
        /// <summary>
        /// Writes data to output stream. key is an object literal to represent a key sequence; available if the terminal is a TTY.
        ///
        /// This will also resume the input stream if it has been paused.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// rl.write('Delete me!');
        /// // Simulate ctrl+u to delete the line written previously
        /// rl.write(null, {ctrl: true, name: 'u'});
        /// </code>
        /// </example>
        public object write(object data) { return null; }
        /// <summary>
        /// Writes data to output stream. key is an object literal to represent a key sequence; available if the terminal is a TTY.
        ///
        /// This will also resume the input stream if it has been paused.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <example>
        /// Example:
        /// <code>
        /// rl.write('Delete me!');
        /// // Simulate ctrl+u to delete the line written previously
        /// rl.write(null, {ctrl: true, name: 'u'});
        /// </code>
        /// </example>
        public object write(object data, object key) { return null; }
        #region events
        /// <summary>
        /// Emitted whenever the input stream receives a \n, usually received when the user hits enter, or return. This is a good hook to listen for user input.
        /// </summary>
        /// <example>
        /// Example of listening for line:
        /// <code>
        /// rl.on('line', function (cmd) {
        ///  console.log('You just typed: '+cmd);
        /// });
        /// </code>
        /// </example>
        public JsAction line { get; set; }
        /// <summary>
        /// Emitted whenever the input stream is paused.
        /// Also emitted whenever the input stream is not paused and receives the SIGCONT event. (See events SIGTSTP and SIGCONT)  
        /// </summary>
        /// <example>
        /// Example of listening for pause:
        /// <code>
        /// rl.on('pause', function() {
        ///  console.log('Readline paused.');
        /// });
        /// </code>
        /// </example>
        [JsProperty(Name = "pause")]
        public JsAction pauseEvent { get; set; }
        /// <summary>
        /// Emitted whenever the input stream is resumed. 
        /// </summary>
        /// <example>
        /// Example of listening for resume:
        /// <code>
        /// rl.on('resume', function() {
        ///  console.log('Readline resumed.');
        /// });
        /// </code>
        /// </example>
        [JsProperty(Name = "resume")]
        public JsAction resumeEvent { get; set; }
        /// <summary>
        /// Emitted when close() is called.
        /// Also emitted when the input stream receives its "end" event. The Interface instance should be considered "finished" once this is emitted. 
        /// For example, when the input stream receives ^D, respectively known as EOT.
        ///
        /// This event is also called if there is no SIGINT event listener present when the input stream receives a ^C, respectively known as SIGINT.
        /// </summary>
        [JsProperty(Name = "close")]
        public JsAction closeEvent { get; set; }
        /// <summary>
        /// Emitted whenever the input stream receives a ^C, respectively known as SIGINT. 
        /// If there is no SIGINT event listener present when the input stream receives a SIGINT, pause will be triggered. 
        /// </summary>
        /// <example>
        /// Example of listening for SIGINT:
        /// <code>
        /// rl.on('SIGINT', function() {
        ///     rl.question('Are you sure you want to exit?', function(answer) {
        ///         if (answer.match(/^y(es)?$/i)) rl.pause();
        ///     });
        /// });
        /// </code>
        /// </example>
        public JsAction SIGINT { get; set; }
        /// <summary>
        /// This does not work on Windows.
        /// Emitted whenever the input stream receives a ^Z, respectively known as SIGTSTP. 
        /// If there is no SIGTSTP event listener present when the input stream receives a SIGTSTP, the program will be sent to the background.
        /// When the program is resumed with fg, the pause and SIGCONT events will be emitted. You can use either to resume the stream.
        /// The pause and SIGCONT events will not be triggered if the stream was paused before the program was sent to the background. 
        /// </summary>
        /// <example>
        /// Example of listening for SIGTSTP:
        /// <code>
        /// rl.on('SIGTSTP', function() {
        ///  // This will override SIGTSTP and prevent the program from going to the
        ///  // background.
        ///     console.log('Caught SIGTSTP.');
        /// });
        /// </code>
        /// </example>
        public JsAction SIGTSTP { get; set; }
        /// <summary>
        /// This does not work on Windows.
        /// Emitted whenever the input stream is sent to the background with ^Z, respectively known as SIGTSTP, and then continued with fg(1). 
        /// This event only emits if the stream was not paused before sending the program to the background. 
        /// </summary>
        /// <example>
        /// Example of listening for SIGCONT:
        /// <code>
        /// rl.on('SIGCONT', function() {
        ///  // `prompt` will automatically resume the stream
        ///  rl.prompt();
        /// });
        /// </code>
        /// </example>
        public JsAction SIGCONT { get; set; }
        #endregion
    }
}
