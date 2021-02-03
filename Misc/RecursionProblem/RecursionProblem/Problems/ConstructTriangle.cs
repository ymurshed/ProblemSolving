using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblem.Problems
{
    public class ConstructTriangle
    {
        public static void PrintTriangle(int[] ary, int n)
        {
            if (n < 1) return;
            
            var temp = new int[n - 1];
            for (var i = 0; i < n - 1; i++)
            {
                var x = ary[i] + ary[i + 1];
                temp[i] = x;
            }

            PrintTriangle(temp, n - 1);

            for (var i = 0; i < n; i++)
            {
                if (i == n - 1) Console.Write(ary[i] + " ");
                else Console.Write(ary[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
