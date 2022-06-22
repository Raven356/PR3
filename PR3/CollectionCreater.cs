using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    abstract class CollectionCreater
    {
        public abstract ICardCollection<Card> CreateCollection();

        public void AddCardToCollection()
        {
            var collection = CreateCollection();
            new AddCard().AddCardToChoosedCollection(collection);
        }
    }
}
