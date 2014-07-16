using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.Html;

namespace SharpKit.Arshaw.FullCalendar
{
    public class FullCalendar
    {
        public FullCalendar(jQuery.jQuery jQuery, FullCalendar options)
        {
        }
        /// <summary>
        /// Immediately forces the calendar to render and/or readjusts its size.
        /// This method is useful in the scenario where a tab setup might hide/show a calendar. Call this method whenever the tabs are shown.
        /// Notice that this example calls render whenever any tab is shown, not just the tab that the calendar is within.
        /// This is okay, because FullCalendar is smart enough to only render calendars that are visible to the user.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#my-tabs').tabs({
        ///     show: function(event, ui) {
        ///         $('#calendar').fullCalendar('render');
        ///     }
        /// });
        ///</code>
        ///</example>
        public void render() { }

        /// <summary>
        /// Restores the element to the state before FullCalendar was initialized.
        /// Removes elements, events handlers, and internal data.
        /// </summary>
        public void destroy() { }

        #region Views
        //TODO: View Option Hash
    

        /// <summary>
        /// The initial view when the calendar loads.
        /// default: 'month'
        /// </summary>
        [JsProperty(Name = "defaultView")]
        public JsString defaultViewString { get; set; }
        /// <summary>
        /// The initial view when the calendar loads.
        /// default: 'month'
        /// </summary>
        public AvailableViews defaultView { get; set; }

        /// <summary>
        /// This is useful if you want to get information about the calendar’s title or start/end dates.
        /// </summary>
        /// <returns>Returns the View Object for the current view.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var view = $('#calendar').fullCalendar('getView');
        ///alert("The view's title is " + view.title);
        ///</code>
        ///</example>
        public View getView() { return null; }

        /// <summary>
        /// Immediately switches to a different view.
        /// </summary>
        /// <param name="viewName">viewName must be a string value containing one of the Available Views.</param>
        public void changeView(JsString viewName) { }
        /// <summary>
        /// Immediately switches to a different view.
        /// </summary>
        /// <param name="viewName">viewName must be a string value containing one of the Available Views.</param>
        public void changeView(AvailableViews viewName) { }


        #endregion

        #region Current Date
        

        /// <summary>
        /// The initial year when the calendar loads.
        /// Must be a 4-digit year like 2009.
        /// If year is unspecified, the calendar will begin at the current year.
        /// </summary>
        public JsNumber year { get; set; }

        /// <summary>
        /// The initial month when the calendar loads.
        /// IMPORTANT: The value is 0-based, meaning January=0, February=1, etc.
        /// If month is unspecified and year is set to the current year, the calendar will start on the current month.
        /// If month is unspecified and year is not set to the current year, the calendar will start on January.
        /// </summary>
        public JsNumber month { get; set; }

        /// <summary>
        /// The initial date-of-month when the calendar loads.
        /// This option only matters for the week &amp; day views. Month view does not need this option, because month view always displays the entire month from start to finish.
        /// If date is unspecified, and year/month are set to the current year/month, then the calendar will start on the current date.
        /// If date is unspecified, and year/month are not set to the current year/month, then the calendar will start on the first of the month.
        /// </summary>
        public JsNumber date { get; set; }

        /// <summary>
        /// Moves the calendar one step back (either by a month, week, or day).
        /// If the calendar is in month view, will move the calendar back one month.
        /// If the calendar is in basicWeek or agendaWeek, will move the calendar back one week.
        /// If the calendar is in basicDay or agendaDay, will move the calendar back one day.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#my-prev-button').click(function() {
        ///     $('#calendar').fullCalendar('prev');
        /// });
        ///</code>
        ///</example>
        public void prev() { }

        /// <summary>
        /// Moves the calendar one step forward (either by a month, week, or day).
        /// If the calendar is in month view, will move the calendar forward one month.
        /// If the calendar is in basicWeek or agendaWeek, will move the calendar forward one week.
        /// If the calendar is in basicDay or agendaDay, will move the calendar forward one day.
        /// Example using next with an external button:
        /// </summary>
        public void next() { }

        /// <summary>
        /// Moves the calendar back one year.
        /// Version 1.3.x did not include this method, but you can use .fullCalendar('incrementDate', -1) instead.
        /// </summary>
        public void prevYear() { }

        /// <summary>
        /// Moves the calendar forward one year.
        /// Version 1.3.x did not include this method, but you can use .fullCalendar('incrementDate', 1) instead.
        /// </summary>
        public void nextYear() { }

        /// <summary>
        /// Moves the calendar to the current date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#my-today-button').click(function() {
        ///     $('#calendar').fullCalendar('today');
        /// });
        ///</code>
        ///</example>
        public void today() { }

        /// <summary>
        /// Moves the calendar to an arbitrary year/month/date.
        /// IMPORTANT: month is 0-based, meaning January=0, February=1, etc.
        /// This method can also be called with a single argument, a Date object (only works in versions >= 1.3.2).
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month">IMPORTANT: month is 0-based, meaning January=0, February=1, etc.</param>
        /// <param name="date"></param>
        public void gotoDate(JsDate year, JsNumber month, JsDate date) { }
        //TODO: year type is date or number?
        /// <summary>
        /// Moves the calendar to an arbitrary year/month/date.
        /// IMPORTANT: month is 0-based, meaning January=0, February=1, etc.
        /// This method can also be called with a single argument, a Date object (only works in versions >= 1.3.2).
        /// </summary>
        /// <param name="year"></param>
        public void gotoDate(JsDate year) { }
        //TODO: year type is date or number?

        /// <summary>
        /// Moves the calendar forward/backward an arbitrary amount of time.
        /// </summary>
        /// <param name="years"></param>
        /// <param name="months"></param>
        /// <param name="dates"></param>
        public void incrementDate(JsNumber years, JsNumber months, JsNumber dates) { }
        /// <summary>
        /// Moves the calendar forward/backward an arbitrary amount of time.
        /// </summary>
        /// <param name="years"></param>
        public void incrementDate(JsNumber years) { }

        /// <summary>
        /// For month view, it will always be sometime between the first and last day of the month.
        /// For week views, it will always be sometime between the first and last day of the week.
        /// </summary>
        /// <returns>Returns a Date object for the current date of the calendar.</returns>
        ///<example>
        ///usage
        ///<code>
        ///$('#my-button').click(function() {
        ///     var d = $('#calendar').fullCalendar('getDate');
        ///     alert("The current date of the calendar is " + d);
        /// });
        ///</code>
        ///</example>
        public JsDate getDate() { return null; }

        #endregion


        //Text/Time Customization:

        /// <summary>
        /// Determines the time-text that will be displayed on each event.
        /// can also be a View Option Hash type
        /// default:
        ///{
        ///    // for agendaWeek and agendaDay
        ///    agenda: 'h:mm{ - h:mm}', // 5:00 - 6:30
        ///
        ///    // for all other views
        ///    '': 'h(:mm)t'            // 7p
        ///}
        ///A single format string will change the time-text for events in all views. A View Option Hash may be provided to target specific views (this is what the default does).
        /// Uses formatDate/formatDates formatting rules. (The formatting rules were much different in versions before 1.3. See here)
        /// Time-text will only be displayed for Event Objects that have allDay equal to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     events: [
        ///         {
        ///             title:  'My Event',
        ///             start:   '2010-01-01T14:30:00',
        ///             allDay: false
        ///         }
        ///         // other events here...
        ///     ],
        ///     timeFormat: 'H(:mm)' // uppercase H for 24-hour clock
        /// });
        ///</code>
        ///</example>
        public JsString timeFormat { get; set; }

