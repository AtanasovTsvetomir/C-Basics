using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EqualsPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;
            int sum = 0;
            bool flag = true;
            int maxDiff = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                sum = firstNumber + secondNumber;
                if (i == 0)
                {
                    firstSum = sum;
                    secondSum = sum;
                }
                if (sum != firstSum)
                {
                    flag = false;
                }
                if (Math.Abs(sum - secondSum) > maxDiff)
                {
                    maxDiff = Math.Abs(sum - secondSum);
                }
            }
            if (flag)
            {
                Console.WriteLine($"Yes, value= {firstSum}");
            }
            else
            {
                Console.WriteLine($"No, maxDiff= {maxDiff}");
            }

        }
    }
}
