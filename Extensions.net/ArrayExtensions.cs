﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace Extensions.net
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Maps to Array.Sort.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void SortExt<T>(this T[] arr) where T : IConvertible => Array.Sort(arr);

        /// <summary>
        /// Maps to Array.BinarySearch
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearchExt(this Array arr, object value) => Array.BinarySearch(arr, value);

        /// <summary>
        /// Maps to Array.BinarySearch
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearchExt(this Array arr, int index, int length, object value) => Array.BinarySearch(arr, index, length, value);

        /// <summary>
        /// Maps to Array.Clear
        /// Set a range of elements in an array to the default value of each element type
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        public static void ClearExt(this Array arr, int index, int length) => Array.Clear(arr, index, length);

        /// <summary>
        /// Performs a deep copy of an array containing reference types.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] DeepCopyExt<T>(this T[] arr) where T : class
        {
            if (arr == null) return arr;

            T[] arr2 = new T[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetType().IsSerializable)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        BinaryFormatter f = new BinaryFormatter();
                        f.Serialize(ms, arr[i]);
                        ms.Position = 0;
                        arr2[i] = (T)f.Deserialize(ms);
                    }
                }
            }

            return arr2;
        }

        /// <summary>
        /// Returns a new array with the same size as source array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] NewNullArrayExt<T>(this T[] arr)
        {
            T[] newArr = Array.Empty<T>();
            Array.Resize(ref newArr, arr.Length);

            return newArr;
        }

        /// <summary>
        /// Maps to string.Join
        /// Joins the values in an IConvertible array into a string sepearated by the separator parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinExt<T>(this T[] arr, string separator) where T : IConvertible => string.Join(separator, arr);

        /// <summary>
        /// Returns a double representing the average of an integer array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double AverageExt(this int[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("Attempting to calulate the average of a null array.");

            double total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            return total / arr.Length;
        }

        /// <summary>
        /// Returns a double representing the average of a double array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double AverageExt(this double[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("Attempting to calulate the average of a null array.");

            double total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            return total / arr.Length;
        }

        /// <summary>
        /// Returns a decimal representing the average of a decimal array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal AverageExt(this decimal[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("Attempting to calulate the average of a null array.");

            decimal total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            return total / arr.Length;
        }

        /// <summary>
        /// Returns a double representing the median of a double array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double MedianExt(this int[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("Attempting to calulate the median of a null array.");

            Array.Sort(arr);
            if (arr.Length.IsEvenExt())
            {
                return (arr[(arr.Length / 2) - 1] + arr[((arr.Length + 2) - 1) / 2]) / 2.0;
            }
            else
            {
                return (arr[((arr.Length + 1) / 2) - 1]);
            }
        }

        /// <summary>
        /// Returns a double representing the median of a double array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double MedianExt(this double[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("Attempting to calulate the median of a null array.");

            Array.Sort(arr);
            if (arr.Length.IsEvenExt())
            {
                return (arr[(arr.Length / 2) - 1] + arr[((arr.Length + 2) - 1) / 2]) / 2;
            }
            else
            {
                return (arr[((arr.Length + 1) / 2) - 1]);
            }
        }

        /// <summary>
        /// Returns a decimal representing the median of a decimal array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static decimal MedianExt(this decimal[] arr)
        {
            if (arr == null)
                throw new NullReferenceException("Attempting to calulate the median of a null array.");

            Array.Sort(arr);
            if (arr.Length.IsEvenExt())
            {
                return (arr[(arr.Length / 2) - 1] + arr[((arr.Length + 2) - 1) / 2]) / 2;
            }
            else
            {
                return (arr[((arr.Length + 1) / 2) - 1]);
            }
        }

        /// <summary>
        /// Returns true if a number is even.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsEvenExt(this int num) => num % 2 == 0;

        /// <summary>
        /// Returns true if a number is odd.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsOddExt(this int num) => num % 2 != 0;

        /// <summary>
        /// Returns true if a number is even.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsEvenExt(this double num) => num % 2 == 0;

        /// <summary>
        /// Returns true if a number is odd.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsOddExt(this double num) => num % 2 != 0;

        /// <summary>
        /// Returns true if a number is even.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsEvenExt(this decimal num) => num % 2 == 0;

        /// <summary>
        /// Returns true if a number is odd.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsOddExt(this decimal num) => num % 2 != 0;

        /// <summary>
        /// Returns a boolean value indicating if the double is an integral value.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsIntegralExt(this double num) => num % 1 == 0;

        /// <summary>
        /// Returns a boolean value indicating if the decimal is an integral value.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsIntegralExt(this decimal num) => num % 1 == 0;

        /// <summary>
        /// Maps to Array.Exists
        /// Takes an arrow function as a parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static bool ExistsExt<T>(this T[] arr, Predicate<T> match) => Array.Exists(arr, match);

        /// <summary>
        /// Checks if a string array contains a specific string. 
        /// Is case sensitive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static bool ContainsExt(this string[] arr, string match) => Array.Exists(arr, x => x == match);

        /// <summary>
        /// Checks if an element in a string array starts with one or more letters (case sensitive). 
        /// Is case sensitive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static bool StartsWithExt(this string[] arr, string match) => Array.Exists(arr, x => x.StartsWith(match));

        /// <summary>
        /// Checks if an element in a string array ends with a one or more letters (case sensitive). 
        /// Is case sensitive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static bool EndsWithExt(this string[] arr, string match) => Array.Exists(arr, x => x.EndsWith(match));

        /// <summary>
        /// Maps to Array.Find
        /// Returns the first occurance of an element in an array that matches the arrow function parameter.
        /// Takes an arrow function as a parameter.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T FindExt<T>(this T[] arr, Predicate<T> value) => Array.Find(arr, value);

        /// <summary>
        /// Maps to Array.FindAll
        /// Returns an array of all the matching elements in an array that match the arrow function parameter.
        /// Takes an arrow function as a parameter.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static T[] FindAllExt<T>(this T[] arr, Predicate<T> match) => Array.FindAll(arr, match);

        /// <summary>
        /// Maps to Array.FindIndex
        /// Returns the zero-based index of the first element that matches the arrow function parameter.
        /// Takes an arrow function as a parameter.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static int FindIndexExt<T>(this T[] arr, Predicate<T> match) => Array.FindIndex(arr, match);

        /// <summary>
        /// Maps to Array.FindLast
        /// Returns the loast occurance of an element in an array that matches the arrow function parameter.
        /// Takes an arrow function as a parameter.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static T FindLastExt<T>(this T[] arr, Predicate<T> match) => Array.FindLast(arr, match);

        /// <summary>
        /// Maps to Array.FindLastIndex
        /// Returns the zero-based index of the last element that matches the arrow function parameter.
        /// Takes an arrow function as a parameter.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        public static int FindLastIndexExt<T>(this T[] arr, Predicate<T> match) => Array.FindLastIndex(arr, match);

        /// <summary>
        /// Returns an int array of all the values that are between an lower bound and an upper bound, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int[] FindBetweenExt(this int[] arr, int lower, int upper) => Array.FindAll(arr, x => x > lower && x < upper);

        /// <summary>
        /// Returns an int array of all the values that are between an lower bound and an upper bound, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int[] FindBetweenInclusiveExt(this int[] arr, int lower, int upper) => Array.FindAll(arr, x => x >= lower && x <= upper);

        /// <summary>
        /// Returns a double array of all the values that are between an lower bound and an upper bound, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static double[] FindBetweenExt(this double[] arr, double lower, double upper) => Array.FindAll(arr, x => x > lower && x < upper);

        /// <summary>
        /// Returns a double array of all the values that are between an lower bound and an upper bound, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static double[] FindBetweenInclusiveExt(this double[] arr, double lower, double upper) => Array.FindAll(arr, x => x >= lower && x <= upper);

        /// <summary>
        /// Returns a decimal array of all the values that are between an lower bound and an upper bound, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static decimal[] FindBetweenExt(this decimal[] arr, decimal lower, decimal upper) => Array.FindAll(arr, x => x > lower && x < upper);

        /// <summary>
        /// Returns a decimal array of all the values that are between an lower bound and an upper bound, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static decimal[] FindBetweenInclusiveExt(this decimal[] arr, decimal lower, decimal upper) => Array.FindAll(arr, x => x >= lower && x <= upper);

        /// <summary>
        /// Returns an int array of all the values that are greater than a target number, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int[] FindGreaterThanExt(this int[] arr, int target) => Array.FindAll(arr, x => x > target);

        /// <summary>
        /// Returns an int array of all the values that are greater than a target number, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int[] FindGreaterThanInclusiveExt(this int[] arr, int target) => Array.FindAll(arr, x => x >= target);

        /// <summary>
        /// Returns a double array of all the values that are greater than a target number, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static double[] FindGreaterThanExt(this double[] arr, double target) => Array.FindAll(arr, x => x > target);

        /// <summary>
        /// Returns a double array of all the values that are greater than a target number, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static double[] FindGreaterThanInclusiveExt(this double[] arr, double target) => Array.FindAll(arr, x => x >= target);

        /// <summary>
        /// Returns a decimal array of all the values that are greater than a target number, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static decimal[] FindGreaterThanExt(this decimal[] arr, decimal target) => Array.FindAll(arr, x => x > target);

        /// <summary>
        /// Returns a decimal array of all the values that are greater than a target number, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static decimal[] FindGreaterThanInclusiveExt(this decimal[] arr, decimal target) => Array.FindAll(arr, x => x >= target);

        /// <summary>
        /// Returns an int array of all the values that are less than a target number, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int[] FindLessThanExt(this int[] arr, int target) => Array.FindAll(arr, x => x < target);

        /// <summary>
        /// Returns an int array of all the values that are less than a target number, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static int[] FindLessThanInclusiveExt(this int[] arr, int target) => Array.FindAll(arr, x => x <= target);

        /// <summary>
        /// Returns a double array of all the values that are less than a target number, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static double[] FindLessThanExt(this double[] arr, double target) => Array.FindAll(arr, x => x < target);

        /// <summary>
        /// Returns a double array of all the values that are less than a target number, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static double[] FindLessThanInclusiveExt(this double[] arr, double target) => Array.FindAll(arr, x => x <= target);

        /// <summary>
        /// Returns a decimal array of all the values that are less than a target number, not inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static decimal[] FindLessThanExt(this decimal[] arr, decimal target) => Array.FindAll(arr, x => x < target);

        /// <summary>
        /// Returns a decimal array of all the values that are less than a target number, inclusive.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static decimal[] FindLessThanInclusiveExt(this decimal[] arr, decimal target) => Array.FindAll(arr, x => x <= target);
    }
}
