using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OwnBuisness
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int computer = 1 * 1 * 1;
            int Area = width * lenght * height;
            int total = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    break;
                }

                total += int.Parse(command);

                if (total >= Area)
                {
                    break;
                }
            }
            double left = Math.Abs(Area - total);

            if (Area >= total)
            {
                Console.WriteLine($"{left} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {left} Cubic meters more.");
            }
        }
    }
}
