using System;
using System.Collections.Generic;

namespace SnakeDraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var draftSpot = 12;
            var numTeams = 12;
            var numRounds = 16;

            snakeDraftPicks(draftSpot, numTeams, numRounds);
        }

        static void snakeDraftPicks(int draftSpot, int numTeams, int numRounds)
        {
            List<int> picks = new List<int>();

            for (int round = 1; round <= numRounds; round++)
            {
                int draftPick;

                if (round % 2 == 0)
                    draftPick = (round * numTeams) - draftSpot + 1;

                else
                    draftPick = ((round - 1) * numTeams) + draftSpot;

                picks.Add(draftPick);
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Draft Picks");
            Console.WriteLine("----------------");

            for (int i = 0; i < picks.Count; i++)
            {
                var pick = picks[i];
                var j = i + 1;
                Console.WriteLine($"{j}) {pick}");
            }
        }
    }
}
