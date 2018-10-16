using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.net.numbers
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
        /// Maps to Convert.ToDouble
        /// </summary>
        /// <param name="num"></param>
        /// <param name="output"></param>
        public static double ToDoubleExt(this int num) => Convert.ToDouble(num);

        /// <summary>
        /// Maps to Convert.ToSingle
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Single ToSingleExt(this int num) => Convert.ToSingle(num);
    }
}
