using System;
using System.Collections.Generic;

namespace SnakeDraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> userResponses = GetUserInput();
            CalculateSnakeDraftPicks(userResponses[0], userResponses[1], userResponses[2]);
        }

        static List<int> GetUserInput()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Nayhee's Draft Picks Calculator ");
            Console.WriteLine("----------------------------------");

            List<int> userResponses = new List<int>();

            Console.WriteLine("What draft spot do you have?");
            string userDraftSpot = Console.ReadLine();
            int draftSpot = int.Parse(userDraftSpot);
            userResponses.Add(draftSpot);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("How many teams are in your league?");
            string userNumTeams = Console.ReadLine();
            int numTeams = int.Parse(userNumTeams);
            userResponses.Add(numTeams);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("How many rounds in your draft?");
            string userNumRounds = Console.ReadLine();
            int numRounds = int.Parse(userNumRounds);
            userResponses.Add(numRounds);

            return userResponses;
        }

        static void CalculateSnakeDraftPicks(int draftSpot, int numTeams, int numRounds)
        {
            List<int> picks = new List<int>();

            for (int round = 1; round <= numRounds; round++)
            {
                int draftPick;

                if (round % 2 == 0)
                {
                    draftPick = (round * numTeams) - draftSpot + 1;
                }

                else
                {
                    draftPick = ((round - 1) * numTeams) + draftSpot;
                }
                picks.Add(draftPick);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Draft Picks: ");

            for (int i = 0; i < picks.Count; i++)
            {
                var pick = picks[i];
                var j = i + 1;
                Console.WriteLine($"{j}) {pick}");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
