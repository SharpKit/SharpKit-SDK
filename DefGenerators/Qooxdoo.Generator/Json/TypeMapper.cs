using System;
using System.Collections.Specialized;
using System.Configuration;
using Microsoft.CSharp;

namespace SharpKit.Qooxdoo.Generator.Json
{
    // Used to map qx js types to .NET types (defined in app.config)
    public class TypeMapper
    {
        private static CSharpCodeProvider codeProvider = new CSharpCodeProvider();
        private static NameValueCollection mappings = ConfigurationManager.GetSection("TypeMappings") as NameValueCollection;

        public static string MapType(string type)
        {
            if (type != null)
            {
                type = MapNamespace(type);
                var mappedType = mappings.Get(type);
                if (mappedType != null)
                {
                    return mappedType;
                }
                else
                {
                    return type;
                }
            }
            else
            {
                return null;
            }
        }

        public static string MapNamespace(string ns)
        {
            if (ns.Contains("."))
            {
                var parts = ns.Split('.');
                for (int i = 0; i < parts.Length; i++)
                {
                    parts[i] = EscapeIdentifier(parts[i]);
                }
                return String.Join(".", parts);
            }
            else
            {
                return ns;
            }
        }

        // Add 'x' to the end if name of the type is .NET keyword/identifier
        public static string EscapeIdentifier(string name)
        {
            if (!codeProvider.IsValidIdentifier(name))
                name = name + "x";
            return name;
        }
    }
}
