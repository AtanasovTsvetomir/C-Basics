using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GoingHome
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            double costForGas = double.Parse(Console.ReadLine());
            double priceForGas = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double gas = (kilometers * costForGas) / 100;
            double moneyForGas = gas * priceForGas;
            double moneyLeft = budget - moneyForGas;
            double money = budget / 5;

            if (budget >= moneyForGas)
            {
                Console.WriteLine($"You can go home. {moneyLeft:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {money:F2} money.");
            }
        }
    }
}
