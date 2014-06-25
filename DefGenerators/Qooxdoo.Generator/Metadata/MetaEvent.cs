using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Qooxdoo.Generator.Json;

namespace SharpKit.Qooxdoo.Generator.Metadata
{
    public class MetaEvent : MetaItem
    {
        public string EventType { get; set; }

        public MetaEvent(Node node) : base(node)
        {
            var typesNode = node.GetChildByType(NodeType.Types);
            if (typesNode != null)
            {
                EventType = TypeMapper.MapType(typesNode.Children[0].GetAttributeValue("type"));
            }
            // Add 'On' in front of all the event names because many times there will be properties or methods with the same names
            FormattedName = "On" + FormattedName;
        }
    }
}
