using System;
using System.Diagnostics;
using Xunit;
using Extensions.net.generic;
using System.Threading.Tasks;

namespace Extensions.net.core.tests
{
    public class GenericExceptionsTests
    {
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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
            OverflowException overflowEx = Assert.Throws<OverflowException>(() => three.ToSingleExt());
            Assert.Equal("Value was either too large or too small for a Single.", overflowEx.Message);

            string strMax = Single.MaxValue.ToString();
            //First call might skew results, so let's get it out of the way.
            Convert.ToSingle(strMax);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertSingleDotNet(strMax), () => actualElapsed = ConvertSingleExt(strMax));

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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

        #region "Private Methods"

        #endregion

        private long ConvertInt32DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToInt32(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertInt32Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToInt32Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertUInt32DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToUInt32(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertUInt32Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToUInt32Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertInt16DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToInt16(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertInt16Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToInt16Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertUInt16DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToUInt16(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertUInt16Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToUInt16Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertInt64DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToInt64(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertInt64Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToInt64Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertUInt64DotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToUInt64(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertUInt64Ext(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToUInt64Ext();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertDoubleDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToDouble(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertDoubleExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToDoubleExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertSingleDotNet(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToSingle(str1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertSingleExt(string str1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = str1.ToSingleExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }
    }
}
