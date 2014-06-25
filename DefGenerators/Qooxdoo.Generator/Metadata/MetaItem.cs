using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Web;
using SharpKit.Qooxdoo.Generator.Json;

namespace SharpKit.Qooxdoo.Generator.Metadata
{
    public class MetaItem
    {
        public Node Node { get; set; }
        public string Name { get; set; }
        public string FormattedName { get; set; }
        public string Comment { get; set; }
        public string OverriddenFrom { get; set; }
        public string DocFrom { get; set; }

        public MetaItem()
        {

        }

        public MetaItem(Node node)
        {
            Node = node;
            Name = node.GetAttributeValue("name");
            FormattedName = StringUtils.CapitalizeFirstLetter(Name);

            // Get item comment
            if (Node.Children != null)
            {
                var descNode = Node.GetChildByType(NodeType.Desc);
                if (descNode != null && !String.IsNullOrWhiteSpace(descNode.Attributes["text"]))
                {
                    Comment = descNode.Attributes["text"];
                }
            }

            OverriddenFrom = node.GetAttributeValue("overriddenFrom");
            if (OverriddenFrom != null)
            {
                OverriddenFrom = TypeMapper.MapType(OverriddenFrom);
            }

            DocFrom = node.GetAttributeValue("docFrom");
            if (DocFrom != null)
            {
                DocFrom = TypeMapper.MapType(DocFrom);
            }
        }

        // Parse and generate XML comment blocks
        public virtual string ParseXMLComment(int ident = 0)
        {
            if (Comment != null)
            {
                var summaryBlock = new List<string>();
                var lines = Comment.Split('\n');

                foreach (var ln in lines)
                {
                    var line = ln.Trim();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        //line = HttpUtility.HtmlDecode(line);
                        line = Regex.Replace(line, @"<[^>]*>", m =>
                        {
                            switch (m.Value)
                            {
                                case "<pre class=\"javascript\">":
                                    return "<code>";
                                case "</pre>":
                                    return "</code>";
                                case "<p>":
                                    return "<para>";
                                case "</p>":
                                    return "</para>";
                                case "<ul>":
                                    return "<list type=\"bullet\">";
                                case "</ul>":
                                    return "</list";
                                case "<li>":
                                    return "<item>";
                                case "</li>":
                                    return "</item>";
                                default:
                                    return "";
                            }
                        });
                        line = Regex.Replace(line, @"\{@link ([^\}]*)\}",
                            m =>
                            {
                                var content = m.Groups[1].ToString();
                                content = Regex.Replace(content, "#([a-z])",
                                    m2 => "." + StringUtils.CapitalizeFirstLetter(m2.Groups[1].ToString()));
                                return String.Format("<see cref=\"{0}\"/>", content.Trim('.'));
                            });
                        
                        if (!line.StartsWith("<para>For further details"))
                        {
                            summaryBlock.Add(line);
                        }
                    }
                }
                 
                if (summaryBlock.Count > 0)
                {
                    return CreateCommentBlock(ident, summaryBlock, false, "summary");
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        public string CreateCommentBlock(int ident, IEnumerable<string> blockLines, bool isSingleLine, string openingTag, string closingTag = null)
        {
            if (closingTag == null) closingTag = openingTag;
            var prefix = StringUtils.IdentString("/// ", ident);
            var emptyIdent = StringUtils.IdentString("", ident);
            var sb = new StringBuilder();
            if (blockLines.Count() > 0)
            {
                sb.Append("/// ").Append("<").Append(openingTag).Append(">");
                if (isSingleLine)
                {
                    sb.Append(String.Join(" ", blockLines));
                }
                else
                {
                    sb.Append(Environment.NewLine);
                    foreach (var line in blockLines)
                    {
                        sb.Append(prefix).Append(line).Append(Environment.NewLine);
                    }
                    sb.Append(prefix);
                }
                sb.Append("</").Append(closingTag).Append(">");
            }
            return sb.Append(Environment.NewLine).Append(emptyIdent).ToString();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
