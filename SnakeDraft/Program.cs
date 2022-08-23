using System;
using System.Collections.Generic;

namespace SnakeDraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snakeDraftPicks(int draftSpot, int numTeams)
            {
                var numRounds = 16;

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
                return picks;
            }

            var ds = 1;
            var nt = 10;
            var answer = snakeDraftPicks(ds, nt);
            foreach (int pick in answer)
            {
                Console.WriteLine(pick);
            }
        }
    }
}
