using Extensions.net.strings;
using System;
using Xunit;

namespace Extensions.net.core.tests.strings
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNullOrWhiteSpace()
        {
            string str1 = "";
            Assert.Equal(str1.IsNullOrWhiteSpaceExt(), string.IsNullOrWhiteSpace(str1));

            string str2 = "Not whitespace";
            Assert.Equal(str2.IsNullOrWhiteSpaceExt(), string.IsNullOrWhiteSpace(str2));

            string str3 = " ";
            Assert.Equal(str3.IsNullOrWhiteSpaceExt(), string.IsNullOrWhiteSpace(str3));
        }

        [Fact]
        public void TestIsNullOrEmpty()
        {
            string str1 = "";
            Assert.Equal(str1.IsNullOrEmptyExt(), string.IsNullOrEmpty(str1));

            string str2 = " ";
            Assert.Equal(str2.IsNullOrEmptyExt(), string.IsNullOrEmpty(str2));

            string str3 = "Not empty";
            Assert.Equal(str3.IsNullOrEmptyExt(), string.IsNullOrEmpty(str3));
        }

        [Fact]
        public void Compare()
        {
            string str1 = "Apples";
            string str2 = "Bananas";
            Assert.Equal(str1.CompareExt(str2), string.Compare(str1, str2));
            Assert.Equal(str2.CompareExt(str1), string.Compare(str2, str1));

            string str3 = "apples";
            Assert.Equal(str3.CompareExt(str1), string.Compare(str3, str1, true));

            string str4 = null;
            Assert.Equal(str1.CompareExt(str4), string.Compare(str1, str4));
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
            Assert.Equal(str1.CompareOrdinalExt(str2), string.CompareOrdinal(str1, str2));
            Assert.Equal(str2.CompareOrdinalExt(str1), string.CompareOrdinal(str2, str1));

            string str3 = "apples";
            Assert.Equal(str3.CompareOrdinalExt(str1), string.CompareOrdinal(str3, str1));

            string str4 = null;
            Assert.Equal(str1.CompareOrdinalExt(str4), string.CompareOrdinal(str1, str4));
        }

        [Fact]
        public void CompareOrdinal2()
        {
            string str1 = "Apples";
            int str1Index = 0;
            string str2 = "Bananas";
            int str2Index = 1;
            int length = 3;
            Assert.Equal(str1.CompareOrdinalExt(str1Index, str2, str2Index, length), string.CompareOrdinal(str1, str1Index, str2, str2Index, length));
            Assert.Equal(str2.CompareOrdinalExt(str2Index, str1, str1Index, length), string.CompareOrdinal(str2, str2Index, str1, str1Index, length));
        }

        [Fact]
        public void Concatenate()
        {
            string str1 = "fu";
            string str2 = "bar";
            string str3 = "star";
            Assert.Equal(str1.ConcatExt(str2, str3), string.Concat(str1, str2, str3));

            string[] arr1 = { str2, str3 };
            Assert.Equal(str1.ConcatExt(arr1), string.Concat(str1, str2, str3));

            string[] arr2 = null;
            Assert.Equal(str1.ConcatExt(arr2), string.Concat(str1, arr2));
        }

        [Fact]
        public void Copy()
        {
            string str1 = "fubar";
            Assert.Equal(str1.CopyExt(), string.Copy(str1));
            Assert.Equal(str1.CopyExt(), string.Copy(str1));
        }

        [Fact]
        public void Format()
        {
            string str1 = "fu{0}{1}";
            string str2 = "bar";
            string str3 = "star";

            object obj1 = new object();

            Assert.Equal(str1.FormatExt(str2, str3), string.Format(str1, str2, str3));
            Assert.Equal(str1.FormatExt(str2, obj1), string.Format(str1, str2, obj1));

            object obj2 = null;
            Assert.Equal(str1.FormatExt(str2, obj2), string.Format(str1, str2, obj2));
        }

        [Fact]
        public void Intern()
        {
            string str1 = "test";
            Assert.Equal(str1.InternExt(), string.Intern(str1));
        }

        [Fact]
        public void IsInterned()
        {
            string str1 = "test";
            Assert.Equal(str1.IsInternExt(), string.IsInterned(str1));
        }

        [Fact]
        public void Join()
        {
            string str1 = "fu";
            string str2 = "bar";
            string separator = " ";

            Assert.Equal(str1.JoinExt(separator, new string[1] { str2 }, 0, 0), string.Join(separator, new string[2] { str1, str2 }, 0, 0));
            Assert.Equal(str1.JoinExt(separator, str2), string.Join(separator, str1, str2));
        }

        [Fact]
        public void ReferenceEqualsExt()
        {
            string str1 = "test";
            string str2 = "test";
            string str3 = str1;

            Assert.Equal(str1.ReferenceEqualsExt(str1), ReferenceEquals(str1, str1));
            Assert.Equal(str1.ReferenceEqualsExt(str2), ReferenceEquals(str1, str2));
            Assert.Equal(str1.ReferenceEqualsExt(str3), ReferenceEquals(str1, str3));
        }

        [Fact]
        public void ToInt32()
        {
            string one = "1";
            Assert.Equal(one.ToInt32Ext(), Convert.ToInt32(one));

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToInt32Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = Int64.MaxValue.ToString();
            Assert.Throws<OverflowException>(() => three.ToInt32Ext());
        }

        [Fact]
        public void ToUInt32()
        {
            string one = "1";
            Assert.Equal(one.ToUInt32Ext(), Convert.ToUInt32(one));

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToUInt32Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = "-3";
            Assert.Throws<OverflowException>(() => three.ToUInt32Ext());
        }

        [Fact]
        public void ToInt16()
        {
            string one = "1";
            Assert.Equal(one.ToInt16Ext(), Convert.ToInt16(one));

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToInt16Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = int.MaxValue.ToString();
            Assert.Throws<OverflowException>(() => three.ToInt16Ext());
        }

        [Fact]
        public void ToUInt16()
        {
            string one = "1";
            Assert.Equal(one.ToUInt16Ext(), Convert.ToUInt16(one));

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToUInt16Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = "-3";
            Assert.Throws<OverflowException>(() => three.ToUInt16Ext());
        }

        [Fact]
        public void ToIn64()
        {
            string one = "1";
            Assert.Equal(one.ToInt64Ext(), Convert.ToInt64(one));

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToInt64Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);
        }

        [Fact]
        public void ToUInt64()
        {
            string one = "1";
            Assert.Equal(one.ToUInt64Ext(), Convert.ToUInt64(one));

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToUInt64Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = "-3";
            Assert.Throws<OverflowException>(() => three.ToUInt64Ext());
        }

        [Fact]
        public void ToDouble()
        {
            string one = "1.5";
            Assert.Equal(one.ToDoubleExt(), Convert.ToDouble(one));

            string two = "two point two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToDoubleExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);
        }

        [Fact]
        public void ToSingle()
        {
            string one = "1.5";
            Assert.Equal(one.ToSingleExt(), Convert.ToSingle(one));

            string two = "two point two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToSingleExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = Double.MaxValue.ToString();
            OverflowException overflowEx = Assert.Throws<OverflowException>(() => three.ToSingleExt());
            Assert.Equal("Value was either too large or too small for a Single.", overflowEx.Message);
        }

        [Fact]
        public void ToBoolean()
        {
            string t = "true";

            Assert.True(t.ToBooleanExt());
            Assert.Equal(t.ToBooleanExt(), Convert.ToBoolean(t));


            string t2 = "is true";
            FormatException formatEx = Assert.Throws<FormatException>(() => t2.ToBooleanExt());
            Assert.Equal("String was not recognized as a valid Boolean.", formatEx.Message);
        }

        [Fact]
        public void ToByte()
        {
            string b = "1";
            Assert.Equal(b.ToByteExt(), Convert.ToByte(b));

            string b2 = "test";
            FormatException formatEx = Assert.Throws<FormatException>(() => b2.ToByteExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);
        }

        [Fact]
        public void ToChar()
        {
            string c = "c";
            Assert.Equal(c.ToCharExt(), Convert.ToChar(c));

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
            Assert.Equal(date2.ToDateTimeExt(), date3);

            string date4 = "This is not a date";
            Assert.Throws<FormatException>(() => date4.ToDateTimeExt());
        }

        [Fact]
        public void ToDecimal()
        {
            string d = "1.25";
            Assert.Equal(d.ToDecimalExt(), Convert.ToDecimal(d));

            string d2 = "one point two five";
            Assert.Throws<FormatException>(() => d2.ToDecimalExt());
        }

        [Fact]
        public void ToSByte()
        {
            string sb = "100";
            Assert.Equal(sb.ToSByteExt(), Convert.ToSByte(sb));

            string sb2 = "1000";
            Assert.Throws<OverflowException>(() => sb2.ToSByteExt());
        }

        [Fact]
        public void ToFloat()
        {
            string one = "1.4";
            float f = 1.4F;
            Assert.Equal(one.ToFloatExt(), f);

            string two = "two point four";
            Assert.Throws<FormatException>(() => two.ToFloatExt());
        }

        [Fact]
        public void ToLong()
        {
            string one = "100";
            long l = 100;
            Assert.Equal(one.ToLongExt(), l);

            string two = "two";
            Assert.Throws<FormatException>(() => two.ToLongExt());
        }

        [Fact]
        public void ToShort()
        {
            string one = "100";
            short s = 100;
            Assert.Equal(one.ToShortExt(), s);

            string two = "two";
            Assert.Throws<FormatException>(() => two.ToShortExt());

            string three = long.MaxValue.ToString();
            Assert.Throws<FormatException>(() => three.ToShortExt());
        }
    }
}
