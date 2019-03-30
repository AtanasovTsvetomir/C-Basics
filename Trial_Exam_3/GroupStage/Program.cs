using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStage
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfClub = Console.ReadLine();
            int numberOfPlayedGames = int.Parse(Console.ReadLine());

            int points = 0;
            int totalScoredGoals = 0;
            int totalReceivedGoals = 0;
            for (int i = 0; i < numberOfPlayedGames; i++)
            {
                int scoredGoals = int.Parse(Console.ReadLine());
                int receivedGoals = int.Parse(Console.ReadLine());

                if (scoredGoals > receivedGoals)
                {
                    points += 3;
                    totalScoredGoals += scoredGoals;
                    totalReceivedGoals += receivedGoals;
                }
                else if (scoredGoals == receivedGoals)
                {
                    points += 1;
                    totalScoredGoals += scoredGoals;
                    totalReceivedGoals += receivedGoals;
                }
                else if (scoredGoals < receivedGoals)
                {
                    totalScoredGoals += scoredGoals;
                    totalReceivedGoals += receivedGoals;
                }
            }
            int totalGoals = totalScoredGoals - totalReceivedGoals;
            if (totalScoredGoals >= totalReceivedGoals)
            {
                Console.WriteLine($"{nameOfClub} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {totalGoals}.");
            }
            else
            {
                Console.WriteLine($"{nameOfClub} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalGoals}.");
            }
        }
    }
}
