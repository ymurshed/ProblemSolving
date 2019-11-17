using System;
using CodilitySolution.Lesson_1;
using CodilitySolution.Lesson_2;

namespace CodilitySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1
            var gap = new BinaryGap().solution(125);
            Console.WriteLine($"Longest binary gap: {gap}");

            // Lesson 2
            var rotateAry = new CyclicRotation().solution(new []{3, 8, 9, 7, 6}, 3);
            Console.WriteLine($"After cyclic left rotation: {string.Join(',', rotateAry)}");
            rotateAry = new CyclicRotation().solution(new []{3, 8, 9, 7, 6}, 3, false);
            Console.WriteLine($"After cyclic right rotation: {string.Join(',', rotateAry)}");

            Console.ReadLine();
        }
    }
}
