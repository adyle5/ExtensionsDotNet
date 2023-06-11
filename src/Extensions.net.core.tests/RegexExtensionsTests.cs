// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using NuGet.Frameworks;
using System.Diagnostics.Contracts;
using Xunit;

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
            Assert.True(target.StartsWithExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.True(target.StartsWithExt(emptypattern).ProcessRegexExt());
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
            Assert.True(target.StartsWithExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.True(target.StartsWithExt(emptypattern).ProcessRegexExt());
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
            Assert.True(target.EndsWithExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.True(target.EndsWithExt(emptypattern).ProcessRegexExt());
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
            Assert.True(target.EndsWithCaseInsensitiveExt(nullpattern).ProcessRegexExt());

            string emptypattern = "";
            Assert.True(target.EndsWithCaseInsensitiveExt(emptypattern).ProcessRegexExt());
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
