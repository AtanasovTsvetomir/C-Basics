using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForTheTrip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int counterForSpending = 0;
            int counterForDays = 0;

            while (true)
            {
                counterForDays++;
                string command = Console.ReadLine();
                double moneyAction = double.Parse(Console.ReadLine());

                if (command == "spend")
                {
                    counterForSpending++;
                    if (counterForSpending == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(counterForDays);
                        return;
                    }
                    currentMoney -= moneyAction;
                    if (currentMoney <0)
                    {
                        currentMoney = 0;
                    }
                }
                else if (command == "save")
                {
                    counterForSpending = 0;
                    currentMoney += moneyAction;
                }
                if (currentMoney >= moneyForTheTrip)
                {
                    Console.WriteLine($"You saved the money for {counterForDays} days.");
                    return;
                }

            }
        }
    }
}
