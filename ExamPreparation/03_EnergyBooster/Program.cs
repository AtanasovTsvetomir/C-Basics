using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int orderCount = int.Parse(Console.ReadLine());

            double price = 0.0;
            double sum = 0.0;
            double total = 0.0;
            switch (fruit)
            {
                case "Watermelon":
                    switch (size)
                    {
                        case "small":
                            price = 56 * 2;
                            break;
                        case "big":
                            price = 28.70 * 5;
                            break;
                    }
                    break;
                case "Mango":
                    switch (size)
                    {
                        case "small":
                            price = 36.66 * 2;
                            break;
                        case "big":
                            price = 19.60 * 5;
                            break;
                    }
                    break;
                case "Pineapple":
                    switch (size)
                    {
                        case "small":
                            price = 42.10 * 2;
                            break;
                        case "big":
                            price = 24.80 * 5;
                            break;
                    }
                    break;
                case "Raspberry":
                    switch (size)
                    {
                        case "small":
                            price = 20 * 2;
                            break;
                        case "big":
                            price = 15.20 * 5;
                            break;
                    }
                    break;
            }
            sum = orderCount * price;
            if (sum >= 400 && sum <= 1000)
            {
                total = sum - (0.15 * sum);
                Console.WriteLine($"{total:f2} lv.");
            }
            else if (sum > 1000)
            {
                total = sum - (0.50 * sum);
                Console.WriteLine($"{total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{sum:f2} lv.");
            }
        }
    }
}
