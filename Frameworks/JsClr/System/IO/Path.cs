using System;
using System.Collections.Generic;

using System.Text;

using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Security.Cryptography;
using System.IO;

namespace SharpKit.JavaScript.Private
{
    [JsType(GlobalObject = true, Filename = "~/res/System.IO.js")]
    class IOGlobal
    {
        //TODO: HACK: see Issue #43
        [JsMethod(Code = @"AfterCompilation(function()
{
	System.IO.Path.ctor();
});
", GlobalCode = true)]
        static void Global()
        {

        }
    }

    [JsType(Name = "System.IO.Path", Filename = "~/res/System.IO.js")]
    internal static class JsImplPath
    {
        // Fields
        public static readonly char AltDirectorySeparatorChar = '/';
        public static readonly char DirectorySeparatorChar = '\\';
        private static readonly char[] InvalidFileNameChars = new char[] { 
        '"', '<', '>', '|', '\0', '\x0001', '\x0002', '\x0003', '\x0004', '\x0005', '\x0006', '\a', '\b', '\t', '\n', '\v', 
        '\f', '\r', '\x000e', '\x000f', '\x0010', '\x0011', '\x0012', '\x0013', '\x0014', '\x0015', '\x0016', '\x0017', '\x0018', '\x0019', '\x001a', '\x001b', 
        '\x001c', '\x001d', '\x001e', '\x001f', ':', '*', '?', '\\', '/'
     };
        [Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public static readonly char[] InvalidPathChars = new char[] { 
        '"', '<', '>', '|', '\0', '\x0001', '\x0002', '\x0003', '\x0004', '\x0005', '\x0006', '\a', '\b', '\t', '\n', '\v', 
        '\f', '\r', '\x000e', '\x000f', '\x0010', '\x0011', '\x0012', '\x0013', '\x0014', '\x0015', '\x0016', '\x0017', '\x0018', '\x0019', '\x001a', '\x001b', 
        '\x001c', '\x001d', '\x001e', '\x001f'
     };
        internal const int MAX_DIRECTORY_PATH = 0xf8;
        internal const int MAX_PATH = 260;
        internal static readonly int MaxPath = 260;
        public static readonly char PathSeparator = ';';
        private static readonly char[] RealInvalidPathChars = new char[] { 
        '"', '<', '>', '|', '\0', '\x0001', '\x0002', '\x0003', '\x0004', '\x0005', '\x0006', '\a', '\b', '\t', '\n', '\v', 
        '\f', '\r', '\x000e', '\x000f', '\x0010', '\x0011', '\x0012', '\x0013', '\x0014', '\x0015', '\x0016', '\x0017', '\x0018', '\x0019', '\x001a', '\x001b', 
        '\x001c', '\x001d', '\x001e', '\x001f'
     };
        public static readonly char VolumeSeparatorChar = ':';

        public static string ChangeExtension(string path, string extension)
        {
            if (path == null)
            {
                return null;
            }
            CheckInvalidPathChars(path);
            string str = path;
            int length = path.Length;
            while (--length >= 0)
            {
                char ch = path[length];
                if (ch == '.')
                {
                    str = path.Substring(0, length);
                    break;
                }
                if (((ch == DirectorySeparatorChar) || (ch == AltDirectorySeparatorChar)) || (ch == VolumeSeparatorChar))
                {
                    break;
                }
            }
            if ((extension == null) || (path.Length == 0))
            {
                return str;
            }
            if ((extension.Length == 0) || (extension[0] != '.'))
            {
                str = str + ".";
            }
            return (str + extension);
        }


        private static bool CharArrayStartsWithOrdinal(char[] array, int numChars, string compareTo, bool ignoreCase)
        {
            if (numChars < compareTo.Length)
            {
                return false;
            }
            if (ignoreCase)
            {
                string str = new string(array, 0, compareTo.Length);
                return compareTo.Equals(str, StringComparison.OrdinalIgnoreCase);
            }
            for (int i = 0; i < compareTo.Length; i++)
            {
                if (array[i] != compareTo[i])
                {
                    return false;
                }
            }
            return true;
        }

        internal static void CheckInvalidPathChars(string path)
        {
            for (int i = 0; i < path.Length; i++)
            {
                int num2 = path.As<JsString>().charCodeAt(i);
                if (((num2 == 0x22) || (num2 == 60)) || (((num2 == 0x3e) || (num2 == 0x7c)) || (num2 < 0x20)))
                {
                    throw new ArgumentException(JsImplEnvironment.GetResourceString("Argument_InvalidPathChars"));
                }
            }
        }

        internal static void CheckSearchPattern(string searchPattern)
        {
            int num;
            //if (((Environment.OSInfo & Environment.OSName.Win9x) != Environment.OSName.Invalid) && CanPathCircumventSecurityNative(searchPattern))
            //{
            //  throw new ArgumentException(Environment.GetResourceString("Arg_InvalidSearchPattern"));
            //}
            while ((num = searchPattern.IndexOf("..", StringComparison.Ordinal)) != -1)
            {
                if ((num + 2) == searchPattern.Length)
                {
                    throw new ArgumentException(JsImplEnvironment.GetResourceString("Arg_InvalidSearchPattern"));
                }
                if ((searchPattern[num + 2] == DirectorySeparatorChar) || (searchPattern[num + 2] == AltDirectorySeparatorChar))
                {
                    throw new ArgumentException(JsImplEnvironment.GetResourceString("Arg_InvalidSearchPattern"));
                }
                searchPattern = searchPattern.Substring(num + 2);
            }
        }

        public static string Combine(string path1, string path2)
        {
            if ((path1 == null) || (path2 == null))
            {
                throw new ArgumentNullException((path1 == null) ? "path1" : "path2");
            }
            CheckInvalidPathChars(path1);
            CheckInvalidPathChars(path2);
            if (path2.Length == 0)
            {
                return path1;
            }
            if (path1.Length == 0)
            {
                return path2;
            }
            if (IsPathRooted(path2))
            {
                return path2;
            }
            char ch = path1[path1.Length - 1];
            if (((ch != DirectorySeparatorChar) && (ch != AltDirectorySeparatorChar)) && (ch != VolumeSeparatorChar))
            {
                return (path1 + DirectorySeparatorChar + path2);
            }
            return (path1 + path2);
        }

        internal static string FixupPath(string path)
        {
            return NormalizePath(path, false);
        }

        public static string GetDirectoryName(string path)
        {
            if (path != null)
            {
                CheckInvalidPathChars(path);
                path = FixupPath(path);
                int rootLength = GetRootLength(path);
                if (path.Length > rootLength)
                {
                    int length = path.Length;
                    if (length == rootLength)
                    {
                        return null;
                    }
                    while (((length > rootLength) && (path[--length] != DirectorySeparatorChar)) && (path[length] != AltDirectorySeparatorChar))
                    {
                    }
                    return path.Substring(0, length);
                }
            }
            return null;
        }

        public static string GetExtension(string path)
        {
            if (path == null)
            {
                return null;
            }
            CheckInvalidPathChars(path);
            int length = path.Length;
            int startIndex = length;
            while (--startIndex >= 0)
            {
                char ch = path[startIndex];
                if (ch == '.')
                {
                    if (startIndex != (length - 1))
                    {
                        return path.Substring(startIndex, length - startIndex);
                    }
                    return string.Empty;
                }
                if (((ch == DirectorySeparatorChar) || (ch == AltDirectorySeparatorChar)) || (ch == VolumeSeparatorChar))
                {
                    break;
                }
            }
            return String.Empty;
        }

        public static string GetFileName(string path)
        {
            if (path != null)
            {
                CheckInvalidPathChars(path);
                int length = path.Length;
                int num2 = length;
                while (--num2 >= 0)
                {
                    char ch = path[num2];
                    if (((ch == DirectorySeparatorChar) || (ch == AltDirectorySeparatorChar)) || (ch == VolumeSeparatorChar))
                    {
                        return path.Substring(num2 + 1, (length - num2) - 1);
                    }
                }
            }
            return path;
        }

        public static string GetFileNameWithoutExtension(string path)
        {
            path = GetFileName(path);
            if (path == null)
            {
                return null;
            }
            int length = path.LastIndexOf('.');
            if (length == -1)
            {
                return path;
            }
            return path.Substring(0, length);
        }

        public static string GetFullPath(string path)
        {
            string fullPathInternal = GetFullPathInternal(path);
            //new FileIOPermission(FileIOPermissionAccess.PathDiscovery, new string[] { fullPathInternal }, false, false).Demand();
            return fullPathInternal;
        }

        internal static string GetFullPathInternal(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }
            return NormalizePath(path, true);
        }

