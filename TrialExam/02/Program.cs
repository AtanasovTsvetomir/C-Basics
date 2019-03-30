using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double widhtOfShip = double.Parse(Console.ReadLine());
            double lenghtOfShip = double.Parse(Console.ReadLine());
            double heightOfShip = double.Parse(Console.ReadLine());
            double avgLenghttOfMan = double.Parse(Console.ReadLine());

            double manNeededPlace = (avgLenghttOfMan + 0.40) * 2 * 2;

            double ShipPlace = widhtOfShip * lenghtOfShip * heightOfShip;

            double Astrounafts = ShipPlace / manNeededPlace;

            if ((Astrounafts > 3) && (Astrounafts < 10))
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(Astrounafts)} astronauts.");
            }
            else if (Astrounafts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (Astrounafts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
