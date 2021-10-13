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

        /// <summary>
        /// Returns true if a number is even.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsEvenExt(this int num) => num % 2 == 0;

        /// <summary>
        /// Returns true if a number is odd.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsOddExt(this int num) => num % 2 != 0;

        /// <summary>
        /// Returns true if a number is even.
        /// Double must be integral to be even. If not integral, will return false.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsEvenExt(this double num)
        {
            if (num.IsIntegralExt())
            {
                return num % 2 == 0;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Returns true if a number is odd.
        /// Double must be integral to be odd. If not integral, will return false.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsOddExt(this double num)
        {
            if (num.IsIntegralExt())
            {
                return num % 2 != 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns true if a number is even.
        /// Decimal must be integral to be even. If not integral, will return false.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsEvenExt(this decimal num)
        {
            if (num.IsIntegralExt())
            {
                return num % 2 == 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns true if a number is odd.
        /// Decimal must be integral to be odd. If not integral, will return false.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsOddExt(this decimal num)
        {
            if (num.IsIntegralExt())
            {
                return num % 2 != 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a boolean value indicating if the double is an integral value.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsIntegralExt(this double num) => num % 1 == 0;

        /// <summary>
        /// Returns a boolean value indicating if the decimal is an integral value.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsIntegralExt(this decimal num) => num % 1 == 0;

        /// <summary>
        /// Converts decimal to a currency string using "C2" formatter.
        /// Culture set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToCurrencyExt(this decimal num) => num.ToString("C2", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts double to a currency string using "C2" formatter.
        /// CultureInfo set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToCurrencyExt(this double num) => num.ToString("C2", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts float to a currency string using "C2" formatter.
        /// CultureInfo set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToCurrencyExt(this float num) => num.ToString("C2", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts int to a currency string using "C2" formatter.
        /// CultureInfo set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToCurrencyExt(this int num) => num.ToString("C2", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts decimal to a percent string.
        /// .23 => "23.00%"
        /// Optional parameter specifies how many decimals out return. Default value is 2 decimal places.
        /// Will round value up or down if necessary.
        /// Culture set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToPercentExt(this decimal num, int decimals = 2) => num.ToString($"P{decimals}", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts double to a percent string.
        /// .23 => "23.00%"
        /// Optional parameter specifies how many decimals out return. Default value is 2 decimal places.
        /// Will round value up or down if necessary.
        /// CultureInfo set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToPercentExt(this double num, int decimals = 2) => num.ToString($"P{decimals}", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts float to a percent string.
        /// .23 => "23.00%"
        /// Optional parameter specifies how many decimals out return. Default value is 2 decimal places.
        /// Will round value up or down if necessary.
        /// CultureInfo set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToPercentExt(this float num, int decimals = 2) => num.ToString($"P{decimals}", System.Globalization.CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts int to a percent string.
        /// 2 => "200.00%"
        /// Optional parameter specifies how many decimals out return. Default value is 2 decimal places.
        /// Will round value up or down if necessary.
        /// CultureInfo set to CurrentCulture.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToPercentExt(this int num, int decimals = 2) => num.ToString($"P{decimals}", System.Globalization.CultureInfo.CurrentCulture);
    }
}
