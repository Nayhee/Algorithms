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
                var elevation = 0;
                for (var i = 0; i < steps; i++)
                {
                    if (path[i] == 'D')
                    {
                        elevation--;
                    }
                    else
                    {
                        if (elevation == -1)
                        {
                            valleys++;
                        }
                        elevation++;
                    }
                };
                return valleys;
            }
        }
    }
}
