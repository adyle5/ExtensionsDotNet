// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Extensions.net.core.tests
{
    public class GenericExtensionsTests
    {
        readonly ITestOutputHelper output;

        public GenericExtensionsTests(ITestOutputHelper output)
        {
            this.output = output;
        }


        [Fact]
        public void ToInt32()
        {
            string str1 = "1";
            Assert.Equal(Convert.ToInt32(str1), str1.ToInt32Ext());

            string str2 = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => str2.ToInt32Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string str3 = Int64.MaxValue.ToString();
            Assert.Throws<OverflowException>(() => str3.ToInt32Ext());

            string strMax = int.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToInt32(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertInt32DotNet(strMax), () => actualElapsed = ConvertInt32Ext(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToUInt32()
        {
            string one = "1";
            Assert.Equal(Convert.ToUInt32(one), one.ToUInt32Ext());

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToUInt32Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = "-3";
            Assert.Throws<OverflowException>(() => three.ToUInt32Ext());

            string strMax = uint.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToUInt32(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertUInt32DotNet(strMax), () => actualElapsed = ConvertUInt32Ext(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToInt16()
        {
            string one = "1";
            Assert.Equal(Convert.ToInt16(one), one.ToInt16Ext());

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToInt16Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = int.MaxValue.ToString();
            Assert.Throws<OverflowException>(() => three.ToInt16Ext());

            string strMax = Int16.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToInt16(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertInt16DotNet(strMax), () => actualElapsed = ConvertInt16Ext(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToUInt16()
        {
            string one = "1";
            Assert.Equal(Convert.ToUInt16(one), one.ToUInt16Ext());

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToUInt16Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = "-3";
            Assert.Throws<OverflowException>(() => three.ToUInt16Ext());

            string strMax = UInt16.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToUInt16(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertUInt16DotNet(strMax), () => actualElapsed = ConvertUInt16Ext(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToIn64()
        {
            string one = "1";
            Assert.Equal(Convert.ToInt64(one), one.ToInt64Ext());

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToInt64Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string strMax = Int64.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToInt64(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertInt64DotNet(strMax), () => actualElapsed = ConvertInt64Ext(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToUInt64()
        {
            string one = "1";
            Assert.Equal(Convert.ToUInt64(one), one.ToUInt64Ext());

            string two = "two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToUInt64Ext());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = "-3";
            Assert.Throws<OverflowException>(() => three.ToUInt64Ext());

            string strMax = UInt64.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToUInt64(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertUInt64DotNet(strMax), () => actualElapsed = ConvertUInt64Ext(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToDouble()
        {
            string one = "1.5";
            Assert.Equal(Convert.ToDouble(one), one.ToDoubleExt());

            string two = "two point two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToDoubleExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string strMax = int.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToDouble(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertDoubleDotNet(strMax), () => actualElapsed = ConvertDoubleExt(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToSingle()
        {
            string one = "1.5";
            Assert.Equal(Convert.ToSingle(one), one.ToSingleExt());

            string two = "two point two";
            FormatException formatEx = Assert.Throws<FormatException>(() => two.ToSingleExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            string three = Double.MaxValue.ToString();
            Assert.Equal(Double.PositiveInfinity, three.ToSingleExt());

            string strMax = Single.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToSingle(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertSingleDotNet(strMax), () => actualElapsed = ConvertSingleExt(strMax));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToBoolean()
        {
            string t = "true";

            Assert.True(t.ToBooleanExt());
            Assert.Equal(Convert.ToBoolean(t), t.ToBooleanExt());

            string t2 = "is true";
            FormatException formatEx = Assert.Throws<FormatException>(() => t2.ToBooleanExt());
            Assert.Equal("String 'is true' was not recognized as a valid Boolean.", formatEx.Message);

            int i = 1;
            Assert.Equal(Convert.ToBoolean(i), i.ToBooleanExt());

            float f = 1.0f;
            Assert.Equal(Convert.ToBoolean(f), f.ToBooleanExt());

            byte b = 1;
            Assert.Equal(Convert.ToBoolean(b), b.ToBooleanExt());

            DateTime d1 = DateTime.Now;
            InvalidCastException invalidCastEx = Assert.Throws<InvalidCastException>(() => d1.ToBooleanExt());
            Assert.Equal("Invalid cast from 'DateTime' to 'Boolean'.", invalidCastEx.Message);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertBooleanDotNet(t), () => actualElapsed = ConvertBooleanExt(t));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToByte()
        {
            string b = "1";
            Assert.Equal(Convert.ToByte(b), b.ToByteExt());

            string b2 = "test";
            FormatException formatEx = Assert.Throws<FormatException>(() => b2.ToByteExt());
            Assert.Equal("Input string was not in a correct format.", formatEx.Message);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertByteDotNet(b), () => actualElapsed = ConvertByteExt(b));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToChar()
        {
            string c = "c";
            Assert.Equal(Convert.ToChar(c), c.ToCharExt());

            string c2 = "cc";
            FormatException formatEx = Assert.Throws<FormatException>(() => c2.ToCharExt());
            Assert.Equal("String must be exactly one character long.", formatEx.Message);

            int i = 5;
            Assert.Equal(Convert.ToChar(i), i.ToCharExt());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertCharDotNet(c), () => actualElapsed = ConvertCharExt(c));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToDecimal()
        {
            string d = "1.25";
            Assert.Equal(Convert.ToDecimal(d), d.ToDecimalExt());

            string d2 = "one point two five";
            Assert.Throws<FormatException>(() => d2.ToDecimalExt());

            float f = 1.4F;
            Assert.Equal(Convert.ToDecimal(f), f.ToDecimalExt());

            string maxcDec = decimal.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToDecimal(maxcDec);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertDecimalDotNet(maxcDec), () => actualElapsed = ConvertDecimalExt(maxcDec));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToSByte()
        {
            string sb = "100";
            Assert.Equal(Convert.ToSByte(sb), sb.ToSByteExt());

            string sb2 = "1000";
            Assert.Throws<OverflowException>(() => sb2.ToSByteExt());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertSByteDotNet(sb), () => actualElapsed = ConvertSByteExt(sb));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void ToFloat()
        {
            string one = "1.4";
            float f = 1.4F;
            Assert.Equal(f, one.ToFloatExt());

            string two = "two point four";
            Assert.Throws<FormatException>(() => two.ToFloatExt());

            double d = 1.4;
            Assert.Equal(f, d.ToFloatExt());
        }

        [Fact]
        public void ToLong()
        {
            string one = "100";
            long l = 100;
            Assert.Equal(l, one.ToLongExt());

            string two = "two";
            Assert.Throws<FormatException>(() => two.ToLongExt());

            int i = 100;
            Assert.Equal(l, i.ToShortExt());
        }

        [Fact]
        public void ToShort()
        {
            string one = "100";
            short s = 100;
            Assert.Equal(s, one.ToShortExt());

            string two = "two";
            Assert.Throws<FormatException>(() => two.ToShortExt());

            string three = long.MaxValue.ToString();
            Assert.Throws<FormatException>(() => three.ToShortExt());

            int i = 100;
            Assert.Equal(s, i.ToShortExt());
        }

        [Fact]
        public void DeepCopy()
        {
            string str1 = "test";
            string str2 = str1.DeepCopyExt();

            Assert.Equal(str1, str2);
            Assert.False(Object.ReferenceEquals(str1, str2));
        }

        [Fact]
        public void ToStream()
        {
            string s = "test";
            using (Stream stream = s.ToStreamExt())
            {
                Assert.NotNull(stream);
            }

            using (Stream stream = s.ToStreamExt())
            {
                using StreamReader sr = new (stream);
                Assert.Equal(s, sr.ReadToEnd());
            }

            int[] arr = { 1, 2, 3, 4, 5 };
            using (Stream stream = arr.ToStreamExt())
            {
                Assert.NotNull(stream);
            }
        }

        [Fact]
        public void ToKeyValuePair()
        {
            int key = 1;
            string value = "red";

            KeyValuePair<int, string> expected = new (key, value);
            Assert.Equal(expected, key.ToKeyValuePairExt(value));
        }

        [Fact]
        public void ToKeyValuePair2()
        {
            int key = 1;
            string value = "red";

            KeyValuePair<int, string> expected = new (key, value);
            Assert.Equal(expected, value.ToKeyValuePair2Ext(key));
        }

        [Fact]
        public void Repeat()
        {
            int num = 3;
            int repeat = 5;

            IEnumerable<int> expected = System.Linq.Enumerable.Repeat(num, repeat);
            Assert.Equal(expected, num.RepeatExt(repeat));

            IEnumerable<bool> expected2 = System.Linq.Enumerable.Repeat(true, repeat);
            Assert.Equal(expected2, true.RepeatExt(repeat));
        }

        [Fact]
        public void Trace()
        {
            string text = "test";
            var ex1 = Record.Exception(() => text.TraceExt());
            Assert.Null(ex1);

            string category = "debug";
            var ex2 = Record.Exception(() => text.TraceExt(category));
            Assert.Null(ex2);
        }

        [Fact]
        public void TraceIf()
        {
            string text = "test";
            var ex1 = Record.Exception(() => text.TraceIfExt(true));
            Assert.Null(ex1);

            ex1 = Record.Exception(() => text.TraceIfExt(false));
            Assert.Null(ex1);

            string category = "category";
            var ex2 = Record.Exception(() => text.TraceIfExt(true, category));
            Assert.Null(ex2);

            ex2 = Record.Exception(() => text.TraceIfExt(false, category));
            Assert.Null(ex2);
        }

        [Fact]
        public void TraceLineExt()
        {
            string text = "test";
            var ex1 = Record.Exception(() => text.TraceLineExt());
            Assert.Null(ex1);

            string category = "debug";
            var ex2 = Record.Exception(() => text.TraceLineExt(category));
            Assert.Null(ex2);
        }

        [Fact]
        public void TraceLineIf()
        {
            string text = "test";

            var ex1 = Record.Exception(() => text.TraceLineIfExt(true));
            Assert.Null(ex1);

            ex1 = Record.Exception(() => text.TraceLineIfExt(false));
            Assert.Null(ex1);

            string category = "category";

            var ex2 = Record.Exception(() => text.TraceLineIfExt(true, category));
            Assert.Null(ex2);

            ex2 = Record.Exception(() => text.TraceLineIfExt(false, category));
            Assert.Null(ex2);
        }

        #region "Private Methods"

        private static long ConvertInt32DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToInt32(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertInt32Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToInt32Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertUInt32DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToUInt32(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertUInt32Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToUInt32Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertInt16DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToInt16(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertInt16Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToInt16Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertUInt16DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToUInt16(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertUInt16Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToUInt16Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertInt64DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToInt64(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertInt64Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToInt64Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertUInt64DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToUInt64(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertUInt64Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToUInt64Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertDoubleDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToDouble(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertDoubleExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToDoubleExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertSingleDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToSingle(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertSingleExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToSingleExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertBooleanDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToBoolean(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertBooleanExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToBooleanExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertByteDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToByte(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertByteExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToByteExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertCharDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToChar(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertCharExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToCharExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertDecimalDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToDecimal(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertDecimalExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToDecimalExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertSByteDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToSByte(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertSByteExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            str1.ToSByteExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        #endregion
    }
}
