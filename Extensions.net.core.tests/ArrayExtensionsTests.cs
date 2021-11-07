// Copyright © 2021 Adrian Gabor
// Refer to license.txt for usage and permission information 

using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Extensions.net.core.tests
{
    public class ArrayExtensionsTests
    {
        ITestOutputHelper output;

        public ArrayExtensionsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Sort()
        {
            int[] arr1 = { 2, 5, 3, 4, 1 };
            int[] arr2 = { 2, 5, 3, 4, 1 };
            Array.Sort(arr1);
            arr2.SortExt();
            Assert.Equal(arr1, arr2);

            string[] arr3 = { "one", "two", "three", "four", "five" };
            string[] arr4 = { "one", "two", "three", "four", "five" };
            Array.Sort(arr3);
            arr4.SortExt();

            Assert.Equal(arr3, arr4);

            DateTime[] arr5 = { new DateTime(2018, 10, 17), new DateTime(2018, 9, 17), new DateTime(2018, 10, 16), new DateTime(2017, 10, 17), new DateTime(2018, 12, 29) };
            DateTime[] arr6 = { new DateTime(2018, 10, 17), new DateTime(2018, 9, 17), new DateTime(2018, 10, 16), new DateTime(2017, 10, 17), new DateTime(2018, 12, 29) };

            Array.Sort(arr5);
            arr6.SortExt();

            Assert.Equal(arr5, arr6);

            DateTime[] arr7 = { new DateTime(2018, 10, 17), new DateTime(2018, 9, 17), new DateTime(2018, 10, 16), new DateTime(2017, 10, 17), new DateTime(2018, 12, 29) };
            DateTime[] arr8 = { new DateTime(2018, 10, 17), new DateTime(2018, 9, 17), new DateTime(2018, 10, 16), new DateTime(2017, 10, 17), new DateTime(2018, 12, 29) };

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = SortDotNet(arr7), () => actualElapsed = SortExt(arr8));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void BinarySearch()
        {
            int[] arr1 = { 2, 5, 3, 4, 1 };

            Assert.Equal(Array.BinarySearch(arr1, 3), arr1.BinarySearchExt(3));

            int[] arr2 = { 54, 333, 44, 379, 261, 87, 186, 645, 135, 67, 440, 209, 927, 353, 372, 152, 478, 757, 43, 75, 411, 569, 480, 272, 88, 928, 605, 439, 850, 789, 964, 618, 166, 968, 890, 934, 29, 792, 817, 25, 11, 248, 95, 294, 470, 536, 177, 259, 687, 956, 557, 912, 566, 287, 594, 406, 26, 28, 778, 101, 938, 957, 543, 498, 938, 200, 255, 628, 549, 216, 749, 441, 203, 948, 537, 550, 772, 278, 492, 839, 913, 458, 565, 754, 656, 234, 665, 463, 361, 350, 661, 902, 314, 203, 247, 870, 986, 673, 844, 950, 199, 395, 947, 584, 464, 96, 305, 244, 320, 802, 292, 37, 45, 732, 774, 793, 883, 962, 979, 994, 549, 904, 929, 661, 29, 898, 985, 315, 300, 649, 264, 512, 728, 8, 994, 805, 581, 605, 571, 555, 915, 551, 705, 807, 224, 250, 432, 445, 183, 327, 878, 968, 865, 104, 787, 244, 17, 678, 801, 811, 645, 988, 863, 564, 60, 997, 167, 571, 588, 21, 476, 987, 81, 912, 822, 55, 643, 960, 584, 374, 285, 987, 399, 445, 472, 364, 734, 428, 628, 514, 724, 714, 659, 297, 569, 13, 474, 424, 698, 49, 747, 836, 241, 729, 628, 818, 825, 714, 210, 917, 68, 100, 687, 900, 610, 836, 998, 19, 214, 920, 151, 701, 905, 338, 70, 732, 573, 609, 564, 588, 550, 617, 724, 751, 296, 392, 783, 806, 970, 850, 932, 333, 581, 62, 807, 19, 132, 738, 146, 31, 313, 480, 973, 362, 552, 872, 135, 783, 508, 967, 988, 417, 723, 662, 866, 448, 2, 124, 700, 214, 215, 283, 656, 51, 126, 12, 477, 132, 377, 892, 92, 775, 720, 457, 807, 810, 594, 222, 984, 763, 327, 606, 731, 640, 273, 658, 586, 757, 221, 110, 214, 192, 633, 694, 754, 602, 944, 584, 526, 717, 600, 50, 487, 165, 805, 596, 726, 805, 403, 279, 907, 544, 464, 424, 887, 437, 775, 218, 492, 100, 170, 291, 202, 187, 72, 754, 168, 891, 338, 271, 320, 359, 934, 635, 230, 890, 516, 215, 747, 747, 320, 644, 502, 210, 316, 387, 698, 112, 109, 217, 907, 584, 480, 542, 792, 414, 635, 579, 48, 967, 660, 287, 5, 503, 956, 986, 591, 194, 931, 200, 766, 656, 800, 367, 926, 734, 542, 309, 707, 234, 637, 580, 983, 275, 161, 433, 50, 491, 621, 83, 109, 49, 28, 486, 333, 500, 663, 144, 80, 714, 725, 791, 383, 387, 922, 124, 793, 305, 631, 307, 467, 894, 613, 550, 872, 5, 597, 664, 133, 110, 978, 687, 831, 430, 156, 488, 961, 707, 739, 234, 245, 591, 445, 965, 455, 638, 978, 795, 579, 899, 874, 656, 400, 698, 263, 935, 918, 847, 813, 940, 582, 968, 753, 978, 325, 151, 192, 792, 223, 552, 504, 287, 585, 436, 456, 327, 154, 657, 996, 541, 223, 749, 490, 965, 711, 951, 939, 537, 148, 290, 152, 23, 770, 865, 860, 903, 41, 296, 381, 838 };
            int target = 569;
            //First call might skew results, so let's get it out of the way.
            Array.BinarySearch(arr2, target);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = BinarySearchDotNet(arr2, target), () => actualElapsed = BinarySearchExt(arr2, target));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }
        }

        [Fact]
        public void BinarySearch2()
        {
            int index = 0;
            int length = 3;
            int[] arr1 = { 2, 5, 3, 4, 1 };

            Assert.Equal(Array.BinarySearch(arr1, index, length, 3), arr1.BinarySearchExt(index, length, 3));

            int[] arr2 = { 54, 333, 44, 379, 261, 87, 186, 645, 135, 67, 440, 209, 927, 353, 372, 152, 478, 757, 43, 75, 411, 569, 480, 272, 88, 928, 605, 439, 850, 789, 964, 618, 166, 968, 890, 934, 29, 792, 817, 25, 11, 248, 95, 294, 470, 536, 177, 259, 687, 956, 557, 912, 566, 287, 594, 406, 26, 28, 778, 101, 938, 957, 543, 498, 938, 200, 255, 628, 549, 216, 749, 441, 203, 948, 537, 550, 772, 278, 492, 839, 913, 458, 565, 754, 656, 234, 665, 463, 361, 350, 661, 902, 314, 203, 247, 870, 986, 673, 844, 950, 199, 395, 947, 584, 464, 96, 305, 244, 320, 802, 292, 37, 45, 732, 774, 793, 883, 962, 979, 994, 549, 904, 929, 661, 29, 898, 985, 315, 300, 649, 264, 512, 728, 8, 994, 805, 581, 605, 571, 555, 915, 551, 705, 807, 224, 250, 432, 445, 183, 327, 878, 968, 865, 104, 787, 244, 17, 678, 801, 811, 645, 988, 863, 564, 60, 997, 167, 571, 588, 21, 476, 987, 81, 912, 822, 55, 643, 960, 584, 374, 285, 987, 399, 445, 472, 364, 734, 428, 628, 514, 724, 714, 659, 297, 569, 13, 474, 424, 698, 49, 747, 836, 241, 729, 628, 818, 825, 714, 210, 917, 68, 100, 687, 900, 610, 836, 998, 19, 214, 920, 151, 701, 905, 338, 70, 732, 573, 609, 564, 588, 550, 617, 724, 751, 296, 392, 783, 806, 970, 850, 932, 333, 581, 62, 807, 19, 132, 738, 146, 31, 313, 480, 973, 362, 552, 872, 135, 783, 508, 967, 988, 417, 723, 662, 866, 448, 2, 124, 700, 214, 215, 283, 656, 51, 126, 12, 477, 132, 377, 892, 92, 775, 720, 457, 807, 810, 594, 222, 984, 763, 327, 606, 731, 640, 273, 658, 586, 757, 221, 110, 214, 192, 633, 694, 754, 602, 944, 584, 526, 717, 600, 50, 487, 165, 805, 596, 726, 805, 403, 279, 907, 544, 464, 424, 887, 437, 775, 218, 492, 100, 170, 291, 202, 187, 72, 754, 168, 891, 338, 271, 320, 359, 934, 635, 230, 890, 516, 215, 747, 747, 320, 644, 502, 210, 316, 387, 698, 112, 109, 217, 907, 584, 480, 542, 792, 414, 635, 579, 48, 967, 660, 287, 5, 503, 956, 986, 591, 194, 931, 200, 766, 656, 800, 367, 926, 734, 542, 309, 707, 234, 637, 580, 983, 275, 161, 433, 50, 491, 621, 83, 109, 49, 28, 486, 333, 500, 663, 144, 80, 714, 725, 791, 383, 387, 922, 124, 793, 305, 631, 307, 467, 894, 613, 550, 872, 5, 597, 664, 133, 110, 978, 687, 831, 430, 156, 488, 961, 707, 739, 234, 245, 591, 445, 965, 455, 638, 978, 795, 579, 899, 874, 656, 400, 698, 263, 935, 918, 847, 813, 940, 582, 968, 753, 978, 325, 151, 192, 792, 223, 552, 504, 287, 585, 436, 456, 327, 154, 657, 996, 541, 223, 749, 490, 965, 711, 951, 939, 537, 148, 290, 152, 23, 770, 865, 860, 903, 41, 296, 381, 838 };
            int target = 569;
            length = 300;
            //First call might skew results, so let's get it out of the way.
            Array.BinarySearch(arr2, index, length, target);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = BinarySearchDotNet(arr2, target, index, length), () => actualElapsed = BinarySearchExt(arr2, target, index, length));

            try
            {
                Assert.True(Math.Abs(expectedElapsed - actualElapsed) < Consts.TEST_TICKS);
            }
            catch (Xunit.Sdk.XunitException e)
            {
                output.WriteLine(e.Message);
                output.WriteLine((expectedElapsed - actualElapsed).ToString());
            }           
        }


        [Fact]
        public void CopyDeep()
        {
            string[] arr1 = { "one", "two", "three", "four", "five" };
            string[] arr2 = arr1.CopyDeepExt();

            Assert.False(Object.ReferenceEquals(arr2[0], arr1[0])); // strings do not point to the same memory loc.

            string[] arr3 = new string[arr1.Length];
            Array.Copy(arr1, arr3, arr3.Length);

            Assert.True(Object.ReferenceEquals(arr3[0], arr1[0])); // strings point to the same memory loc.
        }

        [Fact]
        public void CopyDeep2()
        {
            string[] arr1 = { "one", "two", "three", "four", "five" };
            string[] arr2 = arr1.CopyDeepExt(1, 3);

            Assert.Equal(new string[] { "two", "three", "four" }, arr2);
            Assert.False(Object.ReferenceEquals(arr2[0], arr1[0])); // strings do not point to the same memory loc.

            string[] arr3 = new string[arr1.Length];
            Array.Copy(arr1, arr3, arr3.Length);

            Assert.True(Object.ReferenceEquals(arr3[0], arr1[0])); // strings point to the same memory loc.

            Assert.Throws<OverflowException>(() => arr2.CopyDeepExt(10, 10));

        }

        [Fact]
        public void Concatenate()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] newArr = arr1.ConcatenateExt(arr2);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6 }, newArr);

            string[] arr3 = { "one", "two", "three" };
            string[] arr4 = { "four", "five" };
            string[] newArr2 = arr3.ConcatenateExt(arr4);
            Assert.Equal(new string[] { "one", "two", "three", "four", "five" }, newArr2);

            Assert.True(Object.ReferenceEquals(arr3[0], newArr2[0]));
        }

        [Fact]
        public void ConcatenateDeep()
        {
            string[] arr1 = { "one", "two", "three" };
            string[] arr2 = { "four", "five" };
            string[] newArr = arr1.ConcatenateDeepExt(arr2);
            Assert.Equal(new string[] { "one", "two", "three", "four", "five" }, newArr);

            Assert.False(Object.ReferenceEquals(arr1[0], newArr[0]));
        }

        [Fact]
        public void Insert()
        {
            string[] arr1 = { "one", "two", "four", "five" };
            string valToInsert = "three";
            int position = 2;
            string[] arr2 = arr1.InsertExt(valToInsert, position);

            Assert.True(arr2.Length == 5);
            Assert.Equal(new string[] { "one", "two", "three", "four", "five" }, arr2);
            Assert.True(Object.ReferenceEquals(arr1[0], arr2[0]));
            Assert.Throws<ArgumentOutOfRangeException>(() => arr2.InsertDeepExt("ten", 10));
        }

        [Fact]
        public void InsertDeep()
        {
            string[] arr1 = { "one", "two", "four", "five" };
            string valToInsert = "three";
            int position = 2;
            string[] arr2 = arr1.InsertDeepExt(valToInsert, position);

            Assert.True(arr2.Length == 5);
            Assert.Equal(new string[] { "one", "two", "three", "four", "five" }, arr2);
            Assert.False(Object.ReferenceEquals(arr1[0], arr2[0]));
            Assert.Throws<ArgumentOutOfRangeException>(() => arr2.InsertDeepExt("ten", 10));
        }

        [Fact]
        public void NewNullArray()
        {
            string[] arr1 = { "one", "two", "three", "four", "five" };
            string[] arr2 = arr1.NewNullArrayExt();
            Assert.Equal(arr1.Length, arr2.Length);
            Assert.Null(arr2[2]);
        }

        [Fact]
        public void Join()
        {
            string[] arr1 = { "one", "two", "three", "four", "five" };
            string str1 = arr1.JoinExt(" ");
            Assert.Equal("one two three four five", str1);

            int[] arr2 = { 1, 2, 3, 4, 5 };
            string str2 = arr2.JoinExt("");
            Assert.Equal("12345", str2);
        }

        [Fact]
        public void AverageInt()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal((1 + 2 + 3 + 4 + 5 + 6) / 6.0, arr.AverageExt());
        }

        [Fact]
        public void AverageDouble()
        {
            double[] arr = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            Assert.Equal((1.0 + 2.0 + 3.0 + 4.0 + 5.0 + 6.0) / 6, arr.AverageExt());
        }

        [Fact]
        public void AverageDecimal()
        {
            decimal[] arr = { 1.0M, 2.0M, 3.0M, 4.0M, 5.0M, 6.0M };
            Assert.Equal((1.0M + 2.0M + 3.0M + 4.0M + 5.0M + 6.0M) / 6, arr.AverageExt());
        }

        [Fact]
        public void MedianInt()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            Assert.Equal(3, arr1.MedianExt());

            int[] arr2 = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(3.5, arr2.MedianExt());

            int[] arr3 = { -6, 2, -3, 14, 5, 26 };
            Assert.Equal(3.5, arr3.MedianExt());

            int[] arr4 = null;
            Assert.Throws<NullReferenceException>(() => arr4.MedianExt());
        }

        [Fact]
        public void MedianDouble()
        {
            double[] arr1 = { 1, 2, 3, 4, 5 };
            Assert.Equal(3, arr1.MedianExt());

            double[] arr2 = { -90, -5.4, 0, 1.5, 7.6, 120 };
            Assert.Equal(0.75, arr2.MedianExt());

            double[] arr3 = { -6, 2, -3, 14, 5, 26 };
            Assert.Equal(3.5, arr3.MedianExt());

            double[] arr4 = null;
            Assert.Throws<NullReferenceException>(() => arr4.MedianExt());
        }

        [Fact]
        public void MedianDecimal()
        {
            decimal[] arr1 = { 1M, 2M, 3M, 4M, 5M };
            Assert.Equal(3, arr1.MedianExt());

            decimal[] arr2 = { -90M, -5.4M, 0M, 1.5M, 7.6M, 120M };
            Assert.Equal(0.75M, arr2.MedianExt());

            decimal[] arr3 = { -6M, 2M, -3M, 14M, 5M, 26M };
            Assert.Equal(3.5M, arr3.MedianExt());

            decimal[] arr4 = null;
            Assert.Throws<NullReferenceException>(() => arr4.MedianExt());
        }

        [Fact]
        public void Exists()
        {
            string[] arr1 = { "yellow", "green", "blue", "orange", "pink", "purple", "brown", "black", "white", "red", "mauve", "polka dot" };
            Assert.Equal(Array.Exists(arr1, x => x == "purple"), arr1.ExistsExt(x => x == "purple"));
        }

        [Fact]
        public void Contains()
        {
            string[] arr1 = { "yellow", "green", "blue", "orange", "pink", "purple", "brown", "black", "white", "red", "mauve", "polka dot" };
            Assert.Equal(Array.Exists(arr1, x => x == "purple"), arr1.ContainsExt("purple"));
        }

        [Fact]
        public void StartsWith()
        {
            string[] arr1 = { "yellow", "green", "blue", "orange", "pink", "purple", "brown", "black", "white", "red", "mauve", "polka dot" };
            Assert.Equal(Array.Exists(arr1, x => x.StartsWith("ora")), arr1.StartsWithExt("ora"));
        }

        [Fact]
        public void EndsWith()
        {
            string[] arr1 = { "yellow", "green", "blue", "orange", "pink", "purple", "brown", "black", "white", "red", "mauve", "polka dot" };
            Assert.Equal(Array.Exists(arr1, x => x.EndsWith("nge")), arr1.EndsWithExt("nge"));
        }

        [Fact]
        public void Find()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10 };
            Assert.Equal(Array.Find(arr1, x => x > 100), arr1.FindExt(x => x > 100));
        }

        [Fact]
        public void FindAll()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x > 30 && x <= 40), arr1.FindAllExt(x => x > 30 && x <= 40));
        }

        [Fact]
        public void FindIndex()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindIndex(arr1, x => x == 45), arr1.FindIndexExt(x => x == 45));
        }

        [Fact]
        public void FindLast()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindLast(arr1, x => x == 45), arr1.FindLastExt(x => x == 45));
        }

        [Fact]
        public void FindLastIndex()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindLastIndex(arr1, x => x == 45), arr1.FindLastIndexExt(x => x == 45));
        }

        [Fact]
        public void FindBetweenInt()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x > 30 && x < 40), arr1.FindBetweenExt(30, 40));
        }

        [Fact]
        public void FindBetweenInclusiveInt()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x >= 30 && x <= 40), arr1.FindBetweenInclusiveExt(30, 40));
        }

        [Fact]
        public void FindBetweenDouble()
        {
            double[] arr1 = { 100.34, 45, 57.2, 85.934, 203, 125.4, 30.36, 10, 45.9, 155.008, 35.9, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x > 30 && x < 40), arr1.FindBetweenExt(30, 40));
        }

        [Fact]
        public void FindBetweenInclusiveDouble()
        {
            double[] arr1 = { 100.34, 45, 57.2, 85.934, 203, 125.4, 30.36, 10, 45.9, 155.008, 35.9, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x >= 30 && x <= 40), arr1.FindBetweenInclusiveExt(30, 40));
        }

        [Fact]
        public void FindBetweenDecimal()
        {
            decimal[] arr1 = { 100.34M, 45M, 57.2M, 85.934M, 203M, 125.4M, 30.36M, 10M, 45.9M, 155.008M, 35.9M, 45M };
            Assert.Equal(Array.FindAll(arr1, x => x > 30 && x < 40), arr1.FindBetweenExt(30, 40));
        }

        [Fact]
        public void FindBetweenInclusiveDecimal()
        {
            decimal[] arr1 = { 100.34M, 45M, 57.2M, 85.934M, 203M, 125.4M, 30.36M, 10M, 45.9M, 155.008M, 35.9M, 45M };
            Assert.Equal(Array.FindAll(arr1, x => x >= 30 && x <= 40), arr1.FindBetweenInclusiveExt(30, 40));
        }

        [Fact]
        public void FindGreaterThanInt()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x > 30), arr1.FindGreaterThanExt(30));
        }

        [Fact]
        public void FindGreaterThanInclusiveInt()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x >= 30), arr1.FindGreaterThanInclusiveExt(30));
        }

        [Fact]
        public void FindGreaterThanDouble()
        {
            double[] arr1 = { 100.34, 45, 57.2, 85.934, 203, 125.4, 30.36, 10, 45.9, 155.008, 35.9, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x > 30.5), arr1.FindGreaterThanExt(30.5));
        }

        [Fact]
        public void FindGreaterThanInclusiveDouble()
        {
            double[] arr1 = { 100.34, 45, 57.2, 85.934, 203, 125.4, 30.36, 10, 45.9, 155.008, 35.9, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x >= 30.5), arr1.FindGreaterThanInclusiveExt(35));
        }

        [Fact]
        public void FindGreaterThanDecimal()
        {
            decimal[] arr1 = { 100.34M, 45M, 57.2M, 85.934M, 203M, 125.4M, 30.36M, 10M, 45.9M, 155.008M, 35.9M, 45M };
            Assert.Equal(Array.FindAll(arr1, x => x > 30.5M), arr1.FindGreaterThanExt(30.5M));
        }

        [Fact]
        public void FindGreaterThanInclusiveDecimal()
        {
            decimal[] arr1 = { 100.34M, 45M, 57.2M, 85.934M, 203M, 125.4M, 30.36M, 10M, 45.9M, 155.008M, 35.9M, 45M };
            Assert.Equal(Array.FindAll(arr1, x => x >= 30.5M), arr1.FindGreaterThanInclusiveExt(30.5M));
        }

        [Fact]
        public void FindLessThanInt()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x < 30), arr1.FindLessThanExt(30));
        }

        [Fact]
        public void FindLessThanInclusiveInt()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x <= 30), arr1.FindLessThanInclusiveExt(30));
        }

        [Fact]
        public void FindLessThanDouble()
        {
            double[] arr1 = { 100.34, 45, 57.2, 85.934, 203, 125.4, 30.36, 10, 45.9, 155.008, 35.9, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x < 30.5), arr1.FindLessThanExt(30.5));
        }

        [Fact]
        public void FindLessThanInclusiveDouble()
        {
            double[] arr1 = { 100.34, 45, 57.2, 85.934, 203, 125.4, 30.36, 10, 45.9, 155.008, 35.9, 45 };
            Assert.Equal(Array.FindAll(arr1, x => x <= 30.5), arr1.FindLessThanInclusiveExt(35));
        }

        [Fact]
        public void FindLessThanDecimal()
        {
            decimal[] arr1 = { 100.34M, 45M, 57.2M, 85.934M, 203M, 125.4M, 30.36M, 10M, 45.9M, 155.008M, 35.9M, 45M };
            Assert.Equal(Array.FindAll(arr1, x => x < 30.5M), arr1.FindLessThanExt(30.5M));
        }

        [Fact]
        public void FindLessThanInclusiveDecimal()
        {
            decimal[] arr1 = { 100.34M, 45M, 57.2M, 85.934M, 203M, 125.4M, 30.36M, 10M, 45.9M, 155.008M, 35.9M, 45M };
            Assert.Equal(Array.FindAll(arr1, x => x <= 30.5M), arr1.FindLessThanInclusiveExt(30.5M));
        }

        [Fact]
        public void ForEach()
        {
            int[] arr1 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            int[] arr2 = { 100, 45, 57, 85, 203, 125, 30, 10, 45, 155, 35, 45 };
            Action<int> action = new ((val) => Debug.Write(val));
            Array.ForEach(arr1, action);
            arr2.ForEachExt(action);
            Assert.Equal(arr1, arr2);
        }

        [Fact]
        public void Reverse()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { 7, 6, 5, 4, 3, 2, 1 };
            arr.ReverseExt();
            Assert.Equal(arr, arr2);
        }

        [Fact]
        public void ToStringEx()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            string expected = "1,2,3,4,5,6,7";
            Assert.Equal(arr.ToStringExt(), expected);

            expected = "1 : 2 : 3 : 4 : 5 : 6 : 7";
            Assert.Equal(arr.ToStringExt(" : "), expected);
        }

        [Fact]
        public void ToArraySegment()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            ArraySegment<int> expected = new (arr, 1, 3);
            Assert.Equal(expected, arr.ToArraySegmentExt(1, 3));
        }

        [Fact]
        public void Splice()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 2, 3, 4 };
            Assert.Equal(expected, arr.SpliceExt(1, 3));
        }

        [Fact]
        public void Resize()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int len1 = arr.Length;
            int len2 = len1 + 1;

            arr.ResizeExt(ref arr, len2);

            Assert.Equal(len2, arr.Length);
        }

        [Fact]
        public void Duplicates()
        {
            string[] arr = { "apples", "oranges", "bananas", "peaches", "apples", "pears", "bananas", "kiwis" };

            string[] arr2 = { "apples", "bananas" };

            Assert.Equal(arr2, arr.DuplicatesExt());
        }

        [Fact]
        public void Random()
        {
            string[] arr = { "apples", "oranges", "bananas", "peaches", "apples", "pears", "bananas", "kiwis" };
            string actual = arr.RandomExt();
            actual.TraceInformationExt();

            Assert.NotNull(actual);

            string[] arr2 = null;

            Assert.Throws<ArgumentNullException>(() => arr2.RandomExt());
        }


        [Fact]
        public void ToXml()
        {
            string[] arr = { "apples", "oranges", "bananas", "peaches", "apples", "pears", "bananas", "kiwis" };
            string root = "Colors";
            string elementName = "Color";
            string expected = $"<Colors>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Colors>";
            string actual = arr.ToXmlExt(elementName, root);
            Assert.Equal(expected, actual);

            expected = $"<Root>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Root>";
            actual = arr.ToXmlExt(elementName);
            Assert.Equal(expected, actual);

            string nameSpace = "https://www.namespace.com";
            expected = $"<Colors xmlns=\"https://www.namespace.com\">{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Colors>";
            actual = arr.ToXmlExt(elementName, root, nameSpace);
            Assert.Equal(expected, actual);

            expected = $"<Root xmlns=\"https://www.namespace.com\">{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Root>";
            actual = arr.ToXmlExt(elementName, ns: nameSpace);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToXDocument()
        {
            string[] arr = { "apples", "oranges", "bananas", "peaches", "apples", "pears", "bananas", "kiwis" };
            string root = "Colors";
            string elementName = "Color";
            string expected = $"<Colors>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Colors>";
            string actual = arr.ToXDocumentExt(elementName, root).ToString();
            Assert.Equal(expected, actual);

            expected = $"<Root>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Root>";
            actual = arr.ToXDocumentExt(elementName).ToString();
            Assert.Equal(expected, actual);

            string nameSpace = "https://www.namespace.com";
            expected = $"<Colors xmlns=\"https://www.namespace.com\">{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Colors>";
            actual = arr.ToXDocumentExt(elementName, root, nameSpace).ToString();
            Assert.Equal(expected, actual);

            expected = $"<Root xmlns=\"https://www.namespace.com\">{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>oranges</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>peaches</Color>{Environment.NewLine}  <Color>apples</Color>{Environment.NewLine}  <Color>pears</Color>{Environment.NewLine}  <Color>bananas</Color>{Environment.NewLine}  <Color>kiwis</Color>{Environment.NewLine}</Root>";
            actual = arr.ToXDocumentExt(elementName, ns: nameSpace).ToString();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToJson()
        {
            string[] arr = { "apples", "oranges", "bananas", "peaches", "apples", "pears", "bananas", "kiwis" };
            string expected = JsonSerializer.Serialize(arr);
            string actual = arr.ToJsonExt();
            Assert.Equal(expected, actual);

            string name = "colors";
            actual = arr.ToJsonExt(name);
            expected = @"{""colors"":[""apples"",""oranges"",""bananas"",""peaches"",""apples"",""pears"",""bananas"",""kiwis""]}";
            Assert.Equal(expected, actual);
        }

        #region "Private Methods"
        private static long BinarySearchDotNet(int[] arr1, int target)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Array.BinarySearch(arr1, target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long BinarySearchExt(int[] arr1, int target)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            arr1.BinarySearchExt(target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long BinarySearchDotNet(int[] arr1, int target, int index, int length)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Array.BinarySearch(arr1, index, length, target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long BinarySearchExt(int[] arr1, int target, int index, int length)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            arr1.BinarySearchExt(index, length, target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long SortDotNet(DateTime[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Array.Sort(arr);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private static long SortExt(DateTime[] arr)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            arr.SortExt();
            sw.Stop();
            return sw.ElapsedTicks;
        }

        #endregion
    }
}
