using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tShirtPrice = double.Parse(Console.ReadLine());
            double inputSum = double.Parse(Console.ReadLine());

            double shorts = tShirtPrice * 0.75;
            double socks = shorts * 0.20;
            double shoes = 2 * (tShirtPrice + shorts);

            double sum = tShirtPrice + shorts + socks + shoes;
            double sumWithReduction = sum - (sum * 0.15);

            double sumInneeded = Math.Abs(inputSum - sumWithReduction);
            if (sumWithReduction >= inputSum)
            {
                Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumWithReduction:f2} lv.");
            }
            else
            {
                Console.WriteLine($"No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumInneeded:f2} lv. more.");
            }
        }
    }
}
