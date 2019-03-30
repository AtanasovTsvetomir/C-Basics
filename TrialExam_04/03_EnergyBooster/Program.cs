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

            double price = 0;
            switch (size)
            {
                case "small":
                    switch (fruit)
                    {
                        case "Watermelon":
                            price += 56 * 2;
                            break;
                        case "Mango":
                            price += 36.66 * 2;
                            break;
                        case "Pineapple":
                            price += 42.10 * 2;
                            break;
                        case "Raspberry":
                            price += 20 * 2;
                            break;
                    }
                    break;
                case "big":
                    switch (fruit)
                    {
                        case "Watermelon":
                            price += 28.70 * 5;
                            break;
                        case "Mango":
                            price += 19.60 * 5;
                            break;
                        case "Pineapple":
                            price += 24.80 * 5;
                            break;
                        case "Raspberry":
                            price += 15.20 * 5;
                            break;
                    }
                    break;
            }

            price = price * orderCount;

            if (price >= 400 && price <= 1000)
            {
                price = price - (0.15 * price);
            }
            else if (price > 1000)
            {
                price = price - (0.50 * price);
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
