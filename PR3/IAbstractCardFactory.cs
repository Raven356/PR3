using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    interface IAbstractCardFactory<T>
    {
        public void AddElement(T data);
        public int CountElements();
        public bool CheckIsElementExists(T data);
    }
}
