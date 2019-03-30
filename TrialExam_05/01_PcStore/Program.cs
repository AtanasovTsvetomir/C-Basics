using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PcStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForProcessor = double.Parse(Console.ReadLine());
            double moneyForVideoCard = double.Parse(Console.ReadLine());
            double oneRam = double.Parse(Console.ReadLine());
            double ramCount = double.Parse(Console.ReadLine());
            double reduction = double.Parse(Console.ReadLine());

            double priceForProcessor = moneyForProcessor * 1.57;
            double priceForVideoCard = moneyForVideoCard * 1.57;
            double priceForRam = (oneRam * ramCount) * 1.57;
            double totalForProcessor = priceForProcessor - (reduction * priceForProcessor);
            double totalForVideoCard = priceForVideoCard - (reduction * priceForVideoCard);
            double totalSum = totalForVideoCard + totalForProcessor + priceForRam;
            Console.WriteLine($"Money needed - {totalSum:f2} leva.");
        }
    }
}
