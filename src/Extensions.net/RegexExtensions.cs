// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Text.RegularExpressions;

namespace Extensions.net.RegularExpressions
{
    public static class RegexExtensions
    {
        #region Matches
        /// <summary>
        /// Checks if string starts with the string argument
        /// Case sensitive.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static string StartsWithExt(this string text, string start) => text.IsNullOrEmptyExt() || start.IsNullOrEmptyExt() ? null : Regex.Match(text, @$"^{start}", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string starts with the string argument
        /// Case insensitive.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static string StartsWithCaseInsensitiveExt(this string text, string start) => text.IsNullOrEmptyExt() || start.IsNullOrEmptyExt() ? null : Regex.Match(text, @$"^(?i){start}", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string ends with the string argument
        /// Case sensitive.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string EndsWithExt(this string text, string end) => text.IsNullOrEmptyExt() || end.IsNullOrEmptyExt() ? null : Regex.Match(text, $@"{end}$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string ends with the string argument
        /// Case insensitive.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string EndsWithCaseInsensitiveExt(this string text, string end) => text.IsNullOrEmptyExt() || end.IsNullOrEmptyExt() ? null : Regex.Match(text , $@"(?i){end}$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string contains a number.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ContainsNumberExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text, @"\d", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string contains no numbers.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ContainsNoNumberExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text, @"^[^0-9]+$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string contains a capital letter.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ContainsCapitalLetterExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text, @"(?=.*[A-Z])", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string contains lowercase letter.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ContainsLowerCaseLetterExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text, @"(?=.*[a-z])", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string contains a special character (ASCII).
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain. 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ContainsSpecialCharacterExt(this string text) => text.IsNullOrEmptyExt()? null : Regex.Match(text, @"(?=.*[~`!@#$%^&*()\-_=+\[{\]}\\|;:'"",<.>/?])", RegexOptions.IgnorePatternWhitespace).Success? text : null;

        /// <summary>
        /// Checks if string excludes the string argument.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="exclusion"></param>
        /// <returns></returns>
        public static string ExcludesExt(this string text, string exclusion) => text.IsNullOrEmptyExt() ? null : Regex.Match(text, @$"^((?!{exclusion}).)*$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string excludes the char argument.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="exclusion"></param>
        /// <returns></returns>
        public static string ExcludesExt(this string text, char exclusion) => text.IsNullOrEmptyExt() ? null : Regex.Match(text, @$"^((?!{exclusion}).)*$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        /// <summary>
        /// Checks if string is a valid phone number (USA).
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain. 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string IsValidPhoneNumberExt(this string number) => 
            number.IsNullOrWhiteSpaceExt() 
            ? null 
            : Regex.Match(number, @"^\d{10}$", RegexOptions.IgnorePatternWhitespace).Success 
                ? number 
                : null;

        /// <summary>
        /// Checks if string is a valid email address.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string IsValidEmailExt(this string email) => 
            email.IsNullOrWhiteSpaceExt() 
            ? null 
            : Regex.Match(email, @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,10}[a-zA-Z0-9])?)*$").Success 
                ? email 
                : null;

        /// <summary>
        /// Checks if string is a valid IP address.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string IsValidIPAddressExt(this string address) => 
            address.IsNullOrWhiteSpaceExt() 
            ? null 
            : Regex.Match(address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$").Success 
                ? address 
                : null;

        /// <summary>
        /// Returns a string if all characters inside the string are either numbers or letters, otherwise returns null. 
        /// All characters evaluated including blank spaces.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string IsAlphaNumericExt(this string text) =>
            text is null ? null : Regex.Match(text, @"^[a-zA-Z0-9]+$").Success ? text : null;

        /// <summary>
        /// Returns a string if all characters inside the string are letters, otherwise returns null. 
        /// All characters evaluated including blank spaces.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string IsAlphaExt(this string text) => 
            text is null ? null : Regex.Match(text, @"^[a-zA-Z]+$").Success ? text : null;

        /// <summary>
        /// Returns a string if all characters inside the string are numeric, otherwise returns null. 
        /// A decimal number returns false since it contains a non-numeric character (period).
        /// All characters evaluated including blank spaces.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string IsNumericExt(this string text) => 
            text is null ? null : Regex.Match(text, @"^[0-9]+$").Success ? text : null;

        #endregion

        #region Replaces

        /// <summary>
        /// If the string is a valid phone number, formats the string in the following pattern (###) ###-####.
        /// Returns null if there is no match, otherwise returns the original string.
        /// Can be chained with other regex extensions.
        /// ProcessRegexExt must be called at the end of the extension chain.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string FormatPhoneNumberExt(this string number) => 
            number.IsNullOrWhiteSpaceExt() || !number.IsValidPhoneNumberExt().ProcessRegexExt() 
                ? throw new ArgumentNullException(nameof(number)) 
                : Regex.Replace(number, @"^(\d{3})(\d{3})(\d{4})", "($1) $2-$3", RegexOptions.IgnorePatternWhitespace);

        #endregion

        /// <summary>
        /// Must be called at the end of a match regex extensions chain to return whether the match(es) were true or false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool ProcessRegexExt(this string text) => !text.IsNullOrEmptyExt();
    }
}
