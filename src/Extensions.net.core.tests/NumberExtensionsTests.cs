// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xunit;

namespace Extensions.net.core.tests.UnitTests
{
    public class NumberExtensionsTests
    {
        [Fact]
        public void TryParse()
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
        public void Parse()
        {
            string input = "1";
            int output = 0;
            output.ParseExt(input);
            Assert.Equal(1, output);
        }

        [Fact]
        public void DateTime()
        {
            long l = 123456789;
            DateTime d = new (l);
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

        [Fact]
        public void IsNullOrZeroInt()
        {
            int? i = null;
            Assert.True(i.IsNullOrZeroExt());

            int? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            int? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }


        [Fact]
        public void IsNullOrZeroInt16()
        {
            Int16? i = null;
            Assert.True(i.IsNullOrZeroExt());

            Int16? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            Int16? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroInt64()
        {
            Int64? i = null;
            Assert.True(i.IsNullOrZeroExt());

            Int64? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            Int64? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroUInt32()
        {
            UInt32? i = null;
            Assert.True(i.IsNullOrZeroExt());

            UInt32? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            UInt32? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroUInt16()
        {
            UInt16? i = null;
            Assert.True(i.IsNullOrZeroExt());

            UInt16? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            UInt16? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroUInt64()
        {
            UInt64? i = null;
            Assert.True(i.IsNullOrZeroExt());

            UInt64? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            UInt64? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroDouble()
        {
            double? i = null;
            Assert.True(i.IsNullOrZeroExt());

            double? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            double? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());

            float? f = 0f;
            Assert.True(f.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroSingle()
        {
            Single? i = null;
            Assert.True(i.IsNullOrZeroExt());

            Single? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            Single? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroDecimal()
        {
            decimal? i = null;
            Assert.True(i.IsNullOrZeroExt());

            decimal? i2 = 2m;
            Assert.False(i2.IsNullOrZeroExt());

            decimal? i3 = 0m;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroByte()
        {
            byte? i = null;
            Assert.True(i.IsNullOrZeroExt());

            byte? i2 = 1;
            Assert.False(i2.IsNullOrZeroExt());

            byte? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsNullOrZeroSByte()
        {
            sbyte? i = null;
            Assert.True(i.IsNullOrZeroExt());

            sbyte? i2 = 2;
            Assert.False(i2.IsNullOrZeroExt());

            sbyte? i3 = 0;
            Assert.True(i3.IsNullOrZeroExt());
        }

        [Fact]
        public void IsIntegral()
        {
            double dou = 2.0;
            Assert.True(dou.IsIntegralExt());

            double dou2 = 2.3;
            Assert.False(dou2.IsIntegralExt());

            decimal dec = 3.0M;
            Assert.True(dec.IsIntegralExt());

            decimal dec2 = 3.2M;
            Assert.False(dec2.IsIntegralExt());
        }

        [Fact]
        public void IsEven()
        {
            int i = 2;
            Assert.True(i.IsEvenExt());

            int i2 = 3;
            Assert.False(i2.IsEvenExt());

            double dou = 2.0;
            Assert.True(dou.IsEvenExt());

            double dou2 = 3.0;
            Assert.False(dou2.IsEvenExt());

            decimal dec = 2.0M;
            Assert.True(dec.IsEvenExt());

            decimal dec2 = 2.2M;
            Assert.False(dec2.IsEvenExt());
        }

        [Fact]
        public void IsOdd()
        {
            int i = 2;
            Assert.False(i.IsOddExt());

            int i2 = 3;
            Assert.True(i2.IsOddExt());

            double dou = 2.0;
            Assert.False(dou.IsOddExt());

            double dou2 = 3.0;
            Assert.True(dou2.IsOddExt());

            decimal dec = 2.0M;
            Assert.False(dec.IsOddExt());

            decimal dec2 = 3.2M;
            Assert.False(dec2.IsOddExt());

            decimal dec3 = 3.0M;
            Assert.True(dec3.IsOddExt());
        }

        [Fact]
        public void ToCurrency()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            double d = 1.99;
            decimal dec = 1.99M;
            float f = 1.99F;
            string expected = "$1.99";

            Assert.Equal(expected, d.ToCurrencyExt());
            Assert.Equal(expected, dec.ToCurrencyExt());
            Assert.Equal(expected, f.ToCurrencyExt());

            int i = 1;
            expected = "$1.00";
            Assert.Equal(expected, i.ToCurrencyExt());

            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        [Fact]
        public void ToPercent()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            double d = .23;
            decimal dec = .23M;
            float f = .23F;
            string expected = "23%";

            Assert.Equal(expected, d.ToPercentExt(0));
            Assert.Equal(expected, dec.ToPercentExt(0));
            Assert.Equal(expected, f.ToPercentExt(0));

            int i = 1;
            expected = "100%";
            Assert.Equal(expected, i.ToPercentExt(0));

            d = .2345;
            dec = .2345M;
            f = .2345F;
            expected = "23.45%";

            Assert.Equal(expected, d.ToPercentExt());
            Assert.Equal(expected, dec.ToPercentExt());
            Assert.Equal(expected, f.ToPercentExt());

            Thread.CurrentThread.CurrentCulture = currentCulture;
        }

        [Fact]
        public void ToRange()
        {
            int num = 0;
            int count = 100;

            var expected = System.Linq.Enumerable.Range(num, count);
            Assert.Equal(expected, num.ToRangeExt(count));
        }

        [Fact]
        public void Shuffle()
        {
            int number = 123456789;
            int actual = number.ShuffleExt();
            Assert.NotEqual(number, actual);
            Assert.Equal(number.ToString().Length, actual.ToString().Length);
        }

        [Fact]
        public void ToList()
        {
            int number = 123456789;
            List<int> expected = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> actual = number.ToListExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToInt64Bits()
        {
            double value = 123.456;
            double expected = BitConverter.DoubleToInt64Bits(value);
            double actual = value.ToInt64BitsExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsGreaterThan()
        {
            int i = 5;
            int[] arr1 = { 1, 2, 3, 4 };
            Assert.True(i.IsGreaterThanExt(arr1));

            int[] arr2 = { 1, 2, 3, 4, 5 };
            Assert.False(i.IsGreaterThanExt(arr2));

            int[] arr3 = { 1, 2, 3, 4, 6 };
            Assert.False(i.IsGreaterThanExt(arr3));

            double d = 5.3;
            double[] arr4 = { 1.1, 2.5, 3.7, 4.9 };
            Assert.True(d.IsGreaterThanExt(arr4));

            double[] arr5 = { 1.1, 2.5, 3.7, 4.9, 5.3 };
            Assert.False(d.IsGreaterThanExt(arr5));

            double[] arr6 = { 1.1, 2.5, 3.7, 4.9, 6.3 };
            Assert.False(d.IsGreaterThanExt(arr6));

            decimal dec = 5.3M;
            decimal[] arr7 = { 1.1M, 2.5M, 3.7M, 4.9M };
            Assert.True(dec.IsGreaterThanExt(arr7));

            decimal[] arr8 = { 1.1M, 2.5M, 3.7M, 4.9M, 5.3M };
            Assert.False(dec.IsGreaterThanExt(arr8));

            decimal[] arr9 = { 1.1M, 2.5M, 3.7M, 4.9M, 6.3M };
            Assert.False(dec.IsGreaterThanExt(arr9));
        }

        [Fact]
        public void IsGreaterThanEqualTo()
        {
            int i = 5;
            int[] arr1 = { 1, 2, 3, 4 };
            Assert.True(i.IsGreaterThanEqualToExt(arr1));

            int[] arr2 = { 1, 2, 3, 4, 5 };
            Assert.True(i.IsGreaterThanEqualToExt(arr2));

            int[] arr3 = { 1, 2, 3, 4, 6 };
            Assert.False(i.IsGreaterThanEqualToExt(arr3));

            double d = 5.3;
            double[] arr4 = { 1.1, 2.5, 3.7, 4.9 };
            Assert.True(d.IsGreaterThanEqualToExt(arr4));

            double[] arr5 = { 1.1, 2.5, 3.7, 4.9, 5.3 };
            Assert.True(d.IsGreaterThanEqualToExt(arr5));

            double[] arr6 = { 1.1, 2.5, 3.7, 4.9, 6.3 };
            Assert.False(d.IsGreaterThanEqualToExt(arr6));

            decimal dec = 5.3M;
            decimal[] arr7 = { 1.1M, 2.5M, 3.7M, 4.9M };
            Assert.True(dec.IsGreaterThanExt(arr7));

            decimal[] arr8 = { 1.1M, 2.5M, 3.7M, 4.9M, 5.3M };
            Assert.True(dec.IsGreaterThanEqualToExt(arr8));

            decimal[] arr9 = { 1.1M, 2.5M, 3.7M, 4.9M, 6.3M };
            Assert.False(dec.IsGreaterThanEqualToExt(arr9));
        }

        [Fact]
        public void IsLessThan()
        {
            int i = 1;
            int[] arr1 = { 2, 3, 4, 5 };
            Assert.True(i.IsLessThanExt(arr1));

            int[] arr2 = { 1, 2, 3, 4, 5 };
            Assert.False(i.IsLessThanExt(arr2));

            int[] arr3 = { -1, 2, 3, 4, 6 };
            Assert.False(i.IsLessThanExt(arr3));

            double d = 1.1;
            double[] arr4 = { 2.5, 3.7, 4.9, 5.3 };
            Assert.True(d.IsLessThanExt(arr4));

            double[] arr5 = { 1.1, 2.5, 3.7, 4.9, 5.3 };
            Assert.False(d.IsLessThanExt(arr5));

            double[] arr6 = { -1.1, 2.5, 3.7, 4.9, 6.3 };
            Assert.False(d.IsLessThanExt(arr6));

            decimal dec = 1.1M;
            decimal[] arr7 = { 2.5M, 3.7M, 4.9M, 5.3M };
            Assert.True(dec.IsLessThanExt(arr7));

            decimal[] arr8 = { 1.1M, 2.5M, 3.7M, 4.9M, 5.3M };
            Assert.False(dec.IsLessThanExt(arr8));

            decimal[] arr9 = { -1.1M, 2.5M, 3.7M, 4.9M, 6.3M };
            Assert.False(dec.IsLessThanExt(arr9));
        }

        [Fact]
        public void IsLessThanEqualTo()
        {
            int i = 1;
            int[] arr1 = { 2, 3, 4, 5 };
            Assert.True(i.IsLessThanEqualToExt(arr1));

            int[] arr2 = { 1, 2, 3, 4, 5 };
            Assert.True(i.IsLessThanEqualToExt(arr2));

            int[] arr3 = { -1, 2, 3, 4, 6 };
            Assert.False(i.IsLessThanEqualToExt(arr3));

            double d = 1.1;
            double[] arr4 = { 2.5, 3.7, 4.9, 5.3 };
            Assert.True(d.IsLessThanEqualToExt(arr4));

            double[] arr5 = { 1.1, 2.5, 3.7, 4.9, 5.3 };
            Assert.True(d.IsLessThanEqualToExt(arr5));

            double[] arr6 = { -1.1, 2.5, 3.7, 4.9, 6.3 };
            Assert.False(d.IsLessThanEqualToExt(arr6));

            decimal dec = 1.1M;
            decimal[] arr7 = { 2.5M, 3.7M, 4.9M, 5.3M };
            Assert.True(dec.IsLessThanEqualToExt(arr7));

            decimal[] arr8 = { 1.1M, 2.5M, 3.7M, 4.9M, 5.3M };
            Assert.True(dec.IsLessThanEqualToExt(arr8));

            decimal[] arr9 = { -1.1M, 2.5M, 3.7M, 4.9M, 6.3M };
            Assert.False(dec.IsLessThanEqualToExt(arr9));
        }
    }
}
