using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HoneyMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string country = Console.ReadLine();
            int dayCount = int.Parse(Console.ReadLine());

            double priceForSleep = 0.0;
            double priceForTrip = 0.0;
            double reduction = 0.0;

            switch (country)
            {
                case "Cairo":
                    priceForSleep = 500;
                    priceForTrip = 600;
                    break;
                case "Paris":
                    priceForSleep = 300;
                    priceForTrip = 350;
                    break;
                case "Lima":
                    priceForSleep = 800;
                    priceForTrip = 850;
                    break;
                case "New York":
                    priceForSleep = 600;
                    priceForTrip = 650;
                    break;
                case "Tokyo":
                    priceForSleep = 700;
                    priceForTrip = 700;
                    break;
            }
            double sum = (priceForSleep * dayCount) + priceForTrip;
            
            if (dayCount >= 1 && dayCount <= 4)
            {
                if (country == "Cairo" || country == "New York")
                {
                    reduction = sum - (0.03 * sum);
                }
                else
                {
                    reduction = sum;
                }
            }
            else if (dayCount >= 5 && dayCount <= 9)
            {
                if (country == "Cairo" || country == "New York")
                {
                    reduction = sum - (0.05 * sum);
                }
                else if (country == "Paris")
                {
                    reduction = sum - (0.07 * sum);
                }
                else
                {
                    reduction = sum;
                }
            }
            else if (dayCount >= 10 && dayCount <= 24)
            {
                if (country == "Cairo")
                {
                    reduction = sum - (0.10 * sum);
                }
                else if (country == "New York" || country == "Paris" || country == "Tokyo")
                {
                    reduction = sum - (0.12 * sum);
                }
                else
                {
                    reduction = sum;
                }
            }
            else if (dayCount >= 25 && dayCount <= 49)
            {
                if (country == "Cairo" || country == "Tokyo")
                {
                    reduction = sum - (0.17 * sum);
                }
                else if (country == "New York" || country == "Lima")
                {
                    reduction = sum - (0.19 * sum);
                }
                else if (country == "Paris")
                {
                    reduction = sum - (0.22 * sum);
                }
                else
                {
                    reduction = sum;
                }
            }
            else if (dayCount >= 50)
            {
                reduction = sum - (0.30 * sum);
            }
            double moneyLeft = Math.Abs(budget - reduction);
            if (budget >= reduction)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
            }
        }
    }
}
