using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Qooxdoo.Generator.Json;

namespace SharpKit.Qooxdoo.Generator.Metadata
{
    public class MetaMethodParameter : MetaItem
    {
        public string Type { get; set; }
        public string DefaultValue { get; set; }

        public MetaMethodParameter(Node node)
            : base(node)
        {
            if (node.Children != null)
            {
                // There could be more than one parameter type, in which case make it an object
                var typesNode = node.GetChildByType(NodeType.Types);
                if (typesNode.Children.Count == 1)
                {
                    Type = typesNode.Children[0].GetAttributeValue("type");
                }
                else
                {
                    // If only one of the parameter types is non-null, set it as a parameter type
                    // otherwise set the parameter type to object
                    var nonNullTypes = new List<string>();
                    foreach (var typeNode in typesNode.Children)
                    {
                        var type = typeNode.GetAttributeValue("type");
                        if (type != "null")
                        {
                            nonNullTypes.Add(type);
                        }
                    }
                    if (nonNullTypes.Count == 1)
                    {
                        Type = nonNullTypes[0];
                    }
                    else
                    {
                        Type = "object";
                    }
                }
            }

            if (Type == "Function" && Name == "listener")
                Type = "FunctionListener";

            Type = TypeMapper.MapType(Type);
            if (Type == null)
            {
                Type = "object";
            }

            DefaultValue = node.GetAttributeValue("defaultValue");
            FormatDefaultValue();

            Name = TypeMapper.EscapeIdentifier(Name);
        }

        // Make sure default value is .NET-compatible (i.e. not int i = null)
        public void FormatDefaultValue()
        {
            if (DefaultValue != null)
            {
                if (Type == "int" || Type == "double" || Type == "DateTime" || Type == "bool")
                {
                    if (Type == "int" || Type == "double")
                    {
                        double temp;
                        if (!double.TryParse(DefaultValue, out temp))
                        {
                            DefaultValue = "null";
                        }
                    }
                    else if (Type == "bool")
                    {
                        if (DefaultValue != "true" && DefaultValue != "false")
                        {
                            DefaultValue = "null";
                        }
                    }
                    if (DefaultValue == "null")
                    {
                        Type = Type + "?";
                    }
                }
                else if (Type == "string")
                {
                    if (DefaultValue != "null" && !DefaultValue.StartsWith("\"") && !DefaultValue.EndsWith("\""))
                    {
                        DefaultValue = "\"" + DefaultValue + "\"";
                    }
                }
                else if (Type.StartsWith("Action"))
                {
                    if (DefaultValue != "null")
                    {
                        DefaultValue = "null";
                    }
                }
                else
                {
                    if (DefaultValue != "true" && DefaultValue != "false" && DefaultValue != "null")
                    {
                        double temp;
                        if (!double.TryParse(DefaultValue, out temp))
                        {
                            DefaultValue = "null";
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            if (DefaultValue == null)
                return String.Format("{0} {1}", Type, Name);
            else
                return String.Format("{0} {1} = {2}", Type, Name, DefaultValue);
        }
    }
}
