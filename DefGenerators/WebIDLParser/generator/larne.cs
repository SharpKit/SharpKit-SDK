
/*******************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace WebIDLParser
{
    public class TStringList : List<string>
    {
    }

    public static class LarneFunctions
    {

        //------------------------------------------------------------------------------------------------------------------
        public static string StringLoadFromFile(string File, bool IgnoreIfFileNotExists = false)
        {
            return StringLoadFromFile(File, DefaultEncoding, IgnoreIfFileNotExists);
        }

        //------------------------------------------------------------------------------------------------------------------
        public static string StringLoadFromFile(string File, System.Text.Encoding Enc, bool IgnoreIfFileNotExists = false)
        {
            if (File == "" || !(System.IO.File.Exists(File)))
            {
                if (File != "" && System.IO.File.Exists(File + ".bak"))
                {
                    File = File + ".bak";
                }
                else
                {
                    if (IgnoreIfFileNotExists)
                    {
                        return "";
                    }
                    else
                    {
                        throw new Exception("Datei " + File + " existiert nicht!");
                    }
                }
            }
            System.IO.FileStream fs = System.IO.File.Open(File, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
            try
            {
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, (int)fs.Length);
                fs.Close();
                return BufferToString(ref buf, Enc);
            }
            finally
            {
                fs.Close();
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        public static void StringSaveToFile(string File, string Text)
        {
            StringSaveToFile(File, Text, DefaultEncoding);
        }

        //------------------------------------------------------------------------------------------------------------------
        public static void StringSaveToFile(string File, string Text, System.Text.Encoding Enc)
        {
            if (System.IO.File.Exists(File))
            {
                System.IO.File.Delete(File);
            }
            System.IO.FileStream fs = System.IO.File.Open(File, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            try
            {
                byte[] buf = StringToBuffer(ref Text, Enc);
                fs.Write(buf, 0, buf.Length);
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        public static byte[] StringToBuffer(ref string Str)
        {
            if (Str == null || Str == "")
            {
                return new byte[0];
            }
            else
            {
                return DefaultEncoding.GetBytes(Str);
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        public static byte[] StringToBuffer(ref string Str, System.Text.Encoding Encoding)
        {
            if (Str == null || Str == "")
            {
                return new byte[0];
            }
            else
            {
                return Encoding.GetBytes(Str);
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        private static System.Text.Encoding _DefaultEncoding = System.Text.Encoding.UTF8;
        public static System.Text.Encoding DefaultEncoding
        {
            get
            {
                return _DefaultEncoding;
            }
            set
            {
                _DefaultEncoding = value;
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        public static string BufferToString(ref byte[] Buffer)
        {
            return BufferToString(ref Buffer, DefaultEncoding);
        }

        //------------------------------------------------------------------------------------------------------------------
        public static string BufferToString(ref byte[] Buffer, System.Text.Encoding Encoding)
        {
            return Encoding.GetString(Buffer);
        }

    }
}