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
            int adultsCount = 0;
            int kidsCount = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;
            int years = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Christmas")
                {
                    break;
                }

                years = int.Parse(command);

                if (years <= 16 )
                {
                    kidsCount++;
                    moneyForToys += 5;
                }
                else if (years > 16)
                {
                    adultsCount++;
                    moneyForSweaters += 15;
                }
            }
            Console.WriteLine($"Number of adults: {adultsCount}");
            Console.WriteLine($"Number of kids: {kidsCount}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}