        /// <summary>
        /// Determines the text that will be displayed on the calendar's column headings.
        /// can also be a View Option Hash type
        /// default:
        /// {
        ///     month: 'ddd',    // Mon
        ///     week: 'ddd M/d', // Mon 9/7
        ///     day: 'dddd M/d'  // Monday 9/7
        /// }
        /// A single string will set the title format for all views. A View Option Hash may be provided to target specific views (this is what the default does).
        /// Uses formatDate/formatDates formatting rules. (The formatting rules were much different in versions before 1.3. See here)
        /// </summary>
        public JsString columnFormat { get; set; }

        /// <summary>
        /// Determines the text that will be displayed in the header's title.
        /// can also be a View Option Hash type
        /// default:
        /// {
        ///     month: 'MMMM yyyy',                             // September 2009
        ///     week: "MMM d[ yyyy]{ '&#8212;'[ MMM] d yyyy}", // Sep 7 - 13 2009
        ///     day: 'dddd, MMM d, yyyy'                  // Tuesday, Sep 8, 2009
        /// }
        /// A single string will set the title format for all views. A View Option Hash may be provided to target specific views (this is what the default does).
        /// Uses formatDate/formatDates formatting rules. (The formatting rules were much different in versions before 1.3. See here)
        /// </summary>
        public JsString titleFormat { get; set; }

        /// <summary>
        /// Text that will be displayed on buttons of the header.
        /// default:
        /// {
        ///     prev:     ' &#9668; ',  // left triangle
        ///     next:     ' &#9658; ',  // right triangle
        ///     prevYear: ' &lt;&lt; ', // &lt;&lt;
        ///     nextYear: ' &gt;&gt; ', // >>
        ///     today:    'today',
        ///     month:    'month',
        ///     week:     'week',
        ///     day:      'day'
        /// }
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //If you wanted to change the prev/next buttons to use &lt; and > characters, here is what you would do:
        /// $('#calendar').fullCalendar({
        ///    buttonText: {
        ///        prev: '&amp;lt;',
        ///        next: '&amp;gt;'
        ///    }
        ///});
        ///</code>
        ///</example>
        public object buttonText { get; set; }

        /// <summary>
        /// Full names of months.
        /// default:
        /// ['January', 'February', 'March', 'April', 'May', 'June', 'July',
        ///  'August', 'September', 'October', 'November', 'December']
        ///  (Prior to version 1.3, this was possible by setting $.fullCalendar.monthNames)
        /// </summary>
        public Array monthNames { get; set; }

        /// <summary>
        /// Abbreviated names of months.
        /// default:
        /// ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'
        /// 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
        /// (Prior to version 1.3, this was possible by setting $.fullCalendar.monthAbbrevs)
        /// </summary>
        public Array monthNamesShort { get; set; }

        /// <summary>
        /// Full names of days-of-week.
        /// default:
        /// ['Sunday', 'Monday', 'Tuesday', 'Wednesday',
        ///  'Thursday', 'Friday', 'Saturday']
        ///  (Prior to version 1.3, this was possible by setting $.fullCalendar.dayNames)
        /// </summary>
        public Array dayNames { get; set; }

        /// <summary>
        /// Abbreviated names of days-of-week.
        /// default:
        /// ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
        /// (Prior to version 1.3, this was possible by setting $.fullCalendar.dayAbbrevs)
        /// </summary>
        public Array dayNamesShort { get; set; }



        //Clicking & Hovering:

        /// <summary>
        /// Triggered when the user clicks on a day.
        /// function( date, allDay, jsEvent, view ) { }
        /// date holds a Date object for the current day. If user has clicked on a slot in the agendaWeek or agendaDay views, date will also have its time set.
        /// allDay will be set to true false if the user has clicked on a slot in the agendaWeek or agendaDay views. Otherwise, it will be true.
        /// jsEvent holds the native JavaScript event with low-level information such as click coordinates.
        /// view is set to the current View Object.
        /// Within the callback function, this is set to the &lt;td> of the clicked day.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     dayClick: function(date, allDay, jsEvent, view) {
        /// 
        ///         if (allDay) {
        ///             alert('Clicked on the entire day: ' + date);
        ///         }else{
        ///             alert('Clicked on the slot: ' + date);
        ///         }
        /// 
        ///         alert('Coordinates: ' + jsEvent.pageX + ',' + jsEvent.pageY);
        /// 
        ///         alert('Current view: ' + view.name);
        /// 
        ///         // change the day's background color just for fun
        ///         $(this).css('background-color', 'red');
        /// 
        ///     }
        /// });
        ///</code>
        ///</example>
        public JsAction<JsDate, bool, Event, View> dayClick { get; set; }

        /// <summary>
        /// Triggered when the user clicks an event.
        /// function( event, jsEvent, view ) { }
        /// event is an Event Object that holds the event's information (date, title, etc).
        /// jsEvent holds the native JavaScript event with low-level information such as click coordinates.
        /// view holds the current View Object.
        /// Within the callback function, this is set to the event's &lt;div> element.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     eventClick: function(calEvent, jsEvent, view) {
        /// 
        ///         alert('Event: ' + calEvent.title);
        ///         alert('Coordinates: ' + jsEvent.pageX + ',' + jsEvent.pageY);
        ///         alert('View: ' + view.name);
        /// 
        ///         // change the border color just for fun
        ///         $(this).css('border-color', 'red');
        /// 
        ///     }
        /// });
        ///</code>
        ///</example>
        public JsAction<Event, Event, View> eventClick { get; set; }
        //TODO: Return Value (?) http://arshaw.com/fullcalendar/docs/mouse/eventClick/

        /// <summary>
        /// Triggered when the user mouses over an event.
        /// function( event, jsEvent, view ) { }
        /// event is an Event Object that holds the event's information (date, title, etc).
        /// jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.
        /// view holds the current View Object.
        /// Within the callback function, this is set to the event's &lt;div> element.
        /// </summary>
        public JsAction<Event, Event, View> eventMouseover { get; set; }

        /// <summary>
        /// Triggered when the user mouses out of an event.
        /// function( event, jsEvent, view ) { }
        /// event is an Event Object that holds the event's information (date, title, etc).
        /// jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.
        /// view holds the current View Object.
        /// Within the callback function, this is set to the event's &lt;div> element.
        /// </summary>
        public JsAction<Event, Event, View> eventMouseout { get; set; }



        //Selection:

        /// <summary>
        /// Allows a user to highlight multiple days or timeslots by clicking and dragging.
        /// To let the user make selections by clicking and dragging, this option must be set to true.
        /// The select and unselect callbacks will be useful for monitoring when selections are made and cleared.
        /// To learn the ways in which selections can be cleared, read the docs for the unselect callback.
        /// To view an example of how to create a new event based on a user's selection see "demos/selectable.html" in the download, or visit this page.
        /// </summary>
        [JsProperty(Name = "selectable")]
        public bool selectableBoolean { get; set; }
        /// <summary>
        /// Allows a user to highlight multiple days or timeslots by clicking and dragging.
        /// To let the user make selections by clicking and dragging, this option must be set to true.
        /// The select and unselect callbacks will be useful for monitoring when selections are made and cleared.
        /// To learn the ways in which selections can be cleared, read the docs for the unselect callback.
        /// To view an example of how to create a new event based on a user's selection see "demos/selectable.html" in the download, or visit this page.
        /// </summary>
        public ViewOptionHash selectable { get; set; }

