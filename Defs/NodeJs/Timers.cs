using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;

namespace SharpKit.NodeJs
{
    /// <summary>
    /// Timers
    /// Stability: 5 - Locked
    /// All of the timer functions are globals. You do not need to require() this module in order to use them.
    /// </summary>
    class Timers
    {
        /// <summary>
        /// To schedule execution of a one-time callback after delay milliseconds.
        /// </summary>
        /// <param name="callback">
        /// It is important to note that your callback will probably not be called in exactly delay milliseconds - 
        /// Node.js makes no guarantees about the exact timing of when the callback will fire, nor of the ordering things will fire in. 
        /// The callback will be called as close as possible to the time specified.
        /// </param>
        /// <param name="delay"></param>
        /// <returns>Returns a timeoutId for possible use with clearTimeout().</returns>
        public object setTimeout(JsAction callback, object delay) { return null; }
        /// <summary>
        /// To schedule execution of a one-time callback after delay milliseconds.
        /// </summary>
        /// <param name="callback">
        /// It is important to note that your callback will probably not be called in exactly delay milliseconds - 
        /// Node.js makes no guarantees about the exact timing of when the callback will fire, nor of the ordering things will fire in. 
        /// The callback will be called as close as possible to the time specified.
        /// </param>
        /// <param name="delay"></param>
        /// <param name="arg">Optionally you can also pass arguments to the callback</param>
        /// <returns>Returns a timeoutId for possible use with clearTimeout().</returns>
        public object setTimeout(JsAction callback, object delay, object arg) { return null; }
        /// <summary>
        /// To schedule execution of a one-time callback after delay milliseconds.
        /// </summary>
        /// <param name="callback">
        /// It is important to note that your callback will probably not be called in exactly delay milliseconds - 
        /// Node.js makes no guarantees about the exact timing of when the callback will fire, nor of the ordering things will fire in. 
        /// The callback will be called as close as possible to the time specified.
        /// </param>
        /// <param name="delay"></param>
        /// <param name="obj"></param>
        /// <returns>Returns a timeoutId for possible use with clearTimeout().</returns>
        public object setTimeout(JsAction callback, object delay, params object[] obj) { return null; }
        /// <summary>
        /// To schedule execution of a one-time callback after delay milliseconds.
        /// </summary>
        /// <param name="callback">
        /// It is important to note that your callback will probably not be called in exactly delay milliseconds - 
        /// Node.js makes no guarantees about the exact timing of when the callback will fire, nor of the ordering things will fire in. 
        /// The callback will be called as close as possible to the time specified.
        /// </param>
        /// <param name="delay"></param>
        /// <param name="arg">Optionally you can also pass arguments to the callback</param>
        /// <param name="obj"></param>
        /// <returns>Returns a timeoutId for possible use with clearTimeout().</returns>
        public object setTimeout(JsAction callback, object delay, object arg, params object[] obj) { return null; }
        /// <summary>
        /// Prevents a timeout from triggering.
        /// </summary>
        /// <param name="timeoutId"></param>
        /// <returns></returns>
        public object clearTimeout(object timeoutId) { return null; }
        /// <summary>
        /// To schedule the repeated execution of callback every delay milliseconds. 
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="delay"></param>
        /// <returns> Returns a intervalId for possible use with clearInterval().</returns>
        public object setInterval(JsAction callback, object delay) { return null; }
        /// <summary>
        /// To schedule the repeated execution of callback every delay milliseconds. 
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="delay"></param>
        /// <param name="arg"></param>
        /// <returns>Returns a intervalId for possible use with clearInterval().</returns>
        public object setInterval(JsAction callback, object delay, object arg) { return null; }
        /// <summary>
        /// To schedule the repeated execution of callback every delay milliseconds. 
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="delay"></param>
        /// <param name="obj"></param>
        /// <returns>Returns a intervalId for possible use with clearInterval().</returns>
        public object setInterval(JsAction callback, object delay, params object[] obj) { return null; }
        /// <summary>
        /// To schedule the repeated execution of callback every delay milliseconds. 
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="delay"></param>
        /// <param name="arg"></param>
        /// <param name="obj">Optionally you can also pass arguments to the callback.</param>
        /// <returns>Returns a intervalId for possible use with clearInterval().</returns>
        public object setInterval(JsAction callback, object delay, object arg, params object[] obj) { return null; }
        /// <summary>
        /// Stops a interval from triggering. 
        /// </summary>
        /// <param name="intervalId"></param>
        /// <returns></returns>
        public object clearInterval(object intervalId) { return null; }
    }
}
