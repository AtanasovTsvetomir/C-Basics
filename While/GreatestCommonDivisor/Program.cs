using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result = 0;

            if (firstNumber != secondNumber)
            {
                while ((firstNumber != 0) && (secondNumber != 0))
                {
                    int oldFirstNumber = firstNumber;
                    firstNumber = firstNumber % secondNumber;
                    secondNumber = secondNumber % oldFirstNumber;
                }

                if (firstNumber == 0)
                {
                    Console.WriteLine(secondNumber);
                }
                else
                {
                    Console.WriteLine(firstNumber);
                }
            }
            else
            {
                Console.WriteLine(firstNumber);
            }
        }
    }
}
