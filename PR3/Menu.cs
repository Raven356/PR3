using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class Menu
    {

        public void ChooseCollection()
        {
            CollectionCreater creator;
            while (true)
            {
                try
                {
                    Console.WriteLine("Choose List or array L/A?");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "L":
                            creator = new ListCreator();
                            creator.AddCardToCollection();
                            break;
                        case "A":
                            creator = new ArrayCreator();
                            creator.AddCardToCollection();
                            break;
                        default:
                            throw new ArgumentException("Wrong input");
                    }
                }
                catch (Exception e)
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
