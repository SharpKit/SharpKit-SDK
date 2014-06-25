using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.Qooxdoo.Generator.Json;

namespace SharpKit.Qooxdoo.Generator.Metadata
{
    public class MetaClass : MetaItem
    {
        public string Namespace { get; set; }
        public string OriginalFullName { get; set; }
        public string FullName { get; set; }
        public string BaseClass { get; set; }
        public string InheritanceList { get; set; }
        public List<string> Interfaces { get; set; }
        public List<string> Mixins { get; set; }
        public List<MetaClass> MixinClasses { get; set; }
        public bool IsStatic { get; set; }
        public bool IsMixin { get; set; }
        public bool IsInterface { get; set; }
        public bool IsAbstract { get; set; }

        public List<string> Usings { get; set; }
        public List<MetaMethod> Methods { get; set; }
        public List<MetaProperty> Properties { get; set; }
        public List<MetaEvent> Events { get; set; }

        private List<MetaClass> allClasses;

        public MetaClass(Node node) : base(node)
        {
            Usings = new List<string>();
            Methods = new List<MetaMethod>();
            Properties = new List<MetaProperty>();
            Events = new List<MetaEvent>();
            MixinClasses = new List<MetaClass>();

            OriginalFullName = node.Attributes["fullName"];
            FullName = TypeMapper.MapType(OriginalFullName);
            BaseClass = TypeMapper.MapType(node.GetAttributeValue("superClass"));
            Namespace = TypeMapper.MapNamespace(node.Attributes["packageName"]);
            if (String.IsNullOrWhiteSpace(Namespace))
            {
                Namespace = "qx";
                if (!FullName.Contains(".")) FullName = Namespace + "." + FullName;
            }

            IsStatic = node.Attributes.ContainsKey("isStatic") && node.GetAttributeValue("isStatic") == "True";
            IsAbstract = node.Attributes.ContainsKey("isAbstract") && node.GetAttributeValue("isAbstract") == "True";
            IsMixin = node.Attributes.ContainsKey("type") && node.GetAttributeValue("type") == "mixin";
            IsInterface = node.Attributes.ContainsKey("type") && node.GetAttributeValue("type") == "interface";

            if (BaseClass != null)
            {
                InheritanceList = ": " + TypeMapper.MapNamespace(BaseClass);
            }

            var interfaceList = node.GetAttributeValue("interfaces");
            if (interfaceList != null)
            {
                Interfaces = interfaceList.Split(',').ToList();
                for (int i = 0; i < Interfaces.Count; i++)
                    Interfaces[i] = TypeMapper.MapNamespace(Interfaces[i]);

                if (InheritanceList == null)
                    InheritanceList = ": " + String.Join(", ", Interfaces);
                else
                    InheritanceList += ", " + String.Join(", ", Interfaces);
            }
            else
            {
                Interfaces = new List<string>();
            }
            if (InheritanceList == null) InheritanceList = "";

            var mixinList = node.GetAttributeValue("mixins");
            if (mixinList != null)
            {
                Mixins = mixinList.Split(',').ToList();
                for (int i = 0; i < Mixins.Count; i++)
                    Mixins[i] = TypeMapper.MapNamespace(Mixins[i]);
            }
            else
            {
                Mixins = new List<string>();
            }

            // Add all the properties first (some methods depend on them for lookups)
            foreach (var child in node.Children)
            {
                switch (child.Type)
                {
                    case NodeType.Properties:
                        foreach (var propNode in child.Children)
                        {
                            var metaProperty = new MetaProperty(propNode);
                            // Add 'x' in the end if property name = class name
                            if (metaProperty.FormattedName == FormattedName)
                            {
                                metaProperty.FormattedName += "x";
                            }
                            Properties.Add(metaProperty);
                        }
                        break;
                }
            }

            // Add methods and events 
            foreach (var child in node.Children)
            {
                switch (child.Type)
                {
                    case NodeType.Constructor:
                        var ctorNode = child.GetChildByType(NodeType.Method);
                        Methods.Add(new MetaMethod(ctorNode, this));
                        break;

                    case NodeType.Methods:
                    case NodeType.MethodsStatic:
                        foreach (var methodNode in child.Children)
                        {
                            var attachStatic = methodNode.GetChildByType(NodeType.AttachStatic);
                            if (attachStatic == null) // Not sure what is attackStatic, but we don't need them
                            {
                                var metaMethod = new MetaMethod(methodNode, this);
                                // Add all public methods
                                if (metaMethod.AccessType == "public")
                                {
                                    // Add 'x' in the end if method name = class name
                                    if (metaMethod.FormattedName == FormattedName)
                                    {
                                        metaMethod.FormattedName += "x";
                                    }
                                    Methods.Add(metaMethod);
                                }
                            }
                        }
                        break;

                    case NodeType.Events:
                        foreach (var eventNode in child.Children)
                        {
                            if (Events.FirstOrDefault(e => e.Name == eventNode.GetAttributeValue("name")) == null)
                            {
                                Events.Add(new MetaEvent(eventNode));
                            }
                        }
                        break;
                }
            }

            // In some cases there will be instance & static methods with the same name, adding 'S' in the end for those
            foreach (var method in Methods)
            {
                if (method.IsStatic)
                {
                    var existingNonStatic = Methods.FirstOrDefault(m => !m.IsStatic && m.FormattedName == method.FormattedName);
                    if (existingNonStatic != null)
                    {
                        method.FormattedName += "S";
                    }
                }
            }

            // Adding parameterless constructor if not present
            if (!IsInterface)
            {
                var parameterlessConstructor = Methods.FirstOrDefault(m => m.IsConstructor && m.Parameters.Count == 0);
                if (parameterlessConstructor == null)
                {
                    Methods.Insert(0, new MetaMethod
                    {
                        IsConstructor = true,
                        AccessType = "public",
                        Name = Name,
                        FormattedName = Name,
                        ReturnType = "",
                        Parameters = new List<MetaMethodParameter>(),
                        AutoInsert = true
                    });
                }
            }
        }

