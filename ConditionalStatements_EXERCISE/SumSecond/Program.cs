using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRacer = int.Parse(Console.ReadLine());
            int secondtRacer = int.Parse(Console.ReadLine());
            int thirdRacer = int.Parse(Console.ReadLine());

            int firstSum = firstRacer + secondtRacer + thirdRacer;
            int minutes = firstSum / 60;
            int seconds = firstSum % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
