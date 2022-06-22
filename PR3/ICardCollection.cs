using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    interface ICardCollection<T>
    {
        void AddElement(T data);
        int CountElements();
        bool CheckIsElementExists(T data);
    }
}
