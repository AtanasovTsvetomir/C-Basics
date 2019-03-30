using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForEat = double.Parse(Console.ReadLine());
            double moneyForSuvenirs = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double firstDayInHotel = moneyForHotel - (0.10 * moneyForHotel);
            double secondDayInHotel = moneyForHotel - (0.15 * moneyForHotel);
            double thirdDayInHotel = moneyForHotel - (0.20 * moneyForHotel);

            double priceForGas = 420 / (100 / (7 * 1.85));
            double totalMoneyForHotel = firstDayInHotel + secondDayInHotel + thirdDayInHotel;
            double priceForSuvenirsAndEat = (3 * moneyForEat) + (3 * moneyForSuvenirs);

            double totalSum = priceForGas + priceForSuvenirsAndEat + totalMoneyForHotel;

            Console.WriteLine($"Money Inneeded: {totalSum:f2}");
        }
    }
}
