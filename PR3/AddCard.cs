using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PR3
{
    class AddCard
    {
        public void AddCardToChoosedCollection(ICardCollection<Card> abstractCardFactory)
        {
            while (true)
            {

                int[] correctCost = new int[] {2,3,4,6,7,8,9,10,11 };

                try
                {
                    Card card = new Card();
                    Console.WriteLine("Enter cost of the card you want to add");
                    card.Cost = int.Parse(Console.ReadLine());

                    if (!correctCost.Select(x => x).Contains(card.Cost))
                    {
                        throw new ArgumentException("Wrong cost of card");
                    }
                    if (abstractCardFactory.CheckIsElementExists(card) || abstractCardFactory.CountElements() == 36)
                    {
                        throw new ArgumentException("Card allready exists or deck is full");
                    }
                    abstractCardFactory.AddElement(card);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (!new ContinueEntering().ContinueEnteringVal("Continue"))
                {
                    return;
                }
            }
        }


    }
}
