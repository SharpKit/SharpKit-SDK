
using SharpKit.JavaScript;

namespace SharpKit.TheMProject
{
    #region Components & Utilities

    /// <summary>
    /// M.Controller is the prototype of any controller within your application.
    /// It basically provides two very important methods you will use in most of your applications.
    /// The first one is responsible for switching pages, the second one is the key to the whole content binding feature and triggers rendering updates if content did change.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Controller", Export = false)]
    public class Controller
    {
        /// <summary>
        /// This method initializes the notification of all observers, that observe the property behind 'key'.
        /// So you will use this method out of a controller to inform the application that a property, respectively some content, did change.
        /// See Content Binding for more information about that.
        /// </summary>
        /// <param name="key">The key of the property to be changed.</param>
        /// <param name="value">The value to be set.</param>
        public void set(JsString key, object value) { }
        /// <summary>
        /// This method initializes the notification of all observers, that observe the property behind 'key'.
        /// So you will use this method out of a controller to inform the application that a property, respectively some content, did change.
        /// See Content Binding for more information about that.
        /// </summary>
        /// <param name="key">The key of the property to be changed.</param>
        /// <param name="value">The value to be set.</param>
        public void set(JsString key, JsString value) { }

        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        /// <param name="updateHistory">Update the browser history. Default: YES.</param>
        public void switchToPage(object page, JsString transition, bool isBack, bool updateHistory) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        /// <param name="updateHistory">Update the browser history. Default: YES.</param>
        public void switchToPage(JsString page, JsString transition, bool isBack, bool updateHistory) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        public void switchToPage(object page, JsString transition, bool isBack) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        /// <param name="isBack">YES will cause a reverse-direction transition. Default: NO.</param>
        public void switchToPage(JsString page, JsString transition, bool isBack) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        public void switchToPage(object page, JsString transition) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        /// <param name="transition">The transition that should be used. Default: horizontal slide.</param>
        public void switchToPage(JsString page, JsString transition) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        public void switchToPage(object page) { }
        /// <summary>
        /// This method will perform a page switch based on the passed parameters or the default values.
        /// To learn more about how to use this method, take a look at our tutorial How to switch a page.
        /// </summary>
        /// <param name="page">The page to be displayed or its name.</param>
        public void switchToPage(JsString page) { }

        /// <summary>
        /// This method will perform a page switch to the passed tab. Internally this is used whenever a user taps/clicks on a tab.
        /// But you can also trigger such a switch programmatically out of your application if necessary.
        /// </summary>
        /// <param name="tab">The tab to be activated.</param>
        public void switchToTab(TabBarView tab) { }
    }

    /// <summary>
    /// Since JavaScript's date object doesn't provide lots of built-in functionality, we decided to create a wrapper for this, called M.Date.
    /// This utility object is equipped with many convenient and easy to use methods you will need whenever you are dealing with dates.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Date", Export = false)]
    public class Date
    {
        /// <summary>
        /// This method returns the current date, encapsulated in an M.Date object.
        /// </summary>
        /// <returns></returns>
        public Date now() { return null; }

        /// <summary>
        /// This method internally creates the current date, transfers it 24 hours into the future and returns this date, encapsulated in an M.Date object.
        /// </summary>
        /// <returns></returns>
        public Date tomorrow() { return null; }

        /// <summary>
        /// This method internally creates the current date, transfers it 24 hours into the past and returns this date, encapsulated in an M.Date object.
        /// </summary>
        /// <returns></returns>
        public Date yesterday() { return null; }

        /// <summary>
        /// This method returns a date for a given date string. It is based on JS Date's parse method. The following formats are accepted (time and timezone are optional):
        /// 11/12/2010
        /// 11/12/2010 15:28:15
        /// 11/12/2010 13:28:15 GMT
        /// 11/12/2010 15:28:15 GMT+0200
        /// 12 November 2010
        /// 12 November 2010 15:28:15
        /// 12 November 2010 13:28:15 GMT
        /// 12 November 2010 15:28:15 GMT+0200
        /// 12 Nov 2010
        /// 12 Nov 2010 15:28:15
        /// 12 Nov 2010 13:28:15 GMT
        /// 12 Nov 2010 15:28:15 GMT+0200
        /// If a wrong formatted date string is given, the method will return null. Otherwise an M.Date object will be returned.
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public Date create(JsString dateString) { return null; }

        /// <summary>
        /// This method formats a given date object according to the passed format property and returns it as a String. The following list defines the special characters that can be used in the format property to format the given date:
        /// d Day of the month as digits; no leading zero for single-digit days.
        /// dd Day of the month as digits; leading zero for single-digit days.
        /// ddd Day of the week as a three-letter abbreviation.
        /// dddd Day of the week as its full name.
        /// D Day of the week as number.
        /// m Month as digits; no leading zero for single-digit months.
        /// mm Month as digits; leading zero for single-digit months.
        /// mmm Month as a three-letter abbreviation.
        /// mmmm Month as its full name.
        /// yy Year as last two digits; leading zero for years less than 10.
        /// yyyy Year represented by four digits.
        /// h Hours; no leading zero for single-digit hours (12-hour clock).
        /// hh Hours; leading zero for single-digit hours (12-hour clock).
        /// HH ours; no leading zero for single-digit hours (24-hour clock).
        /// HH Hours; leading zero for single-digit hours (24-hour clock).
        ///  MMinutes; no leading zero for single-digit minutes.
        /// MM Minutes; leading zero for single-digit minutes.
        /// s Seconds; no leading zero for single-digit seconds.
        /// ss Seconds; leading zero for single-digit seconds.
        /// l or L Milliseconds. l gives 3 digits. L gives 2 digits.
        /// t Lowercase, single-character time marker string: a or p.
        /// tt Lowercase, two-character time marker string: am or pm.
        /// T Uppercase, single-character time marker string: A or P.
        /// TT Uppercase, two-character time marker string: AM or PM.
        /// Z US timezone abbreviation, e.g. EST or MDT. With non-US timezones or in the Opera browser, the GMT/UTC offset is returned, e.g. GMT-0500
        /// o GMT/UTC timezone offset, e.g. -0500 or +0230.
        /// S The date's ordinal suffix (st, nd, rd, or th). Works well with d.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public JsString format(JsString format) { return null; }

        /// <summary>
        /// This method returns the current date as a timestamp, e.g: 1308907720887
        /// </summary>
        /// <returns></returns>
        public JsNumber getTimestamp() { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on days.
        /// Basically it adds or subtracts x times the milliseconds of a day,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="days">The number of days to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date daysFromNow(JsNumber days) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on days and the current date.
        /// Basically it adds or subtracts x times the milliseconds of a day,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="days">The number of days to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date daysFromDate(JsNumber days) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on hours.
        /// Basically it adds or subtracts x times the milliseconds of an hour,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="hours">The number of hours to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date hoursFromNow(JsNumber hours) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on hours and the current date.
        /// Basically it adds or subtracts x times the milliseconds of an hour,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="hours">The number of hours to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date hoursFromDate(JsNumber hours) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on minutes.
        /// Basically it adds or subtracts x times the milliseconds of a minute,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="minutes">The number of minutes to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date minutesFromNow(JsNumber minutes) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on minutes and the current date.
        /// Basically it adds or subtracts x times the milliseconds of a minute,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="minutes">The number of minutes to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date minutesFromDate(JsNumber minutes) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on seconds.
        /// Basically it adds or subtracts x times the milliseconds of a second,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="seconds">The number of seconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date secondsFromNow(JsNumber seconds) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on seconds and the current date.
        /// Basically it adds or subtracts x times the milliseconds of a second,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="seconds">The number of seconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date secondsFromDate(JsNumber seconds) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on milliseconds.
        /// Basically it adds or subtracts x milliseconds,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date millisecondsFromNow(JsNumber milliseconds) { return null; }

        /// <summary>
        /// This method returns a date in the future or past, based on milliseconds and the current date.
        /// Basically it adds or subtracts x milliseconds,
        /// but also checks for clock changes and automatically includes these into the calculation of the future or past date.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds to be added to or subtracted from the current date.</param>
        /// <returns></returns>
        public Date millisecondsFromDate(JsNumber milliseconds) { return null; }

        /// <summary>
        /// This method returns the time between two dates, based on the given returnType. Possible return types are:
        /// M.MILLISECONDS: milliseconds
        /// M.SECONDS: seconds
        /// M.MINUTES: minutes
        /// M.HOURS: hours
        /// M.DAYS: days
        /// </summary>
        /// <param name="date"></param>
        /// <param name="returnType"></param>
        /// <returns></returns>
        public JsNumber timeBetween(Date date, JsString returnType) { return null; }

        /// <summary>
        /// This method computes the calendar week of a date. It can either be executed on a M.Date object,
        /// to get the calendar week of that date, or you can pass parameters to get the calendar week for the specified date.
        /// </summary>
        /// <param name="year"> The year part of the date, e.g. 2011. Must be four digits.</param>
        /// <param name="month">The month part of the date: 0-11. Must be one/two digit.</param>
        /// <param name="day">The day part of the date: 1-31. Must be one/two digits.</param>
        /// <returns></returns>
        public JsNumber getCalendarWeek(JsNumber year, JsNumber month, JsNumber day) { return null; }

        /// <summary>
        /// This method returns an array containing all dates within one calendar week as an M.Date object..
        /// If no parameters are given, the calendar week of the current date is taken.
        /// </summary>
        /// <param name="calendarWeek">The calendar week. Note: Pass 'null' if you use this method on an existing M.Date object.</param>
        /// <param name="startWeekOnMonday">Determines whether a week starts on monday or sunday. Optional, default is NO.</param>
        /// <param name="year">The year. Optional, default is current year.</param>
        /// <returns></returns>
        public JsArray getDatesOfCalendarWeek(JsNumber calendarWeek, bool startWeekOnMonday, JsNumber year) { return null; }
        /// <summary>
        /// This method returns an array containing all dates within one calendar week as an M.Date object..
        /// If no parameters are given, the calendar week of the current date is taken.
        /// </summary>
        /// <param name="calendarWeek">The calendar week. Note: Pass 'null' if you use this method on an existing M.Date object.</param>
        /// <param name="startWeekOnMonday">Determines whether a week starts on monday or sunday. Optional, default is NO.</param>
        /// <returns></returns>
        public JsArray getDatesOfCalendarWeek(JsNumber calendarWeek, bool startWeekOnMonday) { return null; }
        /// <summary>
        /// This method returns an array containing all dates within one calendar week as an M.Date object..
        /// If no parameters are given, the calendar week of the current date is taken.
        /// </summary>
        /// <param name="calendarWeek">The calendar week. Note: Pass 'null' if you use this method on an existing M.Date object.</param>
        /// <returns></returns>
        public JsArray getDatesOfCalendarWeek(JsNumber calendarWeek) { return null; }

        /// <summary>
        /// This method returns a date (M.Date) for a given calendar week and day of this week.
        /// </summary>
        /// <param name="calendarWeek"> The calendar week. or sunday. Optional, default is NO.</param>
        /// <param name="dayOfWeek">The day of the week (0 = sunday, ..., 7 = saturday).</param>
        /// <param name="year">The year. Optional, default is current year.</param>
        /// <returns></returns>
        public JsNumber getDateByWeekdayAndCalendarWeek(JsNumber calendarWeek, JsNumber dayOfWeek, JsNumber year) { return null; }
        /// <summary>
        /// This method returns a date (M.Date) for a given calendar week and day of this week.
        /// </summary>
        /// <param name="calendarWeek"> The calendar week. or sunday. Optional, default is NO.</param>
        /// <param name="dayOfWeek">The day of the week (0 = sunday, ..., 7 = saturday).</param>
        /// <returns></returns>
        public JsNumber getDateByWeekdayAndCalendarWeek(JsNumber calendarWeek, JsNumber dayOfWeek) { return null; }
        /// <summary>
        /// This method returns a date (M.Date) for a given calendar week and day of this week.
        /// </summary>
        /// <param name="dayOfWeek">The day of the week (0 = sunday, ..., 7 = saturday).</param>
        /// <returns></returns>
        public JsNumber getDateByWeekdayAndCalendarWeek(JsNumber dayOfWeek) { return null; }

    }
    //TODO: is it ok to call a class that name?

    /// <summary>
    /// The M.Environment object provides information about the environment that your app is running in. It provides methods that return the respective state of the environment:
    /// user agent
    /// platform
    /// viewport size
    /// device orientation
    /// connection status (online/offline)
    /// In several methods, it accesses the global navigator object.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Environment", Export = false)]
    public class Environment
    {
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        /// <param name="url"> A URL defining a location of an image that is tried to include. If nothing is passed, a default url is used.</param>
        public void getConnectionStatus(JsAction callback, JsString url) { }
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        public void getConnectionStatus(JsAction callback) { }
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        /// <param name="url"> A URL defining a location of an image that is tried to include. If nothing is passed, a default url is used.</param>
        public void getConnectionStatus(JsString callback, JsString url) { }
        /// <summary>
        /// The method returns the connection status of the device by invoking a callback function with the status passed.
        /// The status is retrieved by trying to insert an image (tag) into the DOM whose reference URL is a remote stored image
        /// (by default the google logo of google.de is used - we assume that if google is down, you're not connected.
        /// If this is not reliable enough, simply pass your URL as second parameter to the method call).
        /// </summary>
        /// <param name="callback">The callback object defining target and action.
        /// It is also possible to just pass a function to action instead of a string naming the method in a controller.
        /// A constant string (M.ONLINE or M.OFFLINE) is passed to the callback as parameter defining whether the device is online or offline.</param>
        public void getConnectionStatus(JsString callback) { }

        /// <summary>
        /// The method maps to navigator.userAgent and returns the user agent string defined by the browser. The string defines several useful information.
        /// </summary>
        /// <returns>The user agent string.</returns>
        public JsString getUserAgent() { return null; }

        /// <summary>
        /// The method maps to navigator.platform and returns a platform string.
        /// </summary>
        /// <returns> A platform string, e.g. 'MacIntel'.</returns>
        public JsString getPlatform() { return null; }

        /// <summary>
        /// The method returns the currently available width and height of the browser window as an array.
        /// </summary>
        /// <returns>Width and height as numbers in an array: 
        /// [0]: width 
        /// [1]: height</returns>
        public JsArray getSize() { return null; }

