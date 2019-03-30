using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForMaidenParty = double.Parse(Console.ReadLine());
            int loveMessageCount = int.Parse(Console.ReadLine());
            int rossesCount = int.Parse(Console.ReadLine());
            int keychainCount = int.Parse(Console.ReadLine());
            int caricaturCount = int.Parse(Console.ReadLine());
            int luckySurpriseCount = int.Parse(Console.ReadLine());

            double priceForLoveMessage = loveMessageCount * 0.60;
            double priceForRosses = rossesCount * 7.20;
            double priceForKeychain = keychainCount * 3.60;
            double priceForCaricatur = caricaturCount * 18.20;
            double priceForLuckySurprise = luckySurpriseCount * 22;

            int totalOrder = loveMessageCount + rossesCount + keychainCount + caricaturCount + luckySurpriseCount;
            double sum = priceForCaricatur + priceForRosses + priceForKeychain + priceForLoveMessage + priceForLuckySurprise;
            double total = 0.0;
            double moneyLeft = 0.0;
            double totalSum = 0.0;
            if (totalOrder >= 25)
            {
                total = sum - (0.35 * sum);
                totalSum = total - (0.10 * total);
                moneyLeft = Math.Abs(totalSum - priceForMaidenParty);
                if (totalSum >= priceForMaidenParty)
                {
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
                }
            }
            else
            {
                totalSum = sum - (0.10 * sum);
                moneyLeft = Math.Abs(priceForMaidenParty - totalSum);
                if (totalSum >= priceForMaidenParty)
                {
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {moneyLeft:f2} lv needed.");
                }
            }

        }
    }
}
