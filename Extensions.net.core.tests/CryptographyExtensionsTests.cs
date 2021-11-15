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

        [Fact]
        public void GenerateRandomBytes()
        {
            byte[] bytes = new byte[64];
            byte[] bytesCopied = bytes.DeepCopyExt();
            Assert.Equal(bytes, bytesCopied);

            bytes.GenerateRandomBytesExt();
            Assert.NotEqual(bytes, bytesCopied);
        }

        [Fact]
        public void GenerateRandomNonZeroBytes()
        {
            byte[] bytes = new byte[64];
            byte[] bytesCopied = bytes.DeepCopyExt();
            Assert.Equal(bytes, bytesCopied);

            bytes.GenerateRandomNonZeroBytesExt();
            Assert.NotEqual(bytes, bytesCopied);
        }

        [Fact]
        public void ToAesCAPIEncryptedBytesExt()
        {
            string text = "This is a test";

            var (EncryptedBytes, Key, IV) = text.ToAesCAPIEncryptedBytesExt();
            string decrypted = EncryptedBytes.ToAesCAPIDecryptedStringExt(Key, IV);
            string expected = text;

            Assert.Equal(expected, decrypted);
        }

        [Fact]
        public void ToAesCAPIDecryptedString()
        {
            string text = "This is a test";

            var (EncryptedBytes, Key, IV) = text.ToAesCAPIEncryptedBytesExt();
            string decrypted = EncryptedBytes.ToAesCAPIDecryptedStringExt(Key, IV);
            string expected = text;

            Assert.Equal(expected, decrypted);
        }

        [Fact]
        public void ToAesManagedEncryptedBytes()
        {
            string text = "This is a test";

            var (EncryptedBytes, Key, IV) = text.ToAesManagedEncryptedBytesExt();
            string decrypted = EncryptedBytes.ToAesManagedDecryptedStringExt(Key, IV);
            string expected = text;

            Assert.Equal(expected, decrypted);
        }

        [Fact]
        public void ToAesManagedDecryptedString()
        {
            string text = "This is a test";

            var (EncryptedBytes, Key, IV) = text.ToAesManagedEncryptedBytesExt();
            string decrypted = EncryptedBytes.ToAesManagedDecryptedStringExt(Key, IV);
            string expected = text;

            Assert.Equal(expected, decrypted);
        }

        [Fact]
        public void ToTripleDesEncryptedBytes()
        {
            string text = "This is a test";

            var (EncryptedBytes, Key, IV) = text.ToTripleDesEncryptedBytesExt();
            string decrypted = EncryptedBytes.ToTripleDesDecryptedStringExt(Key, IV);
            string expected = text;

            Assert.Equal(expected, decrypted);
        }

        [Fact]
        public void ToTripleDesDecryptedString()
        {
            string text = "This is a test";

            var (EncryptedBytes, Key, IV) = text.ToTripleDesEncryptedBytesExt();
            string decrypted = EncryptedBytes.ToTripleDesDecryptedStringExt(Key, IV);
            string expected = text;

            Assert.Equal(expected, decrypted);
        }
    }
}
