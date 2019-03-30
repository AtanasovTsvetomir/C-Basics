using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MathPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool first = false;
            bool second = false;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n)
                        {
                            if (a < b && b < c)
                            {
                                first = true;
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                            }
                        }
                        else if (a * b * c == n)
                        {
                            if (a > b && b > c)
                            {
                                second = true;
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                            }
                        }
                    }
                }
            }
            if (first == false && second == false)
            {
                Console.WriteLine("No!");
            }

        }
    }
}
