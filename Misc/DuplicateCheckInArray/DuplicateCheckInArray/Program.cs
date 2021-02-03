using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheckInArray
{
    class Program
    {
        public static List<int> CheckDuplicate(int []ary)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> l = new List<int>();
             
            foreach (var item in ary)
            {
                if (!set.Add(item))
                    if (!l.Contains(item))
                        l.Add(item);
            }
            
            return l;
        }

        static void Main(string[] args)
        {
            int n = 10;
            int[] ary = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                ary[i] = r.Next(1, 20);

            Console.WriteLine("Array element: ");
            for (int i = 0; i < n; i++)
                Console.Write(" " + ary[i]);

            List<int> item = CheckDuplicate(ary);
            Console.WriteLine();

            Console.WriteLine("Duplicate elements: ");
            for (int i = 0; i < item.Count; i++)
                Console.Write(" " + item[i]);

            Console.Read();
        }
    }
}
