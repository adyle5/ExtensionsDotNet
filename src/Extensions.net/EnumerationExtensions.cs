// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System.Linq;
using System.Collections.Generic;
using System;

namespace Extensions.net
{
    public static class EnumerationExtensions
    {
        /// <summary>
        /// Converts an instance of an enum into a List of strings.
        /// Uses Linq which may affect time complexity.
        /// Parameter can be an instance of the enumeration or an enumeration value.
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static List<string> ToListExt(this Enum @enum)
        {
            Type t = @enum.GetType();

            return Enum.GetValues(t).Cast<Enum>().Select(x => x.ToString()).ToList();
        }

        /// <summary>
        /// Gets the name of the enumeration constant with the value of the paramater.
        /// Maps to Enum.GetName
        /// Parameter can be an instance of the enumeration or an enumeration value.
        /// </summary>
        /// <param name="enum"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetNameExt(this Enum @enum, object value)
            => Enum.GetName(@enum.GetType(), value);

        /// <summary>
        /// Returns a string array of the names of an enum that matches the type of the emumeration being extended.
        /// Maps to Enum.GetNames.
        /// Parameter can be an instance of the enumeration or an enumeration value.
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static string[] GetNamesExt(this Enum @enum) => Enum.GetNames(@enum.GetType());

        /// <summary>
        /// Joins all values in an enumeration into a comma delimited string.
        /// Parameter can be an instance of the enumeration or an enumeration value.
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static string ToStringExt(this Enum @enum)
        {
            string[] names = @enum.GetNamesExt();
            return names.JoinExt(", ");
        }
    }
}
