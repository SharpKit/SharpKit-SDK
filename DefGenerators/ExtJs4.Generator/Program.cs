using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.CodeDom.Compiler;
using HtmlAgilityPack;
using Newtonsoft.Json;
using SharpKit.ExtJs4.Generator.ExtDocModel;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;

namespace SharpKit.ExtJs4.Generator
{
    class ClassMap
    {
        public ExtClass ExtClass { get; set; }
        public List<Class> Classes { get; set; }
        public string Filename { get; set; }
    }
    class Program
    {
        private static readonly HtmlDocument CurrHtDoc = new HtmlDocument();// { OptionWriteEmptyNodes = true };
        private static readonly char[] MultipleObjectDelimiter = new[] { '/', ' ' };

        //Methods and propertys in Ext.ExtContext, needed to fix docs.
        private static readonly string[] extCreDef = new[] { 
                        "Ext.addBehaviors",
                        "Ext.application", 
                        "Ext.apply", 
                        "Ext.applyIf", 
                        "Ext.batchLayouts",
                        "Ext.bind",
                        "Ext.callback", 
                        "Ext.clean", 
                        "Ext.clone", 
                        "Ext.create", 
                        "Ext.copyTo", 
                        "Ext.createByAlias", 
                        "Ext.createWidget", 
                        "Ext.decode", 
                        "Ext.defer", 
                        "Ext.define", 
                        "Ext.deprecate", 
                        "Ext.destroy", 
                        "Ext.destroyMembers", 
                        "Ext.each", 
                        "Ext.encode", 
                        "Ext.escapeRe", 
                        "Ext.exclude", 
                        "Ext.extend", 
                        "Ext.flatten", 
                        "Ext.fly", 
                        "Ext.get",
                        "Ext.getBody",
                        "Ext.getClass",
                        "Ext.getClassName",
                        "Ext.getCmp",
                        "Ext.getDoc",
                        "Ext.getDom",
                        "Ext.getHead",
                        "Ext.getOrientation",
                        "Ext.getScrollBarWidth",
                        "Ext.getScrollbarSize",
                        "Ext.getStore",
                        "Ext.getVersion",
                        "Ext.htmlDecode",
                        "Ext.htmlEncode",
                        "Ext.id",
                        "Ext.invoke",
                        "Ext.isArray",
                        "Ext.isBoolean",
                        "Ext.isDate",
                        "Ext.isDefined",
                        "Ext.isElement",
                        "Ext.isEmpty", 
                        "Ext.isFunction", 
                        "Ext.isIterable",
                        "Ext.isNumber", 
                        "Ext.isNumeric",
                        "Ext.isObject",
                        "Ext.isPrimitive",
                        "Ext.isString",
                        "Ext.isTextNode",
                        "Ext.iterate",
                        "Ext.log",
                        "Ext.max",
                        "Ext.mean",
                        "Ext.merge",
                        "Ext.min",
                        "Ext.namespace",
                        "Ext.@namespace",
                        "Ext.ns",
                        "Ext.num",
                        "Ext.onDocumentReady",
                        "Ext.onReady",
                        "Ext.@override",
                        "Ext.override",
                        "Ext.partition",
                        "Ext.pass",
                        "Ext.pluck",
                        "Ext.preg",
                        "Ext.query",
                        "Ext.regModel",
                        "Ext.regStore",
                        "Ext.removeNode",
                        "Ext.require",
                        "Ext.resumeLayouts",
                        "Ext.select",
                        "Ext.setVersion",
                        "Ext.sum",
                        "Ext.suspendLayouts",
                        "Ext.syncRequire",
                        "Ext.toArray",
                        "Ext.toSentence",
                        "Ext.type",
                        "Ext.typeOf",
                        "Ext.unique",
                        "Ext.urlAppend",
                        "Ext.urlDecode",
                        "Ext.urlEncode",
                        "Ext.value",
                        "Ext.valueFrom",
                        "Ext.widget",
                        "Ext.zip"
                    };

        #region Config vars

        //If this is set to true, then public (and protected) methods will have proper CamelCase
        private static readonly bool UseProperCaseForPublicMethods = false;

        //If this is set to true, then public (and protected) propertys will have proper CamelCase
        private static readonly bool UseProperCaseForPublicPropertys = false;

        //If this is set to true, then all config fields will go in the main class (besides the Config class), this is the most "Ext-like" behaviour.
        private static readonly bool IncludeConfigsInMainClass = true;

        //If this is set to true, then all classes will have a (params object[] args) constructor
        private static readonly bool GenerateParamsConstructor = true;

        //If this is set, then all public (and protected) methods will return this.
        private static readonly string AllPublicMethodsReturn = null; // "dynamic";

        //Here you can configure wich parameters will be forced as optional
        private static readonly string[] ForcedOptionalParameterNames = new[] { "etc", "createdFn", "root", "suppressEvent", "args", "modifiedFieldNames", "bubbles", "delay" };

        //If this is set, then Ext.ExtContext and Ext.Base will inherit from JsContext 
        private static bool InheritFromJsContext = true;

        //Self explanatory...
        private const string InputDir = @"D:\Proyectos\extjs-4.1.1\docs\output\";
        private const string OutputDir = @"C:\Temp\ExtJs\";
        #endregion

        #region AssemblyContext

        static Class ObjectClass;
        static AssemblyContext Context;
        static Assembly Assembly;
        private static void InitAssemlyContext()
        {
            Assembly = new Assembly
            {
                Usings = new List<string> 
                { 
                    "SharpKit.JavaScript",
             }
            };
            Context = new AssemblyContext
            {
                ClassMappings = new Dictionary<string, string>
                {
                    {"object", "object"},
                    {"Object", "object"},
                    {"Element", "Ext.dom.Element"},
                    {"Ext.Element", "Ext.dom.Element"},
                    {"Ext.core.Element", "Ext.dom.Element"},
                    {"Ext.dom.ElementLoader", "Ext.ElementLoader"},
                    {"Ext.ux.form.FileUploadField","Ext.form.field.File"},
                    {"HTMLElement", "Ext.dom.Element"},
                    {"Function", "System.Delegate"},
                    {"Array", "JsArray"},
                    {"String", "JsString"},
                    {"string", "JsString"},
                    {"Boolean", "bool"},
                    {"Boolan", "bool"},
                    {"boolean", "bool"},
                    {"Float", "JsNumber"},
                    {"integer", "JsNumber"},
                    {"Number", "JsNumber"},
                    {"number", "JsNumber"},
                    {"int", "JsNumber"},
                    {"Date", "JsDate"},
                    {"RegExp", "JsRegExp"},
                    {"Mixed", "JsObject"},
                    {"Ext.fx.target", "Ext.fx.target.Target"},
                    {"Ext", "Ext.ExtContext"},
                    {"Ext.Container", "Ext.container.Container"},
                    {"Container", "Ext.container.Container"},
                    {"Mixed component", "JsObject"},
                    {"Ext.TabBar", "Ext.tab.Bar"},
                    {"Component", "Ext.Component"},
                    {"Region", "Ext.util.Region"},
                    {"ResizeTracker", "Ext.resizer.ResizeTracker"},
                    {"Regexp", "JsRegExp"},
                    {"Menu", "Ext.menu.Menu"},
                    {"Store", "Ext.data.Store"},
                    {"CompositeElement", "Ext.dom.CompositeElement"},
                    {"Ext.CompositeElement", "Ext.dom.CompositeElement"},
                    {"Label", "Ext.form.Label"},
                    {"Model", "Ext.data.Model"},
                    {"Ext.grid.Grid", "Ext.grid.property.Grid"},
                    //{"*", "JsObject"},
                    {"ColorPicker", "Ext.menu.ColorPicker"},
                    {"MultiSlider", "Ext.slider.Multi"},
                    {"XMLElement", "JsObject"},
                    {"CSSStyleSheet", "JsObject"},
                    {"CSSStyleRule", "JsObject"},
                  }
            };
            Context.Assemblies.Add( Assembly );
            var asm = new Assembly
            {
                Classes = new List<Class>
                {
                    new Class{Name="void"},
                    new Class{Name="object"},
                    new Class{Name="object"},
                    new Class{Name="JsObject"},
                    new Class{Name="JsArray"},
                    new Class{Name="JsArray`1"},
                    new Class{Name="JsDate"},
                    new Class{Name="JsRegExp"},
                    new Class{Name="JsFunc`1`1"},
                    new Class{Name="JsFunc`1`2"},
                    new Class{Name="JsFunc`1`3"},
                    new Class{Name="JsFunc`1`4"},
                    new Class{Name="JsAction"},
                    new Class{Name="JsAction`1"},
                    new Class{Name="JsAction`2"},
                    new Class{Name="JsAction`3"},
                    new Class{Name="JsAction`4"},
                    new Class{Name="bool"},
                    new Class{Name="JsString"},
                    new Class{Name="JsNumber"},
                    new Class{Name="JsContext"},
                    new Class{Name="Delegate", FullName = "System.Delegate"},
               }
            };
            Context.Assemblies.Add( asm );
            ObjectClass = Context.GetClass( "object" );
            VoidClass = Context.GetClass( "void" );

        }
        #endregion

