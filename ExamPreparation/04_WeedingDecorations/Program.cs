using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WeedingDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double total = 0.0;
            double price = 0.0;
            double moneyLeft = 0.0;
            int balloons = 0;
            int flowers = 0;
            int candles = 0;
            int ribbon = 0;
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "stop")
                {
                    Console.WriteLine($"Spend money: {total:f2}");
                    Console.WriteLine($"Money left: {moneyLeft:f2}");
                    break;
                }
                int count = int.Parse(Console.ReadLine());
                switch (product)
                {
                    case "balloons":
                        balloons += count;
                        price = 0.1;
                        break;
                    case "flowers":
                        flowers += count;
                        price = 1.5;
                        break;
                    case "candles":
                        candles += count;
                        price = 0.5;
                        break;
                    case "ribbon":
                        ribbon += count;
                        price = 2;
                        break;
                }
                
                total += price * count;
                moneyLeft = Math.Abs(budget - total);
                if (budget <= total)
                {
                    Console.WriteLine($"All money is spent!");
                    break;
                }
            }
            Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m ribbon, {flowers} flowers and {candles} candles.");
        }
    }
}
