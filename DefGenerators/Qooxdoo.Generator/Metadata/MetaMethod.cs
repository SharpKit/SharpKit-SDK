using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Qooxdoo.Generator.Json;

namespace SharpKit.Qooxdoo.Generator.Metadata
{
    public class MetaMethod : MetaItem
    {
        public bool IsConstructor { get; set; }
        public bool IsStatic { get; set; }
        public string AccessType { get; set; }
        public string ReturnType { get; set; }
        public string ReturnComment { get; set; }
        public List<MetaMethodParameter> Parameters { get; set; }
        public bool AutoInsert { get; set; }

        public MetaMethod()
        {

        }

        public MetaMethod(Node node, MetaClass metaClass) : base(node)
        {
            IsConstructor = node.Attributes.ContainsKey("isCtor") && node.GetAttributeValue("isCtor") == "True";
            if (IsConstructor)
            {
                Name = metaClass.Name;
                FormattedName = Name;
                ReturnType = "";
            }
            else
            {
                FormattedName = StringUtils.CapitalizeFirstLetter(FormattedName.Replace("$", ""));
            }

            IsStatic = node.Attributes.ContainsKey("isStatic") && node.GetAttributeValue("isStatic") == "True";

            AccessType = node.GetAttributeValue("access");
            if (AccessType == null) AccessType = "public";

            Parameters = new List<MetaMethodParameter>();
            var paramsNode = node.GetChildByType(NodeType.Params);
            if (paramsNode != null)
            {
                foreach (var el in paramsNode.Children)
                {
                    Parameters.Add(new MetaMethodParameter(el));
                }
            }

            // Make all parameters following the optional ones to also be optional (not always the case)
            bool hasOptional = false;
            foreach (var parameter in Parameters)
            {
                if (parameter.DefaultValue != null)
                {
                    hasOptional = true;
                }
                else if (hasOptional)
                {
                    parameter.DefaultValue = "null";
                    parameter.FormatDefaultValue();
                }
            }

            // Get the return / parameter type from the relevant property (if there is one)
            var fromProperty = node.GetAttributeValue("fromProperty");
            if (fromProperty != null)
            {
                var property = metaClass.Properties.FirstOrDefault(p => p.Name == fromProperty);
                if (property != null)
                {
                    if (Name.StartsWith("get"))
                    {
                        ReturnType = property.Type;
                    }
                    else if (Name.StartsWith("set"))
                    {
                        Parameters[0].Type = property.Type;
                    }
                }
            }

            // Get return type from the metadata
            if (ReturnType == null && fromProperty == null)
            {
                var returnNode = node.GetChildByType(NodeType.Return);
                if (returnNode != null)
                {
                    var typesNode = returnNode.GetChildByType(NodeType.Types);
                    if (typesNode != null)
                    {
                        // There could be more than one return type, in which case make it an object
                        if (typesNode.Children.Count == 1)
                        {
                            ReturnType = typesNode.Children[0].GetAttributeValue("type");
                        }
                        else
                        {
                            // If only one of the return types is non-null, set it as a return type
                            // otherwise set the return type to object
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
                                ReturnType = nonNullTypes[0];
                            }
                            else
                            {
                                ReturnType = "object";
                            }
                        }
                    }
                    var commentNode = returnNode.GetChildByType(NodeType.Desc);
                    if (commentNode != null)
                    {
                        ReturnComment = commentNode.GetAttributeValue("text");
                    }
                }
            }
            if (ReturnType == "null")
                ReturnType = "object";

            if (!IsConstructor)
            {
                if (ReturnType == null)
                    ReturnType = "void";
                else
                    ReturnType = TypeMapper.MapType(ReturnType);
            }
        }

        public string GetParametersList()
        {
            return String.Join(", ", Parameters.Select(p => p.ToString()));
        }

        // Add parameters & return blocks to the XML comment
        public override string ParseXMLComment(int ident = 0)
        {
            var comment = base.ParseXMLComment(ident);
            foreach (var parameter in Parameters)
            {
                if (parameter.Comment != null)
                {
                    comment += CreateCommentBlock(ident, StringUtils.StripTags(parameter.Comment).Split('\n'),
                        true, String.Format("param name=\"{0}\"", parameter.Name), "param");
                }
            }
            if (ReturnComment != null)
            {
                comment += CreateCommentBlock(ident, StringUtils.StripTags(ReturnComment).Split('\n'), 
                    true, "returns");
            }
            return comment;
        }
    }
}
