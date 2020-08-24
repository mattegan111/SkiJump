using System.Collections.Generic;

namespace SkiJump
{
    public class Round : IRound
    {
        public List<IContestant> ListContestants { get; set; }

        public Round(List<IContestant> listContestants)
        {
            ListContestants = listContestants;
        }
    }
}