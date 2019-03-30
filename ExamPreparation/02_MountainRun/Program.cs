using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double georgiNeededToClimbUp = distance * timeInSeconds;
            double slow = Math.Floor((distance / 50)) * 30;
            double totalTime = georgiNeededToClimbUp + slow;
            double timeLeft = Math.Abs(totalTime - record);

            if (totalTime < record)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {timeLeft:F2} seconds slower.");
            }
        }
    }
}
