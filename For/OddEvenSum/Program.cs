using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
                }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes, sum= {oddSum}");
            }
            else
            {
                int diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine($"No, diff= {diff}");
            }
        }
    }
}