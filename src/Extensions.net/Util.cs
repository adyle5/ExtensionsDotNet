// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

namespace Extensions.net
{
    internal static class Util
    {
        internal static bool StringBuilderTypeCheck(object obj)
        {
            switch (obj)
            {
                case string:
                case int:
                case long:
                case float:
                case double:
                case decimal:
                case short:
                case char:
                case bool:
                case ulong:
                case uint:
                case byte:
                case ushort:
                case object:
                    return true;
                default:
                    break;
            }

            return false;
        }
    }
}
