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
            string bestPlayer = string.Empty;
            int bestScore = 0;
            string nameOfPlayer = string.Empty;
            int goals = 0;
            while (true)
            {
                nameOfPlayer = Console.ReadLine();
                if (nameOfPlayer == "END")
                {
                    break;
                }
                else if (goals >= 10)
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
                if (goals > bestScore)
                {
                    bestScore = goals;
                    bestPlayer = nameOfPlayer;
                }
            }
            if (bestScore >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {bestScore} goals.");

            }
        }
    }
}
