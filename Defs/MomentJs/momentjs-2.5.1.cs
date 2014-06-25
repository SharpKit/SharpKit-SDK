using SharpKit.JavaScript;


namespace Moment
{
    // Moment.js
    // An incomplete wrapper library for SharpKit - by Daniel Allemann
    [JsType(JsMode.Prototype, Export = false, Name = "moment")]
    public class Moment
    {

        // constructor
        [JsMethod(OmitNewOperator = true)]
        public Moment() { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(MomentOptions options) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsDate date) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsString date) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsString date, JsString format) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsString date, JsString format, bool strict) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsString date, JsString format, JsString language, bool strict) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsString date, JsString format, JsString language) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsString date, JsString format, bool strict, JsString language) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(JsArray<int> data) { }
        [JsMethod(OmitNewOperator = true)]
        public Moment(Moment momentToClone) { }
        //[JsMethod(OmitNewOperator = true, ArgumentsSuffix = ".local()")]
        //public Moment(Utc momentToClone) { }


        [JsMethod(Name = "utc")]
        public static Moment Utc() { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(MomentOptions options) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsDate date) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsString date) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsString date, JsString format) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsString date, JsString format, bool strict) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsString date, JsString format, JsString language, bool strict) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsString date, JsString format, JsString language) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsString date, JsString format, bool strict, JsString language) { return null; }
        [JsMethod(Name = "utc")]
        public static Moment Utc(JsArray<int> data) { return null; }

        [JsMethod(Name = "utc")]
        public Moment ToUtc() { return null; }
        [JsMethod(Name = "local")]
        public Moment ToLocal() { return null; }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        /// <summary>
        ///Clone the moment
        /// </summary>
        [JsMethod(Name = "clone")]
        public Moment Clone() { return default(Moment); }
        [JsMethod(Name = "isValid")]
        public Moment IsValid() { return default(Moment); }
        [JsMethod(Name = "invalidAt")]
        public int InvalidAt() { return 0; }

        [JsMethod(Name = "millisecond")]
        public int Millisecond() { return 0; }
        [JsMethod(Name = "milliseconds")]
        public int Milliseconds() { return 0; }
        [JsMethod(Name = "millisecond")]
        public Moment Millisecond(int number) { return default(Moment); }
        [JsMethod(Name = "milliseconds")]
        public Moment Milliseconds(int number) { return default(Moment); }

        [JsMethod(Name = "second")]
        public int Second() { return 0; }
        [JsMethod(Name = "seconds")]
        public int Seconds() { return 0; }
        [JsMethod(Name = "second")]
        public Moment Second(int number) { return default(Moment); }
        [JsMethod(Name = "seconds")]
        public Moment Seconds(int number) { return default(Moment); }

        [JsMethod(Name = "minute")]
        public int Minute() { return 0; }
        [JsMethod(Name = "minutes")]
        public int Minutes() { return 0; }
        [JsMethod(Name = "minute")]
        public Moment Minute(int number) { return default(Moment); }
        [JsMethod(Name = "minutes")]
        public Moment Minutes(int number) { return default(Moment); }

        [JsMethod(Name = "hour")]
        public int Hour() { return 0; }
        [JsMethod(Name = "hours")]
        public int Hours() { return 0; }
        [JsMethod(Name = "hour")]
        public Moment Hour(int number) { return default(Moment); }
        [JsMethod(Name = "hours")]
        public Moment Hours(int number) { return default(Moment); }

        [JsMethod(Name = "date")]
        public int Day() { return 0; }
        [JsMethod(Name = "dates")]
        public int Days() { return 0; }
        [JsMethod(Name = "date")]
        public Moment Day(int number) { return default(Moment); }
        [JsMethod(Name = "dates")]
        public Moment Days(int number) { return default(Moment); }

        // Sunday: 0, ... Saturday: 6
        // todo: use enum
        [JsMethod(Name = "day")]
        public int DayOfWeek() { return 0; }
        [JsMethod(Name = "days")]
        public int DayOfWeeks() { return 0; }
        [JsMethod(Name = "day")]
        public Moment DayOfWeek(int number) { return default(Moment); }
        [JsMethod(Name = "days")]
        public Moment DayOfWeeks(int number) { return default(Moment); }

        [JsMethod(Name = "weekday")]
        public int Weekday() { return 0; }
        [JsMethod(Name = "weekday")]
        public Moment Weekday(int number) { return default(Moment); }

        [JsMethod(Name = "isoWeekday")]
        public int IsoWeekday() { return 0; }
        [JsMethod(Name = "isoWeekday")]
        public Moment IsoWeekday(int number) { return default(Moment); }

        [JsMethod(Name = "dayOfYear")]
        public int DayOfYear() { return 0; }
        [JsMethod(Name = "dayOfYear")]
        public Moment DayOfYear(int number) { return default(Moment); }

        [JsMethod(Name = "week")]
        public int Week() { return 0; }
        [JsMethod(Name = "weeks")]
        public int Weeks() { return 0; }
        [JsMethod(Name = "week")]
        public Moment Week(int number) { return default(Moment); }
        [JsMethod(Name = "weeks")]
        public Moment Weeks(int number) { return default(Moment); }

        [JsMethod(Name = "isoWeek")]
        public int IsoWeek() { return 0; }
        [JsMethod(Name = "isoWeeks")]
        public int IsoWeeks() { return 0; }
        [JsMethod(Name = "isoWeek")]
        public Moment IsoWeek(int number) { return default(Moment); }
        [JsMethod(Name = "isoWeeks")]
        public Moment IsoWeeks(int number) { return default(Moment); }

        [JsMethod(Name = "month")]
        public int Month() { return 0; }
        [JsMethod(Name = "months")]
        public int Months() { return 0; }
        [JsMethod(Name = "month")]
        public Moment Month(int number) { return default(Moment); }
        [JsMethod(Name = "months")]
        public Moment Months(int number) { return default(Moment); }

        [JsMethod(Name = "quarter")]
        public int Quarter() { return 0; }

        [JsMethod(Name = "year")]
        public int Year() { return 0; }
        [JsMethod(Name = "years")]
        public int Years() { return 0; }
        [JsMethod(Name = "year")]
        public Moment Year(int number) { return default(Moment); }
        [JsMethod(Name = "years")]
        public Moment Years(int number) { return default(Moment); }

        [JsMethod(Name = "weekYear")]
        public int WeekYear() { return 0; }
        [JsMethod(Name = "weekYear")]
        public Moment WeekYear(int number) { return default(Moment); }

        [JsMethod(Name = "isoWeekYear")]
        public int IsoWeekYear() { return 0; }
        [JsMethod(Name = "isoWeekYear")]
        public Moment IsoWeekYear(int number) { return default(Moment); }

        [JsMethod(Name = "subtract")]
        public Moment Subtract(MomentUnits unit, int number) { return default(Moment); }
        [JsMethod(Name = "subtract")]
        public Moment Subtract(int number, MomentUnits unit) { return default(Moment); }
        [JsMethod(Name = "subtract")]
        public Moment Subtract(Duration duration) { return default(Moment); }
        [JsMethod(Name = "subtract")]
        public Moment Subtract(MomentOptions options) { return default(Moment); }

        [JsMethod(Name = "add")]
        public Moment Add(MomentUnits unit, int number) { return default(Moment); }
        [JsMethod(Name = "add")]
        public Moment Add(int number, MomentUnits unit) { return default(Moment); }
        [JsMethod(Name = "add")]
        public Moment Add(Duration duration) { return default(Moment); }
        [JsMethod(Name = "add")]
        public Moment Add(MomentOptions options) { return default(Moment); }

        // moment().diff(Moment|String|Number|Date|Array, String, Boolean);
        [JsMethod(Name = "diff")]
        public int Diff(Moment moment, MomentUnits unit = MomentUnits.millisecond) { return 0; }
        [JsMethod(Name = "diff")]
        public int Diff(JsString moment, MomentUnits unit = MomentUnits.millisecond) { return 0; }
        [JsMethod(Name = "diff")]
        public int Diff(int milliseconds, MomentUnits unit = MomentUnits.millisecond) { return 0; }
        [JsMethod(Name = "diff")]
        public int Diff(JsDate date, MomentUnits unit = MomentUnits.millisecond) { return 0; }
        [JsMethod(Name = "diff")]
        public int Diff(JsArray<int> moment, MomentUnits unit = MomentUnits.millisecond) { return 0; }
        [JsMethod(Name = "diff")]
        public double Diff(Moment moment, MomentUnits unit = MomentUnits.millisecond, bool asDouble = true) { return 0; }
        [JsMethod(Name = "diff")]
        public double Diff(JsString moment, MomentUnits unit = MomentUnits.millisecond, bool asDouble = true) { return 0; }
        [JsMethod(Name = "diff")]
        public double Diff(int milliseconds, MomentUnits unit = MomentUnits.millisecond, bool asDouble = true) { return 0; }
        [JsMethod(Name = "diff")]
        public double Diff(JsDate date, MomentUnits unit = MomentUnits.millisecond, bool asDouble = true) { return 0; }
        [JsMethod(Name = "diff")]
        public double Diff(JsArray<int> moment, MomentUnits unit = MomentUnits.millisecond, bool asDouble = true) { return 0; }

        [JsMethod(Name = "max")]
        public Moment Max(Moment moment) { return default(Moment); }
        [JsMethod(Name = "max")]
        public Moment Max(JsString moment) { return default(Moment); }
        [JsMethod(Name = "max")]
        public Moment Max(int milliseconds) { return default(Moment); }
        [JsMethod(Name = "max")]
        public Moment Max(JsDate date) { return default(Moment); }
        [JsMethod(Name = "max")]
        public Moment Max(JsArray<int> moment) { return default(Moment); }
        [JsMethod(Name = "min")]
        public Moment Min(Moment moment) { return default(Moment); }
        [JsMethod(Name = "min")]
        public Moment Min(JsString moment) { return default(Moment); }
        [JsMethod(Name = "min")]
        public Moment Min(int milliseconds) { return default(Moment); }
        [JsMethod(Name = "min")]
        public Moment Min(JsDate date) { return default(Moment); }
        [JsMethod(Name = "min")]
        public Moment Min(JsArray<int> moment) { return default(Moment); }

        [JsMethod(Name = "startOf")]
        public Moment StartOf(MomentUnits unit) { return default(Moment); }
        [JsMethod(Name = "endOf")]
        public Moment EndOf(MomentUnits unit) { return default(Moment); }
        [JsMethod(Name = "daysInMonth")]
        public int DaysInMonth() { return 0; }
        [JsMethod(Name = "toDate")]
        public JsDate ToDate() { return null; }
        [JsMethod(Name = "toArray")]
        public JsArray<int> ToArray() { return null; }
        [JsMethod(Name = "valueOf")]
        public int UnixOffset() { return 0; }
        [JsMethod(Name = "unix")]
        public int UnixTimestamp() { return 0; }

        [JsMethod(Name = "format")]
        public Moment Format(JsString format) { return default(Moment); }
        [JsMethod(Name = "toJSON")]
        public JsString ToJSON() { return null; }
        [JsMethod(Name = "toISOString")]
        public JsString ToISOString() { return null; }

        [JsMethod(InlineCodeExpression = "first.isBefore(second)")]
        public static bool operator <(Moment first, Moment second) { return false; }
        [JsMethod(InlineCodeExpression = "first.isAfter(second)")]
        public static bool operator >(Moment first, Moment second) { return false; }
        [JsMethod(InlineCodeExpression = "first.isSame(second)")]
        public static bool operator ==(Moment first, Moment second) { return false; }
        [JsMethod(InlineCodeExpression = "!first.isSame(second)")]
        public static bool operator !=(Moment first, Moment second) { return false; }
        [JsMethod(InlineCodeExpression = "(first.isSame(second) || first.isAfter(second))")]
        public static bool operator >=(Moment first, Moment second) { return false; }
        [JsMethod(InlineCodeExpression = "(first.isSame(second) || first.isBefore(second))")]
        public static bool operator <=(Moment first, Moment second) { return false; }
        [JsMethod(InlineCodeExpression = "this === equalTo")]
        public override bool Equals(object equalTo) { return false; }

        [JsMethod(Name = "isLeapYear")]
        public bool IsLeapYear() { return false; }
        [JsMethod(Name = "isDST")]
        public bool IsDST() { return false; }
        [JsMethod(Name = "lang")]
        public void Language(JsString languageShort) { }
        [JsMethod(Name = "lang")]
        public JsString Language() { return null; }
        /* prohibited to maintain class integrity between Local and Utc,
		 * use appropriate clone constructor or Clone() instead
		[JsMethod(Name = "utc")]
		public Moment Utc() { return default(Moment); }
		[JsMethod(Name = "local")]
		public Moment Local() { return default(Moment); }
		*/

        [JsMethod(Name = "zone")]
        public Moment Zone(int offset) { return default(Moment); }
        [JsMethod(Name = "zone")]
        public Moment Zone(JsString offset) { return default(Moment); }
        [JsMethod(Name = "zone")]
        public int Zone() { return 0; }
        [JsMethod(Name = "parseZone")]
        public Moment ParseZone(JsString dataTime) { return default(Moment); }
    }


    [JsType(JsMode.Json)]
    public class MomentOptions
    {
        public int years;
        public int months;
        public int days;
        public int hours;
        public int minutes;
        public int seconds;
        public int milliseconds;
    }

    [JsType(JsMode.Json)]
    [JsEnumAttribute(ValuesAsNames = true)]
    public enum MomentUnits
    {
        [JsField(Name = "year")]
        year,
        [JsField(Name = "month")]
        month,
        [JsField(Name = "week")]
        week,
        [JsField(Name = "isoWeek")]
        isoWeek,
        [JsField(Name = "day")]
        day,
        [JsField(Name = "date")]
        date,
        [JsField(Name = "hour")]
        hour,
        [JsField(Name = "minute")]
        minute,
        [JsField(Name = "second")]
        second,
        [JsField(Name = "millisecond")]
        millisecond
    };

    [JsType(JsMode.Prototype, Export = false, Name = "moment.duration")]
    public class Duration
    {
        /// <summary>
        ///To create a duration with the length of time in milliseconds.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public Duration(int milliseconds) { }
        /// <summary>
        ///To create a duration from string
        ///The format is an hour, minute, second string separated by colons like 23:59:59. 
        ///The number of days can be prefixed with a dot separator like so 7.23:59:59. 
        ///Partial seconds are supported as well 23:59:59.999.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public Duration(JsString duration) { }
        /// <summary>
        ///If you want to duration with a unit of measurement other than milliseconds, 
        ///you can pass the unit of measurement as well.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public Duration(int duration, MomentUnits unit) { }
        /// <summary>
        ///To create a duration with Options.
        /// </summary>
        [JsMethod(OmitNewOperator = true)]
        public Duration(MomentOptions options) { }

        /// <summary>
        ///Shows a human readable duration, such as "a minute".
        ///By default, the return string is suffixless.
        ///If you want a suffix "in a minute", pass in true.
        ///For suffixes before now "a minute ago", pass in a negative number.
        /// </summary>
        [JsMethod(Name = "humanize")]
        public JsString Humanize(bool suffix = false) { return null; }
        /// <summary>
        ///Get the number of milliseconds in a duration.
        ///It will return a number between 0 and 1000
        /// </summary>
        [JsMethod(Name = "milliseconds")]
        public int Milliseconds() { return 0; }
        /// <summary>
        ///Get the duration in milliseconds.
        /// </summary>
        [JsMethod(Name = "asMilliseconds")]
        public double AsMilliseconds() { return 0; }
        /// <summary>
        ///Get the number of seconds in a duration.
        ///It will return a number between 0 and 59
        /// </summary>
        [JsMethod(Name = "seconds")]
        public int Seconds() { return 0; }
        /// <summary>
        ///Get the duration in seconds.
        /// </summary>
        [JsMethod(Name = "asSeconds")]
        public double AsSeconds() { return 0; }
        /// <summary>
        ///Get the number of minutes in a duration.
        ///It will return a number between 0 and 59
        /// </summary>
        [JsMethod(Name = "minutes")]
        public int Minutes() { return 0; }
        /// <summary>
        ///Get the duration in minutes.
        /// </summary>
        [JsMethod(Name = "asMinutes")]
        public double AsMinutes() { return 0; }
        /// <summary>
        ///Get the number of hours in a duration.
        ///It will return a number between 0 and 59
        /// </summary>
        [JsMethod(Name = "hours")]
        /// <summary>
        ///Get the duration in hours.
        /// </summary>
        public int Hours() { return 0; }
        [JsMethod(Name = "asHours")]
        public double AsHours() { return 0; }
        [JsMethod(Name = "days")]
        public int Days() { return 0; }
        [JsMethod(Name = "asDays")]
        public double AsDays() { return 0; }
        [JsMethod(Name = "months")]
        public int Months() { return 0; }
        [JsMethod(Name = "asMonths")]
        public double AsMonths() { return 0; }
        [JsMethod(Name = "years")]
        public int Years() { return 0; }
        [JsMethod(Name = "asYears")]
        public double AsYears() { return 0; }
        [JsMethod(Name = "as")]
        public int As(MomentUnits unit) { return 0; }
        [JsMethod(Name = "get")]
        public int Get(MomentUnits unit) { return 0; }

        [JsMethod(Name = "fromNow")]
        public JsString FromNow(bool withoutSuffix = false) { return null; }
        [JsMethod(Name = "from")]
        public JsString From(Moment moment, bool withoutSuffix = false) { return null; }
        [JsMethod(Name = "from")]
        public JsString From(JsString moment, bool withoutSuffix = false) { return null; }
        [JsMethod(Name = "from")]
        public JsString From(int milliseconds, bool withoutSuffix = false) { return null; }
        [JsMethod(Name = "from")]
        public JsString From(JsArray<int> moment, bool withoutSuffix = false) { return null; }
        [JsMethod(Name = "from")]
        public JsString From(JsDate date, bool withoutSuffix = false) { return null; }
        [JsMethod(Name = "calendar")]
        public JsString Calendar() { return null; }

        [JsMethod(Name = "subtract")]
        public Duration Subtract(int number, MomentUnits unit) { return null; }
        [JsMethod(Name = "subtract")]
        public Duration Subtract(int number) { return null; }
        [JsMethod(Name = "subtract")]
        public Duration Subtract(Duration duration) { return null; }
        [JsMethod(Name = "subtract")]
        public Duration Subtract(MomentOptions options) { return null; }

        [JsMethod(Name = "add")]
        public Duration Add(int number, MomentUnits unit) { return null; }
        [JsMethod(Name = "add")]
        public Duration Add(int number) { return null; }
        [JsMethod(Name = "add")]
        public Duration Add(Duration duration) { return null; }
        [JsMethod(Name = "add")]
        public Duration Add(MomentOptions options) { return null; }
    }

}
