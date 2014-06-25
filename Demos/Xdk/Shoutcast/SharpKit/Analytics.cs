using SharpKit.JavaScript;
using SharpKit.DotNet.JavaScript;
using SharpKit.DotNet.Html;
using SharpKit.DotNet.IntelXdk;

namespace XdkDemo.Shoutcast
{
    [JsType(GlobalObject = true, Filename = "../js/demo-shoutcast.js", OrderInFile = 2, PreCode = "//---------Analytics----------//")]
    public class Analytics : HtmlContext
    {
        /* statMobi Analytics */

        /// <summary>
        /// This sample function records an event ID, as well as an optional
        /// set of name/value pairs as a query string to the statMobi Analytics
        /// logs.
        /// </summary>
        /// <param name="eventID"></param>
        /// <param name="queryString"></param>
        public static void AddAnalyticsDataPoint(JsString eventID, JsString queryString)
        {
            try
            {
                if (queryString == null) { queryString = ""; }
                Xdk.analytics.LogPageEvent("/application/" + eventID +
         ".event", queryString, "", GetPost.GET, 0, "index.html");
            }
            catch (JsError e) { }
        }
        /* Drop this javascript function into the <head> element of your
        application's index.html page and call it everywhere you want to
        record an analytics event. It takes two parameters. The first is an
        event identifier string and the second is an optional key/value query
        string parameter. */
    }
}