        static void Main( string[] args )
        {

            InitAssemlyContext();


            var list = new List<ClassMap>();
            foreach ( var filename in Directory.GetFiles( InputDir, "Ext*.js" ) )
            {
                Console.WriteLine( filename );
                var code = File.ReadAllText( filename );
                var code2 = code.SubstringBetween( code.IndexOf( "(" ) + 1, code.LastIndexOf( ");" ) );
                //var ce2 = new JavaScriptSerializer().Deserialize(code2, typeof(ExtClass)) as ExtClass;
                var ce2 = JsonConvert.DeserializeObject<ExtClass>( code2, new JsonSerializerSettings { Error = OnError } );
                list.Add( new ClassMap { ExtClass = ce2, Filename = filename } );
            }
            foreach ( var item in list )
            {
                item.Classes = Process( item.ExtClass );
            }
            foreach ( var item in list )
            {
                ProcessBaseClassAndInterfaces( item.ExtClass );
            }
            foreach ( var item in list )
            {
                ProcessMembers( item.ExtClass );
            }
            Assembly.Classes = Fix( Assembly.Classes );
            list = CleanList( list );
            foreach ( var item in list )
            {
                var csFile = Path.Combine( OutputDir, Path.GetFileName( item.Filename ).Replace( ".js", ".cs" ) );
                Export( item.Classes, csFile );
                Exported.AddRange( item.Classes );
            }
            var unknown = Assembly.Classes.Where( t => !Exported.Contains( t ) ).ToList();
            Export( unknown, "Unknown.cs" );

        }

        private static List<ClassMap> CleanList( List<ClassMap> list )
        {
            return list.Where( l => l.Classes.Any( c => Assembly.Classes.Contains( c ) ) ).ToList();
        }

        private static void OnError( object sender, ErrorEventArgs e )
        {
            if ( e.ErrorContext.Member.ToStringOrEmpty() == "private" )
            {
                ( ( ExtClass ) e.CurrentObject ).@private = false;
                e.ErrorContext.Handled = true;
            }
        }

        private static Element Clone( Element el, object newPropertys = null )
        {
            Element newEl = null;
            if ( el is Method )
            {
                newEl = new Method();
            }
            else if ( el is Property )
            {
                newEl = new Property();
            }
            else if ( el is Field )
            {
                newEl = new Field();
            }
            el.GetType().GetProperties().ForEach( p =>
            {
                var val = p.GetValue( el, new object[] { } );
                newEl.GetType().GetProperty( p.Name ).SetValue( newEl, val, new object[] { } );
            } );

            return newEl;
        }

