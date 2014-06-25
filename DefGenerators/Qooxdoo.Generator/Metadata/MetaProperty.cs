using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Qooxdoo.Generator.Json;

namespace SharpKit.Qooxdoo.Generator.Metadata
{
    public class MetaProperty : MetaItem
    {
        public string AccessType { get; set; }
        public string Type { get; set; }

        public MetaProperty(Node node)
            : base(node)
        {
            AccessType = node.GetAttributeValue("access");
            if (AccessType == null) AccessType = "public";

            // Check means property type (wtf?)
            Type = node.GetAttributeValue("check");
            if (Type == null || Type.Contains(" "))
                Type = "object";
            else
                Type = TypeMapper.MapType(Type);
        }

        // Add remarks block to the XML comments
        public override string ParseXMLComment(int ident = 0)
        {
            var comment = base.ParseXMLComment(ident);
            var remarks = new List<string>();
            var possibleValues = Node.GetAttributeValue("possibleValues");
            if (possibleValues != null)
            {
                remarks.Add(String.Format("Possible values: {0}", possibleValues));
            }
            var allowNulls = Node.GetAttributeValue("allowNull");
            if (allowNulls != null)
            {
                remarks.Add(String.Format("Allow nulls: {0}", allowNulls));
            }
            if (remarks.Count > 0)
            {
                comment += CreateCommentBlock(ident, remarks, false, "remarks");
            }
            return comment;
        }
    }
}
