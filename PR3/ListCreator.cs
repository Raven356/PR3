using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class ListCreator : CollectionCreater
    {
        public override ICardCollection<Card> CreateCollection()
        {
            return new ListCardCollection<Card>();
        }
    }
}
