using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DevideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p3Counter = 0;
            double p4Counter = 0;
            double p2Counter = 0;
            for (int i = 1; i <= n; i++)
            {

                double number = double.Parse(Console.ReadLine());

                if (number % 4 == 0)
                {
                    p4Counter++;
                }
                if (number % 3 == 0)
                {
                    p3Counter++;
                }
                if (number % 2 == 0)
                {
                    p2Counter++;
                }
            }

            double p3 = p3Counter / n * 100;
            double p4 = p4Counter / n * 100;
            double p2 = p2Counter / n * 100;

            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
        }
    }
}