        public static char[] GetInvalidFileNameChars()
        {
            return InvalidFileNameChars;
        }

        public static char[] GetInvalidPathChars()
        {
            return RealInvalidPathChars;
        }

        public static string GetPathRoot(string path)
        {
            if (path == null)
            {
                return null;
            }
            path = FixupPath(path);
            return path.Substring(0, GetRootLength(path));
        }

        public static string GetRandomFileName()
        {
            throw new NotSupportedException();
            //byte[] data = new byte[10];
            //new RNGCryptoServiceProvider().GetBytes(data);
            //char[] chArray = System.IO.IsolatedStorage.IsolatedStorage.ToBase32StringSuitableForDirName(data).ToCharArray();
            //chArray[8] = '.';
            //return new string(chArray, 0, 12);
        }

        internal static int GetRootLength(string path)
        {
            CheckInvalidPathChars(path);
            int num = 0;
            int length = path.Length;
            if ((length >= 1) && IsDirectorySeparator(path[0]))
            {
                num = 1;
                if ((length >= 2) && IsDirectorySeparator(path[1]))
                {
                    num = 2;
                    int num3 = 2;
                    while ((num < length) && (((path[num] != DirectorySeparatorChar) && (path[num] != AltDirectorySeparatorChar)) || (--num3 > 0)))
                    {
                        num++;
                    }
                }
                return num;
            }
            if ((length >= 2) && (path[1] == VolumeSeparatorChar))
            {
                num = 2;
                if ((length >= 3) && IsDirectorySeparator(path[2]))
                {
                    num++;
                }
            }
            return num;
        }