        private static List<Class> Fix( List<Class> list )
        {
            list.ForEach( t => t.Members.Where( m => m.DeclaringClass == null ).ForEach( m => m.DeclaringClass = t ) );
            list.ForEach( t => t.Members.OfType<Method>().Where( m => m.Name.Equals( "callParent", StringComparison.Ordinal ) && m.Parameters.Count == 1 ).ForEach( m => m.Parameters.ForEach( p =>
            {
                p.IsOptional = true;
                p.Type = GetClass( "object" );
            } ) ) );
            var ceExt = GetClass( "Ext.ExtContext", false );

            if ( InheritFromJsContext )
                ceExt.BaseClass = GetClass( "JsContext", false );

            ceExt.Attributes[ 0 ].NamedParamters.Add( "Name", "\"Ext\"" );

            //Fixing Ext aliases.
            ceExt.Members.Where( m => m.Name.Equals( "getDoc" ) || m.Name.Equals( "getDom" ) || m.Name.Equals( "getElementById" ) || m.Name.Equals( "getBody" ) ).ForEach( m => m.Type = GetClass( "Element" ) );
            ceExt.Members.OfType<Method>().Where( m => m.Name.Equals( "getClass" ) ).ForEach( m =>
            {
                m.Type = GetClass( "Ext.Class" );
                m.Parameters.Add( new Parameter { DeclaringClass = ceExt, Name = "cls", Type = GetClass( "object" ) } );
            } );
            ceExt.Members.OfType<Method>().Where( m => m.Name.Equals( "getClassName" ) ).ForEach( m =>
            {
                m.Type = GetClass( "JsString" );
                m.Parameters.Add( new Parameter { DeclaringClass = ceExt, Name = "cls", Type = GetClass( "object" ) } );
            } );
            ceExt.Members.OfType<Method>().Where( m => m.Name.Equals( "createByAlias" ) ).ForEach( m =>
            {
                m.Type = GetClass( "object" );
                m.Parameters.Add( new Parameter { DeclaringClass = ceExt, Name = "name", Type = GetClass( "JsString" ) } );
                m.Parameters.Add( new Parameter { DeclaringClass = ceExt, Name = "args", Type = GetClass( "object" ), IsParams = true } );
            } );
            ceExt.Members.OfType<Method>().Where( m => m.Name.Equals( "create" ) ).ForEach( m =>
            {
                m.Parameters[ 0 ].IsOptional = false;
                m.Parameters[ 1 ].IsOptional = false;
                m.Parameters[ 1 ].IsParams = true;
            } );
            ceExt.Members.Where( m => m.Name.Equals( "getCmp" ) ).ForEach( m => m.Type = GetClass( "Ext.Component" ) );
            ceExt.Members.OfType<Method>().Where( m => m.Name.Equals( "require" ) ).ForEach( m => m.Parameters.Add( new Parameter { Type = GetClass( "object" ), Name = "args", IsParams = true, DeclaringClass = ceExt } ) );

            //End fixing Ext aliases

            //Adding Ext non existant aliases.
            ceExt.Members.Add( new Property { Name = "Msg", Type = GetClass( "Ext.window.MessageBox" ), DeclaringClass = ceExt, IsStatic = true } );
            ceExt.Members.Add( new Property { Name = "Direct", Type = GetClass( "Ext.direct.Manager" ), DeclaringClass = ceExt, IsStatic = true } );
            //END adding non existant aliases.

            //Add a new utility class to deal with this
            var cellModel = GetClass( "Ext.selection.CellModel" );
            var jsonPositionClass = GetClass( "Ext.selection.CellModel.Position", true );
            jsonPositionClass.Attributes.Add( CreateJsAttribute( "Json" ) );
            jsonPositionClass.Members.AddRange( new Element[] { new Property { Name = "row", Type = GetClass( "int" ), DeclaringClass = jsonPositionClass }, new Property { Name = "column", Type = GetClass( "int" ), DeclaringClass = jsonPositionClass } } );
            cellModel.Members.Where( m => m.Name.Equals( "getCurrentPosition", StringComparison.Ordinal ) ).ForEach( m => m.Type = jsonPositionClass );

            var bExt = GetClass( "Ext.Base", false );

            if ( InheritFromJsContext )
                bExt.BaseClass = GetClass( "JsContext", false );

            //Explicitly setting these members as public to be able to use it in anonymous objects via @this.As<XXX>().callXXX(); (and borrow should be public but docs are wrong according to Ext forum)
            bExt.Members.OfType<Method>().Where( m => m.Name.Equals( "create", StringComparison.Ordinal ) || m.Name.Equals( "implement", StringComparison.Ordinal ) ).ForEach( m =>
            {
                m.IsStatic = false;
                m.Parameters.Add( new Parameter { Type = GetClass( "object" ), Name = "args", IsParams = true, DeclaringClass = bExt } );
            } );
            bExt.Members.Where( m => new[] { "@className", "configMap", "initConfigList", "initConfigMap", "isInstance", "self", "callParent", "callOverridden", "destroy" }.Any( s => s.Equals( m.Name, StringComparison.Ordinal ) ) ).ForEach( m => m.IsProtected = m.IsPrivate = false );
            list.Where( t => t.FullName == "Ext.util.Sortable" || t.Interfaces.FirstOrDefault( i => i.FullName == "Ext.util.Sortable" ) != null ).ForEach( t => t.Members.Where( m => m.Name.IsNullOrEmpty() ).ForEach( m => m.Name = "sortRoot" ) );

            list.ForEach( t => t.Members.Where( m => m.Type != null && m.Type.Name == "this" ).ForEach( m => m.Type = t ) );
            list = list.Where( t => t.Name != "this" ).ToList();

            list.ForEach( t => t.Members.OfType<Method>().Where( m => m.Name == "toFixed" && m.Type == VoidClass ).ForEach( m => m.Type = GetClass( "JsString" ) ) );
            list.ForEach( t => t.Members.OfType<Method>().Where( m => ( m.Name == "child" || m.Name == "down" || m.Name == "up" ) && m.Type == VoidClass ).ForEach( m => m.Type = GetClass( "Ext.container.AbstractContainer" ) ) );
            list.Where( t => t.FullName == "Ext.Action" ).ForEach( t => t.Members.OfType<Method>().Where( m => ( m.Name == "getText" || m.Name == "getIconCls" ) && m.Type == VoidClass ).ForEach( m => m.Type = GetClass( "JsString" ) ) );

            list.Where( t => t.FullName == "Ext.AbstractComponent" ).ForEach( t => t.Members.OfType<Method>().Where( m => m.Name == "addChildEls" ).ForEach( m => m.Parameters.Add( new Parameter { Type = GetClass( "object" ), DeclaringClass = t, Name = "args", IsParams = true, Summary = "<param name=\"args\">An object or array describing the child elements of the Component. <see cref=\"Ext.AbstractComponent.childEls\" /></param>" } ) ) );

            list.Where( t => t.FullName == "Ext.container.AbstractContainer" ).ForEach( t => t.Members.OfType<Method>().Where( m => m.Name.Equals( "add", StringComparison.Ordinal ) ).ForEach( m =>
            {
                m.Parameters[ 0 ].IsParams = true;
                m.Parameters[ 0 ].IsOptional = false;
            } ) );
            list.Where( t => t.FullName == "Ext.data.Store" ).ForEach( t =>
            {
                t.Members.OfType<Method>().Where( m => m.Name.Equals( "guaranteeRange", StringComparison.Ordinal ) ).ForEach( m =>
                {
                    m.Parameters[ 2 ].IsOptional = true;
                    m.Parameters[ 3 ].IsOptional = true;
                } );
                t.Members.OfType<Method>().Where( m => m.Name.Equals( "loadPage" ) ).ForEach( m => m.Parameters[ 1 ].IsOptional = true );
            } );
            list.Where( t => t.FullName == "Ext.EventObject" ).ForEach( t => t.Members.OfType<Method>().ForEach( m => m.IsStatic = false ) );

            list.Where( t => t.FullName == "Ext.CompositeElement" ).ForEach( t => t.Members.Where( m => m.Name.IsNullOrEmpty() ).ForEach( m => m.Name = "UNKNOWN" ) );

            list.ForEach( t => t.Members.OfType<Method>().Where( m => m.Name == "getStore" ).ForEach( m => m.Type = GetClass( "Ext.data.Store" ) ) );

            list.Where( t => t.FullName == "Ext.Error" ).ForEach( t => t.BaseClass = null );
            list.Where( t => t.IsInterface && t.BaseClass != null ).ForEach( t => t.BaseClass = null );
            list.ForEach( t => t.Members.Where( m => m.Name == "isValid" && ( m.Type == null || m.Type == VoidClass ) ).ForEach( m => m.Type = GetClass( "Boolean" ) ) );
            list.ForEach( t => t.Members.Where( m => m.Name == "getState" && ( m.Type == null || m.Type == VoidClass ) ).ForEach( m => m.Type = ObjectClass ) );
            list.ForEach( t => t.Members.Where( m => m.Name == "getSubTplMarkup" && m.Type == ObjectClass ).ForEach( m => m.Type = GetClass( "JsString" ) ) );
            list.ForEach( t => t.Members.Where( m => m.Name == "getInputId" && m.Type == ObjectClass ).ForEach( m => m.Type = GetClass( "JsString" ) ) );
            list.ForEach( t => t.Members.Where( m => m.Name == "getFieldLabel" && m.Type == ObjectClass ).ForEach( m => m.Type = GetClass( "JsString" ) ) );
            list.Where( t => t.FullName.StartsWith( "Ext.selection" ) ).ForEach( t => t.Members.Where( m => m.Name == "getLastSelected" && m.Type == VoidClass ).ForEach( m => m.Type = GetClass( "Ext.data.Model" ) ) );
            list.Where( t => t.Namespace.Equals( "Ext.ux.event", StringComparison.Ordinal ) ).ForEach( t => t.Namespace = "Ext.ux.@event" );

            var ceField = GetClass( "Ext.form.field.Field" );
            list.ForEach( t => t.Members.Where( m => m.Name == "setValue" && m.Type.Interfaces.Contains( ceField ) ).ForEach( m => m.Type = ceField ) );
            list.Where( t => t.BaseClass != null && t.BaseClass.IsInterface ).ForEach( t =>
            {
                t.Interfaces.Insert( 0, t.BaseClass );
                t.BaseClass = null;
            } );

            //Implement missing interface methods
            list.Where( t => !t.IsInterface && t.Interfaces.Count > 0 ).ForEach( t => t.Interfaces.ForEach( i => i.Members.ForEach( im =>
            {
                if ( !InterfaceMemberIsImplementedBySelfOrBaseClass( im, t ) )
                {
                    var ne = new Element();
                    if ( im is Method )
                    {
                        ne = new Method();
                        ( ne as Method ).Parameters = ( im as Method ).Parameters;
                        ( ne as Method ).ReturnsArray = ( im as Method ).ReturnsArray;
                        ( ne as Method ).IsVirtual = true;//Interface implemented methods are virtual by default.
                    }
                    else if ( im is Property )
                    {
                        ne = new Property();
                    }
                    else if ( im is Field )
                    {
                        ne = new Field();
                        ( ne as Field ).Initializer = ( im as Field ).Initializer;
                    }
                    ne.Attributes = im.Attributes;
                    ne.DeclaringClass = t;
                    ne.IsNew = im.IsNew;
                    ne.IsOverride = false;
                    ne.IsPrivate = false;
                    ne.IsProtected = false;
                    ne.IsStatic = false;
                    ne.IsVirtual = true;
                    ne.Name = im.Name;
                    ne.Remarks = im.Remarks;
                    ne.Summary = im.Summary;
                    ne.Type = im.Type ?? ObjectClass;

                    t.Members.Add( ne );
                }
            } ) ) );

            //Make sure interface implemented methods are public, non static and have proper return type
            list.Where( t => !t.IsInterface && t.Interfaces.Count > 0 ).ForEach( t => t.Members.ForEach( m => t.Interfaces.ForEach( i => i.Members.Where( im => im.Name.Equals( m.Name, StringComparison.Ordinal ) ).ForEach( im =>
            {
                var implementedInBase = AnyBaseClassImplements( m );
                m.IsPrivate = m.IsProtected = m.IsStatic = false;
                if ( im is Method && m is Method && ( im as Method ).Parameters.Count == ( m as Method ).Parameters.Count )
                {
                    m.Type = im.Type;
                    ( m as Method ).ReturnsArray = ( im as Method ).ReturnsArray;
                    var index = 0;
                    //If this is the only implementation, lets fix parameter types and make it virtual
                    if ( !implementedInBase )
                    {
                        ( m as Method ).IsVirtual = true;
                        ( im as Method ).Parameters.ForEach( ip =>
                        {
                            if ( ( m as Method ).Parameters[ index ].Type != ip.Type )
                            {
                                ( m as Method ).Parameters[ index ].Type = ip.Type;
                            }
                            index++;
                        } );
                    }
                }

                else if ( !( ( im is Method ) || !( m is Method ) ) )
                {
                    m.Type = im.Type;
                }
            } ) ) ) );

            //list.Where( t => !t.IsInterface && t.Interfaces.Count > 0 ).ForEach( t => t.Members.ForEach( m => t.Interfaces.Where( i => i.Members.Any( im => im.Name.Equals( m.Name, StringComparison.Ordinal ) ) ).ForEach( im =>
            //{
            //    m.IsPrivate = m.IsProtected = m.IsStatic = false;
            //    m.Type = im.Type;
            //} ) ) );

            var invalidMethods = new List<Method>();
            foreach ( var ce in list )
            {
                if ( !ce.IsInterface )
                {
                    var ce2 = ce.BaseClass;
                    while ( ce2 != null )
                    {
                        if ( !ce2.IsInterface )
                        {
                            ce.Members.ForEach( pe =>
                            {
                                var parentM = ce2.Members.FirstOrDefault( t => HasSameNameAndParameterTypes( t, pe ) );
                                if ( parentM != null )
                                {
                                    if ( parentM.IsVirtual && !pe.IsStatic )
                                    {
                                        pe.IsPrivate = parentM.IsPrivate;
                                        pe.IsProtected = parentM.IsProtected;
                                        pe.IsOverride = true;
                                        pe.IsNew = false;
                                    }
                                    else
                                    {
                                        pe.IsNew = true;
                                    }
                                }
                            } );
                        }
                        ce2 = ce2.BaseClass;
                    }
                }
                foreach ( var me in ce.Members.OfType<Method>().ToList() )
                {
                    if ( ce.IsInterface )
                    {
                        me.IsVirtual = false;
                    }
                    var i1 = me.Parameters.FindIndex( p => p.IsOptional );
                    var i2 = me.Parameters.FindLastIndex( p => !p.IsOptional );
                    if ( i2 >= 0 && i1 >= 0 && i2 > i1 )
                    {
                        //This rarelly happens, so far, only one method and we can get away setting the param to optional.
                        me.Parameters[ i2 ].IsOptional = true;
                    }
                    else if ( me.Parameters.FirstOrDefault( t => t.Name == "*" ) != null )
                    {
                        invalidMethods.Add( me );
                        ce.Members.Remove( me );//invalid method prm name
                    }
                }
            }
            File.WriteAllLines( Path.Combine( OutputDir, "InvalidMethods.txt" ), invalidMethods.Select( t => t.DeclaringClass.FullName + ":" + t.Name ).ToArray() );
            list.RemoveAll( t => t.Name == "*" );
            list.Where( ce => !ce.IsInterface ).ForEach( ce =>
            {
                var ceCfg = GetClass( ce.FullName + "Config", false );
                if ( ceCfg != null )
                {
                    var ctors = ce.Members.OfType<Method>().Where( t => t.IsConstructor ).ToList();
                    if ( ctors.FirstOrDefault( t => t.Parameters.Count == 1 && t.Parameters[ 0 ].Type == ceCfg ) == null )
                    {
                        ce.Members.Add( new Method { IsConstructor = true, Parameters = new List<Parameter> { new Parameter { Name = "config", Type = ceCfg } } } );
                    }
                }
                if ( !HasEmptyOrDefaultConstructor( ce ) )
                    ce.Members.Add( new Method { IsConstructor = true } );

                if ( GenerateParamsConstructor )
                {
                    ce.Members.Add( new Method { IsConstructor = true, Parameters = new List<Parameter> { new Parameter { Name = "args", IsParams = true, Type = GetClass( "object" ) } } } );
                }
            } );

            list.ForEach( t => t.Members.Where( m => m.DeclaringClass == null ).ForEach( m => m.DeclaringClass = t ) );
            list.Where( t => t.IsInterface && t.Members.OfType<Method>().Any( m => m.IsConstructor ) ).ForEach( t =>
                                                                                                       {
                                                                                                           var toRemove = new List<Element>();
                                                                                                           t.Members.ForEach( toRemove.Add );
                                                                                                           toRemove.ForEach( r => t.Members.Remove( r ) );
                                                                                                       } );
            //Remove members already implemented in any base class
            list.Where( t => !t.IsInterface && t.BaseClass != null ).ForEach( t =>
            {
                var toRemove = new List<Element>();
                t.Members.ForEach( m =>
                {
                    if ( AnyBaseClassImplements( m ) )
                    {
                        if ( m is Method )
                        {
                            var mt = m as Method;
                            if ( !mt.IsOverride )
                            {
                                toRemove.Add( m );
                            }
                            else
                            {
                                list.ForEach( ty =>
                                                     {
                                                         var parentM = ty.Members.OfType<Method>().FirstOrDefault( me => me.Name != null && me.Name.Equals( mt.Name ) );
                                                         if ( parentM != null && HasSameNameAndParameterTypes( mt, parentM ) )
                                                         {
                                                             toRemove.Add( m );
                                                         }
                                                     } );
                            }
                        }
                        else
                        {
                            toRemove.Add( m );
                        }
                    }
                } );
                toRemove.ForEach( m => t.Members.Remove( m ) );
            } );

            if ( UseProperCaseForPublicMethods )
            {
                list.ForEach( t => t.Members.OfType<Method>().Where( m => !m.IsConstructor && ( !m.IsPrivate || t.IsInterface ) ).ForEach( m =>
                {
                    var needsExtraRename = false;
                    m.Name = m.Name.Trim( '@' );
                    var newName = m.Name.Substring( 0, 1 ).ToUpperInvariant() + m.Name.Substring( 1 );
                    if ( m.DeclaringClass != null && newName.Equals( m.DeclaringClass.Name, StringComparison.Ordinal ) )
                    {
                        needsExtraRename = true;
                    }
                    if ( !needsExtraRename && t.SubClasses.Any( s => s.Name.Equals( newName ) ) )
                    {
                        needsExtraRename = true;
                    }
                    if ( needsExtraRename )
                    {
                        newName = "Mt" + newName;
                        m.Remarks = "This method was renamed from: " + m.Name + " to: Mt" + m.Name + ", this is only for C# code, in Javascript it will appear with the original 'Ext' name (" + m.Name + ")";
                    }

                    if ( m.Attributes.Count == 0 )
                    {
                        m.Attributes.Add( CreateNameAttribute( "JsMethod", m.Name ) );
                    }
                    FixNewName( list, m, newName );
                    m.Name = newName;
                } ) );
            }

            return FixSameNameAsNamespace( list );
        }

