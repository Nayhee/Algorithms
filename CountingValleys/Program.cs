using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountingValleys(int steps, string path)
            {
                var valleys = 0;
                var location = 0;
                for (var i = 0; i < steps; i++)
                {
                    if (path[i] == 'D')
                    {
                        location--;
                    }
                    else
                    {
                        if (location == -1)
                        {
                            valleys++;
                        }
                        location++;
                    }
                };
                return valleys;
            }
        }
    }
}
