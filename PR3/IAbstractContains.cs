using System;
using System.Collections.Generic;
using System.Text;

namespace PR3
{
    interface IAbstractContains<T>
    {
        public bool Contains(T data);
    }
}
