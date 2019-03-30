using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideWithoutReminder_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
                if (number % 2 == 0)
                {
                    p1++;
                }
            }
            double percentP1 = (p1 / n) * 100;
            double percentP2 = (p2 / n) * 100;
            double percentP3 = (p3 / n) * 100;

            Console.WriteLine($"{percentP1:F2}%");
            Console.WriteLine($"{percentP2:F2}%");
            Console.WriteLine($"{percentP3:F2}%");
        }
    }
}
