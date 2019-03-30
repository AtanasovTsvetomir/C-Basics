using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int firstNumber = number % 10;
            int secondNumber = (number / 10) % 10;
            int thirdNumer = (number / 100) % 10;
            int sum = 0;
            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    for (int l = 1; l <= thirdNumer; l++)
                    {
                        if (firstNumber > 0 && secondNumber > 0 && thirdNumer > 0)
                        {
                            sum = i * j * l;
                            Console.WriteLine($"{i} * {j} * {l} = {sum};");
                        }
                    }
                }
            } 
        }
    }
}
