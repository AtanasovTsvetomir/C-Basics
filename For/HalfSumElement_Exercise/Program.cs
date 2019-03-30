using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (maxNumber < number)
                {
                    maxNumber = number;
                }

                sum += number;
            }
            sum -= maxNumber;
            if (sum == maxNumber)
            {
                Console.WriteLine($"Yes, Sum= {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(sum - maxNumber);
                Console.WriteLine($"No, Diff {diff}");
            }
        }
    }
}
