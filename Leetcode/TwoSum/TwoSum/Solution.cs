using System.Linq;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var indices = new int[2];
            var numList = nums.ToList();
            
            for (var i = 0; i < numList.Count - 1; i++)
            {
                var secondNumber = target - numList[i];
                var index = numList.FindIndex(i + 1, numList.Count - 1 - i, x => x == secondNumber);

                if (index == -1) continue;

                indices[0] = i;
                indices[1] = index;
                break;
            }

            return indices;
        }
    }
}