        /// <summary>
        /// Whether to draw a "placeholder" event while the user is dragging.
        /// This option only applies to the agenda views.
        /// A value of true will draw a "placeholder" event while the user is dragging (similar to what Google Calendar does for its week and day views).
        /// A value of false (the default) will draw the standard highlighting over each cell.
        /// A function can also be specified for drawing custom elements. It will be given 2 arguments: the selection's start date and end date (Date objects).
        /// It must return a DOM element that will be used.
        /// </summary>
        public bool selectHelper { get; set; }
        /// <summary>
        /// Whether to draw a "placeholder" event while the user is dragging.
        /// This option only applies to the agenda views.
        /// A value of true will draw a "placeholder" event while the user is dragging (similar to what Google Calendar does for its week and day views).
        /// A value of false (the default) will draw the standard highlighting over each cell.
        /// A function can also be specified for drawing custom elements. It will be given 2 arguments: the selection's start date and end date (Date objects).
        /// It must return a DOM element that will be used.
        /// </summary>
        [JsProperty(Name = "selectHelper")]
        public JsAction selectHelperFunction { get; set; }

        /// <summary>
        /// Whether clicking elsewhere on the page will cause the current selection to be cleared.
        /// This option can only take effect when selectable is set to true.
        /// </summary>
        public bool unselectAuto { get; set; }

        /// <summary>
        /// A way to specify elements that will ignore the unselectAuto option.
        /// Clicking on elements that match this jQuery selector will prevent the current selection from being cleared (due to the unselectAuto option).
        /// This option is useful if you have a "Create an event" form that shows up in response to the user making a selection. When the user clicks on this form,
        /// you probably don't want to the current selection to go away. Thus, you should add a class to your form such as "my-form", and set the unselectCancel option to ".my-form".
        /// </summary>
        public JsString unselectCancel { get; set; }

        /// <summary>
        /// A callback that will fire after a selection is made.
        /// function( startDate, endDate, allDay, jsEvent, view )
        /// startDate is a Date object indicating the beginning of the selection.
        /// endDate is a Date object indicating the end of the selection. It follows the same rules as the Event Object for inclusivity/exclusivity: when allDay is true, endDate includes the last day.
        /// allDay is a boolean indicating if entire days were selected (days in month view or the "all-day" slot in the agenda view) or time slots were selected.
        /// jsEvent holds the primitive JavaScript event with information such as mouse coordinates. If select has been triggered via the select method, jsEvent will be undefined. (added in version 1.4.7)
        /// </summary>
        public JsAction<JsDate, JsDate, bool, Event, View> select { get; set; }

        /// <summary>
        /// A callback that will fire when the current selection is cleared.
        /// function( view, jsEvent )
        /// A selection might be cleared for a number of reasons:
        /// 1. The user clicks away from the current selection (doesn't happen when unselectAuto is false).
        /// 2. The user makes a new selection. The unselect callback will be fired before the new selection occurs.
        /// 3. The user moves forward or backward in the current view, or switches to a new view.
        /// 4. The unselect method is called through the API.
        /// jsEvent holds the primitive JavaScript event with information such as mouse coordinates. If unselect has been triggered via the unselect method, jsEvent will be undefined. (added in version 1.4.7)
        /// </summary>
        public JsAction<View, Event> unselect { get; set; }

        ///// <summary>
        ///// A method for programmatically selecting a period of time.
        ///// </summary>
        ///// <param name="startDate"></param>
        ///// <param name="endDate"></param>
        ///// <param name="allDay"></param>
        //public void select(JsDate startDate, JsDate endDate, JsDate allDay) { }

        ///// <summary>
        ///// A method for programmatically clearing the current selection.
        ///// </summary>
        //public void unselect() { }



        //Event Data:

        /// <summary>
        /// An array of Event Objects that will be displayed on the calendar.
        /// Make sure you do not have a comma after the last event in your array! It will make Internet Explorer choke.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     events: [
        ///         {
        ///             title  : 'event1',
        ///             start  : '2010-01-01'
        ///         },
        ///         {
        ///             title  : 'event2',
        ///             start  : '2010-01-05',
        ///             end    : '2010-01-07'
        ///         },
        ///         {
        ///             title  : 'event3',
        ///             start  : '2010-01-09 12:30:00',
        ///             allDay : false // will make the time show
        ///         }
        ///     ]
        /// });
        ///</code>
        ///</example>
        public JsArray<Event> events { get; set; }
        //TODO: Extended Form http://arshaw.com/fullcalendar/docs/event_data/events_array/
        ///// <summary>
        ///// A URL of a JSON feed that the calendar will fetch Event Objects from.
        ///// FullCalendar will visit the URL whenever it needs new event data. This happens when the user clicks prev/next or changes views. FullCalendar will determine the date-range it needs events for and will pass that information along in GET parameters.
        ///// The GET parameter names will be determined by the startParam and endParam options. ("start" and "end" by default).
        ///// The value of the parameters will always be UNIX timestamps (seconds since 1970).
        ///// </summary>
        /////<example>
        /////usage
        /////<code>
        /////$('#calendar').fullCalendar({
        /////    events: '/myfeed.php'
        /////});
        /////</code>
        /////</example>
        //public JSON events { get; set; }
        ////TODO: Extended Form http://arshaw.com/fullcalendar/docs/event_data/events_json_feed/
        ///// <summary>
        ///// FullCalendar will call this function whenever it needs new event data. This is triggered when the user clicks prev/next or switches views.
        ///// This function will be given start and end parameters, which are Date objects denoting the range the calendar needs events for.
        ///// It will also be given callback, a function that must be called when the custom event function has generated its events. It is the event function's responsibility to make sure callback is being called with an array of Event Objects.
        ///// </summary>
        /////<example>
        /////usage
        /////<code>
        /////$('#calendar').fullCalendar({
        /////     events: function(start, end, callback) {
        /////         $.ajax({
        /////             url: 'myxmlfeed.php',
        /////             dataType: 'xml',
        /////             data: {
        /////                 // our hypothetical feed requires UNIX timestamps
        /////                 start: Math.round(start.getTime() / 1000),
        /////                 end: Math.round(end.getTime() / 1000)
        /////             },
        /////             success: function(doc) {
        /////                 var events = [];
        /////                 $(doc).find('event').each(function() {
        /////                     events.push({
        /////                         title: $(this).attr('title'),
        /////                         start: $(this).attr('start') // will be parsed
        /////                     });
        /////                 });
        /////                 callback(events);
        /////             }
        /////         });
        /////     }
        ///// });
        /////</code>
        /////</example>
        //public JsAction<JsDate, JsDate, JsAction> events { get; set; }
        ////TODO: Extended Form http://arshaw.com/fullcalendar/docs/event_data/events_function/

