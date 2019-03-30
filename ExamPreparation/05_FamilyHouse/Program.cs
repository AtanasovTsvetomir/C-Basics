using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FamilyHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounths = int.Parse(Console.ReadLine());
            double moneyForElectric = 0.0;
            double moneyForWater = mounths * 20;
            double moneyForInternet = mounths * 15;
            double moneyForOther = 0.0;
            double total = 0.0;
            for (int i = 0; i < mounths; i++)
            {
                double electric = double.Parse(Console.ReadLine());
                moneyForElectric += electric;
                moneyForOther = (electric + 20 + 15);
                total += moneyForOther + (moneyForOther * 0.20);

            }
            double average = (moneyForElectric + moneyForInternet + total + moneyForWater) / mounths;
            Console.WriteLine($"Electricity: {moneyForElectric:f2} lv");
            Console.WriteLine($"Water: {moneyForWater:f2} lv");
            Console.WriteLine($"Internet: {moneyForInternet:f2} lv");
            Console.WriteLine($"Other: {total:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
