using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_WeedingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());
            int oddSeats = int.Parse(Console.ReadLine());

            int evenSeats = oddSeats + 2;
            int seatCounter = 0;

            for (char sector = 'A';sector  <= lastSector;sector++)
            {
                for (int rows = 1; rows <= rowsCount; rows++)
                {
                    if (rows % 2 == 0)
                    {
                        for (char seats = 'a'; seats < evenSeats + 97; seats++)
                        {
                            Console.WriteLine($"{sector}{rows}{seats}");
                            seatCounter++;
                        }
                    }
                    else
                    {
                        for (char seats = 'a'; seats < oddSeats + 97; seats++)
                        {
                            Console.WriteLine($"{sector}{rows}{seats}");
                            seatCounter++;
                        }
                    }
                }
                rowsCount++;
            }
            Console.WriteLine(seatCounter);
        }
    }
}
