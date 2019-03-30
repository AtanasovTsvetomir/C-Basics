using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeadingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numberOfRows = int.Parse(Console.ReadLine());
            int oddSeats = int.Parse(Console.ReadLine());
            int evenSeats = oddSeats + 2;
            int seatCounter = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= numberOfRows; row++)
                {
                    if (row % 2 == 0)
                    {
                        for (char seat = 'a'; seat < evenSeats + 97; seat++)
                        {
                            Console.WriteLine($"{sector}{row}{seat}");
                            seatCounter++;
                        }
                    }
                    else
                    {
                        for (char seat = 'a'; seat < oddSeats + 97; seat++)
                        {
                            Console.WriteLine($"{sector}{row}{seat}");
                            seatCounter++;
                        }
                    }
                }
                numberOfRows++;
            }
            Console.WriteLine(seatCounter);
        }
    }
}
