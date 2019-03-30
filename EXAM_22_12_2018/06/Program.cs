using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string command = string.Empty;

            int price = 0;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "Stop")
                {
                    Console.WriteLine($"Money left: {budget}");
                    return;
                }

                for (int i = 0; i < command.Length; i++)
                {
                    char symbol = command[i];
                    price += symbol;
                    
                }

                if (budget >= price)
                {
                    Console.WriteLine($"Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine($"Not enough money!");
                    return;
                }
                budget = budget - price;
                price = 0;
            }
        }
    }
}
