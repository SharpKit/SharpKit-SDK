using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace log4javascript
{
    /// <summary>
    /// A flexible appender that asynchronously sends log messages to a server via HTTP
    /// </summary>
    public class AjaxAppender : Appender
    {
        public override JsString toString() { return default(JsString); }
        public override void append(LoggingEvent loggingEvent) { }

        /// <summary>
        /// Create a new AjaxAppender
        /// </summary>
        /// <param name="url">The URL to which log messages should be sent. Note that this is subject to the usual Ajax restrictions: the URL should be in the same domain as that of the page making the request</param>
        public AjaxAppender(JsString url) { }
        /// <summary>
        /// [not available after first message logged] 
        /// Whether to send all remaining unsent log messages to the server when the page unloads.
        /// </summary>
        /// <param name="sendAllOnUnload"></param>
        public void setSendAllOnUnload(JsBoolean sendAllOnUnload) { }
        /// <summary>
        /// Returns whether all remaining unsent log messages are sent to the server when the page unloads.
        /// </summary>
        /// <returns></returns>
        public JsBoolean isSendAllOnUnload() { return default(JsBoolean); }
        /// <summary>
        /// [not available after first message logged] 
        /// Sets the post variable name whose value will the formatted log message(s) for each request.  Default value is data
        /// </summary>
        /// <param name="postVarName"></param>
        public void setPostVarName(JsString postVarName) { }
        /// <summary>
        /// Returns the post variable name whose value will the formatted log message(s) for each request
        /// </summary>
        /// <returns></returns>
        public JsString getPostVarName() { return default(JsString); }
        /// <summary>
        /// [not available after first message logged] 
        /// Whether to send log messages to the server at regular, timed intervals. Default value is false. 
        /// </summary>
        /// <param name="timed"></param>
        public void setTimed(Boolean timed) { }
        /// <summary>
        /// Returns whether log messages are sent to the server at regular, timed intervals
        /// </summary>
        /// <returns></returns>
        public JsBoolean isTimed() { return default(JsBoolean); }
        /// <summary>
        /// [not available after first message logged] 
        /// Sets whether to wait for a response from a previous HTTP request from this appender before sending the next log message / batch of messages. Default value is false. 
        /// </summary>
        /// <param name="waitForResponse"></param>
        public void setWaitForResponse(JsBoolean waitForResponse) { }
        /// <summary>
        /// Returns whether the appender waits for a response from a previous HTTP request from this appender before sending the next log message / batch of messages. 
        /// </summary>
        /// <returns></returns>
        public JsBoolean isWaitForResponse() { return default(JsBoolean); }
        /// <summary>
        /// [not available after first message logged] 
        /// Sets the number of log messages to send in each request. If not specified, defaults to 1.
        /// </summary>
        /// <param name="batchSize"></param>
        public void setBatchSize(JsNumber batchSize) { }
        /// <summary>
        /// Returns the number of log messages sent in each request
        /// </summary>
        /// <returns></returns>
        public JsNumber getBatchSize() { return default(JsNumber); }
        /// <summary>
        /// [not available after first message logged] 
        /// Sets the length of time in milliseconds between each sending of queued log messages.
        /// </summary>
        /// <param name="timerInterval"></param>
        public void setTimerInterval(JsNumber timerInterval) { }
        /// <summary>
        /// Returns the length of time in milliseconds between each sending of queued log messages
        /// </summary>
        /// <returns></returns>
        public JsNumber getTimerInterval() { return default(JsNumber); }
        /// <summary>
        /// Sets the function that is called whenever a successful request is made, called at the point at which the response is received. This feature can be used to confirm whether a request has been successful and act accordingly. 
        /// A single parameter, xmlHttp, is passed to the callback function. This is the XMLHttpRequest object that performed the request.
        /// </summary>
        /// <param name="requestSuccessCallback"></param>
        public void setRequestSuccessCallback(JsAction<XMLHttpRequest> requestSuccessCallback) { }
        /// <summary>
        /// Sets the function that is called whenever any kind of failure occurs in the appender, including browser deficiencies or configuration errors (e.g. supplying a non-existent URL to the appender). This feature can be used to handle AjaxAppender-specific errors. 
        /// A single parameter, message, is passed to the callback function. This is the error-specific message that caused the failure.
        /// </summary>
        /// <param name="failCallback"></param>
        public void setFailCallback(JsAction<JsString> failCallback) { }
        /// <summary>
        /// Sets the session id sent to the server each time a request is made
        /// </summary>
        /// <param name="sessionId"></param>
        public void setSessionId(JsString sessionId) { }
        /// <summary>
        /// Returns the session id sent to the server each time a request is made
        /// </summary>
        /// <returns></returns>
        public JsString getSessionId() { return default(JsString); }
        /// <summary>
        /// Adds an HTTP header that is sent with each request
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void addHeader(JsString name, JsString value) { }
        /// <summary>
        /// Returns an array of the additional headers that are sent with each HTTP request. Each array item is an object with properties name and value. 
        /// </summary>
        /// <returns></returns>
        public JsArray<Header> getHeaders() { return default(JsArray<Header>); }
        /// <summary>
        /// Sends all log messages in the queue. If log messages are batched then only completed batches are sent
        /// </summary>
        public void sendAll() { }
    }
}