        /// <summary>
        /// A way to specify multiple event sources.
        /// This option is used instead of the events option.
        /// You can put any number of event arrays, functions, JSON feed URLs, or full-out Event Source Objects into the eventSources array.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     eventSources: [
        ///         '/feed1.php',
        ///         '/feed2.php'
        ///     ]
        /// });
        ///</code>
        ///</example>
        public JsArray eventSources { get; set; }

        /// <summary>
        /// Determines the default value for each Event Object's allDay property, when it is unspecified.
        /// default: true
        /// </summary>
        public bool allDayDefault { get; set; }

        /// <summary>
        /// When parsing ISO8601 dates, whether UTC offsets should be ignored while processing event source data.
        /// default: true
        /// The default is true, which means the UTC offset for all ISO8601 dates will be ignored. For example, the date "2008-11-05T08:15:30-05:00" will be processed as November 5th, 2008 at 8:15am in the local offset of the browser.
        /// If you are using ISO8601 dates with UTC offsets, chances are you want them processed. You must set this option to false. In the future, the default for this option will probably be changed to false.
        /// </summary>
        public bool ignoreTimezone { get; set; }

        /// <summary>
        /// A GET parameter of this name will be inserted into each JSON feed's URL.
        /// default: 'start'
        /// The value of this GET parameter will be a UNIX timestamp denoting the start of the first visible day (inclusive).
        /// </summary>
        public JsString startParam { get; set; }

        /// <summary>
        /// A GET parameter of this name will be inserted into each JSON feed's URL.
        /// default: 'end'
        /// The value of this GET parameter will be a UNIX timestamp denoting the end of the last visible day (exclusive).
        /// </summary>
        public JsString endParam { get; set; }

        /// <summary>
        /// Determines when event fetching should occur.
        /// default: true
        /// When set to true (the default), the calendar will only fetch events when it absolutely needs to, minimizing AJAX calls. For example, say your calendar starts out in month view, in February. FullCalendar will fetch events for the entire month of February and store them in its internal cache. Then, say the user switches to week view and begins browsing the weeks in February. The calendar will avoid fetching events because it already has this information stored.
        /// When set to false, the calendar will fetch events any time the view is switched, or any time the current date changes (for example, as a result of the user clicking prev/next).
        /// </summary>
        public bool lazyFetching { get; set; }

        /// <summary>
        /// Triggered when event fetching starts/stops.
        /// Triggered with a true argument when the calendar begins fetching events via AJAX. Triggered with false when done.
        /// view is the current View Object.
        /// This function is often used to show/hide a loading indicator.
        /// </summary>
        public JsAction<bool, View> loading { get; set; }

        /// <summary>
        /// Reports changes to an event and renders them on the calendar.
        /// </summary>
        /// <param name="event">event must be the original Event Object for an event, not merely a reconstructed object.
        /// The original Event Object can obtained by callbacks such as eventClick, or by the clientEvents method.</param>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     eventClick: function(event, element) {
        /// 
        ///         event.title = "CLICKED!";
        /// 
        ///         $('#calendar').fullCalendar('updateEvent', event);
        /// 
        ///     }
        /// });
        ///</code>
        ///</example>
        public void updateEvent(Event @event) { }

        /// <summary>
        /// Retrieves events that FullCalendar has in memory.
        /// This method will return an array of Event Objects that FullCalendar has stored in client-side memory.
        /// If idOrFilter is omitted, all events will be returned.
        /// If idOrFilter is an ID, all events with the same ID will be returned.
        /// idOrFilter may also be a filter function that accepts one Event Object argument and returns true if it should be included in the result set.
        /// In versions 1.2 and 1.2.1, this option was known as getEventsByID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsArray<Event> clientEvents(JsString id) { return null; }

        /// <summary>
        /// Retrieves events that FullCalendar has in memory.
        /// This method will return an array of Event Objects that FullCalendar has stored in client-side memory.
        /// If idOrFilter is omitted, all events will be returned.
        /// If idOrFilter is an ID, all events with the same ID will be returned.
        /// idOrFilter may also be a filter function that accepts one Event Object argument and returns true if it should be included in the result set.
        /// In versions 1.2 and 1.2.1, this option was known as getEventsByID
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public JsArray<Event> clientEvents(JsFunc<Event, bool> filter) { return null; }

        /// <summary>
        /// Retrieves events that FullCalendar has in memory.
        /// This method will return an array of Event Objects that FullCalendar has stored in client-side memory.
        /// If idOrFilter is omitted, all events will be returned.
        /// If idOrFilter is an ID, all events with the same ID will be returned.
        /// idOrFilter may also be a filter function that accepts one Event Object argument and returns true if it should be included in the result set.
        /// In versions 1.2 and 1.2.1, this option was known as getEventsByID
        /// </summary>
        /// <returns></returns>
        public JsArray<Event> clientEvents() { return null; }

        /// <summary>
        /// Removes events from the calendar.
        ///.fullCalendar( 'removeEvents' [, idOrFilter ] )
        ///If idOrFilter is omitted, all events are removed.
        ///If idOrFilter is an ID, all events with the same ID will be removed.
        ///idOrFilter may also be a filter function that accepts one Event Object argument and returns true if it should be removed.
        /// </summary>
        /// <param name="idOrFilter"></param>
        public void removeEvents(object idOrFilter) { }
        //TODO: must check

        /// <summary>
        /// Refetches events from all sources and rerenders them on the screen.
        /// Prior to version 1.3, the same effect was achieved by the refresh method.
        /// </summary>
        public void refetchEvents() { }

        /// <summary>
        /// Dynamically adds an event source.
        /// </summary>
        /// <param name="source">Source may be an Array/URL/Function just as in the events option. Events will be immediately fetched from this source and placed on the calendar.</param>
        public void addEventSource(object source) { }

        /// <summary>
        /// Dynamically removes an event source.
        /// Events from the source will immediately be removed from the calendar.
        /// Prior to version 1.5, things were more strict. You must specify a reference to the original Array/URL/Function.
        /// </summary>
        /// <param name="source">Since version 1.5, the source parameter has become rather relaxed.
        /// You can provide an event source's Array/URL/Function or you can specify the full Event Source Object.</param>
        public void removeEventSource(object source) { }



        //Event Rendering:

        //TODO: Colors

        /// <summary>
        /// Sets the background and border colors for all events on the calendar.
        /// You can use any of the CSS color formats such #f00, #ff0000, rgb(255,0,0), or red.
        /// This option can be overridden on a per-source basis with the color Event Source Object option or on a per-event basis with the color Event Object option.
        /// </summary>
        public JsString eventColor { get; set; }

        /// <summary>
        /// Sets the background color for all events on the calendar.
        /// You can use any of the CSS color formats such #f00, #ff0000, rgb(255,0,0), or red.
        /// This option can be overridden on a per-source basis with the color Event Source Object option or on a per-event basis with the color Event Object option.
        /// </summary>
        public JsString eventBackgroundColor { get; set; }

        /// <summary>
        /// Sets the border color for all events on the calendar.
        /// You can use any of the CSS color formats such #f00, #ff0000, rgb(255,0,0), or red.
        /// This option can be overridden on a per-source basis with the color Event Source Object option or on a per-event basis with the color Event Object option.
        /// </summary>
        public JsString eventBorderColor { get; set; }

