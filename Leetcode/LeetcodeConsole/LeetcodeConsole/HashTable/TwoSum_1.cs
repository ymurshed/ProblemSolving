using System;
using System.Collections.Generic;

namespace LeetcodeConsole.HashTable
{
    public class TwoSum_1: IExecute
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new[] {map.GetValueOrDefault(complement), i};
                }

                map.Add(nums[i], i);
            }

            throw new Exception("No two sum solutions");
        }

        public void Execute()
        {
            //Input: nums = [2, 7, 11, 15], target = 9
            //Output:[0,1]
            //Output: Because nums[0] +nums[1] == 9, we return [0, 1].

            try
            {
                var nums = new[] { 2, 7, 11, 15 };
                const int target = 9;

                var res = TwoSum(nums, target);
                Console.WriteLine("[" + string.Join(",", res) + "]");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
