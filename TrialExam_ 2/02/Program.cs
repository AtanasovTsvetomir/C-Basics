using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCounter = int.Parse(Console.ReadLine());
            int chipsCounter = int.Parse(Console.ReadLine());

            double priceForBeer = beerCounter * 1.20;
            double priceForChips = Math.Ceiling(chipsCounter *(priceForBeer - (priceForBeer * 0.55)));
            double priceForChipsAndBeer = priceForBeer + priceForChips;

            if (budget >= priceForChipsAndBeer)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget - priceForChipsAndBeer):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(Math.Abs(budget - priceForChipsAndBeer)):f2} more leva!");
            }
        }
    }
}
