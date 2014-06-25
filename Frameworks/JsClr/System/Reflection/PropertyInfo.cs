using System;
using System.Collections.Generic;

using System.Text;
using SharpKit.JavaScript;
using System.Reflection;
using System.Globalization;
[assembly:JsType(JsMode.Clr, TargetType=typeof(System.Reflection.PropertyInfo), NativeOperatorOverloads=true)] //To avoid op_equality for PropertyInfo

namespace SharpKit.JavaScript.Private
{

	[JsType(Name = "System.Reflection.PropertyInfo", Filename = "~/res/System.Reflection.js")]
	internal class JsImplPropertyInfo : JsImplMemberInfo
	{
        [JsMethod(Export=false)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        [JsMethod(Export = false)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        // System.Reflection.PropertyInfo
        /// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are equal.</summary>
        /// <returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        public static bool operator ==(JsImplPropertyInfo left, JsImplPropertyInfo right)
        {
            return JsContext.JsCode("left==right").As<bool>();
        }

        // System.Reflection.PropertyInfo
        /// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are not equal.</summary>
        /// <returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns>
        /// <param name="left">The first object to compare.</param>
        /// <param name="right">The second object to compare.</param>
        public static bool operator !=(JsImplPropertyInfo left, JsImplPropertyInfo right)
        {
            return JsContext.JsCode("left!=right").As<bool>();
        }

		internal JsImplType _PropertyType;



		protected override JsImplMemberInfo GetBaseMember()
		{
			return null;
		}
		internal bool _IsStatic;
		internal JsFunction _Getter;
		internal JsFunction _Setter;

		public object GetValue(object obj, object[] indexes)
		{
			if (_Getter == null)
				throw new Exception("Property " + _Name + " doesn't have a getter");
			var value = _Getter.apply(obj, indexes ?? new JsArray().As<object[]>());
			return value;
		}

        public object GetValue(object obj)
        {
            return this.GetValue(obj, null);
        }

        // System.Reflection.PropertyInfo
        /// <summary>When overridden in a derived class, returns the value of a property having the specified binding, index, and <see cref="T:System.Globalization.CultureInfo" />.</summary>
        /// <returns>The property value for <paramref name="obj" />.</returns>
        /// <param name="obj">The object whose property value will be returned. </param>
        /// <param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags : InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member is to be invoked, the Static flag of BindingFlags must be set. </param>
        /// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
        /// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
        /// <param name="culture">The CultureInfo object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param>
        /// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's get accessor is not found. </exception>
        /// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is null. </exception>
        /// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
        /// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class. </exception>
        /// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
        public object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            return GetValue(obj, index);
        }


		public void SetValue(object obj, object value, object[] indexes)
		{
			if (_Setter == null)
				throw new Exception("Property " + _Name + " doesn't have a setter");
			if (indexes == null || indexes.Length == 0)
			{
				_Setter.call(obj, value);
			}
			else
			{
				var arr = new JsArray(indexes);
				arr.push(value);
				_Setter.apply(obj, indexes ?? new JsArray().As<object[]>());
			}
		}

        public void SetValue(object obj, object value)
        {
            this.SetValue(obj, value, null);
        }

        // System.Reflection.PropertyInfo
        /// <summary>When overridden in a derived class, sets the property value for the given object to the given value.</summary>
        /// <param name="obj">The object whose property value will be set. </param>
        /// <param name="value">The new value for this property. </param>
        /// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member is to be invoked, the Static flag of BindingFlags must be set. </param>
        /// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
        /// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
        /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param>
        /// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's set accessor is not found. </exception>
        /// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is null. </exception>
        /// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
        /// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class. </exception>
        /// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
        public void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            SetValue(obj, value, index);
        }


		public override string Name
		{
			get { return _Name; }
		}

		public JsImplType PropertyType
		{
			get
			{
				return _PropertyType;
			}
		}
	}
}
