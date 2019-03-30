using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPause = int.Parse(Console.ReadLine());
            double priceForOnePart = double.Parse(Console.ReadLine());
            double priceForOneProgram = double.Parse(Console.ReadLine());
            double priceForCoffe = double.Parse(Console.ReadLine());

            int pause = timeForPause - 15;
            double total = (3 * priceForOnePart) + (2 * priceForOneProgram) + priceForCoffe;

            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"{pause}");
        }
    }
}
