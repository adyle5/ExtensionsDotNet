﻿using Xunit;

namespace Extensions.net.core.tests
{
    public class BooleanTests
    {
        [Fact]
        public void TryParse()
        {
            string input = "true";
            bool output = false;
            output.TryParseExt(input);
            Assert.True(output);

            string input2 = "True";
            output = false;
            output.TryParseExt(input2);
            Assert.True(output);

            string input3 = "false";
            output = true;
            output.TryParseExt(input3);
            Assert.False(output);

            string input4 = "False";
            output = true;
            output.TryParseExt(input4);
            Assert.False(output);
        }

        [Fact]
        public void Parse()
        {
            string input = "true";
            bool output = false;
            output.ParseExt(input);
            Assert.True(output);

            string input2 = "True";
            output = false;
            output.ParseExt(input2);
            Assert.True(output);

            string input3 = "false";
            output = true;
            output.ParseExt(input3);
            Assert.False(output);

            string input4 = "False";
            output = true;
            output.ParseExt(input4);
            Assert.False(output);
        }

        [Fact]
        public void EqualsExt()
        {
            bool input = true;
            bool output = true;
            bool areEqual = output.EqualsExt(input);
            Assert.True(areEqual);

            bool input2 = true;
            bool output2 = false;
            bool areEqual2 = output2.EqualsExt(input2);
            Assert.False(areEqual2);
        }
    }
}