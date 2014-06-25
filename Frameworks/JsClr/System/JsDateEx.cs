using System;
using System.Collections.Generic;
using System.Text;


namespace SharpKit.JavaScript.Private
{
    [JsType(JsMode.Prototype, Name = "Date", Filename = "~/Internal/Core.js", OmitDefaultConstructor = true, OmitInheritance = true, NativeOverloads = false)]
    internal class JsDateEx : JsDate
    {
        [JsMethod(Export = false)]
        public JsDateEx(JsNumber miliseconds)
            : base(miliseconds)
        {
        }

        [JsMethod(Export = false)]
        public JsDateEx()
        {
        }

        [JsMethod(Export = false)]
        public JsDateEx(JsString value) { }
        [JsMethod(Export = false)]
        public JsDateEx(int year, int month, int date) { }
        [JsMethod(Export = false)]
        public JsDateEx(int year, int month, int date, int hours) { }
        [JsMethod(Export = false)]
        public JsDateEx(int year, int month, int date, int hours, int minutes) { }
        [JsMethod(Export = false)]
        public JsDateEx(int year, int month, int date, int hours, int minutes, int seconds) { }
        [JsMethod(Export = false)]
        public JsDateEx(int year, int month, int date, int hours, int minutes, int seconds, int ms) { }

        public int CompareTo(JsDateEx value)
        {
            return valueOf() - value.valueOf();
        }

        public int Year
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCFullYear();
                return getFullYear();
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCFullYear(value);
                else
                    setFullYear(value);
            }

        }
        public int Month
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCMonth() + 1;
                return getMonth() + 1;
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCMonth(value - 1);
                else
                    setMonth(value - 1);
            }

        }
        public int Day
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCDate();
                return getDate();
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCDate(value);
                else
                    setDate(value);
            }

        }
        public int Hour
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCHours();
                return getHours();
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCHours(value);
                else
                    setHours(value);
            }
        }
        public int Minute
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCMinutes();
                return getMinutes();
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCMinutes(value);
                else
                    setMinutes(value);
            }
        }
        public int Second
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCSeconds();
                return getSeconds();
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCSeconds(value);
                else
                    setSeconds(value);
            }
        }
        public int Millisecond
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCMilliseconds();
                return getMilliseconds();
            }
            set
            {
                if (_Kind == DateTimeKind.Utc)
                    setUTCMilliseconds(value);
                else
                    setMilliseconds(value);
            }
        }

        //public long Epoch
        //{
        //    get
        //    {
        //        return valueOf();
        //        if (_Kind == DateTimeKind.Utc)
        //            return valueOf();
        //        //return JsDate.UTC(getUTCFullYear(), getUTCMonth(), getUTCDate(), getUTCHours(), getUTCMinutes(), getUTCSeconds(), getUTCMilliseconds());
        //        return JsDate.UTC(getFullYear(), getMonth(), getDate(), getHours(), getMinutes(), getSeconds(), getMilliseconds());
        //    }
        //}

        // WARNING
        // the Ticks property currently has a resolution of 1 millisecond only!
        public long Ticks
        {
            get
            {
                if (_Kind == DateTimeKind.Utc)
                    return getUTCMilliseconds() * 10000;
                return getMilliseconds() * 10000;
            }
            set
            {
                double milliseconds = value / 10000;
                if (_Kind == DateTimeKind.Utc)
                    setUTCMilliseconds(milliseconds);
                else
                    setMilliseconds(milliseconds);
            }
        }

        //TODO: JS Enums problem (DayOfWeek)
        public int DayOfWeek
        {
            get
            {
                return getDay();
            }
        }

        public JsDateEx ToLocalTime()
        {
            if (_Kind != DateTimeKind.Utc)
                return this;
            var x = Clone();
            x._Kind = DateTimeKind.Local;
            return x;
        }
        public JsDateEx ToUniversalTime()
        {
            if (_Kind == DateTimeKind.Utc)
                return this;
            var x = Clone();
            x._Kind = DateTimeKind.Utc;
            return x;
        }

        public static JsDateEx Today
        {
            get
            {
                return new JsDateEx().RemoveTime();
            }
        }

        public TimeSpan Subtract(DateTime value)
        {
            var diff = valueOf() - value.As<JsDateEx>().valueOf();
            return new TimeSpan(diff * TimeSpan.TicksPerMillisecond);
        }
        public JsDateEx Subtract(TimeSpan value)
        {
            var newDate = Clone();
            newDate.setMilliseconds(getMilliseconds() + value.TotalMilliseconds);
            return newDate;
        }

        public string ToString(string format)
        {
            format = format.Replace("yyyy", Year.ToString("0000"));
            format = format.Replace("yy", Year.ToString("00"));
            format = format.Replace("y", Year.ToString());
            format = format.Replace("MM", Month.ToString("00"));
            format = format.Replace("M", Month.ToString());
            format = format.Replace("dd", Day.ToString("00"));
            format = format.Replace("d", Day.ToString());
            format = format.Replace("HH", Hour.ToString("00"));
            format = format.Replace("H", Hour.ToString());
            format = format.Replace("mm", Minute.ToString("00"));
            format = format.Replace("m", Minute.ToString());
            format = format.Replace("ss", Second.ToString("00"));
            format = format.Replace("s", Second.ToString());
            return format;
        }

        JsDateEx Clone()
        {
            var x = new JsDateEx(valueOf());
            x._Kind = _Kind;
            return x;
        }
        JsDateEx Clone2(JsNumber totalMs)
        {
            var x = new JsDateEx(totalMs);
            x._Kind = _Kind;
            return x;
        }
        public JsDateEx AddMilliseconds(int miliseconds)
        {
            var date2 = Clone2(valueOf() + miliseconds);
            return date2;
        }

        public JsDateEx AddSeconds(int seconds)
        {
            var ms = valueOf() + (seconds * 1000);
            var date2 = Clone2(ms.As<JsNumber>());
            //date2.setSeconds(date2.getSeconds() + seconds);
            return date2;
        }

        public JsDateEx AddMinutes(int minutes)
        {
            var date2 = Clone();
            date2.setMinutes(date2.getMinutes() + minutes);
            return date2;
        }

        public JsDateEx AddHours(int hours)
        {
            var date2 = Clone();
            date2.setHours(date2.getHours() + hours);
            return date2;
        }

        public JsDateEx AddDays(int days)
        {
            var date2 = Clone();
            date2.setDate(date2.getDate() + days);
            return date2;
        }

        public JsDateEx AddMonths(int months)
        {
            var date2 = Clone();
            date2.setMonth(date2.getMonth() + months);
            return date2;
        }

        public JsDateEx AddYears(int years)
        {
            var date2 = Clone();
            date2.setMonth(date2.getFullYear() + years);
            return date2;
        }

        public JsDateEx RemoveTime()
        {
            var date2 = Clone();
            date2.setHours(0, 0, 0, 0);
            return date2;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return obj.As<JsDate>().valueOf() == valueOf();
        }

        public override int GetHashCode()
        {
            return valueOf();
        }


        public new Type GetType()
        {
            return typeof(DateTime);
        }

        internal DateTimeKind _Kind;
        public DateTimeKind Kind
        {
            get
            {
                if (_Kind.As<JsObject>() == null)
                    return DateTimeKind.Local;
                return _Kind;
            }
        }

    }
}