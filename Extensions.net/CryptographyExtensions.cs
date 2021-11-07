// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System.Security.Cryptography;

namespace Extensions.net
{
    public static class CryptographyExtensions
    {
        public static byte[] ComputeHash256Ext(this string data)
        {
            using var s256 = SHA256.Create();
            return s256.ComputeHash(data.GetBytesExt());
        }

        public static byte[] ComputeHash512Ext(this string data)
        {
            using var s512 = SHA512.Create();
            return s512.ComputeHash(data.GetBytesExt());
        }

        public static byte[] ComputeHashMD5Ext(this string data)
        {
            using var md5 = MD5.Create();
            return md5.ComputeHash(data.GetBytesExt());
        }

        /// <summary>
        /// Fills the extended byte array with cryptographically strong random bytes.
        /// Bytes filled can be zero.
        /// </summary>
        /// <param name="bytes"></param>
        public static void GenerateRandomBytesExt(this byte[] bytes)
        {
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
        }

        /// <summary>
        /// Fills the extended byte array with cryptographically strong random bytes.
        /// Bytes will be non-zero.
        /// </summary>
        /// <param name="bytes"></param>
        public static void GenerateRandomNonZeroBytesExt(this byte[] bytes)
        {
            using var rng = RandomNumberGenerator.Create();
            rng.GetNonZeroBytes(bytes);
        }
    }
}
