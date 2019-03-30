using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int coumputerCount = int.Parse(Console.ReadLine());

            int raiting = 0;
            double totalSales = 0.0;
            double sales = 0.0;
            double sumRaiting = 0.0;

            for (int i = 0; i < coumputerCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                raiting = number % 10;
                sales = number / 10;

                switch (raiting)
                {
                    case 2:
                        totalSales += sales * 0;
                        break;
                    case 3:
                        totalSales += sales * 0.50;
                        break;
                    case 4:
                        totalSales += sales * 0.70;
                        break;
                    case 5:
                        totalSales += sales * 0.85;
                        break;
                    case 6:
                        totalSales += sales;
                        break;
                }
                sumRaiting += raiting;
                
            }
            double totalRaiting = sumRaiting / coumputerCount;
            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{totalRaiting:f2}");
        }
    }
}
