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
    }
}