        public static string GetTempFileName()
        {
            throw new NotSupportedException();
            //string tempPath = GetTempPath();
            //new FileIOPermission(FileIOPermissionAccess.Write, tempPath).Demand();
            //StringBuilder tmpFileName = new StringBuilder(260);
            //if (Win32Native.GetTempFileName(tempPath, "tmp", 0, tmpFileName) == 0)
            //{
            //  __Error.WinIOError();
            //}
            //return tmpFileName.ToString();
        }

        public static string GetTempPath()
        {
            throw new NotSupportedException();

            //new EnvironmentPermission(PermissionState.Unrestricted).Demand();
            //StringBuilder buffer = new StringBuilder(260);
            //uint tempPath = Win32Native.GetTempPath(260, buffer);
            //string path = buffer.ToString();
            //if (tempPath == 0)
            //{
            //  __Error.WinIOError();
            //}
            //return GetFullPathInternal(path);
        }

        public static bool HasExtension(string path)
        {
            if (path != null)
            {
                CheckInvalidPathChars(path);
                int length = path.Length;
                while (--length >= 0)
                {
                    char ch = path[length];
                    if (ch == '.')
                    {
                        return (length != (path.Length - 1));
                    }
                    if (((ch == DirectorySeparatorChar) || (ch == AltDirectorySeparatorChar)) || (ch == VolumeSeparatorChar))
                    {
                        break;
                    }
                }
            }
            return false;
        }

        internal static string InternalCombine(string path1, string path2)
        {
            if ((path1 == null) || (path2 == null))
            {
                throw new ArgumentNullException((path1 == null) ? "path1" : "path2");
            }
            CheckInvalidPathChars(path1);
            CheckInvalidPathChars(path2);
            if (path2.Length == 0)
            {
                throw new ArgumentException(JsImplEnvironment.GetResourceString("Argument_PathEmpty"), "path2");
            }
            if (IsPathRooted(path2))
            {
                throw new ArgumentException(JsImplEnvironment.GetResourceString("Arg_Path2IsRooted"), "path2");
            }
            int length = path1.Length;
            if (length == 0)
            {
                return path2;
            }
            char ch = path1[length - 1];
            if (((ch != DirectorySeparatorChar) && (ch != AltDirectorySeparatorChar)) && (ch != VolumeSeparatorChar))
            {
                return (path1 + DirectorySeparatorChar + path2);
            }
            return (path1 + path2);
        }

        internal static bool IsDirectorySeparator(char c)
        {
            if (c != DirectorySeparatorChar)
            {
                return (c == AltDirectorySeparatorChar);
            }
            return true;
        }

        public static bool IsPathRooted(string path)
        {
            if (path != null)
            {
                CheckInvalidPathChars(path);
                int length = path.Length;
                if (((length >= 1) && ((path[0] == DirectorySeparatorChar) || (path[0] == AltDirectorySeparatorChar))) || ((length >= 2) && (path[1] == VolumeSeparatorChar)))
                {
                    return true;
                }
            }
            return false;
        }

        internal static string NormalizePath(string path, bool fullCheck)
        {
            return NormalizePathSlow(path, fullCheck);
            //if (Environment.nativeIsWin9x())
            //{
            //  return NormalizePathSlow(path, fullCheck);
            //}
            //return NormalizePathFast(path, fullCheck);
        }