        private static Attribute CreateNameAttribute( string attType, string name )
        {
            var att = new Attribute() { Name = attType };
            att.NamedParamters.Add( "Name", "\"" + name + "\"" );
            return att;
        }

        //Fix the docs, change the old name and put the new one
        private static void FixNewName( List<Class> list, Element el, string newName )
        {
            var name = el.DeclaringClass.FullName + "." + el.Name;
            newName = el.DeclaringClass.FullName + "." + newName;
            list.ForEach( t =>
            {
                if ( t.Summary.IsNotNullOrEmpty() )
                    t.Summary = t.Summary.Replace( name, newName );
                t.Members.ForEach( m =>
                {
                    if ( m.Summary.IsNotNullOrEmpty() )
                        m.Summary = m.Summary.Replace( name, newName );
                    if ( m is Method )
                    {
                        ( m as Method ).Parameters.ForEach( p =>
                        {
                            if ( p.Summary.IsNotNullOrEmpty() )
                                p.Summary = p.Summary.Replace( name, newName );
                        } );
                    }
                } );
            } );
        }

        //Check if a member is already declared in any base class up to the top of the hierarchy
        static bool AnyBaseClassImplements( Element el )
        {
            var cls = el.DeclaringClass;
            var baseCls = cls.BaseClass;
            while ( baseCls != null )
            {
                if ( !baseCls.IsInterface && baseCls.IsDeclared( el ) )
                    return true;
                baseCls = baseCls.BaseClass;
            }

            return false;
        }

