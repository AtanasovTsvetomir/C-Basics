using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WeedingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int guestBudget = guestCount * 20;
            double moneyleft = Math.Abs(budget - guestBudget);
            double moneyForFireworks = moneyleft * 0.40;
            double moneyForDonations = moneyleft - (moneyleft * 0.40);
            if (budget >= guestBudget)
            {
                Console.WriteLine($"Yes! {Math.Round(moneyForFireworks)} lv are for fireworks and {Math.Round(moneyForDonations)} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(moneyleft)} lv more.");
            }
        }
    }
}
