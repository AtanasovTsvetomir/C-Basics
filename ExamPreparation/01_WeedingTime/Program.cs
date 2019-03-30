using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WeedingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double waterQuantity = double.Parse(Console.ReadLine());
            double weinQuantity = double.Parse(Console.ReadLine());
            double champainQuantity = double.Parse(Console.ReadLine());
            double whiskyQuantity = double.Parse(Console.ReadLine());

            double champainPrice = whiskyPrice * 0.50;
            double weinPrice = champainPrice * 0.40;
            double waterPrice = champainPrice * 0.10;
            double total = (whiskyPrice * whiskyQuantity) + (waterPrice * waterQuantity) + (weinPrice * weinQuantity) + (champainPrice * champainQuantity);
            Console.WriteLine($"{total:f2}");

        }
    }
}
