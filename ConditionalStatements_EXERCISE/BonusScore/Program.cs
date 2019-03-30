using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дадено е цяло число - брой точки.Върху него се начисляват бонус точки по правилата, описани по-долу.Да
//се напише програма, която пресмята бонус точките за това число и общия брой точки с бонусите.
// Ако числото е до 100 включително, бонус точките са 5.
// Ако числото е по-голямо от 100, бонус точките са 20% от числото.
// Ако числото е по-голямо от 1000, бонус точките са 10% от числото.
// Допълнителни бонус точки (начисляват се отделно от предходните):
//o За четно число  + 1 т.
//o За число, което завършва на 5  + 2 т.

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double sumOfBonusScore = 0;
            double points = 0;
            double totalSum = 0;
            double totalPointsSum = 0;
            double twentyPercent = 0.20 * number;
            double tenPercent = 0.10 * number;

            if (number <= 100)
            {
                sumOfBonusScore += 5;
            }
            else if ((number > 100) && (number < 1000 ))
            {
                sumOfBonusScore += twentyPercent;
            }
            else if (number >= 1000)
            {
                sumOfBonusScore += tenPercent;
            }
            if (number % 2 == 0)
            {
                points += 1;
            }
            else if (number % 10 == 5)
            {
                points += 2;
            }

            totalPointsSum = sumOfBonusScore + points;
            totalSum = totalPointsSum + number;

            Console.WriteLine(totalPointsSum);
            Console.WriteLine(totalSum);
        }
    }
}
