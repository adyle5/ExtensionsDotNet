using System;
using Xunit;

namespace Extensions.net.core.tests
{
    public class NumberExtensionsTests
    {
        [Fact]
        public void TryParseExt()
        {
            string input = "1";
            int output = 0;
            output.TryParseExt(input);
            Assert.Equal(1, output);

            string input2 = "two";
            output = 0;
            output.TryParseExt(input2);
            Assert.Equal(0, output);
        }

        [Fact]
        public void DateTime()
        {
            long l = 123456789;
            DateTime d = new DateTime(l);
            Assert.Equal(d, l.ToDateTimeExt());
        }

        [Fact]
        public void IsNullOrLessThanOneInt()
        {
            int? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            int? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            int? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }


        [Fact]
        public void IsNullOrLessThanOneInt16()
        {
            Int16? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            Int16? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            Int16? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneInt64()
        {
            Int64? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            Int64? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            Int64? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneUInt32()
        {
            UInt32? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            UInt32? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            UInt32? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneUInt16()
        {
            UInt16? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            UInt16? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            UInt16? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneUInt64()
        {
            UInt64? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            UInt64? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            UInt64? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneDouble()
        {
            double? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            double? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            double? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());

            float? f = 0f;
            Assert.True(f.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneSingle()
        {
            Single? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            Single? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            Single? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneDecimal()
        {
            decimal? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            decimal? i2 = 2m;
            Assert.False(i2.IsNullOrLessThanOneExt());

            decimal? i3 = 0m;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneByte()
        {
            byte? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            byte? i2 = 1;
            Assert.False(i2.IsNullOrLessThanOneExt());

            byte? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }

        [Fact]
        public void IsNullOrLessThanOneSByte()
        {
            byte? i = null;
            Assert.True(i.IsNullOrLessThanOneExt());

            byte? i2 = 2;
            Assert.False(i2.IsNullOrLessThanOneExt());

            byte? i3 = 0;
            Assert.True(i3.IsNullOrLessThanOneExt());
        }
    }
}