        static bool InterfaceMemberIsImplementedBySelfOrBaseClass( Element el, Class cls )
        {
            var baseCls = cls;
            while ( baseCls != null )
            {
                //Last check is because (ej) Ext.Base implements all "basic" members requied by interfaces but doesn't implement any interface so members are private there, that shouldn't happen...
                if ( !baseCls.IsInterface && baseCls.IsDeclared( el, true ) /*&& baseCls.Interfaces.Any( i => i.Members.Any( m => m == el ) )*/ )
                    return true;
                baseCls = baseCls.BaseClass;
            }

            return false;
        }

        //If a class ends up having the name that equals a namespace name, that is a problem, we put that class as a nested class
        static List<Class> FixSameNameAsNamespace( List<Class> classes )
        {
            var toRemove = new List<Class>();
            classes.ForEach( c =>
            {
                var equals = classes.Where( cl => c != cl && c.FullName.Equals( cl.Namespace ) ).ToList();
                equals.ForEach( e =>
                {
                    Debug.WriteLine( "FullName: {0} - Namespace: {1}", e.FullName, e.Namespace );
                    var parent = GetClass( e.Namespace );
                    parent.SubClasses.Add( e );
                    toRemove.Add( e );
                } );
            } );

            toRemove.ForEach( c => classes.Remove( c ) );
            return classes;
        }

        static bool HasEmptyOrDefaultConstructor( Class ce )
        {
            var ctors = ce.Members.OfType<Method>().Where( t => t.IsConstructor ).ToList();
            return ctors.Count == 0 || ctors.Any( ctor => ctor.Parameters.Count == 0 || ctor.Parameters.All( t => t.IsOptional ) );
        }
        static bool HasSameNameAndParameterTypes( Element x, Element y )
        {
            if ( x is Method && y is Method )
            {
                var me1 = ( Method ) x;
                var me2 = ( Method ) y;
                if ( ( me1.IsConstructor && me2.IsConstructor ) || ( me1.Name == me2.Name ) )
                {
                    if ( me1.Parameters.Count == me2.Parameters.Count )
                    {
                        if ( me1.Parameters.TrueForAllTwice( me2.Parameters, ( xx, yy ) => xx.Type == yy.Type ) && x.IsStatic == y.IsStatic )
                            return true;
                    }
                }
                return false;
            }
            return x.Name == y.Name && x.IsStatic == y.IsStatic;
        }

        static HashSet<Class> Exported = new HashSet<Class>();

        private static void Export( List<Class> list, string csFile )
        {
            if ( File.Exists( csFile ) )
                File.Delete( csFile );
            //if ( !csFile.EndsWith( "Ext.cs" ) )
            //{
            //    var fileName = csFile.Replace( "Ext.", "" ).Replace( ".cs", "" );
            //    csFile = fileName.Replace( ".", "\\" ) + ".cs";
            //}
            //var dirs = csFile.Split( '\\' );
            //var d = string.Empty;
            //foreach ( var dir in dirs )
            //{
            //    if ( !dir.Contains( ".cs" ) )
            //    {
            //        d += dir;
            //        if ( !Directory.Exists( d ) )
            //        {
            //            Directory.CreateDirectory( d );
            //        }
            //    }
            //}
            using ( var writer = new StreamWriter( csFile ) )
            {
                var exporter = new CodeModelExporter { Assembly = Assembly, Writer = new IndentedTextWriter( writer ) };
                exporter.ExportHeader();
                exporter.Export( list );
            }
        }


        static bool IsDeclared( ExtClass ce2, ExtMember me2 )
        {
            if ( me2.owner == ce2.name && me2.defined_in == ce2.name )
                return true;

            //if ( me2.defined_in.IsNullOrEmpty() || me2.defined_in == ce2.name || ( ce2.singleton && !me2.meta.@static ) )
            //    return true;

            var ce = GetClass( ce2.name, false );
            var ceOwner = GetClass( me2.owner );
            if ( ce.IsInterface && ceOwner.IsInterface )
                return false;
            if ( ceOwner.IsInterface )
            {
                if ( ( ce.BaseClass == null || ce.BaseClass.IsInterface || !ce.BaseClass.Interfaces.Contains( ceOwner ) ) && ce.BaseClass.BaseClass != ceOwner )
                    return true;
            }
            if ( me2.defined_in.IsNotNullOrEmpty() )
            {
                var ceDefiner = GetClass( me2.defined_in );
                if ( ceDefiner.IsInterface && !ce.IsInterface )
                    return true;
            }
            return me2.defined_in.IsNullOrEmpty() || ce2.singleton && ( ce2.singleton && !me2.meta.@static );
        }

