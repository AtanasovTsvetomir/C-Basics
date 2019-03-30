using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            string winnersName = string.Empty;
            while (input != "STOP")
            {
                int sumOfLetters = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    sumOfLetters += input[i];
                }
                if (max < sumOfLetters)
                {
                    max = sumOfLetters;
                    winnersName = input;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnersName} - {max}!");
        }
    }
}