        internal static string NormalizePathSlow(string path, bool fullCheck)
        {
            return path;
            //char[] chArray3;
            //int num14;
            //if (fullCheck)
            //{
            //  path = path.TrimEnd(new char[0]);
            //  CheckInvalidPathChars(path);
            //}
            //int num = 0;
            //char[] buffer = new char[MaxPath];
            //int index = 0;
            //char[] chArray2 = null;
            //uint num3 = 0;
            //uint num4 = 0;
            //bool flag = false;
            //uint num5 = 0;
            //int num6 = -1;
            //bool flag2 = false;
            //bool flag3 = true;
            //bool flag4 = false;
            //if ((path.Length > 0) && ((path[0] == DirectorySeparatorChar) || (path[0] == AltDirectorySeparatorChar)))
            //{
            //  buffer[index++] = '\\';
            //  num++;
            //  num6 = 0;
            //}
            //while (num < path.Length)
            //{
            //  char ch = path[num];
            //  if ((ch == DirectorySeparatorChar) || (ch == AltDirectorySeparatorChar))
            //  {
            //    if (num5 == 0)
            //    {
            //      if (num4 > 0)
            //      {
            //        int num7 = num6 + 1;
            //        if (path[num7] != '.')
            //        {
            //          throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //        }
            //        if (num4 >= 2)
            //        {
            //          if (flag2 && (num4 > 2))
            //          {
            //            throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //          }
            //          if (path[num7 + 1] == '.')
            //          {
            //            for (int i = num7 + 2; i < (num7 + num4); i++)
            //            {
            //              if (path[i] != '.')
            //              {
            //                throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //              }
            //            }
            //            num4 = 2;
            //          }
            //          else
            //          {
            //            if (num4 > 1)
            //            {
            //              throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //            }
            //            num4 = 1;
            //          }
            //        }
            //        if (index + num4 + 1L >= MaxPath)
            //        {
            //          throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
            //        }
            //        if (num4 == 2)
            //        {
            //          buffer[index++] = '.';
            //        }
            //        buffer[index++] = '.';
            //        flag = false;
            //      }
            //      if ((((num3 > 0) && flag3) && ((num + 1) < path.Length)) && ((path[num + 1] == DirectorySeparatorChar) || (path[num + 1] == AltDirectorySeparatorChar)))
            //      {
            //        buffer[index++] = DirectorySeparatorChar;
            //      }
            //    }
            //    num4 = 0;
            //    num3 = 0;
            //    if (!flag)
            //    {
            //      flag = true;
            //      if ((index + 1) >= MaxPath)
            //      {
            //        throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
            //      }
            //      buffer[index++] = DirectorySeparatorChar;
            //    }
            //    num5 = 0;
            //    num6 = num;
            //    flag2 = false;
            //    flag3 = false;
            //    if (flag4)
            //    {
            //      buffer[index] = '\0';
            //      TryExpandShortFileName(buffer, ref index, 260);
            //      flag4 = false;
            //    }
            //  }
            //  else
            //  {
            //    switch (ch)
            //    {
            //      case '.':
            //        num4++;
            //        goto Label_0343;

            //      case ' ':
            //        num3++;
            //        goto Label_0343;

            //      case '~':
            //        flag4 = true;
            //        break;
            //    }
            //    flag = false;
            //    if (flag3 && (ch == VolumeSeparatorChar))
            //    {
            //      char ch2 = (num > 0) ? path[num - 1] : ' ';
            //      if (((num4 != 0) || (num5 < 1)) || (ch2 == ' '))
            //      {
            //        throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //      }
            //      flag2 = true;
            //      if (num5 > 1)
            //      {
            //        uint num9 = 0;
            //        while ((num9 < index) && (buffer[num9] == ' '))
            //        {
            //          num9++;
            //        }
            //        if ((num5 - num9) == 1)
            //        {
            //          buffer[0] = ch2;
            //          index = 1;
            //        }
            //      }
            //      num5 = 0;
            //    }
            //    else
            //    {
            //      num5 += (1 + num4) + num3;
            //    }
            //    if ((num4 > 0) || (num3 > 0))
            //    {
            //      int count = (num6 >= 0) ? ((num - num6) - 1) : num;
            //      if (count > 0)
            //      {
            //        path.CopyTo(num6 + 1, buffer, index, count);
            //        index += count;
            //      }
            //      num4 = 0;
            //      num3 = 0;
            //    }
            //    if ((index + 1) >= MaxPath)
            //    {
            //      throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
            //    }
            //    buffer[index++] = ch;
            //    num6 = num;
            //  }
            //Label_0343:
            //  num++;
            //}
            //if ((num5 == 0) && (num4 > 0))
            //{
            //  int num11 = num6 + 1;
            //  if (path[num11] != '.')
            //  {
            //    throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //  }
            //  if (num4 >= 2)
            //  {
            //    if (flag2 && (num4 > 2))
            //    {
            //      throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //    }
            //    if (path[num11 + 1] == '.')
            //    {
            //      for (int j = num11 + 2; j < (num11 + num4); j++)
            //      {
            //        if (path[j] != '.')
            //        {
            //          throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //        }
            //      }
            //      num4 = 2;
            //    }
            //    else
            //    {
            //      if (num4 > 1)
            //      {
            //        throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //      }
            //      num4 = 1;
            //    }
            //  }
            //  if ((index + num4) >= MaxPath)
            //  {
            //    throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
            //  }
            //  if (num4 == 2)
            //  {
            //    buffer[index++] = '.';
            //  }
            //  buffer[index++] = '.';
            //}
            //if (index == 0)
            //{
            //  throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
            //}
            //buffer[index] = '\0';
            //if (fullCheck && (CharArrayStartsWithOrdinal(buffer, index, "http:", false) || CharArrayStartsWithOrdinal(buffer, index, "file:", false)))
            //{
            //  throw new ArgumentException(Environment.GetResourceString("Argument_PathUriFormatNotSupported"));
            //}
            //if (flag4)
            //{
            //  TryExpandShortFileName(buffer, ref index, MaxPath);
            //}
            //int numBufferChars = 1;
            //if (!fullCheck)
            //{
            //  chArray3 = buffer;
            //  num14 = index;
            //}
            //else
            //{
            //  chArray2 = new char[MaxPath + 1];
            //  numBufferChars = Win32Native.GetFullPathName(buffer, MaxPath + 1, chArray2, IntPtr.Zero);
            //  if (numBufferChars > MaxPath)
            //  {
            //    chArray2 = new char[numBufferChars];
            //    numBufferChars = Win32Native.GetFullPathName(buffer, numBufferChars, chArray2, IntPtr.Zero);
            //    if (numBufferChars > MaxPath)
            //    {
            //      throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
            //    }
            //  }
            //  if ((numBufferChars == 0) && (buffer[0] != '\0'))
            //  {
            //    __Error.WinIOError();
            //  }
            //  else if (numBufferChars < MaxPath)
            //  {
            //    chArray2[numBufferChars] = '\0';
            //  }
            //  if (Environment.nativeIsWin9x())
            //  {
            //    for (int m = 0; m < 260; m++)
            //    {
            //      if (chArray2[m] == '\0')
            //      {
            //        numBufferChars = m;
            //        break;
            //      }
            //    }
            //  }
            //  chArray3 = chArray2;
            //  num14 = numBufferChars;
            //  flag4 = false;
            //  for (uint k = 0; (k < num14) && !flag4; k++)
            //  {
            //    if (chArray2[k] == '~')
            //    {
            //      flag4 = true;
            //    }
            //  }
            //  if (flag4 && !TryExpandShortFileName(chArray2, ref num14, MaxPath))
            //  {
            //    int num17 = Array.LastIndexOf<char>(chArray2, DirectorySeparatorChar, num14 - 1, num14);
            //    if (num17 >= 0)
            //    {
            //      char[] destinationArray = new char[(num14 - num17) - 1];
            //      Array.Copy(chArray2, num17 + 1, destinationArray, 0, (num14 - num17) - 1);
            //      chArray2[num17] = '\0';
            //      bool flag6 = TryExpandShortFileName(chArray2, ref num17, MaxPath);
            //      chArray2[num17] = DirectorySeparatorChar;
            //      Array.Copy(destinationArray, 0, chArray2, num17 + 1, destinationArray.Length);
            //      if (flag6)
            //      {
            //        num14 = (num17 + 1) + destinationArray.Length;
            //      }
            //    }
            //  }
            //}
            //if (((numBufferChars != 0) && (chArray3[0] == '\\')) && (chArray3[1] == '\\'))
            //{
            //  int num18 = 2;
            //  while (num18 < numBufferChars)
            //  {
            //    if (chArray3[num18] == '\\')
            //    {
            //      num18++;
            //      break;
            //    }
            //    num18++;
            //  }
            //  if (num18 == numBufferChars)
            //  {
            //    throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegalUNC"));
            //  }
            //  if (CharArrayStartsWithOrdinal(chArray3, num14, @"\\?\globalroot", true))
            //  {
            //    throw new ArgumentException(Environment.GetResourceString("Arg_PathGlobalRoot"));
            //  }
            //}
            //if (num14 >= MaxPath)
            //{
            //  throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
            //}
            //if (numBufferChars != 0)
            //{
            //  return new string(chArray3, 0, num14);
            //}
            //int errorCode = Marshal.GetLastWin32Error();
            //if (errorCode == 0)
            //{
            //  errorCode = 0xa1;
            //}
            //__Error.WinIOError(errorCode, path);
            //return null;
        }

