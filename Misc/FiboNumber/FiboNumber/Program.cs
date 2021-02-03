using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboNumber
{
    class Program
    {
        public static int finalValue = 0;
        public static void Fibonacci_Recursive(int len)
        {
            Fibonacci_Rec_Temp(1, 1, 1, len);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                finalValue = a;
                Console.Write("{0} ", a);
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give input: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fiob series: ");
            Fibonacci_Recursive(number);
            Console.WriteLine("\n{0} place fibo numbre: {1}", number, finalValue);
            Console.ReadLine();
        }
    }
}
