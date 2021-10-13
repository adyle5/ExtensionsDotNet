﻿using System.Security.Cryptography;

namespace Extensions.net
{
    public static class CryptographyExtensions
    {
        public static byte[] ComputeHash256Ext(this string data)
        {
            using (var s256 = SHA256.Create())
            {
                return s256.ComputeHash(data.GetBytesExt());
            }
        }

        public static byte[] ComputeHash512Ext(this string data)
        {
            using (var s512 = SHA512.Create())
            {
                return s512.ComputeHash(data.GetBytesExt());
            }
        }

        public static byte[] ComputeHashMD5Ext(this string data)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(data.GetBytesExt());
            }
        }
    }
}
