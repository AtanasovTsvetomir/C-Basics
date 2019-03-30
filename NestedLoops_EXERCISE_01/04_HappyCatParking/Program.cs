using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int hoursCount = int.Parse(Console.ReadLine());
            double sum = 0;
            double price = 0;
            double totalSum = 0;
            double total = 0;
            for (int i = 1; i <= dayCount; i++)
            {
                for (int j = 1; j <= hoursCount; j++)
                {
                    if ((i % 2 == 0) && (j % 2 != 0))
                    {
                        price = 2.50;
                        sum += price;
                        total += sum;
                        sum = 0;
                    }
                    else if ((i % 2 != 0) && (j % 2 == 0))
                    {
                        price = 1.25;
                        sum += price;
                        total += sum;
                        sum = 0;
                    }
                    else
                    {
                        price = 1;
                        sum += price;
                        total += sum;
                        sum = 0;
                    }
                   
                }
                Console.WriteLine($"Day: {i} - {total:f2} leva");
                totalSum += total;
                total = 0;
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
