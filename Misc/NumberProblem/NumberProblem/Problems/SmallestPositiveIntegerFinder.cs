using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberProblem.Problems
{
    public class SmallestPositiveIntegerFinder
    {
        public static List<int> Numbers = new List<int>
        {
            -1, 10, 2, 5, 7, 10, 8, 1, 2, 9, -3, 0
        };

        public static void FindSmallestPositiveInteger()
        {
            var numbers = new List<int>(Numbers);
            numbers.Sort();

            var smallest = numbers.Max() <= 0 ? 1 : numbers.Max();

            if (smallest > 1)
            {
                foreach (var number in numbers)
                {
                    smallest = number + 1;
                    if (!numbers.Contains(smallest) && smallest > 0) break;
                }
            }

            Console.WriteLine($"Smallest positive integer not in the Numbers : {smallest}");
        }
    }
}
