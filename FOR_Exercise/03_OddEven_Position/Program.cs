using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    OddSum += number;
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                }
                else if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                }
            }
            Console.WriteLine($"OddSum = {OddSum},");

            if (OddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin = No,");
            }
            else
            {
                Console.WriteLine($"OddMin = {OddMin},");
            }
            if (OddMax == double.MinValue)
            {
                Console.WriteLine("OddMax = No,");
            }
            else
            {
                Console.WriteLine($"OddMax = {OddMax},");
            }

            Console.WriteLine($"EvenSum = {EvenSum},");

            if (EvenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin = No,");
            }
            else
            {
                Console.WriteLine($"EvenMin = {EvenMin},");
            }
            if (EvenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine($"EvenMax = {EvenMax},");
            }
        }
    }
}
