using System;

namespace SkiJump
{
    public class RoundOrder : IRoundOrder
    {
        public void Order(IRound round)
        {
            round.ListContestants.Sort((x, y) => x.Score.CompareTo(y.Score));

            Console.WriteLine("Order of jumpers: ");

            for (var i = 0; i < round.ListContestants.Count; i++)
            {
                Console.WriteLine("{0}. {1} ({2} scored)", i + 1, round.ListContestants[i].Name, round.ListContestants[i].Score);
            }
        }
    }
}