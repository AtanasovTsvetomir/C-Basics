using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomWidht = int.Parse(Console.ReadLine());
            int roomLenght = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());

            int roomArea = roomHeight * roomLenght * roomWidht;

            string command = Console.ReadLine();

            int currentCapacity = 0;

            while (command != "Done" && roomArea > currentCapacity)
            {
                int boxes = int.Parse(command);
                currentCapacity += boxes;
                if (command == "Done")
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (roomArea < currentCapacity)
            {
                Console.WriteLine($"No more free space! You need {currentCapacity - roomArea} Cubic meters more.");
            }
            else 
            {
                Console.WriteLine($"{roomArea - currentCapacity} Cubic meters left.");
            }
        }
    }
}