        /// <summary>
        /// The method returns the width of the user's browser window (and therefor uses getSize).
        /// </summary>
        /// <returns>The width of the user's browser window.</returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// The method returns the height of the user's browser window (and therefor uses getSize).
        /// </summary>
        /// <returns>The height of the user's browser window.</returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// The method returns the total width and height of the document. Uses getTotalWidth and getTotalHeight.
        /// </summary>
        /// <returns>Width and height as numbers in an array: 
        /// [0]: width 
        /// [1]: height</returns>
        public JsArray getTotalHeight() { return null; }

        /// <summary>
        /// The method returns the total width of the document.
        /// </summary>
        /// <returns> The total width of the document.</returns>
        public JsString getTotalWidth() { return null; }

        /// <summary>
        /// This method returns the device's current orientation, depending on whether or not the device is capable of detecting the current orientation.
        /// If the device is unable to detect the current orientation, this method will return NO.
        /// </summary>
        /// <returns>Number or Boolean: The orientation type as a constant value. If the orientation can not be detected: NO. 
        /// Possible orientation values:
        /// M.PORTRAIT_TOP
        /// M.PORTRAIT_BOTTOM
        /// M.LANDSCAPE_LEFT
        /// M.LANDSCAPE_RIGHT</returns>
        public object getOrientation() { return null; }
    }

    /// <summary>
    /// With M.I18N, The-M-Project provides a tool for internationalisation and localisation.
    /// It can be used to set and get the application's language and to localize any string within an application.
    /// Such a string, for example, can be a label, a url or a path to an image.
    /// To get an idea of what is possible with this feature, take a look at our Todos demo application and switch the language.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.I18N", Export = false)]
    public class I18N
    {
        /// <summary>
        /// This method is used to get a language for the current user. This process is divided into four steps. If one step leads to a language, this one is returned. The steps are prioritized as follows:
        /// 1.get a previously stored language for the user (set by setLanguage)
        /// 2.get the user's language by checking his navigator
        /// 3.use the application's default language
        /// 4.use the systems's default language
        /// </summary>
        /// <returns></returns>
        public JsString getLanguage() { return null; }

        /// <summary>
        /// This method checks if the passed language is available within the application or not.
        /// Normally you, as a developer, should know what language your application support.
        /// Anyway, you can use this method to learn whether a language is supported or not.
        /// </summary>
        /// <param name="language">The language to be checked.</param>
        /// <returns></returns>
        public bool isLanguageAvailable(JsString language) { return false; }

        /// <summary>
        /// This method returns the localized string for the given key based on the current language. 
        /// If context is passed, the input string is searched for pattern &lt;%= the_key %> to be replaced by the property named the_key of context.
        /// With this, dynamic parts in translations can be achieved.
        /// </summary>
        /// <param name="key">The key to the localized string.</param>
        /// <param name="context">Optional. An object defining the values for a parameterized, dynamic translation.</param>
        /// <returns></returns>
        public JsString l(JsString key, object context) { return null; }
        /// <summary>
        /// This method returns the localized string for the given key based on the current language. 
        /// If context is passed, the input string is searched for pattern &lt;%= the_key %> to be replaced by the property named the_key of context.
        /// With this, dynamic parts in translations can be achieved.
        /// </summary>
        /// <param name="key">The key to the localized string.</param>
        /// <returns></returns>
        public JsString l(JsString key) { return null; }

        /// <summary>
        /// This method sets the application's current language and forces it to reload. After the reload, the application will be displayed in the selected language.
        /// Note: Even though we force a reload of the application, this features works offline, too! so don't hesitate to localize your app, you won't lose any functionality.
        /// </summary>
        /// <param name="language"> The language to be set.</param>
        public void setLanguage(JsString language) { }
    }

    /// <summary>
    /// It is used to log messages out of the application based on a given logging level.
    /// There are four logging levels available:
    /// M.INFO
    /// M.DEBUG
    /// M.WARN
    /// M.ERR
    /// By defining a logging level, the developer can decide the importance of a logged message.
    /// The screenshot below shows the particular output on the JavaScript console (here in Chrome Developer Tools).
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Logger", Export = false)]
    public class Logger
    {
        /// <summary>
        /// Logs the passed message on the console. The type of output is defined via an optional passed logging level. If no level is passed, M.DEBUG is used by default.
        /// The method also takes care, that things don't blow up, when this object is used in browsers that don't support this or don't have a console.
        /// </summary>
        /// <param name="msg">The logging message.</param>
        /// <param name="level">level (Number, optional): The logging level, as a number from 0 to 3. Can be passed via constant:
        /// M.INFO: 0
        /// M.DEBUG: 1
        /// M.WARN: 2
        /// M.ERR: 3</param>
        public void log(JsString msg, JsNumber level) { }
        /// <summary>
        /// Logs the passed message on the console. The type of output is defined via an optional passed logging level. If no level is passed, M.DEBUG is used by default.
        /// The method also takes care, that things don't blow up, when this object is used in browsers that don't support this or don't have a console.
        /// </summary>
        /// <param name="msg">The logging message.</param>
        public void log(JsString msg) { }

    }

    /// <summary>
    /// Making Ajax requests and accessing remote services is fundamental to every modern web application.
    /// The-M-Project provides an object, M.Request, to make requests. Basically, it uses jQuery to fulfill this task.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Request", Export = false)]
    public class Request
    {
        /// <summary>
        /// Any request must be initialized with this method before it is possible to send.
        /// </summary>
        /// <param name="obj">obj (Object): The parameter object. The object has the following properties:
        /// url (String): the request url, e.g. 'search.twitter.com/search.json' (needs a proxy to be set because of Same-Origin-Policy)
        /// method (String): the http method to use, e.g. 'POST', defaults to 'GET'.
        /// isAsync (Boolean): defines whether request should be made async or not. defaults to YES. Should be YES.
        /// isJSON (Boolean): defines whether to process request and response as JSON, defaults to NO.
        /// timout (Number): defines timeout in milliseconds (optional)
        /// data (String|Object): the data to be transmitted (optional)
        /// beforeSend (function): callback that is called before request is sent (optional)
        /// onError (function): callback that is called when an error occured (optional)
        /// onSuccess (function): callback that is called when request was successful (optional)</param>
        /// <returns>The initialized request object.</returns>
        public Request init(InitOptions obj) { return null; }

        /// <summary>
        /// This methods sends a request, defined by its parameters.
        /// </summary>
        public void send() { }

        /// <summary>
        /// This methods aborts a request.
        /// </summary>
        /// <returns>A boolean value indicating whether the .</returns>
        public bool abort() { return false; }
    }

    [JsType(JsMode.Json)]
    public class InitOptions
    {
        /// <summary>
        /// the request url, e.g. 'search.twitter.com/search.json' (needs a proxy to be set because of Same-Origin-Policy)
        /// </summary>
        public JsString url { get; set; }

        /// <summary>
        ///  the http method to use, e.g. 'POST', defaults to 'GET'.
        /// </summary>
        public JsString method { get; set; }

        /// <summary>
        /// defines whether request should be made async or not. defaults to YES. Should be YES.
        /// </summary>
        public bool isAsync { get; set; }

        /// <summary>
        /// defines whether to process request and response as JSON, defaults to NO.
        /// </summary>
        public bool isJSON { get; set; }

        /// <summary>
        /// defines timeout in milliseconds (optional)
        /// </summary>
        public JsNumber timout { get; set; }

        /// <summary>
        /// the data to be transmitted (optional)
        /// </summary>
        [JsProperty(Name = "data")]
        public JsString dataString { get; set; }
        /// <summary>
        /// the data to be transmitted (optional)
        /// </summary>
        public object data { get; set; }

        /// <summary>
        ///  callback that is called before request is sent (optional)
        /// </summary>
        public JsAction beforeSend { get; set; }

        /// <summary>
        /// callback that is called when an error occured (optional)
        /// </summary>
        public JsAction onError { get; set; }

        /// <summary>
        /// callback that is called when request was successful (optional)
        /// </summary>
        public JsAction onSuccess { get; set; }

    }

    /// <summary>
    /// The M.Math object wraps JavaScript's Math object and extends it with several own methods. It offers methods for:
    /// expontentiate
    /// retrieving random numbers in a range
    /// rounding
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Math", Export = false)]
    public class Math
    {
        /// <summary>
        /// This method returns the value of the base to the power of the exponent. So e.g. pow(2, 3) would return '2 to the power of 3' --> 8.
        /// </summary>
        /// <param name="base">The base.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns>The result of the exponentiation operation.</returns>
        public JsNumber pow(JsNumber @base, JsNumber exponent) { return null; }
        //TODO: parametrs type?

        /// <summary>
        /// The method returns a random number within the range given by the min property and the max property, including the min and max value.
        /// A test with 100.000 iterations for random(1, 3) created the following distribution:
        /// - 1: 33.2% 
        /// - 2: 33.2% 
        /// - 3: 33.6%
        /// </summary>
        /// <param name="min"> The minimal value.</param>
        /// <param name="max">The maximal value.</param>
        /// <returns>A random number between the passed range.</returns>
        public JsNumber random(JsNumber min, JsNumber max) { return null; }

        /// <summary>
        /// The method returns rounded version of the given input number.
        /// The type of rounding is defined by the second parameter: type. With the optional third parameter decimals, you can specify the number of decimal digits to be returned.
        /// For example round(1.2345, M.FLOOR, 3) would return 1.234. The default for this parameter is 0.
        /// </summary>
        /// <param name="input"> The input value.</param>
        /// <param name="type">The type of rounding. Needs to be one of these three:
        /// M.FLOOR: Returns the next lower integer, so 2.1 and 2.9 both would return 2.
        /// M.CEIL: Returns the next higher integer, so 2.1 and 2.9 both would return 3.
        /// M.ROUND: Returns the nearest integer, so 2.1 would return 2 and 2.9 would return 3.</param>
        /// <param name="decimals">The number of decimals (only available for M.ROUND).</param>
        /// <returns>The rounded number.</returns>
        public JsNumber round(JsNumber input, object type, JsNumber decimals) { return null; }
        //TODO: type parameter's type?
        /// <summary>
        /// The method returns rounded version of the given input number.
        /// The type of rounding is defined by the second parameter: type. With the optional third parameter decimals, you can specify the number of decimal digits to be returned.
        /// For example round(1.2345, M.FLOOR, 3) would return 1.234. The default for this parameter is 0.
        /// </summary>
        /// <param name="input"> The input value.</param>
        /// <param name="type">The type of rounding. Needs to be one of these three:
        /// M.FLOOR: Returns the next lower integer, so 2.1 and 2.9 both would return 2.
        /// M.CEIL: Returns the next higher integer, so 2.1 and 2.9 both would return 3.
        /// M.ROUND: Returns the nearest integer, so 2.1 would return 2 and 2.9 would return 3.</param>
        /// <returns>The rounded number.</returns>
        public JsNumber round(JsNumber input, object type) { return null; }
        //TODO: type parameter's type?
    }

    /// <summary>
    /// The view manager manages and knows all views that are used within an application.
    /// It is one of the core components and participates in many internal operations.
    /// Everytime there is a communication between the UI, respectively the DOM,
    /// and the actual application, the JS objects, the view manager is used to dispatch notifications between these two layers.
    /// Inside your application, you would typically use the view manager for accessing views in general.
    /// It provides methods for finding a certain view within a page and it helps, retrieving pages by their name.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ViewManager", Export = false)]
    public class ViewManager
    {
        /// <summary>
        /// If you want to access the corresponding JS object of the currently displayed page, simply call this method. It returns excactly what you are looking for.
        /// </summary>
        /// <returns></returns>
        public Page getCurrentPage() { return null; }

        /// <summary>
        /// This will return the DOM id of the passed view object.
        /// </summary>
        /// <param name="view">The view for which the id value is wanted.</param>
        /// <returns></returns>
        public JsString getIdByView(object view) { return null; }

        /// <summary>
        /// This method returns the page object from the view list array identified by its name.
        /// If there are multiple pages with the same name, the first result is returned.
        /// Note: Use unique names for your pages!
        /// </summary>
        /// <param name="pageName">The name of the page to be returned.</param>
        /// <returns></returns>
        public Page getPage(JsString pageName) { return null; }

        /// <summary>
        /// This method returns the view object from the view list array identified by the view's name (targetView) and its surrounding view parentView.
        /// If there are multiple views with the same name on the same surrounding view, the first result is returned.
        /// Note: Use unique names for your views within the same surrounding view!
        /// </summary>
        /// <param name="parentView">The name of the parent view (if it is a page) or the parent view itself.</param>
        /// <param name="targetView">The name of the view to be returned.</param>
        /// <returns></returns>
        public object getView(JsString parentView, JsString targetView) { return null; }
        /// <summary>
        /// This method returns the view object from the view list array identified by the view's name (targetView) and its surrounding view parentView.
        /// If there are multiple views with the same name on the same surrounding view, the first result is returned.
        /// Note: Use unique names for your views within the same surrounding view!
        /// </summary>
        /// <param name="parentView">The name of the parent view (if it is a page) or the parent view itself.</param>
        /// <param name="targetView">The name of the view to be returned.</param>
        /// <returns></returns>
        public object getView(object parentView, JsString targetView) { return null; }

        /// <summary>
        /// This method will return the view object from an internal the view list array, identified by the value of its id property.
        /// Internally we use this method a lot. During the development process this can be very useful for debugging your application.
        /// Just take a look at the DOM, find a view that maybe causes trouble, get its id property and finally use this method to retrieve the corresponding JS object.
        /// </summary>
        /// <param name="id">The DOM id of the corresponding view object.</param>
        public void getViewById(JsString id) { }

    }

    #endregion

    /// <summary>
    /// The action sheet dialog is mostly known from iOS, where it is used in a variety of applications.
    /// It presents a dialog that offers multiple options to the user. One of these options often is a destructive action, e.g. for removing something from a collection.
    /// This button is rendered red. Another option is a 'Cancel'-Option that is used to not make a choice, but cancel it. It's rendered black in default.
    /// In addition to these two buttons, a variable number of other buttons can be defined by passing in an array to the property otherButtonValues.
    /// In difference to the other two dialogs, the action sheet does not show a message, it only shows a title and the choices represented by buttons.
    /// The action sheet's behaviour and look is defined by its properties.
    /// Note: It is also possible to pass a function as action instead of a string (this is possible throughout every callback passing). It is executed in the scope of the target.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ActionSheetDialog", Export = false)]
    public class ActionSheetDialog
    {
        /// <summary>
        /// recommended
        /// Default: "Confirm".
        /// Defines the title of the confirm dialog. The title is shown on the top of the dialog.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// optional
        /// Defines the value shown on the destructive button. If this property is not used, no destructive button is shown.
        /// </summary>
        public JsString destructiveButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Defines the value shown on the cancel button. If this property is not used, no cancel button is shown.
        /// </summary>
        public JsString cancelButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Represents array of strings defining the values of the other shown buttons. Each string represents one button and its value.
        /// </summary>
        public JsArray otherButtonValues { get; set; }

