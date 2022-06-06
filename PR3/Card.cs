using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class Card
    {
        public int Cost { get; set; }

        public override string ToString()
        {
            return Cost.ToString();
        }
    }
}
