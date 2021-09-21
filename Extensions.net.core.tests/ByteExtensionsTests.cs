using System;
using System.Diagnostics;
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