        #region Stale

        //internal static unsafe string NormalizePathFast(string path, bool fullCheck)
        //{
        //    char* chPtr2;
        //    int num15;
        //    if (fullCheck)
        //    {
        //        path = path.TrimEnd(new char[0]);
        //        CheckInvalidPathChars(path);
        //    }
        //    int num = 0;
        //    char* buffer = (char*) stackalloc byte[(2 * MaxPath)];
        //    int index = 0;
        //    uint num3 = 0;
        //    uint num4 = 0;
        //    bool flag = false;
        //    uint num5 = 0;
        //    int num6 = -1;
        //    bool flag2 = false;
        //    bool flag3 = true;
        //    bool flag4 = false;
        //    if ((path.Length > 0) && ((path[0] == DirectorySeparatorChar) || (path[0] == AltDirectorySeparatorChar)))
        //    {
        //        SafeSetStackPointerValue(buffer, index++, '\\');
        //        num++;
        //        num6 = 0;
        //    }
        //    while (num < path.Length)
        //    {
        //        char ch = path[num];
        //        if ((ch == DirectorySeparatorChar) || (ch == AltDirectorySeparatorChar))
        //        {
        //            if (num5 == 0)
        //            {
        //                if (num4 > 0)
        //                {
        //                    int num7 = num6 + 1;
        //                    if (path[num7] != '.')
        //                    {
        //                        throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                    }
        //                    if (num4 >= 2)
        //                    {
        //                        if (flag2 && (num4 > 2))
        //                        {
        //                            throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                        }
        //                        if (path[num7 + 1] == '.')
        //                        {
        //                            for (int i = num7 + 2; i < (num7 + num4); i++)
        //                            {
        //                                if (path[i] != '.')
        //                                {
        //                                    throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                                }
        //                            }
        //                            num4 = 2;
        //                        }
        //                        else
        //                        {
        //                            if (num4 > 1)
        //                            {
        //                                throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                            }
        //                            num4 = 1;
        //                        }
        //                    }
        //                    if (num4 == 2)
        //                    {
        //                        SafeSetStackPointerValue(buffer, index++, '.');
        //                    }
        //                    SafeSetStackPointerValue(buffer, index++, '.');
        //                    flag = false;
        //                }
        //                if ((((num3 > 0) && flag3) && ((num + 1) < path.Length)) && ((path[num + 1] == DirectorySeparatorChar) || (path[num + 1] == AltDirectorySeparatorChar)))
        //                {
        //                    SafeSetStackPointerValue(buffer, index++, DirectorySeparatorChar);
        //                }
        //            }
        //            num4 = 0;
        //            num3 = 0;
        //            if (!flag)
        //            {
        //                flag = true;
        //                SafeSetStackPointerValue(buffer, index++, DirectorySeparatorChar);
        //            }
        //            num5 = 0;
        //            num6 = num;
        //            flag2 = false;
        //            flag3 = false;
        //            if (flag4)
        //            {
        //                SafeSetStackPointerValue(buffer, index, '\0');
        //                TryExpandShortFileName(buffer, ref index, 260);
        //                flag4 = false;
        //            }
        //        }
        //        else
        //        {
        //            switch (ch)
        //            {
        //                case '.':
        //                    num4++;
        //                    goto Label_031A;

