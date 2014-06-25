namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.TimeSpan", Filename = "~/Internal/Core.js")]
    public class JsImplTimeSpan //TODO:: System.IComparable, System.IComparable<JsImplTimeSpan>, System.IEquatable<JsImplTimeSpan>//TODO:, System.IFormattable
    {
        public const long TicksPerMillisecond = 10000L;
        private const double MillisecondsPerTick = 0.0001;
        public const long TicksPerSecond = 10000000L;
        private const double SecondsPerTick = 1E-07;
        public const long TicksPerMinute = 600000000L;
        private const double MinutesPerTick = 1.6666666666666667E-09;
        public const long TicksPerHour = 36000000000L;
        private const double HoursPerTick = 2.7777777777777777E-11;
        public const long TicksPerDay = 864000000000L;
        private const double DaysPerTick = 1.1574074074074074E-12;
        private const int MillisPerSecond = 1000;
        private const int MillisPerMinute = 60000;
        private const int MillisPerHour = 3600000;
        private const int MillisPerDay = 86400000;
        internal const long MaxSeconds = 922337203685L;
        internal const long MinSeconds = -922337203685L;
        internal const long MaxMilliSeconds = 922337203685477L;
        internal const long MinMilliSeconds = -922337203685477L;
        internal const long TicksPerTenthSecond = 1000000L;
        public static readonly JsImplTimeSpan Zero = new JsImplTimeSpan(0L);
        public static readonly JsImplTimeSpan MaxValue = new JsImplTimeSpan(9223372036854775807L);
        public static readonly JsImplTimeSpan MinValue = new JsImplTimeSpan(-9223372036854775808L);
        internal double _TotalMilliseconds;
        public long Ticks
        {
            get
            {
                return (_TotalMilliseconds * 10000).As<long>();
            }
        }
        public long _ticks
        {
            get
            {
                return (_TotalMilliseconds * 10000).As<long>();
            }
        }
        public int Days
        {
            get
            {
                return (_ticks / 864000000000D).As<int>();
            }
        }
        public int Hours
        {
            get
            {
                return (_ticks / 36000000000D % 24D).As<int>();
            }
        }
        public int Milliseconds
        {
            get
            {
                return (_ticks / 10000D % 1000D).As<int>();
            }
        }
        public int Minutes
        {
            get
            {
                return (_ticks / 600000000D % 60D).As<int>();
            }
        }
        public int Seconds
        {
            get
            {
                return (_ticks / 10000000D % 60D).As<int>();
            }
        }
        public double TotalDays
        {
            get
            {
                return _ticks / MillisPerDay;// 1.1574074074074074E-12;
            }
        }
        public double TotalHours
        {
            get
            {
                return _TotalMilliseconds / MillisPerHour;// *2.7777777777777777E-11;
            }
        }
        public double TotalMilliseconds
        {
            get
            {
                return _TotalMilliseconds;
            }
        }
        public double TotalMinutes
        {
            get
            {
                return _TotalMilliseconds / MillisPerMinute;// _ticks / TicksPerMillisecond.As<double>() / 1000D / 60D; //* 1.6666666666666667E-09;
            }
        }
        public double TotalSeconds
        {
            get
            {
                return _TotalMilliseconds / MillisPerSecond;// 1000;// _ticks * 1E-07;
            }
        }

        public JsImplTimeSpan()
        {
        }
        public JsImplTimeSpan(long ticks)
        {
            _TotalMilliseconds = ticks / 10000;
        }
        
        public JsImplTimeSpan(int hours, int minutes, int seconds)
        {
            _TotalMilliseconds = TimeToMs(hours, minutes, seconds);
        }
        public JsImplTimeSpan(int days, int hours, int minutes, int seconds) : this(days, hours, minutes, seconds, 0)
        {

        }
        public JsImplTimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
        {
            long num = (days * 3600L * 24L + hours * 3600L + minutes * 60L + seconds) * 1000L + milliseconds;
            if (num > 922337203685477L || num < -922337203685477L)
            {
                throw new System.ArgumentOutOfRangeException(null, "Overflow_TimeSpanTooLong");
            }
            _TotalMilliseconds = num;// *10000L;
        }
        public JsImplTimeSpan Add(JsImplTimeSpan ts)
        {
            var num = _TotalMilliseconds + ts._TotalMilliseconds;
            //if (_ticks >> 63 == ts._ticks >> 63 && _ticks >> 63 != num >> 63)
            //{
            //    throw new System.OverflowException("Overflow_TimeSpanTooLong");
            //}
            return JsImplTimeSpan.FromMilliseconds(num);
        }
        public static int Compare(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            if (t1._ticks > t2._ticks)
            {
                return 1;
            }
            if (t1._ticks < t2._ticks)
            {
                return -1;
            }
            return 0;
        }
        public int CompareTo(object value)
        {
            if (value == null)
            {
                return 1;
            }
            if (!(value is JsImplTimeSpan))
            {
                throw new System.ArgumentException("Arg_MustBeTimeSpan");
            }
            long ticks = ((JsImplTimeSpan)value)._ticks;
            if (_ticks > ticks)
            {
                return 1;
            }
            if (_ticks < ticks)
            {
                return -1;
            }
            return 0;
        }
        public int CompareTo(JsImplTimeSpan value)
        {
            long ticks = value._ticks;
            if (_ticks > ticks)
            {
                return 1;
            }
            if (_ticks < ticks)
            {
                return -1;
            }
            return 0;
        }
        public static JsImplTimeSpan FromDays(double value)
        {
            return JsImplTimeSpan.Interval(value, 86400000);
        }
        public JsImplTimeSpan Duration()
        {
            if (Ticks == JsImplTimeSpan.MinValue.Ticks)
            {
                throw new System.OverflowException("Overflow_Duration");
            }
            return new JsImplTimeSpan((_ticks >= 0L) ? _ticks : (-_ticks));
        }
        public override bool Equals(object value)
        {
            return value is JsImplTimeSpan && _ticks == ((JsImplTimeSpan)value)._ticks;
        }
        public bool Equals(JsImplTimeSpan obj)
        {
            return _ticks == obj._ticks;
        }
        public static bool Equals(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks == t2._ticks;
        }
        public override int GetHashCode()
        {
            return (_ticks ^ (_ticks >> 32)).As<int>();
        }
        public static JsImplTimeSpan FromHours(double value)
        {
            return JsImplTimeSpan.Interval(value, 3600000);
        }
        private static JsImplTimeSpan Interval(double value, int scale)
        {
            if (double.IsNaN(value))
            {
                throw new System.ArgumentException("Arg_CannotBeNaN");
            }
            double num = value * scale;
            double num2 = num + ((value >= 0.0) ? 0.5 : -0.5);
            if (num2 > 922337203685477.0 || num2 < -922337203685477.0)
            {
                throw new System.OverflowException("Overflow_TimeSpanTooLong");
            }
            return new JsImplTimeSpan((num2 * 10000L).As<long>());
        }
        public static JsImplTimeSpan FromMilliseconds(double value)
        {
            var ts = new JsImplTimeSpan();
            ts._TotalMilliseconds = value;
            return ts;
        }
        public static JsImplTimeSpan FromMinutes(double value)
        {
            return JsImplTimeSpan.Interval(value, 60000);
        }
        public JsImplTimeSpan Negate()
        {
            if (Ticks == JsImplTimeSpan.MinValue.Ticks)
            {
                throw new System.OverflowException("Overflow_NegateTwosCompNum");
            }
            return new JsImplTimeSpan(-_ticks);
        }
        public static JsImplTimeSpan FromSeconds(double value)
        {
            return JsImplTimeSpan.Interval(value, 1000);
        }
        public JsImplTimeSpan Subtract(JsImplTimeSpan ts)
        {
            long num = _ticks - ts._ticks;
            if (_ticks >> 63 != ts._ticks >> 63 && _ticks >> 63 != num >> 63)
            {
                throw new System.OverflowException("Overflow_TimeSpanTooLong");
            }
            return new JsImplTimeSpan(num);
        }
        public static JsImplTimeSpan FromTicks(long value)
        {
            return new JsImplTimeSpan(value);
        }
        internal static long TimeToTicks(int hour, int minute, int second)
        {
            var num = hour * 3600L + minute * 60L + second;
            if (num > 922337203685L || num < -922337203685L)
            {
                throw new System.ArgumentOutOfRangeException(null, "Overflow_TimeSpanTooLong");
            }
            return num * 10000000L;
        }
        internal static long TimeToMs(int hour, int minute, int second)
        {
            var num = hour * 3600L + minute * 60L + second;
            if (num > 922337203685L || num < -922337203685L)
            {
                throw new System.ArgumentOutOfRangeException(null, "Overflow_TimeSpanTooLong");
            }
            return num * 1000L;
        }
        #region TODO: Parse

        //public static JsImplTimeSpan Parse(string s)
        //{
        //    return TimeSpanParse.Parse(s, null);
        //}
        //public static JsImplTimeSpan Parse(string input, IFormatProvider formatProvider)
        //{
        //    return TimeSpanParse.Parse(input, formatProvider);
        //}
        //public static JsImplTimeSpan ParseExact(string input, string format, IFormatProvider formatProvider)
        //{
        //    return TimeSpanParse.ParseExact(input, format, formatProvider, TimeSpanStyles.None);
        //}
        //public static JsImplTimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider)
        //{
        //    return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None);
        //}
        //public static JsImplTimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles)
        //{
        //    TimeSpanParse.ValidateStyles(styles, "styles");
        //    return TimeSpanParse.ParseExact(input, format, formatProvider, styles);
        //}
        //public static JsImplTimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
        //{
        //    TimeSpanParse.ValidateStyles(styles, "styles");
        //    return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, styles);
        //}
        //public static bool TryParse(string s, out JsImplTimeSpan result)
        //{
        //    return TimeSpanParse.TryParse(s, null, out result);
        //}
        //public static bool TryParse(string input, IFormatProvider formatProvider, out JsImplTimeSpan result)
        //{
        //    return TimeSpanParse.TryParse(input, formatProvider, out result);
        //}
        //public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out JsImplTimeSpan result)
        //{
        //    return TimeSpanParse.TryParseExact(input, format, formatProvider, TimeSpanStyles.None, out result);
        //}
        //public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, out JsImplTimeSpan result)
        //{
        //    return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None, out result);
        //}
        //public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out JsImplTimeSpan result)
        //{
        //    TimeSpanParse.ValidateStyles(styles, "styles");
        //    return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
        //}
        //public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out JsImplTimeSpan result)
        //{
        //    TimeSpanParse.ValidateStyles(styles, "styles");
        //    return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, styles, out result);
        //}
        //public override string ToString()
        //{
        //    return TimeSpanFormat.Format(this, null, null);
        //}
        //public string ToString(string format)
        //{
        //    return TimeSpanFormat.Format(this, format, null);
        //}
        //public string ToString(string format, IFormatProvider formatProvider)
        //{
        //    if (JsImplTimeSpan.LegacyMode)
        //    {
        //        return TimeSpanFormat.Format(this, null, null);
        //    }
        //    return TimeSpanFormat.Format(this, format, formatProvider);
        //}
        #endregion

        public static JsImplTimeSpan operator -(JsImplTimeSpan t)
        {
            if (t._ticks == JsImplTimeSpan.MinValue._ticks)
            {
                throw new System.OverflowException("Overflow_NegateTwosCompNum");
            }
            return new JsImplTimeSpan(-t._ticks);
        }
        public static JsImplTimeSpan operator -(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1.Subtract(t2);
        }
        public static JsImplTimeSpan operator +(JsImplTimeSpan t)
        {
            return t;
        }
        public static JsImplTimeSpan operator +(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1.Add(t2);
        }
        public static bool operator ==(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks == t2._ticks;
        }
        public static bool operator !=(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks != t2._ticks;
        }
        public static bool operator <(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks < t2._ticks;
        }
        public static bool operator <=(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks <= t2._ticks;
        }
        public static bool operator >(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks > t2._ticks;
        }
        public static bool operator >=(JsImplTimeSpan t1, JsImplTimeSpan t2)
        {
            return t1._ticks >= t2._ticks;
        }
    }
}