        public void AddInterfaces(List<MetaClass> allClasses)
        {
            this.allClasses = allClasses;
            // Removed all the unneeded code
        }

        // Add the list of mixins and their namespaces to include
        public void AddMixins(List<MetaClass> allClasses)
        {
            if (Mixins.Count > 0)
            {
                foreach (var mixin in Mixins)
                {
                    var mixinClass = allClasses.FirstOrDefault(c => c.IsMixin && c.FullName == mixin);
                    if (mixinClass != null)
                    {
                        MixinClasses.Add(mixinClass);
                        if (mixinClass.Namespace != Namespace && !Usings.Contains(mixinClass.Namespace))
                        {
                            Usings.Add(mixinClass.Namespace);
                        }
                    }
                }
            }
        }

        public List<MetaMethod> GetAllMethods()
        {
            // Compile the list of class methods and mixin methods
            var allMethods = new List<MetaMethod>(Methods);
            foreach (var mixinClass in MixinClasses)
            {
                allMethods.AddRange(mixinClass.Methods.Where(m => !m.IsConstructor && allMethods.FirstOrDefault(m1 => m1.Name == m.Name) == null));
            }

            // Replace original methods metadata with the one from docFrom class (it has more accurate description and other data)
            for (int i = 0; i < allMethods.Count; i++)
            {
                if (!allMethods[i].AutoInsert && allMethods[i].DocFrom != null)
                {
                    var fromClass = allClasses.FirstOrDefault(c => allMethods[i].DocFrom == c.FullName);
                    if (fromClass != null)
                    {
                        var fromMethod = fromClass.Methods.FirstOrDefault(m => !m.AutoInsert && m.Name == allMethods[i].Name);
                        if (fromMethod != null)
                        {
                            allMethods[i] = fromMethod;
                        }
                    }
                }
            }

            // Replace original methods metadata with the one from interfaces (it has more accurate description and other data)
            if (Interfaces.Count > 0)
            {
                foreach (var interf in Interfaces)
                {
                    var interfaceClass = allClasses.FirstOrDefault(c => c.IsInterface && c.FullName == interf);
                    if (interfaceClass != null)
                    {
                        for (int i = 0; i < allMethods.Count; i++)
                        {
                            var interfaceMethod = interfaceClass.Methods.FirstOrDefault(m => m.Name == allMethods[i].Name);
                            if (interfaceMethod != null)
                            {
                                allMethods[i] = interfaceMethod;
                            }
                        }
                    }
                }
            }

            return allMethods;
        }

