// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.IO;
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

        /// <summary>
        /// Symmetic encryption of a string using TripleDES.
        /// Returns a tuple that includes the EncryptedBytes, Key, IV
        /// All three objects in the tuple are byte arrays.
        /// The key and initialization vector are needed to decrypt the byte array  back into a string.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static (byte[] EncryptedBytes, byte[] Key, byte[] IV) ToTripleDesEncryptedBytesExt(this string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException(nameof(text));

            using TripleDES des = TripleDES.Create();

            using ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV);

            using MemoryStream ms = new();
            using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);
            using StreamWriter sw = new(cs);

            sw.Write(text);
            sw.Flush();

            cs.FlushFinalBlock();

            byte[] encrypted = ms.ToArray();

            // Returns a tuple that includes the encrypted bytes, des key and des initialization vector
            // The key and IV are needed to decrypt.
            return (encrypted, des.Key, des.IV);
        }

        /// <summary>
        /// Symmetic decryption of a byte array back to a string using using TripleDES and the provided key and initialization vector.
        /// The key and initialization vector (IV) were generated when the string was originally encrypted and needed to be stored for decryption. 
        /// </summary>
        /// <param name="cipher"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ToTripleDesDecryptedStringExt(this byte[] cipher, byte[] key, byte[] iv)
        {
            if (cipher == null || cipher.Length == 0)
                throw new ArgumentNullException(nameof(cipher));

            if (key == null || key.Length == 0)
                throw new ArgumentNullException(nameof(key));

            if (iv == null || iv.Length == 0)
                throw new ArgumentNullException(nameof(iv));

            using TripleDES des = TripleDES.Create();
            des.Key = key;
            des.IV = iv;

            ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV);

            using MemoryStream ms = new(cipher);
            using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
            using StreamReader sr = new(cs);
            return sr.ReadToEnd();
        }
    }
}
