using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCounter = int.Parse(Console.ReadLine());

            double shipPrice = 0;
            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
            }

            if (fishermanCounter <= 6)
            {
                shipPrice -= shipPrice * 0.1;
            }
            else if (fishermanCounter >= 7 && fishermanCounter <= 11)
            {
                shipPrice -= shipPrice * 0.15;
            }
            else 
            {
                shipPrice -= shipPrice * 0.25;
            }
            if (fishermanCounter % 2 == 0 && season != "Autumn")
            {
                shipPrice -= shipPrice * 0.05;
            }
            double result = Math.Abs(budget - shipPrice);

            if (budget >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {result:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {result:F2} leva.");
            }
        }
    }
}

