// Copyright © 2022 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Extensions.net.core.tests.UnitTests
{
    public class ByteExtensionsTests
    {
        readonly ITestOutputHelper output;
        public ByteExtensionsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ToBase64String()
        {
            byte[] bytes = { 64, 23, 1, 77, 12, 65, 45 };
            Assert.Equal(Convert.ToBase64String(bytes), bytes.ToBase64StringExt());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertB64StringDotNet(bytes), () => actualElapsed = ConvertB64Ext(bytes));

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
        public void GetBytes()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.Default.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesExt());

            byte[] expected2 = Encoding.Default.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesExt(0, 5));
        }

        [Fact]
        public void GetBytesUtf8()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.UTF8.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesUtf8Ext());


            byte[] expected2 = Encoding.UTF8.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesUtf8Ext(0, 5));
        }

        [Fact]
        public void GetBytesUtf32()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.UTF32.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesUtf32Ext());

            byte[] expected2 = Encoding.UTF32.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesUtf32Ext(0, 5));
        }

        [Fact]
        public void GetBytesUnicode()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.Unicode.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesUnicodeExt());

            byte[] expected2 = Encoding.Unicode.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesUnicodeExt(0, 5));
        }

        [Fact]
        public void GetBytesASCII()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.ASCII.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesASCIIExt());

            byte[] expected2 = Encoding.ASCII.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesASCIIExt(0, 5));
        }

        [Fact]
        public void GetBytesBigEndianUnicode()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.BigEndianUnicode.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesBigEndianUnicodeExt());

            byte[] expected2 = Encoding.BigEndianUnicode.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesBigEndianUnicodeExt(0, 5));
        }

        [Fact]
        public void GetString()
        {
            byte[] bytes = new byte[] { 100, 52, 3, 65, 76, 12 };
            string expected = System.Text.Encoding.Default.GetString(bytes);
            Assert.Equal(expected, bytes.GetStringExt());
        }

        [Fact]
        public void GetStringASCII()
        {
            byte[] bytes = new byte[] { 100, 52, 3, 65, 76, 12 };
            string expected = System.Text.Encoding.ASCII.GetString(bytes);
            Assert.Equal(expected, bytes.GetStringASCIIExt());
        }

        [Fact]
        public void GetStringUTF8()
        {
            byte[] bytes = new byte[] { 100, 52, 3, 65, 76, 12 };
            string expected = System.Text.Encoding.UTF8.GetString(bytes);
            Assert.Equal(expected, bytes.GetStringUTF8Ext());
        }

        [Fact]
        public void GetStringUTF32()
        {
            byte[] bytes = new byte[] { 100, 52, 3, 65, 76, 12 };
            string expected = System.Text.Encoding.UTF32.GetString(bytes);
            Assert.Equal(expected, bytes.GetStringUTF32Ext());
        }

        [Fact]
        public void GetStringUnicode()
        {
            byte[] bytes = new byte[] { 100, 52, 3, 65, 76, 12 };
            string expected = System.Text.Encoding.Unicode.GetString(bytes);
            Assert.Equal(expected, bytes.GetStringUnicodeExt());
        }

        [Fact]
        public void GetStringBigEndianUnicode()
        {
            byte[] bytes = new byte[] { 100, 52, 3, 65, 76, 12 };
            string expected = System.Text.Encoding.BigEndianUnicode.GetString(bytes);
            Assert.Equal(expected, bytes.GetStringBigEndianUnicodeExt());
        }

        #region "Private Methods"
        private static long ConvertB64StringDotNet(byte[] b1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Convert.ToBase64String(b1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long ConvertB64Ext(byte[] b1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            b1.ToBase64StringExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }
        #endregion
    }
}
