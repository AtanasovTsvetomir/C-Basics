using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool hasEggs = false;
            bool hasFlour = false;
            bool hasSugar = false;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                while (input != "Bake!")
                {
                    if (input == "flour")
                    {
                        hasFlour = true;
                    }
                    else if (input == "eggs")
                    {
                        hasEggs = true;
                    }
                    else if (input == "sugar")
                    {
                        hasSugar = true;
                    }
                    input = Console.ReadLine();

                }
                if (hasSugar && hasFlour && hasEggs)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                    hasEggs = false;
                    hasFlour = false;
                    hasSugar = false;
                }
                else
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    i -= 1;
                    continue;
                }
            }
        }
    }
}
