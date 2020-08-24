using System;
using System.Collections.Generic;
using System.Text;

namespace SkiJump
{
    public interface IContestant
    {
        string Name { get; set; }
        int Score { get; set; }
    }
}
