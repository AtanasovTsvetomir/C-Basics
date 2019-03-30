using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLilly_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            int ageMoneyMultiplier = 1;
            double moneySaved = 0;
            int toyCount = 0;  
            
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += (10 * ageMoneyMultiplier) - 1;
                    ageMoneyMultiplier++;
                }
                else
                {
                    toyCount++;
                }
            }
            double totalMoney = moneySaved + (toyCount * priceOfToy);
            double diff = Math.Abs(totalMoney - priceOfWashingMachine);

            if (totalMoney >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
