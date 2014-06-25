using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace SharpKit.Web.Server.Handlers
{
    /// <summary>
    /// Handler that helps supporting the JsExport.GenerateSourceMaps feature
    /// Specifies to generate chrome source maps, which enables debugging of JavaScript in C#.
    /// To enable this feature you must add a handler in your web.config file:
    /// <code>
    /// &lt;add name="SourceMapsHandler" type="SharpKit.Web.Server.Handlers.SourceMapsHandler, SharpKit.Web" verb="*" path="SourceMaps.ashx" /&gt;
    /// </code>
    /// And enable source maps in chrome: show development bar, click options wheel, check enable source maps.
    /// </summary>
    public class SourceMapsHandler : IHttpHandler
    {
        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return false; }
        }

        static SourceMapsHandler()
        {
            Mappings = new Dictionary<string, string>();
            Mappings["~/res/"] = "~/";

        }
        public static Dictionary<string, string> Mappings { get; set; }

        public void ProcessRequest(HttpContext context)
        {
            
            var filename = context.Request.PathInfo.Substring(1);//.Request.AppRelativeCurrentExecutionFilePath;

            //var x1 = path1.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //x1.RemoveAt(x1.Count - 1);
            //path1 = String.Join("/", x1.ToArray()) + "/";
            //if (Mappings != null)
            //{
            //    foreach (var pair in Mappings.OrderByDescending(t => t.Key))
            //    {
            //        if (path1.StartsWith(pair.Key))
            //        {
            //            path1 = path1.Replace(pair.Key, pair.Value);
            //            break;
            //        }
            //    }
            //}
            //string filename;
            //var path2 = context.Request.Url.Query.Substring(1);
            //if (path1.Contains("\\"))
            //{
            //    filename = path1 + path2.Replace("/", "\\");
            //}
            //else
            //{
            //    //var x1 = path1.Split(new char[]{'/'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            //    // var x2 = path2.Split(new char[]{'/'}, StringSplitOptions.RemoveEmptyEntries);
            //    //x1.RemoveAt(x1.Count - 1);
            //    var f = path1 + path2;
            //    //x1.AddRange(x2);
            //    //var f = String.Join("/", x1.ToArray());
            //    //var f = "~/" + context.Request.PathInfo;//.QueryString["f"];

            //    filename = context.Server.MapPath(f);
            //}
            context.Response.ContentType = "text/plain";
            if (Path.GetExtension(filename) != ".cs")
                throw new Exception("Only cs files are allowed in SourceMapsHandler");
            context.Response.WriteFile(filename);
        }

        #endregion
    }
}
