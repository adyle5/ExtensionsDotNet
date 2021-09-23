using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Extensions.net.core.tests
{
    public class ByteExtensionsTests
    {
        [Fact]
        public void ToBase64String()
        {
            byte[] bytes = { 64, 23, 1, 77, 12, 65, 45 };
            Assert.Equal(Convert.ToBase64String(bytes), bytes.ToBase64StringExt());

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = ConvertB64StringDotNet(bytes), () => actualElapsed = ConvertB64Ext(bytes));

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
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
        public void GetBytesUtf7()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            byte[] expected = Encoding.UTF7.GetBytes(arr);
            Assert.Equal(expected, arr.GetBytesUtf7Ext());

            byte[] expected2 = Encoding.UTF7.GetBytes(arr, 0, 5);
            Assert.Equal(expected2, arr.GetBytesUtf7Ext(0, 5));
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

        #region "Private Methods"
        private long ConvertB64StringDotNet(byte[] b1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Convert.ToBase64String(b1);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long ConvertB64Ext(byte[] b1)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = b1.ToBase64StringExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }
        #endregion
    }
}
