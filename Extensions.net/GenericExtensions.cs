﻿using System;
using System.Text;

namespace Extensions.net
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Maps to Convert.ToInt32
        /// </summary>
        /// <returns>The int32 ext.</returns>
        /// <param name="text">Text.</param>
        public static int ToInt32Ext<T>(this T obj) where T : IConvertible => Convert.ToInt32(obj);

        /// <summary>
        /// Maps to Covert.ToUInt32
        /// </summary>
        /// <returns>The user interface nt32 ext.</returns>
        /// <param name="text">Text.</param>
        public static uint ToUInt32Ext<T>(this T obj) where T : IConvertible => Convert.ToUInt32(obj);

        /// <summary>
        /// Maps to Convert.ToInt16
        /// </summary>
        /// <returns>The int16 ext.</returns>
        /// <param name="text">Text.</param>
        public static Int16 ToInt16Ext<T>(this T obj) where T : IConvertible => Convert.ToInt16(obj);

        /// <summary>
        /// Maps to Convert.ToUInt16
        /// </summary>
        /// <returns>The user interface nt16 ext.</returns>
        /// <param name="text">Text.</param>
        public static UInt16 ToUInt16Ext<T>(this T obj) where T : IConvertible => Convert.ToUInt16(obj);

        /// <summary>
        /// Maps to Convert.ToInt64
        /// </summary>
        /// <returns>The int64 ext.</returns>
        /// <param name="text">Text.</param>
        public static Int64 ToInt64Ext<T>(this T obj) where T : IConvertible => Convert.ToInt64(obj);

        /// <summary>
        /// Maps to Convert.ToUInt64
        /// </summary>
        /// <returns>The user interface nt64 ext.</returns>
        /// <param name="text">Text.</param>
        public static UInt64 ToUInt64Ext<T>(this T obj) where T : IConvertible => Convert.ToUInt64(obj);

        /// <summary>
        /// Maps to Convert.ToDouble
        /// </summary>
        /// <returns>The double ext.</returns>
        /// <param name="text">Text.</param>
        public static double ToDoubleExt<T>(this T obj) where T : IConvertible => Convert.ToDouble(obj);

        /// <summary>
        /// Maps to Convert.ToSingle
        /// </summary>
        /// <returns>The single ext.</returns>
        /// <param name="text">Text.</param>
        public static Single ToSingleExt<T>(this T obj) where T : IConvertible => Convert.ToSingle(obj);

        /// <summary>
        /// Converts a string to a float or throws a format exception.
        /// </summary>
        /// <returns>The float ext.</returns>
        /// <param name="text">Text.</param>
        public static float ToFloatExt<T>(this T obj) where T : IConvertible
        {
            float f = -1;
            if (float.TryParse(obj.ToString(), out f))
            {
                return f;
            }
            else
            {
                throw new FormatException("Input was not in a correct format.");
            }
        }

        /// <summary>
        /// Converts a string to a long or throws a Format Exception
        /// </summary>
        /// <returns>The long ext.</returns>
        /// <param name="text">Text.</param>
        public static long ToLongExt<T>(this T obj) where T : IConvertible
        {
            long l = -1;
            if (long.TryParse(obj.ToString(), out l))
            {
                return l;
            }
            else
            {
                throw new FormatException("Input was not in a correct format.");
            }
        }

        /// <summary>
        /// Converts a string to a short or throws a format exception.
        /// </summary>
        /// <returns>The short ext.</returns>
        /// <param name="text">Text.</param>
        public static short ToShortExt<T>(this T obj) where T : IConvertible
        {
            short s = -1;
            if (short.TryParse(obj.ToString(), out s))
            {
                return s;
            }
            else
            {
                throw new FormatException("Input was not in a correct format.");
            }
        }

        /// <summary>
        /// Maps to Convert.ToBoolean
        /// </summary>
        /// <returns><c>true</c>, if boolean ext was toed, <c>false</c> otherwise.</returns>
        /// <param name="text">Text.</param>
        public static bool ToBooleanExt<T>(this T obj) where T : IConvertible => Convert.ToBoolean(obj);

        /// <summary>
        /// Maps to Convert.ToByte
        /// </summary>
        /// <returns>The byte ext.</returns>
        /// <param name="text">Text.</param>
        public static byte ToByteExt<T>(this T obj) where T : IConvertible => Convert.ToByte(obj);

        /// <summary>
        /// Maps to Convert.ToChar
        /// </summary>
        /// <returns>The char ext.</returns>
        /// <param name="text">Text.</param>
        public static char ToCharExt<T>(this T obj) where T : IConvertible => Convert.ToChar(obj);

        /// <summary>
        /// Maps to Convert.ToDecimal
        /// </summary>
        /// <returns>The decimal ext.</returns>
        /// <param name="text">Text.</param>
        public static decimal ToDecimalExt<T>(this T obj) where T : IConvertible => Convert.ToDecimal(obj);

        /// <summary>
        /// Maps to Convert.ToSByte.
        /// </summary>
        /// <returns>The SB yte ext.</returns>
        /// <param name="text">Text.</param>
        public static SByte ToSByteExt<T>(this T obj) where T : IConvertible => Convert.ToSByte(obj);
    }
}
