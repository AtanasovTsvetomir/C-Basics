using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SchoolTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int leftEat = int.Parse(Console.ReadLine());
            double eatPerDayForFirstDog = double.Parse(Console.ReadLine());
            double eatPerDayForSecondDog = double.Parse(Console.ReadLine());
            double eatPerDayForThirdDog = double.Parse(Console.ReadLine());

            double eatInneeded = (eatPerDayForFirstDog + eatPerDayForSecondDog + eatPerDayForThirdDog) * dayCount;
            double eatLeft = Math.Abs(leftEat - eatInneeded);

            if (leftEat >= eatInneeded)
            {
                Console.WriteLine($"{Math.Floor(eatLeft)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(eatLeft)} more kilos of food are needed.");
            }
        }
    }
}
