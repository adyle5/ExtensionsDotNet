using System;
using System.Diagnostics;
using Xunit;
using System.Threading.Tasks;

namespace Extensions.net.core.tests
{
    public class ArrayExtenstionsTests
    {
        [Fact]
        public void BinarySearch()
        {
            int[] arr1 = { 2,5,3,4,1 };

            Assert.Equal(Array.BinarySearch(arr1, 3), arr1.BinarySearchExt(3));

            int[] arr2 = { 54, 333, 44, 379, 261, 87, 186, 645, 135, 67, 440, 209, 927, 353, 372, 152, 478, 757, 43, 75, 411, 569, 480, 272, 88, 928, 605, 439, 850, 789, 964, 618, 166, 968, 890, 934, 29, 792, 817, 25, 11, 248, 95, 294, 470, 536, 177, 259, 687, 956, 557, 912, 566, 287, 594, 406, 26, 28, 778, 101, 938, 957, 543, 498, 938, 200, 255, 628, 549, 216, 749, 441, 203, 948, 537, 550, 772, 278, 492, 839, 913, 458, 565, 754, 656, 234, 665, 463, 361, 350, 661, 902, 314, 203, 247, 870, 986, 673, 844, 950, 199, 395, 947, 584, 464, 96, 305, 244, 320, 802, 292, 37, 45, 732, 774, 793, 883, 962, 979, 994, 549, 904, 929, 661, 29, 898, 985, 315, 300, 649, 264, 512, 728, 8, 994, 805, 581, 605, 571, 555, 915, 551, 705, 807, 224, 250, 432, 445, 183, 327, 878, 968, 865, 104, 787, 244, 17, 678, 801, 811, 645, 988, 863, 564, 60, 997, 167, 571, 588, 21, 476, 987, 81, 912, 822, 55, 643, 960, 584, 374, 285, 987, 399, 445, 472, 364, 734, 428, 628, 514, 724, 714, 659, 297, 569, 13, 474, 424, 698, 49, 747, 836, 241, 729, 628, 818, 825, 714, 210, 917, 68, 100, 687, 900, 610, 836, 998, 19, 214, 920, 151, 701, 905, 338, 70, 732, 573, 609, 564, 588, 550, 617, 724, 751, 296, 392, 783, 806, 970, 850, 932, 333, 581, 62, 807, 19, 132, 738, 146, 31, 313, 480, 973, 362, 552, 872, 135, 783, 508, 967, 988, 417, 723, 662, 866, 448, 2, 124, 700, 214, 215, 283, 656, 51, 126, 12, 477, 132, 377, 892, 92, 775, 720, 457, 807, 810, 594, 222, 984, 763, 327, 606, 731, 640, 273, 658, 586, 757, 221, 110, 214, 192, 633, 694, 754, 602, 944, 584, 526, 717, 600, 50, 487, 165, 805, 596, 726, 805, 403, 279, 907, 544, 464, 424, 887, 437, 775, 218, 492, 100, 170, 291, 202, 187, 72, 754, 168, 891, 338, 271, 320, 359, 934, 635, 230, 890, 516, 215, 747, 747, 320, 644, 502, 210, 316, 387, 698, 112, 109, 217, 907, 584, 480, 542, 792, 414, 635, 579, 48, 967, 660, 287, 5, 503, 956, 986, 591, 194, 931, 200, 766, 656, 800, 367, 926, 734, 542, 309, 707, 234, 637, 580, 983, 275, 161, 433, 50, 491, 621, 83, 109, 49, 28, 486, 333, 500, 663, 144, 80, 714, 725, 791, 383, 387, 922, 124, 793, 305, 631, 307, 467, 894, 613, 550, 872, 5, 597, 664, 133, 110, 978, 687, 831, 430, 156, 488, 961, 707, 739, 234, 245, 591, 445, 965, 455, 638, 978, 795, 579, 899, 874, 656, 400, 698, 263, 935, 918, 847, 813, 940, 582, 968, 753, 978, 325, 151, 192, 792, 223, 552, 504, 287, 585, 436, 456, 327, 154, 657, 996, 541, 223, 749, 490, 965, 711, 951, 939, 537, 148, 290, 152, 23, 770, 865, 860, 903, 41, 296, 381, 838 };
            int target = 569;
            //First call might skew results, so let's get it out of the way.
            Array.BinarySearch(arr2, target);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = BinarySearchDotNet(arr2, target), () => actualElapsed = BinarySearchExt(arr2, target));

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
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
            Array.BinarySearch(arr2, target);

            long expectedElapsed = 0;
            long actualElapsed = 0;
            Parallel.Invoke(() => expectedElapsed = BinarySearchDotNet(arr2, target), () => actualElapsed = BinarySearchExt(arr2, target));

            Assert.True(Math.Abs(expectedElapsed - actualElapsed) < 1000); //1,000 ticks equals one tenth of a millisecond. Make sure we are inside of it.
        }


        [Fact]
        public void DeepCopy()
        {
            string[] arr1 = { "one", "two", "three", "four", "five" };
            string[] arr2 = arr1.DeepCopyExt();

            Assert.False(Object.ReferenceEquals(arr2[0], arr1[0])); // strings do not point to the same memory loc.

            string[] arr3 = new string[arr1.Length];
            Array.Copy(arr1, arr3, arr3.Length);

            Assert.True(Object.ReferenceEquals(arr3[0], arr1[0])); // strings point to the same memory loc.
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




        #region "Private Methods"
        private long BinarySearchDotNet(int[] arr1, int target)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Array.BinarySearch(arr1, target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long BinarySearchExt(int[] arr1, int target)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = arr1.BinarySearchExt(target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long BinarySearchDotNet(int[] arr1, int target, int index, int length)
        {
            Stopwatch sw = Stopwatch.StartNew();
            var tc1 = Array.BinarySearch(arr1, index, length, target);
            sw.Stop();
            return sw.ElapsedTicks;
        }

        private long BinarySearchExt(int[] arr1, int target, int index, int length)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            var tc2 = arr1.BinarySearchExt(index, length, target);
            sw.Stop();
            return sw.ElapsedTicks;
        }
        #endregion
    }
}
