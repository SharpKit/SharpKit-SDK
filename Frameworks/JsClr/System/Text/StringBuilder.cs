using System;
using System.Collections.Generic;

using System.Text;


namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Text.StringBuilder", Filename = "~/res/System.Text.js")]
    class JsImplStringBuilder
    {
        JsExtendedArray array;
        int length;

        public JsImplStringBuilder()
        {
            this.array = new string[0].As<JsExtendedArray>();
            this.length = 0;

        }

        public JsImplStringBuilder(int len)
        {
            this.array = new string[0].As<JsExtendedArray>();
            this.length = 0;

        }

        public JsImplStringBuilder(string s)
        {
            this.array = new string[] { s }.As<JsExtendedArray>();
            this.length = s == null ? 0 : s.Length;
        }


        public void Append(char s)
        {
            this.array.push(s);
            this.length += 1;
        }

        public void Append(string s)
        {
            this.array.push(s);
            this.length += s.Length;
        }

        public void AppendFormat(string s, object arg0)
        {
            string ss = String.Format(s, arg0);
            this.array.push(ss);
            this.length += ss.Length;
        }

        public void AppendFormat(string s, object arg0, object arg1)
        {
            string ss = String.Format(s, arg0, arg1);
            this.array.push(ss);
            this.length += ss.Length;
        }

        public void AppendFormat(string s, object arg0, object arg1, object arg2)
        {
            string ss = String.Format(s, arg0, arg1, arg2);
            this.array.push(ss);
            this.length += ss.Length;
        }

        public void Append(object obj)
        {
            if (obj != null)
            {
                var s = obj.ToString();
                this.array.push(s);
                this.length += s.Length;
            }
        }

        /// <summary>
        /// Inserts the string representation of a specified Unicode character into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, bool value)
        {
            if (index < 0 || index > this.array.length)
                throw new IndexOutOfRangeException();

            this.array.insert(index, value.ToString());
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a specified 8-bit unsigned integer into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, byte value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a specified Unicode character into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, char value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a specified array of Unicode characters into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, char[] value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }


        /// <summary>
        /// Inserts the string representation of a decimal number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, decimal value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a double number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, double value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a short number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, short value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of an int number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, int value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a long number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, long value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of an object into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, object value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a signed byte number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, sbyte value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a float number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, float value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of a string into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, string value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of an unsigned short number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, ushort value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of an unsigned int number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, uint value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts the string representation of an unsigned long number into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, ulong value)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts one or more copies of a specified string into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <param name="count">The number of times to insert <para>value</para>.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, string value, int count)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            for (int i = 0; i < count; i++)
                this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Inserts one or more copies of a specified character array into this instance at the specified character position.
        /// </summary>
        /// <param name="index">The position in this instance where insertion begins.</param>
        /// <param name="value">The value to insert.</param>
        /// <param name="count">The number of times to insert <para>value</para>.</param>
        /// <returns>A reference to this instance after the insert operation has completed.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"><para>index</para> is less than zero or greater than the length of this instance.</exception>
        public JsImplStringBuilder Insert(int index, char[] value, int count)
        {
            if (index < 0 || index > this.array.length)
                throw new ArgumentOutOfRangeException();

            for (int i = 0; i < count; i++)
                this.array.insert(index, value);
            return this;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return this.array.join("");
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>The length.</value>
        /// <exception cref="System.Exception">Not Implemented</exception>
        public int Length
        {
            get
            {
                //return this.array.length;
                return length;
            }
            set
            {
                if (value == length) return;
                if (value > length)
                    Append(new JsArray(value + 1).join("\x00"));
                else
                {
                    Remove(value, length - value);
                }

                //---

                //if (value < 0)
                //    throw new ArgumentOutOfRangeException();

                //// Setting the length in Javascript will truncate the array.
                //if (value < this.array.length)
                //    this.array.length = value;
                //else
                //{
                //    for(int i = this.array.length; i<length; i++)
                //        this.array.push('\x00');
                //}
            }
        }
        [JsMethod(NativeOverloads = true)]
        public JsImplStringBuilder Remove(int start, int count)
        {
            var s = this.array.join("");
            s = s.As<string>().Remove(start, count);
            this.array = new object[] { s }.As<JsExtendedArray>();
            this.length = s.length;
            return this;
        }
    }


    [JsType(Name = "System.StringComparison", Filename = "~/Internal/Core.js")]
    public enum JsImplStringComparison
    {
        CurrentCulture,
        CurrentCultureIgnoreCase,
        InvariantCulture,
        InvariantCultureIgnoreCase,
        Ordinal,
        OrdinalIgnoreCase
    }






}
