using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions.net.core.tests
{
    public class CharExtensionsTests
    {
        [Fact]
        public void ToUpper()
        {
            char c = 'c';
            char expected = 'C';
            char actual = c.ToUpperExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToUpperInvariant()
        {
            char c = 'c';
            char expected = 'C';
            char actual = c.ToUpperInvariantExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsUpper()
        {
            char c = 'C';
            bool expected = true;
            bool actual = c.IsUpperExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsUpperExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToLower()
        {
            char c = 'C';
            char expected = 'c';
            char actual = c.ToLowerExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToLowerInvariant()
        {
            char c = 'C';
            char expected = 'c';
            char actual = c.ToLowerInvariantExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLower()
        {
            char c = 'c';
            bool expected = true;
            bool actual = c.IsLowerExt();
            Assert.Equal(expected, actual);

            c = 'C';
            expected = false;
            actual = c.IsLowerExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsControl()
        {
            char c = '\0';
            bool expected = true;
            bool actual = c.IsControlCharacterExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsControlCharacterExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsWhiteSpace()
        {
            char c = ' ';
            bool expected = true;
            bool actual = c.IsWhiteSpaceExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsWhiteSpaceExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsDigit()
        {
            char c = '1';
            bool expected = true;
            bool actual = c.IsDigitExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsDigitExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLetter()
        {
            char c = 'c';
            bool expected = true;
            bool actual = c.IsLetterExt();
            Assert.Equal(expected, actual);

            c = '1';
            expected = false;
            actual = c.IsLetterExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLetterOrDigit()
        {
            char c = 'c';
            bool expected = true;
            bool actual = c.IsLetterOrDigitExt();
            Assert.Equal(expected, actual);

            c = '1';
            expected = true;
            actual = c.IsLetterOrDigitExt();
            Assert.Equal(expected, actual);

            c = '\0';
            expected = false;
            actual = c.IsLetterOrDigitExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsNumber()
        {
            char c = '1';
            bool expected = true;
            bool actual = c.IsNumberExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsNumberExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPunctuation()
        {
            char c = '!';
            bool expected = true;
            bool actual = c.IsPunctuationExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsPunctuationExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsSeparator()
        {
            char c = '\u0020';
            bool expected = true;
            bool actual = c.IsSeparatorExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsSeparatorExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsSymbol()
        {
            char c = '+';
            bool expected = true;
            bool actual = c.IsSymbolExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsSymbolExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsSurrogate()
        {
            char c = '\uD800';
            bool expected = true;
            bool actual = c.IsSurrogateExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsSurrogateExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsHighSurrogate()
        {
            char c = '\uD800';
            bool expected = true;
            bool actual = c.IsHighSurrogateExt();
            Assert.Equal(expected, actual);

            c = '\uDC00';
            expected = false;
            actual = c.IsHighSurrogateExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsLowSurrogate()
        {
            char c = '\uDC00';
            bool expected = true;
            bool actual = c.IsLowSurrogateExt();
            Assert.Equal(expected, actual);

            c = '\uD800';
            expected = false;
            actual = c.IsLowSurrogateExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsMinValue()
        {
            char c = char.MinValue;
            bool expected = true;
            bool actual = c.IsMinValueExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsMinValueExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsMaxValue()
        {
            char c = char.MaxValue;
            bool expected = true;
            bool actual = c.IsMaxValueExt();
            Assert.Equal(expected, actual);

            c = 'c';
            expected = false;
            actual = c.IsMaxValueExt();
            Assert.Equal(expected, actual);
        }
    }
}
