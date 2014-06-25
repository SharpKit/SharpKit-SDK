//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Reflection;
//using System.Web;
//using System.Web.UI;

//namespace SharpKit.Web.Server
//{
//    /// <summary>
//    /// Helps managing resources, if they are embedded resources / real files
//    /// </summary>
//    public class ResourceService
//    {
//        public ResourceService()
//        {
//            BaseUrl = "~/EmbeddedResource.ashx/";
//            JsFiles = new List<string>();
//            Scripts = new List<string>();
//            CssFiles = new List<string>();
//        }
//        public string BaseUrl { get; set; }
//        public HttpContext Context { get; set; }
//        public Control Control { get; set; }

//        public List<string> JsFiles { get; set; }
//        public List<string> CssFiles { get; set; }
//        public List<string> Scripts { get; set; }

//        public string GetResourceUrl(string fullname)
//        {
//            return ResolveClientUrl(BaseUrl + fullname);
//        }
//        public string GetIncludes()
//        {
//            var sb = new StringBuilder();
//            foreach (var res in JsFiles)
//            {
//                var url = GetResourceUrl(res);
//                sb.AppendFormat("<script src=\"{0}\" type=\"text/javascript\"></script>", url);
//                sb.AppendLine();
//            }
//            foreach (var res in CssFiles)
//            {
//                var url = GetResourceUrl(res);
//                sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", url);
//                sb.AppendLine();
//            }
//            return sb.ToString();
//        }

//        private string ResolveClientUrl(string url)
//        {
//            if (Control != null)
//                return Control.ResolveClientUrl(url);
//            else if (Context != null)
//                return Context.Response.ApplyAppPathModifier(url);
//            return url;
//        }
//    }



//}
