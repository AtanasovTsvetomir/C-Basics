using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char lowerBounds = char.Parse(Console.ReadLine());
            char upperBounds = char.Parse(Console.ReadLine());
            char except = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = lowerBounds; i <= upperBounds; i++)
            {
                for (char j = lowerBounds; j <= upperBounds; j++)
                {
                    for (char k = lowerBounds; k <= upperBounds; k++)
                    {
                        if (i != except && j != except && k != except)
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
