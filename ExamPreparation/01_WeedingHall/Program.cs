using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WeedingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtHall = double.Parse(Console.ReadLine());
            double widhtHall = double.Parse(Console.ReadLine());
            double barSide = double.Parse(Console.ReadLine());

            double hallArea = lenghtHall * widhtHall;
            double barArea = barSide * barSide;
            double danceArea = hallArea * 0.19;
            double freePlace = hallArea - barArea - danceArea;
            double guestCount = Math.Ceiling(freePlace / 3.2);
            Console.WriteLine(guestCount);
        }
    }
}