        /// <summary>
        /// optional
        /// An array of strings defining a tag for each of the buttons defined by the previously mentioned values.
        /// The number of strings in this array must match the number of values defined in otherButtonValues.
        /// If not, these tags are skipped and the index number of the button is used as tags.
        /// The index for the tag is the same as the respective index in the otherButtonValues array.
        /// The tags are used to identify which button was pressed in the callback (see below).
        /// </summary>
        public JsArray otherButtonTags { get; set; }

        /// <summary>
        /// mandatory
        /// The object defining the several callbacks. Several sub objects must be defined, when using the respective button:
        /// -destruction must be defined when having a destructive button.
        /// -cancel must be defined when having a cancel button.
        /// -other must be defined when having other buttons.
        /// There's only one callback for the other buttons.
        /// The button tag of the pressed button is passed to this callback. The user needs to decide on basis of this information what to do next.
        /// </summary>
        public object callbacks { get; set; }
    }

    /// <summary>
    /// The alert dialog view is a simple view that has two mandatory and two optional parameters: 
    /// The dialog is similar to the alert dialog that JavaScript offers with the alert('Hello World') call,
    /// except that the TMP alert dialog does not block the application.
    /// In addition it can show a much more customized title than the native JavaScript alert dialog
    /// (this one usually shows something strange like "The page at www.the-m-project.net says:" in the title bar).
    /// It is also possible to pass a callback to the dialog, that is executed after the user clicked the confirm button in the dialog.
    /// Therefore we pass the callback object with a nested object named confirm to the call. In this confirm object we define target and action.
    /// Note: It is also possible to pass a function as action instead of a string (this is possible throughout every callback passing).
    /// It is executed in the scope of the target.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.AlertDialogView", Export = false)]
    public class AlertDialogView
    {
        /// <summary>
        /// recommended
        /// Default: "Alert"
        /// Defines the title of the alert dialog. The title is shown on the top of the dialog
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// optional
        /// Defines the message of the alert dialog.
        /// </summary>
        public JsString message { get; set; }

        /// <summary>
        /// optional
        /// Default: "Ok"
        /// Defines the value of the button shown in the dialog.
        /// </summary>
        public JsString confirmButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Represents array of strings defining the values of the other shown buttons. Each string represents one button and its value.
        /// </summary>
        public JsArray otherButtonValues { get; set; }

        /// <summary>
        /// optional
        /// The object defining the confirm callback. This is optional. If it is passed, a sub object named confirm, defining target and action for the callback.
        /// </summary>
        public JsString callbacks { get; set; }
    }

    /// <summary>
    /// The button view is one of the basic views of the UI library of The-M-Project.
    /// Though it is not rendered as the typical HTML-based button you might know if you are a web developer, its functionality is pretty much the same.
    /// A button view is a tappable / clickable area, that displays a text value and mostly will be used to trigger a certain action.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ButtonView", Export = false)]
    public class ButtonView
    {
        /// <summary>
        /// optional
        /// With this property a dynamic content can be bound to the button view.
        /// Everytime the bound property changes, the button view will automatically update its value and its representation.
        /// </summary>
        public object contentBinding { get; set; }

        /// <summary>
        /// optional
        /// With this property one or more css classes can be added to the button view.
        /// Note: By doing this, the default styling of the button view almost fully disappears. You will need to style the button view yourself.
        /// </summary>
        public JsString cssClass { get; set; }


        /// <summary>
        /// optional
        /// Determines whether this button is active or not.
        /// Note: This property is only used if the button is part of a button group (M.ButtonGroupView).
        /// </summary>
        public bool isActive { get; set; }

