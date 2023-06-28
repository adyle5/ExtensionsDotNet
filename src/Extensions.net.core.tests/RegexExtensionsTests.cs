// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using Xunit;
using Extensions.net.RegularExpressions;

namespace Extensions.net.core.tests.UnitTests
{
    public class RegexExtensionsTests
    {
        [Fact]
        public void StartsWith()
        {
            string target = "Cherries";
            string pattern = "Cher";
            Assert.True(target.StartsWithExt(pattern).ProcessRegexExt());

            pattern = "cher";
            Assert.False(target.StartsWithExt(pattern).ProcessRegexExt());

            string antipattern = "app";
            Assert.False(target.StartsWithExt(antipattern).ProcessRegexExt());

            string nullpattern = null;
            Assert.False(target.StartsWithExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.False(target.StartsWithExt(emptypattern).ProcessRegexExt());
        }

        [Fact]
        public void StartsWithCaseInsensitive()
        {
            string target = "Cherries";
            string pattern = "CHeR";
            Assert.True(target.StartsWithCaseInsensitiveExt(pattern).ProcessRegexExt());

            pattern = "cherr";
            Assert.True(target.StartsWithCaseInsensitiveExt(pattern).ProcessRegexExt());

            pattern = "CHER";
            Assert.True(target.StartsWithCaseInsensitiveExt(pattern).ProcessRegexExt());

            string antipattern = "APP";
            Assert.False(target.StartsWithExt(antipattern).ProcessRegexExt());

            string nullpattern = null;
            Assert.False(target.StartsWithExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.False(target.StartsWithExt(emptypattern).ProcessRegexExt());
        }

        [Fact]
        public void EndsWith()
        {
            string target = "Cherries";
            string pattern = "ries";
            Assert.True(target.EndsWithExt(pattern).ProcessRegexExt());

            pattern = "RIES";
            Assert.False(target.EndsWithExt(pattern).ProcessRegexExt());

            string antipattern = "app";
            Assert.False(target.EndsWithExt(antipattern).ProcessRegexExt());

            string nullpattern = null;
            Assert.False(target.EndsWithExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.False(target.EndsWithExt(emptypattern).ProcessRegexExt());
        }

        [Fact]
        public void EndsWithCaseInsensitive()
        {
            string target = "Cherries";
            string pattern = "ries";
            Assert.True(target.EndsWithCaseInsensitiveExt(pattern).ProcessRegexExt());

            pattern = "RIES";
            Assert.True(target.EndsWithCaseInsensitiveExt(pattern).ProcessRegexExt());

            pattern = "Ries";
            Assert.True(target.EndsWithCaseInsensitiveExt(pattern).ProcessRegexExt());

            string antipattern = "rie";
            Assert.False(target.EndsWithCaseInsensitiveExt(antipattern).ProcessRegexExt());

            string nullpattern = null;
            Assert.False(target.EndsWithCaseInsensitiveExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.False(target.EndsWithCaseInsensitiveExt(emptypattern).ProcessRegexExt());
        }

        [Fact]
        public void ContainsNumber()
        {
            string target = "Cherries1";
            Assert.True(target.ContainsNumberExt().ProcessRegexExt());

            target = "Cherries";
            Assert.False(target.ContainsNumberExt().ProcessRegexExt());
        }

        [Fact]
        public void ContainsNoNumber()
        {
            string target = "Cherries1";
            Assert.False(target.ContainsNoNumberExt().ProcessRegexExt());

            target = "Cherries";
            Assert.True(target.ContainsNoNumberExt().ProcessRegexExt());
        }

        [Fact]
        public void ContainsCapitalLetter()
        {
            string target = "Cherries";
            Assert.True(target.ContainsCapitalLetterExt().ProcessRegexExt());

            target = "cherries";
            Assert.False(target.ContainsCapitalLetterExt().ProcessRegexExt());
        }

        [Fact]
        public void ContainsLowerCaseLetter()
        {
            string target = "Cherries";
            Assert.True(target.ContainsLowerCaseLetterExt().ProcessRegexExt());

            target = "CHERRIES";
            Assert.False(target.ContainsLowerCaseLetterExt().ProcessRegexExt());
        }

        [Fact]
        public void ConstainsSpecialCharacter()
        {
            string target = "Cher*ries";
            Assert.True(target.ContainsSpecialCharacterExt().ProcessRegexExt());

            target = "Cher\"ries";
            Assert.True(target.ContainsSpecialCharacterExt().ProcessRegexExt());

            target = "Cherries!!!";
            Assert.True(target.ContainsSpecialCharacterExt().ProcessRegexExt());

            target = "[Cherries";
            Assert.True(target.ContainsSpecialCharacterExt().ProcessRegexExt());

            target = "[Cherrie?s";
            Assert.True(target.ContainsSpecialCharacterExt().ProcessRegexExt());

            target = "cherries";
            Assert.False(target.ContainsSpecialCharacterExt().ProcessRegexExt());
        }

        [Fact]
        public void Excludes()
        {
            string target = "Cherries";
            Assert.True(target.ExcludesExt("!").ProcessRegexExt());
            Assert.True(target.ExcludesExt('\b').ProcessRegexExt());
            Assert.False(target.ExcludesExt("err").ProcessRegexExt());
        }

        [Fact]
        public void IsValidPhoneNumber()
        {
            string number = "5555555555";
            Assert.True(number.IsValidPhoneNumberExt().ProcessRegexExt());

            number = "555555555";
            Assert.False(number.IsValidPhoneNumberExt().ProcessRegexExt());

            number = "555555555X";
            Assert.False(number.IsValidPhoneNumberExt().ProcessRegexExt());

            number = "";
            Assert.False(number.IsValidPhoneNumberExt().ProcessRegexExt());

            number = null;
            Assert.False(number.IsValidPhoneNumberExt().ProcessRegexExt());
        }

        [Fact]
        public void IsValidEmail()
        {
            string email = "test@test.com";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "Test@TEST.org";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "test1@test.com";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "test-1@test.com";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "test.1@test.com";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "test_1@test.com";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "test@test.1";
            Assert.True(email.IsValidEmailExt().ProcessRegexExt());

            email = "test@test@test.com";
            Assert.False(email.IsValidEmailExt().ProcessRegexExt());

            email = "test";
            Assert.False(email.IsValidEmailExt().ProcessRegexExt());

            email = "";
            Assert.False(email.IsValidEmailExt().ProcessRegexExt());

            email = null;
            Assert.False(email.IsValidEmailExt().ProcessRegexExt());
        }

        [Fact]
        public void IsValidIPAddress()
        {
            string ip = "255.255.255.255";
            Assert.True(ip.IsValidIPAddressExt().ProcessRegexExt());

            ip = "0.0.0.0";
            Assert.True(ip.IsValidIPAddressExt().ProcessRegexExt());

            ip = "000.000.000.000";
            Assert.False(ip.IsValidIPAddressExt().ProcessRegexExt());

            ip = "255.255.255.255.355";
            Assert.False(ip.IsValidIPAddressExt().ProcessRegexExt());

            ip = "255.255";
            Assert.False(ip.IsValidIPAddressExt().ProcessRegexExt());

            ip = "256.256.256.256";
            Assert.False(ip.IsValidIPAddressExt().ProcessRegexExt());

            ip = "-255.255.255.255";
            Assert.False(ip.IsValidIPAddressExt().ProcessRegexExt());
        }

        [Fact]
        public void FormatPhoneNumber()
        {
            string number = "5555555555";
            string expected = "(555) 555-5555";
            string actual = number.FormatPhoneNumberExt();
            Assert.Equal(expected, actual);

            number = "555555555";
            Assert.Throws<ArgumentNullException>(number.FormatPhoneNumberExt);

            number = "555555555X";
            Assert.Throws<ArgumentNullException>(number.FormatPhoneNumberExt);

            number = "";
            Assert.Throws<ArgumentNullException>(number.FormatPhoneNumberExt);

            number = null;
            Assert.Throws<ArgumentNullException>(number.FormatPhoneNumberExt);
        }

        [Fact]
        public void IsAlphaNumeric()
        {
            string text = "abc123";
            Assert.True(text.IsAlphaNumericExt().ProcessRegexExt());

            text = "123";
            Assert.True(text.IsAlphaNumericExt().ProcessRegexExt());

            text = "abc";
            Assert.True(text.IsAlphaNumericExt().ProcessRegexExt());

            text = "abc.123";
            Assert.False(text.IsAlphaNumericExt().ProcessRegexExt());

            text = "abc 123";
            Assert.False(text.IsAlphaNumericExt().ProcessRegexExt());

            text = null;
            Assert.False(text.IsAlphaNumericExt().ProcessRegexExt());
        }

        [Fact]
        public void IsAlpha()
        {
            string text = "abc123";
            Assert.False(text.IsAlphaExt().ProcessRegexExt());

            text = "123";
            Assert.False(text.IsAlphaExt().ProcessRegexExt());

            text = "abc";
            Assert.True(text.IsAlphaExt().ProcessRegexExt());

            text = "abc.123";
            Assert.False(text.IsAlphaExt().ProcessRegexExt());

            text = "abc 123";
            Assert.False(text.IsAlphaExt().ProcessRegexExt());

            text = null;
            Assert.False(text.IsAlphaExt().ProcessRegexExt());
        }

        [Fact]
        public void IsNumeric()
        {
            string text = "abc123";
            Assert.False(text.IsNumericExt().ProcessRegexExt());

            text = "123";
            Assert.True(text.IsNumericExt().ProcessRegexExt());

            text = "abc";
            Assert.False(text.IsNumericExt().ProcessRegexExt());

            text = "abc.123";
            Assert.False(text.IsNumericExt().ProcessRegexExt());

            text = "abc 123";
            Assert.False(text.IsNumericExt().ProcessRegexExt());

            text = null;
            Assert.False(text.IsNumericExt().ProcessRegexExt());
        }

        [Fact]
        public void Compound()
        {
            string target = "P@ssword123";
            Assert.True(
                target
                .ContainsCapitalLetterExt()
                .ContainsLowerCaseLetterExt()
                .ContainsNumberExt()
                .ContainsSpecialCharacterExt()
                .ExcludesExt("&")
                .ProcessRegexExt()
            );

            Assert.False(
                target
                .ContainsCapitalLetterExt()
                .ContainsLowerCaseLetterExt()
                .ContainsNumberExt()
                .ContainsSpecialCharacterExt()
                .ExcludesExt("@")
                .ProcessRegexExt()
            );
        }
    }
}
