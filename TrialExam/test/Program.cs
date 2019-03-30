using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string product = string.Empty;
            int br = 0;
            double spendMoney = 0;
            double moneyLeft = 0;

            double balloons = 0.1;
            double flowers = 1.5;
            double candles = 0.5;
            double ribbon = 2;

            double balloonsCounter = 0;
            double flowersCounter = 0;
            double candlesCounter = 0;
            double ribbonCounter = 0;

            while (true)
            {
                product = Console.ReadLine();
                if (spendMoney >= budget)
                {
                    Console.WriteLine("All money is spent!");
                    Console.WriteLine($"Purchased decoration is {balloonsCounter} balloons, {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
                    return;
                }
                else if (product == "stop")
                {
                    Console.WriteLine($"Spend money: {spendMoney:f2}");
                    Console.WriteLine($"Money left: {moneyLeft:F2}");
                    Console.WriteLine($"Purchased decoration is {balloonsCounter} balloons, {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
                    return;
                }
                else
                {
                    br = int.Parse(Console.ReadLine());
                    if (product == "balloons")
                    {
                        spendMoney += balloons * br;
                        balloonsCounter += br;
                    }
                    else if (product == "flowers")
                    {
                        spendMoney += flowers * br;
                        flowersCounter += br;
                    }
                    else if (product == "candles")
                    {
                        spendMoney += candles * br;
                        candlesCounter += br;
                    }
                    else if (product == "ribbon")
                    {
                        spendMoney += ribbon * br;
                        ribbonCounter += br;
                    }
                    moneyLeft = budget - spendMoney;
                }

            }
        }
    }
}