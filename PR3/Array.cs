using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PR3
{
    class Array<T>:IAbstractAdd<T>, IAbstractContains<T>, IAbstractCount<T>
    {
        private T[] _array = new T[0];

        public void Add(T data)
        {
            T[] oldArray = new T[0];
            if(_array.Length != 0)
            {
                oldArray = new T[_array.Length];
                oldArray = Copy(_array, oldArray);
            }

            _array = new T[_array.Length + 1];

            if(oldArray.Length != 0)
                _array = Copy(oldArray, _array);
            _array[^1] = data;
        }

        public bool Contains(T data)
        {
            return _array.Count(x => x.ToString().Equals(data.ToString())) == 4;
        }

        public int Count()
        {
            return _array.Length;
        }

        private T[] Copy(T[] oldArray, T[] newArray) {
            for(int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }
            return newArray;
        }
    }
}
