// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Extensions.net.core.tests
{
    public class CryptographyExtensionsTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ComputeHash256()
        {
            string x = "test";

            byte[] expected = null;
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.Default.GetBytes(x);
                expected = sha256.ComputeHash(bytes);
            }

            Assert.Equal(expected, x.ComputeHash256Ext());
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ComputeHash512()
        {
            string x = "test";

            byte[] expected = null;
            using (var sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.Default.GetBytes(x);
                expected = sha512.ComputeHash(bytes);
            }

            Assert.Equal(expected, x.ComputeHash512Ext());

            Assert.NotEqual(expected, x.ComputeHash256Ext());
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ComputeHashMD5()
        {
            string x = "test";

            byte[] expected = null;
            using (var md5 = MD5.Create())
            {
                byte[] bytes = Encoding.Default.GetBytes(x);
                expected = md5.ComputeHash(bytes);
            }

            Assert.Equal(expected, x.ComputeHashMD5Ext());

            Assert.NotEqual(expected, x.ComputeHash256Ext());
        }
    }
}
