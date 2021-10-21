using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace Extensions.net
{
    /// <summary>
    /// String extensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Maps to string.IsNullOrWhiteSpace
        /// </summary>
        /// <returns><c>true</c>, if string null or white space, <c>false</c> otherwise.</returns>
        /// <param name="text">Text.</param>
        public static bool IsNullOrWhiteSpaceExt(this string text) => string.IsNullOrWhiteSpace(text);

        /// <summary>
        /// maps to string.IsNullOrEmpty
        /// </summary>
        /// <returns><c>true</c>, if string null or empty, <c>false</c> otherwise.</returns>
        /// <param name="text">Text.</param>
        public static bool IsNullOrEmptyExt(this string text) => string.IsNullOrEmpty(text);

        /// <summary>
        /// Maps to string.<paramref name="compareTo"/>, sets the String comparison to Invariant Culture Ignore Case.
        /// </summary>
        /// <returns>The value that comes first alphabeltically. If the same returns an empty string. Ignores case.</returns>
        /// <param name="text">Text.</param>
        /// <param name="compareTo">Compare to.</param>
        public static int CompareExt(this string text, string compareTo) => string.Compare(text, compareTo, StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Returns the first element alphabetically. Of they are the same, returns an empty string.
        /// </summary>
        /// <returns>The first ext.</returns>
        /// <param name="text">Text.</param>
        /// <param name="compareTo">Compare to.</param>
        public static string CompareFirstExt(this string text, string compareTo)
        {
            int res = string.Compare(text, compareTo, StringComparison.InvariantCultureIgnoreCase);
            if (res < 0) return text;
            if (res > 0) return compareTo;

            return "";
        }

        /// <summary>
        /// maps to string.CompareOrdinal
        /// </summary>
        /// <returns>integer indicating which comes first in the sort order.</returns>
        /// <param name="text">Text.</param>
        /// <param name="compareTo">Compare to.</param>
        public static int CompareOrdinalExt(this string text, string compareTo) => string.CompareOrdinal(text, compareTo);

        /// <summary>
        /// Maps to string.CompareOrdinal
        /// </summary>
        /// <returns>The ordinal.</returns>
        /// <param name="text">Text.</param>
        /// <param name="textIndex">Text index.</param>
        /// <param name="compareTo">Compare to.</param>
        /// <param name="compareToIndex">Compare to index.</param>
        /// <param name="length">Length.</param>
        public static int CompareOrdinalExt(this string text, int textIndex, string compareTo, int compareToIndex, int length) => string.CompareOrdinal(text, textIndex, compareTo, compareToIndex, length);

        /// <summary>
        /// Concatenate the specified text and n number of strings. Can be a list of strings or an array
        /// Similar to string.Concat.
        /// </summary>
        /// <returns>The concatenate.</returns>
        /// <param name="text">Text.</param>
        /// <param name="toAdd">To add.</param>
        public static string ConcatExt(this string text, params string[] toAdd)
        {
            if (toAdd != null)
            {
                StringBuilder sb = new StringBuilder(text);
                for (int i = 0; i < toAdd.Length; i++)
                {
                    sb.Append(toAdd[i]);
                }

                return sb.ToString();
            }
            else
            {
                return text;
            }
        }

        /// <summary>
        /// Maps to string.Copy.
        /// Deep copy.
        /// </summary>
        /// <returns>The copy.</returns>
        /// <param name="text">Text.</param>
        public static string CopyExt(this string text) => string.Copy(text);

        /// <summary>
        /// Maps to string.Format
        /// </summary>
        /// <returns>The formatted.</returns>
        /// <param name="text">Text.</param>
        /// <param name="values">Values.</param>
        public static string FormatExt(this string text, params object[] values)
        {
            if (values != null)
            {
                return string.Format(text, values);
            }
            else
            {
                return text;
            }
        }

        /// <summary>
        /// Maps to string.Intern
        /// </summary>
        /// <returns>The intern.</returns>
        /// <param name="text">Text.</param>
        public static string InternExt(this string text) => string.Intern(text);

        /// <summary>
        /// Maps to string.IsInterned
        /// </summary>
        /// <returns>The intern.</returns>
        /// <param name="text">Text.</param>
        public static string IsInternExt(this string text) => string.IsInterned(text);

        /// <summary>
        /// Maps to string.Join
        /// </summary>
        /// <returns>The ext.</returns>
        /// <param name="text">Text.</param>
        /// <param name="separator">Separator.</param>
        /// <param name="value">Value.</param>
        /// <param name="startIndex">Start index.</param>
        /// <param name="count">Count.</param>
        public static string JoinExt(this string text, string separator, string[] value, int startIndex, int count)
        {
            string[] newArr = new string[value.Length + 1];
            newArr[0] = text;
            value.CopyTo(newArr, 1);
            return string.Join(separator, newArr, startIndex, count);
        }

        /// <summary>
        /// Maps to string.Join
        /// </summary>
        /// <returns>The ext.</returns>
        /// <param name="text">Text.</param>
        /// <param name="separator">Separator.</param>
        /// <param name="value">Value.</param>
        public static string JoinExt(this string text, string separator, params string[] value)
        {
            string[] newArr = new string[value.Length + 1];
            newArr[0] = text;
            value.CopyTo(newArr, 1);
            return string.Join(separator, newArr);
        }

        /// <summary>
        /// Maps to string.ReferenceEquals
        /// </summary>
        /// <returns><c>true</c>, if equals ext was referenced, <c>false</c> otherwise.</returns>
        /// <param name="text">Text.</param>
        /// <param name="compareTo">Compare to.</param>
        public static bool ReferenceEqualsExt(this string text, string compareTo) => ReferenceEquals(text, compareTo);

        /// <summary>
        /// Maps to Convert.ToDateTime;
        /// </summary>
        /// <returns>The date time ext.</returns>
        /// <param name="text">Text.</param>
        public static DateTime ToDateTimeExt(this string text) => Convert.ToDateTime(text);

        /// <summary>
        /// Maps to Convert.FromBase64String
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] FromBase64StringExt(this string text) => Convert.FromBase64String(text);

        /// <summary>
        /// Maps to TitleInfo.ToTitleCase
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ToTitleCaseExt(this string text)
        {
            TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
            return textInfo.ToTitleCase(text);
        }

        /// <summary>
        /// Reverses a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReverseExt(this string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Retruns a bool indicating if the text is a palindrome
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsPalindromeExt(this string text)
        {
            string reversed = text.ReverseExt();
            return text == reversed;

        }

        /// <summary>
        /// Maps to Console.Write
        /// </summary>
        /// <param name="text"></param>
        public static void WriteToConsoleExt(this string text) => Console.Write(text);

        /// <summary>
        /// Maps to Console.WriteLine
        /// </summary>
        /// <param name="text"></param>
        public static void WriteLineToConsoleExt(this string text) => Console.WriteLine(text);

        /// <summary>
        /// Maps Debug.Write
        /// Writes to the debug window
        /// </summary>
        /// <param name="text"></param>
        public static void WriteToDebugExt(this string text) => Debug.Write(text);

        /// <summary>
        /// Maps to Debug.WriteLine
        /// Writes to the debug window
        /// </summary>
        /// <param name="text"></param>
        public static void WriteLineToDebugExt(this string text) => Debug.WriteLine(text);

        /// <summary>
        /// Maps to Debug.WriteIf
        /// Writes to the debug window
        /// </summary>
        /// <param name="text"></param>
        /// <param name="condition"></param>
        public static void WriteIfToDebugExt(this string text, bool condition) => Debug.WriteIf(condition, text);

        /// <summary>
        /// Maps to Debug.WriteLineIf
        /// Writes to the debug window
        /// </summary>
        /// <param name="text"></param>
        /// <param name="condition"></param>
        public static void WriteIfLineToDebugExt(this string text, bool condition) => Debug.WriteLineIf(condition, text);

        /// <summary>
        /// Write text to a file. If file exists it will ovewrite.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        public static void WriteToFileExt(this string text, string path)
        {
            using (var f = File.Create(path))
            {
                using (StreamWriter sw = new StreamWriter(f))
                {
                    sw.Write(text);
                }
            }
        }

        /// <summary>
        /// Append Text to a file or creates new file.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        public static void AppendToFileExt(this string text, string path)
        {
            using (var f = File.AppendText(path))
            {
                f.WriteLine(text);
            }
        }

        /// <summary>
        /// Maps to Encoding.Default.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesExt(this string s) => Encoding.Default.GetBytes(s);

        /// <summary>
        /// Maps to Encoding.UTF8.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf8Ext(this string s) => Encoding.UTF8.GetBytes(s);

        /// <summary>
        /// Maps to Encoding.UTF7.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf7Ext(this string s) => Encoding.UTF7.GetBytes(s);

        /// <summary>
        /// Maps to Encoding.UTF32.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf32Ext(this string s) => Encoding.UTF32.GetBytes(s);

        /// <summary>
        /// Maps to Encoding.Unicode.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesUnicodeExt(this string s) => Encoding.Unicode.GetBytes(s);

        /// <summary>
        /// Maps to Encoding.ASCII.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesASCIIExt(this string s) => Encoding.ASCII.GetBytes(s);

        /// <summary>
        /// Maps to Encoding.BigEndianUnicode.GetBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytesBigEndianUnicodeExt(this string s) => Encoding.BigEndianUnicode.GetBytes(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlEncode
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string UrlEncodeExt(this string s) => System.Web.HttpUtility.UrlEncode(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlDecode
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string UrlDecodeExt(this string s) => System.Web.HttpUtility.UrlDecode(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.HtmlEncode
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string HtmlEncodeExt(this string s) => System.Web.HttpUtility.HtmlEncode(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.HtmlDecode
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string HtmlDecodeExt(this string s) => System.Web.HttpUtility.HtmlDecode(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.HtmlAttributeEncode
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string HtmlAttributeEncodeExt(this string s) => System.Web.HttpUtility.HtmlAttributeEncode(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.JavaScriptStringEncode
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string JavaScriptStringEncodeExt(this string s) => System.Web.HttpUtility.JavaScriptStringEncode(s);

        public static System.Collections.Specialized.NameValueCollection ParseQueryStringExt(this string s) => System.Web.HttpUtility.ParseQueryString(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlDecodeToBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] UrlDecodeToBytesExt(this string s) => System.Web.HttpUtility.UrlDecodeToBytes(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlDecodeToBytes
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static byte[] UrlDecodeToBytesExt(this string s, Encoding e) => System.Web.HttpUtility.UrlDecodeToBytes(s, e);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlEncodeToBytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] UrlEncodeToBytesExt(this string s) => System.Web.HttpUtility.UrlEncodeToBytes(s);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlEncodeToBytes
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static byte[] UrlEncodeToBytesExt(this string s, Encoding e) => System.Web.HttpUtility.UrlEncodeToBytes(s, e);

        /// <summary>
        /// Capitalizes the first character in every sentence of a string. A sentence is defined by a string fragment that terminates in a period or a string with no periods. If the string is null or empty, returns the original string.
        /// Uses IsNullOrWhiteSpaceExt and ConcatExt.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CapitalizeExt(this string text)
        {
            if (!text.IsNullOrWhiteSpaceExt())
            {
                if (text.Contains("."))
                {
                    string[] arrText = text.Split('.');
                    string[] arrCap = new string[arrText.Length];

                    for (int i = 0; i < arrText.Length; i++)
                    {               
                        if (!arrText[i].IsNullOrWhiteSpaceExt())
                        {
                            string currText = arrText[i].Trim();
                            arrCap[i] = currText.Substring(0, 1).ToUpperInvariant().ConcatExt(currText.Substring(1, currText.Length - 1));
                        }
                        else
                        {
                            arrCap[i] = arrText[i];
                        }
                    }

                    return arrCap.JoinExt(". ").Trim();
                }
                else
                {
                    return text.Substring(0, 1).ToUpperInvariant().ConcatExt(text.Substring(1, text.Length - 1));
                }        
            }

            return text;
        }

        /// <summary>
        /// Duplicates the value of a string the specified number of times.
        /// String can be of any valid string value including a character, word, sentence, empty space, white space, or null.
        /// Useful for adding padding.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string DuplicateExt(this string text, int length)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                sb.Append(text);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Centers the string and adds leading and trailing characters. 
        /// Optional char parameter specifies the fill in the beginning and the end.
        /// If the word is larger then the specified length, the original word is returned.
        /// Similiar to the Python stringmethod Center.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="length"></param>
        /// <param name="fill"></param>
        /// <returns></returns>
        public static string CenterExt(this string text, int length, char fill = ' ')
        {
            if (text == null)
            {
                return text;
            }
            
            int wordLen = text.Length;
            if (length > wordLen)
            {
                int lead = ((length - wordLen) / 2);
                string centered = string.Concat(fill.ToString().DuplicateExt(lead), text);

                int centeredLen = centered.Length;
                if (length > centeredLen)
                {
                    int tail = length - centeredLen;
                    centered = centered.ConcatExt(fill.ToString().DuplicateExt(tail));
                }

                return centered;
            }

            return text;
        }

        /// <summary>
        /// Returns true if all characters inside the string are either numbers or letters, otherwise returns false. All characters evaluated including blank spaces.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsAlphaNumericExt(this string text)
        {
            if (text == null)
            {
                return false;
            }

            string regex = "^[a-zA-Z0-9]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(text, regex);
        }

        /// <summary>
        /// Returns true if all characters inside the string are letters, otherwise returns false. All characters evaluated including blank spaces.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsAlphaExt(this string text)
        {
            if (text == null)
            {
                return false;
            }

            string regex = "^[a-zA-Z]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(text, regex);
        }

        /// <summary>
        /// Returns true if all characters inside the string are numeric, otherwise returns false. All characters evaluated including blank spaces. A decimal number returns false since it contains a non-numeric character (period).
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNumericExt(this string text)
        {
            if (text == null)
            {
                return false;
            }

            string regex = "^[0-9]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(text, regex);
        }

        /// <summary>
        /// Returns true if all characters in the string are within the ASCII number range (0-126), otherwise returns false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsASCIIExt(this string text)
        {
            if (text == null)
            {
                return false;
            }

            foreach (char c in text)
            {
                if (c.ToInt32Ext() > 126)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns true if all characters in the string are letters and lower case, otherwise returns false. Null, empty string, and white space return false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsLowerExt(this string text)
        {
            if (text.IsNullOrWhiteSpaceExt())
            {
                return false;
            }

            foreach (char c in text)
            {
                if (c.ToInt32Ext() < 97 || c.ToInt32Ext() > 122)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns true if all characters in the string are letters and upper case, otherwise returns false. Null, empty string, and white space return false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsUpperExt(this string text)
        {
            if (text.IsNullOrWhiteSpaceExt())
            {
                return false;
            }

            foreach (char c in text)
            {
                if (c.ToInt32Ext() < 65 || c.ToInt32Ext() > 90)
                {
                    return false;
                }
            }

            return true;
        }

        #region "Moved to Generic Extensions"
        ///// <summary>
        ///// Maps to Convert.ToInt32
        ///// </summary>
        ///// <returns>The int32 ext.</returns>
        ///// <param name="text">Text.</param>
        //public static int ToInt32Ext(this string text) => Convert.ToInt32(text);

        ///// <summary>
        ///// Maps to Covert.ToUInt32
        ///// </summary>
        ///// <returns>The user interface nt32 ext.</returns>
        ///// <param name="text">Text.</param>
        //public static uint ToUInt32Ext(this string text) => Convert.ToUInt32(text);

        ///// <summary>
        ///// Maps to Convert.ToInt16
        ///// </summary>
        ///// <returns>The int16 ext.</returns>
        ///// <param name="text">Text.</param>
        //public static Int16 ToInt16Ext(this string text) => Convert.ToInt16(text);

        ///// <summary>
        ///// Maps to Convert.ToUInt16
        ///// </summary>
        ///// <returns>The user interface nt16 ext.</returns>
        ///// <param name="text">Text.</param>
        //public static UInt16 ToUInt16Ext(this string text) => Convert.ToUInt16(text);

        ///// <summary>
        ///// Maps to Convert.ToInt64
        ///// </summary>
        ///// <returns>The int64 ext.</returns>
        ///// <param name="text">Text.</param>
        //public static Int64 ToInt64Ext(this string text) => Convert.ToInt64(text);

        ///// <summary>
        ///// Maps to Convert.ToUInt64
        ///// </summary>
        ///// <returns>The user interface nt64 ext.</returns>
        ///// <param name="text">Text.</param>
        //public static UInt64 ToUInt64Ext(this string text) => Convert.ToUInt64(text);

        ///// <summary>
        ///// Maps to Convert.ToDouble
        ///// </summary>
        ///// <returns>The double ext.</returns>
        ///// <param name="text">Text.</param>
        //public static double ToDoubleExt(this string text) => Convert.ToDouble(text);

        ///// <summary>
        ///// Maps to Convert.ToSingle
        ///// </summary>
        ///// <returns>The single ext.</returns>
        ///// <param name="text">Text.</param>
        //public static Single ToSingleExt(this string text) => Convert.ToSingle(text);

        ///// <summary>
        ///// Converts a string to a float or throws a format exception.
        ///// </summary>
        ///// <returns>The float ext.</returns>
        ///// <param name="text">Text.</param>
        //public static float ToFloatExt(this string text)
        //{
        //    float f = -1;
        //    if (float.TryParse(text, out f))
        //    {
        //        return f;
        //    }
        //    else
        //    {
        //        throw new FormatException("Input string was not in a correct format.");
        //    }
        //}

        ///// <summary>
        ///// Converts a string to a long or throws a Format Exception
        ///// </summary>
        ///// <returns>The long ext.</returns>
        ///// <param name="text">Text.</param>
        //public static long ToLongExt(this string text)
        //{
        //    long l = -1;
        //    if (long.TryParse(text, out l))
        //    {
        //        return l;
        //    }
        //    else
        //    {
        //        throw new FormatException("Input string was not in a correct format.");
        //    }
        //}

        ///// <summary>
        ///// Converts a string to a short or throws a format exception.
        ///// </summary>
        ///// <returns>The short ext.</returns>
        ///// <param name="text">Text.</param>
        //public static short ToShortExt(this string text)
        //{
        //    short s = -1;
        //    if (short.TryParse(text, out s))
        //    {
        //        return s;
        //    }
        //    else
        //    {
        //        throw new FormatException("Input string was not in a correct format.");
        //    }
        //}

        ///// <summary>
        ///// Maps to Convert.ToBoolean
        ///// </summary>
        ///// <returns><c>true</c>, if boolean ext was toed, <c>false</c> otherwise.</returns>
        ///// <param name="text">Text.</param>
        //public static bool ToBooleanExt(this string text) => Convert.ToBoolean(text);

        ///// <summary>
        ///// Maps to Convert.ToByte
        ///// </summary>
        ///// <returns>The byte ext.</returns>
        ///// <param name="text">Text.</param>
        //public static byte ToByteExt(this string text) => Convert.ToByte(text);

        ///// <summary>
        ///// Maps to Convert.ToChar
        ///// </summary>
        ///// <returns>The char ext.</returns>
        ///// <param name="text">Text.</param>
        //public static char ToCharExt(this string text) => Convert.ToChar(text);

        ///// <summary>
        ///// Maps to Convert.ToDecimal
        ///// </summary>
        ///// <returns>The decimal ext.</returns>
        ///// <param name="text">Text.</param>
        //public static decimal ToDecimalExt(this string text) => Convert.ToDecimal(text);

        ///// <summary>
        ///// Maps to Convert.ToSByte.
        ///// </summary>
        ///// <returns>The SB yte ext.</returns>
        ///// <param name="text">Text.</param>
        //public static SByte ToSByteExt(this string text) => Convert.ToSByte(text);
        #endregion
    }
}
