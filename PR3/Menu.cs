using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class Menu
    {

        public void ChooseFactory()
        {
            ArrayCardFactory<Card> arrayCardFactory;
            ListCardFactory<Card> listCardFactory;
            while (true)
            {
                try
                {
                    Console.WriteLine("Choose List or array L/A?");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "L":
                            listCardFactory = new ListCardFactory<Card>();
                            new AddCard().AddCardToChoosedCollection(listCardFactory);
                            break;
                        case "A":
                            arrayCardFactory = new ArrayCardFactory<Card>();
                            new AddCard().AddCardToChoosedCollection(arrayCardFactory);
                            break;
                        default:
                            throw new ArgumentException("Wrong input");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (!new ContinueEntering().ContinueEnteringVal("Choose another type"))
                {
                    return;
                }
            }

        }
    }
}
