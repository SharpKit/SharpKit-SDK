
using SharpKit.JavaScript;
using SharpKit.Html;
using System;

namespace SharpKit.Highcharts
{
    //TODO: make sure all the methos that return HtmlElement are correct. (there is also an Element class so i didn't know wich one...)
    //TODO: was i suposed to do something after creating the class? like writh a propertye or else?

    /// <summary>
    /// The namespace under which all other Highcharts variables are assembled is called Highcharts.
    /// var chart1 = new Highcharts.Chart(options);
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts", Export = false)]
    public class Highcharts
    {
        /// <summary>
        /// This is the constructor for creating a new chart object.
        /// </summary>
        /// <param name="options">The chart options, as documented under the heading "The options object"in the left menu.</param>
        /// <param name="callback">A function to execute when the chart object is finished loading and rendering.
        /// In most cases the chart is built in one thread, but in Internet Explorer version 8 or lessthe chart is sometimes initiated before the document is ready,
        /// and in thesecases the chart object will not be finished directly after callingnew Highcharts.Chart().
        /// As a consequence, code that relies on the newly built Chart object should always run in the callback.
        /// Defining a chart.event.load handler is equivalent.</param>
        /// <returns></returns>
        public Chart Chart(ChartOptions options, JsAction callback) { return null; }
        //TODO: must check, they say it is a constractor

        /// <summary>
        /// Formats a JavaScript date timestamp (milliseconds since Jan 1st 1970) into a human readable date string.
        /// The format is a subset of the formats for PHP's strftime function.
        /// </summary>
        /// <param name="format">A string containing some of the formats above.</param>
        /// <param name="time">The JavaScript time to format.</param>
        /// <param name="capitalize">Whether to capitalize words in the return string.</param>
        /// <returns></returns>
        public JsString dateFormat(JsString format, JsNumber time, bool capitalize) { return null; }
        /// <summary>
        /// Formats a JavaScript date timestamp (milliseconds since Jan 1st 1970) into a human readable date string.
        /// The format is a subset of the formats for PHP's strftime function.
        /// </summary>
        /// <param name="format">A string containing some of the formats above.</param>
        /// <param name="time">The JavaScript time to format.</param>
        /// <returns></returns>
        public JsString dateFormat(JsString format, JsNumber time) { return null; }
        /// <summary>
        /// Formats a JavaScript date timestamp (milliseconds since Jan 1st 1970) into a human readable date string.
        /// The format is a subset of the formats for PHP's strftime function.
        /// </summary>
        /// <param name="format">A string containing some of the formats above.</param>
        /// <returns></returns>
        public JsString dateFormat(JsString format) { return null; }

        /// <summary>
        /// Formats a JavaScript number with grouped thousands, a fixed amount of decimals and an optional decimal point.
        /// It is a port of PHP's function with the same name. See PHP number_format for a full explanation of the parameters.
        /// </summary>
        /// <param name="number">The raw number to format.</param>
        /// <param name="decimals">The desired number of decimals.</param>
        /// <param name="decimalPoint">The decimal point. Defaults to "." or to the string specified globally in options.lang.decimalPoint.</param>
        /// <param name="thousandsSep">The thousands separator. Defaults to "," or to the string specified globallyin options.lang.thousandsSep.</param>
        /// <returns></returns>
        public JsString numberFormat(JsNumber number, JsNumber decimals, JsString decimalPoint, JsString thousandsSep) { return null; }
        /// <summary>
        /// Formats a JavaScript number with grouped thousands, a fixed amount of decimals and an optional decimal point.
        /// It is a port of PHP's function with the same name. See PHP number_format for a full explanation of the parameters.
        /// </summary>
        /// <param name="number">The raw number to format.</param>
        /// <param name="decimals">The desired number of decimals.</param>
        /// <param name="decimalPoint">The decimal point. Defaults to "." or to the string specified globally in options.lang.decimalPoint.</param>
        /// <returns></returns>
        public JsString numberFormat(JsNumber number, JsNumber decimals, JsString decimalPoint) { return null; }
        /// <summary>
        /// Formats a JavaScript number with grouped thousands, a fixed amount of decimals and an optional decimal point.
        /// It is a port of PHP's function with the same name. See PHP number_format for a full explanation of the parameters.
        /// </summary>
        /// <param name="number">The raw number to format.</param>
        /// <param name="decimals">The desired number of decimals.</param>
        /// <returns></returns>
        public JsString numberFormat(JsNumber number, JsNumber decimals) { return null; }
        /// <summary>
        /// Formats a JavaScript number with grouped thousands, a fixed amount of decimals and an optional decimal point.
        /// It is a port of PHP's function with the same name. See PHP number_format for a full explanation of the parameters.
        /// </summary>
        /// <param name="number">The raw number to format.</param>
        /// <returns></returns>
        public JsString numberFormat(JsNumber number) { return null; }

        /// <summary>
        /// Sets the options globally for all charts created after this has been called.
        /// Takes an options JavaScript object structure as the argument. These options are merged with the default options and the result is returned.
        /// </summary>
        /// <param name="options">The chart configuration object.</param>
        /// <returns></returns>
        public object setOptions(ChartConfiguration options) { return null; }
        //TODO: options type is ChartConfiguration or ChartOptions?
    }
    //TODO: this is a namespce not a class

    /// <summary>
    /// The chart object is the JavaScript object representing a single chart in the web page.The pointer to your chart object
    /// is returned when a chart is created using the Highcharts.Chart() constructor:
    /// var chart1 = new Highcharts.Chart(options);
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts.Chart", Export = false)]
    public class Chart
    {
        public Chart(ChartConfiguration Config) { }

        /// <summary>
        /// An array of the chart's x axes. If only one x axis, it is referenced by chart.xAxis[0].
        /// </summary>
        public JsArray<Axis> xAxis { get; set; }

        /// <summary>
        /// An array of the chart's y axes. If only one y axis, it is referenced by chart.yAxis[0].
        /// </summary>
        public JsArray<Axis> yAxis { get; set; }

        /// <summary>
        /// Add a series to the chart after render time.
        /// Note that this method should never be usedwhen adding data synchronously at chart render time, as it adds expense to the calculationsand rendering.
        /// When adding data at the same time as the chart is initiated, add the seriesas a configuration option instead.
        /// </summary>
        /// <param name="options">The series options, as documented under plotOptions.seriesand under the plotOptions for each series type.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is added. See the redraw()method below.</param>
        /// <param name="animation">Defaults to true. When true, the series' updating will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        /// <returns></returns>
        public Series addSeries(PlotSeriesOptions options, bool redraw, bool animation) { return null; }
        /// <summary>
        /// Add a series to the chart after render time.
        /// Note that this method should never be usedwhen adding data synchronously at chart render time, as it adds expense to the calculationsand rendering.
        /// When adding data at the same time as the chart is initiated, add the seriesas a configuration option instead.
        /// </summary>
        /// <param name="options">The series options, as documented under plotOptions.seriesand under the plotOptions for each series type.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is added. See the redraw()method below.</param>
        /// <param name="animation">Defaults to true. When true, the series' updating will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        /// <returns></returns>
        public Series addSeries(PlotSeriesOptions options, bool redraw, AnimationOptions animation) { return null; }
        /// <summary>
        /// Add a series to the chart after render time.
        /// Note that this method should never be usedwhen adding data synchronously at chart render time, as it adds expense to the calculationsand rendering.
        /// When adding data at the same time as the chart is initiated, add the seriesas a configuration option instead.
        /// </summary>
        /// <param name="options">The series options, as documented under plotOptions.seriesand under the plotOptions for each series type.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is added. See the redraw()method below.</param>
        /// <returns></returns>
        public Series addSeries(PlotSeriesOptions options, bool redraw) { return null; }
        /// <summary>
        /// Add a series to the chart after render time.
        /// Note that this method should never be usedwhen adding data synchronously at chart render time, as it adds expense to the calculationsand rendering.
        /// When adding data at the same time as the chart is initiated, add the seriesas a configuration option instead.
        /// </summary>
        /// <param name="options">The series options, as documented under plotOptions.seriesand under the plotOptions for each series type.</param>
        /// <returns></returns>
        public Series addSeries(PlotSeriesOptions options) { return null; }

        /// <summary>
        /// A reference to the containing HTML element as given in chart.renderTo.
        /// </summary>
        public object container { get; set; }
        //TODO: must check

        /// <summary>
        /// Removes the chart and purges memory.
        /// This method should be called beforewriting a new chart into the same container. It is called internally on window unloadto prevent leaks.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Exporting module required. Submit an SVG version of the chart to a serveralong with some parameters for conversion.
        /// </summary>
        /// <param name="options">Exporting options. Out of the exportingoptions,
        /// the following options can be given as parameters to the exportChart method.All options default to the values given in the exporting config
        /// optins.filename: the filename for the export without extension,
        /// url: the URL for the server module to do the conversion,
        /// width: the width of the PNG or JPEG image generated on the server,
        /// type: the MIME type of the converted image.</param>
        /// <param name="chartOptions">Additional chart options for the exported chart. For example a different background color can be added here.</param>
        /// <returns>null</returns>
        public object exportChart(ExportingOptions options, ChartOptions chartOptions) { return null; }
        //TODO: return null?
        /// <summary>
        /// Exporting module required. Submit an SVG version of the chart to a serveralong with some parameters for conversion.
        /// </summary>
        /// <param name="options">Exporting options. Out of the exportingoptions,
        /// the following options can be given as parameters to the exportChart method.All options default to the values given in the exporting config
        /// optins.filename: the filename for the export without extension,
        /// url: the URL for the server module to do the conversion,
        /// width: the width of the PNG or JPEG image generated on the server,
        /// type: the MIME type of the converted image.</param>
        /// <returns>null</returns>
        public object exportChart(ExportingOptions options) { return null; }
        //TODO: return null?
        /// <summary>
        /// Exporting module required. Submit an SVG version of the chart to a serveralong with some parameters for conversion.
        /// </summary>
        /// <returns>null</returns>
        public object exportChart() { return null; }
        //TODO: return null?

        /// <summary>
        /// Get an axis, series or point by its id as given in the configuration options.
        /// </summary>
        /// <param name="id">The id of the axis, series or point to get.</param>
        /// <returns></returns>
        [JsMethod(Name = "get")]
        public Axis getAxis(JsString id) { return null; }
        /// <summary>
        /// Get an axis, series or point by its id as given in the configuration options.
        /// </summary>
        /// <param name="id">The id of the axis, series or point to get.</param>
        /// <returns></returns>
        [JsMethod(Name = "get")]
        public Series getSeries(JsString id) { return null; }
        /// <summary>
        /// Get an axis, series or point by its id as given in the configuration options.
        /// </summary>
        /// <param name="id">The id of the axis, series or point to get.</param>
        /// <returns></returns>
        [JsMethod(Name = "get")]
        public Point getPoint(JsString id) { return null; }
        //TODO: must check.

        /// <summary>
        /// Exporting module required. Get an SVG string representing the chart.
        /// </summary>
        /// <param name="additionalOptions">Chart options to add to the exported chart in addition to the options given forthe original chart.
        /// For example if series.lineWidth should be greater in the exported chart than in the original,
        /// or the chart should have a different background color, this is added here.</param>
        /// <returns></returns>
        public JsString getSVG(ChartOptions additionalOptions) { return null; }
        /// <summary>
        /// Exporting module required. Get an SVG string representing the chart.
        /// </summary>
        /// <returns></returns>
        public JsString getSVG() { return null; }

        /// <summary>
        /// Returns an array of all currently selected points in the chart. Points can be selected either programmatically by the point.select() method or by clicking.
        /// </summary>
        /// <returns>An array of the selected points.</returns>
        public JsArray<Point> getSelectedPoints() { return null; }
        //TODO: must check

        /// <summary>
        /// Returns an array of all currently selected series in the chart.
        /// Series can be selected either programmatically by the series.select() method or by checking the checkboxnext to the legend item if series.showCheckBox is true.
        /// </summary>
        /// <returns></returns>
        public JsArray<Series> getSelectedSeries() { return null; }

        /// <summary>
        /// Hide the loading screen. Options for the loadingscreen are defined at options.loading.
        /// </summary>
        /// <returns></returns>
        public object hideLoading() { return null; }
        //TODO: check, return null

        /// <summary>
        /// The options stucture for the chart.
        /// </summary>
        public ChartOptions options { get; set; }
        //TODO: check

        /// <summary>
        /// Redraw the chart after changes have been done to the data or axis extremes.
        /// All methodsfor updating axes, series or points have a parameter for redrawing the chart. This istrue by default.
        /// But in many cases you want to do more than one operationon the chart before redrawing, for example add a number of points.
        /// In those cases it isa waste of resources to redraw the chart for each new point added. So you add the pointsand call chart.redraw() after.
        /// </summary>
        /// <returns></returns>
        public object redraw() { return null; }
        //TODO: return null

        /// <summary>
        /// An array of all the chart's series.
        /// </summary>
        public JsArray<Series> series { get; set; }

        /// <summary>
        /// Resize the chart to a given width and height.
        /// </summary>
        /// <param name="width">The new pixel width of the chart.</param>
        /// <param name="height">The new pixel height of the chart.</param>
        /// <param name="animation">Defaults to true. When true, the resize will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void setSize(JsNumber width, JsNumber height, bool animation) { }
        /// <summary>
        /// Resize the chart to a given width and height.
        /// </summary>
        /// <param name="width">The new pixel width of the chart.</param>
        /// <param name="height">The new pixel height of the chart.</param>
        /// <param name="animation">Defaults to true. When true, the resize will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void setSize(JsNumber width, JsNumber height, AnimationOptions animation) { }
        /// <summary>
        /// Resize the chart to a given width and height.
        /// </summary>
        /// <param name="width">The new pixel width of the chart.</param>
        /// <param name="height">The new pixel height of the chart.</param>
        public void setSize(JsNumber width, JsNumber height) { }

        /// <summary>
        /// Set a new title or subtitle for the chart
        /// </summary>
        /// <param name="title">A configuration object for the new title as defined at #title.</param>
        /// <param name="subtitle">A configuration object for the new subtitle as defined at #subtitle.</param>
        public void setTitle(TitleOptions title, SubtitleOptions subtitle) { }

        /// <summary>
        /// Dim the chart's plot area and show a loading label text.
        /// Options for the loadingscreen are defined at options.loading. A customtext can be given as a parameter for loadind
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public object showLoading(JsString str) { return null; }
        //TODO: return null

        /// <summary>
        /// This method is deprecated as of 2.0.1. Updating the chart position after a move operation is no longer necessary.
        /// </summary>
        /// <returns></returns>
        public object updatePosition() { return null; }
        //TODO: return null
    }

    /// <summary>
    /// A chart can have from 0 axes (pie chart) to multiples. In a normal, single seriescartesian chart, there is one X axis and one Y axis.
    /// The X axis or axes are referencedby chart.xAxis, which is an array of Axis objects.
    /// If there is only oneaxis, it can be referenced through chart.xAxis[0], and multiple axes haveincreasing indices. The same pattern goes for Y axes.
    /// If you need to get the axes from a series object, use the series.xAxis andseries.yAxis properties.
    /// These are not arrays, as one series can only be associateddto one X and one Y axis.
    /// A third way to reference the axis programmatically is by id. Add an id in the axis configuration options, and get the axis by chart.get(id).
    /// Configuration options for the axes are given in options.xAxis and options.yAxis.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts.Axis", Export = false)]
    public class Axis
    {
        /// <summary>
        /// Add a plot band after render time.
        /// </summary>
        /// <param name="options">A configuration object consisting of the same members as options.xAxis.plotBands</param>
        public void addPlotBand(AxisPlotBandsOptions options) { }

        /// <summary>
        /// Add a plot line after render time.
        /// </summary>
        /// <param name="options">A configuration object consisting of the same members as options.xAxis.plotLines</param>
        public void addPlotLine(AxisPlotLinesOptions options) { }

        /// <summary>
        /// Get the current extremes for the axis.
        /// </summary>
        /// <param name="dataMax">The maximum value of the axis' associated series.</param>
        /// <param name="dataMin">The minimum value of the axis' associated series.</param>
        /// <param name="max">The maximum axis value, either automatic or set manually. If the max option is not set and maxPadding is0, this value will be the same as dataMax.</param>
        /// <param name="min">The minimum axis value, either automatic or set manually. If the min option is not set and minPadding is0, this value will be the same as dataMin.</param>
        /// <returns></returns>
        public object getExtremes(object dataMax, object dataMin, object max, object min) { return null; }
        //TODO: DANEL MUST CHECK

        /// <summary>
        /// Remove a plot band by its id.
        /// </summary>
        /// <param name="id">The plot band's id as given in the original configuration object orin the addPlotBand method.</param>
        public void removePlotBand(JsString id) { }

        /// <summary>
        /// Remove a plot line by its id.
        /// </summary>
        /// <param name="id">The plot line's id as given in the original configuration object orin the addPlotLine method.</param>
        public void removePlotLine(JsString id) { }

        /// <summary>
        /// Set new categories for the axis.
        /// </summary>
        /// <param name="cateories">The new category names.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the axis or wait for an explicit call to chart.redraw().</param>
        public void setCategories(JsArray cateories, bool redraw) { }
        /// <summary>
        /// Set new categories for the axis.
        /// </summary>
        /// <param name="cateories">The new category names.</param>
        public void setCategories(JsArray cateories) { }

        /// <summary>
        /// Set the minimum and maximum of the axes after render time.
        /// If the startOnTick and endOnTick options are true,the minimum and maximum values are rounded off to the nearest tick.
        /// To preventthis, these options can be set to false before calling setExtremes.
        /// </summary>
        /// <param name="min">The new minimum value</param>
        /// <param name="max">The new maximum value</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart or wait for an explicit call to chart.redraw().</param>
        /// <param name="animation">Defaults to true. When true, the resize will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void setExtremes(JsNumber min, JsNumber max, bool redraw, bool animation) { }
        /// <summary>
        /// Set the minimum and maximum of the axes after render time.
        /// If the startOnTick and endOnTick options are true,the minimum and maximum values are rounded off to the nearest tick.
        /// To preventthis, these options can be set to false before calling setExtremes.
        /// </summary>
        /// <param name="min">The new minimum value</param>
        /// <param name="max">The new maximum value</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart or wait for an explicit call to chart.redraw().</param>
        /// <param name="animation">Defaults to true. When true, the resize will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void setExtremes(JsNumber min, JsNumber max, bool redraw, AnimationOptions animation) { }
        /// <summary>
        /// Set the minimum and maximum of the axes after render time.
        /// If the startOnTick and endOnTick options are true,the minimum and maximum values are rounded off to the nearest tick.
        /// To preventthis, these options can be set to false before calling setExtremes.
        /// </summary>
        /// <param name="min">The new minimum value</param>
        /// <param name="max">The new maximum value</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart or wait for an explicit call to chart.redraw().</param>
        public void setExtremes(JsNumber min, JsNumber max, bool redraw) { }
        /// <summary>
        /// Set the minimum and maximum of the axes after render time.
        /// If the startOnTick and endOnTick options are true,the minimum and maximum values are rounded off to the nearest tick.
        /// To preventthis, these options can be set to false before calling setExtremes.
        /// </summary>
        /// <param name="min">The new minimum value</param>
        /// <param name="max">The new maximum value</param>
        public void setExtremes(JsNumber min, JsNumber max) { }

        /// <summary>
        /// Update the title of the axis after render time.
        /// </summary>
        /// <param name="title">The new title options on the same format as given in xAxis.title.</param>
        /// <param name="redraw">Whether to redraw the chart now or hold until the next chart.redraw()</param>
        public void setTitle(AxisTitleOptions title, bool redraw) { }
        /// <summary>
        /// Update the title of the axis after render time.
        /// </summary>
        /// <param name="title">The new title options on the same format as given in xAxis.title.</param>
        public void setTitle(AxisTitleOptions title) { }

    }