        static bool IsDeclared( Class ce, ExtMember me2 )
        {
            return ce.Members.Any( m => m.Name.Replace( "@", "" ).Equals( me2.name.Replace( "@", "" ) ) );
        }

        private static List<Class> Process( ExtClass ce2 )
        {
            Console.WriteLine( ce2.name );
            var ce = GetClass( ce2.name, true );
            ce.Attributes.Add( CreateJsAttribute( "Prototype" ) );
            ce.IsInterface = ce2.mixedInto != null && ce2.mixedInto.Count > 0;

            var ceCfg = GetClass( ce.FullName + "Config", true );
            ceCfg.Attributes.Add( CreateJsAttribute( "Json" ) );

            var ceEvents = GetClass( ce.FullName + "Events", true );
            ceEvents.Attributes.Add( CreateJsAttribute( "Json" ) );
            var list = new List<Class> { ce, ceCfg, ceEvents };

            return list;
        }
        static void ProcessBaseClassAndInterfaces( ExtClass ce2 )
        {
            var ce = GetClass( ce2.name, false );
            if ( ce2.superclasses != null && ce2.superclasses.Count > 0 )
                ce.BaseClass = GetClass( ce2.superclasses.Last() );

            if ( ce2.mixins != null )
                ce.Interfaces.AddRange( ce2.mixins.Select( t => GetClass( t ) ) );

            if ( ce.BaseClass != null )
            {
                var ceCfg = GetClass( ce.FullName + "Config", false );
                if ( ceCfg != null )
                    ceCfg.BaseClass = GetClass( ce.BaseClass.FullName + "Config", false );
                var ceEvents = GetClass( ce.FullName + "Events", true );
                if ( ceEvents != null )
                    ceEvents.BaseClass = GetClass( ce.BaseClass.FullName + "Events", false );
            }

        }

        private static void ProcessMembers( ExtClass ce2 )
        {
            Console.WriteLine( ce2.name );
            var ce = GetClass( ce2.name );
            CurrHtDoc.LoadHtml( ce2.html );
            ce2.AllMembers.ForEach( ProcessMemberDocs );

            if ( IncludeConfigsInMainClass && !ce.IsInterface )
                ce.Members.AddRange( ce2.members.cfg.Where( t => IsDeclared( ce2, t ) && ( t.defined_in.IsNullOrEmpty() || t.defined_in == t.owner || ce2.singleton ) && !ce2.members.property.Any( t2 => t2.name.Equals( t.name, StringComparison.Ordinal ) ) && !ce2.members.method.Any( t2 => t2.name.Equals( t.name, StringComparison.Ordinal ) ) ).Select( ProcessCfg ) );
            ce.Members.AddRange( ce2.members.property.Where( t => IsDeclared( ce2, t ) && ( t.defined_in.IsNullOrEmpty() || t.defined_in == t.owner || ce2.singleton ) ).Select( ProcessProperty ) );
            ce.Members.AddRange( ce2.members.method.Where( t => IsDeclared( ce2, t ) ).Select( ProcessMethod ) );

            if ( !ce.IsInterface )
            {
                ce.Members.AddRange( ce2.statics.property.Where( t => IsDeclared( ce2, t ) && !IsDeclared( ce, t ) && ( t.defined_in.IsNullOrEmpty() || t.defined_in == t.owner || ce2.singleton ) ).Select( ProcessProperty ) );
                ce.Members.AddRange( ce2.statics.method.Where( t => IsDeclared( ce2, t ) && !IsDeclared( ce, t ) && ( t.defined_in.IsNullOrEmpty() || t.defined_in == t.owner || ce2.singleton ) ).Select( ProcessMethod ) );
            }

            var ceCfg = GetClass( ce.FullName + "Config", false );
            if ( ceCfg != null )
            {
                ceCfg.Members.AddRange( ce2.members.cfg.Where( t => IsDeclared( ce2, t ) && ( t.defined_in.IsNullOrEmpty() || t.defined_in == t.owner || ce2.singleton ) ).Select( ProcessCfg ) );
                if ( !ceCfg.IsInterface )
                    ceCfg.Members.AddRange( ce2.statics.cfg.Where( t => IsDeclared( ce2, t ) && !IsDeclared( ceCfg, t ) && ( t.defined_in.IsNullOrEmpty() || t.defined_in == t.owner || ce2.singleton ) ).Select( ProcessCfg ) );
            }

            var ceEvents = GetClass( ce.FullName + "Events", false );
            if ( ceEvents != null )
                ceEvents.Members.AddRange( ce2.members.@event.Where( t => IsDeclared( ce2, t ) ).Select( ProcessEvent ) );
            if ( ce2.singleton )
            {
                ce.Members.ForEach( t => t.IsStatic = true );
            }
            ce.Summary = FixDoc();
        }

        private static Method ProcessEvent( ExtMember ev2 )
        {
            return ProcessMethod( ev2 );

            //ProcessMemberDocs( ev2 );
            //var pe = new Method { Name = ev2.name, Type = GetClass( "JsString" ), Summary = ev2.shortDoc, IsStatic = true};
            //SetModifiers( ev2, pe );
            ////pe.IsStatic = true;
            ////pe.Initializer = "\"" + ev2.name + "\"";
            //return pe;
        }

        private static void SetModifiers( ExtMember me2, Element me )
        {
            me.IsStatic = me2.meta.@static;
            me.IsPrivate = me2.meta.@private;
            me.IsProtected = me2.meta.@protected;
        }

        private static Property ProcessProperty( ExtMember p )
        {
            //return ProcessCfg( p );
            var pe = new Property { Name = p.name, Type = GetClass( p.type ), Summary = p.shortDoc, IsPrivate = p.meta.@private, IsProtected = p.meta.@protected, IsStatic = p.meta.@static };
            if ( pe.Name.Contains( "$" ) )
            {
                pe.Attributes.Add( new Attribute() { Name = "JsProperty", NamedParamters = new Dictionary<string, string>() { { "Name", "\"" + pe.Name + "\"" } } } );
                pe.Name = pe.Name.Replace( "$", "@" );
            }
            else
            {
                if ( UseProperCaseForPublicPropertys && !pe.IsPrivate )//In this case, we take protected as the same as public because you can use those in your inherited classes
                {
                    pe.Name = pe.Name.Substring( 0, 1 ).ToUpperInvariant() + pe.Name.Substring( 1 );
                    if ( pe.DeclaringClass != null && pe.Name.Equals( pe.DeclaringClass.Name, StringComparison.Ordinal ) )
                    {
                        pe.Remarks = "This property was renamed from: " + pe.Name + ", this is only for C# code, in Javascript it will appear with the original Ext name wich is: " + p.name + ".";
                        pe.Name = "M_" + pe.Name;
                    }
                    pe.Attributes.Add( new Attribute() { Name = "JsProperty" } );
                    pe.Attributes[ 0 ].NamedParamters.Add( "Name", "\"" + p.name + "\"" );
                }
            }
            return pe;
        }

