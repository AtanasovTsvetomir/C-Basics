using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1Counter = 0;
            double p2Counter = 0;
            double p3Counter = 0;
            double p4Counter = 0;
            double p5Counter = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1Counter++;
                }
                else if (number >= 200 && number < 400)
                {
                    p2Counter++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3Counter++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4Counter++;
                }
                else if (number >= 800)
                {
                    p5Counter++;
                }
            }
            double p1 = p1Counter / n * 100;
            double p2 = p2Counter / n * 100;
            double p3 = p3Counter / n * 100;
            double p4 = p4Counter / n * 100;
            double p5 = p5Counter / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
