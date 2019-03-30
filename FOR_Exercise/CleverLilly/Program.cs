using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int LillyYears = int.Parse(Console.ReadLine());
            double priceForWashingMachine = double.Parse(Console.ReadLine());
            int priceForToy = int.Parse(Console.ReadLine());

            int moneyCounter = 0;
            int toyCounter = 0;
            int sum = 0;

            for (int i = 1; i <= LillyYears; i++)
            {
                if (i % 2 != 0)
                {
                    toyCounter++;
                }
                if (i % 2 == 0)
                {
                    moneyCounter++;
                    sum += (moneyCounter * 10) - 1;
                }
            }

            int moneyFromToys = priceForToy * toyCounter;
            int total = moneyFromToys + sum;
            double moneyLeft = Math.Abs(total - priceForWashingMachine);

            if (total >= priceForWashingMachine)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"No! {moneyLeft:f2}");
            }
        }
    }
}