        /// <summary>
        /// Sets the text color for all events on the calendar.
        /// You can use any of the CSS color formats such #f00, #ff0000, rgb(255,0,0), or red.
        /// This option can be overridden on a per-source basis with the color Event Source Object option or on a per-event basis with the color Event Object option.
        /// </summary>
        public JsString eventTextColor { get; set; }

        /// <summary>
        /// Triggered while an event is being rendered.
        /// function( event, element, view ) { }
        /// event is the Event Object that is attempting to be rendered.
        /// element is a newly created jQuery &lt;div> that will be used for rendering. It has already been populated with the correct time/title.
        /// The eventRender callback function can modify element, return a brand new DOM element that will be used for rendering instead, or it can return false, which will prevent the event from being rendered at all.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //eventRender is a great way to attach other jQuery plugins to event elements, such as a qTip tooltip effect:
        ///$('#calendar').fullCalendar({
        ///     events: [
        ///         {
        ///             title: 'My Event',
        ///             start: '2010-01-01',
        ///             description: 'This is a cool event'
        ///         }
        ///         // more events here
        ///     ],
        ///     eventRender: function(event, element) {
        ///         element.qtip({
        ///             content: event.description
        ///         });
        ///     }
        /// });
        /// //Note that description is a non-standard Event Object field, which is allowed.
        ///</code>
        ///</example>
        public JsAction<Event, jQuery.jQuery, View> eventRender { get; set; }

        /// <summary>
        /// Triggered after an event has been placed on the calendar in its final position.
        /// </summary>
        public JsAction<Event, jQuery.jQuery, View> eventAfterRender { get; set; }

        /// <summary>
        /// Renders a new event on the calendar.
        /// </summary>
        /// <param name="event">event must be an Event Object with a title and start at the very least.</param>
        /// <param name="stick">Normally, the event will disappear once the calendar refetches its event sources (example: when prev/next is clicked). However, specifying stick as true will cause the event to be permanently fixed to the calendar.</param>
        public void renderEvent(Event @event, bool stick) { }
        /// <summary>
        /// Renders a new event on the calendar.
        /// </summary>
        /// <param name="event">event must be an Event Object with a title and start at the very least.</param>
        public void renderEvent(Event @event) { }

        /// <summary>
        /// Rerenders all events on the calendar.
        /// Prior to version 1.3, the same effect could be achieved by the refresh method.
        /// </summary>
        public void rerenderEvents() { }

        /// <summary>
        /// Triggered when event dragging begins.
        /// function( event, jsEvent, ui, view ) { }
        /// event is an Event Object that hold the event's information (date, title, etc).
        /// jsEvent holds the native javascript event with low-level information such as click coordinates.
        /// ui holds the jQuery UI object.
        /// view holds the current View Object.
        /// </summary>
        public JsAction<Event, Event, jQuery.jQuery, View> eventDragStart { get; set; }

        /// <summary>
        /// Triggered when event dragging stops.
        /// function( event, jsEvent, ui, view ) { }
        /// This callback is guaranteed to be triggered after the user drags an event, even if the event doesn't change date/time.
        /// It is triggered before the event's information has been modified (if moved to a new date/time) and before the eventDrop callback is triggered.
        /// event is an Event Object that hold the event's information (date, title, etc).
        /// jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.
        /// ui holds the jQuery UI object.
        /// view holds the current View Object.
        /// </summary>
        public JsAction<Event, Event, jQuery.jQuery, View> eventDragStop { get; set; }

        /// <summary>
        /// Triggered when dragging stops and the event has moved to a different day/time.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     events: [
        ///         // events here
        ///     ],
        ///     editable: true,
        ///     eventDrop: function(event,dayDelta,minuteDelta,allDay,revertFunc) {
        /// 
        ///         alert(
        ///             event.title + " was moved " +
        ///             dayDelta + " days and " +
        ///             minuteDelta + " minutes."
        ///         );
        /// 
        ///         if (allDay) {
        ///             alert("Event is now all-day");
        ///         }else{
        ///             alert("Event has a time-of-day");
        ///         }
        /// 
        ///         if (!confirm("Are you sure about this change?")) {
        ///             revertFunc();
        ///         }
        /// 
        ///     }
        /// });
        ///</code>
        ///</example>
        public EventDrop eventDrop { get; set; }

        /// <summary>
        /// Triggered when event resizing begins.
        /// function( event, jsEvent, ui, view ) { }
        /// event is an Event Object that hold the event's information (date, title, etc).
        /// jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.
        /// ui holds the jQuery UI object.
        /// view holds the current View Object.
        /// </summary>
        public JsAction<Event, Event, jQuery.jQuery, View> eventResizeStart { get; set; }

        /// <summary>
        /// Triggered when event resizing stops.
        /// function( event, jsEvent, ui, view ) { }
        /// This callback is guaranteed to be triggered after the user resizes an event, even if the event doesn't change in duration. It is triggered before the event's information has been modified (if changed in duration) and before the eventResize callback is triggered.
        /// event is an Event Object that hold the event's information (date, title, etc).
        /// jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.
        /// ui holds the jQuery UI object.
        /// view holds the current View Object.
        /// </summary>
        public JsAction<Event, Event, jQuery.jQuery, View> eventResizeStop { get; set; }

        /// <summary>
        /// Triggered when resizing stops and the event has changed in duration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     events: [
        ///         // events here
        ///     ],
        ///     editable: true,
        ///     eventResize: function(event,dayDelta,minuteDelta,revertFunc) {
        /// 
        ///         alert(
        ///             "The end date of " + event.title + "has been moved " +
        ///             dayDelta + " days and " +
        ///             minuteDelta + " minutes."
        ///         );
        /// 
        ///         if (!confirm("is this okay?")) {
        ///             revertFunc();
        ///         }
        /// 
        ///     }
        /// });
        ///</code>
        ///</example>
        public EventResize eventResize { get; set; }



        //Event Dragging & Resizing:

        //TODO: Requirements- http://arshaw.com/fullcalendar/docs/event_ui/Requirements/

        /// <summary>
        /// Determines whether the events on the calendar can be modified.
        /// default: false
        /// This determines if the events can be dragged and resized. Enables/disables both at the same time. If you don't want both, use editable in conjunction with disableDragging and disableResizing.
        /// This option can be overridden on a per-event basis with the Event Object editable property.
        /// Prior to version 1.3, the draggable option was used instead.
        /// </summary>
        public bool editable { get; set; }

        /// <summary>
        /// Disables all event dragging, even when events are editable.
        /// default: false
        /// </summary>
        public bool disableDragging { get; set; }

        /// <summary>
        /// Disables all event resizing, even when events are editable.
        /// default: false
        /// </summary>
        public bool disableResizing { get; set; }

        /// <summary>
        /// Time it takes for an event to revert to its original position after an unsuccessful drag.
        /// default: 500
        /// Time is in milliseconds (1 second = 1000 milliseconds).
        /// Prior to version 1.3, this option was known as eventRevertDuration
        /// </summary>
        public JsNumber dragRevertDuration { get; set; }

        /// <summary>
        /// The opacity of an event while it is being dragged.
        /// default:
        /// {
        ///     // for agendaWeek and agendaDay
        ///     agenda: .5,
        /// 
        ///     // for all other views
        ///     '': 1.0
        /// }
        /// 
        /// Float values range from 0.0 to 1.0.
        /// Specify a single number to affect all views, or a View Option Hash to target specific views (which is what the default does).
        /// </summary>
        public float dragOpacity { get; set; }
        //TODO: must check