        /// <summary>
        /// optional
        /// Determines whether the button is only displayed as an icon, without a text value.
        /// </summary>
        public bool isIconOnly { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a hyperlink target for this button. It only works in combination with the hyperlinkType property.
        /// </summary>
        public JsString hyperlinkTarget { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a certain hyperlink type for this button. It only works in combination with the hyperlinkTarget property.
        /// </summary>
        public JsString hyperlinkType { get; set; }

        /// <summary>
        /// recommended
        /// Defines the value of the button. This value is displayed as the button's text.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// This method can be used to disable the button. This leads to a visual 'disabled' look and disabled the buttons tap/click events.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method can be used to enable a disabled button and make it usable again.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method can be used to set the button's value at runtime. It updates both the value property and the button's visual representation.
        /// </summary>
        /// <param name="value">The button's new value.</param>
        public void setValue(JsString value) { }

        /// <summary>
        /// This event is fired when a user clicks a button.
        /// </summary>
        public JsAction<MEventData> click { get; set; }

        /// <summary>
        /// This event is fired when a user taps a button. We recommend to use this event instead of click!
        /// </summary>
        public JsAction<MEventData> tap { get; set; }

    }

    /// <summary>
    /// A button group is an arrangement of several buttons combined within one control.
    /// They can be vertically or horizontally aligned and they can consist of multiple lines.
    /// By default a button group's button views are selectable. This means that everytime a user clicks / taps a button of a button group view, this button gets selected.
    /// A possible previous selection will be automatically removed before. Such a slection change always fires a change event.
    /// Additionally the included button views can have their own events (e.g. tap events), that are fired at the same time.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ButtonGroupView", Export = false)]
    public class ButtonGroupView
    {
        /// <summary>
        /// optional
        /// This property, if set, defines how many buttons are rendered per line.
        /// If there are more buttons defined that fitting into one line, the following buttons are rendered into a new line.
        /// Make sure, the number of your buttons is divisible by the number of buttons per line, since only full lines are displayed.
        /// So if you for example specify 5 buttons and 2 buttons per line, the fifth button won't be visible.
        /// </summary>
        public JsNumber buttonsPerLine { get; set; }

        /// <summary>
        /// optional
        /// With this property one or more css classes can be added to the button group view.
        /// The string passed with this property is assigned to the class property of the surrounding div container of the button group view.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// Default: M.HORIZONTAL
        /// Determines the direction of the button group. This can either be M.HORIZONTAL (see screenshot #1) or M.VERTICAL (see screenshot #2).
        /// </summary>
        public JsString direction { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// Determines whether to display the button group compact, i.e. without top/bottom margin.
        /// This property only is relevant in combination with multiple lines of buttons (c.p.: buttonsPerLine property).
        /// </summary>
        public bool isCompact { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// Determines whether to display the button group view 'inset' or at full width.
        /// </summary>
        public bool isInset { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property determines whether the buttons of this button group are selectable or not.
        /// </summary>
        public bool isSelectable { get; set; }

        /// <summary>
        /// This method returns the currently selected button of this button group. If no button is selected, null is returned.
        /// </summary>
        /// <returns></returns>
        public ButtonView getActiveButton() { return null; }

        /// <summary>
        /// This method activates one button within the button group.
        /// </summary>
        /// <param name="button">The button to be set active or its id.</param>
        public void setActiveButton(ButtonView button) { }
        /// <summary>
        /// This method activates one button within the button group.
        /// </summary>
        /// <param name="button">The button to be set active or its id.</param>
        public void setActiveButton(JsString button) { }

        /// <summary>
        /// This event is fired everytime the selection of the selection list did change.
        /// </summary>
        public JsAction<MEventData> change { get; set; }

    }

    /// <summary>
    /// The canvas view basically renders a simple canvas tag into the DOM.
    /// Additionally it offers some wrappers for canvas-based methods,
    /// but mostly you will just use this view for the first rendering of the canvas element and then work on the dom element itself.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.CanvasView", Export = false)]
    public class CanvasView
    {
        /// <summary>
        /// This method returns the canvas' context.
        /// </summary>
        /// <returns></returns>
        public object getCanvas() { return null; }

        /// <summary>
        /// This method returns the canvas' DOM representation.
        /// </summary>
        /// <param name="type">The context type to return.</param>
        /// <returns></returns>
        public object getContext(JsString type) { return null; }

        /// <summary>
        /// This method returns the canvas' height.
        /// </summary>
        /// <returns></returns>
        public JsNumber getHeight() { return null; }

        /// <summary>
        /// This method returns the canvas' width.
        /// </summary>
        /// <returns></returns>
        public JsNumber getWidth() { return null; }

        /// <summary>
        /// This method sets the canvas' height.
        /// </summary>
        /// <param name="height">The height to be applied to the canvas view.</param>
        public void setHeight(JsNumber height) { }

        /// <summary>
        /// This method sets the canvas' size.
        /// </summary>
        /// <param name="width">The width to be applied to the canvas view.</param>
        /// <param name="height">The height to be applied to the canvas view.</param>
        public void setSize(JsNumber width, JsNumber height) { }

        /// <summary>
        /// This method sets the canvas' width.
        /// </summary>
        /// <param name="width">The width to be applied to the canvas view.</param>
        public void setWidth(JsNumber width) { }


    }

    /// <summary>
    /// A Carousel View holds other views (M.CarouselItemView). Only one view is displayed at a time and you can navigate through these views by swiping the view's area.
    /// This gives you a sort of page browsing behaviour. This view can be used for many purposes, e.g. a picture gallery.
    /// CSS Styles:
    /// The styling of the carousel itself is written down in a CSS file named tmp.css located in modules/tmp_themes/ in the framework's directory.
    /// All relevant styling properties are written down here:
    /// tmp-carousel-wrapper: The wrapper of the carousel.
    /// tmp-carousel-scroller: The inner scroller component that includes the elements.
    /// ul.tmp-carousel-list li: for the several items in the carousel
    /// tmp-carousel-paginatorand tmp-carousel-paginator-horizontal (or vertical): The paginator
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.CarouselView", Export = false)]
    public class CarouselView
    {
        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether or not to show a paginator with the carousel.
        /// If set to YES, there will be dots visible, indicating the total number of items and highlighting the currently visible item.
        /// </summary>
        public bool showPaginator { get; set; }

        /// <summary>
        /// optional
        /// Default: M.HORIZONTAL
        /// This property determines whether the carousel is vertically or horizontally scrollable. Possible values are:
        /// M.HORIZONTAL: horizontal
        /// M.VERTICAL: vertical
        /// </summary>
        public JsString direction { get; set; }

        /// <summary>
        /// optional
        /// Default: M.CAROUSEL_SIZE_CONTENT
        /// This property can be used to specify on what bases the size of the carousel shall be calculated.
        /// By default the content of the items determine that size (M.CAROUSEL_SIZE_CONTENT).
        /// So the item with the longest / biggest content sets the size for all the other items and the carousel itself.
        /// If set to M.CAROUSEL_SIZE_SURROUNDING_ELEMENT, the surrounding element will determine the size of the carousel.
        /// If set to M.CAROUSEL_SIZE_NONE, there will be no special size calculation for the carousel. You will have to take care about this instead.
        /// </summary>
        public JsNumber sizeCalculator { get; set; }

        /// <summary>
        /// This method activates one specific item within the carousel. Simply pass a valid M.CarouselItemView object or the ID of the view and it gets shown.
        /// </summary>
        /// <param name="item">The ID or the object of a M.CarouselItemView.</param>
        public void setActiveItem(CarouselItemView item) { }
        /// <summary>
        /// This method activates one specific item within the carousel. Simply pass a valid M.CarouselItemView object or the ID of the view and it gets shown.
        /// </summary>
        /// <param name="item">The ID or the object of a M.CarouselItemView.</param>
        public void setActiveItem(JsString item) { }

        /// <summary>
        /// This method activates the next item in the row.
        /// </summary>
        public void next() { }

        /// <summary>
        /// This method activates the previous item in the row.
        /// </summary>
        public void prev() { }

    }

    /// <summary>
    /// A carousel item view is the one and only valid sub view of a carousel view. It basically serves as a container that allows you to put anything into such an element.
    /// Simply apply as much child views as you like and let this view (in combination with the carousel) take care of the rest.
    /// CSS Styles:
    /// The carousel item view receives the following class
    /// tmp-carousel-item
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.CarouselItemView", Export = false)]
    public class CarouselItemView
    {
        /// <summary>
        /// optional
        /// This property can be used to specify a tag, that is independent from the carousel item's content.
        /// This allows you to identify a carousel item e.g. within the callback of the carousel's change event.
        /// </summary>
        public JsString tag { get; set; }
    }

    /// <summary>
    /// The confirm dialog is a little more complex than the alert dialog.
    /// It also takes the two parameters of the alert dialog but additionaly has another mandatory parameter (callbacks) and two optional parameters. 
    /// You might ask yourself "Why do I need callbacks for a confirm dialog?". A confirm dialog marks a fork in your application flow.
    /// You want the user to make a decision. And for every decision the application continues in different directions.
    /// For this purpose, you pass callbacks that define where to go after the user made a decision.
    /// Note: It is also possible to pass a function as action instead of a string (this is possible throughout every callback passing).
    /// It is executed in the scope of the target.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ConfirmDialogView", Export = false)]
    public class ConfirmDialogView
    {
        /// <summary>
        /// recommended
        /// Default: "Confirm".
        /// Defines the title of the confirm dialog. The title is shown on the top of the dialog.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// optional
        /// Defines the value shown on the destructive button. If this property is not used, no destructive button is shown.
        /// </summary>
        public JsString message { get; set; }

        /// <summary>
        /// optional
        /// Default: "Confirm".
        /// Defines the value shown on the confirm button. If this value is not set, the default value is used.
        /// </summary>
        public JsString confirmButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Default: "Cancel".
        /// Defines the value shown on the cancel button. If this value is not set, the default value is used.
        /// </summary>
        public JsString cancelButtonValue { get; set; }

        /// <summary>
        /// mandatory
        /// The object defining the callbacks for confirm and cancel. Two sub objects have to be defined:
        /// confirm : the callback for the confirm button.
        /// cancel : the callback for the cancel button.
        /// </summary>
        public object callbacks { get; set; }
    }

    /// <summary>
    /// A container for other views. Only renders a code frame no representation.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ContainerView", Export = false)]
    public class ContainerView
    {
        /// <summary>
        /// optional
        /// A string naming the child views of the container. E.g.
        /// childViews: 'teaser main footer'
        /// Those childViews have to be defined inside the definition of the container, see the examples.
        /// </summary>
        public JsString childViews { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to set CSS classes for a container.
        /// </summary>
        public JsString cssClass { get; set; }
    }

    /// <summary>
    /// A dashboard view displays images and a corresponding text in a grid-like view and serves as the homescreen of an application.
    /// By tapping on of the icons, a user can access certain features of an app.
    /// By default, there are three icons in a row and three rows per page possible. But you can easily adjust this to your custom needs.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.DashboardView", Export = false)]
    public class DashboardView
    {

        /// <summary>
        /// optional
        /// This property can be used to statically assign dashboard items to the dashboard. For a more dynamic way use content binding.
        /// </summary>
        public JsString childViews { get; set; }

        /// <summary>
        /// optional
        /// With this property a dynamic content (dashboard items) can be bound to the dashboard view.
        /// Everytime the bound property changes, the dashboard view will automatically update its items and re-render itself.
        /// </summary>
        public JsArray contentBinding { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to set CSS classes for the dashboard.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property can be used to specify whether or not the dashboard can be re-arranged by a user.
        /// </summary>
        public bool isEditable { get; set; }

        /// <summary>
        /// optional
        /// Default: 3
        /// This property can be used to customize the number of items a dashboard shows per line. By default this is set to three.
        /// </summary>
        public JsNumber itemsPerLine { get; set; }

        /// <summary>
        /// optional
        /// Default: dashboard
        /// This property defines the dashboard's name. This is used internally to identify the dashboard inside the DOM.
        /// Note: If you are using more than one dashboard inside your application, make sure you provide different names.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// This method removes all of the dashboard view's items by removing all of its content in the DOM. This method is based on jQuery's empty().
        /// </summary>
        public void removeAllItems() { }

        /// <summary>
        /// This event is fired when a user clicks/selects a dashboard item.
        /// </summary>
        public JsAction<DashboardViewEventData> click { get; set; }

        /// <summary>
        /// This event is fired when a user taps/selects a dashboard item. We recommend to use this event instead of click!
        /// </summary>
        public JsAction<DashboardViewEventData> tap { get; set; }

    }

    public class DashboardViewEventData
    {

        public JsString domID { get; set; }
    }

    /// <summary>
    /// A dashboard itm view contains an icon and a label and can be used as the only kind of child views for a dashboard view.
    /// While a dashboard view specifies the container of a dashboard, the dashboard item view is used to specify the actual visible items on that dashboard.
    /// They can be attached to a dashboard as either static child views or dynamically via content binding.
    /// CSS Styles:
    /// There are a few CSS classes that define the layout and the look and feel of a list item view:
    /// tmp-dashboard-item: This class is responsible for the arrangement of the items on the dashboard.
    /// tmp-dashboard-item-label: This class defines the layout and styling a list item's label.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.DashboardItemView", Export = false)]
    public class DashboardItemView
    {
        /// <summary>
        /// recommended
        /// The path/url to the dashboard item's icon.
        /// </summary>
        public JsString icon { get; set; }

        /// <summary>
        /// optional
        /// The label for the dashboard item. If no label is specified, the value will be displayed instead.
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// mandatory
        /// This property specifies the dashboard item's value. If there is no label set, this value is used as a visual text.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// This event is fired when a user clicks/selects a dashboard item.
        /// </summary>
        public JsAction<DashboardViewEventData> click { get; set; }

        /// <summary>
        /// This event is fired when a user taps/selects a dashboard item. We recommend to use this event instead of click!
        /// </summary>
        public JsAction<DashboardViewEventData> tap { get; set; }

    }

    /// <summary>
    /// A date picker is a special view, that can be called out of a controller.
    /// It is shown as a date picker popup, based on the mobiscroll library.
    /// You can either connect a date picker with an existing view and automatically pass the selected date to the source's value property,
    /// or you can simply use the date picker to select a date, return it to the controller (respectively the callback) and handle the date by yourself.
    /// Note: If you plan on using HTML5's date input type, you should stick with M.TextFieldView instead.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.DatePickerView", Export = false)]
    public class DatePickerView
    {

        /// <summary>
        /// optional
        /// Default: 
        /// This property can be used to specify several callbacks for the date picker view. There are three types of callbacks available:
        /// before:
        /// This callback gets called, right before the date picker is shown. It passes along two parameters:
        /// value: The initial date of the date picker, formatted as a string
        /// date: The initial date of the date picker as d8 object
        /// confirm:
        /// This callback gets called, when a selected date was confirmed. It passes along two two parameters:
        /// value: The initial date of the date picker, formatted as a string
        /// date: The initial date of the date picker as d8 object
        /// cancel:
        /// This callback gets called, when the cancel button is hit. It doesn't pass any parameters.
        /// Setting up one of those callbacks works the same as with other controls of The-M-Project.
        /// You simply have to specify an object containing a target function, e.g.:
        /// callbacks: {
        ///     confirm: {
        ///         target: this,
        ///         action: 'dateSelected'
        ///     },
        ///     cancel: {
        ///         action: function() {
        ///             // do something
        ///         }
        ///     }
        /// }
        /// </summary>
        public DatePickerCallbacksOptions callbacks { get; set; }

        /// <summary>
        /// optional
        /// Default: Cancel
        /// This property can be used to specify the label of the date picker's cancel button. By default it shows 'Cancel'.
        /// </summary>
        public JsString cancelButtonValue { get; set; }

        /// <summary>
        /// optional
        /// Default: Ok
        /// This property can be used to specify the label of the date picker's confirm button. By default it shows 'Ok'.
        /// </summary>
        public JsString confirmButtonValue { get; set; }

        /// <summary>
        /// recommended
        /// Default: current + 20
        /// This property can be used to specify the last year of the 'year' scroller. By default, this will be set to 20 years after the current year.
        /// </summary>
        public JsNumber endYear { get; set; }

        /// <summary>
        /// optional
        /// Default: M dd, yy
        /// This property can be used to customize the date format of the date picker. This is important if you use the date picker on a valid source since the date picker will then automatically push the selected date/datetime to the 'value' property of the source - based on this format. 
        /// The possible keys:
        /// m: month (without leading zero)
        /// mm: month (two-digit)
        /// M: month name (short)
        /// MM: month name (long)
        /// d: day (without leading zero)
        /// d: day (two digit)
        /// D: day name (short)
        /// DD: day name (long)
        /// y: year (two digit)
        /// yy: year (four digit)
        /// </summary>
        public JsString dateFormat { get; set; }

        /// <summary>
        /// optional
        /// Default: MM yy
        /// This property can be used to customize the date format of the date picker if it is associated with a text input with the type 'month'.
        /// It works the same as the dateFormat property.
        /// </summary>
        public JsString dateFormatMonthOnly { get; set; }

        /// <summary>
        /// optional
        /// Default: Mddyy
        /// This property determines the order and formating of the date scrollers. The following keys are possible:
        /// m : month (without leading zero
        /// mm: month (two-digit
        /// M : month name (short
        /// MM: month name (long
        /// d : day (without leading zero
        /// d : day (two digit
        /// y : year (two digit
        /// yy: year (four digit
        /// </summary>
        public JsString dateOrder { get; set; }

        /// <summary>
        /// optional
        /// Default: Day
        /// This property specified the label shown above of the 'day' scroller.
        /// Note: This label is only shown if the 'showLabels' property is set to YES.
        /// </summary>
        public JsString dayLabel { get; set; }

        /// <summary>
        /// optional
        /// Default: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
        /// This property specifies a list of short day names.
        /// </summary>
        public JsArray dayNames { get; set; }

        /// <summary>
        /// optional
        /// Default: Hours
        /// This property specified the label shown above of the 'hours' scroller.
        /// Note: This label is only shown if the 'showLabels' property is set to YES.
        /// </summary>
        public JsString hoursLabel { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// This property can be used to specify the initial date for the date picker.
        /// If you use the date picker without a source, this date is always picked as the initial date.
        /// If nothing is specified, the current date will be displayed.
        /// If you use the date picker with a valid source, the initial date is picked as long as there is no valid date available by the source.
        /// Once a date was selected and assigned to the source, this is taken as initial date the next time the date picker is opened.
        /// </summary>
        public JsString initialDate { get; set; }
        /// <summary>
        /// optional
        /// Default: 
        /// This property can be used to specify the initial date for the date picker.
        /// If you use the date picker without a source, this date is always picked as the initial date.
        /// If nothing is specified, the current date will be displayed.
        /// If you use the date picker with a valid source, the initial date is picked as long as there is no valid date available by the source.
        /// Once a date was selected and assigned to the source, this is taken as initial date the next time the date picker is opened.
        /// </summary>
        [JsProperty(Name = "initialDate")]
        public object initialDateObject { get; set; }

        /// <summary>
        /// optional
        /// Default: Minutes
        /// This property specified the label shown above of the 'minutes' scroller.
        /// Note: This label is only shown if the 'showLabels' property is set to YES.
        /// </summary>
        public JsString minutesLabel { get; set; }

        /// <summary>
        /// optional
        /// Default: Month
        /// This property specified the label shown above of the 'month' scroller.
        /// Note: This label is only shown if the 'showLabels' property is set to YES.
        /// </summary>
        public JsString monthLabel { get; set; }

        /// <summary>
        /// optional
        /// Default: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']
        /// This property specifies a list of full month names.
        /// </summary>
        public JsArray monthNames { get; set; }

        /// <summary>
        /// optional
        /// Default: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
        /// This property specifies a list of short month names.
        /// </summary>
        public JsArray monthNamesShort { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property can be used to activate the seconds wheel on a time/date-time picker.
        /// </summary>
        public bool seconds { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// You can use this property to enable or disable the AM/PM scroller. If set to NO, the date picker will use the 24h format.
        /// </summary>
        public bool showAmPm { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether to show scrollers for picking a date or not.
        /// Note: If both this and the 'showTimePicker' property are set to NO, no date picker will be shown.
        /// </summary>
        public bool showDatePicker { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether or not to show labels above of the scrollers.
        /// If set to YES, the labels specified with the '...Label' properties are displayed above of the corresponding scroller.
        /// </summary>
        public bool showLabels { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether to show scrollers for picking a time or not.
        /// Note: If both this and the 'showDatePicker' property are set to NO, no date picker will be shown.
        /// </summary>
        public bool showTimePicker { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// This property is used to link the date picker to a source. You can either pass the DOM id of the corresponding source or the javascript object itself.
        /// Linking the date picker directly to a source results in automatic value updates of this source.
        /// Note: Valid sources need to provide a setValue() method.
        /// If you do not pass a source, the date picker isn't linked to any view. It simply returns the selected value/date to given callbacks.
        /// So you can call the date picker out of a controller and handle the selected date all by yourself.
        /// </summary>
        public JsString source { get; set; }
        /// <summary>
        /// optional
        /// Default: 
        /// This property is used to link the date picker to a source. You can either pass the DOM id of the corresponding source or the javascript object itself.
        /// Linking the date picker directly to a source results in automatic value updates of this source.
        /// Note: Valid sources need to provide a setValue() method.
        /// If you do not pass a source, the date picker isn't linked to any view. It simply returns the selected value/date to given callbacks.
        /// So you can call the date picker out of a controller and handle the selected date all by yourself.
        /// </summary>
        [JsProperty(Name = "source")]
        public object sourceObject { get; set; }

        /// <summary>
        /// recommended
        /// Default: current - 20
        /// This property can be used to specify the first year of the 'year' scroller. By default, this will be set to 20 years before the current year.
        /// </summary>
        public JsNumber startYear { get; set; }

        /// <summary>
        /// optional
        /// Default: 1
        /// This property can be used to specify the steps between hours in the time / date-time picker.
        /// </summary>
        public JsNumber stepHour { get; set; }

        /// <summary>
        /// optional
        /// Default: 1
        /// This property can be used to specify the steps between minutes in the time / date-time picker.
        /// </summary>
        public JsNumber stepMinute { get; set; }

        /// <summary>
        /// optional
        /// Default: 1
        /// This property can be used to specify the steps between seconds in the time / date-time picker.
        /// </summary>
        public JsNumber stepSecond { get; set; }

        /// <summary>
        /// optional
        /// Default: h:ii A
        /// This property can be used to customize the time format of the date picker.
        /// This is important if you use the date picker on a valid source since the date picker will then automatically
        /// push the selected time/datetime to the 'value' property of the source - based on this format. 
        /// The possible keys:
        /// h: hours (without leading zero, 12h format
        /// hh: hours (two-digit, 12h format
        /// H: hours (without leading zero, 24h format
        /// HH: hours (two-digit, 24h format
        /// i: minutes (without leading zero
        /// ii: minutes (two-digit
        /// A: AM/PM
        /// </summary>
        public JsString timeFormat { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to determine whether to use the data source's value as initial date or not. If there is no source specified, this property is irrelevant.
        /// Note: If there is a source specified and this property is set to NO, the 'initialDate' property will be used anyway if there is no date value available for the source!
        /// </summary>
        public bool useSourceDateAsInitialDate { get; set; }

        /// <summary>
        /// optional
        /// Default: Year
        /// This property specified the label shown above of the 'year' scroller.
        /// Note: This label is only shown if the 'showLabels' property is set to YES.
        /// </summary>
        public JsString yearLabel { get; set; }

        /// <summary>
        /// This method is the only important method of a date picker view for 'the outside world'.
        /// From within an application, simply call this method and pass along an object, containing all the properties you want to set, different from default.
        /// </summary>
        /// <param name="obj">An object containing all the configuration parameters for the date picker, based on its available properties.</param>
        public void show(object obj) { }
        //TODO: "An object containing all the configuration parameters"-> WICH configuration parameters?!?!

        /// <summary>
        /// This callback gets called, right before the date picker is shown.
        /// </summary>
        public JsAction<DatePickerViewEventData> before { get; set; }

        /// <summary>
        /// This callback gets called, when the cancel button is hit. It doesn't pass any parameters.
        /// </summary>
        public JsAction cancel { get; set; }

        /// <summary>
        /// This callback gets called, when a selected date was confirmed.
        /// </summary>
        public JsAction<DatePickerViewEventData> confirm { get; set; }

    }

    public class DatePickerViewEventData
    {
        /// <summary>
        /// The initial date of the date picker, formatted as a string.
        /// </summary>
        public JsString value  { get; set; }

        /// <summary>
        /// The initial date of the date picker as d8 object.
        /// </summary>
        public object date { get; set; }
    }

    /// <summary>
    /// Setting up one of those callbacks works the same as with other controls of The-M-Project. You simply have to specify an object containing a target function, 
    /// </summary>
    [JsType(JsMode.Json)]
    public class DatePickerCallbacksOptions
    {
        /// <summary>
        /// This callback gets called, right before the date picker is shown. It passes along two parameters:
        /// value: The initial date of the date picker, formatted as a string
        /// date: The initial date of the date picker as d8 object
        /// </summary>
        public JsAction<JsString, object> before { get; set; }

        /// <summary>
        /// This callback gets called, when a selected date was confirmed. It passes along two two parameters:
        /// value: The initial date of the date picker, formatted as a string
        /// date: The initial date of the date picker as d8 object
        /// </summary>
        public JsAction<JsString, object> confirm { get; set; }

        /// <summary>
        /// This callback gets called, when the cancel button is hit. It doesn't pass any parameters.
        /// </summary>
        public JsAction cancel { get; set; }

    }

    /// <summary>
    /// The dialog view is a wrapper view for alert, confirm and action sheet dialogs. Within an application this view is used to initialize the concrete dialogs.
    /// Since those views are well documented, we decided not to write it all down in here again.
    /// So please check the concrete dialog view for further information and some code samples:
    /// M.ActionSheetDialog
    /// M.AlertDialogView
    /// M.ConfirmDialogView
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.DialogView", Export = false)]
    public class DialogView : ActionSheetDialog //TODO: sldo inhair from: AlertDialogView : ConfirmDialogView
    {
    }

    /// <summary>
    /// M.FormViews is the prototype of a form view, a container-like view for grouping input views, e.g. M.TextFieldView.
    /// It covers a lot of the jobs concerning the validation of input views.
    /// There is no visible representation of a M.FormView, it is only used to ease the validation process and its access from a controller.
    /// A M.FormView can be seen similar to the &lt;form> tag in HTML. It is a container for other views that together build a formular.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.FormView", Export = false)]
    public class FormView
    {
        /// <summary>
        /// recommended
        /// Default: YES
        /// A flag that determines whether to automatically show an alert dialog view out of the showError method if the validation failed or not.
        /// So if set to YES, all error messages are shown in an alert dialog view once the showError method is called.
        /// </summary>
        public bool showAlertDialogOnError { get; set; }

        /// <summary>
        /// optional
        /// Default: Validation Error(s)
        /// The title of the alert view that comes up automatically if the validation fails, depending one the showAlertOnError property.
        /// </summary>
        public JsString alertTitle { get; set; }

        /// <summary>
        /// This method triggers the validate() on all child views, respectively on their validators.
        /// This method is used to determine whether all views have valid values according to their defined validators.
        /// </summary>
        /// <returns>The result of the validation process: valid or not.</returns>
        public bool validate() { return false; }

        /// <summary>
        /// This method is a wrapper of M.View's getValues() method.
        /// This method creates and returns an associative array of all child views and their values. 
        /// The key of an array item is the name of the view specified in the view definition. The value of an array item is the value of the corresponding view.
        /// </summary>
        /// <returns>An object as an associative array containing all values of the views inside the form. Collects also values throughout further nesting in child views.
        /// The values are saved as key/value-pairs. The key is the name of the respective view.</returns>
        public object getFormValues() { return null; }

        /// <summary>
        /// This method is a wrapper of M.View's clearValues() method. 
        /// It clears the value of the respective view and also walks through nested child views.
        /// </summary>
        public void clearForm() { }
    }

    /// <summary>
    /// A layout component for arranging views in a grid.
    /// When you are using the grid view with one of the default layouts, the following CSS classes (applied on div elements) are relevant for you:
    /// ui-grid-a: This defines the outer box of the two column grid.
    /// ui-grid-b: This defines the outer box of the three column grid.
    /// ui-grid-c: This defines the outer box of the four column grid.
    /// ui-block-a: This defines the first column of the grid.
    /// ui-block-b: This defines the second column of the grid.
    /// ui-block-c: This defines the third column of the grid.
    /// ui-block-d: This defines the fourth column of the grid.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.GridView", Export = false)]
    public class GridView
    {
        /// <summary>
        /// mandatory
        /// Default : null
        /// The layout for the grid view. There are two predefined layouts available: 
        /// - M.TWO_COLUMNS
        ///    a two column layout, width: 50% / 50% 
        /// - M.THREE_COLUMNS
        ///    a three column layout, width: 33% / 33% / 33% 
        /// - M.FOUR_COLUMNS
        ///    a four column layout, width: 25% / 25% / 25% 
        /// 
        /// To specify your own layout, you will have to implement some css classes and then define your layout like: 
        /// 
        /// cssClass: 'cssClassForWholeGrid', 
        /// columns: { 
        ///     0: 'cssClassForColumn1', 
        ///     1: 'cssClassForColumn2', 
        ///     2: 'cssClassForColumn3', 
        ///     3: 'cssClassForColumn4', 
        ///     //........ 
        /// }
        /// </summary>
        public object layout { get; set; }
    }

    /// <summary>
    /// A view presenting an image in your app.
    /// The M.ImageView is a very basic view, that simply renders an image by using HTML's img element.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ImageView", Export = false)]
    public class ImageView
    {

        /// <summary>
        /// optional
        /// This property can be used to set CSS classes for an image.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// mandatory (if computedValue is not used)
        /// This property defines the value of the image, which means the source that is displayed.
        /// You can either provide a valid path or a data URI.
        /// </summary>
        public JsString value { get; set; }

        /// <summary>
        /// The event is fired when the image could not be loaded.
        /// This can happen if e.g. the source is not valid or there is no network connection available.
        /// </summary>
        public JsAction<ImageViewEventData> error { get; set; }

        /// <summary>
        /// The event is fired when the image was successfully loaded.
        /// </summary>
        public JsAction<ImageViewEventData> load { get; set; }

        /// <summary>
        /// The event is fired when a user taps on the image.
        /// </summary>
        public JsAction<ImageViewEventData> tap { get; set; }

    }

    public class ImageViewEventData
    {
        public JsString viewId { get; set; }

        public object @event { get; set; }
    }

    /// <summary>
    /// The basic view for placing text in your UI. (read-only).
    /// The M.LabelView is basically a view to display a text. E.g. the text that is often displayed in a M.ToolBarView is a LabelView inside this bar.
    /// The value of the label can be statical or dynamical.
    /// It's also a common task to localize the value of a label. It can also used as a link inside the application and to external URLs.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.LabelView", Export = false)]
    public class LabelView
    {

        /// <summary>
        /// optional
        /// This property can be used to set CSS classes for a label.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a hyperlink target for this label.
        /// It only works in combination with the hyperlinkType property.
        /// </summary>
        public JsString hyperlinkTarget { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a certain hyperlink type for this label.
        /// It only works in combination with the hyperlinkTarget property. Three types are available:
        /// M.HYPERLINK_EMAIL, for linking to an e-mail adress.
        /// M.HYPERLINK_WEBSITE, for linking to a URL.
        /// M.HYPERLINK_PHONE, for linking to a phone number.
        /// </summary>
        public JsString hyperlinkType { get; set; }

        /// <summary>
        /// optional
        /// Default:NO
        /// Can be used to let a label float with another following label. Both labels need to have it set to YES.
        /// </summary>
        public bool isInline { get; set; }

        /// <summary>
        /// optional
        /// Default:YES
        /// Determines whether a new line '\n' within the label's value should be transformed into a line break '' before it is rendered.
        /// </summary>
        public bool newLineToBreak { get; set; }

        /// <summary>
        /// optional
        /// Default:YES
        /// Determines whether a tabulator '\t' within the label's value should be transformed into four spaces ' ' before it is rendered.
        /// </summary>
        public bool tabToSpaces { get; set; }

        /// <summary>
        /// mandatory (if computedValue is not used)
        /// This property defines the value of the label, which means the text that is displayed.
        /// </summary>
        public bool value { get; set; }

        /// <summary>
        /// Sets the label's value and initiates its re-rendering.
        /// </summary>
        /// <param name="value">The value to be applied on the label view.</param>
        public void setValue(JsString value) { }

        /// <summary>
        /// The event is fired when a user taps on the label.
        /// </summary>
        public JsAction<ImageViewEventData> tap { get; set; }
    }

    /// <summary>
    /// The basic UI component to list data. Uses ListItems to define the look.
    /// M.ListView is the prototype of any list view. It is used to display static or dynamic content as vertically aligned list items (M.ListItemView).
    /// A list view provides some easy to use helper method, e.g. an out-of-the-box delete view for items.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ListView", Export = false)]
    public class ListView
    {

        /// <summary>
        /// mandatory
        /// Default: 
        /// This property is used to bind list items (resp. "content") to the list view. This has to be an array of objects that match the applied list item template.
        /// Now everytime the bound property changes, the list view will automatically update its items and re-render itself.
        /// </summary>
        public JsArray contentBinding { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// This property can be used to set CSS classes for the List.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// If the list view is a counted list, this property can be used to customize the style of the list item's counter.
        /// </summary>
        public JsString cssClassForCounter { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// If the list view is a divided list, this property can be used to customize the style of the list's dividers.
        /// </summary>
        public JsString cssClassForDivider { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to add margin at the bottom of the list or not.
        /// This is useful whenever the list is not the last element within a page's content area to make sure the list does not overlap following elements.
        /// </summary>
        public bool doNotOverlapAtBottom { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to add margin at the top of the list or not.
        /// This is useful whenever the list is not the first element within a page's content area to make sure the list does not overlap preceding elements.
        /// </summary>
        public bool doNotOverlapAtTop { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether or not to display a search bar at the top of the list view.
        /// </summary>
        public bool hasSearchBar { get; set; }

        /// <summary>
        /// recommended
        /// Default: 
        /// An optional String defining the id property that is passed in view as record id
        /// </summary>
        public JsString idName { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to display the the number of child items for each list item view.
        /// </summary>
        public bool isCountedList { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to display the list as a divided list or not.
        /// </summary>
        public bool isDividedList { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to display the list view 'inset' or at full width.
        /// </summary>
        public bool isInset { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Defines if the ListView is rendered with prefixed numbering for each item.
        /// </summary>
        public bool isNumberedList { get; set; }

        /// <summary>
        /// mandatory
        /// Default: 
        /// This property contains the list view's template view, the blueprint for every child view.
        /// </summary>
        public ListItemView listItemTemplateView { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// An object containing target and action to be triggered if the search string changes.
        /// </summary>
        public object onSearchStringDidChange { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// Determines whether to remove all item if the list is updated or not.
        /// </summary>
        public bool removeItemsOnUpdate { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// The list view's search bar.
        /// </summary>
        public object searchBar { get; set; }

        /// <summary>
        /// optional
        /// Default: 'Search...'
        /// If the hasSearchBar property is set to YES and the usesDefaultSearchBehaviour is set to YES, this property can be used to specify the inital text for the search bar.
        /// This text will be shown as long as nothing else is entered into the search bar text field.
        /// </summary>
        public JsString searchBarInitialText { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// If the hasSearchBar property is set to YES, this property determines whether to use the built-in simple search filters or not.
        /// If set to YES, the list is simply filtered on the fly according to the entered search string. Only list items matching the entered search string will be visible.
        /// If a custom search behaviour is needed, this property must be set to NO.
        /// </summary>
        public bool usesDefaultSearchBehaviour { get; set; }

        /// <summary>
        /// This method adds a new list item to the list view by simply appending its html representation to the list view inside the DOM.
        /// This method is based on jQuery's append().
        /// </summary>
        /// <param name="item">The html representation of a list item to be added.</param>
        public void addItem(JsString item) { }

        /// <summary>
        /// This method removes all of the list view's items by removing all of its content in the DOM. This method is based on jQuery's empty().
        /// </summary>
        public void removeAllItems() { }

        /// <summary>
        /// This method resets the list by applying the default css style to its currently activated list item.
        /// </summary>
        public void resetActiveListItem() { }

        /// <summary>
        /// This method activates a list item by applying the default 'isActive' css style to its DOM representation.
        /// </summary>
        /// <param name="listItemId">The id of the list item to be set active.</param>
        public void setActiveListItem(JsString listItemId) { }

        /// <summary>
        /// This method activates the edit mode and forces the list view to re-render itself and to display a remove button for every list view item.
        /// </summary>
        /// <param name="options">options The options for the remove button.</param>
        public void toggleRemove(object options) { }
        //TODO: no class for the options proprtyes?

        /// <summary>
        /// This event is fired when a user clicks/selects a list item view.
        /// </summary>
        public JsAction<ListViewEventData> click { get; set; }

        /// <summary>
        /// This event is fired when a user taps/selects a list item view. We recommend to use this event instead of click!
        /// </summary>
        public JsAction<ListViewEventData> tap { get; set; }

    }

    public class ListViewEventData
    {

        public JsString domID  { get; set; }

        public JsString itemID  { get; set; }
    }

    /// <summary>
    /// The template for every list entry as a container for different other views.
    /// A list item view serves as a template for each list item within a list view.
    /// Therefore it can only be used as a child view (resp. a listItemTemplateView) of a list view (M.ListView).
    /// Within your application you will use define a list item view for each list, that determines the layout of any list item within this list.
    /// So the component serves as a container and can be filled with all basic views, e.g. a label, a button or an image. Learn more about this in the examples.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ListItemView", Export = false)]
    public class ListItemView
    {
        /// <summary>
        /// optional
        /// Default : M.ButtonView.design({ icon: 'delete',value: '' })
        /// This property contains the list item's delete button that is automatically shown if the list view's built-in toggleRemove() functionality is used.
        /// </summary>
        public ButtonView deleteButton { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property determines whether a list item has one single action that is triggered once there is a click anywhere inside the list item
        /// or if there are specific actions defined for single ui elements within one list item.
        /// </summary>
        public bool hasSingleAction { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether a selection list item can be selected or not.
        /// Note, that this only affects styling stuff. If set to NO, you still can apply e.g. tap events.
        /// </summary>
        public bool isSelectable { get; set; }

        /// <summary>
        /// optional
        /// Default : M.ButtonView.design({ value: 'delete', cssClass: 'a tmp-actionsheet-destructive-button tmp-swipe-button' })
        /// This property can be used to specify a button that appears on a swipe left or swipe righ gesture (as known from the iphone).
        /// Simply specify a tap event for that button and provide a custom method to handle the event. This can e.g. be used as a delete button. 
        /// By default the button will look like a delete button (in red) and display 'delete'.
        /// To change this, simply pass a value to set the label and make use of the cssClass property.
        /// To get a standard button as you now it from the other parts of the framework, set the cssClass property's value to:
        /// 'a' -> black
        /// 'b' -> blue
        /// 'c' -> light grey
        /// 'd' -> white
        /// 'e' -> yellow
        /// Check the jQM docs for further information and visual samples of these themes: http://jquerymobile.com/test/docs/buttons/buttons-themes.html
        /// </summary>
        public ButtonView swipeButton { get; set; }


        /// <summary>
        /// This event is fired when a user clicks/selects a list item view.
        /// </summary>
        public JsAction<ListViewEventData> click { get; set; }

        /// <summary>
        /// This event is fired when a user taps/selects a list item view. We recommend to use this event instead of click!
        /// </summary>
        public JsAction<ListViewEventData> tap { get; set; }

    }

    /// <summary>
    /// Indicate a user that something is happening/gets loaded.
    /// The loader view indicates a user that something is taking so much time that you need to inform him about it.
    /// Typically a loader view would be shown everytime a request is done, a complex operation is performed or maybe even if the application switches to another page.
    /// Besides showing and hiding a loader view, you can define the message that is displayed within the loader view.
    /// Note: By showing the loader view, an internal reference counter will be increased, by hiding the loader view, this counter will be decreased.
    /// We do this since it can happen, that your application fires several request at a time, but receives the responses asynchronously.
    /// So without this internal stack, the first response would hide the loader view visually event though other operations are still in progress.
    /// CSS Styles:
    /// The styling of the loader view is done by jQuery Mobile. There are three css classes responsible for the layout:
    /// ui-loader: This defines the size and position of the loader view.
    /// ui-body-a: This defines the color and styling of the loader view.
    /// ui-corner-all: This adds round corners to the loader view.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.LoaderView", Export = false)]
    public class LoaderView
    {

        /// <summary>
        /// optional
        /// Default : "loading"
        /// This property can be used to specify the default title of a loader.
        /// </summary>
        public JsString defaultTitle { get; set; }

        /// <summary>
        /// This method hides the loader. If the force parameter is not set to YES, this method only decreases the internal reference counter.
        /// If the counter gets down to 0, the loader view visually disappears.
        /// </summary>
        /// <param name="force">Determines whether to force the hide of the loader.</param>
        public void hide(bool force) { }

        /// <summary>
        /// This method shows the default loader. You can specify the displayed label with the title parameter.
        /// By calling this method, the internal reference counter get increased by one.
        /// </summary>
        /// <param name="title">The loader view's current title.</param>
        public void show(JsString title) { }
    }

    /// <summary>
    /// Display a map, based of the Google Maps Javascript API V3.
    /// M.MapView defines a set of methods for displaying a map, setting markers on that map and displaying the user's current location.
    /// It is based on the Google Maps Javascript API V3 and basically wraps all important features available in this great API.
    /// Note: Since the map data is loaded dynamically using the Google Maps Javascript API V3 and is not part of the application itself,
    /// M.MapView only works if there is a network connection available.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.MapView", Export = false)]
    public class MapView
    {
        /// <summary>
        /// recommended
        /// This property, if set, contains the map view's callback in sub a object named 'error',
        /// which will be called if no connection is available and the map service (google maps api) can not be loaded and a 'success' object,
        /// defining a callback once the api was loaded. E.g. you can specify something like:
        /// callbacks: {
        ///     success: {
        ///         target: MyApp.MyController,
        ///         action: 'mapsAPILoaded'
        ///     },
        ///     error: {
        ///         target: MyApp.MyController,
        ///         action: 'noConnectionAvailable'
        ///     }
        /// }
        /// 
        /// </summary>
        public object callbacks { get; set; }

        /// <summary>
        /// recommended
        /// This property can be used to assign a certain css class to the map view's container.
        /// This allows you to specify styling stuff like the width and height of your map view. So we recommend to always assign a css class ... just in case.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// This property specifies the initial location for this map view, as an M.Location object.
        /// Its latitude and longitude properties are directly mapped to the center property of a google map view.
        /// By default this is set to the headquarter of developer team of The-M-Project in Stuttgart, Germany.
        /// </summary>
        public Location initialLocation { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property specifies whether the map is draggable or not.
        /// If set to NO, a user won't be able to move the map, respectively the visible sector.
        /// For further information see the google maps API specification: http://code.google.com/intl/en-US/apis/maps/documentation/javascript/reference.html#MapOptions
        /// </summary>
        public bool isDraggable { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property determines whether to display the map view 'inset' or at full width.
        /// </summary>
        public bool isInset { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This flag can be used to specify whether or not to load the google places library.
        /// By default this property is set to YES. If you do not need the library, you should set this to NO in order to save some bandwidth
        /// </summary>
        public bool loadPlacesLibrary { get; set; }

        /// <summary>
        /// optional
        /// Default: M.MAP_ROADMAP	
        /// This property specifies the map type for this map view. It is directly mapped to the 'mapTypeId' property of a google map view. Possible values for this property are:
        /// M.MAP_ROADMAP --> This map type displays a normal street map.
        /// M.MAP_HYBRID --> This map type displays a transparent layer of major streets on satellite images.
        /// M.MAP_SATELLITE --> This map type displays satellite images.
        /// M.MAP_TERRAIN --> This map type displays maps with physical features such as terrain and vegetation.
        /// For further information see the google maps API specification: http://code.google.com/intl/en-US/apis/maps/documentation/javascript/reference.html#MapOptions
        /// </summary>
        public JsString mapType { get; set; }

        /// <summary>
        /// optional
        /// Default: M.MAP_MARKER_ANIMATION_NONE
        /// This property can be used to specify the animation type for this map view's markers. The following three values are possible:
        /// M.MAP_MARKER_ANIMATION_NONE --> no animation
        /// M.MAP_MARKER_ANIMATION_DROP --> the marker drops onto the map
        /// M.MAP_MARKER_ANIMATION_BOUNCE --> the marker constantly bounces
        /// </summary>
        public JsString markerAnimationType { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property specifies whether or not to remove all existing markers on a map update.
        /// A map update can either be an automatic update due to content binding or a implicit call of the map view's updateMap() method.
        /// </summary>
        public bool removeMarkersOnUpdate { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property determines whether or not to show a marker at the map view's initial location.
        /// This location can be specified by the initialLocation property of this map view.
        /// </summary>
        public bool setMarkerAtInitialLocation { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property specifies whether or not to display the map type controls inside of this map view.
        /// For further information see the google maps API specification: http://code.google.com/intl/en-US/apis/maps/documentation/javascript/reference.html#MapOptions
        /// </summary>
        public bool showMapTypeControl { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property specifies whether or not to display the navigation controls inside of this map view.
        /// For further information see the google maps API specification: http://code.google.com/intl/en-US/apis/maps/documentation/javascript/reference.html#MapOptions
        /// </summary>
        public bool showNavigationControl { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property specifies whether or not to display the street view controls inside of this map view.
        /// For further information see the google maps API specification: http://code.google.com/intl/en-US/apis/maps/documentation/javascript/reference.html#MapOptions
        /// </summary>
        public bool showStreetViewControl { get; set; }

        /// <summary>
        /// optional
        /// Default: 15
        /// This property specifies the zoom level for this map view. 
        /// It is directly mapped to the zoom property of a google map view.
        /// For further information see the google maps API specification: http://code.google.com/intl/de-DE/apis/maps/documentation/javascript/reference.html#MapOptions
        /// </summary>
        public JsNumber zoomLevel { get; set; }

        /// <summary>
        /// This method can be used to add a marker to the map view. 
        /// Simply pass a valid M.MapMarkerView object and a map marker is created automatically, displayed on the map and added to this map view's markers property.
        /// </summary>
        /// <param name="marker">The marker to be added.</param>
        public void addMarker(MapMarkerView marker) { }

        /// <summary>
        /// This method is used to initialize a map view, typically out of a controller. With its options parameter you can set or update almost every parameter of a map view. This allows you to define a map view within your view, but then update its parameters later when you want this view to display a map.
        /// The options parameter must be passed as a simple object, containing all of the M.MapView's properties you want to be updated. Such an options object could look like the following:
        /// {
        ///     zoomLevel: 12,
        ///     mapType: M.MAP_HYBRID,
        ///     initialLocation: location
        /// }
        /// </summary>
        /// <param name="options">The options for the map view.</param>
        public void initMap(object options) { }
        //TODO: maybe needs a new options class?

        /// <summary>
        /// This method removes all markers from this map view. It both cleans up the markers array and deletes the marker's visual representation from the map view.
        /// </summary>
        public void removeAllMarkers() { }

        /// <summary>
        /// This method can be used to remove a certain marker from the map view.
        /// In order to do this, you need to pass the M.MapMarkerView object that you want to be removed from the map view.
        /// </summary>
        /// <param name="marker">The marker to be removed.</param>
        public void removeMarker(MapMarkerView marker) { }

        /// <summary>
        /// This method is used to update a map view, that has already been initialized.
        /// You would typically call this method out of a controller. Besides some internal stuff, this method pretty much does the same as initMap().
        /// So simply pass an object containing valid options for the already existing map view.
        /// </summary>
        /// <param name="options">The options for the map view.</param>
        public void updateMap(object options) { }
        //TODO: maybe needs a new options class?

        /// <summary>
        /// This event is fired whenever a map marker is clicked and there is no special click event defined for this marker.
        /// </summary>
        public JsAction<MEventData> click { get; set; }

        /// <summary>
        /// This event is fired whenever a map marker is tapped and there is no special tap event defined for this marker.
        /// </summary>
        public JsAction<MEventData> tap { get; set; }
    }

    /// <summary>
    /// Its latitude and longitude properties are directly mapped to the center property of a google map view.
    /// By default this is set to the headquarter of developer team of The-M-Project in Stuttgart, Germany.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.Location", Export = false)]
    public class Location
    {
        public JsNumber latitude { get; set; }
        public JsNumber longitude { get; set; }
    }
    //TODO: maybe JSON mode?

    /// <summary>
    /// Set markers on a map to indicate important places.
    /// A map marker view defines a set of methods for adding, removing and managing the markers of a M.MapView.
    /// Such a marker can be used to show the user of an application a certain location on a map view or the location of the user himself.
    /// The map marker view within The-M-Project is based on google maps markers.
    /// Note: Map markers can't be used stand-alone. You'll always need a map to place them on.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.MapMarkerView", Export = false)]
    public class MapMarkerView
    {

        /// <summary>
        /// optional
        /// Default: 
        /// This property can be used to store additional information about a marker.
        /// Since this property is an object, you can store pretty much anything in this property.
        /// This can be useful especially if you are using the click event for map markers.
        /// So you can store any information with a marker and retrieve this information on the click event.
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// This property can be used to specify a custom marker icon. Simply pass a valid path to an image and it will be shown instead of google's default marker.
        /// </summary>
        public JsString icon { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property specifies whether the marker is draggable or not.
        /// If set to NO, a user won't be able to move the marker. For further information see the google maps API specification: http://code.google.com/intl/en-US/apis/maps/documentation/javascript/reference.html#MarkerOptions
        /// </summary>
        public bool isDraggable { get; set; }

        /// <summary>
        /// recommended
        /// Default: location: M.Location.extend({ latitude: 48.813338, longitude: 9.178463 })
        /// This property specifies the location for this map marker view, as an M.Location object.
        /// Its latitude and longitude properties are directly mapped to the position property of a google maps marker.
        /// </summary>
        public Location location { get; set; }

        /// <summary>
        /// optional
        /// Default: M.MAP_MARKER_ANIMATION_NONE
        /// This property can be used to specify the animation type for this map marker view. If this property is set, the markerAnimationType property of the parent map view is ignored. The following three values are possible:
        /// M.MAP_MARKER_ANIMATION_NONE --> no animation
        /// M.MAP_MARKER_ANIMATION_DROP --> the marker drops onto the map
        /// M.MAP_MARKER_ANIMATION_BOUNCE --> the marker constantly bounces
        /// </summary>
        public JsString markerAnimationType { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// This property specifies the message of a map marker view respectively for its annotation.
        /// </summary>
        public JsString message { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property can be used to specify whether or not to show the annotation, if title and/or message are defined, automatically on click event.
        /// </summary>
        public bool showAnnotationOnClick { get; set; }

        /// <summary>
        /// optional
        /// Default: 
        /// This property specifies the title of a map marker view. It can be used in an annotation.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// This method initializes a map marker view. It connects a map marker directly with the parent map view and returns the created M.MapMarkerView object.
        /// Note: By calling this method, the map marker won't be displayed on the map.
        /// It only gets initialized and can no be displayed by using the map view's addMarker() or content binding.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public MapMarkerView init(object options) { return null; }
        //TODO: options class?

        /// <summary>
        /// This method can be used to remove a map marker from a map view.
        /// </summary>
        public void remove() { }

        /// <summary>
        /// This method can be used to show a map markers annotation.
        /// </summary>
        public void showAnnotation() { }

        /// <summary>
        /// This event is fired whenever a map marker is clicked and there is no special click event defined for this marker.
        /// </summary>
        public JsAction<MEventData> click { get; set; }

        /// <summary>
        /// This event is fired whenever a map marker is tapped and there is no special tap event defined for this marker.
        /// </summary>
        public JsAction<MEventData> tap { get; set; }
    }

    /// <summary>
    /// The highest-leveled view of an application, the root of any screen.
    /// The M.PageView is used in every application built with The-M-Project.
    /// It is the container view for every view on one screen. This means, every page defines a screen in your application.
    /// No methods of the PageView are available for public use. Beside the childViews property, there are also no properties to be used by the application developer.
    /// But there are several important events that are fired in the context of the page.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.PageView", Export = false)]
    public class PageView
    {
        /// <summary>
        /// optional (not necessary when using content binding)
        /// A string naming the child views of the page. E.g.
        /// childViews: 'header content footer'
        /// Those childViews have to be defined inside the definition of the page, see the examples.
        /// </summary>
        public JsString childViews { get; set; }

        /// <summary>
        /// This event is triggered on the page being shown, before its transition begins.
        /// </summary>
        public JsAction<PageViewEventData> PageViewEventData { get; set; }

        /// <summary>
        /// This event is triggered on the page being shown, after its transition completes.
        /// </summary>
        public JsAction<PageViewEventData> pageshow { get; set; }

        /// <summary>
        /// This event is triggered on the page being hidden, before its transition begins.
        /// </summary>
        public JsAction<PageViewEventData> pagebeforehide { get; set; }

        /// <summary>
        /// This event is triggered on the page being hidden, after its transition completes.
        /// </summary>
        public JsAction<PageViewEventData> pagehide { get; set; }

        //TODO: orientationchange EVENT

    }

    public class PageViewEventData
    {
        /// <summary>
        /// A flag indicating whether this page is loaded for the very first time.
        /// </summary>
        public bool isFirstLoad  { get; set; }
    }

    /// <summary>
    /// modules/ui/scroll.js
    /// The M.ScrollView is a container for the scrollable content on a single page.
    /// It should be used as a wrapper for any content that isn't part of a header toolbar or footer toolbar/tabbar.
    /// Note: It is very important to use this view for your scrollable content since
    /// this view adds some important meta information to this area so jQuery Mobile recognizes it as the page's content area.
    /// CSS Styles:
    /// There actually only is one relevant CSS class when using a scroll view:
    /// ui-content: This CSS class defines some basic styling (especially the padding) of an application's content area.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.PageView", Export = false)]
    public class ScrollView
    {
        /// <summary>
        /// recommended
        /// A string naming the child views of the scroll view. E.g.
        /// childViews: 'label button textfield'
        /// Those childViews have to be defined inside the definition of the scroll view, as you can see within the samples.
        /// </summary>
        public JsString childViews { get; set; }

        /// <summary>
        /// This property can be used to set CSS classes for the scroll view.
        /// </summary>
        public JsString cssClass { get; set; }

    }

    /// <summary>
    /// A special text field representing a search bar.
    /// M.SearchBarView defines a search bar that can be used inside of a list view or independently as a plain input field with a search styling.
    /// Basically a search bar view is the same as a default text field view except it is styled with a goggles icon at the left and there
    /// appears a 'delete' button at the right once you entered some text to reset the text field.
    /// There are a few CSS classes responsible for the look and feel of the search bar view:
    /// CSS Styles:
    /// ui-shadow-inset: This defines an inner shadow for the text field view.
    /// ui-input-search: This class defines the basic size and dimension of the search bar view.
    /// ui-icon-searchfield: This class is responsible for positioning the goggles/clear icon inside the search bar view.
    /// ui-corner-all: This adds round corners to the search bar view.
    /// ui-body-c: This class defines some styling stuff like border, text color, text-shadow or the background.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.SearchBarView", Export = false)]
    public class SearchBarView
    {
        /// <summary>
        /// optional
        /// The initial text shown inside the search bar field describing the input or making a suggestion for input e.g. "Please enter your Name."
        /// </summary>
        public JsString initialText { get; set; }

        /// <summary>
        /// This method can be used to disable the search bar view. This leads to a visual 'disabled' look and disabled the text fields events.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method clears the search bar's value, both in the DOM and within the corresponding JS object.
        /// </summary>
        public void clearValue() { }

        /// <summary>
        /// This method can be used to enable a disabled search bar and make it usable again.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method sets the search bar's value and initiates its re-rendering.
        /// </summary>
        /// <param name="value">The value to be applied to the search bar view.</param>
        public void setValue(JsString value) { }

        /// <summary>
        /// This event is fired whenever the search bar view loses the focus.
        /// </summary>
        public JsAction<MEventData> blur { get; set; }

        /// <summary>
        /// This event is fired when a user hits the enter button while the search bar view has got the focus.
        /// </summary>
        public JsAction<MEventData> enter { get; set; }

        /// <summary>
        /// This event is fired whenever the search bar view gets the focus.
        /// </summary>
        public JsAction<MEventData> focus { get; set; }

        /// <summary>
        /// This event is fired when a user hits any button while the search bar view has got the focus.
        /// Note: By accessing the keyCode property of the passed event object, you can get the information which key was pressed.
        /// </summary>
        public JsAction<MEventData> keyup { get; set; }
    }

    /// <summary>
    /// Offer several options in a selectable way.
    /// The M.SelectionListView is a very often used UI element. It is used, to give users the opportunity to choose between one or more values.
    /// It combines the HTML elements radio box, checkbox and select box in a single view. When rendering the choices of the select box, the native look and feel is used. 
    /// The type of box that is shown is defined by a property of the view.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.SelectionListView", Export = false)]
    public class SelectionListView
    {

        /// <summary>
        /// optional (not necessary when using content binding)
        /// A string naming the child views of this element. E.g.
        /// childViews: 'item1 item2 item3'
        /// Those childViews have to be defined inside the definition of this view, see the examples.
        /// </summary>
        public JsString childViews { get; set; }

        /// <summary>
        /// optional
        /// In a SelectionListView the content binding defines the content of a SelectionView, means: its selectable entries.
        /// If childViews are also given, these are used until the first time contentBinding is 'activated'.
        /// </summary>
        public object contentBinding { get; set; }

        /// <summary>
        /// optional
        /// The label property defines a text that is shown above or next to the selection list as a 'title' for the selection list. e.g. "Name:".
        /// If no label is specified, no label will be displayed.
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// Determines whether to remove all item if the list is updated (via content binding) or not.
        /// </summary>
        public bool removeItemsOnUpdate { get; set; }

        /// <summary>
        /// optional
        /// Default: M.SINGLE_SELECTION
        /// Defines which type of SelectionView shall be rendered. There's tree possible types:
        /// Single Selection: M.SINGLE_SELECTION. This selection mode will render a selection list with several list items of which only one can be selected.
        /// Whenever a new item is selected, the previously selected item automatically gets de-selected.
        /// This selection mode's behaviour is equivalent to the plain HTML's radio button.
        /// Multiple Selection: M.MULTIPLE_SELECTION. This selection mode will render a selection list with several list items of which all be selected.
        /// So the selection of a new item doesn't lead to automatic de-selected of previously selected items.
        /// This selection mode's behaviour is equivalent to the plain HTML's checkboxes.
        /// Single Selection Dialog: M.SINGLE_SELECTION_DIALOG. This selection mode will render a selection list equivalent to the plain HTML's select menu.
        /// Only the currently selected item will be visible, and by clicking on this item, the selection list will be displayed in a dialog respectively a popup view.
        /// By selecting on of the items, this popup will automatically close and the selected value will be displayed.
        /// Single Selection Dialog: M.MULTIPLE_SELECTION_DIALOG. This selection mode will render a selection list equivalent to the plain HTML's select menu, but with the possibility to select multiple options.
        /// In contrast to the single selection dialog mode, it also is possible to select no option at all.
        /// As with the multiple selecton mode, the selection of a new item doesn't lead to automatic de-selected of previously selected items.
        /// Note: This mode currently only works on mobile devices!!
        /// If no value is passed, the default value is used.
        /// </summary>
        public JsString selectionMode { get; set; }

        /// <summary>
        /// This method disables the selection list by setting the isEnabled property to YES and initializing a corresponding re-painting.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method enables the selection list by setting the isEnabled property to NO and initializing a corresponding re-painting.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method returns the selected item's value(s) either as a String (single selection) or as an Array (multiple selection).
        /// If YES/true is passed as parameter, object(s) (a M.SelectionListItemView (or an array of them) is returned.
        /// </summary>
        /// <param name="returnObject">Determines whether to return the selected item(s) as object or not.</param>
        /// <returns>String, Object or Array</returns>
        public object getSelection(bool returnObject) { return null; }

        /// <summary>
        /// This method can be used to reset the selection of a selection list regardless of the selection mode.
        /// If the selection list is filled using content binding, this method will simply re-apply this bound content to its body.
        /// Otherwise, if no content binding is used, the selection list automatically stores the initial state specified by its child views in an internal property.
        /// On calling this method, this stored state will be applied to the selection list's content.
        /// </summary>
        public void resetSelection() { }

        /// <summary>
        /// This method can be used to select items programmatically. The given parameter can either be a String (single selection) or an Array (multiple selection).
        /// </summary>
        /// <param name="selection">(String or Array): The item/entry (its value) that should be selected.</param>
        public void setSelection(JsString selection) { }
        /// <summary>
        /// This method can be used to select items programmatically. The given parameter can either be a String (single selection) or an Array (multiple selection).
        /// </summary>
        /// <param name="selection">(String or Array): The item/entry (its value) that should be selected.</param>
        public void setSelection(JsArray selection) { }

        /// <summary>
        /// This event is fired when a user changes the selection.
        /// Note: No change event is fired, when the user sets the selection programmatically via setSelection.
        /// </summary>
        public JsAction<SelectionListViewEventData> change { get; set; }

    }

    public class SelectionListViewEventData
    {
        /// <summary>
        /// The value of the selected item or an array of all selected values.
        /// </summary>
        public JsString value { get; set; }
        /// <summary>
        /// The value of the selected item or an array of all selected values.
        /// </summary>
        [JsProperty(Name = "M.SelectionListItemView")]
        public JsArray valueArray { get; set; }
        
        /// <summary>
        /// The selected item (single selection) or an array of items (multiple selection).
        /// </summary>
        [JsProperty(Name="M.SelectionListItemView")]
        public object SelectionListItemView  { get; set; }
        //TODO: must check
        /// <summary>
        /// The selected item (single selection) or an array of items (multiple selection).
        /// </summary>
        [JsProperty(Name = "M.SelectionListItemView")]
        public JsArray SelectionListItemViewArray { get; set; }
        //TODO: must check
    }

    /// <summary>
    /// Add selectable items to a selection list.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.SelectionListItemView", Export = false)]
    public class SelectionListItemView
    {
        /// <summary>
        /// optional
        /// This property states whether a selection list item is selected or not.
        /// </summary>
        public bool isSelected { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify a label for a selection list item.
        /// If set, the label will be displayed instead of the value, so you can use the item's value as an internal value. 
        /// E.g. if you use a selection list to select a color, you could set an item's value to '#FF0000' but its label to 'Red'.
        /// If there is no label specified, the value is displayed instead.
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// mandatory
        /// This property can be used internally to identify an item. If no label is defined for the item, the value is also used as label.
        /// </summary>
        public JsString value { get; set; }
    }

    /// <summary>
    /// A touch-optimized slider view.
    /// The slider view renders a touch-optimized slider that can be used to set a number within a specified range.
    /// CSS Styles:
    /// The styling of the slider view is done by jQuery Mobile but refined by some TMP stuff. The following classes are relevant:
    /// tmp-slider-container: This defines the container for the slider view.
    /// tmp-slider-is-slider-only: If the isSliderOnly property is set to YES, this class is added to the slider.
    /// ui-slider: This defines the jQuery Mobiel default styling for slider view.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.SliderView", Export = false)]
    public class SliderView
    {

        /// <summary>
        /// optional
        /// Default: NO
        /// This property determines whether or not to display the corresponding input of the slider.
        /// If set to NO, a textfield will be visible, showing the slider's current value. If set to YES, only the slider will be visible.
        /// </summary>
        public bool isSliderOnly { get; set; }

        /// <summary>
        /// recommended
        /// Default: 100
        /// This property specifies the max value of the slider. The user can not set a higher value than specified with this property.
        /// </summary>
        public JsNumber max { get; set; }

        /// <summary>
        /// recommended
        /// Default: 0
        /// This property specifies the min value of the slider. The user can not set a lower value than specified with this property. with this property.
        /// </summary>
        public JsNumber min { get; set; }

        /// <summary>
        /// optional
        /// Default: 1
        /// This property specifies the step value of the slider.
        /// </summary>
        public JsNumber step { get; set; }

        /// <summary>
        /// recommended
        /// Default: 0
        /// This property contains the slider's value. Set this to adjust the initial value of the slider.
        /// Once the user moves the slider, this property gets automatically updated.
        /// </summary>
        public JsNumber value { get; set; }

        /// <summary>
        /// This method disables the slider so it can no longer be moved by a user.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method enables the slider so it can be moved by a user.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method resets the slider to its initial value.
        /// </summary>
        public void resetSlider() { }

    }

    /// <summary>
    /// A convenient navigation bar as known from e.g. the iPhone.
    /// A tab bar view is a special variant of a toolbar at the top or bottom of a page, that consists of up to five horizontally aligned tabs.
    /// A M.TabBarView can be used as the top navigation level for an application since it is always visible an indicates the currently active part of the application by highlighting the corresponding tab.
    /// CSS Styles:
    /// The styling of the tab bar is done by jQuery Mobile. It is pretty much the same as with the M.ToolbarView. Depending on the anchorLocation property, some of the following css classes are responsible for the layout:
    /// ui-header / ui-footer: This defines some basic layout and positioning setup for the tab bar.
    /// ui-bar-a: This class defines the color and visual style of the tab bar.
    /// ui-header-fixed / ui-footer-fixed: This indicates that the tab bar is fixed.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.TabBarView", Export = false)]
    public class TabBarView
    {
        /// <summary>
        /// recommended
        /// Defines the position of the TabBar. Possible values are:
        /// M.BOTTOM => is a footer tab bar
        /// M.TOP => is a header tab bar
        /// </summary>
        public JsString anchorLocation { get; set; }

        /// <summary>
        /// optional
        /// Default: tab_bar
        /// This property defines the tab bar's name. This is used internally to identify the tab bar inside the DOM.
        /// If your application only uses one tab bar (the typical way), there is no need to specify a custom name.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// This method visually activates / highlights a tab bar item.
        /// Of course the previously activated tab will automatically be deactivated before.
        /// </summary>
        /// <param name="tab">The tab to set active.</param>
        public void setActiveTab(TabBarItemView tab) { }
    }

    /// <summary>
    /// A child view of a tab bar.
    /// A tab bar item view is the one an only possible type of view that can be applied to a tab bar view as a child.
    /// It represents the actual tab, whilst the tab bar is something like a container for several tab bar items.
    /// CSS Styles:
    /// The styling of the tab bar is mainly done by jQuery Mobile. For styling a tab bar item you way, you might want to take a look at the following css class:
    /// ui-icon: This defines the styling and layout of the tab bar item's icon. If you are using custom icons, you likely will have to make some adjustments there.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.TabBarItemView", Export = false)]
    public class TabBarItemView
    {
        /// <summary>
        /// optional
        /// This property can be used to specify an icon for a tab bar item. Regarding the markup, this will result in a data-icon attribute of the tab bar item.
        /// If you want to use some of the default jQuery Mobile icons, it'll all work just fine out of the box.
        /// If you want to use your own icons, there will be some more work to do. Check the examples for further information.
        /// </summary>
        public JsString icon { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property can be used to specify whether a tab bar item is active on startup or not.
        /// Note: If you are setting this property to YES for more than one tab item, the first will win. All the others will automatically be set to not active instead.
        /// Note 2: If you are setting this property to NO for all tab items, the application's entryPage property will decide which on to activate on startup.
        /// </summary>
        public bool isActive { get; set; }

        /// <summary>
        /// mandatory
        /// This property specifies the corresponding page for this tab bar item so the framework knows which page to show once a user taps on a tab bar item.
        /// </summary>
        public JsString page { get; set; }

        /// <summary>
        /// recommended
        /// Default: NO
        /// This property specifies the tab bar item's visible value.
        /// </summary>
        public JsString value { get; set; }
        //TODO: Default= NO, but it is not a boolean it is a string...?

    }

    /// <summary>
    /// This view renders a HTML table element based on a bound content.
    /// The M.TableView simply renders a HTML table element with an optional table header and based on a bound content. Whenever the content changes, the table re-paints itself.
    /// CSS Styles:
    /// The following CSS classes are relevant when using a table view:
    /// tmp-table-container: This is applied the outer box of the table view.
    /// tmp-table: This is applied to the table element.
    /// tmp-table-th: This is applied to the th element.
    /// tmp-table-td: This is applied to the td element.
    /// tmp-table-tr-a: This is applied to every odd td element.
    /// tmp-table-tr-b: This is applied to every even td element.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.TableView", Export = false)]
    public class TableView
    {
        /// <summary>
        /// optional
        /// This property can be used to set CSS classes for the table.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// This property can be used to specify the table's header and cols, independent from dynamically loaded table content.
        /// It can be provided with the table's definition within a page component. The table's content, in contrast, can only be applied via content binding.
        /// Note: If the removeHeaderRowOnUpdate property is set to YES, the header will be removed whenever a content binding is applied.
        /// So if the header shall be statically specified by the view component, do not set that property to YES!
        /// This property should look something like the following:
        /// {
        ///     data: ['col1', 'col2', 'col3'],
        ///     cols: ['20%', '10%', '70%']
        /// }
        /// Note: the cols property of this object is optional. You can also let CSS take care of the columns arrangement or simply let the browser do all the work automatically.
        /// </summary>
        public JsString header { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property determines whether to remove all content rows if the table is updated or not.
        /// </summary>
        public bool removeContentRowsOnUpdate { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// This property determines whether to remove the header rows if the table is updated or not.
        /// </summary>
        public bool removeHeaderRowOnUpdate { get; set; }

        /// <summary>
        /// This method adds a new row to the table view by simply appending its html representation to the table view inside the DOM. This method is based on jQuery's append().
        /// </summary>
        /// <param name="row">The html representation of a table row to be added.</param>
        /// <param name="addToTableHeader">Determines whether or not to add the row to the table's header.</param>
        public void addRow(JsString row, bool addToTableHeader) { }

        /// <summary>
        /// This method removes all of the table view's rows by removing all of its content in the DOM. This method is based on jQuery's empty().
        /// </summary>
        public void removeAllRows() { }

        /// <summary>
        /// This method removes all content rows of the table view by removing the corresponding html in the DOM. This method is based on jQuery's remove().
        /// </summary>
        public void removeContentRows() { }
    }

    /// <summary>
    /// Offer a simple text field for some user input.
    /// M.TextFieldView is the prototype of any text field input view.
    /// It can be rendered as both a single line text field and a multiple line text field (a textbox). If it is styled as a multiple line text field,
    /// is has a built-in autogrow mechanism so the textfield is getting larger depending on the number of lines of text a user enters.
    /// CSS Styles:
    /// There are a few CSS classes responsible for the look and feel of the text field view:
    /// ui-shadow-inset: This defines an inner shadow for the text field view.
    /// ui-input-text : This class defines the size, padding, line-height, font-size for the text field view.
    /// ui-corner-all: This adds round corners to the text field view.
    /// ui-body-c: This class defines some styling stuff like border, text color, text-shadow or the background.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.TextFieldView", Export = false)]
    public class TextFieldView
    {

        /// <summary>
        /// optional
        /// This property can be used to assign a special css class to the text field while the initial text is visible (c.p. initialText).
        /// </summary>
        public JsString cssClassOnInit { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// TThis property specifies whether the text field view is a simple, single-line text field or a text box with multiple lines.
        /// </summary>
        public bool hasMultipleLines { get; set; }

        /// <summary>
        /// optional
        /// Default: ''
        /// By setting this property, one can specify a initial text for a text field view.
        /// So whenever the text field view's value is empty (e.g. on startup or when resetting a form view), the string specified with this property will be shown.
        /// Note: To give this initial text a special styling, use the cssClassOnInit property.
        /// </summary>
        public JsString initialText { get; set; }

        /// <summary>
        /// optional
        /// Default: M.INPUT_TEXT
        /// This property can be used to specify the input type of a text field view. Possible values are:
        /// M.INPUT_TEXT --> text input (default)
        /// M.INPUT_PASSWORD --> password
        /// M.INPUT_NUMBER --> number
        /// M.INPUT_TELEPHONE --> tel
        /// M.INPUT_URL --> url
        /// M.INPUT_EMAIL --> email
        /// M.INPUT_TIME --> time
        /// M.INPUT_DATE --> date
        /// M.INPUT_MONTH --> month
        /// M.INPUT_WEEK --> week
        /// M.INPUT_DATETIME --> datetime
        /// M.INPUT_DATETIME_LOCAL --> datetime-local
        /// Note: These special input types are specified with HTML5 and not yet supported by all the browsers out there.
        /// So it could happen, that a plain text input field will be rendered instead of e.g. a email input.
        /// </summary>
        public JsString inputType { get; set; }

        /// <summary>
        /// optional
        /// The label proeprty defines a text that is shown above or next to the textfield as a 'title' for the textfield. e.g.
        /// "Name:". If no label is specified, no label will be displayed.
        /// </summary>
        public JsString label { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property can be used to specify whether to use the native implementation of one of the HTML5 input types if it is available.
        /// If set to YES, e.g. iOS5 will render its own date/time picker controls to the corresponding input type.
        /// If set to NO, the native implementation will be disabled.
        /// </summary>
        public bool useNativeImplementationIfAvailable { get; set; }

        /// <summary>
        /// This method can be used to disable the text field view. This leads to a visual 'disabled' look and disabled the text fields events.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method clears the text field's value, both in the DOM and within the corresponding JS object.
        /// </summary>
        public void clearValue() { }

        /// <summary>
        /// This method can be used to enable a disabled text field and make it usable again.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method sets the text field's value and initiates its re-rendering.
        /// </summary>
        /// <param name="value">The value to be applied to the text field view.</param>
        public void setValue(JsString value) { }


        /// <summary>
        /// This event is fired whenever the text field view loses the focus.
        /// </summary>
        public JsAction<MEventData> blur { get; set; }

        /// <summary>
        /// This event is fired when a user hits the enter button while the text field view has got the focus.
        /// </summary>
        public JsAction<MEventData> enter { get; set; }

        /// <summary>
        /// This event is fired whenever the text field view gets the focus.
        /// </summary>
        public JsAction<MEventData> focus { get; set; }

        /// <summary>
        /// This event is fired when a user hits any button while the text field view has got the focus.
        /// Note: By accessing the keyCode property of the passed event object, you can get the information which key was pressed.
        /// </summary>
        public JsAction<MEventData> keyup { get; set; }

    }

    /// <summary>
    /// An easy way to toggle between two views
    /// M.ToggleView defines the prototype of any toggle view.
    /// A toggle view accepts exactly two child views and provides an easy mechanism to toggle between these two views.
    /// An easy example would be to define two different button views that can be toggled,
    /// a more complex scenario would be to define two content views (M.ScrollView) with own child views and toggle between them.
    /// CSS Styles:
    /// The hidden view is disabled via inline style "display:none;".
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ToggleView", Export = false)]
    public class ToggleView
    {
        /// <summary>
        /// Default: M.ToggleView
        /// The type of this object.
        /// </summary>
        public JsString type { get; set; }

        /// <summary>
        /// Default: YES
        /// States whether the toggle view currently displays its first child view or its second child view.
        /// </summary>
        public bool isInFirstState { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to toggle the view on click. This might be useful if the child views are e.g. buttons.
        /// </summary>
        public bool toggleOnClick { get; set; }

        /// <summary>
        /// Contains a reference to the currently displayed view.
        /// </summary>
        public View currentView { get; set; }

        /// <summary>
        /// This method toggles the child views by first emptying the toggle view's content and then rendering the next child view by calling renderUpdateChildViews().
        /// </summary>
        public void toggleView() { }

        /// <summary>
        /// This method can be used to set on of the toggle view's child views as the active one. Simply pass the view, its id or its name.
        /// If a view or id is passed, that does not match on of the toggle view's child views, nothing will be done.
        /// </summary>
        /// <param name="view">The corresponding view.</param>
        public void setView(object view) { }
        /// <summary>
        /// This method can be used to set on of the toggle view's child views as the active one. Simply pass the view, its id or its name.
        /// If a view or id is passed, that does not match on of the toggle view's child views, nothing will be done.
        /// </summary>
        /// <param name="view">The corresponding view.</param>
        public void setView(JsString view) { }

    }

    /// <summary>
    /// A toggle switch view. You can think of it as an boolean switcher.
    /// A binary "flip" switch is a common UI element on mobile devices that is used for binary on/off or true/false data input.
    /// You can either drag the flip handle like a slider or tap one side of the switch.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ToggleSwitchView", Export = false)]
    public class ToggleSwitchView
    {
        /// <summary>
        /// optional
        /// Default: NO
        /// jQuery mobile: "All form controls accept a data-mini="true" attribute that renders a smaller version of the standard-sized form elements.
        /// In the case of grouped buttons, the data-mini="true" attribute can be added to the containing controlgroup.
        /// Compare mini and normal form elements side-by-side."
        /// </summary>
        public bool isMini { get; set; }

        /// <summary>
        /// optional
        /// With this property one or more css classes can be added to the togglesplit view.
        /// </summary>
        public JsString cssClass { get; set; }

        /// <summary>
        /// optional
        /// Default: true
        /// The text displayed on the togglesplit view when it is on.
        /// Think of it as an boolean switch so the on value is set default to true It is set through the render function.
        /// If there is no label defined the label gets set by the value.
        /// </summary>
        public JsString onLabel { get; set; }

        /// <summary>
        /// optional
        /// Default: false
        /// The text displayed on the togglesplit view when it is off.
        /// Think of it as an boolean switch so the off value is set default to false It is set through the render function.
        /// If there is no label defined the label gets set by the value.
        /// </summary>
        public JsString offLabel { get; set; }

        /// <summary>
        /// recommended
        /// Default: YES
        /// The value of the view when it is set to on. Think of it as an boolean switch so the on value is set default to true
        /// </summary>
        public bool onValue { get; set; }
        /// <summary>
        /// recommended
        /// Default: YES
        /// The value of the view when it is set to on. Think of it as an boolean switch so the on value is set default to true
        /// </summary>
        [JsProperty(Name = "onValue")]
        public JsString onValueString { get; set; }

        /// <summary>
        /// recommended
        /// Default: NO
        /// The value of the view when it is set to off. Think of it as an boolean switch so the off value is set default to false
        /// </summary>
        public bool offValue { get; set; }
        /// <summary>
        /// recommended
        /// Default: NO
        /// The value of the view when it is set to off. Think of it as an boolean switch so the off value is set default to false
        /// </summary>
        [JsProperty(Name = "onValue")]
        public JsString offValueString { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Optionally wrap the switch markup in a container with the data-role="fieldcontain" attribute to help visually group it in a longer form.
        /// </summary>
        public bool fieldcontain { get; set; }

        /// <summary>
        /// This method can be used to disable the togglesplitview. This leads to a visual 'disabled' look and disabled the togglesplitview tap/click/swipe events.
        /// </summary>
        public void disable() { }

        /// <summary>
        /// This method can be used to enable a disabled togglesplitview and make it usable again.
        /// </summary>
        public void enable() { }

        /// <summary>
        /// This method can be used to set the togglesplitview's value at runtime. You can either pass the label or value of the option. And toggle the View.
        /// </summary>
        /// <param name="value">The togglesplitview's new value.</param>
        public void setValue(object value) { }

        /// <summary>
        /// Returns the value of the current selection.
        /// </summary>
        /// <returns>the value of the togglesplitview</returns>
        public object getValue() { return null; }

        /// <summary>
        /// This method can be used to set the togglesplitview's value at runtime to the onLabel/onValue. And toggle the View.
        /// </summary>
        public void on() { }

        /// <summary>
        /// This method can be used to set the togglesplitview's value at runtime to the onLabel/onValue. And toggle the View.
        /// </summary>
        public void off() { }

        /// <summary>
        /// This event is fired when the toggleswitch's value changed through a tap, click or swipe.
        /// </summary>
        public JsAction<MEventData> change { get; set; }

    }

    /// <summary>
    /// A view for showing a toolbar at the top or bottom of an application.
    /// The toolbar view is a view to show a bar at the top or bottom of your application.
    /// In its basic variant, it only shows a centered label, which can be used to e.g. display the current page's name.
    /// But it also is possible to create more complex toolbars with buttons, button groups or images positioned at the left, center or right of the toolbar.
    /// The toolbar view can contain up to three child views. Each child view must have a distinct, valid anchorLocation value.
    /// The valid anchorLocations for children of a ToolbarView are M.LEFT, M.CENTER and M.RIGHT.
    /// CSS Styles:
    /// The styling of the toolbar is done by jQuery Mobile. Depending on the anchorLocation property, some of the following css classes are responsible for the layout:
    /// ui-header / ui-footer: This defines some basic layout and positioning setup for the toolbar.
    /// ui-bar-a: This class defines the color and visual style of the toolbar.
    /// ui-header-fixed / ui-footer-fixed: This indicates that the toolbar is fixed.
    /// </summary>
    [JsType(JsMode.Prototype, Name = "M.ToolbarView", Export = false)]
    public class ToolbarView
    {
        /// <summary>
        /// optional
        /// Default: M.TOP
        /// Defines the position of the TabBar. Possible values are:
        /// M.BOTTOM => is a footer bar
        /// M.TOP => is a header bar
        /// </summary>
        public JsString anchorLocation { get; set; }

        /// <summary>
        /// optional
        /// Default: YES
        /// This property determines whether to fix the toolbar to the top / bottom of a page. By default this is set to YES.
        /// </summary>
        public bool isFixed { get; set; }

        /// <summary>
        /// optional
        /// Default: NO
        /// Determines whether to display an auto-generated back-button on the left side of the toolbar view or not.
        /// </summary>
        public bool showBackButton { get; set; }
    }

    public class Page
    {
        //TODO: i have created this class cuse M.Page is the return type of getCurrentPage and getPage methodes, but i don't see ant doc for this class http://panacodalabs.github.com/The-M-Docs/#components_&_utilities/m_viewmanager

    }

    public class View
    {
        //TODO: i have created this class cuse M.View is the type of currentView propertye, but i don't see ant doc for this class http://panacodalabs.github.com/The-M-Docs/#views/m_toggleview

    }

    public class MEventData
    {
        public JsString id  { get; set; }
        public object @event { get; set; }
    }

}
