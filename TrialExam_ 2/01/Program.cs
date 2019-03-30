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
            int sectorCounter = int.Parse(Console.ReadLine());
            int kapacityOfStadium = int.Parse(Console.ReadLine());
            double priceForTicket = double.Parse(Console.ReadLine());

            double income = (kapacityOfStadium * priceForTicket) / sectorCounter;
            double totalIncome = kapacityOfStadium * priceForTicket;
            double diffrence = totalIncome - (0.75 * income);
            double moneyForCharity = diffrence / 8;
            

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
