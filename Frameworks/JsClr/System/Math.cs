using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{
	[JsType(Name = "System.Math", Filename="~/res/System.ComponentModel.js")]
	internal class JsImplMath
	{
        public static double PI = JsMath.PI;// 3.1415926535897931;

		public static JsNumber Abs(JsNumber value)
		{
			return JsMath.abs(value);
		}
		public static double Abs(double value)
		{
			return JsMath.abs(value).As<double>();
		}
        //public static short Abs(short value)
        //{
        //    return JsMath.abs(value).As<short>();
        //}
		public static int Abs(int value)
		{
			return JsMath.abs(value).As<int>();
		}
		public static long Abs(long value)
		{
			return JsMath.abs((decimal)value).As<long>();
		}
        //public static sbyte Abs(sbyte value)
        //{
        //    return JsMath.abs(value).As<sbyte>();
        //}
		public static float Abs(float value)
		{
			return JsMath.abs(value).As<float>();
		}

		private static short AbsHelper(short value)
		{
			throw new NotImplementedException();
		}
		private static int AbsHelper(int value)
		{
			throw new NotImplementedException();
		}
		private static long AbsHelper(long value)
		{
			throw new NotImplementedException();
		}
		private static sbyte AbsHelper(sbyte value)
		{
			throw new NotImplementedException();
		}

		public static double Acos(double d)
		{
			return JsMath.acos(d).As<double>();
		}
		public static double Asin(double d)
		{
			return JsMath.asin(d).As<double>();
		}
		public static double Atan(double d)
		{
			return JsMath.atan(d).As<double>();
		}
		public static double Atan2(double y, double x)
		{
			return JsMath.atan2(y, x).As<double>();
		}
		

		public static long BigMul(int a, int b)
		{
			throw new NotImplementedException();
		}
		public static decimal Ceiling(decimal d)
		{
			return JsMath.ceil(d).As<decimal>();
		}
		public static double Ceiling(double a)
		{
			return JsMath.ceil(a).As<double>();
		}

		public static double Cos(double d)
		{
			return JsMath.cos(d).As<double>();
		}

		public static double Cosh(double value)
		{
			throw new NotImplementedException();
		}
        [JsMethod(Export=false)]
		public static int DivRem(int a, int b, out int result)
		{
			throw new NotImplementedException();
		}
        [JsMethod(Export = false)]
        public static long DivRem(long a, long b, out long result)
		{
			throw new NotImplementedException();
		}

		public static double Exp(double d)
		{
			return JsMath.exp(d).As<double>();
		}
		public static decimal Floor(decimal d)
		{
			return JsMath.floor(d).As<decimal>();
		}

		public static double Floor(double d)
		{
			return JsMath.floor(d).As<double>();
		}
		public static double IEEERemainder(double x, double y)
		{
			throw new NotImplementedException();
		}
		private static double InternalRound(double value, int digits, MidpointRounding mode)
		{
			throw new NotImplementedException();
		}
		private static double InternalTruncate(double d)
		{
			throw new NotImplementedException();
		}

		public static double Log(double d)
		{
			return JsMath.log(d).As<double>();
		}
		public static double Log(double a, double newBase)
		{
            return JsMath.log(a) / JsMath.log(newBase);
		}

		public static double Log10(double d)
		{
            return JsMath.log(d) / JsMath.LN10;
		}

        //public static byte Max(byte val1, byte val2)
        //{
        //    return JsMath.max(val1, val2).As<byte>();
        //}

		public static decimal Max(decimal val1, decimal val2)
		{
			return JsMath.max(val1, val2).As<decimal>();
		}

		public static double Max(double val1, double val2)
		{
			return JsMath.max(val1, val2).As<double>();
		}

        //public static short Max(short val1, short val2)
        //{
        //    return JsMath.max(val1, val2).As<short>();
        //}

		public static int Max(int val1, int val2)
		{
			return JsMath.max(val1, val2).As<int>();
		}

		public static long Max(long val1, long val2)
		{
			return JsMath.max((decimal)val1, (decimal)val2).As<long>();
		}
		public static sbyte Max(sbyte val1, sbyte val2)
		{
			return JsMath.max(val1, val2).As<sbyte>();
		}

		public static float Max(float val1, float val2)
		{
			return JsMath.max(val1, val2).As<float>();
		}
        //public static ushort Max(ushort val1, ushort val2)
        //{
        //    return JsMath.max(val1, val2).As<ushort>();
        //}
		public static uint Max(uint val1, uint val2)
		{
			return JsMath.max((decimal)val1, (decimal)val2).As<uint>();
		}
		public static ulong Max(ulong val1, ulong val2)
		{
			return JsMath.max((decimal)val1, (decimal)val2).As<ulong>();
		}

        //public static byte Min(byte val1, byte val2)
        //{
        //    return JsMath.min(val1, val2).As<byte>();
        //}

		public static decimal Min(decimal val1, decimal val2)
		{
			return JsMath.min(val1, val2).As<decimal>();
		}

		public static double Min(double val1, double val2)
		{
			return JsMath.min(val1, val2).As<double>();
		}

        //public static short Min(short val1, short val2)
        //{
        //    return JsMath.min(val1, val2).As<short>();
        //}

		public static int Min(int val1, int val2)
		{
			return JsMath.min(val1, val2).As<int>();
		}

		public static long Min(long val1, long val2)
		{
			return JsMath.min((decimal)val1, (decimal)val2).As<long>();
		}
		public static sbyte Min(sbyte val1, sbyte val2)
		{
			return JsMath.min(val1, val2).As<sbyte>();
		}

		public static float Min(float val1, float val2)
		{
			return JsMath.min(val1, val2).As<long>();
		}
        //public static ushort Min(ushort val1, ushort val2)
        //{
        //    return JsMath.min(val1, val2).As<ushort>();
        //}
		public static uint Min(uint val1, uint val2)
		{
			return JsMath.min((decimal)val1, (decimal)val2).As<uint>();
		}
		public static ulong Min(ulong val1, ulong val2)
		{
			return JsMath.min((decimal)val1, (decimal)val2).As<ulong>();
		}

		public static double Pow(double x, double y)
		{
			return JsMath.pow(x, y).As<double>();
		}
		public static decimal Round(decimal d)
		{
			return JsMath.round(d).As<decimal>();
		}

		public static double Round(double a)
		{
			return JsMath.round(a).As<double>();
		}
		public static decimal Round(decimal d, int decimals)
		{
			var pow = JsMath.pow(10, decimals);
			return JsMath.round(d * pow) / pow;
		}
		public static decimal Round(decimal d, MidpointRounding mode)
		{
			throw new NotImplementedException();
		}
		public static double Round(double value, int digits)
		{
			var pow = JsMath.pow(10, digits);
			return JsMath.round(value * pow) / pow;
		}
		public static double Round(double value, MidpointRounding mode)
		{
			throw new NotImplementedException();
		}
		public static decimal Round(decimal d, int decimals, MidpointRounding mode)
		{
			throw new NotImplementedException();
		}
		public static double Round(double value, int digits, MidpointRounding mode)
		{
			throw new NotImplementedException();
		}
		public static int Sign(decimal value)
		{
            if (value < 0.0M)
                return -1;
            if (value > 0.0M)
                return 1;
            if (value == 0.0M)
                return 0;
            throw new ArgumentException("value");
		}
		public static int Sign(double value)
		{
			if (value < 0.0)
                return -1;
            if (value > 0.0)
                return 1;
		    if (value == 0.0)
		        return 0;
		    throw new ArgumentException("value");
		}
		public static int Sign(short value)
		{
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw new ArgumentException("value");
		}
		public static int Sign(int value)
		{
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw new ArgumentException("value");
		}
		public static int Sign(long value)
		{
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw new ArgumentException("value");
		}
		public static int Sign(sbyte value)
		{
            if (value < 0)
                return -1;
            if (value > 0)
                return 1;
            if (value == 0)
                return 0;
            throw new ArgumentException("value");
		}
		public static int Sign(float value)
		{
            if (value < 0.0f)
                return -1;
            if (value > 0.0f)
                return 1;
            if (value == 0.0f)
                return 0;
            throw new ArgumentException("value");
		}

		public static double Sin(double a)
		{
			return JsMath.sin(a).As<double>();
		}

		public static double Sinh(double value)
		{
			throw new NotImplementedException();
		}

		//    private static double SplitFractionDouble(double* value)
		//{
		//}
		public static double Sqrt(double d)
		{
			return JsMath.sqrt(d).As<double>();
		}

		public static double Tan(double a)
		{
			return JsMath.tan(a).As<double>();
		}

		public static double Tanh(double value)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// Calculates the integral part of a specified double-precision floating-point number. 
        /// </summary>
        /// <param name="d">The value to truncate.</param>
        /// <returns>The result.</returns>
		public static decimal Truncate(decimal d)
		{
            return d.As<JsNumber>() | 0;
		}

        /// <summary>
        /// Calculates the integral part of a specified double-precision floating-point number. 
        /// </summary>
        /// <param name="d">The value to truncate.</param>
        /// <returns>The result.</returns>
		public static double Truncate(double d)
		{
            return d.As<JsNumber>() | 0;
        }




	}
}
