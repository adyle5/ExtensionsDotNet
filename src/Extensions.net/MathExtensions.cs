// Copyright © 2022 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;

namespace Extensions.net
{
    public static class MathExtensions
    {
        /// <summary>
        /// Adds n number of integers to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static int AddExt(this int num, params int[] add)
        {
            for (int i = 0; i < add.Length; i++)
            {
                num += add[i];
            }

            return num;
        }

        /// <summary>
        /// Adds n number of doubles to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static double AddExt(this double num, params double[] add)
        {
            for (int i = 0; i < add.Length; i++)
            {
                num += add[i];
            }

            return num;
        }

        /// <summary>
        /// Adds n number of decimals to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public static decimal AddExt(this decimal num, params decimal[] add)
        {
            for (int i = 0; i < add.Length; i++)
            {
                num += add[i];
            }

            return num;
        }

        /// <summary>
        /// Subtracts n number of integers to the target integer. 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        public static int SubtractExt(this int num, params int[] sub)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                num -= sub[i];
            }

            return num;
        }

        /// <summary>
        /// Subtracts n number of doubles to the target integer. 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        public static double SubtractExt(this double num, params double[] sub)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                num -= sub[i];
            }

            return num;
        }

        /// <summary>
        /// Subtracts n number of decimals to the target integer. 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        public static decimal SubtractExt(this decimal num, params decimal[] sub)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                num -= sub[i];
            }

            return num;
        }

        /// <summary>
        /// Multiplies n number of integers to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="mul"></param>
        /// <returns></returns>
        public static int MultiplyExt(this int num, params int[] mul)
        {
            for (int i = 0; i < mul.Length; i++)
            {
                num *= mul[i];
            }

            return num;
        }

        /// <summary>
        /// Multiplies n number of doubles to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="mul"></param>
        /// <returns></returns>
        public static double MultiplyExt(this double num, params double[] mul)
        {
            for (int i = 0; i < mul.Length; i++)
            {
                num *= mul[i];
            }

            return num;
        }

        /// <summary>
        /// Multiplies n number of decimals to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="mul"></param>
        /// <returns></returns>
        public static decimal MultiplyExt(this decimal num, params decimal[] mul)
        {
            for (int i = 0; i < mul.Length; i++)
            {
                num *= mul[i];
            }

            return num;
        }

        /// <summary>
        /// Divides n number of integers to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static int DivideExt(this int num, params int[] div)
        {
            for (int i = 0; i < div.Length; i++)
            {
                num /= div[i];
            }

            return num;
        }

        /// <summary>
        /// Divides n number of doubles to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static double DivideExt(this double num, params double[] div)
        {
            for (int i = 0; i < div.Length; i++)
            {
                num /= div[i];
            }

            return num;
        }

        /// <summary>
        /// Divides n number of integers to the target integer.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="div"></param>
        /// <returns></returns>
        public static decimal DivideExt(this decimal num, params decimal[] div)
        {
            for (int i = 0; i < div.Length; i++)
            {
                num /= div[i];
            }

            return num;
        }

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal AbsExt(this decimal value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double AbsExt(this double value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static short AbsExt(this short value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int AbsExt(this int value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long AbsExt(this long value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static sbyte AbsExt(this sbyte value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Abs (Absolute Value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float AbsExt(this float value) => Math.Abs(value);

        /// <summary>
        /// Maps to Math.Acos
        /// MSDN: "Returns the angle whose cosine is the specified number."
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AcosExt(this double d) => Math.Acos(d);

        /// <summary>
        /// Maps to Math.Asin
        /// MSDN: "Returns the angle whose sine is the specified number."
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AsinExt(this double d) => Math.Asin(d);

        /// <summary>
        /// Maps to Math.Atan
        /// MSDN: "Returns the angle whose tangent is the specified number."
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AtanExt(this double d) => Math.Atan(d);

        /// <summary>
        /// Maps to Math.Atan2
        /// MSDN: "Returns the angle whose tangent is the quotient of two specified numbers."
        /// </summary>
        /// <param name="y"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Atan2Ext(this double y, double x) => Math.Atan2(y, x);

        /// <summary>
        /// Maps to Math.Ceiling
        /// Returns a double that is the smallest integral value larger than the source double.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double CeilingExt(this double a) => Math.Ceiling(a);

        /// <summary>
        /// Maps to Math.Ceiling
        /// Returns a decimal that is the smallest integral value larger than the source decimal.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static decimal CeilingExt(this decimal d) => Math.Ceiling(d);

        /// <summary>
        /// Maps to Math.Cos
        /// Returns the cosine of the source angle.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double CosExt(this double d) => Math.Cos(d);

        /// <summary>
        /// Maps to Math.Cosh
        /// Returns the hyperbolic cosine of the source angle.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double CoshExt(this double d) => Math.Cosh(d);

        /// <summary>
        /// Maps to Math.Exp
        /// Returns e raised to the power of the source double. e represents Euler's number. (https://en.wikipedia.org/wiki/E_%28mathematical_constant%29)
        /// MSDN: "If d equals NaN or PositiveInfinity, that value is returned. If d equals NegativeInfinity, 0 is returned."
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double ExpExt(this double d) => Math.Exp(d);

        /// <summary>
        /// Maps to Math.Floor
        /// Returns a decimal that is the first integral value larger than the source decimal.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static decimal FloorExt(this decimal d) => Math.Floor(d);

        /// <summary>
        /// Maps to Math.Floor
        /// Returns a double that is the first integral value larger than the source double.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double FloorExt(this double d) => Math.Floor(d);

        /// <summary>
        /// Maps to Math.IEEERemainder
        /// Returns the remainder resulting from the division of x/y.
        /// For more information: https://docs.microsoft.com/en-us/dotnet/api/system.math.ieeeremainder?view=netframework-4.7.2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double IEEERemainderExt(this double x, double y) => Math.IEEERemainder(x, y);

        /// <summary>
        /// Maps to Math.Log
        /// Returns the natural logarithm of the source number.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double LogExt(this double d) => Math.Log(d);

        /// <summary>
        /// Maps to Math.Log
        /// Returns the logarithm of the source number in a new base.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="newBase"></param>
        /// <returns></returns>
        public static double LogExt(this double a, double newBase) => Math.Log(a, newBase);

        /// <summary>
        /// Maps to Math.Log10
        /// Returns base 10 logarith of the source number.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double Log10Ext(this double d) => Math.Log10(d);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source sbyte and the parameter sbyte.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static sbyte MaxExt(this sbyte val1, sbyte val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source uint and the parameter uint.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static uint MaxExt(this uint val1, uint val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source ushort and the parameter ushort.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static ushort MaxExt(this ushort val1, ushort val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source float and the parameter float.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static float MaxExt(this float val1, float val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source long and the parameter long.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static long MaxExt(this long val1, long val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source ulong and the parameter ulong.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static ulong MaxExt(this ulong val1, ulong val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source short and the parameter short.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static short MaxExt(this short val1, short val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source double and the parameter double.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static double MaxExt(this double val1, double val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source decimal and the parameter decimal.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static decimal MaxExt(this decimal val1, decimal val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source byte and the parameter byte.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static byte MaxExt(this byte val1, byte val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Max
        /// Returns the larger of the source int and the parameter int.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static int MaxExt(this int val1, int val2) => Math.Max(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source sbyte and the parameter sbyte.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static sbyte MinExt(this sbyte val1, sbyte val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source uint and the parameter uint.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static uint MinExt(this uint val1, uint val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source ushort and the parameter ushort.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static ushort MinExt(this ushort val1, ushort val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source float and the parameter float.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static float MinExt(this float val1, float val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source long and the parameter long.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static long MinExt(this long val1, long val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source ulong and the parameter ulong.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static ulong MinExt(this ulong val1, ulong val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source short and the parameter short.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static short MinExt(this short val1, short val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source double and the parameter double.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static double MinExt(this double val1, double val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source decimal and the parameter decimal.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static decimal MinExt(this decimal val1, decimal val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source byte and the parameter byte.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static byte MinExt(this byte val1, byte val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Min
        /// Returns the smaller of the source int and the parameter int.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public static int MinExt(this int val1, int val2) => Math.Min(val1, val2);

        /// <summary>
        /// Maps to Math.Pow
        /// Raises the source double to the power of the parameter double
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double PowExt(this double x, double y) => Math.Pow(x, y);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value. Midway rounding parameter determines if round up or down if value in the middle.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static double RoundExt(this double value, MidpointRounding mode) => Math.Round(value, mode);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value. Midway rounding parameter determines if round up or down if value in the middle. Decimals parameter determing how many decimal places out to round to. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static double RoundExt(this double value, int decimals, MidpointRounding mode) => Math.Round(value, decimals, mode);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value. Decimals parameter determing how many decimal places out to round to. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static double RoundExt(this double value, int decimals) => Math.Round(value, decimals);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static double RoundExt(this double a) => Math.Round(a);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value. Midway rounding parameter determines if round up or down if value in the middle.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static decimal RoundExt(this decimal value, MidpointRounding mode) => Math.Round(value, mode);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value. Midway rounding parameter determines if round up or down if value in the middle. Decimals parameter determing how many decimal places out to round to. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static decimal RoundExt(this decimal value, int decimals, MidpointRounding mode) => Math.Round(value, decimals, mode);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value. Decimals parameter determing how many decimal places out to round to. 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static decimal RoundExt(this decimal value, int decimals) => Math.Round(value, decimals);

        /// <summary>
        /// Maps to Math.Round
        /// Rounds to the nearest integral value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static decimal RoundExt(this decimal a) => Math.Round(a);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this float value) => Math.Sign(value);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this long value) => Math.Sign(value);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this int value) => Math.Sign(value);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this sbyte value) => Math.Sign(value);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this double value) => Math.Sign(value);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this decimal value) => Math.Sign(value);

        /// <summary>
        /// Math.Sign
        /// Returns -1 if number is negative, 1 if the number is positive, or 0 if the number is 0.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int SignExt(this short value) => Math.Sign(value);

        /// <summary>
        /// Maps to Math.Sin
        /// Returns the sine of the source double (angle).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double SinExt(this double a) => Math.Sin(a);

        /// <summary>
        /// Maps to Math.Sinh
        /// Returns the hyperbolic sine of the source double (angle).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double SinhExt(this double value) => Math.Sinh(value);

        /// <summary>
        /// Maps to Math.Sqrt
        /// Returns the square root of the source double
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double SqrtExt(this double d) => Math.Sqrt(d);

        /// <summary>
        /// Maps to Math.Tan
        /// Returns the tangent of the source double (angle).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double TanExt(this double a) => Math.Tan(a);

        /// <summary>
        /// Maps to Math.Tanh
        /// Returns the hyperbolic tangent of the source double (angle).
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double TanhExt(this double a) => Math.Tanh(a);

        /// <summary>
        /// Maps to Math.Truncate
        /// Returns the integer part of the source decimal (the part to the left of the decimal point).
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static decimal TruncateExt(this decimal d) => Math.Truncate(d);

        /// <summary>
        /// Maps to Math.Truncate
        /// Returns the integer part of the source double (the part to the left of the decimal point).
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double TruncateExt(this double d) => Math.Truncate(d);

        /// <summary>
        /// Calculates the area of a circle when the extended number is the radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double AreaOfCircleExt(this double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculates the area of a circle when the extended number is the radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double AreaOfCircleExt(this int radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculates the area of a triangle wher the extended double is the base, and the double parameter is the height.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double AreaOfTriangleExt(this double b, double height)
        {
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "base must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return (b * height) / 2;
        }

        /// <summary>
        /// Calculates the area of a triangle wher the extended int is the base, and the int parameter is the height.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double AreaOfTriangleExt(this int b, int height)
        {
            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "base must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return (b * height) / 2;
        }

        /// <summary>
        /// Calculates the area of a rectangle where the extended number is the length and the parameter is the width.
        /// Works the other way around too.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static double AreaOfRectangleExt(this int length, int width)
        {
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length), "length must be greater than or equal to zero");

            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "width must be greater than or equal to zero");

            return length * width;
        }

        /// <summary>
        /// Calculates the area of a rectangle where the extended number is the length and the parameter is the width.
        /// Works the other way around too. 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static double AreaOfRectangleExt(this double length, double width)
        {
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length), "length must be greater than or equal to zero");

            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "width must be greater than or equal to zero");

            return length * width;
        }

        /// <summary>
        /// Calculates the circumference of a circle when the extended number is the radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CircumferenceOfCircleExt(this double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            return (2 * Math.PI) * radius;
        }

        /// <summary>
        /// Calculates the circumference of a circle when the extended number is the radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CircumferenceOfCircleExt(this int radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            return (2 * Math.PI) * radius;
        }

        /// <summary>
        /// Calculates the length of a circle arc where the extended value is the radius and the paramater is the central angle.
        /// Central angle is is degrees.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="centralAngle"></param>
        /// <returns></returns>
        public static double ArcLengthExt(this double radius, double centralAngle)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            if (centralAngle <= 0)
                throw new ArgumentOutOfRangeException(nameof(centralAngle), "central angle must be greater than or equal to zero");

            return 2 * Math.PI * radius * (centralAngle / 360);
        }

        /// <summary>
        /// Calculates the length of a circle arc where the extended value is the radius and the paramater is the central angle.
        /// Central angle is is degrees.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="centralAngle"></param>
        /// <returns></returns>
        public static double ArcLengthExt(this int radius, int centralAngle)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            if (centralAngle <= 0)
                throw new ArgumentOutOfRangeException(nameof(centralAngle), "central angle must be greater than or equal to zero");

            return  2 * Math.PI * radius * ((double)centralAngle / 360);
        }

        /// <summary>
        /// Calculates the hypotenus of a triangle where leg1 is the extended value and leg2 is the parameter.
        /// </summary>
        /// <param name="leg1"></param>
        /// <param name="leg2"></param>
        /// <returns></returns>
        public static double HypotenuseExt(this double leg1, double leg2)
        {
            if (leg1 <= 0)
                throw new ArgumentOutOfRangeException(nameof(leg1), "side must be greater than or equal to zero");

            if (leg2 <= 0)
                throw new ArgumentOutOfRangeException(nameof(leg2), "side must be greater than or equal to zero");

            return Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2));
        }

        /// <summary>
        /// Calculates the hypotenus of a triangle where leg1 is the extended value and leg2 is the parameter. 
        /// </summary>
        /// <param name="leg1"></param>
        /// <param name="leg2"></param>
        /// <returns></returns>
        public static double HypotenuseExt(this int leg1, int leg2)
        {
            if (leg1 <= 0)
                throw new ArgumentOutOfRangeException(nameof(leg1), "side must be greater than or equal to zero");

            if (leg2 <= 0)
                throw new ArgumentOutOfRangeException(nameof(leg2), "side must be greater than or equal to zero");

            return Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2));
        }        

        /// <summary>
        /// Calculates the volume of a cylinder.
        /// Extended value is the radius of the base and parameter is the height of the cylinder.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double VolumeOfCylinderExt(this int radius, int height) 
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return Math.PI * Math.Pow(radius, 2) * height; 
        }

        /// <summary>
        /// Calculates the volume of a cylinder.
        /// Extended value is the radius of the base and parameter is the height of the cylinder.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double VolumeOfCylinderExt(this double radius, double height)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return Math.PI * Math.Pow(radius, 2) * height;
        }

        /// <summary>
        /// Calculates the volume of a sphere where the extended value is the radius.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double VolumeOfSphereExt(this int radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Calculates the volume of a sphere where the extended value is the radius. 
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double VolumeOfSphereExt(this double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Calculates the volume of a cone where the entended number is the radius and the paramater is the height.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double VolumeOfConeExt(this int radius, int height)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return Math.PI * (Math.Pow(radius, 2) * (height / 3.0));
        }

        /// <summary>
        /// Calculates the volume of a cone where the entended number is the radius and the paramater is the height. 
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double VolumeOfConeExt(this double radius, double height) 
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return Math.PI * (Math.Pow(radius, 2) * (height / 3.0)); 
        }

        /// <summary>
        /// Calculates the area of a trapezoid where the extended value is the height and paramaters a & b are the bases.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double AreaOfTrapezoidExt(this int height, int a, int b)
        {
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), "a must be greater than or equal to zero");

            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "b must be greater than or equal to zero");

            return (a + b) / 2.0 * height;
        }

        /// <summary>
        /// Calculates the area of a trapezoid where the extended value is the height and paramaters a & b are the bases. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double AreaOfTrapezoidExt(this double height, double a, double b)
        {
            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            if (a <= 0)
                throw new ArgumentOutOfRangeException(nameof(a), "a must be greater than or equal to zero");

            if (b <= 0)
                throw new ArgumentOutOfRangeException(nameof(b), "b must be greater than or equal to zero");

            return (a + b) / 2.0 * height;
        }

        /// <summary>
        /// Returns the volume of a pyramid where the extended value is one side of the pyramid and the parameters are the other side and the height.
        /// Also works when the width is the extended value and the length is the first parameter.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double VolumeOfPyramidExt(this int length, int width, int height)
        {
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length), "length must be greater than or equal to zero");

            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "width must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height must be greater than or equal to zero");

            return (length * width * height) / 3.0;
        }

        /// <summary>
        /// Returns the volume of a pyramid where the extended value is one side of the pyramid and the parameters are the other side and the height. 
        /// Also works when the width is the extended value and the length is the first parameter.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double VolumeOfPyramidExt(this double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentOutOfRangeException(nameof(side1), "length, width, and height must be greater than or equal to zero");

            return (side1 * side2 * side3) / 3.0;
        }

        /// <summary>
        /// Calculates the edge of a cube.
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double VolumeOfCubeExt(this int edge)
        {
            if (edge <= 0)
                throw new ArgumentOutOfRangeException(nameof(edge), "edge of cube must be greater than or equal to zero");

            return Math.Pow(edge, 3);
        }

        /// <summary>
        /// Calculates the edge of a cube.
        /// </summary>
        /// <param name="edge"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double VolumeOfCubeExt(this double edge)
        {
            if (edge <= 0)
                throw new ArgumentOutOfRangeException(nameof(edge), "edge of cube must be greater than or equal to zero");

            return Math.Pow(edge, 3);
        }

        /// <summary>
        /// Returns the area of a cylinder where the extended value is the radius and the parameter is the height.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double AreaOfCylinderExt(this int radius, int height)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius of cube must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height of cube must be greater than or equal to zero");

            return (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
        }

        /// <summary>
        /// Returns the area of a cylinder where the extended value is the radius and the parameter is the height.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double AreaOfCylinderExt(this double radius, double height)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "radius of cube must be greater than or equal to zero");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "height of cube must be greater than or equal to zero");

            return (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
        }

        /// <summary>
        /// Maps to Math.DivRem
        /// Returns the quotient as a long and also returns the remainder as an out parameter of two integers, a dividend and a divisor.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <param name="remainder"></param>
        /// <returns></returns>
        public static int DivRemExt(this int dividend, int divisor, out int remainder) => Math.DivRem(dividend, divisor, out remainder);

        /// <summary>
        /// Maps to Math.DivRem
        /// Returns the quotient as an int and also returns the remainder as an out parameter of two longs, a dividend and a divisor.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <param name="remainder"></param>
        /// <returns></returns>
        public static long DivRemExt(this long dividend, long divisor, out long remainder) => Math.DivRem(dividend, divisor, out remainder);

        /// <summary>
        /// Maps to Math.DivRem
        /// Returns the quotient as an intand also returns the remainder as an integer out parameter of two bytes, a dividend and a divisor.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <param name="remainder"></param>
        /// <returns></returns>
        public static int DivRemExt(this byte dividend, byte divisor, out int remainder) => Math.DivRem(dividend, divisor, out remainder);
    }
}
