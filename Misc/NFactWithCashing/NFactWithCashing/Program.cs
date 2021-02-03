using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactWithCashing
{
    class Program
    {
        public static int[] cacheResult;
        public static void NFact(int n)
        {
            int j;
            cacheResult = new int[n + 1];

            for (j = 0; j <= n; j++)
            {
                if (j == 0)
                {
                    cacheResult[j] = 1;
                    continue;
                }
                cacheResult[j] = cacheResult[j - 1] * j;
            }  
            
            Console.WriteLine("Fact of {0}: {1}", n, cacheResult[j - 1]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give input for finding factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            NFact(n);

            Console.WriteLine("Give input for showing any fact result less than {0}: ", n);
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fact value showed from caching: {0}", cacheResult[n1]);
            Console.ReadLine();
        }
    }
}