        private static Method ProcessMethod( ExtMember me2 )
        {
            //var owner = GetClass( me2.owner );
            //ProcessMemberDocs( me2 );

            var clsName = me2.name == "constructor" ? me2.owner : me2.type; //unified "type" is never null
            var me = new Method
            {
                Name = me2.name,
                Type = GetClass( clsName ),
                Summary = me2.shortDoc,
                ParametersDocs = me2.paramsDocs,
                ReturnsDocs = me2.returnsDocs,
                IsPrivate = me2.meta.@private,
                IsProtected = me2.meta.@protected,
                IsStatic = me2.meta.@static,
                IsVirtual = me2.shortDoc.Contains( "template method" ),
                IsConstructor = me2.name == "constructor",
                ReturnsArray = me2.ReturnsArray
            };

            if ( me2.@params != null && me2.@params.Count > 0 )
                me.Parameters.AddRange( me2.@params.Select( ProcessParam ) );
            return me;
        }

        public static void FixHref( HtmlNode node )
        {
            if ( node.HasChildNodes )
            {
                node.ChildNodes.ForEach( FixHref );
            }
            if ( node.Name.Equals( "a", StringComparison.OrdinalIgnoreCase ) && !node.HasAttributes )
            {
                node.Name = "see";
            }
            else if ( node.Name.Equals( "a", StringComparison.OrdinalIgnoreCase ) && node.HasAttributes )
            {
                var val = node.GetAttributeValue( "rel", string.Empty );
                node.Attributes.RemoveAll();
                if ( !string.IsNullOrEmpty( val ) && !val.StartsWith( "template " ) )
                {
                    var originalVal = val;
                    node.Name = "see";
                    if ( val.Contains( "-" ) )
                    {
                        val = val.Replace( "-", "." ).Replace( ".cfg.", "Config." ).Replace( ".method.", "." ).Replace( ".event.", "Events." ).Replace( ".property.", "." ).Replace( ".static.", "." );
                        originalVal = val.Replace( "-", "." ).Replace( ".cfg.", "." ).Replace( ".method.", "." ).Replace( ".event.", "." ).Replace( ".property.", "." ).Replace( ".static.", "." );
                    }
                    if ( extCreDef.Any( e => e.Equals( val, StringComparison.Ordinal ) ) )
                    {
                        val = val.Replace( "Ext.", "Ext.ExtContext." );
                    }
                    val = val.Replace( "Boolean", "bool" );
                    node.Attributes.Add( "cref", val );
                    //var newHtml = node.InnerHtml.ReplaceFirst( originalVal, "" );
                    //if ( originalVal.Contains( "." ) && newHtml.Equals( node.InnerHtml, StringComparison.Ordinal ) )
                    //{
                    //    newHtml = node.InnerHtml.ReplaceFirst( originalVal.Split( '.' ).Last(), "" );
                    //}
                    //node.InnerHtml = newHtml;
                }
                else
                {
                    node.Name = "i";
                }
            }
            else if ( !node.Name.Equals( "a", StringComparison.OrdinalIgnoreCase ) )
            {
                if ( node.Name.Equals( "code", StringComparison.OrdinalIgnoreCase ) )
                {
                    if ( !node.InnerText.Contains( "\n" ) && !node.InnerText.Contains( "\r\n" ) )//Inline code tag
                    {
                        node.Name = "c";
                    }
                }
                if ( node.Name.Equals( "img", StringComparison.OrdinalIgnoreCase ) )
                {
                    node.Name = "i";
                }
                if ( node.HasAttributes )
                    node.Attributes.RemoveAll();
            }
        }

