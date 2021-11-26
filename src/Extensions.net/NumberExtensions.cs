// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Collections.Generic;

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
        public static DateTime ToDateTimeExt(this long ticks) => new(ticks);

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

        /// <summary>
        /// Creates a range of integers starting with the extended type through the count parameter.
        /// Maps to Enumerable.Range
        /// </summary>
        /// <param name="num"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<int> ToRangeExt(this int num, int count) => System.Linq.Enumerable.Range(num, count);

        /// <summary>
        /// Rearranges the individual numbers in an integer.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int ShuffleExt(this int number)
        {
            if (number <= 9)
                return number;

            string numString = number.ToString();
            string shuffledString = numString.ShuffleExt();
            return shuffledString.ToIntExt();
        }

        /// <summary>
        /// Creates a list of integers from the individual numbers in the extended int.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> ToListExt(this int number)
        {
            List<int> lsInt = new ();
            foreach (char cc in Math.Abs(number).ToString().ToCharArray())
            {
                lsInt.Add(cc.ToString().ToIntExt());
            }

            return lsInt;
        }

        /// <summary>
        /// Maps to BitConverter.DoubleToInt64Bits
        /// Converts the extended double to a 64 bit signed integer (lon).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToInt64BitsExt(this double value) => BitConverter.DoubleToInt64Bits(value);

        /// <summary>
        /// Compares the extended integer to an array of integers.
        /// Returns true if the extended integer is greater than all the integers in the array and false if the extended integer is less than or equal to all the integers in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsGreaterThanExt(this int value, int[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value <= comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended integer to an array of integers.
        /// Returns true if the extended integer is greater than or equal to all the integers in the array and false if the extended integer is less than all the integers in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsGreaterThanEqualToExt(this int value, int[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value < comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended integer to an array of integers.
        /// Returns true if the extended integer is less than all the integers in the array and false if the extended integer is greater than or equal to all the integers in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsLessThanExt(this int value, int[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value >= comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended integer to an array of integers.
        /// Returns true if the extended integer is less than or equal to all the integers in the array and false if the extended integer is greater than all the integers in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsLessThanEqualToExt(this int value, int[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value > comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended double to an array of doubles.
        /// Returns true if the extended double is greater than all the doubles in the array and false if the extended double is less than or equal to all the doubles in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsGreaterThanExt(this double value, double[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value <= comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended double to an array of doubles.
        /// Returns true if the extended double is greater than or equal to all the doubles in the array and false if the extended double is less than all the doubles in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsGreaterThanEqualToExt(this double value, double[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value < comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended double to an array of doubles.
        /// Returns true if the extended double is less than all the doubles in the array and false if the extended double is greater than or equal to all the doubles in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsLessThanExt(this double value, double[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value >= comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended double to an array of doubles.
        /// Returns true if the extended double is less than or equal to all the doubles in the array and false if the extended double is less than all the doubles in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsLessThanEqualToExt(this double value, double[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value > comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended decimal to an array of decimals.
        /// Returns true if the extended decimal is greater than all the decimals in the array and false if the extended decimal is less than or equal to all the decimals in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsGreaterThanExt(this decimal value, decimal[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value <= comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended decimal to an array of decimals.
        /// Returns true if the extended decimal is greater than or equal to all the decimals in the array and false if the extended decimal is less than all the decimals in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsGreaterThanEqualToExt(this decimal value, decimal[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value < comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended decimal to an array of decimals.
        /// Returns true if the extended decimal is less than all the decimals in the array and false if the extended decimal is greater than or equal to all the decimals in the array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsLessThanExt(this decimal value, decimal[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value >= comparer[i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the extended decimal to an array of decimals.
        /// Returns true if the extended decimal is less than or equal to all the decimals in the array and false if the extended decimal is less than all the decimals in the array. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static bool IsLessThanEqualToExt(this decimal value, decimal[] comparer)
        {
            for (int i = 0; i < comparer.Length; i++)
            {
                if (value > comparer[i])
                    return false;
            }

            return true;
        }
    }
}
