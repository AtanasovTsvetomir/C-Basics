using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input R: ");
            double r = double.Parse(Console.ReadLine());

            double rTog = r * 57.29578;

            Console.WriteLine(Math.Round(rTog));
        }
    }
}
