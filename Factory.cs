using System.Collections.Generic;

namespace SkiJump
{
    public class Factory
    {
        public static IContestant CreateContestant()
        {
            return new Contestant();
        }
        public static IRound CreateRound(List<IContestant> listContestants)
        {
            return new Round(listContestants);
        }
        public static IRoundCount CreateRoundCount()
        {
            return new RoundCount();
        }
        public static IRoundOrder CreateRoundOrder()
        {
            return new RoundOrder();
        }
        public static IRoundScores CreateRoundScores()
        {
            return new RoundScores();
        }

    }
}