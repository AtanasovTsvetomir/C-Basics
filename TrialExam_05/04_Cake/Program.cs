using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widhtCake = int.Parse(Console.ReadLine());
            int legnghtCake = int.Parse(Console.ReadLine());

            int cakeArea = widhtCake * legnghtCake;
            int piecesArea = 1 * 1;
            int pieces = cakeArea / piecesArea;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                pieces -= int.Parse(command);

                if (pieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{pieces} pieces are left.");
        }
    }
}
