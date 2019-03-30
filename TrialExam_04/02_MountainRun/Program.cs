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
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetters = double.Parse(Console.ReadLine());
            double timeInSecondInneedFor1Metter = double.Parse(Console.ReadLine());

            double georgiMetterInSecond = distanceInMetters * timeInSecondInneedFor1Metter;
            double georgiSecondWithSlow = Math.Floor(distanceInMetters / 50) * 30;
            double georgiTimes = georgiMetterInSecond + georgiSecondWithSlow;
            double georgiInneededTime = Math.Abs(recordInSeconds - georgiTimes);

            if (georgiTimes < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {georgiTimes:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {georgiInneededTime:f2} seconds slower.");
            }
        
        }
    }
}
