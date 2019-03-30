using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketPriceForGoing = double.Parse(Console.ReadLine());
            double ticketPriceForReturn = double.Parse(Console.ReadLine());
            double ticketPriceForMatch = double.Parse(Console.ReadLine());
            int matchCounter = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());

            double discountInPercent = discount / 100;
            double sumForFlying = (ticketPriceForGoing + ticketPriceForReturn )* 6;
            double sumWithDiscount = sumForFlying - (discountInPercent * sumForFlying);
            double sumForMatchTicket = 6 * (ticketPriceForMatch * matchCounter);
            double totalSum = sumWithDiscount + sumForMatchTicket;
            double totalSumForOneFriend = totalSum  / 6;

            Console.WriteLine($"Total sum: {totalSum:F2} lv.");
            Console.WriteLine($"Each friend has to pay {totalSumForOneFriend:f2} lv.");
        
        }
    }
}
 