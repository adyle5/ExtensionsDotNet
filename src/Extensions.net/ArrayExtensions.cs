// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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
        /// Complex classes must be marked as serializable.
        /// O(n) time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] CopyDeepExt<T>(this T[] arr) where T : class
        {
            if (arr == null) return arr;

            T[] arr2 = new T[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetType().IsSerializable)
                {
                    arr2[i] = arr[i].DeepCopyExt();
                }
            }

            return arr2;
        }

        /// <summary>
        /// Performs a deep copy of an array containing reference types.
        /// Complex classes must be marked as serializable.
        /// O(n) time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] CopyDeepExt<T>(this T[] arr, int index, int length) where T : class
        {
            if (arr == null) return arr;

            if (index > arr.Length || index + length > arr.Length)
                throw new OverflowException("Array dimensions exceeded supported range.");

            T[] arr2 = new T[length];

            if (index <= length && (index + length) <= arr.Length)
            {
                for (int baseI = 0; baseI < length; baseI++)
                {
                    int i = baseI + index;
                    if (arr[i].GetType().IsSerializable)
                    {
                        arr2[baseI] = arr[i].DeepCopyExt();
                    }
                }
            }
            else return arr;

            return arr2;
        }

        /// <summary>
        /// Copies an array of type T into a new array of type T and inserts a value into the position specified.
        /// This performs a deep copy of the first of array and of the value being inserted, so the new array and existing array will not point to the same location in memory.
        /// Position is zero based, so to put an item between the send and third item, position should be set to 2.
        /// This extension method may have time complexities that make it costly to run on a large array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T[] InsertDeepExt<T>(this T[] arr, T value, int position) where T : class
        {
            if (arr == null)
                return arr;

            if (position > arr.Length + 1 || position < 0)
                throw new ArgumentOutOfRangeException(nameof(position));

            T[] newArr = new T[arr.Length + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < position)
                {
                    newArr[i] = arr[i].DeepCopyExt();
                }
                else if (i > position)
                {
                    newArr[i] = arr[i -1].DeepCopyExt();
                }
                else if (i == position)
                {
                    newArr[i] = value.DeepCopyExt();
                }
            }

            return newArr;
        }

        /// <summary>
        /// Copies an array of type T into a new array of type T and inserts a value into the position specified.
        /// This performs a shallow copy, so the generated array items will share the same memory location as the items in the first array and as the inserted value, if those values are reference types.
        /// This extension method may have time complexities that make it costly to run on a very large array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T[] InsertExt<T>(this T[] arr, T value, int position)
        {
            if (arr == null)
                return arr;

            if (position > arr.Length + 1 || position < 0)
                throw new ArgumentOutOfRangeException(nameof(position));

            T[] newArr = new T[arr.Length + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < position)
                {
                    newArr[i] = arr[i];
                }
                else if (i > position)
                {
                    newArr[i] = arr[i - 1];
                }
                else if (i == position)
                {
                    newArr[i] = value;
                }
            }

            return newArr;
        }

        /// <summary>
        /// Concatenate two arrays. Shallow copy only. For deep copy (ref types) use ConcatenateDeepExt.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static T[] ConcatenateExt<T>(this T[] arr, T[] arr2)
        {
            if (arr == null || arr2 == null)
                return arr;

            T[] newArr = new T[arr.Length + arr2.Length];
            arr.CopyTo(newArr, 0);
            arr2.CopyTo(newArr, arr.Length);
            return newArr;
        }

        /// <summary>
        /// Concatenate two arrays. Deep copy. For shallow copy use ConcatenateExt.
        /// Type must implement ISerializable
        /// Not recommended for large arrays.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static T[] ConcatenateDeepExt<T>(this T[] arr, T[] arr2) where T : class
        {
            if (arr == null || arr2 == null)
                return arr;

            T[] newArr = new T[arr.Length + arr2.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = (T)arr[i].DeepCopyExt();
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                int j = i + arr.Length;
                newArr[j] = (T)arr2[i].DeepCopyExt();
            }

            return newArr;
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
        /// Returns the mode or modes of an int array as a generic list of integers.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> ModeExt(this int[] arr)
        {
            var mode = new List<int>();
            int count = 1;

            int[] duplicates = arr.DuplicatesExt();
            for (int i = 0; i < duplicates.Length; i++)
            {
                int c = arr.FindAllExt(x => x == duplicates[i]).Length;
                if (c > 1 && c > count)
                {
                    mode.Clear();
                    mode.Add(duplicates[i]);
                    count = c;
                }
                else if (c > 1 && c == count)
                {
                    mode.Add(duplicates[i]);
                }
            }

            return mode;
        }

        /// <summary>
        /// Returns the mode or modes of a double array as a generic list of doubles.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<double> ModeExt(this double[] arr)
        {
            var mode = new List<double>();
            int count = 1;

            double[] duplicates = arr.DuplicatesExt();
            for (int i = 0; i < duplicates.Length; i++)
            {
                int c = arr.FindAllExt(x => x == duplicates[i]).Length;
                if (c > 1 && c > count)
                {
                    mode.Clear();
                    mode.Add(duplicates[i]);
                    count = c;
                }
                else if (c > 1 && c == count)
                {
                    mode.Add(duplicates[i]);
                }
            }

            return mode;
        }

        /// <summary>
        /// Returns the mode or modes of a decimal array as a generic list of decimals.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<decimal> ModeExt(this decimal[] arr)
        {
            var mode = new List<decimal>();
            int count = 1;

            decimal[] duplicates = arr.DuplicatesExt();
            for (int i = 0; i < duplicates.Length; i++)
            {
                int c = arr.FindAllExt(x => x == duplicates[i]).Length;
                if (c > 1 && c > count)
                {
                    mode.Clear();
                    mode.Add(duplicates[i]);
                    count = c;
                }
                else if (c > 1 && c == count)
                {
                    mode.Add(duplicates[i]);
                }
            }

            return mode;
        }
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
        /// Returns the last occurrence of an element in an array that matches the arrow function parameter.
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

        /// <summary>
        /// Maps to Array.ForEach
        /// Iterates through an array and performs the specified action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="action"></param>
        public static void ForEachExt<T>(this T[] arr, Action<T> action) => Array.ForEach<T>(arr, action);

        /// <summary>
        /// Maps to Array.Reverse
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void ReverseExt<T>(this T[] arr) => Array.Reverse(arr);

        /// <summary>
        /// Returns a string representation of the values in an array separated by a comma.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string ToStringExt<T>(this T[] arr) => string.Join(",", arr);

        /// <summary>
        /// Returns a string representation of the values in an array separated by a provided string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ToStringExt<T>(this T[] arr, string separator) => string.Join(separator, arr);

        /// <summary>
        /// Returns an ArraySegment from an Array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static ArraySegment<T> ToArraySegmentExt<T>(this T[] arr, int offset, int length) => new (arr, offset, length);

        /// <summary>
        /// Returns a splice of an array into a new array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static T[] SpliceExt<T>(this T[] arr, int offset, int length)
        {
            ArraySegment<T> arrSeg = arr.ToArraySegmentExt(offset, length);
            return arrSeg.ToArray();
        }

        /// <summary>
        /// Maps to Array.Resize
        /// Changes the size of the array to the value passed in the newSize parameter.
        /// Because of Type constraints in .NET must pass in the array as a parameter.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="newSize"></param>
#pragma warning disable IDE0060 // Remove unused parameter
        public static void ResizeExt<T>(this T[] arr, ref T[] sameArray, int newSize) => Array.Resize(ref sameArray, newSize);
#pragma warning restore IDE0060 // Remove unused parameter

        /// <summary>
        /// Returns all the duplicate values in an array in a new array.
        /// Uses Linq which may affect time complexity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] DuplicatesExt<T>(this T[] arr)
        {
            return arr.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).Distinct().ToArray();
        }

        /// <summary>
        /// Returns a random value from an array.
        /// If the array is null or empty, will throw an ArgumentNullException.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T RandomExt<T>(this T[] arr)
        {
            if (arr != null && arr.Length > 0)
            {
                Random random = new ();
                int num = random.Next(arr.Length);
                return arr[num];
            }
            else
            {
                throw new ArgumentNullException(nameof(arr));
            }
        }

        /// <summary>
        /// Uses System.Xml.Serialization.XmlSerializer to serialize an array and return an xml string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string ToXmlSerializeExt<T>(this T[] arr)
        {
            var ser = new System.Xml.Serialization.XmlSerializer(typeof(T[]));
            using var tw = new System.IO.StringWriter();
            ser.Serialize(tw, arr);
            return tw.ToString();
        }

        /// <summary>
        /// Returns a string as Xml from the extended array, were each item of the array is an element in the xml string.
        /// First paramater is a required element name.
        /// Root name is optional. If not supplied to the method, the root element will be Root.
        /// Namespace is optional.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="elementName"></param>
        /// <param name="root"></param>
        /// <param name="ns"></param>
        /// <returns></returns>
        public static string ToXmlExt<T>(this T[] arr, string elementName, string root = "Root", string ns = "")
        {
            XNamespace nspace = ns;

            XDocument xDocument = new(
                new XElement(nspace + root));

            foreach (var item in arr)
            {
                xDocument.Root.Add(new XElement(nspace + elementName, item.ToString()));
            }

            return xDocument.ToString();
        }

        /// <summary>
        /// Returns an XDocument from the extended array, were each item of the array is an element in the XDocument.
        /// First paramater is a required element name.
        /// Root name is optional. If not supplied to the method, the root element will be Root.
        /// Namespace is optional.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static XDocument ToXDocumentExt<T>(this T[] arr, string elementName, string root = "Root", string ns = "")
        {
            XNamespace nspace = ns;

            XDocument xDocument = new(
               new XElement(nspace + root));

            foreach (var item in arr)
            {
                xDocument.Root.Add(new XElement(nspace + elementName, item.ToString()));
            }

            return xDocument;
        }

        /// <summary>
        /// Converts the extended array to a Json array string.
        /// If the array is not strings, will write the ToString result of each item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string ToJsonExt<T>(this T[] arr)
        {
            if (arr!=null)
            {
                StringBuilder sb = new ();
                sb.Append("[\"");
                sb.Append(string.Join("\",\"", arr));
                sb.Append("\"]");

                return sb.ToString();
            }

            throw new ArgumentNullException(nameof(arr));
        }

        /// <summary>
        /// Converts the extended array to a Json string with a property that holds an array.
        /// If the array is not strings, will write the ToString result of each item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ToJsonExt<T>(this T[] arr, string propertyName)
        {
            if (arr != null)
            {
                StringBuilder sb = new ();
                sb.Append('{');
                sb.Append($"\"{propertyName}\":[\"");
                sb.Append(string.Join("\",\"", arr));
                sb.Append("\"]");
                sb.Append('}');

                return sb.ToString();
            }

            throw new ArgumentNullException(nameof(arr));
        }

        /// <summary>
        /// Returns true if the extended array is null or empty.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool IsNullOrEmptyExt<T>(this T[] arr) => arr == null || arr.Length == 0;

        /// <summary>
        /// Rearranges the objects in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static T[] ShuffleExt<T>(this T[] arr)
        {
            if (arr.IsNullOrEmptyExt())
                return arr;

            var list = new System.Collections.Generic.List<T>();

            Random rnd = new();
            for (int m = 0; m < arr.Length; m++)
            {
                bool cont = true;
                while (cont)
                {
                    int randomNum = rnd.Next(arr.Length);
                    if (!list.Contains(arr[randomNum]))
                    {
                        list.Add(arr[randomNum]);
                        cont = false;
                    }
                }
            }

            return list.ToArray<T>();
        }

        /// <summary>
        /// Outputs all strings in a string array to the console with each string in a new line.
        /// </summary>
        /// <param name="arr"></param>
        public static void ToConsoleExt(this string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// Outputs all strings in a generic list of strings to the console with each string in a new line.
        /// </summary>
        /// <param name="lst"></param>
        public static void ToConsoleExt(this List<string> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
        }

        /// <summary>
        /// Returns every nth value of an array in a new IEnumberable collection. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="occurence"></param>
        public static IEnumerable<T> EveryExt<T>(this T[] arr, int occurence)
        {
            for(int i = occurence - 1; i < arr.Length; i += occurence)
            {
                yield return arr[i];
            }
        }
    }
}