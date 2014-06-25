using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SharpKit.Qooxdoo.Generator.Json
{
    // JSON model for API doc files, used for initial deserialization
    public class Node
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(CustomStringEnumConverter))]
        public NodeType Type { get; set; }

        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [JsonProperty("children")]
        public List<Node> Children { get; set; }

        public Node GetChildByType(NodeType type)
        {
            if (Children != null)
                return Children.FirstOrDefault(c => c.Type == type);
            else
                return null;
        }

        public string GetAttributeValue(string attributeName)
        {
            string value = null;
            if (Attributes != null)
            {
                Attributes.TryGetValue(attributeName, out value);
            }
            return value;
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
