using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        private static bool IsPalindrome(int number)
        {
            int temp = number;
            int reverse = 0;

            while (temp != 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }

            return number == reverse;
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Give input: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string msg = IsPalindrome(number) ? "Palindrome" : "Not Palindrome";
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
