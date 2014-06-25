using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Nullable$1", Filename = "~/Internal/Core.js")]
	//[Serializable, StructLayout(LayoutKind.Sequential), TypeDependency("System.Collections.Generic.NullableComparer`1"), TypeDependency("System.Collections.Generic.NullableEqualityComparer`1")]
	internal class Nullable<T> where T : struct
	{
		private bool hasValue;
		internal T value;
		public Nullable(T value)
		{
			this.value = value;
			this.hasValue = true;
		}

		public bool HasValue
		{
			get
			{
				return this.hasValue;
			}
		}
		public T Value
		{
			get
			{
				if (!this.HasValue)
				{
					throw new InvalidOperationException("InvalidOperation_NoValue");
				}
				return this.value;
			}
		}
		public T GetValueOrDefault()
		{
			return this.value;
		}

		public T GetValueOrDefault(T defaultValue)
		{
			if (!this.HasValue)
			{
				return defaultValue;
			}
			return this.value;
		}

		public override bool Equals(object other)
		{
			if (!this.HasValue)
			{
				return (other == null);
			}
			if (other == null)
			{
				return false;
			}
			return this.value.Equals(other);
		}

		public override int GetHashCode()
		{
			if (!this.HasValue)
			{
				return 0;
			}
			return this.value.GetHashCode();
		}

		public override string ToString()
		{
			if (!this.HasValue)
			{
				return "";
			}
			return this.value.ToString();
		}

		//public static implicit operator T?(T value)
		//{
		//  return new T?(value);
		//}

		//public static explicit operator T(T? value)
		//{
		//  return value.Value;
		//}
	}


	////[ComVisible(true)]
	//[JsType(Name = "System.Nullable")]
	//[RunAtClient]
	//public static class Nullable
	//{
	//  // Methods
	//  //[ComVisible(true)]
	//  public static int Compare<T>(T? n1, T? n2) where T : struct
	//  {
	//    if (n1.HasValue)
	//    {
	//      if (n2.HasValue)
	//      {
	//        return Comparer<T>.Default.Compare(n1.value, n2.value);
	//      }
	//      return 1;
	//    }
	//    if (n2.HasValue)
	//    {
	//      return -1;
	//    }
	//    return 0;
	//  }

	//  //[ComVisible(true)]
	//  public static bool Equals<T>(T? n1, T? n2) where T : struct
	//  {
	//    if (n1.HasValue)
	//    {
	//      return (n2.HasValue && EqualityComparer<T>.Default.Equals(n1.value, n2.value));
	//    }
	//    if (n2.HasValue)
	//    {
	//      return false;
	//    }
	//    return true;
	//  }

	//  public static Type GetUnderlyingType(Type nullableType)
	//  {
	//    if (nullableType == null)
	//    {
	//      throw new ArgumentNullException("nullableType");
	//    }
	//    Type type = null;
	//    if ((nullableType.IsGenericType && !nullableType.IsGenericTypeDefinition) && (nullableType.GetGenericTypeDefinition() == typeof(Nullable<>)))
	//    {
	//      type = nullableType.GetGenericArguments()[0];
	//    }
	//    return type;
	//  }
	//}





}
