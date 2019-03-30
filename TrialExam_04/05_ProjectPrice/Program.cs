using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ProjectPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyPrize = double.Parse(Console.ReadLine());
            double sum = 0;
            int totalPoints = 0;
            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    int bonusPoints = points * 2;
                    totalPoints += bonusPoints;
                }
                else
                {
                    totalPoints += points;
                }
               
            }
            sum = totalPoints * moneyPrize;
            Console.WriteLine($"The project prize was {sum:f2} lv.");
        }
    }
}