        //                case ' ':
        //                    num3++;
        //                    goto Label_031A;

        //                case '~':
        //                    flag4 = true;
        //                    break;
        //            }
        //            flag = false;
        //            if (flag3 && (ch == VolumeSeparatorChar))
        //            {
        //                char ch2 = (num > 0) ? path[num - 1] : ' ';
        //                if (((num4 != 0) || (num5 < 1)) || (ch2 == ' '))
        //                {
        //                    throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                }
        //                flag2 = true;
        //                if (num5 > 1)
        //                {
        //                    uint num9 = 0;
        //                    while ((num9 < index) && (buffer[num9] == ' '))
        //                    {
        //                        num9++;
        //                    }
        //                    if ((num5 - num9) == 1)
        //                    {
        //                        buffer[0] = ch2;
        //                        index = 1;
        //                    }
        //                }
        //                num5 = 0;
        //            }
        //            else
        //            {
        //                num5 += (1 + num4) + num3;
        //            }
        //            if ((num4 > 0) || (num3 > 0))
        //            {
        //                int num10 = (num6 >= 0) ? ((num - num6) - 1) : num;
        //                if (num10 > 0)
        //                {
        //                    for (int j = 0; j < num10; j++)
        //                    {
        //                        SafeSetStackPointerValue(buffer, index++, path[(num6 + 1) + j]);
        //                    }
        //                }
        //                num4 = 0;
        //                num3 = 0;
        //            }
        //            SafeSetStackPointerValue(buffer, index++, ch);
        //            num6 = num;
        //        }
        //    Label_031A:
        //        num++;
        //    }
        //    if ((num5 == 0) && (num4 > 0))
        //    {
        //        int num12 = num6 + 1;
        //        if (path[num12] != '.')
        //        {
        //            throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //        }
        //        if (num4 >= 2)
        //        {
        //            if (flag2 && (num4 > 2))
        //            {
        //                throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //            }
        //            if (path[num12 + 1] == '.')
        //            {
        //                for (int k = num12 + 2; k < (num12 + num4); k++)
        //                {
        //                    if (path[k] != '.')
        //                    {
        //                        throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                    }
        //                }
        //                num4 = 2;
        //            }
        //            else
        //            {
        //                if (num4 > 1)
        //                {
        //                    throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //                }
        //                num4 = 1;
        //            }
        //        }
        //        if (num4 == 2)
        //        {
        //            SafeSetStackPointerValue(buffer, index++, '.');
        //        }
        //        SafeSetStackPointerValue(buffer, index++, '.');
        //    }
        //    if (index == 0)
        //    {
        //        throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
        //    }
        //    SafeSetStackPointerValue(buffer, index, '\0');
        //    if (fullCheck && (CharArrayStartsWithOrdinal(buffer, index, "http:", false) || CharArrayStartsWithOrdinal(buffer, index, "file:", false)))
        //    {
        //        throw new ArgumentException(Environment.GetResourceString("Argument_PathUriFormatNotSupported"));
        //    }
        //    if (flag4)
        //    {
        //        TryExpandShortFileName(buffer, ref index, MaxPath);
        //    }
        //    int numBufferChars = 1;
        //    if (!fullCheck)
        //    {
        //        chPtr2 = buffer;
        //        num15 = index;
        //    }
        //    else
        //    {
        //        char* chPtr3 = (char*) stackalloc byte[(2 * (MaxPath + 1))];
        //        numBufferChars = Win32Native.GetFullPathName(buffer, MaxPath + 1, chPtr3, IntPtr.Zero);
        //        if (numBufferChars > MaxPath)
        //        {
        //            char* chPtr4 = (char*) stackalloc byte[(2 * numBufferChars)];
        //            chPtr3 = chPtr4;
        //            numBufferChars = Win32Native.GetFullPathName(buffer, numBufferChars, chPtr3, IntPtr.Zero);
        //        }
        //        if (numBufferChars >= MaxPath)
        //        {
        //            throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //        }
        //        if ((numBufferChars == 0) && (buffer[0] != '\0'))
        //        {
        //            __Error.WinIOError();
        //        }
        //        else if (numBufferChars < MaxPath)
        //        {
        //            chPtr3[numBufferChars] = '\0';
        //        }
        //        chPtr2 = chPtr3;
        //        num15 = numBufferChars;
        //        flag4 = false;
        //        for (uint m = 0; (m < num15) && !flag4; m++)
        //        {
        //            if (chPtr3[m] == '~')
        //            {
        //                flag4 = true;
        //            }
        //        }
        //        if (flag4 && !TryExpandShortFileName(chPtr3, ref num15, MaxPath))
        //        {
        //            int num17 = -1;
        //            for (int n = num15 - 1; n >= 0; n--)
        //            {
        //                if (chPtr3[n] == DirectorySeparatorChar)
        //                {
        //                    num17 = n;
        //                    break;
        //                }
        //            }
        //            if (num17 >= 0)
        //            {
        //                if (num15 >= MaxPath)
        //                {
        //                    throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //                }
        //                int len = (num15 - num17) - 1;
        //                char* pDest = (char*) stackalloc byte[(2 * len)];
        //                Buffer.memcpy(chPtr3, num17 + 1, pDest, 0, len);
        //                SafeSetStackPointerValue(chPtr3, num17, '\0');
        //                bool flag6 = TryExpandShortFileName(chPtr3, ref num17, MaxPath);
        //                SafeSetStackPointerValue(chPtr3, num17, DirectorySeparatorChar);
        //                if (((num17 + 1) + len) >= MaxPath)
        //                {
        //                    throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //                }
        //                Buffer.memcpy(pDest, 0, chPtr3, num17 + 1, len);
        //                if (flag6)
        //                {
        //                    num15 = (num17 + 1) + len;
        //                }
        //            }
        //        }
        //    }
        //    if (((numBufferChars != 0) && (chPtr2[0] == '\\')) && (chPtr2[1] == '\\'))
        //    {
        //        int num20 = 2;
        //        while (num20 < numBufferChars)
        //        {
        //            if (chPtr2[num20] == '\\')
        //            {
        //                num20++;
        //                break;
        //            }
        //            num20++;
        //        }
        //        if (num20 == numBufferChars)
        //        {
        //            throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegalUNC"));
        //        }
        //        if (CharArrayStartsWithOrdinal(chPtr2, num15, @"\\?\globalroot", true))
        //        {
        //            throw new ArgumentException(Environment.GetResourceString("Arg_PathGlobalRoot"));
        //        }
        //    }
        //    if (num15 >= MaxPath)
        //    {
        //        throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //    }
        //    if (numBufferChars != 0)
        //    {
        //        return new string(chPtr2, 0, num15);
        //    }
        //    int errorCode = Marshal.GetLastWin32Error();
        //    if (errorCode == 0)
        //    {
        //        errorCode = 0xa1;
        //    }
        //    __Error.WinIOError(errorCode, path);
        //    return null;
        //}
        //// Methods
        //[MethodImpl(MethodImplOptions.InternalCall)]
        //private static extern bool CanPathCircumventSecurityNative(string partOfPath);
        //private static unsafe bool CharArrayStartsWithOrdinal(char* array, int numChars, string compareTo, bool ignoreCase)
        //{
        //  if (numChars < compareTo.Length)
        //  {
        //    return false;
        //  }
        //  if (ignoreCase)
        //  {
        //    string str = new string(array, 0, compareTo.Length);
        //    return compareTo.Equals(str, StringComparison.OrdinalIgnoreCase);
        //  }
        //  for (int i = 0; i < compareTo.Length; i++)
        //  {
        //    if (array[i] != compareTo[i])
        //    {
        //      return false;
        //    }
        //  }
        //  return true;
        //}
        //private static unsafe void SafeSetStackPointerValue(char* buffer, int index, char value)
        //{
        //  if (index >= MaxPath)
        //  {
        //    throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //  }
        //  buffer[index] = value;
        //}

