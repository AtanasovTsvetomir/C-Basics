using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfClub = Console.ReadLine();
            int numberOfPlayedGames = int.Parse(Console.ReadLine());

            double playedMinutes = 0;
            int matchInContinue = 0;
            int matchInPenalty = 0;
            for (int i = 0; i < numberOfPlayedGames; i++)
            {
                int game = int.Parse(Console.ReadLine());

                if (game > 90 && game <= 120)
                {
                    matchInContinue++;
                }
                else if (game > 120)
                {
                    matchInPenalty++;
                }
                playedMinutes += game;
            }
            double averageMinutes = playedMinutes / numberOfPlayedGames;
            Console.WriteLine($"{nameOfClub} has played {playedMinutes} minutes. Average minutes per game: {averageMinutes:F2}");
            Console.WriteLine($"Games with penalties: {matchInPenalty}");
            Console.WriteLine($"Games with additional time: {matchInContinue}");
        }
    }
}