        //Dropping External Elements:

        /// <summary>
        /// Determines if jQuery UI draggables can be dropped onto the calendar.
        /// This option operates with jQuery UI draggables. You must download the appropriate jQuery UI files and initialize a draggable element.
        /// Additionally, you must set the calendar's droppable option to true.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#my-draggable').draggable({
        ///     revert: true,      // immediately snap back to original position
        ///     revertDuration: 0  //
        /// });
        /// 
        /// $('#calendar').fullCalendar({
        ///     droppable: true,
        ///     drop: function(date, allDay) {
        ///         alert("Dropped on " + date + " with allDay=" + allDay);
        ///     }
        /// });
        ///</code>
        ///</example>
        public bool droppable { get; set; }

        /// <summary>
        /// Provides a way to filter which elements can be dropped onto the calendar.
        /// By default, after setting a calendar' droppable option to true, the calendar will accept any draggables that are dropped onto the calendar.
        /// The dropAccept option allows the calendar be more selective about which elements can/can't be dropped.
        /// The value of dropAccept can be a string jQuery selector. It can also be a function that accepts the draggable item as a single argument,
        /// and returns true if the element can be dropped onto the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //In the following example, the first draggable (with id "draggable1") can be dropped on the calendar, while the second draggable (with id "draggable2") cannot:
        ///...
        ///&lt;div id='calendar'>&lt;/div>
        ///
        ///&lt;div id='draggable1' class='cool-event'>&lt;/div>
        ///&lt;div id='draggable2'>&lt;/div>
        ///...
        ///
        /// //and here is the JavaScript:
        /// $('#calendar').fullCalendar({
        ///     droppable: true,
        ///     dropAccept: '.cool-event',
        ///     drop: function() {
        ///         alert('dropped!');
        ///     }
        /// });
        /// 
        /// $('#draggable1').draggable();
        /// $('#draggable2').draggable();
        ///</code>
        ///</example>
        public JsString dropAccept { get; set; }
        /// <summary>
        /// Provides a way to filter which elements can be dropped onto the calendar.
        /// By default, after setting a calendar' droppable option to true, the calendar will accept any draggables that are dropped onto the calendar.
        /// The dropAccept option allows the calendar be more selective about which elements can/can't be dropped.
        /// The value of dropAccept can be a string jQuery selector. It can also be a function that accepts the draggable item as a single argument,
        /// and returns true if the element can be dropped onto the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //In the following example, the first draggable (with id "draggable1") can be dropped on the calendar, while the second draggable (with id "draggable2") cannot:
        ///...
        ///&lt;div id='calendar'>&lt;/div>
        ///
        ///&lt;div id='draggable1' class='cool-event'>&lt;/div>
        ///&lt;div id='draggable2'>&lt;/div>
        ///...
        ///
        /// //and here is the JavaScript:
        /// $('#calendar').fullCalendar({
        ///     droppable: true,
        ///     dropAccept: '.cool-event',
        ///     drop: function() {
        ///         alert('dropped!');
        ///     }
        /// });
        /// 
        /// $('#draggable1').draggable();
        /// $('#draggable2').draggable();
        ///</code>
        ///</example>
        [JsProperty(Name = "dropAccept")]
        public JsAction dropAcceptFunction { get; set; }

        /// <summary>
        /// Called when a valid jQuery UI draggable has been dropped onto the calendar.
        /// function( date, allDay, jsEvent, ui ) { }
        /// date holds the JavaScript Date object of where the draggable was dropped.
        /// allDay holds a boolean of whether the draggable was dropped on an all-day cell (like in month view) or in a slot with a specific time (like in agenda view).
        /// jsEvent holds the primitive JavaScript event, with information like mouse coordinates.
        /// ui holds the jQuery UI information.
        /// this holds the DOM element that has been dropped.
        /// To see this callback function in action, view the droppable article or look at this example.
        /// </summary>
        public JsAction<JsDate, bool, Event, jQuery.jQuery, HtmlElement> drop { get; set; }
        //TODO: in the summary there are 5 elemnt, in the function there are 4. i added the last one


    }

    /// <summary>
    /// Defines the buttons and title at the top of the calendar.
    /// Setting the header options to false will display no header. An object can be supplied with properties left, center, and right. These properties contain strings with comma/space separated values. Values separated by a comma will be displayed adjacently. Values separated by a space will be displayed with a small gap in between. Strings can contain any of the following values:
    /// </summary>
    public class FullCalendarHeader
    {
        public JsString left { get; set; }
        public JsString center { get; set; }
        public JsString right { get; set; }
    }
    public class FullCalendarOptions
    {
        //General Display:

        /// <summary>
        /// Defines the buttons and title at the top of the calendar.
        /// </summary>
        public FullCalendarHeader header { get; set; }

        /// <summary>
        /// default: false
        /// Once you enable theming with true, you still need to include the CSS file for the theme you want. For example, if you just downloaded a theme from the jQuery UI Themeroller, you need to put a &lt;link> tag in your page's &lt;head>.
        /// </summary>
        public bool theme { get; set; }

        /// <summary>
        /// Determines which theme icons appear on the header buttons.
        /// This option only applies to calendars that have jQuery UI theming enabled with the theme option.
        /// 
        /// A hash must be supplied that maps button names (from the header) to icon strings. The icon strings determine the CSS class that will be used on the button. For example, the string 'circle-triangle-w' will result in the class 'ui-icon-triangle-w'.
        /// 
        /// If a button does not have an entry, it falls back to using buttonText.
        /// 
        /// If you are using a jQuery UI theme and would prefer not to display any icons and would rather use buttonText instead, you can set the buttonIcons option to false.
        /// </summary>
        public object buttonIcons { get; set; }
        //TODO: check

        /// <summary>
        /// The day that each week begins.
        /// default: 0 (Sunday)
        /// The value must be a number that represents the day of the week.
        /// Sunday=0, Monday=1, Tuesday=2, etc.
        /// This option is useful for UK users who need the week to start on Monday (1).
        /// </summary>
        public JsNumber firstDay { get; set; }
        //TODO: should create an eunm?

        /// <summary>
        /// Displays the calendar in right-to-left mode.
        /// default: false
        /// This option is useful for right-to-left languages such as Arabic and Hebrew.
        /// </summary>
        public bool isRTL { get; set; }

        /// <summary>
        /// Whether to include Saturday/Sunday columns in any of the calendar views.
        /// default: true
        /// </summary>
        public bool weekends { get; set; }

        /// <summary>
        /// Determines the number of weeks displayed in a month view. Also determines each week's height.
        /// default: 'fixed'
        /// Available options:
        /// 'fixed'
        /// The calendar will always be 6 weeks tall. The height will always be the same, as determined by height, contentHeight, or aspectRatio.
        /// 'liquid'
        /// The calendar will have either 4, 5, or 6 weeks, depending on the month. The height of the weeks will stretch to fill the available height, as determined by height, contentHeight, or aspectRatio.
        /// 'variable'
        /// The calendar will have either 4, 5, or 6 weeks, depending on the month. Each week will have the same constant height, meaning the calendar’s height will change month-to-month.
        /// </summary>
        [JsProperty(Name = "weekMode")]
        public JsString weekModeString { get; set; }