        public List<MetaProperty> GetAllProperties()
        {
            // Compile the list of class properties and mixin properties
            var allProperties = new List<MetaProperty>(Properties);
            foreach (var mixinClass in MixinClasses)
            {
                allProperties.AddRange(mixinClass.Properties.Where(p => allProperties.FirstOrDefault(p1 => p1.Name == p.Name) == null));
            }

            // Replace original properties metadata with the one from docFrom class (it has more accurate description and other data)
            for (int i = 0; i < allProperties.Count; i++)
            {
                if (allProperties[i].DocFrom != null)
                {
                    var fromClass = allClasses.FirstOrDefault(c => allProperties[i].DocFrom == c.FullName);
                    if (fromClass != null)
                    {
                        var fromProperty = fromClass.Properties.FirstOrDefault(p => p.Name == allProperties[i].Name);
                        if (fromProperty != null)
                        {
                            allProperties[i] = fromProperty;
                        }
                    }
                }
            }

            // Replace original properties metadata with the one from interfaces (it has more accurate description and other data)
            if (Interfaces.Count > 0)
            {
                foreach (var interf in Interfaces)
                {
                    var interfaceClass = allClasses.FirstOrDefault(c => c.IsInterface && c.FullName == interf);
                    if (interfaceClass != null)
                    {
                        for (int i = 0; i < allProperties.Count; i++)
                        {
                            var interfaceProperty = interfaceClass.Properties.FirstOrDefault(m => m.Name == allProperties[i].Name);
                            if (interfaceProperty != null)
                            {
                                allProperties[i] = interfaceProperty;
                            }
                        }
                    }
                }
            }

            return allProperties;
        }

        public List<MetaEvent> GetAllEvents()
        {
            // Compile the list of class events and mixin events
            var allEvents = new List<MetaEvent>(Events);
            foreach (var mixinClass in MixinClasses)
            {
                allEvents.AddRange(mixinClass.Events.Where(e => allEvents.FirstOrDefault(e1 => e1.Name == e.Name) == null));
            }

            // Replace original events metadata with the one from docFrom class (it has more accurate description and other data)
            for (int i = 0; i < allEvents.Count; i++)
            {
                if (allEvents[i].DocFrom != null)
                {
                    var fromClass = allClasses.FirstOrDefault(c => allEvents[i].DocFrom == c.FullName);
                    if (fromClass != null)
                    {
                        var fromEvent = fromClass.Events.FirstOrDefault(e => e.Name == allEvents[i].Name);
                        if (fromEvent != null)
                        {
                            allEvents[i] = fromEvent;
                        }
                    }
                }
            }

            // Replace original events metadata with the one from interfaces (it has more accurate description and other data)
            if (Interfaces.Count > 0)
            {
                foreach (var interf in Interfaces)
                {
                    var interfaceClass = allClasses.FirstOrDefault(c => c.IsInterface && c.FullName == interf);
                    if (interfaceClass != null)
                    {
                        for (int i = 0; i < allEvents.Count; i++)
                        {
                            var interfaceEvent = interfaceClass.Events.FirstOrDefault(m => m.Name == allEvents[i].Name);
                            if (interfaceEvent != null)
                            {
                                allEvents[i] = interfaceEvent;
                            }
                        }
                    }
                }
            }

            return allEvents;
        }
    }
}
