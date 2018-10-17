using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using Xunit;

namespace Extensions.net.core.tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNullOrWhiteSpace()
        {
            string str1 = "";
            Assert.Equal(string.IsNullOrWhiteSpace(str1), str1.IsNullOrWhiteSpaceExt());

            string str2 = "Not whitespace";
            Assert.Equal(string.IsNullOrWhiteSpace(str2), str2.IsNullOrWhiteSpaceExt());

            string str3 = " ";
            Assert.Equal(string.IsNullOrWhiteSpace(str3), str3.IsNullOrWhiteSpaceExt());
        }

        [Fact]
        public void TestIsNullOrEmpty()
        {
            string str1 = "";
            Assert.Equal(string.IsNullOrEmpty(str1), str1.IsNullOrEmptyExt());

            string str2 = " ";
            Assert.Equal(string.IsNullOrEmpty(str2), str2.IsNullOrEmptyExt());

            string str3 = "Not empty";
            Assert.Equal(string.IsNullOrEmpty(str3), str3.IsNullOrEmptyExt());
        }

        [Fact]
        public void Compare()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal(string.Compare(str1, str2), str1.CompareExt(str2));
            Assert.Equal(string.Compare(str2, str1), str2.CompareExt(str1));

            string str3 = "apples";
            Assert.Equal(string.Compare(str3, str1, true), str3.CompareExt(str1));

            string str4 = null;
            Assert.Equal(string.Compare(str1, str4), str1.CompareExt(str4));
        }

        [Fact]
        public void CompareFirst()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal("Apples", str1.CompareFirstExt(str2));

            string str3 = "apples";
            Assert.Equal("", str1.CompareFirstExt(str3));
        }

        [Fact]
        public void CompareOrdinal()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal(string.CompareOrdinal(str1, str2), str1.CompareOrdinalExt(str2));
            Assert.Equal(string.CompareOrdinal(str2, str1), str2.CompareOrdinalExt(str1));

            string str3 = "apples";
            Assert.Equal(string.CompareOrdinal(str3, str1), str3.CompareOrdinalExt(str1));

            string str4 = null;
            Assert.Equal(string.CompareOrdinal(str1, str4), str1.CompareOrdinalExt(str4));
        }

        [Fact]
        public void CompareOrdinal2()
        {
            string str1 = "Apples";
            int str1Index = 0;
            string str2 = "Bananas";
            int str2Index = 1;
            int length = 3;
            Assert.Equal(string.CompareOrdinal(str1, str1Index, str2, str2Index, length), str1.CompareOrdinalExt(str1Index, str2, str2Index, length));
            Assert.Equal(string.CompareOrdinal(str2, str2Index, str1, str1Index, length), str2.CompareOrdinalExt(str2Index, str1, str1Index, length));
        }

        [Fact]
        public void Concatenate()
        {
            string str1 = "fu";
            string str2 = "bar";
            string str3 = "star";
            Assert.Equal(string.Concat(str1, str2, str3), str1.ConcatExt(str2, str3));

            string[] arr1 = { str2, str3 };
            Assert.Equal(string.Concat(str1, str2, str3), str1.ConcatExt(arr1));

            string[] arr2 = null;
            Assert.Equal(string.Concat(str1, arr2), str1.ConcatExt(arr2));
        }

        [Fact]
        public void Copy()
        {
            string str1 = "fubar";
            Assert.Equal(string.Copy(str1), str1.CopyExt());
            Assert.Equal(string.Copy(str1), str1.CopyExt());
        }

        [Fact]
        public void Format()
        {
            string str1 = "fu{0}{1}";
            string str2 = "bar";
            string str3 = "star";

            object obj1 = new object();

            Assert.Equal(string.Format(str1, str2, str3), str1.FormatExt(str2, str3));
            Assert.Equal(string.Format(str1, str2, obj1), str1.FormatExt(str2, obj1));

            object obj2 = null;
            Assert.Equal(string.Format(str1, str2, obj2), str1.FormatExt(str2, obj2));
        }

        [Fact]
        public void Intern()
        {
            string str1 = "test";
            Assert.Equal(string.Intern(str1), str1.InternExt());
        }

        [Fact]
        public void IsInterned()
        {
            string str1 = "test";
            Assert.Equal(string.IsInterned(str1), str1.IsInternExt());
        }

        [Fact]
        public void Join()
        {
            string str1 = "fu";
            string str2 = "bar";
            string separator = " ";

            Assert.Equal(string.Join(separator, new string[2] { str1, str2 }, 0, 0), str1.JoinExt(separator, new string[1] { str2 }, 0, 0));
            Assert.Equal(string.Join(separator, str1, str2), str1.JoinExt(separator, str2));
        }

        [Fact]
        public void ReferenceEqualsExt()
        {
            string str1 = "test";
            string str2 = "test";
            string str3 = str1;

            Assert.Equal(ReferenceEquals(str1, str1), str1.ReferenceEqualsExt(str1));
            Assert.Equal(ReferenceEquals(str1, str2), str1.ReferenceEqualsExt(str2));
            Assert.Equal(ReferenceEquals(str1, str3), str1.ReferenceEqualsExt(str3));
        }

        [Fact]
        public void ToDateTime()
        {
            string date = "01/01/2018";
            Assert.Equal(date.ToDateTimeExt(), Convert.ToDateTime(date));

            string date2 = "January 1, 2017";
            DateTime date3 = Convert.ToDateTime(date2);
            Assert.Equal(date3, date2.ToDateTimeExt());

            string date4 = "This is not a date";
            Assert.Throws<FormatException>(() => date4.ToDateTimeExt());
        }

        [Fact]
        public void FromBase64String()
        {
            string str1 = "AAEPISo=";
            byte[] b64 = Convert.FromBase64String(str1);               

            Assert.Equal(b64, str1.FromBase64StringExt());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = Base64DotNet(str1), () => actualElapsed = Base64Ext(str1));

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
        }

        [Fact]
        public void ToTitleCase()
        {
            string str1 = "fubar";
            Assert.Equal("Fubar", str1.ToTitleCaseExt());

            string longText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam orci orci, consequat nec dui eu, porta volutpat augue. Nulla vel vehicula lectus, eget facilisis lectus. Sed sed ipsum a nibh aliquet facilisis id quis dui. Mauris interdum urna urna, et euismod tortor luctus quis. Etiam consequat quam vitae lectus egestas finibus. Aliquam id nisi nec ligula semper tempus sed a leo. Pellentesque nec aliquam justo. Nunc non erat bibendum, feugiat urna id, imperdiet metus. Nulla imperdiet mauris vitae justo tincidunt consectetur. Suspendisse interdum lacus sit amet aliquam tincidunt. Aliquam blandit pulvinar vestibulum. Quisque rhoncus tincidunt sem, vitae mollis diam rutrum non.";
            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = TileCaseDotNet(longText), () => actualElapsed = TitleCaseExt(longText));

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
        }

        [Fact]
        public void Reverse()
        {
            string str1 = "fubar";
            Assert.Equal("rabuf", str1.ReverseExt());

            string str2 = "green room";
            Assert.Equal("moor neerg", str2.ReverseExt());
        }

        [Fact]
        public void Palindrome()
        {
            string str1 = "mom";
            Assert.True(str1.IsPalindromeExt());

            string str2 = "socks";
            Assert.False(str2.IsPalindromeExt());
        }

        #region "Private Methods"
        private long Base64DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.FromBase64String(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long Base64Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.FromBase64StringExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long TileCaseDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            TextInfo textInfo = CultureInfo.InvariantCulture.TextInfo;
            var tc1 = textInfo.ToTitleCase(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long TitleCaseExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToTitleCaseExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }
        #endregion
    }
}
