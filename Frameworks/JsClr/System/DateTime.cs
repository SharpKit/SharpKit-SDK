using System;
using System.Collections.Generic;
using System.Text;


namespace SharpKit.JavaScript.Private
{

    [JsType(Name = "System.DateTime", Filename = "~/Internal/Core.js", OmitInheritance = true)]
    internal class JsImplDateTime : JsDateEx
    {

        public JsImplDateTime()
        {
            var x = MinValue;
            JsContext.@return(x);
        }
        public JsImplDateTime(long ticks)
        {
            throw new NotSupportedException("Ticks are not available due to JavaScript number limitation");
        }

        public JsImplDateTime(int year, int month, int day)
        {
            var x = new JsDateEx();
            x.Year = year;
            x.Month = month;
            x.Day = day;
            JsContext.@return(x);
        }

        public JsImplDateTime(int year, int month, int day, int hour, int minute, int second)
        {
            var x = new JsDateEx(year, month - 1, day, hour, minute, second);
            JsContext.@return(x);
        }
        public JsImplDateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
        {
            JsDateEx x;
            if (kind == DateTimeKind.Utc)
            {
                x = new JsDateEx(JsDate.UTC(year, month - 1, day, hour, minute, second));
            }
            else
            {
                x = new JsDateEx(year, month - 1, day, hour, minute, second);
            }
            x._Kind = kind;
            JsContext.@return(x);
        }

        static JsImplDateTime()
        {
            MinValue = new JsDate(0).As<JsImplDateTime>();
            MinValue.setUTCFullYear(1, 0, 1);
            MaxValue = new JsDate(0).As<JsImplDateTime>();
            MaxValue.setUTCFullYear(9999, 11, 31);
        }

        public static JsImplDateTime MinValue;
        public static JsImplDateTime MaxValue;
        [JsMethod(Name = "Parse$$String")]
        public static JsImplDateTime Parse(string str)
        {
            return new JsDateEx(JsDate.parse(str)).As<JsImplDateTime>();
        }

        public static int DaysInMonth(int year, int month)
        {
            return 32 - new JsDate(year, month - 1, 32).getDate();
        }
        public static int Compare(JsImplDateTime t1, JsImplDateTime t2)
        {
            return t1.valueOf() - t2.valueOf();
        }
        public static bool operator ==(JsImplDateTime t1, JsImplDateTime t2)
        {
            return Compare(t1, t2) == 0;
        }

        public static bool operator !=(JsImplDateTime t1, JsImplDateTime t2)
        {
            return Compare(t1, t2) != 0;
        }

        public static bool operator >(JsImplDateTime t1, JsImplDateTime t2)
        {
            return Compare(t1, t2) > 0;
        }
        public static bool operator <(JsImplDateTime t1, JsImplDateTime t2)
        {
            return Compare(t1, t2) < 0;
        }
        public static bool operator <=(JsImplDateTime t1, JsImplDateTime t2)
        {
            return Compare(t1, t2) <= 0;
        }
        public static bool operator >=(JsImplDateTime t1, JsImplDateTime t2)
        {
            return Compare(t1, t2) >= 0;
        }
        public static TimeSpan operator -(JsImplDateTime t1, JsImplDateTime t2)
        {
            return TimeSpan.FromMilliseconds(t1.valueOf() - t2.valueOf());
        }
        public static JsImplDateTime operator -(JsImplDateTime t1, TimeSpan t2)
        {
            return new JsDate((long)t1.valueOf() - (long)t2.TotalMilliseconds).As<JsImplDateTime>();
        }

        public static TimeSpan operator +(JsImplDateTime t1, JsImplDateTime t2)
        {
            return TimeSpan.FromMilliseconds(t1.valueOf() + t2.valueOf());
        }
        public static JsImplDateTime operator +(JsImplDateTime t1, TimeSpan t2)
        {
            return new JsDate((long)t1.valueOf() + (long)t2.TotalMilliseconds).As<JsImplDateTime>();
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

        static int CompareJsDates(JsDate d1, JsDate d2)
        {
            if (d1 == d2)
                return 0;
            if (d1 == null)
                return 1;
            if (d2 == null)
                return -1;
            return d1.valueOf() - d2.valueOf();
        }
        public static JsImplDateTime Now
        {
            get
            {
                return new JsDate().As<JsImplDateTime>();
            }
        }

        public static JsImplDateTime UtcNow
        {
            get
            {
#warning to be implemented correctly
              return Now;
            }
        }
        public new static JsImplDateTime Today
        {
            get
            {
                return JsDateEx.Today.As<JsImplDateTime>();
            }
        }


    }


    [JsType(Name = "System.DateTimeKind", Filename = "~/Internal/Core.js", OmitInheritance = true)]
    public enum DateTimeKind
    {
        /// <summary>The time represented is not specified as either local time or Coordinated Universal Time (UTC).</summary>
        Unspecified,
        /// <summary>The time represented is UTC.</summary>
        Utc,
        /// <summary>The time represented is local time.</summary>
        Local
    }
}
