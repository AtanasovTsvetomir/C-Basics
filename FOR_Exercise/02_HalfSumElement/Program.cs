using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxElement = int.MinValue;
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                total += number;
                if (number > maxElement)
                {
                    maxElement = number;
                    
                }
            }
            total -= maxElement;
            int diff = Math.Abs(maxElement - total);
            if (maxElement == total)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxElement}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
