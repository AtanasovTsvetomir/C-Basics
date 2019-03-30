using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ChallengeTheWeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            int manCount = int.Parse(Console.ReadLine());
            int womenCount = int.Parse(Console.ReadLine());
            int tableCount = int.Parse(Console.ReadLine());
            int tableCounter = 0;

            for (int i = 1; i <= manCount; i++)
            {
                for (int j = 1; j <= womenCount; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    tableCounter++;
                    if (tableCounter >= tableCount)
                    {
                        return;
                    }
                }
            }
        }
    }
}
