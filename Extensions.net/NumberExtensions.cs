using System;

namespace Extensions.net
{
    /// <summary>
    /// Number Extensions
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Maps to int.TryParse
        /// Depends on C# 7.2 or later
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static void TryParseExt(this ref int output, string input) => int.TryParse(input, out output);

        /// <summary>
        /// Maps to int.Parse
        /// Depends on C# 7.2 or later
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        public static void ParseExt(this ref int output, string input) => output = int.Parse(input);

        /// <summary>
        /// Returns a DateTime object from ticks.
        /// </summary>
        /// <param name="ticks"></param>
        /// <returns></returns>
        public static DateTime ToDateTimeExt(this long ticks) => new DateTime(ticks);

        /// <summary>
        /// Checks if a nullable integer is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this int? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable Int16 is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this Int16? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable Int64 is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this Int64? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable UInt32 is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this UInt32? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable UInt16 is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this UInt16? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable UInt64 is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this UInt64? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable double is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this double? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable Single is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this Single? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable decimal is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this decimal? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable byte is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this byte? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable sbyte is null or is less than one.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrLessThanOneExt(this sbyte? num) => num == null || num < 1;

        /// <summary>
        /// Checks if a nullable integer is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this int? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable Int16 is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this Int16? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable Int64 is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this Int64? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable UInt32 is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this UInt32? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable UInt16 is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this UInt16? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable UInt64 is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this UInt64? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable double is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this double? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable Single is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this Single? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable decimal is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this decimal? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable byte is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this byte? num) => num == null || num == 0;

        /// <summary>
        /// Checks if a nullable sbyte is null or is zero.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNullOrZeroExt(this sbyte? num) => num == null || num == 0;
    }
}
