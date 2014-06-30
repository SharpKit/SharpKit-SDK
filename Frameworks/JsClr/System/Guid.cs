
//TODO: this is a very basic implementation of Guid
// For the generation of NewGuid(), we use System.Random()
// No parsing currently implemented


using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace SharpKit.JavaScript.Private
{
  [JsType(Name = "System.Guid", Filename = "~/Internal/Core.js")]
  //[Remotable]
  internal struct JSImplGuid
  //public struct JSImplGuid : IComparable, IFormattable, IComparable<JSImplGuid>, IEquatable<JSImplGuid>
  {
    //
    // Static Fields
    //
    //private static object _rngAccess = new object();

    //public static readonly JSImplGuid Empty = new JSImplGuid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
    public static readonly JSImplGuid Empty = new JSImplGuid();

    //private static RandomNumberGenerator _fastRng;

    //private static RandomNumberGenerator _rng;

    //
    // Fields
    //
    private byte _i;

    private byte _h;

    private byte _k;

    private byte _j;

    private byte _g;

    private short _c;

    private short _b;

    private int _a;

    private byte _f;

    private byte _e;

    private byte _d;

    //
    // Constructors
    //

    private static Random _random = new Random();

    public static JSImplGuid NewGuid()
    {
      byte[] array = new byte[16];
      for (int i = 0; i < 16; i++)
      {
        array[i] = (byte) _random.Next(256);
      }
      JSImplGuid result = new JSImplGuid(array);
      result._d = (byte)((result._d & 63) | 128);
      result._c = (short)(((long)result._c & 4095L) | 16384L);
      return result;
    }

    public JSImplGuid(byte[] b)
    {
      this._a = b[0] | (b[1] << 8) | (b[2] << 16) | (b[3] << 24);
      this._b = (short)(b[4] | (b[5] << 8));
      this._c = (short)(b[6] | (b[7] << 8));
      this._d = b[8];
      this._e = b[9];
      this._f = b[10];
      this._g = b[11];
      this._h = b[12];
      this._i = b[13];
      this._j = b[14];
      this._k = b[15];
    }


    //public static JSImplGuid NewGuid()
    //{
    //  JSImplGuid guid = new JSImplGuid();
    //  char[] s = new char[36];
    //  string hexDigits = "0123456789abcdef";
    //  for (var i = 0; i < 36; i++)
    //  {
    //    //int k = (int) Math.Floor(_random.Next(16));
    //    int k = _random.Next(16);
    //    s[i] = hexDigits[k];
    //  }
    //  s[14] = '4';  // bits 12-15 of the time_hi_and_version field to 0010
    //  s[19] = hexDigits[((s[19] & 0x3) | 0x8)];  // bits 6-7 of the clock_seq_hi_and_reserved to 01
    //  s[8] = s[13] = s[18] = s[23] = '-';

    //  string uuid = new string(s);
    //  return uuid;
    //}

#if false
    public JSImplGuid(string g)
    {
      JSImplGuid.CheckNull(g);
      g = g.Trim();
      JSImplGuid.GuidParser guidParser = new JSImplGuid.GuidParser(g);
      JSImplGuid guid;
      if (!guidParser.Parse(out guid))
      {
        throw JSImplGuid.CreateFormatException(g);
      }
    @@tb the following line produces invalid js code (FireFox is reports it while loading the jsclr.js file)
      this = guid;
    }

    public JSImplGuid(int a, short b, short c, byte[] d)
    {
      JSImplGuid.CheckArray(d, 8);
      this._a = a;
      this._b = b;
      this._c = c;
      this._d = d[0];
      this._e = d[1];
      this._f = d[2];
      this._g = d[3];
      this._h = d[4];
      this._i = d[5];
      this._j = d[6];
      this._k = d[7];
    }

    public JSImplGuid(byte[] b)
    {
      JSImplGuid.CheckArray(b, 16);
      this._a = BitConverterLE.ToInt32(b, 0);
      this._b = BitConverterLE.ToInt16(b, 4);
      this._c = BitConverterLE.ToInt16(b, 6);
      this._d = b[8];
      this._e = b[9];
      this._f = b[10];
      this._g = b[11];
      this._h = b[12];
      this._i = b[13];
      this._j = b[14];
      this._k = b[15];
    }

#endif


    public JSImplGuid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
      : this((int)a, (short)b, (short)c, d, e, f, g, h, i, j, k)
    {
    }

    public JSImplGuid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
    {
      this._a = a;
      this._b = b;
      this._c = c;
      this._d = d;
      this._e = e;
      this._f = f;
      this._g = g;
      this._h = h;
      this._i = i;
      this._j = j;
      this._k = k;
    }


    //
    // Static Methods
    //
    private static void AppendByte(StringBuilder builder, byte value)
    {
      builder.Append(JSImplGuid.ToHex(value >> 4 & 15));
      builder.Append(JSImplGuid.ToHex((int)(value & 15)));
    }

    private static void AppendInt(StringBuilder builder, int value)
    {
      builder.Append(JSImplGuid.ToHex(value >> 28 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 24 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 20 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 16 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 12 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 8 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 4 & 15));
      builder.Append(JSImplGuid.ToHex(value & 15));
    }

    private static void AppendShort(StringBuilder builder, short value)
    {
      builder.Append(JSImplGuid.ToHex(value >> 12 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 8 & 15));
      builder.Append(JSImplGuid.ToHex(value >> 4 & 15));
      builder.Append(JSImplGuid.ToHex((int)(value & 15)));
    }

    private static void CheckArray(byte[] o, int l)
    {
      JSImplGuid.CheckNull(o);
      JSImplGuid.CheckLength(o, l);
    }

    private static void CheckLength(byte[] o, int l)
    {
      if (o.Length != l)
      {
        throw new ArgumentException(string.Format("Array should be exactly {0} bytes long.", l));
      }
    }

    private static void CheckNull(object o)
    {
      if (o == null)
      {
        throw new ArgumentNullException("Value cannot be null.");
      }
    }

    private static int Compare(int x, int y)
    {
      return (x >= y) ? 1 : -1;
    }

    private static Exception CreateFormatException(string s)
    {
      return new FormatException(string.Format("Invalid Guid format: {0}", s));
    }

#if false
    internal static byte[] FastNewGuidArray()
    {
      byte[] array = new byte[16];
      object rngAccess = JSImplGuid._rngAccess;
      lock (rngAccess)
      {
        if (JSImplGuid._rng != null)
        {
          JSImplGuid._fastRng = JSImplGuid._rng;
        }
        if (JSImplGuid._fastRng == null)
        {
          JSImplGuid._fastRng = new RNGCryptoServiceProvider();
        }
        JSImplGuid._fastRng.GetBytes(array);
      }
      array[8] = ((array[8] & 63) | 128);
      array[7] = ((array[7] & 15) | 64);
      return array;
    }

    public static JSImplGuid NewGuid()
    {
      byte[] array = new byte[16];
      object rngAccess = JSImplGuid._rngAccess;
      lock (rngAccess)
      {
        if (JSImplGuid._rng == null)
        {
          JSImplGuid._rng = RandomNumberGenerator.Create();
        }
        JSImplGuid._rng.GetBytes(array);
      }
      JSImplGuid result = new JSImplGuid(array);
      result._d = ((result._d & 63) | 128);
      result._c = (short)(((long)result._c & 4095L) | 16384L);
      return result;
    }

    public static JSImplGuid Parse(string input)
    {
      JSImplGuid result;
      if (!JSImplGuid.TryParse(input, out result))
      {
        throw JSImplGuid.CreateFormatException(input);
      }
      return result;
    }

    public static JSImplGuid ParseExact(string input, string format)
    {
      JSImplGuid result;
      if (!JSImplGuid.TryParseExact(input, format, out result))
      {
        throw JSImplGuid.CreateFormatException(input);
      }
      return result;
    }

    private static JSImplGuid.Format ParseFormat(string format)
    {
      if (format.Length != 1)
      {
        throw new ArgumentException("Wrong format");
      }
      char c = format[0];
      switch (c)
      {
        case 'B':
          return JSImplGuid.Format.B;
        case 'C':
        IL_34:
          switch (c)
          {
            case 'N':
              return JSImplGuid.Format.N;
            case 'O':
            IL_49:
              if (c != 'X')
              {
                throw new ArgumentException("Wrong format");
              }
              return JSImplGuid.Format.X;
            case 'P':
              return JSImplGuid.Format.P;
          }
          goto IL_49;
        case 'D':
          return JSImplGuid.Format.D;
      }
      goto IL_34;
    }
#endif

  	private static string _hexChars = "0123456789abcdef";

	private static string ToHex(int b)
	{
		return _hexChars.Substring(b, 1);
	}

	//private static char ToHex(int b)
	//{
	//    return (char)((b >= 10) ? (97 + b - 10) : (48 + b));
	//}

#if false
    public static bool TryParse(string input, out JSImplGuid result)
    {
      if (input == null)
      {
        throw new ArgumentNullException("input");
      }
      JSImplGuid.GuidParser guidParser = new JSImplGuid.GuidParser(input);
      return guidParser.Parse(out result);
    }

    public static bool TryParseExact(string input, string format, out JSImplGuid result)
    {
      if (input == null)
      {
        throw new ArgumentNullException("input");
      }
      if (format == null)
      {
        throw new ArgumentNullException("format");
      }
      JSImplGuid.GuidParser guidParser = new JSImplGuid.GuidParser(input);
      return guidParser.Parse(JSImplGuid.ParseFormat(format), out result);
    }
#endif

    //
    // Methods
    //
    private string BaseToString(bool h, bool p, bool b)
    {
      StringBuilder stringBuilder = new StringBuilder(40);
      if (p)
      {
        stringBuilder.Append('(');
      }
      else
      {
        if (b)
        {
          stringBuilder.Append('{');
        }
      }
      JSImplGuid.AppendInt(stringBuilder, this._a);
      if (h)
      {
        stringBuilder.Append('-');
      }
      JSImplGuid.AppendShort(stringBuilder, this._b);
      if (h)
      {
        stringBuilder.Append('-');
      }
      JSImplGuid.AppendShort(stringBuilder, this._c);
      if (h)
      {
        stringBuilder.Append('-');
      }
      JSImplGuid.AppendByte(stringBuilder, this._d);
      JSImplGuid.AppendByte(stringBuilder, this._e);
      if (h)
      {
        stringBuilder.Append('-');
      }
      JSImplGuid.AppendByte(stringBuilder, this._f);
      JSImplGuid.AppendByte(stringBuilder, this._g);
      JSImplGuid.AppendByte(stringBuilder, this._h);
      JSImplGuid.AppendByte(stringBuilder, this._i);
      JSImplGuid.AppendByte(stringBuilder, this._j);
      JSImplGuid.AppendByte(stringBuilder, this._k);
      if (p)
      {
        stringBuilder.Append(')');
      }
      else
      {
        if (b)
        {
          stringBuilder.Append('}');
        }
      }
      return stringBuilder.ToString();
    }

    public int CompareTo(JSImplGuid value)
    {
      if (this._a != value._a)
      {
        return JSImplGuid.Compare(this._a, value._a);
      }
      if (this._b != value._b)
      {
        return JSImplGuid.Compare((int)this._b, (int)value._b);
      }
      if (this._c != value._c)
      {
        return JSImplGuid.Compare((int)this._c, (int)value._c);
      }
      if (this._d != value._d)
      {
        return JSImplGuid.Compare((int)this._d, (int)value._d);
      }
      if (this._e != value._e)
      {
        return JSImplGuid.Compare((int)this._e, (int)value._e);
      }
      if (this._f != value._f)
      {
        return JSImplGuid.Compare((int)this._f, (int)value._f);
      }
      if (this._g != value._g)
      {
        return JSImplGuid.Compare((int)this._g, (int)value._g);
      }
      if (this._h != value._h)
      {
        return JSImplGuid.Compare((int)this._h, (int)value._h);
      }
      if (this._i != value._i)
      {
        return JSImplGuid.Compare((int)this._i, (int)value._i);
      }
      if (this._j != value._j)
      {
        return JSImplGuid.Compare((int)this._j, (int)value._j);
      }
      if (this._k != value._k)
      {
        return JSImplGuid.Compare((int)this._k, (int)value._k);
      }
      return 0;
    }

    public int CompareTo(object value)
    {
      if (value == null)
      {
        return 1;
      }
      if (!(value is JSImplGuid))
      {
        throw new ArgumentException("value", "Argument of System.Guid.CompareTo should be a Guid.");
      }
      return this.CompareTo((JSImplGuid)value);
    }

    public override bool Equals(object o)
    {
      return o is JSImplGuid && this.CompareTo((JSImplGuid)o) == 0;
    }

    public bool Equals(JSImplGuid g)
    {
      return this.CompareTo(g) == 0;
    }

    public override int GetHashCode()
    {
      int num = this._a;
      num ^= (int)this._b << 16 | this._c;
      num ^= (int)this._d << 24;
      num ^= (int)this._e << 16;
      num ^= (int)this._f << 8;
      num ^= (int)this._g;
      num ^= (int)this._h << 24;
      num ^= (int)this._i << 16;
      num ^= (int)this._j << 8;
      return num ^ (int)this._k;
    }

#if false
    public byte[] ToByteArray()
    {
      byte[] array = new byte[16];
      int num = 0;
      byte[] bytes = BitConverterLE.GetBytes(this._a);
      for (int i = 0; i < 4; i++)
      {
        array[num++] = bytes[i];
      }
      bytes = BitConverterLE.GetBytes(this._b);
      for (int i = 0; i < 2; i++)
      {
        array[num++] = bytes[i];
      }
      bytes = BitConverterLE.GetBytes(this._c);
      for (int i = 0; i < 2; i++)
      {
        array[num++] = bytes[i];
      }
      array[8] = this._d;
      array[9] = this._e;
      array[10] = this._f;
      array[11] = this._g;
      array[12] = this._h;
      array[13] = this._i;
      array[14] = this._j;
      array[15] = this._k;
      return array;
    }
#endif

    public override string ToString()
    {
      return this.BaseToString(true, false, false);
    }

    public string ToString(string format)
    {
      bool h = true;
      bool p = false;
      bool b = false;
      if (format != null)
      {
        string a = format.ToLowerInvariant();
        if (a == "b")
        {
          b = true;
        }
        else
        {
          if (a == "p")
          {
            p = true;
          }
          else
          {
            if (a == "n")
            {
              h = false;
            }
            else
            {
              if (a != "d" && a != string.Empty)
              {
                throw new FormatException("Argument to Guid.ToString(string format) should be \"b\", \"B\", \"d\", \"D\", \"n\", \"N\", \"p\" or \"P\"");
              }
            }
          }
        }
      }
      return this.BaseToString(h, p, b);
    }

    public string ToString(string format, IFormatProvider provider)
    {
      return this.ToString(format);
    }

    //
    // Operators
    //
    public static bool operator ==(JSImplGuid a, JSImplGuid b)
    {
      return a.Equals(b);
    }

    public static bool operator !=(JSImplGuid a, JSImplGuid b)
    {
      return !a.Equals(b);
    }

    //
    // Nested Types
    //
    private enum Format
    {
      N,
      D,
      B,
      P,
      X
    }

#if false
    private class GuidParser
    {
      private string _src;
      private int _length;
      private int _cur;
      private bool Eof
      {
        get
        {
          return this._cur >= this._length;
        }
      }
      public GuidParser(string src)
      {
        this._src = src;
        this.Reset();
      }
      private void Reset()
      {
        this._cur = 0;
        this._length = this._src.Length;
      }
      private static bool HasHyphen(JSImplGuid.Format format)
      {
        switch (format)
        {
          case JSImplGuid.Format.D:
          case JSImplGuid.Format.B:
          case JSImplGuid.Format.P:
            return true;
          default:
            return false;
        }
      }
      private bool TryParseNDBP(JSImplGuid.Format format, out JSImplGuid guid)
      {
        guid = default(JSImplGuid);
        if (format == JSImplGuid.Format.B && !this.ParseChar('{'))
        {
          return false;
        }
        if (format == JSImplGuid.Format.P && !this.ParseChar('('))
        {
          return false;
        }
        ulong num;
        if (!this.ParseHex(8, true, out num))
        {
          return false;
        }
        bool flag = JSImplGuid.GuidParser.HasHyphen(format);
        if (flag && !this.ParseChar('-'))
        {
          return false;
        }
        ulong num2;
        if (!this.ParseHex(4, true, out num2))
        {
          return false;
        }
        if (flag && !this.ParseChar('-'))
        {
          return false;
        }
        ulong num3;
        if (!this.ParseHex(4, true, out num3))
        {
          return false;
        }
        if (flag && !this.ParseChar('-'))
        {
          return false;
        }
        byte[] array = new byte[8];
        for (int i = 0; i < array.Length; i++)
        {
          ulong num4;
          if (!this.ParseHex(2, true, out num4))
          {
            return false;
          }
          if (i == 1 && flag && !this.ParseChar('-'))
          {
            return false;
          }
          array[i] = (byte)num4;
        }
        if (format == JSImplGuid.Format.B && !this.ParseChar('}'))
        {
          return false;
        }
        if (format == JSImplGuid.Format.P && !this.ParseChar(')'))
        {
          return false;
        }
        if (!this.Eof)
        {
          return false;
        }
        guid = new JSImplGuid((int)num, (short)num2, (short)num3, array);
        return true;
      }
      private bool TryParseX(out JSImplGuid guid)
      {
        guid = default(JSImplGuid);
        ulong num;
        ulong num2;
        ulong num3;
        if (!this.ParseChar('{') || !this.ParseHexPrefix() || !this.ParseHex(8, false, out num) || !this.ParseChar(',') || !this.ParseHexPrefix() || !this.ParseHex(4, false, out num2) || !this.ParseChar(',') || !this.ParseHexPrefix() || !this.ParseHex(4, false, out num3) || !this.ParseChar(',') || !this.ParseChar('{'))
        {
          return false;
        }
        byte[] array = new byte[8];
        for (int i = 0; i < array.Length; i++)
        {
          ulong num4;
          if (!this.ParseHexPrefix() || !this.ParseHex(2, false, out num4))
          {
            return false;
          }
          array[i] = (byte)num4;
          if (i != 7 && !this.ParseChar(','))
          {
            return false;
          }
        }
        if (!this.ParseChar('}') || !this.ParseChar('}'))
        {
          return false;
        }
        if (!this.Eof)
        {
          return false;
        }
        guid = new JSImplGuid((int)num, (short)num2, (short)num3, array);
        return true;
      }
      private bool ParseHexPrefix()
      {
        return this.ParseChar('0') && this.ParseChar('x');
      }
      private bool ParseChar(char c)
      {
        if (!this.Eof && this._src[this._cur] == c)
        {
          this._cur++;
          return true;
        }
        return false;
      }
      private bool ParseHex(int length, bool strict, out ulong res)
      {
        res = 0uL;
        for (int i = 0; i < length; i++)
        {
          if (this.Eof)
          {
            return !strict || i + 1 == length;
          }
          char c = char.ToLowerInvariant(this._src[this._cur]);
          if (char.IsDigit(c))
          {
            res = res * 16uL + (ulong)c - 48uL;
            this._cur++;
          }
          else
          {
            if (c < 'a' || c > 'f')
            {
              return !strict || (!strict || i + 1 == length);
            }
            res = res * 16uL + (ulong)c - 97uL + 10uL;
            this._cur++;
          }
        }
        return true;
      }
      public bool Parse(JSImplGuid.Format format, out JSImplGuid guid)
      {
        if (format == JSImplGuid.Format.X)
        {
          return this.TryParseX(out guid);
        }
        return this.TryParseNDBP(format, out guid);
      }
      public bool Parse(out JSImplGuid guid)
      {
        if (this.TryParseNDBP(JSImplGuid.Format.N, out guid))
        {
          return true;
        }
        this.Reset();
        if (this.TryParseNDBP(JSImplGuid.Format.D, out guid))
        {
          return true;
        }
        this.Reset();
        if (this.TryParseNDBP(JSImplGuid.Format.B, out guid))
        {
          return true;
        }
        this.Reset();
        if (this.TryParseNDBP(JSImplGuid.Format.P, out guid))
        {
          return true;
        }
        this.Reset();
        return this.TryParseX(out guid);
      }
    }
#endif
  }

}
