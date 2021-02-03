using System;
using RecursionProblem.Problems;

namespace RecursionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // ******************* Recursion use stack internally ******************* //

            var n = 5;
            Console.WriteLine($"!{n}: {Factorial.Fact(n)}\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");

            var ary = new[] {10, 20, 30, 40};
            Console.WriteLine($"Reverse of ary: {string.Join(',', ary)} : {string.Join(',', ArrayReverse.Reverse(ary, 0, ary.Length - 1))}\n\n");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");

            var input = "<html><head></head><body><div><span><a></a></span></div><div><h1><span></span></h1></div></body></html>\n";
            Console.WriteLine($"Before indentation of the following input: \n\n{input}");
            Console.WriteLine("After indentation:\n");
            IndentationHandler.HandleIndentation(input);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");

            int[] a = { 1, 2, 3, 4, 5 };
            ConstructTriangle.PrintTriangle(a, a.Length);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");

            Console.ReadLine();
        }
    }
}
