using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SchoolSuplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencilCount = int.Parse(Console.ReadLine());
            int markerCount = int.Parse(Console.ReadLine());
            double preparation = double.Parse(Console.ReadLine());
            double reduction = double.Parse(Console.ReadLine());

            double priceForPencil = pencilCount * 5.80;
            double priceForMarkers = markerCount * 7.20;
            double priceForPreparation = preparation * 1.20;
            double sum = priceForMarkers + priceForPencil + priceForPreparation;
            double percentReduction = reduction / 100;
            double total = sum - (percentReduction * sum);
            Console.WriteLine($"{total:f3}");
        }
    }
}
