using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SharpKit.Qooxdoo.Generator
{
    public class StringUtils
    {
        public static string IdentString(string text, int ident)
        {
            return text.PadLeft(ident + text.Length, '\t');
        }

        public static string CapitalizeFirstLetter(string s)
        {
            if (!String.IsNullOrWhiteSpace(s) && Settings.CapitalizeNames)
            {
                return char.ToUpper(s[0]) + s.Substring(1);
            }
            else
            {
                return s;
            }
        }

        public static string StripTags(string s)
        {
            var res = Regex.Replace(s, @"<[^>]*>", "");
            return Regex.Replace(res, @"\{@link ([^\}]*)\}", m => m.Groups[1].ToString());
        }
    }
}
