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
            double preparationCount = double.Parse(Console.ReadLine());
            double percentCount = double.Parse(Console.ReadLine());

            double pencil = 5.80;
            double marker = 7.20;
            double preparation = 1.20;

            double sum = (pencilCount * pencil) + (markerCount * marker) + (preparationCount * preparation);
            double percent = percentCount / 100;
            double totalSum = sum - (percent * sum);

            Console.WriteLine($"{totalSum:f3}");
        }
    }
}
