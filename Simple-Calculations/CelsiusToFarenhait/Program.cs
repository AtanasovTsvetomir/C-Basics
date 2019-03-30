using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFarenhait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input C: ");
            double c = double.Parse(Console.ReadLine());
            

            double CtoF =  c * 1.8 + 32;

            Console.WriteLine($"{CtoF:F2}");
        }
    }
}