        //private static bool TryExpandShortFileName(char[] buffer, ref int bufferLength, int maxBufferSize)
        //{
        //  char[] longPathBuffer = new char[MaxPath + 1];
        //  int num = Win32Native.GetLongPathName(buffer, longPathBuffer, MaxPath);
        //  if (num >= MaxPath)
        //  {
        //    throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //  }
        //  if (num == 0)
        //  {
        //    return false;
        //  }
        //  if (Environment.nativeIsWin9x())
        //  {
        //    for (int i = 0; i < 260; i++)
        //    {
        //      if (longPathBuffer[i] == '\0')
        //      {
        //        num = i;
        //        break;
        //      }
        //    }
        //  }
        //  Buffer.BlockCopy(longPathBuffer, 0, buffer, 0, 2 * num);
        //  bufferLength = num;
        //  buffer[bufferLength] = '\0';
        //  return true;
        //}

        //private static unsafe bool TryExpandShortFileName(char* buffer, ref int bufferLength, int maxBufferSize)
        //{
        //    char* longPathBuffer = (char*) stackalloc byte[(2 * (MaxPath + 1))];
        //    int len = Win32Native.GetLongPathName(buffer, longPathBuffer, MaxPath);
        //    if (len >= MaxPath)
        //    {
        //        throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
        //    }
        //    if (len == 0)
        //    {
        //        return false;
        //    }
        //    Buffer.memcpy(longPathBuffer, 0, buffer, 0, len);
        //    bufferLength = len;
        //    buffer[bufferLength] = '\0';
        //    return true;
        //}

        #endregion

    }



}
