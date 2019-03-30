using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMan = int.Parse(Console.ReadLine());
            int countOfWomen = int.Parse(Console.ReadLine());
            int totalAmountOfTables = int.Parse(Console.ReadLine());

            int occupitedTable = 0;

            for (int man = 1; man <= countOfMan; man++)
            {
                for (int women = 1; women <= countOfWomen; women++)
                {
                    if (occupitedTable < totalAmountOfTables)
                    {
                        Console.Write($"({man} <-> {women}) ");
                    }
                    occupitedTable++;
                }
            }
        }
    }
}
