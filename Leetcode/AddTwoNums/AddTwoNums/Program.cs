using System;
using System.Collections.Generic;

namespace AddTwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new Solution();
            var num1 = new List<int>
            {
                1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1
            };
            var num2 = new List<int>
            {
                5,6,4
            };

            var l1 = Solution.GetListNodeFromNumber(num1);
            var l2 = Solution.GetListNodeFromNumber(num2);
            var node = ob.AddTwoNumbers(l1, l2);
            
            while (node != null)
            {
                Console.Write($"{node.val}->");
                node = node.next;
            }
        }
    }
}
