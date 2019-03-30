using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget -= 0.7 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget:F2}");
                }
                else if (season == "winter")
                {
                    budget -= 0.3 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }
            else if ((budget > 100) && (budget <= 1000))
            {
                if (season == "summer")
                {
                    budget -= 0.6 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget:F2}");
                }
                else if (season == "winter")
                {
                    budget -= 0.2 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }
            else if (budget > 1000)
            {
                budget -= 0.1 * budget;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget:F2}");
            }
        }
    }
}