    /// <summary>
    /// The Element class is a JavaScript wrapper for SVG elements used in the rendering layer of Highchart.
    /// Combinedwith the Renderer object, these elements allows freeform annotation in the charts or even in your HTML pages without creating a chart at all.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts.Element", Export = false)]
    public class Element
    {
        /// <summary>
        /// Add the element to the renderer canvas.
        /// </summary>
        /// <param name="parent">The element can be added to a g (group) element.</param>
        /// <returns>Element</returns>
        public HtmlElement add(object parent) { return null; }
        /// <summary>
        /// Add the element to the renderer canvas.
        /// </summary>
        /// <returns>Element</returns>
        public HtmlElement add() { return null; }

        /// <summary>
        /// Apply attributes to the SVG/VML elements. These attributes for the most parts correspondto SVG, but some are specific to Highcharts, like zIndex and rotationfor text.
        /// </summary>
        /// <param name="hash">A set of attributes to apply.</param>
        /// <returns>Element</returns>
        public HtmlElement attr(object hash) { return null; }

        /// <summary>
        /// Apply some CSS properties to the element
        /// </summary>
        /// <param name="hash">The object literal of CSS properties to apply. Properties should be hyphenated, not camelCased.</param>
        /// <returns>Element</returns>
        public HtmlElement css(object hash) { return null; }

        /// <summary>
        /// Destroy the element and free up memory
        /// </summary>
        public object destroy { get; set; }

        /// <summary>
        /// Get the bounding box of the element
        /// </summary>
        /// <param name="hash">A hash object containing x, y, width and height values for the element.</param>
        /// <returns>Element</returns>
        public HtmlElement getBBox(object hash) { return null; }
        /// <summary>
        /// Get the bounding box of the element
        /// </summary>
        /// <returns>Element</returns>
        public HtmlElement getBBox() { return null; }

        /// <summary>
        /// Apply an event handler to the element
        /// </summary>
        /// <param name="eventType">The event type to attach, for example 'click', 'mouseover', 'touch'.</param>
        /// <param name="handler">The event handler function.</param>
        /// <returns>Element</returns>
        public HtmlElement on(JsString eventType, JsAction handler) { return null; }

        /// <summary>
        /// Bring the element to the front. Alternatively, a zIndex attribute can be given.
        /// </summary>
        /// <param name="e">The element object</param>
        /// <returns>Element</returns>
        public HtmlElement toFront(HtmlElement e) { return null; }
    }

    /// <summary>
    /// The Series object is the JavaScript representation of each line, area series, pie etc.
    /// The object can be accessed in a number of ways.
    /// All series and point event handlersgive a reference to the series object.
    /// The chart object has a seriesproperty that is a collection of all the chart's series.
    /// The point objectsalso have the same reference.
    /// Another way to reference the series programmatically is by id.
    /// Add an id in the series configuration options, and get the series object by chart.get(id).
    /// Configuration options for the series are given in three levels.
    /// Optionsfor all series in a chart are given in the plotOptions.series object.
    /// Then options for all seriesof a specific type are given in the plotOptions of that type,
    /// for example plotOptions.line.Next, options for one single series are given in the series array.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts.Series", Export = false)]
    public class Series
    {
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        /// <param name="animation">Defaults to true. When true, the graph will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void addPoint(JsArray options, bool redraw, bool shift, bool animation) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        /// <param name="animation">Defaults to true. When true, the graph will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void addPoint(JsArray options, bool redraw, bool shift, AnimationOptions animation) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        public void addPoint(JsArray options, bool redraw, bool shift) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        public void addPoint(JsArray options, bool redraw) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        public void addPoint(JsArray options) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        /// <param name="animation">Defaults to true. When true, the graph will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void addPoint(PointOptions options, bool redraw, bool shift, bool animation) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        /// <param name="animation">Defaults to true. When true, the graph will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void addPoint(PointOptions options, bool redraw, bool shift, AnimationOptions animation) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        public void addPoint(PointOptions options, bool redraw, bool shift) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        public void addPoint(PointOptions options, bool redraw) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        public void addPoint(PointOptions options) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        /// <param name="animation">Defaults to true. When true, the graph will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void addPoint(JsNumber options, bool redraw, bool shift, bool animation) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        /// <param name="animation">Defaults to true. When true, the graph will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void addPoint(JsNumber options, bool redraw, bool shift, AnimationOptions animation) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        /// <param name="shift">Defaults to false. When shift is true, one point is shifted off the start of the series as one is appended to the end.
        /// Use this option for live charts monitoring a value over time.</param>
        public void addPoint(JsNumber options, bool redraw, bool shift) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is added.
        /// When adding more thanone point, it is highly recommended that the redraw option beset to false,
        /// and instead chart.redraw() is explicitly calledafter the adding of points is finished.</param>
        public void addPoint(JsNumber options, bool redraw) { }
        /// <summary>
        /// Add a point to the series after render time.
        /// </summary>
        /// <param name="options">The point options. If options isa single number,
        /// a point with that y value is appended to the series.If it is an array, it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        public void addPoint(JsNumber options) { }

        /// <summary>
        /// Read only. The chart that the series belongs to.
        /// </summary>
        public Chart chart { get; set; }

        /// <summary>
        /// Read only. An array with the series' data point objects.
        /// </summary>
        public JsArray data { get; set; }

        /// <summary>
        /// Hides the series if visible. If the chart.ignoreHiddenSeries option is true,the chart is redrawn without this series.
        /// </summary>
        public void hide() { }

        /// <summary>
        /// The series' name as given in the options.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// Read only. The series' options.
        /// </summary>
        public SeriesOptions options { get; set; }

        /// <summary>
        /// Remove the series from the chart.
        /// </summary>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is removed.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        public void remove(bool redraw) { }
        /// <summary>
        /// Remove the series from the chart.
        /// </summary>
        public void remove() { }

        /// <summary>
        /// Select or unselect the series. This means its selected property is set,the checkbox in the legend is toggled and when selected,
        /// the series is returned in the chart.getSelectedSeries() method.
        /// </summary>
        /// <param name="selected">When true, the series is selected. When false it is unselected.When null or undefined, the series' selection state is toggled.</param>
        public void select(bool selected) { }

        /// <summary>
        /// Read only. The series' selected state as set by series.select().
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// Apply a new set of data to the series and optionally redraw it.
        /// </summary>
        /// <param name="data">Takes an array of data in the same format as given at options.series => data.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is altered.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        public void setData(JsArray<JsNumber> data, bool redraw) { }
        /// <summary>
        /// Apply a new set of data to the series and optionally redraw it.
        /// </summary>
        /// <param name="data">Takes an array of data in the same format as given at options.series => data.</param>
        public void setData(JsArray<JsNumber> data) { }
        /// <summary>
        /// Apply a new set of data to the series and optionally redraw it.
        /// </summary>
        /// <param name="data">Takes an array of data in the same format as given at options.series => data.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is altered.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        public void setData(JsArray<JsArray> data, bool redraw) { }
        /// <summary>
        /// Apply a new set of data to the series and optionally redraw it.
        /// </summary>
        /// <param name="data">Takes an array of data in the same format as given at options.series => data.</param>
        public void setData(JsArray<JsArray> data) { }
        /// <summary>
        /// Apply a new set of data to the series and optionally redraw it.
        /// </summary>
        /// <param name="data">Takes an array of data in the same format as given at options.series => data.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the series is altered.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        public void setData(JsArray<object> data, bool redraw) { }
        /// <summary>
        /// Apply a new set of data to the series and optionally redraw it.
        /// </summary>
        /// <param name="data">Takes an array of data in the same format as given at options.series => data.</param>
        public void setData(JsArray<object> data) { }

        /// <summary>
        /// Shows the series if hidden.
        /// </summary>
        public void show() { }

        /// <summary>
        /// Read only. The series' type, like "line", "area" etc.
        /// </summary>
        public JsString type { get; set; }

        /// <summary>
        /// Read only. The series' visibility state as set by series.show(), series.hide(), or the initial configuration.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Read only. The unique xAxis object associated with the series.
        /// </summary>
        public Axis xAxis { get; set; }

        /// <summary>
        /// Read only. The unique yAxis object associated with the series.
        /// </summary>
        public Axis yAxis { get; set; }
    }

    /// <summary>
    /// The Point object is the JavaScript representation of each data point
    /// The object can be accessed in a number of ways. In all point event handlers the point object is this.
    /// In the series object all the pointsare accessed by the series.data array.
    /// Another way to reference the point programmatically is by id.
    /// Add an id in the point configuration options, and get the point object by chart.get(id).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts.Point", Export = false)]
    public class Point
    {
        /// <summary>
        /// For categorized axes this property holds the category name for the point. For otheraxis it holds the x value.
        /// </summary>
        [JsProperty(Name = "category")]
        public JsString categoryString { get; set; }
        /// <summary>
        /// For categorized axes this property holds the category name for the point. For otheraxis it holds the x value.
        /// </summary>
        public JsNumber category { get; set; }

        /// <summary>
        /// The percentage for points in a stacked series or pies.
        /// </summary>
        public JsNumber percentage { get; set; }

        /// <summary>
        /// Remove the point from the series.
        /// </summary>
        /// <param name="redraw">Defaults to true.
        /// Whether to redraw the chart after the point is removed.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        /// <param name="animation">Defaults to true. When true, the graph's updating will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void remove(bool redraw, bool animation) { }
        /// <summary>
        /// Remove the point from the series.
        /// </summary>
        /// <param name="redraw">Defaults to true.
        /// Whether to redraw the chart after the point is removed.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        /// <param name="animation">Defaults to true. When true, the graph's updating will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void remove(bool redraw, AnimationOptions animation) { }
        /// <summary>
        /// Remove the point from the series.
        /// </summary>
        /// <param name="redraw">Defaults to true.
        /// Whether to redraw the chart after the point is removed.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        public void remove(bool redraw) { }
        /// <summary>
        /// Remove the point from the series.
        /// </summary>
        public void remove() { }

        /// <summary>
        /// Select or unselect the point.
        /// </summary>
        /// <param name="select">When true, the point is selected.
        /// When false, the point is unselected. When null or undefined, the selectionstate is toggled.</param>
        /// <param name="accumulate">When true, the selection is added to other selected points. When false, other selected points are deselected.
        /// Internally in Highcharts,selected points are accumulated on Control, Shift or Cmd clicking the point.</param>
        public void select(bool select, bool accumulate) { }
        /// <summary>
        /// Select or unselect the point.
        /// </summary>
        /// <param name="select">When true, the point is selected.
        /// When false, the point is unselected. When null or undefined, the selectionstate is toggled.</param>
        public void select(bool select) { }
        /// <summary>
        /// Select or unselect the point.
        /// </summary>
        public void select() { }

        /// <summary>
        /// Whether the point is selected or not.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The series object associated with the point.
        /// </summary>
        public Series series { get; set; }

        /// <summary>
        /// Update the point with new values.
        /// </summary>
        /// <param name="options">The point options. If options isa single number, the point will be given that number as the y value.If it is an array,
        /// it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is updated.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        /// <param name="animation">Defaults to true. When true, the update will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void slice(object options, bool redraw, bool animation) { }
        /// <summary>
        /// Update the point with new values.
        /// </summary>
        /// <param name="options">The point options. If options isa single number, the point will be given that number as the y value.If it is an array,
        /// it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is updated.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        /// <param name="animation">Defaults to true. When true, the update will be animated with default animationoptions.
        /// The animation can also be a configuration object with properties durationand easing.</param>
        public void slice(object options, bool redraw, AnimationOptions animation) { }
        /// <summary>
        /// Update the point with new values.
        /// </summary>
        /// <param name="options">The point options. If options isa single number, the point will be given that number as the y value.If it is an array,
        /// it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        /// <param name="redraw">Defaults to true. Whether to redraw the chart after the point is updated.If doing more operations on the chart,
        /// it is a good idea to set redraw to falseand call chart.redraw() after.</param>
        public void slice(object options, bool redraw) { }
        /// <summary>
        /// Update the point with new values.
        /// </summary>
        /// <param name="options">The point options. If options isa single number, the point will be given that number as the y value.If it is an array,
        /// it will be interpreted as x and y values respectively.
        /// If it is an object, advanced options as outlined under options.point are applied.</param>
        public void slice(object options) { }
        /// <summary>
        /// Update the point with new values.
        /// </summary>
        public void slice() { }

        /// <summary>
        /// The x value for the point.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y value for the point.
        /// </summary>
        public JsNumber y { get; set; }
    }

    /// <summary>
    /// Allows direct access to the Highcharts rendering layer in order to draw primitive shapes like circles, rectangles,paths or text directly on a chart,
    /// or independent from any chart. The Renderer represents a wrapper object for SVGin modern browsers and VML in IE &lt; 8.
    /// An existing chart's renderer can be accessed through chart.renderer. To create a renderer independentfrom a chart,
    /// use var renderer = new Highcharts.Renderer(parentNode, width, height); where parentNodeis the HTML element where you want to add it.
    /// The Renderer's methods are chained whereever possible, so you can initiate an element then call for example attrand css and add on that element in one statement.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "Highcharts.Renderer", Export = false)]
    public class Renderer
    {
        /// <summary>
        /// An existing chart's renderer can be accessed through chart.renderer. To create a renderer independentfrom a chart,
        /// use var renderer = new Highcharts.Renderer(parentNode, width, height); where parentNodeis the HTML element where you want to add it.
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Renderer(HtmlElement parentNode, JsNumber width, JsNumber height) { }

        /// <summary>
        /// Draw an arc on the renderer canvas.
        /// </summary>
        /// <param name="centerX">The x position of the arc's center in the SVG element.</param>
        /// <param name="centerY">The y position of the arc's center in the SVG element.</param>
        /// <param name="outerRadius">The outer radius of the arc.</param>
        /// <param name="innerRadius">The inner radius of the arc.</param>
        /// <param name="start">The starting angle of the arc in radians, where 0 is to the right and -Math.PI/2 is up.</param>
        /// <param name="end">The ending angle of the arc in radians, where 0 is to the right and -Math.PI/2 is up.</param>
        /// <returns>Element</returns>
        public HtmlElement arc(JsNumber centerX, JsNumber centerY, JsNumber outerRadius, JsNumber innerRadius, JsNumber start, JsNumber end) { return null; }

        /// <summary>
        /// Draw circle on the renderer canvas.
        /// </summary>
        /// <param name="centerX">The x position of the circle's center in the SVG element.</param>
        /// <param name="centerY">The y position of the circle's center in the SVG element.</param>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>Element</returns>
        public HtmlElement circle(JsNumber centerX, JsNumber centerY, JsNumber radius) { return null; }

        /// <summary>
        /// Add an SVG/VML group.
        /// </summary>
        /// <param name="name">The name of the group. This will be used in the class name, which will be "highcharts-"+ name.
        /// Other Element objects are added to the group by using the group as the first parameter in .add() for thewrappers.</param>
        /// <returns>Element</returns>
        public HtmlElement g(JsString name) { return null; }

        /// <summary>
        /// Add an image from an external resource.
        /// </summary>
        /// <param name="source">The URL of the image.</param>
        /// <param name="x">The x position of the image's upper left corner.</param>
        /// <param name="y">The y position of the image's upper left corner.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        /// <returns></returns>
        public HtmlElement image(JsString source, JsNumber x, JsNumber y, JsNumber width, JsNumber height) { return null; }

        /// <summary>
        /// Add a path based on SVG's path commands.
        /// In SVGcapable browsers all path commands are supported, but in VML only a subset is supported, most notably moveTo, lineTo and curve commands.
        /// </summary>
        /// <param name="path">An SVG path split up in array form.</param>
        /// <returns>Element</returns>
        public HtmlElement path(JsArray path) { return null; }

        /// <summary>
        /// Add a rectangle.
        /// </summary>
        /// <param name="x">The x position of the rectangle's upper left corner.</param>
        /// <param name="y">The y position of the rectangle's upper left corner.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="cornerRadius">The corner radius of all the rectangle's corners.</param>
        /// <returns>Element</returns>
        public HtmlElement rect(JsNumber x, JsNumber y, JsNumber width, JsNumber height, JsNumber cornerRadius) { return null; }

        /// <summary>
        /// Draw text. The text can contain a subset of HTML, like spans and anchors and some basic text stylingof these.
        /// </summary>
        /// <param name="str">The text or HTML to draw</param>
        /// <param name="x">The x position of the text's lower left corner.</param>
        /// <param name="y">The y position of the text's lower left corner.</param>
        /// <returns></returns>
        public HtmlElement text(JsString str, JsNumber x, JsNumber y) { return null; }
    }

    [JsType(JsMode.Json)]
    public class ChartConfiguration
    {
        /// <summary>
        /// Options regarding the chart area and plot area as well as general chart options.
        /// </summary>
        public ChartOptions chart { get; set; }

        /// <summary>
        ///An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:
        /// colors: [
        /// 	'#4572A7', 
        /// 	'#AA4643', 
        /// 	'#89A54E', 
        /// 	'#80699B', 
        /// 	'#3D96AE', 
        /// 	'#DB843D', 
        /// 	'#92A8CD', 
        /// 	'#A47D7C', 
        /// 	'#B5CA92'
        /// ]
        /// </summary>
        public JsArray<JsString> colors { get; set; }

        /// <summary>
        /// Highchart by default puts a credits label in the lower right corner of the chart. This can be changed using these options.
        /// </summary>
        public CreditsOptions credits { get; set; }

        /// <summary>
        /// Options for the exporting module.
        /// </summary>
        public ExportingOptions exporting { get; set; }

        /// <summary>
        /// Global options that don't apply to each chart. These options, like the lang options, must be set using the Highcharts.setOptions method.
        /// Highcharts.setOptions({
        /// 	global: {
        /// 		useUTC: false
        /// 	}
        /// });
        /// </summary>
        public GlobalOptions global { get; set; }

        /// <summary>
        /// HTML labels that can be positioined anywhere in the chart area.
        /// </summary>
        public LabelsOptions labels { get; set; }

        /// <summary>
        /// Language object. The language object is global and it can't be set on each chart initiation. Instead, use Highcharts.setOptions to set it before any chart is initiated.
        /// Highcharts.setOptions({
        /// 	lang: {
        /// 		months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 
        /// 			'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
        /// 		weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']
        /// 	}
        /// });
        /// </summary>
        public LangOptions lang { get; set; }

        /// <summary>
        /// The legend is a box containing a symbol and name for each series item or point item in the chart.
        /// </summary>
        public LegendOptions legend { get; set; }

        /// <summary>
        /// The loading options control the appearance of the loading screen that covers the plot area on chart operations.
        /// This screen only appears after an explicit call to chart.showLoading().
        /// It is a utility for developers to communicate to the end user that something is going on, for example while retrieving new data via an XHR connection.
        /// The "Loading..." text itself is not part of this configuration object, but part of the lang object.
        /// </summary>
        public LoadingOptions loading { get; set; }

        /// <summary>
        /// A collection of options for buttons and menus appearing in the exporting module.
        /// </summary>
        public NavigationOptions navigation { get; set; }

        /// <summary>
        /// Applies only to polar charts and angular gauges.
        /// This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index.
        /// </summary>
        public PaneOptions pane { get; set; }

        /// <summary>
        /// The plotOptions is a wrapper object for config objects for each series type.
        /// The config objects for each series can also be overridden for each series item as given in the series array.
        /// Configuration options for the series are given in three levels. Options for all series in a chart are given in the plotOptions.series object.
        /// Then options for all series of a specific type are given in the plotOptions of that type, for example plotOptions.line.
        /// Next, options for one single series are given in the series array.
        /// </summary>
        public PlotOptions plotOptions { get; set; }

