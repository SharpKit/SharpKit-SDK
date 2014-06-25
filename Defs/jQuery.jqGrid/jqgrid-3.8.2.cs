using SharpKit.JavaScript;

namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export=false)]
    public static partial class jQGridPlugin
    {
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery jqGrid(this jQuery query) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery jqGrid(this jQuery query, jQGridOptions options) { return default(jQuery); }
        [JsMethod(ExtensionImplementedInInstance = true, NativeOverloads = true)]
        public static jQuery jqGrid(this jQuery query, string methodName, params object[] args) { return default(jQuery); }
    }

    [JsType(JsMode.Json)]
    public class jQGridOptions
    {
        /// <summary>
        /// Tells us where to get the data. Typically this is a server-side function with a connection to a database which returns the appropriate information to be filled into the Body layer in the grid 
        /// </summary>
        public JsString url { get; set; }
        /// <summary>
        /// 	This tells jqGrid the type of information being returned so it can construct the grid. In this case, we tell the grid that we expect xml data to be returned from the server, but other formats are possible. For a list of all available datatypes refer to API Methods 
        /// </summary>
        public JsString datatype { get; set; }
        /// <summary>
        /// 	Tells us how to make the ajax call: either 'GET' or 'POST'. In this case, we will use the GET method to retrieve data from the server 
        /// </summary>
        public JsString mtype { get; set; }
        /// <summary>
        /// 	An array in which we place the names of the columns. This is the text that appears in the head of the grid (Header layer). The names are separated with commas 
        /// </summary>
        public JsArray<JsString> colNames { get; set; }
        /// <summary>
        /// An array that describes the model of the columns. This is the most important part of the grid. Here I explain only the options used above. an array that describes the model of the columns. This is the most important part of the grid. Here I explain only the options used above. For the complete list of options see colModel API
        ///name the name of the column. This name does not have to be the name from database table, but later we will see how we can use this when we have different data formats
        ///index the name passed to the server on which to sort the data (note that we could pass column numbers instead). Typically this is the name (or names) from database – this is server-side sorting, so what you pass depends on what your server expects to receive
        ///width the width of the column, in pixels
        ///align the alignment of the column
        ///sortable Specifies if the data in the grid can be sorted on this column; if false, clicking on the header has no effect
        /// </summary>
        public JsArray<jQGridColumn> colModel { get; set; }
        /// <summary>
        /// Defines that we want to use a pager bar to navigate through the records. This must be a valid html element.Note that the Navigation layer (the “pager” div) can be positioned anywhere you want, determined by your html.
        /// </summary>
        public JsString pager { get; set; }
        /// <summary>
        /// Sets how many records we want to view in the grid. This parameter is passed to the url for use by the server routine retrieving the data
        /// </summary>
        public JsNumber rowNum { get; set; }
        /// <summary>
        /// An array to construct a select box element in the pager in which we can change the number of the visible rows. When changed during the execution, this parameter replaces the rowNum parameter that is passed to the url.
        /// </summary>
        public JsArray<JsNumber> rowList { get; set; }
        /// <summary>
        /// 	Sets the initial sorting column. Can be a name or number. This parameter is added to the url for use by the server routine
        /// </summary>
        public JsString sortname { get; set; }
        public JsString sortorder { get; set; }
        /// <summary>
        /// Sets the caption for the grid. If this parameter is not set the Caption layer will be not visible
        /// </summary>
        public JsString caption { get; set; }
        /// <summary>
        /// Defines whether we want to display the number of total records from the query in the pager bar
        /// </summary>
        public JsBoolean viewrecords { get; set; }

        public JsNumber height { get; set; }

        public JsAction gridComplete { get; set; }
    }

    [JsType(JsMode.Json)]
    public class jQGridColumn
    {
        public JsString name { get; set; }
        public JsString index { get; set; }
        public JsNumber width { get; set; }
        public JsString align { get; set; }
        public JsBoolean sortable { get; set; }  
        public JsBoolean editable { get; set; }  
        public JsString edittype { get; set; }
        public JsString formatter { get; set; }
        public jQGridFormatOptions formatoptions { get; set; }
    }

    [JsType(JsMode.Json)]
    public class jQGridFormatOptions
    {
        public JsBoolean disabled { get; set; }  
    }

    
}