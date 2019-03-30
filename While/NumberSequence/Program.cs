using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            while ((command = Console.ReadLine()) != "END")
            {
                int number = int.Parse(command);
                if ( number < minNumber)
                {
                    minNumber = number;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
