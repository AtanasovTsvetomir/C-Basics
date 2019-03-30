using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFlowers = Console.ReadLine();
            int flowerCounter = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double roses = 5;
            double dahlias = 3.80;
            double tullips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;

            if (kindOfFlowers == "Roses")
            {
                double total = flowerCounter * roses;
                double reduction = total - (0.1 * total);
                double remainingReductionBudget = Math.Abs(budget - reduction);
                double remainingBudget = Math.Abs(budget - total);
                if (flowerCounter > 80)
                {

                    if (reduction <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingReductionBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingReductionBudget:f2} leva more.");
                    }
                }
                else
                {
                    if (total <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingBudget:f2} leva more.");
                    }
                }
            }
            else if (kindOfFlowers == "Dahlias")
            {
                double total = flowerCounter * dahlias;
                double reduction = total - (0.15 * total);
                double remainingReductionBudget = Math.Abs(budget - reduction);
                double remainingBudget = Math.Abs(budget - total);
                if (flowerCounter > 90)
                {
                    if (reduction <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingReductionBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingReductionBudget:f2} leva more.");
                    }
                }
                else
                {
                    if (total <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingBudget:f2} leva more.");
                    }
                }
            }
            else if (kindOfFlowers == "Tulips")
            {
                double total = flowerCounter * tullips;
                double reduction = total - (0.15 * total);
                double remainingReductionBudget = Math.Abs(budget - reduction);
                double remainingBudget = Math.Abs(budget - total);
                if (flowerCounter > 80)
                {
                    if (reduction <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingReductionBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingReductionBudget:f2} leva more.");
                    }
                }
                else
                {
                    if (total <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingBudget:f2} leva more.");
                    }
                }
            }
            else if (kindOfFlowers == "Narcissus")
            {
                double total = flowerCounter * narcissus;
                double reduction = total + (0.15 * total);
                double remainingReductionBudget = Math.Abs(budget - reduction);
                double remainingBudget = Math.Abs(budget - total);
                if (flowerCounter < 120)
                {
                    if (reduction <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingReductionBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingReductionBudget:f2} leva more.");
                    }
                }
                else
                {
                    if (total <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingBudget:f2} leva more.");
                    }
                }
            }
            else if (kindOfFlowers == "Gladiolus")
            {
                double total = flowerCounter * gladiolus;
                double reduction = total + (0.2 * total);
                double remainingReductionBudget = Math.Abs(budget - reduction);
                double remainingBudget = Math.Abs(budget - total);
                if (flowerCounter < 80)
                {
                    if (reduction <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingReductionBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingReductionBudget:f2} leva more.");
                    }
                }
                else
                {
                    if (total <= budget)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {kindOfFlowers} and {remainingBudget:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {remainingBudget:f2} leva more.");
                    }
                }
            }
        }
    }
}
