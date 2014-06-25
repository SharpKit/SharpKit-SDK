using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SharpKit.JavaScript.Private
{

    [JsType(Name = "System.Char", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplChar
    {
        [JsMethod(Code = @"return /\s/.test(c);")]
        public static bool IsWhiteSpace(char c)
        {
            throw new NotImplementedException();
        }

        public static bool IsUpper(char c)
        {
            //return true;
            return c.As<JsString>().toUpperCase() == c.As<string>();
            //c.IsU str.charAt(index).As<char>()
        }

        [JsMethod(Name = "IsDigit$$Char", Code = @"return /[0-9]/.test(s);")]
        public static bool IsDigit(char s)
        {
            throw new NotImplementedException();
        }

    }

    [JsType(Name = "System.CharEnumerator", Filename = "~/Internal/Core.js")]
    internal sealed class JsImplCharEnumerator : IEnumerator<char>, IEnumerator
    {
        // Fields
        private char currentElement;
        private int index;
        private JsString str;

        // Methods
        internal JsImplCharEnumerator(JsString str2)
        {
            str = str2;
            index = -1;
        }

        public bool MoveNext()
        {
            if (index < (str.length - 1))
            {
                index++;
                currentElement = str.charAt(index).As<char>();
                return true;
            }
            index = str.length;
            return false;
        }

        public void Reset()
        {
            currentElement = '\0';
            index = -1;
        }

        void IDisposable.Dispose()
        {
        }

        // Properties
        public char Current
        {
            get
            {
                if (index == -1)
                {
                    throw new InvalidOperationException("Enum Not Started");
                }
                if (index >= str.length)
                {
                    throw new InvalidOperationException("Enum Ended");
                }
                return currentElement;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (index == -1)
                {
                    throw new InvalidOperationException("Enum Not Started");
                }
                if (index >= str.length)
                {
                    throw new InvalidOperationException("Enum Ended");
                }
                return currentElement;
            }
        }
    }

}
