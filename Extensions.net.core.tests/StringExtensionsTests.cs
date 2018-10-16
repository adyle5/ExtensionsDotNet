using Extensions.net.strings;
using System;
using System.Diagnostics;
using Xunit;

namespace Extensions.net.core.tests.strings
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
        public void ToBoolean()
        {
            string t = "true";

            Assert.True(t.ToBooleanExt());
            Assert.Equal(Convert.ToBoolean(t), t.ToBooleanExt());


            string t2 = "is true";
            FormatException formatEx = Assert.Throws<FormatException>(() => t2.ToBooleanExt());
            Assert.Equal("String was not recognized as a valid Boolean.", formatEx.Message);
        }

        [Fact]
        public void ToByte()
        {
            string b = "1";
            Assert.Equal(Convert.ToByte(b), b.ToByteExt());

            string b2 = "test";
            FormatException formatEx = Assert.Throws<FormatException>(() => b2.ToByteExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);
        }

        [Fact]
        public void ToChar()
        {
            string c = "c";
            Assert.Equal(Convert.ToChar(c), c.ToCharExt());

            string c2 = "cc";
            FormatException formatEx = Assert.Throws<FormatException>(() => c2.ToCharExt());
            Assert.Equal("String must be exactly one character long.", formatEx.Message);
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
        public void ToDecimal()
        {
            string d = "1.25";
            Assert.Equal(Convert.ToDecimal(d), d.ToDecimalExt());

            string d2 = "one point two five";
            Assert.Throws<FormatException>(() => d2.ToDecimalExt());
        }

        [Fact]
        public void ToSByte()
        {
            string sb = "100";
            Assert.Equal(Convert.ToSByte(sb), sb.ToSByteExt());

            string sb2 = "1000";
            Assert.Throws<OverflowException>(() => sb2.ToSByteExt());
        }

        [Fact]
        public void FromBase64String()
        {
            string str1 = "AAEPISo=";
            byte[] b64 = Convert.FromBase64String(str1);               

            Assert.Equal(b64, str1.FromBase64StringExt());
        }
    }
}
