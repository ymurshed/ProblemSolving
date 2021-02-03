using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagTextPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Type height: ");
            int height = Convert.ToInt16(Console.ReadLine());

            ZigZagTextPrint(text, height);
        }

        private static void InitOrPrint(string type, int height, int length, char[,] result)
        {
            if (type.Equals("init"))
            {
                // initialize with space
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        result[i, j] = ' ';
                    }
                }
            }
            else
            {
                // print result
                Console.WriteLine("Below is the output: \n");

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write(result[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void ZigZagTextPrint(string text, int height)
        {
            try
            {
                char[,] result = new char[height, text.Length];
                string type = "init";

                InitOrPrint(type, height, text.Length, result);

                int r, c;
                r = c = 0;
                string direction = "Down";   

                for (int l = 0; l < text.Length; l++)
                {
                    result[r, c] = text[l];

                    if (r == 0)
                        direction = "Down";
                    if (r == height - 1)
                        direction = "Up";

                    switch (direction)
                    {
                        case "Down":
                            r++;
                            c++;
                            break;

                        case "Up":
                            r--;
                            c++;
                            break;
                    }
                }

                type = "print";
                InitOrPrint(type, height, text.Length, result);
                Console.ReadLine();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}