        internal static void ProcessMemberDocs( ExtMember me2 )
        {
            var div = CurrHtDoc.GetElementbyId( me2.id );
            if ( div != null )
            {
                var divDesc = div.ChildNodes.FirstOrDefault( c => c.Attributes[ "class" ].Value.Equals( "description" ) );
                var longDesc = divDesc.ChildNodes.FirstOrDefault( c => c.GetAttributeValue( "class", string.Empty ).Equals( "long", StringComparison.Ordinal ) );
                var parameters = longDesc.SelectSingleNode( "h3[text()='Parameters']/following-sibling::ul" );
                if ( me2.id.Contains( "property-" ) || me2.id.Contains( "cfg-" ) )
                {
                    var propVal = div.SelectSingleNode( "div[@class='title']" );// .ChildNodes.FirstOrDefault( n => n.Attributes[ "class" ].Value.Equals( "title", StringComparison.OrdinalIgnoreCase ) );
                    var type = "object";
                    if ( propVal != null )
                    {
                        var definedIn = propVal.SelectSingleNode( "div/span[@class='defined-in']" );
                        var a = propVal.SelectNodes( "span/a" );// .ChildNodes.FirstOrDefault( n => n.Name.Equals( "span", StringComparison.OrdinalIgnoreCase ) ).ChildNodes.Where( n => n.Name.Equals( "a", StringComparison.OrdinalIgnoreCase ) ).ToList();
                        if ( a != null && a.Count == 1 )
                        {
                            type = a.FirstOrDefault().InnerText;
                            if ( type.Contains( "/" ) )
                            {
                                type = type.Split( '/' )[ 0 ];
                            }
                        }

                        if ( propVal.InnerText.Contains( "[]" ) )
                        {
                            type = type.Trim( '[', ']' );
                            me2.ReturnsArray = true;
                        }
                        if ( definedIn != null )
                        {
                            me2.defined_in = definedIn.GetAttributeValue( "rel", string.Empty );
                        }
                    }
                    me2.type = type.Replace( "void", "Object" ).Replace( "Object", "JsObject" ).Replace( "String", "JsString" ).Replace( "Ext.data.Record", "Ext.data.Model" ).Replace( "Ext.slider.MultiSlider", "Ext.slider.Multi" ).Replace( "MultiSlider", "Multi" );
                }
                else
                {
                    me2.type = "void";
                    var ret = longDesc.SelectSingleNode( "h3[text()='Returns']/following-sibling::ul/li" );
                    var definedIn = div.SelectSingleNode( "div[@class='title']/div[@class='meta']/*[@rel != '']" );
                    if ( definedIn != null )
                    {
                        me2.defined_in = definedIn.GetAttributeValue( "rel", string.Empty );
                    }
                    if ( ret != null )
                    {
                        if ( ret.InnerText.Contains( "[]" ) )
                        {
                            me2.ReturnsArray = true;
                        }
                        if ( !me2.meta.@protected && !me2.meta.@private && AllPublicMethodsReturn.IsNotNullOrEmpty() )
                        {
                            me2.type = AllPublicMethodsReturn;
                        }
                        else if ( me2.meta.@protected || me2.meta.@private || AllPublicMethodsReturn.IsNullOrEmpty() )
                        {
                            me2.type = ret.SelectSingleNode( "span" ).InnerText.Replace( "object", "Object" ).Replace( "Object", "object" ).Replace( "String", "JsString" ).Replace( "Ext.data.Record", "Ext.data.Model" ).Replace( "Ext.slider.MultiSlider", "Ext.slider.Multi" ).Replace( "MultiSlider", "Multi" ).Replace( "HTMLElement", "JsObject" );
                            FixHref( ret );
                            me2.returnsDocs = ret.InnerHtml;
                            me2.type = me2.type.Trim( '[', ']' );
                        }
                    }
                }
                if ( parameters != null )
                {
                    foreach ( var li in parameters.SelectNodes( "li" ) )
                    {
                        var name = li.FirstChild.InnerText.Trim();
                        if ( !string.IsNullOrEmpty( name ) )
                        {
                            var a = li.SelectNodes( "a" );
                            if ( a == null || a.Count == 0 )
                            {
                                var pre = li.SelectSingleNode( "span[@class='pre']" );// .ChildNodes.FirstOrDefault( n => n.HasAttributes && n.GetAttributeValue( "class", string.Empty ).Equals( "pre", StringComparison.OrdinalIgnoreCase ) );
                                if ( pre != null )
                                {
                                    a = pre.SelectNodes( "a" );// .ChildNodes.Where( n => n.Name.Equals( "a", StringComparison.OrdinalIgnoreCase ) ).ToList();
                                }
                            }
                            var desc = string.Empty;
                            var descNode = li.SelectSingleNode( "div[@class='sub-desc']" );// li.ChildNodes.FirstOrDefault( n => n.Name.Equals( "div", StringComparison.OrdinalIgnoreCase ) && n.Attributes[ "class" ].Value.Equals( "sub-desc", StringComparison.OrdinalIgnoreCase ) );
                            if ( descNode != null )
                            {
                                FixHref( descNode );
                                desc = descNode.InnerHtml;
                            }
                            if ( me2.@params == null )
                                me2.@params = new List<ExtParam>();
                            var type = "object";
                            var isOptional = li.InnerText.Contains( "ptional" ) || li.InnerText.Contains( "(defaults" ) || ForcedOptionalParameterNames.Any( p => p.Equals( name, StringComparison.Ordinal ) );
                            var isParams = li.InnerText.Contains( "Variable number" );
                            //If the parameter is optional, there is a great chance that the type is wrong...
                            if ( !isOptional && !name.Equals( "fn", StringComparison.OrdinalIgnoreCase ) )
                            {
                                if ( a != null && a.Count == 1 && !li.InnerText.Contains( "/" ) ) //If there are no items or the parameter accepts more than one type, we use object
                                {
                                    var al = a.FirstOrDefault();
                                    type = al.InnerText.Trim();
                                    var isArray = li.InnerText.Contains( "[" ) && li.InnerText.Contains( "]" );
                                    if ( type.IndexOfAny( MultipleObjectDelimiter ) >= 0 ) // Any "complex" type will become "object" for easier casting
                                    {
                                        type = "object";
                                    }
                                    type = type.Trim( '[', ']' );
                                    if ( isArray )
                                    {
                                        type = string.Format( "JsArray<{0}>", type );
                                    }
                                }
                                if ( type.Equals( "Object", StringComparison.Ordinal ) )
                                {
                                    type = "object";
                                }
                                if ( type.Equals( "String", StringComparison.OrdinalIgnoreCase ) )
                                {
                                    type = "JsString";
                                }
                                type = type.Replace( "Ext.data.Record", "object" ).Replace( "Ext.Element", "Ext.dom.Element" ).Replace( "Ext.core.Element", "Ext.dom.Element" ).Replace( "Ext.slider.MultiSlider", "Ext.slider.Multi" ).Replace( "MultiSlider", "Multi" );
                            }
                            else if ( name.Equals( "fn", StringComparison.OrdinalIgnoreCase ) )
                            {
                                type = "System.Delegate";// All functions to...
                            }
                            me2.@params.Add( new ExtParam
                            {
                                name = name,
                                optional = isOptional,
                                type = type,
                                doc = desc
                            } );
                            me2.paramsDocs = ( string.IsNullOrEmpty( me2.paramsDocs ) ? "" : me2.paramsDocs + Environment.NewLine ) + string.Format( "<param name=\"{0}\">{1}</param>", name, desc );
                        }
                    }
                }
                if ( longDesc.FirstChild != null )
                {
                    longDesc = longDesc.CloneNode( true );
                    FixHref( longDesc );
                    me2.shortDoc = longDesc.FirstChild.InnerText;
                    if ( longDesc.FirstChild != null && longDesc.FirstChild.NextSibling != null )
                    {
                        var preCode = longDesc.FirstChild.NextSibling;
                        do
                        {
                            //FixHref( preCode );
                            if ( preCode.Name.Equals( "pre", StringComparison.OrdinalIgnoreCase ) )
                            {
                                me2.shortDoc = string.Format( "{0}{1}{2}", Environment.NewLine, me2.shortDoc, preCode.InnerHtml );
                            }
                            else
                            {
                                me2.shortDoc += preCode.InnerHtml;
                            }
                            preCode = preCode.NextSibling;
                        } while ( preCode != null && !preCode.Name.Equals( "h3", StringComparison.OrdinalIgnoreCase ) );
                    }
                }
                else
                {
                    me2.shortDoc = longDesc.InnerText;
                }
            }
        }

        static string FixDoc( string docStr = null )
        {
            var doc = docStr;
            if ( docStr == null )
            {
                if ( CurrHtDoc.DocumentNode == null || CurrHtDoc.DocumentNode.ChildNodes == null || CurrHtDoc.DocumentNode.ChildNodes.Count <= 0 )
                {
                    return null;
                }
                var t = CurrHtDoc.DocumentNode.ChildNodes.Elements().FirstOrDefault( n => n.HasAttributes && n.GetAttributeValue( "class", string.Empty ).Equals( "doc-contents", StringComparison.OrdinalIgnoreCase ) );

                if ( t != null )
                    FixHref( t );
                doc = t != null && !string.IsNullOrEmpty( t.InnerHtml ) ? t.InnerHtml : null;
            }
            return doc;
        }
        private static Parameter ProcessParam( ExtParam prm2 )
        {
            var prm = new Parameter { Name = prm2.name, Type = GetClass( prm2.type ), IsOptional = prm2.optional, Summary = prm2.doc, IsParams = prm2.name.Equals( "add", StringComparison.Ordinal ) || prm2.doc.Contains( "ariable number of" ) };
            if ( prm.IsParams )
                prm.IsOptional = false;
            return prm;
        }

        static Class GetClass( string name, bool? autoCreate = null )
        {
            if ( name.IsNullOrEmpty() )
                return null;
            name = name.Trim( '[', ']', '.' );
            var ce = Context.GetClass( name );
            if ( ce == null )
            {
                if ( name.Contains( "/" ) || name.Contains( "|" ) )
                    return ObjectClass;
            }
            name = Context.ClassMappings.TryGetValue( name ) ?? name;
            if ( ce == null && autoCreate.GetValueOrDefault( true ) )
            {
                if ( autoCreate == null )
                {
                }
                ce = new Class { FullName = name };
                Assembly.Classes.Add( ce );
            }
            return ce;
        }

        private static Field ProcessCfg( ExtMember t )
        {
            //ProcessMemberDocs( t );
            var pe = new Field { Name = t.name, Type = GetClass( t.type ), Summary = t.shortDoc };
            SetModifiers( t, pe );
            //pe.Initializer = "\"" + t.name + "\"";
            if ( pe.Name.Contains( "$" ) )
            {
                pe.Attributes.Add( new Attribute() { Name = "JsField", NamedParamters = new Dictionary<string, string>() { { "Name", "\"" + pe.Name + "\"" } } } );
                pe.Name = pe.Name.Replace( "$", "@" );
            }
            return pe;
        }


        private static Attribute CreateJsAttribute( string jsMode )
        {
            return new Attribute
            {
                Name = "JsType",
                Parameters = new List<string> { "JsMode." + jsMode },
                NamedParamters = new Dictionary<string, string> 
                        {
                            {"Export", "false"},
                            {"OmitOptionalParameters", "true"}
                        }
            };
        }


        public static Class VoidClass { get; set; }

    }
}