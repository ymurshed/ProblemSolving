using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeConsole.HashTable
{
    public class MaximumErasureValue_1695: IExecute
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            var n = nums.Length;
            int maxLength = 0, start = 0, end = 0;
            var uniqueNumbers = new List<int>();
            var maxUniqueNumbers = new List<int>();

            while (start < n && end < n)
            {
                if (!uniqueNumbers.Contains(nums[end]))
                {
                    uniqueNumbers.Add(nums[end++]);
                    maxLength = Math.Max(maxLength, end - start);
                }
                else
                {
                    maxUniqueNumbers = GetMaxSubArray(uniqueNumbers, maxUniqueNumbers);
                    uniqueNumbers.Remove(nums[start++]); // increase 'start' just to make the max count consistent in the if block
                }
            }

            var sum = GetMaxSubArray(uniqueNumbers, maxUniqueNumbers).Sum();
            return sum;
        }

        private static List<int> GetMaxSubArray(List<int> uniqueNumbers, List<int> maxUniqueNumbers)
        {
            if (uniqueNumbers.Count <= maxUniqueNumbers.Count) return maxUniqueNumbers;
            maxUniqueNumbers.Clear();
            maxUniqueNumbers.AddRange(uniqueNumbers);
            Console.WriteLine(string.Join(",", maxUniqueNumbers));
            Console.WriteLine($"Sum => {maxUniqueNumbers.Sum()}");
            return maxUniqueNumbers;
        }

        public void Execute()
        {
            //Input: nums = [5, 2, 1, 2, 5, 2, 1, 2, 5]
            //Output: 8
            //Explanation: The optimal subarray here is [5, 2, 1] or [1, 2, 5].

            try
            {
                //var nums = new[] { 4, 2, 4, 5, 6 };
                //var nums = new[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 };
                var nums = new[] { 215, 436, 338, 139, 220, 815, 150, 720, 64, 721, 811, 32, 411, 901, 120, 657, 311, 429, 73, 825, 217, 173, 256, 805, 864, 459, 306, 426, 855, 425, 893, 557, 571, 255, 185, 300, 976, 388, 275, 301, 263, 834, 228, 116, 959, 109, 369, 162, 38, 384, 27, 387, 183, 773, 419, 409, 437, 799, 378, 977, 735, 618, 783, 941, 132, 944, 469, 633, 292, 660, 890, 22, 817, 356, 782, 406, 427, 179, 316, 574, 21, 492, 966, 962, 162, 27, 422, 451, 568, 187, 809, 626, 29, 758, 713, 294, 555, 104, 556, 689, 950, 983, 224, 811, 587, 926, 77, 478, 122, 333, 849, 504, 702, 94, 28, 837, 483, 266, 48, 147, 28, 568, 785, 573, 332, 207, 38, 442, 38, 852, 190, 648, 715, 32, 184, 361, 986, 466, 740, 980, 816, 875, 199, 687, 415, 619, 472, 52, 634, 348, 689, 325, 39, 870, 22, 638, 705, 282, 433, 272, 108, 755, 307, 279, 897, 317, 1, 935, 550, 335, 690, 614, 502, 94, 872, 269, 318, 735, 651, 71, 506, 886, 359, 2, 38, 320, 219, 274, 308, 715, 464, 252, 329, 932, 726, 196, 834, 869, 251, 17, 248, 60, 99, 911, 271, 665, 783, 140, 603, 621, 827, 975, 807, 459, 853, 605, 537, 550, 384, 444, 732, 614, 606, 866, 290, 630, 665, 746, 787, 410, 532, 27, 271, 457, 979, 774, 97, 238, 760, 205, 306, 679, 811, 857, 849, 689, 512, 927, 151, 772, 219, 251, 387, 747, 961, 21, 115, 511, 393, 791, 5, 204, 173, 280, 251, 468, 789, 197, 909, 710, 822, 731, 539, 121, 310, 806, 836, 6, 455, 305, 50, 38, 289, 33, 666, 78, 670, 292, 241, 311, 320, 173, 141, 962, 207, 494, 314, 779, 120, 185, 303, 454, 794, 962, 886, 115, 647, 519, 241, 808, 787, 846, 878, 413, 180, 465, 501, 194, 86, 176, 201, 537, 257, 602, 604, 857, 68, 545, 143, 396, 733, 459, 997, 559, 783, 64, 931, 486, 452, 611, 41, 921, 506, 967, 449, 23, 754, 564, 130, 830, 905, 678, 388, 307, 464, 818, 998, 970, 891, 204, 754, 887, 17, 495, 339, 40, 494, 292, 823, 746, 842, 39, 524, 507, 746, 764, 488, 955, 670, 35, 99, 387, 147, 370, 261, 848, 605, 695, 406, 408, 84, 657, 320, 982, 564, 424, 742, 447, 284, 658, 589, 930, 765, 467, 260, 552, 171, 903, 869 };
                Console.WriteLine(MaximumUniqueSubarray(nums));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
