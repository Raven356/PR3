using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class ArrayCreator : CollectionCreater
    {
        public override ICardCollection<Card> CreateCollection()
        {
            return new ArrayCardCollection<Card>();
        }
    }
}
