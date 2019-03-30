using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string operations = Console.ReadLine();

            if (operations == "+")
            {
                double total = firstNumber + secondNumber;
                Console.WriteLine($"{firstNumber} + {secondNumber} = {total} - even");
            }
            else if (operations == "-")
            {
                double total = firstNumber - secondNumber;
                Console.WriteLine($"{firstNumber} - {secondNumber} = {total} - odd");
            }
            else if (operations == "*")
            {
                double total = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} * {secondNumber} = {total} - odd");
            }
            else if (operations == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    double total = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {total:f2}");
                }
            }
            else if (operations == "%")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    double total = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {total}");
                }
            }
        }
    }
}
