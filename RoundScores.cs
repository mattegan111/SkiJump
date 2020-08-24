using System;
using System.Collections.Generic;

namespace SkiJump
{
    public class RoundScores : IRoundScores
    {
        public void Scores(IRound round)
        {
            var random = new Random();
            var judgePoints = new List<int>();

            Console.WriteLine("Round results:");

            foreach (var t in round.ListContestants)
            {
                var jumpLength = random.Next(60, 121);

                for (var i = 0; i < 5; i++)
                {
                    judgePoints.Add(random.Next(10, 21));
                }

                Console.WriteLine("{0}  length: {1}  judge votes: {2}, {3}, {4}, {5}, {6}", t.Name, jumpLength, judgePoints[0], judgePoints[1], judgePoints[2], judgePoints[3], judgePoints[4]);

                judgePoints.Sort();
                t.Score += jumpLength + judgePoints[1] + judgePoints[2] + judgePoints[3];
            }
        }
    }
}