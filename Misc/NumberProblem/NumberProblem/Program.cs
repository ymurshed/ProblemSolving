using System;
using NumberProblem.Problems;

namespace NumberProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------Number related problem-------------------------------------");

            DistanceFinder.FindDistance();
            SmallestPositiveIntegerFinder.FindSmallestPositiveInteger();

            Console.ReadLine();
        }
    }
}
