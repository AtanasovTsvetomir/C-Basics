using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double sum = 0;

            for (int i = 0; i < groupCount; i++)
            {
                int group = int.Parse(Console.ReadLine());

                if (group <= 5)
                {
                    musala += group;
                }
                else if (group >= 5 && group <= 12)
                {
                    monblan += group;
                }
                else if (group >= 13 && group <= 25)
                {
                    kilimandjaro += group;
                }
                else if (group >= 26 && group <= 40)
                {
                    k2 += group;
                }
                else if (group >=41)
                {
                    everest += group;
                }

                sum += group;

            }
            double totalMusala = (musala / sum) * 100;
            double totalMonblan = (monblan / sum) * 100;
            double totalKilimandjaro = (kilimandjaro / sum) * 100;
            double totalK2 = (k2 / sum) * 100;
            double totalEverest = (everest / sum) * 100;

            Console.WriteLine($"{totalMusala:F2}%");
            Console.WriteLine($"{totalMonblan:F2}%");
            Console.WriteLine($"{totalKilimandjaro:F2}%");
            Console.WriteLine($"{totalK2:F2}%");
            Console.WriteLine($"{totalEverest:F2}%");

        }
    }
}

