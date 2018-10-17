using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Extensions.net
{
    public static class ArrayExtensions
    {
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
    }
}
