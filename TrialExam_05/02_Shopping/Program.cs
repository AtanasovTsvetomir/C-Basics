using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double chocolateCount = double.Parse(Console.ReadLine());
            double quantityMilk = double.Parse(Console.ReadLine());

            double chocolate = chocolateCount * 0.65;
            double milk = quantityMilk * 2.70;
            double mandarins = Math.Ceiling(chocolate * 0.65);
            double priceForMandarins = mandarins * 0.20;
            double total = chocolate + milk + priceForMandarins;
            double moneyLeft = Math.Abs(budget - total);
            if (budget >= total)
            {
                Console.WriteLine($"You got this, {moneyLeft:F2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyLeft:F2} more!");
            }
        }
    }
}
