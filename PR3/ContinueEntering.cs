using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class ContinueEntering
    {
        public bool ContinueEnteringVal(string text)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"{text}? Y/N   ");
                    string input = Console.ReadLine();
                    if (!input.Equals("N") && !input.Equals("Y"))
                        throw new ArgumentException("Wrong input");
                    return input.Equals("Y");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
