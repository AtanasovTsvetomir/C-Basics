using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int orderCount = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            double price = 0.0;
            double sum = 0.0;

            if (day <= 15)
            {
                if (text == "Cake")
                {
                    price = 24;
                }
                else if (text == "Souffle")
                {
                    price = 6.66;
                }
                else if (text == "Baklava")
                {
                    price = 12.60;
                }
            }
            else if (day > 15)
            {
                if (text == "Cake")
                {
                    price = 28.70;
                }
                else if (text == "Souffle")
                {
                    price = 9.80;
                }
                else if (text == "Baklava")
                {
                    price = 16.98;
                }
            }
            sum = price * orderCount;
            if (day <= 22 && sum >= 100 && sum <= 200)
            {
                sum = sum - (0.15 * sum);
            }
            else if (day <= 22 && sum > 200)
            {
                sum = sum - (0.25 * sum);
            }
            if (day <= 15)
            {
                sum = sum - (0.10 * sum);
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
