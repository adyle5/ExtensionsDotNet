﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        /// <summary>
        /// Performs a deep copy of an object.
        /// Object must be a class and must be serializable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCopyExt<T>(this T obj) where T : class
        {
            if (obj == null) return obj;

            T newObj = null;

            if (obj.GetType().IsSerializable)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter f = new BinaryFormatter();
                    f.Serialize(ms, obj);
                    ms.Position = 0;
                    newObj = (T)f.Deserialize(ms);
                }
            }

            return newObj;
        }

        /// <summary>
        /// Converts generic type to a stream.
        /// Generated stream needs to be disposed or wrapped in using.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Stream ToStreamExt<T>(this T obj)
        {
            string strObj = obj.ToString();
            byte[] bytes = strObj.GetBytesExt();
            MemoryStream ms = new MemoryStream(bytes);

            return ms;
        }

        /// <summary>
        /// Converts to a KeyValuePair with the value of the extended type as the key and the parameter as the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KeyValuePair<T, U> ToKeyValuePairExt<T, U>(this T key, U value)
        {
            return new KeyValuePair<T, U>(key, value);
        }

        /// <summary>
        /// Converts to a KeyValuePair with the value of the extended type as the value and the parameter as the key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static KeyValuePair<T, U> ToKeyValuePair2Ext<T, U>(this U value, T key)
        {
            return new KeyValuePair<T, U>(key, value);
        }

        /// <summary>
        /// Creates a new IEnumerable of the same type as the extended type and repeats the value of the extended times based on the integral parameter.
        /// Maps to Enumerable.Repeat.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="numberOfTimes"></param>
        /// <returns></returns>
        public static IEnumerable<T> RepeatExt<T>(this T value, int numberOfTimes) => System.Linq.Enumerable.Repeat(value, numberOfTimes);

        /// <summary>
        /// Write's the value of a string or the ToString method to the Trace Listener.
        /// Map of Trace.Write
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public static void TraceExt<T>(this T obj) => System.Diagnostics.Trace.Write(obj);

        /// <summary>
        /// Write's the value of a string or the ToString method and category specified to the Trace Listener.
        /// Map of Trace.Write
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="category"></param>
        public static void TraceExt<T>(this T obj, string category) => Trace.Write(obj, category);

        /// <summary>
        /// Write's the value of a string or the ToString method specified to the Trace Listener based on a condition.
        /// Map of Trace.WriteIf
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="condition"></param>
        public static void TraceIfExt<T>(this T obj, bool condition) => Trace.WriteIf(condition, obj);

        /// <summary>
        /// Write's the value of a string or the ToString method and category specified to the Trace Listener based on a condition.
        /// Map of Trace.WriteIf
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="condition"></param>
        /// <param name="category"></param>
        public static void TraceIfExt<T>(this T obj, bool condition, string category) => Trace.WriteIf(condition, obj, category);

        /// <summary>
        /// Write's the value of a string or the ToString method to a new line in the Trace Listener.
        /// Map of Trace.WriteLine
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public static void TraceLineExt<T>(this T obj) => Trace.WriteLine(obj);

        /// <summary>
        /// Write's the value of a string or the ToString method and category specified to a new line in the Trace Listener.
        /// Map of Trace.WriteLine
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="category"></param>
        public static void TraceLineExt<T>(this T obj, string category) => Trace.WriteLine(obj, category);

        /// <summary>
        /// Write's the value of a string or the ToString method specified to a new line in the Trace Listener based on a condition.
        /// Map of Trace.WriteLineIf
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="condition"></param>
        public static void TraceLineIfExt<T>(this T obj, bool condition) => Trace.WriteLineIf(condition, obj);

        /// <summary>
        /// Write's the value of a string or the ToString method and category specified to a new line in the Trace Listener based on a condition.
        /// Map of Trace.WriteLineIf
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="condition"></param>
        /// <param name="category"></param>
        public static void TraceLineIfExt<T>(this T obj, bool condition, string category) => Trace.WriteLineIf(condition, obj, category);
    }
}
