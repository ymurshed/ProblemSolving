using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = 6;
            var nums = new[] {3, 2, 4};

            var ob = new Solution();
            var res = ob.TwoSum(nums, target);
            Console.WriteLine(string.Join(",", res));
        }
    }
}
