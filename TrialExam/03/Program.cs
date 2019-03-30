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
            string sushi = Console.ReadLine();
            string nameOfRestorant = Console.ReadLine();
            double porcionCounter = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();

            double price = 0;
            double totalSum = 0;

            switch (nameOfRestorant)
            {
                case "Sushi Zone":
                    switch (sushi)
                    {
                        case "sashimi":
                            price = 4.99;
                            break;
                        case "maki":
                            price = 5.29;
                            break;
                        case "uramaki":
                            price = 5.99;
                            break;
                        case "temaki":
                            price = 4.29;
                            break;
                    }
                    break;
                case "Sushi Time":
                    switch (sushi)
                    {
                        case "sashimi":
                            price = 5.49;
                            break;
                        case "maki":
                            price = 4.69;
                            break;
                        case "uramaki":
                            price = 4.49;
                            break;
                        case "temaki":
                            price = 5.19;
                            break;
                    }
                    break;
                case "Sushi Bar":
                    switch (sushi)
                    {
                        case "sashimi":
                            price = 5.25;
                            break;
                        case "maki":
                            price = 5.55;
                            break;
                        case "uramaki":
                            price = 6.25;
                            break;
                        case "temaki":
                            price = 4.75;
                            break;
                    }
                    break;
                case "Asian Pub":
                    switch (sushi)
                    {
                        case "sashimi":
                            price = 4.50;
                            break;
                        case "maki":
                            price = 4.80;
                            break;
                        case "uramaki":
                            price = 5.50;
                            break;
                        case "temaki":
                            price = 5.50;
                            break;
                    }
                    break;
            }

            if ((nameOfRestorant == "Sushi Zone") || (nameOfRestorant == "Sushi Time") || (nameOfRestorant == "Sushi Bar") || (nameOfRestorant == "Asian Pub"))
            {
                if (sushi == "sashimi")
                {
                    totalSum = price * porcionCounter;
                }
                else if (sushi == "maki")
                {
                    totalSum = price * porcionCounter;
                }
                else if (sushi == "uramaki")
                {
                    totalSum = price * porcionCounter;
                }
                else if (sushi == "temaki")
                {
                    totalSum = price * porcionCounter;
                }
                if (order == "Y")
                {
                    totalSum += totalSum * 0.20;
                    Console.WriteLine($"Total price: {Math.Ceiling(totalSum)} lv.");
                }
                else
                {
                    Console.WriteLine($"Total price: {Math.Ceiling(totalSum)} lv.");
                }
            }
            else
            {
                Console.WriteLine($"{nameOfRestorant} is invalid restaurant!");
            }
        }

    }
}
