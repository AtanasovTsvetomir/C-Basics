using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Morning")
            {
                if ((gradus >= 10) && (gradus <= 18))
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Sweatshirt and Sneakers.");
                }
                else if ((gradus > 18) && (gradus <= 24))
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if (gradus >= 25)
                {
                    Console.WriteLine($"It's {gradus} degrees, get your T-Shirt and Sandals.");
                }
            }
            else if (day == "Afternoon")
            {
                if ((gradus >= 10) && (gradus <= 18))
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if ((gradus > 18) && (gradus <= 24))
                {
                    Console.WriteLine($"It's {gradus} degrees, get your T-Shirt and Sandals.");
                }
                else if (gradus >= 25)
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Swim Suit and Barefoot.");
                }
            }
            else if (day == "Evening")
            {
                if ((gradus >= 10) && (gradus <= 18))
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if ((gradus > 18) && (gradus <= 24))
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if (gradus >= 25)
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