        /// <summary>
        /// Determines the number of weeks displayed in a month view. Also determines each week's height.
        /// default: 'fixed'
        /// Available options:
        /// 'fixed'
        /// The calendar will always be 6 weeks tall. The height will always be the same, as determined by height, contentHeight, or aspectRatio.
        /// 'liquid'
        /// The calendar will have either 4, 5, or 6 weeks, depending on the month. The height of the weeks will stretch to fill the available height, as determined by height, contentHeight, or aspectRatio.
        /// 'variable'
        /// The calendar will have either 4, 5, or 6 weeks, depending on the month. Each week will have the same constant height, meaning the calendar’s height will change month-to-month.
        /// </summary>
        public weekModeType weekMode { get; set; }

        /// <summary>
        /// Will make the entire calendar (including header) a pixel height.
        /// By default, this option is unset and the calendar's height is calculated by aspectRatio.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     height: 650
        /// });
        ///</code>
        ///</example>
        public JsNumber height { get; set; }
        //TODO: http://arshaw.com/fullcalendar/docs/display/height/ (Setter)

        /// <summary>
        /// Will make the calendar's content area a pixel height.
        /// By default, this option is unset and the calendar's height is calculated by aspectRatio.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$('#calendar').fullCalendar({
        ///     contentHeight: 600
        /// });
        ///</code>
        ///</example>
        public JsNumber contentHeight { get; set; }
        //TODO: http://arshaw.com/fullcalendar/docs/display/contentHeight/ (Setter)

