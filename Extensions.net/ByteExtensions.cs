using System;
using System.Text;

namespace Extensions.net
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Maps to Convert.ToBase64String
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToBase64StringExt(this byte[] bytes) => Convert.ToBase64String(bytes);

        /// <summary>
        /// Maps to Encoding.Default.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesExt(this char[] chars) => Encoding.Default.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.Default.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesExt(this char[] chars, int index, int count) => Encoding.Default.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to Encoding.UTF8.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf8Ext(this char[] chars) => Encoding.UTF8.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.UTF8.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf8Ext(this char[] chars, int index, int count) => Encoding.UTF8.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to Encoding.UTF7.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf7Ext(this char[] chars) => Encoding.UTF7.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.UTF7.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf7Ext(this char[] chars, int index, int count) => Encoding.UTF7.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to Encoding.UTF32.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf32Ext(this char[] chars) => Encoding.UTF32.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.UTF32.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesUtf32Ext(this char[] chars, int index, int count) => Encoding.UTF32.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to Encoding.Unicode.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesUnicodeExt(this char[] chars) => Encoding.Unicode.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.Unicode.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesUnicodeExt(this char[] chars, int index, int count) => Encoding.Unicode.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to Encoding.ASCII.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesASCIIExt(this char[] chars) => Encoding.ASCII.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.ASCII.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesASCIIExt(this char[] chars, int index, int count) => Encoding.ASCII.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to Encoding.BigEndianUnicode.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static byte[] GetBytesBigEndianUnicodeExt(this char[] chars) => Encoding.BigEndianUnicode.GetBytes(chars);

        /// <summary>
        /// Maps to Encoding.BigEndianUnicode.GetBytes
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static byte[] GetBytesBigEndianUnicodeExt(this char[] chars, int index, int count) => Encoding.BigEndianUnicode.GetBytes(chars, index, count);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlDecodeToBytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static byte[] UrlDecodeToBytesExt(this byte[] bytes) => System.Web.HttpUtility.UrlDecodeToBytes(bytes);

        /// <summary>
        /// Maps to System.Web.HttpUtility.UrlEncodeToBytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static byte[] UrlEncodeToBytesExt(this byte[] bytes) => System.Web.HttpUtility.UrlEncodeToBytes(bytes);
    }
}
