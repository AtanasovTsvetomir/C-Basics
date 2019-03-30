using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int fishForDay = int.Parse(Console.ReadLine());
            string fishName = string.Empty;
            double fishKg = 0;
            int fishes = 0;
            double fishPrice = 0;
            int counter = 0;
            double sum = 0;
            for (int i = 1; i <= fishForDay; i++)
            {
                fishName = Console.ReadLine();

                if (fishName == "Stop")
                {
                    break;
                }
                fishes++;

                fishKg = double.Parse(Console.ReadLine());
                fishPrice = 0;

                for (int j = 0; j < fishName.Length; j++)
                {
                    char symbol = fishName[j];
                    fishPrice += symbol;
                }

                counter++;

                if (counter == 3)
                {
                    sum += (fishPrice / fishKg);
                    counter = 0;
                }
                else if (counter < 3)
                {
                    sum -= (fishPrice / fishKg);
                }
            }
            if (fishName == "Stop")
            {
                if (sum < 0)
                {
                    Console.WriteLine($"Lyubo lost {Math.Abs(sum):f2} leva today.");
                }
                else
                {
                    Console.WriteLine($"Lyubo's profit from {fishes} fishes is {sum:f2} leva.");
                }
            }
            else
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
                if (sum < 0)
                {
                    Console.WriteLine($"Lyubo lost {Math.Abs(sum):f2} leva today.");
                }
                else
                {
                    Console.WriteLine($"Lyubo's profit from {fishes} fishes is {sum:f2} leva.");
                }
            }
        }
    }
}

