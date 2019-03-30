using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int fentaziBook = int.Parse(Console.ReadLine());
            int hororBook = int.Parse(Console.ReadLine());
            int romanticBook = int.Parse(Console.ReadLine());

            double moneyLeft = 0.0;
            double total = 0.0;
            double moneyForSeller = 0.0;
            double sum = (fentaziBook * 14.90) + (hororBook * 9.80) + (romanticBook * 4.30);
            double sumWithDDS = sum - (sum * 0.20);

            if (sumWithDDS >= budget)
            {
                sumWithDDS = sumWithDDS - budget;
                moneyForSeller = Math.Floor(sumWithDDS * 0.10);
                moneyLeft = sumWithDDS - moneyForSeller;
                total = budget + moneyLeft;
                Console.WriteLine($"{total:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {moneyForSeller} leva.");
            }
            else
            {
                total = budget - sumWithDDS;
                Console.WriteLine($"{total:f2} money needed.");
            }
        }
    }
}
