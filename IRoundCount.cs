using System;
using System.Collections.Generic;
using System.Text;

namespace SkiJump
{
    public interface IRoundCount
    {
        public int Count { get; set; }
        public void Counter();
    }
}
