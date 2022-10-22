// Copyright © 2022 Adrian Gabor
// Refer to license.txt for usage and permission information 

using Xunit;

namespace Extensions.net.core.tests.UnitTests
{
    public class EnumerationExtensionsTests
    {
        [Fact]
        public void ToList()
        {
            ABC abc = new ();

            string expected = "A,B,C";
            string actual = string.Join(',', abc.ToListExt());
            Assert.Equal(expected, actual);

            actual = string.Join(',', ABC.B.ToListExt());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetName()
        {
            ABC abc = new ();

            string expected = "C";
            string actual = abc.GetNameExt(2);
            Assert.Equal(expected, actual);

            actual = ABC.C.GetNameExt(2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNames()
        {
            ABC abc = new ();

            string[] expected = { "A", "B", "C" };
            string[] actual = abc.GetNamesExt();
            Assert.Equal(expected, actual);

            actual = ABC.A.GetNamesExt();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToStringExt()
        {
            ABC abc = new ();
            string expected = "A, B, C";
            string actual = abc.ToStringExt();
            Assert.Equal(expected, actual);

            actual = ABC.A.ToStringExt();
            Assert.Equal(expected, actual);
        }

        private enum ABC { A = 0, B = 1, C = 2 }
    }
}