        /// <summary>
        /// The actual series to append to the chart.
        /// In addition to the members listed below, any member of the plotOptions for that specific type of plot can be added to a series individually.
        /// For example, even though a general lineWidth is specified in plotOptions.series, an individual lineWidth can be specified for each series.
        /// </summary>
        public JsArray<SeriesOptions> series { get; set; }

        /// <summary>
        /// The chart's subtitle
        /// </summary>
        public SubtitleOptions subtitle { get; set; }

        /// <summary>
        /// The chart's main title.
        /// </summary>
        public TitleOptions title { get; set; }

        /// <summary>
        /// Options for the tooltip that appears when the user hovers over a series or point.
        /// </summary>
        public TooltipOptions tooltip { get; set; }

        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
        /// In case of multiple axes, the xAxis node is an array of configuration objects.
        /// See the Axis object for programmatic access to the axis.
        /// </summary>
        public XAxisOptions xAxis { get; set; }
        /// <summary>
        /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
        /// In case of multiple axes, the xAxis node is an array of configuration objects.
        /// See the Axis object for programmatic access to the axis.
        /// </summary>
        [JsProperty(Name = "xAxis")]
        public JsArray<XAxisOptions> xAxisArray { get; set; }

        /// <summary>
        /// The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis.
        /// In case of multiple axes, the yAxis node is an array of configuration objects.
        /// See the Axis object for programmatic access to the axis.
        /// </summary>
        public XAxisOptions yAxis { get; set; }
        /// <summary>
        /// The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis.
        /// In case of multiple axes, the yAxis node is an array of configuration objects.
        /// See the Axis object for programmatic access to the axis.
        /// </summary>
        [JsProperty(Name = "yAxis")]
        public JsArray<XAxisOptions> yAxisArray { get; set; }

    }

    #region chart

