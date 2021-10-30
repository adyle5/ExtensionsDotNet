// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System.Diagnostics;

namespace Extensions.net
{
    public static class BooleanExtensions
    {
        /// <summary>
        /// Maps to bool.TryParse
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static void TryParseExt(this ref bool output, string input) => bool.TryParse(input, out output);

        /// <summary>
        /// Maps to bool.Parse
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static void ParseExt(this ref bool output, string input) => output = bool.Parse(input);

        /// <summary>
        /// Maps to bool.Equals
        /// </summary>
        /// <param name="output"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool EqualsExt(this bool output, bool input) => bool.Equals(output, input);

        /// <summary>
        /// If extended object's condition is false, will output a message to the trace listener.
        /// Maps to Trace.Assert
        /// </summary>
        /// <param name="condition"></param>
        public static void AssertExt(this bool condition) => Trace.Assert(condition);

        /// <summary>
        /// If extended object's condition is false, will output provided message to the trace listener.
        /// Maps to Trace.Assert
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="shortMessage"></param>
        public static void AssertExt(this bool condition, string shortMessage) => Trace.Assert(condition, shortMessage);

        /// <summary>
        /// If extended object's condition is false, will output provided message to the trace listener.
        /// Maps to Trace.Assert
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="shortMessage"></param>
        /// <param name="detailedMessage"></param>
        public static void AssertExt(this bool condition, string shortMessage, string detailedMessage) => Trace.Assert(condition, shortMessage, detailedMessage);
    }
}
