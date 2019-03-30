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
            double priceForBaklava = double.Parse(Console.ReadLine());
            double priceForMuffins = double.Parse(Console.ReadLine());
            double shtolenKilograms = double.Parse(Console.ReadLine());
            double bonbonsKilograms = double.Parse(Console.ReadLine());
            int biscuitsKilograms = int.Parse(Console.ReadLine());

            double shtolen = priceForBaklava + (0.60 * priceForBaklava);
            double moneyForShtolen = shtolen * shtolenKilograms;
            double bonbons = priceForMuffins + (0.80 * priceForMuffins);
            double moneyForBonbons = bonbons * bonbonsKilograms;
            double priceForBiscuits = biscuitsKilograms * 7.50;
            double total = moneyForShtolen + moneyForBonbons + priceForBiscuits;

            Console.WriteLine($"{total:f2}");
        }
    }
}
