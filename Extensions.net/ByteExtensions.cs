using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.net
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Maps to Convert.ToBase64String
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToBase64StringExt(this byte[] bytes) => Convert.ToBase64String(bytes);
    }
}
