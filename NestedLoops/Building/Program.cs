using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int roomPerfFloor = int.Parse(Console.ReadLine());

            for (int floor = numberOfFloors; floor >= 1; floor--)
            {
                for (int roomNumber = 0; roomNumber < roomPerfFloor; roomNumber++)
                {
                    if (floor == numberOfFloors)
                    {
                        Console.Write($"L{floor}{roomNumber} ");
                        continue;
                    }

                    if (floor % 2 == 0)
                    {
                        //ofice
                        Console.Write($"O{floor}{roomNumber} ");
                    }
                    else
                    {
                        //apartaments
                        Console.Write($"A{floor}{roomNumber} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
