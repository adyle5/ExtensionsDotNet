// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

namespace Extensions.net
{
    public static class CharExtensions
    {
        /// <summary>
        /// Returns uppercase of extended char.
        /// Maps to char.ToUpper
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char ToUpperExt(this char c) => char.ToUpper(c);

        /// <summary>
        /// Returns invariant uppercase of extended char.
        /// Maps to char.ToUpperInvariant
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char ToUpperInvariantExt(this char c) => char.ToUpperInvariant(c);

        /// <summary>
        /// Returns true if extended char is uppercase letter, otherwise returns false.
        /// Maps to char.IsUpper
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsUpperExt(this char c) => char.IsUpper(c);

        /// <summary>
        /// Returns lowercase of extended char.
        /// Maps to char.ToLower
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char ToLowerExt(this char c) => char.ToLower(c);

        /// <summary>
        /// Returns invariant lowercase of extended char.
        /// Maps to char.ToLowerInvariant
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char ToLowerInvariantExt(this char c) => char.ToLowerInvariant(c);

        /// <summary>
        /// Returns true if extended char is lowercase letter, otherwise returns false.
        /// Maps to char.IsLower
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsLowerExt(this char c) => char.IsLower(c);

        /// <summary>
        /// Returns true if extended char is a control character, otherwise returns false.
        /// Maps to char.IsControl
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsControlCharacterExt(this char c) => char.IsControl(c);

        /// <summary>
        /// Returns true if extended char is a white space, otherwise returns false.
        /// Maps to char.IsWhiteSpace
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsWhiteSpaceExt(this char c) => char.IsWhiteSpace(c);

        /// <summary>
        /// Returns true if extended char is a decimal digit, otherwise returns false.
        /// Maps to char.IsDigit
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsDigitExt(this char c) => char.IsDigit(c);

        /// <summary>
        /// Returns true if extended char is a letter, otherwise returns false.
        /// Maps to char.IsLetter
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsLetterExt(this char c) => char.IsLetter(c);

        /// <summary>
        /// Returns true if extended char is a letter or decimal digit, otherwise returns false.
        /// Maps to char.IsLetterOrDigit
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsLetterOrDigitExt(this char c) => char.IsLetterOrDigit(c);

        /// <summary>
        /// Returns true if extended char is a number, otherwise returns false.
        /// Maps to char.IsNumber
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsNumberExt(this char c) => char.IsNumber(c);

        /// <summary>
        /// Returns true if extended char is a punctuation mark, otherwise returns false.
        /// Maps to char.IsPunctuation
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsPunctuationExt(this char c) => char.IsPunctuation(c);

        /// <summary>
        /// Returns true if extended char is a separator character, otherwise returns false.
        /// Maps to char.IsSeparator
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsSeparatorExt(this char c) => char.IsSeparator(c);

        /// <summary>
        /// Returns true if extended char is a symbol character, otherwise returns false.
        /// Maps to char.IsSymbol
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsSymbolExt(this char c) => char.IsSymbol(c);

        /// <summary>
        /// Returns true if extended char is a surrogate code unit, otherwise returns false.
        /// Maps to char.IsSurrogate
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsSurrogateExt(this char c) => char.IsSurrogate(c);

        /// <summary>
        /// Returns true if extended char is a high surrogate code unit, otherwise returns false.
        /// Maps to char.IsHighSurrogate
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsHighSurrogateExt(this char c) => char.IsHighSurrogate(c);

        /// <summary>
        /// Returns true if extended char is a low surrogate code unit, otherwise returns false.
        /// Maps to char.IsLowSurrogate
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsLowSurrogateExt(this char c) => char.IsLowSurrogate(c);

        /// <summary>
        /// Returns true if the extended char is the smallest possible char value, otherwise returns false.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsMinValueExt(this char c) => c == char.MinValue;

        /// <summary>
        /// Returns true if the extended char is the largest possible char value, otherwise returns false.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsMaxValueExt(this char c) => c == char.MaxValue;
    }
}
