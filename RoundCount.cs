using System;

namespace SkiJump
{
    public class RoundCount : IRoundCount
    {
        public int Count { get; set; }
        public void Counter()
        {
            Count += 1;
            Console.WriteLine("Round {0}", Count);
        }
    }
}