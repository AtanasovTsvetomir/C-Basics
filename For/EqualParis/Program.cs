using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualParis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            bool areTheyEqual = true;
            int maxDiff = int.MinValue;
            int lastSum = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int sumOfBoth = firstNum + secondNum;
                if (i == 0)
                {
                    firstSum = sumOfBoth;
                    lastSum = sumOfBoth;
                }
                if (sumOfBoth != firstSum)
                {
                    areTheyEqual = false;
                }
                if (Math.Abs(sumOfBoth - lastSum) > maxDiff)
                {
                    maxDiff = Math.Abs(sumOfBoth - lastSum);
                }
                lastSum = sumOfBoth;
            }
            if (areTheyEqual)
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