    /// <summary>
    /// Options regarding the chart area and plot area as well as general chart options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ChartOptions
    {
        /// <summary>
        /// When using multiple axis, the ticks of two or more opposite axes will automatically be aligned by adding ticks to the axis or axes with the least ticks.
        /// This can be prevented by setting alignTicks to false.
        /// If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting gridLineWidth to 0. Defaults to true.
        /// </summary>
        public bool alignTicks { get; set; }

        /// <summary>
        /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see plotOptions.series => animation.
        /// The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
        /// duration
        /// The duration of the animation in milliseconds.
        /// easing
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.
        /// . Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see plotOptions.series => animation.
        /// The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
        /// duration
        /// The duration of the animation in milliseconds.
        /// easing
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.
        /// . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see plotOptions.series => animation.
        /// The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
        /// duration
        /// The duration of the animation in milliseconds.
        /// easing
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.
        /// . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The background color or gradient for the outer chart area. Defaults to "#FFFFFF".
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The color of the outer chart border. The border is painted using vector graphic techniques to allow rounded corners. Defaults to "#4572A7".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The corner radius of the outer chart border. Defaults to 5.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The pixel width of the outer chart border. The border is painted using vector graphic techniques to allow rounded corners. Defaults to 0.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// A CSS class name to apply to the charts container div, allowing unique CSS styling for each chart. Defaults to "".
        /// </summary>
        public JsString className { get; set; }

        /// <summary>
        /// Alias of type.
        /// </summary>
        public JsString defaultSeriesType { get; set; }

        /// <summary>
        /// Event listeners for the chart.
        /// </summary>
        public ChartEvent events { get; set; }

        /// <summary>
        /// An explicit height for the chart. By default the height is calculated from the offset height of the containing element. Defaults to null.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// If true, the axes will scale to the remaining visible series once one series is hidden.
        /// If false, hiding and showing a series will not affect the axes or the other series. For stacks,
        /// once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected. Defaults to true.
        /// </summary>
        public bool ignoreHiddenSeries { get; set; }

        /// <summary>
        /// Whether to invert the axes so that the x axis is horizontal and y axis is vertical.
        /// When true, the x axis is reversed by default. If a bar plot is present in the chart, it will be inverted automatically. Defaults to false.
        /// </summary>
        public bool inverted { get; set; }

        /// <summary>
        /// The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively.
        /// Use the options marginTop, marginRight, marginBottom and marginLeft for shorthand setting of one option.
        /// Since version 2.1, the margin is 0 by default.
        /// The actual space is dynamically calculated from the offset of axis labels, axis title, title, subtitle and legend in addition to the spacingTop, spacingRight, spacingBottom and spacingLeft options.
        /// Defaults to [null]. Defaults to [null].
        /// </summary>
        public JsArray margin { get; set; }

        /// <summary>
        /// The margin between the bottom outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingBottom. Defaults to 70.
        /// </summary>
        public JsNumber marginBottom { get; set; }

        /// <summary>
        /// The margin between the left outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingLeft. Defaults to 80.
        /// </summary>
        public JsNumber marginLeft { get; set; }

        /// <summary>
        /// The margin between the right outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingRight. Defaults to 50.
        /// </summary>
        public JsNumber marginRight { get; set; }

        /// <summary>
        /// The margin between the top outer edge of the chart and the plot area.
        /// Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingTop. Defaults to null.
        /// </summary>
        public JsNumber marginTop { get; set; }

        /// <summary>
        /// The background color or gradient for the plot area. Defaults to null.
        /// </summary>
        public JsString plotBackgroundColor { get; set; }

        /// <summary>
        /// The URL for an image to use as the plot background.
        /// To set an image as the background for the entire chart, set a CSS background image to the container element. Defaults to null.
        /// </summary>
        public JsString plotBackgroundImage { get; set; }

        /// <summary>
        /// The color of the inner chart or plot area border. Defaults to "#C0C0C0".
        /// </summary>
        public JsString plotBorderColor { get; set; }

        /// <summary>
        /// The pixel width of the plot area border. Defaults to 0.
        /// </summary>
        public JsNumber plotBorderWidth { get; set; }

        /// <summary>
        /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions plotShadow { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "plotShadow")]
        public bool plotShadowBoolean { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "plotShadow")]
        public object plotShadowObject { get; set; }

        /// <summary>
        /// When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires highcharts-more.js.
        /// </summary>
        public bool polar { get; set; }

        /// <summary>
        /// Whether to reflow the chart to fit the width of the container div on resizing the window. Defaults to true.
        /// </summary>
        public bool reflow { get; set; }

        /// <summary>
        /// The HTML element where the chart will be rendered.
        /// If it is a string, the element by that id is used. The HTML element can also be passed by direct reference. Defaults to null.
        /// </summary>
        public JsString renderTo { get; set; }
        /// <summary>
        /// The HTML element where the chart will be rendered.
        /// If it is a string, the element by that id is used. The HTML element can also be passed by direct reference. Defaults to null.
        /// </summary>
        [JsProperty(Name = "renderTo")]
        public object renderToObject { get; set; }

        /// <summary>
        /// The button that appears after a selection zoom, allowing the user to reset zoom.
        /// </summary>
        public ResetZoomButton resetZoomButton { get; set; }

        /// <summary>
        /// The background color of the marker square when selecting (zooming in on) an area of the chart. Defaults to rgba(69,114,167,0.25). Defaults to rgba(69114,167,0.25),.
        /// </summary>
        public JsString selectionMarkerFill { get; set; }

        /// <summary>
        /// Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }

        /// <summary>
        /// Whether to show the axes initially.
        /// This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series. Defaults to false.
        /// </summary>
        public bool showAxes { get; set; }

        /// <summary>
        /// The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingBottom { get; set; }

        /// <summary>
        /// The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingLeft { get; set; }

        /// <summary>
        /// The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingRight { get; set; }

        /// <summary>
        /// The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).
        /// . Defaults to 10.
        /// </summary>
        public JsNumber spacingTop { get; set; }


        /// <summary>
        /// Additional CSS styles to apply inline to the container div. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart options and must be set globally. Defaults to:
        /// style: {
        /// 	fontFamily: '"Lucida Grande", "Lucida Sans Unicode", Verdana, Arial, Helvetica, sans-serif', // default font
        /// 	fontSize: '12px'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The default series type for the chart. Can be one of line, spline, area, areaspline, column, bar, pie and scatter.
        /// From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component. Defaults to "line".
        /// </summary>
        public TypeOptions type { get; set; }


        /// <summary>
        /// An explicit width for the chart. By default the width is calculated from the offset width of the containing element. Defaults to null.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// Decides in what dimentions the user can zoom by dragging the mouse. Can be one of x, y or xy. Defaults to "".
        /// </summary>
        public ZoomType zoomType { get; set; }

    }

    /// <summary>
    /// Event listeners for the chart.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ChartEvent
    {
        /// <summary>
        /// Fires when a series is added to the chart after load time, using the addSeries method. The this keyword refers to the chart object itself
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// Through event.options you can access the series options that was passed to the addSeries method. Returning false prevents the series from being added.
        /// </summary>
        public JsAction<object> addSeries { get; set; }

        /// <summary>
        /// Fires when clicking on the plot background. The this keyword refers to the chart object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// 
        /// Information on the clicked spot can be found through event.xAxis and event.yAxis,
        /// which are arrays containing the axes of each dimension and each axis' value at the clicked spot. The primary axes are event.xAxis[0] and event.yAxis[0].
        /// Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.
        /// 
        /// click: function(e) {
        /// 	console.log(
        /// 		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value), 
        /// 		e.yAxis[0].value
        /// 	)
        /// }
        /// </summary>
        public JsAction<object> click { get; set; }

        /// <summary>
        /// Fires when the chart is finished loading. The this keyword refers to the chart object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// From version 2.0.4, there is also a second parameter to Highcharts.Chart where a callback function can be passed to be executed on chart.load.
        /// </summary>
        public JsAction<object> load { get; set; }

        /// <summary>
        /// Fires when the chart is redrawn, either after a call to chart.redraw() or after an axis, series or point is modified with the redraw option set to true.
        /// The this keyword refers to the chart object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// </summary>
        public JsAction<object> redraw { get; set; }

        /// <summary>
        /// Fires when an area of the chart has been selected. Selection is enabled by setting the chart's zoomType.
        /// The this keyword refers to the chart object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// The default action for the selection event is to zoom the chart to the selected area. It can be prevented by calling event.preventDefault().
        /// Information on the selected area can be found through event.xAxis and event.yAxis,
        /// which are arrays containing the axes of each dimension and each axis' min and max values.
        /// The primary axes are event.xAxis[0] and event.yAxis[0]. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.
        /// 
        /// selection: function(event) {
        /// 	// log the min and max of the primary, datetime x-axis
        /// 	console.log(
        /// 		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min),
        /// 		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max)
        /// 	);
        /// 	// log the min and max of the y axis
        /// 	console.log(event.yAxis[0].min, event.yAxis[0].max);
        /// }
        /// </summary>
        public JsAction<object> selection { get; set; }

    }
    //TODO: must check all events!

    /// <summary>
    /// The animation can either be set as a boolean or a configuration object.
    /// If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:
    /// </summary>
    [JsType(JsMode.Json)]
    public class AnimationOptions
    {
        /// <summary>
        /// The duration of the animation in milliseconds.
        /// </summary>
        public JsNumber duration { get; set; }

        /// <summary>
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs.
        /// When using MooTools as the general framework, use the property name transition instead of easing.
        /// </summary>
        public EasingType easing { get; set; }
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum EasingType
    {
        linear,
        swing,
    }

    /// <summary>
    /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ShadowOptions
    {
        public JsString color { get; set; }

        public JsString offsetX { get; set; }
        [JsProperty(Name = "offsetX")]
        public JsNumber offsetXNumber { get; set; }

        public JsString offsetY { get; set; }
        [JsProperty(Name = "offsetY")]
        public JsNumber offsetYNumber { get; set; }

        public JsString opacity { get; set; }
        [JsProperty(Name = "opacity")]
        public JsNumber opacityNumber { get; set; }

        public JsString width { get; set; }
        [JsProperty(Name = "width")]
        public JsNumber widthNumber { get; set; }
    }

    /// <summary>
    /// The button that appears after a selection zoom, allowing the user to reset zoom.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ResetZoomButton
    {
        /// <summary>
        /// The position of the button.
        /// </summary>
        public object position { get; set; }

        /// <summary>
        /// What frame the button should be placed related to. Can be either "plot" or "chart". Defaults to "plot".
        /// </summary>
        public RelativeToType relativeTo { get; set; }

        /// <summary>
        /// A collection of attributes for the button. The object takes SVG attributes like fill, stroke, stroke-width or r, the border radius.
        /// The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.
        /// </summary>
        public object theme { get; set; }
    }

    /// <summary>
    /// What frame the button should be placed related to. Can be either "plot" or "chart".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum RelativeToType
    {
        plot,
        chart,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TypeOptions
    {
        line,
        spline,
        area,
        areaspline,
        column,
        bar,
        pie,
        scatter,
        arearange,
        areasplinerange,
        columnrange,
    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum ZoomType
    {
        x,
        y,
        xy,
    }

    #endregion

    #region credits

    /// <summary>
    /// Highchart by default puts a credits label in the lower right corner of the chart. This can be changed using these options.
    /// </summary>
    [JsType(JsMode.Json)]
    public class CreditsOptions
    {
        /// <summary>
        /// Whether to show the credits text. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The URL for the credits label. Defaults to "http://www.highcharts.com".
        /// </summary>
        public JsString href { get; set; }

        /// <summary>
        /// Position configuration for the credtis label. Supported properties are align, verticalAlign, x and y. Defaults to
        /// position: {
        /// 	align: 'right',
        /// 	x: -10,
        /// 	verticalAlign: 'bottom',
        /// 	y: -5
        /// }
        /// </summary>
        public CreditsPositionOptions position { get; set; }

        /// <summary>
        /// CSS styles for the credits label. Defaults to:
        /// itemStyle: {
        /// 	cursor: 'pointer',
        /// 	color: '#909090',
        /// 	fontSize: '10px'
        /// 
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The text for the credits label. Defaults to "Highcharts.com".
        /// </summary>
        public JsString text { get; set; }
    }

    /// <summary>
    /// Position configuration for the credtis label. Supported properties are align, verticalAlign, x and y.
    /// </summary>
    [JsType(JsMode.Json)]
    public class CreditsPositionOptions
    {
        public HorizontalAlignType align { get; set; }
        public JsNumber x { get; set; }
        public VerticalAlignType verticalAlign { get; set; }
        public JsNumber y { get; set; }
    }

    #endregion

    #region exporting

    /// <summary>
    /// Options for the exporting module.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ExportingOptions
    {
        /// <summary>
        /// Options for the export related buttons, print and export.
        /// </summary>
        public ButtonsOptions buttons { get; set; }

        /// <summary>
        /// Whether to enable images in the export. Including image point markers, background images etc. Defaults to false.
        /// </summary>
        public bool enableImages { get; set; }

        /// <summary>
        /// Whether to enable the exporting module. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The filename, without extension, to use for the exported chart. Defaults to "chart".
        /// </summary>
        public JsString filename { get; set; }

        /// <summary>
        /// Default MIME type for exporting if chart.exportChart() is called without specifying a type option.
        /// Possible values are image/png, image/jpeg, application/pdf and image/svg+xml. Defaults to "image/png".
        /// </summary>
        public JsString type { get; set; }

        /// <summary>
        /// The URL for the server module converting the SVG string to an image format.
        /// By default this points to Highslide Software's free web service. Defaults to http://export.highcharts.com.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// The pixel width of charts exported to PNG or JPG. . Defaults to 800.
        /// </summary>
        public JsNumber width { get; set; }
    }

    /// <summary>
    /// Options for the export related buttons, print and export.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ButtonsOptions
    {
        /// <summary>
        /// Options for the export button.
        /// </summary>
        public ExportButtonOptions exportButton { get; set; }

        /// <summary>
        /// Options for the print button.
        /// </summary>
        public PrintButtonOptions printButton { get; set; }

    }

    /// <summary>
    /// Options for the export button.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ExportButtonOptions
    {
        /// <summary>
        /// Alignment for the buttons. Defaults to "right".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// backgroundColor: ColorSince 2.0
        /// Background color or gradient for the buttons. Defaults to
        /// backgroundColor: {
        /// 	linearGradient: [0, 0, 0, 20],
        /// 	stops: [
        /// 		[0.4, '#F7F7F7'],
        /// 		[0.6, '#E3E3E3']
        /// 	]
        /// }
        /// </summary>
        public object backgroundColor { get; set; }

        /// <summary>
        /// The border color of the buttons. Defaults to "#B0B0B0".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border corner radius of the buttons. Defaults to 3.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width of the buttons. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Whether to enable buttons. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Pixel height of the buttons. Defaults to 20.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// Color of the button border on hover. Defaults to #909090.
        /// </summary>
        public JsString hoverBorderColor { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => hoverSymbolFill. Defaults to #768F3E.
        /// </summary>
        public JsString hoverSymbolFill { get; set; }

        /// <summary>
        /// Stroke (line) color for the symbol within the button on hover. Defaults to #4572A5.
        /// </summary>
        public JsString hoverSymbolStroke { get; set; }

        /// <summary>
        /// A collection of config options for the menu items.
        /// Each options object consists of a text option which is a string to show in the menu item, as well as an onclick parameter which is a callback function to run on click.
        /// By default, there is one menu item for each of the available export types.
        /// Menu items can be customized by defining a new array of items and assigning null to unwanted positions (see override example below).
        /// </summary>
        public JsArray<object> menuItems { get; set; }

        /// <summary>
        /// A click handler callback to use on the button directly instead of the popup menu.
        /// </summary>
        public JsAction onclick { get; set; }

        /// <summary>
        /// The symbol for the button. Points to a definition function in the Highcharts.Renderer.symbols collection.
        /// The default exportIcon function is part of the exporting module. Defaults to "exportIcon".
        /// </summary>
        public JsString symbol { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => symbolFill. Defaults to #A8BF77.
        /// </summary>
        public JsString symbolFill { get; set; }

        /// <summary>
        /// The pixel size of the symbol on the button. Defaults to 12.
        /// </summary>
        public JsNumber symbolSize { get; set; }

        /// <summary>
        /// The color of the symbol's stroke or line. Defaults to "#A0A0A0".
        /// </summary>
        public JsString symbolStroke { get; set; }

        /// <summary>
        /// The pixel stroke width of the symbol on the button. Defaults to 1.
        /// </summary>
        public JsNumber symbolStrokeWidth { get; set; }

        /// <summary>
        /// The x position of the center of the symbol inside the button. Defaults to 11.5.
        /// </summary>
        public JsNumber symbolX { get; set; }

        /// <summary>
        /// The y position of the center of the symbol inside the button. Defaults to 10.5.
        /// </summary>
        public JsNumber symbolY { get; set; }

        /// <summary>
        /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The pixel width of the button. Defaults to 24.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The horizontal positioin of the button relative to the align option. Defaults to 10.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The vertical offset of the button's position relative to its verticalAlign.	 . Defaults to 10.
        /// </summary>
        public JsNumber y { get; set; }

    }

    /// <summary>
    /// Options for the print button.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PrintButtonOptions
    {
        /// <summary>
        /// Alignment for the buttons. Defaults to "right".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// backgroundColor: ColorSince 2.0
        /// Background color or gradient for the buttons. Defaults to
        /// backgroundColor: {
        /// 	linearGradient: [0, 0, 0, 20],
        /// 	stops: [
        /// 		[0.4, '#F7F7F7'],
        /// 		[0.6, '#E3E3E3']
        /// 	]
        /// }
        /// </summary>
        public object backgroundColor { get; set; }

        /// <summary>
        /// The border color of the buttons. Defaults to "#B0B0B0".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border corner radius of the buttons. Defaults to 3.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width of the buttons. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Whether to enable buttons. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Pixel height of the buttons. Defaults to 20.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// Color of the button border on hover. Defaults to #909090.
        /// </summary>
        public JsString hoverBorderColor { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => hoverSymbolFill. Defaults to #768F3E.
        /// </summary>
        public JsString hoverSymbolFill { get; set; }

        /// <summary>
        /// Stroke (line) color for the symbol within the button on hover. Defaults to #4572A5.
        /// </summary>
        public JsString hoverSymbolStroke { get; set; }

        /// <summary>
        /// A click handler callback to use on the button directly instead of the popup menu.
        /// </summary>
        public JsAction onclick { get; set; }

        /// <summary>
        /// The symbol for the button. Points to a definition function in the Highcharts.Renderer.symbols collection.
        /// The default exportIcon function is part of the exporting module. Defaults to "exportIcon".
        /// </summary>
        public JsString symbol { get; set; }

        /// <summary>
        /// See navigation.buttonOptions => symbolFill. Defaults to #A8BF77.
        /// </summary>
        public JsString symbolFill { get; set; }

        /// <summary>
        /// The pixel size of the symbol on the button. Defaults to 12.
        /// </summary>
        public JsNumber symbolSize { get; set; }

        /// <summary>
        /// The color of the symbol's stroke or line. Defaults to "#A0A0A0".
        /// </summary>
        public JsString symbolStroke { get; set; }

        /// <summary>
        /// The pixel stroke width of the symbol on the button. Defaults to 1.
        /// </summary>
        public JsNumber symbolStrokeWidth { get; set; }

        /// <summary>
        /// The x position of the center of the symbol inside the button. Defaults to 11.5.
        /// </summary>
        public JsNumber symbolX { get; set; }

        /// <summary>
        /// The y position of the center of the symbol inside the button. Defaults to 10.5.
        /// </summary>
        public JsNumber symbolY { get; set; }

        /// <summary>
        /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The pixel width of the button. Defaults to 24.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The horizontal positioin of the button relative to the align option. Defaults to 10.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The vertical offset of the button's position relative to its verticalAlign.	 . Defaults to 10.
        /// </summary>
        public JsNumber y { get; set; }

    }

    /// <summary>
    /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". 
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum VerticalAlignType
    {
        top,
        middle,
        bottom,
    }

    #endregion

    #region global

    /// <summary>
    /// Global options that don't apply to each chart. These options, like the lang options, must be set using the Highcharts.setOptions method.
    /// Highcharts.setOptions({
    /// 	global: {
    /// 		useUTC: false
    /// 	}
    /// });
    /// </summary>
    [JsType(JsMode.Json)]
    public class GlobalOptions
    {
        /// <summary>
        /// Path to the pattern image required by VML browsers in order to draw radial gradients. Defaults to http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png.
        /// </summary>
        public JsString VMLRadialGradientURL { get; set; }

        /// <summary>
        /// The URL to the additional file to lazy load for Android 2.x devices.
        /// These devices don't support SVG, so we download a helper file that contains canvg, its dependecy rbcolor, and our own CanVG Renderer class.
        /// To avoid hotlinking to our site, you can install canvas-tools.js on your own server and change this option accordingly.
        /// Defaults to "http://www.highcharts.com/js/canvas-tools.js".
        /// </summary>
        public JsString canvasToolsURL { get; set; }

        /// <summary>
        /// Whether to use UTC time for axis scaling, tickmark placement and time display in Highcharts.dateFormat.
        /// Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings.
        /// Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required. Defaults to true.
        /// </summary>
        public bool useUTC { get; set; }
    }

    #endregion

    #region labels

    /// <summary>
    /// HTML labels that can be positioined anywhere in the chart area.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LabelsOptions
    {
        /// <summary>
        /// A HTML label that can be positioined anywhere in the chart area.
        /// </summary>
        public JsArray<ItemsOptions> items { get; set; }

        /// <summary>
        /// Shared CSS styles for all labels. Defaults to:
        /// style: {
        /// 	color: '#3E576F'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

    }

    /// <summary>
    /// A HTML label that can be positioined anywhere in the chart area.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ItemsOptions
    {

        /// <summary>
        /// Inner HTML or text for the label. Defaults to "".
        /// </summary>
        public JsString html { get; set; }

        /// <summary>
        /// CSS styles for each label. To position the label, use left and top like this:
        /// style: {
        /// 	left: '100px',
        /// 	top: '100px'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }
    }

    #endregion

    #region lang

    /// <summary>
    /// Language object. The language object is global and it can't be set on each chart initiation. Instead, use Highcharts.setOptions to set it before any chart is initiated.
    /// Highcharts.setOptions({
    /// 	lang: {
    /// 		months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 
    /// 			'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],
    /// 		weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']
    /// 	}
    /// });
    /// </summary>
    [JsType(JsMode.Json)]
    public class LangOptions
    {
        /// <summary>
        /// The default decimal point used in the Highcharts.numberFormat method unless otherwise specified in the function arguments. Defaults to ".".
        /// </summary>
        public JsString decimalPoint { get; set; }

        /// <summary>
        /// Exporting module only. The text for the JPEG download menu item. Defaults to "Download JPEG image".
        /// </summary>
        public JsString downloadJPEG { get; set; }

        /// <summary>
        /// Exporting module only. The text for the PDF download menu item. Defaults to "Download PDF document".
        /// </summary>
        public JsString downloadPDF { get; set; }

        /// <summary>
        /// Exporting module only. The text for the PNG download menu item. Defaults to "Download PNG image".
        /// </summary>
        public JsString downloadPNG { get; set; }

        /// <summary>
        /// Exporting module only. The text for the SVG download menu item. Defaults to "Download SVG vector image".
        /// </summary>
        public JsString downloadSVG { get; set; }

        /// <summary>
        /// Exporting module only. The tooltip text for the export button. Defaults to "Export to raster or vector image".
        /// </summary>
        public JsString exportButtonTitle { get; set; }

        /// <summary>
        /// The loading text that appears when the chart is set into the loading state following a call to chart.showLoading. Defaults to Loading....
        /// </summary>
        public JsString loading { get; set; }

        /// <summary>
        /// An array containing the months names. Corresponds to the %B format in Highcharts.dateFormat().
        /// Defaults to ['January' 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],.
        /// </summary>
        public JsArray<JsString> months { get; set; }

        /// <summary>
        /// Metric prefixes used to shorten high numbers in axis labels. Defaults to ['k', 'M', 'G', 'T', 'P', 'E'].
        /// </summary>
        public JsArray<JsString> numericSymbols { get; set; }

        /// <summary>
        /// Exporting module only. The tooltip text for the print button. Defaults to "Print the chart".
        /// </summary>
        public JsString printButtonTitle { get; set; }

        /// <summary>
        /// The text for the label appearing when a chart is zoomed. Defaults to Reset zoom.
        /// </summary>
        public JsString resetZoom { get; set; }

        /// <summary>
        /// The tooltip title for the label appearing when a chart is zoomed. Defaults to Reset zoom level 1:1.
        /// </summary>
        public JsString resetZoomTitle { get; set; }

        /// <summary>
        /// An array containing the months names in abbreviated form. Corresponds to the %b format in Highcharts.dateFormat().
        /// Defaults to ['Jan' 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],.
        /// </summary>
        public JsArray<JsString> shortMonths { get; set; }

        /// <summary>
        /// The default thousands separator used in the Highcharts.numberFormat method unless otherwise specified in the function arguments. Defaults to ",". Defaults to "",.
        /// </summary>
        public JsString thousandsSep { get; set; }

        /// <summary>
        /// An array containing the weekday names. Defaults to ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'].
        /// Defaults to ['Sunday' 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'].
        /// </summary>
        public JsArray<JsString> Name { get; set; }
    }

    #endregion

    #region legend

    /// <summary>
    /// The legend is a box containing a symbol and name for each series item or point item in the chart.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LegendOptions
    {
        /// <summary>
        /// The horizontal alignment of the legend box within the chart area. Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// The background color of the legend, filling the rounded corner border. Defaults to null.
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The color of the drawn border around the legend. Defaults to #909090.
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border corner radius of the legend. Defaults to 5.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The width of the drawn border around the legend. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Enable or disable the legend. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// When the legend is floating, the plot area ignores it and is allowed to be placed below it. Defaults to false.
        /// </summary>
        public bool floating { get; set; }

        /// <summary>
        /// CSS styles for each legend item when the corresponding series or point is hidden. Properties are inherited from style unless overridden here. Defaults to:
        /// itemHiddenStyle: {
        /// 	color: '#CCC'
        /// }
        /// </summary>
        public CssStyleJson itemHiddenStyle { get; set; }

        /// <summary>
        /// CSS styles for each legend item in hover mode. Properties are inherited from style unless overridden here. Defaults to:
        /// itemHoverStyle: {
        /// 	color: '#000'
        /// }
        /// </summary>
        public CssStyleJson itemHoverStyle { get; set; }

        /// <summary>
        /// The pixel bottom margin for each legend item. Defaults to 0.
        /// </summary>
        public JsNumber itemMarginBottom { get; set; }

        /// <summary>
        /// The pixel top margin for each legend item. Defaults to 0.
        /// </summary>
        public JsNumber itemMarginTop { get; set; }

        /// <summary>
        /// CSS styles for each legend item. Defaults to:
        /// itemStyle: {
        /// 	cursor: 'pointer',
        /// 	color: '#3E576F'
        /// }
        /// </summary>
        public CssStyleJson itemStyle { get; set; }

        /// <summary>
        /// The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically. . Defaults to null.
        /// </summary>
        public JsNumber itemWidth { get; set; }

        /// <summary>
        /// Callback function to format each of the series' labels. The this keyword refers to the series object, or the point object in case of pie charts. Defaults to:
        /// labelFormatter: function() {
        /// 	return this.name
        /// }
        /// </summary>
        public JsAction labelFormatter { get; set; }

        /// <summary>
        /// The layout of the legend items. Can be one of "horizontal" or "vertical". Defaults to "horizontal".
        /// </summary>
        public LayoutType layout { get; set; }

        /// <summary>
        /// Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each item can be set using itemStyle.lineHeight,
        /// and the padding between items using itemMarginTop and itemMarginBottom. Defaults to 16.
        /// </summary>
        public JsNumber lineHeight { get; set; }

        /// <summary>
        /// If the plot area sized is calculated automatically and the legend is not floating,
        /// the legend margin is the space between the legend and the axis labels or plot area. Defaults to 15.
        /// </summary>
        public JsNumber margin { get; set; }

        /// <summary>
        /// Maximum pixel height for the legend. When the maximum height is extended, navigation will show. Defaults to undefined.
        /// </summary>
        public JsNumber maxHeight { get; set; }

        /// <summary>
        /// Options for the paging or navigation appearing when the legend is overflown.
        /// </summary>
        public LegendNavigationOptions navigation { get; set; }

        /// <summary>
        /// The inner padding of the legend box. Defaults to 8.
        /// </summary>
        public JsNumber padding { get; set; }

        /// <summary>
        /// Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object. Defaults to false.
        /// </summary>
        public bool reversed { get; set; }

        /// <summary>
        /// Whether to show the symbol on the right side of the text rather than the left side. This is common in Arabic and Hebraic. Defaults to false.
        /// </summary>
        public bool rtl { get; set; }

        /// <summary>
        /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }

        /// <summary>
        /// CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x,
        /// the position is determined by properties like align, verticalAlign, x and y, but the styles are still parsed for backwards compatibility.
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The pixel padding between the legend item symbol and the legend item text. Defaults to 5.
        /// </summary>
        public JsNumber symbolPadding { get; set; }

        /// <summary>
        /// The pixel width of the legend item symbol. Defaults to 30.
        /// </summary>
        public JsNumber symbolWidth { get; set; }

        /// <summary>
        /// The vertical alignment of the legend box. Can be one of "top", "middle" or "bottom". Vertical position can be further determined by the y option. Defaults to "bottom".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The width of the legend box, not including style.padding. . Defaults to null.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The x offset of the legend relative to it's horizontal alignment align within chart.spacingLeft and chart.spacingRight.
        /// Negative x moves it to the left, positive x moves it to the right.
        /// The default value of 15 together with align: "center" puts it in the center of the plot area. Defaults to 0.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The vertical offset of the legend relative to it's vertical alignment verticalAlign within chart.spacingTop and chart.spacingBottom.
        /// Negative y moves it up, positive y moves it down. Defaults to 0.
        /// </summary>
        public JsNumber y { get; set; }

    }

    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum LayoutType
    {
        horizontal,
        vertical,
    }

    /// <summary>
    /// Options for the paging or navigation appearing when the legend is overflown.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LegendNavigationOptions
    {
        /// <summary>
        /// The color for the active up or down arrow in the legend page navigation. Defaults to #3E576F.
        /// </summary>
        public JsString activeColor { get; set; }

        /// <summary>
        /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in the chart.animation option.
        /// Additional options can be given as an object containing values for easing and duration. . Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in the chart.animation option.
        /// Additional options can be given as an object containing values for easing and duration. . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }
        /// <summary>
        /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in the chart.animation option.
        /// Additional options can be given as an object containing values for easing and duration. . Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }

        /// <summary>
        /// The pixel size of the up and down arrows in the legend paging navigation. . Defaults to 12.
        /// </summary>
        public JsNumber arrowSize { get; set; }

        /// <summary>
        /// The color of the inactive up or down arrow in the legend page navigation. . Defaults to #CCC.
        /// </summary>
        public JsString inactiveColor { get; set; }

        /// <summary>
        /// Text styles for the legend page navigation.
        /// </summary>
        public CssStyleJson style { get; set; }

    }

    #endregion

    #region loading

    /// <summary>
    /// The loading options control the appearance of the loading screen that covers the plot area on chart operations.
    /// This screen only appears after an explicit call to chart.showLoading().
    /// It is a utility for developers to communicate to the end user that something is going on, for example while retrieving new data via an XHR connection.
    /// The "Loading..." text itself is not part of this configuration object, but part of the lang object.
    /// </summary>
    [JsType(JsMode.Json)]
    public class LoadingOptions
    {
        /// <summary>
        /// The duration in milliseconds of the fade out effect. Defaults to 100.
        /// </summary>
        public JsNumber hideDuration { get; set; }

        /// <summary>
        /// CSS styles for the loading label span. Defaults to:
        /// labelStyle: {
        /// 	fontWeight: 'bold',
        /// 	position: 'relative',
        /// 	top: '1em'
        /// }
        /// </summary>
        public CssStyleJson labelStyle { get; set; }

        /// <summary>
        /// The duration in milliseconds of the fade in effect. Defaults to 100.
        /// </summary>
        public JsNumber showDuration { get; set; }

        /// <summary>
        /// CSS styles for the loading screen that covers the plot area. Defaults to:
        /// style: {
        /// 	position: 'absolute',
        /// 	backgroundColor: 'white',
        /// 	opacity: 0.5,
        /// 	textAlign: 'center'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

    }

    #endregion

    #region navigation

    /// <summary>
    /// A collection of options for buttons and menus appearing in the exporting module.
    /// </summary>
    [JsType(JsMode.Json)]
    public class NavigationOptions
    {
        /// <summary>
        /// A collection of options for buttons appearing in the exporting module.
        /// </summary>
        public ButtonOptions buttonOptions { get; set; }

        /// <summary>
        /// CSS styles for the hover state of the individual items within the popup menu appearing by default when the export icon is clicked. The menu items are rendered in HTML. Defaults to
        /// menuItemHoverStyle: {
        /// 	background: '#4572A5',
        /// 	color: '#FFFFFF'
        /// }
        /// </summary>
        public CssStyleJson menuItemHoverStyle { get; set; }

        /// <summary>
        /// CSS styles for the individual items within the popup menu appearing by default when the export icon is clicked. The menu items are rendered in HTML. Defaults to
        /// menuItemStyle: {
        /// 	padding: '0 5px',
        /// 	background: NONE,
        /// 	color: '#303030'
        /// }
        /// </summary>
        public CssStyleJson menuItemStyle { get; set; }

        /// <summary>
        /// CSS styles for the popup menu appearing by default when the export icon is clicked. This menu is rendered in HTML. Defaults to
        /// menuStyle: {
        /// 	border: '1px solid #A0A0A0',
        /// 	background: '#FFFFFF'
        /// }
        /// </summary>
        public CssStyleJson menuStyle { get; set; }
    }

    /// <summary>
    /// A collection of options for buttons appearing in the exporting module.
    /// </summary>
    [JsType(JsMode.Json)]
    public class ButtonOptions
    {
        /// <summary>
        /// Alignment for the buttons. Defaults to "right".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// Background color or gradient for the buttons. Defaults to
        /// backgroundColor: {
        /// 	linearGradient: [0, 0, 0, 20],
        /// 	stops: [
        /// 		[0.4, '#F7F7F7'],
        /// 		[0.6, '#E3E3E3']
        /// 	]
        /// }
        /// </summary>
        public object backgroundColor { get; set; }

        /// <summary>
        /// The border color of the buttons. Defaults to "#B0B0B0".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border corner radius of the buttons. Defaults to 3.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width of the buttons. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Whether to enable buttons. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Pixel height of the buttons. Defaults to 20.
        /// </summary>
        public JsNumber height { get; set; }

        /// <summary>
        /// Color of the button border on hover. Defaults to #909090.
        /// </summary>
        public JsString hoverBorderColor { get; set; }

        /// <summary>
        /// Fill color for the symbol within the button on hover. Defaults to #81A7CF.
        /// </summary>
        public JsString hoverSymbolFill { get; set; }

        /// <summary>
        /// Stroke (line) color for the symbol within the button on hover. Defaults to #4572A5.
        /// </summary>
        public JsString hoverSymbolStroke { get; set; }

        /// <summary>
        /// Fill color for the symbol within the button. Defaults to #E0E0E0.
        /// </summary>
        public JsString symbolFill { get; set; }

        /// <summary>
        /// The pixel size of the symbol on the button. Defaults to 12.
        /// </summary>
        public JsNumber symbolSize { get; set; }

        /// <summary>
        /// The color of the symbol's stroke or line. Defaults to "#A0A0A0".
        /// </summary>
        public JsString symbolStroke { get; set; }

        /// <summary>
        /// The pixel stroke width of the symbol on the button. Defaults to 1.
        /// </summary>
        public JsNumber symbolStrokeWidth { get; set; }

        /// <summary>
        /// The x position of the center of the symbol inside the button. Defaults to 11.5.
        /// </summary>
        public JsNumber symbolX { get; set; }

        /// <summary>
        /// The y position of the center of the symbol inside the button. Defaults to 10.5.
        /// </summary>
        public JsNumber symbolY { get; set; }

        /// <summary>
        /// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The pixel width of the button. Defaults to 24.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The vertical offset of the button's position relative to its verticalAlign.	 . Defaults to 10.
        /// </summary>
        public JsNumber y { get; set; }

    }

    #endregion

    #region pane

    /// <summary>
    /// Applies only to polar charts and angular gauges.
    /// This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PaneOptions
    {
        /// <summary>
        /// An object, or array of objects, for backgrounds.
        /// Sub options include backgroundColor (which can be solid or gradient), innerWidth, outerWidth, borderWidth, borderColor.
        /// </summary>
        public object background { get; set; }
        /// <summary>
        /// An object, or array of objects, for backgrounds.
        /// Sub options include backgroundColor (which can be solid or gradient), innerWidth, outerWidth, borderWidth, borderColor.
        /// </summary>
        [JsProperty(Name = "background")]
        public JsArray<object> backgroundArray { get; set; }

        /// <summary>
        /// The center of a polar chart or angular gauge, given as an array of [x, y] positions.
        /// Positions can be given as integers that transform to pixels, or as percentages of the plot area size. Defaults to ['50%', '50%'].
        /// </summary>
        public JsArray<CenterOptions> center { get; set; }

        /// <summary>
        /// The end angle of the polar X axis or gauge value axis, given in degrees where 0 is north. Defaults to startAngle + 360.
        /// </summary>
        public JsNumber endAngle { get; set; }

        /// <summary>
        /// The start angle of the polar X axis or gauge axis, given in degrees where 0 is north. Defaults to 0.
        /// </summary>
        public JsNumber startAngle { get; set; }
    }

    /// <summary>
    /// The center of a polar chart or angular gauge, given as an array of [x, y] positions.
    /// Positions can be given as integers that transform to pixels, or as percentages of the plot area size. Defaults to ['50%', '50%'].
    /// </summary>
    [JsType(JsMode.Json)]
    public class CenterOptions
    {

        public JsNumber x { get; set; }
        public JsNumber y { get; set; }

        [JsProperty(Name = "x")]
        public JsString xString { get; set; }
        [JsProperty(Name = "y")]
        public JsString yString { get; set; }

    }

    #endregion

    #region plotOptions

    /// <summary>
    /// The plotOptions is a wrapper object for config objects for each series type.
    /// The config objects for each series can also be overridden for each series item as given in the series array.
    /// Configuration options for the series are given in three levels. Options for all series in a chart are given in the plotOptions.series object.
    /// Then options for all series of a specific type are given in the plotOptions of that type, for example plotOptions.line.
    /// Next, options for one single series are given in the series array.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PlotOptions
    {
        public PlotAreaOptions area { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotAreaRangeOptions arearange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotAreaSplineOptions areaspline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotAreaSplineRangeOptions areasplinerange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotBarOptions bar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotColumnOptions column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotColumnRangeOptions columnrange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotGaugeOptions gauge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotLineOptions line { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotPieOptions pie { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotScatterOptions scatter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotSeriesOptions series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlotSplineOptions spline { get; set; }


    }

    #region area

    [JsType(JsMode.Json)]
    public class PlotAreaOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Polar charts only. Whether to connect the ends of a line series plot across the extremes. Defaults to true.
        /// </summary>
        public bool connectEnds { get; set; }

        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public bool connectNulls { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 300.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth. The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        public AreaDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// Fill color or gradient for the area. When null, the series' color is used with the series' fillOpacity. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// Fill opacity for the area. Defaults to .75.
        /// </summary>
        public JsNumber fillOpacity { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// A separate color for the graph line. By default the line takes the color of the series,
        /// but the lineColor setting allows setting a separate color for the line without altering the fillColor. Defaults to null.
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public AreaMarkerOptions marker { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// Whether to stack the values of each series on top of each other.
        /// Possible values are null to disable, "normal" to stack by value or "percent". Defaults to null.
        /// </summary>
        public JsString stacking { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public AreaStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// The Y axis value to serve as the base for the area, for distinguishing between values above and below a threshold. Defaults to 0.
        /// </summary>
        public JsNumber threshold { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events. Defaults to false.
        /// </summary>
        public bool trackByArea { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PlotAreaEvent
    {
        /// <summary>
        /// Fires when the checkbox next to the series' name in the legend is clicked.. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// The state of the checkbox is found by event.checked. Return false to prevent the default action which is to toggle the select state of the series.
        /// </summary>
        public JsAction checkboxClick { get; set; }

        /// <summary>
        /// Fires when the series is clicked. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// Additionally, event.point holds a pointer to the nearest point on the graph.
        /// </summary>
        public JsAction<object> click { get; set; }

        /// <summary>
        /// Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling .hide().
        /// </summary>
        public JsAction hide { get; set; }

        /// <summary>
        /// Fires when the legend item belonging to the series is clicked.
        /// The this keyword refers to the series object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// The default action is to toggle the visibility of the series. This can be prevented by returning false or calling event.preventDefault().
        /// </summary>
        public JsAction<object> legendItemClick { get; set; }

        /// <summary>
        /// Fires when the mouse leaves the graph. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// If the stickyTracking option is true, mouseOut doesn't happen before the mouse enters another graph or leaves the plot area.
        /// </summary>
        public JsAction<object> mouseOut { get; set; }

        /// <summary>
        /// Fires when the mouse enters the graph. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// </summary>
        public JsAction<object> mouseOver { get; set; }

        /// <summary>
        /// Fires when the series is shown after chart generation time, either by clicking the legend item or by calling .show().
        /// </summary>
        public JsAction show { get; set; }

    }
    //TODO: must check all events

    /// <summary>
    /// A name for the dash style to use for the graph.
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum DashStyleType
    {
        Solid,
        ShortDash,
        ShortDot,
        ShortDashDot,
        ShortDashDotDot,
        Dot,
        Dash,
        LongDash,
        DashDot,
        LongDashDot,
        LongDashDotDot,
    }

    [JsType(JsMode.Json)]
    public class AreaDataLabelsOptions
    {
        /// <summary>
        /// The alignment of the data label compared to the point. Can be one of "left", "center" or "right". Defaults to "center". Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// The background color or gradient for the data label. Defaults to undefined. Defaults to undefined.
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The border color for the data label. Defaults to undefined. Defaults to undefined.
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border radius in pixels for the data label. Defaults to 0. Defaults to 0.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width in pixels for the data label. Defaults to 0. Defaults to 0.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// The text color for the data labels. Defaults to null. Defaults to null.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Enable or disable the data labels. Defaults to false. Defaults to false.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Callback JavaScript function to format the data label. Available data are:
        /// this.percentage	Stacked series and pies only. The point's percentage of the total.
        /// this.point	The point object. The point name, if defined, is available through this.point.name.
        /// this.series:	The series object. The series name is available through this.series.name.
        /// this.total	Stacked series only. The total value at this point's x value.
        /// this.x:	The y value.
        /// this.y:	The y value.
        /// Default value:
        /// formatter: function() {
        /// 	return this.y;
        /// }
        /// </summary>
        public JsAction formatter { get; set; }
        //TODO: Callback JavaScript function (REED SUMMARY)

        /// <summary>
        ///How to handle overflowing labels on horizontal axis. Can be undefined or "justify". If "justify", labels will not render outside the plot area.
        ///If there is room to move it, it will be aligned to the edge, else it will be removed. Defaults to undefined.
        /// </summary>
        public JsString overflow { get; set; }

        /// <summary>
        /// When either the borderWidth or the backgroundColor is set, this is the padding within the box. Defaults to 2. Defaults to 2.
        /// </summary>
        public JsNumber padding { get; set; }

        /// <summary>
        /// Text rotation in degrees. Defaults to 0. Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// n/a for data labels
        /// </summary>
        public JsNumber staggerLines { get; set; }

        /// <summary>
        /// n/a for data labels
        /// </summary>
        public JsNumber step { get; set; }

        /// <summary>
        /// Styles for the label.
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The x position offset of the label relative to the point. Defaults to 0.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y position offset of the label relative to the point. Defaults to -6. 
        /// </summary>
        public JsNumber y { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AreaMarkerOptions
    {
        /// <summary>
        /// Enable or disable the point marker. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The fill color of the point marker. When null, the series' or point's color is used. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// The color of the point marker's outline. When null, the series' or point's color is used. Defaults to "#FFFFFF".
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// The width of the point marker's outline. Defaults to 0.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// The radius of the point marker. Defaults to 0.
        /// </summary>
        public JsNumber radius { get; set; }

        public AreaMarkerStatesOptions states { get; set; }

        /// <summary>
        /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols.
        /// Other possible values are "circle", "square", "diamond", "triangle" and "triangle-down".
        /// Additionally, the URL to a graphic can be given on this form: "url(graphic.png)". Defaults to null.
        /// </summary>
        public JsString symbol { get; set; }
    }

    [JsType(JsMode.Json)]
    public class AreaMarkerStatesOptions
    {

        public AreaMarkerStatesHoverOptions hover { get; set; }

        /// <summary>
        /// The appearance of the point marker when selected. In order to allow a point to be selected, set the series.allowPointSelect option to true.
        /// </summary>
        public object select { get; set; }

    }

    [JsType(JsMode.Json)]
    public class AreaMarkerStatesHoverOptions
    {
        /// <summary>
        ///Enable or disable the point marker. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The fill color of the point marker. When null, the series' or point's color is used. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// The color of the point marker's outline. When null, the series' or point's color is used. Defaults to "#FFFFFF".
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// The width of the point marker's outline. Defaults to 0.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2.
        /// </summary>
        public JsNumber radius { get; set; }
    }

    /// <summary>
    /// The appearance of the point marker when selected. In order to allow a point to be selected, set the series.allowPointSelect option to true.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AreaMarkerStatesSelectOptions
    {
        /// <summary>
        ///Enable or disable visible feedback for selection. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The fill color of the point marker. When null, the series' or point's color is used. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// The color of the point marker's outline. When null, the series' or point's color is used. Defaults to "#000000".
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// The width of the point marker's outline. Defaults to 0.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2.
        /// </summary>
        public JsNumber radius { get; set; }
    }

    /// <summary>
    /// Properties for each single point
    /// </summary>
    [JsType(JsMode.Json)]
    public class PointOptions
    {
        /// <summary>
        /// Events for each single point
        /// </summary>
        public PointEvent events { get; set; }
    }

    /// <summary>
    /// Events for each single point
    /// </summary>
    [JsType(JsMode.Json)]
    public class PointEvent
    {

        /// <summary>
        /// Fires when a point is clicked. The this keyword refers to the point object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state.
        /// Returning false cansels this action.
        /// </summary>
        public JsAction<object> click { get; set; }

        /// <summary>
        /// Fires when the mouse leaves the area close to the point. The this keyword refers to the point object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// </summary>
        public JsAction<object> mouseOut { get; set; }

        /// <summary>
        /// Fires when the mouse enters the area close to the point. The this keyword refers to the point object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// </summary>
        public JsAction<object> mouseOver { get; set; }

        /// <summary>
        /// Fires when the point is removed using the .remove() method.
        /// The this keyword refers to the point object itself. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        public JsAction<object> remove { get; set; }

        /// <summary>
        /// Fires when the point is selected either programatically or following a click on the point.
        /// The this keyword refers to the point object itself. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        public JsAction<object> select { get; set; }

        /// <summary>
        /// Fires when the point is unselected either programatically or following a click on the point.
        /// The this keyword refers to the point object itself. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        public JsAction<object> unselect { get; set; }

        /// <summary>
        /// Fires when the point is updated programmatically through the .update() method. The this keyword refers to the point object itself.
        /// One parameter, event, is passed to the function. The new point options can be accessed through event.options. Returning false cancels the operation.
        /// </summary>
        public JsAction<object> update { get; set; }


    }
    //TODO: must check all events

    /// <summary>
    /// Possible values: null, "on", "between".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum PointPlacementType
    {
        on,
        between,
    }

    [JsType(JsMode.Json)]
    public class AreaStatesOptions : SeriesStatesOptions
    {
    }

    /// <summary>
    /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
    /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.	. Defaults to {}.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AreaTooltipOptions : TooltipOptions
    {
    }

    #endregion

    #region arearange

    /// <summary>
    /// The area range is a cartesian series type with higher and lower Y values along an X axis. Requires highcharts-more.js.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PlotAreaRangeOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public bool connectNulls { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn,
        /// event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold,
        /// the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 300.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth.
        /// The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        /// <summary>
        /// Extended data labels for range series types. Range series data labels have no x and y options.
        /// Instead, they have xLow, xHigh, yLow and yHigh options to allow the higher and lower data label sets individually.
        /// </summary>
        public AreaRangeDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaRangeEvent events { get; set; }

        /// <summary>
        /// Fill color or gradient for the area. When null, the series' color is used with the series' fillOpacity. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// Fill opacity for the area. Defaults to .75.
        /// </summary>
        public JsNumber fillOpacity { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// A separate color for the graph line. By default the line takes the color of the series,
        /// but the lineColor setting allows setting a separate color for the line without altering the fillColor. Defaults to null.
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// Whether to stack the values of each series on top of each other.
        /// Possible values are null to disable, "normal" to stack by value or "percent". Defaults to null.
        /// </summary>
        public JsString stacking { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public AreaRangeStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.	. Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events. Defaults to false.
        /// </summary>
        public bool trackByArea { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PlotAreaRangeEvent
    {
        /// <summary>
        /// Fires when the checkbox next to the series' name in the legend is clicked.. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// The state of the checkbox is found by event.checked. Return false to prevent the default action which is to toggle the select state of the series.
        /// </summary>
        public JsAction checkboxClick { get; set; }

        /// <summary>
        /// Fires when the series is clicked. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// Additionally, event.point holds a pointer to the nearest point on the graph.
        /// </summary>
        public JsAction<object> click { get; set; }

        /// <summary>
        /// Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling .hide().
        /// </summary>
        public JsAction hide { get; set; }

        /// <summary>
        /// Fires when the legend item belonging to the series is clicked.
        /// The this keyword refers to the series object itself. One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// The default action is to toggle the visibility of the series. This can be prevented by returning false or calling event.preventDefault().
        /// </summary>
        public JsAction<object> legendItemClick { get; set; }

        /// <summary>
        /// Fires when the mouse leaves the graph. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// If the stickyTracking option is true, mouseOut doesn't happen before the mouse enters another graph or leaves the plot area.
        /// </summary>
        public JsAction<object> mouseOut { get; set; }

        /// <summary>
        /// Fires when the mouse enters the graph. The this keyword refers to the series object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// </summary>
        public JsAction<object> mouseOver { get; set; }

        /// <summary>
        /// Fires when the series is shown after chart generation time, either by clicking the legend item or by calling .show().
        /// </summary>
        public JsAction show { get; set; }

    }

    /// <summary>
    /// Extended data labels for range series types. Range series data labels have no x and y options.
    /// Instead, they have xLow, xHigh, yLow and yHigh options to allow the higher and lower data label sets individually.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AreaRangeDataLabelsOptions
    {
        /// <summary>
        /// The alignment of the data label compared to the point. Can be one of "left", "center" or "right". Defaults to "center". Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// The background color or gradient for the data label. Defaults to undefined. Defaults to undefined.
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The border color for the data label. Defaults to undefined. Defaults to undefined.
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The border radius in pixels for the data label. Defaults to 0. Defaults to 0.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The border width in pixels for the data label. Defaults to 0. Defaults to 0.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// The text color for the data labels. Defaults to null. Defaults to null.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Enable or disable the data labels. Defaults to false. Defaults to false.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Callback JavaScript function to format the data label. Available data are:
        /// this.percentage	Stacked series and pies only. The point's percentage of the total.
        /// this.point	The point object. The point name, if defined, is available through this.point.name.
        /// this.series:	The series object. The series name is available through this.series.name.
        /// this.total	Stacked series only. The total value at this point's x value.
        /// this.x:	The y value.
        /// this.y:	The y value.
        /// Default value:
        /// formatter: function() {
        /// 	return this.y;
        /// }
        /// </summary>
        public JsAction formatter { get; set; }
        //TODO: Callback JavaScript function (REED SUMMARY)

        /// <summary>
        ///How to handle overflowing labels on horizontal axis. Can be undefined or "justify". If "justify", labels will not render outside the plot area.
        ///If there is room to move it, it will be aligned to the edge, else it will be removed. Defaults to undefined.
        /// </summary>
        public JsString overflow { get; set; }

        /// <summary>
        /// When either the borderWidth or the backgroundColor is set, this is the padding within the box. Defaults to 2. Defaults to 2.
        /// </summary>
        public JsNumber padding { get; set; }

        /// <summary>
        /// Text rotation in degrees. Defaults to 0. Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// n/a for data labels
        /// </summary>
        public JsNumber staggerLines { get; set; }

        /// <summary>
        /// n/a for data labels
        /// </summary>
        public JsNumber step { get; set; }

        /// <summary>
        /// Styles for the label.
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// X offset of the higher data labels relative to the point value. Defaults to 0.
        /// </summary>
        public JsNumber xHigh { get; set; }

        /// <summary>
        /// X offset of the lower data labels relative to the point value. Defaults to 0.
        /// </summary>
        public JsNumber xLow { get; set; }

        /// <summary>
        /// Y offset of the higher data labels relative to the point value. Defaults to -6.
        /// </summary>
        public JsNumber yHigh { get; set; }

        /// <summary>
        /// Y offset of the lower data labels relative to the point value. Defaults to 16.
        /// </summary>
        public JsNumber yLow { get; set; }

    }

    [JsType(JsMode.Json)]
    public class AreaRangeStatesOptions : SeriesStatesOptions
    {
    }

    #endregion

    #region PlotAreaOptions

    [JsType(JsMode.Json)]
    public class PlotAreaSplineOptions : PlotAreaOptions
    {
    }

    #endregion

    #region areasplinerange

    [JsType(JsMode.Json)]
    public class PlotAreaSplineRangeOptions : PlotAreaRangeOptions
    {
    }

    #endregion

    #region bar

    [JsType(JsMode.Json)]
    public class PlotBarOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The color of the border surronding each column or bar. Defaults to "#FFFFFF".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The corner radius of the border surronding each column or bar. Defaults to 0.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The width of the border surronding each column or bar. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// When using automatic point colors pulled from the options.colors collection,
        /// this option determines whether the chart should receive one color per series or one color per point. Defaults to false.
        /// </summary>
        public bool colorByPoint { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 50.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth. The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        public BarDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// Padding between each value groups, in x axis units. Defaults to 0.2.
        /// </summary>
        public JsNumber groupPadding { get; set; }

        /// <summary>
        /// Whether to group non-stacked columns or to let them render independent of each other.
        /// Non-grouped columns will be laid out individually and overlap each other. Defaults to true.
        /// </summary>
        public bool grouping { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The minimal height for a column or width for a bar. By default, 0 values are not shown.
        /// To visualize a 0 (or close to zero) point, set the minimal point length to a pixel value like 3.
        /// In stacked column charts, minPointLength might not be respected for tightly packed values. Defaults to 0.
        /// </summary>
        public JsNumber minPointLength { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Padding between each column or bar, in x axis units. Defaults to 0.1.
        /// </summary>
        public JsNumber pointPadding { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// A pixel value specifying a fixed width for each column or bar. When null, the width is calculated from the pointPadding and groupPadding. Defaults to null.
        /// </summary>
        public JsNumber pointWidth { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// Whether to stack the values of each series on top of each other.
        /// Possible values are null to disable, "normal" to stack by value or "percent". Defaults to null.
        /// </summary>
        public JsString stacking { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public BarStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class BarDataLabelsOptions : AreaDataLabelsOptions
    {
    }

    [JsType(JsMode.Json)]
    public class BarStatesOptions : SeriesStatesOptions
    {
    }

    #endregion

    #region column

    [JsType(JsMode.Json)]
    public class PlotColumnOptions : PlotBarOptions
    {
    }

    #endregion

    #region columnrange

    [JsType(JsMode.Json)]
    public class PlotColumnRangeOptions : PlotBarOptions
    {
    }

    #endregion

    #region gauge

    [JsType(JsMode.Json)]
    public class PlotGaugeOptions
    {
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        public GaugeDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Options for the dial or arrow pointer of the gauge.
        /// </summary>
        public GaugeDialOptions dial { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Options for the pivot or the center point of the gauge.
        /// </summary>
        public GaugePivotOptions pivot { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public GaugeStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    /// <summary>
    /// Data labels for the gauge. For gauges, the data labels are enabled by default and shown in a bordered box below the point.
    /// </summary>
    [JsType(JsMode.Json)]
    public class GaugeDataLabelsOptions : AreaRangeDataLabelsOptions
    {
    }

    /// <summary>
    /// Options for the dial or arrow pointer of the gauge.
    /// </summary>
    [JsType(JsMode.Json)]
    public class GaugeDialOptions
    {
        /// <summary>
        /// The background or fill color of the gauge's dial. Defaults to black.
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The length of the dial's base part, relative to the total radius or length of the dial. Defaults to 70%.
        /// </summary>
        public JsString baseLength { get; set; }

        /// <summary>
        /// The pixel width of the base of the gauge dial. The base is the part closest to the pivot, defined by baseLength. Defaults to 3.
        /// </summary>
        public JsNumber baseWidth { get; set; }

        /// <summary>
        /// The border color or stroke of the gauge's dial. By default, the borderWidth is 0, so this must be set in addition to a custom border color. Defaults to silver.
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The width of the gauge dial border in pixels. Defaults to 0.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// The radius or length of the dial, in percentages relative to the radius of the gauge itself. Defaults to 80%.
        /// </summary>
        public JsString radius { get; set; }

        /// <summary>
        /// The length of the dial's rear end, the part that extends out on the other side of the pivot. Relative to the dial's length. Defaults to 10%.
        /// </summary>
        public JsString rearLength { get; set; }

        /// <summary>
        /// The width of the top of the dial, closest to the perimeter. The pivot narrows in from the base to the top. Defaults to 1.
        /// </summary>
        public JsNumber topWidth { get; set; }
    }

    /// <summary>
    ///Options for the pivot or the center point of the gauge.
    /// </summary>
    [JsType(JsMode.Json)]
    public class GaugePivotOptions
    {
        /// <summary>
        /// The background or fill color of the gauge's dial. Defaults to black.
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The border color or stroke of the gauge's dial. By default, the borderWidth is 0, so this must be set in addition to a custom border color. Defaults to silver.
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The width of the gauge dial border in pixels. Defaults to 0.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// The pixel radius of the pivot. Defaults to 5.
        /// </summary>
        public JsNumber radius { get; set; }
    }

    [JsType(JsMode.Json)]
    public class GaugeStatesOptions : SeriesStatesOptions
    {
    }

    #endregion

    #region line

    [JsType(JsMode.Json)]
    public class PlotLineOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Polar charts only. Whether to connect the ends of a line series plot across the extremes. Defaults to true.
        /// </summary>
        public bool connectEnds { get; set; }

        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public bool connectNulls { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 300.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth. The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        public AreaDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public AreaMarkerOptions marker { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// Whether to stack the values of each series on top of each other.
        /// Possible values are null to disable, "normal" to stack by value or "percent". Defaults to null.
        /// </summary>
        public JsString stacking { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public AreaStatesOptions states { get; set; }

        /// <summary>
        /// Whether to apply steps to the line. Defaults to false.
        /// </summary>
        public bool step { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    #endregion

    #region pie

    [JsType(JsMode.Json)]
    public class PlotPieOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The color of the border surronding each slice. Defaults to "#FFFFFF".
        /// </summary>
        public object borderColor { get; set; }

        /// <summary>
        /// The width of the border surronding each slice. Defaults to 1.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// The center of the pie chart relative to the plot area. Can be percentages or pixel values. Defaults to ['50%', '50%']. Defaults to ['50%' '50%'],.
        /// </summary>
        public JsArray<JsString> center { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        public AreaDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The size of the inner diameter for the pie. A size greater than 0 renders a donut chart.
        /// Can be a percentage or pixel value. Percentages are relative to the size of the plot area. Pixel values are given as integers. Defaults to 0.
        /// </summary>
        public JsNumber innerSize { get; set; }
        /// <summary>
        /// The size of the inner diameter for the pie. A size greater than 0 renders a donut chart.
        /// Can be a percentage or pixel value. Percentages are relative to the size of the plot area. Pixel values are given as integers. Defaults to 0.
        /// </summary>
        [JsProperty(Name = "innerSize")]
        public JsString innerSizeString { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public AreaMarkerOptions marker { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// The diameter of the pie relative to the plot area. Can be a percentage or pixel value. Pixel values are given as integers. Defaults to "75%".
        /// </summary>
        [JsProperty(Name = "size")]
        public JsString sizeString { get; set; }
        /// <summary>
        /// The diameter of the pie relative to the plot area. Can be a percentage or pixel value. Pixel values are given as integers. Defaults to "75%".
        /// </summary>
        public JsNumber size { get; set; }

        /// <summary>
        /// If a point is sliced, moved out from the center, how many pixels should it be moved?. Defaults to 10.
        /// </summary>
        public JsNumber slicedOffset { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public AreaStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    #endregion

    #region scatter

    [JsType(JsMode.Json)]
    public class PlotScatterOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }


        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public bool connectNulls { get; set; }

        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public AreaDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// /When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 300.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth. The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public AreaMarkerOptions marker { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public AreaStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    #endregion

    #region series

    /// <summary>
    /// General options for all series types.
    /// </summary>
    [JsType(JsMode.Json)]
    public class PlotSeriesOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Polar charts only. Whether to connect the ends of a line series plot across the extremes. Defaults to true.
        /// </summary>
        public bool connectEnds { get; set; }

        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public bool connectNulls { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 300.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth. The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        public AreaDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public AreaMarkerOptions marker { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// Whether to stack the values of each series on top of each other.
        /// Possible values are null to disable, "normal" to stack by value or "percent". Defaults to null.
        /// </summary>
        public JsString stacking { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public SeriesStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SeriesStatesOptions
    {
        public SeriesStatesHoverOptions hover { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SeriesStatesHoverOptions
    {
        /// <summary>
        /// Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend.	 . Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public SeriesStatesHoverMarkerOptions marker { get; set; }
    }

    [JsType(JsMode.Json)]
    public class SeriesStatesHoverMarkerOptions
    {
        /// <summary>
        /// Enable or disable the point marker. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// The fill color of the point marker. When null, the series' or point's color is used. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// The color of the point marker's outline. When null, the series' or point's color is used. Defaults to "#FFFFFF".
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// The width of the point marker's outline. Defaults to 0.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// The radius of the point marker. Defaults to 0.
        /// </summary>
        public JsNumber radius { get; set; }

        public AreaMarkerStatesOptions states { get; set; }

        /// <summary>
        /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols.
        /// Other possible values are "circle", "square", "diamond", "triangle" and "triangle-down".
        /// Additionally, the URL to a graphic can be given on this form: "url(graphic.png)". Defaults to null.
        /// </summary>
        public JsString symbol { get; set; }
    }

    #endregion

    #region spline

    [JsType(JsMode.Json)]
    public class PlotSplineOptions
    {
        /// <summary>
        /// Allow this series' points to be selected by clicking on the markers, bars or pie slices. Defaults to false.
        /// </summary>
        public bool allowPointSelect { get; set; }

        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        public AnimationOptions animation { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public bool animationBoolean { get; set; }
        /// <summary>
        /// Enable or disable the initial animation when a series is displayed. Since version 2.1, the animation can be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see #chart.animation and the animation parameter under the API methods. The following properties are supported:
        /// duration:
        /// The duration of the animation in milliseconds.
        /// easing:
        /// When using jQuery as the general framework, the easing can be set to linear or swing. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// . For polar charts, the animation is disabled in legacy IE browsers. Defaults to true.
        /// </summary>
        [JsProperty(Name = "animation")]
        public object animationObject { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified.
        /// In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the options.colors array.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// Polar charts only. Whether to connect the ends of a line series plot across the extremes. Defaults to true.
        /// </summary>
        public bool connectEnds { get; set; }

        /// <summary>
        /// Whether to connect a graph line across null points. Defaults to false.
        /// </summary>
        public bool connectNulls { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom.
        /// The advantage of drawing all points (including markers and columns), is that animation is performed on updates.
        /// On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area.
        /// The advantage of cropping away invisible points is to increase performance on large series. . Defaults to 300.
        /// </summary>
        public JsNumber cropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to "pointer" if you have click events attached to the series, to signal to the user that the points and lines can be clicked. Defaults to ''.
        /// </summary>
        public JsString cursor { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in case it has a lineWidth. The value for the dashStyle include:
        /// Solid
        /// ShortDash
        /// ShortDot
        /// ShortDashDot
        /// ShortDashDotDot
        /// Dot
        /// Dash
        /// LongDash
        /// DashDot
        /// LongDashDot
        /// LongDashDotDot
        /// . Defaults to null.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        public AreaDataLabelsOptions dataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series.
        /// This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Defaults to true.
        /// </summary>
        public bool enableMouseTracking { get; set; }

        public PlotAreaEvent events { get; set; }

        /// <summary>
        /// Fill color or gradient for the area. When null, the series' color is used with the series' fillOpacity. Defaults to null.
        /// </summary>
        public JsString fillColor { get; set; }

        /// <summary>
        /// Fill opacity for the area. Defaults to .75.
        /// </summary>
        public JsNumber fillOpacity { get; set; }

        /// <summary>
        /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// A separate color for the graph line. By default the line takes the color of the series,
        /// but the lineColor setting allows setting a separate color for the line without altering the fillColor. Defaults to null.
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// Pixel with of the graph line. Defaults to 2.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        public AreaMarkerOptions marker { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PointOptions point { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointInterval defines the interval of the x values.
        /// For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.
        /// . Defaults to 1.
        /// </summary>
        public JsNumber pointInterval { get; set; }

        /// <summary>
        /// Possible values: null, "on", "between".
        /// In a column chart, when pointPlacement is "on", the point will not create any padding of the X axis.
        /// In a polar column chart this means that the first column points directly north.
        /// If the pointPlacement is "between", the columns will be laid out between ticks.
        /// This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.
        /// Defaults to null in cartesian charts, "between" in polar charts.
        /// </summary>
        public PointPlacementType pointPlacement { get; set; }

        /// <summary>
        /// If no x values are given for the points in a series, pointStart defines on what value to start.
        /// For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Defaults to 0.
        /// </summary>
        public JsNumber pointStart { get; set; }

        /// <summary>
        /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series. Defaults to false.
        /// </summary>
        public bool selected { get; set; }

        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public bool shadowBoolean { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        [JsProperty(Name = "shadow")]
        public object shadowObject { get; set; }
        /// <summary>
        /// The shadow of the box. Works best with borderWidth or backgroundColor.
        /// Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width. Defaults to false.
        /// </summary>
        public ShadowOptions shadow { get; set; }

        /// <summary>
        /// If true, a checkbox is displayed next to the legend item to allow selecting the series.
        /// The state of the checkbox is determined by the selected option. Defaults to false.
        /// </summary>
        public bool showCheckbox { get; set; }

        /// <summary>
        /// Whether to display this particular series or series type in the legend. Defaults to true.
        /// </summary>
        public bool showInLegend { get; set; }

        /// <summary>
        /// Whether to stack the values of each series on top of each other.
        /// Possible values are null to disable, "normal" to stack by value or "percent". Defaults to null.
        /// </summary>
        public JsString stacking { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public AreaStatesOptions states { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events.
        /// When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area.
        /// When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers.
        /// This also implies the tooltip. When stickyTracking is false, the tooltip will be hidden when moving the mouse between series.
        /// Defaults to true.
        /// </summary>
        public bool stickyTracking { get; set; }

        /// <summary>
        /// The Y axis value to serve as the base for the area, for distinguishing between values above and below a threshold. Defaults to 0.
        /// </summary>
        public JsNumber threshold { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip.
        /// Overridable properties are headerFormat, pointFormat, valueDecimals, xDateFormat, valuePrefix and valueSuffix.
        /// Defaults to {}.
        /// </summary>
        public AreaTooltipOptions tooltip { get; set; }

        /// <summary>
        /// Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events. Defaults to false.
        /// </summary>
        public bool trackByArea { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed.
        /// Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Defaults to 1000.
        /// </summary>
        public JsNumber turboThreshold { get; set; }

        /// <summary>
        /// Set the initial visibility of the series. Defaults to true.
        /// </summary>
        public bool visible { get; set; }

        /// <summary>
        /// Define the z index of the series. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    #endregion

    #endregion

    #region series

    /// <summary>
    /// The actual series to append to the chart.
    /// In addition to the members listed below, any member of the plotOptions for that specific type of plot can be added to a series individually.
    /// For example, even though a general lineWidth is specified in plotOptions.series, an individual lineWidth can be specified for each series.
    /// </summary>
    [JsType(JsMode.Json)]
    public class SeriesOptions
    {
        /// <summary>
        /// An array of data points for the series. The points can be given in three ways:
        /// A list of numerical values. In this case, the numberical values will be interpreted and y values,
        /// and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from pointStart and pointInterval given in the plotOptions.
        /// If the axis is has categories, these will be used. This option is not available for range series. Example:
        /// data: [0, 5, 3, 5]
        /// A list of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.
        /// 
        /// For range series, the arrays will be interpreted as [x, low, high]. In this cases, the X value can be skipped altogether to make use of pointStart and pointRange.
        /// 
        /// Example:
        /// data: [[5, 2], [6, 3], [8, 2]]
        /// A list of object with named values. In this case the objects are point configuration objects as seen below.
        /// 
        /// Range series values are given by low and high.
        /// 
        /// Example:
        /// data: [{
        /// 	name: 'Point 1',
        /// 	color: '#00FF00',
        /// 	y: 0
        /// }, {
        /// 	name: 'Point 2',
        /// 	color: '#FF00FF',
        /// 	y: 5
        /// }]
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// *Deprecated*
        /// This method is deprecated as of version 2.0. Instead, use options preprocessing as described in the how-to, section #3.
        /// </summary>
        public JsAction dataParser { get; set; }

        /// <summary>
        /// *Deprecated*
        /// This method is deprecated as of version 2.0. Instead, load the data using jQuery.ajax and use options preprocessing as described in the how-to, section #3. Defaults to null.
        /// </summary>
        public JsString dataURL { get; set; }

        /// <summary>
        /// The index of the series in the chart, affecting the internal index in the chart.series array, the visible Z index as well as the order in the legend.
        /// Defaults to undefined.
        /// </summary>
        public JsNumber index { get; set; }

        /// <summary>
        /// The sequential index of the series in the legend.
        /// </summary>
        public JsNumber legendIndex { get; set; }

        /// <summary>
        /// The name of the series as shown in the legend, tooltip etc. Defaults to "".
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// This option allows grouping series in a stacked chart.
        /// The stack option can be a string or a number or anything else, as long as the grouped series' stack options match each other. Defaults to null.
        /// </summary>
        public object stack { get; set; }

        /// <summary>
        /// The type of series. Can be one of area, areaspline, bar, column, line, pie, scatter or spline.
        /// From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component. Defaults to "line".
        /// </summary>
        public TypeOptions type { get; set; }

        /// <summary>
        /// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to.
        /// It refers to the index of the axis in the xAxis array, with 0 being the first. Defaults to 0.
        /// </summary>
        public JsNumber xAxis { get; set; }

        /// <summary>
        /// When using dual or multiple y axes, this number defines which yAxis the particular series is connected to.
        /// It refers to the index of the axis in the yAxis array, with 0 being the first. Defaults to 0.
        /// </summary>
        public JsNumber yAxis { get; set; }
    }

    /// <summary>
    /// An array of data points for the series. The points can be given in three ways:
    /// A list of numerical values. In this case, the numberical values will be interpreted and y values, and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from pointStart and pointInterval given in the plotOptions. If the axis is has categories, these will be used. This option is not available for range series. Example:
    /// data: [0, 5, 3, 5]
    /// A list of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.
    /// 
    /// For range series, the arrays will be interpreted as [x, low, high]. In this cases, the X value can be skipped altogether to make use of pointStart and pointRange.
    /// 
    /// Example:
    /// data: [[5, 2], [6, 3], [8, 2]]
    /// A list of object with named values. In this case the objects are point configuration objects as seen below.
    /// 
    /// Range series values are given by low and high.
    /// 
    /// Example:
    /// data: [{
    /// 	name: 'Point 1',
    /// 	color: '#00FF00',
    /// 	y: 0
    /// }, {
    /// 	name: 'Point 2',
    /// 	color: '#FF00FF',
    /// 	y: 5
    /// }]
    /// </summary>
    [JsType(JsMode.Json)]
    public class SeriesDataOptions
    {
        /// <summary>
        /// Individual color for the point. Defaults to null.
        /// </summary>
        public object color { get; set; }

        /// <summary>
        /// Individual data label for each point. The options are the same as the ones for plotOptions.series.dataLabels
        /// </summary>
        public object dataLabels { get; set; }
        //TODO: (FOR MAY) change type to plotOptions.series.dataLabels after creating the class

        /// <summary>
        /// An id for the point. This can be used after render time to get a pointer to the point object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Pies only. The sequential index of the pie slice in the legend.	 . Defaults to undefined.
        /// </summary>
        public JsNumber legendIndex { get; set; }

        /// <summary>
        /// The name of the point as shown in the legend, tooltip, dataLabel etc. Defaults to "".
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// Pie series only. Whether to display a slice offset from the center. Defaults to false.
        /// </summary>
        public bool sliced { get; set; }

        /// <summary>
        /// The x value of the point. Defaults to null.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y value of the point. Defaults to null.
        /// </summary>
        public JsNumber y { get; set; }

        public PlotAreaEvent events { get; set; }
    }

    #endregion

    #region subtitle

    /// <summary>
    /// The chart's subtitle
    /// </summary>
    [JsType(JsMode.Json)]
    public class SubtitleOptions
    {
        /// <summary>
        /// The horizontal alignment of the subtitle. Can be one of "left", "center" and "right". Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// When the subtitle is floating, the plot area will not move to make space for it. Defaults to false.
        /// </summary>
        public bool floating { get; set; }

        /// <summary>
        /// CSS styles for the title. Exact positioning of the title can be achieved by changing the margin property, or by adding position: "absolute" and left and top properties. Defaults to:
        /// {
        /// 	color: '#3E576F'
        /// }
        /// </summary>
        public object style { get; set; }
        //TODO: type

        /// <summary>
        /// The subtitle of the chart. Defaults to "".
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        /// The vertical alignment of the title. Can be one of "top", "middle" and "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The x position of the subtitle relative to the alignment within chart.spacingLeft and chart.spacingRight. Defaults to 0.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y position of the subtitle relative to the alignment within chart.spacingTop and chart.spacingBottom. Defaults to 30.
        /// </summary>
        public JsNumber y { get; set; }
    }

    /// <summary>
    /// The horizontal alignment. Can be one of "left", "center" and "right". Defaults to "center".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum HorizontalAlignType
    {
        left,
        center,
        right,
    }

    #endregion

    #region title

    /// <summary>
    /// The chart's main title.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TitleOptions
    {
        /// <summary>
        /// The horizontal alignment of the title. Can be one of "left", "center" and "right". Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// When the title is floating, the plot area will not move to make space for it. Defaults to false.
        /// </summary>
        public bool floating { get; set; }

        /// <summary>
        /// The margin between the title and the plot area, or if a subtitle is present, the margin between the subtitle and the plot area. Defaults to 15.
        /// </summary>
        public JsNumber margin { get; set; }

        /// <summary>
        /// CSS styles for the title. Use this for font styling, but use align, x and yfor text alignment. Defaults to:
        /// {
        /// 	color: '#3E576F',
        /// 	fontSize: '16px'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The title of the chart. To disable the title, set the text to null. Defaults to "Chart title".
        /// </summary>
        public JsString text { get; set; }

        /// <summary>
        /// The vertical alignment of the title. Can be one of "top", "middle" and "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight. Defaults to 0.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y position of the title relative to the alignment within chart.spacingTop and chart.spacingBottom. Defaults to 15.
        /// </summary>
        public JsNumber y { get; set; }
    }

    #endregion

    #region tooltip

    /// <summary>
    /// Options for the tooltip that appears when the user hovers over a series or point.
    /// </summary>
    [JsType(JsMode.Json)]
    public class TooltipOptions
    {

        /// <summary>
        /// Enable or disable animation of the tooltip. In old browsers combined with data-heavy charts, the animation may be slow, so turning it off can be a good idea.
        /// Defaults to true.
        /// </summary>
        public bool animation { get; set; }

        /// <summary>
        /// The background color or gradient for the tooltip. Defaults to "rgba(255, 255, 255, .85)". Defaults to "rgba(255 255, 255, .85)",.
        /// </summary>
        public JsString backgroundColor { get; set; }

        /// <summary>
        /// The color of the tooltip border. When null, the border takes the color of the corresponding series or point. Defaults to "auto".
        /// </summary>
        public JsString borderColor { get; set; }

        /// <summary>
        /// The radius of the rounded border corners. Defaults to 5.
        /// </summary>
        public JsNumber borderRadius { get; set; }

        /// <summary>
        /// The pixel width of the tooltip border. Defaults to 2.
        /// </summary>
        public JsNumber borderWidth { get; set; }

        /// <summary>
        /// Display crosshairs to connect the points with their corresponding axis values. The crosshairs can be defined as a boolean, an array of booleans or an object.
        /// Boolean:
        /// If the crosshairs option is true, a single crosshair relating to the x axis will be shown.
        /// Array of booleans:
        /// In an array of booleans, the first value turns on the x axis crosshair and the second value to the y axis crosshair. Use [true, true] to show complete crosshairs.
        /// Array of objects:
        /// In an array of objects, the first value applies to the x axis crosshair and the second value to the y axis crosshair. For each dimension, a width, color, dashStyle and zIndex can be given.
        /// Defaults to null. Defaults to null.
        /// </summary>
        [JsProperty(Name = "crosshairs")]
        public bool crosshairsBoolean { get; set; }
        /// <summary>
        /// Display crosshairs to connect the points with their corresponding axis values. The crosshairs can be defined as a boolean, an array of booleans or an object.
        /// Boolean:
        /// If the crosshairs option is true, a single crosshair relating to the x axis will be shown.
        /// Array of booleans:
        /// In an array of booleans, the first value turns on the x axis crosshair and the second value to the y axis crosshair. Use [true, true] to show complete crosshairs.
        /// Array of objects:
        /// In an array of objects, the first value applies to the x axis crosshair and the second value to the y axis crosshair. For each dimension, a width, color, dashStyle and zIndex can be given.
        /// Defaults to null. Defaults to null.
        /// </summary>
        [JsProperty(Name = "crosshairs")]
        public JsArray<bool> crosshairsBooleanArray { get; set; }
        /// <summary>
        /// Display crosshairs to connect the points with their corresponding axis values. The crosshairs can be defined as a boolean, an array of booleans or an object.
        /// Boolean:
        /// If the crosshairs option is true, a single crosshair relating to the x axis will be shown.
        /// Array of booleans:
        /// In an array of booleans, the first value turns on the x axis crosshair and the second value to the y axis crosshair. Use [true, true] to show complete crosshairs.
        /// Array of objects:
        /// In an array of objects, the first value applies to the x axis crosshair and the second value to the y axis crosshair. For each dimension, a width, color, dashStyle and zIndex can be given.
        /// Defaults to null. Defaults to null.
        /// </summary>
        [JsProperty(Name = "crosshairs")]
        public JsArray<object> crosshairsObjectArray { get; set; }

        /// <summary>
        /// Enable or disable the tooltip. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// A string to append to the tooltip format. Defaults to false.
        /// </summary>
        public JsString footerFormat { get; set; }

        /// <summary>
        /// Callback function to format the text of the tooltip. Return false to disable tooltip for a specific point on series.
        /// A subset of HTML is supported. The HTML of the tooltip is parsed and converted to SVG, therefore this isn't a complete HTML renderer.
        /// The following tabs are supported: &lt;b>, &lt;strong>, &lt;i>, &lt;em>, &lt;br/>, &lt;span>.
        /// Spans can be styled with a style attribute, but only text-related CSS that is shared with SVG is handled.
        /// Since version 2.1 the tooltip can be shared between multiple series through the shared option.
        /// The available data in the formatter differ a bit depending on whether the tooltip is shared or not. In a shared tooltip, all properties except x, which is common for all points, are kept in an array, this.points.
        /// Available data are:
        /// this.percentage (not shared) / this.points[i].percentage (shared)
        /// Stacked series and pies only. The point's percentage of the total.
        /// this.point (not shared) / this.points[i].point (shared)
        /// The point object. The point name, if defined, is available through this.point.name.
        /// this.points
        /// In a shared tooltip, this is an array containing all other properties for each point.
        /// this.series (not shared) / this.points[i].series (shared)
        /// The series object. The series name is available through this.series.name.
        /// this.total (not shared) / this.points[i].total (shared)
        /// Stacked series only. The total value at this point's x value.
        /// this.x
        /// The x value. This property is the same regardless of the tooltip being shared or not.
        /// this.y (not shared) / this.points[i].y (shared)
        /// The y value.
        /// </summary>
        public JsAction formatter { get; set; }

        /// <summary>
        /// The HTML of the point's line in the tooltip. Variables are enclosed by curly brackets.
        /// Available variables are point.x, point.y, series.name and series.color and other properties on the same form.
        /// Furthermore, point.y can be extended by the tooltip.yPrefix and tooltip.ySuffix variables.
        /// This can also be overridden for each series, which makes it a good hook for displaying units.
        /// Defaults to &lt;span style="color:{series.color}">{series.name}&lt;/span>: &lt;b>{point.y}&lt;/b>&lt;br/>
        /// </summary>
        public JsString pointFormat { get; set; }

        /// <summary>
        /// A callback function to place the tooltip in a default position.
        /// The callback receives three parameters: labelWidth, labelHeight and point,
        /// where point contains values for plotX and plotY telling where the reference point is in the plot area.
        /// The return should be an object containing x and y values, for example { x: 100, y: 100 }.
        /// </summary>
        public JsAction positioner { get; set; }
        //TODO: this is a complicted stuff.  danel reed summary

        /// <summary>
        /// Whether to apply a drop shadow to the tooltip. Defaults to true.
        /// </summary>
        public bool shadow { get; set; }

        /// <summary>
        /// When the tooltip is shared, the entire plot area will capture mouse movement, and tooltip texts for all series will be shown in a single bubble.
        /// This is recommended for single series charts and for iPad optimized sites. Defaults to false.
        /// </summary>
        public bool shared { get; set; }

        /// <summary>
        /// Proximity snap for graphs or single points. Does not apply to bars, columns and pie slices.
        /// It defaults to 10 for mouse-powered devices and 25 for touch devices. Defaults to 10/25.
        /// </summary>
        public JsNumber snap { get; set; }

        /// <summary>
        /// CSS styles for the tooltip. The tooltip can also be styled through the CSS class .highcharts-tooltip. Default value:
        /// style: {
        /// 	color: '#333333',
        /// 	fontSize: '9pt',
        /// 	padding: '5px'
        /// }
        /// </summary>
        public object style { get; set; }

        /// <summary>
        /// Use HTML to render the contents of the tooltip instead of SVG. Using HTML allows advanced formatting like tables and images in the tooltip.
        /// It is also recommended for rtl languages as it works around rtl bugs in early Firefox. Defaults to false.
        /// </summary>
        public bool useHTML { get; set; }

        /// <summary>
        /// How many decimals to show in each series' y value. This is overridable in each series' tooltip options object. The default is to preserve all decimals.
        /// </summary>
        public JsNumber valueDecimals { get; set; }

        /// <summary>
        /// A string to prepend to each series' y value. Overridable in each series' tooltip options object. Defaults to "".
        /// </summary>
        public JsString valuePrefix { get; set; }

        /// <summary>
        /// A string to append to each series' y value. Overridable in each series' tooltip options object. Defaults to "".
        /// </summary>
        public JsString valueSuffix { get; set; }

        /// <summary>
        /// The format for the date in the tooltip header if the X axis is a datetime axis.
        /// The default is a best guess based on the smallest distance between points in the chart.
        /// </summary>
        public JsString xDateFormat { get; set; }
    }

    #endregion

    #region xAxis

    /// <summary>
    /// The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.
    /// In case of multiple axes, the xAxis node is an array of configuration objects.
    /// See the Axis object for programmatic access to the axis.
    /// </summary>
    [JsType(JsMode.Json)]
    public class XAxisOptions
    {
        /// <summary>
        /// Whether to allow decimals in this axis' ticks.
        /// When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels. Defaults to true.
        /// </summary>
        public bool allowDecimals { get; set; }

        /// <summary>
        /// When using an alternate grid color, a band is painted across the plot area between every other grid line. Defaults to null.
        /// </summary>
        public JsString alternateGridColor { get; set; }

        /// <summary>
        /// If categories are present for the xAxis, names are used instead of numbers for that axis. Example:
        /// categories: ['Apples', 'Bananas', 'Oranges']
        /// Defaults to []. Defaults to [].
        /// </summary>
        public JsArray categories { get; set; }

        /// <summary>
        /// For a datetime axis, the scale will automatically adjust to the appropriate unit.
        /// This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:
        /// {
        /// 	second: '%H:%M:%S',
        /// 	minute: '%H:%M',
        /// 	hour: '%H:%M',
        /// 	day: '%e. %b',
        /// 	week: '%e. %b',
        /// 	month: '%b \'%y',
        /// 	year: '%Y'
        /// }
        /// </summary>
        public object dateTimeLabelFormats { get; set; }

        /// <summary>
        /// Whether to force the axis to end on a tick. Use this option with the maxPadding option to control the axis end. Defaults to false.
        /// </summary>
        public bool endOnTick { get; set; }

        /// <summary>
        /// Event handlers for the axis.
        /// </summary>
        public AxisEvent events { get; set; }

        /// <summary>
        /// Color of the grid lines extending the ticks across the plot area. Defaults to "#C0C0C0".
        /// </summary>
        public JsString gridLineColor { get; set; }

        /// <summary>
        /// The dash or dot style of the grid lines. For possible values, see this demonstration. Defaults to Solid.
        /// </summary>
        public DashStyleType gridLineDashStyle { get; set; }

        /// <summary>
        /// The width of the grid lines extending the ticks across the plot area. Defaults to 0.
        /// </summary>
        public JsNumber gridLineWidth { get; set; }

        /// <summary>
        /// An id for the axis. This can be used after render time to get a pointer to the axis object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The axis labels show the number or category for each tick.
        /// </summary>
        public XAxisLabelsOptions labels { get; set; }

        /// <summary>
        /// The color of the line marking the axis itself. Defaults to "#C0D0E0".
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// The width of the line marking the axis itself. Defaults to 1.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// Index of another axis that this axis is linked to.
        /// When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes.
        /// It can be used to show additional info, or to ease reading the chart by duplicating the scales. Defaults to null.
        /// </summary>
        public JsNumber linkedTo { get; set; }

        /// <summary>
        /// The maximum value of the axis. If null, the max value is automatically calculated. If the endOnTick option is true, the max value might be rounded up.
        /// The actual maximum value is also influenced by chart.alignTicks. Defaults to null.
        /// </summary>
        public JsNumber max { get; set; }

        /// <summary>
        /// Padding of the max value relative to the length of the axis.
        /// A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area.
        /// When the axis' max option is set or a max extreme is set using axis.setExtremes(), the maxPadding will be ignored. Defaults to 0.01.
        /// </summary>
        public JsNumber maxPadding { get; set; }

        /// <summary>
        /// Deprecated. Renamed to minRange as of Highcharts 2.2.
        /// </summary>
        public JsNumber maxZoom { get; set; }

        /// <summary>
        /// The minimum value of the axis.
        /// If null the min value is automatically calculated. If the startOnTick option is true, the min value might be rounded down. Defaults to null.
        /// </summary>
        public JsNumber min { get; set; }

        /// <summary>
        /// Padding of the min value relative to the length of the axis.
        /// A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area.
        /// When the axis' min option is set or a min extreme is set using axis.setExtremes(), the minPadding will be ignored. Defaults to 0.01.
        /// </summary>
        public JsNumber minPadding { get; set; }

        /// <summary>
        /// The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this.
        /// For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour.
        /// The default minRange for the x axis is five times the smallest interval between any of the data points.
        /// On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.
        /// </summary>
        public JsNumber minRange { get; set; }

        /// <summary>
        /// The minimum tick interval allowed in axis values.
        /// For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to undefined.
        /// </summary>
        public JsNumber minTickInterval { get; set; }

        /// <summary>
        /// Color of the minor, secondary grid lines. Defaults to #E0E0E0.
        /// </summary>
        public JsString minorGridLineColor { get; set; }

        /// <summary>
        /// The dash or dot style of the minor grid lines. For possible values, see this demonstration. Defaults to Solid.
        /// </summary>
        public DashStyleType minorGridLineDashStyle { get; set; }

        /// <summary>
        /// Width of the minor, secondary grid lines. Defaults to 1.
        /// </summary>
        public JsNumber minorGridLineWidth { get; set; }

        /// <summary>
        /// Color for the minor tick marks. Defaults to #A0A0A0.
        /// </summary>
        public JsString minorTickColor { get; set; }

        /// <summary>
        /// Tick interval in scale units for the minor ticks.
        /// On a linear axis, if "auto", the minor tick interval is calculated as a fifth of the tickInterval. If null, minor ticks are not shown.
        /// On logarithmic axes, the unit is the power of the value.
        /// For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10, 10 and 100 etc.
        /// A minorTickInterval of "auto" on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.
        /// . Defaults to null.
        /// </summary>
        public JsNumber minorTickInterval { get; set; }

        /// <summary>
        /// The pixel length of the minor tick marks. Defaults to 2.
        /// </summary>
        public JsNumber minorTickLength { get; set; }

        /// <summary>
        /// The position of the minor tick marks relative to the axis line. Can be one of inside and outside. Defaults to outside.
        /// </summary>
        public TickPositionType minorTickPosition { get; set; }

        /// <summary>
        /// The pixel width of the minor tick mark. Defaults to 0.
        /// </summary>
        public JsNumber minorTickWidth { get; set; }

        /// <summary>
        /// The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area.
        /// This is typically used when two or more axes are displayed on the same side of the plot. Defaults to 0.
        /// </summary>
        public JsNumber offset { get; set; }

        /// <summary>
        /// Whether to display the axis on the opposite side of the normal.
        /// The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively.
        /// This is typically used with dual or multiple axes. Defaults to false.
        /// </summary>
        public bool opposite { get; set; }

        /// <summary>
        /// A colored band stretching across the plot area marking an interval on the axis.
        /// </summary>
        public AxisPlotBandsOptions plotBands { get; set; }

        /// <summary>
        /// A line streching across the plot area, marking a specific value on one of the axes.
        /// </summary>
        public AxisPlotLinesOptions plotLines { get; set; }

        /// <summary>
        /// Whether to reverse the axis so that the highest number is closest to origo. If the chart is inverted, the x axis is reversed by default. Defaults to false.
        /// </summary>
        public bool reversed { get; set; }

        /// <summary>
        /// Whether to show the axis line and title when the axis has no data. Defaults to true.
        /// </summary>
        public bool showEmpty { get; set; }

        /// <summary>
        /// Whether to show the first tick label. Defaults to true.
        /// </summary>
        public bool showFirstLabel { get; set; }

        /// <summary>
        /// Whether to show the last tick label. Defaults to false.
        /// </summary>
        public bool showLastLabel { get; set; }

        /// <summary>
        /// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday. Defaults to 1.
        /// </summary>
        public JsNumber startOfWeek { get; set; }

        /// <summary>
        /// Whether to force the axis to start on a tick. Use this option with the maxPadding option to control the axis start. Defaults to false.
        /// </summary>
        public bool startOnTick { get; set; }

        /// <summary>
        /// Color for the main tick marks. Defaults to #C0D0E0.
        /// </summary>
        public JsString tickColor { get; set; }

        /// <summary>
        /// The interval of the tick marks in axis units. When null, the tick interval is computed to approximately follow the tickPixelInterval on linear and datetime axes.
        /// On categorized axes, a null tickInterval will default to 1, one category.
        /// Note that datetime axes are based on milliseconds, so for example an interval of one day is expressed as 24 * 3600 * 1000.
        /// On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means one tick on each of 0.1, 1, 10, 100 etc.
        /// A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.
        /// . Defaults to null.
        /// </summary>
        public JsNumber tickInterval { get; set; }

        /// <summary>
        /// The pixel length of the main tick marks. Defaults to 5.
        /// </summary>
        public JsNumber tickLength { get; set; }

        /// <summary>
        /// If tickInterval is null this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis.
        /// Defaults to 72 for the Y axis and 100 for	the X axis.
        /// </summary>
        public JsNumber tickPixelInterval { get; set; }

        /// <summary>
        /// The position of the major tick marks relative to the axis line. Can be one of inside and outside. Defaults to "outside".
        /// </summary>
        public TickPositionType tickPosition { get; set; }

        /// <summary>
        /// The pixel width of the major tick marks. Defaults to 1.
        /// </summary>
        public JsNumber tickWidth { get; set; }

        /// <summary>
        /// For categorized axes only. If "on" the tick mark is placed in the center of the category, if "between" the tick mark is placed between categories. Defaults to "between".
        /// </summary>
        public JsString tickmarkPlacement { get; set; }

        /// <summary>
        /// The axis title, showing next to the axis line.
        /// </summary>
        public AxisTitleOptions title { get; set; }

        /// <summary>
        /// The type of axis. Can be one of "linear", "logarithmic" or "datetime". In a datetime axis, the numbers are given in milliseconds,
        /// and tick marks are placed on appropriate values like full hours or days. Defaults to "linear".
        /// </summary>
        public AxisType type { get; set; }

    }

    /// <summary>
    /// Event handlers for the axis.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AxisEvent
    {
        /// <summary>
        /// Fires when the minimum and maximum is set for the axis, either by calling the .setExtremes() method or by selecting an area in the chart.
        /// The this keyword refers to the axis object itself.
        /// One parameter, event, is passed to the function.
        /// This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.
        /// The new user set minimum and maximum values can be found by event.min and event.max.
        /// </summary>
        public JsAction<object> setExtremes { get; set; }
    }

    /// <summary>
    /// The axis labels show the number or category for each tick.
    /// </summary>
    [JsType(JsMode.Json)]
    public class XAxisLabelsOptions
    {
        /// <summary>
        /// What part of the string the given position is anchored to.
        /// Can be one of "left", "center" or "right". In inverted charts, x axis label alignment and y axis alignment are swapped. Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// Enable or disable the axis labels. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Callback JavaScript function to format the label. The value is given by this.value.
        /// Additional properties for this are axis, chart, isFirst and isLast. Defaults to:
        /// function() {
        /// 	return this.value;
        /// }
        /// </summary>
        public JsAction formatter { get; set; }
        //TODO: Callback JavaScript function (REED SUMMARY)

        /// <summary>
        /// How to handle overflowing labels on horizontal axis. Can be undefined or "justify". If "justify", labels will not render outside the plot area.
        /// If there is room to move it, it will be aligned to the edge, else it will be removed. Defaults to undefined.
        /// </summary>
        public JsString overflow { get; set; }

        /// <summary>
        /// Rotation of the labels in degrees. Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels. . Defaults to null.
        /// </summary>
        public JsNumber staggerLines { get; set; }

        /// <summary>
        /// To show only every n'th label on the axis, set the step to n. Setting the step to 2 shows every other label. Defaults to null.
        /// </summary>
        public JsNumber step { get; set; }

        /// <summary>
        /// CSS styles for the label. Defaults to:
        /// style: {
        /// 	color: '#6D869F',
        /// 	fontWeight: 'bold'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The x position offset of the label relative to the tick position on the axis. Defaults to 0.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y position offset of the label relative to the tick position on the axis. Defaults to 0.
        /// </summary>
        public JsNumber y { get; set; }
    }

    /// <summary>
    /// The position of the minor tick marks relative to the axis line. Can be one of inside and outside
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TickPositionType
    {
        inside,
        outside,
    }

    /// <summary>
    /// A colored band stretching across the plot area marking an interval on the axis.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AxisPlotBandsOptions
    {

        /// <summary>
        /// The color of the plot band. Defaults to null.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// An object defining mouse events for the plot band. Supported properties are click, mouseover, mouseout, mousemove.
        /// </summary>
        public PlotBandsEventsOptions events { get; set; }

        /// <summary>
        /// The start position of the plot band in axis units. Defaults to null.
        /// </summary>
        public JsNumber from { get; set; }

        /// <summary>
        /// An id used for identifying the plot band in Axis.removePlotBand. Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Text labels for the plot bands
        /// </summary>
        public PlotBandsLabelOptions label { get; set; }

        /// <summary>
        /// The end position of the plot band in axis units. Defaults to null.
        /// </summary>
        public JsNumber to { get; set; }

        /// <summary>
        /// The z index of the plot band within the chart. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    [JsType(JsMode.Json)]
    public class PlotBandsEventsOptions
    {
        public JsAction click { get; set; }
        public JsAction mouseover { get; set; }
        public JsAction mouseout { get; set; }
        public JsAction mousemove { get; set; }
    }

    /// <summary>
    /// Text labels for the plot bands
    /// </summary>
    [JsType(JsMode.Json)]
    public class PlotBandsLabelOptions
    {
        /// <summary>
        /// Horizontal alignment of the label. Can be one of "left", "center" or "right". Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// Rotation of the text label in degrees . Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// CSS styles for the text label.
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The string text itself. A subset of HTML is supported.
        /// </summary>
        public TextAlignType textAlign { get; set; }

        /// <summary>
        /// Vertical alignment of the label relative to the plot band. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// Horizontal position relative the alignment. Default varies by orientation.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
        /// </summary>
        public JsNumber y { get; set; }
    }

    /// <summary>
    /// The text alignment for the label. While align determines where the texts anchor point is placed within the plot band,
    /// textAlign determines how the text is aligned against its anchor point.
    /// Possible values are "left", "center" and "right".
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum TextAlignType
    {
        left,
        center,
        right,
    }

    /// <summary>
    /// A line streching across the plot area, marking a specific value on one of the axes.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AxisPlotLinesOptions
    {

        /// <summary>
        /// The color of the line. Defaults to null.
        /// </summary>
        public JsString color { get; set; }

        /// <summary>
        /// The dashing or dot style for the plot line. For possible values see this overview. Defaults to Solid.
        /// </summary>
        public DashStyleType dashStyle { get; set; }

        /// <summary>
        /// An object defining mouse events for the plot line. Supported properties are click, mouseover, mouseout, mousemove.
        /// </summary>
        public PlotBandsEventsOptions events { get; set; }

        /// <summary>
        /// An id used for identifying the plot line in Axis.removePlotLine. Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// Text labels for the plot bands
        /// </summary>
        public PlotLinesLabelOptions label { get; set; }

        /// <summary>
        /// The position of the line in axis units. Defaults to null.
        /// </summary>
        public JsNumber value { get; set; }

        /// <summary>
        /// The width or thickness of the plot line. Defaults to null.
        /// </summary>
        public JsNumber width { get; set; }

        /// <summary>
        /// The z index of the plot line within the chart. Defaults to null.
        /// </summary>
        public JsNumber zIndex { get; set; }
    }

    /// <summary>
    /// Text labels for the plot bands
    /// </summary>
    [JsType(JsMode.Json)]
    public class PlotLinesLabelOptions
    {
        /// <summary>
        /// Horizontal alignment of the label. Can be one of "left", "center" or "right". Defaults to "center".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// Rotation of the text label in degrees. Defaults to 0 for horizontal plot lines and 90 for vertical lines.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// CSS styles for the text label.
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The text alignment for the label.
        /// While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point.
        /// Possible values are "left", "center" and "right". Defaults to the same as the align option.
        /// </summary>
        public TextAlignType textAlign { get; set; }

        /// <summary>
        /// Vertical alignment of the label relative to the plot band. Can be one of "top", "middle" or "bottom". Defaults to "top".
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// Horizontal position relative the alignment. Default varies by orientation.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
        /// </summary>
        public JsNumber y { get; set; }
    }

    /// <summary>
    /// The axis title, showing next to the axis line.
    /// </summary>
    [JsType(JsMode.Json)]
    public class AxisTitleOptions
    {
        /// <summary>
        /// Alignment of the title relative to the axis values. Possible values are "low", "middle" or "high". Defaults to "middle".
        /// </summary>
        public AxisTitleAlignType align { get; set; }

        /// <summary>
        /// Deprecated. Set the text to null to disable the title.
        /// </summary>
        [Obsolete]
        public JsString enabled { get; set; }

        /// <summary>
        /// The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical
        /// </summary>
        public JsNumber margin { get; set; }

        /// <summary>
        /// The distance of the axis title from the axis line.
        /// By default, this distance is computed from the offset width of the labels, the labels' distance from the axis and the title's margin.
        /// However when the offset option is set, it overrides all this. Defaults to undefined.
        /// </summary>
        public JsNumber offset { get; set; }

        /// <summary>
        /// The rotation of the text in degrees. 0 is horizontal, 270 is vertical reading from bottom to top. Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// CSS styles for the title. When titles are rotated they are rendered using vector graphic techniques and not all styles are applicable. Most noteworthy, a bug in IE8 renders all rotated strings bold and italic. Defaults to:
        /// style: {
        /// 	color: '#6D869F',
        /// 	fontWeight: 'bold'
        /// }
        /// </summary>
        public object style { get; set; }

        /// <summary>
        /// The actual text of the axis title. It can contain basic HTML text markup like &lt;b>, &lt;i> and spans with style. Defaults to null.
        /// </summary>
        public JsString text { get; set; }
    }

    /// <summary>
    /// Alignment of the title relative to the axis values. Possible values are "low", "middle" or "high". 
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum AxisTitleAlignType
    {
        low,
        middle,
        high,
    }

    /// <summary>
    /// The type of axis. Can be one of "linear", "logarithmic" or "datetime".
    /// In a datetime axis, the numbers are given in milliseconds, and tick marks are placed on appropriate values like full hours or days
    /// </summary>
    [JsType(JsMode.Json)]
    [JsEnum(ValuesAsNames = true)]
    public enum AxisType
    {
        linear,
        logarithmic,
        datetime,
    }

    #endregion

    #region yAxis

    /// <summary>
    /// The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis.
    /// In case of multiple axes, the yAxis node is an array of configuration objects.
    /// See the Axis object for programmatic access to the axis.
    /// </summary>
    [JsType(JsMode.Json)]
    public class YAxisOptions
    {
        /// <summary>
        /// Whether to allow decimals in this axis' ticks.
        /// When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels. Defaults to true.
        /// </summary>
        public bool allowDecimals { get; set; }

        /// <summary>
        /// When using an alternate grid color, a band is painted across the plot area between every other grid line. Defaults to null.
        /// </summary>
        public JsString alternateGridColor { get; set; }

        /// <summary>
        /// If categories are present for the xAxis, names are used instead of numbers for that axis. Example:
        /// categories: ['Apples', 'Bananas', 'Oranges']
        /// Defaults to [].
        /// </summary>
        public JsArray categories { get; set; }

        /// <summary>
        /// For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:
        /// {
        /// 	second: '%H:%M:%S',
        /// 	minute: '%H:%M',
        /// 	hour: '%H:%M',
        /// 	day: '%e. %b',
        /// 	week: '%e. %b',
        /// 	month: '%b \'%y',
        /// 	year: '%Y'
        /// }
        /// </summary>
        public object dateTimeLabelFormats { get; set; }

        /// <summary>
        /// Whether to force the axis to end on a tick. Use this option with the maxPadding option to control the axis end. Defaults to true.
        /// </summary>
        public bool endOnTick { get; set; }

        /// <summary>
        /// Event handlers for the axis.
        /// </summary>
        public AxisEvent events { get; set; }

        /// <summary>
        /// Color of the grid lines extending the ticks across the plot area. Defaults to "#C0C0C0".
        /// </summary>
        public JsString gridLineColor { get; set; }

        /// <summary>
        /// The dash or dot style of the grid lines. For possible values, see this demonstration. Defaults to Solid.
        /// </summary>
        public DashStyleType gridLineDashStyle { get; set; }

        /// <summary>
        /// The width of the grid lines extending the ticks across the plot area. Defaults to 1.
        /// </summary>
        public JsNumber gridLineWidth { get; set; }

        /// <summary>
        /// An id for the axis. This can be used after render time to get a pointer to the axis object through chart.get(). Defaults to null.
        /// </summary>
        public JsString id { get; set; }

        /// <summary>
        /// The axis labels show the number or category for each tick.
        /// </summary>
        public YAxisLabelsOptions labels { get; set; }

        /// <summary>
        /// The color of the line marking the axis itself. Defaults to "#C0D0E0".
        /// </summary>
        public JsString lineColor { get; set; }

        /// <summary>
        /// The width of the line marking the axis itself. Defaults to 0.
        /// </summary>
        public JsNumber lineWidth { get; set; }

        /// <summary>
        /// Index of another axis that this axis is linked to.
        /// When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes.
        /// It can be used to show additional info, or to ease reading the chart by duplicating the scales. Defaults to null.
        /// </summary>
        public JsNumber linkedTo { get; set; }

        /// <summary>
        /// The maximum value of the axis. If null, the max value is automatically calculated. If the endOnTick option is true, the max value might be rounded up.
        /// The actual maximum value is also influenced by chart.alignTicks. Defaults to null.
        /// </summary>
        public JsNumber max { get; set; }

        /// <summary>
        /// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer.
        /// This is useful when you don't want the highest data value to appear on the edge of the plot area. Defaults to 0.05.
        /// </summary>
        public JsNumber maxPadding { get; set; }

        /// <summary>
        /// Deprecated. Renamed to minRange as of Highcharts 2.2.
        /// </summary>
        public JsNumber maxZoom { get; set; }

        /// <summary>
        /// The minimum value of the axis.
        /// If null the min value is automatically calculated. If the startOnTick option is true, the min value might be rounded down. Defaults to null.
        /// </summary>
        public JsNumber min { get; set; }

        /// <summary>
        /// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer.
        /// This is useful when you don't want the lowest data value to appear on the edge of the plot area. Defaults to 0.05.
        /// </summary>
        public JsNumber minPadding { get; set; }

        /// <summary>
        /// The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this.
        /// For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour.
        /// The default minRange for the x axis is five times the smallest interval between any of the data points.
        /// On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.
        /// </summary>
        public JsNumber minRange { get; set; }

        /// <summary>
        /// The minimum tick interval allowed in axis values.
        /// For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to undefined.
        /// </summary>
        public JsNumber minTickInterval { get; set; }

        /// <summary>
        /// Color of the minor, secondary grid lines. Defaults to #E0E0E0.
        /// </summary>
        public JsString minorGridLineColor { get; set; }

        /// <summary>
        /// The dash or dot style of the minor grid lines. For possible values, see this demonstration. Defaults to Solid.
        /// </summary>
        public DashStyleType minorGridLineDashStyle { get; set; }

        /// <summary>
        /// Width of the minor, secondary grid lines. Defaults to 1.
        /// </summary>
        public JsNumber minorGridLineWidth { get; set; }

        /// <summary>
        /// Color for the minor tick marks. Defaults to #A0A0A0.
        /// </summary>
        public JsString minorTickColor { get; set; }

        /// <summary>
        /// Tick interval in scale units for the minor ticks. On a linear axis, if "auto", the minor tick interval is calculated as a fifth of the tickInterval.
        /// If null, minor ticks are not shown.
        /// On logarithmic axes, the unit is the power of the value.
        /// For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc.
        /// Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10, 10 and 100 etc.
        /// A minorTickInterval of "auto" on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.
        /// . Defaults to null.
        /// </summary>
        public JsNumber minorTickInterval { get; set; }

        /// <summary>
        /// The pixel length of the minor tick marks. Defaults to 2.
        /// </summary>
        public JsNumber minorTickLength { get; set; }

        /// <summary>
        /// The position of the minor tick marks relative to the axis line. Can be one of inside and outside. Defaults to outside.
        /// </summary>
        public TickPositionType minorTickPosition { get; set; }

        /// <summary>
        /// The pixel width of the minor tick mark. Defaults to 0.
        /// </summary>
        public JsNumber minorTickWidth { get; set; }

        /// <summary>
        /// The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area.
        /// This is typically used when two or more axes are displayed on the same side of the plot. Defaults to 0.
        /// </summary>
        public JsNumber offset { get; set; }

        /// <summary>
        /// Whether to display the axis on the opposite side of the normal.
        /// The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively.
        /// This is typically used with dual or multiple axes. Defaults to false.
        /// </summary>
        public bool opposite { get; set; }

        /// <summary>
        /// A colored band stretching across the plot area marking an interval on the axis.
        /// </summary>
        public AxisPlotBandsOptions plotBands { get; set; }

        /// <summary>
        /// A line streching across the plot area, marking a specific value on one of the axes.
        /// </summary>
        public AxisPlotLinesOptions plotLines { get; set; }

        /// <summary>
        /// Whether to reverse the axis so that the highest number is closest to origo. If the chart is inverted, the x axis is reversed by default. Defaults to false.
        /// </summary>
        public bool reversed { get; set; }

        /// <summary>
        /// Whether to show the axis line and title when the axis has no data. Defaults to true.
        /// </summary>
        public bool showEmpty { get; set; }

        /// <summary>
        /// Whether to show the first tick label. Defaults to true.
        /// </summary>
        public bool showFirstLabel { get; set; }

        /// <summary>
        /// Whether to show the last tick label. Defaults to true.
        /// </summary>
        public bool showLastLabel { get; set; }

        /// <summary>
        /// The stack labels show the total value for each bar in a stacked column or bar chart. The label will be placed on top of positive columns and below negative columns.
        /// In case of an inverted column chart or a bar chart the label is placed to the right of positive bars and to the left of negative bars.
        /// </summary>
        public YAxisStackLabelsOptions stackLabels { get; set; }

        /// <summary>
        /// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday. Defaults to 1.
        /// </summary>
        public JsNumber startOfWeek { get; set; }

        /// <summary>
        /// Whether to force the axis to start on a tick. Use this option with the maxPadding option to control the axis start. Defaults to true.
        /// </summary>
        public bool startOnTick { get; set; }

        /// <summary>
        /// Color for the main tick marks. Defaults to #C0D0E0.
        /// </summary>
        public JsString tickColor { get; set; }

        /// <summary>
        /// The interval of the tick marks in axis units. When null, the tick interval is computed to approximately follow the tickPixelInterval on linear and datetime axes.
        /// On categorized axes, a null tickInterval will default to 1, one category.
        /// Note that datetime axes are based on milliseconds, so for example an interval of one day is expressed as 24 * 3600 * 1000.
        /// On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means one tick on each of 0.1, 1, 10, 100 etc.
        /// A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.
        /// . Defaults to null.
        /// </summary>
        public JsNumber tickInterval { get; set; }

        /// <summary>
        /// The pixel length of the main tick marks. Defaults to 5.
        /// </summary>
        public JsNumber tickLength { get; set; }

        /// <summary>
        /// If tickInterval is null this option sets the approximate pixel interval of the tick marks.
        /// Not applicable to categorized axis. Defaults to 72 for the Y axis and 100 for	the X axis.
        /// </summary>
        public JsNumber tickPixelInterval { get; set; }

        /// <summary>
        /// The position of the major tick marks relative to the axis line. Can be one of inside and outside. Defaults to "outside".
        /// </summary>
        public TickPositionType tickPosition { get; set; }

        /// <summary>
        /// The pixel width of the major tick marks. Defaults to 0.
        /// </summary>
        public JsNumber tickWidth { get; set; }

        /// <summary>
        /// For categorized axes only. If "on" the tick mark is placed in the center of the category, if "between" the tick mark is placed between categories.
        /// Defaults to "between".
        /// </summary>
        public JsString tickmarkPlacement { get; set; }

        /// <summary>
        /// The axis title, showing next to the axis line.
        /// </summary>
        public AxisTitleOptions title { get; set; }

        /// <summary>
        /// The type of axis. Can be one of "linear", "logarithmic" or "datetime". In a datetime axis,
        /// the numbers are given in milliseconds, and tick marks are placed on appropriate values like full hours or days. Defaults to "linear".
        /// </summary>
        public AxisType type { get; set; }
    }

    /// <summary>
    /// The axis labels show the number or category for each tick.
    /// </summary>
    [JsType(JsMode.Json)]
    public class YAxisLabelsOptions
    {
        /// <summary>
        /// What part of the string the given position is anchored to. Can be one of "left", "center" or "right". Defaults to "right".
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// Enable or disable the axis labels. Defaults to true.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// Callback JavaScript function to format the label. The value is given by this.value. Additional properties for this are axis, chart, isFirst and isLast. Defaults to:
        /// function() {
        /// 	return this.value;
        /// }
        /// </summary>
        public JsAction formatter { get; set; }
        //TODO: Callback JavaScript function (REED SUMMARY)

        /// <summary>
        /// How to handle overflowing labels on horizontal axis. Can be undefined or "justify". If "justify", labels will not render outside the plot area.
        /// If there is room to move it, it will be aligned to the edge, else it will be removed. Defaults to undefined.
        /// </summary>
        public JsString overflow { get; set; }

        /// <summary>
        /// Rotation of the labels in degrees. Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels. . Defaults to null.
        /// </summary>
        public JsNumber staggerLines { get; set; }

        /// <summary>
        /// To show only every n'th label on the axis, set the step to n. Setting the step to 2 shows every other label. Defaults to null.
        /// </summary>
        public JsNumber step { get; set; }

        /// <summary>
        /// CSS styles for the label. Defaults to:
        /// style: {
        /// 	color: '#6D869F',
        /// 	fontWeight: 'bold'
        /// }
        /// </summary>
        public HtmlElement style { get; set; }

        /// <summary>
        /// The x position offset of the label relative to the tick position on the axis. Defaults to -8.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y position offset of the label relative to the tick position on the axis. Defaults to 3.
        /// </summary>
        public JsNumber y { get; set; }
    }

    /// <summary>
    /// The stack labels show the total value for each bar in a stacked column or bar chart. The label will be placed on top of positive columns and below negative columns.
    /// In case of an inverted column chart or a bar chart the label is placed to the right of positive bars and to the left of negative bars.
    /// </summary>
    [JsType(JsMode.Json)]
    public class YAxisStackLabelsOptions
    {
        /// <summary>
        /// Defines the horizontal alignment of the stack total label. Can be one of "left", "center" or "right".
        /// The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
        /// </summary>
        public HorizontalAlignType align { get; set; }

        /// <summary>
        /// Enable or disable the stack total labels. Defaults to false.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// formatter: FunctionSince 2.1.5
        /// Callback JavaScript function to format the label. The value is given by this.total. Defaults to:
        /// function() {
        /// 	return this.total;
        /// }
        /// </summary>
        public JsAction formatter { get; set; }
        //TODO: Callback JavaScript function (REED SUMMARY)

        /// <summary>
        /// Rotation of the labels in degrees. Defaults to 0.
        /// </summary>
        public JsNumber rotation { get; set; }

        /// <summary>
        /// CSS styles for the label. Defaults to:
        /// style: {
        /// 	color: '#666',
        /// 	'font-size': '11px',
        /// 	'line-height': '14px'
        /// }
        /// </summary>
        public CssStyleJson style { get; set; }

        /// <summary>
        /// The text alignment for the label.
        /// While align determines where the texts anchor point is placed with regards to the stack, textAlign determines how the text is aligned against its anchor point.
        /// Possible values are "left", "center" and "right".
        /// The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
        /// </summary>
        public TextAlignType textAlign { get; set; }

        /// <summary>
        /// Defines the vertical alignment of the stack total label. Can be one of "top", "middle" or "bottom".
        /// The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
        /// </summary>
        public VerticalAlignType verticalAlign { get; set; }

        /// <summary>
        /// The x position offset of the label relative to the left of the stacked bar.
        /// The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
        /// </summary>
        public JsNumber x { get; set; }

        /// <summary>
        /// The y position offset of the label relative to the tick position on the axis.
        /// The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
        /// </summary>
        public JsNumber y { get; set; }
    }

    #endregion


    [JsType(JsMode.Json)]
    public class CssStyleJson : CssStyleDeclaration
    {
    }
}
