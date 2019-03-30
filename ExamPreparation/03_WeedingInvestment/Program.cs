using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WeedingInvestment
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string desert = Console.ReadLine();
            int mounthCount = int.Parse(Console.ReadLine());

            double price = 0.0;
            switch (term)
            {
                case "one":
                    switch (typeOfContract)
                    {
                        case "Small":
                            price = 9.98;
                            break;
                        case "Middle":
                            price = 18.99;
                            break;
                        case "Large":
                            price = 25.98;
                            break;
                        case "ExtraLarge":
                            price = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (typeOfContract)
                    {
                        case "Small":
                            price = 8.58;
                            break;
                        case "Middle":
                            price = 17.09;
                            break;
                        case "Large":
                            price = 23.59;
                            break;
                        case "ExtraLarge":
                            price = 31.79;
                            break;
                    }
                    break;
            }
            double sum = 0.0;
            sum = price;
            if (desert == "yes")
            {
                if (price <= 10 )
                {
                    sum = price + 5.50;
                }
                else if (price <= 30)
                {
                    sum = price + 4.35;
                }
                else if (price > 30)
                {
                    sum = price + 3.85;
                }
            }
            double total = sum * mounthCount;
            if (term == "two")
            {
                double totalSum = total - (0.0375 * total);
                Console.WriteLine($"{totalSum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{total:f2} lv.");
            }
        }
    }
}
