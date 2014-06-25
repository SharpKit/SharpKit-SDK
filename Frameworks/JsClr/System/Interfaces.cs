namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.IComparable", Filename = "~/Internal/Core.js")]
    public interface JsImplIComparable
    {
        int CompareTo(object obj);
    }

    [JsType(Name = "System.IComparable$1", Filename = "~/Internal/Core.js")]
    public interface JsImplIComparable<T>
    {
        int CompareTo(T other);
    }

    [JsType(Name = "System.IEquatable$1", Filename = "~/Internal/Core.js")]
    public interface JsImplIEquatable<T>
    {
        bool Equals(T other);
    }


    [JsType(Name = "System.IFormattable", Filename = "~/Internal/Core.js")]
    public interface JsImplIFormattable
    {
      string ToString(string format, System.IFormatProvider formatProvider);
    }

}
