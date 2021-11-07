// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System.Diagnostics;
using Xunit;

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

        [Fact]
        public void AssertTrace()
        {
            var testListener = new TestListener();
            string expected = $"Message: short message, Detailed Message: detailed message";
            Trace.Listeners.Clear();
            Trace.Listeners.Add(testListener);

            try
            {
                bool condition = 2 > 3;

                var ex1 = Record.Exception(() => condition.AssertExt());
                Assert.Null(ex1);

                string shortMessage = "short message";
                var ex2 = Record.Exception(() => condition.AssertExt(shortMessage));
                Assert.Null(ex2);

                string detailedMessage = "detailed message";
                var ex3 = Record.Exception(() => condition.AssertExt(shortMessage, detailedMessage));
                Assert.Null(ex3);

                testListener.AssertUiEnabled = true;
                Trace.Fail(shortMessage, detailedMessage);

                string actual = testListener.FailString;
                Assert.Equal(expected, actual);
            }
            finally
            {
                Trace.Listeners.Clear();
                Trace.Listeners.Add(testListener);
            }
        }
    }

    class TestListener : DefaultTraceListener
    {
        private void FailMessage(string message, string detailMessage)
        {
            FailString = $"Message: {message}, Detailed Message: {detailMessage}";
        }

        public string FailString { get; private set; } = string.Empty;

        public override void Fail(string message, string detailMessage)
        {
            WriteLine(message, detailMessage);
            if (AssertUiEnabled)
            {
                FailMessage(message, detailMessage);
            }
        }
    }
}
