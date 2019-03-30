using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int eatInKilos = int.Parse(Console.ReadLine());
            int eatInGrams = eatInKilos * 1000;
            string porcion = string.Empty;
            int eatedFood = 0;

            while (true)
            {
                porcion = Console.ReadLine();

                if (porcion == "Adopted")
                {
                    break;
                }
                eatedFood += int.Parse(porcion);
            }
            int leftEat = Math.Abs(eatInGrams - eatedFood);

            if (eatInGrams >= eatedFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {leftEat} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {leftEat} grams more.");
            }
        }
    }
}
