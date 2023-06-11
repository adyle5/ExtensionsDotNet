// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Extensions.net
{
    public static class RegexExtensions
    {
        public static string StartsWithExt(this string text, string start) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @$"^{start}", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string StartsWithCaseInsensitiveExt(this string text, string start) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @$"^(?i){start}", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string EndsWithExt(this string text, string end) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", $@"{end}$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string EndsWithCaseInsensitiveExt(this string text, string end) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", $@"(?i){end}$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string ContainsNumberExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @"\d", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string ContainsNoNumberExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @"^[^0-9]+$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string ContainsCapitalLetterExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @"(?=.*[A-Z])", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string ContainsLowerCaseLetterExt(this string text) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @"(?=.*[a-z])", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string ContainsSpecialCharacterExt(this string text) => text.IsNullOrEmptyExt()? null : Regex.Match(text ?? "", @"(?=.*[~`!@#$%^&*()\-_=+\[{\]}\\|;:'"",<.>/?])", RegexOptions.IgnorePatternWhitespace).Success? text : null;

        public static string ExcludesExt(this string text, string exclusion) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @$"^((?!{exclusion}).)*$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static string ExcludesExt(this string text, char exclusion) => text.IsNullOrEmptyExt() ? null : Regex.Match(text ?? "", @$"^((?!{exclusion}).)*$", RegexOptions.IgnorePatternWhitespace).Success ? text : null;

        public static bool ProcessRegexExt(this string text) => text.IsNullOrEmptyExt() ? false : true;
    }
}
