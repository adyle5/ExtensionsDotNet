using Extensions.net.numbers;
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
        public void ToDoubleExt()
        {
            int num = 1;
            int denominator = 2;

            Assert.Equal(0.5, num.ToDoubleExt() / denominator);
        }

        [Fact]
        public void ToSingleExt()
        {
            int num = 1;
            int denominator = 2;

            Assert.Equal(0.5, num.ToSingleExt() / denominator);
        }
    }
}
