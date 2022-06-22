using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PR3
{
    class ArrayCardCollection<T> : ICardCollection<T>
    {
        readonly Array<T> _array = new Array<T>();
        public void AddElement(T data)
        {
            _array.Add(data);
        }

        public bool CheckIsElementExists(T data)
        {
            return _array.Contains(data);
        }

        public int CountElements()
        {
            return _array.Count();
        }
    }
}
