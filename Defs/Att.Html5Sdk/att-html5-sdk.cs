using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Html5Sdk
{
    #region provider
    //TODO: return value of all methods
    [JsType(JsMode.Prototype, Export = false, Name = "Att.Provider")]
    public partial class _Provider
    {
        /// <summary>
        /// Initiate client authorization window for the user to authorize the application against the given authScopes.
        /// </summary>
        /// <param name="options">An object which may contain the following properties: authScope, success or failure.
        /// </param>
        public object authorizeApp(AuthorizeOptions options) { return null; }

        /// <summary>
        /// ssues a request to cancel a subscription
        /// </summary>
        /// <param name="options"></param>
        public void cancelSubscription(CancelSubscriptionOptions options) { }

        /// <summary>
        /// Initiates a Tropo Session and delivers an object of key/value pairs to pass to the Tropo script
        /// </summary>
        /// <param name="options"></param>
        public void cmsCreateSession(CmsCreateSessionOptions options) { }

        /// <summary>
        /// Sends a signal to an active CMS session script.
        /// </summary>
        /// <param name="options"></param>
        public void cmdSendSignal(CmsSendSignalOptions options) { }

        /// <summary>
        /// Returns information on a device
        /// </summary>
        /// <param name="options">An object which may contain the following properties: success or failure</param>
        public void getDeviceInfo(GetDeviceInfoOptions options) { }

        /// <summary>
        /// Returns location info for a device
        /// </summary>
        /// <param name="options"></param>
        /// <exexample>
        /// <code>
        /// var provider = new Att.Provider();
        /// provider.getDeviceLocation({
        ///    requestedAccuracy: 1000
        /// });
        /// </code>
        /// </exexample>
        public void getDeviceLocation(GetDeviceInfoOptions options) { }
        /// <summary>
        /// Retrieves SMS and MMS message headers.
        /// </summary>
        /// <param name="options"></param>
        //TODO: BETA?
        public void getMessageHeaders(GetMessageHeadersOptions options) { }
        /// <summary>
        /// Checks the status of a sent MMS
        /// </summary>
        /// <param name="options"></param>
        public void getMmsStatus(GetMmsStatusOptions options) { }
        /// <summary>
        /// checks the status of a sent SMS.
        /// </summary>
        /// <param name="options"></param>
        public void getSmsStatus(GetSmsStatusOptions options) { }
        /// <summary>
        /// Checks the details of subscription.
        /// </summary>
        /// <param name="options"></param>
        public void getSubscriptionDetails(GetSubscriptionDetailsOPtions options) { }
        /// <summary>
        /// Checks the status of a subscription.
        /// </summary>
        /// <param name="options"></param>
        public void getSubscriptionStatus(StatusOptions options) { }
        /// <summary>
        /// Checks the status of a transaction.
        /// </summary>
        /// <param name="options"></param>
        public void getTransactionStatus(StatusOptions options) { }
        /// <summary>
        /// Checks to see if the app is authorized against the given authScopes.
        /// </summary>
        /// <param name="options"></param>
        public void isAuthorized(AuthorizeOptions options) { }
        /// <summary>
        /// Retrieves a list of SMSs sent to the application's short code.
        /// </summary>
        /// <param name="options"></param>
        public void recieveSms(RecieveSmsOptions options) { }
        /// <summary>
        /// Issues a request to refund a transaction.
        /// </summary>
        /// <param name="options"></param>
        public void refundTransaction(RefundTransactionOptions options) { }
        /// <summary>
        /// Requests a subscription based on the payment options passed. 
        /// This method will present a popup to the user where they will be given the opportunity to authorize or decline the transaction with AT&T.
        /// </summary>
        /// <param name="options"></param>
        /// <example>
        /// Success callback example (when payments work)
        /// <code>
        ///  function(results) { console.log("payment worked!", results.error, results.error_reason, results.error_description);}
        /// </code>
        /// </example>
        /// <example>
        /// Failure callback examples (when the user cancels or the payment doesn't complete)
        /// <code>
        /// function(results) { console.log("payment worked!", results.error, results.error_reason, results.error_description);}
        /// </code>
        /// </example>
        /// in the case of user cancel you will get something like this:
        /// <example>
        /// <code>
        ///  error: "access_denied"
        /// error_description: "The user denied your request"
        /// error_reason: "user_denied"
        /// </code>
        /// </example>
        public void requestPaidSubscription(RequestOptions options) { }
        /// <summary>
        /// Requests a one-time payment based on the options passed. 
        /// This method call will present a pop-up to the user where they will be given the opportunity to either authorize or decline the transaction.
        /// </summary>
        /// <param name="options"></param>
        /// <example>
        /// <code>
        /// var charge = { "Amount":0.99,
        /// "Category":1,
        /// "Channel":"MOBILE_WEB",
        /// "Description":"better than level 1",
        /// "MerchantTransactionId":"skuser2985trx20111029175423",
        /// "MerchantProductId":"level2"}
        /// provider.requestPayment({
        ///     paymentOptions : charge,
        ///     success : successCallback,
        ///     failure : failureCallback
        /// });
        /// </code>
        /// </example>
        public void requestPayment(RequestOptions options) { }
        /// <summary>
        /// Sends an MMS to a recipient
        /// MMS allows for the delivery of different file types please see the developer documentation for an updated list.
        /// </summary>
        /// <param name="options"></param>
        public void sendMms(SendMmsOptions options) { }
        /// <summary>
        /// Sends a Message on behalf Of.
        /// </summary>
        /// <param name="options"></param>
        public void sendMobo(SendMoboOptions options) { }
        /// <summary>
        /// Sends an SMS to a recipient ..
        /// </summary>
        /// <param name="options"></param>
        public void sendSms(SendSmsOptions options) { }
        /// <summary>
        /// Encrypts the payload param so that it can be used in other Payment API calls.
        /// </summary>
        /// <param name="options"></param>
        public void signPayload(SignPayloadOptions options) { }
        /// <summary>
        /// Sends an audio file to retrieve the translation to text
        /// </summary>
        /// <param name="options"></param>
        public void speechToText(SpeechToTextOptions options) { }
        /// <summary>
        /// Sends a WAP Push message
        /// </summary>
        /// <param name="options"></param>
        public void washPush(WashPushOptions options) { }
        /// <summary>
        /// This helper routine will return a properly formatted URL to the SDK routine which will provide the source content (image, text, etc) for the specified message number and part.
        /// </summary>
        /// <param name="messageId">The message id of the message</param>
        /// <param name="partNumber">The part number to retrieve</param>
        /// <returns>The source URL which returns the content of the message part along with appropriate content headers.</returns>
        public static JsString getContentSrc(JsString messageId, JsString partNumber) { return null; }
        /// <summary>
        /// Given an address will determine if it is a valid phone, email or shortcode.
        /// </summary>
        /// <param name="address">{String} the address to validate</param>
        /// <returns>Boolean</returns>
        public static bool isValidAddress(Object address) { return false; }
        /// <summary>
        /// Given an email, returns true or false if the it is in a valid format.
        /// </summary>
        /// <param name="email">the email to validate</param>
        /// <returns>Boolean</returns>
        public static bool isValidEmail(JsString email) { return false; }
        /// <summary>
        /// Given a phone number, returns true or false if the phone number is in a valid format.
        /// </summary>
        /// <param name="phone">the phone number to validate</param>
        /// <returns>Boolean</returns>
        public static bool isValidPhoneNumber(JsString phone) { return false; }
        /// <summary>
        /// Given a shortcode, returns true or false if the it is in a valid format.
        /// </summary>
        /// <param name="shortcode">the short code to validate</param>
        /// <returns>Boolean</returns>
        public static bool isValidShortCode(JsString shortcode) { return false; }
        /// <summary>
        /// Given a valid address, if it is a phone number will return the normalized phone number. See normalizePhoneNumber Otherwise, returns the address as it is.
        /// </summary>
        /// <param name="address"> {String} the address to normalize.</param>
        /// <returns>the normalize phone number or address.</returns>
        public static JsString normalizeAddress(Object address) { return null; }
        /// <summary>
        /// Given a phone number, returns the phone number with all characters, other than numbers, stripped
        /// </summary>
        /// <param name="phone">he phone number to normalize</param>
        /// <returns>the normalized phone number</returns>
        public static JsString normalizePhoneNumber(JsString phone) { return null; }
    }
    #endregion
    #region ProviderOptions
    /// <summary>
    /// Error Handling:
    ///In case an exception or an error happens, detailed information on the exception/error is available in the error property of the response
    /// </summary>
    [JsType(JsMode.Json)]
    public partial class ProviderOptions
    {
        /// <summary>
        ///  (Default: "att") 
        ///  The base uri path to be prepended to all API calls. 
        /// </summary>
        public JsString apiBasePath { get; set; }
        /// <summary>
        /// (Default: "TL,MOBO,MIM,DC")
        /// This is the default authorization scope used to authorize transactions that require scope and it is not provided.
        /// </summary>
        public JsString authScope { get; set; }
    }
    #endregion 
    #region GetMessageHeadersOptions
    [JsType(JsMode.Json)]
    public partial class GetMessageHeadersOptions
    {
        /// <summary>
        /// The number of message headers to retrieve.
        /// </summary>
        public int headerCount { get; set; }

        //TODO: indexCursor : string (optional)?
        /// <summary>
        /// Pointer to start of records to retrieve, obtained from previous call to this method. 
        /// This value should always be empty when this method is first called.
        /// </summary>
        public JsString indexCursor { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region AuthorizeOptions
    [JsType(JsMode.Json)]
    public partial class AuthorizeOptions
    {
        /// <summary>
        /// Comma separated list of authScopes the app requires access to.
        /// </summary>
        public JsString authScope { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region CancelSubscriptionOptions
    [JsType(JsMode.Json)]
    public partial class CancelSubscriptionOptions
    {
        /// <summary>
        /// transaction id to revoke.
        /// </summary>
        public JsString transactionId { get; set; }
        /// <summary>
        /// refund options. See AT&T payment documentation for a complete set of refund options and restrictions.
        /// </summary>
        public JsString refundOPtions { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region CmsCreateSessionOptions

    [JsType(JsMode.Json)]
    public partial class CmsCreateSessionOptions
    {
        /// <summary>
        /// JSON string of key value pairs
        /// </summary>
        public JsString parameters { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region CmsSendSignalOptions
    [JsType(JsMode.Json)]
    public partial class CmsSendSignalOptions
    {
        /// <summary>
        /// The session ID to which to send a signal
        /// </summary>
        public JsString sessionId { get; set; }
        /// <summary>
        /// A signal to send to your active CMS script
        /// </summary>
        public JsString signal { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region GetDeviceInfoOptions
    [JsType(JsMode.Json)]
    public partial class GetDeviceInfoOptions
    {
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region GetDeviceLocationOptaions
    [JsType(JsMode.Json)]
    public partial class GetDeviceLocationOptaions
    {
        /// <summary>
        /// The requested accuracy is given in meters. This parameter shall be present in the resource URI as query parameter. If the requested accuracy cannot be supported, a service exception (SVC0001) with additional information describing the error is returned. Default is 100 meters.
        /// </summary>
        public JsNumber requestedAccuracy { get; set; }
        /// <summary>
        /// The acceptable accuracy is given in meters and influences the type of location service that is used. 
        /// This parameter shall be present in the resource URI as query parameter.
        /// </summary>
        public JsNumber acceptableAccuracy { get; set; }
        /// <summary>
        /// his parameter defines the application's priority of response time versus accuracy.
        /// Valid values are:
        /// <bullet> NoDelay No compromise on the priority of the response time over accuracy</bullet>
        /// <bullet> LowDelay The response time could have a minimum delay for a better accuracy</bullet> 
        /// <bullet> DelayTolerant Response time could be compromised to have high delay for better accuracy</bullet>
        /// </summary>
        public JsString tolerance { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region GetMmsStatusOptions
    [JsType(JsMode.Json)]
    public partial class GetMmsStatusOptions
    {
        /// <summary>
        /// The unique MMS ID as retrieved from the response of the sendMms method.
        /// </summary>
        public JsString mmsId { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region GetSmsStatusOptions
    [JsType(JsMode.Json)]
    public partial class GetSmsStatusOptions
    {
        /// <summary>
        /// The unique MMS ID as retrieved from the response of the sendMms method.
        /// </summary>
        public JsString smsId { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region GetSubscriptionDetailsOPtions
    [JsType(JsMode.Json)]
    public partial class GetSubscriptionDetailsOPtions
    {
        /// <summary>
        /// authorization code of the subscription.
        /// </summary>
        public JsString merchantSubscriptionId { get; set; }
        /// <summary>
        /// id of the user who created the subscription
        /// </summary>
        public JsString consumerId { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region RecieveSmsOptions

    [JsType(JsMode.Json)]
    public partial class RecieveSmsOptions
    {
        /// <summary>
        /// ShortCode/RegistrationId to receive messages from.
        /// </summary>
        public JsNumber registrationId { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region  RefundTransactionOptions
    [JsType(JsMode.Json)]
    public partial class RefundTransactionOptions
    {
        /// <summary>
        /// transaction id to revoke.
        /// </summary>
        public JsString transactionId { get; set; }
        /// <summary>
        /// refund options. See AT&T payment documentation for a complete set of refund options and restrictions.
        /// </summary>
        public JsObject refundOptions { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region RequestOptions
    [JsType(JsMode.Json)]
    public partial class RequestOptions
    {
        /// <summary>
        /// payment options
        /// </summary>
        public JsObject paymentOptions { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }

    }
    #endregion
    #region SendMmsOptions
    [JsType(JsMode.Json)]
    public partial class SendMmsOptions
    {
        /// <summary>
        /// Wireless number of the recipient(s). Can contain comma separated list for multiple recipients.
        /// </summary>
        public JsString address { get; set; }
        /// <summary>
        /// The reference to a file to be sent in the MMS. The server will map the fileId to a real file location.
        /// </summary>
        public JsString fieldId { get; set; }
        /// <summary>
        /// The text of the message to send.
        /// </summary>
        public JsString message { get; set; }
        /// <summary>
        /// The priority of the message.
        /// Valid values are:
        /// <list type="bullet"> 
        /// <item> Low </item>
        /// <item> Normal</item>
        /// <item>High</item>
        /// </list>
        /// Note: :If this parameter is not passed in the request, the default value is Normal.  
        /// </summary>
        public JsString priority { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region SendMoboOptions
    [JsType(JsMode.Json)]
    public partial class SendMoboOptions
    {
        /// <summary>
        /// Comma separated address list where message will be sent. Those address can be email, phone or short code.
        /// </summary>
        public JsString address { get; set; }
        /// <summary>
        /// The message to be sent.
        /// </summary>
        public JsString message { get; set; }
        /// <summary>
        /// Message subject.
        /// </summary>
        public JsString subject { get; set; }
        /// <summary>
        /// Flag to signify if message is being sent to a group.
        /// </summary>
        public bool group { get; set; }
        /// <summary>
        /// Names of files to be included in this message.
        /// </summary>
        [JsProperty(Name = "file")]
        public JsArray filesArray { get; set; }
        /// <summary>
        /// Names of files to be included in this message.
        /// </summary>
        [JsProperty(Name = "file")]
        public JsString filesString { get; set; }
        /// <summary>
        /// Names of files to be included in this message. Please use the current type: string or array.
        /// </summary>
        public JsObject file { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }
    }
    #endregion
    #region SendSmsOptions
    [JsType(JsMode.Json)]
    public partial class SendSmsOptions
    {
        /// <summary>
        /// Wireless number of the recipient(s). Can contain comma separated list for multiple recipients.
        /// </summary>
        public JsString address { get; set; }
        /// <summary>
        /// The text of the message to send.
        /// </summary>
        public JsString message { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }

    }
    #endregion
    #region SignPayloadOptions
    [JsType(JsMode.Json)]
    public partial class SignPayloadOptions
    {
        /// <summary>
        /// The JSON payload that you want to sign.
        /// </summary>
        public JsObject payload { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }

    }
    #endregion
    #region SpeechToTextOptions
    [JsType(JsMode.Json)]
    public partial class SpeechToTextOptions
    {
        /// <summary>
        /// fileName to be sent to translate
        /// </summary>
        public JsString fileName { get; set; }
        /// <summary>
        /// content-type of the file.
        /// </summary>
        public JsString fileContentType { get; set; }
        /// <summary>
        /// "true" to send the file as chunked
        /// </summary>
        public JsString chunked { get; set; }
        /// <summary>
        /// determines the speech context to be applied to the transcribed text
        /// </summary>
        public JsString context { get; set; }
        /// <summary>
        /// key/value pairs for x-arg parameter of speech.
        /// </summary>
        [JsProperty(Name = "xarg")]
        public JsString xargString { get; set; }
        /// <summary>
        /// key/value pairs for x-arg parameter of speech.
        /// </summary>
        [JsProperty(Name = "xarg")]
        public JsString xargArray { get; set; }
        /// <summary>
        /// key/value pairs for x-arg parameter of speech. Please use the currect type: string or array.
        /// </summary>
        public JsObject xarg { get; set; }
    }
    #endregion
    #region StatusOptions

    [JsType(JsMode.Json)]
    public partial class StatusOptions
    {
        /// <summary>
        /// String for the type of transaction id being passed can be "SubscriptionAuthCode" or "MerchantTransactionId" or "SubscriptionId"
        /// </summary>
        public JsString codeType { get; set; }
        /// <summary>
        /// Subscription authorization code to check can be the Subscription auth code, merchant transaction id or Subscription id.
        /// </summary>
        public JsString transactionId { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }

    }
    #endregion
    #region WashPushOptions
    [JsType(JsMode.Json)]
    public partial class WashPushOptions
    {
        /// <summary>
        /// Wireless number of the recipient(s). Can contain comma separated list for multiple recipients.
        /// </summary>
        public JsString address { get; set; }
        /// <summary>
        /// The XML document containing the message to be sent.
        /// </summary>
        public JsString message { get; set; }
        /// <summary>
        /// success callback function
        /// </summary>
        public JsAction<object> success { get; set; }
        /// <summary>
        /// failure callback function
        /// </summary>
        public JsAction<object> failure { get; set; }

    }
    #endregion
    
}