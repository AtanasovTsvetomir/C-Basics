using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numberOfArticuls = int.Parse(Console.ReadLine());
            int price = 0;
            int totalSum = 0;
            for (int i = 0; i < numberOfArticuls; i++)
            {
                string nameOfArticul = Console.ReadLine();

                switch (nameOfArticul)
                {
                    case "hoodie":
                        price = 30;
                        break;
                    case "keychain":
                        price = 4;
                        break;
                    case "T-shirt":
                        price = 20;
                        break;
                    case "flag":
                        price = 15;
                        break;
                    case "sticker":
                        price = 1;
                        break;
                }
                totalSum += price;
            }
            int moneyLeft = Math.Abs(budget - totalSum);

            if (budget >= totalSum)
            {
                Console.WriteLine($"You bought {numberOfArticuls} items and left with {moneyLeft} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyLeft} more lv.");
            }
        }
    }
}
