using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    class ListCardFactory<T> : IAbstractCardFactory<T>
    {
        readonly LinkedList<T> _linkedList = new LinkedList<T>();
        public void AddElement(T data)
        {
            _linkedList.Add(data);
        }

        public bool CheckIsElementExists(T data)
        {
            return _linkedList.Contains(data);
        }

        public int CountElements()
        {
            return _linkedList.Count();
        }
    }
}
