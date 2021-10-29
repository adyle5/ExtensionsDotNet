using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Extensions.net.core.tests
{
    public class EnumerationExtensionsTests
    {
        [Fact]
        public void ToList()
        {
            ABC abc = new ABC();

            string expected = "A,B,C";
            string actual = string.Join(',', abc.ToListExt());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetName()
        {
            ABC abc = new ABC();

            string expected = "C";
            string actual = abc.GetNameExt(2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNames()
        {
            ABC abc = new ABC();

            string[] expected = { "A", "B", "C" };
            string[] actual = abc.GetNamesExt();
            Assert.Equal(expected, actual);
        }

        private enum ABC { A = 0, B = 1, C = 2 }
    }
}
