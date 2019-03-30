using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numToPrint = 1;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (numToPrint > num)
                    {
                        return;
                    }
                    Console.Write($"{numToPrint} ");
                    numToPrint++;
                }
                Console.WriteLine();
            }
        }
    }
}
