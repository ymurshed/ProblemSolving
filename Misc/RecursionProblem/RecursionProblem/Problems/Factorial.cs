using System;

namespace RecursionProblem.Problems
{
    public class Factorial
    {
        private static int _i = 1;
        private static int _j = 1;

        public static int Fact(int n)
        {
            if (n == 1)
            {
                Console.WriteLine($"Applying return condition. n is: {n}");
                return 1;
            }

            Console.WriteLine($"Before return condition at step# {_i++}, n is: {n}");
            n = n * Fact(n - 1);
            Console.WriteLine($"After poping from stack at step# {_j++}, n is: {n}");

            return n;
        }
    }
}