        /// <summary>
        /// Determines the width-to-height aspect ratio of the calendar.
        /// A calendar is a block-level element that fills its entire avaiable width.
        /// The calendar’s height, however, is determined by this ratio of width-to-height. (Hint: larger numbers make smaller heights).
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $('#calendar').fullCalendar({
        ///     aspectRatio: 2
        /// });
        ///</code>
        ///</example>
        public float aspectRatio { get; set; }
        //TODO: http://arshaw.com/fullcalendar/docs/display/aspectRatio/ (Setter)

        /// <summary>
        /// Triggered when the calendar loads and every time a different date-range is displayed.
        /// function( view ) { }
        /// The calendar's date-range changes whenever the user switches to a new view (for example, if they switch from "month" to "agendaWeek") or when they click the prev/next buttons.
        /// view is the current View Object.
        /// Within the callback function, this will be set to the calendar's main element.
        /// </summary>
        public JsAction<View> viewDisplay { get; set; }

        /// <summary>
        /// Triggered after the calendar's dimensions have been changed due to the browser window being resized.
        /// function( view ) { }
        /// The calendar has automatically adapted to the new size when windowResize is triggered.
        /// view is the current View Object.
        /// Within the callback function, this will be set to the calendar's main element.
        /// </summary>
        public JsAction<View> windowResize { get; set; }



    }

    /// <summary>
    /// Triggered when dragging stops and the event has moved to a different day/time.
    /// </summary>
    /// <param name="event">event is an Event Object that hold the event's information (date, title, etc).</param>
    /// <param name="dayDelta">dayDelta holds the number of days the event was moved forward (a positive number) or backwards (a negative number).</param>
    /// <param name="minuteDelta">minuteDelta holds the number of minutes the event was moved forward (a positive number) or backwards (a negative number). Only useful for the agenda views. In other views, 0 is passed in.</param>
    /// <param name="allDay">allDay is true if the event has been dropped on a day in month view, or the "all-day" slot in the agenda views. It will be false if dropped on a slot in the agenda views (meaning it has been assigned a time).</param>
    /// <param name="revertFunc">revertFunc is a function that, if called, reverts the event's start/end date to the values before the drag. This is useful if an ajax call should fail.</param>
    /// <param name="jsEvent">jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.</param>
    /// <param name="ui">ui holds the jQuery UI object.</param>
    /// <param name="view">view holds the current View Object.</param>
    public delegate void EventDrop(Event @event, JsNumber dayDelta, JsNumber minuteDelta, bool allDay, object revertFunc, Event jsEvent, jQuery.jQuery ui, View view);

    /// <summary>
    /// Triggered when resizing stops and the event has changed in duration.
    /// </summary>
    /// <param name="event">event is an Event Object that hold the event's information (date, title, etc).</param>
    /// <param name="dayDelta">dayDelta holds the number of days the event was moved forward (a positive number) or backwards (a negative number).</param>
    /// <param name="minuteDelta">minuteDelta holds the number of minutes the event was moved forward (a positive number) or backwards (a negative number). Only useful for the agenda views. In other views, 0 is passed in.</param>
    /// <param name="revertFunc">revertFunc is a function that, if called, reverts the event's start/end date to the values before the drag. This is useful if an ajax call should fail.</param>
    /// <param name="jsEvent">jsEvent holds the native JavaScript event with low-level information such as mouse coordinates.</param>
    /// <param name="ui">ui holds the jQuery UI object.</param>
    /// <param name="view">view holds the current View Object.</param>
    public delegate void EventResize(Event @event, JsNumber dayDelta, JsNumber minuteDelta, object revertFunc, Event jsEvent, jQuery.jQuery ui, View view);

    public enum weekModeType
    {
        /// <summary>
        ///  The calendar will always be 6 weeks tall. The height will always be the same, as determined by height, contentHeight, or aspectRatio.
        /// </summary>
        @fixed,
        /// <summary>
        /// The calendar will have either 4, 5, or 6 weeks, depending on the month.
        /// The height of the weeks will stretch to fill the available height, as determined by height, contentHeight, or aspectRatio.
        /// </summary>
        liquid,
        /// <summary>
        /// The calendar will have either 4, 5, or 6 weeks, depending on the month.
        /// Each week will have the same constant height, meaning the calendar’s height will change month-to-month.
        /// </summary>
        variable,
    }

    /// <summary>
    /// FullCalendar has a number of different "views", or ways of displaying days and events. The following 5 views are all built in to FullCalendar:
    /// You can define header buttons to allow the user to switch between them. You can set the initial view of the calendar with the defaultView option.
    /// </summary>
    public enum AvailableViews
    {
        month,
        /// <summary>
        ///  (available since version 1.3)
        /// </summary>
        basicWeek,
        /// <summary>
        /// (available since version 1.3)
        /// </summary>
        basicDay,
        /// <summary>
        /// (available since version 1.4)
        /// </summary>
        agendaWeek,
        /// <summary>
        /// (available since version 1.4)
        /// </summary>
        agendaDay,
    }

    /// <summary>
    /// An object that is passed to every callback, containing info about the current view.
    /// </summary>
    public class View
    {
        /// <summary>
        /// Name of one of the Available Views 
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// Title text that is displayed at the top of the header (such as "September 2009" or "Sep 7 - 13 2009").
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// A Date object of the first day of the month/week. If in day-view, the date of the single day.
        /// </summary>
        public JsDate start { get; set; }

        /// <summary>
        /// A Date object of the day after the last day of the month/week. If in day-view, the Date after the single day.
        /// Because this is an exclusive value, if the calendar has a month-view on October 2009, end will be November 1st.
        /// </summary>
        public JsDate end { get; set; }

        /// <summary>
        ///A Date object of the first visible day of the view. In month-view, this value is often before the 1st day of the month, because most months do not begin on a Monday.
        ///In week and day views, this value will always be the same as start.
        /// </summary>
        public JsDate visStart { get; set; }

        /// <summary>
        /// A Date object of the day after the last visible day (because it is exclusive like end).
        /// </summary>
        public JsDate visEnd { get; set; }
    }

    /// <summary>
    /// the class is empty
    /// </summary>
    public class ViewOptionHash
    {
    }
    //TODO: the class is empty. http://arshaw.com/fullcalendar/docs/views/View_Option_Hash/

    /// <summary>
    /// The following options only apply to the agendaWeek and agendaDay views:
    /// </summary>
    public class AgendaOptions
    {
        /// <summary>
        /// Determines if the "all-day" slot is displayed at the top of the calendar.
        ///  default: true
        ///  When hidden with false, all-day events will not be displayed in agenda views.
        /// </summary>
        public bool allDaySlot { get; set; }

        /// <summary>
        /// The text titling the "all-day" slot at the top of the calendar.
        /// default: 'all-day'
        /// </summary>
        public JsString allDayText { get; set; }

        /// <summary>
        /// Determines the time-text that will be displayed on the vertical axis of the agenda views.
        /// default: 'h(:mm)tt'
        /// The value is a format-string that will be processed by formatDate.
        /// The default value will produce times that look like "5pm" and "5:30pm".
        /// </summary>
        public JsString axisFormat { get; set; }
        //TODO: must check

        /// <summary>
        /// The frequency for displaying time slots, in minutes.
        /// default: 30
        /// The default will make a slot every half hour.
        /// </summary>
        public JsNumber slotMinutes { get; set; }

        /// <summary>
        /// Determines the length (in minutes) an event appears to be when it has an unspecified end date.
        /// default: 120
        /// By default, if an Event Object as no end, it will appear to be 2 hours.
        /// This option only affects events that appear in the agenda slots, meaning they have allDay set to true.
        /// </summary>
        public JsNumber defaultEventMinutes { get; set; }

        /// <summary>
        /// Determines the first hour that will be visible in the scroll pane.
        /// default: 6
        /// Values must be from 0-23, where 0=midnight, 1=1am, etc.
        /// The user will be able to scroll upwards to see events before this time. If you want to prevent users from doing this, use the minTime option instead.
        /// </summary>
        public JsNumber firstHour { get; set; }

        /// <summary>
        /// Determines the first hour/time that will be displayed, even when the scrollbars have been scrolled all the way up.
        /// default: 0
        /// This can be a number like 5 (which means 5am), a string like '5:30' (which means 5:30am) or a string like '5:30am'.
        /// </summary>
        public JsNumber minTime { get; set; }
        /// <summary>
        /// Determines the first hour/time that will be displayed, even when the scrollbars have been scrolled all the way up.
        /// default: 0
        /// This can be a number like 5 (which means 5am), a string like '5:30' (which means 5:30am) or a string like '5:30am'.
        /// </summary>
        [JsProperty(Name = "minTime")]
        public JsString minTimeString { get; set; }

        /// <summary>
        /// Determines the last hour/time (exclusively) that will be displayed, even when the scrollbars have been scrolled all the way down.
        /// default: 24
        /// This can be a number like 22 (which means 10pm), a string like '22:30' (which means 10:30pm) or a string like '10:30pm'.
        /// </summary>
        public JsNumber maxTime { get; set; }
        /// <summary>
        /// Determines the last hour/time (exclusively) that will be displayed, even when the scrollbars have been scrolled all the way down.
        /// default: 24
        /// This can be a number like 22 (which means 10pm), a string like '22:30' (which means 10:30pm) or a string like '10:30pm'.
        /// </summary>
        [JsProperty(Name = "maxTime")]
        public JsString maxTimeString { get; set; }
    }
    //TODO: what should i do with this class now?

    public class Event
    {
        /// <summary>
        /// Optional
        /// Uniquely identifies the given event. Different instances of repeating events should all have the same id.
        /// </summary>
        [JsProperty(Name = "id")]
        public JsString idString { get; set; }
        /// <summary>
        /// Optional
        /// Uniquely identifies the given event. Different instances of repeating events should all have the same id.
        /// </summary>
        public JsNumber id { get; set; }

        /// <summary>
        /// Required.
        /// The text on an event's element
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// Optional.
        /// Whether an event occurs at a specific time-of-day. This property affects whether an event's time is shown. Also, in the agenda views, determines if it is displayed in the "all-day" section.
        /// Don't include quotes around your true/false. This value is not a string!
        /// When specifying Event Objects for events or eventSources, omitting this property will make it inherit from allDayDefault, which is normally true.
        /// </summary>
        public bool allDay { get; set; }

        /// <summary>
        ///  Required.
        ///  The date/time an event begins.
        ///  When specifying Event Objects for events or eventSources, you may specify a string in IETF format (ex: "Wed, 18 Oct 2009 13:00:00 EST"), a string in ISO8601 format (ex: "2009-11-05T13:15:30Z") or a UNIX timestamp.
        /// </summary>
        public JsDate start { get; set; }

        /// <summary>
        ///Date. Optional.
        /// The date/time an event ends.
        /// As with start, you may specify it in IETF, ISO8601, or UNIX timestamp format.
        /// If an event is all-day...
        /// the end date is inclusive. This means an event with start Nov 10 and end Nov 12 will span 3 days on the calendar.
        /// If an event is NOT all-day...
        /// the end date is exclusive. This is only a gotcha when your end has time 00:00. It means your event ends on midnight, and it will not span through the next day.
        /// </summary>
        public JsDate end { get; set; }

        /// <summary>
        /// Optional.
        /// A URL that will be visited when this event is clicked by the user. For more information on controlling this behavior, see the eventClick callback.
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        /// Optional.
        /// A CSS class (or array of classes) that will be attached to this event's element.
        /// </summary>
        public JsString className { get; set; }
        /// <summary>
        /// Optional.
        /// A CSS class (or array of classes) that will be attached to this event's element.
        /// </summary>
        [JsProperty(Name = "className")]
        public JsArray classNameArray { get; set; }

        /// <summary>
        ///  Optional.
        ///  Overrides the master editable option for this single event.
        /// </summary>
        public bool editable { get; set; }

        /// <summary>
        /// Automatically populated.
        /// A reference to the event source that this event came from
        /// </summary>
        public EventSource source { get; set; }

        //TODO:
        //color
        //Sets an event's background and border color just like the calendar-wide eventColor option.
        //
        //backgroundColor
        //Sets an event's background color just like the calendar-wide eventBackgroundColor option.
        //
        //borderColor
        //Sets an event's border color just like the the calendar-wide eventBorderColor option.
        //
        //textColor
        //Sets an event's text color just like the calendar-wide eventTextColor option.
        //
        //Non-standard Fields
        //In addition to the fields above, you may also include your own non-standard fields in each Event Object. FullCalendar will not modify or delete these fields. For example, developers often include a description field for use in callbacks such as eventRender.
    }

    public class EventSource
    {
        //TODO: empty, needs to be done. not sure how. http://arshaw.com/fullcalendar/docs/event_data/Event_Source_Object/
    }

    //TODO: Utilities - http://arshaw.com/fullcalendar/docs/utilities/
}
